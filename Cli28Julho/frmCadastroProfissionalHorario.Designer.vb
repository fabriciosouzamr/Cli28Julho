<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroProfissionalHorario
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
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.lblRListagemPessoa = New System.Windows.Forms.Label()
        Me.cboFilial = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCopiarHorarioExames = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHoraFim = New System.Windows.Forms.TextBox()
        Me.txtHoraInicio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDiasSemana = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtQtdeProcedimento = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtdeRetorno = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.cboConsultorio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboAtivo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtData = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkBloqueado = New System.Windows.Forms.CheckBox()
        Me.txtIntervalo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeProcedimento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtdeRetorno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIntervalo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(5, 62)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(737, 21)
        Me.cboProfissional.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Profissional"
        '
        'cmdGravar
        '
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(586, 426)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 203
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(667, 426)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 204
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 187)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(737, 229)
        Me.grdListagem.TabIndex = 214
        Me.grdListagem.Text = "UltraGrid1"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 172)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(106, 13)
        Me.lblRListagemPessoa.TabIndex = 213
        Me.lblRListagemPessoa.Tag = "Listagem de Horários"
        Me.lblRListagemPessoa.Text = "Listagem de Horários"
        '
        'cboFilial
        '
        Me.cboFilial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilial.FormattingEnabled = True
        Me.cboFilial.Location = New System.Drawing.Point(5, 20)
        Me.cboFilial.Name = "cboFilial"
        Me.cboFilial.Size = New System.Drawing.Size(737, 21)
        Me.cboFilial.TabIndex = 216
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Filial"
        '
        'cmdCopiarHorarioExames
        '
        Me.cmdCopiarHorarioExames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCopiarHorarioExames.Location = New System.Drawing.Point(5, 426)
        Me.cmdCopiarHorarioExames.Name = "cmdCopiarHorarioExames"
        Me.cmdCopiarHorarioExames.Size = New System.Drawing.Size(215, 28)
        Me.cmdCopiarHorarioExames.TabIndex = 217
        Me.cmdCopiarHorarioExames.Text = "  Copiar Horário(s) para os outros Exames"
        Me.cmdCopiarHorarioExames.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(185, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 219
        Me.Label9.Text = "Horário de Fim"
        '
        'txtHoraFim
        '
        Me.txtHoraFim.Location = New System.Drawing.Point(185, 104)
        Me.txtHoraFim.Name = "txtHoraFim"
        Me.txtHoraFim.Size = New System.Drawing.Size(35, 20)
        Me.txtHoraFim.TabIndex = 221
        '
        'txtHoraInicio
        '
        Me.txtHoraInicio.Location = New System.Drawing.Point(5, 104)
        Me.txtHoraInicio.Name = "txtHoraInicio"
        Me.txtHoraInicio.Size = New System.Drawing.Size(35, 20)
        Me.txtHoraInicio.TabIndex = 220
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 218
        Me.Label3.Text = "Horário de Início"
        '
        'cboDiasSemana
        '
        Me.cboDiasSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiasSemana.FormattingEnabled = True
        Me.cboDiasSemana.Location = New System.Drawing.Point(266, 104)
        Me.cboDiasSemana.Name = "cboDiasSemana"
        Me.cboDiasSemana.Size = New System.Drawing.Size(108, 21)
        Me.cboDiasSemana.TabIndex = 245
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 246
        Me.Label4.Text = "Dias da Semana"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(380, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 248
        Me.Label12.Text = "Qt. de Procedimentos"
        '
        'txtQtdeProcedimento
        '
        Me.txtQtdeProcedimento.Location = New System.Drawing.Point(380, 104)
        Me.txtQtdeProcedimento.MaskInput = "nnn"
        Me.txtQtdeProcedimento.MinValue = 0
        Me.txtQtdeProcedimento.Name = "txtQtdeProcedimento"
        Me.txtQtdeProcedimento.Size = New System.Drawing.Size(50, 21)
        Me.txtQtdeProcedimento.TabIndex = 247
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(495, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 250
        Me.Label5.Text = "Qt. de Retorno"
        '
        'txtQtdeRetorno
        '
        Me.txtQtdeRetorno.Location = New System.Drawing.Point(495, 104)
        Me.txtQtdeRetorno.MaskInput = "nnn"
        Me.txtQtdeRetorno.MinValue = 0
        Me.txtQtdeRetorno.Name = "txtQtdeRetorno"
        Me.txtQtdeRetorno.Size = New System.Drawing.Size(50, 21)
        Me.txtQtdeRetorno.TabIndex = 249
        '
        'cboConsultorio
        '
        Me.cboConsultorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsultorio.FormattingEnabled = True
        Me.cboConsultorio.Location = New System.Drawing.Point(5, 145)
        Me.cboConsultorio.Name = "cboConsultorio"
        Me.cboConsultorio.Size = New System.Drawing.Size(108, 21)
        Me.cboConsultorio.TabIndex = 251
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 252
        Me.Label6.Text = "Consultório"
        '
        'cboAtivo
        '
        Me.cboAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAtivo.FormattingEnabled = True
        Me.cboAtivo.Location = New System.Drawing.Point(119, 145)
        Me.cboAtivo.Name = "cboAtivo"
        Me.cboAtivo.Size = New System.Drawing.Size(42, 21)
        Me.cboAtivo.TabIndex = 253
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(119, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 254
        Me.Label7.Text = "Ativos?"
        '
        'txtData
        '
        Me.txtData.DateTime = New Date(2021, 2, 18, 0, 0, 0, 0)
        Me.txtData.Location = New System.Drawing.Point(167, 145)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(89, 21)
        Me.txtData.TabIndex = 255
        Me.txtData.Value = New Date(2021, 2, 18, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(167, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 256
        Me.Label8.Text = "Data Especial"
        '
        'chkBloqueado
        '
        Me.chkBloqueado.AutoSize = True
        Me.chkBloqueado.Location = New System.Drawing.Point(664, 149)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(77, 17)
        Me.chkBloqueado.TabIndex = 257
        Me.chkBloqueado.Text = "Bloqueado"
        Me.chkBloqueado.UseVisualStyleBackColor = True
        '
        'txtIntervalo
        '
        Me.txtIntervalo.Location = New System.Drawing.Point(97, 104)
        Me.txtIntervalo.MaskInput = "nnn"
        Me.txtIntervalo.MinValue = 1
        Me.txtIntervalo.Name = "txtIntervalo"
        Me.txtIntervalo.Size = New System.Drawing.Size(50, 21)
        Me.txtIntervalo.TabIndex = 259
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(97, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 258
        Me.Label10.Text = "Intervalo (Min.s)"
        '
        'frmCadastroProfissionalHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 460)
        Me.Controls.Add(Me.txtIntervalo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.chkBloqueado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.cboAtivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboConsultorio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtQtdeRetorno)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtQtdeProcedimento)
        Me.Controls.Add(Me.cboDiasSemana)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHoraFim)
        Me.Controls.Add(Me.txtHoraInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdCopiarHorarioExames)
        Me.Controls.Add(Me.cboFilial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cboProfissional)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroProfissionalHorario"
        Me.Text = "Cadastro de Horário de Profissional"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeProcedimento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtdeRetorno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIntervalo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboProfissional As ComboBox
  Friend WithEvents Label2 As Label
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents lblRListagemPessoa As Label
  Friend WithEvents cboFilial As ComboBox
  Friend WithEvents Label1 As Label
    Friend WithEvents cmdCopiarHorarioExames As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHoraFim As TextBox
    Friend WithEvents txtHoraInicio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboDiasSemana As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtQtdeProcedimento As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQtdeRetorno As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents cboConsultorio As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboAtivo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtData As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents Label8 As Label
    Friend WithEvents chkBloqueado As CheckBox
    Friend WithEvents txtIntervalo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label10 As Label
End Class
