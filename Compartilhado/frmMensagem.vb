Public Class frmMensagem
  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String 

    sSqlText = "SELECT AGEND.SQ_AGENDAMENTO," &
                      "PESSO_PACIE.NO_PESSOA AS PACIENTE," &
                      "PSTEL.CD_NUMERO AS FONE," &
                      "AGEND.CD_AGENDAMENTO," &
                      "GPPCD.SQ_GRUPOPROCEDIMENTO," &
                      "GPPCD.NO_GRUPOPROCEDIMENTO AS [GRUPO PROCEDIMENTO]," &
                      "PROCE.SQ_PROCEDIMENTO," &
                      "PROCE.CD_PROCEDIMENTO," &
                      "PROCE.NO_PROCEDIMENTO AS PROCEDIMENTO," &
                      "AGEND.DH_AGENDAMENTO," &
                      "AGEND.ID_OPT_STATUS," &
                      "OPCAO_STSAG.NO_OPCAO AS STATUS," &
                      "AGEND.ID_CONVENIO," &
                      "CONVE.NO_CONVENIO AS CONVÊNIO," &
                      "PESSO_PACIE.ID_PF_TIPO_SEXO," &
                      "PESSO_PACIE.ID_OPT_SITUACAOPROFISSIONAL," &
                      "OPCAO_STSPS.NO_OPCAO AS [STATUS DO PACIENTE]," &
                      "PACIE_PROFI.SQ_PESSOA_PROFISSAO," &
                      "PROFI.NO_PROFISSAO AS PROFISSÃO," &
                      "CIDAD.NO_CIDADE AS CIDADE," &
                      "ENDER.NO_BAIRRO AS BAIRRO," &
                      "TPSTC.NO_TIPO_ESTADOCIVIL AS [ESTADO CIVIL]," &
                      "PESSO_PROFI.NO_PESSOA AS PROFISSIONAL," &
                      "PSESP.ID_ESPECIALIDADE," &
                      "ESPEC.NO_ESPECIALIDADE AS ESPECIALIDADE," &
                      "CLATD.SQ_CLINICA_ATENDIMENTO AS HOUVE_ATENDIMENTO," &
                      "CLPCD.SQ_CLINICA_PROCEDIMENTO AS EXAMES_OUTROS_SOLICITADOS," &
                      "CECIT.SQ_CLINICA_EXAME_CITOLOGICO AS EXAME_CITOLOGICO_SOLICITADO" &
                "FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = AGEND.ID_ESPECIALIDADE" &
                " INNER JOIN TB_PESSOA_ESPECIALIDADE PSESP ON PSESP.ID_ESPECIALIDADE = ESPEC.SQ_ESPECIALIDADE" &
                                                         " AND PSESP.ID_PESSOA = PESSO_PROFI.SQ_PESSOA" &
                " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO" &
                " INNER JOIN TB_OPCAO OPCAO_STSAG ON AGEND.ID_OPT_STATUS = OPCAO_STSAG.SQ_OPCAO" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                " INNER JOIN TB_GRUPOPROCEDIMENTO GPPCD ON GPPCD.SQ_GRUPOPROCEDIMENTO = PROCE.ID_GRUPOPROCEDIMENTO" &
                " INNER JOIN TB_PESSOA PESSO_PACIE ON PESSO_PACIE.SQ_PESSOA = AGEND.ID_PESSOA" &
                " INNER JOIN TB_OPCAO OPCAO_STSPS ON OPCAO_STSPS.SQ_OPCAO = PESSO_PACIE.ID_OPT_ATIVO" &
                " INNER JOIN TB_ENDERECO ENDER ON ENDER.ID_PESSOA = PESSO_PACIE.SQ_PESSOA" &
                " INNER JOIN TB_CIDADE CIDAD ON CIDAD.SQ_CIDADE = ENDER.ID_CIDADE" &
                 " LEFT JOIN TB_CLINICA_ATENDIMENTO CLATD ON AGEND.ID_PROCEDIMENTO = CLATD.ID_PROCEDIMENTO" &
                                                       " AND AGEND.ID_EMPRESA = CLATD.ID_EMPRESA" &
                                                       " AND AGEND.ID_PESSOA = CLATD.ID_PESSOA" &
                                                       " AND AGEND.ID_PESSOA_PROFISSIONAL = CLATD.ID_PESSOA_PROFISSIONAL" &
                                                       " AND AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                 " LEFT JOIN TB_PESSOA_PROFISSAO PACIE_PROFI ON PACIE_PROFI.ID_PESSOA = PESSO_PACIE.SQ_PESSOA" &
                 " LEFT JOIN TB_PROFISSAO PROFI ON PROFI.SQ_PROFISSAO = PACIE_PROFI.ID_PROFISSAO" &
                 " LEFT JOIN TB_TIPO_ESTADOCIVIL TPSTC ON TPSTC.SQ_TIPO_ESTADOCIVIL = PESSO_PACIE.ID_PF_TIPO_ESTADOCIVIL" &
                 " LEFT JOIN TB_CLINICA_EXAME_CITOLOGICO CECIT ON CECIT.ID_CLINICA_ATENDIMENTO = CLATD.SQ_CLINICA_ATENDIMENTO" &
                 " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO PSTEL ON PSTEL.ID_PESSOA = PESSO_PACIE.SQ_PESSOA" &
                 " LEFT JOIN TB_CLINICA_PROCEDIMENTO CLPCD ON CLPCD.ID_CLINICA_ATENDIMENTO = CLATD.SQ_CLINICA_ATENDIMENTO" &
               " WHERE PSTEL.IC_WHATSAPP = 'S'" &
                  " AND AGEND.CD_AGENDAMENTO IN ('AG486934', 'AG495459')" &
                  " AND AGEND.DH_AGENDAMENTO >= '23/06/2022'" &
                  " AND AGEND.DH_AGENDAMENTO <= '24/06/2022'" &
               " ORDER BY PESSO_PACIE.NO_PESSOA"
  End Sub

  Private Sub frmMensagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboGrupoProcedimento, enSql.GrupoProcedimento)
    ComboBox_Carregar(cboSexo, enSql.Sexo)
    ComboBox_Carregar(cboProfissao, enSql.Profissao)
    ComboBox_Carregar(cboConvenio, enSql.Convenio)
    ComboBox_Carregar(cboCidade, enSql.Cidade)
    ComboBox_Carregar(cboEstadoCivil, enSql.EstadoCivil)
    'ComboBox_Carregar(cboStatus, enSql.status)
  End Sub
End Class