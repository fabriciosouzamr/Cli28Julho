<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAtendimentoSolicitacaoExameCitologicoLote
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoSolicitacaoExameCitologicoLote))
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.grdDadosLoteCitologias = New System.Windows.Forms.GroupBox()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtDataEnvio = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtCodigoCitologia = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cmdImprimir = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.txtCodigoLote = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grdDadosLoteCitologias.SuspendLayout()
    CType(Me.txtDataEnvio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 44)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(790, 300)
    Me.grdListagem.TabIndex = 254
    Me.grdListagem.Text = "UltraGrid1"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 29)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(223, 13)
    Me.Label1.TabIndex = 255
    Me.Label1.Text = "Listagem de Citologias Pendentes de Análises"
    '
    'grdDadosLoteCitologias
    '
    Me.grdDadosLoteCitologias.Controls.Add(Me.cboProfissional)
    Me.grdDadosLoteCitologias.Controls.Add(Me.Label4)
    Me.grdDadosLoteCitologias.Controls.Add(Me.cmdGravar)
    Me.grdDadosLoteCitologias.Controls.Add(Me.Label2)
    Me.grdDadosLoteCitologias.Controls.Add(Me.txtDataEnvio)
    Me.grdDadosLoteCitologias.Location = New System.Drawing.Point(5, 350)
    Me.grdDadosLoteCitologias.Name = "grdDadosLoteCitologias"
    Me.grdDadosLoteCitologias.Size = New System.Drawing.Size(790, 58)
    Me.grdDadosLoteCitologias.TabIndex = 256
    Me.grdDadosLoteCitologias.TabStop = False
    Me.grdDadosLoteCitologias.Text = "Dados do Lote de Citologias"
    '
    'cboProfissional
    '
    Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissional.FormattingEnabled = True
    Me.cboProfissional.Location = New System.Drawing.Point(5, 31)
    Me.cboProfissional.Name = "cboProfissional"
    Me.cboProfissional.Size = New System.Drawing.Size(606, 21)
    Me.cboProfissional.TabIndex = 260
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 16)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(60, 13)
    Me.Label4.TabIndex = 261
    Me.Label4.Text = "Profissional"
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(708, 24)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 259
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(617, 16)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(75, 13)
    Me.Label2.TabIndex = 258
    Me.Label2.Text = "Data de Envio"
    '
    'txtDataEnvio
    '
    Me.txtDataEnvio.Location = New System.Drawing.Point(617, 31)
    Me.txtDataEnvio.Name = "txtDataEnvio"
    Me.txtDataEnvio.Size = New System.Drawing.Size(85, 21)
    Me.txtDataEnvio.TabIndex = 257
    '
    'txtCodigoCitologia
    '
    Me.txtCodigoCitologia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigoCitologia.Location = New System.Drawing.Point(158, 4)
    Me.txtCodigoCitologia.Name = "txtCodigoCitologia"
    Me.txtCodigoCitologia.Size = New System.Drawing.Size(100, 20)
    Me.txtCodigoCitologia.TabIndex = 258
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(7, 8)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(145, 13)
    Me.Label3.TabIndex = 259
    Me.Label3.Text = "Selecione o exame citológico"
    '
    'cmdImprimir
    '
    Me.cmdImprimir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Imprimir
    Me.cmdImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdImprimir.Location = New System.Drawing.Point(639, 418)
    Me.cmdImprimir.Name = "cmdImprimir"
    Me.cmdImprimir.Size = New System.Drawing.Size(75, 28)
    Me.cmdImprimir.TabIndex = 272
    Me.cmdImprimir.Text = "    Imprimir"
    Me.cmdImprimir.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdFechar.Image = CType(resources.GetObject("cmdFechar.Image"), System.Drawing.Image)
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(720, 418)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 257
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'txtCodigoLote
    '
    Me.txtCodigoLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtCodigoLote.Location = New System.Drawing.Point(688, 4)
    Me.txtCodigoLote.Name = "txtCodigoLote"
    Me.txtCodigoLote.ReadOnly = True
    Me.txtCodigoLote.Size = New System.Drawing.Size(100, 20)
    Me.txtCodigoLote.TabIndex = 273
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(603, 8)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(79, 13)
    Me.Label5.TabIndex = 274
    Me.Label5.Text = "Código do Lote"
    '
    'frmCadastroAtendimentoSolicitacaoExameCitologicoLote
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 458)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtCodigoLote)
    Me.Controls.Add(Me.cmdImprimir)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtCodigoCitologia)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdDadosLoteCitologias)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.grdListagem)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroAtendimentoSolicitacaoExameCitologicoLote"
    Me.Text = "Cadastro de Atendimento - Solicitação de Exame Citológicos - Lote"
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grdDadosLoteCitologias.ResumeLayout(False)
    Me.grdDadosLoteCitologias.PerformLayout()
    CType(Me.txtDataEnvio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents grdDadosLoteCitologias As GroupBox
    Friend WithEvents txtDataEnvio As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents txtCodigoCitologia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdImprimir As Button
    Friend WithEvents cboProfissional As ComboBox
    Friend WithEvents Label4 As Label
  Friend WithEvents txtCodigoLote As TextBox
  Friend WithEvents Label5 As Label
End Class
