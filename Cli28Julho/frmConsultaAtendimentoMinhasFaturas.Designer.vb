<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAtendimentoMinhasFaturas
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAtendimentoMinhasFaturas))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.optExames = New System.Windows.Forms.RadioButton()
    Me.optConsultas = New System.Windows.Forms.RadioButton()
        Me.VScrollBar = New System.Windows.Forms.VScrollBar()
        Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblVlPrestadorTotal = New System.Windows.Forms.Label()
        Me.lblCodAutoiza01 = New System.Windows.Forms.Label()
        Me.lblCodAutoiza02 = New System.Windows.Forms.Label()
        Me.lblCodAutoiza03 = New System.Windows.Forms.Label()
        Me.lblCodAutoiza04 = New System.Windows.Forms.Label()
        Me.lblCodAutoiza05 = New System.Windows.Forms.Label()
        Me.lblCodAutoiza06 = New System.Windows.Forms.Label()
        Me.lblCodAutoiza07 = New System.Windows.Forms.Label()
        Me.lblData07 = New System.Windows.Forms.Label()
        Me.lblData06 = New System.Windows.Forms.Label()
        Me.lblData05 = New System.Windows.Forms.Label()
        Me.lblData04 = New System.Windows.Forms.Label()
        Me.lblData03 = New System.Windows.Forms.Label()
        Me.lblData02 = New System.Windows.Forms.Label()
        Me.lblData01 = New System.Windows.Forms.Label()
        Me.lblPaciente07 = New System.Windows.Forms.Label()
        Me.lblPaciente06 = New System.Windows.Forms.Label()
        Me.lblPaciente05 = New System.Windows.Forms.Label()
        Me.lblPaciente04 = New System.Windows.Forms.Label()
        Me.lblPaciente03 = New System.Windows.Forms.Label()
        Me.lblPaciente02 = New System.Windows.Forms.Label()
        Me.lblPaciente01 = New System.Windows.Forms.Label()
        Me.lblProcedimentoExame07 = New System.Windows.Forms.Label()
        Me.lblProcedimentoExame06 = New System.Windows.Forms.Label()
        Me.lblProcedimentoExame05 = New System.Windows.Forms.Label()
        Me.lblProcedimentoExame04 = New System.Windows.Forms.Label()
        Me.lblProcedimentoExame03 = New System.Windows.Forms.Label()
        Me.lblProcedimentoExame02 = New System.Windows.Forms.Label()
        Me.lblProcedimentoExame01 = New System.Windows.Forms.Label()
        Me.lblTipoAtendimento07 = New System.Windows.Forms.Label()
        Me.lblTipoAtendimento06 = New System.Windows.Forms.Label()
        Me.lblTipoAtendimento05 = New System.Windows.Forms.Label()
        Me.lblTipoAtendimento04 = New System.Windows.Forms.Label()
        Me.lblTipoAtendimento03 = New System.Windows.Forms.Label()
        Me.lblTipoAtendimento02 = New System.Windows.Forms.Label()
        Me.lblTipoAtendimento01 = New System.Windows.Forms.Label()
        Me.lblVlPrestador07 = New System.Windows.Forms.Label()
        Me.lblVlPrestador06 = New System.Windows.Forms.Label()
        Me.lblVlPrestador05 = New System.Windows.Forms.Label()
        Me.lblVlPrestador04 = New System.Windows.Forms.Label()
        Me.lblVlPrestador03 = New System.Windows.Forms.Label()
        Me.lblVlPrestador02 = New System.Windows.Forms.Label()
        Me.lblVlPrestador01 = New System.Windows.Forms.Label()
        Me.cboConvenio = New System.Windows.Forms.ComboBox()
        Me.cmdFechar = New Cli28Julho.uscBotao()
        Me.cmdListar = New Cli28Julho.uscBotao()
        Me.cmdImprimir = New Cli28Julho.uscBotao()
        Me.optTodos = New System.Windows.Forms.RadioButton()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(964, 409)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.optTodos)
        Me.Panel1.Controls.Add(Me.optExames)
        Me.Panel1.Controls.Add(Me.optConsultas)
        Me.Panel1.Location = New System.Drawing.Point(295, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 22)
        Me.Panel1.TabIndex = 1
        '
        'optExames
        '
        Me.optExames.AutoSize = True
        Me.optExames.Location = New System.Drawing.Point(85, 3)
        Me.optExames.Name = "optExames"
        Me.optExames.Size = New System.Drawing.Size(14, 13)
        Me.optExames.TabIndex = 1
        Me.optExames.TabStop = True
        Me.optExames.UseVisualStyleBackColor = True
        '
        'optConsultas
        '
        Me.optConsultas.AutoSize = True
        Me.optConsultas.Location = New System.Drawing.Point(20, 3)
        Me.optConsultas.Name = "optConsultas"
        Me.optConsultas.Size = New System.Drawing.Size(14, 13)
        Me.optConsultas.TabIndex = 0
        Me.optConsultas.TabStop = True
        Me.optConsultas.UseVisualStyleBackColor = True
        '
        'VScrollBar
        '
        Me.VScrollBar.Location = New System.Drawing.Point(957, 163)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(17, 201)
        Me.VScrollBar.TabIndex = 3
        '
        'txtDataInicial
        '
        Me.txtDataInicial.Location = New System.Drawing.Point(25, 82)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(89, 21)
        Me.txtDataInicial.TabIndex = 161
        '
        'txtDataFinal
        '
        Me.txtDataFinal.Location = New System.Drawing.Point(118, 82)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(89, 21)
        Me.txtDataFinal.TabIndex = 162
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(59, 381)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(40, 13)
        Me.lblQuantidade.TabIndex = 163
        Me.lblQuantidade.Text = "lblQtde"
        '
        'lblVlPrestadorTotal
        '
        Me.lblVlPrestadorTotal.Location = New System.Drawing.Point(863, 383)
        Me.lblVlPrestadorTotal.Name = "lblVlPrestadorTotal"
        Me.lblVlPrestadorTotal.Size = New System.Drawing.Size(90, 13)
        Me.lblVlPrestadorTotal.TabIndex = 165
        Me.lblVlPrestadorTotal.Text = "lblVlPrestadorTotal"
        Me.lblVlPrestadorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCodAutoiza01
        '
        Me.lblCodAutoiza01.AutoSize = True
        Me.lblCodAutoiza01.Location = New System.Drawing.Point(13, 169)
        Me.lblCodAutoiza01.Name = "lblCodAutoiza01"
        Me.lblCodAutoiza01.Size = New System.Drawing.Size(83, 13)
        Me.lblCodAutoiza01.TabIndex = 166
        Me.lblCodAutoiza01.Text = "lblCodAutoiza01"
        Me.lblCodAutoiza01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodAutoiza02
        '
        Me.lblCodAutoiza02.AutoSize = True
        Me.lblCodAutoiza02.Location = New System.Drawing.Point(13, 196)
        Me.lblCodAutoiza02.Name = "lblCodAutoiza02"
        Me.lblCodAutoiza02.Size = New System.Drawing.Size(83, 13)
        Me.lblCodAutoiza02.TabIndex = 167
        Me.lblCodAutoiza02.Text = "lblCodAutoiza01"
        Me.lblCodAutoiza02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodAutoiza03
        '
        Me.lblCodAutoiza03.AutoSize = True
        Me.lblCodAutoiza03.Location = New System.Drawing.Point(13, 225)
        Me.lblCodAutoiza03.Name = "lblCodAutoiza03"
        Me.lblCodAutoiza03.Size = New System.Drawing.Size(83, 13)
        Me.lblCodAutoiza03.TabIndex = 168
        Me.lblCodAutoiza03.Text = "lblCodAutoiza01"
        Me.lblCodAutoiza03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodAutoiza04
        '
        Me.lblCodAutoiza04.AutoSize = True
        Me.lblCodAutoiza04.Location = New System.Drawing.Point(13, 255)
        Me.lblCodAutoiza04.Name = "lblCodAutoiza04"
        Me.lblCodAutoiza04.Size = New System.Drawing.Size(83, 13)
        Me.lblCodAutoiza04.TabIndex = 169
        Me.lblCodAutoiza04.Text = "lblCodAutoiza01"
        Me.lblCodAutoiza04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodAutoiza05
        '
        Me.lblCodAutoiza05.AutoSize = True
        Me.lblCodAutoiza05.Location = New System.Drawing.Point(13, 284)
        Me.lblCodAutoiza05.Name = "lblCodAutoiza05"
        Me.lblCodAutoiza05.Size = New System.Drawing.Size(83, 13)
        Me.lblCodAutoiza05.TabIndex = 170
        Me.lblCodAutoiza05.Text = "lblCodAutoiza01"
        Me.lblCodAutoiza05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodAutoiza06
        '
        Me.lblCodAutoiza06.AutoSize = True
        Me.lblCodAutoiza06.Location = New System.Drawing.Point(13, 314)
        Me.lblCodAutoiza06.Name = "lblCodAutoiza06"
        Me.lblCodAutoiza06.Size = New System.Drawing.Size(83, 13)
        Me.lblCodAutoiza06.TabIndex = 171
        Me.lblCodAutoiza06.Text = "lblCodAutoiza01"
        Me.lblCodAutoiza06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodAutoiza07
        '
        Me.lblCodAutoiza07.AutoSize = True
        Me.lblCodAutoiza07.Location = New System.Drawing.Point(13, 343)
        Me.lblCodAutoiza07.Name = "lblCodAutoiza07"
        Me.lblCodAutoiza07.Size = New System.Drawing.Size(83, 13)
        Me.lblCodAutoiza07.TabIndex = 172
        Me.lblCodAutoiza07.Text = "lblCodAutoiza01"
        Me.lblCodAutoiza07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData07
        '
        Me.lblData07.AutoSize = True
        Me.lblData07.Location = New System.Drawing.Point(110, 343)
        Me.lblData07.Name = "lblData07"
        Me.lblData07.Size = New System.Drawing.Size(52, 13)
        Me.lblData07.TabIndex = 179
        Me.lblData07.Text = "lblData01"
        Me.lblData07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData06
        '
        Me.lblData06.AutoSize = True
        Me.lblData06.Location = New System.Drawing.Point(110, 314)
        Me.lblData06.Name = "lblData06"
        Me.lblData06.Size = New System.Drawing.Size(52, 13)
        Me.lblData06.TabIndex = 178
        Me.lblData06.Text = "lblData01"
        Me.lblData06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData05
        '
        Me.lblData05.AutoSize = True
        Me.lblData05.Location = New System.Drawing.Point(110, 284)
        Me.lblData05.Name = "lblData05"
        Me.lblData05.Size = New System.Drawing.Size(52, 13)
        Me.lblData05.TabIndex = 177
        Me.lblData05.Text = "lblData01"
        Me.lblData05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData04
        '
        Me.lblData04.AutoSize = True
        Me.lblData04.Location = New System.Drawing.Point(110, 255)
        Me.lblData04.Name = "lblData04"
        Me.lblData04.Size = New System.Drawing.Size(52, 13)
        Me.lblData04.TabIndex = 176
        Me.lblData04.Text = "lblData01"
        Me.lblData04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData03
        '
        Me.lblData03.AutoSize = True
        Me.lblData03.Location = New System.Drawing.Point(110, 225)
        Me.lblData03.Name = "lblData03"
        Me.lblData03.Size = New System.Drawing.Size(52, 13)
        Me.lblData03.TabIndex = 175
        Me.lblData03.Text = "lblData01"
        Me.lblData03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData02
        '
        Me.lblData02.AutoSize = True
        Me.lblData02.Location = New System.Drawing.Point(110, 196)
        Me.lblData02.Name = "lblData02"
        Me.lblData02.Size = New System.Drawing.Size(52, 13)
        Me.lblData02.TabIndex = 174
        Me.lblData02.Text = "lblData01"
        Me.lblData02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblData01
        '
        Me.lblData01.AutoSize = True
        Me.lblData01.Location = New System.Drawing.Point(110, 169)
        Me.lblData01.Name = "lblData01"
        Me.lblData01.Size = New System.Drawing.Size(52, 13)
        Me.lblData01.TabIndex = 173
        Me.lblData01.Text = "lblData01"
        Me.lblData01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaciente07
        '
        Me.lblPaciente07.Location = New System.Drawing.Point(211, 343)
        Me.lblPaciente07.Name = "lblPaciente07"
        Me.lblPaciente07.Size = New System.Drawing.Size(212, 13)
        Me.lblPaciente07.TabIndex = 186
        Me.lblPaciente07.Text = "lblPaciente01"
        Me.lblPaciente07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaciente06
        '
        Me.lblPaciente06.Location = New System.Drawing.Point(211, 314)
        Me.lblPaciente06.Name = "lblPaciente06"
        Me.lblPaciente06.Size = New System.Drawing.Size(212, 13)
        Me.lblPaciente06.TabIndex = 185
        Me.lblPaciente06.Text = "lblPaciente01"
        Me.lblPaciente06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaciente05
        '
        Me.lblPaciente05.Location = New System.Drawing.Point(211, 284)
        Me.lblPaciente05.Name = "lblPaciente05"
        Me.lblPaciente05.Size = New System.Drawing.Size(212, 13)
        Me.lblPaciente05.TabIndex = 184
        Me.lblPaciente05.Text = "lblPaciente01"
        Me.lblPaciente05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaciente04
        '
        Me.lblPaciente04.Location = New System.Drawing.Point(211, 255)
        Me.lblPaciente04.Name = "lblPaciente04"
        Me.lblPaciente04.Size = New System.Drawing.Size(212, 13)
        Me.lblPaciente04.TabIndex = 183
        Me.lblPaciente04.Text = "lblPaciente01"
        Me.lblPaciente04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaciente03
        '
        Me.lblPaciente03.Location = New System.Drawing.Point(211, 225)
        Me.lblPaciente03.Name = "lblPaciente03"
        Me.lblPaciente03.Size = New System.Drawing.Size(212, 13)
        Me.lblPaciente03.TabIndex = 182
        Me.lblPaciente03.Text = "lblPaciente01"
        Me.lblPaciente03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaciente02
        '
        Me.lblPaciente02.Location = New System.Drawing.Point(211, 196)
        Me.lblPaciente02.Name = "lblPaciente02"
        Me.lblPaciente02.Size = New System.Drawing.Size(212, 13)
        Me.lblPaciente02.TabIndex = 181
        Me.lblPaciente02.Text = "lblPaciente01"
        Me.lblPaciente02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaciente01
        '
        Me.lblPaciente01.Location = New System.Drawing.Point(211, 169)
        Me.lblPaciente01.Name = "lblPaciente01"
        Me.lblPaciente01.Size = New System.Drawing.Size(212, 13)
        Me.lblPaciente01.TabIndex = 180
        Me.lblPaciente01.Text = "lblPaciente01"
        Me.lblPaciente01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcedimentoExame07
        '
        Me.lblProcedimentoExame07.Location = New System.Drawing.Point(436, 343)
        Me.lblProcedimentoExame07.Name = "lblProcedimentoExame07"
        Me.lblProcedimentoExame07.Size = New System.Drawing.Size(213, 13)
        Me.lblProcedimentoExame07.TabIndex = 193
        Me.lblProcedimentoExame07.Text = "lblProcedimentoExame01"
        Me.lblProcedimentoExame07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcedimentoExame06
        '
        Me.lblProcedimentoExame06.Location = New System.Drawing.Point(436, 314)
        Me.lblProcedimentoExame06.Name = "lblProcedimentoExame06"
        Me.lblProcedimentoExame06.Size = New System.Drawing.Size(213, 13)
        Me.lblProcedimentoExame06.TabIndex = 192
        Me.lblProcedimentoExame06.Text = "lblProcedimentoExame01"
        Me.lblProcedimentoExame06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcedimentoExame05
        '
        Me.lblProcedimentoExame05.Location = New System.Drawing.Point(436, 284)
        Me.lblProcedimentoExame05.Name = "lblProcedimentoExame05"
        Me.lblProcedimentoExame05.Size = New System.Drawing.Size(213, 13)
        Me.lblProcedimentoExame05.TabIndex = 191
        Me.lblProcedimentoExame05.Text = "lblProcedimentoExame01"
        Me.lblProcedimentoExame05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcedimentoExame04
        '
        Me.lblProcedimentoExame04.Location = New System.Drawing.Point(436, 255)
        Me.lblProcedimentoExame04.Name = "lblProcedimentoExame04"
        Me.lblProcedimentoExame04.Size = New System.Drawing.Size(213, 13)
        Me.lblProcedimentoExame04.TabIndex = 190
        Me.lblProcedimentoExame04.Text = "lblProcedimentoExame01"
        Me.lblProcedimentoExame04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcedimentoExame03
        '
        Me.lblProcedimentoExame03.Location = New System.Drawing.Point(436, 225)
        Me.lblProcedimentoExame03.Name = "lblProcedimentoExame03"
        Me.lblProcedimentoExame03.Size = New System.Drawing.Size(213, 13)
        Me.lblProcedimentoExame03.TabIndex = 189
        Me.lblProcedimentoExame03.Text = "lblProcedimentoExame01"
        Me.lblProcedimentoExame03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcedimentoExame02
        '
        Me.lblProcedimentoExame02.Location = New System.Drawing.Point(436, 196)
        Me.lblProcedimentoExame02.Name = "lblProcedimentoExame02"
        Me.lblProcedimentoExame02.Size = New System.Drawing.Size(213, 13)
        Me.lblProcedimentoExame02.TabIndex = 188
        Me.lblProcedimentoExame02.Text = "lblProcedimentoExame01"
        Me.lblProcedimentoExame02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcedimentoExame01
        '
        Me.lblProcedimentoExame01.Location = New System.Drawing.Point(436, 169)
        Me.lblProcedimentoExame01.Name = "lblProcedimentoExame01"
        Me.lblProcedimentoExame01.Size = New System.Drawing.Size(213, 13)
        Me.lblProcedimentoExame01.TabIndex = 187
        Me.lblProcedimentoExame01.Text = "lblProcedimentoExame01"
        Me.lblProcedimentoExame01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoAtendimento07
        '
        Me.lblTipoAtendimento07.Location = New System.Drawing.Point(660, 343)
        Me.lblTipoAtendimento07.Name = "lblTipoAtendimento07"
        Me.lblTipoAtendimento07.Size = New System.Drawing.Size(94, 13)
        Me.lblTipoAtendimento07.TabIndex = 200
        Me.lblTipoAtendimento07.Text = "lblTipoAtendime01"
        Me.lblTipoAtendimento07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoAtendimento06
        '
        Me.lblTipoAtendimento06.Location = New System.Drawing.Point(660, 314)
        Me.lblTipoAtendimento06.Name = "lblTipoAtendimento06"
        Me.lblTipoAtendimento06.Size = New System.Drawing.Size(94, 13)
        Me.lblTipoAtendimento06.TabIndex = 199
        Me.lblTipoAtendimento06.Text = "lblTipoAtendime01"
        Me.lblTipoAtendimento06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoAtendimento05
        '
        Me.lblTipoAtendimento05.Location = New System.Drawing.Point(660, 284)
        Me.lblTipoAtendimento05.Name = "lblTipoAtendimento05"
        Me.lblTipoAtendimento05.Size = New System.Drawing.Size(94, 13)
        Me.lblTipoAtendimento05.TabIndex = 198
        Me.lblTipoAtendimento05.Text = "lblTipoAtendime01"
        Me.lblTipoAtendimento05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoAtendimento04
        '
        Me.lblTipoAtendimento04.Location = New System.Drawing.Point(660, 255)
        Me.lblTipoAtendimento04.Name = "lblTipoAtendimento04"
        Me.lblTipoAtendimento04.Size = New System.Drawing.Size(94, 13)
        Me.lblTipoAtendimento04.TabIndex = 197
        Me.lblTipoAtendimento04.Text = "lblTipoAtendime01"
        Me.lblTipoAtendimento04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoAtendimento03
        '
        Me.lblTipoAtendimento03.Location = New System.Drawing.Point(660, 225)
        Me.lblTipoAtendimento03.Name = "lblTipoAtendimento03"
        Me.lblTipoAtendimento03.Size = New System.Drawing.Size(94, 13)
        Me.lblTipoAtendimento03.TabIndex = 196
        Me.lblTipoAtendimento03.Text = "lblTipoAtendime01"
        Me.lblTipoAtendimento03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoAtendimento02
        '
        Me.lblTipoAtendimento02.Location = New System.Drawing.Point(660, 196)
        Me.lblTipoAtendimento02.Name = "lblTipoAtendimento02"
        Me.lblTipoAtendimento02.Size = New System.Drawing.Size(94, 13)
        Me.lblTipoAtendimento02.TabIndex = 195
        Me.lblTipoAtendimento02.Text = "lblTipoAtendime01"
        Me.lblTipoAtendimento02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoAtendimento01
        '
        Me.lblTipoAtendimento01.Location = New System.Drawing.Point(660, 169)
        Me.lblTipoAtendimento01.Name = "lblTipoAtendimento01"
        Me.lblTipoAtendimento01.Size = New System.Drawing.Size(94, 13)
        Me.lblTipoAtendimento01.TabIndex = 194
        Me.lblTipoAtendimento01.Text = "lblTipoAtendime01"
        Me.lblTipoAtendimento01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVlPrestador07
        '
        Me.lblVlPrestador07.Location = New System.Drawing.Point(862, 343)
        Me.lblVlPrestador07.Name = "lblVlPrestador07"
        Me.lblVlPrestador07.Size = New System.Drawing.Size(87, 13)
        Me.lblVlPrestador07.TabIndex = 214
        Me.lblVlPrestador07.Text = "lblVlPrestador01"
        Me.lblVlPrestador07.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador06
        '
        Me.lblVlPrestador06.Location = New System.Drawing.Point(862, 314)
        Me.lblVlPrestador06.Name = "lblVlPrestador06"
        Me.lblVlPrestador06.Size = New System.Drawing.Size(87, 13)
        Me.lblVlPrestador06.TabIndex = 213
        Me.lblVlPrestador06.Text = "lblVlPrestador01"
        Me.lblVlPrestador06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador05
        '
        Me.lblVlPrestador05.Location = New System.Drawing.Point(862, 284)
        Me.lblVlPrestador05.Name = "lblVlPrestador05"
        Me.lblVlPrestador05.Size = New System.Drawing.Size(87, 13)
        Me.lblVlPrestador05.TabIndex = 212
        Me.lblVlPrestador05.Text = "lblVlPrestador01"
        Me.lblVlPrestador05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador04
        '
        Me.lblVlPrestador04.Location = New System.Drawing.Point(862, 255)
        Me.lblVlPrestador04.Name = "lblVlPrestador04"
        Me.lblVlPrestador04.Size = New System.Drawing.Size(87, 13)
        Me.lblVlPrestador04.TabIndex = 211
        Me.lblVlPrestador04.Text = "lblVlPrestador01"
        Me.lblVlPrestador04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador03
        '
        Me.lblVlPrestador03.Location = New System.Drawing.Point(862, 225)
        Me.lblVlPrestador03.Name = "lblVlPrestador03"
        Me.lblVlPrestador03.Size = New System.Drawing.Size(87, 13)
        Me.lblVlPrestador03.TabIndex = 210
        Me.lblVlPrestador03.Text = "lblVlPrestador01"
        Me.lblVlPrestador03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador02
        '
        Me.lblVlPrestador02.Location = New System.Drawing.Point(862, 196)
        Me.lblVlPrestador02.Name = "lblVlPrestador02"
        Me.lblVlPrestador02.Size = New System.Drawing.Size(87, 13)
        Me.lblVlPrestador02.TabIndex = 209
        Me.lblVlPrestador02.Text = "lblVlPrestador01"
        Me.lblVlPrestador02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador01
        '
        Me.lblVlPrestador01.Location = New System.Drawing.Point(862, 169)
        Me.lblVlPrestador01.Name = "lblVlPrestador01"
        Me.lblVlPrestador01.Size = New System.Drawing.Size(87, 13)
        Me.lblVlPrestador01.TabIndex = 208
        Me.lblVlPrestador01.Text = "lblVlPrestador01"
        Me.lblVlPrestador01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboConvenio
        '
        Me.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConvenio.FormattingEnabled = True
        Me.cboConvenio.Location = New System.Drawing.Point(502, 82)
        Me.cboConvenio.Name = "cboConvenio"
        Me.cboConvenio.Size = New System.Drawing.Size(229, 21)
        Me.cboConvenio.TabIndex = 216
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(830, 72)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 7
        '
        'cmdListar
        '
        Me.cmdListar.AutoSize = True
        Me.cmdListar.Location = New System.Drawing.Point(737, 72)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(16, 17)
        Me.cmdListar.TabIndex = 5
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AutoSize = True
        Me.cmdImprimir.Location = New System.Drawing.Point(737, 34)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
        Me.cmdImprimir.TabIndex = 4
        '
        'optTodos
        '
        Me.optTodos.AutoSize = True
        Me.optTodos.Location = New System.Drawing.Point(160, 3)
        Me.optTodos.Name = "optTodos"
        Me.optTodos.Size = New System.Drawing.Size(14, 13)
        Me.optTodos.TabIndex = 216
        Me.optTodos.TabStop = True
        Me.optTodos.UseVisualStyleBackColor = True
        '
        'frmConsultaAtendimentoMinhasFaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 450)
        Me.Controls.Add(Me.cboConvenio)
        Me.Controls.Add(Me.lblVlPrestador07)
        Me.Controls.Add(Me.lblVlPrestador06)
        Me.Controls.Add(Me.lblVlPrestador05)
        Me.Controls.Add(Me.lblVlPrestador04)
        Me.Controls.Add(Me.lblVlPrestador03)
        Me.Controls.Add(Me.lblVlPrestador02)
        Me.Controls.Add(Me.lblVlPrestador01)
        Me.Controls.Add(Me.lblTipoAtendimento07)
        Me.Controls.Add(Me.lblTipoAtendimento06)
        Me.Controls.Add(Me.lblTipoAtendimento05)
        Me.Controls.Add(Me.lblTipoAtendimento04)
        Me.Controls.Add(Me.lblTipoAtendimento03)
        Me.Controls.Add(Me.lblTipoAtendimento02)
        Me.Controls.Add(Me.lblTipoAtendimento01)
        Me.Controls.Add(Me.lblProcedimentoExame07)
        Me.Controls.Add(Me.lblProcedimentoExame06)
        Me.Controls.Add(Me.lblProcedimentoExame05)
        Me.Controls.Add(Me.lblProcedimentoExame04)
        Me.Controls.Add(Me.lblProcedimentoExame03)
        Me.Controls.Add(Me.lblProcedimentoExame02)
        Me.Controls.Add(Me.lblProcedimentoExame01)
        Me.Controls.Add(Me.lblPaciente07)
        Me.Controls.Add(Me.lblPaciente06)
        Me.Controls.Add(Me.lblPaciente05)
        Me.Controls.Add(Me.lblPaciente04)
        Me.Controls.Add(Me.lblPaciente03)
        Me.Controls.Add(Me.lblPaciente02)
        Me.Controls.Add(Me.lblPaciente01)
        Me.Controls.Add(Me.lblData07)
        Me.Controls.Add(Me.lblData06)
        Me.Controls.Add(Me.lblData05)
        Me.Controls.Add(Me.lblData04)
        Me.Controls.Add(Me.lblData03)
        Me.Controls.Add(Me.lblData02)
        Me.Controls.Add(Me.lblData01)
        Me.Controls.Add(Me.lblCodAutoiza07)
        Me.Controls.Add(Me.lblCodAutoiza06)
        Me.Controls.Add(Me.lblCodAutoiza05)
        Me.Controls.Add(Me.lblCodAutoiza04)
        Me.Controls.Add(Me.lblCodAutoiza03)
        Me.Controls.Add(Me.lblCodAutoiza02)
        Me.Controls.Add(Me.lblCodAutoiza01)
        Me.Controls.Add(Me.lblVlPrestadorTotal)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.txtDataInicial)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaAtendimentoMinhasFaturas"
        Me.Text = "Médicos - Minhas Faturas"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents Panel1 As Panel
  Friend WithEvents optExames As RadioButton
  Friend WithEvents optConsultas As RadioButton
    Friend WithEvents VScrollBar As VScrollBar
    Friend WithEvents cmdImprimir As uscBotao
    Friend WithEvents cmdListar As uscBotao
    Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents lblVlPrestadorTotal As Label
    Friend WithEvents lblCodAutoiza01 As Label
    Friend WithEvents lblCodAutoiza02 As Label
    Friend WithEvents lblCodAutoiza03 As Label
    Friend WithEvents lblCodAutoiza04 As Label
    Friend WithEvents lblCodAutoiza05 As Label
    Friend WithEvents lblCodAutoiza06 As Label
    Friend WithEvents lblCodAutoiza07 As Label
    Friend WithEvents lblData07 As Label
    Friend WithEvents lblData06 As Label
    Friend WithEvents lblData05 As Label
    Friend WithEvents lblData04 As Label
    Friend WithEvents lblData03 As Label
    Friend WithEvents lblData02 As Label
    Friend WithEvents lblData01 As Label
    Friend WithEvents lblPaciente07 As Label
    Friend WithEvents lblPaciente06 As Label
    Friend WithEvents lblPaciente05 As Label
    Friend WithEvents lblPaciente04 As Label
    Friend WithEvents lblPaciente03 As Label
    Friend WithEvents lblPaciente02 As Label
    Friend WithEvents lblPaciente01 As Label
    Friend WithEvents lblProcedimentoExame07 As Label
    Friend WithEvents lblProcedimentoExame06 As Label
    Friend WithEvents lblProcedimentoExame05 As Label
    Friend WithEvents lblProcedimentoExame04 As Label
    Friend WithEvents lblProcedimentoExame03 As Label
    Friend WithEvents lblProcedimentoExame02 As Label
    Friend WithEvents lblProcedimentoExame01 As Label
    Friend WithEvents lblTipoAtendimento07 As Label
    Friend WithEvents lblTipoAtendimento06 As Label
    Friend WithEvents lblTipoAtendimento05 As Label
    Friend WithEvents lblTipoAtendimento04 As Label
    Friend WithEvents lblTipoAtendimento03 As Label
    Friend WithEvents lblTipoAtendimento02 As Label
    Friend WithEvents lblTipoAtendimento01 As Label
    Friend WithEvents lblVlPrestador07 As Label
    Friend WithEvents lblVlPrestador06 As Label
  Friend WithEvents lblVlPrestador05 As Label
  Friend WithEvents lblVlPrestador04 As Label
  Friend WithEvents lblVlPrestador03 As Label
  Friend WithEvents lblVlPrestador02 As Label
  Friend WithEvents lblVlPrestador01 As Label
    Friend WithEvents cboConvenio As ComboBox
    Friend WithEvents optTodos As RadioButton
End Class
