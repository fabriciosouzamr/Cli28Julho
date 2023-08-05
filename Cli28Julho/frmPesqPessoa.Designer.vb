<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpsqPessoa
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
    Me.lblRPessoa = New System.Windows.Forms.Label()
    Me.txtPessoa = New System.Windows.Forms.TextBox()
    Me.lblMae = New System.Windows.Forms.Label()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblDocumentos = New System.Windows.Forms.Label()
    Me.txtDocumentos = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboAtivo = New System.Windows.Forms.ComboBox()
    Me.cmdSelecionar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdNovoCadastro = New System.Windows.Forms.Button()
    Me.txtMae = New System.Windows.Forms.TextBox()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    Me.txtNrProtuario = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRPessoa
        '
        Me.lblRPessoa.AutoSize = True
        Me.lblRPessoa.Location = New System.Drawing.Point(7, 6)
        Me.lblRPessoa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRPessoa.Name = "lblRPessoa"
        Me.lblRPessoa.Size = New System.Drawing.Size(78, 16)
        Me.lblRPessoa.TabIndex = 0
        Me.lblRPessoa.Text = "lblRPessoa"
        '
        'txtPessoa
        '
        Me.txtPessoa.Location = New System.Drawing.Point(7, 25)
        Me.txtPessoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPessoa.Name = "txtPessoa"
        Me.txtPessoa.Size = New System.Drawing.Size(399, 22)
        Me.txtPessoa.TabIndex = 1
        '
        'lblMae
        '
        Me.lblMae.AutoSize = True
        Me.lblMae.Location = New System.Drawing.Point(415, 6)
        Me.lblMae.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMae.Name = "lblMae"
        Me.lblMae.Size = New System.Drawing.Size(34, 16)
        Me.lblMae.TabIndex = 3
        Me.lblMae.Text = "Mãe"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(7, 57)
        Me.lblRListagemPessoa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(133, 16)
        Me.lblRListagemPessoa.TabIndex = 51
        Me.lblRListagemPessoa.Text = "lblRListagemPessoa"
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
        Me.grdListagem.Location = New System.Drawing.Point(7, 75)
        Me.grdListagem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(1153, 341)
        Me.grdListagem.TabIndex = 52
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblDocumentos
        '
        Me.lblDocumentos.AutoSize = True
        Me.lblDocumentos.Location = New System.Drawing.Point(623, 6)
        Me.lblDocumentos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDocumentos.Name = "lblDocumentos"
        Me.lblDocumentos.Size = New System.Drawing.Size(83, 16)
        Me.lblDocumentos.TabIndex = 53
        Me.lblDocumentos.Text = "Documentos"
        '
        'txtDocumentos
        '
        Me.txtDocumentos.Location = New System.Drawing.Point(623, 25)
        Me.txtDocumentos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDocumentos.Name = "txtDocumentos"
        Me.txtDocumentos.Size = New System.Drawing.Size(145, 22)
        Me.txtDocumentos.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(951, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Ativos?"
        '
        'cboAtivo
        '
        Me.cboAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAtivo.FormattingEnabled = True
        Me.cboAtivo.Items.AddRange(New Object() {"Todos", "Sim", "Não"})
        Me.cboAtivo.Location = New System.Drawing.Point(951, 25)
        Me.cboAtivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Size = New System.Drawing.Size(100, 24)
        Me.cboAtivo.TabIndex = 4
        '
        'cmdSelecionar
        '
        Me.cmdSelecionar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Selecionar
        Me.cmdSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSelecionar.Location = New System.Drawing.Point(7, 423)
        Me.cmdSelecionar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSelecionar.Name = "cmdSelecionar"
        Me.cmdSelecionar.Size = New System.Drawing.Size(107, 34)
        Me.cmdSelecionar.TabIndex = 100
        Me.cmdSelecionar.Text = "     Selecionar"
        Me.cmdSelecionar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(1060, 423)
        Me.cmdFechar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(100, 34)
        Me.cmdFechar.TabIndex = 101
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(1060, 16)
        Me.cmdPesquisar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(100, 34)
        Me.cmdPesquisar.TabIndex = 5
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdNovoCadastro
        '
        Me.cmdNovoCadastro.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Novo
        Me.cmdNovoCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovoCadastro.Location = New System.Drawing.Point(121, 423)
        Me.cmdNovoCadastro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdNovoCadastro.Name = "cmdNovoCadastro"
        Me.cmdNovoCadastro.Size = New System.Drawing.Size(149, 34)
        Me.cmdNovoCadastro.TabIndex = 102
        Me.cmdNovoCadastro.Text = "     Novo Cadastro"
        Me.cmdNovoCadastro.UseVisualStyleBackColor = True
        '
        'txtMae
        '
        Me.txtMae.Location = New System.Drawing.Point(415, 25)
        Me.txtMae.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMae.Name = "txtMae"
        Me.txtMae.Size = New System.Drawing.Size(199, 22)
        Me.txtMae.TabIndex = 103
        '
        'cmdAlterar
        '
        Me.cmdAlterar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Editar
        Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAlterar.Location = New System.Drawing.Point(279, 423)
        Me.cmdAlterar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(100, 34)
        Me.cmdAlterar.TabIndex = 104
        Me.cmdAlterar.Text = "Alterar"
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'txtNrProtuario
        '
        Me.txtNrProtuario.Location = New System.Drawing.Point(777, 25)
        Me.txtNrProtuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNrProtuario.Name = "txtNrProtuario"
        Me.txtNrProtuario.Size = New System.Drawing.Size(145, 22)
        Me.txtNrProtuario.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(777, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Protunário"
        '
        'frmpsqPessoa
        '
        Me.AcceptButton = Me.cmdSelecionar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdFechar
        Me.ClientSize = New System.Drawing.Size(1167, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtNrProtuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.txtMae)
        Me.Controls.Add(Me.cmdNovoCadastro)
        Me.Controls.Add(Me.cmdSelecionar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboAtivo)
        Me.Controls.Add(Me.txtDocumentos)
        Me.Controls.Add(Me.lblDocumentos)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.lblMae)
        Me.Controls.Add(Me.txtPessoa)
        Me.Controls.Add(Me.lblRPessoa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmpsqPessoa"
        Me.Text = "Pesquisa de Pessoa"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRPessoa As System.Windows.Forms.Label
    Friend WithEvents txtPessoa As System.Windows.Forms.TextBox
  Friend WithEvents lblMae As System.Windows.Forms.Label
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents lblRListagemPessoa As System.Windows.Forms.Label
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblDocumentos As System.Windows.Forms.Label
  Friend WithEvents txtDocumentos As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cboAtivo As System.Windows.Forms.ComboBox
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cmdSelecionar As System.Windows.Forms.Button
  Friend WithEvents cmdNovoCadastro As Button
  Friend WithEvents txtMae As TextBox
  Friend WithEvents cmdAlterar As Button
  Friend WithEvents txtNrProtuario As TextBox
  Friend WithEvents Label3 As Label
End Class
