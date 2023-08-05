<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtLogin_Senha As System.Windows.Forms.TextBox
    Friend WithEvents cmdLogin_Acessar As System.Windows.Forms.Button
    Friend WithEvents cmdLogin_Cancelar As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
    Me.UsernameLabel = New System.Windows.Forms.Label()
    Me.PasswordLabel = New System.Windows.Forms.Label()
    Me.txtLogin_Senha = New System.Windows.Forms.TextBox()
    Me.cboLogin_Usuario = New System.Windows.Forms.ComboBox()
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cmdLogin_Acessar = New System.Windows.Forms.Button()
    Me.cmdLogin_Cancelar = New System.Windows.Forms.Button()
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
    Me.PasswordLabel.Location = New System.Drawing.Point(10, 54)
    Me.PasswordLabel.Name = "PasswordLabel"
    Me.PasswordLabel.Size = New System.Drawing.Size(38, 13)
    Me.PasswordLabel.TabIndex = 2
    Me.PasswordLabel.Text = "Senha"
    Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtLogin_Senha
    '
    Me.txtLogin_Senha.Location = New System.Drawing.Point(10, 69)
    Me.txtLogin_Senha.Name = "txtLogin_Senha"
    Me.txtLogin_Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtLogin_Senha.Size = New System.Drawing.Size(220, 20)
    Me.txtLogin_Senha.TabIndex = 1
    '
    'cboLogin_Usuario
    '
    Me.cboLogin_Usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
    Me.cboLogin_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboLogin_Usuario.FormattingEnabled = True
    Me.cboLogin_Usuario.Location = New System.Drawing.Point(10, 25)
    Me.cboLogin_Usuario.Name = "cboLogin_Usuario"
    Me.cboLogin_Usuario.Size = New System.Drawing.Size(220, 21)
    Me.cboLogin_Usuario.TabIndex = 0
    '
    'cboEmpresa
    '
    Me.cboEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
    Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEmpresa.FormattingEnabled = True
    Me.cboEmpresa.Location = New System.Drawing.Point(10, 114)
    Me.cboEmpresa.Name = "cboEmpresa"
    Me.cboEmpresa.Size = New System.Drawing.Size(367, 21)
    Me.cboEmpresa.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(10, 99)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(48, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Empresa"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cmdLogin_Acessar
    '
    Me.cmdLogin_Acessar.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Login
    Me.cmdLogin_Acessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLogin_Acessar.Location = New System.Drawing.Point(283, 25)
    Me.cmdLogin_Acessar.Name = "cmdLogin_Acessar"
    Me.cmdLogin_Acessar.Size = New System.Drawing.Size(94, 28)
    Me.cmdLogin_Acessar.TabIndex = 3
    Me.cmdLogin_Acessar.Text = "Acessar"
    '
    'cmdLogin_Cancelar
    '
    Me.cmdLogin_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdLogin_Cancelar.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Fechar
    Me.cmdLogin_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLogin_Cancelar.Location = New System.Drawing.Point(283, 69)
    Me.cmdLogin_Cancelar.Name = "cmdLogin_Cancelar"
    Me.cmdLogin_Cancelar.Size = New System.Drawing.Size(94, 28)
    Me.cmdLogin_Cancelar.TabIndex = 4
    Me.cmdLogin_Cancelar.Text = "  Cancelar"
    '
    'frmLogin
    '
    Me.AcceptButton = Me.cmdLogin_Acessar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdLogin_Cancelar
    Me.ClientSize = New System.Drawing.Size(398, 150)
    Me.ControlBox = False
    Me.Controls.Add(Me.cboEmpresa)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cboLogin_Usuario)
    Me.Controls.Add(Me.cmdLogin_Cancelar)
    Me.Controls.Add(Me.cmdLogin_Acessar)
    Me.Controls.Add(Me.txtLogin_Senha)
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

End Class
