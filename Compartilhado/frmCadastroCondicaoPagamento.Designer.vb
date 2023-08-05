<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroCondicaoPagamento
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.txtNome = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboFormaPagamentoParaPagamentoUnicoEntrada = New System.Windows.Forms.ComboBox()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.grpParcelamento = New System.Windows.Forms.GroupBox()
        Me.lblRotulo = New System.Windows.Forms.Label()
        Me.cboTipoDocumentoParcelamento = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkGerarParcelaAVista = New System.Windows.Forms.CheckBox()
        Me.txtPercEntrada = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPercAcrescimento = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiasPrimeiraParcela = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlTipoIntervalo = New System.Windows.Forms.Panel()
        Me.optTipoInvervalo_Ano = New System.Windows.Forms.RadioButton()
        Me.optTipoInvervalo_Semestre = New System.Windows.Forms.RadioButton()
        Me.optTipoInvervalo_Trimestre = New System.Windows.Forms.RadioButton()
        Me.optTipoInvervalo_Mensal = New System.Windows.Forms.RadioButton()
        Me.optTipoInvervalo_Quizena = New System.Windows.Forms.RadioButton()
        Me.optTipoInvervalo_Semana = New System.Windows.Forms.RadioButton()
        Me.optTipoInvervalo_Livre = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNrDiaIntervalo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.txtQtdeParcela = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboFormaPagamentoParcelamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkParcelamento = New System.Windows.Forms.CheckBox()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.chkUsarRecebimento = New System.Windows.Forms.CheckBox()
        Me.chkUsarVenda = New System.Windows.Forms.CheckBox()
        Me.cboTipoDocumentoParaPagamentoUnicoEntrada = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.cmdNovo = New System.Windows.Forms.Button()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.uscCalculoFinanceiro_Juros = New Cli28Julho.uscCalculoFinanceiro()
        Me.txtTaxaCompensacao = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.grpParcelamento.SuspendLayout()
        CType(Me.txtPercEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercAcrescimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiasPrimeiraParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTipoIntervalo.SuspendLayout()
        CType(Me.txtNrDiaIntervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeParcela, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTaxaCompensacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(5, 20)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(131, 20)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(585, 20)
        Me.txtNome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Nome"
        '
        'cboFormaPagamentoParaPagamentoUnicoEntrada
        '
        Me.cboFormaPagamentoParaPagamentoUnicoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPagamentoParaPagamentoUnicoEntrada.FormattingEnabled = True
        Me.cboFormaPagamentoParaPagamentoUnicoEntrada.Location = New System.Drawing.Point(344, 61)
        Me.cboFormaPagamentoParaPagamentoUnicoEntrada.Name = "cboFormaPagamentoParaPagamentoUnicoEntrada"
        Me.cboFormaPagamentoParaPagamentoUnicoEntrada.Size = New System.Drawing.Size(333, 21)
        Me.cboFormaPagamentoParaPagamentoUnicoEntrada.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(344, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(312, 13)
        Me.Label22.TabIndex = 134
        Me.Label22.Text = "Forma de Pagamento Padrão para Pagamento Único ou Entrada"
        '
        'grpParcelamento
        '
        Me.grpParcelamento.Controls.Add(Me.txtTaxaCompensacao)
        Me.grpParcelamento.Controls.Add(Me.lblRotulo)
        Me.grpParcelamento.Controls.Add(Me.uscCalculoFinanceiro_Juros)
        Me.grpParcelamento.Controls.Add(Me.cboTipoDocumentoParcelamento)
        Me.grpParcelamento.Controls.Add(Me.Label11)
        Me.grpParcelamento.Controls.Add(Me.chkGerarParcelaAVista)
        Me.grpParcelamento.Controls.Add(Me.txtPercEntrada)
        Me.grpParcelamento.Controls.Add(Me.Label7)
        Me.grpParcelamento.Controls.Add(Me.txtPercAcrescimento)
        Me.grpParcelamento.Controls.Add(Me.Label9)
        Me.grpParcelamento.Controls.Add(Me.txtDiasPrimeiraParcela)
        Me.grpParcelamento.Controls.Add(Me.Label4)
        Me.grpParcelamento.Controls.Add(Me.pnlTipoIntervalo)
        Me.grpParcelamento.Controls.Add(Me.txtNrDiaIntervalo)
        Me.grpParcelamento.Controls.Add(Me.txtQtdeParcela)
        Me.grpParcelamento.Controls.Add(Me.Label6)
        Me.grpParcelamento.Controls.Add(Me.Label5)
        Me.grpParcelamento.Controls.Add(Me.cboFormaPagamentoParcelamento)
        Me.grpParcelamento.Controls.Add(Me.Label3)
        Me.grpParcelamento.Location = New System.Drawing.Point(5, 134)
        Me.grpParcelamento.Name = "grpParcelamento"
        Me.grpParcelamento.Size = New System.Drawing.Size(711, 166)
        Me.grpParcelamento.TabIndex = 7
        Me.grpParcelamento.TabStop = False
        Me.grpParcelamento.Text = "Dados do Parcelamento"
        '
        'lblRotulo
        '
        Me.lblRotulo.AutoSize = True
        Me.lblRotulo.Location = New System.Drawing.Point(274, 100)
        Me.lblRotulo.Name = "lblRotulo"
        Me.lblRotulo.Size = New System.Drawing.Size(122, 13)
        Me.lblRotulo.TabIndex = 155
        Me.lblRotulo.Text = "Taxa de Compensão (%)"
        '
        'cboTipoDocumentoParcelamento
        '
        Me.cboTipoDocumentoParcelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumentoParcelamento.FormattingEnabled = True
        Me.cboTipoDocumentoParcelamento.Location = New System.Drawing.Point(5, 31)
        Me.cboTipoDocumentoParcelamento.Name = "cboTipoDocumentoParcelamento"
        Me.cboTipoDocumentoParcelamento.Size = New System.Drawing.Size(333, 21)
        Me.cboTipoDocumentoParcelamento.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(345, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(312, 13)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Forma de Pagamento Padrão para Pagamento Único ou Entrada"
        '
        'chkGerarParcelaAVista
        '
        Me.chkGerarParcelaAVista.AutoSize = True
        Me.chkGerarParcelaAVista.Location = New System.Drawing.Point(8, 142)
        Me.chkGerarParcelaAVista.Name = "chkGerarParcelaAVista"
        Me.chkGerarParcelaAVista.Size = New System.Drawing.Size(127, 17)
        Me.chkGerarParcelaAVista.TabIndex = 17
        Me.chkGerarParcelaAVista.Text = "Gerar Parcela A Vista"
        Me.chkGerarParcelaAVista.UseVisualStyleBackColor = True
        '
        'txtPercEntrada
        '
        Me.txtPercEntrada.FormatString = ""
        Me.txtPercEntrada.Location = New System.Drawing.Point(81, 115)
        Me.txtPercEntrada.MaskInput = "{double:3.4}"
        Me.txtPercEntrada.MaxValue = 100.0R
        Me.txtPercEntrada.MinValue = 0R
        Me.txtPercEntrada.Name = "txtPercEntrada"
        Me.txtPercEntrada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtPercEntrada.Size = New System.Drawing.Size(61, 21)
        Me.txtPercEntrada.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(81, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "Entrada (%)"
        '
        'txtPercAcrescimento
        '
        Me.txtPercAcrescimento.FormatString = ""
        Me.txtPercAcrescimento.Location = New System.Drawing.Point(5, 115)
        Me.txtPercAcrescimento.MaskInput = "{double:3.4}"
        Me.txtPercAcrescimento.MinValue = 0R
        Me.txtPercAcrescimento.Name = "txtPercAcrescimento"
        Me.txtPercAcrescimento.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtPercAcrescimento.Size = New System.Drawing.Size(70, 21)
        Me.txtPercAcrescimento.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "Acréscim. (%)"
        '
        'txtDiasPrimeiraParcela
        '
        Me.txtDiasPrimeiraParcela.Location = New System.Drawing.Point(71, 72)
        Me.txtDiasPrimeiraParcela.MaskInput = "nnn"
        Me.txtDiasPrimeiraParcela.MinValue = 0
        Me.txtDiasPrimeiraParcela.Name = "txtDiasPrimeiraParcela"
        Me.txtDiasPrimeiraParcela.Size = New System.Drawing.Size(60, 21)
        Me.txtDiasPrimeiraParcela.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Dias 1ª Parc."
        '
        'pnlTipoIntervalo
        '
        Me.pnlTipoIntervalo.Controls.Add(Me.optTipoInvervalo_Ano)
        Me.pnlTipoIntervalo.Controls.Add(Me.optTipoInvervalo_Semestre)
        Me.pnlTipoIntervalo.Controls.Add(Me.optTipoInvervalo_Trimestre)
        Me.pnlTipoIntervalo.Controls.Add(Me.optTipoInvervalo_Mensal)
        Me.pnlTipoIntervalo.Controls.Add(Me.optTipoInvervalo_Quizena)
        Me.pnlTipoIntervalo.Controls.Add(Me.optTipoInvervalo_Semana)
        Me.pnlTipoIntervalo.Controls.Add(Me.optTipoInvervalo_Livre)
        Me.pnlTipoIntervalo.Controls.Add(Me.Label19)
        Me.pnlTipoIntervalo.Location = New System.Drawing.Point(203, 58)
        Me.pnlTipoIntervalo.Name = "pnlTipoIntervalo"
        Me.pnlTipoIntervalo.Size = New System.Drawing.Size(250, 44)
        Me.pnlTipoIntervalo.TabIndex = 143
        '
        'optTipoInvervalo_Ano
        '
        Me.optTipoInvervalo_Ano.Appearance = System.Windows.Forms.Appearance.Button
        Me.optTipoInvervalo_Ano.AutoSize = True
        Me.optTipoInvervalo_Ano.Location = New System.Drawing.Point(210, 14)
        Me.optTipoInvervalo_Ano.Name = "optTipoInvervalo_Ano"
        Me.optTipoInvervalo_Ano.Size = New System.Drawing.Size(36, 23)
        Me.optTipoInvervalo_Ano.TabIndex = 87
        Me.optTipoInvervalo_Ano.TabStop = True
        Me.optTipoInvervalo_Ano.Tag = "365"
        Me.optTipoInvervalo_Ano.Text = "Ano"
        Me.optTipoInvervalo_Ano.UseVisualStyleBackColor = True
        '
        'optTipoInvervalo_Semestre
        '
        Me.optTipoInvervalo_Semestre.Appearance = System.Windows.Forms.Appearance.Button
        Me.optTipoInvervalo_Semestre.AutoSize = True
        Me.optTipoInvervalo_Semestre.Location = New System.Drawing.Point(173, 14)
        Me.optTipoInvervalo_Semestre.Name = "optTipoInvervalo_Semestre"
        Me.optTipoInvervalo_Semestre.Size = New System.Drawing.Size(35, 23)
        Me.optTipoInvervalo_Semestre.TabIndex = 86
        Me.optTipoInvervalo_Semestre.TabStop = True
        Me.optTipoInvervalo_Semestre.Tag = "180"
        Me.optTipoInvervalo_Semestre.Text = "Smt"
        Me.optTipoInvervalo_Semestre.UseVisualStyleBackColor = True
        '
        'optTipoInvervalo_Trimestre
        '
        Me.optTipoInvervalo_Trimestre.Appearance = System.Windows.Forms.Appearance.Button
        Me.optTipoInvervalo_Trimestre.AutoSize = True
        Me.optTipoInvervalo_Trimestre.Location = New System.Drawing.Point(142, 14)
        Me.optTipoInvervalo_Trimestre.Name = "optTipoInvervalo_Trimestre"
        Me.optTipoInvervalo_Trimestre.Size = New System.Drawing.Size(29, 23)
        Me.optTipoInvervalo_Trimestre.TabIndex = 85
        Me.optTipoInvervalo_Trimestre.TabStop = True
        Me.optTipoInvervalo_Trimestre.Tag = "90"
        Me.optTipoInvervalo_Trimestre.Text = "Tri"
        Me.optTipoInvervalo_Trimestre.UseVisualStyleBackColor = True
        '
        'optTipoInvervalo_Mensal
        '
        Me.optTipoInvervalo_Mensal.Appearance = System.Windows.Forms.Appearance.Button
        Me.optTipoInvervalo_Mensal.AutoSize = True
        Me.optTipoInvervalo_Mensal.Location = New System.Drawing.Point(103, 14)
        Me.optTipoInvervalo_Mensal.Name = "optTipoInvervalo_Mensal"
        Me.optTipoInvervalo_Mensal.Size = New System.Drawing.Size(37, 23)
        Me.optTipoInvervalo_Mensal.TabIndex = 84
        Me.optTipoInvervalo_Mensal.TabStop = True
        Me.optTipoInvervalo_Mensal.Tag = "30"
        Me.optTipoInvervalo_Mensal.Text = "Mês"
        Me.optTipoInvervalo_Mensal.UseVisualStyleBackColor = True
        '
        'optTipoInvervalo_Quizena
        '
        Me.optTipoInvervalo_Quizena.Appearance = System.Windows.Forms.Appearance.Button
        Me.optTipoInvervalo_Quizena.AutoSize = True
        Me.optTipoInvervalo_Quizena.Location = New System.Drawing.Point(68, 14)
        Me.optTipoInvervalo_Quizena.Name = "optTipoInvervalo_Quizena"
        Me.optTipoInvervalo_Quizena.Size = New System.Drawing.Size(33, 23)
        Me.optTipoInvervalo_Quizena.TabIndex = 83
        Me.optTipoInvervalo_Quizena.TabStop = True
        Me.optTipoInvervalo_Quizena.Tag = "14"
        Me.optTipoInvervalo_Quizena.Text = "Qui"
        Me.optTipoInvervalo_Quizena.UseVisualStyleBackColor = True
        '
        'optTipoInvervalo_Semana
        '
        Me.optTipoInvervalo_Semana.Appearance = System.Windows.Forms.Appearance.Button
        Me.optTipoInvervalo_Semana.AutoSize = True
        Me.optTipoInvervalo_Semana.Location = New System.Drawing.Point(28, 14)
        Me.optTipoInvervalo_Semana.Name = "optTipoInvervalo_Semana"
        Me.optTipoInvervalo_Semana.Size = New System.Drawing.Size(38, 23)
        Me.optTipoInvervalo_Semana.TabIndex = 82
        Me.optTipoInvervalo_Semana.TabStop = True
        Me.optTipoInvervalo_Semana.Tag = "7"
        Me.optTipoInvervalo_Semana.Text = "Sem"
        Me.optTipoInvervalo_Semana.UseVisualStyleBackColor = True
        '
        'optTipoInvervalo_Livre
        '
        Me.optTipoInvervalo_Livre.Appearance = System.Windows.Forms.Appearance.Button
        Me.optTipoInvervalo_Livre.AutoSize = True
        Me.optTipoInvervalo_Livre.Location = New System.Drawing.Point(5, 14)
        Me.optTipoInvervalo_Livre.Name = "optTipoInvervalo_Livre"
        Me.optTipoInvervalo_Livre.Size = New System.Drawing.Size(21, 23)
        Me.optTipoInvervalo_Livre.TabIndex = 81
        Me.optTipoInvervalo_Livre.TabStop = True
        Me.optTipoInvervalo_Livre.Tag = "1"
        Me.optTipoInvervalo_Livre.Text = "*"
        Me.optTipoInvervalo_Livre.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, -1)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(241, 13)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "                          Tipo de Intervalo                           "
        '
        'txtNrDiaIntervalo
        '
        Me.txtNrDiaIntervalo.Location = New System.Drawing.Point(137, 73)
        Me.txtNrDiaIntervalo.MaskInput = "nnn"
        Me.txtNrDiaIntervalo.MinValue = 0
        Me.txtNrDiaIntervalo.Name = "txtNrDiaIntervalo"
        Me.txtNrDiaIntervalo.Size = New System.Drawing.Size(60, 21)
        Me.txtNrDiaIntervalo.TabIndex = 13
        '
        'txtQtdeParcela
        '
        Me.txtQtdeParcela.Location = New System.Drawing.Point(5, 73)
        Me.txtQtdeParcela.MaskInput = "nnnn"
        Me.txtQtdeParcela.MaxValue = 100
        Me.txtQtdeParcela.MinValue = 0
        Me.txtQtdeParcela.Name = "txtQtdeParcela"
        Me.txtQtdeParcela.Size = New System.Drawing.Size(60, 21)
        Me.txtQtdeParcela.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Dias Interv"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Qt. Parcela"
        '
        'cboFormaPagamentoParcelamento
        '
        Me.cboFormaPagamentoParcelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPagamentoParcelamento.FormattingEnabled = True
        Me.cboFormaPagamentoParcelamento.Location = New System.Drawing.Point(345, 31)
        Me.cboFormaPagamentoParcelamento.Name = "cboFormaPagamentoParcelamento"
        Me.cboFormaPagamentoParcelamento.Size = New System.Drawing.Size(333, 21)
        Me.cboFormaPagamentoParcelamento.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 13)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Tipo de Documento Padrão para Parcelas"
        '
        'chkParcelamento
        '
        Me.chkParcelamento.AutoSize = True
        Me.chkParcelamento.Location = New System.Drawing.Point(5, 111)
        Me.chkParcelamento.Name = "chkParcelamento"
        Me.chkParcelamento.Size = New System.Drawing.Size(91, 17)
        Me.chkParcelamento.TabIndex = 8
        Me.chkParcelamento.Text = "Parcelamento"
        Me.chkParcelamento.UseVisualStyleBackColor = True
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(243, 88)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 7
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'chkUsarRecebimento
        '
        Me.chkUsarRecebimento.AutoSize = True
        Me.chkUsarRecebimento.Location = New System.Drawing.Point(108, 88)
        Me.chkUsarRecebimento.Name = "chkUsarRecebimento"
        Me.chkUsarRecebimento.Size = New System.Drawing.Size(129, 17)
        Me.chkUsarRecebimento.TabIndex = 6
        Me.chkUsarRecebimento.Text = "Usar no Recebimento"
        Me.chkUsarRecebimento.UseVisualStyleBackColor = True
        '
        'chkUsarVenda
        '
        Me.chkUsarVenda.AutoSize = True
        Me.chkUsarVenda.Location = New System.Drawing.Point(5, 88)
        Me.chkUsarVenda.Name = "chkUsarVenda"
        Me.chkUsarVenda.Size = New System.Drawing.Size(97, 17)
        Me.chkUsarVenda.TabIndex = 5
        Me.chkUsarVenda.Text = "Usar na Venda"
        Me.chkUsarVenda.UseVisualStyleBackColor = True
        '
        'cboTipoDocumentoParaPagamentoUnicoEntrada
        '
        Me.cboTipoDocumentoParaPagamentoUnicoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoDocumentoParaPagamentoUnicoEntrada.FormattingEnabled = True
        Me.cboTipoDocumentoParaPagamentoUnicoEntrada.Location = New System.Drawing.Point(5, 61)
        Me.cboTipoDocumentoParaPagamentoUnicoEntrada.Name = "cboTipoDocumentoParaPagamentoUnicoEntrada"
        Me.cboTipoDocumentoParaPagamentoUnicoEntrada.Size = New System.Drawing.Size(333, 21)
        Me.cboTipoDocumentoParaPagamentoUnicoEntrada.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(268, 13)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Tipo de Documento para Pagamento Único ou Entrada"
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(641, 310)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 102
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdNovo
        '
        Me.cmdNovo.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Novo
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(479, 310)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
        Me.cmdNovo.TabIndex = 100
        Me.cmdNovo.Text = "  Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(560, 310)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 101
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'uscCalculoFinanceiro_Juros
        '
        Me.uscCalculoFinanceiro_Juros.Location = New System.Drawing.Point(148, 100)
        Me.uscCalculoFinanceiro_Juros.Name = "uscCalculoFinanceiro_Juros"
        Me.uscCalculoFinanceiro_Juros.PeriodoCalculoFinanceiro = Nothing
        Me.uscCalculoFinanceiro_Juros.Rotulo = "Juros"
        Me.uscCalculoFinanceiro_Juros.Size = New System.Drawing.Size(120, 36)
        Me.uscCalculoFinanceiro_Juros.TabIndex = 142
        Me.uscCalculoFinanceiro_Juros.Valor = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTaxaCompensacao
        '
        Me.txtTaxaCompensacao.FormatString = ""
        Me.txtTaxaCompensacao.Location = New System.Drawing.Point(274, 115)
        Me.txtTaxaCompensacao.MaskInput = "{double:3.4}"
        Me.txtTaxaCompensacao.Name = "txtTaxaCompensacao"
        Me.txtTaxaCompensacao.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtTaxaCompensacao.Size = New System.Drawing.Size(60, 21)
        Me.txtTaxaCompensacao.TabIndex = 158
        '
        'frmCadastroCondicaoPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdFechar
        Me.ClientSize = New System.Drawing.Size(721, 344)
        Me.Controls.Add(Me.cboTipoDocumentoParaPagamentoUnicoEntrada)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.chkUsarVenda)
        Me.Controls.Add(Me.chkUsarRecebimento)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.chkParcelamento)
        Me.Controls.Add(Me.grpParcelamento)
        Me.Controls.Add(Me.cboFormaPagamentoParaPagamentoUnicoEntrada)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroCondicaoPagamento"
        Me.Text = "Cadastro de Condição de Pagamento"
        Me.grpParcelamento.ResumeLayout(False)
        Me.grpParcelamento.PerformLayout()
        CType(Me.txtPercEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercAcrescimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiasPrimeiraParcela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTipoIntervalo.ResumeLayout(False)
        Me.pnlTipoIntervalo.PerformLayout()
        CType(Me.txtNrDiaIntervalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeParcela, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTaxaCompensacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents txtCodigo As TextBox
  Friend WithEvents txtNome As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents cboFormaPagamentoParaPagamentoUnicoEntrada As ComboBox
  Friend WithEvents Label22 As Label
  Friend WithEvents grpParcelamento As GroupBox
  Friend WithEvents chkParcelamento As CheckBox
  Friend WithEvents cboFormaPagamentoParcelamento As ComboBox
  Friend WithEvents Label3 As Label
  Friend WithEvents txtNrDiaIntervalo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents txtQtdeParcela As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label6 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents pnlTipoIntervalo As Panel
  Friend WithEvents optTipoInvervalo_Ano As RadioButton
  Friend WithEvents optTipoInvervalo_Semestre As RadioButton
  Friend WithEvents optTipoInvervalo_Trimestre As RadioButton
  Friend WithEvents optTipoInvervalo_Mensal As RadioButton
  Friend WithEvents optTipoInvervalo_Quizena As RadioButton
  Friend WithEvents optTipoInvervalo_Semana As RadioButton
  Friend WithEvents optTipoInvervalo_Livre As RadioButton
  Friend WithEvents Label19 As Label
  Friend WithEvents txtDiasPrimeiraParcela As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label4 As Label
  Friend WithEvents txtPercAcrescimento As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label9 As Label
  Friend WithEvents txtPercEntrada As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label7 As Label
  Friend WithEvents chkGerarParcelaAVista As CheckBox
  Friend WithEvents chkAtivo As CheckBox
  Friend WithEvents chkUsarRecebimento As CheckBox
  Friend WithEvents chkUsarVenda As CheckBox
  Friend WithEvents cmdNovo As Button
  Friend WithEvents cboTipoDocumentoParcelamento As ComboBox
  Friend WithEvents Label11 As Label
  Friend WithEvents cboTipoDocumentoParaPagamentoUnicoEntrada As ComboBox
  Friend WithEvents Label8 As Label
  Friend WithEvents uscCalculoFinanceiro_Juros As uscCalculoFinanceiro
    Friend WithEvents lblRotulo As Label
    Friend WithEvents txtTaxaCompensacao As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
