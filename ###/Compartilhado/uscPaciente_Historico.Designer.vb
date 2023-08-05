<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscPaciente_Historico
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
    Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.grdHistoricoConsultas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.grdHistoricoFinanceiro = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cmdAtualizar = New System.Windows.Forms.Button()
        CType(Me.grdHistoricoConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdHistoricoFinanceiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdHistoricoConsultas
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdHistoricoConsultas.DisplayLayout.Appearance = Appearance1
        Me.grdHistoricoConsultas.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdHistoricoConsultas.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdHistoricoConsultas.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdHistoricoConsultas.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdHistoricoConsultas.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdHistoricoConsultas.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdHistoricoConsultas.DisplayLayout.MaxColScrollRegions = 1
        Me.grdHistoricoConsultas.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdHistoricoConsultas.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdHistoricoConsultas.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdHistoricoConsultas.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdHistoricoConsultas.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdHistoricoConsultas.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdHistoricoConsultas.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdHistoricoConsultas.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdHistoricoConsultas.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdHistoricoConsultas.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdHistoricoConsultas.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdHistoricoConsultas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdHistoricoConsultas.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.grdHistoricoConsultas.DisplayLayout.Override.RowAppearance = Appearance11
        Me.grdHistoricoConsultas.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdHistoricoConsultas.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.grdHistoricoConsultas.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdHistoricoConsultas.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdHistoricoConsultas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdHistoricoConsultas.Location = New System.Drawing.Point(5, 241)
        Me.grdHistoricoConsultas.Name = "grdHistoricoConsultas"
        Me.grdHistoricoConsultas.Size = New System.Drawing.Size(1106, 150)
        Me.grdHistoricoConsultas.TabIndex = 87
        Me.grdHistoricoConsultas.Text = "UltraGrid2"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(5, 226)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(117, 13)
        Me.Label49.TabIndex = 86
        Me.Label49.Text = "Históricos de Consultas"
        '
        'grdHistoricoFinanceiro
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdHistoricoFinanceiro.DisplayLayout.Appearance = Appearance13
        Me.grdHistoricoFinanceiro.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdHistoricoFinanceiro.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.grdHistoricoFinanceiro.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdHistoricoFinanceiro.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.grdHistoricoFinanceiro.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdHistoricoFinanceiro.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.grdHistoricoFinanceiro.DisplayLayout.MaxColScrollRegions = 1
        Me.grdHistoricoFinanceiro.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.CellAppearance = Appearance20
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.RowAppearance = Appearance23
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdHistoricoFinanceiro.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.grdHistoricoFinanceiro.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdHistoricoFinanceiro.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdHistoricoFinanceiro.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdHistoricoFinanceiro.Location = New System.Drawing.Point(5, 20)
        Me.grdHistoricoFinanceiro.Name = "grdHistoricoFinanceiro"
        Me.grdHistoricoFinanceiro.Size = New System.Drawing.Size(1106, 200)
        Me.grdHistoricoFinanceiro.TabIndex = 85
        Me.grdHistoricoFinanceiro.Text = "UltraGrid2"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(5, 5)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(115, 13)
        Me.Label42.TabIndex = 84
        Me.Label42.Text = "Histórico de Financeiro"
        '
        'cmdAtualizar
        '
        Me.cmdAtualizar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Atualizar
        Me.cmdAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAtualizar.Location = New System.Drawing.Point(1089, 0)
        Me.cmdAtualizar.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdAtualizar.Name = "cmdAtualizar"
        Me.cmdAtualizar.Size = New System.Drawing.Size(21, 21)
        Me.cmdAtualizar.TabIndex = 90
        Me.cmdAtualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAtualizar.UseVisualStyleBackColor = True
        '
        'uscPaciente_Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdAtualizar)
        Me.Controls.Add(Me.grdHistoricoConsultas)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.grdHistoricoFinanceiro)
        Me.Controls.Add(Me.Label42)
        Me.Name = "uscPaciente_Historico"
        Me.Size = New System.Drawing.Size(1116, 395)
        CType(Me.grdHistoricoConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdHistoricoFinanceiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdHistoricoConsultas As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label49 As Label
  Friend WithEvents grdHistoricoFinanceiro As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label42 As Label
    Friend WithEvents cmdAtualizar As Button
End Class
