Imports Infragistics.Win

Public Class frmCadastroVenda_Fechamento
  Const const_GridListagem_SQ_MOVFINANCEIRA As Integer = 0
  Const const_GridListagem_SQ_CLINICA_VENDA As Integer = 1
  Const const_GridListagem_CD_CLINICA_VENDA As Integer = 2
  Const const_GridListagem_DH_VENDA As Integer = 3
  Const const_GridListagem_NO_TIPO_DOCUMENTO As Integer = 4
  Const const_GridListagem_CD_DOCUMENTO As Integer = 5
  Const const_GridListagem_DT_VENCIMENTO As Integer = 6
  Const const_GridListagem_VL_PARCELA As Integer = 7

  Const const_GridResultado_NO_TIPO_DOCUMENTO As Integer = 0
  Const const_GridResultado_VL_TIPO_DOCUMENTO As Integer = 1
  Const const_GridResultado_DH_VENDA_INI As Integer = 2
  Const const_GridResultado_DH_VENDA_FIM As Integer = 3

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Dim oDBGridResultado As New UltraWinDataSource.UltraDataSource
  Dim iSQ_CLINICA_VENDA_FECHAMENTO As Integer

  Private Sub frmCadastroVenda_Fechamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboContaFinanceira, enSql.ContaCaixa, New Object() {iID_USUARIO})

    If cboContaFinanceira.Items.Count = 1 Then
      cboContaFinanceira.SelectedIndex = 0
    Else
      cboContaFinanceira.Enabled = True
    End If

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_CLINICA_VENDA", 0)
    objGrid_Coluna_Add(grdListagem, "Código da Venda", 150)
    objGrid_Coluna_Add(grdListagem, "D/H da Venda", 100, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 200)
    objGrid_Coluna_Add(grdListagem, "Código de Documento", 150)
    objGrid_Coluna_Add(grdListagem, "Data de Vencimento", 150, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdListagem, "Valor da Parcela", 150, , , , , const_Formato_Valor)

    objGrid_Inicializar(grdResultado, , oDBGridResultado, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdResultado, "Tipo de Documento", 300)
    objGrid_Coluna_Add(grdResultado, "Valor da Parcela", 200, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdResultado, "Início Venda", 130, , , , , const_Formato_Data)
    objGrid_Coluna_Add(grdResultado, "Fim Venda", 130, , , , , const_Formato_Data)

    cmdGravar.Enabled = FNC_Permissao(enPermissao.VEND_Fechamento).bGravar
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String

    sSqlText = "SELECT SQ_MOVFINANCEIRA," &
                      "SQ_CLINICA_VENDA," &
                      "CD_CLINICA_VENDA," &
                      "DH_VENDA," &
                      "NO_TIPO_DOCUMENTO," &
                      "CD_DOCUMENTO," &
                      "DT_VENCIMENTO," &
                      "VL_PARCELA" &
                " FROM VW_CLINICA_VENDA_PENDENTEFECHARCAIXA" &
                " WHERE ID_CONTAFINANCEIRA = " & FNC_NuloZero(cboContaFinanceira.SelectedValue) &
                " ORDER BY CD_CLINICA_VENDA," &
                          "NO_TIPO_DOCUMENTO," &
                          "CD_DOCUMENTO"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_MOVFINANCEIRA,
                                                           const_GridListagem_SQ_CLINICA_VENDA,
                                                           const_GridListagem_CD_CLINICA_VENDA,
                                                           const_GridListagem_DH_VENDA,
                                                           const_GridListagem_NO_TIPO_DOCUMENTO,
                                                           const_GridListagem_CD_DOCUMENTO,
                                                           const_GridListagem_DT_VENCIMENTO,
                                                           const_GridListagem_VL_PARCELA})

    sSqlText = "SELECT NO_TIPO_DOCUMENTO," &
                      "SUM(VL_PARCELA) VL_PARCELA," &
                      "MIN(DH_VENDA)," &
                      "MAX(DH_VENDA)" &
               " FROM VW_CLINICA_VENDA_PENDENTEFECHARCAIXA" &
                " WHERE ID_CONTAFINANCEIRA = " & FNC_NuloZero(cboContaFinanceira.SelectedValue) &
               " GROUP BY NO_TIPO_DOCUMENTO" &
               " ORDER BY NO_TIPO_DOCUMENTO"
    objGrid_Carregar(grdResultado, sSqlText, New Integer() {const_GridResultado_NO_TIPO_DOCUMENTO,
                                                            const_GridResultado_VL_TIPO_DOCUMENTO,
                                                            const_GridResultado_DH_VENDA_INI,
                                                            const_GridResultado_DH_VENDA_FIM})

    cmdGravar.Enabled = True
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If grdListagem.Rows.Count = 0 Then
      FNC_Mensagem("Não existe nenhuma venda listadas para o fechamento de caixa")
      Exit Sub
    End If

    cmdGravar.Enabled = False

    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = DBMontar_SP("SP_CLINICA_VENDA_FECHAMENTO_CAD", False, "@SQ_CLINICA_VENDA_FECHAMENTO OUT",
                                                                     "@ID_CONTAFINANCEIRA",
                                                                     "@ID_PESSOA_FECHAMENTO",
                                                                     "@DH_FECHAMENTO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA_FECHAMENTO", iSQ_CLINICA_VENDA_FECHAMENTO,, ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_CONTAFINANCEIRA", cboContaFinanceira.SelectedValue),
                            DBParametro_Montar("ID_PESSOA_FECHAMENTO", iID_USUARIO),
                            DBParametro_Montar("DH_FECHAMENTO", Now(), SqlDbType.DateTime)) Then
      If DBTeveRetorno() And iSQ_CLINICA_VENDA_FECHAMENTO = 0 Then
        iSQ_CLINICA_VENDA_FECHAMENTO = Convert.ToInt32(DBRetorno(1))
      End If
    End If

    sSqlText = DBMontar_SP("SP_FECHAMENTO_CLINICA_VENDA_INS", False, "@SQ_CLINICA_VENDA_FECHAMENTO",
                                                                     "@SQ_CLINICA_VENDA")

    For iCont = 0 To grdListagem.Rows.Count - 1
      With grdListagem.Rows(iCont)
        DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA_FECHAMENTO", iSQ_CLINICA_VENDA_FECHAMENTO),
                             DBParametro_Montar("SQ_CLINICA_VENDA", .Cells(const_GridListagem_SQ_CLINICA_VENDA).Value))
      End With
    Next

    cmdPesquisar.Enabled = False
    cmdGravar.Enabled = False

    FNC_Mensagem("Fechamento de caixa realizado")
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If iSQ_CLINICA_VENDA_FECHAMENTO > 0 Then
      FormRelatorioCaixaPrestacaoContas(iSQ_CLINICA_VENDA_FECHAMENTO)
    Else
      FormRelatorioCaixaPrestacaoContasFechamento(FNC_NuloZero(cboContaFinanceira.SelectedValue))
    End If
  End Sub
End Class