<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscTextoCadastravel
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
    Me.cmdEscrever = New System.Windows.Forms.Button()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdNovo = New System.Windows.Forms.Button()
    Me.txtEscrever = New System.Windows.Forms.TextBox()
    Me.cboPesquisa = New System.Windows.Forms.ComboBox()
    Me.SuspendLayout()
    '
    'cmdEscrever
    '
    Me.cmdEscrever.Image = Global.SisMattos.My.Resources.Resources.Mini_Escrever
    Me.cmdEscrever.Location = New System.Drawing.Point(34, 80)
    Me.cmdEscrever.Margin = New System.Windows.Forms.Padding(0)
    Me.cmdEscrever.Name = "cmdEscrever"
    Me.cmdEscrever.Size = New System.Drawing.Size(21, 21)
    Me.cmdEscrever.TabIndex = 2
    Me.cmdEscrever.UseVisualStyleBackColor = True
    '
    'cmdPesquisar
    '
    Me.cmdPesquisar.Image = Global.SisMattos.My.Resources.Resources.Mini_Pesquisar
    Me.cmdPesquisar.Location = New System.Drawing.Point(0, 0)
    Me.cmdPesquisar.Margin = New System.Windows.Forms.Padding(0)
    Me.cmdPesquisar.Name = "cmdPesquisar"
    Me.cmdPesquisar.Size = New System.Drawing.Size(21, 21)
    Me.cmdPesquisar.TabIndex = 1
    Me.cmdPesquisar.UseVisualStyleBackColor = True
    '
    'cmdNovo
    '
    Me.cmdNovo.Image = Global.SisMattos.My.Resources.Resources.Mini_Novo
    Me.cmdNovo.Location = New System.Drawing.Point(21, 0)
    Me.cmdNovo.Margin = New System.Windows.Forms.Padding(0)
    Me.cmdNovo.Name = "cmdNovo"
    Me.cmdNovo.Size = New System.Drawing.Size(21, 21)
    Me.cmdNovo.TabIndex = 0
    Me.cmdNovo.UseVisualStyleBackColor = True
    '
    'txtEscrever
    '
    Me.txtEscrever.Location = New System.Drawing.Point(44, 1)
    Me.txtEscrever.Name = "txtEscrever"
    Me.txtEscrever.Size = New System.Drawing.Size(251, 20)
    Me.txtEscrever.TabIndex = 3
    '
    'cboPesquisa
    '
    Me.cboPesquisa.FormattingEnabled = True
    Me.cboPesquisa.Location = New System.Drawing.Point(76, 109)
    Me.cboPesquisa.Name = "cboPesquisa"
    Me.cboPesquisa.Size = New System.Drawing.Size(251, 21)
    Me.cboPesquisa.TabIndex = 179
    '
    'uscTextoCadastravel
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.cboPesquisa)
    Me.Controls.Add(Me.txtEscrever)
    Me.Controls.Add(Me.cmdEscrever)
    Me.Controls.Add(Me.cmdPesquisar)
    Me.Controls.Add(Me.cmdNovo)
    Me.Name = "uscTextoCadastravel"
    Me.Size = New System.Drawing.Size(404, 214)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cmdNovo As System.Windows.Forms.Button
  Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents cmdEscrever As System.Windows.Forms.Button
  Friend WithEvents txtEscrever As System.Windows.Forms.TextBox
  Friend WithEvents cboPesquisa As System.Windows.Forms.ComboBox

End Class
