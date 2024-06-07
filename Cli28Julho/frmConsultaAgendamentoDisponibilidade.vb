Public Class frmConsultaAgendamentoDisponibilidade
  Class cDisponibilidade
    Public DIA As String
    Public DATA As String
    Public MEDICO As String
    Public EMPRESA As String
    Public PERIODO As String
    Public PROCEDIMENTOS_PREVISAO As String
    Public PROCEDIMENTOS_AGENDADAS As String
    Public PROCEDIMENTOS_DISPONIVEL As String
    Public REVISOES_PREVISAO As String
    Public REVISOES_AGENDADAS As String
    Public REVISOES_DISPONIVEL As String
    Public oAgendamento_Disponibilidade As clsAgendamento_Disponibilidade
  End Class

  Public sData_Inicial As String
  Public sData_Final As String
  Public sID_Profissionais As String
  Public sID_Procedimentos As String
  Public sID_GrupoProcedimentos As String
  Public sID_Especialidade As String
  Public sID_Paiciente As String
  Public sProfissionais As String
  Public sProcedimentos As String
  Public sEspecialidade As String
  Public sPaciente As String
  Public sEmpresa As String
  Public bRetornarData As Boolean
  Public dDataRetorno As Date
  Public sHoraInicial As String
  Public sHoraFinal As String
  Public bPodeSelecionar As Boolean
  Public bFechou As Boolean
  Public bRetorno As Boolean
  Public ID_PESSOA_HORARIO As Integer

  Dim oDisponibilidade() As cDisponibilidade
  Dim sSqlText As String

  Private Sub frmConsultaAgendamentoDisponibilidade_Load(sender As Object, e As EventArgs) Handles Me.Load
    lblProfissional.Text = sID_Profissionais
    lblEspecialidade.Text = sEspecialidade
    lblProfissional.Text = sProfissionais
    lblProcedimento.Text = sProcedimentos
    lblPaciente.Text = sPaciente

    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    cmdSetaProcedimentos01.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos02.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos03.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos04.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos05.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos06.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos07.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos08.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos09.Formatar(enOpcoes.ConfiguracaoTela_Botao_Seta)
    cmdSetaProcedimentos01.Enabled = bPodeSelecionar
    cmdSetaProcedimentos02.Enabled = bPodeSelecionar
    cmdSetaProcedimentos03.Enabled = bPodeSelecionar
    cmdSetaProcedimentos04.Enabled = bPodeSelecionar
    cmdSetaProcedimentos05.Enabled = bPodeSelecionar
    cmdSetaProcedimentos06.Enabled = bPodeSelecionar
    cmdSetaProcedimentos07.Enabled = bPodeSelecionar
    cmdSetaProcedimentos08.Enabled = bPodeSelecionar
    cmdSetaProcedimentos09.Enabled = bPodeSelecionar

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1
    VScrollBar.Minimum = 1

    LimparDisponibilidade()
    Carregar()
  End Sub

  Private Sub LimparDisponibilidade()
    For iCont = 1 To 9
      Me.Controls(Me.Controls.IndexOfKey("lblDia" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPeriodo" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblUnidade" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPPvs" + FNC_StrZero(iCont, 1))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPAgd" + FNC_StrZero(iCont, 1))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPDpn" + FNC_StrZero(iCont, 1))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblRPvs" + FNC_StrZero(iCont, 1))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblRAgd" + FNC_StrZero(iCont, 1))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblRDpn" + FNC_StrZero(iCont, 1))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("cmdSetaProcedimentos" + FNC_StrZero(iCont, 2))).Tag = Nothing
    Next
  End Sub

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.Clinica_ConsultaAgendamentoDisponibilidade))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 30
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub Carregar()
    Dim oData As DataTable
    Dim oData_Exames As DataTable = New DataTable()
    Dim sSqlText_Where As String = ""
    Dim iIndice As Integer = 0
    Dim iCont As Integer = 0

    If New DateTime(sData_Inicial.Split("/")(2), sData_Inicial.Split("/")(1), sData_Inicial.Split("/")(0), 0, 0, 0) < Now.Date Then
      sData_Inicial = FNC_StrZero(Now.Day, 2) + "/" + FNC_StrZero(Now.Month, 2) + "/" + FNC_StrZero(Now.Year, 4)
    End If
    If New DateTime(sData_Final.Split("/")(2), sData_Final.Split("/")(1), sData_Final.Split("/")(0), 0, 0, 0) < Now.Date Then
      sData_Final = FNC_StrZero(Now.AddDays(10).Day, 2) + "/" + FNC_StrZero(Now.AddDays(10).Month, 2) + "/" + FNC_StrZero(Now.AddDays(10).Year, 4)
    End If

    Try
      sSqlText = "WITH LSTPR (DATA, NO_OPCAO, ID_EMPRESA, ID_PESSOA, SQ_PESSOA_HORARIO, HR_INICIO, HR_FIM, NR_INTERVALO, QT_ATENDIMENTO, QT_RETORNO, DATA_INICIO, DATA_FIM)" &
                 " AS" &
                 " (SELECT LSTPR.DATA," &
                           "OPCAO.NO_OPCAO," &
                           "PSHRR.ID_EMPRESA," &
                           "PSHRR.ID_PESSOA," &
                           "PSHRR.SQ_PESSOA_HORARIO," &
                           "PSHRR.HR_INICIO," &
                           "PSHRR.HR_FIM," &
                           "ISNULL(PSHRR.NR_INTERVALO, 0) NR_INTERVALO," &
                           "PSHRR.QT_ATENDIMENTO," &
                           "PSHRR.QT_RETORNO," &
                           "dbo.FC_DATAHORA_MONTAR(LSTPR.DATA, PSHRR.HR_INICIO) DATA_INICIO," &
                           "dbo.FC_DATAHORA_MONTAR(LSTPR.DATA, PSHRR.HR_FIM) DATA_FIM" &
                    " FROM dbo.FC_DATA_LISTARPERIODO_DATAUTIL(2, '" + sData_Inicial + "', '" + sData_Final + "') LSTPR" &
                     " INNER JOIN TB_OPCAO (NOLOCK) OPCAO ON OPCAO.CD_OPCAO = DATEPART(DW, LSTPR.DATA)" &
                                                        " AND OPCAO.ID_TIPO_OPCAO = " & enTipoOpcao.DiasSemana &
                     " INNER JOIN TB_PESSOA_HORARIO (NOLOCK) PSHRR On PSHRR.ID_OPT_DIA_SEMANA = OPCAO.SQ_OPCAO" &
                                                                " And ISNULL(PSHRR.IC_BLOQUEADO, 'N') = 'N'" &
                      " AND ISNULL(PSHRR.DT_ESPECIAL, LSTPR.DATA) = LSTPR.DATA" &
                      " AND PSHRR.ID_OPT_ATIVO = " & enOpcoes.SimNao_Sim.GetHashCode() & ")"
      sSqlText = sSqlText &
                 "SELECT DIA," &
                        "DATA," &
                        "ID_EMPRESA," &
                        "NO_EMPRESA," &
                        "SQ_PESSOA," &
                        "NO_PESSOA," &
                        "SQ_PESSOA_HORARIO," &
                        "HR_INICIO," &
                        "HR_FIM," &
                        "NR_INTERVALO," &
                        "QT_ATENDIMENTO PROCEDIMENTO_PREVISAO," &
                        "SUM(PROCEDIMENTO) PROCEDIMENTO_AGENDADAS," &
                        "dbo.FC_ValorPositivo(QT_ATENDIMENTO - SUM(PROCEDIMENTO), 0) PROCEDIMENTO_DISPONIVEL," &
                        "QT_RETORNO REVISOES_PREVISAO," &
                        "SUM(RETORNO) REVISOES_AGENDADAS," &
                        "dbo.FC_ValorPositivo(QT_RETORNO - SUM(RETORNO), 0) REVISOES_DISPONIVEL" &
                 " FROM (SELECT LSTPR.NO_OPCAO DIA," &
                               "LSTPR.DATA," &
                               "EMPRE.SQ_PESSOA ID_EMPRESA," &
                               "EMPRE.NO_PESSOA NO_EMPRESA," &
                               "PESSO.SQ_PESSOA," &
                               "PESSO.NO_PESSOA," &
                               "LSTPR.SQ_PESSOA_HORARIO," &
                               "LSTPR.HR_INICIO," &
                               "LSTPR.HR_FIM," &
                               "LSTPR.NR_INTERVALO," &
                               "ISNULL(LSTPR.QT_ATENDIMENTO, 0) QT_ATENDIMENTO," &
                               "ISNULL(LSTPR.QT_RETORNO, 0) QT_RETORNO," &
                               "SUM(IIF(ISNULL(TPCSL.IC_TIPO_RETORNO, 'X') = 'N', 1, 0)) PROCEDIMENTO," &
                               "SUM(IIF(ISNULL(TPCSL.IC_TIPO_RETORNO, 'X') = 'S', 1, 0)) RETORNO" &
                        " FROM LSTPR LSTPR" &
                          " LEFT JOIN VW_PESSOA_HORARIO_BLOQUEIO (NOLOCK) PNRBP ON PNRBP.DT_BLOQUEIO_INCIO <= LSTPR.DATA_INICIO" &
                                                                   " AND PNRBP.DT_BLOQUEIO_FIM >= LSTPR.DATA_FIM" &
                                                                   " AND PNRBP.ID_EMPRESA = " & iID_EMPRESA_MATRIZ &
                                                                   " AND PNRBP.ID_PESSOA = LSTPR.ID_PESSOA" &
                         " INNER JOIN TB_PESSOA (NOLOCK) PESSO ON PESSO.SQ_PESSOA = LSTPR.ID_PESSOA" &
                         " INNER JOIN TB_PESSOA (NOLOCK) EMPRE ON EMPRE.SQ_PESSOA = LSTPR.ID_EMPRESA"

      If Trim(sID_Procedimentos) <> "" Then
        sSqlText = sSqlText &
                         " INNER JOIN TB_PESSOA_HORARIO_PROCEDIMENTO (NOLOCK) PSHPC ON PSHPC.ID_PESSOA_HORARIO = LSTPR.SQ_PESSOA_HORARIO" &
                         " INNER JOIN TB_PROCEDIMENTO (NOLOCK) PROCE ON PROCE.SQ_PROCEDIMENTO = PSHPC.ID_PROCEDIMENTO"
      End If
      If Trim(sID_Especialidade) <> "" Then
        sSqlText = sSqlText &
                         " INNER JOIN TB_PESSOA_ESPECIALIDADE (NOLOCK) PSESP ON PSESP.ID_PESSOA = PESSO.SQ_PESSOA"
      End If

      sSqlText = sSqlText &
                          " LEFT JOIN TB_AGENDAMENTO (NOLOCK) AGEND ON AGEND.DH_AGENDAMENTO >= LSTPR.DATA_INICIO" &
                                                        " AND AGEND.DH_AGENDAMENTO <= LSTPR.DATA_FIM" &
                                                        " AND AGEND.ID_PESSOA_PROFISSIONAL = LSTPR.ID_PESSOA" &
                                                        " AND AGEND.ID_EMPRESA = LSTPR.ID_EMPRESA" &
                                                        " AND AGEND.ID_OPT_STATUS NOT IN (" & enOpcoes.StatusAgendamento_CanceladoClinica.GetHashCode() & "," &
                                                                                              enOpcoes.StatusAgendamento_CanceladoPaciente.GetHashCode() & "," &
                                                                                              enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode() & "," &
                                                                                              enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode() & "," &
                                                                                              enOpcoes.StatusAgendamento_Sistema_Excluido.GetHashCode() & ")" &
                          " LEFT JOIN TB_TIPO_CONSULTA (NOLOCK) TPCSL ON TPCSL.SQ_TIPO_CONSULTA = AGEND.ID_TIPO_CONSULTA" &
                        " WHERE PNRBP.SQ_PESSOA_HORARIO_BLOQUEIO IS NULL"

      If Trim(sID_Profissionais) <> "" Then
        sSqlText = sSqlText & " AND LSTPR.ID_PESSOA IN (" & sID_Profissionais & ")"
      End If
      If Trim(sID_Procedimentos) <> "" Then
        sSqlText = sSqlText & " AND PROCE.SQ_PROCEDIMENTO IN (" & sID_Procedimentos & ")"
      End If
      If Trim(sID_GrupoProcedimentos) <> "" Then
        sSqlText = sSqlText & " AND PROCE.ID_GRUPOPROCEDIMENTO IN (" & sID_GrupoProcedimentos & ")"
      End If
      If Trim(sID_Especialidade) <> "" Then
        sSqlText = sSqlText & " AND PSESP.ID_ESPECIALIDADE IN (" & sID_Especialidade & ")"
      End If

      sSqlText = sSqlText &
                        " GROUP BY LSTPR.NO_OPCAO," &
                                  "LSTPR.DATA," &
                                  "EMPRE.SQ_PESSOA," &
                                  "EMPRE.NO_PESSOA," &
                                  "PESSO.SQ_PESSOA," &
                                  "PESSO.NO_PESSOA," &
                                  "LSTPR.SQ_PESSOA_HORARIO," &
                                  "LSTPR.HR_INICIO," &
                                  "LSTPR.HR_FIM," &
                                  "LSTPR.NR_INTERVALO," &
                                  "LSTPR.QT_ATENDIMENTO," &
                                  "LSTPR.QT_RETORNO) X" &
                 " GROUP BY DIA," &
                           "DATA," &
                           "ID_EMPRESA," &
                           "NO_EMPRESA," &
                           "SQ_PESSOA," &
                           "NO_PESSOA," &
                           "SQ_PESSOA_HORARIO," &
                           "HR_INICIO," &
                           "HR_FIM," &
                           "NR_INTERVALO," &
                           "QT_ATENDIMENTO," &
                           "QT_RETORNO" &
                 " ORDER BY DATA," &
                           "HR_INICIO," &
                           "HR_FIM," &
                           "NO_EMPRESA," &
                           "NO_PESSOA"
      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        oDisponibilidade = Nothing
      Else
        ReDim oDisponibilidade(oData.Rows.Count - 1)

        For Each oRow As DataRow In oData.Rows
          oDisponibilidade(iIndice) = New cDisponibilidade()

          With oDisponibilidade(iIndice)
            .DIA = oRow.Item("DIA")
            .DATA = oRow.Item("DATA")
            .MEDICO = oRow.Item("NO_PESSOA")
            .EMPRESA = oRow.Item("NO_EMPRESA")
            .PERIODO = oRow.Item("HR_INICIO") & " às " & oRow.Item("HR_FIM")
            .PROCEDIMENTOS_PREVISAO = oRow.Item("PROCEDIMENTO_PREVISAO")
            .PROCEDIMENTOS_AGENDADAS = oRow.Item("PROCEDIMENTO_AGENDADAS")
            .PROCEDIMENTOS_DISPONIVEL = oRow.Item("PROCEDIMENTO_DISPONIVEL")
            .REVISOES_PREVISAO = oRow.Item("REVISOES_PREVISAO")
            .REVISOES_AGENDADAS = oRow.Item("REVISOES_AGENDADAS")
            .REVISOES_DISPONIVEL = oRow.Item("REVISOES_DISPONIVEL")
            .oAgendamento_Disponibilidade = New clsAgendamento_Disponibilidade
            .oAgendamento_Disponibilidade.Especialidade = sID_Especialidade
            .oAgendamento_Disponibilidade.Procedimento = sID_Procedimentos
            .oAgendamento_Disponibilidade.Paciente = sID_Paiciente
            .oAgendamento_Disponibilidade.Empresa = oRow.Item("ID_EMPRESA")
            .oAgendamento_Disponibilidade.Medico = oRow.Item("SQ_PESSOA")
            .oAgendamento_Disponibilidade.NomeMedico = oRow.Item("NO_PESSOA")
            .oAgendamento_Disponibilidade.Data = oRow.Item("DATA")
            .oAgendamento_Disponibilidade.Atendimento_Previsto = oRow.Item("PROCEDIMENTO_PREVISAO")
            .oAgendamento_Disponibilidade.Atendimento_Disponivel = oRow.Item("PROCEDIMENTO_DISPONIVEL")
            .oAgendamento_Disponibilidade.Retorno_Previsto = oRow.Item("REVISOES_PREVISAO")
            .oAgendamento_Disponibilidade.Retorno_Disponivel = oRow.Item("REVISOES_DISPONIVEL")
            .oAgendamento_Disponibilidade.HoraInicial = oRow.Item("HR_INICIO")
            .oAgendamento_Disponibilidade.HoraFim = oRow.Item("HR_FIM")
            .oAgendamento_Disponibilidade.Intervalo = oRow.Item("NR_INTERVALO")
            .oAgendamento_Disponibilidade.ID_PESSOA_HORARIO = oRow.Item("SQ_PESSOA_HORARIO")
          End With

          iIndice = iIndice + 1
        Next

        oData.Dispose()
        oData_Exames.Dispose()
      End If

      If oDisponibilidade Is Nothing Then
        VScrollBar.Enabled = False
        LimparDisponibilidade()
      Else
        VScrollBar.Enabled = (oDisponibilidade.Length > 9)
        If oDisponibilidade.Length - 9 > 0 Then VScrollBar.Maximum = oDisponibilidade.Length - 8
      End If

      VScrollBar.Value = 1

      ListarDisponibilidade()
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Private Function Disponibilidade_Carregado() As Boolean
    If oDisponibilidade Is Nothing Then
      Return False
    Else
      Return (oDisponibilidade.Count > 0)
    End If
  End Function

  Private Sub ListarDisponibilidade()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    If Disponibilidade_Carregado() Then
      For iCont = VScrollBar.Value - 1 To VScrollBar.Value + 7
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblDia" + FNC_StrZero(iLabel, 2))).Text = oDisponibilidade(iCont).DIA
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = oDisponibilidade(iCont).DATA
          Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iLabel, 2))).Text = oDisponibilidade(iCont).MEDICO
          Me.Controls(Me.Controls.IndexOfKey("lblUnidade" + FNC_StrZero(iLabel, 2))).Text = oDisponibilidade(iCont).EMPRESA
          Me.Controls(Me.Controls.IndexOfKey("lblPeriodo" + FNC_StrZero(iLabel, 2))).Text = oDisponibilidade(iCont).PERIODO
          Me.Controls(Me.Controls.IndexOfKey("lblPPvs" + FNC_StrZero(iLabel, 1))).Text = oDisponibilidade(iCont).PROCEDIMENTOS_PREVISAO
          Me.Controls(Me.Controls.IndexOfKey("lblPAgd" + FNC_StrZero(iLabel, 1))).Text = oDisponibilidade(iCont).PROCEDIMENTOS_AGENDADAS
          Me.Controls(Me.Controls.IndexOfKey("lblPDpn" + FNC_StrZero(iLabel, 1))).Text = oDisponibilidade(iCont).PROCEDIMENTOS_DISPONIVEL
          Me.Controls(Me.Controls.IndexOfKey("lblRPvs" + FNC_StrZero(iLabel, 1))).Text = oDisponibilidade(iCont).REVISOES_PREVISAO
          Me.Controls(Me.Controls.IndexOfKey("lblRAgd" + FNC_StrZero(iLabel, 1))).Text = oDisponibilidade(iCont).REVISOES_AGENDADAS
          Me.Controls(Me.Controls.IndexOfKey("lblRDpn" + FNC_StrZero(iLabel, 1))).Text = oDisponibilidade(iCont).REVISOES_DISPONIVEL
          Me.Controls(Me.Controls.IndexOfKey("cmdSetaProcedimentos" + FNC_StrZero(iLabel, 2))).Tag = oDisponibilidade(iCont).oAgendamento_Disponibilidade
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblDia" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPeriodo" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblUnidade" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPPvs" + FNC_StrZero(iLabel, 1))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPAgd" + FNC_StrZero(iLabel, 1))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPDpn" + FNC_StrZero(iLabel, 1))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblRPvs" + FNC_StrZero(iLabel, 1))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblRAgd" + FNC_StrZero(iLabel, 1))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblRDpn" + FNC_StrZero(iLabel, 1))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("cmdSetaProcedimentos" + FNC_StrZero(iLabel, 2))).Tag = Nothing
        End Try

        iLabel = iLabel + 1
      Next
    End If
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    ListarDisponibilidade()
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    bFechou = True
    Close()
  End Sub

  Private Sub cmdSetaClick(sender As Object) Handles cmdSetaProcedimentos01.Clicado, cmdSetaProcedimentos02.Clicado, cmdSetaProcedimentos03.Clicado,
                                                     cmdSetaProcedimentos04.Clicado, cmdSetaProcedimentos05.Clicado, cmdSetaProcedimentos06.Clicado,
                                                     cmdSetaProcedimentos07.Clicado, cmdSetaProcedimentos08.Clicado, cmdSetaProcedimentos09.Clicado
    If Trim(sID_Especialidade) = "" And Not bRetornarData Then
      FNC_Mensagem("Selecione a especialidade na consulta de agendamento")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim oAgendamento_Disponibilidade As clsAgendamento_Disponibilidade = sender.tag

    If Val(sID_Paiciente) > 0 Then
      sSqlText = "SELECT dbo.FC_PESSOA_FAIXAETARIA_PACIENTE(" & oAgendamento_Disponibilidade.Medico & ", " & sID_Paiciente & ")"
      If DBQuery_ValorUnico(sSqlText) = "N" Then
        FNC_Mensagem("Esse profissional não atende a faixa etária desse paciente")
        Exit Sub
      End If
    End If

    If bRetornarData Then
      If (bRetorno And oAgendamento_Disponibilidade.Retorno_Disponivel = 0) Or
         (Not bRetorno And oAgendamento_Disponibilidade.Atendimento_Disponivel = 0) Then
        If FNC_Perguntar("Atingiu o limite de retorno, precisa de senha de supervisor para liberar. Deseja solicitar senha de supervisor?") Then
          If Not FormSEGUsuario_Validacao() Then
            Exit Sub
          End If
        Else
          Exit Sub
        End If
      End If

      dDataRetorno = FNC_Busca_Agendamento_HorarioDisponivel(oAgendamento_Disponibilidade.Empresa,
                                                             oAgendamento_Disponibilidade.Medico,
                                                             FNC_Data_AdicionarHora(oAgendamento_Disponibilidade.Data, oAgendamento_Disponibilidade.HoraInicial),
                                                             FNC_Data_AdicionarHora(oAgendamento_Disponibilidade.Data, oAgendamento_Disponibilidade.HoraFim))
      sID_Profissionais = oAgendamento_Disponibilidade.Medico
      sProfissionais = oAgendamento_Disponibilidade.NomeMedico
      sEmpresa = oAgendamento_Disponibilidade.Empresa
      sHoraInicial = oAgendamento_Disponibilidade.HoraInicial
      sHoraFinal = oAgendamento_Disponibilidade.HoraFim
      ID_PESSOA_HORARIO = oAgendamento_Disponibilidade.ID_PESSOA_HORARIO

      oAgendamento_Disponibilidade = Nothing

      Close()
    Else
      If oAgendamento_Disponibilidade.Atendimento_Disponivel = 0 Then
        If FNC_Perguntar("Atingiu o limite de retorno, precisa de senha de supervisor para liberar. Deseja solicitar senha de supervisor?") Then
          If Not FormSEGUsuario_Validacao() Then
            Exit Sub
          End If
        Else
          Exit Sub
        End If
      End If

      Dim oForm As New frmCadastroAgendamento

      oForm.bInclusaoEdicao = True
      oForm.oAgendamento_Disponibilidade = sender.tag
      oForm.ID_PESSOA_HORARIO = oForm.oAgendamento_Disponibilidade.ID_PESSOA_HORARIO

      FNC_AbriTela(oForm)
    End If
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    FormRelatorioDisponibilidade(sSqlText)
  End Sub
End Class