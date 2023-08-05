<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroConvenio
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
    Me.txtNomeConvenio = New System.Windows.Forms.TextBox()
    Me.chkAtivo = New System.Windows.Forms.CheckBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtContrato = New System.Windows.Forms.TextBox()
    Me.cboTipoConvenio = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.psqAdministradora = New Cli28Julho.uscPesqPessoa()
    Me.txtDiaCorte = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.txtDiaPrevPagto = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
        Me.chkControlaCredito = New System.Windows.Forms.CheckBox()
        Me.chkSenhaSupervisor = New System.Windows.Forms.CheckBox()
        CType(Me.txtDiaCorte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaPrevPagto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Convênio"
        '
        'txtNomeConvenio
        '
        Me.txtNomeConvenio.Location = New System.Drawing.Point(5, 19)
        Me.txtNomeConvenio.MaxLength = 50
        Me.txtNomeConvenio.Name = "txtNomeConvenio"
        Me.txtNomeConvenio.Size = New System.Drawing.Size(600, 20)
        Me.txtNomeConvenio.TabIndex = 1
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(613, 19)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 2
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contrato"
        '
        'txtContrato
        '
        Me.txtContrato.Location = New System.Drawing.Point(5, 105)
        Me.txtContrato.Name = "txtContrato"
        Me.txtContrato.Size = New System.Drawing.Size(300, 20)
        Me.txtContrato.TabIndex = 4
        '
        'cboTipoConvenio
        '
        Me.cboTipoConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConvenio.FormattingEnabled = True
        Me.cboTipoConvenio.Location = New System.Drawing.Point(313, 105)
        Me.cboTipoConvenio.Name = "cboTipoConvenio"
        Me.cboTipoConvenio.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoConvenio.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Tipo do Convênio"
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(507, 142)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 112
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(588, 142)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 113
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'psqAdministradora
        '
        Me.psqAdministradora.AdicionarPessoa = False
        Me.psqAdministradora.Bordas = True
        Me.psqAdministradora.CarregarTodos = False
        Me.psqAdministradora.DS_Pessoa = ""
        Me.psqAdministradora.ID_Pessoa = 0
        Me.psqAdministradora.LabelVisivel = True
        Me.psqAdministradora.Location = New System.Drawing.Point(5, 47)
        Me.psqAdministradora.Name = "psqAdministradora"
        Me.psqAdministradora.PesquisarPessoa = True
        Me.psqAdministradora.Rotulo = "Administradora"
        Me.psqAdministradora.Size = New System.Drawing.Size(658, 36)
        Me.psqAdministradora.SomenteLeitura = False
        Me.psqAdministradora.TabIndex = 6
        Me.psqAdministradora.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'txtDiaCorte
        '
        Me.txtDiaCorte.Location = New System.Drawing.Point(440, 105)
        Me.txtDiaCorte.MaskInput = "nn"
        Me.txtDiaCorte.MaxValue = 31
        Me.txtDiaCorte.MinValue = 1
        Me.txtDiaCorte.Name = "txtDiaCorte"
        Me.txtDiaCorte.Size = New System.Drawing.Size(39, 21)
        Me.txtDiaCorte.TabIndex = 114
        '
        'txtDiaPrevPagto
        '
        Me.txtDiaPrevPagto.Location = New System.Drawing.Point(497, 105)
        Me.txtDiaPrevPagto.MaskInput = "nn"
        Me.txtDiaPrevPagto.MaxValue = 31
        Me.txtDiaPrevPagto.MinValue = 1
        Me.txtDiaPrevPagto.Name = "txtDiaPrevPagto"
        Me.txtDiaPrevPagto.Size = New System.Drawing.Size(39, 21)
        Me.txtDiaPrevPagto.TabIndex = 115
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(440, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Dia Corte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(497, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Dia Prev. Pagto."
        '
        'chkControlaCredito
        '
        Me.chkControlaCredito.AutoSize = True
        Me.chkControlaCredito.Location = New System.Drawing.Point(5, 131)
        Me.chkControlaCredito.Name = "chkControlaCredito"
        Me.chkControlaCredito.Size = New System.Drawing.Size(101, 17)
        Me.chkControlaCredito.TabIndex = 118
        Me.chkControlaCredito.Text = "Controla Crédito"
        Me.chkControlaCredito.UseVisualStyleBackColor = True
        '
        'chkSenhaSupervisor
        '
        Me.chkSenhaSupervisor.AutoSize = True
        Me.chkSenhaSupervisor.Location = New System.Drawing.Point(112, 131)
        Me.chkSenhaSupervisor.Name = "chkSenhaSupervisor"
        Me.chkSenhaSupervisor.Size = New System.Drawing.Size(168, 17)
        Me.chkSenhaSupervisor.TabIndex = 119
        Me.chkSenhaSupervisor.Text = "Solicitar Senha de Supervisão"
        Me.chkSenhaSupervisor.UseVisualStyleBackColor = True
        '
        'frmCadastroConvenio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 180)
        Me.Controls.Add(Me.chkSenhaSupervisor)
        Me.Controls.Add(Me.chkControlaCredito)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDiaPrevPagto)
        Me.Controls.Add(Me.txtDiaCorte)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTipoConvenio)
        Me.Controls.Add(Me.psqAdministradora)
        Me.Controls.Add(Me.txtContrato)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.txtNomeConvenio)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCadastroConvenio"
        Me.Text = "Cadastro de Convênio"
        CType(Me.txtDiaCorte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaPrevPagto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
  Friend WithEvents txtNomeConvenio As TextBox
  Friend WithEvents chkAtivo As CheckBox
  Friend WithEvents Label2 As Label
  Friend WithEvents txtContrato As TextBox
  Friend WithEvents psqAdministradora As uscPesqPessoa
  Friend WithEvents cboTipoConvenio As ComboBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents txtDiaCorte As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtDiaPrevPagto As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label4 As Label
  Friend WithEvents Label5 As Label
    Friend WithEvents chkControlaCredito As CheckBox
    Friend WithEvents chkSenhaSupervisor As CheckBox
End Class
