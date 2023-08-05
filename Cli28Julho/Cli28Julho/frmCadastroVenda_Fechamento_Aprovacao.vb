Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmCadastroVenda_Fechamento_Aprovacao
  Const const_GridListagem_SQ_CLINICA_VENDA_FECHAMENTO As Integer = 0
  Const const_GridListagem_CD_CLINICA_VENDA_FECHAMENTO As Integer = 1
  Const const_GridListagem_NO_CONTAFINANCEIRA As Integer = 2
  Const const_GridListagem_DH_PERIODO_INICIO As Integer = 3
  Const const_GridListagem_DH_PERIODO_FIM As Integer = 4
  Const const_GridListagem_VL_PROCEDIMENTO As Integer = 5
  Const const_GridListagem_NO_PESSOA_FECHAMENTO As Integer = 6
  Const const_GridListagem_DH_FECHAMENTO As Integer = 7
  Const const_GridListagem_NO_PESSOA_APROVACAO As Integer = 8
  Const const_GridListagem_DH_APROVACAO As Integer = 9

  Const const_GridTipoProduto_SQ_CLINICA_VENDA_FECHAMENTO As Integer = 0
  Const const_GridTipoProduto_ID_TIPO_DOCUMENTO As Integer = 1
  Const const_GridTipoProduto_CodigoFechamento As Integer = 2
  Const const_GridTipoProduto_TipoDocumento As Integer = 3
  Const const_GridTipoProduto_ValorTotal As Integer = 4

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Dim oDBGrid_TipoProduto As New UltraWinDataSource.UltraDataSource
  Dim iSQ_CLINICA_VENDA_FECHAMENTO As Integer

  Public eCadastroVenda_Fechamento As modDeclaracaoLocal.enCadastroVenda_Fechamento

  Private Sub frmCadastroVenda_Fechamento_Aprovacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Select Case eCadastroVenda_Fechamento
      Case modDeclaracaoLocal.enCadastroVenda_Fechamento.eAprovacao
        Me.Text = "Cadastro de Venda - Aprovação de Fechamento"
      Case modDeclaracaoLocal.enCadastroVenda_Fechamento.eFinanceiro
        Me.Text = "Cadastro de Venda - Conferência de Fechamento"
    End Select

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_CLINICA_VENDA_FECHAMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "Cód. Fechamento", 200)
    objGrid_Coluna_Add(grdListagem, "Conta Financeira", 200)
    objGrid_Coluna_Add(grdListagem, "D/H Período Início", 150)
    objGrid_Coluna_Add(grdListagem, "D/H Período Fim", 150)
    objGrid_Coluna_Add(grdListagem, "Vlr. Procedimento/Exame", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Pessoa Fechamento", 200)
    objGrid_Coluna_Add(grdListagem, "D/H Fechamento", 150, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Pessoa Aprovação", 200).Hidden = (eCadastroVenda_Fechamento <> modDeclaracaoLocal.enCadastroVenda_Fechamento.eFinanceiro)
    objGrid_Coluna_Add(grdListagem, "D/H Aprovação", 150, , , , , const_Formato_DataHora).Hidden = (eCadastroVenda_Fechamento <> modDeclaracaoLocal.enCadastroVenda_Fechamento.eFinanceiro)

    objGrid_Inicializar(grdTipoProduto, , oDBGrid_TipoProduto, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdTipoProduto, "SQ_CLINICA_VENDA_FECHAMENTO", 0)
    objGrid_Coluna_Add(grdTipoProduto, "ID_TIPO_DOCUMENTO", 0)
    objGrid_Coluna_Add(grdTipoProduto, "Cód. Fechamento", 200)
    objGrid_Coluna_Add(grdTipoProduto, "Tipo de Documento", 250)
    objGrid_Coluna_Add(grdTipoProduto, "Valor Total", 100, , , , , const_Formato_Valor)

    cmdAprovar.Visible = (eCadastroVenda_Fechamento = modDeclaracaoLocal.enCadastroVenda_Fechamento.eAprovacao)

    ComboBox_Carregar(cboContaFinanceira, enSql.ContaCaixa, New Object() {iID_USUARIO})

    cmdAprovar.Enabled = FNC_Permissao(enPermissao.VEND_AprovacaodeFechamento).bGravar
    cmdBaixar.Enabled = FNC_Permissao(enPermissao.VEND_AprovacaodeFechamento).bGravar

    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String

    sSqlText = "SELECT CVFCM.SQ_CLINICA_VENDA_FECHAMENTO," &
                      "CVFCM.CD_CLINICA_VENDA_FECHAMENTO," &
                      "CTFIN.NO_CONTAFINANCEIRA," &
                      "CVFCM.DH_PERIODO_INICIO," &
                      "CVFCM.DH_PERIODO_FIM," &
                      "CLVND_CVDPC.VL_PROCEDIMENTO," &
                      "PESSO_FCMNT.NO_PESSOA NO_PESSOA_FECHAMENTO," &
                      "CVFCM.DH_FECHAMENTO," &
                      "PESSO_APROV.NO_PESSOA NO_PESSOA_APROVACAO," &
                      "CVFCM.DH_APROVACAO" &
               " FROM TB_CLINICA_VENDA_FECHAMENTO	CVFCM" &
                " INNER JOIN TB_CONTAFINANCEIRA	CTFIN ON CTFIN.SQ_CONTAFINANCEIRA = CVFCM.ID_CONTAFINANCEIRA" &
                " INNER JOIN TB_PESSOA PESSO_FCMNT ON PESSO_FCMNT.SQ_PESSOA = CVFCM.ID_PESSOA_FECHAMENTO" &
                "	INNER JOIN (SELECT CLVND.ID_CLINICA_VENDA_FECHAMENTO, SUM(VL_PROCEDIMENTO) VL_PROCEDIMENTO" &
                             " FROM TB_CLINICA_VENDA CLVND" &
                              " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVDPC ON CVDPC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                             " GROUP BY CLVND.ID_CLINICA_VENDA_FECHAMENTO) CLVND_CVDPC ON CLVND_CVDPC.ID_CLINICA_VENDA_FECHAMENTO = CVFCM.SQ_CLINICA_VENDA_FECHAMENTO" &
                 " LEFT JOIN TB_PESSOA PESSO_APROV ON PESSO_APROV.SQ_PESSOA = CVFCM.ID_PESSOA_APROVACAO"

    Select Case eCadastroVenda_Fechamento
      Case modDeclaracaoLocal.enCadastroVenda_Fechamento.eAprovacao
        sSqlText = sSqlText & " WHERE CVFCM.ID_PESSOA_APROVACAO IS NULL AND CVFCM.ID_PESSOA_FINANCEIRA IS NULL"
      Case modDeclaracaoLocal.enCadastroVenda_Fechamento.eFinanceiro
        sSqlText = sSqlText & " WHERE CVFCM.ID_PESSOA_APROVACAO IS NOT NULL AND CVFCM.ID_PESSOA_FINANCEIRA IS NULL"
    End Select

    sSqlText = sSqlText &
               " ORDER BY CTFIN.NO_CONTAFINANCEIRA, CVFCM.DH_PERIODO_INICIO"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_CLINICA_VENDA_FECHAMENTO,
                                                           const_GridListagem_CD_CLINICA_VENDA_FECHAMENTO,
                                                           const_GridListagem_NO_CONTAFINANCEIRA,
                                                           const_GridListagem_DH_PERIODO_INICIO,
                                                           const_GridListagem_DH_PERIODO_FIM,
                                                           const_GridListagem_VL_PROCEDIMENTO,
                                                           const_GridListagem_NO_PESSOA_FECHAMENTO,
                                                           const_GridListagem_DH_FECHAMENTO,
                                                           const_GridListagem_NO_PESSOA_APROVACAO,
                                                           const_GridListagem_DH_APROVACAO})

    oDBGrid_TipoProduto.Rows.Clear()
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdBaixar_Click(sender As Object, e As EventArgs) Handles cmdBaixar.Click
    If iSQ_CLINICA_VENDA_FECHAMENTO = 0 Then
      FNC_Mensagem("Selecione o fechamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboContaFinanceira) Then
      FNC_Mensagem("Selecione a conta caixa")
      Exit Sub
    End If

    If eCadastroVenda_Fechamento = modDeclaracaoLocal.enCadastroVenda_Fechamento.eAprovacao Then
      Gravar_Aprovacao()
    End If

    Gravar_Financeiro()

    FNC_Mensagem("Gravação Efetuada")

    Pesquisar()
  End Sub

  Private Sub Gravar_Aprovacao()
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CLINICA_VENDA_FECHAMENTO_APROVAR", False, "@SQ_CLINICA_VENDA_FECHAMENTO",
                                                                         "@ID_CONTAFINANCEIRA_APROVACAO",
                                                                         "@ID_PESSOA_FINANCEIRA",
                                                                         "@DH_FINANCEIRA")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA_FECHAMENTO", iSQ_CLINICA_VENDA_FECHAMENTO),
                         DBParametro_Montar("ID_CONTAFINANCEIRA_APROVACAO", cboContaFinanceira.SelectedValue),
                         DBParametro_Montar("ID_PESSOA_FINANCEIRA", iID_USUARIO),
                         DBParametro_Montar("DH_FINANCEIRA", Now(), SqlDbType.DateTime))
  End Sub

  Private Sub Gravar_Financeiro()
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CLINICA_VENDA_FECHAMENTO_FINANCEIRA", False, "@SQ_CLINICA_VENDA_FECHAMENTO",
                                                                            "@ID_CONTAFINANCEIRA_FINANCEIRA",
                                                                            "@ID_PESSOA_FINANCEIRA",
                                                                            "@DH_FINANCEIRA")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA_FECHAMENTO", iSQ_CLINICA_VENDA_FECHAMENTO),
                         DBParametro_Montar("ID_CONTAFINANCEIRA_FINANCEIRA", cboContaFinanceira.SelectedValue),
                         DBParametro_Montar("ID_PESSOA_FINANCEIRA", iID_USUARIO),
                         DBParametro_Montar("DH_FINANCEIRA", Now(), SqlDbType.DateTime))
  End Sub

  Private Sub grdListagem_ClickCell(sender As Object, e As ClickCellEventArgs) Handles grdListagem.ClickCell
    With e.Cell.Row
      iSQ_CLINICA_VENDA_FECHAMENTO = FNC_NuloZero(.Cells(const_GridListagem_SQ_CLINICA_VENDA_FECHAMENTO).Value)

      Dim sSqlText As String

      sSqlText = "SELECT CVFCM.SQ_CLINICA_VENDA_FECHAMENTO," &
                        "MVFNP.ID_TIPO_DOCUMENTO," &
                        "CVFCM.CD_CLINICA_VENDA_FECHAMENTO," &
                        "TPDOC.NO_TIPO_DOCUMENTO," &
                        "SUM(MVFNP.VL_PARCELA) VL_PARCELA" &
                 " FROM TB_CLINICA_VENDA_FECHAMENTO	CVFCM" &
                  " INNER JOIN TB_CLINICA_VENDA CLVND ON CLVND.ID_CLINICA_VENDA_FECHAMENTO = CVFCM.SQ_CLINICA_VENDA_FECHAMENTO" &
                  " INNER JOIN TB_MOVFINANCEIRA	MVFNC ON MVFNC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                                                   " AND MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                  " INNER JOIN TB_MOVFINANCEIRAPARCELA MVFNP ON MVFNP.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                  "	INNER JOIN TB_TIPO_DOCUMENTO TPDOC ON TPDOC.SQ_TIPO_DOCUMENTO = MVFNP.ID_TIPO_DOCUMENTO" &
                 " WHERE CVFCM.SQ_CLINICA_VENDA_FECHAMENTO = " & iSQ_CLINICA_VENDA_FECHAMENTO.ToString() &
                 " GROUP BY CVFCM.SQ_CLINICA_VENDA_FECHAMENTO," &
                           "MVFNP.ID_TIPO_DOCUMENTO," &
                           "CVFCM.CD_CLINICA_VENDA_FECHAMENTO," &
                           "TPDOC.NO_TIPO_DOCUMENTO"
      objGrid_Carregar(grdTipoProduto, sSqlText, New Integer() {const_GridTipoProduto_SQ_CLINICA_VENDA_FECHAMENTO,
                                                                const_GridTipoProduto_ID_TIPO_DOCUMENTO,
                                                                const_GridTipoProduto_CodigoFechamento,
                                                                const_GridTipoProduto_TipoDocumento,
                                                                const_GridTipoProduto_ValorTotal})
    End With
  End Sub

  Private Sub cmdAprovar_Click(sender As Object, e As EventArgs) Handles cmdAprovar.Click
    If iSQ_CLINICA_VENDA_FECHAMENTO = 0 Then
      FNC_Mensagem("Selecione o fechamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboContaFinanceira) Then
      FNC_Mensagem("Selecione a conta caixa")
      Exit Sub
    End If

    Gravar_Aprovacao()

    FNC_Mensagem("Gravação Efetuada")

    Pesquisar()
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If iSQ_CLINICA_VENDA_FECHAMENTO = 0 Then
      FNC_Mensagem("Selecione o fechamento")
    Else
      FormRelatorioCaixaPrestacaoContas(iSQ_CLINICA_VENDA_FECHAMENTO)
    End If
  End Sub
End Class