<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaContasReceberPagar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
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
        Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.lblRListagemPessoa = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboContaCaixa = New System.Windows.Forms.ComboBox()
        Me.cboContaBancaria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoMovimentacaoFinanceira = New System.Windows.Forms.ComboBox()
        Me.cboPlanoContas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdQuitar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.txtCodMovimentacao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdQuitar_Excluir = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigoPagamento = New System.Windows.Forms.TextBox()
        Me.cmdRenegociar = New System.Windows.Forms.Button()
        Me.grpPeriodo = New System.Windows.Forms.GroupBox()
        Me.cboTipoPeriodo = New System.Windows.Forms.ComboBox()
        Me.txtCodigoDocumento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdLimpar = New System.Windows.Forms.Button()
        Me.cmdPDF = New System.Windows.Forms.Button()
        Me.cmdTransferir = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdPrestacaoContas = New System.Windows.Forms.Button()
        Me.cmdItensFaturados = New System.Windows.Forms.Button()
        Me.chkSomentePendentesCompesacao = New System.Windows.Forms.CheckBox()
        Me.cmdCompensar = New System.Windows.Forms.Button()
        Me.cboCondicaoPagamento = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
        Me.cmdHistorico = New System.Windows.Forms.Button()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPeriodo.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grdListagem.Size = New System.Drawing.Size(1244, 348)
        Me.grdListagem.TabIndex = 66
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 89)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(131, 13)
        Me.lblRListagemPessoa.TabIndex = 65
        Me.lblRListagemPessoa.Tag = "Listagem de Lançamentos"
        Me.lblRListagemPessoa.Text = "Listagem de Lançamentos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(127, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Conta Caixa"
        '
        'cboContaCaixa
        '
        Me.cboContaCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaCaixa.FormattingEnabled = True
        Me.cboContaCaixa.Location = New System.Drawing.Point(127, 20)
        Me.cboContaCaixa.Name = "cboContaCaixa"
        Me.cboContaCaixa.Size = New System.Drawing.Size(168, 21)
        Me.cboContaCaixa.TabIndex = 2
        '
        'cboContaBancaria
        '
        Me.cboContaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaBancaria.FormattingEnabled = True
        Me.cboContaBancaria.Location = New System.Drawing.Point(5, 62)
        Me.cboContaBancaria.Name = "cboContaBancaria"
        Me.cboContaBancaria.Size = New System.Drawing.Size(240, 21)
        Me.cboContaBancaria.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Conta Bancária"
        '
        'txtDataInicial
        '
        Me.txtDataInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataInicial.Location = New System.Drawing.Point(7, 14)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataInicial.TabIndex = 10
        Me.txtDataInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Tipo de Movimentação"
        '
        'cboTipoMovimentacaoFinanceira
        '
        Me.cboTipoMovimentacaoFinanceira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoMovimentacaoFinanceira.FormattingEnabled = True
        Me.cboTipoMovimentacaoFinanceira.Location = New System.Drawing.Point(5, 20)
        Me.cboTipoMovimentacaoFinanceira.Name = "cboTipoMovimentacaoFinanceira"
        Me.cboTipoMovimentacaoFinanceira.Size = New System.Drawing.Size(116, 21)
        Me.cboTipoMovimentacaoFinanceira.TabIndex = 1
        '
        'cboPlanoContas
        '
        Me.cboPlanoContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanoContas.DropDownWidth = 550
        Me.cboPlanoContas.FormattingEnabled = True
        Me.cboPlanoContas.Location = New System.Drawing.Point(253, 62)
        Me.cboPlanoContas.Name = "cboPlanoContas"
        Me.cboPlanoContas.Size = New System.Drawing.Size(168, 21)
        Me.cboPlanoContas.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Plano de Contas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(832, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Tipo de Documento"
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.DropDownWidth = 200
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(832, 62)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(150, 21)
        Me.cboTipoDocumento.TabIndex = 5
        '
        'txtDataFinal
        '
        Me.txtDataFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataFinal.Location = New System.Drawing.Point(105, 14)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataFinal.TabIndex = 11
        Me.txtDataFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "a"
        '
        'cmdQuitar
        '
        Me.cmdQuitar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Quitar
        Me.cmdQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdQuitar.Location = New System.Drawing.Point(163, 456)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(75, 28)
        Me.cmdQuitar.TabIndex = 103
        Me.cmdQuitar.Text = "Quitar"
        Me.cmdQuitar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(637, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.DropDownWidth = 300
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(637, 62)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(187, 21)
        Me.cboStatus.TabIndex = 4
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(435, 456)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 106
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Cancelar
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(84, 456)
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
        Me.cmdAlterar.Location = New System.Drawing.Point(5, 456)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAlterar.TabIndex = 101
        Me.cmdAlterar.Text = "Alterar"
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(1174, 55)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 12
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(1174, 456)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 107
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'txtCodMovimentacao
        '
        Me.txtCodMovimentacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodMovimentacao.Location = New System.Drawing.Point(429, 62)
        Me.txtCodMovimentacao.Name = "txtCodMovimentacao"
        Me.txtCodMovimentacao.Size = New System.Drawing.Size(60, 20)
        Me.txtCodMovimentacao.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(429, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Cód. Movim."
        '
        'cmdQuitar_Excluir
        '
        Me.cmdQuitar_Excluir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Quitar
        Me.cmdQuitar_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdQuitar_Excluir.Location = New System.Drawing.Point(321, 456)
        Me.cmdQuitar_Excluir.Name = "cmdQuitar_Excluir"
        Me.cmdQuitar_Excluir.Size = New System.Drawing.Size(110, 28)
        Me.cmdQuitar_Excluir.TabIndex = 105
        Me.cmdQuitar_Excluir.Text = "    Excluir Quitação"
        Me.cmdQuitar_Excluir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(497, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "Cód. Pagto."
        '
        'txtCodigoPagamento
        '
        Me.txtCodigoPagamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoPagamento.Location = New System.Drawing.Point(497, 62)
        Me.txtCodigoPagamento.Name = "txtCodigoPagamento"
        Me.txtCodigoPagamento.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigoPagamento.TabIndex = 9
        '
        'cmdRenegociar
        '
        Me.cmdRenegociar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRenegociar.Location = New System.Drawing.Point(242, 456)
        Me.cmdRenegociar.Name = "cmdRenegociar"
        Me.cmdRenegociar.Size = New System.Drawing.Size(75, 28)
        Me.cmdRenegociar.TabIndex = 104
        Me.cmdRenegociar.Text = "Renegociar"
        Me.cmdRenegociar.UseVisualStyleBackColor = True
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.cboTipoPeriodo)
        Me.grpPeriodo.Controls.Add(Me.Label7)
        Me.grpPeriodo.Controls.Add(Me.txtDataFinal)
        Me.grpPeriodo.Controls.Add(Me.txtDataInicial)
        Me.grpPeriodo.Location = New System.Drawing.Point(721, 5)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(287, 41)
        Me.grpPeriodo.TabIndex = 125
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período"
        '
        'cboTipoPeriodo
        '
        Me.cboTipoPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPeriodo.FormattingEnabled = True
        Me.cboTipoPeriodo.Items.AddRange(New Object() {"Lançamento", "Quitação", "Ult. Pagto.", "Vencimento"})
        Me.cboTipoPeriodo.Location = New System.Drawing.Point(196, 14)
        Me.cboTipoPeriodo.Name = "cboTipoPeriodo"
        Me.cboTipoPeriodo.Size = New System.Drawing.Size(85, 21)
        Me.cboTipoPeriodo.TabIndex = 125
        '
        'txtCodigoDocumento
        '
        Me.txtCodigoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoDocumento.Location = New System.Drawing.Point(565, 62)
        Me.txtCodigoDocumento.Name = "txtCodigoDocumento"
        Me.txtCodigoDocumento.Size = New System.Drawing.Size(64, 20)
        Me.txtCodigoDocumento.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(565, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Cód. Docto."
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(1174, 23)
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
        Me.cmdPDF.Location = New System.Drawing.Point(514, 456)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 234
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'cmdTransferir
        '
        Me.cmdTransferir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTransferir.Location = New System.Drawing.Point(593, 456)
        Me.cmdTransferir.Name = "cmdTransferir"
        Me.cmdTransferir.Size = New System.Drawing.Size(75, 28)
        Me.cmdTransferir.TabIndex = 235
        Me.cmdTransferir.Text = "    Transferir"
        Me.cmdTransferir.UseVisualStyleBackColor = True
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(672, 456)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
        Me.cmdImprimir.TabIndex = 271
        Me.cmdImprimir.Text = "    Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdPrestacaoContas
        '
        Me.cmdPrestacaoContas.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdPrestacaoContas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrestacaoContas.Location = New System.Drawing.Point(751, 456)
        Me.cmdPrestacaoContas.Name = "cmdPrestacaoContas"
        Me.cmdPrestacaoContas.Size = New System.Drawing.Size(134, 28)
        Me.cmdPrestacaoContas.TabIndex = 272
        Me.cmdPrestacaoContas.Text = "     Prestação de Contas"
        Me.cmdPrestacaoContas.UseVisualStyleBackColor = True
        '
        'cmdItensFaturados
        '
        Me.cmdItensFaturados.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdItensFaturados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdItensFaturados.Location = New System.Drawing.Point(889, 456)
        Me.cmdItensFaturados.Name = "cmdItensFaturados"
        Me.cmdItensFaturados.Size = New System.Drawing.Size(108, 28)
        Me.cmdItensFaturados.TabIndex = 273
        Me.cmdItensFaturados.Text = "    Itens Faturados"
        Me.cmdItensFaturados.UseVisualStyleBackColor = True
        '
        'chkSomentePendentesCompesacao
        '
        Me.chkSomentePendentesCompesacao.AutoSize = True
        Me.chkSomentePendentesCompesacao.Location = New System.Drawing.Point(637, 85)
        Me.chkSomentePendentesCompesacao.Name = "chkSomentePendentesCompesacao"
        Me.chkSomentePendentesCompesacao.Size = New System.Drawing.Size(202, 17)
        Me.chkSomentePendentesCompesacao.TabIndex = 274
        Me.chkSomentePendentesCompesacao.Text = "Somente Pendentes de Compesação"
        Me.chkSomentePendentesCompesacao.UseVisualStyleBackColor = True
        '
        'cmdCompensar
        '
        Me.cmdCompensar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Novo
        Me.cmdCompensar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompensar.Location = New System.Drawing.Point(1001, 456)
        Me.cmdCompensar.Name = "cmdCompensar"
        Me.cmdCompensar.Size = New System.Drawing.Size(90, 28)
        Me.cmdCompensar.TabIndex = 275
        Me.cmdCompensar.Text = "      Compensar"
        Me.cmdCompensar.UseVisualStyleBackColor = True
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondicaoPagamento.DropDownWidth = 200
        Me.cboCondicaoPagamento.FormattingEnabled = True
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(990, 62)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(150, 21)
        Me.cboCondicaoPagamento.TabIndex = 276
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(990, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 277
        Me.Label10.Text = "Condição de Pagamento"
        '
        'psqPessoa
        '
        Me.psqPessoa.AdicionarPessoa = False
        Me.psqPessoa.Bordas = True
        Me.psqPessoa.CarregarTodos = False
        Me.psqPessoa.DS_Pessoa = ""
        Me.psqPessoa.ID_Pessoa = 0
        Me.psqPessoa.LabelVisivel = True
        Me.psqPessoa.Location = New System.Drawing.Point(301, 5)
        Me.psqPessoa.Name = "psqPessoa"
        Me.psqPessoa.PesquisarPessoa = True
        Me.psqPessoa.Rotulo = "Pessoa"
        Me.psqPessoa.Size = New System.Drawing.Size(414, 36)
        Me.psqPessoa.SomenteLeitura = False
        Me.psqPessoa.TabIndex = 3
        Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'cmdHistorico
        '
        Me.cmdHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHistorico.Location = New System.Drawing.Point(1095, 456)
        Me.cmdHistorico.Name = "cmdHistorico"
        Me.cmdHistorico.Size = New System.Drawing.Size(75, 28)
        Me.cmdHistorico.TabIndex = 278
        Me.cmdHistorico.Text = "    Histórico"
        Me.cmdHistorico.UseVisualStyleBackColor = True
        '
        'frmConsultaContasReceberPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 488)
        Me.Controls.Add(Me.cmdHistorico)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboCondicaoPagamento)
        Me.Controls.Add(Me.cmdCompensar)
        Me.Controls.Add(Me.chkSomentePendentesCompesacao)
        Me.Controls.Add(Me.cmdItensFaturados)
        Me.Controls.Add(Me.cmdPrestacaoContas)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdTransferir)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigoDocumento)
        Me.Controls.Add(Me.cmdRenegociar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdQuitar_Excluir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodMovimentacao)
        Me.Controls.Add(Me.psqPessoa)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cmdQuitar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.Controls.Add(Me.cboPlanoContas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboContaBancaria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboContaCaixa)
        Me.Controls.Add(Me.cboTipoMovimentacaoFinanceira)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.Controls.Add(Me.txtCodigoPagamento)
        Me.Controls.Add(Me.grpPeriodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmConsultaContasReceberPagar"
        Me.Text = "Consulta de Contas a Receber e a Pagar"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblRListagemPessoa As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboContaCaixa As System.Windows.Forms.ComboBox
    Friend WithEvents cboContaBancaria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTipoMovimentacaoFinanceira As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlanoContas As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
    Friend WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmdExcel As System.Windows.Forms.Button
    Friend WithEvents psqPessoa As uscPesqPessoa
    Friend WithEvents txtCodMovimentacao As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdQuitar_Excluir As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCodigoPagamento As TextBox
    Friend WithEvents cmdRenegociar As Button
    Friend WithEvents grpPeriodo As GroupBox
    Friend WithEvents cboTipoPeriodo As ComboBox
    Friend WithEvents txtCodigoDocumento As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdLimpar As Button
    Friend WithEvents cmdPDF As Button
    Friend WithEvents cmdTransferir As Button
    Friend WithEvents cmdImprimir As Button
    Friend WithEvents cmdPrestacaoContas As Button
    Friend WithEvents cmdItensFaturados As Button
    Friend WithEvents chkSomentePendentesCompesacao As CheckBox
    Friend WithEvents cmdCompensar As Button
    Friend WithEvents cboCondicaoPagamento As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdHistorico As Button
End Class
