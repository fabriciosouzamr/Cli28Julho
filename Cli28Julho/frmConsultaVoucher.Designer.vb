<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVoucher
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
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtDataUtilizacao_Fim = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataUtilizacao_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblRCodigo = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cmdPDF = New System.Windows.Forms.Button()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtDataVenda_Fim = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataVenda_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtDataCancelamento_Fim = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataCancelamento_Inicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.cmdCancelar = New System.Windows.Forms.Button()
    Me.cmdVoucher = New System.Windows.Forms.Button()
    Me.psqPessoaUtilizacao = New Cli28Julho.uscPesqPessoa()
    Me.psqPessoaAquisicao = New Cli28Julho.uscPesqPessoa()
    Me.cmdAutorizacao = New System.Windows.Forms.Button()
        Me.cmdHistorico = New System.Windows.Forms.Button()
        CType(Me.txtDataUtilizacao_Fim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataUtilizacao_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataVenda_Fim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataVenda_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataCancelamento_Fim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataCancelamento_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdImprimir
        '
        Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImprimir.Location = New System.Drawing.Point(329, 330)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
        Me.cmdImprimir.TabIndex = 293
        Me.cmdImprimir.Text = "    Imprimir"
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdLimpar
        '
        Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(772, 54)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 292
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(784, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 288
        Me.Label3.Text = "a"
        '
        'txtDataUtilizacao_Fim
        '
        Me.txtDataUtilizacao_Fim.Location = New System.Drawing.Point(799, 19)
        Me.txtDataUtilizacao_Fim.Name = "txtDataUtilizacao_Fim"
        Me.txtDataUtilizacao_Fim.Size = New System.Drawing.Size(85, 21)
        Me.txtDataUtilizacao_Fim.TabIndex = 287
        '
        'txtDataUtilizacao_Inicio
        '
        Me.txtDataUtilizacao_Inicio.Location = New System.Drawing.Point(697, 19)
        Me.txtDataUtilizacao_Inicio.Name = "txtDataUtilizacao_Inicio"
        Me.txtDataUtilizacao_Inicio.Size = New System.Drawing.Size(85, 21)
        Me.txtDataUtilizacao_Inicio.TabIndex = 282
        '
        'lblRCodigo
        '
        Me.lblRCodigo.AutoSize = True
        Me.lblRCodigo.Location = New System.Drawing.Point(697, 47)
        Me.lblRCodigo.Name = "lblRCodigo"
        Me.lblRCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblRCodigo.TabIndex = 280
        Me.lblRCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(697, 62)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigo.TabIndex = 279
        Me.txtCodigo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(697, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 281
        Me.Label2.Text = "Data de Utilizacação"
        '
        'cmdPDF
        '
        Me.cmdPDF.Image = Global.Cli28Julho.My.Resources.Resources.Mini_PDF
        Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPDF.Location = New System.Drawing.Point(248, 330)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 275
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(167, 330)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 271
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdNovo
        '
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(5, 330)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
        Me.cmdNovo.TabIndex = 269
        Me.cmdNovo.Text = "  Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(853, 330)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 272
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 103)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(923, 221)
        Me.grdListagem.TabIndex = 274
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 88)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(106, 13)
        Me.lblRListagemPessoa.TabIndex = 273
        Me.lblRListagemPessoa.Tag = "Listagem de Horários"
        Me.lblRListagemPessoa.Text = "Listagem de Horários"
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(853, 54)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 268
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(591, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "a"
        '
        'txtDataVenda_Fim
        '
        Me.txtDataVenda_Fim.Location = New System.Drawing.Point(606, 19)
        Me.txtDataVenda_Fim.Name = "txtDataVenda_Fim"
        Me.txtDataVenda_Fim.Size = New System.Drawing.Size(85, 21)
        Me.txtDataVenda_Fim.TabIndex = 296
        '
        'txtDataVenda_Inicio
        '
        Me.txtDataVenda_Inicio.Location = New System.Drawing.Point(504, 19)
        Me.txtDataVenda_Inicio.Name = "txtDataVenda_Inicio"
        Me.txtDataVenda_Inicio.Size = New System.Drawing.Size(85, 21)
        Me.txtDataVenda_Inicio.TabIndex = 295
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(504, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 294
        Me.Label7.Text = "Data de Venda"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(591, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 301
        Me.Label8.Text = "a"
        '
        'txtDataCancelamento_Fim
        '
        Me.txtDataCancelamento_Fim.Location = New System.Drawing.Point(606, 61)
        Me.txtDataCancelamento_Fim.Name = "txtDataCancelamento_Fim"
        Me.txtDataCancelamento_Fim.Size = New System.Drawing.Size(85, 21)
        Me.txtDataCancelamento_Fim.TabIndex = 300
        '
        'txtDataCancelamento_Inicio
        '
        Me.txtDataCancelamento_Inicio.Location = New System.Drawing.Point(504, 61)
        Me.txtDataCancelamento_Inicio.Name = "txtDataCancelamento_Inicio"
        Me.txtDataCancelamento_Inicio.Size = New System.Drawing.Size(85, 21)
        Me.txtDataCancelamento_Inicio.TabIndex = 299
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(504, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 298
        Me.Label9.Text = "Data de Cancelamento"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(86, 330)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 303
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdVoucher
        '
        Me.cmdVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVoucher.Location = New System.Drawing.Point(410, 330)
        Me.cmdVoucher.Name = "cmdVoucher"
        Me.cmdVoucher.Size = New System.Drawing.Size(75, 28)
        Me.cmdVoucher.TabIndex = 304
        Me.cmdVoucher.Text = "    Voucher"
        Me.cmdVoucher.UseVisualStyleBackColor = True
        '
        'psqPessoaUtilizacao
        '
        Me.psqPessoaUtilizacao.AdicionarPessoa = False
        Me.psqPessoaUtilizacao.Bordas = True
        Me.psqPessoaUtilizacao.CarregarTodos = False
        Me.psqPessoaUtilizacao.DS_Pessoa = ""
        Me.psqPessoaUtilizacao.ID_Pessoa = 0
        Me.psqPessoaUtilizacao.LabelVisivel = True
        Me.psqPessoaUtilizacao.Location = New System.Drawing.Point(5, 46)
        Me.psqPessoaUtilizacao.Name = "psqPessoaUtilizacao"
        Me.psqPessoaUtilizacao.PesquisarPessoa = True
        Me.psqPessoaUtilizacao.Rotulo = "Pessoa Utilização"
        Me.psqPessoaUtilizacao.Size = New System.Drawing.Size(493, 36)
        Me.psqPessoaUtilizacao.SomenteLeitura = False
        Me.psqPessoaUtilizacao.TabIndex = 302
        Me.psqPessoaUtilizacao.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'psqPessoaAquisicao
        '
        Me.psqPessoaAquisicao.AdicionarPessoa = False
        Me.psqPessoaAquisicao.Bordas = True
        Me.psqPessoaAquisicao.CarregarTodos = False
        Me.psqPessoaAquisicao.DS_Pessoa = ""
        Me.psqPessoaAquisicao.ID_Pessoa = 0
        Me.psqPessoaAquisicao.LabelVisivel = True
        Me.psqPessoaAquisicao.Location = New System.Drawing.Point(5, 4)
        Me.psqPessoaAquisicao.Name = "psqPessoaAquisicao"
        Me.psqPessoaAquisicao.PesquisarPessoa = True
        Me.psqPessoaAquisicao.Rotulo = "Pessoa Aquisição"
        Me.psqPessoaAquisicao.Size = New System.Drawing.Size(493, 36)
        Me.psqPessoaAquisicao.SomenteLeitura = False
        Me.psqPessoaAquisicao.TabIndex = 276
        Me.psqPessoaAquisicao.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
        '
        'cmdAutorizacao
        '
        Me.cmdAutorizacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAutorizacao.Location = New System.Drawing.Point(491, 330)
        Me.cmdAutorizacao.Name = "cmdAutorizacao"
        Me.cmdAutorizacao.Size = New System.Drawing.Size(75, 28)
        Me.cmdAutorizacao.TabIndex = 305
        Me.cmdAutorizacao.Text = "Autorização"
        Me.cmdAutorizacao.UseVisualStyleBackColor = True
        '
        'cmdHistorico
        '
        Me.cmdHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHistorico.Location = New System.Drawing.Point(572, 330)
        Me.cmdHistorico.Name = "cmdHistorico"
        Me.cmdHistorico.Size = New System.Drawing.Size(75, 28)
        Me.cmdHistorico.TabIndex = 306
        Me.cmdHistorico.Text = "    Histórico"
        Me.cmdHistorico.UseVisualStyleBackColor = True
        '
        'frmConsultaVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 363)
        Me.Controls.Add(Me.cmdHistorico)
        Me.Controls.Add(Me.cmdAutorizacao)
        Me.Controls.Add(Me.cmdVoucher)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.psqPessoaUtilizacao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDataCancelamento_Fim)
        Me.Controls.Add(Me.txtDataCancelamento_Inicio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDataVenda_Fim)
        Me.Controls.Add(Me.txtDataVenda_Inicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDataUtilizacao_Fim)
        Me.Controls.Add(Me.txtDataUtilizacao_Inicio)
        Me.Controls.Add(Me.lblRCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.psqPessoaAquisicao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaVoucher"
        Me.Text = "Consulta de Voucher"
        CType(Me.txtDataUtilizacao_Fim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataUtilizacao_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataVenda_Fim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataVenda_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataCancelamento_Fim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataCancelamento_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdImprimir As Button
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents Label3 As Label
  Friend WithEvents txtDataUtilizacao_Fim As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataUtilizacao_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents lblRCodigo As Label
  Friend WithEvents txtCodigo As TextBox
  Friend WithEvents psqPessoaAquisicao As uscPesqPessoa
  Friend WithEvents Label2 As Label
  Friend WithEvents cmdPDF As Button
  Friend WithEvents cmdExcel As Button
  Friend WithEvents cmdNovo As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As Label
  Friend WithEvents cmdPesquisar As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents txtDataVenda_Fim As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataVenda_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label7 As Label
  Friend WithEvents Label8 As Label
  Friend WithEvents txtDataCancelamento_Fim As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataCancelamento_Inicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label9 As Label
  Friend WithEvents psqPessoaUtilizacao As uscPesqPessoa
  Friend WithEvents cmdCancelar As Button
  Friend WithEvents cmdVoucher As Button
  Friend WithEvents cmdAutorizacao As Button
    Friend WithEvents cmdHistorico As Button
End Class
