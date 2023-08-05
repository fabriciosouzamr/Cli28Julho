Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports eDbType

Public Class frmLancaContasReceberPagar_Quitar_Exclusao
  Const const_GridPagamento_ID_PAGAMENTO As Integer = 0
  Const const_GridPagamento_CD_PAGAMENTO As Integer = 1
  Const const_GridPagamento_VL_PAGAMENTO As Integer = 2
  Const const_GridPagamento_DT_PAGAMENTO As Integer = 3
  Const const_GridPagamento_NO_OPT_STATUS_PAGAMENTO As Integer = 4
  Const const_GridPagamento_NO_OPT_TIPOMOVFINANCEIRA As Integer = 5

  Const const_GridItem_CD_PARCELA As Integer = 0
  Const const_GridItem_CD_DOCUMENTO As Integer = 1
  Const const_GridItem_DT_MOVIMENTACAO As Integer = 2
  Const const_GridItem_DT_QUITACAO As Integer = 3
  Const const_GridItem_NO_PESSOA As Integer = 4
  Const const_GridItem_DS_MOVFINANCEIRA As Integer = 5
  Const const_GridItem_NO_TIPO_DOCUMENTO As Integer = 6
  Const const_GridItem_VL_PAGAMENTO As Integer = 7
  Const const_GridItem_ID_PAGAMENTO As Integer = 8

  Const const_GridFormaPagamento_ID_PAGAMENTO As Integer = 0
  Const const_GridFormaPagamento_ID_OPT_STATUS As Integer = 1
  Const const_GridFormaPagamento_NO_OPT_TIPOPAGAMENTO As Integer = 2
  Const const_GridFormaPagamento_NO_CONTAFINANCEIRA As Integer = 3
  Const const_GridFormaPagamento_NO_FORMAPAGAMENTO As Integer = 4
  Const const_GridFormaPagamento_NO_TIPO_DOCUMENTO As Integer = 5
  Const const_GridFormaPagamento_VL_PAGAMENTO As Integer = 6
  Const const_GridFormaPagamento_NO_OPT_STATUS As Integer = 7
  Const const_GridFormaPagamento_SQ_PAGAMENTOITEM As Integer = 8

  Public iID_MOVFINANCEIRAPARCELA As Integer = 0

  Dim oDBGridFormaPagamento As New UltraWinDataSource.UltraDataSource

  Dim oDS As New DataSet

  Private Sub frmLancaContasReceberPagar_Quitar_Exclusao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdPagamentos, , oDS, UltraWinGrid.CellClickAction.RowSelect, ,
                                            DefaultableBoolean.False, True,
                                            UltraWinGrid.ViewStyleBand.Vertical, , , True)
    objGrid_Coluna_Add(grdPagamentos, "ID_PAGAMENTO", 0, , , , , const_Formato_NumeroInteiro)
    objGrid_Coluna_Add(grdPagamentos, "Cód. Pagamento", 130)
    objGrid_Coluna_Add(grdPagamentos, "Vl. Pagamento", 170, , , ColumnStyle.Currency)
    objGrid_Coluna_Add(grdPagamentos, "Data do Pagto", 170, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdPagamentos, "Status do Pagamento", 200)
    objGrid_Coluna_Add(grdPagamentos, "NO_OPT_TIPOMOVFINANCEIRA", 0)

    'Montagem do DataSet - Início
    DBData_Criar(oDS, "Item", New String() {"Parcela", "Cód. Documento", "Dt. Movimentação", "Dt. Quitação", "Pessoa",
                                            "Descr. Financeira", "Tipo de Documento", "Vl. Pagamento", "ID_PAGAMENTO"},
                              New eDbType() {modDeclaracao.eDbType._Texto, modDeclaracao.eDbType._Texto, modDeclaracao.eDbType._Data, modDeclaracao.eDbType._Data,
                                             modDeclaracao.eDbType._Texto, modDeclaracao.eDbType._Texto, modDeclaracao.eDbType._Texto, modDeclaracao.eDbType._Decimal,
                                             modDeclaracao.eDbType._Decimal})
    'Montagem do DataSet - Fim
    DBData_Relationamento_Criar(oDS, "FK_Item", oDS.Tables(0), New String() {oDS.Tables(0).Columns(const_GridPagamento_ID_PAGAMENTO).ColumnName},
                                                oDS.Tables(1), New String() {"ID_PAGAMENTO"})

    objGrid_Band_Formatar(grdPagamentos.DisplayLayout.Bands(1), UltraWinGrid.CellClickAction.RowSelect)

    With grdPagamentos.DisplayLayout.Bands(1)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_CD_PARCELA), "Parcela", 110)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_CD_DOCUMENTO), "Cód. Documento", 80)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_DT_MOVIMENTACAO), "Dt. Movimentação", 80,, ColumnStyle.Date)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_DT_QUITACAO), "Dt. Quitação", 80,, ColumnStyle.Date)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_NO_PESSOA), "Pessoa", 200)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_DS_MOVFINANCEIRA), "Descr. Financeira", 200)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_NO_TIPO_DOCUMENTO), "Tipo de Documento", 150)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_VL_PAGAMENTO), "Vl. Pagamento", 100,, ColumnStyle.Currency)
      objGrid_Coluna_Formatar(grdPagamentos, .Columns(const_GridItem_ID_PAGAMENTO), "ID_PAGAMENTO", 0)
    End With
    objGrid_Configuracao_Carregar(grdPagamentos, Me.Name)

    objGrid_Inicializar(grdFormaPagamento, , oDBGridFormaPagamento, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdFormaPagamento, "ID_PAGAMENTO", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "Tipo de Pagamento", 150)
    objGrid_Coluna_Add(grdFormaPagamento, "Conta Financeira", 150)
    objGrid_Coluna_Add(grdFormaPagamento, "Forma de Pagamento", 150)
    objGrid_Coluna_Add(grdFormaPagamento, "Tipo de Documento", 150)
    objGrid_Coluna_Add(grdFormaPagamento, "Vl. Pagamento", 80,,, ColumnStyle.Currency)
    objGrid_Coluna_Add(grdFormaPagamento, "Status", 150)
    objGrid_Coluna_Add(grdFormaPagamento, "SQ_PAGAMENTOITEM", 0)
    objGrid_Configuracao_Carregar(grdFormaPagamento, Me.Name)

    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String

    oDS.Tables(0).Rows.Clear()
    oDBGridFormaPagamento.Rows.Clear()

    sSqlText = "SELECT MFPG.ID_PAGAMENTO," &
                      "MFPG.CD_PAGAMENTO," &
                      "MFPG.VL_PAGAMENTO," &
                      "MFPG.DT_PAGAMENTO," &
                      "MFPG.NO_OPT_STATUS_PAGAMENTO," &
                      "MFPC.NO_OPT_TIPOMOVFINANCEIRA" &
               " FROM VW_MOVFINANCEIRAPAGTO MFPG" &
                " INNER JOIN VW_MOVFINANCEIRAPARCELA MFPC ON MFPC.SQ_MOVFINANCEIRAPARCELA = MFPG.ID_MOVFINANCEIRAPARCELA" &
               " WHERE MFPG.ID_MOVFINANCEIRAPARCELA = " & iID_MOVFINANCEIRAPARCELA &
               " ORDER BY MFPG.DT_PAGAMENTO"
    DBQuery_Append(oDS.Tables(0), sSqlText, True)

    objGrid_ExibirTotal(grdPagamentos, New Integer() {const_GridPagamento_VL_PAGAMENTO})
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub grdPagamentos_AfterRowExpanded(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles grdPagamentos.AfterRowExpanded
    Dim sSqlText As String

    If e.Row.ChildBands(0).Rows.Count > 0 Then Exit Sub

    sSqlText = "SELECT MFPC.CD_MOVFINANCEIRA_PARCELA," &
                      "MFPC.CD_DOCUMENTO," &
                      "MFPC.DT_MOVIMENTACAO," &
                      "MFPC.DT_QUITACAO," &
                      "MFPC.NO_PESSOA," &
                      "MFPC.DS_MOVFINANCEIRA," &
                      "MFPC.NO_TIPO_DOCUMENTO," &
                      "MFPG.VL_PAGAMENTO," &
                      "MFPG.ID_PAGAMENTO" &
               " FROM VW_MOVFINANCEIRAPAGTO MFPG" &
                " INNER JOIN VW_MOVFINANCEIRAPARCELA MFPC ON MFPC.SQ_MOVFINANCEIRAPARCELA = MFPG.ID_MOVFINANCEIRAPARCELA" &
               " WHERE MFPG.ID_PAGAMENTO = " & e.Row.Cells(const_GridPagamento_ID_PAGAMENTO).Value &
               " ORDER BY MFPC.CD_MOVFINANCEIRA_PARCELA"

    DBQuery_Append(oDS.Tables(1), sSqlText)

    objGrid_ExibirTotal(grdPagamentos, 1, New Integer() {const_GridItem_VL_PAGAMENTO})
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    If objGrid_LinhaSelecionada(grdPagamentos) = -1 Then
      FNC_Mensagem("Selecione o pagamento a ser excluído")
      Exit Sub
    End If

    Dim sSqlText As String

    If objGrid_Valor(grdFormaPagamento, const_GridPagamento_ID_PAGAMENTO, , 0) = 0 Then
      FNC_Mensagem("Houve algum erro na quitação dessa movimentação financeira")
    Else
      sSqlText = "SELECT COUNT(*) FROM VW_PAGAMENTOITEM" &
               " WHERE ID_PAGAMENTO = " & objGrid_Valor(grdFormaPagamento, const_GridPagamento_ID_PAGAMENTO) &
                 " AND ID_OPT_STATUS = " & enOpcoes.StatusPagamentoItem_Quitado.GetHashCode()
      If DBQuery_ValorUnico(sSqlText) > 0 Then
        FNC_Mensagem("Existe forma de pagamento quitados nesse pagamento. A compensão precisa ser cancelada para prosseguir com a exclusão")
        Exit Sub
      End If

      sSqlText = "SELECT COUNT(*) FROM VW_MOVFINANCEIRAPAGTO WHERE ID_PAGAMENTO = " & objGrid_Valor(grdFormaPagamento, const_GridPagamento_ID_PAGAMENTO)

      If DBQuery_ValorUnico(sSqlText) > 1 Then
        Dim sMsg As String

        sMsg = "Existem outras " & objGrid_Valor(grdFormaPagamento, const_GridPagamento_NO_OPT_TIPOMOVFINANCEIRA) & " relacionadas a esse pagamento, e a exclusão do irá colocar as mesmas como 'Em Aberto'. Deseja prosseguir?"

        If Not FNC_Perguntar(sMsg) Then
          Exit Sub
        End If
      Else
        If Not FNC_Perguntar("Deseja realmente excluir esse pagamento?") Then Exit Sub
      End If

      sSqlText = DBMontar_SP("SP_PAGAMENTO_DEL", False, "@ID_PAGAMENTO",
                                                        "@DT_EXCLUSAO")

      If DBExecutar(sSqlText, DBParametro_Montar("@ID_PAGAMENTO", objGrid_Valor(grdPagamentos, const_GridPagamento_ID_PAGAMENTO)),
                              DBParametro_Montar("DT_EXCLUSAO", Now(), SqlDbType.DateTime)) Then
        Pesquisar()

        FNC_Mensagem("Exclusão Efetuada")
      End If
    End If
  End Sub

  Private Sub grdPagamentos_AfterRowActivate(sender As Object, e As EventArgs) Handles grdPagamentos.AfterRowActivate
    Dim sSqlText As String

    If objGrid_LinhaSelecionada(grdPagamentos) = -1 Then
      oDBGridFormaPagamento.Rows.Clear()
    Else
      sSqlText = "SELECT DISTINCT ID_PAGAMENTO," &
                                 "ID_OPT_STATUS," &
                                 "NO_OPT_TIPOPAGAMENTO," &
                                 "NO_CONTAFINANCEIRA," &
                                 "NO_FORMAPAGAMENTO," &
                                 "NO_TIPO_DOCUMENTO," &
                                 "VL_PAGAMENTO," &
                                 "NO_OPT_STATUS," &
                                 "SQ_PAGAMENTOITEM" &
                 " FROM VW_PAGAMENTOITEM" &
                 " WHERE ID_PAGAMENTO = " & grdPagamentos.DisplayLayout.ActiveRow.Cells(const_GridFormaPagamento_ID_PAGAMENTO).Value &
                 " ORDER BY NO_OPT_TIPOPAGAMENTO"
      objGrid_Carregar(grdFormaPagamento, sSqlText, New Integer() {const_GridFormaPagamento_ID_PAGAMENTO,
                                                                   const_GridFormaPagamento_ID_OPT_STATUS,
                                                                   const_GridFormaPagamento_NO_OPT_TIPOPAGAMENTO,
                                                                   const_GridFormaPagamento_NO_CONTAFINANCEIRA,
                                                                   const_GridFormaPagamento_NO_FORMAPAGAMENTO,
                                                                   const_GridFormaPagamento_NO_TIPO_DOCUMENTO,
                                                                   const_GridFormaPagamento_VL_PAGAMENTO,
                                                                   const_GridFormaPagamento_NO_OPT_STATUS,
                                                                   const_GridFormaPagamento_SQ_PAGAMENTOITEM})

      objGrid_ExibirTotal(grdFormaPagamento, New Integer() {const_GridFormaPagamento_VL_PAGAMENTO})
    End If
  End Sub

  Private Sub frmLancaContasReceberPagar_Quitar_Exclusao_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdFormaPagamento, Me.Name)
    objGrid_Configuracao_Gravar(grdPagamentos, Me.Name)
  End Sub
End Class