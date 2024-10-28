Imports Infragistics.Win

Public Class frmConsultaMinhasFaturas
  Const const_GridListagem_CD_CLINICA_VENDA As Integer = 0
  Const const_GridListagem_DH_VENDA As Integer = 1
  Const const_GridListagem_CD_AGENDAMENTO As Integer = 2
  Const const_GridListagem_NO_PESSOA As Integer = 3
  Const const_GridListagem_NO_PROCEDIMENTO As Integer = 4
  Const const_GridListagem_NO_TIPO_ATENDIMENTO As Integer = 5
  Const const_GridListagem_NO_CONVENIO As Integer = 6
  Const const_GridListagem_VL_REPASSE As Integer = 7
  Const const_GridListagem_NO_TURNO As Integer = 8
  Const const_GridListagem_NO_PESSOA_VENDA As Integer = 9

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Dim sSqlText As String

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaMinhasFaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "Cód / Autorização", 100)
    objGrid_Coluna_Add(grdListagem, "Data", 100, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Cód Agendamento", 100)
    objGrid_Coluna_Add(grdListagem, "Paciente", 100)
    objGrid_Coluna_Add(grdListagem, "Procedimento / Exame", 100)
    objGrid_Coluna_Add(grdListagem, "Tipo de Atendimento", 100)
    objGrid_Coluna_Add(grdListagem, "Convênio", 100)
    objGrid_Coluna_Add(grdListagem, "Valor Prestador(a)", 100)
    objGrid_Coluna_Add(grdListagem, "Turno", 100)
    objGrid_Coluna_Add(grdListagem, "Pessoa Venda", 100)

    ComboBox_Carregar(cboTurno, enSql.Turno)

    Limpar()
  End Sub

  Private Sub Limpar()
    txtPeriodoInicial.DateTime = Now.Date
    txtPeriodoFinal.DateTime = Now.Date

    cboTurno.SelectedIndex = -1

    optTotal.Checked = True

    oDBGrid.Rows.Clear()
  End Sub

  Private Sub Carregar()
    sSqlText = $"SELECT CLVND.CD_CLINICA_VENDA,
                        AGEND.DH_AGENDAMENTO,
                        AGEND.CD_AGENDAMENTO,
	                      PESSOAPACIENTE.NO_PESSOA AS NOMEPACIENTE,
                        PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL,
                        PROCE.NO_PROCEDIMENTO,
                        ISNULL(IIF(CLVND.ID_ORCAMENTO_CLIENTE IS NOT NULL, 'Exames', TPCST.NO_TIPO_CONSULTA), 'Venda Direta') NO_TIPO_ATENDIMENTO,
                        CONVE.NO_CONVENIO,
                        CVDPC.VL_REPASSE,
                        TUR.NO_TURNO,
                        PESSO.NO_PESSOA
                  FROM TB_CLINICA_VENDA CLVND
                   INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVDPC ON CVDPC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA
                   INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA
                   INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CVDPC.ID_PESSOA_PROFISSIONAL
                   INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVDPC.ID_PROCEDIMENTO
                   INNER JOIN TB_AGENDAMENTO AGEND ON (AGEND.SQ_AGENDAMENTO = CVDPC.ID_AGENDAMENTO OR AGEND.ID_CLINICA_VENDA_PROCEDIMENTO = CVDPC.SQ_CLINICA_VENDA_PROCEDIMENTO)
                   INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO
                    LEFT JOIN TB_PESSOA PESSOAPACIENTE ON PESSOAPACIENTE.SQ_PESSOA = AGEND.ID_PESSOA
                    LEFT JOIN TB_TIPO_CONSULTA TPCST ON TPCST.SQ_TIPO_CONSULTA = AGEND.ID_TIPO_CONSULTA
                    LEFT JOIN TB_TURNO TUR ON dbo.FC_DATAHORA_MONTAR(GETDATE(), FORMAT(AGEND.DH_AGENDAMENTO, 'HH:mm:ss')) >= dbo.FC_DATAHORA_MONTAR(GETDATE(), TUR.HR_INICIO)
	                                        AND dbo.FC_DATAHORA_MONTAR(GETDATE(), FORMAT(AGEND.DH_AGENDAMENTO, 'HH:mm:ss')) <= dbo.FC_DATAHORA_MONTAR(GETDATE(), TUR.HR_FIM)
                  WHERE CVDPC.ID_PESSOA_PROFISSIONAL IN ({iID_USUARIO})
                    AND CLVND.DH_CANCELAR IS NULL
                    AND AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Atendido.GetHashCode()

    If optConsultas.Checked Then
      sSqlText = sSqlText &
                 " AND PROCE.ID_OPT_TIPOPROCEDIMENTO = " & enOpcoes.TipoProcedimento_Procedimento.GetHashCode()
    ElseIf optExames.Checked Then
      sSqlText = sSqlText &
                 " AND PROCE.ID_OPT_TIPOPROCEDIMENTO = " & enOpcoes.TipoProcedimento_Exame.GetHashCode()
    End If
    If IsDate(txtPeriodoInicial.Text) Then
      sSqlText = sSqlText & " AND CAST(AGEND.DH_AGENDAMENTO AS DATE) >= " & FNC_QuotedStr(txtPeriodoInicial.Text)
    End If
    If IsDate(txtPeriodoFinal.Text) Then
      sSqlText = sSqlText & " AND CAST(AGEND.DH_AGENDAMENTO AS DATE) <= " & FNC_QuotedStr(txtPeriodoFinal.Text)
    End If
    If ComboBox_Selecionado(cboTurno) Then
      sSqlText = sSqlText & " AND TUR.SQ_TURNO = " & cboTurno.SelectedValue
    End If

    sSqlText = sSqlText & " ORDER BY AGEND.DH_AGENDAMENTO"

    objGrid_Carregar(grdListagem,
                     sSqlText.Replace("PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL,", ""),
                     New Integer() {const_GridListagem_CD_CLINICA_VENDA,
                                    const_GridListagem_DH_VENDA,
                                    const_GridListagem_CD_AGENDAMENTO,
                                    const_GridListagem_NO_PESSOA,
                                    const_GridListagem_NO_PROCEDIMENTO,
                                    const_GridListagem_NO_TIPO_ATENDIMENTO,
                                    const_GridListagem_NO_CONVENIO,
                                    const_GridListagem_VL_REPASSE,
                                    const_GridListagem_NO_TURNO,
                                    const_GridListagem_NO_PESSOA_VENDA})
    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VL_REPASSE})
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Carregar()
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If grdListagem.Rows.Count = 0 Then
      FNC_Mensagem("Pesquise antes de gerar a impressão")
    Else
      FormRelatorioConsultaMinhasFaturas(sSqlText)
    End If
  End Sub

  Private Sub cboTurno_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTurno.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboTurno.SelectedIndex = -1
    End If
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    Limpar()
  End Sub
End Class