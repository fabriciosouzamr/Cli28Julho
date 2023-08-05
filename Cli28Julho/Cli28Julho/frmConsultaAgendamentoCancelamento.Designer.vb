<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAgendamentoCancelamento
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblNomePaciente = New System.Windows.Forms.Label()
    Me.lblCodigo = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cboStatus = New System.Windows.Forms.ComboBox()
    Me.txtComentario = New System.Windows.Forms.TextBox()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(81, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(124, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Nome do Paciente"
    '
    'lblNomePaciente
    '
    Me.lblNomePaciente.AutoSize = True
    Me.lblNomePaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNomePaciente.Location = New System.Drawing.Point(81, 24)
    Me.lblNomePaciente.Name = "lblNomePaciente"
    Me.lblNomePaciente.Size = New System.Drawing.Size(114, 17)
    Me.lblNomePaciente.TabIndex = 1
    Me.lblNomePaciente.Text = "lblNomePaciente"
    '
    'lblCodigo
    '
    Me.lblCodigo.AutoSize = True
    Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo.Location = New System.Drawing.Point(5, 24)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(66, 17)
    Me.lblCodigo.TabIndex = 3
    Me.lblCodigo.Text = "lblCodigo"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(5, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(52, 17)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Código"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 47)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(125, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Motivo do Cancelamento"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(5, 89)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(60, 13)
    Me.Label5.TabIndex = 5
    Me.Label5.Text = "Comentário"
    '
    'cboStatus
    '
    Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboStatus.FormattingEnabled = True
    Me.cboStatus.Location = New System.Drawing.Point(5, 62)
    Me.cboStatus.Name = "cboStatus"
    Me.cboStatus.Size = New System.Drawing.Size(300, 21)
    Me.cboStatus.TabIndex = 6
    '
    'txtComentario
    '
    Me.txtComentario.Location = New System.Drawing.Point(5, 104)
    Me.txtComentario.Multiline = True
    Me.txtComentario.Name = "txtComentario"
    Me.txtComentario.Size = New System.Drawing.Size(651, 163)
    Me.txtComentario.TabIndex = 7
    '
    'cmdGravar
    '
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(500, 277)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 195
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(581, 277)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 196
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'frmConsultaAgendamentoCancelamento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(664, 311)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.txtComentario)
    Me.Controls.Add(Me.cboStatus)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.lblCodigo)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.lblNomePaciente)
    Me.Controls.Add(Me.Label1)
    Me.MaximizeBox = False
    Me.Name = "frmConsultaAgendamentoCancelamento"
    Me.Text = "Consulta de Agendamento - Cancelamento"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
    Friend WithEvents lblNomePaciente As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
End Class
