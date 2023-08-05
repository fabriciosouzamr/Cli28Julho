Public Class modLogger
  Public Sub Escrever(sTexto As String)
    sArquivo = Now.ToString() + ".log"

    fluxoTexto = New IO.StreamWriter(CStr(sArquivo))
    fluxoTexto.WriteLine(sTexto)
    fluxoTexto.Close()
  End Sub

  Private Function Diretorio() As String
    sDir = FNC_Diretorio_Tratar(sPathSistema) & "LogZap"

    If Not System.IO.Directory.Exists(sDir) Then
      System.IO.Directory.CreateDirectory(sDir)
    End If

    Return sDir
  End Function
End Class
