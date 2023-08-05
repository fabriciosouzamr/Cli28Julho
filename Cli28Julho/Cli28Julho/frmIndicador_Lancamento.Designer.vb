<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndicador_Lancamento
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
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorResgate = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
        Me.txtDataLancamento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRDataAgendamento = New System.Windows.Forms.Label()
        Me.cboIndicador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtValorResgate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataLancamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGravar
        '
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(299, 299)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 270
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(380, 299)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 271
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(5, 104)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(450, 185)
        Me.txtComentario.TabIndex = 269
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "Comentário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 267
        Me.Label2.Text = "Valor do Lançamento"
        '
        'txtValorResgate
        '
        Me.txtValorResgate.Location = New System.Drawing.Point(131, 62)
        Me.txtValorResgate.MaskInput = "{currency:6.2}"
        Me.txtValorResgate.Name = "txtValorResgate"
        Me.txtValorResgate.Size = New System.Drawing.Size(89, 21)
        Me.txtValorResgate.TabIndex = 266
        '
        'txtDataLancamento
        '
        Me.txtDataLancamento.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
        Me.txtDataLancamento.Location = New System.Drawing.Point(5, 62)
        Me.txtDataLancamento.MaskInput = "{date} {time}"
        Me.txtDataLancamento.Name = "txtDataLancamento"
        Me.txtDataLancamento.Size = New System.Drawing.Size(120, 21)
        Me.txtDataLancamento.TabIndex = 262
        Me.txtDataLancamento.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
        '
        'lblRDataAgendamento
        '
        Me.lblRDataAgendamento.AutoSize = True
        Me.lblRDataAgendamento.Location = New System.Drawing.Point(5, 47)
        Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
        Me.lblRDataAgendamento.Size = New System.Drawing.Size(107, 13)
        Me.lblRDataAgendamento.TabIndex = 263
        Me.lblRDataAgendamento.Text = "Data do Lançamento"
        '
        'cboIndicador
        '
        Me.cboIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIndicador.FormattingEnabled = True
        Me.cboIndicador.Location = New System.Drawing.Point(5, 20)
        Me.cboIndicador.Name = "cboIndicador"
        Me.cboIndicador.Size = New System.Drawing.Size(450, 21)
        Me.cboIndicador.TabIndex = 261
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "Indicador"
        '
        'frmIndicador_Lancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 334)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValorResgate)
        Me.Controls.Add(Me.txtDataLancamento)
        Me.Controls.Add(Me.lblRDataAgendamento)
        Me.Controls.Add(Me.cboIndicador)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIndicador_Lancamento"
        Me.Text = "Indicação - Lançamento de Pontos"
        CType(Me.txtValorResgate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataLancamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValorResgate As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents txtDataLancamento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRDataAgendamento As Label
    Friend WithEvents cboIndicador As ComboBox
    Friend WithEvents Label1 As Label
End Class
