<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscLancaContasReceberPagar_QuitarForm
  Inherits System.Windows.Forms.UserControl

  'O UserControl substitui o descarte para limpar a lista de componentes.
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
    Me.grdFormaPagamento = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnuGrid_ComprimirExpandir = New System.Windows.Forms.ToolStripMenuItem()
    Me.pnlControles = New System.Windows.Forms.Panel()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdRemover = New System.Windows.Forms.Button()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.lblRDocFinanc_CredPessoa_EncContas = New System.Windows.Forms.Label()
    Me.txtNrContaDigito = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.txtNrConta = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.txtNrAgencia = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.cboBanco = New System.Windows.Forms.ComboBox()
    Me.txtCodDocumento = New System.Windows.Forms.TextBox()
    Me.opsqEmitente = New uscPesqPessoa()
    Me.txtDtDocumento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDescricaoDocumento = New System.Windows.Forms.TextBox()
    Me.cboContaDebito_ContaCredito = New System.Windows.Forms.ComboBox()
    Me.txtValorSaldo = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.txtValorPago = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.cboFormaPagamento = New System.Windows.Forms.ComboBox()
    Me.lblRDescricaoDocumento = New System.Windows.Forms.Label()
    Me.lblRNrContaDigito = New System.Windows.Forms.Label()
    Me.lblRConta = New System.Windows.Forms.Label()
    Me.lblRBanco = New System.Windows.Forms.Label()
    Me.lblRAgencia = New System.Windows.Forms.Label()
    Me.lblRDtDocumento = New System.Windows.Forms.Label()
    Me.lblRContaDebito_ContaCredito = New System.Windows.Forms.Label()
    Me.lblRCodDocumento = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboDocFinanc_CredPessoa_EncContas = New System.Windows.Forms.ComboBox()
    CType(Me.grdFormaPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.cmsGrid.SuspendLayout()
    Me.pnlControles.SuspendLayout()
    CType(Me.txtNrContaDigito, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNrConta, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNrAgencia, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDtDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtValorSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtValorPago, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdFormaPagamento
    '
    Me.grdFormaPagamento.ContextMenuStrip = Me.cmsGrid
    Appearance1.BackColor = System.Drawing.SystemColors.Window
    Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdFormaPagamento.DisplayLayout.Appearance = Appearance1
    Me.grdFormaPagamento.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdFormaPagamento.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance2.BorderColor = System.Drawing.SystemColors.Window
    Me.grdFormaPagamento.DisplayLayout.GroupByBox.Appearance = Appearance2
    Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdFormaPagamento.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
    Me.grdFormaPagamento.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance4.BackColor2 = System.Drawing.SystemColors.Control
    Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdFormaPagamento.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
    Me.grdFormaPagamento.DisplayLayout.MaxColScrollRegions = 1
    Me.grdFormaPagamento.DisplayLayout.MaxRowScrollRegions = 1
    Appearance5.BackColor = System.Drawing.SystemColors.Window
    Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdFormaPagamento.DisplayLayout.Override.ActiveCellAppearance = Appearance5
    Appearance6.BackColor = System.Drawing.SystemColors.Highlight
    Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdFormaPagamento.DisplayLayout.Override.ActiveRowAppearance = Appearance6
    Me.grdFormaPagamento.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdFormaPagamento.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance7.BackColor = System.Drawing.SystemColors.Window
    Me.grdFormaPagamento.DisplayLayout.Override.CardAreaAppearance = Appearance7
    Appearance8.BorderColor = System.Drawing.Color.Silver
    Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdFormaPagamento.DisplayLayout.Override.CellAppearance = Appearance8
    Me.grdFormaPagamento.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.grdFormaPagamento.DisplayLayout.Override.CellPadding = 0
    Appearance9.BackColor = System.Drawing.SystemColors.Control
    Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance9.BorderColor = System.Drawing.SystemColors.Window
    Me.grdFormaPagamento.DisplayLayout.Override.GroupByRowAppearance = Appearance9
    Appearance10.TextHAlignAsString = "Left"
    Me.grdFormaPagamento.DisplayLayout.Override.HeaderAppearance = Appearance10
    Me.grdFormaPagamento.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdFormaPagamento.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance11.BackColor = System.Drawing.SystemColors.Window
    Appearance11.BorderColor = System.Drawing.Color.Silver
    Me.grdFormaPagamento.DisplayLayout.Override.RowAppearance = Appearance11
    Me.grdFormaPagamento.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdFormaPagamento.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
    Me.grdFormaPagamento.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdFormaPagamento.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdFormaPagamento.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdFormaPagamento.Location = New System.Drawing.Point(562, 0)
    Me.grdFormaPagamento.Name = "grdFormaPagamento"
    Me.grdFormaPagamento.Size = New System.Drawing.Size(220, 120)
    Me.grdFormaPagamento.TabIndex = 234
    Me.grdFormaPagamento.Text = "UltraGrid1"
    '
    'cmsGrid
    '
    Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGrid_ComprimirExpandir})
    Me.cmsGrid.Name = "cmsGrid"
    Me.cmsGrid.Size = New System.Drawing.Size(183, 26)
    '
    'mnuGrid_ComprimirExpandir
    '
    Me.mnuGrid_ComprimirExpandir.Name = "mnuGrid_ComprimirExpandir"
    Me.mnuGrid_ComprimirExpandir.Size = New System.Drawing.Size(182, 22)
    Me.mnuGrid_ComprimirExpandir.Text = "Comprimir/Expandir"
    '
    'pnlControles
    '
    Me.pnlControles.Controls.Add(Me.cmdNovo)
    Me.pnlControles.Controls.Add(Me.cmdRemover)
    Me.pnlControles.Controls.Add(Me.cmdGravar)
    Me.pnlControles.Controls.Add(Me.lblRDocFinanc_CredPessoa_EncContas)
    Me.pnlControles.Controls.Add(Me.txtNrContaDigito)
    Me.pnlControles.Controls.Add(Me.txtNrConta)
    Me.pnlControles.Controls.Add(Me.txtNrAgencia)
    Me.pnlControles.Controls.Add(Me.cboBanco)
    Me.pnlControles.Controls.Add(Me.txtCodDocumento)
    Me.pnlControles.Controls.Add(Me.opsqEmitente)
    Me.pnlControles.Controls.Add(Me.txtDtDocumento)
    Me.pnlControles.Controls.Add(Me.txtDescricaoDocumento)
    Me.pnlControles.Controls.Add(Me.cboContaDebito_ContaCredito)
    Me.pnlControles.Controls.Add(Me.txtValorSaldo)
    Me.pnlControles.Controls.Add(Me.txtValorPago)
    Me.pnlControles.Controls.Add(Me.cboFormaPagamento)
    Me.pnlControles.Controls.Add(Me.lblRDescricaoDocumento)
    Me.pnlControles.Controls.Add(Me.lblRNrContaDigito)
    Me.pnlControles.Controls.Add(Me.lblRConta)
    Me.pnlControles.Controls.Add(Me.lblRBanco)
    Me.pnlControles.Controls.Add(Me.lblRAgencia)
    Me.pnlControles.Controls.Add(Me.lblRDtDocumento)
    Me.pnlControles.Controls.Add(Me.lblRContaDebito_ContaCredito)
    Me.pnlControles.Controls.Add(Me.lblRCodDocumento)
    Me.pnlControles.Controls.Add(Me.Label3)
    Me.pnlControles.Controls.Add(Me.Label2)
    Me.pnlControles.Controls.Add(Me.Label1)
    Me.pnlControles.Controls.Add(Me.cboDocFinanc_CredPessoa_EncContas)
    Me.pnlControles.Location = New System.Drawing.Point(0, 0)
    Me.pnlControles.Name = "pnlControles"
    Me.pnlControles.Size = New System.Drawing.Size(558, 122)
    Me.pnlControles.TabIndex = 235
    '
    'cmdNovo
    '
    Me.cmdNovo.Image = My.Resources.Resources.Mini_Novo
    Me.cmdNovo.Location = New System.Drawing.Point(478, 98)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(25, 23)
    Me.cmdNovo.TabIndex = 261
    Me.cmdNovo.TabStop = False
    Me.cmdNovo.UseVisualStyleBackColor = True
    '
    'cmdRemover
    '
    Me.cmdRemover.Image = My.Resources.Resources.Mini_Excluir
    Me.cmdRemover.Location = New System.Drawing.Point(532, 98)
    Me.cmdRemover.Name = "cmdRemover"
    Me.cmdRemover.Size = New System.Drawing.Size(25, 23)
    Me.cmdRemover.TabIndex = 260
    Me.cmdRemover.TabStop = False
    Me.cmdRemover.UseVisualStyleBackColor = True
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.Location = New System.Drawing.Point(505, 98)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(25, 23)
    Me.cmdGravar.TabIndex = 259
    Me.cmdGravar.TabStop = False
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'lblRDocFinanc_CredPessoa_EncContas
    '
    Me.lblRDocFinanc_CredPessoa_EncContas.AutoSize = True
    Me.lblRDocFinanc_CredPessoa_EncContas.Location = New System.Drawing.Point(138, 75)
    Me.lblRDocFinanc_CredPessoa_EncContas.Name = "lblRDocFinanc_CredPessoa_EncContas"
    Me.lblRDocFinanc_CredPessoa_EncContas.Size = New System.Drawing.Size(199, 13)
    Me.lblRDocFinanc_CredPessoa_EncContas.TabIndex = 257
    Me.lblRDocFinanc_CredPessoa_EncContas.Text = "Doc. Financ./Créd. Pessoa/Enc. Contas"
    '
    'txtNrContaDigito
    '
    Me.txtNrContaDigito.ImageTransparentColor = System.Drawing.Color.Turquoise
    Me.txtNrContaDigito.ImeMode = System.Windows.Forms.ImeMode.Off
    Me.txtNrContaDigito.Location = New System.Drawing.Point(422, 100)
    Me.txtNrContaDigito.MaskInput = "nn"
    Me.txtNrContaDigito.MinValue = 0
    Me.txtNrContaDigito.Name = "txtNrContaDigito"
    Me.txtNrContaDigito.Size = New System.Drawing.Size(30, 21)
    Me.txtNrContaDigito.TabIndex = 256
    '
    'txtNrConta
    '
    Me.txtNrConta.ImageTransparentColor = System.Drawing.Color.Turquoise
    Me.txtNrConta.ImeMode = System.Windows.Forms.ImeMode.Off
    Me.txtNrConta.Location = New System.Drawing.Point(339, 100)
    Me.txtNrConta.MaskInput = "nnnnnnnnn"
    Me.txtNrConta.MinValue = 0
    Me.txtNrConta.Name = "txtNrConta"
    Me.txtNrConta.Size = New System.Drawing.Size(77, 21)
    Me.txtNrConta.TabIndex = 255
    '
    'txtNrAgencia
    '
    Me.txtNrAgencia.ImageTransparentColor = System.Drawing.Color.Turquoise
    Me.txtNrAgencia.ImeMode = System.Windows.Forms.ImeMode.Off
    Me.txtNrAgencia.Location = New System.Drawing.Point(273, 100)
    Me.txtNrAgencia.MaskInput = "nnnnnn"
    Me.txtNrAgencia.MinValue = 0
    Me.txtNrAgencia.Name = "txtNrAgencia"
    Me.txtNrAgencia.Size = New System.Drawing.Size(60, 21)
    Me.txtNrAgencia.TabIndex = 254
    '
    'cboBanco
    '
    Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboBanco.DropDownWidth = 350
    Me.cboBanco.FormattingEnabled = True
    Me.cboBanco.Location = New System.Drawing.Point(94, 100)
    Me.cboBanco.Name = "cboBanco"
    Me.cboBanco.Size = New System.Drawing.Size(173, 21)
    Me.cboBanco.TabIndex = 253
    '
    'txtCodDocumento
    '
    Me.txtCodDocumento.Location = New System.Drawing.Point(1, 100)
    Me.txtCodDocumento.Name = "txtCodDocumento"
    Me.txtCodDocumento.Size = New System.Drawing.Size(85, 20)
    Me.txtCodDocumento.TabIndex = 252
    '
    'opsqEmitente
    '
    Me.opsqEmitente.AdicionarPessoa = False
    Me.opsqEmitente.CarregarTodos = False
    Me.opsqEmitente.DS_Pessoa = ""
    Me.opsqEmitente.ID_Pessoa = 0
    Me.opsqEmitente.Location = New System.Drawing.Point(273, 42)
    Me.opsqEmitente.Name = "opsqEmitente"
    Me.opsqEmitente.Rotulo = "Emitente"
    Me.opsqEmitente.Size = New System.Drawing.Size(284, 36)
    Me.opsqEmitente.TabIndex = 251
    Me.opsqEmitente.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Pessoa
    '
    'txtDtDocumento
    '
    Me.txtDtDocumento.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDtDocumento.Location = New System.Drawing.Point(1, 58)
    Me.txtDtDocumento.Name = "txtDtDocumento"
    Me.txtDtDocumento.Size = New System.Drawing.Size(85, 21)
    Me.txtDtDocumento.TabIndex = 250
    Me.txtDtDocumento.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDescricaoDocumento
    '
    Me.txtDescricaoDocumento.Location = New System.Drawing.Point(93, 58)
    Me.txtDescricaoDocumento.Name = "txtDescricaoDocumento"
    Me.txtDescricaoDocumento.Size = New System.Drawing.Size(174, 20)
    Me.txtDescricaoDocumento.TabIndex = 249
    '
    'cboContaDebito_ContaCredito
    '
    Me.cboContaDebito_ContaCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboContaDebito_ContaCredito.DropDownWidth = 350
    Me.cboContaDebito_ContaCredito.FormattingEnabled = True
    Me.cboContaDebito_ContaCredito.Location = New System.Drawing.Point(389, 16)
    Me.cboContaDebito_ContaCredito.Name = "cboContaDebito_ContaCredito"
    Me.cboContaDebito_ContaCredito.Size = New System.Drawing.Size(168, 21)
    Me.cboContaDebito_ContaCredito.TabIndex = 248
    '
    'txtValorSaldo
    '
    Me.txtValorSaldo.CausesValidation = False
    Me.txtValorSaldo.Location = New System.Drawing.Point(273, 16)
    Me.txtValorSaldo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtValorSaldo.Name = "txtValorSaldo"
    Me.txtValorSaldo.ReadOnly = True
    Me.txtValorSaldo.Size = New System.Drawing.Size(110, 21)
    Me.txtValorSaldo.TabIndex = 247
    Me.txtValorSaldo.TabStop = False
    '
    'txtValorPago
    '
    Me.txtValorPago.CausesValidation = False
    Me.txtValorPago.Location = New System.Drawing.Point(157, 16)
    Me.txtValorPago.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtValorPago.Name = "txtValorPago"
    Me.txtValorPago.Size = New System.Drawing.Size(110, 21)
    Me.txtValorPago.TabIndex = 246
    Me.txtValorPago.TabStop = False
    '
    'cboFormaPagamento
    '
    Me.cboFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboFormaPagamento.DropDownWidth = 200
    Me.cboFormaPagamento.FormattingEnabled = True
    Me.cboFormaPagamento.Location = New System.Drawing.Point(1, 16)
    Me.cboFormaPagamento.Name = "cboFormaPagamento"
    Me.cboFormaPagamento.Size = New System.Drawing.Size(150, 21)
    Me.cboFormaPagamento.TabIndex = 245
    '
    'lblRDescricaoDocumento
    '
    Me.lblRDescricaoDocumento.AutoSize = True
    Me.lblRDescricaoDocumento.Location = New System.Drawing.Point(92, 43)
    Me.lblRDescricaoDocumento.Name = "lblRDescricaoDocumento"
    Me.lblRDescricaoDocumento.Size = New System.Drawing.Size(128, 13)
    Me.lblRDescricaoDocumento.TabIndex = 244
    Me.lblRDescricaoDocumento.Text = "Descrição do Documento"
    '
    'lblRNrContaDigito
    '
    Me.lblRNrContaDigito.AutoSize = True
    Me.lblRNrContaDigito.Location = New System.Drawing.Point(422, 85)
    Me.lblRNrContaDigito.Name = "lblRNrContaDigito"
    Me.lblRNrContaDigito.Size = New System.Drawing.Size(59, 13)
    Me.lblRNrContaDigito.TabIndex = 243
    Me.lblRNrContaDigito.Text = "Díg. Conta"
    '
    'lblRConta
    '
    Me.lblRConta.AutoSize = True
    Me.lblRConta.Location = New System.Drawing.Point(339, 85)
    Me.lblRConta.Name = "lblRConta"
    Me.lblRConta.Size = New System.Drawing.Size(50, 13)
    Me.lblRConta.TabIndex = 242
    Me.lblRConta.Text = "Nº Conta"
    '
    'lblRBanco
    '
    Me.lblRBanco.AutoSize = True
    Me.lblRBanco.Location = New System.Drawing.Point(94, 85)
    Me.lblRBanco.Name = "lblRBanco"
    Me.lblRBanco.Size = New System.Drawing.Size(38, 13)
    Me.lblRBanco.TabIndex = 241
    Me.lblRBanco.Text = "Banco"
    '
    'lblRAgencia
    '
    Me.lblRAgencia.AutoSize = True
    Me.lblRAgencia.Location = New System.Drawing.Point(273, 85)
    Me.lblRAgencia.Name = "lblRAgencia"
    Me.lblRAgencia.Size = New System.Drawing.Size(61, 13)
    Me.lblRAgencia.TabIndex = 240
    Me.lblRAgencia.Text = "Nº Agência"
    '
    'lblRDtDocumento
    '
    Me.lblRDtDocumento.AutoSize = True
    Me.lblRDtDocumento.Location = New System.Drawing.Point(1, 43)
    Me.lblRDtDocumento.Name = "lblRDtDocumento"
    Me.lblRDtDocumento.Size = New System.Drawing.Size(79, 13)
    Me.lblRDtDocumento.TabIndex = 239
    Me.lblRDtDocumento.Text = "Dt. Documento"
    '
    'lblRContaDebito_ContaCredito
    '
    Me.lblRContaDebito_ContaCredito.AutoSize = True
    Me.lblRContaDebito_ContaCredito.Location = New System.Drawing.Point(389, 1)
    Me.lblRContaDebito_ContaCredito.Name = "lblRContaDebito_ContaCredito"
    Me.lblRContaDebito_ContaCredito.Size = New System.Drawing.Size(168, 13)
    Me.lblRContaDebito_ContaCredito.TabIndex = 238
    Me.lblRContaDebito_ContaCredito.Text = "Conta de Débito/Conta de Crédito"
    '
    'lblRCodDocumento
    '
    Me.lblRCodDocumento.AutoSize = True
    Me.lblRCodDocumento.Location = New System.Drawing.Point(1, 85)
    Me.lblRCodDocumento.Name = "lblRCodDocumento"
    Me.lblRCodDocumento.Size = New System.Drawing.Size(87, 13)
    Me.lblRCodDocumento.TabIndex = 237
    Me.lblRCodDocumento.Text = "Cód. Documento"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(273, 1)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(76, 13)
    Me.Label3.TabIndex = 236
    Me.Label3.Text = "Valor de Saldo"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(157, 1)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(59, 13)
    Me.Label2.TabIndex = 235
    Me.Label2.Text = "Valor Pago"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(1, 1)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(108, 13)
    Me.Label1.TabIndex = 234
    Me.Label1.Text = "Forma de Pagamento"
    '
    'cboDocFinanc_CredPessoa_EncContas
    '
    Me.cboDocFinanc_CredPessoa_EncContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDocFinanc_CredPessoa_EncContas.DropDownWidth = 655
    Me.cboDocFinanc_CredPessoa_EncContas.FormattingEnabled = True
    Me.cboDocFinanc_CredPessoa_EncContas.Location = New System.Drawing.Point(94, 91)
    Me.cboDocFinanc_CredPessoa_EncContas.Name = "cboDocFinanc_CredPessoa_EncContas"
    Me.cboDocFinanc_CredPessoa_EncContas.Size = New System.Drawing.Size(358, 21)
    Me.cboDocFinanc_CredPessoa_EncContas.TabIndex = 258
    '
    'uscLancaContasReceberPagar_QuitarForm
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.pnlControles)
    Me.Controls.Add(Me.grdFormaPagamento)
    Me.Name = "uscLancaContasReceberPagar_QuitarForm"
    Me.Size = New System.Drawing.Size(785, 121)
    CType(Me.grdFormaPagamento, System.ComponentModel.ISupportInitialize).EndInit()
    Me.cmsGrid.ResumeLayout(False)
    Me.pnlControles.ResumeLayout(False)
    Me.pnlControles.PerformLayout()
    CType(Me.txtNrContaDigito, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNrConta, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNrAgencia, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDtDocumento, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtValorSaldo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtValorPago, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grdFormaPagamento As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents pnlControles As Panel
  Friend WithEvents cmdNovo As Button
  Friend WithEvents cmdRemover As Button
  Friend WithEvents cmdGravar As Button
  Friend WithEvents lblRDocFinanc_CredPessoa_EncContas As Label
  Friend WithEvents txtNrContaDigito As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtNrConta As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtNrAgencia As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents cboBanco As ComboBox
  Friend WithEvents txtCodDocumento As TextBox
  Friend WithEvents opsqEmitente As uscPesqPessoa
  Friend WithEvents txtDtDocumento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDescricaoDocumento As TextBox
  Friend WithEvents cboContaDebito_ContaCredito As ComboBox
  Friend WithEvents txtValorSaldo As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents txtValorPago As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents cboFormaPagamento As ComboBox
  Friend WithEvents lblRDescricaoDocumento As Label
  Friend WithEvents lblRNrContaDigito As Label
  Friend WithEvents lblRConta As Label
  Friend WithEvents lblRBanco As Label
  Friend WithEvents lblRAgencia As Label
  Friend WithEvents lblRDtDocumento As Label
  Friend WithEvents lblRContaDebito_ContaCredito As Label
  Friend WithEvents lblRCodDocumento As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents cboDocFinanc_CredPessoa_EncContas As ComboBox
  Friend WithEvents cmsGrid As ContextMenuStrip
  Friend WithEvents mnuGrid_ComprimirExpandir As ToolStripMenuItem
End Class
