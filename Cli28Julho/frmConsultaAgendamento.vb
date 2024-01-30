Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win
Imports Infragistics.Win.Misc.UltraWinNavigationBar
Imports NFe.Utils.InformacoesSuplementares

Public Class frmConsultaAgendamento
  Const const_GridListagem_SQ_AGENDAMENTO As Integer = 0
  Const const_GridListagem_ID_AGENDAMENTO_ORIGEM As Integer = 1
  Const const_GridListagem_ID_OPT_STATUS As Integer = 2
  Const const_GridListagem_ID_PROFISSIONAL As Integer = 3
  Const const_GridListagem_ID_PESSOA As Integer = 4
  Const const_GridListagem_ID_PROCEDIMENTO As Integer = 5
  Const const_GridListagem_Chk As Integer = 6
  Const const_GridListagem_CD_AGENDAMENTO As Integer = 7
  Const const_GridListagem_DH_AGENDAMENTO As Integer = 8
  Const const_GridListagem_NO_EMPRESA As Integer = 9
  Const const_GridListagem_NO_TIPO_CONSULTA As Integer = 10
  Const const_GridListagem_NO_OPT_STATUS As Integer = 11
  Const const_GridListagem_DT_NASC_ABERTURA As Integer = 12
  Const const_GridListagem_NO_PESSOA As Integer = 13
  Const const_GridListagem_NO_PROFISSIONAL As Integer = 14
  Const const_GridListagem_NO_CONVENIO As Integer = 15
  Const const_GridListagem_NO_PROCEDIMENTO As Integer = 16
  Const const_GridListagem_DH_CHEGADA As Integer = 17
  Const const_GridListagem_DH_SAIDA As Integer = 18
  Const const_GridListagem_DH_PAGAMENTO As Integer = 19
  Const const_GridListagem_CD_TELEFONE As Integer = 20
  Const const_GridListagem_CD_CELULAR As Integer = 21
  Const const_GridListagem_CD_AGENDAMENTO_ORIGEM As Integer = 22
  Const const_GridListagem_DS_COMPLEMENTO As Integer = 23
  Const const_GridListagem_NO_INDICACAO As Integer = 24
  Const const_GridListagem_IC_PRIMEIRA As Integer = 25
  Const const_GridListagem_NO_DIASEMANA As Integer = 26
  Const const_GridListagem_CD_DIASEMANA As Integer = 27
  Const const_GridListagem_VL_PROCEDIMENTO As Integer = 28
  Const const_GridListagem_NO_ESEPECIALIDADE As Integer = 29
  Const const_GridListagem_NO_EXECUTOR As Integer = 30
  Const const_GridListagem_IC_TIPO_RETORNO As Integer = 31
  Const const_GridListagem_NO_CANALMARCACAO As Integer = 32
  Const const_GridListagem_UsuarioMarcacao As Integer = 33

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(New frmCadastroAgendamento)
  End Sub

  Private Function PodeAlterarExcluirAgendamento(sTexto) As Boolean
    Dim bOk = False

    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Atendido.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Sistema_ConsultaGerada.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Sistema_Excluido.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_CanceladoClinica.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_CanceladoPaciente.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Iniciado.GetHashCode Then
      bOk = False
    ElseIf objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode Then
      bOk = (objGrid_Valor(grdListagem, const_GridListagem_IC_TIPO_RETORNO) = "S")
    Else
      bOk = True
    End If

    If Not bOk Then
      FNC_Mensagem("Agendamentos com os status " & objGrid_Valor(grdListagem, const_GridListagem_NO_OPT_STATUS) & " não podem ser " + sTexto)
    End If

    Return bOk
  End Function

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o agendamento a ser excluído")
      Exit Sub
    End If

    If PodeAlterarExcluirAgendamento("excluído") Then
      If FormSEGUsuario_Validacao() Then
        If FormCadastroAgendamento_Excluir(objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)) Then
          Pesquisar()
        End If
      End If
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String = ""
    Dim sSqlText_Where As String = ""

    If Not IsDate(txtDataInicial.Text) Then
      FNC_Mensagem("Informe a data inicial para a pesquisa")
      Exit Sub
    End If
    If Not IsDate(txtDataFinal.Text) Then
      FNC_Mensagem("Informe a data final para a pesquisa")
      Exit Sub
    End If

    sSqlText = "SELECT AGEND.SQ_AGENDAMENTO," &
                      "AGEND.ID_AGENDAMENTO_ORIGEM," &
                      "AGEND.ID_OPT_STATUS," &
                      "AGEND.ID_PESSOA_PROFISSIONAL," &
                      "AGEND.ID_PESSOA," &
                      "AGEND.ID_PROCEDIMENTO," &
                      "0," &
                      "AGEND.CD_AGENDAMENTO," &
                      "AGEND.DH_AGENDAMENTO," &
                      "EMPRE.NO_PESSOA NO_EMPRESA," &
                      "AGEND.NO_TIPO_CONSULTA," &
                      "AGEND.NO_OPT_STATUS," &
                      "AGEND.DT_NASC_ABERTURA," &
                      "AGEND.NO_PESSOA," &
                      "AGEND.NO_PESSOA_PROFISSIONAL," &
                      "AGEND.NO_CONVENIO," &
                      "AGEND.NO_PROCEDIMENTO," &
                      "AGEND.DH_CHEGADA," &
                      "AGEND.DH_SAIDA," &
                      "AGEND.DH_PAGAMENTO," &
                      "AGEND.CD_TELEFONE," &
                      "AGEND.CD_CELULAR," &
                      "AGEND.CD_AGENDAMENTO_ORIGEM," &
                      "AGEND.DS_COMPLEMENTO," &
                      "AGEND.NO_INDICACAO," &
                      "IIF(AGEND.IC_PRIMEIRA = 'S', 'Sim', 'Não')," &
                      "OPCDS.NO_OPCAO," &
                      "OPCDS.CD_OPCAO," &
                      "AGEND.VL_PROCEDIMENTO," &
                      "AGEND.NO_ESPECIALIDADE," &
                      "AGEND.NO_PESSOA_EXECUTOR," &
                      "AGEND.IC_TIPO_RETORNO," &
                      "AGEND.NO_CANALMARCACAO," &
                      "HISTO.NO_USUARIO" &
               " FROM VW_AGENDAMENTO AGEND (NOLOCK)" &
                " INNER JOIN TB_PESSOA EMPRE (NOLOCK) ON EMPRE.SQ_PESSOA = AGEND.ID_EMPRESA" &
                 " LEFT JOIN TB_OPCAO OPCDS (NOLOCK) ON OPCDS.ID_TIPO_OPCAO = 114" &
                                                  " AND OPCDS.CD_OPCAO = DATEPART(dw, AGEND.DH_AGENDAMENTO)" &
                 " LEFT JOIN VW_HISTORICO_INCLUSAO HISTO (NOLOCK) ON HISTO.ID_REGISTRO = AGEND.SQ_AGENDAMENTO" &
                                                               " AND HISTO.ID_OPT_PROCESSO = " & enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode()

    If ComboBox_Selecionado(cboEmpresa) Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_EMPRESA = " & cboEmpresa.SelectedValue, " AND ")
    End If
    If IsDate(txtDataInicial.Value) Then
      FNC_Str_Adicionar(sSqlText_Where, "CAST(AGEND.DH_AGENDAMENTO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text), " AND ")
    End If
    If IsDate(txtDataFinal.Value) Then
      FNC_Str_Adicionar(sSqlText_Where, "CAST(AGEND.DH_AGENDAMENTO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text), " AND ")
    End If
    If ComboBox_Selecionado(cboTipoAgendamento) Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_TIPO_CONSULTA = " & cboTipoAgendamento.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboStatus) Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_OPT_STATUS = " & cboStatus.SelectedValue, " AND ")
    End If
    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_PESSOA = " & psqPessoa.ID_Pessoa, " AND ")
    Else
      If Trim(psqPessoa.cboPessoa.Text) <> "" Then
        FNC_Str_Adicionar(sSqlText_Where, "AGEND.NO_PESSOA LIKE " & FNC_SQL_FormatarLike(psqPessoa.cboPessoa.Text), " AND ")
      End If
    End If
    If ComboBox_Selecionado(cboProfissional) Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_PESSOA_PROFISSIONAL = " & cboProfissional.SelectedValue, " AND ")
    End If
    If psqProcedimento.Identificador > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_PROCEDIMENTO = " & psqProcedimento.Identificador, " AND ")
    End If
    If chkPrimeiraSecao.Checked Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.IC_PRIMEIRA = 'S'", " AND ")
    End If
    If Trim(txtCodigo.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.CD_AGENDAMENTO LIKE " & FNC_SQL_FormatarLike(txtCodigo.Text), " AND ")
    End If
    If ComboBox_Selecionado(cboDiaSemana) Then
      FNC_Str_Adicionar(sSqlText_Where, "OPCDS.CD_OPCAO = '" & cboDiaSemana.SelectedItem(enComboBox_DiasSemana.CD_DIASEMANA) + "'", " AND ")
    End If
    If ComboBox_Selecionado(cboGrupoProcedimento) Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_GRUPOPROCEDIMENTO = " & cboGrupoProcedimento.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboEspecialdade) Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_ESPECIALIDADE = " & cboEspecialdade.SelectedValue, " AND ")
    End If
    If Trim(txtNrProntuario.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_PESSOA = " & txtNrProntuario.Text, " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText + " WHERE " + sSqlText_Where
    End If

    sSqlText = sSqlText &
               " ORDER BY AGEND.CD_AGENDAMENTO"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_AGENDAMENTO,
                                                           const_GridListagem_ID_AGENDAMENTO_ORIGEM,
                                                           const_GridListagem_ID_OPT_STATUS,
                                                           const_GridListagem_ID_PROFISSIONAL,
                                                           const_GridListagem_ID_PESSOA,
                                                           const_GridListagem_ID_PROCEDIMENTO,
                                                           const_GridListagem_Chk,
                                                           const_GridListagem_CD_AGENDAMENTO,
                                                           const_GridListagem_DH_AGENDAMENTO,
                                                           const_GridListagem_NO_EMPRESA,
                                                           const_GridListagem_NO_TIPO_CONSULTA,
                                                           const_GridListagem_NO_OPT_STATUS,
                                                           const_GridListagem_DT_NASC_ABERTURA,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_NO_PROFISSIONAL,
                                                           const_GridListagem_NO_CONVENIO,
                                                           const_GridListagem_NO_PROCEDIMENTO,
                                                           const_GridListagem_DH_CHEGADA,
                                                           const_GridListagem_DH_SAIDA,
                                                           const_GridListagem_DH_PAGAMENTO,
                                                           const_GridListagem_CD_TELEFONE,
                                                           const_GridListagem_CD_CELULAR,
                                                           const_GridListagem_CD_AGENDAMENTO_ORIGEM,
                                                           const_GridListagem_DS_COMPLEMENTO,
                                                           const_GridListagem_NO_INDICACAO,
                                                           const_GridListagem_IC_PRIMEIRA,
                                                           const_GridListagem_NO_DIASEMANA,
                                                           const_GridListagem_CD_DIASEMANA,
                                                           const_GridListagem_VL_PROCEDIMENTO,
                                                           const_GridListagem_NO_ESEPECIALIDADE,
                                                           const_GridListagem_NO_EXECUTOR,
                                                           const_GridListagem_IC_TIPO_RETORNO,
                                                           const_GridListagem_NO_CANALMARCACAO,
                                                           const_GridListagem_UsuarioMarcacao})

    FormCadastroAgendamentoAtendimento_ColocarCor(grdListagem, const_GridListagem_ID_OPT_STATUS)

    lblRListagemPessoa.Text = lblRListagemPessoa.Tag & " (" & grdListagem.Rows.Count & " registro(s))"
  End Sub

  Private Sub frmConsultaAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing

    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboTipoAgendamento, enSql.Tipo_Consulta)
    ComboBox_Carregar(cboStatus, enSql.StatusAgendamento_Todos)
    ComboBox_Carregar(cboEmpresa, enSql.Empresa)
    ComboBox_Carregar(cboDiaSemana, enSql.DiasSemana)
    ComboBox_Carregar(cboGrupoProcedimento, enSql.GrupoProcedimento)
    ComboBox_Carregar(cboEspecialdade, enSql.Especialidade)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_AGENDAMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_AGENDAMENTO_ORIGEM", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdListagem, "Nº Prontuário", 100)
    objGrid_Coluna_Add(grdListagem, "ID_PPROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "Chk.", 30, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdListagem, "Código", 80)
    objGrid_Coluna_Add(grdListagem, "Data/Hora Agendamento", 150, , , ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "Empresa", 200)
    objGrid_Coluna_Add(grdListagem, "Tipo de Consulta", 150)
    objGrid_Coluna_Add(grdListagem, "Status", 100)
    objGrid_Coluna_Add(grdListagem, "Dt. Nascimento", 50)
    objGrid_Coluna_Add(grdListagem, "Paciente", 200)
    objGrid_Coluna_Add(grdListagem, "Profissional", 200)
    objGrid_Coluna_Add(grdListagem, "Convênio", 200)
    objGrid_Coluna_Add(grdListagem, "Procedimento", 200)
    objGrid_Coluna_Add(grdListagem, "Data/Hora Chegada", 150, , , ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "Data/Hora Saída", 150, , , ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "Data/Hora Pagamento", 150, , , ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "Telefone", 150)
    objGrid_Coluna_Add(grdListagem, "Celular", 150)
    objGrid_Coluna_Add(grdListagem, "Código Origem", 80)
    objGrid_Coluna_Add(grdListagem, "Complemento", 300)
    objGrid_Coluna_Add(grdListagem, "Indicação", 150)
    objGrid_Coluna_Add(grdListagem, "Primeira Seção", 110)
    objGrid_Coluna_Add(grdListagem, "Dia de Semana", 100)
    objGrid_Coluna_Add(grdListagem, "CD_DIASEMANA", 0)
    objGrid_Coluna_Add(grdListagem, "Vlr. Procedimento", 150,,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Especialidade", 150)
    objGrid_Coluna_Add(grdListagem, "Executor", 150)
    objGrid_Coluna_Add(grdListagem, "IC_TIPO_RETORNO", 0)
    objGrid_Coluna_Add(grdListagem, "Canal Marcação", 150)
    objGrid_Coluna_Add(grdListagem, "Usuário de Marcação", 100)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    txtDataInicial.DateTime = Now.Date
    txtDataFinal.DateTime = Now.Date.AddDays(10)

    cmdNovo.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bIncluir
    cmdAlterar.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bAlterar
    cmdRemarcar.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bIncluir
    cmdRetorno.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bIncluir
    cmdVenda.Enabled = FNC_Permissao(enPermissao.VEND_ConsultaVenda).bIncluir
    cmdAguardandoAtendimento.Visible = (bUSUARIO_ADMINISTRADOR)
  End Sub

  Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If PodeAlterarExcluirAgendamento("alterado") Then
      If objGrid_LinhaSelecionada(grdListagem) = -1 Then
        FNC_Mensagem("Selecione o agendamento a ser alterado")
        Exit Sub
      End If

      Dim oForm As New frmCadastroAgendamento

      oForm.iSQ_AGENDAMENTO = objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)

      FNC_AbriTela(oForm)
    End If
  End Sub

  Private Sub cboStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles cboStatus.KeyDown
    If e.KeyCode = Keys.Delete Then cboStatus.SelectedIndex = -1
  End Sub

  Private Sub cboProfissional_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProfissional.KeyDown
    If e.KeyCode = Keys.Delete Then cboProfissional.SelectedIndex = -1
  End Sub

  Private Sub cboTipoAgendamento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoAgendamento.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoAgendamento.SelectedIndex = -1
  End Sub

  Private Sub frmConsultaAgendamento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdExcluir.Top = cmdNovo.Top
    cmdRetorno.Top = cmdNovo.Top
    cmdRemarcar.Top = cmdNovo.Top
    cmdVenda.Top = cmdNovo.Top
    cmdHistorico.Top = cmdNovo.Top
    cmdCancelar.Top = cmdNovo.Top
    cmdExcel.Top = cmdNovo.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdNovo.Top
    cmdPDF.Top = cmdNovo.Top

    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o agendamento a ser excluído")
      Exit Sub
    End If

    If PodeAlterarExcluirAgendamento("cancelado") Then
      If FNC_Perguntar("Deseja realmente cancelar esse agendamento?") Then
        If FNC_Busca_Agendamento_ExisteAtendimento(objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)) Then
          FNC_Mensagem("Existe atendimento associado a esse agendamento")
        Else
          Dim oForm As New frmConsultaAgendamentoCancelamento

          oForm.iSQ_AGENDAMENTO = objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)
          FNC_AbriTela(oForm, , True, True)

          Pesquisar()
        End If
      End If
    End If
  End Sub

  Private Sub cmdRetorno_Click(sender As Object, e As EventArgs) Handles cmdRetorno.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar o agendamento para cadastrar o retorno")
      Exit Sub
    End If

    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Atendido.GetHashCode Then
      Dim oForm As New frmCadastroAgendamento_ProfissionalData

      oForm.iSQ_AGENDAMENTO = objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)
      oForm.iID_PROFISSIONAL = objGrid_Valor(grdListagem, const_GridListagem_ID_PROFISSIONAL)
      oForm.dDataAgendamento = objGrid_Valor(grdListagem, const_GridListagem_DH_AGENDAMENTO)
      oForm.eTipoAlteracao = frmLancaAgendamento_ProfissionalData.enTipoAlteracao.Retorno

      FNC_AbriTela(oForm, , True, True)

      If oForm.bGravado Then Pesquisar()
    Else
      FNC_Mensagem("É preciso o agendamendo ter sido atendimento para que seja marcado o retorno")
    End If
  End Sub

  Private Sub cmdRemarcar_Click(sender As Object, e As EventArgs) Handles cmdRemarcar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar o agendamento que será remarcado")
      Exit Sub
    End If

    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Confirmado.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode Or
       objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusAgendamento_Agendado.GetHashCode Then
      Dim oForm As New frmCadastroAgendamento_ProfissionalData

      oForm.iSQ_AGENDAMENTO = objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)
      oForm.iID_PROFISSIONAL = objGrid_Valor(grdListagem, const_GridListagem_ID_PROFISSIONAL)
      oForm.dDataAgendamento = objGrid_Valor(grdListagem, const_GridListagem_DH_AGENDAMENTO)
      oForm.eTipoAlteracao = frmLancaAgendamento_ProfissionalData.enTipoAlteracao.Remarcacao

      FNC_AbriTela(oForm, , True, True)

      If oForm.bGravado Then Pesquisar()
    Else
      FNC_Mensagem("O status do agendamento não permite remarcação")
    End If
  End Sub

  Private Sub cmdHistorico_Click(sender As Object, e As EventArgs) Handles cmdHistorico.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar o agendamento para o qual deseja ver o histórico")
      Exit Sub
    End If

    Dim oForm As New frmConsultaHistorico_Registro

    oForm.iProcessso = enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode()
    oForm.iID_REGISTRO = objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)
    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub frmConsultaAgendamento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub grdListagem_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grdListagem.DoubleClickCell
    cmdAlterar.PerformClick()
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    psqPessoa.ID_Pessoa = 0
    cboTipoAgendamento.SelectedIndex = -1
    cboProfissional.SelectedIndex = -1
    psqProcedimento.Limpar()
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
    txtCodigo.Text = ""
    chkPrimeiraSecao.Checked = False
    cboStatus.SelectedIndex = -1
    cboGrupoProcedimento.SelectedIndex = -1
    cboEspecialdade.SelectedIndex = -1
    cboDiaSemana.SelectedIndex = -1
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar o agendamento que será exportado")
      Exit Sub
    End If

    Dim iCont As Integer
    Dim sCodigoAgendamento As String = ""

    For iCont = 0 To grdListagem.Rows.Count - 1
      FNC_Str_Adicionar(sCodigoAgendamento, objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO, iCont), ",")
    Next

    FormRelatorioAgendamento(sCodigoAgendamento)
  End Sub

  Private Sub frmConsultaAgendamento_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.F3 Then
      cmdPesquisar.PerformClick()
    ElseIf e.KeyCode = Keys.Delete Then
      cmdExcluir.PerformClick()
    ElseIf e.Control Then
      Select Case e.KeyCode
        Case Keys.N
          cmdNovo.PerformClick()
        Case Keys.A
          cmdAlterar.PerformClick()
        Case Keys.E
          cmdExcluir.PerformClick()
        'Case Keys.C
        '  cmdCancelar.PerformClick()
        Case Keys.R
          cmdRetorno.PerformClick()
        Case Keys.T
          cmdRemarcar.PerformClick()
        Case Keys.H
          cmdHistorico.PerformClick()
      End Select
    End If
  End Sub

  Private Sub cmdVenda_Click(sender As Object, e As EventArgs) Handles cmdVenda.Click
    If objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagem_Chk) = 0 Then
      FNC_Mensagem("É necessário selecionar o agendamento para o qual deseja gerar uma venda")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim iCont As Integer
    Dim oID_AGENDAMENTO = New Collection

    For iCont = 0 To grdListagem.Rows.Count - 1
      If objGrid_CheckBox_Selecionado(grdListagem, const_GridListagem_Chk, iCont) Then
        If FNC_In(objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS, iCont), enOpcoes.StatusAgendamento_Agendado.GetHashCode(),
                                                                                       enOpcoes.StatusAgendamento_Confirmado.GetHashCode(),
                                                                                       enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode()) Then
          If objGrid_Valor(grdListagem, const_GridListagem_VL_PROCEDIMENTO, iCont, 0) > 0 Then
            sSqlText = "SELECT COUNT(*) FROM VW_CLINICA_VENDA_AGENDAMENTO WHERE ID_AGENDAMENTO = " & objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO, iCont) & " AND DH_CANCELAR IS NULL"

            If DBQuery_ValorUnico(sSqlText) > 0 Then
              FNC_Mensagem("Existe venda realizada para o agendamento " & objGrid_Valor(grdListagem, const_GridListagem_CD_AGENDAMENTO, iCont))
              Exit Sub
            End If

            oID_AGENDAMENTO.Add(objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO, iCont))
          End If
        End If
      End If
    Next

    If oID_AGENDAMENTO.Count > 0 Then
      Dim oForm As New frmCadastroVenda

      oForm.iID_PESSOA = objGrid_Valor(grdListagem, const_GridListagem_ID_PESSOA)
      oForm.oID_AGENDAMENTO = oID_AGENDAMENTO

      FNC_AbriTela(oForm, , True, True)

      oForm.Dispose()
    Else
      FNC_Mensagem("Não foi selecionado nenhum agendamento com valor para gerar a venda")
    End If
  End Sub

  Private Sub cmdDisponibilidade_Click(sender As Object, e As EventArgs) Handles cmdDisponibilidade.Click
    Dim sProfissional As String = ""
    Dim sProcedimento As String = ""
    Dim sEspecialidade As String = ""
    Dim sEmpresa As String = ""

    If Not IsDate(txtDataInicial.Text) Or Not IsDate(txtDataFinal.Text) Then
      FNC_Mensagem("Selecione o período")
      Exit Sub
    End If
    If psqProcedimento.Identificador > 0 Then
      FNC_Str_Adicionar(sProcedimento, psqProcedimento.Identificador, ",")
    End If
    If ComboBox_Selecionado(cboProfissional) Then
      FNC_Str_Adicionar(sProfissional, cboProfissional.SelectedValue, ",")
    End If
    If ComboBox_Selecionado(cboEmpresa) Then
      FNC_Str_Adicionar(sEmpresa, cboEmpresa.SelectedValue, ",")
    End If

    Dim oForm As New frmConsultaAgendamentoDisponibilidade

    oForm.sData_Inicial = txtDataInicial.Text
    oForm.sData_Final = txtDataFinal.Text
    oForm.sID_Profissionais = sProfissional
    oForm.sID_Procedimentos = sProcedimento
    oForm.sID_Especialidade = sEspecialidade
    oForm.sID_Paiciente = psqPessoa.ID_Pessoa
    oForm.sProfissionais = cboProfissional.Text
    oForm.sProcedimentos = psqProcedimento.Nome
    oForm.sEspecialidade = cboEspecialdade.Text
    oForm.sPaciente = psqPessoa.cboPessoa.Text
    oForm.sEmpresa = sEmpresa
    oForm.bPodeSelecionar = True

    If ComboBox_Selecionado(cboEspecialdade) Then
      oForm.sID_Especialidade = cboEspecialdade.SelectedValue
    End If
    If ComboBox_Selecionado(cboGrupoProcedimento) Then
      oForm.sID_GrupoProcedimentos = cboGrupoProcedimento.SelectedValue
    End If

    oForm.Formatar()

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cboGrupoProcedimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoProcedimento.SelectedIndexChanged
    psqProcedimento.GrupoProcedimento = FNC_NVL(cboGrupoProcedimento.SelectedValue, 0)
  End Sub

  Private Sub cboGrupoProcedimento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboGrupoProcedimento.KeyDown
    If e.KeyCode = Keys.Delete Then cboGrupoProcedimento.SelectedIndex = -1
  End Sub

  Private Sub cboEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEmpresa.KeyDown
    If e.KeyCode = Keys.Delete Then cboEmpresa.SelectedIndex = -1
  End Sub

  Private Sub cmdPessoaExecutora_Click(sender As Object, e As EventArgs) Handles cmdPessoaExecutora.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o agendamento a ser alterado")
      Exit Sub
    End If
    If Not FNC_In(objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS), enOpcoes.StatusAgendamento_Agendado.GetHashCode(),
                                                                                enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode(),
                                                                                enOpcoes.StatusAgendamento_Atendido.GetHashCode()) Then
      FNC_Mensagem("O agendamento precisa está no status de Agendado, Aguardando Atendimento e Atendido para poder se alterado")
      Exit Sub
    End If

    Dim oForm As New frmConsultaAgendamentoExecucao

    oForm.iSQ_AGENDAMENTO = objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)
    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdConfirmado_Click(sender As Object, e As EventArgs) Handles cmdConfirmado.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o agendamento a ser confirmado")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) <> enOpcoes.StatusAgendamento_Agendado.GetHashCode Then
      FNC_Mensagem("Só é permitido confirmar agendamentos com o status Agendado")
      Exit Sub
    End If

    sSqlText = "UPDATE TB_AGENDAMENTO SET ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Confirmado.GetHashCode() & " WHERE SQ_AGENDAMENTO = " & objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)
    DBExecutar(sSqlText)

    Dim oHistorico As New clsHistorico

    oHistorico.ID_Registro = objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO)
    oHistorico.GravarHistorico(enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode,
                               enOpcoes.Processo_Acao_Alteracao, 0,
                               objGrid_Valor(grdListagem, const_GridListagem_CD_AGENDAMENTO),
                               "Confirmado")

    FNC_Mensagem("Confirmação Efetuada")

    Pesquisar()
  End Sub

  Private Sub cmdAguardandoAtendimento_Click(sender As Object, e As EventArgs) Handles cmdAguardandoAtendimento.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o agendamento a ser confirmado")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) <> enOpcoes.StatusAgendamento_Atendido.GetHashCode Then
      FNC_Mensagem("Só é permitido alterar o status dos agendamentos atendidos")
      Exit Sub
    End If

    If Not FNC_Perguntar("Deseja realmente alterar o status do agendamento para aguardando atendimento?") Then Exit Sub

    FormCadastroAgendamento_AlterarStatus(iSQ_AGENDAMENTO:=objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO),
                                          iID_OPT_STATUS:=enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode(),
                                          ForcarStatus:=True)

    Pesquisar()

    FNC_Mensagem("Status alterado")
  End Sub
End Class