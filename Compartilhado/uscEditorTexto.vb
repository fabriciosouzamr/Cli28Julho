Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class uscEditorTexto
  Public Event Impresso()
  Public Event VisualizadoImpressao()

  Private WithEvents oRichTextBoxDocument As RichTextBoxDocument

  Dim currentFile As String
  Dim checkPrint As Integer

  Dim iID_MODELO_CABECALHO As Integer = enModeloDocumentoElemento_Padrao.Cabecalho.GetHashCode
  Dim iID_MODELO_ASSINATURA As Integer = enModeloDocumentoElemento_Padrao.Assinatura.GetHashCode
  Dim iID_MODELO_RODAPE As Integer = enModeloDocumentoElemento_Padrao.Rodape.GetHashCode
  Dim iID_OPT_TIPO_MODELODOCUMENTO As Integer
  Dim iSQ_MODELODOCUMENTO As Integer
  Dim iID_DICIONARIODADO_PROCESSO As Integer
  Dim iIDENTIFICADOR As Integer

  Dim bExibirNumeroPagina As Boolean
  Dim bTextoAlterado As Boolean
  Dim bCarregandoTexto As Boolean

  Private Sub FNC_RichTextBox_InserirTabela(Rtb As RichTextBox, vRows As Integer, vCols As Integer)
    Dim A As String
    Dim Fonte As String = "{\fonttbl{\f0\fnil\fcharset0 Comic Sans MS;}{\f1\fnil\fcharset0 Castellar;}"

    A = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1046\deflangfe1046\deftab708" &
         Fonte & "{\f1\fswiss\fprq2\fcharset0 Calibri;}}" &
        "{\colortbl ;\red255\green255\blue0;\red0\green255\blue0;}" &
        "{\*\generator Riched20 10.0.14393}" &
        "{\*\mmathPr\mnaryLim0\mdispDef1\mwrapIndent1440 }" &
        "\viewkind4\uc1" &
        "\trowd\trgaph70\trleft5\trqc\trrh240" &
        "\trbrdrl\brdrs\brdrw10" &
        "\trbrdrt\brdrs\brdrw10" &
        "\trbrdrr\brdrs\brdrw10" &
        "\trbrdrb\brdrs\brdrw10" &
        "\trpaddl70\trpaddr70\trpaddfl3\trpaddfr3" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx1408" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx4251" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx6375" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8499" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx9499" &
        "\pard\intbl\widctlpar\cf2\highlight1\b0\f0\fs22 Nome\cell Rua\cell Cor\cell Sexo\cell\ Idade\cell\row" &
        "\trowd\trgaph70\trleft5\trqc\trrh240" &
        "\trbrdrl\brdrs\brdrw10" &
        "\trbrdrt\brdrs\brdrw10" &
        "\trbrdrr\brdrs\brdrw10" &
        "\trbrdrb\brdrs\brdrw10" &
        "\trbrdrb\brdrs\brdrw10" &
        "\trpaddl70\trpaddr70\trpaddfl3\trpaddfr3" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx1408" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx4251" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx6375" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8499" &
        "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx9499" &
        "\pard\intbl\widctlpar\cf0\highlight0\b\f1\fs20 Fabr\'edcio\cell Monte Cristo\cell Moreno\cell Masculino\cell\32\cell\row" &
        "\pard\intbl\widctlpar\cf0\highlight0\b\f1\fs20 Jomar\cell Morador de Rua\cell Preto\cell Masculino\cell\24\cell\row" &
        "\pard\widctlpar\sa160\sl252\slmult1\par}"

    A = FNC_RichTextBox_CriarTabela(New String() {"Nome", "Rua", "Cor", "Sexo", "Idade"},
                                    New Object() {New String() {"Fabríco", "Monte Cristo", "Moreno", "Masculino", "38"},
                                                  New String() {"Jomar", "Rua das Bibas", "Preto", "Gay", "24"},
                                                  New String() {"Jomar", "Rua das Bibas", "Preto", "Gay", "24"},
                                                  New String() {"Jomar", "Rua das Bibas", "Preto", "Gay", "24"},
                                                  New String() {"Jomar", "Rua das Bibas", "Preto", "Gay", "24"},
                                                  New String() {"Jomar", "Rua das Bibas", "Preto", "Gay", "24"},
                                                  New String() {"Jomar", "Rua das Bibas", "Preto", "Gay", "24"},
                                                  New String() {"Jomar", "Rua das Bibas", "Preto", "Gay", "24"}})
    A = FNC_RichTextBox_CriarTabela(5, 14)

    Rtb.SelectedRtf = A
    Rtb.SelectionAlignment = HorizontalAlignment.Center
  End Sub

  Private Sub mnuFuncao_Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFuncao_Limpar.Click
    rtbDoc.Clear()
  End Sub

  Private Sub mnuEditar_SelecionarTudo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_SelecionarTudo.Click
    Try
      rtbDoc.SelectAll()
    Catch exc As Exception
    End Try
  End Sub

  Private Sub mnuEditar_Copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_Copiar.Click
    Try
      rtbDoc.Copy()
    Catch exc As Exception
    End Try
  End Sub

  Private Sub mnuEditar_Recortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_Recortar.Click
    Try
      rtbDoc.Cut()
    Catch exc As Exception
    End Try
  End Sub

  Private Sub mnuEditar_Colar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_Colar.Click
    Try
      rtbDoc.Paste()
    Catch exc As Exception
    End Try
  End Sub

  Private Sub mnuFonte_SelecionarFonte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFonte_SelecionarFonte.Click
    If Not rtbDoc.SelectionFont Is Nothing Then
      FontDialog1.Font = rtbDoc.SelectionFont
    Else
      FontDialog1.Font = Nothing
    End If

    FontDialog1.ShowApply = True

    If FontDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
      rtbDoc.SelectionFont = FontDialog1.Font
    End If
  End Sub

  Private Sub mnuFonte_Cor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFonte_Cor.Click
    ColorDialog1.Color = rtbDoc.ForeColor

    If ColorDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
      rtbDoc.SelectionColor = ColorDialog1.Color
    End If
  End Sub

  Private Sub Fonte_Formatar(oEstilo As System.Drawing.FontStyle)
    If Not rtbDoc.SelectionFont Is Nothing Then
      Dim currentFont As System.Drawing.Font = rtbDoc.SelectionFont
      Dim newFontStyle As System.Drawing.FontStyle

      If oEstilo = FontStyle.Bold Then
        If Not rtbDoc.SelectionFont.Bold Then newFontStyle = newFontStyle + FontStyle.Bold
      Else
        If rtbDoc.SelectionFont.Bold Then newFontStyle = newFontStyle + FontStyle.Bold
      End If
      If oEstilo = FontStyle.Italic Then
        If Not rtbDoc.SelectionFont.Italic Then newFontStyle = newFontStyle + FontStyle.Italic
      Else
        If rtbDoc.SelectionFont.Italic Then newFontStyle = newFontStyle + FontStyle.Italic
      End If
      If oEstilo = FontStyle.Underline Then
        If Not rtbDoc.SelectionFont.Underline Then newFontStyle = newFontStyle + FontStyle.Underline
      Else
        If rtbDoc.SelectionFont.Underline Then newFontStyle = newFontStyle + FontStyle.Underline
      End If

      rtbDoc.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
    End If
  End Sub

  Private Sub mnuFonte_Negrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFonte_Negrito.Click
    Fonte_Formatar(FontStyle.Bold)
  End Sub

  Private Sub mnuFonte_Italico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFonte_Italico.Click
    Fonte_Formatar(FontStyle.Italic)
  End Sub

  Private Sub mnuFonte_Sublinhado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFonte_Sublinhado.Click
    Fonte_Formatar(FontStyle.Underline)
  End Sub

  Private Sub mnuFonte_Normal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFonte_Normal.Click
    If Not rtbDoc.SelectionFont Is Nothing Then
      Dim currentFont As System.Drawing.Font = rtbDoc.SelectionFont
      Dim newFontStyle As System.Drawing.FontStyle
      newFontStyle = FontStyle.Regular

      rtbDoc.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
    End If
  End Sub

  Private Sub mnuFonte_CorPagina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFonte_CorPagina.Click
    ColorDialog1.Color = rtbDoc.BackColor

    If ColorDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
      rtbDoc.BackColor = ColorDialog1.Color
    End If
  End Sub

  Private Sub mnuEditar_Voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_Voltar.Click
    If rtbDoc.CanUndo Then rtbDoc.Undo()
  End Sub

  Private Sub mnuEditar_Seguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_Seguir.Click
    If rtbDoc.CanRedo Then rtbDoc.Redo()
  End Sub

  Private Sub mnuParagrafo_Alinhar_Esquerda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParagrafo_Alinhar_Esquerda.Click
    rtbDoc.SelectionAlignment = HorizontalAlignment.Left
  End Sub

  Private Sub mnuParagrafo_Alinhar_Centralizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParagrafo_Alinhar_Centralizado.Click
    rtbDoc.SelectionAlignment = HorizontalAlignment.Center
  End Sub

  Private Sub mnuParagrafo_Alinhar_Direita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParagrafo_Alinhar_Direita.Click
    rtbDoc.SelectionAlignment = HorizontalAlignment.Right
  End Sub

  Private Sub mnuLista_AdicionarBolas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLista_AdicionarBolas.Click
    rtbDoc.BulletIndent = 10
    rtbDoc.SelectionBullet = True
  End Sub

  Private Sub mnuLista_RemoverBolas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLista_RemoverBolas.Click
    rtbDoc.SelectionBullet = False
  End Sub

  Private Sub mnuParagrafo_Indentar_Sem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParagrafo_Indentar_Sem.Click
    rtbDoc.SelectionIndent = 0
  End Sub

  Private Sub mnuParagrafo_Indentar_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParagrafo_Indentar_5.Click
    rtbDoc.SelectionIndent = 5
  End Sub

  Private Sub mnuParagrafo_Indentar_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParagrafo_Indentar_10.Click
    rtbDoc.SelectionIndent = 10
  End Sub

  Private Sub mnuParagrafo_Indentar_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParagrafo_Indentar_15.Click
    rtbDoc.SelectionIndent = 15
  End Sub

  Private Sub mnuParagrafo_Indentar_20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParagrafo_Indentar_20.Click
    rtbDoc.SelectionIndent = 20
  End Sub

  Private Sub mnuEditar_Procurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_Procurar.Click
    Dim oForm As New frmRichTextBox_Pesquisar()

    oForm.ortbDoc = rtbDoc
    oForm.Show()
  End Sub

  Private Sub mnuEditar_ProcurarSubstituir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_ProcurarSubstituir.Click
    Dim oForm As New frmRichTextBox_Substituir

    oForm.ortbDoc = rtbDoc
    oForm.Show()
  End Sub

  Public Sub Abrir(sArquivo As String)
    If Trim(sArquivo) = "" Then
      FNC_Mensagem("É preciso informar o caminho do arquivo a ser carregado")
    Else
      If Dir(sArquivo) = "" Then
        FNC_Mensagem("Arquivo informado não existe")
      Else
        bCarregandoTexto = True
        rtbDoc.LoadFile(sArquivo)
        bCarregandoTexto = False
      End If
    End If
  End Sub

  Public Sub Salvar(sArquivo As String)
    If Dir(sArquivo) <> "" Then Kill(sArquivo)

    rtbDoc.SaveFile(sArquivo, RichTextBoxStreamType.RichText)
  End Sub

  Private Sub mnuFuncao_Visualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFuncao_Visualizar.Click
    FNC_RichTextBoxDocument_Visualizar(oRichTextBoxDocument, rtbDoc, iID_MODELO_CABECALHO, iID_MODELO_ASSINATURA, iID_MODELO_RODAPE, bExibirNumeroPagina)
  End Sub

  Private Sub mnuFuncao_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFuncao_Imprimir.Click
    Dim oText As RichTextBoxDocument = FNC_RichTextBoxDocument_Carregar(oRichTextBoxDocument, rtbDoc, iID_MODELO_CABECALHO, iID_MODELO_ASSINATURA, iID_MODELO_RODAPE, bExibirNumeroPagina)

    PrintDialog1.Document = oText

    If PrintDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
      oText.Print()
    End If
  End Sub

  Private Sub mnuFuncao_ConfigurarPagina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFuncao_ConfigurarPagina.Click
    PageSetupDialog1.Document = FNC_RichTextBoxDocument_Carregar(oRichTextBoxDocument, rtbDoc, iID_MODELO_CABECALHO, iID_MODELO_ASSINATURA, iID_MODELO_RODAPE, bExibirNumeroPagina)
    PageSetupDialog1.ShowDialog()
  End Sub

  Private Sub mnuModeloDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim oMenu As ToolStripMenuItem

    oMenu = sender

    If oMenu.OwnerItem.Name = mnuModelosDocumento.Name Then
      MODELODOCUMENTO = oMenu.Tag
    End If
  End Sub

  Private Sub mnuEditar_InserirImagem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditar_InserirImagem.Click
    OpenFileDialog1.Title = "Inserir Imagem"
    OpenFileDialog1.DefaultExt = "rtf"
    OpenFileDialog1.Filter = "Bitmap|*.bmp|JPEG|*.jpg|GIF|*.gif"
    OpenFileDialog1.FilterIndex = 1
    OpenFileDialog1.ShowDialog()
    OpenFileDialog1.FileName = ""

    If OpenFileDialog1.FileName = "" Then Exit Sub

    Try
      Dim strImagePath As String = OpenFileDialog1.FileName
      Dim img As Image
      img = Image.FromFile(strImagePath)
      Clipboard.SetDataObject(img)
      Dim df As DataFormats.Format
      df = DataFormats.GetFormat(DataFormats.Bitmap)
      If Me.rtbDoc.CanPaste(df) Then
        Me.rtbDoc.Paste(df)
      End If
    Catch ex As Exception
      MessageBox.Show("Não é possível inserir a imagem selecionada.", "Inserir Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub tblFormatacao_Negrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblFormatacao_Negrito.Click
    mnuFonte_Negrito_Click(Me, e)
  End Sub

  Private Sub tblFormatacao_Italico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblFormatacao_Italico.Click
    mnuFonte_Italico_Click(Me, e)
  End Sub

  Private Sub tblFormatacao_Subilinhado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblFormatacao_Sublinhado.Click
    mnuFonte_Sublinhado_Click(Me, e)
  End Sub

  Private Sub tblFormatacao_Fonte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblFormatacao_Fonte.Click
    mnuFonte_SelecionarFonte_Click(Me, e)
  End Sub

  Private Sub tblFormatacao_AlinhaEsquerda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblFormatacao_AlinhaEsquerda.Click
    rtbDoc.SelectionAlignment = HorizontalAlignment.Left
  End Sub

  Private Sub tblFormatacao_AlinhaCentralizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblFormatacao_AlinhaCentralizado.Click
    rtbDoc.SelectionAlignment = HorizontalAlignment.Center
  End Sub

  Private Sub tblFormatacao_AlinhaDireita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblFormatacao_AlinhaDireita.Click
    rtbDoc.SelectionAlignment = HorizontalAlignment.Right
  End Sub

  Private Sub tblFormatacao_Pequisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblFormatacao_Pequisar.Click
    Dim oForm As New frmRichTextBox_Pesquisar()

    oForm.ortbDoc = rtbDoc
    oForm.Show()
  End Sub

  Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint    '
    checkPrint = 0
  End Sub

  Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    checkPrint = rtbDoc.Print(checkPrint, rtbDoc.TextLength, e)

    If checkPrint < rtbDoc.TextLength Then
      e.HasMorePages = True
    Else
      e.HasMorePages = False
    End If
  End Sub

  Public Sub CarregarArquivo(sArquivo As String)
    Dim strExt As String

    strExt = System.IO.Path.GetExtension(sArquivo)
    strExt = strExt.ToUpper()

    bCarregandoTexto = True

    Select Case strExt
      Case ".RTF"
        rtbDoc.LoadFile(sArquivo, RichTextBoxStreamType.RichText)
      Case Else
        Dim txtReader As System.IO.StreamReader

        txtReader = New System.IO.StreamReader(sArquivo)
        rtbDoc.Text = txtReader.ReadToEnd
        txtReader.Close()
        txtReader = Nothing
        rtbDoc.SelectionStart = 0
        rtbDoc.SelectionLength = 0
    End Select

    bCarregandoTexto = False
  End Sub

  Public Property Rtf() As String
    Get
      Return rtbDoc.Rtf
    End Get
    Set(ByVal Valor As String)
      rtbDoc.Rtf = Valor
    End Set
  End Property

  Public Property Texto() As String
    Get
      Return rtbDoc.Text
    End Get
    Set(ByVal Valor As String)
      rtbDoc.Text = Valor
    End Set
  End Property

  Public Property TIPO_MODELODOCUMENTO As Integer
    Get
      Return iID_OPT_TIPO_MODELODOCUMENTO
    End Get
    Set(value As Integer)
      iID_OPT_TIPO_MODELODOCUMENTO = value
      CarregarModelosDocumento()
    End Set
  End Property

  Public Property DICIONARIODADO_PROCESSO As Integer
    Get
      Return iID_DICIONARIODADO_PROCESSO
    End Get
    Set(value As Integer)
      iID_DICIONARIODADO_PROCESSO = value
      CarregarDicionarioDados_Macro()
    End Set
  End Property

  Public Property MODELODOCUMENTO As Integer
    Get
      Return iSQ_MODELODOCUMENTO
    End Get
    Set(value As Integer)
      iSQ_MODELODOCUMENTO = value
      ModeloDocumento_Carregar(rtbDoc, iSQ_MODELODOCUMENTO, iID_MODELO_CABECALHO, iID_MODELO_ASSINATURA, iID_MODELO_RODAPE, bExibirNumeroPagina, iIDENTIFICADOR)
    End Set
  End Property

  Public Property SoLeitura() As Boolean
    Get
      Return rtbDoc.ReadOnly
    End Get
    Set(ByVal Valor As Boolean)
      rtbDoc.ReadOnly = Valor
    End Set
  End Property

  Public Property MODELO_CABECALHO As Integer
    Get
      Return iID_MODELO_CABECALHO
    End Get
    Set(value As Integer)
      iID_MODELO_CABECALHO = value
    End Set
  End Property

  Public Property MODELO_ASSINATURA As Integer
    Get
      Return iID_MODELO_ASSINATURA
    End Get
    Set(value As Integer)
      iID_MODELO_ASSINATURA = value
    End Set
  End Property

  Public Property MODELO_RODAPE As Integer
    Get
      Return iID_MODELO_RODAPE
    End Get
    Set(value As Integer)
      iID_MODELO_RODAPE = value
    End Set
  End Property

  Public Property ExibirNumeroPagina As Boolean
    Get
      Return bExibirNumeroPagina
    End Get
    Set(value As Boolean)
      bExibirNumeroPagina = value
    End Set
  End Property

  Public Sub Limpar()
    mnuFuncao_Limpar_Click(Nothing, Nothing)
  End Sub

  Public Sub Imprimir()
    mnuFuncao_Imprimir.PerformClick()
  End Sub

  Private Sub CarregarModelosDocumento()
    mnuModelosDocumento.DropDownItems.Clear()

    If iID_OPT_TIPO_MODELODOCUMENTO > 0 Then
      Dim oData As DataTable
      Dim sSqlText As String
      Dim iCont As Integer

      sSqlText = "SELECT SQ_MODELODOCUMENTO, NO_MODELODOCUMENTO FROM VW_MODELODOCUMENTO" &
                 " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " AND ID_OPT_TIPO_MODELODOCUMENTO = " & iID_OPT_TIPO_MODELODOCUMENTO &
                 " ORDER BY NO_MODELODOCUMENTO"
      oData = DBQuery(sSqlText)

      For iCont = 0 To oData.Rows.Count - 1
        With mnuModelosDocumento.DropDownItems.Add(oData.Rows(iCont).Item("NO_MODELODOCUMENTO"), Nothing, AddressOf mnuModeloDocumento_Click)
          .Tag = oData.Rows(iCont).Item("SQ_MODELODOCUMENTO")
        End With
      Next

      mnuModelosDocumento.Visible = (mnuModelosDocumento.DropDownItems.Count > 0)
    End If
  End Sub

  Private Sub CarregarDicionarioDados_Macro_Sistema()
    Dim oItem As ToolStripItem
    Dim oMenuItem As ToolStripMenuItem

    mnuCampoDados.DropDownItems.Clear()

    '> Formatação Data / Cálculo Matemático
    oItem = mnuCampoDados.DropDownItems.Add("Formatação de Data / Cálculo Matemático")
    oItem.Tag = enDicionarioDados.FormatacaoData_CalculoMatematico
    oMenuItem = oItem
    oMenuItem = oMenuItem.DropDownItems.Add("Formatação de Data")

    CarregarDicionarioDados_Macro_Sistema_Data(oMenuItem.DropDownItems.Add("Data"), "D")
    CarregarDicionarioDados_Macro_Sistema_Data(oMenuItem.DropDownItems.Add("Mês"), "M")
    CarregarDicionarioDados_Macro_Sistema_Data(oMenuItem.DropDownItems.Add("Ano"), "A")
    CarregarDicionarioDados_Macro_Sistema_Data(oMenuItem.DropDownItems.Add("Hora"), "H")

    oMenuItem = oItem
    oMenuItem = oMenuItem.DropDownItems.Add("Cálculo Matemático")

    With oMenuItem.DropDownItems.Add("Adicionar")
      .Tag = const_Sistema_DicionarioDados_Menu_CalculoMatematico_Adicionar
      AddHandler .Click, AddressOf MenuCampoDados_Click
    End With
    With oMenuItem.DropDownItems.Add("Subtrair")
      .Tag = const_Sistema_DicionarioDados_Menu_CalculoMatematico_Subtrair
      AddHandler .Click, AddressOf MenuCampoDados_Click
    End With
    With oMenuItem.DropDownItems.Add("Multiplicar")
      .Tag = const_Sistema_DicionarioDados_Menu_CalculoMatematico_Multiplicar
      AddHandler .Click, AddressOf MenuCampoDados_Click
    End With
    With oMenuItem.DropDownItems.Add("Dividir")
      .Tag = const_Sistema_DicionarioDados_Menu_CalculoMatematico_Dividir
      AddHandler .Click, AddressOf MenuCampoDados_Click
    End With
    With oMenuItem.DropDownItems.Add("Porcentagem")
      .Tag = const_Sistema_DicionarioDados_Menu_CalculoMatematico_Porcetagem
      AddHandler .Click, AddressOf MenuCampoDados_Click
    End With

    '> Informação do Sistema
    oItem = mnuCampoDados.DropDownItems.Add("Informação do Sistema")
    oItem.Tag = enDicionarioDados.InformacoesSistema
    oMenuItem = oItem

    With oMenuItem.DropDownItems.Add("Data Atual")
      .Tag = const_Sistema_DicionarioDados_Menu_Data
      AddHandler .Click, AddressOf MenuCampoDados_Click
    End With
    With oMenuItem.DropDownItems.Add("Nome do Sistema")
      .Tag = const_Sistema_DicionarioDados_Menu_Nome
      AddHandler .Click, AddressOf MenuCampoDados_Click
    End With
  End Sub

  Private Sub CarregarDicionarioDados_Macro_Sistema_Data(oMenuItem As ToolStripMenuItem, sGrupoMes As String)
    Dim oMenuItemAux_01 As ToolStripMenuItem = Nothing
    Dim oMenuItemAux_02 As ToolStripMenuItem = Nothing
    Dim sGrupoMesAux As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim bAdicionar As Boolean

    For iCont_01 = 0 To 1
      sGrupoMesAux = sGrupoMes

      Select Case iCont_01
        Case 0
          oMenuItemAux_01 = oMenuItem.DropDownItems.Add("Adicionar")
          bAdicionar = True
        Case 1
          oMenuItemAux_01 = oMenuItem.DropDownItems.Add("Retirar")
          bAdicionar = False
      End Select

      For iCont_02 = 0 To 1
        Select Case iCont_02
          Case 0
            oMenuItemAux_02 = oMenuItemAux_01.DropDownItems.Add("Data")
            sGrupoMesAux = sGrupoMes & "N@"
          Case 1
            oMenuItemAux_02 = oMenuItemAux_01.DropDownItems.Add("Data (Dia útil)")
            sGrupoMesAux = sGrupoMes & "U@"
        End Select

        sGrupoMesAux = sGrupoMesAux & IIf(bAdicionar, "+", "-")

        With oMenuItemAux_02
          With .DropDownItems.Add("Data")
            .Tag = "#" & Replace(sGrupoMesAux, "@", "N") & "00#"
            AddHandler .Click, AddressOf MenuCampoDados_Click
          End With
          With .DropDownItems.Add("Data por Extenso")
            .Tag = "#" & Replace(sGrupoMesAux, "@", "E") & "00#"
            AddHandler .Click, AddressOf MenuCampoDados_Click
          End With
          With .DropDownItems.Add("Data e Hora")
            .Tag = "#" & Replace(sGrupoMesAux, "@", "G") & "00#"
            AddHandler .Click, AddressOf MenuCampoDados_Click
          End With
          With .DropDownItems.Add("Data por Extenso e Hora")
            .Tag = "#" & Replace(sGrupoMesAux, "@", "J") & "00#"
            AddHandler .Click, AddressOf MenuCampoDados_Click
          End With
          With .DropDownItems.Add("Data por Extenso e Hora por Extenso")
            .Tag = "#" & Replace(sGrupoMesAux, "@", "F") & "00#"
            AddHandler .Click, AddressOf MenuCampoDados_Click
          End With
          With .DropDownItems.Add("Hora")
            .Tag = "#" & Replace(sGrupoMesAux, "@", "H") & "00#"
            AddHandler .Click, AddressOf MenuCampoDados_Click
          End With
          With .DropDownItems.Add("Hora Extenso")
            .Tag = "#" & Replace(sGrupoMesAux, "@", "I") & "00#"
            AddHandler .Click, AddressOf MenuCampoDados_Click
          End With
        End With
      Next
    Next
  End Sub

  Private Sub CarregarDicionarioDados_Macro()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim oItem As ToolStripItem
    Dim oMenuItem As ToolStripMenuItem
    Dim sAux As String

    mnuCampoDados.DropDownItems.Clear()

    If iID_DICIONARIODADO_PROCESSO > 0 Then
      CarregarDicionarioDados_Macro_Sistema()

      sSqlText = "SELECT DDV.SQ_DICIONARIODADO_VISAO," &
                        "DDV.NO_DICIONARIODADO_VISAO" &
                 " FROM TB_DICIONARIODADO_PROCESSO_VISAO DPV" &
                  " INNER JOIN TB_DICIONARIODADO_VISAO DDV ON DDV.SQ_DICIONARIODADO_VISAO = DPV.ID_DICIONARIODADO_VISAO" &
                 " WHERE DPV.ID_DICIONARIODADO_PROCESSO = " & iID_DICIONARIODADO_PROCESSO &
                 " ORDER BY DDV.NO_DICIONARIODADO_VISAO"
      oData = DBQuery(sSqlText)

      For iCont_01 = 0 To oData.Rows.Count - 1
        oItem = mnuCampoDados.DropDownItems.Add(oData.Rows(iCont_01).Item("NO_DICIONARIODADO_VISAO"))
        oItem.Tag = oData.Rows(iCont_01).Item("SQ_DICIONARIODADO_VISAO")
      Next

      For iCont_01 = 0 To mnuCampoDados.DropDownItems.Count - 1
        If Not FNC_In(mnuCampoDados.DropDownItems(iCont_01).Tag, enDicionarioDados.InformacoesSistema.GetHashCode,
                                                                 enDicionarioDados.FormatacaoData_CalculoMatematico.GetHashCode) Then
          sSqlText = "SELECT * FROM VW_DICIONARIODADO_VISAO_CAMPO" &
                     " WHERE SQ_DICIONARIODADO_VISAO = " & mnuCampoDados.DropDownItems(iCont_01).Tag &
                     " ORDER BY DS_CAMPO"
          oData = DBQuery(sSqlText)

          For iCont_02 = 0 To oData.Rows.Count - 1
            oMenuItem = mnuCampoDados.DropDownItems(iCont_01)
            oMenuItem = oMenuItem.DropDownItems.Add(oData.Rows(iCont_02).Item("DS_CAMPO"))
            sAux = Trim(oData.Rows(iCont_02).Item("NO_CAMPO_MACRO"))
            sAux = "#" & Replace(sAux, "#", "_" & Trim(oData.Rows(iCont_01).Item("SQ_DICIONARIODADO_VISAO").ToString) & "#", 2)
            oMenuItem.Tag = sAux

            AddHandler oMenuItem.Click, AddressOf MenuCampoDados_Click
          Next
        End If
      Next
    End If

    mnuCampoDados.Visible = (mnuCampoDados.DropDownItems.Count > 0)
  End Sub

  Private Sub uscEditorTexto_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
    Try
      oRichTextBoxDocument.Dispose()
      oRichTextBoxDocument = Nothing
    Catch ex As Exception
    End Try
  End Sub

  Private Sub TabelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTabela.Click
    FNC_RichTextBox_InserirTabela(rtbDoc, 3, 3)
  End Sub

  Public Sub New()
    InitializeComponent()

    mnuModelosDocumento.Visible = False
    mnuTabela.Visible = False
    mnuCampoDados.Visible = False
  End Sub

  Private Sub rtbDoc_TextChanged(sender As Object, e As EventArgs) Handles rtbDoc.TextChanged
    If Not bCarregandoTexto Then bTextoAlterado = True
  End Sub

  Private Sub oRichTextBoxDocument_Impresso() Handles oRichTextBoxDocument.Impresso
    RaiseEvent Impresso()
  End Sub

  Private Sub oRichTextBoxDocument_VisualizadoImpressao() Handles oRichTextBoxDocument.VisualizadoImpressao
    RaiseEvent VisualizadoImpressao()
  End Sub

  Private Sub uscEditorTexto_Load(sender As Object, e As EventArgs) Handles Me.Load
    oRichTextBoxDocument = New RichTextBoxDocument(rtbDoc)
  End Sub

  Public ReadOnly Property HouveAlteracao
    Get
      Return bTextoAlterado
    End Get
  End Property

  Public Sub RealizadoGravacao()
    bTextoAlterado = False
  End Sub

  Public Sub Inicializar()
    bTextoAlterado = False
  End Sub

  Public Property IDENTIFICADOR As Integer
    Get
      Return iIDENTIFICADOR
    End Get
    Set(value As Integer)
      iIDENTIFICADOR = value
    End Set
  End Property

  Private Sub MenuCampoDados_Click(sender As Object, e As EventArgs)
    Dim oMenuItem As ToolStripMenuItem

    oMenuItem = sender

    Try
      Me.rtbDoc.SelectedText = oMenuItem.Tag
    Catch ex As Exception
    End Try
  End Sub

  Private Sub mnuFonte_AumentarFonte_Click(sender As Object, e As EventArgs) Handles mnuFonte_AumentarFonte.Click
    aplicaTamanhoFonte(Me.rtbDoc, 1)
  End Sub

  Private Sub aplicaTamanhoFonte(ByRef notes As RichTextBox, Ajuste As Integer)
    Dim inicial As Integer

    If notes.SelectionLength = 0 Then notes.SelectAll()

    Dim total As Integer = notes.SelectionLength()

    For inicial = notes.SelectionStart To notes.SelectionStart + total
      notes.Select(inicial, 1)
      Dim estilo As FontStyle = notes.SelectionFont.Style
      notes.SelectionFont = New Font(notes.SelectionFont.FontFamily, notes.SelectionFont.Size + Ajuste, notes.SelectionFont.Style)
    Next
  End Sub

  Private Sub mnuFonte_DiminuirFonte_Click(sender As Object, e As EventArgs) Handles mnuFonte_DiminuirFonte.Click
    aplicaTamanhoFonte(Me.rtbDoc, -1)
  End Sub
End Class