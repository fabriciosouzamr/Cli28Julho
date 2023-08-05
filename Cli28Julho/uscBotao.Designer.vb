<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscBotao
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
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.picMouseOut = New System.Windows.Forms.PictureBox()
    Me.picMouseIn = New System.Windows.Forms.PictureBox()
    Me.picMouseClick = New System.Windows.Forms.PictureBox()
    Me.picDesabilitado = New System.Windows.Forms.PictureBox()
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picMouseOut, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picMouseIn, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picMouseClick, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.picDesabilitado, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'picGeral
    '
    Me.picGeral.Location = New System.Drawing.Point(1, 3)
    Me.picGeral.Name = "picGeral"
    Me.picGeral.Size = New System.Drawing.Size(12, 11)
    Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.picGeral.TabIndex = 0
    Me.picGeral.TabStop = False
    '
    'picMouseOut
    '
    Me.picMouseOut.Location = New System.Drawing.Point(15, 3)
    Me.picMouseOut.Name = "picMouseOut"
    Me.picMouseOut.Size = New System.Drawing.Size(12, 11)
    Me.picMouseOut.TabIndex = 1
    Me.picMouseOut.TabStop = False
    Me.picMouseOut.Visible = False
    '
    'picMouseIn
    '
    Me.picMouseIn.Location = New System.Drawing.Point(29, 3)
    Me.picMouseIn.Name = "picMouseIn"
    Me.picMouseIn.Size = New System.Drawing.Size(12, 11)
    Me.picMouseIn.TabIndex = 2
    Me.picMouseIn.TabStop = False
    Me.picMouseIn.Visible = False
    '
    'picMouseClick
    '
    Me.picMouseClick.Location = New System.Drawing.Point(43, 3)
    Me.picMouseClick.Name = "picMouseClick"
    Me.picMouseClick.Size = New System.Drawing.Size(10, 11)
    Me.picMouseClick.TabIndex = 3
    Me.picMouseClick.TabStop = False
    Me.picMouseClick.Visible = False
    '
    'picDesabilitado
    '
    Me.picDesabilitado.Location = New System.Drawing.Point(55, 3)
    Me.picDesabilitado.Name = "picDesabilitado"
    Me.picDesabilitado.Size = New System.Drawing.Size(10, 11)
    Me.picDesabilitado.TabIndex = 4
    Me.picDesabilitado.TabStop = False
    Me.picDesabilitado.Visible = False
    '
    'uscBotao
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.Controls.Add(Me.picDesabilitado)
    Me.Controls.Add(Me.picMouseClick)
    Me.Controls.Add(Me.picMouseIn)
    Me.Controls.Add(Me.picMouseOut)
    Me.Controls.Add(Me.picGeral)
    Me.Name = "uscBotao"
    Me.Size = New System.Drawing.Size(79, 18)
    CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picMouseOut, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picMouseIn, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picMouseClick, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.picDesabilitado, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents picGeral As PictureBox
  Friend WithEvents picMouseOut As PictureBox
  Friend WithEvents picMouseIn As PictureBox
  Friend WithEvents picMouseClick As PictureBox
  Friend WithEvents picDesabilitado As PictureBox
End Class
