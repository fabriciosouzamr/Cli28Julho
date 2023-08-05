<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaContasReceberPagar_Transferir
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
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblValorTotalTransferencia = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblQuantidadeTitulos = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboContaCaixa = New System.Windows.Forms.ComboBox()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(637, 370)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 102
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(718, 370)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 103
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Valor Total de Transferência"
        '
        'lblValorTotalTransferencia
        '
        Me.lblValorTotalTransferencia.AutoSize = True
        Me.lblValorTotalTransferencia.Location = New System.Drawing.Point(101, 20)
        Me.lblValorTotalTransferencia.Name = "lblValorTotalTransferencia"
        Me.lblValorTotalTransferencia.Size = New System.Drawing.Size(45, 13)
        Me.lblValorTotalTransferencia.TabIndex = 105
        Me.lblValorTotalTransferencia.Text = "R$ 0,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Quantidade de Títulos"
        '
        'lblQuantidadeTitulos
        '
        Me.lblQuantidadeTitulos.AutoSize = True
        Me.lblQuantidadeTitulos.Location = New System.Drawing.Point(252, 20)
        Me.lblQuantidadeTitulos.Name = "lblQuantidadeTitulos"
        Me.lblQuantidadeTitulos.Size = New System.Drawing.Size(13, 13)
        Me.lblQuantidadeTitulos.TabIndex = 107
        Me.lblQuantidadeTitulos.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Listagem por Tipo de Documento"
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
        Me.grdListagem.Location = New System.Drawing.Point(5, 58)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(788, 302)
        Me.grdListagem.TabIndex = 109
        Me.grdListagem.Text = "UltraGrid1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Conta Caixa"
        '
        'cboContaCaixa
        '
        Me.cboContaCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaCaixa.FormattingEnabled = True
        Me.cboContaCaixa.Location = New System.Drawing.Point(271, 20)
        Me.cboContaCaixa.Name = "cboContaCaixa"
        Me.cboContaCaixa.Size = New System.Drawing.Size(300, 21)
        Me.cboContaCaixa.TabIndex = 111
        '
        'frmConsultaContasReceberPagar_Transferir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 404)
        Me.Controls.Add(Me.cboContaCaixa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblQuantidadeTitulos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblValorTotalTransferencia)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaContasReceberPagar_Transferir"
        Me.Text = "Consulta de Contas a Receber e a Pagar - Transferir"
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents lblValorTotalTransferencia As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents lblQuantidadeTitulos As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
  Friend WithEvents Label4 As Label
  Friend WithEvents cboContaCaixa As ComboBox
End Class
