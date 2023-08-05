<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscTexto_CEP
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
    Me.txtCEP = New System.Windows.Forms.TextBox()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'txtCEP
    '
    Me.txtCEP.Location = New System.Drawing.Point(0, 0)
    Me.txtCEP.MaxLength = 10
    Me.txtCEP.Name = "txtCEP"
    Me.txtCEP.Size = New System.Drawing.Size(68, 20)
    Me.txtCEP.TabIndex = 0
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.SisMattos.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.Location = New System.Drawing.Point(68, 0)
    Me.cmdPesquisar.Margin = New System.Windows.Forms.Padding(0)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(21, 21)
    Me.cmdPesquisar.TabIndex = 2
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'uscTexto_CEP
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.txtCEP)
    Me.Name = "uscTexto_CEP"
    Me.Size = New System.Drawing.Size(89, 20)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtCEP As System.Windows.Forms.TextBox
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button

End Class
