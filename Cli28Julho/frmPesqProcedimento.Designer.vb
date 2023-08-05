<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesqProcedimento
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
    Me.cmdSelecionar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboAtivo = New System.Windows.Forms.ComboBox()
    Me.txtCodigos = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboTabelaProcedimento = New System.Windows.Forms.ComboBox()
    Me.txtNomeProcedimento = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboTipoProcedimento = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.lblRTipoExame = New System.Windows.Forms.Label()
    Me.cboTipoExame = New System.Windows.Forms.ComboBox()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdSelecionar
    '
    Me.cmdSelecionar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Selecionar
    Me.cmdSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdSelecionar.Location = New System.Drawing.Point(5, 322)
    Me.cmdSelecionar.Name = "cmdSelecionar"
    Me.cmdSelecionar.Size = New System.Drawing.Size(80, 28)
    Me.cmdSelecionar.TabIndex = 100
    Me.cmdSelecionar.Text = "     Selecionar"
    Me.cmdSelecionar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(716, 322)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(581, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(111, 13)
    Me.Label4.TabIndex = 85
    Me.Label4.Text = "Tipo de Procedimento"
    '
    'cboAtivo
    '
    Me.cboAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAtivo.FormattingEnabled = True
    Me.cboAtivo.Items.AddRange(New Object() {"Todos", "Sim", "Não"})
    Me.cboAtivo.Location = New System.Drawing.Point(616, 62)
    Me.cboAtivo.Name = "cboAtivo"
    Me.cboAtivo.Size = New System.Drawing.Size(76, 21)
    Me.cboAtivo.TabIndex = 2
    '
    'txtCodigos
    '
    Me.txtCodigos.Location = New System.Drawing.Point(465, 62)
    Me.txtCodigos.Name = "txtCodigos"
    Me.txtCodigos.Size = New System.Drawing.Size(145, 20)
    Me.txtCodigos.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(465, 47)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(45, 13)
    Me.Label2.TabIndex = 82
    Me.Label2.Text = "Codigos"
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 103)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(786, 213)
    Me.grdListagem.TabIndex = 81
    Me.grdListagem.Text = "UltraGrid1"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(5, 88)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(104, 13)
    Me.Label5.TabIndex = 80
    Me.Label5.Text = "Listagem de Produto"
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(716, 55)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 10
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(123, 13)
    Me.Label1.TabIndex = 78
    Me.Label1.Text = "Tabela de Procedimento"
    '
    'cboTabelaProcedimento
    '
    Me.cboTabelaProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTabelaProcedimento.FormattingEnabled = True
    Me.cboTabelaProcedimento.Location = New System.Drawing.Point(5, 61)
    Me.cboTabelaProcedimento.Name = "cboTabelaProcedimento"
    Me.cboTabelaProcedimento.Size = New System.Drawing.Size(454, 21)
    Me.cboTabelaProcedimento.TabIndex = 3
    '
    'txtNomeProcedimento
    '
    Me.txtNomeProcedimento.Location = New System.Drawing.Point(5, 20)
    Me.txtNomeProcedimento.Name = "txtNomeProcedimento"
    Me.txtNomeProcedimento.Size = New System.Drawing.Size(571, 20)
    Me.txtNomeProcedimento.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(5, 5)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(118, 13)
    Me.Label3.TabIndex = 75
    Me.Label3.Text = "Nome do Procedimento"
    '
    'cboTipoProcedimento
    '
    Me.cboTipoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoProcedimento.FormattingEnabled = True
    Me.cboTipoProcedimento.Location = New System.Drawing.Point(582, 20)
    Me.cboTipoProcedimento.Name = "cboTipoProcedimento"
    Me.cboTipoProcedimento.Size = New System.Drawing.Size(110, 21)
    Me.cboTipoProcedimento.TabIndex = 102
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(616, 47)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(42, 13)
    Me.Label6.TabIndex = 103
    Me.Label6.Text = "Ativos?"
    '
    'lblRTipoExame
    '
    Me.lblRTipoExame.AutoSize = True
    Me.lblRTipoExame.Location = New System.Drawing.Point(698, 5)
    Me.lblRTipoExame.Name = "lblRTipoExame"
    Me.lblRTipoExame.Size = New System.Drawing.Size(78, 13)
    Me.lblRTipoExame.TabIndex = 105
    Me.lblRTipoExame.Text = "Tipo de Exame"
    '
    'cboTipoExame
    '
    Me.cboTipoExame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoExame.FormattingEnabled = True
    Me.cboTipoExame.Items.AddRange(New Object() {"Todos", "Sim", "Não"})
    Me.cboTipoExame.Location = New System.Drawing.Point(698, 20)
    Me.cboTipoExame.Name = "cboTipoExame"
    Me.cboTipoExame.Size = New System.Drawing.Size(93, 21)
    Me.cboTipoExame.TabIndex = 104
    '
    'frmPesqProcedimento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(797, 355)
    Me.ControlBox = False
    Me.Controls.Add(Me.lblRTipoExame)
    Me.Controls.Add(Me.cboTipoExame)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cboTipoProcedimento)
    Me.Controls.Add(Me.cmdSelecionar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cboAtivo)
    Me.Controls.Add(Me.txtCodigos)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cboTabelaProcedimento)
    Me.Controls.Add(Me.txtNomeProcedimento)
    Me.Controls.Add(Me.Label3)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmPesqProcedimento"
    Me.Text = "Pesquisa de Procedimento"
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdSelecionar As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cboAtivo As System.Windows.Forms.ComboBox
  Friend WithEvents txtCodigos As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboTabelaProcedimento As System.Windows.Forms.ComboBox
  Friend WithEvents txtNomeProcedimento As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cboTipoProcedimento As ComboBox
  Friend WithEvents Label6 As Label
  Friend WithEvents lblRTipoExame As Label
  Friend WithEvents cboTipoExame As ComboBox
End Class
