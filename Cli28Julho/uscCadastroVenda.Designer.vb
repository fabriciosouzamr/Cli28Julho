<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uscCadastroVenda
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscCadastroVenda))
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboConvenio = New System.Windows.Forms.ComboBox()
    Me.txtDataVenda = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblRDataAgendamento = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtPercentualDesconto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.cmdNovoProduto = New System.Windows.Forms.Button()
    Me.txtValorDesconto = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtValorProcedimento = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmdAdicionarProduto = New System.Windows.Forms.Button()
    Me.cboProfissionalPrestadorServico = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.lblValorTotalProcedimento = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboContaFinanceira = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboVendaPendente = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCodigoVenda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdNovo = New System.Windows.Forms.Button()
        Me.cmdGuiaConsultas = New System.Windows.Forms.Button()
        Me.cmdExameInterno = New System.Windows.Forms.Button()
        Me.cmdExameExterno = New System.Windows.Forms.Button()
        Me.lblValorTotalDesconto = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboIndicador = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSaldoConvenio = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboCanalMarcacao = New System.Windows.Forms.ComboBox()
        Me.chkImrimirGuiaConsultas = New System.Windows.Forms.CheckBox()
        Me.chkImrimirExameInterno = New System.Windows.Forms.CheckBox()
        Me.chkImrimirExameExterno = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.oVoucher = New Cli28Julho.uscVoucher()
        Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
        Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
        CType(Me.txtDataVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtPercentualDesconto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorDesconto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorProcedimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Convênio"
        '
        'cboConvenio
        '
        Me.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConvenio.FormattingEnabled = True
        Me.cboConvenio.Location = New System.Drawing.Point(1, 123)
        Me.cboConvenio.Margin = New System.Windows.Forms.Padding(4)
        Me.cboConvenio.Name = "cboConvenio"
        Me.cboConvenio.Size = New System.Drawing.Size(435, 24)
        Me.cboConvenio.TabIndex = 171
        '
        'txtDataVenda
        '
        Me.txtDataVenda.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
        Me.txtDataVenda.Location = New System.Drawing.Point(587, 20)
        Me.txtDataVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDataVenda.MaskInput = "{date} {time}"
        Me.txtDataVenda.Name = "txtDataVenda"
        Me.txtDataVenda.Size = New System.Drawing.Size(160, 24)
        Me.txtDataVenda.TabIndex = 175
        Me.txtDataVenda.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
        '
        'lblRDataAgendamento
        '
        Me.lblRDataAgendamento.AutoSize = True
        Me.lblRDataAgendamento.Location = New System.Drawing.Point(587, 1)
        Me.lblRDataAgendamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
        Me.lblRDataAgendamento.Size = New System.Drawing.Size(98, 16)
        Me.lblRDataAgendamento.TabIndex = 176
        Me.lblRDataAgendamento.Text = "Data da Venda"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtPercentualDesconto)
        Me.GroupBox1.Controls.Add(Me.cmdNovoProduto)
        Me.GroupBox1.Controls.Add(Me.txtValorDesconto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtValorProcedimento)
        Me.GroupBox1.Controls.Add(Me.grdListagem)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdAdicionarProduto)
        Me.GroupBox1.Controls.Add(Me.cboProfissionalPrestadorServico)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.psqProcedimento)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 204)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(831, 361)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Procedimentos/Exames"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(569, 75)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 16)
        Me.Label13.TabIndex = 256
        Me.Label13.Text = "% Desc"
        '
        'txtPercentualDesconto
        '
        Me.txtPercentualDesconto.FormatString = ""
        Me.txtPercentualDesconto.Location = New System.Drawing.Point(569, 94)
        Me.txtPercentualDesconto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPercentualDesconto.MaskInput = "{double:3.2}"
        Me.txtPercentualDesconto.Name = "txtPercentualDesconto"
        Me.txtPercentualDesconto.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtPercentualDesconto.Size = New System.Drawing.Size(60, 24)
        Me.txtPercentualDesconto.TabIndex = 206
        '
        'cmdNovoProduto
        '
        Me.cmdNovoProduto.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Novo
        Me.cmdNovoProduto.Location = New System.Drawing.Point(789, 58)
        Me.cmdNovoProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNovoProduto.Name = "cmdNovoProduto"
        Me.cmdNovoProduto.Size = New System.Drawing.Size(33, 28)
        Me.cmdNovoProduto.TabIndex = 254
        Me.cmdNovoProduto.UseVisualStyleBackColor = True
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.CausesValidation = False
        Me.txtValorDesconto.Location = New System.Drawing.Point(637, 94)
        Me.txtValorDesconto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorDesconto.MaskInput = "{currency:6.2}"
        Me.txtValorDesconto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(133, 24)
        Me.txtValorDesconto.TabIndex = 207
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(637, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "Valor Desconto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 251
        Me.Label5.Text = "Valor"
        '
        'txtValorProcedimento
        '
        Me.txtValorProcedimento.Location = New System.Drawing.Point(455, 94)
        Me.txtValorProcedimento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorProcedimento.MaskInput = "{currency:6.2}"
        Me.txtValorProcedimento.Name = "txtValorProcedimento"
        Me.txtValorProcedimento.ReadOnly = True
        Me.txtValorProcedimento.Size = New System.Drawing.Size(107, 24)
        Me.txtValorProcedimento.TabIndex = 205
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
        Me.grdListagem.Location = New System.Drawing.Point(4, 145)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(819, 215)
        Me.grdListagem.TabIndex = 249
        Me.grdListagem.Text = "UltraGrid1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 16)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "Listagem de Procedimentos/Exames"
        '
        'cmdAdicionarProduto
        '
        Me.cmdAdicionarProduto.Image = CType(resources.GetObject("cmdAdicionarProduto.Image"), System.Drawing.Image)
        Me.cmdAdicionarProduto.Location = New System.Drawing.Point(789, 94)
        Me.cmdAdicionarProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdicionarProduto.Name = "cmdAdicionarProduto"
        Me.cmdAdicionarProduto.Size = New System.Drawing.Size(33, 28)
        Me.cmdAdicionarProduto.TabIndex = 208
        Me.cmdAdicionarProduto.UseVisualStyleBackColor = True
        '
        'cboProfissionalPrestadorServico
        '
        Me.cboProfissionalPrestadorServico.FormattingEnabled = True
        Me.cboProfissionalPrestadorServico.Location = New System.Drawing.Point(9, 94)
        Me.cboProfissionalPrestadorServico.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProfissionalPrestadorServico.Name = "cboProfissionalPrestadorServico"
        Me.cboProfissionalPrestadorServico.Size = New System.Drawing.Size(436, 24)
        Me.cboProfissionalPrestadorServico.TabIndex = 204
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 16)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Médico/Prestador de Serviço"
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(617, 572)
        Me.cmdGravar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(100, 34)
        Me.cmdGravar.TabIndex = 301
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = CType(resources.GetObject("cmdFechar.Image"), System.Drawing.Image)
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(737, 572)
        Me.cmdFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(100, 34)
        Me.cmdFechar.TabIndex = 302
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'lblValorTotalProcedimento
        '
        Me.lblValorTotalProcedimento.AutoSize = True
        Me.lblValorTotalProcedimento.Location = New System.Drawing.Point(251, 593)
        Me.lblValorTotalProcedimento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorTotalProcedimento.Name = "lblValorTotalProcedimento"
        Me.lblValorTotalProcedimento.Size = New System.Drawing.Size(168, 16)
        Me.lblValorTotalProcedimento.TabIndex = 191
        Me.lblValorTotalProcedimento.Text = "lblValorTotalProcedimento"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(251, 572)
        Me.lblQuantidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(91, 16)
        Me.lblQuantidade.TabIndex = 190
        Me.lblQuantidade.Text = "lblQuantidade"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 593)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(233, 17)
        Me.Label9.TabIndex = 189
        Me.Label9.Text = "Valor Total de Procedimentos: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 572)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 17)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "Quantidade de Procedimentos: "
        '
        'cboContaFinanceira
        '
        Me.cboContaFinanceira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaFinanceira.FormattingEnabled = True
        Me.cboContaFinanceira.Location = New System.Drawing.Point(445, 123)
        Me.cboContaFinanceira.Margin = New System.Windows.Forms.Padding(4)
        Me.cboContaFinanceira.Name = "cboContaFinanceira"
        Me.cboContaFinanceira.Size = New System.Drawing.Size(385, 24)
        Me.cboContaFinanceira.TabIndex = 192
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(445, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Conta Caixa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 53)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 16)
        Me.Label7.TabIndex = 194
        Me.Label7.Text = "Vendas Pendentes"
        '
        'cboVendaPendente
        '
        Me.cboVendaPendente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVendaPendente.FormattingEnabled = True
        Me.cboVendaPendente.Location = New System.Drawing.Point(1, 71)
        Me.cboVendaPendente.Margin = New System.Windows.Forms.Padding(4)
        Me.cboVendaPendente.Name = "cboVendaPendente"
        Me.cboVendaPendente.Size = New System.Drawing.Size(435, 24)
        Me.cboVendaPendente.TabIndex = 195
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(543, -52)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 198
        Me.Label10.Text = "Data da Venda"
        '
        'txtCodigoVenda
        '
        Me.txtCodigoVenda.Location = New System.Drawing.Point(755, 20)
        Me.txtCodigoVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoVenda.Name = "txtCodigoVenda"
        Me.txtCodigoVenda.ReadOnly = True
        Me.txtCodigoVenda.Size = New System.Drawing.Size(79, 22)
        Me.txtCodigoVenda.TabIndex = 197
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(755, 1)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 196
        Me.Label11.Text = "Cód Venda"
        '
        'cmdNovo
        '
        Me.cmdNovo.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Novo
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(497, 572)
        Me.cmdNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(100, 34)
        Me.cmdNovo.TabIndex = 300
        Me.cmdNovo.Text = "  Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdGuiaConsultas
        '
        Me.cmdGuiaConsultas.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdGuiaConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuiaConsultas.Location = New System.Drawing.Point(497, 610)
        Me.cmdGuiaConsultas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuiaConsultas.Name = "cmdGuiaConsultas"
        Me.cmdGuiaConsultas.Size = New System.Drawing.Size(100, 34)
        Me.cmdGuiaConsultas.TabIndex = 303
        Me.cmdGuiaConsultas.Text = " Guia"
        Me.cmdGuiaConsultas.UseVisualStyleBackColor = True
        '
        'cmdExameInterno
        '
        Me.cmdExameInterno.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdExameInterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExameInterno.Location = New System.Drawing.Point(617, 610)
        Me.cmdExameInterno.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExameInterno.Name = "cmdExameInterno"
        Me.cmdExameInterno.Size = New System.Drawing.Size(100, 34)
        Me.cmdExameInterno.TabIndex = 304
        Me.cmdExameInterno.Text = "    E. Interno"
        Me.cmdExameInterno.UseVisualStyleBackColor = True
        '
        'cmdExameExterno
        '
        Me.cmdExameExterno.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdExameExterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExameExterno.Location = New System.Drawing.Point(737, 610)
        Me.cmdExameExterno.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExameExterno.Name = "cmdExameExterno"
        Me.cmdExameExterno.Size = New System.Drawing.Size(100, 34)
        Me.cmdExameExterno.TabIndex = 305
        Me.cmdExameExterno.Text = "   E. Externo"
        Me.cmdExameExterno.UseVisualStyleBackColor = True
        '
        'lblValorTotalDesconto
        '
        Me.lblValorTotalDesconto.AutoSize = True
        Me.lblValorTotalDesconto.Location = New System.Drawing.Point(251, 614)
        Me.lblValorTotalDesconto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorTotalDesconto.Name = "lblValorTotalDesconto"
        Me.lblValorTotalDesconto.Size = New System.Drawing.Size(142, 16)
        Me.lblValorTotalDesconto.TabIndex = 206
        Me.lblValorTotalDesconto.Text = "lblValorTotalDesconto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1, 614)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 17)
        Me.Label14.TabIndex = 205
        Me.Label14.Text = "Valor Total de Desconto:"
        '
        'cboIndicador
        '
        Me.cboIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIndicador.FormattingEnabled = True
        Me.cboIndicador.Location = New System.Drawing.Point(445, 71)
        Me.cboIndicador.Margin = New System.Windows.Forms.Padding(4)
        Me.cboIndicador.Name = "cboIndicador"
        Me.cboIndicador.Size = New System.Drawing.Size(388, 24)
        Me.cboIndicador.TabIndex = 306
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(445, 53)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 16)
        Me.Label15.TabIndex = 307
        Me.Label15.Text = "Indicador"
        '
        'lblSaldoConvenio
        '
        Me.lblSaldoConvenio.AutoSize = True
        Me.lblSaldoConvenio.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoConvenio.Location = New System.Drawing.Point(783, 242)
        Me.lblSaldoConvenio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldoConvenio.Name = "lblSaldoConvenio"
        Me.lblSaldoConvenio.Size = New System.Drawing.Size(114, 16)
        Me.lblSaldoConvenio.TabIndex = 257
        Me.lblSaldoConvenio.Text = "lblSaldoConvenio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(445, 156)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 16)
        Me.Label16.TabIndex = 309
        Me.Label16.Text = "Canal de Marcação"
        '
        'cboCanalMarcacao
        '
        Me.cboCanalMarcacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCanalMarcacao.FormattingEnabled = True
        Me.cboCanalMarcacao.Location = New System.Drawing.Point(445, 174)
        Me.cboCanalMarcacao.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCanalMarcacao.Name = "cboCanalMarcacao"
        Me.cboCanalMarcacao.Size = New System.Drawing.Size(132, 24)
        Me.cboCanalMarcacao.TabIndex = 308
        '
        'chkImrimirGuiaConsultas
        '
        Me.chkImrimirGuiaConsultas.AutoSize = True
        Me.chkImrimirGuiaConsultas.Checked = True
        Me.chkImrimirGuiaConsultas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImrimirGuiaConsultas.Location = New System.Drawing.Point(477, 610)
        Me.chkImrimirGuiaConsultas.Margin = New System.Windows.Forms.Padding(4)
        Me.chkImrimirGuiaConsultas.Name = "chkImrimirGuiaConsultas"
        Me.chkImrimirGuiaConsultas.Size = New System.Drawing.Size(18, 17)
        Me.chkImrimirGuiaConsultas.TabIndex = 310
        Me.chkImrimirGuiaConsultas.UseVisualStyleBackColor = True
        '
        'chkImrimirExameInterno
        '
        Me.chkImrimirExameInterno.AutoSize = True
        Me.chkImrimirExameInterno.Checked = True
        Me.chkImrimirExameInterno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImrimirExameInterno.Location = New System.Drawing.Point(597, 610)
        Me.chkImrimirExameInterno.Margin = New System.Windows.Forms.Padding(4)
        Me.chkImrimirExameInterno.Name = "chkImrimirExameInterno"
        Me.chkImrimirExameInterno.Size = New System.Drawing.Size(18, 17)
        Me.chkImrimirExameInterno.TabIndex = 311
        Me.chkImrimirExameInterno.UseVisualStyleBackColor = True
        '
        'chkImrimirExameExterno
        '
        Me.chkImrimirExameExterno.AutoSize = True
        Me.chkImrimirExameExterno.Checked = True
        Me.chkImrimirExameExterno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImrimirExameExterno.Location = New System.Drawing.Point(717, 610)
        Me.chkImrimirExameExterno.Margin = New System.Windows.Forms.Padding(4)
        Me.chkImrimirExameExterno.Name = "chkImrimirExameExterno"
        Me.chkImrimirExameExterno.Size = New System.Drawing.Size(18, 17)
        Me.chkImrimirExameExterno.TabIndex = 312
        Me.chkImrimirExameExterno.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(588, 156)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 16)
        Me.Label17.TabIndex = 314
        Me.Label17.Text = "Voucher"
        '
        'oVoucher
        '
        Me.oVoucher.Location = New System.Drawing.Point(588, 175)
        Me.oVoucher.Margin = New System.Windows.Forms.Padding(5)
        Me.oVoucher.Name = "oVoucher"
        Me.oVoucher.Size = New System.Drawing.Size(244, 26)
        Me.oVoucher.TabIndex = 313
        '
        'psqPessoa
        '
        Me.psqPessoa.AdicionarPessoa = False
        Me.psqPessoa.Bordas = True
        Me.psqPessoa.CarregarTodos = False
        Me.psqPessoa.DS_Pessoa = ""
        Me.psqPessoa.ID_Pessoa = 0
        Me.psqPessoa.LabelVisivel = True
        Me.psqPessoa.Location = New System.Drawing.Point(1, 1)
        Me.psqPessoa.Margin = New System.Windows.Forms.Padding(5)
        Me.psqPessoa.Name = "psqPessoa"
        Me.psqPessoa.PesquisarPessoa = True
        Me.psqPessoa.Rotulo = "Cliente"
        Me.psqPessoa.Size = New System.Drawing.Size(577, 39)
        Me.psqPessoa.SomenteLeitura = False
        Me.psqPessoa.TabIndex = 169
        Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Fisica
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = True
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.GrupoProcedimento = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = True
        Me.psqProcedimento.Location = New System.Drawing.Point(9, 23)
        Me.psqProcedimento.Margin = New System.Windows.Forms.Padding(5)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(765, 44)
        Me.psqProcedimento.TabIndex = 202
        '
        'uscCadastroVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.oVoucher)
        Me.Controls.Add(Me.chkImrimirExameExterno)
        Me.Controls.Add(Me.chkImrimirExameInterno)
        Me.Controls.Add(Me.chkImrimirGuiaConsultas)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cboCanalMarcacao)
        Me.Controls.Add(Me.lblSaldoConvenio)
        Me.Controls.Add(Me.cboIndicador)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblValorTotalDesconto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmdExameExterno)
        Me.Controls.Add(Me.cmdExameInterno)
        Me.Controls.Add(Me.cmdGuiaConsultas)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCodigoVenda)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboVendaPendente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboContaFinanceira)
        Me.Controls.Add(Me.lblValorTotalProcedimento)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.txtDataVenda)
        Me.Controls.Add(Me.lblRDataAgendamento)
        Me.Controls.Add(Me.cboConvenio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.psqPessoa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "uscCadastroVenda"
        Me.Size = New System.Drawing.Size(836, 649)
        CType(Me.txtDataVenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtPercentualDesconto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorDesconto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorProcedimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents psqPessoa As uscPesqPessoa
    Friend WithEvents Label1 As Label
    Friend WithEvents cboConvenio As ComboBox
    Friend WithEvents txtDataVenda As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRDataAgendamento As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents psqProcedimento As uscPesqProcedimento
    Friend WithEvents cboProfissionalPrestadorServico As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdAdicionarProduto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValorProcedimento As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents lblValorTotalProcedimento As Label
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboContaFinanceira As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboVendaPendente As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCodigoVenda As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdNovo As Button
    Friend WithEvents cmdGuiaConsultas As Button
    Friend WithEvents cmdExameInterno As Button
    Friend WithEvents cmdExameExterno As Button
    Friend WithEvents txtValorDesconto As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents Label12 As Label
    Friend WithEvents cmdNovoProduto As Button
    Friend WithEvents lblValorTotalDesconto As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPercentualDesconto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label13 As Label
    Friend WithEvents cboIndicador As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblSaldoConvenio As Label
  Friend WithEvents Label16 As Label
  Friend WithEvents cboCanalMarcacao As ComboBox
  Friend WithEvents chkImrimirGuiaConsultas As CheckBox
  Friend WithEvents chkImrimirExameInterno As CheckBox
  Friend WithEvents chkImrimirExameExterno As CheckBox
    Friend WithEvents oVoucher As uscVoucher
    Friend WithEvents Label17 As Label
End Class
