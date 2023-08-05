Public Class frmConsultaAtendimentoMeuContaReceber
  Class cMeuContasReceber
    Public Data As String
    Public Titulo As String
    Public Valor As Double
  End Class

  Dim oMeuContasReceber_EmAberto() As cMeuContasReceber
  Dim oMeuContasReceber_Recebido() As cMeuContasReceber

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Médico_MeuContasReceber))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub frmConsultaAtendimentoMeuContaReceber_Load(sender As Object, e As EventArgs) Handles Me.Load
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdListarEmAberto.Formatar(enOpcoes.ConfiguracaoTela_Botao_Listar)
    cmdListarRecebido.Formatar(enOpcoes.ConfiguracaoTela_Botao_Listar)

    txtDataEmAberto_Inicial.Value = Nothing
    txtDataEmAberto_Final.Value = Nothing
    txtDataRecebido_Inicial.Value = Nothing
    txtDataRecebido_Final.Value = Nothing

    vsbEmAberto.SmallChange = 1
    vsbEmAberto.LargeChange = 1

    vsbRecebido.SmallChange = 1
    vsbRecebido.LargeChange = 1

    LimparEmAberto()
    LimparRecebido()
  End Sub

  Private Sub cmdListarEmAberto_Click(sender As Object, e As EventArgs) Handles cmdListarEmAberto.Click
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iIndice As Integer = 0
    Dim iQuantidade As Integer
    Dim dValorTotal As Double

    sSqlText = "SELECT DT_QUITACAO," &
                      "CD_MOVFINANCEIRA," &
                      "VL_QUITADO" &
               " FROM VW_MOVFINANCEIRAPARCELA" &
               "  WHERE VL_QUITADO > 0" &
                  " AND ID_PESSOA = " & iID_USUARIO

    If IsDate(txtDataEmAberto_Inicial.Text) Then
      sSqlText = sSqlText &
                 " AND DT_QUITACAO >= " & FNC_QuotedStr(txtDataEmAberto_Inicial.Text)
    End If
    If IsDate(txtDataEmAberto_Final.Text) Then
      sSqlText = sSqlText &
                 " And DT_QUITACAO <= " & FNC_QuotedStr(txtDataEmAberto_Final.Text)
    End If
    oData = DBQuery(sSqlText)

    If objDataTable_Vazio(oData) Then
      oMeuContasReceber_EmAberto = Nothing
    Else
      ReDim oMeuContasReceber_EmAberto(oData.Rows.Count - 1)

      iQuantidade = oData.Rows.Count

      For Each oRow As DataRow In oData.Rows
        oMeuContasReceber_EmAberto(iIndice) = New cMeuContasReceber()

        With oMeuContasReceber_EmAberto(iIndice)
          .Data = oRow.Item("DT_QUITACAO").ToString().Substring(0, 10)
          .Titulo = oRow.Item("CD_MOVFINANCEIRA")
          .Valor = oRow.Item("VL_QUITADO")

          dValorTotal = dValorTotal + .Valor
        End With

        iIndice = iIndice + 1
      Next
    End If

    If oMeuContasReceber_EmAberto Is Nothing Then
      vsbEmAberto.Enabled = False
    Else
      vsbEmAberto.Enabled = (oMeuContasReceber_EmAberto.Length > 7)
      If oMeuContasReceber_EmAberto.Length - 7 > 0 Then vsbEmAberto.Maximum = oMeuContasReceber_EmAberto.Length - 6
    End If

    vsbEmAberto.Value = 1

    ListarEmAberto()

    lblTotalValorAberto.Text = FormatCurrency(dValorTotal)
  End Sub

  Private Sub ListarEmAberto()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    LimparEmAberto()

    For iCont = vsbEmAberto.Value - 1 To vsbEmAberto.Value + 5
      Try
        Me.Controls(Me.Controls.IndexOfKey("lblDataAberto" + FNC_StrZero(iLabel, 2))).Text = oMeuContasReceber_EmAberto(iCont).Data
        Me.Controls(Me.Controls.IndexOfKey("lblTituloAberto" + FNC_StrZero(iLabel, 2))).Text = oMeuContasReceber_EmAberto(iCont).Titulo
        Me.Controls(Me.Controls.IndexOfKey("lblValorAberto" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oMeuContasReceber_EmAberto(iCont).Valor)
      Catch ex As Exception
        Me.Controls(Me.Controls.IndexOfKey("lblDataAberto" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblTituloAberto" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblValorAberto" + FNC_StrZero(iLabel, 2))).Text = ""
      End Try

      iLabel = iLabel + 1
    Next
  End Sub

  Private Sub ListarRecebido()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    LimparRecebido()

    For iCont = vsbRecebido.Value - 1 To vsbRecebido.Value + 5
      Try
        Me.Controls(Me.Controls.IndexOfKey("lblDataRecebido" + FNC_StrZero(iLabel, 2))).Text = oMeuContasReceber_Recebido(iCont).Data
        Me.Controls(Me.Controls.IndexOfKey("lblTituloRecebido" + FNC_StrZero(iLabel, 2))).Text = oMeuContasReceber_Recebido(iCont).Titulo
        Me.Controls(Me.Controls.IndexOfKey("lblValorRecebido" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oMeuContasReceber_Recebido(iCont).Valor)
      Catch ex As Exception
        Me.Controls(Me.Controls.IndexOfKey("lblDataRecebido" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblTituloRecebido" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblValorAberto" + FNC_StrZero(iLabel, 2))).Text = ""
      End Try

      iLabel = iLabel + 1
    Next
  End Sub

  Private Sub LimparEmAberto()
    For iCont = 1 To 7
      Me.Controls(Me.Controls.IndexOfKey("lblDataAberto" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblTituloAberto" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblValorAberto" + FNC_StrZero(iCont, 2))).Text = ""
    Next
  End Sub

  Private Sub LimparRecebido()
    For iCont = 1 To 7
      Me.Controls(Me.Controls.IndexOfKey("lblDataRecebido" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblTituloAberto" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblValorAberto" + FNC_StrZero(iCont, 2))).Text = ""
    Next
  End Sub

  Private Sub cmdListarRecebido_Click(sender As Object, e As EventArgs) Handles cmdListarRecebido.Click
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iIndice As Integer = 0
    Dim iQuantidade As Integer
    Dim dValorTotal As Double

    sSqlText = "SELECT DT_VENCIMENTO," &
                      "CD_MOVFINANCEIRA," &
                      "VL_DEBITO" &
               " FROM VW_MOVFINANCEIRAPARCELA" &
               "  WHERE VL_DEBITO > 0" &
                  " AND ID_PESSOA = " & iID_USUARIO

    If IsDate(txtDataEmAberto_Inicial.Text) Then
      sSqlText = sSqlText &
                 " AND DT_VENCIMENTO >= " & FNC_QuotedStr(txtDataEmAberto_Inicial.Text)
    End If
    If IsDate(txtDataEmAberto_Final.Text) Then
      sSqlText = sSqlText &
                 " And DT_VENCIMENTO <= " & FNC_QuotedStr(txtDataEmAberto_Final.Text)
    End If
    oData = DBQuery(sSqlText)

    If objDataTable_Vazio(oData) Then
      oMeuContasReceber_Recebido = Nothing
    Else
      ReDim oMeuContasReceber_Recebido(oData.Rows.Count - 1)

      iQuantidade = oData.Rows.Count

      For Each oRow As DataRow In oData.Rows
        oMeuContasReceber_Recebido(iIndice) = New cMeuContasReceber()

        With oMeuContasReceber_Recebido(iIndice)
          .Data = oRow.Item("DT_QUITACAO").ToString().Substring(0, 10)
          .Titulo = oRow.Item("CD_MOVFINANCEIRA")
          .Valor = oRow.Item("VL_QUITADO")

          dValorTotal = dValorTotal + .Valor
        End With

        iIndice = iIndice + 1
      Next
    End If

    If oMeuContasReceber_Recebido Is Nothing Then
      vsbRecebido.Enabled = False
    Else
      vsbRecebido.Enabled = (oMeuContasReceber_Recebido.Length > 7)
      If oMeuContasReceber_Recebido.Length - 7 > 0 Then vsbRecebido.Maximum = oMeuContasReceber_Recebido.Length - 6
    End If

    vsbRecebido.Value = 1

    ListarRecebido()

    lblTotalValorRecebido.Text = FormatCurrency(dValorTotal)
  End Sub

  Private Sub vsbRecebido_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbRecebido.Scroll
    ListarRecebido()
  End Sub

  Private Sub vsbEmAberto_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbEmAberto.Scroll
    ListarEmAberto()
  End Sub
End Class