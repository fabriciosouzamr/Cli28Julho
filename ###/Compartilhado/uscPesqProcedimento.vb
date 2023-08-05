Public Class uscPesqProcedimento
  Public Event ItemSelecionado(sender As Object, e As EventArgs)

  Dim bEmProcessamento As Boolean
  Dim iConvenio As Integer
  Dim iGrupoProcedimento As Integer
  Dim iProfissional As Integer

  Private Sub uscPesqProcedimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cboProcedimento.Text = ""
    cboProcedimentoPrincipal.Text = ""

    CarregarDados()
  End Sub

  Private Sub CarregarDados()
    If bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO Then
      ComboBox_CarregarProcedimento(True, cboProcedimento, cboProcedimentoPrincipal, ,, iConvenio, iProfissional, iGrupoProcedimento)
      cboProcedimento.Text = ""
      cboProcedimentoPrincipal.Text = ""
    End If
  End Sub

  Public Sub AtualizarListaProcedimento()
    ComboBox_CarregarProcedimento(True, cboProcedimento, cboProcedimentoPrincipal, ,, iConvenio, iProfissional, iGrupoProcedimento)
  End Sub

  Private Sub uscPesqProcedimento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cboProcedimentoPrincipal.Width = Me.ClientSize.Width - cboProcedimentoPrincipal.Left
  End Sub

  Private Sub cboProcedimentoPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProcedimentoPrincipal.KeyDown
    If e.KeyCode = System.Windows.Forms.Keys.Enter And Not bEmProcessamento And Not bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO Then
      bEmProcessamento = True
      ComboBox_CarregarProcedimento(False, cboProcedimento, cboProcedimentoPrincipal,,, iConvenio,, iGrupoProcedimento)
      bEmProcessamento = False
    End If
  End Sub

  Private Sub cboProcedimento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProcedimento.KeyDown
    If e.KeyCode = System.Windows.Forms.Keys.Enter And Not bEmProcessamento And Not bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO Then
      bEmProcessamento = True
      ComboBox_CarregarProcedimento(True, cboProcedimento, cboProcedimentoPrincipal, ,, iConvenio, iProfissional, iGrupoProcedimento)
      bEmProcessamento = False
    End If
  End Sub

  Private Sub cboProcedimentoPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcedimentoPrincipal.SelectedIndexChanged
    If ComboBox_Selecionado(cboProcedimentoPrincipal) And Not bEmProcessamento Then
      bEmProcessamento = True
      ComboBox_Selecionar(cboProcedimento, cboProcedimentoPrincipal.SelectedValue)
      bEmProcessamento = False
    End If

    RaiseEvent ItemSelecionado(sender, e)
  End Sub

  Private Sub cboProcedimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcedimento.SelectedIndexChanged
    If ComboBox_Selecionado(cboProcedimento) And Not bEmProcessamento Then
      bEmProcessamento = True
      ComboBox_Selecionar(cboProcedimentoPrincipal, cboProcedimento.SelectedValue)
      bEmProcessamento = False
    End If

    RaiseEvent ItemSelecionado(sender, e)
  End Sub

  Private Sub cmdPesquisarProcedimento_Click(sender As Object, e As EventArgs) Handles cmdPesquisarProcedimento.Click
    FormPesquisaProcedimento_BotaoPesquisar(cboProcedimento, cboProcedimentoPrincipal, bEmProcessamento, iConvenio)
  End Sub

  Public ReadOnly Property Codigo As String
    Get
      Return cboProcedimento.Text
    End Get
  End Property

  Public ReadOnly Property Nome As String
    Get
      Return cboProcedimentoPrincipal.Text
    End Get
  End Property

  Public Property Convenio As Integer
    Get
      Return iConvenio
    End Get
    Set(value As Integer)
      iConvenio = value
      CarregarDados()
    End Set
  End Property

  Public Property GrupoProcedimento As Integer
    Get
      Return iGrupoProcedimento
    End Get
    Set(value As Integer)
      iGrupoProcedimento = value

      CarregarDados()
    End Set
  End Property

  Public Property Profissional As Integer
    Get
      Return iProfissional
    End Get
    Set(value As Integer)
      iProfissional = value

      CarregarDados()
    End Set
  End Property

  Public Property Identificador As Integer
    Get
      Return FNC_NVL(cboProcedimentoPrincipal.SelectedValue, 0)
    End Get
    Set(value As Integer)
      If value > 0 Then
        bEmProcessamento = True
        If Not bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO Then ComboBox_CarregarProcedimento(True, cboProcedimento, cboProcedimentoPrincipal, value)
        ComboBox_Selecionar(cboProcedimentoPrincipal, value)

        If value > 0 And Not ComboBox_Selecionado(cboProcedimentoPrincipal) And bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO Then
          ComboBox_CarregarProcedimento(True, cboProcedimento, cboProcedimentoPrincipal, value)
          ComboBox_Selecionar(cboProcedimentoPrincipal, value)
        End If

        ComboBox_Selecionar(cboProcedimento, value)

        bEmProcessamento = False
      End If
    End Set
  End Property

  Public Sub Limpar()
    bEmProcessamento = True
    If bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO Then
      cboProcedimento.SelectedIndex = -1
      cboProcedimentoPrincipal.SelectedIndex = -1
      cboProcedimento.Text = ""
      cboProcedimentoPrincipal.Text = ""
    Else
      cboProcedimento.DataSource = Nothing
      cboProcedimentoPrincipal.DataSource = Nothing
    End If
    bEmProcessamento = False
  End Sub

  Private Sub uscPesqProcedimento_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged
    If Not lblRProcedimento.Visible Then
      cboProcedimento.Font = Me.Font
      cboProcedimentoPrincipal.Font = Me.Font
    End If
  End Sub

  Public Property LabelVisivel As Boolean
    Get
      Return lblRProcedimento.Visible
    End Get
    Set(value As Boolean)
      lblRProcedimento.Visible = value
      lblRDescricaoProcedimento.Visible = value

      Select Case value
        Case True
          cmdPesquisarProcedimento.Top = 15
          cboProcedimento.Top = 15
          cboProcedimentoPrincipal.Top = 15
        Case False
          cmdPesquisarProcedimento.Top = 1
          cboProcedimento.Top = 1
          cboProcedimentoPrincipal.Top = 1
      End Select

      Me.Height = cboProcedimento.Top + cboProcedimento.Height
    End Set
  End Property

  Public Property Bordas As Boolean
    Get
      Return cboProcedimento.FlatStyle = FlatStyle.Standard
    End Get
    Set(value As Boolean)
      If value Then
        cboProcedimento.FlatStyle = FlatStyle.Standard
        cboProcedimentoPrincipal.FlatStyle = FlatStyle.Standard
      Else
        cboProcedimento.FlatStyle = FlatStyle.Flat
        cboProcedimentoPrincipal.FlatStyle = FlatStyle.Flat
      End If
    End Set
  End Property
End Class
