<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAgendamento_ProfissionalData
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
    Me.txtPessoa = New System.Windows.Forms.TextBox()
    Me.lblRCodigo = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.cboTipoConsulta = New System.Windows.Forms.ComboBox()
    Me.lblRTipoConsulta = New System.Windows.Forms.Label()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.lblRProfissional = New System.Windows.Forms.Label()
    Me.txtDataAgendamento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblRDataAgendamento = New System.Windows.Forms.Label()
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
        Me.cmdDisponibilidade = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEspecialdade = New System.Windows.Forms.ComboBox()
        Me.cboGrupoProcedimento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
        CType(Me.txtDataAgendamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Pessoa"
        '
        'txtPessoa
        '
        Me.txtPessoa.Location = New System.Drawing.Point(71, 20)
        Me.txtPessoa.Name = "txtPessoa"
        Me.txtPessoa.ReadOnly = True
        Me.txtPessoa.Size = New System.Drawing.Size(434, 20)
        Me.txtPessoa.TabIndex = 118
        '
        'lblRCodigo
        '
        Me.lblRCodigo.AutoSize = True
        Me.lblRCodigo.Location = New System.Drawing.Point(5, 5)
        Me.lblRCodigo.Name = "lblRCodigo"
        Me.lblRCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblRCodigo.TabIndex = 127
        Me.lblRCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(5, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigo.TabIndex = 117
        '
        'cboTipoConsulta
        '
        Me.cboTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConsulta.FormattingEnabled = True
        Me.cboTipoConsulta.Location = New System.Drawing.Point(5, 187)
        Me.cboTipoConsulta.Name = "cboTipoConsulta"
        Me.cboTipoConsulta.Size = New System.Drawing.Size(362, 21)
        Me.cboTipoConsulta.TabIndex = 120
        '
        'lblRTipoConsulta
        '
        Me.lblRTipoConsulta.AutoSize = True
        Me.lblRTipoConsulta.Location = New System.Drawing.Point(5, 172)
        Me.lblRTipoConsulta.Name = "lblRTipoConsulta"
        Me.lblRTipoConsulta.Size = New System.Drawing.Size(87, 13)
        Me.lblRTipoConsulta.TabIndex = 124
        Me.lblRTipoConsulta.Text = "Tipo de Consulta"
        '
        'cmdGravar
        '
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(349, 260)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdGravar.TabIndex = 125
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(430, 260)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(75, 28)
        Me.cmdFechar.TabIndex = 126
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'lblRProfissional
        '
        Me.lblRProfissional.AutoSize = True
        Me.lblRProfissional.Location = New System.Drawing.Point(5, 88)
        Me.lblRProfissional.Name = "lblRProfissional"
        Me.lblRProfissional.Size = New System.Drawing.Size(60, 13)
        Me.lblRProfissional.TabIndex = 123
        Me.lblRProfissional.Text = "Profissional"
        '
        'txtDataAgendamento
        '
        Me.txtDataAgendamento.Location = New System.Drawing.Point(373, 187)
        Me.txtDataAgendamento.MaskInput = "{date} {time}"
        Me.txtDataAgendamento.Name = "txtDataAgendamento"
        Me.txtDataAgendamento.Size = New System.Drawing.Size(132, 21)
        Me.txtDataAgendamento.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.txtDataAgendamento.TabIndex = 121
        '
        'lblRDataAgendamento
        '
        Me.lblRDataAgendamento.AutoSize = True
        Me.lblRDataAgendamento.Location = New System.Drawing.Point(373, 172)
        Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
        Me.lblRDataAgendamento.Size = New System.Drawing.Size(30, 13)
        Me.lblRDataAgendamento.TabIndex = 122
        Me.lblRDataAgendamento.Text = "Data"
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(5, 103)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(500, 21)
        Me.cboProfissional.TabIndex = 119
        '
        'cmdDisponibilidade
        '
        Me.cmdDisponibilidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDisponibilidade.Location = New System.Drawing.Point(243, 260)
        Me.cmdDisponibilidade.Name = "cmdDisponibilidade"
        Me.cmdDisponibilidade.Size = New System.Drawing.Size(100, 28)
        Me.cmdDisponibilidade.TabIndex = 214
        Me.cmdDisponibilidade.Text = "Disponibilidade"
        Me.cmdDisponibilidade.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Empresa"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(5, 61)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(500, 21)
        Me.cboEmpresa.TabIndex = 215
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 218
        Me.Label3.Text = "Especialdade"
        '
        'cboEspecialdade
        '
        Me.cboEspecialdade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspecialdade.FormattingEnabled = True
        Me.cboEspecialdade.Location = New System.Drawing.Point(5, 145)
        Me.cboEspecialdade.Name = "cboEspecialdade"
        Me.cboEspecialdade.Size = New System.Drawing.Size(247, 21)
        Me.cboEspecialdade.TabIndex = 217
        '
        'cboGrupoProcedimento
        '
        Me.cboGrupoProcedimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrupoProcedimento.FormattingEnabled = True
        Me.cboGrupoProcedimento.Location = New System.Drawing.Point(258, 145)
        Me.cboGrupoProcedimento.Name = "cboGrupoProcedimento"
        Me.cboGrupoProcedimento.Size = New System.Drawing.Size(247, 21)
        Me.cboGrupoProcedimento.TabIndex = 219
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(258, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Grupo de Procedimento"
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = True
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.GrupoProcedimento = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = True
        Me.psqProcedimento.Location = New System.Drawing.Point(5, 214)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(500, 36)
        Me.psqProcedimento.TabIndex = 129
        '
        'frmCadastroAgendamento_ProfissionalData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 296)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboGrupoProcedimento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboEspecialdade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.cmdDisponibilidade)
        Me.Controls.Add(Me.psqProcedimento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPessoa)
        Me.Controls.Add(Me.lblRCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cboTipoConsulta)
        Me.Controls.Add(Me.lblRTipoConsulta)
        Me.Controls.Add(Me.cmdGravar)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.lblRProfissional)
        Me.Controls.Add(Me.txtDataAgendamento)
        Me.Controls.Add(Me.lblRDataAgendamento)
        Me.Controls.Add(Me.cboProfissional)
        Me.Name = "frmCadastroAgendamento_ProfissionalData"
        Me.Text = "frmCadastroAgendamento_ProfissionalData"
        CType(Me.txtDataAgendamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPessoa As TextBox
    Friend WithEvents lblRCodigo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents cboTipoConsulta As ComboBox
    Friend WithEvents lblRTipoConsulta As Label
    Friend WithEvents cmdGravar As Button
    Friend WithEvents cmdFechar As Button
    Friend WithEvents lblRProfissional As Label
    Friend WithEvents txtDataAgendamento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents lblRDataAgendamento As Label
    Friend WithEvents cboProfissional As ComboBox
  Friend WithEvents psqProcedimento As uscPesqProcedimento
  Friend WithEvents cmdDisponibilidade As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboEspecialdade As ComboBox
    Friend WithEvents cboGrupoProcedimento As ComboBox
    Friend WithEvents Label4 As Label
End Class
