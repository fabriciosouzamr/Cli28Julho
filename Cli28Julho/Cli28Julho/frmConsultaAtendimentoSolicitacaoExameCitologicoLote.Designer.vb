﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAtendimentoSolicitacaoExameCitologicoLote
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAtendimentoSolicitacaoExameCitologicoLote))
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtDataEnvioInicio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.psqPessoa = New Cli28Julho.uscPesqPessoa()
    Me.txtDataEnvioFim = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.cmdRetorno = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdImprimir = New System.Windows.Forms.Button()
    Me.cmdAlterar = New System.Windows.Forms.Button()
    CType(Me.txtDataEnvioInicio, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataEnvioFim, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(617, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(90, 13)
    Me.Label2.TabIndex = 261
    Me.Label2.Text = "Período de Envio"
    '
    'txtDataEnvioInicio
    '
    Me.txtDataEnvioInicio.Location = New System.Drawing.Point(617, 20)
    Me.txtDataEnvioInicio.Name = "txtDataEnvioInicio"
    Me.txtDataEnvioInicio.Size = New System.Drawing.Size(85, 21)
    Me.txtDataEnvioInicio.TabIndex = 260
    '
    'psqPessoa
    '
    Me.psqPessoa.AdicionarPessoa = False
    Me.psqPessoa.Bordas = True
    Me.psqPessoa.CarregarTodos = False
    Me.psqPessoa.DS_Pessoa = ""
    Me.psqPessoa.ID_Pessoa = 0
    Me.psqPessoa.LabelVisivel = True
    Me.psqPessoa.Location = New System.Drawing.Point(5, 5)
    Me.psqPessoa.Name = "psqPessoa"
    Me.psqPessoa.PesquisarPessoa = True
    Me.psqPessoa.Rotulo = "Pessoa"
    Me.psqPessoa.Size = New System.Drawing.Size(606, 36)
    Me.psqPessoa.SomenteLeitura = False
    Me.psqPessoa.TabIndex = 259
    Me.psqPessoa.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Pessoa
    '
    'txtDataEnvioFim
    '
    Me.txtDataEnvioFim.Location = New System.Drawing.Point(719, 20)
    Me.txtDataEnvioFim.Name = "txtDataEnvioFim"
    Me.txtDataEnvioFim.Size = New System.Drawing.Size(85, 21)
    Me.txtDataEnvioFim.TabIndex = 262
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(704, 24)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(13, 13)
    Me.Label1.TabIndex = 263
    Me.Label1.Text = "a"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(5, 47)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(223, 13)
    Me.Label3.TabIndex = 266
    Me.Label3.Text = "Listagem de Citologias Pendentes de Análises"
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
    Me.grdListagem.Size = New System.Drawing.Size(880, 300)
    Me.grdListagem.TabIndex = 265
    Me.grdListagem.Text = "UltraGrid1"
    '
    'cmdNovo
    '
    Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdNovo.Location = New System.Drawing.Point(5, 368)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
    Me.cmdNovo.TabIndex = 268
    Me.cmdNovo.Text = "  Novo"
    Me.cmdNovo.UseVisualStyleBackColor = True
    '
    'cmdRetorno
    '
    Me.cmdRetorno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdRetorno.Location = New System.Drawing.Point(167, 368)
    Me.cmdRetorno.Name = "cmdRetorno"
    Me.cmdRetorno.Size = New System.Drawing.Size(75, 28)
    Me.cmdRetorno.TabIndex = 269
    Me.cmdRetorno.Text = "  Retorno"
    Me.cmdRetorno.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdFechar.Image = CType(resources.GetObject("cmdFechar.Image"), System.Drawing.Image)
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(810, 368)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 267
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdPesquisar.Location = New System.Drawing.Point(810, 13)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
    Me.cmdPesquisar.TabIndex = 264
    Me.cmdPesquisar.Text = "    Pesquisar"
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'cmdImprimir
    '
    Me.cmdImprimir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
    Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdImprimir.Location = New System.Drawing.Point(248, 368)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
    Me.cmdImprimir.TabIndex = 273
    Me.cmdImprimir.Text = "    Imprimir"
    Me.cmdImprimir.UseVisualStyleBackColor = True
    '
    'cmdAlterar
    '
    Me.cmdAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdAlterar.Location = New System.Drawing.Point(86, 368)
    Me.cmdAlterar.Name = "cmdAlterar"
    Me.cmdAlterar.Size = New System.Drawing.Size(75, 28)
    Me.cmdAlterar.TabIndex = 274
    Me.cmdAlterar.Text = "Alterar"
    Me.cmdAlterar.UseVisualStyleBackColor = True
    '
    'frmConsultaAtendimentoSolicitacaoExameCitologicoLote
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(895, 403)
    Me.Controls.Add(Me.cmdAlterar)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.cmdRetorno)
    Me.Controls.Add(Me.cmdNovo)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.grdListagem)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtDataEnvioFim)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtDataEnvioInicio)
    Me.Controls.Add(Me.psqPessoa)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmConsultaAtendimentoSolicitacaoExameCitologicoLote"
    Me.Text = "Consulta  de Lote de Exame de Citológico"
    CType(Me.txtDataEnvioInicio, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataEnvioFim, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label2 As Label
    Friend WithEvents txtDataEnvioInicio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents psqPessoa As uscPesqPessoa
    Friend WithEvents txtDataEnvioFim As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPesquisar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents cmdFechar As Button
    Friend WithEvents cmdNovo As Button
    Friend WithEvents cmdRetorno As Button
    Friend WithEvents cmdImprimir As Button
  Friend WithEvents cmdAlterar As Button
End Class
