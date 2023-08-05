Imports System.ComponentModel

Public Class uscPictureBox
  Public Event ImagemAlterada()

  Dim sArquivoAntigo As String = ""
  Dim sArquivo As String
  Dim bZoomAutorizado As Boolean = False

  Public Sub Inicializar()
    sArquivoAntigo = ""
    sArquivo = ""
    picImagem.Image = Nothing
    picImagem.Refresh()
  End Sub

  Public ReadOnly Property ArquivoGravacao As String
    Get
      If picImagem.Image Is Nothing And Trim(sArquivoAntigo) <> "" Then
        If FNC_DiretorioSistema_AdicionarPath(sArquivo) <> FNC_DiretorioSistema_AdicionarPath(sArquivoAntigo) Then
          ExcluirArquivo()
        End If
      End If

      Return FNC_PictureBox_GuardarArquivo(picImagem)
    End Get
  End Property

  Public Property Arquivo As Object
    Get
      Return sArquivo
    End Get
    Set(value As Object)
      sArquivo = FNC_NVL(value, "")
      sArquivo = FNC_DiretorioSistema_RemoverPath(sArquivo)

      If Trim(sArquivoAntigo) = "" Then
        sArquivoAntigo = sArquivo
      End If

      FNC_CarregarImagem(sArquivo, picImagem)
    End Set
  End Property

  Public Sub ValidarArquivo()
    If FNC_DiretorioSistema_AdicionarPath(sArquivo) <> FNC_DiretorioSistema_AdicionarPath(sArquivoAntigo) Then
      ExcluirArquivo()
    End If
  End Sub

  Private Sub ExcluirArquivo(Optional sArquivo As String = "")
    Try
      If Trim(sArquivo) = "" Then sArquivo = sArquivoAntigo

      If Not FNC_RepositorioArquivo_ArquivoEmUso(sArquivo) Then
        Kill(FNC_DiretorioSistema_AdicionarPath(sArquivo))
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub picImagem_DoubleClick(sender As Object, e As EventArgs) Handles picImagem.DoubleClick
    Dim oForm As New frmImagem_Visualizador

    oForm.Imagem = picImagem.ImageLocation

    FNC_AbriTela(oForm)
  End Sub

  Private Sub picImagem_Click(sender As Object, e As EventArgs) Handles picImagem.Click
    'If bZoomAutorizado Then
    '  If picImagem.SizeMode = PictureBoxSizeMode.AutoSize Then
    '    picImagem.SizeMode = PictureBoxSizeMode.Zoom
    '  Else
    '    picImagem.SizeMode = PictureBoxSizeMode.AutoSize
    '  End If

    '  Formatar()
    'End If
  End Sub

  Public Property HabilitarBotoes As Boolean
    Get
      Return pnlBotoes.Enabled
    End Get
    Set(value As Boolean)
      pnlBotoes.Enabled = value
    End Set
  End Property

  Public Property BotaoExcluir As Boolean
    Get
      Return cmdApagarFoto.Visible
    End Get
    Set(value As Boolean)
      cmdApagarFoto.Visible = value
    End Set
  End Property

  Public Property Image As Image
    Get
      Return picImagem.Image
    End Get
    Set(value As Image)
      picImagem.Image = value
    End Set
  End Property

  Public ReadOnly Property PictureBox As PictureBox
    Get
      Return picImagem
    End Get
  End Property

  Private Sub uscPictureBox_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    Formatar()
  End Sub

  Private Sub Formatar()
    If Me.Width >= 293 Then
      cmdApagarFoto.Left = cmdObterFoto.Left + cmdObterFoto.Width + 1
      cmdApagarFoto.Top = 1
      pnlBotoes.Width = cmdApagarFoto.Left + cmdApagarFoto.Width
      pnlBotoes.Height = 28
    Else
      pnlBotoes.Width = 191
      pnlBotoes.Height = 59
      cmdApagarFoto.Left = 101
      cmdApagarFoto.Top = 31
    End If

    pnlBotoes.Left = ((Me.Width - pnlBotoes.Width) / 2)
    pnlBotoes.Top = Me.Height - pnlBotoes.Height

    If uscPictureBox_Zoom.Visible Then
      picImagem.Left = picZoom.Left + picZoom.Width + 5
      picImagem.Height = pnlBotoes.Top - 1
      picImagem.Width = picImagem.Image.Width * (picImagem.Height / picImagem.Image.Height)
      picImagem.SizeMode = PictureBoxSizeMode.StretchImage

      uscPictureBox_Zoom.Height = Me.Height * 0.99
      uscPictureBox_Zoom.Width = (picImagem.Height / uscPictureBox_Zoom.Height) * picImagem.Width

      uscPictureBox_Zoom.Left = Me.Width - uscPictureBox_Zoom.Width - 3
      uscPictureBox_Zoom.Top = 3
    Else
      picImagem.Left = 0
      picImagem.Height = pnlBotoes.Top - 1
      picImagem.Width = Me.Width
      picImagem.SizeMode = PictureBoxSizeMode.Zoom
    End If

    uscPictureBox_Zoom.Carregar(picImagem.ImageLocation)
  End Sub

  Public Property SelecionarImagem As Boolean
    Get
      Return pnlBotoes.Visible
    End Get
    Set(value As Boolean)
      pnlBotoes.Visible = value

      Formatar()
    End Set
  End Property

  Private Sub cmdSelecionarFoto_Click(sender As Object, e As EventArgs) Handles cmdSelecionarFoto.Click
    Dim sRet As String = FNC_CarregarFoto(picImagem)

    If sRet <> "" Then
      sArquivo = sRet
      RaiseEvent ImagemAlterada()
    End If
  End Sub

  Private Sub cmdObterFoto_Click(sender As Object, e As EventArgs) Handles cmdObterFoto.Click
    ObterFoto()
  End Sub

  Public Sub ObterFoto()
    Try
      Dim sRet As String = FNC_WebCam_CapturarFoto(picImagem)

      If sRet <> "" Then
        sArquivo = sRet
        RaiseEvent ImagemAlterada()
      End If
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Public Sub Digitalizar()
    Dim oDigitalizacao As New cls_Scannner
    Dim sRet As String

    Try
      oDigitalizacao.TipoBiblioteca = cls_Scannner.enScannner_TipoBiblioteca.tbWIA
      oDigitalizacao.PainelDigitalizacao()

      sRet = oDigitalizacao.ArquivoImagem

      If sRet <> "" Then
        sArquivo = sRet

        FNC_Mensagem(sArquivo)

        If Dir(sArquivo) <> "" Then picImagem.ImageLocation = sArquivo

        RaiseEvent ImagemAlterada()
      End If
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Private Sub cmdApagarFoto_Click(sender As Object, e As EventArgs) Handles cmdApagarFoto.Click
    Inicializar()
  End Sub

  Public Sub Imprimir()
    PrintDialog1.Document = PrintDocument1

    If PrintDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Or Dir(FNC_DiretorioSistema_AdicionarPath(sArquivo)) <> "" Then
      PrintDocument1.Print()
    End If
  End Sub

  Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    Dim Rect As New Rectangle(20, 20, picImagem.Width, picImagem.Height)
    e.Graphics.DrawImage(picImagem.Image, Rect)
  End Sub

  Private Sub uscPictureBox_Load(sender As Object, e As EventArgs) Handles Me.Load
    picZoom.Visible = False
    uscPictureBox_Zoom.Visible = False
    uscPictureBox_Zoom.picBase = picImagem
    AddHandler picImagem.MouseWheel, AddressOf uscPictureBox_Zoom.picBase_MouseWheel
    AddHandler picImagem.MouseMove, AddressOf uscPictureBox_Zoom.picBase_MouseMove
  End Sub

  Private Sub picZoom_Click(sender As Object, e As EventArgs) Handles picZoom.Click
    uscPictureBox_Zoom.Visible = (Not uscPictureBox_Zoom.Visible)
    uscPictureBox_Zoom.BringToFront()
    Formatar()
  End Sub

  Private Sub picImagem_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles picImagem.LoadCompleted
    uscPictureBox_Zoom.Carregar(picImagem.ImageLocation)
    picZoom.Visible = bZoomAutorizado
  End Sub

  Public Sub Zoom()
    bZoomAutorizado = True
    picZoom.Visible = bZoomAutorizado
  End Sub
End Class