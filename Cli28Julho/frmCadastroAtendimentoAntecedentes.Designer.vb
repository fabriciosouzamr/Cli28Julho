<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoAntecedentes
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoAntecedentes))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.cmdSalvar = New Cli28Julho.uscBotao()
    Me.lblMedico = New System.Windows.Forms.Label()
    Me.lblData = New System.Windows.Forms.Label()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.optPessoal = New System.Windows.Forms.RadioButton()
    Me.optFamiliar = New System.Windows.Forms.RadioButton()
    Me.rtbDescricao = New System.Windows.Forms.RichTextBox()
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picGeral
    '
    Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
    Me.picGeral.Location = New System.Drawing.Point(5, 5)
    Me.picGeral.Name = "picGeral"
    Me.picGeral.Size = New System.Drawing.Size(697, 191)
    Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picGeral.TabIndex = 0
    Me.picGeral.TabStop = False
    '
    'cmdSalvar
    '
    Me.cmdSalvar.AutoSize = True
    Me.cmdSalvar.Location = New System.Drawing.Point(575, 95)
    Me.cmdSalvar.Name = "cmdSalvar"
    Me.cmdSalvar.Size = New System.Drawing.Size(16, 15)
    Me.cmdSalvar.TabIndex = 1
    '
    'lblMedico
    '
    Me.lblMedico.AutoSize = True
    Me.lblMedico.Location = New System.Drawing.Point(24, 32)
    Me.lblMedico.Name = "lblMedico"
    Me.lblMedico.Size = New System.Drawing.Size(52, 13)
    Me.lblMedico.TabIndex = 2
    Me.lblMedico.Text = "lblMedico"
    '
    'lblData
    '
    Me.lblData.AutoSize = True
    Me.lblData.Location = New System.Drawing.Point(405, 32)
    Me.lblData.Name = "lblData"
    Me.lblData.Size = New System.Drawing.Size(40, 13)
    Me.lblData.TabIndex = 3
    Me.lblData.Text = "lblData"
    '
    'cmdImprimir
    '
    Me.cmdImprimir.AutoSize = True
    Me.cmdImprimir.Location = New System.Drawing.Point(575, 124)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(16, 15)
    Me.cmdImprimir.TabIndex = 4
    '
    'cmdFechar
    '
    Me.cmdFechar.AutoSize = True
    Me.cmdFechar.Location = New System.Drawing.Point(575, 152)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(16, 15)
    Me.cmdFechar.TabIndex = 5
    '
    'optPessoal
    '
    Me.optPessoal.AutoSize = True
    Me.optPessoal.Checked = True
    Me.optPessoal.Location = New System.Drawing.Point(524, 119)
    Me.optPessoal.Name = "optPessoal"
    Me.optPessoal.Size = New System.Drawing.Size(14, 13)
    Me.optPessoal.TabIndex = 6
    Me.optPessoal.TabStop = True
    Me.optPessoal.UseVisualStyleBackColor = True
    '
    'optFamiliar
    '
    Me.optFamiliar.AutoSize = True
    Me.optFamiliar.Location = New System.Drawing.Point(524, 153)
    Me.optFamiliar.Name = "optFamiliar"
    Me.optFamiliar.Size = New System.Drawing.Size(14, 13)
    Me.optFamiliar.TabIndex = 7
    Me.optFamiliar.TabStop = True
    Me.optFamiliar.UseVisualStyleBackColor = True
    '
    'rtbDescricao
    '
    Me.rtbDescricao.BackColor = System.Drawing.SystemColors.Window
    Me.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.rtbDescricao.Location = New System.Drawing.Point(26, 74)
    Me.rtbDescricao.Name = "rtbDescricao"
    Me.rtbDescricao.Size = New System.Drawing.Size(453, 109)
    Me.rtbDescricao.TabIndex = 8
    Me.rtbDescricao.Text = ""
    '
    'frmCadastroAtendimentoAntecedentes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.rtbDescricao)
    Me.Controls.Add(Me.optFamiliar)
    Me.Controls.Add(Me.optPessoal)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.lblData)
    Me.Controls.Add(Me.lblMedico)
    Me.Controls.Add(Me.cmdSalvar)
    Me.Controls.Add(Me.picGeral)
    Me.MaximizeBox = False
    Me.Name = "frmCadastroAtendimentoAntecedentes"
    Me.Text = "Cadastro de Atendimento - Antecedentes"
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdSalvar As uscBotao
  Friend WithEvents lblMedico As Label
  Friend WithEvents lblData As Label
  Friend WithEvents cmdImprimir As uscBotao
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents optPessoal As RadioButton
  Friend WithEvents optFamiliar As RadioButton
  Friend WithEvents rtbDescricao As RichTextBox
End Class
