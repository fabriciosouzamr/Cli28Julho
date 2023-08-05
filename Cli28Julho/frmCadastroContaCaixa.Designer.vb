<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroContaCaixa
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtNomeContaCaixa = New System.Windows.Forms.TextBox()
    Me.cboDepartamento = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboFuncionarioSupervisorContaCaixa = New System.Windows.Forms.ComboBox()
    Me.chkControlaSaldo = New System.Windows.Forms.CheckBox()
    Me.chkAtivo = New System.Windows.Forms.CheckBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtPercentualDescontoMaximo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.lstFuncionariosUtilizamConta = New System.Windows.Forms.CheckedListBox()
        Me.txtLocalizacao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.txtPercentualDescontoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome da Conta de Caixa"
        '
        'txtNomeContaCaixa
        '
        Me.txtNomeContaCaixa.Location = New System.Drawing.Point(5, 20)
        Me.txtNomeContaCaixa.MaxLength = 100
        Me.txtNomeContaCaixa.Name = "txtNomeContaCaixa"
        Me.txtNomeContaCaixa.Size = New System.Drawing.Size(500, 20)
        Me.txtNomeContaCaixa.TabIndex = 1
        '
        'cboDepartamento
        '
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Location = New System.Drawing.Point(5, 61)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(500, 21)
        Me.cboDepartamento.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Funcionário Supervisor da Conta de Caixa"
        '
        'cboFuncionarioSupervisorContaCaixa
        '
        Me.cboFuncionarioSupervisorContaCaixa.FormattingEnabled = True
        Me.cboFuncionarioSupervisorContaCaixa.Location = New System.Drawing.Point(5, 103)
        Me.cboFuncionarioSupervisorContaCaixa.Name = "cboFuncionarioSupervisorContaCaixa"
        Me.cboFuncionarioSupervisorContaCaixa.Size = New System.Drawing.Size(500, 21)
        Me.cboFuncionarioSupervisorContaCaixa.TabIndex = 4
        '
        'chkControlaSaldo
        '
        Me.chkControlaSaldo.AutoSize = True
        Me.chkControlaSaldo.Location = New System.Drawing.Point(5, 171)
        Me.chkControlaSaldo.Name = "chkControlaSaldo"
        Me.chkControlaSaldo.Size = New System.Drawing.Size(95, 17)
        Me.chkControlaSaldo.TabIndex = 6
        Me.chkControlaSaldo.Text = "Controla Saldo"
        Me.chkControlaSaldo.UseVisualStyleBackColor = True
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(5, 190)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 7
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Desconto Máximo"
        '
        'txtPercentualDescontoMaximo
        '
        Me.txtPercentualDescontoMaximo.FormatString = ""
        Me.txtPercentualDescontoMaximo.Location = New System.Drawing.Point(260, 188)
        Me.txtPercentualDescontoMaximo.MaskInput = "{double:3.2}"
        Me.txtPercentualDescontoMaximo.Name = "txtPercentualDescontoMaximo"
        Me.txtPercentualDescontoMaximo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtPercentualDescontoMaximo.Size = New System.Drawing.Size(45, 21)
        Me.txtPercentualDescontoMaximo.TabIndex = 207
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 13)
        Me.Label5.TabIndex = 209
        Me.Label5.Text = "Funcionários que utilizam essa conta"
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(655, 219)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 210
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(736, 219)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 211
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'lstFuncionariosUtilizamConta
        '
        Me.lstFuncionariosUtilizamConta.FormattingEnabled = True
        Me.lstFuncionariosUtilizamConta.Location = New System.Drawing.Point(511, 20)
        Me.lstFuncionariosUtilizamConta.Name = "lstFuncionariosUtilizamConta"
        Me.lstFuncionariosUtilizamConta.Size = New System.Drawing.Size(300, 139)
        Me.lstFuncionariosUtilizamConta.TabIndex = 212
        '
        'txtLocalizacao
        '
        Me.txtLocalizacao.Location = New System.Drawing.Point(5, 145)
        Me.txtLocalizacao.MaxLength = 100
        Me.txtLocalizacao.Name = "txtLocalizacao"
        Me.txtLocalizacao.Size = New System.Drawing.Size(500, 20)
        Me.txtLocalizacao.TabIndex = 215
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "Localização"
        '
        'frmCadastroContaCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 253)
        Me.Controls.Add(Me.txtLocalizacao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstFuncionariosUtilizamConta)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPercentualDescontoMaximo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.chkControlaSaldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboFuncionarioSupervisorContaCaixa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.txtNomeContaCaixa)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroContaCaixa"
        Me.Text = "Cadastro de Conta Caixa"
        CType(Me.txtPercentualDescontoMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
  Friend WithEvents txtNomeContaCaixa As TextBox
  Friend WithEvents cboDepartamento As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents cboFuncionarioSupervisorContaCaixa As ComboBox
  Friend WithEvents chkControlaSaldo As CheckBox
  Friend WithEvents chkAtivo As CheckBox
  Friend WithEvents Label4 As Label
  Friend WithEvents txtPercentualDescontoMaximo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label5 As Label
  Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents lstFuncionariosUtilizamConta As CheckedListBox
    Friend WithEvents txtLocalizacao As TextBox
    Friend WithEvents Label6 As Label
End Class
