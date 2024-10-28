Public Class frmCadastroAtendimento
  Public iID_AGENDAMENTO As Integer
  Public iID_CONSULTORIO As Integer
  Public bFinalizado As Boolean
  Public bEditar As Boolean

  Dim iSQ_CLINICA_ATENDIMENTO As Integer
  Dim sCD_CLINICA_ATENDIMENTO As String
  Dim iID_Pessoa As Integer
  Dim iID_Procedimento As Integer
  Dim iID_Especialidade As Integer
  Dim oHistorico As New clsHistorico

  Class cAtendimento
    Public CD_PROCEDIMENTO As String
    Public NO_PROCEDIMENTO As String
    Public NO_MEDICO As String
    Public DH_CLINICA_ATENDIMENTO As String
    Public DESCRICAO As String
    Public EXAMES_SOLICITADOS() As String
  End Class

  Dim oAtendimento() As cAtendimento
  Dim eStatus As enOpcoes = enOpcoes.StatusAtendimentoClinica_EmAtendimento

  Const cnt_Especialidade_Oftalmologia As Integer = 20

  Private Sub frmCadastroAtendimento_Load(sender As Object, e As EventArgs) Handles Me.Load
    pnlExamesSolicitados.Visible = False
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)
    cmdFinalizar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Finalizar)
    cmdPacienteCadastro.Formatar(enOpcoes.ConfiguracaoTela_Botao_Paciente_Cadastro)
    cmdHistorico.Formatar(enOpcoes.ConfiguracaoTela_Botao_Historico)
    cmdAtestados.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atestados)
    cmdExames.Formatar(enOpcoes.ConfiguracaoTela_Botao_Exames)
    cmdReceituario.Formatar(enOpcoes.ConfiguracaoTela_Botao_Receituario)
    cmdVascinas.Formatar(enOpcoes.ConfiguracaoTela_Botao_Vacinas)
    cmdRelatorios.Formatar(enOpcoes.ConfiguracaoTela_Botao_Relatorios)

    lblProcedimento.Text = ""
    lblProntuario.Text = ""
    lblIdade.Text = ""

    Dim sTituloRelatorio As String = ">>>>>>>>>>>>> RELATÓRIO <<<<<<<<<<<<<< "
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT AGEND.ID_PESSOA," &
                      "AGEND.ID_ESPECIALIDADE," &
                      "PESSO.NO_PESSOA," &
                      "ISNULL(CLATD.ID_PROCEDIMENTO, AGEND.ID_PROCEDIMENTO) ID_PROCEDIMENTO," &
                      "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') IDADE," &
                      "CONCAT(RTRIM(PROCE.CD_PROCEDIMENTO), ' - ', PROCE.NO_PROCEDIMENTO) NO_PROCEDIMENTO," &
                      "AGEND.DH_AGENDAMENTO," &
                      "CLATD.SQ_CLINICA_ATENDIMENTO," &
                      "CLATD.DS_CLINICA_ATENDIMENTO," &
                      "CLATD.DH_CLINICA_ATENDIMENTO," &
                      "CLATD.ID_CONSULTORIO," &
                      "CLATD.ID_OPT_STATUS," &
                      "PESSO.DS_PATH_IMAGEM," &
                      "REL.DS_RELATORIO" &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" &
                 " LEFT JOIN TB_CLINICA_ATENDIMENTO	CLATD ON CLATD.ID_AGENDAMENTO = AGEND.SQ_AGENDAMENTO" &
                 " LEFT JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = ISNULL(CLATD.ID_PROCEDIMENTO, AGEND.ID_PROCEDIMENTO)" &
                 " LEFT JOIN TB_CLINICA_RELATORIO REL ON REL.ID_CLINICA_ATENDIMENTO = CLATD.SQ_CLINICA_ATENDIMENTO" &
               " WHERE AGEND.SQ_AGENDAMENTO = " & iID_AGENDAMENTO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      iID_Pessoa = oData.Rows(0).Item("ID_PESSOA")
      iID_Especialidade = oData.Rows(0).Item("ID_ESPECIALIDADE")
      lblPessoa.Text = oData.Rows(0).Item("NO_PESSOA")
      lblProntuario.Text = oData.Rows(0).Item("ID_PESSOA")
      If Not FNC_CampoNulo(oData.Rows(0).Item("ID_PROCEDIMENTO")) Then
        iID_Procedimento = oData.Rows(0).Item("ID_PROCEDIMENTO")
        lblProcedimento.Text = oData.Rows(0).Item("NO_PROCEDIMENTO")
      End If
      lblIdade.Text = oData.Rows(0).Item("IDADE")
      txtDataAgendamento.Value = oData.Rows(0).Item("DH_AGENDAMENTO")

      If Not FNC_CampoNulo(oData.Rows(0).Item("SQ_CLINICA_ATENDIMENTO")) Then
        iSQ_CLINICA_ATENDIMENTO = oData.Rows(0).Item("SQ_CLINICA_ATENDIMENTO")
        rtbDescricao.Text = oData.Rows(0).Item("DS_CLINICA_ATENDIMENTO")
        txtDataAgendamento.Value = oData.Rows(0).Item("DH_CLINICA_ATENDIMENTO")
        eStatus = oData.Rows(0).Item("ID_OPT_STATUS")

        If rtbDescricao.Text.IndexOf(sTituloRelatorio) > -1 Then
          rtbDescricao.Text = rtbDescricao.Text.Substring(0, rtbDescricao.Text.IndexOf(sTituloRelatorio))
        End If

        If Not FNC_CampoNulo(oData.Rows(0).Item("DS_RELATORIO")) Then
          rtbDescricao.Text = rtbDescricao.Text & vbNewLine & vbNewLine & ">>>>>>>>>>>>> RELATÓRIO <<<<<<<<<<<<<< " & vbNewLine & oData.Rows(0).Item("DS_RELATORIO")
        End If
      End If

      If Not FNC_CampoNulo(oData.Rows(0).Item("DS_PATH_IMAGEM")) Then
        FNC_CarregarImagem(oData.Rows(0).Item("DS_PATH_IMAGEM"), picFotoPaciente)
      End If

      HabilitarBotoes()
    End If

    Salvar(enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode(), False)

    FNC_Historico_Guardar()

    HabilitarBotoes()

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1
    VScrollBar.Value = 1
    VScrollBar.Minimum = 1

    CarregarHistorico()
  End Sub

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_TelaAtendimento))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 30
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Salvar(eStatus, False)

    Fechar()
  End Sub

  Private Sub Fechar()
    Close()

    Try
      If Not oFormConsultaAtendimento Is Nothing Then
        oFormConsultaAtendimento.Top = 0
        oFormConsultaAtendimento.Left = 0
        oFormConsultaAtendimento.Show()
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub cmdPacienteCadastro_Clicado(sender As Object) Handles cmdPacienteCadastro.Clicado
    If iID_Pessoa = 0 Then
      FNC_Mensagem("Selecione o paciente para qual deseja consultar o cadastro")
      Exit Sub
    Else
      Dim oForm As New frmCadastroPaciente

      oForm.Hide()
      oForm.Formatar()
      oForm.ID_PACIENTE = iID_Pessoa
      FNC_AbriTela(oForm, , True, True)
    End If
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    If Salvar(enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode(), True) Then FNC_Mensagem("Gravação Efetuada")
  End Sub

  Private Sub cmdFinalizar_Clicado(sender As Object) Handles cmdFinalizar.Clicado
    If Salvar(enOpcoes.StatusAtendimentoClinica_Finalizado.GetHashCode(), True) Then
      eStatus = enOpcoes.StatusAtendimentoClinica_Finalizado
      bFinalizado = True

      FNC_Mensagem("Atendimento Concluído")

      Fechar()
    End If
  End Sub

  Private Function Salvar(eID_STATUS As enOpcoes, bGravarHistorico As Boolean, Optional Async As Boolean = False) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    If iID_Pessoa = 0 Then
      FNC_Mensagem("Selecione o paciente")
      GoTo Sair
    End If
    If Not IsDate(txtDataAgendamento.Text) Then
      FNC_Mensagem("Informe a data e hora de lançamento")
      GoTo Sair
    End If
    If iID_Procedimento = 0 Then
      FNC_Mensagem("Informe o procedimento")
      GoTo Sair
    End If
    If rtbDescricao.Text.Trim() = "" And eID_STATUS = enOpcoes.StatusAtendimentoClinica_Finalizado Then
      FNC_Mensagem("Informa o descrição Do atendimento")
      GoTo Sair
    End If

    Dim Parametro() As DBParamentro = {
      DBParametro_Montar("SQ_CLINICA_ATENDIMENTO", iSQ_CLINICA_ATENDIMENTO, , ParameterDirection.InputOutput),
      DBParametro_Montar("CD_CLINICA_ATENDIMENTO", Nothing, , ParameterDirection.InputOutput),
      DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
      DBParametro_Montar("ID_PESSOA", iID_Pessoa),
      DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_USUARIO),
      DBParametro_Montar("ID_PROCEDIMENTO", iID_Procedimento),
      DBParametro_Montar("ID_AGENDAMENTO", iID_AGENDAMENTO),
      DBParametro_Montar("ID_CONSULTORIO", iID_CONSULTORIO),
      DBParametro_Montar("ID_OPT_STATUS", eID_STATUS.GetHashCode()),
      DBParametro_Montar("DH_CLINICA_ATENDIMENTO", txtDataAgendamento.DateTime, SqlDbType.DateTime2),
      DBParametro_Montar("DS_CLINICA_ATENDIMENTO", rtbDescricao.Text, SqlDbType.Text)
    }

    sSqlText = DBMontar_SP("SP_CLINICA_ATENDIMENTO_CAD", False, "@SQ_CLINICA_ATENDIMENTO OUT",
                                                                "@CD_CLINICA_ATENDIMENTO OUT",
                                                                "@ID_EMPRESA",
                                                                "@ID_PESSOA",
                                                                "@ID_PESSOA_PROFISSIONAL",
                                                                "@ID_PROCEDIMENTO",
                                                                "@ID_AGENDAMENTO",
                                                                "@ID_CONSULTORIO",
                                                                "@ID_OPT_STATUS",
                                                                "@DH_CLINICA_ATENDIMENTO",
                                                                "@DS_CLINICA_ATENDIMENTO")

    If Async Then
      DBExecutarAsync(sSqlText, Parametro)
    Else
      If DBExecutar(sSqlText, Parametro) Then
        If DBTeveRetorno() Then
          iSQ_CLINICA_ATENDIMENTO = DBRetorno(1)
          sCD_CLINICA_ATENDIMENTO = DBRetorno(2)
          bOk = True
        End If

        HabilitarBotoes()

        If bGravarHistorico Then FNC_Historico(enOpcoes.Processo_Acao_Alteracao)
      End If
    End If

Sair:
    Return bOk
  End Function

  Private Sub HabilitarBotoes()
    cmdAtestados.Enabled = bEditar
    cmdExames.Enabled = bEditar
    cmdReceituario.Enabled = bEditar
    cmdVascinas.Enabled = bEditar
    cmdRelatorios.Enabled = bEditar
    cmdSalvar.Enabled = bEditar
    cmdFinalizar.Enabled = bEditar
  End Sub

  Private Sub cmdReceituario_Clicado(sender As Object) Handles cmdReceituario.Clicado
    If iSQ_CLINICA_ATENDIMENTO = 0 Then
      If Not Salvar(enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode(), True) Then Exit Sub
    End If

    If iID_Especialidade = cnt_Especialidade_Oftalmologia Then
      Dim oForm As New frmCadastroAtendimentoOftalmologico

      oForm.iID_CLINICA_ATENDIMENTO = iSQ_CLINICA_ATENDIMENTO

      FNC_AbriTela(oForm, , True, True)
    Else
      Receituario()
    End If
  End Sub

  Private Sub Receituario()
    Dim oForm As New frmCadastroAtendimentoReceituario

    oForm.Formatar()
    oForm.iID_CLINICA_ATENDIMENTO = iSQ_CLINICA_ATENDIMENTO
    oForm.bEditar = bEditar

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdAtestados_Clicado(sender As Object) Handles cmdAtestados.Clicado
    If iSQ_CLINICA_ATENDIMENTO = 0 Then
      If Not Salvar(enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode(), True) Then Exit Sub
    End If

    Dim oForm As New frmCadastroAtestado

    oForm.Formatar()
    oForm.iID_CLINICA_ATENDIMENTO = iSQ_CLINICA_ATENDIMENTO
    oForm.bEditar = bEditar

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdRelatorios_Clicado(sender As Object) Handles cmdRelatorios.Clicado
    If iSQ_CLINICA_ATENDIMENTO = 0 Then
      If Not Salvar(enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode(), True) Then Exit Sub
    End If

    Dim oForm As New frmCadastroRelatorio

    oForm.Formatar()
    oForm.iID_CLINICA_ATENDIMENTO = iSQ_CLINICA_ATENDIMENTO

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdExames_Clicado(sender As Object) Handles cmdExames.Clicado
    If iSQ_CLINICA_ATENDIMENTO = 0 Then
      If Not Salvar(enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode(), True) Then Exit Sub
    End If

    Dim oForm As New frmCadastroAtendimentoSolicitacaoExame

    oForm.Formatar()
    oForm.iID_CLINICA_ATENDIMENTO = iSQ_CLINICA_ATENDIMENTO
    oForm.bEditar = bEditar

    FNC_AbriTela(oForm, , True, True, , , False)
  End Sub

  Private Sub cmdVascinas_Clicado(sender As Object) Handles cmdVascinas.Clicado
    If iSQ_CLINICA_ATENDIMENTO = 0 Then
      If Not Salvar(enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode(), True) Then Exit Sub
    End If

    Dim oForm As New frmCadastroAtendimentoSolicitacaoVacina

    oForm.Formatar()
    oForm.iID_CLINICA_ATENDIMENTO = iSQ_CLINICA_ATENDIMENTO
    oForm.bEditar = bEditar

    FNC_AbriTela(oForm, , True, True, , , False)
  End Sub

  Private Sub cmdHistorico_Clicado(sender As Object) Handles cmdHistorico.Clicado
    Dim oForm As New frmCadastroAtendimentoOutrasConsultas

    oForm.Formatar()
    oForm.iID_PESSOA = iID_Pessoa

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub FNC_Historico_Guardar()
    oHistorico.Inicializar()
    oHistorico.Controle_LimparValorAtual()
    oHistorico.Controle_ValorAtual(lblPessoa, lblPessoa.Text)
    oHistorico.Controle_ValorAtual(lblProcedimento, lblProcedimento.Text)
    oHistorico.Controle_ValorAtual(txtDataAgendamento, txtDataAgendamento.Text)
  End Sub

  Private Sub FNC_Historico(iAcao As enOpcoes)
    oHistorico.ID_Registro = iSQ_CLINICA_ATENDIMENTO
    oHistorico.GravarHistorico(enOpcoes.Processo_Historico_Clinica_AtendimentoMedico,
                               iAcao, 0, sCD_CLINICA_ATENDIMENTO, "",
                               New Object() {lblPessoa, lblPessoa.Text,
                                             lblProcedimento, lblProcedimento.Text,
                                             txtDataAgendamento, txtDataAgendamento.Text})

    FNC_Historico_Guardar()
  End Sub

  Private Sub LimparAtendimentos()
    Dim oItem As ListBox

    Try
      For iCont = 1 To 1
        Me.Controls(Me.Controls.IndexOfKey("lblCodigoProcedimento" + FNC_StrZero(iCont, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblDescricaoProcedimento" + FNC_StrZero(iCont, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iCont, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblDataHora" + FNC_StrZero(iCont, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("txtConsultasAnterior" + FNC_StrZero(iCont, 2))).Text = ""
        oItem = Me.Controls(Me.Controls.IndexOfKey("lstExamesSolicitados" + FNC_StrZero(iCont, 2)))
        oItem.Items.Clear()
      Next
    Catch ex As Exception
    End Try
  End Sub

  Private Sub CarregarHistorico()
    Dim oData As DataTable
    Dim oData_Exames As DataTable = New DataTable()
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""
    Dim iIndice As Integer = 0
    Dim iCont As Integer = 0

    Try
      sSqlText = "Select CLATD.SQ_CLINICA_ATENDIMENTO," &
                       "CLATD.DH_CLINICA_ATENDIMENTO," &
                       "PROCE.CD_PROCEDIMENTO," &
                       "PROCE.NO_PROCEDIMENTO," &
                       "PESSO.NO_PESSOA NO_MEDICO," &
                       "CLATD.DS_CLINICA_ATENDIMENTO" &
                " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                 " INNER JOIN TB_PROCEDIMENTO PROCE On PROCE.SQ_PROCEDIMENTO = CLATD.ID_PROCEDIMENTO" &
                 " INNER JOIN TB_PESSOA PESSO On PESSO.SQ_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                " WHERE CLATD.ID_PESSOA_PROFISSIONAL = " & iID_USUARIO.ToString() &
                  " And CLATD.SQ_CLINICA_ATENDIMENTO Not In (" & iSQ_CLINICA_ATENDIMENTO.ToString() & ")" &
                  " And CLATD.ID_PESSOA = " & iID_Pessoa.ToString() &
                  " And CLATD.DS_CLINICA_ATENDIMENTO Is Not NULL" &
                " ORDER BY CLATD.DH_CLINICA_ATENDIMENTO DESC"
      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        oAtendimento = Nothing
      Else
        ReDim oAtendimento(oData.Rows.Count - 1)

        For Each oRow As DataRow In oData.Rows
          oAtendimento(iIndice) = New cAtendimento()

          With oAtendimento(iIndice)
            .CD_PROCEDIMENTO = oRow.Item("CD_PROCEDIMENTO")
            .NO_PROCEDIMENTO = FNC_NVL(oRow.Item("NO_PROCEDIMENTO"), "")
            .NO_MEDICO = oRow.Item("NO_MEDICO")
            .DH_CLINICA_ATENDIMENTO = oRow.Item("DH_CLINICA_ATENDIMENTO")
            .DESCRICAO = FNC_NVL(oRow.Item("DS_CLINICA_ATENDIMENTO"), "")
          End With

          sSqlText = "Select 'Receituário : ' + CONVERT(VARCHAR, DT_LANCAMENTO, 103) DS_TITULO," +
                             "DS_RECEITUARIO" +
                     " FROM TB_CLINICA_RECEITUARIO" +
                     " WHERE ID_CLINICA_ATENDIMENTO = " & oRow.Item("SQ_CLINICA_ATENDIMENTO")
          oData_Exames = DBQuery(sSqlText)

          If Not objDataTable_Vazio(oData_Exames) Then
            If oAtendimento(iIndice).DESCRICAO.Trim() <> "" Then
              oAtendimento(iIndice).DESCRICAO = oAtendimento(iIndice).DESCRICAO + Environment.NewLine
            End If

            For Each oRowExame As DataRow In oData_Exames.Rows
              FNC_Str_Adicionar(oAtendimento(iIndice).DESCRICAO, oRowExame.Item("DS_TITULO") + " " + oRowExame.Item("DS_RECEITUARIO"), Environment.NewLine)
            Next
          End If

          sSqlText = "SELECT CONCAT(PROCE.CD_PROCEDIMENTO, ' - ', PROCE.NO_PROCEDIMENTO) DS_PROCEDIMENTO" &
                       " FROM TB_CLINICA_PROCEDIMENTO CLPCD" &
                        " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO" &
                       " WHERE CLPCD.ID_CLINICA_ATENDIMENTO = " & oRow.Item("SQ_CLINICA_ATENDIMENTO") &
                       " UNION ALL " &
                       "SELECT 'Exame Citológico'" &
                       " FROM TB_CLINICA_EXAME_CITOLOGICO" &
                       " WHERE ID_CLINICA_ATENDIMENTO = " & oRow.Item("SQ_CLINICA_ATENDIMENTO")
          oData_Exames = DBQuery(sSqlText)

          If Not objDataTable_Vazio(oData_Exames) Then
            ReDim oAtendimento(iIndice).EXAMES_SOLICITADOS(oData_Exames.Rows.Count - 1)

            iCont = 0

            If oAtendimento(iIndice).DESCRICAO.Trim() <> "" Then
              oAtendimento(iIndice).DESCRICAO = oAtendimento(iIndice).DESCRICAO + Environment.NewLine + Environment.NewLine
            End If

            oAtendimento(iIndice).DESCRICAO = oAtendimento(iIndice).DESCRICAO + “Exames Solicitados” + Environment.NewLine

            For Each oRowExame As DataRow In oData_Exames.Rows
              FNC_Str_Adicionar(oAtendimento(iIndice).DESCRICAO, oRowExame.Item("DS_PROCEDIMENTO"), Environment.NewLine)

              oAtendimento(iIndice).EXAMES_SOLICITADOS(iCont) = oRowExame.Item("DS_PROCEDIMENTO")

              iCont = iCont + 1
            Next
          End If

          iIndice = iIndice + 1
        Next

        oData.Dispose()
        oData_Exames.Dispose()
      End If

      If oAtendimento Is Nothing Then
        VScrollBar.Enabled = False
        LimparAtendimentos()
      Else
        VScrollBar.Enabled = (oAtendimento.Length > 1)
        VScrollBar.Maximum = oAtendimento.Length
      End If

      VScrollBar.Value = 1

      ListarAtendimentos()
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Private Function Atendimentos_Carregado() As Boolean
    If oAtendimento Is Nothing Then
      Return False
    Else
      Return (oAtendimento.Count > 0)
    End If
  End Function

  Private Sub ListarAtendimentos()
    Dim oItem As ListBox
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    If Atendimentos_Carregado() Then
      For iCont = VScrollBar.Value - 1 To VScrollBar.Value - 1
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblCodigoProcedimento" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).CD_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblDescricaoProcedimento" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).NO_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).NO_MEDICO
          Me.Controls(Me.Controls.IndexOfKey("lblDataHora" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).DH_CLINICA_ATENDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("txtConsultasAnterior" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).DESCRICAO

          Try
            oItem = Me.pnlExamesSolicitadosDetalhe.Controls(Me.pnlExamesSolicitadosDetalhe.Controls.IndexOfKey("lstExamesSolicitados" + FNC_StrZero(iLabel, 2)))
            oItem.Items.Clear()

            If Not oAtendimento(iCont).EXAMES_SOLICITADOS Is Nothing Then
              For Each oItemExame As String In oAtendimento(iCont).EXAMES_SOLICITADOS
                oItem.Items.Add(oItemExame)
              Next
            End If
          Catch ex As Exception
          End Try
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblCodigoProcedimento" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblDescricaoProcedimento" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblDataHora" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("txtConsultasAnterior" + FNC_StrZero(iLabel, 2))).Text = ""
          oItem = Me.Controls(Me.Controls.IndexOfKey("lstExamesSolicitados" + FNC_StrZero(iLabel, 2)))
          oItem.Items.Clear()
        End Try

        iLabel = iLabel + 1
      Next
    End If
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    ListarAtendimentos()
  End Sub

  Private Sub cmdExamesSolicitadosFechar_Click(sender As Object, e As EventArgs) Handles cmdExamesSolicitadosFechar.Click
    pnlExamesSolicitados.Visible = False
  End Sub

  Private Sub cmdExamesSolicitadosExibir_Click(sender As Object, e As EventArgs) Handles cmdExamesSolicitadosExibir.Click
    pnlExamesSolicitados.Visible = Not pnlExamesSolicitados.Visible
  End Sub

  Private Sub frmCadastroAtendimento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    Me.WindowState = FormWindowState.Maximized
    Me.BringToFront()
    Me.Height = oFormMDI.ClientSize.Height
    Me.Width = oFormMDI.ClientSize.Width
    Me.Left = 0
    Me.Top = 0
  End Sub

  Private Sub frmCadastroAtendimento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    Me.Height = oFormMDI.ClientSize.Height
    Me.Width = oFormMDI.ClientSize.Width
    Me.Left = 0
    Me.Top = 0
  End Sub

  Private Sub rtbDescricao_TextChanged(sender As Object, e As EventArgs) Handles rtbDescricao.TextChanged
    Salvar(enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode(), False, False)
  End Sub

  Private Sub frmCadastroAtendimento_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.F3 Then
      Receituario()
    End If
  End Sub
End Class