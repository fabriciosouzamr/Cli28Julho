<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroEmpresa
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.tbcGeral = New System.Windows.Forms.TabControl()
    Me.tbpInformacoesGerais = New System.Windows.Forms.TabPage()
        Me.txtMensagemSenha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkProvisionarPadrao = New System.Windows.Forms.CheckBox()
        Me.chkQuitarProvisionado = New System.Windows.Forms.CheckBox()
        Me.cboTabelaPrecoPadrao = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtDDDPadrao_CadastroTelefonico = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chkUsarNomeReduzidoPessoasRelatorios = New System.Windows.Forms.CheckBox()
        Me.txtNrCasasDecimaisValores = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboModeloReciboPadrao = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbpEnderecoContato = New System.Windows.Forms.TabPage()
        Me.txtWebSite = New System.Windows.Forms.TextBox()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtComplementoEndereco = New System.Windows.Forms.TextBox()
        Me.txtNumero = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtCEP = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
        Me.cboCidade = New System.Windows.Forms.ComboBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tbpComprasVendas = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPlanoContasPadraoTaxaCompensacao = New System.Windows.Forms.ComboBox()
        Me.txtNrDiaPagtoPrestadorServicoMedicoExterno = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboConvenioPadrao = New System.Windows.Forms.ComboBox()
        Me.cboContaFinanceiraTesouraria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiasValidadePedido = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtDiasValidadeOrcamento = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboSegmentoCRCPPadrao = New System.Windows.Forms.ComboBox()
        Me.cboContaFinanceiraPadraoVenda = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoPadraoVenda = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cboCondicaoPagamentoPadraoRecebimento = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cboCondicaoPagamentoPadraoVenda = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboTransacaoEstoque_Padrao_Vendas = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.cboPlanoContasPadraoRecebimentos = New System.Windows.Forms.ComboBox()
        Me.cboTransacaoEstoque_Padrao_Recebimentos = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbpResponsaveis = New System.Windows.Forms.TabPage()
        Me.psqPessoaResponsavelContabil = New Cli28Julho.uscPesqPessoa()
        Me.psqPessoaResponsavelTecnico = New Cli28Julho.uscPesqPessoa()
        Me.psqPessoaResponsavel = New Cli28Julho.uscPesqPessoa()
        Me.tbpRodapeRelatorio = New System.Windows.Forms.TabPage()
        Me.rtbRodapeRelatorio = New System.Windows.Forms.RichTextBox()
        Me.tbpImpostos = New System.Windows.Forms.TabPage()
        Me.cboContaFinanceiraPadraoImpostoRetido = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.psqPessoaLancamentoImpostoRetido = New Cli28Julho.uscPesqPessoa()
        Me.cboPlanoContasPadraoImpostoRetido = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.oCadEmpresa = New Cli28Julho.uscCadEmpresa()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cboPlanoContasPadraoDevolucao = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbcGeral.SuspendLayout()
        Me.tbpInformacoesGerais.SuspendLayout()
        CType(Me.txtNrCasasDecimaisValores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpEnderecoContato.SuspendLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpComprasVendas.SuspendLayout()
        CType(Me.txtNrDiaPagtoPrestadorServicoMedicoExterno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasValidadePedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasValidadeOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpResponsaveis.SuspendLayout()
        Me.tbpRodapeRelatorio.SuspendLayout()
        Me.tbpImpostos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcGeral
        '
        Me.tbcGeral.Controls.Add(Me.tbpInformacoesGerais)
        Me.tbcGeral.Controls.Add(Me.tbpEnderecoContato)
        Me.tbcGeral.Controls.Add(Me.tbpComprasVendas)
        Me.tbcGeral.Controls.Add(Me.tbpResponsaveis)
        Me.tbcGeral.Controls.Add(Me.tbpRodapeRelatorio)
        Me.tbcGeral.Controls.Add(Me.tbpImpostos)
        Me.tbcGeral.Location = New System.Drawing.Point(5, 245)
        Me.tbcGeral.Name = "tbcGeral"
        Me.tbcGeral.SelectedIndex = 0
        Me.tbcGeral.Size = New System.Drawing.Size(873, 241)
        Me.tbcGeral.TabIndex = 145
        '
        'tbpInformacoesGerais
        '
        Me.tbpInformacoesGerais.Controls.Add(Me.txtMensagemSenha)
        Me.tbpInformacoesGerais.Controls.Add(Me.Label5)
        Me.tbpInformacoesGerais.Controls.Add(Me.chkProvisionarPadrao)
        Me.tbpInformacoesGerais.Controls.Add(Me.chkQuitarProvisionado)
        Me.tbpInformacoesGerais.Controls.Add(Me.cboTabelaPrecoPadrao)
        Me.tbpInformacoesGerais.Controls.Add(Me.Label35)
        Me.tbpInformacoesGerais.Controls.Add(Me.txtDDDPadrao_CadastroTelefonico)
        Me.tbpInformacoesGerais.Controls.Add(Me.Label21)
        Me.tbpInformacoesGerais.Controls.Add(Me.chkUsarNomeReduzidoPessoasRelatorios)
        Me.tbpInformacoesGerais.Controls.Add(Me.txtNrCasasDecimaisValores)
        Me.tbpInformacoesGerais.Controls.Add(Me.Label18)
        Me.tbpInformacoesGerais.Controls.Add(Me.cboModeloReciboPadrao)
        Me.tbpInformacoesGerais.Controls.Add(Me.Label17)
        Me.tbpInformacoesGerais.Location = New System.Drawing.Point(4, 22)
        Me.tbpInformacoesGerais.Name = "tbpInformacoesGerais"
        Me.tbpInformacoesGerais.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInformacoesGerais.Size = New System.Drawing.Size(865, 215)
        Me.tbpInformacoesGerais.TabIndex = 2
        Me.tbpInformacoesGerais.Text = "Informações Gerais"
        Me.tbpInformacoesGerais.UseVisualStyleBackColor = True
        '
        'txtMensagemSenha
        '
        Me.txtMensagemSenha.Location = New System.Drawing.Point(5, 187)
        Me.txtMensagemSenha.MaxLength = 200
        Me.txtMensagemSenha.Name = "txtMensagemSenha"
        Me.txtMensagemSenha.Size = New System.Drawing.Size(854, 20)
        Me.txtMensagemSenha.TabIndex = 141
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Mensagem Senha"
        '
        'chkProvisionarPadrao
        '
        Me.chkProvisionarPadrao.AutoSize = True
        Me.chkProvisionarPadrao.Location = New System.Drawing.Point(5, 89)
        Me.chkProvisionarPadrao.Name = "chkProvisionarPadrao"
        Me.chkProvisionarPadrao.Size = New System.Drawing.Size(124, 17)
        Me.chkProvisionarPadrao.TabIndex = 140
        Me.chkProvisionarPadrao.Text = "Estimado por Padrão"
        Me.chkProvisionarPadrao.UseVisualStyleBackColor = True
        '
        'chkQuitarProvisionado
        '
        Me.chkQuitarProvisionado.AutoSize = True
        Me.chkQuitarProvisionado.Checked = True
        Me.chkQuitarProvisionado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkQuitarProvisionado.Location = New System.Drawing.Point(5, 108)
        Me.chkQuitarProvisionado.Name = "chkQuitarProvisionado"
        Me.chkQuitarProvisionado.Size = New System.Drawing.Size(100, 17)
        Me.chkQuitarProvisionado.TabIndex = 139
        Me.chkQuitarProvisionado.Text = "Quitar Estimado"
        Me.chkQuitarProvisionado.UseVisualStyleBackColor = True
        '
        'cboTabelaPrecoPadrao
        '
        Me.cboTabelaPrecoPadrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTabelaPrecoPadrao.FormattingEnabled = True
        Me.cboTabelaPrecoPadrao.Location = New System.Drawing.Point(5, 62)
        Me.cboTabelaPrecoPadrao.Name = "cboTabelaPrecoPadrao"
        Me.cboTabelaPrecoPadrao.Size = New System.Drawing.Size(450, 21)
        Me.cboTabelaPrecoPadrao.TabIndex = 53
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(5, 47)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(123, 13)
        Me.Label35.TabIndex = 138
        Me.Label35.Text = "Tabela de Preço Padrão"
        '
        'txtDDDPadrao_CadastroTelefonico
        '
        Me.txtDDDPadrao_CadastroTelefonico.Location = New System.Drawing.Point(743, 20)
        Me.txtDDDPadrao_CadastroTelefonico.MaxLength = 5
        Me.txtDDDPadrao_CadastroTelefonico.Name = "txtDDDPadrao_CadastroTelefonico"
        Me.txtDDDPadrao_CadastroTelefonico.Size = New System.Drawing.Size(50, 20)
        Me.txtDDDPadrao_CadastroTelefonico.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(617, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(176, 13)
        Me.Label21.TabIndex = 135
        Me.Label21.Text = "DDD Padrão no cadastro.telefônico"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkUsarNomeReduzidoPessoasRelatorios
        '
        Me.chkUsarNomeReduzidoPessoasRelatorios.AutoSize = True
        Me.chkUsarNomeReduzidoPessoasRelatorios.Location = New System.Drawing.Point(461, 62)
        Me.chkUsarNomeReduzidoPessoasRelatorios.Name = "chkUsarNomeReduzidoPessoasRelatorios"
        Me.chkUsarNomeReduzidoPessoasRelatorios.Size = New System.Drawing.Size(252, 17)
        Me.chkUsarNomeReduzidoPessoasRelatorios.TabIndex = 54
        Me.chkUsarNomeReduzidoPessoasRelatorios.Text = "Usar Nome Reduzido de Pessoas em Relatórios"
        Me.chkUsarNomeReduzidoPessoasRelatorios.UseVisualStyleBackColor = True
        '
        'txtNrCasasDecimaisValores
        '
        Me.txtNrCasasDecimaisValores.Location = New System.Drawing.Point(561, 20)
        Me.txtNrCasasDecimaisValores.MaskInput = "nnnnnn"
        Me.txtNrCasasDecimaisValores.Name = "txtNrCasasDecimaisValores"
        Me.txtNrCasasDecimaisValores.Size = New System.Drawing.Size(50, 21)
        Me.txtNrCasasDecimaisValores.TabIndex = 51
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(461, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 13)
        Me.Label18.TabIndex = 133
        Me.Label18.Text = "Nº de Casas Decimais Valores"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboModeloReciboPadrao
        '
        Me.cboModeloReciboPadrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModeloReciboPadrao.FormattingEnabled = True
        Me.cboModeloReciboPadrao.Location = New System.Drawing.Point(5, 20)
        Me.cboModeloReciboPadrao.Name = "cboModeloReciboPadrao"
        Me.cboModeloReciboPadrao.Size = New System.Drawing.Size(450, 21)
        Me.cboModeloReciboPadrao.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(131, 13)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Modelo de Recibo Padrão"
        '
        'tbpEnderecoContato
        '
        Me.tbpEnderecoContato.Controls.Add(Me.txtWebSite)
        Me.tbpEnderecoContato.Controls.Add(Me.txtEMail)
        Me.tbpEnderecoContato.Controls.Add(Me.Label8)
        Me.tbpEnderecoContato.Controls.Add(Me.Label9)
        Me.tbpEnderecoContato.Controls.Add(Me.txtComplementoEndereco)
        Me.tbpEnderecoContato.Controls.Add(Me.txtNumero)
        Me.tbpEnderecoContato.Controls.Add(Me.txtCEP)
        Me.tbpEnderecoContato.Controls.Add(Me.cboCidade)
        Me.tbpEnderecoContato.Controls.Add(Me.txtBairro)
        Me.tbpEnderecoContato.Controls.Add(Me.txtLogradouro)
        Me.tbpEnderecoContato.Controls.Add(Me.Label4)
        Me.tbpEnderecoContato.Controls.Add(Me.Label34)
        Me.tbpEnderecoContato.Controls.Add(Me.Label33)
        Me.tbpEnderecoContato.Controls.Add(Me.Label32)
        Me.tbpEnderecoContato.Controls.Add(Me.Label31)
        Me.tbpEnderecoContato.Controls.Add(Me.Label29)
        Me.tbpEnderecoContato.Controls.Add(Me.Label30)
        Me.tbpEnderecoContato.Location = New System.Drawing.Point(4, 22)
        Me.tbpEnderecoContato.Name = "tbpEnderecoContato"
        Me.tbpEnderecoContato.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEnderecoContato.Size = New System.Drawing.Size(865, 215)
        Me.tbpEnderecoContato.TabIndex = 0
        Me.tbpEnderecoContato.Text = "Endereço e Contato"
        Me.tbpEnderecoContato.UseVisualStyleBackColor = True
        '
        'txtWebSite
        '
        Me.txtWebSite.Location = New System.Drawing.Point(344, 107)
        Me.txtWebSite.MaxLength = 100
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.Size = New System.Drawing.Size(333, 20)
        Me.txtWebSite.TabIndex = 67
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(5, 107)
        Me.txtEMail.MaxLength = 100
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(333, 20)
        Me.txtEMail.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "WebSite"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "E-Mail"
        '
        'txtComplementoEndereco
        '
        Me.txtComplementoEndereco.Location = New System.Drawing.Point(353, 61)
        Me.txtComplementoEndereco.MaxLength = 100
        Me.txtComplementoEndereco.Name = "txtComplementoEndereco"
        Me.txtComplementoEndereco.Size = New System.Drawing.Size(324, 20)
        Me.txtComplementoEndereco.TabIndex = 65
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(297, 61)
        Me.txtNumero.MaskInput = "nnnnnn"
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(50, 21)
        Me.txtNumero.TabIndex = 64
        '
        'txtCEP
        '
        Me.txtCEP.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
        Me.txtCEP.InputMask = "##.###-###"
        Me.txtCEP.Location = New System.Drawing.Point(211, 61)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(80, 20)
        Me.txtCEP.TabIndex = 63
        Me.txtCEP.Text = ".-"
        '
        'cboCidade
        '
        Me.cboCidade.DropDownWidth = 400
        Me.cboCidade.FormattingEnabled = True
        Me.cboCidade.Location = New System.Drawing.Point(5, 61)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Size = New System.Drawing.Size(200, 21)
        Me.cboCidade.TabIndex = 62
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(411, 20)
        Me.txtBairro.MaxLength = 100
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(266, 20)
        Me.txtBairro.TabIndex = 61
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(5, 20)
        Me.txtLogradouro.MaxLength = 100
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(400, 20)
        Me.txtLogradouro.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(679, 13)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "_________________________________________________________________________________" &
    "_______________________________"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(353, 46)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(71, 13)
        Me.Label34.TabIndex = 100
        Me.Label34.Text = "Complemento"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(297, 46)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(44, 13)
        Me.Label33.TabIndex = 99
        Me.Label33.Text = "Número"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(211, 46)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(37, 13)
        Me.Label32.TabIndex = 98
        Me.Label32.Text = "C.E.P."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(5, 46)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 13)
        Me.Label31.TabIndex = 97
        Me.Label31.Text = "Cidade"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(411, 5)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(34, 13)
        Me.Label29.TabIndex = 94
        Me.Label29.Text = "Bairro"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(5, 5)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 13)
        Me.Label30.TabIndex = 93
        Me.Label30.Text = "Logradouro"
        '
        'tbpComprasVendas
        '
        Me.tbpComprasVendas.Controls.Add(Me.Label3)
        Me.tbpComprasVendas.Controls.Add(Me.cboPlanoContasPadraoTaxaCompensacao)
        Me.tbpComprasVendas.Controls.Add(Me.txtNrDiaPagtoPrestadorServicoMedicoExterno)
        Me.tbpComprasVendas.Controls.Add(Me.Label2)
        Me.tbpComprasVendas.Controls.Add(Me.cboConvenioPadrao)
        Me.tbpComprasVendas.Controls.Add(Me.cboContaFinanceiraTesouraria)
        Me.tbpComprasVendas.Controls.Add(Me.Label1)
        Me.tbpComprasVendas.Controls.Add(Me.txtDiasValidadePedido)
        Me.tbpComprasVendas.Controls.Add(Me.Label37)
        Me.tbpComprasVendas.Controls.Add(Me.txtDiasValidadeOrcamento)
        Me.tbpComprasVendas.Controls.Add(Me.Label28)
        Me.tbpComprasVendas.Controls.Add(Me.Label20)
        Me.tbpComprasVendas.Controls.Add(Me.cboSegmentoCRCPPadrao)
        Me.tbpComprasVendas.Controls.Add(Me.cboContaFinanceiraPadraoVenda)
        Me.tbpComprasVendas.Controls.Add(Me.Label27)
        Me.tbpComprasVendas.Controls.Add(Me.cboTipoDocumentoPadraoVenda)
        Me.tbpComprasVendas.Controls.Add(Me.Label25)
        Me.tbpComprasVendas.Controls.Add(Me.cboCondicaoPagamentoPadraoRecebimento)
        Me.tbpComprasVendas.Controls.Add(Me.Label23)
        Me.tbpComprasVendas.Controls.Add(Me.Label24)
        Me.tbpComprasVendas.Controls.Add(Me.cboCondicaoPagamentoPadraoVenda)
        Me.tbpComprasVendas.Controls.Add(Me.Label22)
        Me.tbpComprasVendas.Controls.Add(Me.Label19)
        Me.tbpComprasVendas.Controls.Add(Me.cboTransacaoEstoque_Padrao_Vendas)
        Me.tbpComprasVendas.Controls.Add(Me.Label36)
        Me.tbpComprasVendas.Controls.Add(Me.cboPlanoContasPadraoRecebimentos)
        Me.tbpComprasVendas.Controls.Add(Me.cboTransacaoEstoque_Padrao_Recebimentos)
        Me.tbpComprasVendas.Controls.Add(Me.Label16)
        Me.tbpComprasVendas.Location = New System.Drawing.Point(4, 22)
        Me.tbpComprasVendas.Name = "tbpComprasVendas"
        Me.tbpComprasVendas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpComprasVendas.Size = New System.Drawing.Size(865, 215)
        Me.tbpComprasVendas.TabIndex = 1
        Me.tbpComprasVendas.Text = "Compras e Vendas"
        Me.tbpComprasVendas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(577, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 13)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Plano de Contas Padrão para Taxa de Compensação"
        '
        'cboPlanoContasPadraoTaxaCompensacao
        '
        Me.cboPlanoContasPadraoTaxaCompensacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanoContasPadraoTaxaCompensacao.DropDownWidth = 500
        Me.cboPlanoContasPadraoTaxaCompensacao.FormattingEnabled = True
        Me.cboPlanoContasPadraoTaxaCompensacao.Location = New System.Drawing.Point(577, 104)
        Me.cboPlanoContasPadraoTaxaCompensacao.Name = "cboPlanoContasPadraoTaxaCompensacao"
        Me.cboPlanoContasPadraoTaxaCompensacao.Size = New System.Drawing.Size(280, 21)
        Me.cboPlanoContasPadraoTaxaCompensacao.TabIndex = 168
        '
        'txtNrDiaPagtoPrestadorServicoMedicoExterno
        '
        Me.txtNrDiaPagtoPrestadorServicoMedicoExterno.Location = New System.Drawing.Point(312, 188)
        Me.txtNrDiaPagtoPrestadorServicoMedicoExterno.MaskInput = "nnnnnn"
        Me.txtNrDiaPagtoPrestadorServicoMedicoExterno.Name = "txtNrDiaPagtoPrestadorServicoMedicoExterno"
        Me.txtNrDiaPagtoPrestadorServicoMedicoExterno.Size = New System.Drawing.Size(50, 21)
        Me.txtNrDiaPagtoPrestadorServicoMedicoExterno.TabIndex = 166
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 13)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Nº dias Pagto. para Prestador de Serviço Médico Externo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboConvenioPadrao
        '
        Me.cboConvenioPadrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConvenioPadrao.DropDownWidth = 500
        Me.cboConvenioPadrao.FormattingEnabled = True
        Me.cboConvenioPadrao.Location = New System.Drawing.Point(5, 104)
        Me.cboConvenioPadrao.Name = "cboConvenioPadrao"
        Me.cboConvenioPadrao.Size = New System.Drawing.Size(280, 21)
        Me.cboConvenioPadrao.TabIndex = 165
        '
        'cboContaFinanceiraTesouraria
        '
        Me.cboContaFinanceiraTesouraria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaFinanceiraTesouraria.DropDownWidth = 500
        Me.cboContaFinanceiraTesouraria.FormattingEnabled = True
        Me.cboContaFinanceiraTesouraria.Location = New System.Drawing.Point(291, 146)
        Me.cboContaFinanceiraTesouraria.Name = "cboContaFinanceiraTesouraria"
        Me.cboContaFinanceiraTesouraria.Size = New System.Drawing.Size(280, 21)
        Me.cboContaFinanceiraTesouraria.TabIndex = 163
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Conta Financeira Tesouraria"
        '
        'txtDiasValidadePedido
        '
        Me.txtDiasValidadePedido.Location = New System.Drawing.Point(168, 188)
        Me.txtDiasValidadePedido.MaskInput = "nnnnnn"
        Me.txtDiasValidadePedido.Name = "txtDiasValidadePedido"
        Me.txtDiasValidadePedido.Size = New System.Drawing.Size(50, 21)
        Me.txtDiasValidadePedido.TabIndex = 78
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(168, 173)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(138, 13)
        Me.Label37.TabIndex = 162
        Me.Label37.Text = "Dias de Validade de Pedido"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDiasValidadeOrcamento
        '
        Me.txtDiasValidadeOrcamento.Location = New System.Drawing.Point(5, 188)
        Me.txtDiasValidadeOrcamento.MaskInput = "nnnnnn"
        Me.txtDiasValidadeOrcamento.Name = "txtDiasValidadeOrcamento"
        Me.txtDiasValidadeOrcamento.Size = New System.Drawing.Size(50, 21)
        Me.txtDiasValidadeOrcamento.TabIndex = 75
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(5, 173)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(157, 13)
        Me.Label28.TabIndex = 160
        Me.Label28.Text = "Dias de Validade de Orçamento"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(577, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 13)
        Me.Label20.TabIndex = 158
        Me.Label20.Text = "Segmento de CR/CP Padrão"
        '
        'cboSegmentoCRCPPadrao
        '
        Me.cboSegmentoCRCPPadrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSegmentoCRCPPadrao.FormattingEnabled = True
        Me.cboSegmentoCRCPPadrao.Location = New System.Drawing.Point(577, 20)
        Me.cboSegmentoCRCPPadrao.Name = "cboSegmentoCRCPPadrao"
        Me.cboSegmentoCRCPPadrao.Size = New System.Drawing.Size(280, 21)
        Me.cboSegmentoCRCPPadrao.TabIndex = 72
        '
        'cboContaFinanceiraPadraoVenda
        '
        Me.cboContaFinanceiraPadraoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaFinanceiraPadraoVenda.DropDownWidth = 500
        Me.cboContaFinanceiraPadraoVenda.FormattingEnabled = True
        Me.cboContaFinanceiraPadraoVenda.Location = New System.Drawing.Point(5, 146)
        Me.cboContaFinanceiraPadraoVenda.Name = "cboContaFinanceiraPadraoVenda"
        Me.cboContaFinanceiraPadraoVenda.Size = New System.Drawing.Size(280, 21)
        Me.cboContaFinanceiraPadraoVenda.TabIndex = 79
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 131)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(173, 13)
        Me.Label27.TabIndex = 156
        Me.Label27.Text = "Conta Financeira Padrão de Venda"
        '
        'cboTipoDocumentoPadraoVenda
        '
        Me.cboTipoDocumentoPadraoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumentoPadraoVenda.DropDownWidth = 500
        Me.cboTipoDocumentoPadraoVenda.FormattingEnabled = True
        Me.cboTipoDocumentoPadraoVenda.Location = New System.Drawing.Point(291, 104)
        Me.cboTipoDocumentoPadraoVenda.Name = "cboTipoDocumentoPadraoVenda"
        Me.cboTipoDocumentoPadraoVenda.Size = New System.Drawing.Size(280, 21)
        Me.cboTipoDocumentoPadraoVenda.TabIndex = 77
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(291, 89)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(187, 13)
        Me.Label25.TabIndex = 154
        Me.Label25.Text = "Tipo de Documento Padrão na Venda"
        '
        'cboCondicaoPagamentoPadraoRecebimento
        '
        Me.cboCondicaoPagamentoPadraoRecebimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondicaoPagamentoPadraoRecebimento.DropDownWidth = 500
        Me.cboCondicaoPagamentoPadraoRecebimento.FormattingEnabled = True
        Me.cboCondicaoPagamentoPadraoRecebimento.Location = New System.Drawing.Point(5, 62)
        Me.cboCondicaoPagamentoPadraoRecebimento.Name = "cboCondicaoPagamentoPadraoRecebimento"
        Me.cboCondicaoPagamentoPadraoRecebimento.Size = New System.Drawing.Size(280, 21)
        Me.cboCondicaoPagamentoPadraoRecebimento.TabIndex = 73
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(5, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(251, 13)
        Me.Label23.TabIndex = 152
        Me.Label23.Text = "Condição de Pagamento Padrão para Recebimento"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(291, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(219, 13)
        Me.Label24.TabIndex = 150
        Me.Label24.Text = "Condição de Pagamento Padrão para Venda"
        '
        'cboCondicaoPagamentoPadraoVenda
        '
        Me.cboCondicaoPagamentoPadraoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondicaoPagamentoPadraoVenda.DropDownWidth = 500
        Me.cboCondicaoPagamentoPadraoVenda.FormattingEnabled = True
        Me.cboCondicaoPagamentoPadraoVenda.Location = New System.Drawing.Point(291, 62)
        Me.cboCondicaoPagamentoPadraoVenda.Name = "cboCondicaoPagamentoPadraoVenda"
        Me.cboCondicaoPagamentoPadraoVenda.Size = New System.Drawing.Size(280, 21)
        Me.cboCondicaoPagamentoPadraoVenda.TabIndex = 74
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(5, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 13)
        Me.Label22.TabIndex = 148
        Me.Label22.Text = "Convênio Padrão"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(291, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(215, 13)
        Me.Label19.TabIndex = 146
        Me.Label19.Text = "Transação de Estoque Padrão para Vendas"
        '
        'cboTransacaoEstoque_Padrao_Vendas
        '
        Me.cboTransacaoEstoque_Padrao_Vendas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransacaoEstoque_Padrao_Vendas.DropDownWidth = 500
        Me.cboTransacaoEstoque_Padrao_Vendas.FormattingEnabled = True
        Me.cboTransacaoEstoque_Padrao_Vendas.Location = New System.Drawing.Point(291, 20)
        Me.cboTransacaoEstoque_Padrao_Vendas.Name = "cboTransacaoEstoque_Padrao_Vendas"
        Me.cboTransacaoEstoque_Padrao_Vendas.Size = New System.Drawing.Size(280, 21)
        Me.cboTransacaoEstoque_Padrao_Vendas.TabIndex = 71
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(577, 47)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(217, 13)
        Me.Label36.TabIndex = 144
        Me.Label36.Text = "Plano de Contas Padrão para Recebimentos"
        '
        'cboPlanoContasPadraoRecebimentos
        '
        Me.cboPlanoContasPadraoRecebimentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanoContasPadraoRecebimentos.DropDownWidth = 500
        Me.cboPlanoContasPadraoRecebimentos.FormattingEnabled = True
        Me.cboPlanoContasPadraoRecebimentos.Location = New System.Drawing.Point(577, 62)
        Me.cboPlanoContasPadraoRecebimentos.Name = "cboPlanoContasPadraoRecebimentos"
        Me.cboPlanoContasPadraoRecebimentos.Size = New System.Drawing.Size(280, 21)
        Me.cboPlanoContasPadraoRecebimentos.TabIndex = 80
        '
        'cboTransacaoEstoque_Padrao_Recebimentos
        '
        Me.cboTransacaoEstoque_Padrao_Recebimentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransacaoEstoque_Padrao_Recebimentos.DropDownWidth = 500
        Me.cboTransacaoEstoque_Padrao_Recebimentos.FormattingEnabled = True
        Me.cboTransacaoEstoque_Padrao_Recebimentos.Location = New System.Drawing.Point(5, 20)
        Me.cboTransacaoEstoque_Padrao_Recebimentos.Name = "cboTransacaoEstoque_Padrao_Recebimentos"
        Me.cboTransacaoEstoque_Padrao_Recebimentos.Size = New System.Drawing.Size(280, 21)
        Me.cboTransacaoEstoque_Padrao_Recebimentos.TabIndex = 70
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(247, 13)
        Me.Label16.TabIndex = 142
        Me.Label16.Text = "Transação de Estoque Padrão para Recebimentos"
        '
        'tbpResponsaveis
        '
        Me.tbpResponsaveis.Controls.Add(Me.psqPessoaResponsavelContabil)
        Me.tbpResponsaveis.Controls.Add(Me.psqPessoaResponsavelTecnico)
        Me.tbpResponsaveis.Controls.Add(Me.psqPessoaResponsavel)
        Me.tbpResponsaveis.Location = New System.Drawing.Point(4, 22)
        Me.tbpResponsaveis.Name = "tbpResponsaveis"
        Me.tbpResponsaveis.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpResponsaveis.Size = New System.Drawing.Size(865, 215)
        Me.tbpResponsaveis.TabIndex = 3
        Me.tbpResponsaveis.Text = "Responsáveis"
        Me.tbpResponsaveis.UseVisualStyleBackColor = True
        '
        'psqPessoaResponsavelContabil
        '
        Me.psqPessoaResponsavelContabil.AdicionarPessoa = False
        Me.psqPessoaResponsavelContabil.Bordas = True
        Me.psqPessoaResponsavelContabil.CarregarTodos = False
        Me.psqPessoaResponsavelContabil.DS_Pessoa = ""
        Me.psqPessoaResponsavelContabil.ID_Pessoa = 0
        Me.psqPessoaResponsavelContabil.LabelVisivel = False
        Me.psqPessoaResponsavelContabil.Location = New System.Drawing.Point(5, 89)
        Me.psqPessoaResponsavelContabil.Name = "psqPessoaResponsavelContabil"
        Me.psqPessoaResponsavelContabil.PesquisarPessoa = False
        Me.psqPessoaResponsavelContabil.Rotulo = "Responsável Contábil"
        Me.psqPessoaResponsavelContabil.Size = New System.Drawing.Size(676, 22)
        Me.psqPessoaResponsavelContabil.SomenteLeitura = False
        Me.psqPessoaResponsavelContabil.TabIndex = 13
        Me.psqPessoaResponsavelContabil.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'psqPessoaResponsavelTecnico
        '
        Me.psqPessoaResponsavelTecnico.AdicionarPessoa = False
        Me.psqPessoaResponsavelTecnico.Bordas = True
        Me.psqPessoaResponsavelTecnico.CarregarTodos = False
        Me.psqPessoaResponsavelTecnico.DS_Pessoa = ""
        Me.psqPessoaResponsavelTecnico.ID_Pessoa = 0
        Me.psqPessoaResponsavelTecnico.LabelVisivel = False
        Me.psqPessoaResponsavelTecnico.Location = New System.Drawing.Point(5, 47)
        Me.psqPessoaResponsavelTecnico.Name = "psqPessoaResponsavelTecnico"
        Me.psqPessoaResponsavelTecnico.PesquisarPessoa = False
        Me.psqPessoaResponsavelTecnico.Rotulo = "Responsável Técnico"
        Me.psqPessoaResponsavelTecnico.Size = New System.Drawing.Size(676, 22)
        Me.psqPessoaResponsavelTecnico.SomenteLeitura = False
        Me.psqPessoaResponsavelTecnico.TabIndex = 12
        Me.psqPessoaResponsavelTecnico.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Fisica
        '
        'psqPessoaResponsavel
        '
        Me.psqPessoaResponsavel.AdicionarPessoa = False
        Me.psqPessoaResponsavel.Bordas = True
        Me.psqPessoaResponsavel.CarregarTodos = False
        Me.psqPessoaResponsavel.DS_Pessoa = ""
        Me.psqPessoaResponsavel.ID_Pessoa = 0
        Me.psqPessoaResponsavel.LabelVisivel = False
        Me.psqPessoaResponsavel.Location = New System.Drawing.Point(5, 5)
        Me.psqPessoaResponsavel.Name = "psqPessoaResponsavel"
        Me.psqPessoaResponsavel.PesquisarPessoa = False
        Me.psqPessoaResponsavel.Rotulo = "Responsável Geral"
        Me.psqPessoaResponsavel.Size = New System.Drawing.Size(676, 22)
        Me.psqPessoaResponsavel.SomenteLeitura = False
        Me.psqPessoaResponsavel.TabIndex = 11
        Me.psqPessoaResponsavel.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Fisica
        '
        'tbpRodapeRelatorio
        '
        Me.tbpRodapeRelatorio.Controls.Add(Me.rtbRodapeRelatorio)
        Me.tbpRodapeRelatorio.Location = New System.Drawing.Point(4, 22)
        Me.tbpRodapeRelatorio.Name = "tbpRodapeRelatorio"
        Me.tbpRodapeRelatorio.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRodapeRelatorio.Size = New System.Drawing.Size(865, 215)
        Me.tbpRodapeRelatorio.TabIndex = 4
        Me.tbpRodapeRelatorio.Text = "Rodapé de Relatório"
        Me.tbpRodapeRelatorio.UseVisualStyleBackColor = True
        '
        'rtbRodapeRelatorio
        '
        Me.rtbRodapeRelatorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbRodapeRelatorio.Location = New System.Drawing.Point(3, 3)
        Me.rtbRodapeRelatorio.Name = "rtbRodapeRelatorio"
        Me.rtbRodapeRelatorio.Size = New System.Drawing.Size(859, 209)
        Me.rtbRodapeRelatorio.TabIndex = 0
        Me.rtbRodapeRelatorio.Text = ""
        '
        'tbpImpostos
        '
        Me.tbpImpostos.Controls.Add(Me.cboPlanoContasPadraoDevolucao)
        Me.tbpImpostos.Controls.Add(Me.Label10)
        Me.tbpImpostos.Controls.Add(Me.cboContaFinanceiraPadraoImpostoRetido)
        Me.tbpImpostos.Controls.Add(Me.Label7)
        Me.tbpImpostos.Controls.Add(Me.psqPessoaLancamentoImpostoRetido)
        Me.tbpImpostos.Controls.Add(Me.cboPlanoContasPadraoImpostoRetido)
        Me.tbpImpostos.Controls.Add(Me.Label6)
        Me.tbpImpostos.Location = New System.Drawing.Point(4, 22)
        Me.tbpImpostos.Name = "tbpImpostos"
        Me.tbpImpostos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpImpostos.Size = New System.Drawing.Size(865, 215)
        Me.tbpImpostos.TabIndex = 5
        Me.tbpImpostos.Text = "Impostos"
        Me.tbpImpostos.UseVisualStyleBackColor = True
        '
        'cboContaFinanceiraPadraoImpostoRetido
        '
        Me.cboContaFinanceiraPadraoImpostoRetido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaFinanceiraPadraoImpostoRetido.DropDownWidth = 500
        Me.cboContaFinanceiraPadraoImpostoRetido.FormattingEnabled = True
        Me.cboContaFinanceiraPadraoImpostoRetido.Location = New System.Drawing.Point(5, 62)
        Me.cboContaFinanceiraPadraoImpostoRetido.Name = "cboContaFinanceiraPadraoImpostoRetido"
        Me.cboContaFinanceiraPadraoImpostoRetido.Size = New System.Drawing.Size(280, 21)
        Me.cboContaFinanceiraPadraoImpostoRetido.TabIndex = 146
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 13)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Conta Financeira Padrão para Imposto Retido"
        '
        'psqPessoaLancamentoImpostoRetido
        '
        Me.psqPessoaLancamentoImpostoRetido.AdicionarPessoa = True
        Me.psqPessoaLancamentoImpostoRetido.Bordas = True
        Me.psqPessoaLancamentoImpostoRetido.CarregarTodos = False
        Me.psqPessoaLancamentoImpostoRetido.DS_Pessoa = ""
        Me.psqPessoaLancamentoImpostoRetido.ID_Pessoa = 0
        Me.psqPessoaLancamentoImpostoRetido.LabelVisivel = True
        Me.psqPessoaLancamentoImpostoRetido.Location = New System.Drawing.Point(291, 5)
        Me.psqPessoaLancamentoImpostoRetido.Name = "psqPessoaLancamentoImpostoRetido"
        Me.psqPessoaLancamentoImpostoRetido.PesquisarPessoa = True
        Me.psqPessoaLancamentoImpostoRetido.Rotulo = "Pessoa para Lançamento do Imposto Retido"
        Me.psqPessoaLancamentoImpostoRetido.Size = New System.Drawing.Size(568, 36)
        Me.psqPessoaLancamentoImpostoRetido.SomenteLeitura = False
        Me.psqPessoaLancamentoImpostoRetido.TabIndex = 145
        Me.psqPessoaLancamentoImpostoRetido.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'cboPlanoContasPadraoImpostoRetido
        '
        Me.cboPlanoContasPadraoImpostoRetido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanoContasPadraoImpostoRetido.DropDownWidth = 500
        Me.cboPlanoContasPadraoImpostoRetido.FormattingEnabled = True
        Me.cboPlanoContasPadraoImpostoRetido.Location = New System.Drawing.Point(5, 20)
        Me.cboPlanoContasPadraoImpostoRetido.Name = "cboPlanoContasPadraoImpostoRetido"
        Me.cboPlanoContasPadraoImpostoRetido.Size = New System.Drawing.Size(280, 21)
        Me.cboPlanoContasPadraoImpostoRetido.TabIndex = 143
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 13)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Plano de Contas Padrão para Imposto Retido"
        '
        'oCadEmpresa
        '
        Me.oCadEmpresa.Location = New System.Drawing.Point(5, 5)
        Me.oCadEmpresa.Name = "oCadEmpresa"
        Me.oCadEmpresa.Size = New System.Drawing.Size(873, 233)
        Me.oCadEmpresa.TabIndex = 146
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(803, 494)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 111
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(722, 494)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 110
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cboPlanoContasPadraoDevolucao
        '
        Me.cboPlanoContasPadraoDevolucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanoContasPadraoDevolucao.DropDownWidth = 500
        Me.cboPlanoContasPadraoDevolucao.FormattingEnabled = True
        Me.cboPlanoContasPadraoDevolucao.Location = New System.Drawing.Point(5, 104)
        Me.cboPlanoContasPadraoDevolucao.Name = "cboPlanoContasPadraoDevolucao"
        Me.cboPlanoContasPadraoDevolucao.Size = New System.Drawing.Size(280, 21)
        Me.cboPlanoContasPadraoDevolucao.TabIndex = 148
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(201, 13)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "Plano de Contas Padrão para Devolução"
        '
        'frmCadastroEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdFechar
        Me.ClientSize = New System.Drawing.Size(883, 527)
        Me.Controls.Add(Me.oCadEmpresa)
        Me.Controls.Add(Me.tbcGeral)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroEmpresa"
        Me.Text = "Cadastro de Empresa"
        Me.tbcGeral.ResumeLayout(False)
        Me.tbpInformacoesGerais.ResumeLayout(False)
        Me.tbpInformacoesGerais.PerformLayout()
        CType(Me.txtNrCasasDecimaisValores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpEnderecoContato.ResumeLayout(False)
        Me.tbpEnderecoContato.PerformLayout()
        CType(Me.txtNumero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpComprasVendas.ResumeLayout(False)
        Me.tbpComprasVendas.PerformLayout()
        CType(Me.txtNrDiaPagtoPrestadorServicoMedicoExterno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasValidadePedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasValidadeOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpResponsaveis.ResumeLayout(False)
        Me.tbpRodapeRelatorio.ResumeLayout(False)
        Me.tbpImpostos.ResumeLayout(False)
        Me.tbpImpostos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbcGeral As TabControl
  Friend WithEvents tbpEnderecoContato As TabPage
  Friend WithEvents txtWebSite As TextBox
  Friend WithEvents txtEMail As TextBox
  Friend WithEvents Label8 As Label
  Friend WithEvents Label9 As Label
  Friend WithEvents txtComplementoEndereco As TextBox
  Friend WithEvents txtNumero As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtCEP As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents cboCidade As ComboBox
  Friend WithEvents txtBairro As TextBox
  Friend WithEvents txtLogradouro As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Label34 As Label
  Friend WithEvents Label33 As Label
  Friend WithEvents Label32 As Label
  Friend WithEvents Label31 As Label
  Friend WithEvents Label29 As Label
  Friend WithEvents Label30 As Label
  Friend WithEvents tbpComprasVendas As TabPage
  Friend WithEvents txtDiasValidadePedido As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label37 As Label
  Friend WithEvents txtDiasValidadeOrcamento As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label28 As Label
  Friend WithEvents Label20 As Label
  Friend WithEvents cboSegmentoCRCPPadrao As ComboBox
  Friend WithEvents cboContaFinanceiraPadraoVenda As ComboBox
  Friend WithEvents Label27 As Label
  Friend WithEvents cboTipoDocumentoPadraoVenda As ComboBox
  Friend WithEvents Label25 As Label
  Friend WithEvents cboCondicaoPagamentoPadraoRecebimento As ComboBox
  Friend WithEvents Label23 As Label
  Friend WithEvents Label24 As Label
  Friend WithEvents cboCondicaoPagamentoPadraoVenda As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cboTransacaoEstoque_Padrao_Vendas As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents cboPlanoContasPadraoRecebimentos As ComboBox
    Friend WithEvents cboTransacaoEstoque_Padrao_Recebimentos As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tbpInformacoesGerais As TabPage
    Friend WithEvents txtDDDPadrao_CadastroTelefonico As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents chkUsarNomeReduzidoPessoasRelatorios As CheckBox
    Friend WithEvents txtNrCasasDecimaisValores As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label18 As Label
    Friend WithEvents cboModeloReciboPadrao As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cboTabelaPrecoPadrao As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents tbpResponsaveis As TabPage
    Friend WithEvents psqPessoaResponsavelTecnico As uscPesqPessoa
    Friend WithEvents psqPessoaResponsavel As uscPesqPessoa
    Friend WithEvents psqPessoaResponsavelContabil As uscPesqPessoa
    Friend WithEvents chkProvisionarPadrao As CheckBox
    Friend WithEvents chkQuitarProvisionado As CheckBox
    Friend WithEvents oCadEmpresa As uscCadEmpresa
    Friend WithEvents cmdFechar As Button
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cboContaFinanceiraTesouraria As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboConvenioPadrao As ComboBox
    Friend WithEvents tbpRodapeRelatorio As TabPage
    Friend WithEvents rtbRodapeRelatorio As RichTextBox
    Friend WithEvents txtNrDiaPagtoPrestadorServicoMedicoExterno As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboPlanoContasPadraoTaxaCompensacao As ComboBox
    Friend WithEvents txtMensagemSenha As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbpImpostos As TabPage
    Friend WithEvents cboPlanoContasPadraoImpostoRetido As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents psqPessoaLancamentoImpostoRetido As uscPesqPessoa
    Friend WithEvents cboContaFinanceiraPadraoImpostoRetido As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboPlanoContasPadraoDevolucao As ComboBox
    Friend WithEvents Label10 As Label
End Class
