<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSEGPermissao
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
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.cboGrupoPermissaoUsuario = New System.Windows.Forms.ComboBox()
    Me.optComboBox_Usuario = New System.Windows.Forms.RadioButton()
    Me.optComboBox_GrupoPermissao = New System.Windows.Forms.RadioButton()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.GroupBox1.SuspendLayout()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.cboGrupoPermissaoUsuario)
    Me.GroupBox1.Controls.Add(Me.optComboBox_Usuario)
    Me.GroupBox1.Controls.Add(Me.optComboBox_GrupoPermissao)
    Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(820, 57)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Usuário"
    '
    'cboGrupoPermissaoUsuario
    '
    Me.cboGrupoPermissaoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrupoPermissaoUsuario.FormattingEnabled = True
    Me.cboGrupoPermissaoUsuario.Location = New System.Drawing.Point(127, 21)
    Me.cboGrupoPermissaoUsuario.Name = "cboGrupoPermissaoUsuario"
    Me.cboGrupoPermissaoUsuario.Size = New System.Drawing.Size(686, 21)
    Me.cboGrupoPermissaoUsuario.TabIndex = 3
    '
    'optComboBox_Usuario
    '
    Me.optComboBox_Usuario.AutoSize = True
    Me.optComboBox_Usuario.Location = New System.Drawing.Point(5, 35)
    Me.optComboBox_Usuario.Name = "optComboBox_Usuario"
    Me.optComboBox_Usuario.Size = New System.Drawing.Size(61, 17)
    Me.optComboBox_Usuario.TabIndex = 2
    Me.optComboBox_Usuario.TabStop = True
    Me.optComboBox_Usuario.Text = "Usuário"
    Me.optComboBox_Usuario.UseVisualStyleBackColor = True
    '
    'optComboBox_GrupoPermissao
    '
    Me.optComboBox_GrupoPermissao.AutoSize = True
    Me.optComboBox_GrupoPermissao.Location = New System.Drawing.Point(5, 16)
    Me.optComboBox_GrupoPermissao.Name = "optComboBox_GrupoPermissao"
    Me.optComboBox_GrupoPermissao.Size = New System.Drawing.Size(120, 17)
    Me.optComboBox_GrupoPermissao.TabIndex = 1
    Me.optComboBox_GrupoPermissao.TabStop = True
    Me.optComboBox_GrupoPermissao.Text = "Grupo de Permissão"
    Me.optComboBox_GrupoPermissao.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(750, 381)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 68)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(820, 303)
    Me.grdListagem.TabIndex = 143
    Me.grdListagem.Text = "UltraGrid1"
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(669, 381)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 100
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'frmSEGPermissao
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(830, 413)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.GroupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmSEGPermissao"
    Me.Text = "Cadastro de Permissão"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents optComboBox_Usuario As System.Windows.Forms.RadioButton
  Friend WithEvents optComboBox_GrupoPermissao As System.Windows.Forms.RadioButton
  Friend WithEvents cboGrupoPermissaoUsuario As System.Windows.Forms.ComboBox
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
End Class
