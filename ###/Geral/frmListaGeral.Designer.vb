<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaGeral
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
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRotuloListagem = New System.Windows.Forms.Label()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdAtualizar = New System.Windows.Forms.Button()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdExcluir = New System.Windows.Forms.Button()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 20)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(550, 80)
    Me.grdListagem.TabIndex = 0
    Me.grdListagem.Text = "UltraGrid1"
    '
    'lblRotuloListagem
    '
    Me.lblRotuloListagem.AutoSize = True
    Me.lblRotuloListagem.Location = New System.Drawing.Point(5, 5)
    Me.lblRotuloListagem.Name = "lblRotuloListagem"
    Me.lblRotuloListagem.Size = New System.Drawing.Size(90, 13)
    Me.lblRotuloListagem.TabIndex = 1
    Me.lblRotuloListagem.Text = "lblRotuloListagem"
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(134, 230)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 2
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'cmdAtualizar
    '
    Me.cmdAtualizar.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Atualizar
    Me.cmdAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdAtualizar.Location = New System.Drawing.Point(44, 274)
    Me.cmdAtualizar.Name = "cmdAtualizar"
    Me.cmdAtualizar.Size = New System.Drawing.Size(75, 28)
    Me.cmdAtualizar.TabIndex = 3
    Me.cmdAtualizar.Text = "    Atualizar"
    Me.cmdAtualizar.UseVisualStyleBackColor = True
    '
    'cmdExcel
    '
    Me.cmdExcel.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Excel
    Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcel.Location = New System.Drawing.Point(333, 178)
    Me.cmdExcel.Name = "cmdExcel"
    Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcel.TabIndex = 115
    Me.cmdExcel.Text = "Excel"
    Me.cmdExcel.UseVisualStyleBackColor = True
    '
    'cmdExcluir
    '
    Me.cmdExcluir.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Excluir2
    Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcluir.Location = New System.Drawing.Point(416, 235)
    Me.cmdExcluir.Name = "cmdExcluir"
    Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcluir.TabIndex = 140
    Me.cmdExcluir.Text = "Excluir"
    Me.cmdExcluir.UseVisualStyleBackColor = True
    '
    'cmdAlterar
    '
    Me.cmdAlterar.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Editar
    Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdAlterar.Location = New System.Drawing.Point(335, 235)
    Me.cmdAlterar.Name = "cmdAlterar"
    Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
    Me.cmdAlterar.TabIndex = 139
    Me.cmdAlterar.Text = "Alterar"
    Me.cmdAlterar.UseVisualStyleBackColor = True
    '
    'cmdNovo
    '
    Me.cmdNovo.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Novo
    Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdNovo.Location = New System.Drawing.Point(254, 235)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
    Me.cmdNovo.TabIndex = 138
    Me.cmdNovo.Text = "  Novo"
    Me.cmdNovo.UseVisualStyleBackColor = True
    '
    'frmListaGeral
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(740, 378)
    Me.Controls.Add(Me.cmdExcluir)
    Me.Controls.Add(Me.cmdAlterar)
    Me.Controls.Add(Me.cmdNovo)
    Me.Controls.Add(Me.cmdExcel)
    Me.Controls.Add(Me.cmdAtualizar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.lblRotuloListagem)
    Me.Controls.Add(Me.grdListagem)
    Me.Name = "frmListaGeral"
    Me.Text = "frmListaGeral"
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblRotuloListagem As System.Windows.Forms.Label
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cmdAtualizar As System.Windows.Forms.Button
  Friend WithEvents cmdExcel As System.Windows.Forms.Button
  Friend WithEvents cmdExcluir As System.Windows.Forms.Button
  Friend WithEvents cmdAlterar As System.Windows.Forms.Button
  Friend WithEvents cmdNovo As System.Windows.Forms.Button
End Class
