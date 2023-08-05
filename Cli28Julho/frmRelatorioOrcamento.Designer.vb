<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorioOrcamento
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
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoOrcamento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(70, 63)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
        Me.cmdImprimir.TabIndex = 102
        Me.cmdImprimir.Text = "    Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(151, 63)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 103
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Código do Orçamento"
        '
        'txtCodigoOrcamento
        '
        Me.txtCodigoOrcamento.Location = New System.Drawing.Point(5, 20)
        Me.txtCodigoOrcamento.Name = "txtCodigoOrcamento"
        Me.txtCodigoOrcamento.Size = New System.Drawing.Size(110, 20)
        Me.txtCodigoOrcamento.TabIndex = 204
        '
        'frmRelatorioOrcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 98)
        Me.Controls.Add(Me.txtCodigoOrcamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRelatorioOrcamento"
        Me.Text = "Relatório de Orcamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdImprimir As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoOrcamento As TextBox
End Class
