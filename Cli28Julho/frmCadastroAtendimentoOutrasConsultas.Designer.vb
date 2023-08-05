<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoOutrasConsultas
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoOutrasConsultas))
    Me.VScrollBar = New System.Windows.Forms.VScrollBar()
    Me.lblCodigoProcedimento01 = New System.Windows.Forms.Label()
    Me.lblCodigoProcedimento02 = New System.Windows.Forms.Label()
    Me.lblCodigoProcedimento03 = New System.Windows.Forms.Label()
    Me.lblCodigoProcedimento04 = New System.Windows.Forms.Label()
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.lblDataHora01 = New System.Windows.Forms.Label()
    Me.lblDataHora02 = New System.Windows.Forms.Label()
    Me.lblDataHora03 = New System.Windows.Forms.Label()
    Me.lblDataHora04 = New System.Windows.Forms.Label()
    Me.lblDescricaoProcedimento01 = New System.Windows.Forms.Label()
    Me.lblDescricaoProcedimento02 = New System.Windows.Forms.Label()
    Me.lblDescricaoProcedimento03 = New System.Windows.Forms.Label()
    Me.lblDescricaoProcedimento04 = New System.Windows.Forms.Label()
    Me.rtbDescricao01 = New System.Windows.Forms.RichTextBox()
    Me.rtbDescricao02 = New System.Windows.Forms.RichTextBox()
    Me.rtbDescricao03 = New System.Windows.Forms.RichTextBox()
    Me.rtbDescricao04 = New System.Windows.Forms.RichTextBox()
    Me.lblIdade = New System.Windows.Forms.Label()
    Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.optMinhasConsultas = New System.Windows.Forms.RadioButton()
    Me.optOutrosProfissionais = New System.Windows.Forms.RadioButton()
    Me.lstExamesSolicitados01 = New System.Windows.Forms.ListBox()
    Me.lstExamesSolicitados02 = New System.Windows.Forms.ListBox()
    Me.lstExamesSolicitados03 = New System.Windows.Forms.ListBox()
    Me.lstExamesSolicitados04 = New System.Windows.Forms.ListBox()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.cmdListar = New Cli28Julho.uscBotao()
    Me.lblPaciente = New System.Windows.Forms.Label()
        Me.lblMedico01 = New System.Windows.Forms.Label()
        Me.lblMedico02 = New System.Windows.Forms.Label()
        Me.lblMedico03 = New System.Windows.Forms.Label()
        Me.lblMedico04 = New System.Windows.Forms.Label()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VScrollBar
        '
        Me.VScrollBar.Location = New System.Drawing.Point(752, 134)
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(17, 451)
        Me.VScrollBar.TabIndex = 1
        '
        'lblCodigoProcedimento01
        '
        Me.lblCodigoProcedimento01.BackColor = System.Drawing.Color.White
        Me.lblCodigoProcedimento01.Location = New System.Drawing.Point(10, 150)
        Me.lblCodigoProcedimento01.Name = "lblCodigoProcedimento01"
        Me.lblCodigoProcedimento01.Size = New System.Drawing.Size(135, 13)
        Me.lblCodigoProcedimento01.TabIndex = 2
        Me.lblCodigoProcedimento01.Text = "lblCodigoProcedimento01"
        '
        'lblCodigoProcedimento02
        '
        Me.lblCodigoProcedimento02.BackColor = System.Drawing.Color.White
        Me.lblCodigoProcedimento02.Location = New System.Drawing.Point(10, 264)
        Me.lblCodigoProcedimento02.Name = "lblCodigoProcedimento02"
        Me.lblCodigoProcedimento02.Size = New System.Drawing.Size(135, 13)
        Me.lblCodigoProcedimento02.TabIndex = 3
        Me.lblCodigoProcedimento02.Text = "lblCodigoProcedimento02"
        '
        'lblCodigoProcedimento03
        '
        Me.lblCodigoProcedimento03.BackColor = System.Drawing.Color.White
        Me.lblCodigoProcedimento03.Location = New System.Drawing.Point(10, 379)
        Me.lblCodigoProcedimento03.Name = "lblCodigoProcedimento03"
        Me.lblCodigoProcedimento03.Size = New System.Drawing.Size(135, 13)
        Me.lblCodigoProcedimento03.TabIndex = 4
        Me.lblCodigoProcedimento03.Text = "lblCodigoProcedimento03"
        '
        'lblCodigoProcedimento04
        '
        Me.lblCodigoProcedimento04.BackColor = System.Drawing.Color.White
        Me.lblCodigoProcedimento04.Location = New System.Drawing.Point(10, 494)
        Me.lblCodigoProcedimento04.Name = "lblCodigoProcedimento04"
        Me.lblCodigoProcedimento04.Size = New System.Drawing.Size(135, 13)
        Me.lblCodigoProcedimento04.TabIndex = 5
        Me.lblCodigoProcedimento04.Text = "lblCodigoProcedimento04"
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(760, 581)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'lblDataHora01
        '
        Me.lblDataHora01.AutoSize = True
        Me.lblDataHora01.BackColor = System.Drawing.Color.White
        Me.lblDataHora01.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataHora01.Location = New System.Drawing.Point(30, 220)
        Me.lblDataHora01.Name = "lblDataHora01"
        Me.lblDataHora01.Size = New System.Drawing.Size(106, 13)
        Me.lblDataHora01.TabIndex = 6
        Me.lblDataHora01.Text = "99/99/9999 99:99:99"
        '
        'lblDataHora02
        '
        Me.lblDataHora02.AutoSize = True
        Me.lblDataHora02.BackColor = System.Drawing.Color.White
        Me.lblDataHora02.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataHora02.Location = New System.Drawing.Point(30, 334)
        Me.lblDataHora02.Name = "lblDataHora02"
        Me.lblDataHora02.Size = New System.Drawing.Size(106, 13)
        Me.lblDataHora02.TabIndex = 7
        Me.lblDataHora02.Text = "99/99/9999 99:99:99"
        '
        'lblDataHora03
        '
        Me.lblDataHora03.AutoSize = True
        Me.lblDataHora03.BackColor = System.Drawing.Color.White
        Me.lblDataHora03.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataHora03.Location = New System.Drawing.Point(30, 449)
        Me.lblDataHora03.Name = "lblDataHora03"
        Me.lblDataHora03.Size = New System.Drawing.Size(106, 13)
        Me.lblDataHora03.TabIndex = 8
        Me.lblDataHora03.Text = "99/99/9999 99:99:99"
        '
        'lblDataHora04
        '
        Me.lblDataHora04.AutoSize = True
        Me.lblDataHora04.BackColor = System.Drawing.Color.White
        Me.lblDataHora04.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataHora04.Location = New System.Drawing.Point(30, 563)
        Me.lblDataHora04.Name = "lblDataHora04"
        Me.lblDataHora04.Size = New System.Drawing.Size(106, 13)
        Me.lblDataHora04.TabIndex = 9
        Me.lblDataHora04.Text = "99/99/9999 99:99:99"
        '
        'lblDescricaoProcedimento01
        '
        Me.lblDescricaoProcedimento01.BackColor = System.Drawing.Color.White
        Me.lblDescricaoProcedimento01.Location = New System.Drawing.Point(10, 164)
        Me.lblDescricaoProcedimento01.Name = "lblDescricaoProcedimento01"
        Me.lblDescricaoProcedimento01.Size = New System.Drawing.Size(135, 30)
        Me.lblDescricaoProcedimento01.TabIndex = 10
        Me.lblDescricaoProcedimento01.Text = "lblDescricaoProcedimento01"
        '
        'lblDescricaoProcedimento02
        '
        Me.lblDescricaoProcedimento02.BackColor = System.Drawing.Color.White
        Me.lblDescricaoProcedimento02.Location = New System.Drawing.Point(10, 279)
        Me.lblDescricaoProcedimento02.Name = "lblDescricaoProcedimento02"
        Me.lblDescricaoProcedimento02.Size = New System.Drawing.Size(135, 30)
        Me.lblDescricaoProcedimento02.TabIndex = 11
        Me.lblDescricaoProcedimento02.Text = "lblDescricaoProcedimento02"
        '
        'lblDescricaoProcedimento03
        '
        Me.lblDescricaoProcedimento03.BackColor = System.Drawing.Color.White
        Me.lblDescricaoProcedimento03.Location = New System.Drawing.Point(10, 394)
        Me.lblDescricaoProcedimento03.Name = "lblDescricaoProcedimento03"
        Me.lblDescricaoProcedimento03.Size = New System.Drawing.Size(135, 30)
        Me.lblDescricaoProcedimento03.TabIndex = 12
        Me.lblDescricaoProcedimento03.Text = "lblDescricaoProcedimento03"
        '
        'lblDescricaoProcedimento04
        '
        Me.lblDescricaoProcedimento04.BackColor = System.Drawing.Color.White
        Me.lblDescricaoProcedimento04.Location = New System.Drawing.Point(10, 509)
        Me.lblDescricaoProcedimento04.Name = "lblDescricaoProcedimento04"
        Me.lblDescricaoProcedimento04.Size = New System.Drawing.Size(135, 30)
        Me.lblDescricaoProcedimento04.TabIndex = 13
        Me.lblDescricaoProcedimento04.Text = "lblDescricaoProcedimento04"
        '
        'rtbDescricao01
        '
        Me.rtbDescricao01.BackColor = System.Drawing.SystemColors.Window
        Me.rtbDescricao01.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescricao01.Location = New System.Drawing.Point(159, 135)
        Me.rtbDescricao01.Name = "rtbDescricao01"
        Me.rtbDescricao01.Size = New System.Drawing.Size(279, 101)
        Me.rtbDescricao01.TabIndex = 14
        Me.rtbDescricao01.Text = ""
        '
        'rtbDescricao02
        '
        Me.rtbDescricao02.BackColor = System.Drawing.SystemColors.Window
        Me.rtbDescricao02.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescricao02.Location = New System.Drawing.Point(159, 253)
        Me.rtbDescricao02.Name = "rtbDescricao02"
        Me.rtbDescricao02.Size = New System.Drawing.Size(279, 100)
        Me.rtbDescricao02.TabIndex = 16
        Me.rtbDescricao02.Text = ""
        '
        'rtbDescricao03
        '
        Me.rtbDescricao03.BackColor = System.Drawing.SystemColors.Window
        Me.rtbDescricao03.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescricao03.Location = New System.Drawing.Point(159, 368)
        Me.rtbDescricao03.Name = "rtbDescricao03"
        Me.rtbDescricao03.Size = New System.Drawing.Size(279, 98)
        Me.rtbDescricao03.TabIndex = 18
        Me.rtbDescricao03.Text = ""
        '
        'rtbDescricao04
        '
        Me.rtbDescricao04.BackColor = System.Drawing.SystemColors.Window
        Me.rtbDescricao04.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescricao04.Location = New System.Drawing.Point(159, 480)
        Me.rtbDescricao04.Name = "rtbDescricao04"
        Me.rtbDescricao04.Size = New System.Drawing.Size(279, 101)
        Me.rtbDescricao04.TabIndex = 20
        Me.rtbDescricao04.Text = ""
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Location = New System.Drawing.Point(443, 36)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(44, 13)
        Me.lblIdade.TabIndex = 23
        Me.lblIdade.Text = "lblIdade"
        '
        'txtDataInicial
        '
        Me.txtDataInicial.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDataInicial.DateTime = New Date(2020, 5, 22, 0, 0, 0, 0)
        Me.txtDataInicial.Location = New System.Drawing.Point(34, 76)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(89, 17)
        Me.txtDataInicial.TabIndex = 163
        Me.txtDataInicial.Value = New Date(2020, 5, 22, 0, 0, 0, 0)
        '
        'txtDataFinal
        '
        Me.txtDataFinal.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDataFinal.DateTime = New Date(2020, 5, 22, 0, 0, 0, 0)
        Me.txtDataFinal.Location = New System.Drawing.Point(132, 76)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(89, 17)
        Me.txtDataFinal.TabIndex = 164
        Me.txtDataFinal.Value = New Date(2020, 5, 22, 0, 0, 0, 0)
        '
        'optMinhasConsultas
        '
        Me.optMinhasConsultas.AutoSize = True
        Me.optMinhasConsultas.Checked = True
        Me.optMinhasConsultas.Location = New System.Drawing.Point(258, 85)
        Me.optMinhasConsultas.Name = "optMinhasConsultas"
        Me.optMinhasConsultas.Size = New System.Drawing.Size(14, 13)
        Me.optMinhasConsultas.TabIndex = 165
        Me.optMinhasConsultas.TabStop = True
        Me.optMinhasConsultas.UseVisualStyleBackColor = True
        '
        'optOutrosProfissionais
        '
        Me.optOutrosProfissionais.AutoSize = True
        Me.optOutrosProfissionais.Location = New System.Drawing.Point(317, 85)
        Me.optOutrosProfissionais.Name = "optOutrosProfissionais"
        Me.optOutrosProfissionais.Size = New System.Drawing.Size(14, 13)
        Me.optOutrosProfissionais.TabIndex = 166
        Me.optOutrosProfissionais.UseVisualStyleBackColor = True
        '
        'lstExamesSolicitados01
        '
        Me.lstExamesSolicitados01.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstExamesSolicitados01.FormattingEnabled = True
        Me.lstExamesSolicitados01.Location = New System.Drawing.Point(448, 138)
        Me.lstExamesSolicitados01.Name = "lstExamesSolicitados01"
        Me.lstExamesSolicitados01.Size = New System.Drawing.Size(297, 91)
        Me.lstExamesSolicitados01.TabIndex = 170
        '
        'lstExamesSolicitados02
        '
        Me.lstExamesSolicitados02.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstExamesSolicitados02.FormattingEnabled = True
        Me.lstExamesSolicitados02.Location = New System.Drawing.Point(448, 258)
        Me.lstExamesSolicitados02.Name = "lstExamesSolicitados02"
        Me.lstExamesSolicitados02.Size = New System.Drawing.Size(297, 91)
        Me.lstExamesSolicitados02.TabIndex = 171
        '
        'lstExamesSolicitados03
        '
        Me.lstExamesSolicitados03.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstExamesSolicitados03.FormattingEnabled = True
        Me.lstExamesSolicitados03.Location = New System.Drawing.Point(448, 372)
        Me.lstExamesSolicitados03.Name = "lstExamesSolicitados03"
        Me.lstExamesSolicitados03.Size = New System.Drawing.Size(297, 91)
        Me.lstExamesSolicitados03.TabIndex = 172
        '
        'lstExamesSolicitados04
        '
        Me.lstExamesSolicitados04.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstExamesSolicitados04.FormattingEnabled = True
        Me.lstExamesSolicitados04.Location = New System.Drawing.Point(448, 485)
        Me.lstExamesSolicitados04.Name = "lstExamesSolicitados04"
        Me.lstExamesSolicitados04.Size = New System.Drawing.Size(297, 91)
        Me.lstExamesSolicitados04.TabIndex = 173
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(475, 70)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 168
        '
        'cmdListar
        '
        Me.cmdListar.AutoSize = True
        Me.cmdListar.Location = New System.Drawing.Point(389, 70)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(16, 17)
        Me.cmdListar.TabIndex = 167
        '
        'lblPaciente
        '
        Me.lblPaciente.Location = New System.Drawing.Point(32, 36)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(404, 13)
        Me.lblPaciente.TabIndex = 174
        Me.lblPaciente.Text = "lblPaciente"
        '
        'lblMedico01
        '
        Me.lblMedico01.BackColor = System.Drawing.Color.White
        Me.lblMedico01.Location = New System.Drawing.Point(10, 194)
        Me.lblMedico01.Name = "lblMedico01"
        Me.lblMedico01.Size = New System.Drawing.Size(135, 13)
        Me.lblMedico01.TabIndex = 175
        Me.lblMedico01.Text = "lblMedico01"
        '
        'lblMedico02
        '
        Me.lblMedico02.BackColor = System.Drawing.Color.White
        Me.lblMedico02.Location = New System.Drawing.Point(10, 309)
        Me.lblMedico02.Name = "lblMedico02"
        Me.lblMedico02.Size = New System.Drawing.Size(135, 13)
        Me.lblMedico02.TabIndex = 176
        Me.lblMedico02.Text = "lblMedico02"
        '
        'lblMedico03
        '
        Me.lblMedico03.BackColor = System.Drawing.Color.White
        Me.lblMedico03.Location = New System.Drawing.Point(10, 424)
        Me.lblMedico03.Name = "lblMedico03"
        Me.lblMedico03.Size = New System.Drawing.Size(135, 13)
        Me.lblMedico03.TabIndex = 177
        Me.lblMedico03.Text = "lblMedico03"
        '
        'lblMedico04
        '
        Me.lblMedico04.BackColor = System.Drawing.Color.White
        Me.lblMedico04.Location = New System.Drawing.Point(10, 539)
        Me.lblMedico04.Name = "lblMedico04"
        Me.lblMedico04.Size = New System.Drawing.Size(135, 13)
        Me.lblMedico04.TabIndex = 178
        Me.lblMedico04.Text = "lblMedico04"
        '
        'frmCadastroAtendimentoOutrasConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMedico04)
        Me.Controls.Add(Me.lblMedico03)
        Me.Controls.Add(Me.lblMedico02)
        Me.Controls.Add(Me.lblMedico01)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.lstExamesSolicitados04)
        Me.Controls.Add(Me.lstExamesSolicitados03)
        Me.Controls.Add(Me.lstExamesSolicitados02)
        Me.Controls.Add(Me.lstExamesSolicitados01)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.optOutrosProfissionais)
        Me.Controls.Add(Me.optMinhasConsultas)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.txtDataInicial)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.rtbDescricao04)
        Me.Controls.Add(Me.rtbDescricao03)
        Me.Controls.Add(Me.rtbDescricao02)
        Me.Controls.Add(Me.rtbDescricao01)
        Me.Controls.Add(Me.lblDescricaoProcedimento04)
        Me.Controls.Add(Me.lblDescricaoProcedimento03)
        Me.Controls.Add(Me.lblDescricaoProcedimento02)
        Me.Controls.Add(Me.lblDescricaoProcedimento01)
        Me.Controls.Add(Me.lblDataHora04)
        Me.Controls.Add(Me.lblDataHora03)
        Me.Controls.Add(Me.lblDataHora02)
        Me.Controls.Add(Me.lblDataHora01)
        Me.Controls.Add(Me.lblCodigoProcedimento04)
        Me.Controls.Add(Me.lblCodigoProcedimento03)
        Me.Controls.Add(Me.lblCodigoProcedimento02)
        Me.Controls.Add(Me.lblCodigoProcedimento01)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.picGeral)
        Me.MaximizeBox = False
        Me.Name = "frmCadastroAtendimentoOutrasConsultas"
        Me.Text = "Cadastro de Atendimento - Outras Consultas"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents VScrollBar As VScrollBar
  Friend WithEvents lblCodigoProcedimento01 As Label
  Friend WithEvents lblCodigoProcedimento02 As Label
  Friend WithEvents lblCodigoProcedimento03 As Label
  Friend WithEvents lblCodigoProcedimento04 As Label
  Friend WithEvents lblDataHora01 As Label
  Friend WithEvents lblDataHora02 As Label
  Friend WithEvents lblDataHora03 As Label
  Friend WithEvents lblDataHora04 As Label
  Friend WithEvents lblDescricaoProcedimento01 As Label
  Friend WithEvents lblDescricaoProcedimento02 As Label
  Friend WithEvents lblDescricaoProcedimento03 As Label
  Friend WithEvents lblDescricaoProcedimento04 As Label
  Friend WithEvents rtbDescricao01 As RichTextBox
  Friend WithEvents rtbDescricao02 As RichTextBox
  Friend WithEvents rtbDescricao03 As RichTextBox
  Friend WithEvents rtbDescricao04 As RichTextBox
  Friend WithEvents lblIdade As Label
  Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents optMinhasConsultas As RadioButton
  Friend WithEvents optOutrosProfissionais As RadioButton
  Friend WithEvents cmdListar As uscBotao
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents lstExamesSolicitados01 As ListBox
  Friend WithEvents lstExamesSolicitados02 As ListBox
  Friend WithEvents lstExamesSolicitados03 As ListBox
  Friend WithEvents lstExamesSolicitados04 As ListBox
  Friend WithEvents lblPaciente As Label
    Friend WithEvents lblMedico01 As Label
    Friend WithEvents lblMedico02 As Label
    Friend WithEvents lblMedico03 As Label
    Friend WithEvents lblMedico04 As Label
End Class
