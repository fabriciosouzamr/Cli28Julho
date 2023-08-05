Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Text
Imports System.Runtime.InteropServices

Module modPrintPreviewRichTextBox
  Public Class RichTextBoxDocument
    Inherits PrintDocument

    Private Declare Function SendMessage Lib "USER32.DLL" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Declare Function SendMessageFormatRange Lib "USER32.DLL" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As UInteger, ByVal wParam As Integer, ByRef lParam As FORMATRANGE) As Integer

    Public Event VisualizadoImpressao()
    Public Event Impresso()
    Public Event ImpressaoCancelada()

    Dim _rtb As System.Windows.Forms.RichTextBox
    Dim _firstChar As Integer
    Dim _currentPage As Integer
    Dim _pageCount As Integer
    Dim _pageNumber As Boolean = True
    Dim _printAction As System.Drawing.Printing.PrintAction

    Dim _Header As String
    Dim _HeaderFont As Font
    Dim _HeaderAlign As StringAlignment
    Dim _Footer As String
    Dim _FooterFont As Font
    Dim _FooterAlign As StringAlignment

    Dim _FooterPageFont As Font
    Dim _FooterDadosSistema As Font

    Const PAGE As String = "[page]"
    Const PAGES As String = "[pages]"
   
    Public Sub New(rtb As System.Windows.Forms.RichTextBox)
      MyBase.New()
      _rtb = rtb

      Dim FontStyle As FontStyle = Drawing.FontStyle.Regular

      'initialize header and footer
      Header = String.Empty
      Footer = String.Empty

      'Header = String.Format("\t - RichTextBoxDocument - \r\n** {0} **", _rtb.Name)
      'Footer = String.Format("{0}\t{1}\tPage [page] of [pages]", DateTime.Today.ToShortDateString(), DateTime.Now.ToShortTimeString())

      _HeaderFont = New Font("Verdana", 18, FontStyle.Bold)
      _HeaderAlign = StringAlignment.Center
      _FooterFont = New Font("Verdana", 8, FontStyle.Bold)
      _FooterAlign = StringAlignment.Center

      _FooterPageFont = New Font("Verdana", 7, FontStyle.Regular)

      FontStyle = FontStyle + Drawing.FontStyle.Bold + Drawing.FontStyle.Underline
      _FooterDadosSistema = New Font("Arial", 8, FontStyle)
    End Sub

    Public ReadOnly Property Impressao As System.Drawing.Printing.PrintAction
      Get
        Return _printAction
      End Get
    End Property

    Public Property Document As System.Windows.Forms.RichTextBox
      Get
        Return _rtb
      End Get
      Set(value As System.Windows.Forms.RichTextBox)
        _rtb = value
      End Set
    End Property

    Public Property HeaderAlign As StringAlignment
      Get
        Return _HeaderAlign
      End Get
      Set(value As StringAlignment)
        _HeaderAlign = value
      End Set
    End Property

    Public Property FooterAlign As StringAlignment
      Get
        Return _FooterAlign
      End Get
      Set(value As StringAlignment)
        _FooterAlign = value
      End Set
    End Property

    Public Property Header As String
      Get
        Return _Header
      End Get
      Set(value As String)
        _Header = value
      End Set
    End Property

    Public Property Footer As String
      Get
        Return _Footer
      End Get
      Set(value As String)
        _Footer = value
      End Set
    End Property

    Public Property HeaderFont As Font
      Get
        Return _HeaderFont
      End Get
      Set(value As Font)
        _HeaderFont = value
      End Set
    End Property

    Public Property FooterFont As Font
      Get
        Return _FooterFont
      End Get
      Set(value As Font)
        _FooterFont = value
      End Set
    End Property

    Public Property PageNumber As Boolean
      Get
        Return _pageNumber
      End Get
      Set(value As Boolean)
        _pageNumber = value
      End Set
    End Property

    Protected Overrides Sub OnEndPrint(e As PrintEventArgs)
      MyBase.OnEndPrint(e)

      If e.Cancel Then
        RaiseEvent ImpressaoCancelada()
      Else
        _printAction = e.PrintAction

        Select Case e.PrintAction
          Case PrintAction.PrintToFile, PrintAction.PrintToPrinter
            RaiseEvent Impresso()
          Case PrintAction.PrintToPreview
            RaiseEvent VisualizadoImpressao()
        End Select
      End If
    End Sub

    '// start printing the document
    Protected Overrides Sub OnBeginPrint(ByVal e As PrintEventArgs)
      '// we haven't printed anything yet
      _firstChar = 0
      _currentPage = 0

      'check whether we need a page count
      If _pageNumber Then
        _pageCount = -1
      Else
        _pageCount = IIf(Header.IndexOf(PAGES) > -1 OrElse Footer.IndexOf(PAGES) > -1, -1, 0)
      End If

      'fire event as usual
      MyBase.OnBeginPrint(e)
    End Sub

    Protected Overrides Sub OnPrintPage(e As PrintPageEventArgs)
      'get a page count if that is required
      If _pageCount < 0 Then
        _pageCount = GetPageCount(e)
      End If

      'update current page
      _currentPage = _currentPage + 1

      'render text
      Dim fmt As FORMATRANGE = GetFormatRange(e, _firstChar)
      Dim nextChar As Integer = _FormatRange(_rtb, True, fmt)

      e.Graphics.ReleaseHdc(fmt.hdc)

      'render header
      If (Not String.IsNullOrEmpty(Header)) Then
        Dim rc As Object = e.MarginBounds

        rc.Y = 0
        rc.Height = e.MarginBounds.Top
        rc.Width = 670

        If Left(Header, Len("file:")) = "file:" Then
          RenderImage(e, Mid(Header, Len("file:") + 1), rc)
        Else
          RenderHeaderFooter(e, Header, HeaderFont, rc, _HeaderAlign)
          e.Graphics.DrawLine(Pens.Black, rc.X, rc.Bottom, rc.Right, rc.Bottom)
        End If
      End If

      'render footer
      If (Not String.IsNullOrEmpty(Footer)) Then
        Dim rc As Object = e.MarginBounds

        rc.Y = rc.Bottom
        rc.Height = e.PageBounds.Bottom - rc.Y
        rc.Width = 670

        If Left(Footer, Len("file:")) = "file:" Then
          RenderImage(e, Mid(Footer, Len("file:") + 1), rc)
        Else
          RenderHeaderFooter(e, Footer, FooterFont, rc, _FooterAlign)
        End If

        e.Graphics.DrawLine(Pens.Black, rc.X, rc.Y, rc.Right, rc.Y)
      End If

      If _pageNumber Then
        Dim rcf As Rectangle = e.MarginBounds

        rcf.Y = 1090
        rcf.X = 100
        rcf.Height = 100
        rcf.Width = 670
        RenderHeaderFooter(e, "página [page] de [pages]", _FooterPageFont, rcf, StringAlignment.Far)
      End If

      'Dim rcs As Rectangle = e.MarginBounds

      'rcs.Y = 1030
      'rcs.X = 100
      'rcs.Height = 100
      'RenderHeaderFooter(e, FNC_Sistema_Dados, _FooterDadosSistema, rcs, StringAlignment.Center)

      'check whether we're done
      e.HasMorePages = nextChar > _firstChar AndAlso nextChar < _rtb.TextLength

      'save start char for next time
      _firstChar = nextChar

      'fire event as usual
      'MyBase.OnPrintPage(e)
    End Sub

    'ender a header or a footer on the current page
    Private Sub RenderHeaderFooter(ByVal e As PrintPageEventArgs, text As String, font As Font, rc As Rectangle, align As StringAlignment)
      Dim parts = text.Split("\t")

      RenderPart(e, text, font, rc, align)
    End Sub

    Private Sub RenderImage(e As PrintPageEventArgs, text As String, rc As Rectangle)
      Dim oImg As Image
      oImg = Image.FromFile(text)
      e.Graphics.DrawImage(oImg, rc)
    End Sub

    Private Sub RenderPart(e As PrintPageEventArgs, text As String, font As Font, rc As Rectangle, align As StringAlignment)
      'replace wildcards
      text = text.Replace(PAGE, _currentPage.ToString())
      text = text.Replace(PAGES, _pageCount.ToString())

      'prepare string format
      Dim fmt As StringFormat = New StringFormat()
      fmt.Alignment = align
      fmt.LineAlignment = StringAlignment.Center

      'render foote
      e.Graphics.DrawString(text, font, Brushes.Black, rc, fmt)
    End Sub

    'build a FORMATRANGE structure with the proper page size and hdc
    '(the hdc must be released after the FORMATRANGE is used)
    Private Function GetFormatRange(e As PrintPageEventArgs, firstChar As Integer) As FORMATRANGE
      'get page rectangle in twips
      Dim rc As Object = e.MarginBounds

      rc.X = (rc.X * 14.4 + 0.5)
      rc.Y = (rc.Y * 16 + 0.5)
      rc.Width = (rc.Width * 17.4 + 0.5)
      rc.Height = (rc.Height * 14.4 + 0.5)

      'set up FORMATRANGE structure

      Dim hdc As Object = e.Graphics.GetHdc()
      Dim fmt As Object = New FORMATRANGE()

      fmt.hdc = hdc
      fmt.hdcTarget = hdc
      fmt.rc = rc
      fmt.rcPage = fmt.rc
      fmt.cpMin = firstChar
      fmt.cpMax = -1

      Return fmt
    End Function

    'get a page count by using FormatRange to measure the content
    Private Function GetPageCount(e As PrintPageEventArgs) As Integer
      Dim pageCount As Integer = 0

      'count the pages using FormatRange
      Dim fmt As FORMATRANGE = GetFormatRange(e, 0)
      Dim firstCharX As Integer = 0

      Do While (firstCharX < _rtb.TextLength)
        fmt.cpMin = firstCharX
        firstCharX = _FormatRange(_rtb, False, fmt)
        pageCount = (pageCount + 1)
      Loop

      e.Graphics.ReleaseHdc(fmt.hdc)

      Return pageCount
    End Function

    'messages used by RichEd20.dll
    Const WM_USER As UInteger = 1024
    Const EM_FORMATRANGE As UInteger = WM_USER + 57

    'FORMATRANGE is used by RichEd20.dll to render RTF
    <StructLayout(LayoutKind.Sequential)> _
    Structure FORMATRANGE
      Public hdc As IntPtr
      Public hdcTarget As IntPtr
      Public rc As Rectangle
      Public rcPage As Rectangle
      Public cpMin As Integer
      Public cpMax As Integer
    End Structure

    'send the EM_FORMATRANGE message to the RichTextBox to render or measure
    'a range of the document into a target specified by a FORMATRANGE structure.
    Private Function _FormatRange(rtb As RichTextBox, render As Boolean, ByRef fmt As FORMATRANGE) As Integer
      Dim Param As Integer = IIf(render, 1, 0)
      Dim nextChar As IntPtr = SendMessageFormatRange(rtb.Handle, EM_FORMATRANGE, Param, fmt)

      'reset
      SendMessage(rtb.Handle, EM_FORMATRANGE, 0, 0)

      'return next character to print
      Return nextChar
    End Function
  End Class
End Module
