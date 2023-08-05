<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscEditorTexto
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscEditorTexto))
    Me.rtbDoc = New ExtendedRichTextBox.RichTextBoxPrintCtrl()
    Me.tlbFormatacao = New System.Windows.Forms.ToolStrip()
    Me.tblFormatacao_Fonte = New System.Windows.Forms.ToolStripButton()
    Me.tblFormatacao_Separador01 = New System.Windows.Forms.ToolStripSeparator()
    Me.tblFormatacao_AlinhaEsquerda = New System.Windows.Forms.ToolStripButton()
    Me.tblFormatacao_AlinhaCentralizado = New System.Windows.Forms.ToolStripButton()
    Me.tblFormatacao_AlinhaDireita = New System.Windows.Forms.ToolStripButton()
    Me.tblFormatacao_Separador02 = New System.Windows.Forms.ToolStripSeparator()
    Me.tblFormatacao_Negrito = New System.Windows.Forms.ToolStripButton()
    Me.tblFormatacao_Italico = New System.Windows.Forms.ToolStripButton()
    Me.tblFormatacao_Sublinhado = New System.Windows.Forms.ToolStripButton()
    Me.tblFormatacao_Separador03 = New System.Windows.Forms.ToolStripSeparator()
    Me.tblFormatacao_Pequisar = New System.Windows.Forms.ToolStripButton()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.mnuFuncoes = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFuncao_Limpar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFuncao_Separador01 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuFuncao_ConfigurarPagina = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFuncao_Visualizar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFuncao_Imprimir = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_Voltar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_Seguir = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_Separador01 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuEditar_Procurar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_ProcurarSubstituir = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_Separador02 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuEditar_SelecionarTudo = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_Separador03 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuEditar_Copiar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_Recortar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_Colar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuEditar_Separador04 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuEditar_InserirImagem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte_SelecionarFonte = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte_Separador01 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuFonte_Cor = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte_Separador02 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuFonte_Negrito = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte_Italico = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte_Sublinhado = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte_Normal = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte_Separador03 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuFonte_CorPagina = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Indentar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Indentar_Sem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Indentar_5 = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Indentar_10 = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Indentar_15 = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Indentar_20 = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Alinhar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Alinhar_Esquerda = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Alinhar_Centralizado = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuParagrafo_Alinhar_Direita = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuLista = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuLista_AdicionarBolas = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuLista_RemoverBolas = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuTabela = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuModelosDocumento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCampoDados = New System.Windows.Forms.ToolStripMenuItem()
    Me.FontDialog1 = New System.Windows.Forms.FontDialog()
    Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
    Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
    Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
    Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
    Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.mnuFonte_AumentarFonte = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFonte_DiminuirFonte = New System.Windows.Forms.ToolStripMenuItem()
    Me.tlbFormatacao.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'rtbDoc
    '
    Me.rtbDoc.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rtbDoc.Location = New System.Drawing.Point(0, 49)
    Me.rtbDoc.Name = "rtbDoc"
    Me.rtbDoc.Size = New System.Drawing.Size(654, 423)
    Me.rtbDoc.TabIndex = 5
    Me.rtbDoc.Text = ""
    '
    'tlbFormatacao
    '
    Me.tlbFormatacao.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tblFormatacao_Fonte, Me.tblFormatacao_Separador01, Me.tblFormatacao_AlinhaEsquerda, Me.tblFormatacao_AlinhaCentralizado, Me.tblFormatacao_AlinhaDireita, Me.tblFormatacao_Separador02, Me.tblFormatacao_Negrito, Me.tblFormatacao_Italico, Me.tblFormatacao_Sublinhado, Me.tblFormatacao_Separador03, Me.tblFormatacao_Pequisar})
    Me.tlbFormatacao.Location = New System.Drawing.Point(0, 24)
    Me.tlbFormatacao.Name = "tlbFormatacao"
    Me.tlbFormatacao.Size = New System.Drawing.Size(654, 25)
    Me.tlbFormatacao.TabIndex = 4
    '
    'tblFormatacao_Fonte
    '
    Me.tblFormatacao_Fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tblFormatacao_Fonte.Image = CType(resources.GetObject("tblFormatacao_Fonte.Image"), System.Drawing.Image)
    Me.tblFormatacao_Fonte.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tblFormatacao_Fonte.Name = "tblFormatacao_Fonte"
    Me.tblFormatacao_Fonte.Size = New System.Drawing.Size(23, 22)
    Me.tblFormatacao_Fonte.Text = "Selecionar fonte"
    '
    'tblFormatacao_Separador01
    '
    Me.tblFormatacao_Separador01.Name = "tblFormatacao_Separador01"
    Me.tblFormatacao_Separador01.Size = New System.Drawing.Size(6, 25)
    '
    'tblFormatacao_AlinhaEsquerda
    '
    Me.tblFormatacao_AlinhaEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tblFormatacao_AlinhaEsquerda.Image = CType(resources.GetObject("tblFormatacao_AlinhaEsquerda.Image"), System.Drawing.Image)
    Me.tblFormatacao_AlinhaEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tblFormatacao_AlinhaEsquerda.Name = "tblFormatacao_AlinhaEsquerda"
    Me.tblFormatacao_AlinhaEsquerda.Size = New System.Drawing.Size(23, 22)
    Me.tblFormatacao_AlinhaEsquerda.Text = "Alinha à Esquerda"
    '
    'tblFormatacao_AlinhaCentralizado
    '
    Me.tblFormatacao_AlinhaCentralizado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tblFormatacao_AlinhaCentralizado.Image = CType(resources.GetObject("tblFormatacao_AlinhaCentralizado.Image"), System.Drawing.Image)
    Me.tblFormatacao_AlinhaCentralizado.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tblFormatacao_AlinhaCentralizado.Name = "tblFormatacao_AlinhaCentralizado"
    Me.tblFormatacao_AlinhaCentralizado.Size = New System.Drawing.Size(23, 22)
    Me.tblFormatacao_AlinhaCentralizado.Text = "Centralizar"
    '
    'tblFormatacao_AlinhaDireita
    '
    Me.tblFormatacao_AlinhaDireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tblFormatacao_AlinhaDireita.Image = CType(resources.GetObject("tblFormatacao_AlinhaDireita.Image"), System.Drawing.Image)
    Me.tblFormatacao_AlinhaDireita.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tblFormatacao_AlinhaDireita.Name = "tblFormatacao_AlinhaDireita"
    Me.tblFormatacao_AlinhaDireita.Size = New System.Drawing.Size(23, 22)
    Me.tblFormatacao_AlinhaDireita.Text = "Alinha à Direita"
    '
    'tblFormatacao_Separador02
    '
    Me.tblFormatacao_Separador02.Name = "tblFormatacao_Separador02"
    Me.tblFormatacao_Separador02.Size = New System.Drawing.Size(6, 25)
    '
    'tblFormatacao_Negrito
    '
    Me.tblFormatacao_Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tblFormatacao_Negrito.Image = CType(resources.GetObject("tblFormatacao_Negrito.Image"), System.Drawing.Image)
    Me.tblFormatacao_Negrito.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tblFormatacao_Negrito.Name = "tblFormatacao_Negrito"
    Me.tblFormatacao_Negrito.Size = New System.Drawing.Size(23, 22)
    Me.tblFormatacao_Negrito.Text = "Colocar como negrito"
    '
    'tblFormatacao_Italico
    '
    Me.tblFormatacao_Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tblFormatacao_Italico.Image = CType(resources.GetObject("tblFormatacao_Italico.Image"), System.Drawing.Image)
    Me.tblFormatacao_Italico.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tblFormatacao_Italico.Name = "tblFormatacao_Italico"
    Me.tblFormatacao_Italico.Size = New System.Drawing.Size(23, 22)
    Me.tblFormatacao_Italico.Text = "Colocar como itálico"
    '
    'tblFormatacao_Sublinhado
    '
    Me.tblFormatacao_Sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tblFormatacao_Sublinhado.Image = CType(resources.GetObject("tblFormatacao_Sublinhado.Image"), System.Drawing.Image)
    Me.tblFormatacao_Sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tblFormatacao_Sublinhado.Name = "tblFormatacao_Sublinhado"
    Me.tblFormatacao_Sublinhado.Size = New System.Drawing.Size(23, 22)
    Me.tblFormatacao_Sublinhado.Text = "Colocar sublinhado"
    '
    'tblFormatacao_Separador03
    '
    Me.tblFormatacao_Separador03.Name = "tblFormatacao_Separador03"
    Me.tblFormatacao_Separador03.Size = New System.Drawing.Size(6, 25)
    '
    'tblFormatacao_Pequisar
    '
    Me.tblFormatacao_Pequisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.tblFormatacao_Pequisar.Image = CType(resources.GetObject("tblFormatacao_Pequisar.Image"), System.Drawing.Image)
    Me.tblFormatacao_Pequisar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tblFormatacao_Pequisar.Name = "tblFormatacao_Pequisar"
    Me.tblFormatacao_Pequisar.Size = New System.Drawing.Size(23, 22)
    Me.tblFormatacao_Pequisar.Text = "Pesquisar"
    '
    'MenuStrip1
    '
    Me.MenuStrip1.AllowMerge = False
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFuncoes, Me.mnuEditar, Me.mnuFonte, Me.mnuParagrafo, Me.mnuLista, Me.mnuTabela, Me.mnuModelosDocumento, Me.mnuCampoDados})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
    Me.MenuStrip1.ShowItemToolTips = True
    Me.MenuStrip1.Size = New System.Drawing.Size(654, 24)
    Me.MenuStrip1.Stretch = False
    Me.MenuStrip1.TabIndex = 3
    '
    'mnuFuncoes
    '
    Me.mnuFuncoes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFuncao_Limpar, Me.mnuFuncao_Separador01, Me.mnuFuncao_ConfigurarPagina, Me.mnuFuncao_Visualizar, Me.mnuFuncao_Imprimir})
    Me.mnuFuncoes.Name = "mnuFuncoes"
    Me.mnuFuncoes.Size = New System.Drawing.Size(63, 20)
    Me.mnuFuncoes.Text = "Funções"
    '
    'mnuFuncao_Limpar
    '
    Me.mnuFuncao_Limpar.Image = CType(resources.GetObject("mnuFuncao_Limpar.Image"), System.Drawing.Image)
    Me.mnuFuncao_Limpar.Name = "mnuFuncao_Limpar"
    Me.mnuFuncao_Limpar.Size = New System.Drawing.Size(170, 22)
    Me.mnuFuncao_Limpar.Text = "Limpar"
    '
    'mnuFuncao_Separador01
    '
    Me.mnuFuncao_Separador01.Name = "mnuFuncao_Separador01"
    Me.mnuFuncao_Separador01.Size = New System.Drawing.Size(167, 6)
    '
    'mnuFuncao_ConfigurarPagina
    '
    Me.mnuFuncao_ConfigurarPagina.Name = "mnuFuncao_ConfigurarPagina"
    Me.mnuFuncao_ConfigurarPagina.Size = New System.Drawing.Size(170, 22)
    Me.mnuFuncao_ConfigurarPagina.Text = "Configurar Página"
    '
    'mnuFuncao_Visualizar
    '
    Me.mnuFuncao_Visualizar.Name = "mnuFuncao_Visualizar"
    Me.mnuFuncao_Visualizar.Size = New System.Drawing.Size(170, 22)
    Me.mnuFuncao_Visualizar.Text = "Visualizar"
    '
    'mnuFuncao_Imprimir
    '
    Me.mnuFuncao_Imprimir.Image = CType(resources.GetObject("mnuFuncao_Imprimir.Image"), System.Drawing.Image)
    Me.mnuFuncao_Imprimir.Name = "mnuFuncao_Imprimir"
    Me.mnuFuncao_Imprimir.Size = New System.Drawing.Size(170, 22)
    Me.mnuFuncao_Imprimir.Text = "Imprimir"
    '
    'mnuEditar
    '
    Me.mnuEditar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditar_Voltar, Me.mnuEditar_Seguir, Me.mnuEditar_Separador01, Me.mnuEditar_Procurar, Me.mnuEditar_ProcurarSubstituir, Me.mnuEditar_Separador02, Me.mnuEditar_SelecionarTudo, Me.mnuEditar_Separador03, Me.mnuEditar_Copiar, Me.mnuEditar_Recortar, Me.mnuEditar_Colar, Me.mnuEditar_Separador04, Me.mnuEditar_InserirImagem})
    Me.mnuEditar.Name = "mnuEditar"
    Me.mnuEditar.Size = New System.Drawing.Size(49, 20)
    Me.mnuEditar.Text = "Editar"
    '
    'mnuEditar_Voltar
    '
    Me.mnuEditar_Voltar.Image = CType(resources.GetObject("mnuEditar_Voltar.Image"), System.Drawing.Image)
    Me.mnuEditar_Voltar.Name = "mnuEditar_Voltar"
    Me.mnuEditar_Voltar.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_Voltar.Text = "Voltar"
    '
    'mnuEditar_Seguir
    '
    Me.mnuEditar_Seguir.Image = CType(resources.GetObject("mnuEditar_Seguir.Image"), System.Drawing.Image)
    Me.mnuEditar_Seguir.Name = "mnuEditar_Seguir"
    Me.mnuEditar_Seguir.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_Seguir.Text = "Seguir"
    '
    'mnuEditar_Separador01
    '
    Me.mnuEditar_Separador01.Name = "mnuEditar_Separador01"
    Me.mnuEditar_Separador01.Size = New System.Drawing.Size(178, 6)
    '
    'mnuEditar_Procurar
    '
    Me.mnuEditar_Procurar.Image = CType(resources.GetObject("mnuEditar_Procurar.Image"), System.Drawing.Image)
    Me.mnuEditar_Procurar.Name = "mnuEditar_Procurar"
    Me.mnuEditar_Procurar.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_Procurar.Text = "Procurar"
    '
    'mnuEditar_ProcurarSubstituir
    '
    Me.mnuEditar_ProcurarSubstituir.Image = CType(resources.GetObject("mnuEditar_ProcurarSubstituir.Image"), System.Drawing.Image)
    Me.mnuEditar_ProcurarSubstituir.Name = "mnuEditar_ProcurarSubstituir"
    Me.mnuEditar_ProcurarSubstituir.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_ProcurarSubstituir.Text = "Procurar e Substituir"
    '
    'mnuEditar_Separador02
    '
    Me.mnuEditar_Separador02.Name = "mnuEditar_Separador02"
    Me.mnuEditar_Separador02.Size = New System.Drawing.Size(178, 6)
    '
    'mnuEditar_SelecionarTudo
    '
    Me.mnuEditar_SelecionarTudo.Name = "mnuEditar_SelecionarTudo"
    Me.mnuEditar_SelecionarTudo.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_SelecionarTudo.Text = "Selecionar Tudo"
    '
    'mnuEditar_Separador03
    '
    Me.mnuEditar_Separador03.Name = "mnuEditar_Separador03"
    Me.mnuEditar_Separador03.Size = New System.Drawing.Size(178, 6)
    '
    'mnuEditar_Copiar
    '
    Me.mnuEditar_Copiar.Image = CType(resources.GetObject("mnuEditar_Copiar.Image"), System.Drawing.Image)
    Me.mnuEditar_Copiar.Name = "mnuEditar_Copiar"
    Me.mnuEditar_Copiar.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_Copiar.Text = "Copiar"
    '
    'mnuEditar_Recortar
    '
    Me.mnuEditar_Recortar.Image = CType(resources.GetObject("mnuEditar_Recortar.Image"), System.Drawing.Image)
    Me.mnuEditar_Recortar.Name = "mnuEditar_Recortar"
    Me.mnuEditar_Recortar.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_Recortar.Text = "Recortar"
    '
    'mnuEditar_Colar
    '
    Me.mnuEditar_Colar.Image = CType(resources.GetObject("mnuEditar_Colar.Image"), System.Drawing.Image)
    Me.mnuEditar_Colar.Name = "mnuEditar_Colar"
    Me.mnuEditar_Colar.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_Colar.Text = "Colocar"
    '
    'mnuEditar_Separador04
    '
    Me.mnuEditar_Separador04.Name = "mnuEditar_Separador04"
    Me.mnuEditar_Separador04.Size = New System.Drawing.Size(178, 6)
    '
    'mnuEditar_InserirImagem
    '
    Me.mnuEditar_InserirImagem.Name = "mnuEditar_InserirImagem"
    Me.mnuEditar_InserirImagem.Size = New System.Drawing.Size(181, 22)
    Me.mnuEditar_InserirImagem.Text = "Inserir Imagem"
    '
    'mnuFonte
    '
    Me.mnuFonte.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFonte_SelecionarFonte, Me.mnuFonte_AumentarFonte, Me.mnuFonte_DiminuirFonte, Me.mnuFonte_Separador01, Me.mnuFonte_Cor, Me.mnuFonte_Separador02, Me.mnuFonte_Negrito, Me.mnuFonte_Italico, Me.mnuFonte_Sublinhado, Me.mnuFonte_Normal, Me.mnuFonte_Separador03, Me.mnuFonte_CorPagina})
    Me.mnuFonte.Name = "mnuFonte"
    Me.mnuFonte.Size = New System.Drawing.Size(49, 20)
    Me.mnuFonte.Text = "Fonte"
    '
    'mnuFonte_SelecionarFonte
    '
    Me.mnuFonte_SelecionarFonte.Image = CType(resources.GetObject("mnuFonte_SelecionarFonte.Image"), System.Drawing.Image)
    Me.mnuFonte_SelecionarFonte.Name = "mnuFonte_SelecionarFonte"
    Me.mnuFonte_SelecionarFonte.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_SelecionarFonte.Text = "Selecionar Fonte"
    '
    'mnuFonte_Separador01
    '
    Me.mnuFonte_Separador01.Name = "mnuFonte_Separador01"
    Me.mnuFonte_Separador01.Size = New System.Drawing.Size(177, 6)
    '
    'mnuFonte_Cor
    '
    Me.mnuFonte_Cor.Name = "mnuFonte_Cor"
    Me.mnuFonte_Cor.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_Cor.Text = "Cor"
    '
    'mnuFonte_Separador02
    '
    Me.mnuFonte_Separador02.Name = "mnuFonte_Separador02"
    Me.mnuFonte_Separador02.Size = New System.Drawing.Size(177, 6)
    '
    'mnuFonte_Negrito
    '
    Me.mnuFonte_Negrito.Image = CType(resources.GetObject("mnuFonte_Negrito.Image"), System.Drawing.Image)
    Me.mnuFonte_Negrito.Name = "mnuFonte_Negrito"
    Me.mnuFonte_Negrito.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_Negrito.Text = "Negrito"
    '
    'mnuFonte_Italico
    '
    Me.mnuFonte_Italico.Image = CType(resources.GetObject("mnuFonte_Italico.Image"), System.Drawing.Image)
    Me.mnuFonte_Italico.Name = "mnuFonte_Italico"
    Me.mnuFonte_Italico.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_Italico.Text = "Itálico"
    '
    'mnuFonte_Sublinhado
    '
    Me.mnuFonte_Sublinhado.Image = CType(resources.GetObject("mnuFonte_Sublinhado.Image"), System.Drawing.Image)
    Me.mnuFonte_Sublinhado.Name = "mnuFonte_Sublinhado"
    Me.mnuFonte_Sublinhado.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_Sublinhado.Text = "Sublinhado"
    '
    'mnuFonte_Normal
    '
    Me.mnuFonte_Normal.Name = "mnuFonte_Normal"
    Me.mnuFonte_Normal.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_Normal.Text = "&Normal"
    '
    'mnuFonte_Separador03
    '
    Me.mnuFonte_Separador03.Name = "mnuFonte_Separador03"
    Me.mnuFonte_Separador03.Size = New System.Drawing.Size(177, 6)
    '
    'mnuFonte_CorPagina
    '
    Me.mnuFonte_CorPagina.Name = "mnuFonte_CorPagina"
    Me.mnuFonte_CorPagina.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_CorPagina.Text = "Cor da Página"
    '
    'mnuParagrafo
    '
    Me.mnuParagrafo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuParagrafo_Indentar, Me.mnuParagrafo_Alinhar})
    Me.mnuParagrafo.Name = "mnuParagrafo"
    Me.mnuParagrafo.Size = New System.Drawing.Size(70, 20)
    Me.mnuParagrafo.Text = "Parágrafo"
    '
    'mnuParagrafo_Indentar
    '
    Me.mnuParagrafo_Indentar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuParagrafo_Indentar_Sem, Me.mnuParagrafo_Indentar_5, Me.mnuParagrafo_Indentar_10, Me.mnuParagrafo_Indentar_15, Me.mnuParagrafo_Indentar_20})
    Me.mnuParagrafo_Indentar.Name = "mnuParagrafo_Indentar"
    Me.mnuParagrafo_Indentar.Size = New System.Drawing.Size(118, 22)
    Me.mnuParagrafo_Indentar.Text = "Indentar"
    '
    'mnuParagrafo_Indentar_Sem
    '
    Me.mnuParagrafo_Indentar_Sem.Name = "mnuParagrafo_Indentar_Sem"
    Me.mnuParagrafo_Indentar_Sem.Size = New System.Drawing.Size(105, 22)
    Me.mnuParagrafo_Indentar_Sem.Text = "Sem"
    '
    'mnuParagrafo_Indentar_5
    '
    Me.mnuParagrafo_Indentar_5.Name = "mnuParagrafo_Indentar_5"
    Me.mnuParagrafo_Indentar_5.Size = New System.Drawing.Size(105, 22)
    Me.mnuParagrafo_Indentar_5.Text = "5 pts"
    '
    'mnuParagrafo_Indentar_10
    '
    Me.mnuParagrafo_Indentar_10.Name = "mnuParagrafo_Indentar_10"
    Me.mnuParagrafo_Indentar_10.Size = New System.Drawing.Size(105, 22)
    Me.mnuParagrafo_Indentar_10.Text = "10 pts"
    '
    'mnuParagrafo_Indentar_15
    '
    Me.mnuParagrafo_Indentar_15.Name = "mnuParagrafo_Indentar_15"
    Me.mnuParagrafo_Indentar_15.Size = New System.Drawing.Size(105, 22)
    Me.mnuParagrafo_Indentar_15.Text = "15 pts"
    '
    'mnuParagrafo_Indentar_20
    '
    Me.mnuParagrafo_Indentar_20.Name = "mnuParagrafo_Indentar_20"
    Me.mnuParagrafo_Indentar_20.Size = New System.Drawing.Size(105, 22)
    Me.mnuParagrafo_Indentar_20.Text = "20 pts"
    '
    'mnuParagrafo_Alinhar
    '
    Me.mnuParagrafo_Alinhar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuParagrafo_Alinhar_Esquerda, Me.mnuParagrafo_Alinhar_Centralizado, Me.mnuParagrafo_Alinhar_Direita})
    Me.mnuParagrafo_Alinhar.Name = "mnuParagrafo_Alinhar"
    Me.mnuParagrafo_Alinhar.Size = New System.Drawing.Size(118, 22)
    Me.mnuParagrafo_Alinhar.Text = "Alinhar"
    '
    'mnuParagrafo_Alinhar_Esquerda
    '
    Me.mnuParagrafo_Alinhar_Esquerda.Image = CType(resources.GetObject("mnuParagrafo_Alinhar_Esquerda.Image"), System.Drawing.Image)
    Me.mnuParagrafo_Alinhar_Esquerda.Name = "mnuParagrafo_Alinhar_Esquerda"
    Me.mnuParagrafo_Alinhar_Esquerda.Size = New System.Drawing.Size(140, 22)
    Me.mnuParagrafo_Alinhar_Esquerda.Text = "Esquerda"
    '
    'mnuParagrafo_Alinhar_Centralizado
    '
    Me.mnuParagrafo_Alinhar_Centralizado.Image = CType(resources.GetObject("mnuParagrafo_Alinhar_Centralizado.Image"), System.Drawing.Image)
    Me.mnuParagrafo_Alinhar_Centralizado.Name = "mnuParagrafo_Alinhar_Centralizado"
    Me.mnuParagrafo_Alinhar_Centralizado.Size = New System.Drawing.Size(140, 22)
    Me.mnuParagrafo_Alinhar_Centralizado.Text = "Centralizado"
    '
    'mnuParagrafo_Alinhar_Direita
    '
    Me.mnuParagrafo_Alinhar_Direita.Image = CType(resources.GetObject("mnuParagrafo_Alinhar_Direita.Image"), System.Drawing.Image)
    Me.mnuParagrafo_Alinhar_Direita.Name = "mnuParagrafo_Alinhar_Direita"
    Me.mnuParagrafo_Alinhar_Direita.Size = New System.Drawing.Size(140, 22)
    Me.mnuParagrafo_Alinhar_Direita.Text = "Direita"
    '
    'mnuLista
    '
    Me.mnuLista.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLista_AdicionarBolas, Me.mnuLista_RemoverBolas})
    Me.mnuLista.Name = "mnuLista"
    Me.mnuLista.Size = New System.Drawing.Size(43, 20)
    Me.mnuLista.Text = "Lista"
    '
    'mnuLista_AdicionarBolas
    '
    Me.mnuLista_AdicionarBolas.Name = "mnuLista_AdicionarBolas"
    Me.mnuLista_AdicionarBolas.Size = New System.Drawing.Size(156, 22)
    Me.mnuLista_AdicionarBolas.Text = "Adicionar Bolas"
    '
    'mnuLista_RemoverBolas
    '
    Me.mnuLista_RemoverBolas.Name = "mnuLista_RemoverBolas"
    Me.mnuLista_RemoverBolas.Size = New System.Drawing.Size(156, 22)
    Me.mnuLista_RemoverBolas.Text = "Remover Bolas"
    '
    'mnuTabela
    '
    Me.mnuTabela.Name = "mnuTabela"
    Me.mnuTabela.Size = New System.Drawing.Size(53, 20)
    Me.mnuTabela.Text = "Tabela"
    '
    'mnuModelosDocumento
    '
    Me.mnuModelosDocumento.Name = "mnuModelosDocumento"
    Me.mnuModelosDocumento.Size = New System.Drawing.Size(147, 20)
    Me.mnuModelosDocumento.Text = "Modelos de Documento"
    '
    'mnuCampoDados
    '
    Me.mnuCampoDados.Name = "mnuCampoDados"
    Me.mnuCampoDados.Size = New System.Drawing.Size(110, 20)
    Me.mnuCampoDados.Text = "Campo de Dados"
    '
    'PrintDialog1
    '
    Me.PrintDialog1.UseEXDialog = True
    '
    'PrintDocument1
    '
    '
    'PrintPreviewDialog1
    '
    Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
    Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
    Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
    Me.PrintPreviewDialog1.Enabled = True
    Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
    Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
    Me.PrintPreviewDialog1.Visible = False
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'mnuFonte_AumentarFonte
    '
    Me.mnuFonte_AumentarFonte.Name = "mnuFonte_AumentarFonte"
    Me.mnuFonte_AumentarFonte.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_AumentarFonte.Text = "Aumentar Fonte"
    '
    'mnuFonte_DiminuirFonte
    '
    Me.mnuFonte_DiminuirFonte.Name = "mnuFonte_DiminuirFonte"
    Me.mnuFonte_DiminuirFonte.Size = New System.Drawing.Size(180, 22)
    Me.mnuFonte_DiminuirFonte.Text = "Diminuir Fonte"
    '
    'uscEditorTexto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.rtbDoc)
    Me.Controls.Add(Me.tlbFormatacao)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Name = "uscEditorTexto"
    Me.Size = New System.Drawing.Size(654, 472)
    Me.tlbFormatacao.ResumeLayout(False)
    Me.tlbFormatacao.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents rtbDoc As ExtendedRichTextBox.RichTextBoxPrintCtrl
  Friend WithEvents tlbFormatacao As System.Windows.Forms.ToolStrip
  Friend WithEvents tblFormatacao_Fonte As System.Windows.Forms.ToolStripButton
  Friend WithEvents tblFormatacao_Separador01 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents tblFormatacao_AlinhaEsquerda As System.Windows.Forms.ToolStripButton
  Friend WithEvents tblFormatacao_AlinhaCentralizado As System.Windows.Forms.ToolStripButton
  Friend WithEvents tblFormatacao_AlinhaDireita As System.Windows.Forms.ToolStripButton
  Friend WithEvents tblFormatacao_Separador02 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents tblFormatacao_Negrito As System.Windows.Forms.ToolStripButton
  Friend WithEvents tblFormatacao_Italico As System.Windows.Forms.ToolStripButton
  Friend WithEvents tblFormatacao_Sublinhado As System.Windows.Forms.ToolStripButton
  Friend WithEvents tblFormatacao_Separador03 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents tblFormatacao_Pequisar As System.Windows.Forms.ToolStripButton
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents mnuFuncoes As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFuncao_Limpar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFuncao_Separador01 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuFuncao_ConfigurarPagina As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFuncao_Visualizar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFuncao_Imprimir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_Voltar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_Seguir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_Separador01 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuEditar_Procurar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_ProcurarSubstituir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_Separador02 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuEditar_SelecionarTudo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_Separador03 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuEditar_Copiar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_Recortar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_Colar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuEditar_Separador04 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuEditar_InserirImagem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte_SelecionarFonte As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte_Separador01 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuFonte_Cor As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte_Separador02 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuFonte_Negrito As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte_Italico As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte_Sublinhado As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte_Normal As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte_Separador03 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuFonte_CorPagina As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Indentar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Indentar_Sem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Indentar_5 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Indentar_10 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Indentar_15 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Indentar_20 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Alinhar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Alinhar_Esquerda As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Alinhar_Centralizado As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuParagrafo_Alinhar_Direita As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLista As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLista_AdicionarBolas As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLista_RemoverBolas As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
  Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
  Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
  Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
  Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents mnuModelosDocumento As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuTabela As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCampoDados As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuFonte_AumentarFonte As ToolStripMenuItem
  Friend WithEvents mnuFonte_DiminuirFonte As ToolStripMenuItem
End Class
