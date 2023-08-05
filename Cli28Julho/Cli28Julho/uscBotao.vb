Public Class uscBotao
  Public Event Clicado(sender As Object)

  Public TipoBotao As Integer

  Public Sub Formatar(iTela As Integer)
    Try
      picMouseOut.Image = Image.FromFile(FNC_ConfiguracaoTela_Botao(iTela, const_ConfiguracaoTela_MouseOut))
    Catch ex As Exception
    End Try
    Try
      picMouseIn.Image = Image.FromFile(FNC_ConfiguracaoTela_Botao(iTela, const_ConfiguracaoTela_MouseIn))
    Catch ex As Exception
      picMouseIn.Image = picMouseOut.Image
    End Try
    Try
      picMouseClick.Image = Image.FromFile(FNC_ConfiguracaoTela_Botao(iTela, const_ConfiguracaoTela_MouseClick))
    Catch ex As Exception
      picMouseClick.Image = picMouseOut.Image
    End Try
    Try
      picDesabilitado.Image = Image.FromFile(FNC_ConfiguracaoTela_Botao(iTela, const_ConfiguracaoTela_Desabilitar))
    Catch ex As Exception
      picDesabilitado.Image = picMouseOut.Image
    End Try

    TipoBotao = iTela

    picGeral.Image = picMouseOut.Image
  End Sub

  Private Sub uscBotao_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    'picGeral.Width = Me.Width
    'picGeral.Height = Me.Height
    'picGeral.Top = 1
    'picGeral.Left = 1
  End Sub

  Private Sub picGeral_MouseEnter(sender As Object, e As EventArgs) Handles picGeral.MouseEnter
    picGeral.Image = picMouseIn.Image
  End Sub

  Private Sub picGeral_MouseLeave(sender As Object, e As EventArgs) Handles picGeral.MouseLeave
    picGeral.Image = picMouseOut.Image
  End Sub

  Private Sub picGeral_MouseDown(sender As Object, e As MouseEventArgs) Handles picGeral.MouseDown
    picGeral.Image = picMouseClick.Image

    RaiseEvent Clicado(Me)
  End Sub

  Private Sub picGeral_MouseUp(sender As Object, e As MouseEventArgs) Handles picGeral.MouseUp
    picGeral.Image = picMouseIn.Image
  End Sub

  Private Sub uscBotao_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
    VerificarAtivacao()
  End Sub

  Private Sub VerificarAtivacao()
    Try
      If Me.Enabled Then
        picGeral.Image = picMouseOut.Image
      Else
        picGeral.Image = picDesabilitado.Image
      End If
    Catch ex As Exception
    End Try
  End Sub
End Class
