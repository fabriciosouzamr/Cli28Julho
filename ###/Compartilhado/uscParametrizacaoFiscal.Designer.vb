<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscParametrizacaoFiscal
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
    Me.cmdAbrirDiretorio = New System.Windows.Forms.Button()
    Me.txtCertificadoDigital_Diretorio = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.txtCertificadoDigital_Senha = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.GroupBox2.SuspendLayout()
    Me.SuspendLayout()
    '
    'cmdAbrirDiretorio
    '
    Me.cmdAbrirDiretorio.Image = Global.SisMattos.My.Resources.Resources.Mini_Diretorio
    Me.cmdAbrirDiretorio.Location = New System.Drawing.Point(5, 31)
    Me.cmdAbrirDiretorio.Name = "cmdAbrirDiretorio"
    Me.cmdAbrirDiretorio.Size = New System.Drawing.Size(20, 20)
    Me.cmdAbrirDiretorio.TabIndex = 156
    Me.cmdAbrirDiretorio.UseVisualStyleBackColor = True
    '
    'txtCertificadoDigital_Diretorio
    '
    Me.txtCertificadoDigital_Diretorio.Location = New System.Drawing.Point(27, 31)
    Me.txtCertificadoDigital_Diretorio.MaxLength = 100
    Me.txtCertificadoDigital_Diretorio.Name = "txtCertificadoDigital_Diretorio"
    Me.txtCertificadoDigital_Diretorio.Size = New System.Drawing.Size(373, 20)
    Me.txtCertificadoDigital_Diretorio.TabIndex = 157
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(5, 16)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(157, 13)
    Me.Label5.TabIndex = 155
    Me.Label5.Text = "Diretório de Imagens e Arquivos"
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.txtCertificadoDigital_Senha)
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Controls.Add(Me.cmdAbrirDiretorio)
    Me.GroupBox2.Controls.Add(Me.txtCertificadoDigital_Diretorio)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Location = New System.Drawing.Point(0, 148)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(406, 99)
    Me.GroupBox2.TabIndex = 159
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Certificado Digital"
    '
    'txtCertificadoDigital_Senha
    '
    Me.txtCertificadoDigital_Senha.Location = New System.Drawing.Point(5, 72)
    Me.txtCertificadoDigital_Senha.MaxLength = 10
    Me.txtCertificadoDigital_Senha.Name = "txtCertificadoDigital_Senha"
    Me.txtCertificadoDigital_Senha.Size = New System.Drawing.Size(100, 20)
    Me.txtCertificadoDigital_Senha.TabIndex = 159
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(5, 57)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(38, 13)
    Me.Label6.TabIndex = 158
    Me.Label6.Text = "Senha"
    '
    'uscParametrizacaoFiscal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.GroupBox2)
    Me.Name = "uscParametrizacaoFiscal"
    Me.Size = New System.Drawing.Size(655, 386)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cmdAbrirDiretorio As Button
  Friend WithEvents txtCertificadoDigital_Diretorio As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents GroupBox2 As GroupBox
  Friend WithEvents txtCertificadoDigital_Senha As TextBox
  Friend WithEvents Label6 As Label
End Class
