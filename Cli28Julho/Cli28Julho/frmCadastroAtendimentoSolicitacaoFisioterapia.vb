Public Class frmCadastroAtendimentoSolicitacaoFisioterapia
  Class Fisioterapia
    Public NO_PROCEDIMENTO As String
    Public DT_FISIOTERAPIA As String
    Public QT_SECOES As String
    Public CM_FISIOTERAPIA As String
  End Class

  Public iID_CLINICA_ATENDIMENTO As Integer

  Dim iSQ_CLINICA_RELATORIO As Integer
  Dim iID_PESSOA As Integer

  Dim oFisioterapia() As Fisioterapia

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_SolicitacaoFisioterapia))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub frmCadastroAtendimentoSolicitacaoFisioterapia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    cmdSalvar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Salvar)

    txtDataFisioterapia.Value = Now.Date

    Dim iCont As Integer
    Dim sSqlText As String

    sSqlText = "SELECT ID_PESSOA FROM TB_CLINICA_ATENDIMENTO WHERE SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO.ToString()
    psqPessoa.ID_Pessoa = DBQuery_ValorUnico(sSqlText)

    lblIdade.Text = ""

    For iCont = 1 To 8
      Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblProcedimento" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblQtdeSecoes" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblObservacao" + FNC_StrZero(iCont, 2))).Text = ""
    Next

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1

    CarregarFisioterapia()
  End Sub

  Private Sub psqPessoa_SelectedIndexChanged() Handles psqPessoa.SelectedIndexChanged
    Dim sSqlText As String

    sSqlText = "SELECT dbo.FC_DateDiff_Extenso(DT_NASC_ABERTURA, getdate(), 'N') FROM TB_PESSOA WHERE SQ_PESSOA = " & psqPessoa.ID_Pessoa
    lblIdade.Text = DBQuery_ValorUnico(sSqlText)
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub CarregarFisioterapia()
    Dim oData As DataTable
    Dim sSqlText As String = ""
    Dim sItem As String = ""
    Dim iCont As Integer = 0

    sSqlText = "SELECT CLFST.DT_FISIOTERAPIA," &
                      "PROCE.NO_PROCEDIMENTO," &
                      "CLFST.QT_SECOES," &
                      "CLFST.CM_FISIOTERAPIA" &
               " FROM TB_CLINICA_FISIOTERAPIA CLFST" &
                " INNER JOIN TB_CLINICA_ATENDIMENTO CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLFST.ID_CLINICA_ATENDIMENTO" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CLFST.ID_PROCEDIMENTO" &
               " WHERE CLATD.ID_PESSOA = " & psqPessoa.ID_Pessoa &
               " ORDER BY CLFST.DT_FISIOTERAPIA," &
                         "PROCE.NO_PROCEDIMENTO"
    oData = DBQuery(sSqlText)

    ReDim oFisioterapia(oData.Rows.Count - 1)

    For Each oRow As DataRow In oData.Rows
      oFisioterapia(iCont) = New Fisioterapia
      oFisioterapia(iCont).DT_FISIOTERAPIA = oRow.Item("DT_FISIOTERAPIA")
      oFisioterapia(iCont).NO_PROCEDIMENTO = oRow.Item("NO_PROCEDIMENTO")
      oFisioterapia(iCont).QT_SECOES = oRow.Item("QT_SECOES")
      oFisioterapia(iCont).CM_FISIOTERAPIA = oRow.Item("CM_FISIOTERAPIA")

      iCont = iCont + 1
    Next

    VScrollBar.Enabled = (oData.Rows.Count > 8)
    If oData.Rows.Count - 19 > 0 Then VScrollBar.Maximum = oData.Rows.Count - 8

    VScrollBar.Value = 1

    ListarFisioterapia()
  End Sub

  Private Sub ListarFisioterapia()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    For iCont = VScrollBar.Value - 1 To VScrollBar.Value + 6
      Try
        Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = oFisioterapia(iCont).DT_FISIOTERAPIA
        Me.Controls(Me.Controls.IndexOfKey("lblProcedimento" + FNC_StrZero(iLabel, 2))).Text = oFisioterapia(iCont).NO_PROCEDIMENTO
        Me.Controls(Me.Controls.IndexOfKey("lblQtdeSecoes" + FNC_StrZero(iLabel, 2))).Text = oFisioterapia(iCont).QT_SECOES
        Me.Controls(Me.Controls.IndexOfKey("lblObservacao" + FNC_StrZero(iLabel, 2))).Text = oFisioterapia(iCont).CM_FISIOTERAPIA
      Catch ex As Exception
        Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblProcedimento" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblQtdeSecoes" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblObservacao" + FNC_StrZero(iLabel, 2))).Text = ""
      End Try

      iLabel = iLabel + 1
    Next
  End Sub

  Private Sub cmdSalvar_Clicado(sender As Object) Handles cmdSalvar.Clicado
    If Not IsDate(txtDataFisioterapia.Text) Then
      FNC_Mensagem("Informe a data do lançamento")
      Exit Sub
    End If
    If psqProcedimento.Identificador = 0 Then
      FNC_Mensagem("Selecione o procedimento")
      Exit Sub
    End If
    If txtQtdeSecoes.Value = 0 Then
      FNC_Mensagem("Informe a qtde. de seções")
      Exit Sub
    End If
    If txtObservacao.Text = "" Then
      FNC_Mensagem("Informe a observação")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CLINICA_PROCEDIMENTO", False, "@ID_CLINICA_ATENDIMENTO",
                                                             "@ID_PROCEDIMENTO",
                                                             "@DT_FISIOTERAPIA",
                                                             "@QT_SECOES",
                                                             "@CM_FISIOTERAPIA")

    DBExecutar(sSqlText, DBParametro_Montar("ID_CLINICA_ATENDIMENTO", iID_CLINICA_ATENDIMENTO),
                         DBParametro_Montar("ID_PROCEDIMENTO", psqProcedimento.Identificador),
                         DBParametro_Montar("DT_FISIOTERAPIA", txtDataFisioterapia.DateTime.Date),
                         DBParametro_Montar("QT_SECOES", txtQtdeSecoes.Value),
                         DBParametro_Montar("CM_FISIOTERAPIA", txtObservacao.Text))

    txtDataFisioterapia.Value = Now.Date
    psqProcedimento.Identificador = 0
    txtObservacao.Text = ""
    txtQtdeSecoes.Value = 0

    CarregarFisioterapia()

    FNC_Mensagem("Lançamento inserido")
  End Sub
End Class