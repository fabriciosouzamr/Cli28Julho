<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscPeriodo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtDataFinal = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtDataInicial = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblRotulo = New System.Windows.Forms.Label()
    CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(85, 19)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(13, 13)
    Me.Label7.TabIndex = 187
    Me.Label7.Text = "a"
    '
    'txtDataFinal
    '
    Me.txtDataFinal.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataFinal.Location = New System.Drawing.Point(98, 15)
    Me.txtDataFinal.Name = "txtDataFinal"
    Me.txtDataFinal.Size = New System.Drawing.Size(85, 21)
    Me.txtDataFinal.TabIndex = 186
    Me.txtDataFinal.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'txtDataInicial
    '
    Me.txtDataInicial.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
    Me.txtDataInicial.InvalidTextBehavior = Infragistics.Win.UltraWinEditors.InvalidTextBehavior.RevertToOriginalValue
    Me.txtDataInicial.Location = New System.Drawing.Point(0, 15)
    Me.txtDataInicial.Name = "txtDataInicial"
    Me.txtDataInicial.Size = New System.Drawing.Size(85, 21)
    Me.txtDataInicial.TabIndex = 184
    Me.txtDataInicial.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
    '
    'lblRotulo
    '
    Me.lblRotulo.AutoSize = True
    Me.lblRotulo.Location = New System.Drawing.Point(0, 0)
    Me.lblRotulo.Name = "lblRotulo"
    Me.lblRotulo.Size = New System.Drawing.Size(118, 13)
    Me.lblRotulo.TabIndex = 185
    Me.lblRotulo.Text = "Data da Movimentação"
    '
    'uscPeriodo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtDataFinal)
    Me.Controls.Add(Me.txtDataInicial)
    Me.Controls.Add(Me.lblRotulo)
    Me.Name = "uscPeriodo"
    Me.Size = New System.Drawing.Size(183, 36)
    CType(Me.txtDataFinal, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtDataInicial, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtDataFinal As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtDataInicial As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents lblRotulo As System.Windows.Forms.Label

End Class
