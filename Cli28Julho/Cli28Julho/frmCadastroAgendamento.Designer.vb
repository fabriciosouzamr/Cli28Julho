<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroAgendamento
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
    Me.components = New System.ComponentModel.Container()
    Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAgendamento))
    Me.grdHorario = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.cboAgendamentosParaEsseHorario = New System.Windows.Forms.ComboBox()
    Me.lblRAgendamentosParaEsseHorario = New System.Windows.Forms.Label()
    Me.lblRCodigo = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.cboStatus = New System.Windows.Forms.ComboBox()
    Me.txtDataAgendamento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.cboTipoAgendamento = New System.Windows.Forms.ComboBox()
    Me.lblRTipoAgendamento = New System.Windows.Forms.Label()
    Me.lblRDataAgendamento = New System.Windows.Forms.Label()
    Me.lblRStatus = New System.Windows.Forms.Label()
    Me.txtCelular = New System.Windows.Forms.TextBox()
    Me.txtTelefone = New System.Windows.Forms.TextBox()
    Me.cboConvenio = New System.Windows.Forms.ComboBox()
    Me.lblRTelefone = New System.Windows.Forms.Label()
    Me.lblRCelular = New System.Windows.Forms.Label()
    Me.lblRConvenio = New System.Windows.Forms.Label()
    Me.cmdDataChegada = New System.Windows.Forms.Button()
    Me.cmdDataSaida = New System.Windows.Forms.Button()
    Me.txtDataSaida = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataChegada = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblRSaida = New System.Windows.Forms.Label()
    Me.lblRChegada = New System.Windows.Forms.Label()
    Me.txtComplemento = New System.Windows.Forms.TextBox()
    Me.lblRComplemento = New System.Windows.Forms.Label()
    Me.lblInformacoes = New System.Windows.Forms.Label()
    Me.lblEmEdicao = New System.Windows.Forms.Label()
    Me.chkAtualizarListagemAutomaticamente = New System.Windows.Forms.CheckBox()
    Me.cmdExcluir = New System.Windows.Forms.Button()
    Me.cmdAtualizar = New System.Windows.Forms.Button()
    Me.cmdHistorico = New System.Windows.Forms.Button()
    Me.cmdRemarcar = New System.Windows.Forms.Button()
    Me.cmdRetorno = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cboEspecialdade = New System.Windows.Forms.ComboBox()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.imlSmile = New System.Windows.Forms.ImageList(Me.components)
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.lblValorProcedimento = New System.Windows.Forms.Label()
    Me.cmdVenda = New System.Windows.Forms.Button()
    Me.lblSaldoConvenio = New System.Windows.Forms.Label()
    Me.cboIndicador = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboCanalMarcacao = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.picAlerta_Financeiro = New System.Windows.Forms.PictureBox()
    Me.picAlerta_Aniversario = New System.Windows.Forms.PictureBox()
    Me.cmdCelularWhatsApp = New System.Windows.Forms.Button()
    Me.cmdTelefoneWhatsApp = New System.Windows.Forms.Button()
    Me.psqExecutor = New Cli28Julho.uscPesqPessoa()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
    Me.oVoucher = New Cli28Julho.uscVoucher()
    CType(Me.grdHorario, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    CType(Me.txtDataAgendamento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataSaida, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataChegada, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picAlerta_Financeiro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picAlerta_Aniversario, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'grdHorario
    '
    Appearance1.BackColor = System.Drawing.SystemColors.Window
    Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdHorario.DisplayLayout.Appearance = Appearance1
    Me.grdHorario.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdHorario.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance2.BorderColor = System.Drawing.SystemColors.Window
    Me.grdHorario.DisplayLayout.GroupByBox.Appearance = Appearance2
    Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdHorario.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
    Me.grdHorario.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance4.BackColor2 = System.Drawing.SystemColors.Control
    Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdHorario.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
    Me.grdHorario.DisplayLayout.MaxColScrollRegions = 1
    Me.grdHorario.DisplayLayout.MaxRowScrollRegions = 1
    Appearance5.BackColor = System.Drawing.SystemColors.Window
    Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdHorario.DisplayLayout.Override.ActiveCellAppearance = Appearance5
    Appearance6.BackColor = System.Drawing.SystemColors.Highlight
    Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdHorario.DisplayLayout.Override.ActiveRowAppearance = Appearance6
    Me.grdHorario.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdHorario.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance7.BackColor = System.Drawing.SystemColors.Window
    Me.grdHorario.DisplayLayout.Override.CardAreaAppearance = Appearance7
    Appearance8.BorderColor = System.Drawing.Color.Silver
    Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdHorario.DisplayLayout.Override.CellAppearance = Appearance8
    Me.grdHorario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.grdHorario.DisplayLayout.Override.CellPadding = 0
    Appearance9.BackColor = System.Drawing.SystemColors.Control
    Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance9.BorderColor = System.Drawing.SystemColors.Window
    Me.grdHorario.DisplayLayout.Override.GroupByRowAppearance = Appearance9
    Appearance10.TextHAlignAsString = "Left"
    Me.grdHorario.DisplayLayout.Override.HeaderAppearance = Appearance10
    Me.grdHorario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdHorario.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance11.BackColor = System.Drawing.SystemColors.Window
    Appearance11.BorderColor = System.Drawing.Color.Silver
    Me.grdHorario.DisplayLayout.Override.RowAppearance = Appearance11
    Me.grdHorario.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdHorario.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
    Me.grdHorario.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdHorario.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdHorario.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdHorario.Location = New System.Drawing.Point(5, 70)
    Me.grdHorario.Name = "grdHorario"
    Me.grdHorario.Size = New System.Drawing.Size(624, 437)
    Me.grdHorario.TabIndex = 141
    Me.grdHorario.Text = "UltraGrid1"
    '
    'cboProfissional
    '
    Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissional.FormattingEnabled = True
    Me.cboProfissional.Location = New System.Drawing.Point(5, 25)
    Me.cboProfissional.Name = "cboProfissional"
    Me.cboProfissional.Size = New System.Drawing.Size(624, 21)
    Me.cboProfissional.TabIndex = 140
    Me.cboProfissional.TabStop = False
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Silver
    Me.Panel1.Controls.Add(Me.cboAgendamentosParaEsseHorario)
    Me.Panel1.Controls.Add(Me.lblRAgendamentosParaEsseHorario)
    Me.Panel1.Location = New System.Drawing.Point(635, 5)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(493, 44)
    Me.Panel1.TabIndex = 159
    '
    'cboAgendamentosParaEsseHorario
    '
    Me.cboAgendamentosParaEsseHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAgendamentosParaEsseHorario.FormattingEnabled = True
    Me.cboAgendamentosParaEsseHorario.Location = New System.Drawing.Point(6, 20)
    Me.cboAgendamentosParaEsseHorario.Name = "cboAgendamentosParaEsseHorario"
    Me.cboAgendamentosParaEsseHorario.Size = New System.Drawing.Size(481, 21)
    Me.cboAgendamentosParaEsseHorario.TabIndex = 116
    '
    'lblRAgendamentosParaEsseHorario
    '
    Me.lblRAgendamentosParaEsseHorario.AutoSize = True
    Me.lblRAgendamentosParaEsseHorario.Location = New System.Drawing.Point(6, 5)
    Me.lblRAgendamentosParaEsseHorario.Name = "lblRAgendamentosParaEsseHorario"
    Me.lblRAgendamentosParaEsseHorario.Size = New System.Drawing.Size(162, 13)
    Me.lblRAgendamentosParaEsseHorario.TabIndex = 117
    Me.lblRAgendamentosParaEsseHorario.Tag = "Agendamentos para esse horário"
    Me.lblRAgendamentosParaEsseHorario.Text = "Agendamentos para esse horário"
    '
    'lblRCodigo
    '
    Me.lblRCodigo.AutoSize = True
    Me.lblRCodigo.Location = New System.Drawing.Point(1068, 55)
    Me.lblRCodigo.Name = "lblRCodigo"
    Me.lblRCodigo.Size = New System.Drawing.Size(40, 13)
    Me.lblRCodigo.TabIndex = 167
    Me.lblRCodigo.Text = "Código"
    '
    'txtCodigo
    '
    Me.txtCodigo.Location = New System.Drawing.Point(1068, 71)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.ReadOnly = True
    Me.txtCodigo.Size = New System.Drawing.Size(60, 20)
    Me.txtCodigo.TabIndex = 166
    Me.txtCodigo.TabStop = False
    '
    'cboStatus
    '
    Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboStatus.FormattingEnabled = True
    Me.cboStatus.Location = New System.Drawing.Point(881, 71)
    Me.cboStatus.Name = "cboStatus"
    Me.cboStatus.Size = New System.Drawing.Size(181, 21)
    Me.cboStatus.TabIndex = 162
    '
    'txtDataAgendamento
    '
    Me.txtDataAgendamento.Location = New System.Drawing.Point(635, 70)
    Me.txtDataAgendamento.MaskInput = "{date} {time}"
    Me.txtDataAgendamento.Name = "txtDataAgendamento"
    Me.txtDataAgendamento.Size = New System.Drawing.Size(119, 21)
    Me.txtDataAgendamento.TabIndex = 160
    '
    'cboTipoAgendamento
    '
    Me.cboTipoAgendamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoAgendamento.DropDownWidth = 200
    Me.cboTipoAgendamento.FormattingEnabled = True
    Me.cboTipoAgendamento.Location = New System.Drawing.Point(760, 71)
    Me.cboTipoAgendamento.Name = "cboTipoAgendamento"
    Me.cboTipoAgendamento.Size = New System.Drawing.Size(115, 21)
    Me.cboTipoAgendamento.TabIndex = 161
    '
    'lblRTipoAgendamento
    '
    Me.lblRTipoAgendamento.AutoSize = True
    Me.lblRTipoAgendamento.Location = New System.Drawing.Point(760, 55)
    Me.lblRTipoAgendamento.Name = "lblRTipoAgendamento"
    Me.lblRTipoAgendamento.Size = New System.Drawing.Size(112, 13)
    Me.lblRTipoAgendamento.TabIndex = 164
    Me.lblRTipoAgendamento.Text = "Tipo de Agendamento"
    '
    'lblRDataAgendamento
    '
    Me.lblRDataAgendamento.AutoSize = True
    Me.lblRDataAgendamento.Location = New System.Drawing.Point(635, 55)
    Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
    Me.lblRDataAgendamento.Size = New System.Drawing.Size(30, 13)
    Me.lblRDataAgendamento.TabIndex = 163
    Me.lblRDataAgendamento.Text = "Data"
    '
    'lblRStatus
    '
    Me.lblRStatus.AutoSize = True
    Me.lblRStatus.Location = New System.Drawing.Point(881, 55)
    Me.lblRStatus.Name = "lblRStatus"
    Me.lblRStatus.Size = New System.Drawing.Size(37, 13)
    Me.lblRStatus.TabIndex = 165
    Me.lblRStatus.Text = "Status"
    '
    'txtCelular
    '
    Me.txtCelular.Location = New System.Drawing.Point(958, 154)
    Me.txtCelular.Name = "txtCelular"
    Me.txtCelular.Size = New System.Drawing.Size(100, 20)
    Me.txtCelular.TabIndex = 171
    '
    'txtTelefone
    '
    Me.txtTelefone.Location = New System.Drawing.Point(830, 154)
    Me.txtTelefone.Name = "txtTelefone"
    Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
    Me.txtTelefone.TabIndex = 170
    '
    'cboConvenio
    '
    Me.cboConvenio.DropDownHeight = 300
    Me.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboConvenio.FormattingEnabled = True
    Me.cboConvenio.IntegralHeight = False
    Me.cboConvenio.Location = New System.Drawing.Point(635, 154)
    Me.cboConvenio.Name = "cboConvenio"
    Me.cboConvenio.Size = New System.Drawing.Size(189, 21)
    Me.cboConvenio.TabIndex = 169
    '
    'lblRTelefone
    '
    Me.lblRTelefone.AutoSize = True
    Me.lblRTelefone.Location = New System.Drawing.Point(830, 139)
    Me.lblRTelefone.Name = "lblRTelefone"
    Me.lblRTelefone.Size = New System.Drawing.Size(49, 13)
    Me.lblRTelefone.TabIndex = 173
    Me.lblRTelefone.Text = "Telefone"
    '
    'lblRCelular
    '
    Me.lblRCelular.AutoSize = True
    Me.lblRCelular.Location = New System.Drawing.Point(958, 139)
    Me.lblRCelular.Name = "lblRCelular"
    Me.lblRCelular.Size = New System.Drawing.Size(39, 13)
    Me.lblRCelular.TabIndex = 174
    Me.lblRCelular.Text = "Celular"
    '
    'lblRConvenio
    '
    Me.lblRConvenio.AutoSize = True
    Me.lblRConvenio.Location = New System.Drawing.Point(635, 139)
    Me.lblRConvenio.Name = "lblRConvenio"
    Me.lblRConvenio.Size = New System.Drawing.Size(52, 13)
    Me.lblRConvenio.TabIndex = 172
    Me.lblRConvenio.Text = "Convênio"
    '
    'cmdDataChegada
    '
    Me.cmdDataChegada.Location = New System.Drawing.Point(754, 238)
    Me.cmdDataChegada.Name = "cmdDataChegada"
    Me.cmdDataChegada.Size = New System.Drawing.Size(21, 21)
    Me.cmdDataChegada.TabIndex = 182
    Me.cmdDataChegada.TabStop = False
    Me.cmdDataChegada.Text = ".."
    Me.cmdDataChegada.UseVisualStyleBackColor = True
    '
    'cmdDataSaida
    '
    Me.cmdDataSaida.Location = New System.Drawing.Point(900, 238)
    Me.cmdDataSaida.Name = "cmdDataSaida"
    Me.cmdDataSaida.Size = New System.Drawing.Size(21, 21)
    Me.cmdDataSaida.TabIndex = 181
    Me.cmdDataSaida.TabStop = False
    Me.cmdDataSaida.Text = ".."
    Me.cmdDataSaida.UseVisualStyleBackColor = True
    '
    'txtDataSaida
    '
    Me.txtDataSaida.Location = New System.Drawing.Point(781, 238)
    Me.txtDataSaida.MaskInput = "{date} {time}"
    Me.txtDataSaida.Name = "txtDataSaida"
    Me.txtDataSaida.Size = New System.Drawing.Size(119, 21)
    Me.txtDataSaida.TabIndex = 178
    '
    'txtDataChegada
    '
    Me.txtDataChegada.Location = New System.Drawing.Point(635, 238)
    Me.txtDataChegada.MaskInput = "{date} {time}"
    Me.txtDataChegada.Name = "txtDataChegada"
    Me.txtDataChegada.Size = New System.Drawing.Size(119, 21)
    Me.txtDataChegada.TabIndex = 177
    '
    'lblRSaida
    '
    Me.lblRSaida.AutoSize = True
    Me.lblRSaida.Location = New System.Drawing.Point(781, 223)
    Me.lblRSaida.Name = "lblRSaida"
    Me.lblRSaida.Size = New System.Drawing.Size(36, 13)
    Me.lblRSaida.TabIndex = 180
    Me.lblRSaida.Text = "Saída"
    '
    'lblRChegada
    '
    Me.lblRChegada.AutoSize = True
    Me.lblRChegada.Location = New System.Drawing.Point(635, 223)
    Me.lblRChegada.Name = "lblRChegada"
    Me.lblRChegada.Size = New System.Drawing.Size(50, 13)
    Me.lblRChegada.TabIndex = 179
    Me.lblRChegada.Text = "Chegada"
    '
    'txtComplemento
    '
    Me.txtComplemento.Location = New System.Drawing.Point(635, 322)
    Me.txtComplemento.MaxLength = 8000
    Me.txtComplemento.Multiline = True
    Me.txtComplemento.Name = "txtComplemento"
    Me.txtComplemento.Size = New System.Drawing.Size(493, 53)
    Me.txtComplemento.TabIndex = 183
    '
    'lblRComplemento
    '
    Me.lblRComplemento.AutoSize = True
    Me.lblRComplemento.Location = New System.Drawing.Point(635, 307)
    Me.lblRComplemento.Name = "lblRComplemento"
    Me.lblRComplemento.Size = New System.Drawing.Size(71, 13)
    Me.lblRComplemento.TabIndex = 184
    Me.lblRComplemento.Text = "Complemento"
    '
    'lblInformacoes
    '
    Me.lblInformacoes.Location = New System.Drawing.Point(885, 381)
    Me.lblInformacoes.Name = "lblInformacoes"
    Me.lblInformacoes.Size = New System.Drawing.Size(243, 86)
    Me.lblInformacoes.TabIndex = 197
    Me.lblInformacoes.Text = "lblInformacoes"
    '
    'lblEmEdicao
    '
    Me.lblEmEdicao.AutoSize = True
    Me.lblEmEdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEmEdicao.ForeColor = System.Drawing.Color.Red
    Me.lblEmEdicao.Location = New System.Drawing.Point(818, 381)
    Me.lblEmEdicao.Name = "lblEmEdicao"
    Me.lblEmEdicao.Size = New System.Drawing.Size(67, 13)
    Me.lblEmEdicao.TabIndex = 196
    Me.lblEmEdicao.Text = "Em Edição"
    '
    'chkAtualizarListagemAutomaticamente
    '
    Me.chkAtualizarListagemAutomaticamente.AutoSize = True
    Me.chkAtualizarListagemAutomaticamente.Location = New System.Drawing.Point(635, 422)
    Me.chkAtualizarListagemAutomaticamente.Name = "chkAtualizarListagemAutomaticamente"
    Me.chkAtualizarListagemAutomaticamente.Size = New System.Drawing.Size(196, 17)
    Me.chkAtualizarListagemAutomaticamente.TabIndex = 195
    Me.chkAtualizarListagemAutomaticamente.TabStop = False
    Me.chkAtualizarListagemAutomaticamente.Text = "Atualizar Listagem Automaticamente"
    Me.chkAtualizarListagemAutomaticamente.UseVisualStyleBackColor = True
    '
    'cmdExcluir
    '
    Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcluir.Location = New System.Drawing.Point(878, 479)
    Me.cmdExcluir.Name = "cmdExcluir"
    Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcluir.TabIndex = 193
    Me.cmdExcluir.Text = "Excluir"
    Me.cmdExcluir.UseVisualStyleBackColor = True
    '
    'cmdAtualizar
    '
    Me.cmdAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdAtualizar.Location = New System.Drawing.Point(635, 445)
    Me.cmdAtualizar.Name = "cmdAtualizar"
    Me.cmdAtualizar.Size = New System.Drawing.Size(75, 28)
    Me.cmdAtualizar.TabIndex = 192
    Me.cmdAtualizar.Text = "     Atualizar"
    Me.cmdAtualizar.UseVisualStyleBackColor = True
    '
    'cmdHistorico
    '
    Me.cmdHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdHistorico.Location = New System.Drawing.Point(716, 445)
    Me.cmdHistorico.Name = "cmdHistorico"
    Me.cmdHistorico.Size = New System.Drawing.Size(75, 28)
    Me.cmdHistorico.TabIndex = 189
    Me.cmdHistorico.Text = "    Histórico"
    Me.cmdHistorico.UseVisualStyleBackColor = True
    '
    'cmdRemarcar
    '
    Me.cmdRemarcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdRemarcar.Location = New System.Drawing.Point(635, 479)
    Me.cmdRemarcar.Name = "cmdRemarcar"
    Me.cmdRemarcar.Size = New System.Drawing.Size(75, 28)
    Me.cmdRemarcar.TabIndex = 187
    Me.cmdRemarcar.Text = "    Remarcar"
    Me.cmdRemarcar.UseVisualStyleBackColor = True
    '
    'cmdRetorno
    '
    Me.cmdRetorno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdRetorno.Location = New System.Drawing.Point(716, 479)
    Me.cmdRetorno.Name = "cmdRetorno"
    Me.cmdRetorno.Size = New System.Drawing.Size(75, 28)
    Me.cmdRetorno.TabIndex = 186
    Me.cmdRetorno.Text = "  Retorno"
    Me.cmdRetorno.UseVisualStyleBackColor = True
    '
    'cmdNovo
    '
    Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdNovo.Location = New System.Drawing.Point(797, 479)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
    Me.cmdNovo.TabIndex = 190
    Me.cmdNovo.Text = "  Novo"
    Me.cmdNovo.UseVisualStyleBackColor = True
    '
    'cmdGravar
    '
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(959, 479)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 191
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(1040, 479)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 194
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'cboEspecialdade
    '
    Me.cboEspecialdade.FormattingEnabled = True
    Me.cboEspecialdade.Location = New System.Drawing.Point(5, 2)
    Me.cboEspecialdade.Name = "cboEspecialdade"
    Me.cboEspecialdade.Size = New System.Drawing.Size(624, 21)
    Me.cboEspecialdade.TabIndex = 200
    Me.cboEspecialdade.TabStop = False
    '
    'Timer1
    '
    '
    'imlSmile
    '
    Me.imlSmile.ImageStream = CType(resources.GetObject("imlSmile.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imlSmile.TransparentColor = System.Drawing.Color.Transparent
    Me.imlSmile.Images.SetKeyName(0, "Agendamento_Agendado.ico")
    Me.imlSmile.Images.SetKeyName(1, "Agendamento_Atendido.ico")
    Me.imlSmile.Images.SetKeyName(2, "Agendamento_Atrasado.ico")
    Me.imlSmile.Images.SetKeyName(3, "Agendamento_Cancelado.ico")
    Me.imlSmile.Images.SetKeyName(4, "Agendamento_CanceladoClinica.ico")
    Me.imlSmile.Images.SetKeyName(5, "Agendamento_Compareceu.ico")
    '
    'cboEmpresa
    '
    Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEmpresa.FormattingEnabled = True
    Me.cboEmpresa.Location = New System.Drawing.Point(5, 48)
    Me.cboEmpresa.Name = "cboEmpresa"
    Me.cboEmpresa.Size = New System.Drawing.Size(624, 21)
    Me.cboEmpresa.TabIndex = 202
    Me.cboEmpresa.TabStop = False
    '
    'lblValorProcedimento
    '
    Me.lblValorProcedimento.AutoSize = True
    Me.lblValorProcedimento.ForeColor = System.Drawing.Color.Blue
    Me.lblValorProcedimento.Location = New System.Drawing.Point(869, 181)
    Me.lblValorProcedimento.Name = "lblValorProcedimento"
    Me.lblValorProcedimento.Size = New System.Drawing.Size(106, 13)
    Me.lblValorProcedimento.TabIndex = 203
    Me.lblValorProcedimento.Text = "lblValorProcedimento"
    '
    'cmdVenda
    '
    Me.cmdVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdVenda.Location = New System.Drawing.Point(797, 445)
    Me.cmdVenda.Name = "cmdVenda"
    Me.cmdVenda.Size = New System.Drawing.Size(75, 28)
    Me.cmdVenda.TabIndex = 213
    Me.cmdVenda.Text = "    Venda"
    Me.cmdVenda.UseVisualStyleBackColor = True
    '
    'lblSaldoConvenio
    '
    Me.lblSaldoConvenio.AutoSize = True
    Me.lblSaldoConvenio.ForeColor = System.Drawing.Color.Blue
    Me.lblSaldoConvenio.Location = New System.Drawing.Point(704, 139)
    Me.lblSaldoConvenio.Name = "lblSaldoConvenio"
    Me.lblSaldoConvenio.Size = New System.Drawing.Size(89, 13)
    Me.lblSaldoConvenio.TabIndex = 215
    Me.lblSaldoConvenio.Text = "lblSaldoConvenio"
    '
    'cboIndicador
    '
    Me.cboIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboIndicador.FormattingEnabled = True
    Me.cboIndicador.Location = New System.Drawing.Point(927, 238)
    Me.cboIndicador.Name = "cboIndicador"
    Me.cboIndicador.Size = New System.Drawing.Size(201, 21)
    Me.cboIndicador.TabIndex = 216
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(927, 223)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(51, 13)
    Me.Label1.TabIndex = 217
    Me.Label1.Text = "Indicador"
    '
    'cboCanalMarcacao
    '
    Me.cboCanalMarcacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCanalMarcacao.FormattingEnabled = True
    Me.cboCanalMarcacao.Location = New System.Drawing.Point(927, 280)
    Me.cboCanalMarcacao.Name = "cboCanalMarcacao"
    Me.cboCanalMarcacao.Size = New System.Drawing.Size(201, 21)
    Me.cboCanalMarcacao.TabIndex = 218
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(927, 265)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(100, 13)
    Me.Label2.TabIndex = 219
    Me.Label2.Text = "Canal de Marcação"
    '
    'picAlerta_Financeiro
    '
    Me.picAlerta_Financeiro.Location = New System.Drawing.Point(851, 396)
    Me.picAlerta_Financeiro.Name = "picAlerta_Financeiro"
    Me.picAlerta_Financeiro.Size = New System.Drawing.Size(16, 16)
    Me.picAlerta_Financeiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.picAlerta_Financeiro.TabIndex = 199
    Me.picAlerta_Financeiro.TabStop = False
    '
    'picAlerta_Aniversario
    '
    Me.picAlerta_Aniversario.Location = New System.Drawing.Point(833, 396)
    Me.picAlerta_Aniversario.Name = "picAlerta_Aniversario"
    Me.picAlerta_Aniversario.Size = New System.Drawing.Size(16, 16)
    Me.picAlerta_Aniversario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picAlerta_Aniversario.TabIndex = 198
    Me.picAlerta_Aniversario.TabStop = False
    '
    'cmdCelularWhatsApp
    '
    Me.cmdCelularWhatsApp.Image = Global.Cli28Julho.My.Resources.Resources.Mini_WhatsApp
    Me.cmdCelularWhatsApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdCelularWhatsApp.Location = New System.Drawing.Point(1058, 153)
    Me.cmdCelularWhatsApp.Name = "cmdCelularWhatsApp"
    Me.cmdCelularWhatsApp.Size = New System.Drawing.Size(22, 22)
    Me.cmdCelularWhatsApp.TabIndex = 176
    Me.cmdCelularWhatsApp.UseVisualStyleBackColor = True
    '
    'cmdTelefoneWhatsApp
    '
    Me.cmdTelefoneWhatsApp.Image = Global.Cli28Julho.My.Resources.Resources.Mini_WhatsApp
    Me.cmdTelefoneWhatsApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdTelefoneWhatsApp.Location = New System.Drawing.Point(930, 153)
    Me.cmdTelefoneWhatsApp.Name = "cmdTelefoneWhatsApp"
    Me.cmdTelefoneWhatsApp.Size = New System.Drawing.Size(22, 22)
    Me.cmdTelefoneWhatsApp.TabIndex = 175
    Me.cmdTelefoneWhatsApp.UseVisualStyleBackColor = True
    '
    'psqExecutor
    '
    Me.psqExecutor.AdicionarPessoa = False
    Me.psqExecutor.Bordas = True
    Me.psqExecutor.CarregarTodos = False
    Me.psqExecutor.DS_Pessoa = ""
    Me.psqExecutor.ID_Pessoa = 0
    Me.psqExecutor.LabelVisivel = True
    Me.psqExecutor.Location = New System.Drawing.Point(635, 265)
    Me.psqExecutor.Name = "psqExecutor"
    Me.psqExecutor.PesquisarPessoa = True
    Me.psqExecutor.Rotulo = "Executor"
    Me.psqExecutor.Size = New System.Drawing.Size(283, 36)
    Me.psqExecutor.SomenteLeitura = False
    Me.psqExecutor.TabIndex = 214
    Me.psqExecutor.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Funcionario
    '
    'psqProcedimento
    '
    Me.psqProcedimento.Bordas = True
    Me.psqProcedimento.Convenio = -1
    Me.psqProcedimento.GrupoProcedimento = 0
    Me.psqProcedimento.Identificador = 0
    Me.psqProcedimento.LabelVisivel = True
    Me.psqProcedimento.Location = New System.Drawing.Point(635, 181)
    Me.psqProcedimento.Name = "psqProcedimento"
    Me.psqProcedimento.Profissional = 0
    Me.psqProcedimento.Size = New System.Drawing.Size(493, 36)
    Me.psqProcedimento.TabIndex = 201
    '
    'psqPessoa
    '
    Me.psqPessoa.AdicionarPessoa = False
    Me.psqPessoa.Bordas = True
    Me.psqPessoa.CarregarTodos = False
    Me.psqPessoa.DS_Pessoa = ""
    Me.psqPessoa.ID_Pessoa = 0
    Me.psqPessoa.LabelVisivel = True
    Me.psqPessoa.Location = New System.Drawing.Point(635, 97)
    Me.psqPessoa.Name = "psqPessoa"
    Me.psqPessoa.PesquisarPessoa = True
    Me.psqPessoa.Rotulo = "Pessoa"
    Me.psqPessoa.Size = New System.Drawing.Size(493, 36)
    Me.psqPessoa.SomenteLeitura = False
    Me.psqPessoa.TabIndex = 168
    Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
    '
    'oVoucher
    '
    Me.oVoucher.Location = New System.Drawing.Point(635, 385)
    Me.oVoucher.Name = "oVoucher"
    Me.oVoucher.Size = New System.Drawing.Size(183, 21)
    Me.oVoucher.TabIndex = 220
    '
    'frmCadastroAgendamento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1135, 513)
    Me.Controls.Add(Me.oVoucher)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboCanalMarcacao)
    Me.Controls.Add(Me.cboIndicador)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblSaldoConvenio)
    Me.Controls.Add(Me.lblInformacoes)
    Me.Controls.Add(Me.psqExecutor)
    Me.Controls.Add(Me.cmdVenda)
    Me.Controls.Add(Me.lblValorProcedimento)
    Me.Controls.Add(Me.cboEmpresa)
    Me.Controls.Add(Me.psqProcedimento)
    Me.Controls.Add(Me.cboEspecialdade)
    Me.Controls.Add(Me.picAlerta_Financeiro)
    Me.Controls.Add(Me.picAlerta_Aniversario)
    Me.Controls.Add(Me.lblEmEdicao)
    Me.Controls.Add(Me.chkAtualizarListagemAutomaticamente)
    Me.Controls.Add(Me.cmdExcluir)
    Me.Controls.Add(Me.cmdAtualizar)
    Me.Controls.Add(Me.cmdHistorico)
    Me.Controls.Add(Me.cmdRemarcar)
    Me.Controls.Add(Me.cmdRetorno)
    Me.Controls.Add(Me.cmdNovo)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.txtComplemento)
    Me.Controls.Add(Me.lblRComplemento)
    Me.Controls.Add(Me.cmdDataChegada)
    Me.Controls.Add(Me.cmdDataSaida)
    Me.Controls.Add(Me.txtDataSaida)
    Me.Controls.Add(Me.txtDataChegada)
    Me.Controls.Add(Me.lblRSaida)
    Me.Controls.Add(Me.lblRChegada)
    Me.Controls.Add(Me.cmdCelularWhatsApp)
    Me.Controls.Add(Me.cmdTelefoneWhatsApp)
    Me.Controls.Add(Me.txtCelular)
    Me.Controls.Add(Me.txtTelefone)
    Me.Controls.Add(Me.cboConvenio)
    Me.Controls.Add(Me.lblRTelefone)
    Me.Controls.Add(Me.lblRCelular)
    Me.Controls.Add(Me.lblRConvenio)
    Me.Controls.Add(Me.psqPessoa)
    Me.Controls.Add(Me.lblRCodigo)
    Me.Controls.Add(Me.txtCodigo)
    Me.Controls.Add(Me.cboStatus)
    Me.Controls.Add(Me.txtDataAgendamento)
    Me.Controls.Add(Me.cboTipoAgendamento)
    Me.Controls.Add(Me.lblRTipoAgendamento)
    Me.Controls.Add(Me.lblRDataAgendamento)
    Me.Controls.Add(Me.lblRStatus)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.grdHorario)
    Me.Controls.Add(Me.cboProfissional)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroAgendamento"
    Me.Text = "Cadastro de Agendamento"
    CType(Me.grdHorario, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    CType(Me.txtDataAgendamento, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataSaida, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataChegada, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picAlerta_Financeiro, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picAlerta_Aniversario, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents grdHorario As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cboProfissional As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboAgendamentosParaEsseHorario As ComboBox
    Friend WithEvents lblRAgendamentosParaEsseHorario As Label
    Friend WithEvents lblRCodigo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtDataAgendamento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cboTipoAgendamento As ComboBox
    Friend WithEvents lblRTipoAgendamento As Label
    Friend WithEvents lblRDataAgendamento As Label
    Friend WithEvents lblRStatus As Label
    Friend WithEvents psqPessoa As uscPesqPessoa
    Friend WithEvents cmdCelularWhatsApp As Button
    Friend WithEvents cmdTelefoneWhatsApp As Button
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents cboConvenio As ComboBox
    Friend WithEvents lblRTelefone As Label
    Friend WithEvents lblRCelular As Label
    Friend WithEvents lblRConvenio As Label
    Friend WithEvents cmdDataChegada As Button
    Friend WithEvents cmdDataSaida As Button
    Friend WithEvents txtDataSaida As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtDataChegada As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRSaida As Label
    Friend WithEvents lblRChegada As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents lblRComplemento As Label
    Friend WithEvents picAlerta_Financeiro As PictureBox
    Friend WithEvents picAlerta_Aniversario As PictureBox
    Friend WithEvents lblInformacoes As Label
    Friend WithEvents lblEmEdicao As Label
    Friend WithEvents chkAtualizarListagemAutomaticamente As CheckBox
    Friend WithEvents cmdExcluir As Button
    Friend WithEvents cmdAtualizar As Button
    Friend WithEvents cmdHistorico As Button
    Friend WithEvents cmdRemarcar As Button
    Friend WithEvents cmdRetorno As Button
    Friend WithEvents cmdNovo As Button
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents cboEspecialdade As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents psqProcedimento As uscPesqProcedimento
    Friend WithEvents imlSmile As ImageList
    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents lblValorProcedimento As Label
    Friend WithEvents cmdVenda As Button
    Friend WithEvents psqExecutor As uscPesqPessoa
    Friend WithEvents lblSaldoConvenio As Label
    Friend WithEvents cboIndicador As ComboBox
    Friend WithEvents Label1 As Label
  Friend WithEvents cboCanalMarcacao As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents oVoucher As uscVoucher
End Class
