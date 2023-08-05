<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroVenda_Fechamento_Aprovacao
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroVenda_Fechamento_Aprovacao))
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
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmdBaixar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.grdTipoProduto = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboContaFinanceira = New System.Windows.Forms.ComboBox()
    Me.cmdAprovar = New System.Windows.Forms.Button()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTipoProduto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grdListagem.Size = New System.Drawing.Size(783, 229)
        Me.grdListagem.TabIndex = 257
        Me.grdListagem.Text = "UltraGrid1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 256
        Me.Label4.Text = "Listagem de Fechamentos"
        '
        'cmdBaixar
        '
        Me.cmdBaixar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Financeiro2
        Me.cmdBaixar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBaixar.Location = New System.Drawing.Point(632, 437)
        Me.cmdBaixar.Name = "cmdBaixar"
        Me.cmdBaixar.Size = New System.Drawing.Size(75, 28)
        Me.cmdBaixar.TabIndex = 254
        Me.cmdBaixar.Text = "  Baixar"
        Me.cmdBaixar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = CType(resources.GetObject("cmdFechar.Image"), System.Drawing.Image)
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(713, 437)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 255
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 258
        Me.Label1.Text = "Listagem por Tipo de Documento"
        '
        'grdTipoProduto
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdTipoProduto.DisplayLayout.Appearance = Appearance13
        Me.grdTipoProduto.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdTipoProduto.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.grdTipoProduto.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdTipoProduto.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.grdTipoProduto.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdTipoProduto.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.grdTipoProduto.DisplayLayout.MaxColScrollRegions = 1
        Me.grdTipoProduto.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTipoProduto.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdTipoProduto.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.grdTipoProduto.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdTipoProduto.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.grdTipoProduto.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdTipoProduto.DisplayLayout.Override.CellAppearance = Appearance20
        Me.grdTipoProduto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdTipoProduto.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.grdTipoProduto.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.grdTipoProduto.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.grdTipoProduto.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdTipoProduto.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.grdTipoProduto.DisplayLayout.Override.RowAppearance = Appearance23
        Me.grdTipoProduto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdTipoProduto.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.grdTipoProduto.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdTipoProduto.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdTipoProduto.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdTipoProduto.Location = New System.Drawing.Point(5, 271)
        Me.grdTipoProduto.Name = "grdTipoProduto"
        Me.grdTipoProduto.Size = New System.Drawing.Size(783, 114)
        Me.grdTipoProduto.TabIndex = 259
        Me.grdTipoProduto.Text = "UltraGrid1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 260
        Me.Label2.Text = "Conta Financeira"
        '
        'cboContaFinanceira
        '
        Me.cboContaFinanceira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaFinanceira.FormattingEnabled = True
        Me.cboContaFinanceira.Location = New System.Drawing.Point(5, 406)
        Me.cboContaFinanceira.Name = "cboContaFinanceira"
        Me.cboContaFinanceira.Size = New System.Drawing.Size(300, 21)
        Me.cboContaFinanceira.TabIndex = 261
        '
        'cmdAprovar
        '
        Me.cmdAprovar.Enabled = False
        Me.cmdAprovar.Image = CType(resources.GetObject("cmdAprovar.Image"), System.Drawing.Image)
        Me.cmdAprovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAprovar.Location = New System.Drawing.Point(345, 157)
        Me.cmdAprovar.Name = "cmdAprovar"
        Me.cmdAprovar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAprovar.TabIndex = 262
        Me.cmdAprovar.Text = "  Aprovar"
        Me.cmdAprovar.UseVisualStyleBackColor = True
        Me.cmdAprovar.Visible = False
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(470, 437)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
        Me.cmdImprimir.TabIndex = 268
        Me.cmdImprimir.Text = "    Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'frmCadastroVenda_Fechamento_Aprovacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 472)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cboContaFinanceira)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdTipoProduto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdBaixar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdAprovar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroVenda_Fechamento_Aprovacao"
        Me.Text = "Cadastro de Venda - Fechamento - Aprovação"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTipoProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label4 As Label
  Friend WithEvents cmdBaixar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents grdTipoProduto As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label2 As Label
  Friend WithEvents cboContaFinanceira As ComboBox
  Friend WithEvents cmdAprovar As Button
    Friend WithEvents cmdImprimir As Button
End Class
