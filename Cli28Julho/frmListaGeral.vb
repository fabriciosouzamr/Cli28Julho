Imports System.ComponentModel
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmListaGeral
  Const const_GridCanalNegocio_SQ_CANALNEGOCIO As Integer = 0
  Const const_GridCanalNegocio_ID_OPT_TIPOCANALNEGOCIO As Integer = 1
  Const const_GridCanalNegocio_NomeCanalNegocio As Integer = 2
  Const const_GridCanalNegocio_ID_CONTABILIZACAO As Integer = 3
  Const const_GridCanalNegocio_Ativo As Integer = 4

  Const const_GridPlanoContas_SQ_PLANOCONTAS As Integer = 0
  Const const_GridPlanoContas_GrupoPlanoContas As Integer = 1
  Const const_GridPlanoContas_CodigoPlanoContas As Integer = 2
  Const const_GridPlanoContas_NomePlanoContas As Integer = 3
  Const const_GridPlanoContas_CreditoDebito As Integer = 4
  Const const_GridPlanoContas_TipoCusto As Integer = 5
  Const const_GridPlanoContas_CodigoPlanoContasContabilidade As Integer = 6
  Const const_GridPlanoContas_Ativo As Integer = 7

  Const const_GridProfissao_SQ_PROFISSAO As Integer = 0
  Const const_GridProfissao_NomeProfissao As Integer = 1

  Const const_GridGrupoPermissao_SQ_GRUPOPERMISSAO As Integer = 0
  Const const_GridGrupoPermissao_NomeGrupoPermissao As Integer = 1

  Const const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO As Integer = 0
  Const const_GridDoencaEstagio_DoencaEstagio As Integer = 1

  Const const_GridCargo_SQ_TIPO_CARGO As Integer = 0
  Const const_GridCargo_NomeCargo As Integer = 1

  Const const_GridCidade_SQ_CIDADE As Integer = 0
  Const const_GridCidade_UF As Integer = 1
  Const const_GridCidade_NomeCidade As Integer = 2
  Const const_GridCidade_CodigoIBGE As Integer = 3

  Const const_GridUF_SQ_UF As Integer = 0
  Const const_GridUF_Pais As Integer = 1
  Const const_GridUF_NomeUF As Integer = 2
  Const const_GridUF_CodigoUF As Integer = 3

  Const const_GridPais_SQ_PAIS As Integer = 0
  Const const_GridPais_NomePais As Integer = 1
  Const const_GridPais_NomeNascionalidade As Integer = 2
  Const const_GridPais_IC_SISTEMA As Integer = 3

  Const const_GridConvenio_SQ_CONVENIO As Integer = 0
  Const const_GridConvenio_TipoConvenio As Integer = 1
  Const const_GridConvenio_NomeConvenio As Integer = 2
  Const const_GridConvenio_Administradora As Integer = 3
  Const const_GridConvenio_CodigoContrato As Integer = 4
  Const const_GridConvenio_DiaCorte As Integer = 5
  Const const_GridConvenio_DiaPrevPagamento As Integer = 6
  Const const_GridConvenio_Ativo As Integer = 7
  Const const_GridConvenio_ControlaCredito As Integer = 8
  Const const_GridConvenio_SenhaSupervisao As Integer = 9
  Const const_GridConvenio_ValorCredito As Integer = 10

  Const const_GridGrupoProduto_SQ_GRUPOPRODUTO As Integer = 0
  Const const_GridGrupoProduto_NomeGrupoProduto As Integer = 1
  Const const_GridGrupoProduto_CTS_Padrao As Integer = 2
  Const const_GridGrupoProduto_CSOSN_Padrao As Integer = 3
  Const const_GridGrupoProduto_CTS_Cofins_Padrao As Integer = 4
  Const const_GridGrupoProduto_CTS_PIS_Padrao As Integer = 5
  Const const_GridGrupoProduto_CTS_IPI_Padrao As Integer = 6
  Const const_GridGrupoProduto_ControlaEstoque As Integer = 7
  Const const_GridGrupoProduto_ControlaGarantia As Integer = 8
  Const const_GridGrupoProduto_ControlaNumeroSerie As Integer = 9
  Const const_GridGrupoProduto_TransacaoEstoque_Padrao_Compras As Integer = 10
  Const const_GridGrupoProduto_TransacaoEstoque_Padrao_Vendas As Integer = 11
  Const const_GridGrupoProduto_Ativo As Integer = 12

  Const const_GridUnidadeMedida_SQ_UNIDADEMEDIDA As Integer = 0
  Const const_GridUnidadeMedida_NomeUnidadeMedida As Integer = 1
  Const const_GridUnidadeMedida_CodigoUnidadeMedida As Integer = 2
  Const const_GridUnidadeMedida_CodigoUnidadeMedidaCompativel As Integer = 3

  Const const_GridEspecialidade_SQ_ESPECIALIDADE As Integer = 0
  Const const_GridEspecialidade_NomeEspecialidade As Integer = 1
  Const const_GridEspecialidade_Ativo As Integer = 2

  Const const_GridBanco_SQ_BANCO As Integer = 0
  Const const_GridBanco_NomeBanco As Integer = 1
  Const const_GridBanco_NumeroBanco As Integer = 2

  Const const_GridContaBancaria_SQ_CONTABANCARIA As Integer = 0
  Const const_GridContaBancaria_TipoConta As Integer = 1
  Const const_GridContaBancaria_Banco As Integer = 2
  Const const_GridContaBancaria_NumeroAgencia As Integer = 3
  Const const_GridContaBancaria_NumeroConta As Integer = 4
  Const const_GridContaBancaria_DigitoConta As Integer = 5
  Const const_GridContaBancaria_DtAbetura As Integer = 6
  Const const_GridContaBancaria_ControlaSaldo As Integer = 7
  Const const_GridContaBancaria_Ativo As Integer = 8

  Const const_GridContaCaixa_SQ_CONTACAIXA As Integer = 0
  Const const_GridContaCaixa_Departamento As Integer = 1
  Const const_GridContaCaixa_Funcionario As Integer = 2
  Const const_GridContaCaixa_FuncionarioSupervisao As Integer = 3
  Const const_GridContaCaixa_NomeCaixa As Integer = 4
  Const const_GridContaCaixa_ControlaSaldo As Integer = 5
  Const const_GridContaCaixa_DescontoMaximo As Integer = 6
  Const const_GridContaCaixa_Localizacao As Integer = 7
  Const const_GridContaCaixa_Ativo As Integer = 8
  Const const_GridContaCaixa_IC_SISTEMA As Integer = 9

  Const const_GridFormaPagamento_SQ_FORMAPAGAMENTO As Integer = 0
  Const const_GridFormaPagamento_TipoDocumento As Integer = 1
  Const const_GridFormaPagamento_NomeFormaPagamento As Integer = 2
  Const const_GridFormaPagamento_TipoDocumentoFinanceiroCadastrado As Integer = 3
  Const const_GridFormaPagamento_ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO As Integer = 4
  Const const_GridFormaPagamento_ID_CONTAFINANCEIRA_QUITACAO As Integer = 5

  Const const_GridTipoCargo_SQ_TIPO_CARGO As Integer = 0
  Const const_GridTipoCargo_NomeTipoCargo As Integer = 1
  Const const_GridTipoCargo_TipoFuncao As Integer = 2

  Const const_GridTipoContato_SQ_TIPO_CONTATO As Integer = 0
  Const const_GridTipoContato_NomeTipoContato As Integer = 1
  Const const_GridTipoContato_IC_SISTEMA As Integer = 2

  Const const_GridTipoDocumento_SQ_TIPO_DOCUMENTO As Integer = 0
  Const const_GridTipoDocumento_NomeTipoDocumento As Integer = 1
  Const const_GridTipoDocumento_ID_OPT_INSTITUICAO_GERADORA As Integer = 2
  Const const_GridTipoDocumento_ID_OPT_UTILIZACAOFINANCEIRO As Integer = 3
  Const const_GridTipoDocumento_IC_COMPENSAR As Integer = 4
  Const const_GridTipoDocumento_IC_CADASTRAR_DOCUMENTO As Integer = 5
  Const const_GridTipoDocumento_IC_CADASTRAR_CONTABANCARIA As Integer = 6
  Const const_GridTipoDocumento_IC_FLUXOCAIXA As Integer = 7
  Const const_GridTipoDocumento_IC_QUITAR_AUTOMATICAMENTE As Integer = 8
  Const const_GridTipoDocumento_IC_ATIVO As Integer = 9
  Const const_GridTipoDocumento_IC_SISTEMA As Integer = 10

  Const const_GridTipoEndereco_SQ_TIPO_ENDERECO As Integer = 0
  Const const_GridTipoEndereco_NomeTipoEndereco As Integer = 1
  Const const_GridTipoEndereco_IC_SISTEMA As Integer = 2

  Const const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE As Integer = 0
  Const const_GridTipoEscolaridade_NomeTipoEscolaridade As Integer = 1

  Const const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL As Integer = 0
  Const const_GridTipoEstadoCivil_NomeEstadoCivil As Integer = 1

  Const const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL As Integer = 0
  Const const_GridTipoMidiaSocial_NomeMidiaSocial As Integer = 1
  Const const_GridTipoMidiaSocial_IC_SISTEMA As Integer = 2

  Const const_GridTipoPaciente_SQ_TIPO_PACIENTE As Integer = 0
  Const const_GridTipoPaciente_NomeTipoPaciente As Integer = 1

  Const const_GridTipoPessoa_SQ_TIPO_PESSOA As Integer = 0
  Const const_GridTipoPessoa_FisicoJuridico As Integer = 1
  Const const_GridTipoPessoa_NomeTipoPessoa As Integer = 2
  Const const_GridTipoPessoa_IC_SISTEMA As Integer = 3

  Const const_GridTipoProduto_SQ_TIPO_PRODUTO As Integer = 0
  Const const_GridTipoProduto_NomeTipoProduto As Integer = 1

  Const const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO As Integer = 0
  Const const_GridTipoQuestionario_NomeTipoQuestionario As Integer = 1
  Const const_GridTipoQuestionario_TipoCampo As Integer = 2

  Const const_GridTipoRaca_SQ_TIPO_RACA As Integer = 0
  Const const_GridTipoRaca_NomeTipoRaca As Integer = 1

  Const const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA As Integer = 0
  Const const_GridTipoReferenciaPessoal_TipoPessoa As Integer = 1
  Const const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa As Integer = 2

  Const const_GridProdutoLinha_SQ_PRODUTO_LINHA As Integer = 0
  Const const_GridProdutoLinha_TipoLinhaProduto As Integer = 1
  Const const_GridProdutoLinha_NomeLinhaProduto As Integer = 2
  Const const_GridProdutoLinha_ProdutoIndicacao As Integer = 3
  Const const_GridProdutoLinha_UnidadeMedida As Integer = 4
  Const const_GridProdutoLinha_Ativo As Integer = 5

  Const const_GridTipoReligiao_SQ_TIPO_RELIGIAO As Integer = 0
  Const const_GridTipoReligiao_NomeTipoReligiao As Integer = 1

  Const const_GridTipoSexo_SQ_TIPO_SEXO As Integer = 0
  Const const_GridTipoSexo_NomeTipoSexo As Integer = 1

  Const const_GridTipoTelefone_SQ_TIPO_TELEFONE As Integer = 0
  Const const_GridTipoTelefone_NomeTipoTelefone As Integer = 1

  Const const_GridDepartamento_SQ_DEPARTAMENTO As Integer = 0
  Const const_GridDepartamento_NomeDepartamento As Integer = 1
  Const const_GridDepartamento_Ativo As Integer = 2
  Const const_GridDepartamento_IC_SISTEMA As Integer = 3

  Const const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA As Integer = 0
  Const const_GridTipoContaFinanceira_NomeTipoContaBancaria As Integer = 1

  Const const_GridTipoConsulta_SQ_TIPO_CONSULTA As Integer = 0
  Const const_GridTipoConsulta_NO_TIPO_CONSULTA As Integer = 1
  Const const_GridTipoConsulta_ID_OPT_ As Integer = 2
  Const const_GridTipoConsulta_IC_ATIVO As Integer = 3
  Const const_GridTipoConsulta_IC_TIPO_RETORNO As Integer = 4

  Const const_GridNaturezaOperacao_SQ_NATUREZAOPERACAO As Integer = 0
  Const const_GridNaturezaOperacao_NomeNaturezaOperacao As Integer = 1
  Const const_GridNaturezaOperacao_CFOP_DentroEstado As Integer = 2
  Const const_GridNaturezaOperacao_CFOP_ForaEstado As Integer = 3
  Const const_GridNaturezaOperacao_CFOP_ForaPais As Integer = 4
  Const const_GridNaturezaOperacao_PlanoContas As Integer = 5
  Const const_GridNaturezaOperacao_Finalidade As Integer = 6
  Const const_GridNaturezaOperacao_BaseICMS As Integer = 7
  Const const_GridNaturezaOperacao_BaseICMSST As Integer = 8
  Const const_GridNaturezaOperacao_CalcularIPI As Integer = 9
  Const const_GridNaturezaOperacao_Referencia As Integer = 10
  Const const_GridNaturezaOperacao_PermiteCreditoICMS As Integer = 11
  Const const_GridNaturezaOperacao_DestacaImpFedEstMunic As Integer = 12
  Const const_GridNaturezaOperacao_ExigePedido As Integer = 13
  Const const_GridNaturezaOperacao_GerarFinanceiro As Integer = 14
  Const const_GridNaturezaOperacao_MovimentarEstoque As Integer = 15
  Const const_GridNaturezaOperacao_BloquearEstoque As Integer = 16
  Const const_GridNaturezaOperacao_StatusNumeroSerieBloqueado As Integer = 17
  Const const_GridNaturezaOperacao_TipoDocumentoFiscal As Integer = 18
  Const const_GridNaturezaOperacao_SerieDocumentoFiscal As Integer = 19
  Const const_GridNaturezaOperacao_UsarOrcamento As Integer = 20
  Const const_GridNaturezaOperacao_Ativo As Integer = 21

  Const const_GridCondicaoPagamento_SQ_CONDICAOPAGAMENTO As Integer = 0
  Const const_GridCondicaoPagamento_CD_CONDICAOPAGAMENTO As Integer = 1
  Const const_GridCondicaoPagamento_NO_CONDICAOPAGAMENTO As Integer = 2
  Const const_GridCondicaoPagamento_NO_FORMAPAGAMENTO_ENTRADA_PADRAO As Integer = 3
  Const const_GridCondicaoPagamento_NO_FORMAPAGAMENTO_PARCELA_PADRAO As Integer = 4
  Const const_GridCondicaoPagamento_NO_TIPO_DOCUMENTO_ENTRADA_PADRAO As Integer = 5
  Const const_GridCondicaoPagamento_NO_TIPO_DOCUMENTO_PARCELA_PADRAO As Integer = 6
  Const const_GridCondicaoPagamento_QT_PARCELA As Integer = 7
  Const const_GridCondicaoPagamento_QT_PARCELA_DIASPRIMEIRAPARCELA As Integer = 8
  Const const_GridCondicaoPagamento_QT_PARCELA_DIASINTERVALO As Integer = 9
  Const const_GridCondicaoPagamento_PC_ACRESCIMO As Integer = 10
  Const const_GridCondicaoPagamento_PC_ENTRADA As Integer = 11
  Const const_GridCondicaoPagamento_PC_JUROS As Integer = 12
  Const const_GridCondicaoPagamento_PC_TAXA_COMPENSACAO As Integer = 13
  Const const_GridCondicaoPagamento_NO_OPT_PERIODOCALCULOFINANCEIRO_JUROS As Integer = 14
  Const const_GridCondicaoPagamento_IC_GERAR_AVISTA As Integer = 15
  Const const_GridCondicaoPagamento_IC_USAR_RECEBIMENTO As Integer = 16
  Const const_GridCondicaoPagamento_IC_USAR_VENDA As Integer = 17
  Const const_GridCondicaoPagamento_IC_ATIVO As Integer = 18

  Const const_GridContabilizacao_SQ_CONTABILIZACAO As Integer = 0
  Const const_GridContabilizacao_NO_CONTABILIZACAO As Integer = 1
  Const const_GridContabilizacao_IC_ATIVO As Integer = 2

  Const const_GridTabelaPreco_SQ_TABELAPRECO As Integer = 0
  Const const_GridTabelaPreco_NO_TABELAPRECO As Integer = 1
  Const const_GridTabelaPreco_DT_INICIO_USO As Integer = 2
  Const const_GridTabelaPreco_DT_FIM_USO As Integer = 3
  Const const_GridTabelaPreco_DT_ULTIMO_REAJUSTE As Integer = 4
  Const const_GridTabelaPreco_PC_DESCONTO_MAXIMO As Integer = 5
  Const const_GridTabelaPreco_PC_MARGEM_LUCRO As Integer = 6
  Const const_GridTabelaPreco_PC_COMISSAO As Integer = 7
  Const const_GridTabelaPreco_IC_DISPONIVEL_FILIAL As Integer = 8

  Const const_GridEstoque_SQ_ESTOQUE As Integer = 0
  Const const_GridEstoque_ID_DEPARTAMENTO_RESPONSAVEL As Integer = 1
  Const const_GridEstoque_CD_ESTOQUE As Integer = 2
  Const const_GridEstoque_NO_ESTOQUE As Integer = 3
  Const const_GridEstoque_IC_CONTROLA_MINIMOS As Integer = 4
  Const const_GridEstoque_IC_PERMITE_BLOQUEIO As Integer = 5
  Const const_GridEstoque_IC_ATIVO As Integer = 6
  Const const_GridEstoque_IC_PERMITE_SALDO_NEGATIVO As Integer = 7
  Const const_GridEstoque_IC_ENTRADA_AUTOMATICA As Integer = 8

  Const const_GridTransacaoEstoque_SQ_TRANSACAOESTOQUE As Integer = 0
  Const const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO As Integer = 1
  Const const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO As Integer = 2
  Const const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE As Integer = 3
  Const const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE As Integer = 4
  Const const_GridTransacaoEstoque_IC_USAR_RECEBIMENTO As Integer = 5
  Const const_GridTransacaoEstoque_IC_USAR_VENDA As Integer = 6
  Const const_GridTransacaoEstoque_IC_USAR_MOVIMENTACAOMANUAL As Integer = 7
  Const const_GridTransacaoEstoque_IC_ATIVO As Integer = 8
  Const const_GridTransacaoEstoque_IC_EM_USO As Integer = 9

  Const const_GridServico_SQ_SERVICO As Integer = 0
  Const const_GridServico_ID_TIPO_SERVICO As Integer = 1
  Const const_GridServico_CD_SERVICO As Integer = 2
  Const const_GridServico_NO_SERVICO As Integer = 3
  Const const_GridServico_IC_GERAFINANCEIRO As Integer = 4
  Const const_GridServico_IC_ATIVO As Integer = 5

  Const const_GridModeloDocumentoElemento_SQ_MODELODOCUMENTO_ELEMENTO As Integer = 0
  Const const_GridModeloDocumentoElemento_NO_MODELODOCUMENTO_ELEMENTO As Integer = 1
  Const const_GridModeloDocumentoElemento_IC_SISTEMA As Integer = 2

  Const const_GridTipoServico_SQ_TIPO_SERVICO As Integer = 0
  Const const_GridTipoServico_NomeTipoServico As Integer = 1

  Const const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO As Integer = 0
  Const const_GridPlanoContasGrupo_ID_PLANOCONTAS_GRUPO_SUPERIOR As Integer = 1
  Const const_GridPlanoContasGrupo_CodigoGrupoProduto As Integer = 2
  Const const_GridPlanoContasGrupo_NomeGrupoProduto As Integer = 3

  Const const_GridSegmento_SQ_SEGMENTO As Integer = 0
  Const const_GridSegmento_NomeSegmento As Integer = 1
  Const const_GridSegmento_Ativo As Integer = 2

  Const const_GridConselhoProfissional_SQ_CONSELHOPROFISSIONAL As Integer = 0
  Const const_GridConselhoProfissional_CD_CONSELHOPROFISSIONAL As Integer = 1
  Const const_GridConselhoProfissional_NO_CONSELHOPROFISSIONAL As Integer = 2

  Const const_GridCaracteristicaProduto_SQ_CARACTERISTICA_PRODUTO As Integer = 0
  Const const_GridCaracteristicaProduto_NO_CARACTERISTICA As Integer = 1

  Const const_GridFinanciamento_SQ_FINANCIAMENTO As Integer = 0
  Const const_GridFinanciamento_NO_FINANCIAMENTO As Integer = 1
  Const const_GridFinanciamento_NO_FINANCIADOR As Integer = 2
  Const const_GridFinanciamento_NO_MODELODOCUMENTO_CONTRATO As Integer = 3
  Const const_GridFinanciamento_NR_MINIMO_PARCELA As Integer = 4
  Const const_GridFinanciamento_NR_MAXIMO_PARCELA As Integer = 5
  Const const_GridFinanciamento_PC_ENTRADA As Integer = 6
  Const const_GridFinanciamento_PC_JUROS As Integer = 7
  Const const_GridFinanciamento_IC_ATIVO As Integer = 8

  Const const_GridGrupoTributario_SQ_GRUPOTRIBUTARIO As Integer = 0
  Const const_GridGrupoTributario_NO_GRUPOTRIBUTARIO As Integer = 1
  Const const_GridGrupoTributario_PC_COFINS As Integer = 2
  Const const_GridGrupoTributario_PC_PIS As Integer = 3
  Const const_GridGrupoTributario_PC_II As Integer = 4
  Const const_GridGrupoTributario_IC_ATIVO As Integer = 5

  Const const_GridDocumentoFiscalSerie_SQ_DOCUMENTOFISCAL_SERIE As Integer = 0
  Const const_GridDocumentoFiscalSerie_ID_DOCUMENTOFISCAL_TIPO As Integer = 1
  Const const_GridDocumentoFiscalSerie_CD_DOCUMENTOFISCAL_SERIE As Integer = 2
  Const const_GridDocumentoFiscalSerie_CD_ULTIMAEMISSAO_NUMERO As Integer = 3
  Const const_GridDocumentoFiscalSerie_IC_PADRAO_VENDA As Integer = 4
  Const const_GridDocumentoFiscalSerie_IC_ATIVO As Integer = 5

  Const const_GridDocumentoFiscalInutilizado_SQ_DOCUMENTOFISCAL_INUTILIZACAO As Integer = 0
  Const const_GridDocumentoFiscalInutilizado_NO_DOCUMENTOFISCAL_TIPO As Integer = 1
  Const const_GridDocumentoFiscalInutilizado_CD_SERVICO_MODELO As Integer = 2
  Const const_GridDocumentoFiscalInutilizado_CD_DOCUMENTOFISCAL_SERIE As Integer = 3
  Const const_GridDocumentoFiscalInutilizado_DH_INUTILIZACAO As Integer = 4
  Const const_GridDocumentoFiscalInutilizado_CD_DOCUMENTOFISCAL_INICIAL As Integer = 5
  Const const_GridDocumentoFiscalInutilizado_CD_DOCUMENTOFISCAL_FINAL As Integer = 6
  Const const_GridDocumentoFiscalInutilizado_CM_JUSTIFICATIVA As Integer = 7

  Const const_GridDocumentoFiscalTipo_SQ_DOCUMENTOFISCAL_TIPO As Integer = 0
  Const const_GridDocumentoFiscalTipo_ID_OPT_NFE_TIPOOPERACAO As Integer = 1
  Const const_GridDocumentoFiscalTipo_ID_OPT_NFE_FORMATOIMPRESSAODANFE As Integer = 2
  Const const_GridDocumentoFiscalTipo_NO_DOCUMENTOFISCAL_TIPO As Integer = 3
  Const const_GridDocumentoFiscalTipo_CD_DOCUMENTOFISCAL_TIPO As Integer = 4
  Const const_GridDocumentoFiscalTipo_CD_SERVICO_MODELO As Integer = 5
  Const const_GridDocumentoFiscalTipo_CD_SERVICO_VERSAO As Integer = 6
  Const const_GridDocumentoFiscalTipo_IC_ATIVO As Integer = 7
  Const const_GridDocumentoFiscalTipo_ID_OPT_EXIGE_PESSOA As Integer = 8
  Const const_GridDocumentoFiscalTipo_ID_OPT_EXIGE_ENDERECO As Integer = 9
  Const const_GridDocumentoFiscalTipo_ID_TIPO_DOCUMENTO As Integer = 10

  Const const_GridVacina_SQ_VACINA As Integer = 0
  Const const_GridVacina_NO_VACINA As Integer = 1
  Const const_GridVacina_DS_SERVENTIA As Integer = 2
  Const const_GridVacina_DS_INICIO As Integer = 3
  Const const_GridVacina_DS_TERMINO As Integer = 4
  Const const_GridVacina_DS_APRAZAMENTO As Integer = 5
  Const const_GridVacina_IC_ATIVO As Integer = 6

  Const const_GridConsultorio_SQ_CONSULTORIO As Integer = 0
  Const const_GridConsultorio_CD_CONSULTORIO As Integer = 1
  Const const_GridConsultorio_NO_CONSULTORIO As Integer = 2
  Const const_GridConsultorio_IC_ATIVO As Integer = 3

  Const const_GridGrupoProcedimento_SQ_GRUPOPROCEDIMENTO As Integer = 0
  Const const_GridGrupoProcedimento_NO_GRUPOPROCEDIMENTO As Integer = 1
  Const const_GridGrupoProcedimento_ID_PLANOCONTAS As Integer = 2
  Const const_GridGrupoProcedimento_ID_PLANOCONTAS_CONTASPAGAR As Integer = 3
  Const const_GridGrupoProcedimento_TP_BLOQUEAR_AGENDAMENTO_DUPLICADO As Integer = 4

  Const const_GridTurno_SQ_TURNO As Integer = 0
  Const const_GridTurno_NO_TURNO As Integer = 1
  Const const_GridTurno_HR_INICIO As Integer = 2
  Const const_GridTurno_HR_FIM As Integer = 3

  Const const_GridClassificacaoExame_SQ_CLASSIFICACAO_EXAME As Integer = 0
  Const const_GridClassificacaoExame_NO_CLASSIFICACAO_EXAME As Integer = 1

  Const const_GridTipoRelatorio_SQ_TIPO_RELATORIO As Integer = 0
  Const const_GridTipoRelatorio_NO_TIPO_RELATORIO As Integer = 1

  Const const_GridTipoIndicador_SQ_TIPOINDICADOR As Integer = 0
  Const const_GridTipoIndicador_NO_TIPOINDICADOR As Integer = 1

  Const const_GridCanalMarcacao_SQ_CANALMARCACAO As Integer = 0
  Const const_GridCanalMarcacao_NO_CANALMARCACAO As Integer = 1

  Const const_GridCaixaAtendimento_SQ_CAIXA_ATENDIMENTO As Integer = 0
  Const const_GridCaixaAtendimento_NO_CAIXA_ATENDIMENTO As Integer = 1
  Const const_GridCaixaAtendimento_Localizacao As Integer = 2
  Const const_GridCaixaAtendimento_UsaSistemaChamada As Integer = 3
  Const const_GridCaixaAtendimento_Ativo As Integer = 4

  '>> Tela de Listagem Geral
  Public Enum enListagemGeral_TipoTela
    CadastroPlanoContas = 1001
    CadastroProfissao = 1002
    CadastroCargo = 1003
    CadastroCidade = 1004
    CadastroUF = 1005
    CadastroPais = 1006
    CadastroConvenio = 1007
    CadastroGrupoProduto = 1008
    CadastroUnidadeMedida = 1009
    CadastroEspecialidade = 1010
    CadastroBanco = 1011
    CadastroContaBancaria = 1012
    CadastroContaCaixa = 1013
    CadastroFormaPagamento = 1014
    CadastroTipoCargo = 1015
    CadastroTipoContato = 1016
    CadastroTipoDocumento = 1017
    CadastroTipoEndereco = 1018
    CadastroTipoEscolaridade = 1019
    CadastroTipoEstadoCivil = 1020
    CadastroTipoMidiaSocial = 1021
    CadastroTipoPaciente = 1022
    CadastroTipoPessoa = 1023
    CadastroTipoProduto = 1024
    CadastroTipoQuestionario = 1025
    CadastroTipoRaca = 1026
    CadastroTipoReferenciaPessoa = 1027
    CadastroTipoReligiao = 1028
    CadastroTipoSexo = 1029
    CadastroTipoTelefone = 1030
    CadastroDepartamento = 1031
    CadastroTipoContaFinanceira = 1032
    CadastroTipoConsulta = 1033
    CadastroNaturezaOperacao = 1034
    CadastroTabelaPreco = 1035
    CadastroEstoque = 1036
    CadastroTransacaoEstoque = 1037
    CadastroDoencaEstagio = 1038
    CadastroGrupoPermissao = 1039
    CadastroModeloDocumentoElemento_Assinatura = 1040
    CadastroModeloDocumentoElemento_Cabecalho = 1041
    CadastroModeloDocumentoElemento_Rodape = 1042
    CadastroTipoServico = 1043
    CadastroServico = 1044
    CadastroPlanoContasGrupo = 1045
    CadastroSegmento_ContasReceberContasPagar = 1046
    CadastroSegmento_OrdemServico = 1047
    CadastroCondicaoPagamento = 1048
    CadastroContabilizacao = 1049
    CadastroCanalNegocio = 1050
    CadastroProdutoLinha = 1051
    CadastroCaracteristicaProduto = 1052
    CadastroConselhoProfissional = 1053
    CadastroFinanciamento = 1054
    CadastroGrupoTributario = 1055
    CadastroDocumentoFiscalSerie = 1056
    CadastroDocumentoFiscalInutilizado = 1057
    CadastroDocumentoFiscalTipo = 1058
    CadastroVacina = 1059
    CadastroConsultorio = 1060
    CadastroGrupoProcedimento = 1061
    CadastroTurno = 1062
    CadastroClassificacaoExame = 1063
    CadastroTipoRelatorio = 1064
    CadastroTipoIndicador = 1065
    CadastroCanalMarcacao = 1066
    CadastroCaixaAtendimento = 1067
  End Enum

  Public eListagemGeral_TipoTela As enListagemGeral_TipoTela

  Dim bEdicao As Boolean = True
  Dim bSoInclusao As Boolean = False
  Dim oDBListagem As New UltraWinDataSource.UltraDataSource
  Dim bLinhaExcluida As Boolean
  Dim oPermissao As clsPermissao

  Private Sub frmListaGeral_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
    grdListagem.PerformAction(UltraGridAction.ToggleDropdown, False, False)
  End Sub

  Private Sub frmListaGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Formatar()

    Try
      If Not oPermissao Is Nothing Then
        cmdNovo.Enabled = oPermissao.bIncluir
        cmdAlterar.Enabled = oPermissao.bAlterar
        cmdExcluir.Enabled = oPermissao.bExcluir
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub Formatar()
    AjustarTela()

    If eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroNaturezaOperacao Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroTabelaPreco Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroEstoque Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroCondicaoPagamento Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroContabilizacao Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroCaracteristicaProduto Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroProdutoLinha Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroFinanciamento Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroGrupoTributario Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroConvenio Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroEspecialidade Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroContaCaixa Or
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroContaBancaria Then
      bEdicao = False
    End If

    If eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroDocumentoFiscalInutilizado Then
      bSoInclusao = True
    End If

    objGrid_Inicializar(grdListagem,
                        IIf(bEdicao, AllowAddNew.FixedAddRowOnTop, AllowAddNew.Default),
                        oDBListagem,
                        UltraWinGrid.CellClickAction.RowSelect,
                        IIf(bEdicao, DefaultableBoolean.True, DefaultableBoolean.False),
                        IIf(bEdicao, DefaultableBoolean.True, DefaultableBoolean.False),
                        True, , , , True)

    If eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroDocumentoFiscalTipo Then
      grdListagem.DisplayLayout.Bands(0).Override.AllowAddNew = AllowAddNew.No
    End If

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroVacina
        Me.Text = "Cadastro de Vacina"

        lblRotuloListagem.Text = "Listagem de Vacina"
        objGrid_Coluna_Add(grdListagem, "SQ_VACINA", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Vacina", 300, , True, , , , , , 200)
        objGrid_Coluna_Add(grdListagem, "Serventia", 400, , True, , , , , , 2000)
        objGrid_Coluna_Add(grdListagem, "Início", 150, , True, , , , , , 200)
        objGrid_Coluna_Add(grdListagem, "Término", 150, , True, , , , , , 200)
        objGrid_Coluna_Add(grdListagem, "Aprazamento", 150, , True, , , , , , 200)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        oPermissao = FNC_Permissao(enPermissao.CADA_Clinica_Vacina)
      Case enListagemGeral_TipoTela.CadastroConsultorio
        Me.Text = "Cadastro de Consultório"

        lblRotuloListagem.Text = "Listagem de Consultório"
        objGrid_Coluna_Add(grdListagem, "SQ_CONSULTORIO", 0)
        objGrid_Coluna_Add(grdListagem, "Código do Consultório", 200, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Consultório", 500, , True, , , , , , 200)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        oPermissao = FNC_Permissao(enPermissao.CADA_Clinica_Consultorio)
      Case enListagemGeral_TipoTela.CadastroCanalNegocio
        Me.Text = "Cadastro de Canal de Negócio"

        lblRotuloListagem.Text = "Listagem de Canal de Negócio"
        objGrid_Coluna_Add(grdListagem, "SQ_CANALNEGOCIO", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Canal de Negócio", 300, , True, , FNC_CarregarLista(enTipoCadastro.TipoCanalNegocio))
        objGrid_Coluna_Add(grdListagem, "Nome do Canal de Negócio", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Contabilização", 300, , True, , FNC_CarregarLista(enTipoCadastro.Contabilizacao))
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        Me.Text = "Cadastro de Plano de Contas"

        lblRotuloListagem.Text = "Listagem de Plano de Contas"
        objGrid_Coluna_Add(grdListagem, "SQ_PLANOCONTAS", 0)
        objGrid_Coluna_Add(grdListagem, "Grupo de Plano de Contas", 300, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContasGrupo))
        objGrid_Coluna_Add(grdListagem, "Código do Plano de Contas", 180, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Plano de Contas", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Crédito/Débito", 200, , True, , FNC_CarregarLista(enTipoCadastro.CreditoDebito))
        objGrid_Coluna_Add(grdListagem, "Tipo de Custo", 200, , True, , FNC_CarregarLista(enTipoCadastro.TipoCustoPlanoContas))
        objGrid_Coluna_Add(grdListagem, "Código do Plano de Contas Contabilidade", 250, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        oPermissao = FNC_Permissao(enPermissao.FINA_GrupoPlanodeContas)
      Case enListagemGeral_TipoTela.CadastroProfissao
        Me.Text = "Cadastro de Profissão"

        lblRotuloListagem.Text = "Listagem de Profissões"
        objGrid_Coluna_Add(grdListagem, "SQ_PROFISSAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Profissão", 400, , True, , , , , , 100)
        oPermissao = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroProfissao)
      Case enListagemGeral_TipoTela.CadastroGrupoProcedimento
        Me.Text = "Cadastro de Grupo de Procedimento"

        lblRotuloListagem.Text = "Listagem de Grupo de Procedimento"
        objGrid_Coluna_Add(grdListagem, "SQ_GRUPOPROCEDIMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Grupo de Procedimento", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Plano de Contas", 300, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContas_Credito))
        objGrid_Coluna_Add(grdListagem, "Plano de Contas Contas a Pagar", 300, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContas_Debito))
        objGrid_Coluna_Add(grdListagem, "Bloquear Agendamento Duplicado", 150, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        oPermissao = FNC_Permissao(enPermissao.CADA_Clinica_GrupoProcedimento)
      Case enListagemGeral_TipoTela.CadastroConselhoProfissional
        Me.Text = "Cadastro de Conselho Profissional"

        lblRotuloListagem.Text = "Listagem de Conselho Profissional"
        objGrid_Coluna_Add(grdListagem, "SQ_CONSELHOPROFISSIONAL", 0)
        objGrid_Coluna_Add(grdListagem, "Código da Conselho Profissional", 200, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Nome da Conselho Profissional", 400, , True, , , , , , 100)
        oPermissao = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroConselhoProfissional)
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura
        Me.Text = "Cadastro de Modelos de Documento - Assinatura"

        lblRotuloListagem.Text = "Listagem de Assinatura"
        objGrid_Coluna_Add(grdListagem, "SQ_MODELODOCUMENTO_ELEMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Assinatura", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho
        Me.Text = "Cadastro de Modelos de Documento - Cabeçalho"

        lblRotuloListagem.Text = "Listagem de Cabeçalho"
        objGrid_Coluna_Add(grdListagem, "SQ_MODELODOCUMENTO_ELEMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Cabeçalho", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        Me.Text = "Cadastro de Modelos de Documento - Rodapé"

        lblRotuloListagem.Text = "Listagem de Rodapé"
        objGrid_Coluna_Add(grdListagem, "SQ_MODELODOCUMENTO_ELEMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Rodapé", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroCaracteristicaProduto
        Me.Text = "Cadastro de Características de Produto"

        lblRotuloListagem.Text = "Características de Produto"
        objGrid_Coluna_Add(grdListagem, "SQ_CARACTERISTICA_PRODUTO", 0)
        objGrid_Coluna_Add(grdListagem, "Características", 400, , False, , , , , , 100)
      Case enListagemGeral_TipoTela.CadastroCargo
        Me.Text = "Cadastro de Função"

        lblRotuloListagem.Text = "Listagem de Função"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CARGO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Função", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroFuncao)
      Case enListagemGeral_TipoTela.CadastroClassificacaoExame
        Me.Text = "Cadastro de Classificação de Exame"

        lblRotuloListagem.Text = "Listagem de Classificação de Exame"
        objGrid_Coluna_Add(grdListagem, "SQ_CLASSIFICACAO_EXAME", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Classificação de Exame", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Clinica_ClassificacaoExame)
      Case enListagemGeral_TipoTela.CadastroGrupoPermissao
        Me.Text = "Cadastro de Grupo de Permissão"

        lblRotuloListagem.Text = "Listagem de Grupo de Permissão"
        objGrid_Coluna_Add(grdListagem, "SQ_GRUPOPERMISSAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Grupo de Permissão", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Segurança_GrupoPerimssoes)
      Case enListagemGeral_TipoTela.CadastroCidade
        Me.Text = "Cadastro de Cidade"

        lblRotuloListagem.Text = "Listagem de Cidade"
        objGrid_Coluna_Add(grdListagem, "SQ_CIDADE", 0)
        objGrid_Coluna_Add(grdListagem, "U.F.", 100, , True, , FNC_CarregarLista(enTipoCadastro.UF))
        objGrid_Coluna_Add(grdListagem, "Nome da Cidade", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Código do IBGE", 150, , True, ColumnStyle.IntegerPositive, , , , , 7)
        oPermissao = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroCidade)
      Case enListagemGeral_TipoTela.CadastroUF
        Me.Text = "Cadastro de U.F."

        lblRotuloListagem.Text = "Listagem de U.F."
        objGrid_Coluna_Add(grdListagem, "SQ_UF", 0)
        objGrid_Coluna_Add(grdListagem, "País", 100, , True, , FNC_CarregarLista(enTipoCadastro.Pais))
        objGrid_Coluna_Add(grdListagem, "Nome da U.F.", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Código da U.F.", 150, , True, , , , , , 2)
        oPermissao = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroUF)
      Case enListagemGeral_TipoTela.CadastroPais
        Me.Text = "Cadastro de País"

        lblRotuloListagem.Text = "Listagem de País"
        objGrid_Coluna_Add(grdListagem, "SQ_PAIS", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do País", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Nome da Nascionalidade", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
        oPermissao = FNC_Permissao(enPermissao.CADA_Pessoa_CadastrodePais)
      Case enListagemGeral_TipoTela.CadastroConvenio
        Me.Text = "Cadastro de Convênio"

        lblRotuloListagem.Text = "Listagem de Convênio"
        objGrid_Coluna_Add(grdListagem, "SQ_CONVENIO", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo do Convênio", 120)
        objGrid_Coluna_Add(grdListagem, "Nome do Convênio", 350)
        objGrid_Coluna_Add(grdListagem, "Administradora", 350)
        objGrid_Coluna_Add(grdListagem, "Código do Contrato", 200)
        objGrid_Coluna_Add(grdListagem, "Dia de Corte", 100)
        objGrid_Coluna_Add(grdListagem, "Dia de Prev. Pagto.", 100)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70,)
        objGrid_Coluna_Add(grdListagem, "Controla Crédito", 100)
        objGrid_Coluna_Add(grdListagem, "Solicitar Senha de Supervisão", 150)
        objGrid_Coluna_Add(grdListagem, "Valor do Crédito", 150, , , ,, const_Formato_Valor)
        oPermissao = FNC_Permissao(enPermissao.CADA_Clinica_Convenio)
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        Me.Text = "Cadastro de Grupo de Produto"

        lblRotuloListagem.Text = "Listagem de Grupo de Produto"
        objGrid_Coluna_Add(grdListagem, "SQ_GRUPOPRODUTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Grupo de Produto", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "CST Padrão", 300, , True, , FNC_CarregarLista(enTipoCadastro.CST))
        objGrid_Coluna_Add(grdListagem, "CSOSN Padrão", 300, , True, , FNC_CarregarLista(enTipoCadastro.CSOSN))
        objGrid_Coluna_Add(grdListagem, "CST Cofins Padrão", 300, , True, , FNC_CarregarLista(enTipoCadastro.CSTCofins))
        objGrid_Coluna_Add(grdListagem, "CST PIS Padrão", 300, , True, , FNC_CarregarLista(enTipoCadastro.CSTPIS))
        objGrid_Coluna_Add(grdListagem, "CST IPI Padrão", 300, , True, , FNC_CarregarLista(enTipoCadastro.CSTIPI))
        objGrid_Coluna_Add(grdListagem, "Controla Estoque", 150, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Controle de Garantia", 150, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Controla Nº de Série", 150, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Transação de Estoque Padrão para Recebimentos", 300, , True, , FNC_CarregarLista(enTipoCadastro.TransacaoEstoque_Recebimento))
        objGrid_Coluna_Add(grdListagem, "Transação de Estoque Padrão para Vendas", 300, , True, , FNC_CarregarLista(enTipoCadastro.TransacaoEstoque_Venda))
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
      Case enListagemGeral_TipoTela.CadastroUnidadeMedida
        Me.Text = "Cadastro de Unidade Medida"

        lblRotuloListagem.Text = "Listagem de Unidade Medida"
        objGrid_Coluna_Add(grdListagem, "SQ_UNIDADEMEDIDA", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Unidade Medida", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Código da Unidade Medida", 200, , True, , , , , , 5, CharacterCasing.Upper)
        objGrid_Coluna_Add(grdListagem, "Código de Unidade Medida Compatível", 200, , True, , , , , , 20, CharacterCasing.Upper)
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        Me.Text = "Cadastro de Especialidade"

        lblRotuloListagem.Text = "Listagem de Especialidade"
        objGrid_Coluna_Add(grdListagem, "SQ_ESPECIALIDADE", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Especialidade", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        oPermissao = FNC_Permissao(enPermissao.CADA_Clinica_Especialidade)
      Case enListagemGeral_TipoTela.CadastroBanco
        Me.Text = "Cadastro de Banco"

        lblRotuloListagem.Text = "Listagem de Banco"
        objGrid_Coluna_Add(grdListagem, "SQ_BANCO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Banco", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Número do Banco", 150, , True, ColumnStyle.IntegerPositive)
        oPermissao = FNC_Permissao(enPermissao.FINA_Banco)
      Case enListagemGeral_TipoTela.CadastroContaBancaria
        Me.Text = "Cadastro de Conta Bancária"

        lblRotuloListagem.Text = "Listagem de Conta Bancária"
        objGrid_Coluna_Add(grdListagem, "SQ_CONTABANCARIA", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Conta", 150, , True, , FNC_CarregarLista(enTipoCadastro.TipoContaBancaria))
        objGrid_Coluna_Add(grdListagem, "Banco", 300, , True, , FNC_CarregarLista(enTipoCadastro.Banco))
        objGrid_Coluna_Add(grdListagem, "Número da Agência", 100, , True, ColumnStyle.IntegerPositive)
        objGrid_Coluna_Add(grdListagem, "Número da Conta", 100, , True, ColumnStyle.IntegerPositive)
        objGrid_Coluna_Add(grdListagem, "Dígito da Conta", 100, , True)
        objGrid_Coluna_Add(grdListagem, "Dt. Abetura", 100, , True, ColumnStyle.Date)
        objGrid_Coluna_Add(grdListagem, "Controla Saldo", 100, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        oPermissao = FNC_Permissao(enPermissao.FINA_ContaBancaria)
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        Me.Text = "Cadastro de Conta Caixa"

        lblRotuloListagem.Text = "Listagem de Conta Caixa"
        objGrid_Coluna_Add(grdListagem, "SQ_CONTACAIXA", 0)
        objGrid_Coluna_Add(grdListagem, "Departamento", 300, , True, , FNC_CarregarLista(enTipoCadastro.Departamento))
        objGrid_Coluna_Add(grdListagem, "Responsável", 300, , True, , FNC_CarregarLista(enTipoCadastro.Funcionario))
        objGrid_Coluna_Add(grdListagem, "Supervisor", 300, , True, , FNC_CarregarLista(enTipoCadastro.Funcionario))
        objGrid_Coluna_Add(grdListagem, "Nome da Conta Caixa", 300, , True)
        objGrid_Coluna_Add(grdListagem, "Controla Saldo", 100, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "% Desconto Máximo", 200, , True, ColumnStyle.DoublePositive)
        objGrid_Coluna_Add(grdListagem, "Localização", 300, , True)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
        oPermissao = FNC_Permissao(enPermissao.FINA_ContaCaixa)
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        Me.Text = "Cadastro de Forma de Pagamento"

        lblRotuloListagem.Text = "Listagem de Forma de Pagamento"
        objGrid_Coluna_Add(grdListagem, "SQ_FORMAPAGAMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 250, , True, , FNC_CarregarLista(enTipoCadastro.TipoDocumento))
        objGrid_Coluna_Add(grdListagem, "Nome da Forma de Pagamento", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Tipo de Doc. Financ. Cadastrado", 250, , True, , FNC_CarregarLista(enTipoCadastro.TipoDocumentoFinanceiroCadastrado))
        objGrid_Coluna_Add(grdListagem, "Classe de Conta Finan. Quitação", 250, , True, , FNC_CarregarLista(enTipoCadastro.ClasseTipoContaFinanceira))
        objGrid_Coluna_Add(grdListagem, "Conta Financeiro Quitação", 250, , True, , FNC_CarregarLista(enTipoCadastro.ContaFinanceira))
        oPermissao = FNC_Permissao(enPermissao.FINA_FormaPagamento)
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        Me.Text = "Cadastro de Cargo"

        lblRotuloListagem.Text = "Listagem de Cargo"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CARGO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Cargo", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Tipo de Função", 250, , True, , FNC_CarregarLista(enTipoCadastro.TipoFuncao))
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoCargo)
      Case enListagemGeral_TipoTela.CadastroTipoContato
        Me.Text = "Cadastro de Tipo de Contato"

        lblRotuloListagem.Text = "Listagem de Tipo de Contato"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CONTATO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Contato", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroTipoDocumento
        Me.Text = "Cadastro de Tipo de Documento"

        lblRotuloListagem.Text = "Listagem de Tipo de Documento"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_DOCUMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Documento", 400, , True)
        objGrid_Coluna_Add(grdListagem, "Instituição Geradora", 150, , True, , FNC_CarregarLista(enTipoCadastro.TipoInstituicao))
        objGrid_Coluna_Add(grdListagem, "Tipo de Util. Lanç. Finan.", 150, , True, , FNC_CarregarLista(enTipoCadastro.TipoUtilizacaoLançamentoFinanceiro))
        objGrid_Coluna_Add(grdListagem, "Compensar", 100, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Cadastrar Documento", 180, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Cadastrar Cta. Bancária", 200, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Usar no Lanç. Cta. Caixa/Cta. Bancária", 230, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Quitar Automaticamente", 200, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoDocumentoFinanceiro)
      Case enListagemGeral_TipoTela.CadastroGrupoTributario
        Me.Text = "Cadastro de Grupo Tributário"

        lblRotuloListagem.Text = "Listagem de Grupo Tributário"
        objGrid_Coluna_Add(grdListagem, "SQ_GRUPOTRIBUTARIO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Grupo Tributário", 400, , False)
        objGrid_Coluna_Add(grdListagem, "Cofins (%)", 110, , False)
        objGrid_Coluna_Add(grdListagem, "PIS (%)", 110, , False)
        objGrid_Coluna_Add(grdListagem, "II (%)", 110, , False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 110, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        Me.Text = "Cadastro de Tipo de Endereço"

        lblRotuloListagem.Text = "Listagem de Tipo de Endereço"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_ENDERECO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Endereço", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipeEndereco)
      Case enListagemGeral_TipoTela.CadastroTipoEscolaridade
        Me.Text = "Cadastro de Tipo de Escolaridade"

        lblRotuloListagem.Text = "Listagem de Tipo de Escolaridade"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_ESCOLARIDADE", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Escolaridade", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoEscolaridade)
      Case enListagemGeral_TipoTela.CadastroTipoEstadoCivil
        Me.Text = "Cadastro de Tipo de Escolaridade"

        lblRotuloListagem.Text = "Listagem de Tipo de Estado Cívil"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_ESTADOCIVIL", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Estado Cívil", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoEstadoCivil)
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        Me.Text = "Cadastro de Tipo de Mídia Social"

        lblRotuloListagem.Text = "Listagem de Tipo de Mídia Social"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_MIDIASOCIAL", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Mídia Social", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipeEndereco)
      Case enListagemGeral_TipoTela.CadastroTipoPaciente
        Me.Text = "Cadastro de Tipo de Paciente"

        lblRotuloListagem.Text = "Listagem de Tipo de Paciente"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_PACIENTE", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Paciente", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoPaciente)
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        Me.Text = "Cadastro de Tipo de Pessoa"

        lblRotuloListagem.Text = "Listagem de Tipo de Pessoa"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_PESSOA", 0)
        objGrid_Coluna_Add(grdListagem, "Físico/Jurídico", 100, , True, , FNC_CarregarLista(enTipoCadastro.FisicoJuridico))
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Pessoa", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoPessoa)
      Case enListagemGeral_TipoTela.CadastroTipoProduto
        Me.Text = "Cadastro de Tipo de Produto"

        lblRotuloListagem.Text = "Listagem de Tipo de Produto"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_PRODUTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Produto", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoQuestionario
        Me.Text = "Cadastro de Tipo de Questionário"

        lblRotuloListagem.Text = "Listagem de Tipo de Questionário"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_QUESTIONARIO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Questionário", 400, , True)
        objGrid_Coluna_Add(grdListagem, "Tipo de Campo", 100, , True, , FNC_CarregarLista(enTipoCadastro.TipoCampo))
      Case enListagemGeral_TipoTela.CadastroTipoRaca
        Me.Text = "Cadastro de Tipo de Raça"

        lblRotuloListagem.Text = "Listagem de Tipo de Raça"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_RACA", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Raça", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoRaca)
      Case enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa
        Me.Text = "Cadastro de Tipo de Referência de Pessoa"

        lblRotuloListagem.Text = "Listagem de Tipo de Referência de Pessoa"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_REFERENCIAPESSOA", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Pessoa", 100, , True, , FNC_CarregarLista(enTipoCadastro.TipoPessoa))
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Referência de Pessoa", 400, , True)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoReferenciaPessoa)
      Case enListagemGeral_TipoTela.CadastroProdutoLinha
        Me.Text = "Cadastro de Linha de Produto"

        lblRotuloListagem.Text = "Listagem de Linha de Produto"
        objGrid_Coluna_Add(grdListagem, "SQ_PRODUTO_LINHA", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Linha de Produto", 250, , False)
        objGrid_Coluna_Add(grdListagem, "Nome de Linha de Produto", 400, , False)
        objGrid_Coluna_Add(grdListagem, "Produto Indicação", 400, , False)
        objGrid_Coluna_Add(grdListagem, "Unidade de Medida", 250, , False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , False)
      Case enListagemGeral_TipoTela.CadastroFinanciamento
        Me.Text = "Cadastro de Financiamento"

        lblRotuloListagem.Text = "Listagem de Financiamento"
        objGrid_Coluna_Add(grdListagem, "SQ_FINANCIAMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Financiamento", 400, , False)
        objGrid_Coluna_Add(grdListagem, "Financiador", 400, , False)
        objGrid_Coluna_Add(grdListagem, "Modelo de Documento de Contrato", 400, , False)
        objGrid_Coluna_Add(grdListagem, "Nº Mínimo de Parcela", 250, , False)
        objGrid_Coluna_Add(grdListagem, "Nº Máximo de Parcela", 250, , False)
        objGrid_Coluna_Add(grdListagem, "Entrada (%)", 70, , False)
        objGrid_Coluna_Add(grdListagem, "Juros a.m. (%)", 70, , False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , False)
        oPermissao = FNC_Permissao(enPermissao.FINA_Financiamento)
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        Me.Text = "Cadastro de Tipo de Religião"

        lblRotuloListagem.Text = "Listagem de Tipo de Religião"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_RELIGIAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Religião", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoReligiao)
      Case enListagemGeral_TipoTela.CadastroTipoSexo
        Me.Text = "Cadastro de Tipo de Sexo"

        lblRotuloListagem.Text = "Listagem de Tipo de Sexo"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_SEXO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Sexo", 400, , True, , , , , , 50)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoSexo)
      Case enListagemGeral_TipoTela.CadastroTipoTelefone
        Me.Text = "Cadastro de Tipo de Telefone"

        lblRotuloListagem.Text = "Listagem de Tipo de Telefone"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_TELEFONE", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Telefone", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroDepartamento
        Me.Text = "Cadastro de Departamento"

        lblRotuloListagem.Text = "Listagem de Departamento"
        objGrid_Coluna_Add(grdListagem, "SQ_DEPARTAMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Departamento", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroTipoContaFinanceira
        Me.Text = "Cadastro de Tipo de Conta Financeira"

        lblRotuloListagem.Text = "Listagem de Tipo de Conta Financeira"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CONTAFINANCEIRA", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Conta Financeira", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoConsulta
        Me.Text = "Cadastro de Tipo de Consulta"

        lblRotuloListagem.Text = "Listagem de Tipo de Consulta"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CONSULTA", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Consulta", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Retorno", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        oPermissao = FNC_Permissao(enPermissao.CADA_Tipo_TipoConsulta)
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        Me.Text = "Cadastro de Natureza de Operação"

        lblRotuloListagem.Text = "Listagem de Natureza de Operação"
        objGrid_Coluna_Add(grdListagem, "SQ_NATUREZAOPERACAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Natureza de Operação", 400)
        objGrid_Coluna_Add(grdListagem, "C.F.O.P. Dentro do Estado", 160)
        objGrid_Coluna_Add(grdListagem, "C.F.O.P. Fora do Estado", 145)
        objGrid_Coluna_Add(grdListagem, "C.F.O.P. Fora do País", 135)
        objGrid_Coluna_Add(grdListagem, "Plano de Contas", 150)
        objGrid_Coluna_Add(grdListagem, "Finalidade", 150)
        objGrid_Coluna_Add(grdListagem, "Base ICMS (%)", 150, , , ColumnStyle.Double, , const_Formato_Fracao_4casas)
        objGrid_Coluna_Add(grdListagem, "Base ICMS ST (%)", 150, , , ColumnStyle.Double, , const_Formato_Fracao_4casas)
        objGrid_Coluna_Add(grdListagem, "Calcular IPI?", 80).Hidden = False
        objGrid_Coluna_Add(grdListagem, "Referência", 100)
        objGrid_Coluna_Add(grdListagem, "Permite Crédito de ICMS?", 155).Hidden = False
        objGrid_Coluna_Add(grdListagem, "Destaca Imp. Fed., Est. e Munic.", 185).Hidden = False
        objGrid_Coluna_Add(grdListagem, "Exige Pedido", 90)
        objGrid_Coluna_Add(grdListagem, "Gerar Financeiro", 90)
        objGrid_Coluna_Add(grdListagem, "Mov. Estoque", 90)
        objGrid_Coluna_Add(grdListagem, "Bloquear Estoque", 120)
        objGrid_Coluna_Add(grdListagem, "Status de Número de Série Bloqueado", 215)
        objGrid_Coluna_Add(grdListagem, "Tipo de Documento Fiscal", 150)
        objGrid_Coluna_Add(grdListagem, "Série de Documento Fiscal", 150)
        objGrid_Coluna_Add(grdListagem, "Usar no Orçamento", 150)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70)
      Case enListagemGeral_TipoTela.CadastroCondicaoPagamento
        Me.Text = "Cadastro de Condição de Pagamento"

        lblRotuloListagem.Text = "Listagem de Condição de Pagamento"
        objGrid_Coluna_Add(grdListagem, "SQ_CONDICAOPAGAMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Código", 100)
        objGrid_Coluna_Add(grdListagem, "Nome", 400)
        objGrid_Coluna_Add(grdListagem, "Forma Pagto. Entrada Padrão", 250)
        objGrid_Coluna_Add(grdListagem, "Forma Pagto. Parcela Padrão", 250)
        objGrid_Coluna_Add(grdListagem, "Tipo de Documento para Pagamento Único ou Entrada", 250)
        objGrid_Coluna_Add(grdListagem, "Tipo de Documento Padrão para Parcelas", 250)
        objGrid_Coluna_Add(grdListagem, "Qt. Parcela", 100,,,,, const_Formato_NumeroInteiro)
        objGrid_Coluna_Add(grdListagem, "Dias 1ª Parc.", 100,,,,, const_Formato_NumeroInteiro)
        objGrid_Coluna_Add(grdListagem, "Dias Interv", 100,,,,, const_Formato_NumeroInteiro)
        objGrid_Coluna_Add(grdListagem, "Acréscim. (%)", 100,,,,, const_Formato_Porcentagem)
        objGrid_Coluna_Add(grdListagem, "Entrada (%)", 100,,,,, const_Formato_Porcentagem)
        objGrid_Coluna_Add(grdListagem, "Juros a.m. (%)", 100,,,,, const_Formato_Porcentagem)
        objGrid_Coluna_Add(grdListagem, "Taxa Compensação (%)", 100,,,,, const_Formato_Porcentagem)
        objGrid_Coluna_Add(grdListagem, "Per. Calc. Juros (%)", 100)
        objGrid_Coluna_Add(grdListagem, "Gerar Parcela A Vista", 250)
        objGrid_Coluna_Add(grdListagem, "Usar no Recebimento", 250)
        objGrid_Coluna_Add(grdListagem, "Usar na Venda", 100)
        objGrid_Coluna_Add(grdListagem, "Ativo", 100)
        oPermissao = FNC_Permissao(enPermissao.FINA_CondicaoPagamento)
      Case enListagemGeral_TipoTela.CadastroContabilizacao
        Me.Text = "Cadastro de Contabilização"

        lblRotuloListagem.Text = "Listagem de Contabilização"
        objGrid_Coluna_Add(grdListagem, "SQ_CONTABILIZACAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome", 400)
        objGrid_Coluna_Add(grdListagem, "Ativo", 100)
      Case enListagemGeral_TipoTela.CadastroTabelaPreco
        Me.Text = "Cadastro de Tabela de Preço"

        lblRotuloListagem.Text = "Listagem de Tabela de Preço"
        objGrid_Coluna_Add(grdListagem, "SQ_TABELAPRECO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Tabela de Preço", 400)
        objGrid_Coluna_Add(grdListagem, "Dt. Início Uso", 90, , , ColumnStyle.Date)
        objGrid_Coluna_Add(grdListagem, "Dt. Fim Uso", 90, , , ColumnStyle.Date)
        objGrid_Coluna_Add(grdListagem, "Dt. Último Reajuste", 120, , , ColumnStyle.Date)
        objGrid_Coluna_Add(grdListagem, "Desconto Máximo (%)", 110, , , ColumnStyle.Double, , , , , , , , HAlign.Right)
        objGrid_Coluna_Add(grdListagem, "Margem de Lucro (%)", 110, , , ColumnStyle.Double, , , , , , , , HAlign.Right)
        objGrid_Coluna_Add(grdListagem, "Comissão (%)", 100, , , ColumnStyle.Double, , , , , , , , HAlign.Right)
        objGrid_Coluna_Add(grdListagem, "Disponível Filial", 120)
      Case enListagemGeral_TipoTela.CadastroEstoque
        Me.Text = "Cadastro de Estoque"

        lblRotuloListagem.Text = "Listagem de Estoque"
        objGrid_Coluna_Add(grdListagem, "SQ_ESTOQUE", 0)
        objGrid_Coluna_Add(grdListagem, "Departamento Responsavel", 300)
        objGrid_Coluna_Add(grdListagem, "Código do Estoque", 120, , , , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Nome do Estoque", 300, , , , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Controla Mínimos", 120)
        objGrid_Coluna_Add(grdListagem, "Permite Bloqueio", 120)
        objGrid_Coluna_Add(grdListagem, "Ativo", 50)
        objGrid_Coluna_Add(grdListagem, "Permite Saldo Negativo", 140)
        objGrid_Coluna_Add(grdListagem, "Entrada Automática", 125)
      Case enListagemGeral_TipoTela.CadastroTransacaoEstoque
        Me.Text = "Cadastro de Transação de Estoque"

        lblRotuloListagem.Text = "Listagem de Transação de Estoque"
        objGrid_Coluna_Add(grdListagem, "SQ_TRANSACAOESTOQUE", 0)
        objGrid_Coluna_Add(grdListagem, "Estoque de Débito", 150, , True, , FNC_CarregarLista(enTipoCadastro.Estoque))
        objGrid_Coluna_Add(grdListagem, "Estoque de Crédito", 150, , True, , FNC_CarregarLista(enTipoCadastro.Estoque))
        objGrid_Coluna_Add(grdListagem, "Código da Transação de Estoque", 100, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Transação de Estoque", 300, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Usar no Recebimento", 150, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Usar na Venda", 120, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Usar na Movimentação de Estoque", 220, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "EmUso", 0)
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        Me.Text = "Cadastro de Motivo da Doença"

        lblRotuloListagem.Text = "Listagem de Motivo da Doença"
        objGrid_Coluna_Add(grdListagem, "SQ_DOENCA_ESTAGIO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Motivo da Doença", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoServico
        Me.Text = "Cadastro de Tipo de Serviço"

        lblRotuloListagem.Text = "Listagem de Tipo de Serviços"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_SERVICO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Serviço", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoRelatorio
        Me.Text = "Cadastro de Tipo de Relatório"

        lblRotuloListagem.Text = "Listagem de Relatório"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_RELATORIO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Relatório", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroServico
        Me.Text = "Cadastro de Serviço"

        lblRotuloListagem.Text = "Listagem de Serviço"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_SERVICO", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Serviço", 150, , True, , FNC_CarregarLista(enTipoCadastro.TipoServico))
        objGrid_Coluna_Add(grdListagem, "Código do Serviço", 100, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Serviço", 300, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Gera Financeiro", 150, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        Me.Text = "Cadastro de Grupo de Plano de Contas"

        lblRotuloListagem.Text = "Listagem de Grupo de Plano de Contas"
        objGrid_Coluna_Add(grdListagem, "SQ_PLANOCONTAS_GRUPO", 0)
        objGrid_Coluna_Add(grdListagem, "Grupo de Plano de Contas Superior", 300, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContasGrupo))
        objGrid_Coluna_Add(grdListagem, "Código do Plano de Contas", 200, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Plano de Contas", 300, , True, , , , , , 100)
        oPermissao = FNC_Permissao(enPermissao.FINA_GrupoPlanodeContas)
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar, enListagemGeral_TipoTela.CadastroSegmento_OrdemServico
        Select Case eListagemGeral_TipoTela
          Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar
            Me.Text = "Segmento de Contas a Receber e Contas a Pagar"
          Case enListagemGeral_TipoTela.CadastroSegmento_OrdemServico
            Me.Text = "Segmento de Ordem de Serviço"
        End Select

        lblRotuloListagem.Text = "Listagem de Segmento"
        objGrid_Coluna_Add(grdListagem, "SQ_SEGMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Segmento", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalSerie
        Me.Text = "Cadastro de Documento Fiscal Série"

        lblRotuloListagem.Text = "Listagem de Documento Fiscal Série"
        objGrid_Coluna_Add(grdListagem, "SQ_DOCUMENTOFISCAL_SERIE", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Documento Fiscal", 300, , True, , FNC_CarregarLista(enTipoCadastro.TipoDocumentoFiscal))
        objGrid_Coluna_Add(grdListagem, "Série de Documento Fiscal", 200, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Número da Última Emissão", 200, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Padrão Na Venda", 130, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalInutilizado
        Me.Text = "Cadastro de Documento Fiscal - Inutillização"

        lblRotuloListagem.Text = "Listagem de Documento Fiscal - Inutillização"
        objGrid_Coluna_Add(grdListagem, "SQ_DOCUMENTOFISCAL_INUTILIZACAO", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Documento Fiscal", 300)
        objGrid_Coluna_Add(grdListagem, "Modelo do Documento Fiscal", 200)
        objGrid_Coluna_Add(grdListagem, "Série de Documento Fiscal", 200)
        objGrid_Coluna_Add(grdListagem, "Data/Hora de Inutilização", 200,,, ColumnStyle.DateTime)
        objGrid_Coluna_Add(grdListagem, "Número do Documento Fiscal Inicial", 200)
        objGrid_Coluna_Add(grdListagem, "Número do Documento Fiscal Final", 200)
        objGrid_Coluna_Add(grdListagem, "Justificativa", 500)
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalTipo
        Me.Text = "Cadastro de Tipo de Documento Fiscal"

        lblRotuloListagem.Text = "Listagem de Tipo de Documento Fiscal"
        objGrid_Coluna_Add(grdListagem, "SQ_DOCUMENTOFISCAL_TIPO", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Operação", 200, , True, , FNC_CarregarLista(enTipoCadastro.NFe_TipoOperacao))
        objGrid_Coluna_Add(grdListagem, "Tipo de Emissão da NFe", 200, , True, , FNC_CarregarLista(enTipoCadastro.NFe_FormatoImpressaoDanfe))
        objGrid_Coluna_Add(grdListagem, "Nome do Documento Fiscal", 200)
        objGrid_Coluna_Add(grdListagem, "Cód. do Documento Fiscal", 100)
        objGrid_Coluna_Add(grdListagem, "Cód. Serviço Modelo", 100)
        objGrid_Coluna_Add(grdListagem, "Cód. Serviço Versão", 100)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Exige Pessoa", 100, , True, , FNC_CarregarLista(enTipoCadastro.ExibirDocumentoFiscal))
        objGrid_Coluna_Add(grdListagem, "Exige Endereço", 100, , True, , FNC_CarregarLista(enTipoCadastro.ExibirDocumentoFiscal))
        objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 150, , True, , FNC_CarregarLista(enTipoCadastro.TipoDocumento))
      Case enListagemGeral_TipoTela.CadastroTurno
        Me.Text = "Cadastro de Turno"

        lblRotuloListagem.Text = "Listagem de Turno"
        objGrid_Coluna_Add(grdListagem, "SQ_TURNO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Turno", 300, , True)
        objGrid_Coluna_Add(grdListagem, "Horário Inicial", 200, , True, ColumnStyle.Time)
        objGrid_Coluna_Add(grdListagem, "Horário Final", 200, , True, ColumnStyle.Time)
        oPermissao = FNC_Permissao(enPermissao.CADA_Clinica_Turno)
      Case enListagemGeral_TipoTela.CadastroTipoIndicador
        Me.Text = "Cadastro de Tipo de Indicador"

        lblRotuloListagem.Text = "Cadastro de Tipo de Indicador"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPOINDICADOR", 0)
        objGrid_Coluna_Add(grdListagem, "Mome do Tipo de Indicador", 400, , True, , , , , , 100)
      Case enListagemGeral_TipoTela.CadastroCanalMarcacao
        Me.Text = "Cadastro de Canal de Marcação"

        lblRotuloListagem.Text = "Cadastro de Canal de Marcação"
        objGrid_Coluna_Add(grdListagem, "SQ_CANALMARCACAO", 0)
        objGrid_Coluna_Add(grdListagem, "Mome do Canal de Marcação", 400, , True, , , , , , 100)
      Case enListagemGeral_TipoTela.CadastroCaixaAtendimento
        Me.Text = "Cadastro de Caixa Atendimento"

        lblRotuloListagem.Text = "Listagem de Caixa Atendimento"
        objGrid_Coluna_Add(grdListagem, "SQ_CAIXA_ATENDIMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Caixa de Atendimento", 250, , True)
        objGrid_Coluna_Add(grdListagem, "Localização", 250, , True)
        objGrid_Coluna_Add(grdListagem, "Usar Sistema de Chamada", 150, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox,,,,,,,,,,,,,,,, False)
    End Select

    'Botaões de edição do modo somente listagem
    cmdNovo.Visible = (Not bEdicao)
    cmdAlterar.Visible = (Not bEdicao And Not bSoInclusao)
    cmdExcluir.Visible = (Not bEdicao And Not bSoInclusao)

    lblRotuloListagem.Tag = lblRotuloListagem.Text

    objGrid_Configuracao_Carregar(grdListagem, Me.Name + "_" + eListagemGeral_TipoTela.ToString())

    Pesquisar()
  End Sub

  Private Sub frmListaGeral_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    AjustarTela()
  End Sub

  Private Sub AjustarTela()
    cmdAtualizar.Left = 5
    cmdAtualizar.Top = Me.ClientSize.Height - cmdFechar.Height - 5

    If cmdNovo.Visible Then
      cmdNovo.Top = cmdAtualizar.Top
      cmdNovo.Left = cmdAtualizar.Left + cmdAtualizar.Width + 5
      cmdAlterar.Top = cmdNovo.Top
      cmdAlterar.Left = cmdNovo.Left + cmdNovo.Width + 5
      cmdExcluir.Top = cmdAlterar.Top
      cmdExcluir.Left = cmdAlterar.Left + cmdAlterar.Width + 5
    End If

    If cmdExcluir.Visible Then
      cmdExcel.Top = cmdExcluir.Top
      cmdExcel.Left = cmdExcluir.Left + cmdExcluir.Width + 5
    Else
      cmdExcel.Top = cmdAtualizar.Top
      cmdExcel.Left = cmdAtualizar.Left + cmdAtualizar.Width + 5
    End If
    cmdPDF.Top = cmdExcel.Top
    cmdPDF.Left = cmdExcel.Left + cmdExcel.Width + 5
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdAtualizar.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim iCont As Integer

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroTurno
        sSqlText = "SELECT SQ_TURNO," &
                          "NO_TURNO," &
                          "HR_INICIO," &
                          "HR_FIM" &
                   " FROM TB_TURNO" &
                   " ORDER BY NO_TURNO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTurno_SQ_TURNO,
                                                               const_GridTurno_NO_TURNO,
                                                               const_GridTurno_HR_INICIO,
                                                               const_GridTurno_HR_FIM})
      Case enListagemGeral_TipoTela.CadastroConsultorio
        sSqlText = "SELECT SQ_CONSULTORIO," &
                          "CD_CONSULTORIO," &
                          "NO_CONSULTORIO," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_CONSULTORIO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_CONSULTORIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridConsultorio_SQ_CONSULTORIO,
                                                               const_GridConsultorio_CD_CONSULTORIO,
                                                               const_GridConsultorio_NO_CONSULTORIO,
                                                               const_GridConsultorio_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroVacina
        sSqlText = "SELECT SQ_VACINA," &
                          "NO_VACINA," &
                          "DS_SERVENTIA," &
                          "DS_INICIO," &
                          "DS_TERMINO," &
                          "DS_APRAZAMENTO," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_VACINA" &
                   " ORDER BY NO_VACINA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridVacina_SQ_VACINA,
                                                               const_GridVacina_NO_VACINA,
                                                               const_GridVacina_DS_SERVENTIA,
                                                               const_GridVacina_DS_INICIO,
                                                               const_GridVacina_DS_TERMINO,
                                                               const_GridVacina_DS_APRAZAMENTO,
                                                               const_GridVacina_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroVacina
        sSqlText = "SELECT SQ_CONSULTORIO," &
                          "CD_CONSULTORIO," &
                          "NO_CONSULTORIO," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_CONSULTORIO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_CONSULTORIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridConsultorio_SQ_CONSULTORIO,
                                                               const_GridConsultorio_CD_CONSULTORIO,
                                                               const_GridConsultorio_NO_CONSULTORIO,
                                                               const_GridConsultorio_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroCanalNegocio
        sSqlText = "SELECT SQ_CANALNEGOCIO," &
                          "ID_OPT_TIPOCANALNEGOCIO," &
                          "NO_CANALNEGOCIO," &
                          "ID_CONTABILIZACAO_PADRAO," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_CANALNEGOCIO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_CANALNEGOCIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCanalNegocio_SQ_CANALNEGOCIO,
                                                               const_GridCanalNegocio_ID_OPT_TIPOCANALNEGOCIO,
                                                               const_GridCanalNegocio_NomeCanalNegocio,
                                                               const_GridCanalNegocio_ID_CONTABILIZACAO,
                                                               const_GridCanalNegocio_Ativo})
      Case enListagemGeral_TipoTela.CadastroGrupoTributario
        sSqlText = "SELECT SQ_GRUPOTRIBUTARIO," &
                          "NO_GRUPOTRIBUTARIO," &
                          "PC_COFINS," &
                          "PC_PIS," &
                          "PC_II," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_GRUPOTRIBUTARIO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_GRUPOTRIBUTARIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridGrupoTributario_SQ_GRUPOTRIBUTARIO,
                                                               const_GridGrupoTributario_NO_GRUPOTRIBUTARIO,
                                                               const_GridGrupoTributario_PC_COFINS,
                                                               const_GridGrupoTributario_PC_PIS,
                                                               const_GridGrupoTributario_PC_II,
                                                               const_GridGrupoTributario_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        sSqlText = "SELECT SQ_PLANOCONTAS," &
                          "ID_PLANOCONTAS_GRUPO," &
                          "CD_PLANOCONTAS," &
                          "NO_PLANOCONTAS," &
                          "ID_OPT_CREDITODEBITO," &
                          "ID_OPT_TIPOCUSTO," &
                          "CD_PLANOCONTAS_CONTABILIDADE," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_PLANOCONTAS" &
                   " ORDER BY ID_OPT_CREDITODEBITO, CD_PLANOCONTAS"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridPlanoContas_SQ_PLANOCONTAS,
                                                               const_GridPlanoContas_GrupoPlanoContas,
                                                               const_GridPlanoContas_CodigoPlanoContas,
                                                               const_GridPlanoContas_NomePlanoContas,
                                                               const_GridPlanoContas_CreditoDebito,
                                                               const_GridPlanoContas_TipoCusto,
                                                               const_GridPlanoContas_CodigoPlanoContasContabilidade,
                                                               const_GridPlanoContas_Ativo})
      Case enListagemGeral_TipoTela.CadastroProfissao
        sSqlText = "SELECT SQ_PROFISSAO," &
                          "NO_PROFISSAO" &
                   " FROM TB_PROFISSAO" &
                   " ORDER BY NO_PROFISSAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridProfissao_SQ_PROFISSAO,
                                                               const_GridProfissao_NomeProfissao})
      Case enListagemGeral_TipoTela.CadastroCanalMarcacao
        sSqlText = "SELECT SQ_CANALMARCACAO," &
                          "NO_CANALMARCACAO" &
                   " FROM TB_CANALMARCACAO" &
                   " ORDER BY NO_CANALMARCACAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCanalMarcacao_SQ_CANALMARCACAO,
                                                               const_GridCanalMarcacao_NO_CANALMARCACAO})
      Case enListagemGeral_TipoTela.CadastroGrupoProcedimento
        sSqlText = "SELECT SQ_GRUPOPROCEDIMENTO," &
                          "NO_GRUPOPROCEDIMENTO," &
                          "ID_PLANOCONTAS," &
                          "ID_PLANOCONTAS_CONTASPAGAR," &
                          "IIF(TP_BLOQUEAR_AGENDAMENTO_DUPLICADO = 'S', 1, 0)" &
                   " FROM TB_GRUPOPROCEDIMENTO" &
                   " ORDER BY NO_GRUPOPROCEDIMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridGrupoProcedimento_SQ_GRUPOPROCEDIMENTO,
                                                               const_GridGrupoProcedimento_NO_GRUPOPROCEDIMENTO,
                                                               const_GridGrupoProcedimento_ID_PLANOCONTAS,
                                                               const_GridGrupoProcedimento_ID_PLANOCONTAS_CONTASPAGAR,
                                                               const_GridGrupoProcedimento_TP_BLOQUEAR_AGENDAMENTO_DUPLICADO})
      Case enListagemGeral_TipoTela.CadastroConselhoProfissional
        sSqlText = "SELECT SQ_CONSELHOPROFISSIONAL," &
                          "CD_CONSELHOPROFISSIONAL," &
                          "NO_CONSELHOPROFISSIONAL" &
                   " FROM TB_CONSELHOPROFISSIONAL" &
                   " ORDER BY NO_CONSELHOPROFISSIONAL"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridConselhoProfissional_SQ_CONSELHOPROFISSIONAL,
                                                               const_GridConselhoProfissional_CD_CONSELHOPROFISSIONAL,
                                                               const_GridConselhoProfissional_NO_CONSELHOPROFISSIONAL})
      Case enListagemGeral_TipoTela.CadastroConselhoProfissional
        sSqlText = "SELECT SQ_DOCUMENTOFISCAL_SERIE," &
                          "ID_DOCUMENTOFISCAL_TIPO," &
                          "CD_DOCUMENTOFISCAL_SERIE," &
                          "CD_ULTIMAEMISSAO_NUMERO," &
                          "IC_PADRAO_VENDA," &
                          "IC_ATIVO" &
                   " FROM TB_CONSELHOPROFISSIONAL" &
                   " ORDER BY NO_CONSELHOPROFISSIONAL"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridDocumentoFiscalSerie_SQ_DOCUMENTOFISCAL_SERIE,
                                                               const_GridDocumentoFiscalSerie_ID_DOCUMENTOFISCAL_TIPO,
                                                               const_GridDocumentoFiscalSerie_CD_DOCUMENTOFISCAL_SERIE,
                                                               const_GridDocumentoFiscalSerie_CD_ULTIMAEMISSAO_NUMERO,
                                                               const_GridDocumentoFiscalSerie_IC_PADRAO_VENDA,
                                                               const_GridDocumentoFiscalSerie_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroTipoServico
        sSqlText = "SELECT SQ_TIPO_SERVICO," &
                          "NO_TIPO_SERVICO" &
                   " FROM TB_TIPO_SERVICO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_TIPO_SERVICO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoServico_SQ_TIPO_SERVICO,
                                                               const_GridTipoServico_NomeTipoServico})
      Case enListagemGeral_TipoTela.CadastroTipoRelatorio
        sSqlText = "SELECT SQ_TIPO_RELATORIO," &
                          "NO_TIPO_RELATORIO" &
                   " FROM TB_TIPO_RELATORIO" &
                   " ORDER BY NO_TIPO_RELATORIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoRelatorio_SQ_TIPO_RELATORIO,
                                                               const_GridTipoRelatorio_NO_TIPO_RELATORIO})
      Case enListagemGeral_TipoTela.CadastroTipoIndicador
        sSqlText = "SELECT SQ_TIPOINDICADOR," &
                          "NO_TIPOINDICADOR" &
                   " FROM TB_TIPOINDICADOR" &
                   " ORDER BY NO_TIPOINDICADOR"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoIndicador_SQ_TIPOINDICADOR,
                                                               const_GridTipoIndicador_NO_TIPOINDICADOR})
      Case enListagemGeral_TipoTela.CadastroTipoIndicador
        sSqlText = "SELECT SQ_CANALMARCACAO," &
                          "NO_CANALMARCACAO" &
                   " FROM TB_CANALMARCACAO" &
                   " ORDER BY NO_CANALMARCACAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCanalMarcacao_SQ_CANALMARCACAO,
                                                               const_GridCanalMarcacao_NO_CANALMARCACAO})
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar,
           enListagemGeral_TipoTela.CadastroSegmento_OrdemServico
        sSqlText = "SELECT SQ_SEGMENTO," &
                          "NO_SEGMENTO," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_SEGMENTO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ID_OPT_TIPOSEGMENTO = " & IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroSegmento_OrdemServico,
                                                                                   enOpcoes.TipoSegmento_OrdemServico.GetHashCode,
                                                         IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar,
                                                                                       enOpcoes.TipoSegmento_ContasReceberContasPagar.GetHashCode, 0)) &
                   " ORDER BY NO_SEGMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridSegmento_SQ_SEGMENTO,
                                                               const_GridSegmento_NomeSegmento,
                                                               const_GridSegmento_Ativo})
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        sSqlText = "SELECT SQ_DOENCA_ESTAGIO," &
                          "NO_DOENCA_ESTAGIO" &
                   " FROM TB_DOENCA_ESTAGIO" &
                   " ORDER BY NO_DOENCA_ESTAGIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO,
                                                               const_GridDoencaEstagio_DoencaEstagio})
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        sSqlText = "SELECT SQ_TIPO_SERVICO," &
                          "NO_TIPO_SERVICO" &
                   " FROM TB_TIPO_SERVICO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_TIPO_SERVICO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoServico_SQ_TIPO_SERVICO,
                                                               const_GridTipoServico_NomeTipoServico})
      Case enListagemGeral_TipoTela.CadastroCargo
        sSqlText = "SELECT SQ_TIPO_CARGO," &
                          "NO_TIPO_CARGO" &
                   " FROM TB_TIPO_CARGO" &
                   " ORDER BY NO_TIPO_CARGO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCargo_SQ_TIPO_CARGO,
                                                               const_GridCargo_NomeCargo})
      Case enListagemGeral_TipoTela.CadastroCaixaAtendimento
        sSqlText = "SELECT SQ_CAIXA_ATENDIMENTO," &
                          "NO_CAIXA_ATENDIMENTO," &
                          "DS_LOCALIZACAO," &
                          "IIF(IC_USA_SISTEMACHAMADA = 'S', 1, 0)," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_CAIXA_ATENDIMENTO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_CAIXA_ATENDIMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCaixaAtendimento_SQ_CAIXA_ATENDIMENTO,
                                                               const_GridCaixaAtendimento_NO_CAIXA_ATENDIMENTO,
                                                               const_GridCaixaAtendimento_Localizacao,
                                                               const_GridCaixaAtendimento_UsaSistemaChamada,
                                                               const_GridCaixaAtendimento_Ativo})
      Case enListagemGeral_TipoTela.CadastroCidade
        sSqlText = "SELECT SQ_CIDADE," &
                          "ID_UF," &
                          "NO_CIDADE," &
                          "CD_IBGE" &
                   " FROM TB_CIDADE" &
                   " ORDER BY NO_CIDADE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCidade_SQ_CIDADE,
                                                               const_GridCidade_UF,
                                                               const_GridCidade_NomeCidade,
                                                               const_GridCidade_CodigoIBGE})
      Case enListagemGeral_TipoTela.CadastroUF
        sSqlText = "SELECT SQ_UF," &
                          "ID_PAIS," &
                          "NO_UF," &
                          "CD_UF" &
                   " FROM TB_UF" &
                   " ORDER BY NO_UF"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridUF_SQ_UF,
                                                               const_GridUF_Pais,
                                                               const_GridUF_NomeUF,
                                                               const_GridUF_CodigoUF})
      Case enListagemGeral_TipoTela.CadastroPais
        sSqlText = "SELECT SQ_PAIS," &
                          "NO_PAIS," &
                          "NO_NACIONALIDADE," &
                          "IC_SISTEMA" &
                   " FROM TB_PAIS" &
                   " ORDER BY NO_PAIS"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridPais_SQ_PAIS,
                                                               const_GridPais_NomePais,
                                                               const_GridPais_NomeNascionalidade,
                                                               const_GridPais_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroConvenio
        sSqlText = "SELECT CVN.SQ_CONVENIO," &
                          "TIP.NO_OPCAO NO_OPT_TIPO," &
                          "CVN.NO_CONVENIO," &
                          "ADM.NO_PESSOA NO_ADMINISTRADORA," &
                          "CVN.CD_CONTRATO," &
                          "CVN.NR_DIA_CORTE," &
                          "CVN.NR_DIA_PREVISAO_PAGAMENTO," &
                          "IIF(CVN.IC_ATIVO = 'S', 'Sim', 'Não')," &
                          "IIF(CVN.IC_CONTROLACREDITO = 'S', 'Sim', 'Não')," &
                          "IIF(CVN.IC_SENHA_SUPERVISOR = 'S', 'Sim', 'Não')," &
                          "VL_CREDITO" &
                   " FROM TB_CONVENIO CVN" &
                    " LEFT JOIN TB_PESSOA ADM ON ADM.SQ_PESSOA = CVN.ID_ADMINISTRADORA" &
                    " LEFT JOIN TB_OPCAO TIP ON TIP.SQ_OPCAO = CVN.ID_OPT_TIPO" &
                   " WHERE CVN.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY CVN.NO_CONVENIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridConvenio_SQ_CONVENIO,
                                                               const_GridConvenio_TipoConvenio,
                                                               const_GridConvenio_NomeConvenio,
                                                               const_GridConvenio_Administradora,
                                                               const_GridConvenio_CodigoContrato,
                                                               const_GridConvenio_DiaCorte,
                                                               const_GridConvenio_DiaPrevPagamento,
                                                               const_GridConvenio_Ativo,
                                                               const_GridConvenio_ControlaCredito,
                                                               const_GridConvenio_SenhaSupervisao,
                                                               const_GridConvenio_ValorCredito})
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        sSqlText = "SELECT SQ_GRUPOPRODUTO," &
                          "NO_GRUPOPRODUTO," &
                          "ID_CST_PADRAO," &
                          "ID_CSOSN_PADRAO," &
                          "ID_CST_COFINS_PADRAO," &
                          "ID_CST_IPI_PADRAO," &
                          "ID_CST_PIS_PADRAO," &
                          "IIF(IC_CONTROLA_ESTOQUE = 'S', 1, 0)," &
                          "IIF(IC_CONTROLE_GARANTIA = 'S', 1, 0)," &
                          "IIF(IC_CONTROLA_NUMERO_SERIE = 'S', 1, 0)," &
                          "ID_TRANSACAOESTOQUE_PADRAO_COMPRAS," &
                          "ID_TRANSACAOESTOQUE_PADRAO_VENDAS," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_GRUPOPRODUTO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_GRUPOPRODUTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridGrupoProduto_SQ_GRUPOPRODUTO,
                                                               const_GridGrupoProduto_NomeGrupoProduto,
                                                               const_GridGrupoProduto_CTS_Padrao,
                                                               const_GridGrupoProduto_CSOSN_Padrao,
                                                               const_GridGrupoProduto_CTS_Cofins_Padrao,
                                                               const_GridGrupoProduto_CTS_IPI_Padrao,
                                                               const_GridGrupoProduto_CTS_PIS_Padrao,
                                                               const_GridGrupoProduto_ControlaEstoque,
                                                               const_GridGrupoProduto_ControlaGarantia,
                                                               const_GridGrupoProduto_ControlaNumeroSerie,
                                                               const_GridGrupoProduto_TransacaoEstoque_Padrao_Compras,
                                                               const_GridGrupoProduto_TransacaoEstoque_Padrao_Vendas,
                                                               const_GridGrupoProduto_Ativo})
      Case enListagemGeral_TipoTela.CadastroUnidadeMedida
        sSqlText = "SELECT SQ_UNIDADEMEDIDA," &
                          "NO_UNIDADEMEDIDA," &
                          "CD_UNIDADEMEDIDA," &
                          "CD_UNIDADEMEDIDA_COMPATIVEL" &
                   " FROM TB_UNIDADEMEDIDA" &
                   " ORDER BY NO_UNIDADEMEDIDA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridUnidadeMedida_SQ_UNIDADEMEDIDA,
                                                               const_GridUnidadeMedida_NomeUnidadeMedida,
                                                               const_GridUnidadeMedida_CodigoUnidadeMedida,
                                                               const_GridUnidadeMedida_CodigoUnidadeMedidaCompativel})
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        sSqlText = "SELECT SQ_ESPECIALIDADE," &
                          "NO_ESPECIALIDADE," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_ESPECIALIDADE" &
                   " ORDER BY NO_ESPECIALIDADE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridEspecialidade_SQ_ESPECIALIDADE,
                                                               const_GridEspecialidade_NomeEspecialidade,
                                                               const_GridEspecialidade_Ativo})
      Case enListagemGeral_TipoTela.CadastroGrupoPermissao
        sSqlText = "SELECT SQ_GRUPOPERMISSAO," &
                          "NO_GRUPOPERMISSAO" &
                   " FROM TB_SEG_GRUPOPERMISSAO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_MATRIZ &
                     " AND IC_SISTEMA = 'N'" &
                   " ORDER BY NO_GRUPOPERMISSAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridGrupoPermissao_SQ_GRUPOPERMISSAO,
                                                               const_GridGrupoPermissao_NomeGrupoPermissao})
      Case enListagemGeral_TipoTela.CadastroBanco
        sSqlText = "SELECT SQ_BANCO," &
                          "NO_BANCO," &
                          "NR_BANCO" &
                   " FROM TB_BANCO" &
                   " ORDER BY NO_BANCO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridBanco_SQ_BANCO,
                                                               const_GridBanco_NomeBanco,
                                                               const_GridBanco_NumeroBanco})
      Case enListagemGeral_TipoTela.CadastroContaBancaria
        sSqlText = "SELECT CB.SQ_CONTAFINANCEIRA," &
                          "CB.ID_TIPO_CONTAFINANCEIRA," &
                          "CB.ID_BANCO," &
                          "CB.NR_AGENCIA," &
                          "CB.NR_CONTA," &
                          "CB.NR_CONTA_DIGITO," &
                          "CB.DT_ABERTURA," &
                          "IIF(CB.IC_CONTROLASALDO = 'S', 1, 0)," &
                          "IIF(CB.IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_CONTAFINANCEIRA CB" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ID_PESSOA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY dbo.FC_BANCO_CONTA_DESCRICAO(CB.ID_BANCO, CB.NR_AGENCIA, CB.NR_CONTA, CB.NR_CONTA_DIGITO)"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridContaBancaria_SQ_CONTABANCARIA,
                                                               const_GridContaBancaria_TipoConta,
                                                               const_GridContaBancaria_Banco,
                                                               const_GridContaBancaria_NumeroAgencia,
                                                               const_GridContaBancaria_NumeroConta,
                                                               const_GridContaBancaria_DigitoConta,
                                                               const_GridContaBancaria_DtAbetura,
                                                               const_GridContaBancaria_ControlaSaldo,
                                                               const_GridContaBancaria_Ativo})
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        sSqlText = "SELECT CC.SQ_CONTAFINANCEIRA," &
                          "CC.ID_DEPARTAMENTO_RESPONSAVEL," &
                          "CC.ID_PESSOA," &
                          "CC.ID_PESSOA_SUPERVISAO," &
                          "CC.NO_CONTAFINANCEIRA," &
                          "IIF(CC.IC_CONTROLASALDO = 'S', 1, 0)," &
                          "CC.PC_DESCONTO_MAXIMO," &
                          "CC.NO_CONTAFINANCEIRA," &
                          "CC.DS_LOCALIZACAO," &
                          "IIF(CC.IC_ATIVO = 'S', 1, 0)," &
                          "CC.IC_SISTEMA" &
                   " FROM TB_CONTAFINANCEIRA CC" &
                    " INNER JOIN TB_DEPARTAMENTO DP ON DP.SQ_DEPARTAMENTO = CC.ID_DEPARTAMENTO_RESPONSAVEL" &
                                                 " AND DP.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY CC.NO_CONTAFINANCEIRA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridContaCaixa_SQ_CONTACAIXA,
                                                               const_GridContaCaixa_Departamento,
                                                               const_GridContaCaixa_Funcionario,
                                                               const_GridContaCaixa_FuncionarioSupervisao,
                                                               const_GridContaCaixa_NomeCaixa,
                                                               const_GridContaCaixa_ControlaSaldo,
                                                               const_GridContaCaixa_DescontoMaximo,
                                                               const_GridContaCaixa_NomeCaixa,
                                                               const_GridContaCaixa_Localizacao,
                                                               const_GridContaCaixa_Ativo,
                                                               const_GridContaCaixa_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        sSqlText = "SELECT SQ_FORMAPAGAMENTO," &
                          "ID_TIPO_DOCUMENTO," &
                          "NO_FORMAPAGAMENTO," &
                          "ID_OPT_DOCUMENTOCADASTRADO," &
                          "ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO," &
                          "NO_CONTAFINANCEIRA" &
                   " FROM VW_FORMAPAGAMENTO" &
                   " ORDER BY NO_FORMAPAGAMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridFormaPagamento_SQ_FORMAPAGAMENTO,
                                                               const_GridFormaPagamento_TipoDocumento,
                                                               const_GridFormaPagamento_NomeFormaPagamento,
                                                               const_GridFormaPagamento_TipoDocumentoFinanceiroCadastrado,
                                                               const_GridFormaPagamento_ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO,
                                                               const_GridFormaPagamento_ID_CONTAFINANCEIRA_QUITACAO})
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        sSqlText = "SELECT SQ_TIPO_CARGO," &
                          "NO_TIPO_CARGO," &
                          "ID_OPT_TIPOFUNCAO" &
                   " FROM TB_TIPO_CARGO" &
                   " ORDER BY NO_TIPO_CARGO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoCargo_SQ_TIPO_CARGO,
                                                               const_GridTipoCargo_NomeTipoCargo,
                                                               const_GridTipoCargo_TipoFuncao})
      Case enListagemGeral_TipoTela.CadastroTipoContato
        sSqlText = "SELECT SQ_TIPO_CONTATO," &
                          "NO_TIPO_CONTATO," &
                          "IC_SISTEMA" &
                   " FROM TB_TIPO_CONTATO" &
                   " ORDER BY NO_TIPO_CONTATO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoContato_SQ_TIPO_CONTATO,
                                                               const_GridTipoContato_NomeTipoContato,
                                                               const_GridTipoContato_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoDocumento
        sSqlText = "SELECT SQ_TIPO_DOCUMENTO," &
                          "NO_TIPO_DOCUMENTO," &
                          "ID_OPT_INSTITUICAO_GERADORA," &
                          "ID_OPT_UTILIZACAOFINANCEIRO," &
                          "IIF(IC_COMPENSAR = 'S', 1, 0)," &
                          "IIF(IC_CADASTRAR_DOCUMENTO = 'S', 1, 0)," &
                          "IIF(IC_CADASTRAR_CONTABANCARIA = 'S', 1, 0)," &
                          "IIF(IC_FLUXOCAIXA = 'S', 1, 0)," &
                          "IIF(IC_QUITAR_AUTOMATICAMENTE = 'S', 1, 0)," &
                          "IIF(IC_ATIVO = 'S', 1, 0)," &
                          "IC_SISTEMA" &
                   " FROM TB_TIPO_DOCUMENTO" &
                   " ORDER BY NO_TIPO_DOCUMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoDocumento_SQ_TIPO_DOCUMENTO,
                                                               const_GridTipoDocumento_NomeTipoDocumento,
                                                               const_GridTipoDocumento_ID_OPT_INSTITUICAO_GERADORA,
                                                               const_GridTipoDocumento_ID_OPT_UTILIZACAOFINANCEIRO,
                                                               const_GridTipoDocumento_IC_COMPENSAR,
                                                               const_GridTipoDocumento_IC_CADASTRAR_DOCUMENTO,
                                                               const_GridTipoDocumento_IC_CADASTRAR_CONTABANCARIA,
                                                               const_GridTipoDocumento_IC_FLUXOCAIXA,
                                                               const_GridTipoDocumento_IC_QUITAR_AUTOMATICAMENTE,
                                                               const_GridTipoDocumento_IC_ATIVO,
                                                               const_GridTipoDocumento_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        sSqlText = "SELECT SQ_TIPO_ENDERECO," &
                          "NO_TIPO_ENDERECO," &
                          "IC_SISTEMA" &
                   " FROM TB_TIPO_ENDERECO" &
                   " ORDER BY NO_TIPO_ENDERECO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoEndereco_SQ_TIPO_ENDERECO,
                                                               const_GridTipoEndereco_NomeTipoEndereco,
                                                               const_GridTipoEndereco_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoEscolaridade
        sSqlText = "SELECT SQ_TIPO_ESCOLARIDADE," &
                          "NO_TIPO_ESCOLARIDADE" &
                   " FROM TB_TIPO_ESCOLARIDADE" &
                   " ORDER BY NO_TIPO_ESCOLARIDADE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE,
                                                               const_GridTipoEscolaridade_NomeTipoEscolaridade})
      Case enListagemGeral_TipoTela.CadastroTipoEstadoCivil
        sSqlText = "SELECT SQ_TIPO_ESTADOCIVIL," &
                          "NO_TIPO_ESTADOCIVIL" &
                   " FROM TB_TIPO_ESTADOCIVIL" &
                   " ORDER BY NO_TIPO_ESTADOCIVIL"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL,
                                                               const_GridTipoEstadoCivil_NomeEstadoCivil})
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        sSqlText = "SELECT SQ_TIPO_MIDIASOCIAL," &
                          "NO_TIPO_MIDIASOCIAL," &
                          "IC_SISTEMA" &
                   " FROM TB_TIPO_MIDIASOCIAL" &
                   " ORDER BY NO_TIPO_MIDIASOCIAL"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL,
                                                               const_GridTipoMidiaSocial_NomeMidiaSocial,
                                                               const_GridTipoMidiaSocial_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoPaciente
        sSqlText = "SELECT SQ_TIPO_PACIENTE," &
                          "NO_TIPO_PACIENTE" &
                   " FROM TB_TIPO_PACIENTE" &
                   " ORDER BY NO_TIPO_PACIENTE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoPaciente_SQ_TIPO_PACIENTE,
                                                               const_GridTipoPaciente_NomeTipoPaciente})
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        sSqlText = "SELECT SQ_TIPO_PESSOA," &
                          "ID_OPT_FISICO_JURIDICO," &
                          "NO_TIPO_PESSOA" &
                   " FROM TB_TIPO_PESSOA" &
                   " ORDER BY ID_OPT_FISICO_JURIDICO, NO_TIPO_PESSOA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoPessoa_SQ_TIPO_PESSOA,
                                                               const_GridTipoPessoa_FisicoJuridico,
                                                               const_GridTipoPessoa_NomeTipoPessoa})
      Case enListagemGeral_TipoTela.CadastroTipoProduto
        sSqlText = "SELECT SQ_TIPO_PRODUTO," &
                          "NO_TIPO_PRODUTO" &
                   " FROM TB_TIPO_PRODUTO" &
                   " ORDER BY NO_TIPO_PRODUTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoProduto_SQ_TIPO_PRODUTO,
                                                               const_GridTipoProduto_NomeTipoProduto})
      Case enListagemGeral_TipoTela.CadastroTipoQuestionario
        sSqlText = "SELECT SQ_TIPO_QUESTIONARIO," &
                          "NO_TIPO_QUESTIONARIO," &
                          "ID_OPT_TIPOCAMPO" &
                   " FROM TB_TIPO_QUESTIONARIO" &
                   " ORDER BY NO_TIPO_QUESTIONARIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO,
                                                               const_GridTipoQuestionario_NomeTipoQuestionario,
                                                               const_GridTipoQuestionario_TipoCampo})
      Case enListagemGeral_TipoTela.CadastroTipoRaca
        sSqlText = "SELECT SQ_TIPO_RACA," &
                          "NO_TIPO_RACA" &
                   " FROM TB_TIPO_RACA" &
                   " ORDER BY NO_TIPO_RACA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoRaca_SQ_TIPO_RACA,
                                                               const_GridTipoRaca_NomeTipoRaca})
      Case enListagemGeral_TipoTela.CadastroClassificacaoExame
        sSqlText = "SELECT SQ_CLASSIFICACAO_EXAME," &
                          "NO_CLASSIFICACAO_EXAME" &
                   " FROM TB_CLASSIFICACAO_EXAME" &
                   " ORDER BY NO_CLASSIFICACAO_EXAME"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridClassificacaoExame_SQ_CLASSIFICACAO_EXAME,
                                                               const_GridClassificacaoExame_NO_CLASSIFICACAO_EXAME})
      Case enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa
        sSqlText = "SELECT SQ_TIPO_REFERENCIAPESSOA," &
                          "ID_TIPO_PESSOA," &
                          "NO_TIPO_REFERENCIAPESSOA" &
                   " FROM TB_TIPO_REFERENCIAPESSOA" &
                   " ORDER BY ID_TIPO_PESSOA, NO_TIPO_REFERENCIAPESSOA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA,
                                                               const_GridTipoReferenciaPessoal_TipoPessoa,
                                                               const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa})
      Case enListagemGeral_TipoTela.CadastroProdutoLinha
        sSqlText = "SELECT SQ_PRODUTO_LINHA," &
                          "NO_OPT_TIPO_PRODUTO_LINHA," &
                          "NO_PRODUTO_LINHA," &
                          "NO_PRODUTO_EMPRESA_INDICACAO," &
                          "NO_UNIDADEMEDIDA," &
                          "IIF(IC_ATIVO = 'S', 'Sim', 'Não')" &
                   " FROM VW_PRODUTO_LINHA" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY ID_OPT_TIPO_PRODUTO_LINHA, NO_PRODUTO_LINHA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridProdutoLinha_SQ_PRODUTO_LINHA,
                                                               const_GridProdutoLinha_TipoLinhaProduto,
                                                               const_GridProdutoLinha_NomeLinhaProduto,
                                                               const_GridProdutoLinha_ProdutoIndicacao,
                                                               const_GridProdutoLinha_UnidadeMedida,
                                                               const_GridProdutoLinha_Ativo})

        For iCont = 0 To grdListagem.Rows.Count - 1
          With grdListagem.Rows(iCont)
            If Not FNC_CampoNulo(.Cells(const_GridProdutoLinha_ProdutoIndicacao)) Then
              .Cells(const_GridProdutoLinha_ProdutoIndicacao).ValueList = FNC_CarregarLista(enTipoCadastro.Produto_LinhaProduto, FNC_NVL(.Cells(const_GridProdutoLinha_SQ_PRODUTO_LINHA).Value, 0))
            End If
          End With
        Next
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalSerie
        sSqlText = "SELECT SQ_DOCUMENTOFISCAL_SERIE," &
                          "ID_DOCUMENTOFISCAL_TIPO," &
                          "CD_DOCUMENTOFISCAL_SERIE," &
                          "CD_ULTIMAEMISSAO_NUMERO," &
                          "IIF(IC_PADRAO_VENDA = 'S', 1, 0)," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM VW_DOCUMENTOFISCAL_SERIE" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_DOCUMENTOFISCAL_TIPO," &
                             "CD_DOCUMENTOFISCAL_SERIE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridDocumentoFiscalSerie_SQ_DOCUMENTOFISCAL_SERIE,
                                                               const_GridDocumentoFiscalSerie_ID_DOCUMENTOFISCAL_TIPO,
                                                               const_GridDocumentoFiscalSerie_CD_DOCUMENTOFISCAL_SERIE,
                                                               const_GridDocumentoFiscalSerie_CD_ULTIMAEMISSAO_NUMERO,
                                                               const_GridDocumentoFiscalSerie_IC_PADRAO_VENDA,
                                                               const_GridDocumentoFiscalSerie_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroFinanciamento
        sSqlText = "SELECT SQ_FINANCIAMENTO," &
                          "NO_FINANCIAMENTO," &
                          "NO_FINANCIADOR," &
                          "NO_MODELODOCUMENTO_CONTRATO," &
                          "NR_MINIMO_PARCELA," &
                          "NR_MAXIMO_PARCELA," &
                          "PC_ENTRADA," &
                          "PC_JUROS," &
                          "IIF(IC_ATIVO = 'S', 'Sim', 'Não')" &
                   " FROM VW_FINANCIAMENTO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_FINANCIAMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridFinanciamento_SQ_FINANCIAMENTO,
                                                               const_GridFinanciamento_NO_FINANCIAMENTO,
                                                               const_GridFinanciamento_NO_FINANCIADOR,
                                                               const_GridFinanciamento_NO_MODELODOCUMENTO_CONTRATO,
                                                               const_GridFinanciamento_NR_MINIMO_PARCELA,
                                                               const_GridFinanciamento_NR_MAXIMO_PARCELA,
                                                               const_GridFinanciamento_PC_ENTRADA,
                                                               const_GridFinanciamento_PC_JUROS,
                                                               const_GridFinanciamento_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        sSqlText = "SELECT SQ_TIPO_RELIGIAO," &
                          "NO_TIPO_RELIGIAO" &
                   " FROM TB_TIPO_RELIGIAO" &
                   " ORDER BY NO_TIPO_RELIGIAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoReligiao_SQ_TIPO_RELIGIAO,
                                                               const_GridTipoReligiao_NomeTipoReligiao})
      Case enListagemGeral_TipoTela.CadastroTipoSexo
        sSqlText = "SELECT SQ_TIPO_SEXO," &
                          "NO_TIPO_SEXO" &
                   " FROM TB_TIPO_SEXO" &
                   " ORDER BY NO_TIPO_SEXO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoSexo_SQ_TIPO_SEXO,
                                                               const_GridTipoSexo_NomeTipoSexo})
      Case enListagemGeral_TipoTela.CadastroTipoTelefone
        sSqlText = "SELECT SQ_TIPO_TELEFONE," &
                          "NO_TIPO_TELEFONE" &
                   " FROM TB_TIPO_TELEFONE" &
                   " ORDER BY NO_TIPO_TELEFONE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoTelefone_SQ_TIPO_TELEFONE,
                                                               const_GridTipoTelefone_NomeTipoTelefone})
      Case enListagemGeral_TipoTela.CadastroDepartamento
        sSqlText = "SELECT SQ_DEPARTAMENTO," &
                          "NO_DEPARTAMENTO," &
                          "IIF(IC_ATIVO = 'S', 1, 0)," &
                          "IC_SISTEMA" &
                   " FROM TB_DEPARTAMENTO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_DEPARTAMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridDepartamento_SQ_DEPARTAMENTO,
                                                               const_GridDepartamento_NomeDepartamento,
                                                               const_GridDepartamento_Ativo,
                                                               const_GridDepartamento_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoContaFinanceira
        sSqlText = "SELECT SQ_TIPO_CONTAFINANCEIRA," &
                          "NO_TIPO_CONTAFINANCEIRA" &
                   " FROM TB_TIPO_CONTAFINANCEIRA" &
                   " WHERE ID_OPT_CLASSE NOT IN (" & enOpcoes.ClasseTipoContaFinanceira_ContaCaixa.GetHashCode() & ")" &
                   " ORDER BY NO_TIPO_CONTAFINANCEIRA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA,
                                                               const_GridTipoContaFinanceira_NomeTipoContaBancaria})
      Case enListagemGeral_TipoTela.CadastroTipoContato
        sSqlText = "SELECT SQ_TIPO_CONTATO," &
                          "NO_TIPO_CONTATO," &
                          "IC_SISTEMA" &
                   " FROM TB_TIPO_CONTATO" &
                   " ORDER BY NO_TIPO_CONTATO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoContato_SQ_TIPO_CONTATO,
                                                               const_GridTipoContato_NomeTipoContato,
                                                               const_GridTipoContato_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoConsulta
        sSqlText = "SELECT SQ_TIPO_CONSULTA," &
                          "NO_TIPO_CONSULTA," &
                          "IIF(IC_ATIVO = 'S', 1, 0)," &
                          "IIF(IC_TIPO_RETORNO = 'S', 1, 0)" &
                   " FROM TB_TIPO_CONSULTA" &
                   " ORDER BY NO_TIPO_CONSULTA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoConsulta_SQ_TIPO_CONSULTA,
                                                               const_GridTipoConsulta_NO_TIPO_CONSULTA,
                                                               const_GridTipoConsulta_IC_ATIVO,
                                                               const_GridTipoConsulta_IC_TIPO_RETORNO})
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        sSqlText = "SELECT NOP.SQ_NATUREZAOPERACAO," &
                          "NOP.NO_NATUREZAOPERACAO," &
                          "CFO_DTE.CD_CFOP," &
                          "CFO_FRE.CD_CFOP," &
                          "CFO_FRP.CD_CFOP," &
                          "PLC.NO_CODIGO_PLANOCONTAS," &
                          "OFN.NO_OPCAO NO_FINALIDADE," &
                          "NOP.PC_BASE_ICMS," &
                          "NOP.PC_BASE_SUBSTITUICAO_ICMS," &
                          "IIF(NOP.IC_CALCULA_IPI = 'S', 'Sim', 'Não')," &
                          "TPR.NO_OPCAO NO_OPT_TIPO_REFERENCIA," &
                          "IIF(NOP.IC_CREDITO_ICMS = 'S', 'Sim', 'Não')," &
                          "IIF(NOP.IC_DESTACA_IMPOSTOS = 'S', 'Sim', 'Não')," &
                          "IIF(NOP.IC_EXIGEPEDIDO = 'S', 'Sim', 'Não')," &
                          "IIF(NOP.IC_GERAFINANCEIRO = 'S', 'Sim', 'Não')," &
                          "IIF(NOP.IC_MOVIMENTAESTOQUE = 'S', 'Sim', 'Não')," &
                          "IIF(NOP.IC_PRODUTO_BLOQUEARESTOQUE = 'S', 'Sim', 'Não')," &
                          "ELS.NO_STATUS," &
                          "DCFTP.NO_DOCUMENTOFISCAL_TIPO," &
                          "DCFSR.CD_DOCUMENTOFISCAL_SERIE," &
                          "IIF(NOP.IC_USAR_ORCAMENTO = 'S', 'Sim', 'Não')," &
                          "IIF(NOP.IC_ATIVO = 'S', 'Sim', 'Não')" &
                   " FROM TB_NATUREZAOPERACAO NOP" &
                     " LEFT JOIN TB_CFOP CFO_DTE ON NOP.ID_CFOP_DENTROESTADO = CFO_DTE.SQ_CFOP" &
                     " LEFT JOIN TB_CFOP CFO_FRE ON NOP.ID_CFOP_FORAESTADO = CFO_FRE.SQ_CFOP" &
                     " LEFT JOIN TB_CFOP CFO_FRP ON NOP.ID_CFOP_FORAPAIS = CFO_FRP.SQ_CFOP" &
                     " LEFT JOIN TB_OPCAO OFN ON NOP.ID_OPT_FINALIDADE = OFN.SQ_OPCAO" &
                     " LEFT JOIN TB_OPCAO TPR ON NOP.ID_OPT_TIPO_REFERENCIA = TPR.SQ_OPCAO" &
                     " LEFT JOIN TB_DOCUMENTOFISCAL_TIPO DCFTP ON DCFTP.SQ_DOCUMENTOFISCAL_TIPO = NOP.ID_DOCUMENTOFISCAL_TIPO" &
                     " LEFT JOIN TB_DOCUMENTOFISCAL_SERIE DCFSR ON DCFSR.ID_DOCUMENTOFISCAL_TIPO = NOP.ID_DOCUMENTOFISCAL_TIPO" &
                                                             " AND DCFSR.SQ_DOCUMENTOFISCAL_SERIE = NOP.ID_DOCUMENTOFISCAL_SERIE" &
                     " LEFT JOIN TB_ESTOQUE_LOCALIZACAO_STATUS ELS ON NOP.ID_ESTOQUE_LOCALIZACAO_STATUS = ELS.SQ_ESTOQUE_LOCALIZACAO_STATUS" &
                     " LEFT JOIN VW_PLANOCONTAS PLC ON NOP.ID_PLANOCONTAS = PLC.SQ_PLANOCONTAS" &
                   " WHERE NOP.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_NATUREZAOPERACAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridNaturezaOperacao_SQ_NATUREZAOPERACAO,
                                                               const_GridNaturezaOperacao_NomeNaturezaOperacao,
                                                               const_GridNaturezaOperacao_CFOP_DentroEstado,
                                                               const_GridNaturezaOperacao_CFOP_ForaEstado,
                                                               const_GridNaturezaOperacao_CFOP_ForaPais,
                                                               const_GridNaturezaOperacao_PlanoContas,
                                                               const_GridNaturezaOperacao_Finalidade,
                                                               const_GridNaturezaOperacao_BaseICMS,
                                                               const_GridNaturezaOperacao_BaseICMSST,
                                                               const_GridNaturezaOperacao_CalcularIPI,
                                                               const_GridNaturezaOperacao_Referencia,
                                                               const_GridNaturezaOperacao_PermiteCreditoICMS,
                                                               const_GridNaturezaOperacao_DestacaImpFedEstMunic,
                                                               const_GridNaturezaOperacao_ExigePedido,
                                                               const_GridNaturezaOperacao_GerarFinanceiro,
                                                               const_GridNaturezaOperacao_MovimentarEstoque,
                                                               const_GridNaturezaOperacao_BloquearEstoque,
                                                               const_GridNaturezaOperacao_StatusNumeroSerieBloqueado,
                                                               const_GridNaturezaOperacao_TipoDocumentoFiscal,
                                                               const_GridNaturezaOperacao_SerieDocumentoFiscal,
                                                               const_GridNaturezaOperacao_UsarOrcamento,
                                                               const_GridNaturezaOperacao_Ativo})
      Case enListagemGeral_TipoTela.CadastroCondicaoPagamento
        sSqlText = "SELECT SQ_CONDICAOPAGAMENTO," &
                          "CD_CONDICAOPAGAMENTO," &
                          "NO_CONDICAOPAGAMENTO, " &
                          "NO_FORMAPAGAMENTO_ENTRADA_PADRAO," &
                          "NO_FORMAPAGAMENTO_PARCELA_PADRAO, " &
                          "NO_TIPO_DOCUMENTO_ENTRADA_PADRAO," &
                          "NO_TIPO_DOCUMENTO_PARCELA_PADRAO, " &
                          "QT_PARCELA," &
                          "QT_PARCELA_DIASPRIMEIRAPARCELA, " &
                          "QT_PARCELA_DIASINTERVALO," &
                          "ISNULL(PC_ACRESCIMO, 0) / 100, " &
                          "ISNULL(PC_ENTRADA, 0) / 100," &
                          "ISNULL(PC_JUROS, 0) / 100, " &
                          "ISNULL(PC_TAXA_COMPENSACAO, 0) / 100, " &
                          "NO_OPT_PERIODOCALCULOFINANCEIRO_JUROS," &
                          "IIF(IC_GERAR_AVISTA = 'S', 'Sim', 'Não')," &
                          "IIF(IC_USAR_RECEBIMENTO = 'S', 'Sim', 'Não')," &
                          "IIF(IC_USAR_VENDA = 'S', 'Sim', 'Não')," &
                          "IIF(IC_ATIVO = 'S', 'Sim', 'Não')" &
                   " FROM VW_CONDICAOPAGAMENTO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_CONDICAOPAGAMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCondicaoPagamento_SQ_CONDICAOPAGAMENTO,
                                                               const_GridCondicaoPagamento_CD_CONDICAOPAGAMENTO,
                                                               const_GridCondicaoPagamento_NO_CONDICAOPAGAMENTO,
                                                               const_GridCondicaoPagamento_NO_FORMAPAGAMENTO_ENTRADA_PADRAO,
                                                               const_GridCondicaoPagamento_NO_FORMAPAGAMENTO_PARCELA_PADRAO,
                                                               const_GridCondicaoPagamento_NO_TIPO_DOCUMENTO_ENTRADA_PADRAO,
                                                               const_GridCondicaoPagamento_NO_TIPO_DOCUMENTO_PARCELA_PADRAO,
                                                               const_GridCondicaoPagamento_QT_PARCELA,
                                                               const_GridCondicaoPagamento_QT_PARCELA_DIASPRIMEIRAPARCELA,
                                                               const_GridCondicaoPagamento_QT_PARCELA_DIASINTERVALO,
                                                               const_GridCondicaoPagamento_PC_ACRESCIMO,
                                                               const_GridCondicaoPagamento_PC_ENTRADA,
                                                               const_GridCondicaoPagamento_PC_JUROS,
                                                               const_GridCondicaoPagamento_PC_TAXA_COMPENSACAO,
                                                               const_GridCondicaoPagamento_NO_OPT_PERIODOCALCULOFINANCEIRO_JUROS,
                                                               const_GridCondicaoPagamento_IC_GERAR_AVISTA,
                                                               const_GridCondicaoPagamento_IC_USAR_RECEBIMENTO,
                                                               const_GridCondicaoPagamento_IC_USAR_VENDA,
                                                               const_GridCondicaoPagamento_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroContabilizacao
        sSqlText = "SELECT SQ_CONTABILIZACAO," &
                          "NO_CONTABILIZACAO, " &
                          "IIF(IC_ATIVO = 'S', 'Sim', 'Não')" &
                   " FROM TB_CONTABILIZACAO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_CONTABILIZACAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCondicaoPagamento_SQ_CONDICAOPAGAMENTO,
                                                               const_GridCondicaoPagamento_CD_CONDICAOPAGAMENTO,
                                                               const_GridCondicaoPagamento_NO_CONDICAOPAGAMENTO,
                                                               const_GridCondicaoPagamento_NO_FORMAPAGAMENTO_ENTRADA_PADRAO,
                                                               const_GridCondicaoPagamento_NO_FORMAPAGAMENTO_PARCELA_PADRAO,
                                                               const_GridCondicaoPagamento_QT_PARCELA,
                                                               const_GridCondicaoPagamento_QT_PARCELA_DIASPRIMEIRAPARCELA,
                                                               const_GridCondicaoPagamento_QT_PARCELA_DIASINTERVALO,
                                                               const_GridCondicaoPagamento_PC_ACRESCIMO,
                                                               const_GridCondicaoPagamento_PC_ENTRADA,
                                                               const_GridCondicaoPagamento_PC_JUROS,
                                                               const_GridCondicaoPagamento_IC_GERAR_AVISTA,
                                                               const_GridCondicaoPagamento_IC_USAR_RECEBIMENTO,
                                                               const_GridCondicaoPagamento_IC_USAR_VENDA,
                                                               const_GridCondicaoPagamento_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroTabelaPreco
        sSqlText = "SELECT SQ_TABELAPRECO," &
                          "NO_TABELAPRECO," &
                          "DT_INICIO_USO," &
                          "DT_FIM_USO," &
                          "DT_ULTIMO_REAJUSTE," &
                          "PC_DESCONTO_MAXIMO," &
                          "PC_MARGEM_LUCRO," &
                          "PC_COMISSAO," &
                          "IIF(ISNULL(IC_DISPONIVEL_FILIAL, 'N') = 'S', 'Sim', 'Não')" &
                   " FROM TB_TABELAPRECO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_TABELAPRECO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTabelaPreco_SQ_TABELAPRECO,
                                                               const_GridTabelaPreco_NO_TABELAPRECO,
                                                               const_GridTabelaPreco_DT_INICIO_USO,
                                                               const_GridTabelaPreco_DT_FIM_USO,
                                                               const_GridTabelaPreco_DT_ULTIMO_REAJUSTE,
                                                               const_GridTabelaPreco_PC_DESCONTO_MAXIMO,
                                                               const_GridTabelaPreco_PC_MARGEM_LUCRO,
                                                               const_GridTabelaPreco_PC_COMISSAO,
                                                               const_GridTabelaPreco_IC_DISPONIVEL_FILIAL})
      Case enListagemGeral_TipoTela.CadastroEstoque
        sSqlText = "SELECT EST.SQ_ESTOQUE," &
                          "DEP.NO_DEPARTAMENTO," &
                          "EST.CD_ESTOQUE," &
                          "EST.NO_ESTOQUE," &
                          "IIF(ISNULL(EST.IC_CONTROLA_MINIMOS, 'N') = 'S', 'Sim', 'Não')," &
                          "IIF(ISNULL(EST.IC_PERMITE_BLOQUEIO, 'N') = 'S', 'Sim', 'Não')," &
                          "IIF(ISNULL(EST.IC_ATIVO, 'N') = 'S', 'Sim', 'Não')," &
                          "IIF(ISNULL(EST.IC_PERMITE_SALDO_NEGATIVO, 'N') = 'S', 'Sim', 'Não')," &
                          "IIF(ISNULL(EST.IC_ENTRADA_AUTOMATICA, 'N') = 'S', 'Sim', 'Não')" &
                   " FROM TB_ESTOQUE EST" &
                    " INNER JOIN TB_DEPARTAMENTO DEP ON EST.ID_DEPARTAMENTO_RESPONSAVEL = DEP.SQ_DEPARTAMENTO" &
                   " WHERE DEP.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY EST.NO_ESTOQUE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridEstoque_SQ_ESTOQUE,
                                                               const_GridEstoque_ID_DEPARTAMENTO_RESPONSAVEL,
                                                               const_GridEstoque_CD_ESTOQUE,
                                                               const_GridEstoque_NO_ESTOQUE,
                                                               const_GridEstoque_IC_CONTROLA_MINIMOS,
                                                               const_GridEstoque_IC_PERMITE_BLOQUEIO,
                                                               const_GridEstoque_IC_ATIVO,
                                                               const_GridEstoque_IC_PERMITE_SALDO_NEGATIVO,
                                                               const_GridEstoque_IC_ENTRADA_AUTOMATICA})
      Case enListagemGeral_TipoTela.CadastroTransacaoEstoque
        sSqlText = "SELECT TSE.SQ_TRANSACAOESTOQUE," &
                          "TSE.ID_ESTOQUE_DEBITO," &
                          "TSE.ID_ESTOQUE_CREDITO," &
                          "TSE.CD_TRANSACAOESTOQUE," &
                          "TSE.NO_TRANSACAOESTOQUE," &
                          "IIF(TSE.IC_USAR_RECEBIMENTO = 'S', 1, 0)," &
                          "IIF(TSE.IC_USAR_VENDA = 'S', 1, 0)," &
                          "IIF(TSE.IC_USAR_MOVIMENTACAOMANUAL = 'S', 1, 0)," &
                          "IIF(TSE.IC_ATIVO = 'S', 1, 0)," &
                          "IIF(MVE.ID_TRANSACAOESTOQUE IS NULL, 'N', 'S')" &
                   " FROM TB_TRANSACAOESTOQUE TSE" &
                    " LEFT JOIN (SELECT DISTINCT ID_TRANSACAOESTOQUE" &
                                " FROM TB_MOVIMENTACAOESTOQUE) MVE ON MVE.ID_TRANSACAOESTOQUE = TSE.SQ_TRANSACAOESTOQUE" &
                   " WHERE TSE.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY TSE.NO_TRANSACAOESTOQUE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTransacaoEstoque_SQ_TRANSACAOESTOQUE,
                                                               const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO,
                                                               const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO,
                                                               const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE,
                                                               const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE,
                                                               const_GridTransacaoEstoque_IC_USAR_RECEBIMENTO,
                                                               const_GridTransacaoEstoque_IC_USAR_VENDA,
                                                               const_GridTransacaoEstoque_IC_USAR_MOVIMENTACAOMANUAL,
                                                               const_GridTransacaoEstoque_IC_ATIVO,
                                                               const_GridTransacaoEstoque_IC_EM_USO})
      Case enListagemGeral_TipoTela.CadastroServico
        sSqlText = "SELECT SQ_SERVICO," &
                          "ID_TIPO_SERVICO," &
                          "CD_SERVICO," &
                          "NO_SERVICO," &
                          "IIF(IC_GERAFINANCEIRO = 'S', 1, 0)," &
                          "IIF(IC_ATIVO = 'S', 1, 0)" &
                   " FROM TB_SERVICO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_SERVICO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridServico_SQ_SERVICO,
                                                               const_GridServico_ID_TIPO_SERVICO,
                                                               const_GridServico_CD_SERVICO,
                                                               const_GridServico_NO_SERVICO,
                                                               const_GridServico_IC_GERAFINANCEIRO,
                                                               const_GridServico_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        sSqlText = "SELECT SQ_MODELODOCUMENTO_ELEMENTO," &
                          "NO_MODELODOCUMENTO_ELEMENTO," &
                          "ISNULL(IC_SISTEMA, 'N')" &
                   " FROM TB_MODELODOCUMENTO_ELEMENTO" &
                   " WHERE (ID_EMPRESA = " & iID_EMPRESA_FILIAL & " OR ID_EMPRESA IS NULL)" &
                     " AND IC_ATIVO = 'S'" &
                     " AND ID_OPT_TIPO_ELEMENTO = " & IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, enOpcoes.TipoElementoModeloDocumento_Assinatura,
                                                      IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, enOpcoes.TipoElementoModeloDocumento_Cabecalho,
                                                                                                                                                        enOpcoes.TipoElementoModeloDocumento_Rodape)) &
                   " ORDER BY ISNULL(IC_SISTEMA, 'N') DESC," &
                             "NO_MODELODOCUMENTO_ELEMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridModeloDocumentoElemento_SQ_MODELODOCUMENTO_ELEMENTO,
                                                               const_GridModeloDocumentoElemento_NO_MODELODOCUMENTO_ELEMENTO,
                                                               const_GridModeloDocumentoElemento_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        sSqlText = "SELECT SQ_PLANOCONTAS_GRUPO," &
                          "ID_PLANOCONTAS_GRUPO_SUPERIOR," &
                          "CD_PLANOCONTAS_GRUPO," &
                          "NO_PLANOCONTAS_GRUPO" &
                   " FROM TB_PLANOCONTAS_GRUPO" &
                   " ORDER BY CD_PLANOCONTAS_GRUPO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO,
                                                               const_GridPlanoContasGrupo_ID_PLANOCONTAS_GRUPO_SUPERIOR,
                                                               const_GridPlanoContasGrupo_CodigoGrupoProduto,
                                                               const_GridPlanoContasGrupo_NomeGrupoProduto})
      Case enListagemGeral_TipoTela.CadastroCaracteristicaProduto
        sSqlText = "SELECT SQ_CARACTERISTICA_PRODUTO," &
                          "NO_CARACTERISTICA" &
                   " FROM TB_CARACTERISTICA_PRODUTO" &
                   " ORDER BY NO_CARACTERISTICA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCaracteristicaProduto_SQ_CARACTERISTICA_PRODUTO,
                                                               const_GridCaracteristicaProduto_NO_CARACTERISTICA})
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalInutilizado
        sSqlText = "SELECT DFI.SQ_DOCUMENTOFISCAL_INUTILIZACAO," &
                          "DFT.NO_DOCUMENTOFISCAL_TIPO," &
                          "DFT.CD_SERVICO_MODELO," &
                          "DFS.CD_DOCUMENTOFISCAL_SERIE," &
                          "DFI.DH_INUTILIZACAO," &
                          "DFI.CD_DOCUMENTOFISCAL_INICIAL," &
                          "DFI.CD_DOCUMENTOFISCAL_FINAL," &
                          "DFI.CM_JUSTIFICATIVA" &
                   " FROM TB_DOCUMENTOFISCAL_INUTILIZACAO DFI" &
                    " INNER JOIN TB_DOCUMENTOFISCAL_TIPO DFT ON DFT.SQ_DOCUMENTOFISCAL_TIPO = DFI.ID_DOCUMENTOFISCAL_TIPO" &
                    " INNER JOIN TB_DOCUMENTOFISCAL_SERIE DFS ON DFS.SQ_DOCUMENTOFISCAL_SERIE = DFI.ID_DOCUMENTOFISCAL_SERIE" &
                   " ORDER BY DFT.NO_DOCUMENTOFISCAL_TIPO," &
                             "DFT.CD_SERVICO_MODELO," &
                             "DFS.CD_DOCUMENTOFISCAL_SERIE," &
                             "DFI.DH_INUTILIZACAO, " &
                             "DFI.CD_DOCUMENTOFISCAL_INICIAL"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridDocumentoFiscalInutilizado_SQ_DOCUMENTOFISCAL_INUTILIZACAO,
                                                               const_GridDocumentoFiscalInutilizado_NO_DOCUMENTOFISCAL_TIPO,
                                                               const_GridDocumentoFiscalInutilizado_CD_SERVICO_MODELO,
                                                               const_GridDocumentoFiscalInutilizado_CD_DOCUMENTOFISCAL_SERIE,
                                                               const_GridDocumentoFiscalInutilizado_DH_INUTILIZACAO,
                                                               const_GridDocumentoFiscalInutilizado_CD_DOCUMENTOFISCAL_INICIAL,
                                                               const_GridDocumentoFiscalInutilizado_CD_DOCUMENTOFISCAL_FINAL,
                                                               const_GridDocumentoFiscalInutilizado_CM_JUSTIFICATIVA})
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalTipo
        sSqlText = "SELECT SQ_DOCUMENTOFISCAL_TIPO," +
                          "ID_OPT_NFE_TIPOOPERACAO," +
                          "ID_OPT_NFE_FORMATOIMPRESSAODANFE," +
                          "NO_DOCUMENTOFISCAL_TIPO," +
                          "CD_DOCUMENTOFISCAL_TIPO," +
                          "CD_SERVICO_MODELO," +
                          "CD_SERVICO_VERSAO," +
                          "IIF(IC_ATIVO = 'S', 1, 0)," +
                          "ID_OPT_EXIGE_PESSOA," +
                          "ID_OPT_EXIGE_ENDERECO," +
                          "ID_TIPO_DOCUMENTO" +
                   " FROM TB_DOCUMENTOFISCAL_TIPO" +
                   " ORDER BY NO_DOCUMENTOFISCAL_TIPO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridDocumentoFiscalTipo_SQ_DOCUMENTOFISCAL_TIPO,
                                                               const_GridDocumentoFiscalTipo_ID_OPT_NFE_TIPOOPERACAO,
                                                               const_GridDocumentoFiscalTipo_ID_OPT_NFE_FORMATOIMPRESSAODANFE,
                                                               const_GridDocumentoFiscalTipo_NO_DOCUMENTOFISCAL_TIPO,
                                                               const_GridDocumentoFiscalTipo_CD_DOCUMENTOFISCAL_TIPO,
                                                               const_GridDocumentoFiscalTipo_CD_SERVICO_MODELO,
                                                               const_GridDocumentoFiscalTipo_CD_SERVICO_VERSAO,
                                                               const_GridDocumentoFiscalTipo_IC_ATIVO,
                                                               const_GridDocumentoFiscalTipo_ID_OPT_EXIGE_PESSOA,
                                                               const_GridDocumentoFiscalTipo_ID_OPT_EXIGE_ENDERECO,
                                                               const_GridDocumentoFiscalTipo_ID_TIPO_DOCUMENTO})
    End Select

    lblRotuloListagem.Text = lblRotuloListagem.Tag & " (" & grdListagem.Rows.Count & " registro(s))"
  End Sub

  Private Sub grdListagem_AfterRowsDeleted(sender As Object, e As EventArgs) Handles grdListagem.AfterRowsDeleted
    If bLinhaExcluida Then
      Pesquisar()
    End If
  End Sub

  Private Sub grdListagem_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles grdListagem.AfterRowUpdate
    Dim sSqlText As String = ""
    Dim bPesquisar As Boolean
    Dim iID_Aux As Integer

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalSerie
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_SQ_DOCUMENTOFISCAL_SERIE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_DOCUMENTOFISCAL_SERIE", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                                            "ID_DOCUMENTOFISCAL_TIPO", "@ID_DOCUMENTOFISCAL_TIPO",
                                                                                            "CD_DOCUMENTOFISCAL_SERIE", "@CD_DOCUMENTOFISCAL_SERIE",
                                                                                            "CD_ULTIMAEMISSAO_NUMERO ", "@CD_ULTIMAEMISSAO_NUMERO ",
                                                                                            "IC_PADRAO_VENDA", "@IC_PADRAO_VENDA",
                                                                                            "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("ID_DOCUMENTOFISCAL_TIPO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_ID_DOCUMENTOFISCAL_TIPO, e.Row.Index)),
                                            DBParametro_Montar("CD_DOCUMENTOFISCAL_SERIE", Trim(objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_CD_DOCUMENTOFISCAL_SERIE, e.Row.Index))),
                                            DBParametro_Montar("CD_ULTIMAEMISSAO_NUMERO", FNC_NuloString(Trim(objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_CD_ULTIMAEMISSAO_NUMERO, e.Row.Index, "")), False)),
                                            DBParametro_Montar("IC_PADRAO_VENDA", objGrid_CheckCol_Valor(grdListagem, const_GridCanalNegocio_Ativo, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridCanalNegocio_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_DOCUMENTOFISCAL_SERIE", FNC_GerarArray("ID_DOCUMENTOFISCAL_TIPO", "@ID_DOCUMENTOFISCAL_TIPO",
                                                                                "CD_DOCUMENTOFISCAL_SERIE", "@CD_DOCUMENTOFISCAL_SERIE",
                                                                                "CD_ULTIMAEMISSAO_NUMERO ", "@CD_ULTIMAEMISSAO_NUMERO ",
                                                                                "IC_PADRAO_VENDA", "@IC_PADRAO_VENDA",
                                                                                "IC_ATIVO", "@IC_ATIVO"),
                                                                 FNC_GerarArray("SQ_DOCUMENTOFISCAL_SERIE", "@SQ_DOCUMENTOFISCAL_SERIE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_DOCUMENTOFISCAL_TIPO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_ID_DOCUMENTOFISCAL_TIPO, e.Row.Index)),
                                            DBParametro_Montar("CD_DOCUMENTOFISCAL_SERIE", Trim(objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_CD_DOCUMENTOFISCAL_SERIE, e.Row.Index))),
                                            DBParametro_Montar("CD_ULTIMAEMISSAO_NUMERO", FNC_NuloString(Trim(objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_CD_ULTIMAEMISSAO_NUMERO, e.Row.Index, "")), False)),
                                            DBParametro_Montar("IC_PADRAO_VENDA", objGrid_CheckCol_Valor(grdListagem, const_GridDocumentoFiscalSerie_IC_PADRAO_VENDA, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridDocumentoFiscalSerie_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("SQ_DOCUMENTOFISCAL_SERIE", objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_SQ_DOCUMENTOFISCAL_SERIE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalTipo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_SQ_DOCUMENTOFISCAL_TIPO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_DOCUMENTOFISCAL_TIPO", TipoCampoFixo.DadoCriacao, "ID_OPT_NFE_TIPOOPERACAO", "@ID_OPT_NFE_TIPOOPERACAO",
                                                                                           "ID_OPT_NFE_FORMATOIMPRESSAODANFE", "@ID_OPT_NFE_FORMATOIMPRESSAODANFE",
                                                                                           "NO_DOCUMENTOFISCAL_TIPO", "@NO_DOCUMENTOFISCAL_TIPO",
                                                                                           "CD_DOCUMENTOFISCAL_TIPO", "@CD_DOCUMENTOFISCAL_TIPO",
                                                                                           "CD_SERVICO_MODELO", "@CD_SERVICO_MODELO",
                                                                                           "CD_SERVICO_VERSAO", "@CD_SERVICO_VERSAO",
                                                                                           "IC_ATIVO", "@IC_ATIVO",
                                                                                           "ID_OPT_EXIGE_PESSOA", "@ID_OPT_EXIGE_PESSOA",
                                                                                           "ID_OPT_EXIGE_ENDERECO", "@ID_OPT_EXIGE_ENDERECO",
                                                                                           "ID_TIPO_DOCUMENTO", "@ID_TIPO_DOCUMENTO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_OPT_NFE_TIPOOPERACAO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_OPT_NFE_TIPOOPERACAO, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_NFE_FORMATOIMPRESSAODANFE", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_OPT_NFE_FORMATOIMPRESSAODANFE, e.Row.Index)),
                                            DBParametro_Montar("NO_DOCUMENTOFISCAL_TIPO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_NO_DOCUMENTOFISCAL_TIPO, e.Row.Index)),
                                            DBParametro_Montar("CD_DOCUMENTOFISCAL_TIPO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_CD_DOCUMENTOFISCAL_TIPO, e.Row.Index)),
                                            DBParametro_Montar("CD_SERVICO_MODELO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_CD_SERVICO_MODELO, e.Row.Index)),
                                            DBParametro_Montar("CD_SERVICO_VERSAO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_CD_SERVICO_VERSAO, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridDocumentoFiscalTipo_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_EXIGE_PESSOA", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_OPT_EXIGE_PESSOA, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_EXIGE_ENDERECO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_OPT_EXIGE_ENDERECO, e.Row.Index)),
                                            DBParametro_Montar("ID_TIPO_DOCUMENTO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_TIPO_DOCUMENTO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_DOCUMENTOFISCAL_TIPO", FNC_GerarArray("ID_OPT_NFE_TIPOOPERACAO", "@ID_OPT_NFE_TIPOOPERACAO",
                                                                               "ID_OPT_NFE_FORMATOIMPRESSAODANFE", "@ID_OPT_NFE_FORMATOIMPRESSAODANFE",
                                                                               "NO_DOCUMENTOFISCAL_TIPO", "@NO_DOCUMENTOFISCAL_TIPO",
                                                                               "CD_DOCUMENTOFISCAL_TIPO", "@CD_DOCUMENTOFISCAL_TIPO",
                                                                               "CD_SERVICO_MODELO", "@CD_SERVICO_MODELO",
                                                                               "CD_SERVICO_VERSAO", "@CD_SERVICO_VERSAO",
                                                                               "IC_ATIVO", "@IC_ATIVO",
                                                                               "ID_OPT_EXIGE_PESSOA", "@ID_OPT_EXIGE_PESSOA",
                                                                               "ID_OPT_EXIGE_ENDERECO", "@ID_OPT_EXIGE_ENDERECO",
                                                                               "ID_TIPO_DOCUMENTO", "@ID_TIPO_DOCUMENTO"),
                                                                FNC_GerarArray("SQ_DOCUMENTOFISCAL_TIPO", "@SQ_DOCUMENTOFISCAL_TIPO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_OPT_NFE_TIPOOPERACAO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_OPT_NFE_TIPOOPERACAO, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_NFE_FORMATOIMPRESSAODANFE", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_OPT_NFE_FORMATOIMPRESSAODANFE, e.Row.Index)),
                                            DBParametro_Montar("NO_DOCUMENTOFISCAL_TIPO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_NO_DOCUMENTOFISCAL_TIPO, e.Row.Index)),
                                            DBParametro_Montar("CD_DOCUMENTOFISCAL_TIPO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_CD_DOCUMENTOFISCAL_TIPO, e.Row.Index)),
                                            DBParametro_Montar("CD_SERVICO_MODELO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_CD_SERVICO_MODELO, e.Row.Index)),
                                            DBParametro_Montar("CD_SERVICO_VERSAO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_CD_SERVICO_VERSAO, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridDocumentoFiscalTipo_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_EXIGE_PESSOA", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_OPT_EXIGE_PESSOA, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_EXIGE_ENDERECO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_OPT_EXIGE_ENDERECO, e.Row.Index)),
                                            DBParametro_Montar("ID_TIPO_DOCUMENTO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalTipo_ID_TIPO_DOCUMENTO, e.Row.Index)),
                                            DBParametro_Montar("SQ_DOCUMENTOFISCAL_TIPO", objGrid_Valor(grdListagem, const_GridDocumentoFiscalSerie_SQ_DOCUMENTOFISCAL_SERIE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroVacina
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridCanalNegocio_SQ_CANALNEGOCIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_VACINA", TipoCampoFixo.DadoCriacao, "NO_VACINA", "@NO_VACINA",
                                                                             "DS_SERVENTIA", "@DS_SERVENTIA",
                                                                             "DS_INICIO", "@DS_INICIO",
                                                                             "DS_TERMINO", "@DS_TERMINO",
                                                                             "DS_APRAZAMENTO", "@DS_APRAZAMENTO",
                                                                             "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_VACINA", Trim(objGrid_Valor(grdListagem, const_GridVacina_NO_VACINA, e.Row.Index))),
                                            DBParametro_Montar("DS_SERVENTIA", Trim(objGrid_Valor(grdListagem, const_GridVacina_DS_SERVENTIA, e.Row.Index))),
                                            DBParametro_Montar("DS_INICIO", Trim(objGrid_Valor(grdListagem, const_GridVacina_DS_INICIO, e.Row.Index))),
                                            DBParametro_Montar("DS_TERMINO", Trim(objGrid_Valor(grdListagem, const_GridVacina_DS_TERMINO, e.Row.Index))),
                                            DBParametro_Montar("DS_APRAZAMENTO", Trim(objGrid_Valor(grdListagem, const_GridVacina_DS_APRAZAMENTO, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridVacina_IC_ATIVO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_VACINA", FNC_GerarArray("NO_VACINA", "@NO_VACINA",
                                                                 "DS_SERVENTIA", "@DS_SERVENTIA",
                                                                 "DS_INICIO", "@DS_INICIO",
                                                                 "DS_TERMINO", "@DS_TERMINO",
                                                                 "DS_APRAZAMENTO", "@DS_APRAZAMENTO",
                                                                 "IC_ATIVO", "@IC_ATIVO"),
                                                  FNC_GerarArray("SQ_VACINA", "@SQ_VACINA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_VACINA", Trim(objGrid_Valor(grdListagem, const_GridVacina_NO_VACINA, e.Row.Index))),
                                            DBParametro_Montar("DS_SERVENTIA", Trim(objGrid_Valor(grdListagem, const_GridVacina_DS_SERVENTIA, e.Row.Index))),
                                            DBParametro_Montar("DS_INICIO", Trim(objGrid_Valor(grdListagem, const_GridVacina_DS_INICIO, e.Row.Index))),
                                            DBParametro_Montar("DS_TERMINO", Trim(objGrid_Valor(grdListagem, const_GridVacina_DS_TERMINO, e.Row.Index))),
                                            DBParametro_Montar("DS_APRAZAMENTO", Trim(objGrid_Valor(grdListagem, const_GridVacina_DS_APRAZAMENTO, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridVacina_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("SQ_VACINA", objGrid_Valor(grdListagem, const_GridVacina_SQ_VACINA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroConsultorio
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridConsultorio_SQ_CONSULTORIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CONSULTORIO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", iID_EMPRESA_FILIAL,
                                                                                  "NO_CONSULTORIO", "@NO_CONSULTORIO",
                                                                                  "CD_CONSULTORIO", "@CD_CONSULTORIO",
                                                                                  "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CONSULTORIO", Trim(objGrid_Valor(grdListagem, const_GridConsultorio_NO_CONSULTORIO, e.Row.Index))),
                                            DBParametro_Montar("CD_CONSULTORIO", Trim(objGrid_Valor(grdListagem, const_GridConsultorio_CD_CONSULTORIO, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridConsultorio_IC_ATIVO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CONSULTORIO", FNC_GerarArray("NO_CONSULTORIO", "@NO_CONSULTORIO",
                                                                      "CD_CONSULTORIO", "@CD_CONSULTORIO",
                                                                      "IC_ATIVO", "@IC_ATIVO"),
                                                       FNC_GerarArray("SQ_CONSULTORIO", "@SQ_CONSULTORIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CONSULTORIO", Trim(objGrid_Valor(grdListagem, const_GridConsultorio_NO_CONSULTORIO, e.Row.Index))),
                                            DBParametro_Montar("CD_CONSULTORIO", Trim(objGrid_Valor(grdListagem, const_GridConsultorio_CD_CONSULTORIO, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridConsultorio_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("SQ_CONSULTORIO", Trim(objGrid_Valor(grdListagem, const_GridConsultorio_SQ_CONSULTORIO, e.Row.Index))))
        End If
      Case enListagemGeral_TipoTela.CadastroTurno
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTurno_SQ_TURNO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TURNO", TipoCampoFixo.DadoCriacao, "NO_TURNO", "@NO_TURNO",
                                                                            "HR_INICIO", "@HR_INICIO",
                                                                            "HR_FIM", "@HR_FIM")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TURNO", Trim(objGrid_Valor(grdListagem, const_GridTurno_NO_TURNO, e.Row.Index))),
                                            DBParametro_Montar("HR_INICIO", Trim(objGrid_Valor(grdListagem, const_GridTurno_HR_INICIO, e.Row.Index).ToString().Substring(11, 5))),
                                            DBParametro_Montar("HR_FIM", objGrid_Valor(grdListagem, const_GridTurno_HR_FIM, e.Row.Index).ToString().Substring(11, 5)))
        Else
          sSqlText = DBMontar_Update("TB_TURNO", FNC_GerarArray("NO_TURNO", "@NO_TURNO",
                                                                "HR_INICIO", "@HR_INICIO",
                                                                "HR_FIM", "@HR_FIM"),
                                                       FNC_GerarArray("SQ_TURNO", "@SQ_TURNO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TURNO", Trim(objGrid_Valor(grdListagem, const_GridTurno_NO_TURNO, e.Row.Index))),
                                            DBParametro_Montar("HR_INICIO", Trim(objGrid_Valor(grdListagem, const_GridTurno_HR_INICIO, e.Row.Index).ToString().Substring(11, 5))),
                                            DBParametro_Montar("HR_FIM", objGrid_Valor(grdListagem, const_GridTurno_HR_FIM, e.Row.Index).ToString().Substring(11, 5)),
                                            DBParametro_Montar("SQ_TURNO", Trim(objGrid_Valor(grdListagem, const_GridTurno_SQ_TURNO, e.Row.Index))))
        End If
      Case enListagemGeral_TipoTela.CadastroCanalNegocio
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridCanalNegocio_SQ_CANALNEGOCIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CANALNEGOCIO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                                   "ID_OPT_TIPOCANALNEGOCIO", "@ID_OPT_TIPOCANALNEGOCIO",
                                                                                   "NO_CANALNEGOCIO", "@NO_CANALNEGOCIO",
                                                                                   "ID_CONTABILIZACAO_PADRAO", "@ID_CONTABILIZACAO_PADRAO",
                                                                                   "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("ID_OPT_TIPOCANALNEGOCIO", objGrid_Valor(grdListagem, const_GridCanalNegocio_ID_OPT_TIPOCANALNEGOCIO, e.Row.Index)),
                                            DBParametro_Montar("NO_CANALNEGOCIO", Trim(objGrid_Valor(grdListagem, const_GridCanalNegocio_NomeCanalNegocio, e.Row.Index))),
                                            DBParametro_Montar("ID_CONTABILIZACAO_PADRAO", objGrid_Valor(grdListagem, const_GridCanalNegocio_ID_CONTABILIZACAO, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridCanalNegocio_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CANALNEGOCIO", FNC_GerarArray("ID_OPT_TIPOCANALNEGOCIO", "@ID_OPT_TIPOCANALNEGOCIO",
                                                                       "NO_CANALNEGOCIO", "@NO_CANALNEGOCIO",
                                                                       "ID_CONTABILIZACAO_PADRAO", "@ID_CONTABILIZACAO_PADRAO",
                                                                       "IC_ATIVO", "@IC_ATIVO"),
                                                        FNC_GerarArray("SQ_CANALNEGOCIO", "@SQ_CANALNEGOCIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("ID_OPT_TIPOCANALNEGOCIO", objGrid_Valor(grdListagem, const_GridCanalNegocio_ID_OPT_TIPOCANALNEGOCIO, e.Row.Index)),
                                            DBParametro_Montar("NO_CANALNEGOCIO", Trim(objGrid_Valor(grdListagem, const_GridCanalNegocio_NomeCanalNegocio, e.Row.Index))),
                                            DBParametro_Montar("ID_CONTABILIZACAO_PADRAO", objGrid_Valor(grdListagem, const_GridCanalNegocio_ID_CONTABILIZACAO, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridCanalNegocio_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_CANALNEGOCIO", objGrid_Valor(grdListagem, const_GridCanalNegocio_SQ_CANALNEGOCIO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_PLANOCONTAS_GRUPO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                                        "ID_PLANOCONTAS_GRUPO_SUPERIOR", "@ID_PLANOCONTAS_GRUPO_SUPERIOR",
                                                                                        "CD_PLANOCONTAS_GRUPO", "@CD_PLANOCONTAS_GRUPO",
                                                                                        "NO_PLANOCONTAS_GRUPO", "@NO_PLANOCONTAS_GRUPO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                            DBParametro_Montar("ID_PLANOCONTAS_GRUPO_SUPERIOR", objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_ID_PLANOCONTAS_GRUPO_SUPERIOR, e.Row.Index)),
                                            DBParametro_Montar("CD_PLANOCONTAS_GRUPO", Trim(objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_CodigoGrupoProduto, e.Row.Index))),
                                            DBParametro_Montar("NO_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_NomeGrupoProduto, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_PLANOCONTAS_GRUPO", FNC_GerarArray("ID_PLANOCONTAS_GRUPO_SUPERIOR", "@ID_PLANOCONTAS_GRUPO_SUPERIOR",
                                                                            "CD_PLANOCONTAS_GRUPO", "@CD_PLANOCONTAS_GRUPO",
                                                                            "NO_PLANOCONTAS_GRUPO", "@NO_PLANOCONTAS_GRUPO"),
                                                             FNC_GerarArray("SQ_PLANOCONTAS_GRUPO", "@SQ_PLANOCONTAS_GRUPO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_PLANOCONTAS_GRUPO_SUPERIOR", Trim(objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_ID_PLANOCONTAS_GRUPO_SUPERIOR, e.Row.Index))),
                                            DBParametro_Montar("CD_PLANOCONTAS_GRUPO", Trim(objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_CodigoGrupoProduto, e.Row.Index))),
                                            DBParametro_Montar("NO_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_NomeGrupoProduto, e.Row.Index)),
                                            DBParametro_Montar("SQ_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO, e.Row.Index)))
        End If

        Formatar()
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridPlanoContas_SQ_PLANOCONTAS, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_PLANOCONTAS", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                                  "ID_PLANOCONTAS_GRUPO", "@ID_PLANOCONTAS_GRUPO",
                                                                                  "CD_PLANOCONTAS", "@CD_PLANOCONTAS",
                                                                                  "NO_PLANOCONTAS", "@NO_PLANOCONTAS",
                                                                                  "ID_OPT_CREDITODEBITO", "@ID_OPT_CREDITODEBITO",
                                                                                  "ID_OPT_TIPOCUSTO", "@ID_OPT_TIPOCUSTO",
                                                                                  "CD_PLANOCONTAS_CONTABILIDADE", "@CD_PLANOCONTAS_CONTABILIDADE",
                                                                                  "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("ID_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContas_GrupoPlanoContas, e.Row.Index)),
                                            DBParametro_Montar("CD_PLANOCONTAS", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_CodigoPlanoContas, e.Row.Index))),
                                            DBParametro_Montar("NO_PLANOCONTAS", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_NomePlanoContas, e.Row.Index))),
                                            DBParametro_Montar("ID_OPT_CREDITODEBITO", objGrid_Valor(grdListagem, const_GridPlanoContas_CreditoDebito, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_TIPOCUSTO", objGrid_Valor(grdListagem, const_GridPlanoContas_TipoCusto, e.Row.Index)),
                                            DBParametro_Montar("CD_PLANOCONTAS_CONTABILIDADE", Trim(FNC_NVL(objGrid_Valor(grdListagem, const_GridPlanoContas_CodigoPlanoContasContabilidade, e.Row.Index), ""))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridPlanoContas_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_PLANOCONTAS", FNC_GerarArray("ID_PLANOCONTAS_GRUPO", "@ID_PLANOCONTAS_GRUPO",
                                                                      "CD_PLANOCONTAS", "@CD_PLANOCONTAS",
                                                                      "NO_PLANOCONTAS", "@NO_PLANOCONTAS",
                                                                      "ID_OPT_CREDITODEBITO", "@ID_OPT_CREDITODEBITO",
                                                                      "ID_OPT_TIPOCUSTO", "@ID_OPT_TIPOCUSTO",
                                                                      "CD_PLANOCONTAS_CONTABILIDADE", "@CD_PLANOCONTAS_CONTABILIDADE",
                                                                      "IC_ATIVO", "@IC_ATIVO"),
                                                       FNC_GerarArray("SQ_PLANOCONTAS", "@SQ_PLANOCONTAS"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContas_GrupoPlanoContas, e.Row.Index)),
                                            DBParametro_Montar("CD_PLANOCONTAS", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_CodigoPlanoContas, e.Row.Index))),
                                            DBParametro_Montar("NO_PLANOCONTAS", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_NomePlanoContas, e.Row.Index))),
                                            DBParametro_Montar("ID_OPT_CREDITODEBITO", objGrid_Valor(grdListagem, const_GridPlanoContas_CreditoDebito, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_TIPOCUSTO", objGrid_Valor(grdListagem, const_GridPlanoContas_TipoCusto, e.Row.Index)),
                                            DBParametro_Montar("CD_PLANOCONTAS_CONTABILIDADE", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_CodigoPlanoContasContabilidade, e.Row.Index, ""))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridPlanoContas_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_PLANOCONTAS", objGrid_Valor(grdListagem, const_GridPlanoContas_SQ_PLANOCONTAS, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroProfissao
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridProfissao_SQ_PROFISSAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_PROFISSAO", TipoCampoFixo.DadoCriacao, "NO_PROFISSAO", "@NO_PROFISSAO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_PROFISSAO", Trim(objGrid_Valor(grdListagem, const_GridProfissao_NomeProfissao, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_PROFISSAO", FNC_GerarArray("NO_PROFISSAO", "@NO_PROFISSAO"),
                                                     FNC_GerarArray("SQ_PROFISSAO", "@SQ_PROFISSAO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_PROFISSAO", Trim(objGrid_Valor(grdListagem, const_GridProfissao_NomeProfissao, e.Row.Index))),
                                            DBParametro_Montar("SQ_PROFISSAO", objGrid_Valor(grdListagem, const_GridProfissao_SQ_PROFISSAO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoIndicador
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoIndicador_SQ_TIPOINDICADOR, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPOINDICADOR", TipoCampoFixo.DadoCriacao, "NO_TIPOINDICADOR", "@NO_TIPOINDICADOR")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPOINDICADOR", Trim(objGrid_Valor(grdListagem, const_GridTipoIndicador_NO_TIPOINDICADOR, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPOINDICADOR", FNC_GerarArray("NO_TIPOINDICADOR", "@NO_TIPOINDICADOR"),
                                                         FNC_GerarArray("SQ_TIPOINDICADOR", "@SQ_TIPOINDICADOR"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPOINDICADOR", Trim(objGrid_Valor(grdListagem, const_GridTipoIndicador_NO_TIPOINDICADOR, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPOINDICADOR", objGrid_Valor(grdListagem, const_GridTipoIndicador_SQ_TIPOINDICADOR, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroCanalMarcacao
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridCanalMarcacao_SQ_CANALMARCACAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CANALMARCACAO", TipoCampoFixo.DadoCriacao, "NO_CANALMARCACAO", "@NO_CANALMARCACAO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CANALMARCACAO", Trim(objGrid_Valor(grdListagem, const_GridCanalMarcacao_NO_CANALMARCACAO, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_CANALMARCACAO", FNC_GerarArray("NO_CANALMARCACAO", "@NO_CANALMARCACAO"),
                                                         FNC_GerarArray("SQ_CANALMARCACAO", "@SQ_CANALMARCACAO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CANALMARCACAO", Trim(objGrid_Valor(grdListagem, const_GridCanalMarcacao_NO_CANALMARCACAO, e.Row.Index))),
                                            DBParametro_Montar("SQ_CANALMARCACAO", objGrid_Valor(grdListagem, const_GridCanalMarcacao_SQ_CANALMARCACAO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroClassificacaoExame
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridClassificacaoExame_SQ_CLASSIFICACAO_EXAME, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CLASSIFICACAO_EXAME", TipoCampoFixo.DadoCriacao, "NO_CLASSIFICACAO_EXAME", "@NO_CLASSIFICACAO_EXAME")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CLASSIFICACAO_EXAME", Trim(objGrid_Valor(grdListagem, const_GridClassificacaoExame_NO_CLASSIFICACAO_EXAME, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_CLASSIFICACAO_EXAME", FNC_GerarArray("NO_CLASSIFICACAO_EXAME", "@NO_CLASSIFICACAO_EXAME"),
                                                               FNC_GerarArray("SQ_CLASSIFICACAO_EXAME", "@SQ_CLASSIFICACAO_EXAME"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CLASSIFICACAO_EXAME", Trim(objGrid_Valor(grdListagem, const_GridClassificacaoExame_NO_CLASSIFICACAO_EXAME, e.Row.Index))),
                                            DBParametro_Montar("SQ_CLASSIFICACAO_EXAME", objGrid_Valor(grdListagem, const_GridClassificacaoExame_SQ_CLASSIFICACAO_EXAME, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoProcedimento
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridGrupoProcedimento_SQ_GRUPOPROCEDIMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_GRUPOPROCEDIMENTO", TipoCampoFixo.DadoCriacao, "NO_GRUPOPROCEDIMENTO", "@NO_GRUPOPROCEDIMENTO",
                                                                                        "ID_PLANOCONTAS", "@ID_PLANOCONTAS",
                                                                                        "ID_PLANOCONTAS_CONTASPAGAR", "@ID_PLANOCONTAS_CONTASPAGAR",
                                                                                        "TP_BLOQUEAR_AGENDAMENTO_DUPLICADO", "@TP_BLOQUEAR_AGENDAMENTO_DUPLICADO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_GRUPOPROCEDIMENTO", Trim(objGrid_Valor(grdListagem, const_GridGrupoProcedimento_NO_GRUPOPROCEDIMENTO, e.Row.Index))),
                                            DBParametro_Montar("ID_PLANOCONTAS", objGrid_Valor(grdListagem, const_GridGrupoProcedimento_ID_PLANOCONTAS, e.Row.Index)),
                                            DBParametro_Montar("ID_PLANOCONTAS_CONTASPAGAR", objGrid_Valor(grdListagem, const_GridGrupoProcedimento_ID_PLANOCONTAS_CONTASPAGAR, e.Row.Index)),
                                            DBParametro_Montar("TP_BLOQUEAR_AGENDAMENTO_DUPLICADO", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProcedimento_TP_BLOQUEAR_AGENDAMENTO_DUPLICADO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_GRUPOPROCEDIMENTO", FNC_GerarArray("NO_GRUPOPROCEDIMENTO", "@NO_GRUPOPROCEDIMENTO",
                                                                            "ID_PLANOCONTAS", "@ID_PLANOCONTAS",
                                                                            "ID_PLANOCONTAS_CONTASPAGAR", "@ID_PLANOCONTAS_CONTASPAGAR",
                                                                            "TP_BLOQUEAR_AGENDAMENTO_DUPLICADO", "@TP_BLOQUEAR_AGENDAMENTO_DUPLICADO"),
                                                             FNC_GerarArray("SQ_GRUPOPROCEDIMENTO", "@SQ_GRUPOPROCEDIMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_GRUPOPROCEDIMENTO", Trim(objGrid_Valor(grdListagem, const_GridGrupoProcedimento_NO_GRUPOPROCEDIMENTO, e.Row.Index))),
                                            DBParametro_Montar("ID_PLANOCONTAS", objGrid_Valor(grdListagem, const_GridGrupoProcedimento_ID_PLANOCONTAS, e.Row.Index)),
                                            DBParametro_Montar("ID_PLANOCONTAS_CONTASPAGAR", objGrid_Valor(grdListagem, const_GridGrupoProcedimento_ID_PLANOCONTAS_CONTASPAGAR, e.Row.Index)),
                                            DBParametro_Montar("TP_BLOQUEAR_AGENDAMENTO_DUPLICADO", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProcedimento_TP_BLOQUEAR_AGENDAMENTO_DUPLICADO, e.Row.Index)),
                                            DBParametro_Montar("SQ_GRUPOPROCEDIMENTO", objGrid_Valor(grdListagem, const_GridGrupoProcedimento_SQ_GRUPOPROCEDIMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroConselhoProfissional
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridConselhoProfissional_SQ_CONSELHOPROFISSIONAL, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CONSELHOPROFISSIONAL", TipoCampoFixo.DadoCriacao, "CD_CONSELHOPROFISSIONAL", "@CD_CONSELHOPROFISSIONAL",
                                                                                           "NO_CONSELHOPROFISSIONAL", "@NO_CONSELHOPROFISSIONAL")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("CD_CONSELHOPROFISSIONAL", Trim(objGrid_Valor(grdListagem, const_GridConselhoProfissional_CD_CONSELHOPROFISSIONAL, e.Row.Index))),
                                            DBParametro_Montar("NO_CONSELHOPROFISSIONAL", Trim(objGrid_Valor(grdListagem, const_GridConselhoProfissional_NO_CONSELHOPROFISSIONAL, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_CONSELHOPROFISSIONAL", FNC_GerarArray("CD_CONSELHOPROFISSIONAL", "@CD_CONSELHOPROFISSIONAL",
                                                                               "NO_CONSELHOPROFISSIONAL", "@NO_CONSELHOPROFISSIONAL"),
                                                                FNC_GerarArray("SQ_CONSELHOPROFISSIONAL", "@SQ_CONSELHOPROFISSIONAL"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("CD_CONSELHOPROFISSIONAL", Trim(objGrid_Valor(grdListagem, const_GridConselhoProfissional_CD_CONSELHOPROFISSIONAL, e.Row.Index))),
                                            DBParametro_Montar("NO_CONSELHOPROFISSIONAL", Trim(objGrid_Valor(grdListagem, const_GridConselhoProfissional_NO_CONSELHOPROFISSIONAL, e.Row.Index))),
                                            DBParametro_Montar("SQ_CONSELHOPROFISSIONAL", objGrid_Valor(grdListagem, const_GridConselhoProfissional_SQ_CONSELHOPROFISSIONAL, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_DOENCA_ESTAGIO", TipoCampoFixo.DadoCriacao, "NO_DOENCA_ESTAGIO", "@NO_DOENCA_ESTAGIO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_DOENCA_ESTAGIO", Trim(objGrid_Valor(grdListagem, const_GridDoencaEstagio_DoencaEstagio, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_DOENCA_ESTAGIO", FNC_GerarArray("NO_DOENCA_ESTAGIO", "@NO_DOENCA_ESTAGIO"),
                                                          FNC_GerarArray("SQ_DOENCA_ESTAGIO", "@SQ_DOENCA_ESTAGIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_DOENCA_ESTAGIO", Trim(objGrid_Valor(grdListagem, const_GridDoencaEstagio_DoencaEstagio, e.Row.Index))),
                                            DBParametro_Montar("SQ_DOENCA_ESTAGIO", objGrid_Valor(grdListagem, const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoServico
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoServico_SQ_TIPO_SERVICO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_SERVICO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                                   "NO_TIPO_SERVICO", "@NO_TIPO_SERVICO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("NO_TIPO_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridTipoServico_NomeTipoServico, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_SERVICO", FNC_GerarArray("NO_TIPO_SERVICO", "@NO_TIPO_SERVICO"),
                                                        FNC_GerarArray("SQ_DOENCA_ESTAGIO", "@SQ_DOENCA_ESTAGIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridTipoServico_NomeTipoServico, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_SERVICO", objGrid_Valor(grdListagem, const_GridTipoServico_SQ_TIPO_SERVICO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRelatorio
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoRelatorio_SQ_TIPO_RELATORIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_RELATORIO", TipoCampoFixo.DadoCriacao, "NO_TIPO_RELATORIO", "@NO_TIPO_RELATORIO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RELATORIO", Trim(objGrid_Valor(grdListagem, const_GridTipoRelatorio_NO_TIPO_RELATORIO, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_RELATORIO", FNC_GerarArray("NO_TIPO_RELATORIO", "@NO_TIPO_RELATORIO"),
                                                          FNC_GerarArray("SQ_TIPO_RELATORIO", "@SQ_TIPO_RELATORIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RELATORIO", Trim(objGrid_Valor(grdListagem, const_GridTipoRelatorio_NO_TIPO_RELATORIO, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_RELATORIO", objGrid_Valor(grdListagem, const_GridTipoRelatorio_SQ_TIPO_RELATORIO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar,
           enListagemGeral_TipoTela.CadastroSegmento_OrdemServico
        Select Case eListagemGeral_TipoTela
          Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar
            iID_Aux = enOpcoes.TipoSegmento_ContasReceberContasPagar.GetHashCode
          Case enListagemGeral_TipoTela.CadastroSegmento_OrdemServico
            iID_Aux = enOpcoes.TipoSegmento_OrdemServico.GetHashCode
        End Select

        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridSegmento_SQ_SEGMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_SEGMENTO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                               "ID_OPT_TIPOSEGMENTO", "@ID_OPT_TIPOSEGMENTO",
                                                                               "NO_SEGMENTO", "@NO_SEGMENTO",
                                                                               "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("ID_OPT_TIPOSEGMENTO", iID_Aux),
                                            DBParametro_Montar("NO_SEGMENTO", Trim(objGrid_Valor(grdListagem, const_GridSegmento_NomeSegmento, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridSegmento_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_SEGMENTO", FNC_GerarArray("NO_SEGMENTO", "@NO_SEGMENTO",
                                                                   "IC_ATIVO", "@IC_ATIVO"),
                                                    FNC_GerarArray("SQ_SEGMENTO", "@SQ_SEGMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_SEGMENTO", Trim(objGrid_Valor(grdListagem, const_GridSegmento_NomeSegmento, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridSegmento_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_SEGMENTO", objGrid_Valor(grdListagem, const_GridSegmento_SQ_SEGMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoPermissao
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridGrupoPermissao_SQ_GRUPOPERMISSAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_SEG_GRUPOPERMISSAO", TipoCampoFixo.DadoCriacao, "NO_GRUPOPERMISSAO", "@NO_GRUPOPERMISSAO",
                                                                                         "ID_EMPRESA", "@ID_EMPRESA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_GRUPOPERMISSAO", Trim(objGrid_Valor(grdListagem, const_GridGrupoPermissao_NomeGrupoPermissao, e.Row.Index))),
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ))
        Else
          sSqlText = DBMontar_Update("TB_SEG_GRUPOPERMISSAO", FNC_GerarArray("NO_GRUPOPERMISSAO", "@NO_GRUPOPERMISSAO",
                                                                             "ID_EMPRESA", "@ID_EMPRESA"),
                                                              FNC_GerarArray("SQ_GRUPOPERMISSAO", "@SQ_GRUPOPERMISSAO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_GRUPOPERMISSAO", Trim(objGrid_Valor(grdListagem, const_GridGrupoPermissao_NomeGrupoPermissao, e.Row.Index))),
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                            DBParametro_Montar("SQ_GRUPOPERMISSAO", objGrid_Valor(grdListagem, const_GridGrupoPermissao_SQ_GRUPOPERMISSAO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroCargo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridProfissao_SQ_PROFISSAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CARGO", TipoCampoFixo.DadoCriacao, "NO_TIPO_CARGO", "@NO_TIPO_CARGO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CARGO", Trim(objGrid_Valor(grdListagem, const_GridCargo_NomeCargo, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CARGO", FNC_GerarArray("NO_TIPO_CARGO", "@NO_TIPO_CARGO"),
                                                      FNC_GerarArray("SQ_TIPO_CARGO", "@SQ_TIPO_CARGO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CARGO", Trim(objGrid_Valor(grdListagem, const_GridCargo_NomeCargo, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_CARGO", objGrid_Valor(grdListagem, const_GridCargo_SQ_TIPO_CARGO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroCidade
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridCidade_SQ_CIDADE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CIDADE", TipoCampoFixo.DadoCriacao, "ID_UF", "@ID_UF",
                                                                             "NO_CIDADE", "@NO_CIDADE",
                                                                             "CD_IBGE", "@CD_IBGE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_UF", objGrid_Valor(grdListagem, const_GridCidade_UF, e.Row.Index)),
                                            DBParametro_Montar("NO_CIDADE", Trim(objGrid_Valor(grdListagem, const_GridCidade_NomeCidade, e.Row.Index))),
                                            DBParametro_Montar("CD_IBGE", objGrid_Valor(grdListagem, const_GridCidade_CodigoIBGE, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CIDADE", FNC_GerarArray("ID_UF", "@ID_UF",
                                                                 "NO_CIDADE", "@NO_CIDADE",
                                                                 "CD_IBGE", "@CD_IBGE"),
                                                  FNC_GerarArray("SQ_CIDADE", "@SQ_CIDADE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_UF", objGrid_Valor(grdListagem, const_GridCidade_UF, e.Row.Index)),
                                            DBParametro_Montar("NO_CIDADE", Trim(objGrid_Valor(grdListagem, const_GridCidade_NomeCidade, e.Row.Index))),
                                            DBParametro_Montar("CD_IBGE", Trim(objGrid_Valor(grdListagem, const_GridCidade_CodigoIBGE, e.Row.Index))),
                                            DBParametro_Montar("SQ_CIDADE", objGrid_Valor(grdListagem, const_GridCidade_SQ_CIDADE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroUF
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridUF_SQ_UF, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_UF", TipoCampoFixo.DadoCriacao, "ID_PAIS", "@ID_PAIS",
                                                                         "NO_UF", "@NO_UF",
                                                                         "CD_UF", "@CD_UF")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_PAIS", objGrid_Valor(grdListagem, const_GridUF_Pais, e.Row.Index)),
                                            DBParametro_Montar("NO_UF", Trim(objGrid_Valor(grdListagem, const_GridUF_NomeUF, e.Row.Index))),
                                            DBParametro_Montar("CD_UF", Trim(objGrid_Valor(grdListagem, const_GridUF_CodigoUF, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_UF", FNC_GerarArray("ID_PAIS", "@ID_PAIS",
                                                             "NO_UF", "@NO_UF",
                                                             "CD_UF", "@CD_UF"),
                                              FNC_GerarArray("SQ_UF", "@SQ_UF"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_PAIS", objGrid_Valor(grdListagem, const_GridUF_Pais, e.Row.Index)),
                                            DBParametro_Montar("NO_UF", Trim(objGrid_Valor(grdListagem, const_GridUF_NomeUF, e.Row.Index))),
                                            DBParametro_Montar("CD_UF", Trim(objGrid_Valor(grdListagem, const_GridUF_CodigoUF, e.Row.Index))),
                                            DBParametro_Montar("SQ_UF", objGrid_Valor(grdListagem, const_GridUF_SQ_UF, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroPais
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridPais_SQ_PAIS, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_PAIS", TipoCampoFixo.DadoCriacao, "NO_PAIS", "@NO_PAIS",
                                                                           "NO_NACIONALIDADE", "@NO_NACIONALIDADE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_PAIS", objGrid_Valor(grdListagem, const_GridPais_NomePais, e.Row.Index)),
                                            DBParametro_Montar("NO_NACIONALIDADE", Trim(objGrid_Valor(grdListagem, const_GridPais_NomeNascionalidade, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_PAIS", FNC_GerarArray("NO_PAIS", "@NO_PAIS",
                                                               "NO_NACIONALIDADE", "@NO_NACIONALIDADE"),
                                                FNC_GerarArray("SQ_PAIS", "@SQ_PAIS"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_PAIS", objGrid_Valor(grdListagem, const_GridPais_NomePais, e.Row.Index)),
                                            DBParametro_Montar("NO_NACIONALIDADE", Trim(objGrid_Valor(grdListagem, const_GridPais_NomeNascionalidade, e.Row.Index))),
                                            DBParametro_Montar("SQ_PAIS", objGrid_Valor(grdListagem, const_GridPais_SQ_PAIS, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridConvenio_SQ_CONVENIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_GRUPOPRODUTO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                                   "NO_GRUPOPRODUTO", "@NO_GRUPOPRODUTO",
                                                                                   "ID_CST_PADRAO", "@ID_CST_PADRAO",
                                                                                   "ID_CSOSN_PADRAO", "@ID_CSOSN_PADRAO",
                                                                                   "ID_CST_COFINS_PADRAO", "@ID_CST_COFINS_PADRAO",
                                                                                   "ID_CST_IPI_PADRAO", "@ID_CST_IPI_PADRAO",
                                                                                   "ID_CST_PIS_PADRAO", "@ID_CST_PIS_PADRAO",
                                                                                   "IC_CONTROLA_ESTOQUE", "@IC_CONTROLA_ESTOQUE",
                                                                                   "IC_CONTROLA_NUMERO_SERIE", "@IC_CONTROLA_NUMERO_SERIE",
                                                                                   "IC_CONTROLE_GARANTIA", "@IC_CONTROLE_GARANTIA",
                                                                                   "ID_TRANSACAOESTOQUE_PADRAO_COMPRAS", "@ID_TRANSACAOESTOQUE_PADRAO_COMPRAS",
                                                                                   "ID_TRANSACAOESTOQUE_PADRAO_VENDAS", "@ID_TRANSACAOESTOQUE_PADRAO_VENDAS",
                                                                                   "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("NO_GRUPOPRODUTO", objGrid_Valor(grdListagem, const_GridGrupoProduto_NomeGrupoProduto, e.Row.Index)),
                                            DBParametro_Montar("ID_CST_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_Padrao, e.Row.Index)),
                                            DBParametro_Montar("ID_CSOSN_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CSOSN_Padrao, e.Row.Index)),
                                            DBParametro_Montar("ID_CST_COFINS_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_Cofins_Padrao, e.Row.Index)),
                                            DBParametro_Montar("ID_CST_IPI_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_IPI_Padrao, e.Row.Index)),
                                            DBParametro_Montar("ID_CST_PIS_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_PIS_Padrao, e.Row.Index)),
                                            DBParametro_Montar("IC_CONTROLA_ESTOQUE", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaEstoque, e.Row.Index)),
                                            DBParametro_Montar("IC_CONTROLA_NUMERO_SERIE", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaNumeroSerie, e.Row.Index)),
                                            DBParametro_Montar("IC_CONTROLE_GARANTIA", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaGarantia, e.Row.Index)),
                                            DBParametro_Montar("ID_TRANSACAOESTOQUE_PADRAO_COMPRAS", objGrid_Valor(grdListagem, const_GridGrupoProduto_TransacaoEstoque_Padrao_Compras, e.Row.Index)),
                                            DBParametro_Montar("ID_TRANSACAOESTOQUE_PADRAO_VENDAS", objGrid_Valor(grdListagem, const_GridGrupoProduto_TransacaoEstoque_Padrao_Vendas, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_GRUPOPRODUTO", FNC_GerarArray("NO_GRUPOPRODUTO", "@NO_GRUPOPRODUTO",
                                                                       "ID_CST_PADRAO", "@ID_CST_PADRAO",
                                                                       "ID_CSOSN_PADRAO", "@ID_CSOSN_PADRAO",
                                                                       "ID_CST_COFINS_PADRAO", "@ID_CST_COFINS_PADRAO",
                                                                       "ID_CST_IPI_PADRAO", "@ID_CST_IPI_PADRAO",
                                                                       "ID_CST_PIS_PADRAO", "@ID_CST_PIS_PADRAO",
                                                                       "IC_CONTROLA_ESTOQUE", "@IC_CONTROLA_ESTOQUE",
                                                                       "IC_CONTROLA_NUMERO_SERIE", "@IC_CONTROLA_NUMERO_SERIE",
                                                                       "IC_CONTROLE_GARANTIA", "@IC_CONTROLE_GARANTIA",
                                                                       "ID_TRANSACAOESTOQUE_PADRAO_COMPRAS", "@ID_TRANSACAOESTOQUE_PADRAO_COMPRAS",
                                                                       "ID_TRANSACAOESTOQUE_PADRAO_VENDAS", "@ID_TRANSACAOESTOQUE_PADRAO_VENDAS",
                                                                       "IC_ATIVO", "@IC_ATIVO"),
                                                        FNC_GerarArray("SQ_GRUPOPRODUTO", "@SQ_GRUPOPRODUTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_GRUPOPRODUTO", objGrid_Valor(grdListagem, const_GridGrupoProduto_NomeGrupoProduto, e.Row.Index)),
                                            DBParametro_Montar("ID_CST_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_Padrao, e.Row.Index)),
                                            DBParametro_Montar("ID_CSOSN_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CSOSN_Padrao, e.Row.Index)),
                                            DBParametro_Montar("ID_CST_COFINS_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_Cofins_Padrao, e.Row.Index)),
                                            DBParametro_Montar("ID_CST_IPI_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_IPI_Padrao, e.Row.Index)),
                                            DBParametro_Montar("ID_CST_PIS_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_PIS_Padrao, e.Row.Index)),
                                            DBParametro_Montar("IC_CONTROLA_ESTOQUE", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaEstoque, e.Row.Index)),
                                            DBParametro_Montar("IC_CONTROLA_NUMERO_SERIE", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaNumeroSerie, e.Row.Index)),
                                            DBParametro_Montar("IC_CONTROLE_GARANTIA", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaGarantia, e.Row.Index)),
                                            DBParametro_Montar("ID_TRANSACAOESTOQUE_PADRAO_COMPRAS", objGrid_Valor(grdListagem, const_GridGrupoProduto_TransacaoEstoque_Padrao_Compras, e.Row.Index)),
                                            DBParametro_Montar("ID_TRANSACAOESTOQUE_PADRAO_VENDAS", objGrid_Valor(grdListagem, const_GridGrupoProduto_TransacaoEstoque_Padrao_Vendas, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_GRUPOPRODUTO", objGrid_Valor(grdListagem, const_GridGrupoProduto_SQ_GRUPOPRODUTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroUnidadeMedida
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridUnidadeMedida_SQ_UNIDADEMEDIDA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_UNIDADEMEDIDA", TipoCampoFixo.DadoCriacao, "NO_UNIDADEMEDIDA", "@NO_UNIDADEMEDIDA",
                                                                                    "CD_UNIDADEMEDIDA", "@CD_UNIDADEMEDIDA",
                                                                                    "CD_UNIDADEMEDIDA_COMPATIVEL", "@CD_UNIDADEMEDIDA_COMPATIVEL")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_NomeUnidadeMedida, e.Row.Index)),
                                            DBParametro_Montar("CD_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_CodigoUnidadeMedida, e.Row.Index)),
                                            DBParametro_Montar("CD_UNIDADEMEDIDA_COMPATIVEL", objGrid_Valor(grdListagem, const_GridUnidadeMedida_CodigoUnidadeMedidaCompativel, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_UNIDADEMEDIDA", FNC_GerarArray("NO_UNIDADEMEDIDA", "@NO_UNIDADEMEDIDA",
                                                                        "CD_UNIDADEMEDIDA", "@CD_UNIDADEMEDIDA",
                                                                        "CD_UNIDADEMEDIDA_COMPATIVEL", "@CD_UNIDADEMEDIDA_COMPATIVEL"),
                                                         FNC_GerarArray("SQ_UNIDADEMEDIDA", "@SQ_UNIDADEMEDIDA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_NomeUnidadeMedida, e.Row.Index)),
                                            DBParametro_Montar("CD_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_CodigoUnidadeMedida, e.Row.Index)),
                                            DBParametro_Montar("CD_UNIDADEMEDIDA_COMPATIVEL", objGrid_Valor(grdListagem, const_GridUnidadeMedida_CodigoUnidadeMedidaCompativel, e.Row.Index)),
                                            DBParametro_Montar("SQ_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_SQ_UNIDADEMEDIDA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridEspecialidade_SQ_ESPECIALIDADE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_ESPECIALIDADE", TipoCampoFixo.DadoCriacao, "NO_ESPECIALIDADE", "@NO_ESPECIALIDADE",
                                                                                    "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_ESPECIALIDADE", objGrid_Valor(grdListagem, const_GridEspecialidade_NomeEspecialidade, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridEspecialidade_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_ESPECIALIDADE", FNC_GerarArray("NO_ESPECIALIDADE", "@NO_ESPECIALIDADE",
                                                                        "IC_ATIVO", "@IC_ATIVO"),
                                                         FNC_GerarArray("SQ_ESPECIALIDADE", "@SQ_ESPECIALIDADE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_ESPECIALIDADE", objGrid_Valor(grdListagem, const_GridEspecialidade_NomeEspecialidade, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridEspecialidade_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_ESPECIALIDADE", objGrid_Valor(grdListagem, const_GridEspecialidade_SQ_ESPECIALIDADE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroBanco
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridBanco_SQ_BANCO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_BANCO", TipoCampoFixo.DadoCriacao, "NO_BANCO", "@NO_BANCO",
                                                                            "NR_BANCO", "@NR_BANCO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_BANCO", objGrid_Valor(grdListagem, const_GridBanco_NomeBanco, e.Row.Index)),
                                            DBParametro_Montar("NR_BANCO", objGrid_Valor(grdListagem, const_GridBanco_NumeroBanco, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_BANCO", FNC_GerarArray("NO_BANCO", "@NO_BANCO",
                                                                "NR_BANCO", "@NR_BANCO"),
                                                 FNC_GerarArray("SQ_BANCO", "@SQ_BANCO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_BANCO", objGrid_Valor(grdListagem, const_GridBanco_NomeBanco, e.Row.Index)),
                                            DBParametro_Montar("NR_BANCO", objGrid_Valor(grdListagem, const_GridBanco_NumeroBanco, e.Row.Index)),
                                            DBParametro_Montar("SQ_BANCO", objGrid_Valor(grdListagem, const_GridBanco_SQ_BANCO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroContaBancaria
        Dim sNO_CONTAFINANCEIRA As String

        sNO_CONTAFINANCEIRA = Trim(e.Row.Cells(const_GridContaBancaria_Banco).Text) & "(" & e.Row.Cells(const_GridContaBancaria_NumeroAgencia).Text _
                                                                                    & " - " & e.Row.Cells(const_GridContaBancaria_NumeroConta).Text _
                                                                                    & "-" & e.Row.Cells(const_GridContaBancaria_DigitoConta).Text & ")"

        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridContaBancaria_SQ_CONTABANCARIA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CONTAFINANCEIRA", TipoCampoFixo.DadoCriacao, "ID_TIPO_CONTAFINANCEIRA", "@ID_TIPO_CONTAFINANCEIRA",
                                                                                      "ID_PESSOA", "@ID_PESSOA",
                                                                                      "ID_BANCO", "@ID_BANCO",
                                                                                      "NO_CONTAFINANCEIRA", "@NO_CONTAFINANCEIRA",
                                                                                      "NR_AGENCIA", "@NR_AGENCIA",
                                                                                      "NR_CONTA", "@NR_CONTA",
                                                                                      "NR_CONTA_DIGITO", "@NR_CONTA_DIGITO",
                                                                                      "DT_ABERTURA", "@DT_ABERTURA",
                                                                                      "ID_EMPRESA", "@ID_EMPRESA",
                                                                                      "IC_CONTROLASALDO", "@IC_CONTROLASALDO",
                                                                                      "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_TIPO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaBancaria_TipoConta, e.Row.Index)),
                                            DBParametro_Montar("ID_PESSOA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("ID_BANCO", objGrid_Valor(grdListagem, const_GridContaBancaria_Banco, e.Row.Index)),
                                            DBParametro_Montar("NO_CONTAFINANCEIRA", sNO_CONTAFINANCEIRA),
                                            DBParametro_Montar("NR_AGENCIA", objGrid_Valor(grdListagem, const_GridContaBancaria_NumeroAgencia, e.Row.Index)),
                                            DBParametro_Montar("NR_CONTA", objGrid_Valor(grdListagem, const_GridContaBancaria_NumeroConta, e.Row.Index)),
                                            DBParametro_Montar("NR_CONTA_DIGITO", objGrid_Valor(grdListagem, const_GridContaBancaria_DigitoConta, e.Row.Index)),
                                            DBParametro_Montar("DT_ABERTURA", objGrid_Valor(grdListagem, const_GridContaBancaria_DtAbetura, e.Row.Index)),
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("IC_CONTROLASALDO", objGrid_CheckCol_Valor(grdListagem, const_GridContaBancaria_ControlaSaldo, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridContaBancaria_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CONTAFINANCEIRA", FNC_GerarArray("ID_TIPO_CONTAFINANCEIRA", "@ID_TIPO_CONTAFINANCEIRA",
                                                                          "ID_BANCO", "@ID_BANCO",
                                                                          "NO_CONTAFINANCEIRA", "@NO_CONTAFINANCEIRA",
                                                                          "NR_AGENCIA", "@NR_AGENCIA",
                                                                          "NR_CONTA", "@NR_CONTA",
                                                                          "NR_CONTA_DIGITO", "@NR_CONTA_DIGITO",
                                                                          "DT_ABERTURA", "@DT_ABERTURA",
                                                                          "IC_CONTROLASALDO", "@IC_CONTROLASALDO",
                                                                          "IC_ATIVO", "@IC_ATIVO"),
                                                           FNC_GerarArray("SQ_CONTAFINANCEIRA", "@SQ_CONTAFINANCEIRA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_TIPO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaBancaria_TipoConta, e.Row.Index)),
                                            DBParametro_Montar("ID_BANCO", objGrid_Valor(grdListagem, const_GridContaBancaria_Banco, e.Row.Index)),
                                            DBParametro_Montar("NO_CONTAFINANCEIRA", sNO_CONTAFINANCEIRA),
                                            DBParametro_Montar("NR_AGENCIA", objGrid_Valor(grdListagem, const_GridContaBancaria_NumeroAgencia, e.Row.Index)),
                                            DBParametro_Montar("NR_CONTA", objGrid_Valor(grdListagem, const_GridContaBancaria_NumeroConta, e.Row.Index)),
                                            DBParametro_Montar("NR_CONTA_DIGITO", objGrid_Valor(grdListagem, const_GridContaBancaria_DigitoConta, e.Row.Index)),
                                            DBParametro_Montar("DT_ABERTURA", objGrid_Valor(grdListagem, const_GridContaBancaria_DtAbetura, e.Row.Index)),
                                            DBParametro_Montar("IC_CONTROLASALDO", objGrid_CheckCol_Valor(grdListagem, const_GridContaBancaria_ControlaSaldo, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridContaBancaria_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaBancaria_SQ_CONTABANCARIA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridContaCaixa_SQ_CONTACAIXA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CONTAFINANCEIRA", TipoCampoFixo.DadoCriacao, "ID_TIPO_CONTAFINANCEIRA", "@ID_TIPO_CONTAFINANCEIRA",
                                                                                      "ID_DEPARTAMENTO_RESPONSAVEL", "@ID_DEPARTAMENTO_RESPONSAVEL",
                                                                                      "ID_PESSOA", "@ID_PESSOA",
                                                                                      "ID_PESSOA_SUPERVISAO", "@ID_PESSOA_SUPERVISAO",
                                                                                      "NO_CONTAFINANCEIRA", "@NO_CONTAFINANCEIRA",
                                                                                      "ID_EMPRESA", "@ID_EMPRESA",
                                                                                      "IC_CONTROLASALDO", "@IC_CONTROLASALDO",
                                                                                      "PC_DESCONTO_MAXIMO", "@PC_DESCONTO_MAXIMO",
                                                                                      "DS_LOCALIZACAO", "@DS_LOCALIZACAO",
                                                                                      "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_TIPO_CONTAFINANCEIRA", 1),
                                            DBParametro_Montar("ID_DEPARTAMENTO_RESPONSAVEL", objGrid_Valor(grdListagem, const_GridContaCaixa_Departamento, e.Row.Index)),
                                            DBParametro_Montar("ID_PESSOA", objGrid_Valor(grdListagem, const_GridContaCaixa_Funcionario, e.Row.Index)),
                                            DBParametro_Montar("ID_PESSOA_SUPERVISAO", objGrid_Valor(grdListagem, const_GridContaCaixa_FuncionarioSupervisao, e.Row.Index)),
                                            DBParametro_Montar("NO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaCaixa_NomeCaixa, e.Row.Index)),
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("IC_CONTROLASALDO", objGrid_CheckCol_Valor(grdListagem, const_GridContaCaixa_ControlaSaldo, e.Row.Index)),
                                            DBParametro_Montar("PC_DESCONTO_MAXIMO", objGrid_Valor(grdListagem, const_GridContaCaixa_DescontoMaximo, e.Row.Index)),
                                            DBParametro_Montar("DS_LOCALIZACAO", objGrid_Valor(grdListagem, const_GridContaCaixa_Localizacao, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridContaCaixa_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CONTAFINANCEIRA", FNC_GerarArray("ID_DEPARTAMENTO_RESPONSAVEL", "@ID_DEPARTAMENTO_RESPONSAVEL",
                                                                          "ID_PESSOA", "@ID_PESSOA",
                                                                          "ID_PESSOA_SUPERVISAO", "@ID_PESSOA_SUPERVISAO",
                                                                          "NO_CONTAFINANCEIRA", "@NO_CONTAFINANCEIRA",
                                                                          "IC_CONTROLASALDO", "@IC_CONTROLASALDO",
                                                                          "PC_DESCONTO_MAXIMO", "@PC_DESCONTO_MAXIMO",
                                                                          "DS_LOCALIZACAO", "@DS_LOCALIZACAO",
                                                                          "IC_ATIVO", "@IC_ATIVO"),
                                                           FNC_GerarArray("SQ_CONTAFINANCEIRA", "@SQ_CONTAFINANCEIRA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_DEPARTAMENTO_RESPONSAVEL", objGrid_Valor(grdListagem, const_GridContaCaixa_Departamento, e.Row.Index)),
                                            DBParametro_Montar("ID_PESSOA", objGrid_Valor(grdListagem, const_GridContaCaixa_Funcionario, e.Row.Index)),
                                            DBParametro_Montar("ID_PESSOA_SUPERVISAO", objGrid_Valor(grdListagem, const_GridContaCaixa_FuncionarioSupervisao, e.Row.Index)),
                                            DBParametro_Montar("NO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaCaixa_NomeCaixa, e.Row.Index)),
                                            DBParametro_Montar("IC_CONTROLASALDO", objGrid_CheckCol_Valor(grdListagem, const_GridContaCaixa_ControlaSaldo, e.Row.Index)),
                                            DBParametro_Montar("PC_DESCONTO_MAXIMO", objGrid_Valor(grdListagem, const_GridContaCaixa_DescontoMaximo, e.Row.Index)),
                                            DBParametro_Montar("DS_LOCALIZACAO", objGrid_Valor(grdListagem, const_GridContaCaixa_Localizacao, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridContaCaixa_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaCaixa_SQ_CONTACAIXA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroCaixaAtendimento
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridContaCaixa_SQ_CONTACAIXA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CAIXA_ATENDIMENTO", TipoCampoFixo.DadoCriacao, "NO_CAIXA_ATENDIMENTO", "@NO_CAIXA_ATENDIMENTO",
                                                                                        "ID_EMPRESA", "@ID_EMPRESA",
                                                                                        "DS_LOCALIZACAO", "@DS_LOCALIZACAO",
                                                                                        "IC_USA_SISTEMACHAMADA", "@IC_USA_SISTEMACHAMADA",
                                                                                        "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CAIXA_ATENDIMENTO", objGrid_Valor(grdListagem, const_GridCaixaAtendimento_NO_CAIXA_ATENDIMENTO, e.Row.Index)),
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("DS_LOCALIZACAO", objGrid_Valor(grdListagem, const_GridCaixaAtendimento_Localizacao, e.Row.Index)),
                                            DBParametro_Montar("IC_USA_SISTEMACHAMADA", objGrid_CheckCol_Valor(grdListagem, const_GridCaixaAtendimento_UsaSistemaChamada, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridCaixaAtendimento_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CAIXA_ATENDIMENTO", FNC_GerarArray("NO_CAIXA_ATENDIMENTO", "@NO_CAIXA_ATENDIMENTO",
                                                                            "ID_EMPRESA", "@ID_EMPRESA",
                                                                            "DS_LOCALIZACAO", "@DS_LOCALIZACAO",
                                                                            "IC_USA_SISTEMACHAMADA", "@IC_USA_SISTEMACHAMADA",
                                                                            "IC_ATIVO", "@IC_ATIVO"),
                                                             FNC_GerarArray("SQ_CAIXA_ATENDIMENTO", "@SQ_CAIXA_ATENDIMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CAIXA_ATENDIMENTO", objGrid_Valor(grdListagem, const_GridCaixaAtendimento_NO_CAIXA_ATENDIMENTO, e.Row.Index)),
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("DS_LOCALIZACAO", objGrid_Valor(grdListagem, const_GridCaixaAtendimento_Localizacao, e.Row.Index)),
                                            DBParametro_Montar("IC_USA_SISTEMACHAMADA", objGrid_CheckCol_Valor(grdListagem, const_GridCaixaAtendimento_UsaSistemaChamada, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridCaixaAtendimento_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_CAIXA_ATENDIMENTO", objGrid_Valor(grdListagem, const_GridCaixaAtendimento_SQ_CAIXA_ATENDIMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridFormaPagamento_SQ_FORMAPAGAMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_FORMAPAGAMENTO", TipoCampoFixo.DadoCriacao, "NO_FORMAPAGAMENTO", "@NO_FORMAPAGAMENTO",
                                                                                     "ID_TIPO_DOCUMENTO", "@ID_TIPO_DOCUMENTO",
                                                                                     "ID_OPT_DOCUMENTOCADASTRADO", "@ID_OPT_DOCUMENTOCADASTRADO",
                                                                                     "ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO", "@ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO",
                                                                                     "ID_CONTAFINANCEIRA_QUITACAO", "@ID_CONTAFINANCEIRA_QUITACAO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_FORMAPAGAMENTO", Trim(objGrid_Valor(grdListagem, const_GridFormaPagamento_NomeFormaPagamento, e.Row.Index))),
                                            DBParametro_Montar("ID_TIPO_DOCUMENTO", objGrid_Valor(grdListagem, const_GridFormaPagamento_TipoDocumento, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_DOCUMENTOCADASTRADO", objGrid_Valor(grdListagem, const_GridFormaPagamento_TipoDocumentoFinanceiroCadastrado, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO", objGrid_Valor(grdListagem, const_GridFormaPagamento_ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO, e.Row.Index)),
                                            DBParametro_Montar("ID_CONTAFINANCEIRA_QUITACAO", objGrid_Valor(grdListagem, const_GridFormaPagamento_ID_CONTAFINANCEIRA_QUITACAO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_FORMAPAGAMENTO", FNC_GerarArray("NO_FORMAPAGAMENTO", "@NO_FORMAPAGAMENTO",
                                                                         "ID_TIPO_DOCUMENTO", "@ID_TIPO_DOCUMENTO",
                                                                         "ID_OPT_DOCUMENTOCADASTRADO", "@ID_OPT_DOCUMENTOCADASTRADO",
                                                                         "ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO", "@ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO",
                                                                         "ID_CONTAFINANCEIRA_QUITACAO", "@ID_CONTAFINANCEIRA_QUITACAO"),
                                                          FNC_GerarArray("SQ_FORMAPAGAMENTO", "@SQ_FORMAPAGAMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_FORMAPAGAMENTO", Trim(objGrid_Valor(grdListagem, const_GridFormaPagamento_NomeFormaPagamento, e.Row.Index))),
                                            DBParametro_Montar("ID_TIPO_DOCUMENTO", objGrid_Valor(grdListagem, const_GridFormaPagamento_TipoDocumento, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_DOCUMENTOCADASTRADO", objGrid_Valor(grdListagem, const_GridFormaPagamento_TipoDocumentoFinanceiroCadastrado, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO", objGrid_Valor(grdListagem, const_GridFormaPagamento_ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO, e.Row.Index)),
                                            DBParametro_Montar("ID_CONTAFINANCEIRA_QUITACAO", objGrid_Valor(grdListagem, const_GridFormaPagamento_ID_CONTAFINANCEIRA_QUITACAO, e.Row.Index)),
                                            DBParametro_Montar("SQ_FORMAPAGAMENTO", objGrid_Valor(grdListagem, const_GridFormaPagamento_SQ_FORMAPAGAMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoCargo_SQ_TIPO_CARGO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CARGO", TipoCampoFixo.DadoCriacao, "NO_TIPO_CARGO", "@NO_TIPO_CARGO",
                                                                                 "ID_OPT_TIPOFUNCAO", "@ID_OPT_TIPOFUNCAO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CARGO", Trim(objGrid_Valor(grdListagem, const_GridTipoCargo_NomeTipoCargo, e.Row.Index))),
                                            DBParametro_Montar("ID_OPT_TIPOFUNCAO", objGrid_Valor(grdListagem, const_GridTipoCargo_TipoFuncao, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CARGO", FNC_GerarArray("NO_TIPO_CARGO", "@NO_TIPO_CARGO",
                                                                     "ID_OPT_TIPOFUNCAO", "@ID_OPT_TIPOFUNCAO"),
                                                      FNC_GerarArray("SQ_TIPO_CARGO", "@SQ_TIPO_CARGO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CARGO", Trim(objGrid_Valor(grdListagem, const_GridTipoCargo_NomeTipoCargo, e.Row.Index))),
                                            DBParametro_Montar("ID_OPT_TIPOFUNCAO", objGrid_Valor(grdListagem, const_GridTipoCargo_TipoFuncao, e.Row.Index)),
                                            DBParametro_Montar("SQ_TIPO_CARGO", objGrid_Valor(grdListagem, const_GridTipoCargo_SQ_TIPO_CARGO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoContato
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoContato_SQ_TIPO_CONTATO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CONTATO", TipoCampoFixo.DadoCriacao, "NO_TIPO_CONTATO", "@NO_TIPO_CONTATO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONTATO", Trim(objGrid_Valor(grdListagem, const_GridTipoCargo_NomeTipoCargo, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CONTATO", FNC_GerarArray("NO_TIPO_CONTATO", "@NO_TIPO_CONTATO"),
                                                        FNC_GerarArray("SQ_TIPO_CONTATO", "@SQ_TIPO_CONTATO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONTATO", Trim(objGrid_Valor(grdListagem, const_GridTipoCargo_NomeTipoCargo, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_CONTATO", objGrid_Valor(grdListagem, const_GridTipoContato_SQ_TIPO_CONTATO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoDocumento
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoDocumento_SQ_TIPO_DOCUMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_DOCUMENTO", TipoCampoFixo.DadoCriacao, "NO_TIPO_DOCUMENTO", "@NO_TIPO_DOCUMENTO",
                                                                                     "ID_OPT_INSTITUICAO_GERADORA", "@ID_OPT_INSTITUICAO_GERADORA",
                                                                                     "ID_OPT_UTILIZACAOFINANCEIRO", "@ID_OPT_UTILIZACAOFINANCEIRO",
                                                                                     "IC_COMPENSAR", "@IC_COMPENSAR",
                                                                                     "IC_CADASTRAR_DOCUMENTO", "@IC_CADASTRAR_DOCUMENTO",
                                                                                     "IC_CADASTRAR_CONTABANCARIA", "@IC_CADASTRAR_CONTABANCARIA",
                                                                                     "IC_QUITAR_AUTOMATICAMENTE", "@IC_QUITAR_AUTOMATICAMENTE",
                                                                                     "IC_ATIVO", "@IC_ATIVO",
                                                                                     "IC_FLUXOCAIXA", "@IC_FLUXOCAIXA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_DOCUMENTO", Trim(objGrid_Valor(grdListagem, const_GridTipoDocumento_NomeTipoDocumento, e.Row.Index))),
                                            DBParametro_Montar("ID_OPT_INSTITUICAO_GERADORA", objGrid_Valor(grdListagem, const_GridTipoDocumento_ID_OPT_INSTITUICAO_GERADORA, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_UTILIZACAOFINANCEIRO", objGrid_Valor(grdListagem, const_GridTipoDocumento_ID_OPT_UTILIZACAOFINANCEIRO, e.Row.Index)),
                                            DBParametro_Montar("IC_COMPENSAR", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_COMPENSAR, e.Row.Index)),
                                            DBParametro_Montar("IC_CADASTRAR_DOCUMENTO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_CADASTRAR_DOCUMENTO, e.Row.Index)),
                                            DBParametro_Montar("IC_CADASTRAR_CONTABANCARIA", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_CADASTRAR_CONTABANCARIA, e.Row.Index)),
                                            DBParametro_Montar("IC_QUITAR_AUTOMATICAMENTE", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_QUITAR_AUTOMATICAMENTE, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("IC_FLUXOCAIXA", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_FLUXOCAIXA, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_DOCUMENTO", FNC_GerarArray("NO_TIPO_DOCUMENTO", "@NO_TIPO_DOCUMENTO",
                                                                         "ID_OPT_INSTITUICAO_GERADORA", "@ID_OPT_INSTITUICAO_GERADORA",
                                                                         "ID_OPT_UTILIZACAOFINANCEIRO", "@ID_OPT_UTILIZACAOFINANCEIRO",
                                                                         "IC_COMPENSAR", "@IC_COMPENSAR",
                                                                         "IC_CADASTRAR_DOCUMENTO", "@IC_CADASTRAR_DOCUMENTO",
                                                                         "IC_CADASTRAR_CONTABANCARIA", "@IC_CADASTRAR_CONTABANCARIA",
                                                                         "IC_QUITAR_AUTOMATICAMENTE", "@IC_QUITAR_AUTOMATICAMENTE",
                                                                         "IC_ATIVO", "@IC_ATIVO",
                                                                         "IC_FLUXOCAIXA", "@IC_FLUXOCAIXA"),
                                                          FNC_GerarArray("SQ_TIPO_DOCUMENTO", "@SQ_TIPO_DOCUMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_DOCUMENTO", Trim(objGrid_Valor(grdListagem, const_GridTipoDocumento_NomeTipoDocumento, e.Row.Index))),
                                            DBParametro_Montar("ID_OPT_INSTITUICAO_GERADORA", objGrid_Valor(grdListagem, const_GridTipoDocumento_ID_OPT_INSTITUICAO_GERADORA, e.Row.Index)),
                                            DBParametro_Montar("ID_OPT_UTILIZACAOFINANCEIRO", objGrid_Valor(grdListagem, const_GridTipoDocumento_ID_OPT_UTILIZACAOFINANCEIRO, e.Row.Index)),
                                            DBParametro_Montar("IC_COMPENSAR", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_COMPENSAR, e.Row.Index)),
                                            DBParametro_Montar("IC_CADASTRAR_DOCUMENTO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_CADASTRAR_DOCUMENTO, e.Row.Index)),
                                            DBParametro_Montar("IC_CADASTRAR_CONTABANCARIA", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_CADASTRAR_CONTABANCARIA, e.Row.Index)),
                                            DBParametro_Montar("IC_QUITAR_AUTOMATICAMENTE", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_QUITAR_AUTOMATICAMENTE, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("IC_FLUXOCAIXA", objGrid_CheckCol_Valor(grdListagem, const_GridTipoDocumento_IC_FLUXOCAIXA, e.Row.Index)),
                                            DBParametro_Montar("SQ_TIPO_DOCUMENTO", objGrid_Valor(grdListagem, const_GridTipoDocumento_SQ_TIPO_DOCUMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoEndereco_SQ_TIPO_ENDERECO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_ENDERECO", TipoCampoFixo.DadoCriacao, "NO_TIPO_ENDERECO", "@NO_TIPO_ENDERECO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ENDERECO", Trim(objGrid_Valor(grdListagem, const_GridTipoEndereco_NomeTipoEndereco, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_ENDERECO", FNC_GerarArray("NO_TIPO_ENDERECO", "@NO_TIPO_ENDERECO"),
                                                         FNC_GerarArray("SQ_TIPO_ENDERECO", "@SQ_TIPO_ENDERECO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ENDERECO", Trim(objGrid_Valor(grdListagem, const_GridTipoEndereco_NomeTipoEndereco, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_ENDERECO", objGrid_Valor(grdListagem, const_GridTipoEndereco_SQ_TIPO_ENDERECO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEscolaridade
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_ESCOLARIDADE", TipoCampoFixo.DadoCriacao, "NO_TIPO_ESCOLARIDADE", "@NO_TIPO_ESCOLARIDADE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ESCOLARIDADE", Trim(objGrid_Valor(grdListagem, const_GridTipoEndereco_NomeTipoEndereco, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_ESCOLARIDADE", FNC_GerarArray("NO_TIPO_ESCOLARIDADE", "@NO_TIPO_ESCOLARIDADE"),
                                                             FNC_GerarArray("SQ_TIPO_ESCOLARIDADE", "@SQ_TIPO_ESCOLARIDADE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ESCOLARIDADE", Trim(objGrid_Valor(grdListagem, const_GridTipoEscolaridade_NomeTipoEscolaridade, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_ESCOLARIDADE", objGrid_Valor(grdListagem, const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEstadoCivil
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_ESTADOCIVIL", TipoCampoFixo.DadoCriacao, "NO_TIPO_ESTADOCIVIL", "@NO_TIPO_ESTADOCIVIL")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ESTADOCIVIL", Trim(objGrid_Valor(grdListagem, const_GridTipoEstadoCivil_NomeEstadoCivil, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_ESTADOCIVIL", FNC_GerarArray("NO_TIPO_ESTADOCIVIL", "@NO_TIPO_ESTADOCIVIL"),
                                                            FNC_GerarArray("SQ_TIPO_ESTADOCIVIL", "@SQ_TIPO_ESTADOCIVIL"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ESTADOCIVIL", Trim(objGrid_Valor(grdListagem, const_GridTipoEstadoCivil_NomeEstadoCivil, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_ESTADOCIVIL", objGrid_Valor(grdListagem, const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_MIDIASOCIAL", TipoCampoFixo.DadoCriacao, "NO_TIPO_MIDIASOCIAL", "@NO_TIPO_MIDIASOCIAL")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_MIDIASOCIAL", Trim(objGrid_Valor(grdListagem, const_GridTipoMidiaSocial_NomeMidiaSocial, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_MIDIASOCIAL", FNC_GerarArray("NO_TIPO_MIDIASOCIAL", "@NO_TIPO_MIDIASOCIAL"),
                                                            FNC_GerarArray("SQ_TIPO_MIDIASOCIAL", "@SQ_TIPO_MIDIASOCIAL"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_MIDIASOCIAL", Trim(objGrid_Valor(grdListagem, const_GridTipoMidiaSocial_NomeMidiaSocial, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_MIDIASOCIAL", objGrid_Valor(grdListagem, const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoPaciente
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoPaciente_SQ_TIPO_PACIENTE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_PACIENTE", TipoCampoFixo.DadoCriacao, "NO_TIPO_PACIENTE", "@NO_TIPO_PACIENTE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_PACIENTE", Trim(objGrid_Valor(grdListagem, const_GridTipoPaciente_NomeTipoPaciente, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_PACIENTE", FNC_GerarArray("NO_TIPO_PACIENTE", "@NO_TIPO_PACIENTE"),
                                                         FNC_GerarArray("SQ_TIPO_PACIENTE", "@SQ_TIPO_PACIENTE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_PACIENTE", Trim(objGrid_Valor(grdListagem, const_GridTipoPaciente_NomeTipoPaciente, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_PACIENTE", objGrid_Valor(grdListagem, const_GridTipoPaciente_SQ_TIPO_PACIENTE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoPessoa_SQ_TIPO_PESSOA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_PESSOA", TipoCampoFixo.DadoCriacao, "ID_OPT_FISICO_JURIDICO", "@ID_OPT_FISICO_JURIDICO",
                                                                                  "NO_TIPO_PESSOA", "@NO_TIPO_PESSOA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_OPT_FISICO_JURIDICO", objGrid_Valor(grdListagem, const_GridTipoPessoa_FisicoJuridico, e.Row.Index)),
                                            DBParametro_Montar("NO_TIPO_PESSOA", Trim(objGrid_Valor(grdListagem, const_GridTipoPessoa_NomeTipoPessoa, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_PESSOA", FNC_GerarArray("ID_OPT_FISICO_JURIDICO", "@ID_OPT_FISICO_JURIDICO",
                                                                      "NO_TIPO_PESSOA", "@NO_TIPO_PESSOA"),
                                                       FNC_GerarArray("SQ_TIPO_PESSOA", "@SQ_TIPO_PESSOA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_OPT_FISICO_JURIDICO", objGrid_Valor(grdListagem, const_GridTipoPessoa_FisicoJuridico, e.Row.Index)),
                                            DBParametro_Montar("NO_TIPO_PESSOA", Trim(objGrid_Valor(grdListagem, const_GridTipoPessoa_NomeTipoPessoa, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_PESSOA", objGrid_Valor(grdListagem, const_GridTipoPessoa_SQ_TIPO_PESSOA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoProduto
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoProduto_SQ_TIPO_PRODUTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_PRODUTO", TipoCampoFixo.DadoCriacao, "NO_TIPO_PRODUTO", "@NO_TIPO_PRODUTO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_PRODUTO", Trim(objGrid_Valor(grdListagem, const_GridTipoProduto_NomeTipoProduto, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_PRODUTO", FNC_GerarArray("NO_TIPO_PRODUTO", "@NO_TIPO_PRODUTO"),
                                                        FNC_GerarArray("SQ_TIPO_PRODUTO", "@SQ_TIPO_PRODUTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_PRODUTO", Trim(objGrid_Valor(grdListagem, const_GridTipoProduto_NomeTipoProduto, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_PRODUTO", objGrid_Valor(grdListagem, const_GridTipoProduto_SQ_TIPO_PRODUTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoQuestionario
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_QUESTIONARIO", TipoCampoFixo.DadoCriacao, "NO_TIPO_QUESTIONARIO", "@NO_TIPO_QUESTIONARIO",
                                                                                        "ID_OPT_TIPOCAMPO", "@ID_OPT_TIPOCAMPO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_QUESTIONARIO", Trim(objGrid_Valor(grdListagem, const_GridTipoQuestionario_NomeTipoQuestionario, e.Row.Index))),
                                            DBParametro_Montar("ID_OPT_TIPOCAMPO", objGrid_Valor(grdListagem, const_GridTipoQuestionario_TipoCampo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_QUESTIONARIO", FNC_GerarArray("NO_TIPO_QUESTIONARIO", "@NO_TIPO_QUESTIONARIO",
                                                                            "ID_OPT_TIPOCAMPO", "@ID_OPT_TIPOCAMPO"),
                                                             FNC_GerarArray("SQ_TIPO_QUESTIONARIO", "@SQ_TIPO_QUESTIONARIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_QUESTIONARIO", Trim(objGrid_Valor(grdListagem, const_GridTipoQuestionario_NomeTipoQuestionario, e.Row.Index))),
                                            DBParametro_Montar("ID_OPT_TIPOCAMPO", objGrid_Valor(grdListagem, const_GridTipoQuestionario_TipoCampo, e.Row.Index)),
                                            DBParametro_Montar("SQ_TIPO_QUESTIONARIO", objGrid_Valor(grdListagem, const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRaca
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoRaca_SQ_TIPO_RACA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_RACA", TipoCampoFixo.DadoCriacao, "NO_TIPO_RACA", "@NO_TIPO_RACA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RACA", Trim(objGrid_Valor(grdListagem, const_GridTipoRaca_NomeTipoRaca, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_RACA", FNC_GerarArray("NO_TIPO_RACA", "@NO_TIPO_RACA"),
                                                     FNC_GerarArray("SQ_TIPO_RACA", "@SQ_TIPO_RACA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RACA", Trim(objGrid_Valor(grdListagem, const_GridTipoRaca_NomeTipoRaca, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_RACA", objGrid_Valor(grdListagem, const_GridTipoRaca_SQ_TIPO_RACA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_REFERENCIAPESSOA", TipoCampoFixo.DadoCriacao, "NO_TIPO_REFERENCIAPESSOA", "@NO_TIPO_REFERENCIAPESSOA",
                                                                                            "ID_TIPO_PESSOA", "@ID_TIPO_PESSOA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_REFERENCIAPESSOA", Trim(objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa, e.Row.Index))),
                                            DBParametro_Montar("ID_TIPO_PESSOA", objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_TipoPessoa, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_REFERENCIAPESSOA", FNC_GerarArray("NO_TIPO_REFERENCIAPESSOA", "@NO_TIPO_REFERENCIAPESSOA",
                                                                                "ID_TIPO_PESSOA", "@ID_TIPO_PESSOA"),
                                                                 FNC_GerarArray("SQ_TIPO_REFERENCIAPESSOA", "@SQ_TIPO_REFERENCIAPESSOA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_REFERENCIAPESSOA", Trim(objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa, e.Row.Index))),
                                            DBParametro_Montar("ID_TIPO_PESSOA", objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_TipoPessoa, e.Row.Index)),
                                            DBParametro_Montar("SQ_TIPO_REFERENCIAPESSOA", objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoReligiao_SQ_TIPO_RELIGIAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_RELIGIAO", TipoCampoFixo.DadoCriacao, "NO_TIPO_RELIGIAO", "@NO_TIPO_RELIGIAO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RELIGIAO", Trim(objGrid_Valor(grdListagem, const_GridTipoReligiao_NomeTipoReligiao, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_RELIGIAO", FNC_GerarArray("NO_TIPO_RELIGIAO", "@NO_TIPO_RELIGIAO"),
                                                         FNC_GerarArray("SQ_TIPO_RELIGIAO", "@SQ_TIPO_RELIGIAO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RELIGIAO", Trim(objGrid_Valor(grdListagem, const_GridTipoReligiao_NomeTipoReligiao, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_RELIGIAO", objGrid_Valor(grdListagem, const_GridTipoReligiao_SQ_TIPO_RELIGIAO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoSexo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoSexo_SQ_TIPO_SEXO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_SEXO", TipoCampoFixo.DadoCriacao, "NO_TIPO_SEXO", "@NO_TIPO_SEXO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_SEXO", Trim(objGrid_Valor(grdListagem, const_GridTipoSexo_NomeTipoSexo, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_SEXO", FNC_GerarArray("NO_TIPO_SEXO", "@NO_TIPO_SEXO"),
                                                     FNC_GerarArray("SQ_TIPO_SEXO", "@SQ_TIPO_SEXO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_SEXO", Trim(objGrid_Valor(grdListagem, const_GridTipoSexo_NomeTipoSexo, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_SEXO", objGrid_Valor(grdListagem, const_GridTipoSexo_SQ_TIPO_SEXO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoTelefone
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoTelefone_SQ_TIPO_TELEFONE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_TELEFONE", TipoCampoFixo.DadoCriacao, "NO_TIPO_TELEFONE", "@NO_TIPO_TELEFONE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_TELEFONE", Trim(objGrid_Valor(grdListagem, const_GridTipoTelefone_NomeTipoTelefone, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_TELEFONE", FNC_GerarArray("NO_TIPO_TELEFONE", "@NO_TIPO_TELEFONE"),
                                                         FNC_GerarArray("SQ_TIPO_TELEFONE", "@SQ_TIPO_TELEFONE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_TELEFONE", Trim(objGrid_Valor(grdListagem, const_GridTipoTelefone_NomeTipoTelefone, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_TELEFONE", objGrid_Valor(grdListagem, const_GridTipoTelefone_SQ_TIPO_TELEFONE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroDepartamento
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridDepartamento_SQ_DEPARTAMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_DEPARTAMENTO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                                   "NO_DEPARTAMENTO", "@NO_DEPARTAMENTO",
                                                                                   "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("NO_DEPARTAMENTO", Trim(objGrid_Valor(grdListagem, const_GridDepartamento_NomeDepartamento, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridDepartamento_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_DEPARTAMENTO", FNC_GerarArray("ID_EMPRESA", "@ID_EMPRESA",
                                                                       "NO_DEPARTAMENTO", "@NO_DEPARTAMENTO",
                                                                       "IC_ATIVO", "@IC_ATIVO"),
                                                        FNC_GerarArray("SQ_DEPARTAMENTO", "@SQ_DEPARTAMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("NO_DEPARTAMENTO", Trim(objGrid_Valor(grdListagem, const_GridDepartamento_NomeDepartamento, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridDepartamento_Ativo, e.Row.Index)),
                                            DBParametro_Montar("SQ_DEPARTAMENTO", objGrid_Valor(grdListagem, const_GridDepartamento_SQ_DEPARTAMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoContaFinanceira
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CONTAFINANCEIRA", TipoCampoFixo.DadoCriacao, "NO_TIPO_CONTAFINANCEIRA", "@NO_TIPO_CONTAFINANCEIRA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONTAFINANCEIRA", Trim(objGrid_Valor(grdListagem, const_GridTipoContaFinanceira_NomeTipoContaBancaria, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CONTAFINANCEIRA", FNC_GerarArray("NO_TIPO_CONTAFINANCEIRA", "@NO_TIPO_CONTAFINANCEIRA"),
                                                                FNC_GerarArray("SQ_TIPO_CONTAFINANCEIRA", "@SQ_TIPO_CONTAFINANCEIRA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONTAFINANCEIRA", Trim(objGrid_Valor(grdListagem, const_GridTipoContaFinanceira_NomeTipoContaBancaria, e.Row.Index))),
                                            DBParametro_Montar("SQ_TIPO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoConsulta
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoConsulta_SQ_TIPO_CONSULTA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CONSULTA", TipoCampoFixo.DadoCriacao, "NO_TIPO_CONSULTA", "@NO_TIPO_CONSULTA",
                                                                                    "IC_ATIVO", "@IC_ATIVO",
                                                                                    "IC_TIPO_RETORNO", "@IC_TIPO_RETORNO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONSULTA", Trim(objGrid_Valor(grdListagem, const_GridTipoConsulta_NO_TIPO_CONSULTA, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoConsulta_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("IC_TIPO_RETORNO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoConsulta_IC_TIPO_RETORNO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CONSULTA", FNC_GerarArray("NO_TIPO_CONSULTA", "@NO_TIPO_CONSULTA",
                                                                        "IC_ATIVO", "@IC_ATIVO",
                                                                        "IC_TIPO_RETORNO", "@IC_TIPO_RETORNO"),
                                                         FNC_GerarArray("SQ_TIPO_CONSULTA", "@SQ_TIPO_CONSULTA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONSULTA", Trim(objGrid_Valor(grdListagem, const_GridTipoConsulta_NO_TIPO_CONSULTA, e.Row.Index))),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoConsulta_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("IC_TIPO_RETORNO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoConsulta_IC_TIPO_RETORNO, e.Row.Index)),
                                            DBParametro_Montar("SQ_TIPO_CONSULTA", objGrid_Valor(grdListagem, const_GridTipoConsulta_SQ_TIPO_CONSULTA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTransacaoEstoque
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoConsulta_SQ_TIPO_CONSULTA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TRANSACAOESTOQUE", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                                       "CD_TRANSACAOESTOQUE", "@CD_TRANSACAOESTOQUE",
                                                                                       "NO_TRANSACAOESTOQUE", "@NO_TRANSACAOESTOQUE",
                                                                                       "ID_ESTOQUE_CREDITO", "@ID_ESTOQUE_CREDITO",
                                                                                       "ID_ESTOQUE_DEBITO", "@ID_ESTOQUE_DEBITO",
                                                                                       "IC_USAR_RECEBIMENTO", "@IC_USAR_RECEBIMENTO",
                                                                                       "IC_USAR_VENDA", "@IC_USAR_VENDA",
                                                                                       "IC_USAR_MOVIMENTACAOMANUAL", "@IC_USAR_MOVIMENTACAOMANUAL",
                                                                                       "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("CD_TRANSACAOESTOQUE", Trim(objGrid_Valor(grdListagem, const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE, e.Row.Index))),
                                            DBParametro_Montar("NO_TRANSACAOESTOQUE", Trim(objGrid_Valor(grdListagem, const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE, e.Row.Index))),
                                            DBParametro_Montar("ID_ESTOQUE_CREDITO", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO, e.Row.Index)),
                                            DBParametro_Montar("ID_ESTOQUE_DEBITO", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO, e.Row.Index)),
                                            DBParametro_Montar("IC_USAR_RECEBIMENTO", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_RECEBIMENTO, e.Row.Index)),
                                            DBParametro_Montar("IC_USAR_VENDA", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_VENDA, e.Row.Index)),
                                            DBParametro_Montar("IC_USAR_MOVIMENTACAOMANUAL", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_MOVIMENTACAOMANUAL, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_ATIVO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TRANSACAOESTOQUE", FNC_GerarArray("ID_EMPRESA", "@ID_EMPRESA",
                                                                           "CD_TRANSACAOESTOQUE", "@CD_TRANSACAOESTOQUE",
                                                                           "NO_TRANSACAOESTOQUE", "@NO_TRANSACAOESTOQUE",
                                                                           "ID_ESTOQUE_CREDITO", "@ID_ESTOQUE_CREDITO",
                                                                           "ID_ESTOQUE_DEBITO", "@ID_ESTOQUE_DEBITO",
                                                                           "IC_USAR_RECEBIMENTO", "@IC_USAR_RECEBIMENTO",
                                                                           "IC_USAR_VENDA", "@IC_USAR_VENDA",
                                                                           "IC_USAR_MOVIMENTACAOMANUAL", "@IC_USAR_MOVIMENTACAOMANUAL",
                                                                           "IC_ATIVO", "@IC_ATIVO"),
                                                            FNC_GerarArray("SQ_TRANSACAOESTOQUE", "@SQ_TRANSACAOESTOQUE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("CD_TRANSACAOESTOQUE", Trim(objGrid_Valor(grdListagem, const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE, e.Row.Index))),
                                            DBParametro_Montar("NO_TRANSACAOESTOQUE", Trim(objGrid_Valor(grdListagem, const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE, e.Row.Index))),
                                            DBParametro_Montar("ID_ESTOQUE_CREDITO", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO, e.Row.Index)),
                                            DBParametro_Montar("ID_ESTOQUE_DEBITO", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO, e.Row.Index)),
                                            DBParametro_Montar("IC_USAR_RECEBIMENTO", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_RECEBIMENTO, e.Row.Index)),
                                            DBParametro_Montar("IC_USAR_VENDA", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_VENDA, e.Row.Index)),
                                            DBParametro_Montar("IC_USAR_MOVIMENTACAOMANUAL", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_MOVIMENTACAOMANUAL, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("SQ_TRANSACAOESTOQUE", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_SQ_TRANSACAOESTOQUE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroServico
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridServico_SQ_SERVICO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_SERVICO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA",
                                                                              "CD_SERVICO", "@CD_SERVICO",
                                                                              "NO_SERVICO", "@NO_SERVICO",
                                                                              "ID_TIPO_SERVICO", "@ID_TIPO_SERVICO",
                                                                              "IC_GERAFINANCEIRO", "@IC_GERAFINANCEIRO",
                                                                              "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("CD_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridServico_CD_SERVICO, e.Row.Index))),
                                            DBParametro_Montar("NO_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridServico_NO_SERVICO, e.Row.Index))),
                                            DBParametro_Montar("ID_TIPO_SERVICO", objGrid_Valor(grdListagem, const_GridServico_ID_TIPO_SERVICO, e.Row.Index)),
                                            DBParametro_Montar("IC_GERAFINANCEIRO", objGrid_CheckCol_Valor(grdListagem, const_GridServico_IC_GERAFINANCEIRO, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridServico_IC_ATIVO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_SERVICO", FNC_GerarArray("ID_EMPRESA", "@ID_EMPRESA",
                                                                  "CD_SERVICO", "@CD_SERVICO",
                                                                  "NO_SERVICO", "@NO_SERVICO",
                                                                  "ID_TIPO_SERVICO", "@ID_TIPO_SERVICO",
                                                                  "IC_GERAFINANCEIRO", "@IC_GERAFINANCEIRO",
                                                                  "IC_ATIVO", "@IC_ATIVO"),
                                                   FNC_GerarArray("SQ_SERVICO", "@SQ_SERVICO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                            DBParametro_Montar("CD_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridServico_CD_SERVICO, e.Row.Index))),
                                            DBParametro_Montar("NO_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridServico_NO_SERVICO, e.Row.Index))),
                                            DBParametro_Montar("ID_TIPO_SERVICO", objGrid_Valor(grdListagem, const_GridServico_ID_TIPO_SERVICO, e.Row.Index)),
                                            DBParametro_Montar("IC_GERAFINANCEIRO", objGrid_CheckCol_Valor(grdListagem, const_GridServico_IC_GERAFINANCEIRO, e.Row.Index)),
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridServico_IC_ATIVO, e.Row.Index)),
                                            DBParametro_Montar("SQ_SERVICO", objGrid_Valor(grdListagem, const_GridServico_SQ_SERVICO, e.Row.Index)))
        End If
    End Select

    If bPesquisar Then
      Pesquisar()
    End If
  End Sub

  Private Sub grdListagem_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdListagem.BeforeCellActivate
    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroTransacaoEstoque
        If e.Cell.Column.Index <> const_GridTransacaoEstoque_IC_ATIVO Then
          e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridTransacaoEstoque_IC_EM_USO).Value, "N") = "S")

          If e.Cancel Then
            FNC_Mensagem("Essa transação está em uso e por isso não pode ser alterada")
            Exit Sub
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroTipoDocumento
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridTipoDocumento_IC_SISTEMA).Value, "N") = "S")
      Case enListagemGeral_TipoTela.CadastroTipoContato
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridTipoContato_IC_SISTEMA).Value, "N") = "S")
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        If e.Cell.Column.Index <> const_GridContaCaixa_Ativo And e.Cell.Column.Index <> const_GridContaCaixa_ControlaSaldo And e.Cell.Column.Index <> const_GridContaCaixa_DescontoMaximo Then
          e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridContaCaixa_IC_SISTEMA).Value, "N") = "S")
        End If
      Case enListagemGeral_TipoTela.CadastroDepartamento
        If e.Cell.Column.Index <> const_GridDepartamento_Ativo Then
          e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridDepartamento_IC_SISTEMA).Value, "N") = "S")
        End If
      Case enListagemGeral_TipoTela.CadastroPais
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridPais_IC_SISTEMA).Value, "N") = "S")
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridTipoEndereco_IC_SISTEMA).Value, "N") = "S")
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridTipoMidiaSocial_IC_SISTEMA).Value, "N") = "S")
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridTipoPessoa_IC_SISTEMA).Value, "N") = "S")
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridModeloDocumentoElemento_IC_SISTEMA).Value, "N") = "S")
    End Select
  End Sub

  Private Sub cmdAtualizar_Click(sender As Object, e As EventArgs) Handles cmdAtualizar.Click
    Pesquisar()
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        Dim oForm As New frmCadastroNaturezaOperacao

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroCondicaoPagamento
        Dim oForm As New frmCadastroCondicaoPagamento

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroProdutoLinha
        Dim oForm As New frmCadastroProdutoLinha

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        Dim oForm As New frmCadastroEspecialidade

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroEstoque
        Dim oForm As New frmCadastroEstoque_Simples

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        Dim oForm As New frmCadastroContaCaixa

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        Dim oForm As New frmCadastroModeloDocumentoElemento

        oForm.iTipoTela = IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, enOpcoes.TipoElementoModeloDocumento_Assinatura,
                              IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, enOpcoes.TipoElementoModeloDocumento_Cabecalho,
                                                                                                                                enOpcoes.TipoElementoModeloDocumento_Rodape))

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroConvenio
        Dim oForm As New frmCadastroConvenio

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
    End Select
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
      Exit Sub
    End If

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroProdutoLinha
        Dim oForm As New frmCadastroProdutoLinha

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_PRODUTO_LINHA = objGrid_Valor(grdListagem, const_GridProdutoLinha_SQ_PRODUTO_LINHA)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        Dim oForm As New frmCadastroEspecialidade

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_ESPECIALIDADE = objGrid_Valor(grdListagem, const_GridEspecialidade_SQ_ESPECIALIDADE)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        Dim oForm As New frmCadastroNaturezaOperacao

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_NATUREZAOPERACAO = objGrid_Valor(grdListagem, const_GridNaturezaOperacao_SQ_NATUREZAOPERACAO)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        Dim oForm As New frmCadastroContaCaixa

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_CONTAFINANCEIRA = objGrid_Valor(grdListagem, const_GridContaCaixa_SQ_CONTACAIXA)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroContaBancaria
        Dim oForm As New frmCadastroContaBancaria

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_CONTAFINANCEIRA = objGrid_Valor(grdListagem, const_GridContaCaixa_SQ_CONTACAIXA)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroCondicaoPagamento
        Dim oForm As New frmCadastroCondicaoPagamento

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_CONDICAOPAGAMENTO = objGrid_Valor(grdListagem, const_GridCondicaoPagamento_SQ_CONDICAOPAGAMENTO)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroEstoque
        Dim oForm As New frmCadastroEstoque_Simples

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_ESTOQUE = objGrid_Valor(grdListagem, const_GridEstoque_SQ_ESTOQUE)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        Dim oForm As New frmCadastroModeloDocumentoElemento

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_MODELODOCUMENTO_ELEMENTO = objGrid_Valor(grdListagem, const_GridModeloDocumentoElemento_SQ_MODELODOCUMENTO_ELEMENTO)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroConvenio
        Dim oForm As New frmCadastroConvenio

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_CONVENIO = objGrid_Valor(grdListagem, const_GridConvenio_SQ_CONVENIO)

        FNC_AbriTela(oForm)
    End Select
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para exclusão")
      Exit Sub
    End If

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroCanalNegocio
        If Not FNC_Perguntar("Deseja realmente excluir essa Canal de Negócio?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_CANALNEGOCIO_DEL", False, "@SQ_CANALNEGOCIO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_CANALNEGOCIO", objGrid_Valor(grdListagem, const_GridCanalNegocio_SQ_CANALNEGOCIO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroProdutoLinha
        If Not FNC_Perguntar("Deseja realmente excluir essa Linha de Produto?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_PRODUTO_LINHA_DEL", False, "@SQ_PRODUTO_LINHA")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_PRODUTO_LINHA", objGrid_Valor(grdListagem, const_GridProdutoLinha_SQ_PRODUTO_LINHA))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        If Not FNC_Perguntar("Deseja realmente excluir essa Conta Financeira?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_CONTAFINANCEIRA_DEL", False, "@SQ_CONTAFINANCEIRA")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaCaixa_SQ_CONTACAIXA))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        If Not FNC_Perguntar("Deseja realmente excluir essa Especialidade?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_ESPECIALIDADE_DEL", False, "@SQ_ESPECIALIDADE")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_ESPECIALIDADE", objGrid_Valor(grdListagem, const_GridEspecialidade_SQ_ESPECIALIDADE))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroFinanciamento
        If Not FNC_Perguntar("Deseja realmente excluir esse Financiamento?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_FINANCIAMENTO_DEL", False, "@SQ_FINANCIAMENTO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_FINANCIAMENTO", objGrid_Valor(grdListagem, const_GridFinanciamento_SQ_FINANCIAMENTO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoTributario
        If Not FNC_Perguntar("Deseja realmente excluir esse grupo tributário?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_GRUPOTRIBUTARIO_DEL", False, "@SQ_GRUPOTRIBUTARIO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_GRUPOTRIBUTARIO", objGrid_Valor(grdListagem, const_GridGrupoTributario_SQ_GRUPOTRIBUTARIO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        If Not FNC_Perguntar("Deseja realmente excluir essa natureza de operação?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_NATUREZAOPERACAO_DEL", False, "@SQ_NATUREZAOPERACAO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_NATUREZAOPERACAO", objGrid_Valor(grdListagem, const_GridNaturezaOperacao_SQ_NATUREZAOPERACAO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroCondicaoPagamento
        If Not FNC_Perguntar("Deseja realmente excluir essa condição de pagamento?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_CONDICAOPAGAMENTO_DEL", False, "@SQ_CONDICAOPAGAMENTO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_CONDICAOPAGAMENTO", objGrid_Valor(grdListagem, const_GridCondicaoPagamento_SQ_CONDICAOPAGAMENTO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroContabilizacao
        If Not FNC_Perguntar("Deseja realmente excluir essa contabilização?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_CONTABILIZACAO_DEL", False, "@SQ_CONTABILIZACAO")

        If DBExecutar(sSqlText, DBParametro_Montar("@SQ_CONTABILIZACAO", objGrid_Valor(grdListagem, const_GridContabilizacao_SQ_CONTABILIZACAO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroTabelaPreco
        If Not FNC_Perguntar("Deseja realmente excluir essa tabela de preço?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_TABELAPRECO_DEL", False, "@SQ_TABELAPRECO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_TABELAPRECO", objGrid_Valor(grdListagem, const_GridTabelaPreco_SQ_TABELAPRECO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroEstoque
        If Not FNC_Perguntar("Deseja realmente excluir esse estoque?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_ESTOQUE_DEL", False, "@SQ_ESTOQUE")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_ESTOQUE", objGrid_Valor(grdListagem, const_GridEstoque_SQ_ESTOQUE))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho,
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        If objGrid_Valor(grdListagem, const_GridModeloDocumentoElemento_IC_SISTEMA, , "N") = "S" Then
          FNC_Mensagem("Esse é um registro de sistema e por isso não pode ser excluído")
          Exit Sub
        End If
        If Not FNC_Perguntar("Deseja realmente excluir esse modelo?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_MODELODOCUMENTO_ELEMENTO_DEL", False, "@SQ_MODELODOCUMENTO_ELEMENTO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_MODELODOCUMENTO_ELEMENTO", objGrid_Valor(grdListagem, const_GridModeloDocumentoElemento_SQ_MODELODOCUMENTO_ELEMENTO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroConvenio
        If Not FNC_Perguntar("Deseja realmente excluir esse convênio?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_CONVENIO_DEL", False, "@SQ_CONVENIO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_CONVENIO", objGrid_Valor(grdListagem, const_GridConvenio_SQ_CONVENIO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
    End Select
  End Sub

  Private Sub grdListagem_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdListagem.BeforeRowsDeleted
    Dim bCancelar As Boolean

    bLinhaExcluida = False

    e.DisplayPromptMsg = False

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroTipoIndicador
        If FNC_Perguntar("Deseja realmente excluir o Tipo de Indicador " & e.Rows(0).Cells(const_GridTipoIndicador_NO_TIPOINDICADOR).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoIndicador_SQ_TIPOINDICADOR).Value) Then
            If Not FNC_Busca_CanalNegocio_ExisteDepencia(e.Rows(0).Cells(const_GridTipoIndicador_SQ_TIPOINDICADOR).Value) Then
              DBExecutar_Delete("TB_TIPOINDICADOR", "SQ_TIPOINDICADOR", e.Rows(0).Cells(const_GridTipoIndicador_SQ_TIPOINDICADOR).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroCanalMarcacao
        If FNC_Perguntar("Deseja realmente excluir o Canal de Marcação " & e.Rows(0).Cells(const_GridCanalMarcacao_NO_CANALMARCACAO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridCanalMarcacao_SQ_CANALMARCACAO).Value) Then
            If Not FNC_Busca_CanalNegocio_ExisteDepencia(e.Rows(0).Cells(const_GridCanalMarcacao_SQ_CANALMARCACAO).Value) Then
              DBExecutar_Delete("TB_CANALMARCACAO", "SQ_CANALMARCACAO", e.Rows(0).Cells(const_GridCanalMarcacao_SQ_CANALMARCACAO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoProcedimento
        If FNC_Perguntar("Deseja realmente excluir o Grupo de Procedimento " & e.Rows(0).Cells(const_GridGrupoProcedimento_NO_GRUPOPROCEDIMENTO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridGrupoProcedimento_SQ_GRUPOPROCEDIMENTO).Value) Then
            If Not FNC_Busca_CanalNegocio_ExisteDepencia(e.Rows(0).Cells(const_GridGrupoProcedimento_SQ_GRUPOPROCEDIMENTO).Value) Then
              DBExecutar_Delete("TB_GRUPOPROCEDIMENTO", "SQ_GRUPOPROCEDIMENTO", e.Rows(0).Cells(const_GridGrupoProcedimento_SQ_GRUPOPROCEDIMENTO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroCanalNegocio
        If FNC_Perguntar("Deseja realmente excluir o Canal de Negócio " & e.Rows(0).Cells(const_GridCanalNegocio_NomeCanalNegocio).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridCanalNegocio_SQ_CANALNEGOCIO).Value) Then
            If Not FNC_Busca_CanalNegocio_ExisteDepencia(e.Rows(0).Cells(const_GridCanalNegocio_SQ_CANALNEGOCIO).Value) Then
              DBExecutar_Delete("TB_CANALNEGOCIO", "SQ_CANALNEGOCIO", e.Rows(0).Cells(const_GridCanalNegocio_SQ_CANALNEGOCIO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroVacina
        If FNC_Perguntar("Deseja realmente excluir a vacina " & e.Rows(0).Cells(const_GridVacina_NO_VACINA).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridVacina_SQ_VACINA).Value) Then
            If Not FNC_BuscaVacina_ExisteDepencia(e.Rows(0).Cells(const_GridVacina_SQ_VACINA).Value) Then
              DBExecutar_Delete("TB_VACINA", "SQ_VACINA", e.Rows(0).Cells(const_GridVacina_SQ_VACINA).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroConsultorio
        If FNC_Perguntar("Deseja realmente excluir o consultório " & e.Rows(0).Cells(const_GridConsultorio_NO_CONSULTORIO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridConsultorio_SQ_CONSULTORIO).Value) Then
            If Not FNC_BuscaVacina_ExisteDepencia(e.Rows(0).Cells(const_GridConsultorio_SQ_CONSULTORIO).Value) Then
              DBExecutar_Delete("TB_CONSULTORIO", "SQ_CONSULTORIO", e.Rows(0).Cells(const_GridConsultorio_SQ_CONSULTORIO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTurno
        If FNC_Perguntar("Deseja realmente excluir o turno " & e.Rows(0).Cells(const_GridTurno_NO_TURNO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTurno_SQ_TURNO).Value) Then
            DBExecutar_Delete("TB_TURNO", "SQ_TURNO", e.Rows(0).Cells(const_GridTurno_SQ_TURNO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalSerie
        If FNC_Perguntar("Deseja realmente excluir a série " & e.Rows(0).Cells(const_GridDocumentoFiscalSerie_ID_DOCUMENTOFISCAL_TIPO).Text & "-" &
                                                               e.Rows(0).Cells(const_GridDocumentoFiscalSerie_CD_DOCUMENTOFISCAL_SERIE).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridDocumentoFiscalSerie_SQ_DOCUMENTOFISCAL_SERIE).Value) Then
            DBExecutar_Delete("TB_DOCUMENTOFISCAL_SERIE", "SQ_DOCUMENTOFISCAL_SERIE", e.Rows(0).Cells(const_GridDocumentoFiscalSerie_SQ_DOCUMENTOFISCAL_SERIE).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        If FNC_Perguntar("Deseja realmente excluir o plano de contas " & e.Rows(0).Cells(const_GridPlanoContas_NomePlanoContas).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridPlanoContas_SQ_PLANOCONTAS).Value) Then
            If Not FNC_Busca_PlanoContas_ExisteDepencia(e.Rows(0).Cells(const_GridPlanoContas_SQ_PLANOCONTAS).Value) Then
              DBExecutar_Delete("TB_PLANOCONTAS", "SQ_PLANOCONTAS", e.Rows(0).Cells(const_GridPlanoContas_SQ_PLANOCONTAS).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        If FNC_Perguntar("Deseja realmente excluir o grupo de plano de contas " & e.Rows(0).Cells(const_GridPlanoContasGrupo_NomeGrupoProduto).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO).Value) Then
            If FNC_Busca_GruoPlanoContas_ExisteDepencia(e.Rows(0).Cells(const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO).Value) Then
              DBExecutar_Delete("TB_PLANOCONTAS_GRUPO", "SQ_PLANOCONTAS_GRUPO", e.Rows(0).Cells(const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoPermissao
        If FNC_Perguntar("Deseja realmente excluir o grupo de permissão " & e.Rows(0).Cells(const_GridGrupoPermissao_NomeGrupoPermissao).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridGrupoPermissao_SQ_GRUPOPERMISSAO).Value) Then
            DBExecutar_Delete("TB_SEG_GRUPOPERMISSAO", "SQ_GRUPOPERMISSAO", e.Rows(0).Cells(const_GridGrupoPermissao_SQ_GRUPOPERMISSAO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroProfissao
        If FNC_Perguntar("Deseja realmente excluir a profissão " & e.Rows(0).Cells(const_GridProfissao_NomeProfissao).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridProfissao_SQ_PROFISSAO).Value) Then
            If FNC_Busca_Profissao_ExisteDepencia(e.Rows(0).Cells(const_GridProfissao_SQ_PROFISSAO).Value) Then
              DBExecutar_Delete("TB_PROFISSAO", "SQ_PROFISSAO", e.Rows(0).Cells(const_GridProfissao_SQ_PROFISSAO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroConselhoProfissional
        If FNC_Perguntar("Deseja realmente excluir o conselho profissional " & e.Rows(0).Cells(const_GridConselhoProfissional_NO_CONSELHOPROFISSIONAL).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridConselhoProfissional_SQ_CONSELHOPROFISSIONAL).Value) Then
            If Not FNC_Busca_ConselhoProfissional_ExisteDepencia(e.Rows(0).Cells(const_GridConselhoProfissional_SQ_CONSELHOPROFISSIONAL).Value) Then
              DBExecutar_Delete("TB_CONSELHOPROFISSIONAL", "SQ_CONSELHOPROFISSIONAL", e.Rows(0).Cells(const_GridConselhoProfissional_SQ_CONSELHOPROFISSIONAL).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoServico
        If FNC_Perguntar("Deseja realmente excluir o tipo de serviço " & e.Rows(0).Cells(const_GridTipoServico_NomeTipoServico).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoServico_SQ_TIPO_SERVICO).Value) Then
            DBExecutar_Delete("TB_TIPO_SERVICO", "SQ_TIPO_SERVICO", e.Rows(0).Cells(const_GridTipoServico_SQ_TIPO_SERVICO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRelatorio
        If FNC_Perguntar("Deseja realmente excluir o tipo de relatório " & e.Rows(0).Cells(const_GridTipoRelatorio_NO_TIPO_RELATORIO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoRelatorio_SQ_TIPO_RELATORIO).Value) Then
            DBExecutar_Delete("TB_TIPO_RELATORIO", "SQ_TIPO_RELATORIO", e.Rows(0).Cells(const_GridTipoRelatorio_SQ_TIPO_RELATORIO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar, enListagemGeral_TipoTela.CadastroSegmento_OrdemServico
        If FNC_Perguntar("Deseja realmente excluir o segmento " & e.Rows(0).Cells(const_GridSegmento_NomeSegmento).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridSegmento_SQ_SEGMENTO).Value) Then
            If Not FNC_Busca_Segmento_ExisteDepencia(e.Rows(0).Cells(const_GridSegmento_SQ_SEGMENTO).Value) Then
              DBExecutar_Delete("TB_SEGMENTO", "SQ_SEGMENTO", e.Rows(0).Cells(const_GridSegmento_SQ_SEGMENTO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        If FNC_Perguntar("Deseja realmente excluir o motivo da doença " & e.Rows(0).Cells(const_GridDoencaEstagio_DoencaEstagio).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO).Value) Then
            DBExecutar_Delete("TB_DOENCA_ESTAGIO", "SQ_DOENCA_ESTAGIO", e.Rows(0).Cells(const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoServico
        If FNC_Perguntar("Deseja realmente excluir o tipo de serviço " & e.Rows(0).Cells(const_GridTipoServico_NomeTipoServico).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoServico_SQ_TIPO_SERVICO).Value) Then
            DBExecutar_Delete("TB_TIPO_SERVICO", "SQ_TIPO_SERVICO", e.Rows(0).Cells(const_GridTipoServico_SQ_TIPO_SERVICO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRelatorio
        If FNC_Perguntar("Deseja realmente excluir o tipo de relatório " & e.Rows(0).Cells(const_GridTipoRelatorio_NO_TIPO_RELATORIO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoRelatorio_SQ_TIPO_RELATORIO).Value) Then
            DBExecutar_Delete("TB_TIPO_RELATORIO", "SQ_TIPO_RELATORIO", e.Rows(0).Cells(const_GridTipoRelatorio_SQ_TIPO_RELATORIO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroCargo
        If FNC_Perguntar("Deseja realmente excluir a função " & e.Rows(0).Cells(const_GridCargo_NomeCargo).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridCargo_SQ_TIPO_CARGO).Value) Then
            DBExecutar_Delete("TB_TIPO_CARGO", "SQ_TIPO_CARGO", e.Rows(0).Cells(const_GridCargo_SQ_TIPO_CARGO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroCidade
        If FNC_Perguntar("Deseja realmente excluir a cidade " & e.Rows(0).Cells(const_GridCidade_NomeCidade).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridCidade_SQ_CIDADE).Value) Then
            If Not FNC_Busca_Cidade_ExisteDepencia(e.Rows(0).Cells(const_GridCidade_SQ_CIDADE).Value) Then
              DBExecutar_Delete("TB_CIDADE", "SQ_CIDADE", e.Rows(0).Cells(const_GridCidade_SQ_CIDADE).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroUF
        If FNC_Perguntar("Deseja realmente excluir a U.F. " & e.Rows(0).Cells(const_GridUF_NomeUF).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridUF_SQ_UF).Value) Then
            DBExecutar_Delete("TB_UF", "SQ_UF", e.Rows(0).Cells(const_GridUF_SQ_UF).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroPais
        If FNC_NVL(e.Rows(0).Cells(const_GridPais_IC_SISTEMA).Value, "N") = "S" Then
          FNC_Mensagem(const_Mensagem_RegistroSistema)
          bCancelar = True
        Else
          If FNC_Perguntar("Deseja realmente excluir o país " & e.Rows(0).Cells(const_GridPais_NomePais).Value & "?") Then
            If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridPais_SQ_PAIS).Value) Then
              If Not FNC_Busca_Pais_ExisteDepencia(e.Rows(0).Cells(const_GridPais_SQ_PAIS).Value) Then
                DBExecutar_Delete("TB_PAIS", "SQ_PAIS", e.Rows(0).Cells(const_GridPais_SQ_PAIS).Value)
              End If
            End If
          Else
            bCancelar = True
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        If FNC_Perguntar("Deseja realmente excluir o grupo de produto " & e.Rows(0).Cells(const_GridGrupoProduto_NomeGrupoProduto).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridGrupoProduto_SQ_GRUPOPRODUTO).Value) Then
            DBExecutar_Delete("TB_GRUPOPRODUTO", "SQ_GRUPOPRODUTO", e.Rows(0).Cells(const_GridGrupoProduto_SQ_GRUPOPRODUTO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroUnidadeMedida
        If FNC_Perguntar("Deseja realmente excluir a unidade de medida " & e.Rows(0).Cells(const_GridUnidadeMedida_NomeUnidadeMedida).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridUnidadeMedida_SQ_UNIDADEMEDIDA).Value) Then
            DBExecutar_Delete("TB_UNIDADEMEDIDA", "SQ_UNIDADEMEDIDA", e.Rows(0).Cells(const_GridUnidadeMedida_SQ_UNIDADEMEDIDA).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        If FNC_Perguntar("Deseja realmente excluir a especialidade " & e.Rows(0).Cells(const_GridEspecialidade_NomeEspecialidade).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridUnidadeMedida_SQ_UNIDADEMEDIDA).Value) Then
            DBExecutar_Delete("TB_ESPECIALIDADE", "SQ_ESPECIALIDADE", e.Rows(0).Cells(const_GridEspecialidade_SQ_ESPECIALIDADE).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroBanco
        If FNC_Perguntar("Deseja realmente excluir o banco " & e.Rows(0).Cells(const_GridBanco_NomeBanco).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridBanco_SQ_BANCO).Value) Then
            If Not FNC_Busca_Banco_ExisteDepencia(e.Rows(0).Cells(const_GridBanco_SQ_BANCO).Value) Then
              DBExecutar_Delete("TB_BANCO", "SQ_BANCO", e.Rows(0).Cells(const_GridBanco_SQ_BANCO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroContaBancaria, enListagemGeral_TipoTela.CadastroContaCaixa
        If FNC_NVL(e.Rows(0).Cells(const_GridContaCaixa_IC_SISTEMA).Value, "N") = "S" Then
          FNC_Mensagem(const_Mensagem_RegistroSistema)
          bCancelar = True
        Else
          Dim iSQ_CONTAFINANCEIRA As Integer

          Select Case eListagemGeral_TipoTela
            Case enListagemGeral_TipoTela.CadastroContaBancaria
              iSQ_CONTAFINANCEIRA = FNC_NVL(e.Rows(0).Cells(const_GridContaBancaria_SQ_CONTABANCARIA).Value, 0)
              If Not FNC_Perguntar("Deseja realmente excluir a conta bancária " & e.Rows(0).Cells(const_GridContaBancaria_NumeroConta).Value & "?") Then
                bCancelar = True
              End If
            Case enListagemGeral_TipoTela.CadastroContaCaixa
              iSQ_CONTAFINANCEIRA = FNC_NVL(e.Rows(0).Cells(const_GridContaCaixa_SQ_CONTACAIXA).Value, 0)
              If Not FNC_Perguntar("Deseja realmente excluir a conta caixa " & e.Rows(0).Cells(const_GridContaCaixa_NomeCaixa).Value & "?") Then
                bCancelar = True
              End If
          End Select

          If Not bCancelar Then
            If iSQ_CONTAFINANCEIRA <> 0 Then
              If FNC_Busca_ContaFinanceira_ExisteDepencia(iSQ_CONTAFINANCEIRA) Then
                DBExecutar_Delete("TB_CONTAFINANCEIRA", "SQ_CONTAFINANCEIRA", iSQ_CONTAFINANCEIRA)
              End If
            End If
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        If FNC_Perguntar("Deseja realmente excluir a forma de pagamento " & e.Rows(0).Cells(const_GridFormaPagamento_NomeFormaPagamento).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridFormaPagamento_SQ_FORMAPAGAMENTO).Value) Then
            DBExecutar_Delete("TB_FORMAPAGAMENTO", "SQ_FORMAPAGAMENTO", e.Rows(0).Cells(const_GridFormaPagamento_SQ_FORMAPAGAMENTO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        If FNC_Perguntar("Deseja realmente excluir o cargo " & e.Rows(0).Cells(const_GridTipoCargo_NomeTipoCargo).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoCargo_SQ_TIPO_CARGO).Value) Then
            DBExecutar_Delete("TB_TIPO_CARGO", "SQ_TIPO_CARGO", e.Rows(0).Cells(const_GridTipoCargo_SQ_TIPO_CARGO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoContato
        If (FNC_NVL(e.Rows(0).Cells(const_GridTipoContato_IC_SISTEMA).Value, "N") = "S") Then
          FNC_Mensagem(const_Mensagem_RegistroSistema)
          bCancelar = True
        Else
          If FNC_Perguntar("Deseja realmente excluir o tipo de contato " & e.Rows(0).Cells(const_GridTipoContato_NomeTipoContato).Value & "?") Then
            If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoContato_SQ_TIPO_CONTATO).Value) Then
              DBExecutar_Delete("TB_TIPO_CONTATO", "SQ_TIPO_CONTATO", e.Rows(0).Cells(const_GridTipoContato_SQ_TIPO_CONTATO).Value)
            End If
          Else
            bCancelar = True
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroTipoDocumento
        If FNC_Perguntar("Deseja realmente excluir o tipo de documento " & e.Rows(0).Cells(const_GridTipoDocumento_NomeTipoDocumento).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoDocumento_SQ_TIPO_DOCUMENTO).Value) Then
            DBExecutar_Delete("TB_TIPO_DOCUMENTO", "SQ_TIPO_DOCUMENTO", e.Rows(0).Cells(const_GridTipoDocumento_SQ_TIPO_DOCUMENTO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        If (FNC_NVL(e.Rows(0).Cells(const_GridTipoEndereco_IC_SISTEMA).Value, "N") = "S") Then
          FNC_Mensagem(const_Mensagem_RegistroSistema)
          bCancelar = True
        Else
          If FNC_Perguntar("Deseja realmente excluir o tipo de endereço " & e.Rows(0).Cells(const_GridTipoEndereco_NomeTipoEndereco).Value & "?") Then
            If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoEndereco_SQ_TIPO_ENDERECO).Value) Then
              DBExecutar_Delete("TB_TIPO_ENDERECO", "SQ_TIPO_ENDERECO", e.Rows(0).Cells(const_GridTipoEndereco_SQ_TIPO_ENDERECO).Value)
            End If
          Else
            bCancelar = True
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEscolaridade
        If FNC_Perguntar("Deseja realmente excluir o tipo de escolaridade " & e.Rows(0).Cells(const_GridTipoEscolaridade_NomeTipoEscolaridade).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE).Value) Then
            DBExecutar_Delete("TB_TIPO_ESCOLARIDADE", "SQ_TIPO_ESCOLARIDADE", e.Rows(0).Cells(const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEstadoCivil
        If FNC_Perguntar("Deseja realmente excluir o tipo de estado civil " & e.Rows(0).Cells(const_GridTipoEstadoCivil_NomeEstadoCivil).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL).Value) Then
            DBExecutar_Delete("TB_TIPO_ESTADOCIVIL", "SQ_TIPO_ESTADOCIVIL", e.Rows(0).Cells(const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        If (FNC_NVL(e.Rows(0).Cells(const_GridTipoMidiaSocial_IC_SISTEMA).Value, "N") = "S") Then
          FNC_Mensagem(const_Mensagem_RegistroSistema)
          bCancelar = True
        Else
          If FNC_Perguntar("Deseja realmente excluir o tipo de mídia social " & e.Rows(0).Cells(const_GridTipoMidiaSocial_NomeMidiaSocial).Value & "?") Then
            If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL).Value) Then
              DBExecutar_Delete("TB_TIPO_MIDIASOCIAL", "SQ_TIPO_MIDIASOCIAL", e.Rows(0).Cells(const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL).Value)
            End If
          Else
            bCancelar = True
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroTipoPaciente
        If FNC_Perguntar("Deseja realmente excluir o tipo de paciente " & e.Rows(0).Cells(const_GridTipoPaciente_NomeTipoPaciente).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoPaciente_SQ_TIPO_PACIENTE).Value) Then
            DBExecutar_Delete("TB_TIPO_PACIENTE", "SQ_TIPO_PACIENTE", e.Rows(0).Cells(const_GridTipoPaciente_SQ_TIPO_PACIENTE).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        If (FNC_NVL(e.Rows(0).Cells(const_GridTipoPessoa_IC_SISTEMA).Value, "N") = "S") Then
          FNC_Mensagem(const_Mensagem_RegistroSistema)
          bCancelar = True
        Else
          If FNC_Perguntar("Deseja realmente excluir o tipo de pessoa " & e.Rows(0).Cells(const_GridTipoPessoa_NomeTipoPessoa).Value & "?") Then
            If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoPessoa_SQ_TIPO_PESSOA).Value) Then
              DBExecutar_Delete("TB_TIPO_PESSOA", "SQ_TIPO_PESSOA", e.Rows(0).Cells(const_GridTipoPessoa_SQ_TIPO_PESSOA).Value)
            End If
          Else
            bCancelar = True
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroTipoProduto
        If FNC_Perguntar("Deseja realmente excluir o tipo de produto " & e.Rows(0).Cells(const_GridTipoProduto_NomeTipoProduto).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoPessoa_SQ_TIPO_PESSOA).Value) Then
            DBExecutar_Delete("TB_TIPO_PRODUTO", "SQ_TIPO_PRODUTO", e.Rows(0).Cells(const_GridTipoProduto_SQ_TIPO_PRODUTO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoQuestionario
        If FNC_Perguntar("Deseja realmente excluir o tipo de questionário " & e.Rows(0).Cells(const_GridTipoQuestionario_NomeTipoQuestionario).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO).Value) Then
            DBExecutar_Delete("TB_TIPO_QUESTIONARIO", "SQ_TIPO_QUESTIONARIO", e.Rows(0).Cells(const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRaca
        If FNC_Perguntar("Deseja realmente excluir o tipo de raça " & e.Rows(0).Cells(const_GridTipoRaca_NomeTipoRaca).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoRaca_SQ_TIPO_RACA).Value) Then
            DBExecutar_Delete("TB_TIPO_RACA", "SQ_TIPO_RACA", e.Rows(0).Cells(const_GridTipoRaca_SQ_TIPO_RACA).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa
        If FNC_Perguntar("Deseja realmente excluir o tipo de referência de pessoa " & e.Rows(0).Cells(const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA).Value) Then
            DBExecutar_Delete("TB_TIPO_REFERENCIAPESSOA", "SQ_TIPO_REFERENCIAPESSOA", e.Rows(0).Cells(const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroProdutoLinha
        If FNC_Perguntar("Deseja realmente excluir a linha de produto " & e.Rows(0).Cells(const_GridProdutoLinha_NomeLinhaProduto).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridProdutoLinha_SQ_PRODUTO_LINHA).Value) Then
            DBExecutar_Delete("TB_PRODUTO_LINHA_CARACTERISTICA", "ID_PRODUTO_LINHA", e.Rows(0).Cells(const_GridProdutoLinha_SQ_PRODUTO_LINHA).Value)
            DBExecutar_Delete("TB_PRODUTO_LINHA", "SQ_PRODUTO_LINHA", e.Rows(0).Cells(const_GridProdutoLinha_SQ_PRODUTO_LINHA).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroFinanciamento
        If FNC_Perguntar("Deseja realmente excluir o financiamento " & e.Rows(0).Cells(const_GridFinanciamento_NO_FINANCIAMENTO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridFinanciamento_SQ_FINANCIAMENTO).Value) Then
            DBExecutar_Delete("TB_FINANCIAMENTO", "SQ_FINANCIAMENTO", e.Rows(0).Cells(const_GridFinanciamento_SQ_FINANCIAMENTO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoTributario
        If FNC_Perguntar("Deseja realmente excluir o grupo tributário " & e.Rows(0).Cells(const_GridGrupoTributario_NO_GRUPOTRIBUTARIO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridGrupoTributario_SQ_GRUPOTRIBUTARIO).Value) Then
            DBExecutar_Delete("TB_GRUPOTRIBUTARIO", "SQ_GRUPOTRIBUTARIO", e.Rows(0).Cells(const_GridGrupoTributario_SQ_GRUPOTRIBUTARIO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroCaracteristicaProduto
        If FNC_Perguntar("Deseja realmente excluir a característica " & e.Rows(0).Cells(const_GridCaracteristicaProduto_NO_CARACTERISTICA).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridCaracteristicaProduto_SQ_CARACTERISTICA_PRODUTO).Value) Then
            If Not FNC_Busca_CaracteristicaProduto_ExisteDepencia(e.Rows(0).Cells(const_GridCaracteristicaProduto_SQ_CARACTERISTICA_PRODUTO).Value) Then
              DBExecutar_Delete("TB_CARACTERISTICA_PRODUTO", "SQ_CARACTERISTICA_PRODUTO", e.Rows(0).Cells(const_GridCaracteristicaProduto_SQ_CARACTERISTICA_PRODUTO).Value)
            End If
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        If FNC_Perguntar("Deseja realmente excluir o tipo de religião " & e.Rows(0).Cells(const_GridTipoReligiao_NomeTipoReligiao).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoReligiao_SQ_TIPO_RELIGIAO).Value) Then
            DBExecutar_Delete("TB_TIPO_RELIGIAO", "SQ_TIPO_RELIGIAO", e.Rows(0).Cells(const_GridTipoReligiao_SQ_TIPO_RELIGIAO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoSexo
        If FNC_Perguntar("Deseja realmente excluir o tipo de sexo " & e.Rows(0).Cells(const_GridTipoSexo_NomeTipoSexo).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoSexo_SQ_TIPO_SEXO).Value) Then
            DBExecutar_Delete("TB_TIPO_SEXO", "SQ_TIPO_SEXO", e.Rows(0).Cells(const_GridTipoSexo_SQ_TIPO_SEXO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoTelefone
        If FNC_Perguntar("Deseja realmente excluir o tipo de telefone " & e.Rows(0).Cells(const_GridTipoTelefone_NomeTipoTelefone).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoTelefone_SQ_TIPO_TELEFONE).Value) Then
            DBExecutar_Delete("TB_TIPO_TELEFONE", "SQ_TIPO_TELEFONE", e.Rows(0).Cells(const_GridTipoTelefone_SQ_TIPO_TELEFONE).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroDepartamento
        If FNC_NVL(e.Rows(0).Cells(const_GridDepartamento_IC_SISTEMA).Value, "N") = "S" Then
          FNC_Mensagem(const_Mensagem_RegistroSistema)
          bCancelar = True
        Else
          If FNC_Perguntar("Deseja realmente excluir o departamento " & e.Rows(0).Cells(const_GridDepartamento_NomeDepartamento).Value & "?") Then
            If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridDepartamento_SQ_DEPARTAMENTO).Value) Then
              If FNC_Busca_Departamento_ExisteDepencia(e.Rows(0).Cells(const_GridDepartamento_SQ_DEPARTAMENTO).Value) Then
                DBExecutar_Delete("TB_DEPARTAMENTO", "SQ_DEPARTAMENTO", e.Rows(0).Cells(const_GridDepartamento_SQ_DEPARTAMENTO).Value)
              End If
            End If
          Else
            bCancelar = True
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroTipoContaFinanceira
        If FNC_Perguntar("Deseja realmente excluir o tipo de conta bancária " & e.Rows(0).Cells(const_GridTipoContaFinanceira_NomeTipoContaBancaria).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA).Value) Then
            DBExecutar_Delete("TB_TIPO_CONTAFINANCEIRA", "SQ_TIPO_CONTAFINANCEIRA", e.Rows(0).Cells(const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoConsulta
        If FNC_Perguntar("Deseja realmente excluir o tipo de consulta " & e.Rows(0).Cells(const_GridTipoConsulta_NO_TIPO_CONSULTA).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTipoConsulta_SQ_TIPO_CONSULTA).Value) Then
            DBExecutar_Delete("TB_TIPO_CONSULTA", "SQ_TIPO_CONSULTA", e.Rows(0).Cells(const_GridTipoConsulta_SQ_TIPO_CONSULTA).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroTransacaoEstoque
        If FNC_Perguntar("Deseja realmente excluir a transação de estoque " & e.Rows(0).Cells(const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridTransacaoEstoque_SQ_TRANSACAOESTOQUE).Value) Then
            DBExecutar_Delete("TB_TRANSACAOESTOQUE", "SQ_TRANSACAOESTOQUE", e.Rows(0).Cells(const_GridTransacaoEstoque_SQ_TRANSACAOESTOQUE).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroServico
        If FNC_Perguntar("Deseja realmente excluir serviço " & e.Rows(0).Cells(const_GridServico_NO_SERVICO).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridServico_SQ_SERVICO).Value) Then
            DBExecutar_Delete("TB_SERVICO", "SQ_SERVICO", e.Rows(0).Cells(const_GridServico_SQ_SERVICO).Value)
          End If
        Else
          bCancelar = True
        End If
    End Select

    If bCancelar Then
      e.Cancel = True
    Else
      bLinhaExcluida = True
    End If
  End Sub

  Private Sub grdListagem_BeforeRowUpdate(sender As Object, e As CancelableRowEventArgs) Handles grdListagem.BeforeRowUpdate
    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroDocumentoFiscalSerie
        If FNC_CampoNulo(e.Row.Cells(const_GridDocumentoFiscalSerie_ID_DOCUMENTOFISCAL_TIPO).Value) Then
          FNC_Mensagem("É preciso selecionar o tipo do documento fiscal")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridDocumentoFiscalSerie_CD_DOCUMENTOFISCAL_SERIE).Value) Then
          FNC_Mensagem("É preciso informar o código da série")
          e.Cancel = True
          Exit Sub
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoProcedimento
        If FNC_CampoNulo(e.Row.Cells(const_GridGrupoProcedimento_NO_GRUPOPROCEDIMENTO).Value) Then
          FNC_Mensagem("É preciso informar o nome do Grupo de Procedimento")
          e.Cancel = True
          Exit Sub
        End If
      Case enListagemGeral_TipoTela.CadastroTipoIndicador
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoIndicador_NO_TIPOINDICADOR).Value) Then
          FNC_Mensagem("É preciso informar o nome do Tipo de Indicador")
          e.Cancel = True
          Exit Sub
        End If
      Case enListagemGeral_TipoTela.CadastroCanalMarcacao
        If FNC_CampoNulo(e.Row.Cells(const_GridCanalMarcacao_NO_CANALMARCACAO).Value) Then
          FNC_Mensagem("É preciso informar o nome do Canal de Marcação")
          e.Cancel = True
          Exit Sub
        End If
      Case enListagemGeral_TipoTela.CadastroCanalNegocio
        If FNC_CampoNulo(e.Row.Cells(const_GridCanalNegocio_NomeCanalNegocio).Value) Then
          FNC_Mensagem("É preciso informar o nome do Canal de Negócio")
          e.Cancel = True
          Exit Sub
        End If
      Case enListagemGeral_TipoTela.CadastroConsultorio
        If FNC_CampoNulo(e.Row.Cells(const_GridConsultorio_NO_CONSULTORIO).Value) Then
          FNC_Mensagem("É preciso informar o nome do consultório")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridConsultorio_CD_CONSULTORIO).Value) Then
          FNC_Mensagem("É preciso informar o código do consultório")
          e.Cancel = True
          Exit Sub
        End If
      Case enListagemGeral_TipoTela.CadastroTurno
        If FNC_CampoNulo(e.Row.Cells(const_GridTurno_NO_TURNO).Value) Then
          FNC_Mensagem("É preciso informar o nome do turno")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridTurno_HR_INICIO).Value) Then
          FNC_Mensagem("É preciso informar o horário inicial do turno")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridTurno_HR_FIM).Value) Then
          FNC_Mensagem("É preciso informar o horário final do turno")
          e.Cancel = True
          Exit Sub
        End If
      Case enListagemGeral_TipoTela.CadastroVacina
        If FNC_CampoNulo(e.Row.Cells(const_GridVacina_NO_VACINA).Value) Then
          FNC_Mensagem("É preciso informar o nome da Vacina")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridVacina_DS_SERVENTIA).Value) Then
          FNC_Mensagem("É preciso informar a serventia")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridVacina_DS_INICIO).Value) Then
          FNC_Mensagem("É preciso informar o início")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridVacina_DS_TERMINO).Value) Then
          FNC_Mensagem("É preciso informar o término")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridVacina_DS_APRAZAMENTO).Value) Then
          FNC_Mensagem("É preciso informar o aprazamento")
          e.Cancel = True
          Exit Sub
        End If
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        If FNC_CampoNulo(e.Row.Cells(const_GridPlanoContas_GrupoPlanoContas).Value) Then
          FNC_Mensagem("É preciso selecionar o grupo de plano de contas")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridPlanoContas_CodigoPlanoContas).Value) Then
          FNC_Mensagem("É preciso informar o código do plano de contas")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridPlanoContas_NomePlanoContas).Value) Then
          FNC_Mensagem("É preciso informar o nome do plano de contas")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridPlanoContas_CreditoDebito).Value) Then
          FNC_Mensagem("É preciso informar se o plano de contas é débito ou crédito")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridPlanoContas_CodigoPlanoContas, e.Row.Cells(const_GridPlanoContas_CodigoPlanoContas).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de plano de contas já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridPlanoContas_NomePlanoContas, e.Row.Cells(const_GridPlanoContas_NomePlanoContas).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Nome de plano de contas já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoPermissao
        If FNC_CampoNulo(e.Row.Cells(const_GridGrupoPermissao_NomeGrupoPermissao).Value) Then
          FNC_Mensagem("É preciso informar o nome do grupo de permissão")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridGrupoPermissao_NomeGrupoPermissao, e.Row.Cells(const_GridGrupoPermissao_NomeGrupoPermissao).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Grupo de permissão já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        If FNC_CampoNulo(e.Row.Cells(const_GridPlanoContasGrupo_CodigoGrupoProduto).Value) Then
          FNC_Mensagem("É preciso informar o código do grupo de plano de contas")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridPlanoContasGrupo_NomeGrupoProduto).Value) Then
          FNC_Mensagem("É preciso informar o nome do grupo de plano de contas")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridPlanoContasGrupo_CodigoGrupoProduto, e.Row.Cells(const_GridPlanoContasGrupo_CodigoGrupoProduto).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de grupo de plano de contas já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridPlanoContasGrupo_NomeGrupoProduto, e.Row.Cells(const_GridPlanoContasGrupo_NomeGrupoProduto).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Nome de grupo de plano de contas já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroProfissao
        If FNC_CampoNulo(e.Row.Cells(const_GridProfissao_NomeProfissao).Value) Then
          FNC_Mensagem("É preciso informar o nome da profissão")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridProfissao_NomeProfissao, e.Row.Cells(const_GridProfissao_NomeProfissao).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Profissão já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroConselhoProfissional
        If FNC_CampoNulo(e.Row.Cells(const_GridConselhoProfissional_NO_CONSELHOPROFISSIONAL).Value) Then
          FNC_Mensagem("É preciso informar o nome do conselho profissional")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridConselhoProfissional_NO_CONSELHOPROFISSIONAL, e.Row.Cells(const_GridConselhoProfissional_NO_CONSELHOPROFISSIONAL).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Conselho Profissional já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoServico
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoServico_NomeTipoServico).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de serviço")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoServico_NomeTipoServico, e.Row.Cells(const_GridTipoServico_NomeTipoServico).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de serviço já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRelatorio
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoRelatorio_NO_TIPO_RELATORIO).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de relatório")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoRelatorio_NO_TIPO_RELATORIO, e.Row.Cells(const_GridTipoRelatorio_NO_TIPO_RELATORIO).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de relatório já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar, enListagemGeral_TipoTela.CadastroSegmento_OrdemServico
        If FNC_CampoNulo(e.Row.Cells(const_GridSegmento_NomeSegmento).Value) Then
          FNC_Mensagem("É preciso informar o nome do segmento")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridSegmento_NomeSegmento, e.Row.Cells(const_GridSegmento_NomeSegmento).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Segmento já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        If FNC_CampoNulo(e.Row.Cells(const_GridDoencaEstagio_DoencaEstagio).Value) Then
          FNC_Mensagem("É preciso informar o nome do motivo da doença")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridDoencaEstagio_DoencaEstagio, e.Row.Cells(const_GridDoencaEstagio_DoencaEstagio).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Motivo da doença já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoServico
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoServico_NomeTipoServico).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de serviço")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoServico_NomeTipoServico, e.Row.Cells(const_GridTipoServico_NomeTipoServico).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de serviço já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRelatorio
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoRelatorio_NO_TIPO_RELATORIO).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de relatório")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoRelatorio_NO_TIPO_RELATORIO, e.Row.Cells(const_GridTipoRelatorio_NO_TIPO_RELATORIO).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de relatório já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroCargo
        If FNC_CampoNulo(e.Row.Cells(const_GridCargo_NomeCargo).Value) Then
          FNC_Mensagem("É preciso informar o nome da função")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridCargo_NomeCargo, e.Row.Cells(const_GridCargo_NomeCargo).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Cargo já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroCidade
        If FNC_CampoNulo(e.Row.Cells(const_GridCidade_UF).Value) Then
          FNC_Mensagem("É preciso selecionar a U.F.")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridCidade_NomeCidade).Value) Then
          FNC_Mensagem("É preciso informar o nome da cidade")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridCidade_UF, e.Row.Cells(const_GridCidade_UF).Value <
                                                       const_GridCidade_NomeCidade, e.Row.Cells(const_GridCidade_NomeCidade).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Cidade já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroUF
        If FNC_CampoNulo(e.Row.Cells(const_GridUF_Pais).Value) Then
          FNC_Mensagem("É preciso selecionar o País")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridUF_NomeUF).Value) Then
          FNC_Mensagem("É preciso informar o nome da U.F.")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridUF_CodigoUF).Value) Then
          FNC_Mensagem("É preciso informar o código da U.F.")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridUF_Pais, e.Row.Cells(const_GridUF_Pais).Value,
                                                       const_GridUF_NomeUF, e.Row.Cells(const_GridUF_NomeUF).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("U.F. já cadastrada")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridUF_Pais, e.Row.Cells(const_GridUF_Pais).Value,
                                                       const_GridUF_CodigoUF, e.Row.Cells(const_GridUF_CodigoUF).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de U.F. já informado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroPais
        If FNC_CampoNulo(e.Row.Cells(const_GridPais_NomePais).Value) Then
          FNC_Mensagem("É preciso informar o nome do país")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridPais_NomeNascionalidade).Value) Then
          FNC_Mensagem("É preciso informar o nome da nascionalidade")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridPais_NomePais, e.Row.Cells(const_GridPais_NomePais).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("País já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridPais_NomeNascionalidade, e.Row.Cells(const_GridPais_NomeNascionalidade).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Nascionalidade já informada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        If FNC_CampoNulo(e.Row.Cells(const_GridGrupoProduto_NomeGrupoProduto).Value) Then
          FNC_Mensagem("É preciso informar o nome do grupo de produto")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridGrupoProduto_NomeGrupoProduto, e.Row.Cells(const_GridGrupoProduto_NomeGrupoProduto).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Grupo de produto já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroUnidadeMedida
        If FNC_CampoNulo(e.Row.Cells(const_GridUnidadeMedida_NomeUnidadeMedida).Value) Then
          FNC_Mensagem("É preciso informar o nome da unidade de medida")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridUnidadeMedida_CodigoUnidadeMedida).Value) Then
          FNC_Mensagem("É preciso informar o código da unidade de medida")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridUnidadeMedida_NomeUnidadeMedida, e.Row.Cells(const_GridUnidadeMedida_NomeUnidadeMedida).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Unidade de Medida já cadastrada")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridUnidadeMedida_CodigoUnidadeMedida, e.Row.Cells(const_GridUnidadeMedida_CodigoUnidadeMedida).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de Unidade de Medida já informado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        If FNC_CampoNulo(e.Row.Cells(const_GridEspecialidade_NomeEspecialidade).Value) Then
          FNC_Mensagem("É preciso informar o nome da especialidade")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridEspecialidade_NomeEspecialidade, e.Row.Cells(const_GridEspecialidade_NomeEspecialidade).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Especialidade já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroBanco
        If FNC_CampoNulo(e.Row.Cells(const_GridBanco_NomeBanco).Value) Then
          FNC_Mensagem("É preciso informar o nome o banco")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridEspecialidade_NomeEspecialidade, e.Row.Cells(const_GridEspecialidade_NomeEspecialidade).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Especialidade já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroContaBancaria
        If FNC_CampoNulo(e.Row.Cells(const_GridContaBancaria_TipoConta).Value) Then
          FNC_Mensagem("É preciso selecionar o tipo de conta")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridContaBancaria_Banco).Value) Then
          FNC_Mensagem("É preciso selecionar o banco")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridContaBancaria_NumeroAgencia).Value) Then
          FNC_Mensagem("É preciso informar o número da agência")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridContaBancaria_NumeroConta).Value) Then
          FNC_Mensagem("É preciso informar o número da conta")
          e.Cancel = True
          Exit Sub
        End If
        If Trim(FNC_NVL(e.Row.Cells(const_GridContaBancaria_DigitoConta).Value, "")) = "" Then
          FNC_Mensagem("É preciso informar o dígito da conta")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridContaBancaria_DtAbetura).Value) Then
          FNC_Mensagem("É preciso informar a data de abertura")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridContaBancaria_Banco, e.Row.Cells(const_GridContaBancaria_Banco).Value,
                                                       const_GridContaBancaria_NumeroConta, e.Row.Cells(const_GridContaBancaria_NumeroConta).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Conta bancária já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        If FNC_CampoNulo(e.Row.Cells(const_GridContaCaixa_Departamento).Value) Then
          FNC_Mensagem("É preciso selecionar o departamento")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridContaCaixa_NomeCaixa).Value) Then
          FNC_Mensagem("É preciso informar o nome da conta caixa")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridContaCaixa_NomeCaixa, e.Row.Cells(const_GridContaCaixa_NomeCaixa).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Conta caixa já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        If FNC_CampoNulo(e.Row.Cells(const_GridFormaPagamento_NomeFormaPagamento).Value) Then
          FNC_Mensagem("É preciso informar o nome da forma de pagamento")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridFormaPagamento_NomeFormaPagamento, e.Row.Cells(const_GridFormaPagamento_NomeFormaPagamento).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Forma de pagamento já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoCargo_NomeTipoCargo).Value) Then
          FNC_Mensagem("É preciso informar o nome do cargo")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoCargo_NomeTipoCargo, e.Row.Cells(const_GridTipoCargo_NomeTipoCargo).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Cargo já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoContato
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoContato_NomeTipoContato).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de contato")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoContato_NomeTipoContato, e.Row.Cells(const_GridTipoContato_NomeTipoContato).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de contato já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoDocumento
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoDocumento_NomeTipoDocumento).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de documento")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoDocumento_ID_OPT_UTILIZACAOFINANCEIRO).Value) Then
          FNC_Mensagem("É preciso informar o tipo de utilização")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoDocumento_NomeTipoDocumento, e.Row.Cells(const_GridTipoDocumento_NomeTipoDocumento).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de documento já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Valor(grdListagem, const_GridTipoDocumento_ID_OPT_UTILIZACAOFINANCEIRO,, 0) <> enOpcoes.TipoUtilizacaoLançamentoFinanceiro_UsarLancamento.GetHashCode() Then
          e.Row.Cells(const_GridTipoDocumento_IC_COMPENSAR).Value = 0
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoEscolaridade_NomeTipoEscolaridade).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de escolaridade")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoEscolaridade_NomeTipoEscolaridade, e.Row.Cells(const_GridTipoEscolaridade_NomeTipoEscolaridade).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de escolaridade já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoEndereco_NomeTipoEndereco).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de endereço")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoEndereco_NomeTipoEndereco, e.Row.Cells(const_GridTipoEndereco_NomeTipoEndereco).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de endereço já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEstadoCivil
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoEstadoCivil_NomeEstadoCivil).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de estado civil")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoEstadoCivil_NomeEstadoCivil, e.Row.Cells(const_GridTipoEstadoCivil_NomeEstadoCivil).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de estado civil já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoMidiaSocial_NomeMidiaSocial).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de mídia social")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoMidiaSocial_NomeMidiaSocial, e.Row.Cells(const_GridTipoMidiaSocial_NomeMidiaSocial).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de mídia social já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoPaciente
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoPaciente_NomeTipoPaciente).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de paciente")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoPaciente_NomeTipoPaciente, e.Row.Cells(const_GridTipoPaciente_NomeTipoPaciente).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de paciente já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoPessoa_NomeTipoPessoa).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de pessoa")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoPessoa_NomeTipoPessoa, e.Row.Cells(const_GridTipoPessoa_NomeTipoPessoa).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de pessoa já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoProduto
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoProduto_NomeTipoProduto).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de produto")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoProduto_NomeTipoProduto, e.Row.Cells(const_GridTipoProduto_NomeTipoProduto).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de produto já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoQuestionario
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoQuestionario_NomeTipoQuestionario).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de questionário")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoQuestionario_TipoCampo).Value) Then
          FNC_Mensagem("É preciso selecionar o nome do tipo de campo")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoQuestionario_NomeTipoQuestionario, e.Row.Cells(const_GridTipoQuestionario_NomeTipoQuestionario).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de questionário já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRaca
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoRaca_NomeTipoRaca).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de raça")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoRaca_NomeTipoRaca, e.Row.Cells(const_GridTipoRaca_NomeTipoRaca).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de raça já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de referência de pessoa")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoReferenciaPessoal_TipoPessoa).Value) Then
          FNC_Mensagem("É preciso selecionar o tipo de pessoa")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoReferenciaPessoal_TipoPessoa, e.Row.Cells(const_GridTipoReferenciaPessoal_TipoPessoa).Value,
                                                       const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa, e.Row.Cells(const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de referência de pessoa já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroCaracteristicaProduto
        If FNC_CampoNulo(e.Row.Cells(const_GridCaracteristicaProduto_NO_CARACTERISTICA).Value) Then
          FNC_Mensagem("É preciso informar o nome da característica de produto")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridCaracteristicaProduto_NO_CARACTERISTICA, e.Row.Cells(const_GridCaracteristicaProduto_NO_CARACTERISTICA).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Característica de produto já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoReligiao_NomeTipoReligiao).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de religião")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoReligiao_NomeTipoReligiao, e.Row.Cells(const_GridTipoReligiao_NomeTipoReligiao).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de religião já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoSexo
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoSexo_NomeTipoSexo).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de sexo")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoSexo_NomeTipoSexo, e.Row.Cells(const_GridTipoSexo_NomeTipoSexo).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de sexo já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoTelefone
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoTelefone_NomeTipoTelefone).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de telefone")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoTelefone_NomeTipoTelefone, e.Row.Cells(const_GridTipoTelefone_NomeTipoTelefone).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de telefone já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroDepartamento
        If FNC_CampoNulo(e.Row.Cells(const_GridDepartamento_NomeDepartamento).Value) Then
          FNC_Mensagem("É preciso informar o nome do departamento")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridDepartamento_NomeDepartamento, e.Row.Cells(const_GridDepartamento_NomeDepartamento).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Departamento já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoContaFinanceira
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoContaFinanceira_NomeTipoContaBancaria).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de conta bancária")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoContaFinanceira_NomeTipoContaBancaria, e.Row.Cells(const_GridTipoContaFinanceira_NomeTipoContaBancaria).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de conta bancária já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoConsulta
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoConsulta_NO_TIPO_CONSULTA).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de consulta")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTipoConsulta_NO_TIPO_CONSULTA, e.Row.Cells(const_GridTipoConsulta_NO_TIPO_CONSULTA).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de consulta já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTransacaoEstoque
        If FNC_CampoNulo(e.Row.Cells(const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE).Value) Then
          FNC_Mensagem("É preciso informar o código da transação de estoque")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE).Value) Then
          FNC_Mensagem("É preciso informar o nome da transação de estoque")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO).Value) And
           FNC_CampoNulo(e.Row.Cells(const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO).Value) Then
          FNC_Mensagem("É preciso informar pelo menos o estoque de crédito ou estoque de débito dessa transação")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_NVL(e.Row.Cells(const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO).Value, 0) =
           FNC_NVL(e.Row.Cells(const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO).Value, 0) Then
          FNC_Mensagem("O estoque de crédito e o estoque de débito não podem serem o mesmo")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE, e.Row.Cells(const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Nome de transação de estoque já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE, e.Row.Cells(const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de transação de estoque já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroServico
        If FNC_CampoNulo(e.Row.Cells(const_GridServico_CD_SERVICO).Value) Then
          FNC_Mensagem("É preciso informar o código do serviço")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridServico_NO_SERVICO).Value) Then
          FNC_Mensagem("É preciso informar o nome do serviço")
          e.Cancel = True
          Exit Sub
        End If
        If FNC_CampoNulo(e.Row.Cells(const_GridServico_ID_TIPO_SERVICO).Value) Then
          FNC_Mensagem("É preciso selecionar o tipo do serviço")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridServico_NO_SERVICO, e.Row.Cells(const_GridServico_NO_SERVICO).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Nome de serviço já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem,
                                        FNC_GerarArray(const_GridServico_CD_SERVICO, e.Row.Cells(const_GridServico_CD_SERVICO).Value),
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de serviço já cadastrado")
          e.Cancel = True
        End If
    End Select
  End Sub

  Private Sub grdListagem_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdListagem.AfterCellUpdate
    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        Select Case e.Cell.Column.Index
          Case const_GridFormaPagamento_ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO
            e.Cell.Row.Cells(const_GridFormaPagamento_ID_CONTAFINANCEIRA_QUITACAO).ValueList = FNC_CarregarLista(enTipoCadastro.ContaFinanceira,
                                                                                                                 FNC_NVL(e.Cell.Row.Cells(const_GridFormaPagamento_ID_OPT_CLASSE_CONTAFINANCEIRA_QUITACAO).Value, 0))
        End Select
    End Select
  End Sub

  Private Sub frmListaGeral_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name + "_" + eListagemGeral_TipoTela.ToString())
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub
End Class