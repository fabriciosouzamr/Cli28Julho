<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroPessoaSimples
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
    Me.cboTipoPessoa = New System.Windows.Forms.ComboBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.txtCPF_CNPJ = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.lblCPF_CNPJ = New System.Windows.Forms.Label()
    Me.txtNomePessoa = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtCelular = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.txtTelefone = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.chkWhatsapp = New System.Windows.Forms.CheckBox()
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
    Me.txtWebSite = New System.Windows.Forms.TextBox()
    Me.txtEMail = New System.Windows.Forms.TextBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtDataNascAbertura = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblDataNascAbertura = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtNomeFantasiaReduzido = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.lblStatus = New System.Windows.Forms.Label()
    Me.cboTipoContribuicaoICMS = New System.Windows.Forms.ComboBox()
    Me.lblRTipoContribuicaoICMS = New System.Windows.Forms.Label()
    Me.txtInscricaoMunicipal = New System.Windows.Forms.TextBox()
    Me.txtInscricaoEstadual = New System.Windows.Forms.TextBox()
    Me.lblRInscriçãoMunicipal = New System.Windows.Forms.Label()
    Me.lblRInscricaoEstaudal = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.picFoto = New uscPictureBox()
    CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataNascAbertura, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboTipoPessoa
    '
    Me.cboTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoPessoa.FormattingEnabled = True
    Me.cboTipoPessoa.Location = New System.Drawing.Point(5, 20)
    Me.cboTipoPessoa.Name = "cboTipoPessoa"
    Me.cboTipoPessoa.Size = New System.Drawing.Size(150, 21)
    Me.cboTipoPessoa.TabIndex = 1
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(5, 5)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(81, 13)
    Me.Label16.TabIndex = 21
    Me.Label16.Text = "Tipo de Pessoa"
    '
    'txtCPF_CNPJ
    '
    Me.txtCPF_CNPJ.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtCPF_CNPJ.InputMask = "nn.nnn.nnn/nnnn-nn"
    Me.txtCPF_CNPJ.Location = New System.Drawing.Point(161, 20)
    Me.txtCPF_CNPJ.Name = "txtCPF_CNPJ"
    Me.txtCPF_CNPJ.Size = New System.Drawing.Size(110, 20)
    Me.txtCPF_CNPJ.TabIndex = 2
    Me.txtCPF_CNPJ.Text = ",,/"
    '
    'lblCPF_CNPJ
    '
    Me.lblCPF_CNPJ.AutoSize = True
    Me.lblCPF_CNPJ.Location = New System.Drawing.Point(161, 5)
    Me.lblCPF_CNPJ.Name = "lblCPF_CNPJ"
    Me.lblCPF_CNPJ.Size = New System.Drawing.Size(70, 13)
    Me.lblCPF_CNPJ.TabIndex = 25
    Me.lblCPF_CNPJ.Text = "lblCPF_CNPJ"
    '
    'txtNomePessoa
    '
    Me.txtNomePessoa.Location = New System.Drawing.Point(5, 62)
    Me.txtNomePessoa.MaxLength = 100
    Me.txtNomePessoa.Name = "txtNomePessoa"
    Me.txtNomePessoa.Size = New System.Drawing.Size(372, 20)
    Me.txtNomePessoa.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 47)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(156, 13)
    Me.Label1.TabIndex = 26
    Me.Label1.Text = "Nome da Pessoa/Razão Social"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(383, 5)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(39, 13)
    Me.Label6.TabIndex = 46
    Me.Label6.Text = "Celular"
    '
    'txtCelular
    '
    Me.txtCelular.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtCelular.InputMask = "(##) #####-####"
    Me.txtCelular.Location = New System.Drawing.Point(383, 20)
    Me.txtCelular.Name = "txtCelular"
    Me.txtCelular.Size = New System.Drawing.Size(100, 20)
    Me.txtCelular.TabIndex = 4
    Me.txtCelular.Text = "() -"
    '
    'txtTelefone
    '
    Me.txtTelefone.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtTelefone.InputMask = "(##) #####-####"
    Me.txtTelefone.Location = New System.Drawing.Point(277, 20)
    Me.txtTelefone.Name = "txtTelefone"
    Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
    Me.txtTelefone.TabIndex = 3
    Me.txtTelefone.Text = "() -"
    '
    'Label26
    '
    Me.Label26.AutoSize = True
    Me.Label26.Location = New System.Drawing.Point(277, 5)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(49, 13)
    Me.Label26.TabIndex = 43
    Me.Label26.Text = "Telefone"
    '
    'chkWhatsapp
    '
    Me.chkWhatsapp.AutoSize = True
    Me.chkWhatsapp.Location = New System.Drawing.Point(422, 5)
    Me.chkWhatsapp.Name = "chkWhatsapp"
    Me.chkWhatsapp.Size = New System.Drawing.Size(81, 17)
    Me.chkWhatsapp.TabIndex = 47
    Me.chkWhatsapp.TabStop = False
    Me.chkWhatsapp.Text = "Whatsapp?"
    Me.chkWhatsapp.UseVisualStyleBackColor = True
    '
    'txtComplementoEndereco
    '
    Me.txtComplementoEndereco.Location = New System.Drawing.Point(353, 148)
    Me.txtComplementoEndereco.MaxLength = 100
    Me.txtComplementoEndereco.Name = "txtComplementoEndereco"
    Me.txtComplementoEndereco.Size = New System.Drawing.Size(324, 20)
    Me.txtComplementoEndereco.TabIndex = 13
    '
    'txtNumero
    '
    Me.txtNumero.Location = New System.Drawing.Point(297, 148)
    Me.txtNumero.MaskInput = "nnnnnn"
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(50, 21)
    Me.txtNumero.TabIndex = 12
    '
    'txtCEP
    '
    Me.txtCEP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtCEP.InputMask = "##.###-###"
    Me.txtCEP.Location = New System.Drawing.Point(211, 148)
    Me.txtCEP.Name = "txtCEP"
    Me.txtCEP.Size = New System.Drawing.Size(80, 20)
    Me.txtCEP.TabIndex = 11
    Me.txtCEP.Text = ".-"
    '
    'cboCidade
    '
    Me.cboCidade.FormattingEnabled = True
    Me.cboCidade.Location = New System.Drawing.Point(5, 148)
    Me.cboCidade.Name = "cboCidade"
    Me.cboCidade.Size = New System.Drawing.Size(200, 21)
    Me.cboCidade.TabIndex = 10
    '
    'txtBairro
    '
    Me.txtBairro.Location = New System.Drawing.Point(411, 107)
    Me.txtBairro.MaxLength = 100
    Me.txtBairro.Name = "txtBairro"
    Me.txtBairro.Size = New System.Drawing.Size(266, 20)
    Me.txtBairro.TabIndex = 9
    '
    'txtLogradouro
    '
    Me.txtLogradouro.Location = New System.Drawing.Point(5, 107)
    Me.txtLogradouro.MaxLength = 100
    Me.txtLogradouro.Name = "txtLogradouro"
    Me.txtLogradouro.Size = New System.Drawing.Size(400, 20)
    Me.txtLogradouro.TabIndex = 8
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(5, 77)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(673, 13)
    Me.Label3.TabIndex = 71
    Me.Label3.Text = "_________________________________________________________________________________" &
    "______________________________"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 163)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(673, 13)
    Me.Label4.TabIndex = 84
    Me.Label4.Text = "_________________________________________________________________________________" &
    "______________________________"
    '
    'Label34
    '
    Me.Label34.AutoSize = True
    Me.Label34.Location = New System.Drawing.Point(353, 133)
    Me.Label34.Name = "Label34"
    Me.Label34.Size = New System.Drawing.Size(71, 13)
    Me.Label34.TabIndex = 83
    Me.Label34.Text = "Complemento"
    '
    'Label33
    '
    Me.Label33.AutoSize = True
    Me.Label33.Location = New System.Drawing.Point(297, 133)
    Me.Label33.Name = "Label33"
    Me.Label33.Size = New System.Drawing.Size(44, 13)
    Me.Label33.TabIndex = 81
    Me.Label33.Text = "Número"
    '
    'Label32
    '
    Me.Label32.AutoSize = True
    Me.Label32.Location = New System.Drawing.Point(211, 133)
    Me.Label32.Name = "Label32"
    Me.Label32.Size = New System.Drawing.Size(37, 13)
    Me.Label32.TabIndex = 79
    Me.Label32.Text = "C.E.P."
    '
    'Label31
    '
    Me.Label31.AutoSize = True
    Me.Label31.Location = New System.Drawing.Point(8, 133)
    Me.Label31.Name = "Label31"
    Me.Label31.Size = New System.Drawing.Size(40, 13)
    Me.Label31.TabIndex = 76
    Me.Label31.Text = "Cidade"
    '
    'Label29
    '
    Me.Label29.AutoSize = True
    Me.Label29.Location = New System.Drawing.Point(411, 92)
    Me.Label29.Name = "Label29"
    Me.Label29.Size = New System.Drawing.Size(34, 13)
    Me.Label29.TabIndex = 73
    Me.Label29.Text = "Bairro"
    '
    'Label30
    '
    Me.Label30.AutoSize = True
    Me.Label30.Location = New System.Drawing.Point(5, 92)
    Me.Label30.Name = "Label30"
    Me.Label30.Size = New System.Drawing.Size(61, 13)
    Me.Label30.TabIndex = 72
    Me.Label30.Text = "Logradouro"
    '
    'txtWebSite
    '
    Me.txtWebSite.Location = New System.Drawing.Point(344, 195)
    Me.txtWebSite.MaxLength = 100
    Me.txtWebSite.Name = "txtWebSite"
    Me.txtWebSite.Size = New System.Drawing.Size(333, 20)
    Me.txtWebSite.TabIndex = 15
    '
    'txtEMail
    '
    Me.txtEMail.Location = New System.Drawing.Point(5, 195)
    Me.txtEMail.MaxLength = 100
    Me.txtEMail.Name = "txtEMail"
    Me.txtEMail.Size = New System.Drawing.Size(333, 20)
    Me.txtEMail.TabIndex = 14
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(344, 180)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(48, 13)
    Me.Label8.TabIndex = 90
    Me.Label8.Text = "WebSite"
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(5, 180)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(36, 13)
    Me.Label9.TabIndex = 89
    Me.Label9.Text = "E-Mail"
    '
    'txtDataNascAbertura
    '
    Me.txtDataNascAbertura.DateTime = New Date(2016, 9, 23, 0, 0, 0, 0)
    Me.txtDataNascAbertura.Location = New System.Drawing.Point(509, 20)
    Me.txtDataNascAbertura.Name = "txtDataNascAbertura"
    Me.txtDataNascAbertura.Size = New System.Drawing.Size(85, 21)
    Me.txtDataNascAbertura.TabIndex = 5
    Me.txtDataNascAbertura.Value = New Date(2016, 9, 23, 0, 0, 0, 0)
    '
    'lblDataNascAbertura
    '
    Me.lblDataNascAbertura.AutoSize = True
    Me.lblDataNascAbertura.Location = New System.Drawing.Point(509, 5)
    Me.lblDataNascAbertura.Name = "lblDataNascAbertura"
    Me.lblDataNascAbertura.Size = New System.Drawing.Size(84, 13)
    Me.lblDataNascAbertura.TabIndex = 94
    Me.lblDataNascAbertura.Text = "lblDataNascAbe"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(683, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(28, 13)
    Me.Label2.TabIndex = 96
    Me.Label2.Text = "Foto"
    '
    'txtNomeFantasiaReduzido
    '
    Me.txtNomeFantasiaReduzido.Location = New System.Drawing.Point(383, 62)
    Me.txtNomeFantasiaReduzido.MaxLength = 100
    Me.txtNomeFantasiaReduzido.Name = "txtNomeFantasiaReduzido"
    Me.txtNomeFantasiaReduzido.ShortcutsEnabled = False
    Me.txtNomeFantasiaReduzido.Size = New System.Drawing.Size(294, 20)
    Me.txtNomeFantasiaReduzido.TabIndex = 7
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(383, 47)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(133, 13)
    Me.Label5.TabIndex = 101
    Me.Label5.Text = "Apelido/Nome de Fantasia"
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(718, 277)
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
    Me.cmdFechar.Location = New System.Drawing.Point(799, 277)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'lblStatus
    '
    Me.lblStatus.AutoSize = True
    Me.lblStatus.ForeColor = System.Drawing.Color.Red
    Me.lblStatus.Location = New System.Drawing.Point(5, 272)
    Me.lblStatus.Name = "lblStatus"
    Me.lblStatus.Size = New System.Drawing.Size(47, 13)
    Me.lblStatus.TabIndex = 103
    Me.lblStatus.Text = "lblStatus"
    '
    'cboTipoContribuicaoICMS
    '
    Me.cboTipoContribuicaoICMS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboTipoContribuicaoICMS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboTipoContribuicaoICMS.CausesValidation = False
    Me.cboTipoContribuicaoICMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoContribuicaoICMS.FormattingEnabled = True
    Me.cboTipoContribuicaoICMS.Location = New System.Drawing.Point(217, 246)
    Me.cboTipoContribuicaoICMS.Name = "cboTipoContribuicaoICMS"
    Me.cboTipoContribuicaoICMS.Size = New System.Drawing.Size(348, 21)
    Me.cboTipoContribuicaoICMS.TabIndex = 18
    '
    'lblRTipoContribuicaoICMS
    '
    Me.lblRTipoContribuicaoICMS.AutoSize = True
    Me.lblRTipoContribuicaoICMS.Location = New System.Drawing.Point(217, 231)
    Me.lblRTipoContribuicaoICMS.Name = "lblRTipoContribuicaoICMS"
    Me.lblRTipoContribuicaoICMS.Size = New System.Drawing.Size(149, 13)
    Me.lblRTipoContribuicaoICMS.TabIndex = 108
    Me.lblRTipoContribuicaoICMS.Text = "Tipo de Contribuição de ICMS"
    '
    'txtInscricaoMunicipal
    '
    Me.txtInscricaoMunicipal.Location = New System.Drawing.Point(111, 246)
    Me.txtInscricaoMunicipal.MaxLength = 50
    Me.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal"
    Me.txtInscricaoMunicipal.Size = New System.Drawing.Size(100, 20)
    Me.txtInscricaoMunicipal.TabIndex = 17
    '
    'txtInscricaoEstadual
    '
    Me.txtInscricaoEstadual.Location = New System.Drawing.Point(5, 246)
    Me.txtInscricaoEstadual.MaxLength = 50
    Me.txtInscricaoEstadual.Name = "txtInscricaoEstadual"
    Me.txtInscricaoEstadual.Size = New System.Drawing.Size(100, 20)
    Me.txtInscricaoEstadual.TabIndex = 16
    '
    'lblRInscriçãoMunicipal
    '
    Me.lblRInscriçãoMunicipal.AutoSize = True
    Me.lblRInscriçãoMunicipal.Location = New System.Drawing.Point(108, 231)
    Me.lblRInscriçãoMunicipal.Name = "lblRInscriçãoMunicipal"
    Me.lblRInscriçãoMunicipal.Size = New System.Drawing.Size(98, 13)
    Me.lblRInscriçãoMunicipal.TabIndex = 107
    Me.lblRInscriçãoMunicipal.Text = "Inscrição Municipal"
    '
    'lblRInscricaoEstaudal
    '
    Me.lblRInscricaoEstaudal.AutoSize = True
    Me.lblRInscricaoEstaudal.Location = New System.Drawing.Point(5, 231)
    Me.lblRInscricaoEstaudal.Name = "lblRInscricaoEstaudal"
    Me.lblRInscricaoEstaudal.Size = New System.Drawing.Size(94, 13)
    Me.lblRInscricaoEstaudal.TabIndex = 104
    Me.lblRInscricaoEstaudal.Text = "Inscrição Estaudal"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(5, 211)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(673, 13)
    Me.Label7.TabIndex = 110
    Me.Label7.Text = "_________________________________________________________________________________" &
    "______________________________"
    '
    'picFoto
    '
    Me.picFoto.Arquivo = ""
    Me.picFoto.BotaoExcluir = True
    Me.picFoto.HabilitarBotoes = True
    Me.picFoto.Image = Nothing
    Me.picFoto.Location = New System.Drawing.Point(683, 20)
    Me.picFoto.Name = "picFoto"
    Me.picFoto.SelecionarImagem = True
    Me.picFoto.Size = New System.Drawing.Size(191, 219)
    Me.picFoto.TabIndex = 102
    Me.picFoto.TabStop = False
    '
    'frmCadastroPessoaSimples
    '
    Me.AcceptButton = Me.cmdGravar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdFechar
    Me.ClientSize = New System.Drawing.Size(879, 310)
    Me.ControlBox = False
    Me.Controls.Add(Me.cboTipoContribuicaoICMS)
    Me.Controls.Add(Me.lblRTipoContribuicaoICMS)
    Me.Controls.Add(Me.txtInscricaoMunicipal)
    Me.Controls.Add(Me.txtInscricaoEstadual)
    Me.Controls.Add(Me.lblRInscriçãoMunicipal)
    Me.Controls.Add(Me.lblRInscricaoEstaudal)
    Me.Controls.Add(Me.lblStatus)
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
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
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
    Me.Controls.Add(Me.Label7)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmCadastroPessoaSimples"
    Me.Text = "Cadastro de Pessoa"
    CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataNascAbertura, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboTipoPessoa As System.Windows.Forms.ComboBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents txtCPF_CNPJ As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents lblCPF_CNPJ As System.Windows.Forms.Label
  Friend WithEvents txtNomePessoa As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtCelular As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents txtTelefone As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents chkWhatsapp As System.Windows.Forms.CheckBox
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
  Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
  Friend WithEvents txtEMail As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtDataNascAbertura As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents lblDataNascAbertura As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtNomeFantasiaReduzido As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents picFoto As uscPictureBox
  Friend WithEvents lblStatus As Label
  Friend WithEvents cboTipoContribuicaoICMS As ComboBox
  Friend WithEvents lblRTipoContribuicaoICMS As Label
  Friend WithEvents txtInscricaoMunicipal As TextBox
  Friend WithEvents txtInscricaoEstadual As TextBox
  Friend WithEvents lblRInscriçãoMunicipal As Label
  Friend WithEvents lblRInscricaoEstaudal As Label
  Friend WithEvents Label7 As Label
End Class
