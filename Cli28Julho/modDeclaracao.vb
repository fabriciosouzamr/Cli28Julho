Imports System.Xml.Serialization

Public Module modDeclaracao
  Public Enum enFormPesquisaPessoa_Cadastro
    CadastroSimples = 1
    CadastroPessoa = 2
    CadastroPaciente = 3
  End Enum

  Public Enum enOrigemVenda
    OrcamentoClinica = 1
    Agendamento = 2
    SolicitacaoExame = 3
  End Enum

  '> Menu
  Public Const const_Menu_Item_Excel As String = "Excel"
  Public Const const_Menu_Item_PDF As String = "PDF"
  Public Const const_Menu_Item_Word As String = "Word"
  Public Const const_Menu_Item_HTML As String = "HTML"

  Public Const const_ExportarGrid_EnviarEMail As String = "ExportarGrid_EnviarEMail"
  Public Const const_ExportarGrid_ExportarComputador As String = "ExportarGrid_ExportarComputador"

  '>> Constantes
  Public Const const_Clinica_TipoConsulta_Padrao As Integer = 1

  Public Const const_TipoAnexo_Grupo_Anexo As String = "Anexo"
  Public Const const_TipoAnexo_Grupo_Atendimento As String = "ATEND"
  Public Const const_TipoAnexo_Grupo_Impressao As String = "IMPRE"

  Public Const const_Smile_Agendado As Integer = 0
  Public Const const_Smile_Atendido As Integer = 1
  Public Const const_Smile_Atrasado As Integer = 2
  Public Const const_Smile_Cancelado As Integer = 3
  Public Const const_Smile_CanceladoClinica As Integer = 4
  Public Const const_Smile_Compareceu As Integer = 5

  Public Const const_Sistema_ModuloClinica As Boolean = True
  Public Const const_Sistema_ModuloAtendimento As Boolean = True
  Public Const const_Sistema_ModuloOrdemServico As Boolean = True

  Public Const const_Sistema_DicionarioDados_Menu_Data As String = "#SISTEMA DATA#"
  Public Const const_Sistema_DicionarioDados_Menu_Nome As String = "#SISTEMA NOME#"

  Public Const const_Sistema_DicionarioDados_Menu_CalculoMatematico_Adicionar = "#AD00000#"
  Public Const const_Sistema_DicionarioDados_Menu_CalculoMatematico_Subtrair = "#SB00000#"
  Public Const const_Sistema_DicionarioDados_Menu_CalculoMatematico_Multiplicar = "#MT00000#"
  Public Const const_Sistema_DicionarioDados_Menu_CalculoMatematico_Dividir = "#DV00000#"
  Public Const const_Sistema_DicionarioDados_Menu_CalculoMatematico_Porcetagem = "#PC00000#"

  '> Mensagens
  Public Const const_Mensagem_RegistroSistema As String = "Esse é um registro interno do sistema e não pode ser excluído"

  '> Mascaras MaskEditor
  Public Const const_Mascara_CPF As String = "###.###.###-##"
  Public Const const_Mascara_CNPJ As String = "##.###.###/####-##"

  '> Formatação de valores
  Public Const const_Formato_Data As String = "dd/MM/yyyy"
  Public Const const_Formato_DataHoraCurta As String = "dd/MM/yyyy HH:mm"
  Public Const const_Formato_DataHora As String = "dd/MM/yyyy HH:mm:ss"
  Public Const const_Formato_Hora As String = "HH:mm:ss"
  Public Const const_Formato_Valor As String = "R$ ###,###,##0.00"
  Public Const const_Formato_Valor_4casas As String = "R$ ###,###,##0.0000"
  Public Const const_Formato_Valor_US As String = "US$ ###,###,##0.00"
  Public Const const_Formato_Valor_EU As String = "€ ###,###,##0.00"
  Public Const const_Formato_Valor_US_4casas As String = "US$ ###,###,##0.00"
  Public Const const_Formato_Kilos As String = "###,###,##0"
  Public Const const_Formato_NumeroInteiro As String = "########0"
  Public Const const_Formato_Porcentagem As String = "###,###,##0.00 %"
  Public Const const_Formato_Procentagem_4casas As String = "###,###,##0.00"
  Public Const const_Formato_Fracao_Simples As String = "##0.00"
  Public Const const_Formato_Fracao As String = "###,###,##0.00"
  Public Const const_Formato_Fracao_4casas As String = "###,###,##0.00"
  Public Const const_Formato_Fracao_8casas As String = "###,###,##0.00000000"
  Public Const const_Formato_CNPJ As String = "##.###.###/####-##"
  Public Const const_Formato_CPF As String = "###.###.###-##"
  Public Const const_Formato_CEP As String = "#####-###"
  Public Const const_Formato_Imagem As String = "@"

  Public Const const_Legenda_SimNao As Integer = 1

  '> Controles
  'Combo de Usuário
  Public Const const_ComboBox_Usuario_ID_USUARIO As Integer = 0
  Public Const const_ComboBox_Usuario_NO_PESSOA As Integer = 1

  Public Const const_GridAcao_Gravar As Integer = 0
  Public Const const_GridAcao_Excluir As Integer = 1
  Public Const const_GridAcao_Removido As Integer = 2
  Public Const const_GridAcao_Neutro As Integer = 3

  Public Const const_SimNao_Sim As String = "Sim"
  Public Const const_SimNao_Nao As String = "Não"

  Public Const const_Telefone_Origem_Agenda = 1
  Public Const const_Telefone_Origem_CadastroPessoa = 2

  Public Const const_MSG_PagamentoItem_Compensacao_PagtoTerceiro = "PAGAMENTO A TERCEIRO"

  Public Const const_FormaPagamento_Dinheiro = 1
  Public Const const_FormaPagamento_CartaoCredito = 2
  Public Const const_FormaPagamento_CartaoDebito = 3
  Public Const const_FormaPagamento_Cheque = 4
  Public Const const_FormaPagamento_ChequePreDatado = 5
  Public Const const_FormaPagamento_NotaPromissoria = 6
  Public Const const_FormaPagamento_CreditoPessoa As Integer = 7
  Public Const const_FormaPagamento_CreditoCedido As Integer = 8

  Public Const const_EntradaSaida_Entrada As String = "E"
  Public Const const_EntradaSaida_Saida As String = "S"

  Public Const const_NFe_VersaoServico_ve100 = "1.00"
  Public Const const_NFe_VersaoServico_ve200 = "2.00"
  Public Const const_NFe_VersaoServico_ve310 = "3.10"
  Public Const const_NFe_VersaoServico_ve400 = "4.00"

  Public Const const_NFe_ProdutoSemGTIN = "SEM GTIN"

  Public Const const_NFe_ModeloServico_NFe = "55"
  Public Const const_NFe_ModeloServico_NFCe = "65"

  Public Const const_Opcao_Agendamento_Aberto = "A"
  Public Const const_Opcao_Agendamento_Excluido = "E"

  Public Const const_Opcao_MovFinanceira_Aberto = "A"

  Public Const const_PeriodoData_MovFinanceira_Lancamento As Integer = 1
  Public Const const_PeriodoData_MovFinanceira_Quitacao As Integer = 2
  Public Const const_PeriodoData_MovFinanceira_UltimoPagto As Integer = 3
  Public Const const_PeriodoData_MovFinanceira_Vencimento As Integer = 4

  Public Const const_Controle_TamanhoComentario As Int64 = 100000
  Public Const const_Controle_TamanhoComentario_DocumentoFiscal As Int64 = 1000
  Public Const const_BancoDados_TamanhoComentario As Int64 = -1
  Public Const const_BancoDados_TamanhoComentario_DocumentoFiscal As Int64 = 1000

  Public Const const_Formatos_CEP_Tamanho As Integer = 8

  Public Const const_Cliente_OrigemVenda_Atendimento = 1
  Public Const const_Cliente_OrigemVenda_Agendamento = 2
  Public Const const_Cliente_OrigemVenda_OrcamentoCliente = 3

  Public Const const_TipoLancamentoIndicacao_Resgate As String = "R"
  Public Const const_TipoLancamentoIndicacao_Manual As String = "M"
  Public Const const_TipoLancamentoIndicacao_Venda As String = "V"

  Public Integracaos As List(Of modDeclaracaoLocal.Integracao)

  '>> Tela de Geral
  Public Enum enTipoTelaGeral
    CadastroAgenda_Empresa = 2001
    CadastroAgenda_Pessoal = 2002
  End Enum

  '>> Enumeradores
  Public Enum enFormatoHora
    SemHoras = 1
    HHMM = 2
    HHMMSS = 3
    HHMM_Extenso = 4
    HHMMSS_Extenso = 5
  End Enum

  Public Enum enTipoMensagem
    Informacao = 1
    Erro = 2
  End Enum

  Public Enum enBotaoEdicao
    Novo = 1
    Alterar = 2
    Gravar = 3
    Cancelar = 4
    Excluir = 5
  End Enum

  '>> CONTROLES
  '>> ComboBox
  Public Enum enComboBox_DocumentoFiscal_Tipo
    SQ_DOCUMENTOFISCAL_TIPO = 0
    NO_DOCUMENTOFISCAL_TIPO = 1
    CD_SERVICO_MODELO = 2
    CD_SERVICO_VERSAO = 3
    CD_DOCUMENTOFISCAL_TIPO = 4
    ID_OPT_NFE_TIPOOPERACAO = 5
    ID_OPT_EXIGE_PESSOA = 6
    ID_OPT_EXIGE_ENDERECO = 7
  End Enum

  Public Enum enComboBox_PessoaProfissionalFornecedorConvenioProcedimento
    ID_PESSOA_PROFISSIONAL = 0
    NO_PESSOA = 1
    VL_PROCEDIMENTO = 2
    QT_DIAS_REPASSE = 3
    VL_REPASSE = 4
    PC_REPASSE = 5
    IC_ATIVO = 6
    IC_PROFISSIONAL_SERVICO_INTERNO = 7
  End Enum

  Public Enum enComboBox_Financiamento
    SQ_FINANCIAMENTO = 0
    NO_FINANCIAMENTO = 1
    ID_FINANCIADOR = 2
    ID_MODELODOCUMENTO_CONTRATO = 3
    NR_MINIMO_PARCELA = 4
    NR_MAXIMO_PARCELA = 5
    PC_ENTRADA = 6
    PC_JUROS = 7
    ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS = 8
  End Enum

  Public Enum enComboBox_Grupo_E_StatusMovimentacaoFinanceira
    SQ_OPCAO = 0
    NO_OPCAO = 1
    SQ_OPCAO_GRUPO = 2
    CD_OPCAO = 3
  End Enum

  Public Enum enComboBox_Cid
    SQ_CID = 0
    NO_CID = 1
    CD_CID = 2
  End Enum

  Public Enum enComboBox_FormaPagamento
    SQ_FORMAPAGAMENTO = 0
    NO_FORMAPAGAMENTO = 1
    ID_TIPO_DOCUMENTO = 2
    NO_TIPO_DOCUMENTO = 3
  End Enum

  Public Enum enComboBox_Usuario_TipoTela
    PDV = 1
    Empresa = 2
    Permissao = 3
  End Enum

  Public Enum enComboBox_Opcao
    SQ_OPCAO = 0
    NO_OPCAO = 1
    CD_OPCAO = 2
    VL_MULTIPLICADOR = 3
  End Enum

  Public Enum enComboBox_PessoaRrofissionalFornecedorProcedimento
    SQ_PESSOA = 0
    NO_PESSOA = 1
    IC_PROFISSIONAL = 2
    IC_FORNECEDOR = 3
  End Enum

  Public Enum enComboBox_Usuario_Supervisao
    SQ_PESSOA = 0
    NO_PESSOA = 1
    DS_SENHA = 2
  End Enum

  Public Enum enComboBox_Conta
    SQ_CONTA = 0
    NO_CONTA = 1
    VL_SALDO = 2
  End Enum

  Public Enum enComboBox_Turno
    SQ_TURNO = 0
    NO_TURNO = 1
    HR_INICIO = 2
    NR_FIM = 3
  End Enum

  Public Enum enComboBox_ContaFinanceira
    SQ_CONTAFINANCEIRA = 0
    ID_EMPRESA = 1
    ID_TIPO_CONTAFINANCEIRA = 2
    ID_DEPARTAMENTO_RESPONSAVEL = 3
    ID_PESSOA = 4
    ID_BANCO = 5
    ID_MOEDA = 6
    NO_CONTAFINANCEIRA = 7
    NR_AGENCIA = 8
    NR_CONTA = 9
    NR_CONTA_DIGITO = 10
    DT_ABERTURA = 11
    VL_SALDO = 12
    VL_BLOQUEADO = 13
    IC_ATIVO = 14
    IC_SISTEMA = 15
    IC_CONTROLASALDO = 16
    PC_DESCONTO_MAXIMO = 17
  End Enum

  Public Enum enComboBox_ContaCaixa
    SQ_CONTAFINANCEIRA = 0
    NO_CONTAFINANCEIRA = 1
    VL_SALDO = 2
    PC_DESCONTO_MAXIMO = 3
  End Enum

  Public Enum enComboBox_Consultorio
    SQ_CONSULTORIO = 0
    NO_CONSULTORIO = 1
    CD_CONSULTORIO = 2
  End Enum

  Public Enum enComboBox_Procedimento
    SQ_PROCEDIMENTO = 0
    NO_PROCEDIMENTO = 1
    CD_INTEGRACAO_EXAME = 2
    DS_INTEGRACAO_EXAME = 3
    CD_INTEGRACAO_MATERIAL = 4
    DS_INTEGRACAO_MATERIAL = 5
  End Enum


  Public Enum enComboBox_Convenio
    SQ_CONVENIO = 0
    NO_CONVENIO = 1
    IC_CONTROLACREDITO = 2
    IC_SENHA_SUPERVISOR = 3
  End Enum

  Public Enum enComboBox_CanalNegocio
    SQ_CANALNEGOCIO = 0
    NO_CANALNEGOCIO = 1
    ID_CONTABILIZACAO_PADRAO = 2
  End Enum

  Public Enum enComboBox_DiasSemana
    SQ_DIASEMANA = 0
    NO_DIASEMANA = 1
    CD_DIASEMANA = 2
  End Enum

  Public Enum enComBox_Semana
    NR_SEMANA = 0
    DS_SEMANA = 1
    DT_SEMANA_INI = 2
    DT_SEMANA_FIM = 3
  End Enum

  Public Enum enComboBox_Endereco
    SQ_ENDERECO = 0
    DS_ENDERECO = 1
    ID_CIDADE = 2
    ID_UF = 3
    ID_PAIS = 4
  End Enum

  Public Enum enComboBox_CondicaoPagamento
    SQ_CONDICAOPAGAMENTO = 0
    NO_CONDICAOPAGAMENTO = 1
    PC_ACRESCIMO = 2
    PC_ENTRADA = 3
    QT_PARCELA = 4
    ID_FORMAPAGAMENTO_ENTRADA_PADRAO = 5
    ID_FORMAPAGAMENTO_PARCELA_PADRAO = 6
    ID_TIPO_DOCUMENTO_ENTRADA_PADRAO = 7
    ID_TIPO_DOCUMENTO_PARCELA_PADRAO = 8
    QT_PARCELA_DIASPRIMEIRAPARCELA = 9
    QT_PARCELA_DIASINTERVALO = 10
    IC_GERAR_AVISTA = 11
    IC_USAR_RECEBIMENTO = 12
    IC_USAR_VENDA = 13
    PC_TAXA_COMPENSACAO = 14
    IC_ATIVO = 15
  End Enum

  Public Enum enDiasSemanaPessoaHorario
    Domingo = 725
    Segunda = 719
    Terca = 720
    Quarta = 721
    Quinta = 722
    Sexta = 723
    Sabado = 724
    DataEspecial = -1
  End Enum

  Public Enum enComboBox_NaturezaoOperacao
    SQ_NATUREZAOPERACAO = 0
    NO_NATUREZAOPERACAO = 1
    IC_CALCULA_IPI = 2
    ID_OPT_TIPO_REFERENCIA = 3
    IC_CREDITO_ICMS = 4
    IC_DESTACA_IMPOSTOS = 5
    IC_EXIGEPEDIDO = 6
    IC_GERAFINANCEIRO = 7
    IC_MOVIMENTAESTOQUE = 8
    ID_CFOP_DENTROESTADO = 9
    ID_CFOP_FORAESTADO = 10
    ID_CFOP_FORAPAIS = 11
    ID_OPT_FINALIDADE = 12
    ID_OPT_OBRIGATORIEDADE_NUMEROSERIE = 13
    ID_DOCUMENTOFISCAL_TIPO = 14
    ID_DOCUMENTOFISCAL_SERIE = 15
  End Enum

  Public Enum enComboBox_Profissional_Especilidade
    ID_PESSOA = 0
    DS_INFORMACAO = 1
    HR_INICIO = 2
    HR_FIM = 3
    ID_PROCEDIMENTO = 4
  End Enum

  Public Enum enComboBox_TipoDocumento
    SQ_TIPO_DOCUMENTO = 0
    NO_TIPO_DOCUMENTO = 1
    IC_COMPENSAR = 2
    IC_CADASTRAR_DOCUMENTO = 3
    ID_OPT_INSTITUICAO_GERADORA = 4
    IC_CADASTRAR_CONTABANCARIA = 5
  End Enum

  Public Enum enCombox_TipoPessoa_Campos
    SQ_TIPO_PESSOA = 0
    NO_TIPO_PESSOA = 1
    SQ_OPT_FISICO_JURIDICO = 2
  End Enum

  Public Enum enCombox_Cidade
    SQ_CIDADE = 0
    NO_UF_CIDADE = 1
    ID_UF = 2
    ID_PAIS = 3
    CD_UF = 4
    NO_CIDADE = 5
  End Enum

  Public Enum enCombox_Empresa
    ID_EMPRESA = 0
    NO_EMPRESA = 1
    ID_EMPRESA_MATRIZ = 2
    ID_CIDADE = 3
    ID_UF = 4
    ID_PAIS = 5
    CD_CNPJ = 6
    CD_UF = 7
  End Enum

  Public Enum enCombobox_TransacaoEstoque
    SQ_TRANSACAOESTOQUE = 0
    NO_TRANSACAOESTOQUE = 1
    ID_ESTOQUE_CREDITO = 2
    ID_ESTOQUE_DEBITO = 3
    SQ_ESTOQUE_LOCALIZACAO_CREDITO = 4
    SQ_ESTOQUE_LOCALIZACAO_DEBITO = 5
    NO_ESTOQUE_CREDITO = 6
    NO_ESTOQUE_DEBITO = 7
    IC_USAR_RECEBIMENTO = 8
    IC_USAR_VENDA = 9
    IC_USAR_MOVIMENTACAOMANUAL = 10
    IC_ESTOQUE_CREDITO_PERMITE_BLOQUEIO = 11
    IC_ESTOQUE_CREDITO_CONTROLA_MINIMOS = 12
    IC_ESTOQUE_CREDITO_CONTROLA_LOCALIZACAO = 13
    IC_ESTOQUE_CREDITO_PERMITE_SALDO_NEGATIVO = 14
    IC_ESTOQUE_CREDITO_ENTRADA_AUTOMATICA = 15
    IC_ESTOQUE_DEBITO_PERMITE_BLOQUEIO = 16
    IC_ESTOQUE_DEBITO_CONTROLA_MINIMOS = 17
    IC_ESTOQUE_DEBITO_CONTROLA_LOCALIZACAO = 18
    IC_ESTOQUE_DEBITO_PERMITE_SALDO_NEGATIVO = 19
    IC_ESTOQUE_DEBITO_ENTRADA_AUTOMATICA = 20
  End Enum

  Public Enum enCombox_CFOP
    SQ_CFOP = 0
    CD_CFOP = 1
    DS_CFOP = 2
  End Enum

  Public Enum enCombox_CST
    SQ_CST = 0
    CD_CST = 1
    NO_CST = 2
    NO_CSOSN = 3
    CD_CTECF = 4
    CD_CSOSN = 5
  End Enum

  Public Enum enCombox_CSOSN
    SQ_CSOSN = 0
    CD_CSOSN = 1
    DS_CSOSN = 2
  End Enum

  Public Enum enCombox_NCM
    SQ_NCM = 0
    CD_NCM = 1
    DS_NCM = 2
  End Enum

  Public Enum enListagemProduto_Tipo
    Produto = 1
    LinhaProduto = 2
  End Enum

  Public Enum enCombox_Produto
    ID_PRODUTO = 0
    ID_PRODUTO_EMPRESA = 1
    ID_PRODUTO_LINHA = 2
    CD_PRODUTO = 4
    NO_PRODUTO = 5
    TIPO = 6
  End Enum

  Public Enum enLegenda
    SimNao = 1
  End Enum

  Public Enum enLegendaItem
    SimNao_Sim = 1
    SimNao_Nao = 2
  End Enum

  Public Enum enCST_Grupo
    eCST_ICMS = 1
    eCST_PIS_COFINS = 2
    eCST_IPI = 3
  End Enum

  Public Enum enTipoOpcao
    CreditoDebito = 1
    TipoCampo = 2
    FisicoJuridico = 3
    SituacaoProfissional = 4
    TipoQuestionarioClinica = 5
    ExplicacaoSe = 6
    AtivoInativo_Pessoal = 7
    TipoSaidaAtendimentoClinica = 8
    TipoDoenca = 9
    TempoDoenca = 10
    IndicacaoAcidente = 11
    TipoQuestionarioClinicaDadosVitais = 12
    StatusAgendamento = 13
    TipoMovimentacaoFinanceiraRecebePagar = 14
    TipoMovimentacaoFinanceiraContas = 15
    StatusAgendamento_Sistema = 16
    StatusAtendimentoClinica = 17
    StatusMovimentacaoFinanceira = 18
    TipoPagamento = 19
    Finalidade_NFe = 20
    ModalidadeBaseCalculoICMS = 21
    ModalidadeBaseCalculoICMSST = 22
    OrigemProduto = 23
    FronteiraEstados = 24
    MetodoCalcularPrecoVenda = 25
    GrupoStatusMovimentacaoFinanceira = 26
    Disponivel01 = 27
    TipoFrete = 28
    StatusPedido = 29
    NFe_StatusProecssamento = 30
    NFe_FormaPagamento = 31
    NFe_TipoOperacao = 32
    NFe_LocalDestinoOperacao = 33
    NFe_FormatoImpressaoDanfe = 34
    NFe_FormaEmissaoNFe = 35
    NFe_FinalidadeEmissaoNFe = 36
    NFe_OperacaoConsumidorFinal = 37
    NFe_CompradorPresenteOperacao = 38
    NFe_ProcessoEmissao = 39
    NFe_CodigoRegimeTributario = 40
    NFe_IndicadorIEDestinatario = 41
    NFe_ProdutoIncluidoValor = 42
    NFe_TipoItemProduto = 43
    NFe_ModalidadeFrete = 44
    StatusDocumentoFiscal = 45
    StatusItemDocumentoFiscal = 46
    StatusMovimentacaoEstoque = 47
    StatusLancamentoEstoque = 48
    StatusProdutoGarantia = 49
    StatusItemPedido = 50
    TipoProcessamento = 51
    StatusDocumentoFinanceiro = 52
    StatusFluxoCaixa = 53
    TipoInstituicao = 54
    StatusPagamentoItem = 55
    TipoEventoAgendaPessoa = 56
    TipoEventoAgendaEmpresa = 57
    TipoModeloDocumento = 58
    TipoElementoModeloDocumento = 59
    TipoRepositorioArquivo = 60
    TipoItemAgendaGeral = 61
    ModeloFormularioQuestionario = 62
    Questionario_TipoPainel = 63
    Questionario_TipoRespostaExplicacao = 64
    Questionario_TipoComponente = 65
    TipoIndicacao = 66
    TipoEventoAgendaEmpresa_Sistema = 67
    StatusOrdemServico = 68
    TipoOrdemServico = 69
    TipoHistoricoOrdemServico = 70
    TipoCustoPlanoContas = 71
    TipoSegmento = 72
    Processo_Acao = 73
    Processo_Historico = 74
    TipoLiberacaoAgenda = 75
    StatusPagamento = 76
    TipoConvenio = 77
    TipoUnidadeMedida = 78
    TipoRelacaoProduto = 79
    TipoDocumentoFinanceiroCadastrado = 80
    MotivoCancelamentoMovimentacaoFinanceira = 81
    StatusNumeroSeriePedido = 82
    TipoPedido = 83
    TipoControleContabil = 84
    TipoCanalNegocio = 85
    TipoEquipamento = 86
    TipoLancamentoCreditoFinanceiro = 87
    TipoMovimentacaoEstoque = 88
    PermissaoDireitoCredito = 89
    TipoContabilizacaoPlanoContas = 90
    TipoUtilizacaoLançamentoFinanceiro = 91
    TipoFormaPagamento = 92
    ClasseTipoContaFinanceira = 93
    TipoLinhaProduto = 94
    TelaCarregamentoAutomaticoInicializacao = 95
    AmbienteProcessamento = 96
    ObrigatoriedadeNumeroSerie = 97
    TipoEstruturaProduto = 98
    PeriodoCalculoFinanceiro = 99
    TipoIntervalos = 100
    Disponivel02 = 101
    TipoCertificadoDigital = 102
    TipoCalculoValor_CadastroLancamento = 103
    TipoCalculoValor_Lancamento = 104
    VersaoQRCodeNFCe = 105
    ConfigNFCe_DetalheVendaNormal = 106
    ConfigNFCe_DetalheVendaContigencia = 107
    ExibirDocumentoFiscal = 108
    TipoReferenciaNaturezaOperacao = 109
    TipoTransmissaoCupomFiscal = 110
    ModeloSAT = 111
    RegimeTributarioISSQN = 112
    SimNao = 113
    DiasSemana = 114
    TipoProcedimento = 115
    TipoExame = 116
    StatusOrçamentoClinica = 117
    StatusItemOrcamentoClinica = 118
    StatusVendaClinica = 119
    ConfiguracaoTela = 120
    TipoAtestado = 121
    TipoAtecedentes = 122
    StatusExameSolicitado = 123
    TipoFuncao = 124
  End Enum

  Public Enum enOpcoes_NFe_StatusProcessamento
    <XmlEnum("100")> AutorizadoUsoNFe = 100
    <XmlEnum("101")> CancelamentoNFeHomologado = 101
    <XmlEnum("102")> InutilizacaoNumeroHomologado = 102
    <XmlEnum("103")> LoteRecebidoComSucesso = 103
    <XmlEnum("104")> LotePocessado = 104
    <XmlEnum("105")> LoteProcessamento = 105
    <XmlEnum("106")> LoteNaoLocalizado = 106
    <XmlEnum("107")> ServicoSVCOperacao = 107
    <XmlEnum("108")> Rejeicao_ServicoParalisadoMomentaneamente_CurtoPrazo = 108
    <XmlEnum("109")> ServicoParalisadoPrevisao = 109
    <XmlEnum("110")> Rejeicao_UsoDenegado = 110
    <XmlEnum("111")> ConsultaCadastroComUmaOcorrencia = 111
    <XmlEnum("112")> ConsultaCadastroComMaisUmaOcorrencia = 112
    <XmlEnum("113")> SVCProcessoDesativacaoSVCSeraDesabilitadaSEFAZ = 113
    <XmlEnum("114")> SVCDesabilitadaSEFAZOrigem = 114S
    <XmlEnum("128")> LoteEventoProcessado = 128
    <XmlEnum("135")> EventoRegistradoVinculadoNFe = 135
    <XmlEnum("136")> EventoRegistradoMasNaoVinculadoNFe = 136
    <XmlEnum("201")> Rejeicao_ONumeroMaximoNumeracaoNFeAInutilizarUtrapassouLimite = 201
    <XmlEnum("202")> Rejeicao_FalhaReconhecimentoAutoriaIntegridadeArquivoDigital = 202
    <XmlEnum("203")> Rejeicao_EmissorNaoHabilitadoParaEmissaoNFe = 203
    <XmlEnum("204")> Rejeicao_DuplicidadeNFe_999999999999999999999999999999999 = 204
    <XmlEnum("205")> Rejeicao_NFeEstaDenegadaBaseDadosSEFAZ = 205
    <XmlEnum("206")> Rejeicao_NFeJaEstaInutilizadaBaseDadosSEFAZ = 206
    <XmlEnum("207")> Rejeicao_CNPJEmitenteInvalido = 207
    <XmlEnum("208")> Rejeicao_CNPJDestinatarioInvalido = 208
    <XmlEnum("209")> Rejeicao_IE_EmitenteInvalida = 209
    <XmlEnum("210")> Rejeicao_IE_DestinatarioInvalida = 210
    <XmlEnum("211")> Rejeicao_IE_SubstitutoInvalida = 211
    <XmlEnum("212")> Rejeicao_DataEmissaoNFePosteriorDataRecebimento = 212
    <XmlEnum("213")> Rejeicao_CNPJ_BaseEmitenteDifereCNPJ_BaseCertificadoDigital = 213
    <XmlEnum("214")> Rejeicao_TamanhoMensagemExcedeuLimiteEstabelecido = 214
    <XmlEnum("215")> Rejeicao_FalhaSchemaXML = 215
    <XmlEnum("216")> Rejeicao_ChaveAcessoDifereCadastrada = 216
    <XmlEnum("217")> Rejeicao_NFeNaoConstaBaseDadosSEFAZ = 217
    <XmlEnum("218")> Rejeicao_NFeJaEstaCanceladaBaseDadosSEFAZ = 218
    <XmlEnum("219")> Rejeicao_CirculacaoNFeVerificada = 219
    <XmlEnum("220")> Rejeicao_NFeAutorizadaHaMais7Dias_168Horas = 220
    <XmlEnum("221")> Rejeicao_ConfirmadoRecebimentoNFePeloDestinatario = 221
    <XmlEnum("222")> Rejeicao_ProtocoloAutorizacaoUsoDifereCadastrado = 222
    <XmlEnum("223")> Rejeicao_CNPJTransmissorLoteDifereCNPJTransmissorConsulta = 223
    <XmlEnum("224")> Rejeicao_AFaixaInicialMaiorAFaixaFinal = 224
    <XmlEnum("225")> Rejeicao_FalhaSchemaXMLNFe = 225
    <XmlEnum("226")> Rejeicao_CodigoUFEmitenteDivergeUFAutorizadora = 226
    <XmlEnum("227")> Rejeicao_ErroChaveAcesso_CampoIDFaltaLiteralNFe = 227
    <XmlEnum("228")> Rejeicao_DataEmissaoMuitoAtrasada = 228
    <XmlEnum("229")> Rejeicao_IEEmitenteNaoinformada = 229
    <XmlEnum("230")> Rejeicao_IEEmitenteNaocadastrada = 230
    <XmlEnum("231")> Rejeicao_IEEmitenteNaovinculadaCNPJ = 231
    <XmlEnum("232")> Rejeicao_IEDestinatarioNaoinformada = 232
    <XmlEnum("233")> Rejeicao_IEDestinatarioNaocadastrada = 233
    <XmlEnum("234")> Rejeicao_IEDestinatarioNaovinculadaCNPJ = 234
    <XmlEnum("235")> Rejeicao_InscricaoSUFRAMAInvalida = 235
    <XmlEnum("236")> Rejeicao_ChaveAcessoDigitoVerificadorInvalido = 236
    <XmlEnum("237")> Rejeicao_CPFDestinatarioInvalido = 237
    <XmlEnum("238")> Rejeicao_Cabecalho_VersaoArquivoXMLSuperiorVersaoVigente = 238
    <XmlEnum("239")> Rejeicao_Cabecalho_VersaoArquivoXMLNaoSuportada = 239
    <XmlEnum("240")> Rejeicao_CancelamentoInutilizacaoIrregularidadeFiscalEmitente = 240
    <XmlEnum("241")> Rejeicao_UmNumeroDaFaixaJaFoiUtilizado = 241
    <XmlEnum("242")> Rejeicao_Cabecalho_FalhaSchemaXML = 242
    <XmlEnum("243")> Rejeicao_XMLMalFormado = 243
    <XmlEnum("244")> Rejeicao_CNPJCertificadoDigitalDifereCNPJMatrizDoCNPJEmitente = 244
    <XmlEnum("245")> Rejeicao_CNPJEmitenteNaocadastrado = 245
    <XmlEnum("246")> Rejeicao_CNPJDestinatarioNaocadastrado = 246
    <XmlEnum("247")> Rejeicao_SiglaUFEmitenteDivergeUFAutorizadora = 247
    <XmlEnum("248")> Rejeicao_UFReciboDivergeUFAutorizadora = 248
    <XmlEnum("249")> Rejeicao_UFChaveAcessoDivergeUFAutorizadora = 249
    <XmlEnum("250")> Rejeicao_UFDivergeUFAutorizadora = 250
    <XmlEnum("251")> Rejeicao_UFMunicipioDestinatarioNaoPertenceSUFRAMA = 251
    <XmlEnum("252")> Rejeicao_AmbienteInformadoDivergeAmbienteRecebimento = 252
    <XmlEnum("253")> Rejeicao_DigitoVerificadorChaveAcessoCompostaInvalida = 253
    <XmlEnum("254")> Rejeicao_NFeComplementarNaoPossuiNFReferenciada = 254
    <XmlEnum("255")> Rejeicao_NFeComplementarPossuiMaisUmaNFReferenciada = 255
    <XmlEnum("256")> Rejeicao_UmaNFeDaFaixaJaEstaInutilizadaBaseDadosSEFAZ = 256
    <XmlEnum("257")> Rejeicao_SolicitanteNaohabilitadoParaEmissaoNFe = 257
    <XmlEnum("258")> Rejeicao_CNPJConsultaInvalido = 258
    <XmlEnum("259")> Rejeicao_CNPJConsultaNaoCadastradoComoContribuinteUF = 259
    <XmlEnum("260")> Rejeicao_IEConsultaInvalida = 260
    <XmlEnum("261")> Rejeicao_IEConsultaNaocadastradaComoContribuinteUF = 261
    <XmlEnum("262")> Rejeicao_UFNaoForneceConsultaPorCPF = 262
    <XmlEnum("263")> Rejeicao_CPFConsultaInvalido = 263
    <XmlEnum("264")> Rejeicao_CPFConsultaNaoCadastradoComoContribuinteUF = 264
    <XmlEnum("265")> Rejeicao_SiglaUFConsultaDifereUFWebService = 265
    <XmlEnum("266")> Rejeicao_SerieUtilizadaNaoPermitidaWebService = 266
    <XmlEnum("267")> Rejeicao_NFComplementarReferenciaNFeInexistente = 267
    <XmlEnum("268")> Rejeicao_NFComplementarReferenciaOutraNFeComplementar = 268
    <XmlEnum("269")> Rejeicao_CNPJEmitenteNFComplementarDifereCNPJNFReferenciada = 269
    <XmlEnum("270")> Rejeicao_CodigoMunicipioFatoGeradorDigitoInvalido = 270
    <XmlEnum("271")> Rejeicao_CodigoMunicipioFatoGeradorDifereUFEmitente = 271
    <XmlEnum("272")> Rejeicao_CodigoMunicipioEmitenteDigitoInvalido = 272
    <XmlEnum("273")> Rejeicao_CodigoMunicipioEmitenteDifereUFEmitente = 273
    <XmlEnum("274")> Rejeicao_CodigoMunicipioDestinatarioDigitoInvalido = 274
    <XmlEnum("275")> Rejeicao_CodigoMunicipioDestinatarioDifereUFDestinatario = 275
    <XmlEnum("276")> Rejeicao_CodigoMunicipioLocalRetirada_DigitoInvalido = 276
    <XmlEnum("277")> Rejeicao_CodigoMunicipioLocalRetirada_DfereUFLocalRetirada = 277
    <XmlEnum("278")> Rejeicao_CodigoMunicipioLocalEntrega_DigitoInvalido = 278
    <XmlEnum("279")> Rejeicao_CodigoMunicipioLocalEntrega_DifereUFLocalEntrega = 279
    <XmlEnum("280")> Rejeicao_CertificadoTransmissorInvalido = 280
    <XmlEnum("281")> Rejeicao_CertificadoTransmissorDataValidade = 281
    <XmlEnum("282")> Rejeicao_CertificadoTransmissorSemCNPJ = 282
    <XmlEnum("283")> Rejeicao_CertificadoTransmissorErroCadeiaCertificacao = 283
    <XmlEnum("284")> Rejeicao_CertificadoTransmissorRevogado = 284
    <XmlEnum("285")> Rejeicao_CertificadoTransmissorDifereICPBrasil = 285
    <XmlEnum("286")> Rejeicao_CertificadoTransmissorErroAcessoLCR = 286
    <XmlEnum("287")> Rejeicao_CodigoMunicipioFG_ISSQNDigitoInvalido = 287
    <XmlEnum("288")> Rejeicao_CodigoMunicipioFG_TransporteiígitoInvalido = 288
    <XmlEnum("289")> Rejeicao_CodigoInformadaDivergeUFSolicitada = 289
    <XmlEnum("290")> Rejeicao_CertificadoAssinaturaInvalido = 290
    <XmlEnum("291")> Rejeicao_CertificadoAssinaturaDataValidade = 291
    <XmlEnum("292")> Rejeicao_CertificadoAssinaturaSemCNPJ = 292
    <XmlEnum("293")> Rejeicao_CertificadoAssinaturaErroCadeiaCertificacao = 293
    <XmlEnum("294")> Rejeicao_CertificadoAssinaturaRevogado = 294
    <XmlEnum("295")> Rejeicao_CertificadoAssinaturaDifereICPBrasil = 295
    <XmlEnum("296")> Rejeicao_CertificadoAssinaturaErroAcessoLCR = 296
    <XmlEnum("297")> Rejeicao_AssinaturaDifereCalculado = 297
    <XmlEnum("298")> Rejeicao_AssinaturaDiferePadraoProjeto = 298
    <XmlEnum("299")> Rejeicao_XMLAreaCabecalhoComCodificacaoDiferenteUTF8 = 299
    <XmlEnum("301")> UsoDenegadoIrregularidadeFiscalEmitente = 301
    <XmlEnum("302")> UsoDenegadoIrregularidadeFiscalDestinatario = 302
    <XmlEnum("355")> Rejeicao_InformarLocalSaidaDoPaisCasoExportacao
    <XmlEnum("401")> Rejeicao_CPFRemetenteInvalido = 401
    <XmlEnum("402")> Rejeicao_XMLAreaDadosComCodificacaoDiferenteUTF8 = 402
    <XmlEnum("403")> Rejeicao_OGrupoInformacoesNFeAvulsaDeUsoExclusivoFisco = 403
    <XmlEnum("404")> Rejeicao_UsoPrefixoNamespaceNaoPermitido = 404
    <XmlEnum("405")> Rejeicao_CodigoPaisEmitente_DigitoInvalido = 405
    <XmlEnum("406")> Rejeicao_CodigoPaisDestinatario_DigitoInvalido = 406
    <XmlEnum("407")> Rejeicao_OCPFSoPodeSerInformadoCampoEmitenteParaNFeAvulsa = 407
    <XmlEnum("409")> Rejeicao_Campo_cUF_InexistenteElemento_nfeCabecMsgSOAPHeader = 409
    <XmlEnum("410")> Rejeicao_UFInformadaCampo_cUFNao_AtendidaWebService = 410
    <XmlEnum("411")> Rejeicao_CampoVersaoDadosInexistenteElemento_nfeCabecMsgSOAPHeader = 411
    <XmlEnum("453")> Rejeicao_AnoInutilizacaoNaoPodeSersuperiorAnoAtual = 453
    <XmlEnum("454")> Rejeicao_AnoInutilizacaoNaoPodeSerinferior2006 = 454
    <XmlEnum("478")> Rejeicao_LocalEntregaNaoinformadoFaturamentoDiretoVeiculosNovos = 478
    <XmlEnum("502")> Rejeicao_ErroChaveAcesso_CampoIDNaoCorrespondeAConcatenacao = 502
    <XmlEnum("503")> Rejeicao_SerieUtilizadaForaDaFaixaPermitidaSCAN_900_999 = 503
    <XmlEnum("504")> Rejeicao_DataEntradaSaidaPosteriorPermitido = 504
    <XmlEnum("505")> Rejeicao_DataEntradaSaidaAnteriorPermitido = 505
    <XmlEnum("506")> Rejeicao_DataSaidaMenorQueDataEmissao = 506
    <XmlEnum("507")> Rejeicao_OCNPJDestinatarioRemetenteNaoDeveSerInformadoOperacao = 507
    <XmlEnum("508")> Rejeicao_OCPFDestinatarioRemetenteNaoDeveSerInformadoOperacao = 508
    <XmlEnum("509")> Rejeicao_OCNPJConteudoNuloSoValidoOperacaoExterior = 509
    <XmlEnum("510")> Rejeicao_OperacaoExteriorCodigoPaisDestinatario1058_Brasil_ouNao = 510
    <XmlEnum("511")> Rejeicao_NaoOperaçaoExteriorCodigoPaisDestinatarioDifere1058Brasil = 511
    <XmlEnum("512")> Rejeicao_CNPJLocalRetiradaInvalido = 512
    <XmlEnum("513")> Rejeicao_CodigoMunicipioLocalRetiradaDeveSer_9999999_UFRetirada_EX = 513
    <XmlEnum("514")> Rejeicao_CNPJLocalEntregaInvalido = 514
    <XmlEnum("515")> Rejeicao_CodigoMunicipioLocalEntregaDeveSer_9999999_UFEntrega_EX = 515
    <XmlEnum("516")> Rejeicao_ObrigatoriaInformacaoNCM_Genero = 516
    <XmlEnum("517")> Rejeicao_InformacaoNCMDifereInformacaoGenero = 517
    <XmlEnum("518")> Rejeicao_CFOPEntradaNFeSaida = 518
    <XmlEnum("519")> Rejeicao_CFOPSaidaNFeEntrada = 519
    <XmlEnum("520")> Rejeicao_CFOPOperacaoExteriorUFDestinatarioDifereEX = 520
    <XmlEnum("521")> Rejeicao_CFOPNaoEDeOperacaoComExteriorUFDestinatarioEX = 521
    <XmlEnum("522")> Rejeicao_CFOPOperacaoEstadualUFEmitenteDifereUFDestinatario = 522
    <XmlEnum("523")> Rejeicao_CFOPNaoEOperacaoEstadualUFEmitenteIgualUFDestinatario = 523
    <XmlEnum("524")> Rejeicao_CFOPOperacaoComExteriorENaoInformadoNCM = 524
    <XmlEnum("525")> Rejeicao_CFOPImportacaoENaoInformadDadosDI = 525
    <XmlEnum("526")> Rejeicao_CFOPExportacaoENaoInformadoLocalEmbarque = 526
    <XmlEnum("527")> Rejeicao_OperacaoExportacaoComInformacaoICMSIncompativel = 527
    <XmlEnum("528")> Rejeicao_ValorICMSDifereProdutoBCAliquota = 528
    <XmlEnum("529")> Rejeicao_NCMInformacaoObrigatoriaParaProdutoTributadopeloIPI = 529
    <XmlEnum("530")> Rejeicao_OperacaoComTibutacaoISSQNinformarInscricaoMunicipal = 530
    <XmlEnum("531")> Rejeicao_TotalBCICMSDifereSomatorioDosItens = 531
    <XmlEnum("532")> Rejeicao_TotalICMSDifereSomatorioDosItens = 532
    <XmlEnum("533")> Rejeicao_TotalBCICMS_STDifereSomatorioItens = 533
    <XmlEnum("534")> Rejeicao_TotalICMS_STDifereSomatorioItens = 534
    <XmlEnum("535")> Rejeicao_TotalFreteDifereSomatorioItens = 535
    <XmlEnum("536")> Rejeicao_TotalSeguroDifereSomatorioItens = 536
    <XmlEnum("537")> Rejeicao_TotalDescontoDifereSomatorioItens = 537
    <XmlEnum("538")> Rejeicao_TotalIPIDifereSomatorioItens = 538
    <XmlEnum("539")> Rejeicao_DuplicidadeNFecomDiferencaChaveAcesso = 539
    <XmlEnum("540")> Rejeicao_CPFLocalRetiradaInvalido = 540
    <XmlEnum("541")> Rejeicao_CPFLocalEntregaInvalido = 541
    <XmlEnum("542")> Rejeicao_CNPJTransportadorInvalido = 542
    <XmlEnum("543")> Rejeicao_CPFTransportadorInvalido = 543
    <XmlEnum("544")> Rejeicao_IETransportadorInvalido = 544
    <XmlEnum("545")> Rejeicao_NotaFiscalEmitidaContingencia = 545
    <XmlEnum("546")> Rejeicao_ErroChaveAcesso_CampoID_FaltaLiteralNFe = 546
    <XmlEnum("547")> Rejeicao_DígitoVerificadorChaveAcessoNFeReferenciadaInvalido = 547
    <XmlEnum("548")> Rejeicao_CNPJ_NFReferenciadaInvalido = 548
    <XmlEnum("549")> Rejeicao_CNPJ_NFReferenciadaProdutorInvalido = 549
    <XmlEnum("550")> Rejeicao_CPF_NFReferenciadaProdutorInvalido = 550
    <XmlEnum("551")> Rejeicao_IE_NFReferenciadaProdutorInvalido = 551
    <XmlEnum("552")> Rejeicao_DigitoVerificadorChaveAcessoCTeReferenciadoInvalido = 552
    <XmlEnum("553")> Rejeicao_TipoAutorizadorReciboDivergeOrgaoAutorizador = 553
    <XmlEnum("554")> Rejeicao_SerieDifereDaFaixa_0_899 = 554
    <XmlEnum("555")> Rejeicao_TipoAutorizadorProtocoloDivergeOrgaoAutorizador = 555
    <XmlEnum("556")> Rejeicao_JustificativaEntradaContingenciaNaoDeveSerInformadaParaTipo = 556
    <XmlEnum("557")> Rejeicao_AJustificativaEntradaContingenciaDeveSerInformada = 557
    <XmlEnum("558")> Rejeicao_DataEntradaContingenciaPosteriorDataEmissao = 558
    <XmlEnum("559")> Rejeicao_UFTransportadorNaoInformado = 559
    <XmlEnum("560")> Rejeicao_CNPJBaseEmitenteDifereCNPJBasePrimeiraNFeLoteRecebido = 560
    <XmlEnum("561")> Rejeicao_MesEmissaoInformadoChaveAcessoDifereMesEmissaoNFe = 561
    <XmlEnum("562")> Rejeicao_CodigoNumericoInformadoChaveAcessoDifereCodigoNumericoDa = 562
    <XmlEnum("999")> Rejeicao_ErroNaoCatalogadoInformarMensagemErroCapturadoTratamentoDa = 999
    <XmlEnum("124")> EPEC_Autorizado = 124
    <XmlEnum("137")> NenhumDocumentoLocalizadoDestinatario = 137
    <XmlEnum("138")> DocumentoLocalizadoParaDestinatario = 138
    <XmlEnum("139")> PedidoDownloadProcessado = 139
    <XmlEnum("140")> DownloadDisponibilizado = 140
    <XmlEnum("142")> AmbienteContingenciaEPECBloqueadoEmitente = 142
    <XmlEnum("150")> AutorizadoNFeAutorizacaoForaPrazo = 150
    <XmlEnum("151")> CancelamentoNFeHomologadoForaPrazo = 151
    <XmlEnum("303")> UsoDenegado_DestinatarioNaoHabilitadoAOperarNaUF = 303
    <XmlEnum("304")> Rejeicao_PedidoCancelamentoNFeComEventoSuframa = 304
    <XmlEnum("315")> Rejeicao_DataEmissaoAnteriorInicioAutorizacaoNotaFiscalUF = 315
    <XmlEnum("316")> Rejeicao_NotaFiscalReferenciadaComAMesmaChaveAcessoNotaFiscalAtual = 316
    '    <XmlEnum("317")> Rejeição : NF modelo 1 referenciada com data de emissão inválida=317
    '<XmlEnum("318")> Rejeição : Contranota de Produtor sem Nota Fiscal referenciada=318
    '<XmlEnum("319")> Rejeição : Contranota de Produtor não pode referenciar somente Nota Fiscal de entrada=319
    '<XmlEnum("320")> Rejeição : Contranota de Produtor referencia somente NF de outro emitente=320
    '<XmlEnum("321")> Rejeição : NF-e de devolução de mercadoria não possui documento fiscal referenciado=321
    '<XmlEnum("322")> Rejeição : NF de produtor referenciada com data de emissão inválida=322
    '<XmlEnum("323")> Rejeição : CNPJ autorizado para download inválido=323
    '<XmlEnum("324")> Rejeição : CNPJ Do destinatário já autorizado para download=324
    '<XmlEnum("325")> Rejeição : CPF autorizado para download inválido=325
    '<XmlEnum("326")> Rejeição : CPF Do destinatário já autorizado para download=326
    '<XmlEnum("327")> Rejeição : CFOP inválido para Nota Fiscal com finalidade de devolução de mercadoria [nItem:nnn]=327
    '<XmlEnum("328")> Rejeição : CFOP de devolução de mercadoria para NF-e que não tem finalidade de devolução de mercadori=328
    '<XmlEnum("329")> Rejeição : Número da DI /DSI inválido=329
    '<XmlEnum("330")> Rejeição : Informar o Valor da AFRMM na importação por via marítima=330
    '<XmlEnum("331")> Rejeição : Informar o CNPJ Do adquirente ou Do encomendante nesta forma de importação=331
    '<XmlEnum("332")> Rejeição : CNPJ Do adquirente ou Do encomendante da importação inválido=332
    '<XmlEnum("333")> Rejeição : Informar a UF Do adquirente ou Do encomendante nesta forma de importação=333
    '<XmlEnum("334")> Rejeição : Número Do processo de drawback não informado na importação=334
    '<XmlEnum("335")> Rejeição : Número Do processo de drawback na importação inválido=335
    '<XmlEnum("336")> Rejeição : Informado o grupo de exportação no item para CFOP que não é de exportação=336
    '<XmlEnum("337")> Rejeição : NFC-e para emitente pessoa física=337
    '<XmlEnum("338")> Rejeição : Número Do processo de drawback não informado na exportação=338
    '<XmlEnum("339")> Rejeição : Número Do processo de drawback na exportação inválido=339
    '<XmlEnum("340")> Rejeição : Não informado o grupo de exportação indireta no item=340
    '<XmlEnum("341")> Rejeição : Número Do registro de exportação inválido=341
    '<XmlEnum("342")> Rejeição : Chave de Acesso informada na Exportação Indireta com DV inválido=342
    '<XmlEnum("343")> Rejeição : Modelo da NF-e informada na Exportação Indireta diferente de 55=343
    '<XmlEnum("344")> Rejeição : Duplicidade de NF-e informada na Exportação Indireta (Chave de Acesso informada mais de um=344
    '<XmlEnum("345")> Rejeição : Chave de Acesso informada na Exportação Indireta não consta como NF-e referenciada=345
    '<XmlEnum("346")> Rejeição : Somatório das quantidades informadas na Exportação Indiretanão corresponde a quantidade To=346
    '<XmlEnum("347")> Rejeição : Descrição Do combustível diverge da descrição adotada pela ANP=347
    '<XmlEnum("348")> Rejeição : NFC-e com grupo RECOPI=348
    '<XmlEnum("349")> Rejeição : Número RECOPI não informado=349
    '<XmlEnum("350")> Rejeição : Número RECOPI inválido=350
    '<XmlEnum("351")> Rejeição : Valor Do ICMS da Operação no CST=51 difere Do produto BC e Alíquota=351
    '<XmlEnum("352")> Rejeição : Valor Do ICMS Diferido no CST=51 difere Do produto Valor ICMS Operação e percentual diferi=352
    '<XmlEnum("353")> Rejeição : Valor Do ICMS no CST=51 não corresponde a diferença Do ICMS operação e ICMS diferido=353
    '<XmlEnum("354")> Rejeição : Informado grupo de devolução de tributos para NF-e que não tem finalidade de devolução de =354
    '<XmlEnum("356")> Rejeição : Informar o local de saída Do Pais somente no caso da exportação=356
    '<XmlEnum("357")> Rejeição : Chave de Acesso Do grupo de Exportação Indireta inexistente [nRef: xxx]=357
    '<XmlEnum("358")> Rejeição : Chave de Acesso Do grupo de Exportação Indireta cancelada ou denegada [nRef: xxx]=358
    '<XmlEnum("359")> Rejeição : NF-e de venda a Órgão Público sem informar a Nota de Empenho=359
    '<XmlEnum("360")> Rejeição : NF-e com Nota de Empenho inválida para a UF.=360
    '<XmlEnum("361")> Rejeição : NF-e com Nota de Empenho inexistente na UF.=361
    '<XmlEnum("362")> Rejeição : Venda de combustível sem informação Do Transportador=362
    '<XmlEnum("364")> Rejeição : Total Do valor da dedução Do ISS difere Do somatório dos itens=364
    '<XmlEnum("365")> Rejeição : Total de outras retenções difere Do somatório dos itens=365
    '<XmlEnum("366")> Rejeição : Total Do desconto incondicionado ISS difere Do somatório dos itens=366
    '<XmlEnum("367")> Rejeição : Total Do desconto condicionado ISS difere Do somatório dos itens=367
    '<XmlEnum("368")> Rejeição : Total de ISS retido difere Do somatório dos itens=368
    '<XmlEnum("369")> Rejeição : Não informado o grupo avulsa na emissão pelo Fisco=369
    '<XmlEnum("370")> Rejeição : Nota Fiscal Avulsa com tipo de emissão inválido=370
    '<XmlEnum("372")> Rejeição : Destinatário com identificação de estrangeiro com caracteres inválidos=372
    '<XmlEnum("373")> Rejeição : Descrição Do primeiro item diferente de NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO – S=373
    '<XmlEnum("374")> Rejeição : CFOP incompatível com o grupo de tributação [nItem:nnn]=374
    '<XmlEnum("375")> Rejeição : NF-e com CFOP 5929 (Lançamento relativo a Cupom Fiscal) referencia uma NFC-e [nItem:nnn]=375
    '<XmlEnum("376")> Rejeição : Data Do Desembaraço Aduaneiro inválida [nItem:nnn]=376
    '<XmlEnum("378")> Rejeição : Grupo de Combustível sem a informação de Encerrante [nItem:nnn]=378
    '<XmlEnum("379")> Rejeição : Grupo de Encerrante na NF-e (modelo 55) para CFOP diferente de venda de combustível para c=379
    '<XmlEnum("380")> Rejeição : Valor Do Encerrante final não é superior ao Encerrante inicial [nItem:nnn]=380
    '<XmlEnum("381")> Rejeição : Grupo de tributação ICMS90, informando dados Do ICMS-ST [nItem:nnn]=381
    '<XmlEnum("382")> Rejeição : CFOP não permitido para o CST informado [nItem:nnn]=382
    '<XmlEnum("383")> Rejeição : Item com CSOSN indevido [nItem:nnn]=383
    '<XmlEnum("384")> Rejeição : CSOSN não permitido para a UF [nItem:nnn]=384
    '<XmlEnum("385")> Rejeição : Grupo de tributação ICMS900, informando dados Do ICMS-ST [nItem:nnn]=385
    '<XmlEnum("386")> Rejeição : CFOP não permitido para o CSOSN informado [nItem:nnn]=386
    '<XmlEnum("387")> Rejeição : Código de Enquadramento Legal Do IPI inválido [nItem:nnn]=387
    '<XmlEnum("388")> Rejeição : Código de Situação Tributária Do IPI incompatível com o Código de Enquadramento Legal Do I=388
    '<XmlEnum("389")> Rejeição : Código Município ISSQN inexistente [nItem:nnn]=389
    '<XmlEnum("390")> Rejeição : Nota Fiscal com grupo de devolução de tributos [nItem:nnn]=390
    '<XmlEnum("391")> Rejeição : Não informados os dados Do cartão de crédito / débito nas Formas de Pagamento da Nota Fisc=391
    '<XmlEnum("392")> Rejeição : Não informados os dados da operação de pagamento por cartão de crédito / débito=392
    '<XmlEnum("393")> Rejeição : NF-e com o grupo de Informações Suplementares=393
    '<XmlEnum("394")> Rejeição : Nota Fiscal sem a informação Do QR-Code=394
    '<XmlEnum("395")> Rejeição : Endereço Do site da UF da Consulta via QRCode diverge Do previsto=395
    '<XmlEnum("396")> Rejeição : Parâmetro Do QR-Code inexistente (chAcesso)=396
    '<XmlEnum("397")> Rejeição : Parâmetro Do QR-Code divergente da Nota Fiscal (chAcesso)=397
    '<XmlEnum("398")> Rejeição : Parâmetro nVersao Do QR-Code difere Do previsto=398
    '<XmlEnum("399")> Rejeição : Parâmetro de Identificação Do destinatário no QR-Code para Nota Fiscal sem identificação d=399
    '<XmlEnum("400")> Rejeição : Parâmetro Do QR-Code não está no formato hexadecimal (dhEmi)=400
    '<XmlEnum("408")> Rejeição : Evento não disponível para Autor pessoa física=408
    '<XmlEnum("417")> Rejeição : Total Do ICMS superior ao valor limite estabelecido=417
    '<XmlEnum("418")> Rejeição : Total Do ICMS ST superior ao valor limite estabelecido=418
    '<XmlEnum("420")> Rejeição : Cancelamento para NF-e já cancelada=420
    '<XmlEnum("450")> Rejeição : Modelo da NF-e diferente de 55=450
    '<XmlEnum("451")> Rejeição : Processo de emissão informado inválido=451
    '<XmlEnum("452")> Rejeição : Tipo Autorizador Do Recibo diverge Do Órgão Autorizador=452
    '<XmlEnum("455")> Rejeição : Órgão Autor Do evento diferente da UF da Chave de Acesso=455
    '<XmlEnum("461")> Rejeição : Informado percentual de Gás Natural na mistura para produto diferente de GLP=461
    '<XmlEnum("462")> Rejeição : Código Identificador Do CSC no QR-Code não cadastrado na SEFAZ=462
    '<XmlEnum("463")> Rejeição : Código Identificador Do CSC no QR-Code foi revogado pela empresa=463
    '<XmlEnum("464")> Rejeição : Código de Hash no QR-Code difere Do calculado=464
    '<XmlEnum("465")> Rejeição : Número de Controle da FCI inexistente=465
    '<XmlEnum("466")> Rejeição : Evento com Tipo de Autor incompatível=466
    '<XmlEnum("467")> Rejeição : Dados da NF-e divergentes Do EPEC=467
    '<XmlEnum("468")> Rejeição : NF-e com Tipo Emissão = 4, sem EPEC correspondente=468
    '<XmlEnum("471")> Rejeição : Informado NCM=00 indevidamente=471
    '<XmlEnum("476")> Rejeição : Código da UF diverge da UF da primeira NF-e Do Lote=476
    '<XmlEnum("477")> Rejeição : Código Do órgão diverge Do órgão Do primeiro evento Do Lote=477
    '<XmlEnum("479")> Rejeição : Data de Emissão anterior a data de credenciamento ou anterior a Data de Abertura Do estabe=479
    '<XmlEnum("480")> Rejeição : Código Município Do Emitente diverge Do cadastrado na UF=480
    '<XmlEnum("481")> Rejeição : Código Regime Tributário Do emitente diverge Do cadastro na SEFAZ=481
    '<XmlEnum("482")> Rejeição : Código Do Município Do Destinatário diverge Do cadastrado na UF=482
    '<XmlEnum("483")> Rejeição : Valor Do desconto maior que valor Do produto [nItem:nnn]=483
    '<XmlEnum("484")> Rejeição : Chave de Acesso com tipo de emissão diferente de 4 (posição 35 da Chave de Acesso)=484
    '<XmlEnum("485")> Rejeição : Duplicidade de numeração Do EPEC (Modelo, CNPJ, Série e Número)=485
    '<XmlEnum("486")> Rejeição : Não informado o Grupo de Autorização para UF que exige a identificação=486
    '<XmlEnum("487")> Rejeição : Escritório de Contabilidade não cadastrado na SEFAZ=487
    '<XmlEnum("488")> Rejeição : Vendas Do Emitente incompatíveis com o Porte da Empresa=488
    '<XmlEnum("489")> Rejeição : CNPJ informado inválido (DV ou zeros)=489
    '<XmlEnum("490")> Rejeição : CPF informado inválido (DV ou zeros)=490
    '<XmlEnum("491")> Rejeição : O tpEvento informado inválido=491
    '<XmlEnum("492")> Rejeição : O verEvento informado inválido=492
    '<XmlEnum("493")> Rejeição : Evento não atende o Schema XML específico=493
    '<XmlEnum("494")> Rejeição : Chave de Acesso inexistente=494
    '<XmlEnum("496")> Rejeição : Não informado o tipo de integração no pagamento com cartão de crédito / débito=496
    '<XmlEnum("501")> Rejeição : Pedido de Cancelamento intempestivo (NF-e autorizada a mais de 7 dias)=501
    '<XmlEnum("563")> Rejeição : Já existe pedido de Inutilização com a mesma faixa de inutilização=563
    '<XmlEnum("564")> Rejeição : Total Do Produto / Serviço difere Do somatório dos itens=564
    '<XmlEnum("565")> Rejeição : Falha no schema XML – inexiste a tag raiz esperada para o lote de NF-e=565
    '<XmlEnum("567")> Rejeição : Falha no schema XML – versão informada na versaoDados Do SOAPHeader diverge da versão Do l=567
    '<XmlEnum("568")> Rejeição : Falha no schema XML – inexiste atributo versao na tag raiz Do lote de NF-e=568
    '<XmlEnum("569")> Rejeição : Data de entrada em contingência muito atrasada=569
    '<XmlEnum("570")> Rejeição : Tipo de Emissão 3, 6 ou 7 só é válido nas contingências SCAN/SVC=570
    '<XmlEnum("571")> Rejeição : O tpEmis informado diferente de 3 para contingência SCAN=571
    '<XmlEnum("572")> Rejeição : Erro Atributo ID Do evento não corresponde a concatenação dos campos (“ID” + tpEvento + ch=572
    '<XmlEnum("573")> Rejeição : Duplicidade de Evento=573
    '<XmlEnum("574")> Rejeição : O autor Do evento diverge Do emissor da NF-e=574
    '<XmlEnum("575")> Rejeição : O autor Do evento diverge Do destinatário da NF-e=575
    '<XmlEnum("576")> Rejeição : O autor Do evento não é um órgão autorizado a gerar o evento=576
    '<XmlEnum("577")> Rejeição : A data Do evento não pode ser menor que a data de emissão da NF-e=577
    '<XmlEnum("578")> Rejeição : A data Do evento não pode ser maior que a data Do processamento=578
    '<XmlEnum("579")> Rejeição : A data Do evento não pode ser menor que a data de autorização para NF-e não emitida em con=579
    '<XmlEnum("580")> Rejeição : O evento exige uma NF-e autorizada=580
    '<XmlEnum("587")> Rejeição : Usar somente o Namespace padrão da NF-e=587
    '<XmlEnum("588")> Rejeição : Não é permitida a presença de caracteres de edição no início/fim da mensagem ou entre As t=588
    '<XmlEnum("589")> Rejeição : Número Do NSU informado superior ao maior NSU da base de dados da SEFAZ=589
    '<XmlEnum("590")> Rejeição : Informado CST para emissor Do Simples Nacional (CRT=1)=590
    '<XmlEnum("591")> Rejeição : Informado CSOSN para emissor que não é Do Simples Nacional (CRT diferente de 1)=591
    '<XmlEnum("592")> Rejeição : A NF-e deve ter pelo menos um item de produto sujeito ao ICMS=592
    '<XmlEnum("593")> Rejeição : CNPJ-Base consultado difere Do CNPJ-Base Do Certificado Digital=593
    '<XmlEnum("594")> Rejeição : O número de sequencia Do evento informado é maior que o permitido=594
    '<XmlEnum("595")> Rejeição : Obrigatória a informação da justificativa Do evento.=595
    '<XmlEnum("596")> Rejeição : Evento apresentado fora Do prazo: [prazo vigente]=596
    '<XmlEnum("597")> Rejeição: CFOP de Importação e não informado dados de IPI=597
    '<XmlEnum("598")> Rejeição :  NF-e emitida em ambiente de homologação com Razão Social do destinatário diferente de NF-E=598
    '<XmlEnum("599")> Rejeição: CFOP de Importação e não informado dados de II=599
    '<XmlEnum("600")> Rejeição: CSOSN incompatível na operação com Não Contribuinte [nItem:999]=600
    '<XmlEnum("601")> Rejeição :  Total do II difere do somatório dos itens=601
    '<XmlEnum("602")> Rejeição :  Total do PIS difere do somatório dos itens sujeitos ao ICMS=602
    '<XmlEnum("603")> Rejeição :  Total do COFINS difere do somatório dos itens sujeitos ao ICMS=603
    '<XmlEnum("604")> Rejeição :  Total do vOutro difere do somatório dos itens=604
    '<XmlEnum("605")> Rejeição :  Total do vISS difere do somatório do vProd dos itens sujeitos ao ISSQN=605
    '<XmlEnum("606")> Rejeição :  Total do vBC do ISS difere do somatório dos itens=606
    '<XmlEnum("607")> Rejeição :  Total do ISS difere do somatório dos itens=607
    '<XmlEnum("608")> Rejeição :  Total do PIS difere do somatório dos itens sujeitos ao ISSQN=608
    '<XmlEnum("609")> Rejeição :  Total do COFINS difere do somatório dos itens sujeitos ao ISSQN=609
    '<XmlEnum("610")> Rejeição: Total da NF difere Do somatório dos Valores compõe o valor Total da NF.=610
    '<XmlEnum("611")> Rejeição: cEAN inválido = 611
    '  <XmlEnum("612")> Rejeição: cEANTrib inválido = 612
    '  <XmlEnum("613")> Rejeição: Chave de Acesso difere da existente em BD=613
    '<XmlEnum("614")> Rejeição: Chave de Acesso inválida (Código UF inválido)=614
    '<XmlEnum("615")> Rejeição: Chave de Acesso inválida (Ano menor que 06 ou Ano maior que Ano corrente)=615
    '<XmlEnum("616")> Rejeição: Chave de Acesso inválida (Mês menor que 1 ou Mês maior que 12)=616
    '<XmlEnum("617")> Rejeição: Chave de Acesso inválida (CNPJ zerado ou dígito inválido)=617
    '<XmlEnum("618")> Rejeição: Chave de Acesso inválida (modelo diferente de 55 e 65)=618
    '<XmlEnum("619")> Rejeição: Chave de Acesso inválida (número NF = 0)=619
    '<XmlEnum("620")> Rejeição: Chave de Acesso difere da existente em BD=620
    '<XmlEnum("621")> Rejeição: CPF Emitente não cadastrado=621
    '<XmlEnum("622")> Rejeição: IE emitente não vinculada ao CPF=622
    '<XmlEnum("623")> Rejeição: CPF Destinatário não cadastrado=623
    '<XmlEnum("624")> Rejeição: IE Destinatário não vinculada ao CPF=624
    '<XmlEnum("625")> Rejeição: Inscrição SUFRAMA deve ser informada na venda com isenção para ZFM=625
    '<XmlEnum("626")> Rejeição: CFOP de operação isenta para ZFM diferente Do previsto=626
    '<XmlEnum("627")> Rejeição: O valor Do ICMS desonerado deve ser informado=627
    '<XmlEnum("628")> Rejeição: Total da NF superior ao valor limite estabelecido pela SEFAZ [Limite]=628
    '<XmlEnum("629")> Rejeição :  Valor do Produto difere do produto Valor Unitário de Comercialização e Quantidade Comercia=629
    '<XmlEnum("630")> Rejeição :  Valor do Produto difere do produto Valor Unitário de Tributação e Quantidade Tributável=630
    '<XmlEnum("631")> Rejeição :  CNPJ-Base do Destinatário difere do CNPJ-Base do Certificado Digital=631
    '<XmlEnum("632")> Rejeição: Solicitação fora de prazo, a NF-e não está mais disponível para download=632
    '<XmlEnum("633")> Rejeição :  NF-e indisponível para download devido a ausência de Manifestação do Destinatário=633
    '<XmlEnum("634")> Rejeição: Destinatário da NF-e não tem o mesmo CNPJ raiz Do solicitante Do download=634
    '<XmlEnum("635")> Rejeição :  NF-e com mesmo número e série já transmitida e aguardando processamento=635
    '<XmlEnum("650")> Rejeição: Evento de “Ciência da Emissão” para NF-e Cancelada ou Denegada=650
    '<XmlEnum("651")> Rejeição: Evento de “Desconhecimento da Operação” para NF-e Cancelada ou Denegada=651
    '<XmlEnum("653")> Rejeição :  NF-e Cancelada, arquivo indisponível para download=653
    '<XmlEnum("654")> Rejeição :  NF-e Denegada, arquivo indisponível para download=654
    '<XmlEnum("655")> Rejeição: Evento de Ciência da Emissão informado após a manifestação final Do destinatário=655
    '<XmlEnum("656")> Rejeição: Consumo Indevido = 656
    '  <XmlEnum("657")> Rejeição :  Código do Órgão diverge do órgão autorizador=657
    '<XmlEnum("658")> Rejeição :  UF do destinatário da Chave de Acesso diverge da UF autorizadora=658
    '<XmlEnum("660")> Rejeição: CFOP de Combustível e não informado grupo de combustível [nItem:nnn]=660
    '<XmlEnum("661")> Rejeição :  NF-e já existente para o número do EPEC informado=661
    '<XmlEnum("662")> Rejeição :  Numeração do EPEC está inutilizada na Base de Dados da SEFAZ=662
    '<XmlEnum("663")> Rejeição :  Alíquota do ICMS com valor superior a 4 por cento na operação de saída interestadual com p=663
    '<XmlEnum("678")> Rejeição: NF referenciada com UF diferente da NF-e complementar=678
    '<XmlEnum("679")> Rejeição: Modelo de DF-e referenciado inválido=679
    '<XmlEnum("680")> Rejeição: Duplicidade de NF-e referenciada (Chave de Acesso referenciada mais de uma vez)=680
    '<XmlEnum("681")> Rejeição: Duplicidade de NF Modelo 1 referenciada (CNPJ, Modelo, Série e Número)=681
    '<XmlEnum("682")> Rejeição: Duplicidade de NF de Produtor referenciada (IE, Modelo, Série e Número)=682
    '<XmlEnum("683")> Rejeição :  Modelo do CT-e referenciado diferente de 57=683
    '<XmlEnum("684")> Rejeição: Duplicidade de Cupom Fiscal referenciado (Modelo, Número de Ordem e COO)=684
    '<XmlEnum("685")> Rejeição :  Total do Valor Aproximado dos Tributos difere do somatório dos itens=685
    '<XmlEnum("686")> Rejeição: NF Complementar referencia uma NF-e cancelada=686
    '<XmlEnum("687")> Rejeição: NF Complementar referencia uma NF-e denegada=687
    '<XmlEnum("688")> Rejeição: NF referenciada de Produtor com IE inexistente [nRef: xxx]=688
    '<XmlEnum("689")> Rejeição: NF referenciada de Produtor com IE não vinculada ao CNPJ/CPF informado [nRef: xxx]=689
    '<XmlEnum("690")> Rejeição: Pedido de Cancelamento para NF-e com CT-e=690
    '<XmlEnum("691")> Rejeição: Chave de Acesso da NF-e diverge da Chave de Acesso Do EPEC=691
    '<XmlEnum("693")> Rejeição: Alíquota de ICMS superior a definida para a operação interestadual [nItem:999]=693
    '<XmlEnum("694")> Rejeição: Não informado o grupo de ICMS para a UF de destino [nItem:999]=694
    '<XmlEnum("695")> Rejeição: Informado indevidamente o grupo de ICMS para a UF de destino [nItem:999]=695
    '<XmlEnum("697")> Rejeição: Alíquota interestadual Do ICMS com origem diferente Do previsto [nItem:999]=697
    '<XmlEnum("698")> Rejeição: Alíquota interestadual Do ICMS incompatível com As UF envolvidas na operação [nItem:999]=698
    '<XmlEnum("699")> Rejeição :  Percentual do ICMS Interestadual para a UF de destino difere do previsto para o ano da Dat=699
    '<XmlEnum("700")> Rejeição: Mensagem de Lote versão 3.xx. Enviar para o Web Service nfeAutorizacao=700
    '<XmlEnum("701")> Rejeição: Não informado Nota Fiscal referenciada (CFOP de Exportação Indireta)=701
    '<XmlEnum("702")> Rejeição :  NFC-e não é aceita pela UF do Emitente=702
    '<XmlEnum("703")> Rejeição :  Data-Hora de Emissão posterior ao horário de recebimento=703
    '<XmlEnum("704")> Rejeição :  NFC-e com Data-Hora de emissão atrasada=704
    '<XmlEnum("705")> Rejeição :  NFC-e com data de entrada/saída=705
    '<XmlEnum("706")> Rejeição :  NFC-e para operação de entrada=706
    '<XmlEnum("707")> Rejeição :  NFC-e para operação interestadual ou com o exterior=707
    '<XmlEnum("708")> Rejeição :  NFC-e não pode referenciar documento fiscal=708
    '<XmlEnum("709")> Rejeição :  NFC-e com formato de DANFE inválido=709
    '<XmlEnum("710")> Rejeição :  NF-e com formato de DANFE inválido=710
    '<XmlEnum("711")> Rejeição :  NF-e com contingência off-line=711
    '<XmlEnum("712")> Rejeição :  NFC-e com contingência off-line para a UF=712
    '<XmlEnum("713")> Rejeição: Tipo de Emissão diferente de 6 ou 7 para contingência da SVC acessada=713
    '<XmlEnum("714")> Rejeição :  NFC-e com opção de contingência inválida (tpEmis=2, 4 (a critério da UF) ou 5)=714
    '<XmlEnum("715")> Rejeição :  NFC-e com finalidade inválida=715
    '<XmlEnum("716")> Rejeição :  NFC-e em operação não destinada a consumidor final=716
    '<XmlEnum("717")> Rejeição :  NFC-e em operação não presencial=717
    '<XmlEnum("718")> Rejeição :  NFC-e não deve informar IE de Substituto Tributário=718
    '<XmlEnum("719")> Rejeição :  NF-e sem a identificação do destinatário=719
    '<XmlEnum("720")> Rejeição: Na operação com Exterior deve ser informada tag idEstrangeiro=720
    '<XmlEnum("721")> Rejeição: Operação interestadual deve informar CNPJ ou CPF=721
    '<XmlEnum("723")> Rejeição: Operação interna com idEstrangeiro informado deve ser para consumidor final=723
    '<XmlEnum("724")> Rejeição :  NF-e sem o nome do destinatário=724
    '<XmlEnum("725")> Rejeição :  NFC-e com CFOP inválido [nItem:nnn]=725
    '<XmlEnum("726")> Rejeição :  NF-e sem a informação de endereço do destinatário=726
    '<XmlEnum("727")> Rejeição: Operação com Exterior e UF diferente de EX=727
    '<XmlEnum("728")> Rejeição :  NF-e sem informação da IE do destinatário=728
    '<XmlEnum("729")> Rejeição :  NFC-e com informação da IE do destinatário=729
    '<XmlEnum("730")> Rejeição :  NFC-e com Inscrição Suframa=730
    '<XmlEnum("731")> Rejeição: CFOP de operação com Exterior e idDest <> 3=731
    '<XmlEnum("732")> Rejeição: CFOP de operação interestadual e idDest <> 2=732
    '<XmlEnum("733")> Rejeição: CFOP de operação interna e idDest <> 1=733
    '<XmlEnum("734")> Rejeição :  NFC-e com Unidade de Comercialização inválida=734
    '<XmlEnum("735")> Rejeição :  NFC-e com Unidade de Tributação inválida=735
    '<XmlEnum("736")> Rejeição :  NFC-e com grupo de Veículos novos=736
    '<XmlEnum("737")> Rejeição :  NFC-e com grupo de Medicamentos=737
    '<XmlEnum("738")> Rejeição :  NFC-e com grupo de Armamentos=738
    '<XmlEnum("740")> Rejeição: Item com Repasse de ICMS retido por Substituto Tributário [nItem:nnn]=740
    '<XmlEnum("741")> Rejeição :  NFC-e com Partilha de ICMS entre UF=741
    '<XmlEnum("742")> Rejeição :  NFC-e com grupo do IPI=742
    '<XmlEnum("743")> Rejeição :  NFC-e com grupo do II=743
    '<XmlEnum("745")> Rejeição :  NF-e sem grupo do PIS=745
    '<XmlEnum("746")> Rejeição :  NFC-e com grupo do PIS-ST=746
    '<XmlEnum("748")> Rejeição :  NF-e sem grupo da COFINS=748
    '<XmlEnum("749")> Rejeição :  NFC-e com grupo da COFINS-ST=749
    '<XmlEnum("750")> Rejeição :  NFC-e com valor total superior ao permitido para destinatário não identificado (Código) [L=750
    '<XmlEnum("751")> Rejeição :  NFC-e com valor total superior ao permitido para destinatário não identificado (Nome) [Lim=751
    '<XmlEnum("752")> Rejeição :  NFC-e com valor total superior ao permitido para destinatário não identificado (Endereço) =752
    '<XmlEnum("753")> Rejeição :  NFC-e com Frete=753
    '<XmlEnum("754")> Rejeição :  NFC-e com dados do Transportador=754
    '<XmlEnum("755")> Rejeição :  NFC-e com dados de Retenção do ICMS no Transporte=755
    '<XmlEnum("756")> Rejeição :  NFC-e com dados do veículo de Transporte=756
    '<XmlEnum("757")> Rejeição :  NFC-e com dados de Reboque do veículo de Transporte=757
    '<XmlEnum("758")> Rejeição :  NFC-e com dados do Vagão de Transporte=758
    '<XmlEnum("759")> Rejeição :  NFC-e com dados da Balsa de Transporte=759
    '<XmlEnum("760")> Rejeição :  NFC-e com dados de cobrança (Fatura, Duplicata)=760
    '<XmlEnum("761")> Rejeição: Código de Produtos ANP inexistente=761
    '<XmlEnum("762")> Rejeição :  NFC-e com dados de compras (Empenho, Pedido, Contrato)=762
    '<XmlEnum("763")> Rejeição :  NFC-e com dados de aquisição de Cana=763
    '<XmlEnum("764")> Rejeição: Solicitada resposta síncrona para Lote com mais de uma NF-e (indSinc=1)=764
    '<XmlEnum("765")> Rejeição: Lote só poderá conter NF-e ou NFC-e=765
    '<XmlEnum("766")> Rejeição: Item com CST indevido [nItem:nnn]=766
    '<XmlEnum("767")> Rejeição :  NFC-e com somatório dos pagamentos diferente do total da Nota Fiscal=767
    '<XmlEnum("768")> Rejeição :  NF-e não deve possuir o grupo de Formas de Pagamento=768
    '<XmlEnum("769")> Rejeição: A critério da UF NFC-e deve possuir o grupo de Formas de Pagamento=769
    '<XmlEnum("770")> Rejeição :  NFC-e autorizada há mais de 24 horas.=770
    '<XmlEnum("771")> Rejeição: Operação Interestadual e UF de destino com EX=771
    '<XmlEnum("772")> Rejeição: Operação Interestadual e UF de destino igual à UF Do emitente=772
    '<XmlEnum("773")> Rejeição: Operação Interna e UF de destino difere da UF Do emitente=773
    '<XmlEnum("774")> Rejeição :  NFC-e com indicador de item não participante do total=774
    '<XmlEnum("775")> Rejeição: Modelo da NFC-e diferente de 65=775
    '<XmlEnum("776")> Rejeição: Solicitada resposta síncrona para UF que não disponibiliza este atendimento (indSinc=1)=776
    '<XmlEnum("777")> Rejeição: Obrigatória a informação Do NCM completo=777
    '<XmlEnum("778")> Rejeição: Informado NCM inexistente [nItem:nnn]=778
    '<XmlEnum("779")> Rejeição :  NFC-e com NCM incompatível=779
    '<XmlEnum("780")> Rejeição: Total da NFC-e superior ao valor limite estabelecido pela SEFAZ [Limite]=780
    '<XmlEnum("781")> Rejeição: Emissor não habilitado para emissão da NFC-e=781
    '<XmlEnum("782")> Rejeição :  NFC-e não é autorizada pelo SCAN=782
    '<XmlEnum("783")> Rejeição :  NFC-e não é autorizada pela SVC=783
    '<XmlEnum("784")> Rejeição :  NFC-e não permite o evento de Carta de Correção=784
    '<XmlEnum("785")> Rejeição :  NFC-e com entrega a domicílio não permitida pela UF=785
    '<XmlEnum("786")> Rejeição :  NFC-e de entrega a domicílio sem dados do Transportador=786
    '<XmlEnum("787")> Rejeição :  NFC-e de entrega a domicílio sem a identificação do destinatário=787
    '<XmlEnum("788")> Rejeição :  NFC-e de entrega a domicílio sem o endereço do destinatário=788
    '<XmlEnum("789")> Rejeição :  NFC-e para destinatário contribuinte de ICMS=789
    '<XmlEnum("790")> Rejeição: Operação com Exterior para destinatário Contribuinte de ICMS=790
    '<XmlEnum("791")> Rejeição :  NF-e com indicação de destinatário isento de IE, com a informação da IE do destinatário=791
    '<XmlEnum("792")> Rejeição: Informada a IE Do destinatário para operação com destinatário no Exterior=792
    '<XmlEnum("793")> Rejeição :  Valor do ICMS relativo ao Fundo de Combate à Pobreza na UF de destino difere do calculado =793
    '<XmlEnum("794")> Rejeição :  NF-e com indicativo de NFC-e com entrega a domicílio=794
    '<XmlEnum("795")> Rejeição :  Total do ICMS desonerado difere do somatório dos itens=795
    '<XmlEnum("796")> Rejeição: Empresa sem Chave de Segurança para o QR-Code=796
    '<XmlEnum("798")> Rejeição: Valor total Do ICMS relativo Fundo de Combate à Pobreza (FCP) da UF de destino difere Do s=798
    '<XmlEnum("799")> Rejeição: Valor total Do ICMS Interestadual da UF de destino difere Do somatório dos itens=799
    '<XmlEnum("800")> Rejeição: Valor total Do ICMS Interestadual da UF Do remetente difere Do somatório dos itens=800
    '<XmlEnum("805")> Rejeição: A SEFAZ Do destinatário não permite Contribuinte Isento de Inscrição Estadual=805
    '<XmlEnum("806")> Rejeição: Operação com ICMS-ST sem informação Do CEST=806
    '<XmlEnum("807")> Rejeição :   NFC-e com grupo de ICMS para a UF do destinatário=807
  End Enum

  Public Enum enOpcoes
    CreditoDebito_Credito = 1
    CreditoDebito_Debito = 2
    TipoCampo_Data = 3
    TipoCampo_Texto = 4
    TipoCampo_Numero = 5
    FisicoJuridico_Fisico = 6
    FisicoJuridico_Juridico = 7
    SituacaoProfissional_Aposentado = 8
    SituacaoProfissional_ProfissionalLiberal = 9
    SituacaoProfissional_Empresario = 10
    SituacaoProfissional_EmpregadoSetorPrivado = 11
    SituacaoProfissional_EmpregadoSetorPublico = 12
    TipoQuestionarioClinica_Anamnese = 13
    TipoQuestionarioClinicaDadosVitais_SinaisVitais = 14
    TipoQuestionarioClinica_QuestionarioLivre = 15
    ExplicacaoSe_SemExplicacao = 16
    ExplicacaoSe_ExplicacaoSim = 17
    ExplicacaoSe_ExplicacaoNao = 18
    TipoCampo_Legenda_UnicaOpcao = 19
    AtivoInativo_Pessoal_Ativo = 20
    AtivoInativo_Pessoal_Inativo = 21
    AtivoInativo_Pessoal_FalecidoBaixado = 22
    StatusAgendamento_Iniciado = 23
    TipoSaidaAtendimentoClinica_Retorno = 24
    TipoSaidaAtendimentoClinica_RetornoSADT = 25
    TipoSaidaAtendimentoClinica_Referencia = 26
    TipoSaidaAtendimentoClinica_Internacao = 27
    TipoSaidaAtendimentoClinica_Alta = 28
    TipoDoenca_Aguda = 29
    TipoDoenca_Cronica = 30
    TempoDoenca_Ano = 31
    TempoDoenca_Mes = 32
    TempoDoenca_Dia = 33
    IndicacaoAcidente_AcidenteDoencaRelacionadoTrabalho = 34
    IndicacaoAcidente_Transito = 35
    IndicacaoAcidente_Outros = 36
    TipoCampo_Marcacao = 37
    StatusAgendamento_Agendado = 38
    StatusAgendamento_Sistema_ConsultaGerada = 39
    StatusAgendamento_Sistema_Remarcado = 40
    StatusAgendamento_Atendido = 41
    StatusAgendamento_CanceladoPaciente = 42
    StatusAgendamento_CanceladoClinica = 43
    StatusAgendamento_Sistema_CanceladoFalta = 44
    TipoMovimentacaoFinanceiraRecebePagar_ContasReceber = 45
    TipoMovimentacaoFinanceiraRecebePagar_ContasPagar = 46
    TipoMovimentacaoFinanceiraContas_ContaCaixa_Credito = 47
    TipoMovimentacaoFinanceiraContas_ContaCaixa_Debito = 48
    TipoMovimentacaoFinanceiraContas_ContaCaixa_Transferencia = 49
    StatusAtendimentoClinica_EmAtendimento = 50
    StatusAtendimentoClinica_Finalizado = 51
    TipoMovimentacaoFinanceiraContas_ContaCaixa_EnvioDepositoContaBancaria = 52
    TipoMovimentacaoFinanceiraContas_ContaBancaria_Credito = 53
    TipoMovimentacaoFinanceiraContas_ContaBancaria_Debito = 54
    TipoMovimentacaoFinanceiraContas_ContaBancaria_Transferencia = 55
    StatusMovimentacaoFinanceira_Aberta = 56
    StatusMovimentacaoFinanceira_Quitada = 57
    StatusMovimentacaoFinanceira_QuitadaParcialmente = 58
    StatusMovimentacaoFinanceira_EncontroContas = 59
    StatusMovimentacaoFinanceira_Cancelada = 60
    StatusMovimentacaoFinanceira_Estimado = 61
    TipoPagamento_EncontroContas = 62
    TipoPagamento_CreditoCliente = 63
    TipoPagamento_Pagamento = 64
    StatusMovimentacaoFinanceira_ParcialmenteQuitadaEncontroContas = 65
    SituacaoProfissional_DoLar = 66
    SituacaoProfissional_Estudante = 67
    SituacaoProfissional_Consultor = 68
    StatusMovimentacaoFinanceira_Finalizada = 69
    Finalidade_NFe_NFeNormal = 70
    Finalidade_NFe_NFeComplementar = 71
    Finalidade_NFe_NFeAjuste = 72
    Finalidade_NFe_DevolucaoRetorno = 73
    ModalidadeBaseCalculoICMS_MargemValorAgregado = 74
    ModalidadeBaseCalculoICMS_Pauta_Valor = 75
    ModalidadeBaseCalculoICMS_PrecoTabeladoMax_Valor = 76
    ModalidadeBaseCalculoICMS_ValorOperacao = 77
    ModalidadeBaseCalculoICMSST_PrecoTabuladoMaximoSugerido = 78
    ModalidadeBaseCalculoICMSST_ListaNegativa_Valor = 79
    ModalidadeBaseCalculoICMSST_ListaPositiva_Valor = 80
    ModalidadeBaseCalculoICMSST_ListaNeutra_Valor = 81
    ModalidadeBaseCalculoICMSST_MargemValorAgregado = 82
    ModalidadeBaseCalculoICMSST_Pauta_Valor = 83
    OrigemProduto_0Nacional_ExcetoIndicadasCodigos_3_4_5_8 = 84
    OrigemProduto_1Estrangeira_ImportacaoDireta_ExcetoIndicadaCodigo_6 = 85
    OrigemProduto_2Estrangeira_AdquiridaMercadoInterno_ExcetoIndicadaCodigo_7 = 86
    OrigemProduto_3Nacional_MercadoriaBemConteudoImportacaoSuperior_40_InferiorIgual_70 = 87
    OrigemProduto_4Nacional_CujaProducaoTenhaSidoFeitaConformidadeProcessosProdutivosBasicosTratamLegislacoesCitadasAjustes = 88
    OrigemProduto_5Nacional_MercadoriaBemonteudoImportacaInferiorIgual_40 = 89
    OrigemProduto_6Estrangeira_ImportacaoDiretaSemSimilaNacionalConstanteListaCAMEX_GasNatural = 90
    OrigemProduto_7Estrangeira_AdquiridaMercadoInternoSemSimilarNacionalConstanteListaCAMEX_GasNatural = 91
    OrigemProduto_8Nacional_MercadoriaBemConteudoImportacaoSuperior_70 = 92
    FronteiraEstados_DentroEstado = 93
    FronteiraEstados_ForaEstado = 94
    FronteiraEstados_Exterior = 95
    MetodoCalcularPrecoVenda_MetodoPadrao = 96
    MetodoCalcularPrecoVenda_MetodoMarkUp = 97
    MetodoCalcularPrecoVenda_MetodoDistribuidor = 98
    GrupoStatusMovimentacaoFinanceira_Aberta = 99
    GrupoStatusMovimentacaoFinanceira_Fechada = 100
    Disponivel_101 = 101
    Disponivel_102 = 102
    Disponivel_103 = 103
    Disponivel_104 = 104
    Disponivel_105 = 105
    TipoFrete_PorContaEmitente = 106
    TipoFrete_PorContaDestinatario = 107
    TipoFrete_PorContaTerceiros = 108
    TipoFrete_SemFrete = 109
    StatusPedido_Gerada = 110
    StatusPedido_NFeAutorizada = 111
    StatusPedido_Cancelado = 112
    NFe_FormaPagamento_PagamentoAVista = 302
    NFe_FormaPagamento_PagamentoAPrazo = 303
    NFe_FormaPagamento_Outros = 304
    NFe_TipoOperacao_Entrada = 305
    NFe_TipoOperacao_Saida = 306
    NFe_LocalDestinoOperacao_OperacaoInterna = 307
    NFe_LocalDestinoOperacao_OperacaoInterestadual = 308
    NFe_LocalDestinoOperacao_OperacaoExteriorida = 309
    NFe_FormatoImpressaoDanfe_Retrato = 310
    NFe_FormatoImpressaoDanfe_Paisagem = 311
    NFe_FormatoImpressaoDanfe_Simplificado = 312
    NFe_FormatoImpressaoDanfe_DANFE_NFCe = 313
    NFe_FormatoImpressaoDanfe_DANFE_NFCe_MensagemEletronica = 314
    NFe_FormaEmissaoNFe_Normal_EmissaoNormal = 315
    NFe_FormaEmissaoNFe_Contingencia_FS = 316
    NFe_FormaEmissaoNFe_Contingencia_SCAN = 317
    NFe_FormaEmissaoNFe_Contingencia_DPEC = 318
    NFe_FormaEmissaoNFe_Contingencia_FS_DA = 319
    NFe_FormaEmissaoNFe_Contingencia_SVC_AN = 320
    NFe_FormaEmissaoNFe_Contingencia_SVC_RS = 321
    NFe_FormaEmissaoNFe_Contingencia_OffLine = 322
    NFe_FinalidadeEmissaoNFe_NFe_Normal = 323
    NFe_FinalidadeEmissaoNFe_NFe_Complementar = 324
    NFe_FinalidadeEmissaoNFe_NFe_Ajuste = 325
    NFe_FinalidadeEmissaoNFe_Devolucao_Retorno = 326
    NFe_OperacaoConsumidorFinal_Nao = 327
    NFe_OperacaoConsumidorFinal_ConsumidorFinal = 328
    NFe_CompradorPresenteOperacao_NaoAplica = 329
    NFe_CompradorPresenteOperacao_OperacaoPesencial = 330
    NFe_CompradorPresenteOperacao_OperacaoNaoPresencial_pelaInternet = 331
    NFe_CompradorPresenteOperacao_OperacaoNaoPresencial_Teleatendimento = 332
    NFe_CompradorPresenteOperacao_NFCe_OperacaoComEntregaDomicilio = 333
    NFe_CompradorPresenteOperacao_OperacaoNaoPresencial_Outros = 334
    NFe_ProcessoEmissao_Emissao_NFe_AplicativoContribuinte = 335
    NFe_ProcessoEmissao_Emissao_NFe_AvulsaFisco = 336
    NFe_ProcessoEmissao_Emissao_NFe_Avulsa_ContribuinteComCertificadoDigital = 337
    NFe_ProcessoEmissao_EmissaoNFe_ContribuinteAplicativoFornecidoFisco = 338
    NFe_CodigoRegimeTributario_SimplesNacional = 339
    NFe_CodigoRegimeTributario_SimplesNacional_ExcessoSublimiteReceitaBruta = 340
    NFe_CodigoRegimeTributario_RegimeNormal = 341
    NFe_IndicadorIEDestinatario_ContribuinteICMS = 342
    NFe_IndicadorIEDestinatario_ContribuinteIsentoInscricaoCadastroContribuintesICMS = 343
    NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS = 344
    NFe_ProdutoIncluidoValor_ValorItemNaoCompoeValorTotalNFe = 345
    NFe_ProdutoIncluidoValor_ValorItemCompoeValorTotalNFe = 346
    NFe_TipoItemProduto_Veiculos = 347
    NFe_TipoItemProduto_Medicamentos = 348
    NFe_TipoItemProduto_Armamentos = 349
    NFe_TipoItemProduto_Combustivel = 350
    NFe_TipoItemProduto_Servico = 351
    NFe_ModalidadeFrete_PorContaEmitente = 352
    NFe_ModalidadeFrete_PorContaDestinatarioRemetente = 353
    NFe_ModalidadeFrete_PorContaTerceiros = 354
    NFe_ModalidadeFrete_SemFrete = 355
    StatusDocumentoFiscal_Cadastrado = 356
    StatusDocumentoFiscal_Recebido = 357
    StatusDocumentoFiscal_Cancelado = 358
    StatusItemDocumentoFiscal_Incluido = 359
    StatusItemDocumentoFiscal_Cancelado = 360
    StatusMovimentacaoEstoque_Incluida = 361
    StatusMovimentacaoEstoque_Cancelada = 362
    StatusLancamentoEstoque_Incluido = 363
    StatusLancamentoEstoque_Excluido = 364
    StatusProdutoGarantia_EmEstoque = 365
    StatusProdutoGarantia_Vendido = 366
    StatusProdutoGarantia_SeparadoParaTeste = 367
    StatusProdutoGarantia_Manutencao = 368
    StatusProdutoGarantia_Outros = 369
    StatusItemPedido_Incluido = 370
    StatusItemPedido_PedenteAprovacao = 371
    StatusItemPedido_Liberado = 372
    StatusItemDocumentoFiscal_PendenteBaixaEstoque = 373
    StatusItemDocumentoFiscal_Finalizado = 374
    StatusItemDocumentoFiscal_PendenteEstocagem = 375
    StatusDocumentoFinanceiro_Cadastrado = 376
    StatusDocumentoFinanceiro_Compensado = 377
    StatusDocumentoFinanceiro_Cancelado = 378
    StatusFluxoCaixa_Lancamento = 379
    StatusFluxoCaixa_Estorno = 380
    StatusMovimentacaoFinanceira_Compensar = 381
    TipoInstituicao_Bancaria = 382
    StatusPagamentoItem_Compensar = 383
    StatusPagamentoItem_Quitado = 384
    TipoEventoAgendaPessoa_FeriasLicenca = 385
    TipoEventoAgendaPessoa_Diversos = 386
    TipoEventoAgendaPessoa_AssuntoPessoal = 387
    TipoEventoAgendaPessoa_EventoCongressoPalestra = 388
    TipoEventoAgendaPessoa_Reuniao = 389
    TipoEventoAgendaEmpresa_Recesso = 390
    TipoEventoAgendaEmpresa_Diversos = 391
    TipoEventoAgendaEmpresa_EventoCongressoPalestra = 392
    TipoEventoAgendaEmpresa_ReuniaoGeral = 393
    TipoModeloDocumento_Anamnese = 394
    TipoModeloDocumento_Evolucao = 395
    TipoModeloDocumento_Recibo = 396
    TipoModeloDocumento_Receita = 397
    TipoModeloDocumento_Exame = 398
    TipoModeloDocumento_Anexo = 399
    TipoElementoModeloDocumento_Cabecalho = 400
    TipoElementoModeloDocumento_Rodape = 401
    TipoElementoModeloDocumento_Assinatura = 402
    TipoRepositorioArquivo_Imagem = 403
    TipoRepositorioArquivo_Arquivo = 404
    StatusAtendimentoClinica_ConsultaGerada = 405
    TipoModeloDocumento_Contrato = 406
    TipoItemAgendaGeral_AgendaPessoal = 407
    TipoItemAgendaGeral_Agendamento = 408
    TipoItemAgendaGeral_AgendaEmpresa = 409
    TipoEventoAgendaEmpresa_Sistema_Feriado = 410
    TipoEventoAgendaEmpresa_Sistema_OutrosEventos = 411
    ModeloFormularioQuestionario_Listagem = 412
    ModeloFormularioQuestionario_Formulario = 413
    TipoCampo_Legenda_MultiplaOpcao = 414
    Questionario_TipoPainel_Painel = 415
    Questionario_TipoPainel_GroupBox = 416
    Questionario_TipoPainel_TabAba = 417
    Questionario_TipoRespostaExplicacao_Texto = 418
    Questionario_TipoRespostaExplicacao_Numero = 419
    Questionario_TipoPainel_Label = 420
    Questionario_TipoComponente_RotuloPergunta = 421
    Questionario_TipoComponente_CampoPergunta = 422
    Questionario_TipoComponente_RotuloExplicacao = 423
    Questionario_TipoComponente_CampoExplicacao = 424
    Questionario_TipoComponente_LegendaItem = 425
    Questionario_TipoPainel_Painel_Main = 426
    TipoCampo_Imagem = 427
    TipoIndicacao_Internet = 428
    TipoIndicacao_Marketing = 429
    TipoIndicacao_Jornal = 430
    TipoIndicacao_Profissional = 431
    TipoIndicacao_SitePesquisa = 432
    TipoIndicacao_Clientes = 433
    TipoIndicacao_Outros = 434
    StatusProdutoGarantia_BaixadoEstoque = 435
    StatusOrdemServico_Aberta = 436
    StatusOrdemServico_Cancelada = 437
    StatusOrdemServico_PendenteRetornoTerceiro = 438
    StatusOrdemServico_PendentePeca = 439
    StatusOrdemServico_Encerrada = 440
    TipoOrdemServico_ManutencaoProdutoVendido = 441
    TipoOrdemServico_ManutencaoProdutoTerceiro = 442
    TipoHistoricoOrdemServico_InclusaoPecaProduto = 443
    TipoHistoricoOrdemServico_InclusaoServico = 444
    TipoHistoricoOrdemServico_StatusManutencaoLocal = 445
    TipoHistoricoOrdemServico_PendenteProdutoPecaLocal = 446
    TipoHistoricoOrdemServico_EnvioManutencaoTerceiros = 447
    TipoHistoricoOrdemServico_StatusManutencaoTerceiros = 448
    TipoHistoricoOrdemServico_PendenteProdutoPecaTerceiros = 449
    TipoHistoricoOrdemServico_RetornoManutencaoTerceiros = 450
    TipoHistoricoOrdemServico_ServicoConcluido = 451
    TipoHistoricoOrdemServico_ProdutoSemCondicaoReparo = 452
    TipoHistoricoOrdemServico_ProdutoRetiradoCliente = 453
    TipoHistoricoOrdemServico_ProdutoTransitoTerceiros = 454
    TipoHistoricoOrdemServico_DefinicaoTecnicoResponsavelLocal = 455
    TipoHistoricoOrdemServico_ServicoCanceladoPeloCliente = 456
    TipoHistoricoOrdemServico_ServicoCanceladoPelaEmpresa = 457
    StatusOrdemServico_OrcamentoGeradoEsperandoAprovacao = 458
    StatusOrdemServico_OrcamentoReprovado = 459
    TipoHistoricoOrdemServico_InclusaoPecaProdutoGerarOrcamento = 460
    TipoHistoricoOrdemServico_InclusaoServicoGerarOrcamento = 461
    TipoCustoPlanoContas_CustoFixo = 462
    TipoCustoPlanoContas_CustoVariavel = 463
    TipoSegmento_ContasReceberContasPagar = 464
    StatusProdutoGarantia_Emprestado = 465
    TipoMovimentacaoFinanceiraOutros_ContaBancaria_SaqueAporteContaCaixa = 466
    Processo_Acao_Inclusao = 467
    Processo_Acao_Alteracao = 468
    Processo_Acao_Exclusao = 469
    Processo_Acao_Impressao = 470
    Processo_Acao_Consulta = 471
    Processo_Historico_Cadastro_CadastroPessoa = 472
    Processo_Historico_Cadastro_CadastroProfissao = 473
    Processo_Historico_Cadastro_CadastroCargo = 474
    Processo_Historico_Cadastro_CadastroCidade = 475
    Processo_Historico_Cadastro_CadastroUF = 476
    Processo_Historico_Cadastro_CadastroPais = 477
    Processo_Historico_Cadastro_CadastroConvenio = 478
    Processo_Historico_Cadastro_CadastroEmpresa = 479
    Processo_Historico_Disponivel_480 = 480
    Processo_Historico_Disponivel_481 = 481
    Processo_Historico_Agendamento_CadastroOrcamento = 482
    Processo_Historico_Financeiro_Voucher = 483
    Processo_Historico_Cadastro_CadastroEstoque = 484
    Processo_Historico_Cadastro_CadastroTransacaoEstoque = 485
    Processo_Historico_Cadastro_CadastroTabelaPreco = 486
    Processo_Historico_Cadastro_CadastroEspecialidade = 487
    Processo_Historico_Cadastro_CadastroPaciente = 488
    Processo_Historico_Cadastro_CadastroProcedimento = 489
    Processo_Historico_Cadastro_CadastroQuestionario_DadosVitais = 490
    Processo_Historico_Cadastro_CadastroQuestionario_OutrosQuestionario = 491
    Processo_Historico_Cadastro_Configuracao = 492
    Processo_Historico_Cadastro_CadastroBanco = 493
    Processo_Historico_Cadastro_CadastroContaBancaria = 494
    Processo_Historico_Cadastro_CadastroContaCaixa = 495
    Processo_Historico_Cadastro_CadastroFormaPagamento = 496
    Processo_Historico_Cadastro_CadastroPlanoContas = 497
    Processo_Historico_Cadastro_CadastroCFOP = 498
    Processo_Historico_Cadastro_CadastroNaturezaOperacao = 499
    Processo_Historico_Cadastro_CadastroTipoContaBancaria = 500
    Processo_Historico_Cadastro_CadastroTipoContato = 501
    Processo_Historico_Cadastro_CadastroTipoConsulta = 502
    Processo_Historico_Cadastro_CadastroTipoDocumento = 503
    Processo_Historico_Cadastro_CadastroTipoEndereco = 504
    Processo_Historico_Cadastro_CadastroTipoEscolaridade = 505
    Processo_Historico_Cadastro_CadastroTipoEstadoCivil = 506
    Processo_Historico_Cadastro_CadastroTipoMidiaSocial = 507
    Processo_Historico_Cadastro_CadastroTipoPaciente = 508
    Processo_Historico_Cadastro_CadastroTipoPessoa = 509
    Processo_Historico_Cadastro_CadastroTipoProduto = 510
    Processo_Historico_Cadastro_CadastroTipoQuestionario = 511
    Processo_Historico_Cadastro_CadastroTipoRaca = 512
    Processo_Historico_Cadastro_CadastroTipoReferenciaPessoal = 513
    Processo_Historico_Cadastro_CadastroTipoRelegiao = 514
    Processo_Historico_Cadastro_CadastroTipoSexo = 515
    Processo_Historico_Vendas_Lancamento = 516
    Processo_Historico_Cadastro_CadastroGrupoPermissao = 517
    Processo_Historico_Cadastro_CadastroPermissoes = 518
    Processo_Historico_Clinica_Agendamento = 519
    Processo_Historico_Clinica_AtendimentoMedico = 520
    Processo_Historico_Clinica_CadastroAnamnese = 521
    Processo_Historico_Clinica_CadastroPaciente = 522
    Processo_Historico_Financeiro_LancamentoContasaReceber_Pagar = 523
    Processo_Historico_Financeiro_LancamentoContaCaixa_ContaBancaria = 524
    Processo_Historico_Financeiro_Compensacao = 525
    Processo_Historico_CompraseVendas_Compras = 526
    Processo_Historico_CompraseVendas_PedidoVendas = 527
    Processo_Historico_CompraseVendas_MovimentarEstoque = 528
    Processo_Historico_CompraseVendas_ProdutoGarantia = 529
    Processo_Historico_RelatorioAgendamento = 530
    Processo_Historico_RelatorioAtendimento = 531
    Processo_Historico_RelatorioListagemPessoa = 532
    Processo_Historico_RelatorioListagemProduto = 533
    Processo_Historico_RelatorioTabelaPreco = 534
    Processo_Historico_RelatorioContaFinanceira = 535
    Processo_Historico_RelatorioFluxoCaixa = 536
    Processo_Historico_RelatorioLancamentoContasaPagar_Receber = 537
    Processo_Historico_RelatorioLancamentoFluxoCaixa = 538
    Processo_Historico_RelatorioCompensacao = 539
    Processo_Historico_RelatorioCompras = 540
    Processo_Historico_RelatorioPedidoVenda = 541
    Processo_Historico_RelatorioProdutoGarantia = 542
    Processo_Historico_RelatorioMovimentacaoEstoque = 543
    Processo_Historico_RelatorioSaldoEstoque = 544
    Processo_Historico_RelatorioListagemUsuario = 545
    Processo_Historico_Clinica_CadastroConsulta = 546
    Processo_Historico_Cadastro_AgendaEmpresa = 547
    Processo_Historico_Cadastro_CadastroModeloDocumento = 548
    Processo_Historico_Utilitario_RepositorioArquivo = 549
    Processo_Historico_PermissaoparaFormacaoPreco_PrecoCusto = 550
    Processo_Historico_PermissaoparaFormacaoPreco_Impostos = 551
    Processo_Historico_RelatorioCardex = 552
    Processo_Historico_CompraseVendas_OrdemServico = 553
    Processo_Historico_PermissaoparaCancelamentoOrdemServico = 554
    Processo_Historico_Cadastro_ConfiguracaoOrdemServico = 555
    Processo_Historico_Cadastro_CadastroServico = 556
    Processo_Historico_Cadastro_CadastroTipoServico = 557
    Processo_Historico_RelatorioOrdemServico = 558
    Processo_Historico_Cadastro_GrupoPlanoContas = 559
    Processo_Historico_Cadastro_SegmentoContasaRecebereContasaPagar = 560
    Processo_Historico_RelatorioLancamentoemPlanoContascomValores = 561
    Processo_Historico_RelatorioPlanoContas = 562
    Processo_Historico_PermissaoparaBloquearDianaAgendadaEmpresa = 563
    Processo_Historico_Cadastro_CadastroElementoModeloDocumento = 564
    Processo_Historico_Cadastro_CadastroNotaFiscalEntrada = 565
    Processo_Historico_PermissaoparaGerarFinanceiroOrdemServico = 566
    Processo_Historico_PermissaoparaGerarContratoparaOrdemServico = 567
    Processo_Historico_UtilitarioAgenda = 568
    StatusAgendamento_AguardandoPagamento = 569
    TipoOrdemServico_ServicoProprioEstabelecimento = 570
    TipoOrdemServico_ServicoPrestadoTerceiros = 571
    TipoSegmento_OrdemServico = 572
    TipoLiberacaoAgenda_Leitura = 573
    TipoLiberacaoAgenda_Edicao = 574
    StatusProdutoGarantia_DoacaoSimilares = 575
    StatusProdutoGarantia_DescarteSucata = 576
    StatusProdutoGarantia_PerdaRoubo = 577
    StatusAgendamento_Informativo = 578
    StatusPagamento_Incluido = 579
    StatusPagamento_Cancelado = 580
    StatusAgendamento_Confirmado = 581
    TipoConvenio_Particular = 582
    TipoConvenio_Publico = 583
    TipoConvenio_Empresarial = 584
    TipoUnidadeMedida_Comprimento = 585
    TipoUnidadeMedida_Massa = 586
    TipoUnidadeMedida_Quilograma = 587
    TipoUnidadeMedida_Area = 588
    TipoUnidadeMedida_Volume = 589
    TipoRelacaoProduto_AdicionarVenda = 590
    StatusDocumentoFinanceiro_Negociado = 591
    StatusPagamentoItem_Negociado = 592
    TipoDocumentoFinanceiroCadastrado_EmitidoTerceiros = 593
    TipoDocumentoFinanceiroCadastrado_EmitidoPropriaEmpresaSocios = 594
    NFe_FormatoImpressaoDanfe_SempImpressaoDanfe = 595
    PermissaoDireitoCredito_SemPermissao = 596
    StatusNumeroSeriePedidoVenda_Incluido = 597
    StatusNumeroSeriePedidoVenda_Cancelado = 598
    StatusNumeroSeriePedidoVenda_Rejeitado = 599
    StatusNumeroSeriePedidoVenda_Faturado = 600
    TipoPedido_PedidoVenda = 601
    TipoPedido_PedidoCompra = 602
    PermissaoDireitoCredito_PermissaoCedida = 603
    TipoControleContabil_ControleDiario = 604
    TipoControleContabil_ControleSemanal = 605
    TipoControleContabil_ControleQuizenal = 606
    TipoControleContabil_ControleMensal = 607
    TipoControleContabil_ControleAnual = 608
    TipoControleContabil_DataEspecifica = 609
    StatusPedido_ParcialmenteFaturado = 610
    StatusPedido_Faturado = 611
    StatusItemPedido_ParcialmenteFaturado = 612
    StatusItemPedido_Faturado = 613
    TipoPedido_OrcamentoVenda = 614
    TipoCanalNegocio_CanalNegociosVenda = 615
    TipoCanalNegocio_CanalNegociosCompras = 616
    TipoPedido_OrcamentoCompra = 617
    TipoProcessamento_ACBrMonitor = 618
    TipoEquipamento_ECFNaoFiscal = 619
    StatusItemPedido_Cancelado = 620
    TipoLancamentoCreditoFinanceiro_Credito = 621
    TipoLancamentoCreditoFinanceiro_Debito = 622
    TipoLancamentoCreditoFinanceiro_EstornoCredito = 623
    TipoLancamentoCreditoFinanceiro_EstornoDebito = 624
    TipoMovimentacaoEstoque_AjusteEstoque = 625
    TipoMovimentacaoEstoque_DoacaoBrinde = 626
    StatusDocumentoFiscal_DocumentoFiscalGerado = 627
    PermissaoDireitoCredito_CreditoProprio = 628
    TipoEquipamento_Computador = 629
    TipoProcessamento_Agente = 630
    TipoContabilizacaoPlanoContas_PorFormaPagamento = 631
    TipoContabilizacaoPlanoContas_PorParticipacao = 632
    TipoPedido_VendaDireta = 633
    TipoUtilizacaoLançamentoFinanceiro_NaoSeAplica = 634
    TipoUtilizacaoLançamentoFinanceiro_UsarLancamento = 635
    TipoUtilizacaoLançamentoFinanceiro_UsarPagamento = 636
    TipoFormaPagamento_Normal = 637
    TipoFormaPagamento_CreditoPessoa = 638
    ClasseTipoContaFinanceira_ContaCaixa = 639
    ClasseTipoContaFinanceira_ContaBancaria = 640
    TipoLinhaProduto_LinhaVenda = 641
    TelaCarregamentoAutomaticoInicializacao_AgendaPessoal = 642
    TelaCarregamentoAutomaticoInicializacao_Agendamento = 643
    TelaCarregamentoAutomaticoInicializacao_AtendimentoMedico = 644
    StatusMovimentacaoFinanceira_ParcialmenteQuitadaCancelada = 645
    StatusMovimentacaoFinanceira_ParcialmenteQuitadaRenegociada = 646
    StatusMovimentacaoFinanceira_Renegociada = 647
    Processo_Acao_Transmissao = 648
    Processo_Historico_Cadastro_CadastroDocumentoFiscal = 649
    StatusDocumentoFiscal_Transmitindo = 650
    AmbienteProcessamento_Producao = 651
    AmbienteProcessamento_Homologacao = 652
    ObrigatoriedadeNumeroSerie_ObrigadoSerInformado = 653
    ObrigatoriedadeNumeroSerie_NaoObrigadoASerInformado = 654
    ObrigatoriedadeNumeroSerie_ObrigadoASerInformado_UsarEstoqueNaSaida = 655
    StatusDocumentoFiscal_Transmitido = 656
    StatusDocumentoFiscal_ProblemaTransmissao = 657
    TipoFormaPagamento_CreditoCedido = 658
    MotivoCancelamentoMovimentacaoFinanceira_DesacordoComercial = 659
    MotivoCancelamentoMovimentacaoFinanceira_ErroLancamento = 660
    StatusAgendamento_Sistema_Excluido = 661
    StatusAgendamento_Concluido = 662
    TipoEstruturaProduto_ProdutoFabricado = 663
    TipoEstruturaProduto_Kit_Composto = 664
    TipoEstruturaProduto_Acessorios = 665
    PeriodoCalculoFinanceiro_AoDia = 666
    PeriodoCalculoFinanceiro_AoMes = 667
    PeriodoCalculoFinanceiro_AoAno = 668
    PeriodoCalculoFinanceiro_Unico = 669
    TipoIntervalos_Diario = 670
    TipoIntervalos_Semanal = 671
    TipoIntervalos_Quizenal = 672
    TipoIntervalos_Mensal = 673
    TipoIntervalos_Bimestral = 674
    TipoIntervalos_Trimestral = 675
    TipoIntervalos_Simestral = 676
    TipoIntervalos_Anual = 677
    Disponivel_678 = 678
    Disponivel_679 = 679
    Disponivel_680 = 680
    TipoCertificadoDigital_A1Repositorio = 681
    TipoCertificadoDigital_A1Arquivo = 682
    TipoCertificadoDigital_A1ByteArray = 683
    TipoCertificadoDigital_A3 = 684
    TipoCalculoValor_CadastroLancamento_NaoAplica = 685
    TipoCalculoValor_Lancamento_Percentual = 686
    TipoCalculoValor_Lancamento_EmValor = 687
    VersaoQRCodeNFCe_Versao10 = 688
    VersaoQRCodeNFCe_Versao20 = 689
    Processo_Acao_Erro = 690
    ConfigNFCe_DetalheVendaNormal_NaoImprimir = 691
    ConfigNFCe_DetalheVendaNormal_UmaLinha = 692
    ConfigNFCe_DetalheVendaNormal_DuasLinhas = 693
    ConfigNFCe_DetalheVendaContigencia_UmaLinha = 694
    ConfigNFCe_DetalheVendaContigencia_DuasLinhas = 695
    StatusAtendimentoClinica_Cancelada = 696
    ExibirDocumentoFiscal_ExibirSempre = 697
    ExibirDocumentoFiscal_ExibirPorPadrao = 698
    ExibirDocumentoFiscal_NaoExibirPorPadrao = 699
    TipoReferenciaNaturezaOperacao_NaoReferenciar = 700
    TipoReferenciaNaturezaOperacao_ReferenciarNFe = 701
    TipoReferenciaNaturezaOperacao_ReferenciarNFCe = 702
    TipoTransmissaoCupomFiscal_NFCe = 703
    TipoTransmissaoCupomFiscal_SAT = 704
    ModeloSAT_Cdecl = 705
    ModeloSAT_StdCall = 706
    ModeloSAT_MFeIntegrador = 707
    RegimeTributarioISSQN_Nenhum = 708
    RegimeTributarioISSQN_MicroEmpresaMunicipal = 709
    RegimeTributarioISSQN_Estimativa = 710
    RegimeTributarioISSQN_SociedadeProfissionais = 711
    RegimeTributarioISSQN_Cooperativa = 712
    RegimeTributarioISSQN_MEI = 713
    RegimeTributarioISSQN_MEEPP = 714
    SimNao_Sim = 715
    SimNao_Nao = 716
    MotivoCancelamentoMovimentacaoFinanceira_ExclusaoPedido = 717
    StatusAgendamento_AguardandoAtendimento = 718
    DiasSemana_Segunda = 719
    DiasSemana_Terca = 720
    DiasSemana_Quarta = 721
    DiasSemana_Quinta = 722
    DiasSemana_Sexta = 723
    DiasSemana_Sabado = 724
    DiasSemana_Domingo = 725
    TipoProcedimento_Procedimento = 726
    TipoProcedimento_Exame = 727
    TipoExame_Laboratorial = 728
    TipoExame_Complementar = 729
    TipoExame_Citologico = 730
    TipoExame_Vacina = 731
    StatusOrcamentoClinica_Cadastrado = 732
    StatusOrcamentoClinica_Excluido = 733
    StatusItemOrcamentoClinica_Cadastrado = 734
    StatusItemOrcamentoClinica_Vendido = 735
    StatusItemOrcamentoClinica_Cancelado = 736
    StatusVendaClinica_Lancado = 737
    StatusVendaClinica_Cancelado = 738
    StatusVendaClinica_Estornado = 739
    StatusVendaClinica_CanceladoParcial = 740
    StatusOrcamentoClinica_EmAberto = 741
    StatusOrcamentoClinica_Fechado = 742
    StatusMovimentacaoFinanceira_EmVenda = 743
    ConfiguracaoTela_ContasReceber_Consulta = 744
    ConfiguracaoTela_ContasReceber_Consulta1 = 745
    ConfiguracaoTela_Atendimento_Vacinas_Cadastro = 746
    ConfiguracaoTela_Atendimento_Medico_Antecedentes = 747
    ConfiguracaoTela_Atendimento_Medico_Atestados = 748
    ConfiguracaoTela_Atendimento_Medico_OutrasConsultasPaciente = 749
    ConfiguracaoTela_Atendimento_Medico_Receituario = 750
    ConfiguracaoTela_Atendimento_Medico_Relatorio = 751
    ConfiguracaoTela_Atendimento_Medico_SolicitacaoFisioterapia = 752
    ConfiguracaoTela_Atendimento_Medico_SolicitacaoVacinas = 753
    ConfiguracaoTela_Atendimento_Medico_TelaInicial = 754
    ConfiguracaoTela_Atendimento_Medico_TelaAtendimento = 755
    ConfiguracaoTela_Atendimento_Medico_SolicitacaExames_TelaMaximizada = 756
    ConfiguracaoTela_Atendimento_Medico_SolicitacaoExamesCitológico = 757
    ConfiguracaoTela_Botao_Atender = 758
    ConfiguracaoTela_Botao_AtendimentosRealizados = 759
    ConfiguracaoTela_Botao_Chamar = 760
    ConfiguracaoTela_Botao_Fechar = 761
    ConfiguracaoTela_Botao_MinhasFaturas = 762
    ConfiguracaoTela_Botao_Atestados = 763
    ConfiguracaoTela_Botao_Exames = 764
    ConfiguracaoTela_Botao_Imprimir = 765
    ConfiguracaoTela_Botao_Listar = 766
    ConfiguracaoTela_Botao_OutrasConsultas = 767
    ConfiguracaoTela_Botao_Paciente_Cadastro = 768
    ConfiguracaoTela_Botao_Receituario = 769
    ConfiguracaoTela_Botao_Relatorios = 770
    ConfiguracaoTela_Botao_Salvar = 771
    ConfiguracaoTela_Botao_Vacinas = 772
    TipoAtestado_Medico = 773
    TipoAtestado_Comparecimento = 774
    TipoAtestado_Acomapanhante = 775
    TipoAntecedentes_Pessoal = 776
    TipoAntecedentes_Familiar = 777
    ConfiguracaoTela_Atendimento_Medico_AtendimentosRealizados = 778
    ConfiguracaoTela_Botao_Finalizar = 779
    StatusExameSolicitado_Solicitado = 780
    StatusExameSolicitado_Orcado = 781
    ConfiguracaoTela_Atendimento_Medico_AtendimentosRealizados_Consulta = 782
    ConfiguracaoTela_Atendimento_Medico_Faturamento = 783
    ConfiguracaoTela_Botao_Faturar = 784
    ConfiguracaoTela_Botao_Financeiro = 785
    StatusVendaClinica_RepasseRealizado = 786
    StatusExameSolicitado_Vendido = 787
    ConfiguracaoTela_Atendimento_Medico_MinhasFaturas = 788
    ConfiguracaoTela_Atendimento_Médico_MeuContasReceber = 789
    Clinica_Procedimento_ReajustePreco = 790
    Clinica_ConsultaAgendamentoDisponibilidade = 791
    TipoProcedimento_Revisoes = 792
    ConfiguracaoTela_Botao_Seta = 793
    TipoFuncao_Supervisao = 794
    TipoFuncao_Gerente = 795
    ConfiguracaoTela_Botao_Atualizar = 796
    ConfiguracaoTela_Atendimento_Medico_Executor_Atendimento = 797
    ConfiguracaoTela_Botao_Importar = 798
    ConfiguracaoTela_Botao_Limpar = 799
    ConfiguracaoTela_Botao_FecharTelaMedico = 800
    ConfiguracaoTela_Botao_AtendimentosRealizadosTelaMedico = 801
    ConfiguracaoTela_Atendimento_Medico_TelaInicial_Itens = 802
    ConfiguracaoTela_Atendimento_Medico_TelaInicial_ItensDesabilitados = 803
    ConfiguracaoTela_Botao_Atendido = 804
    ConfiguracaoTela_Botao_Disponivel = 805
    ConfiguracaoTela_Botao_Historico = 806
    ConfiguracaoTela_Botao_Reserva = 807
    ConfiguracaoTela_Botao_SolicitarExames_Fechar = 808
    ConfiguracaoTela_Botao_SolicitarExames_Imprimir = 809
    ConfiguracaoTela_Botao_SolicitarExames_Visualizar = 810
    ConfiguracaoTela_Botao_Novo = 811
    ConfiguracaoTela_Botao_SolicitarExames_ImprimirSelecionados = 812
    StatusMovimentacaoFinanceira_Faturado = 813
    StatusAgendamento_SistemaAnterior = 814
    TipoPagamento_DevolucaoCliente = 815
    TipoEstacao_EstacaoTrabalho = 816
    TipoEstacao_EstacaoGeracaoSenha = 817
    StatusMovimentacaoFinanceira_Lancado = 828
    Processo_Acao_Notificado = 829
  End Enum

  Public Enum enTipoDocumentoFiscal
    Entrada_NotaFiscalEntrada = 1
    Saida_CupomNaoFiscal = 2
    Saida_NotaFiscalSaida = 3
    Saida_CupomFiscalEletronico = 4
  End Enum

  Public Enum enSql
    CreditoDebito = 1
    TipoCampo = 2
    FisicoJuridico = 3
    SituacaoProfissional = 4
    TipoQuestionarioClinica = 5
    ExplicacaoSe = 6
    AtivoInativo_Pessoal = 7
    TipoSaidaAtendimentoClinica = 8
    TipoDoenca = 9
    TempoDoenca = 10
    IndicacaoAcidente = 11
    TipoQuestionarioClinicaDadosVitais = 12
    StatusAgendamento = 13
    TipoMovimentacaoFinanceiraRecebePagar = 14
    TipoMovimentacaoFinanceiraContas = 15
    StatusAgendamento_Sistema = 16
    StatusAtendimentoClinica = 17
    StatusMovimentacaoFinanceira = 18
    TipoPagamento = 19
    Finalidade_NFe = 20
    ModalidadeBaseCalculoICMS = 21
    ModalidadeBaseCalculoICMSST = 22
    OrigemProduto = 23
    FronteiraEstados = 24
    MetodoCalcularPrecoVenda = 25
    AcaoFinanceiro = 26
    AcaoEstoque = 27
    TipoFrete = 28
    StatusPedido = 29
    NFe_StatusProecssamento = 30
    NFe_FormaPagamento = 31
    NFe_TipoOperacao = 32
    NFe_LocalDestinoOperacao = 33
    NFe_FormatoImpressaoDanfe = 34
    NFe_FormaEmissaoNFe = 35
    NFe_FinalidadeEmissaoNFe = 36
    NFe_OperacaoConsumidorFinal = 37
    NFe_CompradorPresenteOperacao = 38
    NFe_ProcessoEmissao = 39
    NFe_CodigoRegimeTributario = 40
    NFe_IndicadorIEDestinatario = 41
    NFe_ProdutoIncluidoValor = 42
    NFe_TipoItemProduto = 43
    NFe_ModalidadeFrete = 44
    StatusDocumentoFiscal = 45
    StatusItemDocumentoFiscal = 46
    StatusMovimentacaoEstoque = 47
    StatusLançamentoEstoque = 48
    StatusProdutoGarantia = 49
    StatusItemPedido = 50
    TipoProcessamento = 51
    StatusDocumentoFinanceiro = 52
    StatusFluxoCaixa = 53
    TipoInstituicao = 54
    StatusPagamentoItem = 55
    TipoEventoAgendaPessoa = 56
    TipoEventoAgendaEmpresa = 57
    TipoModeloDocumento = 58
    TipoElementoModeloDocumento = 59
    TipoRepositorioArquivo = 60
    TipoItemAgendaGeral = 61
    ModeloFormularioQuestionario = 62
    Questionario_TipoPainel = 63
    Questionario_TipoRespostaExplicacao = 64
    Questionario_TipoComponente = 65
    TipoIndicacao = 66
    TipoEventoAgendaEmpresa_Sistema = 67
    StatusOrdemServico = 68
    TipoOrdemServico = 69
    TipoHistoricoOrdemServico = 70
    TipoCustoPlanoContas = 71
    TipoSegmento = 72
    Processo_Acao = 73
    Processo_Historico = 74
    TipoLiberacaoAgenda = 75
    StatusPagamento = 76
    TipoConvenio = 77
    TipoUnidadeMedida = 78
    TipoRelacaoProduto = 79
    TipoDocumentoFinanceiroCadastrado = 80
    MotivoCancelamentoMovimentacaoFinanceira = 81
    StatusNumeroSeriePedido = 82
    TipoPedido = 83
    TipoControleContabil = 84
    TipoCanalNegocio = 85
    TipoEquipamento = 86
    TipoLançamentoCreditoFinanceiro = 87
    TipoMovimentacaoEstoque = 88
    PermissaoDireitoCredito = 89
    TipoContabilizacaoPlanoContas = 90
    TipoUtilizacaoLançamentoFinanceiro = 91
    TipoFormaPagamento = 92
    ClasseTipoContaFinanceira = 93
    TipoLinhaProduto = 94
    TelaCarregamentoAutomaticoInicializacao = 95
    AmbienteProcessamento = 96
    ObrigatoriedadeNumeroSerie = 97
    TipoEstruturaProduto = 98
    PeriodoCalculoFinanceiro = 99
    TipoIntervalos = 100
    TipoNaturezaOperacao = 101
    TipoCertificadoDigital = 102
    TipoCalculoValor_CadastroLancamento = 103
    TipoCalculoValor_Lancamento = 104
    VersaoQRCodeNFCe = 105
    ConfigNFCe_DetalheVendaNormal = 106
    ConfigNFCe_DetalheVendaContigencia = 107
    ExibirDocumentoFiscal = 108
    TipoReferenciaNaturezaOperacao = 109
    TipoTransmissaoCupomFiscal = 110
    ModeloSAT = 111
    RegimeTributarioISSQN = 112
    SimNao = 113
    DiasSemana = 114
    TipoProcedimento = 115
    TipoExame = 116
    StatusOrcamentoClinica = 117
    StatusItemOrcamentoClinica = 118
    StatusVendaClinica = 119
    TipoPessoa = 1201
    EstadoCivil = 1202
    Nacionalidade = 1203
    Escolaridade = 1204
    Raca = 1205
    Religiao = 1206
    Sexo = 1207
    Profissao = 1208
    Tipo_MidiaSocial = 1209
    TipoTelefone = 1210
    TipoReferencia = 1211
    TabelaPreco = 1212
    TipoPaciente = 1213
    Convenio_Ativo = 1214
    Especialidade = 1215
    Empresa = 1216
    Cidade = 1217
    Profissional = 1218
    Anamnese = 1219
    PlanoContas = 1220
    PlanoContas_Debito = 1221
    PlanoContas_Credito = 1222
    ContaBancaria = 1224
    StatusAgendamento_Todos = 1225
    ContaCaixa = 1226
    TipoDocumento = 1227
    ConselhoProfissional = 1228
    Tipo_Consulta = 1229
    TabelaProcedimento = 1230
    EstagioDoenca = 1231
    Fabricante = 1232
    UnidadeMedida = 1233
    CFOP = 1234
    CST = 1235
    CSOSN = 1236
    CSTCofins = 1238
    CSTIPI = 1239
    CSTPIS = 1240
    NCM = 1241
    GrupoProduto = 1242
    TipoProduto = 1243
    FormaPagamento = 1244
    NaturezaOperacao = 1245
    Fornecedor = 1246
    Transportadora = 1247
    Endereco = 1248
    Produto = 1249
    UF_Codigo = 1250
    Departamento = 1251
    TransacaoEstoque_Recebimento = 1252
    TransacaoEstoque_Venda = 1253
    TransacaoEstoque_MovimentacaoEstoque_Manual = 1254
    TransacaoEstoque = 1255
    CFOP_DentroEstado = 1256
    NaturezaOperacao_Compras = 1257
    NaturezaOperacao_Vendas = 1258
    Banco = 1259
    ContaFinanceira = 1260
    TabelaPreco_Ativa = 1261
    TipoMovimentacaoFinanceira = 1262
    TipoContaFinanceira = 1263
    GrupoPermissao = 1264
    Usuario_Permissao = 1265
    RepositorioImagem = 1266
    RepositorioArquivo = 1267
    ElementoModeloDocumento_Assinatura = 1268
    ElementoModeloDocumento_Cabecalho = 1269
    ElementoModeloDocumento_Rodape = 1270
    TipoCargo = 1271
    ModeloDocumento_Receita = 1272
    ModeloDocumento_Contrato = 1273
    ModeloDocumento_Anamnese = 1274
    ModeloDocumento_Evolucao = 1275
    ModeloDocumento_Recibo = 1276
    ModeloDocumento_Exame = 1277
    ModeloDocumento_Outros = 1278
    Legenda = 1279
    FaixaEtaria = 1280
    Legenda_Item = 1281
    DicionarioDado_Processo_TipoModeloDocumento = 1282
    Indicacao = 1283
    Estoque = 1284
    LocalizacaoEstoque = 1285
    TipoServico = 1286
    Servico = 1287
    TipoDocumento_FluxoCaixa = 1288
    Segmento_ContasReceberContasPagar = 1289
    PlanoContas_Grupo = 1290
    PlanoContas_Grupo_GrupoSuperior = 1291
    CFOP_ForaEstado = 1292
    CFOP_ForaPais = 1293
    StatusEstoqueLocalizacao = 1294
    UF = 1295
    Segmento_OrdemServico = 1296
    AgendaPessoal_AgendaLiberada = 1297
    TipoEndereco = 1298
    Agenda = 1299
    Vendedor = 1300
    CanalNegocio = 1301
    CondicaoPagamento_Venda = 1302
    CondicaoPagamento_Recebimento = 1303
    LinhaProdutoVenda = 1304
    Produto_LinhaProduto = 1305
    CaracteristicaProduto = 1306
    TabelaPreco_SemTabelaBase_Ativa = 1307
    TipoDocumentoFiscal = 1308
    GrupoTributario = 1309
    SerieDocumentoFiscal = 1310
    Telefone = 1311
    MidiaSocial_EMail = 1312
    NaturezaOperacao_SomenteFiscal = 1313
    Grupo_E_StatusMovimentacaoFinanceira = 1314
    FormaPagamento_QuitarCPCR = 1315
    PessoaCredito_QuitarCPCR = 1316
    FormaPagamento_QuitarVenda = 1317
    PessoaCredito_CreditoCedido = 1318
    DocumentoFinanceiroDisponivel = 1319
    TipoDocumentoFiscal_Entrada = 1320
    TipoDocumentoFiscal_Saida = 1321
    CFOP_Grupo = 1322
    Especialidade_Atendida = 1323
    Profissional_Especilidade_Horario = 1324
    EmpresaAtiva = 1325
    Convenio = 1326
    Financiamento = 1327
    Financiamento_Ativo = 1328
    PessoaProfissionalFornecedorProcedimento = 1329
    PessoaProfissionalFornecedorConvenio_Ativo = 1330
    PessoaProfissionalFornecedorConvenioProcedimento_Ativo = 1331
    Especilidade_Profissional = 1332
    Empresa_Profissional_Especialidade = 1333
    OrcamentoCliente_Aberto = 1334
    Consultorio = 1335
    Vacina = 1336
    Profissional_PendenteRepasse = 1337
    GrupoProcedimento = 1338
    Convenio_ComPreco = 1339
    Convenio_SemPreco = 1340
    Profissional_ServicoInterno = 1341
    Usuario_Supervisao = 1342
    Usuario_Supervisao_Caixa = 1343
    Turno = 1344
    ClassificacaoExame = 1345
    Profissional_Especilidade = 1346
    Cid = 1347
    LoteExameCitologico = 1348
    Turno_Todos = 1349
    TipoRelatorio = 1350
    TipoIndicador = 1351
    Indicador = 1352 '
    StatusAgendamento_Cancelamento = 1353
    CanalMarcacao = 1354
    Consultorio_Todos = 1355
    Atendente = 1356
    PlanoContas_Debito_TodasEmpresa = 1357
    PlanoContas_Credito_TodasEmpresa = 1358
    Funcionario = 1359
    ContaCaixa_Empresa = 1360
    ClinicaSenhaGerada_Hoje_Chamar = 1361
    ContaCaixa_SistemaChamada = 1362
    ContaCaixaAtendimento_SistemaChamada = 1363
    ClinicaSenhaGerada_Hoje_Chamada = 1364
    TipoContaBancaria = 1365
  End Enum

  Public Enum enTipoEndereco
    Residencial = 1
    Comercial = 2
    Faturamento = 3
    Cobranca = 4
  End Enum

  Public Enum enTipoMidiaSocial
    EMail = 1
    WebSite = 2
  End Enum

  Public Enum enTipoFiltroPessoa
    Cliente = 1
    Fabricante = 2
    Fornecedor = 3
    Funcionario = 4
    Medico = 5
    Transportadora = 6
    Vendedor = 7
    Pessoa = 8
    Pessoa_Fisica = 9
    Pessoa_Juridica = 10
    Paciente = 11
    Pessoal_Geral = 12
    Pessoa_Juridica_E_Empresa = 13
  End Enum

  Public Enum enTipoPessoa
    Juridica = 1
    Fisica = 2
    ProdutorRural = 3
  End Enum

  Public Enum enTipoTelefone
    Comercial = 1
    Residencial = 2
    Recado = 3
    Comercial_Cobranca = 4
    Comercial_Financeiro = 5
    Celular = 6
  End Enum

  '>> Banco de Dados - Tipo de Cadastro
  Public Enum enTipoCadastro
    CreditoDebito = 1
    TipoCampo = 2
    FisicoJuridico = 3
    SituacaoProfissional = 4
    TipoQuestionarioClinica = 5
    ExplicacaoSe = 6
    AtivoInativo_Pessoal = 7
    TipoSaidaAtendimentoClinica = 8
    TipoDoenca = 9
    TempoDoenca = 10
    IndicacaoAcidente = 11
    TipoQuestionarioClinicaDadosVitais = 12
    StatusAgendamento = 13
    TipoMovimentacaoFinanceiraRecebePagar = 14
    TipoMovimentacaoFinanceiraOutros = 15
    StatusAgendamento_Sistema = 16
    StatusAtendimentoClinica = 17
    StatusMovimentacaoFinanceira = 18
    TipoPagamento = 19
    Finalidade_NFe = 20
    ModalidadeBaseCalculoICMS = 21
    ModalidadeBaseCalculoICMSST = 22
    OrigemProduto = 23
    FronteiraEstados = 24
    MetodoCalcularPrecoVenda = 25
    AcaoFinanceiro = 26
    AcaoEstoque = 27
    TipoFrete = 28
    StatusVenda = 29
    NFe_StatusProecssamento = 30
    NFe_FormaPagamento = 31
    NFe_TipoOperacao = 32
    NFe_LocalDestinoOperacao = 33
    NFe_FormatoImpressaoDanfe = 34
    NFe_FormaEmissaoNFe = 35
    NFe_FinalidadeEmissaoNFe = 36
    NFe_OperacaoConsumidorFinal = 37
    NFe_CompradorPresenteOperacao = 38
    NFe_ProcessoEmissao = 39
    NFe_CodigoRegimeTributario = 40
    NFe_IndicadorIEDestinatario = 41
    NFe_ProdutoIncluidoValor = 42
    NFe_TipoItemProduto = 43
    NFe_ModalidadeFrete = 44
    StatusNotaFiscalEntrada = 45
    StatusItemNotaFiscalEntrada = 46
    StatusMovimentacaoEstoque = 47
    StatusLançamentoEstoque = 48
    StatusProdutoGarantia = 49
    StatusItemPedidoVenda = 50
    StatusItemNotaFiscalSaida = 51
    StatusDocumentoFinanceiro = 52
    StatusFluxoCaixa = 53
    TipoInstituicao = 54
    StatusPagamentoItem = 55
    StatusAgendaPessoa = 56
    StatusAgendaEmpresa = 57
    TipoModeloDocumento = 58
    TipoElementoModeloDocumento = 59
    TipoRepositorioArquivo = 60
    TipoItemAgendaGeral = 61
    ModeloFormularioQuestionario = 62
    Questionario_TipoPainel = 63
    Questionario_TipoRespostaExplicacao = 64
    Questionario_TipoComponente = 65
    TipoIndicacao = 66
    StatusAgendaEmpresa_Sistema = 67
    StatusOrdemServico = 68
    TipoOrdemServico = 69
    TipoHistoricoOrdemServico = 70
    TipoCustoPlanoContas = 71
    TiposSegmento = 72
    Processo_Acao = 73
    Processo_Historico = 74
    TipoLiberacaoAgenda = 75
    StatusPagamento = 76
    TipoConvenio = 77
    TipoUnidadeMedida = 78
    TipoRelacaoProduto = 79
    TipoDocumentoFinanceiroCadastrado = 80
    TipoDocumentoFiscal_Entrada = 81
    StatusNumeroSeriePedidoVenda = 82
    TipoPedido = 83
    TipoControleContabil = 84
    TipoCanalNegocio = 85
    TipoEquipamento = 86
    TipoLançamentoCreditoFinanceiro = 87
    TipoMovimentacaoEstoque = 88
    TipoDocumentoFiscal_Saida = 89
    TipoContabilizacaoPlanoContas = 90
    TipoUtilizacaoLançamentoFinanceiro = 91
    TipoFormaPagamento = 92
    ClasseTipoContaFinanceira = 93
    TipoLinhaProduto = 94
    TelaCarregamentoAutomAticoInicializacao = 95
    AmbienteProcessamento = 96
    ObrigatoriedadeNumeroSerie = 97
    TipoEstruturaProduto = 98
    PeriodoCalculoFinanceiro = 99
    TipoIntervalos = 100
    TipoCertificadoDigital = 102
    TipoCalculoValor_CadastroLancamento = 103
    TipoCalculoValor_Lançamento = 104
    VersaoQRCodeNFCe = 105
    ConfigNFCe_DetalheVendaNormal = 106
    ConfigNFCe_DetalheVendaContigencia = 107
    ExibirDocumentoFiscal = 108
    TipoReferenciaNaturezaOperacao = 109
    TipoTransmissaoCupomFiscal = 110
    ModeloSAT = 111
    RegimeTributarioISSQN = 112
    SimNao = 113
    DiasSemana = 114
    TipoProcedimento = 115
    TipoExame = 116
    StatusOrcamentoClinica = 117
    StatusItemOrcamentoClinica = 118
    StatusVendaClinica = 119
    ConfiguracaoTela = 120
    TipoAtestado = 121
    TipoAtecedentes = 122
    StatusExameSolicitado = 123
    TipoFuncao = 124
    UF = 1000
    Pais = 1001
    TipoContaBancaria = 1002
    Banco = 1003
    Departamento = 1004
    FormaPagamento = 1005
    TipoPessoa = 1006
    Sexo = 1007
    Legenda = 1008
    Profissao = 1009
    MidiaSocial = 1010
    TipoTelefone = 1011
    Convenio = 1012
    TipoEndereco = 1013
    Cidade = 1014
    TipoParentesco = 1015
    Medicamento = 1016
    Procedimento = 1017
    CID = 1018
    PlanoContas_Debito = 1019
    PlanoContas_Credito = 1020
    TipoDocumento = 1021
    Especialidade = 1022
    TipoReferenciaPessoal = 1023
    CSOSN = 1024
    CFOP = 1025
    CST = 1026
    CSTCofins = 1027
    CSTIPI = 1028
    CSTPIS = 1029
    Estoque = 1030
    TransacaoEstoque_Recebimento = 1031
    TransacaoEstoque_Venda = 1032
    TransacaoEstoque_MovimentacaoEstoque_Manual = 1033
    TransacaoEstoque = 1034
    ContaFinanceira = 1035
    TipoServico = 1036
    PlanoContasGrupo = 1037
    UnidadeMedida = 1038
    DocumentoFinanceiroDisponivel = 1039
    FormaPagamento_QuitarCPCR = 1040
    PessoaCredito_QuitarCPCR = 1041
    Contabilizacao = 1042
    FormaPagamento_QuitarVenda = 1043
    PessoaCredito_QuitarVenda = 1044
    Produto_LinhaProduto = 1045
    PessoaCredito_CreditoCedido = 1046
    TipoDocumentoFiscal = 1047
    DiasSemanaPessoaHorario = 1048
    Funcionario = 1049
    Exame = 1050
    TodosProcedimentos = 1051
    FaixaEtraria = 1052
  End Enum

  '>> Bloqueio de Estoque
  Public Enum enEstoqueLocalizacaoStatus
    Disponivel = 1
    Bloquieo = 2
  End Enum

  '>> Segurança - Grupo de Permissão
  Public Enum enSEG_GrupoPermissao
    PDV = 1
  End Enum

  '>> Sistema
  Public Enum enSistema
    PDV = 1
    Empresa = 2
    Clinica = 3
  End Enum

  Public Enum eDbType
    _Inteiro = 1
    _Numero = 2
    _Data = 3
    _Texto = 4
    _Decimal = 5
  End Enum

  Public Enum enTipoArquivo
    eTodos = 1
    eImagem = 2
    eXML = 3
  End Enum

  Public Enum enNFe_Versao
    e2_00 = 1
    e3_10 = 2
  End Enum

  Public Enum enEstoquePendente_Grupo
    VENDAS = 1
    COMPRAS = 2
    PENDENTE_LOCALIZACAO = 3
  End Enum

  Public Enum enDicionarioDados
    InformacoesSistema = -1001
    FormatacaoData_CalculoMatematico = -1002
  End Enum

  '>> Variáveis
  'Banco de Dados
  Public oConexao As System.Data.SqlClient.SqlConnection
  Public oConexao2 As System.Data.SqlClient.SqlConnection
  Public oConexaoDBQuery As System.Data.SqlClient.SqlConnection

  'Informações do Sistema
  Public iID_USUARIO As Integer
  Public sNO_USUARIO As String
  Public sNO_USUARIO_RESUMIDO As String
  Public bUSUARIO_PROFISSIONAL As Boolean
  Public bUSUARIO_VENDEDOR As Boolean
  Public bUSUARIO_ADMINISTRADOR As Boolean
  Public bUSUARIO_ACESSO_SISTEMACHAMADA As Boolean
  Public sUSUARIO_CD_CPF_CNPJ As String
  Public iUSUARIO_ID_PESSOA_PROFISSIONAL_PADRAO As Integer
  Public iUSUARIO_ID_CONTAFINANCEIRA_PADRAO_VENDA As Integer
  Public iUSUARIO_ID_OPT_CARREGAMENTOAUTOMATICOINICIALIZACAO As Integer
  Public bUSUARIO_IC_ATUALIZAR_AGENDA_AUTOMATICO As Boolean
  Public iUSUARIO_ID_OPT_TIPOFUNCAO As Integer

  Public iID_EMPRESA_MATRIZ As Integer
  Public iID_EMPRESA_FILIAL As Integer
  Public sNO_EMPRESA_FILIAL As String
  Public iID_EMPRESA_CIDADE As Integer
  Public iID_EMPRESA_UF As Integer
  Public sCD_EMPRESA_UF As String
  Public iID_EMPRESA_PAIS As Integer
  Public sID_EMPRESA_CNPJ As String
  Public sEMPRESA_DADOS_RELATORIO As String
  Public sEMPRESA_NF_MODELO_PADRAO As String
  Public sEMPRESA_NF_SERIE_PADRAO As String
  Public iEMPRESA_ID_TRANSACAOESTOQUE_PADRAO_COMPRAS As Integer
  Public iEMPRESA_ID_TRANSACAOESTOQUE_PADRAO_VENDAS As Integer
  Public iEMPRESA_ID_PLANOCONTAS_PADRAO_RECEBIMENTO As Integer
  Public iEMPRESA_ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO As Integer
  Public iEMPRESA_ID_TABELAPROCEDIMENTO_PADRAO As Integer
  Public iEMPRESA_ID_MODELODOCUMENTO_RECIBO_PADRAO As Integer
  Public iEMPRESA_ID_MODELODOCUMENTO_RECEITA_PADRAO As Integer
  Public iEMPRESA_ID_MODELODOCUMENTO_ANAMNESE_PADRAO As Integer
  Public iEMPRESA_ID_MODELODOCUMENTO_EVOLUCAO_PADRAO As Integer
  Public iEMPRESA_ID_QUESTIONARIO_ANAMNESE_PADRAO As Integer
  Public iEMPRESA_ID_TIPOCONSULTA_RETORNO As Integer
  Public iEMPRESA_ID_TIPO_CONSULTA_VENDA As Integer
  Public iEMPRESA_ID_SEGMENTO_CRCP_PADRAO As Integer
  Public iEMPRESA_ID_OPT_TIPOCONTROLECONTABIL As Integer
  Public iEMPRESA_ID_NATUREZAOPERACAO_VENDA As Integer
  Public iEMPRESA_ID_TABELAPRECO_PADRAO As Integer
  Public iEMPRESA_ID_CANALNEGOCIO_PADRAO_VENDA As Integer
  Public iEMPRESA_ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO As Integer
  Public iEMPRESA_ID_CONDICAOPAGAMENTO_VENDA_PADRAO As Integer
  Public iEMPRESA_ID_TIPO_DOCUMENTO_PADRAO_VENDA As Integer
  Public iEMPRESA_ID_CONTAFINANCEIRA_PADRAO_VENDA As Integer
  Public iEMPRESA_ID_CONTAFINANCEIRA_TESOURARIA As Integer
  Public iEMPRESA_ID_CONVENIO_PADRAO As Integer
  Public iEMPRESA_NR_ATENDIMENTO_INTERVALO As Integer
  Public sEMPRESA_HR_ATENDIMENTO_INICIO As String
  Public sEMPRESA_HR_ATENDIMENTO_SAIDAREFEICAO As String
  Public sEMPRESA_HR_ATENDIMENTO_RETORNOREFEICAO As String
  Public sEMPRESA_HR_ATENDIMENTO_FIM As String
  Public sEMPRESA_CADASTROTELEFONE_DDD_PADRAO As String
  Public sEMPRESA_CADASTROTELEFONE_MASCARA As String
  Public sEMPRESA_DS_PATH_IMAGEM As String
  Public sEMPRESA_DADOS_NOMEFANTASIA As String
  Public sEMPRESA_DADOS_CNPJ As String
  Public sEMPRESA_DADOS_IE As String
  Public sEMPRESA_DADOS_IM As String
  Public sEMPRESA_DADOS_Endereco As String
  Public sEMPRESA_DADOS_Telefone As String
  Public sEMPRESA_DADOS_EMail As String
  Public sEMPRESA_DADOS_WebSite As String
  Public bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO As Boolean
  Public iEMPRESA_NR_CASASDECIMAIS_VALORES As Integer
  Public iEMPRESA_NR_DIA_VALIDADEORCAMENTO As Integer
  Public iEMPRESA_NR_DIA_VALIDADEPEDIDO As Integer
  Public iEMPRESA_ID_EQUIPAMENTO_PROCESSAMENTO_FISCAL As Integer
  Public iEMPRESA_ID_ORDEMSERVICO_OPT_TIPO_ORDEMSERVICO_PADRAO As Integer
  Public iEMPRESA_ID_ORDEMSERVICO_TABELAPRECO_PADRAO As Integer
  Public bEMPRESA_ORDEMSERVICO_LISTAGEMPRODUTOMANUTENCAO As Boolean
  Public bEMPRESA_ORDEMSERVICO_DESCRICAOPRODUTOMANUTENCAO As Boolean
  Public bEMPRESA_ORDEMSERVICO_DESCRICAOPRODUTOMANUTENCAO_1OPCAO As Boolean
  Public bEMPRESA_IC_NECESSITA_ANAMNESE_EVOLUCAO As Boolean
  Public bEMPRESA_IC_QUITAR_PROVISIONADO As Boolean
  Public bEMPRESA_IC_PROVISIONADO_POR_PADRAO As Boolean
  Public bEMPRESA_IC_DIAUTIL_DOM As Boolean
  Public bEMPRESA_IC_DIAUTIL_SEG As Boolean
  Public bEMPRESA_IC_DIAUTIL_TER As Boolean
  Public bEMPRESA_IC_DIAUTIL_QUA As Boolean
  Public bEMPRESA_IC_DIAUTIL_QUI As Boolean
  Public bEMPRESA_IC_DIAUTIL_SEX As Boolean
  Public bEMPRESA_IC_DIAUTIL_SAB As Boolean
  Public sEMPRESA_PAYGO_REGISTRO_CERTIFICACAO As String

  Public iESTACAO_TRABALHO_SQ_EMPRESA_ESTACAO As Integer
  Public sESTACAO_TRABALHO_DS_DIGITALIZADOR_PADRAO As String
  Public sESTACAO_TRABALHO_DS_DOCUMENTOFISCAL_PATH_SCHEMAS As String
  Public sESTACAO_TRABALHO_DS_CERTIFICADO_DIGITAL_PATH_ARQUIVO As String
  Public sESTACAO_TRABALHO_DS_CERTIFICADO_DIGITAL_SENHA As String
  Public iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE As Integer
  Public iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_TIPO As Integer
  Public bESTACAO_TRABALHO_IC_IMPRIME_DANFENCFE_AUTOMATICAMENTE As Boolean
  Public sESTACAO_TRABALHO_DS_IMPRESSORA_PADRAO_DANFENCFE As String
  Public sESTACAO_TRABALHO_DS_FONTE_PADRAO_DANFENCFE As String

  Public iESTACAO_TRABALHO_ID_OPT_NFCe_VERSAO_QRCODE As Integer
  Public iESTACAO_TRABALHO_ID_OPT_NFCe_DETALHE_VENDA_NORMAL As Integer
  Public iESTACAO_TRABALHO_ID_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA As Integer
  Public sESTACAO_TRABALHO_CD_NFCe_Token_ID As String
  Public sESTACAO_TRABALHO_CD_NFCe_Token_CSC As String
  Public sESTACAO_TRABALHO_CD_OPT_NFCe_VERSAO_QRCODE As String
  Public sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_NORMAL As String
  Public sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA As String

  Public sSISTEMA_PathBackupDB As String = "C:\SisMattos\"
  Public sSISTEMA_LinkWhatsApp_WEB As String = ""
  Public sSISTEMA_LlinkChamarCliente As String
  Public sSISTEMA_LlinkChamarGeral As String
  Public sSISTEMA_LlinkChamarSenha As String
  Public sSISTEMA_UltimaVersao As String

  Public sPathRepositorioArquivo As String
  Public sPathSistema As String
  Public iMetodoCalculoPreco As enOpcoes

  'Telas e Sistema
  Public eSistema As enSistema
  Public oFormMDI As Form

  '>>> CLASSES <<<
  Class cFormaPagamento
    Public SQ_FORMAPAGAMENTO As Integer
    Public ID_TIPO_DOCUMENTO As Integer
    Public ID_OPT_DOCUMENTOCADASTRADO As Integer
    Public ID_OPT_TIPOFORMAPAGAMENTO As Integer
    Public ID_OPT_INSTITUICAO_GERADORA As enOpcoes
    Public NO_FORMAPAGAMENTO As String
    Public NO_TIPO_DOCUMENTO As String
    Public COMPENSA As Boolean
    Public CADASTRAR_DOCUMENTO As Boolean
    Public CADASTRAR_CONTABANCARIA As Boolean
    Public NO_INSTITUICAO_GERADORA As String
  End Class

  Class cDocumentoFinanceiro
    Public SQ_DOCUMENTOFINANCEIRO As Integer
    Public ID_TIPODOCUMENTO As Integer
    Public ID_OPT_STATUS As Integer
    Public ID_BANCO As Integer
    Public ID_EMITENTE As Integer
    Public DT_DOCUMENTO As Date
    Public DT_VENCIMENTO As Date
    Public DS_EMITENTE As String
    Public NR_BANCO_AGENCIA As Integer
    Public NR_BANCO_CONTA As Integer
    Public NR_BANCO_CONTA_DIGITO As Integer
    Public CD_DOCUMENTO As String
    Public VL_DOCUMENTO As Double
    Public VL_SALDO As Double
    Public DS_DOCUMENTO As String
  End Class

  Class cNfe_Produto1
    Public Codigo As String                 '<prod> <cProd>
    Public CodigoBarra As String            '<prod> <cEAN>
    Public Nome As String                   '<prod> <xProd>
    Public NCM As String                    '<prod> <NCM>
    Public CFOP As String                   '<prod> <CFOP>
    Public UnidadeMedida As String          '<prod> <uCom>
    Public Quantidade As Double             '<prod> <qCom>
    Public ValorUnitario As Double          '<prod> <vUnCom>
    Public ValorTotal As Double             '<prod> <vProd>
    Public EANTributavel As String          '<prod> <cEANTrib>
    Public UnidadeTributavel As String      '<prod> <uTrib>
    Public QuantidadeTributavel As Double   '<prod> <qTrib>
    Public ValorTributavel As Double        '<prod> <vUnTrib>
    Public ValorFrete As Double             '<prod> <vFrete>
    Public ValorSeguro As Double            '<prod> <vSeg>
    Public ValorDesconto As Double          '<prod> <vDesc>
    Public ValorOutrasDespesas As Double    '<prod> <vOutro_item>
    Public IncluirValorTotal As Integer     '<prod> <indTot> 0 – O valor do item (vProd) não compõe o valor total da NF-e (vProd)
    '                                                        1 – Os valor do item (vProd) compõe o valor total da NF-e (vProd)
    Public TipoItem As Integer              '<prod> <nTipoItem> 1 - Veículos
    '                                                           2 - Medicamentos
    '                                                           3 - Armamentos
    '                                                           4 – Combustível
    '                                                           5 - Serviço
    Public PedidoCompra As String           '<prod> <xPed_item>
    Public PedidoCompra_Item As String      '<prod> <nItemPed>
    Public CEST As String                   '<prod> <CEST>
  End Class

  Class cNfe_Duplicata1
    Public nDup As String       '<cobr> <fat> <nDup>
    Public dVenc As DateTime    '<cobr> <fat> <dVenc>
    Public vDup As Double       '<cobr> <fat> <vDup>
  End Class

  Class cNFe1
    Public XML As String
    Public NaturezaOperacao As String         '<natOp>
    Public FormaPagamento As Integer          '<indPag> 0 – pagamento à vista;  1 – pagamento à prazo;  2 - outros
    Public Modelo As String                   '<mod>
    Public Serie As String                    '<serie>
    Public NrNF As String                     '<nNF>
    Public DataHora_Emissao As DateTime       '<dEmi> / <dhEmi>
    Public DataHora_EntradaSaida As DateTime  '<dSaiEnt> / <dhSaiEnt>
    Public TipoOperacao As Integer            '<tpNF>1</tpNF> 0-entrada; 1-saída
    Public LocalDestino As Integer            '<idDest> 1 = Operação interna; 2 = Operação interestadual; 3 = Operação com exterior."
    Public IBGE_Municipio As String           '<cMunFG>
    Public FormatoImpressaoDanfe As Integer   '<tpImp> 1-Retrato; 2-Paisagem; 3-Simplificado; 4-DANFE NFC-e; 5-DANFE NFC-e em mensagem eletrônica (o envio de mensagem eletrônica pode ser feita de forma simultânea com a impressão do DANFE; usar o tpImp=5 quando esta for a única forma de disponibilização do DANFE.)."
    Public FormatoEmissao As Integer          '<tpEmis> 1 – Normal – emissão normal;
    '                                                   2 – Contingência FS – emissão em contingência com impressão do DANFE em Formulário de Segurança;
    '                                                   3 – Contingência SCAN – emissão em contingência no Sistema de Contingência do Ambiente Nacional – SCAN; Desativado
    '                                                   4 – Contingência DPEC - emissão em contingência com envio da Declaração Prévia de Emissão em Contingência – DPEC;
    '                                                   5 – Contingência FS-DA - emissão em contingência com impressão do DANFE em Formulário de Segurança para Impressão de Documento Auxiliar de Documento Fiscal Eletrônico (FS-DA);
    '                                                   6 - Contingência SVC-AN (SEFAZ Virtual de Contingência do AN);
    '                                                   7 - Contingência SVC-RS (SEFAZ Virtual de Contingência RS);
    '                                                   9 - Contingência off-line da NFC-e (as demais opções de contingência são válidas também para NFC-e);
    '                                                       NOTA: Para a NFC-e somente estão disponíveis e são válidas as opções de contingência 5 e 9.  
    '                                                       Observação: Para a NFC-e somente é válida a opção de contingência: 9-Contingência Off-Linee, a critério da UF, opção 4-Contingência EPEC"
    Public FinalidadeEmissaoNFe As Integer    '<finNFe> 1 - NF-e normal; 2 - NF-e complementar; 3 – NF-e de ajuste; 4 - Devolução/Retorno
    Public IndOperConsFinal As Integer        '<indFinal> 0-Não; 1-Consumidor final
    Public CompradorPresente As Integer       '<indPres> 0=Não se aplica (por exemplo, Nota Fiscal complementar ou de ajuste)
    '                                                    1=Operação presencial
    '                                                    2=Operação não presencial, pela Internet
    '                                                    3=Operação não presencial, Teleatendimento
    '                                                    4=NFC-e em operação com entrega a domicílio
    '                                                    9=Operação não presencial, outros.
    Public ProcessoEmissaoNFe As Integer      '<procEmi> 0 - emissão de NF-e com aplicativo do contribuinte
    '                                                    1 - emissão de NF-e avulsa pelo Fisco
    '                                                    2 - emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do Fisco
    '                                                    3- emissão NF-e pelo contribuinte com aplicativo fornecido pelo Fisco
    Public Emissor As String                  '<verProc>
    Public DataHoraContigencia As DateTime    '<dhCont>
    Public JustificativaContigencia As String '<xJust>
    Public Emit_SQ_PESSOA As Integer
    Public Emit_CPF_CNPJ As String            '<emit> <CNPJ><CPF>
    Public Emit_Nome As String                '<emit> <xNome>
    Public Emit_NomeFantasia As String        '<emit> <xFant>
    Public Emit_IM As String                  '<emit> <IM>
    Public Emit_CNAE As String                '<emit> <CNAE>
    Public Emit_IE As String                  '<emit> <IE>
    Public Emit_IEST As String                '<emit> <IEST>
    Public Emit_RegimeTributario As Integer   '<emit> <CRT> 1 – Simples Nacional
    '                                                       2 – Simples Nacional – excesso de sublimite  de receita bruta
    '                                                       3 – Regime Normal
    Public Emit_End_SQ_ENDERECO As Integer
    Public Emit_End_Logradouro As String      '<emit> <enderEmit> <xLgr>
    Public Emit_End_Numero As String          '<emit> <enderEmit> <nro>
    Public Emit_End_Complemento As String     '<emit> <enderEmit> <xCpl>
    Public Emit_End_Bairro As String          '<emit> <enderEmit> <xBairro>
    Public Emit_End_IBGE_Municipio As String  '<emit> <enderEmit> <cMun>
    Public Emit_End_Codigo_UF As String       '<emit> <enderEmit> <UF>
    Public Emit_End_CEP As String             '<emit> <enderEmit> <CEP>
    Public Emit_End_Fone As String            '<emit> <enderEmit> <fone>
    Public Dest_CPF_CNPJ As String            '<dest> <CNPJ><CPF>
    Public Dest_Nome As String                '<dest> <xNome>
    Public Dest_DocEstrageiro As String       '<dest> <idEstrangeiro>
    Public Dest_IndicadorIE As Integer        '<dest> <indIEDest> 1-Contribuinte ICMS (informar a IE do destinatário)
    '                                                             2-Contribuinte isento de Inscrição no cadastro de Contribuintes do ICMS
    '                                                             9-Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS
    '                                                             Nota 1: No caso de NFC-e informar indIEDest=9 e não informar a tag IE do destinatário
    '                                                             Nota 2: No caso de operação com o Exterior informar indIEDest=9 e não informar a tag IE do destinatário
    '                                                             Nota 3: No caso de Contribuinte Isento de Inscrição (indIEDest=2), não informar a tag IE do destinatário
    Public Dest_IE As String                  '<dest><IE>
    Public ISuframa As String                 '<dest><ISUF>
    Public Dest_IM As String                  '<dest><IM>
    Public Dest_EMail As String               '<dest><email>
    Public Dest_End_Logradouro As String      '<dest><enderDest><xLgr>
    Public Dest_End_Numero As String          '<dest><enderDest><nro>
    Public Dest_End_Complemento As String     '<dest><enderDest><xCpl>
    Public Dest_End_Bairro As String          '<dest><enderDest><xBairro>
    Public Dest_End_IBGE_Municipio As String  '<dest><enderDest><cMun>
    Public Dest_End_Codigo_UF As String       '<dest><enderDest><UF>
    Public Dest_End_CEP As String             '<dest><enderDest><CEP>
    Public Dest_End_Fone As String            '<dest><enderDest><fone>
    Public EndRetirada_SQ_ENDERECO As Integer
    Public EndRetirada_CNPJ As String         '<retirada><CNPJ>
    Public EndRetirada_Logradouro As String   '<retirada><xLgr>
    Public EndRetirada_Numero As String       '<retirada><nro>
    Public EndRetirada_Complemento As String  '<retirada><xCpl>
    Public EndRetirada_Bairro As String       '<retirada><xBairro>
    Public EndRetirada_IBGE_Municio As String '<retirada><cMun>
    Public EndRetirada_Codigo_UF As String    '<retirada><UF>
    Public EndEntrega_SQ_ENDERECO As Integer
    Public EndEntrega_CPF_CNPJ As String      '<entrega><CNPJ><CNPJ>
    Public EndEntrega_Logradouro As String    '<entrega><xLgr>
    Public EndEntrega_Numero As String        '<entrega><nro>
    Public EndEntrega_Complemento As String   '<entrega><xCpl>
    Public EndEntrega_Bairro As String        '<entrega><xBairro>
    Public EndEntrega_IBGE_Municio As String  '<entrega><cMun>
    Public EndEntrega_Codigo_UF As String     '<entrega><UF>
    Public VlTotal_BaseCalcICMS As Double     '<ICMSTot><vBC>
    Public VlTotal_ValorICMS As Double        '<ICMSTot><vICMS>
    Public VlTotal_ValorICMSDesc As Double    '<ICMSTot><vICMSDeson>
    Public VlTotal_BaseCalcICMSST As Double   '<ICMSTot><vBCST>
    Public VlTotal_ValorICMSST As Double      '<ICMSTot><vST>
    Public VlTotal_ValorProduto As Double     '<ICMSTot><vProd>
    Public VlTotal_ValorFrete As Double       '<ICMSTot><vFrete
    Public VlTotal_ValorSeguro As Double      '<ICMSTot><vSeg>
    Public VlTotal_ValorDesconto As Double    '<ICMSTot><vDesc>
    Public VlTotal_ValorII As Double          '<ICMSTot><vII>
    Public VlTotal_ValorIPI As Double         '<ICMSTot><vIPI>
    Public VlTotal_ValorPIS As Double         '<ICMSTot><vPIS>
    Public VlTotal_ValorCofins As Double      '<ICMSTot><vCOFINS>
    Public VlTotal_ValorOutrasDesp As Double  '<ICMSTot><vOutro>
    Public VlTotal_ValorNF As Double          '<ICMSTot><vNF>
    Public Transp_SQ_PESSOA As Integer
    Public Transp_ModalidadeFrete As Integer  '<transp><modFrete>
    Public Transp_CPF_CNPJ As String          '<transporta><CPF><CNPJ>
    Public Transp_Nome As String              '<transporta><xNome>
    Public Transp_IE As String                '<transporta><IE>
    Public Transp_SQ_ENDERECO As Integer      '<transporta><IE>
    Public Transp_End_Logradouro As String    '<transporta><xEnder>
    Public Transp_End_IBGE_Municipio As String '<transporta><cMun>
    Public Transp_End_Municipio As String     '<transporta><xMun>
    Public Transp_End_UF As String            '<transporta><UF>
    Public Transp_Placa As String             '<veicTransp><placa>
    Public Transp_Placa_UF As String          '<veicTransp><UF>
    Public Transp_Placa_RNTC As String        '<veicTransp><RNTC>
    Public Transp_Placa2 As String             '<reboque><placa>
    Public Transp_Placa2_UF As String          '<reboque><UF>
    Public Transp_Placa2_RNTC As String        '<reboque><RNTC>
    Public Transp_Volume_Quantidade As Double  '<vol><qVol>
    Public Transp_Volume_Especie As String     '<vol><esp>
    Public Transp_Volume_Marca As String       '<vol><marca>
    Public Transp_Volume_PesoLiquido As Double '<vol><pesoL>
    Public Transp_Volume_PesoBruto As Double   '<vol><pesoB>
    Public Cobranca_NumeroFatura As String     '<fat><nFat>
    Public Cobranca_ValorOriginal As Double    '<fat><vOrig>
    Public Cobranca_ValorDesconto As Double    '<fat><vDesc>
    Public Cobranca_ValorLiquido As Double     '<fat><vLiq>
    Public CobrancaParcNrParcela As String     '<dup><nDup>
    Public CobrancaParcVencimento As Date      '<dup><dVenc>
    Public CobrancaParcValorParcela As Double  '<dup><vDup>
    Public InformacoesComplementares As String '<infAdic><infCpl>
    Public Info_Chave As String               '<infProt><chNFe>
    Public Info_DH_Recebimento As String      '<infProt><dhRecbto>
    Public Info_Status As String              '<infProt><cStat>
    Public Info_Motivo As String              '<infProt><xMotivo>
    Public Produto As New Collection
    Public Duplicata As New Collection
  End Class

  Public Class cDocumentoFiscal
    Public oNFe As NFe.Classes.NFe
    Public ArquivoXML As String

    Public Emit_SQ_PESSOA As Integer
    Public Emit_End_SQ_ENDERECO As Integer
    Public EndRetirada_SQ_ENDERECO As Integer
    Public Transp_SQ_PESSOA As Integer
    Public Transp_End_IBGE_Municipio As String
    Public Transp_SQ_ENDERECO As Integer
  End Class
End Module
