Imports Microsoft.Reporting.WinForms
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Module modFormLocal
  '> Pesquisa de Pessoa
  Public Const const_GridListagemPessoa_SQ_PESSOA As Integer = 0
  Public Const const_GridListagemPessoa_Check As Integer = 1
  Public Const const_GridListagemPessoa_NomePessoa As Integer = 2
  Public Const const_GridListagemPessoa_NomeReduzido As Integer = 3
  Public Const const_GridListagemPessoa_CPF_CNPJ As Integer = 4
  Public Const const_GridListagemPessoa_Pendencia As Integer = 5
  Public Const const_GridListagemPessoa_TipoPessoa As Integer = 6
  Public Const const_GridListagemPessoa_Telefone As Integer = 7
  Public Const const_GridListagemPessoa_DtCadastro As Integer = 8
  Public Const const_GridListagemPessoa_DtNascimentoAbertura As Integer = 9
  Public Const const_GridListagemPessoa_DiaMesAniversario As Integer = 10
  Public Const const_GridListagemPessoa_Nascionalidade As Integer = 11
  Public Const const_GridListagemPessoa_Naturalidade As Integer = 12
  Public Const const_GridListagemPessoa_Raca As Integer = 13
  Public Const const_GridListagemPessoa_Religiao As Integer = 14
  Public Const const_GridListagemPessoa_Sexo As Integer = 15
  Public Const const_GridListagemPessoa_EstadoCivil As Integer = 16
  Public Const const_GridListagemPessoa_Escolaridade As Integer = 17
  Public Const const_GridListagemPessoa_Cliente As Integer = 18
  Public Const const_GridListagemPessoa_Paciente As Integer = 19
  Public Const const_GridListagemPessoa_Fabricante As Integer = 20
  Public Const const_GridListagemPessoa_Fornecedor As Integer = 21
  Public Const const_GridListagemPessoa_Funcionario As Integer = 22
  Public Const const_GridListagemPessoa_Profissional As Integer = 23
  Public Const const_GridListagemPessoa_Transportadora As Integer = 24
  Public Const const_GridListagemPessoa_Vendedor As Integer = 25
  Public Const const_GridListagemPessoa_Ativo As Integer = 26
  Public Const const_GridListagemPessoa_Idade As Integer = 27
  Public Const const_GridListagemPessoa_Empresa As Integer = 28
  Public Const const_GridListagemPessoa_ID_EMPRESA As Integer = 29
  Public Const const_GridListagemPessoa_TP_PODEEXCLUIR As Integer = 30
  Public Const const_GridListagemPessoa_NO_MAE As Integer = 31

  Public Const const_GridListagemProduto_ID_PRODUTO As Integer = 0
  Public Const const_GridListagemProduto_ID_PRODUTO_EMPRESA As Integer = 1
  Public Const const_GridListagemProduto_ID_PRODUTO_LINHA As Integer = 2
  Public Const const_GridListagemProduto_Check As Integer = 3
  Public Const const_GridListagemProduto_CD_PRODUTO As Integer = 4
  Public Const const_GridListagemProduto_NO_PRODUTO As Integer = 5
  Public Const const_GridListagemProduto_TIPO As Integer = 6
  Public Const const_GridListagemProduto_CD_BARRA_FABRICANTE As Integer = 7
  Public Const const_GridListagemProduto_CD_BARRA As Integer = 8
  Public Const const_GridListagemProduto_NO_UNIDADEMEDIDA As Integer = 9
  Public Const const_GridListagemProduto_NO_GRUPOPRODUTO As Integer = 10
  Public Const const_GridListagemProduto_NO_TIPO_PRODUTO As Integer = 11
  Public Const const_GridListagemProduto_NO_PESSOA_FABRICANTE As Integer = 12
  Public Const const_GridListagemProduto_NO_ORIGEM As Integer = 13
  Public Const const_GridListagemProduto_CD_CST As Integer = 14
  Public Const const_GridListagemProduto_NO_CST As Integer = 15
  Public Const const_GridListagemProduto_CD_CSOSN As Integer = 16
  Public Const const_GridListagemProduto_NO_CSOSN As Integer = 17
  Public Const const_GridListagemProduto_CD_NCM As Integer = 18
  Public Const const_GridListagemProduto_DS_NCM As Integer = 19
  Public Const const_GridListagemProduto_CD_CST_COFINS As Integer = 20
  Public Const const_GridListagemProduto_NO_CST_COFINS As Integer = 21
  Public Const const_GridListagemProduto_CD_CST_IPI As Integer = 22
  Public Const const_GridListagemProduto_NO_CST_IPI As Integer = 23
  Public Const const_GridListagemProduto_CD_CST_PIS As Integer = 24
  Public Const const_GridListagemProduto_NO_CST_PIS As Integer = 25
  Public Const const_GridListagemProduto_PC_COFINS As Integer = 26
  Public Const const_GridListagemProduto_PC_IPI As Integer = 27
  Public Const const_GridListagemProduto_PC_PIS As Integer = 28
  Public Const const_GridListagemProduto_PC_MVA As Integer = 29
  Public Const const_GridListagemProduto_PC_ALIQUOTA_IBPT_ESTADUAL As Integer = 30
  Public Const const_GridListagemProduto_PC_ALIQUOTA_IBPT_NACIONAL As Integer = 31
  Public Const const_GridListagemProduto_VL_PRECOCUSTO As Integer = 32
  Public Const const_GridListagemProduto_PC_ICMS_ENTRADA As Integer = 33
  Public Const const_GridListagemProduto_PC_ICMS_SAIDA As Integer = 34
  Public Const const_GridListagemProduto_PC_SIMPLESNACIONAL As Integer = 35
  Public Const const_GridListagemProduto_PC_CUSTO_FIXO As Integer = 36
  Public Const const_GridListagemProduto_PC_CUSTO_VARIAVEL As Integer = 37
  Public Const const_GridListagemProduto_PC_OUTROS_IMPOSTOS As Integer = 38
  Public Const const_GridListagemProduto_PC_ICMS_ST As Integer = 39
  Public Const const_GridListagemProduto_PC_FRETE_ENTRADA As Integer = 40
  Public Const const_GridListagemProduto_VL_BRINDE_ACESSORIO As Integer = 41
  Public Const const_GridListagemProduto_VL_PRECOCUSTOTOTAL As Integer = 42
  Public Const const_GridListagemProduto_NR_VALIDADE_COTACAO As Integer = 43
  Public Const const_GridListagemProduto_NR_DIA_ENTREGA_MINIMO As Integer = 44
  Public Const const_GridListagemProduto_DT_CADASTRO As Integer = 45
  Public Const const_GridListagemProduto_IC_ATIVO As Integer = 46
  Public Const const_GridListagemProduto_DT_ULTIMA_COMPRA As Integer = 47
  Public Const const_GridListagemProduto_DT_ULTIMA_VENDA As Integer = 48
  Public Const const_GridListagemProduto_IC_CONTROLA_NUMERO_SERIE As Integer = 49
  Public Const const_GridListagemProduto_IC_CONTROLA_GARANTIA As Integer = 50
  Public Const const_GridListagemProduto_QT_MESES_GARANTIA_FORNECEDOR As Integer = 51
  Public Const const_GridListagemProduto_QT_MESES_GARANTIA_REVENDA As Integer = 52
  Public Const const_GridListagemProduto_Empresa As Integer = 53
  Public Const const_GridListagemProduto_ID_EMPRESA As Integer = 54
  Public Const const_GridListagemProduto_TP_PODE_EXCLUIR As Integer = 55
  Public Const const_GridListagemProduto_NO_PRODUTO_LINHA As Integer = 56
  Public Const const_GridListagemProduto_ID_UNIDADEMEDIDA As Integer = 57

  Public Const const_GridListagemProcedimento_SQ_PROCEDIMENTO As Integer = 0
  Public Const const_GridListagemProcedimento_ID_TABELAPROCEDIMENTO As Integer = 1
  Public Const const_GridListagemProcedimento_NO_OPT_TIPOPROCEDIMENTO As Integer = 2
  Public Const const_GridListagemProcedimento_NO_OPT_TIPOEXAME As Integer = 3
  Public Const const_GridListagemProcedimento_NO_TABELAPROCEDIMENTO As Integer = 4
  Public Const const_GridListagemProcedimento_NO_GRUPOPROCEDIMENTO As Integer = 5
  Public Const const_GridListagemProcedimento_CD_PROCEDIMENTO As Integer = 6
  Public Const const_GridListagemProcedimento_NO_PROCEDIMENTO As Integer = 7
  Public Const const_GridListagemProcedimento_NO_TIPOCONSULTAPREFERENCIAL As Integer = 8
  Public Const const_GridListagemProcedimento_NO_ESPECIALIDADE_PADRAO As Integer = 9
  Public Const const_GridListagemProcedimento_DS_ATIVO As Integer = 10

  Public Const const_GridListagemHistoricoConsultas_ID As Integer = 0
  Public Const const_GridListagemHistoricoConsultas_Codigo As Integer = 1
  Public Const const_GridListagemHistoricoConsultas_Data As Integer = 2
  Public Const const_GridListagemHistoricoConsultas_Profissional As Integer = 3
  Public Const const_GridListagemHistoricoConsultas_Tipo As Integer = 4
  Public Const const_GridListagemHistoricoConsultas_Status As Integer = 5

  Public Const const_GridListagemHistoricoFamiliar_TipoParentesco As Integer = 0
  Public Const const_GridListagemHistoricoFamiliar_Nome As Integer = 1
  Public Const const_GridListagemHistoricoFamiliar_CID10_Diagnostico As Integer = 2

  Public Const const_GridListagemHistoricoCompra_SQ_PEDIDO_PRODUTO As Integer = 0
  Public Const const_GridListagemHistoricoCompra_DH_PEDIDO As Integer = 1
  Public Const const_GridListagemHistoricoCompra_CD_PEDIDO As Integer = 2
  Public Const const_GridListagemHistoricoCompra_NO_PRODUTO As Integer = 3
  Public Const const_GridListagemHistoricoCompra_QT_FATURADA As Integer = 4
  Public Const const_GridListagemHistoricoCompra_VL_UNITARIO As Integer = 5
  Public Const const_GridListagemHistoricoCompra_VL_TOTAL As Integer = 6
  Public Const const_GridListagemHistoricoCompra_VL_DESCONTO As Integer = 7

  Public Const const_GridListagemHistoricoFinanceiro_ID_MOVFINANCEIRA As Integer = 0
  Public Const const_GridListagemHistoricoFinanceiro_SQ_MOVFINANCEIRAPARCELA As Integer = 1
  Public Const const_GridListagemHistoricoFinicaneiro_ID_OPT_STATUS As Integer = 2
  Public Const const_GridListagemHistoricoFinanceiro_Codigo As Integer = 3
  Public Const const_GridListagemHistoricoFinanceiro_Status As Integer = 4
  Public Const const_GridListagemHistoricoFinanceiro_DescricaoMovimentacao As Integer = 5
  Public Const const_GridListagemHistoricoFinanceiro_TipoDocumento As Integer = 6
  Public Const const_GridListagemHistoricoFinanceiro_DataMovimentação As Integer = 7
  Public Const const_GridListagemHistoricoFinanceiro_DataVencimento As Integer = 8
  Public Const const_GridListagemHistoricoFinanceiro_DataQuitação As Integer = 9
  Public Const const_GridListagemHistoricoFinanceiro_ValorParcela As Integer = 10
  Public Const const_GridListagemHistoricoFinanceiro_ValorEmAberto As Integer = 11
  Public Const const_GridListagemHistoricoFinanceiro_Emitente As Integer = 12

  Public Const const_GridListagemPatologia_Data As Integer = 0
  Public Const const_GridListagemPatologia_Diagnostico As Integer = 1

  Public Const const_CboPessoaAgenda_ID_PESSOA_AGENDA As Integer = 0
  Public Const const_CboPessoaAgenda_NO_PESSOA_AGENDA As Integer = 1
  Public Const const_CboPessoaAgenda_ID_OPT_TIPOLIBERACAO As Integer = 2

  Public Const const_TelefoneWhatsApp As String = "WhatsApp"

  Public Const const_ProcessoInterno_ConsultaContasReceberPagarCancelamento_ContasPagarReceber As Integer = 1
  Public Const const_ProcessoInterno_ConsultaContasReceberPagarCancelamento_FluxoCaixa As Integer = 2

  Public Const const_CalculoFinanceiro_DESCONTO As String = "D"
  Public Const const_CalculoFinanceiro_JUROS As String = "J"

  Public oFormConsultaAtendimento As Form

  Public Sub FormPesquisaPessoa_FormatarGrid(ByVal oGrid As UltraGrid,
                                             Optional ByVal oData As Object = Nothing,
                                             Optional CampoFiltro As Boolean = False,
                                             Optional ConsultaSimples As Boolean = True,
                                             Optional bConsultaPaciente As Boolean = False)
    objGrid_Inicializar(oGrid, , oData, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, CampoFiltro, , , , True)
    objGrid_Coluna_Add(oGrid, "Prontuário", 150)
    objGrid_Coluna_Add(oGrid, "..", 50, , True, ColumnStyle.CheckBox).Hidden = True
    If bConsultaPaciente Then
      objGrid_Coluna_Add(oGrid, "Nome do Paciente", 300)
    Else
      objGrid_Coluna_Add(oGrid, "Nome da Pessoa/Razão Social", 300)
    End If
    If bConsultaPaciente Then
      objGrid_Coluna_Add(oGrid, "Nome Reduzido ou Apelido", 300)
    Else
      objGrid_Coluna_Add(oGrid, "Nome Reduzido/Nome de Fantasia", 300)
    End If
    objGrid_Coluna_Add(oGrid, "C.P.F./C.N.P.J.", 130)
    objGrid_Coluna_Add(oGrid, "Pendências", 0)
    If bConsultaPaciente Then
      objGrid_Coluna_Add(oGrid, "Tipo de Paciente", 130)
    Else
      objGrid_Coluna_Add(oGrid, "Tipo de Pessoa", 130)
    End If
    objGrid_Coluna_Add(oGrid, "Telefone(s)", IIf(ConsultaSimples, 0, 300))
    objGrid_Coluna_Add(oGrid, "Dt. Cadastro", IIf(ConsultaSimples, 0, 100), , , ColumnStyle.Date)
    objGrid_Coluna_Add(oGrid, "Dt. Nascimento/Abertura", 100, , , ColumnStyle.Date)
    objGrid_Coluna_Add(oGrid, "Dia/Mês Aniversário", IIf(ConsultaSimples, 0, 150))
    objGrid_Coluna_Add(oGrid, "Nascionalidade", IIf(ConsultaSimples, 0, 150))
    objGrid_Coluna_Add(oGrid, "Naturalidade", IIf(ConsultaSimples, 0, 150))
    objGrid_Coluna_Add(oGrid, "Raça", IIf(ConsultaSimples, 0, 150))
    objGrid_Coluna_Add(oGrid, "Religião", IIf(ConsultaSimples, 0, 150))
    objGrid_Coluna_Add(oGrid, "Sexo", IIf(ConsultaSimples, 0, 150))
    objGrid_Coluna_Add(oGrid, "Estado Civíl", IIf(ConsultaSimples, 0, 150))
    objGrid_Coluna_Add(oGrid, "Escolaridade", IIf(ConsultaSimples, 0, 150))
    objGrid_Coluna_Add(oGrid, "Cliente?", IIf(ConsultaSimples, 0, 100))
    objGrid_Coluna_Add(oGrid, "Paciente?", IIf(ConsultaSimples, 0, 100))
    objGrid_Coluna_Add(oGrid, "Fabricante?", IIf(ConsultaSimples, 0, 100))
    objGrid_Coluna_Add(oGrid, "Fornecedor?", IIf(ConsultaSimples, 0, 100))
    objGrid_Coluna_Add(oGrid, "Funcionário?", IIf(ConsultaSimples, 0, 100))
    objGrid_Coluna_Add(oGrid, "Profissional?", IIf(ConsultaSimples, 0, 100))
    objGrid_Coluna_Add(oGrid, "Transportadora?", IIf(ConsultaSimples, 0, 100))
    objGrid_Coluna_Add(oGrid, "Vendedor?", IIf(ConsultaSimples, 0, 100))
    objGrid_Coluna_Add(oGrid, "Ativo", 80)
    objGrid_Coluna_Add(oGrid, "Idade/Tempo Abertura", 200)
    objGrid_Coluna_Add(oGrid, "Empresa", 300).Hidden = True
    objGrid_Coluna_Add(oGrid, "ID_EMPRESA", 0)
    objGrid_Coluna_Add(oGrid, "TP_PODEEXCLUIR", 0)
    objGrid_Coluna_Add(oGrid, "Mãe", 200)
  End Sub

  Public Sub FormPesquisaProcedimento_FormatarGrid(ByVal oGrid As UltraGrid,
                                                   Optional ByVal oData As Object = Nothing,
                                                   Optional CampoFiltro As Boolean = False)
    objGrid_Inicializar(oGrid, , oData, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, CampoFiltro, , , , True)
    objGrid_Coluna_Add(oGrid, "SQ_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(oGrid, "ID_TABELAPROCEDIMENTO", 0)
    objGrid_Coluna_Add(oGrid, "Tipo de Procedimento", 150)
    objGrid_Coluna_Add(oGrid, "Tipo de Exame", 150)
    objGrid_Coluna_Add(oGrid, "Tabela de Procedimento", 250)
    objGrid_Coluna_Add(oGrid, "Grupo de Procedimento", 250)
    objGrid_Coluna_Add(oGrid, "Código", 100)
    objGrid_Coluna_Add(oGrid, "Nome do Procedimento", 400)
    objGrid_Coluna_Add(oGrid, "Tipo de Consulta Preferêncial", 400)
    objGrid_Coluna_Add(oGrid, "Especialidade Padrão", 400)
    objGrid_Coluna_Add(oGrid, "Ativo", 90)
  End Sub

  Public Sub FormPesquisaProduto_FormatarGrid(ByVal oGrid As UltraGrid,
                                              Optional ByVal oData As Object = Nothing,
                                              Optional CampoFiltro As Boolean = False,
                                              Optional ConsultaSimples As Boolean = True)
    objGrid_Inicializar(oGrid, , oData, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, CampoFiltro, , , , True)
    objGrid_Coluna_Add(oGrid, "SQ_PRODUTO", 0)
    objGrid_Coluna_Add(oGrid, "SQ_PRODUTO_EMPRESA", 0)
    objGrid_Coluna_Add(oGrid, "ID_PRODUTO_LINHA", 0)
    objGrid_Coluna_Add(oGrid, "..", 50, , True, ColumnStyle.CheckBox).Hidden = True
    objGrid_Coluna_Add(oGrid, "Cód.Produto", 70)
    objGrid_Coluna_Add(oGrid, "Nome do Produto", 250)
    objGrid_Coluna_Add(oGrid, "TIPO", 0)
    objGrid_Coluna_Add(oGrid, "Cód. Fabricante", 70)
    objGrid_Coluna_Add(oGrid, "Cód. Barra", 70)
    objGrid_Coluna_Add(oGrid, "Unidade de Medida", 100)
    objGrid_Coluna_Add(oGrid, "Grupo de Produto", 100)
    objGrid_Coluna_Add(oGrid, "Tipo de Produto", 100)
    objGrid_Coluna_Add(oGrid, "Fabricante", 100)
    objGrid_Coluna_Add(oGrid, "Origem", 100)
    objGrid_Coluna_Add(oGrid, "CST", 40)
    objGrid_Coluna_Add(oGrid, "CST", 100)
    objGrid_Coluna_Add(oGrid, "CSOSN", 50)
    objGrid_Coluna_Add(oGrid, "CSOSN", 100)
    objGrid_Coluna_Add(oGrid, "NCM", 50)
    objGrid_Coluna_Add(oGrid, "NCM", 100)
    objGrid_Coluna_Add(oGrid, "CST Cofins", 50)
    objGrid_Coluna_Add(oGrid, "CST Cofins", 100)
    objGrid_Coluna_Add(oGrid, "CST IPI", 50)
    objGrid_Coluna_Add(oGrid, "CST IPI", 100)
    objGrid_Coluna_Add(oGrid, "CST PIS", 50)
    objGrid_Coluna_Add(oGrid, "CST PIS", 100)
    objGrid_Coluna_Add(oGrid, "Cofins (%)", 50)
    objGrid_Coluna_Add(oGrid, "IPI (%)", 50)
    objGrid_Coluna_Add(oGrid, "PIS (%)", 50)
    objGrid_Coluna_Add(oGrid, "MVA (%)", 50)
    objGrid_Coluna_Add(oGrid, "IBPT Estad. (%)", 50)
    objGrid_Coluna_Add(oGrid, "IBPT Nacio. (%)", 50)
    objGrid_Coluna_Add(oGrid, "Preço Custo", 80, , , ColumnStyle.Currency)
    objGrid_Coluna_Add(oGrid, "ICMS Entrada (%)", 80)
    objGrid_Coluna_Add(oGrid, "ICMS Saída (%)", 80)
    objGrid_Coluna_Add(oGrid, "Simples Nacional (%)", 120)
    objGrid_Coluna_Add(oGrid, "Custo Fixo (%)", 80)
    objGrid_Coluna_Add(oGrid, "Custo Variavel (%)", 100)
    objGrid_Coluna_Add(oGrid, "Outros Impostos (%)", 100)
    objGrid_Coluna_Add(oGrid, "ICMS Sub(%)", 80)
    objGrid_Coluna_Add(oGrid, "Frete Entrada (%)", 80)
    objGrid_Coluna_Add(oGrid, "Brinde e Acessórios", 130, , , ColumnStyle.Currency)
    objGrid_Coluna_Add(oGrid, "Preço Total", 100, , , ColumnStyle.Currency)
    objGrid_Coluna_Add(oGrid, "Validade Cotação (Meses)", 100)
    objGrid_Coluna_Add(oGrid, "Min. Dias Entrega", 100)
    objGrid_Coluna_Add(oGrid, "Data Cadastro", 100)
    objGrid_Coluna_Add(oGrid, "Ativo", 80)
    objGrid_Coluna_Add(oGrid, "Ultima Compra", 100, , , ColumnStyle.Date)
    objGrid_Coluna_Add(oGrid, "Ultima Venda", 100, , , ColumnStyle.Date)
    objGrid_Coluna_Add(oGrid, "Controla Número de Série", 150)
    objGrid_Coluna_Add(oGrid, "Controla Garantia", 150)
    objGrid_Coluna_Add(oGrid, "Meses Garantia Fornecedor", 150)
    objGrid_Coluna_Add(oGrid, "Meses Garantia Revenda", 150)
    objGrid_Coluna_Add(oGrid, "Empresa", 300).Hidden = True
    objGrid_Coluna_Add(oGrid, "ID_EMPRESA", 0)
    objGrid_Coluna_Add(oGrid, "TP_PODE_EXCLUIR", 0)
    objGrid_Coluna_Add(oGrid, "Linha de Produto", 150)
    objGrid_Coluna_Add(oGrid, "ID_UNIDADEMEDIDA", 0)
  End Sub

  Public Function FormPesquisaPessoa_Pesquisar_Cidade(Optional CD_IBGE As String = "",
                                                      Optional NO_CIDADE As String = "",
                                                      Optional CD_UF As String = "") As Integer
    If Trim(CD_IBGE) = "" Then
      Return DBQuery_ValorUnico("SELECT SQ_CIDADE FROM VW_CIDADE WHERE NO_CIDADE = " & FNC_QuotedStr(NO_CIDADE) & " AND CD_UF = " & FNC_QuotedStr(CD_UF), 0)
    Else
      Return DBQuery_ValorUnico("SELECT SQ_CIDADE FROM TB_CIDADE WHERE CD_IBGE = " & CD_IBGE, 0)
    End If
  End Function

  Public Sub FormPesquisaPessoa_Pesquisar(ByVal oGrid As UltraGrid,
                                          Optional NomePessoa As String = "",
                                          Optional TipoPessoa As Integer = 0,
                                          Optional Documento As String = "",
                                          Optional bCliente As Boolean = False,
                                          Optional bFabricante As Boolean = False,
                                          Optional bFornecedor As Boolean = False,
                                          Optional bFuncionario As Boolean = False,
                                          Optional bProfissional As Boolean = False,
                                          Optional bProfissional_ServicoInterno As Boolean = False,
                                          Optional bTransportadora As Boolean = False,
                                          Optional bVendedor As Boolean = False,
                                          Optional bPaciente As Boolean = False,
                                          Optional iAtivo As Integer = 20,
                                          Optional iID_PESSOA As Integer = 0,
                                          Optional DiaAniversario As Integer = 0,
                                          Optional MesAniversario As Integer = 0,
                                          Optional bNaoEmpresa As Boolean = False,
                                          Optional bConsultaPaciente As Boolean = False,
                                          Optional bSomenteNome As Boolean = False,
                                          Optional sMae As String = "",
                                          Optional sProntuario As String = "")
    Dim sSqlText As String = ""
    Dim sSqlText_Where As String = ""

    sSqlText = PesquisaPessoa_String(NomePessoa,
                                     TipoPessoa,
                                     Documento,
                                     bCliente,
                                     bFabricante,
                                     bFornecedor,
                                     bFuncionario,
                                     bProfissional,
                                     bProfissional_ServicoInterno,
                                     bTransportadora,
                                     bVendedor,
                                     bPaciente,
                                     False,
                                     iAtivo,
                                     iID_PESSOA,
                                     DiaAniversario,
                                     MesAniversario,,,
                                     bNaoEmpresa, ,
                                     bConsultaPaciente,
                                     bSomenteNome,
                                     sMae,
                                     sProntuario)
    objGrid_Carregar(oGrid, sSqlText, New Integer() {const_GridListagemPessoa_SQ_PESSOA,
                                                     const_GridListagemPessoa_Check,
                                                     const_GridListagemPessoa_NomePessoa,
                                                     const_GridListagemPessoa_NomeReduzido,
                                                     const_GridListagemPessoa_CPF_CNPJ,
                                                     const_GridListagemPessoa_Pendencia,
                                                     const_GridListagemPessoa_TipoPessoa,
                                                     const_GridListagemPessoa_Telefone,
                                                     const_GridListagemPessoa_DtCadastro,
                                                     const_GridListagemPessoa_DtNascimentoAbertura,
                                                     const_GridListagemPessoa_DiaMesAniversario,
                                                     const_GridListagemPessoa_Nascionalidade,
                                                     const_GridListagemPessoa_Naturalidade,
                                                     const_GridListagemPessoa_Raca,
                                                     const_GridListagemPessoa_Religiao,
                                                     const_GridListagemPessoa_Sexo,
                                                     const_GridListagemPessoa_EstadoCivil,
                                                     const_GridListagemPessoa_Escolaridade,
                                                     const_GridListagemPessoa_Cliente,
                                                     const_GridListagemPessoa_Paciente,
                                                     const_GridListagemPessoa_Fabricante,
                                                     const_GridListagemPessoa_Fornecedor,
                                                     const_GridListagemPessoa_Funcionario,
                                                     const_GridListagemPessoa_Profissional,
                                                     const_GridListagemPessoa_Transportadora,
                                                     const_GridListagemPessoa_Vendedor,
                                                     const_GridListagemPessoa_Ativo,
                                                     const_GridListagemPessoa_Idade,
                                                     const_GridListagemPessoa_Empresa,
                                                     const_GridListagemPessoa_ID_EMPRESA,
                                                     const_GridListagemPessoa_TP_PODEEXCLUIR,
                                                     const_GridListagemPessoa_NO_MAE}, True)
  End Sub

  Public Function FormPesquisaProduto_CodigoExiste(sCodigo As String, iSQ_PRODUTO As Integer) As Boolean
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM TB_PRODUTO WHERE CD_PRODUTO = " & FNC_QuotedStr(sCodigo) & " AND SQ_PRODUTO <> " & iSQ_PRODUTO

    Return (DBQuery_ValorUnico(sSqlText, 0) > 0)
  End Function

  Public Sub FormPesquisaProcedimento_Pesquisar(ByVal oGrid As UltraGrid,
                                                  sAtivo As String,
                                                  sNomeProcedimento As String,
                                                  sCodigoProcedimento As String,
                                                  iTabelaProcedimento As Integer,
                                                  iTipoProcedimento As Integer,
                                                  iGrupoProcedimento As Integer,
                                                  Optional iTipoExame As Integer = 0,
                                                  Optional iConvenio As Integer = 0)
    Dim sSqlText As String = ""
    Dim sSqlText_Where As String = ""

    sSqlText = PesquisaProcedimento_String(sAtivo,
                                           sNomeProcedimento,
                                           sCodigoProcedimento,
                                           iTabelaProcedimento,
                                           iTipoProcedimento,
                                           iGrupoProcedimento,
                                           iTipoExame,
                                           iConvenio)
    objGrid_Carregar(oGrid, sSqlText, New Integer() {const_GridListagemProcedimento_SQ_PROCEDIMENTO,
                                                     const_GridListagemProcedimento_ID_TABELAPROCEDIMENTO,
                                                     const_GridListagemProcedimento_NO_OPT_TIPOPROCEDIMENTO,
                                                     const_GridListagemProcedimento_NO_OPT_TIPOEXAME,
                                                     const_GridListagemProcedimento_NO_TABELAPROCEDIMENTO,
                                                     const_GridListagemProcedimento_NO_GRUPOPROCEDIMENTO,
                                                     const_GridListagemProcedimento_CD_PROCEDIMENTO,
                                                     const_GridListagemProcedimento_NO_PROCEDIMENTO,
                                                     const_GridListagemProcedimento_NO_TIPOCONSULTAPREFERENCIAL,
                                                     const_GridListagemProcedimento_NO_ESPECIALIDADE_PADRAO,
                                                     const_GridListagemProcedimento_DS_ATIVO}, True)

  End Sub

  Public Sub FormPesquisaProduto_Pesquisar(ByVal oGrid As UltraGrid,
                                             Optional NomeProduto As String = "",
                                             Optional TipoProduto As Integer = 0,
                                             Optional GrupoProduto As Integer = 0,
                                             Optional Origem As Integer = 0,
                                             Optional Codigo As String = "",
                                             Optional Ativo As String = "T",
                                             Optional bNaoEmpresa As Boolean = False,
                                             Optional bListarLinhaProduto As Boolean = False)
    Dim sSqlText
    Dim sSqlText_Where As String = ""

    sSqlText = PesquisaProduto_String(0, 0,
                                      NomeProduto,
                                      TipoProduto,
                                      GrupoProduto,
                                      Origem,
                                      Codigo,
                                      Ativo, ,
                                      bNaoEmpresa, ,
                                      bListarLinhaProduto)
    objGrid_Carregar(oGrid, sSqlText, New Integer() {const_GridListagemProduto_ID_PRODUTO,
                                                     const_GridListagemProduto_ID_PRODUTO_EMPRESA,
                                                     const_GridListagemProduto_ID_PRODUTO_LINHA,
                                                     const_GridListagemProduto_Check,
                                                     const_GridListagemProduto_CD_PRODUTO,
                                                     const_GridListagemProduto_NO_PRODUTO,
                                                     const_GridListagemProduto_TIPO,
                                                     const_GridListagemProduto_CD_BARRA_FABRICANTE,
                                                     const_GridListagemProduto_CD_BARRA,
                                                     const_GridListagemProduto_NO_UNIDADEMEDIDA,
                                                     const_GridListagemProduto_NO_GRUPOPRODUTO,
                                                     const_GridListagemProduto_NO_TIPO_PRODUTO,
                                                     const_GridListagemProduto_NO_PESSOA_FABRICANTE,
                                                     const_GridListagemProduto_NO_ORIGEM,
                                                     const_GridListagemProduto_CD_CST,
                                                     const_GridListagemProduto_NO_CST,
                                                     const_GridListagemProduto_CD_CSOSN,
                                                     const_GridListagemProduto_NO_CSOSN,
                                                     const_GridListagemProduto_CD_NCM,
                                                     const_GridListagemProduto_DS_NCM,
                                                     const_GridListagemProduto_CD_CST_COFINS,
                                                     const_GridListagemProduto_NO_CST_COFINS,
                                                     const_GridListagemProduto_CD_CST_IPI,
                                                     const_GridListagemProduto_NO_CST_IPI,
                                                     const_GridListagemProduto_CD_CST_PIS,
                                                     const_GridListagemProduto_NO_CST_PIS,
                                                     const_GridListagemProduto_PC_COFINS,
                                                     const_GridListagemProduto_PC_IPI,
                                                     const_GridListagemProduto_PC_PIS,
                                                     const_GridListagemProduto_PC_MVA,
                                                     const_GridListagemProduto_PC_ALIQUOTA_IBPT_ESTADUAL,
                                                     const_GridListagemProduto_PC_ALIQUOTA_IBPT_NACIONAL,
                                                     const_GridListagemProduto_VL_PRECOCUSTO,
                                                     const_GridListagemProduto_PC_ICMS_ENTRADA,
                                                     const_GridListagemProduto_PC_ICMS_SAIDA,
                                                     const_GridListagemProduto_PC_SIMPLESNACIONAL,
                                                     const_GridListagemProduto_PC_CUSTO_FIXO,
                                                     const_GridListagemProduto_PC_CUSTO_VARIAVEL,
                                                     const_GridListagemProduto_PC_OUTROS_IMPOSTOS,
                                                     const_GridListagemProduto_PC_ICMS_ST,
                                                     const_GridListagemProduto_PC_FRETE_ENTRADA,
                                                     const_GridListagemProduto_VL_BRINDE_ACESSORIO,
                                                     const_GridListagemProduto_VL_PRECOCUSTOTOTAL,
                                                     const_GridListagemProduto_NR_VALIDADE_COTACAO,
                                                     const_GridListagemProduto_NR_DIA_ENTREGA_MINIMO,
                                                     const_GridListagemProduto_DT_CADASTRO,
                                                     const_GridListagemProduto_IC_ATIVO,
                                                     const_GridListagemProduto_DT_ULTIMA_COMPRA,
                                                     const_GridListagemProduto_DT_ULTIMA_VENDA,
                                                     const_GridListagemProduto_IC_CONTROLA_NUMERO_SERIE,
                                                     const_GridListagemProduto_IC_CONTROLA_GARANTIA,
                                                     const_GridListagemProduto_QT_MESES_GARANTIA_FORNECEDOR,
                                                     const_GridListagemProduto_QT_MESES_GARANTIA_REVENDA,
                                                     const_GridListagemProduto_Empresa,
                                                     const_GridListagemProduto_ID_EMPRESA,
                                                     const_GridListagemProduto_TP_PODE_EXCLUIR,
                                                     const_GridListagemProduto_NO_PRODUTO_LINHA,
                                                     const_GridListagemProduto_ID_UNIDADEMEDIDA}, True)
  End Sub

  Public Sub FormPesquisaPessoa_ExibirTela(oComboBox_Pessoa As ComboBox,
                                           TipoFiltro As enTipoFiltroPessoa,
                                           Optional bPossicionar As Boolean = False)
    Dim oForm As New frmpsqPessoa

    oForm.TipoFiltro = TipoFiltro
    FNC_AbriTela(oForm, , True, True)

    If oForm.SQ_PESSOA > 0 Then
      If bPossicionar Then
        ComboBox_Selecionar(oComboBox_Pessoa, oForm.SQ_PESSOA)
      Else
        oComboBox_Pessoa.DataSource = Nothing
        ComboBox_Carregar(oComboBox_Pessoa, New String() {oForm.NO_PESSOA},
                                            New Object() {oForm.SQ_PESSOA})
      End If
    End If

    oForm.Close()
    oForm.Dispose()
  End Sub

  Public Sub FormPesquisaProduto_ExibirTela(oComboBox_Produto As ComboBox, Optional bFiltraPelaDescricao As Boolean = False)
    Dim oForm As New frmpsqProduto

    If bFiltraPelaDescricao Then
      oForm.sFiltro = oComboBox_Produto.Text.Trim()
    End If

    FNC_AbriTela(oForm, , True, True)

    If oForm.SQ_PRODUTO(0) > 0 Then
      oComboBox_Produto.DataSource = Nothing
      FormPesquisaProduto_TratarCombo(Nothing, oComboBox_Produto, Nothing, oForm.SQ_PRODUTO(0))
    End If

    oForm.Close()
    oForm.Dispose()
  End Sub

  Public Sub FormPesquisaProcedimento_BotaoPesquisar(ByRef oComboBox As ComboBox,
                                                     ByRef oComboBoxPrincipal As ComboBox,
                                                     ByRef bEmProcessamento As Boolean,
                                                     Optional iConvenio As Integer = 0)
    Dim iID_TABELAPROCEDIMENTO As Integer

    FormPesquisaProcedimento_ExibirTela(oComboBoxPrincipal, iID_TABELAPROCEDIMENTO, iConvenio)

    bEmProcessamento = True
    ComboBox_CarregarProcedimento(False, oComboBox, oComboBoxPrincipal, , iID_TABELAPROCEDIMENTO, iConvenio)

    If oComboBoxPrincipal.Items.Count = 1 Then
      oComboBox.SelectedIndex = 0
      oComboBoxPrincipal.SelectedIndex = 0
    End If

    bEmProcessamento = False
  End Sub

  Public Sub FormPesquisaProcedimento_ExibirTela(oComboBox_Procedimento As ComboBox,
                                                 Optional ByRef iID_TABELAPROCEDIMENTO As Integer = 0,
                                                 Optional iConvenio As Integer = 0)
    Dim oForm As New frmPesqProcedimento

    oForm.ID_CONVENIO = iConvenio

    FNC_AbriTela(oForm, , True, True)

    If oForm.SQ_PROCEDIMENTO > 0 Then
      iID_TABELAPROCEDIMENTO = oForm.ID_TABELAPROCEDIMENTO

      oComboBox_Procedimento.DataSource = Nothing
      ComboBox_Carregar(oComboBox_Procedimento, New String() {oForm.NO_PROCEDIMENTO},
                                                New Object() {oForm.SQ_PROCEDIMENTO})
    End If

    oForm.Close()
    oForm.Dispose()
  End Sub

  Public Function FormPesquisaPessoa_Cadastro(ByRef iSQ_PESSOA As Integer,
                                              Optional bAdicionarSomenteEndereco As Boolean = False,
                                              Optional ByRef iSQ_ENDERECO As Integer = 0,
                                              Optional ByRef bIC_CLIENTE As Boolean = False,
                                              Optional ByRef bIC_FORNECEDOR As Boolean = False,
                                              Optional sNO_PESSOA As String = "",
                                              Optional sCD_TELEFONE As String = "",
                                              Optional sCD_CELULAR As String = "",
                                              Optional TipoCadastro As enFormPesquisaPessoa_Cadastro = enFormPesquisaPessoa_Cadastro.CadastroSimples) As Boolean
    Dim bOk As Boolean

    Select Case TipoCadastro
      Case enFormPesquisaPessoa_Cadastro.CadastroSimples
        Dim oForm As New frmCadastroPessoaSimples

        oForm.iSQ_PESSOA = iSQ_PESSOA
        oForm.bAdicionarSomenteEndereco = bAdicionarSomenteEndereco
        oForm.bIC_CLIENTE = bIC_CLIENTE
        oForm.bIC_FORNECEDOR = bIC_FORNECEDOR
        oForm.sNO_PESSOA = sNO_PESSOA
        oForm.sCD_TELEFONE = sCD_TELEFONE
        oForm.sCD_CELULAR = sCD_CELULAR
        FNC_AbriTela(oForm, , True, True)
        iSQ_PESSOA = oForm.iSQ_PESSOA

        bOk = oForm.bGravado
      Case enFormPesquisaPessoa_Cadastro.CadastroPaciente
        Dim oForm As New frmCadastroPaciente

        oForm.ID_PACIENTE = iSQ_PESSOA
        oForm.sNO_PESSOA = sNO_PESSOA
        oForm.sCD_TELEFONE = sCD_TELEFONE
        oForm.sCD_CELULAR = sCD_CELULAR
        oForm.bFecharAposGravacao = True

        FNC_AbriTela(oForm, , True, True)
        iSQ_PESSOA = oForm.ID_PACIENTE

        bOk = oForm.bGravado
      Case enFormPesquisaPessoa_Cadastro.CadastroPessoa
        Dim oForm As New frmCadastroPessoa

        oForm.iSQ_PESSOA = iSQ_PESSOA
        oForm.sNO_PESSOA = sNO_PESSOA
        oForm.sCD_TELEFONE = sCD_TELEFONE
        oForm.sCD_CELULAR = sCD_CELULAR

        FNC_AbriTela(oForm, , True, True)
        iSQ_PESSOA = oForm.iSQ_PESSOA

        bOk = oForm.bGravado
    End Select

    Return bOk
  End Function

  Public Function FormPesquisaPessoa_VerificarTelefone(iSQ_PESSOA As Integer,
                                                       CD_NUMERO As String,
                                                       Optional TipoTelefone As enTipoTelefone = enTipoTelefone.Celular) As Integer
    Dim sSqlText As String
    Dim iSQ_PESSOA_TELEFONE As Integer

    sSqlText = "SELECT SQ_PESSOA_TELEFONE FROM TB_PESSOA_TELEFONE WHERE ID_PESSOA = " & iSQ_PESSOA & " AND RTRIM(CD_NUMERO) = " & FNC_QuotedStr(Trim(CD_NUMERO))
    iSQ_PESSOA_TELEFONE = DBQuery_ValorUnico(sSqlText, 0)

    If iSQ_PESSOA_TELEFONE = 0 Then
      FormPesquisaPessoa_GravarTelefone(iSQ_PESSOA_TELEFONE, iSQ_PESSOA, TipoTelefone, CD_NUMERO, "")
    End If

    Return iSQ_PESSOA_TELEFONE
  End Function

  Public Function FormCadastroPessoa_GravarPessoa(ByRef iSQ_PESSOA As Integer,
                                                  sNO_PESSOA As String,
                                                  sNO_MAE As String,
                                                  dDT_NASC_ABERTURA As Date,
                                                  iID_TIPO_PESSOA As Integer,
                                                  sDS_PATH_IMAGEM As String,
                                                  sCD_CPF_CNPJ As String,
                                                  iID_PF_TIPO_ESTADOCIVIL As Integer,
                                                  iID_PF_NACIONALIDADE As Integer,
                                                  iID_PF_TIPO_ESCOLARIDADE As Integer,
                                                  iID_PF_NATURALIDADE As Integer,
                                                  iID_PF_TIPO_RACA As Integer,
                                                  iID_PF_TIPO_RELIGIAO As Integer,
                                                  iID_PF_TIPO_SEXO As Integer,
                                                  iID_OPT_SITUACAOPROFISSIONAL As Integer,
                                                  iID_OPT_PJ_CONTRIBUICAO_ICMS As Integer,
                                                  iID_PESSOA_RESPONSAVEL As Integer,
                                                  sCD_PF_RG As String,
                                                  sCD_PF_CARTAO_SEGURIDADE As String,
                                                  sNO_FANTASIA_REDUZIDO As String,
                                                  sCD_PJ_IE As String,
                                                  sCD_PJ_IM As String,
                                                  iID_OPT_ATIVO As Integer) As Boolean
    Dim sSqlText As String

    Try
      sSqlText = DBMontar_SP("SP_PESSOA_CAD", False, "@SQ_PESSOA OUT",
                                                     "@ID_EMPRESA",
                                                     "@NO_PESSOA",
                                                     "@NO_MAE",
                                                     "@DT_NASC_ABERTURA",
                                                     "@ID_TIPO_PESSOA",
                                                     "@DS_PATH_IMAGEM",
                                                     "@CD_CPF_CNPJ",
                                                     "@ID_PF_TIPO_ESTADOCIVIL",
                                                     "@ID_PF_NACIONALIDADE",
                                                     "@ID_PF_TIPO_ESCOLARIDADE",
                                                     "@ID_PF_NATURALIDADE",
                                                     "@ID_PF_TIPO_RACA",
                                                     "@ID_PF_TIPO_RELIGIAO",
                                                     "@ID_PF_TIPO_SEXO",
                                                     "@ID_OPT_SITUACAOPROFISSIONAL",
                                                     "@ID_OPT_PJ_CONTRIBUICAO_ICMS",
                                                     "@ID_PESSOA_RESPONSAVEL",
                                                     "@CD_PF_RG",
                                                     "@CD_PF_CARTAO_SEGURIDADE",
                                                     "@NO_FANTASIA_REDUZIDO",
                                                     "@CD_PJ_IE",
                                                     "@CD_PJ_IM",
                                                     "@ID_OPT_ATIVO")
      If DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA", iSQ_PESSOA, , ParameterDirection.InputOutput),
                              DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                              DBParametro_Montar("NO_PESSOA", sNO_PESSOA),
                              DBParametro_Montar("NO_MAE", sNO_MAE),
                              DBParametro_Montar("DT_NASC_ABERTURA", IIf(dDT_NASC_ABERTURA = Nothing, Nothing, dDT_NASC_ABERTURA)),
                              DBParametro_Montar("ID_TIPO_PESSOA", iID_TIPO_PESSOA),
                              DBParametro_Montar("DS_PATH_IMAGEM", FNC_NuloSe(Trim(sDS_PATH_IMAGEM), "")),
                              DBParametro_Montar("CD_CPF_CNPJ", FNC_SoNumero(sCD_CPF_CNPJ)),
                              DBParametro_Montar("ID_PF_TIPO_ESTADOCIVIL", FNC_NuloSe(iID_PF_TIPO_ESTADOCIVIL, 0)),
                              DBParametro_Montar("ID_PF_NACIONALIDADE", FNC_NuloSe(iID_PF_NACIONALIDADE, 0)),
                              DBParametro_Montar("ID_PF_TIPO_ESCOLARIDADE", FNC_NuloSe(iID_PF_TIPO_ESCOLARIDADE, 0)),
                              DBParametro_Montar("ID_PF_NATURALIDADE", FNC_NuloSe(iID_PF_NATURALIDADE, 0)),
                              DBParametro_Montar("ID_PF_TIPO_RACA", FNC_NuloSe(iID_PF_TIPO_RACA, 0)),
                              DBParametro_Montar("ID_PF_TIPO_RELIGIAO", FNC_NuloSe(iID_PF_TIPO_RELIGIAO, 0)),
                              DBParametro_Montar("ID_PF_TIPO_SEXO", FNC_NuloSe(iID_PF_TIPO_SEXO, 0)),
                              DBParametro_Montar("ID_OPT_SITUACAOPROFISSIONAL", FNC_NuloSe(iID_OPT_SITUACAOPROFISSIONAL, 0)),
                              DBParametro_Montar("ID_OPT_PJ_CONTRIBUICAO_ICMS", FNC_NuloSe(iID_OPT_PJ_CONTRIBUICAO_ICMS, 0)),
                              DBParametro_Montar("ID_PESSOA_RESPONSAVEL", FNC_NuloSe(iID_PESSOA_RESPONSAVEL, 0)),
                              DBParametro_Montar("CD_PF_RG", FNC_NuloSe(Trim(sCD_PF_RG), "")),
                              DBParametro_Montar("CD_PF_CARTAO_SEGURIDADE", FNC_NuloSe(Trim(sCD_PF_CARTAO_SEGURIDADE), "")),
                              DBParametro_Montar("NO_FANTASIA_REDUZIDO", FNC_NuloSe(Trim(sNO_FANTASIA_REDUZIDO), "")),
                              DBParametro_Montar("CD_PJ_IE", FNC_NuloSe(Trim(sCD_PJ_IE), "")),
                              DBParametro_Montar("CD_PJ_IM", FNC_NuloSe(Trim(sCD_PJ_IM), "")),
                              DBParametro_Montar("ID_OPT_ATIVO", IIf(iID_OPT_ATIVO = 0, enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode, iID_OPT_ATIVO))) Then
        If DBTeveRetorno() Then
          iSQ_PESSOA = DBRetorno(1)
        End If

        Return True
      Else
        Return False
      End If
    Catch ex As Exception
      FNC_Mensagem("FormCadastroPessoa_GravarPessoa - " & ex.Message)
      Return False
    End Try
  End Function

  Public Sub FormCadastroPessoa_HistoricoFinanceiro_FormatarGrid(oGrid As UltraWinGrid.UltraGrid, oDB As UltraWinDataSource.UltraDataSource)
    objGrid_Inicializar(oGrid, , oDB, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(oGrid, "ID_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(oGrid, "SQ_MOVFINANCEIRAPARCELA", 0)
    objGrid_Coluna_Add(oGrid, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(oGrid, "Código", 80)
    objGrid_Coluna_Add(oGrid, "Status", 100)
    objGrid_Coluna_Add(oGrid, "Descrição da Movimentação", 150)
    objGrid_Coluna_Add(oGrid, "Tipo de Documento", 150)
    objGrid_Coluna_Add(oGrid, "Data Movimentação", 150, , , ColumnStyle.Date)
    objGrid_Coluna_Add(oGrid, "Data Vencimento", 150, , , ColumnStyle.Date)
    objGrid_Coluna_Add(oGrid, "Data Quitação", 150, , , ColumnStyle.Date)
    objGrid_Coluna_Add(oGrid, "Valor Parcela", 150)
    objGrid_Coluna_Add(oGrid, "Valor Em Aberto", 150)
    objGrid_Coluna_Add(oGrid, "Emitente", 150)
  End Sub

  Public Sub FormCadastroPessoa_HistoricoCompra_CarregarGrid(oGrid As UltraWinGrid.UltraGrid, iID_PESSOA As Integer)
    Dim sSqlText As String

    sSqlText = "SELECT PDPRD.SQ_PEDIDO_PRODUTO," &
                      "PEDID.DH_PEDIDO," &
                      "PEDID.CD_PEDIDO," &
                      "PDPRD.NO_PRODUTO," &
                      "PDPRD.QT_FATURADA," &
                      "PDPRD.VL_UNITARIO," &
                      "(PDPRD.QT_FATURADA * PDPRD.VL_UNITARIO) VL_TOTAL," &
                      "PDPRD.VL_DESCONTO" &
               " FROM VW_PEDIDO_PRODUTO PDPRD" &
                " INNER JOIN VW_PEDIDO PEDID ON PEDID.SQ_PEDIDO = PDPRD.ID_PEDIDO" &
                " WHERE PEDID.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                  " AND PEDID.ID_PESSOA = " & iID_PESSOA &
                " ORDER BY PEDID.DH_PEDIDO, PEDID.CD_PEDIDO"
    objGrid_Carregar(oGrid, sSqlText, New Integer() {const_GridListagemHistoricoCompra_SQ_PEDIDO_PRODUTO,
                                                     const_GridListagemHistoricoCompra_DH_PEDIDO,
                                                     const_GridListagemHistoricoCompra_CD_PEDIDO,
                                                     const_GridListagemHistoricoCompra_NO_PRODUTO,
                                                     const_GridListagemHistoricoCompra_QT_FATURADA,
                                                     const_GridListagemHistoricoCompra_VL_UNITARIO,
                                                     const_GridListagemHistoricoCompra_VL_TOTAL,
                                                     const_GridListagemHistoricoCompra_VL_DESCONTO})
  End Sub

  Public Sub FormCadastroPessoa_HistoricoFinanceiro_CarregarGrid(oGrid As UltraWinGrid.UltraGrid, iID_PESSOA As Integer)
    Dim sSqlText As String

    sSqlText = "SELECT MFP.ID_MOVFINANCEIRA," &
                      "MFP.SQ_MOVFINANCEIRAPARCELA," &
                      "MFP.ID_OPT_STATUS," &
                      "CONCAT(MFN.CD_MOVFINANCEIRA, '-', MFP.CD_PARCELA) CD_MOVFINANCEIRA_PARCELA," &
                      "STS.NO_OPCAO," &
                      "MFN.DS_MOVFINANCEIRA," &
                      "TDC.NO_TIPO_DOCUMENTO," &
                      "MFN.DT_MOVIMENTACAO," &
                      "MFP.DT_VENCIMENTO," &
                      "MFP.DT_QUITACAO," &
                      "MFP.VL_PARCELA," &
                      "MFP.VL_PARCELA - MFP.VL_QUITADO," &
                      "MFP.DS_EMITENTE" &
              " FROM TB_MOVFINANCEIRA MFN" &
               " INNER JOIN TB_MOVFINANCEIRAPARCELA MFP ON MFP.ID_MOVFINANCEIRA = MFN.SQ_MOVFINANCEIRA" &
                " LEFT JOIN TB_TIPO_DOCUMENTO TDC ON TDC.SQ_TIPO_DOCUMENTO = MFP.ID_TIPO_DOCUMENTO" &
                " LEFT JOIN TB_OPCAO STS ON STS.SQ_OPCAO = MFP.ID_OPT_STATUS" &
              " WHERE MFN.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                " AND MFN.ID_PESSOA = " & iID_PESSOA

    objGrid_Carregar(oGrid, sSqlText, New Integer() {const_GridListagemHistoricoFinanceiro_ID_MOVFINANCEIRA,
                                                     const_GridListagemHistoricoFinanceiro_SQ_MOVFINANCEIRAPARCELA,
                                                     const_GridListagemHistoricoFinicaneiro_ID_OPT_STATUS,
                                                     const_GridListagemHistoricoFinanceiro_Codigo,
                                                     const_GridListagemHistoricoFinanceiro_Status,
                                                     const_GridListagemHistoricoFinanceiro_DescricaoMovimentacao,
                                                     const_GridListagemHistoricoFinanceiro_TipoDocumento,
                                                     const_GridListagemHistoricoFinanceiro_DataMovimentação,
                                                     const_GridListagemHistoricoFinanceiro_DataVencimento,
                                                     const_GridListagemHistoricoFinanceiro_DataQuitação,
                                                     const_GridListagemHistoricoFinanceiro_ValorParcela,
                                                     const_GridListagemHistoricoFinanceiro_ValorEmAberto,
                                                     const_GridListagemHistoricoFinanceiro_Emitente})
  End Sub

  Public Function FormCadastroPessoaEmpresa_GravarPessoa(iID_PESSOA As Integer,
                                                         iID_EMPRESA As Integer,
                                                         bIC_CLIENTE As Boolean,
                                                         bIC_FABRICANTE As Boolean,
                                                         bIC_FORNECEDOR As Boolean,
                                                         bIC_FUNCIONARIO As Boolean,
                                                         bIC_PACIENTE As Boolean,
                                                         bIC_PROFISSIONAL As Boolean,
                                                         bIC_TRANSPORTADORA As Boolean,
                                                         bIC_VENDEDOR As Boolean,
                                                         iID_CLIENTE_TABELAPRECO_PADRAO As Integer,
                                                         bIC_CLIENTE_BLOQUEAR_VENDA As Boolean,
                                                         bIC_CLIENTE_ATIVO As Boolean,
                                                         sDS_CLIENTE_COMENTARIO As String,
                                                         bIC_FABRICANTE_ATIVO As Boolean,
                                                         bIC_FORNECEDOR_ATIVO As Boolean,
                                                         bIC_FORNECEDOR_PRESTADORSERVICOMEDICO As Boolean,
                                                         sCM_FORNECEDOR_OBSERVACAO As String,
                                                         iID_FUNCIONARIO_TIPO_CARGO As Integer,
                                                         dDT_FUNCIONARIO_ADMISSAO As Date,
                                                         dDT_FUNCIONARIO_DESLIGAMENTO As Date,
                                                         bIC_FUNCIONARIO_ATIVO As Boolean,
                                                         bIC_FUNCIONARIO_ACESSO_SISTEMACHAMADA As Boolean,
                                                         sDS_PACIENTE_COMENTARIO As String,
                                                         sDS_PACIENTE_PENDENCIAS As String,
                                                         iID_PACIENTE_TIPO_PACIENTE As Integer,
                                                         bIC_PACIENTE_ATIVO As Boolean,
                                                         iID_PROFISSIONAL_CONSELHOPROFISSIONAL As Integer,
                                                         sNR_PROFISSIONAL_CONSELHOPROFISSIONAL As String,
                                                         bIC_PROFISSIONAL_ATIVO As Boolean,
                                                         bIC_PROFISSIONAL_SERVICO_INTERNO As Boolean,
                                                         bIC_PROFISSIONAL_RETEMIMPOSTO As Boolean,
                                                         dPC_PROFISSIONAL_RETEMIMPOSTO As Double,
                                                         bIC_TRANSPORTADORA_ATIVO As Boolean,
                                                         bIC_VENDEDOR_ATIVO As Boolean,
                                                         bIC_INDICADOR_ATIVO As Boolean,
                                                         iID_INDICADOR_TIPOINDICADOR As Integer,
                                                         dDT_INDICADOR_CADASTRO As Date) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_EMPRESA_CAD", False, "@ID_PESSOA",
                                                           "@ID_EMPRESA",
                                                           "@IC_CLIENTE",
                                                           "@IC_FABRICANTE",
                                                           "@IC_FORNECEDOR",
                                                           "@IC_FUNCIONARIO",
                                                           "@IC_PACIENTE",
                                                           "@IC_PROFISSIONAL",
                                                           "@IC_TRANSPORTADORA",
                                                           "@IC_VENDEDOR",
                                                           "@ID_CLIENTE_TABELAPRECO_PADRAO",
                                                           "@IC_CLIENTE_BLOQUEAR_VENDA",
                                                           "@IC_CLIENTE_ATIVO",
                                                           "@DS_CLIENTE_COMENTARIO",
                                                           "@IC_FABRICANTE_ATIVO",
                                                           "@IC_FORNECEDOR_ATIVO",
                                                           "@IC_FORNECEDOR_PRESTADORSERVICOMEDICO",
                                                           "@CM_FORNECEDOR_OBSERVACAO",
                                                           "@ID_FUNCIONARIO_TIPO_CARGO",
                                                           "@DT_FUNCIONARIO_ADMISSAO",
                                                           "@DT_FUNCIONARIO_DESLIGAMENTO",
                                                           "@IC_FUNCIONARIO_ATIVO",
                                                           "@IC_FUNCIONARIO_ACESSO_SISTEMACHAMADA",
                                                           "@DS_PACIENTE_COMENTARIO",
                                                           "@DS_PACIENTE_PENDENCIAS",
                                                           "@ID_PACIENTE_TIPO_PACIENTE",
                                                           "@IC_PACIENTE_ATIVO",
                                                           "@ID_PROFISSIONAL_CONSELHOPROFISSIONAL",
                                                           "@NR_PROFISSIONAL_CONSELHOPROFISSIONAL",
                                                           "@IC_PROFISSIONAL_ATIVO",
                                                           "@IC_PROFISSIONAL_SERVICO_INTERNO",
                                                           "@IC_PROFISSIONAL_RETEMIMPOSTO",
                                                           "@PC_PROFISSIONAL_RETEMIMPOSTO",
                                                           "@IC_TRANSPORTADORA_ATIVO",
                                                           "@IC_VENDEDOR_ATIVO",
                                                           "@IC_INDICADOR",
                                                           "@IC_INDICADOR_ATIVO",
                                                           "@ID_INDICADOR_TIPOINDICADOR",
                                                           "@DT_INDICADOR_CADASTRO")
    If DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA),
                            DBParametro_Montar("IC_CLIENTE", IIf(bIC_CLIENTE, "S", "N")),
                            DBParametro_Montar("IC_FABRICANTE", IIf(bIC_FABRICANTE, "S", "N")),
                            DBParametro_Montar("IC_FORNECEDOR", IIf(bIC_FORNECEDOR, "S", "N")),
                            DBParametro_Montar("IC_FUNCIONARIO", IIf(bIC_FUNCIONARIO, "S", "N")),
                            DBParametro_Montar("IC_PACIENTE", IIf(bIC_PACIENTE, "S", "N")),
                            DBParametro_Montar("IC_PROFISSIONAL", IIf(bIC_PROFISSIONAL, "S", "N")),
                            DBParametro_Montar("IC_TRANSPORTADORA", IIf(bIC_TRANSPORTADORA, "S", "N")),
                            DBParametro_Montar("IC_VENDEDOR", IIf(bIC_VENDEDOR, "S", "N")),
                            DBParametro_Montar("ID_CLIENTE_TABELAPRECO_PADRAO", FNC_NuloZero(iID_CLIENTE_TABELAPRECO_PADRAO, False)),
                            DBParametro_Montar("IC_CLIENTE_BLOQUEAR_VENDA", IIf(bIC_CLIENTE_BLOQUEAR_VENDA, "S", "N")),
                            DBParametro_Montar("IC_CLIENTE_ATIVO", IIf(bIC_CLIENTE_ATIVO, "S", "N")),
                            DBParametro_Montar("DS_CLIENTE_COMENTARIO", FNC_NuloString(sDS_CLIENTE_COMENTARIO, False)),
                            DBParametro_Montar("IC_FABRICANTE_ATIVO", IIf(bIC_FABRICANTE_ATIVO, "S", "N")),
                            DBParametro_Montar("IC_FORNECEDOR_ATIVO", IIf(bIC_FORNECEDOR_ATIVO, "S", "N")),
                            DBParametro_Montar("IC_FORNECEDOR_PRESTADORSERVICOMEDICO", IIf(bIC_FORNECEDOR_PRESTADORSERVICOMEDICO, "S", "N")),
                            DBParametro_Montar("CM_FORNECEDOR_OBSERVACAO", FNC_NuloString(sCM_FORNECEDOR_OBSERVACAO, False)),
                            DBParametro_Montar("ID_FUNCIONARIO_TIPO_CARGO", FNC_NuloZero(iID_FUNCIONARIO_TIPO_CARGO, False)),
                            DBParametro_Montar("DT_FUNCIONARIO_ADMISSAO", FNC_NuloData(dDT_FUNCIONARIO_ADMISSAO), SqlDbType.DateTime),
                            DBParametro_Montar("DT_FUNCIONARIO_DESLIGAMENTO", FNC_NuloData(dDT_FUNCIONARIO_DESLIGAMENTO), SqlDbType.DateTime),
                            DBParametro_Montar("IC_FUNCIONARIO_ATIVO", IIf(bIC_FUNCIONARIO_ATIVO, "S", "N")),
                            DBParametro_Montar("IC_FUNCIONARIO_ACESSO_SISTEMACHAMADA", IIf(bIC_FUNCIONARIO_ACESSO_SISTEMACHAMADA, "S", "N")),
                            DBParametro_Montar("DS_PACIENTE_COMENTARIO", FNC_NuloString(sDS_PACIENTE_COMENTARIO, False)),
                            DBParametro_Montar("DS_PACIENTE_PENDENCIAS", FNC_NuloString(sDS_PACIENTE_PENDENCIAS, False)),
                            DBParametro_Montar("ID_PACIENTE_TIPO_PACIENTE", FNC_NuloZero(iID_PACIENTE_TIPO_PACIENTE, False)),
                            DBParametro_Montar("IC_PACIENTE_ATIVO", IIf(bIC_PACIENTE_ATIVO, "S", "N")),
                            DBParametro_Montar("ID_PROFISSIONAL_CONSELHOPROFISSIONAL", FNC_NuloZero(iID_PROFISSIONAL_CONSELHOPROFISSIONAL, False)),
                            DBParametro_Montar("NR_PROFISSIONAL_CONSELHOPROFISSIONAL", FNC_NuloString(sNR_PROFISSIONAL_CONSELHOPROFISSIONAL, False)),
                            DBParametro_Montar("IC_PROFISSIONAL_ATIVO", IIf(bIC_PROFISSIONAL_ATIVO, "S", "N")),
                            DBParametro_Montar("IC_PROFISSIONAL_SERVICO_INTERNO", IIf(bIC_PROFISSIONAL_SERVICO_INTERNO, "S", "N")),
                            DBParametro_Montar("IC_PROFISSIONAL_RETEMIMPOSTO", IIf(bIC_PROFISSIONAL_RETEMIMPOSTO, "S", "N")),
                            DBParametro_Montar("PC_PROFISSIONAL_RETEMIMPOSTO", dPC_PROFISSIONAL_RETEMIMPOSTO),
                            DBParametro_Montar("IC_TRANSPORTADORA_ATIVO", IIf(bIC_TRANSPORTADORA_ATIVO, "S", "N")),
                            DBParametro_Montar("IC_VENDEDOR_ATIVO", IIf(bIC_VENDEDOR_ATIVO, "S", "N")),
                            DBParametro_Montar("IC_INDICADOR", IIf(bIC_INDICADOR_ATIVO, "S", "N")),
                            DBParametro_Montar("IC_INDICADOR_ATIVO", IIf(bIC_INDICADOR_ATIVO, "S", "N")),
                            DBParametro_Montar("ID_INDICADOR_TIPOINDICADOR", FNC_NuloZero(iID_INDICADOR_TIPOINDICADOR, False)),
                            DBParametro_Montar("DT_INDICADOR_CADASTRO", FNC_NuloData(dDT_INDICADOR_CADASTRO), SqlDbType.DateTime)) Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Function FormCadastroProduto_BuscarOrigemProduto(sCodigo As String) As Integer
    Dim sSql As String

    sSql = "SELECT SQ_OPCAO FROM TB_OPCAO WHERE RTRIM(CD_OPCAO) = " & FNC_QuotedStr(sCodigo)

    Return DBQuery_ValorUnico(sSql, -1)
  End Function

  Public Function FormCadastroProduto_BuscarCST_Zeus(iCST_Grupo As Integer, sCodigo As String) As Integer
    Dim sSql As String

    sSql = "SELECT SQ_CST FROM TB_CST WHERE RTRIM(CD_REF_PROJETOZEUS) = " & FNC_QuotedStr(sCodigo) & "AND ID_CST_GRUPO = " & iCST_Grupo.ToString()

    Return DBQuery_ValorUnico(sSql, -1)
  End Function

  Public Sub FormCadastroPessoa_CarregarEnderecoTelefoneEMail(ByVal iSQ_PESSOA As Integer,
                                                              Optional ByVal ComboBox_EMail As ComboBox = Nothing,
                                                              Optional ByVal ComboBox_Telefone As ComboBox = Nothing,
                                                              Optional ByVal ComboBox_Endereco As ComboBox = Nothing,
                                                              Optional ByVal psqPessoa As uscPesqPessoa = Nothing)
    If iSQ_PESSOA > 0 Then
      If Not psqPessoa Is Nothing Then
        psqPessoa.Text = psqPessoa.cboPessoa.SelectedItem(const_GridListagemPessoa_CPF_CNPJ).ToString()
      End If

      ComboBox_Endereco.SelectedIndex = -1

      If Not ComboBox_Endereco Is Nothing Then FormCadastroPessoa_CarregarEnderecoPessoa(iSQ_PESSOA, ComboBox_Endereco, True)
      If Not ComboBox_Telefone Is Nothing Then ComboBox_Carregar(ComboBox_Telefone, enSql.Telefone, New Object() {iSQ_PESSOA}, True)
      If Not ComboBox_EMail Is Nothing Then ComboBox_Carregar(ComboBox_EMail, enSql.MidiaSocial_EMail, New Object() {iSQ_PESSOA}, True)
    Else
      If Not ComboBox_Endereco Is Nothing Then ComboBox_Endereco.DataSource = Nothing
      If Not ComboBox_Telefone Is Nothing Then ComboBox_Telefone.DataSource = Nothing
      If Not ComboBox_EMail Is Nothing Then ComboBox_EMail.DataSource = Nothing
    End If
  End Sub

  Public Sub FormCadastroPessoa_CarregarEnderecoPessoa(iSQ_PESSOA As Integer,
                                                       oComboBox_Endereco As ComboBox,
                                                       Optional bAutoSelecionar As Boolean = False)
    Dim iAux As Integer

    iAux = FNC_NVL(oComboBox_Endereco.SelectedValue, 0)
    ComboBox_Carregar(oComboBox_Endereco, enSql.Endereco, New Object() {iSQ_PESSOA}, bAutoSelecionar)
    If iAux <> 0 Then ComboBox_Selecionar(oComboBox_Endereco, iAux)
  End Sub

  Public Function FormCadastroPessoaEmpresa_GravarPaciente(iID_PESSOA As Integer,
                                                           iID_EMPRESA As Integer,
                                                           iID_CLIENTE_TABELAPRECO_PADRAO As Integer,
                                                           bIC_CLIENTE_BLOQUEAR_VENDA As Boolean,
                                                           sDS_PACIENTE_COMENTARIO As String,
                                                           sDS_PACIENTE_PENDENCIAS As String,
                                                           iID_PACIENTE_TIPO_PACIENTE As Integer,
                                                           bIC_PACIENTE_ATIVO As Boolean,
                                                           iID_INDICACAO As Integer,
                                                           Optional bSomenteVinculo As Boolean = False) As Boolean
    Dim sSqlText As String

    Try
      sSqlText = DBMontar_SP("SP_PESSOA_EMPRESA_PACIENTE_UPD", False, "@ID_PESSOA",
                                                                      "@ID_EMPRESA",
                                                                      "@ID_CLIENTE_TABELAPRECO_PADRAO",
                                                                      "@IC_CLIENTE_BLOQUEAR_VENDA",
                                                                      "@DS_PACIENTE_COMENTARIO",
                                                                      "@DS_PACIENTE_PENDENCIAS",
                                                                      "@ID_PACIENTE_TIPO_PACIENTE",
                                                                      "@IC_PACIENTE_ATIVO",
                                                                      "@ID_INDICACAO",
                                                                      "@IC_SOMENTE_VINCULAR")
      If DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                              DBParametro_Montar("ID_EMPRESA", iID_EMPRESA),
                              DBParametro_Montar("ID_CLIENTE_TABELAPRECO_PADRAO", FNC_NuloZero(iID_CLIENTE_TABELAPRECO_PADRAO, False)),
                              DBParametro_Montar("IC_CLIENTE_BLOQUEAR_VENDA", IIf(bIC_CLIENTE_BLOQUEAR_VENDA, "S", "N")),
                              DBParametro_Montar("DS_PACIENTE_COMENTARIO", FNC_NuloString(sDS_PACIENTE_COMENTARIO, False), , , 1000),
                              DBParametro_Montar("DS_PACIENTE_PENDENCIAS", FNC_NuloString(sDS_PACIENTE_PENDENCIAS, False), , , 1000),
                              DBParametro_Montar("ID_PACIENTE_TIPO_PACIENTE", FNC_NuloZero(iID_PACIENTE_TIPO_PACIENTE, False)),
                              DBParametro_Montar("IC_PACIENTE_ATIVO", IIf(bIC_PACIENTE_ATIVO, "S", "N")),
                              DBParametro_Montar("ID_INDICACAO", FNC_NuloZero(iID_INDICACAO, False)),
                              DBParametro_Montar("IC_SOMENTE_VINCULAR", IIf(bSomenteVinculo, "S", "N"))) Then
        Return True
      Else
        Return False
      End If
    Catch ex As Exception
      FNC_Mensagem("FormCadastroPessoaEmpresa_GravarPaciente - " & ex.Message)
      Return False
    End Try
  End Function

  Public Function FormPesquisaPessoa_GravarEndereco(ByRef iSQ_ENDERECO As Integer,
                                                    iSQ_PESSOA As Integer,
                                                    iID_TIPO_ENDERECO As Integer,
                                                    iID_CIDADE As Integer,
                                                    sDS_LOGRADOURO As String,
                                                    sNO_BAIRRO As String,
                                                    sNR_LOGRADOURO As String,
                                                    sDS_COMPLEMENTO As String,
                                                    sCD_CEP As String,
                                                    sIC_ATIVO As String) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_ENDERECO_CAD", False, "@SQ_ENDERECO OUT",
                                                     "@ID_PESSOA",
                                                     "@ID_TIPO_ENDERECO",
                                                     "@ID_CIDADE",
                                                     "@DS_LOGRADOURO",
                                                     "@NO_BAIRRO",
                                                     "@NR_LOGRADOURO",
                                                     "@DS_COMPLEMENTO",
                                                     "@CD_CEP",
                                                     "@IC_ATIVO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_ENDERECO", iSQ_ENDERECO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                            DBParametro_Montar("ID_TIPO_ENDERECO", iID_TIPO_ENDERECO),
                            DBParametro_Montar("ID_CIDADE", iID_CIDADE),
                            DBParametro_Montar("DS_LOGRADOURO", sDS_LOGRADOURO),
                            DBParametro_Montar("NO_BAIRRO", sNO_BAIRRO),
                            DBParametro_Montar("NR_LOGRADOURO", sNR_LOGRADOURO),
                            DBParametro_Montar("DS_COMPLEMENTO", sDS_COMPLEMENTO),
                            DBParametro_Montar("CD_CEP", sCD_CEP),
                            DBParametro_Montar("IC_ATIVO", sIC_ATIVO)) Then
      If DBTeveRetorno() Then
        iSQ_ENDERECO = DBRetorno(1)
      End If

      Return True
    Else
      Return False
    End If
  End Function

  Public Sub FormPesquisaPessoa_TelefoneWhatsApp_Limpar(Optional ByRef oTelefone01 As TextBox = Nothing,
                                                        Optional ByRef oTelefone02 As TextBox = Nothing,
                                                        Optional ByRef oTelefone03 As TextBox = Nothing)
    If Not oTelefone01 Is Nothing Then FormPesquisaPessoa_TelefoneWhatsApp(oTelefone01, True)
    If Not oTelefone02 Is Nothing Then FormPesquisaPessoa_TelefoneWhatsApp(oTelefone02, True)
    If Not oTelefone03 Is Nothing Then FormPesquisaPessoa_TelefoneWhatsApp(oTelefone03, True)
  End Sub

  Public Sub FormPesquisaPessoa_TelefoneWhatsApp(oTexto As TextBox,
                                                 Optional bLimpando As Boolean = False,
                                                 Optional oToolTip As System.Windows.Forms.ToolTip = Nothing)
    oTexto.Tag = IIf(bLimpando Or FNC_NVL(oTexto.Tag, "") = const_TelefoneWhatsApp, Nothing, const_TelefoneWhatsApp)
    oTexto.BackColor = IIf(oTexto.Tag = Nothing, System.Drawing.SystemColors.Window, Color.Green)
    oTexto.ForeColor = IIf(oTexto.Tag = Nothing, System.Drawing.SystemColors.WindowText, Color.White)
    If Not oToolTip Is Nothing Then oToolTip.SetToolTip(oTexto, IIf(oTexto.Tag = Nothing, "", "WhatsApp"))
  End Sub

  Public Function FormCadastro_Telefone_Tratar(oComboTipo As ComboBox,
                                                     oTextNumero As TextBox,
                                                     oTextTelefoneComentario As TextBox) As Boolean
    Dim bOk As Boolean = True
    Dim sMens As String

    sMens = IIf(oTextNumero.Text.Trim() <> "", " do número de telefone " & oTextNumero.Text,
                                               IIf(oComboTipo.SelectedIndex = -1, " do comentário " & oTextTelefoneComentario.Text,
                                                                                  " do tipo de telefone " & oComboTipo.Text))

    If oComboTipo.SelectedIndex > -1 Or
       oTextNumero.Text.Trim() <> "" Or
       oTextTelefoneComentario.Text.Trim() <> "" Then
      If Not ComboBox_Selecionado(oComboTipo) Then
        FNC_Mensagem("Informe o número do telefone ou limpe o tipo de telefone" & sMens)
        oTextNumero.Focus()
        bOk = False
      End If
      If oComboTipo.Text.Trim() = "" Then
        FNC_Mensagem("Selecione o tipo do telefone ou limpe o número telefone" & sMens)
        oComboTipo.Focus()
        bOk = False
      End If
    Else
      If oTextNumero.Text.Trim() = "" Then FormPesquisaPessoa_TelefoneWhatsApp_Limpar(oTextNumero)
    End If

    Return bOk
  End Function

  Public Function FormCadastroAgenda_Telefone_Gravar(ByRef iSQ_AGENDA_TELEFONE As Integer,
                                                     ByRef iSQ_AGENDA As Integer,
                                                     oComboTipo As ComboBox,
                                                     oTextNumero As TextBox,
                                                     oTextTelefoneComentario As TextBox) As Boolean
    Dim bOk As Boolean = False
    Dim sSqlText As String

    If ComboBox_Selecionado(oComboTipo) And
       oTextNumero.Text.Trim <> "" Then

      sSqlText = DBMontar_SP("SP_AGENDA_TELEFONE_CAD", False, "@SQ_AGENDA_TELEFONE OUT",
                                                              "@ID_AGENDA",
                                                              "@ID_TIPO_TELEFONE",
                                                              "@ID_PAIS",
                                                              "@CD_NUMERO",
                                                              "@IC_WHATSAPP",
                                                              "@CM_OBSERVACAO")
      bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDA_TELEFONE", iSQ_AGENDA_TELEFONE, , ParameterDirection.InputOutput),
                                 DBParametro_Montar("ID_AGENDA", iSQ_AGENDA),
                                 DBParametro_Montar("ID_TIPO_TELEFONE", oComboTipo.SelectedValue),
                                 DBParametro_Montar("ID_PAIS", 1),
                                 DBParametro_Montar("CD_NUMERO", oTextNumero.Text),
                                 DBParametro_Montar("IC_WHATSAPP", IIf(oTextNumero.Tag = const_TelefoneWhatsApp, "S", "N")),
                                 DBParametro_Montar("CM_OBSERVACAO", FNC_NuloString(oTextTelefoneComentario.Text, False), ,, const_BancoDados_TamanhoComentario))
    Else
      FNC_Mensagem("É preciso informar o tipo e número do telefone")
    End If

    Return bOk
  End Function

  Public Function FormEstoqueLancamento_Gravar(ByRef iSQ_ESTOQUE_LANCAMENTO As Integer,
                                               iID_PRODUTO_EMPRESA As Integer,
                                               iID_ESTOQUE_LOCALIZACAO_CREDITO As Integer,
                                               iID_ESTOQUE_LOCALIZACAO_DEBITO As Integer,
                                               iID_TRANSACAOESTOQUE As Integer,
                                               iID_MOVIMENTACAOESTOQUE As Integer,
                                               iID_DOCUMENTOFISCAL_PRODUTO As Integer,
                                               iID_PEDIDO_PRODUTO As Integer,
                                               sCD_NUMEROSERIE As String,
                                               dDH_LANCAMENTO As Date,
                                               dQT_LANCAMENTO As Double,
                                               dVL_UNITARIO As Double,
                                               sCM_LANCAMENTO As String) As Boolean
    Dim sSqlText As String
    Dim bOk = False

    sSqlText = DBMontar_SP("SP_ESTOQUE_LANCAMENTO_CAD", False, "@SQ_ESTOQUE_LANCAMENTO",
                                                               "@ID_EMPRESA",
                                                               "@ID_PRODUTO_EMPRESA",
                                                               "@ID_ESTOQUE_LOCALIZACAO_CREDITO",
                                                               "@ID_ESTOQUE_LOCALIZACAO_DEBITO",
                                                               "@ID_TRANSACAOESTOQUE",
                                                               "@ID_MOVIMENTACAOESTOQUE",
                                                               "@ID_DOCUMENTOFISCAL_PRODUTO",
                                                               "@ID_PEDIDO_PRODUTO",
                                                               "@CD_NUMEROSERIE",
                                                               "@DH_LANCAMENTO",
                                                               "@QT_LANCAMENTO",
                                                               "@VL_UNITARIO",
                                                               "@CM_LANCAMENTO",
                                                               "@IC_ERRO OUT")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_ESTOQUE_LANCAMENTO", iSQ_ESTOQUE_LANCAMENTO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_PRODUTO_EMPRESA", iID_PRODUTO_EMPRESA),
                            DBParametro_Montar("ID_ESTOQUE_LOCALIZACAO_CREDITO", FNC_NuloSe(iID_ESTOQUE_LOCALIZACAO_CREDITO, 0)),
                            DBParametro_Montar("ID_ESTOQUE_LOCALIZACAO_DEBITO", FNC_NuloSe(iID_ESTOQUE_LOCALIZACAO_DEBITO, 0)),
                            DBParametro_Montar("ID_TRANSACAOESTOQUE", iID_TRANSACAOESTOQUE),
                            DBParametro_Montar("ID_MOVIMENTACAOESTOQUE", FNC_NuloSe(iID_MOVIMENTACAOESTOQUE, 0)),
                            DBParametro_Montar("ID_DOCUMENTOFISCAL_PRODUTO", FNC_NuloSe(iID_DOCUMENTOFISCAL_PRODUTO, 0)),
                            DBParametro_Montar("ID_PEDIDO_PRODUTO", FNC_NuloSe(iID_PEDIDO_PRODUTO, 0)),
                            DBParametro_Montar("CD_NUMEROSERIE", FNC_NuloString(sCD_NUMEROSERIE, False)),
                            DBParametro_Montar("DH_LANCAMENTO", dDH_LANCAMENTO, SqlDbType.DateTime),
                            DBParametro_Montar("QT_LANCAMENTO", dQT_LANCAMENTO),
                            DBParametro_Montar("VL_UNITARIO", dVL_UNITARIO),
                            DBParametro_Montar("CM_LANCAMENTO", sCM_LANCAMENTO,,, const_BancoDados_TamanhoComentario),
                            DBParametro_Montar("IC_ERRO", Nothing, , ParameterDirection.InputOutput)) Then
      If DBTeveRetorno() Then
        iSQ_ESTOQUE_LANCAMENTO = DBRetorno(1)
        bOk = (DBRetorno(2) = "N")
      End If

      Return bOk
    Else
      Return bOk
    End If
  End Function

  Public Function FormPesquisaPessoa_GravarTelefone(ByRef iSQ_PESSOA_TELEFONE As Integer,
                                                    iSQ_PESSOA As Integer,
                                                    iID_TIPO_TELEFONE As Integer,
                                                    sCD_NUMERO As String,
                                                    sCM_OBSERVACAO As String,
                                                    Optional bIC_WHATSAPP As Boolean = False) As Integer
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_TELEFONE_CAD", False, "@SQ_PESSOA_TELEFONE OUT",
                                                            "@ID_PESSOA",
                                                            "@ID_TIPO_TELEFONE",
                                                            "@CD_NUMERO",
                                                            "@IC_WHATSAPP",
                                                            "@CM_OBSERVACAO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_TELEFONE", iSQ_PESSOA_TELEFONE, , ParameterDirection.InputOutput),
                         DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                         DBParametro_Montar("ID_TIPO_TELEFONE", iID_TIPO_TELEFONE),
                         DBParametro_Montar("CD_NUMERO", sCD_NUMERO),
                         DBParametro_Montar("IC_WHATSAPP", IIf(bIC_WHATSAPP, "S", "N")),
                         DBParametro_Montar("CM_OBSERVACAO", FNC_NuloString(sCM_OBSERVACAO, False), ,, const_BancoDados_TamanhoComentario))

    If DBTeveRetorno() Then
      iSQ_PESSOA_TELEFONE = DBRetorno(1)
    End If

    Return iSQ_PESSOA_TELEFONE
  End Function

  Public Function FormPesquisaPessoa_GravarMidiaSocial(ByRef iSQ_PESSOA_MIDIASOCIAL_EMAIL As Integer,
                                                       iSQ_PESSOA As Integer,
                                                       IID_TIPO_MIDIASOCIAL As Integer,
                                                       sDS_MIDIASOCIAL As String) As Integer
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_MIDIASOCIAL_CAD", False, "@SQ_PESSOA_MIDIASOCIAL OUT",
                                                               "@ID_PESSOA",
                                                               "@ID_TIPO_MIDIASOCIAL",
                                                               "@DS_MIDIASOCIAL")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_MIDIASOCIAL", iSQ_PESSOA_MIDIASOCIAL_EMAIL, , ParameterDirection.InputOutput),
                         DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                         DBParametro_Montar("ID_TIPO_MIDIASOCIAL", IID_TIPO_MIDIASOCIAL),
                         DBParametro_Montar("DS_MIDIASOCIAL", sDS_MIDIASOCIAL))

    If DBTeveRetorno() Then
      iSQ_PESSOA_MIDIASOCIAL_EMAIL = DBRetorno(1)
    End If

    Return iSQ_PESSOA_MIDIASOCIAL_EMAIL
  End Function

  Public Function FormPesquisaPessoa_ExisteFornecedor(ByRef iSQ_PESSOA As Integer, sCD_CPF_CNPJ As String) As Boolean
    Dim oData As DataTable
    Dim sSqlText As String
    Dim bOk As Boolean = False

    iSQ_PESSOA = 0

    sSqlText = "SELECT SQ_PESSOA, IC_FORNECEDOR" &
               " FROM VW_PESSOA_NOME" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND CD_CPF_CNPJ = " & FNC_QuotedStr(FNC_SoNumero(Trim(sCD_CPF_CNPJ)))
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      iSQ_PESSOA = oData.Rows(0).Item("SQ_PESSOA")
      bOk = (FNC_NVL(oData.Rows(0).Item("IC_FORNECEDOR"), "N") = "S")
    End If

    oData.Dispose()

    Return bOk
  End Function

  Public Function FormPesquisaPessoa_ExisteTransportadora(ByRef iSQ_PESSOA As Integer, sCD_CPF_CNPJ As String) As Boolean
    Dim oData As DataTable
    Dim sSqlText As String
    Dim bOk As Boolean = False

    iSQ_PESSOA = 0

    sSqlText = "SELECT SQ_PESSOA, IC_TRANSPORTADORA" &
               " FROM VW_PESSOA_NOME" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND CD_CPF_CNPJ = " & FNC_QuotedStr(FNC_SoNumero(Trim(sCD_CPF_CNPJ)))
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      iSQ_PESSOA = oData.Rows(0).Item("SQ_PESSOA")
      bOk = (FNC_NVL(oData.Rows(0).Item("IC_TRANSPORTADORA"), "N") = "S")
    End If

    oData.Dispose()

    Return bOk
  End Function

  Public Function FormPesquisaPessoa_ExisteEndereco(ByRef iSQ_ENDERECO As Integer,
                                                    iSQ_PESSOA As Integer,
                                                    sIBGE_Municipio As String,
                                                    sBairro As String,
                                                    sNumero As String,
                                                    sCEP As String,
                                                    sLogradouro As String) As Boolean
    Dim oData As DataTable
    Dim sSqlText As String
    Dim bOk As Boolean = False
    Dim bAchou As Boolean
    Dim iCont As Integer

    iSQ_ENDERECO = 0

    sSqlText = "SELECT * FROM VW_ENDERECO" &
               " WHERE ID_PESSOA = " & iSQ_PESSOA &
                 " AND CD_IBGE = " & sIBGE_Municipio &
                 " AND LTRIM(RTRIM(NO_BAIRRO)) = " & FNC_QuotedStr(Trim(sBairro)) &
                 " AND ISNULL(NR_LOGRADOURO, " & FNC_QuotedStr(Trim(sNumero)) & ") = " & FNC_QuotedStr(Trim(sNumero))

    If Trim(sCEP) <> "" Then
      sSqlText = sSqlText & " AND LTRIM(RTRIM(dbo.FC_SoNumero(CD_CEP))) = " & Trim(FNC_SoNumero(sCEP))
    End If
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      For iCont = 0 To oData.Rows.Count - 1
        If Trim(oData.Rows(iCont).Item("DS_LOGRADOURO")) = Trim(sLogradouro) Then
          iSQ_ENDERECO = oData.Rows(iCont).Item("SQ_ENDERECO")
          bAchou = True
          Exit For
        End If
      Next

      If Not bAchou Then
        iSQ_ENDERECO = oData.Rows(0).Item("SQ_ENDERECO")
      End If

      bOk = True
    End If

    oData.Dispose()

    Return bOk
  End Function

  Public Sub FormPesquisaPessoa_GravarTransportadora(iSQ_PESSOA As Integer)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_EMPRESA_TRANSPORTADORA_UPD", False, "@ID_PESSOA",
                                                                          "@ID_EMPRESA")
    DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                         DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL))
  End Sub

  Public Function FormPesquisaPessoa_GravarForencedor(iSQ_PESSOA As Integer) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_EMPRESA_FORNECEDOR_UPD", False, "@ID_PESSOA",
                                                                      "@ID_EMPRESA")
    Return DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL))
  End Function

  Public Function FormPesquisaPessoa_GravarCliente(iSQ_PESSOA As Integer) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_EMPRESA_CLIENTE_UPD", False, "@ID_PESSOA",
                                                                   "@ID_EMPRESA")
    Return DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iSQ_PESSOA),
                                DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL))
  End Function

  Public Sub FormPesquisaPessoa_TratarCombo(oFormChamador As Form,
                                            oComboBox_Pessoa As ComboBox,
                                            e As KeyEventArgs,
                                            TipoFiltroPessoa As enTipoFiltroPessoa,
                                            Optional iSQ_PESSOA As Integer = 0,
                                            Optional iAtivo As Integer = 20,
                                            Optional bSomenteNome As Boolean = False)
    Dim bPesquisar As Boolean

    If iSQ_PESSOA > 0 Then
      bPesquisar = True
    Else
      If Not e Is Nothing Then
        Select Case e.KeyCode
          Case System.Windows.Forms.Keys.Enter

            bPesquisar = True
          Case System.Windows.Forms.Keys.F2
            bPesquisar = FormPesquisaPessoa_Cadastro(iSQ_PESSOA,,,
                                                     TipoFiltroPessoa = enTipoFiltroPessoa.Cliente,
                                                     TipoFiltroPessoa = enTipoFiltroPessoa.Fornecedor)
        End Select
      End If
    End If

    If bPesquisar Then
      oComboBox_Pessoa.DataSource = Nothing
      ComboBox_CarregarPessoa(oComboBox_Pessoa, TipoFiltroPessoa, iSQ_PESSOA, True, iAtivo, , , True, bSomenteNome)

      If oComboBox_Pessoa.Items.Count = 1 Then
        oComboBox_Pessoa.SelectedIndex = 0
      End If
    End If
  End Sub

  Public Sub FormPesquisaProduto_TratarCombo(oFormChamador As Form,
                                             oComboBox_Produto As ComboBox,
                                             e As KeyEventArgs,
                                             Optional iSQ_PRODUTO As Integer = 0,
                                             Optional iSQ_PRODUTO_EMPRESA As Integer = 0,
                                             Optional bAtivo As Boolean = True,
                                             Optional bListarLinhaProduto As Boolean = False)
    Dim bPesquisar As Boolean

    If iSQ_PRODUTO > 0 Or iSQ_PRODUTO_EMPRESA > 0 Then
      bPesquisar = True
    Else
      If Not e Is Nothing Then
        Select Case e.KeyCode
          Case System.Windows.Forms.Keys.Enter
            bPesquisar = True
          Case System.Windows.Forms.Keys.F2
            Dim oForm As New frmCadastroProduto

            FNC_AbriTela(oForm, , True, True)

            bPesquisar = oForm.bGravado
            iSQ_PRODUTO = oForm.iSQ_PRODUTO
        End Select
      End If
    End If

    If bPesquisar Then
      oComboBox_Produto.DataSource = Nothing
      ComboBox_CarregarProduto(oComboBox_Produto, iSQ_PRODUTO, iSQ_PRODUTO_EMPRESA, , , , , IIf(bAtivo, "S", "T"), True, True, bListarLinhaProduto)

      If oComboBox_Produto.Items.Count = 1 Then
        oComboBox_Produto.SelectedIndex = 0
      End If
    End If
  End Sub

  Public Function FormPesquisaPessoa_CNPJ_CPF_Existente(sCPF_CNPJ As String) As Boolean
    Dim sSqlText As String

    If Val(FNC_SoNumero(sCPF_CNPJ)) > 0 Then
      sSqlText = "SELECT COUNT(*) FROM TB_PESSOA WHERE CD_CPF_CNPJ = " & FNC_QuotedStr(FNC_SoNumero(sCPF_CNPJ))
      Return (DBQuery_ValorUnico(sSqlText) > 0)
    Else
      Return False
    End If
  End Function

  Public Function FormMovimentacaoFinanceira_Compensacao_Gravar(iSQ_MOVFINANCEIRAPARCELA As Integer,
                                                                iID_CONTAFINANCEIRA As Integer,
                                                                dDT_COMPENSACAO As Date,
                                                                dVL_COMPENSACAO As Double,
                                                                sCM_COMPENSACAO As String) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_COMPENSACAO_CAD", False, "@SQ_MOVFINANCEIRAPARCELA",
                                                                             "@ID_CONTAFINANCEIRA",
                                                                             "@DT_LANCAMENTO",
                                                                             "@DT_COMPENSACAO",
                                                                             "@VL_COMPENSACAO",
                                                                             "@CM_COMPENSACAO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA", FNC_NuloSe(iSQ_MOVFINANCEIRAPARCELA, 0)),
                            DBParametro_Montar("ID_CONTAFINANCEIRA", FNC_NuloSe(iID_CONTAFINANCEIRA, 0)),
                            DBParametro_Montar("DT_LANCAMENTO", dDT_COMPENSACAO, SqlDbType.Date),
                            DBParametro_Montar("DT_COMPENSACAO", dDT_COMPENSACAO, SqlDbType.Date),
                            DBParametro_Montar("VL_COMPENSACAO", dVL_COMPENSACAO),
                            DBParametro_Montar("CM_COMPENSACAO", FNC_NuloSe(Trim(sCM_COMPENSACAO), ""),,, const_BancoDados_TamanhoComentario)) Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Sub FormMovimentacaoFinanceira_Status_Atualizar(iSQ_MOVFINANCEIRA As Integer)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_STATUS", False, "@SQ_MOVFINANCEIRA")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRA", iSQ_MOVFINANCEIRA))
  End Sub

  Public Function FormMovimentacaoFinanceiraParcela_ID_MOVFINANCEIRA(iSQ_MOVFINANCEIRAPARCELA As Integer) As Integer
    Dim sSqlText As String

    sSqlText = "SELECT SQ_MOVFINANCEIRA FROM TB_MOVFINANCEIRAPARCELA WHERE SQ_MOVFINANCEIRAPARCELA = " & iSQ_MOVFINANCEIRAPARCELA
    Return DBQuery_ValorUnico(sSqlText)
  End Function

  Public Function FormMovimentacaoFinanceira_CalculoFinanceiro(iID_OPT_PERIODOCALCULOFINANCEIRO As Integer,
                                                               dPC_CALCULO As Double,
                                                               dVL_BASE As Double,
                                                               dDT_VENCIMENTO As Date,
                                                               dDT_PAGAMENTO As Date,
                                                               sIC_JUROS_DESCONTO As String) As Double
    Dim sSqlText As String
    Dim dRetorno As Double

    sSqlText = "SELECT dbo.FC_CalculoFinanceiro_Calcular(" + iID_OPT_PERIODOCALCULOFINANCEIRO.ToString() +
                                                       "," + FNC_ConvValorFormatoAmericano(dPC_CALCULO) +
                                                       "," + FNC_ConvValorFormatoAmericano(dVL_BASE) +
                                                       "," + FNC_QuotedStr(FNC_DBDataToString(dDT_VENCIMENTO)) +
                                                       "," + FNC_QuotedStr(FNC_DBDataToString(dDT_PAGAMENTO)) +
                                                       "," + FNC_QuotedStr(sIC_JUROS_DESCONTO) + ")"
    dRetorno = DBQuery_ValorUnico(sSqlText, 0)

    Return dRetorno
  End Function

  Public Function FormMovimentacaoFinanceiraParcela_CalculoFinanceiro(iSQ_MOVFINANCEIRAPARCELA As Integer,
                                                                      dDT_PAGAMENTO As Date,
                                                                      sIC_JUROS_DESCONTO As String,
                                                                      Optional dValorBase As Double = 0) As Double
    Dim sSqlText As String
    Dim dRetorno As Double

    sSqlText = "SELECT dbo.FC_MovFinanceiraParcela_CalculoFinanceiro_Calcular(" + iSQ_MOVFINANCEIRAPARCELA.ToString() + ", " _
                                                                                + FNC_QuotedStr(FNC_DBDataToString(dDT_PAGAMENTO)) + ", " _
                                                                                + FNC_QuotedStr(sIC_JUROS_DESCONTO) + "," _
                                                                                + FNC_ConvValorFormatoAmericano(dValorBase) & ")"
    dRetorno = DBQuery_ValorUnico(sSqlText, 0)

    Return dRetorno
  End Function

  Public Function FormPagamento_Compensacao_Gravar(iSQ_PAGAMENTOITEM As Integer,
                                                   iID_CONTAFINANCEIRA As Integer,
                                                   iID_OPT_STATUS As Integer,
                                                   dDT_COMPENSACAO As Date,
                                                   dVL_COMPENSACAO As Double,
                                                   sCM_COMPENSACAO As String) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PAGAMENTO_COMPENSACAO_CAD", False, "@ID_PAGAMENTOITEM",
                                                                  "@ID_CONTAFINANCEIRA",
                                                                  "@ID_OPT_STATUS",
                                                                  "@DT_LANCAMENTO",
                                                                  "@DT_COMPENSACAO",
                                                                  "@VL_COMPENSACAO",
                                                                  "@CM_COMPENSACAO")
    If DBExecutar(sSqlText, DBParametro_Montar("ID_PAGAMENTOITEM", FNC_NuloSe(iSQ_PAGAMENTOITEM, 0)),
                            DBParametro_Montar("ID_CONTAFINANCEIRA", FNC_NuloSe(iID_CONTAFINANCEIRA, 0)),
                            DBParametro_Montar("ID_OPT_STATUS", FNC_NuloSe(iID_OPT_STATUS, 0)),
                            DBParametro_Montar("DT_LANCAMENTO", dDT_COMPENSACAO),
                            DBParametro_Montar("DT_COMPENSACAO", dDT_COMPENSACAO),
                            DBParametro_Montar("VL_COMPENSACAO", dVL_COMPENSACAO),
                            DBParametro_Montar("CM_COMPENSACAO", FNC_NuloSe(Trim(sCM_COMPENSACAO), ""))) Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Function FormCadastroFormaPagamento_Carregar(iSQ_FORMAPAGAMENTO As Integer) As cFormaPagamento
    Dim oData As DataTable
    Dim sSqlText As String
    Dim oFormaPagamento As New cFormaPagamento

    sSqlText = "SELECT * FROM VW_FORMAPAGAMENTO WHERE SQ_FORMAPAGAMENTO = " & iSQ_FORMAPAGAMENTO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      oFormaPagamento.SQ_FORMAPAGAMENTO = .Item("SQ_FORMAPAGAMENTO")
      oFormaPagamento.ID_TIPO_DOCUMENTO = .Item("ID_TIPO_DOCUMENTO")
      oFormaPagamento.ID_OPT_DOCUMENTOCADASTRADO = FNC_NVL(.Item("ID_OPT_DOCUMENTOCADASTRADO"), 0)
      oFormaPagamento.ID_OPT_INSTITUICAO_GERADORA = FNC_NVL(.Item("ID_OPT_INSTITUICAO_GERADORA"), -1)
      oFormaPagamento.ID_OPT_TIPOFORMAPAGAMENTO = FNC_NVL(.Item("ID_OPT_TIPOFORMAPAGAMENTO"), 0)
      oFormaPagamento.NO_FORMAPAGAMENTO = .Item("NO_FORMAPAGAMENTO")
      oFormaPagamento.NO_TIPO_DOCUMENTO = .Item("NO_TIPO_DOCUMENTO")
      oFormaPagamento.COMPENSA = (FNC_NVL(.Item("IC_COMPENSAR"), "N") = "S")
      oFormaPagamento.CADASTRAR_DOCUMENTO = (FNC_NVL(.Item("IC_CADASTRAR_DOCUMENTO"), "N") = "S")
      oFormaPagamento.CADASTRAR_CONTABANCARIA = (FNC_NVL(.Item("IC_CADASTRAR_CONTABANCARIA"), "N") = "S")
      oFormaPagamento.NO_INSTITUICAO_GERADORA = FNC_NVL(.Item("NO_INSTITUICAO_GERADORA"), "")
    End With

    Return oFormaPagamento
  End Function

  Public Sub FormCadastroQuestionaio_DadosVitais_Gravar(ByRef iSQ_QUESTIONARIO As Integer, ByRef iSQ_QUESTIONARIO_VERSAO As Integer)
    FormCadastroQuestionario_Gravar(iSQ_QUESTIONARIO,
                                   iSQ_QUESTIONARIO_VERSAO,
                                   enOpcoes.ModeloFormularioQuestionario_Listagem.GetHashCode,
                                   enOpcoes.TipoQuestionarioClinicaDadosVitais_SinaisVitais.GetHashCode,
                                   "Dados Vitais", True)
    FormCadastroQuestionarioItem_Gravar(0, iSQ_QUESTIONARIO_VERSAO, enOpcoes.TipoCampo_Numero.GetHashCode, 0, 0, 0, "Temperatura", 0, 1, 0, 0, Nothing)
    FormCadastroQuestionarioItem_Gravar(0, iSQ_QUESTIONARIO_VERSAO, enOpcoes.TipoCampo_Numero.GetHashCode, 0, 0, 0, "Pulso", 0, 2, 0, 0, Nothing)
    FormCadastroQuestionarioItem_Gravar(0, iSQ_QUESTIONARIO_VERSAO, enOpcoes.TipoCampo_Numero.GetHashCode, 0, 0, 0, "Pressão Sangúínea", 0, 3, 0, 0, Nothing)
    FormCadastroQuestionarioItem_Gravar(0, iSQ_QUESTIONARIO_VERSAO, enOpcoes.TipoCampo_Numero.GetHashCode, 0, 0, 0, "Frequência Respiratória", 0, 4, 0, 0, Nothing)
  End Sub

  Public Function FormCadastroQuestionario_Gravar(ByRef iSQ_QUESTIONARIO As Integer,
                                                 ByRef iSQ_QUESTIONARIO_VERSAO As Integer,
                                                 iID_OPT_MODELOFORMULARIO As Integer,
                                                 iID_OPT_TIPOQUESTIONARIO As Integer,
                                                 sNO_QUESTIONARIO As String,
                                                 bIC_ATIVO As Boolean) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_QUESTIONARIO_CAD", False, "@SQ_QUESTIONARIO OUT",
                                                         "@ID_EMPRESA",
                                                         "@ID_OPT_MODELOFORMULARIO",
                                                         "@ID_OPT_TIPOQUESTIONARIO",
                                                         "@NO_QUESTIONARIO",
                                                         "@IC_ATIVO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO", iSQ_QUESTIONARIO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_OPT_MODELOFORMULARIO", iID_OPT_MODELOFORMULARIO),
                            DBParametro_Montar("ID_OPT_TIPOQUESTIONARIO", iID_OPT_TIPOQUESTIONARIO),
                            DBParametro_Montar("NO_QUESTIONARIO", Trim(sNO_QUESTIONARIO)),
                            DBParametro_Montar("IC_ATIVO", IIf(bIC_ATIVO, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_QUESTIONARIO = DBRetorno(1)
      End If

      sSqlText = DBMontar_SP("SP_QUESTIONARIO_VERSAO_CAD", False, "@SQ_QUESTIONARIO_VERSAO OUT",
                                                                  "@ID_QUESTIONARIO",
                                                                  "@DT_INICIO_USO",
                                                                  "@DT_FIM_USO")
      DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_VERSAO", iSQ_QUESTIONARIO_VERSAO, , ParameterDirection.InputOutput),
                           DBParametro_Montar("ID_QUESTIONARIO", iSQ_QUESTIONARIO),
                           DBParametro_Montar("DT_INICIO_USO", Now.Date),
                           DBParametro_Montar("DT_FIM_USO", Nothing))
      If DBTeveRetorno() Then
        iSQ_QUESTIONARIO_VERSAO = DBRetorno(1)
      End If

      Return True
    Else
      Return False
    End If
  End Function

  Public Function FormCadastroQuestionarioItem_Gravar(ByRef iSQ_QUESTIONARIO_VERSAO_ITEM As Integer,
                                                     iID_QUESTIONARIO_VERSAO As Integer,
                                                     iID_OPT_TIPO_QUESTIONARIO As Integer,
                                                     iID_TIPO_SEXO As Integer,
                                                     iID_FAIXAETARIA As Integer,
                                                     iID_LEGENDA As Integer,
                                                     sDS_PERGUNTA As String,
                                                     iNR_TAMANHORESPOSTA As Integer,
                                                     iNR_ORDEM_PERGUNTA As Integer,
                                                     iID_LEGENDA_EXPLICACAO As Integer,
                                                     iID_OPT_TIPO_EXPLICACAO As Integer,
                                                     sDS_ROTULO_EXPLICACAO As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    'Grava as perguntas
    sSqlText = DBMontar_SP("SP_QUESTIONARIO_VERSAO_ITEM_CAD", False, "@SQ_QUESTIONARIO_VERSAO_ITEM OUT",
                                                                     "@ID_QUESTIONARIO_VERSAO",
                                                                     "@ID_OPT_TIPO_QUESTIONARIO",
                                                                     "@ID_TIPO_SEXO",
                                                                     "@ID_FAIXAETARIA",
                                                                     "@ID_LEGENDA",
                                                                     "@DS_PERGUNTA",
                                                                     "@NR_TAMANHORESPOSTA",
                                                                     "@NR_ORDEM_PERGUNTA",
                                                                     "@ID_LEGENDA_EXPLICACAO",
                                                                     "@ID_OPT_TIPO_EXPLICACAO",
                                                                     "@DS_ROTULO_EXPLICACAO")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_VERSAO_ITEM", iSQ_QUESTIONARIO_VERSAO_ITEM, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_QUESTIONARIO_VERSAO", iID_QUESTIONARIO_VERSAO),
                               DBParametro_Montar("ID_OPT_TIPO_QUESTIONARIO", iID_OPT_TIPO_QUESTIONARIO),
                               DBParametro_Montar("ID_TIPO_SEXO", FNC_NuloSe(FNC_NuloZero(iID_TIPO_SEXO, False), 0)),
                               DBParametro_Montar("ID_FAIXAETARIA", FNC_NuloSe(FNC_NuloZero(iID_FAIXAETARIA, False), 0)),
                               DBParametro_Montar("ID_LEGENDA", FNC_NuloSe(FNC_NuloZero(iID_LEGENDA, False), 0)),
                               DBParametro_Montar("DS_PERGUNTA", sDS_PERGUNTA),
                               DBParametro_Montar("NR_TAMANHORESPOSTA", FNC_NVL(iNR_TAMANHORESPOSTA, 0)),
                               DBParametro_Montar("NR_ORDEM_PERGUNTA", iNR_ORDEM_PERGUNTA),
                               DBParametro_Montar("ID_LEGENDA_EXPLICACAO", FNC_NuloSe(FNC_NuloZero(iID_LEGENDA_EXPLICACAO, False), 0)),
                               DBParametro_Montar("ID_OPT_TIPO_EXPLICACAO", FNC_NuloSe(FNC_NuloZero(iID_OPT_TIPO_EXPLICACAO, False), 0)),
                               DBParametro_Montar("DS_ROTULO_EXPLICACAO", sDS_ROTULO_EXPLICACAO))
    If DBTeveRetorno() Then
      iSQ_QUESTIONARIO_VERSAO_ITEM = DBRetorno(1)
    End If

    Return bOk
  End Function

  Public Function FormCadastroQuestionarioItem_Excluir(iSQ_QUESTIONARIO_VERSAO_ITEM As Integer) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    'Grava as perguntas
    sSqlText = DBMontar_SP("SP_QUESTIONARIO_VERSAO_ITEM_DEL", False, "@SQ_QUESTIONARIO_VERSAO_ITEM")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_VERSAO_ITEM", iSQ_QUESTIONARIO_VERSAO_ITEM))

    Return bOk
  End Function

  Public Sub FormCadastroQuestionaioItem_Elemento_Gravar(ByRef iSQ_QUESTIONARIO_VERSAO_ITEM_ELEMENTO As Integer,
                                                         iID_QUESTIONARIO_VERSAO_ITEM As Integer,
                                                         iID_QUESTIONARIO_VERSAO_CONTAINER As Integer,
                                                         iID_OPT_TIPOCOMPONENTE As Integer,
                                                         iID_OPT_TIPOCAMPO As Integer,
                                                         sNR_CAMPO_LOCALIZACAO As String,
                                                         sNR_DIMENSAO As String,
                                                         iID_LEGENDA_ITEM As Integer,
                                                         sDS_TEXTO As String,
                                                         sDS_FONTE As String)
    Dim sSqlText As String

    'Grava as perguntas
    sSqlText = DBMontar_SP("SP_QUESTIONARIO_VERSAO_ITEM_ELEMENTO_CAD", False, "@SQ_QUESTIONARIO_VERSAO_ITEM_ELEMENTO OUT",
                                                                              "@ID_QUESTIONARIO_VERSAO_ITEM",
                                                                              "@ID_QUESTIONARIO_VERSAO_CONTAINER",
                                                                              "@ID_OPT_TIPOCOMPONENTE",
                                                                              "@ID_OPT_TIPOCAMPO",
                                                                              "@NR_CAMPO_LOCALIZACAO",
                                                                              "@NR_DIMENSAO",
                                                                              "@ID_LEGENDA_ITEM",
                                                                              "@DS_TEXTO",
                                                                              "@DS_FONTE")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_VERSAO_ITEM_ELEMENTO", iSQ_QUESTIONARIO_VERSAO_ITEM_ELEMENTO, , ParameterDirection.InputOutput),
                         DBParametro_Montar("ID_QUESTIONARIO_VERSAO_ITEM", iID_QUESTIONARIO_VERSAO_ITEM),
                         DBParametro_Montar("ID_QUESTIONARIO_VERSAO_CONTAINER", FNC_NuloZero(iID_QUESTIONARIO_VERSAO_CONTAINER, False)),
                         DBParametro_Montar("ID_OPT_TIPOCOMPONENTE", iID_OPT_TIPOCOMPONENTE),
                         DBParametro_Montar("ID_OPT_TIPOCAMPO", iID_OPT_TIPOCAMPO),
                         DBParametro_Montar("NR_CAMPO_LOCALIZACAO", sNR_CAMPO_LOCALIZACAO),
                         DBParametro_Montar("NR_DIMENSAO", sNR_DIMENSAO),
                         DBParametro_Montar("ID_LEGENDA_ITEM", FNC_NuloSe(FNC_NuloZero(iID_LEGENDA_ITEM, False), 0)),
                         DBParametro_Montar("DS_TEXTO", sDS_TEXTO),
                         DBParametro_Montar("DS_FONTE", sDS_FONTE, , , 500))

    If DBTeveRetorno() Then
      iSQ_QUESTIONARIO_VERSAO_ITEM_ELEMENTO = DBRetorno(1)
    End If
  End Sub

  Public Sub FormCadastroQuestionaio_ContainerElemento_Gravar(ByRef iSQ_QUESTIONARIO_VERSAO_CONTAINER_ELEMENTO As Integer,
                                                              iID_QUESTIONARIO_VERSAO_CONTAINER As Integer,
                                                              iID_OPT_TIPOCAMPO As Integer,
                                                              sNR_CAMPO_LOCALIZACAO As String,
                                                              sNR_DIMENSAO As String,
                                                              sDS_TEXTO As String,
                                                              sDS_FONTE As String)
    Dim sSqlText As String

    'Grava as perguntas
    sSqlText = DBMontar_SP("SP_QUESTIONARIO_VERSAO_CONTAINER_ELEMENTO_CAD", False, "@SQ_QUESTIONARIO_VERSAO_CONTAINER_ELEMENTO OUT",
                                                                                   "@ID_QUESTIONARIO_VERSAO_CONTAINER",
                                                                                   "@ID_OPT_TIPOCAMPO",
                                                                                   "@NR_CAMPO_LOCALIZACAO",
                                                                                   "@NR_DIMENSAO",
                                                                                   "@DS_TEXTO",
                                                                                   "@DS_FONTE")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_VERSAO_CONTAINER_ELEMENTO", iSQ_QUESTIONARIO_VERSAO_CONTAINER_ELEMENTO, , ParameterDirection.InputOutput),
                         DBParametro_Montar("ID_QUESTIONARIO_VERSAO_CONTAINER", FNC_NuloZero(iID_QUESTIONARIO_VERSAO_CONTAINER, False)),
                         DBParametro_Montar("ID_OPT_TIPOCAMPO", iID_OPT_TIPOCAMPO),
                         DBParametro_Montar("NR_CAMPO_LOCALIZACAO", sNR_CAMPO_LOCALIZACAO),
                         DBParametro_Montar("NR_DIMENSAO", sNR_DIMENSAO),
                         DBParametro_Montar("DS_TEXTO", sDS_TEXTO),
                         DBParametro_Montar("DS_FONTE", sDS_FONTE, , , 500))

    If DBTeveRetorno() Then
      iSQ_QUESTIONARIO_VERSAO_CONTAINER_ELEMENTO = DBRetorno(1)
    End If
  End Sub

  Public Sub FormCadastroQuestionaio_Container_Excluir(iID_QUESTIONARIO_VERSAO_CONTAINER As Integer)
    Dim sSqlText As String

    'Grava as perguntas
    sSqlText = DBMontar_SP("SP_QUESTIONARIO_VERSAO_CONTAINER_DEL", False, "@SQ_QUESTIONARIO_VERSAO_CONTAINER")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_VERSAO_CONTAINER", iID_QUESTIONARIO_VERSAO_CONTAINER))
  End Sub

  Public Sub FormCadastroQuestionaio_Container_Gravar(ByRef iSQ_QUESTIONARIO_VERSAO_CONTAINER As Integer,
                                                      iID_QUESTIONARIO_VERSAO As Integer,
                                                      iID_OPT_TIPOCONTAINER As Integer,
                                                      iID_QUESTIONARIO_VERSAO_CONTAINER_PAI As Integer,
                                                      sNR_CAMPO_LOCALIZACAO As String,
                                                      sNR_DIMENSAO As String,
                                                      sDS_TEXTO As String)
    Dim sSqlText As String

    'Grava as perguntas
    sSqlText = DBMontar_SP("SP_QUESTIONARIO_VERSAO_CONTAINER_CAD", False, "@SQ_QUESTIONARIO_VERSAO_CONTAINER OUT",
                                                                          "@ID_QUESTIONARIO_VERSAO",
                                                                          "@ID_OPT_TIPOCONTAINER",
                                                                          "@ID_QUESTIONARIO_VERSAO_CONTAINER_PAI",
                                                                          "@NR_CAMPO_LOCALIZACAO",
                                                                          "@NR_DIMENSAO",
                                                                          "@DS_TEXTO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_VERSAO_CONTAINER", iSQ_QUESTIONARIO_VERSAO_CONTAINER, , ParameterDirection.InputOutput),
                         DBParametro_Montar("ID_QUESTIONARIO_VERSAO", iID_QUESTIONARIO_VERSAO),
                         DBParametro_Montar("ID_OPT_TIPOCONTAINER", iID_OPT_TIPOCONTAINER),
                         DBParametro_Montar("ID_QUESTIONARIO_VERSAO_CONTAINER_PAI", FNC_NuloZero(iID_QUESTIONARIO_VERSAO_CONTAINER_PAI, False)),
                         DBParametro_Montar("NR_CAMPO_LOCALIZACAO", sNR_CAMPO_LOCALIZACAO),
                         DBParametro_Montar("NR_DIMENSAO", sNR_DIMENSAO),
                         DBParametro_Montar("DS_TEXTO", FNC_NuloString(sDS_TEXTO, False)))
    If DBTeveRetorno() Then
      iSQ_QUESTIONARIO_VERSAO_CONTAINER = DBRetorno(1)
    End If
  End Sub

  Public Function FormCadastroAgendamento_Excluir(iSQ_AGENDAMENTO As Integer) As Boolean
    Dim bOk As Boolean = False

    If Not FNC_Perguntar("Deseja realmente excluir esse agendamento?") Then GoTo Sair

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_AGENDAMENTO_DEL", False, "@SQ_AGENDAMENTO",
                                                        "@ID_USUARIO")

    If DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO),
                            DBParametro_Montar("ID_USUARIO", iID_USUARIO)) Then
      bOk = True

      FNC_Mensagem("Exclusão Efetuada")
    End If

Sair:
    Return bOk
  End Function

  Public Sub FormCadastroAgendamento_Gravar(ByRef iSQ_AGENDAMENTO As Integer,
                                            ByRef sCD_AGENDAMENTO As String,
                                            iID_EMPRESA As Integer,
                                            iID_TIPO_CONSULTA As Integer,
                                            iID_PESSOA As Integer,
                                            iID_PESSOA_PROFISSIONAL As Integer,
                                            iID_PESSOA_EXECUTOR As Integer,
                                            iID_ESPECIALIDADE As Integer,
                                            iID_CONVENIO As Integer,
                                            iID_PROCEDIMENTO As Integer,
                                            iID_PESSOAINDICADOR As Integer,
                                            iID_OPT_STATUS As Integer,
                                            iID_CANALMARCACAO As Integer,
                                            dDH_AGENDAMENTO As DateTime,
                                            dDH_CHEGADA As DateTime,
                                            dDH_SAIDA As DateTime,
                                            sNO_PESSOA As String,
                                            sCD_TELEFONE As String,
                                            sCD_CELULAR As String,
                                            sDS_COMPLEMENTO As String,
                                            dVL_PROCEDIMENTO As Double)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_AGENDAMENTO_CAD", False, "@SQ_AGENDAMENTO OUT",
                                                        "@CD_AGENDAMENTO OUT",
                                                        "@ID_EMPRESA",
                                                        "@ID_TIPO_CONSULTA",
                                                        "@ID_AGENDAMENTO_ORIGEM",
                                                        "@ID_PESSOA",
                                                        "@ID_PESSOA_PROFISSIONAL",
                                                        "@ID_PESSOA_EXECUTOR",
                                                        "@ID_ESPECIALIDADE",
                                                        "@ID_CONVENIO",
                                                        "@ID_PROCEDIMENTO",
                                                        "@ID_INDICACAO",
                                                        "@ID_PESSOAINDICADOR",
                                                        "@ID_OPT_STATUS",
                                                        "@ID_CANALMARCACAO",
                                                        "@DH_AGENDAMENTO",
                                                        "@DH_CHEGADA",
                                                        "@DH_SAIDA",
                                                        "@NO_PESSOA",
                                                        "@CD_TELEFONE",
                                                        "@CD_CELULAR",
                                                        "@DS_COMPLEMENTO",
                                                        "@VL_PROCEDIMENTO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO, , ParameterDirection.InputOutput),
                         DBParametro_Montar("CD_AGENDAMENTO", sCD_AGENDAMENTO, , ParameterDirection.InputOutput),
                         DBParametro_Montar("ID_EMPRESA", iID_EMPRESA),
                         DBParametro_Montar("ID_TIPO_CONSULTA", iID_TIPO_CONSULTA),
                         DBParametro_Montar("ID_AGENDAMENTO_ORIGEM", Nothing),
                         DBParametro_Montar("ID_PESSOA", FNC_NuloZero(iID_PESSOA, False)),
                         DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_PESSOA_PROFISSIONAL),
                         DBParametro_Montar("ID_PESSOA_EXECUTOR", FNC_NuloZero(iID_PESSOA_EXECUTOR, False)),
                         DBParametro_Montar("ID_ESPECIALIDADE", FNC_NuloZero(iID_ESPECIALIDADE, False)),
                         DBParametro_Montar("ID_CONVENIO", FNC_NuloZero(iID_CONVENIO, False)),
                         DBParametro_Montar("ID_PROCEDIMENTO", FNC_NuloZero(iID_PROCEDIMENTO, False)),
                         DBParametro_Montar("ID_INDICACAO", Nothing),
                         DBParametro_Montar("ID_PESSOAINDICADOR", FNC_NuloZero(iID_PESSOAINDICADOR, False)),
                         DBParametro_Montar("ID_OPT_STATUS", iID_OPT_STATUS),
                         DBParametro_Montar("ID_CANALMARCACAO", FNC_NuloZero(iID_CANALMARCACAO, False)),
                         DBParametro_Montar("DH_AGENDAMENTO", dDH_AGENDAMENTO, SqlDbType.DateTime),
                         DBParametro_Montar("DH_CHEGADA", FNC_NuloData(dDH_CHEGADA), SqlDbType.DateTime),
                         DBParametro_Montar("DH_SAIDA", FNC_NuloData(dDH_SAIDA), SqlDbType.DateTime),
                         DBParametro_Montar("NO_PESSOA", IIf(iID_PESSOA = 0, sNO_PESSOA, Nothing)),
                         DBParametro_Montar("CD_TELEFONE", sCD_TELEFONE),
                         DBParametro_Montar("CD_CELULAR", sCD_CELULAR),
                         DBParametro_Montar("DS_COMPLEMENTO", sDS_COMPLEMENTO, , , const_BancoDados_TamanhoComentario),
                         DBParametro_Montar("VL_PROCEDIMENTO", dVL_PROCEDIMENTO))

    If DBTeveRetorno() Then
      iSQ_AGENDAMENTO = DBRetorno(1)
      sCD_AGENDAMENTO = DBRetorno(2)
    End If
  End Sub

  Public Sub FormCadastroAgendamento_AlterarStatus(iSQ_AGENDAMENTO As Integer,
                                                   iID_OPT_STATUS As Integer,
                                                   Optional dDH_CHEGADA As Date = Nothing)
    Dim sSqlText As String
    Dim dAux As Date = Nothing

    sSqlText = DBMontar_SP("SP_AGENDAMENTO_STATUS_UPD", False, "@SQ_AGENDAMENTO",
                                                               "@ID_USUARIO",
                                                               "@ID_OPT_STATUS",
                                                               "@DH_CHEGADA",
                                                               "@CD_VERSAO_SISTEMA")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO),
                         DBParametro_Montar("ID_OPT_STATUS", iID_OPT_STATUS),
                         DBParametro_Montar("DH_CHEGADA", IIf(dDH_CHEGADA = dAux, Nothing, dDH_CHEGADA)),
                         DBParametro_Montar("CD_VERSAO_SISTEMA", Application.ProductVersion))
  End Sub

  Public Sub FormCadastroAgendamentoAtendimento_ColocarCor(oGrid As Infragistics.Win.UltraWinGrid.UltraGrid, iColuna_ID_Status As Integer)
    Dim iCont As Integer

    For iCont = 0 To oGrid.Rows.Count - 1
      With oGrid.Rows(iCont)
        Select Case FNC_NVL(.Cells(iColuna_ID_Status).Value, 0)
          Case enOpcoes.StatusAgendamento_Iniciado.GetHashCode
            .Appearance.BackColor = Color.Yellow
          Case enOpcoes.StatusAtendimentoClinica_EmAtendimento.GetHashCode
            .Appearance.BackColor = Color.White
          Case enOpcoes.StatusAtendimentoClinica_Finalizado.GetHashCode
            .Appearance.BackColor = Color.Green
            .Appearance.ForeColor = Color.White
          Case enOpcoes.StatusAgendamento_Agendado.GetHashCode,
               enOpcoes.StatusAgendamento_Confirmado.GetHashCode,
               enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode
            .Appearance.BackColor = Color.White
          Case enOpcoes.StatusAgendamento_Sistema_ConsultaGerada.GetHashCode,
               enOpcoes.StatusAtendimentoClinica_ConsultaGerada.GetHashCode
            .Appearance.BackColor = Color.CadetBlue
            .Appearance.ForeColor = Color.White
          Case enOpcoes.StatusAgendamento_Atendido.GetHashCode
            .Appearance.BackColor = Color.RoyalBlue
            .Appearance.ForeColor = Color.White
          Case enOpcoes.StatusAgendamento_CanceladoPaciente.GetHashCode
            .Appearance.BackColor = Color.IndianRed
          Case enOpcoes.StatusAgendamento_CanceladoClinica.GetHashCode
            .Appearance.BackColor = Color.MediumVioletRed
          Case enOpcoes.StatusAgendamento_Sistema_CanceladoFalta.GetHashCode
            .Appearance.BackColor = Color.PaleVioletRed
        End Select
      End With
    Next
  End Sub

  Public Function FormCadastroAgenda_Excluir(iSQ_PESSOA_AGENDA As Integer) As Boolean
    Dim bOk As Boolean = False

    If iSQ_PESSOA_AGENDA = 0 Then
      FNC_Mensagem("Selecione o item da agenda a ser excluído")
    Else
      Dim sSqlText As String

      If Not FNC_Perguntar("Deseja realmente exlcuir esse item?") Then GoTo Sair

      sSqlText = DBMontar_SP("SP_PESSOA_AGENDA_DEL", False, "@SQ_PESSOA_AGENDA")
      bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_AGENDA", iSQ_PESSOA_AGENDA))

      If bOk Then
        FNC_Mensagem("Item excluído da agenda")
      End If

      Return bOk
    End If

Sair:
    Return bOk
  End Function

  Public Function FormCadastroAgenda_AgendaLiberada() As Boolean
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM TB_PESSOA_AGENDA_LIBERACAO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " And ID_PESSOA_AGENDA = " & iID_USUARIO

    Return (DBQuery_ValorUnico(sSqlText) > 0)
  End Function

  Public Sub FormCadastroAgenda_ColocarCor(oGrid As Infragistics.Win.UltraWinGrid.UltraGrid, iColuna_ID_Status As Integer)
    Dim iCont As Integer

    For iCont = 0 To oGrid.Rows.Count - 1
      With oGrid.Rows(iCont)
        .Appearance.ForeColor = Color.Black
        .Appearance.BackColor = Color.White

        Select Case FNC_NVL(.Cells(iColuna_ID_Status).Value, 0)
          Case enOpcoes.TipoEventoAgendaPessoa_FeriasLicenca.GetHashCode, enOpcoes.TipoEventoAgendaEmpresa_Recesso.GetHashCode
            .Appearance.BackColor = Color.Green
            .Appearance.ForeColor = Color.White
          Case enOpcoes.TipoEventoAgendaPessoa_Diversos.GetHashCode, enOpcoes.TipoEventoAgendaEmpresa_Diversos.GetHashCode
            .Appearance.BackColor = Color.Gray
            .Appearance.ForeColor = Color.White
          Case enOpcoes.TipoEventoAgendaPessoa_AssuntoPessoal.GetHashCode
            .Appearance.BackColor = Color.Yellow
            .Appearance.ForeColor = Color.Black
          Case enOpcoes.TipoEventoAgendaPessoa_EventoCongressoPalestra.GetHashCode, enOpcoes.TipoEventoAgendaEmpresa_EventoCongressoPalestra.GetHashCode
            .Appearance.BackColor = Color.Gold
            .Appearance.ForeColor = Color.Black
          Case enOpcoes.TipoEventoAgendaPessoa_Reuniao.GetHashCode, enOpcoes.TipoEventoAgendaEmpresa_ReuniaoGeral.GetHashCode
            .Appearance.BackColor = Color.Indigo
            .Appearance.ForeColor = Color.White
          Case Else
            .Appearance.ForeColor = Color.Black
            .Appearance.BackColor = Color.White
        End Select
      End With
    Next
  End Sub

  Public Function FormCadastroDocumentoFinanceiro_Gravar(ByRef iSQ_DOCUMENTOFINANCEIRO As Integer,
                                                         iID_TIPODOCUMENTO As Integer,
                                                         iID_BANCO As Integer,
                                                         iID_EMITENTE As Integer,
                                                         dDT_DOCUMENTO As Date,
                                                         dDT_VENCIMENTO As Date,
                                                         sDS_EMITENTE As String,
                                                         iNR_BANCO_AGENCIA As Integer,
                                                         iNR_BANCO_CONTA As Integer,
                                                         iNR_BANCO_CONTA_DIGITO As Integer,
                                                         sCD_DOCUMENTO As String,
                                                         dVL_DOCUMENTO As Double,
                                                         dVL_SALDO As Double,
                                                         sDS_DOCUMENTO As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    sSqlText = DBMontar_SP("SP_DOCUMENTOFINANCEIRO_CAB", False, "@SQ_DOCUMENTOFINANCEIRO OUT",
                                                                "@ID_EMPRESA",
                                                                "@ID_TIPODOCUMENTO",
                                                                "@ID_BANCO",
                                                                "@ID_EMITENTE",
                                                                "@DT_DOCUMENTO",
                                                                "@DT_VENCIMENTO",
                                                                "@DS_EMITENTE",
                                                                "@NR_BANCO_AGENCIA",
                                                                "@NR_BANCO_CONTA",
                                                                "@NR_BANCO_CONTA_DIGITO",
                                                                "@CD_DOCUMENTO",
                                                                "@VL_DOCUMENTO",
                                                                "@VL_SALDO",
                                                                "@DS_DOCUMENTO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFINANCEIRO", iSQ_DOCUMENTOFINANCEIRO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_TIPODOCUMENTO", iID_TIPODOCUMENTO),
                            DBParametro_Montar("ID_BANCO", FNC_NuloSe(iID_BANCO, 0)),
                            DBParametro_Montar("ID_EMITENTE", FNC_NuloSe(iID_EMITENTE, 0)),
                            DBParametro_Montar("DT_DOCUMENTO", dDT_DOCUMENTO, SqlDbType.DateTime),
                            DBParametro_Montar("DT_VENCIMENTO", dDT_VENCIMENTO, SqlDbType.DateTime),
                            DBParametro_Montar("DS_EMITENTE", FNC_NuloSe(Trim(sDS_EMITENTE), "")),
                            DBParametro_Montar("NR_BANCO_AGENCIA", FNC_NuloSe(iNR_BANCO_AGENCIA, 0)),
                            DBParametro_Montar("NR_BANCO_CONTA", FNC_NuloSe(iNR_BANCO_CONTA, 0)),
                            DBParametro_Montar("NR_BANCO_CONTA_DIGITO", FNC_NuloSe(iNR_BANCO_CONTA_DIGITO, 0)),
                            DBParametro_Montar("CD_DOCUMENTO", FNC_NuloSe(Trim(sCD_DOCUMENTO), "")),
                            DBParametro_Montar("VL_DOCUMENTO", FNC_NuloSe(dVL_DOCUMENTO, 0)),
                            DBParametro_Montar("VL_SALDO", FNC_NVL(dVL_SALDO, 0)),
                            DBParametro_Montar("DS_DOCUMENTO", FNC_NuloSe(Trim(sDS_DOCUMENTO), ""))) Then
      If DBTeveRetorno() Then
        iSQ_DOCUMENTOFINANCEIRO = DBRetorno(1)
      End If

      bOk = True
    End If

    Return bOk
  End Function

  Public Function FormCadastroMovimentacaoFinanceira(ByRef iSQ_MOVFINANCEIRA As Integer,
                                                     eID_OPT_TIPOMOVFINANCEIRA As enOpcoes,
                                                     eID_OPT_STATUS As enOpcoes,
                                                     eID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO As enOpcoes,
                                                     eID_OPT_PERIODOCALCULOFINANCEIRO_JUROS As enOpcoes,
                                                     iID_PESSOA As Integer,
                                                     iID_CONTAFINANCERIA_CREDITO As Integer,
                                                     iID_CONTAFINANCERIA_DEBITO As Integer,
                                                     iID_DOCUMENTOFISCAL As Integer,
                                                     iID_PEDIDO As Integer,
                                                     iID_ORDEMSERVICO As Integer,
                                                     iID_SEGMENTO As Integer,
                                                     iID_CONDICAOPAGAMENTO As Integer,
                                                     iID_CLINICA_VENDA As Integer,
                                                     iID_CONVENIO As Integer,
                                                     sDS_MOVFINANCEIRA As String,
                                                     dVL_MOVFINANCEIRA As Double,
                                                     dVL_ORIGINAL As Double,
                                                     dVL_DESCONTO As Double,
                                                     dDT_MOVIMENTACAO As Date,
                                                     dDT_1_VENCIMENTO As Date,
                                                     dPC_ENTRADA As Double,
                                                     dPC_JUROS As Double,
                                                     dPC_DESCONTO As Double,
                                                     dVL_MULTA As Double,
                                                     dPC_MULTA As Double,
                                                     sCM_MOVFINANCEIRA As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_CAD", False, "@SQ_MOVFINANCEIRA OUT",
                                                          "@ID_EMPRESA",
                                                          "@ID_OPT_TIPOMOVFINANCEIRA",
                                                          "@ID_OPT_STATUS",
                                                          "@ID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO",
                                                          "@ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS",
                                                          "@ID_PESSOA",
                                                          "@ID_CONTAFINANCERIA_CREDITO",
                                                          "@ID_CONTAFINANCERIA_DEBITO",
                                                          "@ID_DOCUMENTOFISCAL",
                                                          "@ID_PEDIDO",
                                                          "@ID_ORDEMSERVICO",
                                                          "@ID_SEGMENTO",
                                                          "@ID_CONDICAOPAGAMENTO",
                                                          "@ID_CLINICAVENDA",
                                                          "@ID_CONVENIO",
                                                          "@DS_MOVFINANCEIRA",
                                                          "@VL_MOVFINANCEIRA",
                                                          "@VL_ORIGINAL",
                                                          "@VL_DESCONTO",
                                                          "@DT_MOVIMENTACAO",
                                                          "@DT_1_VENCIMENTO",
                                                          "@PC_ENTRADA",
                                                          "@PC_JUROS",
                                                          "@PC_DESCONTO",
                                                          "@VL_MULTA",
                                                          "@PC_MULTA",
                                                          "@CM_MOVFINANCEIRA")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRA", iSQ_MOVFINANCEIRA, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                               DBParametro_Montar("ID_OPT_TIPOMOVFINANCEIRA", eID_OPT_TIPOMOVFINANCEIRA.GetHashCode()),
                               DBParametro_Montar("ID_OPT_STATUS", FNC_NuloZero(eID_OPT_STATUS.GetHashCode(), False)),
                               DBParametro_Montar("ID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO", FNC_NuloSe(eID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO.GetHashCode(), 0)),
                               DBParametro_Montar("ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS", FNC_NuloSe(eID_OPT_PERIODOCALCULOFINANCEIRO_JUROS.GetHashCode(), 0)),
                               DBParametro_Montar("ID_PESSOA", FNC_NuloSe(iID_PESSOA, 0)),
                               DBParametro_Montar("ID_CONTAFINANCERIA_CREDITO", FNC_NuloSe(iID_CONTAFINANCERIA_CREDITO, 0)),
                               DBParametro_Montar("ID_CONTAFINANCERIA_DEBITO", FNC_NuloSe(iID_CONTAFINANCERIA_DEBITO, 0)),
                               DBParametro_Montar("ID_DOCUMENTOFISCAL", FNC_NuloSe(iID_DOCUMENTOFISCAL, 0)),
                               DBParametro_Montar("ID_PEDIDO", FNC_NuloSe(iID_PEDIDO, 0)),
                               DBParametro_Montar("ID_ORDEMSERVICO", FNC_NuloSe(iID_ORDEMSERVICO, 0)),
                               DBParametro_Montar("ID_SEGMENTO", FNC_NuloSe(iID_SEGMENTO, 0)),
                               DBParametro_Montar("ID_CONDICAOPAGAMENTO", FNC_NuloSe(iID_CONDICAOPAGAMENTO, 0)),
                               DBParametro_Montar("ID_CLINICAVENDA", FNC_NuloSe(iID_CLINICA_VENDA, 0)),
                               DBParametro_Montar("ID_CONVENIO", FNC_NuloSe(iID_CONVENIO, 0)),
                               DBParametro_Montar("DS_MOVFINANCEIRA", sDS_MOVFINANCEIRA,,, 200),
                               DBParametro_Montar("VL_MOVFINANCEIRA", dVL_MOVFINANCEIRA, SqlDbType.Money),
                               DBParametro_Montar("VL_ORIGINAL", dVL_ORIGINAL, SqlDbType.Money),
                               DBParametro_Montar("VL_DESCONTO", dVL_DESCONTO, SqlDbType.Money),
                               DBParametro_Montar("DT_MOVIMENTACAO", FNC_NuloData(dDT_MOVIMENTACAO.Date), SqlDbType.DateTime),
                               DBParametro_Montar("DT_1_VENCIMENTO", dDT_1_VENCIMENTO.Date, SqlDbType.DateTime),
                               DBParametro_Montar("PC_ENTRADA", dPC_ENTRADA),
                               DBParametro_Montar("PC_JUROS", dPC_JUROS),
                               DBParametro_Montar("PC_DESCONTO", dPC_DESCONTO),
                               DBParametro_Montar("VL_MULTA", dVL_MULTA),
                               DBParametro_Montar("PC_MULTA", dPC_MULTA),
                               DBParametro_Montar("CM_MOVFINANCEIRA", FNC_NuloString(sCM_MOVFINANCEIRA, False),,, 32767))
    If DBTeveRetorno() Then
      iSQ_MOVFINANCEIRA = DBRetorno(1)
    End If

    Return bOk
  End Function

  Public Function FormCadastroMovimentacaoFinanceiraParcela(ByRef iSQ_MOVFINANCEIRAPARCELA As Integer,
                                                            iID_MOVFINANCEIRA As Integer,
                                                            eID_OPT_STATUS As enOpcoes,
                                                            iID_TIPO_DOCUMENTO As Integer,
                                                            iID_MOVFINANCEIRAPARCELAORIGEM As Integer,
                                                            iID_DOCUMENTOFINANCEIRO As Integer,
                                                            iID_FORMAPAGAMENTO_PREFERENCIAL As Integer,
                                                            iID_CONDICAOPAGAMENTO As Integer,
                                                            sCD_PARCELA As String,
                                                            sCD_DOCUMENTO As Object,
                                                            sCM_DOCUMENTO As Object,
                                                            sDS_EMITENTE As Object,
                                                            dDT_VENCIMENTO As Date,
                                                            dDT_QUITACAO As Date,
                                                            dVL_PARCELA As Double,
                                                            dVL_JUROS As Double,
                                                            dVL_DESCONTO As Double,
                                                            dVL_QUITADO As Double,
                                                            dVL_PROVISAO As Double,
                                                            dPC_TAXA_COMPENSACAO As Double) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_CAD", False, "@SQ_MOVFINANCEIRAPARCELA OUT",
                                                                 "@ID_MOVFINANCEIRA",
                                                                 "@ID_OPT_STATUS",
                                                                 "@ID_TIPO_DOCUMENTO",
                                                                 "@ID_MOVFINANCEIRAPARCELAORIGEM",
                                                                 "@ID_DOCUMENTOFINANCEIRO",
                                                                 "@ID_FORMAPAGAMENTO_PREFERENCIAL",
                                                                 "@ID_CONDICAOPAGAMENTO",
                                                                 "@CD_PARCELA",
                                                                 "@CD_DOCUMENTO",
                                                                 "@CM_DOCUMENTO",
                                                                 "@DS_EMITENTE",
                                                                 "@DT_VENCIMENTO",
                                                                 "@DT_QUITACAO",
                                                                 "@VL_PARCELA",
                                                                 "@VL_JUROS",
                                                                 "@VL_DESCONTO",
                                                                 "@VL_QUITADO",
                                                                 "@VL_PROVISAO",
                                                                 "@PC_TAXA_COMPENSACAO")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA", Val(FNC_NVL(iSQ_MOVFINANCEIRAPARCELA, 0)), , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_MOVFINANCEIRA", iID_MOVFINANCEIRA),
                               DBParametro_Montar("ID_OPT_STATUS", eID_OPT_STATUS.GetHashCode()),
                               DBParametro_Montar("ID_TIPO_DOCUMENTO", iID_TIPO_DOCUMENTO),
                               DBParametro_Montar("ID_MOVFINANCEIRAPARCELAORIGEM", FNC_NuloSe(iID_MOVFINANCEIRAPARCELAORIGEM, 0)),
                               DBParametro_Montar("ID_DOCUMENTOFINANCEIRO", FNC_NuloSe(iID_DOCUMENTOFINANCEIRO, 0)),
                               DBParametro_Montar("ID_FORMAPAGAMENTO_PREFERENCIAL", FNC_NuloSe(iID_FORMAPAGAMENTO_PREFERENCIAL, 0)),
                               DBParametro_Montar("ID_CONDICAOPAGAMENTO", FNC_NuloSe(iID_CONDICAOPAGAMENTO, 0)),
                               DBParametro_Montar("CD_PARCELA", sCD_PARCELA),
                               DBParametro_Montar("CD_DOCUMENTO", sCD_DOCUMENTO),
                               DBParametro_Montar("CM_DOCUMENTO", sCM_DOCUMENTO,,, const_BancoDados_TamanhoComentario),
                               DBParametro_Montar("DS_EMITENTE", FNC_NuloString(sDS_EMITENTE, False)),
                               DBParametro_Montar("DT_VENCIMENTO", dDT_VENCIMENTO),
                               DBParametro_Montar("DT_QUITACAO", FNC_NuloData(dDT_QUITACAO)),
                               DBParametro_Montar("VL_PARCELA", dVL_PARCELA),
                               DBParametro_Montar("VL_JUROS", dVL_JUROS),
                               DBParametro_Montar("VL_DESCONTO", dVL_DESCONTO),
                               DBParametro_Montar("VL_QUITADO", dVL_QUITADO),
                               DBParametro_Montar("VL_PROVISAO", dVL_PROVISAO),
                               DBParametro_Montar("PC_TAXA_COMPENSACAO", dPC_TAXA_COMPENSACAO, SqlDbType.Float))
    If DBTeveRetorno() Then
      iSQ_MOVFINANCEIRAPARCELA = DBRetorno(1)
    End If

    Return bOk
  End Function

  Public Sub FormCadastroTabelaPreco_Produto(iSQ_TABELAPRECO As Integer,
                                             iSQ_PRODUTO_EMPRESA As Integer,
                                             dVL_PRECOCUSTO As Double,
                                             dPC_ICMS_ENTRADA As Double,
                                             dPC_ICMS_SAIDA As Double,
                                             dPC_ICMS_ST As Double,
                                             dPC_SIMPLESNACIONAL As Double,
                                             dPC_CUSTO_FIXO As Double,
                                             dPC_CUSTO_VARIAVEL As Double,
                                             dPC_OUTROS_IMPOSTOS As Double,
                                             dPC_FRETE_ENTRADA As Double,
                                             dVL_PRECOCUSTOTOTAL As Double,
                                             dPC_DESCONTO_MAXIMO As Double,
                                             dPC_MARGEM_LUCRO As Double,
                                             dVL_BRINDE_ACESSORIO As Double,
                                             dVL_VENDA As Double)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_TABELAPRECO_PRODUTO_CAD", False, "@ID_TABELAPRECO",
                                                                "@ID_PRODUTO_EMPRESA",
                                                                "@ID_USUARIO",
                                                                "@VL_PRECOCUSTO",
                                                                "@PC_ICMS_ENTRADA",
                                                                "@PC_ICMS_SAIDA",
                                                                "@PC_ICMS_ST",
                                                                "@PC_SIMPLESNACIONAL",
                                                                "@PC_CUSTO_FIXO",
                                                                "@PC_CUSTO_VARIAVEL",
                                                                "@PC_OUTROS_IMPOSTOS",
                                                                "@PC_FRETE_ENTRADA",
                                                                "@VL_PRECOCUSTOTOTAL",
                                                                "@PC_DESCONTO_MAXIMO",
                                                                "@PC_MARGEM_LUCRO",
                                                                "@VL_BRINDE_ACESSORIO",
                                                                "@VL_VENDA")
    DBExecutar(sSqlText, DBParametro_Montar("ID_TABELAPRECO", iSQ_TABELAPRECO),
                         DBParametro_Montar("ID_PRODUTO_EMPRESA", iSQ_PRODUTO_EMPRESA),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO),
                         DBParametro_Montar("VL_PRECOCUSTO", dVL_PRECOCUSTO),
                         DBParametro_Montar("PC_ICMS_ENTRADA", dPC_ICMS_ENTRADA),
                         DBParametro_Montar("PC_ICMS_SAIDA", dPC_ICMS_SAIDA),
                         DBParametro_Montar("PC_ICMS_ST", dPC_ICMS_ST),
                         DBParametro_Montar("PC_SIMPLESNACIONAL", dPC_SIMPLESNACIONAL),
                         DBParametro_Montar("PC_CUSTO_FIXO", dPC_CUSTO_FIXO),
                         DBParametro_Montar("PC_CUSTO_VARIAVEL", dPC_CUSTO_VARIAVEL),
                         DBParametro_Montar("PC_OUTROS_IMPOSTOS", dPC_OUTROS_IMPOSTOS),
                         DBParametro_Montar("PC_FRETE_ENTRADA", dPC_FRETE_ENTRADA),
                         DBParametro_Montar("VL_PRECOCUSTOTOTAL", dVL_PRECOCUSTOTOTAL),
                         DBParametro_Montar("PC_DESCONTO_MAXIMO", dPC_DESCONTO_MAXIMO),
                         DBParametro_Montar("PC_MARGEM_LUCRO", dPC_MARGEM_LUCRO),
                         DBParametro_Montar("VL_BRINDE_ACESSORIO", dVL_BRINDE_ACESSORIO),
                         DBParametro_Montar("VL_VENDA", dVL_VENDA))
  End Sub

  Public Function FormLancamentoAtendimento_Iniciar(ByRef iSQ_ATENDIMENTO As Integer,
                                                    iID_AGENDAMENTO As Integer,
                                                    ByRef sCD_ATENDIMENTO As String,
                                                    iID_PESSOA As Integer,
                                                    iID_CONVENIO As Integer,
                                                    iID_PESSOA_PROFISSIONAL As Integer,
                                                    iID_TIPO_CONSULTA As Integer,
                                                    iID_OPT_STATUS_ATENDIMENTO As Integer,
                                                    sCD_IDENTIFICACAO_CONVENIO As String,
                                                    dDH_ATENDIMENTO As Date) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    If iID_OPT_STATUS_ATENDIMENTO = 0 Then
      iID_OPT_STATUS_ATENDIMENTO = enOpcoes.StatusAgendamento_Atendido.StatusAtendimentoClinica_ConsultaGerada.GetHashCode()
    End If

    sSqlText = DBMontar_SP("SP_ATENDIMENTO_INICIAR_CAD", False, "@SQ_ATENDIMENTO OUT",
                                                                "@CD_ATENDIMENTO OUT",
                                                                "@ID_AGENDAMENTO",
                                                                "@ID_EMPRESA",
                                                                "@ID_PESSOA",
                                                                "@ID_CONVENIO",
                                                                "@ID_PESSOA_PROFISSIONAL",
                                                                "@ID_TIPO_CONSULTA",
                                                                "@ID_OPT_STATUS_ATENDIMENTO",
                                                                "@CD_IDENTIFICACAO_CONVENIO",
                                                                "@DH_ATENDIMENTO")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_ATENDIMENTO", iSQ_ATENDIMENTO, , ParameterDirection.InputOutput),
                               DBParametro_Montar("CD_ATENDIMENTO", sCD_ATENDIMENTO, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_AGENDAMENTO", iID_AGENDAMENTO),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_CONVENIO", FNC_NuloZero(iID_CONVENIO, False)),
                               DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_PESSOA_PROFISSIONAL),
                               DBParametro_Montar("ID_TIPO_CONSULTA", iID_TIPO_CONSULTA),
                               DBParametro_Montar("ID_OPT_STATUS_ATENDIMENTO", iID_OPT_STATUS_ATENDIMENTO),
                               DBParametro_Montar("CD_IDENTIFICACAO_CONVENIO", sCD_IDENTIFICACAO_CONVENIO),
                               DBParametro_Montar("DH_ATENDIMENTO", dDH_ATENDIMENTO, SqlDbType.DateTime))

    If DBTeveRetorno() Then
      iSQ_ATENDIMENTO = DBRetorno(1)
      sCD_ATENDIMENTO = DBRetorno(2)
    End If

    Return bOk
  End Function

  Public Function FormLancamentoAtendimento_Gravar(ByRef iSQ_ATENDIMENTO As Integer,
                                                   ByRef sCD_ATENDIMENTO As String,
                                                   iID_PESSOA As Integer,
                                                   iID_CONVENIO As Integer,
                                                   iID_PESSOA_PROFISSIONAL As Integer,
                                                   iID_TIPO_CONSULTA As Integer,
                                                   iID_OPT_STATUS_ATENDIMENTO As Integer,
                                                   iID_OPT_TIPOSAIDA As Integer,
                                                   iID_OPT_TIPODOENCA As Integer,
                                                   iID_AGENDAMENTO As Integer,
                                                   iNR_DIA_TEMPODOENCA As Integer,
                                                   iID_OPT_TEMPODOENCA As Integer,
                                                   iID_OPT_INDICACAOACIDENTE As Integer,
                                                   iID_PROCEDIMENTO As Integer,
                                                   sCD_IDENTIFICACAO_CONVENIO As String,
                                                   dDH_ATENDIMENTO As Date,
                                                   dDH_FINALIZACAO As Date,
                                                   sDS_QUEIXAPRINCIPAL As String,
                                                   sDS_OUTRASINFORMACOES As String)
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_ATENDIMENTO_CAD", False, "@SQ_ATENDIMENTO OUT",
                                                        "@CD_ATENDIMENTO OUT",
                                                        "@ID_EMPRESA",
                                                        "@ID_PESSOA",
                                                        "@ID_CONVENIO",
                                                        "@ID_PESSOA_PROFISSIONAL",
                                                        "@ID_TIPO_CONSULTA",
                                                        "@ID_OPT_STATUS_ATENDIMENTO",
                                                        "@ID_OPT_TIPOSAIDA",
                                                        "@ID_OPT_TIPODOENCA",
                                                        "@ID_AGENDAMENTO",
                                                        "@NR_DIA_TEMPODOENCA",
                                                        "@ID_OPT_TEMPODOENCA",
                                                        "@ID_OPT_INDICACAOACIDENTE",
                                                        "@ID_PROCEDIMENTO",
                                                        "@CD_IDENTIFICACAO_CONVENIO",
                                                        "@DH_ATENDIMENTO",
                                                        "@DH_FINALIZACAO",
                                                        "@DS_QUEIXAPRINCIPAL",
                                                        "@DS_OUTRASINFORMACOES")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_ATENDIMENTO", iSQ_ATENDIMENTO, , ParameterDirection.InputOutput),
                               DBParametro_Montar("CD_ATENDIMENTO", sCD_ATENDIMENTO, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_CONVENIO", FNC_NuloZero(iID_CONVENIO, False)),
                               DBParametro_Montar("ID_PESSOA_PROFISSIONAL", FNC_NuloZero(iID_PESSOA_PROFISSIONAL, False)),
                               DBParametro_Montar("ID_TIPO_CONSULTA", FNC_NuloZero(iID_TIPO_CONSULTA, False)),
                               DBParametro_Montar("ID_OPT_STATUS_ATENDIMENTO", iID_OPT_STATUS_ATENDIMENTO),
                               DBParametro_Montar("ID_OPT_TIPOSAIDA", FNC_NuloZero(iID_OPT_TIPOSAIDA, False)),
                               DBParametro_Montar("ID_OPT_TIPODOENCA", FNC_NuloZero(iID_OPT_TIPODOENCA, False)),
                               DBParametro_Montar("ID_AGENDAMENTO", FNC_NuloZero(iID_AGENDAMENTO, False)),
                               DBParametro_Montar("NR_DIA_TEMPODOENCA", FNC_NuloZero(iNR_DIA_TEMPODOENCA, False)),
                               DBParametro_Montar("ID_OPT_TEMPODOENCA", FNC_NuloZero(iID_OPT_TIPODOENCA, False)),
                               DBParametro_Montar("ID_OPT_INDICACAOACIDENTE", FNC_NuloZero(iID_OPT_INDICACAOACIDENTE, False)),
                               DBParametro_Montar("ID_PROCEDIMENTO", FNC_NuloZero(iID_PROCEDIMENTO, False)),
                               DBParametro_Montar("CD_IDENTIFICACAO_CONVENIO", FNC_NuloString(sCD_IDENTIFICACAO_CONVENIO, False)),
                               DBParametro_Montar("DH_ATENDIMENTO", Nothing),
                               DBParametro_Montar("DH_FINALIZACAO", FNC_NuloData(dDH_FINALIZACAO)),
                               DBParametro_Montar("DS_QUEIXAPRINCIPAL", FNC_NuloString(sDS_QUEIXAPRINCIPAL, False), , , const_BancoDados_TamanhoComentario),
                               DBParametro_Montar("DS_OUTRASINFORMACOES", FNC_NuloString(sDS_OUTRASINFORMACOES, False), , , const_BancoDados_TamanhoComentario))
    If DBTeveRetorno() Then
      iSQ_ATENDIMENTO = DBRetorno(1)
      sCD_ATENDIMENTO = DBRetorno(2)
    End If

    Return bOk
  End Function

  Public Function FormLancamentoAtendimento_Diagnostico_Gravar(iSQ_ATENDIMENTO As Integer,
                                                               iID_CID As Integer) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_ATENDIMENTO_DIAGNOSTICO_CAD", False, "@ID_ATENDIMENTO",
                                                                    "@ID_CID")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("ID_ATENDIMENTO", iSQ_ATENDIMENTO),
                               DBParametro_Montar("ID_CID", iID_CID))

    Return bOk
  End Function

  Public Function FormLancamentoAtendimento_Medicamento_Gravar(iSQ_ATENDIMENTO As Integer,
                                                             iID_MEDICAMENTO_APRESENTACAO As Integer,
                                                             iQT_MEDICAMENTO As Integer,
                                                             sDS_POSOLOGIA As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_ATENDIMENTO_MEDICAMENTO_CAD", False, "@ID_ATENDIMENTO",
                                                                    "@ID_MEDICAMENTO_APRESENTACAO",
                                                                    "@QT_MEDICAMENTO",
                                                                    "@DS_POSOLOGIA")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("ID_ATENDIMENTO", iSQ_ATENDIMENTO),
                               DBParametro_Montar("ID_MEDICAMENTO_APRESENTACAO", iID_MEDICAMENTO_APRESENTACAO),
                               DBParametro_Montar("QT_MEDICAMENTO", iQT_MEDICAMENTO),
                               DBParametro_Montar("DS_POSOLOGIA", FNC_NuloString(sDS_POSOLOGIA, False),,, const_BancoDados_TamanhoComentario))

    Return bOk
  End Function

  Public Function FormLancamentoAtendimento_Procedimento_Gravar(iSQ_ATENDIMENTO As Integer,
                                                                iID_PROCEDIMENTO As Integer,
                                                                iQT_PROCEDIMENTO As Integer) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_ATENDIMENTO_PROCEDIMENTO_CAD", False, "@ID_ATENDIMENTO",
                                                                     "@ID_PROCEDIMENTO",
                                                                     "@QT_PROCEDIMENTO")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("ID_ATENDIMENTO", iSQ_ATENDIMENTO),
                               DBParametro_Montar("ID_PROCEDIMENTO", iID_PROCEDIMENTO),
                               DBParametro_Montar("QT_PROCEDIMENTO", iQT_PROCEDIMENTO))

    Return bOk
  End Function

  Public Function FormLancamentoAtendimento_Items_Excluir(iSQ_ATENDIMENTO As Integer) As Boolean
    Dim bOk As Boolean

    If DBExecutar("DELETE FROM TB_ATENDIMENTO_DIAGNOSTICO WHERE ID_ATENDIMENTO = " & iSQ_ATENDIMENTO) Then
      If DBExecutar("DELETE FROM TB_ATENDIMENTO_MEDICAMENTO WHERE ID_ATENDIMENTO = " & iSQ_ATENDIMENTO) Then
        bOk = DBExecutar("DELETE FROM TB_ATENDIMENTO_PROCEDIMENTO WHERE ID_ATENDIMENTO = " & iSQ_ATENDIMENTO)
      End If
    End If

    Return bOk
  End Function

  Public Sub FormLancamentoAgendamento_CanceladoFalta_Atualizar(Optional iID_PESSOA As Integer = 0)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_AGENDAMENTO_STATUS_CANCELADOPORFALTA_UPD", False, "@ID_EMPRESA",
                                                                                 "@ID_PESSOA")
    DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                         DBParametro_Montar("ID_PESSOA", iID_PESSOA))
  End Sub

  Public Sub FormLancamentoAtendimentoMedico_TABAnamnese_Carregar(pnlAnamneseContainer As Panel,
                                                                  iTipoAnmnese As Integer,
                                                                  iSQ_QUESTIONARIO As Integer,
                                                                  iSQ_QUESTIONARIO_VERSAO As Integer,
                                                                  iID_QUESTIONARIO_RESPOSTA As Integer,
                                                                  iSQ_MODELODOCUMENTO As Integer,
                                                                  sEditorTexto As String,
                                                                  Optional bPodeEditar As Boolean = True,
                                                                  Optional sComentario As String = "")
    pnlAnamneseContainer.Controls.Clear()

    Dim oControl As Control = Nothing

    Select Case iTipoAnmnese
      Case const_Anamnese_Formulario
        Dim oQuestionario_Formulario As New uscQuestionario_Formulario

        oQuestionario_Formulario.SQ_QUESTIONARIO = iSQ_QUESTIONARIO
        oQuestionario_Formulario.SQ_QUESTIONARIO_VERSAO = iSQ_QUESTIONARIO_VERSAO
        oQuestionario_Formulario.SQ_QUESTIONARIO_RESPOSTA = iID_QUESTIONARIO_RESPOSTA
        oQuestionario_Formulario.PodeEditar = bPodeEditar
        oQuestionario_Formulario.Comentario = sComentario
        oQuestionario_Formulario.CarregarDados()

        oControl = oQuestionario_Formulario
      Case const_Anamnese_ModeloDocumento
        Dim oEditorTexto As New uscEditorTexto

        oEditorTexto.MODELODOCUMENTO = iSQ_MODELODOCUMENTO
        oEditorTexto.SoLeitura = (Not bPodeEditar)

        If Trim(sEditorTexto) <> "" Then
          oEditorTexto.Rtf = sEditorTexto
        End If

        oControl = oEditorTexto
    End Select

    oControl.Top = 1
    oControl.Left = 1
    oControl.Width = pnlAnamneseContainer.Width
    oControl.Height = pnlAnamneseContainer.Height

    pnlAnamneseContainer.Controls.Add(oControl)
  End Sub

  Public Function FormLancamentoAnamnese_Gravar(ByRef iSQ_ANAMNESE As Integer,
                                                iID_OPT_TIPOANAMNESE As Integer,
                                                iID_PACIENTE As Integer,
                                                iID_DOENCA_ESTAGIO As Integer,
                                                iSQ_ATENDIMENTO As Integer,
                                                iID_QUESTIONARIO_RESPOSTA As Integer,
                                                sTX_ANAMNESE As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_ANAMNESE_CAD", False, "@SQ_ANAMNESE OUT",
                                                     "@ID_EMPRESA",
                                                     "@ID_OPT_TIPOANAMNESE",
                                                     "@ID_PESSOA_PROFISSIONAL",
                                                     "@ID_PESSOA",
                                                     "@ID_DOENCA_ESTAGIO",
                                                     "@ID_ATENDIMENTO",
                                                     "@ID_QUESTIONARIO_RESPOSTA",
                                                     "@DT_ANAMNESE",
                                                     "@TX_ANAMNESE")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_ANAMNESE", iSQ_ANAMNESE, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_OPT_TIPOANAMNESE", iID_OPT_TIPOANAMNESE),
                               DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_USUARIO),
                               DBParametro_Montar("ID_PESSOA", iID_PACIENTE),
                               DBParametro_Montar("ID_DOENCA_ESTAGIO", FNC_NuloZero(iID_DOENCA_ESTAGIO, False)),
                               DBParametro_Montar("ID_ATENDIMENTO", FNC_NuloZero(iSQ_ATENDIMENTO, False)),
                               DBParametro_Montar("ID_QUESTIONARIO_RESPOSTA", FNC_NuloZero(iID_QUESTIONARIO_RESPOSTA, False)),
                               DBParametro_Montar("DT_ANAMNESE", Now(), SqlDbType.DateTime),
                               DBParametro_Montar("TX_ANAMNESE", FNC_NuloString(sTX_ANAMNESE, False), SqlDbType.NText))
    If bOk Then
      If DBTeveRetorno() Then
        iSQ_ANAMNESE = DBRetorno(1)
      End If
    End If

    Return bOk
  End Function

  Public Function FormCadastroDocumentoFiscal_Gravar(ByRef iSQ_DOCUMENTOFISCAL As Integer,
                                                     iID_NATUREZAOPERACAO As Integer,
                                                     iID_PESSOA As Integer,
                                                     iID_ENDERECO As Integer,
                                                     iID_ENDERECO_RETIRADA As Integer,
                                                     iID_PESSOA_TELEFONE As Integer,
                                                     iID_PESSOA_MIDIASOCIAL As Integer,
                                                     iID_DOCUMENTOFISCAL_SERIE As Integer,
                                                     iID_PESSOA_TRANSPORTADORA As Integer,
                                                     iID_ENDERECO_TRANSPORTADORA As Integer,
                                                     iID_PESSOATELEFONE_TRANSPORTADORA As Integer,
                                                     iID_TRANSPORTE_PLACA_UF As Integer,
                                                     iID_TRANSPORTE_PLACA_2_UF As Integer,
                                                     iID_OPT_STATUS As Integer,
                                                     iID_DOCUMENTOFISCAL_TIPO As Integer,
                                                     iID_OPT_FINALIDADE As Integer,
                                                     iID_OPT_FRETE As Integer,
                                                     iID_OPT_COMPRADORPRESENTE As Integer,
                                                     iID_OPT_NFE_FORMATOEMISSAO As Integer,
                                                     iID_EQUIPAMENTO_PROCESSAMENTO_FISCAL As Integer,
                                                     iID_PEDIDO_PAGAMENTO As Integer,
                                                     bIC_EXIBIR_PESSOA As Boolean,
                                                     bIC_EXIBIR_ENDERECO As Boolean,
                                                     sCD_CHAVE_NFE As String,
                                                     sCD_NF_MODELO As String,
                                                     sCD_NF_SERIE As String,
                                                     sCD_DOCUMENTOFISCAL As String,
                                                     sCD_TRANSPORTE_PLACA As String,
                                                     sCD_TRANSPORTE_PLACA_2 As String,
                                                     dDH_EMISSAO As Date,
                                                     dDH_SAIDA As Date,
                                                     dDH_CONTIGENCIA As Date,
                                                     dQT_VOLUMES As Double,
                                                     dQT_PESO_BRUTO As Double,
                                                     dQT_PESO_LIQUIDO As Double,
                                                     sDS_ESPECIE As String,
                                                     sDS_MARCA As String,
                                                     sDS_JUSTIFICATIVA_CONTIGENCIA As String,
                                                     sDS_INFORMACOES_ADICIONAIS As String,
                                                     sDS_PATH_XML As String,
                                                     sCD_PROTOCOLO As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_CAD", False, "@SQ_DOCUMENTOFISCAL OUTPUT",
                                                            "@ID_EMPRESA",
                                                            "@ID_NATUREZAOPERACAO",
                                                            "@ID_PESSOA",
                                                            "@ID_ENDERECO",
                                                            "@ID_ENDERECO_RETIRADA",
                                                            "@ID_PESSOA_TELEFONE",
                                                            "@ID_PESSOA_MIDIASOCIAL_EMAIL",
                                                            "@ID_DOCUMENTOFISCAL_SERIE",
                                                            "@ID_PESSOA_TRANSPORTADORA",
                                                            "@ID_ENDERECO_TRANSPORTADORA",
                                                            "@ID_PESSOATELEFONE_TRANSPORTADORA",
                                                            "@ID_TRANSPORTE_PLACA_UF",
                                                            "@ID_TRANSPORTE_PLACA_2_UF",
                                                            "@ID_OPT_STATUS",
                                                            "@ID_DOCUMENTOFISCAL_TIPO",
                                                            "@ID_OPT_FINALIDADE",
                                                            "@ID_OPT_FRETE",
                                                            "@ID_OPT_COMPRADORPRESENTE",
                                                            "@ID_OPT_NFE_FORMATOEMISSAO",
                                                            "@ID_EQUIPAMENTO_PROCESSAMENTO_FISCAL",
                                                            "@ID_PEDIDO_PAGAMENTO",
                                                            "@IC_EXIBIR_PESSOA",
                                                            "@IC_EXIBIR_ENDERECO",
                                                            "@CD_CHAVE_NFE",
                                                            "@CD_NF_MODELO",
                                                            "@CD_NF_SERIE",
                                                            "@CD_DOCUMENTOFISCAL",
                                                            "@CD_TRANSPORTE_PLACA",
                                                            "@CD_TRANSPORTE_PLACA_2",
                                                            "@DH_EMISSAO",
                                                            "@DH_SAIDA",
                                                            "@DH_CONTIGENCIA",
                                                            "@QT_VOLUMES",
                                                            "@QT_PESO_BRUTO",
                                                            "@QT_PESO_LIQUIDO",
                                                            "@DS_ESPECIE",
                                                            "@DS_MARCA",
                                                            "@DS_JUSTIFICATIVA_CONTIGENCIA",
                                                            "@DS_INFORMACOES_ADICIONAIS",
                                                            "@DS_PATH_XML",
                                                            "@CD_PROTOCOLO")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFISCAL", iSQ_DOCUMENTOFISCAL, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_NATUREZAOPERACAO", iID_NATUREZAOPERACAO),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_ENDERECO", FNC_NuloZero(iID_ENDERECO, False)),
                               DBParametro_Montar("ID_ENDERECO_RETIRADA", FNC_NuloZero(iID_ENDERECO_RETIRADA, False)),
                               DBParametro_Montar("ID_PESSOA_TELEFONE", FNC_NuloZero(iID_PESSOA_TELEFONE, False)),
                               DBParametro_Montar("ID_PESSOA_MIDIASOCIAL_EMAIL", FNC_NuloZero(iID_PESSOA_MIDIASOCIAL, False)),
                               DBParametro_Montar("ID_DOCUMENTOFISCAL_SERIE", FNC_NuloZero(iID_DOCUMENTOFISCAL_SERIE, False)),
                               DBParametro_Montar("ID_PESSOA_TRANSPORTADORA", FNC_NuloZero(iID_PESSOA_TRANSPORTADORA, False)),
                               DBParametro_Montar("ID_ENDERECO_TRANSPORTADORA", FNC_NuloZero(iID_ENDERECO_TRANSPORTADORA, False)),
                               DBParametro_Montar("ID_PESSOATELEFONE_TRANSPORTADORA", FNC_NuloZero(iID_PESSOATELEFONE_TRANSPORTADORA, False)),
                               DBParametro_Montar("ID_TRANSPORTE_PLACA_UF", FNC_NuloZero(iID_TRANSPORTE_PLACA_UF, False)),
                               DBParametro_Montar("ID_TRANSPORTE_PLACA_2_UF", FNC_NuloZero(iID_TRANSPORTE_PLACA_2_UF, False)),
                               DBParametro_Montar("ID_OPT_STATUS", FNC_NuloZero(iID_OPT_STATUS, False)),
                               DBParametro_Montar("ID_DOCUMENTOFISCAL_TIPO", FNC_NuloZero(iID_DOCUMENTOFISCAL_TIPO, False)),
                               DBParametro_Montar("ID_OPT_FINALIDADE", FNC_NuloZero(iID_OPT_FINALIDADE, False)),
                               DBParametro_Montar("ID_OPT_FRETE", FNC_NuloZero(iID_OPT_FRETE, False)),
                               DBParametro_Montar("ID_OPT_COMPRADORPRESENTE", FNC_NuloZero(iID_OPT_COMPRADORPRESENTE, False)),
                               DBParametro_Montar("ID_OPT_NFE_FORMATOEMISSAO", FNC_NuloZero(iID_OPT_NFE_FORMATOEMISSAO, False)),
                               DBParametro_Montar("ID_EQUIPAMENTO_PROCESSAMENTO_FISCAL", FNC_NuloZero(iID_EQUIPAMENTO_PROCESSAMENTO_FISCAL, False)),
                               DBParametro_Montar("ID_PEDIDO_PAGAMENTO", FNC_NuloZero(iID_PEDIDO_PAGAMENTO, False)),
                               DBParametro_Montar("IC_EXIBIR_PESSOA", IIf(bIC_EXIBIR_PESSOA, "S", "N")),
                               DBParametro_Montar("IC_EXIBIR_ENDERECO", IIf(bIC_EXIBIR_ENDERECO, "S", "N")),
                               DBParametro_Montar("CD_CHAVE_NFE", FNC_NuloString(sCD_CHAVE_NFE, False)),
                               DBParametro_Montar("CD_NF_MODELO", FNC_NuloString(sCD_NF_MODELO, False)),
                               DBParametro_Montar("CD_NF_SERIE", FNC_NuloString(sCD_NF_SERIE, False)),
                               DBParametro_Montar("CD_DOCUMENTOFISCAL", FNC_NuloString(sCD_DOCUMENTOFISCAL, False)),
                               DBParametro_Montar("CD_TRANSPORTE_PLACA", FNC_NuloString(sCD_TRANSPORTE_PLACA, False)),
                               DBParametro_Montar("CD_TRANSPORTE_PLACA_2", FNC_NuloString(sCD_TRANSPORTE_PLACA_2, False)),
                               DBParametro_Montar("DH_EMISSAO", FNC_NuloData(dDH_EMISSAO)),
                               DBParametro_Montar("DH_SAIDA", FNC_NuloData(dDH_SAIDA)),
                               DBParametro_Montar("DH_CONTIGENCIA", FNC_NuloData(dDH_CONTIGENCIA)),
                               DBParametro_Montar("QT_VOLUMES", FNC_NuloZero(dQT_VOLUMES, False)),
                               DBParametro_Montar("QT_PESO_BRUTO", FNC_NuloZero(dQT_PESO_BRUTO, False)),
                               DBParametro_Montar("QT_PESO_LIQUIDO", FNC_NuloZero(dQT_PESO_LIQUIDO, False)),
                               DBParametro_Montar("DS_ESPECIE", FNC_NuloString(sDS_ESPECIE, False)),
                               DBParametro_Montar("DS_MARCA", FNC_NuloString(sDS_MARCA, False)),
                               DBParametro_Montar("DS_JUSTIFICATIVA_CONTIGENCIA", FNC_NuloString(sDS_JUSTIFICATIVA_CONTIGENCIA, False),,, const_BancoDados_TamanhoComentario_DocumentoFiscal),
                               DBParametro_Montar("DS_INFORMACOES_ADICIONAIS", FNC_NuloString(sDS_INFORMACOES_ADICIONAIS, False),,, const_BancoDados_TamanhoComentario_DocumentoFiscal),
                               DBParametro_Montar("DS_PATH_XML", FNC_NuloString(sDS_PATH_XML, False),,, const_BancoDados_TamanhoComentario_DocumentoFiscal),
                               DBParametro_Montar("CD_PROTOCOLO", FNC_NuloString(sCD_PROTOCOLO, False)))
    If bOk Then
      If DBTeveRetorno() Then
        iSQ_DOCUMENTOFISCAL = DBRetorno(1)
      End If
    End If

    Return bOk
  End Function

  Public Sub FormCadastroDocumentoFiscalReferencia_Gravar(ByRef iID_DOCUMENTOFISCAL As Integer,
                                                          sCD_CHAVE_NFE_REFENCENCIA As String)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_REFERENCIA_CAD", False, "@ID_DOCUMENTOFISCAL",
                                                                       "@CD_CHAVE_NFE_REFENCENCIA")

    DBExecutar(sSqlText, DBParametro_Montar("ID_DOCUMENTOFISCAL", iID_DOCUMENTOFISCAL),
                         DBParametro_Montar("CD_CHAVE_NFE_REFENCENCIA", sCD_CHAVE_NFE_REFENCENCIA))
  End Sub


  Public Function FormCadastroDocumentoFiscal_Produto_Gravar(ByRef iSQ_DOCUMENTOFISCAL_PRODUTO As Integer,
                                                                   iID_DOCUMENTOFISCAL As Integer,
                                                                   iID_PRODUTO_EMPRESA As Integer,
                                                                   iID_UNIDADEMEDIDA As Integer,
                                                                   iID_OPT_STATUS As Integer,
                                                                   iID_PEDIDO_PRODUTO As Integer,
                                                                   iID_CFOP As Integer,
                                                                   iID_CSOSN As Integer,
                                                                   iID_CST As Integer,
                                                                   iID_CST_IPI As Integer,
                                                                   iID_CST_PIS As Integer,
                                                                   iID_NCM As Integer,
                                                                   iID_CEST As Integer,
                                                                   iID_TRANSACAOESTOQUE As Integer,
                                                                   sCD_GTIN As String,
                                                                   dQT_PRODUTO As Double,
                                                                   dVL_UNITARIO As Double,
                                                                   dVL_FRETE As Double,
                                                                   dVL_SEGURO As Double,
                                                                   dVL_DESCONTO As Double,
                                                                   dVL_OUTRAS_DESPESAS As Double,
                                                                   dVL_ICMS As Double,
                                                                   dVL_SUBSTITUICAO_ICMS As Double,
                                                                   dVL_II As Double,
                                                                   dVL_IPI As Double,
                                                                   dVL_PIS As Double,
                                                                   dVL_COFINS As Double,
                                                                   dPC_BASE_SUBSTITUICAO_ICMS As Double,
                                                                   dPC_BASE_ICMS As Double,
                                                                   dPC_ICMS As Double,
                                                                   dPC_COFINS As Double,
                                                                   dPC_IPI As Double,
                                                                   dPC_PIS As Double,
                                                                   dPC_II As Double,
                                                                   sIC_TOTALIZA As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_PRODUTO_CAD", False, "@SQ_DOCUMENTOFISCAL_PRODUTO OUT",
                                                                    "@ID_DOCUMENTOFISCAL",
                                                                    "@ID_PRODUTO_EMPRESA",
                                                                    "@ID_UNIDADEMEDIDA",
                                                                    "@ID_OPT_STATUS",
                                                                    "@ID_PEDIDO_PRODUTO",
                                                                    "@ID_CFOP",
                                                                    "@ID_CSOSN",
                                                                    "@ID_CST",
                                                                    "@ID_CST_IPI",
                                                                    "@ID_CST_PIS",
                                                                    "@ID_NCM",
                                                                    "@ID_CEST",
                                                                    "@ID_TRANSACAOESTOQUE",
                                                                    "@CD_GTIN",
                                                                    "@QT_PRODUTO",
                                                                    "@VL_UNITARIO",
                                                                    "@VL_FRETE",
                                                                    "@VL_SEGURO",
                                                                    "@VL_DESCONTO",
                                                                    "@VL_OUTRAS_DESPESAS",
                                                                    "@VL_ICMS",
                                                                    "@VL_SUBSTITUICAO_ICMS",
                                                                    "@VL_II",
                                                                    "@VL_IPI",
                                                                    "@VL_PIS",
                                                                    "@VL_COFINS",
                                                                    "@PC_BASE_SUBSTITUICAO_ICMS",
                                                                    "@PC_BASE_ICMS",
                                                                    "@PC_ICMS",
                                                                    "@PC_COFINS",
                                                                    "@PC_IPI",
                                                                    "@PC_PIS",
                                                                    "@PC_II",
                                                                    "@IC_TOTALIZA")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFISCAL_PRODUTO", iSQ_DOCUMENTOFISCAL_PRODUTO,, ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_DOCUMENTOFISCAL", iID_DOCUMENTOFISCAL),
                               DBParametro_Montar("ID_PRODUTO_EMPRESA", iID_PRODUTO_EMPRESA),
                               DBParametro_Montar("ID_UNIDADEMEDIDA", iID_UNIDADEMEDIDA),
                               DBParametro_Montar("ID_OPT_STATUS", iID_OPT_STATUS),
                               DBParametro_Montar("ID_PEDIDO_PRODUTO", FNC_NuloZero(iID_PEDIDO_PRODUTO, False)),
                               DBParametro_Montar("ID_CFOP", FNC_NuloZero(iID_CFOP, False)),
                               DBParametro_Montar("ID_CSOSN", FNC_NuloZero(iID_CSOSN, False)),
                               DBParametro_Montar("ID_CST", FNC_NuloZero(iID_CST, False)),
                               DBParametro_Montar("ID_CST_IPI", FNC_NuloZero(iID_CST_IPI, False)),
                               DBParametro_Montar("ID_CST_PIS", FNC_NuloZero(iID_CST_PIS, False)),
                               DBParametro_Montar("ID_NCM", FNC_NuloZero(iID_NCM, False)),
                               DBParametro_Montar("ID_CEST", FNC_NuloZero(iID_CEST, False)),
                               DBParametro_Montar("ID_TRANSACAOESTOQUE", FNC_NuloZero(iID_TRANSACAOESTOQUE, False)),
                               DBParametro_Montar("CD_GTIN", FNC_NuloString(sCD_GTIN, False)),
                               DBParametro_Montar("QT_PRODUTO", FNC_NuloZero(dQT_PRODUTO, False)),
                               DBParametro_Montar("VL_UNITARIO", FNC_NuloZero(dVL_UNITARIO, False)),
                               DBParametro_Montar("VL_FRETE", FNC_NuloZero(dVL_FRETE, False)),
                               DBParametro_Montar("VL_SEGURO", FNC_NuloZero(dVL_SEGURO, False)),
                               DBParametro_Montar("VL_DESCONTO", FNC_NuloZero(dVL_DESCONTO, False)),
                               DBParametro_Montar("VL_OUTRAS_DESPESAS", FNC_NuloZero(dVL_OUTRAS_DESPESAS, False)),
                               DBParametro_Montar("VL_ICMS", FNC_NuloZero(dVL_ICMS, False)),
                               DBParametro_Montar("VL_SUBSTITUICAO_ICMS", FNC_NuloZero(dVL_SUBSTITUICAO_ICMS, False)),
                               DBParametro_Montar("VL_II", FNC_NuloZero(dVL_II, False)),
                               DBParametro_Montar("VL_IPI", FNC_NuloZero(dVL_IPI, False)),
                               DBParametro_Montar("VL_PIS", FNC_NuloZero(dVL_PIS, False)),
                               DBParametro_Montar("VL_COFINS", FNC_NuloZero(dVL_COFINS, False)),
                               DBParametro_Montar("PC_BASE_SUBSTITUICAO_ICMS", FNC_NuloZero(dPC_BASE_SUBSTITUICAO_ICMS, False)),
                               DBParametro_Montar("PC_BASE_ICMS", FNC_NuloZero(dPC_BASE_ICMS, False)),
                               DBParametro_Montar("PC_ICMS", FNC_NuloZero(dPC_ICMS, False)),
                               DBParametro_Montar("PC_COFINS", FNC_NuloZero(dPC_COFINS, False)),
                               DBParametro_Montar("PC_IPI", FNC_NuloZero(dPC_IPI, False)),
                               DBParametro_Montar("PC_PIS", FNC_NuloZero(dPC_PIS, False)),
                               DBParametro_Montar("PC_II", FNC_NuloZero(dPC_II, False)),
                               DBParametro_Montar("IC_TOTALIZA", FNC_NuloString(sIC_TOTALIZA, False)))
    If bOk Then
      If DBTeveRetorno() Then
        iSQ_DOCUMENTOFISCAL_PRODUTO = DBRetorno(1)
      End If
    End If

    Return bOk
  End Function

  Public Sub FormCadastroDocumentoFiscal_Produto_Cancelar(iID_DOCUMENTOFISCAL_PRODUTO As Integer)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_PRODUTO_CCL", False, "@ID_DOCUMENTOFISCAL_PRODUTO")
    DBExecutar(sSqlText, DBParametro_Montar("ID_DOCUMENTOFISCAL_PRODUTO", iID_DOCUMENTOFISCAL_PRODUTO))
  End Sub

  Public Sub FormCadastroDocumentoFiscal_Produto_NRSerie_Excluir(iID_DOCUMENTOFISCAL_PRODUTO As Integer,
                                                                sCD_NUMEROSERIE As String)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_PRODUTO_NRSERIE_DEL", False, "@ID_DOCUMENTOFISCAL_PRODUTO",
                                                                            "@CD_NUMEROSERIE")
    DBExecutar(sSqlText, DBParametro_Montar("ID_DOCUMENTOFISCAL_PRODUTO", iID_DOCUMENTOFISCAL_PRODUTO),
                         DBParametro_Montar("CD_NUMEROSERIE", sCD_NUMEROSERIE))
  End Sub

  Public Function FormCadastroAtendimentoSolicitacaoExameCitologico(ByRef iSQ_CLINICA_EXAME_CITOLOGICO As Integer,
                                                                     iID_CLINICA_ATENDIMENTO As Integer,
                                                                     iID_CLINICA_VENDA As Integer,
                                                                     sDS_MEDICO_EXTERNO As String,
                                                                     sDS_COLETA As String,
                                                                     sDS_UM As String,
                                                                     sDS_FILHOS As String,
                                                                     sDS_ABORTO As String,
                                                                     sDS_PARA As String,
                                                                     sDS_LOCAL_COLETA As String,
                                                                     sDS_ACHADOS_COLPOSCOPICOS As String,
                                                                     sIC_DIU As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    sSqlText = DBMontar_SP("SP_CLINICA_EXAME_CITOLOGICO_CAD", False, "@SQ_CLINICA_EXAME_CITOLOGICO OUT",
                                                                     "@ID_CLINICA_ATENDIMENTO",
                                                                     "@ID_CLINICA_VENDA",
                                                                     "@DS_MEDICO_EXTERNO",
                                                                     "@DS_COLETA",
                                                                     "@DS_UM",
                                                                     "@DS_FILHOS",
                                                                     "@DS_ABORTO",
                                                                     "@DS_PARA",
                                                                     "@DS_LOCAL_COLETA",
                                                                     "@DS_ACHADOS_COLPOSCOPICOS",
                                                                     "@IC_DIU")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_EXAME_CITOLOGICO", iSQ_CLINICA_EXAME_CITOLOGICO, , ParameterDirection.InputOutput),
                              DBParametro_Montar("ID_CLINICA_ATENDIMENTO", FNC_NuloZero(iID_CLINICA_ATENDIMENTO, False)),
                              DBParametro_Montar("ID_CLINICA_VENDA", FNC_NuloZero(iID_CLINICA_VENDA, False)),
                              DBParametro_Montar("DS_MEDICO_EXTERNO", sDS_MEDICO_EXTERNO),
                              DBParametro_Montar("DS_COLETA", sDS_COLETA),
                              DBParametro_Montar("DS_UM", sDS_UM),
                              DBParametro_Montar("DS_FILHOS", sDS_FILHOS),
                              DBParametro_Montar("DS_ABORTO", sDS_ABORTO),
                              DBParametro_Montar("DS_PARA", sDS_PARA),
                              DBParametro_Montar("DS_LOCAL_COLETA", sDS_LOCAL_COLETA),
                              DBParametro_Montar("DS_ACHADOS_COLPOSCOPICOS", sDS_ACHADOS_COLPOSCOPICOS),
                              DBParametro_Montar("IC_DIU", FNC_NuloString(sIC_DIU, False))) Then
      If DBTeveRetorno() Then
        iSQ_CLINICA_EXAME_CITOLOGICO = DBRetorno(1)
      End If

      bOk = True
    End If

    Return bOk
  End Function

  Public Sub FormCadastroDocumentoFiscal_Produto_NRSerie_Excluir(iID_DOCUMENTOFISCAL_PRODUTO As Integer)
    FormCadastroDocumentoFiscal_Produto_NRSerie_Excluir(iID_DOCUMENTOFISCAL_PRODUTO, Nothing)
  End Sub

  Public Sub FormCadastroDocumentoFiscal_Produto_NRSerie_Gravar(iID_DOCUMENTOFISCAL_PRODUTO As Integer,
                                                                sCD_NUMEROSERIE As String)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_PRODUTO_NRSERIE_CAD", False, "@ID_DOCUMENTOFISCAL_PRODUTO",
                                                                            "@CD_NUMEROSERIE")
    DBExecutar(sSqlText, DBParametro_Montar("ID_DOCUMENTOFISCAL_PRODUTO", iID_DOCUMENTOFISCAL_PRODUTO),
                         DBParametro_Montar("CD_NUMEROSERIE", sCD_NUMEROSERIE))
  End Sub

  Public Sub FormCadastroDocumentoFiscal_Produto_Pedido_Exluir(iID_PEDIDO As Integer)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_PRODUTO_PEDIDO_DEL", False, "@ID_PEDIDO")
    DBExecutar(sSqlText, DBParametro_Montar("ID_PEDIDO", iID_PEDIDO))
  End Sub

  Public Sub FormCadastroDocumentoFiscal_TipoDocumentoFiscal_Carregar(oCboTipoDocumentoFiscal As ComboBox,
                                                                      oCboSerieDocumentoFiscal As ComboBox,
                                                                      oLblInfoDocumentoFiscal As Label)
    If ComboBox_Selecionado(oCboTipoDocumentoFiscal) Then
      oLblInfoDocumentoFiscal.Text = oCboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.CD_DOCUMENTOFISCAL_TIPO).ToString() +
                                     "/Mod: " + oCboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.CD_SERVICO_MODELO).ToString() +
                                     "/Versão " + oCboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.CD_SERVICO_VERSAO).ToString()
      ComboBox_Carregar(oCboSerieDocumentoFiscal, enSql.SerieDocumentoFiscal, New Object() {oCboTipoDocumentoFiscal.SelectedValue})

      ComboBox_Selecionar(oCboSerieDocumentoFiscal, FNC_Busca_DocumentoFiscal_Tipo_SeriePadrao_Venda(oCboTipoDocumentoFiscal.SelectedValue))

      If oCboSerieDocumentoFiscal.Items.Count = 1 Then
        oCboSerieDocumentoFiscal.SelectedIndex = 0
      End If
    Else
      oLblInfoDocumentoFiscal.Text = ""
      oCboSerieDocumentoFiscal.DataSource = Nothing
    End If
  End Sub

  Public Sub FormCadastroDocumentoFiscal_CartaCorrecao_Gravar(iSQ_DOCUMENTOFISCAL As Integer,
                                                              sDS_CARTACORRECAO As String)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_CARTACORRECAO_UPD", False, "@SQ_DOCUMENTOFISCAL",
                                                                          "@DS_CARTACORRECAO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFISCAL", iSQ_DOCUMENTOFISCAL),
                         DBParametro_Montar("DS_CARTACORRECAO", sDS_CARTACORRECAO, 1000))
  End Sub

  Public Function FormCadastroDocumentoFiscal_Cancelamento_Gravar(iSQ_DOCUMENTOFISCAL As Integer,
                                                                  sDS_JUSTIFICATIVA_CANCELAMENTO As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    Try
      sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_CCL", False, "@SQ_DOCUMENTOFISCAL",
                                                              "@DS_JUSTIFICATIVA_CANCELAMENTO")
      DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFISCAL", iSQ_DOCUMENTOFISCAL),
                           DBParametro_Montar("DS_JUSTIFICATIVA_CANCELAMENTO", sDS_JUSTIFICATIVA_CANCELAMENTO,,, 1000))

      bOk = True
    Catch ex As Exception
    End Try

    Return bOk
  End Function

  Public Function FormCadastroDocumentoFiscal_Inutilizacao_Gravar(iID_DOCUMENTOFISCAL_TIPO As Integer,
                                                                  iID_DOCUMENTOFISCAL_SERIE As Integer,
                                                                  sCD_DOCUMENTOFISCAL_INICIAL As String,
                                                                  sCD_DOCUMENTOFISCAL_FINAL As String,
                                                                  sCM_JUSTIFICATIVA As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    Try
      sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_INUTILIZACAO_CAD", False, "@SQ_DOCUMENTOFISCAL_INUTILIZACAO",
                                                                           "@ID_EMPRESA",
                                                                           "@ID_DOCUMENTOFISCAL_TIPO",
                                                                           "@ID_DOCUMENTOFISCAL_SERIE",
                                                                           "@DH_INUTILIZACAO",
                                                                           "@CD_DOCUMENTOFISCAL_INICIAL",
                                                                           "@CD_DOCUMENTOFISCAL_FINAL",
                                                                           "@CM_JUSTIFICATIVA")
      DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFISCAL_INUTILIZACAO", Nothing),
                           DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                           DBParametro_Montar("ID_DOCUMENTOFISCAL_TIPO", iID_DOCUMENTOFISCAL_TIPO),
                           DBParametro_Montar("ID_DOCUMENTOFISCAL_SERIE", iID_DOCUMENTOFISCAL_SERIE),
                           DBParametro_Montar("DH_INUTILIZACAO", Now(), SqlDbType.DateTime),
                           DBParametro_Montar("CD_DOCUMENTOFISCAL_INICIAL", sCD_DOCUMENTOFISCAL_INICIAL),
                           DBParametro_Montar("CD_DOCUMENTOFISCAL_FINAL", sCD_DOCUMENTOFISCAL_FINAL),
                           DBParametro_Montar("CM_JUSTIFICATIVA", sCM_JUSTIFICATIVA,,, const_BancoDados_TamanhoComentario))

      bOk = True
    Catch ex As Exception
    End Try

    Return bOk
  End Function

  Public Function FormCadastroDocumentoFiscal_CFOP_Carregar(cboNaturezaOperacao As ComboBox,
                                                            cboEnderecoFaturamento As ComboBox,
                                                            cboCFOP_Pedido As UltraCombo,
                                                            cboCFOP As UltraCombo)
    If ComboBox_Selecionado(cboNaturezaOperacao) Then
      If ComboBox_Selecionado(cboEnderecoFaturamento) Then
        If FNC_NVL(cboEnderecoFaturamento.SelectedItem(enComboBox_Endereco.ID_PAIS), 0) <> iID_EMPRESA_PAIS Then
          UltraComboBox_Carregar(cboCFOP_Pedido, enSql.CFOP_ForaPais)
          UltraComboBox_Carregar(cboCFOP, enSql.CFOP_ForaPais)
          UltraComboBox_Selecionar(cboCFOP_Pedido, enCombox_CFOP.SQ_CFOP, cboNaturezaOperacao.SelectedItem(enComboBox_NaturezaoOperacao.ID_CFOP_FORAPAIS))
        ElseIf FNC_NVL(cboEnderecoFaturamento.SelectedItem(enComboBox_Endereco.ID_UF), 0) <> iID_EMPRESA_UF Then
          UltraComboBox_Carregar(cboCFOP_Pedido, enSql.CFOP_ForaEstado)
          UltraComboBox_Carregar(cboCFOP, enSql.CFOP_ForaEstado)
          UltraComboBox_Selecionar(cboCFOP_Pedido, enCombox_CFOP.SQ_CFOP, cboNaturezaOperacao.SelectedItem(enComboBox_NaturezaoOperacao.ID_CFOP_FORAESTADO))
        Else
          UltraComboBox_Carregar(cboCFOP_Pedido, enSql.CFOP_DentroEstado)
          UltraComboBox_Carregar(cboCFOP, enSql.CFOP_DentroEstado)
          UltraComboBox_Selecionar(cboCFOP_Pedido, enCombox_CFOP.SQ_CFOP, cboNaturezaOperacao.SelectedItem(enComboBox_NaturezaoOperacao.ID_CFOP_DENTROESTADO))
        End If
      Else
        UltraComboBox_Carregar(cboCFOP_Pedido, enSql.CFOP_DentroEstado)
        UltraComboBox_Carregar(cboCFOP, enSql.CFOP_DentroEstado)
        UltraComboBox_Selecionar(cboCFOP_Pedido, enCombox_CFOP.SQ_CFOP, cboNaturezaOperacao.SelectedItem(enComboBox_NaturezaoOperacao.ID_CFOP_DENTROESTADO))
      End If
    End If
  End Function

  Public Function FormCadastroDocumentoFiscal_GerarCupom(iID_DOCUMENTOFISCAL As Integer,
                                                         bNaoInformadoConsumidor As Boolean,
                                                         Optional sMensagem01 As String = "",
                                                         Optional sMensagem02 As String = "",
                                                         Optional ValorDesconto As Double = 0) As Boolean
    Dim bOk As Boolean = False
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer
    Dim sNumeroCupom As String
    Dim oACBrMonitor As New clsACBrMonitor

    oACBrMonitor = New clsACBrMonitor()
    oACBrMonitor.Controle_Abrir()
    oACBrMonitor.ECF_Equipamento_Ativar()

    'If Not oACBrMonitor.ECF_Equipamento_PodeAbrirCupom Then
    '  FNC_Mensagem("Existe algum problema para imprimir o cupom. Resolva e imprima o mesmo pela consulta de Documento Fiscal")
    '  Exit Function
    'End If

    If bNaoInformadoConsumidor Then
      oACBrMonitor.ECF_Cupom_Abrir()
    Else
      sSqlText = "SELECT * FROM VW_DOCUMENTOFISCAL WHERE SQ_DOCUMENTOFISCAL = " & iID_DOCUMENTOFISCAL
      oData = DBQuery(sSqlText)

      With oData.Rows(0)
        oACBrMonitor.ECF_Cupom_Abrir(.Item("CD_CPF_CNPJ_FORMATADO"), .Item("NO_PESSOA"), FNC_NVL(.Item("DS_ENDERECO"), ""))
      End With
    End If

    sSqlText = "SELECT * FROM VW_DOCUMENTOFISCAL_PRODUTO WHERE ID_DOCUMENTOFISCAL = " & iID_DOCUMENTOFISCAL
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      With oData.Rows(iCont)
        oACBrMonitor.ECF_Cupom_Item(FNC_NVL(.Item("CD_PRODUTO"), ""),
                                    .Item("NO_PRODUTO"), "NN",
                                    .Item("QT_PRODUTO"),
                                    .Item("VL_UNITARIO"))
      End With
    Next

    oACBrMonitor.ECF_Cupom_SubTotalizar(0 - ValorDesconto)

    sSqlText = "SELECT FPE.CD_FORMAPAGAMENTO_EQUIPAMENTO," &
                        "PFP.VL_PAGAMENTO" &
                 " FROM TB_DOCUMENTOFISCAL DFC" &
                  " INNER JOIN TB_DOCUMENTOFISCAL_PRODUTO DFP ON DFP.ID_DOCUMENTOFISCAL = DFC.SQ_DOCUMENTOFISCAL" &
                  " INNER JOIN TB_PEDIDO_PRODUTO PPD ON PPD.SQ_PEDIDO_PRODUTO = DFP.ID_PEDIDO_PRODUTO" &
                  " INNER JOIN TB_PEDIDO_PAGAMENTO PFP ON PFP.ID_PEDIDO = PPD.ID_PEDIDO" &
                  "	INNER JOIN VW_FORMAPAGAMENTO_EQUIPAMENTO FPE ON FPE.ID_FORMAPAGAMENTO = PFP.ID_FORMAPAGAMENTO" &
                 " WHERE DFC.SQ_DOCUMENTOFISCAL = " & iID_DOCUMENTOFISCAL
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      With oData.Rows(iCont)
        oACBrMonitor.ECF_Cupom_EfetuaPagamento(.Item("CD_FORMAPAGAMENTO_EQUIPAMENTO"), .Item("VL_PAGAMENTO"))
      End With
    Next

    If sMensagem01.Trim() <> "" Or sMensagem02.Trim() <> "" Then
      oACBrMonitor.ECF_Cupom_FecharCupom(sMensagem01, sMensagem02)
    Else
      oACBrMonitor.ECF_Cupom_FecharCupom()
    End If

    oACBrMonitor.ECF_Equipamento_Desativar()
    oACBrMonitor.Controle_Fechar()
    oACBrMonitor = Nothing

    FNC_Pausa()

    oACBrMonitor = New clsACBrMonitor
    oACBrMonitor.Controle_Abrir()
    oACBrMonitor.ECF_Cupom_NumeroCupom_Verificar()
    sNumeroCupom = oACBrMonitor.ECF_Cupom_NumeroCupom
    oACBrMonitor.Controle_Fechar()
    oACBrMonitor = Nothing

    If FNC_NVL(sNumeroCupom, "").Trim() = "" Then
      oACBrMonitor = New clsACBrMonitor
      oACBrMonitor.Controle_Abrir()
      oACBrMonitor.ECF_Cupom_NumeroCOO_Verificar()
      sNumeroCupom = oACBrMonitor.ECF_Cupom_NumeroCupom
      oACBrMonitor.Controle_Fechar()
    End If

    sSqlText = "UPDATE TB_DOCUMENTOFISCAL SET CD_DOCUMENTOFISCAL = " & FNC_QuotedStr(sNumeroCupom) & " WHERE SQ_DOCUMENTOFISCAL = " & iID_DOCUMENTOFISCAL
    DBExecutar(sSqlText)

    FNC_Mensagem("Cupom " & sNumeroCupom & " Gerado")

    bOk = True

    Return bOk
  End Function

  Public Function FormCadastroPedido(ByRef iSQ_PEDIDO As Integer,
                                     iID_EMPRESA As Integer,
                                     iID_PESSOA As Integer,
                                     iID_ENDERECO As Integer,
                                     iID_ENDERECO_RETIRADA As Integer,
                                     iID_PESSOATELEFONE As Integer,
                                     iID_PESSOA_MIDIASOCIAL_EMAIL As Integer,
                                     iID_OPT_TIPOPEDIDO As Integer,
                                     iID_PESSOA_VENDEDOR As Integer,
                                     iID_NATUREZAOPERACAO As Integer,
                                     iID_OPT_FRETE As Integer,
                                     iID_PESSOA_TRANSPORTADORA As Integer,
                                     iID_ENDERECO_TRANSPORTADORA As Integer,
                                     iID_PESSOATELEFONE_TRANSPORTADORA As Integer,
                                     iID_OPT_STATUS As Integer,
                                     iID_SEGMENTO As Integer,
                                     iID_CANALNEGOCIO As Integer,
                                     iID_TABELAPRECO As Integer,
                                     iID_PEDIDOVENDA_ORIGEM As Integer,
                                     iID_CONDICAOPAGAMENTO As Integer,
                                     iID_CONTAFINANCEIRA As Integer,
                                     iID_DOCUMENTOFISCAL_TIPO As Integer,
                                     sCD_PEDIDO As String,
                                     sCD_ORCAMENTO As String,
                                     dDH_PEDIDO As Date,
                                     dDH_PREVISAO_ENTREGA As Date,
                                     dDT_VALIDADE As Date,
                                     dVL_ACRESCIMO As Double,
                                     dVL_DESCONTO_ORCAMENTO As Double,
                                     dVL_DESCONTO As Double,
                                     dVL_FRETE As Double,
                                     dVL_OUTRAS_DESPESAS As Double,
                                     dVL_SEGURO As Double,
                                     dQT_PESO_BRUTO As Double,
                                     dQT_PESO_LIQUIDO As Double,
                                     dQT_VOLUMES As Double,
                                     dPC_ENTRADA As Double,
                                     sDS_ESPECIE As String,
                                     sDS_INFORMACOES_ADICIONAIS As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    '>> Cabeçalho da NFe
    sSqlText = DBMontar_SP("SP_PEDIDO_CAD", False, "@SQ_PEDIDO OUT",
                                                   "@ID_EMPRESA",
                                                   "@ID_PESSOA",
                                                   "@ID_ENDERECO",
                                                   "@ID_ENDERECO_RETIRADA",
                                                   "@ID_PESSOATELEFONE",
                                                   "@ID_PESSOA_MIDIASOCIAL_EMAIL",
                                                   "@ID_OPT_TIPOPEDIDO",
                                                   "@ID_PESSOA_VENDEDOR",
                                                   "@ID_NATUREZAOPERACAO",
                                                   "@ID_OPT_FRETE",
                                                   "@ID_PESSOA_TRANSPORTADORA",
                                                   "@ID_ENDERECO_TRANSPORTADORA",
                                                   "@ID_PESSOATELEFONE_TRANSPORTADORA",
                                                   "@ID_OPT_STATUS",
                                                   "@ID_SEGMENTO",
                                                   "@ID_CANALNEGOCIO",
                                                   "@ID_TABELAPRECO",
                                                   "@ID_PEDIDOVENDA_ORIGEM",
                                                   "@ID_CONDICAOPAGAMENTO",
                                                   "@ID_CONTAFINANCEIRA",
                                                   "@ID_DOCUMENTOFISCAL_TIPO",
                                                   "@CD_PEDIDO",
                                                   "@CD_ORCAMENTO",
                                                   "@DH_PEDIDO",
                                                   "@DH_PREVISAO_ENTREGA",
                                                   "@DT_VALIDADE",
                                                   "@VL_ACRESCIMO",
                                                   "@VL_DESCONTO_ORCAMENTO",
                                                   "@VL_DESCONTO",
                                                   "@VL_FRETE",
                                                   "@VL_OUTRAS_DESPESAS",
                                                   "@VL_SEGURO",
                                                   "@QT_PESO_BRUTO",
                                                   "@QT_PESO_LIQUIDO",
                                                   "@QT_VOLUMES",
                                                   "@PC_ENTRADA",
                                                   "@DS_ESPECIE",
                                                   "@DS_INFORMACOES_ADICIONAIS")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_PEDIDO", iSQ_PEDIDO, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                               DBParametro_Montar("ID_ENDERECO", FNC_NuloZero(iID_ENDERECO, False)),
                               DBParametro_Montar("ID_ENDERECO_RETIRADA", FNC_NuloZero(iID_ENDERECO_RETIRADA, False)),
                               DBParametro_Montar("ID_PESSOATELEFONE", FNC_NuloZero(iID_PESSOATELEFONE, False)),
                               DBParametro_Montar("ID_PESSOA_MIDIASOCIAL_EMAIL", FNC_NuloZero(iID_PESSOA_MIDIASOCIAL_EMAIL, False)),
                               DBParametro_Montar("ID_OPT_TIPOPEDIDO", iID_OPT_TIPOPEDIDO),
                               DBParametro_Montar("ID_PESSOA_VENDEDOR", FNC_NuloZero(iID_PESSOA_VENDEDOR, False)),
                               DBParametro_Montar("ID_NATUREZAOPERACAO", FNC_NuloZero(iID_NATUREZAOPERACAO, False)),
                               DBParametro_Montar("ID_OPT_FRETE", FNC_NuloZero(iID_OPT_FRETE, False)),
                               DBParametro_Montar("ID_PESSOA_TRANSPORTADORA", FNC_NuloZero(iID_PESSOA_TRANSPORTADORA, False)),
                               DBParametro_Montar("ID_ENDERECO_TRANSPORTADORA", FNC_NuloZero(iID_ENDERECO_TRANSPORTADORA, False)),
                               DBParametro_Montar("ID_PESSOATELEFONE_TRANSPORTADORA", FNC_NuloZero(iID_PESSOATELEFONE_TRANSPORTADORA, False)),
                               DBParametro_Montar("ID_OPT_STATUS", iID_OPT_STATUS),
                               DBParametro_Montar("ID_SEGMENTO", FNC_NuloZero(iID_SEGMENTO, False)),
                               DBParametro_Montar("ID_CANALNEGOCIO", FNC_NuloZero(iID_CANALNEGOCIO, False)),
                               DBParametro_Montar("ID_TABELAPRECO", FNC_NuloZero(iID_TABELAPRECO, False)),
                               DBParametro_Montar("ID_PEDIDOVENDA_ORIGEM", FNC_NuloZero(iID_PEDIDOVENDA_ORIGEM, False)),
                               DBParametro_Montar("ID_CONDICAOPAGAMENTO", FNC_NuloZero(iID_CONDICAOPAGAMENTO, False)),
                               DBParametro_Montar("ID_CONTAFINANCEIRA", FNC_NuloZero(iID_CONTAFINANCEIRA, False)),
                               DBParametro_Montar("ID_DOCUMENTOFISCAL_TIPO", FNC_NuloZero(iID_DOCUMENTOFISCAL_TIPO, False)),
                               DBParametro_Montar("CD_PEDIDO", FNC_NuloString(sCD_PEDIDO, False),, ParameterDirection.InputOutput),
                               DBParametro_Montar("CD_ORCAMENTO", FNC_NuloString(sCD_ORCAMENTO, False),, ParameterDirection.InputOutput),
                               DBParametro_Montar("DH_PEDIDO", FNC_NuloData(dDH_PEDIDO)),
                               DBParametro_Montar("DH_PREVISAO_ENTREGA", FNC_NuloData(dDH_PREVISAO_ENTREGA), SqlDbType.DateTime),
                               DBParametro_Montar("DT_VALIDADE", FNC_NuloData(dDT_VALIDADE), SqlDbType.Date),
                               DBParametro_Montar("VL_ACRESCIMO", dVL_ACRESCIMO),
                               DBParametro_Montar("VL_DESCONTO_ORCAMENTO", dVL_DESCONTO_ORCAMENTO),
                               DBParametro_Montar("VL_DESCONTO", dVL_DESCONTO),
                               DBParametro_Montar("VL_FRETE", dVL_FRETE),
                               DBParametro_Montar("VL_OUTRAS_DESPESAS", dVL_OUTRAS_DESPESAS),
                               DBParametro_Montar("VL_SEGURO", dVL_SEGURO),
                               DBParametro_Montar("QT_PESO_BRUTO", dQT_PESO_BRUTO),
                               DBParametro_Montar("QT_PESO_LIQUIDO", dQT_PESO_LIQUIDO),
                               DBParametro_Montar("QT_VOLUMES", dQT_VOLUMES),
                               DBParametro_Montar("PC_ENTRADA", dPC_ENTRADA),
                               DBParametro_Montar("DS_ESPECIE", FNC_NuloString(sDS_ESPECIE, False)),
                               DBParametro_Montar("DS_INFORMACOES_ADICIONAIS", FNC_NuloString(sDS_INFORMACOES_ADICIONAIS, False),,, 5000))
    If DBTeveRetorno() Then
      iSQ_PEDIDO = DBRetorno(1)
    End If

    Return bOk
  End Function

  Public Function FormCadastroPedidoProduto(ByRef iSQ_PEDIDO_PRODUTO As Integer,
                                            iID_PEDIDO As Integer,
                                            iID_PRODUTO_EMPRESA As Integer,
                                            iID_PRODUTO_LINHA As Integer,
                                            iID_UNIDADEMEDIDA As Integer,
                                            iID_OPT_STATUS As Integer,
                                            iID_CFOP As Integer,
                                            iID_CSOSN As Integer,
                                            iID_CST As Integer,
                                            iID_CST_IPI As Integer,
                                            iID_CST_PIS As Integer,
                                            iID_NCM As Integer,
                                            iID_TRANSACAOESTOQUE As Integer,
                                            iNR_ITEM As Integer,
                                            dDH_PREVISAO_ENTREGA As DateTime,
                                            dQT_ORCAMENTO As Double,
                                            dQT_PEDIDO As Double,
                                            dQT_LIBERADA As Double,
                                            dQT_FATURADA As Double,
                                            dVL_UNITARIO As Double,
                                            dVL_DESCONTO_ORCAMENTO As Double,
                                            dVL_DESCONTO As Double,
                                            dVL_SEGURO As Double,
                                            dVL_OUTRAS_DESPESAS As Double,
                                            dVL_ICMS As Double,
                                            dVL_SUBSTITUICAO_ICMS As Double,
                                            dVL_PROD_ICMS As Double,
                                            dVL_IPI As Double,
                                            dPC_COFINS As Double,
                                            dPC_ICMS As Double,
                                            dPC_PIS As Double,
                                            dPC_IPI As Double,
                                            dPC_BASE_ICMS As Double,
                                            dPC_BASE_SUBSTITUICAO_ICMS As Double,
                                            dPC_SUBSTITUICAO_ICMS As Double,
                                            dPC_MVA As Double,
                                            sDS_INFORMACOES_ADICIONAIS As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean = False

    sSqlText = DBMontar_SP("SP_PEDIDO_PRODUTO_CAD", False, "@SQ_PEDIDO_PRODUTO OUT",
                                                           "@ID_PEDIDO",
                                                           "@ID_PRODUTO_EMPRESA",
                                                           "@ID_PRODUTO_LINHA",
                                                           "@ID_UNIDADEMEDIDA",
                                                           "@ID_OPT_STATUS",
                                                           "@ID_CFOP",
                                                           "@ID_CSOSN",
                                                           "@ID_CST",
                                                           "@ID_CST_IPI",
                                                           "@ID_CST_PIS",
                                                           "@ID_NCM",
                                                           "@ID_TRANSACAOESTOQUE",
                                                           "@NR_ITEM",
                                                           "@DH_PREVISAO_ENTREGA",
                                                           "@QT_ORCAMENTO",
                                                           "@QT_PEDIDO",
                                                           "@QT_LIBERADA",
                                                           "@QT_FATURADA",
                                                           "@VL_UNITARIO",
                                                           "@VL_DESCONTO_ORCAMENTO",
                                                           "@VL_DESCONTO",
                                                           "@VL_SEGURO",
                                                           "@VL_OUTRAS_DESPESAS",
                                                           "@VL_ICMS",
                                                           "@VL_SUBSTITUICAO_ICMS",
                                                           "@VL_IPI",
                                                           "@PC_COFINS",
                                                           "@PC_ICMS",
                                                           "@PC_PIS",
                                                           "@PC_IPI",
                                                           "@PC_BASE_ICMS",
                                                           "@PC_BASE_SUBSTITUICAO_ICMS",
                                                           "@PC_SUBSTITUICAO_ICMS",
                                                           "@PC_MVA",
                                                           "@DS_INFORMACOES_ADICIONAIS")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_PEDIDO_PRODUTO", iSQ_PEDIDO_PRODUTO, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_PEDIDO", iID_PEDIDO),
                               DBParametro_Montar("ID_PRODUTO_EMPRESA", iID_PRODUTO_EMPRESA),
                               DBParametro_Montar("ID_PRODUTO_LINHA", FNC_NuloZero(iID_PRODUTO_LINHA, False)),
                               DBParametro_Montar("ID_UNIDADEMEDIDA", iID_UNIDADEMEDIDA),
                               DBParametro_Montar("ID_OPT_STATUS", iID_OPT_STATUS),
                               DBParametro_Montar("ID_CFOP", FNC_NuloZero(iID_CFOP, False)),
                               DBParametro_Montar("ID_CSOSN", FNC_NuloZero(iID_CSOSN, False)),
                               DBParametro_Montar("ID_CST", FNC_NuloZero(iID_CST, False)),
                               DBParametro_Montar("ID_CST_IPI", FNC_NuloZero(iID_CST_IPI, False)),
                               DBParametro_Montar("ID_CST_PIS", FNC_NuloZero(iID_CST_PIS, False)),
                               DBParametro_Montar("ID_NCM", FNC_NuloZero(iID_NCM, False)),
                               DBParametro_Montar("ID_TRANSACAOESTOQUE", FNC_NuloZero(iID_TRANSACAOESTOQUE, False)),
                               DBParametro_Montar("NR_ITEM", iNR_ITEM),
                               DBParametro_Montar("DH_PREVISAO_ENTREGA", FNC_NuloData(dDH_PREVISAO_ENTREGA)),
                               DBParametro_Montar("QT_ORCAMENTO", FNC_NuloZero(dQT_ORCAMENTO, False)),
                               DBParametro_Montar("QT_PEDIDO", dQT_PEDIDO),
                               DBParametro_Montar("QT_LIBERADA", dQT_LIBERADA),
                               DBParametro_Montar("QT_FATURADA", dQT_FATURADA),
                               DBParametro_Montar("VL_UNITARIO", dVL_UNITARIO),
                               DBParametro_Montar("VL_DESCONTO_ORCAMENTO", dVL_DESCONTO_ORCAMENTO),
                               DBParametro_Montar("VL_DESCONTO", dVL_DESCONTO),
                               DBParametro_Montar("VL_SEGURO", dVL_SEGURO),
                               DBParametro_Montar("VL_OUTRAS_DESPESAS", dVL_OUTRAS_DESPESAS),
                               DBParametro_Montar("VL_ICMS", dVL_ICMS),
                               DBParametro_Montar("VL_SUBSTITUICAO_ICMS", dVL_SUBSTITUICAO_ICMS),
                               DBParametro_Montar("VL_PROD_ICMS", dVL_PROD_ICMS),
                               DBParametro_Montar("VL_IPI", dVL_IPI),
                               DBParametro_Montar("PC_COFINS", dPC_COFINS),
                               DBParametro_Montar("PC_ICMS", dPC_ICMS),
                               DBParametro_Montar("PC_PIS", dPC_PIS),
                               DBParametro_Montar("PC_IPI", dPC_IPI),
                               DBParametro_Montar("PC_BASE_ICMS", dPC_BASE_ICMS),
                               DBParametro_Montar("PC_BASE_SUBSTITUICAO_ICMS", dPC_BASE_SUBSTITUICAO_ICMS),
                               DBParametro_Montar("PC_SUBSTITUICAO_ICMS", dPC_SUBSTITUICAO_ICMS),
                               DBParametro_Montar("PC_MVA", dPC_MVA),
                               DBParametro_Montar("DS_INFORMACOES_ADICIONAIS", FNC_NuloString(sDS_INFORMACOES_ADICIONAIS, False)))
    If DBTeveRetorno() Then
      iSQ_PEDIDO_PRODUTO = DBRetorno(1)
    End If

    Return bOk
  End Function

  Public Function FormCadastroPedidoProdutoNumeroSerie(ByRef iSQ_PEDIDO_PRODUTO_NSERIE As Integer,
                                                       iID_PEDIDO_PRODUTO As Integer,
                                                       iID_OPT_STATUS As Integer,
                                                       sCD_NUMEROSERIE As String) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_PEDIDO_PRODUTO_NSERIE_CAD", False, "@SQ_PEDIDO_PRODUTO_NSERIE OUT",
                                                                  "@ID_PEDIDO_PRODUTO",
                                                                  "@ID_OPT_STATUS",
                                                                  "@CD_NUMEROSERIE")

    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_PEDIDO_PRODUTO_NSERIE", 0,, ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_PEDIDO_PRODUTO", iID_PEDIDO_PRODUTO),
                               DBParametro_Montar("ID_OPT_STATUS", iID_OPT_STATUS),
                               DBParametro_Montar("CD_NUMEROSERIE", sCD_NUMEROSERIE))
    If DBTeveRetorno() Then
      iSQ_PEDIDO_PRODUTO_NSERIE = DBRetorno(1)
    End If

    Return bOk
  End Function

  Public Function FormCadastroPedidoPagamento(iID_PEDIDO As Integer,
                                              iID_FORMAPAGAMENTO As Integer,
                                              dVL_PAGAMENTO As Double) As Boolean
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_PEDIDO_PAGAMENTO_CAD", False, "@ID_PEDIDO",
                                                             "@ID_FORMAPAGAMENTO",
                                                             "@VL_PAGAMENTO")

    bOk = DBExecutar(sSqlText, DBParametro_Montar("ID_PEDIDO", iID_PEDIDO),
                               DBParametro_Montar("ID_FORMAPAGAMENTO", iID_FORMAPAGAMENTO),
                               DBParametro_Montar("VL_PAGAMENTO", dVL_PAGAMENTO, SqlDbType.Money))
    Return bOk
  End Function

  Public Sub FormCadastroPedidoNCMLabel(oLabel As Label, iID_NCM As Integer, sCD_NCM As String, sDS_NCM As String)
    oLabel.Tag = iID_NCM

    If iID_NCM = 0 Then
      oLabel.Text = ""
    Else
      oLabel.Text = sCD_NCM + " - " + sDS_NCM
    End If
  End Sub

  Public Function FormCadastroPedido_Faturar(ByRef iSQ_DOCUMENTOFISCAL As Integer,
                                             iID_PEDIDO As Integer,
                                             iID_PEDIDO_PAGAMENTO As Integer,
                                             iID_TRANSPORTE_PLACA_UF As Integer,
                                             iID_TRANSPORTE_PLACA_2_UF As Integer,
                                             eTipoDocumentoFiscal As enOpcoes,
                                             iID_DOCUMENTOFISCAL_SERIE As Integer,
                                             bIC_EXIBIR_PESSOA As Boolean,
                                             bIC_EXIBIR_ENDERECO As Boolean,
                                             sCD_DOCUMENTOFISCAL As String,
                                             sCD_TRANSPORTE_PLACA As String,
                                             sCD_TRANSPORTE_PLACA_2 As String,
                                             dDH_EMISSAO As Date,
                                             dDH_SAIDA As Date,
                                             dDH_CONTIGENCIA As Date,
                                             sDS_JUSTIFICATIVA_CONTIGENCIA As String,
                                             sDS_PATH_XML As String,
                                             bMovimentarEstoque As Boolean) As Boolean
    Dim oData_01 As New DataTable
    Dim oData_02 As New DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim iSQ_DOCUMENTOFISCAL_PRODUTO As Integer
    Dim bBaixaPorNumeroSerie As Boolean
    Dim bOk As Boolean = False

    sSqlText = "SELECT COUNT(*) FROM VW_PEDIDO_TOTAL WHERE SQ_PEDIDO = " & iID_PEDIDO & " AND QT_PRODUTO_LIBERADA - QT_PRODUTO_FATURADA > 0"

    If DBQuery_ValorUnico(sSqlText) = 0 Then
      FNC_Mensagem("O pedido está todo faturado")
    Else
      sSqlText = "SELECT * FROM VW_PEDIDO WHERE SQ_PEDIDO = " & iID_PEDIDO
      oData_01 = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData_01) Then
        With oData_01.Rows(0)
          bOk = FormCadastroDocumentoFiscal_Gravar(iSQ_DOCUMENTOFISCAL:=iSQ_DOCUMENTOFISCAL,
                                                 iID_NATUREZAOPERACAO:= .Item("ID_NATUREZAOPERACAO"),
                                                 iID_PESSOA:=FNC_NVL(.Item("ID_PESSOA"), 0),
                                                 iID_ENDERECO:=FNC_NVL(.Item("ID_ENDERECO"), 0),
                                                 iID_ENDERECO_RETIRADA:=FNC_NVL(.Item("ID_ENDERECO_RETIRADA"), 0),
                                                 iID_PESSOA_TELEFONE:=0,
                                                 iID_PESSOA_MIDIASOCIAL:=0,
                                                 iID_DOCUMENTOFISCAL_SERIE:=iID_DOCUMENTOFISCAL_SERIE,
                                                 iID_PESSOA_TRANSPORTADORA:=FNC_NVL(.Item("ID_PESSOA_TRANSPORTADORA"), 0),
                                                 iID_ENDERECO_TRANSPORTADORA:=FNC_NVL(.Item("ID_ENDERECO_TRANSPORTADORA"), 0),
                                                 iID_PESSOATELEFONE_TRANSPORTADORA:=FNC_NVL(.Item("ID_PESSOATELEFONE_TRANSPORTADORA"), 0),
                                                 iID_TRANSPORTE_PLACA_UF:=FNC_NVL(iID_TRANSPORTE_PLACA_UF, 0),
                                                 iID_TRANSPORTE_PLACA_2_UF:=FNC_NVL(iID_TRANSPORTE_PLACA_2_UF, 0),
                                                 iID_OPT_STATUS:=enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode(),
                                                 iID_DOCUMENTOFISCAL_TIPO:=eTipoDocumentoFiscal,
                                                 iID_OPT_FINALIDADE:=enOpcoes.Finalidade_NFe_NFeNormal.GetHashCode(),
                                                 iID_OPT_FRETE:=FNC_NVL(.Item("ID_OPT_FRETE"), 0),
                                                 iID_OPT_COMPRADORPRESENTE:=enOpcoes.NFe_CompradorPresenteOperacao_NaoAplica.GetHashCode(),
                                                 iID_OPT_NFE_FORMATOEMISSAO:=enOpcoes.NFe_FormaEmissaoNFe_Normal_EmissaoNormal.GetHashCode(),
                                                 iID_EQUIPAMENTO_PROCESSAMENTO_FISCAL:=iEMPRESA_ID_EQUIPAMENTO_PROCESSAMENTO_FISCAL,
                                                 iID_PEDIDO_PAGAMENTO:=iID_PEDIDO_PAGAMENTO,
                                                 bIC_EXIBIR_PESSOA:=bIC_EXIBIR_PESSOA,
                                                 bIC_EXIBIR_ENDERECO:=bIC_EXIBIR_ENDERECO,
                                                 sCD_CHAVE_NFE:=Nothing,
                                                 sCD_NF_MODELO:=Nothing,
                                                 sCD_NF_SERIE:=Nothing,
                                                 sCD_DOCUMENTOFISCAL:=sCD_DOCUMENTOFISCAL,
                                                 sCD_TRANSPORTE_PLACA:=sCD_TRANSPORTE_PLACA,
                                                 sCD_TRANSPORTE_PLACA_2:=sCD_TRANSPORTE_PLACA_2,
                                                 dDH_EMISSAO:=dDH_EMISSAO,
                                                 dDH_SAIDA:=dDH_SAIDA,
                                                 dDH_CONTIGENCIA:=dDH_CONTIGENCIA,
                                                 dQT_VOLUMES:= .Item("QT_VOLUMES"),
                                                 dQT_PESO_BRUTO:= .Item("QT_PESO_BRUTO"),
                                                 dQT_PESO_LIQUIDO:= .Item("QT_PESO_LIQUIDO"),
                                                 sDS_ESPECIE:=FNC_NVL(.Item("DS_ESPECIE"), ""),
                                                 sDS_MARCA:=Nothing,
                                                 sDS_JUSTIFICATIVA_CONTIGENCIA:=sDS_JUSTIFICATIVA_CONTIGENCIA,
                                                 sDS_INFORMACOES_ADICIONAIS:=FNC_NVL(.Item("DS_INFORMACOES_ADICIONAIS"), "").ToString().Replace(ControlChars.CrLf, "").Replace(vbLf, ""),
                                                 sDS_PATH_XML:=sDS_PATH_XML,
                                                 sCD_PROTOCOLO:="")

          If bMovimentarEstoque Then bMovimentarEstoque = (FNC_NVL(.Item("IC_MOVIMENTAESTOQUE"), "N") = "S")
        End With

        FormCadastroDocumentoFiscal_Produto_Pedido_Exluir(iID_PEDIDO)

        sSqlText = "SELECT * FROM VW_PEDIDO_PRODUTO WHERE ID_PEDIDO = " & iID_PEDIDO
        oData_01 = DBQuery(sSqlText)

        For iCont_01 = 0 To oData_01.Rows.Count - 1
          iSQ_DOCUMENTOFISCAL_PRODUTO = 0
          bBaixaPorNumeroSerie = False

          With oData_01.Rows(iCont_01)
            bOk = FormCadastroDocumentoFiscal_Produto_Gravar(iSQ_DOCUMENTOFISCAL_PRODUTO,
                                                           iSQ_DOCUMENTOFISCAL,
                                                           .Item("ID_PRODUTO_EMPRESA"),
                                                           FNC_NVL(.Item("ID_UNIDADEMEDIDA"), 0),
                                                           enOpcoes.StatusItemDocumentoFiscal_Incluido.GetHashCode(),
                                                           .Item("SQ_PEDIDO_PRODUTO"),
                                                           FNC_NVL(.Item("ID_CFOP"), 0),
                                                           FNC_NVL(.Item("ID_CSOSN"), 0),
                                                           FNC_NVL(.Item("ID_CST"), 0),
                                                           FNC_NVL(.Item("ID_CST_IPI"), 0),
                                                           FNC_NVL(.Item("ID_CST_PIS"), 0),
                                                           FNC_NVL(.Item("ID_NCM"), 0),
                                                           0,
                                                           FNC_NVL(.Item("ID_TRANSACAOESTOQUE"), 0),
                                                           "",
                                                           .Item("QT_PEDIDO"),
                                                           .Item("VL_UNITARIO"),
                                                           0,
                                                           .Item("VL_SEGURO"),
                                                           .Item("VL_DESCONTO"),
                                                           .Item("VL_OUTRAS_DESPESAS"),
                                                           0,
                                                           0,
                                                           0,
                                                           0,
                                                           0,
                                                           0,
                                                           0,
                                                           0,
                                                           0,
                                                           0,
                                                           .Item("PC_IPI"),
                                                           0,
                                                           0,
                                                           "N")

            sSqlText = "SELECT * FROM TB_PEDIDO_PRODUTO_NSERIE WHERE ID_PEDIDO_PRODUTO = " & .Item("SQ_PEDIDO_PRODUTO")
            oData_02 = DBQuery(sSqlText)

            For iCont_02 = 0 To oData_02.Rows.Count - 1
              bBaixaPorNumeroSerie = True
              FormCadastroDocumentoFiscal_Produto_NRSerie_Gravar(iSQ_DOCUMENTOFISCAL_PRODUTO,
                                                                 oData_02.Rows(iCont_02).Item("CD_NUMEROSERIE"))

              If bMovimentarEstoque Then
                FormEstoqueLancamento_Gravar(0,
                                         .Item("ID_PRODUTO_EMPRESA"),
                                         Nothing,
                                         .Item("ID_ESTOQUE_LOCALIZACAO_DEBITO"),
                                         .Item("ID_TRANSACAOESTOQUE"),
                                         Nothing,
                                         iSQ_DOCUMENTOFISCAL_PRODUTO,
                                         Nothing,
                                         oData_02.Rows(iCont_02).Item("CD_NUMEROSERIE"),
                                         Now(),
                                         1,
                                        .Item("VL_UNITARIO"),
                                         Nothing)
              End If
            Next

            If Not bBaixaPorNumeroSerie And bMovimentarEstoque Then
              FormEstoqueLancamento_Gravar(0,
                                         .Item("ID_PRODUTO_EMPRESA"),
                                         Nothing,
                                         .Item("ID_ESTOQUE_LOCALIZACAO_DEBITO"),
                                         .Item("ID_TRANSACAOESTOQUE"),
                                         Nothing,
                                         iSQ_DOCUMENTOFISCAL_PRODUTO,
                                         Nothing,
                                         Nothing,
                                         Now(),
                                        .Item("QT_PEDIDO"),
                                        .Item("VL_UNITARIO"),
                                         Nothing)
            End If
          End With
        Next
      End If
    End If

    Return bOk
  End Function

  Public Function FormSEGUsuario_Validacao() As Boolean
    Dim bOk As Boolean = False

    Try
      Dim oFormSEGUsuario_Validacao As New frmSEGUsuario_Validacao

      FNC_AbriTela(oFormSEGUsuario_Validacao, , True, True)

      bOk = oFormSEGUsuario_Validacao.Autorizado

      oFormSEGUsuario_Validacao.Dispose()
      oFormSEGUsuario_Validacao = Nothing
    Catch ex As Exception
    End Try

    Return bOk
  End Function

  Public Function FormCadastroPedido_GerarMDFe(ByRef iSQ_DOCUMENTOFISCAL As Integer,
                                               iSQ_PEDIDO As Integer,
                                               iID_PEDIDO_PAGAMENTO As Integer,
                                               iID_DOCUMENTOFISCAL_TIPO As Integer,
                                               iID_DOCUMENTOFISCAL_SERIE As Integer,
                                               bIC_EXIBIR_PESSOA As Boolean,
                                               bIC_EXIBIR_ENDERECO As Boolean,
                                               sCD_SERVICO_MODELO As String,
                                               bImprimirDanfe As Boolean) As Boolean
    Try
      FormCadastroPedido_Faturar(iSQ_DOCUMENTOFISCAL:=iSQ_DOCUMENTOFISCAL,
                                 iID_PEDIDO:=iSQ_PEDIDO,
                                 iID_PEDIDO_PAGAMENTO:=iID_PEDIDO_PAGAMENTO,
                                 iID_TRANSPORTE_PLACA_UF:=0,
                                 iID_TRANSPORTE_PLACA_2_UF:=0,
                                 eTipoDocumentoFiscal:=iID_DOCUMENTOFISCAL_TIPO,
                                 iID_DOCUMENTOFISCAL_SERIE:=iID_DOCUMENTOFISCAL_SERIE,
                                 bIC_EXIBIR_PESSOA:=bIC_EXIBIR_PESSOA,
                                 bIC_EXIBIR_ENDERECO:=bIC_EXIBIR_ENDERECO,
                                 sCD_DOCUMENTOFISCAL:=Nothing,
                                 sCD_TRANSPORTE_PLACA:=Nothing,
                                 sCD_TRANSPORTE_PLACA_2:=Nothing,
                                 dDH_EMISSAO:=Now,
                                 dDH_SAIDA:=Now,
                                 dDH_CONTIGENCIA:=Nothing,
                                 sDS_JUSTIFICATIVA_CONTIGENCIA:=Nothing,
                                 sDS_PATH_XML:=Nothing,
                                 bMovimentarEstoque:=True)
      If iSQ_DOCUMENTOFISCAL > 0 Then
        Dim sDS_PATH_XML As String = ""

        If FNC_Fiscal_DocumentoFiscal_Transmitir(iSQ_DOCUMENTOFISCAL, Val(sCD_SERVICO_MODELO), sDS_PATH_XML, True, bImprimirDanfe) Then
          Return True
        Else
          Dim oForm_CadastroDocumentoFiscal As New frmCadastroDocumentoFiscal

          oForm_CadastroDocumentoFiscal.iSQ_DOCUMENTOFISCAL = iSQ_DOCUMENTOFISCAL
          FNC_AbriTela(oForm_CadastroDocumentoFiscal,, True, True)

          oForm_CadastroDocumentoFiscal = Nothing
        End If
      End If
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
      Return False
    End Try
  End Function

  Public Sub FormCadastroPaciente_HistoricoCompras_FormatarGrid(oGrid As UltraWinGrid.UltraGrid, oDB As UltraWinDataSource.UltraDataSource)
    objGrid_Inicializar(oGrid, , oDB, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(oGrid, "SQ_PEDIDO_PRODUTO", 0)
    objGrid_Coluna_Add(oGrid, "D/H da Compra", 120, , , ColumnStyle.DateTime)
    objGrid_Coluna_Add(oGrid, "Cód. da Compra", 100)
    objGrid_Coluna_Add(oGrid, "Produto", 200)
    objGrid_Coluna_Add(oGrid, "Qtde. Compra", 0)
    objGrid_Coluna_Add(oGrid, "Vlr. Unitário", 100, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(oGrid, "Vlr. Total", 100, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(oGrid, "Vlr. Desconto", 100, , , , , const_Formato_Valor)
  End Sub

  Public Sub FormCadastroPaciente_HistoricoConsulta_FormatarGrid(oGrid As UltraWinGrid.UltraGrid, oDB As UltraWinDataSource.UltraDataSource)
    objGrid_Inicializar(oGrid, , oDB, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(oGrid, "ID", 0)
    objGrid_Coluna_Add(oGrid, "Código", 80)
    objGrid_Coluna_Add(oGrid, "Data", 70, , , ColumnStyle.Date)
    objGrid_Coluna_Add(oGrid, "Profissional", 400)
    objGrid_Coluna_Add(oGrid, "Tipo", 200,,, ColumnStyle.FormattedText)
    objGrid_Coluna_Add(oGrid, "Status", 200,,, ColumnStyle.FormattedText)
  End Sub

  Public Sub FormCadastroOrdemServico_GerarFinanceiro(iSQ_ORDEMSERVICO As Integer)
    Dim sSqlText As String
    Dim bJaExisteLancamento As Boolean = False

    sSqlText = "Select COUNT(*) FROM TB_MOVFINANCEIRA" &
               " WHERE ID_ORDEMSERVICO = " & iSQ_ORDEMSERVICO &
                 " And ID_OPT_STATUS <> " & enOpcoes.StatusMovimentacaoFinanceira_Cancelada.GetHashCode

    If DBQuery_ValorUnico(sSqlText) > 0 Then
      bJaExisteLancamento = True

      If Not FNC_Perguntar("Já existe lançamento financeiro lançado para essa ordem de serviço. Deseja realizar outro lançamento para essa ordem de serviço?") Then Exit Sub
    End If

    Dim oForm As New frmLancaContasReceberPagar

    oForm.iID_ORDEMSERVICO = iSQ_ORDEMSERVICO
    oForm.bNovoLancamento = bJaExisteLancamento
    FNC_AbriTela(oForm)
  End Sub

  Public Sub FormCadastroPaciente_HistoricoConsulta_CarregarGrid(oGrid As UltraWinGrid.UltraGrid, iID_PESSOA As Integer)
    Dim sSqlText As String

    sSqlText = "SELECT ID," &
                      "CD," &
                      "DH," &
                      "NO_PESSOA," &
                      "NO_TIPO_CONSULTA," &
                      "NO_OPT_STATUS" &
               " FROM VW_HISTORICO_CONSULTA" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " And ID_PESSOA = " & iID_PESSOA &
               " ORDER BY DH DESC," &
                         "NO_PESSOA"
    objGrid_Carregar(oGrid, sSqlText, New Integer() {const_GridListagemHistoricoConsultas_ID,
                                                     const_GridListagemHistoricoConsultas_Codigo,
                                                     const_GridListagemHistoricoConsultas_Data,
                                                     const_GridListagemHistoricoConsultas_Profissional,
                                                     const_GridListagemHistoricoConsultas_Tipo,
                                                     const_GridListagemHistoricoConsultas_Status}, True)
  End Sub

  Public Sub FormCadastroPaciente_HistoricoFamiliar_FormatarGrid(oGrid As UltraWinGrid.UltraGrid, oDB As UltraWinDataSource.UltraDataSource)
    objGrid_Inicializar(oGrid, AllowAddNew.FixedAddRowOnTop, oDB, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(oGrid, "Tipo de Parentesco", 150, , True, , FNC_CarregarLista(enTipoCadastro.TipoParentesco))
    objGrid_Coluna_Add(oGrid, "Nome", 400, , True)
    objGrid_Coluna_Add(oGrid, "CID-10/Diagnóstico", 400, , True, , FNC_CarregarLista(enTipoCadastro.CID))
  End Sub

  Public Sub FormCadastroPaciente_HistoricoFamiliar_GravarGrid(oGrid As UltraWinGrid.UltraGrid, iID_PESSOA As Integer)
    Dim sSqlText As String
    Dim iCont As Integer

    For iCont = 0 To oGrid.Rows.Count - 1
      With oGrid.Rows(iCont)
        sSqlText = DBMontar_SP("SP_PESSOA_PATOLOGIAPARENTE_CAD", False, "@ID_PESSOA",
                                                                        "@ID_TIPO_PARENTESCO",
                                                                        "@NO_PARENTE",
                                                                        "@ID_CID")
        DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                             DBParametro_Montar("ID_TIPO_PARENTESCO", .Cells(const_GridListagemHistoricoFamiliar_TipoParentesco).Value),
                             DBParametro_Montar("NO_PARENTE", .Cells(const_GridListagemHistoricoFamiliar_Nome).Value),
                             DBParametro_Montar("ID_CID", .Cells(const_GridListagemHistoricoFamiliar_CID10_Diagnostico).Value))
      End With
    Next
  End Sub

  Public Sub FormCadastroPaciente_HistoricoFamiliar_Gravar(iID_PESSOA As Integer,
                                                           iID_TIPO_PARENTESCO As Integer,
                                                           sNO_PARENTE As String,
                                                           iID_CID As Integer)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_PATOLOGIAPARENTE_CAD", False, "@ID_PESSOA",
                                                                    "@ID_TIPO_PARENTESCO",
                                                                    "@NO_PARENTE",
                                                                    "@ID_CID")
    DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                         DBParametro_Montar("ID_TIPO_PARENTESCO", iID_TIPO_PARENTESCO),
                         DBParametro_Montar("NO_PARENTE", sNO_PARENTE),
                         DBParametro_Montar("ID_CID", iID_CID))
  End Sub

  Public Sub FormCadastroPaciente_HistoricoFamiliar_Excluir(iID_PESSOA As Integer,
                                                            iID_TIPO_PARENTESCO As Integer,
                                                            sNO_PARENTE As String,
                                                            iID_CID As Integer)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_PATOLOGIAPARENTE_DEL", False, "@ID_PESSOA",
                                                                    "@ID_TIPO_PARENTESCO",
                                                                    "@NO_PARENTE",
                                                                    "@ID_CID")
    DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                         DBParametro_Montar("ID_TIPO_PARENTESCO", iID_TIPO_PARENTESCO),
                         DBParametro_Montar("NO_PARENTE", sNO_PARENTE),
                         DBParametro_Montar("ID_CID", iID_CID))
  End Sub

  Public Sub FormCadastroPaciente_HistoricoFamiliar_CarregarGrid(oGrid As UltraWinGrid.UltraGrid, iID_PESSOA As Integer)
    Dim sSqlText As String

    sSqlText = "Select PPP.ID_TIPO_PARENTESCO," &
                      "PPP.NO_PARENTE," &
                      "CID.SQ_CID" &
               " FROM TB_PESSOA_PATOLOGIAPARENTE PPP" &
                " INNER JOIN TB_TIPO_PARENTESCO TPP On PPP.ID_TIPO_PARENTESCO = TPP.SQ_TIPO_PARENTESCO" &
                " INNER JOIN TB_CID CID On PPP.ID_CID = CID.SQ_CID" &
               " WHERE PPP.ID_PESSOA = " & iID_PESSOA &
               " ORDER BY TPP.NO_TIPO_PARENTESCO," &
                         "PPP.NO_PARENTE," &
                         "CID.SQ_CID"
    objGrid_Carregar(oGrid, sSqlText, New Integer() {const_GridListagemHistoricoFamiliar_TipoParentesco,
                                                     const_GridListagemHistoricoFamiliar_Nome,
                                                     const_GridListagemHistoricoFamiliar_CID10_Diagnostico}, True)
  End Sub

  Public Sub FormCadastroPaciente_Patologia_FormatarGrid(oGrid As UltraWinGrid.UltraGrid, oDB As UltraWinDataSource.UltraDataSource)
    objGrid_Inicializar(oGrid, , oDB, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , False)
    objGrid_Coluna_Add(oGrid, "Data", 70)
    objGrid_Coluna_Add(oGrid, "Diagnóstico", 400)
  End Sub

  Public Sub FormCadastroPaciente_Patologia_CarregarGrid(oGrid As UltraWinGrid.UltraGrid, iID_PESSOA As Integer)
    Dim sSqlText As String

    sSqlText = "Select AT.DH_ATENDIMENTO, CD.DS_CID2" &
               " FROM TB_ATENDIMENTO AT" &
                " INNER JOIN TB_ATENDIMENTO_DIAGNOSTICO TD On TD.ID_ATENDIMENTO = AT.SQ_ATENDIMENTO" &
                " INNER JOIN VW_CID CD On CD.SQ_CID = TD.ID_CID" &
               " WHERE AT.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " And AT.ID_PESSOA = " & iID_PESSOA &
               " ORDER BY AT.DH_ATENDIMENTO, CD.DS_CID2"
    objGrid_Carregar(oGrid, sSqlText, New Integer() {const_GridListagemPatologia_Data,
                                                     const_GridListagemPatologia_Diagnostico}, True)
  End Sub

  Public Function FormCadastroPaciente_Patologia_CarregarGrid(iID_OPT_TIPO_INDICACAO As Integer, sNO_INDICACAO As String) As Integer
    Dim sSqlText As String
    Dim iSQ_INDICACAO As Integer

    sSqlText = DBMontar_SP("SP_INDICACAO_CAD", False, "@SQ_INDICACAO OUT",
                                                      "@ID_OPT_TIPO_INDICACAO",
                                                      "@NO_INDICACAO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_INDICACAO", 0, , ParameterDirection.InputOutput),
                         DBParametro_Montar("ID_OPT_TIPO_INDICACAO", iID_OPT_TIPO_INDICACAO),
                         DBParametro_Montar("NO_INDICACAO", sNO_INDICACAO))
    If DBTeveRetorno() Then
      iSQ_INDICACAO = DBRetorno(1)
    End If

    Return iSQ_INDICACAO
  End Function

  Public Sub FormRelatorioPaciente(iID_PACIENTE As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String = ""
      Dim sFiltro As String = "-"

      sSqlText = "SELECT PESSO.*" &
                 " FROM VW_PESSOA_GERAL PESSO" &
                 " WHERE PESSO.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " And PESSO.IC_PACIENTE = 'S'" &
                   " AND PESSO.SQ_PESSOA = " & iID_PACIENTE &
                 " ORDER BY PESSO.NO_TABELAPRECO"
      oData = DBQuery(sSqlText)

      With oForm
        If oData.Rows.Count > 0 Then
          sFiltro = "Paciente: " & oData.Rows(0).Item("NO_PESSOA")
        End If

        .rpvGeral.LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("RPT_Cadastro_Paciente.rdl")
        .TipoRelatorio = frmReportViewer.enTipoRelatorio.CadastroPaciente
        .rpvGeral.LocalReport.EnableExternalImages = True

        oForm.sFiltro = sFiltro
        oForm.Formatar()

        .rpvGeral.LocalReport.DataSources.Clear()
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("datGeral", oData))
        .rpvGeral.RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioPaciente - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioOrdemServico(iSQ_ORDEMSERVICO As Integer, Optional bImpressaoCliente As Boolean = False)
    Try
      Dim oForm As New frmReportViewer
      Dim oData_OS As DataTable
      Dim oData_OS_HISTORICO As DataTable
      Dim oData_OS_PRODUTOSERVICO As DataTable
      Dim oData_OS_PRODUTO As DataTable
      Dim oData_OS_HISTORICO_STATUS As DataTable
      Dim sSqlText As String = ""
      Dim sFiltro As String = "-"

      sSqlText = "SELECT OSERV.*" &
                 " FROM VW_ORDEMSERVICO OSERV" &
                 " WHERE OSERV.SQ_ORDEMSERVICO = " & iSQ_ORDEMSERVICO
      oData_OS = DBQuery(sSqlText)

      sSqlText = "SELECT * FROM VW_ORDEMSERVICO_HISTORICO WHERE ID_ORDEMSERVICO = " & iSQ_ORDEMSERVICO & " ORDER BY DH_HISTORICO"
      oData_OS_HISTORICO = DBQuery(sSqlText)

      sSqlText = "SELECT * FROM VW_ORDEMSERVICO_PRODUTOSERVICO" &
                 " WHERE ID_ORDEMSERVICO = " & iSQ_ORDEMSERVICO &
                 " ORDER BY TP_PRODUTO_SERVICO, NO_PRODUTO, NO_SERVICO"
      oData_OS_PRODUTOSERVICO = DBQuery(sSqlText)

      sSqlText = "SELECT * FROM VW_ORDEMSERVICO_PRODUTO WHERE ID_ORDEMSERVICO = " & iSQ_ORDEMSERVICO & " ORDER BY DS_PRODUTO"
      oData_OS_PRODUTO = DBQuery(sSqlText)

      sSqlText = "SELECT OSP.SQ_ORDEMSERVICO_PRODUTO," &
                        "OSP.DS_PRODUTO," &
                        "OSP.CD_NUMEROSERIE," &
                        "OHS.NO_OPT_TIPO_HISTORICO," &
                        "ISNULL(OHS.DS_HISTORICO, OHS.NO_PRODUTO_SERVICO) DS_HISTORICO," &
                        "ISNULL(OSP.NO_PESSOA_RESPONSAVEL, OSP.NO_PESSOA_TERCEIRO) NO_PESSOA," &
                        "DH_HISTORICO" &
                 " FROM VW_ORDEMSERVICO_HISTORICO_STATUS OHS" &
                  " LEFT JOIN VW_ORDEMSERVICO_PRODUTO OSP ON OSP.SQ_ORDEMSERVICO_PRODUTO = OHS.ID_ORDEMSERVICO_PRODUTO" &
                 " WHERE OHS.ID_ORDEMSERVICO = " & iSQ_ORDEMSERVICO &
                 " ORDER BY OSP.DS_PRODUTO, OSP.CD_NUMEROSERIE"
      oData_OS_HISTORICO_STATUS = DBQuery(sSqlText)

      With oForm
        If oData_OS.Rows.Count > 0 Then
          sFiltro = "Orderm de Serviço: " & oData_OS.Rows(0).Item("CD_ORDEMSERVICO")
        End If

        .rpvGeral.LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("RPT_Cadastro_OrdemServico.rdl")
        .TipoRelatorio = frmReportViewer.enTipoRelatorio.CadastroPaciente
        .rpvGeral.LocalReport.EnableExternalImages = True

        oForm.sFiltro = sFiltro
        oForm.Formatar()

        If bImpressaoCliente Then
          .rpvGeral.LocalReport.SetParameters(New ReportParameter("ParaCliente", "S"))
        End If

        .rpvGeral.LocalReport.DataSources.Clear()
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("OS", oData_OS))
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("OS_HISTORICO", oData_OS_HISTORICO))
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("OS_PRODUTOSERVICO", oData_OS_PRODUTOSERVICO))
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("OS_PRODUTO", oData_OS_PRODUTO))
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("OS_HISTORICO_STATUS", oData_OS_HISTORICO_STATUS))
        .rpvGeral.RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioPaciente - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioOrdemServico_Contrato(iSQ_ORDEMSERVICO As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData_OS As DataTable
      Dim oData_OS_PRODUTOSERVICO As DataTable
      Dim oData_OS_PRODUTO As DataTable
      Dim sSqlText As String = ""
      Dim sFiltro As String = "-"

      sSqlText = "SELECT OS.*," &
                        "PS.DS_ENDERECO_RESIDENCIAL," &
                        "PS.CD_NUMERO_RESIDENCIAL," &
                        "PS.IC_WHATSAPP_RESIDENCIAL," &
                        "PS.CD_NUMERO_CELULAR," &
                        "PS.IC_WHATSAPP_CELULAR," &
                        "dbo.FC_EMPRESA_OPCAO_CLAUSULASCTR(OS.ID_EMPRESA, ID_OPT_TIPO_ORDEMSERVICO) TX_CLAUSULASCTR" &
                 " FROM VW_ORDEMSERVICO OS" &
                  " INNER JOIN VW_PESSOA PS ON PS.SQ_PESSOA = OS.ID_PESSOA" &
                 " WHERE OS.SQ_ORDEMSERVICO = " & iSQ_ORDEMSERVICO
      oData_OS = DBQuery(sSqlText)

      sSqlText = "SELECT *" &
                 " FROM VW_ORDEMSERVICO_PRODUTOSERVICO" &
                 " WHERE ID_ORDEMSERVICO = " & iSQ_ORDEMSERVICO &
                   " AND ID_OPT_TIPO_HISTORICO IN (" & enOpcoes.TipoHistoricoOrdemServico_InclusaoPecaProdutoGerarOrcamento.GetHashCode & ", " _
                                                     & enOpcoes.TipoHistoricoOrdemServico_InclusaoServicoGerarOrcamento.GetHashCode & ", " _
                                                     & enOpcoes.TipoHistoricoOrdemServico_InclusaoPecaProduto.GetHashCode & ", " _
                                                     & enOpcoes.TipoHistoricoOrdemServico_InclusaoServico.GetHashCode & ")" &
                 " ORDER BY TP_UTILIZACAO DESC, TP_PRODUTO_SERVICO, NO_PRODUTO, NO_SERVICO"
      oData_OS_PRODUTOSERVICO = DBQuery(sSqlText)

      sSqlText = "SELECT *" &
                 " FROM VW_ORDEMSERVICO_PRODUTO" &
                 " WHERE ID_ORDEMSERVICO = " & iSQ_ORDEMSERVICO
      oData_OS_PRODUTO = DBQuery(sSqlText)

      With oForm
        If oData_OS.Rows.Count > 0 Then
          sFiltro = "Paciente: " & oData_OS.Rows(0).Item("NO_PESSOA")
        End If

        .rpvGeral.LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("RPT_Cadastro_OrdemServico_Contrato.rdl")
        .TipoRelatorio = frmReportViewer.enTipoRelatorio.CadastroPaciente
        .rpvGeral.LocalReport.EnableExternalImages = True

        oForm.sFiltro = sFiltro
        oForm.Formatar(False)

        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Usuario_CPF", sUSUARIO_CD_CPF_CNPJ))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Usuario", sNO_USUARIO))
        .rpvGeral.LocalReport.DataSources.Clear()
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("OS", oData_OS))
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("OS_PRODUTOSERVICO", oData_OS_PRODUTOSERVICO))
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("OS_PRODUTO", oData_OS_PRODUTO))
        .rpvGeral.RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioPaciente - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioGuiaConsulta(iSQ_CLINICA_VENDA As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT CVDPC.SQ_CLINICA_VENDA_PROCEDIMENTO," &
                        "IIF(CVDPC.ID_CLINICA_VENDA_DEVOLUCAO IS NULL, '', 'ITEM DEVOLVIDO') ITEM_DEVOLVIDO," &
                        "EMPRE.NO_PESSOA NO_EMPRESA," &
                        "ENDE2.DS_ENDERECO DS_ENDERECO_PROFISSIONAL," &
                        "ENDER.DS_LOGRADOURO_COMPLETO DS_ENDERECO," &
                        "CLVND.CD_CLINICA_VENDA," &
                        "VL_ORIGINAL," &
                        "PESSO.CD_PESSOA,AGEND.CD_AGENDAMENTO," &
                        "AGEND.DH_AGENDAMENTO,PESSO.NO_PESSOA," &
                        "PESSO_ATEND.NO_PESSOA NO_PESSOA_ATENDENTE," &
                        "ISNULL(CLVND.DS_SOLICITANTE, PESSO_SOLIC.NO_PESSOA) DS_SOLICITANTE," &
                        "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "PROCE.NO_PROCEDIMENTO," &
                        "OPCAO_TPPCD.NO_OPCAO NO_OPT_TIPOPROCEDIMENTO," &
                        "CVDPC.VL_PROCEDIMENTO," &
                        "CVDPC.VL_DESCONTO," &
                        "OPCAO_TPEXM.NO_OPCAO NO_OPT_TIPOEXAME," &
                        "CONVE.NO_CONVENIO,PESSO.CD_CPF_CNPJ," &
                        "PESSO.SQ_PESSOA," &
                        "PTLPR.CD_NUMERO CD_TELEFONE," &
                        "ISNULL(MVFNC.VL_DESCONTO, 0) VL_DESCONTO_MOVFINANCEIRA" &
                 " FROM TB_CLINICA_VENDA CLVND" &
                  " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVDPC ON CVDPC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                  " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CVDPC.ID_PESSOA_PROFISSIONAL" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVDPC.ID_PROCEDIMENTO" &
                                                  " AND PROCE.ID_OPT_TIPOPROCEDIMENTO = " & enOpcoes.TipoProcedimento_Procedimento &
                   " LEFT JOIN TB_AGENDAMENTO AGEND ON (AGEND.SQ_AGENDAMENTO = CVDPC.ID_AGENDAMENTO OR " &
                                                      " AGEND.ID_CLINICA_VENDA_PROCEDIMENTO = CVDPC.SQ_CLINICA_VENDA_PROCEDIMENTO)" &
                   " LEFT JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = AGEND.ID_EMPRESA" &
                   " LEFT JOIN TB_PESSOA PESSO_SOLIC ON PESSO_SOLIC.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                   " LEFT JOIN TB_OPCAO OPCAO_TPPCD ON OPCAO_TPPCD.SQ_OPCAO = PROCE.ID_OPT_TIPOPROCEDIMENTO" &
                   " LEFT JOIN TB_OPCAO OPCAO_TPEXM ON OPCAO_TPEXM.SQ_OPCAO = PROCE.ID_OPT_TIPOEXAME" &
                   " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER ON ENDER.ID_PESSOA = CLVND.ID_PESSOA" &
                                                       " AND ENDER.ID_TIPO_ENDERECO = " & enTipoEndereco.Residencial.GetHashCode() &
                   " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDE2 ON ENDE2.ID_PESSOA = AGEND.ID_EMPRESA" &
                                                       " AND ENDE2.ID_TIPO_ENDERECO = " & enTipoEndereco.Comercial.GetHashCode() &
                   " LEFT JOIN TB_PESSOA PESSO_ATEND ON PESSO_ATEND.SQ_PESSOA = CLVND.ID_PESSOA_ATENDENTE" &
                   " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = ISNULL(AGEND.ID_PESSOA, CLVND.ID_PESSOA)" &
                   " LEFT JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = CLVND.ID_CONVENIO" &
                   " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO PTLPR ON PTLPR.ID_PESSOA = PESSO.SQ_PESSOA" &
                   " LEFT JOIN (SELECT ID_CLINICA_VENDA," &
                                      "SUM(VL_ORIGINAL) VL_ORIGINAL," &
                                      "SUM(VL_DESCONTO) VL_DESCONTO" &
                               " FROM TB_MOVFINANCEIRA" &
                               " WHERE ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                               " GROUP BY ID_CLINICA_VENDA) MVFNC ON MVFNC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                 " WHERE CLVND.SQ_CLINICA_VENDA = " & iSQ_CLINICA_VENDA.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\GuiaConsultaMedica.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.GuiaConsulta
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("frmRelatorioGuiaConsulta - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioMovimentacaoFinanceiraPrestacaoContas(iID_CONTA_FINANCEIRA As Integer,
                                                                sNO_CONTA_FINANCEIRA As String,
                                                                dDataInicial As Date,
                                                                dDataFinal As Date)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim oDadosConvenio As DataTable
      Dim oDadosPlanoContas As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT IIF(MVFNC.ID_CLINICA_VENDA_DEVOLUCAO IS NULL, MVFNC.ID_OPT_TIPOMOVFINANCEIRA, 46.5) ID_OPT_TIPOMOVFINANCEIRA," &
                        "IIF(MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode() & ", PESSO.NO_PESSOA, TPDOC.NO_TIPO_DOCUMENTO) NO_TIPO," &
                        "SUM(MVFNP.VL_PARCELA) VL_PARCELA," &
                        "SUM((MVFNP.VL_PARCELA - ISNULL(MVFNP.VL_DESCONTO, 0) + ISNULL(DEVOL.VL_DEVOLUCAO, 0) + ISNULL(MVFNP.VL_DESCONTO_PAGTO, 0)) * IIF(MVFNC.ID_OPT_TIPOMOVFINANCEIRA=" & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode() & ",-1,1)) VL_PARCELA_REAL," &
                        "SUM(IIF(TPDOC.SQ_TIPO_DOCUMENTO = " & const_TipoDocumento_Dinheiro & " OR MVFNC.ID_OPT_TIPOMOVFINANCEIRA=" & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode() & ", (MVFNP.VL_PARCELA - ISNULL(MVFNP.VL_DESCONTO, 0) - ISNULL(MVFNP.VL_DESCONTO_PAGTO, 0)) * IIF(MVFNC.ID_OPT_TIPOMOVFINANCEIRA=" & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode() & ",-1,1),0)) VL_DINHEIRO_REAL," &
                        "SUM(ISNULL(MVFNP.VL_DESCONTO, 0) + ISNULL(MVFNP.VL_DESCONTO_PAGTO, 0)) VL_DESCONTO," &
                        "COUNT(*) QTDE" &
                 " FROM TB_MOVFINANCEIRA MVFNC" &
                  " INNER JOIN TB_MOVFINANCEIRAPARCELA MVFNP ON MVFNP.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                  " INNER JOIN TB_TIPO_DOCUMENTO TPDOC ON TPDOC.SQ_TIPO_DOCUMENTO = MVFNP.ID_TIPO_DOCUMENTO" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = MVFNC.ID_PESSOA" &
                   " LEFT JOIN TB_CONTAFINANCEIRA	CTFIN ON CTFIN.SQ_CONTAFINANCEIRA = MVFNC.ID_CONTAFINANCEIRA_DEBITO" &
                   " LEFT JOIN (SELECT ID_MOVFINANCEIRAPARCELA," &
                                      "SUM(VL_PAGAMENTO) VL_DEVOLUCAO" &
                               " FROM TB_MOVFINANCEIRAPAGTO PIMF" &
                                " INNER JOIN TB_PAGAMENTO PAGT ON PAGT.SQ_PAGAMENTO = PIMF.ID_PAGAMENTO" &
                                                            " AND PAGT.DT_EXCLUSAO IS NULL" &
                                                            " AND PAGT.ID_OPT_TIPOPAGAMENTO = " & enOpcoes.TipoPagamento_DevolucaoCliente.GetHashCode() &
                               " GROUP BY ID_MOVFINANCEIRAPARCELA) DEVOL ON DEVOL.ID_MOVFINANCEIRAPARCELA = MVFNP.SQ_MOVFINANCEIRAPARCELA" &
                 " WHERE CAST(ISNULL(MVFNP.DT_QUITACAO, MVFNC.DT_LANCAMENTO) AS DATE) >= " & FNC_QuotedStr(dDataInicial) &
                   " AND CAST(ISNULL(MVFNP.DT_QUITACAO, MVFNC.DT_LANCAMENTO) AS DATE) <= " & FNC_QuotedStr(dDataFinal) &
                   " AND ((MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode() & " AND 
                           MVFNP.ID_OPT_STATUS IN (" & enOpcoes.StatusMovimentacaoFinanceira_Quitada.GetHashCode() & "," &
                                                       enOpcoes.StatusMovimentacaoFinanceira_QuitadaParcialmente.GetHashCode() & "," &
                                                       enOpcoes.StatusMovimentacaoFinanceira_ParcialmenteQuitadaCancelada.GetHashCode() & "," &
                                                       enOpcoes.StatusMovimentacaoFinanceira_ParcialmenteQuitadaEncontroContas.GetHashCode() & "," &
                                                       enOpcoes.StatusMovimentacaoFinanceira_ParcialmenteQuitadaRenegociada.GetHashCode() & ")) OR " &
                         "MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() & ")" &
                   " AND (MVFNC.ID_CONTAFINANCEIRA_CREDITO = " & iID_CONTA_FINANCEIRA.ToString() & " OR " &
                         "MVFNC.ID_CONTAFINANCEIRA_DEBITO = " & iID_CONTA_FINANCEIRA.ToString() & " ) " &
                   " AND DEVOL.ID_MOVFINANCEIRAPARCELA IS NULL" &
                   " AND ISNULL(MVFNP.ID_FORMAPAGAMENTO_PREFERENCIAL, 0) <> 116" &
                  " GROUP BY MVFNC.ID_CLINICA_VENDA_DEVOLUCAO, MVFNC.ID_OPT_TIPOMOVFINANCEIRA," &
                            "IIF(MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode() & ", PESSO.NO_PESSOA, TPDOC.NO_TIPO_DOCUMENTO)" &
                  " ORDER BY IIF(MVFNC.ID_CLINICA_VENDA_DEVOLUCAO IS NULL, MVFNC.ID_OPT_TIPOMOVFINANCEIRA, 46.5)"
      oData = DBQuery(sSqlText)

      sSqlText = "SELECT CONVE.NO_CONVENIO," &
                        "COUNT(*) QTDE," &
                        "SUM(MVFNP.VL_PARCELA - (MVFNP.VL_DESCONTO + MVFNP.VL_DESCONTO_PAGTO)) VL_PARCELA" &
                 " FROM TB_MOVFINANCEIRA MVFNC" &
                  " INNER JOIN TB_MOVFINANCEIRAPARCELA MVFNP ON MVFNP.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                   " LEFT JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = MVFNC.ID_CLINICA_VENDA" &
                   " LEFT JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = CLVND.ID_CONVENIO" &
                 " WHERE CAST(ISNULL(MVFNP.DT_QUITACAO, MVFNC.DT_LANCAMENTO) AS DATE) >= " & FNC_QuotedStr(dDataInicial) &
                   " AND CAST(ISNULL(MVFNP.DT_QUITACAO, MVFNC.DT_LANCAMENTO) AS DATE) <= " & FNC_QuotedStr(dDataFinal) &
                   " AND MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                   " AND MVFNC.ID_CONTAFINANCEIRA_CREDITO = " & iID_CONTA_FINANCEIRA.ToString() &
                 " GROUP BY CONVE.NO_CONVENIO"
      oDadosConvenio = DBQuery(sSqlText)

      sSqlText = "SELECT MVFNC.ID_OPT_TIPOMOVFINANCEIRA," &
                        "PLCNT.NO_PLANOCONTAS," &
                        "SUM(ROUND((MVFNP.VL_PARCELA - (ISNULL(MVFNP.VL_DESCONTO, 0) + ISNULL(MVFNP.VL_DESCONTO_PAGTO, 0))) * ROUND(ISNULL(MVPLC.PC_PARTICIPACAO, 0) / 100, 2), 2)) VL_PARCELA_REAL," &
                        "COUNT(*) QTDE" &
                 " FROM TB_MOVFINANCEIRA MVFNC" &
                  " INNER JOIN TB_MOVFINANCEIRAPARCELA MVFNP ON MVFNP.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                  "  LEFT JOIN TB_MOVFINANCEIRA_PLANOCONTAS MVPLC ON MVPLC.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                  "  LEFT JOIN TB_PLANOCONTAS PLCNT ON PLCNT.SQ_PLANOCONTAS = MVPLC.ID_PLANOCONTAS" &
                 " WHERE CAST(ISNULL(MVFNP.DT_QUITACAO, MVFNC.DT_LANCAMENTO) AS DATE) >= " & FNC_QuotedStr(dDataInicial) &
                   " AND CAST(ISNULL(MVFNP.DT_QUITACAO, MVFNC.DT_LANCAMENTO) AS DATE) <= " & FNC_QuotedStr(dDataFinal) &
                   " AND ((MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode() & " AND 
                           MVFNP.ID_OPT_STATUS IN (" & enOpcoes.StatusMovimentacaoFinanceira_Quitada.GetHashCode() & "," &
                                                       enOpcoes.StatusMovimentacaoFinanceira_QuitadaParcialmente.GetHashCode() & "," &
                                                       enOpcoes.StatusMovimentacaoFinanceira_ParcialmenteQuitadaCancelada.GetHashCode() & "," &
                                                       enOpcoes.StatusMovimentacaoFinanceira_ParcialmenteQuitadaEncontroContas.GetHashCode() & "," &
                                                       enOpcoes.StatusMovimentacaoFinanceira_ParcialmenteQuitadaRenegociada.GetHashCode() & ")) OR " &
                         "MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() & ")" &
                   " AND (MVFNC.ID_CONTAFINANCEIRA_CREDITO = " & iID_CONTA_FINANCEIRA.ToString() & " OR " &
                         "MVFNC.ID_CONTAFINANCEIRA_DEBITO = " & iID_CONTA_FINANCEIRA.ToString() & " ) " &
                  " GROUP BY MVFNC.ID_OPT_TIPOMOVFINANCEIRA," &
                            "PLCNT.NO_PLANOCONTAS" &
                  " ORDER BY MVFNC.ID_OPT_TIPOMOVFINANCEIRA DESC, PLCNT.NO_PLANOCONTAS"
      oDadosPlanoContas = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\MovFinanceira_Prestacao_Contas.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ClinicaVendaFechamento
        oForm.Formatar()

        .LocalReport.SetParameters(New ReportParameter("Conta", sNO_CONTA_FINANCEIRA))
        .LocalReport.SetParameters(New ReportParameter("Periodo", dDataInicial.ToString().Substring(0, 10) & " a " & dDataFinal.ToString().Substring(0, 10)))
        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DadosConvenio", oDadosConvenio))
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DadosPlanoContas", oDadosPlanoContas))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioCaixaPrestacaoContas - " & ex.Message)
    End Try
  End Sub
  Public Sub FormRelatorioCaixaPrestacaoContas(iID_CLINICA_VENDA_FECHAMENTO As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select CAST(CLVND.DH_VENDA As Date) DT_VENDA," &
                        "CTFIN.NO_CONTAFINANCEIRA," &
                        "PESSO_ATEND.NO_PESSOA NO_PESSOA_ATENDENTE," &
                        "FMPGT.NO_FORMAPAGAMENTO," &
                        "CLVND.CD_CLINICA_VENDA," &
                        "PESSO.NO_PESSOA," &
                        "MVFNP.VL_PARCELA," &
                        "CLVND.ID_CLINICA_VENDA_FECHAMENTO" &
                 " FROM TB_MOVFINANCEIRAPARCELA MVFNP" &
                  " INNER JOIN TB_FORMAPAGAMENTO FMPGT ON FMPGT.SQ_FORMAPAGAMENTO = MVFNP.ID_FORMAPAGAMENTO_PREFERENCIAL" &
                  "	INNER JOIN TB_MOVFINANCEIRA MVFNC ON MVFNC.SQ_MOVFINANCEIRA = MVFNP.ID_MOVFINANCEIRA" &
                                                   " And MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                  " INNER JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = MVFNC.ID_CLINICA_VENDA" &
                  " INNER JOIN TB_PESSOA PESSO_ATEND ON PESSO_ATEND.SQ_PESSOA = CLVND.ID_PESSOA_ATENDENTE" &
                  " INNER JOIN TB_CONTAFINANCEIRA CTFIN ON CTFIN.SQ_CONTAFINANCEIRA = CLVND.ID_CONTAFINANCEIRA" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                " WHERE CLVND.ID_CLINICA_VENDA_FECHAMENTO = " & iID_CLINICA_VENDA_FECHAMENTO.ToString() &
                   " And MVFNP.ID_OPT_STATUS <> " & enOpcoes.StatusMovimentacaoFinanceira_Quitada.GetHashCode() &
                   " And MVFNC.ID_OPT_STATUS <> " & enOpcoes.StatusMovimentacaoFinanceira_Quitada.GetHashCode()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Caixa_Prestacao_Contas_Fechamento.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ClinicaVendaFechamento
        oForm.Formatar()

        .LocalReport.SetParameters(New ReportParameter("Usuario", sNO_USUARIO))
        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioCaixaPrestacaoContas - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioCaixaPrestacaoContasFechamento(iID_CONTAFINANCEIRA As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select CONCAT(CONVERT(VARCHAR, CLVND.DH_VENDA, 101),'-',CTFIN.NO_CONTAFINANCEIRA,'-',PESSO_ATEND.NO_PESSOA) CD_GRUPO," &
                        "CAST(CLVND.DH_VENDA AS DATE) DT_VENDA," &
                        "CTFIN.NO_CONTAFINANCEIRA," &
                        "PESSO_ATEND.NO_PESSOA NO_PESSOA_ATENDENTE," &
                        "FMPGT.NO_FORMAPAGAMENTO," &
                        "CLVND.CD_CLINICA_VENDA," &
                        "PESSO.NO_PESSOA," &
                        "MVFNP.VL_PARCELA," &
                        "CLVND.ID_CLINICA_VENDA_FECHAMENTO " &
                 " FROM TB_CLINICA_VENDA CLVND" &
                  " INNER JOIN TB_MOVFINANCEIRA	MVFNC ON MVFNC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                  " INNER JOIN TB_MOVFINANCEIRAPARCELA MVFNP ON MVFNP.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                  " INNER JOIN TB_FORMAPAGAMENTO FMPGT ON FMPGT.SQ_FORMAPAGAMENTO = MVFNP.ID_FORMAPAGAMENTO_PREFERENCIAL" &
                  " INNER JOIN TB_TIPO_DOCUMENTO TPDOC ON TPDOC.SQ_TIPO_DOCUMENTO = MVFNP.ID_TIPO_DOCUMENTO" &
                  " INNER JOIN TB_CONTAFINANCEIRA CTFIN ON CTFIN.SQ_CONTAFINANCEIRA = CLVND.ID_CONTAFINANCEIRA" &
                  "	INNER JOIN TB_PESSOA PESSO_ATEND ON PESSO_ATEND.SQ_PESSOA = CLVND.ID_PESSOA_ATENDENTE" &
                  "	INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                 " WHERE CLVND.ID_CLINICA_VENDA_FECHAMENTO IS NULL" &
                   " AND CLVND.DH_CANCELAR IS NULL" &
                   " AND CLVND.ID_CONTAFINANCEIRA = " & iID_CONTAFINANCEIRA.ToString() &
                   " AND CLVND.ID_OPT_STATUS = " & enOpcoes.StatusVendaClinica_Lancado.GetHashCode() &
                   " AND MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                   " AND MVFNP.ID_OPT_STATUS <> " & enOpcoes.StatusMovimentacaoFinanceira_Quitada.GetHashCode() &
                   " AND MVFNC.ID_OPT_STATUS <> " & enOpcoes.StatusMovimentacaoFinanceira_Quitada.GetHashCode() &
                 " ORDER BY CLVND.CD_CLINICA_VENDA," &
                           "TPDOC.NO_TIPO_DOCUMENTO," &
                           "MVFNP.CD_DOCUMENTO"
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Caixa_Prestacao_Contas_Fechamento.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ClinicaVendaFechamento
        oForm.Formatar()

        .LocalReport.SetParameters(New ReportParameter("Usuario", sNO_USUARIO))
        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioCaixaPrestacaoContas - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioFinanceiro_Recibo_Pagamento(iSQ_MOVFINANCEIRAPARCELA As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim oDados_FPGTO As DataTable
      Dim oDados_Detalhamento As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT MVFNP.DT_VENCIMENTO," &
                        "PESSO.NO_PESSOA," &
                        "MVFNC.DS_MOVFINANCEIRA," &
                        "dbo.FC_PAGAMENTO_PAGAMENTO_MOVFINANCEIRA_FORMASPAGTO(SQ_MOVFINANCEIRA) FORMASPAGTO," &
                        "dbo.FC_MOVFINANCEIRA_PLANOSCONTA(SQ_MOVFINANCEIRA) PLANOSCONTA," &
                        "CTFIN_D.NO_CONTAFINANCEIRA," &
                        "MVFNC.SQ_MOVFINANCEIRA," &
                        "SUM(PAGIT.VL_PAGAMENTO) VL_PARCELA" &
                 " FROM TB_PAGAMENTOITEM_MOVFINANCEIRA PGIMF" &
                  " INNER JOIN TB_PAGAMENTOITEM PAGIT ON PAGIT.SQ_PAGAMENTOITEM = PGIMF.ID_PAGAMENTOITEM" &
                  " INNER JOIN TB_FORMAPAGAMENTO FPGTO ON FPGTO.SQ_FORMAPAGAMENTO = PAGIT.ID_FORMAPAGAMENTO" &
                  " INNER JOIN TB_MOVFINANCEIRAPARCELA MVFNP ON MVFNP.SQ_MOVFINANCEIRAPARCELA = PGIMF.ID_MOVFINANCEIRAPARCELA" &
                  " INNER JOIN TB_MOVFINANCEIRA MVFNC ON MVFNC.SQ_MOVFINANCEIRA = MVFNP.ID_MOVFINANCEIRA" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = MVFNC.ID_PESSOA" &
                  " INNER JOIN TB_CONTAFINANCEIRA CTFIN_D ON CTFIN_D.SQ_CONTAFINANCEIRA = ISNULL(MVFNC.ID_CONTAFINANCEIRA_DEBITO, MVFNC.ID_CONTAFINANCEIRA_CREDITO)" &
                 " WHERE MVFNP.SQ_MOVFINANCEIRAPARCELA = " & iSQ_MOVFINANCEIRAPARCELA.ToString() &
                 " GROUP BY MVFNP.DT_VENCIMENTO," &
                           "PESSO.NO_PESSOA," &
                           "MVFNC.DS_MOVFINANCEIRA," &
                           "dbo.FC_PAGAMENTO_PAGAMENTO_MOVFINANCEIRA_FORMASPAGTO(SQ_MOVFINANCEIRA)," &
                           "dbo.FC_MOVFINANCEIRA_PLANOSCONTA(SQ_MOVFINANCEIRA)," &
                           "CTFIN_D.NO_CONTAFINANCEIRA," &
                           "MVFNC.SQ_MOVFINANCEIRA"
      oData = DBQuery(sSqlText)

      sSqlText = "Select TOP 4 FPGTO.NO_FORMAPAGAMENTO," &
                              "MVFNP.CD_DOCUMENTO," &
                              "MVFNP.DT_VENCIMENTO," &
                              "PAGIT.VL_PAGAMENTO" &
                 " FROM TB_PAGAMENTOITEM_MOVFINANCEIRA PGIMF" &
                  " INNER JOIN TB_PAGAMENTOITEM PAGIT On PAGIT.SQ_PAGAMENTOITEM = PGIMF.ID_PAGAMENTOITEM" &
                  " INNER JOIN TB_FORMAPAGAMENTO FPGTO On FPGTO.SQ_FORMAPAGAMENTO = PAGIT.ID_FORMAPAGAMENTO" &
                  " INNER JOIN TB_MOVFINANCEIRAPARCELA MVFNP On MVFNP.SQ_MOVFINANCEIRAPARCELA = PGIMF.ID_MOVFINANCEIRAPARCELA" &
                 " WHERE MVFNP.SQ_MOVFINANCEIRAPARCELA = " & iSQ_MOVFINANCEIRAPARCELA.ToString()
      oDados_FPGTO = DBQuery(sSqlText)

      sSqlText = "SELECT PG.DS_MOVFINANCEIRA, PG.DT_MOVIMENTACAO, PG.DT_VENCIMENTO, PG.VL_PARCELA" &
                 " FROM VW_MOVFINANCEIRAPARCELA PC" &
                  " INNER JOIN VW_MOVFINANCEIRAPARCELA PG ON PG.ID_MOVFINANCEIRAGERADA = PC.ID_MOVFINANCEIRA" &
                 " WHERE PC.SQ_MOVFINANCEIRAPARCELA = " & iSQ_MOVFINANCEIRAPARCELA.ToString() &
                 " ORDER BY PG.DS_MOVFINANCEIRA"
      oDados_Detalhamento = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Financeiro_Recibo_Pagamento.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.FinanceiroReciboPagamento
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados_FPGTO", oDados_FPGTO))
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados_Detalhamento", oDados_Detalhamento))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioFinanceiro_Comprovante_Transferencia - " & ex.Message)
    End Try
  End Sub

  Private Function FormRelatorioFinanceiro_Voucher_SqlText(iSQ_VOUCHER As Integer) As String
    Dim sSqlText As String

    sSqlText = "SELECT VOUCE.DH_VOUHCER," &
                      "VOUCE.CD_VOUCHER," &
                      "PESSO.NO_PESSOA," &
                      "VOUCE.VL_VOUCHER, " &
                      "VOUCE.VL_MOVIMENTADO," &
                      "VOUCE.VL_CANCELADO, " &
                      "ISNULL(VOUCE.VL_VOUCHER, 0) - ISNULL(VOUCE.VL_MOVIMENTADO, 0) - ISNULL(VOUCE.VL_CANCELADO, 0) VL_SALDO" &
               " FROM TB_VOUCHER VOUCE" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = VOUCE.ID_PESSOA" &
               " WHERE VOUCE.SQ_VOUCHER = " & iSQ_VOUCHER

    Return sSqlText
  End Function

  Public Sub FormRelatorioFinanceiro_Voucher(iSQ_VOUCHER As Integer, Autorizacao As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = FormRelatorioFinanceiro_Voucher_SqlText(iSQ_VOUCHER)
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        If Autorizacao Then
          .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Voucher_Autorizacao.rdl")
        Else
          .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Voucher.rdl")
        End If
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Voucher
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioFinanceiro_Vouhcer - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioFinanceiro_VoucherLancamento(iSQ_VOUCHER As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim oData_Listagem As DataTable
      Dim sSqlText As String

      sSqlText = FormRelatorioFinanceiro_Voucher_SqlText(iSQ_VOUCHER)
      oData = DBQuery(sSqlText)

      sSqlText = "SELECT VOUCE.CD_VOUCHER, PESSO.NO_PESSOA, CD_CLINICA_VENDA, AGEND.CD_AGENDAMENTO, CVPCD.VL_PROCEDIMENTO, VCLNC.VL_LANCAMENTO, VCLNC.DH_LANCAMENTO" &
                 " FROM TB_VOUCHER_LANCAMENTO VCLNC" &
                  " INNER JOIN TB_VOUCHER VOUCE ON VOUCE.SQ_VOUCHER = VCLNC.ID_VOUCHER" &
                   " LEFT JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = VCLNC.ID_CLINICA_VENDA" &
                   " LEFT JOIN (SELECT ID_CLINICA_VENDA, SUM(VL_PROCEDIMENTO) VL_PROCEDIMENTO" &
                               " FROM TB_CLINICA_VENDA_PROCEDIMENTO GROUP BY ID_CLINICA_VENDA) CVPCD ON CVPCD.ID_CLINICA_VENDA = VCLNC.ID_CLINICA_VENDA" &
                   " LEFT JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = VCLNC.ID_AGENDAMENTO" &
                   " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA OR PESSO.SQ_PESSOA = AGEND.ID_PESSOA" &
                 " WHERE VCLNC.ID_VOUCHER = " & iSQ_VOUCHER
      oData_Listagem = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\VoucherLancamento.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Voucher_Lancamento
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados_Listagem", oData_Listagem))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioFinanceiro_VoucherLancamento - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioFinanceiro_Comprovante_Transferencia(iSQ_MOVFINANCEIRA As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select MVFNC.DT_MOVIMENTACAO," &
                        "CTFIN_C.NO_CONTAFINANCEIRA NO_CONTAFINANCEIRA_CREDITO," &
                        "CTFIN_d.NO_CONTAFINANCEIRA NO_CONTAFINANCEIRA_DEBITO," &
                        "dbo.FC_MOVFINANCEIRA_PLANOSCONTA(MVFNC.SQ_MOVFINANCEIRA) PLANOSCONTA," &
                        "MVFNC.DS_MOVFINANCEIRA," &
                        "MVFNC.VL_MOVFINANCEIRA" &
                 " FROM TB_MOVFINANCEIRA MVFNC" &
                  " INNER JOIN TB_OPCAO OPCAO_TPMOV On OPCAO_TPMOV.SQ_OPCAO = MVFNC.ID_OPT_TIPOMOVFINANCEIRA" &
                   " LEFT JOIN TB_CONTAFINANCEIRA CTFIN_C On CTFIN_C.SQ_CONTAFINANCEIRA = MVFNC.ID_CONTAFINANCEIRA_CREDITO" &
                   " LEFT JOIN TB_CONTAFINANCEIRA CTFIN_D On CTFIN_D.SQ_CONTAFINANCEIRA = MVFNC.ID_CONTAFINANCEIRA_DEBITO" &
                 " WHERE OPCAO_TPMOV.ID_TIPO_OPCAO = 15" &
                   " And MVFNC.SQ_MOVFINANCEIRA = " & iSQ_MOVFINANCEIRA.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Financeiro_Comprovante_Transferencia.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.FinanceiroComprovanteTransferencia
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioFinanceiro_Comprovante_Transferencia - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioAtestadoAcompanhante(iSQ_PESSOA_ATESTADO As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select CLATD.DH_CLINICA_ATENDIMENTO," &
                        "PESSO.NO_PESSOA," &
                        "PSATT.DS_ACOMPANHANTE" &
                 " FROM TB_PESSOA_ATESTADO PSATT" &
                  " INNER JOIN TB_CLINICA_ATENDIMENTO CLATD On CLATD.SQ_CLINICA_ATENDIMENTO = PSATT.ID_CLINICA_ATENDIMENTO" &
                  " INNER JOIN TB_PESSOA PESSO On PESSO.SQ_PESSOA = PSATT.ID_PESSOA" &
                 " WHERE PSATT.SQ_PESSOA_ATESTADO =  " & iSQ_PESSOA_ATESTADO.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\AtestadoAcompanhante.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.AtestadoComparecimento
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioAtestadoMedico - " & ex.Message)
    End Try
  End Sub
  Public Sub FormRelatorioAtestadoComparecimento(iSQ_PESSOA_ATESTADO As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select PSATT.DH_PESSOA_ATESTADO," &
                        "PESSO.NO_PESSOA," &
                        "PSATT.DS_ACOMPANHANTE" &
                 " FROM TB_PESSOA_ATESTADO PSATT" &
                  " INNER JOIN TB_PESSOA PESSO On PESSO.SQ_PESSOA = PSATT.ID_PESSOA" &
                 " WHERE PSATT.SQ_PESSOA_ATESTADO =  " & iSQ_PESSOA_ATESTADO.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\AtestadoComparecimento.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.AtestadoComparecimento
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioAtestadoComparecimento - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioMedicoFaturamento(iID_MOVFINANCEIRA As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select MVFNC.DT_MOVIMENTACAO," &
                       "CLVND.CD_CLINICA_VENDA," &
                       "CLVND.DH_VENDA," &
                       "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                       "PESSO.NO_PESSOA," &
                       "PROCE.NO_PROCEDIMENTO," &
                       "CVPRC.VL_REPASSE," &
                       "ROUND(CVPRC.VL_REPASSE / 2 * 6.15 / 100, 2) VL_IMPOSTO" &
                 " FROM TB_MOVFINANCEIRA MVFNC" &
                  " INNER JOIN TB_MOVFINANCEIRAPARCELA	MVFNP On MVFNP.ID_MOVFINANCEIRAGERADA = MVFNC.SQ_MOVFINANCEIRA" &
                  " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPRC On CVPRC.ID_MOVFINANCEIRA = MVFNP.ID_MOVFINANCEIRA" &
                  " INNER JOIN TB_CLINICA_VENDA CLVND On CLVND.SQ_CLINICA_VENDA = CVPRC.ID_CLINICA_VENDA" &
                  "	INNER JOIN TB_PESSOA PESSO_PROFI On PESSO_PROFI.SQ_PESSOA = CVPRC.ID_PESSOA_PROFISSIONAL" &
                  "	INNER JOIN TB_PESSOA PESSO On PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                  "	INNER JOIN TB_PROCEDIMENTO PROCE On PROCE.SQ_PROCEDIMENTO = CVPRC.ID_PROCEDIMENTO" &
                 " WHERE MVFNC.SQ_MOVFINANCEIRA = " & iID_MOVFINANCEIRA.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\MedicoFaturamento.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.MedicoFaturamento
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioMedicoFaturamento - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioSolicitacaoExame(iID_CLINICA_ATENDIMENTO As Integer, Impresso As Boolean, Optional bImprimir As Boolean = False)
    Try
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select CLATD.DH_CLINICA_ATENDIMENTO," &
                        "PESSO.NO_PESSOA," &
                        "PESSO.SQ_PESSOA," &
                        "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "PSEMP.NR_PROFISSIONAL_CONSELHOPROFISSIONAL," &
                        "PROCE.NO_PROCEDIMENTO," &
                        "CLPCD.CM_PROCEDIMENTO," &
                        "PROCE.ID_OPT_TIPOPROCEDIMENTO," &
                        "IIF(PROCE.ID_OPT_TIPOEXAME = 729, PROCE.SQ_PROCEDIMENTO, 0) NR_GRUPO_PROCEDIMENTO" &
                 " FROM TB_CLINICA_PROCEDIMENTO CLPCD" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE On PROCE.SQ_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO" &
                  " INNER JOIN TB_CLINICA_ATENDIMENTO CLATD On CLATD.SQ_CLINICA_ATENDIMENTO = CLPCD.ID_CLINICA_ATENDIMENTO" &
                  " INNER JOIN TB_PESSOA PESSO On PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                  " INNER JOIN TB_PESSOA PESSO_PROFI On PESSO_PROFI.SQ_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                  " INNER JOIN TB_EMPRESA EMPRE On EMPRE.ID_EMPRESA = CLATD.ID_EMPRESA" &
                   " LEFT JOIN TB_PESSOA_EMPRESA PSEMP On PSEMP.ID_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                                                    " And PSEMP.ID_EMPRESA = EMPRE.ID_EMPRESA_MATRIZ" &
                  " WHERE ISNULL(CLPCD.IC_IMPRESSAO, 'N') = 'S'" &
                    " AND CLPCD.ID_CLINICA_ATENDIMENTO =  " & iID_CLINICA_ATENDIMENTO.ToString()

      If Impresso Then
        sSqlText = sSqlText & " AND ISNULL(CLPCD.IC_IMPRESSAO, 'N') = 'S'"
      Else
        sSqlText = sSqlText & " AND ISNULL(CLPCD.IC_IMPRESSAO, 'N') = 'N'"
      End If
      oData = DBQuery(sSqlText)

      Dim oForm As New frmReportViewer

      oForm.bImprimir = bImprimir

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\ExameSolicitado.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.SolicitacaoExame
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioAtestadoComparecimento - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioReceituario(iSQ_CLINICA_RECEITUARIO As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT CLATD.CD_CLINICA_ATENDIMENTO," &
                        "PESSO.NO_PESSOA," &
                        "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "PSEMP.NR_PROFISSIONAL_CONSELHOPROFISSIONAL," &
                        "CLRCT.DS_RECEITUARIO," &
                        "CLATD.DH_CLINICA_ATENDIMENTO" &
                 " FROM TB_CLINICA_RECEITUARIO CLRCT" &
                  " INNER JOIN TB_CLINICA_ATENDIMENTO CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLRCT.ID_CLINICA_ATENDIMENTO" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLRCT.ID_PESSOA" &
                  " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLRCT.ID_PESSOA_PROFISSIONAL" &
                  " INNER JOIN TB_EMPRESA EMPRE ON EMPRE.ID_EMPRESA = CLATD.ID_EMPRESA" &
                   " LEFT JOIN TB_PESSOA_EMPRESA PSEMP ON PSEMP.ID_PESSOA = CLRCT.ID_PESSOA_PROFISSIONAL" &
                                                    " AND PSEMP.ID_EMPRESA = EMPRE.ID_EMPRESA_MATRIZ" &
                 " WHERE CLRCT.SQ_CLINICA_RECEITUARIO = " & iSQ_CLINICA_RECEITUARIO.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Receituario.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Receituario
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioAtestadoComparecimento - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioOcupacaoTempoPrevisto(sSQ_CLINICA_ATENDIMENTO As String, Termino As String, Inicio As String, Quantidade As String, Tempo As String)
    Dim oForm As New frmReportViewer
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT CLATD.ID_EMPRESA," &
                      "EMPRE.NO_PESSOA AS UNIDADE," &
                      "PROFI.SQ_PESSOA," &
                      "PROFI.NO_PESSOA AS PROFISSIONAL," &
                      "PESSO.NO_PESSOA AS PACIENTE," &
                      "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') DS_NASCIMENTO," &
                      "CLATD.DH_CLINICA_INICIO_ATENDIMENTO," &
                      "CLATD.DH_FIM_ATENDIMENTO," &
                      "dbo.FC_ConverteSegundosEmHoras(DATEDIFF(SECOND, DH_CLINICA_INICIO_ATENDIMENTO, DH_FIM_ATENDIMENTO)) AS TEMPO" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_PESSOA PROFI ON CLATD.ID_PESSOA_PROFISSIONAL = PROFI.SQ_PESSOA" &
                " INNER JOIN TB_PESSOA AS EMPRE ON EMPRE.SQ_PESSOA = CLATD.ID_EMPRESA" &
                " INNER JOIN TB_PESSOA AS PESSO ON CLATD.ID_PESSOA = PESSO.SQ_PESSOA" &
               " WHERE CLATD.SQ_CLINICA_ATENDIMENTO IN (" & sSQ_CLINICA_ATENDIMENTO & ")"
    oData = DBQuery(sSqlText)

    With oForm.rpvGeral
      .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\OcupacaoTempoPrevisto.rdl")
      .LocalReport.SetParameters(New ReportParameter("Termino", Termino))
      .LocalReport.SetParameters(New ReportParameter("Inicio", Inicio))
      .LocalReport.SetParameters(New ReportParameter("Quantidade", Quantidade))
      .LocalReport.SetParameters(New ReportParameter("Tempo", Tempo))
      oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Receituario
      oForm.Formatar()

      .LocalReport.DataSources.Clear()
      .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
      .RefreshReport()

      oForm.Show()
    End With
  End Sub

  Public Sub FormRelatorioDisponibilidade(sSqlText As String)
    Dim oForm As New frmReportViewer
    Dim oData As DataTable

    oData = DBQuery(sSqlText)

    With oForm.rpvGeral
      .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Disponibilidade.rdl")
      oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Receituario
      oForm.Formatar()

      .LocalReport.DataSources.Clear()
      .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
      .RefreshReport()

      oForm.Show()
    End With
  End Sub

  Public Sub FormRelatorioConstultorioOcupacao(sSQ_PESSOA_HORARIO As String)
    Dim oForm As New frmReportViewer
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT EMPRE.NO_PESSOA AS UNIDADE," &
                      "CONSU.NO_CONSULTORIO," &
                      "OPCAO.NO_OPCAO AS DIA," &
                      "PSHRR.HR_INICIO," &
                      "PSHRR.HR_FIM," &
                      "PESSO.NO_PESSOA AS PROFISSIONAL," &
                      "PSHRR.QT_ATENDIMENTO," &
                      "PSHRR.QT_RETORNO," &
                      "PSHRR.DT_ESPECIAL" &
               " FROM TB_PESSOA_HORARIO PSHRR" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PSHRR.ID_PESSOA" &
                " INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = PSHRR.ID_EMPRESA" &
                " INNER JOIN TB_OPCAO OPCAO ON OPCAO.SQ_OPCAO = PSHRR.ID_OPT_DIA_SEMANA" &
                " INNER JOIN TB_CONSULTORIO CONSU ON CONSU.SQ_CONSULTORIO = PSHRR.ID_CONSULTORIO" &
                " WHERE PSHRR.SQ_PESSOA_HORARIO IN (" & sSQ_PESSOA_HORARIO.ToString() & ")" &
                  " AND (PSHRR.DT_ESPECIAL IS NULL OR PSHRR.DT_ESPECIAL >= CAST(GETDATE() AS DATE))" &
               " ORDER BY OPCAO.CD_OPCAO," &
                         "PSHRR.HR_INICIO"
    oData = DBQuery(sSqlText)

    With oForm.rpvGeral
      .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\ConstultorioOcupacao.rdl")
      oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Receituario
      oForm.Formatar()

      .LocalReport.DataSources.Clear()
      .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
      .RefreshReport()

      oForm.Show()
    End With
  End Sub

  Public Sub FormRelatorioAbestencaoDia(sSQ_AGENDAMENTO As String)
    Dim oForm As New frmReportViewer
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT AGEND.SQ_AGENDAMENTO," &
                      "EMPRE.NO_PESSOA AS UNIDADE," &
                      "PROFI.NO_PESSOA AS PROFISSIONAL," &
                      "AGEND.DH_AGENDAMENTO," &
                      "OPCAO.NO_OPCAO AS STATUS," &
                      "ESPEC.NO_ESPECIALIDADE AS ESPECIALIDADE," &
                      "PROCE.NO_PROCEDIMENTO AS PROCEDIMENTO," &
                      "AGEND.CD_AGENDAMENTO," &
                      "TPCST.NO_TIPO_CONSULTA AS TIPO," &
                      "PESSO.NO_PESSOA AS PACIENTE," &
                      "MIN(PSTEL.CD_NUMERO) AS TELEFONE" &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_OPCAO OPCAO ON OPCAO.SQ_OPCAO = AGEND.ID_OPT_STATUS" &
                " INNER JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = AGEND.ID_ESPECIALIDADE" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA  = AGEND.ID_PESSOA" &
                " INNER JOIN TB_PESSOA AS PROFI ON PROFI.SQ_PESSOA  = AGEND.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO  = AGEND.ID_PROCEDIMENTO" &
                " INNER JOIN TB_TIPO_CONSULTA TPCST ON TPCST.SQ_TIPO_CONSULTA  = AGEND.ID_TIPO_CONSULTA" &
                " INNER JOIN TB_PESSOA AS EMPRE ON EMPRE.SQ_PESSOA  = AGEND.ID_EMPRESA" &
                " INNER JOIN TB_PESSOA_TELEFONE PSTEL ON PSTEL.ID_PESSOA = AGEND.ID_PESSOA" &
               " WHERE AGEND.SQ_AGENDAMENTO IN (" & sSQ_AGENDAMENTO & ")" &
                 " AND (AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Agendado & " OR " &
                       "AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_AguardandoAtendimento & " OR " &
                       "AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_AguardandoPagamento & ")" &
               " GROUP BY AGEND.SQ_AGENDAMENTO," &
                         "EMPRE.NO_PESSOA," &
                         "PROFI.NO_PESSOA," &
                         "AGEND.DH_AGENDAMENTO," &
                         "OPCAO.NO_OPCAO," &
                         "ESPEC.NO_ESPECIALIDADE," &
                         "PROCE.NO_PROCEDIMENTO," &
                         "AGEND.CD_AGENDAMENTO," &
                         "TPCST.NO_TIPO_CONSULTA," &
                         "PESSO.NO_PESSOA"
    oData = DBQuery(sSqlText)

    With oForm.rpvGeral
      .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\DiasAbstencao.rdl")
      oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Receituario
      oForm.Formatar()

      .LocalReport.DataSources.Clear()
      .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
      .RefreshReport()

      oForm.Show()
    End With
  End Sub

  Public Sub FormRelatorioRelatorio(iID_CLINICA_ATENDIMENTO As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT CLATD.CD_CLINICA_ATENDIMENTO," &
                        "PESSO.NO_PESSOA," &
                        "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "PSEMP.NR_PROFISSIONAL_CONSELHOPROFISSIONAL," &
                        "CLREL.DS_RELATORIO," &
                        "CLATD.DH_CLINICA_ATENDIMENTO," &
                        "TPRLT.NO_TIPO_RELATORIO" &
                 " FROM TB_CLINICA_RELATORIO CLREL" &
                  " INNER JOIN TB_CLINICA_ATENDIMENTO CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLREL.ID_CLINICA_ATENDIMENTO" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLREL.ID_PESSOA" &
                  " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLREL.ID_PESSOA_PROFISSIONAL" &
                   " LEFT JOIN TB_PESSOA_EMPRESA PSEMP ON PSEMP.ID_PESSOA = CLREL.ID_PESSOA_PROFISSIONAL" &
                                                    " And PSEMP.ID_EMPRESA = CLATD.ID_EMPRESA" &
                   " LEFT JOIN TB_TIPO_RELATORIO TPRLT ON TPRLT.SQ_TIPO_RELATORIO = CLREL.ID_TIPO_RELATORIO" &
                 " WHERE CLREL.ID_CLINICA_ATENDIMENTO =  " & iID_CLINICA_ATENDIMENTO.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\RelatorioMedico.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Receituario
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioAtestadoComparecimento - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioVacina(iID_CLINICA_ATENDIMENTO As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT CLATD.CD_CLINICA_ATENDIMENTO," &
                        "CONCAT(PESSO.NO_PESSOA, ' - ', dbo.FC_FormatarCPF_CNPJ(PESSO.CD_CPF_CNPJ)) NO_PESSOA," &
                        "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "PSEMP.NR_PROFISSIONAL_CONSELHOPROFISSIONAL," &
                        "CLATD.DH_CLINICA_ATENDIMENTO," &
                        "CLVCN.DT_LANCAMENTO," &
                        "VACIN.NO_VACINA," &
                        "CLVCN.QT_DOSAGEM," &
                        "CLVCN.CM_CLINICA_VACINA" &
                 " FROM TB_CLINICA_VACINA CLVCN" &
                  " INNER JOIN TB_CLINICA_ATENDIMENTO CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLVCN.ID_CLINICA_ATENDIMENTO" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVCN.ID_PESSOA" &
                  " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                  " INNER JOIN TB_VACINA VACIN ON VACIN.SQ_VACINA = CLVCN.ID_VACINA" &
                  " INNER JOIN TB_EMPRESA EMPRE ON EMPRE.ID_EMPRESA = CLATD.ID_EMPRESA" &
                   " LEFT JOIN TB_PESSOA_EMPRESA PSEMP ON PSEMP.ID_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                                                    " AND PSEMP.ID_EMPRESA = EMPRE.ID_EMPRESA_MATRIZ" &
                 " WHERE CLVCN.ID_CLINICA_ATENDIMENTO =  " & iID_CLINICA_ATENDIMENTO.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\SolicitacaoVacina.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Receituario
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioAtestadoComparecimento - " & ex.Message)
    End Try
  End Sub
  Public Sub FormRelatorioAtestadoMedico(iSQ_PESSOA_ATESTADO As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT CLATD.DH_CLINICA_ATENDIMENTO," &
                        "PESSO.NO_PESSOA," &
                        "PSATT.NR_DIAS_REPOUSO," &
                        "dbo.FNC_Extenso(NR_DIAS_REPOUSO) DS_DIAS_REPOUSO," &
                        "PSATT.DS_ATESTADO," &
                        "PSATT.CD_CID" &
                 " FROM TB_PESSOA_ATESTADO PSATT" &
                  " INNER JOIN TB_CLINICA_ATENDIMENTO CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = PSATT.ID_CLINICA_ATENDIMENTO" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PSATT.ID_PESSOA" &
                 " WHERE PSATT.SQ_PESSOA_ATESTADO =  " & iSQ_PESSOA_ATESTADO.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\AtestadoMedico.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.AtestadoMedico
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioAtestadoComparecimento - " & ex.Message)
    End Try
  End Sub
  Public Sub FormRelatorioAgendamento(sCodigoAgendamento As String)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT AGEND.CD_AGENDAMENTO," &
                        "AGEND.DH_AGENDAMENTO," &
                        "EMPRE.NO_PESSOA NO_EMPRESA," &
                        "OPCAO_STATUS.NO_OPCAO NO_OPT_STATUS, " &
                        "PACIE.NO_PESSOA NO_PACIENTE," &
                        "PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "CONVE.NO_CONVENIO," &
                        "AGEND.CD_TELEFONE," &
                        "AGEND.CD_CELULAR," &
                        "PROCE.NO_PROCEDIMENTO" &
                  " FROM TB_AGENDAMENTO AGEND" &
                   " INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = AGEND.ID_EMPRESA" &
                   " INNER JOIN TB_OPCAO OPCAO_STATUS ON OPCAO_STATUS.SQ_OPCAO = AGEND.ID_OPT_STATUS" &
                   " INNER JOIN TB_PESSOA PACIE ON PACIE.SQ_PESSOA = AGEND.ID_PESSOA" &
                   " INNER JOIN TB_PESSOA PROFI ON PROFI.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                   " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                   " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO" &
                   " WHERE AGEND.SQ_AGENDAMENTO IN (" & sCodigoAgendamento.ToString() & ")"
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Agendamento.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.Agendamento
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioAgendamento - " & ex.Message)
    End Try
  End Sub
  Public Sub FormRelatorioExameExterno(iSQ_CLINICA_VENDA As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT CONCAT(IIF(PROCE.ID_OPT_TIPOEXAME = 729, CAST(PROCE.SQ_PROCEDIMENTO  AS VARCHAR(10)), '0'), '.', CAST(PESSO_PROFI.SQ_PESSOA AS VARCHAR(10))) IC_QUEBRAPAGINA," &
                        "PESSO_PROFI.SQ_PESSOA SQ_PESSOA_PROFISSIONAL," &
                        "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "ENDER_PROFI.DS_LOGRADOURO_COMPLETO DS_ENDERECO_PROFISSIONAL," &
                        "CLVND.CD_CLINICA_VENDA, " &
                        "ISNULL(CLVND.DS_SOLICITANTE," &
                        "PESSO_SOLIC.NO_PESSOA) DS_SOLICITANTE," &
                        "PESSO.CD_PESSOA," &
                        "PESSO.NO_PESSOA, " &
                        "IIF(CVDPC.ID_CLINICA_VENDA_DEVOLUCAO IS NULL, '', 'ITEM DEVOLVIDO') ITEM_DEVOLVIDO," &
                        "PESSO.DT_NASC_ABERTURA," &
                        "dbo.FC_FormatarCPF_CNPJ(PESSO.CD_CPF_CNPJ) CD_CPF_CNPJ," &
                        "ENDER.DS_LOGRADOURO_COMPLETO," &
                        "ENDER.NO_CIDADE," &
                        "PROCE.NO_PROCEDIMENTO," &
                        "CVDPC.VL_PROCEDIMENTO," &
                        "CVDPC.VL_DESCONTO," &
                        "PESSO_ATEND.NO_PESSOA NO_PESSOA_ATENDENTE," &
                        "CLVND.DH_VENDA," &
                        "AGEND.DH_AGENDAMENTO," &
                        "PESSO.SQ_PESSOA," &
                        "PTLPR.CD_NUMERO CD_TELEFONE," &
                        "ISNULL(MVFNC.VL_ORIGINAL, 0) VL_ORIGINAL," &
                        "ISNULL(MVFNC.VL_DESCONTO, 0) VL_DESCONTO_MOVFINANCEIRA" &
                 " FROM TB_CLINICA_VENDA_PROCEDIMENTO CVDPC" &
                  " INNER JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = CVDPC.ID_CLINICA_VENDA" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVDPC.ID_PROCEDIMENTO" &
                                                  " And PROCE.ID_OPT_TIPOPROCEDIMENTO Not IN (" & enOpcoes.TipoProcedimento_Procedimento.GetHashCode() & ")" &
                  " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CVDPC.ID_PESSOA_PROFISSIONAL" &
                  " INNER JOIN TB_EMPRESA EMPRE ON EMPRE.ID_EMPRESA = CLVND.ID_EMPRESA" &
                  " INNER JOIN TB_PESSOA_EMPRESA PSEMP ON PSEMP.ID_PESSOA = CVDPC.ID_PESSOA_PROFISSIONAL" &
                                                     " And PSEMP.ID_EMPRESA = EMPRE.ID_EMPRESA_MATRIZ" &
                                                     " And ISNULL(PSEMP.IC_PROFISSIONAL_SERVICO_INTERNO, 'N') = 'N'" &
                   " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER_PROFI ON ENDER_PROFI.ID_PESSOA = CVDPC.ID_PESSOA_PROFISSIONAL" &
                                                             " AND ENDER_PROFI.ID_TIPO_ENDERECO = " & enTipoEndereco.Comercial.GetHashCode() &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                  " LEFT JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CVDPC.ID_AGENDAMENTO" &
                  " LEFT JOIN TB_PESSOA PESSO_SOLIC ON PESSO_SOLIC.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                  " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER ON ENDER.ID_PESSOA = CLVND.ID_PESSOA" &
                                                      " AND ENDER.ID_TIPO_ENDERECO = " & enTipoEndereco.Residencial.GetHashCode() &
                  " LEFT JOIN TB_PESSOA PESSO_ATEND ON PESSO_ATEND.SQ_PESSOA = CLVND.ID_PESSOA_ATENDENTE" &
                  " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO PTLPR ON PTLPR.ID_PESSOA = PESSO.SQ_PESSOA" &
                  " LEFT JOIN (SELECT ID_CLINICA_VENDA," &
                                      "SUM(VL_ORIGINAL) VL_ORIGINAL," &
                                      "SUM(VL_DESCONTO) VL_DESCONTO" &
                              " FROM TB_MOVFINANCEIRA" &
                              " WHERE ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                              " GROUP BY ID_CLINICA_VENDA) MVFNC ON MVFNC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                 " WHERE CLVND.SQ_CLINICA_VENDA = " & iSQ_CLINICA_VENDA.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\GuiaExamesExternos.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ExameExterno
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("frmRelatorioGuiaConsulta - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioExameInterno(iSQ_CLINICA_VENDA As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT CVDPC.SQ_CLINICA_VENDA_PROCEDIMENTO," &
                        "IIF(CVDPC.ID_CLINICA_VENDA_DEVOLUCAO IS NULL, '', 'ITEM DEVOLVIDO') ITEM_DEVOLVIDO," &
                        "EMPRE.NO_PESSOA NO_EMPRESA," &
                        "PESSO_PROFI.SQ_PESSOA SQ_PESSOA_PROFISSIONAL," &
                        "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "ENDER.DS_ENDERECO DS_ENDERECO_PROFISSIONAL," &
                        "CLVND.CD_CLINICA_VENDA," &
                        "ISNULL(CLVND.DS_SOLICITANTE, PESSO_SOLIC.NO_PESSOA) DS_SOLICITANTE," &
                        "PESSO.SQ_PESSOA," &
                        "PESSO.NO_PESSOA," &
                        "PESSO.DT_NASC_ABERTURA," &
                        "dbo.FC_FormatarCPF_CNPJ(PESSO.CD_CPF_CNPJ) CD_CPF_CNPJ," &
                        "ENDER.DS_LOGRADOURO_COMPLETO," &
                        "ENDER.NO_CIDADE," &
                        "PROCE.NO_PROCEDIMENTO," &
                        "CVDPC.VL_PROCEDIMENTO," &
                        "CVDPC.VL_DESCONTO," &
                        "CVDPC.VL_PROCEDIMENTO - CVDPC.VL_DESCONTO VL_LIQUIDO," &
                        "PESSO_ATEND.NO_PESSOA NO_PESSOA_ATENDENTE," &
                        "CLVND.DH_VENDA," &
                        "AGEND.DH_AGENDAMENTO," &
                        "AGEND.CD_AGENDAMENTO," &
                        "OPCAO_TPPRC.NO_OPCAO NO_OPT_TIPOPROCEDIMENTO," &
                        "CONVE.NO_CONVENIO," &
                        "PTLPR.CD_NUMERO CD_TELEFONE," &
                        "ISNULL(MVFNC.VL_ORIGINAL, 0) VL_ORIGINAL," &
                        "ISNULL(MVFNC.VL_DESCONTO, 0) VL_DESCONTO_MOVFINANCEIRA" &
                 " FROM TB_CLINICA_VENDA_PROCEDIMENTO CVDPC" &
                  " INNER JOIN TB_CLINICA_VENDA CLVND On CLVND.SQ_CLINICA_VENDA = CVDPC.ID_CLINICA_VENDA" &
                  " INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = CLVND.ID_EMPRESA" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVDPC.ID_PROCEDIMENTO" &
                                                  " And PROCE.ID_OPT_TIPOPROCEDIMENTO Not IN (" & enOpcoes.TipoProcedimento_Procedimento.GetHashCode() & ")" &
                  " INNER JOIN TB_OPCAO OPCAO_TPPRC On OPCAO_TPPRC.SQ_OPCAO = PROCE.ID_OPT_TIPOPROCEDIMENTO" &
                  " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CVDPC.ID_PESSOA_PROFISSIONAL" &
                  " INNER JOIN TB_PESSOA_EMPRESA PSEMP ON PSEMP.ID_PESSOA = CVDPC.ID_PESSOA_PROFISSIONAL" &
                                                    " And ISNULL(PSEMP.IC_PROFISSIONAL_SERVICO_INTERNO, 'N') = 'S'" &
                   " LEFT JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = CLVND.ID_CONVENIO" &
                   " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER_PROFI ON ENDER_PROFI.ID_PESSOA = CVDPC.ID_PESSOA_PROFISSIONAL" &
                                                             " AND ENDER_PROFI.ID_TIPO_ENDERECO = " & enTipoEndereco.Comercial.GetHashCode &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                   " LEFT JOIN TB_AGENDAMENTO AGEND ON (AGEND.SQ_AGENDAMENTO = CVDPC.ID_AGENDAMENTO OR " &
                                                       "AGEND.ID_CLINICA_VENDA_PROCEDIMENTO = CVDPC.SQ_CLINICA_VENDA_PROCEDIMENTO)" &
                   " LEFT JOIN TB_PESSOA PESSO_SOLIC ON PESSO_SOLIC.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                   " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER ON ENDER.ID_PESSOA = CLVND.ID_PESSOA" &
                                                       " AND ENDER.ID_TIPO_ENDERECO = " & enTipoEndereco.Residencial.GetHashCode() &
                   " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO PTLPR ON PTLPR.ID_PESSOA = PESSO.SQ_PESSOA" &
                   " LEFT JOIN TB_PESSOA PESSO_ATEND ON PESSO_ATEND.SQ_PESSOA = CLVND.ID_PESSOA_ATENDENTE" &
                   " LEFT JOIN (SELECT ID_CLINICA_VENDA," &
                                      "SUM(VL_ORIGINAL) VL_ORIGINAL," &
                                      "SUM(VL_DESCONTO) VL_DESCONTO" &
                               " FROM TB_MOVFINANCEIRA" &
                               " WHERE ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                               " GROUP BY ID_CLINICA_VENDA) MVFNC ON MVFNC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                 " WHERE CLVND.SQ_CLINICA_VENDA = " & iSQ_CLINICA_VENDA.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\GuiaExamesInternos.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ExameInterno
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("frmRelatorioGuiaConsulta - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioExameCitologico(iSQ_CLINICA_EXAME_CITOLOGICO As Integer, bImprimir As Boolean)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select CLEXC.CD_CLINICA_EXAME_CITOLOGICO," &
                        "PESSO.CD_PESSOA," &
                        "CONVE.NO_CONVENIO," &
                        "PESSO.NO_PESSOA," &
                        "PESSO.CD_CPF_CNPJ," &
                        "PESSO.SQ_PESSOA," &
                        "PESSO.DATA_NASCIMENTO," &
                        "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') DS_IDADE," &
                        "CLEXC.DS_FILHOS," &
                        "CLEXC.DS_ABORTO," &
                        "ISNULL(CLEXC.DS_MEDICO_EXTERNO, PESSO_PROFI.NO_PESSOA) NO_PESSOA_PROFISSIONAL," &
                        "CLEXC.DS_COLETA," &
                        "CLEXC.DS_UM," &
                        "CLEXC.DS_LOCAL_COLETA," &
                        "CLEXC.DS_ACHADOS_COLPOSCOPICOS," &
                        "CLEXC.IC_DIU" &
                 " FROM TB_CLINICA_EXAME_CITOLOGICO	CLEXC" &
                  " LEFT JOIN TB_CLINICA_ATENDIMENTO CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLEXC.ID_CLINICA_ATENDIMENTO" &
                  " LEFT JOIN (SELECT CV.SQ_CLINICA_VENDA, CV.ID_PESSOA, CV.ID_CONVENIO, CP.ID_PESSOA_PROFISSIONAL
                                FROM TB_CLINICA_VENDA CV
                                 INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CP ON CP.ID_CLINICA_VENDA = CV.SQ_CLINICA_VENDA) CLVND ON CLVND.SQ_CLINICA_VENDA = CLEXC.ID_CLINICA_VENDA" &
                  " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                                             " OR PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                  " LEFT JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                                                   " OR PESSO_PROFI.SQ_PESSOA = CLVND.ID_PESSOA_PROFISSIONAL" &
                  "	LEFT JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                  " LEFT JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO" &
                                              " OR CONVE.SQ_CONVENIO = CLVND.ID_CONVENIO" &
                 " WHERE CLEXC.SQ_CLINICA_EXAME_CITOLOGICO = " & iSQ_CLINICA_EXAME_CITOLOGICO.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\SolicitacaoCitologia.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ExameCitologico
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()

        If bImprimir Then
          Dim autoprintme As AutoPrintCls = New AutoPrintCls(.LocalReport)
          autoprintme.Print()
          autoprintme = Nothing
        Else
          oForm.Show()
        End If
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioExameCitologico - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioExameCitologicoLote(iSQ_CLINICA_EXAME_CITOLOGICO_LOTE As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT CLEXL.CD_CLINICA_EXAME_CITOLOGICO_LOTE," &
                        "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                        "CLEXL.DT_ENVIO," &
                        "CLEXC.CD_CLINICA_EXAME_CITOLOGICO," &
                        "CLATD.CD_CLINICA_ATENDIMENTO," &
                        "PESSO.CD_PESSOA," &
                        "PESSO.NO_PESSOA," &
                        "PESSO.CD_CPF_CNPJ," &
                        "PESSO.SQ_PESSOA," &
                        "PESSO.DT_NASC_ABERTURA," &
                        "ISNULL(CLEXC.DT_CHEGADA, CLEXL.DT_CHEGADA) DT_CHEGADA" &
                 " FROM TB_CLINICA_EXAME_CITOLOGICO_LOTE CLEXL" &
                  " INNER JOIN TB_CLINICA_EXAME_CITOLOGICO CLEXC ON CLEXC.ID_CLINICA_EXAME_CITOLOGICO_LOTE = CLEXL.SQ_CLINICA_EXAME_CITOLOGICO_LOTE" &
                  " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLEXL.ID_PESSOA_PROFISSIONAL" &
                   " LEFT JOIN TB_CLINICA_ATENDIMENTO CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLEXC.ID_CLINICA_ATENDIMENTO" &
                   " LEFT JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = CLEXC.ID_CLINICA_VENDA" &
                   " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                                             " OR PESSO.SQ_PESSOA = CLVND.ID_PESSOA " &
                 " WHERE CLEXL.SQ_CLINICA_EXAME_CITOLOGICO_LOTE = " & iSQ_CLINICA_EXAME_CITOLOGICO_LOTE.ToString()
      oData = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\SolicitacaoCitologiaLote.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ExameCitologico
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dados", oData))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioExameCitologicoLote - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioOrcamentoProcedimentos(iSQ_ORCAMENTO_CLIENTE As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim oDataProcedimentos As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT OCCLI.CD_ORCAMENTO_CLIENTE," &
                        "OCCLI.DH_ORCAMENTO_CLIENTE," &
                        "PESSO.NO_PESSOA," &
                        "PSTEL.CD_NUMERO," &
                        "OCCLI.DT_VALIDADE," &
                        "EMPRE.DS_RODAPE_RELATORIO" &
                 " FROM TB_ORCAMENTO_CLIENTE OCCLI" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = OCCLI.ID_PESSOA" &
                  " INNER JOIN TB_EMPRESA EMPRE ON EMPRE.ID_EMPRESA = OCCLI.ID_EMPRESA" &
                   " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO PSTEL ON PSTEL.ID_PESSOA = OCCLI.ID_PESSOA" &
                   " LEFT JOIN VW_PESSOA_MIDIASOCIAL PSMDS ON PSMDS.ID_PESSOA = OCCLI.ID_PESSOA" &
                 " WHERE OCCLI.SQ_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE.ToString()
      oData = DBQuery(sSqlText)

      sSqlText = "SELECT PROCE.ID_OPT_TIPOEXAME, OPCAO_TPEXM.NO_OPCAO NO_OPT_TIPOEXAME, FORMAT(ROW_NUMBER() OVER(ORDER BY PROCE.NO_PROCEDIMENTO ASC), '000') AS LINHA,PROCE.NO_PROCEDIMENTO,OCPRC.VL_ORCADO" &
                 " FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO OCPRC" &
                  " INNER JOIN TB_ORCAMENTO_CLIENTE OCCLI On OCCLI.SQ_ORCAMENTO_CLIENTE = OCPRC.ID_ORCAMENTO_CLIENTE" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE On PROCE.SQ_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                  " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = OCPRC.ID_OPT_STATUS" &
                  " INNER JOIN TB_OPCAO OPCAO_TPEXM On OPCAO_TPEXM.SQ_OPCAO = PROCE.ID_OPT_TIPOEXAME" &
                   " LEFT JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL" &
                 " WHERE OCCLI.SQ_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE.ToString() &
                   " AND PROCE.ID_OPT_TIPOEXAME = " & enOpcoes.TipoExame_Laboratorial.GetHashCode() &
                " UNION ALL " &
                " SELECT PROCE.ID_OPT_TIPOEXAME, OPCAO_TPEXM.NO_OPCAO NO_OPT_TIPOEXAME, FORMAT(ROW_NUMBER() OVER(ORDER BY PROCE.NO_PROCEDIMENTO ASC), '000') AS LINHA,PROCE.NO_PROCEDIMENTO,OCPRC.VL_ORCADO" &
                 " FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO OCPRC" &
                  " INNER JOIN TB_ORCAMENTO_CLIENTE OCCLI On OCCLI.SQ_ORCAMENTO_CLIENTE = OCPRC.ID_ORCAMENTO_CLIENTE" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                  " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = OCPRC.ID_OPT_STATUS" &
                  " INNER JOIN TB_OPCAO OPCAO_TPEXM ON OPCAO_TPEXM.SQ_OPCAO = PROCE.ID_OPT_TIPOEXAME" &
                   " LEFT JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL" &
                 " WHERE OCCLI.SQ_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE.ToString() &
                   " AND PROCE.ID_OPT_TIPOEXAME = " & enOpcoes.TipoExame_Complementar.GetHashCode() &
                " UNION ALL " &
                " Select PROCE.ID_OPT_TIPOEXAME, OPCAO_TPEXM.NO_OPCAO NO_OPT_TIPOEXAME, FORMAT(ROW_NUMBER() OVER(ORDER BY PROCE.NO_PROCEDIMENTO ASC), '000') AS LINHA,PROCE.NO_PROCEDIMENTO,OCPRC.VL_ORCADO" &
                 " FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO OCPRC" &
                  " INNER JOIN TB_ORCAMENTO_CLIENTE OCCLI ON OCCLI.SQ_ORCAMENTO_CLIENTE = OCPRC.ID_ORCAMENTO_CLIENTE" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                  " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = OCPRC.ID_OPT_STATUS" &
                  " INNER JOIN TB_OPCAO OPCAO_TPEXM ON OPCAO_TPEXM.SQ_OPCAO = PROCE.ID_OPT_TIPOEXAME" &
                   " LEFT JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL" &
                 " WHERE OCCLI.SQ_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE.ToString() &
                   " AND PROCE.ID_OPT_TIPOEXAME = " & enOpcoes.TipoExame_Citologico.GetHashCode() &
                " UNION ALL " &
                " Select PROCE.ID_OPT_TIPOEXAME, OPCAO_TPEXM.NO_OPCAO NO_OPT_TIPOEXAME, Format(ROW_NUMBER() OVER(ORDER BY PROCE.NO_PROCEDIMENTO ASC), '000') AS LINHA,PROCE.NO_PROCEDIMENTO,OCPRC.VL_ORCADO" &
                 " FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO OCPRC" &
                  " INNER JOIN TB_ORCAMENTO_CLIENTE OCCLI ON OCCLI.SQ_ORCAMENTO_CLIENTE = OCPRC.ID_ORCAMENTO_CLIENTE" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                  " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = OCPRC.ID_OPT_STATUS" &
                  " INNER JOIN TB_OPCAO OPCAO_TPEXM ON OPCAO_TPEXM.SQ_OPCAO = PROCE.ID_OPT_TIPOEXAME" &
                   " LEFT JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL" &
                 " WHERE OCCLI.SQ_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE.ToString() &
                   " AND PROCE.ID_OPT_TIPOEXAME = " & enOpcoes.TipoExame_Vacina.GetHashCode()
      oDataProcedimentos = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\Orcamento.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ClinicaOrcamento
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("datGeral", oData))
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("datProcedimentos", oDataProcedimentos))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("frmRelatorioOrcamento - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioOrcamento(iSQ_PEDIDO As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData_Orcamento As DataTable
      Dim oData_Orcamento_PRODUTO As DataTable
      Dim oData_Empresa_Responsavel As DataTable
      Dim sSqlText As String = ""
      Dim sFiltro As String = "-"

      sSqlText = "SELECT * FROM VW_EMPRESA_RESPONSAVEL WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
      oData_Empresa_Responsavel = DBQuery(sSqlText)

      sSqlText = "SELECT PEDID.SQ_PEDIDO," &
                        "PEDID.CD_ORCAMENTO," &
                        "PEDID.DH_PEDIDO," &
                        "PEDID.DT_VALIDADE," &
                        "PESSO.NO_PESSOA NO_CLIENTE," &
                        "dbo.FC_FormatarCPF_CNPJ(PESSO.CD_CPF_CNPJ) CD_CPF_CNPJ," &
                        "ENDER.DS_ENDERECO," &
                        "TELEF.CD_NUMERO CD_TELEFONE," &
                        "VENDE.NO_PESSOA NO_VENDEDOR," &
                        "CNLNG.NO_CANALNEGOCIO," &
                        "SEGMT.NO_SEGMENTO," &
                        "TABPC.NO_TABELAPRECO," &
                        "dbo.FC_EMPRESA_OPCAO_CLAUSULASCTR(2, 614) TX_CLAUSULASCTR" &
                 " FROM VW_PEDIDO PEDID" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PEDID.ID_PESSOA" &
                   " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER ON ENDER.SQ_ENDERECO = PEDID.ID_ENDERECO" &
                                                       " AND ENDER.ID_TIPO_ENDERECO = " & enTipoEndereco.Residencial.GetHashCode().ToString() &
                   " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO TELEF ON TELEF.ID_PESSOA = PEDID.ID_PESSOA" &
                                                              " AND TELEF.ID_TIPO_TELEFONE = " & enTipoTelefone.Residencial.GetHashCode().ToString() &
                   " LEFT JOIN TB_PESSOA VENDE ON VENDE.SQ_PESSOA = PEDID.ID_PESSOA_VENDEDOR" &
                   " LEFT JOIN TB_CANALNEGOCIO CNLNG ON CNLNG.SQ_CANALNEGOCIO = PEDID.ID_CANALNEGOCIO" &
                   " LEFT JOIN TB_TABELAPRECO TABPC ON TABPC.SQ_TABELAPRECO = PEDID.ID_TABELAPRECO" &
                   " LEFT JOIN TB_SEGMENTO SEGMT ON SEGMT.SQ_SEGMENTO = PEDID.ID_SEGMENTO" &
                 " WHERE SQ_PEDIDO = " & iSQ_PEDIDO
      oData_Orcamento = DBQuery(sSqlText)

      sSqlText = "SELECT ISNULL(NO_PRODUTO_LINHA, NO_PRODUTO) NO_PRODUTO," &
                        "IIF(ID_PRODUTO_LINHA IS NULL, dbo.FC_Produto_ProdutoCaracteristica(ID_PRODUTO), dbo.FC_ProdutoLinha_ProdutoCaracteristica(ID_PRODUTO_LINHA)) NO_CARACTERISTICA," &
                        "QT_ORCAMENTO," &
                        "VL_UNITARIO," &
                        "VL_UNITARIO * QT_ORCAMENTO VL_TOTAL" &
                 " FROM VW_PEDIDO_PRODUTO" &
                 " WHERE ID_PEDIDO = " & iSQ_PEDIDO
      oData_Orcamento_PRODUTO = DBQuery(sSqlText)

      With oForm
        If oData_Orcamento.Rows.Count > 0 Then
          sFiltro = "Orçamento: " & oData_Orcamento.Rows(0).Item("CD_ORCAMENTO")
        End If

        .rpvGeral.LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("RPT_Cadastro_Orcamento.rdl")
        .TipoRelatorio = frmReportViewer.enTipoRelatorio.CadastroPaciente
        .rpvGeral.LocalReport.EnableExternalImages = True

        oForm.sFiltro = sFiltro
        oForm.Formatar(False)

        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Responsavel_CPF", FNC_NVL(oData_Empresa_Responsavel.Rows(0).Item("CD_CPF_CNPJ_RESPONSAVEL"), "").ToString()))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Responsavel", FNC_NVL(oData_Empresa_Responsavel.Rows(0).Item("NO_PESSOA_RESPONSAVEL"), "").ToString()))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("ResponsavelTecnico", FNC_NVL(oData_Empresa_Responsavel.Rows(0).Item("NO_PESSOA_RESPONSAVELTECNICO"), "").ToString()))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("ResponsavelTecnico_Registro", FNC_NVL(oData_Empresa_Responsavel.Rows(0).Item("CD_RESPONSAVELTECNICO_CONSELHOPROFISSIONAL"), "").ToString() & " - " &
                                                                                               FNC_NVL(oData_Empresa_Responsavel.Rows(0).Item("NR_RESPONSAVELTECNICO_CONSELHOPROFISSIONAL"), "").ToString()))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("ResponsavelTecnico_Cargo", FNC_NVL(oData_Empresa_Responsavel.Rows(0).Item("NO_RESPONSAVELTECNICO_TIPO_CARGO_RESPONSAVEL"), "").ToString()))

        .rpvGeral.LocalReport.DataSources.Clear()
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("ORCAMENTO", oData_Orcamento))
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("ORCAMENTO_PRODUTO", oData_Orcamento_PRODUTO))
        .rpvGeral.RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioPaciente - " & ex.Message)
    End Try
  End Sub

  Public Sub FormRelatorioOrcamentoFinanciamento(iSQ_PEDIDO As Integer)
    Try
      Dim oForm As New frmReportViewer
      Dim oData_01 As DataTable
      Dim oData_02 As DataTable
      Dim oData_Financiamento As DataTable
      Dim sSqlText As String = ""
      Dim sFiltro As String = "-"
      Dim iCont_01 As Integer
      Dim iCont_02 As Integer
      Dim iCont_03 As Integer
      Dim dPC_JURO_MES As Double
      Dim sParcela_Produto_Desc_01 As String = ""
      Dim sParcela_Produto_Desc_02 As String = ""
      Dim sParcela_Produto_Desc_03 As String = ""
      Dim sParcela_Produto_Desc_04 As String = ""
      Dim dParcela_Produto_Valor_01 As Double = 0
      Dim dParcela_Produto_Valor_02 As Double = 0
      Dim dParcela_Produto_Valor_03 As Double = 0
      Dim dParcela_Produto_Valor_04 As Double = 0
      Dim oRow As DataRow

      oData_Financiamento = New DataTable
      oData_Financiamento.TableName = "ORCAMENTO_FINANCIAMENTO"
      oData_Financiamento.Columns.Add("ID_PEDIDO", GetType(System.Int32))
      oData_Financiamento.Columns.Add("ID_FINANCIAMENTO", GetType(System.Int32))
      oData_Financiamento.Columns.Add("NO_FINANCIAMENTO", GetType(System.String))
      oData_Financiamento.Columns.Add("DS_FINANCIAMENTO", GetType(System.String))
      oData_Financiamento.Columns.Add("CD_ORCAMENTO", GetType(System.String))
      oData_Financiamento.Columns.Add("CD_PEDIDO", GetType(System.String))
      oData_Financiamento.Columns.Add("DH_PEDIDO", GetType(System.DateTime))
      oData_Financiamento.Columns.Add("DT_VALIDADE", GetType(System.DateTime))
      oData_Financiamento.Columns.Add("NO_PESSOA", GetType(System.String))
      oData_Financiamento.Columns.Add("CD_CPF_CNPJ", GetType(System.String))
      oData_Financiamento.Columns.Add("DS_ENDERECO", GetType(System.String))
      oData_Financiamento.Columns.Add("CD_TELEFONE", GetType(System.String))
      oData_Financiamento.Columns.Add("NR_PARCELA", GetType(System.Int32))
      oData_Financiamento.Columns.Add("VL_PRODUTO_01", GetType(System.Double))
      oData_Financiamento.Columns.Add("VL_PRODUTO_02", GetType(System.Double))
      oData_Financiamento.Columns.Add("VL_PRODUTO_03", GetType(System.Double))
      oData_Financiamento.Columns.Add("VL_PRODUTO_04", GetType(System.Double))

      sSqlText = "SELECT NO_PRODUTO, (VL_UNITARIO * QT_ORCAMENTO) VL_ORCAMENTO" &
                 " FROM VW_PEDIDO_PRODUTO" &
                 " WHERE ID_PEDIDO = " & iSQ_PEDIDO
      oData_01 = DBQuery(sSqlText)

      For iCont_01 = 0 To oData_01.Rows.Count - 1
        Select Case iCont_01
          Case 0
            sParcela_Produto_Desc_01 = oData_01.Rows(iCont_01).Item("NO_PRODUTO")
            dParcela_Produto_Valor_01 = oData_01.Rows(iCont_01).Item("VL_ORCAMENTO")
          Case 1
            sParcela_Produto_Desc_02 = oData_01.Rows(iCont_01).Item("NO_PRODUTO")
            dParcela_Produto_Valor_02 = oData_01.Rows(iCont_01).Item("VL_ORCAMENTO")
          Case 2
            sParcela_Produto_Desc_03 = oData_01.Rows(iCont_01).Item("NO_PRODUTO")
            dParcela_Produto_Valor_03 = oData_01.Rows(iCont_01).Item("VL_ORCAMENTO")
          Case 3
            sParcela_Produto_Desc_04 = oData_01.Rows(iCont_01).Item("NO_PRODUTO")
            dParcela_Produto_Valor_04 = oData_01.Rows(iCont_01).Item("VL_ORCAMENTO")
        End Select
      Next

      sSqlText = "SELECT PEDFN.*" &
                 " FROM VW_PEDIDO_FINANCIAMENTO PEDFN" &
                 " WHERE PEDFN.ID_PEDIDO = " & iSQ_PEDIDO
      oData_02 = DBQuery(sSqlText)

      For iCont_01 = 0 To oData_02.Rows.Count - 1
        For iCont_02 = oData_02.Rows(iCont_01).Item("NR_MINIMO_PARCELA") To oData_02.Rows(iCont_01).Item("NR_MAXIMO_PARCELA")
          oRow = oData_Financiamento.NewRow
          oRow("ID_PEDIDO") = iSQ_PEDIDO
          oRow("ID_FINANCIAMENTO") = oData_02.Rows(iCont_01).Item("ID_FINANCIAMENTO")
          oRow("NO_FINANCIAMENTO") = oData_02.Rows(iCont_01).Item("NO_FINANCIAMENTO")
          oRow("DS_FINANCIAMENTO") = oData_02.Rows(iCont_01).Item("DS_FINANCIAMENTO")
          oRow("CD_ORCAMENTO") = oData_02.Rows(iCont_01).Item("CD_ORCAMENTO")
          oRow("CD_PEDIDO") = oData_02.Rows(iCont_01).Item("CD_PEDIDO")
          oRow("DH_PEDIDO") = oData_02.Rows(iCont_01).Item("DH_PEDIDO")
          oRow("DT_VALIDADE") = oData_02.Rows(iCont_01).Item("DT_VALIDADE")
          oRow("NO_PESSOA") = oData_02.Rows(iCont_01).Item("NO_PESSOA")
          oRow("CD_CPF_CNPJ") = oData_02.Rows(iCont_01).Item("CD_CPF_CNPJ")
          oRow("DS_ENDERECO") = oData_02.Rows(iCont_01).Item("DS_ENDERECO")
          oRow("CD_TELEFONE") = oData_02.Rows(iCont_01).Item("CD_TELEFONE")
          oRow("NR_PARCELA") = iCont_02
          dPC_JURO_MES = oData_02.Rows(iCont_01).Item("PC_JUROS") / 100

          For iCont_03 = 0 To oData_01.Rows.Count - 1
            Select Case iCont_03
              Case 0
                oRow("VL_PRODUTO_01") = Financial.Pmt(dPC_JURO_MES, iCont_02, oData_01.Rows(iCont_03).Item("VL_ORCAMENTO")) * -1
              Case 1
                oRow("VL_PRODUTO_02") = Financial.Pmt(dPC_JURO_MES, iCont_02, oData_01.Rows(iCont_03).Item("VL_ORCAMENTO")) * -1
              Case 2
                oRow("VL_PRODUTO_03") = Financial.Pmt(dPC_JURO_MES, iCont_02, oData_01.Rows(iCont_03).Item("VL_ORCAMENTO")) * -1
              Case 3
                oRow("VL_PRODUTO_04") = Financial.Pmt(dPC_JURO_MES, iCont_02, oData_01.Rows(iCont_03).Item("VL_ORCAMENTO")) * -1
            End Select
          Next

          oData_Financiamento.Rows.Add(oRow)
        Next
      Next

      With oForm
        If oData_Financiamento.Rows.Count > 0 Then
          sFiltro = "Orçamento: " & oData_Financiamento.Rows(0).Item("CD_ORCAMENTO")
        End If

        .rpvGeral.LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("RPT_Cadastro_Orcamento_Financiamento.rdl")
        .TipoRelatorio = frmReportViewer.enTipoRelatorio.CadastroPaciente
        .rpvGeral.LocalReport.EnableExternalImages = True

        oForm.sFiltro = sFiltro
        oForm.Formatar(False)

        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Parcela_Produto_Desc_01", sParcela_Produto_Desc_01))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Parcela_Produto_Desc_02", sParcela_Produto_Desc_02))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Parcela_Produto_Desc_03", sParcela_Produto_Desc_03))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Parcela_Produto_Desc_04", sParcela_Produto_Desc_04))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Parcela_Produto_Valor_01", dParcela_Produto_Valor_01))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Parcela_Produto_Valor_02", dParcela_Produto_Valor_02))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Parcela_Produto_Valor_03", dParcela_Produto_Valor_03))
        .rpvGeral.LocalReport.SetParameters(New ReportParameter("Parcela_Produto_Valor_04", dParcela_Produto_Valor_04))

        .rpvGeral.LocalReport.DataSources.Clear()
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("ORCAMENTO_FINANCIAMENTO", oData_Financiamento))
        sSqlText = "SELECT IM_LOGOTIPO FROM TB_EMPRESA WHERE ID_EMPRESA = " + iID_EMPRESA_FILIAL.ToString()
        .rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("EMPRESA", DBQuery(sSqlText)))
        .rpvGeral.RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("FormRelatorioPaciente - " & ex.Message)
    End Try
  End Sub

  'Public Sub btnSavePdf_Click(sTexto As String)
  '  ' Create Document class object and set its size to letter and give space left, right, Top, Bottom Margin
  '  Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
  '  ' Using Savefiledialog

  '  Try
  '    Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream("c:\Temp\Vamos.pdf", FileMode.Create))
  '    ' Open Document to write
  '    doc.Open()

  '    ' Declaring p1 as Paragraph
  '    Dim p1 As New Paragraph
  '    ' setting line spacing between paragraph to 1.
  '    Dim linespacing As Single = 1.0F
  '    ' Setting font for Paragraph to arial
  '    p1.Font = FontFactory.GetFont("ARIAL", 9.0F)
  '    ' Adding RichTextBox to Paragraph
  '    p1.Add(sTexto)
  '    ' Adding Paragraph to Document
  '    doc.Add(p1)

  '    ' Document Closing
  '    doc.Close()


  '  Catch docEx As DocumentException
  '    MessageBox.Show(docEx.Message)
  '    ' handle IO exception
  '  Catch ioEx As IOException
  '    ' hahndle other exception if occurs
  '    MessageBox.Show(ioEx.Message)
  '  Catch ex As Exception
  '    MessageBox.Show(ex.Message)
  '  Finally
  '    'Close document and writer
  '    doc.Close()
  '    MsgBox("pdf Created Successfully")
  '  End Try

  'End Sub
End Module
