Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Cli28Julho.modDeclaracaoLocal

Public Class frmLancaContasReceberPagar
  Public Event RegerarConsulta()

  Public bRecebimentoXML As Boolean
  Public oCadastroAtendimentoFaturamento_Item() As cCadastroAtendimentoFaturamento_Item
  Public oDocumentoFiscal As modDeclaracaoLocal.cDocumentoFiscal
  Public iID_DOCUMENTOFISCAL As Integer
  Public iID_PEDIDO As Integer
  Public iID_ORDEMSERVICO As Integer
  Public iSQ_MOVFINANCEIRA As Integer
  Public iSQ_VOUCHER As Integer

  Public bVoucher As Boolean
  Public bAlteracaoSimples As Boolean
  Public bNovoLancamento As Boolean = False
  Public bLancamentoManual As Boolean = False
  Public dValorOriginal As Double
  Public iID_PESSOA As Integer

  Public iTipoMovimentacao As Integer
  Public cSQ_MOVFINANCEIRAPARCELA As New Collection
  Public eOperacao As Integer

  Const const_GridParcela_SQ_MOVFINANCEIRAPARCELA As Integer = 0
  Const const_GridParcela_ID_MOVFINANCEIRA As Integer = 1
  Const const_GridParcela_ID_DOCUMENTOFINANCEIRO As Integer = 2
  Const const_GridParcela_ID_OPT_STATUS As Integer = 3
  Const const_GridParcela_ID_EMITENTE As Integer = 4
  Const const_GridParcela_Provisionada As Integer = 5
  Const const_GridParcela_CodigoParcela As Integer = 6
  Const const_GridParcela_DataVencimento As Integer = 7
  Const const_GridParcela_ValorParcela As Integer = 8
  Const const_GridParcela_TipoDocumento As Integer = 9
  Const const_GridParcela_CodigoDocumento As Integer = 10
  Const const_GridParcela_Emitente As Integer = 11
  Const const_GridParcela_BTNEmitente As Integer = 12
  Const const_GridParcela_DataDocumento As Integer = 13
  Const const_GridParcela_Banco As Integer = 14
  Const const_GridParcela_NumeroAgencia As Integer = 15
  Const const_GridParcela_NumeroConta As Integer = 16
  Const const_GridParcela_NumeroConta_Digito As Integer = 17
  Const const_GridParcela_DescricaoDocumento As Integer = 18
  Const const_GridParcela_ValorPago As Integer = 19
  Const const_GridParcela_ValorDebito As Integer = 20
  Const const_GridParcela_ValorDesconto As Integer = 21
  Const const_GridParcela_ValorMulta As Integer = 22
  Const const_GridParcela_ValorJuros As Integer = 23
  Const const_GridParcela_ValorDescontoPagto As Integer = 24
  Const const_GridParcela_ValorAcrescimoPagto As Integer = 25
  Const const_GridParcela_ValorImpostoRetidoFonte As Integer = 26
  Const const_GridParcela_ValorTotalAPagar As Integer = 27
  Const const_GridParcela_JustificativaDescontoAcrescimo As Integer = 28
  Const const_GridParcela_DiasAtraso As Integer = 29
  Const const_GridParcela_ValorQuitando As Integer = 30
  Const const_GridParcela_ValorRestante As Integer = 31
  Const const_GridParcela_NO_OPT_STATUS As Integer = 32
  Const const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL As Integer = 33
  Const const_GridParcela_ID_PAGAMENTO As Integer = 34
  Const const_GridParcela_PC_DESCONTO As Integer = 35

  Const const_GridPlanoContas_PlanoContas As Integer = 0
  Const const_GridPlanoContas_Participacao As Integer = 1
  Const const_GridPlanoContas_Comentario As Integer = 2
  Const const_GridPlanoContas_ID_TIPO_DOCUMENTO As Integer = 3

  Dim oDBParcela As New UltraWinDataSource.UltraDataSource
  Dim oDBPlanoContas As New UltraWinDataSource.UltraDataSource
  Dim bAtualizandoParcela As Boolean
  Dim bCarregando As Boolean = False
  Dim bEmProcessamento As Boolean
  Dim bCalculandoMulta As Boolean
  Dim dPcProfissionalRetemImposto As Double

  Dim iID_OPT_STATUS As Integer = 0
  Dim iID_CONTABILIZACAO As Integer
  Dim iID_CONDICAOPAGAMENTO As Integer
  Dim bEncerrar As Boolean

  Private Sub frmLancaContasReceberPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim sSqlText As String
    Dim iCont As Integer

    ComboBox_Carregar(cboTipoMovimentacaoFinanceira, enSql.TipoMovimentacaoFinanceiraRecebePagar)
    ComboBox_Carregar(cboContaCaixa, enSql.ContaCaixa, New Object() {iID_USUARIO}, True)
    oCalculoFinanceiro_Juros.Inicializar()
    oCalculoFinanceiro_Desconto.Inicializar(True)

    objGrid_Inicializar(grdParcela, , oDBParcela, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdParcela, "SQ_MOVFINANCEIRAPARCELA", 0)
    objGrid_Coluna_Add(grdParcela, "ID_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdParcela, "ID_DOCUMENTOFINANCEIRO", 0)
    objGrid_Coluna_Add(grdParcela, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdParcela, "ID_EMITENTE", 0)
    objGrid_Coluna_Add(grdParcela, "Provis.", 30, , True, ColumnStyle.CheckBox, , , , , , , , , , , , , , , , (iSQ_MOVFINANCEIRA = 0))
    objGrid_Coluna_Add(grdParcela, "Cód. Parcela", 100)
    objGrid_Coluna_Add(grdParcela, "Vencimento", 120, , True, ColumnStyle.Date)
    objGrid_Coluna_Add(grdParcela, "Valor da Parcela", 150, , True, ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Tipo de Documento", 150, , True, , FNC_CarregarLista(enTipoCadastro.TipoDocumento, enOpcoes.TipoUtilizacaoLançamentoFinanceiro_UsarLancamento.GetHashCode()))
    objGrid_Coluna_Add(grdParcela, "Cód. Documento", 100, , True)
    objGrid_Coluna_Add(grdParcela, "Emitente", 300, , True)
    objGrid_Coluna_Add(grdParcela, "...", 30, , True, ColumnStyle.Button)
    objGrid_Coluna_Add(grdParcela, "Dt. Documento", 0, , True, ColumnStyle.Date)
    objGrid_Coluna_Add(grdParcela, "Banco", 0, , True, , FNC_CarregarLista(enTipoCadastro.Banco))
    objGrid_Coluna_Add(grdParcela, "Nº Agência", 0, , True, ColumnStyle.IntegerPositive)
    objGrid_Coluna_Add(grdParcela, "Nº Conta", 0, , True, ColumnStyle.IntegerPositive)
    objGrid_Coluna_Add(grdParcela, "Nº Díg. Conta", 0, , True, ColumnStyle.IntegerPositive)
    objGrid_Coluna_Add(grdParcela, "Descrição do Documento", 100, , True)
    objGrid_Coluna_Add(grdParcela, "Valor da Pago", 100, , False, ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Débito", 100, , False, ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Desconto", 100, , False, ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Multa", 100, , False, ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Juros", 100, , False, ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Desconto Pagto", 150, , True, ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Acréscimo Pagto", 150, , True, ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Retido Fonte", 150, , True, ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Total a Pagar", 150, , False, ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Justificativa Desc/Acrés", 200, , True)
    objGrid_Coluna_Add(grdParcela, "Dias Atraso", 150,, False)
    objGrid_Coluna_Add(grdParcela, "Valor Quitando", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Valor Restante", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdParcela, "Status", 100)
    objGrid_Coluna_Add(grdParcela, "ID_FORMAPAGAMENTO_PREFERENCIAL", 150)
    objGrid_Coluna_Add(grdParcela, "ID_PAGAMENTO", 0)
    objGrid_Coluna_Add(grdParcela, "PC_DESCONTO", 0)

    objGrid_Configuracao_Carregar(grdParcela, Me.Name)

    If bVoucher Then
      iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode()
    End If

    If iTipoMovimentacao > 0 Then
      ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, iTipoMovimentacao)
      Me.Text = cboTipoMovimentacaoFinanceira.Text & IIf(bVoucher, " - Voucher", "")
      cboTipoMovimentacaoFinanceira.Enabled = False
    End If

    Select Case iTipoMovimentacao
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar
        cmdNovo.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bIncluir
        cmdGravar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bGravar
        oLancaContasReceberPagar_QuitarForm.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasPagar).bAlterar
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber
        cmdNovo.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasReceber).bIncluir
        cmdGravar.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasReceber).bAlterar
        oLancaContasReceberPagar_QuitarForm.Enabled = FNC_Permissao(enPermissao.FINA_ConsultaContasReceber).bAlterar
    End Select

    txtDataPagamento.Value = Nothing

    Novo()

    If Not cSQ_MOVFINANCEIRAPARCELA Is Nothing Then
      If cSQ_MOVFINANCEIRAPARCELA.Count > 0 Then
        sSqlText = "SELECT SUM(ISNULL(VL_DEBITO, 0)) FROM VW_MOVFINANCEIRAPARCELA" &
                   " WHERE SQ_MOVFINANCEIRAPARCELA IN (" & FNC_Collection_Para_Lista(cSQ_MOVFINANCEIRAPARCELA) & ")"
        txtValorOriginal.Value = DBQuery_ValorUnico(sSqlText)
      End If
    End If

    If iSQ_MOVFINANCEIRA > 0 Then
      CarregarDados()
    Else
      If iID_ORDEMSERVICO > 0 Then
        ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode)

        sSqlText = "SELECT * FROM TB_ORDEMSERVICO WHERE SQ_ORDEMSERVICO = " & iID_ORDEMSERVICO

        With DBQuery(sSqlText).Rows(0)
          psqPessoa.ID_Pessoa = .Item("ID_PESSOA")
          txtDt1Parcela.Value = .Item("DH_ORDEMSERVICO").Date

          If Not bNovoLancamento Then
            txtQtdeParcela.Value = 1
            txtDescricaoLancamento.Text = "Pagamento Ordem de Serviço de nº " & .Item("CD_ORDEMSERVICO")
            txtValorOriginal.Value = .Item("VL_PRODUTO_SERVICO") + .Item("VL_ADICIONAL") + .Item("VL_DESCONTO")
            txtValorDesconto.Value = .Item("VL_DESCONTO") + FNC_Porcentagem(txtValorOriginal.Value, .Item("PC_DESCONTO"))
            txtValorMovimentacao.Value = txtValorOriginal.Value - txtValorDesconto.Value
            GridParcela_CarregarLinhas()
            Gravar()
          End If
        End With
      ElseIf iID_DOCUMENTOFISCAL > 0 And Not bRecebimentoXML Then
        sSqlText = "SELECT * FROM VW_DOCUMENTOFISCAL_TOTAL WHERE SQ_DOCUMENTOFISCAL = " & iID_DOCUMENTOFISCAL

        With DBQuery(sSqlText).Rows(0)
          If .Item("ID_DOCUMENTOFISCAL_TIPO") = enTipoDocumentoFiscal.Saida_CupomNaoFiscal.GetHashCode() Or
                      .Item("ID_DOCUMENTOFISCAL_TIPO") = enTipoDocumentoFiscal.Saida_NotaFiscalSaida.GetHashCode() Then
            ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode())
          ElseIf .Item("ID_DOCUMENTOFISCAL_TIPO") = enTipoDocumentoFiscal.Entrada_NotaFiscalEntrada.GetHashCode() Then
            ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode())
          End If

          psqPessoa.ID_Pessoa = .Item("ID_PESSOA")
          txtDt1Parcela.Value = .Item("DH_EMISSAO").Date

          If Not bNovoLancamento Then
            txtQtdeParcela.Value = 1
            txtDescricaoLancamento.Text = .Item("NO_NATUREZAOPERACAO")
            txtValorOriginal.Value = .Item("VL_PRODUTO_TOTAL") + .Item("VL_PRODUTO_DESCONTO")
            txtValorDesconto.Value = .Item("VL_PRODUTO_DESCONTO")
            txtValorMovimentacao.Value = txtValorOriginal.Value - txtValorDesconto.Value
            GridParcela_CarregarLinhas()
            Gravar()
          End If
        End With
      ElseIf iID_PEDIDO > 0 Then
        sSqlText = "SELECT * FROM VW_PEDIDO_TOTAL WHERE SQ_PEDIDO = " & iID_PEDIDO

        With DBQuery(sSqlText).Rows(0)
          If .Item("ID_OPT_TIPOPEDIDO") = enOpcoes.TipoPedido_VendaDireta.GetHashCode() Or
                       .Item("ID_OPT_TIPOPEDIDO") = enOpcoes.TipoPedido_VendaDireta.GetHashCode() Or
                       .Item("ID_OPT_TIPOPEDIDO") = enOpcoes.TipoPedido_OrcamentoVenda.GetHashCode() Then
            ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode())
          ElseIf .Item("ID_OPT_TIPOPEDIDO") = enOpcoes.TipoPedido_PedidoCompra.GetHashCode() Or
                           .Item("ID_OPT_TIPOPEDIDO") = enOpcoes.TipoPedido_OrcamentoCompra.GetHashCode() Then
            ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode())
          End If

          psqPessoa.ID_Pessoa = .Item("ID_PESSOA")
          txtDt1Parcela.Value = .Item("DH_PEDIDO").Date
          ComboBox_Selecionar(cboContaCaixa, FNC_NVL(.Item("ID_CONTAFINANCEIRA"), 0))

          iID_CONDICAOPAGAMENTO = FNC_NVL(.Item("ID_CONDICAOPAGAMENTO"), 0)
          iID_CONTABILIZACAO = FNC_NVL(.Item("ID_CONTABILIZACAO_PADRAO"), 0)

          txtQtdeParcela.Enabled = False
          txtDescricaoLancamento.Text = .Item("NO_NATUREZAOPERACAO")
          txtPercEntrada.Value = FNC_NVL(.Item("PC_ENTRADA"), 0)
          txtValorOriginal.Value = FNC_NVL(.Item("VL_TOTAL"), 0) + FNC_NVL(.Item("VL_DESCONTO"), 0) + FNC_NVL(.Item("VL_PRODUTO_DESCONTO"), 0)

          If FNC_NVL(.Item("ID_OPT_TIPOPEDIDO"), 0) = enOpcoes.TipoPedido_VendaDireta.GetHashCode() Then
            txtValorMovimentacao.Value = FNC_NVL(.Item("VL_PAGAMENTO"), 0)
          Else
            txtValorMovimentacao.Value = FNC_NVL(.Item("VL_TOTAL"), 0) - (FNC_NVL(.Item("VL_DESCONTO"), 0) + FNC_NVL(.Item("VL_PRODUTO_DESCONTO"), 0))
          End If

          GridParcela_CarregarLinhas()
          CondicaoPagamento_Tratar()
          Contabilizacao_Tratar()

          If Gravar() Then bEncerrar = True
        End With
      End If
    End If

    If bAlteracaoSimples Then
      cboTipoMovimentacaoFinanceira.Enabled = False
      cboContaCaixa.Enabled = False
      psqPessoa.Enabled = False
      txtDt1Parcela.Enabled = False
      txtQtdeParcela.Enabled = False
      txtNrDiaIntervalo.Enabled = False
      optTipoInvervalo_Ano.Enabled = False
      optTipoInvervalo_Livre.Enabled = False
      optTipoInvervalo_Mensal.Enabled = False
      optTipoInvervalo_Quizena.Enabled = False
      optTipoInvervalo_Semana.Enabled = False
      optTipoInvervalo_Semestre.Enabled = False
      optTipoInvervalo_Trimestre.Enabled = False
      txtValorMovimentacao.Enabled = False
      chkValorParcela.Enabled = False
    End If

    If bRecebimentoXML Then
      With oDocumentoFiscal
        ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode)
        cboTipoMovimentacaoFinanceira.Enabled = False
        psqPessoa.ID_Pessoa = .Emit_SQ_PESSOA
        psqPessoa.Enabled = False
        txtDescricaoLancamento.Text = "Recebimento de Nota Fiscal de Compra nº " & .oNFe.infNFe.ide.nNF.ToString()
        txtValorOriginal.Value = .oNFe.infNFe.cobr.fat.vOrig
        txtValorOriginal.Enabled = False
        txtValorDesconto.Value = FNC_NVL(.oNFe.infNFe.cobr.fat.vDesc, 0)
        txtValorDesconto.Enabled = False
        txtValorMovimentacao.Value = .oNFe.infNFe.cobr.fat.vLiq
        txtValorMovimentacao.Enabled = False
        'Parcelas

        txtDt1Parcela.Value = Nothing

        If .oNFe.infNFe.cobr.dup Is Nothing Then
          txtDt1Parcela.Value = 1
          txtDt1Parcela.Value = Now.Date
        Else
          If .oNFe.infNFe.cobr.dup.Count = 0 Then
            txtQtdeParcela.Value = 1
          Else
            txtQtdeParcela.Value = .oNFe.infNFe.cobr.dup.Count
          End If

          For Each oDup As NFe.Classes.Informacoes.Cobranca.dup In .oNFe.infNFe.cobr.dup
            If txtDt1Parcela.Value Is Nothing Then
              txtDt1Parcela.Value = oDup.dVenc
            Else
              If txtDt1Parcela.Value < oDup.dVenc Then
                txtDt1Parcela.Value = oDup.dVenc
              End If
            End If

            grdParcela.Rows(iCont).Cells(const_GridParcela_CodigoDocumento).Value = .oNFe.infNFe.cobr.fat.nFat & "/" & oDup.nDup
            grdParcela.Rows(iCont).Cells(const_GridParcela_DataDocumento).Value = .oNFe.infNFe.ide.dhEmi.Date
            grdParcela.Rows(iCont).Cells(const_GridParcela_DataVencimento).Value = oDup.dVenc
            grdParcela.Rows(iCont).Cells(const_GridParcela_ValorParcela).Value = oDup.vDup
          Next
        End If

        GridParcela_CarregarLinhas()
      End With

      cmdNovo.Visible = False

      Gravar()
    End If

    If Not oCadastroAtendimentoFaturamento_Item Is Nothing Then
      psqPessoa.ID_Pessoa = iID_PESSOA
      txtValorOriginal.Value = dValorOriginal
      txtValorMovimentacao.Value = dValorOriginal
      txtValorMovimentacao.Enabled = False
      txtValorOriginal.Enabled = False
      psqPessoa.Enabled = False
      txtDescricaoLancamento.Text = "REPASSE " + psqPessoa.cboPessoa.Text
      ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode())
      cboTipoMovimentacaoFinanceira.Enabled = False

      sSqlText = ""

      For Each oItem As cCadastroAtendimentoFaturamento_Item In oCadastroAtendimentoFaturamento_Item
        FNC_Str_Adicionar(sSqlText, oItem.SQ_CLINICA_VENDA_PROCEDIMENTO.ToString(), ",")
      Next

      sSqlText = "SELECT ID_PLANOCONTAS," &
                        "ROUND(SUM(PC_PARTICIPACAO), 2) * 100" &
                 " FROM (SELECT MFPLC.ID_PLANOCONTAS," &
                               "(MFPLC.PC_PARTICIPACAO / sum(MFPLC.PC_PARTICIPACAO) over ()) PC_PARTICIPACAO" &
                        " FROM TB_CLINICA_VENDA_PROCEDIMENTO CVPRC" &
                         " INNER JOIN TB_MOVFINANCEIRA_PLANOCONTAS	MFPLC ON MFPLC.ID_MOVFINANCEIRA = CVPRC.ID_MOVFINANCEIRA" &
                         " WHERE CVPRC.SQ_CLINICA_VENDA_PROCEDIMENTO IN (" & sSqlText & ")) X" &
                 " GROUP BY ID_PLANOCONTAS"
      objGrid_Carregar(grdPlanoContas, sSqlText, New Integer() {const_GridPlanoContas_PlanoContas,
                                                                const_GridPlanoContas_Participacao})

      GridPlanoContas_CalcularParticipacao()

      grdParcela.Rows(0).Cells(const_GridParcela_TipoDocumento).Value = iEMPRESA_ID_TIPO_DOCUMENTO_PADRAO_VENDA
      'If dPcProfissionalRetemImposto > 0 And FNC_NVL(grdParcela.Rows(0).Cells(const_GridParcela_ValorImpostoRetidoFonte).Value, 0) = 0 Then
      '  grdParcela.Rows(0).Cells(const_GridParcela_ValorImpostoRetidoFonte).Value = FNC_Porcentagem(grdParcela.Rows(0).Cells(const_GridParcela_ValorParcela).Value, dPcProfissionalRetemImposto)
      '  grdParcela.Rows(0).Cells(const_GridParcela_ValorTotalAPagar).Value = FNC_NVL(grdParcela.Rows(0).Cells(const_GridParcela_ValorParcela).Value, 0) -
      '                                                                       FNC_NVL(grdParcela.Rows(0).Cells(const_GridParcela_ValorImpostoRetidoFonte).Value, 0)
      '  grdParcela.Rows(0).Cells(const_GridParcela_JustificativaDescontoAcrescimo).Value = "Imposto Retido"
      'End If
    End If

    oLancaContasReceberPagar_QuitarForm.grdContas = grdParcela
    oLancaContasReceberPagar_QuitarForm.GrdContas_SQ_MOVFINANCEIRAPARCELA = const_GridParcela_SQ_MOVFINANCEIRAPARCELA
    oLancaContasReceberPagar_QuitarForm.GrdContas_SQ_PAGAMENTO = const_GridParcela_ID_PAGAMENTO
    oLancaContasReceberPagar_QuitarForm.GrdContas_PC_DESCONTO = const_GridParcela_PC_DESCONTO
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorQuitando = const_GridParcela_ValorQuitando
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorDesconto = const_GridParcela_ValorDesconto
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorParcela = const_GridParcela_ValorParcela
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorJuros = const_GridParcela_ValorJuros
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorMulta = const_GridParcela_ValorMulta
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorDescontoPagto = const_GridParcela_ValorDescontoPagto
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorAcrescimoPagto = const_GridParcela_ValorAcrescimoPagto
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorRestante = const_GridParcela_ValorRestante
    oLancaContasReceberPagar_QuitarForm.GrdContas_ValorImpostoRetido = const_GridParcela_ValorImpostoRetidoFonte
    oLancaContasReceberPagar_QuitarForm.GrdContas_JustificativaDescontoAcrescimo = const_GridParcela_JustificativaDescontoAcrescimo
    oLancaContasReceberPagar_QuitarForm.GrdContas_ID_MOVFINANCEIRA = const_GridParcela_ID_MOVFINANCEIRA
    oLancaContasReceberPagar_QuitarForm.GrdContas_ID_FORMAPAGAMENTO_PREFERENCIAL = const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL
    oLancaContasReceberPagar_QuitarForm.bPagamentoPorParcela = (iID_PEDIDO > 0)
    oLancaContasReceberPagar_QuitarForm.bGravacaoAutomatica = (iID_PEDIDO > 0)
    oLancaContasReceberPagar_QuitarForm.iTipoMovimentacao = Convert.ToInt32(cboTipoMovimentacaoFinanceira.SelectedValue)
    oLancaContasReceberPagar_QuitarForm.sTipoMovimentacao = cboTipoMovimentacaoFinanceira.Text
    oLancaContasReceberPagar_QuitarForm.Formatar()
  End Sub

  Private Sub GridContas_AtualizarValores(iLinha)
    With grdParcela.Rows(iLinha)
      .Cells(const_GridParcela_ValorTotalAPagar).Value = (CDbl(FNC_NVL(.Cells(const_GridParcela_ValorDebito).Value, 0)) +
                                                                CDbl(FNC_NVL(.Cells(const_GridParcela_ValorMulta).Value, 0)) +
                                                                CDbl(FNC_NVL(.Cells(const_GridParcela_ValorJuros).Value, 0)) +
                                                                CDbl(FNC_NVL(.Cells(const_GridParcela_ValorAcrescimoPagto).Value, 0)) -
                                                                CDbl(FNC_NVL(.Cells(const_GridParcela_ValorDesconto).Value, 0)) -
                                                                CDbl(FNC_NVL(.Cells(const_GridParcela_ValorDescontoPagto).Value, 0)) -
                                                                CDbl(FNC_NVL(.Cells(const_GridParcela_ValorImpostoRetidoFonte).Value, 0)))
      .Cells(const_GridParcela_ValorRestante).Value = FNC_NVL(.Cells(const_GridParcela_ValorTotalAPagar).Value, 0) - FNC_NVL(.Cells(const_GridParcela_ValorQuitando).Value, 0)
    End With
  End Sub

  Private Sub FormatarPlanoContas()
    oDBPlanoContas.Rows.Clear()

    objGrid_Inicializar(grdPlanoContas, IIf(cboTipoMovimentacaoFinanceira.SelectedValue = Nothing, AllowAddNew.Default,
                                                                                                   AllowAddNew.FixedAddRowOnTop),
                        oDBPlanoContas, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    Select Case cboTipoMovimentacaoFinanceira.SelectedValue
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar
        objGrid_Coluna_Add(grdPlanoContas, "Plano de Contas", 230, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContas_Debito))
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber
        objGrid_Coluna_Add(grdPlanoContas, "Plano de Contas", 230, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContas_Credito))
      Case Else
        objGrid_Coluna_Add(grdPlanoContas, "Plano de Contas", 230)
    End Select
    objGrid_Coluna_Add(grdPlanoContas, "Participação (%)", 120, , True, ColumnStyle.DoublePositive)
    objGrid_Coluna_Add(grdPlanoContas, "Comentário", 300, , True)
    objGrid_Coluna_Add(grdPlanoContas, "ID_TIPO_DOCUMENTO", 0)
    objGrid_Configuracao_Carregar(grdPlanoContas, Me.Name)

    oLancaContasReceberPagar_QuitarForm.TipoMovimentacao = FNC_NVL(cboTipoMovimentacaoFinanceira.SelectedValue, 0)
  End Sub

  Private Sub cboTipoMovimentacaoFinanceira_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimentacaoFinanceira.SelectedIndexChanged
    FormatarPlanoContas()
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub txtQtdeParcela_LostFocus(sender As Object, e As EventArgs) Handles txtQtdeParcela.LostFocus
    GridParcela_CarregarLinhas()
  End Sub

  Private Sub GridParcela_CarregarLinhas()
    If FNC_NVL(txtQtdeParcela.Value, 0) <> grdParcela.Rows.Count Then
      Dim iCont As Integer

      oDBParcela.Rows.Clear()

      For iCont = 0 To FNC_NVL(txtQtdeParcela.Value, 0) - 1
        With objGrid_Linha_Add(grdParcela, New Object() {const_GridParcela_CodigoParcela, FNC_StrZero(iCont + 1, 3) & "/" & FNC_StrZero(txtQtdeParcela.Value, 3)})
          If (iSQ_MOVFINANCEIRA = 0 And bEMPRESA_IC_PROVISIONADO_POR_PADRAO And iID_PEDIDO = 0 And iID_DOCUMENTOFISCAL = 0) Then
            .SetCellValue(const_GridParcela_Provisionada, 1)
          Else
            .SetCellValue(const_GridParcela_Provisionada, 0)
          End If
        End With
      Next

      GridParcela_CalcularDias()
      GridParcela_CalcularValor()
    End If
  End Sub

  Private Sub txtValorMovimentacao_ValueChanged(sender As Object, e As EventArgs) Handles txtValorMovimentacao.ValueChanged
    GridParcela_CalcularValor()
    Desconto_Calculo()
  End Sub

  Private Sub GridParcela_TotalValor()
    lblValorTotalParcela.Text = "Valor Total das Parcelas: R$ " & FormatCurrency(objGrid_CalcularTotalColuna(grdParcela, const_GridParcela_ValorParcela), 2)
    lblValorTotalParcela.Tag = objGrid_CalcularTotalColuna(grdParcela, const_GridParcela_ValorParcela)

    lblValorTotalPendente.Text = "Valor Total Pendente: R$ " & FormatCurrency(objGrid_CalcularTotalColuna(grdParcela, const_GridParcela_ValorTotalAPagar), 2)
    lblValorTotalPendente.Tag = objGrid_CalcularTotalColuna(grdParcela, const_GridParcela_ValorTotalAPagar)
  End Sub

  Private Sub GridParcela_CalcularValor(Optional bRecalcularValorParcela As Boolean = True)
    If FNC_NVL(txtValorMovimentacao.Value, 0) * FNC_NVL(txtMulta.Value, 0) = 0 Then
      txtValorMulta.Value = 0
    Else
      txtValorMulta.Value = (FNC_NVL(txtValorMovimentacao.Value, 0) * FNC_NVL(txtMulta.Value, 0) / 100)
    End If

    Dim iCont As Integer
    Dim dValorRestante As Double
    Dim dValorEntrada As Double
    Dim dValorParcela As Double

    If bRecalcularValorParcela Then
      dValorRestante = txtValorMovimentacao.Value
      dValorEntrada = Math.Round(FNC_Porcentagem(txtValorMovimentacao.Value, txtPercEntrada.Value), 2)

      For iCont = 0 To grdParcela.Rows.Count - 1
        With grdParcela.Rows(iCont).Cells(const_GridParcela_ValorParcela)
          If chkValorParcela.Checked Then
            .Value = txtValorMovimentacao.Value
          Else
            If dValorRestante = 0 Then
              .Value = 0
            Else
              If iCont = 0 And dValorEntrada > 0 Then
                dValorRestante = dValorRestante - dValorEntrada
                .Value = dValorEntrada
              Else
                If (txtQtdeParcela.Value - IIf(dValorEntrada > 0, 1, 0)) > 0 Then
                  dValorParcela = Math.Round((txtValorMovimentacao.Value - dValorEntrada) / (txtQtdeParcela.Value - IIf(dValorEntrada > 0, 1, 0)), 2)
                Else
                  dValorParcela = 0
                End If

                If dValorRestante > dValorParcela Then
                  .Value = dValorParcela
                  dValorRestante = dValorRestante - dValorParcela
                Else
                  .Value = dValorRestante
                End If
              End If
            End If
          End If
        End With
      Next
    End If

    TratarDataPagamento()
    GridParcela_TotalValor()
  End Sub

  Private Sub txtValorMulta_ValueChanged(sender As Object, e As EventArgs) Handles txtValorMulta.ValueChanged
    If Not bCarregando And Not bCalculandoMulta Then
      bCalculandoMulta = True
      If txtValorMulta.Value = 0 And txtValorMovimentacao.Value = 0 Then
        txtMulta.Value = 0
      Else
        txtMulta.Value = (txtValorMulta.Value / objGrid_Valor(grdParcela, const_GridParcela_ValorParcela, 1, 0) * 100)
      End If

      bCalculandoMulta = False
    End If

    GridParcela_CalcularValor()
  End Sub

  Private Sub txtMulta_ValueChanged(sender As Object, e As EventArgs) Handles txtMulta.ValueChanged
    If Not bCarregando And Not bCalculandoMulta Then
      bCalculandoMulta = True

      If txtMulta.Value = 0 Or txtValorMovimentacao.Value = 0 Then
        txtValorMulta.Value = 0
      Else
        txtValorMulta.Value = (Val(objGrid_Valor(grdParcela, const_GridParcela_ValorParcela, 1, 0)) * txtMulta.Value / 100)
      End If

      bCalculandoMulta = False
    End If
  End Sub

  Private Sub txtNrDiaIntervalo_ValueChanged(sender As Object, e As EventArgs)
    GridParcela_CalcularDias()
  End Sub

  Private Sub GridParcela_CalcularDias()
    Dim iCont As Integer
    Dim iFator As Integer

    iFator = IIf(optTipoInvervalo_Livre.Checked Or optTipoInvervalo_Mensal.Checked,
                     1,
                     IIf(optTipoInvervalo_Semana.Checked,
                         7,
                         IIf(optTipoInvervalo_Quizena.Checked,
                             15,
                             IIf(optTipoInvervalo_Trimestre.Checked,
                                 3,
                                 IIf(optTipoInvervalo_Semestre.Checked,
                                     6,
                                     IIf(optTipoInvervalo_Ano.Checked,
                                         12,
                                         1))))))

    For iCont = 0 To grdParcela.Rows.Count - 1
      With grdParcela.Rows(iCont)
        If iCont = 0 And (txtPercEntrada.Value > 0) Then
          .Cells(const_GridParcela_DataVencimento).Value = Now.Date
        Else
          If IsDate(txtDt1Parcela.Value) Then
            If optTipoInvervalo_Mensal.Checked Or
                           optTipoInvervalo_Trimestre.Checked Or
                           optTipoInvervalo_Semestre.Checked Or
                           optTipoInvervalo_Ano.Checked Then
              .Cells(const_GridParcela_DataVencimento).Value = txtDt1Parcela.DateTime.Date.AddMonths(iCont * iFator)
            Else
              .Cells(const_GridParcela_DataVencimento).Value = txtDt1Parcela.DateTime.Date.AddDays(FNC_NVL(txtNrDiaIntervalo.Value, 0) * iCont)
            End If
          Else
            .Cells(const_GridParcela_DataVencimento).Value = Nothing
          End If
        End If
      End With
    Next
  End Sub

  Private Sub txtDt1Parcela_LostFocus(sender As Object, e As EventArgs) Handles txtDt1Parcela.LostFocus
    GridParcela_CalcularDias()
  End Sub

  Private Sub optTipoInvervalo_CheckedChanged(sender As Object, e As EventArgs) Handles optTipoInvervalo_Livre.CheckedChanged,
                                                                                          optTipoInvervalo_Semana.CheckedChanged,
                                                                                          optTipoInvervalo_Quizena.CheckedChanged,
                                                                                          optTipoInvervalo_Mensal.CheckedChanged,
                                                                                          optTipoInvervalo_Trimestre.CheckedChanged,
                                                                                          optTipoInvervalo_Semestre.CheckedChanged,
                                                                                          optTipoInvervalo_Ano.CheckedChanged
    If bEmProcessamento Then Exit Sub

    bEmProcessamento = True

    txtNrDiaIntervalo.Value = sender.Tag
    txtNrDiaIntervalo.Enabled = optTipoInvervalo_Livre.Checked
    GridParcela_CalcularDias()

    bEmProcessamento = False
  End Sub

  Private Sub grdPlanoContas_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdPlanoContas.AfterCellUpdate
    GridPlanoContas_CalcularParticipacao()
  End Sub

  Private Sub GridPlanoContas_CalcularParticipacao()
    lblTotalParticipacao.Text = "Total de Participação: " & objGrid_CalcularTotalColuna(grdPlanoContas, const_GridPlanoContas_Participacao) & "%"
    lblTotalParticipacao.Tag = objGrid_CalcularTotalColuna(grdPlanoContas, const_GridPlanoContas_Participacao)
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Gravar() Then
      FNC_Mensagem("Lançamento Efetuado")

      RaiseEvent RegerarConsulta()

      CarregarDados()

      cmdImprimir.Enabled = True

      If bRecebimentoXML Then
        Close()
      End If
    End If
  End Sub

  Private Function Gravar() As Boolean
    Dim iCont As Integer

    If Not ComboBox_Selecionado(cboTipoMovimentacaoFinanceira) Then
      FNC_Mensagem("É preciso selecionar tipo de movimentação")
      GoTo Erro
    End If
    If Not ComboBox_Selecionado(cboContaCaixa) Then
      FNC_Mensagem("É preciso selecionar a conta de caixa")
      GoTo Erro
    End If
    If Not psqPessoa.Selecionado Then
      FNC_Mensagem("É preciso selecionar a pessoa")
      GoTo Erro
    End If
    If Not IsDate(txtDt1Parcela.Value) Then
      FNC_Mensagem("É preciso informar a data da 1ª parcela")
      GoTo Erro
    End If
    If txtQtdeParcela.Value < 1 Then
      FNC_Mensagem("A quantidade mínima de parcela é 1")
      GoTo Erro
    End If
    If Trim(txtDescricaoLancamento.Text) = "" Then
      FNC_Mensagem("Informe a descriação do lançamento")
      GoTo Erro
    End If
    If txtValorMovimentacao.Value <= 0 Then
      FNC_Mensagem("É preciso informar um valor maior que 0")
      GoTo Erro
    End If
    If objGrid_CalcularTotalColuna(grdPlanoContas, const_GridPlanoContas_Participacao) <> 100 Then
      FNC_Mensagem("É preciso fazer o rateio em plano de contas de 100% do lançamento")
      GoTo Erro
    End If
    'Validação do plano de contas
    For iCont = 0 To grdPlanoContas.Rows.Count - 1
      With grdPlanoContas.Rows(iCont)
        If FNC_CampoNulo(.Cells(const_GridPlanoContas_PlanoContas).Value) Then
          FNC_Mensagem("Selecione o plano de contas da linha " & iCont + 1)
          GoTo Erro
        End If
        If FNC_CampoNulo(.Cells(const_GridPlanoContas_Participacao).Value) Then
          FNC_Mensagem("Informe a participação do plano de contas")
          GoTo Erro
        End If
      End With
    Next
    For iCont = 0 To grdParcela.Rows.Count - 1
      With grdParcela.Rows(iCont)
        If Not IsDate(.Cells(const_GridParcela_DataVencimento).Value) Then
          FNC_Mensagem("Informe a data do vencimento da parcela " & .Cells(const_GridParcela_CodigoParcela).Value)
          GoTo Erro
        End If
        If FNC_CampoNulo(.Cells(const_GridParcela_TipoDocumento).Value) Then
          FNC_Mensagem("Informe o tipo de documento da parcela " & .Cells(const_GridParcela_CodigoParcela).Value)
          GoTo Erro
        End If
        If FNC_CampoNulo(.Cells(const_GridParcela_ValorParcela).Value) Then
          FNC_Mensagem("Informe o valor da parcela " & .Cells(const_GridParcela_CodigoParcela).Value)
          GoTo Erro
        End If
        If FNC_NVL(.Cells(const_GridParcela_ValorParcela).Value, 0) <= 0 Then
          FNC_Mensagem("Informe um valor positivo para a parcela " & objGrid_Valor(grdParcela, const_GridParcela_CodigoParcela))
          GoTo Erro
        End If
        If Not FNC_CampoNulo(.Cells(const_GridParcela_NumeroAgencia).Value) Then
          If FNC_CampoNulo(.Cells(const_GridParcela_Banco).Value) Then
            FNC_Mensagem("Selecione o banco da conta bancária")
            GoTo Erro
          End If
          If FNC_CampoNulo(.Cells(const_GridParcela_NumeroConta).Value) Then
            FNC_Mensagem("Informe o número da conta bancária")
            GoTo Erro
          End If
          If Trim(.Cells(const_GridParcela_NumeroConta_Digito).Value) = "" Then
            FNC_Mensagem("Informe o dígito da conta bancária")
            GoTo Erro
          End If
        End If
      End With
    Next

    oLancaContasReceberPagar_QuitarForm.dDataPagamento = txtDataPagamento.DateTime.Date

    If Not oLancaContasReceberPagar_QuitarForm.Validar_DataPagamento Then GoTo Erro

    If txtValorOriginal.Value = 0 Then
      txtValorOriginal.Value = txtValorMovimentacao.Value
    End If

    Dim sSqlText As String
    Dim bCredito As Boolean = (cboTipoMovimentacaoFinanceira.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode)
    Dim iSQ_DOCUMENTOFINANCEIRO As Integer
    Dim _ID_OPT_STATUS As enOpcoes

    If Not oCadastroAtendimentoFaturamento_Item Is Nothing Then
      _ID_OPT_STATUS = enOpcoes.StatusMovimentacaoFinanceira_Lancado
    Else
      _ID_OPT_STATUS = enOpcoes.StatusMovimentacaoFinanceira_Aberta
    End If

    If FormCadastroMovimentacaoFinanceira(iSQ_MOVFINANCEIRA:=iSQ_MOVFINANCEIRA,
                                          eID_OPT_TIPOMOVFINANCEIRA:=cboTipoMovimentacaoFinanceira.SelectedValue,
                                          eID_OPT_STATUS:=IIf(iSQ_MOVFINANCEIRA = 0, _ID_OPT_STATUS, Nothing),
                                          eID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO:=oCalculoFinanceiro_Desconto.PeriodoCalculoFinanceiro,
                                          eID_OPT_PERIODOCALCULOFINANCEIRO_JUROS:=oCalculoFinanceiro_Juros.PeriodoCalculoFinanceiro,
                                          iID_PESSOA:=psqPessoa.ID_Pessoa,
                                          iID_CONTAFINANCERIA_CREDITO:=IIf(bCredito, cboContaCaixa.SelectedValue, 0),
                                          iID_CONTAFINANCERIA_DEBITO:=IIf(bCredito, 0, cboContaCaixa.SelectedValue),
                                          iID_DOCUMENTOFISCAL:=IIf(iSQ_MOVFINANCEIRA = 0, FNC_NuloSe(iID_DOCUMENTOFISCAL, 0), 0),
                                          iID_PEDIDO:=IIf(iSQ_MOVFINANCEIRA = 0, FNC_NuloSe(iID_PEDIDO, 0), 0),
                                          iID_ORDEMSERVICO:=IIf(iSQ_MOVFINANCEIRA = 0, FNC_NuloSe(iID_ORDEMSERVICO, 0), 0),
                                          iID_SEGMENTO:=Nothing,
                                          iID_CONDICAOPAGAMENTO:=FNC_NVL(iID_CONDICAOPAGAMENTO, 0),
                                          iID_CLINICA_VENDA:=0,
                                          iID_CONVENIO:=FNC_NVL(cboConvenio.SelectedValue, 0),
                                          sDS_MOVFINANCEIRA:=Trim(txtDescricaoLancamento.Text),
                                          dVL_MOVFINANCEIRA:=lblValorTotalParcela.Tag,
                                          dVL_ORIGINAL:=txtValorOriginal.Value,
                                          dVL_DESCONTO:=txtValorDesconto.Value,
                                          dDT_MOVIMENTACAO:=IIf(iSQ_MOVFINANCEIRA = 0, Now.Date, Nothing),
                                          dDT_1_VENCIMENTO:=txtDt1Parcela.DateTime.Date,
                                          dPC_ENTRADA:=txtPercEntrada.Value,
                                          dPC_JUROS:=oCalculoFinanceiro_Juros.Valor,
                                          dPC_DESCONTO:=oCalculoFinanceiro_Desconto.Valor,
                                          dVL_MULTA:=txtValorMulta.Value,
                                          dPC_MULTA:=txtMulta.Value,
                                          sCM_MOVFINANCEIRA:=txtComentario.Text) Then
      'Gravação das parcelas
      Dim iID_DOCUMENTOFINANCEIRO As Integer = 0
      Dim cSQ_MOVFINANCEIRAPARCELA_QUITAR As New Collection
      Dim bQuitarAutomatico As Boolean

      For iCont = 0 To grdParcela.Rows.Count - 1
        With grdParcela.Rows(iCont)
          'If FNC_NVL(.Cells(const_GridParcela_ID_OPT_STATUS).Value, enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode) =
          '  enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode Then
          If FNC_NVL(.Cells(const_GridParcela_ID_OPT_STATUS).Value, enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode) <>
                       enOpcoes.StatusMovimentacaoFinanceira_Cancelada.GetHashCode And
                       CDbl(FNC_NVL(.Cells(const_GridParcela_ValorPago).Value, 0)) = 0 Then
            If FormCadastroMovimentacaoFinanceiraParcela(iSQ_MOVFINANCEIRAPARCELA:=FNC_NVL(.Cells(const_GridParcela_SQ_MOVFINANCEIRAPARCELA).Value, 0),
                                                          iID_MOVFINANCEIRA:=iSQ_MOVFINANCEIRA,
                                                          eID_OPT_STATUS:=IIf(objGrid_CheckCol_Valor(grdParcela, const_GridParcela_Provisionada, iCont) = "S",
                                                                              enOpcoes.StatusMovimentacaoFinanceira_Estimado,
                                                                              enOpcoes.StatusMovimentacaoFinanceira_Aberta),
                                                          iID_TIPO_DOCUMENTO:=Val(.Cells(const_GridParcela_TipoDocumento).Value),
                                                          iID_MOVFINANCEIRAPARCELAORIGEM:=0,
                                                          iID_DOCUMENTOFINANCEIRO:=iSQ_DOCUMENTOFINANCEIRO,
                                                          iID_FORMAPAGAMENTO_PREFERENCIAL:=FNC_NVL(.Cells(const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL).Value, 0),
                                                          iID_CONDICAOPAGAMENTO:=0,
                                                          sCD_PARCELA:= .Cells(const_GridParcela_CodigoParcela).Value,
                                                          sCD_DOCUMENTO:=FNC_NuloString(FNC_NVL(.Cells(const_GridParcela_CodigoDocumento).Value, ""), False),
                                                          sCM_DOCUMENTO:= .Cells(const_GridParcela_DescricaoDocumento).Value,
                                                          sDS_EMITENTE:=IIf(FNC_CampoNulo(.Cells(const_GridParcela_ID_EMITENTE).Value), "", .Cells(const_GridParcela_Emitente).Text),
                                                          dDT_VENCIMENTO:= .Cells(const_GridParcela_DataVencimento).Value,
                                                          dDT_QUITACAO:=Nothing,
                                                          dVL_PARCELA:=CDbl(.Cells(const_GridParcela_ValorParcela).Value),
                                                          dVL_JUROS:=0,
                                                          dVL_DESCONTO:=CDbl(FNC_NVL(.Cells(const_GridParcela_ValorDesconto).Value, 0)),
                                                          dVL_QUITADO:=0,
                                                          dVL_PROVISAO:=IIf(objGrid_CheckCol_Valor(grdParcela, const_GridParcela_Provisionada, iCont) = "S",
                                                                            FNC_ConvValorFormatoAmericano(.Cells(const_GridParcela_ValorParcela).Value),
                                                                            0),
                                                          dPC_TAXA_COMPENSACAO:=0,
                                                          dVL_IMPOSTORETIDO:=CDbl(FNC_NVL(.Cells(const_GridParcela_ValorImpostoRetidoFonte).Value, 0))) Then
              If Trim(txtCodMovimentacao.Text) = "" Then
                sSqlText = "SELECT CD_MOVFINANCEIRA FROM TB_MOVFINANCEIRA WHERE SQ_MOVFINANCEIRA = " & iSQ_MOVFINANCEIRA
                txtCodMovimentacao.Text = DBQuery_ValorUnico(sSqlText)
              End If

              If FNC_CampoNulo(.Cells(const_GridParcela_ID_OPT_STATUS).Value) And Not bLancamentoManual Then
                bQuitarAutomatico = True
              Else
                If IIf(objGrid_CheckCol_Valor(grdParcela, const_GridParcela_Provisionada, iCont) = "S", enOpcoes.StatusMovimentacaoFinanceira_Estimado,
                                                                                                        enOpcoes.StatusMovimentacaoFinanceira_Aberta) = enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode And
                   FNC_NVL(.Cells(const_GridParcela_ID_OPT_STATUS).Value, enOpcoes.StatusMovimentacaoFinanceira_Estimado) <> enOpcoes.StatusMovimentacaoFinanceira_Aberta Then
                  bQuitarAutomatico = True
                End If
              End If

              If DBTeveRetorno() Then
                .Cells(const_GridParcela_SQ_MOVFINANCEIRAPARCELA).Value = DBRetorno(1)
                If bQuitarAutomatico Then
                  cSQ_MOVFINANCEIRAPARCELA_QUITAR.Add(DBRetorno(1))
                End If
              End If
            End If
          End If
        End With
      Next

      'Associa parcela de renegociacao
      If eOperacao = enContasReceberPagar_TipoBaixa.Renegociacao Then
        For iCont = 1 To cSQ_MOVFINANCEIRAPARCELA.Count
          sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_RENEGOCIACAO_UPD", False, "@SQ_MOVFINANCEIRAPARCELA",
                                                                                    "@ID_MOVFINANCEIRAGERADA")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA", cSQ_MOVFINANCEIRAPARCELA(iCont)),
                               DBParametro_Montar("ID_MOVFINANCEIRAGERADA", iSQ_MOVFINANCEIRA))
        Next
      End If

      'Gravação de plano de contas
      sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_PLANOCONTAS_DEL", False, "@ID_MOVFINANCEIRA",
                                                                        "@ID_PLANOCONTAS")
      DBExecutar(sSqlText, DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                           DBParametro_Montar("ID_PLANOCONTAS", 0))

      sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_PLANOCONTAS_CAD", False, "@ID_MOVFINANCEIRA",
                                                                        "@ID_PLANOCONTAS",
                                                                        "@ID_OPT_CREDITODEBITO",
                                                                        "@PC_PARTICIPACAO",
                                                                        "@CM_PARTICIPACAO")

      For iCont = 0 To grdPlanoContas.Rows.Count - 1
        With grdPlanoContas.Rows(iCont)
          DBExecutar(sSqlText, DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                               DBParametro_Montar("ID_PLANOCONTAS", .Cells(const_GridPlanoContas_PlanoContas).Value),
                               DBParametro_Montar("ID_OPT_CREDITODEBITO", enOpcoes.CreditoDebito_Credito.GetHashCode),
                               DBParametro_Montar("PC_PARTICIPACAO", FNC_ConvValorFormatoAmericano(.Cells(const_GridPlanoContas_Participacao).Value)),
                               DBParametro_Montar("CM_PARTICIPACAO", .Cells(const_GridPlanoContas_Comentario).Value,,, const_BancoDados_TamanhoComentario))
        End With
      Next

      ParcelaAtualizarDados()

      If cSQ_MOVFINANCEIRAPARCELA_QUITAR.Count > 0 And iID_PEDIDO > 0 Then
        Dim oForm As New frmLancaContasReceberPagar_Quitar

        oForm.cSQ_MOVFINANCEIRAPARCELA = cSQ_MOVFINANCEIRAPARCELA_QUITAR
        oForm.bPagamentoPorParcela = (iID_PEDIDO > 0)
        oForm.bGravacaoAutomatica = (iID_PEDIDO > 0)
        oForm.iTipoMovimentacao = cboTipoMovimentacaoFinanceira.SelectedValue
        oForm.sTipoMovimentacao = cboTipoMovimentacaoFinanceira.Text

        FNC_AbriTela(oForm, , True, True)
      Else
        If oLancaContasReceberPagar_QuitarForm.Validar(False) Then
          oLancaContasReceberPagar_QuitarForm.iSQ_PESSOA_CREDITO = psqPessoa.ID_Pessoa
          oLancaContasReceberPagar_QuitarForm.dPagamento = txtDataPagamento.DateTime
          oLancaContasReceberPagar_QuitarForm.dValorFinal = CDbl(lblValorTotalPendente.Tag)
          oLancaContasReceberPagar_QuitarForm.Gravar()
        End If
      End If

      'Quitação/Compensão das parcelas em dinheiro
      sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_QUITAR_TIPODOCUMENTO_CAD", False, "@ID_MOVFINANCEIRA",
                                                                                 "@SQ_TIPO_DOCUMENTO",
                                                                                 "@ID_USUARIO")
      DBExecutar(sSqlText, DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                           DBParametro_Montar("SQ_TIPO_DOCUMENTO", const_TipoDocumento_Dinheiro),
                           DBParametro_Montar("ID_USUARIO", iID_USUARIO))

      FormMovimentacaoFinanceira_Status_Atualizar(iSQ_MOVFINANCEIRA)

      If Not oCadastroAtendimentoFaturamento_Item Is Nothing Then
        For Each oItem As cCadastroAtendimentoFaturamento_Item In oCadastroAtendimentoFaturamento_Item
          sSqlText = DBMontar_SP("SP_CLINICA_VENDA_PROCEDIMENTO", False, "@SQ_CLINICA_VENDA_PROCEDIMENTO",
                                                                         "@SQ_MOVFINANCEIRA",
                                                                         "@ID_USUARIO")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA_PROCEDIMENTO", oItem.SQ_CLINICA_VENDA_PROCEDIMENTO),
                               DBParametro_Montar("SQ_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                               DBParametro_Montar("ID_USUARIO", iID_USUARIO))
        Next

        sSqlText = "SELECT SQ_MOVFINANCEIRAPARCELA" &
                   " FROM TB_MOVFINANCEIRAPARCELA" &
                   " WHERE ID_MOVFINANCEIRA = " & iSQ_MOVFINANCEIRA &
                     " AND ID_OPT_STATUS = " & enOpcoes.StatusMovimentacaoFinanceira_Lancado.GetHashCode
        Dim oData As DataTable
        oData = DBQuery(sSqlText)

        If Not objDataTable_Vazio(oData) Then
          For Each row As DataRow In oData.Rows
            sSqlText = "UPDATE TB_MOVFINANCEIRAPARCELA" &
                       " SET ID_OPT_STATUS = " & enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode &
                       " WHERE SQ_MOVFINANCEIRAPARCELA = " & row.Item("SQ_MOVFINANCEIRAPARCELA") &
                         " AND ID_OPT_STATUS = " & enOpcoes.StatusMovimentacaoFinanceira_Lancado.GetHashCode
            DBExecutar(sSqlText)

            FormCadastroHistorico_Gravar(iID_EMPRESA_FILIAL,
                                        enOpcoes.Processo_Historico_Financeiro_LancamentoContasaReceber_Pagar.GetHashCode,
                                         enOpcoes.Processo_Acao_Alteracao.GetHashCode,
                                         row.Item("SQ_MOVFINANCEIRAPARCELA"),
                                         "Alteração de Status de 'Lançado' para 'Aberta'",
                                         Nothing,
                                         sSISTEMA_UltimaVersao,
                                         FNC_Computador_Nome(),
                                         txtCodMovimentacao.Text,
                                         Nothing)
          Next
        End If
      End If

      If bVoucher Then
        sSqlText = DBMontar_SP("SP_VOUCHER_INS", False, "@SQ_VOUCHER OUT",
                                                        "@ID_EMPRESA",
                                                        "@ID_PESSOA",
                                                        "@ID_MOVFINANCEIRA",
                                                        "@VL_VOUCHER",
                                                        "@ID_USUARIO")
        If DBExecutar(sSqlText, DBParametro_Montar("SQ_VOUCHER", 0, , ParameterDirection.InputOutput),
                                DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                DBParametro_Montar("ID_PESSOA", psqPessoa.ID_Pessoa),
                                DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                                DBParametro_Montar("VL_VOUCHER", txtValorMovimentacao.Value),
                                DBParametro_Montar("ID_USUARIO", iID_USUARIO)) Then
          If DBTeveRetorno() Then
            iSQ_VOUCHER = DBRetorno(1)
          End If
        End If
      End If

      CarregarDados()

      Return True
    Else
      Return False
    End If

    Exit Function

Erro:
    Return False
  End Function

  Private Sub grdParcela_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdParcela.AfterCellUpdate
    If bAtualizandoParcela Then Exit Sub

    Dim iCont As Integer

    Select Case e.Cell.Column.Index
      Case const_GridParcela_ValorQuitando, const_GridParcela_ValorDescontoPagto, const_GridParcela_ValorAcrescimoPagto, const_GridParcela_ValorImpostoRetidoFonte
        GridContas_AtualizarValores(e.Cell.Row.Index)
      Case const_GridParcela_ValorParcela, const_GridParcela_ValorPago
        If FNC_In(FNC_NVL(e.Cell.Row.Cells(const_GridParcela_ID_OPT_STATUS).Value, enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode()),
                                  enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode(),
                                  enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode()) Then
          e.Cell.Row.Cells(const_GridParcela_ValorTotalAPagar).Value = e.Cell.Value - FNC_NVL(e.Cell.Row.Cells(const_GridParcela_ValorPago).Value, 0)
          e.Cell.Row.Cells(const_GridParcela_ValorDebito).Value = e.Cell.Row.Cells(const_GridParcela_ValorTotalAPagar).Value
        End If

        GridParcela_TotalValor()
      Case const_GridParcela_TipoDocumento
        If e.Cell.Row.Index = 0 Then
          bAtualizandoParcela = True

          For iCont = 1 To grdParcela.Rows.Count - 1
            If FNC_CampoNulo(grdParcela.Rows(iCont).Cells(const_GridParcela_TipoDocumento).Value) Then
              grdParcela.Rows(iCont).Cells(const_GridParcela_TipoDocumento).Value = e.Cell.Value
            End If
          Next

          bAtualizandoParcela = False
        End If
      Case const_GridParcela_DataVencimento
        GridParcela_CalcularValor(False)
      Case const_GridParcela_DataDocumento
        If e.Cell.Row.Index = 0 Then
          bAtualizandoParcela = True

          For iCont = 1 To grdParcela.Rows.Count - 1
            If FNC_CampoNulo(grdParcela.Rows(iCont).Cells(const_GridParcela_DataDocumento).Value) Then
              grdParcela.Rows(iCont).Cells(const_GridParcela_DataDocumento).Value = e.Cell.Value
            End If
          Next

          bAtualizandoParcela = False
        End If
      Case const_GridParcela_Banco
        If e.Cell.Row.Index = 0 Then
          bAtualizandoParcela = True

          For iCont = 1 To grdParcela.Rows.Count - 1
            If FNC_CampoNulo(grdParcela.Rows(iCont).Cells(const_GridParcela_Banco).Value) Then
              grdParcela.Rows(iCont).Cells(const_GridParcela_Banco).Value = e.Cell.Value
            End If
          Next

          bAtualizandoParcela = False
        End If
      Case const_GridParcela_NumeroAgencia
        If e.Cell.Row.Index = 0 Then
          bAtualizandoParcela = True

          For iCont = 1 To grdParcela.Rows.Count - 1
            If FNC_CampoNulo(grdParcela.Rows(iCont).Cells(const_GridParcela_NumeroAgencia).Value) Then
              grdParcela.Rows(iCont).Cells(const_GridParcela_NumeroAgencia).Value = e.Cell.Value
            End If
          Next

          bAtualizandoParcela = False
        End If
      Case const_GridParcela_NumeroConta_Digito
        If e.Cell.Row.Index = 0 Then
          bAtualizandoParcela = True

          For iCont = 1 To grdParcela.Rows.Count - 1
            If FNC_CampoNulo(grdParcela.Rows(iCont).Cells(const_GridParcela_NumeroConta_Digito).Value) Then
              grdParcela.Rows(iCont).Cells(const_GridParcela_NumeroConta_Digito).Value = e.Cell.Value
            End If
          Next

          bAtualizandoParcela = False
        End If
      Case const_GridParcela_CodigoDocumento
        If e.Cell.Row.Index = 0 And Trim(FNC_SoNumero(e.Cell.Value)) = Trim(e.Cell.Value) Then
          bAtualizandoParcela = True

          For iCont = 1 To grdParcela.Rows.Count - 1
            If FNC_CampoNulo(grdParcela.Rows(iCont).Cells(const_GridParcela_CodigoDocumento).Value) Then
              grdParcela.Rows(iCont).Cells(const_GridParcela_CodigoDocumento).Value = Val(e.Cell.Value) + iCont
            End If
          Next

          bAtualizandoParcela = False
        End If
      Case const_GridParcela_Provisionada
        If e.Cell.Row.Index = 0 Then
          bAtualizandoParcela = True

          For iCont = 1 To grdParcela.Rows.Count - 1
            If FNC_CampoNulo(grdParcela.Rows(iCont).Cells(const_GridParcela_Provisionada).Value) Then
              grdParcela.Rows(iCont).Cells(const_GridParcela_Provisionada).Value = e.Cell.Value
            End If
          Next

          bAtualizandoParcela = False
        End If
    End Select
  End Sub

  Private Sub grdPlanoContas_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdPlanoContas.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridPlanoContas_PlanoContas).Value) Then
      FNC_Mensagem("É preciso informar o plano de contas")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridPlanoContas_Participacao).Value) Then
      FNC_Mensagem("É preciso informar a porcentagem de participação do plano de contas")
      e.Cancel = True
      Exit Sub
    End If
  End Sub

  Private Sub chkValorParcela_CheckedChanged(sender As Object, e As EventArgs) Handles chkValorParcela.CheckedChanged
    txtPercEntrada.Value = 0
    GridParcela_CalcularValor()
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    Novo()

    bCarregando = True

    sSqlText = "SELECT * FROM TB_MOVFINANCEIRA WHERE SQ_MOVFINANCEIRA = " & iSQ_MOVFINANCEIRA
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        txtCodMovimentacao.Text = .Item("CD_MOVFINANCEIRA")
        ComboBox_Selecionar(cboTipoMovimentacaoFinanceira, .Item("ID_OPT_TIPOMOVFINANCEIRA"))
        ComboBox_Selecionar(cboConvenio, .Item("ID_CONVENIO"))
        ComboBox_Selecionar(cboContaCaixa, FNC_NVL(.Item("ID_CONTAFINANCEIRA_CREDITO"), .Item("ID_CONTAFINANCEIRA_DEBITO")))
        oCalculoFinanceiro_Desconto.PeriodoCalculoFinanceiro = FNC_NVL(.Item("ID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO"), 0)
        oCalculoFinanceiro_Juros.PeriodoCalculoFinanceiro = FNC_NVL(.Item("ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS"), 0)
        psqPessoa.ID_Pessoa = .Item("ID_PESSOA")
        txtDt1Parcela.Value = .Item("DT_1_VENCIMENTO")
        txtDescricaoLancamento.Text = .Item("DS_MOVFINANCEIRA")
        txtValorMovimentacao.Value = .Item("VL_MOVFINANCEIRA")
        txtValorOriginal.Value = FNC_NVL(.Item("VL_ORIGINAL"), 0)
        oCalculoFinanceiro_Desconto.Valor = FNC_NVL(.Item("VL_DESCONTO"), 0)
        txtPercEntrada.Value = .Item("PC_ENTRADA")
        oCalculoFinanceiro_Juros.Valor = .Item("PC_JUROS")
        oCalculoFinanceiro_Desconto.Valor = .Item("PC_DESCONTO")
        txtMulta.Value = .Item("PC_MULTA")
        txtValorMulta.Value = FNC_NVL(.Item("VL_MULTA"), 0)
        txtComentario.Text = FNC_NVL(.Item("CM_MOVFINANCEIRA"), "")
      End With

      sSqlText = "SELECT MFP.SQ_MOVFINANCEIRAPARCELA," &
                              "MFP.ID_MOVFINANCEIRA," &
                              "MFP.ID_DOCUMENTOFINANCEIRO," &
                              "MFP.ID_OPT_STATUS," &
                              "DCF.ID_EMITENTE," &
                              "IIF(MFP.ID_OPT_STATUS = " & enOpcoes.StatusMovimentacaoFinanceira_Estimado & ", 1, 0)," &
                              "MFP.CD_PARCELA," &
                              "MFP.DT_VENCIMENTO," &
                              "MFP.VL_PARCELA," &
                              "MFP.ID_TIPO_DOCUMENTO," &
                              "MFP.CD_DOCUMENTO," &
                              "MFP.DS_EMITENTE," &
                              "DCF.DT_DOCUMENTO," &
                              "DCF.ID_BANCO," &
                              "DCF.NR_BANCO_AGENCIA," &
                              "DCF.NR_BANCO_CONTA," &
                              "DCF.NR_BANCO_CONTA_DIGITO," &
                              "DCF.DS_DOCUMENTO," &
                              "MFP.VL_QUITADO," &
                              "MFP.VL_DEBITO," &
                              "MFP.VL_DEBITO - MFP.VL_CALC_DESCONTO + MFP.VL_CALC_MULTA + MFP.VL_CALC_JUROS," &
                              "MFP.VL_DEBITO - MFP.VL_CALC_DESCONTO + MFP.VL_CALC_MULTA + MFP.VL_CALC_JUROS," &
                              "MFP.VL_DESCONTO," &
                              "MFP.VL_CALC_DESCONTO," &
                              "MFP.VL_CALC_MULTA," &
                              "MFP.VL_CALC_JUROS," &
                              "MFP.VL_IMPOSTORETIDO," &
                              "MFP.QT_DIAS_ATRASO," &
                              "OPC.NO_OPCAO NO_OPT_STATUS," &
                              "MFP.PC_DESCONTO," &
                              "IIF(ISNULL(PSEMP.PC_PROFISSIONAL_RETEMIMPOSTO, 0) > 0, 'Imposto Retido', '')" &
                       " FROM TB_MOVFINANCEIRA MFN" &
                        " INNER JOIN VW_MOVFINANCEIRAPARCELA MFP ON MFP.ID_MOVFINANCEIRA = MFN.SQ_MOVFINANCEIRA" &
                        " INNER JOIN TB_PESSOA_EMPRESA PSEMP ON PSEMP.ID_PESSOA = MFP.ID_PESSOA" &
                                                          " AND PSEMP.ID_EMPRESA = 2" &
                        " INNER JOIN TB_OPCAO OPC ON OPC.SQ_OPCAO = MFP.ID_OPT_STATUS" &
                         " LEFT JOIN TB_DOCUMENTOFINANCEIRO DCF ON DCF.SQ_DOCUMENTOFINANCEIRO = MFP.ID_DOCUMENTOFINANCEIRO" &
                       " WHERE MFN.SQ_MOVFINANCEIRA = " & iSQ_MOVFINANCEIRA &
                       " ORDER BY MFP.CD_PARCELA"
      objGrid_Carregar(grdParcela, sSqlText, New Integer() {const_GridParcela_SQ_MOVFINANCEIRAPARCELA,
                                                                  const_GridParcela_ID_MOVFINANCEIRA,
                                                                  const_GridParcela_ID_DOCUMENTOFINANCEIRO,
                                                                  const_GridParcela_ID_OPT_STATUS,
                                                                  const_GridParcela_ID_EMITENTE,
                                                                  const_GridParcela_Provisionada,
                                                                  const_GridParcela_CodigoParcela,
                                                                  const_GridParcela_DataVencimento,
                                                                  const_GridParcela_ValorParcela,
                                                                  const_GridParcela_TipoDocumento,
                                                                  const_GridParcela_CodigoDocumento,
                                                                  const_GridParcela_Emitente,
                                                                  const_GridParcela_DataDocumento,
                                                                  const_GridParcela_Banco,
                                                                  const_GridParcela_NumeroAgencia,
                                                                  const_GridParcela_NumeroConta,
                                                                  const_GridParcela_NumeroConta_Digito,
                                                                  const_GridParcela_DescricaoDocumento,
                                                                  const_GridParcela_ValorPago,
                                                                  const_GridParcela_ValorDebito,
                                                                  const_GridParcela_ValorRestante,
                                                                  const_GridParcela_ValorTotalAPagar,
                                                                  const_GridParcela_ValorDesconto,
                                                                  const_GridParcela_ValorDescontoPagto,
                                                                  const_GridParcela_ValorMulta,
                                                                  const_GridParcela_ValorJuros,
                                                                  const_GridParcela_ValorImpostoRetidoFonte,
                                                                  const_GridParcela_DiasAtraso,
                                                                  const_GridParcela_NO_OPT_STATUS,
                                                                  const_GridParcela_PC_DESCONTO,
                                                                  const_GridParcela_JustificativaDescontoAcrescimo})

      txtQtdeParcela.Value = grdParcela.Rows.Count

      sSqlText = "SELECT ID_PLANOCONTAS," &
                        "PC_PARTICIPACAO," &
                        "CM_PARTICIPACAO" &
                 " FROM TB_MOVFINANCEIRA_PLANOCONTAS" &
                 " WHERE ID_MOVFINANCEIRA = " & iSQ_MOVFINANCEIRA
      objGrid_Carregar(grdPlanoContas, sSqlText, New Integer() {const_GridPlanoContas_PlanoContas,
                                                                const_GridPlanoContas_Participacao,
                                                                const_GridPlanoContas_Comentario})

      GridPlanoContas_CalcularParticipacao()

      sSqlText = "SELECT COUNT(*) FROM TB_MOVFINANCEIRAPARCELA" &
                       " WHERE ID_MOVFINANCEIRA = " & iSQ_MOVFINANCEIRA &
                         " AND ID_OPT_STATUS NOT IN (" & enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode & ", " &
                                                         enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode & ")"
      JurosDescontoMulta_Habilitar((DBQuery_ValorUnico(sSqlText, 0) = 0))

      With grdParcela.DisplayLayout.Bands(0).Columns(const_GridParcela_Provisionada).Header
        .CheckBoxVisibility = HeaderCheckBoxVisibility.Never
        .CheckBoxSynchronization = HeaderCheckBoxSynchronization.None
      End With

      bCarregando = False

      GridParcela_TotalValor()
    End If
  End Sub

  Private Sub JurosDescontoMulta_Habilitar(bHabilitar As Boolean)
    lblRPercEntrada.Enabled = bHabilitar
    txtPercEntrada.Enabled = bHabilitar
    lblRMulta.Enabled = bHabilitar
    txtMulta.Enabled = bHabilitar
    lblRValorMulta.Enabled = bHabilitar
    txtValorMulta.Enabled = bHabilitar
    oCalculoFinanceiro_Desconto.Enabled = bHabilitar
    oCalculoFinanceiro_Juros.Enabled = bHabilitar
  End Sub

  Private Sub grdParcela_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdParcela.BeforeCellActivate
    If Not FNC_In(FNC_NVL(e.Cell.Row.Cells(const_GridParcela_ID_OPT_STATUS).Value, enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode),
                              enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode,
                              enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode) Then
      If FNC_In(e.Cell.Column.Index, const_GridParcela_ValorDescontoPagto,
                                     const_GridParcela_ValorAcrescimoPagto,
                                     const_GridParcela_JustificativaDescontoAcrescimo) And
               e.Cell.Row.Cells(const_GridParcela_ValorTotalAPagar).Value <> 0 Then
        e.Cancel = False
      Else
        e.Cancel = True
      End If
    Else
      Select Case e.Cell.Column.Index
        Case const_GridParcela_ValorParcela
          e.Cancel = chkValorParcela.Checked
        Case const_GridParcela_Provisionada
          e.Cancel = Not FNC_In(FNC_NVL(e.Cell.Row.Cells(const_GridParcela_ID_OPT_STATUS).Value, enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode),
                                          enOpcoes.StatusMovimentacaoFinanceira_Estimado.GetHashCode,
                                          enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode)
      End Select
    End If
  End Sub

  Private Sub cboSegmento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboConvenio.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboConvenio.SelectedIndex = -1
    End If
  End Sub

  Private Sub txtValorOriginal_ValueChanged(sender As Object, e As EventArgs) Handles txtValorOriginal.ValueChanged
    Desconto_Calculo()
  End Sub

  Private Sub Desconto_Calculo()
    If txtValorOriginal.Value - txtValorMovimentacao.Value < 0 Then
      txtValorDesconto.Value = 0
    Else
      txtValorDesconto.Value = txtValorOriginal.Value - txtValorMovimentacao.Value
    End If
  End Sub

  Private Sub CondicaoPagamento_Tratar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    If iID_PEDIDO > 0 Then
      sSqlText = "SELECT * FROM VW_PEDIDO_CONDICAOPAGAMENTO WHERE SQ_PEDIDO = " & iID_PEDIDO
    Else
      sSqlText = "SELECT * FROM VW_CONDICAOPAGAMENTO WHERE SQ_CONDICAOPAGAMENTO = " & iID_CONDICAOPAGAMENTO
    End If
    oData = DBQuery(sSqlText)

    If Not objDataTable_CampoVazio(oData) Then
      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          If FNC_CampoNulo(.Item("ID_FORMAPAGAMENTO_PARCELA_PADRAO")) Then
            txtQtdeParcela.Value = 1
          Else
            txtQtdeParcela.Value = FNC_NVL(.Item("QT_PARCELA"), 0)
            If FNC_NVL(txtPercEntrada.Value, 0) > 0 Then
              txtQtdeParcela.Value = txtQtdeParcela.Value + 1
            End If
          End If

          txtDt1Parcela.Value = Now.AddDays(FNC_NVL(.Item("QT_PARCELA_DIASPRIMEIRAPARCELA"), 0)).Date
          txtNrDiaIntervalo.Value = FNC_NVL(.Item("QT_PARCELA_DIASINTERVALO"), 0)
          oCalculoFinanceiro_Juros.PeriodoCalculoFinanceiro = FNC_NVL(.Item("ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS"), 0)
          oCalculoFinanceiro_Juros.Valor = FNC_NVL(.Item("PC_JUROS"), 0)

          If FNC_NVL(.Item("IC_GERAR_AVISTA"), "N") = "S" Then
            txtDt1Parcela.DateTime = Now.Date()
          End If

          GridParcela_CarregarLinhas()

          For iCont = 0 To grdParcela.Rows.Count - 1
            If iCont = 0 Then
              If FNC_CampoNulo(.Item("ID_TIPO_DOCUMENTO_PARCELA_PADRAO")) Or FNC_NVL(txtPercEntrada.Value, 0) > 0 Then
                If iID_PEDIDO > 0 Then
                  If FNC_CampoNulo(.Item("ID_TIPO_DOCUMENTO")) Then
                    grdParcela.Rows(iCont).Cells(const_GridParcela_TipoDocumento).Value = .Item("ID_TIPO_DOCUMENTO_ENTRADA_PADRAO")
                  Else
                    grdParcela.Rows(iCont).Cells(const_GridParcela_TipoDocumento).Value = .Item("ID_TIPO_DOCUMENTO")
                  End If
                  grdParcela.Rows(iCont).Cells(const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL).Value = .Item("ID_FORMAPAGAMENTO")
                Else
                  grdParcela.Rows(iCont).Cells(const_GridParcela_TipoDocumento).Value = .Item("ID_TIPO_DOCUMENTO_ENTRADA_PADRAO")
                  grdParcela.Rows(iCont).Cells(const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL).Value = .Item("ID_FORMAPAGAMENTO_ENTRADA_PADRAO")
                End If
              Else
                grdParcela.Rows(iCont).Cells(const_GridParcela_TipoDocumento).Value = .Item("ID_TIPO_DOCUMENTO_PARCELA_PADRAO")
                grdParcela.Rows(iCont).Cells(const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL).Value = .Item("ID_FORMAPAGAMENTO_PARCELA_PADRAO")
              End If
            Else
              grdParcela.Rows(iCont).Cells(const_GridParcela_TipoDocumento).Value = .Item("ID_TIPO_DOCUMENTO_PARCELA_PADRAO")
              grdParcela.Rows(iCont).Cells(const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL).Value = .Item("ID_FORMAPAGAMENTO_PARCELA_PADRAO")
            End If
          Next
        End With
      End If
    End If
  End Sub

  Private Sub Contabilizacao_Tratar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim dPC_100 As Double = 100
    Dim dAux As Double
    Dim iAux As Integer = 0

    sSqlText = "SELECT CTB.ID_PLANOCONTAS, CTB.ID_TIPO_DOCUMENTO" &
                   " FROM VW_CONTABILIZACAO_PLANOCONTAS_FPGTO CTB" &
                   " WHERE CTB.ID_CONTABILIZACAO = " & iID_CONTABILIZACAO &
                     " AND CTB.ID_OPT_CREDITODEBITO = " & IIf(FNC_NVL(cboTipoMovimentacaoFinanceira.SelectedValue, 0) = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode(),
                                                              enOpcoes.CreditoDebito_Debito,
                                                              enOpcoes.CreditoDebito_Credito)

    If iID_PEDIDO > 0 Then
      sSqlText = sSqlText &
                       " AND (CTB.ID_FORMAPAGAMENTO IN (SELECT ID_FORMAPAGAMENTO FROM VW_PEDIDO_PAGAMENTO WHERE ID_PEDIDO = " & iID_PEDIDO & ") OR" &
                       "      (CTB.ID_FORMAPAGAMENTO IN (SELECT ID_FORMAPAGAMENTO_ENTRADA_PADRAO FROM VW_CONDICAOPAGAMENTO" &
                                                        " WHERE SQ_CONDICAOPAGAMENTO = " & iID_CONDICAOPAGAMENTO &
                                                          " AND ID_TIPO_DOCUMENTO_FORMAPAGAMENTO_ENTRADA_PADRAO IS NOT NULL) AND
                         NOT EXISTS((SELECT ID_FORMAPAGAMENTO FROM VW_PEDIDO_PAGAMENTO WHERE ID_PEDIDO =  " & iID_PEDIDO & "))) OR" &
                       "      CTB.ID_FORMAPAGAMENTO IN (SELECT ID_FORMAPAGAMENTO_PARCELA_PADRAO FROM VW_CONDICAOPAGAMENTO" &
                                                       " WHERE SQ_CONDICAOPAGAMENTO = " & iID_CONDICAOPAGAMENTO &
                                                         " AND ID_TIPO_DOCUMENTO_FORMAPAGAMENTO_PARCELA_PADRAO IS NOT NULL))"
    ElseIf iID_CONDICAOPAGAMENTO > 0 Then
      sSqlText = sSqlText &
                       " AND (CTB.ID_FORMAPAGAMENTO IN (SELECT ID_FORMAPAGAMENTO_ENTRADA_PADRAO FROM VW_CONDICAOPAGAMENTO" &
                                                       " WHERE SQ_CONDICAOPAGAMENTO = " & iID_CONDICAOPAGAMENTO &
                                                         " AND ID_TIPO_DOCUMENTO_FORMAPAGAMENTO_ENTRADA_PADRAO IS NOT NULL) OR" &
                       "      CTB.ID_FORMAPAGAMENTO IN (SELECT ID_FORMAPAGAMENTO_PARCELA_PADRAO FROM VW_CONDICAOPAGAMENTO" &
                                                       " WHERE SQ_CONDICAOPAGAMENTO = " & iID_CONDICAOPAGAMENTO &
                                                         " AND ID_TIPO_DOCUMENTO_FORMAPAGAMENTO_PARCELA_PADRAO IS NOT NULL))"

    End If
    objGrid_Carregar(grdPlanoContas, sSqlText, New Integer() {const_GridPlanoContas_PlanoContas,
                                                              const_GridPlanoContas_ID_TIPO_DOCUMENTO})

    sSqlText = "SELECT * FROM VW_PEDIDO_PAGAMENTO" &
                   " WHERE ID_PEDIDO = " & iID_PEDIDO
    oData = DBQuery(sSqlText)

    If objDataTable_Vazio(oData) Then
      For iCont_01 = 0 To oData.Rows.Count - 1
        dAux = objGrid_CalcularTotalColuna(grdParcela,
                                                   const_GridParcela_ValorParcela,
                                                   grdTipoCalculoTotal.SomarValor,
                                                   New Object() {const_GridParcela_TipoDocumento, oData.Rows(iCont_01).Item("ID_TIPO_DOCUMENTO")})
        dAux = Math.Round(dAux / txtValorMovimentacao.Value, 2) * 100

        For iCont_02 = 0 To grdPlanoContas.Rows.Count - 1
          If objGrid_Valor(grdPlanoContas, const_GridPlanoContas_ID_TIPO_DOCUMENTO, iCont_02) = oData.Rows(iCont_01).Item("ID_TIPO_DOCUMENTO") Then
            grdPlanoContas.Rows(iCont_02).Cells(const_GridPlanoContas_Participacao).Value = dAux
            Exit For
          End If
        Next
      Next
    Else
      If iID_PEDIDO > 0 Then
        sSqlText = "SELECT * FROM VW_PEDIDO_CONDICAOPAGAMENTO" &
                         " WHERE SQ_PEDIDO = " & iID_PEDIDO
      Else
        sSqlText = "SELECT * FROM VW_CONDICAOPAGAMENTO" &
                         " WHERE SQ_CONDICAOPAGAMENTO = " & iID_CONDICAOPAGAMENTO
      End If
      oData = DBQuery(sSqlText)

      If Not objDataTable_CampoVazio(oData) Then
        For iCont_01 = 0 To oData.Rows.Count - 1
          If iID_PEDIDO > 0 Then
            iAux = oData.Rows(iCont_01).Item("ID_FORMAPAGAMENTO")
          Else
            If FNC_CampoNulo(oData.Rows(iCont_01).Item("ID_FORMAPAGAMENTO_ENTRADA_PADRAO")) Then
              iAux = oData.Rows(iCont_01).Item("ID_FORMAPAGAMENTO_ENTRADA_PADRAO")
            End If
          End If
          If iAux > 0 Then
            dAux = objGrid_CalcularTotalColuna(grdParcela,
                                                           const_GridParcela_ValorParcela,
                                                           grdTipoCalculoTotal.SomarValor,
                                                           New Object() {const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL, iAux})
            dAux = Math.Round(dAux / txtValorMovimentacao.Value, 2) * 100

            For iCont_02 = 0 To grdPlanoContas.Rows.Count - 1
              If objGrid_Valor(grdPlanoContas, const_GridPlanoContas_ID_TIPO_DOCUMENTO, iCont_02) = FNC_NVL(oData.Rows(iCont_01).Item("ID_TIPO_DOCUMENTO_FORMAPAGAMENTO_ENTRADA_PADRAO"), 0) Then
                grdPlanoContas.Rows(iCont_02).Cells(const_GridPlanoContas_Participacao).Value = dAux
                Exit For
              End If
            Next
          End If

          If Not FNC_CampoNulo(oData.Rows(iCont_01).Item("ID_FORMAPAGAMENTO_PARCELA_PADRAO")) Then
            dAux = objGrid_CalcularTotalColuna(grdParcela,
                                                           const_GridParcela_ValorParcela,
                                                           grdTipoCalculoTotal.SomarValor,
                                                           New Object() {const_GridParcela_ID_FORMAPAGAMENTO_PREFERENCIAL, oData.Rows(iCont_01).Item("ID_FORMAPAGAMENTO_PARCELA_PADRAO")})
            dAux = Math.Round(dAux / txtValorMovimentacao.Value, 2) * 100

            For iCont_02 = 0 To grdPlanoContas.Rows.Count - 1
              If objGrid_Valor(grdPlanoContas, const_GridPlanoContas_ID_TIPO_DOCUMENTO, iCont_02) = oData.Rows(iCont_01).Item("ID_TIPO_DOCUMENTO_FORMAPAGAMENTO_PARCELA_PADRAO") Then
                grdPlanoContas.Rows(iCont_02).Cells(const_GridPlanoContas_Participacao).Value = dAux
                Exit For
              End If
            Next
          End If
        Next
      End If
    End If

    dPC_100 = dPC_100 - (objGrid_CalcularTotalColuna(grdPlanoContas,
                                                         const_GridPlanoContas_Participacao,
                                                         grdTipoCalculoTotal.SomarValor))

    If dPC_100 > 0 Then
      For iCont_01 = 0 To grdPlanoContas.Rows.Count - 1
        If FNC_CampoNulo(grdPlanoContas.Rows(iCont_01).Cells(const_GridPlanoContas_ID_TIPO_DOCUMENTO).Value) Then
          grdPlanoContas.Rows(iCont_01).Cells(const_GridPlanoContas_Participacao).Value = dPC_100
          Exit For
        End If
      Next
    End If
  End Sub

  Private Sub txtPercEntrada_ValueChanged(sender As Object, e As EventArgs) Handles txtPercEntrada.ValueChanged
    If txtPercEntrada.Value > 0 Then
      txtDt1Parcela.DateTime = Now.Date()
    End If

    GridParcela_CalcularValor()
  End Sub

  Private Sub frmLancaContasReceberPagar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    If bEncerrar Then Close()
  End Sub

  Private Sub grdPlanoContas_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdPlanoContas.BeforeRowsDeleted
    e.DisplayPromptMsg = False
  End Sub

  Private Sub grdPlanoContas_AfterRowsDeleted(sender As Object, e As EventArgs) Handles grdPlanoContas.AfterRowsDeleted
    GridPlanoContas_CalcularParticipacao()
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    Novo(True)
  End Sub

  Private Sub Novo(Optional bZerarSQ As Boolean = False)
    FormatarPlanoContas()

    txtQtdeParcela.Value = 1
    txtDt1Parcela.Value = Now.Date
    optTipoInvervalo_Livre.Checked = True
    GridParcela_CarregarLinhas()
    GridParcela_CalcularDias()

    psqPessoa.ID_Pessoa = 0
    txtNrDiaIntervalo.Value = 0
    optTipoInvervalo_Livre.Checked = True
    txtDescricaoLancamento.Text = ""
    chkValorParcela.Checked = False
    txtValorMovimentacao.Value = 0
    txtValorOriginal.Value = 0
    txtValorDesconto.Value = 0
    txtPercEntrada.Value = 0
    oCalculoFinanceiro_Juros.Valor = 0
    oCalculoFinanceiro_Desconto.Valor = 0
    txtMulta.Value = 0
    txtValorMulta.Value = 0
    txtComentario.Text = ""

    If bZerarSQ Then iSQ_MOVFINANCEIRA = 0

    cboTipoMovimentacaoFinanceira.Enabled = (iTipoMovimentacao = 0)
    cboContaCaixa.Enabled = True
    psqPessoa.Enabled = True
    txtDt1Parcela.Enabled = True
    txtQtdeParcela.Enabled = True
    txtNrDiaIntervalo.Enabled = True
    optTipoInvervalo_Ano.Enabled = True
    optTipoInvervalo_Livre.Enabled = True
    optTipoInvervalo_Mensal.Enabled = True
    optTipoInvervalo_Quizena.Enabled = True
    optTipoInvervalo_Semana.Enabled = True
    optTipoInvervalo_Semestre.Enabled = True
    optTipoInvervalo_Trimestre.Enabled = True
    txtValorMovimentacao.Enabled = True
    chkValorParcela.Enabled = True
    JurosDescontoMulta_Habilitar(True)

    oDBParcela.Rows.Clear()

    GridParcela_CarregarLinhas()

    oLancaContasReceberPagar_QuitarForm.Inicializar()

    cmdImprimir.Enabled = False
  End Sub

  Private Sub frmLancaContasReceberPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdParcela, Me.Name)
    objGrid_Configuracao_Gravar(grdPlanoContas, Me.Name)
  End Sub

  Private Sub oLancaContasReceberPagar_QuitarForm_ValorPago() Handles oLancaContasReceberPagar_QuitarForm.ValorPago
    oLancaContasReceberPagar_QuitarForm.CalcularBaixarParcelas(grdParcela,
                                                                   const_GridParcela_ValorQuitando,
                                                                   const_GridParcela_ValorTotalAPagar,
                                                                   const_GridParcela_ValorRestante)
  End Sub

  Private Sub ParcelaAtualizarDados()
    Dim iCont As Integer

    For iCont = 0 To grdParcela.Rows.Count - 1
      With grdParcela.Rows(iCont)
        .Cells(const_GridParcela_ID_MOVFINANCEIRA).Value = iSQ_MOVFINANCEIRA
        .Cells(const_GridParcela_PC_DESCONTO).Value = oCalculoFinanceiro_Desconto.Valor
      End With
    Next
  End Sub

  Private Sub txtDataPagamento_ValueChanged(sender As Object, e As EventArgs) Handles txtDataPagamento.ValueChanged
    TratarDataPagamento()
  End Sub

  Private Sub TratarDataPagamento()
    Dim iCont As Integer

    For iCont = 0 To grdParcela.Rows.Count - 1
      With grdParcela.Rows(iCont)
        If Not FNC_CampoNulo(.Cells(const_GridParcela_DataVencimento).Value) Then
          .Cells(const_GridParcela_ValorDescontoPagto).Value = FormMovimentacaoFinanceira_CalculoFinanceiro(oCalculoFinanceiro_Desconto.PeriodoCalculoFinanceiro,
                                                                                                            oCalculoFinanceiro_Desconto.Valor,
                                                                                                            FNC_NVL(.Cells(const_GridParcela_ValorDebito).Value, 0),
                                                                                                            FNC_NVL(.Cells(const_GridParcela_DataVencimento).Value, 0),
                                                                                                            txtDataPagamento.DateTime.Date,
                                                                                                            const_CalculoFinanceiro_DESCONTO)
          .Cells(const_GridParcela_ValorJuros).Value = FormMovimentacaoFinanceira_CalculoFinanceiro(oCalculoFinanceiro_Juros.PeriodoCalculoFinanceiro,
                                                                                                            oCalculoFinanceiro_Juros.Valor,
                                                                                                            FNC_NVL(.Cells(const_GridParcela_ValorDebito).Value, 0),
                                                                                                            FNC_NVL(.Cells(const_GridParcela_DataVencimento).Value, 0),
                                                                                                            txtDataPagamento.DateTime.Date,
                                                                                                            const_CalculoFinanceiro_JUROS)

          If .Cells(const_GridParcela_DataVencimento).Value < txtDataPagamento.DateTime.Date Then
            .Cells(const_GridParcela_ValorMulta).Value = txtValorMulta.Value
          Else
            .Cells(const_GridParcela_ValorMulta).Value = 0
          End If
        Else
          .Cells(const_GridParcela_ValorDescontoPagto).Value = 0
          .Cells(const_GridParcela_ValorJuros).Value = 0
          .Cells(const_GridParcela_ValorMulta).Value = 0
        End If

        GridContas_AtualizarValores(iCont)
      End With
    Next
  End Sub

  Private Sub oCalculoFinanceiro_Desconto_Atualizado() Handles oCalculoFinanceiro_Desconto.Atualizado
    GridParcela_CalcularValor()
  End Sub

  Private Sub oCalculoFinanceiro_Juros_Atualizado() Handles oCalculoFinanceiro_Juros.Atualizado
    GridParcela_CalcularValor()
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If objGrid_Valor(grdParcela, const_GridParcela_SQ_MOVFINANCEIRAPARCELA, 0) > 0 Then
      If bVoucher Then
        FormRelatorioFinanceiro_Voucher(iSQ_VOUCHER, False)
      Else
        FormRelatorioFinanceiro_Recibo_Pagamento(objGrid_Valor(grdParcela, const_GridParcela_SQ_MOVFINANCEIRAPARCELA, 0), 0, 0)
      End If
    End If
  End Sub

  Private Sub psqPessoa_SelectedIndexChanged() Handles psqPessoa.SelectedIndexChanged
    If psqPessoa.ID_Pessoa = 0 Then
      cboConvenio.DataSource = Nothing
    Else
      ComboBox_Carregar(cboConvenio, enSql.Convenio_Ativo, New Object() {psqPessoa.ID_Pessoa})

      Dim sSqlText As String

      sSqlText = "SELECT ISNULL(PC_PROFISSIONAL_RETEMIMPOSTO, 0) FROM TB_PESSOA_EMPRESA WHERE ID_PESSOA = " & psqPessoa.ID_Pessoa
      dPcProfissionalRetemImposto = DBQuery_ValorUnico(sSqlText, 0)
    End If
  End Sub
End Class