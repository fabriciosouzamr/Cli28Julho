﻿<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReportViewer
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewer))
    Me.rpvGeral = New Microsoft.Reporting.WinForms.ReportViewer()
    Me.SuspendLayout()
    '
    'rpvGeral
    '
    Me.rpvGeral.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rpvGeral.DocumentMapWidth = 58
    Me.rpvGeral.Location = New System.Drawing.Point(0, 0)
    Me.rpvGeral.Name = "rpvGeral"
    Me.rpvGeral.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
    Me.rpvGeral.Size = New System.Drawing.Size(541, 399)
    Me.rpvGeral.TabIndex = 0
    '
    'frmReportViewer
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(541, 399)
    Me.Controls.Add(Me.rpvGeral)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmReportViewer"
    Me.Text = "frmReportViewer"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents rpvGeral As Microsoft.Reporting.WinForms.ReportViewer
End Class
