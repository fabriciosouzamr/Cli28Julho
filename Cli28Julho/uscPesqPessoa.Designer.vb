<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscPesqPessoa
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
    Me.cboPessoa = New System.Windows.Forms.ComboBox()
    Me.lblRotuloPessoa = New System.Windows.Forms.Label()
    Me.cmdPesquisar = New System.Windows.Forms.Button()
    Me.cmdAdicionar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPessoa
        '
        Me.cboPessoa.FormattingEnabled = True
        Me.cboPessoa.Location = New System.Drawing.Point(46, 15)
        Me.cboPessoa.Name = "cboPessoa"
        Me.cboPessoa.Size = New System.Drawing.Size(474, 21)
        Me.cboPessoa.TabIndex = 1
        '
        'lblRotuloPessoa
        '
        Me.lblRotuloPessoa.AutoSize = True
        Me.lblRotuloPessoa.Location = New System.Drawing.Point(0, 0)
        Me.lblRotuloPessoa.Name = "lblRotuloPessoa"
        Me.lblRotuloPessoa.Size = New System.Drawing.Size(42, 13)
        Me.lblRotuloPessoa.TabIndex = 179
        Me.lblRotuloPessoa.Text = "Pessoa"
        '
        'cmdPesquisar
        '
        Me.cmdPesquisar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Pesquisar
        Me.cmdPesquisar.Location = New System.Drawing.Point(23, 15)
        Me.cmdPesquisar.Name = "cmdPesquisar"
        Me.cmdPesquisar.Size = New System.Drawing.Size(21, 21)
        Me.cmdPesquisar.TabIndex = 180
        Me.cmdPesquisar.TabStop = False
        Me.cmdPesquisar.UseVisualStyleBackColor = True
        '
        'cmdAdicionar
        '
        Me.cmdAdicionar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Adicionar
        Me.cmdAdicionar.Location = New System.Drawing.Point(0, 15)
        Me.cmdAdicionar.Name = "cmdAdicionar"
        Me.cmdAdicionar.Size = New System.Drawing.Size(21, 21)
        Me.cmdAdicionar.TabIndex = 181
        Me.cmdAdicionar.TabStop = False
        Me.cmdAdicionar.UseVisualStyleBackColor = True
        '
        'uscPesqPessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdAdicionar)
        Me.Controls.Add(Me.cmdPesquisar)
        Me.Controls.Add(Me.cboPessoa)
        Me.Controls.Add(Me.lblRotuloPessoa)
        Me.Name = "uscPesqPessoa"
        Me.Size = New System.Drawing.Size(520, 36)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPesquisar As System.Windows.Forms.Button
  Friend WithEvents cboPessoa As System.Windows.Forms.ComboBox
  Friend WithEvents lblRotuloPessoa As System.Windows.Forms.Label
  Friend WithEvents cmdAdicionar As System.Windows.Forms.Button

End Class
