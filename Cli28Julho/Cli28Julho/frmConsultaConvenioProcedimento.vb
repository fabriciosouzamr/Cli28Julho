Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaConvenioProcedimento
  Const const_GridListagem_ID_EMPRESA As Integer = 0
  Const const_GridListagem_ID_PROCEDIMENTO As Integer = 1
  Const const_GridListagem_ID_PESSOA_PROFISSIONAL As Integer = 2
  Const const_GridListagem_SQ_CONVENIO_PROCEDIMENTO As Integer = 3
  Const const_GridListagem_IC_PROFISSIONAL As Integer = 4
  Const const_GridListagem_IC_ATIVO As Integer = 5
  Const const_GridListagem_NO_CONVENIO As Integer = 6
  Const const_GridListagem_NO_PPROCEDIMENTO As Integer = 7
  Const const_GridListagem_NO_PESSOA As Integer = 8
  Const const_GridListagem_VL_PROCEDIMENTO As Integer = 9
  Const const_GridListagem_CM_OBSERVACAO As Integer = 10
  Const const_GridListagem_IC_PADRAO As Integer = 11

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub frmConsultaConvenioProcedimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboConvenio, enSql.Convenio_Ativo)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "ID_EMPRESA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_CONVENIO_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "IC_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdListagem, "Ativo", 50)
    objGrid_Coluna_Add(grdListagem, "Convênvio", 300)
    objGrid_Coluna_Add(grdListagem, "Procedimento", 300)
    objGrid_Coluna_Add(grdListagem, "Profissional/Prestador", 300)
    objGrid_Coluna_Add(grdListagem, "Vlr. Procedimento", 100)
    objGrid_Coluna_Add(grdListagem, "Observação", 300)
    objGrid_Coluna_Add(grdListagem, "Padrão", 50)
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""

    sSqlText = "SELECT CONVE.ID_EMPRESA," &
                      "PROCE.SQ_PROCEDIMENTO," &
                      "PESSO.SQ_PESSOA," &
                      "PSEMP.IC_PROFISSIONAL," &
                      "CVPCD.SQ_CONVENIO_PROCEDIMENTO," &
                      "IIF(ISNULL(CVPCD.IC_ATIVO, 'S') = 'S', 'Sim', 'Não')," &
                      "CONVE.NO_CONVENIO," &
                      "PROCE.NO_PROCEDIMENTO," &
                      "PESSO.NO_PESSOA," &
                      "CVPCD.VL_PROCEDIMENTO," &
                      "CVPCD.CM_OBSERVACAO," &
                      "IIF(ISNULL(CVPCD.IC_PADRAO, 'N') = 'S', 'Sim', 'Não')" &
               " FROM TB_CONVENIO_PROCEDIMENTO CVPCD" &
                " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = CVPCD.ID_CONVENIO" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVPCD.ID_PROCEDIMENTO" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL" &
                "	INNER JOIN TB_PESSOA_EMPRESA PSEMP ON PSEMP.ID_PESSOA = PESSO.SQ_PESSOA"

    If psqProcedimento.Identificador > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "CVPCD.ID_PROCEDIMENTO = " & psqProcedimento.Identificador, " AND ")
    End If
    If ComboBox_Selecionado(cboConvenio) Then
      FNC_Str_Adicionar(sSqlText_Where, "CVPCD.ID_CONVENIO = " & cboConvenio.SelectedValue, " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " WHERE " & sSqlText_Where
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_EMPRESA,
                                                           const_GridListagem_ID_PROCEDIMENTO,
                                                           const_GridListagem_ID_PESSOA_PROFISSIONAL,
                                                           const_GridListagem_IC_PROFISSIONAL,
                                                           const_GridListagem_SQ_CONVENIO_PROCEDIMENTO,
                                                           const_GridListagem_IC_ATIVO,
                                                           const_GridListagem_NO_CONVENIO,
                                                           const_GridListagem_NO_PPROCEDIMENTO,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_VL_PROCEDIMENTO,
                                                           const_GridListagem_CM_OBSERVACAO,
                                                           const_GridListagem_IC_PADRAO})
  End Sub
End Class