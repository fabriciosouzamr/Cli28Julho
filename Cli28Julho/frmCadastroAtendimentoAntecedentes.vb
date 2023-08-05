Public Class frmCadastroAtendimentoAntecedentes
  Public iSQ_PESSOA As Integer
  Dim iSQ_PESSOA_ANTECEDENTES As Integer
  Dim iID_PESSOA_PROFISSIONAL As Integer

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_Antecedentes))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub frmCadastroAtendimentoAntecedentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)

    lblMedico.Text = ""
    lblData.Text = ""

    Carregar()
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    Dim sSqlText As String
    Dim eID_OPT_TIPO_ANTECEDENTES As enOpcoes

    If rtbDescricao.Text.Trim() = "" Then
      FNC_Mensagem("Informe a descrição do atestado")
      Exit Sub
    End If

    If optPessoal.Checked Then
      eID_OPT_TIPO_ANTECEDENTES = enOpcoes.TipoAntecedentes_Pessoal
    ElseIf optFamiliar.Checked Then
      eID_OPT_TIPO_ANTECEDENTES = enOpcoes.TipoAntecedentes_Familiar
    End If

    sSqlText = DBMontar_SP("SP_PESSOA_ATESTADO_CAD", False, "@SQ_PESSOA_ANTECEDENTES OUT",
                                                            "@ID_PESSOA",
                                                            "@ID_PESSOA_PROFISSIONAL",
                                                            "@ID_OPT_TIPO_ANTECEDENTES",
                                                            "@DT_LANCAMENTO",
                                                            "@DS_ANTECEDENTES")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_ANTECEDENTES", iSQ_PESSOA_ANTECEDENTES, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                            DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_PESSOA_PROFISSIONAL),
                            DBParametro_Montar("ID_OPT_TIPO_ATESTADO", eID_OPT_TIPO_ANTECEDENTES.GetHashCode()),
                            DBParametro_Montar("DT_LANCAMENTO", Now(), SqlDbType.DateTime2),
                            DBParametro_Montar("DS_ANTECEDENTES", rtbDescricao.Text, SqlDbType.Text)) Then
      If DBTeveRetorno() Then
        iSQ_PESSOA_ANTECEDENTES = DBRetorno(1)
      End If

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub Carregar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim eID_OPT_TIPO_ANTECEDENTES As enOpcoes

    If optPessoal.Checked Then
      eID_OPT_TIPO_ANTECEDENTES = enOpcoes.TipoAntecedentes_Pessoal
    ElseIf optFamiliar.Checked Then
      eID_OPT_TIPO_ANTECEDENTES = enOpcoes.TipoAntecedentes_Familiar
    End If

    sSqlText = "SELECT PSACD.SQ_PESSOA_ANTECEDENTES," &
                      "PSACD.ID_PESSOA_PROFISSIONAL," &
                      "PSACD.DS_ANTECEDENTES," &
                      "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                      "PSACD.DT_LANCAMENTO" &
               " FROM TB_PESSOA_ANTECEDENTES PSACD" &
               " INNER JOIM TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = PSACD.ID_PESSOA_PROFISSIONAL" &
               " WHERE ID_PESSOA = " & iSQ_PESSOA.ToString() &
                 " AND ID_OPT_TIPO_ATESTADO = " & eID_OPT_TIPO_ANTECEDENTES.GetHashCode()
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      iSQ_PESSOA_ANTECEDENTES = oData.Rows(0).Item("SQ_PESSOA_ANTECEDENTES")
      iID_PESSOA_PROFISSIONAL = oData.Rows(0).Item("ID_PESSOA_PROFISSIONAL")
      lblMedico.Text = oData.Rows(0).Item("NO_PESSOA_PROFISSIONAL")
      lblData.Text = oData.Rows(0).Item("DT_LANCAMENTO").ToString().Substring(0, 10)
      rtbDescricao.Text = oData.Rows(0).Item("DS_ANTECEDENTES")
    Else
      iSQ_PESSOA_ANTECEDENTES = 0
      iID_PESSOA_PROFISSIONAL = iID_USUARIO
      lblMedico.Text = sNO_USUARIO
      lblData.Text = Now().ToString().Substring(0, 10)
    End If
  End Sub

  Private Sub optPessoal_CheckedChanged(sender As Object, e As EventArgs) Handles optPessoal.CheckedChanged
    Carregar()
  End Sub

  Private Sub optFamiliar_CheckedChanged(sender As Object, e As EventArgs) Handles optFamiliar.CheckedChanged
    Carregar()
  End Sub
End Class