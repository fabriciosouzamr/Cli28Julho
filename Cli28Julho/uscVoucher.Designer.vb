<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscVoucher
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
    Me.components = New System.ComponentModel.Container()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.lblNumeroVoucher = New System.Windows.Forms.Label()
    Me.lblSaldo = New System.Windows.Forms.Label()
    Me.mnuVouvher = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.SuspendLayout()
    '
    'txtCodigo
    '
    Me.txtCodigo.Location = New System.Drawing.Point(21, 0)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(90, 20)
    Me.txtCodigo.TabIndex = 0
    '
    'lblNumeroVoucher
    '
    Me.lblNumeroVoucher.AutoSize = True
    Me.lblNumeroVoucher.ContextMenuStrip = Me.mnuVouvher
    Me.lblNumeroVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumeroVoucher.Location = New System.Drawing.Point(0, 4)
    Me.lblNumeroVoucher.Name = "lblNumeroVoucher"
    Me.lblNumeroVoucher.Size = New System.Drawing.Size(21, 13)
    Me.lblNumeroVoucher.TabIndex = 1
    Me.lblNumeroVoucher.Text = "00"
    '
    'lblSaldo
    '
    Me.lblSaldo.AutoSize = True
    Me.lblSaldo.Location = New System.Drawing.Point(115, 4)
    Me.lblSaldo.Name = "lblSaldo"
    Me.lblSaldo.Size = New System.Drawing.Size(0, 13)
    Me.lblSaldo.TabIndex = 2
    '
    'mnuVouvher
    '
    Me.mnuVouvher.Name = "mnuVouvher"
    '
    'uscVoucher
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lblSaldo)
    Me.Controls.Add(Me.lblNumeroVoucher)
    Me.Controls.Add(Me.txtCodigo)
    Me.Name = "uscVoucher"
    Me.Size = New System.Drawing.Size(183, 21)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtCodigo As TextBox
  Friend WithEvents lblNumeroVoucher As Label
  Friend WithEvents lblSaldo As Label
  Friend WithEvents mnuVouvher As ContextMenuStrip
End Class
