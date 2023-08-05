<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadastroAtendimentoSolicitacaoExame
  Inherits System.Windows.Forms.Form

  'Descartar substituições de formulário para limpar a lista de componentes.
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

  'Exigido pelo Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
  'Pode ser modificado usando o Windows Form Designer.  
  'Não o modifique usando o editor de códigos.
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAtendimentoSolicitacaoExame))
    Me.picGeral = New System.Windows.Forms.PictureBox()
    Me.lblIdade = New System.Windows.Forms.Label()
    Me.optCitologico = New System.Windows.Forms.RadioButton()
    Me.optLaboratorias = New System.Windows.Forms.RadioButton()
    Me.optComplementares = New System.Windows.Forms.RadioButton()
    Me.lblExame01 = New System.Windows.Forms.Label()
    Me.cmdSelecionar01 = New System.Windows.Forms.Button()
    Me.lblExameEscolhido01 = New System.Windows.Forms.Label()
    Me.txtObservacao01 = New System.Windows.Forms.TextBox()
    Me.cmdExcluir01 = New System.Windows.Forms.Button()
    Me.cmdExcluir02 = New System.Windows.Forms.Button()
    Me.txtObservacao02 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido02 = New System.Windows.Forms.Label()
    Me.cmdSelecionar02 = New System.Windows.Forms.Button()
    Me.lblExame02 = New System.Windows.Forms.Label()
    Me.cmdExcluir03 = New System.Windows.Forms.Button()
    Me.txtObservacao03 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido03 = New System.Windows.Forms.Label()
    Me.cmdSelecionar03 = New System.Windows.Forms.Button()
    Me.lblExame03 = New System.Windows.Forms.Label()
    Me.cmdExcluir04 = New System.Windows.Forms.Button()
    Me.txtObservacao04 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido04 = New System.Windows.Forms.Label()
    Me.cmdSelecionar04 = New System.Windows.Forms.Button()
    Me.lblExame04 = New System.Windows.Forms.Label()
    Me.cmdExcluir05 = New System.Windows.Forms.Button()
    Me.txtObservacao05 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido05 = New System.Windows.Forms.Label()
    Me.cmdSelecionar05 = New System.Windows.Forms.Button()
    Me.lblExame05 = New System.Windows.Forms.Label()
    Me.cmdExcluir06 = New System.Windows.Forms.Button()
    Me.txtObservacao06 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido06 = New System.Windows.Forms.Label()
    Me.cmdSelecionar06 = New System.Windows.Forms.Button()
    Me.lblExame06 = New System.Windows.Forms.Label()
    Me.cmdExcluir07 = New System.Windows.Forms.Button()
    Me.txtObservacao07 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido07 = New System.Windows.Forms.Label()
    Me.cmdSelecionar07 = New System.Windows.Forms.Button()
    Me.lblExame07 = New System.Windows.Forms.Label()
    Me.cmdExcluir08 = New System.Windows.Forms.Button()
    Me.txtObservacao08 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido08 = New System.Windows.Forms.Label()
    Me.cmdSelecionar08 = New System.Windows.Forms.Button()
    Me.lblExame08 = New System.Windows.Forms.Label()
    Me.cmdExcluir09 = New System.Windows.Forms.Button()
    Me.txtObservacao09 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido09 = New System.Windows.Forms.Label()
    Me.cmdSelecionar09 = New System.Windows.Forms.Button()
    Me.lblExame09 = New System.Windows.Forms.Label()
    Me.cmdExcluir10 = New System.Windows.Forms.Button()
    Me.txtObservacao10 = New System.Windows.Forms.TextBox()
    Me.lblExameEscolhido10 = New System.Windows.Forms.Label()
    Me.cmdSelecionar10 = New System.Windows.Forms.Button()
    Me.lblExame10 = New System.Windows.Forms.Label()
        Me.vsbExame = New System.Windows.Forms.VScrollBar()
        Me.vsbExameEscolhido = New System.Windows.Forms.VScrollBar()
        Me.txtFiltroExame = New System.Windows.Forms.TextBox()
        Me.cboClassificacaoExame = New System.Windows.Forms.ComboBox()
        Me.optOutros = New System.Windows.Forms.RadioButton()
        Me.cmdVisualizar = New Cli28Julho.uscBotao()
        Me.cmdFechar = New Cli28Julho.uscBotao()
        Me.cmdImprimir = New Cli28Julho.uscBotao()
        Me.chkSelecionarImpressao01 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao02 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao04 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao03 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao08 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao07 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao06 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao05 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao10 = New System.Windows.Forms.CheckBox()
        Me.chkSelecionarImpressao09 = New System.Windows.Forms.CheckBox()
        Me.cmdImprimirSelecionados = New Cli28Julho.uscBotao()
        Me.lblProntuario = New System.Windows.Forms.Label()
        Me.lblPessoa = New System.Windows.Forms.Label()
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGeral
        '
        Me.picGeral.ErrorImage = Nothing
        Me.picGeral.Image = CType(resources.GetObject("picGeral.Image"), System.Drawing.Image)
        Me.picGeral.Location = New System.Drawing.Point(5, 5)
        Me.picGeral.Name = "picGeral"
        Me.picGeral.Size = New System.Drawing.Size(987, 670)
        Me.picGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGeral.TabIndex = 0
        Me.picGeral.TabStop = False
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Location = New System.Drawing.Point(575, 37)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(44, 13)
        Me.lblIdade.TabIndex = 2
        Me.lblIdade.Text = "lblIdade"
        '
        'optCitologico
        '
        Me.optCitologico.AutoSize = True
        Me.optCitologico.Location = New System.Drawing.Point(289, 95)
        Me.optCitologico.Name = "optCitologico"
        Me.optCitologico.Size = New System.Drawing.Size(14, 13)
        Me.optCitologico.TabIndex = 3
        Me.optCitologico.UseVisualStyleBackColor = True
        '
        'optLaboratorias
        '
        Me.optLaboratorias.AutoSize = True
        Me.optLaboratorias.Location = New System.Drawing.Point(67, 95)
        Me.optLaboratorias.Name = "optLaboratorias"
        Me.optLaboratorias.Size = New System.Drawing.Size(14, 13)
        Me.optLaboratorias.TabIndex = 4
        Me.optLaboratorias.UseVisualStyleBackColor = True
        '
        'optComplementares
        '
        Me.optComplementares.AutoSize = True
        Me.optComplementares.Location = New System.Drawing.Point(180, 95)
        Me.optComplementares.Name = "optComplementares"
        Me.optComplementares.Size = New System.Drawing.Size(14, 13)
        Me.optComplementares.TabIndex = 5
        Me.optComplementares.UseVisualStyleBackColor = True
        '
        'lblExame01
        '
        Me.lblExame01.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame01.Location = New System.Drawing.Point(16, 279)
        Me.lblExame01.Name = "lblExame01"
        Me.lblExame01.Size = New System.Drawing.Size(326, 13)
        Me.lblExame01.TabIndex = 10
        Me.lblExame01.Text = "lblExame01"
        '
        'cmdSelecionar01
        '
        Me.cmdSelecionar01.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar01.Location = New System.Drawing.Point(355, 271)
        Me.cmdSelecionar01.Name = "cmdSelecionar01"
        Me.cmdSelecionar01.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar01.TabIndex = 11
        Me.cmdSelecionar01.Text = ">>"
        Me.cmdSelecionar01.UseVisualStyleBackColor = True
        '
        'lblExameEscolhido01
        '
        Me.lblExameEscolhido01.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido01.Location = New System.Drawing.Point(419, 279)
        Me.lblExameEscolhido01.Name = "lblExameEscolhido01"
        Me.lblExameEscolhido01.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido01.TabIndex = 12
        Me.lblExameEscolhido01.Text = "lblExameEscolhido01"
        '
        'txtObservacao01
        '
        Me.txtObservacao01.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao01.Location = New System.Drawing.Point(669, 279)
        Me.txtObservacao01.Name = "txtObservacao01"
        Me.txtObservacao01.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao01.TabIndex = 13
        '
        'cmdExcluir01
        '
        Me.cmdExcluir01.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir01.Location = New System.Drawing.Point(949, 272)
        Me.cmdExcluir01.Name = "cmdExcluir01"
        Me.cmdExcluir01.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir01.TabIndex = 14
        Me.cmdExcluir01.Text = "<<"
        Me.cmdExcluir01.UseVisualStyleBackColor = True
        '
        'cmdExcluir02
        '
        Me.cmdExcluir02.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir02.Location = New System.Drawing.Point(949, 306)
        Me.cmdExcluir02.Name = "cmdExcluir02"
        Me.cmdExcluir02.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir02.TabIndex = 19
        Me.cmdExcluir02.Text = "<<"
        Me.cmdExcluir02.UseVisualStyleBackColor = True
        '
        'txtObservacao02
        '
        Me.txtObservacao02.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao02.Location = New System.Drawing.Point(669, 313)
        Me.txtObservacao02.Name = "txtObservacao02"
        Me.txtObservacao02.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao02.TabIndex = 18
        '
        'lblExameEscolhido02
        '
        Me.lblExameEscolhido02.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido02.Location = New System.Drawing.Point(419, 313)
        Me.lblExameEscolhido02.Name = "lblExameEscolhido02"
        Me.lblExameEscolhido02.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido02.TabIndex = 17
        Me.lblExameEscolhido02.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar02
        '
        Me.cmdSelecionar02.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar02.Location = New System.Drawing.Point(355, 305)
        Me.cmdSelecionar02.Name = "cmdSelecionar02"
        Me.cmdSelecionar02.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar02.TabIndex = 16
        Me.cmdSelecionar02.Text = ">>"
        Me.cmdSelecionar02.UseVisualStyleBackColor = True
        '
        'lblExame02
        '
        Me.lblExame02.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame02.Location = New System.Drawing.Point(16, 313)
        Me.lblExame02.Name = "lblExame02"
        Me.lblExame02.Size = New System.Drawing.Size(326, 13)
        Me.lblExame02.TabIndex = 15
        Me.lblExame02.Text = "lblExame01"
        '
        'cmdExcluir03
        '
        Me.cmdExcluir03.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir03.Location = New System.Drawing.Point(949, 340)
        Me.cmdExcluir03.Name = "cmdExcluir03"
        Me.cmdExcluir03.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir03.TabIndex = 24
        Me.cmdExcluir03.Text = "<<"
        Me.cmdExcluir03.UseVisualStyleBackColor = True
        '
        'txtObservacao03
        '
        Me.txtObservacao03.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao03.Location = New System.Drawing.Point(669, 347)
        Me.txtObservacao03.Name = "txtObservacao03"
        Me.txtObservacao03.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao03.TabIndex = 23
        '
        'lblExameEscolhido03
        '
        Me.lblExameEscolhido03.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido03.Location = New System.Drawing.Point(419, 347)
        Me.lblExameEscolhido03.Name = "lblExameEscolhido03"
        Me.lblExameEscolhido03.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido03.TabIndex = 22
        Me.lblExameEscolhido03.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar03
        '
        Me.cmdSelecionar03.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar03.Location = New System.Drawing.Point(355, 339)
        Me.cmdSelecionar03.Name = "cmdSelecionar03"
        Me.cmdSelecionar03.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar03.TabIndex = 21
        Me.cmdSelecionar03.Text = ">>"
        Me.cmdSelecionar03.UseVisualStyleBackColor = True
        '
        'lblExame03
        '
        Me.lblExame03.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame03.Location = New System.Drawing.Point(16, 347)
        Me.lblExame03.Name = "lblExame03"
        Me.lblExame03.Size = New System.Drawing.Size(326, 13)
        Me.lblExame03.TabIndex = 20
        Me.lblExame03.Text = "lblExame01"
        '
        'cmdExcluir04
        '
        Me.cmdExcluir04.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir04.Location = New System.Drawing.Point(949, 374)
        Me.cmdExcluir04.Name = "cmdExcluir04"
        Me.cmdExcluir04.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir04.TabIndex = 29
        Me.cmdExcluir04.Text = "<<"
        Me.cmdExcluir04.UseVisualStyleBackColor = True
        '
        'txtObservacao04
        '
        Me.txtObservacao04.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao04.Location = New System.Drawing.Point(669, 381)
        Me.txtObservacao04.Name = "txtObservacao04"
        Me.txtObservacao04.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao04.TabIndex = 28
        '
        'lblExameEscolhido04
        '
        Me.lblExameEscolhido04.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido04.Location = New System.Drawing.Point(419, 381)
        Me.lblExameEscolhido04.Name = "lblExameEscolhido04"
        Me.lblExameEscolhido04.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido04.TabIndex = 27
        Me.lblExameEscolhido04.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar04
        '
        Me.cmdSelecionar04.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar04.Location = New System.Drawing.Point(355, 373)
        Me.cmdSelecionar04.Name = "cmdSelecionar04"
        Me.cmdSelecionar04.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar04.TabIndex = 26
        Me.cmdSelecionar04.Text = ">>"
        Me.cmdSelecionar04.UseVisualStyleBackColor = True
        '
        'lblExame04
        '
        Me.lblExame04.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame04.Location = New System.Drawing.Point(16, 381)
        Me.lblExame04.Name = "lblExame04"
        Me.lblExame04.Size = New System.Drawing.Size(326, 13)
        Me.lblExame04.TabIndex = 25
        Me.lblExame04.Text = "lblExame01"
        '
        'cmdExcluir05
        '
        Me.cmdExcluir05.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir05.Location = New System.Drawing.Point(949, 408)
        Me.cmdExcluir05.Name = "cmdExcluir05"
        Me.cmdExcluir05.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir05.TabIndex = 34
        Me.cmdExcluir05.Text = "<<"
        Me.cmdExcluir05.UseVisualStyleBackColor = True
        '
        'txtObservacao05
        '
        Me.txtObservacao05.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao05.Location = New System.Drawing.Point(669, 415)
        Me.txtObservacao05.Name = "txtObservacao05"
        Me.txtObservacao05.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao05.TabIndex = 33
        '
        'lblExameEscolhido05
        '
        Me.lblExameEscolhido05.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido05.Location = New System.Drawing.Point(419, 415)
        Me.lblExameEscolhido05.Name = "lblExameEscolhido05"
        Me.lblExameEscolhido05.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido05.TabIndex = 32
        Me.lblExameEscolhido05.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar05
        '
        Me.cmdSelecionar05.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar05.Location = New System.Drawing.Point(355, 407)
        Me.cmdSelecionar05.Name = "cmdSelecionar05"
        Me.cmdSelecionar05.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar05.TabIndex = 31
        Me.cmdSelecionar05.Text = ">>"
        Me.cmdSelecionar05.UseVisualStyleBackColor = True
        '
        'lblExame05
        '
        Me.lblExame05.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame05.Location = New System.Drawing.Point(16, 415)
        Me.lblExame05.Name = "lblExame05"
        Me.lblExame05.Size = New System.Drawing.Size(326, 13)
        Me.lblExame05.TabIndex = 30
        Me.lblExame05.Text = "lblExame01"
        '
        'cmdExcluir06
        '
        Me.cmdExcluir06.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir06.Location = New System.Drawing.Point(949, 442)
        Me.cmdExcluir06.Name = "cmdExcluir06"
        Me.cmdExcluir06.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir06.TabIndex = 39
        Me.cmdExcluir06.Text = "<<"
        Me.cmdExcluir06.UseVisualStyleBackColor = True
        '
        'txtObservacao06
        '
        Me.txtObservacao06.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao06.Location = New System.Drawing.Point(669, 449)
        Me.txtObservacao06.Name = "txtObservacao06"
        Me.txtObservacao06.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao06.TabIndex = 38
        '
        'lblExameEscolhido06
        '
        Me.lblExameEscolhido06.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido06.Location = New System.Drawing.Point(419, 449)
        Me.lblExameEscolhido06.Name = "lblExameEscolhido06"
        Me.lblExameEscolhido06.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido06.TabIndex = 37
        Me.lblExameEscolhido06.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar06
        '
        Me.cmdSelecionar06.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar06.Location = New System.Drawing.Point(355, 441)
        Me.cmdSelecionar06.Name = "cmdSelecionar06"
        Me.cmdSelecionar06.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar06.TabIndex = 36
        Me.cmdSelecionar06.Text = ">>"
        Me.cmdSelecionar06.UseVisualStyleBackColor = True
        '
        'lblExame06
        '
        Me.lblExame06.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame06.Location = New System.Drawing.Point(16, 449)
        Me.lblExame06.Name = "lblExame06"
        Me.lblExame06.Size = New System.Drawing.Size(326, 13)
        Me.lblExame06.TabIndex = 35
        Me.lblExame06.Text = "lblExame01"
        '
        'cmdExcluir07
        '
        Me.cmdExcluir07.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir07.Location = New System.Drawing.Point(949, 476)
        Me.cmdExcluir07.Name = "cmdExcluir07"
        Me.cmdExcluir07.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir07.TabIndex = 44
        Me.cmdExcluir07.Text = "<<"
        Me.cmdExcluir07.UseVisualStyleBackColor = True
        '
        'txtObservacao07
        '
        Me.txtObservacao07.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao07.Location = New System.Drawing.Point(669, 483)
        Me.txtObservacao07.Name = "txtObservacao07"
        Me.txtObservacao07.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao07.TabIndex = 43
        '
        'lblExameEscolhido07
        '
        Me.lblExameEscolhido07.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido07.Location = New System.Drawing.Point(419, 483)
        Me.lblExameEscolhido07.Name = "lblExameEscolhido07"
        Me.lblExameEscolhido07.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido07.TabIndex = 42
        Me.lblExameEscolhido07.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar07
        '
        Me.cmdSelecionar07.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar07.Location = New System.Drawing.Point(355, 475)
        Me.cmdSelecionar07.Name = "cmdSelecionar07"
        Me.cmdSelecionar07.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar07.TabIndex = 41
        Me.cmdSelecionar07.Text = ">>"
        Me.cmdSelecionar07.UseVisualStyleBackColor = True
        '
        'lblExame07
        '
        Me.lblExame07.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame07.Location = New System.Drawing.Point(16, 483)
        Me.lblExame07.Name = "lblExame07"
        Me.lblExame07.Size = New System.Drawing.Size(326, 13)
        Me.lblExame07.TabIndex = 40
        Me.lblExame07.Text = "lblExame01"
        '
        'cmdExcluir08
        '
        Me.cmdExcluir08.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir08.Location = New System.Drawing.Point(949, 510)
        Me.cmdExcluir08.Name = "cmdExcluir08"
        Me.cmdExcluir08.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir08.TabIndex = 49
        Me.cmdExcluir08.Text = "<<"
        Me.cmdExcluir08.UseVisualStyleBackColor = True
        '
        'txtObservacao08
        '
        Me.txtObservacao08.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao08.Location = New System.Drawing.Point(669, 517)
        Me.txtObservacao08.Name = "txtObservacao08"
        Me.txtObservacao08.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao08.TabIndex = 48
        '
        'lblExameEscolhido08
        '
        Me.lblExameEscolhido08.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido08.Location = New System.Drawing.Point(419, 517)
        Me.lblExameEscolhido08.Name = "lblExameEscolhido08"
        Me.lblExameEscolhido08.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido08.TabIndex = 47
        Me.lblExameEscolhido08.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar08
        '
        Me.cmdSelecionar08.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar08.Location = New System.Drawing.Point(355, 509)
        Me.cmdSelecionar08.Name = "cmdSelecionar08"
        Me.cmdSelecionar08.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar08.TabIndex = 46
        Me.cmdSelecionar08.Text = ">>"
        Me.cmdSelecionar08.UseVisualStyleBackColor = True
        '
        'lblExame08
        '
        Me.lblExame08.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame08.Location = New System.Drawing.Point(16, 517)
        Me.lblExame08.Name = "lblExame08"
        Me.lblExame08.Size = New System.Drawing.Size(326, 13)
        Me.lblExame08.TabIndex = 45
        Me.lblExame08.Text = "lblExame01"
        '
        'cmdExcluir09
        '
        Me.cmdExcluir09.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir09.Location = New System.Drawing.Point(949, 544)
        Me.cmdExcluir09.Name = "cmdExcluir09"
        Me.cmdExcluir09.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir09.TabIndex = 54
        Me.cmdExcluir09.Text = "<<"
        Me.cmdExcluir09.UseVisualStyleBackColor = True
        '
        'txtObservacao09
        '
        Me.txtObservacao09.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao09.Location = New System.Drawing.Point(669, 551)
        Me.txtObservacao09.Name = "txtObservacao09"
        Me.txtObservacao09.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao09.TabIndex = 53
        '
        'lblExameEscolhido09
        '
        Me.lblExameEscolhido09.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido09.Location = New System.Drawing.Point(419, 551)
        Me.lblExameEscolhido09.Name = "lblExameEscolhido09"
        Me.lblExameEscolhido09.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido09.TabIndex = 52
        Me.lblExameEscolhido09.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar09
        '
        Me.cmdSelecionar09.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar09.Location = New System.Drawing.Point(355, 543)
        Me.cmdSelecionar09.Name = "cmdSelecionar09"
        Me.cmdSelecionar09.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar09.TabIndex = 51
        Me.cmdSelecionar09.Text = ">>"
        Me.cmdSelecionar09.UseVisualStyleBackColor = True
        '
        'lblExame09
        '
        Me.lblExame09.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame09.Location = New System.Drawing.Point(16, 551)
        Me.lblExame09.Name = "lblExame09"
        Me.lblExame09.Size = New System.Drawing.Size(326, 13)
        Me.lblExame09.TabIndex = 50
        Me.lblExame09.Text = "lblExame01"
        '
        'cmdExcluir10
        '
        Me.cmdExcluir10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdExcluir10.Location = New System.Drawing.Point(949, 578)
        Me.cmdExcluir10.Name = "cmdExcluir10"
        Me.cmdExcluir10.Size = New System.Drawing.Size(30, 27)
        Me.cmdExcluir10.TabIndex = 59
        Me.cmdExcluir10.Text = "<<"
        Me.cmdExcluir10.UseVisualStyleBackColor = True
        '
        'txtObservacao10
        '
        Me.txtObservacao10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacao10.Location = New System.Drawing.Point(669, 585)
        Me.txtObservacao10.Name = "txtObservacao10"
        Me.txtObservacao10.Size = New System.Drawing.Size(241, 13)
        Me.txtObservacao10.TabIndex = 58
        '
        'lblExameEscolhido10
        '
        Me.lblExameEscolhido10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExameEscolhido10.Location = New System.Drawing.Point(419, 585)
        Me.lblExameEscolhido10.Name = "lblExameEscolhido10"
        Me.lblExameEscolhido10.Size = New System.Drawing.Size(236, 13)
        Me.lblExameEscolhido10.TabIndex = 57
        Me.lblExameEscolhido10.Text = "lblExameEscolhido01"
        '
        'cmdSelecionar10
        '
        Me.cmdSelecionar10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSelecionar10.Location = New System.Drawing.Point(355, 577)
        Me.cmdSelecionar10.Name = "cmdSelecionar10"
        Me.cmdSelecionar10.Size = New System.Drawing.Size(30, 27)
        Me.cmdSelecionar10.TabIndex = 56
        Me.cmdSelecionar10.Text = ">>"
        Me.cmdSelecionar10.UseVisualStyleBackColor = True
        '
        'lblExame10
        '
        Me.lblExame10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExame10.Location = New System.Drawing.Point(16, 585)
        Me.lblExame10.Name = "lblExame10"
        Me.lblExame10.Size = New System.Drawing.Size(326, 13)
        Me.lblExame10.TabIndex = 55
        Me.lblExame10.Text = "lblExame01"
        '
        'vsbExame
        '
        Me.vsbExame.LargeChange = 1
        Me.vsbExame.Location = New System.Drawing.Point(389, 272)
        Me.vsbExame.Name = "vsbExame"
        Me.vsbExame.Size = New System.Drawing.Size(17, 336)
        Me.vsbExame.TabIndex = 105
        '
        'vsbExameEscolhido
        '
        Me.vsbExameEscolhido.Location = New System.Drawing.Point(982, 272)
        Me.vsbExameEscolhido.Name = "vsbExameEscolhido"
        Me.vsbExameEscolhido.Size = New System.Drawing.Size(17, 336)
        Me.vsbExameEscolhido.TabIndex = 106
        '
        'txtFiltroExame
        '
        Me.txtFiltroExame.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFiltroExame.Location = New System.Drawing.Point(30, 200)
        Me.txtFiltroExame.Name = "txtFiltroExame"
        Me.txtFiltroExame.Size = New System.Drawing.Size(300, 13)
        Me.txtFiltroExame.TabIndex = 107
        '
        'cboClassificacaoExame
        '
        Me.cboClassificacaoExame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClassificacaoExame.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClassificacaoExame.FormattingEnabled = True
        Me.cboClassificacaoExame.Location = New System.Drawing.Point(26, 141)
        Me.cboClassificacaoExame.Name = "cboClassificacaoExame"
        Me.cboClassificacaoExame.Size = New System.Drawing.Size(300, 33)
        Me.cboClassificacaoExame.TabIndex = 108
        '
        'optOutros
        '
        Me.optOutros.AutoSize = True
        Me.optOutros.Location = New System.Drawing.Point(374, 95)
        Me.optOutros.Name = "optOutros"
        Me.optOutros.Size = New System.Drawing.Size(14, 13)
        Me.optOutros.TabIndex = 109
        Me.optOutros.UseVisualStyleBackColor = True
        '
        'cmdVisualizar
        '
        Me.cmdVisualizar.AutoSize = True
        Me.cmdVisualizar.Location = New System.Drawing.Point(595, 95)
        Me.cmdVisualizar.Name = "cmdVisualizar"
        Me.cmdVisualizar.Size = New System.Drawing.Size(16, 17)
        Me.cmdVisualizar.TabIndex = 110
        '
        'cmdFechar
        '
        Me.cmdFechar.AutoSize = True
        Me.cmdFechar.Location = New System.Drawing.Point(595, 157)
        Me.cmdFechar.Name = "cmdFechar"
        Me.cmdFechar.Size = New System.Drawing.Size(16, 17)
        Me.cmdFechar.TabIndex = 9
        '
        'cmdImprimir
        '
        Me.cmdImprimir.AutoSize = True
        Me.cmdImprimir.Location = New System.Drawing.Point(455, 157)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(16, 17)
        Me.cmdImprimir.TabIndex = 8
        '
        'chkSelecionarImpressao01
        '
        Me.chkSelecionarImpressao01.AutoSize = True
        Me.chkSelecionarImpressao01.Location = New System.Drawing.Point(922, 278)
        Me.chkSelecionarImpressao01.Name = "chkSelecionarImpressao01"
        Me.chkSelecionarImpressao01.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao01.TabIndex = 111
        Me.chkSelecionarImpressao01.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao02
        '
        Me.chkSelecionarImpressao02.AutoSize = True
        Me.chkSelecionarImpressao02.Location = New System.Drawing.Point(922, 312)
        Me.chkSelecionarImpressao02.Name = "chkSelecionarImpressao02"
        Me.chkSelecionarImpressao02.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao02.TabIndex = 112
        Me.chkSelecionarImpressao02.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao04
        '
        Me.chkSelecionarImpressao04.AutoSize = True
        Me.chkSelecionarImpressao04.Location = New System.Drawing.Point(922, 380)
        Me.chkSelecionarImpressao04.Name = "chkSelecionarImpressao04"
        Me.chkSelecionarImpressao04.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao04.TabIndex = 114
        Me.chkSelecionarImpressao04.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao03
        '
        Me.chkSelecionarImpressao03.AutoSize = True
        Me.chkSelecionarImpressao03.Location = New System.Drawing.Point(922, 346)
        Me.chkSelecionarImpressao03.Name = "chkSelecionarImpressao03"
        Me.chkSelecionarImpressao03.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao03.TabIndex = 113
        Me.chkSelecionarImpressao03.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao08
        '
        Me.chkSelecionarImpressao08.AutoSize = True
        Me.chkSelecionarImpressao08.Location = New System.Drawing.Point(922, 516)
        Me.chkSelecionarImpressao08.Name = "chkSelecionarImpressao08"
        Me.chkSelecionarImpressao08.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao08.TabIndex = 118
        Me.chkSelecionarImpressao08.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao07
        '
        Me.chkSelecionarImpressao07.AutoSize = True
        Me.chkSelecionarImpressao07.Location = New System.Drawing.Point(922, 482)
        Me.chkSelecionarImpressao07.Name = "chkSelecionarImpressao07"
        Me.chkSelecionarImpressao07.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao07.TabIndex = 117
        Me.chkSelecionarImpressao07.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao06
        '
        Me.chkSelecionarImpressao06.AutoSize = True
        Me.chkSelecionarImpressao06.Location = New System.Drawing.Point(922, 448)
        Me.chkSelecionarImpressao06.Name = "chkSelecionarImpressao06"
        Me.chkSelecionarImpressao06.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao06.TabIndex = 116
        Me.chkSelecionarImpressao06.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao05
        '
        Me.chkSelecionarImpressao05.AutoSize = True
        Me.chkSelecionarImpressao05.Location = New System.Drawing.Point(922, 414)
        Me.chkSelecionarImpressao05.Name = "chkSelecionarImpressao05"
        Me.chkSelecionarImpressao05.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao05.TabIndex = 115
        Me.chkSelecionarImpressao05.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao10
        '
        Me.chkSelecionarImpressao10.AutoSize = True
        Me.chkSelecionarImpressao10.Location = New System.Drawing.Point(922, 584)
        Me.chkSelecionarImpressao10.Name = "chkSelecionarImpressao10"
        Me.chkSelecionarImpressao10.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao10.TabIndex = 120
        Me.chkSelecionarImpressao10.UseVisualStyleBackColor = True
        '
        'chkSelecionarImpressao09
        '
        Me.chkSelecionarImpressao09.AutoSize = True
        Me.chkSelecionarImpressao09.Location = New System.Drawing.Point(922, 550)
        Me.chkSelecionarImpressao09.Name = "chkSelecionarImpressao09"
        Me.chkSelecionarImpressao09.Size = New System.Drawing.Size(15, 14)
        Me.chkSelecionarImpressao09.TabIndex = 119
        Me.chkSelecionarImpressao09.UseVisualStyleBackColor = True
        '
        'cmdImprimirSelecionados
        '
        Me.cmdImprimirSelecionados.AutoSize = True
        Me.cmdImprimirSelecionados.Location = New System.Drawing.Point(455, 91)
        Me.cmdImprimirSelecionados.Name = "cmdImprimirSelecionados"
        Me.cmdImprimirSelecionados.Size = New System.Drawing.Size(16, 17)
        Me.cmdImprimirSelecionados.TabIndex = 127
        '
        'lblProntuario
        '
        Me.lblProntuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProntuario.Location = New System.Drawing.Point(451, 34)
        Me.lblProntuario.Name = "lblProntuario"
        Me.lblProntuario.Size = New System.Drawing.Size(113, 20)
        Me.lblProntuario.TabIndex = 171
        Me.lblProntuario.Text = "lblProntuario"
        Me.lblProntuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPessoa
        '
        Me.lblPessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPessoa.Location = New System.Drawing.Point(26, 34)
        Me.lblPessoa.Name = "lblPessoa"
        Me.lblPessoa.Size = New System.Drawing.Size(419, 20)
        Me.lblPessoa.TabIndex = 172
        Me.lblPessoa.Text = "lblPessoa"
        Me.lblPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCadastroAtendimentoSolicitacaoExame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 788)
        Me.Controls.Add(Me.lblPessoa)
        Me.Controls.Add(Me.lblProntuario)
        Me.Controls.Add(Me.cmdImprimirSelecionados)
        Me.Controls.Add(Me.chkSelecionarImpressao10)
        Me.Controls.Add(Me.chkSelecionarImpressao09)
        Me.Controls.Add(Me.chkSelecionarImpressao08)
        Me.Controls.Add(Me.chkSelecionarImpressao07)
        Me.Controls.Add(Me.chkSelecionarImpressao06)
        Me.Controls.Add(Me.chkSelecionarImpressao05)
        Me.Controls.Add(Me.chkSelecionarImpressao04)
        Me.Controls.Add(Me.chkSelecionarImpressao03)
        Me.Controls.Add(Me.chkSelecionarImpressao02)
        Me.Controls.Add(Me.chkSelecionarImpressao01)
        Me.Controls.Add(Me.cmdVisualizar)
        Me.Controls.Add(Me.optOutros)
        Me.Controls.Add(Me.cboClassificacaoExame)
        Me.Controls.Add(Me.txtFiltroExame)
        Me.Controls.Add(Me.vsbExameEscolhido)
        Me.Controls.Add(Me.vsbExame)
        Me.Controls.Add(Me.cmdExcluir10)
        Me.Controls.Add(Me.txtObservacao10)
        Me.Controls.Add(Me.lblExameEscolhido10)
        Me.Controls.Add(Me.cmdSelecionar10)
        Me.Controls.Add(Me.lblExame10)
        Me.Controls.Add(Me.cmdExcluir09)
        Me.Controls.Add(Me.txtObservacao09)
        Me.Controls.Add(Me.lblExameEscolhido09)
        Me.Controls.Add(Me.cmdSelecionar09)
        Me.Controls.Add(Me.lblExame09)
        Me.Controls.Add(Me.cmdExcluir08)
        Me.Controls.Add(Me.txtObservacao08)
        Me.Controls.Add(Me.lblExameEscolhido08)
        Me.Controls.Add(Me.cmdSelecionar08)
        Me.Controls.Add(Me.lblExame08)
        Me.Controls.Add(Me.cmdExcluir07)
        Me.Controls.Add(Me.txtObservacao07)
        Me.Controls.Add(Me.lblExameEscolhido07)
        Me.Controls.Add(Me.cmdSelecionar07)
        Me.Controls.Add(Me.lblExame07)
        Me.Controls.Add(Me.cmdExcluir06)
        Me.Controls.Add(Me.txtObservacao06)
        Me.Controls.Add(Me.lblExameEscolhido06)
        Me.Controls.Add(Me.cmdSelecionar06)
        Me.Controls.Add(Me.lblExame06)
        Me.Controls.Add(Me.cmdExcluir05)
        Me.Controls.Add(Me.txtObservacao05)
        Me.Controls.Add(Me.lblExameEscolhido05)
        Me.Controls.Add(Me.cmdSelecionar05)
        Me.Controls.Add(Me.lblExame05)
        Me.Controls.Add(Me.cmdExcluir04)
        Me.Controls.Add(Me.txtObservacao04)
        Me.Controls.Add(Me.lblExameEscolhido04)
        Me.Controls.Add(Me.cmdSelecionar04)
        Me.Controls.Add(Me.lblExame04)
        Me.Controls.Add(Me.cmdExcluir03)
        Me.Controls.Add(Me.txtObservacao03)
        Me.Controls.Add(Me.lblExameEscolhido03)
        Me.Controls.Add(Me.cmdSelecionar03)
        Me.Controls.Add(Me.lblExame03)
        Me.Controls.Add(Me.cmdExcluir02)
        Me.Controls.Add(Me.txtObservacao02)
        Me.Controls.Add(Me.lblExameEscolhido02)
        Me.Controls.Add(Me.cmdSelecionar02)
        Me.Controls.Add(Me.lblExame02)
        Me.Controls.Add(Me.cmdExcluir01)
        Me.Controls.Add(Me.txtObservacao01)
        Me.Controls.Add(Me.lblExameEscolhido01)
        Me.Controls.Add(Me.cmdSelecionar01)
        Me.Controls.Add(Me.lblExame01)
        Me.Controls.Add(Me.cmdFechar)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.optComplementares)
        Me.Controls.Add(Me.optLaboratorias)
        Me.Controls.Add(Me.optCitologico)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.picGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmCadastroAtendimentoSolicitacaoExame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Atendimento - Solicitação de Exame"
        CType(Me.picGeral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picGeral As PictureBox
    Friend WithEvents lblIdade As Label
    Friend WithEvents optCitologico As RadioButton
  Friend WithEvents optLaboratorias As RadioButton
  Friend WithEvents optComplementares As RadioButton
    Friend WithEvents cmdImprimir As uscBotao
    Friend WithEvents cmdFechar As uscBotao
    Friend WithEvents lblExame01 As Label
    Friend WithEvents cmdSelecionar01 As Button
    Friend WithEvents lblExameEscolhido01 As Label
    Friend WithEvents txtObservacao01 As TextBox
    Friend WithEvents cmdExcluir01 As Button
    Friend WithEvents cmdExcluir02 As Button
    Friend WithEvents txtObservacao02 As TextBox
    Friend WithEvents lblExameEscolhido02 As Label
    Friend WithEvents cmdSelecionar02 As Button
    Friend WithEvents lblExame02 As Label
    Friend WithEvents cmdExcluir03 As Button
    Friend WithEvents txtObservacao03 As TextBox
    Friend WithEvents lblExameEscolhido03 As Label
    Friend WithEvents cmdSelecionar03 As Button
    Friend WithEvents lblExame03 As Label
    Friend WithEvents cmdExcluir04 As Button
    Friend WithEvents txtObservacao04 As TextBox
    Friend WithEvents lblExameEscolhido04 As Label
    Friend WithEvents cmdSelecionar04 As Button
    Friend WithEvents lblExame04 As Label
    Friend WithEvents cmdExcluir05 As Button
    Friend WithEvents txtObservacao05 As TextBox
    Friend WithEvents lblExameEscolhido05 As Label
    Friend WithEvents cmdSelecionar05 As Button
    Friend WithEvents lblExame05 As Label
    Friend WithEvents cmdExcluir06 As Button
    Friend WithEvents txtObservacao06 As TextBox
    Friend WithEvents lblExameEscolhido06 As Label
    Friend WithEvents cmdSelecionar06 As Button
    Friend WithEvents lblExame06 As Label
    Friend WithEvents cmdExcluir07 As Button
    Friend WithEvents txtObservacao07 As TextBox
    Friend WithEvents lblExameEscolhido07 As Label
    Friend WithEvents cmdSelecionar07 As Button
    Friend WithEvents lblExame07 As Label
    Friend WithEvents cmdExcluir08 As Button
    Friend WithEvents txtObservacao08 As TextBox
    Friend WithEvents lblExameEscolhido08 As Label
    Friend WithEvents cmdSelecionar08 As Button
    Friend WithEvents lblExame08 As Label
    Friend WithEvents cmdExcluir09 As Button
    Friend WithEvents txtObservacao09 As TextBox
    Friend WithEvents lblExameEscolhido09 As Label
    Friend WithEvents cmdSelecionar09 As Button
    Friend WithEvents lblExame09 As Label
    Friend WithEvents cmdExcluir10 As Button
    Friend WithEvents txtObservacao10 As TextBox
    Friend WithEvents lblExameEscolhido10 As Label
    Friend WithEvents cmdSelecionar10 As Button
    Friend WithEvents lblExame10 As Label
    Friend WithEvents vsbExame As VScrollBar
    Friend WithEvents vsbExameEscolhido As VScrollBar
    Friend WithEvents txtFiltroExame As TextBox
    Friend WithEvents cboClassificacaoExame As ComboBox
    Friend WithEvents optOutros As RadioButton
    Friend WithEvents cmdVisualizar As uscBotao
    Friend WithEvents chkSelecionarImpressao01 As CheckBox
    Friend WithEvents chkSelecionarImpressao02 As CheckBox
    Friend WithEvents chkSelecionarImpressao04 As CheckBox
    Friend WithEvents chkSelecionarImpressao03 As CheckBox
    Friend WithEvents chkSelecionarImpressao08 As CheckBox
    Friend WithEvents chkSelecionarImpressao07 As CheckBox
    Friend WithEvents chkSelecionarImpressao06 As CheckBox
    Friend WithEvents chkSelecionarImpressao05 As CheckBox
    Friend WithEvents chkSelecionarImpressao10 As CheckBox
    Friend WithEvents chkSelecionarImpressao09 As CheckBox
    Friend WithEvents cmdImprimirSelecionados As uscBotao
    Friend WithEvents lblProntuario As Label
    Friend WithEvents lblPessoa As Label
End Class
