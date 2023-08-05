<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaVendaPendente
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
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cboOrigem = New System.Windows.Forms.ComboBox()
    Me.cmdVenda = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtDataValidadeFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.cboProfissionalPrestadorServico = New System.Windows.Forms.ComboBox()
    Me.txtDataValidadeInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.cboConvenio = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cmdPDF = New System.Windows.Forms.Button()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    CType(Me.txtDataValidadeFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataValidadeInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
    Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLimpar.Location = New System.Drawing.Point(844, 62)
    Me.cmdLimpar.Name = "cmdLimpar"
    Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
    Me.cmdLimpar.TabIndex = 291
    Me.cmdLimpar.Text = "Limpar"
    Me.cmdLimpar.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(728, 47)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(40, 13)
    Me.Label6.TabIndex = 290
    Me.Label6.Text = "Origem"
    '
    'cboOrigem
    '
    Me.cboOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboOrigem.FormattingEnabled = True
    Me.cboOrigem.Location = New System.Drawing.Point(728, 62)
    Me.cboOrigem.Name = "cboOrigem"
    Me.cboOrigem.Size = New System.Drawing.Size(110, 21)
    Me.cboOrigem.TabIndex = 289
    '
    'cmdVenda
    '
    Me.cmdVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdVenda.Location = New System.Drawing.Point(5, 335)
    Me.cmdVenda.Name = "cmdVenda"
    Me.cmdVenda.Size = New System.Drawing.Size(75, 28)
    Me.cmdVenda.TabIndex = 288
    Me.cmdVenda.Text = "    Venda"
    Me.cmdVenda.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(897, 24)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(13, 13)
    Me.Label3.TabIndex = 287
    Me.Label3.Text = "a"
    '
    'txtDataValidadeFinal
    '
    Me.txtDataValidadeFinal.Location = New System.Drawing.Point(912, 20)
    Me.txtDataValidadeFinal.Name = "txtDataValidadeFinal"
    Me.txtDataValidadeFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataValidadeFinal.TabIndex = 286
    '
    'cboProfissionalPrestadorServico
    '
    Me.cboProfissionalPrestadorServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissionalPrestadorServico.FormattingEnabled = True
    Me.cboProfissionalPrestadorServico.Location = New System.Drawing.Point(504, 62)
    Me.cboProfissionalPrestadorServico.Name = "cboProfissionalPrestadorServico"
    Me.cboProfissionalPrestadorServico.Size = New System.Drawing.Size(218, 21)
    Me.cboProfissionalPrestadorServico.TabIndex = 284
    '
    'txtDataValidadeInicial
    '
    Me.txtDataValidadeInicial.Location = New System.Drawing.Point(810, 20)
    Me.txtDataValidadeInicial.Name = "txtDataValidadeInicial"
    Me.txtDataValidadeInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataValidadeInicial.TabIndex = 281
    '
    'cboConvenio
    '
    Me.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboConvenio.FormattingEnabled = True
    Me.cboConvenio.Location = New System.Drawing.Point(504, 20)
    Me.cboConvenio.Name = "cboConvenio"
    Me.cboConvenio.Size = New System.Drawing.Size(300, 21)
    Me.cboConvenio.TabIndex = 277
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(504, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(52, 13)
    Me.Label1.TabIndex = 276
    Me.Label1.Text = "Convênio"
    '
    'psqPessoa
    '
    Me.psqPessoa.AdicionarPessoa = False
    Me.psqPessoa.CarregarTodos = False
    Me.psqPessoa.DS_Pessoa = ""
    Me.psqPessoa.ID_Pessoa = 0
    Me.psqPessoa.Location = New System.Drawing.Point(5, 5)
    Me.psqPessoa.Name = "psqPessoa"
    Me.psqPessoa.Rotulo = "Pessoa"
    Me.psqPessoa.Size = New System.Drawing.Size(493, 36)
    Me.psqPessoa.TabIndex = 275
    Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(810, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(107, 13)
    Me.Label2.TabIndex = 280
    Me.Label2.Text = "Data do Lançamento"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(504, 47)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(162, 13)
    Me.Label5.TabIndex = 285
    Me.Label5.Text = "Profissional/Prestador de serviço"
    '
    'cmdPDF
    '
    Me.cmdPDF.Image = Global.Cli28Julho.My.Resources.Resources.Mini_PDF
    Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPDF.Location = New System.Drawing.Point(167, 335)
    Me.cmdPDF.Name = "cmdPDF"
    Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
    Me.cmdPDF.TabIndex = 274
    Me.cmdPDF.Text = "     P.D.F."
    Me.cmdPDF.UseVisualStyleBackColor = True
    '
    'cmdExcel
    '
    Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcel.Location = New System.Drawing.Point(86, 335)
    Me.cmdExcel.Name = "cmdExcel"
    Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcel.TabIndex = 270
    Me.cmdExcel.Text = "Excel"
    Me.cmdExcel.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(925, 335)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 271
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 104)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(995, 221)
    Me.grdListagem.TabIndex = 273
    Me.grdListagem.Text = "UltraGrid1"
    '
    'lblRListagemPessoa
    '
    Me.lblRListagemPessoa.AutoSize = True
    Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 89)
    Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
    Me.lblRListagemPessoa.Size = New System.Drawing.Size(106, 13)
    Me.lblRListagemPessoa.TabIndex = 272
    Me.lblRListagemPessoa.Tag = "Listagem de Horários"
    Me.lblRListagemPessoa.Text = "Listagem de Horários"
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(925, 62)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 267
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'psqProcedimento
    '
    Me.psqProcedimento.Convenio = 0
    Me.psqProcedimento.Identificador = 0
    Me.psqProcedimento.Location = New System.Drawing.Point(5, 47)
    Me.psqProcedimento.Name = "psqProcedimento"
    Me.psqProcedimento.Profissional = 0
    Me.psqProcedimento.Size = New System.Drawing.Size(493, 36)
    Me.psqProcedimento.TabIndex = 292
    '
    'frmConsultaVendaPendente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1006, 368)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cboOrigem)
    Me.Controls.Add(Me.cmdVenda)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtDataValidadeFinal)
    Me.Controls.Add(Me.cboProfissionalPrestadorServico)
    Me.Controls.Add(Me.txtDataValidadeInicial)
    Me.Controls.Add(Me.cboConvenio)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.psqPessoa)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.cmdPDF)
    Me.Controls.Add(Me.cmdExcel)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.lblRListagemPessoa)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.psqProcedimento)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmConsultaVendaPendente"
    Me.Text = "Consulta de Venda Pendente"
    CType(Me.txtDataValidadeFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataValidadeInicial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cmdLimpar As Button
  Friend WithEvents Label6 As Label
  Friend WithEvents cboOrigem As ComboBox
  Friend WithEvents cmdVenda As Button
  Friend WithEvents Label3 As Label
  Friend WithEvents txtDataValidadeFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents cboProfissionalPrestadorServico As ComboBox
  Friend WithEvents txtDataValidadeInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents cboConvenio As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents psqPessoa As uscPesqPessoa
  Friend WithEvents Label2 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents cmdPDF As Button
  Friend WithEvents cmdExcel As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As Label
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents psqProcedimento As uscPesqProcedimento
End Class
