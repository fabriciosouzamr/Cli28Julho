Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmLancaContasReceberPagar_Quitar
  Public Event RegerarConsulta()

  Const const_cFormaPagamento_Parcela_SQ_PAGAMENTO As Integer = 0
  Const const_cFormaPagamento_Parcela_SQ_MOVFINANCEIRAPARCELA As Integer = 1

  Const const_GridContas_SQ_MOVFINANCEIRAPARCELA As Integer = 0
  Const const_GridContas_ID_MOVFINANCEIRA As Integer = 1
  Const const_GridContas_PC_DESCONTO As Integer = 2
  Const const_GridContas_CodigoParcela As Integer = 3
  Const const_GridContas_ValorQuitando As Integer = 4
  Const const_GridContas_ValorRestante As Integer = 5
  Const const_GridContas_CodigoDocumento As Integer = 6
  Const const_GridContas_ContaCaixa As Integer = 7
  Const const_GridContas_Pessoa As Integer = 8
  Const const_GridContas_Descricao As Integer = 9
  Const const_GridContas_DataLancamento As Integer = 10
  Const const_GridContas_DataVencimento As Integer = 11
  Const const_GridContas_ValorParcela As Integer = 12
  Const const_GridContas_ValorDebito As Integer = 13
  Const const_GridContas_ValorDesconto As Integer = 14
  Const const_GridContas_ValorMulta As Integer = 15
  Const const_GridContas_ValorJuros As Integer = 16
  Const const_GridContas_ValorDescontoPagto As Integer = 17
  Const const_GridContas_ValorAcrescimoPagto As Integer = 18
  Const const_GridContas_JustificativaDescontoAcrescimo As Integer = 19
  Const const_GridContas_ValorImpostoRetidoFonte As Integer = 20
  Const const_GridContas_ValorTotalAPagar As Integer = 21
  Const const_GridContas_DiasAtraso As Integer = 22
  Const const_GridContas_Emitente As Integer = 23
  Const const_GridContas_BTN_Subir As Integer = 24
  Const const_GridContas_BTN_Descer As Integer = 25
  Const const_GridContas_ID_Pessoa As Integer = 26
  Const const_GridContas_ID_FORMAPAGAMENTO_PREFERENCIAL As Integer = 27
  Const const_GridContas_SQ_PAGAMENTO As Integer = 28
  Const const_GridContas_ID_CONTAFINANCEIRA As Integer = 29

  Public cSQ_MOVFINANCEIRAPARCELA As New Collection
  Public bPagamentoPorParcela As Boolean
  Public bGravacaoAutomatica As Boolean
  Public iTipoMovimentacao As Integer
  Public sTipoMovimentacao As String
  Public cID_PESSOA As New Collection

  Dim oDBContas As New UltraWinDataSource.UltraDataSource
  Dim iSQ_PAGAMENTO As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Gravar()

    cmdImprimir.Enabled = True
  End Sub

  Private Function Gravar()
    Dim bOk As Boolean

    If Math.Round(txtDesconto.Value, 2) > Math.Round(txtValorAtualizado.Value - txtValorPago.Value, 2) And txtDesconto.Value <> 0 Then
      FNC_Mensagem("O valor de descoBooleannto não pode ser maior que o valor atualizado menos o valor pago. R$ " & FormatCurrency(txtValorAtualizado.Value - txtValorPago.Value))
      GoTo Sair
    End If
    If txtValorPago.Value <= 0 Then
      FNC_Mensagem("Não foi informado nenhum pagamento ainda")
      GoTo Sair
    End If
    If Not IsDate(txtDataPagamento.Value) Then
      FNC_Mensagem("Informe a data do pagamento")
      GoTo Sair
    End If
    If (iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode) And
       Math.Round(txtValorFinal.Value, 2) < 0 Then
      FNC_Mensagem("Não é permitido pagar mais que o valor total das parcelas")
      GoTo Sair
    End If
    If objGrid_CalcularTotalColuna(grdContas, const_GridContas_ValorQuitando) <> txtValorPago.Value Then
      FNC_Mensagem("A soma do valor quitando das contas não pode ser diferente do valor pago")
      GoTo Sair
    End If
    If Math.Abs(txtValorFinal.Value) < 0 And psqPessoalCredito.ID_Pessoa = 0 Then
      FNC_Mensagem("É preciso informar a pessoa que irá receber o crédito de " & FormatCurrency(Math.Abs(txtValorFinal.Value)))
      GoTo Sair
    End If

    Dim sSqlText As String
    Dim dDesconto As Double

    sSqlText = ""

    'Validação das contas
    For iCont = 0 To grdContas.Rows.Count - 1
      With grdContas.Rows(iCont)
        If (FNC_NVL(.Cells(const_GridContas_ValorDescontoPagto).Value, 0) <> 0 Or FNC_NVL(.Cells(const_GridContas_ValorAcrescimoPagto).Value, 0) <> 0) Then
          If FNC_NVL(.Cells(const_GridContas_ValorRestante).Value, 0) <> 0 Then
            FNC_Mensagem("Só é permitido lançamento desconto e acréscimo realizado no pagamento no momento da liquidação da dívida")
            GoTo Sair
          End If
          If FNC_CampoNulo(.Cells(const_GridContas_JustificativaDescontoAcrescimo).Value) Then
            FNC_Mensagem("É preciso justificar valor de desconto e acréscimo realizado no pagamento")
            GoTo Sair
          End If
        End If
      End With
    Next

    'Validação dos pagamentos
    If Not oLancaContasReceberPagar_Quitar.Validar() Then GoTo Sair

    Try
      DBUsarTransacao = True

      For iCont = 0 To grdContas.Rows.Count - 1
        With grdContas.Rows(iCont)
          If iSQ_PAGAMENTO = 0 Or Not FNC_CampoNulo(.Cells(const_GridContas_ID_FORMAPAGAMENTO_PREFERENCIAL).Value) Then
            sSqlText = DBMontar_SP("SP_PAGAMENTO_CAD", False, "@SQ_PAGAMENTO OUT",
                                                              "@ID_EMPRESA",
                                                              "@ID_OPT_TIPOPAGAMENTO",
                                                              "@DT_LANCAMENTO",
                                                              "@DT_PAGAMENTO")

            If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PAGAMENTO", 0, , ParameterDirection.InputOutput),
                                        DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                        DBParametro_Montar("ID_OPT_TIPOPAGAMENTO", enOpcoes.TipoPagamento_Pagamento.GetHashCode),
                                        DBParametro_Montar("DT_LANCAMENTO", Nothing),
                                        DBParametro_Montar("DT_PAGAMENTO", txtDataPagamento.Value)) Then GoTo Erro

            If DBTeveRetorno() Then
              iSQ_PAGAMENTO = DBRetorno(1)
            End If
          End If

          sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_PGT", False, "@SQ_MOVFINANCEIRAPARCELA",
                                                                       "@ID_PAGAMENTO",
                                                                       "@ID_APROVADOR_DESCONTO",
                                                                       "@VL_PAGAMENTO",
                                                                       "@VL_JUROS",
                                                                       "@VL_MULTA",
                                                                       "@VL_DESCONTO",
                                                                       "@VL_DESCONTO_PAGTO",
                                                                       "@VL_ACRESCIMO_PAGTO",
                                                                       "@VL_JUROS_PAGTO",
                                                                       "@VL_IMPOSTORETIDO",
                                                                       "@CM_JUSTIFICATICA_DESCONTO_ACRESCIMO",
                                                                       "@DT_PAGAMENTO",
                                                                       "@ID_USUARIO")

          .Cells(const_GridContas_SQ_PAGAMENTO).Value = iSQ_PAGAMENTO

          If FNC_NVL(.Cells(const_GridContas_ValorDesconto).Value, 0) > 0 Then
            dDesconto = .Cells(const_GridContas_ValorQuitando).Value / (.Cells(const_GridContas_ValorParcela).Value * (1 - .Cells(const_GridContas_PC_DESCONTO).Value))
            dDesconto = dDesconto * FNC_Porcentagem(.Cells(const_GridContas_ValorParcela).Value, .Cells(const_GridContas_PC_DESCONTO).Value)
          End If

          If .Cells(const_GridContas_ValorQuitando).Value > 0 Then
            If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA", FNC_NVL(.Cells(const_GridContas_SQ_MOVFINANCEIRAPARCELA).Value, 0)),
                                        DBParametro_Montar("ID_PAGAMENTO", iSQ_PAGAMENTO),
                                        DBParametro_Montar("ID_APROVADOR_DESCONTO", Nothing),
                                        DBParametro_Montar("VL_PAGAMENTO", FNC_ConvValorFormatoAmericano(.Cells(const_GridContas_ValorQuitando).Value)),
                                        DBParametro_Montar("VL_JUROS", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(const_GridContas_ValorJuros).Value, "0"))),
                                        DBParametro_Montar("VL_MULTA", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(const_GridContas_ValorMulta).Value, "0"))),
                                        DBParametro_Montar("VL_DESCONTO", Math.Round(dDesconto, 2)),
                                        DBParametro_Montar("VL_DESCONTO_PAGTO", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(const_GridContas_ValorDescontoPagto).Value, "0"))),
                                        DBParametro_Montar("VL_ACRESCIMO_PAGTO", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(const_GridContas_ValorAcrescimoPagto).Value, "0"))),
                                        DBParametro_Montar("VL_JUROS_PAGTO", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(const_GridContas_ValorJuros).Value, "0"))),
                                        DBParametro_Montar("VL_IMPOSTORETIDO", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(const_GridContas_ValorImpostoRetidoFonte).Value, "0"))),
                                        DBParametro_Montar("CM_JUSTIFICATICA_DESCONTO_ACRESCIMO", .Cells(const_GridContas_JustificativaDescontoAcrescimo).Value,,, const_BancoDados_TamanhoComentario),
                                        DBParametro_Montar("DT_PAGAMENTO", txtDataPagamento.DateTime.Date, SqlDbType.Date),
                                        DBParametro_Montar("ID_USUARIO", iID_USUARIO)) Then GoTo Erro
          End If

          FormMovimentacaoFinanceira_Status_Atualizar(.Cells(const_GridContas_ID_MOVFINANCEIRA).Value)
        End With
      Next

      oLancaContasReceberPagar_Quitar.iSQ_PAGAMENTO = iSQ_PAGAMENTO
      If Not oLancaContasReceberPagar_Quitar.Gravar() Then GoTo Erro

      'For iCont = 0 To grdContas.Rows.Count - 1
      '  With grdContas.Rows(iCont)
      '    'Quitação/Compensão das parcelas em dinheiro
      '    sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_QUITAR_CAD", False, "@ID_MOVFINANCEIRA", "@ID_USUARIO")
      '    DBExecutar(sSqlText,
      '               DBParametro_Montar("ID_MOVFINANCEIRA", FNC_NVL(.Cells(const_GridContas_ID_MOVFINANCEIRA).Value, 0)),
      '               DBParametro_Montar("ID_USUARIO", iID_USUARIO))

      '    FormMovimentacaoFinanceira_Status_Atualizar(FNC_NVL(.Cells(const_GridContas_ID_MOVFINANCEIRA).Value, 0))
      '  End With
      'Next

      If txtValorImpostos.Value > 0 Then
        sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_PGT_IMPOSTORETIDO", False, "@ID_EMPRESA",
                                                                                   "@ID_PAGAMENTO",
                                                                                   "@VL_IMPOSTORETIDO",
                                                                                   "@ID_USUARIO")
        DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                             DBParametro_Montar("ID_PAGAMENTO", iSQ_PAGAMENTO),
                             DBParametro_Montar("VL_IMPOSTORETIDO", txtValorImpostos.Value),
                             DBParametro_Montar("ID_USUARIO", iID_USUARIO))
      End If

      DBExecutarTransacao()

      RaiseEvent RegerarConsulta()

      If bGravacaoAutomatica Then
        Close()
      Else
        FNC_Mensagem("Pagamento(s) lançado(s)")

        cmdGravar.Enabled = False
      End If
    Catch ex As Exception
      DBUsarTransacao = False
      FNC_Mensagem(ex.Message)
    End Try

    bOk = True

    GoTo Sair

Erro:
    DBUsarTransacao = False

Sair:
    Return bOk
  End Function

  Private Sub frmLancaContasReceberPagar_Quitar_Load(sender As Object, e As EventArgs) Handles Me.Load
    Dim sSqlText As String

    If Trim(sTipoMovimentacao) <> "" Then
      Me.Text = Me.Text & " (" & sTipoMovimentacao & ")"
    End If

    If bGravacaoAutomatica Then
      txtDataPagamento.Value = Now.Date()
    Else
      txtDataPagamento.Value = Nothing
    End If

    cmdImprimir.Enabled = False

    objGrid_Inicializar(grdContas, , oDBContas, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdContas, "SQ_MOVFINANCEIRAPARCELA", 0)
    objGrid_Coluna_Add(grdContas, "ID_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdContas, "PC_DESCONTO", 0)
    objGrid_Coluna_Add(grdContas, "Cód. Parcela", 110)
    objGrid_Coluna_Add(grdContas, "Valor Quitando", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Valor Restante", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Cód. Documento", 110)
    objGrid_Coluna_Add(grdContas, "Conta Caixa", 200)
    objGrid_Coluna_Add(grdContas, "Pessoa", 300)
    objGrid_Coluna_Add(grdContas, "Descrição", 300)
    objGrid_Coluna_Add(grdContas, "Data Lançamento", 100, , , ColumnStyle.Date)
    objGrid_Coluna_Add(grdContas, "Data Vencimento", 100, , , ColumnStyle.Date)
    objGrid_Coluna_Add(grdContas, "Valor Parcela", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Valor Débito", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Valor Desconto", 100, , , ColumnStyle.Currency, , const_Formato_Valor, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Valor Multa", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Valor Juros", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Valor Desconto Pagto", 150, , True, ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Valor Acréscimo Pagto", 150, , True, ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Justificativa Desc/Acrés", 200, , True)
    objGrid_Coluna_Add(grdContas, "Valor Retido Fonte", 150, , True, ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Valor Total a Pagar", 150, , , ColumnStyle.Currency, , const_Formato_Valor_4casas, , , , , , HAlign.Right)
    objGrid_Coluna_Add(grdContas, "Dias Atraso", 150)
    objGrid_Coluna_Add(grdContas, "Emitente", 300)
    objGrid_Coluna_Add(grdContas, "Subir", 50, , True, ColumnStyle.Button)
    objGrid_Coluna_Add(grdContas, "Descer", 50, , True, ColumnStyle.Button)
    objGrid_Coluna_Add(grdContas, "Pessoa", 0)
    objGrid_Coluna_Add(grdContas, "ID_FORMAPAGAMENTO_PREFERENCIAL ", 0)
    objGrid_Coluna_Add(grdContas, "SQ_PAGAMENTO", 0)
    objGrid_Coluna_Add(grdContas, "ID_CONTAFINANCEIRA", 0)
    objGrid_Configuracao_Carregar(grdContas, Me.Name)

    oLancaContasReceberPagar_Quitar.grdContas = grdContas
    oLancaContasReceberPagar_Quitar.GrdContas_SQ_MOVFINANCEIRAPARCELA = const_GridContas_SQ_MOVFINANCEIRAPARCELA
    oLancaContasReceberPagar_Quitar.GrdContas_SQ_PAGAMENTO = const_GridContas_SQ_PAGAMENTO
    oLancaContasReceberPagar_Quitar.GrdContas_ValorQuitando = const_GridContas_ValorQuitando
    oLancaContasReceberPagar_Quitar.GrdContas_ValorDescontoPagto = const_GridContas_ValorDescontoPagto
    oLancaContasReceberPagar_Quitar.GrdContas_ValorAcrescimoPagto = const_GridContas_ValorAcrescimoPagto
    oLancaContasReceberPagar_Quitar.GrdContas_JustificativaDescontoAcrescimo = const_GridContas_JustificativaDescontoAcrescimo
    oLancaContasReceberPagar_Quitar.GrdContas_ValorRestante = const_GridContas_ValorRestante
    oLancaContasReceberPagar_Quitar.GrdContas_ID_FORMAPAGAMENTO_PREFERENCIAL = const_GridContas_ID_FORMAPAGAMENTO_PREFERENCIAL

    oLancaContasReceberPagar_Quitar.bPagamentoPorParcela = bPagamentoPorParcela
    oLancaContasReceberPagar_Quitar.bGravacaoAutomatica = bGravacaoAutomatica
    oLancaContasReceberPagar_Quitar.iTipoMovimentacao = iTipoMovimentacao
    oLancaContasReceberPagar_Quitar.sTipoMovimentacao = sTipoMovimentacao
    oLancaContasReceberPagar_Quitar.cID_PESSOA = cID_PESSOA
    oLancaContasReceberPagar_Quitar.iSQ_PESSOA_CREDITO = psqPessoalCredito.ID_Pessoa
    oLancaContasReceberPagar_Quitar.dPagamento = txtDataPagamento.DateTime
    oLancaContasReceberPagar_Quitar.dValorFinal = txtValorFinal.Value
    oLancaContasReceberPagar_Quitar.Formatar()

    sSqlText = "SELECT MFP.SQ_MOVFINANCEIRAPARCELA," &
                      "MFP.ID_MOVFINANCEIRA," &
                      "MFP.PC_DESCONTO," &
                      "MFP.NO_PESSOA," &
                      "MFP.CD_MOVFINANCEIRA_PARCELA," &
                      "MFP.CD_DOCUMENTO," &
                      "ISNULL(MFP.NO_CONTAFINANCEIRA_CREDITO, MFP.NO_CONTAFINANCEIRA_DEBITO) NO_CONTAFINANCEIRA," &
                      "MFP.DS_MOVFINANCEIRA," &
                      "MFP.DT_MOVIMENTACAO," &
                      "MFP.DT_VENCIMENTO," &
                      "MFP.VL_PARCELA," &
                      "ROUND(MFP.VL_DEBITO - MFP.VL_CALC_DESCONTO - MFP.VL_CALC_MULTA + MFP.VL_CALC_JUROS, 2) + ISNULL(MFP.VL_IMPOSTORETIDO, 0)," &
                      "ROUND(MFP.VL_DEBITO - MFP.VL_CALC_DESCONTO - MFP.VL_CALC_MULTA + MFP.VL_CALC_JUROS, 2) + ISNULL(MFP.VL_IMPOSTORETIDO, 0)," &
                      "ROUND(MFP.VL_DEBITO - MFP.VL_CALC_DESCONTO - MFP.VL_CALC_MULTA + MFP.VL_CALC_JUROS, 2) + ISNULL(MFP.VL_IMPOSTORETIDO, 0)," &
                      "MFP.VL_CALC_DESCONTO," &
                      "MFP.VL_CALC_MULTA," &
                      "MFP.VL_CALC_JUROS," &
                      "MFP.QT_DIAS_ATRASO," &
                      "MFP.DS_EMITENTE," &
                      "MFP.ID_PESSOA," &
                      "MFP.ID_FORMAPAGAMENTO_PREFERENCIAL," &
                      "MFP.ID_CONTAFINANCEIRA_CREDITO," &
                      "IIF(ISNULL(MFP.VL_IMPOSTORETIDO, 0) = 0, ROUND(ISNULL(PSEMP.PC_PROFISSIONAL_RETEMIMPOSTO, 0) * MFP.VL_DEBITO / 100, 2), MFP.VL_IMPOSTORETIDO)" &
               " FROM VW_MOVFINANCEIRAPARCELA MFP" &
                " INNER JOIN TB_PESSOA_EMPRESA PSEMP ON PSEMP.ID_PESSOA = MFP.ID_PESSOA" &
                                                  " AND PSEMP.ID_EMPRESA = 2" &
               " WHERE MFP.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND MFP.SQ_MOVFINANCEIRAPARCELA IN (" & FNC_Collection_Para_Lista(cSQ_MOVFINANCEIRAPARCELA, ",") & ")" &
                 " AND MFP.CD_OPT_STATUS IN ('" & const_Opcao_MovFinanceira_Aberto & "')" &
               " ORDER BY MFP.NO_PESSOA," &
                         "MFP.CD_MOVFINANCEIRA_PARCELA"
    objGrid_Carregar(grdContas, sSqlText, New Integer() {const_GridContas_SQ_MOVFINANCEIRAPARCELA,
                                                         const_GridContas_ID_MOVFINANCEIRA,
                                                         const_GridContas_PC_DESCONTO,
                                                         const_GridContas_Pessoa,
                                                         const_GridContas_CodigoParcela,
                                                         const_GridContas_CodigoDocumento,
                                                         const_GridContas_ContaCaixa,
                                                         const_GridContas_Descricao,
                                                         const_GridContas_DataLancamento,
                                                         const_GridContas_DataVencimento,
                                                         const_GridContas_ValorParcela,
                                                         const_GridContas_ValorDebito,
                                                         const_GridContas_ValorRestante,
                                                         const_GridContas_ValorTotalAPagar,
                                                         const_GridContas_ValorDesconto,
                                                         const_GridContas_ValorMulta,
                                                         const_GridContas_ValorJuros,
                                                         const_GridContas_DiasAtraso,
                                                         const_GridContas_Emitente,
                                                         const_GridContas_ID_Pessoa,
                                                         const_GridContas_ID_FORMAPAGAMENTO_PREFERENCIAL,
                                                         const_GridContas_ID_CONTAFINANCEIRA,
                                                         const_GridContas_ValorImpostoRetidoFonte})

    CalcularValores()

    objGrid_ExibirTotal(grdContas, New Integer() {const_GridContas_ValorQuitando,
                                                  const_GridContas_ValorRestante,
                                                  const_GridContas_ValorTotalAPagar,
                                                  const_GridContas_ValorImpostoRetidoFonte,
                                                  const_GridContas_ValorParcela,
                                                  const_GridContas_ValorDebito,
                                                  const_GridContas_ValorDesconto,
                                                  const_GridContas_ValorMulta,
                                                  const_GridContas_ValorJuros,
                                                  const_GridContas_ValorAcrescimoPagto,
                                                  const_GridContas_ValorDescontoPagto})

    psqPessoalCredito.Visible = (iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode)

    PessoaCredito_Validar()

    oLancaContasReceberPagar_Quitar.Formatar()

    FormaPagamento_CarregarPreferencial()

    If bGravacaoAutomatica Then
      If Gravar() Then
        Close()
      End If
    End If
  End Sub

  Private Sub CalcularValores()
    txtValorAtualizado.Value = objGrid_CalcularTotalColuna(grdContas, const_GridContas_ValorDebito)
    txtDesconto.Value = objGrid_CalcularTotalColuna(grdContas, const_GridContas_ValorDescontoPagto)
    txtValorImpostos.Value = objGrid_CalcularTotalColuna(grdContas, const_GridContas_ValorImpostoRetidoFonte)
  End Sub

  Private Sub grdContas_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdContas.AfterCellUpdate
    Select Case e.Cell.Column.Index
      Case const_GridContas_ValorQuitando, const_GridContas_ValorDescontoPagto, const_GridContas_ValorAcrescimoPagto, const_GridContas_ValorImpostoRetidoFonte
        GridContas_AtualizarValores(e.Cell.Row.Index)
        CalcularValores()
    End Select
  End Sub

  Private Sub GridContas_AtualizarValores(iLinha)
    With grdContas.Rows(iLinha)
      .Cells(const_GridContas_ValorTotalAPagar).Value = (CDbl(FNC_NVL(.Cells(const_GridContas_ValorDebito).Value, 0)) +
                                                         CDbl(FNC_NVL(.Cells(const_GridContas_ValorMulta).Value, 0)) +
                                                         CDbl(FNC_NVL(.Cells(const_GridContas_ValorJuros).Value, 0)) +
                                                         CDbl(FNC_NVL(.Cells(const_GridContas_ValorAcrescimoPagto).Value, 0)) -
                                                         CDbl(FNC_NVL(.Cells(const_GridContas_ValorDesconto).Value, 0)) -
                                                         CDbl(FNC_NVL(.Cells(const_GridContas_ValorDescontoPagto).Value, 0)))
      .Cells(const_GridContas_ValorRestante).Value = FNC_NVL(.Cells(const_GridContas_ValorTotalAPagar).Value, 0) -
                                                     FNC_NVL(.Cells(const_GridContas_ValorQuitando).Value, 0)
    End With
  End Sub

  Private Sub grdContas_ClickCellButton(sender As Object, e As CellEventArgs) Handles grdContas.ClickCellButton
    Select Case e.Cell.Column.Index
      Case const_GridContas_BTN_Subir
        If e.Cell.Row.Index > 0 Then
          grdContas.Rows.Move(e.Cell.Row, e.Cell.Row.Index - 1)
          oLancaContasReceberPagar_Quitar.CalcularBaixarParcelas(grdContas,
                                                                 const_GridContas_ValorQuitando,
                                                                 const_GridContas_ValorTotalAPagar,
                                                                 const_GridContas_ValorRestante)
        End If
      Case const_GridContas_BTN_Descer
        If e.Cell.Row.Index < grdContas.Rows.Count - 1 Then
          grdContas.Rows.Move(e.Cell.Row, e.Cell.Row.Index + 1)
          oLancaContasReceberPagar_Quitar.CalcularBaixarParcelas(grdContas,
                                                                 const_GridContas_ValorQuitando,
                                                                 const_GridContas_ValorTotalAPagar,
                                                                 const_GridContas_ValorRestante)
        End If
    End Select
  End Sub

  Private Sub txtDesconto_ValueChanged(sender As Object, e As EventArgs) Handles txtDesconto.ValueChanged
    CalculaValorFinal()
  End Sub

  Private Sub CalculaValorFinal()
    txtValorFinal.Value = txtValorAtualizado.Value - txtValorPago.Value - txtDesconto.Value - txtValorImpostos.Value
  End Sub

  Private Sub txtValorPago_ValueChanged(sender As Object, e As EventArgs) Handles txtValorPago.ValueChanged
    CalculaValorFinal()
    oLancaContasReceberPagar_Quitar.CalcularBaixarParcelas(grdContas,
                                                           const_GridContas_ValorQuitando,
                                                           const_GridContas_ValorTotalAPagar,
                                                           const_GridContas_ValorRestante)
  End Sub

  Private Sub txtValorAtualizado_ValueChanged(sender As Object, e As EventArgs) Handles txtValorAtualizado.ValueChanged
    CalculaValorFinal()
  End Sub

  Private Sub txtValorFinal_ValueChanged(sender As Object, e As EventArgs) Handles txtValorFinal.ValueChanged
    oLancaContasReceberPagar_Quitar.dValorFinal = txtValorFinal.Value
    PessoaCredito_Validar()
  End Sub

  Private Sub PessoaCredito_Validar()
    psqPessoalCredito.Visible = (txtValorFinal.Value < 0) And (iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode())

    If psqPessoalCredito.Visible Then
      If psqPessoalCredito.ID_Pessoa = 0 Then
        psqPessoalCredito.ID_Pessoa = objGrid_Valor(grdContas, const_GridContas_ID_Pessoa, 0)
      End If
    Else
      psqPessoalCredito.ID_Pessoa = 0
    End If
  End Sub

  Private Sub txtDataPagamento_ValueChanged(sender As Object, e As EventArgs) Handles txtDataPagamento.ValueChanged
    oLancaContasReceberPagar_Quitar.dPagamento = txtDataPagamento.DateTime
    TratarDataPagamento()
  End Sub

  Private Sub TratarDataPagamento()
    Dim iCont As Integer

    For iCont = 0 To grdContas.Rows.Count - 1
      With grdContas.Rows(iCont)
        .Cells(const_GridContas_ValorDesconto).Value = FormMovimentacaoFinanceiraParcela_CalculoFinanceiro(.Cells(const_GridContas_SQ_MOVFINANCEIRAPARCELA).Value,
                                                                                                           txtDataPagamento.Value,
                                                                                                           const_CalculoFinanceiro_DESCONTO)
        .Cells(const_GridContas_ValorJuros).Value = FormMovimentacaoFinanceiraParcela_CalculoFinanceiro(.Cells(const_GridContas_SQ_MOVFINANCEIRAPARCELA).Value,
                                                                                                        txtDataPagamento.Value,
                                                                                                        const_CalculoFinanceiro_JUROS)
        GridContas_AtualizarValores(iCont)
      End With
    Next

    CalcularValores()
  End Sub

  Private Sub frmLancaContasReceberPagar_Quitar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdContas, Me.Name)
    oLancaContasReceberPagar_Quitar.Finalizar()
  End Sub

  Private Sub FormaPagamento_CarregarPreferencial()
    Dim iCont As Integer = 0

    For iCont = 0 To grdContas.Rows.Count - 1
      If Not FNC_CampoNulo(objGrid_Valor(grdContas, const_GridContas_ID_FORMAPAGAMENTO_PREFERENCIAL, iCont)) Then
        oLancaContasReceberPagar_Quitar.Grid_Adicionar(objGrid_Valor(grdContas, const_GridContas_ID_CONTAFINANCEIRA, iCont, 0),
                                                       objGrid_Valor(grdContas, const_GridContas_ID_FORMAPAGAMENTO_PREFERENCIAL, iCont, 0),
                                                       objGrid_Valor(grdContas, const_GridContas_SQ_MOVFINANCEIRAPARCELA, iCont, 0),
                                                       Val(objGrid_Valor(grdContas, const_GridContas_ValorDebito, iCont, 0)))
      End If
    Next

    oLancaContasReceberPagar_Quitar.CalcularValorPago()
  End Sub

  Private Sub psqPessoalCredito_SelectedIndexChanged() Handles psqPessoalCredito.SelectedIndexChanged
    oLancaContasReceberPagar_Quitar.iSQ_PESSOA_CREDITO = psqPessoalCredito.ID_Pessoa
  End Sub

  Private Sub oLancaContasReceberPagar_Quitar_ValorPago() Handles oLancaContasReceberPagar_Quitar.ValorPago
    txtValorPago.Value = oLancaContasReceberPagar_Quitar.dValorPago
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    FormRelatorioFinanceiro_Recibo_Pagamento(objGrid_Valor(grdContas, const_GridContas_SQ_MOVFINANCEIRAPARCELA), 0, iSQ_PAGAMENTO)
  End Sub

  Private Sub txtValorImpostos_ValueChanged(sender As Object, e As EventArgs) Handles txtValorImpostos.ValueChanged
    CalculaValorFinal()
  End Sub
End Class