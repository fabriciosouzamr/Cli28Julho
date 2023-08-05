<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscPesqProcedimento
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
    Me.cboProcedimentoPrincipal = New System.Windows.Forms.ComboBox()
    Me.cboProcedimento = New System.Windows.Forms.ComboBox()
    Me.lblRDescricaoProcedimento = New System.Windows.Forms.Label()
    Me.lblRProcedimento = New System.Windows.Forms.Label()
    Me.cmdPesquisarProcedimento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboProcedimentoPrincipal
        '
        Me.cboProcedimentoPrincipal.FormattingEnabled = True
        Me.cboProcedimentoPrincipal.Location = New System.Drawing.Point(107, 15)
        Me.cboProcedimentoPrincipal.Name = "cboProcedimentoPrincipal"
        Me.cboProcedimentoPrincipal.Size = New System.Drawing.Size(255, 21)
        Me.cboProcedimentoPrincipal.TabIndex = 74
        '
        'cboProcedimento
        '
        Me.cboProcedimento.FormattingEnabled = True
        Me.cboProcedimento.Location = New System.Drawing.Point(0, 15)
        Me.cboProcedimento.Name = "cboProcedimento"
        Me.cboProcedimento.Size = New System.Drawing.Size(80, 21)
        Me.cboProcedimento.TabIndex = 71
        '
        'lblRDescricaoProcedimento
        '
        Me.lblRDescricaoProcedimento.AutoSize = True
        Me.lblRDescricaoProcedimento.Location = New System.Drawing.Point(86, 0)
        Me.lblRDescricaoProcedimento.Name = "lblRDescricaoProcedimento"
        Me.lblRDescricaoProcedimento.Size = New System.Drawing.Size(138, 13)
        Me.lblRDescricaoProcedimento.TabIndex = 73
        Me.lblRDescricaoProcedimento.Text = "Descrição do Procedimento"
        '
        'lblRProcedimento
        '
        Me.lblRProcedimento.AutoSize = True
        Me.lblRProcedimento.Location = New System.Drawing.Point(0, 0)
        Me.lblRProcedimento.Name = "lblRProcedimento"
        Me.lblRProcedimento.Size = New System.Drawing.Size(72, 13)
        Me.lblRProcedimento.TabIndex = 72
        Me.lblRProcedimento.Text = "Procedimento"
        '
        'cmdPesquisarProcedimento
        '
        Me.cmdPesquisarProcedimento.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisarProcedimento.Location = New System.Drawing.Point(86, 15)
        Me.cmdPesquisarProcedimento.Name = "cmdPesquisarProcedimento"
        Me.cmdPesquisarProcedimento.Size = New System.Drawing.Size(21, 21)
        Me.cmdPesquisarProcedimento.TabIndex = 75
        Me.cmdPesquisarProcedimento.UseVisualStyleBackColor = True
        '
        'uscPesqProcedimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdPesquisarProcedimento)
        Me.Controls.Add(Me.cboProcedimentoPrincipal)
        Me.Controls.Add(Me.cboProcedimento)
        Me.Controls.Add(Me.lblRDescricaoProcedimento)
        Me.Controls.Add(Me.lblRProcedimento)
        Me.Name = "uscPesqProcedimento"
        Me.Size = New System.Drawing.Size(362, 36)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPesquisarProcedimento As System.Windows.Forms.Button
  Friend WithEvents cboProcedimentoPrincipal As System.Windows.Forms.ComboBox
  Friend WithEvents cboProcedimento As System.Windows.Forms.ComboBox
  Friend WithEvents lblRDescricaoProcedimento As System.Windows.Forms.Label
  Friend WithEvents lblRProcedimento As System.Windows.Forms.Label

End Class
