<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroIntegracao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.tabIntegracao = New System.Windows.Forms.TabControl()
        Me.tbsSisVida = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSisVida_Integracao = New System.Windows.Forms.TextBox()
        Me.txtSisVida_CodLab = New System.Windows.Forms.TextBox()
        Me.txtSisVida_Senha = New System.Windows.Forms.TextBox()
        Me.txtSisVida_Login = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSisVida_LinkAPI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSisVida_Ativo = New System.Windows.Forms.CheckBox()
        Me.tabIntegracao.SuspendLayout()
        Me.tbsSisVida.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(927, 562)
        Me.cmdFechar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(100, 34)
        Me.cmdFechar.TabIndex = 158
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(819, 562)
        Me.cmdGravar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(100, 34)
        Me.cmdGravar.TabIndex = 157
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'tabIntegracao
        '
        Me.tabIntegracao.Controls.Add(Me.tbsSisVida)
        Me.tabIntegracao.Location = New System.Drawing.Point(5, 5)
        Me.tabIntegracao.Name = "tabIntegracao"
        Me.tabIntegracao.SelectedIndex = 0
        Me.tabIntegracao.Size = New System.Drawing.Size(1026, 551)
        Me.tabIntegracao.TabIndex = 159
        '
        'tbsSisVida
        '
        Me.tbsSisVida.Controls.Add(Me.chkSisVida_Ativo)
        Me.tbsSisVida.Controls.Add(Me.Label5)
        Me.tbsSisVida.Controls.Add(Me.Label4)
        Me.tbsSisVida.Controls.Add(Me.Label3)
        Me.tbsSisVida.Controls.Add(Me.txtSisVida_Integracao)
        Me.tbsSisVida.Controls.Add(Me.txtSisVida_CodLab)
        Me.tbsSisVida.Controls.Add(Me.txtSisVida_Senha)
        Me.tbsSisVida.Controls.Add(Me.txtSisVida_Login)
        Me.tbsSisVida.Controls.Add(Me.Label2)
        Me.tbsSisVida.Controls.Add(Me.txtSisVida_LinkAPI)
        Me.tbsSisVida.Controls.Add(Me.Label1)
        Me.tbsSisVida.Location = New System.Drawing.Point(4, 25)
        Me.tbsSisVida.Name = "tbsSisVida"
        Me.tbsSisVida.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsSisVida.Size = New System.Drawing.Size(1018, 522)
        Me.tbsSisVida.TabIndex = 0
        Me.tbsSisVida.Text = "SisVida"
        Me.tbsSisVida.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(758, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Integracao"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(507, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CodLab"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Senha"
        '
        'txtSisVida_Integracao
        '
        Me.txtSisVida_Integracao.Location = New System.Drawing.Point(758, 69)
        Me.txtSisVida_Integracao.Name = "txtSisVida_Integracao"
        Me.txtSisVida_Integracao.Size = New System.Drawing.Size(251, 22)
        Me.txtSisVida_Integracao.TabIndex = 5
        '
        'txtSisVida_CodLab
        '
        Me.txtSisVida_CodLab.Location = New System.Drawing.Point(507, 69)
        Me.txtSisVida_CodLab.Name = "txtSisVida_CodLab"
        Me.txtSisVida_CodLab.Size = New System.Drawing.Size(245, 22)
        Me.txtSisVida_CodLab.TabIndex = 4
        '
        'txtSisVida_Senha
        '
        Me.txtSisVida_Senha.Location = New System.Drawing.Point(256, 69)
        Me.txtSisVida_Senha.Name = "txtSisVida_Senha"
        Me.txtSisVida_Senha.Size = New System.Drawing.Size(245, 22)
        Me.txtSisVida_Senha.TabIndex = 3
        '
        'txtSisVida_Login
        '
        Me.txtSisVida_Login.Location = New System.Drawing.Point(5, 69)
        Me.txtSisVida_Login.Name = "txtSisVida_Login"
        Me.txtSisVida_Login.Size = New System.Drawing.Size(245, 22)
        Me.txtSisVida_Login.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Login"
        '
        'txtSisVida_LinkAPI
        '
        Me.txtSisVida_LinkAPI.Location = New System.Drawing.Point(5, 23)
        Me.txtSisVida_LinkAPI.Name = "txtSisVida_LinkAPI"
        Me.txtSisVida_LinkAPI.Size = New System.Drawing.Size(1004, 22)
        Me.txtSisVida_LinkAPI.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Link API"
        '
        'chkSisVida_Ativo
        '
        Me.chkSisVida_Ativo.AutoSize = True
        Me.chkSisVida_Ativo.Location = New System.Drawing.Point(5, 97)
        Me.chkSisVida_Ativo.Name = "chkSisVida_Ativo"
        Me.chkSisVida_Ativo.Size = New System.Drawing.Size(59, 20)
        Me.chkSisVida_Ativo.TabIndex = 10
        Me.chkSisVida_Ativo.Text = "Ativo"
        Me.chkSisVida_Ativo.UseVisualStyleBackColor = True
        '
        'frmCadastroIntegracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 604)
        Me.Controls.Add(Me.tabIntegracao)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdGravar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroIntegracao"
        Me.Text = "Cadastro de Integrações"
        Me.tabIntegracao.ResumeLayout(False)
        Me.tbsSisVida.ResumeLayout(False)
        Me.tbsSisVida.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdFechar As Button
    Friend WithEvents cmdGravar As Button
    Friend WithEvents tabIntegracao As TabControl
    Friend WithEvents tbsSisVida As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSisVida_LinkAPI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSisVida_Integracao As TextBox
    Friend WithEvents txtSisVida_CodLab As TextBox
    Friend WithEvents txtSisVida_Senha As TextBox
    Friend WithEvents txtSisVida_Login As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkSisVida_Ativo As CheckBox
End Class
