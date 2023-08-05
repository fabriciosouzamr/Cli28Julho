<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroAtestado
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtestado))
    Me.cmdSalvar = New Cli28Julho.uscBotao()
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.optMedico = New System.Windows.Forms.RadioButton()
    Me.optComparecimento = New System.Windows.Forms.RadioButton()
    Me.optAcompanhamento = New System.Windows.Forms.RadioButton()
    Me.txtDataAtestado = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDiasRepouso = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.txtCID = New System.Windows.Forms.TextBox()
    Me.txtAcompanhamente = New System.Windows.Forms.TextBox()
    Me.cboCidBuscar = New System.Windows.Forms.ComboBox()
    Me.txtCidBuscar = New System.Windows.Forms.TextBox()
    Me.cmdCidSelecionar = New System.Windows.Forms.Button()
    Me.lblProntuario = New System.Windows.Forms.Label()
    Me.pnlAcompanhante = New System.Windows.Forms.Panel()
    Me.lblPessoa = New System.Windows.Forms.Label()
    Me.chkImprimir = New System.Windows.Forms.CheckBox()
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataAtestado, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDiasRepouso, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdSalvar
    '
    Me.cmdSalvar.AutoSize = True
    Me.cmdSalvar.Location = New System.Drawing.Point(701, 120)
    Me.cmdSalvar.Name = "cmdSalvar"
    Me.cmdSalvar.Size = New System.Drawing.Size(16, 17)
    Me.cmdSalvar.TabIndex = 1
    '
    'picGeral
    '
    Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
    Me.picGeral.Location = New System.Drawing.Point(5, 5)
    Me.picGeral.Name = "picGeral"
    Me.picGeral.Size = New System.Drawing.Size(806, 219)
    Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picGeral.TabIndex = 0
    Me.picGeral.TabStop = False
    '
    'cmdImprimir
    '
    Me.cmdImprimir.AutoSize = True
    Me.cmdImprimir.Location = New System.Drawing.Point(702, 152)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
    Me.cmdImprimir.TabIndex = 2
    '
    'cmdFechar
    '
    Me.cmdFechar.AutoSize = True
    Me.cmdFechar.Location = New System.Drawing.Point(702, 184)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
    Me.cmdFechar.TabIndex = 3
    '
    'optMedico
    '
    Me.optMedico.AutoSize = True
    Me.optMedico.Checked = True
    Me.optMedico.Location = New System.Drawing.Point(565, 102)
    Me.optMedico.Name = "optMedico"
    Me.optMedico.Size = New System.Drawing.Size(14, 13)
    Me.optMedico.TabIndex = 4
    Me.optMedico.TabStop = True
    Me.optMedico.UseVisualStyleBackColor = True
    '
    'optComparecimento
    '
    Me.optComparecimento.AutoSize = True
    Me.optComparecimento.Location = New System.Drawing.Point(645, 102)
    Me.optComparecimento.Name = "optComparecimento"
    Me.optComparecimento.Size = New System.Drawing.Size(14, 13)
    Me.optComparecimento.TabIndex = 5
    Me.optComparecimento.UseVisualStyleBackColor = True
    '
    'optAcompanhamento
    '
    Me.optAcompanhamento.AutoSize = True
    Me.optAcompanhamento.Location = New System.Drawing.Point(745, 102)
    Me.optAcompanhamento.Name = "optAcompanhamento"
    Me.optAcompanhamento.Size = New System.Drawing.Size(14, 13)
    Me.optAcompanhamento.TabIndex = 6
    Me.optAcompanhamento.UseVisualStyleBackColor = True
    '
    'txtDataAtestado
    '
    Me.txtDataAtestado.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
    Me.txtDataAtestado.Location = New System.Drawing.Point(424, 40)
    Me.txtDataAtestado.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.IncludePromptChars
    Me.txtDataAtestado.Name = "txtDataAtestado"
    Me.txtDataAtestado.Size = New System.Drawing.Size(89, 17)
    Me.txtDataAtestado.TabIndex = 162
    '
    'txtDiasRepouso
    '
    Me.txtDiasRepouso.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
    Me.txtDiasRepouso.Location = New System.Drawing.Point(35, 87)
    Me.txtDiasRepouso.MaskInput = "nnn"
    Me.txtDiasRepouso.Name = "txtDiasRepouso"
    Me.txtDiasRepouso.Nullable = True
    Me.txtDiasRepouso.Size = New System.Drawing.Size(50, 17)
    Me.txtDiasRepouso.TabIndex = 163
    Me.txtDiasRepouso.Value = Nothing
    '
    'txtCID
    '
    Me.txtCID.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtCID.Location = New System.Drawing.Point(140, 89)
    Me.txtCID.Name = "txtCID"
    Me.txtCID.Size = New System.Drawing.Size(50, 13)
    Me.txtCID.TabIndex = 164
    '
    'txtAcompanhamente
    '
    Me.txtAcompanhamente.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtAcompanhamente.Location = New System.Drawing.Point(203, 89)
    Me.txtAcompanhamente.Name = "txtAcompanhamente"
    Me.txtAcompanhamente.Size = New System.Drawing.Size(318, 13)
    Me.txtAcompanhamente.TabIndex = 165
    '
    'cboCidBuscar
    '
    Me.cboCidBuscar.FormattingEnabled = True
    Me.cboCidBuscar.Location = New System.Drawing.Point(30, 174)
    Me.cboCidBuscar.Name = "cboCidBuscar"
    Me.cboCidBuscar.Size = New System.Drawing.Size(355, 21)
    Me.cboCidBuscar.TabIndex = 166
    '
    'txtCidBuscar
    '
    Me.txtCidBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.txtCidBuscar.Location = New System.Drawing.Point(391, 178)
    Me.txtCidBuscar.Name = "txtCidBuscar"
    Me.txtCidBuscar.ReadOnly = True
    Me.txtCidBuscar.Size = New System.Drawing.Size(72, 13)
    Me.txtCidBuscar.TabIndex = 167
    '
    'cmdCidSelecionar
    '
    Me.cmdCidSelecionar.Location = New System.Drawing.Point(485, 173)
    Me.cmdCidSelecionar.Name = "cmdCidSelecionar"
    Me.cmdCidSelecionar.Size = New System.Drawing.Size(23, 23)
    Me.cmdCidSelecionar.TabIndex = 168
    Me.cmdCidSelecionar.Text = "S"
    Me.cmdCidSelecionar.UseVisualStyleBackColor = True
    '
    'lblProntuario
    '
    Me.lblProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProntuario.Location = New System.Drawing.Point(330, 38)
    Me.lblProntuario.Name = "lblProntuario"
    Me.lblProntuario.Size = New System.Drawing.Size(81, 20)
    Me.lblProntuario.TabIndex = 173
    Me.lblProntuario.Text = "lblProntuario"
    Me.lblProntuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'pnlAcompanhante
    '
    Me.pnlAcompanhante.BackColor = System.Drawing.Color.White
    Me.pnlAcompanhante.Location = New System.Drawing.Point(199, 66)
    Me.pnlAcompanhante.Name = "pnlAcompanhante"
    Me.pnlAcompanhante.Size = New System.Drawing.Size(341, 46)
    Me.pnlAcompanhante.TabIndex = 174
    '
    'lblPessoa
    '
    Me.lblPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPessoa.Location = New System.Drawing.Point(30, 38)
    Me.lblPessoa.Name = "lblPessoa"
    Me.lblPessoa.Size = New System.Drawing.Size(294, 20)
    Me.lblPessoa.TabIndex = 175
    Me.lblPessoa.Text = "lblPessoa"
    Me.lblPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'chkImprimir
    '
    Me.chkImprimir.AutoSize = True
    Me.chkImprimir.Checked = True
    Me.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkImprimir.Location = New System.Drawing.Point(685, 156)
    Me.chkImprimir.Name = "chkImprimir"
    Me.chkImprimir.Size = New System.Drawing.Size(15, 14)
    Me.chkImprimir.TabIndex = 176
    Me.chkImprimir.UseVisualStyleBackColor = True
    '
    'frmCadastroAtestado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(818, 229)
    Me.ControlBox = False
    Me.Controls.Add(Me.chkImprimir)
    Me.Controls.Add(Me.pnlAcompanhante)
    Me.Controls.Add(Me.lblPessoa)
    Me.Controls.Add(Me.lblProntuario)
    Me.Controls.Add(Me.cmdCidSelecionar)
    Me.Controls.Add(Me.txtCidBuscar)
    Me.Controls.Add(Me.cboCidBuscar)
    Me.Controls.Add(Me.txtAcompanhamente)
    Me.Controls.Add(Me.txtCID)
    Me.Controls.Add(Me.txtDiasRepouso)
    Me.Controls.Add(Me.txtDataAtestado)
    Me.Controls.Add(Me.optAcompanhamento)
    Me.Controls.Add(Me.optComparecimento)
    Me.Controls.Add(Me.optMedico)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.cmdSalvar)
    Me.Controls.Add(Me.picGeral)
    Me.MaximizeBox = False
    Me.Name = "frmCadastroAtestado"
    Me.Text = "Cadastro de Atestado"
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataAtestado, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDiasRepouso, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picGeral As PictureBox
    Friend WithEvents cmdSalvar As uscBotao
    Friend WithEvents cmdImprimir As uscBotao
    Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents optMedico As RadioButton
    Friend WithEvents optComparecimento As RadioButton
    Friend WithEvents optAcompanhamento As RadioButton
    Friend WithEvents txtDataAtestado As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtDiasRepouso As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents txtCID As TextBox
    Friend WithEvents txtAcompanhamente As TextBox
    Friend WithEvents cboCidBuscar As ComboBox
    Friend WithEvents txtCidBuscar As TextBox
    Friend WithEvents cmdCidSelecionar As Button
    Friend WithEvents lblProntuario As Label
    Friend WithEvents pnlAcompanhante As Panel
    Friend WithEvents lblPessoa As Label
  Friend WithEvents chkImprimir As CheckBox
End Class
