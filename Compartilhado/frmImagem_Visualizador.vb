Public Class frmImagem_Visualizador
  Private Sub frmImagem_Visualizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    uscPictureBox_Zoom.picBase = picImagem
    AddHandler picImagem.MouseWheel, AddressOf uscPictureBox_Zoom.picBase_MouseWheel
    AddHandler picImagem.MouseMove, AddressOf uscPictureBox_Zoom.picBase_MouseMove
    uscPictureBox_Zoom.Visible = False
    Formatar()
  End Sub

  Public Property Imagem As String
    Get
      Return picImagem.ImageLocation
    End Get
    Set(value As String)
      picImagem.ImageLocation = value
    End Set
  End Property

  Private Sub cmdLupar_Click(sender As Object, e As EventArgs) Handles cmdLupar.Click
    uscPictureBox_Zoom.Visible = (Not uscPictureBox_Zoom.Visible)
    uscPictureBox_Zoom.BringToFront()
    Formatar()
  End Sub

  Private Sub Formatar()
    If uscPictureBox_Zoom.Visible Then
      picImagem.Dock = DockStyle.None
      picImagem.Left = 1
      picImagem.Top = 1
      picImagem.Height = pnlImagem.Height - 2
      picImagem.SizeMode = PictureBoxSizeMode.Zoom

      If Not picImagem.Image Is Nothing Then
        picImagem.Width = picImagem.Image.Width * (picImagem.Height / picImagem.Image.Height)
      End If

      uscPictureBox_Zoom.Height = pnlImagem.Height * 0.99
      uscPictureBox_Zoom.Width = (picImagem.Height / uscPictureBox_Zoom.Height) * picImagem.Width
      uscPictureBox_Zoom.Width = 600

      uscPictureBox_Zoom.Left = pnlImagem.Width - uscPictureBox_Zoom.Width - 3
      uscPictureBox_Zoom.Top = 3
    Else
      picImagem.Dock = DockStyle.Fill
      picImagem.Left = 0
      picImagem.Height = pnlOpcao.Top - 1
      picImagem.Width = Me.Width
      picImagem.SizeMode = PictureBoxSizeMode.Zoom
    End If

    uscPictureBox_Zoom.Carregar(picImagem.ImageLocation)
  End Sub
End Class