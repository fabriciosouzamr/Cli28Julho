<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRichTextBox_Substituir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Me.cmdSubstituirTudo = New System.Windows.Forms.Button()
    Me.cmdSubstituir = New System.Windows.Forms.Button()
    Me.txtTextoSubstituir = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cmdProxima = New System.Windows.Forms.Button()
    Me.cmdPequisar = New System.Windows.Forms.Button()
    Me.chkMaiusculaMinuscula = New System.Windows.Forms.CheckBox()
    Me.txtTextoPesquisa = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'cmdSubstituirTudo
    '
    Me.cmdSubstituirTudo.Location = New System.Drawing.Point(248, 114)
    Me.cmdSubstituirTudo.Name = "cmdSubstituirTudo"
    Me.cmdSubstituirTudo.Size = New System.Drawing.Size(90, 28)
    Me.cmdSubstituirTudo.TabIndex = 6
    Me.cmdSubstituirTudo.Text = "Substituir tudo"
    Me.cmdSubstituirTudo.UseVisualStyleBackColor = True
    '
    'cmdSubstituir
    '
    Me.cmdSubstituir.Location = New System.Drawing.Point(167, 114)
    Me.cmdSubstituir.Name = "cmdSubstituir"
    Me.cmdSubstituir.Size = New System.Drawing.Size(75, 28)
    Me.cmdSubstituir.TabIndex = 5
    Me.cmdSubstituir.Text = "Substituir"
    Me.cmdSubstituir.UseVisualStyleBackColor = True
    '
    'txtTextoSubstituir
    '
    Me.txtTextoSubstituir.Location = New System.Drawing.Point(5, 61)
    Me.txtTextoSubstituir.Name = "txtTextoSubstituir"
    Me.txtTextoSubstituir.Size = New System.Drawing.Size(333, 20)
    Me.txtTextoSubstituir.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 46)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(71, 13)
    Me.Label2.TabIndex = 19
    Me.Label2.Text = "Substituir por:"
    '
    'cmdProxima
    '
    Me.cmdProxima.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Proxima
    Me.cmdProxima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdProxima.Location = New System.Drawing.Point(86, 114)
    Me.cmdProxima.Name = "cmdProxima"
    Me.cmdProxima.Size = New System.Drawing.Size(75, 28)
    Me.cmdProxima.TabIndex = 4
    Me.cmdProxima.Text = "   Próxima"
    Me.cmdProxima.UseVisualStyleBackColor = True
    '
    'cmdPequisar
    '
    Me.cmdPequisar.Image = Global.UNNO_Sistema.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPequisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPequisar.Location = New System.Drawing.Point(5, 114)
    Me.cmdPequisar.Name = "cmdPequisar"
    Me.cmdPequisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPequisar.TabIndex = 3
    Me.cmdPequisar.Text = "    Pesquisar"
    Me.cmdPequisar.UseVisualStyleBackColor = True
    '
    'chkMaiusculaMinuscula
    '
    Me.chkMaiusculaMinuscula.AutoSize = True
    Me.chkMaiusculaMinuscula.Location = New System.Drawing.Point(5, 87)
    Me.chkMaiusculaMinuscula.Name = "chkMaiusculaMinuscula"
    Me.chkMaiusculaMinuscula.Size = New System.Drawing.Size(192, 17)
    Me.chkMaiusculaMinuscula.TabIndex = 2
    Me.chkMaiusculaMinuscula.Text = "Diferenciar maiúscula de minúscula"
    Me.chkMaiusculaMinuscula.UseVisualStyleBackColor = True
    '
    'txtTextoPesquisa
    '
    Me.txtTextoPesquisa.Location = New System.Drawing.Point(5, 20)
    Me.txtTextoPesquisa.Name = "txtTextoPesquisa"
    Me.txtTextoPesquisa.Size = New System.Drawing.Size(333, 20)
    Me.txtTextoPesquisa.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(74, 13)
    Me.Label1.TabIndex = 20
    Me.Label1.Text = "Pesquisar por:"
    '
    'frmRichTextBox_Substituir
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(343, 146)
    Me.Controls.Add(Me.cmdProxima)
    Me.Controls.Add(Me.cmdPequisar)
    Me.Controls.Add(Me.chkMaiusculaMinuscula)
    Me.Controls.Add(Me.txtTextoPesquisa)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmdSubstituirTudo)
    Me.Controls.Add(Me.cmdSubstituir)
    Me.Controls.Add(Me.txtTextoSubstituir)
    Me.Controls.Add(Me.Label2)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "frmRichTextBox_Substituir"
    Me.Text = "Substituir"
    Me.TopMost = True
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdSubstituirTudo As System.Windows.Forms.Button
  Friend WithEvents cmdSubstituir As System.Windows.Forms.Button
  Friend WithEvents txtTextoSubstituir As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cmdProxima As System.Windows.Forms.Button
  Friend WithEvents cmdPequisar As System.Windows.Forms.Button
  Friend WithEvents chkMaiusculaMinuscula As System.Windows.Forms.CheckBox
  Friend WithEvents txtTextoPesquisa As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
