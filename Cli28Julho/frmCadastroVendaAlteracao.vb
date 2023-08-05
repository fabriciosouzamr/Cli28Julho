Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmCadastroVendaAlteracao
  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Const const_GridListagem_SQ_MOVFINANCEIRAPARCELA As Integer = 0
  Const const_GridListagem_TipoDocumento As Integer = 1
  Const const_GridListagem_FormaPagamento As Integer = 2
  Const const_GridListagem_VlrParcela As Integer = 3

  Public iID_CLINICA_VENDA As Integer

  Dim sCD_CLINICA_VENDA As String


  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroVendaAlteracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdFormaPagamento, , oDBGrid, UltraWinGrid.CellClickAction.Edit, DefaultableBoolean.True, DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdFormaPagamento, "SQ_MOVFINANCEIRAPARCELA", 0)
    objGrid_Coluna_Add(grdFormaPagamento, "Tipo de Documento", 200)
    objGrid_Coluna_Add(grdFormaPagamento, "Forma de Pagamento", 200, True, , , FNC_CarregarLista(enTipoCadastro.FormaPagamento))
    objGrid_Coluna_Add(grdFormaPagamento, "Vlr. Parcela", 200, , , , , const_Formato_Valor)

    Dim sSqlText

    sSqlText = "SELECT CD_CLINICA_VENDA FROM TB_CLINICA_VENDA WHERE SQ_CLINICA_VENDA = " & iID_CLINICA_VENDA
    sCD_CLINICA_VENDA = DBQuery_ValorUnico(sSqlText)

    sSqlText = "SELECT MFPRC.SQ_MOVFINANCEIRAPARCELA," &
                      "TPDOC.NO_TIPO_DOCUMENTO," &
                      "MFPRC.ID_FORMAPAGAMENTO_PREFERENCIAL," &
                      "MFPRC.VL_PARCELA" &
               " FROM TB_MOVFINANCEIRAPARCELA MFPRC" &
                " INNER JOIN TB_MOVFINANCEIRA MVFIN ON MVFIN.SQ_MOVFINANCEIRA = MFPRC.ID_MOVFINANCEIRA" &
                                                 " AND MVFIN.ID_CLINICA_VENDA = " & iID_CLINICA_VENDA &
                " INNER JOIN TB_TIPO_DOCUMENTO TPDOC ON TPDOC.SQ_TIPO_DOCUMENTO = MFPRC.ID_TIPO_DOCUMENTO" &
               " WHERE MVFIN.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode()
    objGrid_Carregar(grdFormaPagamento, sSqlText, New Integer() {const_GridListagem_SQ_MOVFINANCEIRAPARCELA,
                                                                 const_GridListagem_TipoDocumento,
                                                                 const_GridListagem_FormaPagamento,
                                                                 const_GridListagem_VlrParcela})
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String
    Dim iCont As Integer
    Dim sDS_HISTORICO As String

    For iCont = 0 To grdFormaPagamento.Rows.Count - 1
      sSqlText = "SELECT F.NO_FORMAPAGAMENTO" &
                 " FROM TB_MOVFINANCEIRAPARCELA M" &
                  " INNER JOIN TB_FORMAPAGAMENTO F ON F.SQ_FORMAPAGAMENTO = M.ID_FORMAPAGAMENTO_PREFERENCIAL" &
                 " WHERE SQ_MOVFINANCEIRAPARCELA = " & objGrid_Valor(grdFormaPagamento, const_GridListagem_SQ_MOVFINANCEIRAPARCELA, iCont)
      sDS_HISTORICO = DBQuery_ValorUnico(sSqlText, "")

      sSqlText = "SELECT NO_FORMAPAGAMENTO FROM TB_FORMAPAGAMENTO WHERE SQ_FORMAPAGAMENTO = " & objGrid_Valor(grdFormaPagamento, const_GridListagem_FormaPagamento, iCont)
      sDS_HISTORICO = String.Format("Alteração de Forma de Pagamento de '{0}' para '{1}'", sDS_HISTORICO, DBQuery_ValorUnico(sSqlText, ""))

      sSqlText = "UPDATE TB_MOVFINANCEIRAPARCELA" &
                 " SET ID_FORMAPAGAMENTO_PREFERENCIAL = " & objGrid_Valor(grdFormaPagamento, const_GridListagem_FormaPagamento, iCont) &
                 " WHERE SQ_MOVFINANCEIRAPARCELA = " & objGrid_Valor(grdFormaPagamento, const_GridListagem_SQ_MOVFINANCEIRAPARCELA, iCont)
      DBExecutar(sSqlText)

      FormCadastroHistorico_Gravar(iID_EMPRESA_FILIAL,
                                   enOpcoes.Processo_Historico_Financeiro_LancamentoContasaReceber_Pagar.GetHashCode,
                                   enOpcoes.Processo_Acao_Alteracao.GetHashCode,
                                   objGrid_Valor(grdFormaPagamento, const_GridListagem_SQ_MOVFINANCEIRAPARCELA, iCont),
                                    sDS_HISTORICO,
                                    Nothing,
                                    sSISTEMA_UltimaVersao,
                                    FNC_Computador_Nome(),
                                    sCD_CLINICA_VENDA,
                                    Nothing)
    Next

    FNC_Mensagem("Gravação Efetuada")
  End Sub

  Private Sub grdFormaPagamento_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdFormaPagamento.BeforeCellActivate
    e.Cancel = (e.Cell.Column.Index <> const_GridListagem_FormaPagamento)
  End Sub
End Class