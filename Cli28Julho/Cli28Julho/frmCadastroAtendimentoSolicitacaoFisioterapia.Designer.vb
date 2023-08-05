<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoSolicitacaoFisioterapia
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoSolicitacaoFisioterapia))
    Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.lblIdade = New System.Windows.Forms.Label()
    Me.cmdSalvar = New Cli28Julho.uscBotao()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.txtDataFisioterapia = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    Me.txtObservacao = New System.Windows.Forms.TextBox()
    Me.txtQtdeSecoes = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.VScrollBar = New System.Windows.Forms.VScrollBar()
    Me.lblData01 = New System.Windows.Forms.Label()
    Me.lblQtdeSecoes01 = New System.Windows.Forms.Label()
    Me.lblProcedimento01 = New System.Windows.Forms.Label()
    Me.lblObservacao01 = New System.Windows.Forms.Label()
    Me.lblObservacao02 = New System.Windows.Forms.Label()
    Me.lblProcedimento02 = New System.Windows.Forms.Label()
    Me.lblQtdeSecoes02 = New System.Windows.Forms.Label()
    Me.lblData02 = New System.Windows.Forms.Label()
    Me.lblObservacao03 = New System.Windows.Forms.Label()
    Me.lblProcedimento03 = New System.Windows.Forms.Label()
    Me.lblQtdeSecoes03 = New System.Windows.Forms.Label()
    Me.lblData03 = New System.Windows.Forms.Label()
    Me.lblObservacao04 = New System.Windows.Forms.Label()
    Me.lblProcedimento04 = New System.Windows.Forms.Label()
    Me.lblQtdeSecoes04 = New System.Windows.Forms.Label()
    Me.lblData04 = New System.Windows.Forms.Label()
    Me.lblObservacao05 = New System.Windows.Forms.Label()
    Me.lblProcedimento05 = New System.Windows.Forms.Label()
    Me.lblQtdeSecoes05 = New System.Windows.Forms.Label()
    Me.lblData05 = New System.Windows.Forms.Label()
    Me.lblObservacao06 = New System.Windows.Forms.Label()
    Me.lblProcedimento06 = New System.Windows.Forms.Label()
    Me.lblQtdeSecoes06 = New System.Windows.Forms.Label()
    Me.lblData06 = New System.Windows.Forms.Label()
    Me.lblObservacao07 = New System.Windows.Forms.Label()
    Me.lblProcedimento07 = New System.Windows.Forms.Label()
    Me.lblQtdeSecoes07 = New System.Windows.Forms.Label()
    Me.lblData07 = New System.Windows.Forms.Label()
    Me.lblObservacao08 = New System.Windows.Forms.Label()
    Me.lblProcedimento08 = New System.Windows.Forms.Label()
    Me.lblQtdeSecoes08 = New System.Windows.Forms.Label()
    Me.lblData08 = New System.Windows.Forms.Label()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFisioterapia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeSecoes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'psqPessoa
        '
        Me.psqPessoa.AdicionarPessoa = False
        Me.psqPessoa.Bordas = False
        Me.psqPessoa.CarregarTodos = False
        Me.psqPessoa.DS_Pessoa = ""
        Me.psqPessoa.ID_Pessoa = 0
        Me.psqPessoa.LabelVisivel = False
        Me.psqPessoa.Location = New System.Drawing.Point(14, 32)
        Me.psqPessoa.Name = "psqPessoa"
        Me.psqPessoa.Rotulo = "Pessoa"
        Me.psqPessoa.Size = New System.Drawing.Size(362, 22)
        Me.psqPessoa.TabIndex = 1
        Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(807, 487)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Location = New System.Drawing.Point(380, 37)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(44, 13)
        Me.lblIdade.TabIndex = 141
        Me.lblIdade.Text = "lblIdade"
        '
        'cmdSalvar
        '
        Me.cmdSalvar.AutoSize = True
        Me.cmdSalvar.Location = New System.Drawing.Point(68, 71)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(16, 17)
        Me.cmdSalvar.TabIndex = 142
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AutoSize = True
        Me.cmdImprimir.Location = New System.Drawing.Point(161, 71)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
        Me.cmdImprimir.TabIndex = 144
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(253, 71)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 145
        '
        'txtDataFisioterapia
        '
        Me.txtDataFisioterapia.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDataFisioterapia.Location = New System.Drawing.Point(11, 144)
        Me.txtDataFisioterapia.Name = "txtDataFisioterapia"
        Me.txtDataFisioterapia.Size = New System.Drawing.Size(89, 17)
        Me.txtDataFisioterapia.TabIndex = 161
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = False
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = False
        Me.psqProcedimento.Location = New System.Drawing.Point(106, 143)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(269, 22)
        Me.psqProcedimento.TabIndex = 162
        '
        'txtObservacao
        '
        Me.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao.Location = New System.Drawing.Point(522, 148)
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(253, 13)
        Me.txtObservacao.TabIndex = 163
        '
        'txtQtdeSecoes
        '
        Me.txtQtdeSecoes.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtQtdeSecoes.Location = New System.Drawing.Point(381, 144)
        Me.txtQtdeSecoes.Name = "txtQtdeSecoes"
        Me.txtQtdeSecoes.Size = New System.Drawing.Size(135, 17)
        Me.txtQtdeSecoes.TabIndex = 164
        '
        'VScrollBar
        '
        Me.VScrollBar.Location = New System.Drawing.Point(779, 250)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(17, 241)
        Me.VScrollBar.TabIndex = 165
        '
        'lblData01
        '
        Me.lblData01.AutoSize = True
        Me.lblData01.Location = New System.Drawing.Point(13, 258)
        Me.lblData01.Name = "lblData01"
        Me.lblData01.Size = New System.Drawing.Size(52, 13)
        Me.lblData01.TabIndex = 166
        Me.lblData01.Text = "lblData01"
        '
        'lblQtdeSecoes01
        '
        Me.lblQtdeSecoes01.AutoSize = True
        Me.lblQtdeSecoes01.Location = New System.Drawing.Point(380, 258)
        Me.lblQtdeSecoes01.Name = "lblQtdeSecoes01"
        Me.lblQtdeSecoes01.Size = New System.Drawing.Size(88, 13)
        Me.lblQtdeSecoes01.TabIndex = 167
        Me.lblQtdeSecoes01.Text = "lblQtdeSecoes01"
        '
        'lblProcedimento01
        '
        Me.lblProcedimento01.AutoSize = True
        Me.lblProcedimento01.Location = New System.Drawing.Point(106, 258)
        Me.lblProcedimento01.Name = "lblProcedimento01"
        Me.lblProcedimento01.Size = New System.Drawing.Size(94, 13)
        Me.lblProcedimento01.TabIndex = 168
        Me.lblProcedimento01.Text = "lblProcedimento01"
        '
        'lblObservacao01
        '
        Me.lblObservacao01.AutoSize = True
        Me.lblObservacao01.Location = New System.Drawing.Point(521, 258)
        Me.lblObservacao01.Name = "lblObservacao01"
        Me.lblObservacao01.Size = New System.Drawing.Size(87, 13)
        Me.lblObservacao01.TabIndex = 169
        Me.lblObservacao01.Text = "lblObservacao01"
        '
        'lblObservacao02
        '
        Me.lblObservacao02.AutoSize = True
        Me.lblObservacao02.Location = New System.Drawing.Point(521, 286)
        Me.lblObservacao02.Name = "lblObservacao02"
        Me.lblObservacao02.Size = New System.Drawing.Size(87, 13)
        Me.lblObservacao02.TabIndex = 173
        Me.lblObservacao02.Text = "lblObservacao01"
        '
        'lblProcedimento02
        '
        Me.lblProcedimento02.AutoSize = True
        Me.lblProcedimento02.Location = New System.Drawing.Point(106, 286)
        Me.lblProcedimento02.Name = "lblProcedimento02"
        Me.lblProcedimento02.Size = New System.Drawing.Size(94, 13)
        Me.lblProcedimento02.TabIndex = 172
        Me.lblProcedimento02.Text = "lblProcedimento01"
        '
        'lblQtdeSecoes02
        '
        Me.lblQtdeSecoes02.AutoSize = True
        Me.lblQtdeSecoes02.Location = New System.Drawing.Point(380, 286)
        Me.lblQtdeSecoes02.Name = "lblQtdeSecoes02"
        Me.lblQtdeSecoes02.Size = New System.Drawing.Size(88, 13)
        Me.lblQtdeSecoes02.TabIndex = 171
        Me.lblQtdeSecoes02.Text = "lblQtdeSecoes01"
        '
        'lblData02
        '
        Me.lblData02.AutoSize = True
        Me.lblData02.Location = New System.Drawing.Point(13, 286)
        Me.lblData02.Name = "lblData02"
        Me.lblData02.Size = New System.Drawing.Size(52, 13)
        Me.lblData02.TabIndex = 170
        Me.lblData02.Text = "lblData01"
        '
        'lblObservacao03
        '
        Me.lblObservacao03.AutoSize = True
        Me.lblObservacao03.Location = New System.Drawing.Point(521, 317)
        Me.lblObservacao03.Name = "lblObservacao03"
        Me.lblObservacao03.Size = New System.Drawing.Size(87, 13)
        Me.lblObservacao03.TabIndex = 177
        Me.lblObservacao03.Text = "lblObservacao01"
        '
        'lblProcedimento03
        '
        Me.lblProcedimento03.AutoSize = True
        Me.lblProcedimento03.Location = New System.Drawing.Point(106, 317)
        Me.lblProcedimento03.Name = "lblProcedimento03"
        Me.lblProcedimento03.Size = New System.Drawing.Size(94, 13)
        Me.lblProcedimento03.TabIndex = 176
        Me.lblProcedimento03.Text = "lblProcedimento01"
        '
        'lblQtdeSecoes03
        '
        Me.lblQtdeSecoes03.AutoSize = True
        Me.lblQtdeSecoes03.Location = New System.Drawing.Point(380, 317)
        Me.lblQtdeSecoes03.Name = "lblQtdeSecoes03"
        Me.lblQtdeSecoes03.Size = New System.Drawing.Size(88, 13)
        Me.lblQtdeSecoes03.TabIndex = 175
        Me.lblQtdeSecoes03.Text = "lblQtdeSecoes01"
        '
        'lblData03
        '
        Me.lblData03.AutoSize = True
        Me.lblData03.Location = New System.Drawing.Point(13, 317)
        Me.lblData03.Name = "lblData03"
        Me.lblData03.Size = New System.Drawing.Size(52, 13)
        Me.lblData03.TabIndex = 174
        Me.lblData03.Text = "lblData01"
        '
        'lblObservacao04
        '
        Me.lblObservacao04.AutoSize = True
        Me.lblObservacao04.Location = New System.Drawing.Point(521, 349)
        Me.lblObservacao04.Name = "lblObservacao04"
        Me.lblObservacao04.Size = New System.Drawing.Size(87, 13)
        Me.lblObservacao04.TabIndex = 181
        Me.lblObservacao04.Text = "lblObservacao01"
        '
        'lblProcedimento04
        '
        Me.lblProcedimento04.AutoSize = True
        Me.lblProcedimento04.Location = New System.Drawing.Point(106, 349)
        Me.lblProcedimento04.Name = "lblProcedimento04"
        Me.lblProcedimento04.Size = New System.Drawing.Size(94, 13)
        Me.lblProcedimento04.TabIndex = 180
        Me.lblProcedimento04.Text = "lblProcedimento01"
        '
        'lblQtdeSecoes04
        '
        Me.lblQtdeSecoes04.AutoSize = True
        Me.lblQtdeSecoes04.Location = New System.Drawing.Point(380, 349)
        Me.lblQtdeSecoes04.Name = "lblQtdeSecoes04"
        Me.lblQtdeSecoes04.Size = New System.Drawing.Size(88, 13)
        Me.lblQtdeSecoes04.TabIndex = 179
        Me.lblQtdeSecoes04.Text = "lblQtdeSecoes01"
        '
        'lblData04
        '
        Me.lblData04.AutoSize = True
        Me.lblData04.Location = New System.Drawing.Point(13, 349)
        Me.lblData04.Name = "lblData04"
        Me.lblData04.Size = New System.Drawing.Size(52, 13)
        Me.lblData04.TabIndex = 178
        Me.lblData04.Text = "lblData01"
        '
        'lblObservacao05
        '
        Me.lblObservacao05.AutoSize = True
        Me.lblObservacao05.Location = New System.Drawing.Point(521, 379)
        Me.lblObservacao05.Name = "lblObservacao05"
        Me.lblObservacao05.Size = New System.Drawing.Size(87, 13)
        Me.lblObservacao05.TabIndex = 185
        Me.lblObservacao05.Text = "lblObservacao01"
        '
        'lblProcedimento05
        '
        Me.lblProcedimento05.AutoSize = True
        Me.lblProcedimento05.Location = New System.Drawing.Point(106, 379)
        Me.lblProcedimento05.Name = "lblProcedimento05"
        Me.lblProcedimento05.Size = New System.Drawing.Size(94, 13)
        Me.lblProcedimento05.TabIndex = 184
        Me.lblProcedimento05.Text = "lblProcedimento01"
        '
        'lblQtdeSecoes05
        '
        Me.lblQtdeSecoes05.AutoSize = True
        Me.lblQtdeSecoes05.Location = New System.Drawing.Point(380, 379)
        Me.lblQtdeSecoes05.Name = "lblQtdeSecoes05"
        Me.lblQtdeSecoes05.Size = New System.Drawing.Size(88, 13)
        Me.lblQtdeSecoes05.TabIndex = 183
        Me.lblQtdeSecoes05.Text = "lblQtdeSecoes01"
        '
        'lblData05
        '
        Me.lblData05.AutoSize = True
        Me.lblData05.Location = New System.Drawing.Point(13, 379)
        Me.lblData05.Name = "lblData05"
        Me.lblData05.Size = New System.Drawing.Size(52, 13)
        Me.lblData05.TabIndex = 182
        Me.lblData05.Text = "lblData01"
        '
        'lblObservacao06
        '
        Me.lblObservacao06.AutoSize = True
        Me.lblObservacao06.Location = New System.Drawing.Point(521, 410)
        Me.lblObservacao06.Name = "lblObservacao06"
        Me.lblObservacao06.Size = New System.Drawing.Size(87, 13)
        Me.lblObservacao06.TabIndex = 189
        Me.lblObservacao06.Text = "lblObservacao01"
        '
        'lblProcedimento06
        '
        Me.lblProcedimento06.AutoSize = True
        Me.lblProcedimento06.Location = New System.Drawing.Point(106, 410)
        Me.lblProcedimento06.Name = "lblProcedimento06"
        Me.lblProcedimento06.Size = New System.Drawing.Size(94, 13)
        Me.lblProcedimento06.TabIndex = 188
        Me.lblProcedimento06.Text = "lblProcedimento01"
        '
        'lblQtdeSecoes06
        '
        Me.lblQtdeSecoes06.AutoSize = True
        Me.lblQtdeSecoes06.Location = New System.Drawing.Point(380, 410)
        Me.lblQtdeSecoes06.Name = "lblQtdeSecoes06"
        Me.lblQtdeSecoes06.Size = New System.Drawing.Size(88, 13)
        Me.lblQtdeSecoes06.TabIndex = 187
        Me.lblQtdeSecoes06.Text = "lblQtdeSecoes01"
        '
        'lblData06
        '
        Me.lblData06.AutoSize = True
        Me.lblData06.Location = New System.Drawing.Point(13, 410)
        Me.lblData06.Name = "lblData06"
        Me.lblData06.Size = New System.Drawing.Size(52, 13)
        Me.lblData06.TabIndex = 186
        Me.lblData06.Text = "lblData01"
        '
        'lblObservacao07
        '
        Me.lblObservacao07.AutoSize = True
        Me.lblObservacao07.Location = New System.Drawing.Point(521, 441)
        Me.lblObservacao07.Name = "lblObservacao07"
        Me.lblObservacao07.Size = New System.Drawing.Size(87, 13)
        Me.lblObservacao07.TabIndex = 193
        Me.lblObservacao07.Text = "lblObservacao01"
        '
        'lblProcedimento07
        '
        Me.lblProcedimento07.AutoSize = True
        Me.lblProcedimento07.Location = New System.Drawing.Point(106, 441)
        Me.lblProcedimento07.Name = "lblProcedimento07"
        Me.lblProcedimento07.Size = New System.Drawing.Size(94, 13)
        Me.lblProcedimento07.TabIndex = 192
        Me.lblProcedimento07.Text = "lblProcedimento01"
        '
        'lblQtdeSecoes07
        '
        Me.lblQtdeSecoes07.AutoSize = True
        Me.lblQtdeSecoes07.Location = New System.Drawing.Point(380, 441)
        Me.lblQtdeSecoes07.Name = "lblQtdeSecoes07"
        Me.lblQtdeSecoes07.Size = New System.Drawing.Size(88, 13)
        Me.lblQtdeSecoes07.TabIndex = 191
        Me.lblQtdeSecoes07.Text = "lblQtdeSecoes01"
        '
        'lblData07
        '
        Me.lblData07.AutoSize = True
        Me.lblData07.Location = New System.Drawing.Point(13, 441)
        Me.lblData07.Name = "lblData07"
        Me.lblData07.Size = New System.Drawing.Size(52, 13)
        Me.lblData07.TabIndex = 190
        Me.lblData07.Text = "lblData01"
        '
        'lblObservacao08
        '
        Me.lblObservacao08.AutoSize = True
        Me.lblObservacao08.Location = New System.Drawing.Point(521, 472)
        Me.lblObservacao08.Name = "lblObservacao08"
        Me.lblObservacao08.Size = New System.Drawing.Size(87, 13)
        Me.lblObservacao08.TabIndex = 197
        Me.lblObservacao08.Text = "lblObservacao01"
        '
        'lblProcedimento08
        '
        Me.lblProcedimento08.AutoSize = True
        Me.lblProcedimento08.Location = New System.Drawing.Point(106, 472)
        Me.lblProcedimento08.Name = "lblProcedimento08"
        Me.lblProcedimento08.Size = New System.Drawing.Size(94, 13)
        Me.lblProcedimento08.TabIndex = 196
        Me.lblProcedimento08.Text = "lblProcedimento01"
        '
        'lblQtdeSecoes08
        '
        Me.lblQtdeSecoes08.AutoSize = True
        Me.lblQtdeSecoes08.Location = New System.Drawing.Point(380, 472)
        Me.lblQtdeSecoes08.Name = "lblQtdeSecoes08"
        Me.lblQtdeSecoes08.Size = New System.Drawing.Size(88, 13)
        Me.lblQtdeSecoes08.TabIndex = 195
        Me.lblQtdeSecoes08.Text = "lblQtdeSecoes01"
        '
        'lblData08
        '
        Me.lblData08.AutoSize = True
        Me.lblData08.Location = New System.Drawing.Point(13, 472)
        Me.lblData08.Name = "lblData08"
        Me.lblData08.Size = New System.Drawing.Size(52, 13)
        Me.lblData08.TabIndex = 194
        Me.lblData08.Text = "lblData01"
        '
        'frmCadastroAtendimentoSolicitacaoFisioterapia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 529)
        Me.Controls.Add(Me.lblObservacao08)
        Me.Controls.Add(Me.lblProcedimento08)
        Me.Controls.Add(Me.lblQtdeSecoes08)
        Me.Controls.Add(Me.lblData08)
        Me.Controls.Add(Me.lblObservacao07)
        Me.Controls.Add(Me.lblProcedimento07)
        Me.Controls.Add(Me.lblQtdeSecoes07)
        Me.Controls.Add(Me.lblData07)
        Me.Controls.Add(Me.lblObservacao06)
        Me.Controls.Add(Me.lblProcedimento06)
        Me.Controls.Add(Me.lblQtdeSecoes06)
        Me.Controls.Add(Me.lblData06)
        Me.Controls.Add(Me.lblObservacao05)
        Me.Controls.Add(Me.lblProcedimento05)
        Me.Controls.Add(Me.lblQtdeSecoes05)
        Me.Controls.Add(Me.lblData05)
        Me.Controls.Add(Me.lblObservacao04)
        Me.Controls.Add(Me.lblProcedimento04)
        Me.Controls.Add(Me.lblQtdeSecoes04)
        Me.Controls.Add(Me.lblData04)
        Me.Controls.Add(Me.lblObservacao03)
        Me.Controls.Add(Me.lblProcedimento03)
        Me.Controls.Add(Me.lblQtdeSecoes03)
        Me.Controls.Add(Me.lblData03)
        Me.Controls.Add(Me.lblObservacao02)
        Me.Controls.Add(Me.lblProcedimento02)
        Me.Controls.Add(Me.lblQtdeSecoes02)
        Me.Controls.Add(Me.lblData02)
        Me.Controls.Add(Me.lblObservacao01)
        Me.Controls.Add(Me.lblProcedimento01)
        Me.Controls.Add(Me.lblQtdeSecoes01)
        Me.Controls.Add(Me.lblData01)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.txtQtdeSecoes)
        Me.Controls.Add(Me.txtObservacao)
        Me.Controls.Add(Me.psqProcedimento)
        Me.Controls.Add(Me.txtDataFisioterapia)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.psqPessoa)
        Me.Controls.Add(Me.picGeral)
        Me.Name = "frmCadastroAtendimentoSolicitacaoFisioterapia"
        Me.Text = "Cadastro de Atendimento - Solicitação de Fisioterapia"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFisioterapia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeSecoes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents psqPessoa As uscPesqPessoa
  Friend WithEvents lblIdade As Label
  Friend WithEvents cmdSalvar As uscBotao
  Friend WithEvents cmdImprimir As uscBotao
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents txtDataFisioterapia As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents psqProcedimento As uscPesqProcedimento
  Friend WithEvents txtObservacao As TextBox
  Friend WithEvents txtQtdeSecoes As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents VScrollBar As VScrollBar
  Friend WithEvents lblData01 As Label
  Friend WithEvents lblQtdeSecoes01 As Label
  Friend WithEvents lblProcedimento01 As Label
  Friend WithEvents lblObservacao01 As Label
  Friend WithEvents lblObservacao02 As Label
  Friend WithEvents lblProcedimento02 As Label
  Friend WithEvents lblQtdeSecoes02 As Label
  Friend WithEvents lblData02 As Label
  Friend WithEvents lblObservacao03 As Label
  Friend WithEvents lblProcedimento03 As Label
  Friend WithEvents lblQtdeSecoes03 As Label
  Friend WithEvents lblData03 As Label
  Friend WithEvents lblObservacao04 As Label
  Friend WithEvents lblProcedimento04 As Label
  Friend WithEvents lblQtdeSecoes04 As Label
  Friend WithEvents lblData04 As Label
  Friend WithEvents lblObservacao05 As Label
  Friend WithEvents lblProcedimento05 As Label
  Friend WithEvents lblQtdeSecoes05 As Label
  Friend WithEvents lblData05 As Label
  Friend WithEvents lblObservacao06 As Label
  Friend WithEvents lblProcedimento06 As Label
  Friend WithEvents lblQtdeSecoes06 As Label
  Friend WithEvents lblData06 As Label
  Friend WithEvents lblObservacao07 As Label
  Friend WithEvents lblProcedimento07 As Label
  Friend WithEvents lblQtdeSecoes07 As Label
  Friend WithEvents lblData07 As Label
  Friend WithEvents lblObservacao08 As Label
  Friend WithEvents lblProcedimento08 As Label
  Friend WithEvents lblQtdeSecoes08 As Label
  Friend WithEvents lblData08 As Label
End Class
