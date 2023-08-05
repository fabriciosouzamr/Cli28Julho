<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancaContasReceberPagar_Compensacao
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
    Me.Label19 = New System.Windows.Forms.Label()
    Me.txtValorCompensacao = New Infragistics.Win.UltraWinEditors.UltraCurrencyEditor()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.txtDataCompensacao = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtComentario = New System.Windows.Forms.TextBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.cmdExcluir = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblRTipoDocumento = New System.Windows.Forms.Label()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.cboContaFinanceira = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboContaFinanceiraTaxaCompensacao = New System.Windows.Forms.ComboBox()
        CType(Me.txtValorCompensacao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDataCompensacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(127, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 13)
        Me.Label19.TabIndex = 84
        Me.Label19.Text = "Valor Compensação"
        '
        'txtValorCompensacao
        '
        Me.txtValorCompensacao.CausesValidation = False
        Me.txtValorCompensacao.Location = New System.Drawing.Point(127, 104)
        Me.txtValorCompensacao.MaskInput = "{currency:-9.2}"
        Me.txtValorCompensacao.Name = "txtValorCompensacao"
        Me.txtValorCompensacao.ReadOnly = True
        Me.txtValorCompensacao.Size = New System.Drawing.Size(110, 21)
        Me.txtValorCompensacao.TabIndex = 3
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(333, 256)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(85, 28)
        Me.cmdGravar.TabIndex = 101
        Me.cmdGravar.Text = "     Compensar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(424, 256)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 102
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'txtDataCompensacao
        '
        Me.txtDataCompensacao.DateTime = New Date(2016, 10, 4, 0, 0, 0, 0)
        Me.txtDataCompensacao.Location = New System.Drawing.Point(5, 104)
        Me.txtDataCompensacao.Name = "txtDataCompensacao"
        Me.txtDataCompensacao.Size = New System.Drawing.Size(85, 21)
        Me.txtDataCompensacao.TabIndex = 2
        Me.txtDataCompensacao.Value = New Date(2016, 10, 4, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Data da Compensação"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(5, 146)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(494, 100)
        Me.txtComentario.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 131)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Comentário"
        '
        'cmdExcluir
        '
        Me.cmdExcluir.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Excluir2
        Me.cmdExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExcluir.Location = New System.Drawing.Point(252, 256)
        Me.cmdExcluir.Name = "cmdExcluir"
        Me.cmdExcluir.Size = New System.Drawing.Size(75, 28)
        Me.cmdExcluir.TabIndex = 100
        Me.cmdExcluir.Text = "Excluir"
        Me.cmdExcluir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Tipo de Documento"
        '
        'lblRTipoDocumento
        '
        Me.lblRTipoDocumento.AutoSize = True
        Me.lblRTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRTipoDocumento.Location = New System.Drawing.Point(243, 108)
        Me.lblRTipoDocumento.Name = "lblRTipoDocumento"
        Me.lblRTipoDocumento.Size = New System.Drawing.Size(118, 13)
        Me.lblRTipoDocumento.TabIndex = 172
        Me.lblRTipoDocumento.Text = "lblRTipoDocumento"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 13)
        Me.Label14.TabIndex = 174
        Me.Label14.Text = "Conta Caixa"
        '
        'cboContaFinanceira
        '
        Me.cboContaFinanceira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaFinanceira.FormattingEnabled = True
        Me.cboContaFinanceira.Location = New System.Drawing.Point(5, 20)
        Me.cboContaFinanceira.Name = "cboContaFinanceira"
        Me.cboContaFinanceira.Size = New System.Drawing.Size(356, 21)
        Me.cboContaFinanceira.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 13)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "Conta Financeira de Lançamento da Taxa de Compensação"
        '
        'cboContaFinanceiraTaxaCompensacao
        '
        Me.cboContaFinanceiraTaxaCompensacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContaFinanceiraTaxaCompensacao.FormattingEnabled = True
        Me.cboContaFinanceiraTaxaCompensacao.Location = New System.Drawing.Point(5, 62)
        Me.cboContaFinanceiraTaxaCompensacao.Name = "cboContaFinanceiraTaxaCompensacao"
        Me.cboContaFinanceiraTaxaCompensacao.Size = New System.Drawing.Size(356, 21)
        Me.cboContaFinanceiraTaxaCompensacao.TabIndex = 175
        '
        'frmLancaContasReceberPagar_Compensacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 291)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboContaFinanceiraTaxaCompensacao)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboContaFinanceira)
        Me.Controls.Add(Me.lblRTipoDocumento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExcluir)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtDataCompensacao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtValorCompensacao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLancaContasReceberPagar_Compensacao"
        Me.Text = "Contas Receber e Pagar - Compensação"
        CType(Me.txtValorCompensacao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDataCompensacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents txtValorCompensacao As Infragistics.Win.UltraWinEditors.UltraCurrencyEditor
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents txtDataCompensacao As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtComentario As System.Windows.Forms.TextBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents cmdExcluir As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblRTipoDocumento As System.Windows.Forms.Label
  Friend WithEvents Label14 As Label
  Friend WithEvents cboContaFinanceira As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboContaFinanceiraTaxaCompensacao As ComboBox
End Class
