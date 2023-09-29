Public Class frmCadastroEmpresa
  Public bConfiguracaoInicial As Boolean = False
  Public bGravacaoEfetuada As Boolean = False

  Dim iSQ_ENDERECO As Integer
  Dim iSQ_PESSOA_TELEFONE As Integer
  Dim iSQ_PESSOA_MIDIASOCIAL_EMAIL As Integer
  Dim iSQ_PESSOA_MIDIASOCIAL_WEBSITE As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT PES.NO_PESSOA," &
                      "dbo.FC_FormatarCPF_CNPJ(PES.CD_CPF_CNPJ) CD_CPF_CNPJ," &
                      "PES.NO_FANTASIA_REDUZIDO," &
                      "PES.DT_NASC_ABERTURA," &
                      "PES.CD_PJ_IE," &
                      "PES.CD_PJ_IM," &
                      "EMP.ID_TABELAPRECO_PADRAO," &
                      "EMP.DS_PATH_REPOSITORIO_ARQUIVO," &
                      "PES.DS_PATH_IMAGEM," &
                      "EML.SQ_PESSOA_MIDIASOCIAL SQ_PESSOA_MIDIASOCIAL_EMAIL," &
                      "WBS.SQ_PESSOA_MIDIASOCIAL SQ_PESSOA_MIDIASOCIAL_WEBSITE," &
                      "EML.DS_MIDIASOCIAL DS_MIDIASOCIAL_EMAIL," &
                      "WBS.DS_MIDIASOCIAL DS_MIDIASOCIAL_WEBSITE," &
                      "EMP.ID_TRANSACAOESTOQUE_PADRAO_COMPRAS," &
                      "EMP.ID_TRANSACAOESTOQUE_PADRAO_VENDAS," &
                      "EMP.ID_PLANOCONTAS_PADRAO_RECEBIMENTO," &
                      "EMP.ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO," &
                      "EMP.ID_MODELODOCUMENTO_RECEITA_PADRAO," &
                      "EMP.ID_SEGMENTO_CRCP_PADRAO," &
                      "EMP.ID_CANALNEGOCIO_PADRAO_VENDA," &
                      "EMP.ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO," &
                      "EMP.ID_CONDICAOPAGAMENTO_VENDA_PADRAO," &
                      "EMP.ID_TIPO_DOCUMENTO_PADRAO_VENDA," &
                      "PES.ID_OPT_PJ_CONTRIBUICAO_ICMS," &
                      "EMP.ID_PESSOA_RESPONSAVEL," &
                      "EMP.ID_PESSOA_RESPONSAVELTECNICO," &
                      "EMP.ID_PESSOA_RESPONSAVELCONTABIL," &
                      "EMP.ID_CONTAFINANCEIRA_PADRAO_VENDA," &
                      "EMP.ID_CONTAFINANCEIRA_TESOURARIA," &
                      "EMP.ID_CONVENIO_PADRAO," &
                      "EMP.NR_CASASDECIMAIS_VALORES," &
                      "EMP.NR_DIA_VALIDADEORCAMENTO," &
                      "EMP.NR_DIA_VALIDADEPEDIDO," &
                      "EMP.NR_DIA_PAGTO_PRESTADORSERVICOMEDICO," &
                      "EMP.IC_NOME_FANTASIA_RELATORIOS," &
                      "EMP.CADASTROTELEFONE_DDD_PADRAO," &
                      "EMP.CD_CNAE," &
                      "EMP.IC_QUITAR_PROVISIONADO," &
                      "EMP.IC_PROVISIONADO_POR_PADRAO," &
                      "EMP.IC_DIAUTIL_DOM," &
                      "EMP.IC_DIAUTIL_SEG," &
                      "EMP.IC_DIAUTIL_TER," &
                      "EMP.IC_DIAUTIL_QUA," &
                      "EMP.IC_DIAUTIL_QUI," &
                      "EMP.IC_DIAUTIL_SEX," &
                      "EMP.IC_DIAUTIL_SAB," &
                      "EMP.DS_RODAPE_RELATORIO," &
                      "EMP.DS_MENSAGEM_IMPRESSAO_SENHA," &
                      "EMP.ID_PESSOA_RESPONSAVEL_IMPOSTORETIDO," &
                      "EMP.ID_PLANOCONTAS_PADRAO_IMPOSTORETIDO," &
                      "EMP.ID_CONTAFINANCEIRA_IMPOSTORETIDO," &
                      "EMP.ID_PLANOCONTAS_PADRAO_DEVOLUCAO" &
               " FROM TB_PESSOA PES" &
                " INNER JOIN TB_EMPRESA EMP ON EMP.ID_EMPRESA = PES.SQ_PESSOA" &
                 " LEFT JOIN VW_PESSOA_MIDIASOCIAL_EMAIL EML ON EML.ID_PESSOA = PES.SQ_PESSOA" &
                 " LEFT JOIN VW_PESSOA_MIDIASOCIAL_WEBSITE WBS ON WBS.ID_PESSOA = PES.SQ_PESSOA" &
               " WHERE PES.SQ_PESSOA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    If oData.Rows.Count > 0 Then
      With oData.Rows(0)
        oCadEmpresa.txtRazaoSocial.Text = .Item("NO_PESSOA")
        oCadEmpresa.txtCNPJ.Text = .Item("CD_CPF_CNPJ")
        oCadEmpresa.txtNomeFantasia.Text = FNC_NVL(.Item("NO_FANTASIA_REDUZIDO"), "")
        If Not FNC_CampoNulo(.Item("DT_NASC_ABERTURA")) Then
          oCadEmpresa.txtDataAbertura.Value = .Item("DT_NASC_ABERTURA")
        End If
        oCadEmpresa.txtInscricaoEstadual.Text = FNC_NVL(.Item("CD_PJ_IE"), "")
        oCadEmpresa.txtInscricaoMunicipal.Text = FNC_NVL(.Item("CD_PJ_IM"), "")
        oCadEmpresa.txtDiretorio.Text = FNC_NVL(.Item("DS_PATH_REPOSITORIO_ARQUIVO"), "")
        txtEMail.Text = FNC_NVL(.Item("DS_MIDIASOCIAL_EMAIL"), "")
        txtWebSite.Text = FNC_NVL(.Item("DS_MIDIASOCIAL_WEBSITE"), "")
        txtNrCasasDecimaisValores.Value = FNC_NVL(.Item("NR_CASASDECIMAIS_VALORES"), 4)
        txtNrDiaPagtoPrestadorServicoMedicoExterno.Value = FNC_NVL(.Item("NR_DIA_PAGTO_PRESTADORSERVICOMEDICO"), 0)
        txtDDDPadrao_CadastroTelefonico.Text = FNC_NVL(.Item("CADASTROTELEFONE_DDD_PADRAO"), "")
        iSQ_PESSOA_MIDIASOCIAL_EMAIL = FNC_NVL(.Item("SQ_PESSOA_MIDIASOCIAL_EMAIL"), 0)
        iSQ_PESSOA_MIDIASOCIAL_WEBSITE = FNC_NVL(.Item("SQ_PESSOA_MIDIASOCIAL_WEBSITE"), 0)
        oCadEmpresa.picLogotipo.Arquivo = .Item("DS_PATH_IMAGEM")
        chkUsarNomeReduzidoPessoasRelatorios.Checked = (FNC_NVL(.Item("IC_NOME_FANTASIA_RELATORIOS"), "N") = "S")
        chkQuitarProvisionado.Checked = (FNC_NVL(.Item("IC_QUITAR_PROVISIONADO"), "N") = "S")
        chkProvisionarPadrao.Checked = (FNC_NVL(.Item("IC_PROVISIONADO_POR_PADRAO"), "N") = "S")

        psqPessoaResponsavel.ID_Pessoa = FNC_NVL(.Item("ID_PESSOA_RESPONSAVEL"), 0)
        psqPessoaResponsavelTecnico.ID_Pessoa = FNC_NVL(.Item("ID_PESSOA_RESPONSAVELTECNICO"), 0)
        psqPessoaResponsavelContabil.ID_Pessoa = FNC_NVL(.Item("ID_PESSOA_RESPONSAVELCONTABIL"), 0)
        psqPessoaLancamentoImpostoRetido.ID_Pessoa = FNC_NVL(.Item("ID_PESSOA_RESPONSAVEL_IMPOSTORETIDO"), 0)

        ComboBox_Selecionar(cboTabelaPrecoPadrao, .Item("ID_TABELAPRECO_PADRAO"))
        ComboBox_Selecionar(cboTransacaoEstoque_Padrao_Recebimentos, .Item("ID_TRANSACAOESTOQUE_PADRAO_COMPRAS"))
        ComboBox_Selecionar(cboTransacaoEstoque_Padrao_Vendas, .Item("ID_TRANSACAOESTOQUE_PADRAO_VENDAS"))
        ComboBox_Selecionar(cboPlanoContasPadraoRecebimentos, .Item("ID_PLANOCONTAS_PADRAO_RECEBIMENTO"))
        ComboBox_Selecionar(cboPlanoContasPadraoTaxaCompensacao, .Item("ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO"))
        ComboBox_Selecionar(cboModeloReciboPadrao, .Item("ID_MODELODOCUMENTO_RECEITA_PADRAO"))
        ComboBox_Selecionar(cboSegmentoCRCPPadrao, .Item("ID_SEGMENTO_CRCP_PADRAO"))
        ComboBox_Selecionar(cboConvenioPadrao, .Item("ID_CONVENIO_PADRAO"))
        ComboBox_Selecionar(cboCondicaoPagamentoPadraoRecebimento, .Item("ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO"))
        ComboBox_Selecionar(cboCondicaoPagamentoPadraoVenda, .Item("ID_CONDICAOPAGAMENTO_VENDA_PADRAO"))
        ComboBox_Selecionar(cboTipoDocumentoPadraoVenda, .Item("ID_TIPO_DOCUMENTO_PADRAO_VENDA"))
        ComboBox_Selecionar(oCadEmpresa.cboTipoContribuicaoICMS, .Item("ID_OPT_PJ_CONTRIBUICAO_ICMS"))
        ComboBox_Selecionar(cboContaFinanceiraPadraoVenda, .Item("ID_CONTAFINANCEIRA_PADRAO_VENDA"))
        ComboBox_Selecionar(cboContaFinanceiraTesouraria, .Item("ID_CONTAFINANCEIRA_TESOURARIA"))
        ComboBox_Selecionar(cboPlanoContasPadraoImpostoRetido, .Item("ID_PLANOCONTAS_PADRAO_IMPOSTORETIDO"))
        ComboBox_Selecionar(cboContaFinanceiraPadraoImpostoRetido, .Item("ID_CONTAFINANCEIRA_IMPOSTORETIDO"))
        ComboBox_Selecionar(cboPlanoContasPadraoDevolucao, .Item("ID_PLANOCONTAS_PADRAO_DEVOLUCAO"))

        oCadEmpresa.chkDiaUtil_Dom.Checked = (FNC_NVL(.Item("IC_DIAUTIL_DOM"), "N") = "S")
        oCadEmpresa.chkDiaUtil_Seg.Checked = (FNC_NVL(.Item("IC_DIAUTIL_SEG"), "N") = "S")
        oCadEmpresa.chkDiaUtil_Ter.Checked = (FNC_NVL(.Item("IC_DIAUTIL_TER"), "N") = "S")
        oCadEmpresa.chkDiaUtil_Qua.Checked = (FNC_NVL(.Item("IC_DIAUTIL_QUA"), "N") = "S")
        oCadEmpresa.chkDiaUtil_Qui.Checked = (FNC_NVL(.Item("IC_DIAUTIL_QUI"), "N") = "S")
        oCadEmpresa.chkDiaUtil_Sex.Checked = (FNC_NVL(.Item("IC_DIAUTIL_SEX"), "N") = "S")
        oCadEmpresa.chkDiaUtil_Sab.Checked = (FNC_NVL(.Item("IC_DIAUTIL_SAB"), "N") = "S")

        rtbRodapeRelatorio.Text = FNC_NuloString(.Item("DS_RODAPE_RELATORIO"), False)
        txtMensagemSenha.Text = FNC_NuloString(.Item("DS_MENSAGEM_IMPRESSAO_SENHA"), False)
      End With

      sSqlText = "SELECT * " &
                 " FROM TB_ENDERECO" &
                 " WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL &
                   " AND ID_TIPO_ENDERECO = " & enTipoEndereco.Comercial.GetHashCode
      oData = DBQuery(sSqlText)

      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          iSQ_ENDERECO = .Item("SQ_ENDERECO")
          txtLogradouro.Text = FNC_NVL(.Item("DS_LOGRADOURO"), "")
          txtBairro.Text = FNC_NVL(.Item("NO_BAIRRO"), "")
          ComboBox_Selecionar(cboCidade, .Item("ID_CIDADE"))
          If Not FNC_CampoNulo(.Item("NR_LOGRADOURO")) Then txtNumero.Value = .Item("NR_LOGRADOURO")
          If Not FNC_CampoNulo(.Item("CD_CEP")) Then txtCEP.Value = .Item("CD_CEP")
          txtComplementoEndereco.Text = FNC_NVL(.Item("DS_COMPLEMENTO"), "")
        End With
      End If

      sSqlText = "SELECT * " &
                 " FROM TB_PESSOA_TELEFONE" &
                 " WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL &
                    "AND ID_TIPO_TELEFONE = " & enTipoTelefone.Comercial.GetHashCode
      oData = DBQuery(sSqlText)

      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          iSQ_PESSOA_TELEFONE = .Item("SQ_PESSOA_TELEFONE")
          oCadEmpresa.txtTelefone.Text = FNC_NVL(.Item("CD_NUMERO"), "")
        End With
      End If
    End If
  End Sub

  Private Sub frmCadastroEmpresa_Load(sender As Object, e As EventArgs) Handles Me.Load
    oCadEmpresa.Formatar()
    ComboBox_Carregar(cboTabelaPrecoPadrao, enSql.TabelaPreco)
    ComboBox_Carregar(cboCidade, enSql.Cidade)
    ComboBox_Carregar(cboTransacaoEstoque_Padrao_Recebimentos, enSql.TransacaoEstoque_Recebimento)
    ComboBox_Carregar(cboTransacaoEstoque_Padrao_Vendas, enSql.TransacaoEstoque_Venda)
    ComboBox_Carregar(cboPlanoContasPadraoRecebimentos, enSql.PlanoContas_Credito)
    ComboBox_Carregar(cboPlanoContasPadraoTaxaCompensacao, enSql.PlanoContas_Debito)
    ComboBox_Carregar(cboModeloReciboPadrao, enSql.ModeloDocumento_Recibo)
    ComboBox_Carregar(cboSegmentoCRCPPadrao, enSql.Segmento_ContasReceberContasPagar)
    ComboBox_Carregar(cboConvenioPadrao, enSql.Convenio)
    ComboBox_Carregar(cboCondicaoPagamentoPadraoRecebimento, enSql.CondicaoPagamento_Recebimento)
    ComboBox_Carregar(cboCondicaoPagamentoPadraoVenda, enSql.CondicaoPagamento_Venda)
    ComboBox_Carregar(cboTipoDocumentoPadraoVenda, enSql.TipoDocumento, New Object() {enOpcoes.TipoUtilizacaoLançamentoFinanceiro_UsarLancamento.GetHashCode()})
    ComboBox_Carregar(cboContaFinanceiraPadraoVenda, enSql.ContaCaixa, , True)
    ComboBox_Carregar(cboContaFinanceiraTesouraria, enSql.ContaCaixa, , True)
    ComboBox_Carregar(cboContaFinanceiraPadraoImpostoRetido, enSql.ContaCaixa, , True)
    ComboBox_Carregar(cboPlanoContasPadraoImpostoRetido, enSql.PlanoContas_Debito)
    ComboBox_Carregar(cboPlanoContasPadraoDevolucao, enSql.PlanoContas_Debito)

    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroEmpresa).bGravar

    oCadEmpresa.bConfiguracaoInicial = bConfiguracaoInicial

    If iID_EMPRESA_FILIAL > 0 Then
      CarregarDados()
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String

    If Trim(oCadEmpresa.txtRazaoSocial.Text) = "" Then
      FNC_Mensagem("Informe o nome da razão social")
      Exit Sub
    End If
    If FNC_SoNumero(oCadEmpresa.txtCNPJ.Text).Replace("0", "").Trim() = "" Then
      FNC_Mensagem("Informe o C.N.P.J.")
      Exit Sub
    End If
    If Trim(oCadEmpresa.txtNomeFantasia.Text) = "" Then
      FNC_Mensagem("Informe o nome de fantasia")
      Exit Sub
    End If
    If Not IsDate(oCadEmpresa.txtDataAbertura.Text) Then
      FNC_Mensagem("Informe a data de abertura")
      Exit Sub
    End If
    If Not IsDate(oCadEmpresa.txtDataAbertura.Text) Then
      FNC_Mensagem("Informe a data de abertura")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboCidade) Then
      FNC_Mensagem("Informe o endereço da empresa")
      Exit Sub
    End If
    If Trim(txtLogradouro.Text) <> "" Or Trim(txtBairro.Text) <> "" Or ComboBox_Selecionado(cboCidade) Or Trim(FNC_SoNumero(txtCEP.Text)) <> "" Then
      If Trim(txtLogradouro.Text) = "" Or Trim(txtBairro.Text) = "" Or Not ComboBox_Selecionado(cboCidade) Or Trim(FNC_SoNumero(txtCEP.Text)) = "" Then
        FNC_Mensagem("Se for informar o endereço é necessário informar completo")
        Exit Sub
      End If
    End If
    If Not oCadEmpresa.picLogotipo.Image Is Nothing Then
      If Trim(oCadEmpresa.txtDiretorio.Text) = "" Then
        FNC_Mensagem("É preciso informar o diretório de Imagens e Arquivos para poder salvar o logotipo")
        Exit Sub
      End If
    End If

    sPathRepositorioArquivo = oCadEmpresa.txtDiretorio.Text

    DBUsarTransacao = True

    If FormCadastroPessoa_GravarPessoa(iID_EMPRESA_FILIAL,
                                       FNC_TextoPrimeiraMaiuscula(oCadEmpresa.txtRazaoSocial.Text),
                                       Nothing,
                                       oCadEmpresa.txtDataAbertura.Value,
                                       enTipoPessoa.Juridica.GetHashCode,
                                       oCadEmpresa.picLogotipo.ArquivoGravacao,
                                       FNC_SoNumero(oCadEmpresa.txtCNPJ.Value),
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       oCadEmpresa.txtNomeFantasia.Text,
                                       oCadEmpresa.txtInscricaoEstadual.Text,
                                       oCadEmpresa.txtInscricaoMunicipal.Text,
                                       enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode) Then
      If DBTeveRetorno() Then
        iID_EMPRESA_FILIAL = DBRetorno(1)
      End If

      If iID_EMPRESA_FILIAL > 0 Then
        sSqlText = DBMontar_SP("SP_EMPRESA_CAD", False, "@ID_EMPRESA",
                                                        "@ID_TABELAPRECO_PADRAO",
                                                        "@ID_TRANSACAOESTOQUE_PADRAO_COMPRAS",
                                                        "@ID_TRANSACAOESTOQUE_PADRAO_VENDAS",
                                                        "@ID_EMPRESA_MATRIZ",
                                                        "@ID_PLANOCONTAS_PADRAO_RECEBIMENTO",
                                                        "@ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO",
                                                        "@ID_MODELODOCUMENTO_RECIBO_PADRAO",
                                                        "@ID_SEGMENTO_CRCP_PADRAO",
                                                        "@ID_CANALNEGOCIO_PADRAO_VENDA",
                                                        "@ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO",
                                                        "@ID_CONDICAOPAGAMENTO_VENDA_PADRAO",
                                                        "@ID_TIPO_DOCUMENTO_PADRAO_VENDA",
                                                        "@ID_CONTAFINANCEIRA_PADRAO_VENDA",
                                                        "@ID_CONTAFINANCEIRA_TESOURARIA",
                                                        "@ID_PESSOA_RESPONSAVEL",
                                                        "@ID_PESSOA_RESPONSAVELTECNICO",
                                                        "@ID_PESSOA_RESPONSAVELCONTABIL",
                                                        "@ID_CONVENIO_PADRAO",
                                                        "@DS_PATH_REPOSITORIO_ARQUIVO",
                                                        "@CADASTROTELEFONE_DDD_PADRAO",
                                                        "@NR_CASASDECIMAIS_VALORES",
                                                        "@NR_DIA_VALIDADEORCAMENTO",
                                                        "@NR_DIA_VALIDADEPEDIDO",
                                                        "@NR_DIA_PAGTO_PRESTADORSERVICOMEDICO",
                                                        "@IC_NOME_FANTASIA_RELATORIOS",
                                                        "@IC_QUITAR_PROVISIONADO",
                                                        "@IC_PROVISIONADO_POR_PADRAO",
                                                        "@IM_LOGOTIPO",
                                                        "@IC_DIAUTIL_DOM",
                                                        "@IC_DIAUTIL_SEG",
                                                        "@IC_DIAUTIL_TER",
                                                        "@IC_DIAUTIL_QUA",
                                                        "@IC_DIAUTIL_QUI",
                                                        "@IC_DIAUTIL_SEX",
                                                        "@IC_DIAUTIL_SAB",
                                                        "@DS_RODAPE_RELATORIO",
                                                        "@DS_MENSAGEM_IMPRESSAO_SENHA",
                                                        "@ID_PLANOCONTAS_PADRAO_IMPOSTORETIDO",
                                                        "@ID_PESSOA_RESPONSAVEL_IMPOSTORETIDO",
                                                        "@ID_CONTAFINANCEIRA_IMPOSTORETIDO",
                                                        "@ID_PLANOCONTAS_PADRAO_DEVOLUCAO")
        DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                             DBParametro_Montar("ID_TABELAPRECO_PADRAO", cboTabelaPrecoPadrao.SelectedValue),
                             DBParametro_Montar("ID_TRANSACAOESTOQUE_PADRAO_COMPRAS", cboTransacaoEstoque_Padrao_Recebimentos.SelectedValue),
                             DBParametro_Montar("ID_TRANSACAOESTOQUE_PADRAO_VENDAS", cboTransacaoEstoque_Padrao_Vendas.SelectedValue),
                             DBParametro_Montar("ID_EMPRESA_MATRIZ", iID_EMPRESA_MATRIZ),
                             DBParametro_Montar("ID_PLANOCONTAS_PADRAO_RECEBIMENTO", cboPlanoContasPadraoRecebimentos.SelectedValue),
                             DBParametro_Montar("ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO", cboPlanoContasPadraoTaxaCompensacao.SelectedValue),
                             DBParametro_Montar("ID_MODELODOCUMENTO_RECIBO_PADRAO", cboModeloReciboPadrao.SelectedValue),
                             DBParametro_Montar("ID_SEGMENTO_CRCP_PADRAO", cboSegmentoCRCPPadrao.SelectedValue),
                             DBParametro_Montar("ID_CANALNEGOCIO_PADRAO_VENDA", Nothing),
                             DBParametro_Montar("ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO", cboCondicaoPagamentoPadraoRecebimento.SelectedValue),
                             DBParametro_Montar("ID_CONDICAOPAGAMENTO_VENDA_PADRAO", cboCondicaoPagamentoPadraoVenda.SelectedValue),
                             DBParametro_Montar("ID_TIPO_DOCUMENTO_PADRAO_VENDA", cboTipoDocumentoPadraoVenda.SelectedValue),
                             DBParametro_Montar("ID_CONTAFINANCEIRA_PADRAO_VENDA", cboContaFinanceiraPadraoVenda.SelectedValue),
                             DBParametro_Montar("ID_CONTAFINANCEIRA_TESOURARIA", cboContaFinanceiraTesouraria.SelectedValue),
                             DBParametro_Montar("ID_PESSOA_RESPONSAVEL", FNC_NuloZero(psqPessoaResponsavel.ID_Pessoa, False)),
                             DBParametro_Montar("ID_PESSOA_RESPONSAVELTECNICO", FNC_NuloZero(psqPessoaResponsavelTecnico.ID_Pessoa, False)),
                             DBParametro_Montar("ID_PESSOA_RESPONSAVELCONTABIL", FNC_NuloZero(psqPessoaResponsavelContabil.ID_Pessoa, False)),
                             DBParametro_Montar("ID_CONVENIO_PADRAO", cboConvenioPadrao.SelectedValue),
                             DBParametro_Montar("DS_PATH_REPOSITORIO_ARQUIVO", FNC_NuloSe(oCadEmpresa.txtDiretorio.Text, "")),
                             DBParametro_Montar("CADASTROTELEFONE_DDD_PADRAO", FNC_NuloString(txtDDDPadrao_CadastroTelefonico.Text, False)),
                             DBParametro_Montar("NR_CASASDECIMAIS_VALORES", FNC_NVL(txtNrCasasDecimaisValores.Value, 4)),
                             DBParametro_Montar("NR_DIA_VALIDADEORCAMENTO", FNC_NVL(txtDiasValidadeOrcamento.Value, 30)),
                             DBParametro_Montar("NR_DIA_VALIDADEPEDIDO", FNC_NVL(txtDiasValidadePedido.Value, 30)),
                             DBParametro_Montar("NR_DIA_PAGTO_PRESTADORSERVICOMEDICO", FNC_NVL(txtNrDiaPagtoPrestadorServicoMedicoExterno.Value, 30)),
                             DBParametro_Montar("IC_NOME_FANTASIA_RELATORIOS", IIf(chkUsarNomeReduzidoPessoasRelatorios.Checked, "S", "N")),
                             DBParametro_Montar("IC_QUITAR_PROVISIONADO", IIf(chkQuitarProvisionado.Checked, "S", "N")),
                             DBParametro_Montar("IC_PROVISIONADO_POR_PADRAO", IIf(chkProvisionarPadrao.Checked, "S", "N")),
                             DBParametro_Montar("IM_LOGOTIPO", FNC_Image_Para_ImageDB(oCadEmpresa.picLogotipo.Image), SqlDbType.Image),
                             DBParametro_Montar("IC_DIAUTIL_DOM", IIf(oCadEmpresa.chkDiaUtil_Dom.Checked, "S", "N")),
                             DBParametro_Montar("IC_DIAUTIL_SEG", IIf(oCadEmpresa.chkDiaUtil_Seg.Checked, "S", "N")),
                             DBParametro_Montar("IC_DIAUTIL_TER", IIf(oCadEmpresa.chkDiaUtil_Ter.Checked, "S", "N")),
                             DBParametro_Montar("IC_DIAUTIL_QUA", IIf(oCadEmpresa.chkDiaUtil_Qua.Checked, "S", "N")),
                             DBParametro_Montar("IC_DIAUTIL_QUI", IIf(oCadEmpresa.chkDiaUtil_Qui.Checked, "S", "N")),
                             DBParametro_Montar("IC_DIAUTIL_SEX", IIf(oCadEmpresa.chkDiaUtil_Sex.Checked, "S", "N")),
                             DBParametro_Montar("IC_DIAUTIL_SAB", IIf(oCadEmpresa.chkDiaUtil_Sab.Checked, "S", "N")),
                             DBParametro_Montar("DS_RODAPE_RELATORIO", rtbRodapeRelatorio.Text, SqlDbType.NVarChar, , 200),
                             DBParametro_Montar("DS_MENSAGEM_IMPRESSAO_SENHA", txtMensagemSenha.Text, SqlDbType.NVarChar, , 200),
                             DBParametro_Montar("ID_PLANOCONTAS_PADRAO_IMPOSTORETIDO", cboPlanoContasPadraoImpostoRetido.SelectedValue),
                             DBParametro_Montar("ID_PESSOA_RESPONSAVEL_IMPOSTORETIDO", FNC_NuloZero(psqPessoaLancamentoImpostoRetido.ID_Pessoa, False)),
                             DBParametro_Montar("ID_CONTAFINANCEIRA_IMPOSTORETIDO", cboContaFinanceiraPadraoImpostoRetido.SelectedValue),
                             DBParametro_Montar("ID_PLANOCONTAS_PADRAO_DEVOLUCAO", cboPlanoContasPadraoDevolucao.SelectedValue))
        If Trim(txtLogradouro.Text) <> "" Then
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
          DBExecutar(sSqlText, DBParametro_Montar("SQ_ENDERECO", iSQ_ENDERECO),
                               DBParametro_Montar("ID_PESSOA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_TIPO_ENDERECO", enTipoEndereco.Comercial.GetHashCode),
                               DBParametro_Montar("ID_CIDADE", cboCidade.SelectedValue),
                               DBParametro_Montar("DS_LOGRADOURO", txtLogradouro.Text),
                               DBParametro_Montar("NO_BAIRRO", txtBairro.Text),
                               DBParametro_Montar("NR_LOGRADOURO", txtNumero.Value),
                               DBParametro_Montar("DS_COMPLEMENTO", txtComplementoEndereco.Text,,, const_BancoDados_TamanhoComentario),
                               DBParametro_Montar("CD_CEP", txtCEP.Value),
                               DBParametro_Montar("IC_ATIVO", "S"))
        End If
        If Trim(FNC_SoNumero(oCadEmpresa.txtTelefone.Text)) <> "" Then
          sSqlText = DBMontar_SP("SP_PESSOA_TELEFONE_CAD", False, "@SQ_PESSOA_TELEFONE",
                                                                  "@ID_PESSOA",
                                                                  "@ID_TIPO_TELEFONE",
                                                                  "@CD_NUMERO",
                                                                  "@IC_WHATSAPP",
                                                                  "@CM_OBSERVACAO")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_TELEFONE", iSQ_PESSOA_TELEFONE),
                               DBParametro_Montar("ID_PESSOA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_TIPO_TELEFONE", enTipoTelefone.Comercial.GetHashCode),
                               DBParametro_Montar("CD_NUMERO", oCadEmpresa.txtTelefone.Text),
                               DBParametro_Montar("IC_WHATSAPP", Nothing),
                               DBParametro_Montar("CM_OBSERVACAO", Nothing))
        End If
        If Trim(txtEMail.Text) <> "" Then
          sSqlText = DBMontar_SP("SP_PESSOA_MIDIASOCIAL_CAD", False, "@SQ_PESSOA_MIDIASOCIAL",
                                                                     "@ID_PESSOA",
                                                                     "@ID_TIPO_MIDIASOCIAL",
                                                                     "@DS_MIDIASOCIAL")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_MIDIASOCIAL", iSQ_PESSOA_MIDIASOCIAL_EMAIL),
                               DBParametro_Montar("ID_PESSOA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_TIPO_MIDIASOCIAL", enTipoMidiaSocial.EMail.GetHashCode),
                               DBParametro_Montar("DS_MIDIASOCIAL", txtEMail.Text))
        End If
        If Trim(txtWebSite.Text) <> "" Then
          sSqlText = DBMontar_SP("SP_PESSOA_MIDIASOCIAL_CAD", False, "@SQ_PESSOA_MIDIASOCIAL",
                                                                     "@ID_PESSOA",
                                                                     "@ID_TIPO_MIDIASOCIAL",
                                                                     "@DS_MIDIASOCIAL")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_MIDIASOCIAL", iSQ_PESSOA_MIDIASOCIAL_WEBSITE),
                               DBParametro_Montar("ID_PESSOA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_TIPO_MIDIASOCIAL", enTipoMidiaSocial.WebSite.GetHashCode),
                               DBParametro_Montar("DS_MIDIASOCIAL", txtWebSite.Text))
        End If

        DBExecutarTransacao()

        bGravacaoEfetuada = True

        If bConfiguracaoInicial Then
          Me.Close()
        End If

        oCadEmpresa.picLogotipo.ValidarArquivo()

        CarregarDados()
        FNC_CarregarDados_EmpresaUsuario()
        sID_EMPRESA_CNPJ = oCadEmpresa.txtCNPJ.Text
        iID_EMPRESA_CIDADE = cboCidade.SelectedValue
        iID_EMPRESA_UF = FNC_NVL(cboCidade.SelectedItem(enCombox_Cidade.ID_UF), 0)
        sCD_EMPRESA_UF = FNC_NVL(cboCidade.SelectedItem(enCombox_Cidade.CD_UF), "")
        iID_EMPRESA_PAIS = FNC_NVL(cboCidade.SelectedItem(enCombox_Cidade.ID_PAIS), 0)
        sNO_EMPRESA_FILIAL = oCadEmpresa.txtRazaoSocial.Text

        FNC_Mensagem("Gravação Efetuada")
      End If
    End If
  End Sub

  Private Sub ComboBox_KeyDown(sender As Object, e As KeyEventArgs)
    If e.KeyCode = Keys.Delete Then
      sender.SelectedIndex = -1
    End If
  End Sub
End Class