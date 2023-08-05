<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPessoa
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
    Me.txtNomePessoa = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboTipoPessoa = New System.Windows.Forms.ComboBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.chkTransportadora = New System.Windows.Forms.CheckBox()
    Me.chkCliente = New System.Windows.Forms.CheckBox()
    Me.chkFuncionario = New System.Windows.Forms.CheckBox()
    Me.chkVendedor = New System.Windows.Forms.CheckBox()
    Me.chkProfissional = New System.Windows.Forms.CheckBox()
    Me.chkFornecedor = New System.Windows.Forms.CheckBox()
    Me.chkFabricante = New System.Windows.Forms.CheckBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtDocumento = New System.Windows.Forms.TextBox()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.cboAtivo = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboMesAniversario = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.chkPaciente = New System.Windows.Forms.CheckBox()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdExcluir = New System.Windows.Forms.Button()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.txtDiaAniversario = New System.Windows.Forms.NumericUpDown()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdPDF = New System.Windows.Forms.Button()
    Me.chkProfissional_PrestaServicosInterno = New System.Windows.Forms.CheckBox()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDiaAniversario, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNomePessoa
    '
    Me.txtNomePessoa.Location = New System.Drawing.Point(5, 20)
    Me.txtNomePessoa.MaxLength = 100
    Me.txtNomePessoa.Name = "txtNomePessoa"
    Me.txtNomePessoa.Size = New System.Drawing.Size(560, 20)
    Me.txtNomePessoa.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(88, 13)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Nome da Pessoa"
    '
    'cboTipoPessoa
    '
    Me.cboTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoPessoa.FormattingEnabled = True
    Me.cboTipoPessoa.Location = New System.Drawing.Point(571, 20)
    Me.cboTipoPessoa.Name = "cboTipoPessoa"
    Me.cboTipoPessoa.Size = New System.Drawing.Size(120, 21)
    Me.cboTipoPessoa.TabIndex = 2
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(571, 5)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(81, 13)
    Me.Label16.TabIndex = 21
    Me.Label16.Text = "Tipo de Pessoa"
    '
    'chkTransportadora
    '
    Me.chkTransportadora.AutoSize = True
    Me.chkTransportadora.Location = New System.Drawing.Point(391, 64)
    Me.chkTransportadora.Name = "chkTransportadora"
    Me.chkTransportadora.Size = New System.Drawing.Size(98, 17)
    Me.chkTransportadora.TabIndex = 12
    Me.chkTransportadora.Text = "Transportadora"
    Me.chkTransportadora.UseVisualStyleBackColor = True
    '
    'chkCliente
    '
    Me.chkCliente.AutoSize = True
    Me.chkCliente.Location = New System.Drawing.Point(163, 46)
    Me.chkCliente.Name = "chkCliente"
    Me.chkCliente.Size = New System.Drawing.Size(58, 17)
    Me.chkCliente.TabIndex = 5
    Me.chkCliente.Text = "Cliente"
    Me.chkCliente.UseVisualStyleBackColor = True
    '
    'chkFuncionario
    '
    Me.chkFuncionario.AutoSize = True
    Me.chkFuncionario.Location = New System.Drawing.Point(246, 46)
    Me.chkFuncionario.Name = "chkFuncionario"
    Me.chkFuncionario.Size = New System.Drawing.Size(81, 17)
    Me.chkFuncionario.TabIndex = 8
    Me.chkFuncionario.Text = "Funcionário"
    Me.chkFuncionario.UseVisualStyleBackColor = True
    '
    'chkVendedor
    '
    Me.chkVendedor.AutoSize = True
    Me.chkVendedor.Location = New System.Drawing.Point(697, 61)
    Me.chkVendedor.Name = "chkVendedor"
    Me.chkVendedor.Size = New System.Drawing.Size(72, 17)
    Me.chkVendedor.TabIndex = 11
    Me.chkVendedor.Text = "Vendedor"
    Me.chkVendedor.UseVisualStyleBackColor = True
    Me.chkVendedor.Visible = False
    '
    'chkProfissional
    '
    Me.chkProfissional.AutoSize = True
    Me.chkProfissional.Location = New System.Drawing.Point(163, 64)
    Me.chkProfissional.Name = "chkProfissional"
    Me.chkProfissional.Size = New System.Drawing.Size(79, 17)
    Me.chkProfissional.TabIndex = 9
    Me.chkProfissional.Text = "Profissional"
    Me.chkProfissional.UseVisualStyleBackColor = True
    '
    'chkFornecedor
    '
    Me.chkFornecedor.AutoSize = True
    Me.chkFornecedor.Location = New System.Drawing.Point(697, 42)
    Me.chkFornecedor.Name = "chkFornecedor"
    Me.chkFornecedor.Size = New System.Drawing.Size(80, 17)
    Me.chkFornecedor.TabIndex = 7
    Me.chkFornecedor.Text = "Fornecedor"
    Me.chkFornecedor.UseVisualStyleBackColor = True
    Me.chkFornecedor.Visible = False
    '
    'chkFabricante
    '
    Me.chkFabricante.AutoSize = True
    Me.chkFabricante.Location = New System.Drawing.Point(697, 79)
    Me.chkFabricante.Name = "chkFabricante"
    Me.chkFabricante.Size = New System.Drawing.Size(76, 17)
    Me.chkFabricante.TabIndex = 6
    Me.chkFabricante.Text = "Fabricante"
    Me.chkFabricante.UseVisualStyleBackColor = True
    Me.chkFabricante.Visible = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 46)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(62, 13)
    Me.Label2.TabIndex = 41
    Me.Label2.Text = "Documento"
    '
    'txtDocumento
    '
    Me.txtDocumento.Location = New System.Drawing.Point(5, 61)
    Me.txtDocumento.Name = "txtDocumento"
    Me.txtDocumento.Size = New System.Drawing.Size(150, 20)
    Me.txtDocumento.TabIndex = 4
    '
    'lblRListagemPessoa
    '
    Me.lblRListagemPessoa.AutoSize = True
    Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 87)
    Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
    Me.lblRListagemPessoa.Size = New System.Drawing.Size(102, 13)
    Me.lblRListagemPessoa.TabIndex = 43
    Me.lblRListagemPessoa.Tag = "Listagem de Pessoa"
    Me.lblRListagemPessoa.Text = "Listagem de Pessoa"
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 102)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(883, 303)
    Me.grdListagem.TabIndex = 44
    Me.grdListagem.Text = "UltraGrid1"
    '
    'cboAtivo
    '
    Me.cboAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAtivo.FormattingEnabled = True
    Me.cboAtivo.Location = New System.Drawing.Point(697, 20)
    Me.cboAtivo.Name = "cboAtivo"
    Me.cboAtivo.Size = New System.Drawing.Size(108, 21)
    Me.cboAtivo.TabIndex = 3
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(697, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(42, 13)
    Me.Label4.TabIndex = 51
    Me.Label4.Text = "Ativos?"
    '
    'cboMesAniversario
    '
    Me.cboMesAniversario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboMesAniversario.FormattingEnabled = True
    Me.cboMesAniversario.Location = New System.Drawing.Point(608, 61)
    Me.cboMesAniversario.Name = "cboMesAniversario"
    Me.cboMesAniversario.Size = New System.Drawing.Size(83, 21)
    Me.cboMesAniversario.TabIndex = 14
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(571, 46)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(118, 13)
    Me.Label3.TabIndex = 117
    Me.Label3.Text = "Dia/Mês de Aniversário"
    '
    'chkPaciente
    '
    Me.chkPaciente.AutoSize = True
    Me.chkPaciente.Location = New System.Drawing.Point(391, 46)
    Me.chkPaciente.Name = "chkPaciente"
    Me.chkPaciente.Size = New System.Drawing.Size(68, 17)
    Me.chkPaciente.TabIndex = 10
    Me.chkPaciente.Text = "Paciente"
    Me.chkPaciente.UseVisualStyleBackColor = True
    '
    'cmdExcel
    '
    Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
    Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcel.Location = New System.Drawing.Point(248, 411)
    Me.cmdExcel.Name = "cmdExcel"
    Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcel.TabIndex = 103
    Me.cmdExcel.Text = "Excel"
    Me.cmdExcel.UseVisualStyleBackColor = True
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(813, 53)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 30
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'cmdExcluir
    '
    Me.cmdExcluir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excluir2
    Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcluir.Location = New System.Drawing.Point(167, 411)
    Me.cmdExcluir.Name = "cmdExcluir"
    Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcluir.TabIndex = 102
    Me.cmdExcluir.Text = "Excluir"
    Me.cmdExcluir.UseVisualStyleBackColor = True
    '
    'cmdAlterar
    '
    Me.cmdAlterar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Editar
    Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdAlterar.Location = New System.Drawing.Point(86, 411)
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
    Me.cmdNovo.Location = New System.Drawing.Point(5, 411)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
    Me.cmdNovo.TabIndex = 100
    Me.cmdNovo.Text = "  Novo"
    Me.cmdNovo.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(813, 411)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 104
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'txtDiaAniversario
    '
    Me.txtDiaAniversario.Location = New System.Drawing.Point(571, 61)
    Me.txtDiaAniversario.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
    Me.txtDiaAniversario.Name = "txtDiaAniversario"
    Me.txtDiaAniversario.Size = New System.Drawing.Size(35, 20)
    Me.txtDiaAniversario.TabIndex = 13
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
    Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLimpar.Location = New System.Drawing.Point(813, 20)
    Me.cmdLimpar.Name = "cmdLimpar"
    Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
    Me.cmdLimpar.TabIndex = 234
    Me.cmdLimpar.Text = "Limpar"
    Me.cmdLimpar.UseVisualStyleBackColor = True
    '
    'cmdPDF
    '
    Me.cmdPDF.Image = Global.Cli28Julho.My.Resources.Resources.Mini_PDF
    Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPDF.Location = New System.Drawing.Point(329, 411)
    Me.cmdPDF.Name = "cmdPDF"
    Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
    Me.cmdPDF.TabIndex = 235
    Me.cmdPDF.Text = "     P.D.F."
    Me.cmdPDF.UseVisualStyleBackColor = True
    '
    'chkProfissional_PrestaServicosInterno
    '
    Me.chkProfissional_PrestaServicosInterno.AutoSize = True
    Me.chkProfissional_PrestaServicosInterno.Location = New System.Drawing.Point(246, 64)
    Me.chkProfissional_PrestaServicosInterno.Name = "chkProfissional_PrestaServicosInterno"
    Me.chkProfissional_PrestaServicosInterno.Size = New System.Drawing.Size(141, 17)
    Me.chkProfissional_PrestaServicosInterno.TabIndex = 904
    Me.chkProfissional_PrestaServicosInterno.Text = "Presta Serviços Internos"
    Me.chkProfissional_PrestaServicosInterno.UseVisualStyleBackColor = True
    '
    'frmConsultaPessoa
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(895, 445)
    Me.Controls.Add(Me.chkProfissional_PrestaServicosInterno)
    Me.Controls.Add(Me.cmdPDF)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.txtDiaAniversario)
    Me.Controls.Add(Me.cboMesAniversario)
    Me.Controls.Add(Me.cmdExcel)
    Me.Controls.Add(Me.cboAtivo)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.cmdExcluir)
    Me.Controls.Add(Me.cmdAlterar)
    Me.Controls.Add(Me.cmdNovo)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.txtDocumento)
    Me.Controls.Add(Me.chkCliente)
    Me.Controls.Add(Me.chkFuncionario)
    Me.Controls.Add(Me.chkFornecedor)
    Me.Controls.Add(Me.chkFabricante)
    Me.Controls.Add(Me.cboTipoPessoa)
    Me.Controls.Add(Me.txtNomePessoa)
    Me.Controls.Add(Me.chkPaciente)
    Me.Controls.Add(Me.chkTransportadora)
    Me.Controls.Add(Me.chkVendedor)
    Me.Controls.Add(Me.chkProfissional)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.lblRListagemPessoa)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label16)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.KeyPreview = True
    Me.Name = "frmConsultaPessoa"
    Me.Text = "Consulta de Pessoa"
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDiaAniversario, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtNomePessoa As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboTipoPessoa As System.Windows.Forms.ComboBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents chkTransportadora As System.Windows.Forms.CheckBox
  Friend WithEvents chkCliente As System.Windows.Forms.CheckBox
  Friend WithEvents chkFuncionario As System.Windows.Forms.CheckBox
  Friend WithEvents chkVendedor As System.Windows.Forms.CheckBox
  Friend WithEvents chkProfissional As System.Windows.Forms.CheckBox
  Friend WithEvents chkFornecedor As System.Windows.Forms.CheckBox
  Friend WithEvents chkFabricante As System.Windows.Forms.CheckBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
  Friend WithEvents lblRListagemPessoa As System.Windows.Forms.Label
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cmdNovo As System.Windows.Forms.Button
  Friend WithEvents cmdAlterar As System.Windows.Forms.Button
  Friend WithEvents cmdExcluir As System.Windows.Forms.Button
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents cboAtivo As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cmdExcel As System.Windows.Forms.Button
  Friend WithEvents cboMesAniversario As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents chkPaciente As System.Windows.Forms.CheckBox
  Friend WithEvents txtDiaAniversario As System.Windows.Forms.NumericUpDown
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdPDF As Button
  Friend WithEvents chkProfissional_PrestaServicosInterno As CheckBox
End Class
