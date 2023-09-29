Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaFluxoCaixa
  Const const_GridListagem_SQ_MOVFINANCEIRA As Integer = 0
  Const const_GridListagem_ID_MOVFINANCEIRAPARCELA As Integer = 1
  Const const_GridListagem_ID_OPT_STATUS As Integer = 2
  Const const_GridListagem_Check As Integer = 3
  Const const_GridListagem_TipoMovimentacaoFinanceiraContas As Integer = 4
  Const const_GridListagem_CodigoParcela As Integer = 5
  Const const_GridListagem_Status As Integer = 6
  Const const_GridListagem_ContaFinanceira_Debito As Integer = 7
  Const const_GridListagem_ContaFinanceira_Credito As Integer = 8
  Const const_GridListagem_DescricaoLancamento As Integer = 9
  Const const_GridListagem_TipoDocumento As Integer = 10
  Const const_GridListagem_Lancamento As Integer = 11
  Const const_GridListagem_Vencimento As Integer = 12
  Const const_GridListagem_Quitacao As Integer = 13
  Const const_GridListagem_ValorParcela As Integer = 14
  Const const_GridListagem_Compensacao As Integer = 15
  Const const_GridListagem_DiasAtraso As Integer = 16
  Const const_GridListagem_Juros As Integer = 17
  Const const_GridListagem_Multa As Integer = 18
  Const const_GridListagem_Emitente As Integer = 19
  Const const_GridListagem_ValorParcelaReal As Integer = 20
  Const const_GridListagem_Justificativa As Integer = 21

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaFluxoCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing

    ComboBox_Carregar(cboTipoMovimentacao, enSql.TipoMovimentacaoFinanceiraContas)
    ComboBox_Carregar(cboContaCaixa, enSql.ContaCaixa)
    ComboBox_Carregar(cboContaBancaria, enSql.ContaBancaria)
    ComboBox_Carregar(cboTipoDocumento, enSql.TipoDocumento)
    ComboBox_Carregar(cboPlanoContas, enSql.PlanoContas)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_MOVFINANCEIRAPARCELA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdListagem, "..", 50, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdListagem, "Tipo de Movimentação Financeira", 200)
    objGrid_Coluna_Add(grdListagem, "Código Parcela", 110)
    objGrid_Coluna_Add(grdListagem, "Status", 150)
    objGrid_Coluna_Add(grdListagem, "Conta de Débito", 150)
    objGrid_Coluna_Add(grdListagem, "Conta de Crédito", 150)
    objGrid_Coluna_Add(grdListagem, "Descrição do Lançamento", 300)
    objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 150)
    objGrid_Coluna_Add(grdListagem, "Lançamento", 150)
    objGrid_Coluna_Add(grdListagem, "Vencimento", 150)
    objGrid_Coluna_Add(grdListagem, "Quitação", 150)
    objGrid_Coluna_Add(grdListagem, "Valor Parcela", 150, , , ColumnStyle.Currency, , , , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Compensação", 150, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdListagem, "Dias em Atraso", 150)
    objGrid_Coluna_Add(grdListagem, "Juros", 150, , , ColumnStyle.Currency, , , , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Multa", 150, , , ColumnStyle.Currency, , , , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Emitente", 150)
    objGrid_Coluna_Add(grdListagem, "ValorParcelaReal", 0)
    objGrid_Coluna_Add(grdListagem, "Justificativa", 1000)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    cmdNovo.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaFluxodeCaixa).bIncluir
    cmdAlterar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaFluxodeCaixa).bAlterar
    cmdCancelar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaFluxodeCaixa).bExcluir
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(New frmLancaFluxoCaixa)
  End Sub

  Private Sub cboContaCaixa_KeyDown(sender As Object, e As KeyEventArgs) Handles cboContaCaixa.KeyDown
    If e.KeyCode = Keys.Delete Then cboContaCaixa.SelectedIndex = -1
  End Sub

  Private Sub cboTipoMovimentacao_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoMovimentacao.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoMovimentacao.SelectedIndex = -1
  End Sub

  Private Sub cboContaBancaria_KeyDown(sender As Object, e As KeyEventArgs) Handles cboContaBancaria.KeyDown
    If e.KeyCode = Keys.Delete Then cboContaBancaria.SelectedIndex = -1
  End Sub

  Private Sub cboTipoDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoDocumento.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoDocumento.SelectedIndex = -1
  End Sub

  Private Sub cboPlanoContas_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPlanoContas.KeyDown
    If e.KeyCode = Keys.Delete Then cboPlanoContas.SelectedIndex = -1
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser alterado")
      Exit Sub
    End If

    Dim oForm As New frmLancaFluxoCaixa

    oForm.iSQ_MOVFINANCEIRA = objGrid_Valor(grdListagem, const_GridListagem_SQ_MOVFINANCEIRA)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser cancelada")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusMovimentacaoFinanceira_Cancelada.GetHashCode Then
      FNC_Mensagem("Movimentação já cancelada")
      Exit Sub
    End If

    If Not FNC_Perguntar("Deseja realmente cancelar esse lançamento?") Then Exit Sub

    Dim oForm As New frmConsultaContasReceberPagarCancelamento

    oForm.iProcessoInterno = const_ProcessoInterno_ConsultaContasReceberPagarCancelamento_FluxoCaixa
    oForm.iSQ_MOVFINANCEIRAPARCELA = objGrid_Valor(grdListagem, const_GridListagem_ID_MOVFINANCEIRAPARCELA)
    oForm.dVL_CANCELAMENTO = Val(objGrid_Valor(grdListagem, const_GridListagem_ValorParcelaReal))

    FNC_AbriTela(oForm,, True, True)

    oForm.Dispose()
    oForm = Nothing

    Pesquisar()

Sair:
  End Sub

  Private Sub frmConsultaPedidoVenda_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdCancelar.Top = cmdNovo.Top
    cmdExcel.Top = cmdNovo.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdNovo.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""

    sSqlText = "SELECT MFN.SQ_MOVFINANCEIRA," &
                      "MFP.SQ_MOVFINANCEIRAPARCELA," &
                      "MFP.ID_OPT_STATUS," &
                      "0," &
                      "TM.NO_TIPOMOVIMENTACAOFINANCEIRACONTAS," &
                      "CONCAT(MFN.CD_MOVFINANCEIRA, '-', MFP.CD_PARCELA) CD_MOVFINANCEIRA_PARCELA," &
                      "STS.NO_OPCAO," &
                      "CCD.NO_CONTAFINANCEIRA," &
                      "CCC.NO_CONTAFINANCEIRA," &
                      "MFN.DS_MOVFINANCEIRA," &
                      "TDC.NO_TIPO_DOCUMENTO," &
                      "MFN.DT_MOVIMENTACAO," &
                      "MFP.DT_VENCIMENTO," &
                      "MFP.DT_QUITACAO," &
                      "(MFP.VL_PARCELA) * TMF.VL_MULTIPLICADOR," &
                      "MFP.DT_COMPENSACAO," &
                      "IIf(DateDiff(Day, MFP.DT_VENCIMENTO, ISNULL(MFP.DT_QUITACAO, GETDATE())) < 1, 0, DateDiff(Day, MFP.DT_VENCIMENTO, ISNULL(MFP.DT_QUITACAO, GETDATE())))," &
                      "IIf(DateDiff(Day, MFP.DT_VENCIMENTO, ISNULL(MFP.DT_QUITACAO, GETDATE())) < 1, 0, (MFP.VL_PARCELA * MFN.PC_JUROS / 100 / 30) * DateDiff(Day, MFP.DT_VENCIMENTO, ISNULL(MFP.DT_QUITACAO, GETDATE())))," &
                      "IIf(DateDiff(Day, MFP.DT_VENCIMENTO, ISNULL(MFP.DT_QUITACAO, GETDATE())) < 1, 0, MFN.VL_MULTA)," &
                      "MFP.DS_EMITENTE," &
                      "MFP.VL_PARCELA," &
                      "MFN.CM_MOVFINANCEIRA" &
               " FROM TB_MOVFINANCEIRA MFN" &
                " INNER JOIN VW_TIPOMOVIMENTACAOFINANCEIRACONTAS TM ON TM.SQ_TIPOMOVIMENTACAOFINANCEIRACONTAS = MFN.ID_OPT_TIPOMOVFINANCEIRA" &
                " INNER JOIN TB_MOVFINANCEIRAPARCELA MFP ON MFP.ID_MOVFINANCEIRA = MFN.SQ_MOVFINANCEIRA" &
                " INNER JOIN TB_OPCAO STS ON STS.SQ_OPCAO = MFP.ID_OPT_STATUS" &
                " INNER JOIN TB_OPCAO TMF ON TMF.SQ_OPCAO = MFN.ID_OPT_TIPOMOVFINANCEIRA" &
                 " LEFT JOIN TB_PESSOA PES ON PES.SQ_PESSOA = MFN.ID_PESSOA" &
                 " LEFT JOIN TB_TIPO_DOCUMENTO TDC ON TDC.SQ_TIPO_DOCUMENTO = MFP.ID_TIPO_DOCUMENTO" &
                 " LEFT JOIN TB_CONTAFINANCEIRA CCC ON CCC.SQ_CONTAFINANCEIRA = MFN.ID_CONTAFINANCEIRA_CREDITO" &
                 " LEFT JOIN TB_CONTAFINANCEIRA CCD ON CCD.SQ_CONTAFINANCEIRA = MFN.ID_CONTAFINANCEIRA_DEBITO" &
                 " LEFT JOIN TB_CONTAFINANCEIRA CFC ON CFC.SQ_CONTAFINANCEIRA = MFP.ID_CONTAFINANCEIRA_COMPENSACAO" &
               " WHERE MFN.ID_EMPRESA = " & iID_EMPRESA_FILIAL

    If ComboBox_Selecionado(cboTipoMovimentacao) Then
      FNC_Str_Adicionar(sSqlText_Where, "MFN.ID_OPT_TIPOMOVFINANCEIRA = " & cboTipoMovimentacao.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboContaBancaria) Or ComboBox_Selecionado(cboContaCaixa) Then
      FNC_Str_Adicionar(sSqlText_Where, "(MFN.ID_CONTAFINANCEIRA_CREDITO IN (" & FNC_NVL(cboContaCaixa.SelectedValue, 0) & "," & FNC_NVL(cboContaBancaria.SelectedValue, 0) & ") OR " & _
                                         "MFN.ID_CONTAFINANCEIRA_DEBITO IN (" & FNC_NVL(cboContaCaixa.SelectedValue, 0) & "," & FNC_NVL(cboContaBancaria.SelectedValue, 0) & "))", " AND ")
    End If
    If ComboBox_Selecionado(cboTipoDocumento) Then
      FNC_Str_Adicionar(sSqlText_Where, "MFP.ID_TIPO_DOCUMENTO = " & cboTipoDocumento.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboPlanoContas) Then
      FNC_Str_Adicionar(sSqlText_Where, "MFN.SQ_MOVFINANCEIRA IN (SELECT ID_MOVFINANCEIRA" & _
                                                                 " FROM TB_MOVFINANCEIRA_PLANOCONTAS" & _
                                                                 " WHERE ID_PLANOCONTAS = " & cboPlanoContas.SelectedValue & ")", " AND ")
    End If
    If IsDate(txtDataInicial.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, "(MFN.DT_MOVIMENTACAO >= " & FNC_QuotedStr(txtDataInicial.Text) & " OR " & _
                                         "MFP.DT_VENCIMENTO >= " & FNC_QuotedStr(txtDataInicial.Text) & " OR " & _
                                         "MFP.DT_QUITACAO >= " & FNC_QuotedStr(txtDataInicial.Text) & " OR " & _
                                         "MFP.DT_COMPENSACAO >= " & FNC_QuotedStr(txtDataInicial.Text) & ")", " AND ")
    End If
    If IsDate(txtDataFinal.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, "(MFN.DT_MOVIMENTACAO <= " & FNC_QuotedStr(txtDataFinal.Text) & " OR " & _
                                         "MFP.DT_VENCIMENTO <= " & FNC_QuotedStr(txtDataFinal.Text) & " OR " & _
                                         "MFP.DT_QUITACAO <= " & FNC_QuotedStr(txtDataFinal.Text) & " OR " & _
                                         "MFP.DT_COMPENSACAO <= " & FNC_QuotedStr(txtDataFinal.Text) & ")", " AND ")
    End If
    If Trim(txtCodMovimentacao.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "MFN.CD_MOVFINANCEIRA LIKE " & FNC_SQL_FormatarLike(txtCodMovimentacao.Text), " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " AND " & sSqlText_Where
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_MOVFINANCEIRA,
                                                           const_GridListagem_ID_MOVFINANCEIRAPARCELA,
                                                           const_GridListagem_ID_OPT_STATUS,
                                                           const_GridListagem_Check,
                                                           const_GridListagem_TipoMovimentacaoFinanceiraContas,
                                                           const_GridListagem_CodigoParcela,
                                                           const_GridListagem_Status,
                                                           const_GridListagem_ContaFinanceira_Debito,
                                                           const_GridListagem_ContaFinanceira_Credito,
                                                           const_GridListagem_DescricaoLancamento,
                                                           const_GridListagem_TipoDocumento,
                                                           const_GridListagem_Lancamento,
                                                           const_GridListagem_Vencimento,
                                                           const_GridListagem_Quitacao,
                                                           const_GridListagem_ValorParcela,
                                                           const_GridListagem_Compensacao,
                                                           const_GridListagem_DiasAtraso,
                                                           const_GridListagem_Juros,
                                                           const_GridListagem_Multa,
                                                           const_GridListagem_Emitente,
                                                           const_GridListagem_ValorParcelaReal,
                                                           const_GridListagem_Justificativa})
    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_ValorParcela,
                                                    const_GridListagem_Juros,
                                                    const_GridListagem_Multa})

    lblRListagemPessoa.Text = lblRListagemPessoa.Tag & " (" & grdListagem.Rows.Count & " registro(s))"
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub frmConsultaFluxoCaixa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboContaBancaria.SelectedIndex = -1
    cboContaCaixa.SelectedIndex = -1
    cboPlanoContas.SelectedIndex = -1
    cboTipoDocumento.SelectedIndex = -1
    cboTipoMovimentacao.SelectedIndex = -1
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
    txtCodMovimentacao.Text = ""
  End Sub

  Private Sub grdListagem_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grdListagem.DoubleClickCell
    cmdAlterar.PerformClick()
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub FrmConsultaFluxoCaixa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.F3 Then
      cmdPesquisar.PerformClick()
    End If
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser alterado")
      Exit Sub
    End If

    FormRelatorioFinanceiro_Comprovante_Transferencia(objGrid_Valor(grdListagem, const_GridListagem_ID_MOVFINANCEIRAPARCELA))
  End Sub
End Class