Public Class frmCadastroAtestado
  Public iID_AGENDAMENTO As Integer
  Public iID_CLINICA_ATENDIMENTO As Integer
  Public bEditar As Boolean

  Dim iSQ_PESSOA_ATESTADO As Integer
  Dim iID_PESSOA As Integer
  Dim eID_OPT_TIPO_ATESTADO As enOpcoes

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_Atestados))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    If Salvar() Then FNC_Mensagem("Gravação Efetuada")
  End Sub

  Private Sub CarregaDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim sAtestado As String

    sSqlText = "SELECT * FROM TB_EMPRESA WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    sAtestado = FNC_NVL(oData.Rows(0).Item("DS_ATESTADO"), "")

    If optMedico.Checked Then
      eID_OPT_TIPO_ATESTADO = enOpcoes.TipoAtestado_Medico
    ElseIf optComparecimento.Checked Then
      eID_OPT_TIPO_ATESTADO = enOpcoes.TipoAtestado_Comparecimento
    ElseIf optAcompanhamento.Checked Then
      eID_OPT_TIPO_ATESTADO = enOpcoes.TipoAtestado_Acomapanhante
    End If

    iSQ_PESSOA_ATESTADO = 0

    If iID_AGENDAMENTO <> 0 Or iID_CLINICA_ATENDIMENTO <> 0 Then
      sSqlText = "SELECT SQ_PESSOA_ATESTADO," &
                        "DH_PESSOA_ATESTADO," &
                        "NR_DIAS_REPOUSO," &
                        "dbo.FNC_Extenso(NR_DIAS_REPOUSO) DS_DIAS_REPOUSO," &
                        "CD_CID," &
                        "DS_ACOMPANHANTE," &
                        "DS_ATESTADO" &
                 " FROM TB_PESSOA_ATESTADO" &
                 " WHERE ID_OPT_TIPO_ATESTADO = " & eID_OPT_TIPO_ATESTADO.GetHashCode()

      If iID_AGENDAMENTO <> 0 Then
        sSqlText = sSqlText & " AND ID_AGENDAMENTO = " & iID_AGENDAMENTO
      ElseIf iID_CLINICA_ATENDIMENTO <> 0 Then
        sSqlText = sSqlText & " AND ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
      End If

      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        iSQ_PESSOA_ATESTADO = oData.Rows(0).Item("SQ_PESSOA_ATESTADO")
        txtDataAtestado.Value = oData.Rows(0).Item("DH_PESSOA_ATESTADO")
        txtDiasRepouso.Value = oData.Rows(0).Item("NR_DIAS_REPOUSO")
        txtCID.Text = FNC_NVL(oData.Rows(0).Item("CD_CID"), "")
        txtAcompanhamente.Text = FNC_NVL(oData.Rows(0).Item("DS_ACOMPANHANTE"), "")
      End If
    End If
  End Sub

  Private Function Salvar() As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    If Not IsDate(txtDataAtestado.Text) Then
      FNC_Mensagem("Informe a data do atestado")
      GoTo Sair
    End If
    'If rtbDescricao.Text.Trim() = "" Then
    '  FNC_Mensagem("Informe a descrição do atestado")
    '  GoTo Sair
    'End If

    sSqlText = DBMontar_SP("SP_PESSOA_ATESTADO_CAD", False, "@SQ_PESSOA_ATESTADO OUT",
                                                            "@ID_EMPRESA",
                                                            "@ID_PESSOA",
                                                            "@ID_PESSOA_PROFISSIONAL",
                                                            "@ID_OPT_TIPO_ATESTADO",
                                                            "@ID_AGENDAMENTO",
                                                            "@ID_CLINICA_ATENDIMENTO",
                                                            "@DH_PESSOA_ATESTADO",
                                                            "@NR_DIAS_REPOUSO",
                                                            "@CD_CID",
                                                            "@DS_ACOMPANHANTE",
                                                            "@DS_ATESTADO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_ATESTADO", iSQ_PESSOA_ATESTADO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                            DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_USUARIO),
                            DBParametro_Montar("ID_OPT_TIPO_ATESTADO", eID_OPT_TIPO_ATESTADO.GetHashCode()),
                            DBParametro_Montar("ID_AGENDAMENTO", iID_AGENDAMENTO),
                            DBParametro_Montar("ID_CLINICA_ATENDIMENTO", iID_CLINICA_ATENDIMENTO),
                            DBParametro_Montar("DH_PESSOA_ATESTADO", Now(), SqlDbType.DateTime2),
                            DBParametro_Montar("NR_DIAS_REPOUSO", txtDiasRepouso.Value),
                            DBParametro_Montar("CD_CID", txtCID.Text),
                            DBParametro_Montar("DS_ACOMPANHANTE", txtAcompanhamente.Text, SqlDbType.Text),
                            DBParametro_Montar("DS_ATESTADO", "", SqlDbType.Text)) Then
      If DBTeveRetorno() Then
        iSQ_PESSOA_ATESTADO = DBRetorno(1)
      End If
    End If

    bOk = True

Sair:
    Return bOk
  End Function

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub frmCadastroAtestado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim sSqlText As String = ""

    lblProntuario.Text = ""
    txtDataAtestado.Value = Now().Date
    txtAcompanhamente.Visible = False
    pnlAcompanhante.Visible = True

    ComboBox_Carregar(cboCidBuscar, enSql.Cid)

    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)

    If iID_AGENDAMENTO > 0 Or iID_CLINICA_ATENDIMENTO > 0 Then
      Dim oData As DataTable

      If iID_AGENDAMENTO > 0 Then
        sSqlText = "SELECT PESSO.SQ_PESSOA, PESSO.NO_PESSOA" &
                   " FROM TB_AGENDAMENTO AGEND" &
                    " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" &
                   " WHERE SQ_AGENDAMENTO = " & iID_AGENDAMENTO
        oData = DBQuery(sSqlText)
      ElseIf iID_CLINICA_ATENDIMENTO > 0 Then
        sSqlText = "SELECT PESSO.SQ_PESSOA, PESSO.NO_PESSOA" &
                   " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                    " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                   " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
        oData = DBQuery(sSqlText)
      End If

      iID_PESSOA = oData.Rows(0).Item("SQ_PESSOA")
      lblPessoa.Text = oData.Rows(0).Item("NO_PESSOA")
      lblProntuario.Text = iID_PESSOA

      oData.Dispose()

      CarregaDados()
    End If

    cmdSalvar.Enabled = bEditar
  End Sub

  Private Sub optMedico_CheckedChanged(sender As Object, e As EventArgs) Handles optMedico.CheckedChanged
    CarregaDados()
  End Sub

  Private Sub optComparecimento_CheckedChanged(sender As Object, e As EventArgs) Handles optComparecimento.CheckedChanged
    CarregaDados()
  End Sub

  Private Sub optAcompanhamento_CheckedChanged(sender As Object, e As EventArgs) Handles optAcompanhamento.CheckedChanged
    txtAcompanhamente.Visible = (optAcompanhamento.Checked)
    pnlAcompanhante.Visible = (Not optAcompanhamento.Checked)
    CarregaDados()
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    Salvar()

    If iSQ_PESSOA_ATESTADO > 0 Then
      If optMedico.Checked Then
        FormRelatorioAtestadoMedico(iSQ_PESSOA_ATESTADO, chkImprimir.Checked)
      ElseIf optComparecimento.Checked Then
        FormRelatorioAtestadoComparecimento(iSQ_PESSOA_ATESTADO, chkImprimir.Checked)
      ElseIf optAcompanhamento.Checked Then
        FormRelatorioAtestadoAcompanhante(iSQ_PESSOA_ATESTADO, chkImprimir.Checked)
      End If
    End If
  End Sub

  Private Sub cboCidBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCidBuscar.SelectedIndexChanged
    If ComboBox_Selecionado(cboCidBuscar) Then
      txtCidBuscar.Text = cboCidBuscar.SelectedItem(enComboBox_Cid.CD_CID)
    Else
      txtCidBuscar.Text = ""
    End If
  End Sub

  Private Sub cmdCidSelecionar_Click(sender As Object, e As EventArgs) Handles cmdCidSelecionar.Click
    If txtCidBuscar.Text = "" Then
      FNC_Mensagem("É preciso selecionar o CID")
    Else
      txtCID.Text = txtCidBuscar.Text
    End If
  End Sub
End Class