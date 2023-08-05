<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroVenda
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
    Me.uscCadastroVenda = New Cli28Julho.uscCadastroVenda()
        Me.SuspendLayout()
        '
        'uscCadastroVenda
        '
        Me.uscCadastroVenda.Location = New System.Drawing.Point(1, 1)
        Me.uscCadastroVenda.Name = "uscCadastroVenda"
        Me.uscCadastroVenda.Size = New System.Drawing.Size(627, 527)
        Me.uscCadastroVenda.TabIndex = 0
        '
        'frmCadastroVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 530)
        Me.Controls.Add(Me.uscCadastroVenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCadastroVenda"
        Me.Text = "Cadastro de Venda"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents uscCadastroVenda As uscCadastroVenda
End Class
