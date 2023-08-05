Public Class frmCadastroRelatorio
  Public iID_CLINICA_ATENDIMENTO As Integer

  Dim iSQ_CLINICA_RELATORIO As Integer
  Dim iID_PESSOA As Integer

  Private Sub frmCadastroRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim oData As DataTable
    Dim sSqlText As String

    lblProntuario.Text = ""
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)

    ComboBox_Carregar(cboTipoRelatorio, enSql.TipoRelatorio)

    ComboBox_Selecionar(cboTipoRelatorio, 1)

    txtDataRelatorio.Value = Now().Date

    sSqlText = "SELECT PESSO_PROFI.SQ_PESSOA," &
                      "CLATD.ID_PESSOA," &
                      "CLREL.SQ_CLINICA_RELATORIO," &
                      "PESSO_PROFI.NO_PESSOA," &
                      "CLREL.DH_LANCAMENTO," &
                      "CLREL.DS_RELATORIO," &
                      "CLREL.ID_TIPO_RELATORIO" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                 " LEFT JOIN TB_CLINICA_RELATORIO CLREL ON CLREL.ID_CLINICA_ATENDIMENTO = CLATD.SQ_CLINICA_ATENDIMENTO" &
               " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO.ToString()
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      iID_PESSOA = oData.Rows(0).Item("ID_PESSOA").ToString()
      lblProntuario.Text = iID_PESSOA
      lblMedico.Text = oData.Rows(0).Item("NO_PESSOA")

      If Not FNC_CampoNulo(oData.Rows(0).Item("SQ_CLINICA_RELATORIO")) Then
        iSQ_CLINICA_RELATORIO = oData.Rows(0).Item("SQ_CLINICA_RELATORIO")
        txtDataRelatorio.Value = oData.Rows(0).Item("DH_LANCAMENTO")
        rtbDescricao.Text = oData.Rows(0).Item("DS_RELATORIO")
        ComboBox_Selecionar(cboTipoRelatorio, oData.Rows(0).Item("ID_TIPO_RELATORIO"))
      End If
    End If
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    If Not IsDate(txtDataRelatorio.Text) Then
      FNC_Mensagem("Informe a data do relatório")
      Exit Sub
    End If
    If rtbDescricao.Text.Trim() = "" Then
      FNC_Mensagem("Informe a descrição do relatório")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoRelatorio) Then
      FNC_Mensagem("Selecione o tipo de relatório")
      Exit Sub
    End If

    Gravar(True)
  End Sub

  Private Sub Gravar(bMensagem As Boolean)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CLINICA_RELATORIO_CAD", False, "@SQ_CLINICA_RELATORIO OUT",
                                                              "@ID_TIPO_RELATORIO",
                                                              "@ID_EMPRESA",
                                                              "@ID_PESSOA",
                                                              "@ID_PESSOA_PROFISSIONAL",
                                                              "@ID_CLINICA_ATENDIMENTO",
                                                              "@DH_LANCAMENTO",
                                                              "@DS_RELATORIO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_RELATORIO", iSQ_CLINICA_RELATORIO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_TIPO_RELATORIO", cboTipoRelatorio.SelectedValue),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                            DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_USUARIO),
                            DBParametro_Montar("ID_CLINICA_ATENDIMENTO", iID_CLINICA_ATENDIMENTO),
                            DBParametro_Montar("DH_LANCAMENTO", Now(), SqlDbType.DateTime2),
                            DBParametro_Montar("DS_RELATORIO", rtbDescricao.Text, SqlDbType.Text)) Then
      If DBTeveRetorno() Then
        iSQ_CLINICA_RELATORIO = DBRetorno(1)
      End If

      If bMensagem Then FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_Relatorio))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    Gravar(False)

    FormRelatorioRelatorio(iID_CLINICA_ATENDIMENTO, chkImprimir.Checked)
  End Sub
End Class