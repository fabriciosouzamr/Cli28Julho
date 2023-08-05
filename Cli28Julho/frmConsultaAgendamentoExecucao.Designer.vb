<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAgendamentoExecucao
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
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.lblCodigo = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.lblNomePaciente = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.psqExecutor = New Cli28Julho.uscPesqPessoa()
    Me.SuspendLayout()
    '
    'cmdGravar
    '
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(502, 93)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 205
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(583, 93)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 206
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'lblCodigo
    '
    Me.lblCodigo.AutoSize = True
    Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo.Location = New System.Drawing.Point(7, 24)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(66, 17)
    Me.lblCodigo.TabIndex = 200
    Me.lblCodigo.Text = "lblCodigo"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(7, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(52, 17)
    Me.Label4.TabIndex = 199
    Me.Label4.Text = "Código"
    '
    'lblNomePaciente
    '
    Me.lblNomePaciente.AutoSize = True
    Me.lblNomePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNomePaciente.Location = New System.Drawing.Point(83, 24)
    Me.lblNomePaciente.Name = "lblNomePaciente"
    Me.lblNomePaciente.Size = New System.Drawing.Size(114, 17)
    Me.lblNomePaciente.TabIndex = 198
    Me.lblNomePaciente.Text = "lblNomePaciente"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(83, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(124, 17)
    Me.Label1.TabIndex = 197
    Me.Label1.Text = "Nome do Paciente"
    '
    'psqExecutor
    '
    Me.psqExecutor.AdicionarPessoa = False
    Me.psqExecutor.Bordas = True
    Me.psqExecutor.CarregarTodos = False
    Me.psqExecutor.DS_Pessoa = ""
    Me.psqExecutor.ID_Pessoa = 0
    Me.psqExecutor.LabelVisivel = True
    Me.psqExecutor.Location = New System.Drawing.Point(7, 47)
    Me.psqExecutor.Name = "psqExecutor"
    Me.psqExecutor.PesquisarPessoa = True
    Me.psqExecutor.Rotulo = "Executor"
    Me.psqExecutor.Size = New System.Drawing.Size(570, 36)
    Me.psqExecutor.SomenteLeitura = False
    Me.psqExecutor.TabIndex = 215
    Me.psqExecutor.TipoFiltro = Cli28Julho.uscPesqPessoa.enTipoFiltroPessoa.Funcionario
    '
    'frmConsultaAgendamentoExecucao
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(664, 127)
    Me.Controls.Add(Me.psqExecutor)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.lblCodigo)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.lblNomePaciente)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmConsultaAgendamentoExecucao"
    Me.Text = "Consulta de Agendamento - Execução"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents lblCodigo As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents lblNomePaciente As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents psqExecutor As uscPesqPessoa
End Class
