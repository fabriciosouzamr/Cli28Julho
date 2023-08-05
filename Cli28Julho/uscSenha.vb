Public Class uscSenha
  Private Sub picVisualizar_MouseEnter(sender As Object, e As EventArgs) Handles picVisualizar.MouseEnter
    txtSenha.PasswordChar = ""
  End Sub

  Private Sub picVisualizar_MouseLeave(sender As Object, e As EventArgs) Handles picVisualizar.MouseLeave
    txtSenha.PasswordChar = "*"
  End Sub

  Private Sub uscSenha_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    picVisualizar.Left = Me.Width - picVisualizar.Width
    txtSenha.Width = picVisualizar.Left - 2
    txtSenha.Height = Me.Height
    picVisualizar.Top = ((Me.Height - picVisualizar.Height) / 2)
  End Sub

  Public Property Senha() As String
    Get
      Return txtSenha.Text
    End Get
    Set(value As String)
      txtSenha.Text = value
    End Set
  End Property
End Class
