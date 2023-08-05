Imports System.ComponentModel

Public Class frmPDF_Visualizar
  Public sArquivo As String

  Private Sub frmPDF_Visualizar_Load(sender As Object, e As EventArgs) Handles Me.Load
    If System.IO.File.Exists(sArquivo) Then
      pdfVisualizar.setShowToolbar(True)
      pdfVisualizar.src = sArquivo
      pdfVisualizar.Show()

      Me.Width = oFormMDI.ClientSize.Width * 0.95
      Me.Height = oFormMDI.ClientSize.Height * 0.8

      Me.Left = ((Me.Width - oFormMDI.ClientSize.Width) / 2)
      Me.Top = ((Me.Height - oFormMDI.ClientSize.Height) / 2)
    End If
  End Sub

  Private Sub frmPDF_Visualizar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    pdfVisualizar.src = ""
  End Sub
End Class