<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLancaAgendamento_ProfissionalData
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
    Me.cboProfissional = New System.Windows.Forms.ComboBox()
    Me.txtDataAgendamento = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lblRDataAgendamento = New System.Windows.Forms.Label()
    Me.lblRProfissional = New System.Windows.Forms.Label()
    Me.lblRTipoConsulta = New System.Windows.Forms.Label()
    Me.cboTipoConsulta = New System.Windows.Forms.ComboBox()
    Me.cmdGravar = New System.Windows.Forms.Button()
    Me.cmdFechar = New System.Windows.Forms.Button()
    Me.lblRCodigo = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtPessoa = New System.Windows.Forms.TextBox()
        Me.psqProcedimento = New Cli28Julho.uscPesqProcedimento()
        Me.cmdDisponibilidade = New System.Windows.Forms.Button()
        CType(Me.txtDataAgendamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProfissional
        '
        Me.cboProfissional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfissional.FormattingEnabled = True
        Me.cboProfissional.Location = New System.Drawing.Point(7, 71)
        Me.cboProfissional.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboProfissional.Name = "cboProfissional"
        Me.cboProfissional.Size = New System.Drawing.Size(665, 24)
        Me.cboProfissional.TabIndex = 3
        '
        'txtDataAgendamento
        '
        Me.txtDataAgendamento.Location = New System.Drawing.Point(497, 123)
        Me.txtDataAgendamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDataAgendamento.MaskInput = "{date} {time}"
        Me.txtDataAgendamento.Name = "txtDataAgendamento"
        Me.txtDataAgendamento.Size = New System.Drawing.Size(176, 24)
        Me.txtDataAgendamento.SpinButtonDisplayStyle = Infragistics.Win.ButtonDisplayStyle.Always
        Me.txtDataAgendamento.TabIndex = 5
        '
        'lblRDataAgendamento
        '
        Me.lblRDataAgendamento.AutoSize = True
        Me.lblRDataAgendamento.Location = New System.Drawing.Point(497, 105)
        Me.lblRDataAgendamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRDataAgendamento.Name = "lblRDataAgendamento"
        Me.lblRDataAgendamento.Size = New System.Drawing.Size(36, 16)
        Me.lblRDataAgendamento.TabIndex = 59
        Me.lblRDataAgendamento.Text = "Data"
        '
        'lblRProfissional
        '
        Me.lblRProfissional.AutoSize = True
        Me.lblRProfissional.Location = New System.Drawing.Point(7, 53)
        Me.lblRProfissional.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRProfissional.Name = "lblRProfissional"
        Me.lblRProfissional.Size = New System.Drawing.Size(77, 16)
        Me.lblRProfissional.TabIndex = 61
        Me.lblRProfissional.Text = "Profissional"
        '
        'lblRTipoConsulta
        '
        Me.lblRTipoConsulta.AutoSize = True
        Me.lblRTipoConsulta.Location = New System.Drawing.Point(7, 105)
        Me.lblRTipoConsulta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRTipoConsulta.Name = "lblRTipoConsulta"
        Me.lblRTipoConsulta.Size = New System.Drawing.Size(109, 16)
        Me.lblRTipoConsulta.TabIndex = 64
        Me.lblRTipoConsulta.Text = "Tipo de Consulta"
        '
        'cboTipoConsulta
        '
        Me.cboTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConsulta.FormattingEnabled = True
        Me.cboTipoConsulta.Location = New System.Drawing.Point(7, 123)
        Me.cboTipoConsulta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTipoConsulta.Name = "cboTipoConsulta"
        Me.cboTipoConsulta.Size = New System.Drawing.Size(481, 24)
        Me.cboTipoConsulta.TabIndex = 4
        '
        'cmdGravar
        '
        Me.cmdGravar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Salvar
        Me.cmdGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGravar.Location = New System.Drawing.Point(465, 213)
        Me.cmdGravar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGravar.Name = "cmdGravar"
        Me.cmdGravar.Size = New System.Drawing.Size(100, 34)
        Me.cmdGravar.TabIndex = 100
        Me.cmdGravar.Text = "  Gravar"
        Me.cmdGravar.UseVisualStyleBackColor = True
        '
        'cmdFechar
        '
        Me.cmdFechar.Image = Global.Cli28Julho.My.Resources.Resources.Mini_Fechar
        Me.cmdFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFechar.Location = New System.Drawing.Point(573, 213)
        Me.cmdFechar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(100, 34)
        Me.cmdFechar.TabIndex = 101
        Me.cmdFechar.Text = "  Fechar"
        Me.cmdFechar.UseVisualStyleBackColor = True
        '
        'lblRCodigo
        '
        Me.lblRCodigo.AutoSize = True
        Me.lblRCodigo.Location = New System.Drawing.Point(7, 2)
        Me.lblRCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRCodigo.Name = "lblRCodigo"
        Me.lblRCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblRCodigo.TabIndex = 114
        Me.lblRCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(7, 21)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(79, 22)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Pessoa"
        '
        'txtPessoa
        '
        Me.txtPessoa.Location = New System.Drawing.Point(95, 21)
        Me.txtPessoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPessoa.Name = "txtPessoa"
        Me.txtPessoa.ReadOnly = True
        Me.txtPessoa.Size = New System.Drawing.Size(577, 22)
        Me.txtPessoa.TabIndex = 2
        '
        'psqProcedimento
        '
        Me.psqProcedimento.Bordas = True
        Me.psqProcedimento.Convenio = 0
        Me.psqProcedimento.GrupoProcedimento = 0
        Me.psqProcedimento.Identificador = 0
        Me.psqProcedimento.LabelVisivel = True
        Me.psqProcedimento.Location = New System.Drawing.Point(7, 156)
        Me.psqProcedimento.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.psqProcedimento.Name = "psqProcedimento"
        Me.psqProcedimento.Profissional = 0
        Me.psqProcedimento.Size = New System.Drawing.Size(667, 44)
        Me.psqProcedimento.TabIndex = 6
        '
        'cmdDisponibilidade
        '
        Me.cmdDisponibilidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDisponibilidade.Location = New System.Drawing.Point(324, 213)
        Me.cmdDisponibilidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDisponibilidade.Name = "cmdDisponibilidade"
        Me.cmdDisponibilidade.Size = New System.Drawing.Size(133, 34)
        Me.cmdDisponibilidade.TabIndex = 215
        Me.cmdDisponibilidade.Text = "Disponibilidade"
        Me.cmdDisponibilidade.UseVisualStyleBackColor = True
        '
        'frmLancaAgendamento_ProfissionalData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdDisponibilidade)
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
        Me.Controls.Add(Me.psqProcedimento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLancaAgendamento_ProfissionalData"
        Me.Text = "Agendamento"
        CType(Me.txtDataAgendamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboProfissional As System.Windows.Forms.ComboBox
  Friend WithEvents txtDataAgendamento As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents lblRDataAgendamento As System.Windows.Forms.Label
  Friend WithEvents lblRProfissional As System.Windows.Forms.Label
  Friend WithEvents cmdGravar As System.Windows.Forms.Button
  Friend WithEvents cmdFechar As System.Windows.Forms.Button
  Friend WithEvents lblRTipoConsulta As System.Windows.Forms.Label
  Friend WithEvents cboTipoConsulta As System.Windows.Forms.ComboBox
  Friend WithEvents psqProcedimento As uscPesqProcedimento
  Friend WithEvents lblRCodigo As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtPessoa As System.Windows.Forms.TextBox
    Friend WithEvents cmdDisponibilidade As Button
End Class
