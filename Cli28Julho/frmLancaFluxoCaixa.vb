Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmLancaFluxoCaixa
  Const const_GridPlanoContas_PlanoContas As Integer = 0
  Const const_GridPlanoContas_Participacao As Integer = 1
  Const const_GridPlanoContas_Comentario As Integer = 2

  Public iSQ_MOVFINANCEIRA As Integer

  Dim oDBPlanoContas_Credito As New UltraWinDataSource.UltraDataSource
  Dim oDBPlanoContas_Debito As New UltraWinDataSource.UltraDataSource

  Private Sub frmLancaFluxoCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdPlanoContas_Credito, AllowAddNew.FixedAddRowOnTop, oDBPlanoContas_Credito, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdPlanoContas_Credito, "Plano de Contas", 230, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContas_Credito))
    objGrid_Coluna_Add(grdPlanoContas_Credito, "Participação (%)", 120, , True, ColumnStyle.DoublePositive)
    objGrid_Coluna_Add(grdPlanoContas_Credito, "Comentário", 300, , True)
    objGrid_Configuracao_Carregar(grdPlanoContas_Credito, Me.Name)

    objGrid_Inicializar(grdPlanoContas_Debito, AllowAddNew.FixedAddRowOnTop, oDBPlanoContas_Debito, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdPlanoContas_Debito, "Plano de Contas", 230, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContas_Debito))
    objGrid_Coluna_Add(grdPlanoContas_Debito, "Participação (%)", 120, , True, ColumnStyle.DoublePositive)
    objGrid_Coluna_Add(grdPlanoContas_Debito, "Comentário", 300, , True)
    objGrid_Configuracao_Gravar(grdPlanoContas_Debito, Me.Name)

    ComboBox_Carregar(cboTipoMovimentacao, enSql.TipoMovimentacaoFinanceiraContas)
    ComboBox_Carregar(cboTipoDocumento, enSql.TipoDocumento_FluxoCaixa)

    If cboTipoDocumento.Items.Count = 1 Then
      lblR_TipoDocumento.Visible = False
      cboTipoDocumento.Visible = False
      cboTipoDocumento.SelectedIndex = 0
    End If

    ComboBox_Selecionar(cboTipoMovimentacao, enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Credito.GetHashCode)
    LimparTela()

    cmdNovo.Enabled = FNC_Permissao(enPermissao.FINA_LançamentoemContasCaixaContaBancaria).bIncluir Or FNC_Permissao(enPermissao.FINA_ConsuladeLançamentoEmContasCaixaContaBancaria).bGravar
    cmdGravar.Enabled = FNC_Permissao(enPermissao.FINA_LançamentoemContasCaixaContaBancaria).bGravar Or FNC_Permissao(enPermissao.FINA_ConsuladeLançamentoEmContasCaixaContaBancaria).bGravar
  End Sub

  Private Sub cboTipoMovimentacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoMovimentacao.SelectedIndexChanged
    ComboTipoMovimentacao_Tratar()
  End Sub

  Private Sub ComboTipoMovimentacao_Tratar()
    Dim bContaCaixa_Credito As Boolean
    Dim bContaCaixa_Debito As Boolean
    Dim bContaBancaria_Credito As Boolean
    Dim bContaBancaria_Debito As Boolean

    'Habilita os planos de contas utilizados
    lblTotalParticipacao.Text = "Total de Participação:  0.00%"
    oDBPlanoContas_Credito.Rows.Clear()
    oDBPlanoContas_Debito.Rows.Clear()
    lblRPlanoContasDebito.Enabled = True
    grdPlanoContas_Debito.Enabled = True
    lblRPlanoContasCredito.Enabled = True
    grdPlanoContas_Credito.Enabled = True

    Select Case cboTipoMovimentacao.SelectedValue
      Case enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Credito.GetHashCode,
           enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Credito.GetHashCode
        lblRPlanoContasDebito.Enabled = False
        grdPlanoContas_Debito.Enabled = False
      Case enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Debito.GetHashCode,
           enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Debito.GetHashCode
        lblRPlanoContasCredito.Enabled = False
        grdPlanoContas_Credito.Enabled = False
        'Case enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Transferencia.GetHashCode,
        '     enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_EnvioDepositoContaBancaria.GetHashCode,
        '     enOpcoes.TipoMovimentacaoFinanceiraOutros_ContaBancaria_SaqueAporteContaCaixa.GetHashCode,
        '     enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Transferencia.GetHashCode
        '  lblRPlanoContasDebito.Enabled = False
        '  grdPlanoContas_Debito.Enabled = False
        '  lblRPlanoContasCredito.Enabled = False
        '  grdPlanoContas_Credito.Enabled = False
    End Select

    'Trata os campos de contas
    lblR_ContaCredito.Text = "Conta de Crédito"
    lblR_ContaCredito.Enabled = False
    cboContaCredito.Enabled = False
    cboContaCredito.DataSource = Nothing
    lblR_ContaDebito.Text = "Conta de Débito"
    lblR_ContaDebito.Enabled = False
    cboContaDebito.Enabled = False
    cboContaDebito.DataSource = Nothing

    bContaCaixa_Credito = (cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Credito.GetHashCode Or
                           cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Transferencia.GetHashCode Or
                           cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraOutros_ContaBancaria_SaqueAporteContaCaixa.GetHashCode)
    bContaCaixa_Debito = (cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Debito.GetHashCode Or
                          cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_EnvioDepositoContaBancaria.GetHashCode Or
                          cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Transferencia.GetHashCode)

    bContaBancaria_Credito = (cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Credito.GetHashCode Or
                              cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_EnvioDepositoContaBancaria.GetHashCode Or
                              cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Transferencia.GetHashCode)
    bContaBancaria_Debito = (cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Debito.GetHashCode Or
                             cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Transferencia.GetHashCode Or
                             cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraOutros_ContaBancaria_SaqueAporteContaCaixa.GetHashCode)

    If bContaCaixa_Credito Then
      lblR_ContaCredito.Text = "Conta Caixa de Crédito"
      ComboBox_Carregar(cboContaCredito, enSql.ContaCaixa, New Object() {iID_USUARIO})
    End If
    If bContaCaixa_Debito Then
      lblR_ContaDebito.Text = "Conta Caixa de Débito"
      ComboBox_Carregar(cboContaDebito, enSql.ContaCaixa, New Object() {iID_USUARIO})
    End If
    If bContaBancaria_Credito Then
      lblR_ContaCredito.Text = "Conta Bancária de Crédito"
      ComboBox_Carregar(cboContaCredito, enSql.ContaBancaria)
    End If
    If bContaBancaria_Debito Then
      lblR_ContaDebito.Text = "Conta Bancária de Débito"
      ComboBox_Carregar(cboContaDebito, enSql.ContaBancaria)
    End If

    lblR_ContaCredito.Enabled = (bContaCaixa_Credito Or bContaBancaria_Credito)
    cboContaCredito.Enabled = (bContaCaixa_Credito Or bContaBancaria_Credito)
    lblR_ContaDebito.Enabled = (bContaCaixa_Debito Or bContaBancaria_Debito)
    cboContaDebito.Enabled = (bContaCaixa_Debito Or bContaBancaria_Debito)

    lblSaldoContaDebito.Text = "R$ 0.00"
    lblSaldoContaCredito.Text = "R$ 0.00"
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cboContaCredito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContaCredito.SelectedIndexChanged
    If cboContaCredito.SelectedIndex = -1 Then
      lblSaldoContaCredito.Text = "R$ 0.00"
    Else
      lblSaldoContaCredito.Text = FormatCurrency(DBQuery_ValorUnico("SELECT ISNULL(VL_SALDO, 0) FROM TB_CONTAFINANCEIRA WHERE SQ_CONTAFINANCEIRA = " & cboContaCredito.SelectedValue, 0))
    End If
  End Sub

  Private Sub cboContaDebito_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContaDebito.SelectedIndexChanged
    If cboContaDebito.SelectedIndex = -1 Then
      lblSaldoContaDebito.Text = "R$ 0.00"
    Else
      lblSaldoContaDebito.Text = FormatCurrency(DBQuery_ValorUnico("SELECT ISNULL(VL_SALDO, 0) FROM TB_CONTAFINANCEIRA WHERE SQ_CONTAFINANCEIRA = " & cboContaDebito.SelectedValue, 0))
    End If
  End Sub

  Private Sub grdPlanoContas_Credito_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdPlanoContas_Credito.AfterCellUpdate
    GridPlanoContas_CalcularParticipacao()
  End Sub

  Private Sub grdPlanoContas_Debito_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdPlanoContas_Debito.AfterCellUpdate
    GridPlanoContas_CalcularParticipacao()
  End Sub

  Private Sub GridPlanoContas_CalcularParticipacao()
    If grdPlanoContas_Debito.Enabled And grdPlanoContas_Credito.Enabled Then
      lblTotalParticipacao.Text = "Total de Participação: " & objGrid_CalcularTotalColuna(grdPlanoContas_Debito, const_GridPlanoContas_Participacao) & "% / " &
                                                              objGrid_CalcularTotalColuna(grdPlanoContas_Credito, const_GridPlanoContas_Participacao) & "%"
    ElseIf grdPlanoContas_Debito.Enabled Then
      lblTotalParticipacao.Text = "Total de Participação: " & objGrid_CalcularTotalColuna(grdPlanoContas_Debito, const_GridPlanoContas_Participacao) & "%"
    ElseIf grdPlanoContas_Credito.Enabled Then
      lblTotalParticipacao.Text = "Total de Participação: " & objGrid_CalcularTotalColuna(grdPlanoContas_Credito, const_GridPlanoContas_Participacao) & "%"
    End If

    lblTotalParticipacao.Tag = objGrid_CalcularTotalColuna(grdPlanoContas_Debito, const_GridPlanoContas_Participacao) +
                               objGrid_CalcularTotalColuna(grdPlanoContas_Credito, const_GridPlanoContas_Participacao)
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboTipoMovimentacao) Then
      FNC_Mensagem("Selecione o tipo de movimentação")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoDocumento) Then
      FNC_Mensagem("Selecione o tipo de documento")
      Exit Sub
    End If
    If Not IsDate(txtData.Value) Then
      FNC_Mensagem("Informe a data da movimentação")
      Exit Sub
    End If
    If txtValorMovimentacao.Value <= 0 Then
      FNC_Mensagem("Informe um valor maior que zero para a movimentação")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim bContaCaixa_Credito As Boolean
    Dim bContaCaixa_Debito As Boolean
    Dim bContaBancaria_Credito As Boolean
    Dim bContaBancaria_Debito As Boolean
    Dim iSQ_MOVFINANCEIRAPARCELA As Integer = 0
    Dim iSQ_DOCUMENTOFINANCEIRO As Integer = 0
    Dim eOPT_Status As enOpcoes = enOpcoes.StatusMovimentacaoFinanceira_Quitada.GetHashCode

    bContaCaixa_Credito = (cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Credito.GetHashCode Or
                           cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Transferencia.GetHashCode Or
                           cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraOutros_ContaBancaria_SaqueAporteContaCaixa.GetHashCode)
    bContaCaixa_Debito = (cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Debito.GetHashCode Or
                          cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_EnvioDepositoContaBancaria.GetHashCode Or
                          cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_Transferencia.GetHashCode)

    bContaBancaria_Credito = (cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Credito.GetHashCode Or
                              cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaCaixa_EnvioDepositoContaBancaria.GetHashCode Or
                              cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Transferencia.GetHashCode)
    bContaBancaria_Debito = (cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Debito.GetHashCode Or
                             cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Transferencia.GetHashCode Or
                             cboTipoMovimentacao.SelectedValue = enOpcoes.TipoMovimentacaoFinanceiraOutros_ContaBancaria_SaqueAporteContaCaixa.GetHashCode)

    If bContaCaixa_Debito And cboContaDebito.SelectedIndex = -1 Then
      FNC_Mensagem("Selecione a conta caixa de débito")
      Exit Sub
    End If
    If bContaCaixa_Credito And cboContaCredito.SelectedIndex = -1 Then
      FNC_Mensagem("Selecione a conta caixa de crédito")
      Exit Sub
    End If
    If bContaBancaria_Debito And cboContaDebito.SelectedIndex = -1 Then
      FNC_Mensagem("Selecione a conta bancária de débito")
      Exit Sub
    End If
    If bContaBancaria_Credito And cboContaCredito.SelectedIndex = -1 Then
      FNC_Mensagem("Selecione a conta bancária de crédito")
      Exit Sub
    End If
    If Trim(txtJustificativa.Text) = "" Then
      FNC_Mensagem("Informe a justificativa da movimentação")
      Exit Sub
    End If
    If FNC_NVL(cboContaCredito.SelectedValue, 0) = FNC_NVL(cboContaDebito.SelectedValue, 0) Then
      FNC_Mensagem("A conta de débito não pode ser igual a conta de crédito")
      Exit Sub
    End If
    If grdPlanoContas_Credito.Enabled Or grdPlanoContas_Debito.Enabled Then
      If lblTotalParticipacao.Tag <> 100 And lblTotalParticipacao.Tag <> 200 Then
        If grdPlanoContas_Credito.Enabled And grdPlanoContas_Debito.Enabled Then
          FNC_Mensagem("É preciso fazer o rateio entre os planos de contas de crédito e débito")
        ElseIf grdPlanoContas_Credito.Enabled Then
          FNC_Mensagem("É preciso fazer o rateio nos planos de contas de crédito")
        ElseIf grdPlanoContas_Debito.Enabled Then
          FNC_Mensagem("É preciso fazer o rateio nos planos de contas de débito")
        End If
        Exit Sub
      End If
    End If
    If FNC_NVL(cboTipoDocumento.SelectedItem(enComboBox_TipoDocumento.IC_CADASTRAR_DOCUMENTO), "N") = "S" Then
      If (bContaBancaria_Debito Or bContaCaixa_Debito) And Not ComboBox_Selecionado(cboDocumentoFinanceiro) Then
        FNC_Mensagem("É preciso selecionar o documento financeiro da transferência")
        Exit Sub
      Else
        Dim oForm As New frmCadastroDocumentoFinanceiro

        oForm.iSQ_TIPO_DOCUMENTO = cboTipoDocumento.SelectedValue
        oForm.dVL_DOCUMENTO = txtValorMovimentacao.Value
        oForm.bFecharTela = True

        FNC_AbriTela(oForm, , True, True)

        iSQ_DOCUMENTOFINANCEIRO = oForm.iSQ_DOCUMENTOFINANCEIRO

        oForm.Dispose()

        If iSQ_DOCUMENTOFINANCEIRO = 0 Then
          FNC_Mensagem("É preciso cadastrar o documento financeiro")
          Exit Sub
        End If
      End If
    End If

    Try
      If iSQ_MOVFINANCEIRA > 0 Then
        sSqlText = "SELECT SQ_MOVFINANCEIRAPARCELA FROM TB_MOVFINANCEIRAPARCELA WHERE ID_MOVFINANCEIRA = " & iSQ_MOVFINANCEIRA
        iSQ_MOVFINANCEIRAPARCELA = DBQuery_ValorUnico(sSqlText)
      End If

      If FNC_NVL(cboTipoDocumento.SelectedItem(enComboBox_TipoDocumento.IC_COMPENSAR), "N") = "S" Then
        eOPT_Status = enOpcoes.StatusMovimentacaoFinanceira_Compensar
      End If

      If FormCadastroMovimentacaoFinanceira(iSQ_MOVFINANCEIRA:=iSQ_MOVFINANCEIRA,
                                            eID_OPT_TIPOMOVFINANCEIRA:=cboTipoMovimentacao.SelectedValue,
                                            eID_OPT_STATUS:=eOPT_Status,
                                            eID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO:=0,
                                            eID_OPT_PERIODOCALCULOFINANCEIRO_JUROS:=0,
                                            iID_PESSOA:=0,
                                            iID_CONTAFINANCERIA_CREDITO:=IIf(bContaBancaria_Credito Or bContaCaixa_Credito, cboContaCredito.SelectedValue, 0),
                                            iID_CONTAFINANCERIA_DEBITO:=IIf(bContaBancaria_Debito Or bContaCaixa_Debito, cboContaDebito.SelectedValue, 0),
                                            iID_DOCUMENTOFISCAL:=0,
                                            iID_PEDIDO:=0,
                                            iID_ORDEMSERVICO:=0,
                                            iID_SEGMENTO:=0,
                                            iID_CONDICAOPAGAMENTO:=0,
                                            iID_CLINICA_VENDA:=0,
                                            iID_CONVENIO:=0,
                                            sDS_MOVFINANCEIRA:=Trim(txtJustificativa.Text),
                                            dVL_MOVFINANCEIRA:=txtValorMovimentacao.Value,
                                            dVL_ORIGINAL:=txtValorMovimentacao.Value,
                                            dVL_DESCONTO:=0,
                                            dDT_MOVIMENTACAO:=txtData.Value,
                                            dDT_1_VENCIMENTO:=txtData.Value,
                                            dPC_ENTRADA:=0,
                                            dPC_JUROS:=0,
                                            dPC_DESCONTO:=0,
                                            dVL_MULTA:=0,
                                            dPC_MULTA:=0,
                                            sCM_MOVFINANCEIRA:=txtComentario.Text) Then
        If FormCadastroMovimentacaoFinanceiraParcela(iSQ_MOVFINANCEIRAPARCELA:=iSQ_MOVFINANCEIRAPARCELA,
                                                     iID_MOVFINANCEIRA:=iSQ_MOVFINANCEIRA,
                                                     eID_OPT_STATUS:=eOPT_Status,
                                                     iID_TIPO_DOCUMENTO:=cboTipoDocumento.SelectedValue,
                                                     iID_MOVFINANCEIRAPARCELAORIGEM:=0,
                                                     iID_DOCUMENTOFINANCEIRO:=iSQ_DOCUMENTOFINANCEIRO,
                                                     iID_FORMAPAGAMENTO_PREFERENCIAL:=0,
                                                     iID_CONDICAOPAGAMENTO:=0,
                                                     sCD_PARCELA:="001/001",
                                                     sCD_DOCUMENTO:=txtCodigoDocumento.Text,
                                                     sCM_DOCUMENTO:=Nothing,
                                                     sDS_EMITENTE:=Nothing,
                                                     dDT_VENCIMENTO:=txtData.Value,
                                                     dDT_QUITACAO:=txtData.Value,
                                                     dVL_PARCELA:=txtValorMovimentacao.Value,
                                                     dVL_JUROS:=0,
                                                     dVL_DESCONTO:=0,
                                                     dVL_QUITADO:=txtValorMovimentacao.Value,
                                                     dVL_PROVISAO:=0,
                                                     dPC_TAXA_COMPENSACAO:=0,
                                                     dVL_IMPOSTORETIDO:=0) Then
          If FNC_NVL(cboTipoDocumento.SelectedItem(enComboBox_TipoDocumento.IC_COMPENSAR), "N") = "N" Then
            'Inclusão no Fluxo de Caixa
            FormMovimentacaoFinanceira_Compensacao_Gravar(iSQ_MOVFINANCEIRAPARCELA,
                                                          IIf(bContaBancaria_Credito Or bContaCaixa_Credito, cboContaCredito.SelectedValue, cboContaDebito.SelectedValue),
                                                          txtData.DateTime.Date, txtValorMovimentacao.Value, "")
          End If
        Else
          GoTo Erro
        End If

        '>> Gravação de plano de contas
        'Exclusão de plano de contas
        sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_PLANOCONTAS_DEL", False, "@ID_MOVFINANCEIRA",
                                                                          "@ID_PLANOCONTAS")
        DBExecutar(sSqlText, DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                             DBParametro_Montar("ID_PLANOCONTAS", 0))

        'Inclusão de plano de contas
        sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_PLANOCONTAS_CAD", False, "@ID_MOVFINANCEIRA",
                                                                          "@ID_PLANOCONTAS",
                                                                          "@ID_OPT_CREDITODEBITO",
                                                                          "@PC_PARTICIPACAO",
                                                                          "@CM_PARTICIPACAO")

        For iCont = 0 To grdPlanoContas_Credito.Rows.Count - 1
          With grdPlanoContas_Credito.Rows(iCont)
            DBExecutar(sSqlText, DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                                   DBParametro_Montar("ID_PLANOCONTAS", .Cells(const_GridPlanoContas_PlanoContas).Value),
                                   DBParametro_Montar("ID_OPT_CREDITODEBITO", enOpcoes.CreditoDebito_Credito.GetHashCode),
                                   DBParametro_Montar("PC_PARTICIPACAO", FNC_ConvValorFormatoAmericano(.Cells(const_GridPlanoContas_Participacao).Value)),
                                   DBParametro_Montar("CM_PARTICIPACAO", .Cells(const_GridPlanoContas_Comentario).Value,,, const_BancoDados_TamanhoComentario))
          End With
        Next

        For iCont = 0 To grdPlanoContas_Debito.Rows.Count - 1
          With grdPlanoContas_Debito.Rows(iCont)
            DBExecutar(sSqlText, DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                                 DBParametro_Montar("ID_PLANOCONTAS", .Cells(const_GridPlanoContas_PlanoContas).Value),
                                 DBParametro_Montar("ID_OPT_CREDITODEBITO", enOpcoes.CreditoDebito_Debito.GetHashCode),
                                 DBParametro_Montar("PC_PARTICIPACAO", FNC_ConvValorFormatoAmericano(.Cells(const_GridPlanoContas_Participacao).Value)),
                                 DBParametro_Montar("CM_PARTICIPACAO", .Cells(const_GridPlanoContas_Comentario).Value,,, const_BancoDados_TamanhoComentario))
          End With
        Next

        FNC_Mensagem("Lançamento Efetuado")
      Else
        GoTo Erro
      End If

      cmdNovo.PerformClick()
    Catch ex As Exception
      GoTo Erro
    End Try

    Exit Sub

Erro:
    DBUsarTransacao = False
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    LimparTela()
  End Sub

  Private Sub LimparTela()
    iSQ_MOVFINANCEIRA = 0
    cboTipoMovimentacao.SelectedIndex = 0
    txtData.Value = Now.Date
    cboContaCredito.SelectedIndex = -1
    cboContaDebito.SelectedIndex = -1
    txtJustificativa.Text = ""
    txtValorMovimentacao.Value = 0
    txtComentario.Text = ""
    If cboTipoDocumento.Visible Then cboTipoDocumento.SelectedIndex = -1
    cboDocumentoFinanceiro.DataSource = Nothing
    txtCodigoDocumento.Text = ""
    oDBPlanoContas_Credito.Rows.Clear()
    oDBPlanoContas_Debito.Rows.Clear()
  End Sub

  Private Sub frmLancaFluxoCaixa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    objGrid_Configuracao_Gravar(grdPlanoContas_Credito, Me.Name)
    objGrid_Configuracao_Gravar(grdPlanoContas_Debito, Me.Name)
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If iSQ_MOVFINANCEIRA = 0 Then
      FNC_Mensagem("Movimentação não gravada")
    Else
      FormRelatorioFinanceiro_Comprovante_Transferencia(iSQ_MOVFINANCEIRA)
    End If
  End Sub
End Class