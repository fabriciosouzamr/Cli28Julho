Public Class uscPictureBox_Zoom
  'Dim OriImg As System.Drawing.Image
  Dim dZoom As Double = 2.5
  Public picBase As PictureBox

  Public Sub Carregar(sImagem As String)
    'OriImg = OriImg.FromFile(sImagem)

    'If OriImg.Width > OriImg.Height Then
    '  picBase.Height = OriImg.Height * (picBase.Width / OriImg.Width)
    'Else
    '  picBase.Width = OriImg.Width * (picBase.Height / OriImg.Height)
    'End If

    Zoom_Tamanho()

    picImagem.ImageLocation = sImagem
  End Sub

  Public Sub picBase_MouseMove(sender As Object, e As MouseEventArgs)
    Try
      If (0 - (e.X * (picImagem.Width / picBase.Width))) + picImagem.Width >= Me.Width Then
        picImagem.Left = 0 - (e.X * (picImagem.Width / picBase.Width))
      Else
        picImagem.Left = Me.Width - picImagem.Width

        If picImagem.Width < Me.Width Then
          picImagem.Left = 0
        End If
      End If
      If (0 - (e.Y * (picImagem.Height / picBase.Height))) + picImagem.Height >= Me.Height Then
        picImagem.Top = 0 - (e.Y * (picImagem.Height / picBase.Height))
      Else
        picImagem.Top = Me.Height - picImagem.Height

        If picImagem.Height < Me.Height Then
          picImagem.Top = 0
        End If
      End If
    Catch ex As Exception
    End Try
  End Sub

  Public Sub picBase_MouseWheel(sender As Object, e As MouseEventArgs)
    dZoom = Math.Round(dZoom + IIf(e.Delta > 0, 0.1, -0.1), 2)

    If dZoom < 1 Then
      dZoom = 1
    End If

    Zoom_Tamanho()
  End Sub

  Private Sub Zoom_Tamanho()
    Try
      picImagem.Width = picBase.Width * dZoom
      picImagem.Height = picBase.Height * dZoom
      picImagem.SizeMode = PictureBoxSizeMode.StretchImage
    Catch ex As Exception
    End Try
  End Sub
End Class
