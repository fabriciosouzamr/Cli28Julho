<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscIndicacao
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscIndicacao))
    Me.lblRIndicacao = New System.Windows.Forms.Label()
    Me.pnlTiposIndicacao = New System.Windows.Forms.Panel()
    Me.picTipoIndicacao_Outros = New System.Windows.Forms.PictureBox()
    Me.picTipoIndicacao_Internet = New System.Windows.Forms.PictureBox()
    Me.picTipoIndicacao_Profissional = New System.Windows.Forms.PictureBox()
    Me.picTipoIndicacao_SitePesquisa = New System.Windows.Forms.PictureBox()
    Me.picTipoIndicacao_Jornal = New System.Windows.Forms.PictureBox()
    Me.picTipoIndicacao_Marketing = New System.Windows.Forms.PictureBox()
    Me.picTipoIndicacao_Cliente = New System.Windows.Forms.PictureBox()
    Me.picTipoIndicacao = New System.Windows.Forms.PictureBox()
    Me.cboIndicacao = New System.Windows.Forms.ComboBox()
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.pnlTiposIndicacao.SuspendLayout()
    CType(Me.picTipoIndicacao_Outros, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picTipoIndicacao_Internet, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picTipoIndicacao_Profissional, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picTipoIndicacao_SitePesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picTipoIndicacao_Jornal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picTipoIndicacao_Marketing, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picTipoIndicacao_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picTipoIndicacao, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblRIndicacao
    '
    Me.lblRIndicacao.AutoSize = True
    Me.lblRIndicacao.Location = New System.Drawing.Point(31, 0)
    Me.lblRIndicacao.Name = "lblRIndicacao"
    Me.lblRIndicacao.Size = New System.Drawing.Size(66, 13)
    Me.lblRIndicacao.TabIndex = 1
    Me.lblRIndicacao.Text = "Indicado por"
    '
    'pnlTiposIndicacao
    '
    Me.pnlTiposIndicacao.Controls.Add(Me.picTipoIndicacao_Outros)
    Me.pnlTiposIndicacao.Controls.Add(Me.picTipoIndicacao_Internet)
    Me.pnlTiposIndicacao.Controls.Add(Me.picTipoIndicacao_Profissional)
    Me.pnlTiposIndicacao.Controls.Add(Me.picTipoIndicacao_SitePesquisa)
    Me.pnlTiposIndicacao.Controls.Add(Me.picTipoIndicacao_Jornal)
    Me.pnlTiposIndicacao.Controls.Add(Me.picTipoIndicacao_Marketing)
    Me.pnlTiposIndicacao.Controls.Add(Me.picTipoIndicacao_Cliente)
    Me.pnlTiposIndicacao.Location = New System.Drawing.Point(1, 40)
    Me.pnlTiposIndicacao.Name = "pnlTiposIndicacao"
    Me.pnlTiposIndicacao.Size = New System.Drawing.Size(225, 30)
    Me.pnlTiposIndicacao.TabIndex = 2
    '
    'picTipoIndicacao_Outros
    '
    Me.picTipoIndicacao_Outros.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
    Me.picTipoIndicacao_Outros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picTipoIndicacao_Outros.Image = CType(resources.GetObject("picTipoIndicacao_Outros.Image"), System.Drawing.Image)
    Me.picTipoIndicacao_Outros.Location = New System.Drawing.Point(192, 0)
    Me.picTipoIndicacao_Outros.Name = "picTipoIndicacao_Outros"
    Me.picTipoIndicacao_Outros.Size = New System.Drawing.Size(28, 28)
    Me.picTipoIndicacao_Outros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
    Me.picTipoIndicacao_Outros.TabIndex = 6
    Me.picTipoIndicacao_Outros.TabStop = False
    Me.ToolTip1.SetToolTip(Me.picTipoIndicacao_Outros, "Indicação de Outros")
    '
    'picTipoIndicacao_Internet
    '
    Me.picTipoIndicacao_Internet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picTipoIndicacao_Internet.Image = CType(resources.GetObject("picTipoIndicacao_Internet.Image"), System.Drawing.Image)
    Me.picTipoIndicacao_Internet.Location = New System.Drawing.Point(96, 2)
    Me.picTipoIndicacao_Internet.Name = "picTipoIndicacao_Internet"
    Me.picTipoIndicacao_Internet.Size = New System.Drawing.Size(30, 26)
    Me.picTipoIndicacao_Internet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picTipoIndicacao_Internet.TabIndex = 5
    Me.picTipoIndicacao_Internet.TabStop = False
    Me.ToolTip1.SetToolTip(Me.picTipoIndicacao_Internet, "Indicação de Páginas de Internet")
    '
    'picTipoIndicacao_Profissional
    '
    Me.picTipoIndicacao_Profissional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picTipoIndicacao_Profissional.Image = CType(resources.GetObject("picTipoIndicacao_Profissional.Image"), System.Drawing.Image)
    Me.picTipoIndicacao_Profissional.Location = New System.Drawing.Point(128, 0)
    Me.picTipoIndicacao_Profissional.Name = "picTipoIndicacao_Profissional"
    Me.picTipoIndicacao_Profissional.Size = New System.Drawing.Size(30, 30)
    Me.picTipoIndicacao_Profissional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picTipoIndicacao_Profissional.TabIndex = 4
    Me.picTipoIndicacao_Profissional.TabStop = False
    Me.ToolTip1.SetToolTip(Me.picTipoIndicacao_Profissional, "Indicação de Profissional")
    '
    'picTipoIndicacao_SitePesquisa
    '
    Me.picTipoIndicacao_SitePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picTipoIndicacao_SitePesquisa.Image = CType(resources.GetObject("picTipoIndicacao_SitePesquisa.Image"), System.Drawing.Image)
    Me.picTipoIndicacao_SitePesquisa.Location = New System.Drawing.Point(64, 0)
    Me.picTipoIndicacao_SitePesquisa.Name = "picTipoIndicacao_SitePesquisa"
    Me.picTipoIndicacao_SitePesquisa.Size = New System.Drawing.Size(30, 30)
    Me.picTipoIndicacao_SitePesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picTipoIndicacao_SitePesquisa.TabIndex = 3
    Me.picTipoIndicacao_SitePesquisa.TabStop = False
    Me.ToolTip1.SetToolTip(Me.picTipoIndicacao_SitePesquisa, "Indicação por Site de Pesquisa")
    '
    'picTipoIndicacao_Jornal
    '
    Me.picTipoIndicacao_Jornal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picTipoIndicacao_Jornal.Image = CType(resources.GetObject("picTipoIndicacao_Jornal.Image"), System.Drawing.Image)
    Me.picTipoIndicacao_Jornal.Location = New System.Drawing.Point(160, 0)
    Me.picTipoIndicacao_Jornal.Name = "picTipoIndicacao_Jornal"
    Me.picTipoIndicacao_Jornal.Size = New System.Drawing.Size(30, 30)
    Me.picTipoIndicacao_Jornal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picTipoIndicacao_Jornal.TabIndex = 2
    Me.picTipoIndicacao_Jornal.TabStop = False
    Me.ToolTip1.SetToolTip(Me.picTipoIndicacao_Jornal, "Indicação de Jornal")
    '
    'picTipoIndicacao_Marketing
    '
    Me.picTipoIndicacao_Marketing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picTipoIndicacao_Marketing.Image = CType(resources.GetObject("picTipoIndicacao_Marketing.Image"), System.Drawing.Image)
    Me.picTipoIndicacao_Marketing.Location = New System.Drawing.Point(32, 0)
    Me.picTipoIndicacao_Marketing.Name = "picTipoIndicacao_Marketing"
    Me.picTipoIndicacao_Marketing.Size = New System.Drawing.Size(30, 30)
    Me.picTipoIndicacao_Marketing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picTipoIndicacao_Marketing.TabIndex = 1
    Me.picTipoIndicacao_Marketing.TabStop = False
    Me.ToolTip1.SetToolTip(Me.picTipoIndicacao_Marketing, "Indicação por Marketing")
    '
    'picTipoIndicacao_Cliente
    '
    Me.picTipoIndicacao_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picTipoIndicacao_Cliente.Image = CType(resources.GetObject("picTipoIndicacao_Cliente.Image"), System.Drawing.Image)
    Me.picTipoIndicacao_Cliente.Location = New System.Drawing.Point(0, 0)
    Me.picTipoIndicacao_Cliente.Name = "picTipoIndicacao_Cliente"
    Me.picTipoIndicacao_Cliente.Size = New System.Drawing.Size(30, 30)
    Me.picTipoIndicacao_Cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picTipoIndicacao_Cliente.TabIndex = 0
    Me.picTipoIndicacao_Cliente.TabStop = False
    Me.ToolTip1.SetToolTip(Me.picTipoIndicacao_Cliente, "Indicação de Clientes")
    '
    'picTipoIndicacao
    '
    Me.picTipoIndicacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
    Me.picTipoIndicacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.picTipoIndicacao.Location = New System.Drawing.Point(1, 8)
    Me.picTipoIndicacao.Name = "picTipoIndicacao"
    Me.picTipoIndicacao.Size = New System.Drawing.Size(28, 28)
    Me.picTipoIndicacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
    Me.picTipoIndicacao.TabIndex = 6
    Me.picTipoIndicacao.TabStop = False
    '
    'cboIndicacao
    '
    Me.cboIndicacao.FormattingEnabled = True
    Me.cboIndicacao.Location = New System.Drawing.Point(31, 15)
    Me.cboIndicacao.Name = "cboIndicacao"
    Me.cboIndicacao.Size = New System.Drawing.Size(195, 21)
    Me.cboIndicacao.TabIndex = 7
    '
    'uscIndicacao
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.cboIndicacao)
    Me.Controls.Add(Me.picTipoIndicacao)
    Me.Controls.Add(Me.pnlTiposIndicacao)
    Me.Controls.Add(Me.lblRIndicacao)
    Me.Name = "uscIndicacao"
    Me.Size = New System.Drawing.Size(226, 80)
    Me.pnlTiposIndicacao.ResumeLayout(False)
    Me.pnlTiposIndicacao.PerformLayout()
    CType(Me.picTipoIndicacao_Outros, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picTipoIndicacao_Internet, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picTipoIndicacao_Profissional, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picTipoIndicacao_SitePesquisa, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picTipoIndicacao_Jornal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picTipoIndicacao_Marketing, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picTipoIndicacao_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picTipoIndicacao, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblRIndicacao As System.Windows.Forms.Label
  Friend WithEvents pnlTiposIndicacao As System.Windows.Forms.Panel
  Friend WithEvents picTipoIndicacao_Cliente As System.Windows.Forms.PictureBox
  Friend WithEvents picTipoIndicacao_Marketing As System.Windows.Forms.PictureBox
  Friend WithEvents picTipoIndicacao_Jornal As System.Windows.Forms.PictureBox
  Friend WithEvents picTipoIndicacao_SitePesquisa As System.Windows.Forms.PictureBox
  Friend WithEvents picTipoIndicacao_Profissional As System.Windows.Forms.PictureBox
  Friend WithEvents picTipoIndicacao_Outros As System.Windows.Forms.PictureBox
  Friend WithEvents picTipoIndicacao_Internet As System.Windows.Forms.PictureBox
  Friend WithEvents picTipoIndicacao As System.Windows.Forms.PictureBox
  Friend WithEvents cboIndicacao As System.Windows.Forms.ComboBox
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
