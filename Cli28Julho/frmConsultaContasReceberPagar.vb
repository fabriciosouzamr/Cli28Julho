Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Cli28Julho.frmConsultaHistorico_Registro

Public Class frmConsultaContasReceberPagar
  Const const_GridListagem_ID_MOVFINANCEIRA As Integer = 0
  Const const_GridListagem_SQ_MOVFINANCEIRAPARCELA As Integer = 1
  Const const_GridListagem_ID_OPT_STATUS As Integer = 2
  Const const_GridListagem_Check As Integer = 3
  Const const_GridListagem_CodigoParcela As Integer = 4
  Const const_GridListagem_CodigoDocumento As Integer = 5
  Const const_GridListagem_TipoMovimentacaoFinanceira As Integer = 6
  Const const_GridListagem_Status As Integer = 7
  Const const_GridListagem_ContaFinanceira As Integer = 8
  Const const_GridListagem_Pessoa As Integer = 9
  Const const_GridListagem_DescricaoLancamento As Integer = 10
  Const const_GridListagem_TipoDocumento As Integer = 11
  Const const_GridListagem_Lancamento As Integer = 12
  Const const_GridListagem_Vencimento As Integer = 13
  Const const_GridListagem_Quitacao As Integer = 14
  Const const_GridListagem_UltPagamento As Integer = 15
  Const const_GridListagem_ValorParcela As Integer = 16
  Const const_GridListagem_ValorDesconto As Integer = 17
  Const const_GridListagem_ValorQuitado As Integer = 18
  Const const_GridListagem_ValorDevolucao As Integer = 19
  Const const_GridListagem_JurosPago As Integer = 20
  Const const_GridListagem_MultaPaga As Integer = 21
  Const const_GridListagem_ValorDescontoPagto As Integer = 22
  Const const_GridListagem_ValorAcrescimoPagto As Integer = 23
  Const const_GridListagem_ValorImpostoRetido As Integer = 24
  Const const_GridListagem_SaldoDevedor As Integer = 25
  Const const_GridListagem_Compensacao As Integer = 26
  Const const_GridListagem_DiasAtraso As Integer = 27
  Const const_GridListagem_Juros As Integer = 28
  Const const_GridListagem_Multa As Integer = 29
  Const const_GridListagem_PerCalcJuros As Integer = 30
  Const const_GridListagem_PerCalcDesconto As Integer = 31
  Const const_GridListagem_PerTaxaCompensacao As Integer = 32
  Const const_GridListagem_ValorTaxaCompensacao As Integer = 33
  Const const_GridListagem_Emitente As Integer = 34
  Const const_GridListagem_Segmento As Integer = 35
  Const const_GridListagem_IC_COMPENSADO As Integer = 36
  Const const_GridListagem_ID_OPT_STATUS_MOVIMENTACAO As Integer = 37
  Const const_GridListagem_ID_OPT_TIPOMOVFINANCEIRA As Integer = 38
  Const const_GridListagem_ID_PESSOA As Integer = 39
  Const const_GridListagem_CodigoVenda As Integer = 40
  Const const_GridListagem_CodigoMovimentacaoGerada As Integer = 41
  Const const_GridListagem_ID_MOVFINANCEIRAGERADA As Integer = 42
  Const const_GridListagem_CondicaoPagamento As Integer = 43

  Public iTipoMovimentacao As Integer

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaContasReceberPagar_Load(sender As Object, e As EventArgs) Handles Me.Load
    ComboBox_Carregar(cboTipoMovimentacaoFinanceira, enSql.TipoMovimentacaoFinanceiraRecebePagar)
    ComboBox_Carregar(cboTipoDocumento, enSql.TipoDocumento)
    ComboBox_Carregar(cboContaBancaria, enSql.ContaBancaria)
    ComboBox_Carregar(cboContaCaixa, enSql.ContaCaixa)
    ComboBox_Carregar(cboStatus, enSql.Grupo_E_StatusMovimentacaoFinanceira)
    ComboBox_CarregarPeriodoData_MovFinanceira(cboTipoPeriodo)

    ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode)
    ComboBox_Selecionar(cboTipoPeriodo, const_PeriodoData_MovFinanceira_Vencimento)

    If iTipoMovimentacao > 0 Then
      ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, iTipoMovimentacao)
      Me.Text = "Consulta de " + cboTipoMovimentacaoFinanceira.Text
      cboTipoMovimentacaoFinanceira.Enabled = False
    End If

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "ID_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_MOVFINANCEIRAPARCELA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdListagem, "..", 50, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdListagem, "Código Parcela", 110)
    objGrid_Coluna_Add(grdListagem, "Código Documento", 150)
    objGrid_Coluna_Add(grdListagem, "Tipo da Movimentação Financeira", 0)
    objGrid_Coluna_Add(grdListagem, "Status", 150)
    objGrid_Coluna_Add(grdListagem, "Conta Caixa", 150)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 300)
    objGrid_Coluna_Add(grdListagem, "Descrição do Lançamento", 300)
    objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 150)
    objGrid_Coluna_Add(grdListagem, "Lançamento", 100)
    objGrid_Coluna_Add(grdListagem, "Vencimento", 100, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdListagem, "Quitação", 100, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdListagem, "Ult. Pagamento", 100, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdListagem, "Valor Parcela", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Valor Desconto", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Valor Quitado", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Valor Devolução", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Juros Pago", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Multa Paga", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Valor Desconto Pagto", 140, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Valor Acréscimo Pagto", 140, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Valor Imposto Retido", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Saldo Devedor", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Compensação", 100, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdListagem, "Dias em Atraso", 100)
    objGrid_Coluna_Add(grdListagem, "Juros Pendente", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Multa Pendente", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Per. Calc. Juros", 100)
    objGrid_Coluna_Add(grdListagem, "Per. Calc. Desconto", 100)
    objGrid_Coluna_Add(grdListagem, "Per. Taxa de Compensação", 100, , , ColumnStyle.Currency, , const_Formato_Porcentagem, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Valor Taxa de Compensação", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdListagem, "Emitente", 150)
    objGrid_Coluna_Add(grdListagem, "Segmento", 150)
    objGrid_Coluna_Add(grdListagem, "IC_COMPENSADO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_STATUS_MOVIMENTACAO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_TIPOMOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA", 0)
    objGrid_Coluna_Add(grdListagem, "Código Venda", 150)
    objGrid_Coluna_Add(grdListagem, "Código Movimentação Gerada", 150)
    objGrid_Coluna_Add(grdListagem, "ID_MOVFINANCEIRAGERADA", 0)
    objGrid_Coluna_Add(grdListagem, "Condição de Pagamento", 300)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    txtDataInicial.Text = ""
    txtDataFinal.Text = ""

    Select Case iTipoMovimentacao
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar
        cmdAlterar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
        cmdCancelar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bExcluir
        cmdQuitar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bExcluir
        cmdRenegociar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
        cmdQuitar_Excluir.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
        cmdTransferir.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
        ComboBox_Carregar(cboCondicaoPagamento, enSql.CondicaoPagamento_Venda)
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber
        cmdAlterar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
        cmdCancelar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bExcluir
        cmdQuitar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bExcluir
        cmdRenegociar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
        cmdQuitar_Excluir.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
        cmdTransferir.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
        ComboBox_Carregar(cboCondicaoPagamento, enSql.CondicaoPagamento_Recebimento)
    End Select
  End Sub

  Private Sub cboTipoMovimentacaoFinanceira_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTipoMovimentacaoFinanceira.SelectedValueChanged
    If cboTipoMovimentacaoFinanceira.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode Then
      ComboBox_Carregar(cboPlanoContas, enSql.PlanoContas_Credito.GetHashCode)
    Else
      ComboBox_Carregar(cboPlanoContas, enSql.PlanoContas_Debito.GetHashCode)
    End If
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Aux As String
    Dim sSqlText_Where As String = ""

    sSqlText = "SELECT MFP.ID_MOVFINANCEIRA," &
                      "MFP.SQ_MOVFINANCEIRAPARCELA," &
                      "MFP.ID_OPT_STATUS," &
                      "0," &
                      "MFP.CD_MOVFINANCEIRA_PARCELA," &
                      "MFP.CD_DOCUMENTO," &
                      "TMV.NO_OPCAO NO_OPT_TIPOMOVFINANCEIRA," &
                      "MFP.NO_OPT_STATUS," &
                      "ISNULL(MFP.NO_CONTAFINANCEIRA_COMPENSACAO, IIF(MFN.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() & ", CCC.NO_CONTAFINANCEIRA, CCD.NO_CONTAFINANCEIRA))," &
                      "PES.NO_PESSOA," &
                      "MFN.DS_MOVFINANCEIRA," &
                      "TDC.NO_TIPO_DOCUMENTO," &
                      "MFN.DT_MOVIMENTACAO," &
                      "MFP.DT_VENCIMENTO," &
                      "MFP.DT_QUITACAO," &
                      "MUP.DT_ULT_PAGAMENTO," &
                      "MFP.VL_PARCELA," &
                      "MFP.VL_DESCONTO," &
                      "MFP.VL_QUITADO," &
                      "MFP.VL_DEVOLUCAO," &
                      "MFP.VL_MULTA," &
                      "MFP.VL_JUROS," &
                      "MFP.VL_ACRESCIMO_PAGTO," &
                      "MFP.VL_DESCONTO_PAGTO," &
                      "ISNULL(MFP.VL_IMPOSTORETIDO, 0) VL_IMPOSTORETIDO," &
                      "MFP.VL_DEBITO," &
                      "MFP.DT_COMPENSACAO," &
                      "MFP.QT_DIAS_ATRASO," &
                      "MFP.VL_CALC_JUROS," &
                      "MFP.VL_CALC_MULTA," &
                      "MFP.NO_OPT_PERIODOCALCULOFINANCEIRO_JUROS," &
                      "MFP.NO_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO," &
                      "MFP.DS_EMITENTE," &
                      "SMT.NO_SEGMENTO," &
                      "MFP.IC_COMPENSADO," &
                      "MFN.ID_OPT_STATUS," &
                      "MFN.ID_OPT_TIPOMOVFINANCEIRA," &
                      "MFN.ID_PESSOA," &
                      "CLVND.CD_CLINICA_VENDA," &
                      "MFP.CD_MOVFINANCEIRAGERADA," &
                      "MFPGD.ID_MOVFINANCEIRAGERADA," &
                      "MFP.PC_TAXA_COMPENSACAO / 100," &
                      "MFP.VL_TAXA_COMPENSACAO," &
                      "MFP.NO_CONDICAOPAGAMENTO" &
               " FROM TB_MOVFINANCEIRA MFN" &
                " INNER JOIN VW_MOVFINANCEIRAPARCELA MFP ON MFP.ID_MOVFINANCEIRA = MFN.SQ_MOVFINANCEIRA" &
                 " LEFT JOIN (SELECT DISTINCT ID_MOVFINANCEIRAGERADA FROM TB_MOVFINANCEIRAPARCELA WHERE ID_MOVFINANCEIRAGERADA IS NOT NULL) MFPGD ON MFPGD.ID_MOVFINANCEIRAGERADA = MFN.SQ_MOVFINANCEIRA" &
                 " LEFT JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = MFN.ID_CLINICA_VENDA" &
                 " LEFT JOIN TB_OPCAO TMV ON TMV.SQ_OPCAO = MFN.ID_OPT_TIPOMOVFINANCEIRA" &
                 " LEFT JOIN TB_PESSOA PES ON PES.SQ_PESSOA = MFN.ID_PESSOA" &
                 " LEFT JOIN TB_TIPO_DOCUMENTO TDC ON TDC.SQ_TIPO_DOCUMENTO = MFP.ID_TIPO_DOCUMENTO" &
                 " LEFT JOIN TB_CONTAFINANCEIRA CCC ON CCC.SQ_CONTAFINANCEIRA = MFN.ID_CONTAFINANCEIRA_CREDITO" &
                 " LEFT JOIN TB_CONTAFINANCEIRA CCD ON CCD.SQ_CONTAFINANCEIRA = MFN.ID_CONTAFINANCEIRA_DEBITO" &
                 " LEFT JOIN TB_SEGMENTO SMT ON SMT.SQ_SEGMENTO = MFN.ID_SEGMENTO" &
                 " LEFT JOIN VW_MOVFINANCEIRAPAGTO_ULTPAGTO MUP ON MUP.ID_MOVFINANCEIRAPARCELA = MFP.SQ_MOVFINANCEIRAPARCELA"

    If ComboBox_Selecionado(cboTipoMovimentacaoFinanceira) Then
      FNC_Str_Adicionar(sSqlText_Where, "MFN.ID_OPT_TIPOMOVFINANCEIRA = " & cboTipoMovimentacaoFinanceira.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboContaCaixa) Then
      If cboTipoMovimentacaoFinanceira.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode Then
        FNC_Str_Adicionar(sSqlText_Where, "MFN.ID_CONTAFINANCEIRA_CREDITO = " & cboContaCaixa.SelectedValue, " AND ")
      Else
        FNC_Str_Adicionar(sSqlText_Where, "MFN.ID_CONTAFINANCEIRA_DEBITO = " & cboContaCaixa.SelectedValue, " AND ")
      End If
    End If
    If ComboBox_Selecionado(cboContaBancaria) Then
      sSqlText_Aux = "SELECT MVFPG.ID_MOVFINANCEIRAPARCELA" &
                     " FROM VW_PAGAMENTOITEM PAGIT" &
                      " INNER JOIN TB_MOVFINANCEIRAPAGTO MVFPG ON MVFPG.ID_PAGAMENTO = PAGIT.ID_PAGAMENTO" &
                     " WHERE PAGIT.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                       " AND PAGIT.ID_CONTAFINANCEIRA = " & cboContaBancaria.SelectedValue
      FNC_Str_Adicionar(sSqlText_Where, "MFP.SQ_MOVFINANCEIRAPARCELA IN (" & sSqlText_Aux & ")", " AND ")
    End If
    If txtCodigoPagamento.Text.Trim() <> "" Then
      sSqlText_Aux = "SELECT MVFPG.ID_MOVFINANCEIRAPARCELA" &
                     " FROM TB_PAGAMENTO PAGTO" &
                      " INNER JOIN TB_MOVFINANCEIRAPAGTO MVFPG ON MVFPG.ID_PAGAMENTO = PAGTO.SQ_PAGAMENTO" &
                     " WHERE PAGTO.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                       " AND PAGTO.CD_PAGAMENTO Like " & FNC_SQL_FormatarLike(txtCodigoPagamento.Text)
      FNC_Str_Adicionar(sSqlText_Where, "MFP.SQ_MOVFINANCEIRAPARCELA IN (" & sSqlText_Aux & ")", " AND ")
    End If
    If txtCodigoDocumento.Text.Trim() <> "" Then
      sSqlText_Aux = "SELECT SQ_MOVFINANCEIRAPARCELA" &
                     " FROM TB_MOVFINANCEIRAPARCELA A" &
                      " INNER JOIN TB_MOVFINANCEIRA B ON B.SQ_MOVFINANCEIRA = A.ID_MOVFINANCEIRA" &
                     " WHERE B.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                       " AND A.CD_DOCUMENTO Like " & FNC_SQL_FormatarLike(txtCodigoDocumento.Text)
      FNC_Str_Adicionar(sSqlText_Where, "MFP.SQ_MOVFINANCEIRAPARCELA IN (" & sSqlText_Aux & ")", " AND ")
    End If
    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "MFN.ID_PESSOA = " & psqPessoa.ID_Pessoa, " AND ")
    End If
    If ComboBox_Selecionado(cboTipoDocumento) Then
      FNC_Str_Adicionar(sSqlText_Where, "MFP.ID_TIPO_DOCUMENTO = " & cboTipoDocumento.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboPlanoContas) Then
      FNC_Str_Adicionar(sSqlText_Where, "MFN.SQ_MOVFINANCEIRA IN (SELECT ID_MOVFINANCEIRA" &
                                                                 " FROM TB_MOVFINANCEIRA_PLANOCONTAS" &
                                                                 " WHERE ID_PLANOCONTAS = " & cboPlanoContas.SelectedValue & ")", " AND ")
    End If
    If IsDate(txtDataInicial.Text) Then
      Select Case FNC_NVL(cboTipoPeriodo.SelectedValue, const_PeriodoData_MovFinanceira_Vencimento)
        Case const_PeriodoData_MovFinanceira_Lancamento
          FNC_Str_Adicionar(sSqlText_Where, "CAST(MFN.DT_MOVIMENTACAO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text), " AND ")
        Case const_PeriodoData_MovFinanceira_Quitacao
          FNC_Str_Adicionar(sSqlText_Where, "CAST(MFP.DT_QUITACAO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text), " AND ")
        Case const_PeriodoData_MovFinanceira_UltimoPagto
          FNC_Str_Adicionar(sSqlText_Where, "CAST(MUP.DT_ULT_PAGAMENTO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text), " AND ")
        Case const_PeriodoData_MovFinanceira_Vencimento
          FNC_Str_Adicionar(sSqlText_Where, "CAST(MFP.DT_VENCIMENTO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text), " AND ")
      End Select
    End If
    If IsDate(txtDataFinal.Text) Then
      Select Case FNC_NVL(cboTipoPeriodo.SelectedValue, const_PeriodoData_MovFinanceira_Vencimento)
        Case const_PeriodoData_MovFinanceira_Lancamento
          FNC_Str_Adicionar(sSqlText_Where, "CAST(MFN.DT_MOVIMENTACAO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text), " AND ")
        Case const_PeriodoData_MovFinanceira_Quitacao
          FNC_Str_Adicionar(sSqlText_Where, "CAST(MFP.DT_QUITACAO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text), " AND ")
        Case const_PeriodoData_MovFinanceira_UltimoPagto
          FNC_Str_Adicionar(sSqlText_Where, "CAST(MUP.DT_ULT_PAGAMENTO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text), " AND ")
        Case const_PeriodoData_MovFinanceira_Vencimento
          FNC_Str_Adicionar(sSqlText_Where, "CAST(MFP.DT_VENCIMENTO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text), " AND ")
      End Select
    End If
    If ComboBox_Selecionado(cboStatus) Then
      If Convert.ToInt32(cboStatus.SelectedValue) = 0 Then
        FNC_Str_Adicionar(sSqlText_Where, "MFP.CD_OPT_STATUS = " & FNC_QuotedStr(cboStatus.SelectedItem(enComboBox_Grupo_E_StatusMovimentacaoFinanceira.CD_OPCAO)), " AND ")
      Else
        FNC_Str_Adicionar(sSqlText_Where, "MFP.ID_OPT_STATUS = " & cboStatus.SelectedValue, " AND ")
      End If
    End If
    If Trim(txtCodMovimentacao.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "MFN.CD_MOVFINANCEIRA LIKE " & FNC_SQL_FormatarLike(txtCodMovimentacao.Text), " AND ")
    End If
    If chkSomentePendentesCompesacao.Checked Then
      FNC_Str_Adicionar(sSqlText_Where, "MFP.IC_COMPENSADO = 'N'", " AND ")
    End If
    If ComboBox_Selecionado(cboCondicaoPagamento) Then
      FNC_Str_Adicionar(sSqlText_Where, "MFP.ID_CONDICAOPAGAMENTO = " & cboCondicaoPagamento.SelectedValue, " AND ")
    End If

    sSqlText = sSqlText & " WHERE MFN.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                            " AND MFN.ID_OPT_STATUS NOT IN (" & enOpcoes.StatusMovimentacaoFinanceira_Cancelada & ")" &
                            " AND MFP.ID_OPT_STATUS NOT IN (" & enOpcoes.StatusMovimentacaoFinanceira_Cancelada & "," &
                                                                enOpcoes.StatusMovimentacaoFinanceira_Faturado & ")"

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " AND " & sSqlText_Where
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_MOVFINANCEIRA,
                                                           const_GridListagem_SQ_MOVFINANCEIRAPARCELA,
                                                           const_GridListagem_ID_OPT_STATUS,
                                                           const_GridListagem_Check,
                                                           const_GridListagem_CodigoParcela,
                                                           const_GridListagem_CodigoDocumento,
                                                           const_GridListagem_TipoMovimentacaoFinanceira,
                                                           const_GridListagem_Status,
                                                           const_GridListagem_ContaFinanceira,
                                                           const_GridListagem_Pessoa,
                                                           const_GridListagem_DescricaoLancamento,
                                                           const_GridListagem_TipoDocumento,
                                                           const_GridListagem_Lancamento,
                                                           const_GridListagem_Vencimento,
                                                           const_GridListagem_Quitacao,
                                                           const_GridListagem_UltPagamento,
                                                           const_GridListagem_ValorParcela,
                                                           const_GridListagem_ValorDesconto,
                                                           const_GridListagem_ValorQuitado,
                                                           const_GridListagem_ValorDevolucao,
                                                           const_GridListagem_JurosPago,
                                                           const_GridListagem_MultaPaga,
                                                           const_GridListagem_ValorDescontoPagto,
                                                           const_GridListagem_ValorAcrescimoPagto,
                                                           const_GridListagem_ValorImpostoRetido,
                                                           const_GridListagem_SaldoDevedor,
                                                           const_GridListagem_Compensacao,
                                                           const_GridListagem_DiasAtraso,
                                                           const_GridListagem_Juros,
                                                           const_GridListagem_Multa,
                                                           const_GridListagem_PerCalcJuros,
                                                           const_GridListagem_PerCalcDesconto,
                                                           const_GridListagem_Emitente,
                                                           const_GridListagem_Segmento,
                                                           const_GridListagem_IC_COMPENSADO,
                                                           const_GridListagem_ID_OPT_STATUS_MOVIMENTACAO,
                                                           const_GridListagem_ID_OPT_TIPOMOVFINANCEIRA,
                                                           const_GridListagem_ID_PESSOA,
                                                           const_GridListagem_CodigoVenda,
                                                           const_GridListagem_CodigoMovimentacaoGerada,
                                                           const_GridListagem_ID_MOVFINANCEIRAGERADA,
                                                           const_GridListagem_PerTaxaCompensacao,
                                                           const_GridListagem_ValorTaxaCompensacao,
                                                           const_GridListagem_CondicaoPagamento})
    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_ValorParcela,
                                                    const_GridListagem_ValorQuitado,
                                                    const_GridListagem_JurosPago,
                                                    const_GridListagem_MultaPaga,
                                                    const_GridListagem_ValorDescontoPagto,
                                                    const_GridListagem_ValorAcrescimoPagto,
                                                    const_GridListagem_ValorDevolucao,
                                                    const_GridListagem_SaldoDevedor,
                                                    const_GridListagem_Juros,
                                                    const_GridListagem_Multa,
                                                    const_GridListagem_ValorTaxaCompensacao})

    lblRListagemPessoa.Text = lblRListagemPessoa.Tag & " (" & grdListagem.Rows.Count & " registro(s))"
  End Sub

  Private Sub cboContaCaixa_KeyDown(sender As Object, e As KeyEventArgs) Handles cboContaCaixa.KeyDown
    If e.KeyCode = Keys.Delete Then cboContaCaixa.SelectedIndex = -1
  End Sub

  Private Sub cboContaBancaria_KeyDown(sender As Object, e As KeyEventArgs) Handles cboContaBancaria.KeyDown
    If e.KeyCode = Keys.Delete Then cboContaBancaria.SelectedIndex = -1
  End Sub

  Private Sub cboPlanoContas_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPlanoContas.KeyDown
    If e.KeyCode = Keys.Delete Then cboPlanoContas.SelectedIndex = -1
  End Sub

  Private Sub cboTipoDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoDocumento.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoDocumento.SelectedIndex = -1
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub cmdQuitar_Click(sender As Object, e As EventArgs) Handles cmdQuitar.Click
    BaixarParcelas(enContasReceberPagar_TipoBaixa.Quitacao)
  End Sub

  Private Sub BaixarParcelas(eTipoBaixa As enContasReceberPagar_TipoBaixa)
    If objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagem_Check) <= 0 Then
      Select Case eTipoBaixa
        Case enContasReceberPagar_TipoBaixa.Quitacao
          FNC_Mensagem("Selecione a(s) parcela(s) a ser(em) quitada(s)")
        Case enContasReceberPagar_TipoBaixa.Renegociacao
          FNC_Mensagem("Selecione a(s) parcela(s) a ser(em) renegociada(s)")
      End Select

      Exit Sub
    End If

    Dim iCont As Integer
    Dim cSQ_MOVFINANCEIRAPARCELA = New Collection
    Dim cID_PESSOA = New Collection

    For iCont = 0 To grdListagem.Rows.Count - 1
      If objGrid_CheckCol_Valor(grdListagem, const_GridListagem_Check, iCont) = "S" Then
        If Not (objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS, iCont) = enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode Or
                objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS, iCont) = enOpcoes.StatusMovimentacaoFinanceira_QuitadaParcialmente.GetHashCode Or
                (objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS, iCont) = enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode And
                 bEMPRESA_IC_QUITAR_PROVISIONADO)) Then
          Select Case eTipoBaixa
            Case enContasReceberPagar_TipoBaixa.Quitacao
              FNC_Mensagem("A parcela precisa está no status ""Aberto"" ou ""Parcialmente Quitada"" para ser quitada")
            Case enContasReceberPagar_TipoBaixa.Renegociacao
              FNC_Mensagem("A parcela precisa está no status ""Aberto"" ou ""Parcialmente Quitada"" para ser renegociada")
          End Select

          Exit Sub
        End If

        cSQ_MOVFINANCEIRAPARCELA.Add(grdListagem.Rows(iCont).Cells(const_GridListagem_SQ_MOVFINANCEIRAPARCELA).Value)
        cID_PESSOA.Add(grdListagem.Rows(iCont).Cells(const_GridListagem_ID_PESSOA).Value)
      End If
    Next

    If cSQ_MOVFINANCEIRAPARCELA.Count > 0 Then
      Select Case eTipoBaixa
        Case enContasReceberPagar_TipoBaixa.Quitacao
          Dim oForm As New frmLancaContasReceberPagar_Quitar

          AddHandler oForm.RegerarConsulta, AddressOf Pesquisar

          oForm.iTipoMovimentacao = cboTipoMovimentacaoFinanceira.SelectedValue
          oForm.sTipoMovimentacao = cboTipoMovimentacaoFinanceira.Text
          oForm.cSQ_MOVFINANCEIRAPARCELA = cSQ_MOVFINANCEIRAPARCELA
          oForm.cID_PESSOA = cID_PESSOA
          FNC_AbriTela(oForm, , True, True)

          oForm.Dispose()
          oForm = Nothing
        Case enContasReceberPagar_TipoBaixa.Renegociacao
          Dim oForm As New frmLancaContasReceberPagar

          AddHandler oForm.RegerarConsulta, AddressOf Pesquisar

          oForm.iTipoMovimentacao = cboTipoMovimentacaoFinanceira.SelectedValue
          oForm.eOperacao = enContasReceberPagar_TipoBaixa.Renegociacao.GetHashCode()
          oForm.cSQ_MOVFINANCEIRAPARCELA = cSQ_MOVFINANCEIRAPARCELA
          FNC_AbriTela(oForm, , True, True)

          oForm.Dispose()
          oForm = Nothing
      End Select
    Else
      Select Case eTipoBaixa
        Case enContasReceberPagar_TipoBaixa.Quitacao
          FNC_Mensagem("É preciso selecionar as contas a serem quitadas")
        Case enContasReceberPagar_TipoBaixa.Renegociacao
          FNC_Mensagem("É preciso selecionar as contas a serem renegociadas")
      End Select
    End If
  End Sub

  Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser cancelado")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusMovimentacaoFinanceira_Cancelada.GetHashCode Then
      FNC_Mensagem("Parcela já cancelada")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_SaldoDevedor) = 0 Then
      FNC_Mensagem("Não existe saldo a ser cancelado para essa parcela. Exclua quitações, caso queira excluir a movimentação")
      Exit Sub
    End If

    Dim oForm As New frmConsultaContasReceberPagarCancelamento

    oForm.iProcessoInterno = const_ProcessoInterno_ConsultaContasReceberPagarCancelamento_ContasPagarReceber
    oForm.iSQ_MOVFINANCEIRAPARCELA = objGrid_Valor(grdListagem, const_GridListagem_SQ_MOVFINANCEIRAPARCELA)
    oForm.dVL_CANCELAMENTO = Val(objGrid_Valor(grdListagem, const_GridListagem_SaldoDevedor))

    FNC_AbriTela(oForm,, True, True)

    oForm.Dispose()
    oForm = Nothing

    Pesquisar()

    FNC_Mensagem("Cancelamento Efetuado")

Sair:
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser alterado")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS_MOVIMENTACAO) = enOpcoes.StatusMovimentacaoFinanceira_Cancelada.GetHashCode Then
      FNC_Mensagem("Essa movimentação está cancelada, por isso não pode ser alterada")
      Exit Sub
    End If

    Dim oForm As New frmLancaContasReceberPagar

    oForm.bAlteracaoSimples = True
    oForm.iTipoMovimentacao = cboTipoMovimentacaoFinanceira.SelectedValue
    oForm.iSQ_MOVFINANCEIRA = objGrid_Valor(grdListagem, const_GridListagem_ID_MOVFINANCEIRA)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs)
    Dim oForm As New frmLancaContasReceberPagar

    oForm.bLancamentoManual = True
    oForm.iTipoMovimentacao = FNC_NVL(cboTipoMovimentacaoFinanceira.SelectedValue, 0)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cboStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles cboStatus.KeyDown
    If e.KeyCode = Keys.Delete Then cboStatus.SelectedIndex = -1
  End Sub

  Private Sub frmConsultaPedidoVenda_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdAlterar.Left = 5
    cmdAlterar.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdCancelar.Top = cmdAlterar.Top
    cmdQuitar.Top = cmdAlterar.Top
    cmdRenegociar.Top = cmdAlterar.Top
    cmdQuitar_Excluir.Top = cmdAlterar.Top
    cmdExcel.Top = cmdAlterar.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdAlterar.Top
    cmdPDF.Top = cmdAlterar.Top
    cmdTransferir.Top = cmdAlterar.Top
    cmdImprimir.Top = cmdAlterar.Top
    cmdHistorico.Top = cmdAlterar.Top
    cmdPrestacaoContas.Top = cmdAlterar.Top
    cmdItensFaturados.Top = cmdAlterar.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdQuitar_Excluir_Click(sender As Object, e As EventArgs) Handles cmdQuitar_Excluir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser excluído")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusMovimentacaoFinanceira_Cancelada.GetHashCode Then
      FNC_Mensagem("Parcela já cancelada")
      Exit Sub
    End If

    Dim oForm As New frmLancaContasReceberPagar_Quitar_Exclusao

    oForm.iID_MOVFINANCEIRAPARCELA = objGrid_Valor(grdListagem, const_GridListagem_SQ_MOVFINANCEIRAPARCELA)

    FNC_AbriTela(oForm, , True, True)

Sair:
  End Sub

  Private Sub cmdRenegociar_Click(sender As Object, e As EventArgs) Handles cmdRenegociar.Click
    BaixarParcelas(enContasReceberPagar_TipoBaixa.Renegociacao)
  End Sub

  Private Sub frmConsultaContasReceberPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub grdListagem_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grdListagem.DoubleClickCell
    cmdAlterar.PerformClick()
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboContaBancaria.SelectedIndex = -1
    cboContaCaixa.SelectedIndex = -1
    cboPlanoContas.SelectedIndex = -1
    cboStatus.SelectedIndex = -1
    cboTipoDocumento.SelectedIndex = -1
    psqPessoa.ID_Pessoa = 0
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
    txtCodigoDocumento.Text = ""
    txtCodigoPagamento.Text = ""
    txtCodMovimentacao.Text = ""
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub FrmConsultaContasReceberPagar_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.F3 Then
      cmdPesquisar.PerformClick()
    End If
  End Sub

  Private Sub cmdTransferir_Click(sender As Object, e As EventArgs) Handles cmdTransferir.Click
    Dim oForm As New frmConsultaContasReceberPagar_Transferir
    Dim iCont As Integer

    If objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagem_Check) = 0 Then
      FNC_Mensagem("Selecione os itens a serem transferido")
      Exit Sub
    End If

    For iCont = 0 To grdListagem.Rows.Count - 1
      With grdListagem.Rows(iCont)
        If objGrid_CheckCol_Valor(grdListagem, const_GridListagem_Check, iCont) = "S" Then
          oForm.MOVFINANCEIRA_Adicionar(.Cells(const_GridListagem_SQ_MOVFINANCEIRAPARCELA).Value,
                                        .Cells(const_GridListagem_TipoDocumento).Value,
                                        .Cells(const_GridListagem_ValorParcela).Value)
        End If
      End With
    Next

    oForm.Carregar()

    FNC_AbriTela(oForm, , True, True)

    Pesquisar()
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser impresso")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) <> enOpcoes.StatusMovimentacaoFinanceira_Quitada.GetHashCode Then
      FNC_Mensagem("Essa movimentação precisa está quitada para ser emitido o recibo")
      Exit Sub
    End If

    If ComboBox_Selecionado(cboContaCaixa) Then
      FormRelatorioFinanceiro_Recibo_Pagamento(objGrid_Valor(grdListagem, const_GridListagem_SQ_MOVFINANCEIRAPARCELA), cboContaCaixa.SelectedValue, 0)
    Else
      FormRelatorioFinanceiro_Recibo_Pagamento(objGrid_Valor(grdListagem, const_GridListagem_SQ_MOVFINANCEIRAPARCELA), 0, 0)
    End If
  End Sub

  Private Sub cmdPrestacaoContas_Click(sender As Object, e As EventArgs) Handles cmdPrestacaoContas.Click
    If Not ComboBox_Selecionado(cboContaCaixa) Then
      FNC_Mensagem("É preciso selecionar a conta caixa")
      Exit Sub
    End If
    If Not IsDate(txtDataInicial.Text) Or Not IsDate(txtDataFinal.Text) Then
      FNC_Mensagem("Informe o período")
      Exit Sub
    End If
    If grdListagem.Rows.Count = 0 Then
      FNC_Mensagem("Náo foi carregados nenhum lançamento")
      Exit Sub
    End If

    FormRelatorioMovimentacaoFinanceiraPrestacaoContas(cboContaCaixa.SelectedValue, cboContaCaixa.Text, txtDataInicial.DateTime.Date, txtDataFinal.DateTime.Date)
  End Sub

  Private Sub cmdItensFaturados_Click(sender As Object, e As EventArgs) Handles cmdItensFaturados.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser impresso")
      Exit Sub
    End If
    If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridListagem_ID_MOVFINANCEIRAGERADA)) Then
      FNC_Mensagem("Essa movimentação não foi gerado por pelo faturamento médico")
      Exit Sub
    End If

    FormRelatorioMedicoFaturamento(objGrid_Valor(grdListagem, const_GridListagem_ID_MOVFINANCEIRAGERADA))
  End Sub

  Private Sub cboTipoMovimentacaoFinanceira_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimentacaoFinanceira.SelectedIndexChanged
    cmdItensFaturados.Visible = (FNC_NVL(cboTipoMovimentacaoFinanceira.SelectedValue, 0) = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar)
  End Sub

  Private Sub cmdCompensar_Click(sender As Object, e As EventArgs) Handles cmdCompensar.Click
    If objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagem_Check) <= 0 Then
      FNC_Mensagem("Selecione a(s) parcela(s) a ser(em) compensada(s)")

      Exit Sub
    End If

    Dim iCont As Integer
    Dim cSQ_MOVFINANCEIRAPARCELA = New Collection
    Dim cID_PESSOA = New Collection

    For iCont = 0 To grdListagem.Rows.Count - 1
      If objGrid_CheckCol_Valor(grdListagem, const_GridListagem_Check, iCont) = "S" Then
        If objGrid_Valor(grdListagem, const_GridListagem_IC_COMPENSADO, iCont) = "S" Then
          FNC_Mensagem("Foi selecionada parcela já compensada")

          Exit Sub
        End If

        cSQ_MOVFINANCEIRAPARCELA.Add(grdListagem.Rows(iCont).Cells(const_GridListagem_SQ_MOVFINANCEIRAPARCELA).Value)
      End If
    Next

    If cSQ_MOVFINANCEIRAPARCELA.Count > 0 Then
      Dim oForm As New frmLancaContasReceberPagar_Compensacao

      AddHandler oForm.Pesquisar, AddressOf Pesquisar

      oForm.cSQ_MOVFINANCEIRAPARCELA = cSQ_MOVFINANCEIRAPARCELA

      FNC_AbriTela(oForm)
    End If
  End Sub

  Private Sub cmdHistorico_Click(sender As Object, e As EventArgs) Handles cmdHistorico.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar a movimentação para a qual deseja ver o histórico")
      Exit Sub
    End If

    Dim oForm As New frmConsultaHistorico_Registro

    oForm.iProcessso = enOpcoes.Processo_Historico_Financeiro_LancamentoContasaReceber_Pagar.GetHashCode()
    oForm.iID_REGISTROS = New List(Of Integer)
    oForm.iID_REGISTROS.Add(objGrid_Valor(grdListagem, const_GridListagem_SQ_MOVFINANCEIRAPARCELA))
    oForm.iID_REGISTROS.Add(objGrid_Valor(grdListagem, const_GridListagem_ID_MOVFINANCEIRA))
    FNC_AbriTela(oForm, , True, True)
  End Sub
End Class