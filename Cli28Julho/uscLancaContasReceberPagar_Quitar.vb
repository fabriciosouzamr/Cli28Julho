Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class uscLancaContasReceberPagar_Quitar
  Public Event ValorPago()

  Const const_GridFormaPagamento_FormaPagamento As Integer = 0
  Const const_GridFormaPagamento_ValorPago As Integer = 1
  Const const_GridFormaPagamento_ValorSaldo As Integer = 2
  Const const_GridFormaPagamento_ContaFinanceira As Integer = 3
  Const const_GridFormaPagamento_CodigoDocumento As Integer = 4
  Const const_GridFormaPagamento_Emitente As Integer = 5
  Const const_GridFormaPagamento_BTN_Emitente As Integer = 6
  Const const_GridFormaPagamento_DtDocumento As Integer = 7
  Const const_GridFormaPagamento_Banco As Integer = 8
  Const const_GridFormaPagamento_NAgencia As Integer = 9
  Const const_GridFormaPagamento_NConta As Integer = 10
  Const const_GridFormaPagamento_NDigConta As Integer = 11
  Const const_GridFormaPagamento_DescricaoDocumento As Integer = 12
  Const const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas As Integer = 13
  Const const_GridFormaPagamento_IC_COMPENSAR As Integer = 14
  Const const_GridFormaPagamento_ID_TIPO_DOCUMENTO As Integer = 15
  Const const_GridFormaPagamento_ID_EMITENTE As Integer = 16
  Const const_GridFormaPagamento_IC_CADASTRAR_DOCUMENTO As Integer = 17
  Const const_GridFormaPagamento_ID_PAGAMENTOITEM_DOCFINAN As Integer = 18
  Const const_GridFormaPagamento_SQ_MOVFINANCEIRAPARCELA As Integer = 19

  Public grdContas As UltraWinGrid.UltraGrid
  Public GrdContas_SQ_MOVFINANCEIRAPARCELA As Integer
  Public GrdContas_SQ_PAGAMENTO As Integer
  Public GrdContas_ValorQuitando As Integer
  Public GrdContas_ValorDescontoPagto As Integer
  Public GrdContas_ValorAcrescimoPagto As Integer
  Public GrdContas_JustificativaDescontoAcrescimo As Integer
  Public GrdContas_ValorRestante As Integer
  Public GrdContas_ID_FORMAPAGAMENTO_PREFERENCIAL As Integer

  Public bPagamentoPorParcela As Boolean
  Public bGravacaoAutomatica As Boolean
  Public iTipoMovimentacao As Integer
  Public sTipoMovimentacao As String
  Public cID_PESSOA As New Collection
  Public iSQ_PAGAMENTO As Integer
  Public iSQ_PESSOA_CREDITO As Integer
  Public dPagamento As DateTime
  Public dValorFinal As Double
  Public dValorPago As Double
  Public dDataPagamento As Date

  Dim cFormaPagamento As Collection
  Dim oDBFormaPagamento As New UltraWinDataSource.UltraDataSource
  Dim oFormaPagamento As cFormaPagamento

  Public Function Validar() As Boolean
    Dim bOk As Boolean = False

    For iCont_01 = 0 To grdFormaPagamento.Rows.Count - 1
      With grdFormaPagamento.Rows(iCont_01)
        oFormaPagamento = FNC_FormaPagamento_Collection(FNC_NVL(.Cells(const_GridFormaPagamento_FormaPagamento).Value, 0), cFormaPagamento)

        'Se existem pagamento com saldo total livre
        If .Cells(const_GridFormaPagamento_ValorPago).Value = .Cells(const_GridFormaPagamento_ValorSaldo).Value Then
          FNC_Mensagem("Exite(m) forma(s) de pagamento lançada(s) a mais, para quitar as contas informadas, por isso é preciso excluí-la(s).")
          GoTo Sair
        End If
      End With

      If FNC_NVL(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_ContaFinanceira).Value, 0) = 0 Then
        FNC_Mensagem("Selecione a conta financeira")
        GoTo Sair
      End If

      'Valida saldo de crédito pessoal usado
      If grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_FormaPagamento).Value = const_FormaPagamento_CreditoPessoa Then
        With grdFormaPagamento.Rows(iCont_01)
          'Valida se foi informado a pessoa para o crédito pessoa
          If FNC_CampoNulo(.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value) Then
            FNC_Mensagem("Não foi informado a pessoa ref. ao crédito de pessoa")
            GoTo Sair
          End If
          If objGrid_CalcularTotalColuna(grdFormaPagamento,
                                         const_GridFormaPagamento_ValorPago,
                                         grdTipoCalculoTotal.SomarValor,
                                         New Object() {const_GridFormaPagamento_FormaPagamento, .Cells(const_GridFormaPagamento_FormaPagamento).Value,
                                                       const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas, .Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value}) >
             FNC_Busca_Pessoa_Empresa_Credito(.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value) Then
            FNC_Mensagem("O valor total informado para crédito de pessoa é maior que o valor que " & .Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Text & " possui.")
            GoTo Sair
          End If
        End With
      ElseIf grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_FormaPagamento).Value = const_FormaPagamento_CreditoCedido Then
        With grdFormaPagamento.Rows(iCont_01)
          If FNC_CampoNulo(.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value) Then
            FNC_Mensagem("Não foi informado a conta a pagar a ser vinculada")
            GoTo Sair
          End If
          If objGrid_CalcularTotalColuna(grdFormaPagamento,
                                         const_GridFormaPagamento_ValorPago,
                                         grdTipoCalculoTotal.SomarValor,
                                         New Object() {const_GridFormaPagamento_FormaPagamento, .Cells(const_GridFormaPagamento_FormaPagamento).Value,
                                                       const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas, .Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value}) >
             FNC_Busca_MovFinanceiraParcela_ValorDebito(.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value) Then
            FNC_Mensagem("O valor total informado é maior que o valor do débito da movimentação " & .Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Text & ".")
            GoTo Sair
          End If
        End With
      Else
        'Valida se é necessário cadastrar o documento financeiro - Início
        With oFormaPagamento
          grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_IC_COMPENSAR).Value = IIf(.COMPENSA, "S", "N")
          grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_ID_TIPO_DOCUMENTO).Value = .ID_TIPO_DOCUMENTO
          grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_IC_CADASTRAR_DOCUMENTO).Value = IIf(.CADASTRAR_DOCUMENTO, "S", "N")

          If .ID_OPT_DOCUMENTOCADASTRADO = enOpcoes.TipoDocumentoFinanceiroCadastrado_EmitidoTerceiros Then
            If FNC_CampoNulo(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value) Then
              FNC_Mensagem("Selecione o documento financeiro de terceiro a ser usado")
              GoTo Sair
            End If
          End If
          If .CADASTRAR_CONTABANCARIA And
             (FNC_NVL(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_NAgencia).Value, 0) <= 0 Or
             FNC_NVL(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_NConta).Value, 0) <= 0 Or
             Trim(FNC_NVL(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_NDigConta).Value, "")) = "") Then
            FNC_Mensagem("É preciso informar os dados da conta bancária desse documento")
            GoTo Sair
          End If
          If .ID_OPT_INSTITUICAO_GERADORA = enOpcoes.TipoInstituicao_Bancaria And
             FNC_CampoNulo(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_Banco).Value) Then
            FNC_Mensagem("É preciso selecionar o banco gerador desse documento")
            GoTo Sair
          End If
          If .CADASTRAR_DOCUMENTO Or .CADASTRAR_CONTABANCARIA Then
            If FNC_NVL(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_CodigoDocumento).Value, "") = "" Then
              FNC_Mensagem("É preciso informar o código do documento")
              GoTo Sair
            End If
            If FNC_NVL(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_Emitente).Value, "") = "" Then
              FNC_Mensagem("É preciso informar o emitente do documento")
              GoTo Sair
            End If
            If Not IsDate(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_DtDocumento).Value) Then
              FNC_Mensagem("É preciso informar a data do documento")
              GoTo Sair
            End If
          End If
        End With
        'Valida se é necessário cadastrar o documento financeiro - Fim
      End If
    Next

    bOk = True

Sair:
    Return bOk
  End Function

  Public Function Gravar() As Boolean
    Dim iID_PESSOA_CREDITO As Integer
    Dim iID_MOVFINANCEIRAPARCELA_ENCONTROCONTAS As Integer
    Dim eID_OPT_STATUS As enOpcoes = enOpcoes.StatusPagamentoItem_Quitado
    Dim iSQ_PAGAMENTOITEM As Integer
    Dim iSQ_DOCUMENTOFINANCEIRO As Integer

    Dim sSqlText As String
    Dim bOk As Boolean = False

    Dim sMsg As String = ""

    iID_PESSOA_CREDITO = 0
    iID_MOVFINANCEIRAPARCELA_ENCONTROCONTAS = 0
    iSQ_DOCUMENTOFINANCEIRO = 0

    If dValorPago <= 0 Then
      sMsg = "Não foi informado nenhum pagamento ainda"
      GoTo Sair
    End If
    If Not IsDate(dDataPagamento) Then
      sMsg = "Informe a data do pagamento"
      GoTo Sair
    End If
    If (iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode) And
       Math.Round(dValorFinal, 2) < 0 Then
      sMsg = "Não é permitido pagar mais que o valor total das parcelas"
      GoTo Sair
    End If
    If objGrid_CalcularTotalColuna(grdContas, GrdContas_ValorQuitando) <> dValorPago Then
      sMsg = "A soma do valor quitando das contas não pode ser diferente do valor pago"
      GoTo Sair
    End If
    If Math.Abs(dValorFinal) < 0 And iSQ_PESSOA_CREDITO = 0 Then
      sMsg = "É preciso informar a pessoa que irá receber o crédito de " & FormatCurrency(Math.Abs(dValorFinal))
      GoTo Sair
    End If

    sSqlText = ""

    'Validação das contas
    For iCont = 0 To grdContas.Rows.Count - 1
      With grdContas.Rows(iCont)
        If (FNC_NVL(.Cells(GrdContas_ValorDescontoPagto).Value, 0) <> 0 Or FNC_NVL(.Cells(GrdContas_ValorAcrescimoPagto).Value, 0) <> 0) Then
          If FNC_NVL(.Cells(GrdContas_ValorRestante).Value, 0) <> 0 Then
            sMsg = "Só é permitido lançamento desconto e acréscimo realizado no pagamento no momento da liquidação da dívida"
            GoTo Sair
          End If
          If FNC_CampoNulo(.Cells(GrdContas_JustificativaDescontoAcrescimo).Value) Then
            sMsg = "É preciso justificar valor de desconto e acréscimo realizado no pagamento"
            GoTo Sair
          End If
        End If
      End With
    Next

    For iCont_01 = 0 To grdFormaPagamento.Rows.Count - 1
      iSQ_DOCUMENTOFINANCEIRO = 0

      With grdFormaPagamento.Rows(iCont_01)
        If FNC_NVL(.Cells(const_GridFormaPagamento_SQ_MOVFINANCEIRAPARCELA).Value, 0) > 0 Then
          For iCont_02 = 0 To grdContas.Rows.Count - 1
            If FNC_NVL(.Cells(const_GridFormaPagamento_SQ_MOVFINANCEIRAPARCELA).Value, 0) =
               grdContas.Rows(iCont_02).Cells(GrdContas_SQ_MOVFINANCEIRAPARCELA).Value Then
              iSQ_PAGAMENTO = grdContas.Rows(iCont_02).Cells(GrdContas_SQ_PAGAMENTO).Value
              Exit For
            End If
          Next
        End If

        If FNC_NVL(.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value, 0) = 0 Then
          If FNC_NVL(.Cells(const_GridFormaPagamento_IC_CADASTRAR_DOCUMENTO).Value, "N") = "S" Then
            FormCadastroDocumentoFinanceiro_Gravar(iSQ_DOCUMENTOFINANCEIRO,
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_ID_TIPO_DOCUMENTO).Value, 0),
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_Banco).Value, 0),
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_ID_EMITENTE).Value, 0),
                                                   CDate(.Cells(const_GridFormaPagamento_DtDocumento).Value),
                                                   CDate(.Cells(const_GridFormaPagamento_DtDocumento).Value),
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_Emitente).Text, ""),
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_NAgencia).Value, 0),
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_NConta).Value, 0),
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_NDigConta).Value, 0),
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_CodigoDocumento).Value, ""),
                                                   Val(.Cells(const_GridFormaPagamento_ValorPago).Value),
                                                   Val(.Cells(const_GridFormaPagamento_ValorPago).Value),
                                                   FNC_NVL(.Cells(const_GridFormaPagamento_DescricaoDocumento).Value, ""))
          End If
        Else
          oFormaPagamento = FNC_FormaPagamento_Collection(FNC_NVL(.Cells(const_GridFormaPagamento_FormaPagamento).Value, 0), cFormaPagamento)

          If FNC_NVL(.Cells(const_GridFormaPagamento_FormaPagamento).Value, 0) = const_FormaPagamento_CreditoPessoa Then
            iID_PESSOA_CREDITO = FNC_NVL(.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value, 0)
          ElseIf FNC_NVL(.Cells(const_GridFormaPagamento_FormaPagamento).Value, 0) = const_FormaPagamento_CreditoCedido Then
            iID_MOVFINANCEIRAPARCELA_ENCONTROCONTAS = FNC_NVL(.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value, 0)
          ElseIf FNC_NVL(.Cells(const_GridFormaPagamento_FormaPagamento).Value, 0) = const_FormaPagamento_NotaPromissoria Or
                   oFormaPagamento.ID_OPT_DOCUMENTOCADASTRADO = enOpcoes.TipoDocumentoFinanceiroCadastrado_EmitidoTerceiros.GetHashCode() Then
            iSQ_DOCUMENTOFINANCEIRO = .Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value

            FormPagamento_Compensacao_Gravar(.Cells(const_GridFormaPagamento_ID_PAGAMENTOITEM_DOCFINAN).Value,
                                             .Cells(const_GridFormaPagamento_ContaFinanceira).Value,
                                             enOpcoes.StatusPagamentoItem_Negociado.GetHashCode(),
                                             dPagamento.Date,
                                             .Cells(const_GridFormaPagamento_ValorPago).Value,
                                             const_MSG_PagamentoItem_Compensacao_PagtoTerceiro)
          End If
        End If

        If FNC_NVL(.Cells(const_GridFormaPagamento_IC_COMPENSAR).Value, "N") = "S" Then
          eID_OPT_STATUS = enOpcoes.StatusPagamentoItem_Compensar
        Else
          eID_OPT_STATUS = enOpcoes.StatusPagamentoItem_Quitado
        End If

        iSQ_PAGAMENTOITEM = 0

        sSqlText = DBMontar_SP("SP_PAGAMENTOITEM_CAD", False, "@SQ_PAGAMENTOITEM OUT",
                                                              "@ID_PAGAMENTO",
                                                              "@ID_OPT_STATUS",
                                                              "@ID_MOVFINANCEIRAPARCELA_ENCONTROCONTAS",
                                                              "@ID_FORMAPAGAMENTO",
                                                              "@ID_CONTAFINANCEIRA",
                                                              "@ID_DOCUMENTOFINANCEIRO",
                                                              "@ID_PESSOA_CREDITO",
                                                              "@DS_EMITENTE",
                                                              "@VL_PAGAMENTO")

        If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PAGAMENTOITEM", 0, , ParameterDirection.InputOutput),
                                    DBParametro_Montar("ID_PAGAMENTO", iSQ_PAGAMENTO),
                                    DBParametro_Montar("ID_OPT_STATUS", eID_OPT_STATUS),
                                    DBParametro_Montar("ID_MOVFINANCEIRAPARCELA_ENCONTROCONTAS", FNC_NuloSe(iID_MOVFINANCEIRAPARCELA_ENCONTROCONTAS, 0)),
                                    DBParametro_Montar("ID_FORMAPAGAMENTO", .Cells(const_GridFormaPagamento_FormaPagamento).Value),
                                    DBParametro_Montar("ID_CONTAFINANCEIRA", .Cells(const_GridFormaPagamento_ContaFinanceira).Value),
                                    DBParametro_Montar("ID_DOCUMENTOFINANCEIRO", FNC_NuloSe(iSQ_DOCUMENTOFINANCEIRO, 0)),
                                    DBParametro_Montar("ID_PESSOA_CREDITO", FNC_NuloSe(iID_PESSOA_CREDITO, 0)),
                                    DBParametro_Montar("DS_EMITENTE", .Cells(const_GridFormaPagamento_Emitente).Value),
                                    DBParametro_Montar("VL_PAGAMENTO", Val(FNC_ConvValorFormatoAmericano(.Cells(const_GridFormaPagamento_ValorPago).Value)))) Then GoTo Sair
        If DBTeveRetorno() Then
          iSQ_PAGAMENTOITEM = DBRetorno(1)
        End If

        sSqlText = DBMontar_SP("SP_PAGAMENTOITEM_MOVFINANCEIRA_CAD", False, "@ID_PAGAMENTOITEM")
        If Not DBExecutar(sSqlText, DBParametro_Montar("ID_PAGAMENTOITEM", iSQ_PAGAMENTOITEM)) Then GoTo Sair

        If FNC_NVL(.Cells(const_GridFormaPagamento_IC_COMPENSAR).Value, "N") = "N" Or
             FNC_NVL(.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value, 0) <> 0 Then
          If Not FormPagamento_Compensacao_Gravar(iSQ_PAGAMENTOITEM,
                                                  .Cells(const_GridFormaPagamento_ContaFinanceira).Value,
                                                  enOpcoes.StatusPagamentoItem_Quitado.GetHashCode(),
                                                  dPagamento.Date,
                                                  Val(FNC_ConvValorFormatoAmericano(.Cells(const_GridFormaPagamento_ValorPago).Value)), "") Then GoTo Sair
        End If
      End With
    Next

    If iSQ_PESSOA_CREDITO <> 0 And Math.Abs(dValorFinal) <> 0 Then
      sSqlText = DBMontar_SP("SP_LANCAMENTOCREDITOFINANCEIRO_CAD", False, "@SQ_LANCAMENTOCREDITOFINANCEIRO",
                                                                          "@ID_EMPRESA",
                                                                          "@ID_OPT_TIPOLANCAMENTO",
                                                                          "@ID_PESSOA",
                                                                          "@ID_PAGAMENTO",
                                                                          "@ID_CAMPANHA",
                                                                          "@VL_LANCAMENTO",
                                                                          "@DT_LANCAMENTO",
                                                                          "@CM_JUSTIFICATIVA")
      If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_LANCAMENTOCREDITOFINANCEIRO", 0),
                                  DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                  DBParametro_Montar("ID_OPT_TIPOLANCAMENTO", enOpcoes.TipoLancamentoCreditoFinanceiro_Credito.GetHashCode),
                                  DBParametro_Montar("ID_PESSOA", iSQ_PESSOA_CREDITO),
                                  DBParametro_Montar("ID_PAGAMENTO", iSQ_PAGAMENTO),
                                  DBParametro_Montar("ID_CAMPANHA", Nothing),
                                  DBParametro_Montar("VL_LANCAMENTO", Math.Abs(dValorFinal)),
                                  DBParametro_Montar("DT_LANCAMENTO", dPagamento.Date),
                                  DBParametro_Montar("CM_JUSTIFICATIVA", Nothing)) Then GoTo Sair
    End If

    bOk = True

Sair:
    If Trim(sMsg) <> "" Then FNC_Mensagem(sMsg)
    Return bOk
  End Function

  Public Sub Formatar()
    objGrid_Inicializar(grdFormaPagamento, Infragistics.Win.UltraWinGrid.AllowAddNew.FixedAddRowOnTop,
                                           oDBFormaPagamento,
                                           UltraWinGrid.CellClickAction.RowSelect, , IIf(bPagamentoPorParcela,
                                                                                         DefaultableBoolean.False,
                                                                                         DefaultableBoolean.True), False, , , , True)
    Select Case iTipoMovimentacao
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode
        objGrid_Coluna_Add(grdFormaPagamento, "Forma de Pagamento", 200, , True, , FNC_CarregarLista(enTipoCadastro.FormaPagamento_QuitarCPCR))
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode
        objGrid_Coluna_Add(grdFormaPagamento, "Forma de Pagamento", 200, , True, , FNC_CarregarLista(enTipoCadastro.FormaPagamento_QuitarCPCR, FNC_Collection_Para_Lista(cID_PESSOA, ",")))
    End Select
    objGrid_Coluna_Add(grdFormaPagamento, "Valor Pago", 150, , True, ColumnStyle.Currency)
    objGrid_Coluna_Add(grdFormaPagamento, "Valor Saldo", 150, , False, ColumnStyle.Currency)
    Select Case iTipoMovimentacao
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode
        objGrid_Coluna_Add(grdFormaPagamento, "Conta de Débito", 300, , True, , FNC_CarregarLista(enTipoCadastro.ContaFinanceira, New Object() {iID_USUARIO}))
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode
        objGrid_Coluna_Add(grdFormaPagamento, "Conta de Crédito", 300, , True, , FNC_CarregarLista(enTipoCadastro.ContaFinanceira, New Object() {iID_USUARIO}))
    End Select
    objGrid_Coluna_Add(grdFormaPagamento, "Cód. Documento", 300, , True)
    objGrid_Coluna_Add(grdFormaPagamento, "Emitente", 300, , True)
    objGrid_Coluna_Add(grdFormaPagamento, "...", 30, , True, ColumnStyle.Button)
    objGrid_Coluna_Add(grdFormaPagamento, "Dt. Documento", 120, , True, ColumnStyle.Date)
    objGrid_Coluna_Add(grdFormaPagamento, "Banco", 150, , True, , FNC_CarregarLista(enTipoCadastro.Banco))
    objGrid_Coluna_Add(grdFormaPagamento, "Nº Agência", 100, , True, ColumnStyle.IntegerPositive)
    objGrid_Coluna_Add(grdFormaPagamento, "Nº Conta", 100, , True, ColumnStyle.IntegerPositive)
    objGrid_Coluna_Add(grdFormaPagamento, "Nº Díg. Conta", 100, , True, ColumnStyle.IntegerPositive)
    objGrid_Coluna_Add(grdFormaPagamento, "Descrição do Documento", 150, , True)
    objGrid_Coluna_Add(grdFormaPagamento, "Doc. Financ./Créd. Pessoa/Enc. Contas", 300, , True)
    objGrid_Coluna_Add(grdFormaPagamento, "IC_COMPENSAR", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "ID_TIPO_DOCUMENTO", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "ID_EMITENTE", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "ID_CADASTRAR_DOCUMENTO", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "ID_PAGAMENTOITEM", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "SQ_MOVFINANCEIRAPARCELA", 0)
    objGrid_Configuracao_Gravar(grdFormaPagamento, Me.Name)

    cFormaPagamento = FNC_FormaPagamento_Collection_Carregar()
  End Sub

  Private Sub uscLancaContasReceberPagar_Quitar_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    grdFormaPagamento.Height = Me.Height - grdFormaPagamento.Top
    grdFormaPagamento.Width = Me.Width
  End Sub

  Private Sub grdFormaPagamento_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdFormaPagamento.AfterCellUpdate
    CalcularValorPago()

    Dim oFormaPagamento As cFormaPagamento

    Select Case e.Cell.Column.Index
      Case const_GridFormaPagamento_FormaPagamento
        oFormaPagamento = FNC_FormaPagamento_Collection(FNC_NVL(e.Cell.Value, 0), cFormaPagamento)

        If Convert.ToInt32(FNC_NVL(e.Cell.Value, 0)) = const_FormaPagamento_CreditoPessoa Then
          e.Cell.Row.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).ValueList = FNC_CarregarLista(enTipoCadastro.PessoaCredito_QuitarCPCR,
                                                                                                                                              FNC_Collection_Para_Lista(cID_PESSOA))
        ElseIf Convert.ToInt32(FNC_NVL(e.Cell.Value, 0)) = const_FormaPagamento_CreditoCedido Then
          e.Cell.Row.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).ValueList = FNC_CarregarLista(enTipoCadastro.PessoaCredito_CreditoCedido,
                                                                                                                                              FNC_Collection_Para_Lista(cID_PESSOA))
        ElseIf FNC_NVL(oFormaPagamento.ID_OPT_DOCUMENTOCADASTRADO, 0) = enOpcoes.TipoDocumentoFinanceiroCadastrado_EmitidoTerceiros.GetHashCode() Then
          e.Cell.Row.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).ValueList = FNC_CarregarLista(enTipoCadastro.DocumentoFinanceiroDisponivel,
                                                                                                                                              oFormaPagamento.ID_TIPO_DOCUMENTO)
        Else
          e.Cell.Row.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).ValueList = Nothing
        End If

        e.Cell.Row.Cells(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value = Nothing
        e.Cell.Row.Cells(const_GridFormaPagamento_ValorPago).Value = 0
        e.Cell.Row.Cells(const_GridFormaPagamento_Emitente).Value = Nothing
        e.Cell.Row.Cells(const_GridFormaPagamento_CodigoDocumento).Value = Nothing
        e.Cell.Row.Cells(const_GridFormaPagamento_DtDocumento).Value = Nothing
        e.Cell.Row.Cells(const_GridFormaPagamento_Banco).Value = Nothing
        e.Cell.Row.Cells(const_GridFormaPagamento_NAgencia).Value = Nothing
        e.Cell.Row.Cells(const_GridFormaPagamento_NConta).Value = Nothing
        e.Cell.Row.Cells(const_GridFormaPagamento_NDigConta).Value = Nothing
      Case const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas
        If FNC_NVL(e.Cell.Row.Cells(const_GridFormaPagamento_FormaPagamento).Value, 0) <> const_FormaPagamento_CreditoPessoa Then
          Dim oData As DataTable
          Dim sSqlText As String

          sSqlText = "SELECT * FROM VW_DOCUMENTOFINANCEIRO WHERE SQ_DOCUMENTOFINANCEIRO = " & FNC_NVL(e.Cell.Value, 0)
          oData = DBQuery(sSqlText)
          If Not objDataTable_Vazio(oData) Then
            With oData.Rows(0)
              e.Cell.Row.Cells(const_GridFormaPagamento_ValorPago).Value = .Item("VL_SALDO")
              e.Cell.Row.Cells(const_GridFormaPagamento_Emitente).Value = .Item("DS_EMITENTE")
              e.Cell.Row.Cells(const_GridFormaPagamento_CodigoDocumento).Value = .Item("CD_DOCUMENTO")
              e.Cell.Row.Cells(const_GridFormaPagamento_DtDocumento).Value = .Item("DT_DOCUMENTO")
              e.Cell.Row.Cells(const_GridFormaPagamento_Banco).Value = .Item("ID_BANCO")
              e.Cell.Row.Cells(const_GridFormaPagamento_NAgencia).Value = .Item("NR_BANCO_AGENCIA")
              e.Cell.Row.Cells(const_GridFormaPagamento_NConta).Value = .Item("NR_BANCO_CONTA")
              e.Cell.Row.Cells(const_GridFormaPagamento_NDigConta).Value = .Item("NR_BANCO_CONTA_DIGITO")
            End With

            sSqlText = "SELECT * FROM TB_PAGAMENTOITEM" &
                       " WHERE ID_DOCUMENTOFINANCEIRO = " & FNC_NVL(e.Cell.Value, 0) &
                         " AND ID_OPT_STATUS = " & enOpcoes.StatusPagamentoItem_Compensar.GetHashCode()
            e.Cell.Row.Cells(const_GridFormaPagamento_ID_PAGAMENTOITEM_DOCFINAN).Value = DBQuery_ValorUnico(sSqlText)
          End If
        End If
    End Select
  End Sub

  Public Function CalcularValorPago() As Double
    dValorPago = objGrid_CalcularTotalColuna(grdFormaPagamento, const_GridFormaPagamento_ValorPago)

    RaiseEvent ValorPago()

    Return dValorPago
  End Function

  Public Sub CalcularBaixarParcelas(grdContas As UltraWinGrid.UltraGrid,
                                    iGridContas_ValorQuitando As Integer,
                                    iGridContas_ValorTotalAPagar As Integer,
                                    iGridContas_ValorRestante As Integer)
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim vValor As Double

    'Limpa os valores de parcela das contas
    For iCont_01 = 0 To grdContas.Rows.Count - 1
      With grdContas.Rows(iCont_01)
        .Cells(iGridContas_ValorQuitando).Value = 0
        .Cells(iGridContas_ValorRestante).Value = .Cells(iGridContas_ValorTotalAPagar).Value
      End With
    Next
    'Atualizo os saldos da forma de pagamento
    For iCont_01 = 0 To grdFormaPagamento.Rows.Count - 1
      With grdFormaPagamento.Rows(iCont_01)
        .Cells(const_GridFormaPagamento_ValorSaldo).Value = CDbl(.Cells(const_GridFormaPagamento_ValorPago).Value)
      End With
    Next

    For iCont_01 = 0 To grdFormaPagamento.Rows.Count - 1
      For iCont_02 = 0 To grdContas.Rows.Count - 1
        If objGrid_Valor(grdContas, iGridContas_ValorRestante, iCont_02) > 0 Then
          If Val(objGrid_Valor(grdFormaPagamento, const_GridFormaPagamento_ValorSaldo, iCont_01)) >
             Val(objGrid_Valor(grdContas, iGridContas_ValorRestante, iCont_02)) Then
            vValor = Math.Round(Val(objGrid_Valor(grdContas, iGridContas_ValorRestante, iCont_02)), 2)
          Else
            vValor = Val(objGrid_Valor(grdFormaPagamento, const_GridFormaPagamento_ValorSaldo, iCont_01))
          End If

          With grdContas.Rows(iCont_02)
            .Cells(iGridContas_ValorRestante).Value = Val(.Cells(iGridContas_ValorRestante).Value) - vValor
            .Cells(iGridContas_ValorQuitando).Value = Val(.Cells(iGridContas_ValorQuitando).Value) + vValor
          End With
          With grdFormaPagamento.Rows(iCont_01)
            .Cells(const_GridFormaPagamento_ValorSaldo).Value = CDbl(.Cells(const_GridFormaPagamento_ValorSaldo).Value) - vValor

            If .Cells(const_GridFormaPagamento_ValorSaldo).Value = 0 Then Exit For
          End With
        End If
      Next
    Next
  End Sub

  Public Sub Finalizar()
    objGrid_Configuracao_Gravar(grdFormaPagamento, Me.Name)
  End Sub

  Private Sub grdFormaPagamento_ClickCellButton(sender As Object, e As CellEventArgs) Handles grdFormaPagamento.ClickCellButton
    Dim oForm As New frmpsqPessoa

    FNC_AbriTela(oForm, , True, True)

    e.Cell.Row.Cells(const_GridFormaPagamento_ID_EMITENTE).Value = oForm.SQ_PESSOA
    e.Cell.Row.Cells(const_GridFormaPagamento_Emitente).Value = oForm.NO_PESSOA

    oForm.Dispose()
  End Sub

  Public Sub Grid_Adicionar(iID_CONTAFINANCEIRA As Integer,
                            iID_FORMAPAGAMENTO_PREFERENCIAL As Integer,
                            iSQ_MOVFINANCEIRAPARCELA As Integer,
                            dValorDebito As Double)
    objGrid_Linha_Add(grdFormaPagamento, New Object() {const_GridFormaPagamento_ContaFinanceira, iID_CONTAFINANCEIRA,
                                                       const_GridFormaPagamento_FormaPagamento, iID_FORMAPAGAMENTO_PREFERENCIAL,
                                                       const_GridFormaPagamento_SQ_MOVFINANCEIRAPARCELA, iSQ_MOVFINANCEIRAPARCELA,
                                                       const_GridFormaPagamento_ValorPago, dValorDebito})
  End Sub

  Private Sub grdFormaPagamento_AfterRowsDeleted(sender As Object, e As EventArgs) Handles grdFormaPagamento.AfterRowsDeleted
    CalcularValorPago()
  End Sub

  Private Sub grdFormaPagamento_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdFormaPagamento.BeforeRowsDeleted
    e.DisplayPromptMsg = False
  End Sub
End Class
