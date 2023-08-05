<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscPesqServico
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
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cboServico = New System.Windows.Forms.ComboBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.SisMattos.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.Location = New System.Drawing.Point(0, 15)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(21, 21)
    Me.cmdPesquisar.TabIndex = 235
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'cboProduto
    '
    Me.cboServico.DropDownWidth = 800
    Me.cboServico.FormattingEnabled = True
    Me.cboServico.Location = New System.Drawing.Point(23, 15)
    Me.cboServico.Name = "cboProduto"
    Me.cboServico.Size = New System.Drawing.Size(440, 21)
    Me.cboServico.TabIndex = 233
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(0, 0)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(43, 13)
    Me.Label10.TabIndex = 234
    Me.Label10.Text = "Serviço"
    '
    'uscPesqServico
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.cboServico)
    Me.Controls.Add(Me.Label10)
    Me.Name = "uscPesqServico"
    Me.Size = New System.Drawing.Size(465, 36)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents cboServico As System.Windows.Forms.ComboBox
  Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
