<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscTexto_Telefone
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.txtTelefone = New System.Windows.Forms.TextBox()
    Me.SuspendLayout()
    '
    'txtTelefone
    '
    Me.txtTelefone.Location = New System.Drawing.Point(0, 0)
    Me.txtTelefone.Name = "txtTelefone"
    Me.txtTelefone.Size = New System.Drawing.Size(90, 20)
    Me.txtTelefone.TabIndex = 0
    '
    'uscTexto_Telefone
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.Controls.Add(Me.txtTelefone)
    Me.Name = "uscTexto_Telefone"
    Me.Size = New System.Drawing.Size(90, 20)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtTelefone As System.Windows.Forms.TextBox

End Class
