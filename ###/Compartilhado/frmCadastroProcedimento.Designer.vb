<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroProcedimento
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
        Me.cboTipoProcedimento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.txtNomeProcedimento = New System.Windows.Forms.TextBox()
        Me.cboTabelaProcedimento = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipoExame = New System.Windows.Forms.ComboBox()
        Me.lblRTipoExame = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboGrupoProcedimento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdSelecionarTodas = New System.Windows.Forms.Button()
        Me.cboPlanoContas = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grdEspecialidade = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.cboClassificacaoExame = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboTipoConsultaPreferencial = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkGeraExameCitologico = New System.Windows.Forms.CheckBox()
        Me.psqExecutor = New Cli28Julho.uscPesqPessoa()
        Me.txtSisVida_CodigoExame = New System.Windows.Forms.TextBox()
        Me.txtSisVida_DescricaoExame = New System.Windows.Forms.TextBox()
        Me.txtSisVida_DescricaoMaterial = New System.Windows.Forms.TextBox()
        Me.txtSisVida_CodigoMaterial = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.grdEspecialidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipoProcedimento
        '
        Me.cboTipoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProcedimento.FormattingEnabled = True
        Me.cboTipoProcedimento.Location = New System.Drawing.Point(5, 186)
        Me.cboTipoProcedimento.Name = "cboTipoProcedimento"
        Me.cboTipoProcedimento.Size = New System.Drawing.Size(150, 21)
        Me.cboTipoProcedimento.TabIndex = 160
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Tipo de Procedimento"
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(681, 546)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 156
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(445, 129)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 154
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(600, 546)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 155
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'txtNomeProcedimento
        '
        Me.txtNomeProcedimento.Location = New System.Drawing.Point(5, 61)
        Me.txtNomeProcedimento.MaxLength = 100
        Me.txtNomeProcedimento.Name = "txtNomeProcedimento"
        Me.txtNomeProcedimento.Size = New System.Drawing.Size(746, 20)
        Me.txtNomeProcedimento.TabIndex = 153
        '
        'cboTabelaProcedimento
        '
        Me.cboTabelaProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTabelaProcedimento.FormattingEnabled = True
        Me.cboTabelaProcedimento.Location = New System.Drawing.Point(163, 20)
        Me.cboTabelaProcedimento.Name = "cboTabelaProcedimento"
        Me.cboTabelaProcedimento.Size = New System.Drawing.Size(588, 21)
        Me.cboTabelaProcedimento.TabIndex = 152
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(5, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(150, 20)
        Me.txtCodigo.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Nome do Procedimento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Tabela de Procedimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Código"
        '
        'cboTipoExame
        '
        Me.cboTipoExame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoExame.FormattingEnabled = True
        Me.cboTipoExame.Location = New System.Drawing.Point(161, 186)
        Me.cboTipoExame.Name = "cboTipoExame"
        Me.cboTipoExame.Size = New System.Drawing.Size(150, 21)
        Me.cboTipoExame.TabIndex = 162
        '
        'lblRTipoExame
        '
        Me.lblRTipoExame.AutoSize = True
        Me.lblRTipoExame.Location = New System.Drawing.Point(161, 171)
        Me.lblRTipoExame.Name = "lblRTipoExame"
        Me.lblRTipoExame.Size = New System.Drawing.Size(78, 13)
        Me.lblRTipoExame.TabIndex = 163
        Me.lblRTipoExame.Text = "Tipo de Exame"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Lista de Especialidade"
        '
        'cboGrupoProcedimento
        '
        Me.cboGrupoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupoProcedimento.FormattingEnabled = True
        Me.cboGrupoProcedimento.Location = New System.Drawing.Point(5, 102)
        Me.cboGrupoProcedimento.Name = "cboGrupoProcedimento"
        Me.cboGrupoProcedimento.Size = New System.Drawing.Size(434, 21)
        Me.cboGrupoProcedimento.TabIndex = 166
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Grupo de Procedimento"
        '
        'cmdSelecionarTodas
        '
        Me.cmdSelecionarTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSelecionarTodas.Location = New System.Drawing.Point(10, 546)
        Me.cmdSelecionarTodas.Name = "cmdSelecionarTodas"
        Me.cmdSelecionarTodas.Size = New System.Drawing.Size(116, 28)
        Me.cmdSelecionarTodas.TabIndex = 168
        Me.cmdSelecionarTodas.Text = "  Selecionar Todas"
        Me.cmdSelecionarTodas.UseVisualStyleBackColor = True
        '
        'cboPlanoContas
        '
        Me.cboPlanoContas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlanoContas.FormattingEnabled = True
        Me.cboPlanoContas.Location = New System.Drawing.Point(5, 144)
        Me.cboPlanoContas.Name = "cboPlanoContas"
        Me.cboPlanoContas.Size = New System.Drawing.Size(434, 21)
        Me.cboPlanoContas.TabIndex = 169
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Plano de Contas"
        '
        'grdEspecialidade
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdEspecialidade.DisplayLayout.Appearance = Appearance1
        Me.grdEspecialidade.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdEspecialidade.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdEspecialidade.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdEspecialidade.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdEspecialidade.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdEspecialidade.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdEspecialidade.DisplayLayout.MaxColScrollRegions = 1
        Me.grdEspecialidade.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdEspecialidade.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdEspecialidade.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdEspecialidade.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdEspecialidade.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdEspecialidade.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdEspecialidade.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdEspecialidade.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdEspecialidade.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdEspecialidade.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdEspecialidade.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdEspecialidade.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdEspecialidade.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.grdEspecialidade.DisplayLayout.Override.RowAppearance = Appearance11
        Me.grdEspecialidade.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdEspecialidade.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.grdEspecialidade.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdEspecialidade.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdEspecialidade.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdEspecialidade.Location = New System.Drawing.Point(5, 269)
        Me.grdEspecialidade.Name = "grdEspecialidade"
        Me.grdEspecialidade.Size = New System.Drawing.Size(752, 269)
        Me.grdEspecialidade.TabIndex = 171
        Me.grdEspecialidade.Text = "UltraGrid1"
        '
        'cboClassificacaoExame
        '
        Me.cboClassificacaoExame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClassificacaoExame.FormattingEnabled = True
        Me.cboClassificacaoExame.Location = New System.Drawing.Point(473, 186)
        Me.cboClassificacaoExame.Name = "cboClassificacaoExame"
        Me.cboClassificacaoExame.Size = New System.Drawing.Size(278, 21)
        Me.cboClassificacaoExame.TabIndex = 172
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(473, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "Classificação de Exame"
        '
        'cboTipoConsultaPreferencial
        '
        Me.cboTipoConsultaPreferencial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConsultaPreferencial.FormattingEnabled = True
        Me.cboTipoConsultaPreferencial.Location = New System.Drawing.Point(317, 186)
        Me.cboTipoConsultaPreferencial.Name = "cboTipoConsultaPreferencial"
        Me.cboTipoConsultaPreferencial.Size = New System.Drawing.Size(150, 21)
        Me.cboTipoConsultaPreferencial.TabIndex = 174
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(317, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Tipo de Consulta Preferencial"
        '
        'chkGeraExameCitologico
        '
        Me.chkGeraExameCitologico.AutoSize = True
        Me.chkGeraExameCitologico.Location = New System.Drawing.Point(445, 146)
        Me.chkGeraExameCitologico.Name = "chkGeraExameCitologico"
        Me.chkGeraExameCitologico.Size = New System.Drawing.Size(133, 17)
        Me.chkGeraExameCitologico.TabIndex = 178
        Me.chkGeraExameCitologico.Text = "Gera Exame Citológico"
        Me.chkGeraExameCitologico.UseVisualStyleBackColor = True
        '
        'psqExecutor
        '
        Me.psqExecutor.AdicionarPessoa = False
        Me.psqExecutor.Bordas = True
        Me.psqExecutor.CarregarTodos = False
        Me.psqExecutor.DS_Pessoa = ""
        Me.psqExecutor.ID_Pessoa = 0
        Me.psqExecutor.LabelVisivel = True
        Me.psqExecutor.Location = New System.Drawing.Point(445, 87)
        Me.psqExecutor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.psqExecutor.Name = "psqExecutor"
        Me.psqExecutor.PesquisarPessoa = True
        Me.psqExecutor.Rotulo = "Executor"
        Me.psqExecutor.Size = New System.Drawing.Size(306, 36)
        Me.psqExecutor.SomenteLeitura = False
        Me.psqExecutor.TabIndex = 216
        Me.psqExecutor.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Funcionario
        '
        'txtSisVida_CodigoExame
        '
        Me.txtSisVida_CodigoExame.Location = New System.Drawing.Point(5, 228)
        Me.txtSisVida_CodigoExame.Name = "txtSisVida_CodigoExame"
        Me.txtSisVida_CodigoExame.Size = New System.Drawing.Size(180, 20)
        Me.txtSisVida_CodigoExame.TabIndex = 217
        '
        'txtSisVida_DescicaoExame
        '
        Me.txtSisVida_DescricaoExame.Location = New System.Drawing.Point(191, 228)
        Me.txtSisVida_DescricaoExame.Name = "txtSisVida_DescicaoExame"
        Me.txtSisVida_DescricaoExame.Size = New System.Drawing.Size(180, 20)
        Me.txtSisVida_DescricaoExame.TabIndex = 218
        '
        'txtSisVida_DescricaoMaterial
        '
        Me.txtSisVida_DescricaoMaterial.Location = New System.Drawing.Point(563, 228)
        Me.txtSisVida_DescricaoMaterial.Name = "txtSisVida_DescricaoMaterial"
        Me.txtSisVida_DescricaoMaterial.Size = New System.Drawing.Size(188, 20)
        Me.txtSisVida_DescricaoMaterial.TabIndex = 220
        '
        'txtSisVida_CodigoMaterial
        '
        Me.txtSisVida_CodigoMaterial.Location = New System.Drawing.Point(377, 228)
        Me.txtSisVida_CodigoMaterial.Name = "txtSisVida_CodigoMaterial"
        Me.txtSisVida_CodigoMaterial.Size = New System.Drawing.Size(180, 20)
        Me.txtSisVida_CodigoMaterial.TabIndex = 219
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 221
        Me.Label10.Text = "SisVida - Código Exame"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(191, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 13)
        Me.Label11.TabIndex = 222
        Me.Label11.Text = "SisVida - Descrição Exame"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(377, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 13)
        Me.Label12.TabIndex = 223
        Me.Label12.Text = "SisVida - Código Material"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(563, 213)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 13)
        Me.Label13.TabIndex = 224
        Me.Label13.Text = "SisVida - Descrição Material"
        '
        'frmCadastroProcedimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSisVida_DescricaoMaterial)
        Me.Controls.Add(Me.txtSisVida_CodigoMaterial)
        Me.Controls.Add(Me.txtSisVida_DescricaoExame)
        Me.Controls.Add(Me.txtSisVida_CodigoExame)
        Me.Controls.Add(Me.psqExecutor)
        Me.Controls.Add(Me.chkGeraExameCitologico)
        Me.Controls.Add(Me.cboTipoConsultaPreferencial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboClassificacaoExame)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grdEspecialidade)
        Me.Controls.Add(Me.cboPlanoContas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdSelecionarTodas)
        Me.Controls.Add(Me.cboGrupoProcedimento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboTipoExame)
        Me.Controls.Add(Me.lblRTipoExame)
        Me.Controls.Add(Me.cboTipoProcedimento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.chkAtivo)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.txtNomeProcedimento)
        Me.Controls.Add(Me.cboTabelaProcedimento)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCadastroProcedimento"
        Me.Text = "Cadastro de Procedimento"
        CType(Me.grdEspecialidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboTipoProcedimento As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdFechar As Button
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents cmdGravar As Button
    Friend WithEvents txtNomeProcedimento As TextBox
    Friend WithEvents cboTabelaProcedimento As ComboBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTipoExame As ComboBox
    Friend WithEvents lblRTipoExame As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboGrupoProcedimento As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdSelecionarTodas As Button
    Friend WithEvents cboPlanoContas As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents grdEspecialidade As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cboClassificacaoExame As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboTipoConsultaPreferencial As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkGeraExameCitologico As CheckBox
    Friend WithEvents psqExecutor As uscPesqPessoa
    Friend WithEvents txtSisVida_CodigoExame As TextBox
    Friend WithEvents txtSisVida_DescricaoExame As TextBox
    Friend WithEvents txtSisVida_DescricaoMaterial As TextBox
    Friend WithEvents txtSisVida_CodigoMaterial As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
