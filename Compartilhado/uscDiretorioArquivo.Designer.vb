<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscDiretorioArquivo
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
    Me.cmdAbrirDiretorioArquivo = New System.Windows.Forms.Button()
    Me.txtDiretorioArquivo = New System.Windows.Forms.TextBox()
    Me.lblRDiretorioArquivo = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'cmdAbrirDiretorioArquivo
    '
    Me.cmdAbrirDiretorioArquivo.Image = Global.SisMattos.My.Resources.Resources.Mini_Diretorio
    Me.cmdAbrirDiretorioArquivo.Location = New System.Drawing.Point(0, 15)
    Me.cmdAbrirDiretorioArquivo.Name = "cmdAbrirDiretorioArquivo"
    Me.cmdAbrirDiretorioArquivo.Size = New System.Drawing.Size(20, 20)
    Me.cmdAbrirDiretorioArquivo.TabIndex = 102
    Me.cmdAbrirDiretorioArquivo.UseVisualStyleBackColor = True
    '
    'txtDiretorioArquivo
    '
    Me.txtDiretorioArquivo.Location = New System.Drawing.Point(22, 15)
    Me.txtDiretorioArquivo.MaxLength = 100
    Me.txtDiretorioArquivo.Name = "txtDiretorioArquivo"
    Me.txtDiretorioArquivo.Size = New System.Drawing.Size(654, 20)
    Me.txtDiretorioArquivo.TabIndex = 103
    '
    'lblRDiretorioArquivo
    '
    Me.lblRDiretorioArquivo.AutoSize = True
    Me.lblRDiretorioArquivo.Location = New System.Drawing.Point(0, 0)
    Me.lblRDiretorioArquivo.Name = "lblRDiretorioArquivo"
    Me.lblRDiretorioArquivo.Size = New System.Drawing.Size(157, 13)
    Me.lblRDiretorioArquivo.TabIndex = 101
    Me.lblRDiretorioArquivo.Text = "Diretório de Imagens e Arquivos"
    '
    'uscDiretorioArquivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.cmdAbrirDiretorioArquivo)
    Me.Controls.Add(Me.txtDiretorioArquivo)
    Me.Controls.Add(Me.lblRDiretorioArquivo)
    Me.MaximumSize = New System.Drawing.Size(1000, 35)
    Me.MinimumSize = New System.Drawing.Size(300, 35)
    Me.Name = "uscDiretorioArquivo"
    Me.Size = New System.Drawing.Size(676, 35)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cmdAbrirDiretorioArquivo As Button
  Friend WithEvents txtDiretorioArquivo As TextBox
  Friend WithEvents lblRDiretorioArquivo As Label
End Class
