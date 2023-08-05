<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscPictureBox_Zoom
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
    Me.picImagem = New System.Windows.Forms.PictureBox()
    CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picImagem
    '
    Me.picImagem.Location = New System.Drawing.Point(3, 3)
    Me.picImagem.Name = "picImagem"
    Me.picImagem.Size = New System.Drawing.Size(420, 426)
    Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picImagem.TabIndex = 2
    Me.picImagem.TabStop = False
    '
    'uscPictureBox_Zoom
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.picImagem)
    Me.Name = "uscPictureBox_Zoom"
    Me.Size = New System.Drawing.Size(468, 335)
    CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picImagem As PictureBox
End Class
