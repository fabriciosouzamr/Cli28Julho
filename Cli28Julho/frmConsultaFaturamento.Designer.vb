<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaFaturamento
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
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

  'Exigido pelo Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
  'Pode ser modificado usando o Windows Form Designer.  
  'Não o modifique usando o editor de códigos.
  <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataAgendamentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtDataAgendamentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdLimpar = New System.Windows.Forms.Button()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboProfissional = New System.Windows.Forms.ComboBox()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.lblRListagemPessoa = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDataFaturaFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtDataFaturaInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
        Me.lblRCodigo = New System.Windows.Forms.Label()
        Me.txtCodigoAgendamento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoVenda = New System.Windows.Forms.TextBox()
        Me.cmdPDF = New System.Windows.Forms.Button()
        CType(Me.txtDataAgendamentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataAgendamentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFaturaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFaturaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 327
        Me.Label7.Text = "a"
        '
        'txtDataAgendamentoFinal
        '
        Me.txtDataAgendamentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataAgendamentoFinal.Location = New System.Drawing.Point(103, 20)
        Me.txtDataAgendamentoFinal.Name = "txtDataAgendamentoFinal"
        Me.txtDataAgendamentoFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataAgendamentoFinal.TabIndex = 325
        Me.txtDataAgendamentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtDataAgendamentoInicial
        '
        Me.txtDataAgendamentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataAgendamentoInicial.Location = New System.Drawing.Point(5, 20)
        Me.txtDataAgendamentoInicial.Name = "txtDataAgendamentoInicial"
        Me.txtDataAgendamentoInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataAgendamentoInicial.TabIndex = 324
        Me.txtDataAgendamentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 326
        Me.Label5.Text = "Período de Agendamento"
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(905, 5)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 316
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(5, 396)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 310
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(905, 39)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 309
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(383, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 314
        Me.Label14.Text = "Profissional"
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(383, 20)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(288, 21)
        Me.cboProfissional.TabIndex = 308
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(905, 396)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 311
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
        Me.grdListagem.Size = New System.Drawing.Size(975, 286)
        Me.grdListagem.TabIndex = 313
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 89)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(131, 13)
        Me.lblRListagemPessoa.TabIndex = 312
        Me.lblRListagemPessoa.Tag = "Listagem de Lançamentos"
        Me.lblRListagemPessoa.Text = "Listagem de Lançamentos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 331
        Me.Label6.Text = "a"
        '
        'txtDataFaturaFinal
        '
        Me.txtDataFaturaFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataFaturaFinal.Location = New System.Drawing.Point(292, 20)
        Me.txtDataFaturaFinal.Name = "txtDataFaturaFinal"
        Me.txtDataFaturaFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataFaturaFinal.TabIndex = 329
        Me.txtDataFaturaFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtDataFaturaInicial
        '
        Me.txtDataFaturaInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataFaturaInicial.Location = New System.Drawing.Point(194, 20)
        Me.txtDataFaturaInicial.Name = "txtDataFaturaInicial"
        Me.txtDataFaturaInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataFaturaInicial.TabIndex = 328
        Me.txtDataFaturaInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 330
        Me.Label8.Text = "Período de Data da Fatura"
        '
        'psqPessoa
        '
        Me.psqPessoa.AdicionarPessoa = False
        Me.psqPessoa.Bordas = True
        Me.psqPessoa.CarregarTodos = False
        Me.psqPessoa.DS_Pessoa = ""
        Me.psqPessoa.ID_Pessoa = 0
        Me.psqPessoa.LabelVisivel = True
        Me.psqPessoa.Location = New System.Drawing.Point(5, 47)
        Me.psqPessoa.Name = "psqPessoa"
        Me.psqPessoa.PesquisarPessoa = True
        Me.psqPessoa.Rotulo = "Pessoa"
        Me.psqPessoa.Size = New System.Drawing.Size(486, 36)
        Me.psqPessoa.SomenteLeitura = False
        Me.psqPessoa.TabIndex = 332
        Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'lblRCodigo
        '
        Me.lblRCodigo.AutoSize = True
        Me.lblRCodigo.Location = New System.Drawing.Point(497, 47)
        Me.lblRCodigo.Name = "lblRCodigo"
        Me.lblRCodigo.Size = New System.Drawing.Size(98, 13)
        Me.lblRCodigo.TabIndex = 334
        Me.lblRCodigo.Text = "Cód. Agendamento"
        '
        'txtCodigoAgendamento
        '
        Me.txtCodigoAgendamento.Location = New System.Drawing.Point(497, 63)
        Me.txtCodigoAgendamento.Name = "txtCodigoAgendamento"
        Me.txtCodigoAgendamento.Size = New System.Drawing.Size(70, 20)
        Me.txtCodigoAgendamento.TabIndex = 333
        Me.txtCodigoAgendamento.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(601, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 336
        Me.Label1.Text = "Cód. Venda"
        '
        'txtCodigoVenda
        '
        Me.txtCodigoVenda.Location = New System.Drawing.Point(601, 63)
        Me.txtCodigoVenda.Name = "txtCodigoVenda"
        Me.txtCodigoVenda.Size = New System.Drawing.Size(70, 20)
        Me.txtCodigoVenda.TabIndex = 335
        Me.txtCodigoVenda.TabStop = False
        '
        'cmdPDF
        '
        Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPDF.Location = New System.Drawing.Point(86, 396)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 337
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'frmConsultaFaturamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 430)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigoVenda)
        Me.Controls.Add(Me.lblRCodigo)
        Me.Controls.Add(Me.txtCodigoAgendamento)
        Me.Controls.Add(Me.psqPessoa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDataFaturaFinal)
        Me.Controls.Add(Me.txtDataFaturaInicial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataAgendamentoFinal)
        Me.Controls.Add(Me.txtDataAgendamentoInicial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboProfissional)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaFaturamento"
        Me.Text = "Consulta de Faturamento"
        CType(Me.txtDataAgendamentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataAgendamentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFaturaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFaturaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtDataAgendamentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtDataAgendamentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdLimpar As Button
    Friend WithEvents cmdExcel As Button
    Friend WithEvents cmdPesquisar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cboProfissional As ComboBox
    Friend WithEvents cmdFechar As Button
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblRListagemPessoa As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDataFaturaFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtDataFaturaInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label8 As Label
    Friend WithEvents psqPessoa As uscPesqPessoa
    Friend WithEvents lblRCodigo As Label
    Friend WithEvents txtCodigoAgendamento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoVenda As TextBox
    Friend WithEvents cmdPDF As Button
End Class
