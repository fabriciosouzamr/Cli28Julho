Public Class frmCadastroAgendamento_ProfissionalData
  Public Event GravacaoEfetuada()

  Public Enum enTipoAlteracao
    Retorno = 1
    Remarcacao = 2
  End Enum

  Public eTipoAlteracao As enTipoAlteracao = enTipoAlteracao.Retorno
  Public iSQ_AGENDAMENTO As Integer
  Public iID_PROFISSIONAL As Integer
  Public dDataAgendamento As Date
  Public bGravado As Boolean
  Dim oHistorico As New clsHistorico
  Dim iProcesso As Integer
  Dim sCD_AGENDAMENTO As String
  Dim iID_PESSOA As Integer

  Private Sub frmCadastroAgendamento_ProfissionalData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboProfissional, enSql.Profissional)
    ComboBox_Carregar(cboTipoConsulta, enSql.Tipo_Consulta)
    ComboBox_Carregar(cboEmpresa, enSql.Empresa)
    ComboBox_Carregar(cboEspecialdade, enSql.Especialidade)
    ComboBox_Carregar(cboGrupoProcedimento, enSql.GrupoProcedimento)

    If iID_PROFISSIONAL > 0 Then
      ComboBox_Selecionar(cboProfissional, iID_PROFISSIONAL)
    End If

    cboEmpresa.Enabled = False
    cboGrupoProcedimento.Enabled = False
    cboEspecialdade.Enabled = False
    cboProfissional.Enabled = False
    cboTipoConsulta.Enabled = False
    txtDataAgendamento.Enabled = False

    CarregarDados()

    Select Case eTipoAlteracao
      Case enTipoAlteracao.Retorno
        If iEMPRESA_ID_TIPOCONSULTA_RETORNO > 0 Then
          ComboBox_Selecionar(cboTipoConsulta, iEMPRESA_ID_TIPOCONSULTA_RETORNO)
        End If
        cmdDisponibilidade.Top = cmdFechar.Top
        Me.Text = "Cadastro de Agendamento - Retorno"
      Case enTipoAlteracao.Remarcacao
        psqProcedimento.Visible = False
        cmdGravar.Top = 218
        cmdFechar.Top = 218
        cmdDisponibilidade.Top = 218
        Me.Height = 291
        Me.Text = "Cadastro de Agendamento - Remarcação"
    End Select

    txtDataAgendamento.Value = dDataAgendamento
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM VW_AGENDAMENTO WHERE SQ_AGENDAMENTO = " & iSQ_AGENDAMENTO
    oData = DBQuery(sSqlText)

    iID_PESSOA = oData.Rows(0).Item("ID_PESSOA")
    sCD_AGENDAMENTO = oData.Rows(0).Item("CD_AGENDAMENTO")
    txtCodigo.Text = oData.Rows(0).Item("CD_AGENDAMENTO")
    txtPessoa.Text = oData.Rows(0).Item("NO_PESSOA")
    ComboBox_Selecionar(cboTipoConsulta, oData.Rows(0).Item("ID_TIPO_CONSULTA"))
    ComboBox_Selecionar(cboEspecialdade, oData.Rows(0).Item("ID_ESPECIALIDADE"))
    ComboBox_Selecionar(cboEmpresa, oData.Rows(0).Item("ID_EMPRESA"))
    ComboBox_Selecionar(cboGrupoProcedimento, oData.Rows(0).Item("ID_GRUPOPROCEDIMENTO"))
    psqProcedimento.Identificador = FNC_NVL(oData.Rows(0).Item("ID_PROCEDIMENTO"), 0)

    FNC_Historico_Guardar()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboProfissional) Then
      FNC_Mensagem("Selecione o profissional para esse agendamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoConsulta) Then
      FNC_Mensagem("Selecione o tipo da consulta")
      Exit Sub
    End If
    If Not IsDate(txtDataAgendamento.Text) Then
      FNC_Mensagem("Informe uma data válida para esse agendamento")
      Exit Sub
    End If
    If eTipoAlteracao = enTipoAlteracao.Retorno Then
      If txtDataAgendamento.DateTime.Date <= dDataAgendamento.Date Then
        FNC_Mensagem("É preciso informar uma data posterior a data do agendamento para retorno")
        Exit Sub
      End If
    End If
    If FNC_Busca_Agendamento_Existe(FNC_NVL(cboEmpresa.SelectedValue, 0), FNC_NVL(cboProfissional.SelectedValue, 0), txtDataAgendamento.Value) Then
      FNC_Mensagem("Existe agendamento para esse horário, favor verificar na listagem de agendamentos")
      Exit Sub
    End If

    Dim sSqlText As String

    Select Case eTipoAlteracao
      Case enTipoAlteracao.Retorno
        iProcesso = enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode()

        sSqlText = DBMontar_SP("SP_AGENDAMENTO_RETORNO_CAD", False, "@SQ_AGENDAMENTO OUT",
                                                                    "@ID_EMPRESA",
                                                                    "@CD_AGENDAMENTO OUT",
                                                                    "@ID_PESSOA_PROFISSIONAL",
                                                                    "@ID_TIPO_CONSULTA",
                                                                    "@ID_PROCEDIMENTO",
                                                                    "@DH_AGENDAMENTO",
                                                                    "@ID_USUARIO")
        If DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO, , ParameterDirection.InputOutput),
                                DBParametro_Montar("ID_EMPRESA", cboEmpresa.SelectedValue),
                                DBParametro_Montar("CD_AGENDAMENTO", Nothing, , ParameterDirection.Output),
                                DBParametro_Montar("ID_PESSOA_PROFISSIONAL", cboProfissional.SelectedValue),
                                DBParametro_Montar("ID_TIPO_CONSULTA", cboTipoConsulta.SelectedValue),
                                DBParametro_Montar("ID_PROCEDIMENTO", FNC_NuloZero(psqProcedimento.Identificador, False)),
                                DBParametro_Montar("DH_AGENDAMENTO", txtDataAgendamento.DateTime, SqlDbType.DateTime),
                                DBParametro_Montar("ID_USUARIO", iID_USUARIO)) Then
          If DBTeveRetorno() Then
            txtCodigo.Text = DBRetorno(2)
          End If

          iID_PROFISSIONAL = cboProfissional.SelectedValue
          dDataAgendamento = txtDataAgendamento.DateTime
          bGravado = True

          FNC_Mensagem("Gravação Efetuada")
        End If
      Case enTipoAlteracao.Remarcacao
        iProcesso = enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode()

        sSqlText = DBMontar_SP("SP_AGENDAMENTO_REMARCAR_UPD", False, "@SQ_AGENDAMENTO OUT",
                                                                     "@ID_EMPRESA",
                                                                     "@CD_AGENDAMENTO OUT",
                                                                     "@ID_PESSOA_PROFISSIONAL",
                                                                     "@ID_TIPO_CONSULTA",
                                                                     "@DH_AGENDAMENTO",
                                                                     "@ID_USUARIO")
        If DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO, , ParameterDirection.InputOutput),
                                DBParametro_Montar("ID_EMPRESA", cboEmpresa.SelectedValue),
                                DBParametro_Montar("CD_AGENDAMENTO", Nothing, , ParameterDirection.Output),
                                DBParametro_Montar("ID_PESSOA_PROFISSIONAL", cboProfissional.SelectedValue),
                                DBParametro_Montar("ID_TIPO_CONSULTA", cboTipoConsulta.SelectedValue),
                                DBParametro_Montar("DH_AGENDAMENTO", txtDataAgendamento.DateTime, SqlDbType.DateTime),
                                DBParametro_Montar("ID_USUARIO", iID_USUARIO)) Then
          If DBTeveRetorno() Then
            txtCodigo.Text = DBRetorno(2)
          End If

          iID_PROFISSIONAL = cboProfissional.SelectedValue
          dDataAgendamento = txtDataAgendamento.DateTime
          bGravado = True

          FNC_Mensagem("Gravação Efetuada")

          RaiseEvent GravacaoEfetuada()
        End If

        FNC_Historico(enOpcoes.Processo_Acao_Alteracao)
    End Select

    Close()
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub FNC_Historico_Guardar()
    oHistorico.Inicializar()
    oHistorico.Controle_LimparValorAtual()
    oHistorico.Controle_ValorAtual(txtCodigo, txtCodigo.Text)
    oHistorico.Controle_ValorAtual(cboProfissional, cboProfissional.Text)
    oHistorico.Controle_ValorAtual(txtDataAgendamento, txtDataAgendamento.Text)
    oHistorico.Controle_ValorAtual(cboTipoConsulta, cboTipoConsulta.Text)
    oHistorico.Controle_ValorAtual(psqProcedimento.cboProcedimentoPrincipal, psqProcedimento.cboProcedimentoPrincipal.Text)
  End Sub

  Private Sub FNC_Historico(iAcao As enOpcoes)
    oHistorico.ID_Registro = iSQ_AGENDAMENTO
    oHistorico.GravarHistorico(iProcesso,
                               iAcao, 0, sCD_AGENDAMENTO, Me.Text,
                               New Object() {txtCodigo, txtCodigo.Text,
                                             cboProfissional, lblRProfissional.Text,
                                             cboTipoConsulta, lblRTipoConsulta.Text,
                                             txtDataAgendamento, lblRDataAgendamento.Text,
                                             psqProcedimento.cboProcedimentoPrincipal, "Procedimento"})

    FNC_Historico_Guardar()
  End Sub

  Private Sub cmdDisponibilidade_Click(sender As Object, e As EventArgs) Handles cmdDisponibilidade.Click
    Dim dDataInicial As Date
    Dim dDataFinal As Date
    Dim sProfissional As String = ""
    Dim sProcedimento As String = ""
    Dim sEspecialidade As String = ""
    Dim sEmpresa As String = ""

    If IsDate(txtDataAgendamento.Text) Then dDataInicial = Now.Date()
    If IsDate(txtDataAgendamento.Text) Then dDataFinal = Now.Date.AddMonths(1)
    If psqProcedimento.Identificador > 0 Then
      FNC_Str_Adicionar(sProcedimento, psqProcedimento.Identificador, ",")
    End If
    If ComboBox_Selecionado(cboEmpresa) Then
      FNC_Str_Adicionar(sEmpresa, cboEmpresa.SelectedValue, ",")
    End If

    Dim oForm As New frmConsultaAgendamentoDisponibilidade

    oForm.sData_Inicial = dDataInicial
    oForm.sData_Final = dDataFinal
    If eTipoAlteracao = enTipoAlteracao.Remarcacao Then
      oForm.sID_Profissionais = sProfissional
    Else
      oForm.sID_Profissionais = cboProfissional.SelectedValue
    End If
    oForm.sID_Procedimentos = sProcedimento
    oForm.sID_Especialidade = sEspecialidade
    oForm.sID_Paiciente = iID_PESSOA
    oForm.sEmpresa = sEmpresa
    oForm.bPodeSelecionar = True
    oForm.bRetornarData = True
    oForm.bRetorno = (eTipoAlteracao = enTipoAlteracao.Retorno)

    If ComboBox_Selecionado(cboEspecialdade) Then
      oForm.sID_Especialidade = cboEspecialdade.SelectedValue
    End If
    If ComboBox_Selecionado(cboGrupoProcedimento) Then
      oForm.sID_GrupoProcedimentos = cboGrupoProcedimento.SelectedValue
    End If

    oForm.Formatar()

    FNC_AbriTela(oForm, , True, True)

    If Not oForm.bFechou Then
      txtDataAgendamento.DateTime = oForm.dDataRetorno
      ComboBox_Selecionar(cboEmpresa, oForm.sEmpresa)

      If eTipoAlteracao = enTipoAlteracao.Remarcacao Then
        ComboBox_Selecionar(cboProfissional, oForm.sID_Profissionais)
      End If
    End If

    oForm = Nothing
  End Sub
End Class