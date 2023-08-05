<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaContasReceberPagarCancelamento
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
    Me.txtDataCancelamento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.cboMotivoCancelamento = New System.Windows.Forms.ComboBox()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.txtValorCancelamento = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.txtComentario = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdGravar = New System.Windows.Forms.Button()
    CType(Me.txtDataCancelamento, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtValorCancelamento, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtDataCancelamento
    '
    Me.txtDataCancelamento.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataCancelamento.Location = New System.Drawing.Point(5, 20)
    Me.txtDataCancelamento.Name = "txtDataCancelamento"
    Me.txtDataCancelamento.ReadOnly = True
    Me.txtDataCancelamento.Size = New System.Drawing.Size(85, 21)
    Me.txtDataCancelamento.TabIndex = 1
    Me.txtDataCancelamento.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(116, 13)
    Me.Label4.TabIndex = 90
    Me.Label4.Text = "Data da Cancelamento"
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Location = New System.Drawing.Point(127, 5)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(125, 13)
    Me.Label14.TabIndex = 176
    Me.Label14.Text = "Motivo do Cancelamento"
    '
    'cboMotivoCancelamento
    '
    Me.cboMotivoCancelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboMotivoCancelamento.FormattingEnabled = True
    Me.cboMotivoCancelamento.Location = New System.Drawing.Point(127, 20)
    Me.cboMotivoCancelamento.Name = "cboMotivoCancelamento"
    Me.cboMotivoCancelamento.Size = New System.Drawing.Size(182, 21)
    Me.cboMotivoCancelamento.TabIndex = 2
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Location = New System.Drawing.Point(315, 5)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(102, 13)
    Me.Label19.TabIndex = 178
    Me.Label19.Text = "Valor Cancelamento"
    '
    'txtValorCancelamento
    '
    Me.txtValorCancelamento.CausesValidation = False
    Me.txtValorCancelamento.Location = New System.Drawing.Point(315, 20)
    Me.txtValorCancelamento.MaskInput = "{currency:-9.2}"
    Me.txtValorCancelamento.Name = "txtValorCancelamento"
    Me.txtValorCancelamento.ReadOnly = True
    Me.txtValorCancelamento.Size = New System.Drawing.Size(110, 21)
    Me.txtValorCancelamento.TabIndex = 3
    '
    'txtComentario
    '
    Me.txtComentario.Location = New System.Drawing.Point(5, 62)
    Me.txtComentario.MaxLength = 100000
    Me.txtComentario.Multiline = True
    Me.txtComentario.Name = "txtComentario"
    Me.txtComentario.Size = New System.Drawing.Size(420, 200)
    Me.txtComentario.TabIndex = 4
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Location = New System.Drawing.Point(5, 47)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(60, 13)
    Me.Label16.TabIndex = 179
    Me.Label16.Text = "Comentário"
    '
    'cmdFechar
    '
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(350, 272)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(269, 272)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 100
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'frmConsultaContasReceberPagarCancelamento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(432, 304)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.txtComentario)
    Me.Controls.Add(Me.Label16)
    Me.Controls.Add(Me.Label19)
    Me.Controls.Add(Me.txtValorCancelamento)
    Me.Controls.Add(Me.Label14)
    Me.Controls.Add(Me.cboMotivoCancelamento)
    Me.Controls.Add(Me.txtDataCancelamento)
    Me.Controls.Add(Me.Label4)
    Me.MaximizeBox = False
    Me.Name = "frmConsultaContasReceberPagarCancelamento"
    Me.Text = "frmConsultaContasReceberPagarCancelamento"
    CType(Me.txtDataCancelamento, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtValorCancelamento, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtDataCancelamento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As Label
  Friend WithEvents Label14 As Label
  Friend WithEvents cboMotivoCancelamento As ComboBox
  Friend WithEvents Label19 As Label
  Friend WithEvents txtValorCancelamento As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents txtComentario As TextBox
  Friend WithEvents Label16 As Label
  Friend WithEvents cmdFechar As Button
  Friend WithEvents cmdGravar As Button
End Class
