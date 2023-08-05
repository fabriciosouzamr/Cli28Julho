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
    Me.cmdWhatsApp_Enviar = New System.Windows.Forms.Button()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    Me.cmdSMS_PreVisualizacao = New System.Windows.Forms.Button()
    Me.cmdWhatsApp_PreVisualizacao = New System.Windows.Forms.Button()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.txtBairro = New System.Windows.Forms.TextBox()
    CType(Me.txtDataAgendamentoFinal,System.ComponentModel.ISupportInitialize).BeginInit
    CType(Me.txtDataAgendamentoInicial,System.ComponentModel.ISupportInitialize).BeginInit
    CType(Me.txtDataNascimentoFinal,System.ComponentModel.ISupportInitialize).BeginInit
    CType(Me.txtDataNascimentoInicial,System.ComponentModel.ISupportInitialize).BeginInit
    CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SuspendLayout
    '
    'cboGrupoProcedimento
    '
    Me.cboGrupoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrupoProcedimento.DropDownWidth = 200
    Me.cboGrupoProcedimento.FormattingEnabled = true
    Me.cboGrupoProcedimento.Location = New System.Drawing.Point(5, 20)
    Me.cboGrupoProcedimento.Name = "cboGrupoProcedimento"
    Me.cboGrupoProcedimento.Size = New System.Drawing.Size(119, 21)
    Me.cboGrupoProcedimento.TabIndex = 217
    '
    'Label6
    '
    Me.Label6.AutoSize = true
    Me.Label6.Location = New System.Drawing.Point(5, 5)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(119, 13)
    Me.Label6.TabIndex = 218
    Me.Label6.Text = "Grupo de Procedimento"
    '
    'Label7
    '
    Me.Label7.AutoSize = true
    Me.Label7.Location = New System.Drawing.Point(634, 24)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(13, 13)
    Me.Label7.TabIndex = 222
    Me.Label7.Text = "a"
    '
    'txtDataAgendamentoFinal
    '
    Me.txtDataAgendamentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataAgendamentoFinal.Location = New System.Drawing.Point(649, 20)
    Me.txtDataAgendamentoFinal.Name = "txtDataAgendamentoFinal"
    Me.txtDataAgendamentoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataAgendamentoFinal.TabIndex = 220
    Me.txtDataAgendamentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDataAgendamentoInicial
    '
    Me.txtDataAgendamentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataAgendamentoInicial.Location = New System.Drawing.Point(547, 20)
    Me.txtDataAgendamentoInicial.Name = "txtDataAgendamentoInicial"
    Me.txtDataAgendamentoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataAgendamentoInicial.TabIndex = 219
    Me.txtDataAgendamentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(547, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(129, 13)
    Me.Label4.TabIndex = 221
    Me.Label4.Text = "Período de Agendamento"
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Location = New System.Drawing.Point(850, 102)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 23)
    Me.cmdPesquisar.TabIndex = 223
    Me.cmdPesquisar.Text = "Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = true
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(827, 24)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(13, 13)
    Me.Label1.TabIndex = 227
    Me.Label1.Text = "a"
    '
    'txtDataNascimentoFinal
    '
    Me.txtDataNascimentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataNascimentoFinal.Location = New System.Drawing.Point(842, 20)
    Me.txtDataNascimentoFinal.Name = "txtDataNascimentoFinal"
    Me.txtDataNascimentoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataNascimentoFinal.TabIndex = 225
    Me.txtDataNascimentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDataNascimentoInicial
    '
    Me.txtDataNascimentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataNascimentoInicial.Location = New System.Drawing.Point(740, 20)
    Me.txtDataNascimentoInicial.Name = "txtDataNascimentoInicial"
    Me.txtDataNascimentoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataNascimentoInicial.TabIndex = 224
    Me.txtDataNascimentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(740, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(119, 13)
    Me.Label2.TabIndex = 226
    Me.Label2.Text = "Período de Nascimento"
    '
    'cboSexo
    '
    Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSexo.DropDownWidth = 200
    Me.cboSexo.FormattingEnabled = true
    Me.cboSexo.Location = New System.Drawing.Point(5, 62)
    Me.cboSexo.Name = "cboSexo"
    Me.cboSexo.Size = New System.Drawing.Size(80, 21)
    Me.cboSexo.TabIndex = 228
    '
    'Label3
    '
    Me.Label3.AutoSize = true
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
    Me.cboProfissao.FormattingEnabled = true
    Me.cboProfissao.Location = New System.Drawing.Point(91, 62)
    Me.cboProfissao.Name = "cboProfissao"
    Me.cboProfissao.Size = New System.Drawing.Size(251, 21)
    Me.cboProfissao.TabIndex = 230
    '
    'Label5
    '
    Me.Label5.AutoSize = true
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
    Me.cboConvenio.FormattingEnabled = true
    Me.cboConvenio.Location = New System.Drawing.Point(348, 62)
    Me.cboConvenio.Name = "cboConvenio"
    Me.cboConvenio.Size = New System.Drawing.Size(119, 21)
    Me.cboConvenio.TabIndex = 232
    '
    'Label8
    '
    Me.Label8.AutoSize = true
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
    Me.cboCidade.FormattingEnabled = true
    Me.cboCidade.Location = New System.Drawing.Point(473, 62)
    Me.cboCidade.Name = "cboCidade"
    Me.cboCidade.Size = New System.Drawing.Size(119, 21)
    Me.cboCidade.TabIndex = 234
    '
    'Label9
    '
    Me.Label9.AutoSize = true
    Me.Label9.Location = New System.Drawing.Point(473, 47)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(40, 13)
    Me.Label9.TabIndex = 235
    Me.Label9.Text = "Cidade"
    '
    'Label10
    '
    Me.Label10.AutoSize = true
    Me.Label10.Location = New System.Drawing.Point(598, 47)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(34, 13)
    Me.Label10.TabIndex = 237
    Me.Label10.Text = "Bairro"
    '
    'cboEstadoCivil
    '
    Me.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEstadoCivil.DropDownWidth = 200
    Me.cboEstadoCivil.FormattingEnabled = true
    Me.cboEstadoCivil.Location = New System.Drawing.Point(723, 62)
    Me.cboEstadoCivil.Name = "cboEstadoCivil"
    Me.cboEstadoCivil.Size = New System.Drawing.Size(119, 21)
    Me.cboEstadoCivil.TabIndex = 238
    '
    'Label11
    '
    Me.Label11.AutoSize = true
    Me.Label11.Location = New System.Drawing.Point(723, 47)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(62, 13)
    Me.Label11.TabIndex = 239
    Me.Label11.Text = "Estado Civil"
    '
    'cboProfissional
    '
    Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissional.FormattingEnabled = true
    Me.cboProfissional.Location = New System.Drawing.Point(5, 104)
    Me.cboProfissional.Name = "cboProfissional"
    Me.cboProfissional.Size = New System.Drawing.Size(322, 21)
    Me.cboProfissional.TabIndex = 240
    '
    'Label12
    '
    Me.Label12.AutoSize = true
    Me.Label12.Location = New System.Drawing.Point(5, 89)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(60, 13)
    Me.Label12.TabIndex = 241
    Me.Label12.Text = "Profissional"
    '
    'cboEspecialidade
    '
    Me.cboEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEspecialidade.FormattingEnabled = true
    Me.cboEspecialidade.Location = New System.Drawing.Point(333, 104)
    Me.cboEspecialidade.Name = "cboEspecialidade"
    Me.cboEspecialidade.Size = New System.Drawing.Size(322, 21)
    Me.cboEspecialidade.TabIndex = 242
    '
    'Label13
    '
    Me.Label13.AutoSize = true
    Me.Label13.Location = New System.Drawing.Point(333, 89)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(73, 13)
    Me.Label13.TabIndex = 243
    Me.Label13.Text = "Especialidade"
    '
    'chkExamePrevisto
    '
    Me.chkExamePrevisto.AutoSize = true
    Me.chkExamePrevisto.Location = New System.Drawing.Point(661, 89)
    Me.chkExamePrevisto.Name = "chkExamePrevisto"
    Me.chkExamePrevisto.Size = New System.Drawing.Size(109, 17)
    Me.chkExamePrevisto.TabIndex = 244
    Me.chkExamePrevisto.Text = "Exames Previstos"
    Me.chkExamePrevisto.UseVisualStyleBackColor = true
    '
    'chkQuemNaoFezExames
    '
    Me.chkQuemNaoFezExames.AutoSize = true
    Me.chkQuemNaoFezExames.Location = New System.Drawing.Point(661, 108)
    Me.chkQuemNaoFezExames.Name = "chkQuemNaoFezExames"
    Me.chkQuemNaoFezExames.Size = New System.Drawing.Size(137, 17)
    Me.chkQuemNaoFezExames.TabIndex = 245
    Me.chkQuemNaoFezExames.Text = "Quem não fez exame(s)"
    Me.chkQuemNaoFezExames.UseVisualStyleBackColor = true
    '
    'cboStatus
    '
    Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboStatus.DropDownWidth = 200
    Me.cboStatus.FormattingEnabled = true
    Me.cboStatus.Location = New System.Drawing.Point(848, 62)
    Me.cboStatus.Name = "cboStatus"
    Me.cboStatus.Size = New System.Drawing.Size(77, 21)
    Me.cboStatus.TabIndex = 246
    '
    'lblRStatus
    '
    Me.lblRStatus.AutoSize = true
    Me.lblRStatus.Location = New System.Drawing.Point(848, 47)
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 131)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(922, 151)
    Me.grdListagem.TabIndex = 248
    Me.grdListagem.Text = "UltraGrid1"
    '
    'Label14
    '
    Me.Label14.AutoSize = true
    Me.Label14.Location = New System.Drawing.Point(5, 288)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(57, 13)
    Me.Label14.TabIndex = 249
    Me.Label14.Text = "WhatsApp"
    '
    'rtbWahtsApp
    '
    Me.rtbWahtsApp.Location = New System.Drawing.Point(5, 303)
    Me.rtbWahtsApp.Name = "rtbWahtsApp"
    Me.rtbWahtsApp.Size = New System.Drawing.Size(448, 96)
    Me.rtbWahtsApp.TabIndex = 250
    Me.rtbWahtsApp.Text = ""
    '
    'rtbSMS
    '
    Me.rtbSMS.Location = New System.Drawing.Point(459, 303)
    Me.rtbSMS.Name = "rtbSMS"
    Me.rtbSMS.Size = New System.Drawing.Size(426, 96)
    Me.rtbSMS.TabIndex = 251
    Me.rtbSMS.Text = ""
    '
    'cmdWhatsApp_Enviar
    '
    Me.cmdWhatsApp_Enviar.Location = New System.Drawing.Point(5, 399)
    Me.cmdWhatsApp_Enviar.Name = "cmdWhatsApp_Enviar"
    Me.cmdWhatsApp_Enviar.Size = New System.Drawing.Size(75, 23)
    Me.cmdWhatsApp_Enviar.TabIndex = 252
    Me.cmdWhatsApp_Enviar.Text = "Enviar"
    Me.cmdWhatsApp_Enviar.UseVisualStyleBackColor = true
    '
    'psqProcedimento
    '
    Me.psqProcedimento.Bordas = true
    Me.psqProcedimento.Convenio = 0
    Me.psqProcedimento.GrupoProcedimento = 0
    Me.psqProcedimento.Identificador = 0
    Me.psqProcedimento.LabelVisivel = true
    Me.psqProcedimento.Location = New System.Drawing.Point(130, 5)
    Me.psqProcedimento.Name = "psqProcedimento"
    Me.psqProcedimento.Profissional = 0
    Me.psqProcedimento.Size = New System.Drawing.Size(411, 36)
    Me.psqProcedimento.TabIndex = 216
    '
    'cmdSMS_PreVisualizacao
    '
    Me.cmdSMS_PreVisualizacao.Location = New System.Drawing.Point(459, 399)
    Me.cmdSMS_PreVisualizacao.Name = "cmdSMS_PreVisualizacao"
    Me.cmdSMS_PreVisualizacao.Size = New System.Drawing.Size(75, 23)
    Me.cmdSMS_PreVisualizacao.TabIndex = 253
    Me.cmdSMS_PreVisualizacao.Text = "Enviar"
    Me.cmdSMS_PreVisualizacao.UseVisualStyleBackColor = true
    '
    'cmdWhatsApp_PreVisualizacao
    '
    Me.cmdWhatsApp_PreVisualizacao.Location = New System.Drawing.Point(341, 399)
    Me.cmdWhatsApp_PreVisualizacao.Name = "cmdWhatsApp_PreVisualizacao"
    Me.cmdWhatsApp_PreVisualizacao.Size = New System.Drawing.Size(112, 23)
    Me.cmdWhatsApp_PreVisualizacao.TabIndex = 254
    Me.cmdWhatsApp_PreVisualizacao.Text = "Pré-Visualização"
    Me.cmdWhatsApp_PreVisualizacao.UseVisualStyleBackColor = true
    '
    'Label15
    '
    Me.Label15.AutoSize = true
    Me.Label15.Location = New System.Drawing.Point(459, 288)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(39, 13)
    Me.Label15.TabIndex = 255
    Me.Label15.Text = "S.M.S."
    '
    'txtBairro
    '
    Me.txtBairro.Location = New System.Drawing.Point(598, 63)
    Me.txtBairro.Name = "txtBairro"
    Me.txtBairro.Size = New System.Drawing.Size(119, 20)
    Me.txtBairro.TabIndex = 256
    '
    'frmMensagem
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(933, 428)
    Me.Controls.Add(Me.txtBairro)
    Me.Controls.Add(Me.Label15)
    Me.Controls.Add(Me.cmdWhatsApp_PreVisualizacao)
    Me.Controls.Add(Me.cmdSMS_PreVisualizacao)
    Me.Controls.Add(Me.cmdWhatsApp_Enviar)
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
    Me.MaximizeBox = false
    Me.Name = "frmMensagem"
    Me.Text = "Mensagem"
    CType(Me.txtDataAgendamentoFinal,System.ComponentModel.ISupportInitialize).EndInit
    CType(Me.txtDataAgendamentoInicial,System.ComponentModel.ISupportInitialize).EndInit
    CType(Me.txtDataNascimentoFinal,System.ComponentModel.ISupportInitialize).EndInit
    CType(Me.txtDataNascimentoInicial,System.ComponentModel.ISupportInitialize).EndInit
    CType(Me.grdListagem,System.ComponentModel.ISupportInitialize).EndInit
    Me.ResumeLayout(false)
    Me.PerformLayout

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
  Friend WithEvents cmdWhatsApp_Enviar As Button
  Friend WithEvents cmdSMS_PreVisualizacao As Button
  Friend WithEvents cmdWhatsApp_PreVisualizacao As Button
  Friend WithEvents Label15 As Label
  Friend WithEvents txtBairro As TextBox
End Class
