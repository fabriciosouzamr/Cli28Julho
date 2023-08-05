<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uscAnexo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uscAnexo))
    Me.lblAnexo_NomeArquivo = New System.Windows.Forms.Label()
    Me.txtAnexo_Descricao = New System.Windows.Forms.TextBox()
    Me.Label45 = New System.Windows.Forms.Label()
    Me.txtAnexo_Data = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
    Me.lvwAnexos = New System.Windows.Forms.ListView()
    Me.tabAnexo = New System.Windows.Forms.TabControl()
    Me.tbpAnexo_PDF = New System.Windows.Forms.TabPage()
    Me.AcrobatVisualizador = New AxAcroPDFLib.AxAcroPDF()
    Me.tbpAnexo_Imagem = New System.Windows.Forms.TabPage()
    Me.tbpAnexo_TextoRTF = New System.Windows.Forms.TabPage()
    Me.tbpAnexo_Anotacao = New System.Windows.Forms.TabPage()
    Me.Label34 = New System.Windows.Forms.Label()
        Me.picAnexo_Imagem = New uscPictureBox()
        Me.rctAnexo = New uscEditorTexto()
        Me.oEditor_Anotacao = New uscEditorTexto()
        Me.cmdAnexo_Digitalizacao = New System.Windows.Forms.Button()
    Me.cmdAnexo_ObterFoto = New System.Windows.Forms.Button()
    Me.cmdAnexo_SelecionarNovoArquivo = New System.Windows.Forms.Button()
    Me.cmdAnexo_Novo = New System.Windows.Forms.Button()
    Me.cmdAnexo_Excluir = New System.Windows.Forms.Button()
    Me.cmdAnexo_Gravar = New System.Windows.Forms.Button()
    Me.cmdAnexo_Imprimir = New System.Windows.Forms.Button()
    CType(Me.txtAnexo_Data, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tabAnexo.SuspendLayout()
    Me.tbpAnexo_PDF.SuspendLayout()
    CType(Me.AcrobatVisualizador, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tbpAnexo_Imagem.SuspendLayout()
    Me.tbpAnexo_TextoRTF.SuspendLayout()
    Me.tbpAnexo_Anotacao.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblAnexo_NomeArquivo
    '
    Me.lblAnexo_NomeArquivo.AutoSize = True
    Me.lblAnexo_NomeArquivo.Location = New System.Drawing.Point(126, 42)
    Me.lblAnexo_NomeArquivo.Name = "lblAnexo_NomeArquivo"
    Me.lblAnexo_NomeArquivo.Size = New System.Drawing.Size(95, 13)
    Me.lblAnexo_NomeArquivo.TabIndex = 79
    Me.lblAnexo_NomeArquivo.Tag = ""
    Me.lblAnexo_NomeArquivo.Text = "Nome do Arquivo: "
    '
    'txtAnexo_Descricao
    '
    Me.txtAnexo_Descricao.Location = New System.Drawing.Point(251, 16)
    Me.txtAnexo_Descricao.MaxLength = 100
    Me.txtAnexo_Descricao.Name = "txtAnexo_Descricao"
    Me.txtAnexo_Descricao.Size = New System.Drawing.Size(380, 20)
    Me.txtAnexo_Descricao.TabIndex = 74
    '
    'Label45
    '
    Me.Label45.AutoSize = True
    Me.Label45.Location = New System.Drawing.Point(251, 0)
    Me.Label45.Name = "Label45"
    Me.Label45.Size = New System.Drawing.Size(128, 13)
    Me.Label45.TabIndex = 73
    Me.Label45.Text = "Descrição do Documento"
    '
    'txtAnexo_Data
    '
    Me.txtAnexo_Data.DateTime = New Date(2017, 8, 18, 0, 0, 0, 0)
    Me.txtAnexo_Data.Location = New System.Drawing.Point(126, 15)
    Me.txtAnexo_Data.MaskInput = "{date} {time}"
    Me.txtAnexo_Data.Name = "txtAnexo_Data"
    Me.txtAnexo_Data.Size = New System.Drawing.Size(119, 21)
    Me.txtAnexo_Data.TabIndex = 72
    Me.txtAnexo_Data.Value = New Date(2017, 8, 18, 0, 0, 0, 0)
    '
    'lvwAnexos
    '
    Me.lvwAnexos.Location = New System.Drawing.Point(0, 0)
    Me.lvwAnexos.Name = "lvwAnexos"
    Me.lvwAnexos.Size = New System.Drawing.Size(120, 97)
    Me.lvwAnexos.TabIndex = 69
    Me.lvwAnexos.UseCompatibleStateImageBehavior = False
    '
    'tabAnexo
    '
    Me.tabAnexo.Controls.Add(Me.tbpAnexo_PDF)
    Me.tabAnexo.Controls.Add(Me.tbpAnexo_Imagem)
    Me.tabAnexo.Controls.Add(Me.tbpAnexo_TextoRTF)
    Me.tabAnexo.Controls.Add(Me.tbpAnexo_Anotacao)
    Me.tabAnexo.Location = New System.Drawing.Point(126, 57)
    Me.tabAnexo.Name = "tabAnexo"
    Me.tabAnexo.SelectedIndex = 0
    Me.tabAnexo.Size = New System.Drawing.Size(582, 300)
    Me.tabAnexo.TabIndex = 68
    '
    'tbpAnexo_PDF
    '
    Me.tbpAnexo_PDF.Controls.Add(Me.AcrobatVisualizador)
    Me.tbpAnexo_PDF.Location = New System.Drawing.Point(4, 22)
    Me.tbpAnexo_PDF.Name = "tbpAnexo_PDF"
    Me.tbpAnexo_PDF.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpAnexo_PDF.Size = New System.Drawing.Size(574, 274)
    Me.tbpAnexo_PDF.TabIndex = 0
    Me.tbpAnexo_PDF.Text = "PDF"
    Me.tbpAnexo_PDF.UseVisualStyleBackColor = True
    '
    'AcrobatVisualizador
    '
    Me.AcrobatVisualizador.Dock = System.Windows.Forms.DockStyle.Fill
    Me.AcrobatVisualizador.Enabled = True
    Me.AcrobatVisualizador.Location = New System.Drawing.Point(3, 3)
    Me.AcrobatVisualizador.Name = "AcrobatVisualizador"
    Me.AcrobatVisualizador.OcxState = CType(resources.GetObject("AcrobatVisualizador.OcxState"), System.Windows.Forms.AxHost.State)
    Me.AcrobatVisualizador.Size = New System.Drawing.Size(568, 268)
    Me.AcrobatVisualizador.TabIndex = 1
    '
    'tbpAnexo_Imagem
    '
    Me.tbpAnexo_Imagem.AutoScroll = True
    Me.tbpAnexo_Imagem.Controls.Add(Me.picAnexo_Imagem)
    Me.tbpAnexo_Imagem.Location = New System.Drawing.Point(4, 22)
    Me.tbpAnexo_Imagem.Name = "tbpAnexo_Imagem"
    Me.tbpAnexo_Imagem.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpAnexo_Imagem.Size = New System.Drawing.Size(574, 274)
    Me.tbpAnexo_Imagem.TabIndex = 1
    Me.tbpAnexo_Imagem.Text = "Imagem"
    Me.tbpAnexo_Imagem.UseVisualStyleBackColor = True
    '
    'tbpAnexo_TextoRTF
    '
    Me.tbpAnexo_TextoRTF.Controls.Add(Me.rctAnexo)
    Me.tbpAnexo_TextoRTF.Location = New System.Drawing.Point(4, 22)
    Me.tbpAnexo_TextoRTF.Name = "tbpAnexo_TextoRTF"
    Me.tbpAnexo_TextoRTF.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpAnexo_TextoRTF.Size = New System.Drawing.Size(574, 274)
    Me.tbpAnexo_TextoRTF.TabIndex = 3
    Me.tbpAnexo_TextoRTF.Text = "Texto/RTF"
    Me.tbpAnexo_TextoRTF.UseVisualStyleBackColor = True
    '
    'tbpAnexo_Anotacao
    '
    Me.tbpAnexo_Anotacao.Controls.Add(Me.oEditor_Anotacao)
    Me.tbpAnexo_Anotacao.Location = New System.Drawing.Point(4, 22)
    Me.tbpAnexo_Anotacao.Name = "tbpAnexo_Anotacao"
    Me.tbpAnexo_Anotacao.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpAnexo_Anotacao.Size = New System.Drawing.Size(574, 274)
    Me.tbpAnexo_Anotacao.TabIndex = 4
    Me.tbpAnexo_Anotacao.Text = "Anotações"
    Me.tbpAnexo_Anotacao.UseVisualStyleBackColor = True
    '
    'Label34
    '
    Me.Label34.AutoSize = True
    Me.Label34.Location = New System.Drawing.Point(126, 0)
    Me.Label34.Name = "Label34"
    Me.Label34.Size = New System.Drawing.Size(30, 13)
    Me.Label34.TabIndex = 71
    Me.Label34.Text = "Data"
    '
    'picAnexo_Imagem
    '
    Me.picAnexo_Imagem.Arquivo = ""
    Me.picAnexo_Imagem.BotaoExcluir = False
    Me.picAnexo_Imagem.Dock = System.Windows.Forms.DockStyle.Fill
    Me.picAnexo_Imagem.HabilitarBotoes = True
    Me.picAnexo_Imagem.Image = Nothing
    Me.picAnexo_Imagem.Location = New System.Drawing.Point(3, 3)
    Me.picAnexo_Imagem.Name = "picAnexo_Imagem"
    Me.picAnexo_Imagem.SelecionarImagem = False
    Me.picAnexo_Imagem.Size = New System.Drawing.Size(568, 268)
    Me.picAnexo_Imagem.TabIndex = 0
    '
    'rctAnexo
    '
    Me.rctAnexo.DICIONARIODADO_PROCESSO = 0
    Me.rctAnexo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.rctAnexo.ExibirNumeroPagina = False
    Me.rctAnexo.Location = New System.Drawing.Point(3, 3)
    Me.rctAnexo.MODELO_ASSINATURA = 0
    Me.rctAnexo.MODELO_CABECALHO = 0
    Me.rctAnexo.MODELO_RODAPE = 0
    Me.rctAnexo.MODELODOCUMENTO = 0
    Me.rctAnexo.Name = "rctAnexo"
    Me.rctAnexo.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
    "ans Serif;}}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs17\par" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
    Me.rctAnexo.Size = New System.Drawing.Size(568, 268)
    Me.rctAnexo.SoLeitura = False
    Me.rctAnexo.TabIndex = 1
    Me.rctAnexo.Texto = ""
    Me.rctAnexo.TIPO_MODELODOCUMENTO = 0
    '
    'oEditor_Anotacao
    '
    Me.oEditor_Anotacao.DICIONARIODADO_PROCESSO = 0
    Me.oEditor_Anotacao.Dock = System.Windows.Forms.DockStyle.Fill
    Me.oEditor_Anotacao.ExibirNumeroPagina = False
    Me.oEditor_Anotacao.Location = New System.Drawing.Point(3, 3)
    Me.oEditor_Anotacao.MODELO_ASSINATURA = 0
    Me.oEditor_Anotacao.MODELO_CABECALHO = 0
    Me.oEditor_Anotacao.MODELO_RODAPE = 0
    Me.oEditor_Anotacao.MODELODOCUMENTO = 0
    Me.oEditor_Anotacao.Name = "oEditor_Anotacao"
    Me.oEditor_Anotacao.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft S" & _
    "ans Serif;}}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs17\par" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
    Me.oEditor_Anotacao.Size = New System.Drawing.Size(568, 268)
    Me.oEditor_Anotacao.SoLeitura = False
    Me.oEditor_Anotacao.TabIndex = 0
    Me.oEditor_Anotacao.Texto = ""
    Me.oEditor_Anotacao.TIPO_MODELODOCUMENTO = 0
        '
        'cmdAnexo_Digitalizacao
        '
        Me.cmdAnexo_Digitalizacao.Image = My.Resources.Resources.Mini_Digitalizacao
        Me.cmdAnexo_Digitalizacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAnexo_Digitalizacao.Location = New System.Drawing.Point(510, 360)
        Me.cmdAnexo_Digitalizacao.Name = "cmdAnexo_Digitalizacao"
        Me.cmdAnexo_Digitalizacao.Size = New System.Drawing.Size(90, 28)
        Me.cmdAnexo_Digitalizacao.TabIndex = 93
        Me.cmdAnexo_Digitalizacao.TabStop = False
        Me.cmdAnexo_Digitalizacao.Text = "     Digitalização"
        Me.cmdAnexo_Digitalizacao.UseVisualStyleBackColor = True
        '
        'cmdAnexo_ObterFoto
        '
        Me.cmdAnexo_ObterFoto.Image = My.Resources.Resources.Mini_Imagem
        Me.cmdAnexo_ObterFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAnexo_ObterFoto.Location = New System.Drawing.Point(414, 360)
        Me.cmdAnexo_ObterFoto.Name = "cmdAnexo_ObterFoto"
        Me.cmdAnexo_ObterFoto.Size = New System.Drawing.Size(90, 28)
        Me.cmdAnexo_ObterFoto.TabIndex = 92
        Me.cmdAnexo_ObterFoto.TabStop = False
        Me.cmdAnexo_ObterFoto.Text = "   Obter Foto"
        Me.cmdAnexo_ObterFoto.UseVisualStyleBackColor = True
        '
        'cmdAnexo_SelecionarNovoArquivo
        '
        Me.cmdAnexo_SelecionarNovoArquivo.Image = My.Resources.Resources.Mini_Diretorio
        Me.cmdAnexo_SelecionarNovoArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAnexo_SelecionarNovoArquivo.Location = New System.Drawing.Point(288, 360)
        Me.cmdAnexo_SelecionarNovoArquivo.Name = "cmdAnexo_SelecionarNovoArquivo"
        Me.cmdAnexo_SelecionarNovoArquivo.Size = New System.Drawing.Size(120, 28)
        Me.cmdAnexo_SelecionarNovoArquivo.TabIndex = 91
        Me.cmdAnexo_SelecionarNovoArquivo.TabStop = False
        Me.cmdAnexo_SelecionarNovoArquivo.Text = "    Selecionar arquivo"
        Me.cmdAnexo_SelecionarNovoArquivo.UseVisualStyleBackColor = True
        '
        'cmdAnexo_Novo
        '
        Me.cmdAnexo_Novo.Image = My.Resources.Resources.Mini_Novo
        Me.cmdAnexo_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAnexo_Novo.Location = New System.Drawing.Point(126, 360)
        Me.cmdAnexo_Novo.Name = "cmdAnexo_Novo"
        Me.cmdAnexo_Novo.Size = New System.Drawing.Size(75, 28)
        Me.cmdAnexo_Novo.TabIndex = 90
        Me.cmdAnexo_Novo.Text = "  Novo"
        Me.cmdAnexo_Novo.UseVisualStyleBackColor = True
        '
        'cmdAnexo_Excluir
        '
        Me.cmdAnexo_Excluir.Image = My.Resources.Resources.Mini_Excluir2
        Me.cmdAnexo_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAnexo_Excluir.Location = New System.Drawing.Point(207, 360)
        Me.cmdAnexo_Excluir.Name = "cmdAnexo_Excluir"
        Me.cmdAnexo_Excluir.Size = New System.Drawing.Size(75, 28)
        Me.cmdAnexo_Excluir.TabIndex = 89
        Me.cmdAnexo_Excluir.Text = "Excluir"
        Me.cmdAnexo_Excluir.UseVisualStyleBackColor = True
        '
        'cmdAnexo_Gravar
        '
        Me.cmdAnexo_Gravar.Image = My.Resources.Resources.Mini_Salvar
        Me.cmdAnexo_Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAnexo_Gravar.Location = New System.Drawing.Point(637, 8)
        Me.cmdAnexo_Gravar.Name = "cmdAnexo_Gravar"
        Me.cmdAnexo_Gravar.Size = New System.Drawing.Size(75, 28)
        Me.cmdAnexo_Gravar.TabIndex = 76
        Me.cmdAnexo_Gravar.Text = "  Gravar"
        Me.cmdAnexo_Gravar.UseVisualStyleBackColor = True
        '
        'cmdAnexo_Imprimir
        '
        Me.cmdAnexo_Imprimir.Image = My.Resources.Resources.Mini_Imprimir
        Me.cmdAnexo_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdAnexo_Imprimir.Location = New System.Drawing.Point(633, 360)
    Me.cmdAnexo_Imprimir.Name = "cmdAnexo_Imprimir"
    Me.cmdAnexo_Imprimir.Size = New System.Drawing.Size(75, 28)
    Me.cmdAnexo_Imprimir.TabIndex = 70
    Me.cmdAnexo_Imprimir.Text = "  Imprimir"
    Me.cmdAnexo_Imprimir.UseVisualStyleBackColor = True
    '
    'uscAnexo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.cmdAnexo_Digitalizacao)
    Me.Controls.Add(Me.cmdAnexo_ObterFoto)
    Me.Controls.Add(Me.cmdAnexo_SelecionarNovoArquivo)
    Me.Controls.Add(Me.cmdAnexo_Novo)
    Me.Controls.Add(Me.cmdAnexo_Excluir)
    Me.Controls.Add(Me.lblAnexo_NomeArquivo)
    Me.Controls.Add(Me.cmdAnexo_Gravar)
    Me.Controls.Add(Me.txtAnexo_Descricao)
    Me.Controls.Add(Me.Label45)
    Me.Controls.Add(Me.txtAnexo_Data)
    Me.Controls.Add(Me.cmdAnexo_Imprimir)
    Me.Controls.Add(Me.lvwAnexos)
    Me.Controls.Add(Me.tabAnexo)
    Me.Controls.Add(Me.Label34)
    Me.Name = "uscAnexo"
    Me.Size = New System.Drawing.Size(788, 430)
    CType(Me.txtAnexo_Data, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tabAnexo.ResumeLayout(False)
    Me.tbpAnexo_PDF.ResumeLayout(False)
    CType(Me.AcrobatVisualizador, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tbpAnexo_Imagem.ResumeLayout(False)
    Me.tbpAnexo_TextoRTF.ResumeLayout(False)
    Me.tbpAnexo_Anotacao.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAnexo_NomeArquivo As System.Windows.Forms.Label
  Friend WithEvents cmdAnexo_Gravar As System.Windows.Forms.Button
  Friend WithEvents txtAnexo_Descricao As System.Windows.Forms.TextBox
  Friend WithEvents Label45 As System.Windows.Forms.Label
  Friend WithEvents txtAnexo_Data As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
  Friend WithEvents cmdAnexo_Imprimir As System.Windows.Forms.Button
  Friend WithEvents lvwAnexos As System.Windows.Forms.ListView
  Friend WithEvents tabAnexo As System.Windows.Forms.TabControl
  Friend WithEvents tbpAnexo_PDF As System.Windows.Forms.TabPage
  Friend WithEvents AcrobatVisualizador As AxAcroPDFLib.AxAcroPDF
  Friend WithEvents tbpAnexo_Imagem As System.Windows.Forms.TabPage
  Friend WithEvents tbpAnexo_TextoRTF As System.Windows.Forms.TabPage
    Friend WithEvents rctAnexo As uscEditorTexto
    Friend WithEvents tbpAnexo_Anotacao As System.Windows.Forms.TabPage
    Friend WithEvents oEditor_Anotacao As uscEditorTexto
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents picAnexo_Imagem As uscPictureBox
    Friend WithEvents cmdAnexo_Excluir As System.Windows.Forms.Button
  Friend WithEvents cmdAnexo_Novo As System.Windows.Forms.Button
  Friend WithEvents cmdAnexo_SelecionarNovoArquivo As System.Windows.Forms.Button
  Friend WithEvents cmdAnexo_ObterFoto As System.Windows.Forms.Button
  Friend WithEvents cmdAnexo_Digitalizacao As System.Windows.Forms.Button

End Class
