<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaProfissionalHorarioBloqueioAgenda
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
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdLimpar = New System.Windows.Forms.Button()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cboProfissional = New System.Windows.Forms.ComboBox()
        Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.cmdPesquisar = New System.Windows.Forms.Button()
        Me.cmdExcluir = New System.Windows.Forms.Button()
        Me.cmdNovo = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.grdListagem = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRListagemPessoa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(5, 62)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(515, 21)
        Me.cboEmpresa.TabIndex = 225
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "Filial"
        '
        'cmdLimpar
        '
        Me.cmdLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpar.Location = New System.Drawing.Point(935, 13)
        Me.cmdLimpar.Name = "cmdLimpar"
        Me.cmdLimpar.Size = New System.Drawing.Size(75, 28)
        Me.cmdLimpar.TabIndex = 223
        Me.cmdLimpar.Text = "Limpar"
        Me.cmdLimpar.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcel.Location = New System.Drawing.Point(854, 375)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcel.TabIndex = 221
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(5, 20)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(322, 21)
        Me.cboProfissional.TabIndex = 210
        '
        'txtDataFinal
        '
        Me.txtDataFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataFinal.Location = New System.Drawing.Point(435, 20)
        Me.txtDataFinal.Name = "txtDataFinal"
        Me.txtDataFinal.Size = New System.Drawing.Size(85, 21)
        Me.txtDataFinal.TabIndex = 212
        Me.txtDataFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'txtDataInicial
        '
        Me.txtDataInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataInicial.Location = New System.Drawing.Point(333, 20)
        Me.txtDataInicial.Name = "txtDataInicial"
        Me.txtDataInicial.Size = New System.Drawing.Size(85, 21)
        Me.txtDataInicial.TabIndex = 211
        Me.txtDataInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPesquisar.Location = New System.Drawing.Point(935, 47)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(75, 28)
        Me.cmdPesquisar.TabIndex = 213
        Me.cmdPesquisar.Text = "    Pesquisar"
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdExcluir
        '
        Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcluir.Location = New System.Drawing.Point(86, 375)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcluir.TabIndex = 220
        Me.cmdExcluir.Text = "Excluir"
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'cmdNovo
        '
        Me.cmdNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNovo.Location = New System.Drawing.Point(5, 375)
        Me.cmdNovo.Name = "cmdNovo"
        Me.cmdNovo.Size = New System.Drawing.Size(75, 28)
        Me.cmdNovo.TabIndex = 218
        Me.cmdNovo.Text = "  Novo"
        Me.cmdNovo.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(935, 375)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 222
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'grdListagem
        '
        Me.grdListagem.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdListagem.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdListagem.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdListagem.DisplayLayout.MaxColScrollRegions = 1
        Me.grdListagem.DisplayLayout.MaxRowScrollRegions = 1
        Me.grdListagem.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdListagem.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdListagem.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdListagem.DisplayLayout.Override.CellPadding = 0
        Me.grdListagem.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.grdListagem.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.grdListagem.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.grdListagem.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdListagem.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdListagem.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdListagem.Location = New System.Drawing.Point(5, 104)
        Me.grdListagem.Name = "grdListagem"
        Me.grdListagem.Size = New System.Drawing.Size(1005, 261)
        Me.grdListagem.TabIndex = 215
        Me.grdListagem.Text = "UltraGrid1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 217
        Me.Label1.Text = "Profissional"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "Período de Bloqueio"
        '
        'lblRListagemPessoa
        '
        Me.lblRListagemPessoa.AutoSize = True
        Me.lblRListagemPessoa.Location = New System.Drawing.Point(5, 89)
        Me.lblRListagemPessoa.Name = "lblRListagemPessoa"
        Me.lblRListagemPessoa.Size = New System.Drawing.Size(102, 13)
        Me.lblRListagemPessoa.TabIndex = 214
        Me.lblRListagemPessoa.Tag = "Listagem de Pessoa"
        Me.lblRListagemPessoa.Text = "Listagem de Pessoa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "a"
        '
        'frmConsultaProfissionalHorarioBloqueioAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 409)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdLimpar)
        Me.Controls.Add(Me.cmdExcel)
        Me.Controls.Add(Me.cboProfissional)
        Me.Controls.Add(Me.txtDataFinal)
        Me.Controls.Add(Me.txtDataInicial)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.cmdNovo)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.grdListagem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRListagemPessoa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaProfissionalHorarioBloqueioAgenda"
        Me.Text = "Consulta de Horário de Profissional - Bloquieo de Agenda"
        CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdListagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdLimpar As Button
    Friend WithEvents cmdExcel As Button
    Friend WithEvents cboProfissional As ComboBox
    Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents cmdPesquisar As Button
    Friend WithEvents cmdExcluir As Button
    Friend WithEvents cmdNovo As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents grdListagem As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRListagemPessoa As Label
    Friend WithEvents Label2 As Label
End Class
