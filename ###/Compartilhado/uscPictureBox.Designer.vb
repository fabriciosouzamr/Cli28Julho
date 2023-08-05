<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uscPictureBox
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.picImagem = New System.Windows.Forms.PictureBox()
    Me.pnlBotoes = New System.Windows.Forms.Panel()
    Me.cmdApagarFoto = New System.Windows.Forms.Button()
    Me.cmdObterFoto = New System.Windows.Forms.Button()
    Me.cmdSelecionarFoto = New System.Windows.Forms.Button()
    Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
    Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
    Me.picZoom = New System.Windows.Forms.PictureBox()
        Me.uscPictureBox_Zoom = New uscPictureBox_Zoom()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlBotoes.SuspendLayout()
    CType(Me.picZoom, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picImagem
    '
    Me.picImagem.BackColor = System.Drawing.SystemColors.Control
    Me.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picImagem.Location = New System.Drawing.Point(0, 0)
    Me.picImagem.Name = "picImagem"
    Me.picImagem.Size = New System.Drawing.Size(50, 50)
    Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.picImagem.TabIndex = 3
    Me.picImagem.TabStop = False
    '
    'pnlBotoes
    '
    Me.pnlBotoes.Controls.Add(Me.cmdApagarFoto)
    Me.pnlBotoes.Controls.Add(Me.cmdObterFoto)
    Me.pnlBotoes.Controls.Add(Me.cmdSelecionarFoto)
    Me.pnlBotoes.Location = New System.Drawing.Point(1, 130)
    Me.pnlBotoes.Name = "pnlBotoes"
    Me.pnlBotoes.Size = New System.Drawing.Size(191, 59)
    Me.pnlBotoes.TabIndex = 4
    Me.pnlBotoes.Visible = False
        '
        'cmdApagarFoto
        '
        Me.cmdApagarFoto.Image = My.Resources.Resources.Mini_Excluir2
        Me.cmdApagarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdApagarFoto.Location = New System.Drawing.Point(101, 31)
    Me.cmdApagarFoto.Name = "cmdApagarFoto"
    Me.cmdApagarFoto.Size = New System.Drawing.Size(90, 28)
    Me.cmdApagarFoto.TabIndex = 86
    Me.cmdApagarFoto.TabStop = False
    Me.cmdApagarFoto.Text = "    Excluir Foto"
    Me.cmdApagarFoto.UseVisualStyleBackColor = True
        '
        'cmdObterFoto
        '
        Me.cmdObterFoto.Image = My.Resources.Resources.Mini_Imagem
        Me.cmdObterFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdObterFoto.Location = New System.Drawing.Point(101, 1)
    Me.cmdObterFoto.Name = "cmdObterFoto"
    Me.cmdObterFoto.Size = New System.Drawing.Size(90, 28)
    Me.cmdObterFoto.TabIndex = 85
    Me.cmdObterFoto.TabStop = False
    Me.cmdObterFoto.Text = "   Obter Foto"
    Me.cmdObterFoto.UseVisualStyleBackColor = True
        '
        'cmdSelecionarFoto
        '
        Me.cmdSelecionarFoto.Image = My.Resources.Resources.Mini_Diretorio
        Me.cmdSelecionarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdSelecionarFoto.Location = New System.Drawing.Point(1, 1)
    Me.cmdSelecionarFoto.Name = "cmdSelecionarFoto"
    Me.cmdSelecionarFoto.Size = New System.Drawing.Size(100, 28)
    Me.cmdSelecionarFoto.TabIndex = 84
    Me.cmdSelecionarFoto.TabStop = False
    Me.cmdSelecionarFoto.Text = "    Selecionar foto"
    Me.cmdSelecionarFoto.UseVisualStyleBackColor = True
    '
    'PrintDocument1
    '
    '
    'PrintDialog1
    '
    Me.PrintDialog1.UseEXDialog = True
        '
        'picZoom
        '
        Me.picZoom.Image = My.Resources.Resources.Mini_Pesquisar
        Me.picZoom.Location = New System.Drawing.Point(2, 2)
    Me.picZoom.Name = "picZoom"
    Me.picZoom.Size = New System.Drawing.Size(16, 16)
    Me.picZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picZoom.TabIndex = 5
    Me.picZoom.TabStop = False
    '
    'uscPictureBox_Zoom
    '
    Me.uscPictureBox_Zoom.Location = New System.Drawing.Point(84, 21)
    Me.uscPictureBox_Zoom.Name = "uscPictureBox_Zoom"
    Me.uscPictureBox_Zoom.Size = New System.Drawing.Size(468, 335)
    Me.uscPictureBox_Zoom.TabIndex = 6
    Me.uscPictureBox_Zoom.Visible = False
    '
    'uscPictureBox
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.uscPictureBox_Zoom)
    Me.Controls.Add(Me.picZoom)
    Me.Controls.Add(Me.pnlBotoes)
    Me.Controls.Add(Me.picImagem)
    Me.Name = "uscPictureBox"
    Me.Size = New System.Drawing.Size(191, 219)
    CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlBotoes.ResumeLayout(False)
    CType(Me.picZoom, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents picImagem As System.Windows.Forms.PictureBox
  Friend WithEvents cmdApagarFoto As System.Windows.Forms.Button
  Friend WithEvents cmdObterFoto As System.Windows.Forms.Button
  Friend WithEvents cmdSelecionarFoto As System.Windows.Forms.Button
  Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
  Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
  Private WithEvents pnlBotoes As System.Windows.Forms.Panel
  Friend WithEvents picZoom As PictureBox
  Friend WithEvents uscPictureBox_Zoom As uscPictureBox_Zoom
End Class
