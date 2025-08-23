Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmLancaContasReceberPagar_Venda
  Public dValorTotal As Double
  Public DescontoMaximo As Double
  Public DescontoMaximoSupervisor As Double
  Public ValorDesconto As Double
  Public iPessoaLiberacaoDesconto As Integer
  Public dVoucher As Double

  Public oLancaContasReceberPagar_Venda As clsLancaContasReceberPagar_Venda()

  Const const_GridParcela_ID_FORMAPAGAMETO As Integer = 0
  Const const_GridParcela_ID_DOCUMENTOFINANCEIRO As Integer = 1
  Const const_GridParcela_ID_OPT_STATUS As Integer = 2
  Const const_GridParcela_ID_EMITENTE As Integer = 3
  Const const_GridParcela_ID_BANCO As Integer = 4
  Const const_GridParcela_ID_TIPODOCUMENTO As Integer = 5
  Const const_GridParcela_ID_CONDICAOPAGAMENTO As Integer = 6
  Const const_GridParcela_FormaPagamento As Integer = 7
  Const const_GridParcela_CondicaoPagamento As Integer = 8
  Const const_GridParcela_CodigoParcela As Integer = 9
  Const const_GridParcela_DataVencimento As Integer = 10
  Const const_GridParcela_ValorParcela As Integer = 11
  Const const_GridParcela_TipoDocumento As Integer = 12
  Const const_GridParcela_CodigoDocumento As Integer = 13
  Const const_GridParcela_Emitente As Integer = 14
  Const const_GridParcela_BTNEmitente As Integer = 15
  Const const_GridParcela_DataDocumento As Integer = 16
  Const const_GridParcela_Banco As Integer = 17
  Const const_GridParcela_NumeroAgencia As Integer = 18
  Const const_GridParcela_NumeroConta As Integer = 19
  Const const_GridParcela_NumeroConta_Digito As Integer = 20
  Const const_GridParcela_DescricaoDocumento As Integer = 21
  Const const_GridParcela_Identificador As Integer = 22
  Const const_GridParcela_TaxaCompensacao As Integer = 23

  Dim oDBParcela As New UltraWinDataSource.UltraDataSource
  Dim bEmProcessamento As Boolean
  Dim sIdentificador As String

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmLancaContasReceberPagar_Venda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    bEmProcessamento = True

    txtValorTotalLancamento.Value = dValorTotal
    txtValorVoucher.Value = dVoucher
    ComboBox_Carregar(cboFormaPagamento, enSql.FormaPagamento)

    objGrid_Inicializar(grdParcela, , oDBParcela, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdParcela, "ID_FORMAPAGAMETO", 0)
    objGrid_Coluna_Add(grdParcela, "ID_DOCUMENTOFINANCEIRO", 0)
    objGrid_Coluna_Add(grdParcela, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdParcela, "ID_EMITENTE", 0)
    objGrid_Coluna_Add(grdParcela, "ID_BANCO", 0)
    objGrid_Coluna_Add(grdParcela, "ID_TIPODOCUMENTO", 0)
    objGrid_Coluna_Add(grdParcela, "ID_CONDICAOPAGAMENTO", 0)
    objGrid_Coluna_Add(grdParcela, "Forma de Pagamento", 200)
    objGrid_Coluna_Add(grdParcela, "Condição de Pagamento", 200)
    objGrid_Coluna_Add(grdParcela, "Cód. Parcela", 100)
    objGrid_Coluna_Add(grdParcela, "Vencimento", 90, , True, ColumnStyle.Date)
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
    objGrid_Coluna_Add(grdParcela, "Identificador", 0)
    objGrid_Coluna_Add(grdParcela, "Taxa de Compensação", 0)

    bEmProcessamento = False

    cmdGravar.Enabled = FNC_Permissao(enPermissao.VEND_ConsultaVenda).bIncluir
  End Sub

  Private Sub cmdAdicionarPagamento_Click(sender As Object, e As EventArgs) Handles cmdAdicionarPagamento.Click
    If Not ComboBox_Selecionado(cboFormaPagamento) Then
      FNC_Mensagem("Selecione a forma de pagamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboCondicaoPagamento) Then
      FNC_Mensagem("Selecione a condição de pagamento")
      Exit Sub
    End If
    If txtQtdeParcela.Value < 1 Then
      FNC_Mensagem("Informe o número de parcelas")
      Exit Sub
    End If
    If txtValorMovimentacao.Value < 0 Then
      FNC_Mensagem("Informe o valor da movimentação")
      Exit Sub
    End If

    Dim iContParcela As Integer
    Dim iContListagem As Integer
    Dim bAchou As Boolean
    Dim dValorParcela As Double
    Dim dValorRestante As Double
    Dim dDataVencimento As Date

    sIdentificador = Guid.NewGuid().ToString()

    For iContParcela = 1 To txtQtdeParcela.Value
      For iContListagem = 0 To grdParcela.Rows.Count - 1
        If cboFormaPagamento.SelectedValue = objGrid_Valor(grdParcela, const_GridParcela_ID_FORMAPAGAMETO, iContListagem) Then
          bAchou = True
          Exit For
        End If
      Next

      If bAchou Then Exit For
    Next

    If bAchou Then
      If FNC_Perguntar("Essa forma de pagamento já foi incluída. Para poder fazer alguns ajustes na mesma precisa excluir as parcelas existentes, deseja continuar?") Then
        bAchou = False
        iContListagem = 0

        Do While True
          If cboFormaPagamento.SelectedValue = objGrid_Valor(grdParcela, const_GridParcela_ID_FORMAPAGAMETO, iContListagem) Then
            grdParcela.Rows(iContListagem).Delete()
          Else
            iContListagem = iContListagem + 1
          End If
        Loop
      End If
    End If

    If Not bAchou Then
      dValorRestante = txtValorMovimentacao.Value
      dValorParcela = Math.Round(txtValorMovimentacao.Value / txtQtdeParcela.Value, 2)

      For iContParcela = 1 To txtQtdeParcela.Value
        If iContParcela = txtQtdeParcela.Value Then
          dValorParcela = dValorRestante
        Else
          dValorRestante = dValorRestante - dValorParcela
        End If
        If iContParcela = 1 Then
          dDataVencimento = DateTime.Now

          If cboCondicaoPagamento.SelectedItem(enComboBox_CondicaoPagamento.IC_GERAR_AVISTA) = "N" Then
            dDataVencimento = dDataVencimento.AddDays(cboCondicaoPagamento.SelectedItem(enComboBox_CondicaoPagamento.QT_PARCELA_DIASINTERVALO))
          End If
        Else
          dDataVencimento = dDataVencimento.AddDays(cboCondicaoPagamento.SelectedItem(enComboBox_CondicaoPagamento.QT_PARCELA_DIASINTERVALO))
        End If

        objGrid_Linha_Add(grdParcela, New Object() {const_GridParcela_ID_FORMAPAGAMETO, cboFormaPagamento.SelectedValue,
                                                    const_GridParcela_ID_OPT_STATUS, enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode(),
                                                    const_GridParcela_ID_TIPODOCUMENTO, cboFormaPagamento.SelectedItem(enComboBox_FormaPagamento.ID_TIPO_DOCUMENTO),
                                                    const_GridParcela_ID_CONDICAOPAGAMENTO, cboCondicaoPagamento.SelectedValue,
                                                    const_GridParcela_FormaPagamento, cboFormaPagamento.Text,
                                                    const_GridParcela_CondicaoPagamento, cboCondicaoPagamento.Text,
                                                    const_GridParcela_CodigoParcela, FNC_StrZero(iContParcela, 3) + "/" + FNC_StrZero(txtQtdeParcela.Value, 3),
                                                    const_GridParcela_DataVencimento, dDataVencimento,
                                                    const_GridParcela_ValorParcela, dValorParcela,
                                                    const_GridParcela_TipoDocumento, cboFormaPagamento.SelectedItem(enComboBox_FormaPagamento.NO_TIPO_DOCUMENTO),
                                                    const_GridParcela_CodigoDocumento, "",
                                                    const_GridParcela_Identificador, sIdentificador,
                                                    const_GridParcela_TaxaCompensacao, FNC_NVL(cboCondicaoPagamento.SelectedItem(enComboBox_CondicaoPagamento.PC_TAXA_COMPENSACAO), 0)})
      Next

      CalcularValorTotalAdicionado()
    End If

    bEmProcessamento = True
    cboFormaPagamento.SelectedIndex = -1
    cboCondicaoPagamento.DataSource = Nothing
    txtQtdeParcela.Value = 1
    txtValorMovimentacao.Value = 0
    bEmProcessamento = False
  End Sub

  Private Sub CalcularValorTotalAdicionado()
    txtValorTotalAdicionado.Value = objGrid_CalcularTotalColuna(grdParcela, const_GridParcela_ValorParcela)
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Math.Round(txtValorTotalAPagar.Value, 2) <> txtValorTotalAdicionado.Value Then
      FNC_Mensagem("O valor total lançado é menor que o valor total da movimentação")
      Exit Sub
    End If
    If grdParcela.Rows.Count = 0 And txtValorVoucher.Value = 0 Then
      FNC_Mensagem("Não foi lançado nenhuma forma de pagamento")
      Exit Sub
    End If

    If Math.Round(txtValorDesconto.Value + txtValorDescontoSupervisor.Value, 2) >
       Math.Round(FNC_Porcentagem(txtValorTotalLancamento.Value, FNC_MaiorNumero(DescontoMaximo, DescontoMaximoSupervisor)), 2) Then
      FNC_Mensagem("Valor informado para desconto é maior que o permitido")
      Exit Sub
    End If

    ReDim oLancaContasReceberPagar_Venda(grdParcela.Rows.Count - 1)

    Dim iCont As Integer

    ValorDesconto = txtValorDesconto.Value + txtValorDescontoSupervisor.Value

    If grdParcela.Rows.Count > 0 Then
      For iCont = 0 To grdParcela.Rows.Count - 1
        oLancaContasReceberPagar_Venda(iCont) = New clsLancaContasReceberPagar_Venda
        With oLancaContasReceberPagar_Venda(iCont)
          .ID_FORMAPAGAMETO = objGrid_Valor(grdParcela, const_GridParcela_ID_FORMAPAGAMETO, iCont)
          .ID_DOCUMENTOFINANCEIRO = 0
          .ID_OPT_STATUS = enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode()
          .ID_BANCO = objGrid_Valor(grdParcela, const_GridParcela_ID_BANCO, iCont, 0)
          .ID_EMITENTE = objGrid_Valor(grdParcela, const_GridParcela_ID_EMITENTE, iCont, 0)
          .ID_TIPODOCUMENTO = objGrid_Valor(grdParcela, const_GridParcela_ID_TIPODOCUMENTO, iCont, 0)
          .ID_CONDICAOPAGAMENTO = objGrid_Valor(grdParcela, const_GridParcela_ID_CONDICAOPAGAMENTO, iCont, 0)
          .CodigoParcela = objGrid_Valor(grdParcela, const_GridParcela_CodigoParcela, iCont, "")
          .DataVencimento = objGrid_Valor(grdParcela, const_GridParcela_DataVencimento, iCont)
          .ValorParcela = Val(objGrid_Valor(grdParcela, const_GridParcela_ValorParcela, iCont, 0))
          .CodigoDocumento = objGrid_Valor(grdParcela, const_GridParcela_CodigoDocumento, iCont, "")
          .DataDocumento = objGrid_Valor(grdParcela, const_GridParcela_DataDocumento, iCont, DateTime.Now)
          .NumeroAgencia = objGrid_Valor(grdParcela, const_GridParcela_NumeroAgencia, iCont, 0)
          .NumeroConta = objGrid_Valor(grdParcela, const_GridParcela_NumeroConta, iCont, 0)
          .NumeroConta_Digito = objGrid_Valor(grdParcela, const_GridParcela_NumeroConta_Digito, iCont, 0)
          .DescricaoDocumento = objGrid_Valor(grdParcela, const_GridParcela_DescricaoDocumento, iCont, "")
          .TaxaCompensacao = Val(objGrid_Valor(grdParcela, const_GridParcela_TaxaCompensacao, iCont, 0))
        End With
      Next
    ElseIf txtValorVoucher.Value > 0 Then
      ReDim oLancaContasReceberPagar_Venda(0)

      oLancaContasReceberPagar_Venda(0) = New clsLancaContasReceberPagar_Venda
      With oLancaContasReceberPagar_Venda(0)
        .ID_FORMAPAGAMETO = 0
        .ID_DOCUMENTOFINANCEIRO = 0
        .ID_OPT_STATUS = enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode()
        .ID_BANCO = 0
        .ID_EMITENTE = 0
        .ID_TIPODOCUMENTO = 0
        .ID_CONDICAOPAGAMENTO = 0
        .CodigoParcela = "01/01"
        .DataVencimento = DateTime.Now
        .ValorParcela = txtValorVoucher.Value
      End With
    End If

    Close()
  End Sub

  Private Sub cboFormaPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormaPagamento.SelectedIndexChanged
    cboCondicaoPagamento.DataSource = Nothing
    If Not bEmProcessamento Then
      bEmProcessamento = True
      ComboBox_Carregar(cboCondicaoPagamento, enSql.CondicaoPagamento_Venda, New Object() {FNC_NuloZero(cboFormaPagamento.SelectedValue)})
      bEmProcessamento = False
    End If
  End Sub

  Private Sub cboCondicaoPagamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCondicaoPagamento.SelectedIndexChanged
    If Not bEmProcessamento Then
      If ComboBox_Selecionado(cboCondicaoPagamento) Then
        txtQtdeParcela.MinValue = 0
        txtQtdeParcela.Value = cboCondicaoPagamento.SelectedItem(enComboBox_CondicaoPagamento.QT_PARCELA)

        If cboCondicaoPagamento.SelectedItem(enComboBox_CondicaoPagamento.IC_GERAR_AVISTA) = "S" Then
          txtQtdeParcela.Value = txtQtdeParcela.Value + 1
        End If

        If txtQtdeParcela.Value = 0 Then
          txtQtdeParcela.Value = 1
        End If
      End If
    End If
  End Sub

  Private Sub grdParcela_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdParcela.AfterCellUpdate
    If e.Cell.Column.Index = const_GridParcela_ValorParcela Then
      CalcularValorTotalAdicionado()
    End If
  End Sub

  Private Sub txtValorTotalAdicionado_ValueChanged(sender As Object, e As EventArgs) Handles txtValorTotalAdicionado.ValueChanged
    CalcularTotalAPagar()
  End Sub

  Private Sub CalcularTotalAPagar()
    Try
      txtValorTotalAPagar.Value = txtValorTotalLancamento.Value - txtValorDesconto.Value - txtValorDescontoSupervisor.Value - txtValorVoucher.Value

      lblValorPendenteLancado.Text = lblValorPendenteLancado.Tag.ToString().Trim() & " " & Math.Round(txtValorTotalLancamento.Value - txtValorTotalAdicionado.Value - txtValorDesconto.Value - txtValorVoucher.Value, 2)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub txtValorDesconto_ValueChanged(sender As Object, e As EventArgs) Handles txtValorDesconto.ValueChanged
    CalcularTotalAPagar()
  End Sub

  Private Sub cmdValidarDesconto_Click(sender As Object, e As EventArgs) Handles cmdValidarDesconto.Click
    Dim oForm As New frmLancaContasReceberPagar_Venda_Desconto

    oForm.ValorTotal = dValorTotal

    FNC_AbriTela(oForm, , True, True)

    If oForm.Autorizado Then
      iPessoaLiberacaoDesconto = oForm.iPessoaLiberacaoDesconto
      DescontoMaximoSupervisor = oForm.PcDesconto
      txtValorDescontoSupervisor.Value = oForm.ValorDesconto
    End If
  End Sub

  Private Sub txtValorTotalLancamento_ValueChanged(sender As Object, e As EventArgs) Handles txtValorTotalLancamento.ValueChanged
    CalcularTotalAPagar()
  End Sub

  Private Sub grdParcela_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdParcela.BeforeRowsDeleted
    If e.DisplayPromptMsg Then
      e.DisplayPromptMsg = False

      If Not FNC_Perguntar("Deseja excluir a forma de pagamento " & e.Rows(0).Cells(const_GridParcela_FormaPagamento).Value) Then
        e.Cancel = True
      Else
        sIdentificador = e.Rows(0).Cells(const_GridParcela_Identificador).Value
      End If
    End If
  End Sub

  Private Sub grdParcela_AfterRowsDeleted(sender As Object, e As EventArgs) Handles grdParcela.AfterRowsDeleted
    Dim iCont As Integer = 0

    Do While iCont <= grdParcela.Rows.Count - 1
      If grdParcela.Rows(iCont).Cells(const_GridParcela_Identificador).Value = sIdentificador Then
        grdParcela.Rows(iCont).Delete(False)
      Else
        iCont = iCont + 1
      End If
    Loop

    CalcularValorTotalAdicionado()
  End Sub

  Private Sub txtValorVoucher_ValueChanged(sender As Object, e As EventArgs) Handles txtValorVoucher.ValueChanged
    CalcularTotalAPagar()
  End Sub

  Private Sub txtValorDescontoSupervisor_ValueChanged(sender As Object, e As EventArgs) Handles txtValorDescontoSupervisor.ValueChanged
    CalcularTotalAPagar()
  End Sub
End Class