<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroModeloDocumentoElemento
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
    Me.lblRNomeElemento = New System.Windows.Forms.Label()
    Me.txtNomeElemento = New System.Windows.Forms.TextBox()
    Me.lblRTexto = New System.Windows.Forms.Label()
    Me.txtTexto = New System.Windows.Forms.TextBox()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.optImagem = New System.Windows.Forms.RadioButton()
    Me.optTexto = New System.Windows.Forms.RadioButton()
    Me.lblRUsarRepositorioImagem = New System.Windows.Forms.Label()
    Me.cboRepositorioImagem = New System.Windows.Forms.ComboBox()
    Me.pnlAlinhamento = New System.Windows.Forms.Panel()
    Me.optAlinharDireita = New System.Windows.Forms.RadioButton()
    Me.optAlinharCentralizado = New System.Windows.Forms.RadioButton()
    Me.optAlinharEsquerda = New System.Windows.Forms.RadioButton()
    Me.pnlTipo = New System.Windows.Forms.Panel()
    Me.cmdFonte = New System.Windows.Forms.Button()
    Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.picImagem = New uscPictureBox()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
    Me.pnlAlinhamento.SuspendLayout()
    Me.pnlTipo.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblRNomeElemento
    '
    Me.lblRNomeElemento.AutoSize = True
    Me.lblRNomeElemento.Location = New System.Drawing.Point(5, 5)
    Me.lblRNomeElemento.Name = "lblRNomeElemento"
    Me.lblRNomeElemento.Size = New System.Drawing.Size(97, 13)
    Me.lblRNomeElemento.TabIndex = 2
    Me.lblRNomeElemento.Text = "Nome do Elemento"
    '
    'txtNomeElemento
    '
    Me.txtNomeElemento.Location = New System.Drawing.Point(5, 20)
    Me.txtNomeElemento.MaxLength = 100
    Me.txtNomeElemento.Name = "txtNomeElemento"
    Me.txtNomeElemento.Size = New System.Drawing.Size(500, 20)
    Me.txtNomeElemento.TabIndex = 1
    '
    'lblRTexto
    '
    Me.lblRTexto.AutoSize = True
    Me.lblRTexto.Location = New System.Drawing.Point(5, 69)
    Me.lblRTexto.Name = "lblRTexto"
    Me.lblRTexto.Size = New System.Drawing.Size(52, 13)
    Me.lblRTexto.TabIndex = 4
    Me.lblRTexto.Text = "lblRTexto"
    '
    'txtTexto
    '
    Me.txtTexto.Location = New System.Drawing.Point(5, 84)
    Me.txtTexto.MaxLength = 1000
    Me.txtTexto.Multiline = True
    Me.txtTexto.Name = "txtTexto"
    Me.txtTexto.Size = New System.Drawing.Size(500, 60)
    Me.txtTexto.TabIndex = 5
    Me.txtTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cmdGravar
    '
    Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(349, 225)
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
    Me.cmdFechar.Location = New System.Drawing.Point(430, 225)
    Me.cmdFechar.Name = "cmdFechar"
    Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
    Me.cmdFechar.TabIndex = 101
    Me.cmdFechar.Text = "  Fechar"
    Me.cmdFechar.UseVisualStyleBackColor = True
    '
    'optImagem
    '
    Me.optImagem.AutoSize = True
    Me.optImagem.Location = New System.Drawing.Point(1, 1)
    Me.optImagem.Name = "optImagem"
    Me.optImagem.Size = New System.Drawing.Size(62, 17)
    Me.optImagem.TabIndex = 2
    Me.optImagem.TabStop = True
    Me.optImagem.Text = "Imagem"
    Me.optImagem.UseVisualStyleBackColor = True
    '
    'optTexto
    '
    Me.optTexto.AutoSize = True
    Me.optTexto.Location = New System.Drawing.Point(69, 1)
    Me.optTexto.Name = "optTexto"
    Me.optTexto.Size = New System.Drawing.Size(52, 17)
    Me.optTexto.TabIndex = 3
    Me.optTexto.TabStop = True
    Me.optTexto.Text = "Texto"
    Me.optTexto.UseVisualStyleBackColor = True
    '
    'lblRUsarRepositorioImagem
    '
    Me.lblRUsarRepositorioImagem.AutoSize = True
    Me.lblRUsarRepositorioImagem.Location = New System.Drawing.Point(5, 179)
    Me.lblRUsarRepositorioImagem.Name = "lblRUsarRepositorioImagem"
    Me.lblRUsarRepositorioImagem.Size = New System.Drawing.Size(155, 13)
    Me.lblRUsarRepositorioImagem.TabIndex = 115
    Me.lblRUsarRepositorioImagem.Text = "Usar do Repositório de Imagem"
    '
    'cboRepositorioImagem
    '
    Me.cboRepositorioImagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboRepositorioImagem.FormattingEnabled = True
    Me.cboRepositorioImagem.Location = New System.Drawing.Point(5, 194)
    Me.cboRepositorioImagem.Name = "cboRepositorioImagem"
    Me.cboRepositorioImagem.Size = New System.Drawing.Size(500, 21)
    Me.cboRepositorioImagem.TabIndex = 6
    '
    'pnlAlinhamento
    '
    Me.pnlAlinhamento.Controls.Add(Me.optAlinharDireita)
    Me.pnlAlinhamento.Controls.Add(Me.optAlinharCentralizado)
    Me.pnlAlinhamento.Controls.Add(Me.optAlinharEsquerda)
    Me.pnlAlinhamento.Location = New System.Drawing.Point(172, 181)
    Me.pnlAlinhamento.Name = "pnlAlinhamento"
    Me.pnlAlinhamento.Size = New System.Drawing.Size(300, 21)
    Me.pnlAlinhamento.TabIndex = 117
    '
    'optAlinharDireita
    '
    Me.optAlinharDireita.AutoSize = True
    Me.optAlinharDireita.Location = New System.Drawing.Point(201, 1)
    Me.optAlinharDireita.Name = "optAlinharDireita"
    Me.optAlinharDireita.Size = New System.Drawing.Size(90, 17)
    Me.optAlinharDireita.TabIndex = 9
    Me.optAlinharDireita.Text = "Alinhar Direita"
    Me.optAlinharDireita.UseVisualStyleBackColor = True
    '
    'optAlinharCentralizado
    '
    Me.optAlinharCentralizado.AutoSize = True
    Me.optAlinharCentralizado.Checked = True
    Me.optAlinharCentralizado.Location = New System.Drawing.Point(112, 1)
    Me.optAlinharCentralizado.Name = "optAlinharCentralizado"
    Me.optAlinharCentralizado.Size = New System.Drawing.Size(83, 17)
    Me.optAlinharCentralizado.TabIndex = 8
    Me.optAlinharCentralizado.TabStop = True
    Me.optAlinharCentralizado.Text = "Centralizado"
    Me.optAlinharCentralizado.UseVisualStyleBackColor = True
    '
    'optAlinharEsquerda
    '
    Me.optAlinharEsquerda.AutoSize = True
    Me.optAlinharEsquerda.Location = New System.Drawing.Point(1, 1)
    Me.optAlinharEsquerda.Name = "optAlinharEsquerda"
    Me.optAlinharEsquerda.Size = New System.Drawing.Size(105, 17)
    Me.optAlinharEsquerda.TabIndex = 7
    Me.optAlinharEsquerda.Tag = ""
    Me.optAlinharEsquerda.Text = "Alinhar Esquerda"
    Me.optAlinharEsquerda.UseVisualStyleBackColor = True
    '
    'pnlTipo
    '
    Me.pnlTipo.Controls.Add(Me.optTexto)
    Me.pnlTipo.Controls.Add(Me.optImagem)
    Me.pnlTipo.Location = New System.Drawing.Point(5, 46)
    Me.pnlTipo.Name = "pnlTipo"
    Me.pnlTipo.Size = New System.Drawing.Size(122, 19)
    Me.pnlTipo.TabIndex = 118
    '
    'cmdFonte
    '
    Me.cmdFonte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdFonte.Location = New System.Drawing.Point(477, 150)
    Me.cmdFonte.Name = "cmdFonte"
    Me.cmdFonte.Size = New System.Drawing.Size(28, 28)
    Me.cmdFonte.TabIndex = 120
    Me.cmdFonte.TabStop = False
    Me.cmdFonte.Text = "F"
    Me.cmdFonte.UseVisualStyleBackColor = True
    '
    'picImagem
    '
    Me.picImagem.Arquivo = ""
    Me.picImagem.BotaoExcluir = True
    Me.picImagem.HabilitarBotoes = True
    Me.picImagem.Image = Nothing
    Me.picImagem.Location = New System.Drawing.Point(5, 84)
    Me.picImagem.Name = "picImagem"
    Me.picImagem.SelecionarImagem = True
    Me.picImagem.Size = New System.Drawing.Size(500, 89)
    Me.picImagem.TabIndex = 6
    '
    'chkAtivo
    '
    Me.chkAtivo.AutoSize = True
    Me.chkAtivo.Location = New System.Drawing.Point(455, 48)
    Me.chkAtivo.Name = "chkAtivo"
    Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
    Me.chkAtivo.TabIndex = 4
    Me.chkAtivo.Text = "Ativo"
    Me.chkAtivo.UseVisualStyleBackColor = True
    '
    'frmCadastroModeloDocumentoElemento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdFechar
    Me.ClientSize = New System.Drawing.Size(510, 257)
    Me.Controls.Add(Me.chkAtivo)
    Me.Controls.Add(Me.cmdFonte)
    Me.Controls.Add(Me.pnlTipo)
    Me.Controls.Add(Me.pnlAlinhamento)
    Me.Controls.Add(Me.cboRepositorioImagem)
    Me.Controls.Add(Me.lblRUsarRepositorioImagem)
    Me.Controls.Add(Me.cmdFechar)
    Me.Controls.Add(Me.cmdGravar)
    Me.Controls.Add(Me.lblRTexto)
    Me.Controls.Add(Me.txtNomeElemento)
    Me.Controls.Add(Me.lblRNomeElemento)
    Me.Controls.Add(Me.txtTexto)
    Me.Controls.Add(Me.picImagem)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroModeloDocumentoElemento"
    Me.Text = "Cadastro de Modelos de Documento"
    Me.pnlAlinhamento.ResumeLayout(False)
    Me.pnlAlinhamento.PerformLayout()
    Me.pnlTipo.ResumeLayout(False)
    Me.pnlTipo.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblRNomeElemento As System.Windows.Forms.Label
  Friend WithEvents txtNomeElemento As System.Windows.Forms.TextBox
  Friend WithEvents lblRTexto As System.Windows.Forms.Label
  Friend WithEvents txtTexto As System.Windows.Forms.TextBox
    Friend WithEvents picImagem As uscPictureBox
    Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents optImagem As System.Windows.Forms.RadioButton
  Friend WithEvents optTexto As System.Windows.Forms.RadioButton
  Friend WithEvents lblRUsarRepositorioImagem As System.Windows.Forms.Label
  Friend WithEvents cboRepositorioImagem As System.Windows.Forms.ComboBox
  Friend WithEvents pnlAlinhamento As System.Windows.Forms.Panel
  Friend WithEvents optAlinharEsquerda As System.Windows.Forms.RadioButton
  Friend WithEvents optAlinharDireita As System.Windows.Forms.RadioButton
  Friend WithEvents optAlinharCentralizado As System.Windows.Forms.RadioButton
  Friend WithEvents pnlTipo As System.Windows.Forms.Panel
  Friend WithEvents cmdFonte As System.Windows.Forms.Button
  Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
  Friend WithEvents chkAtivo As CheckBox
End Class
