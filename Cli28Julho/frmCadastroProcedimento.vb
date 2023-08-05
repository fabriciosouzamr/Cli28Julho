Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmCadastroProcedimento
  Public iSQ_PROCEDIMENTO As Integer

  Const const_GridEspecialidade_ID_ESEPECIALIDADE As Integer = 0
  Const const_GridEspecialidade_IC_FAVORITO As Integer = 1

  Dim oDBGridEspecialidade As New UltraWinDataSource.UltraDataSource

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Trim(txtCodigo.Text) = "" Then
      FNC_Mensagem("Informe o código do procedimento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTabelaProcedimento) Then
      FNC_Mensagem("Selecione a tabela de procedimento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoProcedimento) Then
      FNC_Mensagem("Selecione o tipo de procedimento")
      Exit Sub
    End If
    If Trim(txtNomeProcedimento.Text) = "" Then
      FNC_Mensagem("Informe o nome do procedimento")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = DBMontar_SP("SP_PROCEDIMENTO_CAD", False, "@SQ_PROCEDIMENTO OUT",
                                                         "@ID_TABELAPROCEDIMENTO",
                                                         "@ID_OPT_TIPOPROCEDIMENTO",
                                                         "@ID_OPT_TIPOEXAME",
                                                         "@ID_GRUPOPROCEDIMENTO",
                                                         "@ID_PLANOCONTAS",
                                                         "@ID_TIPO_CONSULTA_PREFERENCIAL",
                                                         "@ID_CLASSIFICACAO_EXAME",
                                                         "@ID_ESPECIALIDADE_PADRAO",
                                                         "@ID_PESSOA_EXECUTOU_PADRAO",
                                                         "@CD_PROCEDIMENTO",
                                                         "@NO_PROCEDIMENTO",
                                                         "@IC_GERA_CLINICA_EXAME_CITOLOGICO",
                                                         "@CD_INTEGRACAO_EXAME",
                                                         "@DS_INTEGRACAO_EXAME",
                                                         "@CD_INTEGRACAO_MATERIAL",
                                                         "@DS_INTEGRACAO_MATERIAL",
                                                         "@IC_ATIVO")

    If DBExecutar(sSqlText, DBParametro_Montar("SQ_PROCEDIMENTO", iSQ_PROCEDIMENTO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_TABELAPROCEDIMENTO", cboTabelaProcedimento.SelectedValue),
                            DBParametro_Montar("ID_OPT_TIPOPROCEDIMENTO", cboTipoProcedimento.SelectedValue),
                            DBParametro_Montar("ID_OPT_TIPOEXAME", cboTipoExame.SelectedValue),
                            DBParametro_Montar("ID_GRUPOPROCEDIMENTO", cboGrupoProcedimento.SelectedValue),
                            DBParametro_Montar("ID_PLANOCONTAS", cboPlanoContas.SelectedValue),
                            DBParametro_Montar("ID_CLASSIFICACAO_EXAME", cboClassificacaoExame.SelectedValue),
                            DBParametro_Montar("ID_TIPO_CONSULTA_PREFERENCIAL", cboTipoConsultaPreferencial.SelectedValue),
                            DBParametro_Montar("ID_ESPECIALIDADE_PADRAO", Nothing),
                            DBParametro_Montar("ID_PESSOA_EXECUTOU_PADRAO", FNC_NuloZero(psqExecutor.ID_Pessoa, False)),
                            DBParametro_Montar("CD_PROCEDIMENTO", Trim(txtCodigo.Text)),
                            DBParametro_Montar("NO_PROCEDIMENTO", Trim(txtNomeProcedimento.Text)),
                            DBParametro_Montar("IC_GERA_CLINICA_EXAME_CITOLOGICO", IIf(chkGeraExameCitologico.Checked, "S", "N")),
                            DBParametro_Montar("CD_INTEGRACAO_EXAME", Trim(txtSisVida_CodigoExame.Text)),
                            DBParametro_Montar("DS_INTEGRACAO_EXAME", Trim(txtSisVida_DescricaoExame.Text)),
                            DBParametro_Montar("CD_INTEGRACAO_MATERIAL", Trim(txtSisVida_CodigoMaterial.Text)),
                            DBParametro_Montar("DS_INTEGRACAO_MATERIAL", Trim(txtSisVida_DescricaoMaterial.Text)),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_PROCEDIMENTO = DBRetorno(1)
      End If

      sSqlText = "DELETE FROM TB_PROCEDIMENTO_ESPECIALIDADE WHERE ID_PROCEDIMENTO = " & iSQ_PROCEDIMENTO
      DBExecutar(sSqlText)

      For iCont = 0 To grdEspecialidade.Rows.Count - 1
        sSqlText = DBMontar_Insert("TB_PROCEDIMENTO_ESPECIALIDADE", TipoCampoFixo.DadoCriacao, "ID_PROCEDIMENTO", "@ID_PROCEDIMENTO",
                                                                                               "ID_ESPECIALIDADE", "@ID_ESPECIALIDADE",
                                                                                               "IC_FAVORITO", "@IC_FAVORITO")
        DBExecutar(sSqlText, DBParametro_Montar("ID_PROCEDIMENTO", iSQ_PROCEDIMENTO),
                             DBParametro_Montar("ID_ESPECIALIDADE", objGrid_Valor(grdEspecialidade, const_GridEspecialidade_ID_ESEPECIALIDADE, iCont)),
                             DBParametro_Montar("IC_FAVORITO", objGrid_CheckCol_Valor(grdEspecialidade, const_GridEspecialidade_IC_FAVORITO, iCont)))
      Next

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub TipoExame_Habilitar(bHabilitar As Boolean)
    lblRTipoExame.Enabled = bHabilitar
    cboTipoExame.Enabled = bHabilitar
    If Not bHabilitar Then cboTipoExame.SelectedIndex = -1
  End Sub

  Private Sub frmCadastroProcedimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboTabelaProcedimento, enSql.TabelaProcedimento)
    ComboBox_Carregar(cboTipoProcedimento, enSql.TipoProcedimento)
    ComboBox_Carregar(cboTipoExame, enSql.TipoExame)
    ComboBox_Carregar(cboPlanoContas, enSql.PlanoContas_Credito)
    ComboBox_Carregar(cboGrupoProcedimento, enSql.GrupoProcedimento)
    ComboBox_Carregar(cboClassificacaoExame, enSql.ClassificacaoExame)
    ComboBox_Carregar(cboTipoConsultaPreferencial, enSql.Tipo_Consulta)

    TipoExame_Habilitar(False)

    objGrid_Inicializar(grdEspecialidade, AllowAddNew.TemplateOnTop, oDBGridEspecialidade, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdEspecialidade, "Especialidade", 400, , True, , FNC_CarregarLista(enTipoCadastro.Especialidade))
    objGrid_Coluna_Add(grdEspecialidade, "Favorito", 100, , True, ColumnStyle.CheckBox)

    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_Procedimento).bGravar

    chkAtivo.Checked = True

    If iSQ_PROCEDIMENTO > 0 Then
      CarregarDados()
    End If

    Me.Width = 780
    Me.Height = 615
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * " &
               " FROM TB_PROCEDIMENTO" &
               " WHERE SQ_PROCEDIMENTO = " & iSQ_PROCEDIMENTO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      ComboBox_Selecionar(cboTabelaProcedimento, .Item("ID_TABELAPROCEDIMENTO"))
      ComboBox_Selecionar(cboTipoProcedimento, .Item("ID_OPT_TIPOPROCEDIMENTO"))
      ComboBox_Selecionar(cboTipoExame, .Item("ID_OPT_TIPOEXAME"))
      ComboBox_Selecionar(cboGrupoProcedimento, .Item("ID_GRUPOPROCEDIMENTO"))
      ComboBox_Selecionar(cboPlanoContas, .Item("ID_PLANOCONTAS"))
      ComboBox_Selecionar(cboClassificacaoExame, .Item("ID_CLASSIFICACAO_EXAME"))
      ComboBox_Selecionar(cboTipoConsultaPreferencial, .Item("ID_TIPO_CONSULTA_PREFERENCIAL"))
      psqExecutor.ID_Pessoa = FNC_NVL(.Item("ID_PESSOA_EXECUTOU_PADRAO"), 0)
      txtCodigo.Text = .Item("CD_PROCEDIMENTO")
      txtNomeProcedimento.Text = .Item("NO_PROCEDIMENTO")
      chkAtivo.Checked = (.Item("IC_ATIVO") = "S")
      chkGeraExameCitologico.Checked = (.Item("IC_GERA_CLINICA_EXAME_CITOLOGICO") = "S")
      txtSisVida_CodigoExame.Text = FNC_NVL(.Item("CD_INTEGRACAO_EXAME"), "")
      txtSisVida_DescricaoExame.Text = FNC_NVL(.Item("DS_INTEGRACAO_EXAME"), "")
      txtSisVida_CodigoMaterial.Text = FNC_NVL(.Item("CD_INTEGRACAO_MATERIAL"), "")
      txtSisVida_DescricaoMaterial.Text = FNC_NVL(.Item("DS_INTEGRACAO_MATERIAL"), "")
    End With

    sSqlText = "SELECT PCESP.ID_ESPECIALIDADE," &
                      "IIF(PCESP.IC_FAVORITO = 'S', 1, 0)" &
               " FROM TB_PROCEDIMENTO_ESPECIALIDADE	PCESP" &
                " INNER JOIN TB_ESPECIALIDADE	ESPEC ON ESPEC.SQ_ESPECIALIDADE = PCESP.ID_ESPECIALIDADE" &
               " WHERE PCESP.ID_PROCEDIMENTO = " & iSQ_PROCEDIMENTO.ToString() &
               " ORDER BY ESPEC.NO_ESPECIALIDADE"
    objGrid_Carregar(grdEspecialidade, sSqlText, New Integer() {const_GridEspecialidade_ID_ESEPECIALIDADE,
                                                                const_GridEspecialidade_IC_FAVORITO})
  End Sub

  Private Sub cboTipoProcedimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoProcedimento.SelectedIndexChanged
    If ComboBox_Selecionado(cboTipoProcedimento) Then
      TipoExame_Habilitar(cboTipoProcedimento.SelectedValue = enOpcoes.TipoProcedimento_Exame.GetHashCode())
    Else
      TipoExame_Habilitar(False)
    End If
  End Sub

  Private Sub cmdSelecionarTodas_Click(sender As Object, e As EventArgs) Handles cmdSelecionarTodas.Click
    Dim iCont As Integer

    For iCont = 0 To grdEspecialidade.Rows.Count - 1
      grdEspecialidade.Rows(iCont).Cells(const_GridEspecialidade_IC_FAVORITO).Value = 1
    Next
  End Sub

  Private Sub cboGrupoProcedimento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboGrupoProcedimento.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboGrupoProcedimento.SelectedIndex = -1
    End If
  End Sub

  Private Sub cboPlanoContas_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPlanoContas.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboPlanoContas.SelectedIndex = -1
    End If
  End Sub

  Private Sub grdEspecialidade_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdEspecialidade.BeforeRowsDeleted
    Dim sSqlText As String

    e.DisplayPromptMsg = False

    If FNC_Perguntar("Deseja realmente excluir a Especialidade " & e.Rows(0).Cells(const_GridEspecialidade_ID_ESEPECIALIDADE).Value & "?") Then
      sSqlText = "DELETE FROM TB_PROCEDIMENTO_ESPECIALIDADE" &
                 " WHERE ID_ESPECIALIDADE =" & e.Rows(0).Cells(const_GridEspecialidade_ID_ESEPECIALIDADE).Value &
                   " AND ID_PROCEDIMENTO  = " & iSQ_PROCEDIMENTO.ToString()
      DBExecutar(sSqlText)
    End If
  End Sub

  Private Sub grdEspecialidade_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdEspecialidade.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridEspecialidade_ID_ESEPECIALIDADE).Value) Then
      FNC_Mensagem("É preciso informar o nome da Esepcialidade")
      e.Cancel = True
      Exit Sub
    End If
  End Sub
End Class