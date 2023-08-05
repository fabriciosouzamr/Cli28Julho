Public Class frmConsultaVendaCancelamento
  Public iID_CLINICA_VENDA As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If txtMotivoCancelamento.Text.Trim() = "" Then
      FNC_Mensagem("Informe o motivo do cancelamennto")
      Exit Sub
    End If

    Dim sSqlText As String

    Try
      sSqlText = DBMontar_SP("SP_CLINICA_VENDA_CANCELAR_UPD", False, "@ID_CLINICA_VENDA",
                                                                     "@DH_CANCELAR",
                                                                     "@CM_OBSERVACAO_CANCELAMENTO")
      If DBExecutar(sSqlText, DBParametro_Montar("ID_CLINICA_VENDA", iID_CLINICA_VENDA),
                              DBParametro_Montar("DH_CANCELAR", Now(), SqlDbType.DateTime),
                              DBParametro_Montar("CM_OBSERVACAO_CANCELAMENTO", txtMotivoCancelamento.Text)) Then
        FNC_Mensagem("Cancelamento realizado")
      End If
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub
End Class