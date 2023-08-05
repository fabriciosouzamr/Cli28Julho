Imports Infragistics.Win

Public Class frmIndicador_Historico
  Const const_GridListagem_SQ_LANCAMENTOINDICACAO As Integer = 0
  Const const_GridListagem_CD_VENDA As Integer = 1
  Const const_GridListagem_NO_PESSOA As Integer = 2
  Const const_GridListagem_NO_PACIENTE As Integer = 3
  Const const_GridListagem_DH_VENDA As Integer = 4
  Const const_GridListagem_VL_PONTOS As Integer = 5
  Const const_GridListagem_DS_LANCAMENTO As Integer = 6
  Const const_GridListagem_CM_COMENTARIO As Integer = 7
  Const const_GridListagem_NO_USUARIO As Integer = 8
  Const const_GridListagem_TP_LANCAMENTO As Integer = 9

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdLancamento_Click(sender As Object, e As EventArgs) Handles cmdLancamento.Click
    Dim oForm As New frmIndicador_Lancamento

    FNC_AbriTela(oForm, , True, True)

    oForm.Dispose()
  End Sub

  Private Sub cmdResgate_Click(sender As Object, e As EventArgs) Handles cmdResgate.Click
    Dim oForm As New frmIndicador_Resgate

    FNC_AbriTela(oForm, , True, True)

    oForm.Dispose()
  End Sub

  Private Sub frmIndicador_Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboIndicador, enSql.Indicador)
    ComboBox_Carregar(cboTipoLancamento, New String() {"Manual", "Resgate", "Venda"},
                                         New Object() {const_TipoLancamentoIndicacao_Manual, const_TipoLancamentoIndicacao_Resgate, const_TipoLancamentoIndicacao_Venda})

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_LANCAMENTOINDICACAO", 0)
    objGrid_Coluna_Add(grdListagem, "Cód. Venda", 150)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 300)
    objGrid_Coluna_Add(grdListagem, "Paciente", 300)
    objGrid_Coluna_Add(grdListagem, "D/H Venda", 150)
    objGrid_Coluna_Add(grdListagem, "Vlr. Pontos", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Descrição", 300)
    objGrid_Coluna_Add(grdListagem, "Comentário", 300)
    objGrid_Coluna_Add(grdListagem, "Usuário", 300)
    objGrid_Coluna_Add(grdListagem, "TP_LANCAMENTO", 0)

    txtDataLancamentoInicial.Value = Nothing
    txtDataLancamentoFinal.Value = Nothing
    cboTipoLancamento.SelectedIndex = -1
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    If Not ComboBox_Selecionado(cboIndicador) Then
      FNC_Mensagem("Selecione o indicador a ter o histórico listado")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = "SELECT SQ_LANCAMENTOINDICACAO," &
                      "CD_CLINICA_VENDA," &
                      "NO_PESSOA," &
                      "NO_PACIENTE," &
                      "DH_VENDA," &
                      "VL_PONTOS," &
                      "DS_LANCAMENTO," &
                      "CM_COMENTARIO," &
                      "NO_USUARIO," &
                      "TP_LANCAMENTO" &
               " FROM VW_LANCAMENTOINDICACAO" &
               " WHERE SQ_PESSOA = " & cboIndicador.SelectedValue

    If IsDate(txtDataLancamentoInicial.Value) Then
      sSqlText = sSqlText & " AND CAST(DH_VENDA AS DATE) >= " & FNC_QuotedStr(txtDataLancamentoInicial.Text)
    End If
    If IsDate(txtDataLancamentoFinal.Value) Then
      sSqlText = sSqlText & " AND CAST(DH_VENDA AS DATE) <= " & FNC_QuotedStr(txtDataLancamentoFinal.Text)
    End If
    If ComboBox_Selecionado(cboTipoLancamento) Then
      sSqlText = sSqlText & " AND TP_LANCAMENTO = " & FNC_QuotedStr(cboTipoLancamento.SelectedValue)
    End If

    sSqlText = sSqlText &
               " ORDER BY DH_VENDA"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_LANCAMENTOINDICACAO,
                                                           const_GridListagem_CD_VENDA,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_NO_PACIENTE,
                                                           const_GridListagem_DH_VENDA,
                                                           const_GridListagem_VL_PONTOS,
                                                           const_GridListagem_DS_LANCAMENTO,
                                                           const_GridListagem_CM_COMENTARIO,
                                                           const_GridListagem_NO_USUARIO,
                                                           const_GridListagem_TP_LANCAMENTO})

    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VL_PONTOS})
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser excluído")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_TP_LANCAMENTO) = const_TipoLancamentoIndicacao_Venda Then
      FNC_Mensagem("Não é possível excluir uma lançamento de venda")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_LANCAMENTOINDICACAO_DEL", False, "@SQ_LANCAMENTOINDICACAO",
                                                                "@ID_USUARIO")

    DBExecutar(sSqlText, DBParametro_Montar("SQ_LANCAMENTOINDICACAO", objGrid_Valor(grdListagem, const_GridListagem_SQ_LANCAMENTOINDICACAO)),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO))

    Pesquisar()
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboIndicador.SelectedIndex = -1
    txtDataLancamentoInicial.Value = Nothing
    txtDataLancamentoFinal.Value = Nothing
    cboTipoLancamento.SelectedIndex = -1
  End Sub
End Class