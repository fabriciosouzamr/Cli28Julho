<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoReceituario
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoReceituario))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.txtDataReceituario = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.rtbDescricao = New System.Windows.Forms.RichTextBox()
    Me.cmdAnterior = New System.Windows.Forms.Button()
    Me.cmdProximo = New System.Windows.Forms.Button()
    Me.cmdNovo = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.cmdImprimir = New Cli28Julho.uscBotao()
    Me.cmdSalvar = New Cli28Julho.uscBotao()
    Me.lblProntuario = New System.Windows.Forms.Label()
    Me.lblPessoa = New System.Windows.Forms.Label()
    Me.chkImprimir = New System.Windows.Forms.CheckBox()
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataReceituario, System.ComponentModel.ISupportInitialize).BeginInit()
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
    'txtDataReceituario
    '
    Me.txtDataReceituario.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
    Me.txtDataReceituario.Location = New System.Drawing.Point(560, 54)
    Me.txtDataReceituario.Name = "txtDataReceituario"
    Me.txtDataReceituario.Size = New System.Drawing.Size(89, 17)
    Me.txtDataReceituario.TabIndex = 162
    '
    'rtbDescricao
    '
    Me.rtbDescricao.BackColor = System.Drawing.SystemColors.Window
    Me.rtbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.rtbDescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
    Me.rtbDescricao.Location = New System.Drawing.Point(43, 128)
    Me.rtbDescricao.Name = "rtbDescricao"
    Me.rtbDescricao.Size = New System.Drawing.Size(600, 449)
    Me.rtbDescricao.TabIndex = 164
    Me.rtbDescricao.Text = ""
    '
    'cmdAnterior
    '
    Me.cmdAnterior.Location = New System.Drawing.Point(689, 223)
    Me.cmdAnterior.Name = "cmdAnterior"
    Me.cmdAnterior.Size = New System.Drawing.Size(30, 23)
    Me.cmdAnterior.TabIndex = 169
    Me.cmdAnterior.Text = "<<"
    Me.cmdAnterior.UseVisualStyleBackColor = True
    '
    'cmdProximo
    '
    Me.cmdProximo.Location = New System.Drawing.Point(725, 223)
    Me.cmdProximo.Name = "cmdProximo"
    Me.cmdProximo.Size = New System.Drawing.Size(30, 23)
    Me.cmdProximo.TabIndex = 168
    Me.cmdProximo.Text = ">>"
    Me.cmdProximo.UseVisualStyleBackColor = True
    '
    'cmdNovo
    '
    Me.cmdNovo.AutoSize = True
    Me.cmdNovo.Location = New System.Drawing.Point(801, 110)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(16, 17)
    Me.cmdNovo.TabIndex = 165
    '
    'cmdFechar
    '
    Me.cmdFechar.AutoSize = True
    Me.cmdFechar.Location = New System.Drawing.Point(696, 182)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
    Me.cmdFechar.TabIndex = 3
    '
    'cmdImprimir
    '
    Me.cmdImprimir.AutoSize = True
    Me.cmdImprimir.Location = New System.Drawing.Point(696, 145)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
    Me.cmdImprimir.TabIndex = 2
    '
    'cmdSalvar
    '
    Me.cmdSalvar.AutoSize = True
    Me.cmdSalvar.Location = New System.Drawing.Point(696, 110)
    Me.cmdSalvar.Name = "cmdSalvar"
    Me.cmdSalvar.Size = New System.Drawing.Size(16, 17)
    Me.cmdSalvar.TabIndex = 1
    '
    'lblProntuario
    '
    Me.lblProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProntuario.Location = New System.Drawing.Point(450, 52)
    Me.lblProntuario.Name = "lblProntuario"
    Me.lblProntuario.Size = New System.Drawing.Size(97, 20)
    Me.lblProntuario.TabIndex = 170
    Me.lblProntuario.Text = "lblProntuario"
    Me.lblProntuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblPessoa
    '
    Me.lblPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPessoa.Location = New System.Drawing.Point(42, 52)
    Me.lblPessoa.Name = "lblPessoa"
    Me.lblPessoa.Size = New System.Drawing.Size(393, 20)
    Me.lblPessoa.TabIndex = 176
    Me.lblPessoa.Text = "lblPessoa"
    Me.lblPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'chkImprimir
    '
    Me.chkImprimir.AutoSize = True
    Me.chkImprimir.Checked = True
    Me.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkImprimir.Location = New System.Drawing.Point(676, 149)
    Me.chkImprimir.Name = "chkImprimir"
    Me.chkImprimir.Size = New System.Drawing.Size(15, 14)
    Me.chkImprimir.TabIndex = 177
    Me.chkImprimir.UseVisualStyleBackColor = True
    '
    'frmCadastroAtendimentoReceituario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1004, 642)
    Me.ControlBox = False
    Me.Controls.Add(Me.chkImprimir)
    Me.Controls.Add(Me.lblPessoa)
    Me.Controls.Add(Me.lblProntuario)
    Me.Controls.Add(Me.cmdNovo)
    Me.Controls.Add(Me.cmdAnterior)
    Me.Controls.Add(Me.cmdProximo)
    Me.Controls.Add(Me.rtbDescricao)
    Me.Controls.Add(Me.txtDataReceituario)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.cmdSalvar)
    Me.Controls.Add(Me.picGeral)
    Me.MaximizeBox = False
    Me.Name = "frmCadastroAtendimentoReceituario"
    Me.Text = "Cadastro de Atendimento - Receituário"
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataReceituario, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdSalvar As uscBotao
  Friend WithEvents cmdImprimir As uscBotao
  Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents txtDataReceituario As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents rtbDescricao As RichTextBox
    Friend WithEvents cmdNovo As uscBotao
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdProximo As Button
    Friend WithEvents lblProntuario As Label
    Friend WithEvents lblPessoa As Label
  Friend WithEvents chkImprimir As CheckBox
End Class
