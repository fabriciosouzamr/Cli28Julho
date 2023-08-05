<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscCadParametrizacaoFiscal
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
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboRateioISSQN = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboCRT_ISSQN = New System.Windows.Forms.ComboBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboTipoContribuicaoICMS = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboCRT = New System.Windows.Forms.ComboBox()
    Me.txtCNAEFiscal = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(412, 41)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(74, 13)
    Me.Label3.TabIndex = 174
    Me.Label3.Text = "Rateio ISSQN"
    '
    'cboRateioISSQN
    '
    Me.cboRateioISSQN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboRateioISSQN.FormattingEnabled = True
    Me.cboRateioISSQN.Location = New System.Drawing.Point(412, 56)
    Me.cboRateioISSQN.Name = "cboRateioISSQN"
    Me.cboRateioISSQN.Size = New System.Drawing.Size(217, 21)
    Me.cboRateioISSQN.TabIndex = 173
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(412, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(217, 13)
    Me.Label2.TabIndex = 172
    Me.Label2.Text = "C.R.T. - Código de Regime Tributário ISSQN"
    '
    'cboCRT_ISSQN
    '
    Me.cboCRT_ISSQN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCRT_ISSQN.FormattingEnabled = True
    Me.cboCRT_ISSQN.Location = New System.Drawing.Point(412, 15)
    Me.cboCRT_ISSQN.Name = "cboCRT_ISSQN"
    Me.cboCRT_ISSQN.Size = New System.Drawing.Size(217, 21)
    Me.cboCRT_ISSQN.TabIndex = 171
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(0, 41)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(149, 13)
    Me.Label4.TabIndex = 170
    Me.Label4.Text = "Tipo de Contribuição de ICMS"
    '
    'cboTipoContribuicaoICMS
    '
    Me.cboTipoContribuicaoICMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoContribuicaoICMS.DropDownWidth = 500
    Me.cboTipoContribuicaoICMS.FormattingEnabled = True
    Me.cboTipoContribuicaoICMS.Location = New System.Drawing.Point(0, 56)
    Me.cboTipoContribuicaoICMS.Name = "cboTipoContribuicaoICMS"
    Me.cboTipoContribuicaoICMS.Size = New System.Drawing.Size(406, 21)
    Me.cboTipoContribuicaoICMS.TabIndex = 167
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(106, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(181, 13)
    Me.Label1.TabIndex = 169
    Me.Label1.Text = "C.R.T. - Código de Regime Tributário"
    '
    'cboCRT
    '
    Me.cboCRT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCRT.FormattingEnabled = True
    Me.cboCRT.Location = New System.Drawing.Point(106, 15)
    Me.cboCRT.Name = "cboCRT"
    Me.cboCRT.Size = New System.Drawing.Size(300, 21)
    Me.cboCRT.TabIndex = 166
    '
    'txtCNAEFiscal
    '
    Me.txtCNAEFiscal.Location = New System.Drawing.Point(0, 15)
    Me.txtCNAEFiscal.MaxLength = 10
    Me.txtCNAEFiscal.Name = "txtCNAEFiscal"
    Me.txtCNAEFiscal.Size = New System.Drawing.Size(100, 20)
    Me.txtCNAEFiscal.TabIndex = 165
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(0, 0)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(66, 13)
    Me.Label7.TabIndex = 168
    Me.Label7.Text = "CNAE Fiscal"
    '
    'uscCadParametrizacaoFiscal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.cboRateioISSQN)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboCRT_ISSQN)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.cboTipoContribuicaoICMS)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.cboCRT)
    Me.Controls.Add(Me.txtCNAEFiscal)
    Me.Controls.Add(Me.Label7)
    Me.Name = "uscCadParametrizacaoFiscal"
    Me.Size = New System.Drawing.Size(629, 77)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label3 As Label
  Friend WithEvents cboRateioISSQN As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents cboCRT_ISSQN As ComboBox
  Friend WithEvents Label4 As Label
  Friend WithEvents cboTipoContribuicaoICMS As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents cboCRT As ComboBox
  Friend WithEvents txtCNAEFiscal As TextBox
  Friend WithEvents Label7 As Label
End Class
