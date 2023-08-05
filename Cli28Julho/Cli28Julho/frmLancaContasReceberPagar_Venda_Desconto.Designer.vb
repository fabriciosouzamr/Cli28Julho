<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancaContasReceberPagar_Venda_Desconto
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
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.cboLogin_Usuario = New System.Windows.Forms.ComboBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtValorDesconto = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdValidar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtValorDesconto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSenha)
        Me.GroupBox1.Controls.Add(Me.cboLogin_Usuario)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuário e senha de supervisão"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(7, 73)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(220, 20)
        Me.txtSenha.TabIndex = 7
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'cboLogin_Usuario
        '
        Me.cboLogin_Usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboLogin_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLogin_Usuario.FormattingEnabled = True
        Me.cboLogin_Usuario.Location = New System.Drawing.Point(7, 31)
        Me.cboLogin_Usuario.Name = "cboLogin_Usuario"
        Me.cboLogin_Usuario.Size = New System.Drawing.Size(220, 21)
        Me.cboLogin_Usuario.TabIndex = 3
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(7, 58)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(38, 13)
        Me.PasswordLabel.TabIndex = 6
        Me.PasswordLabel.Text = "Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(7, 16)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtValorDesconto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(236, 60)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Desconto"
        '
        'txtValorDesconto
        '
        Me.txtValorDesconto.CausesValidation = False
        Me.txtValorDesconto.Location = New System.Drawing.Point(7, 31)
        Me.txtValorDesconto.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtValorDesconto.Name = "txtValorDesconto"
        Me.txtValorDesconto.Size = New System.Drawing.Size(124, 21)
        Me.txtValorDesconto.TabIndex = 212
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 211
        Me.Label7.Text = "Valor Desconto"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(147, 184)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(94, 28)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "  Cancelar"
        '
        'cmdValidar
        '
        Me.cmdValidar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Login
        Me.cmdValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdValidar.Location = New System.Drawing.Point(47, 184)
        Me.cmdValidar.Name = "cmdValidar"
        Me.cmdValidar.Size = New System.Drawing.Size(94, 28)
        Me.cmdValidar.TabIndex = 5
        Me.cmdValidar.Text = "Validar"
        '
        'frmLancaContasReceberPagar_Venda_Desconto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 218)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdValidar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLancaContasReceberPagar_Venda_Desconto"
        Me.Text = "Contas Receber e Pagar - Venda - Desconto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtValorDesconto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboLogin_Usuario As ComboBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtValorDesconto As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdValidar As Button
End Class
