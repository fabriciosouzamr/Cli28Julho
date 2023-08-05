<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSEGUsuario_Clinica_Configuracao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboProfissionalPadraoAgendamento = New System.Windows.Forms.ComboBox()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cboContaFinanceiraPadraoVenda = New System.Windows.Forms.ComboBox()
    Me.Label27 = New System.Windows.Forms.Label()
    Me.cboCarregamentoAutomaticoInicializacao = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(181, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Profissional Padrão no Agendamento"
    '
    'cboProfissionalPadraoAgendamento
    '
    Me.cboProfissionalPadraoAgendamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProfissionalPadraoAgendamento.FormattingEnabled = True
    Me.cboProfissionalPadraoAgendamento.Location = New System.Drawing.Point(5, 20)
    Me.cboProfissionalPadraoAgendamento.Name = "cboProfissionalPadraoAgendamento"
    Me.cboProfissionalPadraoAgendamento.Size = New System.Drawing.Size(500, 21)
    Me.cboProfissionalPadraoAgendamento.TabIndex = 1
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(349, 93)
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
    Me.cmdFechar.Location = New System.Drawing.Point(430, 93)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'cboContaFinanceiraPadraoVenda
    '
    Me.cboContaFinanceiraPadraoVenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboContaFinanceiraPadraoVenda.FormattingEnabled = True
    Me.cboContaFinanceiraPadraoVenda.Location = New System.Drawing.Point(5, 62)
    Me.cboContaFinanceiraPadraoVenda.Name = "cboContaFinanceiraPadraoVenda"
    Me.cboContaFinanceiraPadraoVenda.Size = New System.Drawing.Size(289, 21)
    Me.cboContaFinanceiraPadraoVenda.TabIndex = 3
    '
    'Label27
    '
    Me.Label27.AutoSize = True
    Me.Label27.Location = New System.Drawing.Point(5, 47)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(173, 13)
    Me.Label27.TabIndex = 142
    Me.Label27.Text = "Conta Financeira Padrão de Venda"
    '
    'cboCarregamentoAutomaticoInicializacao
    '
    Me.cboCarregamentoAutomaticoInicializacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCarregamentoAutomaticoInicializacao.FormattingEnabled = True
    Me.cboCarregamentoAutomaticoInicializacao.Location = New System.Drawing.Point(300, 62)
    Me.cboCarregamentoAutomaticoInicializacao.Name = "cboCarregamentoAutomaticoInicializacao"
    Me.cboCarregamentoAutomaticoInicializacao.Size = New System.Drawing.Size(205, 21)
    Me.cboCarregamentoAutomaticoInicializacao.TabIndex = 2
    Me.cboCarregamentoAutomaticoInicializacao.Visible = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(300, 47)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(205, 13)
    Me.Label2.TabIndex = 144
    Me.Label2.Text = "Carregamento Automático na Inicialização"
    Me.Label2.Visible = False
    '
    'frmSEGUsuario_Clinica_Configuracao
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(510, 126)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboCarregamentoAutomaticoInicializacao)
    Me.Controls.Add(Me.cboContaFinanceiraPadraoVenda)
    Me.Controls.Add(Me.Label27)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cboProfissionalPadraoAgendamento)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmSEGUsuario_Clinica_Configuracao"
    Me.Text = "Configuração do Usuário"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboProfissionalPadraoAgendamento As System.Windows.Forms.ComboBox
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cboContaFinanceiraPadraoVenda As ComboBox
  Friend WithEvents Label27 As Label
  Friend WithEvents cboCarregamentoAutomaticoInicializacao As ComboBox
  Friend WithEvents Label2 As Label
End Class
