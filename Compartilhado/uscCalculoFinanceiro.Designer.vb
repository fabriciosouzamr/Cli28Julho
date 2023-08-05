<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscCalculoFinanceiro
  Inherits System.Windows.Forms.UserControl

  'O UserControl substitui o descarte para limpar a lista de componentes.
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
    Me.txtValor = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.lblRotulo = New System.Windows.Forms.Label()
    Me.cboPeriodoCalculoFinanceiro = New System.Windows.Forms.ComboBox()
    CType(Me.txtValor, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtValor
    '
    Me.txtValor.FormatString = ""
    Me.txtValor.Location = New System.Drawing.Point(0, 15)
    Me.txtValor.MaskInput = "{double:3.4}"
    Me.txtValor.Name = "txtValor"
    Me.txtValor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
    Me.txtValor.Size = New System.Drawing.Size(60, 21)
    Me.txtValor.TabIndex = 105
    '
    'lblRotulo
    '
    Me.lblRotulo.AutoSize = True
    Me.lblRotulo.Location = New System.Drawing.Point(0, 0)
    Me.lblRotulo.Name = "lblRotulo"
    Me.lblRotulo.Size = New System.Drawing.Size(49, 13)
    Me.lblRotulo.TabIndex = 106
    Me.lblRotulo.Text = "Juros (%)"
    '
    'cboPeriodoCalculoFinanceiro
    '
    Me.cboPeriodoCalculoFinanceiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodoCalculoFinanceiro.DropDownWidth = 60
    Me.cboPeriodoCalculoFinanceiro.FormattingEnabled = True
    Me.cboPeriodoCalculoFinanceiro.Items.AddRange(New Object() {"ao Dia", "ao Mês", "ao Ano"})
    Me.cboPeriodoCalculoFinanceiro.Location = New System.Drawing.Point(60, 15)
    Me.cboPeriodoCalculoFinanceiro.Name = "cboPeriodoCalculoFinanceiro"
    Me.cboPeriodoCalculoFinanceiro.Size = New System.Drawing.Size(60, 21)
    Me.cboPeriodoCalculoFinanceiro.TabIndex = 110
    '
    'uscCalculoFinanceiro
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.cboPeriodoCalculoFinanceiro)
    Me.Controls.Add(Me.txtValor)
    Me.Controls.Add(Me.lblRotulo)
    Me.Name = "uscCalculoFinanceiro"
    Me.Size = New System.Drawing.Size(120, 36)
    CType(Me.txtValor, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtValor As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents lblRotulo As Label
  Friend WithEvents cboPeriodoCalculoFinanceiro As ComboBox
End Class
