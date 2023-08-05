<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVendaDevolucao
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
    Me.Label4 = New System.Windows.Forms.Label()
    Me.lblNomePaciente = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblDHVenda = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblCodigo = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.grdListagemADevolver = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.grdListagemDevolucao = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.lblValorDevolucao = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtJustificativaDevolucao = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.cboContaFinanceira = New System.Windows.Forms.ComboBox()
        Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.grdListagemADevolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagemDevolucao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Código"
        '
        'lblNomePaciente
        '
        Me.lblNomePaciente.AutoSize = True
        Me.lblNomePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomePaciente.Location = New System.Drawing.Point(223, 24)
        Me.lblNomePaciente.Name = "lblNomePaciente"
        Me.lblNomePaciente.Size = New System.Drawing.Size(114, 17)
        Me.lblNomePaciente.TabIndex = 5
        Me.lblNomePaciente.Text = "lblNomePaciente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome do Paciente"
        '
        'lblDHVenda
        '
        Me.lblDHVenda.AutoSize = True
        Me.lblDHVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDHVenda.Location = New System.Drawing.Point(77, 24)
        Me.lblDHVenda.Name = "lblDHVenda"
        Me.lblDHVenda.Size = New System.Drawing.Size(83, 17)
        Me.lblDHVenda.TabIndex = 8
        Me.lblDHVenda.Text = "lblDHVenda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Data da Venda"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(5, 24)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(66, 17)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.Text = "lblCodigo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(299, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Listagem de procedimentos/exames que podem ser devolvido"
        '
        'grdListagemADevolver
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdListagemADevolver.DisplayLayout.Appearance = Appearance1
        Me.grdListagemADevolver.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdListagemADevolver.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdListagemADevolver.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdListagemADevolver.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdListagemADevolver.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdListagemADevolver.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdListagemADevolver.DisplayLayout.MaxColScrollRegions = 1
        Me.grdListagemADevolver.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdListagemADevolver.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdListagemADevolver.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdListagemADevolver.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdListagemADevolver.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagemADevolver.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdListagemADevolver.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdListagemADevolver.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdListagemADevolver.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdListagemADevolver.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdListagemADevolver.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdListagemADevolver.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdListagemADevolver.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.grdListagemADevolver.DisplayLayout.Override.RowAppearance = Appearance11
        Me.grdListagemADevolver.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdListagemADevolver.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.grdListagemADevolver.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdListagemADevolver.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdListagemADevolver.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdListagemADevolver.Location = New System.Drawing.Point(5, 103)
        Me.grdListagemADevolver.Name = "grdListagemADevolver"
        Me.grdListagemADevolver.Size = New System.Drawing.Size(837, 191)
        Me.grdListagemADevolver.TabIndex = 277
        Me.grdListagemADevolver.Text = "UltraGrid1"
        '
        'grdListagemDevolucao
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdListagemDevolucao.DisplayLayout.Appearance = Appearance13
        Me.grdListagemDevolucao.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdListagemDevolucao.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.grdListagemDevolucao.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdListagemDevolucao.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.grdListagemDevolucao.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdListagemDevolucao.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.grdListagemDevolucao.DisplayLayout.MaxColScrollRegions = 1
        Me.grdListagemDevolucao.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdListagemDevolucao.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdListagemDevolucao.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.grdListagemDevolucao.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdListagemDevolucao.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.grdListagemDevolucao.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdListagemDevolucao.DisplayLayout.Override.CellAppearance = Appearance20
        Me.grdListagemDevolucao.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdListagemDevolucao.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.grdListagemDevolucao.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.grdListagemDevolucao.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.grdListagemDevolucao.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdListagemDevolucao.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.grdListagemDevolucao.DisplayLayout.Override.RowAppearance = Appearance23
        Me.grdListagemDevolucao.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdListagemDevolucao.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.grdListagemDevolucao.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdListagemDevolucao.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdListagemDevolucao.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdListagemDevolucao.Location = New System.Drawing.Point(5, 313)
        Me.grdListagemDevolucao.Name = "grdListagemDevolucao"
        Me.grdListagemDevolucao.Size = New System.Drawing.Size(837, 178)
        Me.grdListagemDevolucao.TabIndex = 278
        Me.grdListagemDevolucao.Text = "UltraGrid1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(319, 13)
        Me.Label3.TabIndex = 279
        Me.Label3.Text = "Listagem de procedimentos/exames selecionados para devolução"
        '
        'cmdGravar
        '
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(684, 501)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(77, 28)
        Me.cmdGravar.TabIndex = 280
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(767, 501)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 281
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(712, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 17)
        Me.Label6.TabIndex = 282
        Me.Label6.Text = "Valor de Devolução"
        '
        'lblValorDevolucao
        '
        Me.lblValorDevolucao.AutoSize = True
        Me.lblValorDevolucao.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorDevolucao.Location = New System.Drawing.Point(712, 24)
        Me.lblValorDevolucao.Name = "lblValorDevolucao"
        Me.lblValorDevolucao.Size = New System.Drawing.Size(122, 17)
        Me.lblValorDevolucao.TabIndex = 283
        Me.lblValorDevolucao.Text = "lblValorDevolucao"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 13)
        Me.Label7.TabIndex = 284
        Me.Label7.Text = "Justificativa para a devolução"
        '
        'txtJustificativaDevolucao
        '
        Me.txtJustificativaDevolucao.Location = New System.Drawing.Point(5, 62)
        Me.txtJustificativaDevolucao.MaxLength = 150
        Me.txtJustificativaDevolucao.Name = "txtJustificativaDevolucao"
        Me.txtJustificativaDevolucao.Size = New System.Drawing.Size(496, 20)
        Me.txtJustificativaDevolucao.TabIndex = 285
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(507, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(199, 17)
        Me.Label8.TabIndex = 286
        Me.Label8.Text = "Conta Caixa para a Devolução"
        '
        'cboContaFinanceira
        '
        Me.cboContaFinanceira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaFinanceira.FormattingEnabled = True
        Me.cboContaFinanceira.Location = New System.Drawing.Point(507, 24)
        Me.cboContaFinanceira.Name = "cboContaFinanceira"
        Me.cboContaFinanceira.Size = New System.Drawing.Size(199, 21)
        Me.cboContaFinanceira.TabIndex = 287
        '
        'cboTipoDocumento
        '
        Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumento.FormattingEnabled = True
        Me.cboTipoDocumento.Location = New System.Drawing.Point(507, 62)
        Me.cboTipoDocumento.Name = "cboTipoDocumento"
        Me.cboTipoDocumento.Size = New System.Drawing.Size(331, 21)
        Me.cboTipoDocumento.TabIndex = 289
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(507, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 17)
        Me.Label9.TabIndex = 288
        Me.Label9.Text = "Tipo de Documento"
        '
        'frmConsultaVendaDevolucao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 535)
        Me.Controls.Add(Me.cboContaFinanceira)
        Me.Controls.Add(Me.cboTipoDocumento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtJustificativaDevolucao)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblValorDevolucao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grdListagemDevolucao)
        Me.Controls.Add(Me.grdListagemADevolver)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDHVenda)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNomePaciente)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmConsultaVendaDevolucao"
        Me.Text = "Consulta de Vendas - Devolução"
        CType(Me.grdListagemADevolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagemDevolucao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
  Friend WithEvents lblNomePaciente As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents lblDHVenda As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents lblCodigo As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents grdListagemADevolver As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents grdListagemDevolucao As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label3 As Label
  Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents Label6 As Label
  Friend WithEvents lblValorDevolucao As Label
  Friend WithEvents Label7 As Label
  Friend WithEvents txtJustificativaDevolucao As TextBox
  Friend WithEvents Label8 As Label
  Friend WithEvents cboContaFinanceira As ComboBox
    Friend WithEvents cboTipoDocumento As ComboBox
    Friend WithEvents Label9 As Label
End Class
