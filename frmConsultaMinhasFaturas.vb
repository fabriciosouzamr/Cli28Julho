Imports Infragistics.Win

Public Class frmConsultaMinhasFaturas
  Const const_GridListagem_CD_CLINICA_VENDA As Integer = 0
  Const const_GridListagem_DH_VENDA As Integer = 1
  Const const_GridListagem_NO_PESSOA As Integer = 2
  Const const_GridListagem_NO_PROCEDIMENTO As Integer = 3
  Const const_GridListagem_NO_TIPO_ATENDIMENTO As Integer = 4
  Const const_GridListagem_NO_CONVENIO As Integer = 5
  Const const_GridListagem_VL_REPASSE As Integer = 6

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaMinhasFaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "Cód / Autorização", 100)
    objGrid_Coluna_Add(grdListagem, "Data", 100, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Paciente", 100)
    objGrid_Coluna_Add(grdListagem, "Procedimento / Exame", 100)
    objGrid_Coluna_Add(grdListagem, "Tipo de Atendimento", 100)
    objGrid_Coluna_Add(grdListagem, "Convênio", 100)
    objGrid_Coluna_Add(grdListagem, "Valor Prestador(a)", 100)

    txtPeriodoInicial.Value = Date.Now.Date
    txtPeriodoFinal.Value = Date.Now.Date

    Limpar()
  End Sub

  Private Sub Limpar()
    txtPeriodoInicial.Text = ""
    txtPeriodoFinal.Text = ""

    optTotal.Checked = True
  End Sub

  Private Sub Carregar()
    Dim sSqlText As String

    sSqlText = "SELECT CLVND.CD_CLINICA_VENDA," &
                      "CLVND.DH_VENDA," &
                      "PESSO.NO_PESSOA," &
                      "PROCE.NO_PROCEDIMENTO," &
                      "ISNULL(IIF(CLVND.ID_ORCAMENTO_CLIENTE IS NOT NULL, 'Exames', TPCST.NO_TIPO_CONSULTA), 'Venda Direta') NO_TIPO_ATENDIMENTO," &
                      "CONVE.NO_CONVENIO," &
                      "CVDPC.VL_REPASSE" &
               " FROM TB_CLINICA_VENDA CLVND" &
                " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVDPC ON CVDPC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVDPC.ID_PROCEDIMENTO" &
                " INNER JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CVDPC.ID_AGENDAMENTO" &
                " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO" &
                 " LEFT JOIN TB_TIPO_CONSULTA TPCST ON TPCST.SQ_TIPO_CONSULTA = AGEND.ID_TIPO_CONSULTA" &
               " WHERE CVDPC.ID_PESSOA_PROFISSIONAL = " & iID_USUARIO &
                 " AND AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Atendido.GetHashCode()

    If optConsultas.Checked Then
      sSqlText = sSqlText &
                 " AND PROCE.ID_OPT_TIPOPROCEDIMENTO = " & enOpcoes.TipoProcedimento_Procedimento.GetHashCode()
    ElseIf optExames.Checked Then
      sSqlText = sSqlText &
                 " AND PROCE.ID_OPT_TIPOPROCEDIMENTO = " & enOpcoes.TipoProcedimento_Exame.GetHashCode()
    End If
    If IsDate(txtPeriodoInicial.Text) Then
      sSqlText = sSqlText & " AND CAST(CLVND.DH_VENDA AS DATE) >= " & FNC_QuotedStr(txtPeriodoInicial.Text)
    End If
    If IsDate(txtPeriodoFinal.Text) Then
      sSqlText = sSqlText & " AND CAST(CLVND.DH_VENDA AS DATE) <= " & FNC_QuotedStr(txtPeriodoFinal.Text)
    End If

    sSqlText = sSqlText & " ORDER BY CLVND.DH_VENDA"

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_CD_CLINICA_VENDA,
                                                           const_GridListagem_DH_VENDA,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_NO_PROCEDIMENTO,
                                                           const_GridListagem_NO_TIPO_ATENDIMENTO,
                                                           const_GridListagem_NO_CONVENIO,
                                                           const_GridListagem_VL_REPASSE})
    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VL_REPASSE})
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Carregar()
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub
End Class