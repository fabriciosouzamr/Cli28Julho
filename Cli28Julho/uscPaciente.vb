Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class uscPaciente
  Public Event DadosCarregado()
  Public Event GravacaoEfetuada()
  Public Event GerarConsulta()
  Public Event GridHistoricoConsultas_DoubleClickRow(iID_CONVENIO_PACIENTE As Integer, iID_ATENDIMENTO As Integer)
  Public Event Fechar()
  Public Event Novo()

  Public sNO_PESSOA As String
  Public sCD_TELEFONE As String
  Public sCD_CELULAR As String

  Const const_GridEndereco_SQ_ENDERECO As Integer = 0
  Const const_GridEndereco_TipoEndereco As Integer = 1
  Const const_GridEndereco_Cep As Integer = 2
  Const const_GridEndereco_BuscaCep As Integer = 3
  Const const_GridEndereco_Logradouro As Integer = 4
  Const const_GridEndereco_Numero As Integer = 5
  Const const_GridEndereco_Bairro As Integer = 6
  Const const_GridEndereco_Cidade As Integer = 7
  Const const_GridEndereco_Complemento As Integer = 8
  Const const_GridEndereco_Ativo As Integer = 9

  Dim oDBEndereco As New UltraWinDataSource.UltraDataSource

  Dim oEndereco_Exclusao As New Collection
  Dim bEmProcessamento As Boolean

  Dim bComboPaciente As Boolean  Dim iID_PESSOA As Integer  Dim iSQ_PESSOA_MIDIASOCIAL_EMAIL As Integer
  Dim iSQ_PESSOA_MIDIASOCIAL_WEBSITE As Integer
  Dim iSQ_PESSOA_TELEFONE(2) As Integer
  Dim iSQ_PESSOA_PROFISSAO As Integer
  Dim iID_CONVENIO_PACIENTE As Integer

  Dim oHistorico As New clsHistorico

  Dim Historico_Acao As enOpcoes = enOpcoes.Processo_Acao_Inclusao

  Public Sub New()
    InitializeComponent()
  End Sub

  Public Sub Formatar()
    bEmProcessamento = True

    txtDtCadastro.Value = Now
    TextBox_FormatarCampoTexto(txtTelefoneComentario01)
    TextBox_FormatarCampoTexto(txtTelefoneComentario02)
    TextBox_FormatarCampoTexto(txtTelefoneComentario03)

    '>> Carregar Combos
    'Cadastro de Paciente
    ComboBox_Carregar(cboEscolaridade, enSql.Escolaridade)
    ComboBox_Carregar(cboEstadoCivil, enSql.EstadoCivil)
    ComboBox_Carregar(cboNacionalidade, enSql.Nacionalidade)
    ComboBox_Carregar(cboNaturalidade, enSql.Cidade)
    ComboBox_Carregar(cboRaca, enSql.Raca)
    ComboBox_Carregar(cboReligiao, enSql.Religiao)
    ComboBox_Carregar(cboSexo, enSql.Sexo)
    ComboBox_Carregar(cboSituacaoProfissional, enSql.SituacaoProfissional)
    ComboBox_Carregar(cboTipoPaciente, enSql.TipoPaciente)
    ComboBox_Carregar(cboPaciente_Ativo, enSql.AtivoInativo_Pessoal)
    ComboBox_Carregar(cboProfissao, enSql.Profissao)
    ComboBox_Carregar(cboTipoTelefone01, enSql.TipoTelefone)
    ComboBox_Carregar(cboTipoTelefone02, enSql.TipoTelefone)
    ComboBox_Carregar(cboTipoTelefone03, enSql.TipoTelefone)
    ComboBox_Carregar(cboConvenioPaciente, enSql.Convenio_Ativo)

    If bComboPaciente Then
      oPaciente.Visible = True
      txtNomePaciente.Visible = False
      'ComboBox_CarregarPessoa(cboPaciente, enTipoFiltroPessoa.Pessoa_Fisica, , , 0, False)
      oPaciente.Left = txtNomePaciente.Left
      oPaciente.Top = txtNomePaciente.Top
      oPaciente.Width = txtNomePaciente.Width
    Else
      txtNomePaciente.Visible = True
      oPaciente.Visible = False
    End If

    '>> Formatação de Grids
    'Endereço
    objGrid_Inicializar(grdEndereco, AllowAddNew.FixedAddRowOnTop, oDBEndereco, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdEndereco, "SQ_ENDERECO", 0)
    objGrid_Coluna_Add(grdEndereco, "Tipo de Endereço", 200, , True, , FNC_CarregarLista(enTipoCadastro.TipoEndereco))
    objGrid_Coluna_Add(grdEndereco, "C.E.P.", 80, , True)
    objGrid_Coluna_Add(grdEndereco, "...", 30, , True, ColumnStyle.Button)
    objGrid_Coluna_Add(grdEndereco, "Logradouro", 300, , True)
    objGrid_Coluna_Add(grdEndereco, "Número", 100, , True)
    objGrid_Coluna_Add(grdEndereco, "Bairro", 200, , True)
    objGrid_Coluna_Add(grdEndereco, "Cidade", 200, , True, , FNC_CarregarLista(enTipoCadastro.Cidade))
    objGrid_Coluna_Add(grdEndereco, "Complemento", 200, , True)
    objGrid_Coluna_Add(grdEndereco, "Ativo", 80, , True, ColumnStyle.CheckBox)
    objGrid_Configuracao_Carregar(grdEndereco, "grdEndereco")

    oPaciente_Historico.Inicializar()

    pnlHistorico.Visible = False
    pnlHistorico.Left = 10
    pnlHistorico.Top = 10

    FormPesquisaPessoa_TelefoneWhatsApp_Limpar(txtTelefone01, txtTelefone02, txtTelefone03)
    llbTelefoneWhatsApp01.Visible = False
    llbTelefoneWhatsApp02.Visible = False
    llbTelefoneWhatsApp03.Visible = False

    If cmdFechar.Visible Then
      cmdGravar.Left = 1023
      cmdFechar.Left = 1104
    Else
      cmdGravar.Left = 1104
    End If

    bEmProcessamento = False

    NovoCadastro()

    oPaciente.NO_PESSOA = sNO_PESSOA
    txtNomePaciente.Text = sNO_PESSOA
    If FNC_NVL(sCD_TELEFONE, "").Trim() <> "" Then
      ComboBox_Selecionar(cboTipoTelefone01, enTipoTelefone.Residencial.GetHashCode())
      txtTelefone01.Text = sCD_TELEFONE
    End If
    If FNC_NVL(sCD_CELULAR, "").Trim() <> "" Then
      ComboBox_Selecionar(cboTipoTelefone02, enTipoTelefone.Celular.GetHashCode())
      txtTelefone02.Text = sCD_CELULAR
    End If
  End Sub

  Public Property ExibirHistorico As Boolean
    Get
      Return cmdHistorico.Visible
    End Get
    Set(value As Boolean)
      cmdHistorico.Visible = value
    End Set
  End Property

  Public Property ComboPaciente As Boolean
    Get
      Return bComboPaciente
    End Get
    Set(value As Boolean)
      bComboPaciente = value
    End Set
  End Property

  Public ReadOnly Property Data_NascimentoAbertura As String
    Get
      Return txtDtNascAbertura.Text
    End Get
  End Property

  Public Property BotaoGerarConsultas As Boolean
    Get
      Return cmdGerarConsultas.Visible
    End Get
    Set(value As Boolean)
      cmdGerarConsultas.Visible = value
      cmdGerarConsultas.Visible = False
    End Set
  End Property

  Public Property BotaoFechar As Boolean
    Get
      Return cmdFechar.Visible
    End Get
    Set(value As Boolean)
      cmdFechar.Visible = value
    End Set
  End Property

  Public Property BotaoNovo As Boolean
    Get
      Return cmdNovo.Enabled
    End Get
    Set(value As Boolean)
      cmdNovo.Enabled = value
    End Set
  End Property

  Public Property Ativo As Integer
    Get
      Return FNC_NVL(cboPaciente_Ativo.SelectedValue, 1)
    End Get
    Set(value As Integer)
      ComboBox_Selecionar(cboPaciente_Ativo, value)
    End Set
  End Property

  Public Property Identificador As Integer
    Get
      Return iID_PESSOA
    End Get
    Set(value As Integer)
      iID_PESSOA = value
    End Set
  End Property

  Public Property NomePaciente As String
    Get
      Return txtNomePaciente.Text
    End Get
    Set(value As String)
      txtNomePaciente.Text = value
    End Set
  End Property

  Public ReadOnly Property Sexo As Integer
    Get
      Return FNC_NVL(cboSexo.SelectedValue, 0)
    End Get
  End Property

  Public Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    NovoCadastro(False)

    Historico_Acao = enOpcoes.Processo_Acao_Alteracao

    bEmProcessamento = True

    sSqlText = "SELECT NO_PESSOA," &
                      "NO_MAE," &
                      "DT_NASC_ABERTURA," &
                      "DT_CADASTRO," &
                      "dbo.FC_FormatarCPF_CNPJ(CD_CPF_CNPJ) CD_CPF_CNPJ," &
                      "ID_TIPO_PESSOA," &
                      "ID_OPT_ATIVO," &
                      "ID_PF_TIPO_ESTADOCIVIL," &
                      "ID_PF_NACIONALIDADE," &
                      "ID_PF_NATURALIDADE," &
                      "ID_PF_TIPO_ESCOLARIDADE," &
                      "ID_PF_TIPO_RACA," &
                      "ID_PF_TIPO_RELIGIAO," &
                      "ID_PF_TIPO_SEXO," &
                      "ID_OPT_SITUACAOPROFISSIONAL," &
                      "CD_PF_RG," &
                      "NO_FANTASIA_REDUZIDO," &
                      "CD_PJ_IE," &
                      "CD_PJ_IM," &
                      "CD_PF_CARTAO_SEGURIDADE," &
                      "DS_PATH_IMAGEM" &
               " FROM TB_PESSOA" &
               " WHERE SQ_PESSOA = " & iID_PESSOA
    oData = DBQuery(sSqlText)

    If oData.Rows.Count > 0 Then
      With oData.Rows(0)
        'Dados Gerais
        oPaciente.ID_Pessoa = iID_PESSOA
        txtNomePaciente.Text = .Item("NO_PESSOA")
        txtNomeMae.Text = FNC_NVL(.Item("NO_MAE"), "")
        UltraDateTime_CarregarData(txtDtNascAbertura, FNC_DBDataToString(.Item("DT_NASC_ABERTURA")))
        UltraDateTime_CarregarData(txtDtCadastro, FNC_DBDataToString(.Item("DT_CADASTRO")))
        txtCPF.Text = .Item("CD_CPF_CNPJ")
        ComboBox_Selecionar(cboEstadoCivil, .Item("ID_PF_TIPO_ESTADOCIVIL"))
        ComboBox_Selecionar(cboNacionalidade, .Item("ID_PF_NACIONALIDADE"))
        ComboBox_Selecionar(cboNaturalidade, .Item("ID_PF_NATURALIDADE"))
        ComboBox_Selecionar(cboEscolaridade, .Item("ID_PF_TIPO_ESCOLARIDADE"))
        ComboBox_Selecionar(cboRaca, .Item("ID_PF_TIPO_RACA"))
        ComboBox_Selecionar(cboReligiao, .Item("ID_PF_TIPO_RELIGIAO"))
        ComboBox_Selecionar(cboSexo, .Item("ID_PF_TIPO_SEXO"))
        ComboBox_Selecionar(cboSituacaoProfissional, .Item("ID_OPT_SITUACAOPROFISSIONAL"))
        txtRG.Text = FNC_NVL(.Item("CD_PF_RG"), "")
        txtNomeReduzido.Text = FNC_NVL(.Item("NO_FANTASIA_REDUZIDO"), "")
        txtCartaoSistemaNacionalSaude.Text = FNC_NVL(.Item("CD_PF_CARTAO_SEGURIDADE"), "")
        ComboBox_Selecionar(cboPaciente_Ativo, .Item("ID_OPT_ATIVO"))
        picFotoPaciente.Arquivo = .Item("DS_PATH_IMAGEM")

        'Carregar os dados do cliente
        sSqlText = "SELECT * FROM TB_PESSOA_EMPRESA" &
                   " WHERE ID_PESSOA = " & iID_PESSOA
        oData = DBQuery(sSqlText)

        If oData.Rows.Count > 0 Then
          chkLimiteCreditoBloqueado.Checked = (FNC_NVL(oData.Rows(0).Item("IC_CLIENTE_LIMITECREDITO_BLOQUEADO"), "N") = "S")
          chkCliente_BloquearVenda.Checked = (FNC_NVL(oData.Rows(0).Item("IC_CLIENTE_BLOQUEAR_VENDA"), "N") = "S")

          ComboBox_Selecionar(cboTipoPaciente, oData.Rows(0).Item("ID_PACIENTE_TIPO_PACIENTE"))
          txtComentario.Text = FNC_NVL(oData.Rows(0).Item("DS_PACIENTE_COMENTARIO"), "")
          txtPendencias.Text = FNC_NVL(oData.Rows(0).Item("DS_PACIENTE_PENDENCIAS"), "")
          oIndicacao.INDICACAO = FNC_NVL(oData.Rows(0).Item("ID_INDICACAO"), 0)
        End If

        'Grid de Profissão
        sSqlText = "SELECT PP.SQ_PESSOA_PROFISSAO," &
                          "PP.ID_PROFISSAO, " &
                          "PP.DT_INICIO_ATUACAO" &
                   " FROM TB_PESSOA_PROFISSAO PP" &
                    " INNER JOIN TB_PROFISSAO PF ON PF.SQ_PROFISSAO = PP.ID_PROFISSAO" &
                   " WHERE PP.ID_PESSOA = " & iID_PESSOA &
                   " ORDER BY PP.SQ_PESSOA_PROFISSAO"
        oData = DBQuery(sSqlText)

        If Not objDataTable_Vazio(oData) Then
          iSQ_PESSOA_PROFISSAO = FNC_NVL(oData.Rows(0).Item("SQ_PESSOA_PROFISSAO"), 0)
          ComboBox_Selecionar(cboProfissao, FNC_NVL(oData.Rows(0).Item("ID_PROFISSAO"), 0))
        End If
        'Mídia Social
        sSqlText = "SELECT * FROM VW_PESSOA_MIDIASOCIAL_EMAIL WHERE ID_PESSOA = " & iID_PESSOA
        oData = DBQuery(sSqlText)
        If Not objDataTable_Vazio(oData) Then
          iSQ_PESSOA_MIDIASOCIAL_EMAIL = oData.Rows(0).Item("SQ_PESSOA_MIDIASOCIAL")
          txtMidiaSocial_EMail.Text = oData.Rows(0).Item("DS_MIDIASOCIAL")
        End If
        sSqlText = "SELECT * FROM VW_PESSOA_MIDIASOCIAL_WEBSITE WHERE ID_PESSOA = " & iID_PESSOA
        oData = DBQuery(sSqlText)
        If Not objDataTable_Vazio(oData) Then
          iSQ_PESSOA_MIDIASOCIAL_EMAIL = oData.Rows(0).Item("SQ_PESSOA_MIDIASOCIAL")
        End If

        'Endereço
        sSqlText = "SELECT ED.SQ_ENDERECO," &
                          "ED.ID_TIPO_ENDERECO," &
                          "ED.DS_LOGRADOURO," &
                          "ED.NO_BAIRRO," &
                          "ED.NR_LOGRADOURO," &
                          "ED.ID_CIDADE," &
                          "[dbo].[FC_FormatarCEP](ED.CD_CEP) CD_CEP," &
                          "ED.DS_COMPLEMENTO," &
                          "IIF(ED.IC_ATIVO='S', 1, 0)" &
                   " FROM TB_ENDERECO ED" &
                   " WHERE ED.ID_PESSOA = " & iID_PESSOA &
                   " ORDER BY ED.ID_CIDADE, ED.NO_BAIRRO, ED.DS_LOGRADOURO"
        objGrid_Carregar(grdEndereco, sSqlText, New Integer() {const_GridEndereco_SQ_ENDERECO,
                                                               const_GridEndereco_TipoEndereco,
                                                               const_GridEndereco_Logradouro,
                                                               const_GridEndereco_Bairro,
                                                               const_GridEndereco_Numero,
                                                               const_GridEndereco_Cidade,
                                                               const_GridEndereco_CEP,
                                                               const_GridEndereco_Complemento,
                                                               const_GridEndereco_Ativo}, True)

        'Telefone
        FormPesquisaPessoa_TelefoneWhatsApp_Limpar(txtTelefone01, txtTelefone02, txtTelefone03)
        iSQ_PESSOA_TELEFONE(0) = 0
        iSQ_PESSOA_TELEFONE(1) = 0
        iSQ_PESSOA_TELEFONE(2) = 0

        sSqlText = "SELECT PT.SQ_PESSOA_TELEFONE," &
                          "PT.ID_TIPO_TELEFONE," &
                          "PT.CD_NUMERO," &
                          "PT.IC_WHATSAPP," &
                          "PT.CM_OBSERVACAO" &
                   " FROM TB_PESSOA_TELEFONE PT" &
                   " WHERE PT.ID_PESSOA = " & iID_PESSOA &
                   " ORDER BY PT.SQ_PESSOA_TELEFONE"
        oData = DBQuery(sSqlText)

        For iCont = 0 To oData.Rows.Count - 1
          If iCont < 3 Then
            iSQ_PESSOA_TELEFONE(iCont) = oData.Rows(iCont).Item("SQ_PESSOA_TELEFONE")

            Select Case iCont
              Case 0
                ComboBox_Selecionar(cboTipoTelefone01, oData.Rows(iCont).Item("ID_TIPO_TELEFONE"))
                txtTelefone01.Text = FNC_NVL(oData.Rows(iCont).Item("CD_NUMERO"), "")
                If FNC_NVL(oData.Rows(iCont).Item("IC_WHATSAPP"), "N") = "S" Then cmdTelefoneWhatsApp01.PerformClick()
                txtTelefoneComentario01.Text = FNC_NVL(oData.Rows(iCont).Item("CM_OBSERVACAO"), "")
              Case 1
                ComboBox_Selecionar(cboTipoTelefone02, oData.Rows(iCont).Item("ID_TIPO_TELEFONE"))
                txtTelefone02.Text = FNC_NVL(oData.Rows(iCont).Item("CD_NUMERO"), "")
                If FNC_NVL(oData.Rows(iCont).Item("IC_WHATSAPP"), "N") = "S" Then cmdTelefoneWhatsApp02.PerformClick()
                txtTelefoneComentario02.Text = FNC_NVL(oData.Rows(iCont).Item("CM_OBSERVACAO"), "")
              Case 2
                ComboBox_Selecionar(cboTipoTelefone03, oData.Rows(iCont).Item("ID_TIPO_TELEFONE"))
                txtTelefone03.Text = FNC_NVL(oData.Rows(iCont).Item("CD_NUMERO"), "")
                If FNC_NVL(oData.Rows(iCont).Item("IC_WHATSAPP"), "N") = "S" Then cmdTelefoneWhatsApp03.PerformClick()
                txtTelefoneComentario03.Text = FNC_NVL(oData.Rows(iCont).Item("CM_OBSERVACAO"), "")
            End Select
          Else
            Exit For
          End If
        Next

        'Convênio
        sSqlText = "SELECT CC.ID_CONVENIO," &
                          "CC.CD_IDENTIFICACAO," &
                          "CC.DT_VALIDADE" &
                   " FROM TB_PESSOA_CONVENIO CC" &
                   " WHERE CC.ID_PESSOA = " & iID_PESSOA &
                     " AND CC.ID_EMPRESA = " & iID_EMPRESA_MATRIZ
        oData = DBQuery(sSqlText)

        If Not objDataTable_Vazio(oData) Then
          ComboBox_Selecionar(cboConvenioPaciente, oData.Rows(0).Item("ID_CONVENIO"))
          iID_CONVENIO_PACIENTE = FNC_NuloSe(cboConvenioPaciente.SelectedValue, 0)
          txtIdentificacaoConvenioPaciente.Text = FNC_NVL(oData.Rows(0).Item("CD_IDENTIFICACAO"), "")
          If objDataTable_CampoVazio(oData.Rows(0).Item("DT_VALIDADE")) Then
            txtDtValidadeConvenio.Value = Nothing
          Else
            txtDtValidadeConvenio.Text = oData.Rows(0).Item("DT_VALIDADE")
          End If
        Else
          cboConvenioPaciente.SelectedIndex = -1
          txtIdentificacaoConvenioPaciente.Text = ""
          txtDtValidadeConvenio.Value = Nothing
        End If
      End With

      FNC_Historico_Guardar()

      Try
        RaiseEvent DadosCarregado()
      Catch ex As Exception
      End Try
    End If

    bEmProcessamento = False
  End Sub

  Private Sub CarregarHistorico()
    If cmdHistorico.Visible Then
      oPaciente_Historico.Carregar(iID_PESSOA)
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String
    Dim iCont As Integer

    If Trim(txtNomePaciente.Text) = "" Then
      FNC_Mensagem("É preciso informar o nome da pessoa")
      Exit Sub
    End If
    If Trim(FNC_SoNumero(txtCPF.Text)) = "" Then
      FNC_Mensagem("É preciso informar o número de C.P.F.")
      Exit Sub
    End If
    If Not IsDate(txtDtNascAbertura.Value) Then
      FNC_Mensagem("É preciso informar a data de nascimento")
      Exit Sub
    End If
    If Not FormCadastro_Telefone_Tratar(cboTipoTelefone01, txtTelefone01, txtTelefoneComentario01) Then Exit Sub
    If Not FormCadastro_Telefone_Tratar(cboTipoTelefone02, txtTelefone02, txtTelefoneComentario02) Then Exit Sub
    If Not FormCadastro_Telefone_Tratar(cboTipoTelefone03, txtTelefone03, txtTelefoneComentario03) Then Exit Sub
    If IsDate(txtDtValidadeConvenio.Text) And Trim(txtIdentificacaoConvenioPaciente.Text) = "" Then
      FNC_Mensagem("Para informar a data de validade é preciso informar o Número de Carteira do Convênio")
      Exit Sub
    End If
    If Trim(txtIdentificacaoConvenioPaciente.Text) <> "" And Not ComboBox_Selecionado(cboConvenioPaciente) Then
      FNC_Mensagem("Para informar o Número de Carteira do Convênio é preciso selecionar o convênio")
      Exit Sub
    End If
    For Each row As UltraGridRow In grdEndereco.Rows
      If FNC_CampoNulo(row.Cells(const_GridEndereco_CEP).Value) OrElse
         FNC_SoNumero(row.Cells(const_GridEndereco_CEP).Value).Length <> 8 Then
        FNC_Mensagem("Informe um CEP válido para todos os endereços informados")
        Exit Sub
      End If
    Next

    Dim oCPF As New clsValida_CNPJ_CPF

    oCPF.cpf = txtCPF.Text

    If Not oCPF.isCpfValido() Then
      FNC_Mensagem("C.P.F. inválido")
      Exit Sub
    End If

    If FNC_Busca_CPF_CNPJ_Identificar(txtCPF.Text, iID_PESSOA, IIf(FNC_In(Trim(FNC_SoNumero(txtCPF.Text)), "00000000000000", "00000000000"), txtNomePaciente.Text, "")) > 0 Then
      FNC_Mensagem("C.P.F./C.N.P.J. já cadastrado para outra pessoa, favor pesquisá-lo")
      Exit Sub
    End If

    Try
      oIndicacao.Gravar()

      If FormCadastroPessoa_GravarPessoa(iID_PESSOA,
                                         FNC_TextoPrimeiraMaiuscula(txtNomePaciente.Text),
                                         txtNomeMae.Text,
                                         txtDtNascAbertura.Value,
                                         enTipoPessoa.Fisica.GetHashCode,
                                         picFotoPaciente.ArquivoGravacao,
                                         FNC_SoNumero(txtCPF.Value),
                                         FNC_NVL(cboEstadoCivil.SelectedValue, 0),
                                         FNC_NVL(cboNacionalidade.SelectedValue, 0),
                                         FNC_NVL(cboEscolaridade.SelectedValue, 0),
                                         FNC_NVL(cboNaturalidade.SelectedValue, 0),
                                         FNC_NVL(cboRaca.SelectedValue, 0),
                                         FNC_NVL(cboReligiao.SelectedValue, 0),
                                         FNC_NVL(cboSexo.SelectedValue, 0),
                                         FNC_NVL(cboSituacaoProfissional.SelectedValue, 0),
                                         enOpcoes.NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS.GetHashCode(),
                                         Nothing,
                                         txtRG.Text,
                                         txtCartaoSistemaNacionalSaude.Text,
                                         txtNomeReduzido.Text,
                                         Nothing,
                                         Nothing,
                                         cboPaciente_Ativo.SelectedValue) Then
        sNO_PESSOA = txtNomePaciente.Text
        If DBTeveRetorno() Then
          iID_PESSOA = DBRetorno(1)
        End If

        If Not FormCadastroPessoaEmpresa_GravarPaciente(iID_PESSOA,
                                                        iID_EMPRESA_MATRIZ,
                                                        0,
                                                        chkCliente_BloquearVenda.Checked,
                                                        txtComentario.Text,
                                                        txtPendencias.Text,
                                                        FNC_NVL(cboTipoPaciente.SelectedValue, 0),
                                                        (cboPaciente_Ativo.SelectedValue = enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode),
                                                        oIndicacao.INDICACAO) Then GoTo Erro

        picFotoPaciente.ValidarArquivo()

        'Gravar Profissão
        If ComboBox_Selecionado(cboProfissao) Then
          sSqlText = DBMontar_SP("SP_PESSOA_PROFISSAO_CAD", False, "@SQ_PESSOA_PROFISSAO",
                                                                   "@ID_PESSOA",
                                                                   "@ID_PROFISSAO",
                                                                   "@DT_INICIO_ATUACAO")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_PROFISSAO", iSQ_PESSOA_PROFISSAO),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_PROFISSAO", cboProfissao.SelectedValue),
                               DBParametro_Montar("DT_INICIO_ATUACAO", Nothing))
        Else
          If iSQ_PESSOA_PROFISSAO > 0 Then
            sSqlText = DBMontar_SP("SP_PESSOA_PROFISSAO_DEL", False, "@SQ_PESSOA_PROFISSAO")
            DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_PROFISSAO", iSQ_PESSOA_PROFISSAO))
          End If
        End If
        'Gravar Mídia Social
        If Trim(txtMidiaSocial_EMail.Text) = "" Then
          If iSQ_PESSOA_MIDIASOCIAL_EMAIL > 0 Then
            sSqlText = DBMontar_SP("SP_PESSOA_MIDIASOCIAL_DEL", False, "@SQ_PESSOA_MIDIASOCIAL")
            DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_MIDIASOCIAL", iSQ_PESSOA_MIDIASOCIAL_EMAIL))
          End If
        Else
          sSqlText = DBMontar_SP("SP_PESSOA_MIDIASOCIAL_CAD", False, "@SQ_PESSOA_MIDIASOCIAL",
                                                                     "@ID_PESSOA",
                                                                     "@ID_TIPO_MIDIASOCIAL",
                                                                     "@DS_MIDIASOCIAL")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_MIDIASOCIAL", iSQ_PESSOA_MIDIASOCIAL_EMAIL),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_TIPO_MIDIASOCIAL", enTipoMidiaSocial.EMail.GetHashCode),
                               DBParametro_Montar("DS_MIDIASOCIAL", txtMidiaSocial_EMail.Text))
        End If
        'If Trim(txtMidiaSocial_WebSite.Text) = "" Then
        '  If iSQ_PESSOA_MIDIASOCIAL_EMAIL > 0 Then
        '    sSqlText = DBMontar_SP("SP_PESSOA_MIDIASOCIAL_DEL", False, "@SQ_PESSOA_MIDIASOCIAL")
        '    DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_MIDIASOCIAL", iSQ_PESSOA_MIDIASOCIAL_WEBSITE))
        '  End If
        'Else
        '  sSqlText = DBMontar_SP("SP_PESSOA_MIDIASOCIAL_CAD", False, "@SQ_PESSOA_MIDIASOCIAL",
        '                                                             "@ID_PESSOA",
        '                                                             "@ID_TIPO_MIDIASOCIAL",
        '                                                             "@DS_MIDIASOCIAL")
        '  DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_MIDIASOCIAL", iSQ_PESSOA_MIDIASOCIAL_WEBSITE),
        '                       DBParametro_Montar("ID_PESSOA", iID_PESSOA),
        '                       DBParametro_Montar("ID_TIPO_MIDIASOCIAL", enTipoMidiaSocial.WebSite.GetHashCode),
        '                       DBParametro_Montar("DS_MIDIASOCIAL", txtMidiaSocial_WebSite.Text))
        'End If
        'Gravar Endereço
        For iCont = 0 To grdEndereco.Rows.Count - 1
          With grdEndereco.Rows(iCont)
            sSqlText = DBMontar_SP("SP_ENDERECO_CAD", False, "@SQ_ENDERECO",
                                                             "@ID_PESSOA",
                                                             "@ID_TIPO_ENDERECO",
                                                             "@ID_CIDADE",
                                                             "@DS_LOGRADOURO",
                                                             "@NO_BAIRRO",
                                                             "@NR_LOGRADOURO",
                                                             "@DS_COMPLEMENTO",
                                                             "@CD_CEP",
                                                             "@IC_ATIVO")
            DBExecutar(sSqlText, DBParametro_Montar("SQ_ENDERECO", .Cells(const_GridEndereco_SQ_ENDERECO).Value),
                                 DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                                 DBParametro_Montar("ID_TIPO_ENDERECO", .Cells(const_GridEndereco_TipoEndereco).Value),
                                 DBParametro_Montar("ID_CIDADE", .Cells(const_GridEndereco_Cidade).Value),
                                 DBParametro_Montar("DS_LOGRADOURO", .Cells(const_GridEndereco_Logradouro).Value),
                                 DBParametro_Montar("NO_BAIRRO", .Cells(const_GridEndereco_Bairro).Value),
                                 DBParametro_Montar("NR_LOGRADOURO", .Cells(const_GridEndereco_Numero).Value),
                                 DBParametro_Montar("DS_COMPLEMENTO", .Cells(const_GridEndereco_Complemento).Value),
                                 DBParametro_Montar("CD_CEP", FNC_SoNumero(.Cells(const_GridEndereco_CEP).Value)),
                                 DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdEndereco, const_GridEndereco_Ativo, iCont)))
          End With
        Next
        'Gravar Telefone
        sSqlText = DBMontar_SP("SP_PESSOA_TELEFONE_CAD", False, "@SQ_PESSOA_TELEFONE",
                                                                "@ID_PESSOA",
                                                                "@ID_TIPO_TELEFONE",
                                                                "@CD_NUMERO",
                                                                "@IC_WHATSAPP",
                                                                "@CM_OBSERVACAO")
        If ComboBox_Selecionado(cboTipoTelefone01) Then
          DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_TELEFONE", FNC_NVL(iSQ_PESSOA_TELEFONE(0), 0)),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_TIPO_TELEFONE", cboTipoTelefone01.SelectedValue),
                               DBParametro_Montar("CD_NUMERO", Trim(txtTelefone01.Text)),
                               DBParametro_Montar("IC_WHATSAPP", IIf(txtTelefone01.Tag = const_TelefoneWhatsApp, "S", "N")),
                               DBParametro_Montar("CM_OBSERVACAO", FNC_NuloString(txtTelefoneComentario01.Text, False),,, const_BancoDados_TamanhoComentario))
        Else
          If FNC_NVL(iSQ_PESSOA_TELEFONE(0), 0) > 0 Then
            sSqlText = DBMontar_SP("SP_PESSOA_TELEFONE_DEL", False, "@SQ_PESSOA_TELEFONE")

            DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_TELEFONE", iSQ_PESSOA_TELEFONE(0)))
          End If
        End If
        If ComboBox_Selecionado(cboTipoTelefone02) Then
          DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_TELEFONE", FNC_NVL(iSQ_PESSOA_TELEFONE(1), 0)),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_TIPO_TELEFONE", cboTipoTelefone02.SelectedValue),
                               DBParametro_Montar("CD_NUMERO", Trim(txtTelefone02.Text)),
                               DBParametro_Montar("IC_WHATSAPP", IIf(txtTelefone02.Tag = const_TelefoneWhatsApp, "S", "N")),
                               DBParametro_Montar("CM_OBSERVACAO", FNC_NVL(txtTelefoneComentario02.Text, ""),,, const_BancoDados_TamanhoComentario))
        Else
          If FNC_NVL(iSQ_PESSOA_TELEFONE(1), 0) > 0 Then
            DBExecutar(DBMontar_SP("SP_PESSOA_TELEFONE_DEL", False, "@SQ_PESSOA_TELEFONE"),
                       DBParametro_Montar("SQ_PESSOA_TELEFONE", iSQ_PESSOA_TELEFONE(1)))
          End If
        End If
        If ComboBox_Selecionado(cboTipoTelefone03) Then
          DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_TELEFONE", FNC_NVL(iSQ_PESSOA_TELEFONE(2), 0)),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_TIPO_TELEFONE", cboTipoTelefone03.SelectedValue),
                               DBParametro_Montar("CD_NUMERO", Trim(txtTelefone03.Text)),
                               DBParametro_Montar("IC_WHATSAPP", IIf(txtTelefone03.Tag = const_TelefoneWhatsApp, "S", "N")),
                               DBParametro_Montar("CM_OBSERVACAO", FNC_NVL(txtTelefoneComentario03.Text, ""),,, const_BancoDados_TamanhoComentario))
        Else
          If FNC_NVL(iSQ_PESSOA_TELEFONE(2), 0) > 0 Then
            DBExecutar(DBMontar_SP("SP_PESSOA_TELEFONE_DEL", False, "@SQ_PESSOA_TELEFONE"),
                       DBParametro_Montar("SQ_PESSOA_TELEFONE", iSQ_PESSOA_TELEFONE(2)))
          End If
        End If
        'Gravar Convênio
        If ComboBox_Selecionado(cboConvenioPaciente) Then
          sSqlText = DBMontar_SP("SP_PESSOA_CONVENIO_CAD", False, "@ID_PESSOA",
                                                                  "@ID_EMPRESA",
                                                                  "@ID_CONVENIO",
                                                                  "@CD_IDENTIFICACAO",
                                                                  "@DT_VALIDADE")
          DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                               DBParametro_Montar("ID_CONVENIO", cboConvenioPaciente.SelectedValue),
                               DBParametro_Montar("CD_IDENTIFICACAO", IIf(Trim(txtIdentificacaoConvenioPaciente.Text) = "", Nothing, txtIdentificacaoConvenioPaciente.Text)),
                               DBParametro_Montar("DT_VALIDADE", IIf(IsDate(txtDtValidadeConvenio.Text), txtDtValidadeConvenio.Value, Nothing)))
        Else
          If iID_CONVENIO_PACIENTE > 0 Then
            sSqlText = DBMontar_SP("SP_PESSOA_CONVENIO_DEL", False, "@ID_PESSOA",
                                                                    "@ID_EMPRESA",
                                                                    "@ID_CONVENIO")
            DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                                 DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                 DBParametro_Montar("ID_CONVENIO", iID_CONVENIO_PACIENTE))
          End If
        End If

        sSqlText = ""
        'Exclusão dos endereço
        If Not oEndereco_Exclusao Is Nothing Then
          For iCont = 1 To oEndereco_Exclusao.Count
            sSqlText = "DELETE FROM TB_ENDERECO" &
                       " WHERE SQ_ENDERECO = " & oEndereco_Exclusao(iCont)
            DBExecutar(sSqlText)
          Next
        End If

        RaiseEvent GravacaoEfetuada()

        If bComboPaciente Then
          bEmProcessamento = True
          oPaciente.ID_Pessoa = 0
          'ComboBox_CarregarPessoa(cboPaciente, enTipoFiltroPessoa.Pessoa_Fisica, , , 0, True)
          bEmProcessamento = False
        End If

        FNC_Historico(Historico_Acao)

        CarregarDados()

        FNC_Mensagem("Gravação dos dados do paciente efetuado")
      End If
    Catch ex As Exception
      FNC_Mensagem("cmdGravar - " & ex.Message)
      DBUsarTransacao = False
    End Try

    Exit Sub

Erro:
    DBUsarTransacao = False
  End Sub

  Public Sub NovoCadastro(Optional bZerarIDPaciente As Boolean = True)
    If bZerarIDPaciente Then iID_PESSOA = 0

    bEmProcessamento = True

    Historico_Acao = enOpcoes.Processo_Acao_Inclusao

    lblIdade.Text = ""
    txtNomePaciente.Text = ""
    txtNomeReduzido.Text = ""
    oPaciente.ID_Pessoa = 0
    txtDtNascAbertura.Value = Nothing
    txtCPF.Value = ""
    txtDtCadastro.Value = Nothing
    cboEstadoCivil.SelectedIndex = -1
    cboNacionalidade.SelectedIndex = -1
    cboEscolaridade.SelectedIndex = -1
    cboNaturalidade.SelectedIndex = -1
    cboRaca.SelectedIndex = -1
    cboReligiao.SelectedIndex = -1
    cboSexo.SelectedIndex = -1
    cboSituacaoProfissional.SelectedIndex = -1
    txtRG.Text = ""
    ComboBox_Selecionar(cboPaciente_Ativo, enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode)
    chkLimiteCreditoBloqueado.Checked = False
    chkCliente_BloquearVenda.Checked = False
    txtComentario.Text = ""
    txtPendencias.Text = ""
    txtCartaoSistemaNacionalSaude.Text = ""
    cboTipoPaciente.SelectedIndex = -1

    iSQ_PESSOA_PROFISSAO = 0
    cboProfissao.SelectedIndex = -1
    iSQ_PESSOA_MIDIASOCIAL_EMAIL = 0
    iSQ_PESSOA_MIDIASOCIAL_WEBSITE = 0
    txtMidiaSocial_EMail.Text = ""
    iSQ_PESSOA_TELEFONE(0) = 0
    iSQ_PESSOA_TELEFONE(1) = 0
    iSQ_PESSOA_TELEFONE(2) = 0
    FormPesquisaPessoa_TelefoneWhatsApp_Limpar(txtTelefone01, txtTelefone02, txtTelefone03)
    cboTipoTelefone01.SelectedIndex = -1
    txtTelefone01.Text = ""
    txtTelefoneComentario01.Text = ""
    cboTipoTelefone02.SelectedIndex = -1
    txtTelefone02.Text = ""
    txtTelefoneComentario02.Text = ""
    cboTipoTelefone03.SelectedIndex = -1
    txtTelefone03.Text = ""
    txtTelefoneComentario03.Text = ""
    iID_CONVENIO_PACIENTE = 0
    cboConvenioPaciente.SelectedIndex = -1
    txtIdentificacaoConvenioPaciente.Text = ""
    txtDtValidadeConvenio.Value = Nothing
    oIndicacao.Limpar()
    picFotoPaciente.Inicializar()

    oDBEndereco.Rows.Clear()
    oPaciente_Historico.Limpar()
    oEndereco_Exclusao = New Collection

    RaiseEvent Novo()

    bEmProcessamento = False
  End Sub

  Private Sub cmdFecharHistorico_Click(sender As Object, e As EventArgs) Handles cmdFecharHistorico.Click
    pnlHistorico.Visible = False
  End Sub

  Private Sub cmdHistorico_Click(sender As Object, e As EventArgs) Handles cmdHistorico.Click
    If pnlHistorico.Visible Then
      pnlHistorico.Visible = False
    Else
      pnlHistorico.BringToFront()
      pnlHistorico.Visible = True
      CarregarHistorico()
    End If
  End Sub

  Private Sub cmdTelefoneWhatsApp01_Click(sender As Object, e As EventArgs) Handles cmdTelefoneWhatsApp01.Click
    FormPesquisaPessoa_TelefoneWhatsApp(txtTelefone01)
    llbTelefoneWhatsApp01.Visible = True
  End Sub

  Private Sub cmdTelefoneWhatsApp02_Click(sender As Object, e As EventArgs) Handles cmdTelefoneWhatsApp02.Click
    FormPesquisaPessoa_TelefoneWhatsApp(txtTelefone02)
    llbTelefoneWhatsApp02.Visible = True
  End Sub

  Private Sub cmdTelefoneWhatsApp03_Click(sender As Object, e As EventArgs) Handles cmdTelefoneWhatsApp03.Click
    FormPesquisaPessoa_TelefoneWhatsApp(txtTelefone03)
    llbTelefoneWhatsApp03.Visible = True
  End Sub

  Private Sub cboNaturalidade_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNaturalidade.KeyDown
    If e.KeyCode = Keys.Delete Then cboNaturalidade.SelectedIndex = -1
  End Sub

  Private Sub cboNascionalidade_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNacionalidade.KeyDown
    If e.KeyCode = Keys.Delete Then cboNacionalidade.SelectedIndex = -1
  End Sub

  Private Sub cboEstadoCivil_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEstadoCivil.KeyDown
    If e.KeyCode = Keys.Delete Then cboEstadoCivil.SelectedIndex = -1
  End Sub

  Private Sub cboRaca_KeyDown(sender As Object, e As KeyEventArgs) Handles cboRaca.KeyDown
    If e.KeyCode = Keys.Delete Then cboRaca.SelectedIndex = -1
  End Sub

  Private Sub cboReligiao_KeyDown(sender As Object, e As KeyEventArgs) Handles cboReligiao.KeyDown
    If e.KeyCode = Keys.Delete Then cboReligiao.SelectedIndex = -1
  End Sub

  Private Sub cboEscolaridade_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEscolaridade.KeyDown
    If e.KeyCode = Keys.Delete Then cboEscolaridade.SelectedIndex = -1
  End Sub

  Private Sub cboSexo_KeyDown(sender As Object, e As KeyEventArgs) Handles cboSexo.KeyDown
    If e.KeyCode = Keys.Delete Then cboSexo.SelectedIndex = -1
  End Sub

  Private Sub cboTipoPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoPaciente.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoPaciente.SelectedIndex = -1
  End Sub

  Private Sub cboProfissao_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProfissao.KeyDown
    If e.KeyCode = Keys.Delete Then cboProfissao.SelectedIndex = -1
  End Sub

  Private Sub cboSituacaoProfissional_KeyDown(sender As Object, e As KeyEventArgs) Handles cboSituacaoProfissional.KeyDown
    If e.KeyCode = Keys.Delete Then cboSituacaoProfissional.SelectedIndex = -1
  End Sub

  Private Sub cboTipoTelefone01_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoTelefone01.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoTelefone01.SelectedIndex = -1
  End Sub

  Private Sub cboTipoTelefone02_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoTelefone02.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoTelefone02.SelectedIndex = -1
  End Sub

  Private Sub cboTipoTelefone03_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoTelefone03.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoTelefone03.SelectedIndex = -1
  End Sub

  Private Sub cboConvenioPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles cboConvenioPaciente.KeyDown
    If e.KeyCode = Keys.Delete Then cboConvenioPaciente.SelectedIndex = -1
  End Sub

  Private Sub cmdGerarConsultas_Click(sender As Object, e As EventArgs) Handles cmdGerarConsultas.Click
    RaiseEvent GerarConsulta()
  End Sub

  Private Sub grdEndereco_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdEndereco.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_TipoEndereco).Value) Then
      FNC_Mensagem("É preciso selecionar o tipo de endereço")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_Logradouro).Value) Then
      FNC_Mensagem("É preciso informar a descrição do logradouro")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_Cidade).Value) Then
      FNC_Mensagem("É preciso selecionar a cidade")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_Bairro).Value) Then
      FNC_Mensagem("É preciso selecionar o bairro")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_CEP).Value) OrElse
       FNC_SoNumero(e.Row.Cells(const_GridEndereco_CEP).Value).Length <> 8 Then
      FNC_Mensagem("É preciso selecionar um CEP válido")
      e.Cancel = True
      Exit Sub
    End If
    If objGrid_Coluna_ProcurarValor(grdEndereco,
                                    FNC_GerarArray(const_GridEndereco_Cidade, e.Row.Cells(const_GridEndereco_Cidade).Value,
                                                   const_GridEndereco_Bairro, e.Row.Cells(const_GridEndereco_Bairro).Value,
                                                   const_GridEndereco_Logradouro, e.Row.Cells(const_GridEndereco_Logradouro).Value,
                                                   const_GridEndereco_Numero, e.Row.Cells(const_GridEndereco_Numero).Value),
                                    e.Row.Index) > -1 Then
      FNC_Mensagem("Endereço já cadastrado")
      e.Cancel = True
    End If
  End Sub

  Private Sub grdEndereco_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdEndereco.BeforeRowsDeleted
    e.DisplayPromptMsg = False
    If FNC_Perguntar("Deseja realmente excluir o endereço " & e.Rows(0).Cells(const_GridEndereco_Logradouro).Value & "?") Then
      oEndereco_Exclusao.Add(e.Rows(0).Cells(const_GridEndereco_SQ_ENDERECO).Value)
    Else
      e.Cancel = True
    End If
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    NovoCadastro()
  End Sub

  Private Sub grdHistoricoConsultas_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs)
    If Not e.Row.IsActiveRow = Nothing Then
      RaiseEvent GridHistoricoConsultas_DoubleClickRow(iID_CONVENIO_PACIENTE, e.Row.Cells(const_GridListagemHistoricoConsultas_ID).Value)
    End If
  End Sub

  Private Sub grdHistoricoFamiliar_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs)
    e.DisplayPromptMsg = False
    e.Cancel = (Not FNC_Perguntar("Deseja realmente excluir o histórico de " & e.Rows(0).Cells(const_GridListagemHistoricoFamiliar_Nome).Value & "?"))
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    RaiseEvent Fechar()
  End Sub

  Private Sub cboPaciente_TextChanged(sender As Object, e As EventArgs) Handles cboPaciente.TextChanged
    txtNomePaciente.Text = cboPaciente.Text
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If iID_PESSOA = 0 Then
      FNC_Mensagem("Selecione o paciente ou preciso gravar os dados desse cadastro")
      Exit Sub
    End If

    FormRelatorioPaciente(iID_PESSOA)
  End Sub

  Private Sub cboReligiao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReligiao.SelectedIndexChanged
    ToolTip1.SetToolTip(cboReligiao, cboReligiao.Text)
  End Sub

  Private Sub cboProfissao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProfissao.SelectedIndexChanged
    ToolTip1.SetToolTip(cboReligiao, cboProfissao.Text)
  End Sub

  Private Sub txtDtNascAbertura_ValueChanged(sender As Object, e As EventArgs) Handles txtDtNascAbertura.ValueChanged
    If IsDate(txtDtNascAbertura.Text) Then
      lblIdade.Text = "Idade: " & FNC_DateDiff_Extenso(txtDtNascAbertura.DateTime.Date, Now.Date)
    Else
      lblIdade.Text = ""
    End If
  End Sub

  Private Sub txtCPF_LostFocus(sender As Object, e As EventArgs) Handles txtCPF.LostFocus
    'Dim iRet As Integer

    'iRet = FNC_Busca_CPF_CNPJ_Identificar(txtCPF.Text)

    'If iRet <> iID_PESSOA And iID_PESSOA = 0 Then
    '  iID_PESSOA = iRet
    '  ComboBox_CarregarPessoa(cboPaciente, enTipoFiltroPessoa.Pessoa_Fisica, iID_PESSOA, , , True)
    '  ComboBox_Posicionar(cboPaciente, iID_PESSOA)
    '  'CarregarDados()
    'End If
  End Sub

  Public Sub Finalizar()
    objGrid_Configuracao_Gravar(grdEndereco, "grdEndereco")
    oPaciente_Historico.Finalizar()
  End Sub

  Private Sub LlbTelefoneWhatsApp01_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbTelefoneWhatsApp01.LinkClicked
    FNC_WhatsApp(txtTelefone01.Text)
  End Sub

  Private Sub LlbTelefoneWhatsApp02_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbTelefoneWhatsApp02.LinkClicked
    FNC_WhatsApp(txtTelefone02.Text)
  End Sub

  Private Sub LlbTelefoneWhatsApp03_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbTelefoneWhatsApp03.LinkClicked
    FNC_WhatsApp(txtTelefone03.Text)
  End Sub

  Private Sub oPaciente_SelectedIndexChanged() Handles oPaciente.SelectedIndexChanged
    If Not bEmProcessamento Then
      If oPaciente.ID_Pessoa = 0 Then
        NovoCadastro()
      Else
        If Not bDBCarregandoComboBox Then CarregarDados()
      End If
    End If
  End Sub

  Private Sub FNC_Historico_Guardar()
    oHistorico.Inicializar()
    oHistorico.Controle_LimparValorAtual()
    oHistorico.Controle_ValorAtual(txtNomePaciente, txtNomePaciente.Text)
    oHistorico.Controle_ValorAtual(txtNomeMae, txtNomeMae.Text)
    oHistorico.Controle_ValorAtual(txtNomeReduzido, txtNomeReduzido.Text)
    oHistorico.Controle_ValorAtual(txtCPF, txtCPF.Text)
    oHistorico.Controle_ValorAtual(txtRG, txtRG.Text)
    oHistorico.Controle_ValorAtual(txtDtNascAbertura, txtDtNascAbertura.Text)
    oHistorico.Controle_ValorAtual(cboEstadoCivil, cboEstadoCivil.Text)
    oHistorico.Controle_ValorAtual(cboNaturalidade, cboNaturalidade.Text)
    oHistorico.Controle_ValorAtual(cboNacionalidade, cboNacionalidade.Text)
    oHistorico.Controle_ValorAtual(cboEscolaridade, cboEscolaridade.Text)
    oHistorico.Controle_ValorAtual(cboRaca, cboRaca.Text)
    oHistorico.Controle_ValorAtual(cboReligiao, cboReligiao.Text)
    oHistorico.Controle_ValorAtual(cboSexo, cboSexo.Text)
    oHistorico.Controle_ValorAtual(txtCartaoSistemaNacionalSaude, txtCartaoSistemaNacionalSaude.Text)
    oHistorico.Controle_ValorAtual(cboTipoPaciente, cboTipoPaciente.Text)
    oHistorico.Controle_ValorAtual(cboProfissao, cboProfissao.Text)
    oHistorico.Controle_ValorAtual(cboSituacaoProfissional, cboSituacaoProfissional.Text)
    oHistorico.Controle_ValorAtual(cboTipoTelefone01, cboTipoTelefone01.Text)
    oHistorico.Controle_ValorAtual(txtTelefone01, txtTelefone01.Text)
    oHistorico.Controle_ValorAtual(txtTelefoneComentario01, txtTelefoneComentario01.Text)
    oHistorico.Controle_ValorAtual(cboTipoTelefone02, cboTipoTelefone02.Text)
    oHistorico.Controle_ValorAtual(txtTelefone02, txtTelefone02.Text)
    oHistorico.Controle_ValorAtual(txtTelefoneComentario02, txtTelefoneComentario02.Text)
    oHistorico.Controle_ValorAtual(cboTipoTelefone03, cboTipoTelefone03.Text)
    oHistorico.Controle_ValorAtual(txtTelefone03, txtTelefone03.Text)
    oHistorico.Controle_ValorAtual(txtTelefoneComentario03, txtTelefoneComentario03.Text)
    oHistorico.Controle_ValorAtual(cboConvenioPaciente, cboConvenioPaciente.Text)
    oHistorico.Controle_ValorAtual(txtMidiaSocial_EMail, txtMidiaSocial_EMail.Text)
  End Sub

  Private Sub FNC_Historico(iAcao As enOpcoes)
    oHistorico.ID_Registro = iID_PESSOA
    oHistorico.GravarHistorico(enOpcoes.Processo_Historico_Cadastro_CadastroPaciente.GetHashCode,
                               iAcao, 0,
                               txtCPF.Text, "",
                               New Object() {txtNomePaciente, "Nome Paciente",
                                             txtNomeMae, "Nome da Mãe",
                                             txtNomeReduzido, "Nome Reduzido ou Apelido",
                                             txtCPF, "C.P.F.",
                                             txtRG, "R.G.",
                                             txtDtNascAbertura, "Dt. NascAbertura",
                                             cboEstadoCivil, "Estado Civíl",
                                             cboNaturalidade, "Naturalidade",
                                             cboNacionalidade, "Nacionalidade",
                                             cboEscolaridade, "Escolaridade",
                                             cboRaca, "Raça",
                                             cboReligiao, "Religião",
                                             cboSexo, "Sexo",
                                             txtCartaoSistemaNacionalSaude, "Nº Cartão Nacional Saúde",
                                             cboTipoPaciente, "Tipo de Paciente",
                                             cboProfissao, "Profissão",
                                             cboSituacaoProfissional, "Situação Profissional",
                                             cboTipoTelefone01, "Tipo de Telefone 01",
                                             txtTelefone01, "Número Telefone 01",
                                             txtTelefoneComentario01, "Comentário Telefone 01",
                                             cboTipoTelefone02, "Tipo de Telefone 02",
                                             txtTelefone02, "Número Telefone 02",
                                             txtTelefoneComentario02, "Comentário Telefone 02",
                                             cboTipoTelefone03, "Tipo de Telefone 03",
                                             txtTelefone03, "Número Telefone 03",
                                             txtTelefoneComentario03, "Comentário Telefone 03",
                                             cboConvenioPaciente, "Convênio do Paciente",
                                             txtMidiaSocial_EMail, "E-Mail"})

    FNC_Historico_Guardar()
  End Sub

  Private Sub cmdHistoricoAlteracao_Click(sender As Object, e As EventArgs) Handles cmdHistoricoAlteracao.Click
    If iID_PESSOA <> 0 Then
      Dim oForm As New frmConsultaHistorico_Registro

      oForm.iProcessso = enOpcoes.Processo_Historico_Cadastro_CadastroPaciente.GetHashCode()
      oForm.iID_REGISTRO = iID_PESSOA
      FNC_AbriTela(oForm, , True, True)
    End If
  End Sub

  Private Sub grdEndereco_ClickCellButton(sender As Object, e As CellEventArgs) Handles grdEndereco.ClickCellButton
    Dim dadosCep = modServicosExterno.BuscarCEP(e.Cell.Row.Cells(const_GridEndereco_Cep).Value)

    If dadosCep.RetornoBusca Then
      Dim sCidade = DBQuery_ValorUnico("SELECT SQ_CIDADE FROM VW_CIDADE WHERE NO_CIDADE = " & FNC_QuotedStr(dadosCep.Cidade) & " AND CD_UF = " & FNC_QuotedStr(dadosCep.Estado), 0)

      e.Cell.Row.Cells(const_GridEndereco_Logradouro).Value = dadosCep.Logradouro
      e.Cell.Row.Cells(const_GridEndereco_Bairro).Value = dadosCep.Bairro
      e.Cell.Row.Cells(const_GridEndereco_Complemento).Value = dadosCep.Complemento

      If sCidade IsNot Nothing AndAlso Not String.IsNullOrEmpty(sCidade) And IsNumeric(sCidade) Then
        e.Cell.Row.Cells(const_GridEndereco_Cidade).Value = sCidade
      End If
    Else
      FNC_Mensagem(dadosCep.MensagemRetorno)
    End If
  End Sub
End Class
