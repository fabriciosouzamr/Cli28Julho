<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroEstoque_Simples
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
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtCodigoEstoque = New System.Windows.Forms.TextBox()
    Me.chkEntradaAutomatica = New System.Windows.Forms.CheckBox()
    Me.chkPermiteSaldoNegativo = New System.Windows.Forms.CheckBox()
    Me.chkAtivo = New System.Windows.Forms.CheckBox()
    Me.chkPermiteBloqueio = New System.Windows.Forms.CheckBox()
    Me.chkControlaMinimos = New System.Windows.Forms.CheckBox()
    Me.cboDepartamento = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtNomeEstoque = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.grdProdutos = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.cmdProdutos_Excel = New System.Windows.Forms.Button()
    Me.cmdProdutos_Atualizar = New System.Windows.Forms.Button()
    CType(Me.grdProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(511, 5)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(97, 13)
    Me.Label3.TabIndex = 142
    Me.Label3.Text = "Código do Estoque"
    '
    'txtCodigoEstoque
    '
    Me.txtCodigoEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigoEstoque.Location = New System.Drawing.Point(511, 20)
    Me.txtCodigoEstoque.MaxLength = 10
    Me.txtCodigoEstoque.Name = "txtCodigoEstoque"
    Me.txtCodigoEstoque.Size = New System.Drawing.Size(100, 20)
    Me.txtCodigoEstoque.TabIndex = 133
    '
    'chkEntradaAutomatica
    '
    Me.chkEntradaAutomatica.AutoSize = True
    Me.chkEntradaAutomatica.Location = New System.Drawing.Point(373, 88)
    Me.chkEntradaAutomatica.Name = "chkEntradaAutomatica"
    Me.chkEntradaAutomatica.Size = New System.Drawing.Size(119, 17)
    Me.chkEntradaAutomatica.TabIndex = 139
    Me.chkEntradaAutomatica.Text = "Entrada Automática"
    Me.chkEntradaAutomatica.UseVisualStyleBackColor = True
    '
    'chkPermiteSaldoNegativo
    '
    Me.chkPermiteSaldoNegativo.AutoSize = True
    Me.chkPermiteSaldoNegativo.Location = New System.Drawing.Point(230, 88)
    Me.chkPermiteSaldoNegativo.Name = "chkPermiteSaldoNegativo"
    Me.chkPermiteSaldoNegativo.Size = New System.Drawing.Size(137, 17)
    Me.chkPermiteSaldoNegativo.TabIndex = 138
    Me.chkPermiteSaldoNegativo.Text = "Permite Saldo Negativo"
    Me.chkPermiteSaldoNegativo.UseVisualStyleBackColor = True
    '
    'chkAtivo
    '
    Me.chkAtivo.AutoSize = True
    Me.chkAtivo.Location = New System.Drawing.Point(617, 22)
    Me.chkAtivo.Name = "chkAtivo"
    Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
    Me.chkAtivo.TabIndex = 135
    Me.chkAtivo.Text = "Ativo"
    Me.chkAtivo.UseVisualStyleBackColor = True
    '
    'chkPermiteBloqueio
    '
    Me.chkPermiteBloqueio.AutoSize = True
    Me.chkPermiteBloqueio.Location = New System.Drawing.Point(119, 88)
    Me.chkPermiteBloqueio.Name = "chkPermiteBloqueio"
    Me.chkPermiteBloqueio.Size = New System.Drawing.Size(105, 17)
    Me.chkPermiteBloqueio.TabIndex = 137
    Me.chkPermiteBloqueio.Text = "Permite Bloqueio"
    Me.chkPermiteBloqueio.UseVisualStyleBackColor = True
    '
    'chkControlaMinimos
    '
    Me.chkControlaMinimos.AutoSize = True
    Me.chkControlaMinimos.Location = New System.Drawing.Point(5, 88)
    Me.chkControlaMinimos.Name = "chkControlaMinimos"
    Me.chkControlaMinimos.Size = New System.Drawing.Size(108, 17)
    Me.chkControlaMinimos.TabIndex = 136
    Me.chkControlaMinimos.Text = "Controla Mínimos"
    Me.chkControlaMinimos.UseVisualStyleBackColor = True
    '
    'cboDepartamento
    '
    Me.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDepartamento.FormattingEnabled = True
    Me.cboDepartamento.Location = New System.Drawing.Point(5, 61)
    Me.cboDepartamento.Name = "cboDepartamento"
    Me.cboDepartamento.Size = New System.Drawing.Size(500, 21)
    Me.cboDepartamento.TabIndex = 134
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 46)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(74, 13)
    Me.Label2.TabIndex = 141
    Me.Label2.Text = "Departamento"
    '
    'txtNomeEstoque
    '
    Me.txtNomeEstoque.Location = New System.Drawing.Point(5, 20)
    Me.txtNomeEstoque.MaxLength = 50
    Me.txtNomeEstoque.Name = "txtNomeEstoque"
    Me.txtNomeEstoque.Size = New System.Drawing.Size(500, 20)
    Me.txtNomeEstoque.TabIndex = 132
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(92, 13)
    Me.Label1.TabIndex = 140
    Me.Label1.Text = "Nome do Estoque"
    '
    'cmdFechar
    '
    Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(603, 420)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 144
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(522, 420)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 143
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 111)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(166, 13)
    Me.Label4.TabIndex = 146
    Me.Label4.Text = "Listagem de produtos em estoque"
    '
    'grdProdutos
    '
    Appearance1.BackColor = System.Drawing.SystemColors.Window
    Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdProdutos.DisplayLayout.Appearance = Appearance1
    Me.grdProdutos.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdProdutos.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance2.BorderColor = System.Drawing.SystemColors.Window
    Me.grdProdutos.DisplayLayout.GroupByBox.Appearance = Appearance2
    Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdProdutos.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
    Me.grdProdutos.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance4.BackColor2 = System.Drawing.SystemColors.Control
    Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdProdutos.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
    Me.grdProdutos.DisplayLayout.MaxColScrollRegions = 1
    Me.grdProdutos.DisplayLayout.MaxRowScrollRegions = 1
    Appearance5.BackColor = System.Drawing.SystemColors.Window
    Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdProdutos.DisplayLayout.Override.ActiveCellAppearance = Appearance5
    Appearance6.BackColor = System.Drawing.SystemColors.Highlight
    Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdProdutos.DisplayLayout.Override.ActiveRowAppearance = Appearance6
    Me.grdProdutos.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdProdutos.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance7.BackColor = System.Drawing.SystemColors.Window
    Me.grdProdutos.DisplayLayout.Override.CardAreaAppearance = Appearance7
    Appearance8.BorderColor = System.Drawing.Color.Silver
    Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdProdutos.DisplayLayout.Override.CellAppearance = Appearance8
    Me.grdProdutos.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.grdProdutos.DisplayLayout.Override.CellPadding = 0
    Appearance9.BackColor = System.Drawing.SystemColors.Control
    Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance9.BorderColor = System.Drawing.SystemColors.Window
    Me.grdProdutos.DisplayLayout.Override.GroupByRowAppearance = Appearance9
    Appearance10.TextHAlignAsString = "Left"
    Me.grdProdutos.DisplayLayout.Override.HeaderAppearance = Appearance10
    Me.grdProdutos.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdProdutos.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance11.BackColor = System.Drawing.SystemColors.Window
    Appearance11.BorderColor = System.Drawing.Color.Silver
    Me.grdProdutos.DisplayLayout.Override.RowAppearance = Appearance11
    Me.grdProdutos.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdProdutos.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
    Me.grdProdutos.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdProdutos.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdProdutos.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdProdutos.Location = New System.Drawing.Point(5, 126)
    Me.grdProdutos.Name = "grdProdutos"
    Me.grdProdutos.Size = New System.Drawing.Size(673, 288)
    Me.grdProdutos.TabIndex = 145
    Me.grdProdutos.Text = "UltraGrid1"
    '
    'cmdProdutos_Excel
    '
    Me.cmdProdutos_Excel.Image = My.Resources.Resources.Mini_Excel
    Me.cmdProdutos_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdProdutos_Excel.Location = New System.Drawing.Point(5, 420)
    Me.cmdProdutos_Excel.Name = "cmdProdutos_Excel"
    Me.cmdProdutos_Excel.Size = New System.Drawing.Size(75, 28)
    Me.cmdProdutos_Excel.TabIndex = 148
    Me.cmdProdutos_Excel.Text = "Excel"
    Me.cmdProdutos_Excel.UseVisualStyleBackColor = True
    '
    'cmdProdutos_Atualizar
    '
    Me.cmdProdutos_Atualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdProdutos_Atualizar.Image = My.Resources.Resources.Mini_Atualizar
    Me.cmdProdutos_Atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdProdutos_Atualizar.Location = New System.Drawing.Point(86, 420)
    Me.cmdProdutos_Atualizar.Name = "cmdProdutos_Atualizar"
    Me.cmdProdutos_Atualizar.Size = New System.Drawing.Size(75, 28)
    Me.cmdProdutos_Atualizar.TabIndex = 147
    Me.cmdProdutos_Atualizar.Text = "    Atualizar"
    Me.cmdProdutos_Atualizar.UseVisualStyleBackColor = True
    '
    'frmCadastroEstoque_Simples
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(685, 454)
    Me.Controls.Add(Me.cmdProdutos_Excel)
    Me.Controls.Add(Me.cmdProdutos_Atualizar)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.grdProdutos)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtCodigoEstoque)
    Me.Controls.Add(Me.chkEntradaAutomatica)
    Me.Controls.Add(Me.chkPermiteSaldoNegativo)
    Me.Controls.Add(Me.chkAtivo)
    Me.Controls.Add(Me.chkPermiteBloqueio)
    Me.Controls.Add(Me.chkControlaMinimos)
    Me.Controls.Add(Me.cboDepartamento)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtNomeEstoque)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroEstoque_Simples"
    Me.Text = "Cadastro de Estoque"
    CType(Me.grdProdutos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label3 As Label
  Friend WithEvents txtCodigoEstoque As TextBox
  Friend WithEvents chkEntradaAutomatica As CheckBox
  Friend WithEvents chkPermiteSaldoNegativo As CheckBox
  Friend WithEvents chkAtivo As CheckBox
  Friend WithEvents chkPermiteBloqueio As CheckBox
  Friend WithEvents chkControlaMinimos As CheckBox
  Friend WithEvents cboDepartamento As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents txtNomeEstoque As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents cmdFechar As Button
  Friend WithEvents cmdGravar As Button
  Friend WithEvents Label4 As Label
  Friend WithEvents grdProdutos As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents cmdProdutos_Excel As Button
  Friend WithEvents cmdProdutos_Atualizar As Button
End Class
