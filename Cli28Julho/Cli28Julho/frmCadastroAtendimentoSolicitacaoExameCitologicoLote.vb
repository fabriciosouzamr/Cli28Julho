Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmCadastroAtendimentoSolicitacaoExameCitologicoLote
  Const const_GridListagem_Chk As Integer = 0
  Const const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO As Integer = 1
  Const const_GridListagem_CD_CLINICA_ATENDIMENTO As Integer = 2
  Const const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO As Integer = 3
  Const const_GridListagem_DS_TIPO As Integer = 4
  Const const_GridListagem_DS_MEDICO_EXTERNO As Integer = 5
  Const const_GridListagem_DS_COLETA As Integer = 6
  Const const_GridListagem_PRONTUARIO As Integer = 7
  Const const_GridListagem_PACIENTE As Integer = 8

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Public iSQ_CLINICA_EXAME_CITOLOGICO_LOTE As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroAtendimentoSolicitacaoExameCitologicoLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "..", 50, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdListagem, "SQ_CLINICA_EXAME_CITOLOGICO", 0)
    objGrid_Coluna_Add(grdListagem, "Código do Atendimento", 300)
    objGrid_Coluna_Add(grdListagem, "Código do Exame Citológico", 300)
    objGrid_Coluna_Add(grdListagem, "Tipo", 300)
    objGrid_Coluna_Add(grdListagem, "Médico Externo", 300)
    objGrid_Coluna_Add(grdListagem, "Coleta", 300)
    objGrid_Coluna_Add(grdListagem, "Prontuário", 100)
    objGrid_Coluna_Add(grdListagem, "Paciente", 300)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    ComboBox_Carregar(cboProfissional, enSql.Profissional)

    cmdImprimir.Enabled = False

    Pesquisar()
    cboProfissional.Enabled = (iSQ_CLINICA_EXAME_CITOLOGICO_LOTE = 0)
    txtDataEnvio.Enabled = (iSQ_CLINICA_EXAME_CITOLOGICO_LOTE = 0)
  End Sub

  Private Sub Pesquisar()
    Dim oData As DataTable
    Dim sSqlText As String = ""

    sSqlText = "SELECT ID_PESSOA_PROFISSIONAL, DT_ENVIO FROM TB_CLINICA_EXAME_CITOLOGICO_LOTE" &
               " WHERE SQ_CLINICA_EXAME_CITOLOGICO_LOTE = " & iSQ_CLINICA_EXAME_CITOLOGICO_LOTE
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      ComboBox_Selecionar(cboProfissional, oData.Rows(0).Item("ID_PESSOA_PROFISSIONAL"))
      txtDataEnvio.Value = oData.Rows(0).Item("DT_ENVIO")
    End If

    sSqlText = "SELECT IIF(ID_CLINICA_EXAME_CITOLOGICO_LOTE = " & iSQ_CLINICA_EXAME_CITOLOGICO_LOTE & ", 1, 0)," &
                      "CLEXC.SQ_CLINICA_EXAME_CITOLOGICO," &
                      "ISNULL(CLATD.CD_CLINICA_ATENDIMENTO, CLVND.CD_CLINICA_VENDA)," &
                      "CLEXC.CD_CLINICA_EXAME_CITOLOGICO," &
                      "CLEXC.DS_TIPO," &
                      "CLEXC.DS_MEDICO_EXTERNO," &
                      "CLEXC.DS_COLETA," &
                      "PESSO.NO_PESSOA," &
                      "PESSO.SQ_PESSOA" &
               " FROM TB_CLINICA_EXAME_CITOLOGICO	CLEXC" &
               " LEFT JOIN TB_CLINICA_ATENDIMENTO	CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLEXC.ID_CLINICA_ATENDIMENTO" &
               " LEFT JOIN TB_CLINICA_VENDA	CLVND ON CLVND.SQ_CLINICA_VENDA = CLEXC.ID_CLINICA_VENDA" &
               " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                                         " OR PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
               " WHERE ID_CLINICA_EXAME_CITOLOGICO_LOTE = " & iSQ_CLINICA_EXAME_CITOLOGICO_LOTE &
                  " OR ID_CLINICA_EXAME_CITOLOGICO_LOTE IS NULL"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_Chk,
                                                           const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO,
                                                           const_GridListagem_CD_CLINICA_ATENDIMENTO,
                                                           const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO,
                                                           const_GridListagem_DS_TIPO,
                                                           const_GridListagem_DS_MEDICO_EXTERNO,
                                                           const_GridListagem_DS_COLETA,
                                                           const_GridListagem_PACIENTE,
                                                           const_GridListagem_PRONTUARIO})
  End Sub

  Private Sub txtCodigoCitologia_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoCitologia.KeyDown
    If e.KeyCode = Keys.Enter Then
      Dim iCont As Integer
      Dim bAchou As Boolean = False

      For iCont = 0 To grdListagem.Rows.Count - 1
        If FNC_NVL(grdListagem.Rows(iCont).Cells(const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO).Value, "") = txtCodigoCitologia.Text Or
           FNC_NVL(grdListagem.Rows(iCont).Cells(const_GridListagem_CD_CLINICA_ATENDIMENTO).Value, "") = txtCodigoCitologia.Text Then
          grdListagem.Rows(iCont).Cells(const_GridListagem_Chk).Value = 1
          bAchou = True
        End If
      Next

      txtCodigoCitologia.Text = ""
      txtCodigoCitologia.Select()

      If Not bAchou Then
        FNC_Mensagem("Exame não encontrado")
        Exit Sub
      End If
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim iCont As Integer
    Dim bSelecionado As Boolean = False

    If Not ComboBox_Selecionado(cboProfissional) Then
      FNC_Mensagem("É preciso selecionar o profissional")
      Exit Sub
    End If
    If Not IsDate(txtDataEnvio.Text) Then
      FNC_Mensagem("É preciso informar a data de envio")
      Exit Sub
    End If
    If objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagem_Chk) = 0 Then
      FNC_Mensagem("É preciso selecionar a solicitações de exames citológicos que irão no lote")
      Exit Sub
    End If
    For iCont = 0 To grdListagem.Rows.Count - 1
      If objGrid_CheckBox_Selecionado(grdListagem, iCont, const_GridListagem_Chk) Then
        bSelecionado = True
        Exit For
      End If
    Next

    If Not bSelecionado Then
      FNC_Mensagem("Selecione algum exame para o lote")
      Exit Sub
    End If

    Dim sSqlText As String

    If iSQ_CLINICA_EXAME_CITOLOGICO_LOTE = 0 Then
      sSqlText = DBMontar_SP("SP_CLINICA_EXAME_CITOLOGICO_LOTE_CAD", False, "@SQ_CLINICA_EXAME_CITOLOGICO_LOTE OUT",
                                                                            "@ID_EMPRESA",
                                                                            "@ID_PESSOA_PROFISSIONAL",
                                                                            "@DT_ENVIO")
      DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_EXAME_CITOLOGICO_LOTE", Nothing, , ParameterDirection.Output),
                           DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                           DBParametro_Montar("ID_PESSOA_PROFISSIONAL", cboProfissional.SelectedValue),
                           DBParametro_Montar("DT_ENVIO", txtDataEnvio.DateTime.Date, SqlDbType.Date))
      iSQ_CLINICA_EXAME_CITOLOGICO_LOTE = DBRetorno(1)
    End If

    If iSQ_CLINICA_EXAME_CITOLOGICO_LOTE > 0 Then
      For iCont = 0 To grdListagem.Rows.Count - 1
        sSqlText = DBMontar_SP("SP_CLINICA_EXAME_CITOLOGICO_SETAR_LOTE", False, "@ID_CLINICA_EXAME_CITOLOGICO",
                                                                                "@ID_CLINICA_EXAME_CITOLOGICO_LOTE",
                                                                                "@IC_ADICIONAR_REMOVER")
        DBExecutar(sSqlText, DBParametro_Montar("ID_CLINICA_EXAME_CITOLOGICO", objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO, iCont)),
                             DBParametro_Montar("ID_CLINICA_EXAME_CITOLOGICO_LOTE", iSQ_CLINICA_EXAME_CITOLOGICO_LOTE),
                             DBParametro_Montar("IC_ADICIONAR_REMOVER", IIf(objGrid_CheckBox_Selecionado(grdListagem, const_GridListagem_Chk, iCont), "A", "R")))
      Next
    End If

    FNC_Mensagem("Gravação Efetuada")

    cmdGravar.Enabled = False
    cmdImprimir.Enabled = True
  End Sub

  Private Sub frmCadastroAtendimentoSolicitacaoExameCitologicoLote_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub
End Class