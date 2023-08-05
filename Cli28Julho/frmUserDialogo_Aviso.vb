Public Class frmUserDialogo_Aviso
  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Public Property Mensagem As String
    Set(value As String)
      lblAviso.Text = value
    End Set
    Get
      Return lblAviso.Text
    End Get
  End Property
End Class