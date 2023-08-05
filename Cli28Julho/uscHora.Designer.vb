<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscHora
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
    Me.txtHora = New System.Windows.Forms.TextBox()
    Me.txtMinuto = New System.Windows.Forms.TextBox()
    Me.lblSeparador = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'txtHora
    '
    Me.txtHora.BackColor = System.Drawing.Color.White
    Me.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtHora.Location = New System.Drawing.Point(0, 0)
    Me.txtHora.Name = "txtHora"
    Me.txtHora.Size = New System.Drawing.Size(18, 13)
    Me.txtHora.TabIndex = 0
    Me.txtHora.Text = "99"
    Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtMinuto
    '
    Me.txtMinuto.BackColor = System.Drawing.Color.White
    Me.txtMinuto.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMinuto.Location = New System.Drawing.Point(28, 0)
    Me.txtMinuto.Name = "txtMinuto"
    Me.txtMinuto.Size = New System.Drawing.Size(18, 13)
    Me.txtMinuto.TabIndex = 1
    Me.txtMinuto.Text = "99"
    '
    'lblSeparador
    '
    Me.lblSeparador.AutoSize = True
    Me.lblSeparador.Location = New System.Drawing.Point(18, 0)
    Me.lblSeparador.Name = "lblSeparador"
    Me.lblSeparador.Size = New System.Drawing.Size(10, 13)
    Me.lblSeparador.TabIndex = 2
    Me.lblSeparador.Text = ":"
    '
    'uscHora
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lblSeparador)
    Me.Controls.Add(Me.txtMinuto)
    Me.Controls.Add(Me.txtHora)
    Me.Name = "uscHora"
    Me.Size = New System.Drawing.Size(47, 13)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtHora As TextBox
  Friend WithEvents txtMinuto As TextBox
  Friend WithEvents lblSeparador As Label
End Class
