﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaOcupacaoTempoPrevisto
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
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtDataAtendimentoFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataAtendimentoInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.lblRListagemPessoa = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.lblTempo = New System.Windows.Forms.Label()
    Me.lblTermino = New System.Windows.Forms.Label()
    Me.lblInicio = New System.Windows.Forms.Label()
    Me.lblQuantidade = New System.Windows.Forms.Label()
    Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
    Me.cmdImprimir = New System.Windows.Forms.Button()
    Me.cmdLimpar = New System.Windows.Forms.Button()
    Me.cmdExcel = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    CType(Me.txtDataAtendimentoFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataAtendimentoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(547, 24)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(13, 13)
    Me.Label7.TabIndex = 254
    Me.Label7.Text = "a"
    '
    'txtDataAtendimentoFinal
    '
    Me.txtDataAtendimentoFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataAtendimentoFinal.Location = New System.Drawing.Point(562, 20)
    Me.txtDataAtendimentoFinal.Name = "txtDataAtendimentoFinal"
    Me.txtDataAtendimentoFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataAtendimentoFinal.TabIndex = 238
    Me.txtDataAtendimentoFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDataAtendimentoInicial
    '
    Me.txtDataAtendimentoInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataAtendimentoInicial.Location = New System.Drawing.Point(460, 20)
    Me.txtDataAtendimentoInicial.Name = "txtDataAtendimentoInicial"
    Me.txtDataAtendimentoInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataAtendimentoInicial.TabIndex = 237
    Me.txtDataAtendimentoInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(460, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(113, 13)
    Me.Label4.TabIndex = 252
    Me.Label4.Text = "Período da Ocupação"
    '
    'cboEmpresa
    '
    Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEmpresa.FormattingEnabled = True
    Me.cboEmpresa.Location = New System.Drawing.Point(5, 20)
    Me.cboEmpresa.Name = "cboEmpresa"
    Me.cboEmpresa.Size = New System.Drawing.Size(205, 21)
    Me.cboEmpresa.TabIndex = 234
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(48, 13)
    Me.Label2.TabIndex = 251
    Me.Label2.Text = "Empresa"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(216, 5)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(60, 13)
    Me.Label14.TabIndex = 250
    Me.Label14.Text = "Profissional"
    '
    'cboProfissional
    '
    Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissional.FormattingEnabled = True
    Me.cboProfissional.Location = New System.Drawing.Point(216, 20)
    Me.cboProfissional.Name = "cboProfissional"
    Me.cboProfissional.Size = New System.Drawing.Size(238, 21)
    Me.cboProfissional.TabIndex = 235
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
    Me.grdListagem.Size = New System.Drawing.Size(767, 303)
    Me.grdListagem.TabIndex = 249
    Me.grdListagem.Text = "UltraGrid1"
    '
    'lblRListagemPessoa
    '
    Me.lblRListagemPessoa.AutoSize = True
    Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 89)
    Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
    Me.lblRListagemPessoa.Size = New System.Drawing.Size(131, 13)
    Me.lblRListagemPessoa.TabIndex = 248
    Me.lblRListagemPessoa.Tag = "Listagem de Lançamentos"
    Me.lblRListagemPessoa.Text = "Listagem de Lançamentos"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(5, 413)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 13)
    Me.Label1.TabIndex = 273
    Me.Label1.Text = "Quantidade"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(83, 413)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(40, 13)
    Me.Label3.TabIndex = 274
    Me.Label3.Text = "Início"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(199, 413)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(52, 13)
    Me.Label5.TabIndex = 275
    Me.Label5.Text = "Término"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(315, 413)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(45, 13)
    Me.Label6.TabIndex = 276
    Me.Label6.Text = "Tempo"
    '
    'lblTempo
    '
    Me.lblTempo.AutoSize = True
    Me.lblTempo.Location = New System.Drawing.Point(315, 428)
    Me.lblTempo.Name = "lblTempo"
    Me.lblTempo.Size = New System.Drawing.Size(50, 13)
    Me.lblTempo.TabIndex = 280
    Me.lblTempo.Text = "lblTempo"
    '
    'lblTermino
    '
    Me.lblTermino.AutoSize = True
    Me.lblTermino.Location = New System.Drawing.Point(199, 428)
    Me.lblTermino.Name = "lblTermino"
    Me.lblTermino.Size = New System.Drawing.Size(55, 13)
    Me.lblTermino.TabIndex = 279
    Me.lblTermino.Text = "lblTermino"
    '
    'lblInicio
    '
    Me.lblInicio.AutoSize = True
    Me.lblInicio.Location = New System.Drawing.Point(83, 428)
    Me.lblInicio.Name = "lblInicio"
    Me.lblInicio.Size = New System.Drawing.Size(42, 13)
    Me.lblInicio.TabIndex = 278
    Me.lblInicio.Text = "lblInicio"
    '
    'lblQuantidade
    '
    Me.lblQuantidade.AutoSize = True
    Me.lblQuantidade.Location = New System.Drawing.Point(5, 428)
    Me.lblQuantidade.Name = "lblQuantidade"
    Me.lblQuantidade.Size = New System.Drawing.Size(72, 13)
    Me.lblQuantidade.TabIndex = 277
    Me.lblQuantidade.Text = "lblQuantidade"
    '
    'psqPessoa
    '
    Me.psqPessoa.AdicionarPessoa = True
    Me.psqPessoa.Bordas = True
    Me.psqPessoa.CarregarTodos = False
    Me.psqPessoa.DS_Pessoa = ""
    Me.psqPessoa.ID_Pessoa = 0
    Me.psqPessoa.LabelVisivel = True
    Me.psqPessoa.Location = New System.Drawing.Point(5, 47)
    Me.psqPessoa.Name = "psqPessoa"
    Me.psqPessoa.PesquisarPessoa = True
    Me.psqPessoa.Rotulo = "Pessoa"
    Me.psqPessoa.Size = New System.Drawing.Size(642, 36)
    Me.psqPessoa.SomenteLeitura = False
    Me.psqPessoa.TabIndex = 240
    Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
    '
    'cmdImprimir
    '
    Me.cmdImprimir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
    Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdImprimir.Location = New System.Drawing.Point(86, 451)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
    Me.cmdImprimir.TabIndex = 272
    Me.cmdImprimir.Text = "    Imprimir"
    Me.cmdImprimir.UseVisualStyleBackColor = True
    '
    'cmdLimpar
    '
    Me.cmdLimpar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Limpar
    Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdLimpar.Location = New System.Drawing.Point(697, 5)
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
    Me.cmdExcel.Location = New System.Drawing.Point(5, 451)
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
    Me.cmdPesquisar.Location = New System.Drawing.Point(697, 39)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 244
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(697, 451)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 247
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'frmConsultaOcupacaoTempoPrevisto
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(784, 487)
    Me.Controls.Add(Me.lblTempo)
    Me.Controls.Add(Me.lblTermino)
    Me.Controls.Add(Me.lblInicio)
    Me.Controls.Add(Me.lblQuantidade)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.cmdLimpar)
    Me.Controls.Add(Me.psqPessoa)
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
    Me.Name = "frmConsultaOcupacaoTempoPrevisto"
    Me.Text = "Consulta de Ocupação de Tempo Previsto"
    CType(Me.txtDataAtendimentoFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataAtendimentoInicial, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdLimpar As Button
  Friend WithEvents psqPessoa As uscPesqPessoa
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
  Friend WithEvents cmdImprimir As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents lblTempo As Label
  Friend WithEvents lblTermino As Label
  Friend WithEvents lblInicio As Label
  Friend WithEvents lblQuantidade As Label
End Class
