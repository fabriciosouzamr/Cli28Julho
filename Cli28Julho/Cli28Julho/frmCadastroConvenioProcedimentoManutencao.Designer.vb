<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroConvenioProcedimentoManutencao
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroConvenioProcedimentoManutencao))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.optReajustePreco = New System.Windows.Forms.RadioButton()
    Me.optReajustePrestador = New System.Windows.Forms.RadioButton()
    Me.cboReajusteConvenio = New System.Windows.Forms.ComboBox()
    Me.cboCopiarTabela_ConvenioOrigem = New System.Windows.Forms.ComboBox()
    Me.cboCopiarTabela_ConvenioDestino = New System.Windows.Forms.ComboBox()
    Me.cboReajustePrestador = New System.Windows.Forms.ComboBox()
    Me.cboReajusteGrupoProcedimento = New System.Windows.Forms.ComboBox()
    Me.txtReajusteValor = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.cmdExecutarCopiaTabela = New Cli28Julho.uscBotao()
    Me.cmdExecutarReajuste = New Cli28Julho.uscBotao()
    Me.cmdFechar = New Cli28Julho.uscBotao()
    Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReajusteValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGeral
        '
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(644, 272)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'optReajustePreco
        '
        Me.optReajustePreco.AutoSize = True
        Me.optReajustePreco.Location = New System.Drawing.Point(170, 255)
        Me.optReajustePreco.Name = "optReajustePreco"
        Me.optReajustePreco.Size = New System.Drawing.Size(14, 13)
        Me.optReajustePreco.TabIndex = 4
        Me.optReajustePreco.TabStop = True
        Me.optReajustePreco.UseVisualStyleBackColor = True
        '
        'optReajustePrestador
        '
        Me.optReajustePrestador.AutoSize = True
        Me.optReajustePrestador.Location = New System.Drawing.Point(211, 255)
        Me.optReajustePrestador.Name = "optReajustePrestador"
        Me.optReajustePrestador.Size = New System.Drawing.Size(14, 13)
        Me.optReajustePrestador.TabIndex = 5
        Me.optReajustePrestador.TabStop = True
        Me.optReajustePrestador.UseVisualStyleBackColor = True
        '
        'cboReajusteConvenio
        '
        Me.cboReajusteConvenio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReajusteConvenio.FormattingEnabled = True
        Me.cboReajusteConvenio.Location = New System.Drawing.Point(117, 129)
        Me.cboReajusteConvenio.Name = "cboReajusteConvenio"
        Me.cboReajusteConvenio.Size = New System.Drawing.Size(142, 21)
        Me.cboReajusteConvenio.TabIndex = 6
        '
        'cboCopiarTabela_ConvenioOrigem
        '
        Me.cboCopiarTabela_ConvenioOrigem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.cboCopiarTabela_ConvenioOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCopiarTabela_ConvenioOrigem.FormattingEnabled = True
        Me.cboCopiarTabela_ConvenioOrigem.Location = New System.Drawing.Point(492, 129)
        Me.cboCopiarTabela_ConvenioOrigem.Name = "cboCopiarTabela_ConvenioOrigem"
        Me.cboCopiarTabela_ConvenioOrigem.Size = New System.Drawing.Size(142, 21)
        Me.cboCopiarTabela_ConvenioOrigem.TabIndex = 7
        '
        'cboCopiarTabela_ConvenioDestino
        '
        Me.cboCopiarTabela_ConvenioDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCopiarTabela_ConvenioDestino.FormattingEnabled = True
        Me.cboCopiarTabela_ConvenioDestino.Location = New System.Drawing.Point(492, 162)
        Me.cboCopiarTabela_ConvenioDestino.Name = "cboCopiarTabela_ConvenioDestino"
        Me.cboCopiarTabela_ConvenioDestino.Size = New System.Drawing.Size(142, 21)
        Me.cboCopiarTabela_ConvenioDestino.TabIndex = 8
        '
        'cboReajustePrestador
        '
        Me.cboReajustePrestador.FormattingEnabled = True
        Me.cboReajustePrestador.Location = New System.Drawing.Point(117, 160)
        Me.cboReajustePrestador.Name = "cboReajustePrestador"
        Me.cboReajustePrestador.Size = New System.Drawing.Size(237, 21)
        Me.cboReajustePrestador.TabIndex = 9
        '
        'cboReajusteGrupoProcedimento
        '
        Me.cboReajusteGrupoProcedimento.FormattingEnabled = True
        Me.cboReajusteGrupoProcedimento.Location = New System.Drawing.Point(117, 188)
        Me.cboReajusteGrupoProcedimento.Name = "cboReajusteGrupoProcedimento"
        Me.cboReajusteGrupoProcedimento.Size = New System.Drawing.Size(237, 21)
        Me.cboReajusteGrupoProcedimento.TabIndex = 10
        '
        'txtReajusteValor
        '
        Me.txtReajusteValor.Location = New System.Drawing.Point(117, 245)
        Me.txtReajusteValor.MaskInput = "{double:-9.4}"
        Me.txtReajusteValor.Name = "txtReajusteValor"
        Me.txtReajusteValor.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
        Me.txtReajusteValor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtReajusteValor.Size = New System.Drawing.Size(60, 21)
        Me.txtReajusteValor.SpinButtonAlignment = Infragistics.Win.ButtonAlignment.Left
        Me.txtReajusteValor.TabIndex = 12
        '
        'cmdExecutarCopiaTabela
        '
        Me.cmdExecutarCopiaTabela.AutoSize = True
        Me.cmdExecutarCopiaTabela.Location = New System.Drawing.Point(520, 192)
        Me.cmdExecutarCopiaTabela.Name = "cmdExecutarCopiaTabela"
        Me.cmdExecutarCopiaTabela.Size = New System.Drawing.Size(16, 17)
        Me.cmdExecutarCopiaTabela.TabIndex = 3
        '
        'cmdExecutarReajuste
        '
        Me.cmdExecutarReajuste.AutoSize = True
        Me.cmdExecutarReajuste.Location = New System.Drawing.Point(271, 243)
        Me.cmdExecutarReajuste.Name = "cmdExecutarReajuste"
        Me.cmdExecutarReajuste.Size = New System.Drawing.Size(16, 17)
        Me.cmdExecutarReajuste.TabIndex = 2
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(193, 28)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 1
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = True
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.GrupoProcedimento = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = False
        Me.psqProcedimento.Location = New System.Drawing.Point(117, 216)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(237, 22)
        Me.psqProcedimento.TabIndex = 13
        '
        'frmCadastroConvenioProcedimentoManutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 281)
        Me.Controls.Add(Me.psqProcedimento)
        Me.Controls.Add(Me.txtReajusteValor)
        Me.Controls.Add(Me.cboReajusteGrupoProcedimento)
        Me.Controls.Add(Me.cboReajustePrestador)
        Me.Controls.Add(Me.cboCopiarTabela_ConvenioDestino)
        Me.Controls.Add(Me.cboCopiarTabela_ConvenioOrigem)
        Me.Controls.Add(Me.cboReajusteConvenio)
        Me.Controls.Add(Me.optReajustePrestador)
        Me.Controls.Add(Me.optReajustePreco)
        Me.Controls.Add(Me.cmdExecutarCopiaTabela)
        Me.Controls.Add(Me.cmdExecutarReajuste)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.picGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastroConvenioProcedimentoManutencao"
        Me.Text = "Cadastro de Exames/Procecimentos por Convênio (Manuentação)"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReajusteValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
  Friend WithEvents cmdFechar As uscBotao
  Friend WithEvents cmdExecutarReajuste As uscBotao
  Friend WithEvents cmdExecutarCopiaTabela As uscBotao
  Friend WithEvents optReajustePreco As RadioButton
  Friend WithEvents optReajustePrestador As RadioButton
  Friend WithEvents cboReajusteConvenio As ComboBox
  Friend WithEvents cboCopiarTabela_ConvenioOrigem As ComboBox
  Friend WithEvents cboCopiarTabela_ConvenioDestino As ComboBox
  Friend WithEvents cboReajustePrestador As ComboBox
  Friend WithEvents cboReajusteGrupoProcedimento As ComboBox
  Friend WithEvents txtReajusteValor As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents psqProcedimento As uscPesqProcedimento
End Class
