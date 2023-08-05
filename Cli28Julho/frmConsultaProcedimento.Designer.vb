<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProcedimento
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
    Me.cboTabelaProcedimento = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdExcluir = New System.Windows.Forms.Button()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtNomeProcedimento = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboAtivo = New System.Windows.Forms.ComboBox()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdPDF = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cboTipoProcedimento = New System.Windows.Forms.ComboBox()
    Me.cboGrupoProcedimento = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboTabelaProcedimento
    '
    Me.cboTabelaProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTabelaProcedimento.FormattingEnabled = True
    Me.cboTabelaProcedimento.Location = New System.Drawing.Point(211, 60)
    Me.cboTabelaProcedimento.Name = "cboTabelaProcedimento"
    Me.cboTabelaProcedimento.Size = New System.Drawing.Size(250, 21)
    Me.cboTabelaProcedimento.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(211, 46)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(123, 13)
    Me.Label3.TabIndex = 143
    Me.Label3.Text = "Tabela de Procedimento"
    '
    'cmdExcel
    '
    Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
    Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcel.Location = New System.Drawing.Point(248, 410)
    Me.cmdExcel.Name = "cmdExcel"
    Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcel.TabIndex = 103
    Me.cmdExcel.Text = "Excel"
    Me.cmdExcel.UseVisualStyleBackColor = True
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(753, 53)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 5
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'cmdExcluir
    '
    Me.cmdExcluir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excluir2
    Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdExcluir.Location = New System.Drawing.Point(167, 410)
    Me.cmdExcluir.Name = "cmdExcluir"
    Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
    Me.cmdExcluir.TabIndex = 102
    Me.cmdExcluir.Text = "Excluir"
    Me.cmdExcluir.UseVisualStyleBackColor = True
    '
    'cmdAlterar
    '
    Me.cmdAlterar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Editar
    Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdAlterar.Location = New System.Drawing.Point(86, 410)
    Me.cmdAlterar.Name = "cmdAlterar"
    Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
    Me.cmdAlterar.TabIndex = 101
    Me.cmdAlterar.Text = "Alterar"
    Me.cmdAlterar.UseVisualStyleBackColor = True
    '
    'cmdNovo
    '
    Me.cmdNovo.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Novo
    Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdNovo.Location = New System.Drawing.Point(5, 410)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
    Me.cmdNovo.TabIndex = 100
    Me.cmdNovo.Text = "  Novo"
    Me.cmdNovo.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(753, 410)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 104
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 101)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(823, 303)
    Me.grdListagem.TabIndex = 133
    Me.grdListagem.Text = "UltraGrid1"
    '
    'lblRListagemPessoa
    '
    Me.lblRListagemPessoa.AutoSize = True
    Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 86)
    Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
    Me.lblRListagemPessoa.Size = New System.Drawing.Size(132, 13)
    Me.lblRListagemPessoa.TabIndex = 132
    Me.lblRListagemPessoa.Tag = "Listagem de Procedimento"
    Me.lblRListagemPessoa.Text = "Listagem de Procedimento"
    '
    'txtCodigo
    '
    Me.txtCodigo.Location = New System.Drawing.Point(5, 60)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(200, 20)
    Me.txtCodigo.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 46)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(40, 13)
    Me.Label2.TabIndex = 130
    Me.Label2.Text = "Código"
    '
    'txtNomeProcedimento
    '
    Me.txtNomeProcedimento.Location = New System.Drawing.Point(5, 20)
    Me.txtNomeProcedimento.MaxLength = 100
    Me.txtNomeProcedimento.Name = "txtNomeProcedimento"
    Me.txtNomeProcedimento.Size = New System.Drawing.Size(560, 20)
    Me.txtNomeProcedimento.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(118, 13)
    Me.Label1.TabIndex = 119
    Me.Label1.Text = "Nome do Procedimento"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(653, 46)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(42, 13)
    Me.Label4.TabIndex = 145
    Me.Label4.Text = "Ativos?"
    '
    'cboAtivo
    '
    Me.cboAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAtivo.FormattingEnabled = True
    Me.cboAtivo.Items.AddRange(New Object() {"Todos", "Sim", "Não"})
    Me.cboAtivo.Location = New System.Drawing.Point(653, 60)
    Me.cboAtivo.Name = "cboAtivo"
    Me.cboAtivo.Size = New System.Drawing.Size(76, 21)
    Me.cboAtivo.TabIndex = 2
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
    Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLimpar.Location = New System.Drawing.Point(753, 20)
    Me.cmdLimpar.Name = "cmdLimpar"
    Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
    Me.cmdLimpar.TabIndex = 234
    Me.cmdLimpar.Text = "Limpar"
    Me.cmdLimpar.UseVisualStyleBackColor = True
    '
    'cmdPDF
    '
    Me.cmdPDF.Image = Global.Cli28Julho.My.Resources.Resources.Mini_PDF
    Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPDF.Location = New System.Drawing.Point(329, 410)
    Me.cmdPDF.Name = "cmdPDF"
    Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
    Me.cmdPDF.TabIndex = 235
    Me.cmdPDF.Text = "     P.D.F."
    Me.cmdPDF.UseVisualStyleBackColor = True
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(571, 4)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(111, 13)
    Me.Label5.TabIndex = 237
    Me.Label5.Text = "Tipo de Procedimento"
    '
    'cboTipoProcedimento
    '
    Me.cboTipoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoProcedimento.FormattingEnabled = True
    Me.cboTipoProcedimento.Items.AddRange(New Object() {"Todos", "Sim", "Não"})
    Me.cboTipoProcedimento.Location = New System.Drawing.Point(571, 20)
    Me.cboTipoProcedimento.Name = "cboTipoProcedimento"
    Me.cboTipoProcedimento.Size = New System.Drawing.Size(158, 21)
    Me.cboTipoProcedimento.TabIndex = 236
    '
    'cboGrupoProcedimento
    '
    Me.cboGrupoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrupoProcedimento.FormattingEnabled = True
    Me.cboGrupoProcedimento.Location = New System.Drawing.Point(467, 60)
    Me.cboGrupoProcedimento.Name = "cboGrupoProcedimento"
    Me.cboGrupoProcedimento.Size = New System.Drawing.Size(180, 21)
    Me.cboGrupoProcedimento.TabIndex = 238
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(467, 46)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(119, 13)
    Me.Label6.TabIndex = 239
    Me.Label6.Text = "Grupo de Procedimento"
    '
    'frmConsultaProcedimento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(834, 443)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cboGrupoProcedimento)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.cboTipoProcedimento)
    Me.Controls.Add(Me.cmdPDF)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cboAtivo)
    Me.Controls.Add(Me.cboTabelaProcedimento)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.cmdExcel)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.cmdExcluir)
    Me.Controls.Add(Me.cmdAlterar)
    Me.Controls.Add(Me.cmdNovo)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.lblRListagemPessoa)
    Me.Controls.Add(Me.txtCodigo)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtNomeProcedimento)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.KeyPreview = True
    Me.Name = "frmConsultaProcedimento"
    Me.Text = "Consulta de Procedimento"
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboTabelaProcedimento As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cmdExcel As System.Windows.Forms.Button
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents cmdExcluir As System.Windows.Forms.Button
  Friend WithEvents cmdAlterar As System.Windows.Forms.Button
  Friend WithEvents cmdNovo As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtNomeProcedimento As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cboAtivo As System.Windows.Forms.ComboBox
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents cmdPDF As Button
  Friend WithEvents Label5 As Label
  Friend WithEvents cboTipoProcedimento As ComboBox
  Friend WithEvents cboGrupoProcedimento As ComboBox
  Friend WithEvents Label6 As Label
End Class
