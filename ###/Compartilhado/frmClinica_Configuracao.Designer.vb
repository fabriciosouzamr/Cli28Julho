<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClinica_Configuracao
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
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpReceituario = New System.Windows.Forms.TabPage()
        Me.tbpAtestado = New System.Windows.Forms.TabPage()
        Me.tbpDadosGerais = New System.Windows.Forms.TabPage()
        Me.oCadClinicaConfiguracao = New Cli28Julho.uscCadClinicaConfiguracao()
        Me.txtReceituario = New System.Windows.Forms.RichTextBox()
        Me.txtAtestado = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.tbpReceituario.SuspendLayout()
        Me.tbpAtestado.SuspendLayout()
        Me.tbpDadosGerais.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(845, 298)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 100
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(926, 298)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 101
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpDadosGerais)
        Me.TabControl1.Controls.Add(Me.tbpReceituario)
        Me.TabControl1.Controls.Add(Me.tbpAtestado)
        Me.TabControl1.Location = New System.Drawing.Point(5, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1000, 283)
        Me.TabControl1.TabIndex = 103
        '
        'tbpReceituario
        '
        Me.tbpReceituario.Controls.Add(Me.txtReceituario)
        Me.tbpReceituario.Location = New System.Drawing.Point(4, 22)
        Me.tbpReceituario.Name = "tbpReceituario"
        Me.tbpReceituario.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpReceituario.Size = New System.Drawing.Size(992, 257)
        Me.tbpReceituario.TabIndex = 0
        Me.tbpReceituario.Text = "Receituário"
        Me.tbpReceituario.UseVisualStyleBackColor = True
        '
        'tbpAtestado
        '
        Me.tbpAtestado.Controls.Add(Me.txtAtestado)
        Me.tbpAtestado.Location = New System.Drawing.Point(4, 22)
        Me.tbpAtestado.Name = "tbpAtestado"
        Me.tbpAtestado.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAtestado.Size = New System.Drawing.Size(992, 257)
        Me.tbpAtestado.TabIndex = 1
        Me.tbpAtestado.Text = "Atestado"
        Me.tbpAtestado.UseVisualStyleBackColor = True
        '
        'tbpDadosGerais
        '
        Me.tbpDadosGerais.Controls.Add(Me.oCadClinicaConfiguracao)
        Me.tbpDadosGerais.Location = New System.Drawing.Point(4, 22)
        Me.tbpDadosGerais.Name = "tbpDadosGerais"
        Me.tbpDadosGerais.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDadosGerais.Size = New System.Drawing.Size(992, 257)
        Me.tbpDadosGerais.TabIndex = 2
        Me.tbpDadosGerais.Text = "Dados Gerais"
        Me.tbpDadosGerais.UseVisualStyleBackColor = True
        '
        'oCadClinicaConfiguracao
        '
        Me.oCadClinicaConfiguracao.Location = New System.Drawing.Point(5, 5)
        Me.oCadClinicaConfiguracao.Name = "oCadClinicaConfiguracao"
        Me.oCadClinicaConfiguracao.Size = New System.Drawing.Size(814, 183)
        Me.oCadClinicaConfiguracao.TabIndex = 103
        '
        'txtReceituario
        '
        Me.txtReceituario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtReceituario.Location = New System.Drawing.Point(3, 3)
        Me.txtReceituario.Name = "txtReceituario"
        Me.txtReceituario.Size = New System.Drawing.Size(986, 251)
        Me.txtReceituario.TabIndex = 0
        Me.txtReceituario.Text = ""
        '
        'txtAtestado
        '
        Me.txtAtestado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAtestado.Location = New System.Drawing.Point(3, 3)
        Me.txtAtestado.Name = "txtAtestado"
        Me.txtAtestado.Size = New System.Drawing.Size(986, 251)
        Me.txtAtestado.TabIndex = 0
        Me.txtAtestado.Text = ""
        '
        'frmClinica_Configuracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 331)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmClinica_Configuracao"
        Me.Text = "Clínica - Configuração"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpReceituario.ResumeLayout(False)
        Me.tbpAtestado.ResumeLayout(False)
        Me.tbpDadosGerais.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbpReceituario As TabPage
    Friend WithEvents tbpAtestado As TabPage
    Friend WithEvents tbpDadosGerais As TabPage
    Friend WithEvents oCadClinicaConfiguracao As uscCadClinicaConfiguracao
    Friend WithEvents txtReceituario As RichTextBox
    Friend WithEvents txtAtestado As RichTextBox
End Class
