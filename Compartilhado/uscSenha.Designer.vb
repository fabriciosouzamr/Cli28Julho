<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscSenha
  Inherits System.Windows.Forms.UserControl

  'O UserControl substitui o descarte para limpar a lista de componentes.
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
    Me.txtSenha = New System.Windows.Forms.TextBox()
    Me.picVisualizar = New System.Windows.Forms.PictureBox()
    CType(Me.picVisualizar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtSenha
    '
    Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtSenha.Location = New System.Drawing.Point(0, 3)
    Me.txtSenha.Name = "txtSenha"
    Me.txtSenha.PasswordChar = Microsoft.VisualBasic.ChrW(42)
    Me.txtSenha.Size = New System.Drawing.Size(100, 13)
    Me.txtSenha.TabIndex = 0
    '
    'picVisualizar
    '
    Me.picVisualizar.Image = My.Resources.Resources.Mini_Olho
    Me.picVisualizar.Location = New System.Drawing.Point(102, 1)
    Me.picVisualizar.Name = "picVisualizar"
    Me.picVisualizar.Size = New System.Drawing.Size(16, 16)
    Me.picVisualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picVisualizar.TabIndex = 1
    Me.picVisualizar.TabStop = False
    '
    'uscSenha
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Controls.Add(Me.picVisualizar)
    Me.Controls.Add(Me.txtSenha)
    Me.Name = "uscSenha"
    Me.Size = New System.Drawing.Size(116, 20)
    CType(Me.picVisualizar, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtSenha As TextBox
  Friend WithEvents picVisualizar As PictureBox
End Class
