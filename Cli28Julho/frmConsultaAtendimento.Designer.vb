<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaAtendimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAtendimento))
        Me.txtDataPesquisa = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.cboConsultorio = New System.Windows.Forms.ComboBox()
        Me.picGeral = New System.Windows.Forms.PictureBox()
        Me.cboEspecialidade = New System.Windows.Forms.ComboBox()
        Me.cboTurno = New System.Windows.Forms.ComboBox()
        Me.VScrollBar = New System.Windows.Forms.VScrollBar()
        Me.lblRAtendimentoDisponivel = New System.Windows.Forms.Label()
        Me.lblAtendimentoDisponivel = New System.Windows.Forms.Label()
        Me.chkFiltroConsulta = New System.Windows.Forms.CheckBox()
        Me.chkFiltroExame = New System.Windows.Forms.CheckBox()
        Me.chkFiltroRetorno = New System.Windows.Forms.CheckBox()
        Me.chkAtendidos = New System.Windows.Forms.CheckBox()
        Me.cmdAtualizar = New System.Windows.Forms.Button()
        Me.oConsultaAtendimento_Item12 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item11 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item10 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item09 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item08 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item07 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item06 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item05 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item04 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item03 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item02 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.oConsultaAtendimento_Item01 = New Cli28Julho.uscConsultaAtendimento_Item()
        Me.cmdFechar = New Cli28Julho.uscBotao()
        Me.cmdAtendimentosRealizados = New Cli28Julho.uscBotao()
        Me.cmdSolicitarAssistencia = New System.Windows.Forms.Button()
        CType(Me.txtDataPesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDataPesquisa
        '
        Me.txtDataPesquisa.DateTime = New Date(2021, 2, 18, 0, 0, 0, 0)
        Me.txtDataPesquisa.Location = New System.Drawing.Point(215, 72)
        Me.txtDataPesquisa.Name = "txtDataPesquisa"
        Me.txtDataPesquisa.Size = New System.Drawing.Size(89, 21)
        Me.txtDataPesquisa.TabIndex = 160
        Me.txtDataPesquisa.Value = New Date(2021, 2, 18, 0, 0, 0, 0)
        '
        'cboConsultorio
        '
        Me.cboConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsultorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConsultorio.FormattingEnabled = True
        Me.cboConsultorio.Location = New System.Drawing.Point(213, 156)
        Me.cboConsultorio.Name = "cboConsultorio"
        Me.cboConsultorio.Size = New System.Drawing.Size(304, 24)
        Me.cboConsultorio.TabIndex = 253
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(1280, 230)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 126
        Me.picGeral.TabStop = False
        '
        'cboEspecialidade
        '
        Me.cboEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEspecialidade.FormattingEnabled = True
        Me.cboEspecialidade.Location = New System.Drawing.Point(213, 115)
        Me.cboEspecialidade.Name = "cboEspecialidade"
        Me.cboEspecialidade.Size = New System.Drawing.Size(304, 24)
        Me.cboEspecialidade.TabIndex = 276
        '
        'cboTurno
        '
        Me.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTurno.FormattingEnabled = True
        Me.cboTurno.Location = New System.Drawing.Point(615, 156)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.Size = New System.Drawing.Size(174, 24)
        Me.cboTurno.TabIndex = 277
        '
        'VScrollBar
        '
        Me.VScrollBar.Location = New System.Drawing.Point(1254, 235)
        Me.VScrollBar.Minimum = 1
        Me.VScrollBar.Name = "VScrollBar"
        Me.VScrollBar.Size = New System.Drawing.Size(17, 373)
        Me.VScrollBar.TabIndex = 295
        Me.VScrollBar.Value = 1
        '
        'lblRAtendimentoDisponivel
        '
        Me.lblRAtendimentoDisponivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRAtendimentoDisponivel.Location = New System.Drawing.Point(1042, 72)
        Me.lblRAtendimentoDisponivel.Name = "lblRAtendimentoDisponivel"
        Me.lblRAtendimentoDisponivel.Size = New System.Drawing.Size(193, 62)
        Me.lblRAtendimentoDisponivel.TabIndex = 296
        Me.lblRAtendimentoDisponivel.Text = "Atendimentos Disponíveis"
        Me.lblRAtendimentoDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAtendimentoDisponivel
        '
        Me.lblAtendimentoDisponivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtendimentoDisponivel.Location = New System.Drawing.Point(1042, 136)
        Me.lblAtendimentoDisponivel.Name = "lblAtendimentoDisponivel"
        Me.lblAtendimentoDisponivel.Size = New System.Drawing.Size(193, 31)
        Me.lblAtendimentoDisponivel.TabIndex = 297
        Me.lblAtendimentoDisponivel.Text = "0"
        Me.lblAtendimentoDisponivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkFiltroConsulta
        '
        Me.chkFiltroConsulta.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chkFiltroConsulta.Checked = True
        Me.chkFiltroConsulta.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltroConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltroConsulta.Location = New System.Drawing.Point(799, 142)
        Me.chkFiltroConsulta.Name = "chkFiltroConsulta"
        Me.chkFiltroConsulta.Size = New System.Drawing.Size(75, 35)
        Me.chkFiltroConsulta.TabIndex = 298
        Me.chkFiltroConsulta.Tag = "1"
        Me.chkFiltroConsulta.Text = "Consulta"
        Me.chkFiltroConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFiltroConsulta.UseVisualStyleBackColor = True
        '
        'chkFiltroExame
        '
        Me.chkFiltroExame.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chkFiltroExame.Checked = True
        Me.chkFiltroExame.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltroExame.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltroExame.Location = New System.Drawing.Point(880, 142)
        Me.chkFiltroExame.Name = "chkFiltroExame"
        Me.chkFiltroExame.Size = New System.Drawing.Size(59, 35)
        Me.chkFiltroExame.TabIndex = 299
        Me.chkFiltroExame.Tag = "3"
        Me.chkFiltroExame.Text = "Exame"
        Me.chkFiltroExame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFiltroExame.UseVisualStyleBackColor = True
        '
        'chkFiltroRetorno
        '
        Me.chkFiltroRetorno.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chkFiltroRetorno.Checked = True
        Me.chkFiltroRetorno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFiltroRetorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFiltroRetorno.Location = New System.Drawing.Point(945, 142)
        Me.chkFiltroRetorno.Name = "chkFiltroRetorno"
        Me.chkFiltroRetorno.Size = New System.Drawing.Size(75, 35)
        Me.chkFiltroRetorno.TabIndex = 300
        Me.chkFiltroRetorno.Tag = "4"
        Me.chkFiltroRetorno.Text = "Retorno"
        Me.chkFiltroRetorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkFiltroRetorno.UseVisualStyleBackColor = True
        '
        'chkAtendidos
        '
        Me.chkAtendidos.AutoSize = True
        Me.chkAtendidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAtendidos.Location = New System.Drawing.Point(831, 21)
        Me.chkAtendidos.Name = "chkAtendidos"
        Me.chkAtendidos.Size = New System.Drawing.Size(99, 21)
        Me.chkAtendidos.TabIndex = 302
        Me.chkAtendidos.Tag = "1"
        Me.chkAtendidos.Text = "Atendidos"
        Me.chkAtendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkAtendidos.UseVisualStyleBackColor = True
        '
        'cmdAtualizar
        '
        Me.cmdAtualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAtualizar.Location = New System.Drawing.Point(520, 15)
        Me.cmdAtualizar.Name = "cmdAtualizar"
        Me.cmdAtualizar.Size = New System.Drawing.Size(118, 30)
        Me.cmdAtualizar.TabIndex = 303
        Me.cmdAtualizar.Text = "Atualizar"
        Me.cmdAtualizar.UseVisualStyleBackColor = True
        '
        'oConsultaAtendimento_Item12
        '
        Me.oConsultaAtendimento_Item12.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item12.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item12.Location = New System.Drawing.Point(5, 576)
        Me.oConsultaAtendimento_Item12.Name = "oConsultaAtendimento_Item12"
        Me.oConsultaAtendimento_Item12.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item12.TabIndex = 289
        '
        'oConsultaAtendimento_Item11
        '
        Me.oConsultaAtendimento_Item11.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item11.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item11.Location = New System.Drawing.Point(5, 545)
        Me.oConsultaAtendimento_Item11.Name = "oConsultaAtendimento_Item11"
        Me.oConsultaAtendimento_Item11.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item11.TabIndex = 288
        '
        'oConsultaAtendimento_Item10
        '
        Me.oConsultaAtendimento_Item10.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item10.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item10.Location = New System.Drawing.Point(5, 514)
        Me.oConsultaAtendimento_Item10.Name = "oConsultaAtendimento_Item10"
        Me.oConsultaAtendimento_Item10.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item10.TabIndex = 287
        '
        'oConsultaAtendimento_Item09
        '
        Me.oConsultaAtendimento_Item09.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item09.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item09.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item09.Location = New System.Drawing.Point(5, 483)
        Me.oConsultaAtendimento_Item09.Name = "oConsultaAtendimento_Item09"
        Me.oConsultaAtendimento_Item09.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item09.TabIndex = 286
        '
        'oConsultaAtendimento_Item08
        '
        Me.oConsultaAtendimento_Item08.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item08.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item08.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item08.Location = New System.Drawing.Point(5, 452)
        Me.oConsultaAtendimento_Item08.Name = "oConsultaAtendimento_Item08"
        Me.oConsultaAtendimento_Item08.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item08.TabIndex = 285
        '
        'oConsultaAtendimento_Item07
        '
        Me.oConsultaAtendimento_Item07.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item07.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item07.Location = New System.Drawing.Point(5, 421)
        Me.oConsultaAtendimento_Item07.Name = "oConsultaAtendimento_Item07"
        Me.oConsultaAtendimento_Item07.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item07.TabIndex = 284
        '
        'oConsultaAtendimento_Item06
        '
        Me.oConsultaAtendimento_Item06.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item06.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item06.Location = New System.Drawing.Point(5, 390)
        Me.oConsultaAtendimento_Item06.Name = "oConsultaAtendimento_Item06"
        Me.oConsultaAtendimento_Item06.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item06.TabIndex = 283
        '
        'oConsultaAtendimento_Item05
        '
        Me.oConsultaAtendimento_Item05.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item05.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item05.Location = New System.Drawing.Point(5, 359)
        Me.oConsultaAtendimento_Item05.Name = "oConsultaAtendimento_Item05"
        Me.oConsultaAtendimento_Item05.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item05.TabIndex = 282
        '
        'oConsultaAtendimento_Item04
        '
        Me.oConsultaAtendimento_Item04.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item04.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item04.Location = New System.Drawing.Point(5, 328)
        Me.oConsultaAtendimento_Item04.Name = "oConsultaAtendimento_Item04"
        Me.oConsultaAtendimento_Item04.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item04.TabIndex = 281
        '
        'oConsultaAtendimento_Item03
        '
        Me.oConsultaAtendimento_Item03.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item03.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item03.Location = New System.Drawing.Point(5, 297)
        Me.oConsultaAtendimento_Item03.Name = "oConsultaAtendimento_Item03"
        Me.oConsultaAtendimento_Item03.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item03.TabIndex = 280
        '
        'oConsultaAtendimento_Item02
        '
        Me.oConsultaAtendimento_Item02.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item02.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item02.Location = New System.Drawing.Point(5, 266)
        Me.oConsultaAtendimento_Item02.Name = "oConsultaAtendimento_Item02"
        Me.oConsultaAtendimento_Item02.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item02.TabIndex = 279
        '
        'oConsultaAtendimento_Item01
        '
        Me.oConsultaAtendimento_Item01.BackgroundImage = CType(resources.GetObject("oConsultaAtendimento_Item01.BackgroundImage"), System.Drawing.Image)
        Me.oConsultaAtendimento_Item01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.oConsultaAtendimento_Item01.Location = New System.Drawing.Point(5, 235)
        Me.oConsultaAtendimento_Item01.Name = "oConsultaAtendimento_Item01"
        Me.oConsultaAtendimento_Item01.Size = New System.Drawing.Size(1249, 31)
        Me.oConsultaAtendimento_Item01.TabIndex = 278
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(766, 50)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 129
        '
        'cmdAtendimentosRealizados
        '
        Me.cmdAtendimentosRealizados.AutoSize = True
        Me.cmdAtendimentosRealizados.Location = New System.Drawing.Point(546, 50)
        Me.cmdAtendimentosRealizados.Name = "cmdAtendimentosRealizados"
        Me.cmdAtendimentosRealizados.Size = New System.Drawing.Size(16, 17)
        Me.cmdAtendimentosRealizados.TabIndex = 127
        '
        'cmdSolicitarAssistencia
        '
        Me.cmdSolicitarAssistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmdSolicitarAssistencia.Location = New System.Drawing.Point(645, 15)
        Me.cmdSolicitarAssistencia.Name = "cmdSolicitarAssistencia"
        Me.cmdSolicitarAssistencia.Size = New System.Drawing.Size(180, 30)
        Me.cmdSolicitarAssistencia.TabIndex = 357
        Me.cmdSolicitarAssistencia.Text = "Solicitar Assistência"
        Me.cmdSolicitarAssistencia.UseVisualStyleBackColor = True
        '
        'frmConsultaAtendimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1302, 749)
        Me.Controls.Add(Me.cmdSolicitarAssistencia)
        Me.Controls.Add(Me.cmdAtualizar)
        Me.Controls.Add(Me.chkAtendidos)
        Me.Controls.Add(Me.chkFiltroRetorno)
        Me.Controls.Add(Me.chkFiltroExame)
        Me.Controls.Add(Me.chkFiltroConsulta)
        Me.Controls.Add(Me.lblAtendimentoDisponivel)
        Me.Controls.Add(Me.lblRAtendimentoDisponivel)
        Me.Controls.Add(Me.VScrollBar)
        Me.Controls.Add(Me.oConsultaAtendimento_Item12)
        Me.Controls.Add(Me.oConsultaAtendimento_Item11)
        Me.Controls.Add(Me.oConsultaAtendimento_Item10)
        Me.Controls.Add(Me.oConsultaAtendimento_Item09)
        Me.Controls.Add(Me.oConsultaAtendimento_Item08)
        Me.Controls.Add(Me.oConsultaAtendimento_Item07)
        Me.Controls.Add(Me.oConsultaAtendimento_Item06)
        Me.Controls.Add(Me.oConsultaAtendimento_Item05)
        Me.Controls.Add(Me.oConsultaAtendimento_Item04)
        Me.Controls.Add(Me.oConsultaAtendimento_Item03)
        Me.Controls.Add(Me.oConsultaAtendimento_Item02)
        Me.Controls.Add(Me.oConsultaAtendimento_Item01)
        Me.Controls.Add(Me.cboTurno)
        Me.Controls.Add(Me.cboEspecialidade)
        Me.Controls.Add(Me.cboConsultorio)
        Me.Controls.Add(Me.txtDataPesquisa)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdAtendimentosRealizados)
        Me.Controls.Add(Me.picGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmConsultaAtendimento"
        Me.Text = "Consulta de Atendimento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txtDataPesquisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDataPesquisa As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents cmdAtendimentosRealizados As uscBotao
    Friend WithEvents cboConsultorio As ComboBox
    Friend WithEvents picGeral As PictureBox
    Friend WithEvents cboEspecialidade As ComboBox
    Friend WithEvents cboTurno As ComboBox
    Friend WithEvents oConsultaAtendimento_Item01 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item02 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item04 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item03 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item08 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item07 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item06 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item05 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item12 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item11 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item10 As uscConsultaAtendimento_Item
    Friend WithEvents oConsultaAtendimento_Item09 As uscConsultaAtendimento_Item
    Friend WithEvents VScrollBar As VScrollBar
    Friend WithEvents lblRAtendimentoDisponivel As Label
    Friend WithEvents lblAtendimentoDisponivel As Label
    Friend WithEvents chkFiltroConsulta As CheckBox
    Friend WithEvents chkFiltroExame As CheckBox
    Friend WithEvents chkFiltroRetorno As CheckBox
    Friend WithEvents chkAtendidos As CheckBox
    Friend WithEvents cmdAtualizar As Button
    Friend WithEvents cmdSolicitarAssistencia As Button
End Class
