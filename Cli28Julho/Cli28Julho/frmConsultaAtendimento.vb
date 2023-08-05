Imports System.ComponentModel
Imports System.Threading

Public Class frmConsultaAtendimento
  Class Listagem
    Public SQ_AGENDAMENTO As Integer
    Public ID_OPT_STATUS As Integer
    Public Numero As Integer
    Public Pessoa As String
    Public Idade As String
    Public TipoAtendimento As String
    Public Status As String
    Public ConfirmacaoChegada As String
  End Class

  Dim iCmdAtendimentosRealizados_Left As Integer
  Dim iCmdFechar_Left As Integer
  Dim iConsultaAtendimento_Item_Left As Integer
  Dim iVScrollBar_Left As Integer
  Dim iCboEspecialidade_Left As Integer
  Dim iCboConsultorio_Left As Integer
  Dim iCboTurno_Left As Integer
  Dim iTxtDataPesquisa_Left As Integer
  Dim iLblRAtendimentoDisponivel_Left As Integer
  Dim iLblAtendimentoDisponivel_Left As Integer
  Dim iChkFiltroConsulta_Left As Integer
  Dim iChkFiltroExame_Left As Integer
  Dim iChkFiltroRetorno_Left As Integer

  Dim bCarregado As Boolean = False

  Dim cListagem As Listagem()

  Dim oThAtualizar As Thread
  Dim iQT_LinhaAtendimento As Integer

  Private Sub frmConsultaAtendimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    bCarregado = False

    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_TelaInicial))

    cmdAtendimentosRealizados.Formatar(enOpcoes.ConfiguracaoTela_Botao_AtendimentosRealizadosTelaMedico)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_FecharTelaMedico)

    iCmdAtendimentosRealizados_Left = cmdAtendimentosRealizados.Left
    iCmdFechar_Left = cmdFechar.Left
    iConsultaAtendimento_Item_Left = oConsultaAtendimento_Item01.Left
    iVScrollBar_Left = VScrollBar.Left
    iCboEspecialidade_Left = cboEspecialidade.Left
    iCboConsultorio_Left = cboConsultorio.Left
    iCboTurno_Left = cboTurno.Left
    iTxtDataPesquisa_Left = txtDataPesquisa.Left
    iLblRAtendimentoDisponivel_Left = lblRAtendimentoDisponivel.Left
    iLblAtendimentoDisponivel_Left = lblAtendimentoDisponivel.Left
    iChkFiltroConsulta_Left = chkFiltroConsulta.Left
    iChkFiltroExame_Left = chkFiltroExame.Left
    iChkFiltroRetorno_Left = chkFiltroRetorno.Left

    Botao_Posicionar()
    Limpar()

    oConsultaAtendimento_Item01.Formatar()
    oConsultaAtendimento_Item02.Formatar()
    oConsultaAtendimento_Item03.Formatar()
    oConsultaAtendimento_Item04.Formatar()
    oConsultaAtendimento_Item05.Formatar()
    oConsultaAtendimento_Item06.Formatar()
    oConsultaAtendimento_Item07.Formatar()
    oConsultaAtendimento_Item08.Formatar()
    oConsultaAtendimento_Item09.Formatar()
    oConsultaAtendimento_Item10.Formatar()
    oConsultaAtendimento_Item11.Formatar()
    oConsultaAtendimento_Item12.Formatar()

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1

    ComboBox_Carregar(cboTurno, enSql.Turno)
    ComboBox_Carregar(cboConsultorio, enSql.Consultorio)
    ComboBox_Carregar(cboEspecialidade, enSql.Profissional_Especilidade, New Object() {iID_USUARIO})

    bCarregado = True

    txtDataPesquisa.DateTime = Now()

    CheckForIllegalCrossThreadCalls = False

    oThAtualizar = New Thread(AddressOf ThAtualizar)
    oThAtualizar.Start()
  End Sub

  Private Sub ThAtualizar()
    While True
      Carregar()
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
      Try
        Thread.CurrentThread.Sleep(100000)
      Catch ex As Exception
      End Try
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
    End While
  End Sub

  Private Sub frmConsultaAtendimento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    Try
      picGeral.Left = (Me.Width - picGeral.Width) / 2

      If bCarregado Then
        Botao_Posicionar()
      End If

      Me.Left = 0
      Me.Top = 0
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Botao_Posicionar()
    cboEspecialidade.Left = picGeral.Left - 5 + iCboEspecialidade_Left
    cboConsultorio.Left = picGeral.Left - 5 + iCboConsultorio_Left
    cboTurno.Left = picGeral.Left - 5 + iCboTurno_Left
    cmdAtendimentosRealizados.Left = picGeral.Left - 5 + iCmdAtendimentosRealizados_Left
    cmdFechar.Left = picGeral.Left - 5 + iCmdFechar_Left
    lblAtendimentoDisponivel.Left = picGeral.Left - 5 + iLblAtendimentoDisponivel_Left
    lblRAtendimentoDisponivel.Left = picGeral.Left - 5 + iLblRAtendimentoDisponivel_Left
    oConsultaAtendimento_Item01.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item02.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item03.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item04.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item05.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item06.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item07.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item08.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item09.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item10.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item11.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    oConsultaAtendimento_Item12.Left = picGeral.Left - 5 + iConsultaAtendimento_Item_Left
    chkFiltroConsulta.Left = picGeral.Left - 5 + iChkFiltroConsulta_Left
    chkFiltroExame.Left = picGeral.Left - 5 + iChkFiltroExame_Left
    chkFiltroRetorno.Left = picGeral.Left - 5 + iChkFiltroRetorno_Left

    txtDataPesquisa.Left = picGeral.Left - 5 + iTxtDataPesquisa_Left
    VScrollBar.Left = picGeral.Left - 5 + iVScrollBar_Left
  End Sub

  Private Sub Limpar()
    oConsultaAtendimento_Item01.Limpar()
    oConsultaAtendimento_Item02.Limpar()
    oConsultaAtendimento_Item03.Limpar()
    oConsultaAtendimento_Item04.Limpar()
    oConsultaAtendimento_Item05.Limpar()
    oConsultaAtendimento_Item06.Limpar()
    oConsultaAtendimento_Item07.Limpar()
    oConsultaAtendimento_Item08.Limpar()
    oConsultaAtendimento_Item09.Limpar()
    oConsultaAtendimento_Item10.Limpar()
    oConsultaAtendimento_Item11.Limpar()
    oConsultaAtendimento_Item12.Limpar()
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Sub Carregar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim sSqlText2 As String = ""
    Dim iCont As Integer = 0
    Dim sDH_AGENDAMENTO_INI As String
    Dim sDH_AGENDAMENTO_FIM As String
    Dim bTurnoSelecionado As Boolean = False

    If Not bCarregado Then Exit Sub

    cmdFechar.Enabled = False

    Try
      If cboTurno.SelectedIndex > -1 Then
        If cboConsultorio.SelectedValue <> -1 Then
          bTurnoSelecionado = True
        End If
      End If

      If Not bTurnoSelecionado Then
        sDH_AGENDAMENTO_INI = txtDataPesquisa.DateTime.Date & " 00:00:00"
        sDH_AGENDAMENTO_FIM = txtDataPesquisa.DateTime.Date & " 23:59:00"
      Else
        sDH_AGENDAMENTO_INI = txtDataPesquisa.DateTime.Date & " " & cboTurno.SelectedItem(enComboBox_Turno.HR_INICIO)
        sDH_AGENDAMENTO_FIM = txtDataPesquisa.DateTime.Date & " " & cboTurno.SelectedItem(enComboBox_Turno.NR_FIM)
      End If

      sSqlText = "SELECT AGEND.SQ_AGENDAMENTO," &
                        "AGEND.ID_EMPRESA," &
                        "AGEND.ID_OPT_STATUS," &
                        "FORMAT(AGEND.DH_AGENDAMENTO, 'HH:mm') DH_AGENDAMENTO," &
                        "PESSO.NO_PESSOA," &
                        "DBO.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') IDADE," &
                        "PROCE.NO_PROCEDIMENTO," &
                        "OPCAO_STATU.NO_OPCAO NO_OPT_STATUS," &
                        "FORMAT(AGEND.DH_CHEGADA, 'HH:mm:ss') DH_CHEGADA" &
                 " FROM TB_AGENDAMENTO AGEND" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                  " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = AGEND.ID_OPT_STATUS" &
                                                 " AND OPCAO_STATU.SQ_OPCAO IN (" & enOpcoes.StatusAgendamento_Agendado.GetHashCode() & "," &
                                                                                    enOpcoes.StatusAgendamento_Atendido.GetHashCode() & "," &
                                                                                    enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode() & "," &
                                                                                    enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode() & ")" &
                   " LEFT JOIN (SELECT CLVND.DH_VENDA, CLVCN.ID_AGENDAMENTO" &
                               " FROM TB_CLINICA_VENDA CLVND" &
                                " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CLVCN ON CLVCN.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                               " WHERE CLVND.DH_CANCELAR IS NULL) CLVND ON CLVND.ID_AGENDAMENTO = AGEND.SQ_AGENDAMENTO" &
                 " WHERE AGEND.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " AND AGEND.DH_AGENDAMENTO >= " & FNC_QuotedStr(sDH_AGENDAMENTO_INI) &
                   " AND AGEND.DH_AGENDAMENTO <= " & FNC_QuotedStr(sDH_AGENDAMENTO_FIM) &
                   " AND AGEND.ID_PESSOA_EXECUTOR IS NULL" &
                   " AND AGEND.ID_PESSOA_PROFISSIONAL = " & iID_USUARIO.ToString()

      If chkFiltroConsulta.Checked Or chkFiltroExame.Checked Or chkFiltroRetorno.Checked Then
        sSqlText2 = " (AGEND.ID_OPT_STATUS NOT IN (" & enOpcoes.StatusAgendamento_Atendido.GetHashCode() & ") AND " &
                      "AGEND.ID_TIPO_CONSULTA IN (" & IIf(chkFiltroConsulta.Checked, chkFiltroConsulta.Tag, 0) & "," &
                                                      IIf(chkFiltroExame.Checked, chkFiltroExame.Tag, 0) & "," &
                                                      IIf(chkFiltroRetorno.Checked, chkFiltroRetorno.Tag, 0) & "))"
      End If

      If chkAtendidos.Checked Then
        If sSqlText2 <> "" Then
          sSqlText = sSqlText &
                   " AND (AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Atendido.GetHashCode() & " OR " & sSqlText2 & ")"
        Else
          sSqlText = sSqlText &
                   " AND AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Atendido.GetHashCode()
        End If
      Else
        If sSqlText2 <> "" Then
          sSqlText = sSqlText &
                     " AND " & sSqlText2
        Else
          sSqlText = sSqlText &
                   " AND AGEND.ID_OPT_STATUS = 0"
        End If
      End If

      If ComboBox_Selecionado(cboEspecialidade) Then
        If cboEspecialidade.SelectedValue <> -1 Then
          sSqlText = sSqlText &
                   " AND AGEND.ID_ESPECIALIDADE = " & FNC_NVL(cboEspecialidade.SelectedValue, 0).ToString()
        End If
      End If

      sSqlText = sSqlText &
                 " ORDER BY IIF(AGEND.ID_OPT_STATUS IN (" & enOpcoes.StatusAgendamento_Atendido.GetHashCode() & "," &
                                                            enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode() & "), 0, 1)," &
                           "IIF(ISNULL(AGEND.DH_PAGAMENTO, CLVND.DH_VENDA) IS NULL, 1, 0)," &
                           "ISNULL(AGEND.DH_PAGAMENTO, CLVND.DH_VENDA)," &
                           "AGEND.DH_AGENDAMENTO"
      oData = DBQuery(sSqlText)

      If oData.Rows.Count > iQT_LinhaAtendimento Then
        iQT_LinhaAtendimento = oData.Rows.Count
      End If

      oConsultaAtendimento_Item01.Visible = (iQT_LinhaAtendimento > 0)
      oConsultaAtendimento_Item02.Visible = (iQT_LinhaAtendimento > 1)
      oConsultaAtendimento_Item03.Visible = (iQT_LinhaAtendimento > 2)
      oConsultaAtendimento_Item04.Visible = (iQT_LinhaAtendimento > 3)
      oConsultaAtendimento_Item05.Visible = (iQT_LinhaAtendimento > 4)
      oConsultaAtendimento_Item06.Visible = (iQT_LinhaAtendimento > 5)
      oConsultaAtendimento_Item07.Visible = (iQT_LinhaAtendimento > 6)
      oConsultaAtendimento_Item08.Visible = (iQT_LinhaAtendimento > 7)
      oConsultaAtendimento_Item09.Visible = (iQT_LinhaAtendimento > 8)
      oConsultaAtendimento_Item10.Visible = (iQT_LinhaAtendimento > 9)
      oConsultaAtendimento_Item11.Visible = (iQT_LinhaAtendimento > 10)
      oConsultaAtendimento_Item12.Visible = (iQT_LinhaAtendimento > 11)

      If iQT_LinhaAtendimento - oData.Rows.Count > 0 Then
        lblAtendimentoDisponivel.Text = iQT_LinhaAtendimento - oData.Rows.Count
      Else
        lblAtendimentoDisponivel.Text = 0
      End If

      If oData.Rows.Count > 0 Then
        ReDim cListagem(oData.Rows.Count - 1)

        For Each oRow As DataRow In oData.Rows
          cListagem(iCont) = New Listagem()

          With cListagem(iCont)
            .SQ_AGENDAMENTO = oRow.Item("SQ_AGENDAMENTO")
            .Numero = iCont + 1
            .ID_OPT_STATUS = oRow.Item("ID_OPT_STATUS")
            .Pessoa = oRow.Item("NO_PESSOA")
            .Idade = oRow.Item("IDADE")
            .TipoAtendimento = oRow.Item("NO_PROCEDIMENTO")
            .Status = oRow.Item("NO_OPT_STATUS")
            If Not FNC_CampoNulo(oRow.Item("DH_CHEGADA")) Then
              .ConfirmacaoChegada = "Presente"
            End If
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
        VScrollBar.Enabled = (cListagem.Length > 12 - 1)
        If cListagem.Length - 12 > 0 Then VScrollBar.Maximum = cListagem.Length - 12 + 1 Else VScrollBar.Maximum = 1
      End If

      Try
        VScrollBar.Value = 1
      Catch ex As Exception
      End Try

      Listar()
    Catch ex As Exception
    End Try

    cmdFechar.Enabled = True
  End Sub

  Private Sub Listar()
    Dim iCont As Integer
    Dim iControle As Integer

    Dim oConsultaAtendimento_Item As uscConsultaAtendimento_Item

    Limpar()

    iControle = 1

    Try
      If Not cListagem Is Nothing Then
        For iCont = VScrollBar.Value - 1 To VScrollBar.Value + iQT_LinhaAtendimento - 2
          oConsultaAtendimento_Item = Me.Controls(Me.Controls.IndexOfKey("oConsultaAtendimento_Item" + FNC_StrZero(iControle, 2)))

          Try
            oConsultaAtendimento_Item.iSQ_AGENDAMENTO = cListagem(iCont).SQ_AGENDAMENTO
            oConsultaAtendimento_Item.iID_OPT_STATUS = cListagem(iCont).ID_OPT_STATUS
            oConsultaAtendimento_Item.lblNumero.Text = FNC_StrZero(cListagem(iCont).Numero, 2)
            oConsultaAtendimento_Item.lblPaciente.Text = cListagem(iCont).Pessoa
            oConsultaAtendimento_Item.lblIdade.Text = cListagem(iCont).Idade
            oConsultaAtendimento_Item.lblTipoAtendimento.Text = cListagem(iCont).TipoAtendimento
            If cListagem(iCont).Status.Length > 15 Then
              oConsultaAtendimento_Item.lblStatus.Text = cListagem(iCont).Status.Substring(0, 16)
            Else
              oConsultaAtendimento_Item.lblStatus.Text = cListagem(iCont).Status
            End If
            oConsultaAtendimento_Item.lblConfirmacaoChegada.Text = cListagem(iCont).ConfirmacaoChegada

            Select Case oConsultaAtendimento_Item.iID_OPT_STATUS
              Case enOpcoes.StatusAgendamento_Atendido
                oConsultaAtendimento_Item.BotoesExibir(True)
              Case enOpcoes.StatusAgendamento_AguardandoAtendimento
                oConsultaAtendimento_Item.BotoesExibir(False)
              Case Else
                oConsultaAtendimento_Item.Reserva()
            End Select
          Catch ex As Exception
            oConsultaAtendimento_Item.Limpar()
          End Try

          iControle = iControle + 1
        Next
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub txtDataPesquisa_ValueChanged(sender As Object, e As EventArgs) Handles txtDataPesquisa.ValueChanged
    Dim sSqlText As String

    If Not bCarregado Then Exit Sub

    sSqlText = "SELECT SUM(ISNULL(QT_ATENDIMENTO, 0) + ISNULL(QT_RETORNO, 0)) FROM VW_PESSOA_HORARIO" &
               " WHERE ID_PESSOA = " & iID_USUARIO &
                 " AND CD_OPT_DIA_SEMANA = " & (txtDataPesquisa.DateTime.DayOfWeek.GetHashCode() + 1) &
                 " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL
    iQT_LinhaAtendimento = DBQuery_ValorUnico(sSqlText, 0)

    Carregar()
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    Listar()
  End Sub

  Private Sub cmdAtendimentosRealizados_Clicado(sender As Object) Handles cmdAtendimentosRealizados.Clicado
    FNC_AbriTela(New frmCadastroAtendimentoAtendimentosRelalizados, , True, True)
  End Sub

  Private Sub cboEspecialidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEspecialidade.SelectedIndexChanged
    Carregar()
  End Sub

  Private Sub cboTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTurno.SelectedIndexChanged
    Carregar()
  End Sub

  Private Sub frmConsultaAtendimento_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    oThAtualizar.Interrupt()
    oThAtualizar = Nothing
  End Sub

  Private Sub oConsultaAtendimento_Item01_Chamar(sender As Object) Handles oConsultaAtendimento_Item01.Chamar, oConsultaAtendimento_Item02.Chamar,
                                                                           oConsultaAtendimento_Item03.Chamar, oConsultaAtendimento_Item04.Chamar,
                                                                           oConsultaAtendimento_Item05.Chamar, oConsultaAtendimento_Item06.Chamar,
                                                                           oConsultaAtendimento_Item07.Chamar, oConsultaAtendimento_Item08.Chamar,
                                                                           oConsultaAtendimento_Item09.Chamar, oConsultaAtendimento_Item10.Chamar,
                                                                           oConsultaAtendimento_Item11.Chamar, oConsultaAtendimento_Item12.Chamar
    Dim oBotao As uscConsultaAtendimento_Item
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
      sURL = sSISTEMA_LlinkChamarCliente.Replace("[Paciente]", oBotao.lblPaciente.Text) _
                                        .Replace("[Unidade]", iUnidade) _
                                        .Replace("[Consultorio]", cboConsultorio.SelectedItem(enComboBox_Consultorio.CD_CONSULTORIO))

      FNC_URL_Executar(sURL)

      FNC_Mensagem("Paciente chamado com sucesso!")
    Catch ex As Exception
      FNC_Mensagem("ERRO: " & ex.Message)
    End Try
  End Sub

  Private Sub oConsultaAtendimento_Item_Atender(sender As Object) Handles oConsultaAtendimento_Item01.Atender, oConsultaAtendimento_Item02.Atender,
                                                                          oConsultaAtendimento_Item03.Atender, oConsultaAtendimento_Item04.Atender,
                                                                          oConsultaAtendimento_Item05.Atender, oConsultaAtendimento_Item06.Atender,
                                                                          oConsultaAtendimento_Item07.Atender, oConsultaAtendimento_Item08.Atender,
                                                                          oConsultaAtendimento_Item09.Atender, oConsultaAtendimento_Item10.Atender,
                                                                          oConsultaAtendimento_Item11.Atender, oConsultaAtendimento_Item12.Atender
    Dim oBotao As uscConsultaAtendimento_Item
    Dim bEditar As Boolean

    If Not ComboBox_Selecionado(cboConsultorio) Then
      FNC_Mensagem("Selecione o consultório")
      Exit Sub
    End If

    oBotao = sender

    bEditar = (oBotao.iID_OPT_STATUS = enOpcoes.StatusAgendamento_AguardandoAtendimento.GetHashCode Or
              (oBotao.iID_OPT_STATUS = enOpcoes.StatusAgendamento_Atendido.GetHashCode And txtDataPesquisa.DateTime.Date = DateTime.Now.Date))

    Me.Hide()

    Dim oForm As New frmCadastroAtendimento

    oForm.Formatar()
    oForm.iID_AGENDAMENTO = oBotao.iSQ_AGENDAMENTO
    oForm.iID_CONSULTORIO = cboConsultorio.SelectedValue
    oForm.bEditar = bEditar

    FNC_AbriTela(oForm)

    oForm.Left = 0
    oForm.Top = 0

    If oForm.bFinalizado Then
      Carregar()
    End If
  End Sub

  Private Sub cboTurno_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTurno.KeyDown
    If e.KeyCode = Keys.Delete Then cboTurno.SelectedIndex = -1
  End Sub

  Private Sub chkFiltroConsulta_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltroConsulta.CheckedChanged
    Carregar()
  End Sub

  Private Sub chkFiltroExame_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltroExame.CheckedChanged
    Carregar()
  End Sub

  Private Sub chkFiltroRetorno_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltroRetorno.CheckedChanged
    Carregar()
  End Sub

  Private Sub cmdAtualizar_Click(sender As Object, e As EventArgs) Handles cmdAtualizar.Click
    Carregar()
  End Sub

  Private Sub chkAtendidos_CheckedChanged(sender As Object, e As EventArgs) Handles chkAtendidos.CheckedChanged
    Carregar()
  End Sub

  Private Sub frmConsultaAtendimento_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    Me.BringToFront()
    Me.Left = 0
    Me.Top = 0
  End Sub
End Class