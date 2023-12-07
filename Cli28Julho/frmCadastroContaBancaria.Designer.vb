<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroContaBancaria
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
        Me.lstFuncionariosUtilizamConta = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumeroAgencia = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.chkControlaSaldo = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboFuncionarioSupervisorContaCaixa = New System.Windows.Forms.ComboBox()
        Me.txtNomeContaBancaria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTipoContaBancaria = New System.Windows.Forms.ComboBox()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.txtNumeroConta = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDigitoConta = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDataAbertura = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.txtNumeroAgencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroConta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDigitoConta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataAbertura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstFuncionariosUtilizamConta
        '
        Me.lstFuncionariosUtilizamConta.FormattingEnabled = True
        Me.lstFuncionariosUtilizamConta.Location = New System.Drawing.Point(511, 20)
        Me.lstFuncionariosUtilizamConta.Name = "lstFuncionariosUtilizamConta"
        Me.lstFuncionariosUtilizamConta.Size = New System.Drawing.Size(300, 139)
        Me.lstFuncionariosUtilizamConta.TabIndex = 229
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 13)
        Me.Label5.TabIndex = 226
        Me.Label5.Text = "Funcionários que utilizam essa conta"
        '
        'txtNumeroAgencia
        '
        Me.txtNumeroAgencia.FormatString = ""
        Me.txtNumeroAgencia.Location = New System.Drawing.Point(5, 145)
        Me.txtNumeroAgencia.MaskInput = "nnnnnnnnnn"
        Me.txtNumeroAgencia.Name = "txtNumeroAgencia"
        Me.txtNumeroAgencia.Size = New System.Drawing.Size(101, 21)
        Me.txtNumeroAgencia.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 224
        Me.Label4.Text = "Número da Agência"
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(410, 149)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 8
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'chkControlaSaldo
        '
        Me.chkControlaSaldo.AutoSize = True
        Me.chkControlaSaldo.Location = New System.Drawing.Point(410, 130)
        Me.chkControlaSaldo.Name = "chkControlaSaldo"
        Me.chkControlaSaldo.Size = New System.Drawing.Size(95, 17)
        Me.chkControlaSaldo.TabIndex = 7
        Me.chkControlaSaldo.Text = "Controla Saldo"
        Me.chkControlaSaldo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 13)
        Me.Label3.TabIndex = 221
        Me.Label3.Text = "Funcionário Supervisor da Conta de Caixa"
        '
        'cboFuncionarioSupervisorContaCaixa
        '
        Me.cboFuncionarioSupervisorContaCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFuncionarioSupervisorContaCaixa.FormattingEnabled = True
        Me.cboFuncionarioSupervisorContaCaixa.Location = New System.Drawing.Point(5, 103)
        Me.cboFuncionarioSupervisorContaCaixa.Name = "cboFuncionarioSupervisorContaCaixa"
        Me.cboFuncionarioSupervisorContaCaixa.Size = New System.Drawing.Size(500, 21)
        Me.cboFuncionarioSupervisorContaCaixa.TabIndex = 2
        '
        'txtNomeContaBancaria
        '
        Me.txtNomeContaBancaria.Location = New System.Drawing.Point(5, 61)
        Me.txtNomeContaBancaria.MaxLength = 100
        Me.txtNomeContaBancaria.Name = "txtNomeContaBancaria"
        Me.txtNomeContaBancaria.Size = New System.Drawing.Size(500, 20)
        Me.txtNomeContaBancaria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Nome da Conta de Bancária"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 231
        Me.Label6.Text = "Tipo de Conta Bancária"
        '
        'cboTipoContaBancaria
        '
        Me.cboTipoContaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoContaBancaria.FormattingEnabled = True
        Me.cboTipoContaBancaria.Location = New System.Drawing.Point(5, 20)
        Me.cboTipoContaBancaria.Name = "cboTipoContaBancaria"
        Me.cboTipoContaBancaria.Size = New System.Drawing.Size(500, 21)
        Me.cboTipoContaBancaria.TabIndex = 0
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(655, 169)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 227
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.AllowDrop = True
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(736, 169)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 228
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'txtNumeroConta
        '
        Me.txtNumeroConta.FormatString = ""
        Me.txtNumeroConta.Location = New System.Drawing.Point(112, 145)
        Me.txtNumeroConta.MaskInput = "nnnnnnnnnn"
        Me.txtNumeroConta.Name = "txtNumeroConta"
        Me.txtNumeroConta.Size = New System.Drawing.Size(90, 21)
        Me.txtNumeroConta.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 232
        Me.Label7.Text = "Número da Conta"
        '
        'txtDigitoConta
        '
        Me.txtDigitoConta.FormatString = ""
        Me.txtDigitoConta.Location = New System.Drawing.Point(245, 145)
        Me.txtDigitoConta.MaskInput = "nn"
        Me.txtDigitoConta.Name = "txtDigitoConta"
        Me.txtDigitoConta.Size = New System.Drawing.Size(45, 21)
        Me.txtDigitoConta.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 234
        Me.Label8.Text = "Dígito da Conta"
        '
        'txtDataAbertura
        '
        Me.txtDataAbertura.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataAbertura.Location = New System.Drawing.Point(296, 145)
        Me.txtDataAbertura.Name = "txtDataAbertura"
        Me.txtDataAbertura.Size = New System.Drawing.Size(85, 21)
        Me.txtDataAbertura.TabIndex = 6
        Me.txtDataAbertura.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "Data de Abertura"
        '
        'frmCadastroContaBancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 205)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDataAbertura)
        Me.Controls.Add(Me.txtDigitoConta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNumeroConta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTipoContaBancaria)
        Me.Controls.Add(Me.lstFuncionariosUtilizamConta)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumeroAgencia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.chkControlaSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboFuncionarioSupervisorContaCaixa)
        Me.Controls.Add(Me.txtNomeContaBancaria)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroContaBancaria"
        Me.Text = "Cadastro de Conta Bancária"
        CType(Me.txtNumeroAgencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroConta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDigitoConta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataAbertura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFuncionariosUtilizamConta As CheckedListBox
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumeroAgencia As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label4 As Label
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents chkControlaSaldo As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboFuncionarioSupervisorContaCaixa As ComboBox
    Friend WithEvents txtNomeContaBancaria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboTipoContaBancaria As ComboBox
    Friend WithEvents txtNumeroConta As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDigitoConta As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDataAbertura As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As Label
End Class
