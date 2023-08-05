Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Imports System.Drawing.Printing
Imports System.IO

Public Class clsExtracticon
  <DllImport("shell32.dll")> _
  Private Shared Function ExtractIconEx( _
        ByVal lpszFile As String, ByVal nIconIndex As Integer, _
        ByRef phiconLarge As Integer, ByRef phiconSmall As Integer, _
        ByVal nIcons As UInteger) As Integer
  End Function
  <DllImport("shell32.dll")> _
  Private Shared Function ExtractIcon( _
        ByVal hInst As Integer, ByVal lpszExeFileName As String, _
        ByVal nIconIndex As Integer) As IntPtr
  End Function
  <DllImport("user32.dll")> _
  Private Shared Function GetClassLong( _
        ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
  End Function

  Private Const GCW_HMODULE As Integer = (-16)

  Public Function IconToPictureBox( _
          ByVal picBox As PictureBox, _
          ByVal sPath As String, _
          ByVal indice As Integer) As Boolean

    Dim icono As Icon = IconPorIndice(sPath, indice)
    If icono IsNot Nothing Then
      picBox.Image = icono.ToBitmap
      Return True
    End If

    Return False
  End Function
  Public Function IconPorIndice( _
          ByVal sPath As String, _
          ByVal indice As Integer) As Icon
    Dim hInst As Integer
    Dim hIcon As IntPtr
    hInst = GetClassLong(IntPtr.Zero, GCW_HMODULE)
    hIcon = ExtractIcon(hInst, sPath, indice)
    If hIcon <> IntPtr.Zero Then
      Return Icon.FromHandle(hIcon)
    End If
    Return Nothing
  End Function
  Public Function TotalIconos(ByVal sPath As String) As Integer
    Return ExtractIconEx(sPath, -1, 0, 0, 0)
  End Function
  Public Function IconAsociado(ByVal sFic As String) As Icon
    Dim icono As Icon = Nothing
    Try
      icono = Icon.ExtractAssociatedIcon(sFic)
    Catch 'ex As Exception
    End Try

    Return icono
  End Function

  Public Function IconToBitmap(ByVal icono As Icon) As Bitmap
    If icono Is Nothing Then
      Return Nothing
    Else
      Return icono.ToBitmap
    End If
  End Function
End Class

Public Class clsImpressao
  Dim WithEvents oPrintDocumento As PrintDocument

  Class clsImprmir
    Enum enTipo
      Texto = 1
      Retangulo = 2
      Linha = 3
      NovaPagina = 4
      Imagem = 5
    End Enum

    Public Tipo As enTipo = enTipo.Texto
    Public Arquivo As String
    Public Texto As String
    Public EstiloPreenchimento As Drawing2D.DashStyle = Nothing
    Public Dimensao As Rectangle
    Public Fonte As Font
    Public Cor As Color
    Public Espessura As Integer
    Public Ponto1 As Point
    Public Ponto2 As Point
  End Class

  Public Impressao_ImprmirPaginaColorida As Boolean = False
  Public Impressao_CorPreenchimento As Color

  Dim cImprimir As Collection
  Dim iImprimir_Indice As Integer = 1

  Public Fonte As Font
  Public Fonte_Cor As Color

  Public Sub New()
    oPrintDocumento = New PrintDocument()
    cImprimir = New Collection

    With oPrintDocumento
      .OriginAtMargins = True
    End With
  End Sub

  Protected Overrides Sub Finalize()
    MyBase.Finalize()

    oPrintDocumento = Nothing
  End Sub

  Private Sub Imprmir(eTipo As clsImprmir.enTipo, _
                      Optional Arquivo As String = "", _
                      Optional Texto As String = "", _
                      Optional EstiloPreenchimento As Drawing2D.DashStyle = Nothing, _
                      Optional Dimensao As Rectangle = Nothing, _
                      Optional Fonte As Font = Nothing, _
                      Optional Cor As Color = Nothing, _
                      Optional iEspessura As Integer = 0, _
                      Optional Ponto1 As Point = Nothing, _
                      Optional Ponto2 As Point = Nothing)
    Dim oImprimir As New clsImprmir

    With oImprimir
      .Arquivo = Arquivo
      .Tipo = eTipo
      .Texto = Texto
      .EstiloPreenchimento = EstiloPreenchimento
      .Dimensao = Dimensao
      .Fonte = Fonte
      .Cor = Cor
      .Espessura = iEspessura
      .Ponto1 = Ponto1
      .Ponto2 = Ponto2
    End With

    cImprimir.Add(oImprimir)
  End Sub

  Public Property Impressao_QuantidadeCopias As Short
    Get
      Return oPrintDocumento.DefaultPageSettings.PrinterSettings.Copies
    End Get
    Set(iValor As Short)
      oPrintDocumento.DefaultPageSettings.PrinterSettings.Copies = iValor
    End Set
  End Property

  Public ReadOnly Property Impressao_Pagina_TamanhoArea As RectangleF
    Get
      Return oPrintDocumento.DefaultPageSettings.PrintableArea
    End Get
  End Property

  Public ReadOnly Property Impressao_Pagina_Margem As Margins
    Get
      Return oPrintDocumento.DefaultPageSettings.Margins
    End Get
  End Property

  Public Property Impressao_Pagina_Origem As System.Drawing.Printing.PaperSource
    Get
      Return oPrintDocumento.DefaultPageSettings.PaperSource
    End Get
    Set(Valor As System.Drawing.Printing.PaperSource)
      oPrintDocumento.DefaultPageSettings.PaperSource = Valor
    End Set
  End Property

  Public Property Impressao_Pagina_TamanhoMargem As Margins
    Set(Valor As Margins)
      oPrintDocumento.DefaultPageSettings.Margins = Valor
    End Set
    Get
      Return oPrintDocumento.DefaultPageSettings.Margins
    End Get
  End Property

  Public ReadOnly Property Impressao_Pagina_TamanhoPagina As Rectangle
    Get
      Return oPrintDocumento.DefaultPageSettings.Bounds
    End Get
  End Property

  Public Property Impressao_Pagina_Resolucao As System.Drawing.Printing.PrinterResolution
    Get
      Return oPrintDocumento.DefaultPageSettings.PrinterResolution
    End Get
    Set(Valor As System.Drawing.Printing.PrinterResolution)
      oPrintDocumento.DefaultPageSettings.PrinterResolution = Valor
    End Set
  End Property

  Public Property Impressao_Duplex As System.Drawing.Printing.Duplex
    Get
      Return oPrintDocumento.DefaultPageSettings.PrinterSettings.Duplex
    End Get
    Set(Valor As System.Drawing.Printing.Duplex)
      If oPrintDocumento.DefaultPageSettings.PrinterSettings.CanDuplex Then
        oPrintDocumento.DefaultPageSettings.PrinterSettings.Duplex = Valor
      End If
    End Set
  End Property

  Public Property Impressao_Fonte As Font
    Get
      Return Fonte
    End Get
    Set(Valor As Font)
      Fonte = Valor
    End Set
  End Property

  Public Property Impressao_FonteNegrito As Boolean
    Get
      Return Fonte.Bold
    End Get
    Set(bValor As Boolean)
      Fonte = FNC_Fonte(Fonte, , True)
    End Set
  End Property

  Public Property Impressao_FonteItalico As Boolean
    Get
      Return Fonte.Italic
    End Get
    Set(bValor As Boolean)
      Fonte = FNC_Fonte(Fonte, , , , True)
    End Set
  End Property

  Public Property Impressao_FonteTamanho As Single
    Get
      Return Fonte.Size
    End Get
    Set(iValor As Single)
      Fonte = FNC_Fonte(Fonte, iValor)
    End Set
  End Property

  Public Property Impressao_FonteTachada As Boolean
    Get
      Return Fonte.Italic
    End Get
    Set(bValor As Boolean)
      Fonte = FNC_Fonte(Fonte, , , , , True)
    End Set
  End Property

  Public Property Impressao_FonteSublinhada As Boolean
    Get
      Return Fonte.Italic
    End Get
    Set(bValor As Boolean)
      Fonte = FNC_Fonte(Fonte, , , True)
    End Set
  End Property

  Public Property Impressao_FonteCor As Color
    Get
      Return Fonte_Cor
    End Get
    Set(Valor As Color)
      Fonte_Cor = Valor
    End Set
  End Property

  Public ReadOnly Property Impressora_Nome As String
    Get
      Return oPrintDocumento.PrinterSettings.PrinterName
    End Get
  End Property

  Public Property Impressora_TamanhoPapel_Tipo As System.Drawing.Printing.PaperKind
    Get
      Return oPrintDocumento.DefaultPageSettings.PaperSize.Kind
    End Get
    Set(Valor As System.Drawing.Printing.PaperKind)
      Dim iCont As Integer

      For iCont = 0 To oPrintDocumento.PrinterSettings.PaperSizes.Count - 1
        If oPrintDocumento.PrinterSettings.PaperSizes(iCont).Kind = Valor Then
          oPrintDocumento.DefaultPageSettings.PaperSize = oPrintDocumento.PrinterSettings.PaperSizes(iCont)
        End If
      Next
    End Set
  End Property

  Public ReadOnly Property Impressora_TamanhoPapel As System.Drawing.Printing.PaperSize
    Get
      Return oPrintDocumento.DefaultPageSettings.PaperSize
    End Get
  End Property

  Public Sub Impressao_NovaPagina()
    Dim oImprmir As New clsImprmir

    Imprmir(clsImprmir.enTipo.NovaPagina)
  End Sub

  Public Sub Impressao_InserirImagem(sArquivo As String, _
                                     iVertical As Integer, _
                                     iHorizontal As Integer, _
                                     Optional iLargura As Integer = -1,
                                     Optional iAltura As Integer = -1)
    Imprmir(clsImprmir.enTipo.Imagem, sArquivo, , , New Rectangle(iHorizontal, iVertical, iLargura, iAltura))
  End Sub

  Public Sub Impressao_InserirTexto(sTexto As String, _
                                    iVertical As Integer, _
                                    iHorizontal As Integer, _
                                    Optional Fonte As Font = Nothing, _
                                    Optional Fonte_Tamanho As Integer = 0)
    Imprmir(clsImprmir.enTipo.Texto, , sTexto, , , FNC_Fonte(Fonte, Fonte_Tamanho), , , New Point(iHorizontal, iVertical))
  End Sub

  Public Sub Impressao_Imprimir()
    oPrintDocumento.Print()
  End Sub

  Public Sub Impressao_ImprimirArquivo(sCaminhoArquivo As String)
    Try
      Dim oArquivo = New StreamReader(sCaminhoArquivo)

      Try
        Dim pd As New PrintDocument()

        pd.Print()
      Finally
        oArquivo.Close()
      End Try
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub 'Printing

  Public Sub Impressao_Visualizar()
    Dim Visualizacao As New PrintPreviewDialog

    Visualizacao.PrintPreviewControl.AutoZoom = True
    Visualizacao.Document = oPrintDocumento
    Visualizacao.ShowDialog()
  End Sub

  Public Property Impressao_Pagina_OrientacaoRetrato As Boolean
    Get
      Return oPrintDocumento.DefaultPageSettings.Landscape
    End Get
    Set(bValor As Boolean)
      oPrintDocumento.DefaultPageSettings.Landscape = bValor
    End Set
  End Property

  Public Property Impressao_NomeDocumento As String
    Get
      Return oPrintDocumento.DocumentName
    End Get
    Set(sValor As String)
      oPrintDocumento.DocumentName = sValor
    End Set
  End Property

  Public Sub Impressao_InserirLinha(iPontoInicial_Horizontal As Integer, _
                                    iPontoInicial_Vertical As Integer, _
                                    iPontoFinal_Horizontal As Integer, _
                                    iPontoFinal_Vertical As Integer, _
                                    Optional Cor As Color = Nothing, _
                                    Optional Espessura As Integer = 0)
    Imprmir(clsImprmir.enTipo.Linha, , , , , , _
            Cor, _
            Espessura, _
            New Point(iPontoInicial_Horizontal, iPontoInicial_Vertical), _
            New Point(iPontoFinal_Horizontal, iPontoFinal_Vertical))
  End Sub

  Private Sub oPrinter_BeginPrint(sender As Object, e As PrintEventArgs) Handles oPrintDocumento.BeginPrint
    If oPrintDocumento.PrinterSettings.IsValid Then
      If oPrintDocumento.PrinterSettings.SupportsColor Then
        oPrintDocumento.DefaultPageSettings.Color = Impressao_ImprmirPaginaColorida
      End If
    End If
  End Sub

  Private Sub oPrintDocumento_PrintPage(sender As Object, e As PrintPageEventArgs) Handles oPrintDocumento.PrintPage
    Dim oImprmir As clsImprmir

    'For iCont = 1 To cImprimir.Count
    Do While iImprimir_Indice <= cImprimir.Count
      oImprmir = CType(cImprimir(iImprimir_Indice), clsImprmir)

      With oImprmir
        Select Case .Tipo
          Case clsImprmir.enTipo.Texto
            e.Graphics.DrawString(.Texto, .Fonte, Brushes.Black, .Ponto1)
          Case clsImprmir.enTipo.Retangulo
            Dim oPen As Pen

            oPen = New Pen(Brushes.Black)

            If Not .EstiloPreenchimento = Nothing Then
              oPen.DashStyle = .EstiloPreenchimento
            End If
            If .Espessura > 0 Then
              oPen.Width = .Espessura
            End If

            e.Graphics.DrawRectangle(oPen, .Dimensao)
          Case clsImprmir.enTipo.Linha
            Dim oPen As Pen

            oPen = New Pen(Brushes.Black)

            If Not .EstiloPreenchimento = Nothing Then
              oPen.DashStyle = .EstiloPreenchimento
            End If
            If .Espessura > 0 Then
              oPen.Width = .Espessura
            End If

            e.Graphics.DrawLine(oPen, .Ponto1, .Ponto2)
          Case clsImprmir.enTipo.NovaPagina
            iImprimir_Indice = iImprimir_Indice + 1
            e.HasMorePages = True
            Exit Do
          Case clsImprmir.enTipo.Imagem
            Dim Imagem As Image = Image.FromFile(.Arquivo)

            If .Dimensao.Width = -1 Then
              e.Graphics.DrawImage(Imagem, New Point(.Dimensao.X, .Dimensao.Y))
            Else
              e.Graphics.DrawImage(Imagem, .Dimensao)
            End If
        End Select
      End With

      iImprimir_Indice = iImprimir_Indice + 1
    Loop
    'Next

    If iImprimir_Indice = cImprimir.Count Then
      e.HasMorePages = False
    End If
  End Sub
End Class

Public Class clsHistorico
  Dim oHistorico_Controle As Collection

  Public ID_Registro As Integer

  Public Sub Inicializar()
    oHistorico_Controle = New Collection
  End Sub

  Public Sub Controle_LimparValorAtual()
    oHistorico_Controle.Clear()
  End Sub

  Public Sub Controle_ValorAtual(oControle As Object, ByVal Valor As Object)
    Dim bOk As Boolean = True

    'Try
    '  oControle.Value = Valor
    'Catch ex1 As Exception
    '  Try
    '    oControle.Text = Valor
    '  Catch ex2 As Exception
    '    Try
    '      If TypeOf oControle Is System.Windows.Forms.ComboBox Then
    '        ComboBox_Possicionar(oControle, Valor)

    '        Valor = oControle.Text
    '      End If
    '    Catch ex3 As Exception
    '      bOk = False
    '    End Try
    '  End Try
    'End Try

    If bOk Then
      oHistorico_Controle.Add(New Object() {oControle.Name, Valor})
    End If
  End Sub

  Public Sub GravarHistorico(iProcesso As Integer,
                             iAcao As Integer,
                             iErro As Integer,
                             sCodigo As String,
                             sObservacao As String,
                             ParamArray oControle As Object())
    Dim sTexto As String = ""
    Dim iCont01 As Integer
    Dim iCont02 As Integer

    If (Not oControle Is Nothing) Then
      For iCont01 = 0 To oControle.Length - 1 Step 2
        Select Case iAcao
          Case enOpcoes.Processo_Acao_Inclusao.GetHashCode,
             enOpcoes.Processo_Acao_Exclusao.GetHashCode
            GravarHistorico_Controle(sTexto, oControle(iCont01 + 1), oControle(iCont01), "", False)
          Case enOpcoes.Processo_Acao_Alteracao.GetHashCode
            For iCont02 = 1 To oHistorico_Controle.Count
              If oControle(iCont01).Name = oHistorico_Controle(iCont02)(0) Then
                If FNC_Contem(oControle(iCont01 + 1), "valor", "vl") Then
                  GravarHistorico_Controle(sTexto, oControle(iCont01 + 1), oControle(iCont01), FormatCurrency(oHistorico_Controle(iCont02)(1)), True)
                Else
                  GravarHistorico_Controle(sTexto, oControle(iCont01 + 1), oControle(iCont01), oHistorico_Controle(iCont02)(1), True)
                End If
              End If
            Next
        End Select
      Next
    End If

    If Trim(sObservacao) <> "" Then
      sTexto = sObservacao + Environment.NewLine + Environment.NewLine + sTexto
    End If

    FNC_Historico_Incluir(iProcesso, iAcao, iErro, ID_Registro, sTexto, sCodigo)
  End Sub

  Private Sub GravarHistorico_Controle(ByRef sTexto As String, oControle01 As Object, oControle02 As Object, sHistorico As String, bDePara As Boolean)
    Dim sValor As String = ""

    Try
      If TypeOf oControle02 Is uscPesqPessoa Then
        sValor = oControle02.DS_Pessoa
      ElseIf TypeOf oControle02 Is uscPesqProcedimento Then
        sValor = oControle02.Codigo + " " + oControle02.Nome
      Else
        If FNC_Contem(oControle01, "valor", "vl") Then
          sValor = FormatCurrency(oControle02.Value)
        Else
          sValor = oControle02.Value
        End If
      End If
    Catch ex1 As Exception
      Try
        sValor = oControle02.Text.ToString()
      Catch ex2 As Exception
        Try
          If TypeOf oControle02 Is System.Windows.Forms.ComboBox Then
            sValor = oControle02.Text.ToString()
          End If
        Catch ex3 As Exception
          FNC_Mensagem("HISTÓRICO - Não foi possível fazer o tratamento para o campo '" + oControle01 + "'")
        End Try
      End Try
    End Try

    If bDePara Then
      If FNC_NVL(sHistorico, "").Trim() <> FNC_NVL(sValor, "").Trim() Then
        FNC_Str_Adicionar(sTexto, oControle01 + " De " + FNC_QuotedStr(sHistorico) + " para " + FNC_QuotedStr(sValor), vbCrLf)
      End If
    Else
      FNC_Str_Adicionar(sTexto, oControle01 + " = " + sValor, vbCrLf)
    End If
  End Sub
End Class