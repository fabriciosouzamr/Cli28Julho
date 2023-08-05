<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebCam_Captura
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
    Me.cmdCapturar = New System.Windows.Forms.Button()
    Me.cmdParar = New System.Windows.Forms.Button()
    Me.picFoto = New System.Windows.Forms.PictureBox()
    Me.cboEquipamento = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdCapturar
    '
    Me.cmdCapturar.Image = My.Resources.Resources.Mini_Captura
    Me.cmdCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdCapturar.Location = New System.Drawing.Point(230, 351)
    Me.cmdCapturar.Name = "cmdCapturar"
    Me.cmdCapturar.Size = New System.Drawing.Size(75, 28)
    Me.cmdCapturar.TabIndex = 101
    Me.cmdCapturar.Text = "   Capturar"
    Me.cmdCapturar.UseVisualStyleBackColor = True
    '
    'cmdParar
    '
    Me.cmdParar.Image = My.Resources.Resources.Mini_Parar
    Me.cmdParar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdParar.Location = New System.Drawing.Point(5, 351)
    Me.cmdParar.Name = "cmdParar"
    Me.cmdParar.Size = New System.Drawing.Size(75, 28)
    Me.cmdParar.TabIndex = 100
    Me.cmdParar.Text = "  Parar"
    Me.cmdParar.UseVisualStyleBackColor = True
    '
    'picFoto
    '
    Me.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picFoto.Location = New System.Drawing.Point(5, 45)
    Me.picFoto.Name = "picFoto"
    Me.picFoto.Size = New System.Drawing.Size(300, 300)
    Me.picFoto.TabIndex = 0
    Me.picFoto.TabStop = False
    '
    'cboEquipamento
    '
    Me.cboEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEquipamento.FormattingEnabled = True
    Me.cboEquipamento.Location = New System.Drawing.Point(5, 18)
    Me.cboEquipamento.Name = "cboEquipamento"
    Me.cboEquipamento.Size = New System.Drawing.Size(300, 21)
    Me.cboEquipamento.TabIndex = 1
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(5, 3)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(69, 13)
    Me.Label5.TabIndex = 34
    Me.Label5.Text = "Equipamento"
    '
    'frmWebCam_Captura
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(311, 384)
    Me.ControlBox = False
    Me.Controls.Add(Me.cboEquipamento)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.cmdParar)
    Me.Controls.Add(Me.cmdCapturar)
    Me.Controls.Add(Me.picFoto)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "frmWebCam_Captura"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Captura de Imagem"
    Me.TopMost = True
    CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents picFoto As System.Windows.Forms.PictureBox
  Friend WithEvents cmdCapturar As System.Windows.Forms.Button
  Friend WithEvents cmdParar As System.Windows.Forms.Button
  Friend WithEvents cboEquipamento As System.Windows.Forms.ComboBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
