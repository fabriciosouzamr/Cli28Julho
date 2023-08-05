Public Class frmCadastroAtendimentoSolicitacaoExameCitologico
  Public iID_CLINICA_ATENDIMENTO As Integer
  Public iID_CLINICA_VENDA As Integer
  Public iSQ_PESSOA As Integer

  Public bGravado As Boolean
  Public bFecharSair As Boolean
  Public oSolicitacaoExameCitologico As modDeclaracaoLocal.cSolicitacaoExameCitologico

  Dim iSQ_CLINICA_EXAME_CITOLOGICO As Integer

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_SolicitacaoExamesCitológico))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub frmCadastroAtendimentoSolicitacaoExameCitologico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    lblProntuario.Text = ""

    Dim oData As DataTable
    Dim sSqlText As String

    If iID_CLINICA_ATENDIMENTO > 0 Then
      sSqlText = "SELECT CLATD.ID_PESSOA," &
                      "PESSO.NO_PESSOA," &
                      "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') DS_IDADE" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
               " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        lblProntuario.Text = oData.Rows(0).Item("ID_PESSOA")
        lblPaciente.Text = oData.Rows(0).Item("NO_PESSOA")
        lblIdade.Text = oData.Rows(0).Item("DS_IDADE")
      End If

      sSqlText = "SELECT * FROM TB_CLINICA_EXAME_CITOLOGICO WHERE ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        With oData.Rows(0)
          iSQ_CLINICA_EXAME_CITOLOGICO = .Item("SQ_CLINICA_EXAME_CITOLOGICO")
          If FNC_CampoNulo(.Item("IC_DIU")) Then
            optDIU_Sim.Checked = False
            optDIU_Nao.Checked = False
          Else
            optDIU_Sim.Checked = (FNC_NVL(.Item("IC_DIU"), "N") = "S")
            optDIU_Nao.Checked = (FNC_NVL(.Item("IC_DIU"), "N") = "N")
          End If
          txtMedicoExterno.Text = .Item("DS_MEDICO_EXTERNO")
          txtColeta.Text = .Item("DS_COLETA")
          txtUm.Text = .Item("DS_UM")
          txtFilho.Text = .Item("DS_FILHOS")
          txtAborto.Text = .Item("DS_ABORTO")
          txtPara.Text = .Item("DS_PARA")
          txtLocalColeta.Text = .Item("DS_LOCAL_COLETA")
          txtAchadosColposcopicos.Text = .Item("DS_ACHADOS_COLPOSCOPICOS")
        End With
      End If

      If Trim(txtMedicoExterno.Text) = "" Then
        sSqlText = "SELECT CLVND.DS_SOLICITANTE" &
                   " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                    " LEFT JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPCDA ON CVPCDA.ID_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                    " LEFT JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                    " LEFT JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPCDG ON CVPCDG.SQ_CLINICA_VENDA_PROCEDIMENTO = AGEND.ID_CLINICA_VENDA_PROCEDIMENTO" &
                    " LEFT JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = ISNULL(CVPCDA.ID_CLINICA_VENDA, CVPCDG.ID_CLINICA_VENDA)" &
                   " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
        txtMedicoExterno.Text = DBQuery_ValorUnico(sSqlText, sNO_USUARIO)
      End If
    Else
      sSqlText = "SELECT PESSO.SQ_PESSOA," &
                        "PESSO.NO_PESSOA," &
                        "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') DS_IDADE" &
               " FROM TB_PESSOA PESSO" &
               " WHERE PESSO.SQ_PESSOA = " & iSQ_PESSOA
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        lblProntuario.Text = oData.Rows(0).Item("SQ_PESSOA")
        lblPaciente.Text = oData.Rows(0).Item("NO_PESSOA")
        lblIdade.Text = oData.Rows(0).Item("DS_IDADE")
      End If
    End If

    oData.Dispose()
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    Salvar(iID_CLINICA_ATENDIMENTO > 0)

    If bFecharSair Then Close()
  End Sub

  Private Sub Salvar(bMensagem As Boolean)
    If iID_CLINICA_ATENDIMENTO > 0 Then
      bGravado = FormCadastroAtendimentoSolicitacaoExameCitologico(iSQ_CLINICA_EXAME_CITOLOGICO,
                                                                   iID_CLINICA_ATENDIMENTO,
                                                                   iID_CLINICA_VENDA,
                                                                   txtMedicoExterno.Text,
                                                                   txtColeta.Text,
                                                                   txtUm.Text,
                                                                   txtFilho.Text,
                                                                   txtAborto.Text,
                                                                   txtPara.Text,
                                                                   txtLocalColeta.Text,
                                                                   txtAchadosColposcopicos.Text,
                                                                   IIf(optDIU_Sim.Checked, "S", IIf(optDIU_Nao.Checked, "N", Nothing)))
    End If

    oSolicitacaoExameCitologico = New modDeclaracaoLocal.cSolicitacaoExameCitologico()
    oSolicitacaoExameCitologico.sDS_MEDICO_EXTERNO = txtMedicoExterno.Text
    oSolicitacaoExameCitologico.sDS_COLETA = txtColeta.Text
    oSolicitacaoExameCitologico.sDS_UM = txtUm.Text
    oSolicitacaoExameCitologico.sDS_FILHOS = txtFilho.Text
    oSolicitacaoExameCitologico.sDS_ABORTO = txtAborto.Text
    oSolicitacaoExameCitologico.sDS_PARA = txtPara.Text
    oSolicitacaoExameCitologico.sDS_LOCAL_COLETA = txtColeta.Text
    oSolicitacaoExameCitologico.sDS_ACHADOS_COLPOSCOPICOS = txtAchadosColposcopicos.Text
    oSolicitacaoExameCitologico.sIC_DIU = IIf(optDIU_Sim.Checked, "S", IIf(optDIU_Nao.Checked, "N", ""))

    If bMensagem Then FNC_Mensagem("Gravaçao Efeutada")
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    Salvar(False)
    FormRelatorioExameCitologico(iSQ_CLINICA_EXAME_CITOLOGICO, chkImprimir.Checked)
  End Sub

  Private Sub optDIU_Sim_KeyDown(sender As Object, e As KeyEventArgs) Handles optDIU_Sim.KeyDown
    If e.KeyCode = Keys.Delete Then
      optDIU_Sim.Checked = False
    End If
  End Sub

  Private Sub optDIU_Nao_KeyDown(sender As Object, e As KeyEventArgs) Handles optDIU_Nao.KeyDown
    If e.KeyCode = Keys.Delete Then
      optDIU_Nao.Checked = False
    End If
  End Sub
End Class