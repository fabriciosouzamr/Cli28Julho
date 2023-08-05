<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserDialogo_Texto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.lblTitulo = New System.Windows.Forms.Label()
    Me.txtTexto = New System.Windows.Forms.TextBox()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'lblTitulo
    '
    Me.lblTitulo.AutoSize = True
    Me.lblTitulo.Location = New System.Drawing.Point(8, 8)
    Me.lblTitulo.Name = "lblTitulo"
    Me.lblTitulo.Size = New System.Drawing.Size(43, 13)
    Me.lblTitulo.TabIndex = 0
    Me.lblTitulo.Text = "lblTitulo"
    '
    'txtTexto
    '
    Me.txtTexto.Location = New System.Drawing.Point(8, 23)
    Me.txtTexto.Name = "txtTexto"
    Me.txtTexto.Size = New System.Drawing.Size(497, 20)
    Me.txtTexto.TabIndex = 1
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(430, 53)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 46
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(348, 53)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 75
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'frmUserDialogo_Texto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(510, 85)
    Me.ControlBox = False
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.txtTexto)
    Me.Controls.Add(Me.lblTitulo)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmUserDialogo_Texto"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "frmUserDialogo_Texto"
    Me.TopMost = True
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
  Friend WithEvents txtTexto As System.Windows.Forms.TextBox
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
End Class
