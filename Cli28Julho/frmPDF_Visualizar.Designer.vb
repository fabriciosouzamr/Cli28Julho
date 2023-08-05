<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDF_Visualizar
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPDF_Visualizar))
    Me.pdfVisualizar = New AxAcroPDFLib.AxAcroPDF()
    CType(Me.pdfVisualizar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pdfVisualizar
    '
    Me.pdfVisualizar.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pdfVisualizar.Enabled = True
    Me.pdfVisualizar.Location = New System.Drawing.Point(0, 0)
    Me.pdfVisualizar.Name = "pdfVisualizar"
    Me.pdfVisualizar.OcxState = CType(resources.GetObject("pdfVisualizar.OcxState"), System.Windows.Forms.AxHost.State)
    Me.pdfVisualizar.Size = New System.Drawing.Size(800, 450)
    Me.pdfVisualizar.TabIndex = 0
    '
    'frmPDF_Visualizar
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.pdfVisualizar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmPDF_Visualizar"
    Me.Text = "PDF - Visualizar"
    CType(Me.pdfVisualizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

  Friend WithEvents pdfVisualizar As AxAcroPDFLib.AxAcroPDF
End Class
