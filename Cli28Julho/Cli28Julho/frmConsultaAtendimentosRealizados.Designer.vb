<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAtendimentosRealizados
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAtendimentosRealizados))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.cboMedico = New System.Windows.Forms.ComboBox()
    Me.cboTipoConsulta = New System.Windows.Forms.ComboBox()
    Me.lblQtde = New System.Windows.Forms.Label()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.lblData01 = New System.Windows.Forms.Label()
    Me.lblData02 = New System.Windows.Forms.Label()
    Me.lblData03 = New System.Windows.Forms.Label()
    Me.lblData04 = New System.Windows.Forms.Label()
    Me.lblData05 = New System.Windows.Forms.Label()
    Me.lblData06 = New System.Windows.Forms.Label()
    Me.lblData07 = New System.Windows.Forms.Label()
    Me.lblMedico07 = New System.Windows.Forms.Label()
    Me.lblMedico06 = New System.Windows.Forms.Label()
    Me.lblMedico05 = New System.Windows.Forms.Label()
    Me.lblMedico04 = New System.Windows.Forms.Label()
    Me.lblMedico03 = New System.Windows.Forms.Label()
    Me.lblMedico02 = New System.Windows.Forms.Label()
    Me.lblMedico01 = New System.Windows.Forms.Label()
    Me.lblPaciente07 = New System.Windows.Forms.Label()
    Me.lblPaciente06 = New System.Windows.Forms.Label()
    Me.lblPaciente05 = New System.Windows.Forms.Label()
    Me.lblPaciente04 = New System.Windows.Forms.Label()
    Me.lblPaciente03 = New System.Windows.Forms.Label()
    Me.lblPaciente02 = New System.Windows.Forms.Label()
    Me.lblPaciente01 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento07 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento06 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento05 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento04 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento03 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento02 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento01 = New System.Windows.Forms.Label()
    Me.lblValor07 = New System.Windows.Forms.Label()
    Me.lblValor06 = New System.Windows.Forms.Label()
    Me.lblValor05 = New System.Windows.Forms.Label()
    Me.lblValor04 = New System.Windows.Forms.Label()
    Me.lblValor03 = New System.Windows.Forms.Label()
    Me.lblValor02 = New System.Windows.Forms.Label()
    Me.lblValor01 = New System.Windows.Forms.Label()
    Me.VScrollBar = New System.Windows.Forms.VScrollBar()
    Me.lblCodAutorizacao07 = New System.Windows.Forms.Label()
    Me.lblCodAutorizacao06 = New System.Windows.Forms.Label()
    Me.lblCodAutorizacao05 = New System.Windows.Forms.Label()
    Me.lblCodAutorizacao04 = New System.Windows.Forms.Label()
    Me.lblCodAutorizacao03 = New System.Windows.Forms.Label()
    Me.lblCodAutorizacao02 = New System.Windows.Forms.Label()
    Me.lblCodAutorizacao01 = New System.Windows.Forms.Label()
    Me.psqPaciente = New Cli28Julho.uscPesqPessoa()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdListar = New Cli28Julho.uscBotao()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(1113, 390)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'txtDataInicial
        '
        Me.txtDataInicial.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDataInicial.Location = New System.Drawing.Point(418, 32)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(89, 17)
        Me.txtDataInicial.TabIndex = 162
        '
        'txtDataFinal
        '
        Me.txtDataFinal.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDataFinal.Location = New System.Drawing.Point(514, 32)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(89, 17)
        Me.txtDataFinal.TabIndex = 163
        '
        'cboMedico
        '
        Me.cboMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMedico.FormattingEnabled = True
        Me.cboMedico.Location = New System.Drawing.Point(37, 29)
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Size = New System.Drawing.Size(369, 21)
        Me.cboMedico.TabIndex = 164
        '
        'cboTipoConsulta
        '
        Me.cboTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoConsulta.FormattingEnabled = True
        Me.cboTipoConsulta.Location = New System.Drawing.Point(418, 78)
        Me.cboTipoConsulta.Name = "cboTipoConsulta"
        Me.cboTipoConsulta.Size = New System.Drawing.Size(94, 21)
        Me.cboTipoConsulta.TabIndex = 165
        '
        'lblQtde
        '
        Me.lblQtde.Location = New System.Drawing.Point(76, 366)
        Me.lblQtde.Name = "lblQtde"
        Me.lblQtde.Size = New System.Drawing.Size(55, 13)
        Me.lblQtde.TabIndex = 167
        Me.lblQtde.Text = "lblQtde"
        Me.lblQtde.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(972, 364)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(115, 13)
        Me.lblTotal.TabIndex = 168
        Me.lblTotal.Text = "lblTotal"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblData01
        '
        Me.lblData01.AutoSize = True
        Me.lblData01.Location = New System.Drawing.Point(140, 154)
        Me.lblData01.Name = "lblData01"
        Me.lblData01.Size = New System.Drawing.Size(110, 13)
        Me.lblData01.TabIndex = 169
        Me.lblData01.Text = "99/99/9999 99:99:99"
        '
        'lblData02
        '
        Me.lblData02.AutoSize = True
        Me.lblData02.Location = New System.Drawing.Point(140, 181)
        Me.lblData02.Name = "lblData02"
        Me.lblData02.Size = New System.Drawing.Size(110, 13)
        Me.lblData02.TabIndex = 170
        Me.lblData02.Text = "99/99/9999 99:99:99"
        '
        'lblData03
        '
        Me.lblData03.AutoSize = True
        Me.lblData03.Location = New System.Drawing.Point(140, 212)
        Me.lblData03.Name = "lblData03"
        Me.lblData03.Size = New System.Drawing.Size(110, 13)
        Me.lblData03.TabIndex = 171
        Me.lblData03.Text = "99/99/9999 99:99:99"
        '
        'lblData04
        '
        Me.lblData04.AutoSize = True
        Me.lblData04.Location = New System.Drawing.Point(140, 241)
        Me.lblData04.Name = "lblData04"
        Me.lblData04.Size = New System.Drawing.Size(110, 13)
        Me.lblData04.TabIndex = 172
        Me.lblData04.Text = "99/99/9999 99:99:99"
        '
        'lblData05
        '
        Me.lblData05.AutoSize = True
        Me.lblData05.Location = New System.Drawing.Point(140, 269)
        Me.lblData05.Name = "lblData05"
        Me.lblData05.Size = New System.Drawing.Size(110, 13)
        Me.lblData05.TabIndex = 173
        Me.lblData05.Text = "99/99/9999 99:99:99"
        '
        'lblData06
        '
        Me.lblData06.AutoSize = True
        Me.lblData06.Location = New System.Drawing.Point(140, 300)
        Me.lblData06.Name = "lblData06"
        Me.lblData06.Size = New System.Drawing.Size(110, 13)
        Me.lblData06.TabIndex = 174
        Me.lblData06.Text = "99/99/9999 99:99:99"
        '
        'lblData07
        '
        Me.lblData07.AutoSize = True
        Me.lblData07.Location = New System.Drawing.Point(140, 328)
        Me.lblData07.Name = "lblData07"
        Me.lblData07.Size = New System.Drawing.Size(110, 13)
        Me.lblData07.TabIndex = 175
        Me.lblData07.Text = "99/99/9999 99:99:99"
        '
        'lblMedico07
        '
        Me.lblMedico07.Location = New System.Drawing.Point(288, 328)
        Me.lblMedico07.Name = "lblMedico07"
        Me.lblMedico07.Size = New System.Drawing.Size(252, 13)
        Me.lblMedico07.TabIndex = 182
        Me.lblMedico07.Text = "lblMedico07"
        '
        'lblMedico06
        '
        Me.lblMedico06.Location = New System.Drawing.Point(288, 300)
        Me.lblMedico06.Name = "lblMedico06"
        Me.lblMedico06.Size = New System.Drawing.Size(252, 13)
        Me.lblMedico06.TabIndex = 181
        Me.lblMedico06.Text = "lblMedico06"
        '
        'lblMedico05
        '
        Me.lblMedico05.Location = New System.Drawing.Point(288, 269)
        Me.lblMedico05.Name = "lblMedico05"
        Me.lblMedico05.Size = New System.Drawing.Size(252, 13)
        Me.lblMedico05.TabIndex = 180
        Me.lblMedico05.Text = "lblMedico05"
        '
        'lblMedico04
        '
        Me.lblMedico04.Location = New System.Drawing.Point(288, 241)
        Me.lblMedico04.Name = "lblMedico04"
        Me.lblMedico04.Size = New System.Drawing.Size(252, 13)
        Me.lblMedico04.TabIndex = 179
        Me.lblMedico04.Text = "lblMedico04"
        '
        'lblMedico03
        '
        Me.lblMedico03.Location = New System.Drawing.Point(288, 212)
        Me.lblMedico03.Name = "lblMedico03"
        Me.lblMedico03.Size = New System.Drawing.Size(252, 13)
        Me.lblMedico03.TabIndex = 178
        Me.lblMedico03.Text = "lblMedico03"
        '
        'lblMedico02
        '
        Me.lblMedico02.Location = New System.Drawing.Point(288, 181)
        Me.lblMedico02.Name = "lblMedico02"
        Me.lblMedico02.Size = New System.Drawing.Size(252, 13)
        Me.lblMedico02.TabIndex = 177
        Me.lblMedico02.Text = "lblMedico02"
        '
        'lblMedico01
        '
        Me.lblMedico01.Location = New System.Drawing.Point(288, 154)
        Me.lblMedico01.Name = "lblMedico01"
        Me.lblMedico01.Size = New System.Drawing.Size(252, 13)
        Me.lblMedico01.TabIndex = 176
        Me.lblMedico01.Text = "lblMedico01"
        '
        'lblPaciente07
        '
        Me.lblPaciente07.Location = New System.Drawing.Point(548, 328)
        Me.lblPaciente07.Name = "lblPaciente07"
        Me.lblPaciente07.Size = New System.Drawing.Size(272, 13)
        Me.lblPaciente07.TabIndex = 189
        Me.lblPaciente07.Text = "lblPaciente07"
        '
        'lblPaciente06
        '
        Me.lblPaciente06.Location = New System.Drawing.Point(548, 300)
        Me.lblPaciente06.Name = "lblPaciente06"
        Me.lblPaciente06.Size = New System.Drawing.Size(272, 13)
        Me.lblPaciente06.TabIndex = 188
        Me.lblPaciente06.Text = "lblPaciente06"
        '
        'lblPaciente05
        '
        Me.lblPaciente05.Location = New System.Drawing.Point(548, 269)
        Me.lblPaciente05.Name = "lblPaciente05"
        Me.lblPaciente05.Size = New System.Drawing.Size(272, 13)
        Me.lblPaciente05.TabIndex = 187
        Me.lblPaciente05.Text = "lblPaciente05"
        '
        'lblPaciente04
        '
        Me.lblPaciente04.Location = New System.Drawing.Point(548, 241)
        Me.lblPaciente04.Name = "lblPaciente04"
        Me.lblPaciente04.Size = New System.Drawing.Size(272, 13)
        Me.lblPaciente04.TabIndex = 186
        Me.lblPaciente04.Text = "lblPaciente04"
        '
        'lblPaciente03
        '
        Me.lblPaciente03.Location = New System.Drawing.Point(548, 212)
        Me.lblPaciente03.Name = "lblPaciente03"
        Me.lblPaciente03.Size = New System.Drawing.Size(272, 13)
        Me.lblPaciente03.TabIndex = 185
        Me.lblPaciente03.Text = "lblPaciente03"
        '
        'lblPaciente02
        '
        Me.lblPaciente02.Location = New System.Drawing.Point(548, 181)
        Me.lblPaciente02.Name = "lblPaciente02"
        Me.lblPaciente02.Size = New System.Drawing.Size(272, 13)
        Me.lblPaciente02.TabIndex = 184
        Me.lblPaciente02.Text = "lblPaciente02"
        '
        'lblPaciente01
        '
        Me.lblPaciente01.Location = New System.Drawing.Point(548, 154)
        Me.lblPaciente01.Name = "lblPaciente01"
        Me.lblPaciente01.Size = New System.Drawing.Size(272, 13)
        Me.lblPaciente01.TabIndex = 183
        Me.lblPaciente01.Text = "lblPaciente01"
        '
        'lblTipoAtendimento07
        '
        Me.lblTipoAtendimento07.AutoSize = True
        Me.lblTipoAtendimento07.Location = New System.Drawing.Point(829, 328)
        Me.lblTipoAtendimento07.Name = "lblTipoAtendimento07"
        Me.lblTipoAtendimento07.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoAtendimento07.TabIndex = 196
        Me.lblTipoAtendimento07.Text = "lblTipoAtendimento07"
        '
        'lblTipoAtendimento06
        '
        Me.lblTipoAtendimento06.AutoSize = True
        Me.lblTipoAtendimento06.Location = New System.Drawing.Point(829, 300)
        Me.lblTipoAtendimento06.Name = "lblTipoAtendimento06"
        Me.lblTipoAtendimento06.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoAtendimento06.TabIndex = 195
        Me.lblTipoAtendimento06.Text = "lblTipoAtendimento06"
        '
        'lblTipoAtendimento05
        '
        Me.lblTipoAtendimento05.AutoSize = True
        Me.lblTipoAtendimento05.Location = New System.Drawing.Point(829, 269)
        Me.lblTipoAtendimento05.Name = "lblTipoAtendimento05"
        Me.lblTipoAtendimento05.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoAtendimento05.TabIndex = 194
        Me.lblTipoAtendimento05.Text = "lblTipoAtendimento05"
        '
        'lblTipoAtendimento04
        '
        Me.lblTipoAtendimento04.AutoSize = True
        Me.lblTipoAtendimento04.Location = New System.Drawing.Point(829, 241)
        Me.lblTipoAtendimento04.Name = "lblTipoAtendimento04"
        Me.lblTipoAtendimento04.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoAtendimento04.TabIndex = 193
        Me.lblTipoAtendimento04.Text = "lblTipoAtendimento04"
        '
        'lblTipoAtendimento03
        '
        Me.lblTipoAtendimento03.AutoSize = True
        Me.lblTipoAtendimento03.Location = New System.Drawing.Point(829, 212)
        Me.lblTipoAtendimento03.Name = "lblTipoAtendimento03"
        Me.lblTipoAtendimento03.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoAtendimento03.TabIndex = 192
        Me.lblTipoAtendimento03.Text = "lblTipoAtendimento03"
        '
        'lblTipoAtendimento02
        '
        Me.lblTipoAtendimento02.AutoSize = True
        Me.lblTipoAtendimento02.Location = New System.Drawing.Point(829, 181)
        Me.lblTipoAtendimento02.Name = "lblTipoAtendimento02"
        Me.lblTipoAtendimento02.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoAtendimento02.TabIndex = 191
        Me.lblTipoAtendimento02.Text = "lblTipoAtendimento02"
        '
        'lblTipoAtendimento01
        '
        Me.lblTipoAtendimento01.AutoSize = True
        Me.lblTipoAtendimento01.Location = New System.Drawing.Point(829, 154)
        Me.lblTipoAtendimento01.Name = "lblTipoAtendimento01"
        Me.lblTipoAtendimento01.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoAtendimento01.TabIndex = 190
        Me.lblTipoAtendimento01.Text = "lblTipoAtendimento01"
        '
        'lblValor07
        '
        Me.lblValor07.Location = New System.Drawing.Point(970, 328)
        Me.lblValor07.Name = "lblValor07"
        Me.lblValor07.Size = New System.Drawing.Size(117, 13)
        Me.lblValor07.TabIndex = 203
        Me.lblValor07.Text = "lblValor07"
        Me.lblValor07.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor06
        '
        Me.lblValor06.Location = New System.Drawing.Point(970, 300)
        Me.lblValor06.Name = "lblValor06"
        Me.lblValor06.Size = New System.Drawing.Size(117, 13)
        Me.lblValor06.TabIndex = 202
        Me.lblValor06.Text = "lblValor06"
        Me.lblValor06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor05
        '
        Me.lblValor05.Location = New System.Drawing.Point(970, 269)
        Me.lblValor05.Name = "lblValor05"
        Me.lblValor05.Size = New System.Drawing.Size(117, 13)
        Me.lblValor05.TabIndex = 201
        Me.lblValor05.Text = "lblValor05"
        Me.lblValor05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor04
        '
        Me.lblValor04.Location = New System.Drawing.Point(970, 241)
        Me.lblValor04.Name = "lblValor04"
        Me.lblValor04.Size = New System.Drawing.Size(117, 13)
        Me.lblValor04.TabIndex = 200
        Me.lblValor04.Text = "lblValor04"
        Me.lblValor04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor03
        '
        Me.lblValor03.Location = New System.Drawing.Point(970, 212)
        Me.lblValor03.Name = "lblValor03"
        Me.lblValor03.Size = New System.Drawing.Size(117, 13)
        Me.lblValor03.TabIndex = 199
        Me.lblValor03.Text = "lblValor03"
        Me.lblValor03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor02
        '
        Me.lblValor02.Location = New System.Drawing.Point(970, 181)
        Me.lblValor02.Name = "lblValor02"
        Me.lblValor02.Size = New System.Drawing.Size(117, 13)
        Me.lblValor02.TabIndex = 198
        Me.lblValor02.Text = "lblValor02"
        Me.lblValor02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor01
        '
        Me.lblValor01.Location = New System.Drawing.Point(970, 154)
        Me.lblValor01.Name = "lblValor01"
        Me.lblValor01.Size = New System.Drawing.Size(117, 13)
        Me.lblValor01.TabIndex = 197
        Me.lblValor01.Text = "lblValor01"
        Me.lblValor01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VScrollBar
        '
        Me.VScrollBar.Location = New System.Drawing.Point(1096, 150)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(17, 197)
        Me.VScrollBar.TabIndex = 204
        '
        'lblCodAutorizacao07
        '
        Me.lblCodAutorizacao07.AutoSize = True
        Me.lblCodAutorizacao07.Location = New System.Drawing.Point(11, 328)
        Me.lblCodAutorizacao07.Name = "lblCodAutorizacao07"
        Me.lblCodAutorizacao07.Size = New System.Drawing.Size(104, 13)
        Me.lblCodAutorizacao07.TabIndex = 211
        Me.lblCodAutorizacao07.Text = "lblCodAutorizacao07"
        '
        'lblCodAutorizacao06
        '
        Me.lblCodAutorizacao06.AutoSize = True
        Me.lblCodAutorizacao06.Location = New System.Drawing.Point(11, 300)
        Me.lblCodAutorizacao06.Name = "lblCodAutorizacao06"
        Me.lblCodAutorizacao06.Size = New System.Drawing.Size(104, 13)
        Me.lblCodAutorizacao06.TabIndex = 210
        Me.lblCodAutorizacao06.Text = "lblCodAutorizacao06"
        '
        'lblCodAutorizacao05
        '
        Me.lblCodAutorizacao05.AutoSize = True
        Me.lblCodAutorizacao05.Location = New System.Drawing.Point(11, 269)
        Me.lblCodAutorizacao05.Name = "lblCodAutorizacao05"
        Me.lblCodAutorizacao05.Size = New System.Drawing.Size(104, 13)
        Me.lblCodAutorizacao05.TabIndex = 209
        Me.lblCodAutorizacao05.Text = "lblCodAutorizacao05"
        '
        'lblCodAutorizacao04
        '
        Me.lblCodAutorizacao04.AutoSize = True
        Me.lblCodAutorizacao04.Location = New System.Drawing.Point(11, 241)
        Me.lblCodAutorizacao04.Name = "lblCodAutorizacao04"
        Me.lblCodAutorizacao04.Size = New System.Drawing.Size(104, 13)
        Me.lblCodAutorizacao04.TabIndex = 208
        Me.lblCodAutorizacao04.Text = "lblCodAutorizacao04"
        '
        'lblCodAutorizacao03
        '
        Me.lblCodAutorizacao03.AutoSize = True
        Me.lblCodAutorizacao03.Location = New System.Drawing.Point(11, 212)
        Me.lblCodAutorizacao03.Name = "lblCodAutorizacao03"
        Me.lblCodAutorizacao03.Size = New System.Drawing.Size(104, 13)
        Me.lblCodAutorizacao03.TabIndex = 207
        Me.lblCodAutorizacao03.Text = "lblCodAutorizacao03"
        '
        'lblCodAutorizacao02
        '
        Me.lblCodAutorizacao02.AutoSize = True
        Me.lblCodAutorizacao02.Location = New System.Drawing.Point(11, 181)
        Me.lblCodAutorizacao02.Name = "lblCodAutorizacao02"
        Me.lblCodAutorizacao02.Size = New System.Drawing.Size(104, 13)
        Me.lblCodAutorizacao02.TabIndex = 206
        Me.lblCodAutorizacao02.Text = "lblCodAutorizacao02"
        '
        'lblCodAutorizacao01
        '
        Me.lblCodAutorizacao01.AutoSize = True
        Me.lblCodAutorizacao01.Location = New System.Drawing.Point(11, 154)
        Me.lblCodAutorizacao01.Name = "lblCodAutorizacao01"
        Me.lblCodAutorizacao01.Size = New System.Drawing.Size(104, 13)
        Me.lblCodAutorizacao01.TabIndex = 205
        Me.lblCodAutorizacao01.Text = "lblCodAutorizacao01"
        '
        'psqPaciente
        '
        Me.psqPaciente.AdicionarPessoa = False
        Me.psqPaciente.Bordas = True
        Me.psqPaciente.CarregarTodos = False
        Me.psqPaciente.DS_Pessoa = ""
        Me.psqPaciente.ID_Pessoa = 0
        Me.psqPaciente.LabelVisivel = False
        Me.psqPaciente.Location = New System.Drawing.Point(37, 77)
        Me.psqPaciente.Name = "psqPaciente"
        Me.psqPaciente.Rotulo = "Pessoa"
        Me.psqPaciente.Size = New System.Drawing.Size(371, 22)
        Me.psqPaciente.TabIndex = 166
        Me.psqPaciente.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(648, 76)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 3
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AutoSize = True
        Me.cmdImprimir.Location = New System.Drawing.Point(648, 45)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
        Me.cmdImprimir.TabIndex = 2
        '
        'cmdListar
        '
        Me.cmdListar.AutoSize = True
        Me.cmdListar.Location = New System.Drawing.Point(648, 14)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(16, 17)
        Me.cmdListar.TabIndex = 1
        '
        'frmConsultaAtendimentosRealizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 450)
        Me.Controls.Add(Me.lblCodAutorizacao07)
        Me.Controls.Add(Me.lblCodAutorizacao06)
        Me.Controls.Add(Me.lblCodAutorizacao05)
        Me.Controls.Add(Me.lblCodAutorizacao04)
        Me.Controls.Add(Me.lblCodAutorizacao03)
        Me.Controls.Add(Me.lblCodAutorizacao02)
        Me.Controls.Add(Me.lblCodAutorizacao01)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.lblValor07)
        Me.Controls.Add(Me.lblValor06)
        Me.Controls.Add(Me.lblValor05)
        Me.Controls.Add(Me.lblValor04)
        Me.Controls.Add(Me.lblValor03)
        Me.Controls.Add(Me.lblValor02)
        Me.Controls.Add(Me.lblValor01)
        Me.Controls.Add(Me.lblTipoAtendimento07)
        Me.Controls.Add(Me.lblTipoAtendimento06)
        Me.Controls.Add(Me.lblTipoAtendimento05)
        Me.Controls.Add(Me.lblTipoAtendimento04)
        Me.Controls.Add(Me.lblTipoAtendimento03)
        Me.Controls.Add(Me.lblTipoAtendimento02)
        Me.Controls.Add(Me.lblTipoAtendimento01)
        Me.Controls.Add(Me.lblPaciente07)
        Me.Controls.Add(Me.lblPaciente06)
        Me.Controls.Add(Me.lblPaciente05)
        Me.Controls.Add(Me.lblPaciente04)
        Me.Controls.Add(Me.lblPaciente03)
        Me.Controls.Add(Me.lblPaciente02)
        Me.Controls.Add(Me.lblPaciente01)
        Me.Controls.Add(Me.lblMedico07)
        Me.Controls.Add(Me.lblMedico06)
        Me.Controls.Add(Me.lblMedico05)
        Me.Controls.Add(Me.lblMedico04)
        Me.Controls.Add(Me.lblMedico03)
        Me.Controls.Add(Me.lblMedico02)
        Me.Controls.Add(Me.lblMedico01)
        Me.Controls.Add(Me.lblData07)
        Me.Controls.Add(Me.lblData06)
        Me.Controls.Add(Me.lblData05)
        Me.Controls.Add(Me.lblData04)
        Me.Controls.Add(Me.lblData03)
        Me.Controls.Add(Me.lblData02)
        Me.Controls.Add(Me.lblData01)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblQtde)
        Me.Controls.Add(Me.psqPaciente)
        Me.Controls.Add(Me.cboTipoConsulta)
        Me.Controls.Add(Me.cboMedico)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.txtDataInicial)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.picGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaAtendimentosRealizados"
        Me.Text = "Consulta de Atendimentos Realizados"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdListar As uscBotao
  Friend WithEvents cmdImprimir As uscBotao
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents cboMedico As ComboBox
  Friend WithEvents cboTipoConsulta As ComboBox
  Friend WithEvents psqPaciente As uscPesqPessoa
  Friend WithEvents lblQtde As Label
  Friend WithEvents lblTotal As Label
  Friend WithEvents lblData01 As Label
  Friend WithEvents lblData02 As Label
  Friend WithEvents lblData03 As Label
  Friend WithEvents lblData04 As Label
  Friend WithEvents lblData05 As Label
  Friend WithEvents lblData06 As Label
  Friend WithEvents lblData07 As Label
  Friend WithEvents lblMedico07 As Label
  Friend WithEvents lblMedico06 As Label
  Friend WithEvents lblMedico05 As Label
  Friend WithEvents lblMedico04 As Label
  Friend WithEvents lblMedico03 As Label
  Friend WithEvents lblMedico02 As Label
  Friend WithEvents lblMedico01 As Label
  Friend WithEvents lblPaciente07 As Label
  Friend WithEvents lblPaciente06 As Label
  Friend WithEvents lblPaciente05 As Label
  Friend WithEvents lblPaciente04 As Label
  Friend WithEvents lblPaciente03 As Label
  Friend WithEvents lblPaciente02 As Label
  Friend WithEvents lblPaciente01 As Label
  Friend WithEvents lblTipoAtendimento07 As Label
  Friend WithEvents lblTipoAtendimento06 As Label
  Friend WithEvents lblTipoAtendimento05 As Label
  Friend WithEvents lblTipoAtendimento04 As Label
  Friend WithEvents lblTipoAtendimento03 As Label
  Friend WithEvents lblTipoAtendimento02 As Label
  Friend WithEvents lblTipoAtendimento01 As Label
  Friend WithEvents lblValor07 As Label
  Friend WithEvents lblValor06 As Label
  Friend WithEvents lblValor05 As Label
  Friend WithEvents lblValor04 As Label
  Friend WithEvents lblValor03 As Label
  Friend WithEvents lblValor02 As Label
  Friend WithEvents lblValor01 As Label
  Friend WithEvents VScrollBar As VScrollBar
  Friend WithEvents lblCodAutorizacao07 As Label
  Friend WithEvents lblCodAutorizacao06 As Label
  Friend WithEvents lblCodAutorizacao05 As Label
  Friend WithEvents lblCodAutorizacao04 As Label
  Friend WithEvents lblCodAutorizacao03 As Label
  Friend WithEvents lblCodAutorizacao02 As Label
  Friend WithEvents lblCodAutorizacao01 As Label
End Class
