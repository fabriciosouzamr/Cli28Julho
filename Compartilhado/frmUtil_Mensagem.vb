Public Class frmUtil_Mensagem
  Private Sub frmUtil_Mensagem_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    If Not oFormMDI Is Nothing Then
      Me.Left = oFormMDI.Width - Me.Width - 50
      Me.Top = oFormMDI.Height - Me.Height - 50
    End If
  End Sub

  Private Sub frmUtil_Mensagem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    e.Cancel = True
    Me.Hide()
  End Sub
End Class