Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmCadastroPessoa
  Public Event Pesquisar()

  Public iSQ_PESSOA As Integer
  Public bGravado As Boolean

  Public sNO_PESSOA As String
  Public sCD_TELEFONE As String
  Public sCD_CELULAR As String

  Const const_GridProfissao_SQ_PESSOA_PROFISSAO As Integer = 0
  Const const_GridProfissao_NO_PROFISSAO As Integer = 1
  Const const_GridProfissao_DT_INICIO_ATUACAO As Integer = 2

  Const const_GridMidiaSocial_SQ_PESSOA_MIDIASOCIAL As Integer = 0
  Const const_GridMidiaSocial_TipoMidiaSocial As Integer = 1
  Const const_GridMidiaSocial_EnderecoMidiaSocial As Integer = 2

  Const const_GridEndereco_SQ_ENDERECO As Integer = 0
  Const const_GridEndereco_TipoEndereco As Integer = 1
  Const const_GridEndereco_Logradouro As Integer = 2
  Const const_GridEndereco_Numero As Integer = 3
  Const const_GridEndereco_Bairro As Integer = 4
  Const const_GridEndereco_Cidade As Integer = 5
  Const const_GridEndereco_CEP As Integer = 6
  Const const_GridEndereco_Complemento As Integer = 7
  Const const_GridEndereco_Ativo As Integer = 8

  Const const_GridTelefone_SQ_PESSOA_TELEFONE As Integer = 0
  Const const_GridTelefone_TipoTelefone As Integer = 1
  Const const_GridTelefone_Numero As Integer = 2
  Const const_GridTelefone_Whatsapp As Integer = 3
  Const const_GridTelefone_Comentario As Integer = 4

  Const const_GridReferencia_SQ_PESSOA_REFERENCIA As Integer = 0
  Const const_GridReferencia_TipoReferencia As Integer = 1
  Const const_GridReferencia_Nome As Integer = 2
  Const const_GridReferencia_Telefone As Integer = 3
  Const const_GridReferencia_Complemento As Integer = 4

  Const const_GridConvenio_NomeConvenio As Integer = 0
  Const const_GridConvenio_Identificacao As Integer = 1
  Const const_GridConvenio_DataValidade As Integer = 2

  Const const_GridEspecialidade_NomeEspecialidade As Integer = 0
  Const const_GridEspecialidade_DataConclusao As Integer = 1

  Const const_GridExame_NomeExame As Integer = 0

  Const const_GridFaixaEtaria_SQ_PESSOA_FAIXAETARIA As Integer = 0
  Const const_GridFaixaEtaria_NomeFaixaEtaria As Integer = 1

  Const const_GridGrupoPermissao_Chk As Integer = 0
  Const const_GridGrupoPermissao_SQ_GRUPOPERMISSAO As Integer = 1
  Const const_GridGrupoPermissao_NomeGrupoPermissao As Integer = 2

  Const const_GridPessoaVinculada_ID_PESSOA As Integer = 0
  Const const_GridPessoaVinculada_Pessoa As Integer = 1
  Const const_GridPessoaVinculada_PermissaoCredito As Integer = 2

  Const const_GridIndicador_ListagemCidadeAtuacao_ID_UF As Integer = 0
  Const const_GridIndicador_ListagemCidadeAtuacao_ID_CIDADE As Integer = 1
  Const const_GridIndicador_ListagemCidadeAtuacao_Estado As Integer = 2
  Const const_GridIndicador_ListagemCidadeAtuacao_Cidade As Integer = 3

  Dim oDBProfissao As New UltraWinDataSource.UltraDataSource
  Dim oDBMidiaSocial As New UltraWinDataSource.UltraDataSource
  Dim oDBEndereco As New UltraWinDataSource.UltraDataSource
  Dim oDBTelefone As New UltraWinDataSource.UltraDataSource
  Dim oDBReferencia As New UltraWinDataSource.UltraDataSource
  Dim oDBConvenio As New UltraWinDataSource.UltraDataSource
  Dim oDBEspecialidade As New UltraWinDataSource.UltraDataSource
  Dim oDBGrupoPermissao As New UltraWinDataSource.UltraDataSource
  Dim oDBPessoaVinculada As New UltraWinDataSource.UltraDataSource
  Dim oDBExame As New UltraWinDataSource.UltraDataSource
  Dim oDBFaixaEtaria As New UltraWinDataSource.UltraDataSource
  Dim oDBIndicador_ListagemCidadeAtuacao As New UltraWinDataSource.UltraDataSource

  Dim oProfissao_Exclusao As New Collection
  Dim oMediaSocial_Exclusao As New Collection
  Dim oTelefone_Exclusao As New Collection
  Dim oConvenio_Exclusao As New Collection
  Dim oEndereco_Exclusao As New Collection
  Dim oReferenciaPessoal_Exclusao As New Collection
  Dim oFaixaEtaria_Exclusao As New Collection

  Dim iLinhaEdicaoProfissao As Integer = -1
  Dim bCarregado As Boolean = False

  Private Sub frmCadastroPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    FormatarTela()

    TextBox_FormatarCampoTexto(txtCliente_Comentario)
    TextBox_FormatarCampoTexto(txtFornecedor_Observacao)
    TextBox_FormatarCampoTexto(txtPaciente_Comentario)
    TextBox_FormatarCampoTexto(txtPaciente_Pendencias)

    txtNomePessoa.Text = sNO_PESSOA
    cmdNovo.Visible = (FNC_NVL(sNO_PESSOA, "").Trim() = "")

    If FNC_NVL(sCD_TELEFONE, "").Trim() <> "" Then
      objGrid_Linha_Add(grdTelefone, New Object() {const_GridTelefone_TipoTelefone, enTipoTelefone.Residencial.GetHashCode(),
                                                   const_GridTelefone_Numero, sCD_CELULAR})
    End If
    If FNC_NVL(sCD_CELULAR, "").Trim() <> "" Then
      objGrid_Linha_Add(grdTelefone, New Object() {const_GridTelefone_TipoTelefone, enTipoTelefone.Celular.GetHashCode(),
                                                   const_GridTelefone_Numero, sCD_CELULAR})
    End If

    bCarregado = True

    If iSQ_PESSOA > 0 Then
      CarregarDados()
    End If

    cmdNovo.Enabled = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroPessoa).bIncluir
    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroPessoa).bGravar
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer

    picFoto.Image = Nothing

    sSqlText = "SELECT NO_PESSOA," &
                      "DT_NASC_ABERTURA," &
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
                      "ID_OPT_PJ_CONTRIBUICAO_ICMS," &
                      "ID_PESSOA_RESPONSAVEL," &
                      "CD_PF_RG," &
                      "NO_FANTASIA_REDUZIDO," &
                      "CD_PJ_IE," &
                      "CD_PJ_IM," &
                      "DS_PATH_IMAGEM" &
               " FROM TB_PESSOA" &
               " WHERE SQ_PESSOA = " & iSQ_PESSOA
    oData = DBQuery(sSqlText)

    If oData.Rows.Count > 0 Then
      With oData.Rows(0)
        'Dados Gerais
        txtNomePessoa.Text = .Item("NO_PESSOA")
        txtDataNascAbertura.Value = .Item("DT_NASC_ABERTURA")
        ComboBox_Selecionar(cboTipoPessoa, .Item("ID_TIPO_PESSOA"), , True)
        ComboTipoPessoa_TratarSelecionado()
        txtCPF_CNPJ.Text = .Item("CD_CPF_CNPJ")
        ComboBox_Selecionar(cboAtivo, .Item("ID_OPT_ATIVO"), , True)
        ComboBox_Selecionar(cboEstadoCivil, .Item("ID_PF_TIPO_ESTADOCIVIL"), , True)
        ComboBox_Selecionar(cboNascionalidade, .Item("ID_PF_NACIONALIDADE"), , True)
        ComboBox_Selecionar(cboNaturalidade, .Item("ID_PF_NATURALIDADE"), , True)
        ComboBox_Selecionar(cboEscolaridade, .Item("ID_PF_TIPO_ESCOLARIDADE"), , True)
        ComboBox_Selecionar(cboRaca, .Item("ID_PF_TIPO_RACA"), , True)
        ComboBox_Selecionar(cboReligiao, .Item("ID_PF_TIPO_RELIGIAO"), , True)
        ComboBox_Selecionar(cboSexo, .Item("ID_PF_TIPO_SEXO"), , True)
        ComboBox_Selecionar(cboSituacaoProfissional, .Item("ID_OPT_SITUACAOPROFISSIONAL"), , True)
        ComboBox_Selecionar(cboTipoContribuicaoICMS, .Item("ID_OPT_PJ_CONTRIBUICAO_ICMS"), , True)
        txtRG.Text = FNC_NVL(.Item("CD_PF_RG"), "")
        txtNomeReduzido.Text = FNC_NVL(.Item("NO_FANTASIA_REDUZIDO"), "")
        txtNomeFantasia.Text = FNC_NVL(.Item("NO_FANTASIA_REDUZIDO"), "")
        txtInscricaoEstadual.Text = FNC_NVL(.Item("CD_PJ_IE"), "")
        txtInscricaoMunicipal.Text = FNC_NVL(.Item("CD_PJ_IM"), "")
        psqPessoaResponsavel.ID_Pessoa = FNC_NVL(.Item("ID_PESSOA_RESPONSAVEL"), 0)
        picFoto.Arquivo = .Item("DS_PATH_IMAGEM")
        oAnexo.iID_PESSOA = iSQ_PESSOA
        oAnexo.Carregar()

        If cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode Then
          'Grid de Profissão
          sSqlText = "SELECT PP.SQ_PESSOA_PROFISSAO," & _
                            "PP.ID_PROFISSAO, " & _
                            "PP.DT_INICIO_ATUACAO" & _
                     " FROM TB_PESSOA_PROFISSAO PP" & _
                      " INNER JOIN TB_PROFISSAO PF ON PF.SQ_PROFISSAO = PP.ID_PROFISSAO" & _
                     " WHERE PP.ID_PESSOA = " & iSQ_PESSOA & _
                     " ORDER BY PF.NO_PROFISSAO"
          objGrid_Carregar(grdProfissao, sSqlText, New Integer() {const_GridProfissao_SQ_PESSOA_PROFISSAO, _
                                                                  const_GridProfissao_NO_PROFISSAO, _
                                                                  const_GridProfissao_DT_INICIO_ATUACAO}, True)
        End If
        'Mídia Social
        sSqlText = "SELECT PM.SQ_PESSOA_MIDIASOCIAL, " & _
                          "PM.ID_TIPO_MIDIASOCIAL," & _
                          "PM.DS_MIDIASOCIAL" & _
                   " FROM TB_PESSOA_MIDIASOCIAL PM" & _
                   " WHERE PM.ID_PESSOA = " & iSQ_PESSOA & _
                   " ORDER BY PM.DS_MIDIASOCIAL"
        objGrid_Carregar(grdMidiaSocial, sSqlText, New Integer() {const_GridMidiaSocial_SQ_PESSOA_MIDIASOCIAL, _
                                                                  const_GridMidiaSocial_TipoMidiaSocial, _
                                                                  const_GridMidiaSocial_EnderecoMidiaSocial}, True)
        'Endereço
        sSqlText = "SELECT ED.SQ_ENDERECO," & _
                          "ED.ID_TIPO_ENDERECO," & _
                          "ED.DS_LOGRADOURO," & _
                          "ED.NO_BAIRRO," & _
                          "ED.NR_LOGRADOURO," & _
                          "ED.ID_CIDADE," & _
                          "ED.CD_CEP," & _
                          "ED.DS_COMPLEMENTO," & _
                          "IIF(ED.IC_ATIVO='S', 1, 0)" & _
                   " FROM TB_ENDERECO ED" & _
                   " WHERE ED.ID_PESSOA = " & iSQ_PESSOA & _
                   " ORDER BY ED.ID_CIDADE, ED.NO_BAIRRO, ED.DS_LOGRADOURO"
        objGrid_Carregar(grdEndereco, sSqlText, New Integer() {const_GridEndereco_SQ_ENDERECO, _
                                                               const_GridEndereco_TipoEndereco, _
                                                               const_GridEndereco_Logradouro, _
                                                               const_GridEndereco_Bairro, _
                                                               const_GridEndereco_Numero, _
                                                               const_GridEndereco_Cidade, _
                                                               const_GridEndereco_CEP, _
                                                               const_GridEndereco_Complemento, _
                                                               const_GridEndereco_Ativo}, True)
        'Telefone
        sSqlText = "SELECT PT.SQ_PESSOA_TELEFONE," & _
                          "PT.ID_TIPO_TELEFONE," & _
                          "PT.CD_NUMERO," & _
                          "IIF(PT.IC_WHATSAPP = 'S', 1, 0)," & _
                          "CM_OBSERVACAO" & _
                   " FROM TB_PESSOA_TELEFONE PT" & _
                   " WHERE PT.ID_PESSOA = " & iSQ_PESSOA & _
                   " ORDER BY PT.ID_TIPO_TELEFONE, PT.CD_NUMERO"
        objGrid_Carregar(grdTelefone, sSqlText, New Integer() {const_GridTelefone_SQ_PESSOA_TELEFONE, _
                                                               const_GridTelefone_TipoTelefone, _
                                                               const_GridTelefone_Numero, _
                                                               const_GridTelefone_Whatsapp, _
                                                               const_GridTelefone_Comentario}, True)
        'Referência
        sSqlText = "SELECT PR.SQ_PESSOA_REFERENCIA," & _
                          "PR.ID_TIPO_REFERENCIAPESSOA," & _
                          "PR.NO_REFERENCIA," & _
                          "PR.CD_TELEFONE," & _
                          "PR.DS_COMENTARIO" & _
                   " FROM TB_PESSOA_REFERENCIA PR" & _
                    " INNER JOIN TB_TIPO_REFERENCIAPESSOA TF ON TF.SQ_TIPO_REFERENCIAPESSOA = PR.ID_TIPO_REFERENCIAPESSOA" & _
                   " WHERE PR.ID_PESSOA = " & iSQ_PESSOA & _
                   " ORDER BY TF.NO_TIPO_REFERENCIAPESSOA, PR.NO_REFERENCIA"
        objGrid_Carregar(grdReferencia, sSqlText, New Integer() {const_GridReferencia_SQ_PESSOA_REFERENCIA,
                                                                 const_GridReferencia_TipoReferencia,
                                                                 const_GridReferencia_Nome,
                                                                 const_GridReferencia_Telefone,
                                                                 const_GridReferencia_Complemento}, True)

        'Dados do Usuário
        sSqlText = "SELECT * FROM TB_SEG_USUARIO_EMPRESA" &
                   " WHERE ID_USUARIO = " & iSQ_PESSOA &
                     " AND ID_EMPRESA = " & iID_EMPRESA_MATRIZ
        oData = DBQuery(sSqlText)
        If oData.Rows.Count = 0 Then
          chkHabilitarUsuario.Checked = False
          chkAtivoUsuario.Checked = False
        Else
          chkHabilitarUsuario.Checked = True
          chkHabilitarUsuario.Enabled = False
          chkAtivoUsuario.Checked = (FNC_NVL(oData.Rows(0).Item("IC_ATIVO"), "N") = "S")
        End If

        sSqlText = "SELECT * FROM TB_SEG_USUARIO" &
                   " WHERE ID_USUARIO = " & iSQ_PESSOA
        oData = DBQuery(sSqlText)
        If oData.Rows.Count = 0 Then
          chkTrocarSenhaProximoAcesso.Checked = False
        Else
          chkTrocarSenhaProximoAcesso.Checked = (FNC_NVL(oData.Rows(0).Item("IC_TROCARSENHA_PROXIMOACESSO"), "N") = "S")
        End If

        sSqlText = "SELECT * FROM VW_SEG_USUARIO_GRUPOPERMISSAO" &
                   " WHERE ID_USUARIO = " & iSQ_PESSOA &
                     " AND ID_EMPRESA = " & iID_EMPRESA_MATRIZ
        oData = DBQuery(sSqlText)
        For iCont_01 = 0 To oData.Rows.Count - 1
          For iCont_02 = 0 To grdGrupoPermissao.Rows.Count - 1
            If grdGrupoPermissao.Rows(iCont_02).Cells(const_GridGrupoPermissao_SQ_GRUPOPERMISSAO).Value = oData.Rows(iCont_01).Item("ID_GRUPOPERMISSAO") Then
              grdGrupoPermissao.Rows(iCont_02).Cells(const_GridGrupoPermissao_Chk).Value = True
              Exit For
            End If
          Next
        Next

        sSqlText = "SELECT * FROM TB_PESSOA_INTEGRACAO" &
                   " WHERE ID_PESSOA = " & iSQ_PESSOA
        oData = DBQuery(sSqlText)
        For iCont_01 = 0 To oData.Rows.Count - 1
          For iCont_02 = 0 To clbProfissional_Integracao.Items.Count - 1
            If clbProfissional_Integracao.Items(iCont_02)(0) = oData.Rows(iCont_01).Item("ID_INTEGRACAO") Then
              clbProfissional_Integracao.SetItemChecked(iCont_02, True)
              Exit For
            End If
          Next
        Next
      End With

      'Dados da empresa
      sSqlText = "SELECT *" &
                 " FROM TB_PESSOA_EMPRESA" &
                 " WHERE ID_PESSOA = " & iSQ_PESSOA &
                   " AND ID_EMPRESA = " & iID_EMPRESA_MATRIZ
      oData = DBQuery(sSqlText)

      chkCliente.Checked = True

      If Not objDataTable_Vazio(oData) Then
        With oData.Rows(0)
          chkCliente.Checked = (FNC_NVL(.Item("IC_CLIENTE"), "N") = "S")
          ComboBox_Selecionar(cboCliente_TabelaPrecoPadrao, FNC_NVL(.Item("ID_CLIENTE_TABELAPRECO_PADRAO"), 0), , True)
          lblDataUltimaCompra.Text = FNC_NVL(.Item("DT_CLIENTE_ULTIMA_COMPRA"), "")
          chkCliente_Ativo.Checked = (FNC_NVL(.Item("IC_CLIENTE_ATIVO"), "N") = "S")
          chkCliente_BloquearVenda.Checked = (FNC_NVL(.Item("IC_CLIENTE_BLOQUEAR_VENDA"), "N") = "S")
          txtCliente_Comentario.Text = FNC_NVL(.Item("DS_CLIENTE_COMENTARIO"), "")

          chkFabricante.Checked = (FNC_NVL(.Item("IC_FABRICANTE"), "N") = "S")
          chkFabricante_Ativo.Checked = (FNC_NVL(.Item("IC_FABRICANTE_ATIVO"), "N") = "S")

          chkFornecedor.Checked = (FNC_NVL(.Item("IC_FORNECEDOR"), "N") = "S")
          chkFornecedor_Ativo.Checked = (FNC_NVL(.Item("IC_FORNECEDOR_ATIVO"), "N") = "S")

          chkFuncionario.Checked = (FNC_NVL(.Item("IC_FUNCIONARIO"), "N") = "S")
          chkFuncionario_Ativo.Checked = (FNC_NVL(.Item("IC_FUNCIONARIO_ATIVO"), "N") = "S")
          chkFuncionario_AcessoSistemaChamada.Checked = (FNC_NVL(.Item("IC_FUNCIONARIO_ACESSO_SISTEMACHAMADA"), "N") = "S")
          ComboBox_Selecionar(cboFuncionario_Cargo, FNC_NVL(.Item("ID_FUNCIONARIO_TIPO_CARGO"), 0))
          txtFuncionario_DataAdmissao.Value = .Item("DT_FUNCIONARIO_ADMISSAO")
          If Not FNC_CampoNulo(.Item("DT_FUNCIONARIO_DESLIGAMENTO")) Then
            txtFuncionario_DataDesligamento.Value = .Item("DT_FUNCIONARIO_DESLIGAMENTO")
          End If

          chkPaciente.Checked = (FNC_NVL(.Item("IC_PACIENTE"), "N") = "S")
          ComboBox_Selecionar(cboTipoPaciente, FNC_NVL(.Item("ID_PACIENTE_TIPO_PACIENTE"), 0), , True)
          txtPaciente_Comentario.Text = FNC_NVL(.Item("DS_PACIENTE_COMENTARIO"), "")
          txtPaciente_Pendencias.Text = FNC_NVL(.Item("DS_PACIENTE_PENDENCIAS"), "")
          chkPaciente_Ativo.Checked = (FNC_NVL(.Item("IC_PACIENTE_ATIVO"), "N") = "S")

          chkProfissional.Checked = (FNC_NVL(.Item("IC_PROFISSIONAL"), "N") = "S")
          chkProfissional_Ativo.Checked = (FNC_NVL(.Item("IC_PROFISSIONAL_ATIVO"), "N") = "S")
          chkProfissional_PrestaServicosInterno.Checked = (FNC_NVL(.Item("IC_PROFISSIONAL_SERVICO_INTERNO"), "N") = "S")
          chkProfissional_RetemImpostos.Checked = (FNC_NVL(.Item("IC_PROFISSIONAL_RETEMIMPOSTO"), "N") = "S")
          chkProfissional_RetemImpostos_GerarCP.Checked = (FNC_NVL(.Item("IC_PROFISSIONAL_RETEMIMPOSTO_GERARCP"), "N") = "S")
          txtProfissional_RetemImposto.Value = FNC_NVL(.Item("PC_PROFISSIONAL_RETEMIMPOSTO"), 0)
          ComboBox_Selecionar(cboProfissional_ConselhoProfissional, FNC_NVL(.Item("ID_PROFISSIONAL_CONSELHOPROFISSIONAL"), 0), , True)
          ComboBox_Selecionar(cboProfissional_ConselhoProfissionalUF, FNC_NVL(.Item("ID_PROFISSIONAL_CONSELHOPROFISSIONAL_UF"), 0), , True)
          txtProfissional_CBO.Text = FNC_NVL(.Item("DS_PROFISSIONAL_CBO"), "")
          txtProfissional_NrConselho.Text = FNC_NVL(.Item("NR_PROFISSIONAL_CONSELHOPROFISSIONAL"), "")

          chkTransportadora.Checked = (FNC_NVL(.Item("IC_TRANSPORTADORA"), "N") = "S")
          chkTransportadora_Ativo.Checked = (FNC_NVL(.Item("IC_TRANSPORTADORA_ATIVO"), "N") = "S")

          chkVendedor.Checked = (FNC_NVL(.Item("IC_VENDEDOR"), "N") = "S")
          chkVendedor_Ativo.Checked = (FNC_NVL(.Item("IC_VENDEDOR_ATIVO"), "N") = "S")

          chkIndicador_Ativo.Checked = (FNC_NVL(.Item("IC_INDICADOR_ATIVO"), "N") = "S")
          ComboBox_Selecionar(cboIndicador_Tipo, FNC_NVL(.Item("ID_INDICADOR_TIPOINDICADOR"), 0), , True)

          If Not FNC_CampoNulo(.Item("IC_INDICADOR_ATIVO")) Then
            txtIndicador_DtCadastro.Value = .Item("DT_INDICADOR_CADASTRO")
            txtIndicador_Codigo.Text = .Item("ID_PESSOA")
          End If
        End With
      End If

      FormatarTela_Paciente()

      'Convênio
      sSqlText = "SELECT CC.ID_PESSOA," &
                        "CC.CD_IDENTIFICACAO," &
                        "CC.DT_VALIDADE" &
                 " FROM TB_PESSOA_CONVENIO CC" &
                 " WHERE CC.ID_PESSOA = " & iSQ_PESSOA &
                   " AND CC.ID_EMPRESA = " & iID_EMPRESA_MATRIZ
      objGrid_Carregar(grdConvenio, sSqlText, New Integer() {const_GridConvenio_NomeConvenio,
                                                             const_GridConvenio_Identificacao,
                                                             const_GridConvenio_DataValidade}, True)

      'Esepecialidade
      sSqlText = "SELECT PF.ID_ESPECIALIDADE," &
                        "PF.DT_CONCLUSAO" &
                 " FROM TB_PESSOA_ESPECIALIDADE PF" &
                  " INNER JOIN TB_ESPECIALIDADE ES ON ES.SQ_ESPECIALIDADE = PF.ID_ESPECIALIDADE" &
                 " WHERE PF.ID_EMPRESA = " & iID_EMPRESA_MATRIZ &
                   " AND PF.ID_PESSOA = " & iSQ_PESSOA &
                 " ORDER BY ES.NO_ESPECIALIDADE"
      objGrid_Carregar(grdEspecialidade, sSqlText, New Integer() {const_GridEspecialidade_NomeEspecialidade,
                                                                  const_GridEspecialidade_DataConclusao}, True)

      'Exame
      sSqlText = "SELECT PROCE.SQ_PROCEDIMENTO" &
                 " FROM TB_PESSOA_PROCEDIMENTO PSPRC" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = PSPRC.ID_PROCEDIMENTO" &
                 " WHERE PSPRC.ID_PESSOA = " & iSQ_PESSOA &
                 " ORDER BY PROCE.NO_PROCEDIMENTO"
      objGrid_Carregar(grdExame, sSqlText, New Integer() {const_GridExame_NomeExame}, True)

      'Faixa Etária
      sSqlText = "SELECT PSFXE.SQ_PESSOA_FAIXAETARIA, FXETA.SQ_FAIXAETARIA" &
                 " FROM TB_PESSOA_FAIXAETARIA PSFXE" &
                  " INNER JOIN TB_FAIXAETARIA FXETA ON FXETA.SQ_FAIXAETARIA = PSFXE.ID_FAIXAETARIA" &
                  " WHERE PSFXE.ID_PESSOA = " & iSQ_PESSOA &
                  " ORDER BY FXETA.NO_FAIXAETARIA"
      objGrid_Carregar(grdFaixaEtaria, sSqlText, New Integer() {const_GridFaixaEtaria_SQ_PESSOA_FAIXAETARIA,
                                                                const_GridFaixaEtaria_NomeFaixaEtaria}, True)

      'Cidade de Atuação
      sSqlText = "SELECT TABUF.SQ_UF," &
                        "CIDAD.SQ_CIDADE," &
                        "TABUF.NO_UF," &
                        "CIDAD.NO_CIDADE" &
                 " FROM TB_PESSOAINDICADOR_CIDADE PICID" &
                   " INNER JOIN TB_CIDADE CIDAD ON CIDAD.SQ_CIDADE = PICID.ID_CIDADE" &
                   " INNER JOIN TB_UF TABUF ON TABUF.SQ_UF = CIDAD.ID_UF" &
                 " WHERE ID_EMPRESA = " & iID_EMPRESA_MATRIZ &
                 " AND ID_PESSOA = " & iSQ_PESSOA &
                 " ORDER BY TABUF.NO_UF," &
                           "CIDAD.NO_CIDADE"
      objGrid_Carregar(grdIndicador_ListagemCidadeAtuacao, sSqlText, New Integer() {const_GridIndicador_ListagemCidadeAtuacao_ID_UF,
                                                                                    const_GridIndicador_ListagemCidadeAtuacao_ID_CIDADE,
                                                                                    const_GridIndicador_ListagemCidadeAtuacao_Estado,
                                                                                    const_GridIndicador_ListagemCidadeAtuacao_Cidade})
    End If
  End Sub

  Private Sub Novo()
    picFoto.Image = Nothing

    oDBProfissao.Rows.Clear()
    oDBMidiaSocial.Rows.Clear()
    oDBEndereco.Rows.Clear()
    oDBTelefone.Rows.Clear()
    oDBReferencia.Rows.Clear()
    oDBConvenio.Rows.Clear()
    oDBEspecialidade.Rows.Clear()
    oDBGrupoPermissao.Rows.Clear()
    oDBPessoaVinculada.Rows.Clear()
    oDBExame.Rows.Clear()
    oDBFaixaEtaria.Rows.Clear()

    oProfissao_Exclusao = New Collection
    oMediaSocial_Exclusao = New Collection
    oTelefone_Exclusao = New Collection
    oConvenio_Exclusao = New Collection
    oEndereco_Exclusao = New Collection
    oReferenciaPessoal_Exclusao = New Collection
    oFaixaEtaria_Exclusao = New Collection

    'Dados Gerais
    txtNomePessoa.Text = ""
    txtDataNascAbertura.Value = Nothing
    cboTipoPessoa.SelectedIndex = -1
    txtCPF_CNPJ.Text = ""
    ComboBox_Selecionar(cboAtivo, enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode)
    cboEstadoCivil.SelectedIndex = -1
    cboNascionalidade.SelectedIndex = -1
    cboNaturalidade.SelectedIndex = -1
    cboEscolaridade.SelectedIndex = -1
    cboRaca.SelectedIndex = -1
    cboReligiao.SelectedIndex = -1
    cboSexo.SelectedIndex = -1
    cboSituacaoProfissional.SelectedIndex = -1
    cboTipoContribuicaoICMS.SelectedIndex = -1
    txtRG.Text = ""
    txtNomeReduzido.Text = ""
    txtNomeFantasia.Text = ""
    txtInscricaoEstadual.Text = ""
    txtInscricaoMunicipal.Text = ""
    psqPessoaResponsavel.ID_Pessoa = 0
    picFoto.Inicializar()
    oAnexo.iID_PESSOA = 0
    oAnexo.Carregar()

    grpDadosUsuario.Enabled = False
    chkHabilitarUsuario.Enabled = True
    chkHabilitarUsuario.Checked = False
    chkAtivoUsuario.Checked = False
    chkTrocarSenhaProximoAcesso.Checked = False

    chkCliente.Checked = False
    cboCliente_TabelaPrecoPadrao.SelectedIndex = -1
    lblDataUltimaCompra.Text = ""
    chkCliente_Ativo.Checked = False
    chkCliente_BloquearVenda.Checked = False
    txtCliente_Comentario.Text = ""

    chkFabricante.Checked = False
    chkFabricante_Ativo.Checked = False

    chkFornecedor.Checked = False
    chkFornecedor_Ativo.Checked = False

    chkFuncionario.Checked = False
    chkFuncionario_Ativo.Checked = False
    cboFuncionario_Cargo.SelectedIndex = -1
    txtFuncionario_DataAdmissao.Value = Nothing
    txtFuncionario_DataDesligamento.Value = Nothing

    chkPaciente.Checked = False
    cboTipoPaciente.SelectedIndex = -1
    txtPaciente_Comentario.Text = ""
    txtPaciente_Pendencias.Text = ""
    chkPaciente_Ativo.Checked = False

    chkProfissional.Checked = False
    chkProfissional_Ativo.Checked = False
    cboProfissional_ConselhoProfissional.SelectedIndex = -1
    cboProfissional_ConselhoProfissionalUF.SelectedIndex = -1
    chkProfissional_RetemImpostos.Checked = False
    chkProfissional_RetemImpostos_GerarCP.Checked = False
    txtProfissional_RetemImposto.Value = 0
    txtProfissional_NrConselho.Text = ""
    txtProfissional_CBO.Text = ""

    chkTransportadora.Checked = False
    chkTransportadora_Ativo.Checked = False

    chkVendedor.Checked = False
    chkVendedor_Ativo.Checked = False

    FormatarTela_Paciente()

    iSQ_PESSOA = 0
    bGravado = False
  End Sub

  Private Sub FormatarTela()
    Dim sSqlText As String

    '>> Formatar Grid
    'Mídia Social
    objGrid_Inicializar(grdMidiaSocial, AllowAddNew.FixedAddRowOnTop, oDBMidiaSocial, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdMidiaSocial, "SQ_PESSOA_MIDIASOCIAL", 0)
    objGrid_Coluna_Add(grdMidiaSocial, "Tipo de Mídia Social", 300, , True, , FNC_CarregarLista(enTipoCadastro.MidiaSocial))
    objGrid_Coluna_Add(grdMidiaSocial, "Endereço na Mídia Social", 300, , True)
    objGrid_Configuracao_Carregar(grdMidiaSocial, "grdMidiaSocial")
    'Profissão
    objGrid_Inicializar(grdProfissao, AllowAddNew.FixedAddRowOnTop, oDBProfissao, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdProfissao, "SQ_PESSOA_PROFISSAO", 0)
    objGrid_Coluna_Add(grdProfissao, "Nome da Profissão", 400, , True, , FNC_CarregarLista(enTipoCadastro.Profissao))
    objGrid_Coluna_Add(grdProfissao, "Dt. Início Atuação", 100, , True, ColumnStyle.Date)
    objGrid_Configuracao_Carregar(grdProfissao, "grdProfissao")
    'Endereço
    objGrid_Inicializar(grdEndereco, AllowAddNew.FixedAddRowOnTop, oDBEndereco, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdEndereco, "SQ_ENDERECO", 0)
    objGrid_Coluna_Add(grdEndereco, "Tipo de Endereço", 200, , True, , FNC_CarregarLista(enTipoCadastro.TipoEndereco))
    objGrid_Coluna_Add(grdEndereco, "Logradouro", 300, , True)
    objGrid_Coluna_Add(grdEndereco, "Número", 100, , True)
    objGrid_Coluna_Add(grdEndereco, "Bairro", 200, , True)
    objGrid_Coluna_Add(grdEndereco, "Cidade", 200, , True, , FNC_CarregarLista(enTipoCadastro.Cidade))
    objGrid_Coluna_Add(grdEndereco, "C.E.P.", 100, , True)
    objGrid_Coluna_Add(grdEndereco, "Complemento", 200, , True)
    objGrid_Coluna_Add(grdEndereco, "Ativo", 80, , True, ColumnStyle.CheckBox)
    objGrid_Configuracao_Carregar(grdEndereco, "grdEndereco")
    'Telefone
    objGrid_Inicializar(grdTelefone, AllowAddNew.FixedAddRowOnTop, oDBTelefone, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdTelefone, "SQ_PESSOA_TELEFONE", 0)
    objGrid_Coluna_Add(grdTelefone, "Tipo de Telefone", 300, , True, , FNC_CarregarLista(enTipoCadastro.TipoTelefone))
    objGrid_Coluna_Add(grdTelefone, "Número", 200, , True)
    objGrid_Coluna_Add(grdTelefone, "Whatsapp?", 100, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdTelefone, "Comentário", 200, , True)
    objGrid_Configuracao_Carregar(grdTelefone, "grdTelefone")
    'Convênio
    objGrid_Inicializar(grdConvenio, AllowAddNew.FixedAddRowOnTop, oDBConvenio, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdConvenio, "Nome do Convênio", 300, , True, , FNC_CarregarLista(enTipoCadastro.Convenio))
    objGrid_Coluna_Add(grdConvenio, "Identificação", 150, , True)
    objGrid_Coluna_Add(grdConvenio, "Data Validade", 200, , True, ColumnStyle.Date)
    objGrid_Configuracao_Carregar(grdConvenio, "grdConvenio")
    'Especialidade
    objGrid_Inicializar(grdEspecialidade, AllowAddNew.FixedAddRowOnTop, oDBEspecialidade, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdEspecialidade, "Nome da Especialidade", 300, , True, , FNC_CarregarLista(enTipoCadastro.Especialidade))
    objGrid_Coluna_Add(grdEspecialidade, "Data Conclusão", 200, , True, ColumnStyle.Date)
    objGrid_Configuracao_Carregar(grdEspecialidade, "grdEspecialidade")
    'Exame
    objGrid_Inicializar(grdExame, AllowAddNew.FixedAddRowOnTop, oDBExame, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdExame, "Nome do Exame", 300, , True, , FNC_CarregarLista(enTipoCadastro.Exame))
    objGrid_Configuracao_Carregar(grdExame, "grdExame")
    'Faixa Etária
    objGrid_Inicializar(grdFaixaEtaria, AllowAddNew.FixedAddRowOnTop, oDBFaixaEtaria, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdFaixaEtaria, "SQ_PESSOA_FAIXAETARIA", 0)
    objGrid_Coluna_Add(grdFaixaEtaria, "Nome do Faixa Etária", 300, , True, , FNC_CarregarLista(enTipoCadastro.FaixaEtraria))
    objGrid_Configuracao_Carregar(grdFaixaEtaria, "grdFaixaEtaria")
    'Grupo de Permissão
    objGrid_Inicializar(grdGrupoPermissao, AllowAddNew.Default, oDBGrupoPermissao, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdGrupoPermissao, "Chk", 50, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdGrupoPermissao, "SQ_GRUPOPERMISSAO", 0, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdGrupoPermissao, "Grupo de Permissão", 300)
    objGrid_Configuracao_Carregar(grdGrupoPermissao, "grdGrupoPermissao")
    'Referência
    objGrid_Inicializar(grdReferencia, AllowAddNew.FixedAddRowOnTop, oDBReferencia, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdReferencia, "SQ_PESSOA_REFERENCIA", 0)
    objGrid_Coluna_Add(grdReferencia, "Tipo de Referência", 200, , True, , FNC_CarregarLista(enTipoCadastro.TipoReferenciaPessoal, FNC_NuloZero(cboTipoPessoa.SelectedValue)))
    objGrid_Coluna_Add(grdReferencia, "Nome", 200, , True)
    objGrid_Coluna_Add(grdReferencia, "Telefone", 100, , True)
    objGrid_Coluna_Add(grdReferencia, "Complemento", 300, , True)
    'Pessoa Vinculada
    objGrid_Inicializar(grdPessoaVinculada, AllowAddNew.Default, oDBPessoaVinculada, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdPessoaVinculada, "ID_PESSOA", 50, , False, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdPessoaVinculada, "Nome da Pessoa", 300, , False)
    objGrid_Coluna_Add(grdPessoaVinculada, "Permissão de Uso de Crédito", 200, , False)
    objGrid_Configuracao_Carregar(grdPessoaVinculada, "grdPessoaVinculada")
    'Listagem Cidade Atuação
    objGrid_Inicializar(grdIndicador_ListagemCidadeAtuacao, AllowAddNew.Default, oDBIndicador_ListagemCidadeAtuacao, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdIndicador_ListagemCidadeAtuacao, "ID_UF", 0)
    objGrid_Coluna_Add(grdIndicador_ListagemCidadeAtuacao, "ID_CIDADE", 0)
    objGrid_Coluna_Add(grdIndicador_ListagemCidadeAtuacao, "U.F.", 300, , False)
    objGrid_Coluna_Add(grdIndicador_ListagemCidadeAtuacao, "Cindade", 400, , False)

    '>> Carregar combos
    ComboBox_Carregar(cboTipoPessoa, enSql.TipoPessoa)
    ComboBox_Carregar(cboEstadoCivil, enSql.EstadoCivil)
    ComboBox_Carregar(cboNascionalidade, enSql.Nacionalidade)
    ComboBox_Carregar(cboNaturalidade, enSql.Cidade)
    ComboBox_Carregar(cboEscolaridade, enSql.Escolaridade)
    ComboBox_Carregar(cboRaca, enSql.Raca)
    ComboBox_Carregar(cboReligiao, enSql.Religiao)
    ComboBox_Carregar(cboSexo, enSql.Sexo)
    ComboBox_Carregar(cboCliente_TabelaPrecoPadrao, enSql.TabelaPreco)
    ComboBox_Carregar(cboTipoPaciente, enSql.TipoPaciente)
    ComboBox_Carregar(cboSituacaoProfissional, enSql.SituacaoProfissional)
    ComboBox_Carregar(cboProfissional_ConselhoProfissional, enSql.ConselhoProfissional)
    ComboBox_Carregar(cboProfissional_ConselhoProfissionalUF, enSql.UF)
    ComboBox_Carregar(cboAtivo, enSql.AtivoInativo_Pessoal)
    ComboBox_Carregar(cboFuncionario_Cargo, enSql.TipoCargo)
    ComboBox_Carregar(cboTipoContribuicaoICMS, enSql.NFe_IndicadorIEDestinatario)
    ComboBox_Carregar(cboIndicador_Tipo, enSql.TipoIndicador)
    ComboBox_Carregar(cboIndicador_EstadoAtuacao, enSql.UF)

    '>> Escondendo controles para formatar de acordo o tipo de pessoa
    tabGeral.TabPages.Remove(tbpCliente)
    tabGeral.TabPages.Remove(tbpFabricante)
    tabGeral.TabPages.Remove(tbpFornecedor)
    tabGeral.TabPages.Remove(tbpFuncionario)
    tabGeral.TabPages.Remove(tbpProfissional)
    tabGeral.TabPages.Remove(tbpTransportadora)
    tabGeral.TabPages.Remove(tbpVendedor)
    tabDadosFisicoJuridico.TabPages.Remove(tbpReferencias)
    lblDataNascAbertura.Visible = False
    txtDataNascAbertura.Visible = False
    txtDataNascAbertura.Value = Nothing
    lblCPF_CNPJ.Visible = False
    txtCPF_CNPJ.Visible = False
    chkFuncionario.Visible = False
    chkProfissional.Visible = False
    chkVendedor.Visible = False
    tabDadosFisicoJuridico.TabPages.Remove(tbpPessoaFisica)
    tabDadosFisicoJuridico.TabPages.Remove(tbpPessoaJuridica)
    tabDadosFisicoJuridico.TabPages.Remove(tbpProfissao)
    lblDataUltimaCompra.Text = ""
    txtFuncionario_DataAdmissao.Value = Nothing
    txtFuncionario_DataDesligamento.Value = Nothing
    grpDadosUsuario.Enabled = False
    chkHabilitarUsuario.Enabled = True
    chkHabilitarUsuario.Checked = False
    chkAtivoUsuario.Checked = False
    txtSenha.Text = ""
    lblIdade.Text = ""
    lblTempoAbertura.Text = ""
    chkTrocarSenhaProximoAcesso.Checked = False
    ComboBox_Selecionar(cboAtivo, enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode)
    ComboBox_Selecionar(cboTipoContribuicaoICMS, enOpcoes.NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS.GetHashCode)
    ComboBox_TipoContribuicaoICMS_Tratar()
    txtIndicador_DtCadastro.Value = Now.Date
    txtIndicador_Codigo.Text = ""

    picFoto.SelecionarImagem = True

    FormatarTela_Paciente()

    sSqlText = "SELECT 0, SQ_GRUPOPERMISSAO, NO_GRUPOPERMISSAO" &
               " FROM TB_SEG_GRUPOPERMISSAO" &
               " WHERE ISNULL(ID_EMPRESA, " & iID_EMPRESA_MATRIZ & ") = " & iID_EMPRESA_MATRIZ &
               " ORDER BY NO_GRUPOPERMISSAO"
    objGrid_Carregar(grdGrupoPermissao, sSqlText, New Integer() {const_GridGrupoPermissao_Chk,
                                                                 const_GridGrupoPermissao_SQ_GRUPOPERMISSAO,
                                                                 const_GridGrupoPermissao_NomeGrupoPermissao})

    clbProfissional_Integracao.ValueMember = "SQ_INTEGRACAO"
    clbProfissional_Integracao.DisplayMember = "NO_INTEGRACAO"
    clbProfissional_Integracao.DataSource = DBQuery("SELECT SQ_INTEGRACAO, NO_INTEGRACAO FROM TB_INTEGRACAO ORDER BY NO_INTEGRACAO")
    clbProfissional_Integracao.Refresh()
  End Sub

  Private Function tabGeral_Index(iIndice As Integer) As Integer
    If tabGeral.TabCount < iIndice Then
      Return tabGeral.TabCount
    Else
      Return iIndice
    End If
  End Function

  Private Sub chkCliente_CheckedChanged(sender As Object, e As EventArgs) Handles chkCliente.CheckedChanged
    If chkCliente.Checked Then
      tabGeral.TabPages.Insert(1, tbpCliente)
      chkCliente_Ativo.Checked = True
    Else
      tabGeral.TabPages.Remove(tbpCliente)
    End If
  End Sub

  Private Sub chkFabricante_CheckedChanged(sender As Object, e As EventArgs) Handles chkFabricante.CheckedChanged
    If chkFabricante.Checked Then
      tabGeral.TabPages.Insert(tabGeral_Index(3), tbpFabricante)
      chkFabricante_Ativo.Checked = True
    Else
      tabGeral.TabPages.Remove(tbpFabricante)
    End If
  End Sub

  Private Sub chkFornecedor_CheckedChanged(sender As Object, e As EventArgs) Handles chkFornecedor.CheckedChanged
    If chkFornecedor.Checked Then
      tabGeral.TabPages.Insert(tabGeral_Index(4), tbpFornecedor)
      chkFornecedor_Ativo.Checked = True
    Else
      tabGeral.TabPages.Remove(tbpFornecedor)
    End If
  End Sub

  Private Sub chkFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles chkFuncionario.CheckedChanged
    If chkFuncionario.Checked Then
      tabGeral.TabPages.Insert(tabGeral_Index(5), tbpFuncionario)
      chkFuncionario_Ativo.Checked = True
    Else
      tabGeral.TabPages.Remove(tbpFuncionario)
    End If
  End Sub

  Private Sub chkMedico_CheckedChanged(sender As Object, e As EventArgs) Handles chkProfissional.CheckedChanged
    If chkProfissional.Checked Then
      tabGeral.TabPages.Insert(tabGeral_Index(6), tbpProfissional)
      chkProfissional_Ativo.Checked = True
    Else
      tabGeral.TabPages.Remove(tbpProfissional)
    End If
  End Sub

  Private Sub chkTransportadora_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransportadora.CheckedChanged
    If chkTransportadora.Checked Then
      tabGeral.TabPages.Insert(tabGeral_Index(7), tbpTransportadora)
      chkTransportadora_Ativo.Checked = True
    Else
      tabGeral.TabPages.Remove(tbpTransportadora)
    End If
  End Sub

  Private Sub chkVendedor_CheckedChanged(sender As Object, e As EventArgs) Handles chkVendedor.CheckedChanged
    If chkVendedor.Checked Then
      tabGeral.TabPages.Insert(tabGeral_Index(8), tbpVendedor)
      chkVendedor_Ativo.Checked = True
    Else
      tabGeral.TabPages.Remove(tbpVendedor)
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cboTipoPessoa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPessoa.SelectedIndexChanged
    ComboTipoPessoa_TratarSelecionado()
  End Sub

  Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPessoa.SelectedIndexChanged,
                                                                                      cboAtivo.SelectedIndexChanged,
                                                                                      cboProfissional_ConselhoProfissional.SelectedIndexChanged,
                                                                                      cboProfissional_ConselhoProfissionalUF.SelectedIndexChanged,
                                                                                      cboEscolaridade.SelectedIndexChanged,
                                                                                      cboEstadoCivil.SelectedIndexChanged,
                                                                                      cboNascionalidade.SelectedIndexChanged,
                                                                                      cboNaturalidade.SelectedIndexChanged,
                                                                                      cboRaca.SelectedIndexChanged,
                                                                                      cboReligiao.SelectedIndexChanged,
                                                                                      cboSexo.SelectedIndexChanged,
                                                                                      cboSituacaoProfissional.SelectedIndexChanged,
                                                                                      cboCliente_TabelaPrecoPadrao.SelectedIndexChanged,
                                                                                      cboTipoPaciente.SelectedIndexChanged

    sender.tag = sender.SelectedIndex
  End Sub

  Private Sub ComboTipoPessoa_TratarSelecionado()
    If bCarregado Then
      tabDadosFisicoJuridico.TabPages.Remove(tbpPessoaFisica)
      tabDadosFisicoJuridico.TabPages.Remove(tbpPessoaJuridica)
      tabDadosFisicoJuridico.TabPages.Remove(tbpProfissao)

      If cboTipoPessoa.SelectedItem Is Nothing Then
        lblDataNascAbertura.Text = ""
        lblCPF_CNPJ.Text = ""
        txtCPF_CNPJ.InputMask = ""

        lblDataNascAbertura.Visible = False
        txtDataNascAbertura.Visible = False
        lblCPF_CNPJ.Visible = False
        txtCPF_CNPJ.Visible = False
        chkFuncionario.Visible = False
        chkProfissional.Visible = False
        chkVendedor.Visible = False
      Else
        If cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode Then
          tabDadosFisicoJuridico.TabPages.Insert(0, tbpPessoaFisica)
          tabDadosFisicoJuridico.TabPages.Insert(1, tbpProfissao)
          tabDadosFisicoJuridico.SelectTab(tbpPessoaFisica)
          lblDataNascAbertura.Text = "Data de Nascimento"
          lblCPF_CNPJ.Text = "C.P.F."
          txtCPF_CNPJ.InputMask = const_Mascara_CPF
        ElseIf cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Juridico.GetHashCode Then
          tabDadosFisicoJuridico.TabPages.Insert(0, tbpPessoaJuridica)
          tabDadosFisicoJuridico.SelectTab(tbpPessoaJuridica)
          lblDataNascAbertura.Text = "Data de Abertura"
          lblCPF_CNPJ.Text = "C.N.P.J."
          txtCPF_CNPJ.InputMask = const_Mascara_CNPJ
        End If

        lblDataNascAbertura.Visible = True
        txtDataNascAbertura.Visible = True
        lblCPF_CNPJ.Visible = True
        txtCPF_CNPJ.Visible = True
        chkFuncionario.Visible = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)
        chkProfissional.Visible = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)
        chkVendedor.Visible = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)
      End If
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String
    Dim bFisicoJuridico_Fisico As Boolean
    Dim iCont As Integer

    If Not ComboBox_Selecionado(cboTipoPessoa) Then
      FNC_Mensagem("Selecione o tipo de pessoa")
      Exit Sub
    End If
    If chkProfissional_RetemImpostos.Checked And txtProfissional_RetemImposto.Value = 0 Then
      FNC_Mensagem("É preciso informar o percentual de retenção do profissional")
      Exit Sub
    End If
    If Not chkProfissional_RetemImpostos.Checked Then
      txtProfissional_RetemImposto.Value = 0
    End If

    bFisicoJuridico_Fisico = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)

    If Trim(txtNomePessoa.Text) = "" Then
      FNC_Mensagem("É preciso informar o nome da pessoa")
      Exit Sub
    End If
    If Trim(FNC_SoNumero(FNC_NVL(txtCPF_CNPJ.Text, ""))) = "" Then
      FNC_Mensagem("É preciso informar o " & lblCPF_CNPJ.Text & " da pessoa")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoPessoa) Then
      FNC_Mensagem("Selecione o tipo de pessoa")
      Exit Sub
    End If
    If bFisicoJuridico_Fisico Then
      Dim oCPF As New clsValida_CNPJ_CPF

      oCPF.cpf = txtCPF_CNPJ.Text

      If Not oCPF.isCpfValido() Then
        FNC_Mensagem("C.P.F. inválido")
        Exit Sub
      End If
    Else
      Dim oCNPJ As New clsValida_CNPJ_CPF

      oCNPJ.cnpj = txtCPF_CNPJ.Text

      If Not oCNPJ.isCnpjValido() Then
        FNC_Mensagem("C.N.P.J. inválido")
        Exit Sub
      End If
    End If

    If FNC_Busca_CPF_CNPJ_Identificar(txtCPF_CNPJ.Text, iSQ_PESSOA, IIf(FNC_In(Trim(FNC_SoNumero(txtCPF_CNPJ.Text)), "00000000000000", "00000000000"), txtNomePessoa.Text, "")) > 0 Then
      FNC_Mensagem("C.P.F./C.N.P.J. já cadastrado para outra pessoa, favor pesquisá-lo")
      Exit Sub
    End If

    Try
      If FormCadastroPessoa_GravarPessoa(iSQ_PESSOA,
                                         FNC_TextoPrimeiraMaiuscula(txtNomePessoa.Text),
                                         Nothing,
                                         FNC_NVL(txtDataNascAbertura.Value, Nothing),
                                         FNC_NVL(cboTipoPessoa.SelectedValue, 0),
                                         picFoto.ArquivoGravacao,
                                         FNC_SoNumero(txtCPF_CNPJ.Value),
                                         FNC_NVL(cboEstadoCivil.SelectedValue, 0),
                                         FNC_NVL(cboNascionalidade.SelectedValue, 0),
                                         FNC_NVL(cboEscolaridade.SelectedValue, 0),
                                         FNC_NVL(cboNaturalidade.SelectedValue, 0),
                                         FNC_NVL(cboRaca.SelectedValue, 0),
                                         FNC_NVL(cboReligiao.SelectedValue, 0),
                                         FNC_NVL(cboSexo.SelectedValue, 0),
                                         FNC_NVL(cboSituacaoProfissional.SelectedValue, 0),
                                         FNC_NVL(cboTipoContribuicaoICMS.SelectedValue, 0),
                                         psqPessoaResponsavel.ID_Pessoa,
                                         txtRG.Text,
                                         Nothing,
                                         IIf(bFisicoJuridico_Fisico, txtNomeReduzido.Text, txtNomeFantasia.Text),
                                         txtInscricaoEstadual.Text,
                                         txtInscricaoMunicipal.Text,
                                         cboAtivo.SelectedValue) Then
        If DBTeveRetorno() Then
          iSQ_PESSOA = DBRetorno(1)
        End If

        If Not FormCadastroPessoaEmpresa_GravarPessoa(iID_PESSOA:=iSQ_PESSOA,
                                                      iID_EMPRESA:=iID_EMPRESA_MATRIZ,
                                                      bIC_CLIENTE:=chkCliente.Checked,
                                                      bIC_FABRICANTE:=chkFabricante.Checked,
                                                      bIC_FORNECEDOR:=chkFornecedor.Checked,
                                                      bIC_FUNCIONARIO:=chkFuncionario.Checked,
                                                      bIC_PACIENTE:=chkPaciente.Checked,
                                                      bIC_PROFISSIONAL:=chkProfissional.Checked,
                                                      bIC_TRANSPORTADORA:=chkTransportadora.Checked,
                                                      bIC_VENDEDOR:=chkVendedor.Checked,
                                                      iID_CLIENTE_TABELAPRECO_PADRAO:=FNC_NVL(cboCliente_TabelaPrecoPadrao.SelectedValue, 0),
                                                      bIC_CLIENTE_BLOQUEAR_VENDA:=chkCliente_BloquearVenda.Checked,
                                                      bIC_CLIENTE_ATIVO:=chkCliente_Ativo.Checked,
                                                      sDS_CLIENTE_COMENTARIO:=txtCliente_Comentario.Text,
                                                      bIC_FABRICANTE_ATIVO:=chkFabricante_Ativo.Checked,
                                                      bIC_FORNECEDOR_ATIVO:=chkFornecedor_Ativo.Checked,
                                                      bIC_FORNECEDOR_PRESTADORSERVICOMEDICO:=chkFornecedor_ExameProcedimento.Checked,
                                                      sCM_FORNECEDOR_OBSERVACAO:=txtFornecedor_Observacao.Text,
                                                      iID_FUNCIONARIO_TIPO_CARGO:=FNC_NVL(cboFuncionario_Cargo.SelectedValue, 0),
                                                      dDT_FUNCIONARIO_ADMISSAO:=txtFuncionario_DataAdmissao.Value,
                                                      dDT_FUNCIONARIO_DESLIGAMENTO:=txtFuncionario_DataDesligamento.Value,
                                                      bIC_FUNCIONARIO_ATIVO:=chkFuncionario_Ativo.Checked,
                                                      bIC_FUNCIONARIO_ACESSO_SISTEMACHAMADA:=chkFuncionario_AcessoSistemaChamada.Checked,
                                                      sDS_PACIENTE_COMENTARIO:=txtPaciente_Comentario.Text,
                                                      sDS_PACIENTE_PENDENCIAS:=txtPaciente_Pendencias.Text,
                                                      iID_PACIENTE_TIPO_PACIENTE:=FNC_NVL(cboTipoPaciente.SelectedValue, 0),
                                                      bIC_PACIENTE_ATIVO:=chkPaciente_Ativo.Checked,
                                                      iID_PROFISSIONAL_CONSELHOPROFISSIONAL:=FNC_NVL(cboProfissional_ConselhoProfissional.SelectedValue, 0),
                                                      iID_PROFISSIONAL_CONSELHOPROFISSIONAL_UF:=FNC_NVL(cboProfissional_ConselhoProfissionalUF.SelectedValue, 0),
                                                      sNR_PROFISSIONAL_CONSELHOPROFISSIONAL:=txtProfissional_NrConselho.Text,
                                                      sDS_PROFISSIONAL_CBO:=txtProfissional_CBO.Text,
                                                      bIC_PROFISSIONAL_ATIVO:=chkProfissional_Ativo.Checked,
                                                      bIC_PROFISSIONAL_SERVICO_INTERNO:=chkProfissional_PrestaServicosInterno.Checked,
                                                      bIC_PROFISSIONAL_RETEMIMPOSTO:=chkProfissional_RetemImpostos.Checked,
                                                      bIC_PROFISSIONAL_RETEMIMPOSTO_GERARCP:=chkProfissional_RetemImpostos_GerarCP.Checked,
                                                      dPC_PROFISSIONAL_RETEMIMPOSTO:=txtProfissional_RetemImposto.Value,
                                                      bIC_TRANSPORTADORA_ATIVO:=chkTransportadora_Ativo.Checked,
                                                      bIC_VENDEDOR_ATIVO:=chkVendedor_Ativo.Checked,
                                                      bIC_INDICADOR_ATIVO:=chkIndicador_Ativo.Checked,
                                                      iID_INDICADOR_TIPOINDICADOR:=FNC_NVL(cboIndicador_Tipo.SelectedValue, 0),
                                                      dDT_INDICADOR_CADASTRO:=txtIndicador_DtCadastro.Value) Then GoTo Erro

        picFoto.ValidarArquivo()

        'Gravar Profissão
        For iCont = 0 To grdProfissao.Rows.Count - 1
          With grdProfissao.Rows(iCont)
            sSqlText = DBMontar_SP("SP_PESSOA_PROFISSAO_CAD", False, "@SQ_PESSOA_PROFISSAO",
                                                                     "@ID_PESSOA",
                                                                     "@ID_PROFISSAO",
                                                                     "@DT_INICIO_ATUACAO")
            If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_PROFISSAO", FNC_NVL(.Cells(const_GridProfissao_SQ_PESSOA_PROFISSAO).Value, 0)),
                                        DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_PROFISSAO", .Cells(const_GridProfissao_NO_PROFISSAO).Value),
                                        DBParametro_Montar("DT_INICIO_ATUACAO", .Cells(const_GridProfissao_DT_INICIO_ATUACAO).Value)) Then GoTo Erro
          End With
        Next
        'Gravar Mídia Social
        For iCont = 0 To grdMidiaSocial.Rows.Count - 1
          With grdMidiaSocial.Rows(iCont)
            sSqlText = DBMontar_SP("SP_PESSOA_MIDIASOCIAL_CAD", False, "@SQ_PESSOA_MIDIASOCIAL",
                                                                       "@ID_PESSOA",
                                                                       "@ID_TIPO_MIDIASOCIAL",
                                                                       "@DS_MIDIASOCIAL")
            If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_MIDIASOCIAL", FNC_NVL(.Cells(const_GridMidiaSocial_SQ_PESSOA_MIDIASOCIAL).Value, 0)),
                                        DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_TIPO_MIDIASOCIAL", .Cells(const_GridMidiaSocial_TipoMidiaSocial).Value),
                                        DBParametro_Montar("DS_MIDIASOCIAL", .Cells(const_GridMidiaSocial_EnderecoMidiaSocial).Value)) Then GoTo Erro
          End With
        Next
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
            If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_ENDERECO", FNC_NVL(.Cells(const_GridEndereco_SQ_ENDERECO).Value, 0)),
                                        DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_TIPO_ENDERECO", .Cells(const_GridEndereco_TipoEndereco).Value),
                                        DBParametro_Montar("ID_CIDADE", .Cells(const_GridEndereco_Cidade).Value),
                                        DBParametro_Montar("DS_LOGRADOURO", .Cells(const_GridEndereco_Logradouro).Value),
                                        DBParametro_Montar("NO_BAIRRO", .Cells(const_GridEndereco_Bairro).Value),
                                        DBParametro_Montar("NR_LOGRADOURO", .Cells(const_GridEndereco_Numero).Value),
                                        DBParametro_Montar("DS_COMPLEMENTO", .Cells(const_GridEndereco_Complemento).Value,,, const_BancoDados_TamanhoComentario),
                                        DBParametro_Montar("CD_CEP", .Cells(const_GridEndereco_CEP).Value),
                                        DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdEndereco, const_GridEndereco_Ativo, iCont))) Then GoTo Erro
          End With
        Next
        'Gravar Telefone
        For iCont = 0 To grdTelefone.Rows.Count - 1
          With grdTelefone.Rows(iCont)
            sSqlText = DBMontar_SP("SP_PESSOA_TELEFONE_CAD", False, "@SQ_PESSOA_TELEFONE",
                                                                    "@ID_PESSOA",
                                                                    "@ID_TIPO_TELEFONE",
                                                                    "@CD_NUMERO",
                                                                    "@IC_WHATSAPP",
                                                                    "@CM_OBSERVACAO")
            If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_TELEFONE", FNC_NVL(.Cells(const_GridTelefone_SQ_PESSOA_TELEFONE).Value, 0)),
                                        DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_TIPO_TELEFONE", .Cells(const_GridTelefone_TipoTelefone).Value),
                                        DBParametro_Montar("CD_NUMERO", .Cells(const_GridTelefone_Numero).Value),
                                        DBParametro_Montar("IC_WHATSAPP", objGrid_CheckCol_Valor(grdTelefone, const_GridTelefone_Whatsapp, iCont)),
                                        DBParametro_Montar("CM_OBSERVACAO", FNC_NuloString(.Cells(const_GridTelefone_Comentario).Value, False),,, const_BancoDados_TamanhoComentario)) Then GoTo Erro
          End With
        Next
        'Gravar Referência
        For iCont = 0 To grdReferencia.Rows.Count - 1
          With grdReferencia.Rows(iCont)
            sSqlText = DBMontar_SP("SP_PESSOA_REFERENCIA_CAD", False, "@SQ_PESSOA_REFERENCIA",
                                                                      "@ID_PESSOA",
                                                                      "@ID_TIPO_REFERENCIAPESSOA",
                                                                      "@NO_REFERENCIA",
                                                                      "@CD_TELEFONE",
                                                                      "@DS_COMENTARIO")
            If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_REFERENCIA", FNC_NVL(.Cells(const_GridReferencia_SQ_PESSOA_REFERENCIA).Value, 0)),
                                        DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_TIPO_REFERENCIAPESSOA", .Cells(const_GridReferencia_TipoReferencia).Value),
                                        DBParametro_Montar("NO_REFERENCIA", .Cells(const_GridReferencia_Nome).Value),
                                        DBParametro_Montar("CD_TELEFONE", .Cells(const_GridReferencia_Telefone).Value),
                                        DBParametro_Montar("DS_COMENTARIO", .Cells(const_GridReferencia_Complemento).Value)) Then GoTo Erro
          End With
        Next
        'Gravar Referência
        For iCont = 0 To grdFaixaEtaria.Rows.Count - 1
          With grdFaixaEtaria.Rows(iCont)
            sSqlText = DBMontar_SP("SP_PESSOA_FAIXAETARIA_CAD", False, "@SQ_PESSOA_FAIXAETARIA",
                                                                       "@ID_PESSOA",
                                                                       "@ID_FAIXAETARIA")
            If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_FAIXAETARIA", FNC_NVL(.Cells(const_GridFaixaEtaria_SQ_PESSOA_FAIXAETARIA).Value, 0)),
                                        DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_FAIXAETARIA", .Cells(const_GridFaixaEtaria_NomeFaixaEtaria).Value)) Then GoTo Erro
          End With
        Next
        If chkHabilitarUsuario.Checked Then
          sSqlText = DBMontar_SP("SP_SEG_USUARIO_CAD", False, "@ID_USUARIO",
                                                              "@ID_EMPRESA",
                                                              "@DS_SENHA",
                                                              "@IC_TROCARSENHA_PROXIMOACESSO",
                                                              "@IC_ATIVO")
          If Not DBExecutar(sSqlText, DBParametro_Montar("ID_USUARIO", iSQ_PESSOA),
                                      DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                      DBParametro_Montar("DS_SENHA", IIf(Trim(txtSenha.Text) = "", Nothing, FNC_Criptografia(txtSenha.Text))),
                                      DBParametro_Montar("IC_TROCARSENHA_PROXIMOACESSO", IIf(chkTrocarSenhaProximoAcesso.Checked, "S", "N")),
                                      DBParametro_Montar("IC_ATIVO", IIf(cboAtivo.SelectedValue = enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode, "S", "N"))) Then GoTo Erro

          For iCont = 0 To grdGrupoPermissao.Rows.Count - 1
            If objGrid_CheckBox_Selecionado(grdGrupoPermissao, const_GridGrupoPermissao_Chk, iCont) Then
              sSqlText = DBMontar_SP("SP_SEG_USUARIO_GRUPOPERMISSAO_CAD", False, "@ID_USUARIO",
                                                                                 "@ID_EMPRESA",
                                                                                 "@ID_GRUPOPERMISSAO")
              DBExecutar(sSqlText, DBParametro_Montar("ID_USUARIO", iSQ_PESSOA),
                                   DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                   DBParametro_Montar("ID_GRUPOPERMISSAO", objGrid_Valor(grdGrupoPermissao, const_GridGrupoPermissao_SQ_GRUPOPERMISSAO, iCont)))
            Else
              sSqlText = DBMontar_SP("SP_SEG_USUARIO_GRUPOPERMISSAO_DEL", False, "@ID_USUARIO",
                                                                                 "@ID_EMPRESA",
                                                                                 "@ID_GRUPOPERMISSAO")
              DBExecutar(sSqlText, DBParametro_Montar("ID_USUARIO", iSQ_PESSOA),
                                   DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                   DBParametro_Montar("ID_GRUPOPERMISSAO", objGrid_Valor(grdGrupoPermissao, const_GridGrupoPermissao_SQ_GRUPOPERMISSAO, iCont)))
            End If
          Next
        Else
          sSqlText = DBMontar_SP("SP_SEG_USUARIO_DEL", False, "@ID_USUARIO")
          If Not DBExecutar(sSqlText, DBParametro_Montar("ID_USUARIO", iSQ_PESSOA)) Then GoTo Erro
        End If

        'Gravar Convênio
        For iCont = 0 To grdConvenio.Rows.Count - 1
          With grdConvenio.Rows(iCont)
            sSqlText = DBMontar_SP("SP_PESSOA_CONVENIO_CAD", False, "@ID_PESSOA",
                                                                    "@ID_EMPRESA",
                                                                    "@ID_CONVENIO",
                                                                    "@CD_IDENTIFICACAO",
                                                                    "@DT_VALIDADE")
            If Not DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                        DBParametro_Montar("ID_CONVENIO", .Cells(const_GridConvenio_NomeConvenio).Value),
                                        DBParametro_Montar("CD_IDENTIFICACAO", .Cells(const_GridConvenio_Identificacao).Value),
                                        DBParametro_Montar("DT_VALIDADE", .Cells(const_GridConvenio_DataValidade).Value)) Then GoTo Erro
          End With
        Next
        'Gravar Especialidade
        sSqlText = DBMontar_SP("SP_PESSOA_ESPECIALIDADE_DEL", False, "@ID_PESSOA",
                                                                     "@ID_EMPRESA")
        If Not DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                    DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ)) Then GoTo Erro
        For iCont = 0 To grdEspecialidade.Rows.Count - 1
          With grdEspecialidade.Rows(iCont)
            sSqlText = DBMontar_SP("SP_PESSOA_ESPECIALIDADE_CAD", False, "@ID_PESSOA",
                                                                         "@ID_EMPRESA",
                                                                         "@ID_ESPECIALIDADE",
                                                                         "@DT_CONCLUSAO")
            If Not DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                        DBParametro_Montar("ID_ESPECIALIDADE", .Cells(const_GridEspecialidade_NomeEspecialidade).Value),
                                        DBParametro_Montar("DT_CONCLUSAO", .Cells(const_GridEspecialidade_DataConclusao).Value)) Then GoTo Erro
          End With
        Next
        'Gravar Especialidade
        sSqlText = DBMontar_SP("SP_PESSOA_PROCEDIMENTO_DEL", False, "@ID_PESSOA")
        If Not DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA)) Then GoTo Erro
        For iCont = 0 To grdExame.Rows.Count - 1
          With grdExame.Rows(iCont)
            sSqlText = DBMontar_SP("SP_PESSOA_PROCEDIMENTO_CAD", False, "@ID_PESSOA",
                                                                        "@ID_PROCEDIMENTO",
                                                                        "@IC_FAVORITO")
            If Not DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_PROCEDIMENTO", .Cells(const_GridExame_NomeExame).Value),
                                        DBParametro_Montar("IC_FAVORITO", "S")) Then GoTo Erro
          End With
        Next
        'Gravar Cidade de Atuação
        Dim sID As String

        For iCont = 0 To grdIndicador_ListagemCidadeAtuacao.Rows.Count - 1
          With grdIndicador_ListagemCidadeAtuacao.Rows(iCont)
            FNC_Str_Adicionar(sID, .Cells(const_GridIndicador_ListagemCidadeAtuacao_ID_CIDADE).Value, ",")

            sSqlText = DBMontar_SP("SP_PESSOAINDICADOR_CIDADE_CAD", False, "@ID_PESSOA",
                                                                           "@ID_EMPRESA",
                                                                           "@ID_CIDADE")
            If Not DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                        DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                        DBParametro_Montar("ID_CIDADE", .Cells(const_GridIndicador_ListagemCidadeAtuacao_ID_CIDADE).Value)) Then GoTo Erro
          End With
        Next

        sSqlText = "DELETE FROM TB_PESSOAINDICADOR_CIDADE" &
                   " WHERE ID_PESSOA = " & iSQ_PESSOA &
                     " AND ID_EMPRESA = " & iID_EMPRESA_MATRIZ

        If Trim(sID) <> "" Then
          sSqlText = sSqlText &
                       " AND ID_CIDADE NOT IN (" & sID & ")"
        End If

        DBExecutar(sSqlText)

        'Exclusão das profissões
        For iCont = 1 To oProfissao_Exclusao.Count
          If Trim(oProfissao_Exclusao(iCont)) <> "" Then
            sSqlText = "DELETE FROM TB_PESSOA_PROFISSAO" &
                       " WHERE SQ_PESSOA_PROFISSAO = " & oProfissao_Exclusao(iCont)
            If Not DBExecutar(sSqlText) Then GoTo Erro
          End If
        Next
        'Exclusão das mídias sociais
        For iCont = 1 To oMediaSocial_Exclusao.Count
          If Trim(oMediaSocial_Exclusao(iCont)) <> "" Then
            sSqlText = "DELETE FROM TB_PESSOA_MIDIASOCIAL" &
                       " WHERE SQ_PESSOA_MIDIASOCIAL = " & oMediaSocial_Exclusao(iCont)
            DBExecutar(sSqlText)
          End If
        Next
        'Exclusão dos telefones
        For iCont = 1 To oTelefone_Exclusao.Count
          If Trim(oTelefone_Exclusao(iCont)) <> "" Then
            sSqlText = "DELETE FROM TB_PESSOA_TELEFONE" &
                       " WHERE SQ_PESSOA_TELEFONE = " & oTelefone_Exclusao(iCont)
            If Not DBExecutar(sSqlText) Then GoTo Erro
          End If
        Next
        'Exclusão dos convênio
        For iCont = 1 To oConvenio_Exclusao.Count
          If Trim(oConvenio_Exclusao(iCont)) <> "" Then
            sSqlText = "DELETE FROM TB_PESSOA_CONVENIO" &
                       " WHERE ID_PESSOA = " & iSQ_PESSOA &
                         " And ID_EMPRESA = " & iID_EMPRESA_MATRIZ &
                         " And ID_CONVENIO = " & oConvenio_Exclusao(iCont)
            If Not DBExecutar(sSqlText) Then GoTo Erro
          End If
        Next
        'Exclusão dos endereço
        For iCont = 1 To oEndereco_Exclusao.Count
          If Trim(oEndereco_Exclusao(iCont)) <> "" Then
            sSqlText = "DELETE FROM TB_ENDERECO" &
                       " WHERE SQ_ENDERECO = " & oEndereco_Exclusao(iCont)
            If Not DBExecutar(sSqlText) Then GoTo Erro
          End If
        Next
        'Exclusão das referência pessoal
        For iCont = 1 To oReferenciaPessoal_Exclusao.Count
          If Trim(oReferenciaPessoal_Exclusao(iCont)) <> "" Then
            sSqlText = "DELETE FROM TB_PESSOA_REFERENCIA" &
                       " WHERE SQ_PESSOA_REFERENCIA = " & oReferenciaPessoal_Exclusao(iCont)
            If Not DBExecutar(sSqlText) Then GoTo Erro
          End If
        Next
        'Exclusão das referência pessoal
        For iCont = 1 To oFaixaEtaria_Exclusao.Count
          If Trim(oFaixaEtaria_Exclusao(iCont)) <> "" Then
            sSqlText = "DELETE FROM TB_PESSOA_FAIXAETARIA" &
                       " WHERE SQ_PESSOA_FAIXAETARIA = " & oFaixaEtaria_Exclusao(iCont)
            If Not DBExecutar(sSqlText) Then GoTo Erro
          End If
        Next

        sSqlText = "DELETE FROM TB_PESSOA_INTEGRACAO WHERE ID_PESSOA = " & iSQ_PESSOA
        DBExecutar(sSqlText)

        For iCont = 0 To clbProfissional_Integracao.SelectedItems.Count - 1
          sSqlText = "INSERT INTO TB_PESSOA_INTEGRACAO(ID_PESSOA, ID_INTEGRACAO) VALUES (" & iSQ_PESSOA & ", " & clbProfissional_Integracao.SelectedItems(iCont)(0) & ")"
          DBExecutar(sSqlText)
        Next
      Else
        GoTo Erro
      End If

      CarregarDados()

      bGravado = True

      RaiseEvent Pesquisar()

      FNC_Mensagem("Cadastro Efetuado")
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
      DBUsarTransacao = False
    End Try

    Exit Sub

Erro:
    DBUsarTransacao = False
  End Sub

  Private Sub grdProfissao_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdProfissao.BeforeRowsDeleted
    e.DisplayPromptMsg = False

    If FNC_Perguntar("Deseja realmente excluir a profissão " & e.Rows(0).Cells(const_GridProfissao_NO_PROFISSAO).Value & "?") Then
      oProfissao_Exclusao.Add(FNC_NVL(e.Rows(0).Cells(const_GridProfissao_SQ_PESSOA_PROFISSAO).Value, ""))
    Else
      e.Cancel = True
    End If
  End Sub

  Private Sub grdProfissao_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdProfissao.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridProfissao_NO_PROFISSAO).Value) Then
      FNC_Mensagem("É preciso selecionar a profissão")
      e.Cancel = True
      Exit Sub
    End If
    If objGrid_Coluna_ProcurarValor(grdProfissao, _
                                    FNC_GerarArray(const_GridProfissao_NO_PROFISSAO, e.Row.Cells(const_GridProfissao_NO_PROFISSAO).Value), _
                                    e.Row.Index) > -1 Then
      FNC_Mensagem("Profissão já cadastrada")
      e.Cancel = True
    End If
  End Sub

  Private Sub grdMidiaSocial_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdMidiaSocial.BeforeRowsDeleted
    e.DisplayPromptMsg = False
    If FNC_Perguntar("Deseja realmente excluir a mídia social " & e.Rows(0).Cells(const_GridMidiaSocial_EnderecoMidiaSocial).Value & "?") Then
      oMediaSocial_Exclusao.Add(FNC_NVL(e.Rows(0).Cells(const_GridMidiaSocial_SQ_PESSOA_MIDIASOCIAL).Value, ""))
    Else
      e.Cancel = True
    End If
  End Sub

  Private Sub grdMidiaSocial_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdMidiaSocial.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridMidiaSocial_TipoMidiaSocial).Value) Then
      FNC_Mensagem("É preciso selecionar o tipo de mídia social")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridMidiaSocial_EnderecoMidiaSocial).Value) Then
      FNC_Mensagem("É preciso informar o endereço na mídia social")
      e.Cancel = True
      Exit Sub
    End If
    If objGrid_Coluna_ProcurarValor(grdMidiaSocial, _
                                    FNC_GerarArray(const_GridMidiaSocial_TipoMidiaSocial, e.Row.Cells(const_GridMidiaSocial_TipoMidiaSocial).Value, _
                                                   const_GridMidiaSocial_EnderecoMidiaSocial, e.Row.Cells(const_GridMidiaSocial_EnderecoMidiaSocial).Value), _
                                    e.Row.Index) > -1 Then
      FNC_Mensagem("Mídia social já cadastrada")
      e.Cancel = True
    End If
  End Sub

  Private Sub grdEndereco_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdEndereco.BeforeRowsDeleted
    e.DisplayPromptMsg = False
    If FNC_Perguntar("Deseja realmente excluir o endereço " & e.Rows(0).Cells(const_GridEndereco_Logradouro).Value & "?") Then
      oEndereco_Exclusao.Add(FNC_NVL(e.Rows(0).Cells(const_GridEndereco_SQ_ENDERECO).Value, ""))
    Else
      e.Cancel = True
    End If
  End Sub

  Private Sub grdReferencia_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdReferencia.BeforeRowsDeleted
    e.DisplayPromptMsg = False
    If FNC_Perguntar("Deseja realmente excluir a referência pessoal " & e.Rows(0).Cells(const_GridReferencia_Nome).Value & "?") Then
      oReferenciaPessoal_Exclusao.Add(FNC_NVL(e.Rows(0).Cells(const_GridReferencia_SQ_PESSOA_REFERENCIA).Value, ""))
    Else
      e.Cancel = True
    End If
  End Sub

  Private Sub grdFaixaEtaria_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdFaixaEtaria.BeforeRowsDeleted
    e.DisplayPromptMsg = False
    If FNC_Perguntar("Deseja realmente excluir a faixa etária " & e.Rows(0).Cells(const_GridFaixaEtaria_NomeFaixaEtaria).Value & "?") Then
      oFaixaEtaria_Exclusao.Add(FNC_NVL(e.Rows(0).Cells(const_GridFaixaEtaria_SQ_PESSOA_FAIXAETARIA).Value, ""))
    Else
      e.Cancel = True
    End If
  End Sub

  'Private Sub grdEndereco_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdEndereco.BeforeRowUpdate
  '  If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_TipoEndereco).Value) Then
  '    FNC_Mensagem("É PRECISO SELECIONAR O TIPO DE ENDEREÇO")
  '    e.Cancel = True
  '    Exit Sub
  '  End If
  '  If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_Logradouro).Value) Then
  '    FNC_Mensagem("É PRECISO INFORMAR A DESCRIÇÃO DO LOGRADOURO")
  '    e.Cancel = True
  '    Exit Sub
  '  End If
  '  If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_Cidade).Value) Then
  '    FNC_Mensagem("É PRECISO SELECIONAR A CIDADE")
  '    e.Cancel = True
  '    Exit Sub
  '  End If
  '  If FNC_CampoNulo(e.Row.Cells(const_GridEndereco_Bairro).Value) Then
  '    FNC_Mensagem("É PRECISO SELECIONAR O BAIRRO")
  '    e.Cancel = True
  '    Exit Sub
  '  End If
  '  If objGrid_Coluna_ProcurarValor(grdConvenio,
  '                                  FNC_GerarArray(const_GridEndereco_Cidade, e.Row.Cells(const_GridEndereco_Cidade).Value,
  '                                                 const_GridEndereco_Bairro, e.Row.Cells(const_GridEndereco_Bairro).Value,
  '                                                 const_GridEndereco_Logradouro, e.Row.Cells(const_GridEndereco_Logradouro).Value,
  '                                                 const_GridEndereco_Numero, e.Row.Cells(const_GridEndereco_Numero).Value),
  '                                  e.Row.Index) > -1 Then
  '    FNC_Mensagem("ENDEREÇO JÁ CADASTRADO")
  '    e.Cancel = True
  '  End If
  'End Sub

  Private Sub grdReferencia_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdReferencia.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridReferencia_TipoReferencia).Value) Then
      FNC_Mensagem("É preciso selecionar o tipo de referência pessoal")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridReferencia_Nome).Value) Then
      FNC_Mensagem("É preciso informar o nome da referência pessoal")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridReferencia_Telefone).Value) Then
      FNC_Mensagem("É preciso informar o telefone da referência pessoal")
      e.Cancel = True
      Exit Sub
    End If
    If objGrid_Coluna_ProcurarValor(grdReferencia, _
                                    FNC_GerarArray(const_GridReferencia_TipoReferencia, e.Row.Cells(const_GridReferencia_TipoReferencia).Value, _
                                                   const_GridReferencia_Nome, e.Row.Cells(const_GridReferencia_Nome).Value), _
                                    e.Row.Index) > -1 Then
      FNC_Mensagem("Referência pessoal já cadastrada")
      e.Cancel = True
    End If
  End Sub

  Private Sub grdTelefone_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdTelefone.BeforeRowsDeleted
    e.DisplayPromptMsg = False
    If FNC_Perguntar("Deseja realmente excluir o telefone " & e.Rows(0).Cells(const_GridTelefone_Numero).Value & "?") Then
      oTelefone_Exclusao.Add(FNC_NVL(e.Rows(0).Cells(const_GridTelefone_SQ_PESSOA_TELEFONE).Value, ""))
    Else
      e.Cancel = True
    End If
  End Sub

  Private Sub grdTelefone_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdTelefone.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridTelefone_TipoTelefone).Value) Then
      FNC_Mensagem("É preciso selecionar o tipo de telefone")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridTelefone_Numero).Value) Then
      FNC_Mensagem("É preciso informar o número do telefone")
      e.Cancel = True
      Exit Sub
    End If
    If objGrid_Coluna_ProcurarValor(grdTelefone, _
                                    FNC_GerarArray(const_GridTelefone_Numero, e.Row.Cells(const_GridTelefone_Numero).Value), _
                                    e.Row.Index) > -1 Then
      FNC_Mensagem("Número já cadastrado")
      e.Cancel = True
    End If
  End Sub

  Private Sub grdConvenio_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdConvenio.BeforeRowsDeleted
    e.DisplayPromptMsg = False
    If FNC_Perguntar("Deseja realmente excluir o convênio " & e.Rows(0).Cells(const_GridConvenio_Identificacao).Value & "?") Then
      oConvenio_Exclusao.Add(FNC_NVL(e.Rows(0).Cells(const_GridConvenio_NomeConvenio).Value, ""))
    Else
      e.Cancel = True
    End If
  End Sub

  Private Sub grdConvenio_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdConvenio.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridConvenio_NomeConvenio).Value) Then
      FNC_Mensagem("É preciso selecionar o convênio")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridConvenio_Identificacao).Value) Then
      FNC_Mensagem("É preciso informar o número de identificação")
      e.Cancel = True
      Exit Sub
    End If
    If FNC_CampoNulo(e.Row.Cells(const_GridConvenio_DataValidade).Value) Then
      FNC_Mensagem("É preciso informar a data de validade")
      e.Cancel = True
      Exit Sub
    End If
    If objGrid_Coluna_ProcurarValor(grdConvenio, _
                                    FNC_GerarArray(const_GridConvenio_NomeConvenio, e.Row.Cells(const_GridConvenio_NomeConvenio).Value), _
                                    e.Row.Index) > -1 Then
      FNC_Mensagem("Convênio já cadastrado")
      e.Cancel = True
    End If
  End Sub

  Private Sub grdEspecialidade_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdEspecialidade.BeforeRowsDeleted
    e.DisplayPromptMsg = False
    If Not FNC_Perguntar("Deseja realmente excluir a especialidade " & e.Rows(0).Cells(const_GridEspecialidade_NomeEspecialidade).Text & "?") Then
      e.Cancel = True
    End If
  End Sub

  Private Sub grdEspecialidade_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdEspecialidade.BeforeRowUpdate
    If FNC_CampoNulo(e.Row.Cells(const_GridEspecialidade_NomeEspecialidade).Value) Then
      FNC_Mensagem("É preciso selecionar a especialidade")
      e.Cancel = True
      Exit Sub
    End If
    If objGrid_Coluna_ProcurarValor(grdEspecialidade,
                                    FNC_GerarArray(const_GridEspecialidade_NomeEspecialidade, e.Row.Cells(const_GridEspecialidade_NomeEspecialidade).Value),
                                    e.Row.Index) > -1 Then
      FNC_Mensagem("Especialidade já cadastrada")
      e.Cancel = True
    End If
  End Sub

  Private Sub chkPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaciente.CheckedChanged
    FormatarTela_Paciente()
  End Sub

  Private Sub FormatarTela_Paciente()
    lblRTipoPaciente.Enabled = (chkPaciente.Checked)
    cboTipoPaciente.Enabled = (chkPaciente.Checked)
    lblRComentarioPaciente.Enabled = (chkPaciente.Checked)
    txtPaciente_Comentario.Enabled = (chkPaciente.Checked)

    If Not chkPaciente.Checked Then
      cboTipoPaciente.SelectedIndex = -1
      txtPaciente_Comentario.Text = ""
    End If
  End Sub

  Private Sub txtDataNascAbertura_ValueChanged(sender As Object, e As EventArgs) Handles txtDataNascAbertura.ValueChanged
    If IsDate(txtDataNascAbertura.Text) Then
      lblIdade.Text = "Idade: " & FNC_DateDiff_Extenso(txtDataNascAbertura.DateTime.Date, Now.Date)
      lblTempoAbertura.Text = "Aberta á: " & FNC_DateDiff_Extenso(txtDataNascAbertura.DateTime.Date, Now.Date)
    Else
      lblIdade.Text = ""
      lblTempoAbertura.Text = ""
    End If
  End Sub

  Private Sub cboEstadoCivil_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEstadoCivil.KeyDown
    If e.KeyCode = Keys.Delete Then cboEstadoCivil.SelectedIndex = -1
  End Sub

  Private Sub cboRaca_KeyDown(sender As Object, e As KeyEventArgs) Handles cboRaca.KeyDown
    If e.KeyCode = Keys.Delete Then cboRaca.SelectedIndex = -1
  End Sub

  Private Sub cboEscolaridade_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEscolaridade.KeyDown
    If e.KeyCode = Keys.Delete Then cboEscolaridade.SelectedIndex = -1
  End Sub

  Private Sub cboNascionalidade_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNascionalidade.KeyDown
    If e.KeyCode = Keys.Delete Then cboNascionalidade.SelectedIndex = -1
  End Sub

  Private Sub cboNaturalidade_KeyDown(sender As Object, e As KeyEventArgs) Handles cboNaturalidade.KeyDown
    If e.KeyCode = Keys.Delete Then cboNaturalidade.SelectedIndex = -1
  End Sub

  Private Sub cboReligiao_KeyDown(sender As Object, e As KeyEventArgs) Handles cboReligiao.KeyDown
    If e.KeyCode = Keys.Delete Then cboReligiao.SelectedIndex = -1
  End Sub

  Private Sub cboSexo_KeyDown(sender As Object, e As KeyEventArgs) Handles cboSexo.KeyDown
    If e.KeyCode = Keys.Delete Then cboSexo.SelectedIndex = -1
  End Sub

  Private Sub cboSituacaoProfissional_KeyDown(sender As Object, e As KeyEventArgs) Handles cboSituacaoProfissional.KeyDown
    If e.KeyCode = Keys.Delete Then cboSituacaoProfissional.SelectedIndex = -1
  End Sub

  Private Sub TabControl_ControlAdded(sender As Object, e As ControlEventArgs) Handles tabDadosFisicoJuridico.ControlAdded, _
                                                                                       tabCliente.ControlAdded, _
                                                                                       tabGeral.ControlAdded
    ComboBox_Validar()
  End Sub

  Private Sub ComboBox_Validar()
    Try
      cboAtivo.SelectedIndex = cboAtivo.Tag
      cboProfissional_ConselhoProfissional.SelectedIndex = cboProfissional_ConselhoProfissional.Tag
      cboEscolaridade.SelectedIndex = cboEscolaridade.Tag
      cboEstadoCivil.SelectedIndex = cboEstadoCivil.Tag
      cboNascionalidade.SelectedIndex = cboNascionalidade.Tag
      cboNaturalidade.SelectedIndex = cboNaturalidade.Tag
      cboRaca.SelectedIndex = cboRaca.Tag
      cboReligiao.SelectedIndex = cboReligiao.Tag
      cboSexo.SelectedIndex = cboSexo.Tag
      cboSituacaoProfissional.SelectedIndex = cboSituacaoProfissional.Tag
      cboCliente_TabelaPrecoPadrao.SelectedIndex = cboCliente_TabelaPrecoPadrao.Tag
      cboTipoPaciente.SelectedIndex = cboTipoPaciente.Tag
    Catch ex As Exception
    End Try
  End Sub

  Private Sub cboCargoFuncionario_KeyDown(sender As Object, e As KeyEventArgs) Handles cboFuncionario_Cargo.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboFuncionario_Cargo.SelectedIndex = -1
    End If
  End Sub

  Private Sub txtCPF_CNPJ_LostFocus(sender As Object, e As EventArgs) Handles txtCPF_CNPJ.LostFocus
    Dim iRet As Integer

    iRet = FNC_Busca_CPF_CNPJ_Identificar(txtCPF_CNPJ.Text)

    If iRet <> iSQ_PESSOA And iSQ_PESSOA = 0 Then
      iSQ_PESSOA = iRet
      CarregarDados()
    Else
      If iSQ_PESSOA > 0 And FNC_SoNumero(txtCPF_CNPJ.Text).Trim() <> "" Then
        If Not FNC_Perguntar("Se deseja somente alterar o C.P.F./C.N.P.J. clique em 'Sim', caso contrário em 'Não' para começar um novo cadastro") Then
          Dim iTipoPessoa As Integer = FNC_NuloZero(cboTipoPessoa.SelectedValue)
          Dim sCPF_CNPJ As String = txtCPF_CNPJ.Text

          Novo()

          ComboBox_Selecionar(cboTipoPessoa, iTipoPessoa)
          txtCPF_CNPJ.Text = sCPF_CNPJ
        End If
      End If
    End If
  End Sub

  Private Sub chkAtivoUsuario_CheckedChanged(sender As Object, e As EventArgs) Handles chkAtivoUsuario.CheckedChanged
    If chkAtivoUsuario.Checked Then
      chkHabilitarUsuario.Checked = True
    End If
  End Sub

  Private Sub cboTipoContribuicaoICMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoContribuicaoICMS.SelectedIndexChanged
    ComboBox_TipoContribuicaoICMS_Tratar()
  End Sub

  Private Sub ComboBox_TipoContribuicaoICMS_Tratar()
    Select Case Val(cboTipoContribuicaoICMS.SelectedValue)
      Case enOpcoes.NFe_IndicadorIEDestinatario_ContribuinteICMS.GetHashCode()
        txtInscricaoEstadual.Enabled = True
      Case enOpcoes.NFe_IndicadorIEDestinatario_ContribuinteIsentoInscricaoCadastroContribuintesICMS.GetHashCode()
        txtInscricaoEstadual.Text = "ISENTO"
        txtInscricaoEstadual.Enabled = False
      Case enOpcoes.NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS.GetHashCode()
        txtInscricaoEstadual.Text = ""
        txtInscricaoEstadual.Enabled = False
    End Select
  End Sub

  Private Sub cmdPessoaVinculada_Gravar_Click(sender As Object, e As EventArgs) Handles cmdPessoaVinculada_Gravar.Click
    Dim iCont As Integer

    If psqPessoaVinculada.ID_Pessoa = 0 Then
      FNC_Mensagem("Informe a pessoa vinculada")
      Exit Sub
    End If

    For iCont = 0 To grdPessoaVinculada.Rows.Count - 1
      If objGrid_Valor(grdPessoaVinculada, const_GridPessoaVinculada_ID_PESSOA, iCont) = psqPessoaVinculada.ID_Pessoa Then
        FNC_Mensagem("Selecione uma pessoa diferente da pessoa do cadastro")
        Exit Sub
      End If
    Next
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    Novo()
  End Sub

  Private Sub chkHabilitarUsuario_CheckedChanged(sender As Object, e As EventArgs) Handles chkHabilitarUsuario.CheckedChanged
    grpDadosUsuario.Enabled = chkHabilitarUsuario.Checked
  End Sub

  Private Sub frmCadastroPessoa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdMidiaSocial, "grdMidiaSocial")
    objGrid_Configuracao_Gravar(grdProfissao, "grdProfissao")
    objGrid_Configuracao_Gravar(grdEndereco, "grdEndereco")
    objGrid_Configuracao_Gravar(grdTelefone, "grdTelefone")
    objGrid_Configuracao_Gravar(grdConvenio, "grdConvenio")
    objGrid_Configuracao_Gravar(grdEspecialidade, "grdEspecialidade")
    objGrid_Configuracao_Gravar(grdGrupoPermissao, "grdGrupoPermissao")
    objGrid_Configuracao_Gravar(grdPessoaVinculada, "grdPessoaVinculada")
  End Sub

  Private Sub cboIndicador_EstadoAtuacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIndicador_EstadoAtuacao.SelectedIndexChanged
    ComboBox_Carregar(cboIndicador_CidadeAtuacao, enSql.Cidade, New Object() {FNC_NVL(cboIndicador_EstadoAtuacao.SelectedValue, 0)})
  End Sub

  Private Sub cmdIndicador_Gravar_Click(sender As Object, e As EventArgs) Handles cmdIndicador_Gravar.Click
    If Not ComboBox_Selecionado(cboIndicador_EstadoAtuacao) Then
      FNC_Mensagem("Selecione o Estado de atuação do Indicador")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboIndicador_EstadoAtuacao) Then
      FNC_Mensagem("Selecione a cidade de atuação do Indicador")
      Exit Sub
    End If

    Dim iCont As Integer

    For iCont = 0 To grdIndicador_ListagemCidadeAtuacao.Rows.Count - 1
      If objGrid_Valor(grdIndicador_ListagemCidadeAtuacao, const_GridIndicador_ListagemCidadeAtuacao_ID_UF, iCont) = cboIndicador_EstadoAtuacao.SelectedValue And
         objGrid_Valor(grdIndicador_ListagemCidadeAtuacao, const_GridIndicador_ListagemCidadeAtuacao_ID_CIDADE, iCont) = cboIndicador_CidadeAtuacao.SelectedValue Then
        FNC_Mensagem("Cidade de atuação já adicionada")
        Exit Sub
      End If
    Next

    objGrid_Linha_Add(grdIndicador_ListagemCidadeAtuacao, New Object() {const_GridIndicador_ListagemCidadeAtuacao_ID_UF, cboIndicador_EstadoAtuacao.SelectedValue,
                                                                        const_GridIndicador_ListagemCidadeAtuacao_ID_CIDADE, cboIndicador_CidadeAtuacao.SelectedValue,
                                                                        const_GridIndicador_ListagemCidadeAtuacao_Estado, cboIndicador_EstadoAtuacao.SelectedItem(1),
                                                                        const_GridIndicador_ListagemCidadeAtuacao_Cidade, cboIndicador_CidadeAtuacao.SelectedItem(1)})
  End Sub

  Private Sub cmdIndicador_Excluir_Click(sender As Object, e As EventArgs) Handles cmdIndicador_Excluir.Click
    If objGrid_LinhaSelecionada(grdIndicador_ListagemCidadeAtuacao) = -1 Then
      FNC_Mensagem("Selecione a cidade a ser excluída")
      Exit Sub
    End If

    objGrid_ExcluirLinha(grdIndicador_ListagemCidadeAtuacao)
  End Sub
End Class