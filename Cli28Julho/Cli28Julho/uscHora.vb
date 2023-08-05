Public Class uscHora
  Public Property Hora As String
    Get
      Try
        Return FNC_StrZero(txtHora.Text, 2) + ":" + FNC_StrZero(txtMinuto.Text, 2)
      Catch ex As Exception
        Return ":"
      End Try
    End Get
    Set(value As String)
      Try
        txtHora.Text = FNC_StrZero(value.Substring(0, value.IndexOf(":")), 2)
        txtMinuto.Text = value.Substring(value.IndexOf(":") + 1)
      Catch ex As Exception
        txtHora.Text = ""
        txtMinuto.Text = ""
      End Try
    End Set
  End Property

  Public Property SomenteLeitura As Boolean
    Get
      Return txtHora.ReadOnly
    End Get
    Set(value As Boolean)
      txtHora.ReadOnly = value
      txtMinuto.ReadOnly = value
    End Set
  End Property

  Private Sub uscHora_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      txtHora.Text = ""
      txtMinuto.Text = ""
    Catch ex As Exception
    End Try
  End Sub
End Class
