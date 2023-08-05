<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroTabelaPreco
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroTabelaPreco))
    Me.txtNomeTabelaPreco = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtDataInicioUso = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtDataFimUso = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.chkDisponivelFilial = New System.Windows.Forms.CheckBox()
    Me.lblRListagemProduto = New System.Windows.Forms.Label()
    Me.grdListagemProduto = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.txtMargemLucro = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.txtComissao = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtDescontoMaximo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.cboTabelaPrecoBase = New System.Windows.Forms.ComboBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.lblRAcrescimoDecrescimo = New System.Windows.Forms.Label()
    Me.txtPercAcrescimoDecrescimo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    CType(Me.txtDataInicioUso, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataFimUso, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdListagemProduto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMargemLucro, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtComissao, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDescontoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtPercAcrescimoDecrescimo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNomeTabelaPreco
    '
    Me.txtNomeTabelaPreco.Location = New System.Drawing.Point(5, 20)
    Me.txtNomeTabelaPreco.MaxLength = 100
    Me.txtNomeTabelaPreco.Name = "txtNomeTabelaPreco"
    Me.txtNomeTabelaPreco.Size = New System.Drawing.Size(500, 20)
    Me.txtNomeTabelaPreco.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(132, 13)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Nome da Tabela de Preço"
    '
    'txtDataInicioUso
    '
    Me.txtDataInicioUso.DateTime = New Date(2016, 9, 23, 0, 0, 0, 0)
    Me.txtDataInicioUso.Location = New System.Drawing.Point(511, 20)
    Me.txtDataInicioUso.Name = "txtDataInicioUso"
    Me.txtDataInicioUso.Size = New System.Drawing.Size(85, 21)
    Me.txtDataInicioUso.TabIndex = 2
    Me.txtDataInicioUso.Value = New Date(2016, 9, 23, 0, 0, 0, 0)
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(511, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(82, 13)
    Me.Label2.TabIndex = 22
    Me.Label2.Text = "Data Início Uso"
    '
    'txtDataFimUso
    '
    Me.txtDataFimUso.DateTime = New Date(2016, 9, 23, 0, 0, 0, 0)
    Me.txtDataFimUso.Location = New System.Drawing.Point(602, 20)
    Me.txtDataFimUso.Name = "txtDataFimUso"
    Me.txtDataFimUso.Size = New System.Drawing.Size(85, 21)
    Me.txtDataFimUso.TabIndex = 3
    Me.txtDataFimUso.Value = New Date(2016, 9, 23, 0, 0, 0, 0)
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(602, 5)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(101, 13)
    Me.Label3.TabIndex = 24
    Me.Label3.Text = "Data de Fim de Uso"
    '
    'chkDisponivelFilial
    '
    Me.chkDisponivelFilial.AutoSize = True
    Me.chkDisponivelFilial.Location = New System.Drawing.Point(709, 85)
    Me.chkDisponivelFilial.Name = "chkDisponivelFilial"
    Me.chkDisponivelFilial.Size = New System.Drawing.Size(100, 17)
    Me.chkDisponivelFilial.TabIndex = 9
    Me.chkDisponivelFilial.Text = "Disponível Filial"
    Me.chkDisponivelFilial.UseVisualStyleBackColor = True
    Me.chkDisponivelFilial.Visible = False
    '
    'lblRListagemProduto
    '
    Me.lblRListagemProduto.AutoSize = True
    Me.lblRListagemProduto.Location = New System.Drawing.Point(5, 89)
    Me.lblRListagemProduto.Name = "lblRListagemProduto"
    Me.lblRListagemProduto.Size = New System.Drawing.Size(190, 13)
    Me.lblRListagemProduto.TabIndex = 27
    Me.lblRListagemProduto.Text = "Listagem de Produto/Linha de Produto"
    '
    'grdListagemProduto
    '
    Appearance1.BackColor = System.Drawing.SystemColors.Window
    Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
    Me.grdListagemProduto.DisplayLayout.Appearance = Appearance1
    Me.grdListagemProduto.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Me.grdListagemProduto.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
    Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
    Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
    Appearance2.BorderColor = System.Drawing.SystemColors.Window
    Me.grdListagemProduto.DisplayLayout.GroupByBox.Appearance = Appearance2
    Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdListagemProduto.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
    Me.grdListagemProduto.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
    Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
    Appearance4.BackColor2 = System.Drawing.SystemColors.Control
    Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
    Me.grdListagemProduto.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
    Me.grdListagemProduto.DisplayLayout.MaxColScrollRegions = 1
    Me.grdListagemProduto.DisplayLayout.MaxRowScrollRegions = 1
    Appearance5.BackColor = System.Drawing.SystemColors.Window
    Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
    Me.grdListagemProduto.DisplayLayout.Override.ActiveCellAppearance = Appearance5
    Appearance6.BackColor = System.Drawing.SystemColors.Highlight
    Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.grdListagemProduto.DisplayLayout.Override.ActiveRowAppearance = Appearance6
    Me.grdListagemProduto.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
    Me.grdListagemProduto.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
    Appearance7.BackColor = System.Drawing.SystemColors.Window
    Me.grdListagemProduto.DisplayLayout.Override.CardAreaAppearance = Appearance7
    Appearance8.BorderColor = System.Drawing.Color.Silver
    Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
    Me.grdListagemProduto.DisplayLayout.Override.CellAppearance = Appearance8
    Me.grdListagemProduto.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
    Me.grdListagemProduto.DisplayLayout.Override.CellPadding = 0
    Appearance9.BackColor = System.Drawing.SystemColors.Control
    Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
    Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
    Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
    Appearance9.BorderColor = System.Drawing.SystemColors.Window
    Me.grdListagemProduto.DisplayLayout.Override.GroupByRowAppearance = Appearance9
    Appearance10.TextHAlignAsString = "Left"
    Me.grdListagemProduto.DisplayLayout.Override.HeaderAppearance = Appearance10
    Me.grdListagemProduto.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
    Me.grdListagemProduto.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
    Appearance11.BackColor = System.Drawing.SystemColors.Window
    Appearance11.BorderColor = System.Drawing.Color.Silver
    Me.grdListagemProduto.DisplayLayout.Override.RowAppearance = Appearance11
    Me.grdListagemProduto.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
    Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
    Me.grdListagemProduto.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
    Me.grdListagemProduto.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
    Me.grdListagemProduto.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
    Me.grdListagemProduto.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
    Me.grdListagemProduto.Location = New System.Drawing.Point(5, 104)
    Me.grdListagemProduto.Name = "grdListagemProduto"
    Me.grdListagemProduto.Size = New System.Drawing.Size(863, 360)
    Me.grdListagemProduto.TabIndex = 44
    Me.grdListagemProduto.Text = "UltraGrid1"
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(712, 474)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 100
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(793, 474)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'txtMargemLucro
    '
    Me.txtMargemLucro.Location = New System.Drawing.Point(709, 20)
    Me.txtMargemLucro.MaskInput = "{double:5.2}"
    Me.txtMargemLucro.Name = "txtMargemLucro"
    Me.txtMargemLucro.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
    Me.txtMargemLucro.PromptChar = Microsoft.VisualBasic.ChrW(32)
    Me.txtMargemLucro.Size = New System.Drawing.Size(48, 21)
    Me.txtMargemLucro.TabIndex = 4
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Location = New System.Drawing.Point(709, 5)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(90, 13)
    Me.Label25.TabIndex = 66
    Me.Label25.Text = "Margem de Lucro"
    '
    'txtComissao
    '
    Me.txtComissao.Location = New System.Drawing.Point(805, 20)
    Me.txtComissao.MaskInput = "{double:5.2}"
    Me.txtComissao.Name = "txtComissao"
    Me.txtComissao.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
    Me.txtComissao.PromptChar = Microsoft.VisualBasic.ChrW(32)
    Me.txtComissao.Size = New System.Drawing.Size(48, 21)
    Me.txtComissao.TabIndex = 5
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(805, 5)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(52, 13)
    Me.Label5.TabIndex = 77
    Me.Label5.Text = "Comissão"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(757, 24)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(15, 13)
    Me.Label6.TabIndex = 78
    Me.Label6.Text = "%"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(853, 24)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(15, 13)
    Me.Label7.TabIndex = 79
    Me.Label7.Text = "%"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(709, 47)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(92, 13)
    Me.Label8.TabIndex = 84
    Me.Label8.Text = "Desconto Máximo"
    '
    'txtDescontoMaximo
    '
    Me.txtDescontoMaximo.Location = New System.Drawing.Point(709, 62)
    Me.txtDescontoMaximo.MaskInput = "{double:5.2}"
    Me.txtDescontoMaximo.Name = "txtDescontoMaximo"
    Me.txtDescontoMaximo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
    Me.txtDescontoMaximo.PromptChar = Microsoft.VisualBasic.ChrW(32)
    Me.txtDescontoMaximo.Size = New System.Drawing.Size(48, 21)
    Me.txtDescontoMaximo.TabIndex = 8
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(757, 66)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(15, 13)
    Me.Label9.TabIndex = 85
    Me.Label9.Text = "%"
    '
    'cboTabelaPrecoBase
    '
    Me.cboTabelaPrecoBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTabelaPrecoBase.FormattingEnabled = True
    Me.cboTabelaPrecoBase.Location = New System.Drawing.Point(5, 62)
    Me.cboTabelaPrecoBase.Name = "cboTabelaPrecoBase"
    Me.cboTabelaPrecoBase.Size = New System.Drawing.Size(500, 21)
    Me.cboTabelaPrecoBase.TabIndex = 6
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(5, 47)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(128, 13)
    Me.Label10.TabIndex = 87
    Me.Label10.Text = "Tabela de Preço de Base"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(559, 66)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(15, 13)
    Me.Label11.TabIndex = 90
    Me.Label11.Text = "%"
    '
    'lblRAcrescimoDecrescimo
    '
    Me.lblRAcrescimoDecrescimo.AutoSize = True
    Me.lblRAcrescimoDecrescimo.Location = New System.Drawing.Point(511, 47)
    Me.lblRAcrescimoDecrescimo.Name = "lblRAcrescimoDecrescimo"
    Me.lblRAcrescimoDecrescimo.Size = New System.Drawing.Size(111, 13)
    Me.lblRAcrescimoDecrescimo.TabIndex = 89
    Me.lblRAcrescimoDecrescimo.Text = "Acréssimo/Decrécimo"
    '
    'txtPercAcrescimoDecrescimo
    '
    Me.txtPercAcrescimoDecrescimo.Location = New System.Drawing.Point(511, 62)
    Me.txtPercAcrescimoDecrescimo.MaskInput = "{double:5.2}"
    Me.txtPercAcrescimoDecrescimo.Name = "txtPercAcrescimoDecrescimo"
    Me.txtPercAcrescimoDecrescimo.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
    Me.txtPercAcrescimoDecrescimo.PromptChar = Microsoft.VisualBasic.ChrW(32)
    Me.txtPercAcrescimoDecrescimo.Size = New System.Drawing.Size(48, 21)
    Me.txtPercAcrescimoDecrescimo.TabIndex = 7
    '
    'frmCadastroTabelaPreco
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(873, 506)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.lblRAcrescimoDecrescimo)
    Me.Controls.Add(Me.txtPercAcrescimoDecrescimo)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.cboTabelaPrecoBase)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.txtDescontoMaximo)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtComissao)
    Me.Controls.Add(Me.txtMargemLucro)
    Me.Controls.Add(Me.Label25)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagemProduto)
    Me.Controls.Add(Me.lblRListagemProduto)
    Me.Controls.Add(Me.chkDisponivelFilial)
    Me.Controls.Add(Me.txtDataFimUso)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtDataInicioUso)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtNomeTabelaPreco)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmCadastroTabelaPreco"
    Me.Text = "Cadastro de Tabela de Preço"
    CType(Me.txtDataInicioUso, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataFimUso, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdListagemProduto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMargemLucro, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtComissao, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDescontoMaximo, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtPercAcrescimoDecrescimo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtNomeTabelaPreco As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtDataInicioUso As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtDataFimUso As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents chkDisponivelFilial As System.Windows.Forms.CheckBox
  Friend WithEvents lblRListagemProduto As System.Windows.Forms.Label
  Friend WithEvents grdListagemProduto As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents txtMargemLucro As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents txtComissao As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtDescontoMaximo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents cboTabelaPrecoBase As ComboBox
  Friend WithEvents Label10 As Label
  Friend WithEvents Label11 As Label
  Friend WithEvents lblRAcrescimoDecrescimo As Label
  Friend WithEvents txtPercAcrescimoDecrescimo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
End Class
