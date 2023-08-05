<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProfissionalHorarioMatrix
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
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.grpTipoCalendário = New System.Windows.Forms.GroupBox()
    Me.optTipoCalendário_Mensal = New System.Windows.Forms.RadioButton()
    Me.optTipoCalendário_Semanal = New System.Windows.Forms.RadioButton()
    Me.pnlTipoCalendário_Mensal = New System.Windows.Forms.Panel()
    Me.cmdTipoCalendário_Mensal_Carregar = New System.Windows.Forms.Button()
    Me.txtTipoCalendário_Mensal_Ano = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboTipoCalendário_Mensal_Mes = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.pnlTipoCalendário_Semanal = New System.Windows.Forms.Panel()
    Me.cboTipoCalendário_Semanal_Semana = New System.Windows.Forms.ComboBox()
    Me.cmdTipoCalendário_Semanal_Adiantar = New System.Windows.Forms.Button()
    Me.cmdTipoCalendário_Semanal_Voltar = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboEmpresa = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpTipoCalendário.SuspendLayout()
    Me.pnlTipoCalendário_Mensal.SuspendLayout()
    CType(Me.txtTipoCalendário_Mensal_Ano, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlTipoCalendário_Semanal.SuspendLayout()
    Me.SuspendLayout()
    '
    'cmdFechar
    '
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(923, 468)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 240
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
    Me.grdListagem.Location = New System.Drawing.Point(5, 49)
    Me.grdListagem.Name = "grdListagem"
    Me.grdListagem.Size = New System.Drawing.Size(993, 409)
    Me.grdListagem.TabIndex = 241
    Me.grdListagem.Text = "UltraGrid1"
    '
    'grpTipoCalendário
    '
    Me.grpTipoCalendário.Controls.Add(Me.optTipoCalendário_Mensal)
    Me.grpTipoCalendário.Controls.Add(Me.optTipoCalendário_Semanal)
    Me.grpTipoCalendário.Location = New System.Drawing.Point(262, 5)
    Me.grpTipoCalendário.Name = "grpTipoCalendário"
    Me.grpTipoCalendário.Size = New System.Drawing.Size(143, 38)
    Me.grpTipoCalendário.TabIndex = 242
    Me.grpTipoCalendário.TabStop = False
    Me.grpTipoCalendário.Text = "Tipo de Calendário"
    '
    'optTipoCalendário_Mensal
    '
    Me.optTipoCalendário_Mensal.AutoSize = True
    Me.optTipoCalendário_Mensal.Location = New System.Drawing.Point(77, 15)
    Me.optTipoCalendário_Mensal.Name = "optTipoCalendário_Mensal"
    Me.optTipoCalendário_Mensal.Size = New System.Drawing.Size(59, 17)
    Me.optTipoCalendário_Mensal.TabIndex = 1
    Me.optTipoCalendário_Mensal.Text = "Mensal"
    Me.optTipoCalendário_Mensal.UseVisualStyleBackColor = True
    '
    'optTipoCalendário_Semanal
    '
    Me.optTipoCalendário_Semanal.AutoSize = True
    Me.optTipoCalendário_Semanal.Checked = True
    Me.optTipoCalendário_Semanal.Location = New System.Drawing.Point(5, 15)
    Me.optTipoCalendário_Semanal.Name = "optTipoCalendário_Semanal"
    Me.optTipoCalendário_Semanal.Size = New System.Drawing.Size(66, 17)
    Me.optTipoCalendário_Semanal.TabIndex = 0
    Me.optTipoCalendário_Semanal.TabStop = True
    Me.optTipoCalendário_Semanal.Text = "Semanal"
    Me.optTipoCalendário_Semanal.UseVisualStyleBackColor = True
    '
    'pnlTipoCalendário_Mensal
    '
    Me.pnlTipoCalendário_Mensal.Controls.Add(Me.cmdTipoCalendário_Mensal_Carregar)
    Me.pnlTipoCalendário_Mensal.Controls.Add(Me.txtTipoCalendário_Mensal_Ano)
    Me.pnlTipoCalendário_Mensal.Controls.Add(Me.Label2)
    Me.pnlTipoCalendário_Mensal.Controls.Add(Me.cboTipoCalendário_Mensal_Mes)
    Me.pnlTipoCalendário_Mensal.Controls.Add(Me.Label1)
    Me.pnlTipoCalendário_Mensal.Location = New System.Drawing.Point(450, 318)
    Me.pnlTipoCalendário_Mensal.Name = "pnlTipoCalendário_Mensal"
    Me.pnlTipoCalendário_Mensal.Size = New System.Drawing.Size(174, 38)
    Me.pnlTipoCalendário_Mensal.TabIndex = 243
    '
    'cmdTipoCalendário_Mensal_Carregar
    '
    Me.cmdTipoCalendário_Mensal_Carregar.Location = New System.Drawing.Point(149, 16)
    Me.cmdTipoCalendário_Mensal_Carregar.Name = "cmdTipoCalendário_Mensal_Carregar"
    Me.cmdTipoCalendário_Mensal_Carregar.Size = New System.Drawing.Size(25, 21)
    Me.cmdTipoCalendário_Mensal_Carregar.TabIndex = 4
    Me.cmdTipoCalendário_Mensal_Carregar.Text = "V"
    Me.cmdTipoCalendário_Mensal_Carregar.UseVisualStyleBackColor = True
    '
    'txtTipoCalendário_Mensal_Ano
    '
    Me.txtTipoCalendário_Mensal_Ano.Location = New System.Drawing.Point(99, 16)
    Me.txtTipoCalendário_Mensal_Ano.MaskInput = "nnnn"
    Me.txtTipoCalendário_Mensal_Ano.MaxValue = 3000
    Me.txtTipoCalendário_Mensal_Ano.MinValue = 1900
    Me.txtTipoCalendário_Mensal_Ano.Name = "txtTipoCalendário_Mensal_Ano"
    Me.txtTipoCalendário_Mensal_Ano.Size = New System.Drawing.Size(44, 21)
    Me.txtTipoCalendário_Mensal_Ano.TabIndex = 3
    Me.txtTipoCalendário_Mensal_Ano.Value = 2020
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(99, 1)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(26, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Ano"
    '
    'cboTipoCalendário_Mensal_Mes
    '
    Me.cboTipoCalendário_Mensal_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoCalendário_Mensal_Mes.FormattingEnabled = True
    Me.cboTipoCalendário_Mensal_Mes.Location = New System.Drawing.Point(1, 16)
    Me.cboTipoCalendário_Mensal_Mes.Name = "cboTipoCalendário_Mensal_Mes"
    Me.cboTipoCalendário_Mensal_Mes.Size = New System.Drawing.Size(92, 21)
    Me.cboTipoCalendário_Mensal_Mes.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(1, 1)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(27, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Mês"
    '
    'pnlTipoCalendário_Semanal
    '
    Me.pnlTipoCalendário_Semanal.Controls.Add(Me.cboTipoCalendário_Semanal_Semana)
    Me.pnlTipoCalendário_Semanal.Controls.Add(Me.cmdTipoCalendário_Semanal_Adiantar)
    Me.pnlTipoCalendário_Semanal.Controls.Add(Me.cmdTipoCalendário_Semanal_Voltar)
    Me.pnlTipoCalendário_Semanal.Controls.Add(Me.Label3)
    Me.pnlTipoCalendário_Semanal.Location = New System.Drawing.Point(411, 5)
    Me.pnlTipoCalendário_Semanal.Name = "pnlTipoCalendário_Semanal"
    Me.pnlTipoCalendário_Semanal.Size = New System.Drawing.Size(277, 38)
    Me.pnlTipoCalendário_Semanal.TabIndex = 244
    '
    'cboTipoCalendário_Semanal_Semana
    '
    Me.cboTipoCalendário_Semanal_Semana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoCalendário_Semanal_Semana.FormattingEnabled = True
    Me.cboTipoCalendário_Semanal_Semana.Location = New System.Drawing.Point(52, 13)
    Me.cboTipoCalendário_Semanal_Semana.Name = "cboTipoCalendário_Semanal_Semana"
    Me.cboTipoCalendário_Semanal_Semana.Size = New System.Drawing.Size(173, 21)
    Me.cboTipoCalendário_Semanal_Semana.TabIndex = 3
    '
    'cmdTipoCalendário_Semanal_Adiantar
    '
    Me.cmdTipoCalendário_Semanal_Adiantar.Location = New System.Drawing.Point(227, 12)
    Me.cmdTipoCalendário_Semanal_Adiantar.Name = "cmdTipoCalendário_Semanal_Adiantar"
    Me.cmdTipoCalendário_Semanal_Adiantar.Size = New System.Drawing.Size(47, 23)
    Me.cmdTipoCalendário_Semanal_Adiantar.TabIndex = 2
    Me.cmdTipoCalendário_Semanal_Adiantar.Text = ">>>"
    Me.cmdTipoCalendário_Semanal_Adiantar.UseVisualStyleBackColor = True
    '
    'cmdTipoCalendário_Semanal_Voltar
    '
    Me.cmdTipoCalendário_Semanal_Voltar.Location = New System.Drawing.Point(3, 12)
    Me.cmdTipoCalendário_Semanal_Voltar.Name = "cmdTipoCalendário_Semanal_Voltar"
    Me.cmdTipoCalendário_Semanal_Voltar.Size = New System.Drawing.Size(47, 23)
    Me.cmdTipoCalendário_Semanal_Voltar.TabIndex = 1
    Me.cmdTipoCalendário_Semanal_Voltar.Text = "<<<"
    Me.cmdTipoCalendário_Semanal_Voltar.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(113, 1)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(51, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Semanas"
    '
    'cboEmpresa
    '
    Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEmpresa.FormattingEnabled = True
    Me.cboEmpresa.Location = New System.Drawing.Point(5, 20)
    Me.cboEmpresa.Name = "cboEmpresa"
    Me.cboEmpresa.Size = New System.Drawing.Size(251, 21)
    Me.cboEmpresa.TabIndex = 248
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(48, 13)
    Me.Label4.TabIndex = 247
    Me.Label4.Text = "Empresa"
    '
    'frmConsultaProfissionalHorarioMatrix
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1003, 501)
    Me.Controls.Add(Me.cboEmpresa)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.pnlTipoCalendário_Semanal)
    Me.Controls.Add(Me.pnlTipoCalendário_Mensal)
    Me.Controls.Add(Me.grpTipoCalendário)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.grdListagem)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmConsultaProfissionalHorarioMatrix"
    Me.Text = "Consulta de Horário de Profissional"
    CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpTipoCalendário.ResumeLayout(False)
    Me.grpTipoCalendário.PerformLayout()
    Me.pnlTipoCalendário_Mensal.ResumeLayout(False)
    Me.pnlTipoCalendário_Mensal.PerformLayout()
    CType(Me.txtTipoCalendário_Mensal_Ano, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlTipoCalendário_Semanal.ResumeLayout(False)
    Me.pnlTipoCalendário_Semanal.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cmdFechar As Button
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents grpTipoCalendário As GroupBox
  Friend WithEvents optTipoCalendário_Semanal As RadioButton
  Friend WithEvents optTipoCalendário_Mensal As RadioButton
  Friend WithEvents pnlTipoCalendário_Mensal As Panel
  Friend WithEvents pnlTipoCalendário_Semanal As Panel
  Friend WithEvents Label1 As Label
  Friend WithEvents cboTipoCalendário_Mensal_Mes As ComboBox
  Friend WithEvents txtTipoCalendário_Mensal_Ano As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents cboTipoCalendário_Semanal_Semana As ComboBox
  Friend WithEvents cmdTipoCalendário_Semanal_Adiantar As Button
  Friend WithEvents cmdTipoCalendário_Semanal_Voltar As Button
  Friend WithEvents cmdTipoCalendário_Mensal_Carregar As Button
  Friend WithEvents cboEmpresa As ComboBox
  Friend WithEvents Label4 As Label
End Class
