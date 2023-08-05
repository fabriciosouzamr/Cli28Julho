<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroFinanciamento
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
    Me.txtNomeFinanciamento = New System.Windows.Forms.TextBox()
    Me.psqFinanciador = New uscPesqPessoa()
    Me.cboModeloContrato = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtPercEntrada = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtJurosMes = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtMaximoParcela = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtMininoParcela = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.chkAtivo = New System.Windows.Forms.CheckBox()
    Me.cklTabelaPreco = New System.Windows.Forms.CheckedListBox()
    CType(Me.txtPercEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtJurosMes, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMaximoParcela, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.txtMininoParcela, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(122, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Nome do Financiamento"
    '
    'txtNomeFinanciamento
    '
    Me.txtNomeFinanciamento.Location = New System.Drawing.Point(5, 20)
    Me.txtNomeFinanciamento.MaxLength = 100
    Me.txtNomeFinanciamento.Name = "txtNomeFinanciamento"
    Me.txtNomeFinanciamento.Size = New System.Drawing.Size(508, 20)
    Me.txtNomeFinanciamento.TabIndex = 1
    '
    'psqFinanciador
    '
    Me.psqFinanciador.AdicionarPessoa = False
    Me.psqFinanciador.CarregarTodos = False
    Me.psqFinanciador.DS_Pessoa = ""
    Me.psqFinanciador.ID_Pessoa = 0
    Me.psqFinanciador.Location = New System.Drawing.Point(5, 46)
    Me.psqFinanciador.Name = "psqFinanciador"
    Me.psqFinanciador.Rotulo = "Financiador"
    Me.psqFinanciador.Size = New System.Drawing.Size(508, 36)
    Me.psqFinanciador.TabIndex = 2
    Me.psqFinanciador.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Juridica
    '
    'cboModeloContrato
    '
    Me.cboModeloContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboModeloContrato.FormattingEnabled = True
    Me.cboModeloContrato.Location = New System.Drawing.Point(5, 103)
    Me.cboModeloContrato.Name = "cboModeloContrato"
    Me.cboModeloContrato.Size = New System.Drawing.Size(508, 21)
    Me.cboModeloContrato.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 88)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(100, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Modelo de Contrato"
    '
    'txtPercEntrada
    '
    Me.txtPercEntrada.FormatString = ""
    Me.txtPercEntrada.Location = New System.Drawing.Point(5, 145)
    Me.txtPercEntrada.MaskInput = "{double:3.4}"
    Me.txtPercEntrada.Name = "txtPercEntrada"
    Me.txtPercEntrada.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
    Me.txtPercEntrada.Size = New System.Drawing.Size(61, 21)
    Me.txtPercEntrada.TabIndex = 4
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(5, 130)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(61, 13)
    Me.Label9.TabIndex = 23
    Me.Label9.Text = "Entrada (%)"
    '
    'txtJurosMes
    '
    Me.txtJurosMes.FormatString = ""
    Me.txtJurosMes.Location = New System.Drawing.Point(72, 145)
    Me.txtJurosMes.MaskInput = "{double:3.4}"
    Me.txtJurosMes.Name = "txtJurosMes"
    Me.txtJurosMes.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
    Me.txtJurosMes.Size = New System.Drawing.Size(72, 21)
    Me.txtJurosMes.TabIndex = 5
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(72, 130)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(72, 13)
    Me.Label10.TabIndex = 26
    Me.Label10.Text = "Juros a.m. (%)"
    '
    'txtMaximoParcela
    '
    Me.txtMaximoParcela.Location = New System.Drawing.Point(407, 145)
    Me.txtMaximoParcela.MaskInput = "nnnnnn"
    Me.txtMaximoParcela.MaxValue = 100
    Me.txtMaximoParcela.MinValue = 1
    Me.txtMaximoParcela.Name = "txtMaximoParcela"
    Me.txtMaximoParcela.Size = New System.Drawing.Size(50, 21)
    Me.txtMaximoParcela.TabIndex = 7
    Me.txtMaximoParcela.Value = 1
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(228, 130)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(111, 13)
    Me.Label18.TabIndex = 135
    Me.Label18.Text = "Nº Mínimo de Parcela"
    Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(345, 130)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(112, 13)
    Me.Label4.TabIndex = 136
    Me.Label4.Text = "Nº Máximo de Parcela"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtMininoParcela
    '
    Me.txtMininoParcela.Location = New System.Drawing.Point(289, 145)
    Me.txtMininoParcela.MaskInput = "nnnnnn"
    Me.txtMininoParcela.MaxValue = 100
    Me.txtMininoParcela.MinValue = 1
    Me.txtMininoParcela.Name = "txtMininoParcela"
    Me.txtMininoParcela.Size = New System.Drawing.Size(50, 21)
    Me.txtMininoParcela.TabIndex = 6
    Me.txtMininoParcela.Value = 1
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(5, 172)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(86, 13)
    Me.Label5.TabIndex = 138
    Me.Label5.Text = "Tabela de Preço"
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(357, 321)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 100
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'cmdFechar
    '
    Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
    Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdFechar.Location = New System.Drawing.Point(438, 321)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'chkAtivo
    '
    Me.chkAtivo.AutoSize = True
    Me.chkAtivo.Location = New System.Drawing.Point(463, 145)
    Me.chkAtivo.Name = "chkAtivo"
    Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
    Me.chkAtivo.TabIndex = 8
    Me.chkAtivo.Text = "Ativo"
    Me.chkAtivo.UseVisualStyleBackColor = True
    '
    'cklTabelaPreco
    '
    Me.cklTabelaPreco.FormattingEnabled = True
    Me.cklTabelaPreco.Location = New System.Drawing.Point(5, 187)
    Me.cklTabelaPreco.Name = "cklTabelaPreco"
    Me.cklTabelaPreco.Size = New System.Drawing.Size(508, 124)
    Me.cklTabelaPreco.TabIndex = 9
    '
    'frmCadastroFinanciamento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdFechar
    Me.ClientSize = New System.Drawing.Size(521, 355)
    Me.Controls.Add(Me.cklTabelaPreco)
    Me.Controls.Add(Me.chkAtivo)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtMininoParcela)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtMaximoParcela)
    Me.Controls.Add(Me.Label18)
    Me.Controls.Add(Me.txtPercEntrada)
    Me.Controls.Add(Me.Label9)
    Me.Controls.Add(Me.txtJurosMes)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboModeloContrato)
    Me.Controls.Add(Me.psqFinanciador)
    Me.Controls.Add(Me.txtNomeFinanciamento)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroFinanciamento"
    Me.Text = "Cadastro de Financiamento"
    CType(Me.txtPercEntrada, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtJurosMes, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMaximoParcela, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.txtMininoParcela, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents txtNomeFinanciamento As TextBox
  Friend WithEvents psqFinanciador As uscPesqPessoa
  Friend WithEvents cboModeloContrato As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents txtPercEntrada As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label9 As Label
  Friend WithEvents txtJurosMes As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label10 As Label
  Friend WithEvents txtMaximoParcela As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label18 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents txtMininoParcela As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label5 As Label
  Friend WithEvents cmdGravar As Button
  Friend WithEvents cmdFechar As Button
  Friend WithEvents chkAtivo As CheckBox
  Friend WithEvents cklTabelaPreco As CheckedListBox
End Class
