﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaConvenioProfissional
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
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboConvenio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboProfissional = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPDF
        '
        Me.cmdPDF.Image = Global.Cli28Julho.My.Resources.Resources.Mini_PDF
        Me.cmdPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPDF.Location = New System.Drawing.Point(86, 432)
        Me.cmdPDF.Name = "cmdPDF"
        Me.cmdPDF.Size = New System.Drawing.Size(75, 28)
        Me.cmdPDF.TabIndex = 248
        Me.cmdPDF.Text = "     P.D.F."
        Me.cmdPDF.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excel
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(5, 432)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 247
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(948, 17)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 246
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(948, 432)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 244
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 62)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(1018, 360)
        Me.grdListagem.TabIndex = 243
        Me.grdListagem.Text = "UltraGrid1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 242
        Me.Label2.Text = "Listagem de Exames/Procecimentos"
        '
        'cboConvenio
        '
        Me.cboConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConvenio.FormattingEnabled = True
        Me.cboConvenio.Location = New System.Drawing.Point(5, 20)
        Me.cboConvenio.Name = "cboConvenio"
        Me.cboConvenio.Size = New System.Drawing.Size(400, 21)
        Me.cboConvenio.TabIndex = 241
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "Convênio"
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(411, 20)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(322, 21)
        Me.cboProfissional.TabIndex = 249
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 250
        Me.Label3.Text = "Profissional"
        '
        'frmConsultaConvenioProfissional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 466)
        Me.Controls.Add(Me.cboProfissional)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdPDF)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboConvenio)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmConsultaConvenioProfissional"
        Me.Text = "Consulta de Convênio e Profissional"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPDF As Button
    Friend WithEvents cmdExcel As Button
    Friend WithEvents cmdPesquisar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents cboConvenio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboProfissional As ComboBox
    Friend WithEvents Label3 As Label
End Class
