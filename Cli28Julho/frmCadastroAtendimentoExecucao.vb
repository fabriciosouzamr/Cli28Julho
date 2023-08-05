Public Class frmCadastroAtendimentoExecucao
  Class Listagem
    Public SQ_AGENDAMENTO As Integer
    Public ID_OPT_STATUS As Integer
    Public Hora As String
    Public Pessoa As String
    Public Idade As String
    Public Medico As String
    Public Status As String
    Public Atendido As Boolean
  End Class

  Dim iCmdFechar_Left As Integer
  Dim iCmdChamar_Left As Integer
  Dim iCmdAtender_Left As Integer
  Dim iCmdAtualizar_Left As Integer
  Dim iExecutor_Left As Integer
  Dim iTxtDataPesquisa_Left As Integer
  Dim iTxtHora_Left As Integer
  Dim iLblPaciente_Left As Integer
  Dim iLblIdade_Left As Integer
  Dim iLblMedico_Left As Integer
  Dim iLblStatus_Left As Integer
  Dim iVScrollBar_Left As Integer

  Dim bCarregado As Boolean = False

  Dim cListagem As Listagem()

  Private Sub frmCadastroAtendimentoExecucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_Executor_Atendimento))

    cmdAtualizar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atualizar)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdChamar01.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar02.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar03.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar04.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar05.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar06.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar07.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar08.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar09.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar10.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar11.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar12.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar13.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdAtender01.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender02.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender03.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender04.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender05.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender06.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender07.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender08.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender09.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender10.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender11.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender12.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    cmdAtender13.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)

    iCmdFechar_Left = cmdFechar.Left
    iCmdChamar_Left = cmdChamar01.Left
    iCmdAtender_Left = cmdAtender01.Left
    iCmdAtualizar_Left = cmdAtualizar.Left
    iExecutor_Left = lblExecutor.Left
    iTxtDataPesquisa_Left = txtDataPesquisa.Left
    iTxtHora_Left = txtHora01.Left
    iLblPaciente_Left = lblPaciente01.Left
    iLblIdade_Left = lblIdade01.Left
    iLblMedico_Left = lblMedico01.Left
    iLblStatus_Left = lblStatus01.Left
    iVScrollBar_Left = VScrollBar.Left

    lblExecutor.Text = sNO_USUARIO
    txtDataPesquisa.DateTime = Now()

    Botao_Posicionar()
    Limpar()

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1

    ComboBox_Carregar(cboMedico, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboConsultorio, enSql.Consultorio)
    Carregar()

    bCarregado = True
  End Sub

  Private Sub frmConsultaAtendimento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    picGeral.Left = (Me.Width - picGeral.Width) / 2

    If bCarregado Then
      Botao_Posicionar()
    End If
  End Sub

  Private Sub Botao_Posicionar()
    cmdAtualizar.Left = picGeral.Left - 5 + iCmdAtualizar_Left
    cmdFechar.Left = picGeral.Left - 5 + iCmdFechar_Left
    lblExecutor.Left = picGeral.Left - 5 + iExecutor_Left
    cmdChamar01.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar02.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar03.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar04.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar05.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar06.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar07.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar08.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar09.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar10.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar11.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar12.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdChamar13.Left = picGeral.Left - 5 + iCmdChamar_Left
    cmdAtender01.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender02.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender03.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender04.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender05.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender06.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender07.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender08.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender09.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender10.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender11.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender12.Left = picGeral.Left - 5 + iCmdAtender_Left
    cmdAtender13.Left = picGeral.Left - 5 + iCmdAtender_Left
    txtDataPesquisa.Left = picGeral.Left - 5 + iTxtDataPesquisa_Left
    txtHora01.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora02.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora03.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora04.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora05.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora06.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora07.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora08.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora09.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora10.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora11.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora12.Left = picGeral.Left - 5 + iTxtHora_Left
    txtHora13.Left = picGeral.Left - 5 + iTxtHora_Left
    lblPaciente01.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente02.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente03.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente04.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente05.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente06.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente07.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente08.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente09.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente10.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente11.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente12.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblPaciente13.Left = picGeral.Left - 5 + iLblPaciente_Left
    lblIdade01.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade02.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade03.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade04.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade05.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade06.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade07.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade08.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade09.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade10.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade11.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade12.Left = picGeral.Left - 5 + iLblIdade_Left
    lblIdade13.Left = picGeral.Left - 5 + iLblIdade_Left
    lblMedico01.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico02.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico03.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico04.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico05.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico06.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico07.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico08.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico09.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico10.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico11.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico12.Left = picGeral.Left - 5 + iLblMedico_Left
    lblMedico13.Left = picGeral.Left - 5 + iLblMedico_Left
    lblStatus01.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus02.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus03.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus04.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus05.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus06.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus07.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus08.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus09.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus10.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus11.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus12.Left = picGeral.Left - 5 + iLblStatus_Left
    lblStatus13.Left = picGeral.Left - 5 + iLblStatus_Left
    VScrollBar.Left = picGeral.Left - 5 + iVScrollBar_Left
  End Sub

  Private Sub Limpar()
    lblPaciente01.Text = ""
    lblPaciente02.Text = ""
    lblPaciente03.Text = ""
    lblPaciente04.Text = ""
    lblPaciente05.Text = ""
    lblPaciente06.Text = ""
    lblPaciente07.Text = ""
    lblPaciente08.Text = ""
    lblPaciente09.Text = ""
    lblPaciente10.Text = ""
    lblPaciente11.Text = ""
    lblPaciente12.Text = ""
    lblPaciente13.Text = ""
    lblIdade01.Text = ""
    lblIdade02.Text = ""
    lblIdade03.Text = ""
    lblIdade04.Text = ""
    lblIdade05.Text = ""
    lblIdade06.Text = ""
    lblIdade07.Text = ""
    lblIdade08.Text = ""
    lblIdade09.Text = ""
    lblIdade10.Text = ""
    lblIdade11.Text = ""
    lblIdade12.Text = ""
    lblIdade13.Text = ""
    lblMedico01.Text = ""
    lblMedico02.Text = ""
    lblMedico03.Text = ""
    lblMedico04.Text = ""
    lblMedico05.Text = ""
    lblMedico06.Text = ""
    lblMedico07.Text = ""
    lblMedico08.Text = ""
    lblMedico09.Text = ""
    lblMedico10.Text = ""
    lblMedico11.Text = ""
    lblMedico12.Text = ""
    lblMedico13.Text = ""
    lblStatus01.Text = ""
    lblStatus02.Text = ""
    lblStatus03.Text = ""
    lblStatus04.Text = ""
    lblStatus05.Text = ""
    lblStatus06.Text = ""
    lblStatus07.Text = ""
    lblStatus08.Text = ""
    lblStatus09.Text = ""
    lblStatus10.Text = ""
    lblStatus11.Text = ""
    lblStatus12.Text = ""
    lblStatus13.Text = ""
    cmdChamar01.Visible = False
    cmdChamar02.Visible = False
    cmdChamar03.Visible = False
    cmdChamar04.Visible = False
    cmdChamar05.Visible = False
    cmdChamar06.Visible = False
    cmdChamar07.Visible = False
    cmdChamar08.Visible = False
    cmdChamar09.Visible = False
    cmdChamar10.Visible = False
    cmdChamar11.Visible = False
    cmdChamar12.Visible = False
    cmdChamar13.Visible = False
    cmdAtender01.Visible = False
    cmdAtender02.Visible = False
    cmdAtender03.Visible = False
    cmdAtender04.Visible = False
    cmdAtender05.Visible = False
    cmdAtender06.Visible = False
    cmdAtender07.Visible = False
    cmdAtender08.Visible = False
    cmdAtender09.Visible = False
    cmdAtender10.Visible = False
    cmdAtender11.Visible = False
    cmdAtender12.Visible = False
    cmdAtender13.Visible = False
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub Carregar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer = 0

    sSqlText = "SELECT AGEND.SQ_AGENDAMENTO," &
                      "AGEND.ID_OPT_STATUS," &
                      "FORMAT(AGEND.DH_AGENDAMENTO, 'HH:mm') DH_AGENDAMENTO," &
                      "PESSO.NO_PESSOA," &
                      "DBO.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'N') IDADE," &
                      "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                      "OPCAO_STATU.NO_OPCAO NO_OPT_STATUS," &
                      "FORMAT(AGEND.DH_CHEGADA, 'HH:mm:ss') DH_CHEGADA," &
                      "AGEND.DH_EXECUTOR_ATENDIMENTO" &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" &
                " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN TB_TIPO_CONSULTA TPCST ON TPCST.SQ_TIPO_CONSULTA = AGEND.ID_TIPO_CONSULTA" &
                " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = AGEND.ID_OPT_STATUS" &
                                               " AND SQ_OPCAO IN (" & enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode() & "," &
                                                                      enOpcoes.StatusAgendamento_Atendido.GetHashCode() & ")" &
                 " LEFT JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPCD ON CVPCD.ID_AGENDAMENTO = AGEND.SQ_AGENDAMENTO" &
                 " LEFT JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = CVPCD.ID_CLINICA_VENDA" &
                                                 " AND CLVND.DH_CANCELAR IS NULL" &
               " WHERE CAST(AGEND.DH_AGENDAMENTO AS DATE) = " & FNC_QuotedStr(txtDataPesquisa.Text) &
                 " AND AGEND.ID_PESSOA_EXECUTOR IS NOT NULL" &
                 " AND AGEND.ID_EMPRESA = " & iID_EMPRESA_FILIAL

    If psqProcedimento.Identificador > 0 Then
      sSqlText = sSqlText & " AND AGEND.ID_PROCEDIMENTO = " & psqProcedimento.Identificador
    End If
    If ComboBox_Selecionado(cboMedico) Then
      sSqlText = sSqlText & " AND AGEND.ID_PESSOA_PROFISSIONAL = " & cboMedico.SelectedValue
    End If

    sSqlText = sSqlText &
               " ORDER BY ISNULL(CLVND.DH_VENDA, AGEND.DH_AGENDAMENTO)"
    oData = DBQuery(sSqlText)

    If oData.Rows.Count > 0 Then
      ReDim cListagem(oData.Rows.Count - 1)

      For Each oRow As DataRow In oData.Rows
        cListagem(iCont) = New Listagem()

        With cListagem(iCont)
          .SQ_AGENDAMENTO = oRow.Item("SQ_AGENDAMENTO")
          .ID_OPT_STATUS = oRow.Item("ID_OPT_STATUS")
          .Hora = oRow.Item("DH_AGENDAMENTO")
          .Pessoa = oRow.Item("NO_PESSOA")
          .Idade = oRow.Item("IDADE")
          .Medico = oRow.Item("NO_PESSOA_PROFISSIONAL")
          .Status = oRow.Item("NO_OPT_STATUS")
          .Atendido = (Not FNC_CampoNulo(oRow.Item("DH_EXECUTOR_ATENDIMENTO")))
        End With

        iCont = iCont + 1
      Next
    Else
      cListagem = Nothing
    End If

    If cListagem Is Nothing Then
      VScrollBar.Enabled = False
      VScrollBar.Maximum = 1
    Else
      VScrollBar.Enabled = (cListagem.Length > 13)
      If cListagem.Length - 13 > 0 Then VScrollBar.Maximum = cListagem.Length - 12 Else VScrollBar.Maximum = 1
    End If

    Try
      VScrollBar.Value = 1
    Catch ex As Exception
    End Try

    Listar()
  End Sub

  Private Sub Listar()
    If Not bCarregado Then Exit Sub

    Dim iCont As Integer
    Dim iControle As Integer

    Dim oTxtHora As uscHora
    Dim oPaciente As Label
    Dim oIdade As Label
    Dim oMedico As Label
    Dim oStatus As Label
    Dim oBotaoChamar As uscBotao
    Dim oBotaoAtender As uscBotao

    Limpar()

    iControle = 1

    For iCont = VScrollBar.Value - 1 To VScrollBar.Value + 11
      oTxtHora = Me.Controls(Me.Controls.IndexOfKey("txtHora" + FNC_StrZero(iControle, 2)))
      oPaciente = Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iControle, 2)))
      oIdade = Me.Controls(Me.Controls.IndexOfKey("lblIdade" + FNC_StrZero(iControle, 2)))
      oMedico = Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iControle, 2)))
      oStatus = Me.Controls(Me.Controls.IndexOfKey("lblStatus" + FNC_StrZero(iControle, 2)))
      oBotaoChamar = Me.Controls(Me.Controls.IndexOfKey("cmdChamar" + FNC_StrZero(iControle, 2)))
      oBotaoAtender = Me.Controls(Me.Controls.IndexOfKey("cmdAtender" + FNC_StrZero(iControle, 2)))

      Try
        oTxtHora.Tag = cListagem(iCont).SQ_AGENDAMENTO
        oTxtHora.Hora = cListagem(iCont).Hora
        oPaciente.Text = cListagem(iCont).Pessoa
        oIdade.Text = cListagem(iCont).Idade
        oMedico.Text = cListagem(iCont).Medico
        oStatus.Tag = cListagem(iCont).ID_OPT_STATUS
        oStatus.Text = cListagem(iCont).Status
        oBotaoChamar.Visible = True
        oBotaoAtender.Visible = (Not cListagem(iCont).Atendido)
      Catch ex As Exception
        oTxtHora.Tag = 0
        oTxtHora.Hora = ""
        oPaciente.Text = ""
        oIdade.Text = ""
        oMedico.Text = ""
        oStatus.Tag = 0
        oStatus.Text = ""
        oBotaoChamar.Visible = False
        oBotaoAtender.Visible = False
      End Try

      iControle = iControle + 1
    Next
  End Sub

  Private Sub txtDataPesquisa_ValueChanged(sender As Object, e As EventArgs) Handles txtDataPesquisa.ValueChanged
    Carregar()
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    Listar()
  End Sub

  Private Sub cmdAtender_Clicado(sender As Object) Handles cmdAtender01.Clicado, cmdAtender02.Clicado, cmdAtender03.Clicado,
                                                           cmdAtender04.Clicado, cmdAtender05.Clicado, cmdAtender06.Clicado,
                                                           cmdAtender07.Clicado, cmdAtender08.Clicado, cmdAtender09.Clicado,
                                                           cmdAtender10.Clicado, cmdAtender11.Clicado, cmdAtender12.Clicado,
                                                           cmdAtender13.Clicado
    Dim oBotao As uscBotao
    Dim oHora As uscHora
    Dim oPaciente As Label
    Dim sSqlText As String
    Dim sHistorico As String

    oBotao = sender

    oHora = Me.Controls("txtHora" + oBotao.Name.Substring(10, 2))
    oPaciente = Me.Controls("lblPaciente" + oBotao.Name.Substring(10, 2))

    If Not FNC_Perguntar("Deseja realmente marcar como atendido o procedimento de " + oPaciente.Text + " como atendido?") Then
      Exit Sub
    End If

    sHistorico = "Execução realizada por " & lblExecutor.Text

    FNC_Historico_Incluir(enOpcoes.Processo_Historico_Clinica_Agendamento, enOpcoes.Processo_Acao_Alteracao, 0, oHora.Tag, sHistorico, "")

    sSqlText = DBMontar_SP("SP_AGENDAMENTO_EXECUTOR_ATENDIMENTO_UPD", False, "@SQ_AGENDAMENTO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", oHora.Tag))

    Carregar()
  End Sub

  Private Sub cmdAtualizar_Clicado(sender As Object) Handles cmdAtualizar.Clicado
    Carregar()
  End Sub

  Private Sub cboMedico_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMedico.KeyDown
    If e.KeyCode = Keys.Delete Then cboMedico.SelectedIndex = -1
  End Sub

  Private Sub cmdChamar_Clicado(sender As Object) Handles cmdChamar01.Clicado, cmdChamar02.Clicado, cmdChamar03.Clicado, cmdChamar04.Clicado, cmdChamar05.Clicado, cmdChamar06.Clicado, cmdChamar07.Clicado,
                                                          cmdChamar08.Clicado, cmdChamar09.Clicado, cmdChamar10.Clicado, cmdChamar11.Clicado, cmdChamar12.Clicado, cmdChamar13.Clicado
    Dim oBotao As uscBotao
    Dim sURL As String
    Dim iUnidade As Integer

    If Not ComboBox_Selecionado(cboConsultorio) Then
      FNC_Mensagem("Selecione o consultório")
      Exit Sub
    End If

    If iID_EMPRESA_FILIAL = iID_EMPRESA_MATRIZ Then
      iUnidade = 1
    Else
      iUnidade = 2
    End If

    oBotao = sender

    Try
      sURL = sSISTEMA_LlinkChamarCliente.Replace("[Paciente]", Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + oBotao.Name.Substring(9, 2))).Text) _
                                        .Replace("[Unidade]", iUnidade) _
                                        .Replace("[Consultorio]", cboConsultorio.SelectedItem(enComboBox_Consultorio.CD_CONSULTORIO))

      FNC_URL_Executar(sURL)

      FNC_Mensagem("Paciente chamado com sucesso!")
    Catch ex As Exception
      FNC_Mensagem("ERRO: " & ex.Message)
    End Try
  End Sub
End Class