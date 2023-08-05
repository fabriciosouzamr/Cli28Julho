Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmCadastroEspecialidade
  Public Event Pesquisar()

  Public iSQ_ESPECIALIDADE As Integer

  Const const_GridProcedimento_ID_PROCEDIMENTO As Integer = 0
  Const const_GridProcedimento_IC_FAVORITO As Integer = 1

  Dim oDBGridEspecialidade As New UltraWinDataSource.UltraDataSource

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Trim(txtNomeEspecialidade.Text) = "" Then
      FNC_Mensagem("Informe o nome do especialidade")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = DBMontar_SP("SP_ESPECIALIDADE_CAD", False, "@SQ_ESPECIALIDADE OUT",
                                                          "@NO_ESPECIALIDADE",
                                                          "@IC_ATIVO")

    If DBExecutar(sSqlText, DBParametro_Montar("SQ_ESPECIALIDADE", iSQ_ESPECIALIDADE, , ParameterDirection.InputOutput),
                            DBParametro_Montar("NO_ESPECIALIDADE", Trim(txtNomeEspecialidade.Text)),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_ESPECIALIDADE = DBRetorno(1)
      End If

      sSqlText = "DELETE FROM TB_PROCEDIMENTO_ESPECIALIDADE WHERE ID_ESPECIALIDADE = " & iSQ_ESPECIALIDADE
      DBExecutar(sSqlText)

      For iCont = 0 To grdProcedimento.Rows.Count - 1
        sSqlText = DBMontar_Insert("TB_PROCEDIMENTO_ESPECIALIDADE", TipoCampoFixo.DadoCriacao, "ID_PROCEDIMENTO", "@ID_PROCEDIMENTO",
                                                                                                 "ID_ESPECIALIDADE", "@ID_ESPECIALIDADE",
                                                                                                 "IC_FAVORITO", "@IC_FAVORITO")
        DBExecutar(sSqlText, DBParametro_Montar("ID_PROCEDIMENTO", objGrid_Valor(grdProcedimento, const_GridProcedimento_ID_PROCEDIMENTO, iCont)),
                              DBParametro_Montar("ID_ESPECIALIDADE", iSQ_ESPECIALIDADE),
                              DBParametro_Montar("IC_FAVORITO", objGrid_CheckCol_Valor(grdProcedimento, const_GridProcedimento_IC_FAVORITO, iCont)))
      Next

      RaiseEvent Pesquisar()

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroEspecialidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdProcedimento, AllowAddNew.TemplateOnTop, oDBGridEspecialidade, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdProcedimento, "Exames", 400, , True, , FNC_CarregarLista(enTipoCadastro.Exame))
    objGrid_Coluna_Add(grdProcedimento, "Favorito", 100, , True, ColumnStyle.CheckBox)

    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_Procedimento).bGravar

    chkAtivo.Checked = True

    If iSQ_ESPECIALIDADE > 0 Then
      CarregarDados()
    End If
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * " &
               " FROM TB_ESPECIALIDADE" &
               " WHERE SQ_ESPECIALIDADE = " & iSQ_ESPECIALIDADE
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      txtNomeEspecialidade.Text = .Item("NO_ESPECIALIDADE")
      chkAtivo.Checked = (.Item("IC_ATIVO") = "S")
    End With

    sSqlText = "SELECT PCESP.ID_PROCEDIMENTO," &
                      "IIF(PCESP.IC_FAVORITO = 'S', 1, 0)" &
               " FROM TB_PROCEDIMENTO_ESPECIALIDADE	PCESP" &
                " INNER JOIN TB_PROCEDIMENTO	PROCE ON PROCE.SQ_PROCEDIMENTO = PCESP.ID_PROCEDIMENTO" &
               " WHERE PCESP.ID_ESPECIALIDADE = " & iSQ_ESPECIALIDADE.ToString() &
               " ORDER BY PROCE.NO_PROCEDIMENTO"
    objGrid_Carregar(grdProcedimento, sSqlText, New Integer() {const_GridProcedimento_ID_PROCEDIMENTO,
                                                               const_GridProcedimento_IC_FAVORITO})
  End Sub

  Private Sub cmdSelecionarTodas_Click(sender As Object, e As EventArgs) Handles cmdSelecionarTodas.Click
    Dim iCont As Integer

    For iCont = 0 To grdProcedimento.Rows.Count - 1
      grdProcedimento.Rows(iCont).Cells(const_GridProcedimento_IC_FAVORITO).Value = 1
    Next
  End Sub

  Private Sub grdEspecialidade_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdProcedimento.BeforeRowsDeleted
    Dim sSqlText As String

    e.DisplayPromptMsg = False

    If FNC_Perguntar("Deseja realmente excluir a Especialidade " & e.Rows(0).Cells(const_GridProcedimento_ID_PROCEDIMENTO).Value & "?") Then
      sSqlText = "DELETE FROM TB_PROCEDIMENTO_ESPECIALIDADE" &
                 " WHERE ID_PROCEDIMENTO =" & e.Rows(0).Cells(const_GridProcedimento_ID_PROCEDIMENTO).Value &
                   " AND ID_ESPECIALIDADE  = " & iSQ_ESPECIALIDADE.ToString()
      DBExecutar(sSqlText)
    End If
  End Sub

  Private Sub grdEspecialidade_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdProcedimento.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridProcedimento_ID_PROCEDIMENTO).Value) Then
      FNC_Mensagem("É preciso informar o nome da Esepcialidade")
      e.Cancel = True
      Exit Sub
    End If
  End Sub

  'Private Sub grdEspecialidade_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles grdProcedimento.AfterRowUpdate
  '  Dim sSqlText As String

  '  sSqlText = DBMontar_Update("TB_PROCEDIMENTO_ESPECIALIDADE", FNC_GerarArray("IC_FAVORITO", "@IC_FAVORITO"),
  '                                                              FNC_GerarArray("ID_ESPECIALIDADE", "@ID_ESPECIALIDADE", " AND ",
  '                                                                             "ID_PROCEDIMENTO", "@ID_PROCEDIMENTO"))
  '  DBExecutar(sSqlText, DBParametro_Montar("IC_FAVORITO", objGrid_CheckCol_Valor(grdProcedimento, const_GridProcedimento_IC_FAVORITO, e.Row.Index)),
  '                       DBParametro_Montar("ID_ESPECIALIDADE", iSQ_ESPECIALIDADE),
  '                       DBParametro_Montar("ID_PROCEDIMENTO", objGrid_Valor(grdProcedimento, const_GridProcedimento_ID_PROCEDIMENTO, e.Row.Index)))
  'End Sub
End Class