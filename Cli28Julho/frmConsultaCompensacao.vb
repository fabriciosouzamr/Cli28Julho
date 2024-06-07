Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaCompensacao
  Const const_GridListagem_ID_MOVFINANCEIRAPARCELA As Integer = 0
  Const const_GridListagem_ID_PAGAMENTOITEM As Integer = 1
  Const const_GridListagem_ID_OPT_STATUS As Integer = 2
  Const const_GridListagem_Check As Integer = 3
  Const const_GridListagem_CD_MOVIMENTACAO As Integer = 4
  Const const_GridListagem_NO_TIPOMOVFINANCEIRA As Integer = 5
  Const const_GridListagem_NO_CONTAFINANCEIRA_CREDITO As Integer = 6
  Const const_GridListagem_NO_CONTAFINANCEIRA_DEBITO As Integer = 7
  Const const_GridListagem_NO_TIPO_DOCUMENTO As Integer = 8
  Const const_GridListagem_DT_MOVIMENTACAO As Integer = 9
  Const const_GridListagem_NO_PESSOA As Integer = 10
  Const const_GridListagem_VL_PARCELA As Integer = 11
  Const const_GridListagem_CD_DOCUMENTO As Integer = 12
  Const const_GridListagem_DT_DOCUMENTO As Integer = 13
  Const const_GridListagem_DS_BANCO_CONTA As Integer = 14
  Const const_GridListagem_DS_EMITENTE As Integer = 15
  Const const_GridListagem_NO_OPT_STATUS As Integer = 16

  Const const_Tipo_Compensar As Integer = 1
  Const const_Tipo_Compensado As Integer = 2

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String

    sSqlText = "SELECT MVFCP.ID_MOVFINANCEIRAPARCELA," &
                      "MVFCP.ID_PAGAMENTOITEM," &
                      "MVFCP.ID_OPT_STATUS," &
                      "ISNULL(MVFCP.CD_PAGAMENTO, MVFCP.CD_MOVFINANCEIRA)," &
                      "MVFCP.NO_TIPOMOVFINANCEIRA," &
                      "MVFCP.NO_CONTAFINANCEIRA_CREDITO," &
                      "MVFCP.NO_CONTAFINANCEIRA_DEBITO, " &
                      "MVFCP.NO_TIPO_DOCUMENTO," &
                      "MVFCP.DT_PAGAMENTO," &
                      "MVFCP.NO_PESSOA," &
                      "MVFCP.VL_PAGAMENTO," &
                      "MVFCP.CD_DOCUMENTO," &
                      "MVFCP.DT_DOCUMENTO," &
                      "MVFCP.DS_BANCO_CONTA," &
                      "MVFCP.DS_EMITENTE," &
                      "MVFCP.NO_OPT_STATUS" &
               " FROM VW_MOVFINANCEIRA_COMPENSACAO MVFCP" &
               " WHERE MVFCP.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND ID_OPT_TIPOMOVFINANCEIRA_GRUPO = " & enTipoOpcao.TipoMovimentacaoFinanceiraRecebePagar.GetHashCode()

    Select Case cboTipo.SelectedValue
      Case const_Tipo_Compensar
        sSqlText = sSqlText & " AND ID_OPT_STATUS IN (" & enOpcoes.StatusMovimentacaoFinanceira_Compensar.GetHashCode & "," &
                                                          enOpcoes.StatusPagamentoItem_Compensar.GetHashCode & ")"
        sSqlText = sSqlText & " AND ISNULL(IC_COMPENSADO, 'N') = 'N'"
      Case const_Tipo_Compensado
        sSqlText = sSqlText & " AND ISNULL(IC_COMPENSADO, 'N') = 'S'"
      Case Else
        sSqlText = sSqlText & " AND ((ID_OPT_STATUS IN (" & enOpcoes.StatusMovimentacaoFinanceira_Compensar.GetHashCode & "," &
                                                          enOpcoes.StatusPagamentoItem_Compensar.GetHashCode & ") AND " &
                                     "ISNULL(IC_COMPENSADO, 'N') = 'N')" &
                               " OR ISNULL(IC_COMPENSADO, 'N') = 'S')"
    End Select
    If IsDate(txtDataLancamentoInicial.Value) Then
      FNC_Str_Adicionar(sSqlText, "CAST(DT_PAGAMENTO AS DATE) >= " & FNC_QuotedStr(txtDataLancamentoInicial.Text), " AND ")
    End If
    If IsDate(txtDataLancamentoFinal.Value) Then
      FNC_Str_Adicionar(sSqlText, "CAST(DT_PAGAMENTO AS DATE) <= " & FNC_QuotedStr(txtDataLancamentoFinal.Text), " AND ")
    End If
    If IsDate(txtDataDocumentoInicial.Value) Then
      FNC_Str_Adicionar(sSqlText, "CAST(DT_DOCUMENTO AS DATE) >= " & FNC_QuotedStr(txtDataDocumentoInicial.Text), " AND ")
    End If
    If IsDate(txtDataDocumentoFinal.Value) Then
      FNC_Str_Adicionar(sSqlText, "CAST(DT_DOCUMENTO AS DATE) <= " & FNC_QuotedStr(txtDataDocumentoFinal.Text), " AND ")
    End If
    If ComboBox_Selecionado(cboTipoDocumento) Then
      FNC_Str_Adicionar(sSqlText, " ID_TIPO_DOCUMENTO = " & cboTipoDocumento.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboContaBancaria) Then
      FNC_Str_Adicionar(sSqlText, " (ID_CONTAFINANCEIRA_CREDITO = " & cboContaBancaria.SelectedValue &
                                " OR ID_CONTAFINANCEIRA_DEBITO = " & cboContaBancaria.SelectedValue & ")", " AND ")
    End If
    If ComboBox_Selecionado(cboContaCaixa) Then
      FNC_Str_Adicionar(sSqlText, " (ID_CONTAFINANCEIRA_CREDITO = " & cboContaCaixa.SelectedValue &
                                " OR ID_CONTAFINANCEIRA_DEBITO = " & cboContaCaixa.SelectedValue & ")", " AND ")
    End If
    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText, " MVFCP.ID_PESSOA = " & psqPessoa.ID_Pessoa, " AND ")
    End If
    If Trim(txtCodigoDocumento.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText, " MVFCP.CD_DOCUMENTO LIKE " & FNC_SQL_FormatarLike(txtCodigoDocumento.Text), " AND ")
    End If

    sSqlText = sSqlText &
               " ORDER BY DT_PAGAMENTO," &
                         "NO_PESSOA"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_MOVFINANCEIRAPARCELA,
                                                           const_GridListagem_ID_PAGAMENTOITEM,
                                                           const_GridListagem_ID_OPT_STATUS,
                                                           const_GridListagem_CD_MOVIMENTACAO,
                                                           const_GridListagem_NO_TIPOMOVFINANCEIRA,
                                                           const_GridListagem_NO_CONTAFINANCEIRA_CREDITO,
                                                           const_GridListagem_NO_CONTAFINANCEIRA_DEBITO,
                                                           const_GridListagem_NO_TIPO_DOCUMENTO,
                                                           const_GridListagem_DT_MOVIMENTACAO,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_VL_PARCELA,
                                                           const_GridListagem_CD_DOCUMENTO,
                                                           const_GridListagem_DT_DOCUMENTO,
                                                           const_GridListagem_DS_BANCO_CONTA,
                                                           const_GridListagem_DS_EMITENTE,
                                                           const_GridListagem_NO_OPT_STATUS})

    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VL_PARCELA})
  End Sub

  Private Sub frmConsultaCompensacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboContaBancaria, enSql.ContaBancaria)
    ComboBox_Carregar(cboContaCaixa, enSql.ContaCaixa)
    ComboBox_Carregar(cboTipoDocumento, enSql.TipoDocumento)
    ComboBox_Carregar(cboTipo, New String() {"Compensar", "Compensado"},
                               New Object() {const_Tipo_Compensar, const_Tipo_Compensado})
    ComboBox_Selecionar(cboTipo, const_Tipo_Compensar)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_MOVFINANCEIRAPARCELA", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_PAGAMENTOITEM", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdListagem, "..", 50, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdListagem, "Cód da Movimentação", 100)
    objGrid_Coluna_Add(grdListagem, "Tipo de Movimentação", 200)
    objGrid_Coluna_Add(grdListagem, "Conta de Crédito", 200)
    objGrid_Coluna_Add(grdListagem, "Conta de Débito", 200)
    objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 200)
    objGrid_Coluna_Add(grdListagem, "Data da Movimentação", 120, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdListagem, "Nome da Pessoa", 300)
    objGrid_Coluna_Add(grdListagem, "Valor da Movimentação", 140, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Código do Documento", 100)
    objGrid_Coluna_Add(grdListagem, "Data do Documento", 120, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdListagem, "Descrição Conta Bancária", 200)
    objGrid_Coluna_Add(grdListagem, "Emitente", 200)
    objGrid_Coluna_Add(grdListagem, "Status", 80)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    txtDataLancamentoInicial.Value = Nothing
    txtDataLancamentoFinal.Value = Nothing
    txtDataDocumentoInicial.Value = Nothing
    txtDataDocumentoFinal.Value = Nothing

    cmdCompensar.Enabled = FNC_Permissao(enPermissao.FINA_Compensacao).bGravar
  End Sub

  Private Sub cboContaBancaria_KeyDown(sender As Object, e As KeyEventArgs) Handles cboContaBancaria.KeyDown
    If e.KeyCode = Keys.Delete Then cboContaBancaria.SelectedIndex = -1
  End Sub

  Private Sub cboContaCaixa_KeyDown(sender As Object, e As KeyEventArgs) Handles cboContaCaixa.KeyDown
    If e.KeyCode = Keys.Delete Then cboContaCaixa.SelectedIndex = -1
  End Sub

  Private Sub cboTipoDocumento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoDocumento.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoDocumento.SelectedIndex = -1
  End Sub

  Private Sub cmdCompensar_Click(sender As Object, e As EventArgs) Handles cmdCompensar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser compensado")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusPagamentoItem_Negociado.GetHashCode() Then
      FNC_Mensagem("Essa pagamento foi usado em uma negociação, e não pode ser alterado")
      Exit Sub
    End If

    Dim oForm As New frmLancaContasReceberPagar_Compensacao

    AddHandler oForm.Pesquisar, AddressOf Pesquisar

    oForm.cSQ_MOVFINANCEIRAPARCELA = New Collection()
    oForm.cSQ_PAGAMENTOITEM = New Collection()

    For iCont = 0 To grdListagem.Rows.Count - 1
      If objGrid_CheckCol_Valor(grdListagem, const_GridListagem_Check, iCont) = "S" Then
        If objGrid_Valor(grdListagem, const_GridListagem_ID_MOVFINANCEIRAPARCELA, , 0) > 0 Then
          oForm.cSQ_MOVFINANCEIRAPARCELA.Add(objGrid_Valor(grdListagem, const_GridListagem_ID_MOVFINANCEIRAPARCELA, iCont, 0))
        Else
          oForm.cSQ_PAGAMENTOITEM.Add(objGrid_Valor(grdListagem, const_GridListagem_ID_PAGAMENTOITEM, iCont, 0))
        End If
      End If
    Next

    FNC_AbriTela(oForm)
  End Sub

  Private Sub frmConsultaCompensacao_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdCompensar.Left = 5
    cmdCompensar.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdExcel.Top = cmdCompensar.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdCompensar.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cboTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipo.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipo.SelectedIndex = -1
  End Sub

  Private Sub frmConsultaCompensacao_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboContaBancaria.SelectedIndex = -1
    cboContaCaixa.SelectedIndex = -1
    cboTipo.SelectedIndex = -1
    cboTipoDocumento.SelectedIndex = -1
    txtDataDocumentoInicial.Value = Nothing
    txtDataDocumentoFinal.Value = Nothing
    txtDataLancamentoInicial.Value = Nothing
    txtDataLancamentoFinal.Value = Nothing
    txtCodigoDocumento.Text = ""
    psqPessoa.ID_Pessoa = 0
  End Sub

  Private Sub grdListagem_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grdListagem.DoubleClickCell
    cmdCompensar.PerformClick()
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub frmConsultaCompensacao_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.F3 Then
      cmdPesquisar.PerformClick()
    End If
  End Sub
End Class