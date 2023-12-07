<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uscMensagemModelo
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.richMensagem = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtImagemMensagem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoUsuario = New System.Windows.Forms.TextBox()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descrição da Mensagem"
        '
        'richMensagem
        '
        Me.richMensagem.Location = New System.Drawing.Point(1, 16)
        Me.richMensagem.Name = "richMensagem"
        Me.richMensagem.Size = New System.Drawing.Size(800, 400)
        Me.richMensagem.TabIndex = 1
        Me.richMensagem.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Imagem da Mensagem"
        '
        'txtImagemMensagem
        '
        Me.txtImagemMensagem.Location = New System.Drawing.Point(1, 435)
        Me.txtImagemMensagem.Name = "txtImagemMensagem"
        Me.txtImagemMensagem.Size = New System.Drawing.Size(800, 20)
        Me.txtImagemMensagem.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 461)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Código de usuário"
        '
        'txtCodigoUsuario
        '
        Me.txtCodigoUsuario.Location = New System.Drawing.Point(1, 476)
        Me.txtCodigoUsuario.Name = "txtCodigoUsuario"
        Me.txtCodigoUsuario.Size = New System.Drawing.Size(300, 20)
        Me.txtCodigoUsuario.TabIndex = 3
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(751, 476)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 5
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'uscMensagemModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.txtCodigoUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtImagemMensagem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.richMensagem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uscMensagemModelo"
        Me.Size = New System.Drawing.Size(809, 500)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents richMensagem As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtImagemMensagem As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoUsuario As TextBox
    Friend WithEvents chkAtivo As CheckBox
End Class
