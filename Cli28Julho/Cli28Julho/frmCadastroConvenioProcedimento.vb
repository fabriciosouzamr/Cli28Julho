Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports System.ComponentModel

Public Class frmCadastroConvenioProcedimento
  Const const_GridListagem_ID_EMPRESA As Integer = 0
  Const const_GridListagem_ID_PROCEDIMENTO As Integer = 1
  Const const_GridListagem_ID_PESSOA_PROFISSIONAL As Integer = 2
  Const const_GridListagem_SQ_CONVENIO_PROCEDIMENTO As Integer = 3
  Const const_GridListagem_IC_PROFISSIONAL As Integer = 4
  Const const_GridListagem_IC_ATIVO As Integer = 5
  Const const_GridListagem_NO_PESSOA As Integer = 6
  Const const_GridListagem_VL_PROCEDIMENTO As Integer = 7
  Const const_GridListagem_VL_REPASSE As Integer = 8
  Const const_GridListagem_PC_REPASSE As Integer = 9
  Const const_GridListagem_VL_CLINICA As Integer = 10
  Const const_GridListagem_QT_DIAS_REPASSE As Integer = 11
  Const const_GridListagem_CM_OBSERVACAO As Integer = 12
  Const const_GridListagem_IC_PADRAO As Integer = 13

  Public iSQ_CONVENIO_PROCEDIMENTO As Integer

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Dim bEmProcessamento As Boolean

  Private Sub frmCadastroConvenioProcedimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboConvenio, enSql.Convenio_Ativo)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "ID_EMPRESA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_CONVENIO_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "IC_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdListagem, "Ativo", 50, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, True)
    objGrid_Coluna_Add(grdListagem, "Profissional/Prestador", 300)
    objGrid_Coluna_Add(grdListagem, "Vlr. Procedimento", 100, , True, , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Vlr. Repasse", 100, , True, , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "% Repasse", 100,, True, , , "0.00'%")
    objGrid_Coluna_Add(grdListagem, "Vlr. Clínica", 100, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Qt. Dias Repasse", 100,, True,,, const_Formato_NumeroInteiro)
    objGrid_Coluna_Add(grdListagem, "Observação", 300,, True)
    objGrid_Coluna_Add(grdListagem, "Padrão", 50, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)

    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_CadastrarPrecodeProcedimentoseExames).bGravar
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sPessoa As String
    Dim bPadrao As Boolean

    For Each oRow As UltraGridRow In grdListagem.Rows
      If FNC_NVL(oRow.Cells(const_GridListagem_IC_PROFISSIONAL).Value, "N") = "N" Then
        sPessoa = "o prestador de serviço " + oRow.Cells(const_GridListagem_NO_PESSOA).Value
      Else
        sPessoa = "o médico " + oRow.Cells(const_GridListagem_NO_PESSOA).Value
      End If

      If oRow.Cells(const_GridListagem_IC_ATIVO).Value = 1 Then
        If FNC_NVL(oRow.Cells(const_GridListagem_VL_PROCEDIMENTO).Value, 0) < 0 Then
          FNC_Mensagem("Informe o valor do procedimento para " + sPessoa)
          Exit Sub
        End If
        If FNC_NVL(oRow.Cells(const_GridListagem_VL_REPASSE).Value, 0) < 0 And
           FNC_NVL(oRow.Cells(const_GridListagem_PC_REPASSE).Value, 0) < 0 Then
          FNC_Mensagem("Informe o valor ou porcentagem de rapasse a" + sPessoa)
          Exit Sub
        End If
        If oRow.Cells(const_GridListagem_QT_DIAS_REPASSE).Value Is Nothing Or
           FNC_NVL(oRow.Cells(const_GridListagem_QT_DIAS_REPASSE).Value, 0) < 0 Then
          FNC_Mensagem("Informe a quantidade de dias para o repasse para " + sPessoa)
          Exit Sub
        End If
      End If

      bPadrao = bPadrao Or (oRow.Cells(const_GridListagem_IC_PADRAO).Value = 1)
    Next
    If Not bPadrao Then
      FNC_Mensagem("É preciso informar um médico ou profissional padrão")
      Exit Sub
    End If

    Dim sSqlText As String

    For Each oRow As UltraGridRow In grdListagem.Rows
      If oRow.Cells(const_GridListagem_IC_ATIVO).Value = 1 Or FNC_NVL(oRow.Cells(const_GridListagem_SQ_CONVENIO_PROCEDIMENTO).Value, 0) <> 0 Then
        sSqlText = DBMontar_SP("SP_CONVENIO_PROCEDIMENTO_CAD", False, "	@SQ_CONVENIO_PROCEDIMENTO",
                                                                       "@ID_PROCEDIMENTO",
                                                                       "@ID_CONVENIO",
                                                                       "@ID_PESSOA_PROFISSIONAL",
                                                                       "@VL_PROCEDIMENTO",
                                                                       "@VL_REPASSE",
                                                                       "@PC_REPASSE",
                                                                       "@QT_DIAS_REPASSE",
                                                                       "@CM_OBSERVACAO",
                                                                       "@IC_ATIVO",
                                                                       "@IC_PADRAO")
        DBExecutar(sSqlText, DBParametro_Montar("SQ_CONVENIO_PROCEDIMENTO", FNC_NVL(oRow.Cells(const_GridListagem_SQ_CONVENIO_PROCEDIMENTO).Value, 0)),
                             DBParametro_Montar("ID_PROCEDIMENTO", FNC_NVL(oRow.Cells(const_GridListagem_ID_PROCEDIMENTO).Value, 0)),
                             DBParametro_Montar("ID_CONVENIO", cboConvenio.SelectedValue),
                             DBParametro_Montar("ID_PESSOA_PROFISSIONAL", FNC_NVL(oRow.Cells(const_GridListagem_ID_PESSOA_PROFISSIONAL).Value, 0)),
                             DBParametro_Montar("VL_PROCEDIMENTO", FNC_NVL(oRow.Cells(const_GridListagem_VL_PROCEDIMENTO).Value, 0), SqlDbType.Money),
                             DBParametro_Montar("VL_REPASSE", FNC_NVL(oRow.Cells(const_GridListagem_VL_REPASSE).Value, 0), SqlDbType.Money),
                             DBParametro_Montar("PC_REPASSE", FNC_NVL(oRow.Cells(const_GridListagem_PC_REPASSE).Value, 0), SqlDbType.Decimal),
                             DBParametro_Montar("QT_DIAS_REPASSE", FNC_NVL(oRow.Cells(const_GridListagem_QT_DIAS_REPASSE).Value, 0)),
                             DBParametro_Montar("CM_OBSERVACAO", oRow.Cells(const_GridListagem_CM_OBSERVACAO).Value),
                             DBParametro_Montar("IC_ATIVO", IIf(oRow.Cells(const_GridListagem_IC_ATIVO).Value = 1, "S", "N")),
                             DBParametro_Montar("IC_PADRAO", IIf(oRow.Cells(const_GridListagem_IC_PADRAO).Value = 1, "S", "N")))
      End If
    Next

    Pesquisar()

    MsgBox("Gravação Efeutada")
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String

    If Not ComboBox_Selecionado(cboConvenio) Then
      FNC_Mensagem("Selecione o convênio")
      Exit Sub
    End If
    If psqProcedimento.Identificador = 0 Then
      FNC_Mensagem("Informe o procedimento ou exame")
      Exit Sub
    End If

    Controle_Ativar(False)

    sSqlText = "SELECT PROCE.ID_EMPRESA," &
                      "PROCE.SQ_PROCEDIMENTO," &
                      "PROCE.SQ_PESSOA," &
                      "PROCE.IC_PROFISSIONAL," &
                      "CVPCD.SQ_CONVENIO_PROCEDIMENTO," &
                      "IIF(ISNULL(CVPCD.IC_ATIVO, 'N') = 'S', 1, 0)," &
                      "PROCE.NO_PESSOA," &
                      "CVPCD.VL_PROCEDIMENTO," &
                      "CVPCD.VL_REPASSE," &
                      "CVPCD.PC_REPASSE," &
                      "CVPCD.VL_PROCEDIMENTO - ISNULL(CVPCD.VL_REPASSE, 0) - (ISNULL(CVPCD.PC_REPASSE, 0) * CVPCD.VL_PROCEDIMENTO / 100) VL_CLINICA," &
                      "CVPCD.QT_DIAS_REPASSE," &
                      "CVPCD.CM_OBSERVACAO," &
                      "IIF(ISNULL(CVPCD.IC_PADRAO, 'N') = 'S', 1, 0)" &
               " FROM (SELECT DISTINCT PESSO.ID_EMPRESA, PRCE.SQ_PROCEDIMENTO, PESSO.SQ_PESSOA, PRCE.NO_PROCEDIMENTO, PESSO.NO_PESSOA, PESSO.IC_PROFISSIONAL" &
                      " FROM VW_PROCEDIMENTO_EMPRESA PRCE" &
                       " CROSS JOIN VW_PESSOA_PROFISSIONAL_FORNECEDOR_PROCEDIMENTO PESSO)	PROCE" &
                " LEFT JOIN TB_CONVENIO_PROCEDIMENTO CVPCD ON CVPCD.ID_PROCEDIMENTO = PROCE.SQ_PROCEDIMENTO" &
                                                        " AND CVPCD.ID_PESSOA_PROFISSIONAL = PROCE.SQ_PESSOA" &
                                                        " AND CVPCD.ID_CONVENIO = " & cboConvenio.SelectedValue &
               " WHERE PROCE.SQ_PROCEDIMENTO = " & psqProcedimento.Identificador &
                 " AND PROCE.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
               " ORDER BY PROCE.NO_PESSOA"
    bEmProcessamento = True
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_EMPRESA,
                                                           const_GridListagem_ID_PROCEDIMENTO,
                                                           const_GridListagem_ID_PESSOA_PROFISSIONAL,
                                                           const_GridListagem_IC_PROFISSIONAL,
                                                           const_GridListagem_SQ_CONVENIO_PROCEDIMENTO,
                                                           const_GridListagem_IC_ATIVO,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_VL_PROCEDIMENTO,
                                                           const_GridListagem_VL_REPASSE,
                                                           const_GridListagem_PC_REPASSE,
                                                           const_GridListagem_VL_CLINICA,
                                                           const_GridListagem_QT_DIAS_REPASSE,
                                                           const_GridListagem_CM_OBSERVACAO,
                                                           const_GridListagem_IC_PADRAO})

    bEmProcessamento = False
  End Sub

  Private Sub grdListagem_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdListagem.AfterCellUpdate
    If bEmProcessamento Then Exit Sub

    Select Case e.Cell.Column.Index
      Case const_GridListagem_VL_REPASSE
        GridListagem_Atualizar_ValorClinica(grdListagem, e.Cell.Row.Index, False)
      Case const_GridListagem_PC_REPASSE
        GridListagem_Atualizar_ValorClinica(grdListagem, e.Cell.Row.Index, True)
      Case const_GridListagem_VL_PROCEDIMENTO
        GridListagem_Atualizar_ValorClinica(grdListagem, e.Cell.Row.Index, FNC_NVL(e.Cell.Row.Cells(const_GridListagem_PC_REPASSE).Value, 0) <> 0)
      Case const_GridListagem_IC_PADRAO
        Dim iCont As Integer

        bEmProcessamento = True

        For iCont = 0 To grdListagem.Rows.Count - 1
          If iCont <> e.Cell.Row.Index Then
            grdListagem.Rows(iCont).Cells(const_GridListagem_IC_PADRAO).Value = 0
          End If
        Next

        bEmProcessamento = False
    End Select
  End Sub

  Private Sub GridListagem_Atualizar_ValorClinica(ByVal oGrid As UltraGrid, iLinha As Integer, bPercentual As Boolean)
    bEmProcessamento = True
    If FNC_NVL(oGrid.Rows(iLinha).Cells(const_GridListagem_VL_PROCEDIMENTO).Value, 0) = 0 Then
      oGrid.Rows(iLinha).Cells(const_GridListagem_VL_CLINICA).Value = 0
    Else
      If bPercentual Then
        oGrid.Rows(iLinha).Cells(const_GridListagem_VL_REPASSE).Value = 0
        oGrid.Rows(iLinha).Cells(const_GridListagem_VL_CLINICA).Value = FNC_NVL(oGrid.Rows(iLinha).Cells(const_GridListagem_VL_PROCEDIMENTO).Value, 0) -
                                                                                FNC_Porcentagem(FNC_NVL(oGrid.Rows(iLinha).Cells(const_GridListagem_VL_PROCEDIMENTO).Value, 0),
                                                                                                FNC_NVL(oGrid.Rows(iLinha).Cells(const_GridListagem_PC_REPASSE).Value, 0), 2)
      Else
        oGrid.Rows(iLinha).Cells(const_GridListagem_PC_REPASSE).Value = 0
        oGrid.Rows(iLinha).Cells(const_GridListagem_VL_CLINICA).Value = FNC_NVL(oGrid.Rows(iLinha).Cells(const_GridListagem_VL_PROCEDIMENTO).Value, 0) -
                                                                        FNC_NVL(oGrid.Rows(iLinha).Cells(const_GridListagem_VL_REPASSE).Value, 0)
      End If
    End If
    bEmProcessamento = False
  End Sub

  Private Sub cmdCancela_Click(sender As Object, e As EventArgs) Handles cmdCancela.Click
    Controle_Ativar(True)

    oDBGrid.Rows.Clear()
  End Sub

  Private Sub Controle_Ativar(bHabilitar As Boolean)
    cboConvenio.Enabled = bHabilitar
    psqProcedimento.Enabled = bHabilitar
  End Sub

  Private Sub grdListagem_ClickCell(sender As Object, e As ClickCellEventArgs) Handles grdListagem.ClickCell
    If e.Cell.Column.Index = const_GridListagem_IC_PADRAO Then
      Dim iCont As Integer

      bEmProcessamento = True

      For iCont = 0 To grdListagem.Rows.Count - 1
        If iCont <> e.Cell.Row.Index Then
          grdListagem.Rows(iCont).Cells(const_GridListagem_IC_PADRAO).Value = 0
        End If
      Next

      bEmProcessamento = False
    End If
  End Sub

  Private Sub cmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub
End Class