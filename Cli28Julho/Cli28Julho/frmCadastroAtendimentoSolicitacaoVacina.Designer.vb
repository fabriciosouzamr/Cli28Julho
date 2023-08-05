<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoSolicitacaoVacina
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoSolicitacaoVacina))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.lblPaciente = New System.Windows.Forms.Label()
    Me.lblIdade = New System.Windows.Forms.Label()
    Me.cmdSalvar = New Cli28Julho.uscBotao()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.txtDataVacina = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.cboVacina = New System.Windows.Forms.ComboBox()
    Me.txtDosagem = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.txtObservacao = New System.Windows.Forms.TextBox()
    Me.lblData01 = New System.Windows.Forms.Label()
    Me.lblVacina01 = New System.Windows.Forms.Label()
    Me.lblDosagem01 = New System.Windows.Forms.Label()
    Me.lblObservacao01 = New System.Windows.Forms.Label()
    Me.lblObservacao02 = New System.Windows.Forms.Label()
    Me.lblDosagem02 = New System.Windows.Forms.Label()
    Me.lblVacina02 = New System.Windows.Forms.Label()
    Me.lblData02 = New System.Windows.Forms.Label()
    Me.lblObservacao03 = New System.Windows.Forms.Label()
    Me.lblDosagem03 = New System.Windows.Forms.Label()
    Me.lblVacina03 = New System.Windows.Forms.Label()
    Me.lblData03 = New System.Windows.Forms.Label()
    Me.lblObservacao04 = New System.Windows.Forms.Label()
    Me.lblDosagem04 = New System.Windows.Forms.Label()
    Me.lblVacina04 = New System.Windows.Forms.Label()
    Me.lblData04 = New System.Windows.Forms.Label()
    Me.lblObservacao05 = New System.Windows.Forms.Label()
    Me.lblDosagem05 = New System.Windows.Forms.Label()
    Me.lblVacina05 = New System.Windows.Forms.Label()
    Me.lblData05 = New System.Windows.Forms.Label()
    Me.lblObservacao06 = New System.Windows.Forms.Label()
    Me.lblDosagem06 = New System.Windows.Forms.Label()
    Me.lblVacina06 = New System.Windows.Forms.Label()
    Me.lblData06 = New System.Windows.Forms.Label()
    Me.lblObservacao07 = New System.Windows.Forms.Label()
    Me.lblDosagem07 = New System.Windows.Forms.Label()
    Me.lblVacina07 = New System.Windows.Forms.Label()
    Me.lblData07 = New System.Windows.Forms.Label()
    Me.lblObservacao08 = New System.Windows.Forms.Label()
    Me.lblDosagem08 = New System.Windows.Forms.Label()
    Me.lblVacina08 = New System.Windows.Forms.Label()
    Me.lblData08 = New System.Windows.Forms.Label()
    Me.lblObservacao09 = New System.Windows.Forms.Label()
    Me.lblDosagem09 = New System.Windows.Forms.Label()
    Me.lblVacina09 = New System.Windows.Forms.Label()
    Me.lblData09 = New System.Windows.Forms.Label()
    Me.VScrollBar = New System.Windows.Forms.VScrollBar()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataVacina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDosagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(807, 495)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(15, 37)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(59, 13)
        Me.lblPaciente.TabIndex = 1
        Me.lblPaciente.Text = "lblPaciente"
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Location = New System.Drawing.Point(383, 37)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(44, 13)
        Me.lblIdade.TabIndex = 2
        Me.lblIdade.Text = "lblIdade"
        '
        'cmdSalvar
        '
        Me.cmdSalvar.AutoSize = True
        Me.cmdSalvar.Location = New System.Drawing.Point(69, 71)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(16, 17)
        Me.cmdSalvar.TabIndex = 3
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AutoSize = True
        Me.cmdImprimir.Location = New System.Drawing.Point(161, 71)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
        Me.cmdImprimir.TabIndex = 4
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(254, 71)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 5
        '
        'txtDataVacina
        '
        Me.txtDataVacina.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDataVacina.Location = New System.Drawing.Point(5, 133)
        Me.txtDataVacina.Name = "txtDataVacina"
        Me.txtDataVacina.Size = New System.Drawing.Size(89, 17)
        Me.txtDataVacina.TabIndex = 162
        '
        'cboVacina
        '
        Me.cboVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVacina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVacina.FormattingEnabled = True
        Me.cboVacina.Location = New System.Drawing.Point(101, 131)
        Me.cboVacina.Name = "cboVacina"
        Me.cboVacina.Size = New System.Drawing.Size(267, 21)
        Me.cboVacina.TabIndex = 163
        '
        'txtDosagem
        '
        Me.txtDosagem.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDosagem.Location = New System.Drawing.Point(407, 133)
        Me.txtDosagem.Name = "txtDosagem"
        Me.txtDosagem.Size = New System.Drawing.Size(100, 17)
        Me.txtDosagem.TabIndex = 164
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao.Location = New System.Drawing.Point(517, 135)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(249, 13)
        Me.txtObservacao.TabIndex = 165
        '
        'lblData01
        '
        Me.lblData01.AutoSize = True
        Me.lblData01.Location = New System.Drawing.Point(11, 235)
        Me.lblData01.Name = "lblData01"
        Me.lblData01.Size = New System.Drawing.Size(52, 13)
        Me.lblData01.TabIndex = 166
        Me.lblData01.Text = "lblData01"
        '
        'lblVacina01
        '
        Me.lblVacina01.Location = New System.Drawing.Point(102, 235)
        Me.lblVacina01.Name = "lblVacina01"
        Me.lblVacina01.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina01.TabIndex = 167
        Me.lblVacina01.Text = "lblVacina01"
        '
        'lblDosagem01
        '
        Me.lblDosagem01.AutoSize = True
        Me.lblDosagem01.Location = New System.Drawing.Point(375, 235)
        Me.lblDosagem01.Name = "lblDosagem01"
        Me.lblDosagem01.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem01.TabIndex = 168
        Me.lblDosagem01.Text = "lblDosagem01"
        '
        'lblObservacao01
        '
        Me.lblObservacao01.Location = New System.Drawing.Point(516, 235)
        Me.lblObservacao01.Name = "lblObservacao01"
        Me.lblObservacao01.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao01.TabIndex = 169
        Me.lblObservacao01.Text = "lblObservacao01"
        '
        'lblObservacao02
        '
        Me.lblObservacao02.Location = New System.Drawing.Point(516, 267)
        Me.lblObservacao02.Name = "lblObservacao02"
        Me.lblObservacao02.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao02.TabIndex = 173
        Me.lblObservacao02.Text = "lblObservacao01"
        '
        'lblDosagem02
        '
        Me.lblDosagem02.AutoSize = True
        Me.lblDosagem02.Location = New System.Drawing.Point(375, 267)
        Me.lblDosagem02.Name = "lblDosagem02"
        Me.lblDosagem02.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem02.TabIndex = 172
        Me.lblDosagem02.Text = "lblDosagem01"
        '
        'lblVacina02
        '
        Me.lblVacina02.Location = New System.Drawing.Point(102, 267)
        Me.lblVacina02.Name = "lblVacina02"
        Me.lblVacina02.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina02.TabIndex = 171
        Me.lblVacina02.Text = "lblVacina01"
        '
        'lblData02
        '
        Me.lblData02.AutoSize = True
        Me.lblData02.Location = New System.Drawing.Point(11, 267)
        Me.lblData02.Name = "lblData02"
        Me.lblData02.Size = New System.Drawing.Size(52, 13)
        Me.lblData02.TabIndex = 170
        Me.lblData02.Text = "lblData01"
        '
        'lblObservacao03
        '
        Me.lblObservacao03.Location = New System.Drawing.Point(516, 296)
        Me.lblObservacao03.Name = "lblObservacao03"
        Me.lblObservacao03.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao03.TabIndex = 177
        Me.lblObservacao03.Text = "lblObservacao01"
        '
        'lblDosagem03
        '
        Me.lblDosagem03.AutoSize = True
        Me.lblDosagem03.Location = New System.Drawing.Point(375, 296)
        Me.lblDosagem03.Name = "lblDosagem03"
        Me.lblDosagem03.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem03.TabIndex = 176
        Me.lblDosagem03.Text = "lblDosagem01"
        '
        'lblVacina03
        '
        Me.lblVacina03.Location = New System.Drawing.Point(102, 296)
        Me.lblVacina03.Name = "lblVacina03"
        Me.lblVacina03.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina03.TabIndex = 175
        Me.lblVacina03.Text = "lblVacina01"
        '
        'lblData03
        '
        Me.lblData03.AutoSize = True
        Me.lblData03.Location = New System.Drawing.Point(11, 296)
        Me.lblData03.Name = "lblData03"
        Me.lblData03.Size = New System.Drawing.Size(52, 13)
        Me.lblData03.TabIndex = 174
        Me.lblData03.Text = "lblData01"
        '
        'lblObservacao04
        '
        Me.lblObservacao04.Location = New System.Drawing.Point(516, 327)
        Me.lblObservacao04.Name = "lblObservacao04"
        Me.lblObservacao04.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao04.TabIndex = 181
        Me.lblObservacao04.Text = "lblObservacao01"
        '
        'lblDosagem04
        '
        Me.lblDosagem04.AutoSize = True
        Me.lblDosagem04.Location = New System.Drawing.Point(375, 327)
        Me.lblDosagem04.Name = "lblDosagem04"
        Me.lblDosagem04.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem04.TabIndex = 180
        Me.lblDosagem04.Text = "lblDosagem01"
        '
        'lblVacina04
        '
        Me.lblVacina04.Location = New System.Drawing.Point(102, 327)
        Me.lblVacina04.Name = "lblVacina04"
        Me.lblVacina04.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina04.TabIndex = 179
        Me.lblVacina04.Text = "lblVacina01"
        '
        'lblData04
        '
        Me.lblData04.AutoSize = True
        Me.lblData04.Location = New System.Drawing.Point(11, 327)
        Me.lblData04.Name = "lblData04"
        Me.lblData04.Size = New System.Drawing.Size(52, 13)
        Me.lblData04.TabIndex = 178
        Me.lblData04.Text = "lblData01"
        '
        'lblObservacao05
        '
        Me.lblObservacao05.Location = New System.Drawing.Point(516, 358)
        Me.lblObservacao05.Name = "lblObservacao05"
        Me.lblObservacao05.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao05.TabIndex = 185
        Me.lblObservacao05.Text = "lblObservacao01"
        '
        'lblDosagem05
        '
        Me.lblDosagem05.AutoSize = True
        Me.lblDosagem05.Location = New System.Drawing.Point(375, 358)
        Me.lblDosagem05.Name = "lblDosagem05"
        Me.lblDosagem05.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem05.TabIndex = 184
        Me.lblDosagem05.Text = "lblDosagem01"
        '
        'lblVacina05
        '
        Me.lblVacina05.Location = New System.Drawing.Point(102, 358)
        Me.lblVacina05.Name = "lblVacina05"
        Me.lblVacina05.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina05.TabIndex = 183
        Me.lblVacina05.Text = "lblVacina01"
        '
        'lblData05
        '
        Me.lblData05.AutoSize = True
        Me.lblData05.Location = New System.Drawing.Point(11, 358)
        Me.lblData05.Name = "lblData05"
        Me.lblData05.Size = New System.Drawing.Size(52, 13)
        Me.lblData05.TabIndex = 182
        Me.lblData05.Text = "lblData01"
        '
        'lblObservacao06
        '
        Me.lblObservacao06.Location = New System.Drawing.Point(516, 388)
        Me.lblObservacao06.Name = "lblObservacao06"
        Me.lblObservacao06.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao06.TabIndex = 189
        Me.lblObservacao06.Text = "lblObservacao01"
        '
        'lblDosagem06
        '
        Me.lblDosagem06.AutoSize = True
        Me.lblDosagem06.Location = New System.Drawing.Point(375, 388)
        Me.lblDosagem06.Name = "lblDosagem06"
        Me.lblDosagem06.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem06.TabIndex = 188
        Me.lblDosagem06.Text = "lblDosagem01"
        '
        'lblVacina06
        '
        Me.lblVacina06.Location = New System.Drawing.Point(102, 388)
        Me.lblVacina06.Name = "lblVacina06"
        Me.lblVacina06.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina06.TabIndex = 187
        Me.lblVacina06.Text = "lblVacina01"
        '
        'lblData06
        '
        Me.lblData06.AutoSize = True
        Me.lblData06.Location = New System.Drawing.Point(11, 388)
        Me.lblData06.Name = "lblData06"
        Me.lblData06.Size = New System.Drawing.Size(52, 13)
        Me.lblData06.TabIndex = 186
        Me.lblData06.Text = "lblData01"
        '
        'lblObservacao07
        '
        Me.lblObservacao07.Location = New System.Drawing.Point(516, 419)
        Me.lblObservacao07.Name = "lblObservacao07"
        Me.lblObservacao07.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao07.TabIndex = 193
        Me.lblObservacao07.Text = "lblObservacao01"
        '
        'lblDosagem07
        '
        Me.lblDosagem07.AutoSize = True
        Me.lblDosagem07.Location = New System.Drawing.Point(375, 419)
        Me.lblDosagem07.Name = "lblDosagem07"
        Me.lblDosagem07.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem07.TabIndex = 192
        Me.lblDosagem07.Text = "lblDosagem01"
        '
        'lblVacina07
        '
        Me.lblVacina07.Location = New System.Drawing.Point(102, 419)
        Me.lblVacina07.Name = "lblVacina07"
        Me.lblVacina07.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina07.TabIndex = 191
        Me.lblVacina07.Text = "lblVacina01"
        '
        'lblData07
        '
        Me.lblData07.AutoSize = True
        Me.lblData07.Location = New System.Drawing.Point(11, 419)
        Me.lblData07.Name = "lblData07"
        Me.lblData07.Size = New System.Drawing.Size(52, 13)
        Me.lblData07.TabIndex = 190
        Me.lblData07.Text = "lblData01"
        '
        'lblObservacao08
        '
        Me.lblObservacao08.Location = New System.Drawing.Point(516, 450)
        Me.lblObservacao08.Name = "lblObservacao08"
        Me.lblObservacao08.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao08.TabIndex = 197
        Me.lblObservacao08.Text = "lblObservacao01"
        '
        'lblDosagem08
        '
        Me.lblDosagem08.AutoSize = True
        Me.lblDosagem08.Location = New System.Drawing.Point(375, 450)
        Me.lblDosagem08.Name = "lblDosagem08"
        Me.lblDosagem08.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem08.TabIndex = 196
        Me.lblDosagem08.Text = "lblDosagem01"
        '
        'lblVacina08
        '
        Me.lblVacina08.Location = New System.Drawing.Point(102, 450)
        Me.lblVacina08.Name = "lblVacina08"
        Me.lblVacina08.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina08.TabIndex = 195
        Me.lblVacina08.Text = "lblVacina01"
        '
        'lblData08
        '
        Me.lblData08.AutoSize = True
        Me.lblData08.Location = New System.Drawing.Point(11, 450)
        Me.lblData08.Name = "lblData08"
        Me.lblData08.Size = New System.Drawing.Size(52, 13)
        Me.lblData08.TabIndex = 194
        Me.lblData08.Text = "lblData01"
        '
        'lblObservacao09
        '
        Me.lblObservacao09.Location = New System.Drawing.Point(516, 478)
        Me.lblObservacao09.Name = "lblObservacao09"
        Me.lblObservacao09.Size = New System.Drawing.Size(250, 13)
        Me.lblObservacao09.TabIndex = 201
        Me.lblObservacao09.Text = "lblObservacao01"
        '
        'lblDosagem09
        '
        Me.lblDosagem09.AutoSize = True
        Me.lblDosagem09.Location = New System.Drawing.Point(375, 478)
        Me.lblDosagem09.Name = "lblDosagem09"
        Me.lblDosagem09.Size = New System.Drawing.Size(74, 13)
        Me.lblDosagem09.TabIndex = 200
        Me.lblDosagem09.Text = "lblDosagem01"
        '
        'lblVacina09
        '
        Me.lblVacina09.Location = New System.Drawing.Point(102, 478)
        Me.lblVacina09.Name = "lblVacina09"
        Me.lblVacina09.Size = New System.Drawing.Size(266, 13)
        Me.lblVacina09.TabIndex = 199
        Me.lblVacina09.Text = "lblVacina01"
        '
        'lblData09
        '
        Me.lblData09.AutoSize = True
        Me.lblData09.Location = New System.Drawing.Point(11, 478)
        Me.lblData09.Name = "lblData09"
        Me.lblData09.Size = New System.Drawing.Size(52, 13)
        Me.lblData09.TabIndex = 198
        Me.lblData09.Text = "lblData01"
        '
        'VScrollBar
        '
        Me.VScrollBar.Location = New System.Drawing.Point(771, 229)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(17, 271)
        Me.VScrollBar.TabIndex = 202
        '
        'frmCadastroAtendimentoSolicitacaoVacina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 541)
        Me.ControlBox = False
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.lblObservacao09)
        Me.Controls.Add(Me.lblDosagem09)
        Me.Controls.Add(Me.lblVacina09)
        Me.Controls.Add(Me.lblData09)
        Me.Controls.Add(Me.lblObservacao08)
        Me.Controls.Add(Me.lblDosagem08)
        Me.Controls.Add(Me.lblVacina08)
        Me.Controls.Add(Me.lblData08)
        Me.Controls.Add(Me.lblObservacao07)
        Me.Controls.Add(Me.lblDosagem07)
        Me.Controls.Add(Me.lblVacina07)
        Me.Controls.Add(Me.lblData07)
        Me.Controls.Add(Me.lblObservacao06)
        Me.Controls.Add(Me.lblDosagem06)
        Me.Controls.Add(Me.lblVacina06)
        Me.Controls.Add(Me.lblData06)
        Me.Controls.Add(Me.lblObservacao05)
        Me.Controls.Add(Me.lblDosagem05)
        Me.Controls.Add(Me.lblVacina05)
        Me.Controls.Add(Me.lblData05)
        Me.Controls.Add(Me.lblObservacao04)
        Me.Controls.Add(Me.lblDosagem04)
        Me.Controls.Add(Me.lblVacina04)
        Me.Controls.Add(Me.lblData04)
        Me.Controls.Add(Me.lblObservacao03)
        Me.Controls.Add(Me.lblDosagem03)
        Me.Controls.Add(Me.lblVacina03)
        Me.Controls.Add(Me.lblData03)
        Me.Controls.Add(Me.lblObservacao02)
        Me.Controls.Add(Me.lblDosagem02)
        Me.Controls.Add(Me.lblVacina02)
        Me.Controls.Add(Me.lblData02)
        Me.Controls.Add(Me.lblObservacao01)
        Me.Controls.Add(Me.lblDosagem01)
        Me.Controls.Add(Me.lblVacina01)
        Me.Controls.Add(Me.lblData01)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.txtDosagem)
        Me.Controls.Add(Me.cboVacina)
        Me.Controls.Add(Me.txtDataVacina)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.picGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroAtendimentoSolicitacaoVacina"
        Me.Text = "Cadastro de Atendimento - Solicitação de Vacinas"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataVacina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDosagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents lblPaciente As Label
  Friend WithEvents lblIdade As Label
  Friend WithEvents cmdSalvar As uscBotao
  Friend WithEvents cmdImprimir As uscBotao
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents txtDataVacina As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents cboVacina As ComboBox
  Friend WithEvents txtDosagem As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtObservacao As TextBox
  Friend WithEvents lblData01 As Label
  Friend WithEvents lblVacina01 As Label
  Friend WithEvents lblDosagem01 As Label
  Friend WithEvents lblObservacao01 As Label
  Friend WithEvents lblObservacao02 As Label
  Friend WithEvents lblDosagem02 As Label
  Friend WithEvents lblVacina02 As Label
  Friend WithEvents lblData02 As Label
  Friend WithEvents lblObservacao03 As Label
  Friend WithEvents lblDosagem03 As Label
  Friend WithEvents lblVacina03 As Label
  Friend WithEvents lblData03 As Label
  Friend WithEvents lblObservacao04 As Label
  Friend WithEvents lblDosagem04 As Label
  Friend WithEvents lblVacina04 As Label
  Friend WithEvents lblData04 As Label
  Friend WithEvents lblObservacao05 As Label
  Friend WithEvents lblDosagem05 As Label
  Friend WithEvents lblVacina05 As Label
  Friend WithEvents lblData05 As Label
  Friend WithEvents lblObservacao06 As Label
  Friend WithEvents lblDosagem06 As Label
  Friend WithEvents lblVacina06 As Label
  Friend WithEvents lblData06 As Label
  Friend WithEvents lblObservacao07 As Label
  Friend WithEvents lblDosagem07 As Label
  Friend WithEvents lblVacina07 As Label
  Friend WithEvents lblData07 As Label
  Friend WithEvents lblObservacao08 As Label
  Friend WithEvents lblDosagem08 As Label
  Friend WithEvents lblVacina08 As Label
  Friend WithEvents lblData08 As Label
  Friend WithEvents lblObservacao09 As Label
  Friend WithEvents lblDosagem09 As Label
  Friend WithEvents lblVacina09 As Label
  Friend WithEvents lblData09 As Label
  Friend WithEvents VScrollBar As VScrollBar
End Class
