Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Infragistics.Win.Misc.UltraWinNavigationBar

Public Class frmConsultaVendaDevolucao
  Const const_GridListagemADevolver_SQ_CLINICA_VENDA_PROCEDIMENTO As Integer = 0
  Const const_GridListagemADevolver_NomeProcedimentoExame As Integer = 2
  Const const_GridListagemADevolver_VlrTotalProcedimento As Integer = 3
  Const const_GridListagemADevolver_VlrRepasse As Integer = 4
  Const const_GridListagemADevolver_CodigoAgendamento As Integer = 5
  Const const_GridListagemADevolver_DataAgendamento As Integer = 6
  Const const_GridListagemADevolver_StatusAgendamento As Integer = 7
  Const const_GridListagemADevolver_Profissional As Integer = 8

  Const const_GridListagemDevolucao_SQ_CLINICA_VENDA_PROCEDIMENTO As Integer = 0
  Const const_GridListagemDevolucao_NomeProcedimentoExame As Integer = 2
  Const const_GridListagemDevolucao_VlrTotalProcedimento As Integer = 3
  Const const_GridListagemDevolucao_VlrRepasse As Integer = 4
  Const const_GridListagemDevolucao_CodigoAgendamento As Integer = 5
  Const const_GridListagemDevolucao_DataAgendamento As Integer = 6
  Const const_GridListagemDevolucao_StatusAgendamento As Integer = 7
  Const const_GridListagemDevolucao_Profissional As Integer = 8

  Public iSQ_CLINICA_VENDA As Integer

  Dim oDBGridADevolver As New UltraWinDataSource.UltraDataSource
  Dim oDBGridDevolucao As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If grdListagemDevolucao.Rows.Count = 0 Then
      FNC_Mensagem("É preciso selecionar o(s) procedimento(s)/exame(s) a ser(em) devolvido(s).")
      Exit Sub
    End If
    If Trim(txtJustificativaDevolucao.Text) = "" Then
      FNC_Mensagem("Informe a justificativa para essa devolução")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboContaFinanceira) Then
      FNC_Mensagem("Selecione a conta finaceira")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoDocumento) Then
      FNC_Mensagem("Selecione o tipo de documento")
      Exit Sub
    End If

    Dim iCont As Integer
    Dim sSqlText As String
    Dim iSQ_CLINICA_VENDA_DEVOLUCAO As Integer

    sSqlText = DBMontar_SP("SP_CLINICA_VENDA_DEVOLVER_UPD", False, "@SQ_CLINICA_VENDA",
                                                                   "@SQ_CLINICA_VENDA_DEVOLUCAO OUTPUT",
                                                                   "@SQ_MOVFINANCEIRA OUTPUT",
                                                                   "@ID_EMPRESA",
                                                                   "@ID_CONTAFINANCEIRA_DEBITO",
                                                                   "@CM_JUSTIFICATIVA",
                                                                   "@VL_DEVOLUCAO",
                                                                   "@ID_TIPO_DOCUMENTO",
                                                                   "@ID_USUARIO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA", iSQ_CLINICA_VENDA),
                         DBParametro_Montar("SQ_CLINICA_VENDA_DEVOLUCAO", Nothing, , ParameterDirection.Output),
                         DBParametro_Montar("SQ_MOVFINANCEIRA", Nothing, , ParameterDirection.Output),
                         DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                         DBParametro_Montar("ID_CONTAFINANCEIRA_DEBITO", cboContaFinanceira.SelectedValue),
                         DBParametro_Montar("CM_JUSTIFICATIVA", txtJustificativaDevolucao.Text),
                         DBParametro_Montar("VL_DEVOLUCAO", CDbl(lblValorDevolucao.Tag), SqlDbType.Money),
                         DBParametro_Montar("ID_TIPO_DOCUMENTO", cboTipoDocumento.SelectedValue),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO))

    If DBTeveRetorno() Then
      iSQ_CLINICA_VENDA_DEVOLUCAO = DBRetorno(1)
    End If

    sSqlText = DBMontar_SP("SP_CLINICA_VENDA_PROCEDIMENTO_DEVOLVER_UPD", False, "@SQ_CLINICA_VENDA_PROCEDIMENTO",
                                                                                "@ID_CLINICA_VENDA_DEVOLUCAO")

    For iCont = 0 To grdListagemDevolucao.Rows.Count - 1
      With grdListagemDevolucao.Rows(iCont)
        DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA_PROCEDIMENTO", .Cells(const_GridListagemDevolucao_SQ_CLINICA_VENDA_PROCEDIMENTO).Value),
                             DBParametro_Montar("ID_CLINICA_VENDA_DEVOLUCAO", iSQ_CLINICA_VENDA_DEVOLUCAO))
      End With
    Next

    sSqlText = DBMontar_SP("SP_CLINICA_VENDA_DEVOLUCAO_CANCELA_REPASSE_UPD", False, "@ID_CLINICA_VENDA_DEVOLUCAO",
                                                                                    "@ID_CONTACAIXA",
                                                                                    "@ID_USUARIO")
    DBExecutar(sSqlText, DBParametro_Montar("ID_CLINICA_VENDA_DEVOLUCAO", iSQ_CLINICA_VENDA_DEVOLUCAO),
                         DBParametro_Montar("ID_CONTACAIXA", cboContaFinanceira.SelectedValue),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO))

    cmdGravar.Enabled = False

    FNC_Mensagem("Devolução Efetuada")
  End Sub

  Private Sub frmConsultaVendaDevolucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim oData As DataTable
    Dim sSqlText As String

    objGrid_Inicializar(grdListagemADevolver, , oDBGridADevolver, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagemADevolver, "SQ_CLINICA_VENDA_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagemADevolver, "Devolver", 80, , , ColumnStyle.Button)
    objGrid_Coluna_Add(grdListagemADevolver, "Nome do Procedimento/Exame", 300)
    objGrid_Coluna_Add(grdListagemADevolver, "Vlr. Total Procedimento", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagemADevolver, "Vlr. Repasse", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagemADevolver, "Cód. do Agendamento", 150)
    objGrid_Coluna_Add(grdListagemADevolver, "Data do Agendamento", 150, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagemADevolver, "Status do Agendamento", 150)
    objGrid_Coluna_Add(grdListagemADevolver, "Profissional", 150)

    objGrid_Inicializar(grdListagemDevolucao, , oDBGridDevolucao, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagemDevolucao, "SQ_CLINICA_VENDA_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagemDevolucao, "Retirar", 80, , , ColumnStyle.Button)
    objGrid_Coluna_Add(grdListagemDevolucao, "Nome do Procedimento/Exame", 300)
    objGrid_Coluna_Add(grdListagemDevolucao, "Vlr. Total Procedimento", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagemDevolucao, "Vlr. Repasse", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagemDevolucao, "Cód. do Agendamento", 150)
    objGrid_Coluna_Add(grdListagemDevolucao, "Data do Agendamento", 150, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagemDevolucao, "Status do Agendamento", 150)
    objGrid_Coluna_Add(grdListagemDevolucao, "Profissional", 150)

    ComboBox_Carregar(cboContaFinanceira, enSql.ContaCaixa, New Object() {iID_USUARIO})
    ComboBox_Carregar(cboTipoDocumento, enSql.TipoDocumento)

    sSqlText = "SELECT CLVND.CD_CLINICA_VENDA," &
                      "CLVND.DH_VENDA," &
                      "PESSO.NO_PESSOA" &
               " FROM TB_CLINICA_VENDA CLVND" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
               " WHERE CLVND.SQ_CLINICA_VENDA = " & iSQ_CLINICA_VENDA
    oData = DBQuery(sSqlText)

    lblCodigo.Text = oData.Rows(0).Item("CD_CLINICA_VENDA")
    lblDHVenda.Text = oData.Rows(0).Item("DH_VENDA")
    lblNomePaciente.Text = oData.Rows(0).Item("NO_PESSOA")
    lblValorDevolucao.Text = "R$ 0,00"

    sSqlText = "SELECT CVPCD.SQ_CLINICA_VENDA_PROCEDIMENTO," &
                      "PROCE.NO_PROCEDIMENTO," &
                      "CVPCD.VL_PROCEDIMENTO - ROUND(ISNULL(MVFCR.VL_DESCONTO, 0) / MVFCR.VL_ORIGINAL * CVPCD.VL_PROCEDIMENTO, 2)," &
                      "ISNULL(CVPCD.VL_REPASSE, 0)," &
                      "AGEND.CD_AGENDAMENTO," &
                      "AGEND.DH_AGENDAMENTO," &
                      "STAGD.NO_OPCAO," &
                      "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL" &
               " FROM TB_CLINICA_VENDA CLVND" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPCD ON CVPCD.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                                                              " AND CVPCD.ID_CLINICA_VENDA_DEVOLUCAO IS NULL" &
                " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN TB_OPCAO STCVP ON STCVP.SQ_OPCAO = CVPCD.ID_OPT_STATUS" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVPCD.ID_PROCEDIMENTO" &
                 " LEFT JOIN TB_MOVFINANCEIRA MVFNC ON MVFNC.SQ_MOVFINANCEIRA = CVPCD.ID_MOVFINANCEIRA" &
                 " LEFT JOIN TB_OPCAO STMFN ON STMFN.SQ_OPCAO = MVFNC.ID_OPT_STATUS" &
                 " LEFT JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CVPCD.ID_AGENDAMENTO" &
                 " LEFT JOIN TB_OPCAO STAGD ON STAGD.SQ_OPCAO = AGEND.ID_OPT_STATUS" &
                 " LEFT JOIN (SELECT ID_CLINICA_VENDA," &
                                    "SUM(VL_ORIGINAL) VL_ORIGINAL," &
                                    "SUM(VL_DESCONTO) VL_DESCONTO" &
                             " FROM TB_MOVFINANCEIRA" &
                             " WHERE ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                             " GROUP BY ID_CLINICA_VENDA) MVFCR ON MVFCR.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
               " WHERE CLVND.SQ_CLINICA_VENDA = " & iSQ_CLINICA_VENDA &
                 " AND ISNULL(STAGD.CD_OPCAO, 'A') = 'A'" &
                 " AND ISNULL(STCVP.CD_OPCAO, 'A') = 'A'" &
                 " AND ISNULL(STMFN.CD_OPCAO, 'A') = 'A'" &
                 " AND CLVND.DH_CANCELAR IS NULL" &
               " ORDER BY PROCE.NO_PROCEDIMENTO"
    objGrid_Carregar(grdListagemADevolver, sSqlText, New Integer() {const_GridListagemADevolver_SQ_CLINICA_VENDA_PROCEDIMENTO,
                                                                    const_GridListagemADevolver_NomeProcedimentoExame,
                                                                    const_GridListagemADevolver_VlrTotalProcedimento,
                                                                    const_GridListagemADevolver_VlrRepasse,
                                                                    const_GridListagemADevolver_CodigoAgendamento,
                                                                    const_GridListagemADevolver_DataAgendamento,
                                                                    const_GridListagemADevolver_StatusAgendamento,
                                                                    const_GridListagemADevolver_Profissional})
  End Sub

  Private Sub grdListagemADevolver_ClickCellButton(sender As Object, e As CellEventArgs) Handles grdListagemADevolver.ClickCellButton
    If e.Cell.Row.Index = -1 Then Exit Sub

    objGrid_Linha_Add(grdListagemDevolucao, New Object() {const_GridListagemDevolucao_SQ_CLINICA_VENDA_PROCEDIMENTO, e.Cell.Row.Cells(const_GridListagemADevolver_SQ_CLINICA_VENDA_PROCEDIMENTO).Value,
                                                          const_GridListagemDevolucao_NomeProcedimentoExame, e.Cell.Row.Cells(const_GridListagemADevolver_NomeProcedimentoExame).Value,
                                                          const_GridListagemDevolucao_VlrTotalProcedimento, e.Cell.Row.Cells(const_GridListagemADevolver_VlrTotalProcedimento).Value,
                                                          const_GridListagemDevolucao_VlrRepasse, e.Cell.Row.Cells(const_GridListagemADevolver_VlrRepasse).Value,
                                                          const_GridListagemDevolucao_CodigoAgendamento, e.Cell.Row.Cells(const_GridListagemADevolver_CodigoAgendamento).Value,
                                                          const_GridListagemDevolucao_DataAgendamento, e.Cell.Row.Cells(const_GridListagemADevolver_DataAgendamento).Value,
                                                          const_GridListagemDevolucao_StatusAgendamento, e.Cell.Row.Cells(const_GridListagemADevolver_StatusAgendamento).Value,
                                                          const_GridListagemDevolucao_Profissional, e.Cell.Row.Cells(const_GridListagemADevolver_Profissional).Value})
    grdListagemADevolver.Rows(e.Cell.Row.Index).Delete(False)

    GridDevolucao_CalcularValorDevolucao()
  End Sub

  Private Sub grdListagemDevolucao_ClickCellButton(sender As Object, e As CellEventArgs) Handles grdListagemDevolucao.ClickCellButton
    If e.Cell.Row.Index = -1 Then Exit Sub

    objGrid_Linha_Add(grdListagemADevolver, New Object() {const_GridListagemADevolver_SQ_CLINICA_VENDA_PROCEDIMENTO, e.Cell.Row.Cells(const_GridListagemDevolucao_SQ_CLINICA_VENDA_PROCEDIMENTO).Value,
                                                          const_GridListagemADevolver_NomeProcedimentoExame, e.Cell.Row.Cells(const_GridListagemDevolucao_NomeProcedimentoExame).Value,
                                                          const_GridListagemADevolver_VlrTotalProcedimento, e.Cell.Row.Cells(const_GridListagemDevolucao_VlrTotalProcedimento).Value,
                                                          const_GridListagemADevolver_VlrRepasse, e.Cell.Row.Cells(const_GridListagemDevolucao_VlrRepasse).Value,
                                                          const_GridListagemADevolver_CodigoAgendamento, e.Cell.Row.Cells(const_GridListagemDevolucao_CodigoAgendamento).Value,
                                                          const_GridListagemADevolver_DataAgendamento, e.Cell.Row.Cells(const_GridListagemDevolucao_DataAgendamento).Value,
                                                          const_GridListagemADevolver_StatusAgendamento, e.Cell.Row.Cells(const_GridListagemDevolucao_StatusAgendamento).Value,
                                                          const_GridListagemADevolver_Profissional, e.Cell.Row.Cells(const_GridListagemDevolucao_Profissional).Value})
    grdListagemDevolucao.Rows(e.Cell.Row.Index).Delete(False)

    GridDevolucao_CalcularValorDevolucao()
  End Sub

  Private Sub GridDevolucao_CalcularValorDevolucao()
    lblValorDevolucao.Tag = objGrid_CalcularTotalColuna(grdListagemDevolucao, const_GridListagemDevolucao_VlrTotalProcedimento)
    lblValorDevolucao.Text = FormatCurrency(lblValorDevolucao.Tag)
  End Sub
End Class