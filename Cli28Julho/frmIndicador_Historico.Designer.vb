<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndicador_Historico
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
        Me.cboIndicador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRDataAgendamento = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTipoLancamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.lblRListagemPessoa = New System.Windows.Forms.Label()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.cmdLancamento = New System.Windows.Forms.Button()
        Me.cmdResgate = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.txtDataLancamentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtDataLancamentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.cmdLimpar = New System.Windows.Forms.Button()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataLancamentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataLancamentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboIndicador
        '
        Me.cboIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIndicador.FormattingEnabled = True
        Me.cboIndicador.Location = New System.Drawing.Point(5, 20)
        Me.cboIndicador.Name = "cboIndicador"
        Me.cboIndicador.Size = New System.Drawing.Size(450, 21)
        Me.cboIndicador.TabIndex = 263
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 262
        Me.Label1.Text = "Indicador"
        '
        'lblRDataAgendamento
        '
        Me.lblRDataAgendamento.AutoSize = True
        Me.lblRDataAgendamento.Location = New System.Drawing.Point(461, 5)
        Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
        Me.lblRDataAgendamento.Size = New System.Drawing.Size(122, 13)
        Me.lblRDataAgendamento.TabIndex = 265
        Me.lblRDataAgendamento.Text = "Período do Lançamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(546, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 267
        Me.Label2.Text = "a"
        '
        'cboTipoLancamento
        '
        Me.cboTipoLancamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoLancamento.FormattingEnabled = True
        Me.cboTipoLancamento.Location = New System.Drawing.Point(650, 20)
        Me.cboTipoLancamento.Name = "cboTipoLancamento"
        Me.cboTipoLancamento.Size = New System.Drawing.Size(130, 21)
        Me.cboTipoLancamento.TabIndex = 268
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(650, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 269
        Me.Label3.Text = "Tipo de Lançamento"
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(871, 13)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 270
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 62)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(941, 303)
        Me.grdListagem.TabIndex = 272
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 47)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(131, 13)
        Me.lblRListagemPessoa.TabIndex = 271
        Me.lblRListagemPessoa.Tag = "Listagem de Lançamentos"
        Me.lblRListagemPessoa.Text = "Listagem de Lançamentos"
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(871, 375)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 273
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdLancamento
        '
        Me.cmdLancamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLancamento.Location = New System.Drawing.Point(5, 375)
        Me.cmdLancamento.Name = "cmdLancamento"
        Me.cmdLancamento.Size = New System.Drawing.Size(86, 28)
        Me.cmdLancamento.TabIndex = 274
        Me.cmdLancamento.Text = "  Lançamento"
        Me.cmdLancamento.UseVisualStyleBackColor = True
        '
        'cmdResgate
        '
        Me.cmdResgate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdResgate.Location = New System.Drawing.Point(99, 375)
        Me.cmdResgate.Name = "cmdResgate"
        Me.cmdResgate.Size = New System.Drawing.Size(75, 28)
        Me.cmdResgate.TabIndex = 275
        Me.cmdResgate.Text = "  Resgate"
        Me.cmdResgate.UseVisualStyleBackColor = True
        '
        'cmdExcluir
        '
        Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcluir.Location = New System.Drawing.Point(180, 375)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcluir.TabIndex = 276
        Me.cmdExcluir.Text = "Excluir"
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'txtDataLancamentoFinal
        '
        Me.txtDataLancamentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataLancamentoFinal.Location = New System.Drawing.Point(559, 20)
        Me.txtDataLancamentoFinal.Name = "txtDataLancamentoFinal"
        Me.txtDataLancamentoFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataLancamentoFinal.TabIndex = 278
        Me.txtDataLancamentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtDataLancamentoInicial
        '
        Me.txtDataLancamentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataLancamentoInicial.Location = New System.Drawing.Point(461, 20)
        Me.txtDataLancamentoInicial.Name = "txtDataLancamentoInicial"
        Me.txtDataLancamentoInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataLancamentoInicial.TabIndex = 277
        Me.txtDataLancamentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(790, 13)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 279
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'frmIndicador_Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 410)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.txtDataLancamentoFinal)
        Me.Controls.Add(Me.txtDataLancamentoInicial)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.cmdResgate)
        Me.Controls.Add(Me.cmdLancamento)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTipoLancamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRDataAgendamento)
        Me.Controls.Add(Me.cboIndicador)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmIndicador_Historico"
        Me.Text = "Indicação - Histórico"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataLancamentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataLancamentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboIndicador As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRDataAgendamento As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboTipoLancamento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdPesquisar As Button
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblRListagemPessoa As Label
    Friend WithEvents cmdFechar As Button
    Friend WithEvents cmdLancamento As Button
    Friend WithEvents cmdResgate As Button
    Friend WithEvents cmdExcluir As Button
    Friend WithEvents txtDataLancamentoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtDataLancamentoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmdLimpar As Button
End Class
