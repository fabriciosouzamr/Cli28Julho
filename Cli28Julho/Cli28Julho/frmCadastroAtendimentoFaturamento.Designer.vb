<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoFaturamento
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoFaturamento))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.cboMedicoPrestador = New System.Windows.Forms.ComboBox()
    Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.cmdSelecionar01 = New System.Windows.Forms.Button()
    Me.cmdSelecionar02 = New System.Windows.Forms.Button()
    Me.cmdSelecionar03 = New System.Windows.Forms.Button()
    Me.cmdSelecionar04 = New System.Windows.Forms.Button()
    Me.cmdSelecionar05 = New System.Windows.Forms.Button()
    Me.cmdSelecionar06 = New System.Windows.Forms.Button()
    Me.cmdTodasPendentes = New System.Windows.Forms.Button()
    Me.cmdTodosRemover = New System.Windows.Forms.Button()
    Me.cmdRemover01 = New System.Windows.Forms.Button()
    Me.cmdRemover02 = New System.Windows.Forms.Button()
    Me.cmdRemover03 = New System.Windows.Forms.Button()
    Me.cmdRemover04 = New System.Windows.Forms.Button()
    Me.cmdRemover05 = New System.Windows.Forms.Button()
    Me.cmdRemover06 = New System.Windows.Forms.Button()
    Me.lblPCodAutorizacao01 = New System.Windows.Forms.Label()
    Me.lblPCodAutorizacao02 = New System.Windows.Forms.Label()
    Me.lblPCodAutorizacao03 = New System.Windows.Forms.Label()
    Me.lblPCodAutorizacao04 = New System.Windows.Forms.Label()
    Me.lblPCodAutorizacao05 = New System.Windows.Forms.Label()
    Me.lblPCodAutorizacao06 = New System.Windows.Forms.Label()
    Me.lblPData06 = New System.Windows.Forms.Label()
    Me.lblPData05 = New System.Windows.Forms.Label()
    Me.lblPData04 = New System.Windows.Forms.Label()
    Me.lblPData03 = New System.Windows.Forms.Label()
    Me.lblPData02 = New System.Windows.Forms.Label()
    Me.lblPData01 = New System.Windows.Forms.Label()
    Me.lblPMedicoPrestador06 = New System.Windows.Forms.Label()
    Me.lblPMedicoPrestador05 = New System.Windows.Forms.Label()
    Me.lblPMedicoPrestador04 = New System.Windows.Forms.Label()
    Me.lblPMedicoPrestador03 = New System.Windows.Forms.Label()
    Me.lblPMedicoPrestador02 = New System.Windows.Forms.Label()
    Me.lblPMedicoPrestador01 = New System.Windows.Forms.Label()
    Me.lblPPaciente06 = New System.Windows.Forms.Label()
    Me.lblPPaciente05 = New System.Windows.Forms.Label()
    Me.lblPPaciente04 = New System.Windows.Forms.Label()
    Me.lblPPaciente03 = New System.Windows.Forms.Label()
    Me.lblPPaciente02 = New System.Windows.Forms.Label()
    Me.lblPPaciente01 = New System.Windows.Forms.Label()
    Me.lblPTipoAtendimento06 = New System.Windows.Forms.Label()
    Me.lblPTipoAtendimento05 = New System.Windows.Forms.Label()
    Me.lblPTipoAtendimento04 = New System.Windows.Forms.Label()
    Me.lblPTipoAtendimento03 = New System.Windows.Forms.Label()
    Me.lblPTipoAtendimento02 = New System.Windows.Forms.Label()
    Me.lblPTipoAtendimento01 = New System.Windows.Forms.Label()
    Me.lblPValor06 = New System.Windows.Forms.Label()
    Me.lblPValor05 = New System.Windows.Forms.Label()
    Me.lblPValor04 = New System.Windows.Forms.Label()
    Me.lblPValor03 = New System.Windows.Forms.Label()
    Me.lblPValor02 = New System.Windows.Forms.Label()
    Me.lblPValor01 = New System.Windows.Forms.Label()
    Me.lblPVlPrestador06 = New System.Windows.Forms.Label()
    Me.lblPVlPrestador05 = New System.Windows.Forms.Label()
    Me.lblPVlPrestador04 = New System.Windows.Forms.Label()
    Me.lblPVlPrestador03 = New System.Windows.Forms.Label()
    Me.lblPVlPrestador02 = New System.Windows.Forms.Label()
    Me.lblPVlPrestador01 = New System.Windows.Forms.Label()
    Me.lblFVlPrestador06 = New System.Windows.Forms.Label()
    Me.lblFVlPrestador05 = New System.Windows.Forms.Label()
    Me.lblFVlPrestador04 = New System.Windows.Forms.Label()
    Me.lblFVlPrestador03 = New System.Windows.Forms.Label()
    Me.lblFVlPrestador02 = New System.Windows.Forms.Label()
    Me.lblFVlPrestador01 = New System.Windows.Forms.Label()
    Me.lblFValor06 = New System.Windows.Forms.Label()
    Me.lblFValor05 = New System.Windows.Forms.Label()
    Me.lblFValor04 = New System.Windows.Forms.Label()
    Me.lblFValor03 = New System.Windows.Forms.Label()
    Me.lblFValor02 = New System.Windows.Forms.Label()
    Me.lblFValor01 = New System.Windows.Forms.Label()
    Me.lblFTipoAtendimento06 = New System.Windows.Forms.Label()
    Me.lblFTipoAtendimento05 = New System.Windows.Forms.Label()
    Me.lblFTipoAtendimento04 = New System.Windows.Forms.Label()
    Me.lblFTipoAtendimento03 = New System.Windows.Forms.Label()
    Me.lblFTipoAtendimento02 = New System.Windows.Forms.Label()
    Me.lblFTipoAtendimento01 = New System.Windows.Forms.Label()
    Me.lblFPaciente06 = New System.Windows.Forms.Label()
    Me.lblFPaciente05 = New System.Windows.Forms.Label()
    Me.lblFPaciente04 = New System.Windows.Forms.Label()
    Me.lblFPaciente03 = New System.Windows.Forms.Label()
    Me.lblFPaciente02 = New System.Windows.Forms.Label()
    Me.lblFPaciente01 = New System.Windows.Forms.Label()
    Me.lblFMedicoPrestador06 = New System.Windows.Forms.Label()
    Me.lblFMedicoPrestador05 = New System.Windows.Forms.Label()
    Me.lblFMedicoPrestador04 = New System.Windows.Forms.Label()
    Me.lblFMedicoPrestador03 = New System.Windows.Forms.Label()
    Me.lblFMedicoPrestador02 = New System.Windows.Forms.Label()
    Me.lblFMedicoPrestador01 = New System.Windows.Forms.Label()
    Me.lblFData06 = New System.Windows.Forms.Label()
    Me.lblFData05 = New System.Windows.Forms.Label()
    Me.lblFData04 = New System.Windows.Forms.Label()
    Me.lblFData03 = New System.Windows.Forms.Label()
    Me.lblFData02 = New System.Windows.Forms.Label()
    Me.lblFData01 = New System.Windows.Forms.Label()
    Me.lblFCodAutorizacao06 = New System.Windows.Forms.Label()
    Me.lblFCodAutorizacao05 = New System.Windows.Forms.Label()
    Me.lblFCodAutorizacao04 = New System.Windows.Forms.Label()
    Me.lblFCodAutorizacao03 = New System.Windows.Forms.Label()
    Me.lblFCodAutorizacao02 = New System.Windows.Forms.Label()
    Me.lblFCodAutorizacao01 = New System.Windows.Forms.Label()
    Me.lblPQdte = New System.Windows.Forms.Label()
    Me.lblPValorTotal = New System.Windows.Forms.Label()
    Me.lblPVlPrestTotal = New System.Windows.Forms.Label()
    Me.lblFVlPrestTotal = New System.Windows.Forms.Label()
    Me.lblFValorTotal = New System.Windows.Forms.Label()
    Me.lblFQdte = New System.Windows.Forms.Label()
    Me.vsbPendentes = New System.Windows.Forms.VScrollBar()
    Me.vsbFaturar = New System.Windows.Forms.VScrollBar()
    Me.txtCodAutorizacao = New System.Windows.Forms.TextBox()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
    Me.cmdFaturar = New Cli28Julho.uscBotao()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
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
    Me.picGeral.Size = New System.Drawing.Size(948, 652)
    Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picGeral.TabIndex = 0
    Me.picGeral.TabStop = False
    '
    'cboMedicoPrestador
    '
    Me.cboMedicoPrestador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboMedicoPrestador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.cboMedicoPrestador.FormattingEnabled = True
    Me.cboMedicoPrestador.Location = New System.Drawing.Point(34, 94)
    Me.cboMedicoPrestador.Name = "cboMedicoPrestador"
    Me.cboMedicoPrestador.Size = New System.Drawing.Size(278, 21)
    Me.cboMedicoPrestador.TabIndex = 2
    '
    'txtDataInicial
    '
    Me.txtDataInicial.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
    Me.txtDataInicial.DateTime = New Date(2020, 6, 7, 0, 0, 0, 0)
    Me.txtDataInicial.Location = New System.Drawing.Point(322, 96)
    Me.txtDataInicial.Name = "txtDataInicial"
    Me.txtDataInicial.Size = New System.Drawing.Size(83, 17)
    Me.txtDataInicial.TabIndex = 162
    Me.txtDataInicial.Value = New Date(2020, 6, 7, 0, 0, 0, 0)
    '
    'txtDataFinal
    '
    Me.txtDataFinal.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
    Me.txtDataFinal.DateTime = New Date(2020, 6, 7, 0, 0, 0, 0)
    Me.txtDataFinal.Location = New System.Drawing.Point(413, 96)
    Me.txtDataFinal.Name = "txtDataFinal"
    Me.txtDataFinal.Size = New System.Drawing.Size(83, 17)
    Me.txtDataFinal.TabIndex = 163
    Me.txtDataFinal.Value = New Date(2020, 6, 7, 0, 0, 0, 0)
    '
    'cmdSelecionar01
    '
    Me.cmdSelecionar01.Location = New System.Drawing.Point(9, 191)
    Me.cmdSelecionar01.Name = "cmdSelecionar01"
    Me.cmdSelecionar01.Size = New System.Drawing.Size(16, 23)
    Me.cmdSelecionar01.TabIndex = 167
    Me.cmdSelecionar01.Text = "V"
    Me.cmdSelecionar01.UseVisualStyleBackColor = True
    '
    'cmdSelecionar02
    '
    Me.cmdSelecionar02.Location = New System.Drawing.Point(9, 218)
    Me.cmdSelecionar02.Name = "cmdSelecionar02"
    Me.cmdSelecionar02.Size = New System.Drawing.Size(16, 23)
    Me.cmdSelecionar02.TabIndex = 168
    Me.cmdSelecionar02.Text = "V"
    Me.cmdSelecionar02.UseVisualStyleBackColor = True
    '
    'cmdSelecionar03
    '
    Me.cmdSelecionar03.Location = New System.Drawing.Point(9, 245)
    Me.cmdSelecionar03.Name = "cmdSelecionar03"
    Me.cmdSelecionar03.Size = New System.Drawing.Size(16, 23)
    Me.cmdSelecionar03.TabIndex = 169
    Me.cmdSelecionar03.Text = "V"
    Me.cmdSelecionar03.UseVisualStyleBackColor = True
    '
    'cmdSelecionar04
    '
    Me.cmdSelecionar04.Location = New System.Drawing.Point(9, 272)
    Me.cmdSelecionar04.Name = "cmdSelecionar04"
    Me.cmdSelecionar04.Size = New System.Drawing.Size(16, 23)
    Me.cmdSelecionar04.TabIndex = 170
    Me.cmdSelecionar04.Text = "V"
    Me.cmdSelecionar04.UseVisualStyleBackColor = True
    '
    'cmdSelecionar05
    '
    Me.cmdSelecionar05.Location = New System.Drawing.Point(9, 299)
    Me.cmdSelecionar05.Name = "cmdSelecionar05"
    Me.cmdSelecionar05.Size = New System.Drawing.Size(16, 23)
    Me.cmdSelecionar05.TabIndex = 171
    Me.cmdSelecionar05.Text = "V"
    Me.cmdSelecionar05.UseVisualStyleBackColor = True
    '
    'cmdSelecionar06
    '
    Me.cmdSelecionar06.Location = New System.Drawing.Point(9, 326)
    Me.cmdSelecionar06.Name = "cmdSelecionar06"
    Me.cmdSelecionar06.Size = New System.Drawing.Size(16, 23)
    Me.cmdSelecionar06.TabIndex = 172
    Me.cmdSelecionar06.Text = "V"
    Me.cmdSelecionar06.UseVisualStyleBackColor = True
    '
    'cmdTodasPendentes
    '
    Me.cmdTodasPendentes.Location = New System.Drawing.Point(10, 174)
    Me.cmdTodasPendentes.Name = "cmdTodasPendentes"
    Me.cmdTodasPendentes.Size = New System.Drawing.Size(13, 13)
    Me.cmdTodasPendentes.TabIndex = 173
    Me.cmdTodasPendentes.Text = "."
    Me.cmdTodasPendentes.UseVisualStyleBackColor = True
    '
    'cmdTodosRemover
    '
    Me.cmdTodosRemover.Location = New System.Drawing.Point(10, 438)
    Me.cmdTodosRemover.Name = "cmdTodosRemover"
    Me.cmdTodosRemover.Size = New System.Drawing.Size(13, 13)
    Me.cmdTodosRemover.TabIndex = 174
    Me.cmdTodosRemover.Text = "."
    Me.cmdTodosRemover.UseVisualStyleBackColor = True
    '
    'cmdRemover01
    '
    Me.cmdRemover01.Location = New System.Drawing.Point(9, 455)
    Me.cmdRemover01.Name = "cmdRemover01"
    Me.cmdRemover01.Size = New System.Drawing.Size(16, 23)
    Me.cmdRemover01.TabIndex = 175
    Me.cmdRemover01.Text = "X"
    Me.cmdRemover01.UseVisualStyleBackColor = True
    '
    'cmdRemover02
    '
    Me.cmdRemover02.Location = New System.Drawing.Point(9, 482)
    Me.cmdRemover02.Name = "cmdRemover02"
    Me.cmdRemover02.Size = New System.Drawing.Size(16, 23)
    Me.cmdRemover02.TabIndex = 176
    Me.cmdRemover02.Text = "X"
    Me.cmdRemover02.UseVisualStyleBackColor = True
    '
    'cmdRemover03
    '
    Me.cmdRemover03.Location = New System.Drawing.Point(9, 509)
    Me.cmdRemover03.Name = "cmdRemover03"
    Me.cmdRemover03.Size = New System.Drawing.Size(16, 23)
    Me.cmdRemover03.TabIndex = 177
    Me.cmdRemover03.Text = "X"
    Me.cmdRemover03.UseVisualStyleBackColor = True
    '
    'cmdRemover04
    '
    Me.cmdRemover04.Location = New System.Drawing.Point(9, 536)
    Me.cmdRemover04.Name = "cmdRemover04"
    Me.cmdRemover04.Size = New System.Drawing.Size(16, 23)
    Me.cmdRemover04.TabIndex = 178
    Me.cmdRemover04.Text = "X"
    Me.cmdRemover04.UseVisualStyleBackColor = True
    '
    'cmdRemover05
    '
    Me.cmdRemover05.Location = New System.Drawing.Point(9, 563)
    Me.cmdRemover05.Name = "cmdRemover05"
    Me.cmdRemover05.Size = New System.Drawing.Size(16, 23)
    Me.cmdRemover05.TabIndex = 179
    Me.cmdRemover05.Text = "X"
    Me.cmdRemover05.UseVisualStyleBackColor = True
    '
    'cmdRemover06
    '
    Me.cmdRemover06.Location = New System.Drawing.Point(9, 590)
    Me.cmdRemover06.Name = "cmdRemover06"
    Me.cmdRemover06.Size = New System.Drawing.Size(16, 23)
    Me.cmdRemover06.TabIndex = 180
    Me.cmdRemover06.Text = "X"
    Me.cmdRemover06.UseVisualStyleBackColor = True
    '
    'lblPCodAutorizacao01
    '
    Me.lblPCodAutorizacao01.AutoSize = True
    Me.lblPCodAutorizacao01.Location = New System.Drawing.Point(34, 197)
    Me.lblPCodAutorizacao01.Name = "lblPCodAutorizacao01"
    Me.lblPCodAutorizacao01.Size = New System.Drawing.Size(87, 13)
    Me.lblPCodAutorizacao01.TabIndex = 181
    Me.lblPCodAutorizacao01.Text = "lblPCodAutoriz01"
    '
    'lblPCodAutorizacao02
    '
    Me.lblPCodAutorizacao02.AutoSize = True
    Me.lblPCodAutorizacao02.Location = New System.Drawing.Point(34, 223)
    Me.lblPCodAutorizacao02.Name = "lblPCodAutorizacao02"
    Me.lblPCodAutorizacao02.Size = New System.Drawing.Size(87, 13)
    Me.lblPCodAutorizacao02.TabIndex = 182
    Me.lblPCodAutorizacao02.Text = "lblPCodAutoriz01"
    '
    'lblPCodAutorizacao03
    '
    Me.lblPCodAutorizacao03.AutoSize = True
    Me.lblPCodAutorizacao03.Location = New System.Drawing.Point(34, 250)
    Me.lblPCodAutorizacao03.Name = "lblPCodAutorizacao03"
    Me.lblPCodAutorizacao03.Size = New System.Drawing.Size(87, 13)
    Me.lblPCodAutorizacao03.TabIndex = 183
    Me.lblPCodAutorizacao03.Text = "lblPCodAutoriz01"
    '
    'lblPCodAutorizacao04
    '
    Me.lblPCodAutorizacao04.AutoSize = True
    Me.lblPCodAutorizacao04.Location = New System.Drawing.Point(34, 277)
    Me.lblPCodAutorizacao04.Name = "lblPCodAutorizacao04"
    Me.lblPCodAutorizacao04.Size = New System.Drawing.Size(87, 13)
    Me.lblPCodAutorizacao04.TabIndex = 184
    Me.lblPCodAutorizacao04.Text = "lblPCodAutoriz01"
    '
    'lblPCodAutorizacao05
    '
    Me.lblPCodAutorizacao05.AutoSize = True
    Me.lblPCodAutorizacao05.Location = New System.Drawing.Point(34, 304)
    Me.lblPCodAutorizacao05.Name = "lblPCodAutorizacao05"
    Me.lblPCodAutorizacao05.Size = New System.Drawing.Size(87, 13)
    Me.lblPCodAutorizacao05.TabIndex = 185
    Me.lblPCodAutorizacao05.Text = "lblPCodAutoriz01"
    '
    'lblPCodAutorizacao06
    '
    Me.lblPCodAutorizacao06.AutoSize = True
    Me.lblPCodAutorizacao06.Location = New System.Drawing.Point(34, 332)
    Me.lblPCodAutorizacao06.Name = "lblPCodAutorizacao06"
    Me.lblPCodAutorizacao06.Size = New System.Drawing.Size(87, 13)
    Me.lblPCodAutorizacao06.TabIndex = 186
    Me.lblPCodAutorizacao06.Text = "lblPCodAutoriz01"
    '
    'lblPData06
    '
    Me.lblPData06.AutoSize = True
    Me.lblPData06.Location = New System.Drawing.Point(125, 332)
    Me.lblPData06.Name = "lblPData06"
    Me.lblPData06.Size = New System.Drawing.Size(59, 13)
    Me.lblPData06.TabIndex = 192
    Me.lblPData06.Text = "lblPData01"
    '
    'lblPData05
    '
    Me.lblPData05.AutoSize = True
    Me.lblPData05.Location = New System.Drawing.Point(125, 304)
    Me.lblPData05.Name = "lblPData05"
    Me.lblPData05.Size = New System.Drawing.Size(59, 13)
    Me.lblPData05.TabIndex = 191
    Me.lblPData05.Text = "lblPData01"
    '
    'lblPData04
    '
    Me.lblPData04.AutoSize = True
    Me.lblPData04.Location = New System.Drawing.Point(125, 277)
    Me.lblPData04.Name = "lblPData04"
    Me.lblPData04.Size = New System.Drawing.Size(59, 13)
    Me.lblPData04.TabIndex = 190
    Me.lblPData04.Text = "lblPData01"
    '
    'lblPData03
    '
    Me.lblPData03.AutoSize = True
    Me.lblPData03.Location = New System.Drawing.Point(125, 250)
    Me.lblPData03.Name = "lblPData03"
    Me.lblPData03.Size = New System.Drawing.Size(59, 13)
    Me.lblPData03.TabIndex = 189
    Me.lblPData03.Text = "lblPData01"
    '
    'lblPData02
    '
    Me.lblPData02.AutoSize = True
    Me.lblPData02.Location = New System.Drawing.Point(125, 223)
    Me.lblPData02.Name = "lblPData02"
    Me.lblPData02.Size = New System.Drawing.Size(59, 13)
    Me.lblPData02.TabIndex = 188
    Me.lblPData02.Text = "lblPData01"
    '
    'lblPData01
    '
    Me.lblPData01.AutoSize = True
    Me.lblPData01.Location = New System.Drawing.Point(125, 197)
    Me.lblPData01.Name = "lblPData01"
    Me.lblPData01.Size = New System.Drawing.Size(59, 13)
    Me.lblPData01.TabIndex = 187
    Me.lblPData01.Text = "lblPData01"
    '
    'lblPMedicoPrestador06
    '
    Me.lblPMedicoPrestador06.AutoSize = True
    Me.lblPMedicoPrestador06.Location = New System.Drawing.Point(232, 332)
    Me.lblPMedicoPrestador06.Name = "lblPMedicoPrestador06"
    Me.lblPMedicoPrestador06.Size = New System.Drawing.Size(116, 13)
    Me.lblPMedicoPrestador06.TabIndex = 198
    Me.lblPMedicoPrestador06.Text = "lblPMedicoPrestador01"
    '
    'lblPMedicoPrestador05
    '
    Me.lblPMedicoPrestador05.AutoSize = True
    Me.lblPMedicoPrestador05.Location = New System.Drawing.Point(232, 304)
    Me.lblPMedicoPrestador05.Name = "lblPMedicoPrestador05"
    Me.lblPMedicoPrestador05.Size = New System.Drawing.Size(116, 13)
    Me.lblPMedicoPrestador05.TabIndex = 197
    Me.lblPMedicoPrestador05.Text = "lblPMedicoPrestador01"
    '
    'lblPMedicoPrestador04
    '
    Me.lblPMedicoPrestador04.AutoSize = True
    Me.lblPMedicoPrestador04.Location = New System.Drawing.Point(232, 277)
    Me.lblPMedicoPrestador04.Name = "lblPMedicoPrestador04"
    Me.lblPMedicoPrestador04.Size = New System.Drawing.Size(116, 13)
    Me.lblPMedicoPrestador04.TabIndex = 196
    Me.lblPMedicoPrestador04.Text = "lblPMedicoPrestador01"
    '
    'lblPMedicoPrestador03
    '
    Me.lblPMedicoPrestador03.AutoSize = True
    Me.lblPMedicoPrestador03.Location = New System.Drawing.Point(232, 250)
    Me.lblPMedicoPrestador03.Name = "lblPMedicoPrestador03"
    Me.lblPMedicoPrestador03.Size = New System.Drawing.Size(116, 13)
    Me.lblPMedicoPrestador03.TabIndex = 195
    Me.lblPMedicoPrestador03.Text = "lblPMedicoPrestador01"
    '
    'lblPMedicoPrestador02
    '
    Me.lblPMedicoPrestador02.AutoSize = True
    Me.lblPMedicoPrestador02.Location = New System.Drawing.Point(232, 223)
    Me.lblPMedicoPrestador02.Name = "lblPMedicoPrestador02"
    Me.lblPMedicoPrestador02.Size = New System.Drawing.Size(116, 13)
    Me.lblPMedicoPrestador02.TabIndex = 194
    Me.lblPMedicoPrestador02.Text = "lblPMedicoPrestador01"
    '
    'lblPMedicoPrestador01
    '
    Me.lblPMedicoPrestador01.AutoSize = True
    Me.lblPMedicoPrestador01.Location = New System.Drawing.Point(232, 197)
    Me.lblPMedicoPrestador01.Name = "lblPMedicoPrestador01"
    Me.lblPMedicoPrestador01.Size = New System.Drawing.Size(116, 13)
    Me.lblPMedicoPrestador01.TabIndex = 193
    Me.lblPMedicoPrestador01.Text = "lblPMedicoPrestador01"
    '
    'lblPPaciente06
    '
    Me.lblPPaciente06.AutoSize = True
    Me.lblPPaciente06.Location = New System.Drawing.Point(425, 332)
    Me.lblPPaciente06.Name = "lblPPaciente06"
    Me.lblPPaciente06.Size = New System.Drawing.Size(78, 13)
    Me.lblPPaciente06.TabIndex = 204
    Me.lblPPaciente06.Text = "lblPPaciente01"
    '
    'lblPPaciente05
    '
    Me.lblPPaciente05.AutoSize = True
    Me.lblPPaciente05.Location = New System.Drawing.Point(425, 304)
    Me.lblPPaciente05.Name = "lblPPaciente05"
    Me.lblPPaciente05.Size = New System.Drawing.Size(78, 13)
    Me.lblPPaciente05.TabIndex = 203
    Me.lblPPaciente05.Text = "lblPPaciente01"
    '
    'lblPPaciente04
    '
    Me.lblPPaciente04.AutoSize = True
    Me.lblPPaciente04.Location = New System.Drawing.Point(425, 277)
    Me.lblPPaciente04.Name = "lblPPaciente04"
    Me.lblPPaciente04.Size = New System.Drawing.Size(78, 13)
    Me.lblPPaciente04.TabIndex = 202
    Me.lblPPaciente04.Text = "lblPPaciente01"
    '
    'lblPPaciente03
    '
    Me.lblPPaciente03.AutoSize = True
    Me.lblPPaciente03.Location = New System.Drawing.Point(425, 250)
    Me.lblPPaciente03.Name = "lblPPaciente03"
    Me.lblPPaciente03.Size = New System.Drawing.Size(78, 13)
    Me.lblPPaciente03.TabIndex = 201
    Me.lblPPaciente03.Text = "lblPPaciente01"
    '
    'lblPPaciente02
    '
    Me.lblPPaciente02.AutoSize = True
    Me.lblPPaciente02.Location = New System.Drawing.Point(425, 223)
    Me.lblPPaciente02.Name = "lblPPaciente02"
    Me.lblPPaciente02.Size = New System.Drawing.Size(78, 13)
    Me.lblPPaciente02.TabIndex = 200
    Me.lblPPaciente02.Text = "lblPPaciente01"
    '
    'lblPPaciente01
    '
    Me.lblPPaciente01.AutoSize = True
    Me.lblPPaciente01.Location = New System.Drawing.Point(425, 197)
    Me.lblPPaciente01.Name = "lblPPaciente01"
    Me.lblPPaciente01.Size = New System.Drawing.Size(78, 13)
    Me.lblPPaciente01.TabIndex = 199
    Me.lblPPaciente01.Text = "lblPPaciente01"
    '
    'lblPTipoAtendimento06
    '
    Me.lblPTipoAtendimento06.AutoSize = True
    Me.lblPTipoAtendimento06.Location = New System.Drawing.Point(636, 332)
    Me.lblPTipoAtendimento06.Name = "lblPTipoAtendimento06"
    Me.lblPTipoAtendimento06.Size = New System.Drawing.Size(95, 13)
    Me.lblPTipoAtendimento06.TabIndex = 210
    Me.lblPTipoAtendimento06.Text = "lblPTipoAtendim01"
    '
    'lblPTipoAtendimento05
    '
    Me.lblPTipoAtendimento05.AutoSize = True
    Me.lblPTipoAtendimento05.Location = New System.Drawing.Point(636, 304)
    Me.lblPTipoAtendimento05.Name = "lblPTipoAtendimento05"
    Me.lblPTipoAtendimento05.Size = New System.Drawing.Size(95, 13)
    Me.lblPTipoAtendimento05.TabIndex = 209
    Me.lblPTipoAtendimento05.Text = "lblPTipoAtendim01"
    '
    'lblPTipoAtendimento04
    '
    Me.lblPTipoAtendimento04.AutoSize = True
    Me.lblPTipoAtendimento04.Location = New System.Drawing.Point(636, 277)
    Me.lblPTipoAtendimento04.Name = "lblPTipoAtendimento04"
    Me.lblPTipoAtendimento04.Size = New System.Drawing.Size(95, 13)
    Me.lblPTipoAtendimento04.TabIndex = 208
    Me.lblPTipoAtendimento04.Text = "lblPTipoAtendim01"
    '
    'lblPTipoAtendimento03
    '
    Me.lblPTipoAtendimento03.AutoSize = True
    Me.lblPTipoAtendimento03.Location = New System.Drawing.Point(636, 250)
    Me.lblPTipoAtendimento03.Name = "lblPTipoAtendimento03"
    Me.lblPTipoAtendimento03.Size = New System.Drawing.Size(95, 13)
    Me.lblPTipoAtendimento03.TabIndex = 207
    Me.lblPTipoAtendimento03.Text = "lblPTipoAtendim01"
    '
    'lblPTipoAtendimento02
    '
    Me.lblPTipoAtendimento02.AutoSize = True
    Me.lblPTipoAtendimento02.Location = New System.Drawing.Point(636, 223)
    Me.lblPTipoAtendimento02.Name = "lblPTipoAtendimento02"
    Me.lblPTipoAtendimento02.Size = New System.Drawing.Size(95, 13)
    Me.lblPTipoAtendimento02.TabIndex = 206
    Me.lblPTipoAtendimento02.Text = "lblPTipoAtendim01"
    '
    'lblPTipoAtendimento01
    '
    Me.lblPTipoAtendimento01.AutoSize = True
    Me.lblPTipoAtendimento01.Location = New System.Drawing.Point(636, 197)
    Me.lblPTipoAtendimento01.Name = "lblPTipoAtendimento01"
    Me.lblPTipoAtendimento01.Size = New System.Drawing.Size(95, 13)
    Me.lblPTipoAtendimento01.TabIndex = 205
    Me.lblPTipoAtendimento01.Text = "lblPTipoAtendim01"
    '
    'lblPValor06
    '
    Me.lblPValor06.Location = New System.Drawing.Point(744, 332)
    Me.lblPValor06.Name = "lblPValor06"
    Me.lblPValor06.Size = New System.Drawing.Size(90, 13)
    Me.lblPValor06.TabIndex = 216
    Me.lblPValor06.Text = "lblPValor01"
    Me.lblPValor06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPValor05
    '
    Me.lblPValor05.Location = New System.Drawing.Point(744, 304)
    Me.lblPValor05.Name = "lblPValor05"
    Me.lblPValor05.Size = New System.Drawing.Size(90, 13)
    Me.lblPValor05.TabIndex = 215
    Me.lblPValor05.Text = "lblPValor01"
    Me.lblPValor05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPValor04
    '
    Me.lblPValor04.Location = New System.Drawing.Point(744, 277)
    Me.lblPValor04.Name = "lblPValor04"
    Me.lblPValor04.Size = New System.Drawing.Size(90, 13)
    Me.lblPValor04.TabIndex = 214
    Me.lblPValor04.Text = "lblPValor01"
    Me.lblPValor04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPValor03
    '
    Me.lblPValor03.Location = New System.Drawing.Point(744, 250)
    Me.lblPValor03.Name = "lblPValor03"
    Me.lblPValor03.Size = New System.Drawing.Size(90, 13)
    Me.lblPValor03.TabIndex = 213
    Me.lblPValor03.Text = "lblPValor01"
    Me.lblPValor03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPValor02
    '
    Me.lblPValor02.Location = New System.Drawing.Point(744, 223)
    Me.lblPValor02.Name = "lblPValor02"
    Me.lblPValor02.Size = New System.Drawing.Size(90, 13)
    Me.lblPValor02.TabIndex = 212
    Me.lblPValor02.Text = "lblPValor01"
    Me.lblPValor02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPValor01
    '
    Me.lblPValor01.Location = New System.Drawing.Point(744, 197)
    Me.lblPValor01.Name = "lblPValor01"
    Me.lblPValor01.Size = New System.Drawing.Size(90, 13)
    Me.lblPValor01.TabIndex = 211
    Me.lblPValor01.Text = "lblPValor01"
    Me.lblPValor01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPVlPrestador06
    '
    Me.lblPVlPrestador06.Location = New System.Drawing.Point(841, 332)
    Me.lblPVlPrestador06.Name = "lblPVlPrestador06"
    Me.lblPVlPrestador06.Size = New System.Drawing.Size(81, 13)
    Me.lblPVlPrestador06.TabIndex = 222
    Me.lblPVlPrestador06.Text = "lblPVlPrestador01"
    Me.lblPVlPrestador06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPVlPrestador05
    '
    Me.lblPVlPrestador05.Location = New System.Drawing.Point(841, 304)
    Me.lblPVlPrestador05.Name = "lblPVlPrestador05"
    Me.lblPVlPrestador05.Size = New System.Drawing.Size(81, 13)
    Me.lblPVlPrestador05.TabIndex = 221
    Me.lblPVlPrestador05.Text = "lblPVlPrestador01"
    Me.lblPVlPrestador05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPVlPrestador04
    '
    Me.lblPVlPrestador04.Location = New System.Drawing.Point(841, 277)
    Me.lblPVlPrestador04.Name = "lblPVlPrestador04"
    Me.lblPVlPrestador04.Size = New System.Drawing.Size(81, 13)
    Me.lblPVlPrestador04.TabIndex = 220
    Me.lblPVlPrestador04.Text = "lblPVlPrestador01"
    Me.lblPVlPrestador04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPVlPrestador03
    '
    Me.lblPVlPrestador03.Location = New System.Drawing.Point(841, 250)
    Me.lblPVlPrestador03.Name = "lblPVlPrestador03"
    Me.lblPVlPrestador03.Size = New System.Drawing.Size(81, 13)
    Me.lblPVlPrestador03.TabIndex = 219
    Me.lblPVlPrestador03.Text = "lblPVlPrestador01"
    Me.lblPVlPrestador03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPVlPrestador02
    '
    Me.lblPVlPrestador02.Location = New System.Drawing.Point(841, 223)
    Me.lblPVlPrestador02.Name = "lblPVlPrestador02"
    Me.lblPVlPrestador02.Size = New System.Drawing.Size(81, 13)
    Me.lblPVlPrestador02.TabIndex = 218
    Me.lblPVlPrestador02.Text = "lblPVlPrestador01"
    Me.lblPVlPrestador02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPVlPrestador01
    '
    Me.lblPVlPrestador01.Location = New System.Drawing.Point(841, 197)
    Me.lblPVlPrestador01.Name = "lblPVlPrestador01"
    Me.lblPVlPrestador01.Size = New System.Drawing.Size(81, 13)
    Me.lblPVlPrestador01.TabIndex = 217
    Me.lblPVlPrestador01.Text = "lblPVlPrestador01"
    Me.lblPVlPrestador01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFVlPrestador06
    '
    Me.lblFVlPrestador06.Location = New System.Drawing.Point(841, 595)
    Me.lblFVlPrestador06.Name = "lblFVlPrestador06"
    Me.lblFVlPrestador06.Size = New System.Drawing.Size(81, 13)
    Me.lblFVlPrestador06.TabIndex = 264
    Me.lblFVlPrestador06.Text = "lblFVlPrestador01"
    Me.lblFVlPrestador06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFVlPrestador05
    '
    Me.lblFVlPrestador05.Location = New System.Drawing.Point(841, 568)
    Me.lblFVlPrestador05.Name = "lblFVlPrestador05"
    Me.lblFVlPrestador05.Size = New System.Drawing.Size(81, 13)
    Me.lblFVlPrestador05.TabIndex = 263
    Me.lblFVlPrestador05.Text = "lblFVlPrestador01"
    Me.lblFVlPrestador05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFVlPrestador04
    '
    Me.lblFVlPrestador04.Location = New System.Drawing.Point(841, 541)
    Me.lblFVlPrestador04.Name = "lblFVlPrestador04"
    Me.lblFVlPrestador04.Size = New System.Drawing.Size(81, 13)
    Me.lblFVlPrestador04.TabIndex = 262
    Me.lblFVlPrestador04.Text = "lblFVlPrestador01"
    Me.lblFVlPrestador04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFVlPrestador03
    '
    Me.lblFVlPrestador03.Location = New System.Drawing.Point(841, 514)
    Me.lblFVlPrestador03.Name = "lblFVlPrestador03"
    Me.lblFVlPrestador03.Size = New System.Drawing.Size(81, 13)
    Me.lblFVlPrestador03.TabIndex = 261
    Me.lblFVlPrestador03.Text = "lblFVlPrestador01"
    Me.lblFVlPrestador03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFVlPrestador02
    '
    Me.lblFVlPrestador02.Location = New System.Drawing.Point(841, 487)
    Me.lblFVlPrestador02.Name = "lblFVlPrestador02"
    Me.lblFVlPrestador02.Size = New System.Drawing.Size(81, 13)
    Me.lblFVlPrestador02.TabIndex = 260
    Me.lblFVlPrestador02.Text = "lblFVlPrestador01"
    Me.lblFVlPrestador02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFVlPrestador01
    '
    Me.lblFVlPrestador01.Location = New System.Drawing.Point(841, 460)
    Me.lblFVlPrestador01.Name = "lblFVlPrestador01"
    Me.lblFVlPrestador01.Size = New System.Drawing.Size(81, 13)
    Me.lblFVlPrestador01.TabIndex = 259
    Me.lblFVlPrestador01.Text = "lblFVlPrestador01"
    Me.lblFVlPrestador01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFValor06
    '
    Me.lblFValor06.Location = New System.Drawing.Point(744, 595)
    Me.lblFValor06.Name = "lblFValor06"
    Me.lblFValor06.Size = New System.Drawing.Size(90, 13)
    Me.lblFValor06.TabIndex = 258
    Me.lblFValor06.Text = "lblFValor01"
    Me.lblFValor06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFValor05
    '
    Me.lblFValor05.Location = New System.Drawing.Point(744, 568)
    Me.lblFValor05.Name = "lblFValor05"
    Me.lblFValor05.Size = New System.Drawing.Size(90, 13)
    Me.lblFValor05.TabIndex = 257
    Me.lblFValor05.Text = "lblFValor01"
    Me.lblFValor05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFValor04
    '
    Me.lblFValor04.Location = New System.Drawing.Point(744, 541)
    Me.lblFValor04.Name = "lblFValor04"
    Me.lblFValor04.Size = New System.Drawing.Size(90, 13)
    Me.lblFValor04.TabIndex = 256
    Me.lblFValor04.Text = "lblFValor01"
    Me.lblFValor04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFValor03
    '
    Me.lblFValor03.Location = New System.Drawing.Point(744, 514)
    Me.lblFValor03.Name = "lblFValor03"
    Me.lblFValor03.Size = New System.Drawing.Size(90, 13)
    Me.lblFValor03.TabIndex = 255
    Me.lblFValor03.Text = "lblFValor01"
    Me.lblFValor03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFValor02
    '
    Me.lblFValor02.Location = New System.Drawing.Point(744, 487)
    Me.lblFValor02.Name = "lblFValor02"
    Me.lblFValor02.Size = New System.Drawing.Size(90, 13)
    Me.lblFValor02.TabIndex = 254
    Me.lblFValor02.Text = "lblFValor01"
    Me.lblFValor02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFValor01
    '
    Me.lblFValor01.Location = New System.Drawing.Point(744, 460)
    Me.lblFValor01.Name = "lblFValor01"
    Me.lblFValor01.Size = New System.Drawing.Size(90, 13)
    Me.lblFValor01.TabIndex = 253
    Me.lblFValor01.Text = "lblFValor01"
    Me.lblFValor01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFTipoAtendimento06
    '
    Me.lblFTipoAtendimento06.AutoSize = True
    Me.lblFTipoAtendimento06.Location = New System.Drawing.Point(636, 595)
    Me.lblFTipoAtendimento06.Name = "lblFTipoAtendimento06"
    Me.lblFTipoAtendimento06.Size = New System.Drawing.Size(94, 13)
    Me.lblFTipoAtendimento06.TabIndex = 252
    Me.lblFTipoAtendimento06.Text = "lblFTipoAtendim01"
    '
    'lblFTipoAtendimento05
    '
    Me.lblFTipoAtendimento05.AutoSize = True
    Me.lblFTipoAtendimento05.Location = New System.Drawing.Point(636, 568)
    Me.lblFTipoAtendimento05.Name = "lblFTipoAtendimento05"
    Me.lblFTipoAtendimento05.Size = New System.Drawing.Size(94, 13)
    Me.lblFTipoAtendimento05.TabIndex = 251
    Me.lblFTipoAtendimento05.Text = "lblFTipoAtendim01"
    '
    'lblFTipoAtendimento04
    '
    Me.lblFTipoAtendimento04.AutoSize = True
    Me.lblFTipoAtendimento04.Location = New System.Drawing.Point(636, 541)
    Me.lblFTipoAtendimento04.Name = "lblFTipoAtendimento04"
    Me.lblFTipoAtendimento04.Size = New System.Drawing.Size(94, 13)
    Me.lblFTipoAtendimento04.TabIndex = 250
    Me.lblFTipoAtendimento04.Text = "lblFTipoAtendim01"
    '
    'lblFTipoAtendimento03
    '
    Me.lblFTipoAtendimento03.AutoSize = True
    Me.lblFTipoAtendimento03.Location = New System.Drawing.Point(636, 514)
    Me.lblFTipoAtendimento03.Name = "lblFTipoAtendimento03"
    Me.lblFTipoAtendimento03.Size = New System.Drawing.Size(94, 13)
    Me.lblFTipoAtendimento03.TabIndex = 249
    Me.lblFTipoAtendimento03.Text = "lblFTipoAtendim01"
    '
    'lblFTipoAtendimento02
    '
    Me.lblFTipoAtendimento02.AutoSize = True
    Me.lblFTipoAtendimento02.Location = New System.Drawing.Point(636, 487)
    Me.lblFTipoAtendimento02.Name = "lblFTipoAtendimento02"
    Me.lblFTipoAtendimento02.Size = New System.Drawing.Size(94, 13)
    Me.lblFTipoAtendimento02.TabIndex = 248
    Me.lblFTipoAtendimento02.Text = "lblFTipoAtendim01"
    '
    'lblFTipoAtendimento01
    '
    Me.lblFTipoAtendimento01.AutoSize = True
    Me.lblFTipoAtendimento01.Location = New System.Drawing.Point(636, 460)
    Me.lblFTipoAtendimento01.Name = "lblFTipoAtendimento01"
    Me.lblFTipoAtendimento01.Size = New System.Drawing.Size(94, 13)
    Me.lblFTipoAtendimento01.TabIndex = 247
    Me.lblFTipoAtendimento01.Text = "lblFTipoAtendim01"
    '
    'lblFPaciente06
    '
    Me.lblFPaciente06.AutoSize = True
    Me.lblFPaciente06.Location = New System.Drawing.Point(425, 595)
    Me.lblFPaciente06.Name = "lblFPaciente06"
    Me.lblFPaciente06.Size = New System.Drawing.Size(77, 13)
    Me.lblFPaciente06.TabIndex = 246
    Me.lblFPaciente06.Text = "lblFPaciente01"
    '
    'lblFPaciente05
    '
    Me.lblFPaciente05.AutoSize = True
    Me.lblFPaciente05.Location = New System.Drawing.Point(425, 568)
    Me.lblFPaciente05.Name = "lblFPaciente05"
    Me.lblFPaciente05.Size = New System.Drawing.Size(77, 13)
    Me.lblFPaciente05.TabIndex = 245
    Me.lblFPaciente05.Text = "lblFPaciente01"
    '
    'lblFPaciente04
    '
    Me.lblFPaciente04.AutoSize = True
    Me.lblFPaciente04.Location = New System.Drawing.Point(425, 541)
    Me.lblFPaciente04.Name = "lblFPaciente04"
    Me.lblFPaciente04.Size = New System.Drawing.Size(77, 13)
    Me.lblFPaciente04.TabIndex = 244
    Me.lblFPaciente04.Text = "lblFPaciente01"
    '
    'lblFPaciente03
    '
    Me.lblFPaciente03.AutoSize = True
    Me.lblFPaciente03.Location = New System.Drawing.Point(425, 514)
    Me.lblFPaciente03.Name = "lblFPaciente03"
    Me.lblFPaciente03.Size = New System.Drawing.Size(77, 13)
    Me.lblFPaciente03.TabIndex = 243
    Me.lblFPaciente03.Text = "lblFPaciente01"
    '
    'lblFPaciente02
    '
    Me.lblFPaciente02.AutoSize = True
    Me.lblFPaciente02.Location = New System.Drawing.Point(425, 487)
    Me.lblFPaciente02.Name = "lblFPaciente02"
    Me.lblFPaciente02.Size = New System.Drawing.Size(77, 13)
    Me.lblFPaciente02.TabIndex = 242
    Me.lblFPaciente02.Text = "lblFPaciente01"
    '
    'lblFPaciente01
    '
    Me.lblFPaciente01.AutoSize = True
    Me.lblFPaciente01.Location = New System.Drawing.Point(425, 460)
    Me.lblFPaciente01.Name = "lblFPaciente01"
    Me.lblFPaciente01.Size = New System.Drawing.Size(77, 13)
    Me.lblFPaciente01.TabIndex = 241
    Me.lblFPaciente01.Text = "lblFPaciente01"
    '
    'lblFMedicoPrestador06
    '
    Me.lblFMedicoPrestador06.AutoSize = True
    Me.lblFMedicoPrestador06.Location = New System.Drawing.Point(232, 595)
    Me.lblFMedicoPrestador06.Name = "lblFMedicoPrestador06"
    Me.lblFMedicoPrestador06.Size = New System.Drawing.Size(115, 13)
    Me.lblFMedicoPrestador06.TabIndex = 240
    Me.lblFMedicoPrestador06.Text = "lblFMedicoPrestador01"
    '
    'lblFMedicoPrestador05
    '
    Me.lblFMedicoPrestador05.AutoSize = True
    Me.lblFMedicoPrestador05.Location = New System.Drawing.Point(232, 568)
    Me.lblFMedicoPrestador05.Name = "lblFMedicoPrestador05"
    Me.lblFMedicoPrestador05.Size = New System.Drawing.Size(115, 13)
    Me.lblFMedicoPrestador05.TabIndex = 239
    Me.lblFMedicoPrestador05.Text = "lblFMedicoPrestador01"
    '
    'lblFMedicoPrestador04
    '
    Me.lblFMedicoPrestador04.AutoSize = True
    Me.lblFMedicoPrestador04.Location = New System.Drawing.Point(232, 541)
    Me.lblFMedicoPrestador04.Name = "lblFMedicoPrestador04"
    Me.lblFMedicoPrestador04.Size = New System.Drawing.Size(115, 13)
    Me.lblFMedicoPrestador04.TabIndex = 238
    Me.lblFMedicoPrestador04.Text = "lblFMedicoPrestador01"
    '
    'lblFMedicoPrestador03
    '
    Me.lblFMedicoPrestador03.AutoSize = True
    Me.lblFMedicoPrestador03.Location = New System.Drawing.Point(232, 514)
    Me.lblFMedicoPrestador03.Name = "lblFMedicoPrestador03"
    Me.lblFMedicoPrestador03.Size = New System.Drawing.Size(115, 13)
    Me.lblFMedicoPrestador03.TabIndex = 237
    Me.lblFMedicoPrestador03.Text = "lblFMedicoPrestador01"
    '
    'lblFMedicoPrestador02
    '
    Me.lblFMedicoPrestador02.AutoSize = True
    Me.lblFMedicoPrestador02.Location = New System.Drawing.Point(232, 487)
    Me.lblFMedicoPrestador02.Name = "lblFMedicoPrestador02"
    Me.lblFMedicoPrestador02.Size = New System.Drawing.Size(115, 13)
    Me.lblFMedicoPrestador02.TabIndex = 236
    Me.lblFMedicoPrestador02.Text = "lblFMedicoPrestador01"
    '
    'lblFMedicoPrestador01
    '
    Me.lblFMedicoPrestador01.AutoSize = True
    Me.lblFMedicoPrestador01.Location = New System.Drawing.Point(232, 460)
    Me.lblFMedicoPrestador01.Name = "lblFMedicoPrestador01"
    Me.lblFMedicoPrestador01.Size = New System.Drawing.Size(115, 13)
    Me.lblFMedicoPrestador01.TabIndex = 235
    Me.lblFMedicoPrestador01.Text = "lblFMedicoPrestador01"
    '
    'lblFData06
    '
    Me.lblFData06.AutoSize = True
    Me.lblFData06.Location = New System.Drawing.Point(125, 595)
    Me.lblFData06.Name = "lblFData06"
    Me.lblFData06.Size = New System.Drawing.Size(59, 13)
    Me.lblFData06.TabIndex = 234
    Me.lblFData06.Text = "lblPData01"
    '
    'lblFData05
    '
    Me.lblFData05.AutoSize = True
    Me.lblFData05.Location = New System.Drawing.Point(125, 568)
    Me.lblFData05.Name = "lblFData05"
    Me.lblFData05.Size = New System.Drawing.Size(58, 13)
    Me.lblFData05.TabIndex = 233
    Me.lblFData05.Text = "lblFData01"
    '
    'lblFData04
    '
    Me.lblFData04.AutoSize = True
    Me.lblFData04.Location = New System.Drawing.Point(125, 541)
    Me.lblFData04.Name = "lblFData04"
    Me.lblFData04.Size = New System.Drawing.Size(58, 13)
    Me.lblFData04.TabIndex = 232
    Me.lblFData04.Text = "lblFData01"
    '
    'lblFData03
    '
    Me.lblFData03.AutoSize = True
    Me.lblFData03.Location = New System.Drawing.Point(125, 514)
    Me.lblFData03.Name = "lblFData03"
    Me.lblFData03.Size = New System.Drawing.Size(58, 13)
    Me.lblFData03.TabIndex = 231
    Me.lblFData03.Text = "lblFData01"
    '
    'lblFData02
    '
    Me.lblFData02.AutoSize = True
    Me.lblFData02.Location = New System.Drawing.Point(125, 487)
    Me.lblFData02.Name = "lblFData02"
    Me.lblFData02.Size = New System.Drawing.Size(58, 13)
    Me.lblFData02.TabIndex = 230
    Me.lblFData02.Text = "lblFData01"
    '
    'lblFData01
    '
    Me.lblFData01.AutoSize = True
    Me.lblFData01.Location = New System.Drawing.Point(125, 460)
    Me.lblFData01.Name = "lblFData01"
    Me.lblFData01.Size = New System.Drawing.Size(58, 13)
    Me.lblFData01.TabIndex = 229
    Me.lblFData01.Text = "lblFData01"
    '
    'lblFCodAutorizacao06
    '
    Me.lblFCodAutorizacao06.AutoSize = True
    Me.lblFCodAutorizacao06.Location = New System.Drawing.Point(34, 595)
    Me.lblFCodAutorizacao06.Name = "lblFCodAutorizacao06"
    Me.lblFCodAutorizacao06.Size = New System.Drawing.Size(86, 13)
    Me.lblFCodAutorizacao06.TabIndex = 228
    Me.lblFCodAutorizacao06.Text = "lblFCodAutoriz06"
    '
    'lblFCodAutorizacao05
    '
    Me.lblFCodAutorizacao05.AutoSize = True
    Me.lblFCodAutorizacao05.Location = New System.Drawing.Point(34, 568)
    Me.lblFCodAutorizacao05.Name = "lblFCodAutorizacao05"
    Me.lblFCodAutorizacao05.Size = New System.Drawing.Size(86, 13)
    Me.lblFCodAutorizacao05.TabIndex = 227
    Me.lblFCodAutorizacao05.Text = "lblFCodAutoriz05"
    '
    'lblFCodAutorizacao04
    '
    Me.lblFCodAutorizacao04.AutoSize = True
    Me.lblFCodAutorizacao04.Location = New System.Drawing.Point(34, 541)
    Me.lblFCodAutorizacao04.Name = "lblFCodAutorizacao04"
    Me.lblFCodAutorizacao04.Size = New System.Drawing.Size(86, 13)
    Me.lblFCodAutorizacao04.TabIndex = 226
    Me.lblFCodAutorizacao04.Text = "lblFCodAutoriz04"
    '
    'lblFCodAutorizacao03
    '
    Me.lblFCodAutorizacao03.AutoSize = True
    Me.lblFCodAutorizacao03.Location = New System.Drawing.Point(34, 514)
    Me.lblFCodAutorizacao03.Name = "lblFCodAutorizacao03"
    Me.lblFCodAutorizacao03.Size = New System.Drawing.Size(86, 13)
    Me.lblFCodAutorizacao03.TabIndex = 225
    Me.lblFCodAutorizacao03.Text = "lblFCodAutoriz03"
    '
    'lblFCodAutorizacao02
    '
    Me.lblFCodAutorizacao02.AutoSize = True
    Me.lblFCodAutorizacao02.Location = New System.Drawing.Point(34, 487)
    Me.lblFCodAutorizacao02.Name = "lblFCodAutorizacao02"
    Me.lblFCodAutorizacao02.Size = New System.Drawing.Size(86, 13)
    Me.lblFCodAutorizacao02.TabIndex = 224
    Me.lblFCodAutorizacao02.Text = "lblFCodAutoriz02"
    '
    'lblFCodAutorizacao01
    '
    Me.lblFCodAutorizacao01.AutoSize = True
    Me.lblFCodAutorizacao01.Location = New System.Drawing.Point(34, 460)
    Me.lblFCodAutorizacao01.Name = "lblFCodAutorizacao01"
    Me.lblFCodAutorizacao01.Size = New System.Drawing.Size(86, 13)
    Me.lblFCodAutorizacao01.TabIndex = 223
    Me.lblFCodAutorizacao01.Text = "lblFCodAutoriz01"
    '
    'lblPQdte
    '
    Me.lblPQdte.AutoSize = True
    Me.lblPQdte.Location = New System.Drawing.Point(55, 365)
    Me.lblPQdte.Name = "lblPQdte"
    Me.lblPQdte.Size = New System.Drawing.Size(59, 13)
    Me.lblPQdte.TabIndex = 265
    Me.lblPQdte.Text = "lblPQdte01"
    '
    'lblPValorTotal
    '
    Me.lblPValorTotal.Location = New System.Drawing.Point(745, 365)
    Me.lblPValorTotal.Name = "lblPValorTotal"
    Me.lblPValorTotal.Size = New System.Drawing.Size(90, 13)
    Me.lblPValorTotal.TabIndex = 266
    Me.lblPValorTotal.Text = "lblPValorTotal01"
    Me.lblPValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblPVlPrestTotal
    '
    Me.lblPVlPrestTotal.Location = New System.Drawing.Point(841, 365)
    Me.lblPVlPrestTotal.Name = "lblPVlPrestTotal"
    Me.lblPVlPrestTotal.Size = New System.Drawing.Size(81, 13)
    Me.lblPVlPrestTotal.TabIndex = 267
    Me.lblPVlPrestTotal.Text = "lblPVlPrestTotal1"
    Me.lblPVlPrestTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFVlPrestTotal
    '
    Me.lblFVlPrestTotal.Location = New System.Drawing.Point(841, 628)
    Me.lblFVlPrestTotal.Name = "lblFVlPrestTotal"
    Me.lblFVlPrestTotal.Size = New System.Drawing.Size(81, 13)
    Me.lblFVlPrestTotal.TabIndex = 270
    Me.lblFVlPrestTotal.Text = "lblFVlPrestTotal1"
    Me.lblFVlPrestTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFValorTotal
    '
    Me.lblFValorTotal.Location = New System.Drawing.Point(745, 628)
    Me.lblFValorTotal.Name = "lblFValorTotal"
    Me.lblFValorTotal.Size = New System.Drawing.Size(90, 13)
    Me.lblFValorTotal.TabIndex = 269
    Me.lblFValorTotal.Text = "lblFValorTotal01"
    Me.lblFValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblFQdte
    '
    Me.lblFQdte.AutoSize = True
    Me.lblFQdte.Location = New System.Drawing.Point(55, 628)
    Me.lblFQdte.Name = "lblFQdte"
    Me.lblFQdte.Size = New System.Drawing.Size(58, 13)
    Me.lblFQdte.TabIndex = 268
    Me.lblFQdte.Text = "lblFQdte01"
    '
    'vsbPendentes
    '
    Me.vsbPendentes.Location = New System.Drawing.Point(930, 195)
    Me.vsbPendentes.Name = "vsbPendentes"
    Me.vsbPendentes.Size = New System.Drawing.Size(17, 157)
    Me.vsbPendentes.TabIndex = 271
    '
    'vsbFaturar
    '
    Me.vsbFaturar.Location = New System.Drawing.Point(930, 458)
    Me.vsbFaturar.Name = "vsbFaturar"
    Me.vsbFaturar.Size = New System.Drawing.Size(17, 158)
    Me.vsbFaturar.TabIndex = 272
    '
    'txtCodAutorizacao
    '
    Me.txtCodAutorizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCodAutorizacao.Location = New System.Drawing.Point(10, 138)
    Me.txtCodAutorizacao.Name = "txtCodAutorizacao"
    Me.txtCodAutorizacao.Size = New System.Drawing.Size(122, 27)
    Me.txtCodAutorizacao.TabIndex = 274
    '
    'ComboBox1
    '
    Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Location = New System.Drawing.Point(506, 94)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
    Me.ComboBox1.TabIndex = 275
    '
    'psqPessoa
    '
    Me.psqPessoa.AdicionarPessoa = False
    Me.psqPessoa.Bordas = True
    Me.psqPessoa.CarregarTodos = False
    Me.psqPessoa.DS_Pessoa = ""
    Me.psqPessoa.ID_Pessoa = 0
    Me.psqPessoa.LabelVisivel = True
    Me.psqPessoa.Location = New System.Drawing.Point(639, 79)
    Me.psqPessoa.Name = "psqPessoa"
    Me.psqPessoa.PesquisarPessoa = True
    Me.psqPessoa.Rotulo = "Pessoa"
    Me.psqPessoa.Size = New System.Drawing.Size(308, 36)
    Me.psqPessoa.SomenteLeitura = False
    Me.psqPessoa.TabIndex = 276
    Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
    '
    'cmdFaturar
    '
    Me.cmdFaturar.AutoSize = True
    Me.cmdFaturar.Location = New System.Drawing.Point(645, 15)
    Me.cmdFaturar.Name = "cmdFaturar"
    Me.cmdFaturar.Size = New System.Drawing.Size(16, 17)
    Me.cmdFaturar.TabIndex = 273
    '
    'cmdImprimir
    '
    Me.cmdImprimir.AutoSize = True
    Me.cmdImprimir.Location = New System.Drawing.Point(746, 50)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
    Me.cmdImprimir.TabIndex = 166
    '
    'cmdFechar
    '
    Me.cmdFechar.AutoSize = True
    Me.cmdFechar.Location = New System.Drawing.Point(846, 50)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
    Me.cmdFechar.TabIndex = 165
    '
    'cmdListar
    '
    Me.cmdListar.AutoSize = True
    Me.cmdListar.Location = New System.Drawing.Point(645, 50)
    Me.cmdListar.Name = "cmdListar"
    Me.cmdListar.Size = New System.Drawing.Size(16, 17)
    Me.cmdListar.TabIndex = 1
    '
    'frmCadastroAtendimentoFaturamento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1264, 749)
    Me.Controls.Add(Me.psqPessoa)
    Me.Controls.Add(Me.ComboBox1)
    Me.Controls.Add(Me.txtCodAutorizacao)
    Me.Controls.Add(Me.cmdFaturar)
    Me.Controls.Add(Me.vsbFaturar)
    Me.Controls.Add(Me.vsbPendentes)
    Me.Controls.Add(Me.lblFVlPrestTotal)
    Me.Controls.Add(Me.lblFValorTotal)
    Me.Controls.Add(Me.lblFQdte)
    Me.Controls.Add(Me.lblPVlPrestTotal)
    Me.Controls.Add(Me.lblPValorTotal)
    Me.Controls.Add(Me.lblPQdte)
    Me.Controls.Add(Me.lblFVlPrestador06)
    Me.Controls.Add(Me.lblFVlPrestador05)
    Me.Controls.Add(Me.lblFVlPrestador04)
    Me.Controls.Add(Me.lblFVlPrestador03)
    Me.Controls.Add(Me.lblFVlPrestador02)
    Me.Controls.Add(Me.lblFVlPrestador01)
    Me.Controls.Add(Me.lblFValor06)
    Me.Controls.Add(Me.lblFValor05)
    Me.Controls.Add(Me.lblFValor04)
    Me.Controls.Add(Me.lblFValor03)
    Me.Controls.Add(Me.lblFValor02)
    Me.Controls.Add(Me.lblFValor01)
    Me.Controls.Add(Me.lblFTipoAtendimento06)
    Me.Controls.Add(Me.lblFTipoAtendimento05)
    Me.Controls.Add(Me.lblFTipoAtendimento04)
    Me.Controls.Add(Me.lblFTipoAtendimento03)
    Me.Controls.Add(Me.lblFTipoAtendimento02)
    Me.Controls.Add(Me.lblFTipoAtendimento01)
    Me.Controls.Add(Me.lblFPaciente06)
    Me.Controls.Add(Me.lblFPaciente05)
    Me.Controls.Add(Me.lblFPaciente04)
    Me.Controls.Add(Me.lblFPaciente03)
    Me.Controls.Add(Me.lblFPaciente02)
    Me.Controls.Add(Me.lblFPaciente01)
    Me.Controls.Add(Me.lblFMedicoPrestador06)
    Me.Controls.Add(Me.lblFMedicoPrestador05)
    Me.Controls.Add(Me.lblFMedicoPrestador04)
    Me.Controls.Add(Me.lblFMedicoPrestador03)
    Me.Controls.Add(Me.lblFMedicoPrestador02)
    Me.Controls.Add(Me.lblFMedicoPrestador01)
    Me.Controls.Add(Me.lblFData06)
    Me.Controls.Add(Me.lblFData05)
    Me.Controls.Add(Me.lblFData04)
    Me.Controls.Add(Me.lblFData03)
    Me.Controls.Add(Me.lblFData02)
    Me.Controls.Add(Me.lblFData01)
    Me.Controls.Add(Me.lblFCodAutorizacao06)
    Me.Controls.Add(Me.lblFCodAutorizacao05)
    Me.Controls.Add(Me.lblFCodAutorizacao04)
    Me.Controls.Add(Me.lblFCodAutorizacao03)
    Me.Controls.Add(Me.lblFCodAutorizacao02)
    Me.Controls.Add(Me.lblFCodAutorizacao01)
    Me.Controls.Add(Me.lblPVlPrestador06)
    Me.Controls.Add(Me.lblPVlPrestador05)
    Me.Controls.Add(Me.lblPVlPrestador04)
    Me.Controls.Add(Me.lblPVlPrestador03)
    Me.Controls.Add(Me.lblPVlPrestador02)
    Me.Controls.Add(Me.lblPVlPrestador01)
    Me.Controls.Add(Me.lblPValor06)
    Me.Controls.Add(Me.lblPValor05)
    Me.Controls.Add(Me.lblPValor04)
    Me.Controls.Add(Me.lblPValor03)
    Me.Controls.Add(Me.lblPValor02)
    Me.Controls.Add(Me.lblPValor01)
    Me.Controls.Add(Me.lblPTipoAtendimento06)
    Me.Controls.Add(Me.lblPTipoAtendimento05)
    Me.Controls.Add(Me.lblPTipoAtendimento04)
    Me.Controls.Add(Me.lblPTipoAtendimento03)
    Me.Controls.Add(Me.lblPTipoAtendimento02)
    Me.Controls.Add(Me.lblPTipoAtendimento01)
    Me.Controls.Add(Me.lblPPaciente06)
    Me.Controls.Add(Me.lblPPaciente05)
    Me.Controls.Add(Me.lblPPaciente04)
    Me.Controls.Add(Me.lblPPaciente03)
    Me.Controls.Add(Me.lblPPaciente02)
    Me.Controls.Add(Me.lblPPaciente01)
    Me.Controls.Add(Me.lblPMedicoPrestador06)
    Me.Controls.Add(Me.lblPMedicoPrestador05)
    Me.Controls.Add(Me.lblPMedicoPrestador04)
    Me.Controls.Add(Me.lblPMedicoPrestador03)
    Me.Controls.Add(Me.lblPMedicoPrestador02)
    Me.Controls.Add(Me.lblPMedicoPrestador01)
    Me.Controls.Add(Me.lblPData06)
    Me.Controls.Add(Me.lblPData05)
    Me.Controls.Add(Me.lblPData04)
    Me.Controls.Add(Me.lblPData03)
    Me.Controls.Add(Me.lblPData02)
    Me.Controls.Add(Me.lblPData01)
    Me.Controls.Add(Me.lblPCodAutorizacao06)
    Me.Controls.Add(Me.lblPCodAutorizacao05)
    Me.Controls.Add(Me.lblPCodAutorizacao04)
    Me.Controls.Add(Me.lblPCodAutorizacao03)
    Me.Controls.Add(Me.lblPCodAutorizacao02)
    Me.Controls.Add(Me.lblPCodAutorizacao01)
    Me.Controls.Add(Me.cmdRemover06)
    Me.Controls.Add(Me.cmdRemover05)
    Me.Controls.Add(Me.cmdRemover04)
    Me.Controls.Add(Me.cmdRemover03)
    Me.Controls.Add(Me.cmdRemover02)
    Me.Controls.Add(Me.cmdRemover01)
    Me.Controls.Add(Me.cmdTodosRemover)
    Me.Controls.Add(Me.cmdTodasPendentes)
    Me.Controls.Add(Me.cmdSelecionar06)
    Me.Controls.Add(Me.cmdSelecionar05)
    Me.Controls.Add(Me.cmdSelecionar04)
    Me.Controls.Add(Me.cmdSelecionar03)
    Me.Controls.Add(Me.cmdSelecionar02)
    Me.Controls.Add(Me.cmdSelecionar01)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.txtDataFinal)
    Me.Controls.Add(Me.txtDataInicial)
    Me.Controls.Add(Me.cboMedicoPrestador)
    Me.Controls.Add(Me.cmdListar)
    Me.Controls.Add(Me.picGeral)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroAtendimentoFaturamento"
    Me.Text = "Cadastro de Atendimento - Faturamento"
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdListar As uscBotao
  Friend WithEvents cboMedicoPrestador As ComboBox
  Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents cmdImprimir As uscBotao
  Friend WithEvents cmdSelecionar01 As Button
  Friend WithEvents cmdSelecionar02 As Button
  Friend WithEvents cmdSelecionar03 As Button
  Friend WithEvents cmdSelecionar04 As Button
  Friend WithEvents cmdSelecionar05 As Button
  Friend WithEvents cmdSelecionar06 As Button
  Friend WithEvents cmdTodasPendentes As Button
  Friend WithEvents cmdTodosRemover As Button
  Friend WithEvents cmdRemover01 As Button
  Friend WithEvents cmdRemover02 As Button
  Friend WithEvents cmdRemover03 As Button
  Friend WithEvents cmdRemover04 As Button
  Friend WithEvents cmdRemover05 As Button
  Friend WithEvents cmdRemover06 As Button
  Friend WithEvents lblPCodAutorizacao01 As Label
  Friend WithEvents lblPCodAutorizacao02 As Label
  Friend WithEvents lblPCodAutorizacao03 As Label
  Friend WithEvents lblPCodAutorizacao04 As Label
  Friend WithEvents lblPCodAutorizacao05 As Label
  Friend WithEvents lblPCodAutorizacao06 As Label
  Friend WithEvents lblPData06 As Label
  Friend WithEvents lblPData05 As Label
  Friend WithEvents lblPData04 As Label
  Friend WithEvents lblPData03 As Label
  Friend WithEvents lblPData02 As Label
  Friend WithEvents lblPData01 As Label
  Friend WithEvents lblPMedicoPrestador06 As Label
  Friend WithEvents lblPMedicoPrestador05 As Label
  Friend WithEvents lblPMedicoPrestador04 As Label
  Friend WithEvents lblPMedicoPrestador03 As Label
  Friend WithEvents lblPMedicoPrestador02 As Label
  Friend WithEvents lblPMedicoPrestador01 As Label
  Friend WithEvents lblPPaciente06 As Label
  Friend WithEvents lblPPaciente05 As Label
  Friend WithEvents lblPPaciente04 As Label
  Friend WithEvents lblPPaciente03 As Label
  Friend WithEvents lblPPaciente02 As Label
  Friend WithEvents lblPPaciente01 As Label
  Friend WithEvents lblPTipoAtendimento06 As Label
  Friend WithEvents lblPTipoAtendimento05 As Label
  Friend WithEvents lblPTipoAtendimento04 As Label
  Friend WithEvents lblPTipoAtendimento03 As Label
  Friend WithEvents lblPTipoAtendimento02 As Label
  Friend WithEvents lblPTipoAtendimento01 As Label
  Friend WithEvents lblPValor06 As Label
  Friend WithEvents lblPValor05 As Label
  Friend WithEvents lblPValor04 As Label
  Friend WithEvents lblPValor03 As Label
  Friend WithEvents lblPValor02 As Label
  Friend WithEvents lblPValor01 As Label
  Friend WithEvents lblPVlPrestador06 As Label
  Friend WithEvents lblPVlPrestador05 As Label
  Friend WithEvents lblPVlPrestador04 As Label
  Friend WithEvents lblPVlPrestador03 As Label
  Friend WithEvents lblPVlPrestador02 As Label
  Friend WithEvents lblPVlPrestador01 As Label
  Friend WithEvents lblFVlPrestador06 As Label
  Friend WithEvents lblFVlPrestador05 As Label
  Friend WithEvents lblFVlPrestador04 As Label
  Friend WithEvents lblFVlPrestador03 As Label
  Friend WithEvents lblFVlPrestador02 As Label
  Friend WithEvents lblFVlPrestador01 As Label
  Friend WithEvents lblFValor06 As Label
  Friend WithEvents lblFValor05 As Label
  Friend WithEvents lblFValor04 As Label
  Friend WithEvents lblFValor03 As Label
  Friend WithEvents lblFValor02 As Label
  Friend WithEvents lblFValor01 As Label
  Friend WithEvents lblFTipoAtendimento06 As Label
  Friend WithEvents lblFTipoAtendimento05 As Label
  Friend WithEvents lblFTipoAtendimento04 As Label
  Friend WithEvents lblFTipoAtendimento03 As Label
  Friend WithEvents lblFTipoAtendimento02 As Label
  Friend WithEvents lblFTipoAtendimento01 As Label
  Friend WithEvents lblFPaciente06 As Label
  Friend WithEvents lblFPaciente05 As Label
  Friend WithEvents lblFPaciente04 As Label
  Friend WithEvents lblFPaciente03 As Label
  Friend WithEvents lblFPaciente02 As Label
  Friend WithEvents lblFPaciente01 As Label
  Friend WithEvents lblFMedicoPrestador06 As Label
  Friend WithEvents lblFMedicoPrestador05 As Label
  Friend WithEvents lblFMedicoPrestador04 As Label
  Friend WithEvents lblFMedicoPrestador03 As Label
  Friend WithEvents lblFMedicoPrestador02 As Label
  Friend WithEvents lblFMedicoPrestador01 As Label
  Friend WithEvents lblFData06 As Label
  Friend WithEvents lblFData05 As Label
  Friend WithEvents lblFData04 As Label
  Friend WithEvents lblFData03 As Label
  Friend WithEvents lblFData02 As Label
  Friend WithEvents lblFData01 As Label
  Friend WithEvents lblFCodAutorizacao06 As Label
  Friend WithEvents lblFCodAutorizacao05 As Label
  Friend WithEvents lblFCodAutorizacao04 As Label
  Friend WithEvents lblFCodAutorizacao03 As Label
  Friend WithEvents lblFCodAutorizacao02 As Label
  Friend WithEvents lblFCodAutorizacao01 As Label
  Friend WithEvents lblPQdte As Label
  Friend WithEvents lblPValorTotal As Label
  Friend WithEvents lblPVlPrestTotal As Label
  Friend WithEvents lblFVlPrestTotal As Label
  Friend WithEvents lblFValorTotal As Label
  Friend WithEvents lblFQdte As Label
  Friend WithEvents vsbPendentes As VScrollBar
  Friend WithEvents vsbFaturar As VScrollBar
  Friend WithEvents cmdFaturar As uscBotao
    Friend WithEvents txtCodAutorizacao As TextBox
    Friend WithEvents ComboBox1 As ComboBox
  Friend WithEvents psqPessoa As uscPesqPessoa
End Class
