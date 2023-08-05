<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVendaCancelamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaVendaCancelamento))
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMotivoCancelamento = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(632, 215)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 185
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = CType(resources.GetObject("cmdFechar.Image"), System.Drawing.Image)
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(713, 215)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 186
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "Motivo"
        '
        'txtMotivoCancelamento
        '
        Me.txtMotivoCancelamento.Location = New System.Drawing.Point(4, 19)
        Me.txtMotivoCancelamento.MaxLength = 8000
        Me.txtMotivoCancelamento.Multiline = True
        Me.txtMotivoCancelamento.Name = "txtMotivoCancelamento"
        Me.txtMotivoCancelamento.Size = New System.Drawing.Size(784, 186)
        Me.txtMotivoCancelamento.TabIndex = 188
        '
        'frmConsultaVendaCancelamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 248)
        Me.Controls.Add(Me.txtMotivoCancelamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.MaximizeBox = False
        Me.Name = "frmConsultaVendaCancelamento"
        Me.Text = "Cancelamento de Vendas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMotivoCancelamento As TextBox
End Class
