Public Class frmIndicador_Resgate
  Private Sub frmIndicador_Resgate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboIndicador, enSql.Indicador)

    txtDataResgate.Value = Now()
  End Sub

  Private Sub cboIndicador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIndicador.SelectedIndexChanged
    CarregarSaldo()
  End Sub
  Private Sub CarregarSaldo()
    Dim sSqlText As String

    sSqlText = "SELECT SUM(VL_PONTOS) FROM VW_LANCAMENTOINDICACAO WHERE SQ_PESSOA = " & FNC_NVL(cboIndicador.SelectedValue, 0)
    txtValorSaldo.Value = DBQuery_ValorUnico(sSqlText, 0)
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If txtValorSaldo.Value < txtValorResgate.Value Then
      FNC_Mensagem("O valor de resgate não pode ser maior que o saldo de pontos")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboIndicador) Then
      FNC_Mensagem("Selecione o Indicador que irá receber o resgate")
      Exit Sub
    End If
    If Not IsDate(txtDataResgate.Value) Then
      FNC_Mensagem("Informa a data do resgate")
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
                         DBParametro_Montar("ID_OPT_CREDITODEBITO", enOpcoes.CreditoDebito_Debito.GetHashCode),
                         DBParametro_Montar("DT_LANCAMENTOINDICACAO", txtDataResgate.Value, SqlDbType.DateTime2),
                         DBParametro_Montar("VL_PONTOS", txtValorResgate.Value),
                         DBParametro_Montar("CM_COMENTARIO", txtComentario.Text, SqlDbType.Text),
                         DBParametro_Montar("TP_LANCAMENTO", const_TipoLancamentoIndicacao_Resgate),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO))

    CarregarSaldo()

    FNC_Mensagem("Resgate realizado")

    cboIndicador.SelectedIndex = -1
    txtValorResgate.Value = 0
    txtDataResgate.Value = Nothing
    txtComentario.Text = ""
  End Sub
  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub
End Class