Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class cResponse
  Public chat_add_id As String
  Public chat_add_status As String
  Public code As Integer
  Public description As String
  Public result As String
End Class


Public Class modChatGuru
  Public sKey As String = "UPKZPO18E49W2I2J8NPUVYOF6T0MUYGYV71X1S8S4N3OUV3FYFDU8R4UN16STVZN"
  Public sAccountId As String = "625ea934822c38492819b7bf"
  Public sPhoneId As String = "625eaafbbb25ea2c81b31a4e"

  Dim oresponse As cResponse

  Public Function Enviar(sMensagem As String,
                         sNome As String,
                         sNumero As String,
                         sTitulo As String,
                         sArquivo As String) As Boolean
    If sNumero.Substring(0, 3) = "+55" Then
      Try
        message_send(sMensagem, sNome, sNumero, sTitulo, sArquivo)

        If oresponse Is Nothing Then
          Return False
        Else
          Return (oresponse.code = 201)
        End If
      Catch ex As Exception
        FNC_Mensagem(ex.Message)
      End Try
    Else
      Escrever(Now.ToString() + " - O contato " + sNome + " " + sNumero + " não está no formato certo")
      Escrever("--------------------------------------------------------------------------------")
    End If
  End Function

  Private Async Function message_send(sMensagem As String,
                                      sNome As String,
                                      sNumero As String,
                                      sTitulo As String,
                                      sArquivo As String) As Task(Of String)
    Try
      Await messag(sMensagem, sNome, sNumero, sTitulo, sArquivo)
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Function

  Private Async Function messag(sMensagem As String,
                                sNome As String,
                                sNumero As String,
                                sTitulo As String,
                                sArquivo As String) As Task(Of cResponse)
    Try
      Dim sLink As String

      oresponse = Nothing

      If Trim(sMensagem) <> "" Then
        sLink = "https://s15.chatguru.app/api/v1?key=" + sKey +
                                                "&account_id=" + sAccountId +
                                                "&phone_id=" + sPhoneId +
                                                "&action=message_send" +
                                                "&send_date=" + Now.ToString("yyyy-MM-dd HH:MM") +
                                                "&text=" + sMensagem +
                                                "&chat_number=" + sNumero

        Using httpClient = New HttpClient()
          Using response = Await httpClient.PostAsync(sLink, New StringContent(""))
            Dim apiResponse As String = Await response.Content.ReadAsStringAsync()
            Escrever(Now.ToString() + " - " + sLink)
            Escrever(apiResponse)
            Escrever("--------------------------------------------------------------------------------")

            Do While True
              Try
                oresponse = JsonConvert.DeserializeObject(Of cResponse)(apiResponse)

                If Not oresponse Is Nothing Then Exit Do
              Catch ex As Exception
              End Try
            Loop
          End Using
        End Using

        Select Case oresponse.code
          Case 400
            Await chat_add(sMensagem, sNome, sNumero)
        End Select
      End If

      If Trim(sArquivo) <> "" Then
        Await file(sNumero, sTitulo, sArquivo)
      End If
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Function

  Private Async Function file(sNumero As String,
                              sTitulo As String,
                              sArquivo As String) As Task(Of cResponse)
    Try
      Dim sLink As String

      oresponse = Nothing

      sLink = "https://s15.chatguru.app/api/v1?key=" + sKey +
                                              "&account_id=" + sAccountId +
                                              "&phone_id=" + sPhoneId +
                                              "&action=message_file_send&" +
                                              "&file_url=" + sArquivo +
                                              "&caption=" + sTitulo +
                                              "&chat_number=" + sNumero

      Using httpClient = New HttpClient()
        Using response = Await httpClient.PostAsync(sLink, New StringContent(""))
          Dim apiResponse As String = Await response.Content.ReadAsStringAsync()
          Escrever(Now.ToString() + " - " + sLink)
          Escrever(apiResponse)
          Escrever("--------------------------------------------------------------------------------")

          Do While True
            Try
              oresponse = JsonConvert.DeserializeObject(Of cResponse)(apiResponse)

              If Not oresponse Is Nothing Then Exit Do
            Catch ex As Exception
            End Try
          Loop
        End Using
      End Using
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Function

  Private Async Function chat_add(sMensagem As String,
                                  sNome As String,
                                  sNumero As String) As Task(Of cResponse)
    Try
      Dim sLink As String

      oresponse = Nothing

      sLink = "https://s15.chatguru.app/api/v1?key=" + sKey +
                                              "&account_id=" + sAccountId +
                                              "&phone_id=" + sPhoneId +
                                              "&action=chat_add" +
                                              "&userid=62751112349e6fb1558e498cADMIN" +
                                              "&name=" + sNome +
                                              "&text=" + sMensagem +
                                              "&chat_number=" + sNumero +
                                              "&dialog_id=628b8aa42e02590fd0a4da4b"

      Using httpClient = New HttpClient()
        Using response = Await httpClient.PostAsync(sLink, New StringContent(""))
          Dim apiResponse As String = Await response.Content.ReadAsStringAsync()
          Escrever(Now.ToString() + " - " + sLink)
          Escrever(apiResponse)
          Escrever("--------------------------------------------------------------------------------")

          Do While True
            Try
              oresponse = JsonConvert.DeserializeObject(Of cResponse)(apiResponse)

              If Not oresponse Is Nothing Then Exit Do
            Catch ex As Exception
            End Try
          Loop
        End Using
      End Using
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Function

  Private Function Escrever(sTexto As String) As String
    Try
      sArquivo = FNC_Diretorio_Tratar(Diretorio()) + Now.ToString("yyyy-MM-dd HHMM") + ".log"

      fluxoTexto = New IO.StreamWriter(CStr(sArquivo), True)
      fluxoTexto.WriteLine(sTexto)
      fluxoTexto.Close()

      Return sArquivo
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Function

  Private Function Diretorio() As String
    Try
      sDir = FNC_Diretorio_Tratar(sPathSistema) & "LogZap"

      If Not System.IO.Directory.Exists(sDir) Then
        System.IO.Directory.CreateDirectory(sDir)
      End If

      Return sDir
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Function
End Class
