<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroRelatorio
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroRelatorio))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.cmdSalvar = New Cli28Julho.uscBotao()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.lblMedico = New System.Windows.Forms.Label()
    Me.txtDataRelatorio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.rtbDescricao = New System.Windows.Forms.RichTextBox()
    Me.cboTipoRelatorio = New System.Windows.Forms.ComboBox()
    Me.lblProntuario = New System.Windows.Forms.Label()
    Me.chkImprimir = New System.Windows.Forms.CheckBox()
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picGeral
    '
    Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
    Me.picGeral.Location = New System.Drawing.Point(5, 5)
    Me.picGeral.Name = "picGeral"
    Me.picGeral.Size = New System.Drawing.Size(995, 634)
    Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picGeral.TabIndex = 0
    Me.picGeral.TabStop = False
    '
    'cmdSalvar
    '
    Me.cmdSalvar.AutoSize = True
    Me.cmdSalvar.Location = New System.Drawing.Point(700, 96)
    Me.cmdSalvar.Name = "cmdSalvar"
    Me.cmdSalvar.Size = New System.Drawing.Size(16, 17)
    Me.cmdSalvar.TabIndex = 1
    '
    'cmdImprimir
    '
    Me.cmdImprimir.AutoSize = True
    Me.cmdImprimir.Location = New System.Drawing.Point(700, 124)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
    Me.cmdImprimir.TabIndex = 2
    '
    'cmdFechar
    '
    Me.cmdFechar.AutoSize = True
    Me.cmdFechar.Location = New System.Drawing.Point(700, 152)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
    Me.cmdFechar.TabIndex = 3
    '
    'lblMedico
    '
    Me.lblMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMedico.Location = New System.Drawing.Point(43, 50)
    Me.lblMedico.Name = "lblMedico"
    Me.lblMedico.Size = New System.Drawing.Size(381, 24)
    Me.lblMedico.TabIndex = 4
    Me.lblMedico.Text = "lblMedico"
    '
    'txtDataRelatorio
    '
    Me.txtDataRelatorio.Location = New System.Drawing.Point(440, 112)
    Me.txtDataRelatorio.Name = "txtDataRelatorio"
    Me.txtDataRelatorio.Size = New System.Drawing.Size(89, 21)
    Me.txtDataRelatorio.TabIndex = 163
    '
    'rtbDescricao
    '
    Me.rtbDescricao.BackColor = System.Drawing.SystemColors.Window
    Me.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.rtbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
    Me.rtbDescricao.Location = New System.Drawing.Point(51, 185)
    Me.rtbDescricao.Name = "rtbDescricao"
    Me.rtbDescricao.Size = New System.Drawing.Size(580, 415)
    Me.rtbDescricao.TabIndex = 164
    Me.rtbDescricao.Text = ""
    '
    'cboTipoRelatorio
    '
    Me.cboTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoRelatorio.FormattingEnabled = True
    Me.cboTipoRelatorio.Location = New System.Drawing.Point(44, 112)
    Me.cboTipoRelatorio.Name = "cboTipoRelatorio"
    Me.cboTipoRelatorio.Size = New System.Drawing.Size(380, 21)
    Me.cboTipoRelatorio.TabIndex = 166
    '
    'lblProntuario
    '
    Me.lblProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProntuario.Location = New System.Drawing.Point(436, 52)
    Me.lblProntuario.Name = "lblProntuario"
    Me.lblProntuario.Size = New System.Drawing.Size(107, 20)
    Me.lblProntuario.TabIndex = 171
    Me.lblProntuario.Text = "lblProntuario"
    Me.lblProntuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'chkImprimir
    '
    Me.chkImprimir.AutoSize = True
    Me.chkImprimir.Checked = True
    Me.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkImprimir.Location = New System.Drawing.Point(682, 128)
    Me.chkImprimir.Name = "chkImprimir"
    Me.chkImprimir.Size = New System.Drawing.Size(15, 14)
    Me.chkImprimir.TabIndex = 178
    Me.chkImprimir.UseVisualStyleBackColor = True
    '
    'frmCadastroRelatorio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1002, 641)
    Me.ControlBox = False
    Me.Controls.Add(Me.chkImprimir)
    Me.Controls.Add(Me.lblProntuario)
    Me.Controls.Add(Me.cboTipoRelatorio)
    Me.Controls.Add(Me.rtbDescricao)
    Me.Controls.Add(Me.txtDataRelatorio)
    Me.Controls.Add(Me.lblMedico)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.cmdSalvar)
    Me.Controls.Add(Me.picGeral)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroRelatorio"
    Me.Text = "Cadastro de Relatório"
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataRelatorio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdSalvar As uscBotao
  Friend WithEvents cmdImprimir As uscBotao
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents lblMedico As Label
  Friend WithEvents txtDataRelatorio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents rtbDescricao As RichTextBox
    Friend WithEvents cboTipoRelatorio As ComboBox
    Friend WithEvents lblProntuario As Label
  Friend WithEvents chkImprimir As CheckBox
End Class
