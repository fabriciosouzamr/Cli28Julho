Public Class frmConsultaAtendimentoMinhasFaturas
  Class cMinhasFaturas
    Public CD_CLINICA_VENDA As String
    Public DATA As String
    Public PACIENTE As String
    Public PROCEDIMENTO As String
    Public TIPO_ATENDIMENTO As String
    Public Valor As Double
    Public VlPrestador As Double
  End Class

  Dim oMinhasFaturas() As cMinhasFaturas

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_MinhasFaturas))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub frmConsultaAtendimentoMinhasFaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cmdListar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Listar)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)

    txtDataInicial.Value = Date.Now.Date
    txtDataFinal.Value = Date.Now.Date

    Pesquisa()

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1

    optConsultas.Checked = True

    LimparMinhasFaturas()
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdListar_Clicado(sender As Object) Handles cmdListar.Clicado
    Pesquisa()
  End Sub

  Private Sub Pesquisa()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iIndice As Integer = 0
    Dim iQuantidade As Integer
    Dim dValorTotal As Double
    Dim dVlPrestadorTotal As Double

    sSqlText = "SELECT CLVND.CD_CLINICA_VENDA," &
                      "CLVND.DH_VENDA," &
                      "PESSO.NO_PESSOA," &
                      "PROCE.NO_PROCEDIMENTO," &
                      "ISNULL(IIF(CLVND.ID_ORCAMENTO_CLIENTE IS NOT NULL, 'Exames', TPCST.NO_TIPO_CONSULTA), 'Venda Direta') NO_TIPO_ATENDIMENTO," &
                      "CVDPC.VL_PROCEDIMENTO," &
                      "CVDPC.VL_REPASSE" &
               " FROM TB_CLINICA_VENDA CLVND" &
                " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVDPC ON CVDPC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVDPC.ID_PROCEDIMENTO" &
                " INNER JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CVDPC.ID_AGENDAMENTO" &
                 " LEFT JOIN TB_TIPO_CONSULTA TPCST ON TPCST.SQ_TIPO_CONSULTA = AGEND.ID_TIPO_CONSULTA" &
               " WHERE CVDPC.ID_PESSOA_PROFISSIONAL = " & iID_USUARIO &
                 " AND AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Atendido.GetHashCode()

    If optConsultas.Checked Then
      sSqlText = sSqlText &
                 " AND PROCE.ID_OPT_TIPOPROCEDIMENTO = " & enOpcoes.TipoProcedimento_Procedimento.GetHashCode()
    Else
      sSqlText = sSqlText &
                 " AND PROCE.ID_OPT_TIPOPROCEDIMENTO = " & enOpcoes.TipoProcedimento_Exame.GetHashCode()
    End If
    If IsDate(txtDataInicial.Text) Then
      sSqlText = sSqlText & " AND CAST(CLVND.DH_VENDA AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text)
    End If
    If IsDate(txtDataFinal.Text) Then
      sSqlText = sSqlText & " AND CAST(CLVND.DH_VENDA AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text)
    End If

    oData = DBQuery(sSqlText)

    If objDataTable_Vazio(oData) Then
      oMinhasFaturas = Nothing
    Else
      ReDim oMinhasFaturas(oData.Rows.Count - 1)

      iQuantidade = oData.Rows.Count

      For Each oRow As DataRow In oData.Rows
        oMinhasFaturas(iIndice) = New cMinhasFaturas()

        With oMinhasFaturas(iIndice)
          .CD_CLINICA_VENDA = oRow.Item("CD_CLINICA_VENDA")
          .DATA = oRow.Item("DH_VENDA").ToString().Substring(0, 10)
          .PACIENTE = oRow.Item("NO_PESSOA")
          .PROCEDIMENTO = oRow.Item("NO_PROCEDIMENTO")
          .TIPO_ATENDIMENTO = oRow.Item("NO_TIPO_ATENDIMENTO")
          .Valor = oRow.Item("VL_PROCEDIMENTO")
          .VlPrestador = oRow.Item("VL_REPASSE")

          dValorTotal = dValorTotal + .Valor
          dVlPrestadorTotal = dVlPrestadorTotal + .VlPrestador
        End With

        iIndice = iIndice + 1
      Next
    End If

    If oMinhasFaturas Is Nothing Then
      VScrollBar.Enabled = False
    Else
      VScrollBar.Enabled = (oMinhasFaturas.Length > 7)
      If oMinhasFaturas.Length - 7 > 0 Then VScrollBar.Maximum = oMinhasFaturas.Length - 6
    End If

    VScrollBar.Value = 1

    ListarMinhasFaturas()

    lblQuantidade.Text = iQuantidade
    lblVlPrestadorTotal.Text = FormatCurrency(dVlPrestadorTotal)
  End Sub

  Private Sub ListarMinhasFaturas()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    LimparMinhasFaturas()

    For iCont = VScrollBar.Value - 1 To VScrollBar.Value + 5
      Try
        Me.Controls(Me.Controls.IndexOfKey("lblCodAutoiza" + FNC_StrZero(iLabel, 2))).Text = oMinhasFaturas(iCont).CD_CLINICA_VENDA
        Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = oMinhasFaturas(iCont).DATA
        Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iLabel, 2))).Text = oMinhasFaturas(iCont).PACIENTE
        Me.Controls(Me.Controls.IndexOfKey("lblProcedimentoExame" + FNC_StrZero(iLabel, 2))).Text = oMinhasFaturas(iCont).PROCEDIMENTO
        Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = oMinhasFaturas(iCont).TIPO_ATENDIMENTO
        Me.Controls(Me.Controls.IndexOfKey("lblVlPrestador" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oMinhasFaturas(iCont).VlPrestador)
      Catch ex As Exception
        Me.Controls(Me.Controls.IndexOfKey("lblCodAutoiza" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblProcedimentoExame" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblVlPrestador" + FNC_StrZero(iLabel, 2))).Text = ""
      End Try

      iLabel = iLabel + 1
    Next
  End Sub

  Private Sub LimparMinhasFaturas()
    For iCont = 1 To 7
      Me.Controls(Me.Controls.IndexOfKey("lblCodAutoiza" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblProcedimentoExame" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblVlPrestador" + FNC_StrZero(iCont, 2))).Text = ""
    Next
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    ListarMinhasFaturas()
  End Sub

  Private Sub cmdFinanceiro_Click(sender As Object, e As EventArgs)
    Dim oForm As New frmConsultaAtendimentoMeuContaReceber

    oForm.Formatar()

    FNC_AbriTela(oForm, , True, True)
  End Sub
End Class