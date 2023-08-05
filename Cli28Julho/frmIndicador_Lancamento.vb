Public Class frmIndicador_Lancamento
  Private Sub frmIndicador_Lancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboIndicador, enSql.Indicador)

    txtDataLancamento.Value = Now()
    txtValorResgate.Value = 0
    txtComentario.Text = ""
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboIndicador) Then
      FNC_Mensagem("Selecione o Indicador que irá receber o lançamento")
      Exit Sub
    End If
    If Not IsDate(txtDataLancamento.Value) Then
      FNC_Mensagem("Informa a data do lançamento")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_LANCAMENTOINDICACAO_CAD", False, "@SQ_LANCAMENTOINDICACAO OUTPUT",
                                                                "@ID_PESSOA",
                                                                "@ID_OPT_CREDITODEBITO",
                                                                "@DT_LANCAMENTOINDICACAO",
                                                                "@VL_PONTOS",
                                                                "@CM_COMENTARIO",
                                                                "@TP_LANCAMENTO",
                                                                "@ID_USUARIO")

    DBExecutar(sSqlText, DBParametro_Montar("SQ_LANCAMENTOINDICACAO", Nothing),
                         DBParametro_Montar("ID_PESSOA", cboIndicador.SelectedValue),
                         DBParametro_Montar("ID_OPT_CREDITODEBITO", enOpcoes.CreditoDebito_Credito.GetHashCode),
                         DBParametro_Montar("DT_LANCAMENTOINDICACAO", txtDataLancamento.Value, SqlDbType.DateTime2),
                         DBParametro_Montar("VL_PONTOS", txtValorResgate.Value),
                         DBParametro_Montar("CM_COMENTARIO", txtComentario.Text, SqlDbType.Text),
                         DBParametro_Montar("TP_LANCAMENTO", const_TipoLancamentoIndicacao_Manual),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO))

    FNC_Mensagem("Resgate realizado")

    cmdGravar.Enabled = False
  End Sub
  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub
End Class