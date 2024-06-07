<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroAtendimentoOftalmologico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoOftalmologico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.numParaLongeOeEixo = New System.Windows.Forms.NumericUpDown()
        Me.numParaLongeOeCilindrico = New System.Windows.Forms.NumericUpDown()
        Me.numParaLongeOeEsferico = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.numParaLongeOdEixo = New System.Windows.Forms.NumericUpDown()
        Me.numParaLongeOdCilindrico = New System.Windows.Forms.NumericUpDown()
        Me.numParaLongeOdEsferico = New System.Windows.Forms.NumericUpDown()
        Me.numParaPertoAOEsferico = New System.Windows.Forms.NumericUpDown()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkImprimir = New System.Windows.Forms.CheckBox()
        Me.cmdFechar = New Cli28Julho.uscBotao()
        Me.cmdImprimir = New Cli28Julho.uscBotao()
        Me.cmdSalvar = New Cli28Julho.uscBotao()
        Me.lblPessoa = New System.Windows.Forms.Label()
        Me.lblProntuario = New System.Windows.Forms.Label()
        Me.txtDataReceituario = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtValidade = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtbObservacao = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.numParaLongeOeEixo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numParaLongeOeCilindrico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numParaLongeOeEsferico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.numParaLongeOdEixo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numParaLongeOdCilindrico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numParaLongeOdEsferico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numParaPertoAOEsferico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtDataReceituario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(382, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Esférico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(540, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cilíndrico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(739, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Eixo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Para Longe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 38)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Para Perto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 38)
        Me.Label6.TabIndex = 5
        Me.Label6.Tag = ""
        Me.Label6.Text = "O.D."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(286, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 38)
        Me.Label7.TabIndex = 6
        Me.Label7.Tag = ""
        Me.Label7.Text = "O.E."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(285, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 38)
        Me.Label8.TabIndex = 7
        Me.Label8.Tag = ""
        Me.Label8.Text = "A.O."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.numParaPertoAOEsferico)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(55, 180)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 271)
        Me.Panel1.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.numParaLongeOeEixo)
        Me.Panel4.Controls.Add(Me.numParaLongeOeCilindrico)
        Me.Panel4.Controls.Add(Me.numParaLongeOeEsferico)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(0, 141)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(872, 60)
        Me.Panel4.TabIndex = 17
        '
        'numParaLongeOeEixo
        '
        Me.numParaLongeOeEixo.DecimalPlaces = 2
        Me.numParaLongeOeEixo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numParaLongeOeEixo.Location = New System.Drawing.Point(719, 13)
        Me.numParaLongeOeEixo.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numParaLongeOeEixo.Name = "numParaLongeOeEixo"
        Me.numParaLongeOeEixo.Size = New System.Drawing.Size(120, 39)
        Me.numParaLongeOeEixo.TabIndex = 5
        '
        'numParaLongeOeCilindrico
        '
        Me.numParaLongeOeCilindrico.DecimalPlaces = 2
        Me.numParaLongeOeCilindrico.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numParaLongeOeCilindrico.Location = New System.Drawing.Point(558, 13)
        Me.numParaLongeOeCilindrico.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numParaLongeOeCilindrico.Name = "numParaLongeOeCilindrico"
        Me.numParaLongeOeCilindrico.Size = New System.Drawing.Size(120, 39)
        Me.numParaLongeOeCilindrico.TabIndex = 4
        '
        'numParaLongeOeEsferico
        '
        Me.numParaLongeOeEsferico.DecimalPlaces = 2
        Me.numParaLongeOeEsferico.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numParaLongeOeEsferico.Location = New System.Drawing.Point(391, 13)
        Me.numParaLongeOeEsferico.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numParaLongeOeEsferico.Name = "numParaLongeOeEsferico"
        Me.numParaLongeOeEsferico.Size = New System.Drawing.Size(120, 39)
        Me.numParaLongeOeEsferico.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.numParaLongeOdEixo)
        Me.Panel3.Controls.Add(Me.numParaLongeOdCilindrico)
        Me.Panel3.Controls.Add(Me.numParaLongeOdEsferico)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(872, 79)
        Me.Panel3.TabIndex = 16
        '
        'numParaLongeOdEixo
        '
        Me.numParaLongeOdEixo.DecimalPlaces = 2
        Me.numParaLongeOdEixo.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numParaLongeOdEixo.Location = New System.Drawing.Point(719, 25)
        Me.numParaLongeOdEixo.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numParaLongeOdEixo.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
        Me.numParaLongeOdEixo.Name = "numParaLongeOdEixo"
        Me.numParaLongeOdEixo.Size = New System.Drawing.Size(120, 39)
        Me.numParaLongeOdEixo.TabIndex = 2
        '
        'numParaLongeOdCilindrico
        '
        Me.numParaLongeOdCilindrico.DecimalPlaces = 2
        Me.numParaLongeOdCilindrico.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numParaLongeOdCilindrico.Location = New System.Drawing.Point(558, 25)
        Me.numParaLongeOdCilindrico.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numParaLongeOdCilindrico.Name = "numParaLongeOdCilindrico"
        Me.numParaLongeOdCilindrico.Size = New System.Drawing.Size(120, 39)
        Me.numParaLongeOdCilindrico.TabIndex = 1
        '
        'numParaLongeOdEsferico
        '
        Me.numParaLongeOdEsferico.DecimalPlaces = 2
        Me.numParaLongeOdEsferico.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numParaLongeOdEsferico.Location = New System.Drawing.Point(391, 25)
        Me.numParaLongeOdEsferico.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numParaLongeOdEsferico.Name = "numParaLongeOdEsferico"
        Me.numParaLongeOdEsferico.Size = New System.Drawing.Size(120, 39)
        Me.numParaLongeOdEsferico.TabIndex = 0
        '
        'numParaPertoAOEsferico
        '
        Me.numParaPertoAOEsferico.DecimalPlaces = 2
        Me.numParaPertoAOEsferico.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numParaPertoAOEsferico.Location = New System.Drawing.Point(392, 213)
        Me.numParaPertoAOEsferico.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numParaPertoAOEsferico.Name = "numParaPertoAOEsferico"
        Me.numParaPertoAOEsferico.Size = New System.Drawing.Size(120, 39)
        Me.numParaPertoAOEsferico.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 65)
        Me.Panel2.TabIndex = 8
        '
        'chkImprimir
        '
        Me.chkImprimir.AutoSize = True
        Me.chkImprimir.Checked = True
        Me.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkImprimir.Location = New System.Drawing.Point(761, 122)
        Me.chkImprimir.Name = "chkImprimir"
        Me.chkImprimir.Size = New System.Drawing.Size(15, 14)
        Me.chkImprimir.TabIndex = 182
        Me.chkImprimir.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(779, 146)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 181
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AutoSize = True
        Me.cmdImprimir.Location = New System.Drawing.Point(779, 118)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
        Me.cmdImprimir.TabIndex = 180
        '
        'cmdSalvar
        '
        Me.cmdSalvar.AutoSize = True
        Me.cmdSalvar.Location = New System.Drawing.Point(779, 90)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(16, 17)
        Me.cmdSalvar.TabIndex = 179
        '
        'lblPessoa
        '
        Me.lblPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPessoa.Location = New System.Drawing.Point(37, 48)
        Me.lblPessoa.Name = "lblPessoa"
        Me.lblPessoa.Size = New System.Drawing.Size(393, 20)
        Me.lblPessoa.TabIndex = 185
        Me.lblPessoa.Text = "lblPessoa"
        Me.lblPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProntuario
        '
        Me.lblProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProntuario.Location = New System.Drawing.Point(445, 48)
        Me.lblProntuario.Name = "lblProntuario"
        Me.lblProntuario.Size = New System.Drawing.Size(97, 20)
        Me.lblProntuario.TabIndex = 184
        Me.lblProntuario.Text = "lblProntuario"
        Me.lblProntuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDataReceituario
        '
        Me.txtDataReceituario.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtDataReceituario.Location = New System.Drawing.Point(555, 50)
        Me.txtDataReceituario.Name = "txtDataReceituario"
        Me.txtDataReceituario.Size = New System.Drawing.Size(89, 17)
        Me.txtDataReceituario.TabIndex = 183
        '
        'txtValidade
        '
        Me.txtValidade.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txtValidade.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold)
        Me.txtValidade.Location = New System.Drawing.Point(206, 126)
        Me.txtValidade.Name = "txtValidade"
        Me.txtValidade.Size = New System.Drawing.Size(171, 37)
        Me.txtValidade.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 38)
        Me.Label9.TabIndex = 187
        Me.Label9.Text = "Validade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(55, 454)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 23)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Observação"
        '
        'rtbObservacao
        '
        Me.rtbObservacao.Location = New System.Drawing.Point(55, 481)
        Me.rtbObservacao.Name = "rtbObservacao"
        Me.rtbObservacao.Size = New System.Drawing.Size(872, 141)
        Me.rtbObservacao.TabIndex = 100
        Me.rtbObservacao.Text = ""
        '
        'frmCadastroAtendimentoOftalmologico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(995, 634)
        Me.Controls.Add(Me.rtbObservacao)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtValidade)
        Me.Controls.Add(Me.lblPessoa)
        Me.Controls.Add(Me.lblProntuario)
        Me.Controls.Add(Me.txtDataReceituario)
        Me.Controls.Add(Me.chkImprimir)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroAtendimentoOftalmologico"
        Me.Text = "frmCadastroAtendimentoOftalmologico"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.numParaLongeOeEixo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numParaLongeOeCilindrico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numParaLongeOeEsferico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.numParaLongeOdEixo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numParaLongeOdCilindrico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numParaLongeOdEsferico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numParaPertoAOEsferico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtDataReceituario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents numParaPertoAOEsferico As NumericUpDown
    Friend WithEvents numParaLongeOeEixo As NumericUpDown
    Friend WithEvents numParaLongeOeCilindrico As NumericUpDown
    Friend WithEvents numParaLongeOeEsferico As NumericUpDown
    Friend WithEvents numParaLongeOdEixo As NumericUpDown
    Friend WithEvents numParaLongeOdCilindrico As NumericUpDown
    Friend WithEvents numParaLongeOdEsferico As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents chkImprimir As CheckBox
    Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents cmdImprimir As uscBotao
    Friend WithEvents cmdSalvar As uscBotao
    Friend WithEvents lblPessoa As Label
    Friend WithEvents lblProntuario As Label
    Friend WithEvents txtDataReceituario As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtValidade As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents rtbObservacao As RichTextBox
End Class
