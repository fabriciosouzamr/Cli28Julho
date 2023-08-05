<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSEGAlterarSenha
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.PasswordLabel = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.txtSenhaAtual = New uscSenha()
    Me.txtNovaSenha = New uscSenha()
    Me.txtConfirmarSenha = New uscSenha()
    Me.SuspendLayout()
    '
    'PasswordLabel
    '
    Me.PasswordLabel.AutoSize = True
    Me.PasswordLabel.Location = New System.Drawing.Point(10, 20)
    Me.PasswordLabel.Name = "PasswordLabel"
    Me.PasswordLabel.Size = New System.Drawing.Size(65, 13)
    Me.PasswordLabel.TabIndex = 4
    Me.PasswordLabel.Text = "Senha Atual"
    Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(10, 65)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(67, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Nova Senha"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(10, 110)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(85, 13)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = "Confirmar Senha"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(10, 155)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 10
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(155, 155)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 11
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'txtSenhaAtual
    '
    Me.txtSenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtSenhaAtual.Location = New System.Drawing.Point(10, 35)
    Me.txtSenhaAtual.Name = "txtSenhaAtual"
    Me.txtSenhaAtual.Senha = ""
    Me.txtSenhaAtual.Size = New System.Drawing.Size(220, 20)
    Me.txtSenhaAtual.TabIndex = 12
    '
    'txtNovaSenha
    '
    Me.txtNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNovaSenha.Location = New System.Drawing.Point(10, 80)
    Me.txtNovaSenha.Name = "txtNovaSenha"
    Me.txtNovaSenha.Senha = ""
    Me.txtNovaSenha.Size = New System.Drawing.Size(220, 20)
    Me.txtNovaSenha.TabIndex = 13
    '
    'txtConfirmarSenha
    '
    Me.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtConfirmarSenha.Location = New System.Drawing.Point(10, 125)
    Me.txtConfirmarSenha.Name = "txtConfirmarSenha"
    Me.txtConfirmarSenha.Senha = ""
    Me.txtConfirmarSenha.Size = New System.Drawing.Size(220, 20)
    Me.txtConfirmarSenha.TabIndex = 14
    '
    'frmSEGAlterarSenha
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(242, 191)
    Me.ControlBox = False
    Me.Controls.Add(Me.txtConfirmarSenha)
    Me.Controls.Add(Me.txtNovaSenha)
    Me.Controls.Add(Me.txtSenhaAtual)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.PasswordLabel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmSEGAlterarSenha"
    Me.Text = "Alterar Senha"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PasswordLabel As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents txtSenhaAtual As uscSenha
  Friend WithEvents txtNovaSenha As uscSenha
  Friend WithEvents txtConfirmarSenha As uscSenha
End Class
