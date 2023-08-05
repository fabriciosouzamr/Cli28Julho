<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroPaciente
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.tabGeral = New System.Windows.Forms.TabControl()
    Me.tabDadosPaciente = New System.Windows.Forms.TabPage()
    Me.oPaciente = New uscPaciente()
    Me.tabGuiaAnamnese = New System.Windows.Forms.TabPage()
    Me.pnlAnamneseContainer = New System.Windows.Forms.Panel()
    Me.pnlAnamneseControle = New System.Windows.Forms.Panel()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboAnamneseGeradas = New System.Windows.Forms.ComboBox()
    Me.tabEvolucao = New System.Windows.Forms.TabPage()
    Me.pnlEvolucaoEditor = New System.Windows.Forms.Panel()
    Me.oEditorEvolucao = New uscEditorTexto()
    Me.pnlEvolucaoControle = New System.Windows.Forms.Panel()
    Me.cboEvolucao = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.tabImpressoes = New System.Windows.Forms.TabPage()
    Me.oImpressoes = New uscImpressoes()
    Me.tabAnexo = New System.Windows.Forms.TabPage()
    Me.oAnexo = New uscAnexo()
    Me.tabGeral.SuspendLayout()
    Me.tabDadosPaciente.SuspendLayout()
    Me.tabGuiaAnamnese.SuspendLayout()
    Me.pnlAnamneseControle.SuspendLayout()
    Me.tabEvolucao.SuspendLayout()
    Me.pnlEvolucaoEditor.SuspendLayout()
    Me.pnlEvolucaoControle.SuspendLayout()
    Me.tabImpressoes.SuspendLayout()
    Me.tabAnexo.SuspendLayout()
    Me.SuspendLayout()
    '
    'tabGeral
    '
    Me.tabGeral.Controls.Add(Me.tabDadosPaciente)
    Me.tabGeral.Controls.Add(Me.tabGuiaAnamnese)
    Me.tabGeral.Controls.Add(Me.tabEvolucao)
    Me.tabGeral.Controls.Add(Me.tabImpressoes)
    Me.tabGeral.Controls.Add(Me.tabAnexo)
    Me.tabGeral.Location = New System.Drawing.Point(1, 1)
    Me.tabGeral.Name = "tabGeral"
    Me.tabGeral.SelectedIndex = 0
    Me.tabGeral.Size = New System.Drawing.Size(1197, 465)
    Me.tabGeral.TabIndex = 0
    '
    'tabDadosPaciente
    '
    Me.tabDadosPaciente.Controls.Add(Me.oPaciente)
    Me.tabDadosPaciente.Location = New System.Drawing.Point(4, 22)
    Me.tabDadosPaciente.Name = "tabDadosPaciente"
    Me.tabDadosPaciente.Padding = New System.Windows.Forms.Padding(3)
    Me.tabDadosPaciente.Size = New System.Drawing.Size(1189, 439)
    Me.tabDadosPaciente.TabIndex = 0
    Me.tabDadosPaciente.Text = "Dados do Paciente"
    Me.tabDadosPaciente.UseVisualStyleBackColor = True
    '
    'oPaciente
    '
    Me.oPaciente.Ativo = 1
    Me.oPaciente.BotaoFechar = False
    Me.oPaciente.BotaoGerarConsultas = False
    Me.oPaciente.BotaoNovo = True
    Me.oPaciente.ComboPaciente = False
    Me.oPaciente.ExibirHistorico = False
    Me.oPaciente.Identificador = 0
    Me.oPaciente.Location = New System.Drawing.Point(5, 5)
    Me.oPaciente.Name = "oPaciente"
    Me.oPaciente.NomePaciente = ""
    Me.oPaciente.Size = New System.Drawing.Size(1179, 428)
    Me.oPaciente.TabIndex = 1
    '
    'tabGuiaAnamnese
    '
    Me.tabGuiaAnamnese.Controls.Add(Me.pnlAnamneseContainer)
    Me.tabGuiaAnamnese.Controls.Add(Me.pnlAnamneseControle)
    Me.tabGuiaAnamnese.Location = New System.Drawing.Point(4, 22)
    Me.tabGuiaAnamnese.Name = "tabGuiaAnamnese"
    Me.tabGuiaAnamnese.Padding = New System.Windows.Forms.Padding(3)
    Me.tabGuiaAnamnese.Size = New System.Drawing.Size(1189, 439)
    Me.tabGuiaAnamnese.TabIndex = 3
    Me.tabGuiaAnamnese.Text = "Guia de Anamnese"
    Me.tabGuiaAnamnese.UseVisualStyleBackColor = True
    '
    'pnlAnamneseContainer
    '
    Me.pnlAnamneseContainer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlAnamneseContainer.Location = New System.Drawing.Point(3, 49)
    Me.pnlAnamneseContainer.Name = "pnlAnamneseContainer"
    Me.pnlAnamneseContainer.Size = New System.Drawing.Size(1183, 387)
    Me.pnlAnamneseContainer.TabIndex = 11
    '
    'pnlAnamneseControle
    '
    Me.pnlAnamneseControle.Controls.Add(Me.Label4)
    Me.pnlAnamneseControle.Controls.Add(Me.cboAnamneseGeradas)
    Me.pnlAnamneseControle.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlAnamneseControle.Location = New System.Drawing.Point(3, 3)
    Me.pnlAnamneseControle.Name = "pnlAnamneseControle"
    Me.pnlAnamneseControle.Size = New System.Drawing.Size(1183, 46)
    Me.pnlAnamneseControle.TabIndex = 1
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(5, 5)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(105, 13)
    Me.Label4.TabIndex = 116
    Me.Label4.Text = "Anamneses Geradas"
    '
    'cboAnamneseGeradas
    '
    Me.cboAnamneseGeradas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnamneseGeradas.FormattingEnabled = True
    Me.cboAnamneseGeradas.Location = New System.Drawing.Point(5, 20)
    Me.cboAnamneseGeradas.Name = "cboAnamneseGeradas"
    Me.cboAnamneseGeradas.Size = New System.Drawing.Size(450, 21)
    Me.cboAnamneseGeradas.TabIndex = 10
    '
    'tabEvolucao
    '
    Me.tabEvolucao.Controls.Add(Me.pnlEvolucaoEditor)
    Me.tabEvolucao.Controls.Add(Me.pnlEvolucaoControle)
    Me.tabEvolucao.Location = New System.Drawing.Point(4, 22)
    Me.tabEvolucao.Name = "tabEvolucao"
    Me.tabEvolucao.Padding = New System.Windows.Forms.Padding(3)
    Me.tabEvolucao.Size = New System.Drawing.Size(1189, 439)
    Me.tabEvolucao.TabIndex = 4
    Me.tabEvolucao.Text = "Evoluções"
    Me.tabEvolucao.UseVisualStyleBackColor = True
    '
    'pnlEvolucaoEditor
    '
    Me.pnlEvolucaoEditor.BackColor = System.Drawing.Color.Gray
    Me.pnlEvolucaoEditor.Controls.Add(Me.oEditorEvolucao)
    Me.pnlEvolucaoEditor.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlEvolucaoEditor.Location = New System.Drawing.Point(3, 41)
    Me.pnlEvolucaoEditor.Name = "pnlEvolucaoEditor"
    Me.pnlEvolucaoEditor.Size = New System.Drawing.Size(1183, 395)
    Me.pnlEvolucaoEditor.TabIndex = 1
    '
    'oEditorEvolucao
    '
    Me.oEditorEvolucao.DICIONARIODADO_PROCESSO = 0
    Me.oEditorEvolucao.Dock = System.Windows.Forms.DockStyle.Fill
    Me.oEditorEvolucao.ExibirNumeroPagina = False
    Me.oEditorEvolucao.IDENTIFICADOR = 0
    Me.oEditorEvolucao.Location = New System.Drawing.Point(0, 0)
    Me.oEditorEvolucao.MODELO_ASSINATURA = 0
    Me.oEditorEvolucao.MODELO_CABECALHO = 0
    Me.oEditorEvolucao.MODELO_RODAPE = 0
    Me.oEditorEvolucao.MODELODOCUMENTO = 0
    Me.oEditorEvolucao.Name = "oEditorEvolucao"
    Me.oEditorEvolucao.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft S" &
    "ans Serif;}}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs17\par" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
    Me.oEditorEvolucao.Size = New System.Drawing.Size(1183, 395)
    Me.oEditorEvolucao.SoLeitura = False
    Me.oEditorEvolucao.TabIndex = 21
    Me.oEditorEvolucao.Texto = ""
    Me.oEditorEvolucao.TIPO_MODELODOCUMENTO = 0
    '
    'pnlEvolucaoControle
    '
    Me.pnlEvolucaoControle.Controls.Add(Me.cboEvolucao)
    Me.pnlEvolucaoControle.Controls.Add(Me.Label2)
    Me.pnlEvolucaoControle.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlEvolucaoControle.Location = New System.Drawing.Point(3, 3)
    Me.pnlEvolucaoControle.Name = "pnlEvolucaoControle"
    Me.pnlEvolucaoControle.Size = New System.Drawing.Size(1183, 38)
    Me.pnlEvolucaoControle.TabIndex = 0
    '
    'cboEvolucao
    '
    Me.cboEvolucao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEvolucao.FormattingEnabled = True
    Me.cboEvolucao.Location = New System.Drawing.Point(85, 9)
    Me.cboEvolucao.Name = "cboEvolucao"
    Me.cboEvolucao.Size = New System.Drawing.Size(650, 21)
    Me.cboEvolucao.TabIndex = 20
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 13)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(78, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Evoluções >>>"
    '
    'tabImpressoes
    '
    Me.tabImpressoes.Controls.Add(Me.oImpressoes)
    Me.tabImpressoes.Location = New System.Drawing.Point(4, 22)
    Me.tabImpressoes.Name = "tabImpressoes"
    Me.tabImpressoes.Padding = New System.Windows.Forms.Padding(3)
    Me.tabImpressoes.Size = New System.Drawing.Size(1189, 439)
    Me.tabImpressoes.TabIndex = 1
    Me.tabImpressoes.Text = "Impressões"
    Me.tabImpressoes.UseVisualStyleBackColor = True
    '
    'oImpressoes
    '
    Me.oImpressoes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.oImpressoes.Location = New System.Drawing.Point(3, 3)
    Me.oImpressoes.Name = "oImpressoes"
    Me.oImpressoes.Size = New System.Drawing.Size(1183, 433)
    Me.oImpressoes.TabIndex = 30
    '
    'tabAnexo
    '
    Me.tabAnexo.Controls.Add(Me.oAnexo)
    Me.tabAnexo.Location = New System.Drawing.Point(4, 22)
    Me.tabAnexo.Name = "tabAnexo"
    Me.tabAnexo.Padding = New System.Windows.Forms.Padding(3)
    Me.tabAnexo.Size = New System.Drawing.Size(1189, 439)
    Me.tabAnexo.TabIndex = 2
    Me.tabAnexo.Text = "Anexo"
    Me.tabAnexo.UseVisualStyleBackColor = True
    '
    'oAnexo
    '
    Me.oAnexo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.oAnexo.Location = New System.Drawing.Point(3, 3)
    Me.oAnexo.Name = "oAnexo"
    Me.oAnexo.Size = New System.Drawing.Size(1183, 433)
    Me.oAnexo.TabIndex = 40
    '
    'frmCadastroPaciente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1199, 466)
    Me.Controls.Add(Me.tabGeral)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCadastroPaciente"
    Me.Text = "Cadastro de Paciente"
    Me.tabGeral.ResumeLayout(False)
    Me.tabDadosPaciente.ResumeLayout(False)
    Me.tabGuiaAnamnese.ResumeLayout(False)
    Me.pnlAnamneseControle.ResumeLayout(False)
    Me.pnlAnamneseControle.PerformLayout()
    Me.tabEvolucao.ResumeLayout(False)
    Me.pnlEvolucaoEditor.ResumeLayout(False)
    Me.pnlEvolucaoControle.ResumeLayout(False)
    Me.pnlEvolucaoControle.PerformLayout()
    Me.tabImpressoes.ResumeLayout(False)
    Me.tabAnexo.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tabGeral As System.Windows.Forms.TabControl
  Friend WithEvents tabDadosPaciente As System.Windows.Forms.TabPage
  Friend WithEvents oPaciente As uscPaciente
  Friend WithEvents tabImpressoes As System.Windows.Forms.TabPage
  Friend WithEvents oImpressoes As uscImpressoes
  Friend WithEvents tabAnexo As System.Windows.Forms.TabPage
  Friend WithEvents oAnexo As uscAnexo
  Friend WithEvents tabGuiaAnamnese As System.Windows.Forms.TabPage
  Friend WithEvents pnlAnamneseContainer As System.Windows.Forms.Panel
  Friend WithEvents pnlAnamneseControle As System.Windows.Forms.Panel
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cboAnamneseGeradas As System.Windows.Forms.ComboBox
  Friend WithEvents tabEvolucao As System.Windows.Forms.TabPage
  Friend WithEvents pnlEvolucaoEditor As System.Windows.Forms.Panel
  Friend WithEvents oEditorEvolucao As uscEditorTexto
  Friend WithEvents pnlEvolucaoControle As System.Windows.Forms.Panel
  Friend WithEvents cboEvolucao As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
