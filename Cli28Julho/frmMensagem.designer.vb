<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensagem
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
    Me.cboGrupoProcedimento = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtDataAgendamentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataAgendamentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtDataNascimentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataNascimentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboSexo = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboProfissao = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cboConvenio = New System.Windows.Forms.ComboBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.cboCidade = New System.Windows.Forms.ComboBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.cboEspecialidade = New System.Windows.Forms.ComboBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.chkExamePrevisto = New System.Windows.Forms.CheckBox()
    Me.chkQuemNaoFezExames = New System.Windows.Forms.CheckBox()
    Me.cboStatus = New System.Windows.Forms.ComboBox()
    Me.lblRStatus = New System.Windows.Forms.Label()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.rtbWahtsApp = New System.Windows.Forms.RichTextBox()
    Me.rtbSMS = New System.Windows.Forms.RichTextBox()
    Me.cmdWhatsApp_EnviarListagem = New System.Windows.Forms.Button()
        Me.cmdSMS_PreVisualizacao = New System.Windows.Forms.Button()
        Me.cmdWhatsApp_PreVisualizacao = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.cmdWhatsApp_EnviarNumero = New System.Windows.Forms.Button()
        Me.txtNumeroZap = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLinkArquivo = New System.Windows.Forms.TextBox()
        Me.txtTituloLinkArquivo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.chkAniversariantesDia = New System.Windows.Forms.CheckBox()
        Me.cmdExportarExcel = New System.Windows.Forms.Button()
        Me.cboTipoAgendamento = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDiaAniversario = New System.Windows.Forms.NumericUpDown()
        Me.cboMesAniversario = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblQuantidadePessoas = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDataSemAgendamentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtDataSemAgendamentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboCanalMarcacao = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCodigoUsuario = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.chkQuemNaoFezExamesNovamente = New System.Windows.Forms.CheckBox()
        Me.psqExamePrescrito = New Cli28Julho.uscPesqProcedimento()
        Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
        CType(Me.txtDataAgendamentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataAgendamentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataNascimentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataNascimentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaAniversario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataSemAgendamentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataSemAgendamentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboGrupoProcedimento
        '
        Me.cboGrupoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupoProcedimento.DropDownWidth = 200
        Me.cboGrupoProcedimento.FormattingEnabled = True
        Me.cboGrupoProcedimento.Location = New System.Drawing.Point(5, 20)
        Me.cboGrupoProcedimento.Name = "cboGrupoProcedimento"
        Me.cboGrupoProcedimento.Size = New System.Drawing.Size(327, 21)
        Me.cboGrupoProcedimento.TabIndex = 217
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Grupo de Procedimento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(634, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 222
        Me.Label7.Text = "a"
        '
        'txtDataAgendamentoFinal
        '
        Me.txtDataAgendamentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataAgendamentoFinal.Location = New System.Drawing.Point(649, 62)
        Me.txtDataAgendamentoFinal.Name = "txtDataAgendamentoFinal"
        Me.txtDataAgendamentoFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataAgendamentoFinal.TabIndex = 220
        Me.txtDataAgendamentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtDataAgendamentoInicial
        '
        Me.txtDataAgendamentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataAgendamentoInicial.Location = New System.Drawing.Point(547, 62)
        Me.txtDataAgendamentoInicial.Name = "txtDataAgendamentoInicial"
        Me.txtDataAgendamentoInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataAgendamentoInicial.TabIndex = 219
        Me.txtDataAgendamentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(547, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 221
        Me.Label4.Text = "Período de Agendamento"
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Location = New System.Drawing.Point(1041, 144)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 23)
        Me.cmdPesquisar.TabIndex = 223
        Me.cmdPesquisar.Text = "Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1018, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 227
        Me.Label1.Text = "a"
        '
        'txtDataNascimentoFinal
        '
        Me.txtDataNascimentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataNascimentoFinal.Location = New System.Drawing.Point(1031, 62)
        Me.txtDataNascimentoFinal.Name = "txtDataNascimentoFinal"
        Me.txtDataNascimentoFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataNascimentoFinal.TabIndex = 225
        Me.txtDataNascimentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtDataNascimentoInicial
        '
        Me.txtDataNascimentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataNascimentoInicial.Location = New System.Drawing.Point(933, 62)
        Me.txtDataNascimentoInicial.Name = "txtDataNascimentoInicial"
        Me.txtDataNascimentoInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataNascimentoInicial.TabIndex = 224
        Me.txtDataNascimentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(958, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 226
        Me.Label2.Text = "Período de Nascimento"
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.DropDownWidth = 200
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Location = New System.Drawing.Point(5, 62)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(80, 21)
        Me.cboSexo.TabIndex = 228
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 229
        Me.Label3.Text = "Sexo"
        '
        'cboProfissao
        '
        Me.cboProfissao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissao.DropDownWidth = 200
        Me.cboProfissao.FormattingEnabled = True
        Me.cboProfissao.Location = New System.Drawing.Point(91, 62)
        Me.cboProfissao.Name = "cboProfissao"
        Me.cboProfissao.Size = New System.Drawing.Size(251, 21)
        Me.cboProfissao.TabIndex = 230
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 231
        Me.Label5.Text = "Profissão"
        '
        'cboConvenio
        '
        Me.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConvenio.DropDownWidth = 200
        Me.cboConvenio.FormattingEnabled = True
        Me.cboConvenio.Location = New System.Drawing.Point(348, 62)
        Me.cboConvenio.Name = "cboConvenio"
        Me.cboConvenio.Size = New System.Drawing.Size(193, 21)
        Me.cboConvenio.TabIndex = 232
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(348, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 233
        Me.Label8.Text = "Convênio"
        '
        'cboCidade
        '
        Me.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCidade.DropDownWidth = 200
        Me.cboCidade.FormattingEnabled = True
        Me.cboCidade.Location = New System.Drawing.Point(350, 104)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Size = New System.Drawing.Size(119, 21)
        Me.cboCidade.TabIndex = 234
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(350, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 235
        Me.Label9.Text = "Cidade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(475, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 237
        Me.Label10.Text = "Bairro"
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoCivil.DropDownWidth = 200
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Location = New System.Drawing.Point(600, 104)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(119, 21)
        Me.cboEstadoCivil.TabIndex = 238
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(600, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 239
        Me.Label11.Text = "Estado Civil"
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(5, 104)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(337, 21)
        Me.cboProfissional.TabIndex = 240
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 241
        Me.Label12.Text = "Profissional"
        '
        'cboEspecialidade
        '
        Me.cboEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialidade.FormattingEnabled = True
        Me.cboEspecialidade.Location = New System.Drawing.Point(5, 146)
        Me.cboEspecialidade.Name = "cboEspecialidade"
        Me.cboEspecialidade.Size = New System.Drawing.Size(226, 21)
        Me.cboEspecialidade.TabIndex = 242
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 13)
        Me.Label13.TabIndex = 243
        Me.Label13.Text = "Especialidade"
        '
        'chkExamePrevisto
        '
        Me.chkExamePrevisto.AutoSize = True
        Me.chkExamePrevisto.Location = New System.Drawing.Point(730, 146)
        Me.chkExamePrevisto.Name = "chkExamePrevisto"
        Me.chkExamePrevisto.Size = New System.Drawing.Size(112, 17)
        Me.chkExamePrevisto.TabIndex = 244
        Me.chkExamePrevisto.Text = "Exames Prescritos"
        Me.chkExamePrevisto.UseVisualStyleBackColor = True
        '
        'chkQuemNaoFezExames
        '
        Me.chkQuemNaoFezExames.AutoSize = True
        Me.chkQuemNaoFezExames.Location = New System.Drawing.Point(392, 146)
        Me.chkQuemNaoFezExames.Name = "chkQuemNaoFezExames"
        Me.chkQuemNaoFezExames.Size = New System.Drawing.Size(137, 17)
        Me.chkQuemNaoFezExames.TabIndex = 245
        Me.chkQuemNaoFezExames.Text = "Quem não fez exame(s)"
        Me.chkQuemNaoFezExames.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.DropDownWidth = 200
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(725, 104)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(77, 21)
        Me.cboStatus.TabIndex = 246
        '
        'lblRStatus
        '
        Me.lblRStatus.AutoSize = True
        Me.lblRStatus.Location = New System.Drawing.Point(725, 89)
        Me.lblRStatus.Name = "lblRStatus"
        Me.lblRStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblRStatus.TabIndex = 247
        Me.lblRStatus.Text = "Status"
        '
        'grdListagem
        '
        Me.grdListagem.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdListagem.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdListagem.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdListagem.DisplayLayout.MaxColScrollRegions = 1
        Me.grdListagem.DisplayLayout.MaxRowScrollRegions = 1
        Me.grdListagem.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdListagem.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdListagem.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdListagem.DisplayLayout.Override.CellPadding = 0
        Me.grdListagem.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdListagem.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grdListagem.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdListagem.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdListagem.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdListagem.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdListagem.Location = New System.Drawing.Point(5, 173)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(1111, 132)
        Me.grdListagem.TabIndex = 248
        Me.grdListagem.Text = "UltraGrid1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 317)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 249
        Me.Label14.Text = "WhatsApp"
        '
        'rtbWahtsApp
        '
        Me.rtbWahtsApp.Location = New System.Drawing.Point(5, 332)
        Me.rtbWahtsApp.Name = "rtbWahtsApp"
        Me.rtbWahtsApp.Size = New System.Drawing.Size(555, 96)
        Me.rtbWahtsApp.TabIndex = 250
        Me.rtbWahtsApp.Text = ""
        '
        'rtbSMS
        '
        Me.rtbSMS.Location = New System.Drawing.Point(560, 332)
        Me.rtbSMS.Name = "rtbSMS"
        Me.rtbSMS.Size = New System.Drawing.Size(555, 96)
        Me.rtbSMS.TabIndex = 251
        Me.rtbSMS.Text = ""
        '
        'cmdWhatsApp_EnviarListagem
        '
        Me.cmdWhatsApp_EnviarListagem.Location = New System.Drawing.Point(5, 453)
        Me.cmdWhatsApp_EnviarListagem.Name = "cmdWhatsApp_EnviarListagem"
        Me.cmdWhatsApp_EnviarListagem.Size = New System.Drawing.Size(115, 23)
        Me.cmdWhatsApp_EnviarListagem.TabIndex = 252
        Me.cmdWhatsApp_EnviarListagem.Text = "Enviar para Listagem"
        Me.cmdWhatsApp_EnviarListagem.UseVisualStyleBackColor = True
        '
        'cmdSMS_PreVisualizacao
        '
        Me.cmdSMS_PreVisualizacao.Location = New System.Drawing.Point(475, 430)
        Me.cmdSMS_PreVisualizacao.Name = "cmdSMS_PreVisualizacao"
        Me.cmdSMS_PreVisualizacao.Size = New System.Drawing.Size(75, 23)
        Me.cmdSMS_PreVisualizacao.TabIndex = 253
        Me.cmdSMS_PreVisualizacao.Text = "Enviar"
        Me.cmdSMS_PreVisualizacao.UseVisualStyleBackColor = True
        '
        'cmdWhatsApp_PreVisualizacao
        '
        Me.cmdWhatsApp_PreVisualizacao.Location = New System.Drawing.Point(357, 430)
        Me.cmdWhatsApp_PreVisualizacao.Name = "cmdWhatsApp_PreVisualizacao"
        Me.cmdWhatsApp_PreVisualizacao.Size = New System.Drawing.Size(112, 23)
        Me.cmdWhatsApp_PreVisualizacao.TabIndex = 254
        Me.cmdWhatsApp_PreVisualizacao.Text = "Pré-Visualização"
        Me.cmdWhatsApp_PreVisualizacao.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(560, 317)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 255
        Me.Label15.Text = "S.M.S."
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(475, 104)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(119, 20)
        Me.txtBairro.TabIndex = 256
        '
        'cmdWhatsApp_EnviarNumero
        '
        Me.cmdWhatsApp_EnviarNumero.Location = New System.Drawing.Point(5, 478)
        Me.cmdWhatsApp_EnviarNumero.Name = "cmdWhatsApp_EnviarNumero"
        Me.cmdWhatsApp_EnviarNumero.Size = New System.Drawing.Size(115, 23)
        Me.cmdWhatsApp_EnviarNumero.TabIndex = 258
        Me.cmdWhatsApp_EnviarNumero.Text = "Enviar para Número"
        Me.cmdWhatsApp_EnviarNumero.UseVisualStyleBackColor = True
        '
        'txtNumeroZap
        '
        Me.txtNumeroZap.Location = New System.Drawing.Point(126, 481)
        Me.txtNumeroZap.Name = "txtNumeroZap"
        Me.txtNumeroZap.Size = New System.Drawing.Size(108, 20)
        Me.txtNumeroZap.TabIndex = 259
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(33, 511)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 260
        Me.Label16.Text = "Link do Arquivo: "
        '
        'txtLinkArquivo
        '
        Me.txtLinkArquivo.Location = New System.Drawing.Point(126, 507)
        Me.txtLinkArquivo.Name = "txtLinkArquivo"
        Me.txtLinkArquivo.Size = New System.Drawing.Size(759, 20)
        Me.txtLinkArquivo.TabIndex = 262
        '
        'txtTituloLinkArquivo
        '
        Me.txtTituloLinkArquivo.Location = New System.Drawing.Point(126, 533)
        Me.txtTituloLinkArquivo.Name = "txtTituloLinkArquivo"
        Me.txtTituloLinkArquivo.Size = New System.Drawing.Size(759, 20)
        Me.txtTituloLinkArquivo.TabIndex = 264
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(25, 537)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 13)
        Me.Label17.TabIndex = 263
        Me.Label17.Text = "Título do Arquivo: "
        '
        'chkAniversariantesDia
        '
        Me.chkAniversariantesDia.AutoSize = True
        Me.chkAniversariantesDia.Location = New System.Drawing.Point(846, 146)
        Me.chkAniversariantesDia.Name = "chkAniversariantesDia"
        Me.chkAniversariantesDia.Size = New System.Drawing.Size(130, 17)
        Me.chkAniversariantesDia.TabIndex = 265
        Me.chkAniversariantesDia.Text = "Aniversariantes do dia"
        Me.chkAniversariantesDia.UseVisualStyleBackColor = True
        '
        'cmdExportarExcel
        '
        Me.cmdExportarExcel.Location = New System.Drawing.Point(1019, 307)
        Me.cmdExportarExcel.Name = "cmdExportarExcel"
        Me.cmdExportarExcel.Size = New System.Drawing.Size(97, 23)
        Me.cmdExportarExcel.TabIndex = 266
        Me.cmdExportarExcel.Text = "Exportar Excel"
        Me.cmdExportarExcel.UseVisualStyleBackColor = True
        '
        'cboTipoAgendamento
        '
        Me.cboTipoAgendamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAgendamento.FormattingEnabled = True
        Me.cboTipoAgendamento.Location = New System.Drawing.Point(237, 146)
        Me.cboTipoAgendamento.Name = "cboTipoAgendamento"
        Me.cboTipoAgendamento.Size = New System.Drawing.Size(149, 21)
        Me.cboTipoAgendamento.TabIndex = 267
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(237, 131)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 13)
        Me.Label18.TabIndex = 268
        Me.Label18.Text = "Tipo de Agendamento"
        '
        'txtDiaAniversario
        '
        Me.txtDiaAniversario.Location = New System.Drawing.Point(810, 105)
        Me.txtDiaAniversario.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.txtDiaAniversario.Name = "txtDiaAniversario"
        Me.txtDiaAniversario.Size = New System.Drawing.Size(35, 20)
        Me.txtDiaAniversario.TabIndex = 269
        '
        'cboMesAniversario
        '
        Me.cboMesAniversario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMesAniversario.FormattingEnabled = True
        Me.cboMesAniversario.Location = New System.Drawing.Point(846, 104)
        Me.cboMesAniversario.Name = "cboMesAniversario"
        Me.cboMesAniversario.Size = New System.Drawing.Size(83, 21)
        Me.cboMesAniversario.TabIndex = 270
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(810, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(118, 13)
        Me.Label19.TabIndex = 271
        Me.Label19.Text = "Dia/Mês de Aniversário"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(740, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(83, 13)
        Me.Label20.TabIndex = 273
        Me.Label20.Text = "Exame Prescrito"
        '
        'lblQuantidadePessoas
        '
        Me.lblQuantidadePessoas.AutoSize = True
        Me.lblQuantidadePessoas.Location = New System.Drawing.Point(5, 305)
        Me.lblQuantidadePessoas.Name = "lblQuantidadePessoas"
        Me.lblQuantidadePessoas.Size = New System.Drawing.Size(123, 13)
        Me.lblQuantidadePessoas.TabIndex = 274
        Me.lblQuantidadePessoas.Tag = "Quantidade de Pessoas:"
        Me.lblQuantidadePessoas.Text = "Quantidade de Pessoas:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(827, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 278
        Me.Label21.Text = "a"
        Me.Label21.Visible = False
        '
        'txtDataSemAgendamentoFinal
        '
        Me.txtDataSemAgendamentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataSemAgendamentoFinal.Location = New System.Drawing.Point(842, 62)
        Me.txtDataSemAgendamentoFinal.Name = "txtDataSemAgendamentoFinal"
        Me.txtDataSemAgendamentoFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataSemAgendamentoFinal.TabIndex = 276
        Me.txtDataSemAgendamentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataSemAgendamentoFinal.Visible = False
        '
        'txtDataSemAgendamentoInicial
        '
        Me.txtDataSemAgendamentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataSemAgendamentoInicial.Location = New System.Drawing.Point(740, 62)
        Me.txtDataSemAgendamentoInicial.Name = "txtDataSemAgendamentoInicial"
        Me.txtDataSemAgendamentoInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataSemAgendamentoInicial.TabIndex = 275
        Me.txtDataSemAgendamentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataSemAgendamentoInicial.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(740, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(136, 13)
        Me.Label22.TabIndex = 277
        Me.Label22.Text = "Período sem Agendamento"
        Me.Label22.Visible = False
        '
        'cboCanalMarcacao
        '
        Me.cboCanalMarcacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCanalMarcacao.DropDownWidth = 200
        Me.cboCanalMarcacao.FormattingEnabled = True
        Me.cboCanalMarcacao.Location = New System.Drawing.Point(933, 104)
        Me.cboCanalMarcacao.Name = "cboCanalMarcacao"
        Me.cboCanalMarcacao.Size = New System.Drawing.Size(183, 21)
        Me.cboCanalMarcacao.TabIndex = 279
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(933, 89)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 13)
        Me.Label23.TabIndex = 280
        Me.Label23.Text = "Canal de Marcação"
        '
        'txtCodigoUsuario
        '
        Me.txtCodigoUsuario.Location = New System.Drawing.Point(357, 481)
        Me.txtCodigoUsuario.Name = "txtCodigoUsuario"
        Me.txtCodigoUsuario.Size = New System.Drawing.Size(528, 20)
        Me.txtCodigoUsuario.TabIndex = 281
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(255, 485)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 13)
        Me.Label24.TabIndex = 282
        Me.Label24.Text = "Código de Usuário: "
        '
        'chkQuemNaoFezExamesNovamente
        '
        Me.chkQuemNaoFezExamesNovamente.AutoSize = True
        Me.chkQuemNaoFezExamesNovamente.Location = New System.Drawing.Point(533, 146)
        Me.chkQuemNaoFezExamesNovamente.Name = "chkQuemNaoFezExamesNovamente"
        Me.chkQuemNaoFezExamesNovamente.Size = New System.Drawing.Size(193, 17)
        Me.chkQuemNaoFezExamesNovamente.TabIndex = 283
        Me.chkQuemNaoFezExamesNovamente.Text = "Quem não fez exame(s) novamente"
        Me.chkQuemNaoFezExamesNovamente.UseVisualStyleBackColor = True
        '
        'psqExamePrescrito
        '
        Me.psqExamePrescrito.Bordas = True
        Me.psqExamePrescrito.Convenio = 0
        Me.psqExamePrescrito.GrupoProcedimento = 0
        Me.psqExamePrescrito.Identificador = 0
        Me.psqExamePrescrito.LabelVisivel = False
        Me.psqExamePrescrito.Location = New System.Drawing.Point(740, 20)
        Me.psqExamePrescrito.Margin = New System.Windows.Forms.Padding(4)
        Me.psqExamePrescrito.Name = "psqExamePrescrito"
        Me.psqExamePrescrito.Profissional = 0
        Me.psqExamePrescrito.Size = New System.Drawing.Size(376, 22)
        Me.psqExamePrescrito.TabIndex = 272
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = True
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.GrupoProcedimento = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = True
        Me.psqProcedimento.Location = New System.Drawing.Point(339, 5)
        Me.psqProcedimento.Margin = New System.Windows.Forms.Padding(4)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(395, 36)
        Me.psqProcedimento.TabIndex = 216
        '
        'frmMensagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 560)
        Me.Controls.Add(Me.chkQuemNaoFezExamesNovamente)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtCodigoUsuario)
        Me.Controls.Add(Me.cboCanalMarcacao)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtDataSemAgendamentoFinal)
        Me.Controls.Add(Me.txtDataSemAgendamentoInicial)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblQuantidadePessoas)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.psqExamePrescrito)
        Me.Controls.Add(Me.txtDiaAniversario)
        Me.Controls.Add(Me.cboMesAniversario)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cboTipoAgendamento)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cmdExportarExcel)
        Me.Controls.Add(Me.chkAniversariantesDia)
        Me.Controls.Add(Me.txtTituloLinkArquivo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtLinkArquivo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtNumeroZap)
        Me.Controls.Add(Me.cmdWhatsApp_EnviarNumero)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmdWhatsApp_PreVisualizacao)
        Me.Controls.Add(Me.cmdSMS_PreVisualizacao)
        Me.Controls.Add(Me.cmdWhatsApp_EnviarListagem)
        Me.Controls.Add(Me.rtbSMS)
        Me.Controls.Add(Me.rtbWahtsApp)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.lblRStatus)
        Me.Controls.Add(Me.chkQuemNaoFezExames)
        Me.Controls.Add(Me.chkExamePrevisto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cboEspecialidade)
        Me.Controls.Add(Me.cboProfissional)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboEstadoCivil)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboCidade)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboConvenio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboProfissao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboSexo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDataNascimentoFinal)
        Me.Controls.Add(Me.txtDataNascimentoInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataAgendamentoFinal)
        Me.Controls.Add(Me.txtDataAgendamentoInicial)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboGrupoProcedimento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.psqProcedimento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMensagem"
        Me.Text = "Mensagem"
        CType(Me.txtDataAgendamentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataAgendamentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataNascimentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataNascimentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaAniversario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataSemAgendamentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataSemAgendamentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboGrupoProcedimento As ComboBox
  Friend WithEvents Label6 As Label
  Friend WithEvents psqProcedimento As uscPesqProcedimento
  Friend WithEvents Label7 As Label
  Friend WithEvents txtDataAgendamentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataAgendamentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As Label
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents txtDataNascimentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataNascimentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label2 As Label
  Friend WithEvents cboSexo As ComboBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cboProfissao As ComboBox
  Friend WithEvents Label5 As Label
  Friend WithEvents cboConvenio As ComboBox
  Friend WithEvents Label8 As Label
  Friend WithEvents cboCidade As ComboBox
  Friend WithEvents Label9 As Label
  Friend WithEvents Label10 As Label
  Friend WithEvents cboEstadoCivil As ComboBox
  Friend WithEvents Label11 As Label
  Friend WithEvents cboProfissional As ComboBox
  Friend WithEvents Label12 As Label
  Friend WithEvents cboEspecialidade As ComboBox
  Friend WithEvents Label13 As Label
  Friend WithEvents chkExamePrevisto As CheckBox
  Friend WithEvents chkQuemNaoFezExames As CheckBox
  Friend WithEvents cboStatus As ComboBox
  Friend WithEvents lblRStatus As Label
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label14 As Label
  Friend WithEvents rtbWahtsApp As RichTextBox
  Friend WithEvents rtbSMS As RichTextBox
  Friend WithEvents cmdWhatsApp_EnviarListagem As Button
  Friend WithEvents cmdSMS_PreVisualizacao As Button
  Friend WithEvents cmdWhatsApp_PreVisualizacao As Button
  Friend WithEvents Label15 As Label
  Friend WithEvents txtBairro As TextBox
    Friend WithEvents cmdWhatsApp_EnviarNumero As Button
    Friend WithEvents txtNumeroZap As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtLinkArquivo As TextBox
    Friend WithEvents txtTituloLinkArquivo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents chkAniversariantesDia As CheckBox
    Friend WithEvents cmdExportarExcel As Button
    Friend WithEvents cboTipoAgendamento As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtDiaAniversario As NumericUpDown
    Friend WithEvents cboMesAniversario As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents psqExamePrescrito As uscPesqProcedimento
    Friend WithEvents Label20 As Label
    Friend WithEvents lblQuantidadePessoas As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDataSemAgendamentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtDataSemAgendamentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label22 As Label
    Friend WithEvents cboCanalMarcacao As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtCodigoUsuario As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents chkQuemNaoFezExamesNovamente As CheckBox
End Class
