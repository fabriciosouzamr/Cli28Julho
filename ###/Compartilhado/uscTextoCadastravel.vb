Public Class uscTextoCadastravel
  Public Enum enTipo
    Pessoa = 1
  End Enum

  Public Tipo As enTipo = enTipo.Pessoa
  Public Escrever As Boolean = True

  Public Property BotaoNovo As Boolean
    Get
      Return cmdNovo.Visible
    End Get
    Set(bValor As Boolean)
      cmdNovo.Visible = bValor
    End Set
  End Property

  Private Sub AjustarControles()
    cmdEscrever.Left = 0
    cmdEscrever.Top = 0
    cmdPesquisar.Left = cmdEscrever.Left
    cmdPesquisar.Top = cmdEscrever.Top
    cmdNovo.Left = 21
    cmdNovo.Top = 0

    txtEscrever.Top = 1
    txtEscrever.Left = IIf(cmdNovo.Visible, 44, 22)
    txtEscrever.Width = Me.Width - txtEscrever.Left
    cboPesquisa.Top = 0
    cboPesquisa.Left = IIf(cmdNovo.Visible, 44, 22)
    cboPesquisa.Width = Me.Width - cboPesquisa.Left
  End Sub

  Private Sub PesquisarEscrever(bEscrever As Boolean)
    cmdPesquisar.Visible = bEscrever
    txtEscrever.Visible = bEscrever

    cmdEscrever.Visible = (Not bEscrever)
    cboPesquisa.Visible = (Not bEscrever)
  End Sub

  Private Sub uscTextoCadastravel_Load(sender As Object, e As EventArgs) Handles Me.Load
    PesquisarEscrever(Escrever)
  End Sub

  Private Sub uscTextoCadastravel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    AjustarControles()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    PesquisarEscrever(False)
  End Sub

  Private Sub cmdEscrever_Click(sender As Object, e As EventArgs) Handles cmdEscrever.Click
    PesquisarEscrever(True)
  End Sub

  Public Sub New()
    InitializeComponent()

    BotaoNovo = False
    PesquisarEscrever(False)
  End Sub
End Class
