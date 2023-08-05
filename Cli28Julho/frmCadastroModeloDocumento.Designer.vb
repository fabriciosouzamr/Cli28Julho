<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroModeloDocumento
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
    Me.cboTipoModeloDocumento = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtNomeModeloDocumento = New System.Windows.Forms.TextBox()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboModeloCabecalho = New System.Windows.Forms.ComboBox()
    Me.cboModeloAssinatura = New System.Windows.Forms.ComboBox()
    Me.cboModeloRodape = New System.Windows.Forms.ComboBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.chkExibirNumeroPagina = New System.Windows.Forms.CheckBox()
        Me.oEditorTexto = New uscEditorTexto()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
    Me.cboProcesso = New System.Windows.Forms.ComboBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(5, 5)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(154, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Tipo de Modelo de Documento"
    '
    'cboTipoModeloDocumento
    '
    Me.cboTipoModeloDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoModeloDocumento.FormattingEnabled = True
    Me.cboTipoModeloDocumento.Location = New System.Drawing.Point(5, 20)
    Me.cboTipoModeloDocumento.Name = "cboTipoModeloDocumento"
    Me.cboTipoModeloDocumento.Size = New System.Drawing.Size(154, 21)
    Me.cboTipoModeloDocumento.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(165, 5)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(161, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Nome do Modelo de Documento"
    '
    'txtNomeModeloDocumento
    '
    Me.txtNomeModeloDocumento.Location = New System.Drawing.Point(165, 20)
    Me.txtNomeModeloDocumento.MaxLength = 100
    Me.txtNomeModeloDocumento.Name = "txtNomeModeloDocumento"
    Me.txtNomeModeloDocumento.Size = New System.Drawing.Size(450, 20)
    Me.txtNomeModeloDocumento.TabIndex = 2
    '
    'cmdFechar
    '
    Me.cmdFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdFechar.Image = My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(815, 68)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 101
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdGravar.Location = New System.Drawing.Point(734, 68)
    Me.cmdGravar.Name = "cmdGravar"
    Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdGravar.TabIndex = 100
    Me.cmdGravar.Text = "  Gravar"
    Me.cmdGravar.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 424)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(58, 13)
    Me.Label4.TabIndex = 194
    Me.Label4.Text = "Cabeçalho"
    '
    'cboModeloCabecalho
    '
    Me.cboModeloCabecalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboModeloCabecalho.FormattingEnabled = True
    Me.cboModeloCabecalho.Location = New System.Drawing.Point(5, 14)
    Me.cboModeloCabecalho.Name = "cboModeloCabecalho"
    Me.cboModeloCabecalho.Size = New System.Drawing.Size(291, 21)
    Me.cboModeloCabecalho.TabIndex = 5
    '
    'cboModeloAssinatura
    '
    Me.cboModeloAssinatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboModeloAssinatura.Enabled = False
    Me.cboModeloAssinatura.FormattingEnabled = True
    Me.cboModeloAssinatura.Location = New System.Drawing.Point(302, 14)
    Me.cboModeloAssinatura.Name = "cboModeloAssinatura"
    Me.cboModeloAssinatura.Size = New System.Drawing.Size(291, 21)
    Me.cboModeloAssinatura.TabIndex = 6
    '
    'cboModeloRodape
    '
    Me.cboModeloRodape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboModeloRodape.FormattingEnabled = True
    Me.cboModeloRodape.Location = New System.Drawing.Point(599, 14)
    Me.cboModeloRodape.Name = "cboModeloRodape"
    Me.cboModeloRodape.Size = New System.Drawing.Size(291, 21)
    Me.cboModeloRodape.TabIndex = 7
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(302, 424)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(56, 13)
    Me.Label5.TabIndex = 198
    Me.Label5.Text = "Assinatura"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(599, 424)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(45, 13)
    Me.Label6.TabIndex = 199
    Me.Label6.Text = "Rodapé"
    '
    'chkExibirNumeroPagina
    '
    Me.chkExibirNumeroPagina.AutoSize = True
    Me.chkExibirNumeroPagina.Location = New System.Drawing.Point(61, 41)
    Me.chkExibirNumeroPagina.Name = "chkExibirNumeroPagina"
    Me.chkExibirNumeroPagina.Size = New System.Drawing.Size(142, 17)
    Me.chkExibirNumeroPagina.TabIndex = 9
    Me.chkExibirNumeroPagina.Text = "Exibir Número de Página"
    Me.chkExibirNumeroPagina.UseVisualStyleBackColor = True
    '
    'oEditorTexto
    '
    Me.oEditorTexto.DICIONARIODADO_PROCESSO = 0
    Me.oEditorTexto.Dock = System.Windows.Forms.DockStyle.Fill
    Me.oEditorTexto.ExibirNumeroPagina = False
    Me.oEditorTexto.IDENTIFICADOR = 0
    Me.oEditorTexto.Location = New System.Drawing.Point(0, 0)
    Me.oEditorTexto.MODELO_ASSINATURA = 0
    Me.oEditorTexto.MODELO_CABECALHO = 0
    Me.oEditorTexto.MODELO_RODAPE = 0
    Me.oEditorTexto.MODELODOCUMENTO = 0
    Me.oEditorTexto.Name = "oEditorTexto"
    Me.oEditorTexto.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft S" &
    "ans Serif;}}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs17\par" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
    Me.oEditorTexto.Size = New System.Drawing.Size(893, 378)
    Me.oEditorTexto.SoLeitura = False
    Me.oEditorTexto.TabIndex = 4
    Me.oEditorTexto.Texto = ""
    Me.oEditorTexto.TIPO_MODELODOCUMENTO = 0
    '
    'chkAtivo
    '
    Me.chkAtivo.AutoSize = True
    Me.chkAtivo.Checked = True
    Me.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkAtivo.Location = New System.Drawing.Point(5, 41)
    Me.chkAtivo.Name = "chkAtivo"
    Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
    Me.chkAtivo.TabIndex = 8
    Me.chkAtivo.Text = "Ativo"
    Me.chkAtivo.UseVisualStyleBackColor = True
    '
    'cboProcesso
    '
    Me.cboProcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProcesso.FormattingEnabled = True
    Me.cboProcesso.Location = New System.Drawing.Point(621, 20)
    Me.cboProcesso.Name = "cboProcesso"
    Me.cboProcesso.Size = New System.Drawing.Size(269, 21)
    Me.cboProcesso.TabIndex = 3
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(621, 5)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(51, 13)
    Me.Label7.TabIndex = 205
    Me.Label7.Text = "Processo"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.chkAtivo)
    Me.Panel1.Controls.Add(Me.chkExibirNumeroPagina)
    Me.Panel1.Controls.Add(Me.cboModeloRodape)
    Me.Panel1.Controls.Add(Me.cboModeloAssinatura)
    Me.Panel1.Controls.Add(Me.cboModeloCabecalho)
    Me.Panel1.Controls.Add(Me.cmdGravar)
    Me.Panel1.Controls.Add(Me.cmdFechar)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.Panel1.Location = New System.Drawing.Point(0, 426)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(895, 99)
    Me.Panel1.TabIndex = 206
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.Label7)
    Me.Panel2.Controls.Add(Me.cboProcesso)
    Me.Panel2.Controls.Add(Me.txtNomeModeloDocumento)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.cboTipoModeloDocumento)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(895, 44)
    Me.Panel2.TabIndex = 207
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.oEditorTexto)
    Me.Panel3.Controls.Add(Me.Label3)
    Me.Panel3.Location = New System.Drawing.Point(0, 48)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(893, 378)
    Me.Panel3.TabIndex = 208
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(3, 1)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(34, 13)
    Me.Label3.TabIndex = 202
    Me.Label3.Text = "Texto"
    '
    'frmCadastroModeloDocumento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.cmdFechar
    Me.ClientSize = New System.Drawing.Size(895, 525)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.Panel1)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Panel3)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Name = "frmCadastroModeloDocumento"
    Me.Text = "Cadastro de Modelos de Documento"
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboTipoModeloDocumento As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtNomeModeloDocumento As System.Windows.Forms.TextBox
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cboModeloCabecalho As System.Windows.Forms.ComboBox
  Friend WithEvents cboModeloAssinatura As System.Windows.Forms.ComboBox
  Friend WithEvents cboModeloRodape As System.Windows.Forms.ComboBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents chkExibirNumeroPagina As System.Windows.Forms.CheckBox
    Friend WithEvents oEditorTexto As uscEditorTexto
    Friend WithEvents chkAtivo As System.Windows.Forms.CheckBox
  Friend WithEvents cboProcesso As System.Windows.Forms.ComboBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As Panel
  Friend WithEvents Panel2 As Panel
  Friend WithEvents Panel3 As Panel
  Friend WithEvents Label3 As Label
End Class
