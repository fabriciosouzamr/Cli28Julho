<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCompensacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdCompensar = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtDataLancamentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
    Me.txtDataLancamentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboContaBancaria = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.cboContaCaixa = New System.Windows.Forms.ComboBox()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboTipo = New System.Windows.Forms.ComboBox()
    Me.psqPessoa = New uscPesqPessoa()
    Me.txtCodigoDocumento = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtDataDocumentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataDocumentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdPDF = New System.Windows.Forms.Button()
    CType(Me.txtDataLancamentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataLancamentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataDocumentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataDocumentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdExcel
    '
    Me.cmdExcel.Image = My.Resources.Resources.Mini_Excel
    Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcel.Location = New System.Drawing.Point(102, 413)
    Me.cmdExcel.Name = "cmdExcel"
    Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcel.TabIndex = 101
    Me.cmdExcel.Text = "Excel"
    Me.cmdExcel.UseVisualStyleBackColor = True
    '
    'cmdCompensar
    '
    Me.cmdCompensar.Image = My.Resources.Resources.Mini_Novo
    Me.cmdCompensar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdCompensar.Location = New System.Drawing.Point(6, 413)
    Me.cmdCompensar.Name = "cmdCompensar"
    Me.cmdCompensar.Size = New System.Drawing.Size(90, 28)
    Me.cmdCompensar.TabIndex = 100
    Me.cmdCompensar.Text = "      Compensar"
    Me.cmdCompensar.UseVisualStyleBackColor = True
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(861, 55)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 20
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(649, 24)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(13, 13)
    Me.Label7.TabIndex = 134
    Me.Label7.Text = "a"
    '
    'txtDataLancamentoFinal
    '
    Me.txtDataLancamentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataLancamentoFinal.Location = New System.Drawing.Point(662, 20)
    Me.txtDataLancamentoFinal.Name = "txtDataLancamentoFinal"
    Me.txtDataLancamentoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataLancamentoFinal.TabIndex = 5
    Me.txtDataLancamentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(390, 5)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(101, 13)
    Me.Label6.TabIndex = 132
    Me.Label6.Text = "Tipo de Documento"
    '
    'cboTipoDocumento
    '
    Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDocumento.FormattingEnabled = True
    Me.cboTipoDocumento.Location = New System.Drawing.Point(390, 20)
    Me.cboTipoDocumento.Name = "cboTipoDocumento"
    Me.cboTipoDocumento.Size = New System.Drawing.Size(168, 21)
    Me.cboTipoDocumento.TabIndex = 3
    '
    'txtDataLancamentoInicial
    '
    Me.txtDataLancamentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataLancamentoInicial.Location = New System.Drawing.Point(564, 20)
    Me.txtDataLancamentoInicial.Name = "txtDataLancamentoInicial"
    Me.txtDataLancamentoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataLancamentoInicial.TabIndex = 4
    Me.txtDataLancamentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(564, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(131, 13)
    Me.Label4.TabIndex = 128
    Me.Label4.Text = "Período da Compensação"
    '
    'cboContaBancaria
    '
    Me.cboContaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboContaBancaria.FormattingEnabled = True
    Me.cboContaBancaria.Location = New System.Drawing.Point(5, 20)
    Me.cboContaBancaria.Name = "cboContaBancaria"
    Me.cboContaBancaria.Size = New System.Drawing.Size(205, 21)
    Me.cboContaBancaria.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(80, 13)
    Me.Label2.TabIndex = 125
    Me.Label2.Text = "Conta Bancária"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(216, 5)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(64, 13)
    Me.Label14.TabIndex = 122
    Me.Label14.Text = "Conta Caixa"
    '
    'cboContaCaixa
    '
    Me.cboContaCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboContaCaixa.FormattingEnabled = True
    Me.cboContaCaixa.Location = New System.Drawing.Point(216, 20)
    Me.cboContaCaixa.Name = "cboContaCaixa"
    Me.cboContaCaixa.Size = New System.Drawing.Size(168, 21)
    Me.cboContaCaixa.TabIndex = 2
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(861, 413)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 102
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
    Me.grdListagem.Size = New System.Drawing.Size(931, 303)
    Me.grdListagem.TabIndex = 116
    Me.grdListagem.Text = "UltraGrid1"
    '
    'lblRListagemPessoa
    '
    Me.lblRListagemPessoa.AutoSize = True
    Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 89)
    Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
    Me.lblRListagemPessoa.Size = New System.Drawing.Size(131, 13)
    Me.lblRListagemPessoa.TabIndex = 115
    Me.lblRListagemPessoa.Tag = "Listagem de Lançamentos"
    Me.lblRListagemPessoa.Text = "Listagem de Lançamentos"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(753, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(28, 13)
    Me.Label1.TabIndex = 144
    Me.Label1.Text = "Tipo"
    '
    'cboTipo
    '
    Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipo.FormattingEnabled = True
    Me.cboTipo.Location = New System.Drawing.Point(753, 20)
    Me.cboTipo.Name = "cboTipo"
    Me.cboTipo.Size = New System.Drawing.Size(92, 21)
    Me.cboTipo.TabIndex = 6
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
    Me.psqPessoa.Size = New System.Drawing.Size(449, 36)
    Me.psqPessoa.TabIndex = 7
    Me.psqPessoa.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Pessoa
    '
    'txtCodigoDocumento
    '
    Me.txtCodigoDocumento.Location = New System.Drawing.Point(460, 63)
    Me.txtCodigoDocumento.Name = "txtCodigoDocumento"
    Me.txtCodigoDocumento.Size = New System.Drawing.Size(98, 20)
    Me.txtCodigoDocumento.TabIndex = 8
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(460, 47)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(98, 13)
    Me.Label3.TabIndex = 227
    Me.Label3.Text = "Código Documento"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(649, 66)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(13, 13)
    Me.Label5.TabIndex = 231
    Me.Label5.Text = "a"
    '
    'txtDataDocumentoFinal
    '
    Me.txtDataDocumentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataDocumentoFinal.Location = New System.Drawing.Point(662, 62)
    Me.txtDataDocumentoFinal.Name = "txtDataDocumentoFinal"
    Me.txtDataDocumentoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataDocumentoFinal.TabIndex = 10
    Me.txtDataDocumentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDataDocumentoInicial
    '
    Me.txtDataDocumentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataDocumentoInicial.Location = New System.Drawing.Point(564, 62)
    Me.txtDataDocumentoInicial.Name = "txtDataDocumentoInicial"
    Me.txtDataDocumentoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataDocumentoInicial.TabIndex = 9
    Me.txtDataDocumentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(564, 47)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(118, 13)
    Me.Label8.TabIndex = 229
    Me.Label8.Text = "Período do Documento"
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Image = My.Resources.Resources.Mini_Limpar
    Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLimpar.Location = New System.Drawing.Point(861, 21)
    Me.cmdLimpar.Name = "cmdLimpar"
    Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
    Me.cmdLimpar.TabIndex = 232
    Me.cmdLimpar.Text = "Limpar"
    Me.cmdLimpar.UseVisualStyleBackColor = True
    '
    'cmdPDF
    '
    Me.cmdPDF.Image = My.Resources.Resources.Mini_PDF
    Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPDF.Location = New System.Drawing.Point(183, 413)
    Me.cmdPDF.Name = "cmdPDF"
    Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
    Me.cmdPDF.TabIndex = 233
    Me.cmdPDF.Text = "     P.D.F."
    Me.cmdPDF.UseVisualStyleBackColor = True
    '
    'frmConsultaCompensacao
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(942, 447)
    Me.Controls.Add(Me.cmdPDF)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtDataDocumentoFinal)
    Me.Controls.Add(Me.txtDataDocumentoInicial)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.txtCodigoDocumento)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.psqPessoa)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cboTipo)
    Me.Controls.Add(Me.cmdExcel)
    Me.Controls.Add(Me.cmdCompensar)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtDataLancamentoFinal)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cboTipoDocumento)
    Me.Controls.Add(Me.txtDataLancamentoInicial)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cboContaBancaria)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.cboContaCaixa)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.lblRListagemPessoa)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.KeyPreview = True
    Me.Name = "frmConsultaCompensacao"
    Me.Text = "Consulta de Compensação"
    CType(Me.txtDataLancamentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataLancamentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataDocumentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataDocumentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdExcel As System.Windows.Forms.Button
  Friend WithEvents cmdCompensar As System.Windows.Forms.Button
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtDataLancamentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
  Friend WithEvents txtDataLancamentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cboContaBancaria As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents cboContaCaixa As System.Windows.Forms.ComboBox
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
  Friend WithEvents psqPessoa As uscPesqPessoa
  Friend WithEvents txtCodigoDocumento As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label5 As Label
  Friend WithEvents txtDataDocumentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataDocumentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label8 As Label
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdPDF As Button
End Class
