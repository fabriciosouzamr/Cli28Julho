Public Class uscIndicacao
  Dim iSQ_INDICACAO As Integer
  Dim bCarregado As Boolean

  Private Sub picTiposIndicacao_Cliente(sender As Object, e As EventArgs) Handles picTipoIndicacao_Cliente.Click, _
                                                                                  picTipoIndicacao_Internet.Click, _
                                                                                  picTipoIndicacao_Jornal.Click, _
                                                                                  picTipoIndicacao_Marketing.Click, _
                                                                                  picTipoIndicacao_Outros.Click, _
                                                                                  picTipoIndicacao_Profissional.Click, _
                                                                                  picTipoIndicacao_SitePesquisa.Click
    pnlTiposIndicacao_Selecionar(sender.Tag)
    pnlTiposIndicacao_Visivel(False)
  End Sub

  Private Sub pnlTiposIndicacao_Visivel(bVisivel As Boolean)
    pnlTiposIndicacao.Visible = bVisivel
    picTipoIndicacao.Visible = (Not bVisivel)
    lblRIndicacao.Visible = (Not bVisivel)
    cboIndicacao.Visible = (Not bVisivel)
  End Sub

  Private Sub pnlTiposIndicacao_Selecionar(iTipoIndicacao As Integer)
    Dim oPIC As PictureBox = Nothing

    iSQ_INDICACAO = 0

    Select Case iTipoIndicacao
      Case enOpcoes.TipoIndicacao_Clientes.GetHashCode
        oPIC = picTipoIndicacao_Cliente
      Case enOpcoes.TipoIndicacao_Internet.GetHashCode
        oPIC = picTipoIndicacao_Internet
      Case enOpcoes.TipoIndicacao_Jornal.GetHashCode
        oPIC = picTipoIndicacao_Jornal
      Case enOpcoes.TipoIndicacao_Marketing.GetHashCode
        oPIC = picTipoIndicacao_Marketing
      Case enOpcoes.TipoIndicacao_Outros.GetHashCode
        oPIC = picTipoIndicacao_Outros
      Case enOpcoes.TipoIndicacao_Profissional.GetHashCode
        oPIC = picTipoIndicacao_Profissional
      Case enOpcoes.TipoIndicacao_SitePesquisa.GetHashCode
        oPIC = picTipoIndicacao_SitePesquisa
    End Select

    If bCarregado Then ComboBox_Carregar(cboIndicacao, enSql.Indicacao, New Object() {oPIC.Tag})

    picTipoIndicacao.Image = oPIC.Image
    picTipoIndicacao.Tag = oPIC.Tag
    ToolTip1.SetToolTip(picTipoIndicacao, ToolTip1.GetToolTip(oPIC))
  End Sub

  Public Sub New()
    InitializeComponent()

    picTipoIndicacao_Cliente.Tag = enOpcoes.TipoIndicacao_Clientes.GetHashCode
    picTipoIndicacao_Internet.Tag = enOpcoes.TipoIndicacao_Internet.GetHashCode
    picTipoIndicacao_Jornal.Tag = enOpcoes.TipoIndicacao_Jornal.GetHashCode
    picTipoIndicacao_Marketing.Tag = enOpcoes.TipoIndicacao_Marketing.GetHashCode
    picTipoIndicacao_Outros.Tag = enOpcoes.TipoIndicacao_Outros.GetHashCode
    picTipoIndicacao_Profissional.Tag = enOpcoes.TipoIndicacao_Profissional.GetHashCode
    picTipoIndicacao_SitePesquisa.Tag = enOpcoes.TipoIndicacao_SitePesquisa.GetHashCode

    Limpar()

    pnlTiposIndicacao.Top = 3
    pnlTiposIndicacao.Visible = False

    Me.Height = 36

    pnlTiposIndicacao_Visivel(False)
    bCarregado = True
  End Sub

  Private Sub picTipoIndicacao_Click(sender As Object, e As EventArgs) Handles picTipoIndicacao.Click
    pnlTiposIndicacao_Visivel(True)
  End Sub

  Public Sub Limpar()
    iSQ_INDICACAO = 0

    'If Not Me.DesignMode Then
    '  pnlTiposIndicacao_Selecionar(picTipoIndicacao_Profissional.Tag)
    '  picTipoIndicacao.Refresh()
    'End If

    cboIndicacao.Text = ""
  End Sub

  Public Property INDICACAO
    Get
      Return iSQ_INDICACAO
    End Get
    Set(value)
      iSQ_INDICACAO = value

      If iSQ_INDICACAO <= 0 Then
        Limpar()
      Else
        CarregarDados()
      End If
    End Set
  End Property

  Public ReadOnly Property DESCRICAO As String
    Get
      Return cboIndicacao.Text
    End Get
  End Property

  Public Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM TB_INDICACAO WHERE SQ_INDICACAO = " & iSQ_INDICACAO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      pnlTiposIndicacao_Selecionar(oData.Rows(0).Item("ID_OPT_TIPO_INDICACAO"))
      ComboBox_Selecionar(cboIndicacao, oData.Rows(0).Item("SQ_INDICACAO"))
    End If
  End Sub

  Public Function Gravar() As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    If Trim(cboIndicacao.Text) = "" Then
      iSQ_INDICACAO = 0
      GoTo Sair
    End If

    sSqlText = DBMontar_SP("SP_INDICACAO_CAD", False, "@SQ_INDICACAO OUT", _
                                                      "@ID_TIPO_INDICACAO", _
                                                      "@NO_INDICACAO")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_INDICACAO", iSQ_INDICACAO, , ParameterDirection.InputOutput), _
                               DBParametro_Montar("ID_TIPO_INDICACAO", picTipoIndicacao.Tag), _
                               DBParametro_Montar("NO_INDICACAO", cboIndicacao.Text))

    If DBTeveRetorno() Then
      iSQ_INDICACAO = DBRetorno(1)
    End If

Sair:
    Return bOk
  End Function

  Private Sub cboIndicacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIndicacao.SelectedIndexChanged
    iSQ_INDICACAO = FNC_NVL(cboIndicacao.SelectedValue, 0)
  End Sub

  Private Sub uscIndicacao_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cboIndicacao.Width = (Me.Width - cboIndicacao.Left)
  End Sub
  Private Sub cboIndicacao_TextChanged(sender As Object, e As EventArgs) Handles cboIndicacao.TextChanged
    iSQ_INDICACAO = FNC_NVL(cboIndicacao.SelectedValue, 0)
  End Sub
End Class
