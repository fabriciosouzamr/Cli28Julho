<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frmLogin
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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
  Friend WithEvents UsernameLabel As System.Windows.Forms.Label
  Friend WithEvents PasswordLabel As System.Windows.Forms.Label
  Friend WithEvents cmdLogin_Acessar As System.Windows.Forms.Button
  Friend WithEvents cmdLogin_Cancelar As System.Windows.Forms.Button

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
    Me.UsernameLabel = New System.Windows.Forms.Label()
    Me.PasswordLabel = New System.Windows.Forms.Label()
    Me.cboLogin_Usuario = New System.Windows.Forms.ComboBox()
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cmdLogin_Acessar = New System.Windows.Forms.Button()
    Me.cmdLogin_Cancelar = New System.Windows.Forms.Button()
    Me.cboServidor = New System.Windows.Forms.ComboBox()
    Me.lblRServidor = New System.Windows.Forms.Label()
        Me.txtLogin_Senha = New Cli28Julho.uscSenha()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(10, 10)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(43, 13)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(10, 64)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(38, 13)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboLogin_Usuario
        '
        Me.cboLogin_Usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboLogin_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLogin_Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLogin_Usuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboLogin_Usuario.FormattingEnabled = True
        Me.cboLogin_Usuario.Location = New System.Drawing.Point(10, 25)
        Me.cboLogin_Usuario.Name = "cboLogin_Usuario"
        Me.cboLogin_Usuario.Size = New System.Drawing.Size(569, 33)
        Me.cboLogin_Usuario.TabIndex = 0
        '
        'cboEmpresa
        '
        Me.cboEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpresa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(10, 133)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(469, 33)
        Me.cboEmpresa.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdLogin_Acessar
        '
        Me.cmdLogin_Acessar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Login
        Me.cmdLogin_Acessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogin_Acessar.Location = New System.Drawing.Point(485, 84)
        Me.cmdLogin_Acessar.Name = "cmdLogin_Acessar"
        Me.cmdLogin_Acessar.Size = New System.Drawing.Size(94, 28)
        Me.cmdLogin_Acessar.TabIndex = 3
        Me.cmdLogin_Acessar.Text = "Acessar"
        '
        'cmdLogin_Cancelar
        '
        Me.cmdLogin_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdLogin_Cancelar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdLogin_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogin_Cancelar.Location = New System.Drawing.Point(485, 138)
        Me.cmdLogin_Cancelar.Name = "cmdLogin_Cancelar"
        Me.cmdLogin_Cancelar.Size = New System.Drawing.Size(94, 28)
        Me.cmdLogin_Cancelar.TabIndex = 4
        Me.cmdLogin_Cancelar.Text = "  Cancelar"
        '
        'cboServidor
        '
        Me.cboServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServidor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cboServidor.FormattingEnabled = True
        Me.cboServidor.Location = New System.Drawing.Point(10, 187)
        Me.cboServidor.Name = "cboServidor"
        Me.cboServidor.Size = New System.Drawing.Size(469, 33)
        Me.cboServidor.TabIndex = 6
        '
        'lblRServidor
        '
        Me.lblRServidor.AutoSize = True
        Me.lblRServidor.Location = New System.Drawing.Point(10, 172)
        Me.lblRServidor.Name = "lblRServidor"
        Me.lblRServidor.Size = New System.Drawing.Size(46, 13)
        Me.lblRServidor.TabIndex = 7
        Me.lblRServidor.Text = "Servidor"
        Me.lblRServidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLogin_Senha
        '
        Me.txtLogin_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogin_Senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin_Senha.Location = New System.Drawing.Point(10, 79)
        Me.txtLogin_Senha.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtLogin_Senha.Name = "txtLogin_Senha"
        Me.txtLogin_Senha.Senha = ""
        Me.txtLogin_Senha.Size = New System.Drawing.Size(469, 33)
        Me.txtLogin_Senha.TabIndex = 1
        '
        'frmLogin
        '
        Me.AcceptButton = Me.cmdLogin_Acessar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdLogin_Cancelar
        Me.ClientSize = New System.Drawing.Size(591, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLogin_Senha)
        Me.Controls.Add(Me.cboServidor)
        Me.Controls.Add(Me.lblRServidor)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboLogin_Usuario)
        Me.Controls.Add(Me.cmdLogin_Cancelar)
        Me.Controls.Add(Me.cmdLogin_Acessar)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acesso ao Sistema"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboLogin_Usuario As System.Windows.Forms.ComboBox
  Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboServidor As ComboBox
  Friend WithEvents lblRServidor As Label
  Friend WithEvents txtLogin_Senha As uscSenha
End Class
