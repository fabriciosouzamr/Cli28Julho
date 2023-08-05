<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscCadEmpresa
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
    Me.cboTipoContribuicaoICMS = New System.Windows.Forms.ComboBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtTelefone = New System.Windows.Forms.TextBox()
    Me.picLogotipo = New uscPictureBox()
    Me.cmdAbrirDiretorio = New System.Windows.Forms.Button()
    Me.txtDiretorio = New System.Windows.Forms.TextBox()
    Me.txtCNPJ = New Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit()
    Me.txtDataAbertura = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.txtInscricaoMunicipal = New System.Windows.Forms.TextBox()
    Me.txtInscricaoEstadual = New System.Windows.Forms.TextBox()
    Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
    Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.Label01 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.chkDiaUtil_Sex = New System.Windows.Forms.CheckBox()
    Me.chkDiaUtil_Qui = New System.Windows.Forms.CheckBox()
    Me.chkDiaUtil_Sab = New System.Windows.Forms.CheckBox()
    Me.chkDiaUtil_Ter = New System.Windows.Forms.CheckBox()
    Me.chkDiaUtil_Seg = New System.Windows.Forms.CheckBox()
    Me.chkDiaUtil_Qua = New System.Windows.Forms.CheckBox()
    Me.chkDiaUtil_Dom = New System.Windows.Forms.CheckBox()
    CType(Me.txtDataAbertura, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboTipoContribuicaoICMS
    '
    Me.cboTipoContribuicaoICMS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboTipoContribuicaoICMS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboTipoContribuicaoICMS.CausesValidation = False
    Me.cboTipoContribuicaoICMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoContribuicaoICMS.DropDownWidth = 500
    Me.cboTipoContribuicaoICMS.FormattingEnabled = True
    Me.cboTipoContribuicaoICMS.Location = New System.Drawing.Point(318, 97)
    Me.cboTipoContribuicaoICMS.Name = "cboTipoContribuicaoICMS"
    Me.cboTipoContribuicaoICMS.Size = New System.Drawing.Size(358, 21)
    Me.cboTipoContribuicaoICMS.TabIndex = 160
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(318, 82)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(149, 13)
    Me.Label7.TabIndex = 174
    Me.Label7.Text = "Tipo de Contribuição de ICMS"
    '
    'txtTelefone
    '
    Me.txtTelefone.Location = New System.Drawing.Point(212, 97)
    Me.txtTelefone.MaxLength = 40
    Me.txtTelefone.Name = "txtTelefone"
    Me.txtTelefone.Size = New System.Drawing.Size(100, 20)
    Me.txtTelefone.TabIndex = 159
    '
    'picLogotipo
    '
    Me.picLogotipo.Arquivo = ""
    Me.picLogotipo.BotaoExcluir = True
    Me.picLogotipo.HabilitarBotoes = True
    Me.picLogotipo.Image = Nothing
    Me.picLogotipo.Location = New System.Drawing.Point(682, 15)
    Me.picLogotipo.Name = "picLogotipo"
    Me.picLogotipo.SelecionarImagem = True
    Me.picLogotipo.Size = New System.Drawing.Size(191, 219)
    Me.picLogotipo.TabIndex = 173
    Me.picLogotipo.TabStop = False
    '
    'cmdAbrirDiretorio
    '
    Me.cmdAbrirDiretorio.Image = My.Resources.Resources.Mini_Diretorio
    Me.cmdAbrirDiretorio.Location = New System.Drawing.Point(0, 140)
    Me.cmdAbrirDiretorio.Name = "cmdAbrirDiretorio"
    Me.cmdAbrirDiretorio.Size = New System.Drawing.Size(20, 20)
    Me.cmdAbrirDiretorio.TabIndex = 170
    Me.cmdAbrirDiretorio.TabStop = False
    Me.cmdAbrirDiretorio.UseVisualStyleBackColor = True
    '
    'txtDiretorio
    '
    Me.txtDiretorio.Location = New System.Drawing.Point(22, 140)
    Me.txtDiretorio.MaxLength = 100
    Me.txtDiretorio.Name = "txtDiretorio"
    Me.txtDiretorio.ReadOnly = True
    Me.txtDiretorio.Size = New System.Drawing.Size(654, 20)
    Me.txtDiretorio.TabIndex = 172
    '
    'txtCNPJ
    '
    Me.txtCNPJ.EditAs = Infragistics.Win.UltraWinMaskedEdit.EditAsType.UseSpecifiedMask
    Me.txtCNPJ.InputMask = "##.###.###/####-##"
    Me.txtCNPJ.Location = New System.Drawing.Point(566, 15)
    Me.txtCNPJ.Name = "txtCNPJ"
    Me.txtCNPJ.Size = New System.Drawing.Size(110, 20)
    Me.txtCNPJ.TabIndex = 154
    Me.txtCNPJ.Text = "../-"
    '
    'txtDataAbertura
    '
    Me.txtDataAbertura.DateTime = New Date(2016, 9, 23, 0, 0, 0, 0)
    Me.txtDataAbertura.Location = New System.Drawing.Point(566, 56)
    Me.txtDataAbertura.Name = "txtDataAbertura"
    Me.txtDataAbertura.Size = New System.Drawing.Size(85, 21)
    Me.txtDataAbertura.TabIndex = 156
    Me.txtDataAbertura.Value = New Date(2016, 9, 23, 0, 0, 0, 0)
    '
    'txtInscricaoMunicipal
    '
    Me.txtInscricaoMunicipal.Location = New System.Drawing.Point(106, 97)
    Me.txtInscricaoMunicipal.MaxLength = 50
    Me.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal"
    Me.txtInscricaoMunicipal.Size = New System.Drawing.Size(100, 20)
    Me.txtInscricaoMunicipal.TabIndex = 158
    '
    'txtInscricaoEstadual
    '
    Me.txtInscricaoEstadual.Location = New System.Drawing.Point(0, 97)
    Me.txtInscricaoEstadual.MaxLength = 50
    Me.txtInscricaoEstadual.Name = "txtInscricaoEstadual"
    Me.txtInscricaoEstadual.Size = New System.Drawing.Size(100, 20)
    Me.txtInscricaoEstadual.TabIndex = 157
    '
    'txtNomeFantasia
    '
    Me.txtNomeFantasia.Location = New System.Drawing.Point(0, 56)
    Me.txtNomeFantasia.MaxLength = 100
    Me.txtNomeFantasia.Name = "txtNomeFantasia"
    Me.txtNomeFantasia.Size = New System.Drawing.Size(560, 20)
    Me.txtNomeFantasia.TabIndex = 155
    '
    'txtRazaoSocial
    '
    Me.txtRazaoSocial.Location = New System.Drawing.Point(0, 15)
    Me.txtRazaoSocial.MaxLength = 200
    Me.txtRazaoSocial.Name = "txtRazaoSocial"
    Me.txtRazaoSocial.Size = New System.Drawing.Size(560, 20)
    Me.txtRazaoSocial.TabIndex = 153
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(-3, 110)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(679, 13)
    Me.Label3.TabIndex = 167
    Me.Label3.Text = "_________________________________________________________________________________" &
    "_______________________________"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(682, 0)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(107, 13)
    Me.Label6.TabIndex = 171
    Me.Label6.Text = "Logotipo da Empresa"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(0, 125)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(157, 13)
    Me.Label5.TabIndex = 169
    Me.Label5.Text = "Diretório de Imagens e Arquivos"
    '
    'Label26
    '
    Me.Label26.AutoSize = True
    Me.Label26.Location = New System.Drawing.Point(212, 82)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(49, 13)
    Me.Label26.TabIndex = 168
    Me.Label26.Text = "Telefone"
    '
    'Label01
    '
    Me.Label01.AutoSize = True
    Me.Label01.Location = New System.Drawing.Point(566, 0)
    Me.Label01.Name = "Label01"
    Me.Label01.Size = New System.Drawing.Size(34, 13)
    Me.Label01.TabIndex = 166
    Me.Label01.Text = "CNPJ"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(566, 41)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(73, 13)
    Me.Label2.TabIndex = 165
    Me.Label2.Text = "Data Abertura"
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(106, 82)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(98, 13)
    Me.Label12.TabIndex = 164
    Me.Label12.Text = "Inscrição Municipal"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(0, 82)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(94, 13)
    Me.Label11.TabIndex = 163
    Me.Label11.Text = "Inscrição Estadual"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(0, 41)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(93, 13)
    Me.Label10.TabIndex = 162
    Me.Label10.Text = "Nome de Fantasia"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(70, 13)
    Me.Label1.TabIndex = 161
    Me.Label1.Text = "Razão Social"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.chkDiaUtil_Sex)
    Me.GroupBox1.Controls.Add(Me.chkDiaUtil_Qui)
    Me.GroupBox1.Controls.Add(Me.chkDiaUtil_Sab)
    Me.GroupBox1.Controls.Add(Me.chkDiaUtil_Ter)
    Me.GroupBox1.Controls.Add(Me.chkDiaUtil_Seg)
    Me.GroupBox1.Controls.Add(Me.chkDiaUtil_Qua)
    Me.GroupBox1.Controls.Add(Me.chkDiaUtil_Dom)
    Me.GroupBox1.Location = New System.Drawing.Point(0, 168)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(374, 38)
    Me.GroupBox1.TabIndex = 175
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Dias de Funcionamento"
    '
    'chkDiaUtil_Sex
    '
    Me.chkDiaUtil_Sex.AutoSize = True
    Me.chkDiaUtil_Sex.Location = New System.Drawing.Point(273, 16)
    Me.chkDiaUtil_Sex.Name = "chkDiaUtil_Sex"
    Me.chkDiaUtil_Sex.Size = New System.Drawing.Size(44, 17)
    Me.chkDiaUtil_Sex.TabIndex = 6
    Me.chkDiaUtil_Sex.Text = "Sex"
    Me.chkDiaUtil_Sex.UseVisualStyleBackColor = True
    '
    'chkDiaUtil_Qui
    '
    Me.chkDiaUtil_Qui.AutoSize = True
    Me.chkDiaUtil_Qui.Location = New System.Drawing.Point(223, 16)
    Me.chkDiaUtil_Qui.Name = "chkDiaUtil_Qui"
    Me.chkDiaUtil_Qui.Size = New System.Drawing.Size(42, 17)
    Me.chkDiaUtil_Qui.TabIndex = 5
    Me.chkDiaUtil_Qui.Text = "Qui"
    Me.chkDiaUtil_Qui.UseVisualStyleBackColor = True
    '
    'chkDiaUtil_Sab
    '
    Me.chkDiaUtil_Sab.AutoSize = True
    Me.chkDiaUtil_Sab.Location = New System.Drawing.Point(325, 16)
    Me.chkDiaUtil_Sab.Name = "chkDiaUtil_Sab"
    Me.chkDiaUtil_Sab.Size = New System.Drawing.Size(45, 17)
    Me.chkDiaUtil_Sab.TabIndex = 4
    Me.chkDiaUtil_Sab.Text = "Sáb"
    Me.chkDiaUtil_Sab.UseVisualStyleBackColor = True
    '
    'chkDiaUtil_Ter
    '
    Me.chkDiaUtil_Ter.AutoSize = True
    Me.chkDiaUtil_Ter.Location = New System.Drawing.Point(119, 16)
    Me.chkDiaUtil_Ter.Name = "chkDiaUtil_Ter"
    Me.chkDiaUtil_Ter.Size = New System.Drawing.Size(42, 17)
    Me.chkDiaUtil_Ter.TabIndex = 3
    Me.chkDiaUtil_Ter.Text = "Ter"
    Me.chkDiaUtil_Ter.UseVisualStyleBackColor = True
    '
    'chkDiaUtil_Seg
    '
    Me.chkDiaUtil_Seg.AutoSize = True
    Me.chkDiaUtil_Seg.Location = New System.Drawing.Point(66, 16)
    Me.chkDiaUtil_Seg.Name = "chkDiaUtil_Seg"
    Me.chkDiaUtil_Seg.Size = New System.Drawing.Size(45, 17)
    Me.chkDiaUtil_Seg.TabIndex = 2
    Me.chkDiaUtil_Seg.Text = "Seg"
    Me.chkDiaUtil_Seg.UseVisualStyleBackColor = True
    '
    'chkDiaUtil_Qua
    '
    Me.chkDiaUtil_Qua.AutoSize = True
    Me.chkDiaUtil_Qua.Location = New System.Drawing.Point(169, 16)
    Me.chkDiaUtil_Qua.Name = "chkDiaUtil_Qua"
    Me.chkDiaUtil_Qua.Size = New System.Drawing.Size(46, 17)
    Me.chkDiaUtil_Qua.TabIndex = 1
    Me.chkDiaUtil_Qua.Text = "Qua"
    Me.chkDiaUtil_Qua.UseVisualStyleBackColor = True
    '
    'chkDiaUtil_Dom
    '
    Me.chkDiaUtil_Dom.AutoSize = True
    Me.chkDiaUtil_Dom.Location = New System.Drawing.Point(10, 16)
    Me.chkDiaUtil_Dom.Name = "chkDiaUtil_Dom"
    Me.chkDiaUtil_Dom.Size = New System.Drawing.Size(48, 17)
    Me.chkDiaUtil_Dom.TabIndex = 0
    Me.chkDiaUtil_Dom.Text = "Dom"
    Me.chkDiaUtil_Dom.UseVisualStyleBackColor = True
    '
    'uscCadEmpresa
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.cboTipoContribuicaoICMS)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.txtTelefone)
    Me.Controls.Add(Me.picLogotipo)
    Me.Controls.Add(Me.cmdAbrirDiretorio)
    Me.Controls.Add(Me.txtDiretorio)
    Me.Controls.Add(Me.txtCNPJ)
    Me.Controls.Add(Me.txtDataAbertura)
    Me.Controls.Add(Me.txtInscricaoMunicipal)
    Me.Controls.Add(Me.txtInscricaoEstadual)
    Me.Controls.Add(Me.txtNomeFantasia)
    Me.Controls.Add(Me.txtRazaoSocial)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label26)
    Me.Controls.Add(Me.Label01)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.Label10)
    Me.Controls.Add(Me.Label1)
    Me.Name = "uscCadEmpresa"
    Me.Size = New System.Drawing.Size(873, 233)
    CType(Me.txtDataAbertura, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cboTipoContribuicaoICMS As ComboBox
  Friend WithEvents Label7 As Label
  Friend WithEvents txtTelefone As TextBox
  Friend WithEvents picLogotipo As uscPictureBox
  Friend WithEvents cmdAbrirDiretorio As Button
  Friend WithEvents txtDiretorio As TextBox
  Friend WithEvents txtCNPJ As Infragistics.Win.UltraWinMaskedEdit.UltraMaskedEdit
  Friend WithEvents txtDataAbertura As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents txtInscricaoMunicipal As TextBox
  Public WithEvents txtInscricaoEstadual As TextBox
  Friend WithEvents txtNomeFantasia As TextBox
  Friend WithEvents txtRazaoSocial As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label26 As Label
  Friend WithEvents Label01 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label12 As Label
  Friend WithEvents Label11 As Label
  Friend WithEvents Label10 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents chkDiaUtil_Sex As CheckBox
  Friend WithEvents chkDiaUtil_Qui As CheckBox
  Friend WithEvents chkDiaUtil_Sab As CheckBox
  Friend WithEvents chkDiaUtil_Ter As CheckBox
  Friend WithEvents chkDiaUtil_Seg As CheckBox
  Friend WithEvents chkDiaUtil_Qua As CheckBox
  Friend WithEvents chkDiaUtil_Dom As CheckBox
End Class
