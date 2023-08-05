<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroDocumentoFinanceiro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
    Me.cboStatus = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboBanco = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtDescricaoDocumento = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtDataEmissao = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataVencimento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtValorDocumento = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.txtSaldoDisponivel = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtCodigoDocumento = New System.Windows.Forms.TextBox()
    Me.txtNrAgencia = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.txtNrConta = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.txtNrContaDigito = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.psqEmitente = New uscPesqPessoa()
    CType(Me.txtDataEmissao, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataVencimento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtValorDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtSaldoDisponivel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNrAgencia, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNrConta, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNrContaDigito, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(249, 301)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 100
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(330, 301)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(101, 13)
    Me.Label1.TabIndex = 28
    Me.Label1.Text = "Tipo de Documento"
    '
    'cboTipoDocumento
    '
    Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDocumento.FormattingEnabled = True
    Me.cboTipoDocumento.Location = New System.Drawing.Point(5, 20)
    Me.cboTipoDocumento.Name = "cboTipoDocumento"
    Me.cboTipoDocumento.Size = New System.Drawing.Size(400, 21)
    Me.cboTipoDocumento.TabIndex = 1
    '
    'cboStatus
    '
    Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboStatus.FormattingEnabled = True
    Me.cboStatus.Location = New System.Drawing.Point(194, 270)
    Me.cboStatus.Name = "cboStatus"
    Me.cboStatus.Size = New System.Drawing.Size(211, 21)
    Me.cboStatus.TabIndex = 13
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(194, 255)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(37, 13)
    Me.Label2.TabIndex = 31
    Me.Label2.Text = "Status"
    '
    'cboBanco
    '
    Me.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboBanco.FormattingEnabled = True
    Me.cboBanco.Location = New System.Drawing.Point(5, 228)
    Me.cboBanco.Name = "cboBanco"
    Me.cboBanco.Size = New System.Drawing.Size(400, 21)
    Me.cboBanco.TabIndex = 9
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 213)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(38, 13)
    Me.Label4.TabIndex = 34
    Me.Label4.Text = "Banco"
    '
    'txtDescricaoDocumento
    '
    Me.txtDescricaoDocumento.Location = New System.Drawing.Point(5, 145)
    Me.txtDescricaoDocumento.MaxLength = 255
    Me.txtDescricaoDocumento.Name = "txtDescricaoDocumento"
    Me.txtDescricaoDocumento.Size = New System.Drawing.Size(400, 20)
    Me.txtDescricaoDocumento.TabIndex = 4
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(5, 130)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(128, 13)
    Me.Label5.TabIndex = 37
    Me.Label5.Text = "Descrição do Documento"
    '
    'txtDataEmissao
    '
    Me.txtDataEmissao.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataEmissao.Location = New System.Drawing.Point(5, 186)
    Me.txtDataEmissao.Name = "txtDataEmissao"
    Me.txtDataEmissao.Size = New System.Drawing.Size(85, 21)
    Me.txtDataEmissao.TabIndex = 5
    Me.txtDataEmissao.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDataVencimento
    '
    Me.txtDataVencimento.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataVencimento.Location = New System.Drawing.Point(96, 186)
    Me.txtDataVencimento.Name = "txtDataVencimento"
    Me.txtDataVencimento.Size = New System.Drawing.Size(85, 21)
    Me.txtDataVencimento.TabIndex = 6
    Me.txtDataVencimento.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtValorDocumento
    '
    Me.txtValorDocumento.Location = New System.Drawing.Point(187, 186)
    Me.txtValorDocumento.MaskInput = "{currency:6.3}"
    Me.txtValorDocumento.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
    Me.txtValorDocumento.Name = "txtValorDocumento"
    Me.txtValorDocumento.Size = New System.Drawing.Size(104, 21)
    Me.txtValorDocumento.TabIndex = 7
    Me.txtValorDocumento.UseWaitCursor = True
    '
    'txtSaldoDisponivel
    '
    Me.txtSaldoDisponivel.Location = New System.Drawing.Point(297, 186)
    Me.txtSaldoDisponivel.MaskInput = "{currency:6.3}"
    Me.txtSaldoDisponivel.Name = "txtSaldoDisponivel"
    Me.txtSaldoDisponivel.ReadOnly = True
    Me.txtSaldoDisponivel.Size = New System.Drawing.Size(93, 21)
    Me.txtSaldoDisponivel.TabIndex = 8
    Me.txtSaldoDisponivel.UseWaitCursor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(5, 171)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(87, 13)
    Me.Label6.TabIndex = 205
    Me.Label6.Text = "Data de Emissão"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(96, 171)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(63, 13)
    Me.Label7.TabIndex = 206
    Me.Label7.Text = "Vencimento"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(187, 171)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(104, 13)
    Me.Label8.TabIndex = 207
    Me.Label8.Text = "Valor do Documento"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(297, 171)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(88, 13)
    Me.Label9.TabIndex = 208
    Me.Label9.Text = "Saldo Disponível"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(5, 89)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(113, 13)
    Me.Label10.TabIndex = 210
    Me.Label10.Text = "Código do Documento"
    '
    'txtCodigoDocumento
    '
    Me.txtCodigoDocumento.Location = New System.Drawing.Point(5, 104)
    Me.txtCodigoDocumento.MaxLength = 600
    Me.txtCodigoDocumento.Name = "txtCodigoDocumento"
    Me.txtCodigoDocumento.Size = New System.Drawing.Size(400, 20)
    Me.txtCodigoDocumento.TabIndex = 3
    '
    'txtNrAgencia
    '
    Me.txtNrAgencia.ImageTransparentColor = System.Drawing.Color.Turquoise
    Me.txtNrAgencia.ImeMode = System.Windows.Forms.ImeMode.Off
    Me.txtNrAgencia.Location = New System.Drawing.Point(5, 270)
    Me.txtNrAgencia.MaskInput = "nnnnnn"
    Me.txtNrAgencia.MinValue = 0
    Me.txtNrAgencia.Name = "txtNrAgencia"
    Me.txtNrAgencia.Size = New System.Drawing.Size(60, 21)
    Me.txtNrAgencia.TabIndex = 10
    '
    'txtNrConta
    '
    Me.txtNrConta.ImageTransparentColor = System.Drawing.Color.Turquoise
    Me.txtNrConta.ImeMode = System.Windows.Forms.ImeMode.Off
    Me.txtNrConta.Location = New System.Drawing.Point(71, 270)
    Me.txtNrConta.MaskInput = "nnnnnnnnn"
    Me.txtNrConta.MinValue = 0
    Me.txtNrConta.Name = "txtNrConta"
    Me.txtNrConta.Size = New System.Drawing.Size(77, 21)
    Me.txtNrConta.TabIndex = 11
    '
    'txtNrContaDigito
    '
    Me.txtNrContaDigito.ImageTransparentColor = System.Drawing.Color.Turquoise
    Me.txtNrContaDigito.ImeMode = System.Windows.Forms.ImeMode.Off
    Me.txtNrContaDigito.Location = New System.Drawing.Point(154, 270)
    Me.txtNrContaDigito.MaskInput = "nn"
    Me.txtNrContaDigito.MinValue = 0
    Me.txtNrContaDigito.Name = "txtNrContaDigito"
    Me.txtNrContaDigito.Size = New System.Drawing.Size(30, 21)
    Me.txtNrContaDigito.TabIndex = 12
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(5, 255)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(46, 13)
    Me.Label11.TabIndex = 217
    Me.Label11.Text = "Agência"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(71, 255)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(35, 13)
    Me.Label12.TabIndex = 218
    Me.Label12.Text = "Conta"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(154, 255)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(34, 13)
    Me.Label13.TabIndex = 219
    Me.Label13.Text = "Digito"
    '
    'psqEmitente
    '
    Me.psqEmitente.AdicionarPessoa = False
    Me.psqEmitente.CarregarTodos = False
    Me.psqEmitente.DS_Pessoa = ""
    Me.psqEmitente.ID_Pessoa = 0
    Me.psqEmitente.Location = New System.Drawing.Point(5, 47)
    Me.psqEmitente.Name = "psqEmitente"
    Me.psqEmitente.Rotulo = "Pessoa"
    Me.psqEmitente.Size = New System.Drawing.Size(400, 36)
    Me.psqEmitente.TabIndex = 2
    Me.psqEmitente.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Pessoa
    '
    'frmCadastroDocumentoFinanceiro
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdFechar
    Me.ClientSize = New System.Drawing.Size(410, 333)
    Me.Controls.Add(Me.psqEmitente)
    Me.Controls.Add(Me.Label13)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.txtNrContaDigito)
    Me.Controls.Add(Me.txtNrConta)
    Me.Controls.Add(Me.txtNrAgencia)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.txtCodigoDocumento)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.txtSaldoDisponivel)
    Me.Controls.Add(Me.txtValorDocumento)
    Me.Controls.Add(Me.txtDataVencimento)
    Me.Controls.Add(Me.txtDataEmissao)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtDescricaoDocumento)
    Me.Controls.Add(Me.cboBanco)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboStatus)
    Me.Controls.Add(Me.cboTipoDocumento)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.MaximizeBox = False
    Me.Name = "frmCadastroDocumentoFinanceiro"
    Me.Text = "Cadastro de Documento de Financeiro"
    CType(Me.txtDataEmissao, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataVencimento, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtValorDocumento, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtSaldoDisponivel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNrAgencia, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNrConta, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNrContaDigito, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
  Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboBanco As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtDescricaoDocumento As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtDataEmissao As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataVencimento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtValorDocumento As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents txtSaldoDisponivel As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents txtCodigoDocumento As System.Windows.Forms.TextBox
  Friend WithEvents txtNrAgencia As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtNrConta As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtNrContaDigito As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents psqEmitente As uscPesqPessoa
End Class
