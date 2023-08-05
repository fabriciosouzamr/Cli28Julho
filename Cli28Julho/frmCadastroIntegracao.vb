Public Class frmCadastroIntegracao
  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    sSqlText = DBMontar_SP("SP_INTEGRACAO_UPD", False, "@SQ_INTEGRACAO",
                                                       "@DS_LINK",
                                                       "@CD_CHAVE_01",
                                                       "@CD_CHAVE_02",
                                                       "@CD_CHAVE_03",
                                                       "@CD_CHAVE_04",
                                                       "@CD_CHAVE_05",
                                                       "@TP_ATIVO")

    DBExecutar(sSqlText, DBParametro_Montar("SQ_INTEGRACAO", modDeclaracaoLocal.enIntegracao.eSisVida.GetHashCode(), , ParameterDirection.InputOutput),
                         DBParametro_Montar("DS_LINK", txtSisVida_LinkAPI.Text),
                         DBParametro_Montar("CD_CHAVE_01", txtSisVida_Login.Text),
                         DBParametro_Montar("CD_CHAVE_02", txtSisVida_Senha.Text),
                         DBParametro_Montar("CD_CHAVE_03", txtSisVida_CodLab.Text),
                         DBParametro_Montar("CD_CHAVE_04", txtSisVida_Integracao.Text),
                         DBParametro_Montar("CD_CHAVE_05", ""),
                         DBParametro_Montar("TP_ATIVO", IIf(chkSisVida_Ativo.Checked, "S", "N")))

    FNC_Mensagem("Gravação Efetuada")
  End Sub

  Private Sub frmCadastroIntegracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim sSqlText As String
    Dim oData As DataTable
    Dim iCont As Integer

    sSqlText = "SELECT * FROM TB_INTEGRACAO"
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      Select Case oData.Rows(iCont).Item("SQ_INTEGRACAO")
        Case modDeclaracaoLocal.enIntegracao.eSisVida
          txtSisVida_LinkAPI.Text = FNC_NVL(oData.Rows(iCont).Item("DS_LINK"), "")
          txtSisVida_Login.Text = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_01"), "")
          txtSisVida_Senha.Text = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_02"), "")
          txtSisVida_CodLab.Text = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_03"), "")
          txtSisVida_Integracao.Text = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_04"), "")
          chkSisVida_Ativo.Checked = (FNC_NVL(oData.Rows(iCont).Item("TP_ATIVO"), "") = "S")
      End Select
    Next
  End Sub
End Class