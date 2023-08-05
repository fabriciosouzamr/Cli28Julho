<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAtendimentoSolicitacaoExameCitologicoLoteChegada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaAtendimentoSolicitacaoExameCitologicoLoteChegada))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDataEnvio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblProfissional = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.cmdFechar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDataChegada = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDataChegada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDataEnvio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblProfissional)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 92)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Lote"
        '
        'lblDataEnvio
        '
        Me.lblDataEnvio.AutoSize = True
        Me.lblDataEnvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataEnvio.Location = New System.Drawing.Point(5, 69)
        Me.lblDataEnvio.Name = "lblDataEnvio"
        Me.lblDataEnvio.Size = New System.Drawing.Size(99, 17)
        Me.lblDataEnvio.TabIndex = 3
        Me.lblDataEnvio.Text = "lblDataEnvio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data de Envio"
        '
        'lblProfissional
        '
        Me.lblProfissional.AutoSize = True
        Me.lblProfissional.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfissional.Location = New System.Drawing.Point(5, 31)
        Me.lblProfissional.Name = "lblProfissional"
        Me.lblProfissional.Size = New System.Drawing.Size(110, 17)
        Me.lblProfissional.TabIndex = 1
        Me.lblProfissional.Text = "lblProfissional"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Profissional"
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = CType(resources.GetObject("cmdGravar.Image"), System.Drawing.Image)
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(544, 149)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 263
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = CType(resources.GetObject("cmdFechar.Image"), System.Drawing.Image)
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(625, 149)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 260
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 262
        Me.Label2.Text = "Data de Chegada"
        '
        'txtDataChegada
        '
        Me.txtDataChegada.Location = New System.Drawing.Point(5, 118)
        Me.txtDataChegada.Name = "txtDataChegada"
        Me.txtDataChegada.Size = New System.Drawing.Size(85, 21)
        Me.txtDataChegada.TabIndex = 261
        '
        'frmConsultaAtendimentoSolicitacaoExameCitologicoLoteChegada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 184)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDataChegada)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsultaAtendimentoSolicitacaoExameCitologicoLoteChegada"
        Me.Text = "Cadastro de Atendimento - Solicitação de Exame Citológicos - Lote - Informar Cheg" &
    "ada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDataChegada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProfissional As Label
    Friend WithEvents lblDataEnvio As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDataChegada As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
End Class
