<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoSolicitacaoExameCitologico
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoSolicitacaoExameCitologico))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.lblPaciente = New System.Windows.Forms.Label()
    Me.lblIdade = New System.Windows.Forms.Label()
    Me.txtMedicoExterno = New System.Windows.Forms.TextBox()
    Me.txtColeta = New System.Windows.Forms.TextBox()
    Me.txtUm = New System.Windows.Forms.TextBox()
    Me.txtFilho = New System.Windows.Forms.TextBox()
    Me.txtAborto = New System.Windows.Forms.TextBox()
    Me.txtPara = New System.Windows.Forms.TextBox()
    Me.txtLocalColeta = New System.Windows.Forms.TextBox()
    Me.txtAchadosColposcopicos = New System.Windows.Forms.TextBox()
    Me.optDIU_Sim = New System.Windows.Forms.RadioButton()
    Me.optDIU_Nao = New System.Windows.Forms.RadioButton()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdSalvar = New Cli28Julho.uscBotao()
    Me.lblProntuario = New System.Windows.Forms.Label()
    Me.chkImprimir = New System.Windows.Forms.CheckBox()
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picGeral
    '
    Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
    Me.picGeral.Location = New System.Drawing.Point(5, 5)
    Me.picGeral.Name = "picGeral"
    Me.picGeral.Size = New System.Drawing.Size(679, 210)
    Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picGeral.TabIndex = 0
    Me.picGeral.TabStop = False
    '
    'lblPaciente
    '
    Me.lblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPaciente.Location = New System.Drawing.Point(26, 29)
    Me.lblPaciente.Name = "lblPaciente"
    Me.lblPaciente.Size = New System.Drawing.Size(283, 20)
    Me.lblPaciente.TabIndex = 4
    Me.lblPaciente.Text = "lblPaciente"
    '
    'lblIdade
    '
    Me.lblIdade.AutoSize = True
    Me.lblIdade.Location = New System.Drawing.Point(404, 33)
    Me.lblIdade.Name = "lblIdade"
    Me.lblIdade.Size = New System.Drawing.Size(44, 13)
    Me.lblIdade.TabIndex = 5
    Me.lblIdade.Text = "lblIdade"
    '
    'txtMedicoExterno
    '
    Me.txtMedicoExterno.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtMedicoExterno.Location = New System.Drawing.Point(130, 74)
    Me.txtMedicoExterno.Name = "txtMedicoExterno"
    Me.txtMedicoExterno.Size = New System.Drawing.Size(268, 13)
    Me.txtMedicoExterno.TabIndex = 2
    '
    'txtColeta
    '
    Me.txtColeta.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtColeta.Location = New System.Drawing.Point(27, 117)
    Me.txtColeta.Name = "txtColeta"
    Me.txtColeta.Size = New System.Drawing.Size(91, 13)
    Me.txtColeta.TabIndex = 3
    '
    'txtUm
    '
    Me.txtUm.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtUm.Location = New System.Drawing.Point(129, 117)
    Me.txtUm.Name = "txtUm"
    Me.txtUm.Size = New System.Drawing.Size(90, 13)
    Me.txtUm.TabIndex = 4
    '
    'txtFilho
    '
    Me.txtFilho.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtFilho.Location = New System.Drawing.Point(229, 117)
    Me.txtFilho.Name = "txtFilho"
    Me.txtFilho.Size = New System.Drawing.Size(90, 13)
    Me.txtFilho.TabIndex = 5
    '
    'txtAborto
    '
    Me.txtAborto.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtAborto.Location = New System.Drawing.Point(335, 117)
    Me.txtAborto.Name = "txtAborto"
    Me.txtAborto.Size = New System.Drawing.Size(90, 13)
    Me.txtAborto.TabIndex = 6
    '
    'txtPara
    '
    Me.txtPara.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtPara.Location = New System.Drawing.Point(434, 117)
    Me.txtPara.Name = "txtPara"
    Me.txtPara.Size = New System.Drawing.Size(91, 13)
    Me.txtPara.TabIndex = 7
    '
    'txtLocalColeta
    '
    Me.txtLocalColeta.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtLocalColeta.Location = New System.Drawing.Point(536, 117)
    Me.txtLocalColeta.Name = "txtLocalColeta"
    Me.txtLocalColeta.Size = New System.Drawing.Size(138, 13)
    Me.txtLocalColeta.TabIndex = 8
    '
    'txtAchadosColposcopicos
    '
    Me.txtAchadosColposcopicos.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtAchadosColposcopicos.Location = New System.Drawing.Point(25, 165)
    Me.txtAchadosColposcopicos.Multiline = True
    Me.txtAchadosColposcopicos.Name = "txtAchadosColposcopicos"
    Me.txtAchadosColposcopicos.Size = New System.Drawing.Size(650, 35)
    Me.txtAchadosColposcopicos.TabIndex = 9
    '
    'optDIU_Sim
    '
    Me.optDIU_Sim.AutoSize = True
    Me.optDIU_Sim.Location = New System.Drawing.Point(26, 73)
    Me.optDIU_Sim.Name = "optDIU_Sim"
    Me.optDIU_Sim.Size = New System.Drawing.Size(14, 13)
    Me.optDIU_Sim.TabIndex = 0
    Me.optDIU_Sim.UseVisualStyleBackColor = True
    '
    'optDIU_Nao
    '
    Me.optDIU_Nao.AutoSize = True
    Me.optDIU_Nao.Location = New System.Drawing.Point(74, 73)
    Me.optDIU_Nao.Name = "optDIU_Nao"
    Me.optDIU_Nao.Size = New System.Drawing.Size(14, 13)
    Me.optDIU_Nao.TabIndex = 1
    Me.optDIU_Nao.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.AutoSize = True
    Me.cmdFechar.Location = New System.Drawing.Point(591, 70)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
    Me.cmdFechar.TabIndex = 3
    Me.cmdFechar.TabStop = False
    '
    'cmdImprimir
    '
    Me.cmdImprimir.AutoSize = True
    Me.cmdImprimir.Location = New System.Drawing.Point(503, 70)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
    Me.cmdImprimir.TabIndex = 2
    Me.cmdImprimir.TabStop = False
    '
    'cmdSalvar
    '
    Me.cmdSalvar.AutoSize = True
    Me.cmdSalvar.Location = New System.Drawing.Point(415, 70)
    Me.cmdSalvar.Name = "cmdSalvar"
    Me.cmdSalvar.Size = New System.Drawing.Size(16, 17)
    Me.cmdSalvar.TabIndex = 1
    Me.cmdSalvar.TabStop = False
    '
    'lblProntuario
    '
    Me.lblProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProntuario.Location = New System.Drawing.Point(315, 29)
    Me.lblProntuario.Name = "lblProntuario"
    Me.lblProntuario.Size = New System.Drawing.Size(81, 20)
    Me.lblProntuario.TabIndex = 172
    Me.lblProntuario.Text = "lblProntuario"
    Me.lblProntuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'chkImprimir
    '
    Me.chkImprimir.AutoSize = True
    Me.chkImprimir.Checked = True
    Me.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkImprimir.Location = New System.Drawing.Point(503, 59)
    Me.chkImprimir.Name = "chkImprimir"
    Me.chkImprimir.Size = New System.Drawing.Size(15, 14)
    Me.chkImprimir.TabIndex = 178
    Me.chkImprimir.UseVisualStyleBackColor = True
    '
    'frmCadastroAtendimentoSolicitacaoExameCitologico
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.chkImprimir)
    Me.Controls.Add(Me.lblProntuario)
    Me.Controls.Add(Me.optDIU_Nao)
    Me.Controls.Add(Me.optDIU_Sim)
    Me.Controls.Add(Me.txtAchadosColposcopicos)
    Me.Controls.Add(Me.txtLocalColeta)
    Me.Controls.Add(Me.txtPara)
    Me.Controls.Add(Me.txtAborto)
    Me.Controls.Add(Me.txtFilho)
    Me.Controls.Add(Me.txtUm)
    Me.Controls.Add(Me.txtColeta)
    Me.Controls.Add(Me.txtMedicoExterno)
    Me.Controls.Add(Me.lblIdade)
    Me.Controls.Add(Me.lblPaciente)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.cmdSalvar)
    Me.Controls.Add(Me.picGeral)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmCadastroAtendimentoSolicitacaoExameCitologico"
    Me.Text = "Cadastro de Atendimento - Solicitação de Exame Citológicos"
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdSalvar As uscBotao
  Friend WithEvents cmdImprimir As uscBotao
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents lblPaciente As Label
  Friend WithEvents lblIdade As Label
    Friend WithEvents txtMedicoExterno As TextBox
    Friend WithEvents txtColeta As TextBox
  Friend WithEvents txtUm As TextBox
  Friend WithEvents txtFilho As TextBox
  Friend WithEvents txtAborto As TextBox
  Friend WithEvents txtPara As TextBox
  Friend WithEvents txtLocalColeta As TextBox
  Friend WithEvents txtAchadosColposcopicos As TextBox
    Friend WithEvents optDIU_Sim As RadioButton
    Friend WithEvents optDIU_Nao As RadioButton
    Friend WithEvents lblProntuario As Label
  Friend WithEvents chkImprimir As CheckBox
End Class
