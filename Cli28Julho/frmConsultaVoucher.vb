Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmConsultaVoucher
  Const const_GridListagem_SQ_VOUCHER As Integer = 0
  Const const_GridListagem_CD_VOUCHER As Integer = 1
  Const const_GridListagem_NO_PESSOA As Integer = 2
  Const const_GridListagem_VL_VOUCHER As Integer = 3
  Const const_GridListagem_VL_SALDO As Integer = 4
  Const const_GridListagem_VL_CANCELADO As Integer = 5
  Const const_GridListagem_DH_VOUHCER As Integer = 6
  Const const_GridListagem_DH_ULTIMA_MOVIMENTACAO As Integer = 7
  Const const_GridListagem_DH_CANCELADO As Integer = 8

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    Limpar()
  End Sub

  Private Sub Limpar()
    oDBGrid.Rows.Clear()
    txtDataVenda_Inicio.Value = Nothing
    txtDataVenda_Fim.Value = Nothing
    txtDataUtilizacao_Inicio.Value = Nothing
    txtDataUtilizacao_Fim.Value = Nothing
    txtDataCancelamento_Inicio.Value = Nothing
    txtDataCancelamento_Fim.Value = Nothing

    psqPessoaAquisicao.ID_Pessoa = 0
    psqPessoaUtilizacao.ID_Pessoa = 0
  End Sub

  Private Sub frmConsultaVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_VOUCHER", 0)
    objGrid_Coluna_Add(grdListagem, "Código", 150)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 300)
    objGrid_Coluna_Add(grdListagem, "Vlr. Voucher", 140, , , ColumnStyle.Currency, , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdListagem, "Vlr. Saldo", 140, , , ColumnStyle.Currency, , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdListagem, "Vlr. Cancelado", 140, , , ColumnStyle.Currency, , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdListagem, "D/H Voucher", 140, , , ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "D/H Última Movimentação", 140, , , ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "D/H Cancelado", 140, , , ColumnStyle.DateTime)

    Limpar()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Where As String

    sSqlText = "SELECT VOUCE.SQ_VOUCHER," &
                      "VOUCE.CD_VOUCHER," &
                      "PESVC.NO_PESSOA," &
                      "VOUCE.VL_VOUCHER," &
                      "VOUCE.VL_VOUCHER - VOUCE.VL_MOVIMENTADO VL_SALDO," &
                      "VOUCE.VL_CANCELADO," &
                      "VOUCE.DH_VOUHCER," &
                      "VOUCE.DH_ULTIMA_MOVIMENTACAO," &
                      "VOUCE.DH_CANCELADO" &
               " FROM TB_VOUCHER VOUCE" &
                " INNER JOIN TB_PESSOA PESVC ON PESVC.SQ_PESSOA = VOUCE.ID_PESSOA"

    If psqPessoaAquisicao.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, " VOUCE.ID_PESSOA = " & psqPessoaAquisicao.ID_Pessoa, " AND ")
    End If
    If psqPessoaUtilizacao.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, " VOUCE.SQ_VOUCHER IN (SELECT CVVCH.ID_VOUCHER" &
                                                              " FROM TB_CLINICA_VENDA CLVND" &
                                                               " INNER JOIN TB_CLINICA_VENDA_VOUCHER CVVCH ON CVVCH.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                                                              " WHERE CLVND.ID_PESSOA =  " & psqPessoaAquisicao.ID_Pessoa & ")", " AND ")
    End If
    If IsDate(txtDataVenda_Inicio.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(VOUCE.DH_VOUHCER AS DATE) >= " & FNC_QuotedStr(txtDataVenda_Inicio.Text), " AND ")
    End If
    If IsDate(txtDataVenda_Fim.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(VOUCE.DH_VOUHCER AS DATE) <= " & FNC_QuotedStr(txtDataVenda_Fim.Text), " AND ")
    End If
    If IsDate(txtDataUtilizacao_Inicio.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " VOUCE.SQ_VOUCHER IN (SELECT CVVCH.ID_VOUCHER" &
                                                              " FROM TB_CLINICA_VENDA CLVND" &
                                                               " INNER JOIN TB_CLINICA_VENDA_VOUCHER CVVCH ON CVVCH.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                                                              " WHERE CAST(CLVND.DH_VENDA AS DATE) >= " & FNC_QuotedStr(txtDataUtilizacao_Inicio.Text) & ")", " AND ")
    End If
    If IsDate(txtDataUtilizacao_Fim.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " VOUCE.SQ_VOUCHER IN (SELECT CVVCH.ID_VOUCHER" &
                                                              " FROM TB_CLINICA_VENDA CLVND" &
                                                               " INNER JOIN TB_CLINICA_VENDA_VOUCHER CVVCH ON CVVCH.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                                                              " WHERE CAST(CLVND.DH_VENDA AS DATE) >= " & FNC_QuotedStr(txtDataUtilizacao_Fim.Text) & ")", " AND ")
    End If
    If IsDate(txtDataCancelamento_Inicio.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(VOUCE.DH_CANCELADO AS DATE) >= " & FNC_QuotedStr(txtDataCancelamento_Inicio.Text), " AND ")
    End If
    If IsDate(txtDataCancelamento_Fim.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(VOUCE.DH_CANCELADO AS DATE) <= " & FNC_QuotedStr(txtDataCancelamento_Fim.Text), " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " WHERE " & sSqlText_Where
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_VOUCHER,
                                                           const_GridListagem_CD_VOUCHER,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_VL_VOUCHER,
                                                           const_GridListagem_VL_SALDO,
                                                           const_GridListagem_VL_CANCELADO,
                                                           const_GridListagem_DH_VOUHCER,
                                                           const_GridListagem_DH_ULTIMA_MOVIMENTACAO,
                                                           const_GridListagem_DH_CANCELADO})
    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VL_VOUCHER,
                                                    const_GridListagem_VL_SALDO,
                                                    const_GridListagem_VL_CANCELADO})

  End Sub

  Private Sub cmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    Dim oForm As New frmLancaContasReceberPagar

    AddHandler oForm.RegerarConsulta, AddressOf Pesquisar
    oForm.bVoucher = True

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o voucher a ser excluído")
      Exit Sub
    End If
    If Not FNC_Perguntar("Deseja realmente ir cancelar esse voucher?") Then
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_VOUCHER_CANCELAR_UPD", False, "@SQ_VOUCHER", "@ID_USUARIO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_VOUCHER", objGrid_Valor(grdListagem, const_GridListagem_SQ_VOUCHER)),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO))

    FNC_Mensagem("Cancelamento efetuado")

    Pesquisar()
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o voucher a ser excluído")
      Exit Sub
    End If

    FormRelatorioFinanceiro_VoucherLancamento(objGrid_Valor(grdListagem, const_GridListagem_SQ_VOUCHER))
  End Sub

  Private Sub cmdVoucher_Click(sender As Object, e As EventArgs) Handles cmdVoucher.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o voucher a ser impresso")
      Exit Sub
    End If

    FormRelatorioFinanceiro_Voucher(objGrid_Valor(grdListagem, const_GridListagem_SQ_VOUCHER), False)
  End Sub

  Private Sub cmdAutorizacao_Click(sender As Object, e As EventArgs) Handles cmdAutorizacao.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o voucher a ser impresso")
      Exit Sub
    End If

    FormRelatorioFinanceiro_Voucher(objGrid_Valor(grdListagem, const_GridListagem_SQ_VOUCHER), True)
  End Sub

  Private Sub cmdHistorico_Click(sender As Object, e As EventArgs) Handles cmdHistorico.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o voucher para o qual deseja ver o histórico")
      Exit Sub
    End If

    Dim oForm As New frmConsultaHistorico_Registro

    oForm.iProcessso = enOpcoes.Processo_Historico_Financeiro_Voucher.GetHashCode()
    oForm.iID_REGISTRO = objGrid_Valor(grdListagem, const_GridListagem_SQ_VOUCHER)
    FNC_AbriTela(oForm, , True, True)
  End Sub
End Class