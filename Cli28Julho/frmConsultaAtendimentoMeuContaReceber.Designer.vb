<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAtendimentoMeuContaReceber
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAtendimentoMeuContaReceber))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.cmdListarEmAberto = New Cli28Julho.uscBotao()
    Me.cmdListarRecebido = New Cli28Julho.uscBotao()
    Me.txtDataEmAberto_Inicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataEmAberto_Final = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataRecebido_Inicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataRecebido_Final = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblDataAberto01 = New System.Windows.Forms.Label()
    Me.lblDataAberto02 = New System.Windows.Forms.Label()
    Me.lblDataAberto03 = New System.Windows.Forms.Label()
    Me.lblDataAberto04 = New System.Windows.Forms.Label()
    Me.lblDataAberto05 = New System.Windows.Forms.Label()
    Me.lblDataAberto06 = New System.Windows.Forms.Label()
    Me.lblDataAberto07 = New System.Windows.Forms.Label()
    Me.lblTituloAberto07 = New System.Windows.Forms.Label()
    Me.lblTituloAberto06 = New System.Windows.Forms.Label()
    Me.lblTituloAberto05 = New System.Windows.Forms.Label()
    Me.lblTituloAberto04 = New System.Windows.Forms.Label()
    Me.lblTituloAberto03 = New System.Windows.Forms.Label()
    Me.lblTituloAberto02 = New System.Windows.Forms.Label()
    Me.lblTituloAberto01 = New System.Windows.Forms.Label()
    Me.lblValorAberto01 = New System.Windows.Forms.Label()
    Me.lblValorAberto02 = New System.Windows.Forms.Label()
    Me.lblValorAberto03 = New System.Windows.Forms.Label()
    Me.lblValorAberto04 = New System.Windows.Forms.Label()
    Me.lblValorAberto05 = New System.Windows.Forms.Label()
    Me.lblValorAberto06 = New System.Windows.Forms.Label()
    Me.lblValorAberto07 = New System.Windows.Forms.Label()
    Me.lblValorRecebido08 = New System.Windows.Forms.Label()
    Me.lblValorRecebido07 = New System.Windows.Forms.Label()
    Me.lblValorRecebido05 = New System.Windows.Forms.Label()
    Me.lblValorRecebido04 = New System.Windows.Forms.Label()
    Me.lblValorRecebido03 = New System.Windows.Forms.Label()
    Me.lblValorRecebido02 = New System.Windows.Forms.Label()
    Me.lblValorRecebido01 = New System.Windows.Forms.Label()
    Me.lblTituloRecebido08 = New System.Windows.Forms.Label()
    Me.lblTituloRecebido06 = New System.Windows.Forms.Label()
    Me.lblTituloRecebido05 = New System.Windows.Forms.Label()
    Me.lblTituloRecebido04 = New System.Windows.Forms.Label()
    Me.lblTituloRecebido03 = New System.Windows.Forms.Label()
    Me.lblTituloRecebido02 = New System.Windows.Forms.Label()
    Me.lblTituloRecebido01 = New System.Windows.Forms.Label()
    Me.lblDataRecebido07 = New System.Windows.Forms.Label()
    Me.lblDataRecebido06 = New System.Windows.Forms.Label()
    Me.lblDataRecebido05 = New System.Windows.Forms.Label()
    Me.lblDataRecebido04 = New System.Windows.Forms.Label()
    Me.lblDataRecebido03 = New System.Windows.Forms.Label()
    Me.lblDataRecebido02 = New System.Windows.Forms.Label()
    Me.lblDataRecebido01 = New System.Windows.Forms.Label()
    Me.lblTotalValorAberto = New System.Windows.Forms.Label()
    Me.lblTotalValorRecebido = New System.Windows.Forms.Label()
    Me.vsbEmAberto = New System.Windows.Forms.VScrollBar()
    Me.vsbRecebido = New System.Windows.Forms.VScrollBar()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataEmAberto_Inicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataEmAberto_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataRecebido_Inicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataRecebido_Final, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(1163, 369)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(1002, 17)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 1
        '
        'cmdListarEmAberto
        '
        Me.cmdListarEmAberto.AutoSize = True
        Me.cmdListarEmAberto.Location = New System.Drawing.Point(352, 93)
        Me.cmdListarEmAberto.Name = "cmdListarEmAberto"
        Me.cmdListarEmAberto.Size = New System.Drawing.Size(16, 17)
        Me.cmdListarEmAberto.TabIndex = 2
        '
        'cmdListarRecebido
        '
        Me.cmdListarRecebido.AutoSize = True
        Me.cmdListarRecebido.Location = New System.Drawing.Point(933, 93)
        Me.cmdListarRecebido.Name = "cmdListarRecebido"
        Me.cmdListarRecebido.Size = New System.Drawing.Size(16, 17)
        Me.cmdListarRecebido.TabIndex = 3
        '
        'txtDataEmAberto_Inicial
        '
        Me.txtDataEmAberto_Inicial.Location = New System.Drawing.Point(152, 95)
        Me.txtDataEmAberto_Inicial.Name = "txtDataEmAberto_Inicial"
        Me.txtDataEmAberto_Inicial.Size = New System.Drawing.Size(89, 21)
        Me.txtDataEmAberto_Inicial.TabIndex = 161
        '
        'txtDataEmAberto_Final
        '
        Me.txtDataEmAberto_Final.Location = New System.Drawing.Point(249, 95)
        Me.txtDataEmAberto_Final.Name = "txtDataEmAberto_Final"
        Me.txtDataEmAberto_Final.Size = New System.Drawing.Size(89, 21)
        Me.txtDataEmAberto_Final.TabIndex = 162
        '
        'txtDataRecebido_Inicial
        '
        Me.txtDataRecebido_Inicial.Location = New System.Drawing.Point(733, 95)
        Me.txtDataRecebido_Inicial.Name = "txtDataRecebido_Inicial"
        Me.txtDataRecebido_Inicial.Size = New System.Drawing.Size(89, 21)
        Me.txtDataRecebido_Inicial.TabIndex = 163
        '
        'txtDataRecebido_Final
        '
        Me.txtDataRecebido_Final.Location = New System.Drawing.Point(828, 95)
        Me.txtDataRecebido_Final.Name = "txtDataRecebido_Final"
        Me.txtDataRecebido_Final.Size = New System.Drawing.Size(89, 21)
        Me.txtDataRecebido_Final.TabIndex = 164
        '
        'lblDataAberto01
        '
        Me.lblDataAberto01.AutoSize = True
        Me.lblDataAberto01.Location = New System.Drawing.Point(12, 150)
        Me.lblDataAberto01.Name = "lblDataAberto01"
        Me.lblDataAberto01.Size = New System.Drawing.Size(83, 13)
        Me.lblDataAberto01.TabIndex = 165
        Me.lblDataAberto01.Text = "lblDataAberto01"
        '
        'lblDataAberto02
        '
        Me.lblDataAberto02.AutoSize = True
        Me.lblDataAberto02.Location = New System.Drawing.Point(12, 178)
        Me.lblDataAberto02.Name = "lblDataAberto02"
        Me.lblDataAberto02.Size = New System.Drawing.Size(83, 13)
        Me.lblDataAberto02.TabIndex = 166
        Me.lblDataAberto02.Text = "lblDataAberto01"
        '
        'lblDataAberto03
        '
        Me.lblDataAberto03.AutoSize = True
        Me.lblDataAberto03.Location = New System.Drawing.Point(12, 206)
        Me.lblDataAberto03.Name = "lblDataAberto03"
        Me.lblDataAberto03.Size = New System.Drawing.Size(83, 13)
        Me.lblDataAberto03.TabIndex = 167
        Me.lblDataAberto03.Text = "lblDataAberto01"
        '
        'lblDataAberto04
        '
        Me.lblDataAberto04.AutoSize = True
        Me.lblDataAberto04.Location = New System.Drawing.Point(12, 234)
        Me.lblDataAberto04.Name = "lblDataAberto04"
        Me.lblDataAberto04.Size = New System.Drawing.Size(83, 13)
        Me.lblDataAberto04.TabIndex = 168
        Me.lblDataAberto04.Text = "lblDataAberto01"
        '
        'lblDataAberto05
        '
        Me.lblDataAberto05.AutoSize = True
        Me.lblDataAberto05.Location = New System.Drawing.Point(12, 262)
        Me.lblDataAberto05.Name = "lblDataAberto05"
        Me.lblDataAberto05.Size = New System.Drawing.Size(83, 13)
        Me.lblDataAberto05.TabIndex = 169
        Me.lblDataAberto05.Text = "lblDataAberto01"
        '
        'lblDataAberto06
        '
        Me.lblDataAberto06.AutoSize = True
        Me.lblDataAberto06.Location = New System.Drawing.Point(12, 289)
        Me.lblDataAberto06.Name = "lblDataAberto06"
        Me.lblDataAberto06.Size = New System.Drawing.Size(83, 13)
        Me.lblDataAberto06.TabIndex = 170
        Me.lblDataAberto06.Text = "lblDataAberto01"
        '
        'lblDataAberto07
        '
        Me.lblDataAberto07.AutoSize = True
        Me.lblDataAberto07.Location = New System.Drawing.Point(12, 318)
        Me.lblDataAberto07.Name = "lblDataAberto07"
        Me.lblDataAberto07.Size = New System.Drawing.Size(83, 13)
        Me.lblDataAberto07.TabIndex = 171
        Me.lblDataAberto07.Text = "lblDataAberto01"
        '
        'lblTituloAberto07
        '
        Me.lblTituloAberto07.AutoSize = True
        Me.lblTituloAberto07.Location = New System.Drawing.Point(149, 318)
        Me.lblTituloAberto07.Name = "lblTituloAberto07"
        Me.lblTituloAberto07.Size = New System.Drawing.Size(86, 13)
        Me.lblTituloAberto07.TabIndex = 178
        Me.lblTituloAberto07.Text = "lblTituloAberto01"
        '
        'lblTituloAberto06
        '
        Me.lblTituloAberto06.AutoSize = True
        Me.lblTituloAberto06.Location = New System.Drawing.Point(149, 289)
        Me.lblTituloAberto06.Name = "lblTituloAberto06"
        Me.lblTituloAberto06.Size = New System.Drawing.Size(86, 13)
        Me.lblTituloAberto06.TabIndex = 177
        Me.lblTituloAberto06.Text = "lblTituloAberto01"
        '
        'lblTituloAberto05
        '
        Me.lblTituloAberto05.AutoSize = True
        Me.lblTituloAberto05.Location = New System.Drawing.Point(149, 262)
        Me.lblTituloAberto05.Name = "lblTituloAberto05"
        Me.lblTituloAberto05.Size = New System.Drawing.Size(86, 13)
        Me.lblTituloAberto05.TabIndex = 176
        Me.lblTituloAberto05.Text = "lblTituloAberto01"
        '
        'lblTituloAberto04
        '
        Me.lblTituloAberto04.AutoSize = True
        Me.lblTituloAberto04.Location = New System.Drawing.Point(149, 234)
        Me.lblTituloAberto04.Name = "lblTituloAberto04"
        Me.lblTituloAberto04.Size = New System.Drawing.Size(86, 13)
        Me.lblTituloAberto04.TabIndex = 175
        Me.lblTituloAberto04.Text = "lblTituloAberto01"
        '
        'lblTituloAberto03
        '
        Me.lblTituloAberto03.AutoSize = True
        Me.lblTituloAberto03.Location = New System.Drawing.Point(149, 206)
        Me.lblTituloAberto03.Name = "lblTituloAberto03"
        Me.lblTituloAberto03.Size = New System.Drawing.Size(86, 13)
        Me.lblTituloAberto03.TabIndex = 174
        Me.lblTituloAberto03.Text = "lblTituloAberto01"
        '
        'lblTituloAberto02
        '
        Me.lblTituloAberto02.AutoSize = True
        Me.lblTituloAberto02.Location = New System.Drawing.Point(149, 178)
        Me.lblTituloAberto02.Name = "lblTituloAberto02"
        Me.lblTituloAberto02.Size = New System.Drawing.Size(86, 13)
        Me.lblTituloAberto02.TabIndex = 173
        Me.lblTituloAberto02.Text = "lblTituloAberto01"
        '
        'lblTituloAberto01
        '
        Me.lblTituloAberto01.AutoSize = True
        Me.lblTituloAberto01.Location = New System.Drawing.Point(149, 150)
        Me.lblTituloAberto01.Name = "lblTituloAberto01"
        Me.lblTituloAberto01.Size = New System.Drawing.Size(86, 13)
        Me.lblTituloAberto01.TabIndex = 172
        Me.lblTituloAberto01.Text = "lblTituloAberto01"
        '
        'lblValorAberto01
        '
        Me.lblValorAberto01.AutoSize = True
        Me.lblValorAberto01.Location = New System.Drawing.Point(446, 150)
        Me.lblValorAberto01.Name = "lblValorAberto01"
        Me.lblValorAberto01.Size = New System.Drawing.Size(84, 13)
        Me.lblValorAberto01.TabIndex = 179
        Me.lblValorAberto01.Text = "lblValorAberto01"
        '
        'lblValorAberto02
        '
        Me.lblValorAberto02.AutoSize = True
        Me.lblValorAberto02.Location = New System.Drawing.Point(446, 178)
        Me.lblValorAberto02.Name = "lblValorAberto02"
        Me.lblValorAberto02.Size = New System.Drawing.Size(84, 13)
        Me.lblValorAberto02.TabIndex = 180
        Me.lblValorAberto02.Text = "lblValorAberto01"
        '
        'lblValorAberto03
        '
        Me.lblValorAberto03.AutoSize = True
        Me.lblValorAberto03.Location = New System.Drawing.Point(446, 206)
        Me.lblValorAberto03.Name = "lblValorAberto03"
        Me.lblValorAberto03.Size = New System.Drawing.Size(84, 13)
        Me.lblValorAberto03.TabIndex = 181
        Me.lblValorAberto03.Text = "lblValorAberto01"
        '
        'lblValorAberto04
        '
        Me.lblValorAberto04.AutoSize = True
        Me.lblValorAberto04.Location = New System.Drawing.Point(446, 234)
        Me.lblValorAberto04.Name = "lblValorAberto04"
        Me.lblValorAberto04.Size = New System.Drawing.Size(84, 13)
        Me.lblValorAberto04.TabIndex = 182
        Me.lblValorAberto04.Text = "lblValorAberto01"
        '
        'lblValorAberto05
        '
        Me.lblValorAberto05.AutoSize = True
        Me.lblValorAberto05.Location = New System.Drawing.Point(446, 262)
        Me.lblValorAberto05.Name = "lblValorAberto05"
        Me.lblValorAberto05.Size = New System.Drawing.Size(84, 13)
        Me.lblValorAberto05.TabIndex = 183
        Me.lblValorAberto05.Text = "lblValorAberto01"
        '
        'lblValorAberto06
        '
        Me.lblValorAberto06.AutoSize = True
        Me.lblValorAberto06.Location = New System.Drawing.Point(446, 289)
        Me.lblValorAberto06.Name = "lblValorAberto06"
        Me.lblValorAberto06.Size = New System.Drawing.Size(84, 13)
        Me.lblValorAberto06.TabIndex = 184
        Me.lblValorAberto06.Text = "lblValorAberto01"
        '
        'lblValorAberto07
        '
        Me.lblValorAberto07.AutoSize = True
        Me.lblValorAberto07.Location = New System.Drawing.Point(446, 318)
        Me.lblValorAberto07.Name = "lblValorAberto07"
        Me.lblValorAberto07.Size = New System.Drawing.Size(84, 13)
        Me.lblValorAberto07.TabIndex = 185
        Me.lblValorAberto07.Text = "lblValorAberto01"
        '
        'lblValorRecebido08
        '
        Me.lblValorRecebido08.AutoSize = True
        Me.lblValorRecebido08.Location = New System.Drawing.Point(1029, 318)
        Me.lblValorRecebido08.Name = "lblValorRecebido08"
        Me.lblValorRecebido08.Size = New System.Drawing.Size(99, 13)
        Me.lblValorRecebido08.TabIndex = 206
        Me.lblValorRecebido08.Text = "lblValorRecebido01"
        '
        'lblValorRecebido07
        '
        Me.lblValorRecebido07.AutoSize = True
        Me.lblValorRecebido07.Location = New System.Drawing.Point(1029, 289)
        Me.lblValorRecebido07.Name = "lblValorRecebido07"
        Me.lblValorRecebido07.Size = New System.Drawing.Size(99, 13)
        Me.lblValorRecebido07.TabIndex = 205
        Me.lblValorRecebido07.Text = "lblValorRecebido01"
        '
        'lblValorRecebido05
        '
        Me.lblValorRecebido05.AutoSize = True
        Me.lblValorRecebido05.Location = New System.Drawing.Point(1029, 262)
        Me.lblValorRecebido05.Name = "lblValorRecebido05"
        Me.lblValorRecebido05.Size = New System.Drawing.Size(99, 13)
        Me.lblValorRecebido05.TabIndex = 204
        Me.lblValorRecebido05.Text = "lblValorRecebido01"
        '
        'lblValorRecebido04
        '
        Me.lblValorRecebido04.AutoSize = True
        Me.lblValorRecebido04.Location = New System.Drawing.Point(1029, 234)
        Me.lblValorRecebido04.Name = "lblValorRecebido04"
        Me.lblValorRecebido04.Size = New System.Drawing.Size(99, 13)
        Me.lblValorRecebido04.TabIndex = 203
        Me.lblValorRecebido04.Text = "lblValorRecebido01"
        '
        'lblValorRecebido03
        '
        Me.lblValorRecebido03.AutoSize = True
        Me.lblValorRecebido03.Location = New System.Drawing.Point(1029, 206)
        Me.lblValorRecebido03.Name = "lblValorRecebido03"
        Me.lblValorRecebido03.Size = New System.Drawing.Size(99, 13)
        Me.lblValorRecebido03.TabIndex = 202
        Me.lblValorRecebido03.Text = "lblValorRecebido01"
        '
        'lblValorRecebido02
        '
        Me.lblValorRecebido02.AutoSize = True
        Me.lblValorRecebido02.Location = New System.Drawing.Point(1029, 178)
        Me.lblValorRecebido02.Name = "lblValorRecebido02"
        Me.lblValorRecebido02.Size = New System.Drawing.Size(99, 13)
        Me.lblValorRecebido02.TabIndex = 201
        Me.lblValorRecebido02.Text = "lblValorRecebido01"
        '
        'lblValorRecebido01
        '
        Me.lblValorRecebido01.AutoSize = True
        Me.lblValorRecebido01.Location = New System.Drawing.Point(1029, 150)
        Me.lblValorRecebido01.Name = "lblValorRecebido01"
        Me.lblValorRecebido01.Size = New System.Drawing.Size(99, 13)
        Me.lblValorRecebido01.TabIndex = 200
        Me.lblValorRecebido01.Text = "lblValorRecebido01"
        '
        'lblTituloRecebido08
        '
        Me.lblTituloRecebido08.AutoSize = True
        Me.lblTituloRecebido08.Location = New System.Drawing.Point(732, 318)
        Me.lblTituloRecebido08.Name = "lblTituloRecebido08"
        Me.lblTituloRecebido08.Size = New System.Drawing.Size(101, 13)
        Me.lblTituloRecebido08.TabIndex = 199
        Me.lblTituloRecebido08.Text = "lblTituloRecebido01"
        '
        'lblTituloRecebido06
        '
        Me.lblTituloRecebido06.AutoSize = True
        Me.lblTituloRecebido06.Location = New System.Drawing.Point(732, 289)
        Me.lblTituloRecebido06.Name = "lblTituloRecebido06"
        Me.lblTituloRecebido06.Size = New System.Drawing.Size(101, 13)
        Me.lblTituloRecebido06.TabIndex = 198
        Me.lblTituloRecebido06.Text = "lblTituloRecebido01"
        '
        'lblTituloRecebido05
        '
        Me.lblTituloRecebido05.AutoSize = True
        Me.lblTituloRecebido05.Location = New System.Drawing.Point(732, 262)
        Me.lblTituloRecebido05.Name = "lblTituloRecebido05"
        Me.lblTituloRecebido05.Size = New System.Drawing.Size(101, 13)
        Me.lblTituloRecebido05.TabIndex = 197
        Me.lblTituloRecebido05.Text = "lblTituloRecebido01"
        '
        'lblTituloRecebido04
        '
        Me.lblTituloRecebido04.AutoSize = True
        Me.lblTituloRecebido04.Location = New System.Drawing.Point(732, 234)
        Me.lblTituloRecebido04.Name = "lblTituloRecebido04"
        Me.lblTituloRecebido04.Size = New System.Drawing.Size(101, 13)
        Me.lblTituloRecebido04.TabIndex = 196
        Me.lblTituloRecebido04.Text = "lblTituloRecebido01"
        '
        'lblTituloRecebido03
        '
        Me.lblTituloRecebido03.AutoSize = True
        Me.lblTituloRecebido03.Location = New System.Drawing.Point(732, 206)
        Me.lblTituloRecebido03.Name = "lblTituloRecebido03"
        Me.lblTituloRecebido03.Size = New System.Drawing.Size(101, 13)
        Me.lblTituloRecebido03.TabIndex = 195
        Me.lblTituloRecebido03.Text = "lblTituloRecebido01"
        '
        'lblTituloRecebido02
        '
        Me.lblTituloRecebido02.AutoSize = True
        Me.lblTituloRecebido02.Location = New System.Drawing.Point(732, 178)
        Me.lblTituloRecebido02.Name = "lblTituloRecebido02"
        Me.lblTituloRecebido02.Size = New System.Drawing.Size(101, 13)
        Me.lblTituloRecebido02.TabIndex = 194
        Me.lblTituloRecebido02.Text = "lblTituloRecebido01"
        '
        'lblTituloRecebido01
        '
        Me.lblTituloRecebido01.AutoSize = True
        Me.lblTituloRecebido01.Location = New System.Drawing.Point(732, 150)
        Me.lblTituloRecebido01.Name = "lblTituloRecebido01"
        Me.lblTituloRecebido01.Size = New System.Drawing.Size(101, 13)
        Me.lblTituloRecebido01.TabIndex = 193
        Me.lblTituloRecebido01.Text = "lblTituloRecebido01"
        '
        'lblDataRecebido07
        '
        Me.lblDataRecebido07.AutoSize = True
        Me.lblDataRecebido07.Location = New System.Drawing.Point(595, 318)
        Me.lblDataRecebido07.Name = "lblDataRecebido07"
        Me.lblDataRecebido07.Size = New System.Drawing.Size(98, 13)
        Me.lblDataRecebido07.TabIndex = 192
        Me.lblDataRecebido07.Text = "lblDataRecebido01"
        '
        'lblDataRecebido06
        '
        Me.lblDataRecebido06.AutoSize = True
        Me.lblDataRecebido06.Location = New System.Drawing.Point(595, 289)
        Me.lblDataRecebido06.Name = "lblDataRecebido06"
        Me.lblDataRecebido06.Size = New System.Drawing.Size(98, 13)
        Me.lblDataRecebido06.TabIndex = 191
        Me.lblDataRecebido06.Text = "lblDataRecebido01"
        '
        'lblDataRecebido05
        '
        Me.lblDataRecebido05.AutoSize = True
        Me.lblDataRecebido05.Location = New System.Drawing.Point(595, 262)
        Me.lblDataRecebido05.Name = "lblDataRecebido05"
        Me.lblDataRecebido05.Size = New System.Drawing.Size(98, 13)
        Me.lblDataRecebido05.TabIndex = 190
        Me.lblDataRecebido05.Text = "lblDataRecebido01"
        '
        'lblDataRecebido04
        '
        Me.lblDataRecebido04.AutoSize = True
        Me.lblDataRecebido04.Location = New System.Drawing.Point(595, 234)
        Me.lblDataRecebido04.Name = "lblDataRecebido04"
        Me.lblDataRecebido04.Size = New System.Drawing.Size(98, 13)
        Me.lblDataRecebido04.TabIndex = 189
        Me.lblDataRecebido04.Text = "lblDataRecebido01"
        '
        'lblDataRecebido03
        '
        Me.lblDataRecebido03.AutoSize = True
        Me.lblDataRecebido03.Location = New System.Drawing.Point(595, 206)
        Me.lblDataRecebido03.Name = "lblDataRecebido03"
        Me.lblDataRecebido03.Size = New System.Drawing.Size(98, 13)
        Me.lblDataRecebido03.TabIndex = 188
        Me.lblDataRecebido03.Text = "lblDataRecebido01"
        '
        'lblDataRecebido02
        '
        Me.lblDataRecebido02.AutoSize = True
        Me.lblDataRecebido02.Location = New System.Drawing.Point(595, 178)
        Me.lblDataRecebido02.Name = "lblDataRecebido02"
        Me.lblDataRecebido02.Size = New System.Drawing.Size(98, 13)
        Me.lblDataRecebido02.TabIndex = 187
        Me.lblDataRecebido02.Text = "lblDataRecebido01"
        '
        'lblDataRecebido01
        '
        Me.lblDataRecebido01.AutoSize = True
        Me.lblDataRecebido01.Location = New System.Drawing.Point(595, 150)
        Me.lblDataRecebido01.Name = "lblDataRecebido01"
        Me.lblDataRecebido01.Size = New System.Drawing.Size(98, 13)
        Me.lblDataRecebido01.TabIndex = 186
        Me.lblDataRecebido01.Text = "lblDataRecebido01"
        '
        'lblTotalValorAberto
        '
        Me.lblTotalValorAberto.AutoSize = True
        Me.lblTotalValorAberto.Location = New System.Drawing.Point(446, 355)
        Me.lblTotalValorAberto.Name = "lblTotalValorAberto"
        Me.lblTotalValorAberto.Size = New System.Drawing.Size(96, 13)
        Me.lblTotalValorAberto.TabIndex = 207
        Me.lblTotalValorAberto.Text = "lblTotalValorAberto"
        '
        'lblTotalValorRecebido
        '
        Me.lblTotalValorRecebido.AutoSize = True
        Me.lblTotalValorRecebido.Location = New System.Drawing.Point(1030, 355)
        Me.lblTotalValorRecebido.Name = "lblTotalValorRecebido"
        Me.lblTotalValorRecebido.Size = New System.Drawing.Size(111, 13)
        Me.lblTotalValorRecebido.TabIndex = 209
        Me.lblTotalValorRecebido.Text = "lblTotalValorRecebido"
        '
        'vsbEmAberto
        '
        Me.vsbEmAberto.Location = New System.Drawing.Point(573, 146)
        Me.vsbEmAberto.Name = "vsbEmAberto"
        Me.vsbEmAberto.Size = New System.Drawing.Size(17, 190)
        Me.vsbEmAberto.TabIndex = 210
        '
        'vsbRecebido
        '
        Me.vsbRecebido.Location = New System.Drawing.Point(1157, 146)
        Me.vsbRecebido.Name = "vsbRecebido"
        Me.vsbRecebido.Size = New System.Drawing.Size(17, 190)
        Me.vsbRecebido.TabIndex = 211
        '
        'frmConsultaAtendimentoMeuContaReceber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 450)
        Me.Controls.Add(Me.vsbRecebido)
        Me.Controls.Add(Me.vsbEmAberto)
        Me.Controls.Add(Me.lblTotalValorRecebido)
        Me.Controls.Add(Me.lblTotalValorAberto)
        Me.Controls.Add(Me.lblValorRecebido08)
        Me.Controls.Add(Me.lblValorRecebido07)
        Me.Controls.Add(Me.lblValorRecebido05)
        Me.Controls.Add(Me.lblValorRecebido04)
        Me.Controls.Add(Me.lblValorRecebido03)
        Me.Controls.Add(Me.lblValorRecebido02)
        Me.Controls.Add(Me.lblValorRecebido01)
        Me.Controls.Add(Me.lblTituloRecebido08)
        Me.Controls.Add(Me.lblTituloRecebido06)
        Me.Controls.Add(Me.lblTituloRecebido05)
        Me.Controls.Add(Me.lblTituloRecebido04)
        Me.Controls.Add(Me.lblTituloRecebido03)
        Me.Controls.Add(Me.lblTituloRecebido02)
        Me.Controls.Add(Me.lblTituloRecebido01)
        Me.Controls.Add(Me.lblDataRecebido07)
        Me.Controls.Add(Me.lblDataRecebido06)
        Me.Controls.Add(Me.lblDataRecebido05)
        Me.Controls.Add(Me.lblDataRecebido04)
        Me.Controls.Add(Me.lblDataRecebido03)
        Me.Controls.Add(Me.lblDataRecebido02)
        Me.Controls.Add(Me.lblDataRecebido01)
        Me.Controls.Add(Me.lblValorAberto07)
        Me.Controls.Add(Me.lblValorAberto06)
        Me.Controls.Add(Me.lblValorAberto05)
        Me.Controls.Add(Me.lblValorAberto04)
        Me.Controls.Add(Me.lblValorAberto03)
        Me.Controls.Add(Me.lblValorAberto02)
        Me.Controls.Add(Me.lblValorAberto01)
        Me.Controls.Add(Me.lblTituloAberto07)
        Me.Controls.Add(Me.lblTituloAberto06)
        Me.Controls.Add(Me.lblTituloAberto05)
        Me.Controls.Add(Me.lblTituloAberto04)
        Me.Controls.Add(Me.lblTituloAberto03)
        Me.Controls.Add(Me.lblTituloAberto02)
        Me.Controls.Add(Me.lblTituloAberto01)
        Me.Controls.Add(Me.lblDataAberto07)
        Me.Controls.Add(Me.lblDataAberto06)
        Me.Controls.Add(Me.lblDataAberto05)
        Me.Controls.Add(Me.lblDataAberto04)
        Me.Controls.Add(Me.lblDataAberto03)
        Me.Controls.Add(Me.lblDataAberto02)
        Me.Controls.Add(Me.lblDataAberto01)
        Me.Controls.Add(Me.txtDataRecebido_Final)
        Me.Controls.Add(Me.txtDataRecebido_Inicial)
        Me.Controls.Add(Me.txtDataEmAberto_Final)
        Me.Controls.Add(Me.txtDataEmAberto_Inicial)
        Me.Controls.Add(Me.cmdListarRecebido)
        Me.Controls.Add(Me.cmdListarEmAberto)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.picGeral)
        Me.Name = "frmConsultaAtendimentoMeuContaReceber"
        Me.Text = "Médicos - Meu Contas a Receber"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataEmAberto_Inicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataEmAberto_Final, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataRecebido_Inicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataRecebido_Final, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents cmdListarEmAberto As uscBotao
  Friend WithEvents cmdListarRecebido As uscBotao
  Friend WithEvents txtDataEmAberto_Inicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataEmAberto_Final As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataRecebido_Inicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataRecebido_Final As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents lblDataAberto01 As Label
  Friend WithEvents lblDataAberto02 As Label
  Friend WithEvents lblDataAberto03 As Label
  Friend WithEvents lblDataAberto04 As Label
  Friend WithEvents lblDataAberto05 As Label
  Friend WithEvents lblDataAberto06 As Label
  Friend WithEvents lblDataAberto07 As Label
  Friend WithEvents lblTituloAberto07 As Label
  Friend WithEvents lblTituloAberto06 As Label
  Friend WithEvents lblTituloAberto05 As Label
  Friend WithEvents lblTituloAberto04 As Label
  Friend WithEvents lblTituloAberto03 As Label
  Friend WithEvents lblTituloAberto02 As Label
  Friend WithEvents lblTituloAberto01 As Label
  Friend WithEvents lblValorAberto01 As Label
  Friend WithEvents lblValorAberto02 As Label
  Friend WithEvents lblValorAberto03 As Label
  Friend WithEvents lblValorAberto04 As Label
  Friend WithEvents lblValorAberto05 As Label
  Friend WithEvents lblValorAberto06 As Label
  Friend WithEvents lblValorAberto07 As Label
  Friend WithEvents lblValorRecebido08 As Label
  Friend WithEvents lblValorRecebido07 As Label
  Friend WithEvents lblValorRecebido05 As Label
  Friend WithEvents lblValorRecebido04 As Label
  Friend WithEvents lblValorRecebido03 As Label
  Friend WithEvents lblValorRecebido02 As Label
  Friend WithEvents lblValorRecebido01 As Label
  Friend WithEvents lblTituloRecebido08 As Label
  Friend WithEvents lblTituloRecebido06 As Label
  Friend WithEvents lblTituloRecebido05 As Label
  Friend WithEvents lblTituloRecebido04 As Label
  Friend WithEvents lblTituloRecebido03 As Label
  Friend WithEvents lblTituloRecebido02 As Label
  Friend WithEvents lblTituloRecebido01 As Label
  Friend WithEvents lblDataRecebido07 As Label
  Friend WithEvents lblDataRecebido06 As Label
  Friend WithEvents lblDataRecebido05 As Label
  Friend WithEvents lblDataRecebido04 As Label
  Friend WithEvents lblDataRecebido03 As Label
  Friend WithEvents lblDataRecebido02 As Label
  Friend WithEvents lblDataRecebido01 As Label
  Friend WithEvents lblTotalValorAberto As Label
  Friend WithEvents lblTotalValorRecebido As Label
  Friend WithEvents vsbEmAberto As VScrollBar
  Friend WithEvents vsbRecebido As VScrollBar
End Class
