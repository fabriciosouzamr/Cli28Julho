Public Class frmWebCam_Captura
  Public sArquivoFoto As String = ""

  Dim oWebCam As New clsWebCam

  Private Sub frmWebCam_Captura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    oWebCam.ComboBox_Dispositivo = cboEquipamento
    oWebCam.oPicCaptura = picFoto
    oWebCam.Visualizar()
  End Sub

  Private Sub cmdParar_Click(sender As Object, e As EventArgs) Handles cmdParar.Click
    oWebCam.InterromperVisualizacao()
    sArquivoFoto = ""
    Close()
  End Sub

  Private Sub cmdCapturar_Click(sender As Object, e As EventArgs) Handles cmdCapturar.Click
    sArquivoFoto = oWebCam.SalvarVisualizacao
    Close()
  End Sub
End Class