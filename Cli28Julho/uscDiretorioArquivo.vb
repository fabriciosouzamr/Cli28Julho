Public Class uscDiretorioArquivo
  Public Enum enDiretorioArquivo
    Arquivo = 1
    Diretorio = 2
  End Enum

  Public DiretorioArquivo As enDiretorioArquivo = enDiretorioArquivo.Diretorio

  Private Sub cmdAbrirDiretorioArquivo_Click(sender As Object, e As EventArgs) Handles cmdAbrirDiretorioArquivo.Click
    Select Case DiretorioArquivo
      Case enDiretorioArquivo.Arquivo
        txtDiretorioArquivo.Text = FNC_Arquivo_Dialogo_Abrir()
      Case enDiretorioArquivo.Diretorio
        txtDiretorioArquivo.Text = FNC_Pasta_Dialogo_Abrir()
    End Select
  End Sub

  Private Sub uscDiretorioArquivo_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    txtDiretorioArquivo.Width = Me.Width - txtDiretorioArquivo.Left
  End Sub

  Public Property Rotulo As String
    Get
      Return lblRDiretorioArquivo.Text
    End Get
    Set(value As String)
      lblRDiretorioArquivo.Text = value
    End Set
  End Property

  Public Property Diretorio As String
    Get
      Select Case DiretorioArquivo
        Case enDiretorioArquivo.Arquivo
          Return FNC_Path_Arquivo(txtDiretorioArquivo.Text)
        Case enDiretorioArquivo.Diretorio
          Return txtDiretorioArquivo.Text
        Case Else
          Return ""
      End Select
    End Get
    Set(value As String)
      txtDiretorioArquivo.Text = value
    End Set
  End Property

  Public Property Arquivo As String
    Get
      Return txtDiretorioArquivo.Text
    End Get
    Set(value As String)
      txtDiretorioArquivo.Text = value
    End Set
  End Property
End Class
