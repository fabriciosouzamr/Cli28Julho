<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImagem_Visualizador
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.pnlOpcao = New System.Windows.Forms.Panel()
    Me.cmdLupar = New System.Windows.Forms.Button()
    Me.pnlImagem = New System.Windows.Forms.Panel()
    Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.uscPictureBox_Zoom = New uscPictureBox_Zoom()
        Me.pnlOpcao.SuspendLayout()
    Me.pnlImagem.SuspendLayout()
    CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlOpcao
    '
    Me.pnlOpcao.Controls.Add(Me.cmdLupar)
    Me.pnlOpcao.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnlOpcao.Location = New System.Drawing.Point(0, 426)
    Me.pnlOpcao.Name = "pnlOpcao"
    Me.pnlOpcao.Size = New System.Drawing.Size(708, 27)
    Me.pnlOpcao.TabIndex = 0
        '
        'cmdLupar
        '
        Me.cmdLupar.Image = My.Resources.Resources.Mini_Lupa
        Me.cmdLupar.Location = New System.Drawing.Point(1, 1)
    Me.cmdLupar.Name = "cmdLupar"
    Me.cmdLupar.Size = New System.Drawing.Size(24, 24)
    Me.cmdLupar.TabIndex = 5
    Me.cmdLupar.UseVisualStyleBackColor = True
    '
    'pnlImagem
    '
    Me.pnlImagem.AutoScroll = True
    Me.pnlImagem.Controls.Add(Me.uscPictureBox_Zoom)
    Me.pnlImagem.Controls.Add(Me.picImagem)
    Me.pnlImagem.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlImagem.Location = New System.Drawing.Point(0, 0)
    Me.pnlImagem.Name = "pnlImagem"
    Me.pnlImagem.Size = New System.Drawing.Size(708, 426)
    Me.pnlImagem.TabIndex = 1
    '
    'picImagem
    '
    Me.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picImagem.Location = New System.Drawing.Point(0, 2)
    Me.picImagem.Name = "picImagem"
    Me.picImagem.Size = New System.Drawing.Size(353, 424)
    Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picImagem.TabIndex = 4
    Me.picImagem.TabStop = False
    '
    'uscPictureBox_Zoom
    '
    Me.uscPictureBox_Zoom.Location = New System.Drawing.Point(395, 59)
    Me.uscPictureBox_Zoom.Name = "uscPictureBox_Zoom"
    Me.uscPictureBox_Zoom.Size = New System.Drawing.Size(243, 213)
    Me.uscPictureBox_Zoom.TabIndex = 5
    Me.uscPictureBox_Zoom.Visible = False
    '
    'frmImagem_Visualizador
    '
    Me.AllowDrop = True
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoScroll = True
    Me.ClientSize = New System.Drawing.Size(708, 453)
    Me.Controls.Add(Me.pnlImagem)
    Me.Controls.Add(Me.pnlOpcao)
    Me.Name = "frmImagem_Visualizador"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Visualizador de Imagem"
    Me.pnlOpcao.ResumeLayout(False)
    Me.pnlImagem.ResumeLayout(False)
    CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents pnlOpcao As System.Windows.Forms.Panel
  Friend WithEvents pnlImagem As System.Windows.Forms.Panel
  Friend WithEvents picImagem As System.Windows.Forms.PictureBox
  Friend WithEvents cmdLupar As Button
  Friend WithEvents uscPictureBox_Zoom As uscPictureBox_Zoom
End Class
