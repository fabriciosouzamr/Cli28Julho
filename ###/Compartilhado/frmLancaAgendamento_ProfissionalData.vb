Public Class frmLancaAgendamento_ProfissionalData
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

  Private Sub frmLancaAgendamento_ProfissionalData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboProfissional, enSql.Profissional)
    ComboBox_Carregar(cboTipoConsulta, enSql.Tipo_Consulta)

    If iID_PROFISSIONAL > 0 Then
      ComboBox_Selecionar(cboProfissional, iID_PROFISSIONAL)
    End If

    CarregarDados()

    Select Case eTipoAlteracao
      Case enTipoAlteracao.Retorno
        If iEMPRESA_ID_TIPOCONSULTA_RETORNO > 0 Then
          ComboBox_Selecionar(cboTipoConsulta, iEMPRESA_ID_TIPOCONSULTA_RETORNO)
        End If
      Case enTipoAlteracao.Remarcacao
        psqProcedimento.Visible = False
        cmdGravar.Top = 131
        cmdFechar.Top = 131
        Me.Height = 204
    End Select

    txtDataAgendamento.Value = dDataAgendamento
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM VW_AGENDAMENTO WHERE SQ_AGENDAMENTO = " & iSQ_AGENDAMENTO
    oData = DBQuery(sSqlText)

    txtCodigo.Text = oData.Rows(0).Item("CD_AGENDAMENTO")
    txtPessoa.Text = oData.Rows(0).Item("NO_PESSOA")
    ComboBox_Selecionar(cboTipoConsulta, oData.Rows(0).Item("ID_TIPO_CONSULTA"))
    ComboBox_Selecionar(cboTipoConsulta, oData.Rows(0).Item("ID_TIPO_CONSULTA"))
    psqProcedimento.Identificador = FNC_NVL(oData.Rows(0).Item("ID_PROCEDIMENTO"), 0)
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
    If FNC_Busca_Agendamento_Existe(iID_EMPRESA_FILIAL, FNC_NVL(cboProfissional.SelectedValue, 0), txtDataAgendamento.Value) Then
      FNC_Mensagem("Existe agendamento para esse horário, favor verificar na listagem de agendamentos")
      Exit Sub
    End If

    Dim sSqlText As String

    Select Case eTipoAlteracao
      Case enTipoAlteracao.Retorno
        sSqlText = DBMontar_SP("SP_AGENDAMENTO_RETORNO_CAD", False, "@SQ_AGENDAMENTO",
                                                                    "@ID_PESSOA_PROFISSIONAL",
                                                                    "@ID_TIPO_CONSULTA",
                                                                    "@ID_PROCEDIMENTO",
                                                                    "@DH_AGENDAMENTO")
        If DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO),
                                DBParametro_Montar("ID_PESSOA_PROFISSIONAL", cboProfissional.SelectedValue),
                                DBParametro_Montar("ID_TIPO_CONSULTA", cboTipoConsulta.SelectedValue),
                                DBParametro_Montar("ID_PROCEDIMENTO", FNC_NuloZero(psqProcedimento.Identificador, False)),
                                DBParametro_Montar("DH_AGENDAMENTO", txtDataAgendamento.DateTime, SqlDbType.DateTime)) Then
          iID_PROFISSIONAL = cboProfissional.SelectedValue
          dDataAgendamento = txtDataAgendamento.DateTime
          bGravado = True

          FNC_Mensagem("Gravação Efetuada")
        End If
      Case enTipoAlteracao.Remarcacao
        sSqlText = DBMontar_SP("SP_AGENDAMENTO_REMARCAR_UPD", False, "@SQ_AGENDAMENTO",
                                                                     "@ID_PESSOA_PROFISSIONAL",
                                                                     "@ID_TIPO_CONSULTA",
                                                                     "@DH_AGENDAMENTO")
        If DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO),
                                DBParametro_Montar("ID_PESSOA_PROFISSIONAL", cboProfissional.SelectedValue),
                                DBParametro_Montar("ID_TIPO_CONSULTA", cboTipoConsulta.SelectedValue),
                                DBParametro_Montar("DH_AGENDAMENTO", txtDataAgendamento.DateTime, SqlDbType.DateTime)) Then
          iID_PROFISSIONAL = cboProfissional.SelectedValue
          dDataAgendamento = txtDataAgendamento.DateTime
          bGravado = True

          FNC_Mensagem("Gravação Efetuada")

          RaiseEvent GravacaoEfetuada()
        End If
    End Select
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub FNC_Historico_Guardar()
    oHistorico.Inicializar()
    oHistorico.Controle_LimparValorAtual()
    oHistorico.Controle_ValorAtual(cboProfissional, cboProfissional.Text)
    oHistorico.Controle_ValorAtual(txtDataAgendamento, txtDataAgendamento.Text)
    oHistorico.Controle_ValorAtual(cboTipoConsulta, cboTipoConsulta.Text)
    oHistorico.Controle_ValorAtual(psqProcedimento.cboProcedimentoPrincipal, psqProcedimento.cboProcedimentoPrincipal.Text)
  End Sub

  Private Sub FNC_Historico(iAcao As enOpcoes)
    oHistorico.ID_Registro = iSQ_AGENDAMENTO
    oHistorico.GravarHistorico(enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode,
                               iAcao, 0, txtCodigo.Text, Me.Text,
                               New Object() {cboProfissional, lblRProfissional.Text,
                                             cboTipoConsulta, lblRTipoConsulta.Text,
                                             txtDataAgendamento, lblRDataAgendamento.Text,
                                             psqProcedimento.cboProcedimentoPrincipal, "Procedimento"})

    FNC_Historico_Guardar()
  End Sub
End Class