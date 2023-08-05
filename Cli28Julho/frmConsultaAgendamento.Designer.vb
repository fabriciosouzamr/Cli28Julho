<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAgendamento
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
    Me.cmdExcluir = New System.Windows.Forms.Button()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.cboStatus = New System.Windows.Forms.ComboBox()
    Me.cboTipoAgendamento = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblRStatus = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdCancelar = New System.Windows.Forms.Button()
    Me.cmdRetorno = New System.Windows.Forms.Button()
    Me.cmdRemarcar = New System.Windows.Forms.Button()
    Me.chkPrimeiraSecao = New System.Windows.Forms.CheckBox()
    Me.cmdHistorico = New System.Windows.Forms.Button()
    Me.lblRCodigo = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdPDF = New System.Windows.Forms.Button()
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboDiaSemana = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cmdVenda = New System.Windows.Forms.Button()
    Me.cmdDisponibilidade = New System.Windows.Forms.Button()
    Me.cboGrupoProcedimento = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cboEspecialdade = New System.Windows.Forms.ComboBox()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtNrProntuario = New System.Windows.Forms.TextBox()
    Me.cmdPessoaExecutora = New System.Windows.Forms.Button()
        Me.cmdConfirmado = New System.Windows.Forms.Button()
        Me.cmdAguardandoAtendimento = New System.Windows.Forms.Button()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExcluir
        '
        Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcluir.Location = New System.Drawing.Point(167, 413)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcluir.TabIndex = 102
        Me.cmdExcluir.Text = "Excluir"
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAlterar.Location = New System.Drawing.Point(86, 413)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAlterar.TabIndex = 101
        Me.cmdAlterar.Text = "Alterar"
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'cmdNovo
        '
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(5, 413)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
        Me.cmdNovo.TabIndex = 100
        Me.cmdNovo.Text = "  Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(1062, 413)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 110
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 146)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(1132, 261)
        Me.grdListagem.TabIndex = 66
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 131)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(102, 13)
        Me.lblRListagemPessoa.TabIndex = 65
        Me.lblRListagemPessoa.Tag = "Listagem de Pessoa"
        Me.lblRListagemPessoa.Text = "Listagem de Pessoa"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.DropDownWidth = 200
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(688, 62)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(133, 21)
        Me.cboStatus.TabIndex = 4
        '
        'cboTipoAgendamento
        '
        Me.cboTipoAgendamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoAgendamento.FormattingEnabled = True
        Me.cboTipoAgendamento.Location = New System.Drawing.Point(374, 20)
        Me.cboTipoAgendamento.Name = "cboTipoAgendamento"
        Me.cboTipoAgendamento.Size = New System.Drawing.Size(119, 21)
        Me.cboTipoAgendamento.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Tipo de Agendamento"
        '
        'lblRStatus
        '
        Me.lblRStatus.AutoSize = True
        Me.lblRStatus.Location = New System.Drawing.Point(688, 47)
        Me.lblRStatus.Name = "lblRStatus"
        Me.lblRStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblRStatus.TabIndex = 80
        Me.lblRStatus.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(584, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "a"
        '
        'txtDataFinal
        '
        Me.txtDataFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataFinal.Location = New System.Drawing.Point(597, 62)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataFinal.TabIndex = 7
        Me.txtDataFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtDataInicial
        '
        Me.txtDataInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataInicial.Location = New System.Drawing.Point(499, 62)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataInicial.TabIndex = 6
        Me.txtDataInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(492, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Período de Agendamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(499, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Profissional"
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(499, 20)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(322, 21)
        Me.cboProfissional.TabIndex = 3
        '
        'cmdExcel
        '
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(734, 413)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 107
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(1062, 55)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 50
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(248, 413)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 104
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdRetorno
        '
        Me.cmdRetorno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRetorno.Location = New System.Drawing.Point(329, 413)
        Me.cmdRetorno.Name = "cmdRetorno"
        Me.cmdRetorno.Size = New System.Drawing.Size(75, 28)
        Me.cmdRetorno.TabIndex = 105
        Me.cmdRetorno.Text = "  Retorno"
        Me.cmdRetorno.UseVisualStyleBackColor = True
        '
        'cmdRemarcar
        '
        Me.cmdRemarcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRemarcar.Location = New System.Drawing.Point(410, 413)
        Me.cmdRemarcar.Name = "cmdRemarcar"
        Me.cmdRemarcar.Size = New System.Drawing.Size(75, 28)
        Me.cmdRemarcar.TabIndex = 106
        Me.cmdRemarcar.Text = "    Remarcar"
        Me.cmdRemarcar.UseVisualStyleBackColor = True
        '
        'chkPrimeiraSecao
        '
        Me.chkPrimeiraSecao.AutoSize = True
        Me.chkPrimeiraSecao.Location = New System.Drawing.Point(688, 85)
        Me.chkPrimeiraSecao.Name = "chkPrimeiraSecao"
        Me.chkPrimeiraSecao.Size = New System.Drawing.Size(97, 17)
        Me.chkPrimeiraSecao.TabIndex = 8
        Me.chkPrimeiraSecao.Text = "Primeira Seção"
        Me.chkPrimeiraSecao.UseVisualStyleBackColor = True
        '
        'cmdHistorico
        '
        Me.cmdHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHistorico.Location = New System.Drawing.Point(653, 413)
        Me.cmdHistorico.Name = "cmdHistorico"
        Me.cmdHistorico.Size = New System.Drawing.Size(75, 28)
        Me.cmdHistorico.TabIndex = 111
        Me.cmdHistorico.Text = "    Histórico"
        Me.cmdHistorico.UseVisualStyleBackColor = True
        '
        'lblRCodigo
        '
        Me.lblRCodigo.AutoSize = True
        Me.lblRCodigo.Location = New System.Drawing.Point(827, 4)
        Me.lblRCodigo.Name = "lblRCodigo"
        Me.lblRCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblRCodigo.TabIndex = 114
        Me.lblRCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(827, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(70, 20)
        Me.txtCodigo.TabIndex = 113
        Me.txtCodigo.TabStop = False
        '
        'cmdLimpar
        '
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(1062, 21)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 206
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdPDF
        '
        Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPDF.Location = New System.Drawing.Point(815, 413)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 207
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(5, 104)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(454, 21)
        Me.cboEmpresa.TabIndex = 208
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Filial"
        '
        'cboDiaSemana
        '
        Me.cboDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaSemana.DropDownWidth = 200
        Me.cboDiaSemana.FormattingEnabled = True
        Me.cboDiaSemana.Location = New System.Drawing.Point(465, 104)
        Me.cboDiaSemana.Name = "cboDiaSemana"
        Me.cboDiaSemana.Size = New System.Drawing.Size(92, 21)
        Me.cboDiaSemana.TabIndex = 210
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "Dia de Semana"
        '
        'cmdVenda
        '
        Me.cmdVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVenda.Location = New System.Drawing.Point(491, 413)
        Me.cmdVenda.Name = "cmdVenda"
        Me.cmdVenda.Size = New System.Drawing.Size(75, 28)
        Me.cmdVenda.TabIndex = 212
        Me.cmdVenda.Text = "    Venda"
        Me.cmdVenda.UseVisualStyleBackColor = True
        '
        'cmdDisponibilidade
        '
        Me.cmdDisponibilidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDisponibilidade.Location = New System.Drawing.Point(1037, 97)
        Me.cmdDisponibilidade.Name = "cmdDisponibilidade"
        Me.cmdDisponibilidade.Size = New System.Drawing.Size(100, 28)
        Me.cmdDisponibilidade.TabIndex = 213
        Me.cmdDisponibilidade.Text = "Disponibilidade"
        Me.cmdDisponibilidade.UseVisualStyleBackColor = True
        '
        'cboGrupoProcedimento
        '
        Me.cboGrupoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupoProcedimento.DropDownWidth = 200
        Me.cboGrupoProcedimento.FormattingEnabled = True
        Me.cboGrupoProcedimento.Location = New System.Drawing.Point(5, 62)
        Me.cboGrupoProcedimento.Name = "cboGrupoProcedimento"
        Me.cboGrupoProcedimento.Size = New System.Drawing.Size(119, 21)
        Me.cboGrupoProcedimento.TabIndex = 214
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "Grupo de Procedimento"
        '
        'cboEspecialdade
        '
        Me.cboEspecialdade.FormattingEnabled = True
        Me.cboEspecialdade.Location = New System.Drawing.Point(563, 104)
        Me.cboEspecialdade.Name = "cboEspecialdade"
        Me.cboEspecialdade.Size = New System.Drawing.Size(334, 21)
        Me.cboEspecialdade.TabIndex = 216
        Me.cboEspecialdade.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(563, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 217
        Me.Label8.Text = "Especialidade"
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = True
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.GrupoProcedimento = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = True
        Me.psqProcedimento.Location = New System.Drawing.Point(130, 47)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(363, 36)
        Me.psqProcedimento.TabIndex = 5
        '
        'psqPessoa
        '
        Me.psqPessoa.AdicionarPessoa = False
        Me.psqPessoa.Bordas = True
        Me.psqPessoa.CarregarTodos = False
        Me.psqPessoa.DS_Pessoa = ""
        Me.psqPessoa.ID_Pessoa = 0
        Me.psqPessoa.LabelVisivel = True
        Me.psqPessoa.Location = New System.Drawing.Point(5, 5)
        Me.psqPessoa.Name = "psqPessoa"
        Me.psqPessoa.PesquisarPessoa = True
        Me.psqPessoa.Rotulo = "Pessoa"
        Me.psqPessoa.Size = New System.Drawing.Size(363, 36)
        Me.psqPessoa.SomenteLeitura = False
        Me.psqPessoa.TabIndex = 1
        Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(827, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 219
        Me.Label9.Text = "Nº Prontuário"
        '
        'txtNrProntuario
        '
        Me.txtNrProntuario.Location = New System.Drawing.Point(827, 62)
        Me.txtNrProntuario.Name = "txtNrProntuario"
        Me.txtNrProntuario.Size = New System.Drawing.Size(70, 20)
        Me.txtNrProntuario.TabIndex = 218
        Me.txtNrProntuario.TabStop = False
        '
        'cmdPessoaExecutora
        '
        Me.cmdPessoaExecutora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPessoaExecutora.Location = New System.Drawing.Point(572, 413)
        Me.cmdPessoaExecutora.Name = "cmdPessoaExecutora"
        Me.cmdPessoaExecutora.Size = New System.Drawing.Size(75, 28)
        Me.cmdPessoaExecutora.TabIndex = 220
        Me.cmdPessoaExecutora.Text = "    Executora"
        Me.cmdPessoaExecutora.UseVisualStyleBackColor = True
        '
        'cmdConfirmado
        '
        Me.cmdConfirmado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdConfirmado.Location = New System.Drawing.Point(896, 413)
        Me.cmdConfirmado.Name = "cmdConfirmado"
        Me.cmdConfirmado.Size = New System.Drawing.Size(75, 28)
        Me.cmdConfirmado.TabIndex = 221
        Me.cmdConfirmado.Text = "  Confirmado"
        Me.cmdConfirmado.UseVisualStyleBackColor = True
        '
        'cmdAguardandoAtendimento
        '
        Me.cmdAguardandoAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAguardandoAtendimento.Location = New System.Drawing.Point(979, 413)
        Me.cmdAguardandoAtendimento.Name = "cmdAguardandoAtendimento"
        Me.cmdAguardandoAtendimento.Size = New System.Drawing.Size(75, 28)
        Me.cmdAguardandoAtendimento.TabIndex = 222
        Me.cmdAguardandoAtendimento.Text = "Ag. Atender"
        Me.cmdAguardandoAtendimento.UseVisualStyleBackColor = True
        '
        'frmConsultaAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 446)
        Me.Controls.Add(Me.cmdAguardandoAtendimento)
        Me.Controls.Add(Me.cmdConfirmado)
        Me.Controls.Add(Me.cmdPessoaExecutora)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNrProntuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboEspecialdade)
        Me.Controls.Add(Me.cboGrupoProcedimento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdDisponibilidade)
        Me.Controls.Add(Me.cmdVenda)
        Me.Controls.Add(Me.cboDiaSemana)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.lblRCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cmdHistorico)
        Me.Controls.Add(Me.psqProcedimento)
        Me.Controls.Add(Me.psqPessoa)
        Me.Controls.Add(Me.chkPrimeiraSecao)
        Me.Controls.Add(Me.cmdRemarcar)
        Me.Controls.Add(Me.cmdRetorno)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cboProfissional)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.txtDataInicial)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.cboTipoAgendamento)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRStatus)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmConsultaAgendamento"
        Me.Text = "Consulta de Agendamento"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents cmdExcluir As System.Windows.Forms.Button
  Friend WithEvents cmdAlterar As System.Windows.Forms.Button
  Friend WithEvents cmdNovo As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As System.Windows.Forms.Label
  Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
  Friend WithEvents cboTipoAgendamento As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblRStatus As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboProfissional As System.Windows.Forms.ComboBox
  Friend WithEvents cmdExcel As System.Windows.Forms.Button
  Friend WithEvents cmdCancelar As System.Windows.Forms.Button
  Friend WithEvents cmdRetorno As System.Windows.Forms.Button
  Friend WithEvents cmdRemarcar As System.Windows.Forms.Button
  Friend WithEvents chkPrimeiraSecao As System.Windows.Forms.CheckBox
  Friend WithEvents psqPessoa As uscPesqPessoa
  Friend WithEvents psqProcedimento As uscPesqProcedimento
  Friend WithEvents cmdHistorico As Button
  Friend WithEvents lblRCodigo As Label
  Friend WithEvents txtCodigo As TextBox
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdPDF As Button
  Friend WithEvents cboEmpresa As ComboBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cboDiaSemana As ComboBox
  Friend WithEvents Label5 As Label
  Friend WithEvents cmdVenda As Button
    Friend WithEvents cmdDisponibilidade As Button
    Friend WithEvents cboGrupoProcedimento As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboEspecialdade As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNrProntuario As TextBox
  Friend WithEvents cmdPessoaExecutora As Button
    Friend WithEvents cmdConfirmado As Button
    Friend WithEvents cmdAguardandoAtendimento As Button
End Class
