<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaExamesPrescritos
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
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtDataLancamentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.cboCidade = New System.Windows.Forms.ComboBox()
    Me.txtDataLancamentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.cboEspecialidade = New System.Windows.Forms.ComboBox()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    CType(Me.txtDataLancamentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataLancamentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
    Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLimpar.Location = New System.Drawing.Point(860, 19)
    Me.cmdLimpar.Name = "cmdLimpar"
    Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
    Me.cmdLimpar.TabIndex = 259
    Me.cmdLimpar.Text = "Limpar"
    Me.cmdLimpar.UseVisualStyleBackColor = True
    '
    'cmdExcel
    '
    Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
    Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcel.Location = New System.Drawing.Point(4, 416)
    Me.cmdExcel.Name = "cmdExcel"
    Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcel.TabIndex = 246
    Me.cmdExcel.Text = "Excel"
    Me.cmdExcel.UseVisualStyleBackColor = True
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(860, 54)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 244
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(91, 23)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(13, 13)
    Me.Label7.TabIndex = 254
    Me.Label7.Text = "a"
    '
    'txtDataLancamentoFinal
    '
    Me.txtDataLancamentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataLancamentoFinal.Location = New System.Drawing.Point(106, 19)
    Me.txtDataLancamentoFinal.Name = "txtDataLancamentoFinal"
    Me.txtDataLancamentoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataLancamentoFinal.TabIndex = 238
    Me.txtDataLancamentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(582, 46)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(40, 13)
    Me.Label6.TabIndex = 253
    Me.Label6.Text = "Cidade"
    '
    'cboCidade
    '
    Me.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCidade.FormattingEnabled = True
    Me.cboCidade.Location = New System.Drawing.Point(582, 61)
    Me.cboCidade.Name = "cboCidade"
    Me.cboCidade.Size = New System.Drawing.Size(168, 21)
    Me.cboCidade.TabIndex = 236
    '
    'txtDataLancamentoInicial
    '
    Me.txtDataLancamentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataLancamentoInicial.Location = New System.Drawing.Point(4, 19)
    Me.txtDataLancamentoInicial.Name = "txtDataLancamentoInicial"
    Me.txtDataLancamentoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataLancamentoInicial.TabIndex = 237
    Me.txtDataLancamentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(4, 4)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(115, 13)
    Me.Label4.TabIndex = 252
    Me.Label4.Text = "Período da Solicitação"
    '
    'cboProfissional
    '
    Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissional.FormattingEnabled = True
    Me.cboProfissional.Location = New System.Drawing.Point(197, 19)
    Me.cboProfissional.Name = "cboProfissional"
    Me.cboProfissional.Size = New System.Drawing.Size(379, 21)
    Me.cboProfissional.TabIndex = 234
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(197, 4)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(60, 13)
    Me.Label2.TabIndex = 251
    Me.Label2.Text = "Profissional"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(582, 4)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(73, 13)
    Me.Label14.TabIndex = 250
    Me.Label14.Text = "Especialidade"
    '
    'cboEspecialidade
    '
    Me.cboEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEspecialidade.FormattingEnabled = True
    Me.cboEspecialidade.Location = New System.Drawing.Point(582, 19)
    Me.cboEspecialidade.Name = "cboEspecialidade"
    Me.cboEspecialidade.Size = New System.Drawing.Size(168, 21)
    Me.cboEspecialidade.TabIndex = 235
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(860, 416)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 247
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'grdListagem
    '
    Appearance1.BackColor = System.Drawing.SystemColors.Window
    Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdListagem.DisplayLayout.Appearance = Appearance1
    Me.grdListagem.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdListagem.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance2.BorderColor = System.Drawing.SystemColors.Window
    Me.grdListagem.DisplayLayout.GroupByBox.Appearance = Appearance2
    Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdListagem.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
    Me.grdListagem.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance4.BackColor2 = System.Drawing.SystemColors.Control
    Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdListagem.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
    Me.grdListagem.DisplayLayout.MaxColScrollRegions = 1
    Me.grdListagem.DisplayLayout.MaxRowScrollRegions = 1
    Appearance5.BackColor = System.Drawing.SystemColors.Window
    Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdListagem.DisplayLayout.Override.ActiveCellAppearance = Appearance5
    Appearance6.BackColor = System.Drawing.SystemColors.Highlight
    Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdListagem.DisplayLayout.Override.ActiveRowAppearance = Appearance6
    Me.grdListagem.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdListagem.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance7.BackColor = System.Drawing.SystemColors.Window
    Me.grdListagem.DisplayLayout.Override.CardAreaAppearance = Appearance7
    Appearance8.BorderColor = System.Drawing.Color.Silver
    Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdListagem.DisplayLayout.Override.CellAppearance = Appearance8
    Me.grdListagem.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.grdListagem.DisplayLayout.Override.CellPadding = 0
    Appearance9.BackColor = System.Drawing.SystemColors.Control
    Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance9.BorderColor = System.Drawing.SystemColors.Window
    Me.grdListagem.DisplayLayout.Override.GroupByRowAppearance = Appearance9
    Appearance10.TextHAlignAsString = "Left"
    Me.grdListagem.DisplayLayout.Override.HeaderAppearance = Appearance10
    Me.grdListagem.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdListagem.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance11.BackColor = System.Drawing.SystemColors.Window
    Appearance11.BorderColor = System.Drawing.Color.Silver
    Me.grdListagem.DisplayLayout.Override.RowAppearance = Appearance11
    Me.grdListagem.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdListagem.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
    Me.grdListagem.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdListagem.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdListagem.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdListagem.Location = New System.Drawing.Point(4, 103)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(931, 303)
    Me.grdListagem.TabIndex = 249
    Me.grdListagem.Text = "UltraGrid1"
    '
    'lblRListagemPessoa
    '
    Me.lblRListagemPessoa.AutoSize = True
    Me.lblRListagemPessoa.Location = New System.Drawing.Point(4, 88)
    Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
    Me.lblRListagemPessoa.Size = New System.Drawing.Size(131, 13)
    Me.lblRListagemPessoa.TabIndex = 248
    Me.lblRListagemPessoa.Tag = "Listagem de Lançamentos"
    Me.lblRListagemPessoa.Text = "Listagem de Lançamentos"
    '
    'psqProcedimento
    '
    Me.psqProcedimento.Bordas = True
    Me.psqProcedimento.Convenio = 0
    Me.psqProcedimento.GrupoProcedimento = 0
    Me.psqProcedimento.Identificador = 0
    Me.psqProcedimento.LabelVisivel = True
    Me.psqProcedimento.Location = New System.Drawing.Point(4, 46)
    Me.psqProcedimento.Name = "psqProcedimento"
    Me.psqProcedimento.Profissional = 0
    Me.psqProcedimento.Size = New System.Drawing.Size(572, 36)
    Me.psqProcedimento.TabIndex = 261
    '
    'frmConsultaExamesPrescritos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(941, 449)
    Me.Controls.Add(Me.psqProcedimento)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.cmdExcel)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtDataLancamentoFinal)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cboCidade)
    Me.Controls.Add(Me.txtDataLancamentoInicial)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cboProfissional)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.cboEspecialidade)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.lblRListagemPessoa)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmConsultaExamesPrescritos"
    Me.Text = "Consulta de Exames Prescritos"
    CType(Me.txtDataLancamentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataLancamentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdExcel As Button
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents Label7 As Label
  Friend WithEvents txtDataLancamentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label6 As Label
  Friend WithEvents cboCidade As ComboBox
  Friend WithEvents txtDataLancamentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As Label
  Friend WithEvents cboProfissional As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label14 As Label
  Friend WithEvents cboEspecialidade As ComboBox
  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As Label
  Friend WithEvents psqProcedimento As uscPesqProcedimento
End Class
