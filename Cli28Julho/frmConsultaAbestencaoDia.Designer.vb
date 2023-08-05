<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAbestencaoDia
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
    Me.cmdImprimir = New System.Windows.Forms.Button()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtDataAtendimentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataAtendimentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.cboStatus = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboCanalMarcacao = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtDataMarcacaoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataMarcacaoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.cboUsuarioMarcacao = New System.Windows.Forms.ComboBox()
    CType(Me.txtDataAtendimentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataAtendimentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataMarcacaoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataMarcacaoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cmdImprimir
    '
    Me.cmdImprimir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
    Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdImprimir.Location = New System.Drawing.Point(90, 452)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
    Me.cmdImprimir.TabIndex = 296
    Me.cmdImprimir.Text = "    Imprimir"
    Me.cmdImprimir.UseVisualStyleBackColor = True
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
    Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLimpar.Location = New System.Drawing.Point(958, 6)
    Me.cmdLimpar.Name = "cmdLimpar"
    Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
    Me.cmdLimpar.TabIndex = 295
    Me.cmdLimpar.Text = "Limpar"
    Me.cmdLimpar.UseVisualStyleBackColor = True
    '
    'cmdExcel
    '
    Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
    Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcel.Location = New System.Drawing.Point(9, 452)
    Me.cmdExcel.Name = "cmdExcel"
    Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcel.TabIndex = 287
    Me.cmdExcel.Text = "Excel"
    Me.cmdExcel.UseVisualStyleBackColor = True
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(958, 40)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 286
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(798, 25)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(13, 13)
    Me.Label7.TabIndex = 294
    Me.Label7.Text = "a"
    '
    'txtDataAtendimentoFinal
    '
    Me.txtDataAtendimentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataAtendimentoFinal.Location = New System.Drawing.Point(813, 21)
    Me.txtDataAtendimentoFinal.Name = "txtDataAtendimentoFinal"
    Me.txtDataAtendimentoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataAtendimentoFinal.TabIndex = 284
    Me.txtDataAtendimentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDataAtendimentoInicial
    '
    Me.txtDataAtendimentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataAtendimentoInicial.Location = New System.Drawing.Point(711, 21)
    Me.txtDataAtendimentoInicial.Name = "txtDataAtendimentoInicial"
    Me.txtDataAtendimentoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataAtendimentoInicial.TabIndex = 283
    Me.txtDataAtendimentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(711, 6)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(129, 13)
    Me.Label4.TabIndex = 293
    Me.Label4.Text = "Período de Agendamento"
    '
    'cboEmpresa
    '
    Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEmpresa.FormattingEnabled = True
    Me.cboEmpresa.Location = New System.Drawing.Point(9, 21)
    Me.cboEmpresa.Name = "cboEmpresa"
    Me.cboEmpresa.Size = New System.Drawing.Size(205, 21)
    Me.cboEmpresa.TabIndex = 281
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 6)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(48, 13)
    Me.Label2.TabIndex = 292
    Me.Label2.Text = "Empresa"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(220, 6)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(60, 13)
    Me.Label14.TabIndex = 291
    Me.Label14.Text = "Profissional"
    '
    'cboProfissional
    '
    Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissional.FormattingEnabled = True
    Me.cboProfissional.Location = New System.Drawing.Point(220, 21)
    Me.cboProfissional.Name = "cboProfissional"
    Me.cboProfissional.Size = New System.Drawing.Size(238, 21)
    Me.cboProfissional.TabIndex = 282
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(958, 452)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 288
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
    Me.grdListagem.Location = New System.Drawing.Point(9, 105)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(1024, 341)
    Me.grdListagem.TabIndex = 290
    Me.grdListagem.Text = "UltraGrid1"
    '
    'lblRListagemPessoa
    '
    Me.lblRListagemPessoa.AutoSize = True
    Me.lblRListagemPessoa.Location = New System.Drawing.Point(9, 90)
    Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
    Me.lblRListagemPessoa.Size = New System.Drawing.Size(131, 13)
    Me.lblRListagemPessoa.TabIndex = 289
    Me.lblRListagemPessoa.Tag = "Listagem de Lançamentos"
    Me.lblRListagemPessoa.Text = "Listagem de Lançamentos"
    '
    'cboStatus
    '
    Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboStatus.FormattingEnabled = True
    Me.cboStatus.Location = New System.Drawing.Point(9, 63)
    Me.cboStatus.Name = "cboStatus"
    Me.cboStatus.Size = New System.Drawing.Size(205, 21)
    Me.cboStatus.TabIndex = 297
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 48)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(37, 13)
    Me.Label1.TabIndex = 298
    Me.Label1.Text = "Status"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(220, 48)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(100, 13)
    Me.Label3.TabIndex = 300
    Me.Label3.Text = "Canal de Marcação"
    '
    'cboCanalMarcacao
    '
    Me.cboCanalMarcacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCanalMarcacao.FormattingEnabled = True
    Me.cboCanalMarcacao.Location = New System.Drawing.Point(220, 63)
    Me.cboCanalMarcacao.Name = "cboCanalMarcacao"
    Me.cboCanalMarcacao.Size = New System.Drawing.Size(238, 21)
    Me.cboCanalMarcacao.TabIndex = 299
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(798, 66)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(13, 13)
    Me.Label5.TabIndex = 304
    Me.Label5.Text = "a"
    '
    'txtDataMarcacaoFinal
    '
    Me.txtDataMarcacaoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataMarcacaoFinal.Location = New System.Drawing.Point(813, 62)
    Me.txtDataMarcacaoFinal.Name = "txtDataMarcacaoFinal"
    Me.txtDataMarcacaoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataMarcacaoFinal.TabIndex = 302
    Me.txtDataMarcacaoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDataMarcacaoInicial
    '
    Me.txtDataMarcacaoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataMarcacaoInicial.Location = New System.Drawing.Point(711, 62)
    Me.txtDataMarcacaoInicial.Name = "txtDataMarcacaoInicial"
    Me.txtDataMarcacaoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataMarcacaoInicial.TabIndex = 301
    Me.txtDataMarcacaoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(711, 47)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(111, 13)
    Me.Label6.TabIndex = 303
    Me.Label6.Text = "Período de Marcação"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(465, 6)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(109, 13)
    Me.Label8.TabIndex = 306
    Me.Label8.Text = "Usuário de Marcação"
    '
    'cboUsuarioMarcacao
    '
    Me.cboUsuarioMarcacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboUsuarioMarcacao.FormattingEnabled = True
    Me.cboUsuarioMarcacao.Location = New System.Drawing.Point(465, 21)
    Me.cboUsuarioMarcacao.Name = "cboUsuarioMarcacao"
    Me.cboUsuarioMarcacao.Size = New System.Drawing.Size(238, 21)
    Me.cboUsuarioMarcacao.TabIndex = 305
    '
    'frmConsultaAbestencaoDia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1038, 487)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.cboUsuarioMarcacao)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtDataMarcacaoFinal)
    Me.Controls.Add(Me.txtDataMarcacaoInicial)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.cboCanalMarcacao)
    Me.Controls.Add(Me.cboStatus)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.cmdExcel)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtDataAtendimentoFinal)
    Me.Controls.Add(Me.txtDataAtendimentoInicial)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cboEmpresa)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.cboProfissional)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.lblRListagemPessoa)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmConsultaAbestencaoDia"
    Me.Text = "Consulta de Dias de Abstenção"
    CType(Me.txtDataAtendimentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataAtendimentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataMarcacaoFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataMarcacaoInicial, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdImprimir As Button
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdExcel As Button
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents Label7 As Label
  Friend WithEvents txtDataAtendimentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataAtendimentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As Label
  Friend WithEvents cboEmpresa As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label14 As Label
  Friend WithEvents cboProfissional As ComboBox
  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As Label
  Friend WithEvents cboStatus As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents cboCanalMarcacao As ComboBox
  Friend WithEvents Label5 As Label
  Friend WithEvents txtDataMarcacaoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataMarcacaoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label6 As Label
  Friend WithEvents Label8 As Label
  Friend WithEvents cboUsuarioMarcacao As ComboBox
End Class
