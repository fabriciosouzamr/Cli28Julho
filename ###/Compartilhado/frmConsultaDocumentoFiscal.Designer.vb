<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaDocumentoFiscal
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()>
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Exigido pelo Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
  'Pode ser modificado usando o Windows Form Designer.  
  'Não o modifique usando o editor de códigos.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboNaturezaOperacao = New System.Windows.Forms.ComboBox()
        Me.cboSerieDocumentoFiscal = New System.Windows.Forms.ComboBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoFiscal = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodDocumento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdBaixarXML = New System.Windows.Forms.Button()
        Me.cmsBaixarXML = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsBaixarXML_BaixarTodosListados = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCartaCorrecao = New System.Windows.Forms.Button()
        Me.cmdHistorico = New System.Windows.Forms.Button()
        Me.cmdTransmitir_NFe = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.cmdNovo = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdLimpar = New System.Windows.Forms.Button()
        Me.cmdPDF = New System.Windows.Forms.Button()
        Me.cmdCopiar = New System.Windows.Forms.Button()
        Me.cmdDevolver = New System.Windows.Forms.Button()
        Me.psqProduto = New SisMattos.uscpsqProduto()
        Me.psqPessoa = New SisMattos.uscPesqPessoa()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsBaixarXML.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 324
        Me.Label2.Text = "Natureza de Operação"
        '
        'cboNaturezaOperacao
        '
        Me.cboNaturezaOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNaturezaOperacao.FormattingEnabled = True
        Me.cboNaturezaOperacao.Location = New System.Drawing.Point(5, 20)
        Me.cboNaturezaOperacao.Name = "cboNaturezaOperacao"
        Me.cboNaturezaOperacao.Size = New System.Drawing.Size(607, 21)
        Me.cboNaturezaOperacao.TabIndex = 1
        '
        'cboSerieDocumentoFiscal
        '
        Me.cboSerieDocumentoFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSerieDocumentoFiscal.FormattingEnabled = True
        Me.cboSerieDocumentoFiscal.Location = New System.Drawing.Point(1032, 20)
        Me.cboSerieDocumentoFiscal.Name = "cboSerieDocumentoFiscal"
        Me.cboSerieDocumentoFiscal.Size = New System.Drawing.Size(85, 21)
        Me.cboSerieDocumentoFiscal.TabIndex = 7
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(1032, 5)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(31, 13)
        Me.Label60.TabIndex = 371
        Me.Label60.Text = "Série"
        '
        'cboTipoDocumentoFiscal
        '
        Me.cboTipoDocumentoFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumentoFiscal.FormattingEnabled = True
        Me.cboTipoDocumentoFiscal.Location = New System.Drawing.Point(807, 20)
        Me.cboTipoDocumentoFiscal.Name = "cboTipoDocumentoFiscal"
        Me.cboTipoDocumentoFiscal.Size = New System.Drawing.Size(219, 21)
        Me.cboTipoDocumentoFiscal.TabIndex = 6
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(807, 5)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(28, 13)
        Me.Label54.TabIndex = 369
        Me.Label54.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(703, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 376
        Me.Label7.Text = "a"
        '
        'txtDataFinal
        '
        Me.txtDataFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataFinal.Location = New System.Drawing.Point(716, 20)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataFinal.TabIndex = 3
        Me.txtDataFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtDataInicial
        '
        Me.txtDataInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataInicial.Location = New System.Drawing.Point(618, 20)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataInicial.TabIndex = 2
        Me.txtDataInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(618, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 374
        Me.Label4.Text = "Período de Emissão"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 384
        Me.Label1.Tag = "Listagem de Pessoa"
        Me.Label1.Text = "Listagem de Pessoa"
        '
        'grdListagem
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdListagem.DisplayLayout.Appearance = Appearance1
        Me.grdListagem.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdListagem.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdListagem.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdListagem.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdListagem.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdListagem.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdListagem.DisplayLayout.MaxColScrollRegions = 1
        Me.grdListagem.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdListagem.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdListagem.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdListagem.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdListagem.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagem.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdListagem.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdListagem.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdListagem.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdListagem.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdListagem.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdListagem.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdListagem.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.grdListagem.DisplayLayout.Override.RowAppearance = Appearance11
        Me.grdListagem.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdListagem.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.grdListagem.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdListagem.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdListagem.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdListagem.Location = New System.Drawing.Point(5, 144)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(1112, 294)
        Me.grdListagem.TabIndex = 378
        Me.grdListagem.Text = "UltraGrid1"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(618, 62)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(178, 21)
        Me.cboStatus.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(618, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 387
        Me.Label3.Text = "Status"
        '
        'txtCodDocumento
        '
        Me.txtCodDocumento.Location = New System.Drawing.Point(804, 62)
        Me.txtCodDocumento.Name = "txtCodDocumento"
        Me.txtCodDocumento.Size = New System.Drawing.Size(87, 20)
        Me.txtCodDocumento.TabIndex = 391
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(804, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 392
        Me.Label5.Text = "Nº Documento"
        '
        'cmdBaixarXML
        '
        Me.cmdBaixarXML.ContextMenuStrip = Me.cmsBaixarXML
        Me.cmdBaixarXML.Image = Global.SisMattos.My.Resources.Resources.Mini_XML
        Me.cmdBaixarXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBaixarXML.Location = New System.Drawing.Point(974, 444)
        Me.cmdBaixarXML.Name = "cmdBaixarXML"
        Me.cmdBaixarXML.Size = New System.Drawing.Size(56, 28)
        Me.cmdBaixarXML.TabIndex = 393
        Me.cmdBaixarXML.Text = " XML"
        Me.cmdBaixarXML.UseVisualStyleBackColor = True
        '
        'cmsBaixarXML
        '
        Me.cmsBaixarXML.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsBaixarXML_BaixarTodosListados})
        Me.cmsBaixarXML.Name = "ContextMenuStrip1"
        Me.cmsBaixarXML.Size = New System.Drawing.Size(187, 26)
        '
        'cmsBaixarXML_BaixarTodosListados
        '
        Me.cmsBaixarXML_BaixarTodosListados.Name = "cmsBaixarXML_BaixarTodosListados"
        Me.cmsBaixarXML_BaixarTodosListados.Size = New System.Drawing.Size(186, 22)
        Me.cmsBaixarXML_BaixarTodosListados.Text = "Baixar Todos Listados"
        '
        'cmdCartaCorrecao
        '
        Me.cmdCartaCorrecao.Image = Global.SisMattos.My.Resources.Resources.Mini_CartaCorrecao
        Me.cmdCartaCorrecao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCartaCorrecao.Location = New System.Drawing.Point(432, 444)
        Me.cmdCartaCorrecao.Name = "cmdCartaCorrecao"
        Me.cmdCartaCorrecao.Size = New System.Drawing.Size(119, 28)
        Me.cmdCartaCorrecao.TabIndex = 390
        Me.cmdCartaCorrecao.Text = "      Carta de Correção"
        Me.cmdCartaCorrecao.UseVisualStyleBackColor = True
        '
        'cmdHistorico
        '
        Me.cmdHistorico.Image = Global.SisMattos.My.Resources.Resources.Mini_Historico_1
        Me.cmdHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHistorico.Location = New System.Drawing.Point(725, 444)
        Me.cmdHistorico.Name = "cmdHistorico"
        Me.cmdHistorico.Size = New System.Drawing.Size(75, 28)
        Me.cmdHistorico.TabIndex = 388
        Me.cmdHistorico.Text = "    Histórico"
        Me.cmdHistorico.UseVisualStyleBackColor = True
        '
        'cmdTransmitir_NFe
        '
        Me.cmdTransmitir_NFe.Image = Global.SisMattos.My.Resources.Resources.Mini_NFe_Transmitir
        Me.cmdTransmitir_NFe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTransmitir_NFe.Location = New System.Drawing.Point(171, 444)
        Me.cmdTransmitir_NFe.Name = "cmdTransmitir_NFe"
        Me.cmdTransmitir_NFe.Size = New System.Drawing.Size(109, 28)
        Me.cmdTransmitir_NFe.TabIndex = 102
        Me.cmdTransmitir_NFe.Text = "    Transmitir NF-e"
        Me.cmdTransmitir_NFe.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = Global.SisMattos.My.Resources.Resources.Mini_Imprimir
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(642, 444)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
        Me.cmdImprimir.TabIndex = 104
        Me.cmdImprimir.Text = "    Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.SisMattos.My.Resources.Resources.Mini_Excel
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(808, 444)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 105
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = Global.SisMattos.My.Resources.Resources.Mini_Cancelar
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(559, 444)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 103
        Me.cmdCancelar.Text = "      Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.Image = Global.SisMattos.My.Resources.Resources.Mini_Editar
        Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAlterar.Location = New System.Drawing.Point(88, 444)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAlterar.TabIndex = 101
        Me.cmdAlterar.Text = "Alterar"
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'cmdNovo
        '
        Me.cmdNovo.Image = Global.SisMattos.My.Resources.Resources.Mini_Novo
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(5, 444)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
        Me.cmdNovo.TabIndex = 100
        Me.cmdNovo.Text = "       Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.SisMattos.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(1042, 444)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 106
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.SisMattos.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(1042, 95)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 10
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.SisMattos.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(959, 95)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 394
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdPDF
        '
        Me.cmdPDF.Image = Global.SisMattos.My.Resources.Resources.Mini_PDF
        Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPDF.Location = New System.Drawing.Point(891, 444)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 395
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'cmdCopiar
        '
        Me.cmdCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCopiar.Location = New System.Drawing.Point(288, 444)
        Me.cmdCopiar.Name = "cmdCopiar"
        Me.cmdCopiar.Size = New System.Drawing.Size(64, 28)
        Me.cmdCopiar.TabIndex = 396
        Me.cmdCopiar.Text = "Copiar"
        Me.cmdCopiar.UseVisualStyleBackColor = True
        '
        'cmdDevolver
        '
        Me.cmdDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDevolver.Location = New System.Drawing.Point(360, 444)
        Me.cmdDevolver.Name = "cmdDevolver"
        Me.cmdDevolver.Size = New System.Drawing.Size(64, 28)
        Me.cmdDevolver.TabIndex = 397
        Me.cmdDevolver.Text = "Devolver"
        Me.cmdDevolver.UseVisualStyleBackColor = True
        '
        'psqProduto
        '
        Me.psqProduto.Identificador = -1
        Me.psqProduto.Identificador_Filial = 0
        Me.psqProduto.Location = New System.Drawing.Point(5, 87)
        Me.psqProduto.Name = "psqProduto"
        Me.psqProduto.SelectedIndex = -1
        Me.psqProduto.Size = New System.Drawing.Size(607, 36)
        Me.psqProduto.TabIndex = 8
        '
        'psqPessoa
        '
        Me.psqPessoa.AdicionarPessoa = True
        Me.psqPessoa.CarregarTodos = False
        Me.psqPessoa.DS_Pessoa = ""
        Me.psqPessoa.ID_Pessoa = 0
        Me.psqPessoa.Location = New System.Drawing.Point(5, 47)
        Me.psqPessoa.Name = "psqPessoa"
        Me.psqPessoa.Rotulo = "Pessoa"
        Me.psqPessoa.Size = New System.Drawing.Size(607, 36)
        Me.psqPessoa.TabIndex = 5
        Me.psqPessoa.TipoFiltro = SisMattos.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'frmConsultaDocumentoFiscal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 476)
        Me.Controls.Add(Me.cmdDevolver)
        Me.Controls.Add(Me.cmdCopiar)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.cmdBaixarXML)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodDocumento)
        Me.Controls.Add(Me.cmdCartaCorrecao)
        Me.Controls.Add(Me.cmdHistorico)
        Me.Controls.Add(Me.cmdTransmitir_NFe)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.txtDataInicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.psqProduto)
        Me.Controls.Add(Me.cboSerieDocumentoFiscal)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.cboTipoDocumentoFiscal)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.psqPessoa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboNaturezaOperacao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmConsultaDocumentoFiscal"
        Me.Text = "Consulta de Documento Fiscal"
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsBaixarXML.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents psqPessoa As uscPesqPessoa
  Friend WithEvents Label2 As Label
  Friend WithEvents cboNaturezaOperacao As ComboBox
  Friend WithEvents cboSerieDocumentoFiscal As ComboBox
  Friend WithEvents Label60 As Label
  Friend WithEvents cboTipoDocumentoFiscal As ComboBox
  Friend WithEvents Label54 As Label
  Friend WithEvents psqProduto As uscpsqProduto
  Friend WithEvents Label7 As Label
  Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As Label
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents cmdImprimir As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents cmdExcel As Button
  Friend WithEvents cmdCancelar As Button
  Friend WithEvents cmdAlterar As Button
  Friend WithEvents cmdNovo As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents cboStatus As ComboBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cmdTransmitir_NFe As Button
  Friend WithEvents cmdHistorico As Button
  Friend WithEvents cmdCartaCorrecao As Button
  Friend WithEvents txtCodDocumento As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents cmdBaixarXML As Button
  Friend WithEvents cmsBaixarXML As ContextMenuStrip
  Friend WithEvents cmsBaixarXML_BaixarTodosListados As ToolStripMenuItem
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdPDF As Button
    Friend WithEvents cmdCopiar As Button
    Friend WithEvents cmdDevolver As Button
End Class
