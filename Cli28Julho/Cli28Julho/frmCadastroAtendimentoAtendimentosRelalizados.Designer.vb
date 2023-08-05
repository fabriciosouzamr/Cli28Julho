<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoAtendimentosRelalizados
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoAtendimentosRelalizados))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.VScrollBar = New System.Windows.Forms.VScrollBar()
    Me.lblMedico = New System.Windows.Forms.Label()
    Me.txtPeriodoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtPeriodoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.cboTipoConsulta = New System.Windows.Forms.ComboBox()
    Me.cboStatus = New System.Windows.Forms.ComboBox()
    Me.lblData01 = New System.Windows.Forms.Label()
    Me.lblData02 = New System.Windows.Forms.Label()
    Me.lblData03 = New System.Windows.Forms.Label()
    Me.lblData04 = New System.Windows.Forms.Label()
    Me.lblData05 = New System.Windows.Forms.Label()
    Me.lblData06 = New System.Windows.Forms.Label()
    Me.lblData07 = New System.Windows.Forms.Label()
    Me.lblPaciente01 = New System.Windows.Forms.Label()
    Me.lblPaciente02 = New System.Windows.Forms.Label()
    Me.lblPaciente03 = New System.Windows.Forms.Label()
    Me.lblPaciente04 = New System.Windows.Forms.Label()
    Me.lblPaciente05 = New System.Windows.Forms.Label()
    Me.lblPaciente06 = New System.Windows.Forms.Label()
    Me.lblPaciente07 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento01 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento02 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento03 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento04 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento05 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento06 = New System.Windows.Forms.Label()
    Me.lblTipoAtendimento07 = New System.Windows.Forms.Label()
    Me.lblStatus01 = New System.Windows.Forms.Label()
    Me.lblStatus02 = New System.Windows.Forms.Label()
    Me.lblStatus03 = New System.Windows.Forms.Label()
    Me.lblStatus04 = New System.Windows.Forms.Label()
    Me.lblStatus05 = New System.Windows.Forms.Label()
    Me.lblStatus06 = New System.Windows.Forms.Label()
    Me.lblStatus07 = New System.Windows.Forms.Label()
    Me.lblValor07 = New System.Windows.Forms.Label()
    Me.lblValor06 = New System.Windows.Forms.Label()
    Me.lblValor05 = New System.Windows.Forms.Label()
    Me.lblValor04 = New System.Windows.Forms.Label()
    Me.lblValor03 = New System.Windows.Forms.Label()
    Me.lblValor02 = New System.Windows.Forms.Label()
    Me.lblValor01 = New System.Windows.Forms.Label()
    Me.lblVlPrestador07 = New System.Windows.Forms.Label()
    Me.lblVlPrestador06 = New System.Windows.Forms.Label()
    Me.lblVlPrestador05 = New System.Windows.Forms.Label()
    Me.lblVlPrestador04 = New System.Windows.Forms.Label()
    Me.lblVlPrestador03 = New System.Windows.Forms.Label()
    Me.lblVlPrestador02 = New System.Windows.Forms.Label()
    Me.lblVlPrestador01 = New System.Windows.Forms.Label()
    Me.lblQuantidade = New System.Windows.Forms.Label()
    Me.lblValorTotal = New System.Windows.Forms.Label()
    Me.lblVlPrestadorTotal = New System.Windows.Forms.Label()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.cmdListar = New Cli28Julho.uscBotao()
        Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(995, 392)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'VScrollBar
        '
        Me.VScrollBar.Location = New System.Drawing.Point(968, 149)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(17, 198)
        Me.VScrollBar.TabIndex = 1
        '
        'lblMedico
        '
        Me.lblMedico.Location = New System.Drawing.Point(23, 32)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(385, 13)
        Me.lblMedico.TabIndex = 2
        Me.lblMedico.Text = "lblMedico"
        '
        'txtPeriodoInicial
        '
        Me.txtPeriodoInicial.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtPeriodoInicial.Location = New System.Drawing.Point(415, 30)
        Me.txtPeriodoInicial.Name = "txtPeriodoInicial"
        Me.txtPeriodoInicial.Size = New System.Drawing.Size(89, 17)
        Me.txtPeriodoInicial.TabIndex = 162
        '
        'txtPeriodoFinal
        '
        Me.txtPeriodoFinal.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtPeriodoFinal.Location = New System.Drawing.Point(512, 30)
        Me.txtPeriodoFinal.Name = "txtPeriodoFinal"
        Me.txtPeriodoFinal.Size = New System.Drawing.Size(89, 17)
        Me.txtPeriodoFinal.TabIndex = 163
        '
        'cboTipoConsulta
        '
        Me.cboTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoConsulta.FormattingEnabled = True
        Me.cboTipoConsulta.Location = New System.Drawing.Point(417, 78)
        Me.cboTipoConsulta.Name = "cboTipoConsulta"
        Me.cboTipoConsulta.Size = New System.Drawing.Size(94, 21)
        Me.cboTipoConsulta.TabIndex = 165
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(513, 78)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(92, 21)
        Me.cboStatus.TabIndex = 166
        '
        'lblData01
        '
        Me.lblData01.AutoSize = True
        Me.lblData01.Location = New System.Drawing.Point(8, 152)
        Me.lblData01.Name = "lblData01"
        Me.lblData01.Size = New System.Drawing.Size(110, 13)
        Me.lblData01.TabIndex = 169
        Me.lblData01.Text = "99/99/9999 99:99:99"
        '
        'lblData02
        '
        Me.lblData02.AutoSize = True
        Me.lblData02.Location = New System.Drawing.Point(8, 179)
        Me.lblData02.Name = "lblData02"
        Me.lblData02.Size = New System.Drawing.Size(52, 13)
        Me.lblData02.TabIndex = 170
        Me.lblData02.Text = "lblData01"
        '
        'lblData03
        '
        Me.lblData03.AutoSize = True
        Me.lblData03.Location = New System.Drawing.Point(8, 207)
        Me.lblData03.Name = "lblData03"
        Me.lblData03.Size = New System.Drawing.Size(52, 13)
        Me.lblData03.TabIndex = 171
        Me.lblData03.Text = "lblData01"
        '
        'lblData04
        '
        Me.lblData04.AutoSize = True
        Me.lblData04.Location = New System.Drawing.Point(8, 234)
        Me.lblData04.Name = "lblData04"
        Me.lblData04.Size = New System.Drawing.Size(52, 13)
        Me.lblData04.TabIndex = 172
        Me.lblData04.Text = "lblData01"
        '
        'lblData05
        '
        Me.lblData05.AutoSize = True
        Me.lblData05.Location = New System.Drawing.Point(8, 263)
        Me.lblData05.Name = "lblData05"
        Me.lblData05.Size = New System.Drawing.Size(52, 13)
        Me.lblData05.TabIndex = 173
        Me.lblData05.Text = "lblData01"
        '
        'lblData06
        '
        Me.lblData06.AutoSize = True
        Me.lblData06.Location = New System.Drawing.Point(8, 290)
        Me.lblData06.Name = "lblData06"
        Me.lblData06.Size = New System.Drawing.Size(52, 13)
        Me.lblData06.TabIndex = 174
        Me.lblData06.Text = "lblData01"
        '
        'lblData07
        '
        Me.lblData07.AutoSize = True
        Me.lblData07.Location = New System.Drawing.Point(8, 318)
        Me.lblData07.Name = "lblData07"
        Me.lblData07.Size = New System.Drawing.Size(52, 13)
        Me.lblData07.TabIndex = 175
        Me.lblData07.Text = "lblData01"
        '
        'lblPaciente01
        '
        Me.lblPaciente01.Location = New System.Drawing.Point(122, 152)
        Me.lblPaciente01.Name = "lblPaciente01"
        Me.lblPaciente01.Size = New System.Drawing.Size(310, 13)
        Me.lblPaciente01.TabIndex = 176
        Me.lblPaciente01.Text = "lblPaciente01"
        '
        'lblPaciente02
        '
        Me.lblPaciente02.Location = New System.Drawing.Point(122, 179)
        Me.lblPaciente02.Name = "lblPaciente02"
        Me.lblPaciente02.Size = New System.Drawing.Size(310, 13)
        Me.lblPaciente02.TabIndex = 177
        Me.lblPaciente02.Text = "lblPaciente01"
        '
        'lblPaciente03
        '
        Me.lblPaciente03.Location = New System.Drawing.Point(122, 207)
        Me.lblPaciente03.Name = "lblPaciente03"
        Me.lblPaciente03.Size = New System.Drawing.Size(310, 13)
        Me.lblPaciente03.TabIndex = 178
        Me.lblPaciente03.Text = "lblPaciente01"
        '
        'lblPaciente04
        '
        Me.lblPaciente04.Location = New System.Drawing.Point(122, 234)
        Me.lblPaciente04.Name = "lblPaciente04"
        Me.lblPaciente04.Size = New System.Drawing.Size(310, 13)
        Me.lblPaciente04.TabIndex = 179
        Me.lblPaciente04.Text = "lblPaciente01"
        '
        'lblPaciente05
        '
        Me.lblPaciente05.Location = New System.Drawing.Point(122, 263)
        Me.lblPaciente05.Name = "lblPaciente05"
        Me.lblPaciente05.Size = New System.Drawing.Size(310, 13)
        Me.lblPaciente05.TabIndex = 180
        Me.lblPaciente05.Text = "lblPaciente01"
        '
        'lblPaciente06
        '
        Me.lblPaciente06.Location = New System.Drawing.Point(122, 290)
        Me.lblPaciente06.Name = "lblPaciente06"
        Me.lblPaciente06.Size = New System.Drawing.Size(310, 13)
        Me.lblPaciente06.TabIndex = 181
        Me.lblPaciente06.Text = "lblPaciente01"
        '
        'lblPaciente07
        '
        Me.lblPaciente07.Location = New System.Drawing.Point(122, 318)
        Me.lblPaciente07.Name = "lblPaciente07"
        Me.lblPaciente07.Size = New System.Drawing.Size(310, 13)
        Me.lblPaciente07.TabIndex = 182
        Me.lblPaciente07.Text = "lblPaciente01"
        '
        'lblTipoAtendimento01
        '
        Me.lblTipoAtendimento01.Location = New System.Drawing.Point(445, 152)
        Me.lblTipoAtendimento01.Name = "lblTipoAtendimento01"
        Me.lblTipoAtendimento01.Size = New System.Drawing.Size(126, 13)
        Me.lblTipoAtendimento01.TabIndex = 183
        Me.lblTipoAtendimento01.Text = "lblTipoAtendimento01"
        '
        'lblTipoAtendimento02
        '
        Me.lblTipoAtendimento02.Location = New System.Drawing.Point(445, 179)
        Me.lblTipoAtendimento02.Name = "lblTipoAtendimento02"
        Me.lblTipoAtendimento02.Size = New System.Drawing.Size(126, 13)
        Me.lblTipoAtendimento02.TabIndex = 184
        Me.lblTipoAtendimento02.Text = "lblTipoAtendimento01"
        '
        'lblTipoAtendimento03
        '
        Me.lblTipoAtendimento03.Location = New System.Drawing.Point(445, 207)
        Me.lblTipoAtendimento03.Name = "lblTipoAtendimento03"
        Me.lblTipoAtendimento03.Size = New System.Drawing.Size(126, 13)
        Me.lblTipoAtendimento03.TabIndex = 185
        Me.lblTipoAtendimento03.Text = "lblTipoAtendimento01"
        '
        'lblTipoAtendimento04
        '
        Me.lblTipoAtendimento04.Location = New System.Drawing.Point(445, 234)
        Me.lblTipoAtendimento04.Name = "lblTipoAtendimento04"
        Me.lblTipoAtendimento04.Size = New System.Drawing.Size(126, 13)
        Me.lblTipoAtendimento04.TabIndex = 186
        Me.lblTipoAtendimento04.Text = "lblTipoAtendimento01"
        '
        'lblTipoAtendimento05
        '
        Me.lblTipoAtendimento05.Location = New System.Drawing.Point(445, 263)
        Me.lblTipoAtendimento05.Name = "lblTipoAtendimento05"
        Me.lblTipoAtendimento05.Size = New System.Drawing.Size(126, 13)
        Me.lblTipoAtendimento05.TabIndex = 187
        Me.lblTipoAtendimento05.Text = "lblTipoAtendimento01"
        '
        'lblTipoAtendimento06
        '
        Me.lblTipoAtendimento06.Location = New System.Drawing.Point(445, 290)
        Me.lblTipoAtendimento06.Name = "lblTipoAtendimento06"
        Me.lblTipoAtendimento06.Size = New System.Drawing.Size(126, 13)
        Me.lblTipoAtendimento06.TabIndex = 188
        Me.lblTipoAtendimento06.Text = "lblTipoAtendimento01"
        '
        'lblTipoAtendimento07
        '
        Me.lblTipoAtendimento07.Location = New System.Drawing.Point(445, 318)
        Me.lblTipoAtendimento07.Name = "lblTipoAtendimento07"
        Me.lblTipoAtendimento07.Size = New System.Drawing.Size(126, 13)
        Me.lblTipoAtendimento07.TabIndex = 189
        Me.lblTipoAtendimento07.Text = "lblTipoAtendimento07"
        '
        'lblStatus01
        '
        Me.lblStatus01.Location = New System.Drawing.Point(584, 152)
        Me.lblStatus01.Name = "lblStatus01"
        Me.lblStatus01.Size = New System.Drawing.Size(116, 13)
        Me.lblStatus01.TabIndex = 190
        Me.lblStatus01.Text = "lblStatus01"
        '
        'lblStatus02
        '
        Me.lblStatus02.Location = New System.Drawing.Point(584, 179)
        Me.lblStatus02.Name = "lblStatus02"
        Me.lblStatus02.Size = New System.Drawing.Size(116, 13)
        Me.lblStatus02.TabIndex = 191
        Me.lblStatus02.Text = "lblStatus01"
        '
        'lblStatus03
        '
        Me.lblStatus03.Location = New System.Drawing.Point(584, 207)
        Me.lblStatus03.Name = "lblStatus03"
        Me.lblStatus03.Size = New System.Drawing.Size(116, 13)
        Me.lblStatus03.TabIndex = 192
        Me.lblStatus03.Text = "lblStatus03"
        '
        'lblStatus04
        '
        Me.lblStatus04.Location = New System.Drawing.Point(584, 234)
        Me.lblStatus04.Name = "lblStatus04"
        Me.lblStatus04.Size = New System.Drawing.Size(116, 13)
        Me.lblStatus04.TabIndex = 193
        Me.lblStatus04.Text = "lblStatus04"
        '
        'lblStatus05
        '
        Me.lblStatus05.Location = New System.Drawing.Point(584, 263)
        Me.lblStatus05.Name = "lblStatus05"
        Me.lblStatus05.Size = New System.Drawing.Size(116, 13)
        Me.lblStatus05.TabIndex = 194
        Me.lblStatus05.Text = "lblStatus05"
        '
        'lblStatus06
        '
        Me.lblStatus06.Location = New System.Drawing.Point(584, 290)
        Me.lblStatus06.Name = "lblStatus06"
        Me.lblStatus06.Size = New System.Drawing.Size(116, 13)
        Me.lblStatus06.TabIndex = 195
        Me.lblStatus06.Text = "lblStatus06"
        '
        'lblStatus07
        '
        Me.lblStatus07.Location = New System.Drawing.Point(584, 318)
        Me.lblStatus07.Name = "lblStatus07"
        Me.lblStatus07.Size = New System.Drawing.Size(116, 13)
        Me.lblStatus07.TabIndex = 196
        Me.lblStatus07.Text = "lblStatus07"
        '
        'lblValor07
        '
        Me.lblValor07.Location = New System.Drawing.Point(713, 318)
        Me.lblValor07.Name = "lblValor07"
        Me.lblValor07.Size = New System.Drawing.Size(116, 13)
        Me.lblValor07.TabIndex = 203
        Me.lblValor07.Text = "lblValor01"
        Me.lblValor07.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor06
        '
        Me.lblValor06.Location = New System.Drawing.Point(713, 290)
        Me.lblValor06.Name = "lblValor06"
        Me.lblValor06.Size = New System.Drawing.Size(116, 13)
        Me.lblValor06.TabIndex = 202
        Me.lblValor06.Text = "lblValor01"
        Me.lblValor06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor05
        '
        Me.lblValor05.Location = New System.Drawing.Point(713, 263)
        Me.lblValor05.Name = "lblValor05"
        Me.lblValor05.Size = New System.Drawing.Size(116, 13)
        Me.lblValor05.TabIndex = 201
        Me.lblValor05.Text = "lblValor01"
        Me.lblValor05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor04
        '
        Me.lblValor04.Location = New System.Drawing.Point(713, 234)
        Me.lblValor04.Name = "lblValor04"
        Me.lblValor04.Size = New System.Drawing.Size(116, 13)
        Me.lblValor04.TabIndex = 200
        Me.lblValor04.Text = "lblValor01"
        Me.lblValor04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor03
        '
        Me.lblValor03.Location = New System.Drawing.Point(713, 207)
        Me.lblValor03.Name = "lblValor03"
        Me.lblValor03.Size = New System.Drawing.Size(116, 13)
        Me.lblValor03.TabIndex = 199
        Me.lblValor03.Text = "lblValor01"
        Me.lblValor03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor02
        '
        Me.lblValor02.Location = New System.Drawing.Point(713, 179)
        Me.lblValor02.Name = "lblValor02"
        Me.lblValor02.Size = New System.Drawing.Size(116, 13)
        Me.lblValor02.TabIndex = 198
        Me.lblValor02.Text = "lblValor01"
        Me.lblValor02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValor01
        '
        Me.lblValor01.Location = New System.Drawing.Point(713, 152)
        Me.lblValor01.Name = "lblValor01"
        Me.lblValor01.Size = New System.Drawing.Size(116, 13)
        Me.lblValor01.TabIndex = 197
        Me.lblValor01.Text = "lblValor01"
        Me.lblValor01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador07
        '
        Me.lblVlPrestador07.Location = New System.Drawing.Point(842, 318)
        Me.lblVlPrestador07.Name = "lblVlPrestador07"
        Me.lblVlPrestador07.Size = New System.Drawing.Size(116, 13)
        Me.lblVlPrestador07.TabIndex = 210
        Me.lblVlPrestador07.Text = "lblVlPrestador01"
        Me.lblVlPrestador07.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador06
        '
        Me.lblVlPrestador06.Location = New System.Drawing.Point(842, 290)
        Me.lblVlPrestador06.Name = "lblVlPrestador06"
        Me.lblVlPrestador06.Size = New System.Drawing.Size(116, 13)
        Me.lblVlPrestador06.TabIndex = 209
        Me.lblVlPrestador06.Text = "lblVlPrestador01"
        Me.lblVlPrestador06.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador05
        '
        Me.lblVlPrestador05.Location = New System.Drawing.Point(842, 263)
        Me.lblVlPrestador05.Name = "lblVlPrestador05"
        Me.lblVlPrestador05.Size = New System.Drawing.Size(116, 13)
        Me.lblVlPrestador05.TabIndex = 208
        Me.lblVlPrestador05.Text = "lblVlPrestador01"
        Me.lblVlPrestador05.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador04
        '
        Me.lblVlPrestador04.Location = New System.Drawing.Point(842, 234)
        Me.lblVlPrestador04.Name = "lblVlPrestador04"
        Me.lblVlPrestador04.Size = New System.Drawing.Size(116, 13)
        Me.lblVlPrestador04.TabIndex = 207
        Me.lblVlPrestador04.Text = "lblVlPrestador04"
        Me.lblVlPrestador04.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador03
        '
        Me.lblVlPrestador03.Location = New System.Drawing.Point(842, 207)
        Me.lblVlPrestador03.Name = "lblVlPrestador03"
        Me.lblVlPrestador03.Size = New System.Drawing.Size(116, 13)
        Me.lblVlPrestador03.TabIndex = 206
        Me.lblVlPrestador03.Text = "lblVlPrestador03"
        Me.lblVlPrestador03.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador02
        '
        Me.lblVlPrestador02.Location = New System.Drawing.Point(842, 179)
        Me.lblVlPrestador02.Name = "lblVlPrestador02"
        Me.lblVlPrestador02.Size = New System.Drawing.Size(116, 13)
        Me.lblVlPrestador02.TabIndex = 205
        Me.lblVlPrestador02.Text = "lblVlPrestador01"
        Me.lblVlPrestador02.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestador01
        '
        Me.lblVlPrestador01.Location = New System.Drawing.Point(842, 152)
        Me.lblVlPrestador01.Name = "lblVlPrestador01"
        Me.lblVlPrestador01.Size = New System.Drawing.Size(116, 13)
        Me.lblVlPrestador01.TabIndex = 204
        Me.lblVlPrestador01.Text = "lblVlPrestador01"
        Me.lblVlPrestador01.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuantidade
        '
        Me.lblQuantidade.Location = New System.Drawing.Point(125, 363)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(51, 13)
        Me.lblQuantidade.TabIndex = 211
        Me.lblQuantidade.Text = "lblQuantidade"
        Me.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblValorTotal
        '
        Me.lblValorTotal.Location = New System.Drawing.Point(713, 360)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(116, 13)
        Me.lblValorTotal.TabIndex = 212
        Me.lblValorTotal.Text = "lblValorTotal"
        Me.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVlPrestadorTotal
        '
        Me.lblVlPrestadorTotal.Location = New System.Drawing.Point(842, 360)
        Me.lblVlPrestadorTotal.Name = "lblVlPrestadorTotal"
        Me.lblVlPrestadorTotal.Size = New System.Drawing.Size(116, 13)
        Me.lblVlPrestadorTotal.TabIndex = 213
        Me.lblVlPrestadorTotal.Text = "lblVlPrestadorTotal"
        Me.lblVlPrestadorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(648, 67)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 168
        '
        'cmdListar
        '
        Me.cmdListar.AutoSize = True
        Me.cmdListar.Location = New System.Drawing.Point(647, 27)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(16, 17)
        Me.cmdListar.TabIndex = 167
        '
        'psqPessoa
        '
        Me.psqPessoa.AdicionarPessoa = False
        Me.psqPessoa.Bordas = True
        Me.psqPessoa.CarregarTodos = False
        Me.psqPessoa.DS_Pessoa = ""
        Me.psqPessoa.ID_Pessoa = 0
        Me.psqPessoa.LabelVisivel = False
        Me.psqPessoa.Location = New System.Drawing.Point(23, 77)
        Me.psqPessoa.Name = "psqPessoa"
        Me.psqPessoa.Rotulo = "Pessoa"
        Me.psqPessoa.Size = New System.Drawing.Size(385, 22)
        Me.psqPessoa.TabIndex = 214
        Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'frmCadastroAtendimentoAtendimentosRelalizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 450)
        Me.Controls.Add(Me.psqPessoa)
        Me.Controls.Add(Me.lblVlPrestadorTotal)
        Me.Controls.Add(Me.lblValorTotal)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.lblVlPrestador07)
        Me.Controls.Add(Me.lblVlPrestador06)
        Me.Controls.Add(Me.lblVlPrestador05)
        Me.Controls.Add(Me.lblVlPrestador04)
        Me.Controls.Add(Me.lblVlPrestador03)
        Me.Controls.Add(Me.lblVlPrestador02)
        Me.Controls.Add(Me.lblVlPrestador01)
        Me.Controls.Add(Me.lblValor07)
        Me.Controls.Add(Me.lblValor06)
        Me.Controls.Add(Me.lblValor05)
        Me.Controls.Add(Me.lblValor04)
        Me.Controls.Add(Me.lblValor03)
        Me.Controls.Add(Me.lblValor02)
        Me.Controls.Add(Me.lblValor01)
        Me.Controls.Add(Me.lblStatus07)
        Me.Controls.Add(Me.lblStatus06)
        Me.Controls.Add(Me.lblStatus05)
        Me.Controls.Add(Me.lblStatus04)
        Me.Controls.Add(Me.lblStatus03)
        Me.Controls.Add(Me.lblStatus02)
        Me.Controls.Add(Me.lblStatus01)
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
        Me.Controls.Add(Me.lblData07)
        Me.Controls.Add(Me.lblData06)
        Me.Controls.Add(Me.lblData05)
        Me.Controls.Add(Me.lblData04)
        Me.Controls.Add(Me.lblData03)
        Me.Controls.Add(Me.lblData02)
        Me.Controls.Add(Me.lblData01)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboTipoConsulta)
        Me.Controls.Add(Me.txtPeriodoFinal)
        Me.Controls.Add(Me.txtPeriodoInicial)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.picGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadastroAtendimentoAtendimentosRelalizados"
        Me.Text = "Cadastro de Atendimento - Atendimentos Relalizados"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents VScrollBar As VScrollBar
  Friend WithEvents lblMedico As Label
  Friend WithEvents txtPeriodoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtPeriodoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cboTipoConsulta As ComboBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cmdListar As uscBotao
    Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents lblData01 As Label
    Friend WithEvents lblData02 As Label
    Friend WithEvents lblData03 As Label
    Friend WithEvents lblData04 As Label
    Friend WithEvents lblData05 As Label
    Friend WithEvents lblData06 As Label
    Friend WithEvents lblData07 As Label
    Friend WithEvents lblPaciente01 As Label
    Friend WithEvents lblPaciente02 As Label
    Friend WithEvents lblPaciente03 As Label
    Friend WithEvents lblPaciente04 As Label
    Friend WithEvents lblPaciente05 As Label
    Friend WithEvents lblPaciente06 As Label
    Friend WithEvents lblPaciente07 As Label
    Friend WithEvents lblTipoAtendimento01 As Label
    Friend WithEvents lblTipoAtendimento02 As Label
    Friend WithEvents lblTipoAtendimento03 As Label
    Friend WithEvents lblTipoAtendimento04 As Label
    Friend WithEvents lblTipoAtendimento05 As Label
    Friend WithEvents lblTipoAtendimento06 As Label
    Friend WithEvents lblTipoAtendimento07 As Label
    Friend WithEvents lblStatus01 As Label
    Friend WithEvents lblStatus02 As Label
    Friend WithEvents lblStatus03 As Label
    Friend WithEvents lblStatus04 As Label
    Friend WithEvents lblStatus05 As Label
    Friend WithEvents lblStatus06 As Label
    Friend WithEvents lblStatus07 As Label
    Friend WithEvents lblValor07 As Label
    Friend WithEvents lblValor06 As Label
    Friend WithEvents lblValor05 As Label
    Friend WithEvents lblValor04 As Label
    Friend WithEvents lblValor03 As Label
    Friend WithEvents lblValor02 As Label
    Friend WithEvents lblValor01 As Label
    Friend WithEvents lblVlPrestador07 As Label
    Friend WithEvents lblVlPrestador06 As Label
    Friend WithEvents lblVlPrestador05 As Label
    Friend WithEvents lblVlPrestador04 As Label
    Friend WithEvents lblVlPrestador03 As Label
    Friend WithEvents lblVlPrestador02 As Label
    Friend WithEvents lblVlPrestador01 As Label
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents lblValorTotal As Label
    Friend WithEvents lblVlPrestadorTotal As Label
    Friend WithEvents psqPessoa As uscPesqPessoa
End Class
