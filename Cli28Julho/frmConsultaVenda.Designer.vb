<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVenda
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
    Me.txtDataVendaInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblRDataAgendamento = New System.Windows.Forms.Label()
    Me.cboConvenio = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboProfissionalPrestadorServico = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtDataVendaFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdPDF = New System.Windows.Forms.Button()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdCancelar = New System.Windows.Forms.Button()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboOrigemVenda = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtCodigoOrigemVenda = New System.Windows.Forms.TextBox()
    Me.lblRCodigoOrigemVenda = New System.Windows.Forms.Label()
    Me.lblQuantidade = New System.Windows.Forms.Label()
    Me.lblValorTotal = New System.Windows.Forms.Label()
    Me.chkListarVendasCanceladas = New System.Windows.Forms.CheckBox()
    Me.cmdExameExterno = New System.Windows.Forms.Button()
    Me.cmdExameInterno = New System.Windows.Forms.Button()
    Me.cmdGuiaConsultas = New System.Windows.Forms.Button()
    Me.cboContaCaixa = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    Me.psqIndicacao = New Cli28Julho.uscIndicacao()
    Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
    Me.chkImrimirExameExterno = New System.Windows.Forms.CheckBox()
    Me.chkImrimirExameInterno = New System.Windows.Forms.CheckBox()
    Me.chkImrimirGuiaConsultas = New System.Windows.Forms.CheckBox()
    Me.cmdDevolver = New System.Windows.Forms.Button()
        Me.txtCodigoVenda = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.txtDataVendaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataVendaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDataVendaInicial
        '
        Me.txtDataVendaInicial.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
        Me.txtDataVendaInicial.Location = New System.Drawing.Point(511, 20)
        Me.txtDataVendaInicial.MaskInput = "{date}"
        Me.txtDataVendaInicial.Name = "txtDataVendaInicial"
        Me.txtDataVendaInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataVendaInicial.TabIndex = 209
        Me.txtDataVendaInicial.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
        '
        'lblRDataAgendamento
        '
        Me.lblRDataAgendamento.AutoSize = True
        Me.lblRDataAgendamento.Location = New System.Drawing.Point(511, 5)
        Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
        Me.lblRDataAgendamento.Size = New System.Drawing.Size(79, 13)
        Me.lblRDataAgendamento.TabIndex = 210
        Me.lblRDataAgendamento.Text = "Data da Venda"
        '
        'cboConvenio
        '
        Me.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConvenio.FormattingEnabled = True
        Me.cboConvenio.Location = New System.Drawing.Point(5, 104)
        Me.cboConvenio.Name = "cboConvenio"
        Me.cboConvenio.Size = New System.Drawing.Size(250, 21)
        Me.cboConvenio.TabIndex = 207
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Convênio"
        '
        'cboProfissionalPrestadorServico
        '
        Me.cboProfissionalPrestadorServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissionalPrestadorServico.FormattingEnabled = True
        Me.cboProfissionalPrestadorServico.Location = New System.Drawing.Point(261, 104)
        Me.cboProfissionalPrestadorServico.Name = "cboProfissionalPrestadorServico"
        Me.cboProfissionalPrestadorServico.Size = New System.Drawing.Size(329, 21)
        Me.cboProfissionalPrestadorServico.TabIndex = 213
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "Médico/Prestador de Serviço"
        '
        'txtDataVendaFinal
        '
        Me.txtDataVendaFinal.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
        Me.txtDataVendaFinal.Location = New System.Drawing.Point(613, 20)
        Me.txtDataVendaFinal.MaskInput = "{date}"
        Me.txtDataVendaFinal.Name = "txtDataVendaFinal"
        Me.txtDataVendaFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataVendaFinal.TabIndex = 214
        Me.txtDataVendaFinal.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(598, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "a"
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(852, 97)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 235
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(933, 97)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 234
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdPDF
        '
        Me.cmdPDF.Image = Global.Cli28Julho.My.Resources.Resources.Mini_PDF
        Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPDF.Location = New System.Drawing.Point(329, 463)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 242
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(248, 463)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 240
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Cancelar
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(167, 463)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 239
        Me.cmdCancelar.Text = "      Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Editar
        Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAlterar.Location = New System.Drawing.Point(86, 463)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAlterar.TabIndex = 238
        Me.cmdAlterar.Text = "Alterar"
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'cmdNovo
        '
        Me.cmdNovo.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Novo
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(5, 463)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
        Me.cmdNovo.TabIndex = 237
        Me.cmdNovo.Text = "  Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(933, 463)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 241
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 189)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(1003, 260)
        Me.grdListagem.TabIndex = 236
        Me.grdListagem.Text = "UltraGrid1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Listagem de Vendas"
        '
        'cboOrigemVenda
        '
        Me.cboOrigemVenda.DropDownHeight = 300
        Me.cboOrigemVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrigemVenda.FormattingEnabled = True
        Me.cboOrigemVenda.IntegralHeight = False
        Me.cboOrigemVenda.Location = New System.Drawing.Point(704, 20)
        Me.cboOrigemVenda.Name = "cboOrigemVenda"
        Me.cboOrigemVenda.Size = New System.Drawing.Size(95, 21)
        Me.cboOrigemVenda.TabIndex = 245
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(704, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 244
        Me.Label5.Text = "Origem Vendas"
        '
        'txtCodigoOrigemVenda
        '
        Me.txtCodigoOrigemVenda.Location = New System.Drawing.Point(805, 21)
        Me.txtCodigoOrigemVenda.Name = "txtCodigoOrigemVenda"
        Me.txtCodigoOrigemVenda.Size = New System.Drawing.Size(104, 20)
        Me.txtCodigoOrigemVenda.TabIndex = 246
        '
        'lblRCodigoOrigemVenda
        '
        Me.lblRCodigoOrigemVenda.AutoSize = True
        Me.lblRCodigoOrigemVenda.Location = New System.Drawing.Point(805, 5)
        Me.lblRCodigoOrigemVenda.Name = "lblRCodigoOrigemVenda"
        Me.lblRCodigoOrigemVenda.Size = New System.Drawing.Size(104, 13)
        Me.lblRCodigoOrigemVenda.TabIndex = 247
        Me.lblRCodigoOrigemVenda.Text = "Cód. Origem Vendas"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(785, 463)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(68, 13)
        Me.lblQuantidade.TabIndex = 248
        Me.lblQuantidade.Tag = "Quantidade: "
        Me.lblQuantidade.Text = "Quantidade: "
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(785, 478)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(61, 13)
        Me.lblValorTotal.TabIndex = 249
        Me.lblValorTotal.Tag = "Valor Total:"
        Me.lblValorTotal.Text = "Valor Total:"
        '
        'chkListarVendasCanceladas
        '
        Me.chkListarVendasCanceladas.AutoSize = True
        Me.chkListarVendasCanceladas.Location = New System.Drawing.Point(852, 127)
        Me.chkListarVendasCanceladas.Name = "chkListarVendasCanceladas"
        Me.chkListarVendasCanceladas.Size = New System.Drawing.Size(149, 17)
        Me.chkListarVendasCanceladas.TabIndex = 250
        Me.chkListarVendasCanceladas.Text = "Listar Vendas Canceladas"
        Me.chkListarVendasCanceladas.UseVisualStyleBackColor = True
        '
        'cmdExameExterno
        '
        Me.cmdExameExterno.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdExameExterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExameExterno.Location = New System.Drawing.Point(703, 463)
        Me.cmdExameExterno.Name = "cmdExameExterno"
        Me.cmdExameExterno.Size = New System.Drawing.Size(75, 28)
        Me.cmdExameExterno.TabIndex = 253
        Me.cmdExameExterno.Text = "   E. Externo"
        Me.cmdExameExterno.UseVisualStyleBackColor = True
        '
        'cmdExameInterno
        '
        Me.cmdExameInterno.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdExameInterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExameInterno.Location = New System.Drawing.Point(605, 463)
        Me.cmdExameInterno.Name = "cmdExameInterno"
        Me.cmdExameInterno.Size = New System.Drawing.Size(75, 28)
        Me.cmdExameInterno.TabIndex = 252
        Me.cmdExameInterno.Text = "    E. Interno"
        Me.cmdExameInterno.UseVisualStyleBackColor = True
        '
        'cmdGuiaConsultas
        '
        Me.cmdGuiaConsultas.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
        Me.cmdGuiaConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuiaConsultas.Location = New System.Drawing.Point(509, 463)
        Me.cmdGuiaConsultas.Name = "cmdGuiaConsultas"
        Me.cmdGuiaConsultas.Size = New System.Drawing.Size(75, 28)
        Me.cmdGuiaConsultas.TabIndex = 251
        Me.cmdGuiaConsultas.Text = " Guia"
        Me.cmdGuiaConsultas.UseVisualStyleBackColor = True
        '
        'cboContaCaixa
        '
        Me.cboContaCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaCaixa.FormattingEnabled = True
        Me.cboContaCaixa.Location = New System.Drawing.Point(596, 104)
        Me.cboContaCaixa.Name = "cboContaCaixa"
        Me.cboContaCaixa.Size = New System.Drawing.Size(250, 21)
        Me.cboContaCaixa.TabIndex = 254
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(596, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 255
        Me.Label6.Text = "Conta Caixa"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(5, 146)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(585, 21)
        Me.cboEmpresa.TabIndex = 257
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 256
        Me.Label7.Text = "Empresa"
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = True
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.GrupoProcedimento = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = True
        Me.psqProcedimento.Location = New System.Drawing.Point(5, 47)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(610, 36)
        Me.psqProcedimento.TabIndex = 211
        '
        'psqIndicacao
        '
        Me.psqIndicacao.INDICACAO = 0
        Me.psqIndicacao.Location = New System.Drawing.Point(621, 47)
        Me.psqIndicacao.Name = "psqIndicacao"
        Me.psqIndicacao.Size = New System.Drawing.Size(387, 36)
        Me.psqIndicacao.TabIndex = 208
        '
        'psqPessoa
        '
        Me.psqPessoa.AdicionarPessoa = False
        Me.psqPessoa.Bordas = True
        Me.psqPessoa.CarregarTodos = False
        Me.psqPessoa.DS_Pessoa = ""
        Me.psqPessoa.ID_Pessoa = 0
        Me.psqPessoa.LabelVisivel = True
        Me.psqPessoa.Location = New System.Drawing.Point(5, 5)
        Me.psqPessoa.Name = "psqPessoa"
        Me.psqPessoa.PesquisarPessoa = True
        Me.psqPessoa.Rotulo = "Cliente"
        Me.psqPessoa.Size = New System.Drawing.Size(500, 36)
        Me.psqPessoa.SomenteLeitura = False
        Me.psqPessoa.TabIndex = 205
        Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Fisica
        '
        'chkImrimirExameExterno
        '
        Me.chkImrimirExameExterno.AutoSize = True
        Me.chkImrimirExameExterno.Checked = True
        Me.chkImrimirExameExterno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImrimirExameExterno.Location = New System.Drawing.Point(686, 463)
        Me.chkImrimirExameExterno.Name = "chkImrimirExameExterno"
        Me.chkImrimirExameExterno.Size = New System.Drawing.Size(15, 14)
        Me.chkImrimirExameExterno.TabIndex = 315
        Me.chkImrimirExameExterno.UseVisualStyleBackColor = True
        '
        'chkImrimirExameInterno
        '
        Me.chkImrimirExameInterno.AutoSize = True
        Me.chkImrimirExameInterno.Checked = True
        Me.chkImrimirExameInterno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImrimirExameInterno.Location = New System.Drawing.Point(590, 463)
        Me.chkImrimirExameInterno.Name = "chkImrimirExameInterno"
        Me.chkImrimirExameInterno.Size = New System.Drawing.Size(15, 14)
        Me.chkImrimirExameInterno.TabIndex = 314
        Me.chkImrimirExameInterno.UseVisualStyleBackColor = True
        '
        'chkImrimirGuiaConsultas
        '
        Me.chkImrimirGuiaConsultas.AutoSize = True
        Me.chkImrimirGuiaConsultas.Checked = True
        Me.chkImrimirGuiaConsultas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImrimirGuiaConsultas.Location = New System.Drawing.Point(494, 463)
        Me.chkImrimirGuiaConsultas.Name = "chkImrimirGuiaConsultas"
        Me.chkImrimirGuiaConsultas.Size = New System.Drawing.Size(15, 14)
        Me.chkImrimirGuiaConsultas.TabIndex = 313
        Me.chkImrimirGuiaConsultas.UseVisualStyleBackColor = True
        '
        'cmdDevolver
        '
        Me.cmdDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDevolver.Location = New System.Drawing.Point(410, 463)
        Me.cmdDevolver.Name = "cmdDevolver"
        Me.cmdDevolver.Size = New System.Drawing.Size(75, 28)
        Me.cmdDevolver.TabIndex = 316
        Me.cmdDevolver.Text = "     Devolver"
        Me.cmdDevolver.UseVisualStyleBackColor = True
        '
        'txtCodigoVenda
        '
        Me.txtCodigoVenda.Location = New System.Drawing.Point(915, 21)
        Me.txtCodigoVenda.Name = "txtCodigoVenda"
        Me.txtCodigoVenda.Size = New System.Drawing.Size(93, 20)
        Me.txtCodigoVenda.TabIndex = 317
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(915, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 318
        Me.Label8.Text = "Código da Vendas"
        '
        'frmConsultaVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 496)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCodigoVenda)
        Me.Controls.Add(Me.cmdDevolver)
        Me.Controls.Add(Me.chkImrimirExameExterno)
        Me.Controls.Add(Me.chkImrimirExameInterno)
        Me.Controls.Add(Me.chkImrimirGuiaConsultas)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboContaCaixa)
        Me.Controls.Add(Me.chkListarVendasCanceladas)
        Me.Controls.Add(Me.cmdExameExterno)
        Me.Controls.Add(Me.cmdExameInterno)
        Me.Controls.Add(Me.cmdGuiaConsultas)
        Me.Controls.Add(Me.lblValorTotal)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.lblRCodigoOrigemVenda)
        Me.Controls.Add(Me.txtCodigoOrigemVenda)
        Me.Controls.Add(Me.cboOrigemVenda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDataVendaFinal)
        Me.Controls.Add(Me.psqProcedimento)
        Me.Controls.Add(Me.txtDataVendaInicial)
        Me.Controls.Add(Me.lblRDataAgendamento)
        Me.Controls.Add(Me.psqIndicacao)
        Me.Controls.Add(Me.cboConvenio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.psqPessoa)
        Me.Controls.Add(Me.cboProfissionalPrestadorServico)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConsultaVenda"
        Me.Text = "Consulta de Venda"
        CType(Me.txtDataVendaInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataVendaFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents psqProcedimento As uscPesqProcedimento
  Friend WithEvents txtDataVendaInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents lblRDataAgendamento As Label
  Friend WithEvents psqIndicacao As uscIndicacao
  Friend WithEvents cboConvenio As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents psqPessoa As uscPesqPessoa
  Friend WithEvents cboProfissionalPrestadorServico As ComboBox
  Friend WithEvents Label3 As Label
  Friend WithEvents txtDataVendaFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label2 As Label
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents cmdPDF As Button
  Friend WithEvents cmdExcel As Button
  Friend WithEvents cmdCancelar As Button
  Friend WithEvents cmdAlterar As Button
  Friend WithEvents cmdNovo As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label4 As Label
  Friend WithEvents cboOrigemVenda As ComboBox
  Friend WithEvents Label5 As Label
  Friend WithEvents txtCodigoOrigemVenda As TextBox
  Friend WithEvents lblRCodigoOrigemVenda As Label
  Friend WithEvents lblQuantidade As Label
  Friend WithEvents lblValorTotal As Label
    Friend WithEvents chkListarVendasCanceladas As CheckBox
    Friend WithEvents cmdExameExterno As Button
    Friend WithEvents cmdExameInterno As Button
    Friend WithEvents cmdGuiaConsultas As Button
    Friend WithEvents cboContaCaixa As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents Label7 As Label
  Friend WithEvents chkImrimirExameExterno As CheckBox
  Friend WithEvents chkImrimirExameInterno As CheckBox
  Friend WithEvents chkImrimirGuiaConsultas As CheckBox
  Friend WithEvents cmdDevolver As Button
    Friend WithEvents txtCodigoVenda As TextBox
    Friend WithEvents Label8 As Label
End Class
