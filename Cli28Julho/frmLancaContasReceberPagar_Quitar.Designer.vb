<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancaContasReceberPagar_Quitar
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
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.txtValorAtualizado = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtValorPago = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.txtDesconto = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.txtValorFinal = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.grdContas = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.txtDataPagamento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
        Me.psqPessoalCredito = New Cli28Julho.uscPesqPessoa()
        Me.oLancaContasReceberPagar_Quitar = New Cli28Julho.uscLancaContasReceberPagar_Quitar()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorImpostos = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
        CType(Me.txtValorAtualizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesconto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdContas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorImpostos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(904, 402)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 101
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(823, 402)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 100
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'txtValorAtualizado
        '
        Me.txtValorAtualizado.CausesValidation = False
        Me.txtValorAtualizado.Location = New System.Drawing.Point(5, 367)
        Me.txtValorAtualizado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorAtualizado.Name = "txtValorAtualizado"
        Me.txtValorAtualizado.ReadOnly = True
        Me.txtValorAtualizado.Size = New System.Drawing.Size(110, 21)
        Me.txtValorAtualizado.TabIndex = 1
        Me.txtValorAtualizado.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 352)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Valor do Atualizado"
        '
        'txtValorPago
        '
        Me.txtValorPago.CausesValidation = False
        Me.txtValorPago.Location = New System.Drawing.Point(133, 367)
        Me.txtValorPago.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorPago.Name = "txtValorPago"
        Me.txtValorPago.ReadOnly = True
        Me.txtValorPago.Size = New System.Drawing.Size(110, 21)
        Me.txtValorPago.TabIndex = 2
        Me.txtValorPago.TabStop = False
        '
        'txtDesconto
        '
        Me.txtDesconto.CausesValidation = False
        Me.txtDesconto.Location = New System.Drawing.Point(261, 367)
        Me.txtDesconto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.ReadOnly = True
        Me.txtDesconto.Size = New System.Drawing.Size(110, 21)
        Me.txtDesconto.TabIndex = 3
        Me.txtDesconto.TabStop = False
        '
        'txtValorFinal
        '
        Me.txtValorFinal.CausesValidation = False
        Me.txtValorFinal.Location = New System.Drawing.Point(520, 367)
        Me.txtValorFinal.MaskInput = "{currency:-9.2}"
        Me.txtValorFinal.Name = "txtValorFinal"
        Me.txtValorFinal.ReadOnly = True
        Me.txtValorFinal.Size = New System.Drawing.Size(110, 21)
        Me.txtValorFinal.TabIndex = 4
        Me.txtValorFinal.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(119, 371)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(247, 371)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(503, 371)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 79
        Me.Label17.Text = "="
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(133, 352)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "Valor Pago"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(261, 352)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Outro Desconto"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(520, 352)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 13)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Valor Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Listagem de Contas"
        '
        'grdContas
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdContas.DisplayLayout.Appearance = Appearance1
        Me.grdContas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdContas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdContas.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdContas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdContas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdContas.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdContas.DisplayLayout.MaxColScrollRegions = 1
        Me.grdContas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdContas.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdContas.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdContas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdContas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdContas.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdContas.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdContas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdContas.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdContas.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdContas.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdContas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdContas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.grdContas.DisplayLayout.Override.RowAppearance = Appearance11
        Me.grdContas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdContas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.grdContas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdContas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdContas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdContas.Location = New System.Drawing.Point(5, 20)
        Me.grdContas.Name = "grdContas"
        Me.grdContas.Size = New System.Drawing.Size(974, 155)
        Me.grdContas.TabIndex = 84
        Me.grdContas.Text = "UltraGrid1"
        '
        'txtDataPagamento
        '
        Me.txtDataPagamento.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataPagamento.Location = New System.Drawing.Point(894, 367)
        Me.txtDataPagamento.Name = "txtDataPagamento"
        Me.txtDataPagamento.Size = New System.Drawing.Size(85, 21)
        Me.txtDataPagamento.TabIndex = 6
        Me.txtDataPagamento.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(894, 352)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Data Pagto"
        '
        'psqPessoalCredito
        '
        Me.psqPessoalCredito.AdicionarPessoa = True
        Me.psqPessoalCredito.Bordas = True
        Me.psqPessoalCredito.CarregarTodos = False
        Me.psqPessoalCredito.DS_Pessoa = ""
        Me.psqPessoalCredito.ID_Pessoa = 0
        Me.psqPessoalCredito.LabelVisivel = True
        Me.psqPessoalCredito.Location = New System.Drawing.Point(5, 394)
        Me.psqPessoalCredito.Name = "psqPessoalCredito"
        Me.psqPessoalCredito.PesquisarPessoa = True
        Me.psqPessoalCredito.Rotulo = "Pessoa pra o Crédito"
        Me.psqPessoalCredito.Size = New System.Drawing.Size(380, 36)
        Me.psqPessoalCredito.SomenteLeitura = False
        Me.psqPessoalCredito.TabIndex = 5
        Me.psqPessoalCredito.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'oLancaContasReceberPagar_Quitar
        '
        Me.oLancaContasReceberPagar_Quitar.Location = New System.Drawing.Point(5, 181)
        Me.oLancaContasReceberPagar_Quitar.Name = "oLancaContasReceberPagar_Quitar"
        Me.oLancaContasReceberPagar_Quitar.Size = New System.Drawing.Size(970, 164)
        Me.oLancaContasReceberPagar_Quitar.TabIndex = 102
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(742, 402)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
        Me.cmdImprimir.TabIndex = 272
        Me.cmdImprimir.Text = "    Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "Impostos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "-"
        '
        'txtValorImpostos
        '
        Me.txtValorImpostos.CausesValidation = False
        Me.txtValorImpostos.Location = New System.Drawing.Point(389, 367)
        Me.txtValorImpostos.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorImpostos.Name = "txtValorImpostos"
        Me.txtValorImpostos.ReadOnly = True
        Me.txtValorImpostos.Size = New System.Drawing.Size(110, 21)
        Me.txtValorImpostos.TabIndex = 273
        Me.txtValorImpostos.TabStop = False
        '
        'frmLancaContasReceberPagar_Quitar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValorImpostos)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.oLancaContasReceberPagar_Quitar)
        Me.Controls.Add(Me.psqPessoalCredito)
        Me.Controls.Add(Me.txtDataPagamento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtValorFinal)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.txtValorPago)
        Me.Controls.Add(Me.txtValorAtualizado)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.grdContas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLancaContasReceberPagar_Quitar"
        Me.Text = "Contas Receber e Pagar - Quitar"
        CType(Me.txtValorAtualizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesconto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdContas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorImpostos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
    Friend WithEvents txtValorAtualizado As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtValorPago As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents txtDesconto As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents txtValorFinal As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdContas As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents txtDataPagamento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As Label
  Friend WithEvents psqPessoalCredito As uscPesqPessoa
  Friend WithEvents oLancaContasReceberPagar_Quitar As uscLancaContasReceberPagar_Quitar
    Friend WithEvents cmdImprimir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValorImpostos As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
End Class
