using System.Data;

namespace WorkerService
{
  public class Worker : BackgroundService
  {
    System.Data.SqlClient.SqlConnection conn;

    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
      _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
      Console.WriteLine("Iniciou");

      modChatGuru oChatGuru = new();

      while (!stoppingToken.IsCancellationRequested)
      {
        try
        {
          if (DateTime.Now.Date >= new DateTime(2022,8,31,0,0,0)) 
          {
            if (conn == null)
              conn = new System.Data.SqlClient.SqlConnection("server=192.168.254.220\\SQLEXPRESS;database=Cli28Julho;Connection Timeout=0;uid=sa;pwd=clinica2828");

            if (conn.State != System.Data.ConnectionState.Open)
              conn.Open();

            DataTable oData = null;
            string sSqlText = "";
            string DS_MENSAGEM_MODELO = "";
            string DS_PATH_IMAGEM = "";
            string CD_USUARIO = "";
            string CD_DIALOGO = "";
            bool TP_ATIVO = false;
            string Texto = "";
            string Historico = "";

            int NR_DIA_CONFIRMACAO_AGENDAMENTO = 0;
            int NR_INTERVALO_ENVIO_MENSAGEM = 0;

            sSqlText = "SELECT NR_DIA_CONFIRMACAO_AGENDAMENTO, NR_INTERVALO_ENVIO_MENSAGEM FROM TB_SISTEMA";
            oData = Util.Query(conn, sSqlText);

            NR_DIA_CONFIRMACAO_AGENDAMENTO = Convert.ToInt16(oData.Rows[0]["NR_DIA_CONFIRMACAO_AGENDAMENTO"]);
            NR_INTERVALO_ENVIO_MENSAGEM = Convert.ToInt16(oData.Rows[0]["NR_INTERVALO_ENVIO_MENSAGEM"]);
            
            //modSisVida.MontarEnviar(conn);

            if (DateTime.Now.Hour >= 7)
            {
              sSqlText = "SELECT DISTINCT CVATD.CD_CLINICA_ATENDIMENTO," +
                                         "CVATD.SQ_CLINICA_ATENDIMENTO," +
                                         "CONVERT(CHAR, CVATD.DH_FIM_ATENDIMENTO, 103) DH_FIM_ATENDIMENTO," +
                                         "PESSO.NO_PESSOA," +
                                         "PESSO.SQ_PESSOA," +
                                         "ISNULL(PSCFG.DS_PATH_IMAGEM_MENSAGEM, '') DS_PATH_IMAGEM_MENSAGEM," +
                                         "dbo.FC_Formatar_NUMERO_WHATSAPP(PSTEL.CD_NUMERO) CD_NUMERO," +
                                         "ISNULL(EXAME.QT_EXAMES, 0) QT_EXAMES" +
                         " FROM TB_CLINICA_ATENDIMENTO CVATD" +
                          " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CVATD.ID_PESSOA" +
                          " INNER JOIN(SELECT ID_PESSOA, IC_WHATSAPP, MAX(CD_NUMERO) CD_NUMERO FROM TB_PESSOA_TELEFONE WHERE IC_WHATSAPP = 'S' GROUP BY ID_PESSOA, IC_WHATSAPP) PSTEL ON PSTEL.ID_PESSOA = PESSO.SQ_PESSOA" +
                           " LEFT JOIN TB_HISTORICO HISTO ON HISTO.ID_REGISTRO = CVATD.SQ_CLINICA_ATENDIMENTO" +
                                                       " AND HISTO.ID_OPT_ACAO = 829" +
                           " LEFT JOIN TB_PESSOA_CONFIGURACAO PSCFG ON PSCFG.ID_PESSOA = CVATD.ID_PESSOA_PROFISSIONAL" +
                                                        " AND PSCFG.ID_EMPRESA = 2" +
                           " LEFT JOIN (SELECT ID_CLINICA_ATENDIMENTO, COUNT(*) QT_EXAMES FROM TB_CLINICA_PROCEDIMENTO GROUP BY ID_CLINICA_ATENDIMENTO) EXAME ON EXAME.ID_CLINICA_ATENDIMENTO = CVATD.SQ_CLINICA_ATENDIMENTO" +
                         " WHERE HISTO.SQ_HISTORICO IS NULL" +
                           " AND DATEADD(HOUR, -3, GETDATE()) <= CVATD.DH_FIM_ATENDIMENTO" +
                           " AND CVATD.DH_FIM_ATENDIMENTO <= DATEADD(MINUTE, -" + NR_INTERVALO_ENVIO_MENSAGEM + " , GETDATE())";
              oData = Util.Query(conn, sSqlText);

              foreach (DataRow row in oData.Rows)
              {
                if (!String.IsNullOrEmpty(row["CD_NUMERO"].ToString()))
                {
                  if (Convert.ToInt32(row["QT_EXAMES"]) == 0)
                  {
                    Modelo(conn, "AGRADECA", ref DS_MENSAGEM_MODELO, ref DS_PATH_IMAGEM, ref CD_USUARIO, ref CD_DIALOGO, ref TP_ATIVO);
                    Historico = "Notificação: Mens Agradecimento(SEM Exames)";
                  }
                  else
                  {
                    Modelo(conn, "AGRADECEXM", ref DS_MENSAGEM_MODELO, ref DS_PATH_IMAGEM, ref CD_USUARIO, ref CD_DIALOGO, ref TP_ATIVO);
                    Historico = "Notificação: Mens Agradecimento(COM Exames)";
                  }

                  if (TP_ATIVO)
                  {
                    bool add = VerificarNotificacaoHoje(int.Parse(row["SQ_PESSOA"].ToString()), conn);

                    Texto = DS_MENSAGEM_MODELO;
                    Texto = Texto.Replace("[NomePaciente]", row["NO_PESSOA"].ToString());
                    Texto = Texto.Replace("[DataAtendimento]", row["DH_FIM_ATENDIMENTO"].ToString());

                    bool enviado = await oChatGuru.EnviarAsync(Texto, row["NO_PESSOA"].ToString(), row["CD_NUMERO"].ToString(), "", row["DS_PATH_IMAGEM_MENSAGEM"].ToString(), CD_USUARIO, CD_DIALOGO, add);

                    if (enviado)
                    {
                      GravarNotificacaoHoje(int.Parse(row["SQ_PESSOA"].ToString()), conn);

                      sSqlText = "INSERT INTO TB_HISTORICO (ID_EMPRESA, ID_OPT_PROCESSO, ID_OPT_ACAO, ID_USUARIO, ID_REGISTRO, DT_HISTORICO, DS_HISTORICO, DS_FILTRO, CD_VERSAO_SISTEMA, NO_COMPUTADOR_NOME, CD_HISTORICO, ID_OPT_ERRO)" +
                                 " VALUES (@ID_EMPRESA, @ID_OPT_PROCESSO, @ID_OPT_ACAO, @ID_USUARIO, @ID_REGISTRO, @DT_HISTORICO, @DS_HISTORICO, @DS_FILTRO, @CD_VERSAO_SISTEMA, @NO_COMPUTADOR_NOME, @CD_HISTORICO, @ID_OPT_ERRO)";
                      Util.Executar(conn, sSqlText, new Util.DBParamentro[] { Util.DBParametro_Montar("ID_EMPRESA", 2), /* Praça - Clínica de 28 de Julho */
                                                                        Util.DBParametro_Montar("ID_OPT_PROCESSO", 520 /* Clínica - Atendimento Médico */),
                                                                        Util.DBParametro_Montar("ID_OPT_ACAO", 829 /* Notificado */),
                                                                        Util.DBParametro_Montar("ID_USUARIO", 1),
                                                                        Util.DBParametro_Montar("ID_REGISTRO", row["SQ_CLINICA_ATENDIMENTO"]),
                                                                        Util.DBParametro_Montar("DS_HISTORICO", Historico),
                                                                        Util.DBParametro_Montar("DT_HISTORICO", DateTime.Now, SqlDbType.DateTime),
                                                                        Util.DBParametro_Montar("DS_FILTRO", ""),
                                                                        Util.DBParametro_Montar("CD_VERSAO_SISTEMA", ""),
                                                                        Util.DBParametro_Montar("NO_COMPUTADOR_NOME", ""),
                                                                        Util.DBParametro_Montar("CD_HISTORICO", row["CD_CLINICA_ATENDIMENTO"]),
                                                                        Util.DBParametro_Montar("ID_OPT_ERRO", "")});
                    }

                    Thread.Sleep(1000);
                  }
                }
              }
            }

            if (DateTime.Now.Hour >= 9)
            {
              Modelo(conn, "NIVER", ref DS_MENSAGEM_MODELO, ref DS_PATH_IMAGEM, ref CD_USUARIO, ref CD_DIALOGO, ref TP_ATIVO);

              if (TP_ATIVO)
              {
                sSqlText = "SELECT DISTINCT PESSO.SQ_PESSOA, PESSO.CD_PESSOA, PESSO.NO_PESSOA, dbo.FC_Formatar_NUMERO_WHATSAPP(PSTEL.CD_NUMERO) CD_NUMERO" +
                           " FROM TB_PESSOA PESSO" +
                            " INNER JOIN(SELECT ID_PESSOA, IC_WHATSAPP, MAX(CD_NUMERO) CD_NUMERO FROM TB_PESSOA_TELEFONE WHERE IC_WHATSAPP = 'S' GROUP BY ID_PESSOA, IC_WHATSAPP) PSTEL ON PSTEL.ID_PESSOA = PESSO.SQ_PESSOA" +
                             " LEFT JOIN TB_HISTORICO HISTO ON HISTO.ID_REGISTRO = PESSO.SQ_PESSOA" +
                                                         " AND HISTO.ID_OPT_ACAO = 829" +
                           " WHERE PESSO.DT_NASC_ABERTURA IS NOT NULL" +
                             " AND PESSO.SQ_PESSOA = 14569";
                oData = Util.Query(conn, sSqlText);

                foreach (DataRow row in oData.Rows)
                {
                  if (!String.IsNullOrEmpty(row["CD_NUMERO"].ToString()))
                  {
                    Texto = DS_MENSAGEM_MODELO;
                    Texto = Texto.Replace("[NomePaciente]", row["NO_PESSOA"].ToString());
                    Historico = "Notificação: Mens De Aniversário";

                    if (!String.IsNullOrEmpty(row["CD_NUMERO"].ToString()))
                    {
                      bool add = VerificarNotificacaoHoje(int.Parse(row["SQ_PESSOA"].ToString()), conn);
                      bool enviado = false;

                      try
                      {
                        if (DS_PATH_IMAGEM.Trim() == "")
                        {
                          enviado = await oChatGuru.EnviarAsync(Texto, row["NO_PESSOA"].ToString(), row["CD_NUMERO"].ToString(), "", "", CD_USUARIO, CD_DIALOGO, add);
                        }
                        else
                        {
                          enviado = await oChatGuru.EnviarAsync("", row["NO_PESSOA"].ToString(), row["CD_NUMERO"].ToString(), Texto, DS_PATH_IMAGEM, CD_USUARIO, CD_DIALOGO, add);
                        }
                      }
                      catch (Exception Ex)
                      {
                        var erro = Ex.Message;
                      }

                      if (enviado)
                      {
                        GravarNotificacaoHoje(int.Parse(row["SQ_PESSOA"].ToString()), conn);

                        sSqlText = "INSERT INTO TB_HISTORICO (ID_EMPRESA, ID_OPT_PROCESSO, ID_OPT_ACAO, ID_USUARIO, ID_REGISTRO, DT_HISTORICO, DS_HISTORICO, DS_FILTRO, CD_VERSAO_SISTEMA, NO_COMPUTADOR_NOME, CD_HISTORICO, ID_OPT_ERRO)" +
                                 " VALUES (@ID_EMPRESA, @ID_OPT_PROCESSO, @ID_OPT_ACAO, @ID_USUARIO, @ID_REGISTRO, @DT_HISTORICO, @DS_HISTORICO, @DS_FILTRO, @CD_VERSAO_SISTEMA, @NO_COMPUTADOR_NOME, @CD_HISTORICO, @ID_OPT_ERRO)";
                        Util.Executar(conn, sSqlText, new Util.DBParamentro[] { Util.DBParametro_Montar("ID_EMPRESA", 2), /* Praça - Clínica de 28 de Julho */
                                                                            Util.DBParametro_Montar("ID_OPT_PROCESSO", 488 /* Cadastro - Cadastro de Paciente */),
                                                                            Util.DBParametro_Montar("ID_OPT_ACAO", 829 /* Notificação por WhatsApp */),
                                                                            Util.DBParametro_Montar("ID_USUARIO", 1),
                                                                            Util.DBParametro_Montar("ID_REGISTRO", row["SQ_PESSOA"]),
                                                                            Util.DBParametro_Montar("DS_HISTORICO", Historico),
                                                                            Util.DBParametro_Montar("DT_HISTORICO", DateTime.Now, SqlDbType.DateTime),
                                                                            Util.DBParametro_Montar("DS_FILTRO", ""),
                                                                            Util.DBParametro_Montar("CD_VERSAO_SISTEMA", ""),
                                                                            Util.DBParametro_Montar("NO_COMPUTADOR_NOME", ""),
                                                                            Util.DBParametro_Montar("CD_HISTORICO", row["CD_PESSOA"]),
                                                                            Util.DBParametro_Montar("ID_OPT_ERRO", "")});
                      }
                    }

                    Thread.Sleep(1000);
                  }
                }
              }
            }

            Modelo(conn, "CANCAGENDA", ref DS_MENSAGEM_MODELO, ref DS_PATH_IMAGEM, ref CD_USUARIO, ref CD_DIALOGO, ref TP_ATIVO);

            if (TP_ATIVO)
            {
              sSqlText = "SELECT AGEND.SQ_AGENDAMENTO," +
                                "AGEND.ID_PESSOA," +
                                "AGEND.CD_AGENDAMENTO," +
                                "PESSO.NO_PESSOA," +
                                "PSPRF.NO_PESSOA NO_PESSOA_PROFISSIONAL," +
                                "EMPRE.NO_PESSOA NO_EMPRESA," +
                                "CONVERT(CHAR, AGEND.DH_AGENDAMENTO, 103) DT_AGENDAMENTO," +
                                "CONVERT(CHAR(5), AGEND.DH_AGENDAMENTO, 108) HR_AGENDAMENTO," +
                                "dbo.FC_Formatar_NUMERO_WHATSAPP(PSTEL.CD_NUMERO) CD_NUMERO," +
                                "ISNULL(PSCFG.DS_PATH_IMAGEM_MENSAGEM, '') DS_PATH_IMAGEM_MENSAGEM," +
                                "ENDER.DS_ENDERECO," +
                                "CONSL.NO_CONSULTORIO" +
                         " FROM TB_AGENDAMENTO AGEND" +
                          " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" +
                          " INNER JOIN TB_PESSOA PSPRF ON PSPRF.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" +
                          " INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = AGEND.ID_EMPRESA" +
                          " INNER JOIN TB_OPCAO OPCAO ON OPCAO.SQ_OPCAO = AGEND.ID_OPT_STATUS" +
                                                   " AND OPCAO.CD_OPCAO = 'E'" +
                          " INNER JOIN (SELECT ID_PESSOA, IC_WHATSAPP, MAX(CD_NUMERO) CD_NUMERO FROM TB_PESSOA_TELEFONE WHERE IC_WHATSAPP = 'S' GROUP BY ID_PESSOA, IC_WHATSAPP) PSTEL ON PSTEL.ID_PESSOA = PESSO.SQ_PESSOA" +
                          " INNER JOIN TB_HISTORICO HSTAG ON HSTAG.ID_OPT_PROCESSO = 519" +
                                                       " AND HSTAG.ID_OPT_ACAO = 469" +
                                                       " AND CAST(HSTAG.DT_HISTORICO AS DATE) = CAST(GETDATE() AS DATE)" +
                          " INNER JOIN TB_CANALMARCACAO CNN ON CNN.SQ_CANALMARCACAO = AGEND.ID_CANALMARCACAO" +
                                                      " AND CNN.TP_ENVIAR_NOTIFICACAO_WHATSAPP = 'S'" +
                           " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER ON ENDER.ID_TIPO_ENDERECO = 2" +
                                                               " AND ENDER.ID_PESSOA = AGEND.ID_EMPRESA" +
                           " LEFT JOIN TB_HISTORICO HISTO ON HISTO.ID_REGISTRO = AGEND.SQ_AGENDAMENTO" +
                                                       " AND HISTO.ID_OPT_ACAO = 101" +
                                                       " AND CAST(HISTO.DT_HISTORICO AS DATE) = CAST(GETDATE() AS DATE)" +
                           " LEFT JOIN TB_CONSULTORIO CONSL ON CONSL.SQ_CONSULTORIO = AGEND.ID_CONSULTORIO" +
                           " LEFT JOIN TB_PESSOA_CONFIGURACAO PSCFG ON PSCFG.ID_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" +
                                                        " AND PSCFG.ID_EMPRESA = 2" +
                         " WHERE AGEND.ID_OPT_STATUS IN (38)" +
                           " AND HISTO.SQ_HISTORICO IS NULL";
              oData = Util.Query(conn, sSqlText);

              foreach (DataRow row in oData.Rows)
              {
                Historico = "Notificação: Cancelamento de agendamento";

                if (!String.IsNullOrEmpty(row["CD_NUMERO"].ToString()))
                {
                  bool add = VerificarNotificacaoHoje(int.Parse(row["ID_PESSOA"].ToString()), conn);

                  Texto = DS_MENSAGEM_MODELO;
                  Texto = Texto.Replace("[NomePaciente]", row["NO_PESSOA"].ToString());
                  Texto = Texto.Replace("[DiaAgendamento]", row["DT_AGENDAMENTO"].ToString());
                  Texto = Texto.Replace("[HoraAgendamento]", row["HR_INICIO"].ToString());
                  Texto = Texto.Replace("[Medico]", row["NO_PESSOA_PROFISSIONAL"].ToString());
                  Texto = Texto.Replace("[Unidade]", row["NO_EMPRESA"].ToString());
                  Texto = Texto.Replace("[EnderecoUnidade]", row["DS_ENDERECO"].ToString());
                  Texto = Texto.Replace("[Consultorio]", row["NO_CONSULTORIO"].ToString());

                  bool enviado = await oChatGuru.EnviarAsync(Texto, row["NO_PESSOA"].ToString(), row["CD_NUMERO"].ToString(), "", DS_PATH_IMAGEM, CD_USUARIO, CD_DIALOGO, add);

                  if (enviado)
                  {
                    GravarNotificacaoHoje(int.Parse(row["ID_PESSOA"].ToString()), conn);

                    sSqlText = "INSERT INTO TB_HISTORICO (ID_EMPRESA, ID_OPT_PROCESSO, ID_OPT_ACAO, ID_USUARIO, ID_REGISTRO, DT_HISTORICO, DS_HISTORICO, DS_FILTRO, CD_VERSAO_SISTEMA, NO_COMPUTADOR_NOME, CD_HISTORICO, ID_OPT_ERRO)" +
                               " VALUES (@ID_EMPRESA, @ID_OPT_PROCESSO, @ID_OPT_ACAO, @ID_USUARIO, @ID_REGISTRO, @DT_HISTORICO, @DS_HISTORICO, @DS_FILTRO, @CD_VERSAO_SISTEMA, @NO_COMPUTADOR_NOME, @CD_HISTORICO, @ID_OPT_ERRO)";
                    Util.Executar(conn, sSqlText, new Util.DBParamentro[] { Util.DBParametro_Montar("ID_EMPRESA", 2), /* Praça - Clínica de 28 de Julho */
                                                                        Util.DBParametro_Montar("ID_OPT_PROCESSO", 519 /* Clínica - Agendamento */),
                                                                        Util.DBParametro_Montar("ID_OPT_ACAO", 101 /* Notificado - Cancelamento */),
                                                                        Util.DBParametro_Montar("ID_USUARIO", 1),
                                                                        Util.DBParametro_Montar("ID_REGISTRO", row["SQ_AGENDAMENTO"]),
                                                                        Util.DBParametro_Montar("DS_HISTORICO", Historico),
                                                                        Util.DBParametro_Montar("DT_HISTORICO", DateTime.Now, SqlDbType.DateTime),
                                                                        Util.DBParametro_Montar("DS_FILTRO", ""),
                                                                        Util.DBParametro_Montar("CD_VERSAO_SISTEMA", ""),
                                                                        Util.DBParametro_Montar("NO_COMPUTADOR_NOME", ""),
                                                                        Util.DBParametro_Montar("CD_HISTORICO", row["CD_AGENDAMENTO"]),
                                                                        Util.DBParametro_Montar("ID_OPT_ERRO", "")});
                  }

                  Thread.Sleep(1000);
                }
              }
            }

            bool enviar = false;

            sSqlText = "SELECT AGEND.SQ_AGENDAMENTO," +
                              "AGEND.ID_PESSOA," +
                              "AGEND.CD_AGENDAMENTO," +
                              "PESSO.NO_PESSOA," +
                              "PSPRF.NO_PESSOA NO_PESSOA_PROFISSIONAL," +
                              "EMPRE.NO_PESSOA NO_EMPRESA," +
                              "CONVERT(CHAR, AGEND.DH_AGENDAMENTO, 103) DT_AGENDAMENTO," +
                              "CONVERT(CHAR(5), AGEND.DH_AGENDAMENTO, 108) HR_AGENDAMENTO," +
                              "dbo.FC_Formatar_NUMERO_WHATSAPP(PSTEL.CD_NUMERO) CD_NUMERO," +
                              "ISNULL(PSCFG.DS_PATH_IMAGEM_MENSAGEM, '') DS_PATH_IMAGEM_MENSAGEM," +
                              "ISNULL(PSHHR.HR_INICIO, ISNULL(DE.HR_INICIO, SDE.HR_INICIO)) HR_INICIO," +
                              "ENDER.DS_ENDERECO," +
                              "IIF(CAST(AGEND.DH_INLCUSAO AS DATE) = CAST(GETDATE() AS DATE), 'CONFIRMINC'," +
                                  "IIF(CAST(GETDATE() AS DATE) = CAST(DATEADD(DAY, -3, AGEND.DH_AGENDAMENTO) AS DATE), 'CONFIRM3D'," +
                                      "IIF(CAST(GETDATE() AS DATE) = CAST(DATEADD(DAY, -1, AGEND.DH_AGENDAMENTO) AS DATE), 'CONFIRM1D'," +
                                          "IIF(CAST(GETDATE() AS DATE) = CAST(AGEND.DH_AGENDAMENTO AS DATE), 'CONFIRMND', '')))) CD_MODELO," +
                              "CONSL.NO_CONSULTORIO" +
                       " FROM TB_AGENDAMENTO AGEND" +
                        " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" +
                        " INNER JOIN TB_PESSOA PSPRF ON PSPRF.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" +
                        " INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = AGEND.ID_EMPRESA" +
                        " INNER JOIN (SELECT ID_PESSOA, IC_WHATSAPP, MAX(CD_NUMERO) CD_NUMERO FROM TB_PESSOA_TELEFONE WHERE IC_WHATSAPP = 'S' GROUP BY ID_PESSOA, IC_WHATSAPP) PSTEL ON PSTEL.ID_PESSOA = PESSO.SQ_PESSOA" +
                        " INNER JOIN TB_CANALMARCACAO CNN ON CNN.SQ_CANALMARCACAO = AGEND.ID_CANALMARCACAO" +
                                                    " AND CNN.TP_ENVIAR_NOTIFICACAO_WHATSAPP = 'S'" +
                         " LEFT JOIN TB_CONSULTORIO CONSL ON CONSL.SQ_CONSULTORIO = AGEND.ID_CONSULTORIO" +
                         " LEFT JOIN TB_PESSOA_HORARIO PSHHR ON PSHHR.SQ_PESSOA_HORARIO = AGEND.ID_PESSOA_HORARIO" +
                         " LEFT JOIN TB_HISTORICO HISTO ON HISTO.ID_REGISTRO = AGEND.SQ_AGENDAMENTO" +
                                                     " AND HISTO.ID_OPT_ACAO = 829" +
                                                     " AND CAST(HISTO.DT_HISTORICO AS DATE) = CAST(GETDATE() AS DATE)" +
                         " LEFT JOIN TB_PESSOA_CONFIGURACAO PSCFG ON PSCFG.ID_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" +
                                                      " AND PSCFG.ID_EMPRESA = 2" +
                         " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER ON ENDER.ID_TIPO_ENDERECO = 2" +
                                                             " AND ENDER.ID_PESSOA = AGEND.ID_EMPRESA" +
                         " LEFT JOIN (SELECT PH.ID_EMPRESA," +
                                            "PH.ID_PESSOA," +
                                            "PH.DT_ESPECIAL," +
                                            "IIF(DATEPART(HOUR, dbo.FC_DATAHORA_MONTAR(GETDATE(), PH.HR_INICIO)) > 12, 2, 1) NR_TURNO," +
                                            "MIN(PH.HR_INICIO) HR_INICIO" +
                                     " FROM TB_PESSOA_HORARIO PH" +
                                      " INNER JOIN TB_OPCAO OP ON OP.SQ_OPCAO = PH.ID_OPT_DIA_SEMANA" +
                                     " WHERE PH.DT_ESPECIAL IS NOT NULL" +
                                     " GROUP BY PH.ID_EMPRESA," +
                                               "PH.ID_PESSOA," +
                                               "PH.DT_ESPECIAL," +
                                               "IIF(DATEPART(HOUR, dbo.FC_DATAHORA_MONTAR(GETDATE(), HR_INICIO)) > 12, 2, 1)) DE ON DE.ID_EMPRESA = AGEND.ID_EMPRESA" +
                                                                                                                              " AND DE.ID_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" +
                                                                                                                              " AND CAST(DE.DT_ESPECIAL AS DATE) = CAST(AGEND.DH_AGENDAMENTO AS DATE)" +
                                                                                                                              " AND DE.NR_TURNO = IIF(DATEPART(HOUR, AGEND.DH_AGENDAMENTO) > 12, 2, 1)" + 
                          "LEFT JOIN (SELECT PH.ID_EMPRESA, PH.ID_PESSOA, OP.CD_OPCAO, IIF(DATEPART(HOUR, dbo.FC_DATAHORA_MONTAR(GETDATE(), PH.HR_INICIO)) > 12, 2, 1) NR_TURNO, MIN(PH.HR_INICIO) HR_INICIO" +
                                     " FROM TB_PESSOA_HORARIO PH" +
                                      " INNER JOIN TB_OPCAO OP ON OP.SQ_OPCAO = PH.ID_OPT_DIA_SEMANA" +
                                      " WHERE PH.DT_ESPECIAL IS NULL" +
                                      " GROUP BY PH.ID_EMPRESA," +
                                                "PH.ID_PESSOA," +
                                                "IIF(DATEPART(HOUR, dbo.FC_DATAHORA_MONTAR(GETDATE(), HR_INICIO)) > 12, 2, 1), OP.CD_OPCAO) SDE ON SDE.ID_EMPRESA = AGEND.ID_EMPRESA" +
                                                                                                                                         " AND SDE.ID_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" +
                                                                                                                                         " AND SDE.CD_OPCAO = DATEPART(W, AGEND.DH_AGENDAMENTO)" +
                                                                                                                                         " AND SDE.NR_TURNO = IIF(DATEPART(HOUR, AGEND.DH_AGENDAMENTO) > 12, 2, 1)" +
                       " WHERE AGEND.ID_TIPO_CONSULTA IN (1, 3) " +
                       "   AND AGEND.ID_OPT_STATUS IN (38) " +
                       "   AND AGEND.DH_AGENDAMENTO >= '08/01/2025 23:00:00' " +
                       "   AND HISTO.SQ_HISTORICO IS NULL" +
                       " GROUP BY AGEND.CD_AGENDAMENTO," +
                                 "AGEND.SQ_AGENDAMENTO," +
                                 "AGEND.ID_PESSOA," +
                                 "PESSO.NO_PESSOA," +
                                 "PSPRF.NO_PESSOA," +
                                 "EMPRE.NO_PESSOA," +
                                 "CONSL.NO_CONSULTORIO," +
                                 "CONVERT(CHAR, AGEND.DH_AGENDAMENTO, 103)," +
                                 "CONVERT(CHAR(5), AGEND.DH_AGENDAMENTO, 108)," +
                                 "dbo.FC_Formatar_NUMERO_WHATSAPP(PSTEL.CD_NUMERO)," +
                                 "ISNULL(PSCFG.DS_PATH_IMAGEM_MENSAGEM, '')," +
                                 "ENDER.DS_ENDERECO," +
                                 "ISNULL(PSHHR.HR_INICIO, ISNULL(DE.HR_INICIO, SDE.HR_INICIO))," +
                                 "IIF(CAST(AGEND.DH_INLCUSAO AS DATE) = CAST(GETDATE() AS DATE), 'CONFIRMINC'," +
                                     "IIF(CAST(GETDATE() AS DATE) = CAST(DATEADD(DAY, -3, AGEND.DH_AGENDAMENTO) AS DATE), 'CONFIRM3D'," +
                                         "IIF(CAST(GETDATE() AS DATE) = CAST(DATEADD(DAY, -1, AGEND.DH_AGENDAMENTO) AS DATE), 'CONFIRM1D'," +
                                             "IIF(CAST(GETDATE() AS DATE) = CAST(AGEND.DH_AGENDAMENTO AS DATE), 'CONFIRMND', ''))))";
            sSqlText = "SELECT DISTINCT * FROM (" + sSqlText + ") X WHERE CD_MODELO = 'CONFIRMINC'";
            oData = Util.Query(conn, sSqlText);

            foreach (DataRow row in oData.Rows)
            {
              if (!String.IsNullOrEmpty(row["CD_NUMERO"].ToString()))
              {
                switch (row["CD_MODELO"].ToString())
                {
                  case "CONFIRM3D":
                    Historico = "Notificação: Mens Lembrete de 3 Dias";
                    enviar = (DateTime.Now.Hour >= 17);
                    break;
                  case "CONFIRM1D":
                    Historico = "Notificação: Mens Lembrete de 1 Dia";
                    enviar = (DateTime.Now >= DateTime.Now.Date.AddHours(6).AddMinutes(30));
                    break;
                  case "CONFIRMINC":
                    Historico = "Notificação: Mens Agendamento";
                    enviar = (DateTime.Now.Hour >= 7);
                    break;
                  case "CONFIRMND":
                    Historico = "Notificação: Mens Lembrete do dia";
                    enviar = (DateTime.Now.Hour >= 6);
                    break;
                }

                Modelo(conn, row["CD_MODELO"].ToString(), ref DS_MENSAGEM_MODELO, ref DS_PATH_IMAGEM, ref CD_USUARIO, ref CD_DIALOGO, ref TP_ATIVO);

                if (enviar && (!String.IsNullOrEmpty(row["CD_NUMERO"].ToString())) && TP_ATIVO)
                {
                  bool enviouNotificacaoHoje = VerificarNotificacaoHoje(int.Parse(row["ID_PESSOA"].ToString()), conn);

                  Texto = DS_MENSAGEM_MODELO;
                  Texto = Texto.Replace("[NomePaciente]", row["NO_PESSOA"].ToString());
                  Texto = Texto.Replace("[DiaAgendamento]", row["DT_AGENDAMENTO"].ToString());
                  Texto = Texto.Replace("[HoraAgendamento]", row["HR_INICIO"].ToString());
                  Texto = Texto.Replace("[Medico]", row["NO_PESSOA_PROFISSIONAL"].ToString());
                  Texto = Texto.Replace("[Unidade]", row["NO_EMPRESA"].ToString());
                  Texto = Texto.Replace("[EnderecoUnidade]", row["DS_ENDERECO"].ToString());
                  Texto = Texto.Replace("[Consultorio]", row["NO_CONSULTORIO"].ToString());

                  await oChatGuru.chat_update_custom_fields("Nome", row["NO_PESSOA"].ToString(), row["CD_NUMERO"].ToString());
                  await oChatGuru.chat_update_custom_fields("DiaAgendamento", row["DT_AGENDAMENTO"].ToString(), row["CD_NUMERO"].ToString());
                  await oChatGuru.chat_update_custom_fields("HoraAgendamento", row["HR_INICIO"].ToString(), row["CD_NUMERO"].ToString());
                  await oChatGuru.chat_update_custom_fields("EnderecoUnidade", row["DS_ENDERECO"].ToString(), row["CD_NUMERO"].ToString());

                  bool enviado = await oChatGuru.EnviarAsync(Texto, row["NO_PESSOA"].ToString(), row["CD_NUMERO"].ToString(), "", DS_PATH_IMAGEM, CD_USUARIO, CD_DIALOGO, !enviouNotificacaoHoje);

                  if (enviado)
                  {
                    GravarNotificacaoHoje(int.Parse(row["ID_PESSOA"].ToString()), conn);

                    sSqlText = "INSERT INTO TB_HISTORICO (ID_EMPRESA, ID_OPT_PROCESSO, ID_OPT_ACAO, ID_USUARIO, ID_REGISTRO, DT_HISTORICO, DS_HISTORICO, DS_FILTRO, CD_VERSAO_SISTEMA, NO_COMPUTADOR_NOME, CD_HISTORICO, ID_OPT_ERRO)" +
                               " VALUES (@ID_EMPRESA, @ID_OPT_PROCESSO, @ID_OPT_ACAO, @ID_USUARIO, @ID_REGISTRO, @DT_HISTORICO, @DS_HISTORICO, @DS_FILTRO, @CD_VERSAO_SISTEMA, @NO_COMPUTADOR_NOME, @CD_HISTORICO, @ID_OPT_ERRO)";
                    Util.Executar(conn, sSqlText, new Util.DBParamentro[] { Util.DBParametro_Montar("ID_EMPRESA", 2), /* Praça - Clínica de 28 de Julho */
                                                                        Util.DBParametro_Montar("ID_OPT_PROCESSO", 519 /* Clínica - Agendamento */),
                                                                        Util.DBParametro_Montar("ID_OPT_ACAO", 829 /* Notificado */),
                                                                        Util.DBParametro_Montar("ID_USUARIO", 1),
                                                                        Util.DBParametro_Montar("ID_REGISTRO", row["SQ_AGENDAMENTO"]),
                                                                        Util.DBParametro_Montar("DS_HISTORICO", Historico),
                                                                        Util.DBParametro_Montar("DT_HISTORICO", DateTime.Now, SqlDbType.DateTime),
                                                                        Util.DBParametro_Montar("DS_FILTRO", ""),
                                                                        Util.DBParametro_Montar("CD_VERSAO_SISTEMA", ""),
                                                                        Util.DBParametro_Montar("NO_COMPUTADOR_NOME", ""),
                                                                        Util.DBParametro_Montar("CD_HISTORICO", row["CD_AGENDAMENTO"]),
                                                                        Util.DBParametro_Montar("ID_OPT_ERRO", "")});
                  }
                }

                Thread.Sleep(1000);
              }
            }
          }

          Thread.Sleep(1000 * 60 * 1);
        }
        catch (Exception Ex)
        {
          _logger.Log(LogLevel.Error, Ex.Message);
        }
      }
    }

    bool VerificarNotificacaoHoje(int iID_PESSOA, System.Data.SqlClient.SqlConnection conn)
    {
      string sql = $"SELECT COUNT(*) FROM TB_PESSOA WHERE SQ_PESSOA = {iID_PESSOA} AND CAST(DH_NOTIFICACAO AS DATE) = CAST(GETDATE() AS DATE)";

      DataTable dt = Util.Query(conn, sql);

      return dt.Rows.Count > 0;
    }

    void GravarNotificacaoHoje(int iID_PESSOA, System.Data.SqlClient.SqlConnection conn)
    {
      string sql = $"EXEC SP_PESSOA_NOTIFICACAO_UPD @ID_PESSOA";

      Util.Executar(conn, sql, new Util.DBParamentro[] {  Util.DBParametro_Montar("ID_PESSOA", iID_PESSOA) });
    }

    void Modelo(System.Data.SqlClient.SqlConnection conn, string CD_MENSAGEM_MODELO, ref string DS_MENSAGEM_MODELO, ref string DS_PATH_IMAGEM, ref string CD_USUARIO, ref string CD_DIALOGO, ref bool TP_ATIVO)
    {
      try
      {
        DataTable oData = null;
        string sSqlText = "";
        sSqlText = "SELECT DS_MENSAGEM_MODELO, DS_PATH_IMAGEM, CD_USUARIO, CD_DIALOGO, TP_ATIVO FROM TB_MENSAGEM_MODELO WHERE CD_MENSAGEM_MODELO = '" + CD_MENSAGEM_MODELO + "'";
        oData = Util.Query(conn, sSqlText);

        DS_MENSAGEM_MODELO = oData.Rows[0]["DS_MENSAGEM_MODELO"].ToString();
        DS_PATH_IMAGEM = oData.Rows[0]["DS_PATH_IMAGEM"].ToString();
        CD_USUARIO = oData.Rows[0]["CD_USUARIO"].ToString();
        CD_DIALOGO = oData.Rows[0]["CD_DIALOGO"].ToString();
        TP_ATIVO = oData.Rows[0]["TP_ATIVO"].ToString() == "S";
      }
      catch (Exception)
      {
      }
    }


  }
}