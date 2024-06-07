<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaMinhasFaturas
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
        Me.cmdPDF = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPeriodoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtPeriodoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdLimpar = New System.Windows.Forms.Button()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.lblRListagemPessoa = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.optTotal = New System.Windows.Forms.RadioButton()
        Me.optExames = New System.Windows.Forms.RadioButton()
        Me.optConsultas = New System.Windows.Forms.RadioButton()
        CType(Me.txtPeriodoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPeriodoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPDF
        '
        Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPDF.Location = New System.Drawing.Point(86, 362)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 359
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 349
        Me.Label7.Text = "a"
        '
        'txtPeriodoFinal
        '
        Me.txtPeriodoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtPeriodoFinal.Location = New System.Drawing.Point(107, 20)
        Me.txtPeriodoFinal.Name = "txtPeriodoFinal"
        Me.txtPeriodoFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtPeriodoFinal.TabIndex = 347
        Me.txtPeriodoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtPeriodoInicial
        '
        Me.txtPeriodoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtPeriodoInicial.Location = New System.Drawing.Point(5, 20)
        Me.txtPeriodoInicial.Name = "txtPeriodoInicial"
        Me.txtPeriodoInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtPeriodoInicial.TabIndex = 346
        Me.txtPeriodoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 348
        Me.Label5.Text = "Período"
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(905, 5)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 345
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(5, 362)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 340
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(905, 39)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 339
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(905, 362)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 341
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 70)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(975, 286)
        Me.grdListagem.TabIndex = 343
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 54)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(49, 13)
        Me.lblRListagemPessoa.TabIndex = 342
        Me.lblRListagemPessoa.Tag = "Listagem"
        Me.lblRListagemPessoa.Text = "Listagem"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.optTotal)
        Me.Panel1.Controls.Add(Me.optExames)
        Me.Panel1.Controls.Add(Me.optConsultas)
        Me.Panel1.Location = New System.Drawing.Point(198, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 39)
        Me.Panel1.TabIndex = 360
        '
        'optTotal
        '
        Me.optTotal.AutoSize = True
        Me.optTotal.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.optTotal.Location = New System.Drawing.Point(120, 3)
        Me.optTotal.Name = "optTotal"
        Me.optTotal.Size = New System.Drawing.Size(35, 30)
        Me.optTotal.TabIndex = 2
        Me.optTotal.TabStop = True
        Me.optTotal.Text = "Total"
        Me.optTotal.UseVisualStyleBackColor = True
        '
        'optExames
        '
        Me.optExames.AutoSize = True
        Me.optExames.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.optExames.Location = New System.Drawing.Point(66, 3)
        Me.optExames.Name = "optExames"
        Me.optExames.Size = New System.Drawing.Size(48, 30)
        Me.optExames.TabIndex = 1
        Me.optExames.TabStop = True
        Me.optExames.Text = "Exames"
        Me.optExames.UseVisualStyleBackColor = True
        '
        'optConsultas
        '
        Me.optConsultas.AutoSize = True
        Me.optConsultas.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.optConsultas.Location = New System.Drawing.Point(3, 3)
        Me.optConsultas.Name = "optConsultas"
        Me.optConsultas.Size = New System.Drawing.Size(57, 30)
        Me.optConsultas.TabIndex = 0
        Me.optConsultas.TabStop = True
        Me.optConsultas.Text = "Consultas"
        Me.optConsultas.UseVisualStyleBackColor = True
        '
        'frmConsultaMinhasFaturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 396)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPeriodoFinal)
        Me.Controls.Add(Me.txtPeriodoInicial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmConsultaMinhasFaturas"
        Me.Text = "Médicos - Minhas Faturas"
        CType(Me.txtPeriodoFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPeriodoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPDF As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPeriodoFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtPeriodoInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdLimpar As Button
    Friend WithEvents cmdExcel As Button
    Friend WithEvents cmdPesquisar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblRListagemPessoa As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents optConsultas As RadioButton
    Friend WithEvents optTotal As RadioButton
    Friend WithEvents optExames As RadioButton
End Class
