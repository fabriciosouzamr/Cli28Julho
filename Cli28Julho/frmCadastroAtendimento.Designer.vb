<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroAtendimento
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimento))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.lblIdade = New System.Windows.Forms.Label()
    Me.txtDataAgendamento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.rtbDescricao = New System.Windows.Forms.RichTextBox()
    Me.picFotoPaciente = New System.Windows.Forms.PictureBox()
    Me.txtConsultasAnterior01 = New System.Windows.Forms.RichTextBox()
    Me.VScrollBar = New System.Windows.Forms.VScrollBar()
    Me.lblMedico01 = New System.Windows.Forms.Label()
    Me.lblDescricaoProcedimento01 = New System.Windows.Forms.Label()
    Me.lblDataHora01 = New System.Windows.Forms.Label()
    Me.lblCodigoProcedimento01 = New System.Windows.Forms.Label()
    Me.pnlExamesSolicitados = New System.Windows.Forms.Panel()
    Me.pnlExamesSolicitadosDetalhe = New System.Windows.Forms.Panel()
    Me.lstExamesSolicitados01 = New System.Windows.Forms.ListBox()
    Me.pnlExamesSolicitadosCabecalho = New System.Windows.Forms.Panel()
    Me.cmdExamesSolicitadosFechar = New System.Windows.Forms.Button()
    Me.cmdExamesSolicitadosExibir = New System.Windows.Forms.Button()
    Me.lblProntuario = New System.Windows.Forms.Label()
    Me.lblPessoa = New System.Windows.Forms.Label()
    Me.lblProcedimento = New System.Windows.Forms.Label()
    Me.cmdRelatorios = New Cli28Julho.uscBotao()
    Me.cmdSalvar = New Cli28Julho.uscBotao()
    Me.cmdFinalizar = New Cli28Julho.uscBotao()
    Me.cmdVascinas = New Cli28Julho.uscBotao()
    Me.cmdReceituario = New Cli28Julho.uscBotao()
    Me.cmdHistorico = New Cli28Julho.uscBotao()
    Me.cmdAtestados = New Cli28Julho.uscBotao()
    Me.cmdExames = New Cli28Julho.uscBotao()
    Me.cmdPacienteCadastro = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataAgendamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFotoPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlExamesSolicitados.SuspendLayout()
        Me.pnlExamesSolicitadosDetalhe.SuspendLayout()
        Me.pnlExamesSolicitadosCabecalho.SuspendLayout()
        Me.SuspendLayout()
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(1036, 578)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'lblIdade
        '
        Me.lblIdade.Location = New System.Drawing.Point(576, 46)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(129, 13)
        Me.lblIdade.TabIndex = 140
        Me.lblIdade.Text = "lblIdade"
        '
        'txtDataAgendamento
        '
        Me.txtDataAgendamento.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDataAgendamento.DateTime = New Date(2022, 2, 1, 0, 0, 0, 0)
        Me.txtDataAgendamento.Location = New System.Drawing.Point(467, 111)
        Me.txtDataAgendamento.Name = "txtDataAgendamento"
        Me.txtDataAgendamento.Size = New System.Drawing.Size(89, 17)
        Me.txtDataAgendamento.TabIndex = 161
        Me.txtDataAgendamento.Value = New Date(2022, 2, 1, 0, 0, 0, 0)
        '
        'rtbDescricao
        '
        Me.rtbDescricao.BackColor = System.Drawing.SystemColors.Window
        Me.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescricao.Location = New System.Drawing.Point(19, 195)
        Me.rtbDescricao.Name = "rtbDescricao"
        Me.rtbDescricao.Size = New System.Drawing.Size(905, 178)
        Me.rtbDescricao.TabIndex = 162
        Me.rtbDescricao.Text = ""
        '
        'picFotoPaciente
        '
        Me.picFotoPaciente.ImageLocation = ""
        Me.picFotoPaciente.Location = New System.Drawing.Point(722, 38)
        Me.picFotoPaciente.Name = "picFotoPaciente"
        Me.picFotoPaciente.Size = New System.Drawing.Size(79, 92)
        Me.picFotoPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFotoPaciente.TabIndex = 165
        Me.picFotoPaciente.TabStop = False
        '
        'txtConsultasAnterior01
        '
        Me.txtConsultasAnterior01.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConsultasAnterior01.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.txtConsultasAnterior01.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConsultasAnterior01.Location = New System.Drawing.Point(196, 440)
        Me.txtConsultasAnterior01.Name = "txtConsultasAnterior01"
        Me.txtConsultasAnterior01.Size = New System.Drawing.Size(801, 134)
        Me.txtConsultasAnterior01.TabIndex = 169
        Me.txtConsultasAnterior01.Text = ""
        '
        'VScrollBar
        '
        Me.VScrollBar.LargeChange = 1
        Me.VScrollBar.Location = New System.Drawing.Point(1044, 430)
        Me.VScrollBar.Maximum = 7
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(17, 152)
        Me.VScrollBar.TabIndex = 171
        '
        'lblMedico01
        '
        Me.lblMedico01.BackColor = System.Drawing.Color.White
        Me.lblMedico01.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblMedico01.Location = New System.Drawing.Point(20, 511)
        Me.lblMedico01.Name = "lblMedico01"
        Me.lblMedico01.Size = New System.Drawing.Size(160, 44)
        Me.lblMedico01.TabIndex = 179
        Me.lblMedico01.Text = "FABRICIO SOUZA MOREIRA"
        '
        'lblDescricaoProcedimento01
        '
        Me.lblDescricaoProcedimento01.BackColor = System.Drawing.Color.White
        Me.lblDescricaoProcedimento01.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblDescricaoProcedimento01.Location = New System.Drawing.Point(20, 463)
        Me.lblDescricaoProcedimento01.Name = "lblDescricaoProcedimento01"
        Me.lblDescricaoProcedimento01.Size = New System.Drawing.Size(160, 48)
        Me.lblDescricaoProcedimento01.TabIndex = 178
        Me.lblDescricaoProcedimento01.Text = "lblDescricaoProcedimento01"
        '
        'lblDataHora01
        '
        Me.lblDataHora01.AutoSize = True
        Me.lblDataHora01.BackColor = System.Drawing.Color.White
        Me.lblDataHora01.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataHora01.Location = New System.Drawing.Point(44, 560)
        Me.lblDataHora01.Name = "lblDataHora01"
        Me.lblDataHora01.Size = New System.Drawing.Size(106, 13)
        Me.lblDataHora01.TabIndex = 177
        Me.lblDataHora01.Text = "99/99/9999 99:99:99"
        '
        'lblCodigoProcedimento01
        '
        Me.lblCodigoProcedimento01.BackColor = System.Drawing.Color.White
        Me.lblCodigoProcedimento01.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblCodigoProcedimento01.Location = New System.Drawing.Point(20, 440)
        Me.lblCodigoProcedimento01.Name = "lblCodigoProcedimento01"
        Me.lblCodigoProcedimento01.Size = New System.Drawing.Size(160, 23)
        Me.lblCodigoProcedimento01.TabIndex = 176
        Me.lblCodigoProcedimento01.Text = "lblCodigoProcedimento01"
        '
        'pnlExamesSolicitados
        '
        Me.pnlExamesSolicitados.Controls.Add(Me.pnlExamesSolicitadosDetalhe)
        Me.pnlExamesSolicitados.Controls.Add(Me.pnlExamesSolicitadosCabecalho)
        Me.pnlExamesSolicitados.Location = New System.Drawing.Point(123, 228)
        Me.pnlExamesSolicitados.Name = "pnlExamesSolicitados"
        Me.pnlExamesSolicitados.Size = New System.Drawing.Size(830, 269)
        Me.pnlExamesSolicitados.TabIndex = 180
        '
        'pnlExamesSolicitadosDetalhe
        '
        Me.pnlExamesSolicitadosDetalhe.Controls.Add(Me.lstExamesSolicitados01)
        Me.pnlExamesSolicitadosDetalhe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlExamesSolicitadosDetalhe.Location = New System.Drawing.Point(0, 30)
        Me.pnlExamesSolicitadosDetalhe.Name = "pnlExamesSolicitadosDetalhe"
        Me.pnlExamesSolicitadosDetalhe.Size = New System.Drawing.Size(830, 239)
        Me.pnlExamesSolicitadosDetalhe.TabIndex = 169
        '
        'lstExamesSolicitados01
        '
        Me.lstExamesSolicitados01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstExamesSolicitados01.FormattingEnabled = True
        Me.lstExamesSolicitados01.Location = New System.Drawing.Point(0, 0)
        Me.lstExamesSolicitados01.Name = "lstExamesSolicitados01"
        Me.lstExamesSolicitados01.Size = New System.Drawing.Size(830, 239)
        Me.lstExamesSolicitados01.TabIndex = 168
        '
        'pnlExamesSolicitadosCabecalho
        '
        Me.pnlExamesSolicitadosCabecalho.Controls.Add(Me.cmdExamesSolicitadosFechar)
        Me.pnlExamesSolicitadosCabecalho.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlExamesSolicitadosCabecalho.Location = New System.Drawing.Point(0, 0)
        Me.pnlExamesSolicitadosCabecalho.Name = "pnlExamesSolicitadosCabecalho"
        Me.pnlExamesSolicitadosCabecalho.Size = New System.Drawing.Size(830, 30)
        Me.pnlExamesSolicitadosCabecalho.TabIndex = 168
        '
        'cmdExamesSolicitadosFechar
        '
        Me.cmdExamesSolicitadosFechar.Location = New System.Drawing.Point(804, 3)
        Me.cmdExamesSolicitadosFechar.Name = "cmdExamesSolicitadosFechar"
        Me.cmdExamesSolicitadosFechar.Size = New System.Drawing.Size(23, 23)
        Me.cmdExamesSolicitadosFechar.TabIndex = 0
        Me.cmdExamesSolicitadosFechar.Text = "X"
        Me.cmdExamesSolicitadosFechar.UseVisualStyleBackColor = True
        '
        'cmdExamesSolicitadosExibir
        '
        Me.cmdExamesSolicitadosExibir.Location = New System.Drawing.Point(1010, 430)
        Me.cmdExamesSolicitadosExibir.Name = "cmdExamesSolicitadosExibir"
        Me.cmdExamesSolicitadosExibir.Size = New System.Drawing.Size(25, 19)
        Me.cmdExamesSolicitadosExibir.TabIndex = 181
        Me.cmdExamesSolicitadosExibir.UseVisualStyleBackColor = True
        '
        'lblProntuario
        '
        Me.lblProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProntuario.Location = New System.Drawing.Point(463, 42)
        Me.lblProntuario.Name = "lblProntuario"
        Me.lblProntuario.Size = New System.Drawing.Size(97, 20)
        Me.lblProntuario.TabIndex = 187
        Me.lblProntuario.Text = "lblProntuario"
        Me.lblProntuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPessoa
        '
        Me.lblPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPessoa.Location = New System.Drawing.Point(36, 42)
        Me.lblPessoa.Name = "lblPessoa"
        Me.lblPessoa.Size = New System.Drawing.Size(413, 20)
        Me.lblPessoa.TabIndex = 192
        Me.lblPessoa.Text = "lblPessoa"
        Me.lblPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcedimento
        '
        Me.lblProcedimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcedimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblProcedimento.Location = New System.Drawing.Point(40, 108)
        Me.lblProcedimento.Name = "lblProcedimento"
        Me.lblProcedimento.Size = New System.Drawing.Size(405, 20)
        Me.lblProcedimento.TabIndex = 193
        Me.lblProcedimento.Text = "lblProcedimento"
        Me.lblProcedimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdRelatorios
        '
        Me.cmdRelatorios.AutoSize = True
        Me.cmdRelatorios.Location = New System.Drawing.Point(886, 145)
        Me.cmdRelatorios.Name = "cmdRelatorios"
        Me.cmdRelatorios.Size = New System.Drawing.Size(16, 17)
        Me.cmdRelatorios.TabIndex = 191
        '
        'cmdSalvar
        '
        Me.cmdSalvar.AutoSize = True
        Me.cmdSalvar.Location = New System.Drawing.Point(900, 241)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(16, 17)
        Me.cmdSalvar.TabIndex = 190
        '
        'cmdFinalizar
        '
        Me.cmdFinalizar.AutoSize = True
        Me.cmdFinalizar.Location = New System.Drawing.Point(900, 325)
        Me.cmdFinalizar.Name = "cmdFinalizar"
        Me.cmdFinalizar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFinalizar.TabIndex = 188
        '
        'cmdVascinas
        '
        Me.cmdVascinas.AutoSize = True
        Me.cmdVascinas.Location = New System.Drawing.Point(750, 145)
        Me.cmdVascinas.Name = "cmdVascinas"
        Me.cmdVascinas.Size = New System.Drawing.Size(16, 17)
        Me.cmdVascinas.TabIndex = 185
        '
        'cmdReceituario
        '
        Me.cmdReceituario.AutoSize = True
        Me.cmdReceituario.Location = New System.Drawing.Point(600, 145)
        Me.cmdReceituario.Name = "cmdReceituario"
        Me.cmdReceituario.Size = New System.Drawing.Size(16, 17)
        Me.cmdReceituario.TabIndex = 184
        '
        'cmdHistorico
        '
        Me.cmdHistorico.AutoSize = True
        Me.cmdHistorico.Location = New System.Drawing.Point(300, 145)
        Me.cmdHistorico.Name = "cmdHistorico"
        Me.cmdHistorico.Size = New System.Drawing.Size(16, 17)
        Me.cmdHistorico.TabIndex = 183
        '
        'cmdAtestados
        '
        Me.cmdAtestados.AutoSize = True
        Me.cmdAtestados.Location = New System.Drawing.Point(450, 145)
        Me.cmdAtestados.Name = "cmdAtestados"
        Me.cmdAtestados.Size = New System.Drawing.Size(16, 17)
        Me.cmdAtestados.TabIndex = 182
        '
        'cmdExames
        '
        Me.cmdExames.AutoSize = True
        Me.cmdExames.Location = New System.Drawing.Point(180, 145)
        Me.cmdExames.Name = "cmdExames"
        Me.cmdExames.Size = New System.Drawing.Size(16, 17)
        Me.cmdExames.TabIndex = 134
        '
        'cmdPacienteCadastro
        '
        Me.cmdPacienteCadastro.AutoSize = True
        Me.cmdPacienteCadastro.Location = New System.Drawing.Point(23, 145)
        Me.cmdPacienteCadastro.Name = "cmdPacienteCadastro"
        Me.cmdPacienteCadastro.Size = New System.Drawing.Size(16, 17)
        Me.cmdPacienteCadastro.TabIndex = 131
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(865, 113)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 128
        '
        'frmCadastroAtendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblProcedimento)
        Me.Controls.Add(Me.pnlExamesSolicitados)
        Me.Controls.Add(Me.lblPessoa)
        Me.Controls.Add(Me.cmdRelatorios)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.cmdFinalizar)
        Me.Controls.Add(Me.lblProntuario)
        Me.Controls.Add(Me.cmdVascinas)
        Me.Controls.Add(Me.cmdReceituario)
        Me.Controls.Add(Me.cmdHistorico)
        Me.Controls.Add(Me.cmdAtestados)
        Me.Controls.Add(Me.cmdExamesSolicitadosExibir)
        Me.Controls.Add(Me.lblMedico01)
        Me.Controls.Add(Me.lblDescricaoProcedimento01)
        Me.Controls.Add(Me.lblDataHora01)
        Me.Controls.Add(Me.lblCodigoProcedimento01)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.txtConsultasAnterior01)
        Me.Controls.Add(Me.picFotoPaciente)
        Me.Controls.Add(Me.rtbDescricao)
        Me.Controls.Add(Me.txtDataAgendamento)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.cmdExames)
        Me.Controls.Add(Me.cmdPacienteCadastro)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.picGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmCadastroAtendimento"
        Me.Text = "Cadastro de Atendimento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataAgendamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFotoPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlExamesSolicitados.ResumeLayout(False)
        Me.pnlExamesSolicitadosDetalhe.ResumeLayout(False)
        Me.pnlExamesSolicitadosCabecalho.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents cmdPacienteCadastro As uscBotao
    Friend WithEvents cmdExames As uscBotao
    Friend WithEvents lblIdade As Label
    Friend WithEvents txtDataAgendamento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents rtbDescricao As RichTextBox
    Friend WithEvents picFotoPaciente As PictureBox
    Friend WithEvents txtConsultasAnterior01 As RichTextBox
    Friend WithEvents VScrollBar As VScrollBar
    Friend WithEvents lblMedico01 As Label
    Friend WithEvents lblDescricaoProcedimento01 As Label
    Friend WithEvents lblDataHora01 As Label
    Friend WithEvents lblCodigoProcedimento01 As Label
    Friend WithEvents pnlExamesSolicitados As Panel
    Friend WithEvents pnlExamesSolicitadosDetalhe As Panel
    Friend WithEvents pnlExamesSolicitadosCabecalho As Panel
    Friend WithEvents cmdExamesSolicitadosFechar As Button
    Friend WithEvents cmdExamesSolicitadosExibir As Button
    Friend WithEvents cmdAtestados As uscBotao
    Friend WithEvents cmdHistorico As uscBotao
    Friend WithEvents cmdReceituario As uscBotao
    Friend WithEvents cmdVascinas As uscBotao
    Friend WithEvents lblProntuario As Label
    Friend WithEvents lstExamesSolicitados01 As ListBox
    Friend WithEvents cmdSalvar As uscBotao
    Friend WithEvents cmdFinalizar As uscBotao
    Friend WithEvents cmdRelatorios As uscBotao
    Friend WithEvents lblPessoa As Label
    Friend WithEvents lblProcedimento As Label
End Class
