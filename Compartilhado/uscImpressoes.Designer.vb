<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uscImpressoes
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.spcImpressoes = New System.Windows.Forms.SplitContainer()
    Me.tvwModeloDocumento = New System.Windows.Forms.TreeView()
    Me.pnlImpressoes_Editor = New System.Windows.Forms.Panel()
    Me.oEditorImpressoes = New uscEditorTexto()
    Me.pnlImpressoes_Botoes = New System.Windows.Forms.Panel()
    Me.cmdImpressoes_Gravar = New System.Windows.Forms.Button()
    CType(Me.spcImpressoes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.spcImpressoes.Panel1.SuspendLayout()
    Me.spcImpressoes.Panel2.SuspendLayout()
    Me.spcImpressoes.SuspendLayout()
    Me.pnlImpressoes_Editor.SuspendLayout()
    Me.pnlImpressoes_Botoes.SuspendLayout()
    Me.SuspendLayout()
    '
    'spcImpressoes
    '
    Me.spcImpressoes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.spcImpressoes.Location = New System.Drawing.Point(0, 0)
    Me.spcImpressoes.Name = "spcImpressoes"
    '
    'spcImpressoes.Panel1
    '
    Me.spcImpressoes.Panel1.Controls.Add(Me.tvwModeloDocumento)
    '
    'spcImpressoes.Panel2
    '
    Me.spcImpressoes.Panel2.Controls.Add(Me.pnlImpressoes_Editor)
    Me.spcImpressoes.Panel2.Controls.Add(Me.pnlImpressoes_Botoes)
    Me.spcImpressoes.Size = New System.Drawing.Size(1164, 523)
    Me.spcImpressoes.SplitterDistance = 331
    Me.spcImpressoes.TabIndex = 2
    '
    'tvwModeloDocumento
    '
    Me.tvwModeloDocumento.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvwModeloDocumento.Location = New System.Drawing.Point(0, 0)
    Me.tvwModeloDocumento.Name = "tvwModeloDocumento"
    Me.tvwModeloDocumento.Size = New System.Drawing.Size(331, 523)
    Me.tvwModeloDocumento.TabIndex = 0
    '
    'pnlImpressoes_Editor
    '
    Me.pnlImpressoes_Editor.Controls.Add(Me.oEditorImpressoes)
    Me.pnlImpressoes_Editor.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlImpressoes_Editor.Location = New System.Drawing.Point(0, 0)
    Me.pnlImpressoes_Editor.Name = "pnlImpressoes_Editor"
    Me.pnlImpressoes_Editor.Size = New System.Drawing.Size(829, 485)
    Me.pnlImpressoes_Editor.TabIndex = 2
    '
    'oEditorImpressoes
    '
    Me.oEditorImpressoes.DICIONARIODADO_PROCESSO = 0
    Me.oEditorImpressoes.Dock = System.Windows.Forms.DockStyle.Fill
    Me.oEditorImpressoes.ExibirNumeroPagina = False
    Me.oEditorImpressoes.IDENTIFICADOR = 0
    Me.oEditorImpressoes.Location = New System.Drawing.Point(0, 0)
    Me.oEditorImpressoes.MODELO_ASSINATURA = 0
    Me.oEditorImpressoes.MODELO_CABECALHO = 0
    Me.oEditorImpressoes.MODELO_RODAPE = 0
    Me.oEditorImpressoes.MODELODOCUMENTO = 0
    Me.oEditorImpressoes.Name = "oEditorImpressoes"
    Me.oEditorImpressoes.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang1046{\fonttbl{\f0\fnil\fcharset0 Microsoft S" &
    "ans Serif;}}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs17\par" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
    Me.oEditorImpressoes.Size = New System.Drawing.Size(829, 485)
    Me.oEditorImpressoes.SoLeitura = False
    Me.oEditorImpressoes.TabIndex = 1
    Me.oEditorImpressoes.Texto = ""
    Me.oEditorImpressoes.TIPO_MODELODOCUMENTO = 0
    '
    'pnlImpressoes_Botoes
    '
    Me.pnlImpressoes_Botoes.Controls.Add(Me.cmdImpressoes_Gravar)
    Me.pnlImpressoes_Botoes.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.pnlImpressoes_Botoes.Location = New System.Drawing.Point(0, 485)
    Me.pnlImpressoes_Botoes.Name = "pnlImpressoes_Botoes"
    Me.pnlImpressoes_Botoes.Size = New System.Drawing.Size(829, 38)
    Me.pnlImpressoes_Botoes.TabIndex = 1
    '
    'cmdImpressoes_Gravar
    '
    Me.cmdImpressoes_Gravar.Image = My.Resources.Resources.Mini_Salvar
    Me.cmdImpressoes_Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.cmdImpressoes_Gravar.Location = New System.Drawing.Point(665, 5)
    Me.cmdImpressoes_Gravar.Name = "cmdImpressoes_Gravar"
    Me.cmdImpressoes_Gravar.Size = New System.Drawing.Size(75, 28)
    Me.cmdImpressoes_Gravar.TabIndex = 111
    Me.cmdImpressoes_Gravar.Text = "  Gravar"
    Me.cmdImpressoes_Gravar.UseVisualStyleBackColor = True
    '
    'uscImpressoes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.spcImpressoes)
    Me.Name = "uscImpressoes"
    Me.Size = New System.Drawing.Size(1164, 523)
    Me.spcImpressoes.Panel1.ResumeLayout(False)
    Me.spcImpressoes.Panel2.ResumeLayout(False)
    CType(Me.spcImpressoes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.spcImpressoes.ResumeLayout(False)
    Me.pnlImpressoes_Editor.ResumeLayout(False)
    Me.pnlImpressoes_Botoes.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents spcImpressoes As System.Windows.Forms.SplitContainer
  Friend WithEvents tvwModeloDocumento As System.Windows.Forms.TreeView
  Friend WithEvents pnlImpressoes_Botoes As System.Windows.Forms.Panel
  Friend WithEvents cmdImpressoes_Gravar As System.Windows.Forms.Button
  Friend WithEvents pnlImpressoes_Editor As System.Windows.Forms.Panel
  Friend WithEvents oEditorImpressoes As uscEditorTexto
End Class
