<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaFluxoCaixa
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
    Me.cmdCancelar = New System.Windows.Forms.Button()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
    Me.cboPlanoContas = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboContaBancaria = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.cboTipoMovimentacao = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.cboContaCaixa = New System.Windows.Forms.ComboBox()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtCodMovimentacao = New System.Windows.Forms.TextBox()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdPDF = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Cancelar
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(167, 413)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 102
        Me.cmdCancelar.Text = "      Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Editar
        Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAlterar.Location = New System.Drawing.Point(86, 413)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAlterar.TabIndex = 101
        Me.cmdAlterar.Text = "Alterar"
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'cmdNovo
        '
        Me.cmdNovo.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Novo
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(5, 413)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
        Me.cmdNovo.TabIndex = 100
        Me.cmdNovo.Text = "  Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(767, 55)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 10
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(744, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "a"
        '
        'txtDataFinal
        '
        Me.txtDataFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataFinal.Location = New System.Drawing.Point(757, 20)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataFinal.TabIndex = 5
        Me.txtDataFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(485, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Tipo de Documento"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(485, 20)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(168, 21)
        Me.cboTipoDocumento.TabIndex = 3
        '
        'cboPlanoContas
        '
        Me.cboPlanoContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanoContas.DropDownWidth = 400
        Me.cboPlanoContas.FormattingEnabled = True
        Me.cboPlanoContas.Location = New System.Drawing.Point(216, 62)
        Me.cboPlanoContas.Name = "cboPlanoContas"
        Me.cboPlanoContas.Size = New System.Drawing.Size(306, 21)
        Me.cboPlanoContas.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Plano de Contas"
        '
        'txtDataInicial
        '
        Me.txtDataInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataInicial.Location = New System.Drawing.Point(659, 20)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataInicial.TabIndex = 4
        Me.txtDataInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(659, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Período"
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaBancaria.FormattingEnabled = True
        Me.cboContaBancaria.Location = New System.Drawing.Point(5, 62)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Size = New System.Drawing.Size(205, 21)
        Me.cboContaBancaria.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Conta Bancária"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(311, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "Conta Caixa"
        '
        'cboTipoMovimentacao
        '
        Me.cboTipoMovimentacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMovimentacao.FormattingEnabled = True
        Me.cboTipoMovimentacao.Location = New System.Drawing.Point(5, 20)
        Me.cboTipoMovimentacao.Name = "cboTipoMovimentacao"
        Me.cboTipoMovimentacao.Size = New System.Drawing.Size(300, 21)
        Me.cboTipoMovimentacao.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Tipo de Movimentação Financeira"
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(767, 413)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 104
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
        Me.grdListagem.Size = New System.Drawing.Size(837, 303)
        Me.grdListagem.TabIndex = 90
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 89)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(131, 13)
        Me.lblRListagemPessoa.TabIndex = 89
        Me.lblRListagemPessoa.Tag = "Listagem de Lançamentos"
        Me.lblRListagemPessoa.Text = "Listagem de Lançamentos"
        '
        'cboContaCaixa
        '
        Me.cboContaCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaCaixa.FormattingEnabled = True
        Me.cboContaCaixa.Location = New System.Drawing.Point(311, 20)
        Me.cboContaCaixa.Name = "cboContaCaixa"
        Me.cboContaCaixa.Size = New System.Drawing.Size(168, 21)
        Me.cboContaCaixa.TabIndex = 2
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(248, 413)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 103
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(528, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Cód. Movim."
        '
        'txtCodMovimentacao
        '
        Me.txtCodMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodMovimentacao.Location = New System.Drawing.Point(528, 62)
        Me.txtCodMovimentacao.Name = "txtCodMovimentacao"
        Me.txtCodMovimentacao.Size = New System.Drawing.Size(60, 20)
        Me.txtCodMovimentacao.TabIndex = 8
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(686, 55)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 233
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdPDF
        '
        Me.cmdPDF.Image = Global.Cli28Julho.My.Resources.Resources.Mini_PDF
        Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPDF.Location = New System.Drawing.Point(329, 413)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 234
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(410, 413)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
        Me.cmdImprimir.TabIndex = 270
        Me.cmdImprimir.Text = "    Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'frmConsultaFluxoCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 448)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodMovimentacao)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cboContaCaixa)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.Controls.Add(Me.cboPlanoContas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDataInicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboContaBancaria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboTipoMovimentacao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmConsultaFluxoCaixa"
        Me.Text = "Consulta de Lançamento em Conta Caixa/Conta Bancária"
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
  Friend WithEvents cmdAlterar As System.Windows.Forms.Button
  Friend WithEvents cmdNovo As System.Windows.Forms.Button
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
  Friend WithEvents cboPlanoContas As System.Windows.Forms.ComboBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cboContaBancaria As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents cboTipoMovimentacao As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As System.Windows.Forms.Label
  Friend WithEvents cboContaCaixa As System.Windows.Forms.ComboBox
  Friend WithEvents cmdExcel As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtCodMovimentacao As System.Windows.Forms.TextBox
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdPDF As Button
    Friend WithEvents cmdImprimir As Button
End Class
