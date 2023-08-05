<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancaContasReceberPagar_Venda
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
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.grdParcela = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmdAdicionarProduto = New System.Windows.Forms.Button()
    Me.txtValorMovimentacao = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtQtdeParcela = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboCondicaoPagamento = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboFormaPagamento = New System.Windows.Forms.ComboBox()
    Me.txtValorTotalLancamento = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtValorTotalAdicionado = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdGravar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorMovimentacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorTotalLancamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorTotalAdicionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdParcela)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdAdicionarProduto)
        Me.GroupBox1.Controls.Add(Me.txtValorMovimentacao)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtQtdeParcela)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboCondicaoPagamento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboFormaPagamento)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 290)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de Pagamento"
        '
        'grdParcela
        '
        Me.grdParcela.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdParcela.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdParcela.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdParcela.DisplayLayout.MaxColScrollRegions = 1
        Me.grdParcela.DisplayLayout.MaxRowScrollRegions = 1
        Me.grdParcela.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdParcela.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdParcela.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdParcela.DisplayLayout.Override.CellPadding = 0
        Me.grdParcela.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdParcela.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grdParcela.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdParcela.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdParcela.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdParcela.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdParcela.Location = New System.Drawing.Point(7, 75)
        Me.grdParcela.Name = "grdParcela"
        Me.grdParcela.Size = New System.Drawing.Size(633, 208)
        Me.grdParcela.TabIndex = 251
        Me.grdParcela.Text = "UltraGrid1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 13)
        Me.Label4.TabIndex = 250
        Me.Label4.Text = "Listagem de Procedimentos/Exames"
        '
        'cmdAdicionarProduto
        '
        Me.cmdAdicionarProduto.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Adicionar
        Me.cmdAdicionarProduto.Location = New System.Drawing.Point(615, 31)
        Me.cmdAdicionarProduto.Name = "cmdAdicionarProduto"
        Me.cmdAdicionarProduto.Size = New System.Drawing.Size(25, 23)
        Me.cmdAdicionarProduto.TabIndex = 206
        Me.cmdAdicionarProduto.UseVisualStyleBackColor = True
        '
        'txtValorMovimentacao
        '
        Me.txtValorMovimentacao.CausesValidation = False
        Me.txtValorMovimentacao.Location = New System.Drawing.Point(485, 33)
        Me.txtValorMovimentacao.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorMovimentacao.Name = "txtValorMovimentacao"
        Me.txtValorMovimentacao.Size = New System.Drawing.Size(124, 21)
        Me.txtValorMovimentacao.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(485, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Valor do Lançamento"
        '
        'txtQtdeParcela
        '
        Me.txtQtdeParcela.Location = New System.Drawing.Point(419, 33)
        Me.txtQtdeParcela.MaskInput = "nnnn"
        Me.txtQtdeParcela.MaxValue = 100
        Me.txtQtdeParcela.MinValue = 1
        Me.txtQtdeParcela.Name = "txtQtdeParcela"
        Me.txtQtdeParcela.Size = New System.Drawing.Size(60, 21)
        Me.txtQtdeParcela.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Qt. Parcela"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Condição de Pagamento"
        '
        'cboCondicaoPagamento
        '
        Me.cboCondicaoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondicaoPagamento.FormattingEnabled = True
        Me.cboCondicaoPagamento.Location = New System.Drawing.Point(213, 33)
        Me.cboCondicaoPagamento.Name = "cboCondicaoPagamento"
        Me.cboCondicaoPagamento.Size = New System.Drawing.Size(200, 21)
        Me.cboCondicaoPagamento.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Forma de Pagamento"
        '
        'cboFormaPagamento
        '
        Me.cboFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPagamento.FormattingEnabled = True
        Me.cboFormaPagamento.Location = New System.Drawing.Point(7, 33)
        Me.cboFormaPagamento.Name = "cboFormaPagamento"
        Me.cboFormaPagamento.Size = New System.Drawing.Size(200, 21)
        Me.cboFormaPagamento.TabIndex = 79
        '
        'txtValorTotalLancamento
        '
        Me.txtValorTotalLancamento.CausesValidation = False
        Me.txtValorTotalLancamento.Location = New System.Drawing.Point(9, 316)
        Me.txtValorTotalLancamento.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorTotalLancamento.Name = "txtValorTotalLancamento"
        Me.txtValorTotalLancamento.ReadOnly = True
        Me.txtValorTotalLancamento.Size = New System.Drawing.Size(124, 21)
        Me.txtValorTotalLancamento.TabIndex = 206
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Valor do Total"
        '
        'txtValorTotalAdicionado
        '
        Me.txtValorTotalAdicionado.CausesValidation = False
        Me.txtValorTotalAdicionado.Location = New System.Drawing.Point(139, 316)
        Me.txtValorTotalAdicionado.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorTotalAdicionado.Name = "txtValorTotalAdicionado"
        Me.txtValorTotalAdicionado.ReadOnly = True
        Me.txtValorTotalAdicionado.Size = New System.Drawing.Size(124, 21)
        Me.txtValorTotalAdicionado.TabIndex = 208
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 207
        Me.Label6.Text = "Valor Adicionado"
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(575, 343)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 204
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(494, 343)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 203
        Me.cmdGravar.Text = "Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'frmLancaContasReceberPagar_Venda
        '
        Me.AcceptButton = Me.cmdAdicionarProduto
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 377)
        Me.Controls.Add(Me.txtValorTotalAdicionado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtValorTotalLancamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLancaContasReceberPagar_Venda"
        Me.Text = "Contas Receber e Pagar - Venda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorMovimentacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorTotalLancamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorTotalAdicionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cboCondicaoPagamento As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents cboFormaPagamento As ComboBox
  Friend WithEvents txtQtdeParcela As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label5 As Label
  Friend WithEvents txtValorMovimentacao As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents Label8 As Label
  Friend WithEvents cmdAdicionarProduto As Button
  Friend WithEvents grdParcela As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label4 As Label
  Friend WithEvents cmdFechar As Button
  Friend WithEvents cmdGravar As Button
  Friend WithEvents txtValorTotalLancamento As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents Label2 As Label
  Friend WithEvents txtValorTotalAdicionado As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents Label6 As Label
End Class
