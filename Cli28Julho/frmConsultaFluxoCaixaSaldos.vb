Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaFluxoCaixaSaldos
  Const const_GridListagem_IC_TIPO As Integer = 0
  Const const_GridListagem_NO_CONTAFINANCEIRA As Integer = 1
  Const const_GridListagem_NO_TIPOMOVFINANCEIRA As Integer = 2
  Const const_GridListagem_NO_TIPO_DOCUMENTO As Integer = 3
  Const const_GridListagem_DT_EVENTO As Integer = 4
  Const const_GridListagem_DT_MOVIMENTACAO As Integer = 5
  Const const_GridListagem_NO_PESSOA As Integer = 6
  Const const_GridListagem_CD_MOVFINANCEIRA As Integer = 7
  Const const_GridListagem_VL_MOVIMENTACAO As Integer = 8
  Const const_GridListagem_VL_SALDO As Integer = 9
  Const const_GridListagem_NO_STATUS As Integer = 10
  Const const_GridListagem_NO_PLANOCONTAS As Integer = 11
  Const const_GridListagem_NO_PLANOCONTAS_GRUPO As Integer = 12

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Private Sub CmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboContaFinanceira.SelectedIndex = -1
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
    cboSegmento.SelectedIndex = -1
    cboPlanoContas.SelectedIndex = -1
  End Sub

  Private Sub CmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub FrmConsultaFluxoCaixaSaldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
    ComboBox_Carregar(cboContaFinanceira, enSql.ContaFinanceira)
    ComboBox_Carregar(cboSegmento, enSql.Segmento_ContasReceberContasPagar)
    ComboBox_Carregar(cboPlanoContas, enSql.PlanoContas)

    ComboBox_Carregar(cboSegmento, New String() {"<Sem segmento definido>"}, New Object() {0}, True, True)
    cboSegmento.SelectedIndex = -1

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "Tipo", 50)
    objGrid_Coluna_Add(grdListagem, "Conta Financeira", 150)
    objGrid_Coluna_Add(grdListagem, "Tipo de Movimentação", 200)
    objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 150)
    objGrid_Coluna_Add(grdListagem, "Data Efetiva", 150)
    objGrid_Coluna_Add(grdListagem, "Data da Movimentação", 150)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 300)
    objGrid_Coluna_Add(grdListagem, "Cód. Mov. Financeira", 150)
    objGrid_Coluna_Add(grdListagem, "Vlr. Movimentação", 150,,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Vlr. Saldo", 150,,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Status", 150)
    objGrid_Coluna_Add(grdListagem, "Plano de Contas", 150)
    objGrid_Coluna_Add(grdListagem, "Grupo de Plano de Contas", 150)
  End Sub

  Private Sub CmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String = ""

    If Not IsDate(txtDataInicial.Text) Or Not IsDate(txtDataFinal.Text) Then
      FNC_Mensagem("É preciso informar o período para gerar essa consulta")
      Exit Sub
    End If
    If txtDataInicial.DateTime.Date > txtDataFinal.DateTime.Date Then
      FNC_Mensagem("A data inicial não pode ser maior que a data final")
      Exit Sub
    End If

    sSqlText = "SELECT IC_TIPO," &
                      "NO_CONTAFINANCEIRA," &
                      "NO_TIPOMOVFINANCEIRA," &
                      "NO_TIPO_DOCUMENTO," &
                      "DT_EVENTO," &
                      "DT_MOVIMENTACAO," &
                      "ISNULL(NO_PESSOA_RELATORIO, NO_PESSOA) NO_PESSOA," &
                      "CD_MOVFINANCEIRA," &
                      "VL_MOVIMENTACAO," &
                      "VL_SALDO," &
                      "NO_STATUS," &
                      "NO_PLANOCONTAS," &
                      "NO_PLANOCONTAS_GRUPO" &
               " FROM FC_MOVFINANCEIRA_FLUXOCAIXA(" & iID_EMPRESA_FILIAL & "," _
                                                    & IIf(ComboBox_Selecionado(cboContaFinanceira), cboContaFinanceira.SelectedValue, "NULL") & ", " _
                                                    & IIf(ComboBox_Selecionado(cboSegmento), cboSegmento.SelectedValue, "NULL") & ", " _
                                                    & IIf(ComboBox_Selecionado(cboPlanoContas), cboPlanoContas.SelectedValue, "NULL") & ", " _
                                                    & FNC_QuotedStr(txtDataInicial.Text) & ", " _
                                                    & FNC_QuotedStr(txtDataFinal.Text) & ")" &
               " ORDER BY ID_CONTAFINANCEIRA, NR_GRUPO, SQ_MOVFINANCEIRA_FLUXOCAIXA"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_IC_TIPO,
                                                           const_GridListagem_NO_CONTAFINANCEIRA,
                                                           const_GridListagem_NO_TIPOMOVFINANCEIRA,
                                                           const_GridListagem_NO_TIPO_DOCUMENTO,
                                                           const_GridListagem_DT_EVENTO,
                                                           const_GridListagem_DT_MOVIMENTACAO,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_CD_MOVFINANCEIRA,
                                                           const_GridListagem_VL_MOVIMENTACAO,
                                                           const_GridListagem_VL_SALDO,
                                                           const_GridListagem_NO_STATUS,
                                                           const_GridListagem_NO_PLANOCONTAS,
                                                           const_GridListagem_NO_PLANOCONTAS_GRUPO})
  End Sub

  Private Sub frmConsultaFluxoCaixaSaldos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdExcel.Left = 5
    cmdExcel.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdPDF.Top = cmdExcel.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdExcel.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub
End Class