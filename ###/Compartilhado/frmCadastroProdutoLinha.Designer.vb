<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroProdutoLinha
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
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboTipoProdutoLinha = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtNomeProdutoLinha = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboUnidadeMedida = New System.Windows.Forms.ComboBox()
    Me.chkAtivo = New System.Windows.Forms.CheckBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.lblRProdutoIndicacao = New System.Windows.Forms.Label()
    Me.cboProdutoIndicacao = New System.Windows.Forms.ComboBox()
    Me.cklCaracteriscaProduto = New System.Windows.Forms.CheckedListBox()
    Me.SuspendLayout()
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(449, 324)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 100
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(530, 324)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(127, 13)
    Me.Label1.TabIndex = 18
    Me.Label1.Text = "Tipo de Linha de Produto"
    '
    'cboTipoProdutoLinha
    '
    Me.cboTipoProdutoLinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoProdutoLinha.FormattingEnabled = True
    Me.cboTipoProdutoLinha.Location = New System.Drawing.Point(5, 61)
    Me.cboTipoProdutoLinha.Name = "cboTipoProdutoLinha"
    Me.cboTipoProdutoLinha.Size = New System.Drawing.Size(127, 21)
    Me.cboTipoProdutoLinha.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(134, 13)
    Me.Label2.TabIndex = 20
    Me.Label2.Text = "Nome de Linha de Produto"
    '
    'txtNomeProdutoLinha
    '
    Me.txtNomeProdutoLinha.Location = New System.Drawing.Point(5, 20)
    Me.txtNomeProdutoLinha.Name = "txtNomeProdutoLinha"
    Me.txtNomeProdutoLinha.Size = New System.Drawing.Size(600, 20)
    Me.txtNomeProdutoLinha.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(5, 88)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 13)
    Me.Label3.TabIndex = 18
    Me.Label3.Text = "Unidade de Medida"
    '
    'cboUnidadeMedida
    '
    Me.cboUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboUnidadeMedida.FormattingEnabled = True
    Me.cboUnidadeMedida.Location = New System.Drawing.Point(5, 103)
    Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
    Me.cboUnidadeMedida.Size = New System.Drawing.Size(376, 21)
    Me.cboUnidadeMedida.TabIndex = 4
    '
    'chkAtivo
    '
    Me.chkAtivo.AutoSize = True
    Me.chkAtivo.Location = New System.Drawing.Point(555, 103)
    Me.chkAtivo.Name = "chkAtivo"
    Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
    Me.chkAtivo.TabIndex = 5
    Me.chkAtivo.Text = "Ativo"
    Me.chkAtivo.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 130)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(127, 13)
    Me.Label4.TabIndex = 25
    Me.Label4.Text = "Caraterística de Produtos"
    '
    'lblRProdutoIndicacao
    '
    Me.lblRProdutoIndicacao.AutoSize = True
    Me.lblRProdutoIndicacao.Location = New System.Drawing.Point(138, 46)
    Me.lblRProdutoIndicacao.Name = "lblRProdutoIndicacao"
    Me.lblRProdutoIndicacao.Size = New System.Drawing.Size(94, 13)
    Me.lblRProdutoIndicacao.TabIndex = 27
    Me.lblRProdutoIndicacao.Text = "Produto Indicação"
    '
    'cboProdutoIndicacao
    '
    Me.cboProdutoIndicacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProdutoIndicacao.FormattingEnabled = True
    Me.cboProdutoIndicacao.Location = New System.Drawing.Point(138, 61)
    Me.cboProdutoIndicacao.Name = "cboProdutoIndicacao"
    Me.cboProdutoIndicacao.Size = New System.Drawing.Size(467, 21)
    Me.cboProdutoIndicacao.TabIndex = 3
    '
    'cklCaracteriscaProduto
    '
    Me.cklCaracteriscaProduto.FormattingEnabled = True
    Me.cklCaracteriscaProduto.Location = New System.Drawing.Point(5, 145)
    Me.cklCaracteriscaProduto.Name = "cklCaracteriscaProduto"
    Me.cklCaracteriscaProduto.Size = New System.Drawing.Size(600, 169)
    Me.cklCaracteriscaProduto.TabIndex = 6
    '
    'frmCadastroProdutoLinha
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(610, 357)
    Me.Controls.Add(Me.cklCaracteriscaProduto)
    Me.Controls.Add(Me.cboProdutoIndicacao)
    Me.Controls.Add(Me.lblRProdutoIndicacao)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.chkAtivo)
    Me.Controls.Add(Me.cboUnidadeMedida)
    Me.Controls.Add(Me.txtNomeProdutoLinha)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboTipoProdutoLinha)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroProdutoLinha"
    Me.Text = "Cadastro de Linha de Produto"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents cboTipoProdutoLinha As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents txtNomeProdutoLinha As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cboUnidadeMedida As ComboBox
  Friend WithEvents chkAtivo As CheckBox
  Friend WithEvents Label4 As Label
  Friend WithEvents lblRProdutoIndicacao As Label
  Friend WithEvents cboProdutoIndicacao As ComboBox
  Friend WithEvents cklCaracteriscaProduto As CheckedListBox
End Class
