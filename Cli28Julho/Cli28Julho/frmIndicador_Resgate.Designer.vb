<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndicador_Resgate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboIndicador = New System.Windows.Forms.ComboBox()
        Me.txtDataResgate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.lblRDataAgendamento = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValorSaldo = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorResgate = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        CType(Me.txtDataResgate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorResgate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Indicador"
        '
        'cboIndicador
        '
        Me.cboIndicador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIndicador.FormattingEnabled = True
        Me.cboIndicador.Location = New System.Drawing.Point(5, 20)
        Me.cboIndicador.Name = "cboIndicador"
        Me.cboIndicador.Size = New System.Drawing.Size(450, 21)
        Me.cboIndicador.TabIndex = 1
        '
        'txtDataResgate
        '
        Me.txtDataResgate.DateTime = New Date(2020, 3, 26, 0, 0, 0, 0)
        Me.txtDataResgate.Location = New System.Drawing.Point(100, 62)
        Me.txtDataResgate.MaskInput = "{date} {time}"
        Me.txtDataResgate.Name = "txtDataResgate"
        Me.txtDataResgate.Size = New System.Drawing.Size(120, 21)
        Me.txtDataResgate.TabIndex = 177
        Me.txtDataResgate.Value = New Date(2020, 3, 26, 0, 0, 0, 0)
        '
        'lblRDataAgendamento
        '
        Me.lblRDataAgendamento.AutoSize = True
        Me.lblRDataAgendamento.Location = New System.Drawing.Point(100, 47)
        Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
        Me.lblRDataAgendamento.Size = New System.Drawing.Size(88, 13)
        Me.lblRDataAgendamento.TabIndex = 178
        Me.lblRDataAgendamento.Text = "Data do Resgate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Valor do Saldo"
        '
        'txtValorSaldo
        '
        Me.txtValorSaldo.Location = New System.Drawing.Point(5, 62)
        Me.txtValorSaldo.MaskInput = "{currency:6.2}"
        Me.txtValorSaldo.Name = "txtValorSaldo"
        Me.txtValorSaldo.ReadOnly = True
        Me.txtValorSaldo.Size = New System.Drawing.Size(89, 21)
        Me.txtValorSaldo.TabIndex = 252
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 255
        Me.Label2.Text = "Valor do Resgate"
        '
        'txtValorResgate
        '
        Me.txtValorResgate.Location = New System.Drawing.Point(226, 62)
        Me.txtValorResgate.MaskInput = "{currency:6.2}"
        Me.txtValorResgate.Name = "txtValorResgate"
        Me.txtValorResgate.Size = New System.Drawing.Size(89, 21)
        Me.txtValorResgate.TabIndex = 254
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 256
        Me.Label3.Text = "Comentário"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(5, 104)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(450, 185)
        Me.txtComentario.TabIndex = 257
        '
        'cmdGravar
        '
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(299, 299)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 258
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(380, 299)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 259
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'frmIndicador_Resgate
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
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtValorSaldo)
        Me.Controls.Add(Me.txtDataResgate)
        Me.Controls.Add(Me.lblRDataAgendamento)
        Me.Controls.Add(Me.cboIndicador)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIndicador_Resgate"
        Me.Text = "Indicação - Resgate de Pontos"
        CType(Me.txtDataResgate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorResgate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboIndicador As ComboBox
    Friend WithEvents txtDataResgate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRDataAgendamento As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValorSaldo As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValorResgate As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
    Friend WithEvents Label3 As Label
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
End Class
