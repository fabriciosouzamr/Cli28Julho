Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class uscLancaContasReceberPagar_QuitarForm
  Public Event ValorPago()
  Public Event RegerarConsulta()

  Const const_GridFormaPagamento_ValorPago As Integer = 0
  Const const_GridFormaPagamento_FormaPagamento As Integer = 1
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
  Const const_GridFormaPagamento_ID_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas As Integer = 20

  Public grdContas As UltraWinGrid.UltraGrid
  Public GrdContas_SQ_MOVFINANCEIRAPARCELA As Integer
  Public GrdContas_SQ_PAGAMENTO As Integer
  Public GrdContas_PC_DESCONTO As Integer
  Public GrdContas_ValorQuitando As Integer
  Public GrdContas_ValorDesconto As Integer
  Public GrdContas_ValorParcela As Integer
  Public GrdContas_ValorJuros As Integer
  Public GrdContas_ValorMulta As Integer
  Public GrdContas_ValorDescontoPagto As Integer
  Public GrdContas_ValorAcrescimoPagto As Integer
  Public GrdContas_ValorRestante As Integer
  Public GrdContas_ValorImpostoRetido As Integer
  Public GrdContas_JustificativaDescontoAcrescimo As Integer
  Public GrdContas_ID_MOVFINANCEIRA As Integer
  Public GrdContas_ID_FORMAPAGAMENTO_PREFERENCIAL As Integer

  Public bPagamentoPorParcela As Boolean
  Public bGravacaoAutomatica As Boolean
  Public sTipoMovimentacao As String
  Public cID_PESSOA As New Collection
  Public iSQ_PAGAMENTO As Integer
  Public iSQ_PESSOA_CREDITO As Integer
  Public dPagamento As DateTime
  Public dValorFinal As Double
  Public dValorPago As Double
  Public iTipoMovimentacao As Integer
  Public dDataPagamento As Date

  Dim oDBFormaPagamento As New UltraWinDataSource.UltraDataSource

  Dim cFormaPagamento As Collection
  Dim oFormaPagamento As cFormaPagamento
  Dim iNRLinha As Integer = -1
  Dim bEmProcessamento As Boolean = False

  Public Property TipoMovimentacao As Integer
    Get
      Return iTipoMovimentacao
    End Get
    Set(value As Integer)
      iTipoMovimentacao = value
      Formatar_TipoMovimentacao()
    End Set
  End Property

  Private Sub Banco_Habilitar(bHabilitar As Boolean)
    lblRBanco.Visible = bHabilitar
    cboBanco.Visible = bHabilitar
    lblRAgencia.Visible = bHabilitar
    txtNrAgencia.Visible = bHabilitar
    lblRConta.Visible = bHabilitar
    txtNrConta.Visible = bHabilitar
    lblRNrContaDigito.Visible = bHabilitar
    txtNrContaDigito.Visible = bHabilitar

    If Not bHabilitar Then
      cboBanco.SelectedIndex = -1
      txtNrAgencia.Value = 0
      txtNrConta.Value = 0
      txtNrContaDigito.Value = 0
    End If
  End Sub

  Public Sub Inicializar()
    Novo()
    oDBFormaPagamento.Rows.Clear()
  End Sub

  Private Sub Novo()
    Banco_Habilitar(False)

    lblRDocFinanc_CredPessoa_EncContas.Top = 84
    lblRDocFinanc_CredPessoa_EncContas.Left = 93
    lblRDocFinanc_CredPessoa_EncContas.Visible = False
    cboDocFinanc_CredPessoa_EncContas.Top = 99
    cboDocFinanc_CredPessoa_EncContas.Left = 93
    cboDocFinanc_CredPessoa_EncContas.Visible = False
    cboDocFinanc_CredPessoa_EncContas.DataSource = Nothing

    lblRDtDocumento.Enabled = False
    txtDtDocumento.Enabled = False
    txtDtDocumento.Value = Nothing
    lblRDescricaoDocumento.Enabled = False
    txtDescricaoDocumento.Enabled = False
    txtDescricaoDocumento.Text = ""
    opsqEmitente.Enabled = False
    opsqEmitente.ID_Pessoa = 0
    lblRCodDocumento.Enabled = False
    txtCodDocumento.Enabled = False
    txtCodDocumento.Text = ""

    txtValorPago.Value = 0
    cboFormaPagamento.SelectedIndex = -1
    txtValorSaldo.Value = 0
    cboContaDebito_ContaCredito.SelectedIndex = -1

    iNRLinha = -1
  End Sub

  Public Sub Formatar()
    Novo()

    objGrid_Inicializar(grdFormaPagamento, Infragistics.Win.UltraWinGrid.AllowAddNew.No,
                                           oDBFormaPagamento,
                                           UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdFormaPagamento, "Valor Pago", 100, , True, ColumnStyle.Currency)
    Select Case iTipoMovimentacao
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode
        objGrid_Coluna_Add(grdFormaPagamento, "Forma de Pagamento", 200, , True, , FNC_CarregarLista(enTipoCadastro.FormaPagamento_QuitarCPCR))
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode
        objGrid_Coluna_Add(grdFormaPagamento, "Forma de Pagamento", 200, , True, , FNC_CarregarLista(enTipoCadastro.FormaPagamento_QuitarCPCR, FNC_Collection_Para_Lista(cID_PESSOA, ",")))
    End Select
    objGrid_Coluna_Add(grdFormaPagamento, "Valor Saldo", 150, , False, ColumnStyle.Currency)
    Select Case iTipoMovimentacao
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode
        objGrid_Coluna_Add(grdFormaPagamento, "Conta de Débito", 300, , True, , FNC_CarregarLista(enTipoCadastro.ContaFinanceira))
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode
        objGrid_Coluna_Add(grdFormaPagamento, "Conta de Crédito", 300, , True, , FNC_CarregarLista(enTipoCadastro.ContaFinanceira))
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
    objGrid_Coluna_Add(grdFormaPagamento, "ID_PAGAMENTOITEM_DOCFINAN", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "SQ_MOVFINANCEIRAPARCELA", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "ID_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas", 0)
    objGrid_Configuracao_Gravar(grdFormaPagamento, Me.Name)

    Formatar_TipoMovimentacao()

    cFormaPagamento = FNC_FormaPagamento_Collection_Carregar()
    ComboBox_Carregar(cboContaDebito_ContaCredito, enSql.ContaFinanceira, New Object() {iID_USUARIO})
    ComboBox_Carregar(cboBanco, enSql.Banco)
  End Sub

  Public Sub Formatar_TipoMovimentacao()
    Select Case iTipoMovimentacao
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode
        lblRContaDebito_ContaCredito.Text = "Conta de Débito"
        ComboBox_Carregar(cboFormaPagamento, enSql.FormaPagamento_QuitarCPCR)
      Case enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode
        lblRContaDebito_ContaCredito.Text = "Conta de Crédito"
        ComboBox_Carregar(cboFormaPagamento, enSql.FormaPagamento_QuitarCPCR, New Object() {FNC_Collection_Para_Lista(cID_PESSOA, ",")})
    End Select
  End Sub

  Private Sub cboFormaPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormaPagamento.SelectedIndexChanged
    If ComboBox_Selecionado(cboFormaPagamento) Then
      Dim bRDocFinanc_CredPessoa_EncContas As Boolean = False
      Dim bCADASTRAR_CONTABANCARIA As Boolean = False
      Dim bCADASTRAR_DOCUMENTO As Boolean = False

      oFormaPagamento = FNC_FormaPagamento_Collection(FNC_NVL(cboFormaPagamento.SelectedValue, 0), cFormaPagamento)

      If Convert.ToInt32(FNC_NVL(cboFormaPagamento.SelectedValue, 0)) = const_FormaPagamento_CreditoPessoa Then
        If Not cID_PESSOA Is Nothing Then
          If cID_PESSOA.Count <> 0 Then
            ComboBox_Carregar(cboDocFinanc_CredPessoa_EncContas, enSql.PessoaCredito_QuitarCPCR, New Object() {FNC_Collection_Para_Lista(cID_PESSOA)})
          End If
        End If

        bRDocFinanc_CredPessoa_EncContas = True
      ElseIf Convert.ToInt32(FNC_NVL(cboFormaPagamento.SelectedValue, 0)) = const_FormaPagamento_CreditoCedido Then
        If Not cID_PESSOA Is Nothing Then
          If cID_PESSOA.Count <> 0 Then
            ComboBox_Carregar(cboDocFinanc_CredPessoa_EncContas, enSql.PessoaCredito_CreditoCedido, New Object() {FNC_Collection_Para_Lista(cID_PESSOA)})
          End If
        End If
        bRDocFinanc_CredPessoa_EncContas = True
      ElseIf FNC_NVL(oFormaPagamento.ID_OPT_DOCUMENTOCADASTRADO, 0) = enOpcoes.TipoDocumentoFinanceiroCadastrado_EmitidoTerceiros.GetHashCode() Then
        ComboBox_Carregar(cboDocFinanc_CredPessoa_EncContas, enSql.DocumentoFinanceiroDisponivel, New Object() {oFormaPagamento.ID_TIPO_DOCUMENTO})
        bRDocFinanc_CredPessoa_EncContas = True
      Else
        bCADASTRAR_CONTABANCARIA = oFormaPagamento.CADASTRAR_CONTABANCARIA
        bCADASTRAR_DOCUMENTO = (oFormaPagamento.CADASTRAR_DOCUMENTO Or oFormaPagamento.COMPENSA)
      End If

      lblRDocFinanc_CredPessoa_EncContas.Visible = bRDocFinanc_CredPessoa_EncContas
      cboDocFinanc_CredPessoa_EncContas.Visible = bRDocFinanc_CredPessoa_EncContas
      Banco_Habilitar(bCADASTRAR_CONTABANCARIA)

      lblRDtDocumento.Enabled = bCADASTRAR_CONTABANCARIA Or bCADASTRAR_DOCUMENTO
      txtDtDocumento.Enabled = bCADASTRAR_CONTABANCARIA Or bCADASTRAR_DOCUMENTO
      lblRDescricaoDocumento.Enabled = bCADASTRAR_CONTABANCARIA Or bCADASTRAR_DOCUMENTO
      txtDescricaoDocumento.Enabled = bCADASTRAR_CONTABANCARIA Or bCADASTRAR_DOCUMENTO
      opsqEmitente.Enabled = bCADASTRAR_CONTABANCARIA Or bCADASTRAR_DOCUMENTO
      lblRCodDocumento.Enabled = bCADASTRAR_CONTABANCARIA Or bCADASTRAR_DOCUMENTO
      txtCodDocumento.Enabled = bCADASTRAR_CONTABANCARIA Or bCADASTRAR_DOCUMENTO
    End If
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    Novo()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboFormaPagamento) Then
      FNC_Mensagem("Selecione a forma de pagamento")
      Exit Sub
    End If
    If txtValorPago.Value = 0 Then
      FNC_Mensagem("Informe o valor do pagamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboContaDebito_ContaCredito) Then
      FNC_Mensagem("Selecione a " + lblRContaDebito_ContaCredito.Text)
      Exit Sub
    End If

    'Validar dados bancários
    If cboBanco.Visible Then
      If Not ComboBox_Selecionado(cboBanco) Then
        FNC_Mensagem("Selecione o banco desse documento")
        Exit Sub
      End If
      If txtNrAgencia.Value = 0 Then
        FNC_Mensagem("Informe o número da agência")
        Exit Sub
      End If
      If txtNrConta.Value = 0 Then
        FNC_Mensagem("Informe o número da conta corrente")
        Exit Sub
      End If
      If txtNrContaDigito.Value = 0 Then
        FNC_Mensagem("Informe o número o dígito da conta corrente")
        Exit Sub
      End If
    End If

    If cboDocFinanc_CredPessoa_EncContas.Visible Then
      If Not ComboBox_Selecionado(cboDocFinanc_CredPessoa_EncContas) Then
        If Convert.ToInt32(FNC_NVL(cboFormaPagamento.SelectedValue, 0)) = const_FormaPagamento_CreditoPessoa Then
          FNC_Mensagem("Selecione o crédito a ser utilizado")
        ElseIf Convert.ToInt32(FNC_NVL(cboFormaPagamento.SelectedValue, 0)) = const_FormaPagamento_CreditoCedido Then
          FNC_Mensagem("Selecione o crédito a ser utilizado")
        ElseIf FNC_NVL(oFormaPagamento.ID_OPT_DOCUMENTOCADASTRADO, 0) = enOpcoes.TipoDocumentoFinanceiroCadastrado_EmitidoTerceiros.GetHashCode() Then
          FNC_Mensagem("Selecione o documento de terceiro a ser utilizado")
        End If

        Exit Sub
      End If
    End If

    If txtDtDocumento.Enabled And Not IsDate(txtDtDocumento.Text) Then
      FNC_Mensagem("Selecione a data do documento")
      Exit Sub
    End If

    If iNRLinha = -1 Then
      iNRLinha = oDBFormaPagamento.Rows.Add().Index
    End If

    oFormaPagamento = FNC_FormaPagamento_Collection(FNC_NVL(cboFormaPagamento.SelectedValue, 0), cFormaPagamento)

    With oDBFormaPagamento.Rows(iNRLinha)
      .SetCellValue(const_GridFormaPagamento_ValorPago, txtValorPago.Value)
      .SetCellValue(const_GridFormaPagamento_FormaPagamento, cboFormaPagamento.SelectedValue)
      .SetCellValue(const_GridFormaPagamento_ValorSaldo, txtValorSaldo.Value)
      .SetCellValue(const_GridFormaPagamento_ContaFinanceira, cboContaDebito_ContaCredito.SelectedValue)

      If cboBanco.Visible Then
        .SetCellValue(const_GridFormaPagamento_Banco, cboBanco.SelectedValue)
        .SetCellValue(const_GridFormaPagamento_NAgencia, txtNrAgencia.Value)
        .SetCellValue(const_GridFormaPagamento_NConta, txtNrConta.Value)
        .SetCellValue(const_GridFormaPagamento_NDigConta, txtNrContaDigito.Value)
      Else
        .SetCellValue(const_GridFormaPagamento_Banco, Nothing)
        .SetCellValue(const_GridFormaPagamento_NAgencia, Nothing)
        .SetCellValue(const_GridFormaPagamento_NConta, Nothing)
        .SetCellValue(const_GridFormaPagamento_NDigConta, Nothing)
      End If
      If ComboBox_Selecionado(cboDocFinanc_CredPessoa_EncContas) Then
        .SetCellValue(const_GridFormaPagamento_ID_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas, cboDocFinanc_CredPessoa_EncContas.SelectedValue)
        .SetCellValue(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas, cboDocFinanc_CredPessoa_EncContas.Text)

        If oFormaPagamento.ID_OPT_DOCUMENTOCADASTRADO = enOpcoes.TipoDocumentoFinanceiroCadastrado_EmitidoTerceiros.GetHashCode() Then
          Dim sSqlText As String

          sSqlText = "SELECT * FROM TB_PAGAMENTOITEM" &
                       " WHERE ID_DOCUMENTOFINANCEIRO = " & cboDocFinanc_CredPessoa_EncContas.SelectedValue &
                         " AND ID_OPT_STATUS = " & enOpcoes.StatusPagamentoItem_Compensar.GetHashCode()
          .SetCellValue(const_GridFormaPagamento_ID_PAGAMENTOITEM_DOCFINAN, DBQuery_ValorUnico(sSqlText))
        End If
      Else
        .SetCellValue(const_GridFormaPagamento_ID_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas, Nothing)
        .SetCellValue(const_GridFormaPagamento_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas, Nothing)
      End If
      If txtDtDocumento.Enabled Then
        .SetCellValue(const_GridFormaPagamento_DtDocumento, txtDtDocumento.Value)
      Else
        .SetCellValue(const_GridFormaPagamento_DtDocumento, Nothing)
      End If
      If txtDescricaoDocumento.Enabled Then
        .SetCellValue(const_GridFormaPagamento_DescricaoDocumento, txtDescricaoDocumento.Text)
      Else
        .SetCellValue(const_GridFormaPagamento_DescricaoDocumento, Nothing)
      End If
      If opsqEmitente.Enabled Then
        .SetCellValue(const_GridFormaPagamento_Emitente, opsqEmitente.NO_PESSOA)
        .SetCellValue(const_GridFormaPagamento_ID_EMITENTE, opsqEmitente.ID_Pessoa)
      Else
        .SetCellValue(const_GridFormaPagamento_Emitente, Nothing)
        .SetCellValue(const_GridFormaPagamento_ID_EMITENTE, Nothing)
      End If
      If txtCodDocumento.Enabled Then
        .SetCellValue(const_GridFormaPagamento_CodigoDocumento, txtCodDocumento.Text)
      Else
        .SetCellValue(const_GridFormaPagamento_CodigoDocumento, Nothing)
      End If

      .SetCellValue(const_GridFormaPagamento_IC_COMPENSAR, IIf(oFormaPagamento.COMPENSA, "S", "N"))
      .SetCellValue(const_GridFormaPagamento_ID_TIPO_DOCUMENTO, oFormaPagamento.ID_TIPO_DOCUMENTO)
      .SetCellValue(const_GridFormaPagamento_IC_CADASTRAR_DOCUMENTO, IIf(oFormaPagamento.CADASTRAR_DOCUMENTO, "S", "N"))
    End With

    RaiseEvent ValorPago()

    Novo()
  End Sub

  Private Sub cmdRemover_Click(sender As Object, e As EventArgs) Handles cmdRemover.Click
    If objGrid_LinhaSelecionada(grdFormaPagamento) = -1 Then
      FNC_Mensagem("Selecione um registro para exclusão")
      Exit Sub
    End If
    If Not FNC_Perguntar("Deseja realmente excluir esse pagamento?") Then
      Exit Sub
    End If

    grdFormaPagamento.Rows(objGrid_LinhaSelecionada(grdFormaPagamento)).Delete()
  End Sub

  Public Function Validar_DataPagamento() As Boolean
    Dim bOk As Boolean = False

    If grdFormaPagamento.Rows.Count > 0 And FNC_Data_HoraValida(dDataPagamento) Or grdFormaPagamento.Rows.Count = 0 Then
      bOk = True
    Else
      FNC_Mensagem("Para informar pagamento é preciso informar a data do mesmo")
    End If

    Return bOk
  End Function

  Public Function Validar(PagamentoObrigatorio As Boolean) As Boolean
    Dim bOk As Boolean = False

    If Not PagamentoObrigatorio And grdFormaPagamento.Rows.Count = 0 Then
      GoTo Sair
    End If

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
          'If .CADASTRAR_DOCUMENTO Or .CADASTRAR_CONTABANCARIA Then
          '  If FNC_NVL(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_CodigoDocumento).Value, "") = "" Then
          '    FNC_Mensagem("É preciso informar o código do documento")
          '    GoTo Sair
          '  End If
          '  If FNC_NVL(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_Emitente).Value, "") = "" Then
          '    FNC_Mensagem("É preciso informar o emitente do documento")
          '    GoTo Sair
          '  End If
          '  If Not IsDate(grdFormaPagamento.Rows(iCont_01).Cells(const_GridFormaPagamento_DtDocumento).Value) Then
          '    FNC_Mensagem("É preciso informar a data do documento")
          '    GoTo Sair
          '  End If
          'End If
        End With
        'Valida se é necessário cadastrar o documento financeiro - Fim
      End If
    Next

    If dValorPago <= 0 Then
      FNC_Mensagem("Não foi informado nenhum pagamento ainda")
      GoTo Sair
    End If
    If Not IsDate(dDataPagamento) Then
      FNC_Mensagem("Informe a data do pagamento")
      GoTo Sair
    End If
    If (iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode) And
       Math.Round(dValorFinal, 2) < 0 Then
      FNC_Mensagem("Não é permitido pagar mais que o valor total das parcelas")
      GoTo Sair
    End If
    If objGrid_CalcularTotalColuna(grdContas, GrdContas_ValorQuitando) <> dValorPago Then
      FNC_Mensagem("A soma do valor quitando das contas não pode ser diferente do valor pago")
      GoTo Sair
    End If
    If Math.Abs(dValorFinal) < 0 And iSQ_PESSOA_CREDITO = 0 Then
      FNC_Mensagem("É preciso informar a pessoa que irá receber o crédito de " & FormatCurrency(Math.Abs(dValorFinal)))
      GoTo Sair
    End If

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
    Dim iSQ_PAGAMENTO As Integer

    Dim sSqlText As String
    Dim bOk As Boolean = False

    Dim dDesconto As Double

    iID_PESSOA_CREDITO = 0
    iID_MOVFINANCEIRAPARCELA_ENCONTROCONTAS = 0
    iSQ_DOCUMENTOFINANCEIRO = 0

    sSqlText = ""

    'Validação das contas
    For iCont = 0 To grdContas.Rows.Count - 1
      With grdContas.Rows(iCont)
        If (FNC_NVL(.Cells(GrdContas_ValorDescontoPagto).Value, 0) <> 0 Or FNC_NVL(.Cells(GrdContas_ValorAcrescimoPagto).Value, 0) <> 0) Then
          If FNC_NVL(.Cells(GrdContas_ValorRestante).Value, 0) <> 0 Then
            FNC_Mensagem("Só é permitido lançamento desconto e acréscimo realizado no pagamento no momento da liquidação da dívida")
            GoTo Sair
          End If
          If FNC_CampoNulo(.Cells(GrdContas_JustificativaDescontoAcrescimo).Value) Then
            FNC_Mensagem("É preciso justificar valor de desconto e acréscimo realizado no pagamento")
            GoTo Sair
          End If
        End If
      End With
    Next

    'Validação dos pagamentos
    If Not Validar(True) Then GoTo Sair

    DBUsarTransacao = True

    For iCont = 0 To grdContas.Rows.Count - 1
      With grdContas.Rows(iCont)
        If iSQ_PAGAMENTO = 0 Or Not FNC_CampoNulo(.Cells(GrdContas_ID_FORMAPAGAMENTO_PREFERENCIAL).Value) Then
          sSqlText = DBMontar_SP("SP_PAGAMENTO_CAD", False, "@SQ_PAGAMENTO OUT",
                                                            "@ID_EMPRESA",
                                                            "@ID_OPT_TIPOPAGAMENTO",
                                                            "@DT_LANCAMENTO",
                                                            "@DT_PAGAMENTO")

          If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PAGAMENTO", 0, , ParameterDirection.InputOutput),
                                      DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                      DBParametro_Montar("ID_OPT_TIPOPAGAMENTO", enOpcoes.TipoPagamento_Pagamento.GetHashCode),
                                      DBParametro_Montar("DT_LANCAMENTO", Nothing),
                                      DBParametro_Montar("DT_PAGAMENTO", dDataPagamento)) Then GoTo Erro

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

        .Cells(GrdContas_SQ_PAGAMENTO).Value = iSQ_PAGAMENTO

        If FNC_NVL(.Cells(GrdContas_ValorDesconto).Value, 0) > 0 Then
          dDesconto = .Cells(GrdContas_ValorQuitando).Value / (.Cells(GrdContas_ValorParcela).Value * (1 - .Cells(GrdContas_PC_DESCONTO).Value))
          dDesconto = dDesconto * FNC_Porcentagem(.Cells(GrdContas_ValorParcela).Value, .Cells(GrdContas_PC_DESCONTO).Value)
        End If

        If .Cells(GrdContas_ValorQuitando).Value > 0 Then
          If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA", FNC_NVL(.Cells(GrdContas_SQ_MOVFINANCEIRAPARCELA).Value, 0)),
                                      DBParametro_Montar("ID_PAGAMENTO", iSQ_PAGAMENTO),
                                      DBParametro_Montar("ID_APROVADOR_DESCONTO", Nothing),
                                      DBParametro_Montar("VL_PAGAMENTO", FNC_ConvValorFormatoAmericano(.Cells(GrdContas_ValorQuitando).Value)),
                                      DBParametro_Montar("VL_JUROS", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(GrdContas_ValorJuros).Value, "0"))),
                                      DBParametro_Montar("VL_MULTA", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(GrdContas_ValorMulta).Value, "0"))),
                                      DBParametro_Montar("VL_DESCONTO", Math.Round(dDesconto, 2)),
                                      DBParametro_Montar("VL_DESCONTO_PAGTO", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(GrdContas_ValorDescontoPagto).Value, "0"))),
                                      DBParametro_Montar("VL_ACRESCIMO_PAGTO", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(GrdContas_ValorAcrescimoPagto).Value, "0"))),
                                      DBParametro_Montar("VL_JUROS_PAGTO", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(GrdContas_ValorJuros).Value, "0"))),
                                      DBParametro_Montar("VL_IMPOSTORETIDO", FNC_ConvValorFormatoAmericano(FNC_NVL(.Cells(GrdContas_ValorImpostoRetido).Value, "0"))),
                                      DBParametro_Montar("CM_JUSTIFICATICA_DESCONTO_ACRESCIMO", .Cells(GrdContas_JustificativaDescontoAcrescimo).Value,,, const_BancoDados_TamanhoComentario),
                                      DBParametro_Montar("DT_PAGAMENTO", dDataPagamento.Date, SqlDbType.Date),
                                      DBParametro_Montar("ID_USUARIO", iID_USUARIO)) Then GoTo Erro
        End If

        FormMovimentacaoFinanceira_Status_Atualizar(.Cells(GrdContas_ID_MOVFINANCEIRA).Value)
      End With
    Next

    For iCont_01 = 0 To grdFormaPagamento.Rows.Count - 1
      iSQ_DOCUMENTOFINANCEIRO = 0

      With grdFormaPagamento.Rows(iCont_01)
        If FNC_NVL(.Cells(const_GridFormaPagamento_SQ_MOVFINANCEIRAPARCELA).Value, 0) > 0 And GrdContas_SQ_PAGAMENTO <> 0 Then
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

    If objGrid_CalcularTotalColuna(grdContas, GrdContas_ValorImpostoRetido, grdTipoCalculoTotal.SomarValor) > 0 Then
      sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_PGT_IMPOSTORETIDO", False, "@ID_EMPRESA",
                                                                                 "@ID_PAGAMENTO",
                                                                                 "@VL_IMPOSTORETIDO",
                                                                                 "@ID_USUARIO")
      DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                           DBParametro_Montar("ID_PAGAMENTO", iSQ_PAGAMENTO),
                           DBParametro_Montar("VL_IMPOSTORETIDO", objGrid_CalcularTotalColuna(grdContas, GrdContas_ValorImpostoRetido, grdTipoCalculoTotal.SomarValor)),
                           DBParametro_Montar("ID_USUARIO", iID_USUARIO))
    End If

    DBExecutarTransacao()

    RaiseEvent RegerarConsulta()

    bOk = True

    GoTo Sair

Erro:
    DBUsarTransacao = False

Sair:
    Return bOk
  End Function

  Public Sub Grid_Adicionar(iID_CONTAFINANCEIRA As Integer,
                            iID_FORMAPAGAMENTO_PREFERENCIAL As Integer,
                            iSQ_MOVFINANCEIRAPARCELA As Integer,
                            dValorDebito As Double)
    objGrid_Linha_Add(grdFormaPagamento, New Object() {const_GridFormaPagamento_ContaFinanceira, iID_CONTAFINANCEIRA,
                                                       const_GridFormaPagamento_FormaPagamento, iID_FORMAPAGAMENTO_PREFERENCIAL,
                                                       const_GridFormaPagamento_SQ_MOVFINANCEIRAPARCELA, iSQ_MOVFINANCEIRAPARCELA,
                                                       const_GridFormaPagamento_ValorPago, dValorDebito})
  End Sub

  Private Sub grdFormaPagamento_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdFormaPagamento.AfterCellUpdate
    If bEmProcessamento Then Exit Sub

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

    bEmProcessamento = True

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
            .Cells(iGridContas_ValorRestante).Value = CDbl(.Cells(iGridContas_ValorRestante).Value) - vValor
            .Cells(iGridContas_ValorQuitando).Value = CDbl(.Cells(iGridContas_ValorQuitando).Value) + vValor
          End With
          With grdFormaPagamento.Rows(iCont_01)
            .Cells(const_GridFormaPagamento_ValorSaldo).Value = CDbl(.Cells(const_GridFormaPagamento_ValorSaldo).Value) - vValor

            If .Cells(const_GridFormaPagamento_ValorSaldo).Value = 0 Then Exit For
          End With
        End If
      Next
    Next

    bEmProcessamento = False
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

  Private Sub mnuGrid_ComprimirExpandir_Click(sender As Object, e As EventArgs) Handles mnuGrid_ComprimirExpandir.Click
    If pnlControles.Visible Then
      pnlControles.Visible = False
      grdFormaPagamento.Left = 0
      grdFormaPagamento.Top = 0
      grdFormaPagamento.Width = Me.Width
      grdFormaPagamento.Height = Me.Height
      objGrid_Band_AutoAdicionarLinha(grdFormaPagamento, AllowAddNew.FixedAddRowOnTop)
      grdFormaPagamento.DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.CellSelect
    Else
      pnlControles.Visible = True
      grdFormaPagamento.Left = 562
      grdFormaPagamento.Top = 0
      grdFormaPagamento.Width = 220
      grdFormaPagamento.Height = 120
      objGrid_Band_AutoAdicionarLinha(grdFormaPagamento, AllowAddNew.No)
      grdFormaPagamento.DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.RowSelect
    End If
  End Sub

  Private Sub grdFormaPagamento_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdFormaPagamento.BeforeCellActivate
    If pnlControles.Visible Then
      If objGrid_LinhaSelecionada(grdFormaPagamento) <> -1 And pnlControles.Visible Then
        iNRLinha = e.Cell.Row.Index

        With e.Cell.Row
          txtValorPago.Value = .Cells(const_GridFormaPagamento_ValorPago).Value
          ComboBox_Selecionar(cboFormaPagamento, .Cells(const_GridFormaPagamento_FormaPagamento).Value)
          txtValorSaldo.Value = .Cells(const_GridFormaPagamento_ValorSaldo).Value
          ComboBox_Selecionar(cboContaDebito_ContaCredito, .Cells(const_GridFormaPagamento_ContaFinanceira).Value)

          If cboBanco.Visible Then
            ComboBox_Selecionar(cboBanco, .Cells(const_GridFormaPagamento_Banco).Value)
            txtNrAgencia.Value = .Cells(const_GridFormaPagamento_NAgencia).Value
            txtNrConta.Value = .Cells(const_GridFormaPagamento_NConta).Value
            txtNrContaDigito.Value = .Cells(const_GridFormaPagamento_NDigConta).Value
          End If
          If cboDocFinanc_CredPessoa_EncContas.Visible Then
            ComboBox_Selecionar(cboDocFinanc_CredPessoa_EncContas, .Cells(const_GridFormaPagamento_ID_DocumentoFinanceiroCadastrado_CreditoPessoa_EncontroContas).Value)
          End If
          If txtDtDocumento.Enabled Then
            txtDtDocumento.Value = .Cells(const_GridFormaPagamento_DtDocumento).Value
          End If
          If txtDescricaoDocumento.Enabled Then
            txtDescricaoDocumento.Text = .Cells(const_GridFormaPagamento_DescricaoDocumento).Value
          End If
          If opsqEmitente.Enabled Then
            opsqEmitente.ID_Pessoa = .Cells(const_GridFormaPagamento_ID_EMITENTE).Value
          End If
          If txtCodDocumento.Enabled Then
            txtCodDocumento.Text = .Cells(const_GridFormaPagamento_CodigoDocumento).Value
          End If
        End With
      End If
      e.Cancel = True
    End If
  End Sub

  Private Sub grdFormaPagamento_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdFormaPagamento.BeforeRowsDeleted
    e.DisplayPromptMsg = False
  End Sub
End Class