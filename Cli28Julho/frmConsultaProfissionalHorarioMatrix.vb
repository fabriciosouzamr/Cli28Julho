Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.ComponentModel

Public Class frmConsultaProfissionalHorarioMatrix
  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Dim bEmProcessamento As Boolean
  Dim bFormCarregado As Boolean

  Private Sub frmConsultaProfissionalHorarioMatrix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    bEmProcessamento = True
    bFormCarregado = True
    ComboBox_Carregar(cboEmpresa, enSql.EmpresaAtiva)
    ComboBox_CarregarMeses(cboTipoCalendário_Mensal_Mes)
    ComboBox_CarregarSemanas(cboTipoCalendário_Semanal_Semana, Now.Year)
    ComboBox_Selecionar(cboTipoCalendário_Mensal_Mes, Now.Month)
    ComboBox_Selecionar(cboEmpresa, iID_EMPRESA_FILIAL)
    optTipoCalendário_Semanal.Checked = True
    CarregarSemanal()
    bEmProcessamento = False
  End Sub

  Private Sub optTipoCalendário_Semanal_CheckedChanged(sender As Object, e As EventArgs) Handles optTipoCalendário_Semanal.CheckedChanged
    pnlTipoCalendário_Mensal.Visible = False
    pnlTipoCalendário_Semanal.Top = 5
    pnlTipoCalendário_Semanal.Left = 411
    pnlTipoCalendário_Semanal.Visible = True
    If bFormCarregado Then CarregarSemanal()
    CarregarHorario()
  End Sub

  Private Sub optTipoCalendário_Mensal_CheckedChanged(sender As Object, e As EventArgs) Handles optTipoCalendário_Mensal.CheckedChanged
    pnlTipoCalendário_Semanal.Visible = False
    pnlTipoCalendário_Mensal.Top = 5
    pnlTipoCalendário_Mensal.Left = 411
    pnlTipoCalendário_Mensal.Visible = True
    If bFormCarregado Then CarregarMensal()
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdTipoCalendário_Mensal_Carregar_Click(sender As Object, e As EventArgs) Handles cmdTipoCalendário_Mensal_Carregar.Click
    If Not ComboBox_Selecionado(cboTipoCalendário_Mensal_Mes) Then
      FNC_Mensagem("Selecione o mês")
      Exit Sub
    End If
    If txtTipoCalendário_Mensal_Ano.Value < 1900 Then
      FNC_Mensagem("Informe um ano válido")
      Exit Sub
    End If

    GridLimpar()

    Dim oData As DataTable
    Dim sSqlText As String
    Dim iLinha As Integer
    Dim iColuna As Integer
    Dim bValido As Boolean
    Dim dMes_Ini As Date
    Dim dMes_Fim As Date
    Dim dUtil As Date

    dMes_Ini = New Date(txtTipoCalendário_Mensal_Ano.Value, cboTipoCalendário_Mensal_Mes.SelectedValue, 1)
    dMes_Fim = dMes_Ini.AddMonths(1).AddDays(-1)

    sSqlText = "SELECT CONCAT(PSHRR.HR_INICIO, '-', PSHRR.HR_FIM, CHAR(13)+CHAR(10), PESSO.NO_PESSOA, ' (', PROCE.NO_PROCEDIMENTO, ')') DS_HORARIO, DT_ESPECIAL, ISNULL(OPCAO_DISMN.SQ_OPCAO, OPCAO_DISMN2.SQ_OPCAO) SQ_OPCAO" &
               " FROM TB_PESSOA_HORARIO	PSHRR" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PSHRR.ID_PESSOA" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = PSHRR.ID_PROCEDIMENTO" &
                 " LEFT JOIN TB_OPCAO OPCAO_DISMN ON OPCAO_DISMN.SQ_OPCAO = PSHRR.ID_OPT_DIA_SEMANA" &
                 " LEFT JOIN TB_OPCAO OPCAO_DISMN2 ON OPCAO_DISMN2.CD_OPCAO = DATEPART(W, DT_ESPECIAL)" &
                                                " AND OPCAO_DISMN2.ID_TIPO_OPCAO = " & enTipoOpcao.DiasSemana.GetHashCode() &
               " WHERE PSHRR.ID_EMPRESA = " & cboEmpresa.SelectedValue &
                " AND (PSHRR.DT_ESPECIAL IS NULL OR (PSHRR.DT_ESPECIAL >= '" & dMes_Ini & "' AND " &
                                                    "PSHRR.DT_ESPECIAL <= '" & dMes_Fim & "'))" &
               " ORDER BY CONCAT(PSHRR.HR_INICIO, '-', PSHRR.HR_FIM, ' ', PESSO.NO_PESSOA, ' (', PROCE.NO_PROCEDIMENTO, ')')"
    oData = DBQuery(sSqlText)

    For Each oRow As DataRow In oData.Rows
      bValido = False

      For iColuna = 1 To grdListagem.DisplayLayout.Bands(0).Columns.Count - 1
        bValido = (grdListagem.DisplayLayout.Bands(0).Columns(iColuna).Tag = FNC_NVL(oRow.Item("SQ_OPCAO"), 0))

        If Not FNC_CampoNulo(oRow.Item("DT_ESPECIAL")) Then
          dUtil = oRow.Item("DT_ESPECIAL")
        End If

        If bValido Then
          For iLinha = 0 To grdListagem.Rows.Count - 1
            If FNC_NVL(grdListagem.Rows(iLinha).Cells(0).Value, "") = "T" Then
              If Val(grdListagem.Rows(iLinha).Cells(iColuna).Value) = dUtil.Day And Not FNC_CampoNulo(oRow.Item("DT_ESPECIAL")) Then
                If FNC_NVL(grdListagem.Rows(iLinha + 1).Cells(iColuna).Value, "").ToString().Trim() = "" Then
                  grdListagem.Rows(iLinha + 1).Cells(iColuna).Value = oRow.Item("DS_HORARIO")
                Else
                  grdListagem.Rows(iLinha + 1).Cells(iColuna).Value = grdListagem.Rows(iLinha + 1).Cells(iColuna).Value & Environment.NewLine & oRow.Item("DS_HORARIO")
                End If
                Exit For
              End If
            Else
              If FNC_CampoNulo(oRow.Item("DT_ESPECIAL")) Then
                If FNC_NVL(grdListagem.Rows(iLinha).Cells(iColuna).Value, "").ToString().Trim() = "" Then
                  grdListagem.Rows(iLinha).Cells(iColuna).Value = oRow.Item("DS_HORARIO")
                Else
                  grdListagem.Rows(iLinha).Cells(iColuna).Value = grdListagem.Rows(iLinha).Cells(iColuna).Value & Environment.NewLine & oRow.Item("DS_HORARIO")
                End If
              End If
            End If
          Next
        End If
      Next
    Next

    oData = Nothing
  End Sub

  Public Sub CarregarMensal()
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.Default, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "TIPO", 0)
    objGrid_Coluna_Add(grdListagem, "DOM", 135).Tag = enDiasSemanaPessoaHorario.Domingo
    objGrid_Coluna_Add(grdListagem, "SEG", 135).Tag = enDiasSemanaPessoaHorario.Segunda
    objGrid_Coluna_Add(grdListagem, "TER", 135).Tag = enDiasSemanaPessoaHorario.Terca
    objGrid_Coluna_Add(grdListagem, "QUA", 135).Tag = enDiasSemanaPessoaHorario.Quarta
    objGrid_Coluna_Add(grdListagem, "QUI", 135).Tag = enDiasSemanaPessoaHorario.Quinta
    objGrid_Coluna_Add(grdListagem, "SEX", 135).Tag = enDiasSemanaPessoaHorario.Sexta
    objGrid_Coluna_Add(grdListagem, "SÁB", 135).Tag = enDiasSemanaPessoaHorario.Sabado

    grdListagem.DisplayLayout.Override.WrapHeaderText = DefaultableBoolean.True
    grdListagem.DisplayLayout.Override.CellMultiLine = DefaultableBoolean.True
    grdListagem.DisplayLayout.Bands(0).Columns(1).CellMultiLine = DefaultableBoolean.True
    grdListagem.DisplayLayout.Override.RowSizing = RowSizing.Free
    grdListagem.DisplayLayout.Bands(0).Override.RowSizing = RowSizing.Free
    grdListagem.DisplayLayout.Override.RowSizingAutoMaxLines = 20

    oDBGrid.Rows.Clear()

    Dim oDataInicial As Date

    oDataInicial = New DateTime(txtTipoCalendário_Mensal_Ano.Value, cboTipoCalendário_Mensal_Mes.SelectedValue, 1)
    oDataInicial = oDataInicial.AddDays(0 - oDataInicial.DayOfWeek)

    objGrid_Linha_Add(grdListagem, New Object() {0, "T",
                                                 1, oDataInicial.Day,
                                                 2, oDataInicial.AddDays(1).Day,
                                                 3, oDataInicial.AddDays(2).Day,
                                                 4, oDataInicial.AddDays(3).Day,
                                                 5, oDataInicial.AddDays(4).Day,
                                                 6, oDataInicial.AddDays(5).Day,
                                                 7, oDataInicial.AddDays(6).Day})
    objGrid_Linha_Add(grdListagem, New Object() {0, "D", 1, " ", 2, " ", 3, " ", 4, " ", 5, " ", 6, " ", 7, " "})
    oDataInicial = oDataInicial.AddDays(7)
    objGrid_Linha_Add(grdListagem, New Object() {0, "T",
                                                 1, oDataInicial.Day,
                                                 2, oDataInicial.AddDays(1).Day,
                                                 3, oDataInicial.AddDays(2).Day,
                                                 4, oDataInicial.AddDays(3).Day,
                                                 5, oDataInicial.AddDays(4).Day,
                                                 6, oDataInicial.AddDays(5).Day,
                                                 7, oDataInicial.AddDays(6).Day})
    objGrid_Linha_Add(grdListagem, New Object() {0, "D", 1, " ", 2, " ", 3, " ", 4, " ", 5, " ", 6, " ", 7, " "})
    oDataInicial = oDataInicial.AddDays(7)
    objGrid_Linha_Add(grdListagem, New Object() {0, "T",
                                                 1, oDataInicial.Day,
                                                 2, oDataInicial.AddDays(1).Day,
                                                 3, oDataInicial.AddDays(2).Day,
                                                 4, oDataInicial.AddDays(3).Day,
                                                 5, oDataInicial.AddDays(4).Day,
                                                 6, oDataInicial.AddDays(5).Day,
                                                 7, oDataInicial.AddDays(6).Day})
    objGrid_Linha_Add(grdListagem, New Object() {0, "D", 1, " ", 2, " ", 3, " ", 4, " ", 5, " ", 6, " ", 7, " "})
    oDataInicial = oDataInicial.AddDays(7)
    objGrid_Linha_Add(grdListagem, New Object() {0, "T",
                                                 1, oDataInicial.Day,
                                                 2, oDataInicial.AddDays(1).Day,
                                                 3, oDataInicial.AddDays(2).Day,
                                                 4, oDataInicial.AddDays(3).Day,
                                                 5, oDataInicial.AddDays(4).Day,
                                                 6, oDataInicial.AddDays(5).Day,
                                                 7, oDataInicial.AddDays(6).Day})
    objGrid_Linha_Add(grdListagem, New Object() {0, "D", 1, " ", 2, " ", 3, " ", 4, " ", 5, " ", 6, " ", 7, " "})
    oDataInicial = oDataInicial.AddDays(7)
    objGrid_Linha_Add(grdListagem, New Object() {0, "T",
                                                 1, oDataInicial.Day,
                                                 2, oDataInicial.AddDays(1).Day,
                                                 3, oDataInicial.AddDays(2).Day,
                                                 4, oDataInicial.AddDays(3).Day,
                                                 5, oDataInicial.AddDays(4).Day,
                                                 6, oDataInicial.AddDays(5).Day,
                                                 7, oDataInicial.AddDays(6).Day})
    objGrid_Linha_Add(grdListagem, New Object() {0, "D", 1, " ", 2, " ", 3, " ", 4, " ", 5, " ", 6, " ", 7, " "})
    oDataInicial = oDataInicial.AddDays(7)
    objGrid_Linha_Add(grdListagem, New Object() {0, "T",
                                                 1, oDataInicial.Day,
                                                 2, oDataInicial.AddDays(1).Day,
                                                 3, oDataInicial.AddDays(2).Day,
                                                 4, oDataInicial.AddDays(3).Day,
                                                 5, oDataInicial.AddDays(4).Day,
                                                 6, oDataInicial.AddDays(5).Day,
                                                 7, oDataInicial.AddDays(6).Day})
    objGrid_Linha_Add(grdListagem, New Object() {0, "D", 1, " ", 2, " ", 3, " ", 4, " ", 5, " ", 6, " ", 7, " "})
  End Sub

  Private Sub CarregarSemanal()
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.Default, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "TIPO", 0)
    objGrid_Coluna_Add(grdListagem, "DOM", 135).Tag = enDiasSemanaPessoaHorario.Domingo
    objGrid_Coluna_Add(grdListagem, "SEG", 135).Tag = enDiasSemanaPessoaHorario.Segunda
    objGrid_Coluna_Add(grdListagem, "TER", 135).Tag = enDiasSemanaPessoaHorario.Terca
    objGrid_Coluna_Add(grdListagem, "QUA", 135).Tag = enDiasSemanaPessoaHorario.Quarta
    objGrid_Coluna_Add(grdListagem, "QUI", 135).Tag = enDiasSemanaPessoaHorario.Quinta
    objGrid_Coluna_Add(grdListagem, "SEX", 135).Tag = enDiasSemanaPessoaHorario.Sexta
    objGrid_Coluna_Add(grdListagem, "SÁB", 135).Tag = enDiasSemanaPessoaHorario.Sabado

    grdListagem.DisplayLayout.Override.WrapHeaderText = DefaultableBoolean.True
    grdListagem.DisplayLayout.Override.CellMultiLine = DefaultableBoolean.True
    grdListagem.DisplayLayout.Bands(0).Columns(1).CellMultiLine = DefaultableBoolean.True
    grdListagem.DisplayLayout.Override.RowSizing = RowSizing.Free
    grdListagem.DisplayLayout.Bands(0).Override.RowSizing = RowSizing.Free
    grdListagem.DisplayLayout.Override.RowSizingAutoMaxLines = 20

    oDBGrid.Rows.Clear()

    objGrid_Linha_Add(grdListagem, New Object() {1, " "})
    objGrid_Linha_Add(grdListagem, New Object() {1, " "})
    objGrid_Linha_Add(grdListagem, New Object() {1, " "})
    objGrid_Linha_Add(grdListagem, New Object() {1, " "})
    objGrid_Linha_Add(grdListagem, New Object() {1, " "})
    objGrid_Linha_Add(grdListagem, New Object() {1, " "})
    objGrid_Linha_Add(grdListagem, New Object() {1, " "})
  End Sub

  Private Sub GridLimpar()
    Dim iLinha As Integer
    Dim iColuna As Integer

    For iLinha = 0 To grdListagem.Rows.Count - 1
      For iColuna = 0 To grdListagem.DisplayLayout.Bands(0).Columns.Count - 1
        If FNC_NVL(grdListagem.Rows(iLinha).Cells(0).Value, "") <> "T" Then
          grdListagem.Rows(iLinha).Cells(iColuna).Value = ""
        End If
      Next
    Next
  End Sub

  Private Sub cboTipoCalendário_Semanal_Semana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCalendário_Semanal_Semana.SelectedIndexChanged
    If bEmProcessamento Then Exit Sub
    CarregarHorario()
  End Sub

  Private Sub grdListagem_InitializeRow(sender As Object, e As InitializeRowEventArgs) Handles grdListagem.InitializeRow
    If optTipoCalendário_Mensal.Checked Then
      If e.Row.Index > 0 Then
        If (e.Row.Index / 2) <> Int(e.Row.Index / 2) Then
          e.Row.Height = 50
        End If
      End If
    ElseIf optTipoCalendário_Semanal.Checked Then
      e.Row.Height = 50
    End If
  End Sub

  Private Sub grdListagem_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdListagem.BeforeCellActivate
    Try
      e.Cancel = (e.Cell.Row.Cells(0).Value = "T")
    Catch ex As Exception
    End Try
  End Sub

  Private Sub CarregarHorario()
    If ComboBox_Selecionado(cboEmpresa) Then
      Dim sSqlText As String

      GridLimpar()

      If optTipoCalendário_Mensal.Checked Then

      ElseIf optTipoCalendário_Semanal.Checked Then
        If Not ComboBox_Selecionado(cboTipoCalendário_Semanal_Semana) Then
          FNC_Mensagem("Selecione a semana")
          Exit Sub
        End If

        Dim oData As DataTable
        Dim iLinha As Integer
        Dim iColuna As Integer
        Dim bValido As Boolean
        Dim bInserir As Boolean
        Dim dUtil As Date

        sSqlText = "SELECT CONCAT(PSHRR.HR_INICIO, '-', PSHRR.HR_FIM, CHAR(13)+CHAR(10), PESSO.NO_PESSOA, ' (', PROCE.NO_PROCEDIMENTO, ')') DS_HORARIO, DT_ESPECIAL, ISNULL(OPCAO_DISMN.SQ_OPCAO, OPCAO_DISMN2.SQ_OPCAO) SQ_OPCAO" &
               " FROM TB_PESSOA_HORARIO	PSHRR" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PSHRR.ID_PESSOA" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = PSHRR.ID_PROCEDIMENTO" &
                 " LEFT JOIN TB_OPCAO OPCAO_DISMN ON OPCAO_DISMN.SQ_OPCAO = PSHRR.ID_OPT_DIA_SEMANA" &
                 " LEFT JOIN TB_OPCAO OPCAO_DISMN2 ON OPCAO_DISMN2.CD_OPCAO = DATEPART(W, DT_ESPECIAL)" &
                                                " AND OPCAO_DISMN2.ID_TIPO_OPCAO = " & enTipoOpcao.DiasSemana.GetHashCode() &
               " WHERE PSHRR.ID_EMPRESA = " & cboEmpresa.SelectedValue &
                 " AND (PSHRR.DT_ESPECIAL IS NULL OR (PSHRR.DT_ESPECIAL >= '" & cboTipoCalendário_Semanal_Semana.SelectedItem(enComBox_Semana.DT_SEMANA_INI) & "' AND " &
                                                     "PSHRR.DT_ESPECIAL <= '" & cboTipoCalendário_Semanal_Semana.SelectedItem(enComBox_Semana.DT_SEMANA_FIM) & "'))" &
               " ORDER BY CONCAT(PSHRR.HR_INICIO, '-', PSHRR.HR_FIM, ' ', PESSO.NO_PESSOA, ' (', PROCE.NO_PROCEDIMENTO, ')')"
        oData = DBQuery(sSqlText)

        For Each oRow As DataRow In oData.Rows
          bValido = False
          bInserir = True

          For iColuna = 1 To grdListagem.DisplayLayout.Bands(0).Columns.Count - 1
            If Not oRow.Item("SQ_OPCAO") Is Nothing Then
              bValido = (grdListagem.DisplayLayout.Bands(0).Columns(iColuna).Tag = FNC_NVL(oRow.Item("SQ_OPCAO"), 0))
            Else
              dUtil = oRow.Item("DT_ESPECIAL")
              bValido = (grdListagem.DisplayLayout.Bands(0).Columns(iColuna).Tag = dUtil.DayOfWeek)
            End If

            If bValido Then
              For iLinha = 0 To grdListagem.Rows.Count - 1
                If FNC_NVL(grdListagem.Rows(iLinha).Cells(0).Value, "") <> "T" Then
                  If FNC_NVL(grdListagem.Rows(iLinha).Cells(iColuna).Value, "").ToString().Trim() = "" Then
                    bInserir = False
                    grdListagem.Rows(iLinha).Cells(iColuna).Value = oRow.Item("DS_HORARIO")
                    Exit For
                  End If
                End If
              Next

              If bInserir Then
                objGrid_Linha_Add(grdListagem, New Object() {0, "", 1, "", 2, "", 3, "", 4, "", 5, "", 6, "", 7, ""}).SetCellValue(iColuna, oRow.Item("DS_HORARIO"))
              End If
            End If
          Next
        Next

        oData = Nothing
      End If
    End If
  End Sub

  Private Sub cboEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresa.SelectedIndexChanged
    If bEmProcessamento Then Exit Sub
    CarregarHorario()
  End Sub

  Private Sub cboTipoCalendário_Mensal_Mes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCalendário_Mensal_Mes.SelectedIndexChanged
    If bEmProcessamento Then Exit Sub
  End Sub

  Private Sub grdListagem_InitializeLayout(sender As Object, e As InitializeLayoutEventArgs) Handles grdListagem.InitializeLayout
    e.Layout.Override.RowSizing = RowSizing.AutoFree
  End Sub

  Private Sub grdListagem_BeforeEnterEditMode(sender As Object, e As CancelEventArgs) Handles grdListagem.BeforeEnterEditMode
    e.Cancel = True
  End Sub
End Class