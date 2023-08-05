Imports System
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Module ImpressaoDireta
  Public Class AutoPrintCls
    Inherits PrintDocument

    Private m_pageSettings As PageSettings
    Private m_currentPage As Integer
    Private m_pages As List(Of Stream) = New List(Of Stream)()

    Public Sub New(ByVal serverReport As ServerReport)
      Me.New(CType(serverReport, Report))
      RenderAllServerReportPages(serverReport)
    End Sub

    Public Sub New(ByVal localReport As LocalReport)
      Me.New(CType(localReport, Report))
      RenderAllLocalReportPages(localReport)
    End Sub

    Public Sub New(ByVal report As Report)
      Dim reportPageSettings As ReportPageSettings = report.GetDefaultPageSettings()
      m_pageSettings = New PageSettings()
      m_pageSettings.PaperSize = reportPageSettings.PaperSize
      m_pageSettings.Margins = reportPageSettings.Margins
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      MyBase.Dispose(disposing)

      If disposing Then

        For Each s As Stream In m_pages
          s.Dispose()
        Next

        m_pages.Clear()
      End If
    End Sub

    Protected Overrides Sub OnBeginPrint(ByVal e As PrintEventArgs)
      MyBase.OnBeginPrint(e)
      m_currentPage = 0
    End Sub

    Protected Overrides Sub OnPrintPage(ByVal e As PrintPageEventArgs)
      MyBase.OnPrintPage(e)
      Dim pageToPrint As Stream = m_pages(m_currentPage)
      pageToPrint.Position = 0

      Using pageMetaFile As Metafile = New Metafile(pageToPrint)
        Dim adjustedRect As Rectangle = New Rectangle(e.PageBounds.Left - CInt(e.PageSettings.HardMarginX), e.PageBounds.Top - CInt(e.PageSettings.HardMarginY), e.PageBounds.Width, e.PageBounds.Height)
        e.Graphics.FillRectangle(Brushes.White, adjustedRect)
        e.Graphics.DrawImage(pageMetaFile, adjustedRect)
        m_currentPage += 1
        e.HasMorePages = m_currentPage < m_pages.Count
      End Using
    End Sub

    Protected Overrides Sub OnQueryPageSettings(ByVal e As QueryPageSettingsEventArgs)
      e.PageSettings = CType(m_pageSettings.Clone(), PageSettings)
    End Sub

    Private Sub RenderAllServerReportPages(ByVal serverReport As ServerReport)
      Try
        Dim deviceInfo As String = CreateEMFDeviceInfo()
        Dim firstPageParameters As NameValueCollection = New NameValueCollection()
        firstPageParameters.Add("rs:PersistStreams", "True")
        Dim nonFirstPageParameters As NameValueCollection = New NameValueCollection()
        nonFirstPageParameters.Add("rs:GetNextStream", "True")
        Dim mimeType As String
        Dim fileExtension As String
        Dim pageStream As Stream = serverReport.Render("IMAGE", deviceInfo, firstPageParameters, mimeType, fileExtension)

        While pageStream.Length > 0
          m_pages.Add(pageStream)
          pageStream = serverReport.Render("IMAGE", deviceInfo, nonFirstPageParameters, mimeType, fileExtension)
        End While

      Catch e As Exception
        MessageBox.Show("possible missing information ::  " + e.Message)
      End Try
    End Sub

    Private Sub RenderAllLocalReportPages(ByVal localReport As LocalReport)
      Try
        Dim deviceInfo As String = CreateEMFDeviceInfo()
        Dim warnings As Warning()
        localReport.Render("IMAGE", deviceInfo, AddressOf LocalReportCreateStreamCallback, warnings)
      Catch e As Exception
        MessageBox.Show("error :: " + e.Message)
      End Try
    End Sub

    Private Function LocalReportCreateStreamCallback(ByVal name As String, ByVal extension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
      Dim stream As MemoryStream = New MemoryStream()
      m_pages.Add(stream)
      Return stream
    End Function

    Private Function CreateEMFDeviceInfo() As String
      Dim paperSize As PaperSize = m_pageSettings.PaperSize
      Dim margins As Margins = m_pageSettings.Margins
      Return String.Format(CultureInfo.InvariantCulture, "<DeviceInfo><OutputFormat>emf</OutputFormat><StartPage>0</StartPage><EndPage>0</EndPage><MarginTop>{0}</MarginTop><MarginLeft>{1}</MarginLeft><MarginRight>{2}</MarginRight><MarginBottom>{3}</MarginBottom><PageHeight>{4}</PageHeight><PageWidth>{5}</PageWidth></DeviceInfo>", ToInches(margins.Top), ToInches(margins.Left), ToInches(margins.Right), ToInches(margins.Bottom), ToInches(paperSize.Height), ToInches(paperSize.Width))
    End Function

    Private Shared Function ToInches(ByVal hundrethsOfInch As Integer) As String
      Dim inches As Double = hundrethsOfInch / 100.0
      Return inches.ToString(CultureInfo.InvariantCulture) & "in"
    End Function
  End Class
End Module
