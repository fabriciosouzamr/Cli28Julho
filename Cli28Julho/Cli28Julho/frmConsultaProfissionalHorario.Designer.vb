<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaProfissionalHorario
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
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.cboAtivo = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboDiasSemana = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdCalendario = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.chkBloqueado = New System.Windows.Forms.CheckBox()
        Me.cmdBloquearTodos = New System.Windows.Forms.Button()
        Me.cmdDesbloquearTodos = New System.Windows.Forms.Button()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Profissional"
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(5, 20)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(450, 21)
        Me.cboProfissional.TabIndex = 3
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(879, 55)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 21
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(248, 373)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 236
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdAlterar
        '
        Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAlterar.Location = New System.Drawing.Point(86, 373)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAlterar.TabIndex = 235
        Me.cmdAlterar.Text = "Alterar"
        Me.cmdAlterar.UseVisualStyleBackColor = True
        '
        'cmdNovo
        '
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(5, 373)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
        Me.cmdNovo.TabIndex = 234
        Me.cmdNovo.Text = "  Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(879, 373)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 237
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 104)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(949, 259)
        Me.grdListagem.TabIndex = 239
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 89)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(106, 13)
        Me.lblRListagemPessoa.TabIndex = 238
        Me.lblRListagemPessoa.Tag = "Listagem de Horários"
        Me.lblRListagemPessoa.Text = "Listagem de Horários"
        '
        'cboAtivo
        '
        Me.cboAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAtivo.FormattingEnabled = True
        Me.cboAtivo.Location = New System.Drawing.Point(575, 62)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Size = New System.Drawing.Size(108, 21)
        Me.cboAtivo.TabIndex = 240
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(575, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 241
        Me.Label4.Text = "Ativos?"
        '
        'cboDiasSemana
        '
        Me.cboDiasSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiasSemana.FormattingEnabled = True
        Me.cboDiasSemana.Location = New System.Drawing.Point(461, 62)
        Me.cboDiasSemana.Name = "cboDiasSemana"
        Me.cboDiasSemana.Size = New System.Drawing.Size(108, 21)
        Me.cboDiasSemana.TabIndex = 243
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(461, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 244
        Me.Label1.Text = "Dias da Semana"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(5, 62)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(450, 21)
        Me.cboEmpresa.TabIndex = 246
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "Empresa"
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = True
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.GrupoProcedimento = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = True
        Me.psqProcedimento.Location = New System.Drawing.Point(461, 5)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(493, 36)
        Me.psqProcedimento.TabIndex = 242
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(798, 55)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 267
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdCalendario
        '
        Me.cmdCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCalendario.Location = New System.Drawing.Point(329, 373)
        Me.cmdCalendario.Name = "cmdCalendario"
        Me.cmdCalendario.Size = New System.Drawing.Size(75, 28)
        Me.cmdCalendario.TabIndex = 268
        Me.cmdCalendario.Text = "Calendário"
        Me.cmdCalendario.UseVisualStyleBackColor = True
        '
        'cmdExcluir
        '
        Me.cmdExcluir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excluir2
        Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcluir.Location = New System.Drawing.Point(167, 373)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcluir.TabIndex = 269
        Me.cmdExcluir.Text = "Excluir"
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'chkBloqueado
        '
        Me.chkBloqueado.AutoSize = True
        Me.chkBloqueado.Location = New System.Drawing.Point(689, 67)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(77, 17)
        Me.chkBloqueado.TabIndex = 270
        Me.chkBloqueado.Text = "Bloqueado"
        Me.chkBloqueado.UseVisualStyleBackColor = True
        '
        'cmdBloquearTodos
        '
        Me.cmdBloquearTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBloquearTodos.Location = New System.Drawing.Point(410, 373)
        Me.cmdBloquearTodos.Name = "cmdBloquearTodos"
        Me.cmdBloquearTodos.Size = New System.Drawing.Size(90, 28)
        Me.cmdBloquearTodos.TabIndex = 271
        Me.cmdBloquearTodos.Text = "Bloquear Todos"
        Me.cmdBloquearTodos.UseVisualStyleBackColor = True
        '
        'cmdDesbloquearTodos
        '
        Me.cmdDesbloquearTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDesbloquearTodos.Location = New System.Drawing.Point(506, 373)
        Me.cmdDesbloquearTodos.Name = "cmdDesbloquearTodos"
        Me.cmdDesbloquearTodos.Size = New System.Drawing.Size(110, 28)
        Me.cmdDesbloquearTodos.TabIndex = 272
        Me.cmdDesbloquearTodos.Text = "Desbloquear Todos"
        Me.cmdDesbloquearTodos.UseVisualStyleBackColor = True
        '
        'frmConsultaProfissionalHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 406)
        Me.Controls.Add(Me.cmdDesbloquearTodos)
        Me.Controls.Add(Me.cmdBloquearTodos)
        Me.Controls.Add(Me.chkBloqueado)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.cmdCalendario)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboDiasSemana)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.psqProcedimento)
        Me.Controls.Add(Me.cboAtivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.cboProfissional)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConsultaProfissionalHorario"
        Me.Text = "Consulta de Horário de Profissional"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
  Friend WithEvents cboProfissional As ComboBox
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents cmdExcel As Button
  Friend WithEvents cmdAlterar As Button
  Friend WithEvents cmdNovo As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As Label
  Friend WithEvents cboAtivo As ComboBox
  Friend WithEvents Label4 As Label
  Friend WithEvents psqProcedimento As uscPesqProcedimento
  Friend WithEvents cboDiasSemana As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents cboEmpresa As ComboBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdCalendario As Button
    Friend WithEvents cmdExcluir As Button
    Friend WithEvents chkBloqueado As CheckBox
    Friend WithEvents cmdBloquearTodos As Button
    Friend WithEvents cmdDesbloquearTodos As Button
End Class
