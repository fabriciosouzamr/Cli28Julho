<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscPessoaSimples
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.picFoto = New SisMattos.uscPictureBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtNomeFantasiaReduzido = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblDataNascAbertura = New System.Windows.Forms.Label()
    Me.txtDataNascAbertura = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtWebSite = New System.Windows.Forms.TextBox()
    Me.txtEMail = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtCelular = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.txtTelefone = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.txtNomePessoa = New System.Windows.Forms.TextBox()
    Me.txtCPF_CNPJ = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.cboTipoPessoa = New System.Windows.Forms.ComboBox()
    Me.chkWhatsapp = New System.Windows.Forms.CheckBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblCPF_CNPJ = New System.Windows.Forms.Label()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.txtComplementoEndereco = New System.Windows.Forms.TextBox()
    Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.txtCEP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.cboCidade = New System.Windows.Forms.ComboBox()
    Me.txtBairro = New System.Windows.Forms.TextBox()
    Me.txtLogradouro = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label34 = New System.Windows.Forms.Label()
    Me.Label33 = New System.Windows.Forms.Label()
    Me.Label32 = New System.Windows.Forms.Label()
    Me.Label31 = New System.Windows.Forms.Label()
    Me.Label29 = New System.Windows.Forms.Label()
    Me.Label30 = New System.Windows.Forms.Label()
    CType(Me.txtDataNascAbertura, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picFoto
    '
    Me.picFoto.Arquivo = ""
    Me.picFoto.BotaoExcluir = True
    Me.picFoto.HabilitarBotoes = True
    Me.picFoto.Image = Nothing
    Me.picFoto.Location = New System.Drawing.Point(679, 16)
    Me.picFoto.Name = "picFoto"
    Me.picFoto.SelecionarImagem = True
    Me.picFoto.Size = New System.Drawing.Size(191, 219)
    Me.picFoto.TabIndex = 137
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(379, 43)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(133, 13)
    Me.Label5.TabIndex = 136
    Me.Label5.Text = "Apelido/Nome de Fantasia"
    '
    'txtNomeFantasiaReduzido
    '
    Me.txtNomeFantasiaReduzido.Location = New System.Drawing.Point(379, 58)
    Me.txtNomeFantasiaReduzido.MaxLength = 100
    Me.txtNomeFantasiaReduzido.Name = "txtNomeFantasiaReduzido"
    Me.txtNomeFantasiaReduzido.ShortcutsEnabled = False
    Me.txtNomeFantasiaReduzido.Size = New System.Drawing.Size(294, 20)
    Me.txtNomeFantasiaReduzido.TabIndex = 135
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(679, 1)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(28, 13)
    Me.Label2.TabIndex = 134
    Me.Label2.Text = "Foto"
    '
    'lblDataNascAbertura
    '
    Me.lblDataNascAbertura.AutoSize = True
    Me.lblDataNascAbertura.Location = New System.Drawing.Point(505, 1)
    Me.lblDataNascAbertura.Name = "lblDataNascAbertura"
    Me.lblDataNascAbertura.Size = New System.Drawing.Size(84, 13)
    Me.lblDataNascAbertura.TabIndex = 133
    Me.lblDataNascAbertura.Text = "lblDataNascAbe"
    '
    'txtDataNascAbertura
    '
    Me.txtDataNascAbertura.DateTime = New Date(2016, 9, 23, 0, 0, 0, 0)
    Me.txtDataNascAbertura.Location = New System.Drawing.Point(505, 16)
    Me.txtDataNascAbertura.Name = "txtDataNascAbertura"
    Me.txtDataNascAbertura.Size = New System.Drawing.Size(85, 21)
    Me.txtDataNascAbertura.TabIndex = 132
    Me.txtDataNascAbertura.Value = New Date(2016, 9, 23, 0, 0, 0, 0)
    '
    'txtWebSite
    '
    Me.txtWebSite.Location = New System.Drawing.Point(340, 191)
    Me.txtWebSite.MaxLength = 100
    Me.txtWebSite.Name = "txtWebSite"
    Me.txtWebSite.Size = New System.Drawing.Size(333, 20)
    Me.txtWebSite.TabIndex = 131
    '
    'txtEMail
    '
    Me.txtEMail.Location = New System.Drawing.Point(1, 191)
    Me.txtEMail.MaxLength = 100
    Me.txtEMail.Name = "txtEMail"
    Me.txtEMail.Size = New System.Drawing.Size(333, 20)
    Me.txtEMail.TabIndex = 130
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(340, 176)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(48, 13)
    Me.Label8.TabIndex = 129
    Me.Label8.Text = "WebSite"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(1, 176)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(36, 13)
    Me.Label9.TabIndex = 128
    Me.Label9.Text = "E-Mail"
    '
    'txtCelular
    '
    Me.txtCelular.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtCelular.InputMask = "(##) #####-####"
    Me.txtCelular.Location = New System.Drawing.Point(379, 16)
    Me.txtCelular.Name = "txtCelular"
    Me.txtCelular.Size = New System.Drawing.Size(100, 20)
    Me.txtCelular.TabIndex = 111
    Me.txtCelular.Text = "() "
    '
    'txtTelefone
    '
    Me.txtTelefone.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtTelefone.InputMask = "(##) #####-####"
    Me.txtTelefone.Location = New System.Drawing.Point(273, 16)
    Me.txtTelefone.Name = "txtTelefone"
    Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
    Me.txtTelefone.TabIndex = 110
    Me.txtTelefone.Text = "() -"
    '
    'txtNomePessoa
    '
    Me.txtNomePessoa.Location = New System.Drawing.Point(1, 58)
    Me.txtNomePessoa.MaxLength = 100
    Me.txtNomePessoa.Name = "txtNomePessoa"
    Me.txtNomePessoa.Size = New System.Drawing.Size(372, 20)
    Me.txtNomePessoa.TabIndex = 108
    '
    'txtCPF_CNPJ
    '
    Me.txtCPF_CNPJ.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtCPF_CNPJ.InputMask = "nn.nnn.nnn/nnnn-nn"
    Me.txtCPF_CNPJ.Location = New System.Drawing.Point(157, 16)
    Me.txtCPF_CNPJ.Name = "txtCPF_CNPJ"
    Me.txtCPF_CNPJ.Size = New System.Drawing.Size(110, 20)
    Me.txtCPF_CNPJ.TabIndex = 105
    Me.txtCPF_CNPJ.Text = ",,/"
    '
    'cboTipoPessoa
    '
    Me.cboTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoPessoa.FormattingEnabled = True
    Me.cboTipoPessoa.Location = New System.Drawing.Point(1, 16)
    Me.cboTipoPessoa.Name = "cboTipoPessoa"
    Me.cboTipoPessoa.Size = New System.Drawing.Size(150, 21)
    Me.cboTipoPessoa.TabIndex = 103
    '
    'chkWhatsapp
    '
    Me.chkWhatsapp.AutoSize = True
    Me.chkWhatsapp.Location = New System.Drawing.Point(418, 1)
    Me.chkWhatsapp.Name = "chkWhatsapp"
    Me.chkWhatsapp.Size = New System.Drawing.Size(81, 17)
    Me.chkWhatsapp.TabIndex = 113
    Me.chkWhatsapp.Text = "Whatsapp?"
    Me.chkWhatsapp.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(379, 1)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(39, 13)
    Me.Label6.TabIndex = 112
    Me.Label6.Text = "Celular"
    '
    'Label26
    '
    Me.Label26.AutoSize = True
    Me.Label26.Location = New System.Drawing.Point(273, 1)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(49, 13)
    Me.Label26.TabIndex = 109
    Me.Label26.Text = "Telefone"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(1, 43)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(156, 13)
    Me.Label1.TabIndex = 107
    Me.Label1.Text = "Nome da Pessoa/Razão Social"
    '
    'lblCPF_CNPJ
    '
    Me.lblCPF_CNPJ.AutoSize = True
    Me.lblCPF_CNPJ.Location = New System.Drawing.Point(157, 1)
    Me.lblCPF_CNPJ.Name = "lblCPF_CNPJ"
    Me.lblCPF_CNPJ.Size = New System.Drawing.Size(70, 13)
    Me.lblCPF_CNPJ.TabIndex = 106
    Me.lblCPF_CNPJ.Text = "lblCPF_CNPJ"
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(1, 1)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(81, 13)
    Me.Label16.TabIndex = 104
    Me.Label16.Text = "Tipo de Pessoa"
    '
    'txtComplementoEndereco
    '
    Me.txtComplementoEndereco.Location = New System.Drawing.Point(349, 144)
    Me.txtComplementoEndereco.MaxLength = 100
    Me.txtComplementoEndereco.Name = "txtComplementoEndereco"
    Me.txtComplementoEndereco.Size = New System.Drawing.Size(324, 20)
    Me.txtComplementoEndereco.TabIndex = 125
    '
    'txtNumero
    '
    Me.txtNumero.Location = New System.Drawing.Point(293, 144)
    Me.txtNumero.MaskInput = "nnnnnn"
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(50, 21)
    Me.txtNumero.TabIndex = 123
    '
    'txtCEP
    '
    Me.txtCEP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtCEP.InputMask = "##.###-###"
    Me.txtCEP.Location = New System.Drawing.Point(207, 144)
    Me.txtCEP.Name = "txtCEP"
    Me.txtCEP.Size = New System.Drawing.Size(80, 20)
    Me.txtCEP.TabIndex = 121
    Me.txtCEP.Text = ".-"
    '
    'cboCidade
    '
    Me.cboCidade.FormattingEnabled = True
    Me.cboCidade.Location = New System.Drawing.Point(1, 144)
    Me.cboCidade.Name = "cboCidade"
    Me.cboCidade.Size = New System.Drawing.Size(200, 21)
    Me.cboCidade.TabIndex = 120
    '
    'txtBairro
    '
    Me.txtBairro.Location = New System.Drawing.Point(407, 103)
    Me.txtBairro.MaxLength = 100
    Me.txtBairro.Name = "txtBairro"
    Me.txtBairro.Size = New System.Drawing.Size(266, 20)
    Me.txtBairro.TabIndex = 118
    '
    'txtLogradouro
    '
    Me.txtLogradouro.Location = New System.Drawing.Point(1, 103)
    Me.txtLogradouro.MaxLength = 100
    Me.txtLogradouro.Name = "txtLogradouro"
    Me.txtLogradouro.Size = New System.Drawing.Size(400, 20)
    Me.txtLogradouro.TabIndex = 117
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(1, 73)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(673, 13)
    Me.Label3.TabIndex = 114
    Me.Label3.Text = "_________________________________________________________________________________" & _
    "______________________________"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(1, 159)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(673, 13)
    Me.Label4.TabIndex = 127
    Me.Label4.Text = "_________________________________________________________________________________" & _
    "______________________________"
    '
    'Label34
    '
    Me.Label34.AutoSize = True
    Me.Label34.Location = New System.Drawing.Point(349, 129)
    Me.Label34.Name = "Label34"
    Me.Label34.Size = New System.Drawing.Size(71, 13)
    Me.Label34.TabIndex = 126
    Me.Label34.Text = "Complemento"
    '
    'Label33
    '
    Me.Label33.AutoSize = True
    Me.Label33.Location = New System.Drawing.Point(293, 129)
    Me.Label33.Name = "Label33"
    Me.Label33.Size = New System.Drawing.Size(44, 13)
    Me.Label33.TabIndex = 124
    Me.Label33.Text = "Número"
    '
    'Label32
    '
    Me.Label32.AutoSize = True
    Me.Label32.Location = New System.Drawing.Point(207, 129)
    Me.Label32.Name = "Label32"
    Me.Label32.Size = New System.Drawing.Size(37, 13)
    Me.Label32.TabIndex = 122
    Me.Label32.Text = "C.E.P."
    '
    'Label31
    '
    Me.Label31.AutoSize = True
    Me.Label31.Location = New System.Drawing.Point(4, 129)
    Me.Label31.Name = "Label31"
    Me.Label31.Size = New System.Drawing.Size(40, 13)
    Me.Label31.TabIndex = 119
    Me.Label31.Text = "Cidade"
    '
    'Label29
    '
    Me.Label29.AutoSize = True
    Me.Label29.Location = New System.Drawing.Point(407, 88)
    Me.Label29.Name = "Label29"
    Me.Label29.Size = New System.Drawing.Size(34, 13)
    Me.Label29.TabIndex = 116
    Me.Label29.Text = "Bairro"
    '
    'Label30
    '
    Me.Label30.AutoSize = True
    Me.Label30.Location = New System.Drawing.Point(1, 88)
    Me.Label30.Name = "Label30"
    Me.Label30.Size = New System.Drawing.Size(61, 13)
    Me.Label30.TabIndex = 115
    Me.Label30.Text = "Logradouro"
    '
    'uscPessoaSimples
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.picFoto)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtNomeFantasiaReduzido)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.lblDataNascAbertura)
    Me.Controls.Add(Me.txtDataNascAbertura)
    Me.Controls.Add(Me.txtWebSite)
    Me.Controls.Add(Me.txtEMail)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.txtCelular)
    Me.Controls.Add(Me.txtTelefone)
    Me.Controls.Add(Me.txtNomePessoa)
    Me.Controls.Add(Me.txtCPF_CNPJ)
    Me.Controls.Add(Me.cboTipoPessoa)
    Me.Controls.Add(Me.chkWhatsapp)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label26)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblCPF_CNPJ)
    Me.Controls.Add(Me.Label16)
    Me.Controls.Add(Me.txtComplementoEndereco)
    Me.Controls.Add(Me.txtNumero)
    Me.Controls.Add(Me.txtCEP)
    Me.Controls.Add(Me.cboCidade)
    Me.Controls.Add(Me.txtBairro)
    Me.Controls.Add(Me.txtLogradouro)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label34)
    Me.Controls.Add(Me.Label33)
    Me.Controls.Add(Me.Label32)
    Me.Controls.Add(Me.Label31)
    Me.Controls.Add(Me.Label29)
    Me.Controls.Add(Me.Label30)
    Me.Name = "uscPessoaSimples"
    Me.Size = New System.Drawing.Size(870, 295)
    CType(Me.txtDataNascAbertura, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents picFoto As SisMattos.uscPictureBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtNomeFantasiaReduzido As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblDataNascAbertura As System.Windows.Forms.Label
  Friend WithEvents txtDataNascAbertura As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
  Friend WithEvents txtEMail As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtCelular As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents txtTelefone As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents txtNomePessoa As System.Windows.Forms.TextBox
  Friend WithEvents txtCPF_CNPJ As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents cboTipoPessoa As System.Windows.Forms.ComboBox
  Friend WithEvents chkWhatsapp As System.Windows.Forms.CheckBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblCPF_CNPJ As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents txtComplementoEndereco As System.Windows.Forms.TextBox
  Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtCEP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents cboCidade As System.Windows.Forms.ComboBox
  Friend WithEvents txtBairro As System.Windows.Forms.TextBox
  Friend WithEvents txtLogradouro As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label34 As System.Windows.Forms.Label
  Friend WithEvents Label33 As System.Windows.Forms.Label
  Friend WithEvents Label32 As System.Windows.Forms.Label
  Friend WithEvents Label31 As System.Windows.Forms.Label
  Friend WithEvents Label29 As System.Windows.Forms.Label
  Friend WithEvents Label30 As System.Windows.Forms.Label

End Class
