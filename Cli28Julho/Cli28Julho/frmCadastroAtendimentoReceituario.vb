Public Class frmCadastroAtendimentoReceituario
  Class cCadastroAtendimentoReceituario
    Public SQ_CLINICA_RECEITUARIO As Integer
    Public DT_LANCAMENTO  as Date
    Public DS_RECEITUARIO As String
  End Class

  Public iID_CLINICA_ATENDIMENTO As Integer
  Public bEditar As Boolean

  Dim iSQ_CLINICA_RECEITUARIO As Integer
  Dim iID_PESSOA As Integer
  Dim oCadastroAtendimentoReceituario() As cCadastroAtendimentoReceituario
  Dim iIndiceListar As Integer

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_Receituario))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    If rtbDescricao.Text.Trim() = "" Then
      FNC_Mensagem("Informe a descrição do atestado")
      Exit Sub
    End If
    If Not IsDate(txtDataReceituario.Text) Then
      FNC_Mensagem("Informe a data do receituário")
      Exit Sub
    End If

    If Not oCadastroAtendimentoReceituario Is Nothing Then
      iIndiceListar = oCadastroAtendimentoReceituario.Length
    Else
      iIndiceListar = 0
    End If

    Gravar(True)
  End Sub

  Private Sub Gravar(bMensagem As Boolean)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CLINICA_RECEITUARIO_CAD", False, "@SQ_CLINICA_RECEITUARIO OUT",
                                                                "@ID_EMPRESA",
                                                                "@ID_PESSOA",
                                                                "@ID_PESSOA_PROFISSIONAL",
                                                                "@ID_CLINICA_ATENDIMENTO",
                                                                "@DT_LANCAMENTO",
                                                                "@DS_RECEITUARIO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_RECEITUARIO", iSQ_CLINICA_RECEITUARIO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                            DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_USUARIO),
                            DBParametro_Montar("ID_CLINICA_ATENDIMENTO", iID_CLINICA_ATENDIMENTO),
                            DBParametro_Montar("DT_LANCAMENTO", Now(), SqlDbType.DateTime2),
                            DBParametro_Montar("DS_RECEITUARIO", rtbDescricao.Text, SqlDbType.Text)) Then
      If DBTeveRetorno() Then
        iSQ_CLINICA_RECEITUARIO = DBRetorno(1)
      End If

      Carregar()

      cmdAnterior.Enabled = True
      cmdProximo.Enabled = False

      If bMensagem Then FNC_Mensagem("Gravaçao Efeutada")
    End If
  End Sub

  Private Sub frmCadastroAtendimentoReceituario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtDataReceituario.Value = Now().Date

    lblProntuario.Text = ""
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    cmdNovo.Formatar(enOpcoes.ConfiguracaoTela_Botao_Novo)

    Carregar()
  End Sub
  Private Sub Carregar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iIndice As Integer = 0

    cmdAnterior.Enabled = False
    cmdProximo.Enabled = False

    If iID_CLINICA_ATENDIMENTO > 0 Then
      sSqlText = "SELECT CLATD.ID_PESSOA," &
                        "PESSO.NO_PESSOA," &
                        "CLRCT.SQ_CLINICA_RECEITUARIO," &
                        "CLRCT.DT_LANCAMENTO," &
                        "CLRCT.DS_RECEITUARIO" &
                 " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                  " LEFT JOIN TB_CLINICA_RECEITUARIO CLRCT ON CLRCT.ID_CLINICA_ATENDIMENTO = CLATD.SQ_CLINICA_ATENDIMENTO" &
                  " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                 " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        oCadastroAtendimentoReceituario = Nothing
      Else
        ReDim oCadastroAtendimentoReceituario(oData.Rows.Count - 1)

        For Each oRow As DataRow In oData.Rows
          oCadastroAtendimentoReceituario(iIndice) = New cCadastroAtendimentoReceituario()
          iID_PESSOA = oRow.Item("ID_PESSOA")
          lblPessoa.Text = oRow.Item("NO_PESSOA")
          lblProntuario.Text = oRow.Item("ID_PESSOA")

          If FNC_CampoNulo(oRow.Item("SQ_CLINICA_RECEITUARIO")) Then
            sSqlText = "SELECT * FROM TB_EMPRESA WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
            oData = DBQuery(sSqlText)

            oCadastroAtendimentoReceituario(iIndice).DS_RECEITUARIO = FNC_NVL(oData.Rows(0).Item("DS_RECEITUARIO"), "")
          Else

            If Not FNC_CampoNulo(oRow.Item("SQ_CLINICA_RECEITUARIO")) Then
              oCadastroAtendimentoReceituario(iIndice).SQ_CLINICA_RECEITUARIO = oRow.Item("SQ_CLINICA_RECEITUARIO")
              oCadastroAtendimentoReceituario(iIndice).DT_LANCAMENTO = oRow.Item("DT_LANCAMENTO")
              oCadastroAtendimentoReceituario(iIndice).DS_RECEITUARIO = oRow.Item("DS_RECEITUARIO")
            End If
          End If

          iIndice = iIndice + 1
        Next

        cmdProximo.Enabled = (iIndice > 1)
      End If
    End If

    txtDataReceituario.Value = Now().Date

    cmdSalvar.Enabled = bEditar

    CarregarDados()
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    Gravar(False)
    FormRelatorioReceituario(iSQ_CLINICA_RECEITUARIO, chkImprimir.Checked)
  End Sub

  Private Sub cmdNovo_Clicado(sender As Object) Handles cmdNovo.Clicado
    iSQ_CLINICA_RECEITUARIO = 0
    txtDataReceituario.DateTime = Now()
    rtbDescricao.Text = ""
  End Sub

  Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
    iIndiceListar = iIndiceListar - 1
    CarregarDados()
    cmdProximo.Enabled = True
    cmdAnterior.Enabled = (iIndiceListar > 0)
  End Sub

  Private Sub cmdProximo_Click(sender As Object, e As EventArgs) Handles cmdProximo.Click
    iIndiceListar = iIndiceListar + 1
    CarregarDados()
    cmdAnterior.Enabled = True
    cmdProximo.Enabled = (iIndiceListar < oCadastroAtendimentoReceituario.Length - 1)
  End Sub

  Private Sub CarregarDados()
    If oCadastroAtendimentoReceituario Is Nothing Then Exit Sub

    Try
      If oCadastroAtendimentoReceituario(iIndiceListar).DT_LANCAMENTO <> New Date Then
        txtDataReceituario.DateTime = oCadastroAtendimentoReceituario(iIndiceListar).DT_LANCAMENTO
      End If
      rtbDescricao.Text = oCadastroAtendimentoReceituario(iIndiceListar).DS_RECEITUARIO
      iSQ_CLINICA_RECEITUARIO = FNC_NVL(oCadastroAtendimentoReceituario(iIndiceListar).SQ_CLINICA_RECEITUARIO, 0)
    Catch ex As Exception
    End Try
  End Sub
End Class