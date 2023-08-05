<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVendasMaster
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
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtDataVendaFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataVendaInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblRDataAgendamento = New System.Windows.Forms.Label()
    Me.cboConvenio = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboProfissionalPrestadorServico = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboPlanoContasCredito = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cboPlanoContasDebito = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cboEspecialidade = New System.Windows.Forms.ComboBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.cboGrupoProcedimento = New System.Windows.Forms.ComboBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.cboUsuarioMarcacao = New System.Windows.Forms.ComboBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.cboCanalMarcacao = New System.Windows.Forms.ComboBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.cboCidade = New System.Windows.Forms.ComboBox()
    Me.lblValorTotalProcedimento = New System.Windows.Forms.Label()
    Me.lblValorTotalDesconto = New System.Windows.Forms.Label()
    Me.lblValorTotalLiquido = New System.Windows.Forms.Label()
    Me.lblValorTotalRepasse = New System.Windows.Forms.Label()
    Me.lblQuantidadeProcedimento = New System.Windows.Forms.Label()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtDataMarcacaoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataMarcacaoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label14 = New System.Windows.Forms.Label()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataVendaFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataVendaInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataMarcacaoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataMarcacaoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboEmpresa
    '
    Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEmpresa.FormattingEnabled = True
    Me.cboEmpresa.Location = New System.Drawing.Point(198, 20)
    Me.cboEmpresa.Name = "cboEmpresa"
    Me.cboEmpresa.Size = New System.Drawing.Size(350, 21)
    Me.cboEmpresa.TabIndex = 292
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(198, 5)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(48, 13)
    Me.Label7.TabIndex = 291
    Me.Label7.Text = "Empresa"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 173)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(103, 13)
    Me.Label4.TabIndex = 278
    Me.Label4.Text = "Listagem de Vendas"
    '
    'cmdExcel
    '
    Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
    Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcel.Location = New System.Drawing.Point(5, 455)
    Me.cmdExcel.Name = "cmdExcel"
    Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcel.TabIndex = 275
    Me.cmdExcel.Text = "Excel"
    Me.cmdExcel.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(885, 455)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 276
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
    Me.grdListagem.Size = New System.Drawing.Size(955, 260)
    Me.grdListagem.TabIndex = 271
    Me.grdListagem.Text = "UltraGrid1"
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
    Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLimpar.Location = New System.Drawing.Point(804, 139)
    Me.cmdLimpar.Name = "cmdLimpar"
    Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
    Me.cmdLimpar.TabIndex = 270
    Me.cmdLimpar.Text = "Limpar"
    Me.cmdLimpar.UseVisualStyleBackColor = True
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(885, 139)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 269
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(92, 24)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(13, 13)
    Me.Label2.TabIndex = 268
    Me.Label2.Text = "a"
    '
    'txtDataVendaFinal
    '
    Me.txtDataVendaFinal.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
    Me.txtDataVendaFinal.Location = New System.Drawing.Point(107, 20)
    Me.txtDataVendaFinal.MaskInput = "{date}"
    Me.txtDataVendaFinal.Name = "txtDataVendaFinal"
    Me.txtDataVendaFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataVendaFinal.TabIndex = 267
    Me.txtDataVendaFinal.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
    '
    'txtDataVendaInicial
    '
    Me.txtDataVendaInicial.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
    Me.txtDataVendaInicial.Location = New System.Drawing.Point(5, 20)
    Me.txtDataVendaInicial.MaskInput = "{date}"
    Me.txtDataVendaInicial.Name = "txtDataVendaInicial"
    Me.txtDataVendaInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataVendaInicial.TabIndex = 262
    Me.txtDataVendaInicial.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
    '
    'lblRDataAgendamento
    '
    Me.lblRDataAgendamento.AutoSize = True
    Me.lblRDataAgendamento.Location = New System.Drawing.Point(5, 5)
    Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
    Me.lblRDataAgendamento.Size = New System.Drawing.Size(79, 13)
    Me.lblRDataAgendamento.TabIndex = 263
    Me.lblRDataAgendamento.Text = "Data da Venda"
    '
    'cboConvenio
    '
    Me.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboConvenio.FormattingEnabled = True
    Me.cboConvenio.Location = New System.Drawing.Point(554, 21)
    Me.cboConvenio.Name = "cboConvenio"
    Me.cboConvenio.Size = New System.Drawing.Size(200, 21)
    Me.cboConvenio.TabIndex = 260
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(554, 6)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(52, 13)
    Me.Label1.TabIndex = 259
    Me.Label1.Text = "Convênio"
    '
    'cboProfissionalPrestadorServico
    '
    Me.cboProfissionalPrestadorServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissionalPrestadorServico.FormattingEnabled = True
    Me.cboProfissionalPrestadorServico.Location = New System.Drawing.Point(5, 146)
    Me.cboProfissionalPrestadorServico.Name = "cboProfissionalPrestadorServico"
    Me.cboProfissionalPrestadorServico.Size = New System.Drawing.Size(480, 21)
    Me.cboProfissionalPrestadorServico.TabIndex = 266
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(5, 131)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(146, 13)
    Me.Label3.TabIndex = 265
    Me.Label3.Text = "Médico/Prestador de Serviço"
    '
    'cboPlanoContasCredito
    '
    Me.cboPlanoContasCredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPlanoContasCredito.FormattingEnabled = True
    Me.cboPlanoContasCredito.Location = New System.Drawing.Point(5, 104)
    Me.cboPlanoContasCredito.Name = "cboPlanoContasCredito"
    Me.cboPlanoContasCredito.Size = New System.Drawing.Size(300, 21)
    Me.cboPlanoContasCredito.TabIndex = 293
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(5, 89)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(136, 13)
    Me.Label5.TabIndex = 294
    Me.Label5.Text = "Plano de Contas de Crédito"
    '
    'cboPlanoContasDebito
    '
    Me.cboPlanoContasDebito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPlanoContasDebito.FormattingEnabled = True
    Me.cboPlanoContasDebito.Location = New System.Drawing.Point(311, 104)
    Me.cboPlanoContasDebito.Name = "cboPlanoContasDebito"
    Me.cboPlanoContasDebito.Size = New System.Drawing.Size(300, 21)
    Me.cboPlanoContasDebito.TabIndex = 295
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(311, 89)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(134, 13)
    Me.Label6.TabIndex = 296
    Me.Label6.Text = "Plano de Contas de Débito"
    '
    'cboEspecialidade
    '
    Me.cboEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEspecialidade.FormattingEnabled = True
    Me.cboEspecialidade.Location = New System.Drawing.Point(760, 21)
    Me.cboEspecialidade.Name = "cboEspecialidade"
    Me.cboEspecialidade.Size = New System.Drawing.Size(200, 21)
    Me.cboEspecialidade.TabIndex = 298
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(760, 6)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(73, 13)
    Me.Label8.TabIndex = 297
    Me.Label8.Text = "Especialidade"
    '
    'cboGrupoProcedimento
    '
    Me.cboGrupoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrupoProcedimento.FormattingEnabled = True
    Me.cboGrupoProcedimento.Location = New System.Drawing.Point(198, 62)
    Me.cboGrupoProcedimento.Name = "cboGrupoProcedimento"
    Me.cboGrupoProcedimento.Size = New System.Drawing.Size(350, 21)
    Me.cboGrupoProcedimento.TabIndex = 300
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(198, 47)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(119, 13)
    Me.Label9.TabIndex = 299
    Me.Label9.Text = "Grupo de Procedimento"
    '
    'cboUsuarioMarcacao
    '
    Me.cboUsuarioMarcacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboUsuarioMarcacao.FormattingEnabled = True
    Me.cboUsuarioMarcacao.Location = New System.Drawing.Point(491, 146)
    Me.cboUsuarioMarcacao.Name = "cboUsuarioMarcacao"
    Me.cboUsuarioMarcacao.Size = New System.Drawing.Size(307, 21)
    Me.cboUsuarioMarcacao.TabIndex = 301
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(491, 131)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(56, 13)
    Me.Label10.TabIndex = 302
    Me.Label10.Text = "Atendente"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(617, 89)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(100, 13)
    Me.Label11.TabIndex = 304
    Me.Label11.Text = "Canal de Marcação"
    '
    'cboCanalMarcacao
    '
    Me.cboCanalMarcacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCanalMarcacao.FormattingEnabled = True
    Me.cboCanalMarcacao.Location = New System.Drawing.Point(617, 104)
    Me.cboCanalMarcacao.Name = "cboCanalMarcacao"
    Me.cboCanalMarcacao.Size = New System.Drawing.Size(190, 21)
    Me.cboCanalMarcacao.TabIndex = 303
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(813, 89)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(40, 13)
    Me.Label12.TabIndex = 306
    Me.Label12.Text = "Cidade"
    '
    'cboCidade
    '
    Me.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCidade.FormattingEnabled = True
    Me.cboCidade.Location = New System.Drawing.Point(813, 104)
    Me.cboCidade.Name = "cboCidade"
    Me.cboCidade.Size = New System.Drawing.Size(146, 21)
    Me.cboCidade.TabIndex = 305
    '
    'lblValorTotalProcedimento
    '
    Me.lblValorTotalProcedimento.AutoSize = True
    Me.lblValorTotalProcedimento.Location = New System.Drawing.Point(161, 455)
    Me.lblValorTotalProcedimento.Name = "lblValorTotalProcedimento"
    Me.lblValorTotalProcedimento.Size = New System.Drawing.Size(144, 13)
    Me.lblValorTotalProcedimento.TabIndex = 307
    Me.lblValorTotalProcedimento.Tag = "Valor Total de Procedimento:"
    Me.lblValorTotalProcedimento.Text = "Valor Total de Procedimento:"
    '
    'lblValorTotalDesconto
    '
    Me.lblValorTotalDesconto.AutoSize = True
    Me.lblValorTotalDesconto.Location = New System.Drawing.Point(410, 455)
    Me.lblValorTotalDesconto.Name = "lblValorTotalDesconto"
    Me.lblValorTotalDesconto.Size = New System.Drawing.Size(125, 13)
    Me.lblValorTotalDesconto.TabIndex = 308
    Me.lblValorTotalDesconto.Tag = "Valor Total de Desconto:"
    Me.lblValorTotalDesconto.Text = "Valor Total de Desconto:"
    '
    'lblValorTotalLiquido
    '
    Me.lblValorTotalLiquido.AutoSize = True
    Me.lblValorTotalLiquido.Location = New System.Drawing.Point(630, 455)
    Me.lblValorTotalLiquido.Name = "lblValorTotalLiquido"
    Me.lblValorTotalLiquido.Size = New System.Drawing.Size(115, 13)
    Me.lblValorTotalLiquido.TabIndex = 309
    Me.lblValorTotalLiquido.Tag = "Valor Total de Líquido:"
    Me.lblValorTotalLiquido.Text = "Valor Total de Líquido:"
    '
    'lblValorTotalRepasse
    '
    Me.lblValorTotalRepasse.AutoSize = True
    Me.lblValorTotalRepasse.Location = New System.Drawing.Point(630, 470)
    Me.lblValorTotalRepasse.Name = "lblValorTotalRepasse"
    Me.lblValorTotalRepasse.Size = New System.Drawing.Size(121, 13)
    Me.lblValorTotalRepasse.TabIndex = 310
    Me.lblValorTotalRepasse.Tag = "Valor Total de Repasse:"
    Me.lblValorTotalRepasse.Text = "Valor Total de Repasse:"
    '
    'lblQuantidadeProcedimento
    '
    Me.lblQuantidadeProcedimento.AutoSize = True
    Me.lblQuantidadeProcedimento.Location = New System.Drawing.Point(161, 470)
    Me.lblQuantidadeProcedimento.Name = "lblQuantidadeProcedimento"
    Me.lblQuantidadeProcedimento.Size = New System.Drawing.Size(148, 13)
    Me.lblQuantidadeProcedimento.TabIndex = 311
    Me.lblQuantidadeProcedimento.Tag = "Quantidade de Procedimento:"
    Me.lblQuantidadeProcedimento.Text = "Quantidade de Procedimento:"
    '
    'psqProcedimento
    '
    Me.psqProcedimento.Bordas = True
    Me.psqProcedimento.Convenio = 0
    Me.psqProcedimento.GrupoProcedimento = 0
    Me.psqProcedimento.Identificador = 0
    Me.psqProcedimento.LabelVisivel = True
    Me.psqProcedimento.Location = New System.Drawing.Point(554, 47)
    Me.psqProcedimento.Name = "psqProcedimento"
    Me.psqProcedimento.Profissional = 0
    Me.psqProcedimento.Size = New System.Drawing.Size(406, 36)
    Me.psqProcedimento.TabIndex = 264
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(92, 65)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(13, 13)
    Me.Label13.TabIndex = 315
    Me.Label13.Text = "a"
    '
    'txtDataMarcacaoFinal
    '
    Me.txtDataMarcacaoFinal.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
    Me.txtDataMarcacaoFinal.Location = New System.Drawing.Point(107, 61)
    Me.txtDataMarcacaoFinal.MaskInput = "{date}"
    Me.txtDataMarcacaoFinal.Name = "txtDataMarcacaoFinal"
    Me.txtDataMarcacaoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataMarcacaoFinal.TabIndex = 314
    Me.txtDataMarcacaoFinal.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
    '
    'txtDataMarcacaoInicial
    '
    Me.txtDataMarcacaoInicial.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
    Me.txtDataMarcacaoInicial.Location = New System.Drawing.Point(5, 61)
    Me.txtDataMarcacaoInicial.MaskInput = "{date}"
    Me.txtDataMarcacaoInicial.Name = "txtDataMarcacaoInicial"
    Me.txtDataMarcacaoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataMarcacaoInicial.TabIndex = 312
    Me.txtDataMarcacaoInicial.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(5, 46)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(96, 13)
    Me.Label14.TabIndex = 313
    Me.Label14.Text = "Data da Marcação"
    '
    'frmConsultaVendasMaster
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(968, 488)
    Me.Controls.Add(Me.Label13)
    Me.Controls.Add(Me.txtDataMarcacaoFinal)
    Me.Controls.Add(Me.txtDataMarcacaoInicial)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.lblQuantidadeProcedimento)
    Me.Controls.Add(Me.lblValorTotalRepasse)
    Me.Controls.Add(Me.lblValorTotalLiquido)
    Me.Controls.Add(Me.lblValorTotalDesconto)
    Me.Controls.Add(Me.lblValorTotalProcedimento)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.cboCidade)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.cboCanalMarcacao)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.cboUsuarioMarcacao)
    Me.Controls.Add(Me.cboGrupoProcedimento)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.cboEspecialidade)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cboPlanoContasDebito)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.cboPlanoContasCredito)
    Me.Controls.Add(Me.cboEmpresa)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cmdExcel)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtDataVendaFinal)
    Me.Controls.Add(Me.psqProcedimento)
    Me.Controls.Add(Me.txtDataVendaInicial)
    Me.Controls.Add(Me.lblRDataAgendamento)
    Me.Controls.Add(Me.cboConvenio)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cboProfissionalPrestadorServico)
    Me.Controls.Add(Me.Label3)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmConsultaVendasMaster"
    Me.Tag = "ob#P01AV"
    Me.Text = "Consula de Vendas - Master"
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataVendaFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataVendaInicial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataMarcacaoFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataMarcacaoInicial, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cboEmpresa As ComboBox
  Friend WithEvents Label7 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents cmdExcel As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents txtDataVendaFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents psqProcedimento As uscPesqProcedimento
  Friend WithEvents txtDataVendaInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents lblRDataAgendamento As Label
  Friend WithEvents cboConvenio As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents cboProfissionalPrestadorServico As ComboBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cboPlanoContasCredito As ComboBox
  Friend WithEvents Label5 As Label
  Friend WithEvents cboPlanoContasDebito As ComboBox
  Friend WithEvents Label6 As Label
  Friend WithEvents cboEspecialidade As ComboBox
  Friend WithEvents Label8 As Label
  Friend WithEvents cboGrupoProcedimento As ComboBox
  Friend WithEvents Label9 As Label
  Friend WithEvents cboUsuarioMarcacao As ComboBox
  Friend WithEvents Label10 As Label
  Friend WithEvents Label11 As Label
  Friend WithEvents cboCanalMarcacao As ComboBox
  Friend WithEvents Label12 As Label
  Friend WithEvents cboCidade As ComboBox
  Friend WithEvents lblValorTotalProcedimento As Label
  Friend WithEvents lblValorTotalDesconto As Label
  Friend WithEvents lblValorTotalLiquido As Label
  Friend WithEvents lblValorTotalRepasse As Label
  Friend WithEvents lblQuantidadeProcedimento As Label
  Friend WithEvents Label13 As Label
  Friend WithEvents txtDataMarcacaoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataMarcacaoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label14 As Label
End Class
