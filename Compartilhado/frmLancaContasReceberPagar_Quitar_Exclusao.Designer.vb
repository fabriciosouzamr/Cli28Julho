<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLancaContasReceberPagar_Quitar_Exclusao
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
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

  'Exigido pelo Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
  'Pode ser modificado usando o Windows Form Designer.  
  'Não o modifique usando o editor de códigos.
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cmdExcluir = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.grdFormaPagamento = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.grdPagamentos = New Infragistics.Win.UltraWinGrid.UltraGrid()
    CType(Me.grdFormaPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdPagamentos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(115, 13)
    Me.Label1.TabIndex = 102
    Me.Label1.Text = "Liatem de Pagamentos"
    '
    'cmdExcluir
    '
    Me.cmdExcluir.Image = My.Resources.Resources.Mini_Excluir2
    Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcluir.Location = New System.Drawing.Point(724, 426)
    Me.cmdExcluir.Name = "cmdExcluir"
    Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcluir.TabIndex = 100
    Me.cmdExcluir.Text = "  Excluir"
    Me.cmdExcluir.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(805, 426)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(5, 221)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(195, 13)
    Me.Label12.TabIndex = 88
    Me.Label12.Text = "Lançamento das Formas de Pagamento"
    '
    'grdFormaPagamento
    '
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
    Me.grdFormaPagamento.Location = New System.Drawing.Point(5, 236)
    Me.grdFormaPagamento.Name = "grdFormaPagamento"
    Me.grdFormaPagamento.Size = New System.Drawing.Size(875, 180)
    Me.grdFormaPagamento.TabIndex = 87
    Me.grdFormaPagamento.Text = "UltraGrid1"
    '
    'grdPagamentos
    '
    Appearance13.BackColor = System.Drawing.SystemColors.Window
    Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdPagamentos.DisplayLayout.Appearance = Appearance13
    Me.grdPagamentos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdPagamentos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance14.BorderColor = System.Drawing.SystemColors.Window
    Me.grdPagamentos.DisplayLayout.GroupByBox.Appearance = Appearance14
    Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdPagamentos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
    Me.grdPagamentos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance16.BackColor2 = System.Drawing.SystemColors.Control
    Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdPagamentos.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
    Me.grdPagamentos.DisplayLayout.MaxColScrollRegions = 1
    Me.grdPagamentos.DisplayLayout.MaxRowScrollRegions = 1
    Appearance17.BackColor = System.Drawing.SystemColors.Window
    Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdPagamentos.DisplayLayout.Override.ActiveCellAppearance = Appearance17
    Appearance18.BackColor = System.Drawing.SystemColors.Highlight
    Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdPagamentos.DisplayLayout.Override.ActiveRowAppearance = Appearance18
    Me.grdPagamentos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdPagamentos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance19.BackColor = System.Drawing.SystemColors.Window
    Me.grdPagamentos.DisplayLayout.Override.CardAreaAppearance = Appearance19
    Appearance20.BorderColor = System.Drawing.Color.Silver
    Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdPagamentos.DisplayLayout.Override.CellAppearance = Appearance20
    Me.grdPagamentos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.grdPagamentos.DisplayLayout.Override.CellPadding = 0
    Appearance21.BackColor = System.Drawing.SystemColors.Control
    Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance21.BorderColor = System.Drawing.SystemColors.Window
    Me.grdPagamentos.DisplayLayout.Override.GroupByRowAppearance = Appearance21
    Appearance22.TextHAlignAsString = "Left"
    Me.grdPagamentos.DisplayLayout.Override.HeaderAppearance = Appearance22
    Me.grdPagamentos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdPagamentos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance23.BackColor = System.Drawing.SystemColors.Window
    Appearance23.BorderColor = System.Drawing.Color.Silver
    Me.grdPagamentos.DisplayLayout.Override.RowAppearance = Appearance23
    Me.grdPagamentos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdPagamentos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
    Me.grdPagamentos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdPagamentos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdPagamentos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdPagamentos.Location = New System.Drawing.Point(5, 20)
    Me.grdPagamentos.Name = "grdPagamentos"
    Me.grdPagamentos.Size = New System.Drawing.Size(875, 195)
    Me.grdPagamentos.TabIndex = 103
    Me.grdPagamentos.Text = "UltraGrid1"
    '
    'frmLancaContasReceberPagar_Quitar_Exclusao
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(884, 458)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmdExcluir)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.grdFormaPagamento)
    Me.Controls.Add(Me.grdPagamentos)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmLancaContasReceberPagar_Quitar_Exclusao"
    Me.Text = "Contas Receber e Pagar - Quitar - Exclusão"
    CType(Me.grdFormaPagamento, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdPagamentos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As Label
  Friend WithEvents cmdExcluir As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents Label12 As Label
  Friend WithEvents grdFormaPagamento As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents grdPagamentos As Infragistics.Win.UltraWinGrid.UltraGrid
End Class
