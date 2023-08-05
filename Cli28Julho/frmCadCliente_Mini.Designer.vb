<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadCliente_Mini
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
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.cboTipoPessoa = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCNPJ_CPF = New System.Windows.Forms.TextBox()
        Me.lblRotulo_CNPJCPF = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCidade = New System.Windows.Forms.ComboBox()
        Me.cboUF = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtInformaoesComplementares = New System.Windows.Forms.TextBox()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdGravar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Cliente"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.Location = New System.Drawing.Point(5, 20)
        Me.txtNomeCliente.MaxLength = 100
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(400, 20)
        Me.txtNomeCliente.TabIndex = 1
        '
        'cboTipoPessoa
        '
        Me.cboTipoPessoa.FormattingEnabled = True
        Me.cboTipoPessoa.Location = New System.Drawing.Point(410, 20)
        Me.cboTipoPessoa.Name = "cboTipoPessoa"
        Me.cboTipoPessoa.Size = New System.Drawing.Size(125, 21)
        Me.cboTipoPessoa.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(410, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de Pessoa"
        '
        'txtCNPJ_CPF
        '
        Me.txtCNPJ_CPF.Location = New System.Drawing.Point(5, 60)
        Me.txtCNPJ_CPF.MaxLength = 100
        Me.txtCNPJ_CPF.Name = "txtCNPJ_CPF"
        Me.txtCNPJ_CPF.Size = New System.Drawing.Size(115, 20)
        Me.txtCNPJ_CPF.TabIndex = 4
        '
        'lblRotulo_CNPJCPF
        '
        Me.lblRotulo_CNPJCPF.AutoSize = True
        Me.lblRotulo_CNPJCPF.Location = New System.Drawing.Point(5, 45)
        Me.lblRotulo_CNPJCPF.Name = "lblRotulo_CNPJCPF"
        Me.lblRotulo_CNPJCPF.Size = New System.Drawing.Size(59, 13)
        Me.lblRotulo_CNPJCPF.TabIndex = 5
        Me.lblRotulo_CNPJCPF.Text = "CNPJ/CPF"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(125, 60)
        Me.txtLogradouro.MaxLength = 100
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(410, 20)
        Me.txtLogradouro.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Logradouro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Número"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(5, 100)
        Me.txtNumero.MaxLength = 100
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(50, 20)
        Me.txtNumero.TabIndex = 9
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(60, 100)
        Me.txtBairro.MaxLength = 100
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(173, 20)
        Me.txtBairro.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Bairro"
        '
        'cboCidade
        '
        Me.cboCidade.FormattingEnabled = True
        Me.cboCidade.Location = New System.Drawing.Point(238, 100)
        Me.cboCidade.Name = "cboCidade"
        Me.cboCidade.Size = New System.Drawing.Size(173, 21)
        Me.cboCidade.TabIndex = 12
        '
        'cboUF
        '
        Me.cboUF.FormattingEnabled = True
        Me.cboUF.Location = New System.Drawing.Point(415, 100)
        Me.cboUF.Name = "cboUF"
        Me.cboUF.Size = New System.Drawing.Size(50, 21)
        Me.cboUF.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cidade"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "U.F."
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(470, 100)
        Me.txtCEP.MaxLength = 100
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(65, 20)
        Me.txtCEP.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "C.E.P."
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(5, 140)
        Me.txtEMail.MaxLength = 100
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(318, 20)
        Me.txtEMail.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "E-Mail"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(329, 140)
        Me.txtCelular.MaxLength = 100
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(100, 20)
        Me.txtCelular.TabIndex = 20
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(435, 140)
        Me.txtTelefone.MaxLength = 100
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefone.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(329, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Celular"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(435, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Telefone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "E-Mail"
        '
        'txtInformaoesComplementares
        '
        Me.txtInformaoesComplementares.Location = New System.Drawing.Point(5, 180)
        Me.txtInformaoesComplementares.MaxLength = 100
        Me.txtInformaoesComplementares.Multiline = True
        Me.txtInformaoesComplementares.Name = "txtInformaoesComplementares"
        Me.txtInformaoesComplementares.Size = New System.Drawing.Size(530, 60)
        Me.txtInformaoesComplementares.TabIndex = 25
        '
        'cmdSair
        '
        Me.cmdSair.Location = New System.Drawing.Point(460, 255)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.Size = New System.Drawing.Size(75, 23)
        Me.cmdSair.TabIndex = 26
        Me.cmdSair.Text = "Sair"
        Me.cmdSair.UseVisualStyleBackColor = True
        '
        'cmdGravar
        '
        Me.cmdGravar.Location = New System.Drawing.Point(5, 255)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGravar.TabIndex = 27
        Me.cmdGravar.Text = "Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'frmCadCliente_Mini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.txtInformaoesComplementares)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboUF)
        Me.Controls.Add(Me.cboCidade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLogradouro)
        Me.Controls.Add(Me.lblRotulo_CNPJCPF)
        Me.Controls.Add(Me.txtCNPJ_CPF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoPessoa)
        Me.Controls.Add(Me.txtNomeCliente)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCadCliente_Mini"
        Me.Text = "Cadastro de Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomeCliente As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoPessoa As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCNPJ_CPF As System.Windows.Forms.TextBox
    Friend WithEvents lblRotulo_CNPJCPF As System.Windows.Forms.Label
    Friend WithEvents txtLogradouro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCidade As System.Windows.Forms.ComboBox
    Friend WithEvents cboUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCEP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtInformaoesComplementares As System.Windows.Forms.TextBox
    Friend WithEvents cmdSair As System.Windows.Forms.Button
    Friend WithEvents cmdGravar As System.Windows.Forms.Button
End Class
