Public Class frmCadastroAtendimentoOftalmologico
  Public iID_CLINICA_ATENDIMENTO As Integer
  Dim iSQ_CLINICA_OFTAMOLOGIA As Integer

  Private Sub frmCadastroAtendimentoOftalmologico_Load(sender As Object, e As EventArgs) Handles Me.Load
    lblProntuario.Text = ""
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)
    Carregar()
  End Sub

  Private Sub Carregar()
    Dim oData As DataTable
    Dim sSqlText As String

    If iID_CLINICA_ATENDIMENTO > 0 Then
      sSqlText = "SELECT CLATD.ID_PESSOA," &
                        "PESSO.NO_PESSOA," &
                        "CLRCT.SQ_CLINICA_OFTAMOLOGIA," &
                        "CLRCT.DT_VALIDADE_RECEITA," &
                        "CLRCT.NR_LONGEOD_ESFERICO," &
                        "CLRCT.NR_LONGEOD_CILINDRO," &
                        "CLRCT.NR_LONGEOD_EIXO," &
                        "CLRCT.NR_LONGEOE_ESFERICO," &
                        "CLRCT.NR_LONGEOE_CILINDRO," &
                        "CLRCT.NR_LONGEOE_EIXO," &
                        "CLRCT.NR_PERTOAO_ESFERICO," &
                        "CLRCT.CM_OBSERVACAO" &
                 " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                  " LEFT JOIN TB_CLINICA_OFTAMOLOGIA CLRCT ON CLRCT.ID_CLINICA_ATENDIMENTO = CLATD.SQ_CLINICA_ATENDIMENTO" &
                  " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                 " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        Dim oRow As DataRow = oData.Rows(0)

        lblPessoa.Text = oRow.Item("NO_PESSOA")
        lblProntuario.Text = oRow.Item("ID_PESSOA")

        If Not objDataTable_CampoVazio(oRow.Item("SQ_CLINICA_OFTAMOLOGIA")) Then
          iSQ_CLINICA_OFTAMOLOGIA = oRow.Item("SQ_CLINICA_OFTAMOLOGIA")
          txtValidade.Value = oRow.Item("DT_VALIDADE_RECEITA")
          numParaLongeOdEsferico.Text = FNC_NVL(oRow.Item("NR_LONGEOD_ESFERICO"), "")
          numParaLongeOdCilindrico.Text = FNC_NVL(oRow.Item("NR_LONGEOD_CILINDRO"), "")
          numParaLongeOdEixo.Text = FNC_NVL(oRow.Item("NR_LONGEOD_EIXO"), "")
          numParaLongeOeEsferico.Text = FNC_NVL(oRow.Item("NR_LONGEOE_ESFERICO"), "")
          numParaLongeOeCilindrico.Text = FNC_NVL(oRow.Item("NR_LONGEOE_CILINDRO"), "")
          numParaLongeOeEixo.Text = FNC_NVL(oRow.Item("NR_LONGEOE_EIXO"), "")
          numParaPertoAOEsferico.Text = FNC_NVL(oRow.Item("NR_PERTOAO_ESFERICO"), "")
          rtbObservacao.Text = FNC_NVL(oRow.Item("CM_OBSERVACAO"), "")
        Else
          txtValidade.Value = Now().Date
        End If
      End If
    End If

    txtDataReceituario.Value = Now().Date
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    Gravar(True)
  End Sub

  Private Sub Gravar(ExibirMensagem As Boolean)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CLINICA_OFTAMOLOGIA_CAD", False, "@SQ_CLINICA_OFTAMOLOGIA OUT",
                                                                "@DH_CLINICA_OFTAMOLOGIA",
                                                                "@ID_CLINICA_ATENDIMENTO",
                                                                "@DT_VALIDADE_RECEITA",
                                                                "@NR_LONGEOD_ESFERICO",
                                                                "@NR_LONGEOD_CILINDRO",
                                                                "@NR_LONGEOD_EIXO",
                                                                "@NR_LONGEOE_ESFERICO",
                                                                "@NR_LONGEOE_CILINDRO",
                                                                "@NR_LONGEOE_EIXO",
                                                                "@NR_PERTOAO_ESFERICO",
                                                                "@CM_OBSERVACAO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_OFTAMOLOGIA", iSQ_CLINICA_OFTAMOLOGIA, , ParameterDirection.InputOutput),
                            DBParametro_Montar("DH_CLINICA_OFTAMOLOGIA", txtDataReceituario.Value),
                            DBParametro_Montar("ID_CLINICA_ATENDIMENTO", iID_CLINICA_ATENDIMENTO),
                            DBParametro_Montar("DT_VALIDADE_RECEITA", txtValidade.Value),
                            DBParametro_Montar("NR_LONGEOD_ESFERICO", numParaLongeOdEsferico.Text),
                            DBParametro_Montar("NR_LONGEOD_CILINDRO", numParaLongeOdCilindrico.Text),
                            DBParametro_Montar("NR_LONGEOD_EIXO", numParaLongeOdEixo.Text),
                            DBParametro_Montar("NR_LONGEOE_ESFERICO", numParaLongeOeEsferico.Text),
                            DBParametro_Montar("NR_LONGEOE_CILINDRO", numParaLongeOeCilindrico.Text),
                            DBParametro_Montar("NR_LONGEOE_EIXO", numParaLongeOeEixo.Text),
                            DBParametro_Montar("NR_PERTOAO_ESFERICO", numParaPertoAOEsferico.Text),
                            DBParametro_Montar("CM_OBSERVACAO", rtbObservacao.Text, SqlDbType.Text, , const_BancoDados_TamanhoComentario)) Then
      If DBTeveRetorno() Then
        iSQ_CLINICA_OFTAMOLOGIA = DBRetorno(1)
      End If

      If ExibirMensagem Then
        FNC_Mensagem("Gravação Efetuada")
      End If
    End If
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    Gravar(False)

    FormRelatorioOfalmotologia(iSQ_CLINICA_OFTAMOLOGIA, chkImprimir.Checked)
  End Sub
End Class