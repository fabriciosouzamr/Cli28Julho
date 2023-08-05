<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensagemModelo
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbsConfiguracaoProfissional = New System.Windows.Forms.TabPage()
        Me.grdProfssional = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.tbsMensagemAgradecimento = New System.Windows.Forms.TabPage()
        Me.oMensagemAgradecimento = New Cli28Julho.uscMensagemModelo()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.oMensagemAgradecimentoExame = New Cli28Julho.uscMensagemModelo()
        Me.tbsConfirmacaoAgenda = New System.Windows.Forms.TabPage()
        Me.oConfirmacaoAgendaInclusao = New Cli28Julho.uscMensagemModelo()
        Me.tbsConfirmacaoAgenda3dias = New System.Windows.Forms.TabPage()
        Me.oConfirmacaoAgenda3dias = New Cli28Julho.uscMensagemModelo()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.oConfirmacaoAgenda1dias = New Cli28Julho.uscMensagemModelo()
        Me.tbsConfirmacaoAgendaNoDias = New System.Windows.Forms.TabPage()
        Me.oConfirmacaoAgendaNoDias = New Cli28Julho.uscMensagemModelo()
        Me.tbsAniversarianteDia = New System.Windows.Forms.TabPage()
        Me.oAniversarianteDia = New Cli28Julho.uscMensagemModelo()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.tbsCancelamentoAgendamento = New System.Windows.Forms.TabPage()
        Me.oCancelamentoAgendamento = New Cli28Julho.uscMensagemModelo()
        Me.TabControl1.SuspendLayout()
        Me.tbsConfiguracaoProfissional.SuspendLayout()
        CType(Me.grdProfssional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbsMensagemAgradecimento.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tbsConfirmacaoAgenda.SuspendLayout()
        Me.tbsConfirmacaoAgenda3dias.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.tbsConfirmacaoAgendaNoDias.SuspendLayout()
        Me.tbsAniversarianteDia.SuspendLayout()
        Me.tbsCancelamentoAgendamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbsConfiguracaoProfissional)
        Me.TabControl1.Controls.Add(Me.tbsMensagemAgradecimento)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.tbsConfirmacaoAgenda)
        Me.TabControl1.Controls.Add(Me.tbsConfirmacaoAgenda3dias)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.tbsConfirmacaoAgendaNoDias)
        Me.TabControl1.Controls.Add(Me.tbsAniversarianteDia)
        Me.TabControl1.Controls.Add(Me.tbsCancelamentoAgendamento)
        Me.TabControl1.Location = New System.Drawing.Point(5, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1212, 526)
        Me.TabControl1.TabIndex = 0
        '
        'tbsConfiguracaoProfissional
        '
        Me.tbsConfiguracaoProfissional.Controls.Add(Me.grdProfssional)
        Me.tbsConfiguracaoProfissional.Location = New System.Drawing.Point(4, 22)
        Me.tbsConfiguracaoProfissional.Name = "tbsConfiguracaoProfissional"
        Me.tbsConfiguracaoProfissional.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbsConfiguracaoProfissional.Size = New System.Drawing.Size(1204, 500)
        Me.tbsConfiguracaoProfissional.TabIndex = 3
        Me.tbsConfiguracaoProfissional.Text = "Configuração do Profissional"
        Me.tbsConfiguracaoProfissional.UseVisualStyleBackColor = True
        '
        'grdProfssional
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdProfssional.DisplayLayout.Appearance = Appearance1
        Me.grdProfssional.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdProfssional.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdProfssional.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdProfssional.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdProfssional.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdProfssional.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdProfssional.DisplayLayout.MaxColScrollRegions = 1
        Me.grdProfssional.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProfssional.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdProfssional.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdProfssional.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdProfssional.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdProfssional.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdProfssional.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdProfssional.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdProfssional.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdProfssional.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdProfssional.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdProfssional.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdProfssional.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.grdProfssional.DisplayLayout.Override.RowAppearance = Appearance11
        Me.grdProfssional.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdProfssional.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.grdProfssional.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdProfssional.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdProfssional.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdProfssional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProfssional.Location = New System.Drawing.Point(3, 3)
        Me.grdProfssional.Name = "grdProfssional"
        Me.grdProfssional.Size = New System.Drawing.Size(1198, 494)
        Me.grdProfssional.TabIndex = 47
        Me.grdProfssional.Text = "UltraGrid1"
        '
        'tbsMensagemAgradecimento
        '
        Me.tbsMensagemAgradecimento.Controls.Add(Me.oMensagemAgradecimento)
        Me.tbsMensagemAgradecimento.Location = New System.Drawing.Point(4, 22)
        Me.tbsMensagemAgradecimento.Name = "tbsMensagemAgradecimento"
        Me.tbsMensagemAgradecimento.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbsMensagemAgradecimento.Size = New System.Drawing.Size(1204, 500)
        Me.tbsMensagemAgradecimento.TabIndex = 0
        Me.tbsMensagemAgradecimento.Text = "Mensagem de agradecimento"
        Me.tbsMensagemAgradecimento.UseVisualStyleBackColor = True
        '
        'oMensagemAgradecimento
        '
        Me.oMensagemAgradecimento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oMensagemAgradecimento.Location = New System.Drawing.Point(3, 3)
        Me.oMensagemAgradecimento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oMensagemAgradecimento.Name = "oMensagemAgradecimento"
        Me.oMensagemAgradecimento.Size = New System.Drawing.Size(1198, 494)
        Me.oMensagemAgradecimento.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.oMensagemAgradecimentoExame)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1204, 500)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "Mensagem de agradecimento c/ Exame"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'oMensagemAgradecimentoExame
        '
        Me.oMensagemAgradecimentoExame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oMensagemAgradecimentoExame.Location = New System.Drawing.Point(2, 2)
        Me.oMensagemAgradecimentoExame.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oMensagemAgradecimentoExame.Name = "oMensagemAgradecimentoExame"
        Me.oMensagemAgradecimentoExame.Size = New System.Drawing.Size(1200, 496)
        Me.oMensagemAgradecimentoExame.TabIndex = 1
        '
        'tbsConfirmacaoAgenda
        '
        Me.tbsConfirmacaoAgenda.Controls.Add(Me.oConfirmacaoAgendaInclusao)
        Me.tbsConfirmacaoAgenda.Location = New System.Drawing.Point(4, 22)
        Me.tbsConfirmacaoAgenda.Name = "tbsConfirmacaoAgenda"
        Me.tbsConfirmacaoAgenda.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbsConfirmacaoAgenda.Size = New System.Drawing.Size(1204, 500)
        Me.tbsConfirmacaoAgenda.TabIndex = 1
        Me.tbsConfirmacaoAgenda.Text = "Confir. da agenda - Inclusão"
        Me.tbsConfirmacaoAgenda.UseVisualStyleBackColor = True
        '
        'oConfirmacaoAgendaInclusao
        '
        Me.oConfirmacaoAgendaInclusao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oConfirmacaoAgendaInclusao.Location = New System.Drawing.Point(3, 3)
        Me.oConfirmacaoAgendaInclusao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oConfirmacaoAgendaInclusao.Name = "oConfirmacaoAgendaInclusao"
        Me.oConfirmacaoAgendaInclusao.Size = New System.Drawing.Size(1198, 494)
        Me.oConfirmacaoAgendaInclusao.TabIndex = 1
        '
        'tbsConfirmacaoAgenda3dias
        '
        Me.tbsConfirmacaoAgenda3dias.Controls.Add(Me.oConfirmacaoAgenda3dias)
        Me.tbsConfirmacaoAgenda3dias.Location = New System.Drawing.Point(4, 22)
        Me.tbsConfirmacaoAgenda3dias.Name = "tbsConfirmacaoAgenda3dias"
        Me.tbsConfirmacaoAgenda3dias.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbsConfirmacaoAgenda3dias.Size = New System.Drawing.Size(1204, 500)
        Me.tbsConfirmacaoAgenda3dias.TabIndex = 4
        Me.tbsConfirmacaoAgenda3dias.Text = "Confir. da agenda - 3 dia(s)"
        Me.tbsConfirmacaoAgenda3dias.UseVisualStyleBackColor = True
        '
        'oConfirmacaoAgenda3dias
        '
        Me.oConfirmacaoAgenda3dias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oConfirmacaoAgenda3dias.Location = New System.Drawing.Point(3, 3)
        Me.oConfirmacaoAgenda3dias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oConfirmacaoAgenda3dias.Name = "oConfirmacaoAgenda3dias"
        Me.oConfirmacaoAgenda3dias.Size = New System.Drawing.Size(1198, 494)
        Me.oConfirmacaoAgenda3dias.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.oConfirmacaoAgenda1dias)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(1204, 500)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Confir. da agenda - 1 dia(s)"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'oConfirmacaoAgenda1dias
        '
        Me.oConfirmacaoAgenda1dias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oConfirmacaoAgenda1dias.Location = New System.Drawing.Point(3, 3)
        Me.oConfirmacaoAgenda1dias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oConfirmacaoAgenda1dias.Name = "oConfirmacaoAgenda1dias"
        Me.oConfirmacaoAgenda1dias.Size = New System.Drawing.Size(1198, 494)
        Me.oConfirmacaoAgenda1dias.TabIndex = 2
        '
        'tbsConfirmacaoAgendaNoDias
        '
        Me.tbsConfirmacaoAgendaNoDias.Controls.Add(Me.oConfirmacaoAgendaNoDias)
        Me.tbsConfirmacaoAgendaNoDias.Location = New System.Drawing.Point(4, 22)
        Me.tbsConfirmacaoAgendaNoDias.Name = "tbsConfirmacaoAgendaNoDias"
        Me.tbsConfirmacaoAgendaNoDias.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbsConfirmacaoAgendaNoDias.Size = New System.Drawing.Size(1204, 500)
        Me.tbsConfirmacaoAgendaNoDias.TabIndex = 6
        Me.tbsConfirmacaoAgendaNoDias.Text = "Confir. da agenda - No dia(s)"
        Me.tbsConfirmacaoAgendaNoDias.UseVisualStyleBackColor = True
        '
        'oConfirmacaoAgendaNoDias
        '
        Me.oConfirmacaoAgendaNoDias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oConfirmacaoAgendaNoDias.Location = New System.Drawing.Point(3, 3)
        Me.oConfirmacaoAgendaNoDias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oConfirmacaoAgendaNoDias.Name = "oConfirmacaoAgendaNoDias"
        Me.oConfirmacaoAgendaNoDias.Size = New System.Drawing.Size(1198, 494)
        Me.oConfirmacaoAgendaNoDias.TabIndex = 2
        '
        'tbsAniversarianteDia
        '
        Me.tbsAniversarianteDia.Controls.Add(Me.oAniversarianteDia)
        Me.tbsAniversarianteDia.Location = New System.Drawing.Point(4, 22)
        Me.tbsAniversarianteDia.Name = "tbsAniversarianteDia"
        Me.tbsAniversarianteDia.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbsAniversarianteDia.Size = New System.Drawing.Size(1204, 500)
        Me.tbsAniversarianteDia.TabIndex = 2
        Me.tbsAniversarianteDia.Text = "AniversarianteDia"
        Me.tbsAniversarianteDia.UseVisualStyleBackColor = True
        '
        'oAniversarianteDia
        '
        Me.oAniversarianteDia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oAniversarianteDia.Location = New System.Drawing.Point(3, 3)
        Me.oAniversarianteDia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.oAniversarianteDia.Name = "oAniversarianteDia"
        Me.oAniversarianteDia.Size = New System.Drawing.Size(1198, 494)
        Me.oAniversarianteDia.TabIndex = 1
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(11, 537)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 504
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(92, 537)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 505
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'tbsCancelamentoAgendamento
        '
        Me.tbsCancelamentoAgendamento.Controls.Add(Me.oCancelamentoAgendamento)
        Me.tbsCancelamentoAgendamento.Location = New System.Drawing.Point(4, 22)
        Me.tbsCancelamentoAgendamento.Name = "tbsCancelamentoAgendamento"
        Me.tbsCancelamentoAgendamento.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsCancelamentoAgendamento.Size = New System.Drawing.Size(1204, 500)
        Me.tbsCancelamentoAgendamento.TabIndex = 8
        Me.tbsCancelamentoAgendamento.Text = "Cancelamento de Agendamento"
        Me.tbsCancelamentoAgendamento.UseVisualStyleBackColor = True
        '
        'oCancelamentoAgendamento
        '
        Me.oCancelamentoAgendamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.oCancelamentoAgendamento.Location = New System.Drawing.Point(3, 3)
        Me.oCancelamentoAgendamento.Margin = New System.Windows.Forms.Padding(4)
        Me.oCancelamentoAgendamento.Name = "oCancelamentoAgendamento"
        Me.oCancelamentoAgendamento.Size = New System.Drawing.Size(1198, 494)
        Me.oCancelamentoAgendamento.TabIndex = 2
        '
        'frmMensagemModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 578)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMensagemModelo"
        Me.Text = "Mensagem - Modelo"
        Me.TabControl1.ResumeLayout(False)
        Me.tbsConfiguracaoProfissional.ResumeLayout(False)
        CType(Me.grdProfssional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbsMensagemAgradecimento.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tbsConfirmacaoAgenda.ResumeLayout(False)
        Me.tbsConfirmacaoAgenda3dias.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.tbsConfirmacaoAgendaNoDias.ResumeLayout(False)
        Me.tbsAniversarianteDia.ResumeLayout(False)
        Me.tbsCancelamentoAgendamento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbsMensagemAgradecimento As TabPage
    Friend WithEvents tbsConfirmacaoAgenda As TabPage
    Friend WithEvents tbsAniversarianteDia As TabPage
    Friend WithEvents oMensagemAgradecimento As uscMensagemModelo
    Friend WithEvents oConfirmacaoAgendaInclusao As uscMensagemModelo
    Friend WithEvents oAniversarianteDia As uscMensagemModelo
    Friend WithEvents tbsConfiguracaoProfissional As TabPage
    Friend WithEvents tbsConfirmacaoAgenda3dias As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbsConfirmacaoAgendaNoDias As TabPage
    Friend WithEvents oConfirmacaoAgenda3dias As uscMensagemModelo
    Friend WithEvents oConfirmacaoAgenda1dias As uscMensagemModelo
    Friend WithEvents oConfirmacaoAgendaNoDias As uscMensagemModelo
    Friend WithEvents grdProfssional As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents oMensagemAgradecimentoExame As uscMensagemModelo
    Friend WithEvents tbsCancelamentoAgendamento As TabPage
    Friend WithEvents oCancelamentoAgendamento As uscMensagemModelo
End Class
