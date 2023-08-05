Imports System
Imports System.IO
Imports System.Collections
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms

Module modScanner

End Module

Public Class cls_Scannner_Gdip
  Friend Declare Function GdipCreateBitmapFromGdiDib Lib "gdiplus.dll" (ByVal bminfo As IntPtr, ByVal pixdat As IntPtr, ByRef image As IntPtr) As Integer
  Friend Declare Function GdipSaveImageToFile Lib "gdiplus.dll" (ByVal image As IntPtr, ByVal filename As String, ByRef clsid As Guid, ByVal encparams As IntPtr) As Integer
  Friend Declare Function GdipDisposeImage Lib "gdiplus.dll" (ByVal image As IntPtr) As Integer

  Private Shared codecs() As ImageCodecInfo = ImageCodecInfo.GetImageEncoders

  Private Shared Function GetCodecClsid(ByVal filename As String, ByRef clsid As Guid) As Boolean
    clsid = Guid.Empty
    Dim ext As String = Path.GetExtension(filename)

    If (ext Is Nothing) Then
      Return False
    End If

    ext = ("*" + ext.ToUpper)

    For Each codec As ImageCodecInfo In codecs
      If (codec.FilenameExtension.IndexOf(ext) >= 0) Then
        clsid = codec.Clsid
        Return True
      End If
    Next

    Return False
  End Function

  Public Shared Function SaveDIBAs(ByVal picname As String, ByVal bminfo As IntPtr, ByVal pixdat As IntPtr) As Boolean
    Dim sd As SaveFileDialog = New SaveFileDialog

    sd.FileName = picname
    sd.Title = "Save bitmap as..."
    sd.Filter = "Bitmap file (*.bmp)|*.bmp|TIFF file (*.tif)|*.tif|JPEG file (*.jpg)|*.jpg|PNG file (*.png)|*.png|GIF file (*.gif)|*.gif|All files (*.*)|*.*"
    sd.FilterIndex = 1

    If (sd.ShowDialog <> DialogResult.OK) Then
      Return False
    End If

    Dim clsid As Guid
    If Not GetCodecClsid(sd.FileName, clsid) Then
      MessageBox.Show(("Unknown picture format for extension " + Path.GetExtension(sd.FileName)), "Image Codec", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Return False
    End If

    Dim img As IntPtr = IntPtr.Zero
    Dim st As Integer = GdipCreateBitmapFromGdiDib(bminfo, pixdat, img)
    If ((st <> 0) _
                OrElse (img = IntPtr.Zero)) Then
      Return False
    End If

    st = GdipSaveImageToFile(img, sd.FileName, clsid, IntPtr.Zero)
    GdipDisposeImage(img)

    Return (st = 0)
  End Function
End Class

Public Class cls_Scannner
  Public Enum enScannner_TipoBiblioteca
    tbWIA = 1
    tbTWAIN = 2
  End Enum

  Public Enum enScannner_Status
    tbOk = 1
    tbErro = 2
  End Enum

  Public TipoBiblioteca As enScannner_TipoBiblioteca = enScannner_TipoBiblioteca.tbWIA
  Public ArquivoImagem As String
  Public Status As enScannner_Status = enScannner_Status.tbErro
  Public Handle As System.IntPtr

  Private Function ArquivoImagem_Carregar() As String
    ArquivoImagem = FNC_Diretorio_Tratar(FNC_Diretorio_Temporario()) & "scanwia000.png"

    If System.IO.File.Exists(ArquivoImagem) Then
      System.IO.File.Delete(ArquivoImagem)
    End If

    Return ArquivoImagem
  End Function

  Public Sub Digitalizar()
        'Status = enScannner_Status.tbErro

        'Select Case TipoBiblioteca
        '  Case enScannner_TipoBiblioteca.tbWIA
        '    Try
        '      Dim dialog = New WIA.CommonDialogClass
        '      Dim scannedImage = CType(dialog.ShowAcquireImage(WIA.WiaDeviceType.ScannerDeviceType), WIA.ImageFile)

        '      If (Not (scannedImage) Is Nothing) Then
        '        scannedImage.SaveFile(ArquivoImagem_Carregar())
        '      Else
        '        FNC_Mensagem("Erro na digitalizaçãso do documento.", enTipoMensagem.Erro)
        '        Status = enScannner_Status.tbErro
        '      End If

        '      Status = enScannner_Status.tbOk
        '    Catch ex As System.Exception
        '      FNC_Mensagem("Erro na digitalizaçãso do documento. " + ex.Message, enTipoMensagem.Erro)
        '      Status = enScannner_Status.tbErro
        '    End Try
        '  Case enScannner_TipoBiblioteca.tbTWAIN
        '    Try
        '      Dim appId As NTwain.Data.TWIdentity = NTwain.Data.TWIdentity.CreateFromAssembly(NTwain.Data.DataGroups.Image, System.Reflection.Assembly.GetEntryAssembly)
        '      Dim twain As NTwain.TwainSession = New NTwain.TwainSession(appId)

        '      twain.Open()

        '      Dim scanner As NTwain.DataSource = twain.ShowSourceSelector()

        '      scanner.Open()

        '      AddHandler twain.DataTransferred, AddressOf twain_DataTransferred
        '      scanner.Enable(NTwain.SourceEnableMode.NoUI, True, Handle)

        '      scanner.Close()
        '    Catch ex As Exception
        '      FNC_Mensagem("Erro na digitalizaçãso do documento. " & ex.Message, enTipoMensagem.Erro)
        '      Status = enScannner_Status.tbErro
        '    End Try
        'End Select
    End Sub

  Public Sub PainelDigitalizacao()
        'Status = enScannner_Status.tbErro

        'Select Case TipoBiblioteca
        '  Case enScannner_TipoBiblioteca.tbWIA
        '    Try
        '      Dim dialog As WIA.CommonDialogClass = New WIA.CommonDialogClass
        '      Dim oScannerWIA As WIA.Device
        '      Dim iCont As Integer = 0
        '      Dim sArquivo As String = ArquivoImagem_Carregar()
        '      Dim sArquivoAux As String

        '      oScannerWIA = dialog.ShowSelectDevice(WIA.WiaDeviceType.ScannerDeviceType, True, False)

        '      dialog.ShowAcquisitionWizard(oScannerWIA)

        '      If oScannerWIA.Items.Count = 0 Then
        '        ArquivoImagem = ""
        '      Else
        '        For Each itm As WIA.Item In oScannerWIA.Items
        '          Dim img As WIA.ImageFile = itm.Transfer()

        '          iCont = iCont + 1

        '          sArquivoAux = Replace(sArquivo, "scanwia000.png", "scanwia" & FNC_StrZero(iCont, 3) & ".png")

        '          If Dir(sArquivoAux) <> "" Then
        '            Kill(sArquivoAux)
        '          End If

        '          img.SaveFile(sArquivoAux)

        '          FNC_Mensagem(sArquivoAux)
        '        Next
        '      End If

        '      'Try
        '      '  FNC_Mensagem("M1 - " & oScannerWIA.Items.Count.ToString())

        '      '  For iCont = 0 To oScannerWIA.Items.Count - 1
        '      '    FNC_Mensagem("M2 - " & oScannerWIA.Items(iCont).Items.Count.ToString())
        '      '    FNC_Mensagem("M3 - " & oScannerWIA.Items(iCont).Properties.Count.ToString())
        '      '    FNC_Mensagem("M4 - " & oScannerWIA.Items(iCont).WiaItem.ToString())
        '      '    FNC_Mensagem("M5 - " & oScannerWIA.Type.ToString())
        '      '  Next
        '      'Catch ex As Exception
        '      '  FNC_Mensagem("ERRO 1 - " & ex.Message)
        '      'End Try

        '      Status = enScannner_Status.tbOk
        '    Catch ex As System.Exception
        '      MessageBox.Show("Erro na digitalizaçãso do documento. " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '      Status = enScannner_Status.tbErro
        '    End Try
        '  Case enScannner_TipoBiblioteca.tbTWAIN
        'End Select
    End Sub

  Private Sub twain_DataTransferred(ByVal sender As Object, ByVal e As NTwain.DataTransferredEventArgs)
    Try
      Dim img As Image = Nothing

      Status = enScannner_Status.tbErro

      If (e.NativeData <> IntPtr.Zero) Then
        Dim stream = e.GetNativeImageStream

        If (Not (stream) Is Nothing) Then
          img = Image.FromStream(stream)
        End If
      ElseIf Not String.IsNullOrEmpty(e.FileDataPath) Then
        img = New Bitmap(e.FileDataPath)
      End If

      img.Save(ArquivoImagem_Carregar(), System.Drawing.Imaging.ImageFormat.Png)

      Status = enScannner_Status.tbOk
    Catch ex As Exception
      FNC_Mensagem("Erro na digitalizaçãso do documento.", enTipoMensagem.Erro)
      Status = enScannner_Status.tbErro
    End Try
  End Sub
End Class