<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscConsultaAtendimento_Item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscConsultaAtendimento_Item))
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblPaciente = New System.Windows.Forms.Label()
        Me.lblIdade = New System.Windows.Forms.Label()
        Me.lblTipoAtendimento = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblConfirmacaoChegada = New System.Windows.Forms.Label()
        Me.cmdChamar = New Cli28Julho.uscBotao()
        Me.cmdAtendimento = New Cli28Julho.uscBotao()
        Me.SuspendLayout()
        '
        'lblNumero
        '
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(1, 2)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(65, 22)
        Me.lblNumero.TabIndex = 0
        Me.lblNumero.Text = "lblNumero"
        '
        'lblPaciente
        '
        Me.lblPaciente.BackColor = System.Drawing.Color.Transparent
        Me.lblPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaciente.Location = New System.Drawing.Point(69, 1)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(361, 24)
        Me.lblPaciente.TabIndex = 1
        Me.lblPaciente.Text = "lblPaciente"
        '
        'lblIdade
        '
        Me.lblIdade.BackColor = System.Drawing.Color.Transparent
        Me.lblIdade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblIdade.Location = New System.Drawing.Point(440, 4)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(102, 19)
        Me.lblIdade.TabIndex = 2
        Me.lblIdade.Text = "lblIdade"
        '
        'lblTipoAtendimento
        '
        Me.lblTipoAtendimento.BackColor = System.Drawing.Color.Transparent
        Me.lblTipoAtendimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoAtendimento.Location = New System.Drawing.Point(549, 4)
        Me.lblTipoAtendimento.Name = "lblTipoAtendimento"
        Me.lblTipoAtendimento.Size = New System.Drawing.Size(185, 19)
        Me.lblTipoAtendimento.TabIndex = 3
        Me.lblTipoAtendimento.Text = "lblTipoAtendimento"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(740, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(148, 19)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "lblStatus"
        '
        'lblConfirmacaoChegada
        '
        Me.lblConfirmacaoChegada.BackColor = System.Drawing.Color.Transparent
        Me.lblConfirmacaoChegada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmacaoChegada.Location = New System.Drawing.Point(891, 1)
        Me.lblConfirmacaoChegada.Name = "lblConfirmacaoChegada"
        Me.lblConfirmacaoChegada.Size = New System.Drawing.Size(149, 24)
        Me.lblConfirmacaoChegada.TabIndex = 5
        Me.lblConfirmacaoChegada.Text = "lblConfirmacaoChegada"
        '
        'cmdChamar
        '
        Me.cmdChamar.AutoSize = True
        Me.cmdChamar.Location = New System.Drawing.Point(1049, 0)
        Me.cmdChamar.Name = "cmdChamar"
        Me.cmdChamar.Size = New System.Drawing.Size(91, 21)
        Me.cmdChamar.TabIndex = 6
        '
        'cmdAtendimento
        '
        Me.cmdAtendimento.AutoSize = True
        Me.cmdAtendimento.Location = New System.Drawing.Point(1152, 0)
        Me.cmdAtendimento.Name = "cmdAtendimento"
        Me.cmdAtendimento.Size = New System.Drawing.Size(91, 21)
        Me.cmdAtendimento.TabIndex = 7
        '
        'uscConsultaAtendimento_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.cmdAtendimento)
        Me.Controls.Add(Me.cmdChamar)
        Me.Controls.Add(Me.lblConfirmacaoChegada)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblTipoAtendimento)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.lblPaciente)
        Me.Controls.Add(Me.lblNumero)
        Me.Name = "uscConsultaAtendimento_Item"
        Me.Size = New System.Drawing.Size(1249, 31)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumero As Label
    Friend WithEvents lblPaciente As Label
    Friend WithEvents lblIdade As Label
    Friend WithEvents lblTipoAtendimento As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblConfirmacaoChegada As Label
    Friend WithEvents cmdChamar As uscBotao
    Friend WithEvents cmdAtendimento As uscBotao
End Class
