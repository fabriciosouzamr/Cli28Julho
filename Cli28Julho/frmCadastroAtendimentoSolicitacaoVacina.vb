Public Class frmCadastroAtendimentoSolicitacaoVacina
  Class cVacina
    Public Data As String
    Public Vacina As String
    Public Dosagem As String
    Public Observacao As String
  End Class

  Public iID_CLINICA_ATENDIMENTO As Integer
  Public bEditar As Boolean

  Dim iID_PESSOA As Integer
  Dim oVacina() As cVacina

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_SolicitacaoVacinas))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub frmCadastroAtendimentoSolicitacaoVacina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim oData As DataTable
    Dim sSqlText As String

    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)

    ComboBox_Carregar(cboVacina, enSql.Vacina)

    sSqlText = "SELECT CLATD.ID_PESSOA," &
                      "CONCAT(RTRIM(PESSO.NO_PESSOA), ' - ', CAST(PESSO.SQ_PESSOA AS VARCHAR)) NO_PESSOA," &
                      "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') DS_IDADE" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
               " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      iID_PESSOA = oData.Rows(0).Item("ID_PESSOA")
      lblPaciente.Text = oData.Rows(0).Item("NO_PESSOA")
      lblIdade.Text = oData.Rows(0).Item("DS_IDADE")
    End If

    txtDataVacina.Value = Now.Date

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1

    CarregarVacinas()

    cmdSalvar.Enabled = bEditar
  End Sub

  Private Sub CarregarVacinas()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer = 0

    sSqlText = "SELECT VACIN.NO_VACINA," &
                      "CLVCN.DT_LANCAMENTO," &
                      "CLVCN.QT_DOSAGEM," &
                      "CLVCN.CM_CLINICA_VACINA" &
               " FROM TB_CLINICA_VACINA	CLVCN" &
                " INNER JOIN TB_CLINICA_ATENDIMENTO	CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLVCN.ID_CLINICA_ATENDIMENTO" &
                " INNER JOIN TB_VACINA VACIN ON VACIN.SQ_VACINA = CLVCN.ID_VACINA" &
              " WHERE CLATD.ID_PESSOA = " & iID_PESSOA &
              " ORDER BY CLVCN.DT_LANCAMENTO"
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      ReDim oVacina(oData.Rows.Count - 1)

      For Each oRow As DataRow In oData.Rows
        oVacina(iCont) = New cVacina

        With oVacina(iCont)
          .Data = oRow.Item("DT_LANCAMENTO")
          .Vacina = oRow.Item("NO_VACINA")
          .Dosagem = oRow.Item("QT_DOSAGEM")
          .Observacao = oRow.Item("CM_CLINICA_VACINA")
        End With

        iCont = iCont + 1
      Next
    End If

    oData.Dispose()

    VScrollBar.Enabled = (oData.Rows.Count > 9)
    If oData.Rows.Count - 9 > 0 Then VScrollBar.Maximum = oData.Rows.Count - 8

    VScrollBar.Value = 1

    ListarVacinas()
  End Sub

  Private Function Vacina_Carregado() As Boolean
    If oVacina Is Nothing Then
      Return False
    Else
      Return (oVacina.Count > 0)
    End If
  End Function

  Private Sub ListarVacinas()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    LimparVacinas()

    If Vacina_Carregado() Then
      For iCont = VScrollBar.Value - 1 To VScrollBar.Value + 7
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = oVacina(iCont).Data
          Me.Controls(Me.Controls.IndexOfKey("lblVacina" + FNC_StrZero(iLabel, 2))).Text = oVacina(iCont).Vacina
          Me.Controls(Me.Controls.IndexOfKey("lblDosagem" + FNC_StrZero(iLabel, 2))).Text = oVacina(iCont).Dosagem
          Me.Controls(Me.Controls.IndexOfKey("lblObservacao" + FNC_StrZero(iLabel, 2))).Text = oVacina(iCont).Observacao
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblVacina" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblDosagem" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblObservacao" + FNC_StrZero(iLabel, 2))).Text = ""
        End Try

        iLabel = iLabel + 1
      Next
    End If
  End Sub

  Private Sub LimparVacinas()
    For iCont = 1 To 9
      Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblVacina" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblDosagem" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblObservacao" + FNC_StrZero(iCont, 2))).Text = ""
    Next
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    ListarVacinas()
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    If Not IsDate(txtDataVacina.Text) Then
      FNC_Mensagem("Informe a data de lançamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboVacina) Then
      FNC_Mensagem("Selecione a vacina")
      Exit Sub
    End If
    If txtDosagem.Value <= 0 Then
      FNC_Mensagem("Informe as dosagem")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CLINICA_VACINA_CAD", False, "@SQ_CLINICA_VACINA",
                                                           "@ID_CLINICA_ATENDIMENTO",
                                                           "@ID_PESSOA",
                                                           "@ID_VACINA",
                                                           "@DT_LANCAMENTO",
                                                           "@QT_DOSAGEM",
                                                           "@CM_CLINICA_VACINA")

    DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VACINA", 0),
                         DBParametro_Montar("ID_CLINICA_ATENDIMENTO", iID_CLINICA_ATENDIMENTO),
                         DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                         DBParametro_Montar("ID_VACINA", cboVacina.SelectedValue),
                         DBParametro_Montar("DT_LANCAMENTO", txtDataVacina.Value),
                         DBParametro_Montar("QT_DOSAGEM", txtDosagem.Value),
                         DBParametro_Montar("CM_CLINICA_VACINA", txtObservacao.Text))

    CarregarVacinas()

    txtDataVacina.Value = Now.Date
    cboVacina.SelectedIndex = -1
    txtDosagem.Value = 0
    txtObservacao.Text = ""

    FNC_Mensagem("Vacina Gravada")
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    FormRelatorioVacina(iID_CLINICA_ATENDIMENTO)
  End Sub
End Class