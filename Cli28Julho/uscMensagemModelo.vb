Public Class uscMensagemModelo

  Public _CodigoMensagem As String
  Public _TextoMensagem As String

  Public Sub Carregar(CodigoMensagem As String, TextoMensagem As String)
    Dim sSqlText As String
    Dim oData As DataTable

    _CodigoMensagem = CodigoMensagem
    _TextoMensagem = TextoMensagem

    sSqlText = "SELECT * FROM TB_MENSAGEM_MODELO WHERE CD_MENSAGEM_MODELO = " & FNC_QuotedStr(CodigoMensagem)
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      richMensagem.Text = FNC_NVL(oData.Rows(0).Item("DS_MENSAGEM_MODELO"), "")
      txtImagemMensagem.Text = FNC_NVL(oData.Rows(0).Item("DS_PATH_IMAGEM"), "")
      txtCodigoUsuario.Text = FNC_NVL(oData.Rows(0).Item("CD_USUARIO"), "")
    End If

    oData.Dispose()
  End Sub

  Public Sub Gravar()
    Dim sSqlText As String

    If Trim(richMensagem.Text) = "" Then
      FNC_Mensagem("Informe o texto da " & _TextoMensagem)
      Exit Sub
    End If

    sSqlText = "UPDATE TB_MENSAGEM_MODELO" &
               " SET DS_MENSAGEM_MODELO = @DS_MENSAGEM_MODELO," +
                    "DS_PATH_IMAGEM = @DS_PATH_IMAGEM," +
                    "CD_USUARIO = @CD_USUARIO" &
               " WHERE CD_MENSAGEM_MODELO = @CD_MENSAGEM_MODELO"

    DBExecutar(sSqlText, DBParametro_Montar("DS_MENSAGEM_MODELO", richMensagem.Text, , , 8000),
                         DBParametro_Montar("DS_PATH_IMAGEM", txtImagemMensagem.Text, , , 8000),
                         DBParametro_Montar("CD_USUARIO", txtCodigoUsuario.Text),
                         DBParametro_Montar("CD_MENSAGEM_MODELO", _CodigoMensagem))
  End Sub

  Private Sub uscMensagemModelo_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    richMensagem.Width = Me.Width - (richMensagem.Left * 2)
  End Sub
End Class