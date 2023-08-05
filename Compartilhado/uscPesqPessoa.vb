Public Class uscPesqPessoa
  Public Enum enTipoCadastro
    CadastroSimples = 1
    CadastroPessoa = 2
    CadastroPaciente = 3
  End Enum

  Enum enTipoFiltroPessoa
    Cliente = 1
    Fabricante = 2
    Fornecedor = 3
    Funcionario = 4
    Profissional = 5
    Transportadora = 6
    Vendedor = 7
    Pessoa = 8
    Pessoa_Fisica = 9
    Pessoa_Juridica = 10
    Paciente = 11
    Pessoal_Geral = 12
    Pessoa_Juridica_E_Empresa = 13
  End Enum

  Public Event Adicionado()
  Public Event Adicionando()
  Public Event SelectedIndexChanged()

  Public TipoCadastro As enTipoCadastro = enTipoCadastro.CadastroSimples
  Public bSomenteNome As Boolean = False

  Dim bCarregarTodos As Boolean

  Public NO_PESSOA As String
  Public sCD_TELEFONE As String
  Public sCD_CELULAR As String
  Public dDT_NASC_ABERTURA As Date

  Dim oTipoFiltro As enTipoFiltroPessoa = enTipoFiltroPessoa.Pessoa

  Public Property TipoFiltro As enTipoFiltroPessoa
    Get
      Return oTipoFiltro
    End Get
    Set(value As enTipoFiltroPessoa)
      If value <> 0 Then
        oTipoFiltro = value

        If FNC_NVL(lblRotuloPessoa.Tag, "") = "" Then
          Select Case oTipoFiltro
            Case enTipoFiltroPessoa.Cliente
              lblRotuloPessoa.Text = "Cliente"
            Case enTipoFiltroPessoa.Fabricante
              lblRotuloPessoa.Text = "Fabricante"
            Case enTipoFiltroPessoa.Fornecedor
              lblRotuloPessoa.Text = "Fornecedor"
            Case enTipoFiltroPessoa.Funcionario
              lblRotuloPessoa.Text = "Funcionário"
            Case enTipoFiltroPessoa.Profissional
              lblRotuloPessoa.Text = "Profissional"
            Case enTipoFiltroPessoa.Transportadora
              lblRotuloPessoa.Text = "Transportadora"
            Case enTipoFiltroPessoa.Vendedor
              lblRotuloPessoa.Text = "Vendedor"
            Case enTipoFiltroPessoa.Pessoa,
                 enTipoFiltroPessoa.Pessoa_Fisica,
                 enTipoFiltroPessoa.Pessoa_Juridica,
                 enTipoFiltroPessoa.Pessoa_Juridica_E_Empresa,
                 enTipoFiltroPessoa.Pessoal_Geral
              lblRotuloPessoa.Text = "Pessoa"
            Case enTipoFiltroPessoa.Paciente
              lblRotuloPessoa.Text = "Paciente"
          End Select
        End If
      End If
    End Set
  End Property

  Public Property CarregarTodos As Boolean
    Get
      Return bCarregarTodos
    End Get
    Set(value As Boolean)
      If value Then ComboBox_CarregarPessoa(cboPessoa, oTipoFiltro, , , , True, True, True, bSomenteNome)
      bCarregarTodos = value
    End Set
  End Property

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    FormPesquisaPessoa_ExibirTela(cboPessoa, oTipoFiltro, bCarregarTodos)
  End Sub

  Private Sub cboPessoa_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPessoa.KeyDown
    If Not bCarregarTodos Then FormPesquisaPessoa_TratarCombo(Me.ParentForm, cboPessoa, e, oTipoFiltro, , , bSomenteNome)
  End Sub

  Private Sub cmdAdicionar_Click(sender As Object, e As EventArgs) Handles cmdAdicionar.Click
    Dim iID_PESSOA As Integer = 0

    RaiseEvent Adicionando()

    If FormPesquisaPessoa_Cadastro(iID_PESSOA, False, 0, ,, NO_PESSOA, sCD_TELEFONE, sCD_CELULAR, TipoCadastro) Then
      If bCarregarTodos Then
        cboPessoa.Text = ""
        ComboBox_CarregarPessoa(cboPessoa, oTipoFiltro, , , , True, True,, bSomenteNome)
        ComboBox_Selecionar(cboPessoa, iID_PESSOA)
      Else
        FormPesquisaPessoa_TratarCombo(Me.ParentForm, cboPessoa, Nothing, oTipoFiltro, iID_PESSOA,, bSomenteNome)
      End If

      RaiseEvent Adicionado()
    End If
  End Sub

  Private Sub cboPessoa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPessoa.SelectedIndexChanged
    Dim sSqlText As String
    Dim oData As DataTable

    If ComboBox_Selecionado(cboPessoa) Then
      'Carregar Dados Paciente
      sSqlText = "SELECT PE.DS_PACIENTE_PENDENCIAS, PS.DT_NASC_ABERTURA" &
                 " FROM TB_PESSOA_EMPRESA PE" &
                  " INNER JOIN TB_PESSOA PS ON PS.SQ_PESSOA = PE.ID_PESSOA" &
                 " WHERE PE.ID_PESSOA = " & cboPessoa.SelectedValue
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        If Not FNC_CampoNulo(oData.Rows(0).Item("DS_PACIENTE_PENDENCIAS")) Then
          FNC_Aviso(Me.ParentForm, oData.Rows(0).Item("DS_PACIENTE_PENDENCIAS"))
        End If
        If Not FNC_CampoNulo(oData.Rows(0).Item("DT_NASC_ABERTURA")) Then
          dDT_NASC_ABERTURA = oData.Rows(0).Item("DT_NASC_ABERTURA")
        End If

      End If
    End If

    RaiseEvent SelectedIndexChanged()
  End Sub

  Public ReadOnly Property Selecionado As Boolean
    Get
      Return ComboBox_Selecionado(cboPessoa)
    End Get
  End Property

  Public ReadOnly Property ComboBox As ComboBox
    Get
      Return cboPessoa
    End Get
  End Property

  Public Property ID_Pessoa As Integer
    Get
      Return FNC_NVL(cboPessoa.SelectedValue, 0)
    End Get
    Set(value As Integer)
      If value = 0 Then
        If bCarregarTodos Then
          cboPessoa.SelectedIndex = -1
        Else
          cboPessoa.DataSource = Nothing
        End If
      Else
        If bCarregarTodos Then
          ComboBox_Selecionar(cboPessoa, value)
        Else
          FormPesquisaPessoa_TratarCombo(Me.ParentForm, cboPessoa, Nothing, oTipoFiltro, value,, bSomenteNome)
        End If
      End If
    End Set
  End Property

  Public Property DS_Pessoa As String
    Set(value As String)
      cboPessoa.Text = value
    End Set
    Get
      If Trim(cboPessoa.Text) = "0" Then
        Return ""
      Else
        Return cboPessoa.Text
      End If
    End Get
  End Property

  Public Property AdicionarPessoa As Boolean
    Get
      Return cmdAdicionar.Visible
    End Get
    Set(value As Boolean)
      cmdAdicionar.Visible = value
      AjustarTela()
    End Set
  End Property

  Public Property PesquisarPessoa As Boolean
    Get
      Return cmdPesquisar.Visible
    End Get
    Set(value As Boolean)
      cmdPesquisar.Visible = value
      AjustarTela()
    End Set
  End Property

  Private Sub AjustarTela()
    If cmdAdicionar.Visible Then
      cmdPesquisar.Left = 24
      cboPessoa.Left = cmdPesquisar.Left + cmdPesquisar.Width + 1
    Else
      cmdPesquisar.Left = 1

      If Not cmdPesquisar.Visible Then
        cboPessoa.Left = 1
      Else
        cboPessoa.Left = cmdPesquisar.Left + cmdPesquisar.Width + 1
      End If
    End If

    cboPessoa.Width = Me.Width - cboPessoa.Left

    Me.Height = cboPessoa.Top + cboPessoa.Height
  End Sub

  Private Sub FormatarTela()
    AjustarTela()

    If bCarregarTodos Then
      ComboBox_CarregarPessoa(cboPessoa, oTipoFiltro, , , , True, True,, bSomenteNome)
    End If
  End Sub

  Public Property Rotulo As String
    Get
      Return lblRotuloPessoa.Tag
    End Get
    Set(value As String)
      lblRotuloPessoa.Tag = value
      lblRotuloPessoa.Text = value
    End Set
  End Property

  Private Sub uscPesqPessoa_Load(sender As Object, e As EventArgs) Handles Me.Load
    FormatarTela()
  End Sub

  Private Sub uscPesqPessoa_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    FormatarTela()
  End Sub

  Public Sub New()
    InitializeComponent()

    cmdAdicionar.Visible = False
    Rotulo = "Pessoa"
  End Sub

  Public Property LabelVisivel As Boolean
    Get
      Return lblRotuloPessoa.Visible
    End Get
    Set(value As Boolean)
      lblRotuloPessoa.Visible = value

      Select Case value
        Case True
          cmdAdicionar.Top = 15
          cmdPesquisar.Top = 15
          cboPessoa.Top = 15
        Case False
          cmdAdicionar.Top = 1
          cmdPesquisar.Top = 1
          cboPessoa.Top = 1
      End Select

      Me.Height = cboPessoa.Top + cboPessoa.Height
    End Set
  End Property

  Public Property Bordas As Boolean
    Get
      Return cboPessoa.FlatStyle = FlatStyle.Standard
    End Get
    Set(value As Boolean)
      If value Then
        cboPessoa.FlatStyle = FlatStyle.Standard
      Else
        cboPessoa.FlatStyle = FlatStyle.Flat
      End If
    End Set
  End Property

  Public Property SomenteLeitura As Boolean
    Get
      Return cboPessoa.DropDownStyle = ComboBoxStyle.DropDownList
    End Get
    Set(value As Boolean)
      If value Then
        cboPessoa.DropDownStyle = ComboBoxStyle.DropDownList
      Else
        cboPessoa.DropDownStyle = ComboBoxStyle.DropDown
      End If
    End Set
  End Property
End Class
