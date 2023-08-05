using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService
{
  public static class modSisVida
  {
    public class Cabecalho
    {
      public string login { get; set; }
      public string senha { get; set; }
      public string codlab { get; set; }
      public int integracao { get; set; }
      public string versao { get; set; }
      public string datahora { get; set; }
      public string software { get; set; }
      public string operador { get; set; }
    }
    public class Amostra
    {
      public int codigo_lis { get; set; }
      public string codigo { get; set; }
      public string descricao { get; set; }
      public List<Exame> exames { get; set; }
    }

    public class Cidade
    {
      // Public Property codigo As String
      // Public Property estado_id As Integer
      // Public Property id As Integer
      // Public Property localidade As String
      public string municipio { get; set; }
    }

    public class Estado
    {
      public string codigo_tiss { get; set; }
      public string descricao { get; set; }
      public int id { get; set; }
      public object identificador { get; set; }
      public int pais_id { get; set; }
      public string sigla { get; set; }
    }

    public class Exame
    {
      public int codigo_lis { get; set; }
      public string codigo { get; set; }
      public int prioridade { get; set; }
      public string descricao { get; set; }
    }

    public class Paciente
    {
      public int codigo_lis { get; set; }
      public string nome { get; set; }
      public string data_nascimento { get; set; }
      public string sexo { get; set; }
      public string tipo_documento { get; set; }
      public string documento { get; set; }
      public string cpf { get; set; }
      public string telefone { get; set; }
      public string endereco { get; set; }
      public Cidade cidade { get; set; }
      public string estado { get; set; }
    }

    public class ProfissionalSaudeSolicitante
    {
      public string nome { get; set; }
      public string uf_conselho { get; set; }
      public string numero_conselho { get; set; }
      public string cbo_s { get; set; }
      public string conselho_profissional { get; set; }
    }

    public class Solicitaco
    {
      // Public Property codigo_lis As Integer
      public Paciente paciente { get; set; }
      public ProfissionalSaudeSolicitante profissional_saude_solicitante { get; set; }
      // Public Property observacao As String
      public string data { get; set; }
      public string crm { get; set; }
      public List<Amostra> amostras { get; set; }
    }

    public class Root
    {
      public Cabecalho cabecalho { get; set; }
      public List<Solicitaco> solicitacoes { get; set; }
    }

    private static List<Amostra> _amostras;
    private static List<Exame> _exames;

    private static string Integracao_DS_LINK = "";
    private static string Integracao_CD_CHAVE_01 = "";
    private static string Integracao_CD_CHAVE_02 = "";
    private static string Integracao_CD_CHAVE_03 = "";
    private static string Integracao_CD_CHAVE_04 = "";

    public static void Inicializar()
    {
      _amostras = new List<Amostra>();
      _exames = new List<Exame>();
    }

    private static void AdicionarExame(string CD_INTEGRACAO_MATERIAL, string DS_INTEGRACAO_MATERIAL, Exame _exame)
    {
      Amostra _amostra = null;
      int iCont;

      for (iCont = 0; iCont <= _amostras.Count - 1; iCont++)
      {
        if (_amostras[iCont].codigo == CD_INTEGRACAO_MATERIAL)
        {
          _amostra = _amostras[iCont];
          _amostra.exames.Add(_exame);
          _amostras[iCont] = _amostra;
          break;
        }
      }

      if (_amostra == null)
      {
        _amostra = new Amostra();
        _amostra.codigo_lis = 0;
        _amostra.codigo = CD_INTEGRACAO_MATERIAL;
        _amostra.descricao = DS_INTEGRACAO_MATERIAL;
        _amostra.exames = new List<Exame>();
        _amostra.exames.Add(_exame);
        _amostras.Add(_amostra);
      }
    }

    public static void AdicionarExames(int SQ_PROCEDIMENTO, string CD_INTEGRACAO_EXAME, string DS_INTEGRACAO_EXAME, string CD_INTEGRACAO_MATERIAL, string DS_INTEGRACAO_MATERIAL)
    {
      var _exame = new Exame();

      _exame.codigo_lis = SQ_PROCEDIMENTO;
      _exame.codigo = CD_INTEGRACAO_EXAME;
      _exame.prioridade = 0;
      _exame.descricao = DS_INTEGRACAO_EXAME;

      AdicionarExame(CD_INTEGRACAO_MATERIAL, DS_INTEGRACAO_MATERIAL, _exame);
    }

    public static void MontarEnviar(System.Data.SqlClient.SqlConnection conn)
    {
      try
      {
        string sSqlText = "";
        DataTable oData = null;
        DataTable oDataVenda = null;
        DataTable oDataItem = null;

        int SQ_CLINICA_VENDA = 0;
        string CD_CLINICA_VENDA = "";
        int ID_PACIENTE=0;
        string NO_USUARIO = "";
        string NO_PACIENTE = "";
        string DT_PACIENTE_NASCIMENTO = "";
        string CD_SEXO = "";
        string CD_PACIENTE_CPF = "";
        string CD_PACIENTE_TELEFONE = "";
        string DS_PACIENTE_ENDERECO = "";
        string DS_PACIENTE_ENDERECO_CIDADE = "";
        string CD_PACIENTE_ENDERECO_UF = "";
        string NO_PROFISSIONAL = "";
        string NO_PROFISSIONAL_CONSELHO_UF = "";
        string NO_PROFISSIONAL_CONSELHO_NR = "";
        string NO_PROFISSIONAL_CBO = "";
        string NO_PROFISSIONAL_CONSELHO = "";

        sSqlText = "SELECT * FROM TB_INTEGRACAO WHERE SQ_INTEGRACAO = 1 AND TP_ATIVO = 'S'";
        oData = Util.Query(conn, sSqlText);

        if (oData != null)
        {
          if (oData.Rows[0]["DS_LINK"] != null) Integracao_DS_LINK = oData.Rows[0]["DS_LINK"].ToString();
          if (oData.Rows[0]["CD_CHAVE_01"] != null) Integracao_CD_CHAVE_01 = oData.Rows[0]["CD_CHAVE_01"].ToString();
          if (oData.Rows[0]["CD_CHAVE_02"] != null) Integracao_CD_CHAVE_02 = oData.Rows[0]["CD_CHAVE_02"].ToString();
          if (oData.Rows[0]["CD_CHAVE_03"] != null) Integracao_CD_CHAVE_03 = oData.Rows[0]["CD_CHAVE_03"].ToString();
          if (oData.Rows[0]["CD_CHAVE_04"] != null) Integracao_CD_CHAVE_04 = oData.Rows[0]["CD_CHAVE_04"].ToString();
        }

        if (!string.IsNullOrEmpty(Integracao_DS_LINK))
        {
          sSqlText = "SELECT DISTINCT CLVND.SQ_CLINICA_VENDA" +
                     " FROM TB_CLINICA_VENDA CLVND" +
                      " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPCD ON CVPCD.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" +
                                                                    " AND CVPCD.ID_PESSOA_PROFISSIONAL_SOLICITANTE IS NOT NULL" +
                      " INNER JOIN TB_PESSOA_INTEGRACAO PSINT ON PSINT.ID_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL" +
                                                           " AND PSINT.ID_INTEGRACAO = 1" +
                      " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVPCD.ID_PROCEDIMENTO" +
                                                      " AND PROCE.CD_INTEGRACAO_EXAME IS NOT NULL" +
                     " WHERE CLVND.TP_INTEGRADO_SISVIDA = 'N' AND DH_CANCELAR IS NULL";
          oData = Util.Query(conn, sSqlText);

          foreach (DataRow row in oData.Rows)
          {
            sSqlText = "SELECT DISTINCT CLVND.SQ_CLINICA_VENDA, CVPCD.ID_PESSOA_PROFISSIONAL" +
                       " FROM TB_CLINICA_VENDA CLVND" +
                        " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPCD ON CVPCD.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" +
                                                                      " AND CVPCD.ID_PESSOA_PROFISSIONAL_SOLICITANTE IS NOT NULL" +
                        " INNER JOIN TB_PESSOA_INTEGRACAO PSINT ON PSINT.ID_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL" +
                                                             " AND PSINT.ID_INTEGRACAO = 1" +
                        " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVPCD.ID_PROCEDIMENTO" +
                                                        " AND PROCE.CD_INTEGRACAO_EXAME IS NOT NULL" +
                       " WHERE CLVND.SQ_CLINICA_VENDA = " + row["SQ_CLINICA_VENDA"].ToString();
            oDataVenda = Util.Query(conn, sSqlText);

            foreach (DataRow rowVenda in oDataVenda.Rows)
            {
              Inicializar();

              sSqlText = "SELECT CLVND.SQ_CLINICA_VENDA," +
                                "CLVND.CD_CLINICA_VENDA," +
                                "CLVND.ID_PESSOA," +
                                "ISNULL(USU.NO_PESSOA, 'Administrador de Sistema') NO_USUARIO," +
                                "PACIE.NO_PESSOA NO_PACIENTE," +
                                "PACIE.DT_NASC_ABERTURA," +
                                "SUBSTRING(ISNULL(SXO.NO_TIPO_SEXO, ''), 1, 1) NO_TIPO_SEXO," +
                                "PACIE.CD_CPF_CNPJ," +
                                "PROCE.SQ_PROCEDIMENTO," +
                                "PROCE.CD_INTEGRACAO_EXAME," +
                                "PROCE.CD_INTEGRACAO_MATERIAL," +
                                "PROCE.DS_INTEGRACAO_EXAME," +
                                "PROCE.DS_INTEGRACAO_MATERIAL," +
                                "PROFI.NO_PESSOA NO_PROFISSIONAL," +
                                "UF.CD_UF CD_PROFISSIONAL_CONSELHOPROFISSIONAL_UF," +
                                "PRFEM.NR_PROFISSIONAL_CONSELHOPROFISSIONAL," +
                                "PRFEM.DS_PROFISSIONAL_CBO," +
                                "CLHPF.CD_CONSELHOPROFISSIONAL," +
                                "TLP.CD_NUMERO," +
                                "ENP.DS_LOGRADOURO_COMPLETO," +
                                "ENP.NO_CIDADE," +
                                "ENP.CD_UF" +
                         " FROM TB_CLINICA_VENDA CLVND" +
                          " INNER JOIN TB_PESSOA PACIE ON PACIE.SQ_PESSOA = CLVND.ID_PESSOA" +
                           " LEFT JOIN TB_TIPO_SEXO SXO ON SXO.SQ_TIPO_SEXO = PACIE.ID_PF_TIPO_SEXO" +
                          " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPCD ON CVPCD.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" +
                                                                        " AND CVPCD.ID_PESSOA_PROFISSIONAL_SOLICITANTE IS NOT NULL" +
                          " INNER JOIN TB_PESSOA_INTEGRACAO PSINT ON PSINT.ID_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL" +
                                                               " AND PSINT.ID_INTEGRACAO = 1" +
                          " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVPCD.ID_PROCEDIMENTO" +
                                                          " AND PROCE.CD_INTEGRACAO_EXAME IS NOT NULL" +
                           " LEFT JOIN TB_HISTORICO HST ON HST.ID_REGISTRO = CLVND.SQ_CLINICA_VENDA" +
                                                     " AND HST.ID_OPT_PROCESSO = 516" +
                                                     " AND HST.ID_OPT_ACAO = 467" +
                           " LEFT JOIN TB_PESSOA USU ON USU.SQ_PESSOA = HST.ID_USUARIO" +
                           " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO TLP ON TLP.ID_PESSOA = PACIE.SQ_PESSOA" +
                           " LEFT JOIN VW_ENDERECO_PRIMEIRO ENP ON ENP.ID_PESSOA = PACIE.SQ_PESSOA" +
                           " LEFT JOIN TB_PESSOA PROFI ON PROFI.SQ_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL_SOLICITANTE" +
                           " LEFT JOIN TB_PESSOA_EMPRESA PRFEM ON PRFEM.ID_EMPRESA = 2 AND PRFEM.ID_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL_SOLICITANTE" +
                           " LEFT JOIN TB_CONSELHOPROFISSIONAL CLHPF ON CLHPF.SQ_CONSELHOPROFISSIONAL = PRFEM.ID_PROFISSIONAL_CONSELHOPROFISSIONAL" +
                           " LEFT JOIN TB_UF UF ON UF.SQ_UF = PRFEM.ID_PROFISSIONAL_CONSELHOPROFISSIONAL_UF" +
                         " WHERE CLVND.SQ_CLINICA_VENDA = " + rowVenda["SQ_CLINICA_VENDA"].ToString() +
                           " AND CVPCD.ID_PESSOA_PROFISSIONAL = " + rowVenda["ID_PESSOA_PROFISSIONAL"].ToString();
              oDataItem = Util.Query(conn, sSqlText);

              foreach (DataRow rowItem in oDataItem.Rows)
              {
                AdicionarExames(Convert.ToInt32(rowItem["SQ_PROCEDIMENTO"]),
                                rowItem["CD_INTEGRACAO_EXAME"].ToString(),
                                rowItem["DS_INTEGRACAO_EXAME"].ToString(),
                                rowItem["CD_INTEGRACAO_MATERIAL"].ToString(),
                                rowItem["DS_INTEGRACAO_MATERIAL"].ToString());

                SQ_CLINICA_VENDA = Convert.ToInt32(rowItem["SQ_CLINICA_VENDA"]);
                CD_CLINICA_VENDA = rowItem["CD_CLINICA_VENDA"].ToString();
                ID_PACIENTE = Convert.ToInt32(rowItem["ID_PESSOA"]);
                NO_USUARIO = rowItem["NO_USUARIO"].ToString();
                NO_PACIENTE = rowItem["NO_PACIENTE"].ToString();
                DT_PACIENTE_NASCIMENTO = rowItem["DT_NASC_ABERTURA"].ToString().Substring(0, 10);
                CD_SEXO = rowItem["NO_TIPO_SEXO"].ToString();
                CD_PACIENTE_CPF = rowItem["CD_CPF_CNPJ"].ToString();
                CD_PACIENTE_TELEFONE = rowItem["CD_NUMERO"].ToString();
                DS_PACIENTE_ENDERECO = rowItem["DS_LOGRADOURO_COMPLETO"].ToString();
                DS_PACIENTE_ENDERECO_CIDADE = rowItem["NO_CIDADE"].ToString();
                CD_PACIENTE_ENDERECO_UF = rowItem["CD_UF"].ToString();
                NO_PROFISSIONAL = rowItem["NO_PROFISSIONAL"].ToString();
                NO_PROFISSIONAL_CONSELHO_UF = rowItem["CD_PROFISSIONAL_CONSELHOPROFISSIONAL_UF"].ToString();
                NO_PROFISSIONAL_CONSELHO_NR = rowItem["NR_PROFISSIONAL_CONSELHOPROFISSIONAL"].ToString();
                NO_PROFISSIONAL_CBO = rowItem["DS_PROFISSIONAL_CBO"].ToString();
                NO_PROFISSIONAL_CONSELHO = rowItem["CD_CONSELHOPROFISSIONAL"].ToString();
              }

              EnviarSimples(conn,
                            SQ_CLINICA_VENDA,
                            CD_CLINICA_VENDA,
                            ID_PACIENTE,
                            NO_USUARIO,
                            NO_PACIENTE,
                            DT_PACIENTE_NASCIMENTO,
                            CD_SEXO,
                            CD_PACIENTE_CPF,
                            CD_PACIENTE_TELEFONE,
                            DS_PACIENTE_ENDERECO,
                            DS_PACIENTE_ENDERECO_CIDADE,
                            CD_PACIENTE_ENDERECO_UF,
                            NO_PROFISSIONAL,
                            NO_PROFISSIONAL_CONSELHO_UF,
                            NO_PROFISSIONAL_CONSELHO_NR,
                            NO_PROFISSIONAL_CBO,
                            NO_PROFISSIONAL_CONSELHO);
            }

            sSqlText = "UPDATE TB_CLINICA_VENDA SET TP_INTEGRADO_SISVIDA = 'S' WHERE SQ_CLINICA_VENDA = " + row["SQ_CLINICA_VENDA"].ToString();
            Util.Executar(conn, sSqlText, null);

            Thread.Sleep(1000);
          }
        }

      }
      catch (Exception Ex)
      {
      }
    }

    private static void EnviarSimples(System.Data.SqlClient.SqlConnection conn,
                                      int SQ_CLINICA_VENDA,
                                      string CD_CLINICA_VENDA, 
                                      int ID_PACIENTE,
                                      string NO_USUARIO,
                                      string NO_PACIENTE, 
                                      string DT_PACIENTE_NASCIMENTO, 
                                      string CD_SEXO, 
                                      string CD_PACIENTE_CPF, 
                                      string CD_PACIENTE_TELEFONE, 
                                      string DS_PACIENTE_ENDERECO, 
                                      string DS_PACIENTE_ENDERECO_CIDADE, 
                                      string CD_PACIENTE_ENDERECO_UF, 
                                      string NO_PROFISSIONAL, 
                                      string NO_PROFISSIONAL_CONSELHO_UF, 
                                      string NO_PROFISSIONAL_CONSELHO_NR, 
                                      string NO_PROFISSIONAL_CBO, 
                                      string NO_PROFISSIONAL_CONSELHO)
    {
      string sSqlText = "";
      string sTexto;

      try
      {
        Root _envio = new Root();
        Solicitaco _solicitaco = new Solicitaco();
        Paciente _paciente = new Paciente();
        ProfissionalSaudeSolicitante _profissionalSaudeSolicitante = new ProfissionalSaudeSolicitante();

        _paciente.codigo_lis = ID_PACIENTE;
        _paciente.nome = NO_PACIENTE;
        _paciente.data_nascimento = DT_PACIENTE_NASCIMENTO;
        _paciente.tipo_documento = "SR";
        _paciente.documento = "0";
        _paciente.sexo = CD_SEXO;
        _paciente.cpf = CD_PACIENTE_CPF;
        _paciente.telefone = CD_PACIENTE_TELEFONE;
        _paciente.endereco = DS_PACIENTE_ENDERECO;
        _paciente.cidade = new Cidade();
        _paciente.cidade.municipio = DS_PACIENTE_ENDERECO_CIDADE;
        _paciente.estado = CD_PACIENTE_ENDERECO_UF;

        _profissionalSaudeSolicitante.nome = NO_PROFISSIONAL;
        _profissionalSaudeSolicitante.uf_conselho = NO_PROFISSIONAL_CONSELHO_UF;
        _profissionalSaudeSolicitante.numero_conselho = NO_PROFISSIONAL_CONSELHO_NR;
        _profissionalSaudeSolicitante.cbo_s = NO_PROFISSIONAL_CBO;
        _profissionalSaudeSolicitante.conselho_profissional = NO_PROFISSIONAL_CONSELHO;

        _solicitaco.paciente = _paciente;
        _solicitaco.profissional_saude_solicitante = _profissionalSaudeSolicitante;
        _solicitaco.data = DateTime.Now.ToString();
        _solicitaco.crm = NO_PROFISSIONAL_CONSELHO_NR + "-" + NO_PROFISSIONAL_CONSELHO_UF;
        _solicitaco.amostras = new List<Amostra>();
        _solicitaco.amostras = _amostras;

        _envio.cabecalho = new Cabecalho();
        _envio.cabecalho.login = Integracao_CD_CHAVE_01;
        _envio.cabecalho.senha = Integracao_CD_CHAVE_02;
        _envio.cabecalho.codlab = Integracao_CD_CHAVE_03;
        _envio.cabecalho.integracao = Convert.ToInt32(Integracao_CD_CHAVE_04);
        _envio.cabecalho.versao = "v1";
        _envio.cabecalho.datahora = DateTime.Now.AddMinutes(5).ToString();
        _envio.cabecalho.software = "Cli28Julho - Clínica 28 de Julho";
        _envio.cabecalho.operador = NO_USUARIO;
        _envio.solicitacoes = new List<Solicitaco>();
        _envio.solicitacoes.Add(_solicitaco);

        sTexto = Enviar(Integracao_DS_LINK + "/remessa", _envio);
      }
      catch (Exception ex)
      {
        sTexto = ex.Message;
      }

      sSqlText = "INSERT INTO TB_HISTORICO (ID_EMPRESA, ID_OPT_PROCESSO, ID_OPT_ACAO, ID_USUARIO, ID_REGISTRO, DT_HISTORICO, DS_HISTORICO, DS_FILTRO, CD_VERSAO_SISTEMA, NO_COMPUTADOR_NOME, CD_HISTORICO, ID_OPT_ERRO)" +
                 " VALUES (@ID_EMPRESA, @ID_OPT_PROCESSO, @ID_OPT_ACAO, @ID_USUARIO, @ID_REGISTRO, @DT_HISTORICO, @DS_HISTORICO, @DS_FILTRO, @CD_VERSAO_SISTEMA, @NO_COMPUTADOR_NOME, @CD_HISTORICO, @ID_OPT_ERRO)";
      Util.Executar(conn, sSqlText, new Util.DBParamentro[] { Util.DBParametro_Montar("ID_EMPRESA", 2), /* Praça - Clínica de 28 de Julho */
                                                                Util.DBParametro_Montar("ID_OPT_PROCESSO", 516 /* Vendas - Lançamento */),
                                                                Util.DBParametro_Montar("ID_OPT_ACAO", 648 /* Transmissão */),
                                                                Util.DBParametro_Montar("ID_USUARIO", 1),
                                                                Util.DBParametro_Montar("ID_REGISTRO", SQ_CLINICA_VENDA),
                                                                Util.DBParametro_Montar("DS_HISTORICO", sTexto, SqlDbType.VarChar , ParameterDirection.Input,8000),
                                                                Util.DBParametro_Montar("DT_HISTORICO", DateTime.Now, SqlDbType.DateTime),
                                                                Util.DBParametro_Montar("DS_FILTRO", ""),
                                                                Util.DBParametro_Montar("CD_VERSAO_SISTEMA", ""),
                                                                Util.DBParametro_Montar("NO_COMPUTADOR_NOME", ""),
                                                                Util.DBParametro_Montar("CD_HISTORICO", CD_CLINICA_VENDA),
                                                                Util.DBParametro_Montar("ID_OPT_ERRO", "")});
    }

    public static string Enviar(string sLink, Root _envio)
    {
      string sRetorno = "Sucesso";
      HttpWebResponse httpResponse;

      string ToJSON = JsonConvert.SerializeObject(_envio);

      try
      {
        var dados = Encoding.UTF8.GetBytes(ToJSON);

        var httpWebRequest = (HttpWebRequest)WebRequest.Create(sLink + "/enviar");
        httpWebRequest.ContentType = "application/json";
        httpWebRequest.Method = "POST";
        // httpWebRequest.ContentLength = ToJSON.Length

        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        {
          streamWriter.Write(ToJSON);
        }

        httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        {
          string responseText = streamReader.ReadToEnd();
        }
      }
      catch (Exception ex)
      {
        if (!ex.Message.Contains("Not Acceptable"))
        {
          sRetorno = "Erro - " + ex.Message;
        }
      }

      return sRetorno + " >> " + ToJSON;
    }
  }
}
