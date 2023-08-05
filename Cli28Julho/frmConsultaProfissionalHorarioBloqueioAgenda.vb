Imports Infragistics.Win

Public Class frmConsultaProfissionalHorarioBloqueioAgenda
  Const const_GridListagem_SQ_PESSOA_HORARIO_BLOQUEIO As Integer = 0
  Const const_GridListagem_SQ_PESSOA_HORARIO_BLOQUEIO_PESSOA As Integer = 1
  Const const_GridListagem_NO_EMPRESA As Integer = 2
  Const const_GridListagem_NO_PESSOA As Integer = 3
  Const const_GridListagem_DT_BLOQUEIO_INCIO As Integer = 4
  Const const_GridListagem_DT_BLOQUEIO_FIM As Integer = 5
  Const const_GridListagem_NO_USUARIO As Integer = 6

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboProfissional.SelectedIndex = -1
    cboEmpresa.SelectedIndex = -1
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
  End Sub

  Private Sub frmConsultaProfissionalHorarioBloqueioAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboEmpresa, enSql.Empresa)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_PESSOA_HORARIO_BLOQUEIO", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_PESSOA_HORARIO_BLOQUEIO_PESSOA", 0)
    objGrid_Coluna_Add(grdListagem, "Empresa", 0)
    objGrid_Coluna_Add(grdListagem, "Profissional", 300)
    objGrid_Coluna_Add(grdListagem, "Data do Bloqueio Início", 150, , , UltraWinGrid.ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "Data do Bloqueio Fim", 150, , , UltraWinGrid.ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "Usuário", 300)

    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Where As String

    If (IsDate(txtDataInicial.Text) Or IsDate(txtDataInicial.Text)) And
       (Not IsDate(txtDataInicial.Text) Or Not IsDate(txtDataInicial.Text)) Then
      FNC_Mensagem("Informe a data inicial e a data final do período")
      Exit Sub
    End If

    sSqlText = "SELECT SQ_PESSOA_HORARIO_BLOQUEIO," &
                      "SQ_PESSOA_HORARIO_BLOQUEIO_PESSOA," &
                      "ID_EMPRESA," &
                      "NO_PESSOA," &
                      "DT_BLOQUEIO_INCIO," &
                      "DT_BLOQUEIO_FIM," &
                      "NO_USUARIO" &
               " FROM VW_PESSOA_HORARIO_BLOQUEIO"

    If ComboBox_Selecionado(cboProfissional) Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_PESSOA = " & cboProfissional.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboEmpresa) Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_EMPRESA = " & cboEmpresa.SelectedValue, " AND ")
    End If
    If IsDate(txtDataInicial.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, "((CAST(DT_BLOQUEIO_INCIO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text) & " AND " &
                                          "CAST(DT_BLOQUEIO_FIM AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text) & ") OR" &
                                         "(CAST(DT_BLOQUEIO_INCIO AS DATE) <= " & FNC_QuotedStr(txtDataInicial.Text) & " AND " &
                                          "CAST(DT_BLOQUEIO_FIM AS DATE) >= " & FNC_QuotedStr(txtDataFinal.Text) & "))", " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then sSqlText = sSqlText & " WHERE " & sSqlText_Where

    sSqlText = sSqlText &
               " ORDER BY NO_PESSOA, DT_BLOQUEIO_INCIO"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_PESSOA_HORARIO_BLOQUEIO,
                                                           const_GridListagem_SQ_PESSOA_HORARIO_BLOQUEIO_PESSOA,
                                                           const_GridListagem_NO_EMPRESA,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_DT_BLOQUEIO_INCIO,
                                                           const_GridListagem_DT_BLOQUEIO_FIM,
                                                           const_GridListagem_NO_USUARIO})
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(frmCadastroProfissionalHorarioBloqueioAgenda)
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o bloqueio a ser excluído")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_HORARIO_BLOQUEIO_DEL", False, "@SQ_PESSOA_HORARIO_BLOQUEIO_PESSOA")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_HORARIO_BLOQUEIO_PESSOA", objGrid_Valor(grdListagem, const_GridListagem_SQ_PESSOA_HORARIO_BLOQUEIO_PESSOA)))

    Pesquisar()
  End Sub
End Class