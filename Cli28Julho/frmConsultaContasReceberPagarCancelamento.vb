Public Class frmConsultaContasReceberPagarCancelamento
  Public iProcessoInterno As Integer

  Public iSQ_MOVFINANCEIRAPARCELA_CANCELAMENTO As Integer
  Public iSQ_MOVFINANCEIRAPARCELA As Integer
  Public dVL_CANCELAMENTO As Double

  Private Sub frmConsultaContasReceberPagarCancelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Select Case iProcessoInterno
      Case const_ProcessoInterno_ConsultaContasReceberPagarCancelamento_ContasPagarReceber
        Me.Text = "Consulta de Contas a Receber e a Pagar - Cancelamento"
      Case const_ProcessoInterno_ConsultaContasReceberPagarCancelamento_FluxoCaixa
        Me.Text = "Consulta de Lançamento em Conta Caixa/Conta Bancária - Cancelamento"
    End Select

    ComboBox_Carregar(cboMotivoCancelamento, enSql.MotivoCancelamentoMovimentacaoFinanceira)
    txtDataCancelamento.Value = Now().Date()
    txtValorCancelamento.Value = dVL_CANCELAMENTO

    'txtComentario.MaxLength = const_BancoDados_TamanhoComentario
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not txtDataCancelamento.IsDateValid Then
      FNC_Mensagem("Informe a data do cancelamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboMotivoCancelamento) Then
      FNC_Mensagem("Selecione o motivo de cancelamento")
      Exit Sub
    End If
    If Trim(txtComentario.Text) = "" Then
      FNC_Mensagem("Informe o comentário/motivo do cancelamento")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_CANCELAMENTO_CAD", False, "@SQ_MOVFINANCEIRAPARCELA_CANCELAMENTO",
                                                                              "@SQ_MOVFINANCEIRAPARCELA",
                                                                              "@ID_OPT_MOTIVO_CANCELAMENTO",
                                                                              "@DT_CANCELAMENTO",
                                                                              "@VL_CANCELAMENTO",
                                                                              "@CM_CANCELAMENTO",
                                                                              "@ID_USUARIO")

    If DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA_CANCELAMENTO", iSQ_MOVFINANCEIRAPARCELA_CANCELAMENTO),
                            DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA", iSQ_MOVFINANCEIRAPARCELA),
                            DBParametro_Montar("ID_OPT_MOTIVO_CANCELAMENTO", cboMotivoCancelamento.SelectedValue),
                            DBParametro_Montar("DT_CANCELAMENTO", txtDataCancelamento.Value),
                            DBParametro_Montar("VL_CANCELAMENTO", txtValorCancelamento.Value, SqlDbType.Float),
                            DBParametro_Montar("CM_CANCELAMENTO", txtComentario.Text, const_BancoDados_TamanhoComentario),
                            DBParametro_Montar("ID_USUARIO", iID_USUARIO)) Then
      FNC_Mensagem("Cancelamento efetuado")
    End If

    Close()
  End Sub
End Class