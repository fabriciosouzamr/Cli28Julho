Imports System.ComponentModel
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmCadastroAgendamento
  Const const_GridHorario_SQ_AGENDAMENTO As Integer = 0
  Const const_GridHorario_ID_PROCEDIMENTO As Integer = 1
  Const const_GridHorario_ID_PACIENTE As Integer = 2
  Const const_GridHorario_ID_OPT_TIPOEVENTO As Integer = 3
  Const const_GridHorario_Smile As Integer = 4
  Const const_GridHorario_HORA As Integer = 5
  Const const_GridHorario_Codigo As Integer = 6
  Const const_GridHorario_Paciente As Integer = 7
  Const const_GridHorario_Status As Integer = 8
  Const const_GridHorario_IC_TIPO_RETORNO As Integer = 9

  Const const_GridAlerta_TipoAlerta As Integer = 0
  Const const_GridAlerta_Descricao As Integer = 1
  Const const_GridAlerta_OutrasInformações As Integer = 2

  Public oAgendamento_Disponibilidade As clsAgendamento_Disponibilidade
  Public iSQ_AGENDAMENTO As Integer
  Public bInclusaoEdicao As Boolean

  Dim iLinhaSelecionada As Integer

  Dim oDBHorario As New UltraWinDataSource.UltraDataSource
  Dim oDBAlerta As New UltraWinDataSource.UltraDataSource
  Dim bEmProcessamento As Boolean = False
  Dim bAtualizandoGrid As Boolean = False
  Dim oHistorico As New clsHistorico

  Dim dVL_PROCEDIMENTO As Double

  Dim oConexaoLocal As System.Data.SqlClient.SqlConnection
  Dim bEdicao_Incluir As Boolean
  Dim bEdicao_Alterar As Boolean
  Dim iQT_LIMITE As Integer = 0
  Dim sHorarioAtendimento_Inicio As String
  Dim sHorarioAtendimento_Fim As String
  Public iID_PACIENTE As Integer

  Private Sub frmCadastroAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    psqProcedimento.Convenio = -1

    FormLancamentoAgendamento_CanceladoFalta_Atualizar()
    FormatarTela()

    cboEspecialdade.Enabled = False
    cboProfissional.Enabled = False
    cboEmpresa.Enabled = False

    If Not oAgendamento_Disponibilidade Is Nothing Then
      ComboBox_Selecionar(cboEspecialdade, oAgendamento_Disponibilidade.Especialidade)
      ComboBox_Selecionar(cboProfissional, oAgendamento_Disponibilidade.Medico)
      bEmProcessamento = True
      ComboBox_Selecionar(cboEmpresa, oAgendamento_Disponibilidade.Empresa)
      txtDataAgendamento.Value = oAgendamento_Disponibilidade.Data
      bEmProcessamento = False

      CarregarLinhas()

      psqPessoa.ID_Pessoa = oAgendamento_Disponibilidade.Paciente
    End If

    If cboConvenio.SelectedIndex = -1 Then ComboBox_Selecionar(cboConvenio, iEMPRESA_ID_CONVENIO_PADRAO)

    If Not oAgendamento_Disponibilidade Is Nothing Then
      Dim sSqlText As String

      If Trim(oAgendamento_Disponibilidade.Procedimento) <> "" Then
        psqProcedimento.Identificador = oAgendamento_Disponibilidade.Procedimento

        sSqlText = "SELECT ID_TIPO_CONSULTA_PREFERENCIAL FROM TB_PROCEDIMENTO" &
                   " WHERE SQ_PROCEDIMENTO = " & oAgendamento_Disponibilidade.Procedimento
        ComboBox_Selecionar(cboTipoAgendamento, DBQuery_ValorUnico(sSqlText))
      End If
    End If

    cmdVenda.Enabled = FNC_Permissao(enPermissao.VEND_ConsultaVenda).bIncluir
    cmdRemarcar.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bIncluir
    cmdRetorno.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bIncluir
    cmdNovo.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bIncluir
    cmdGravar.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bGravar
    cmdExcluir.Enabled = FNC_Permissao(enPermissao.AGEN_Agendamento).bExcluir

    bEdicao_Incluir = FNC_Permissao(enPermissao.AGEN_Agendamento).bIncluir
    bEdicao_Alterar = FNC_Permissao(enPermissao.AGEN_Agendamento).bAlterar

    oConexaoLocal = New SqlClient.SqlConnection

    DBConectar(sDBStringDeConecao01, sDBStringDeConecao02,, oConexaoLocal)

    cmdRetorno.Enabled = False
    cmdRemarcar.Enabled = False
    cmdNovo.Enabled = False
  End Sub

  Private Sub FormatarTela()
    bEmProcessamento = True

    'Formatar Grid Agendamento
    objGrid_Inicializar(grdHorario, , oDBHorario, UltraWinGrid.CellClickAction.RowSelect, , False, False, , , , , , HeaderClickAction.Select, False)
    objGrid_Coluna_Add(grdHorario, "SQ_AGENDAMENTO", 0)
    objGrid_Coluna_Add(grdHorario, "ID_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdHorario, "ID_PACIENTE", 0)
    objGrid_Coluna_Add(grdHorario, "ID_OPT_TIPOEVENTO", 0)
    objGrid_Coluna_Add(grdHorario, " ", 25, , , , , , , , , , , HAlign.Center)
    objGrid_Coluna_Add(grdHorario, "Hora", 50)
    objGrid_Coluna_Add(grdHorario, "Código", 62)
    objGrid_Coluna_Add(grdHorario, "Paciente", 338)
    objGrid_Coluna_Add(grdHorario, "Status", 110)
    objGrid_Coluna_Add(grdHorario, "IC_TIPO_RETORNO", 0)

    ComboBox_Carregar(cboTipoAgendamento, enSql.Tipo_Consulta, New Object() {"S"})
    ComboBox_Carregar(cboConvenio, enSql.Convenio_Ativo)
    ComboBox_Carregar(cboStatus, enSql.StatusAgendamento)
    ComboBox_Carregar(cboEspecialdade, enSql.Especialidade)
    ComboBox_Carregar(cboCanalMarcacao, enSql.CanalMarcacao)

    cboStatus.Enabled = False

    'psqPessoa.CarregarTodos = True
    psqPessoa.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Fisica.GetHashCode()
    psqPessoa.TipoCadastro = uscPesqPessoa.enTipoCadastro.CadastroPaciente
    psqPessoa.AdicionarPessoa = True

    If iSQ_AGENDAMENTO > 0 Then
      Dim sSqlText As String
      Dim oData As DataTable

      sSqlText = "SELECT * FROM TB_AGENDAMENTO WHERE SQ_AGENDAMENTO = " + iSQ_AGENDAMENTO.ToString()
      oData = DBQuery(sSqlText)

      With oData.Rows(0)
        txtDataAgendamento.Value = .Item("DH_AGENDAMENTO")
        ComboBox_Selecionar(cboEspecialdade, FNC_NVL(.Item("ID_ESPECIALIDADE"), 0))
        ComboBox_Carregar(cboProfissional, enSql.Especilidade_Profissional, New Object() {FNC_NVL(.Item("ID_ESPECIALIDADE"), 0)})
        ComboBox_Selecionar(cboProfissional, FNC_NVL(.Item("ID_PESSOA_PROFISSIONAL"), 0))
        ComboBox_Carregar(cboEmpresa, enSql.Empresa_Profissional_Especialidade, New Object() {FNC_NVL(.Item("ID_ESPECIALIDADE"), 0), FNC_NVL(.Item("ID_PESSOA_PROFISSIONAL"), 0)})
        ComboBox_Selecionar(cboEmpresa, .Item("ID_EMPRESA"))
        ComboBox_Selecionar(cboCanalMarcacao, .Item("ID_CANALMARCACAO"))

        Calendario_CarregarLinhas()
        ListagemAgendamento_Carregar()
        iSQ_AGENDAMENTO = .Item("SQ_AGENDAMENTO")
        ComboBox_AgendamentosParaEsseHorario_Carregar()
      End With

      oData.Dispose()
    Else
      If oAgendamento_Disponibilidade Is Nothing Then
        txtDataAgendamento.Value = Now
        txtDataAgendamento.Tag = Now

        txtDataChegada.Value = Nothing
        txtDataSaida.Value = Nothing

        LimparTela(True)
        ComboBox_Selecionar(cboEmpresa, iID_EMPRESA_FILIAL)
        psqProcedimento.Limpar()
      End If
    End If

    chkAtualizarListagemAutomaticamente.Checked = bUSUARIO_IC_ATUALIZAR_AGENDA_AUTOMATICO
    lblInformacoes.Text = ""
    lblSaldoConvenio.Text = ""
    txtDataAgendamento.ReadOnly = True
    cboTipoAgendamento.Enabled = False

    bEmProcessamento = False
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim iCont As Integer
    Dim sSqlText As String
    Dim iRowIndex As Integer
    Dim iAcao As enOpcoes = enOpcoes.Processo_Acao_Inclusao
    Dim eID_OPT_STATUS As enOpcoes = enOpcoes.StatusAgendamento_Agendado

    If Not Agendamento_Validar() Then
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboEmpresa) Then
      FNC_Mensagem("Selecione a filial")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboEspecialdade) Then
      FNC_Mensagem("Selecione a especialidade")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboProfissional) Then
      FNC_Mensagem("Selecione o profissional")
      Exit Sub
    End If
    If Not IsDate(txtDataAgendamento.Value) Then
      FNC_Mensagem("Informe a data de horário do agendamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoAgendamento) Then
      FNC_Mensagem("Selecione o tipo de agendamento")
      Exit Sub
    End If
    If Trim(psqPessoa.DS_Pessoa) = "" Then
      FNC_Mensagem("Informe o paciente")
      Exit Sub
    End If
    If Trim(FNC_SoNumero(txtTelefone.Text)) = "" And Trim(FNC_SoNumero(txtCelular.Text)) = "" Then
      FNC_Mensagem("Informe um número de telefone ou celular")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboConvenio) Then
      FNC_Mensagem("Selecione um convênio")
      Exit Sub
    End If
    If FNC_NVL(cboConvenio.SelectedItem(enComboBox_Convenio.IC_CONTROLACREDITO), "N") = "S" Then
      sSqlText = "SELECT VL_CREDITO FROM TB_CONVENIO WHERE SQ_CONVENIO = " & cboConvenio.SelectedValue

      If DBQuery_ValorUnico(sSqlText, 0) < dVL_PROCEDIMENTO Then
        FNC_Mensagem("Esse convênio tem controle de créito, e o saldo é menor do que o valor do procedimento")
        Exit Sub
      End If
    End If
    If psqProcedimento.Identificador = 0 Then
      FNC_Mensagem("Informe o procedimento")
      Exit Sub
    End If
    If iSQ_AGENDAMENTO = 0 Then
      If FNC_Busca_Agendamento_Existe(FNC_NVL(cboEmpresa.SelectedValue, 0), FNC_NVL(cboProfissional.SelectedValue, 0), txtDataAgendamento.Value) Then
        FNC_Mensagem("Existe agendamento para esse horário, favor atualizar a listagem de agendamentos")
        Exit Sub
      End If
    End If
    If FNC_Hora(sHorarioAtendimento_Inicio) > FNC_Hora(FNC_StrZero(txtDataAgendamento.DateTime.Hour.ToString(), 2) & ":" & FNC_StrZero(txtDataAgendamento.DateTime.Minute.ToString(), 2)) Or
       FNC_Hora(sHorarioAtendimento_Fim) < FNC_Hora(FNC_StrZero(txtDataAgendamento.DateTime.Hour.ToString(), 2) & ":" & FNC_StrZero(txtDataAgendamento.DateTime.Minute.ToString(), 2)) Then
      FNC_Mensagem("Agendamento fora do horário de atendimento")
      Exit Sub
    End If
    'If iSQ_AGENDAMENTO = 0 Then
    '  If objGrid_Coluna_ProcurarValor(grdHorario,
    '                                  New Object() {const_GridHorario_Paciente, psqPessoa.DS_Pessoa}) <> -1 Then
    '    FNC_Mensagem("Existe outra marcação de horário para essa pessoa, e não é permitido mais de uma marcação de horário no mesmo dia.")
    '    Exit Sub
    '  End If
    'End If
    If Not FNC_In(FNC_NVL(cboStatus.SelectedValue, 0), enOpcoes.StatusAgendamento_Agendado.GetHashCode(),
                                                       enOpcoes.StatusAgendamento_CanceladoClinica.GetHashCode(),
                                                       enOpcoes.StatusAgendamento_CanceladoPaciente.GetHashCode(),
                                                       enOpcoes.StatusAgendamento_Iniciado.GetHashCode()) And
       psqPessoa.ID_Pessoa = 0 Then
      FNC_Mensagem("Para colocar o agendamento no status '" & cboStatus.Text & "', é preciso que a pessoa esteja devidamente cadastrada")
      Exit Sub
    End If

    iCont = Calendario_LinhaHora(FormatDateTime(txtDataAgendamento.Value, DateFormat.ShortTime))

    If iCont = -1 Then
      If DBQuery_ValorUnico("SELECT COUNT(*) FROM dbo.FC_PESSOA_AGENDA_PORDATA(" & cboEmpresa.SelectedValue.ToString() & ", '" & txtDataAgendamento.Text & "', '" & txtDataAgendamento.Text & "')") > 0 Then
        FNC_Mensagem("O horário informado está indisponível")
        Exit Sub
      ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM dbo.FC_PESSOA_AGENDA_PORDATA(" & cboProfissional.SelectedValue & ", '" & txtDataAgendamento.Text & "', '" & txtDataAgendamento.Text & "')") > 0 Then
        FNC_Mensagem("O horário informado está indisponível")
        Exit Sub
      End If
    Else
      If objGrid_Valor(grdHorario, const_GridHorario_SQ_AGENDAMENTO, iCont, -1) <> iSQ_AGENDAMENTO Then
        If Trim(objGrid_Valor(grdHorario, const_GridHorario_Paciente, iCont, "")) <> "" Then
          FNC_Mensagem("O horário informado está indisponível")
          Exit Sub
        End If
      End If
    End If

    Dim bSenhaSupervisor As Boolean = False

    If iSQ_AGENDAMENTO > 0 Then
      If Not FNC_Perguntar("Deseja realmente realizar essa alteração?") Then Exit Sub
      iAcao = enOpcoes.Processo_Acao_Alteracao
    Else
      If GridHorario_QuantidadeAgendamentos(False) >= iQT_LIMITE Then
        If FNC_Perguntar("Atingiu o limite de atendimentos, precisa de senha de supervisor para liberar. Deseja solicitar senha de supervisor?") Then
          bSenhaSupervisor = True
        Else
          Exit Sub
        End If
      ElseIf FNC_NVL(cboConvenio.SelectedItem(enComboBox_Convenio.IC_SENHA_SUPERVISOR), "N") = "S" Then
        bSenhaSupervisor = True
      ElseIf dVL_PROCEDIMENTO = 0 Then
        If Not FNC_Perguntar("Agendamento de cortesia precisam ter aprovação de supervisão. Deseja solicitar senha de supervisor?") Then
          bSenhaSupervisor = True
        Else
          Exit Sub
        End If
      End If
    End If

    If bSenhaSupervisor Then
      If Not FormSEGUsuario_Validacao() Then
        Exit Sub
      End If
    End If

    If IsDate(txtDataChegada.Text) Then
      If dVL_PROCEDIMENTO = 0 Then
        eID_OPT_STATUS = enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode()
      Else
        eID_OPT_STATUS = enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode()
      End If
    Else
      If ComboBox_Selecionado(cboStatus) Then
        eID_OPT_STATUS = cboStatus.SelectedValue
      End If
    End If

    sSqlText = DBMontar_SP("SP_AGENDAMENTO_CAD", False, "@SQ_AGENDAMENTO OUT",
                                                        "@CD_AGENDAMENTO OUT",
                                                        "@ID_EMPRESA",
                                                        "@ID_TIPO_CONSULTA",
                                                        "@ID_AGENDAMENTO_ORIGEM",
                                                        "@ID_PESSOA",
                                                        "@ID_PESSOA_PROFISSIONAL",
                                                        "@ID_PESSOA_EXECUTOR",
                                                        "@ID_ESPECIALIDADE",
                                                        "@ID_CONVENIO",
                                                        "@ID_PROCEDIMENTO",
                                                        "@ID_INDICACAO",
                                                        "@ID_PESSOAINDICADOR",
                                                        "@ID_OPT_STATUS",
                                                        "@ID_CANALMARCACAO",
                                                        "@DH_AGENDAMENTO",
                                                        "@DH_CHEGADA",
                                                        "@DH_SAIDA",
                                                        "@NO_PESSOA",
                                                        "@CD_TELEFONE",
                                                        "@CD_CELULAR",
                                                        "@DS_COMPLEMENTO",
                                                        "@VL_PROCEDIMENTO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO, , ParameterDirection.InputOutput),
                         DBParametro_Montar("CD_AGENDAMENTO", txtCodigo.Text, , ParameterDirection.InputOutput),
                         DBParametro_Montar("ID_EMPRESA", cboEmpresa.SelectedValue),
                         DBParametro_Montar("ID_TIPO_CONSULTA", cboTipoAgendamento.SelectedValue),
                         DBParametro_Montar("ID_AGENDAMENTO_ORIGEM", Nothing),
                         DBParametro_Montar("ID_PESSOA", FNC_NuloZero(psqPessoa.ID_Pessoa, False)),
                         DBParametro_Montar("ID_PESSOA_PROFISSIONAL", cboProfissional.SelectedValue),
                         DBParametro_Montar("ID_PESSOA_EXECUTOR", FNC_NuloZero(psqExecutor.ID_Pessoa, False)),
                         DBParametro_Montar("ID_ESPECIALIDADE", cboEspecialdade.SelectedValue),
                         DBParametro_Montar("ID_CONVENIO", cboConvenio.SelectedValue),
                         DBParametro_Montar("ID_PROCEDIMENTO", FNC_NuloZero(psqProcedimento.Identificador, False)),
                         DBParametro_Montar("ID_INDICACAO", Nothing),
                         DBParametro_Montar("ID_PESSOAINDICADOR", cboIndicador.SelectedValue),
                         DBParametro_Montar("ID_OPT_STATUS", eID_OPT_STATUS),
                         DBParametro_Montar("ID_CANALMARCACAO", cboCanalMarcacao.SelectedValue),
                         DBParametro_Montar("DH_AGENDAMENTO", txtDataAgendamento.Value, SqlDbType.DateTime),
                         DBParametro_Montar("DH_CHEGADA", txtDataChegada.Value, SqlDbType.DateTime),
                         DBParametro_Montar("DH_SAIDA", txtDataSaida.Value, SqlDbType.DateTime),
                         DBParametro_Montar("NO_PESSOA", IIf(psqPessoa.ID_Pessoa = 0, psqPessoa.DS_Pessoa, Nothing)),
                         DBParametro_Montar("CD_TELEFONE", txtTelefone.Text),
                         DBParametro_Montar("CD_CELULAR", txtCelular.Text),
                         DBParametro_Montar("DS_COMPLEMENTO", Trim(txtComplemento.Text), , , const_BancoDados_TamanhoComentario),
                         DBParametro_Montar("VL_PROCEDIMENTO", dVL_PROCEDIMENTO))

    If DBTeveRetorno() Then
      iSQ_AGENDAMENTO = DBRetorno(1)
      txtCodigo.Text = DBRetorno(2)
    End If

    If Not chkAtualizarListagemAutomaticamente.Checked Then
      If Calendario_LinhaHora(Mid(FormatDateTime(txtDataAgendamento.Value, DateFormat.ShortTime), 1, 5)) = -1 Then
        iRowIndex = oDBHorario.Rows.Add().Index
      Else
        iRowIndex = Calendario_LinhaHora(Mid(FormatDateTime(txtDataAgendamento.Value, DateFormat.ShortTime), 1, 5))
      End If

      With grdHorario.Rows(iRowIndex)
        .Cells(const_GridHorario_SQ_AGENDAMENTO).Value = iSQ_AGENDAMENTO
        .Cells(const_GridHorario_ID_PROCEDIMENTO).Value = psqProcedimento.Identificador
        .Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value = cboStatus.SelectedValue
        .Cells(const_GridHorario_ID_PACIENTE).Value = psqPessoa.ID_Pessoa
        .Cells(const_GridHorario_HORA).Value = Mid(FormatDateTime(txtDataAgendamento.Value, DateFormat.ShortTime), 1, 5)
        .Cells(const_GridHorario_Codigo).Value = txtCodigo.Text
        .Cells(const_GridHorario_Paciente).Value = psqPessoa.DS_Pessoa
        .Cells(const_GridHorario_Status).Value = cboStatus.Text
        GridHorario_Smile(iRowIndex)
      End With

      grdHorario.DisplayLayout.Bands(0).SortedColumns.Add(grdHorario.DisplayLayout.Bands(0).Columns(const_GridHorario_HORA), False)
    End If

    FNC_Historico(iAcao)

    Convenio_AtualizarCredito()
    Profissional_Atualizar()

    If dVL_PROCEDIMENTO > 0 Then oVoucher.Salvar(iSQ_AGENDAMENTO, 0, dVL_PROCEDIMENTO)

    LimparTela(chkAtualizarListagemAutomaticamente.Checked)

    FNC_Mensagem("Agendamento efetuado")
  End Sub

  Private Function GridHorario_QuantidadeAgendamentos(bRetorno As Boolean) As Integer
    Dim iCont As Integer
    Dim iQtde As Integer

    For iCont = 0 To grdHorario.Rows.Count - 1
      If objGrid_Valor(grdHorario, const_GridHorario_Codigo, iCont) <> "" Then
        If bRetorno Then
          If objGrid_Valor(grdHorario, const_GridHorario_IC_TIPO_RETORNO, iCont) = "S" Then
            iQtde = iQtde + 1
          End If
        Else
          If objGrid_Valor(grdHorario, const_GridHorario_IC_TIPO_RETORNO, iCont) = "N" Then
            iQtde = iQtde + 1
          End If
        End If
      End If
    Next

    Return iQtde
  End Function

  Private Sub FNC_Historico_Guardar()
    oHistorico.Inicializar()
    oHistorico.Controle_LimparValorAtual()
    oHistorico.Controle_ValorAtual(cboProfissional, cboProfissional.Text)
    oHistorico.Controle_ValorAtual(txtDataAgendamento, txtDataAgendamento.DateTime.ToString())
    oHistorico.Controle_ValorAtual(cboTipoAgendamento, cboTipoAgendamento.Text)
    oHistorico.Controle_ValorAtual(cboStatus, cboStatus.Text)
    oHistorico.Controle_ValorAtual(psqPessoa, psqPessoa.DS_Pessoa)
    oHistorico.Controle_ValorAtual(cboConvenio, cboConvenio.Text)
    oHistorico.Controle_ValorAtual(txtTelefone, txtTelefone.Text)
    oHistorico.Controle_ValorAtual(txtCelular, txtCelular.Text)
    oHistorico.Controle_ValorAtual(psqProcedimento.cboProcedimentoPrincipal, psqProcedimento.cboProcedimentoPrincipal.Text)
    oHistorico.Controle_ValorAtual(txtDataChegada, txtDataChegada.Text)
    oHistorico.Controle_ValorAtual(txtDataSaida, txtDataSaida.Text)
    oHistorico.Controle_ValorAtual(txtCodigo, txtCodigo.Text)
    oHistorico.Controle_ValorAtual(txtComplemento, txtComplemento.Text)
  End Sub

  Private Sub FNC_Historico(iAcao As enOpcoes)
    oHistorico.ID_Registro = iSQ_AGENDAMENTO
    oHistorico.GravarHistorico(enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode,
                               iAcao, 0,
                               txtCodigo.Text, "",
                               New Object() {cboProfissional, "Profissional",
                                             txtDataAgendamento, lblRDataAgendamento.Text,
                                             cboTipoAgendamento, lblRTipoAgendamento.Text,
                                             cboStatus, lblRStatus.Text,
                                             psqPessoa, psqPessoa.Rotulo,
                                             cboConvenio, lblRConvenio.Text,
                                             txtTelefone, lblRTelefone.Text,
                                             txtCelular, lblRCelular.Text,
                                             psqProcedimento.cboProcedimentoPrincipal, "Procedimento",
                                             txtDataChegada, lblRChegada.Text,
                                             txtDataSaida, lblRSaida.Text,
                                             txtCodigo, lblRCodigo.Text,
                                             txtComplemento, lblRComplemento.Text})

    FNC_Historico_Guardar()
  End Sub

  Private Sub grdHorario_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdHorario.DoubleClickRow
    If Agendamento_Validar(FNC_NVL(e.Row.Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0)) Then
      If Trim(FNC_NVL(e.Row.Cells(const_GridHorario_Paciente).Value, "")) <> "" Then
        If FNC_NVL(e.Row.Cells(const_GridHorario_ID_PACIENTE).Value, 0) = 0 Then
          If bUSUARIO_PROFISSIONAL Then
            FNC_Mensagem("É preciso cadastrar a pessoa antes de verificar a ficha de atendimento da mesma")
          Else
            FNC_Mensagem("É preciso cadastrar a pessoa antes de verificar a ficha da mesma")
          End If
        Else
          If bUSUARIO_PROFISSIONAL Then
            Try
              Dim oForm As New frmCadastroAtendimentoClinica

              'oForm.iID_AGENDAMENTO = e.Row.Cells(const_GridHorario_SQ_AGENDAMENTO).Value
              'AddHandler oForm.Agendamento_StatusAtendido, AddressOf Agendamento_StatusAtendido

              FNC_AbriTela(oForm)
            Catch ex As Exception
              FNC_Mensagem("[ERRO] frmLancaAgendamento (Atendimento Médico) - " & ex.Message)
            End Try
          Else
            If FNC_NVL(e.Row.Cells(const_GridHorario_ID_PACIENTE).Value, 0) = 0 Then
              FNC_Mensagem("Paciente não cadastradado")
            Else
              Try
                Dim oForm As New frmCadastroPaciente

                oForm.Hide()
                FNC_AbriTela(oForm)
                oForm.ID_PACIENTE = e.Row.Cells(const_GridHorario_ID_PACIENTE).Value
                oForm.Show()
              Catch ex As Exception
                FNC_Mensagem("[ERRO] frmLancaAgendamento (Cadastro de Paciente) - " & ex.Message)
              End Try
            End If
          End If
        End If
      End If
    End If
  End Sub

  Private Sub Agendamento_StatusAtendido(iID_AGENDAMENTO As Integer)
    Dim iCont As Integer

    For iCont = 0 To grdHorario.Rows.Count - 1
      With grdHorario.Rows(iCont)
        If FNC_NVL(.Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0) = iID_AGENDAMENTO Then
          .Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value = enOpcoes.StatusAgendamento_Atendido.GetHashCode
          .Cells(const_GridHorario_Status).Value = "Atendido"
          Exit For
        End If
      End With
    Next

    FormCadastroAgenda_ColocarCor(grdHorario, const_GridHorario_ID_OPT_TIPOEVENTO)
    FormCadastroAgendamentoAtendimento_ColocarCor(grdHorario, const_GridHorario_ID_OPT_TIPOEVENTO)
  End Sub

  Private Sub grdHorario_ClickCell(sender As Object, e As ClickCellEventArgs) Handles grdHorario.ClickCell
    iSQ_AGENDAMENTO = FNC_NVL(e.Cell.Row.Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0)
    iID_PACIENTE = FNC_NVL(e.Cell.Row.Cells(const_GridHorario_ID_PACIENTE).Value, 0)

    If bAtualizandoGrid Or bInclusaoEdicao Then
      Exit Sub
    End If

    bEmProcessamento = True

    iLinhaSelecionada = e.Cell.Row.Index
    objGrid_RetirarSelecaoLinhas(grdHorario)
    e.Cell.Row.Selected = True

    If Trim(FNC_NVL(e.Cell.Row.Cells(const_GridHorario_Paciente).Value, "")) = "" Then
      bEmProcessamento = True
      txtDataAgendamento.Value = New Date(txtDataAgendamento.DateTime.Year,
                                          txtDataAgendamento.DateTime.Month,
                                          txtDataAgendamento.DateTime.Day,
                                          Val(Mid(e.Cell.Row.Cells(const_GridHorario_HORA).Value, 1, 2)),
                                          Val(Mid(e.Cell.Row.Cells(const_GridHorario_HORA).Value, 4, 2)), 0)
      bEmProcessamento = False
    Else
      LimparTela(False)

      If Agendamento_Validar(FNC_NVL(e.Cell.Row.Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0)) Then
        ComboBox_AgendamentosParaEsseHorario_Carregar()
        iSQ_AGENDAMENTO = FNC_NVL(e.Cell.Row.Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0)

        cmdRetorno.Enabled = (e.Cell.Row.Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value = enOpcoes.StatusAgendamento_Atendido.GetHashCode)
      End If
    End If

    bEmProcessamento = False
  End Sub

  Private Sub ControlarEdicao(bEditar As Boolean)
    Dim bBotoes_Editar As Boolean
    Dim bControles_Editar As Boolean
    Dim bStatus_Editar As Boolean

    If cboStatus.Visible Then
      bBotoes_Editar = (Not FNC_In(FNC_NVL(cboStatus.SelectedValue, 0), enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode(),
                                                                        enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode()))

      bStatus_Editar = (Not FNC_In(FNC_NVL(cboStatus.SelectedValue, 0), enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode(),
                                                                        enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode(),
                                                                        enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode()))

      bControles_Editar = (Not FNC_In(FNC_NVL(cboStatus.SelectedValue, 0), enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode(),
                                                                           enOpcoes.StatusAgendamento_CanceladoClinica.GetHashCode(),
                                                                           enOpcoes.StatusAgendamento_CanceladoPaciente.GetHashCode(),
                                                                           enOpcoes.StatusAgendamento_CanceladoPaciente.GetHashCode(),
                                                                           enOpcoes.StatusAgendamento_Atendido.GetHashCode(),
                                                                           enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode()))
    Else
      bBotoes_Editar = True
      bControles_Editar = True
    End If

    'cboStatus.Enabled = bStatus_Editar
    cboStatus.Enabled = False

    psqPessoa.Enabled = bControles_Editar

    cmdGravar.Enabled = (bBotoes_Editar And bEditar)
    cmdRemarcar.Enabled = bBotoes_Editar
    cmdExcluir.Enabled = bBotoes_Editar
    lblEmEdicao.Visible = bBotoes_Editar
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    LimparTela(True)
  End Sub

  Private Sub LimparTela(Optional bListagemAgendamento_Carregar As Boolean = True)
    iSQ_AGENDAMENTO = 0
    iLinhaSelecionada = -1
    cboAgendamentosParaEsseHorario.DataSource = Nothing
    txtCodigo.Text = ""
    psqPessoa.ID_Pessoa = 0
    psqPessoa.DS_Pessoa = ""
    psqExecutor.ID_Pessoa = 0
    psqExecutor.DS_Pessoa = ""
    'cboTipoAgendamento.SelectedIndex = -1
    'cboConvenio.SelectedIndex = -1
    txtTelefone.Text = ""
    cmdTelefoneWhatsApp.Visible = False
    txtCelular.Text = ""
    cmdCelularWhatsApp.Visible = False
    cboIndicador.DataSource = Nothing
    txtDataChegada.Value = Nothing
    txtDataSaida.Value = Nothing
    txtComplemento.Text = ""
    lblRStatus.Visible = False
    cboStatus.Visible = False
    ComboBox_Selecionar(cboStatus, enOpcoes.StatusAgendamento_Agendado.GetHashCode)
    If bListagemAgendamento_Carregar Then ListagemAgendamento_Carregar(True)
    ControlarEdicao(True)
    psqPessoa.AdicionarPessoa = True
    lblEmEdicao.Visible = False
    lblValorProcedimento.Text = ""
    lblRConvenio.Text = ""
    lblRConvenio.Visible = False
  End Sub

  Private Sub cboProfissional_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProfissional.SelectedIndexChanged
    If Not bEmProcessamento Then
      bEmProcessamento = True
      psqProcedimento.Profissional = FNC_NVL(cboProfissional.SelectedValue, 0)
      ComboBox_Carregar(cboEmpresa, enSql.Empresa_Profissional_Especialidade, New Object() {FNC_NVL(cboEspecialdade.SelectedValue, 0), FNC_NVL(cboProfissional.SelectedValue, 0)})
      bEmProcessamento = False
    End If
  End Sub

  Private Function Calendario_LinhaHora(sHora) As Integer
    Dim iCont As Integer
    Dim iLinha As Integer = -1

    For iCont = 0 To grdHorario.Rows.Count - 1
      If objGrid_Valor(grdHorario, const_GridHorario_HORA, iCont) = sHora Then
        iLinha = iCont
        Exit For
      End If
    Next

    Return iLinha
  End Function

  Private Sub Calendario_LimparLinha()
    Dim iCont As Integer

    For iCont = 0 To grdHorario.Rows.Count - 1
      With grdHorario.Rows(iCont)
        If FNC_NVL(.Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0) <> -1 Then
          Calendario_LimparLinha(iCont)
        End If
      End With
    Next
  End Sub

  Private Sub Calendario_LimparLinha(iLinha As Integer)
    If iLinha >= 0 Then
      grdHorario.Rows(iLinha).Cells(const_GridHorario_SQ_AGENDAMENTO).Value = 0
      grdHorario.Rows(iLinha).Cells(const_GridHorario_ID_PROCEDIMENTO).Value = 0
      grdHorario.Rows(iLinha).Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value = 0
      grdHorario.Rows(iLinha).Cells(const_GridHorario_ID_PACIENTE).Value = 0
      grdHorario.Rows(iLinha).Cells(const_GridHorario_Codigo).Value = ""
      grdHorario.Rows(iLinha).Cells(const_GridHorario_Paciente).Value = ""
      grdHorario.Rows(iLinha).Cells(const_GridHorario_Status).Value = ""
      grdHorario.Rows(iLinha).Appearance.ForeColor = Color.Black
      grdHorario.Rows(iLinha).Appearance.BackColor = Color.White
      GridHorario_Smile(iLinha)
    End If
  End Sub

  Private Sub Calendario_CarregarLinhas()
    Dim sHR_ATENDIMENTO_INICIO As String = sEMPRESA_HR_ATENDIMENTO_INICIO
    Dim sHR_ATENDIMENTO_FIM As String

    If Not ComboBox_Selecionado(cboProfissional) Or Not ComboBox_Selecionado(cboEmpresa) Then Exit Sub

    Dim oData As DataTable
    Dim sSqlText As String

    Dim bIniciar As Boolean
    Dim oRow As UltraWinDataSource.UltraDataRow = Nothing
    Dim oData_Inicio As Date = FNC_Hora(sHR_ATENDIMENTO_INICIO)
    Dim dDT_EVENTO As Date
    Dim dDT_EVENTO_FIM As Date
    Dim iRowIndex As Integer
    Dim sProcedimento As String = ""

    iQT_LIMITE = 0

    If Not oAgendamento_Disponibilidade Is Nothing Then
      If oAgendamento_Disponibilidade.Procedimento <> "" Then
        sProcedimento = oAgendamento_Disponibilidade.Procedimento
      End If

      iQT_LIMITE = iQT_LIMITE + oAgendamento_Disponibilidade.Atendimento_Previsto + oAgendamento_Disponibilidade.Retorno_Previsto
      sHR_ATENDIMENTO_INICIO = oAgendamento_Disponibilidade.HoraInicial
      sHR_ATENDIMENTO_FIM = oAgendamento_Disponibilidade.HoraFim

      If Trim(sHR_ATENDIMENTO_INICIO) = "" Then sHR_ATENDIMENTO_INICIO = sEMPRESA_HR_ATENDIMENTO_INICIO
      If Trim(sHR_ATENDIMENTO_FIM) = "" Then sHR_ATENDIMENTO_FIM = sEMPRESA_HR_ATENDIMENTO_FIM

      If sHorarioAtendimento_Inicio = "" Then sHorarioAtendimento_Inicio = sHR_ATENDIMENTO_INICIO
      If sHorarioAtendimento_Fim = "" Then sHorarioAtendimento_Fim = sHR_ATENDIMENTO_FIM

      oData_Inicio = FNC_Hora(sHR_ATENDIMENTO_INICIO)

      For iCont = 0 To DateDiff(DateInterval.Minute, oData_Inicio, FNC_Hora(sHR_ATENDIMENTO_FIM)) / iEMPRESA_NR_ATENDIMENTO_INTERVALO
        oRow = oDBHorario.Rows.Add()
        oRow.SetCellValue(const_GridHorario_HORA, FormatDateTime(oData_Inicio, DateFormat.ShortTime))
        oData_Inicio = oData_Inicio.AddMinutes(iEMPRESA_NR_ATENDIMENTO_INTERVALO)
      Next
    Else
      If Trim(sProcedimento) = "" Then
        sSqlText = "SELECT HR_INICIO, HR_FIM, ISNULL(QT_ATENDIMENTO, 0) QT_ATENDIMENTO, ISNULL(QT_RETORNO, 0) QT_RETORNO" &
                   " FROM VW_PESSOA_HORARIO" &
                   " WHERE ID_EMPRESA = " & cboEmpresa.SelectedValue &
                     " AND ID_PESSOA = " & cboProfissional.SelectedValue &
                     " AND CD_OPT_DIA_SEMANA = " & (txtDataAgendamento.DateTime.DayOfWeek.GetHashCode() + 1) &
                  "  ORDER BY HR_INICIO"
      Else
        sSqlText = "SELECT DISTINCT PH.HR_INICIO, PH.HR_FIM, ISNULL(QT_ATENDIMENTO, 0) QT_ATENDIMENTO, ISNULL(QT_RETORNO, 0) QT_RETORNO" &
                   " FROM VW_PESSOA_HORARIO PH" &
                    " INNER JOIN TB_PESSOA_HORARIO_PROCEDIMENTO PP ON PP.ID_PESSOA_HORARIO = PH.SQ_PESSOA_HORARIO" &
                      " AND PP.ID_PROCEDIMENTO IN (" & sProcedimento & ")" &
                   " WHERE PH.ID_EMPRESA = " & cboEmpresa.SelectedValue &
                     " AND PH.ID_PESSOA = " & cboProfissional.SelectedValue &
                     " AND PH.CD_OPT_DIA_SEMANA = " & (txtDataAgendamento.DateTime.DayOfWeek.GetHashCode() + 1) &
                  "  ORDER BY PH.HR_INICIO"
      End If
      oData = DBQuery(sSqlText)

      oDBHorario.Rows.Clear()

      If objDataTable_Vazio(oData) Then
        Exit Sub
      Else
        For Each oDataRow As DataRow In oData.Rows
          iQT_LIMITE = iQT_LIMITE + oDataRow.Item("QT_ATENDIMENTO") + oDataRow.Item("QT_RETORNO")

          sHR_ATENDIMENTO_INICIO = oDataRow.Item("HR_INICIO").ToString()
          sHR_ATENDIMENTO_FIM = oDataRow.Item("HR_FIM").ToString()

          If Trim(sHR_ATENDIMENTO_INICIO) = "" Then sHR_ATENDIMENTO_INICIO = sEMPRESA_HR_ATENDIMENTO_INICIO
          If Trim(sHR_ATENDIMENTO_FIM) = "" Then sHR_ATENDIMENTO_FIM = sEMPRESA_HR_ATENDIMENTO_FIM

          If sHorarioAtendimento_Inicio = "" Then sHorarioAtendimento_Inicio = sHR_ATENDIMENTO_INICIO
          If sHorarioAtendimento_Fim = "" Then sHorarioAtendimento_Fim = sHR_ATENDIMENTO_FIM

          If FNC_Hora(sHorarioAtendimento_Inicio) > FNC_Hora(sHR_ATENDIMENTO_INICIO) Then sHorarioAtendimento_Inicio = sHR_ATENDIMENTO_INICIO
          If FNC_Hora(sHorarioAtendimento_Fim) < FNC_Hora(sHR_ATENDIMENTO_FIM) Then sHorarioAtendimento_Fim = sHR_ATENDIMENTO_FIM

          oData_Inicio = FNC_Hora(sHR_ATENDIMENTO_INICIO)

          For iCont = 0 To DateDiff(DateInterval.Minute, oData_Inicio, FNC_Hora(sHR_ATENDIMENTO_FIM)) / iEMPRESA_NR_ATENDIMENTO_INTERVALO
            oRow = oDBHorario.Rows.Add()
            oRow.SetCellValue(const_GridHorario_HORA, FormatDateTime(oData_Inicio, DateFormat.ShortTime))
            oData_Inicio = oData_Inicio.AddMinutes(iEMPRESA_NR_ATENDIMENTO_INTERVALO)
          Next
        Next
      End If
    End If

    sSqlText = "SELECT dbo.FC_EMPRESA_HR_ATENDIMENTO_INICIO(ID_EMPRESA, " & FNC_QuotedStr(txtDataAgendamento.DateTime.Date) & ") DT_EVENTO," +
                      "dbo.FC_EMPRESA_HR_ATENDIMENTO_FIM(ID_EMPRESA, " & FNC_QuotedStr(txtDataAgendamento.DateTime.Date) & ") DT_EVENTO_FIM," +
                      "'N' IC_OCORRE_TODO_ANO_MESMADATA," +
                      "-1 ID_OPT_TIPOEVENTO," +
                      "'Dia não util: ' + dbo.fc_TitleCase(dbo.FC_DIA_SEMANA_EXTENSO(" & FNC_QuotedStr(txtDataAgendamento.DateTime.Date) & ")) DS_EVENTO," +
                      "'Dia não util: ' + dbo.fc_TitleCase(dbo.FC_DIA_SEMANA_EXTENSO(" & FNC_QuotedStr(txtDataAgendamento.DateTime.Date) & ")) NO_OPT_TIPOEVENTO," +
                      "'N' IC_EMPRESA," +
                      "'N' IC_BLOQUEAR_VISUZALIZACAO" +
               " FROM TB_EMPRESA" +
               " WHERE ID_EMPRESA = " + cboEmpresa.SelectedValue.ToString() +
                 " AND dbo.FC_DataUtil(ID_EMPRESA, " & FNC_QuotedStr(txtDataAgendamento.DateTime.Date) & ", 'N') = 'N'"
    oData = DBQuery(sSqlText)

    If oData.Rows.Count = 0 Then
      'Agenda da Empresa e Profissional
      sSqlText = "SELECT *" &
                 " FROM VW_PESSOA_AGENDA_GERAL" &
                 " WHERE ID_EMPRESA = " & cboEmpresa.SelectedValue.ToString() &
                   " AND ID_PESSOA IN (" & IIf(FNC_CampoNulo(cboProfissional.SelectedValue), "", cboProfissional.SelectedValue & ",") _
                                         & cboEmpresa.SelectedValue.ToString() & ")" &
                   " AND ID_TIPO_ITEM Not IN (" & enOpcoes.TipoItemAgendaGeral_Agendamento.GetHashCode & ")" &
                   " AND (((CAST(DT_EVENTO AS DATE) <= " & FNC_QuotedStr(txtDataAgendamento.DateTime.Date) & " AND CAST(DT_EVENTO_FIM AS DATE) >= " & FNC_QuotedStr(txtDataAgendamento.DateTime.Date) & ")) Or " &
                         "(IC_OCORRE_TODO_ANO_MESMADATA = 'S' AND DAY(DT_EVENTO) = " & txtDataAgendamento.DateTime.Day.ToString & " AND MONTH(DT_EVENTO) = " & txtDataAgendamento.DateTime.Month.ToString & "))" &
                   " AND ISNULL(IC_BLOQUEIA_ATENDIMENTO, 'N') = 'S'" &
                 " ORDER BY IC_EMPRESA DESC, DT_EVENTO ASC"
      oData = DBQuery(sSqlText)
    End If

    For iCont_01 = 0 To oData.Rows.Count - 1
      dDT_EVENTO = oData.Rows(iCont_01).Item("DT_EVENTO")
      dDT_EVENTO_FIM = oData.Rows(iCont_01).Item("DT_EVENTO_FIM")

      If Calendario_LinhaHora(Mid(FormatDateTime(dDT_EVENTO, DateFormat.ShortTime), 1, 5)) = -1 Then
        iRowIndex = oDBHorario.Rows.Add().Index

        Calendario_LimparLinha(iRowIndex)

        With grdHorario.Rows(iRowIndex)
          .Cells(const_GridHorario_SQ_AGENDAMENTO).Value = 0
          .Cells(const_GridHorario_HORA).Value = Mid(FormatDateTime(dDT_EVENTO, DateFormat.ShortTime), 1, 5)
          GridHorario_Smile(iRowIndex)
        End With

        grdHorario.DisplayLayout.Bands(0).SortedColumns.Add(grdHorario.DisplayLayout.Bands(0).Columns(const_GridHorario_HORA), False)
      End If

      If oData.Rows(iCont_01).Item("IC_OCORRE_TODO_ANO_MESMADATA") = "S" Then
        dDT_EVENTO = dDT_EVENTO.AddYears(Now.Year - dDT_EVENTO.Year)
        dDT_EVENTO_FIM = dDT_EVENTO_FIM.AddYears(Now.Year - dDT_EVENTO_FIM.Year)
      End If

      For iCont_02 = 0 To grdHorario.Rows.Count - 1
        With grdHorario.Rows(iCont_02)
          If Not bIniciar Then
            If dDT_EVENTO < txtDataAgendamento.DateTime Then
              bIniciar = True
            Else
              If FNC_Hora(.Cells(const_GridHorario_HORA).Text, txtDataAgendamento.DateTime.Date) = dDT_EVENTO Then
                bIniciar = True
              End If
            End If
          End If

          If bIniciar Then
            If FNC_Hora(.Cells(const_GridHorario_HORA).Text, txtDataAgendamento.DateTime.Date) > dDT_EVENTO_FIM Then
              bIniciar = False
              Exit For
            End If

            bEmProcessamento = True
            If FNC_NVL(.Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0) <> -1 Then
              .Cells(const_GridHorario_SQ_AGENDAMENTO).Value = -1
              .Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value = oData.Rows(iCont_01).Item("ID_OPT_TIPOEVENTO")
              If oData.Rows(iCont_01).Item("ID_OPT_TIPOEVENTO") = -1 Then
                .Cells(const_GridHorario_Paciente).Value = "Indisponível"
                .Cells(const_GridHorario_Status).Value = oData.Rows(iCont_01).Item("NO_OPT_TIPOEVENTO")
              ElseIf oData.Rows(iCont_01).Item("IC_EMPRESA") = "S" Then
                .Cells(const_GridHorario_Paciente).Value = "Ag. Empresa: " & oData.Rows(iCont_01).Item("DS_EVENTO")
              Else
                If FNC_NVL(oData.Rows(iCont_01).Item("IC_BLOQUEAR_VISUZALIZACAO"), "N") = "S" Then
                  .Cells(const_GridHorario_Paciente).Value = "Visualização Bloqueada"
                Else
                  .Cells(const_GridHorario_Paciente).Value = "Ag. Profissional: " & oData.Rows(iCont_01).Item("DS_EVENTO")
                End If
              End If
              .Cells(const_GridHorario_Status).Value = oData.Rows(iCont_01).Item("NO_OPT_TIPOEVENTO")
            End If
            bEmProcessamento = False
          End If
        End With
      Next
    Next

    FormCadastroAgenda_ColocarCor(grdHorario, const_GridHorario_ID_OPT_TIPOEVENTO)
  End Sub

  Private Sub ListagemAgendamento_ProximoHorarioVazio()
    Dim iCont As Integer

    bEmProcessamento = True

    For iCont = 0 To grdHorario.Rows.Count - 1
      grdHorario.Rows(iCont).Selected = False
    Next

    For iCont = 0 To grdHorario.Rows.Count - 1
      If Trim(grdHorario.Rows(iCont).Cells(const_GridHorario_Paciente).Text) = "" Then
        LimparTela(False)
        txtDataAgendamento.Value = New Date(txtDataAgendamento.DateTime.Year,
                                            txtDataAgendamento.DateTime.Month,
                                            txtDataAgendamento.DateTime.Day,
                                            Val(Mid(grdHorario.Rows(iCont).Cells(const_GridHorario_HORA).Value, 1, 2)),
                                            Val(Mid(grdHorario.Rows(iCont).Cells(const_GridHorario_HORA).Value, 4, 2)), 0)
        grdHorario.Rows(iCont).Selected = True
        Exit For
      End If
    Next

    bEmProcessamento = False
  End Sub

  Private Sub ListagemAgendamento_Carregar(Optional bProximoHorarioVazio As Boolean = True)
    Dim oData As DataTable
    Dim sSqlText As String
    Dim sHora As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim iLinhaSelecionada As Integer
    Dim bAchou As Boolean
    Dim oRow As UltraWinDataSource.UltraDataRow = Nothing

    bAtualizandoGrid = True

    If grdHorario.Selected.Rows.Count > 0 Then
      iLinhaSelecionada = grdHorario.Selected.Rows(0).Index
    End If

    Calendario_LimparLinha()

    'Carregar agendamentos cadastrados
    If ComboBox_Selecionado(cboProfissional) And IsDate(txtDataAgendamento.Value) Then
      sSqlText = "SELECT AG.SQ_AGENDAMENTO, " &
                        "AG.ID_PROCEDIMENTO," &
                        "AG.ID_OPT_STATUS, " &
                        "AG.ID_PESSOA ID_PACIENTE," &
                        "AG.CD_AGENDAMENTO, " &
                        "ISNULL(PS.NO_PESSOA, AG.NO_PESSOA) NO_PACIENTE," &
                        "DH_AGENDAMENTO," &
                        "OP.NO_OPCAO NO_OPT_STATUS," &
                        "TC.IC_TIPO_RETORNO" &
                 " FROM TB_AGENDAMENTO AG" &
                  " LEFT JOIN TB_PESSOA PS ON PS.SQ_PESSOA = AG.ID_PESSOA" &
                  " LEFT JOIN TB_OPCAO OP ON OP.SQ_OPCAO = AG.ID_OPT_STATUS" &
                  " LEFT JOIN TB_TIPO_CONSULTA TC ON TC.SQ_TIPO_CONSULTA = AG.ID_TIPO_CONSULTA" &
                 " WHERE AG.ID_EMPRESA = " & cboEmpresa.SelectedValue.ToString() &
                   " AND AG.ID_OPT_STATUS NOT IN(" & enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode() & "," &
                                                     enOpcoes.StatusAgendamento_Sistema_Excluido.GetHashCode() & "," &
                                                     enOpcoes.StatusAgendamento_CanceladoClinica.GetHashCode() & "," &
                                                     enOpcoes.StatusAgendamento_CanceladoPaciente.GetHashCode() & ")" &
                   " AND AG.ID_PESSOA_PROFISSIONAL = " & cboProfissional.SelectedValue &
                   " AND AG.DH_AGENDAMENTO >= " & FNC_QuotedStr(FNC_Hora(sHorarioAtendimento_Inicio, txtDataAgendamento.DateTime.Date)) &
                   " AND AG.DH_AGENDAMENTO <= " & FNC_QuotedStr(FNC_Hora(sHorarioAtendimento_Fim, txtDataAgendamento.DateTime.Date)) &
                 " ORDER BY AG.DH_AGENDAMENTO"
      oData = DBQuery(sSqlText, oConexaoLocal)

      For iCont_01 = 0 To oData.Rows.Count - 1
        bAchou = False

        For iCont_02 = 0 To grdHorario.Rows.Count - 1
          With oData.Rows(iCont_01)
            sHora = FNC_StrZero(Hour(.Item("DH_AGENDAMENTO")), 2) & ":" & FNC_StrZero(Minute(.Item("DH_AGENDAMENTO")), 2)

            If grdHorario.Rows(iCont_02).Cells(const_GridHorario_HORA).Value = sHora Then
              bAchou = True

              If FNC_NVL(grdHorario.Rows(iCont_02).Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0) <> -1 Then
                grdHorario.Rows(iCont_02).Cells(const_GridHorario_SQ_AGENDAMENTO).Value = .Item("SQ_AGENDAMENTO")
                grdHorario.Rows(iCont_02).Cells(const_GridHorario_ID_PROCEDIMENTO).Value = .Item("ID_PROCEDIMENTO")
                grdHorario.Rows(iCont_02).Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value = .Item("ID_OPT_STATUS")
                grdHorario.Rows(iCont_02).Cells(const_GridHorario_ID_PACIENTE).Value = .Item("ID_PACIENTE")
                grdHorario.Rows(iCont_02).Cells(const_GridHorario_Codigo).Value = .Item("CD_AGENDAMENTO")
                grdHorario.Rows(iCont_02).Cells(const_GridHorario_Paciente).Value = .Item("NO_PACIENTE")
                grdHorario.Rows(iCont_02).Cells(const_GridHorario_Status).Value = .Item("NO_OPT_STATUS")
                grdHorario.Rows(iCont_02).Cells(const_GridHorario_IC_TIPO_RETORNO).Value = .Item("IC_TIPO_RETORNO")
              End If

              GridHorario_Smile(iCont_02)

              Exit For
            End If
          End With
        Next

        If Not bAchou Then
          oRow = oDBHorario.Rows.Add()

          With oData.Rows(iCont_01)
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_SQ_AGENDAMENTO).Value = .Item("SQ_AGENDAMENTO")
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_ID_PROCEDIMENTO).Value = .Item("ID_PROCEDIMENTO")
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value = .Item("ID_OPT_STATUS")
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_ID_PACIENTE).Value = .Item("ID_PACIENTE")
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_HORA).Value = Mid(FormatDateTime(.Item("DH_AGENDAMENTO"), DateFormat.ShortTime), 1, 5)
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_Codigo).Value = .Item("CD_AGENDAMENTO")
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_Paciente).Value = .Item("NO_PACIENTE")
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_Status).Value = .Item("NO_OPT_STATUS")
            grdHorario.Rows(oRow.Index).Cells(const_GridHorario_IC_TIPO_RETORNO).Value = .Item("IC_TIPO_RETORNO")
            GridHorario_Smile(oRow.Index)
          End With
        End If
      Next

      If bProximoHorarioVazio Then ListagemAgendamento_ProximoHorarioVazio()

      If iLinhaSelecionada > 0 Then
        objGrid_RetirarSelecaoLinhas(grdHorario)
        grdHorario.Rows(iLinhaSelecionada).Selected = True
      End If
    End If

    FormCadastroAgendamentoAtendimento_ColocarCor(grdHorario, const_GridHorario_ID_OPT_TIPOEVENTO)

    grdHorario.DisplayLayout.Bands(0).SortedColumns.Add(grdHorario.DisplayLayout.Bands(0).Columns(const_GridHorario_HORA), False)

    bAtualizandoGrid = False
  End Sub

  Private Sub txtDataAgendamento_LostFocus(sender As Object, e As EventArgs) Handles txtDataAgendamento.LostFocus
    txtDataAgendamento.Tag = txtDataAgendamento.Value
  End Sub

  Private Sub txtDataAgendamento_ValueChanged(sender As Object, e As EventArgs) Handles txtDataAgendamento.ValueChanged
    Dim dData As Date

    If bEmProcessamento Then Exit Sub

    dData = txtDataAgendamento.Tag

    If dData.Date <> txtDataAgendamento.DateTime.Date Then
      CarregarLinhas()
    End If
  End Sub

  Private Sub CarregarLinhas()
    CarregarProfissional()
    Calendario_CarregarLinhas()
    ListagemAgendamento_Carregar()
  End Sub


  Private Function AGENDAMENTO_Status(iSQ_AGENDAMENTO As Integer) As Integer
    Dim iCont As Integer
    Dim iID_OPT_STATUS As Integer = 0

    For iCont = 0 To grdHorario.Rows.Count - 1
      If iSQ_AGENDAMENTO = FNC_NVL(grdHorario.Rows(iCont).Cells(const_GridHorario_SQ_AGENDAMENTO).Value, 0) Then
        iID_OPT_STATUS = FNC_NVL(grdHorario.Rows(iCont).Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value, 0)
        Exit For
      End If
    Next

    Return iID_OPT_STATUS
  End Function

  Private Sub CarregarDadosAgendamento()
    Dim oData As DataTable
    Dim sSqlText As String

    If iSQ_AGENDAMENTO = -1 Or bInclusaoEdicao Then Exit Sub

    bEmProcessamento = True

    sSqlText = "SELECT AGD.*, AGD.ID_INDICACAO, PTT.IC_WHATSAPP IC_WHATSAPP_TELEFONE, PTC.IC_WHATSAPP IC_WHATSAPP_CELULAR" +
               " FROM TB_AGENDAMENTO AGD" +
                " LEFT JOIN TB_PESSOA_EMPRESA PEM ON PEM.ID_PESSOA = AGD.ID_PESSOA" +
                                               " AND PEM.ID_EMPRESA = AGD.ID_EMPRESA" +
                " LEFT JOIN TB_PESSOA_TELEFONE PTT ON PTT.ID_PESSOA = PEM.ID_PESSOA" +
                                                " AND dbo.FC_SoNumero(PTT.CD_NUMERO) = dbo.FC_SoNumero(AGD.CD_TELEFONE)" +
                " LEFT JOIN TB_PESSOA_TELEFONE PTC ON PTC.ID_PESSOA = PEM.ID_PESSOA" +
                                                " AND dbo.FC_SoNumero(PTC.CD_NUMERO) = dbo.FC_SoNumero(AGD.CD_CELULAR)" +
               " WHERE AGD.SQ_AGENDAMENTO =  " & iSQ_AGENDAMENTO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      txtCodigo.Text = .Item("CD_AGENDAMENTO")
      If objDataTable_CampoVazio(.Item("ID_PESSOA")) Then
        psqPessoa.ID_Pessoa = 0
        psqPessoa.DS_Pessoa = .Item("NO_PESSOA")
      Else
        psqPessoa.ID_Pessoa = .Item("ID_PESSOA")
      End If
      psqPessoa.AdicionarPessoa = (psqPessoa.ID_Pessoa = 0)
      psqExecutor.ID_Pessoa = FNC_NVL(.Item("ID_PESSOA_EXECUTOR"), 0)
      ComboBox_Selecionar(cboTipoAgendamento, .Item("ID_TIPO_CONSULTA"))
      ComboBox_Selecionar(cboConvenio, .Item("ID_CONVENIO"))

      If .Item("ID_OPT_STATUS") = enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode() Then
        ComboBox_Carregar(cboStatus, enSql.StatusAgendamento_Sistema)
      Else
        ComboBox_Carregar(cboStatus, enSql.StatusAgendamento)
      End If

      ComboBox_Selecionar(cboStatus, .Item("ID_OPT_STATUS"))
      If Not FNC_CampoNulo(.Item("ID_PROCEDIMENTO")) Then
        psqProcedimento.Identificador = .Item("ID_PROCEDIMENTO")
      End If
      If FNC_CampoNulo(.Item("DH_CHEGADA")) Then txtDataChegada.Value = Nothing Else txtDataChegada.Value = .Item("DH_CHEGADA")
      If FNC_CampoNulo(.Item("DH_SAIDA")) Then txtDataSaida.Value = Nothing Else txtDataSaida.Value = .Item("DH_SAIDA")
      If FNC_CampoNulo(.Item("CD_CELULAR")) Then txtCelular.Text = "" Else txtCelular.Text = .Item("CD_CELULAR")
      cmdCelularWhatsApp.Visible = (FNC_NVL(.Item("IC_WHATSAPP_CELULAR"), "N") = "S")
      If FNC_CampoNulo(.Item("CD_TELEFONE")) Then txtTelefone.Text = "" Else txtTelefone.Text = .Item("CD_TELEFONE")
      cmdTelefoneWhatsApp.Visible = (FNC_NVL(.Item("IC_WHATSAPP_TELEFONE"), "N") = "S")
      txtComplemento.Text = FNC_NVL(.Item("DS_COMPLEMENTO"), "")
      ComboBox_CarregarIndicador(cboIndicador, psqPessoa.ID_Pessoa)
      ComboBox_Selecionar(cboIndicador, .Item("ID_PESSOAINDICADOR"))

      ControlarEdicao(Not FNC_In(.Item("ID_OPT_STATUS"), enOpcoes.StatusAgendamento_Atendido, enOpcoes.StatusAgendamento_AguardandoAtendimento))
    End With

    FNC_Historico_Guardar()

    lblRStatus.Visible = True
    cboStatus.Visible = True

    bEmProcessamento = False
  End Sub

  Private Sub CarregarDadosPaciente()
    txtTelefone.Text = ""
    txtCelular.Text = ""

    If psqPessoa.ID_Pessoa > 0 Then
      Dim oData As DataTable
      Dim sSqlText As String
      Dim iCont As Integer

      If psqPessoa.ID_Pessoa > 0 Then
        sSqlText = "SELECT ID_CONVENIO FROM TB_PESSOA_CONVENIO WHERE ID_PESSOA = " & psqPessoa.ID_Pessoa
        oData = DBQuery(sSqlText)

        If Not objDataTable_Vazio(oData) Then
          ComboBox_Selecionar(cboConvenio, oData.Rows(0).Item("ID_CONVENIO"))
        End If

        'Carregar Telefone
        sSqlText = "SELECT * FROM TB_PESSOA_TELEFONE" &
                   " WHERE ID_PESSOA = " & psqPessoa.ID_Pessoa &
                   " ORDER BY SQ_PESSOA_TELEFONE"
        oData = DBQuery(sSqlText)

        For iCont = 0 To oData.Rows.Count - 1
          With oData.Rows(iCont)
            Select Case .Item("ID_TIPO_TELEFONE")
              Case enTipoTelefone.Residencial.GetHashCode,
                   enTipoTelefone.Recado.GetHashCode,
                   enTipoTelefone.Comercial.GetHashCode
                If Trim(FNC_SoNumero(txtTelefone.Text)) = "" Then
                  txtTelefone.Text = .Item("CD_NUMERO")
                  cmdTelefoneWhatsApp.Visible = (FNC_NVL(.Item("IC_WHATSAPP"), "N") = "S")
                End If
              Case enTipoTelefone.Celular.GetHashCode
                If Trim(FNC_SoNumero(txtCelular.Text)) = "" Then
                  txtCelular.Text = .Item("CD_NUMERO")
                  cmdCelularWhatsApp.Visible = (FNC_NVL(.Item("IC_WHATSAPP"), "N") = "S")
                End If
            End Select
          End With

          If Trim(FNC_SoNumero(txtCelular.Text)) <> "" And Trim(FNC_SoNumero(txtCelular.Text)) <> "" Then
            Exit For
          End If
        Next

        ComboBox_CarregarIndicador(cboIndicador, psqPessoa.ID_Pessoa)
      End If

      CarregarInformacoes(psqPessoa.ID_Pessoa)
    End If
  End Sub

  Private Sub cmdDataChegada_Click(sender As Object, e As EventArgs) Handles cmdDataChegada.Click
    If psqPessoa.ID_Pessoa = 0 Then
      FNC_Mensagem("É preciso cadastrar a pessoa antes de informar a chegada da mesma")
    Else
      txtDataChegada.Value = Now()

      If iSQ_AGENDAMENTO > 0 Then
        FormCadastroAgendamento_AlterarStatus(iSQ_AGENDAMENTO, enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode, txtDataChegada.Value)
        bEmProcessamento = True
        ComboBox_Selecionar(cboStatus, enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode)
        bEmProcessamento = False

        Atualizar()
      End If
    End If
  End Sub

  Private Sub cmdDataSaida_Click(sender As Object, e As EventArgs) Handles cmdDataSaida.Click
    txtDataSaida.Value = Now()
  End Sub

  Private Sub cmdAtualizar_Click(sender As Object, e As EventArgs) Handles cmdAtualizar.Click
    Atualizar()
  End Sub

  Private Sub Atualizar()
    ListagemAgendamento_Carregar(True)
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    If Agendamento_Validar() Then
      If iSQ_AGENDAMENTO = 0 Then
        FNC_Mensagem("É necessário selecionar o agendamento a ser excluído")
      Else
        If FormCadastroAgendamento_Excluir(iSQ_AGENDAMENTO) Then
          FNC_Historico(enOpcoes.Processo_Acao_Exclusao)
          LimparTela()
          Calendario_LimparLinha(iLinhaSelecionada)
        End If
      End If
    End If
  End Sub

  Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
    If Not bEmProcessamento And iSQ_AGENDAMENTO > 0 And ComboBox_Selecionado(cboStatus) Then
      If FNC_In(cboStatus.SelectedValue, enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode(),
                                         enOpcoes.StatusAgendamento_Atendido.GetHashCode(),
                                         enOpcoes.StatusAgendamento_Iniciado.GetHashCode()) And
         psqPessoa.ID_Pessoa = 0 Then
        bEmProcessamento = True
        ComboBox_Selecionar(cboStatus, grdHorario.Rows(iLinhaSelecionada).Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value)
        bEmProcessamento = False
        FNC_Mensagem("É preciso cadastrar a pessoa antes de informar a chegada da mesma")
        Exit Sub
      End If
      FormCadastroAgendamento_AlterarStatus(iSQ_AGENDAMENTO, cboStatus.SelectedValue, Nothing)
      ListagemAgendamento_Carregar(False)
    End If
  End Sub

  Private Function Agendamento_Validar(Optional iSQ_AGENDAMENTO_int As Integer = -2) As Boolean
    Dim bOk As Boolean = True

    If iSQ_AGENDAMENTO_int = -2 Then
      iSQ_AGENDAMENTO_int = iSQ_AGENDAMENTO
    End If

    If iSQ_AGENDAMENTO_int = -1 Then
      FNC_Mensagem("Não é permitido alterar informações de agenda de profisional ou empresa por essa tela")
      bOk = False
    End If

    Return bOk
  End Function

  Private Sub cmdRetorno_Click(sender As Object, e As EventArgs) Handles cmdRetorno.Click
    If iSQ_AGENDAMENTO = 0 Then
      FNC_Mensagem("É necessário selecionar o agendamento para cadastrar o retorno")
    Else
      If objGrid_Valor(grdHorario, const_GridHorario_ID_OPT_TIPOEVENTO, iLinhaSelecionada) = enOpcoes.StatusAgendamento_Atendido.GetHashCode Then
        Dim oForm As New frmCadastroAgendamento_ProfissionalData

        AddHandler oForm.GravacaoEfetuada, AddressOf LancaAgendamento_ProfissionalData_GravacaoEfetuada
        oForm.iSQ_AGENDAMENTO = iSQ_AGENDAMENTO
        oForm.iID_PROFISSIONAL = cboProfissional.SelectedValue
        oForm.dDataAgendamento = txtDataAgendamento.DateTime
        oForm.eTipoAlteracao = frmCadastroAgendamento_ProfissionalData.enTipoAlteracao.Retorno

        FNC_AbriTela(oForm, , True, True)
      Else
        FNC_Mensagem("É preciso o agendamendo ter sido atendimento para que seja marcado o retorno")
      End If
    End If
  End Sub

  Private Sub cmdRemarcar_Click(sender As Object, e As EventArgs) Handles cmdRemarcar.Click
    If iSQ_AGENDAMENTO = 0 Then
      FNC_Mensagem("É necessário selecionar o agendamento que será remarcado")
    Else
      If objGrid_Valor(grdHorario, const_GridHorario_ID_OPT_TIPOEVENTO, iLinhaSelecionada) = enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode Or
         objGrid_Valor(grdHorario, const_GridHorario_ID_OPT_TIPOEVENTO, iLinhaSelecionada) = enOpcoes.StatusAgendamento_Agendado.GetHashCode Or
         objGrid_Valor(grdHorario, const_GridHorario_ID_OPT_TIPOEVENTO, iLinhaSelecionada) = enOpcoes.StatusAgendamento_Confirmado.GetHashCode Then
        Dim oForm As New frmCadastroAgendamento_ProfissionalData

        AddHandler oForm.GravacaoEfetuada, AddressOf LancaAgendamento_ProfissionalData_GravacaoEfetuada
        oForm.iSQ_AGENDAMENTO = iSQ_AGENDAMENTO
        oForm.iID_PROFISSIONAL = cboProfissional.SelectedValue
        oForm.dDataAgendamento = txtDataAgendamento.DateTime
        oForm.eTipoAlteracao = frmCadastroAgendamento_ProfissionalData.enTipoAlteracao.Remarcacao

        FNC_AbriTela(oForm, , True, True)

        If oForm.bGravado Then ListagemAgendamento_Carregar(True)
      Else
        FNC_Mensagem("Somente agendamento com o status ""Agendado"" e ""Remarcado"" pode ser remarcado")
      End If
    End If
  End Sub

  Private Sub LancaAgendamento_ProfissionalData_GravacaoEfetuada()
    ListagemAgendamento_Carregar(True)
  End Sub

  Private Sub GridHorario_Smile(iLinha As Integer)
    Select Case FNC_NVL(grdHorario.Rows(iLinha).Cells(const_GridHorario_ID_OPT_TIPOEVENTO).Value, 0)
      Case enOpcoes.StatusAgendamento_Agendado.GetHashCode,
           enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode
        If FNC_Hora(grdHorario.Rows(iLinha).Cells(const_GridHorario_HORA).Value, txtDataAgendamento.Value) < Now Then
          grdHorario.Rows(iLinha).Cells(const_GridHorario_Smile).Appearance.Image = imlSmile.Images(const_Smile_Atrasado)
        Else
          grdHorario.Rows(iLinha).Cells(const_GridHorario_Smile).Appearance.Image = imlSmile.Images(const_Smile_Agendado)
        End If
      Case enOpcoes.StatusAgendamento_Atendido.GetHashCode
        grdHorario.Rows(iLinha).Cells(const_GridHorario_Smile).Appearance.Image = imlSmile.Images(const_Smile_Atendido)
      Case enOpcoes.StatusAgendamento_CanceladoPaciente.GetHashCode,
           enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode
        grdHorario.Rows(iLinha).Cells(const_GridHorario_Smile).Appearance.Image = imlSmile.Images(const_Smile_Cancelado)
      Case enOpcoes.StatusAgendamento_CanceladoClinica.GetHashCode
        grdHorario.Rows(iLinha).Cells(const_GridHorario_Smile).Appearance.Image = imlSmile.Images(const_Smile_CanceladoClinica)
      Case enOpcoes.StatusAgendamento_Sistema_ConsultaGerada.GetHashCode,
           enOpcoes.StatusAgendamento_Iniciado.GetHashCode
        grdHorario.Rows(iLinha).Cells(const_GridHorario_Smile).Appearance.Image = imlSmile.Images(const_Smile_Compareceu)
      Case Else
        grdHorario.Rows(iLinha).Cells(const_GridHorario_Smile).Appearance.Image = Nothing
    End Select
  End Sub

  Private Sub grdHorario_InitializeRow(sender As Object, e As InitializeRowEventArgs) Handles grdHorario.InitializeRow
    e.Row.Height = 22
  End Sub

  Private Sub chkAtualizarListagemAutomaticamente_CheckedChanged(sender As Object, e As EventArgs) Handles chkAtualizarListagemAutomaticamente.CheckedChanged
    If Not bEmProcessamento Then
      bUSUARIO_IC_ATUALIZAR_AGENDA_AUTOMATICO = chkAtualizarListagemAutomaticamente.Checked

      FNC_UsuarioConfiguracao_AtualizarAgendaAutomatico(bUSUARIO_IC_ATUALIZAR_AGENDA_AUTOMATICO)
    End If

    Timer1.Enabled = bUSUARIO_IC_ATUALIZAR_AGENDA_AUTOMATICO
  End Sub

  Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    Dim iSQ_AGENDAMENTO_Temp As Integer = iSQ_AGENDAMENTO

    ListagemAgendamento_Carregar(False)

    iSQ_AGENDAMENTO = iSQ_AGENDAMENTO_Temp
  End Sub

  Private Sub psqPessoa_SelectedIndexChanged() Handles psqPessoa.SelectedIndexChanged
    If Not bEmProcessamento Then
      CarregarDadosPaciente()
    End If
  End Sub

  Private Sub psqPessoa_Adicionando() Handles psqPessoa.Adicionando
    If psqPessoa.ID_Pessoa = 0 Then
      psqPessoa.NO_PESSOA = psqPessoa.DS_Pessoa
      psqPessoa.sCD_TELEFONE = txtTelefone.Text
      psqPessoa.sCD_CELULAR = txtCelular.Text
    Else
      psqPessoa.NO_PESSOA = ""
      psqPessoa.sCD_TELEFONE = ""
      psqPessoa.sCD_CELULAR = ""
    End If
  End Sub

  Private Sub psqPessoa_Adicionado() Handles psqPessoa.Adicionado
    If iLinhaSelecionada > -1 Then
      With grdHorario.Rows(iLinhaSelecionada)
        .Cells(const_GridHorario_ID_PACIENTE).Value = psqPessoa.ID_Pessoa
        .Cells(const_GridHorario_Paciente).Value = psqPessoa.DS_Pessoa
        psqPessoa.AdicionarPessoa = False
      End With
    End If
  End Sub

  Private Sub ComboBox_AgendamentosParaEsseHorario_Carregar()
    Dim sSqlText As String

    sSqlText = "SELECT AG.SQ_AGENDAMENTO, " &
                      "ISNULL(PE.NO_PESSOA, AG.NO_PESSOA) NO_PACIENTE" &
               " FROM TB_AGENDAMENTO AG" &
                " INNER JOIN TB_AGENDAMENTO AB ON AB.ID_PESSOA_PROFISSIONAL = AG.ID_PESSOA_PROFISSIONAL" &
                                            " And AB.DH_AGENDAMENTO = AG.DH_AGENDAMENTO" &
                                            " And AB.SQ_AGENDAMENTO = " & iSQ_AGENDAMENTO &
                 " LEFT JOIN TB_PESSOA PE ON PE.SQ_PESSOA = AG.ID_PESSOA" &
                 " LEFT JOIN TB_OPCAO OP ON OP.SQ_OPCAO = AG.ID_OPT_STATUS"

    If ComboBox_Selecionado(cboEmpresa) Then
      sSqlText = sSqlText &
               " WHERE AG.ID_EMPRESA = " & cboEmpresa.SelectedValue.ToString()
    End If
    sSqlText = sSqlText &
               " ORDER BY AG.DH_AGENDAMENTO"
    DBComboBox_Carregar(cboAgendamentosParaEsseHorario, sSqlText)

    lblRAgendamentosParaEsseHorario.Text = lblRAgendamentosParaEsseHorario.Tag & " " & cboAgendamentosParaEsseHorario.Items.Count

    ComboBox_Selecionar(cboAgendamentosParaEsseHorario, iSQ_AGENDAMENTO)
  End Sub

  Private Sub cboAgendamentosParaEsseHorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAgendamentosParaEsseHorario.SelectedIndexChanged
    If ComboBox_Selecionado(cboAgendamentosParaEsseHorario) Then
      iSQ_AGENDAMENTO = cboAgendamentosParaEsseHorario.SelectedValue
      CarregarDadosAgendamento()
    End If
  End Sub

  Private Sub cmdHistorico_Click(sender As Object, e As EventArgs) Handles cmdHistorico.Click
    If iSQ_AGENDAMENTO = 0 Then
      FNC_Mensagem("Selecione o agendamento para o qual deseja ver o histórico")
    Else
      Dim oForm As New frmConsultaHistorico_Registro

      oForm.iProcessso = enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode()
      oForm.iID_REGISTRO = iSQ_AGENDAMENTO
      FNC_AbriTela(oForm, , True, True)
    End If
  End Sub

  Private Sub CarregarInformacoes(iID_PACIENTE As Integer)
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    lblInformacoes.Text = ""

    sSqlText = "SELECT TOP 3 CD_AGENDAMENTO, DH_AGENDAMENTO" +
               " FROM VW_AGENDAMENTO" +
               " WHERE ID_PESSOA = " + iID_PACIENTE.ToString() +
                 " And CAST(DH_AGENDAMENTO AS DATE) > CAST(GETDATE() AS DATE)" +
               " ORDER BY DH_AGENDAMENTO"
    oData = DBQuery(sSqlText)

    If oData.Rows.Count > 0 Then lblInformacoes.Text = "Os 3 mais recente agendamentos futuros desse paciente"

    For iCont = 0 To oData.Rows.Count - 1
      With oData.Rows(iCont)
        lblInformacoes.Text = lblInformacoes.Text + Environment.NewLine() +
                                                    .Item("CD_AGENDAMENTO") + " " + .Item("DH_AGENDAMENTO").ToString()
      End With
    Next
  End Sub

  Private Sub frmLancaAgendamento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    Try
      oConexaoLocal.Close()
      oConexaoLocal.Dispose()
    Catch ex As Exception
    End Try
  End Sub

  Private Sub CmdTelefoneWhatsApp_Click(sender As Object, e As EventArgs) Handles cmdTelefoneWhatsApp.Click
    FNC_WhatsApp(txtTelefone.Text)
  End Sub

  Private Sub CmdCelularWhatsApp_Click(sender As Object, e As EventArgs) Handles cmdCelularWhatsApp.Click
    FNC_WhatsApp(txtCelular.Text)
  End Sub

  Private Sub cboEspecialdade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEspecialdade.SelectedIndexChanged
    If Not bEmProcessamento Then CarregarProfissional()
  End Sub

  Private Sub CarregarProfissional()
    If Not bEmProcessamento Then
      Dim iID_PROFISSIONAL As Integer

      bEmProcessamento = True
      iID_PROFISSIONAL = FNC_NVL(cboProfissional.SelectedValue, 0)
      ComboBox_Carregar(cboProfissional, enSql.Especilidade_Profissional, New Object() {FNC_NVL(cboEspecialdade.SelectedValue, 0)})
      If iID_PROFISSIONAL > 0 Then ComboBox_Selecionar(cboProfissional, iID_PROFISSIONAL)
      bEmProcessamento = False
    End If
  End Sub

  Private Sub Profissional_Atualizar()
    Exit Sub
    bEmProcessamento = True

    Dim iID_PESSOA_PROFISSIONAL As Integer = FNC_NuloZero(cboProfissional.SelectedValue)

    ComboBox_Carregar(cboProfissional, enSql.Profissional_Especilidade_Horario, New Object() {FNC_NVL(cboEmpresa.SelectedValue, 0), FNC_NVL(cboEspecialdade.SelectedValue, 0), txtDataAgendamento.DateTime.Date})
    ComboBox_Selecionar(cboProfissional, iID_PESSOA_PROFISSIONAL)
    bEmProcessamento = False
  End Sub

  Private Sub cboEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresa.SelectedIndexChanged
    If Not bEmProcessamento Then
      Calendario_CarregarLinhas()
      ListagemAgendamento_Carregar()

      CalcularProcedimento()
    End If
  End Sub

  Private Sub CalcularProcedimento()
    lblValorProcedimento.Text = ""
    dVL_PROCEDIMENTO = 0

    If ComboBox_Selecionado(cboProfissional) And ComboBox_Selecionado(cboConvenio) And psqProcedimento.Identificador <> 0 Then
      Dim sSqlText As String
      Dim oData As DataTable

      sSqlText = "SELECT ISNULL(VL_PROCEDIMENTO, 0) VL_PROCEDIMENTO" &
                 " FROM TB_CONVENIO_PROCEDIMENTO" &
                 " WHERE ID_PROCEDIMENTO = " & psqProcedimento.Identificador &
                   " And ID_CONVENIO = " & cboConvenio.SelectedValue &
                   " And ID_PESSOA_PROFISSIONAL = " & cboProfissional.SelectedValue
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        dVL_PROCEDIMENTO = oData.Rows(0).Item("VL_PROCEDIMENTO")

        lblValorProcedimento.Text = FormatCurrency(dVL_PROCEDIMENTO)
      End If

      oData.Dispose()
    End If
  End Sub

  Private Sub psqProcedimento_ItemSelecionado(sender As Object, e As EventArgs) Handles psqProcedimento.ItemSelecionado
    CalcularProcedimento()
  End Sub

  Private Sub cboConvenio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConvenio.SelectedIndexChanged
    If Not bEmProcessamento Then
      psqProcedimento.Limpar()
      psqProcedimento.Convenio = cboConvenio.SelectedValue
      Convenio_AtualizarCredito()
    End If
  End Sub

  Private Sub Convenio_AtualizarCredito()
    If ComboBox_Selecionado(cboConvenio) Then
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT SQ_CONVENIO, VL_CREDITO FROM TB_CONVENIO WHERE SQ_CONVENIO = " & cboConvenio.SelectedValue & " And ISNULL(IC_CONTROLACREDITO, 'N') = 'S'"
      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        lblSaldoConvenio.Tag = 0
        lblSaldoConvenio.Visible = False
      Else
        lblSaldoConvenio.Tag = FNC_NVL(oData.Rows(0).Item("VL_CREDITO"), 0)
        lblSaldoConvenio.Text = FormatCurrency(lblSaldoConvenio.Tag)
        lblSaldoConvenio.Visible = True
      End If

      oData.Dispose()
    End If
  End Sub

  Private Sub cmdVenda_Click(sender As Object, e As EventArgs) Handles cmdVenda.Click
    If iSQ_AGENDAMENTO <= 0 Then
      FNC_Mensagem("É necessário selecionar o agendamento para o qual deseja gerar uma venda")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM VW_CLINICA_VENDA_AGENDAMENTO WHERE ID_AGENDAMENTO = " & iSQ_AGENDAMENTO & " AND DH_CANCELAR IS NULL"

    If DBQuery_ValorUnico(sSqlText) > 0 Then
      FNC_Mensagem("Existe venda realizada para esse agendamento")
      Exit Sub
    End If

    Dim oForm As New frmCadastroVenda

    oForm.iID_PESSOA = iID_PACIENTE
    oForm.oID_AGENDAMENTO = New Collection
    oForm.oID_AGENDAMENTO.Add(iSQ_AGENDAMENTO)

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdRetorno_EnabledChanged(sender As Object, e As EventArgs) Handles cmdRetorno.EnabledChanged
    cmdRetorno.Enabled = False
  End Sub

  Private Sub cmdRemarcar_EnabledChanged(sender As Object, e As EventArgs) Handles cmdRemarcar.EnabledChanged
    cmdRemarcar.Enabled = False
  End Sub

  Private Sub cmdNovo_EnabledChanged(sender As Object, e As EventArgs) Handles cmdNovo.EnabledChanged
    cmdNovo.Enabled = False
  End Sub
End Class