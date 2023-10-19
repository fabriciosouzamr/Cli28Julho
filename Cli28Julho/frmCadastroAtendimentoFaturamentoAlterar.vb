Imports Infragistics.Win

Public Class frmCadastroAtendimentoFaturamentoAlterar
  Const const_GridListagem_ID_MOVFINANCEIRA As Integer = 0
  Const const_GridListagem_CodigoMovimentacao As Integer = 1
  Const const_GridListagem_Pessoa As Integer = 2
  Const const_GridListagem_DescricaoLancamento As Integer = 3
  Const const_GridListagem_Data As Integer = 4
  Const const_GridListagem_ValorMovimentacao As Integer = 5

  Const const_GridListagemGuia_ID_MOVFINANCEIRA As Integer = 0
  Const const_GridListagemGuia_CodigoMovimentacao As Integer = 1
  Const const_GridListagemGuia_CodigoAutorizacao As Integer = 2
  Const const_GridListagemGuia_Pessoa As Integer = 3
  Const const_GridListagemGuia_DescricaoLancamento As Integer = 4
  Const const_GridListagemGuia_Data As Integer = 5
  Const const_GridListagemGuia_ValorMovimentacao As Integer = 6

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Dim oDBGridGuias As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroAtendimentoFaturamentoAlterar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "ID_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdListagem, "Cód. Mov.", 200)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 200)
    objGrid_Coluna_Add(grdListagem, "Descr. Lançamento", 200)
    objGrid_Coluna_Add(grdListagem, "Data", 200, ,,,, const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Valor", 200, ,,,, const_Formato_Valor)

    objGrid_Inicializar(grdListagemGuias, , oDBGridGuias, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagemGuias, "ID_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdListagemGuias, "Cód. Mov.", 150)
    objGrid_Coluna_Add(grdListagemGuias, "Cód. Autor.", 150)
    objGrid_Coluna_Add(grdListagemGuias, "Pessoa", 200)
    objGrid_Coluna_Add(grdListagemGuias, "Descr. Lançamento", 200)
    objGrid_Coluna_Add(grdListagemGuias, "Data", 200, ,,,, const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagemGuias, "Valor", 200, ,,,, const_Formato_Valor)

    CarregarGrid()
  End Sub

  Private Sub CarregarGrid()
    Dim sSqlText As String

    sSqlText = $"SELECT M.SQ_MOVFINANCEIRA,
		                    M.CD_MOVFINANCEIRA,
			                  P.NO_PESSOA,
			                  M.DS_MOVFINANCEIRA,
			                  M.DT_MOVIMENTACAO,
			                  M.VL_MOVFINANCEIRA
                  FROM TB_MOVFINANCEIRA M
                   INNER JOIN TB_PESSOA P ON P.SQ_PESSOA = M.ID_PESSOA
                   INNER JOIN TB_PESSOA_EMPRESA E ON E.ID_PESSOA = P.SQ_PESSOA
									                          AND ISNULL(E.IC_PROFISSIONAL, 'N') = 'S'
                  WHERE M.ID_CLINICA_VENDA IS NULL
                    AND M.ID_OPT_STATUS = 56	/* Aberto */
                    AND M.VL_MOVFINANCEIRA > 0.1
                  ORDER BY P.NO_PESSOA"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_MOVFINANCEIRA,
                                                           const_GridListagem_CodigoMovimentacao,
                                                           const_GridListagem_Pessoa,
                                                           const_GridListagem_DescricaoLancamento,
                                                           const_GridListagem_Data,
                                                           const_GridListagem_ValorMovimentacao})
  End Sub

  Private Sub grdListagem_AfterRowActivate(sender As Object, e As EventArgs) Handles grdListagem.AfterRowActivate
    CarregarGridGuias()
  End Sub

  Private Sub CarregarGridGuias()
    Dim sSqlText As String

    Try
      If Not grdListagem.ActiveRow.IsFilterRow Then
        sSqlText = $"SELECT M.SQ_MOVFINANCEIRA,
		                      M.CD_MOVFINANCEIRA,
													ISNULL(CVPRC.CD_AGENDAMENTO_REALIZADO, CLVND.CD_CLINICA_VENDA) CD_AUTORIZACAO,
			                    P.NO_PESSOA,
			                    M.DS_MOVFINANCEIRA,
			                    M.DT_MOVIMENTACAO,
			                    M.VL_MOVFINANCEIRA
                     FROM TB_MOVFINANCEIRAPARCELA PC
                     INNER JOIN TB_MOVFINANCEIRA M ON M.SQ_MOVFINANCEIRA = PC.ID_MOVFINANCEIRA
	                   INNER JOIN TB_PESSOA P ON P.SQ_PESSOA = M.ID_PESSOA
	                	  LEFT JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPRC (NOLOCK) ON CVPRC.ID_MOVFINANCEIRA = M.SQ_MOVFINANCEIRA
		                  LEFT JOIN TB_PROCEDIMENTO PROCE (NOLOCK) ON PROCE.SQ_PROCEDIMENTO = CVPRC.ID_PROCEDIMENTO
		                  LEFT JOIN TB_CLINICA_VENDA CLVND (NOLOCK) ON CLVND.SQ_CLINICA_VENDA = CVPRC.ID_CLINICA_VENDA
                    WHERE PC.ID_MOVFINANCEIRAGERADA = {grdListagem.ActiveRow.Cells(const_GridListagem_ID_MOVFINANCEIRA).Value}"
        objGrid_Carregar(grdListagemGuias, sSqlText, New Integer() {const_GridListagemGuia_ID_MOVFINANCEIRA,
                                                                    const_GridListagemGuia_CodigoMovimentacao,
                                                                    const_GridListagemGuia_CodigoAutorizacao,
                                                                    const_GridListagemGuia_Pessoa,
                                                                    const_GridListagemGuia_DescricaoLancamento,
                                                                    const_GridListagemGuia_Data,
                                                                    const_GridListagemGuia_ValorMovimentacao})
        objGrid_ExibirTotal(grdListagemGuias, New Integer() {const_GridListagemGuia_ValorMovimentacao})

        grdListagem.ActiveRow.Cells(const_GridListagem_ValorMovimentacao).Value = objGrid_CalcularTotalColuna(grdListagemGuias, const_GridListagemGuia_ValorMovimentacao, grdTipoCalculoTotal.SomarValor)
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub cmdExcluirGuia_Click(sender As Object, e As EventArgs) Handles cmdExcluirGuia.Click
    If grdListagemGuias.ActiveRow Is Nothing Then
      FNC_Mensagem("Selecione uma fatura")
    Else
      If Not FNC_Perguntar("Deseja excluir essa guia?") Then Exit Sub

      Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_FATURAMENTO_EXCLUIR", False, "@SQ_MOVFINANCEIRA",
                                                                            "@SQ_MOVFINANCEIRA_GERAL",
                                                                            "@ID_USUARIO")
        If DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRA", grdListagemGuias.ActiveRow.Cells(const_GridListagem_ID_MOVFINANCEIRA).Value),
                              DBParametro_Montar("SQ_MOVFINANCEIRA_GERAL", grdListagem.ActiveRow.Cells(const_GridListagem_ID_MOVFINANCEIRA).Value),
                              DBParametro_Montar("ID_USUARIO", iID_USUARIO)) Then
          CarregarGridGuias()

          FNC_Mensagem("Gravação Efetuada")
        End If
      End If
  End Sub
End Class