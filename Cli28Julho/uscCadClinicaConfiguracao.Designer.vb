<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscCadClinicaConfiguracao
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
    Me.chkNecessarioAnamneseEvolucoes = New System.Windows.Forms.CheckBox()
    Me.cboTipoConsulta_Retorno = New System.Windows.Forms.ComboBox()
    Me.chkCarregarTodosProcedimentosPadrao = New System.Windows.Forms.CheckBox()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.txtAtendimento_HoraRetornoRefeicao = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.txtAtendimento_HoraSaidaRefeicao = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtAtendimento_HoraInicio = New System.Windows.Forms.TextBox()
    Me.txtAtendimento_HoraFim = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboModeloEvoluca_Padrao = New System.Windows.Forms.ComboBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.cboModeloAnamnese_Padrao = New System.Windows.Forms.ComboBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtAtendimento_Intervalo = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.cboModeloReceita_Padrao = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.grpAtendimento = New System.Windows.Forms.GroupBox()
    Me.cboTabelaProcedimento_Padrao = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtIdadeIdoso = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.cboTipoConsulta_Venda = New System.Windows.Forms.ComboBox()
    Me.Label13 = New System.Windows.Forms.Label()
    CType(Me.txtAtendimento_Intervalo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpAtendimento.SuspendLayout()
    CType(Me.txtIdadeIdoso, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'chkNecessarioAnamneseEvolucoes
    '
    Me.chkNecessarioAnamneseEvolucoes.AutoSize = True
    Me.chkNecessarioAnamneseEvolucoes.Location = New System.Drawing.Point(410, 145)
    Me.chkNecessarioAnamneseEvolucoes.Name = "chkNecessarioAnamneseEvolucoes"
    Me.chkNecessarioAnamneseEvolucoes.Size = New System.Drawing.Size(264, 17)
    Me.chkNecessarioAnamneseEvolucoes.TabIndex = 130
    Me.chkNecessarioAnamneseEvolucoes.Text = "É necessário ter Anamnese para fazer Evoluções?"
    Me.chkNecessarioAnamneseEvolucoes.UseVisualStyleBackColor = True
    '
    'cboTipoConsulta_Retorno
    '
    Me.cboTipoConsulta_Retorno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoConsulta_Retorno.FormattingEnabled = True
    Me.cboTipoConsulta_Retorno.Location = New System.Drawing.Point(0, 15)
    Me.cboTipoConsulta_Retorno.Name = "cboTipoConsulta_Retorno"
    Me.cboTipoConsulta_Retorno.Size = New System.Drawing.Size(404, 21)
    Me.cboTipoConsulta_Retorno.TabIndex = 124
    '
    'chkCarregarTodosProcedimentosPadrao
    '
    Me.chkCarregarTodosProcedimentosPadrao.AutoSize = True
    Me.chkCarregarTodosProcedimentosPadrao.Location = New System.Drawing.Point(410, 126)
    Me.chkCarregarTodosProcedimentosPadrao.Name = "chkCarregarTodosProcedimentosPadrao"
    Me.chkCarregarTodosProcedimentosPadrao.Size = New System.Drawing.Size(209, 17)
    Me.chkCarregarTodosProcedimentosPadrao.TabIndex = 129
    Me.chkCarregarTodosProcedimentosPadrao.Text = "Carregar Todos Procedimentos Padrão"
    Me.chkCarregarTodosProcedimentosPadrao.UseVisualStyleBackColor = True
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(248, 16)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(91, 13)
    Me.Label10.TabIndex = 9
    Me.Label10.Text = "Retorno Refeição"
    '
    'txtAtendimento_HoraRetornoRefeicao
    '
    Me.txtAtendimento_HoraRetornoRefeicao.Location = New System.Drawing.Point(304, 30)
    Me.txtAtendimento_HoraRetornoRefeicao.Name = "txtAtendimento_HoraRetornoRefeicao"
    Me.txtAtendimento_HoraRetornoRefeicao.Size = New System.Drawing.Size(35, 20)
    Me.txtAtendimento_HoraRetornoRefeicao.TabIndex = 11
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(160, 16)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(82, 13)
    Me.Label9.TabIndex = 7
    Me.Label9.Text = "Saída Refeição"
    '
    'txtAtendimento_HoraSaidaRefeicao
    '
    Me.txtAtendimento_HoraSaidaRefeicao.Location = New System.Drawing.Point(207, 30)
    Me.txtAtendimento_HoraSaidaRefeicao.Name = "txtAtendimento_HoraSaidaRefeicao"
    Me.txtAtendimento_HoraSaidaRefeicao.Size = New System.Drawing.Size(35, 20)
    Me.txtAtendimento_HoraSaidaRefeicao.TabIndex = 10
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(345, 16)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(55, 13)
    Me.Label4.TabIndex = 5
    Me.Label4.Text = "Hora Final"
    '
    'txtAtendimento_HoraInicio
    '
    Me.txtAtendimento_HoraInicio.Location = New System.Drawing.Point(119, 31)
    Me.txtAtendimento_HoraInicio.Name = "txtAtendimento_HoraInicio"
    Me.txtAtendimento_HoraInicio.Size = New System.Drawing.Size(35, 20)
    Me.txtAtendimento_HoraInicio.TabIndex = 9
    '
    'txtAtendimento_HoraFim
    '
    Me.txtAtendimento_HoraFim.Location = New System.Drawing.Point(365, 31)
    Me.txtAtendimento_HoraFim.Name = "txtAtendimento_HoraFim"
    Me.txtAtendimento_HoraFim.Size = New System.Drawing.Size(35, 20)
    Me.txtAtendimento_HoraFim.TabIndex = 12
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(94, 16)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(60, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Hora Inicial"
    '
    'cboModeloEvoluca_Padrao
    '
    Me.cboModeloEvoluca_Padrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboModeloEvoluca_Padrao.FormattingEnabled = True
    Me.cboModeloEvoluca_Padrao.Location = New System.Drawing.Point(410, 99)
    Me.cboModeloEvoluca_Padrao.Name = "cboModeloEvoluca_Padrao"
    Me.cboModeloEvoluca_Padrao.Size = New System.Drawing.Size(404, 21)
    Me.cboModeloEvoluca_Padrao.TabIndex = 127
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(410, 84)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(142, 13)
    Me.Label7.TabIndex = 134
    Me.Label7.Text = "Modelo de Evolução Padrão"
    '
    'cboModeloAnamnese_Padrao
    '
    Me.cboModeloAnamnese_Padrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboModeloAnamnese_Padrao.FormattingEnabled = True
    Me.cboModeloAnamnese_Padrao.Location = New System.Drawing.Point(0, 57)
    Me.cboModeloAnamnese_Padrao.Name = "cboModeloAnamnese_Padrao"
    Me.cboModeloAnamnese_Padrao.Size = New System.Drawing.Size(404, 21)
    Me.cboModeloAnamnese_Padrao.TabIndex = 126
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(0, 42)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(147, 13)
    Me.Label6.TabIndex = 133
    Me.Label6.Text = "Modelo de Anamnese Padrão"
    '
    'txtAtendimento_Intervalo
    '
    Me.txtAtendimento_Intervalo.Location = New System.Drawing.Point(38, 31)
    Me.txtAtendimento_Intervalo.MaskInput = "nnn"
    Me.txtAtendimento_Intervalo.MinValue = 1
    Me.txtAtendimento_Intervalo.Name = "txtAtendimento_Intervalo"
    Me.txtAtendimento_Intervalo.Size = New System.Drawing.Size(50, 21)
    Me.txtAtendimento_Intervalo.TabIndex = 8
    '
    'cboModeloReceita_Padrao
    '
    Me.cboModeloReceita_Padrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboModeloReceita_Padrao.FormattingEnabled = True
    Me.cboModeloReceita_Padrao.Location = New System.Drawing.Point(410, 57)
    Me.cboModeloReceita_Padrao.Name = "cboModeloReceita_Padrao"
    Me.cboModeloReceita_Padrao.Size = New System.Drawing.Size(404, 21)
    Me.cboModeloReceita_Padrao.TabIndex = 125
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(6, 16)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(82, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Intervalo (Min.s)"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(0, 0)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(152, 13)
    Me.Label8.TabIndex = 135
    Me.Label8.Text = "Tipo de Consulta para Retorno"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(410, 42)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(134, 13)
    Me.Label5.TabIndex = 132
    Me.Label5.Text = "Modelo de Receita Padrão"
    '
    'grpAtendimento
    '
    Me.grpAtendimento.Controls.Add(Me.Label10)
    Me.grpAtendimento.Controls.Add(Me.txtAtendimento_HoraRetornoRefeicao)
    Me.grpAtendimento.Controls.Add(Me.Label9)
    Me.grpAtendimento.Controls.Add(Me.txtAtendimento_HoraSaidaRefeicao)
    Me.grpAtendimento.Controls.Add(Me.Label4)
    Me.grpAtendimento.Controls.Add(Me.txtAtendimento_HoraInicio)
    Me.grpAtendimento.Controls.Add(Me.txtAtendimento_HoraFim)
    Me.grpAtendimento.Controls.Add(Me.Label3)
    Me.grpAtendimento.Controls.Add(Me.txtAtendimento_Intervalo)
    Me.grpAtendimento.Controls.Add(Me.Label2)
    Me.grpAtendimento.Location = New System.Drawing.Point(0, 126)
    Me.grpAtendimento.Name = "grpAtendimento"
    Me.grpAtendimento.Size = New System.Drawing.Size(407, 58)
    Me.grpAtendimento.TabIndex = 131
    Me.grpAtendimento.TabStop = False
    Me.grpAtendimento.Text = "Atendimento"
    '
    'cboTabelaProcedimento_Padrao
    '
    Me.cboTabelaProcedimento_Padrao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTabelaProcedimento_Padrao.FormattingEnabled = True
    Me.cboTabelaProcedimento_Padrao.Location = New System.Drawing.Point(0, 99)
    Me.cboTabelaProcedimento_Padrao.Name = "cboTabelaProcedimento_Padrao"
    Me.cboTabelaProcedimento_Padrao.Size = New System.Drawing.Size(404, 21)
    Me.cboTabelaProcedimento_Padrao.TabIndex = 128
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(0, 84)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(160, 13)
    Me.Label1.TabIndex = 123
    Me.Label1.Text = "Tabela de Procedimento Padrão"
    '
    'txtIdadeIdoso
    '
    Me.txtIdadeIdoso.Location = New System.Drawing.Point(680, 141)
    Me.txtIdadeIdoso.MaskInput = "nnn"
    Me.txtIdadeIdoso.MinValue = 1
    Me.txtIdadeIdoso.Name = "txtIdadeIdoso"
    Me.txtIdadeIdoso.Size = New System.Drawing.Size(50, 21)
    Me.txtIdadeIdoso.TabIndex = 137
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(680, 84)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(0, 13)
    Me.Label11.TabIndex = 136
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(677, 126)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(121, 13)
    Me.Label12.TabIndex = 138
    Me.Label12.Text = "Idade mín. pra ser idoso"
    '
    'cboTipoConsulta_Venda
    '
    Me.cboTipoConsulta_Venda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoConsulta_Venda.FormattingEnabled = True
    Me.cboTipoConsulta_Venda.Location = New System.Drawing.Point(410, 15)
    Me.cboTipoConsulta_Venda.Name = "cboTipoConsulta_Venda"
    Me.cboTipoConsulta_Venda.Size = New System.Drawing.Size(404, 21)
    Me.cboTipoConsulta_Venda.TabIndex = 139
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(410, 0)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(260, 13)
    Me.Label13.TabIndex = 140
    Me.Label13.Text = "Tipo de Consulta para Geração Automática na Venda"
    '
    'uscCadClinicaConfiguracao
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.Label13)
    Me.Controls.Add(Me.cboTipoConsulta_Venda)
    Me.Controls.Add(Me.Label12)
    Me.Controls.Add(Me.txtIdadeIdoso)
    Me.Controls.Add(Me.Label11)
    Me.Controls.Add(Me.chkNecessarioAnamneseEvolucoes)
    Me.Controls.Add(Me.cboTipoConsulta_Retorno)
    Me.Controls.Add(Me.chkCarregarTodosProcedimentosPadrao)
    Me.Controls.Add(Me.cboModeloEvoluca_Padrao)
    Me.Controls.Add(Me.Label7)
    Me.Controls.Add(Me.cboModeloAnamnese_Padrao)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.cboModeloReceita_Padrao)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.grpAtendimento)
    Me.Controls.Add(Me.cboTabelaProcedimento_Padrao)
    Me.Controls.Add(Me.Label1)
    Me.Name = "uscCadClinicaConfiguracao"
    Me.Size = New System.Drawing.Size(814, 183)
    CType(Me.txtAtendimento_Intervalo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpAtendimento.ResumeLayout(False)
    Me.grpAtendimento.PerformLayout()
    CType(Me.txtIdadeIdoso, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents chkNecessarioAnamneseEvolucoes As CheckBox
  Friend WithEvents cboTipoConsulta_Retorno As ComboBox
  Friend WithEvents chkCarregarTodosProcedimentosPadrao As CheckBox
  Friend WithEvents Label10 As Label
  Friend WithEvents txtAtendimento_HoraRetornoRefeicao As TextBox
  Friend WithEvents Label9 As Label
  Friend WithEvents txtAtendimento_HoraSaidaRefeicao As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents txtAtendimento_HoraInicio As TextBox
  Friend WithEvents txtAtendimento_HoraFim As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents cboModeloEvoluca_Padrao As ComboBox
  Friend WithEvents Label7 As Label
  Friend WithEvents cboModeloAnamnese_Padrao As ComboBox
  Friend WithEvents Label6 As Label
  Friend WithEvents txtAtendimento_Intervalo As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents cboModeloReceita_Padrao As ComboBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label8 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents grpAtendimento As GroupBox
  Friend WithEvents cboTabelaProcedimento_Padrao As ComboBox
  Friend WithEvents Label1 As Label
  Friend WithEvents txtIdadeIdoso As Infragistics.Win.UltraWinEditors.UltraNumericEditor
  Friend WithEvents Label11 As Label
  Friend WithEvents Label12 As Label
  Friend WithEvents cboTipoConsulta_Venda As ComboBox
  Friend WithEvents Label13 As Label
End Class
