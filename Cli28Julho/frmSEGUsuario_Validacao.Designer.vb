<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSEGUsuario_Validacao
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
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdValidar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox1.TabIndex = 7
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
        'cmdCancelar
        '
        Me.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancelar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(147, 118)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(94, 28)
        Me.cmdCancelar.TabIndex = 10
        Me.cmdCancelar.Text = "  Cancelar"
        '
        'cmdValidar
        '
        Me.cmdValidar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Login
        Me.cmdValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdValidar.Location = New System.Drawing.Point(46, 118)
        Me.cmdValidar.Name = "cmdValidar"
        Me.cmdValidar.Size = New System.Drawing.Size(94, 28)
        Me.cmdValidar.TabIndex = 9
        Me.cmdValidar.Text = "Validar"
        '
        'frmSEGUsuario_Validacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 153)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdValidar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSEGUsuario_Validacao"
        Me.Text = "frmSEGUsuario_Validacao"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents cboLogin_Usuario As ComboBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents cmdCancelar As Button
    Friend WithEvents cmdValidar As Button
End Class
