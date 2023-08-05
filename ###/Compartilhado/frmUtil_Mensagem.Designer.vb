<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtil_Mensagem
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
    Me.txtMensagem = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'txtMensagem
    '
    Me.txtMensagem.Dock = System.Windows.Forms.DockStyle.Fill
    Me.txtMensagem.Location = New System.Drawing.Point(0, 0)
    Me.txtMensagem.Multiline = True
    Me.txtMensagem.Name = "txtMensagem"
    Me.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.txtMensagem.Size = New System.Drawing.Size(364, 133)
    Me.txtMensagem.TabIndex = 0
    '
    'frmUtil_Mensagem
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(364, 133)
    Me.Controls.Add(Me.txtMensagem)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmUtil_Mensagem"
    Me.Text = "Mensagem"
    Me.TopMost = True
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtMensagem As TextBox
End Class
