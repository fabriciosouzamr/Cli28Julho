Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmListaGeral
  Const const_GridPlanoContas_SQ_PLANOCONTAS As Integer = 0
  Const const_GridPlanoContas_GrupoPlanoContas As Integer = 1
  Const const_GridPlanoContas_CodigoPlanoContas As Integer = 2
  Const const_GridPlanoContas_NomePlanoContas As Integer = 3
  Const const_GridPlanoContas_CreditoDebito As Integer = 4
  Const const_GridPlanoContas_TipoCusto As Integer = 5
  Const const_GridPlanoContas_Ativo As Integer = 6

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
  Const const_GridConvenio_NomeConvenio As Integer = 1
  Const const_GridConvenio_CodigoContrato As Integer = 2
  Const const_GridConvenio_Ativo As Integer = 3

  Const const_GridGrupoProduto_SQ_GRUPOPRODUTO As Integer = 0
  Const const_GridGrupoProduto_NomeGrupoProduto As Integer = 1
  Const const_GridGrupoProduto_CFOP_Padrao As Integer = 2
  Const const_GridGrupoProduto_CTS_Padrao As Integer = 3
  Const const_GridGrupoProduto_CSOSN_Padrao As Integer = 4
  Const const_GridGrupoProduto_ControlaEstoque As Integer = 5
  Const const_GridGrupoProduto_ControlaGarantia As Integer = 6
  Const const_GridGrupoProduto_ControlaNumeroSerie As Integer = 7
  Const const_GridGrupoProduto_Ativo As Integer = 8

  Const const_GridUnidadeMedida_SQ_UNIDADEMEDIDA As Integer = 0
  Const const_GridUnidadeMedida_NomeUnidadeMedida As Integer = 1
  Const const_GridUnidadeMedida_CodigoUnidadeMedida As Integer = 2
  Const const_GridUnidadeMedida_CodigoUnidadeMedidaCompativel As Integer = 3

  Const const_GridEspecialidade_SQ_ESPECIALIDADE As Integer = 0
  Const const_GridEspecialidade_NomeEspecialidade As Integer = 1

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
  Const const_GridContaCaixa_NomeCaixa As Integer = 2
  Const const_GridContaCaixa_ControlaSaldo As Integer = 3
  Const const_GridContaCaixa_Ativo As Integer = 4
  Const const_GridContaCaixa_IC_SISTEMA As Integer = 5

  Const const_GridFormaPagamento_SQ_FORMAPAGAMENTO As Integer = 0
  Const const_GridFormaPagamento_TipoDocumento As Integer = 1
  Const const_GridFormaPagamento_NomeFormaPagamento As Integer = 2

  Const const_GridTipoCargo_SQ_TIPO_CARGO As Integer = 0
  Const const_GridTipoCargo_NomeTipoCargo As Integer = 1

  Const const_GridTipoContato_SQ_TIPO_CONTATO As Integer = 0
  Const const_GridTipoContato_NomeTipoContato As Integer = 1
  Const const_GridTipoContato_IC_SISTEMA As Integer = 2

  Const const_GridTipoDocumento_SQ_TIPO_DOCUMENTO As Integer = 0
  Const const_GridTipoDocumento_NomeTipoDocumento As Integer = 1

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
  Const const_GridTipoConsulta_IC_ATIVO As Integer = 2

  Const const_GridNaturezaOperacao_SQ_NATUREZAOPERACAO As Integer = 0
  Const const_GridNaturezaOperacao_NomeNaturezaOperacao As Integer = 1
  Const const_GridNaturezaOperacao_CFOP As Integer = 2
  Const const_GridNaturezaOperacao_AcaoFinanceiro As Integer = 3
  Const const_GridNaturezaOperacao_AcaoEstoque As Integer = 4
  Const const_GridNaturezaOperacao_PlanoContas As Integer = 5
  Const const_GridNaturezaOperacao_Finalidade As Integer = 6
  Const const_GridNaturezaOperacao_BaseICMS As Integer = 7
  Const const_GridNaturezaOperacao_BaseICMSST As Integer = 8
  Const const_GridNaturezaOperacao_CalcularIPI As Integer = 9
  Const const_GridNaturezaOperacao_Referencia As Integer = 10
  Const const_GridNaturezaOperacao_PermiteCreditoICMS As Integer = 11
  Const const_GridNaturezaOperacao_DestacaImpFedEstMunic As Integer = 12
  Const const_GridNaturezaOperacao_Ativo As Integer = 13

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
  Const const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO As Integer = 1
  Const const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO As Integer = 2
  Const const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE As Integer = 3
  Const const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE As Integer = 4
  Const const_GridTransacaoEstoque_IC_USAR_RECEBIMENTO As Integer = 5
  Const const_GridTransacaoEstoque_IC_USAR_VENDA As Integer = 6
  Const const_GridTransacaoEstoque_IC_USAR_MOVIMENTACAOMANUAL As Integer = 7
  Const const_GridTransacaoEstoque_IC_ATIVO As Integer = 8

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
  End Enum

  Public eListagemGeral_TipoTela As enListagemGeral_TipoTela

  Dim bEdicao As Boolean = True
  Dim oDBListagem As New UltraWinDataSource.UltraDataSource
  Dim bLinhaExcluida As Boolean

  Private Sub frmListaGeral_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
    grdListagem.PerformAction(UltraGridAction.ToggleDropdown, False, False)
  End Sub

  Private Sub frmListaGeral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Formatar()
  End Sub

  Private Sub Formatar()
    AjustarTela()

    If eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroNaturezaOperacao Or _
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroTabelaPreco Or _
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroEstoque Or _
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura Or _
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho Or _
       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape Then
      bEdicao = False
    End If

    objGrid_Inicializar(grdListagem, _
                        IIf(bEdicao, AllowAddNew.FixedAddRowOnTop, AllowAddNew.Default), _
                        oDBListagem, _
                        UltraWinGrid.CellClickAction.RowSelect, _
                        IIf(bEdicao, DefaultableBoolean.True, DefaultableBoolean.False), _
                        IIf(bEdicao, DefaultableBoolean.True, DefaultableBoolean.False), True, , , , True)

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        Me.Text = "Cadastro de Plano de Contas"

        lblRotuloListagem.Text = "Listagem de Plano de Contas"
        objGrid_Coluna_Add(grdListagem, "SQ_PLANOCONTAS", 0)
        objGrid_Coluna_Add(grdListagem, "Grupo de Plano de Contas", 300, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContasGrupo))
        objGrid_Coluna_Add(grdListagem, "Código do Plano de Contas", 180, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Plano de Contas", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Crédito/Débito", 200, , True, , FNC_CarregarLista(enTipoCadastro.CreditoDebito))
        objGrid_Coluna_Add(grdListagem, "Tipo de Custo", 200, , True, , FNC_CarregarLista(enTipoCadastro.TipoCustoPlanoContas))
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
      Case enListagemGeral_TipoTela.CadastroProfissao
        Me.Text = "Cadastro de Profissão"

        lblRotuloListagem.Text = "Listagem de Profissões"
        objGrid_Coluna_Add(grdListagem, "SQ_PROFISSAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Profissão", 400, , True, , , , , , 100)
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
      Case enListagemGeral_TipoTela.CadastroCargo
        Me.Text = "Cadastro de Cargo"

        lblRotuloListagem.Text = "Listagem de Cargo"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CARGO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Cargo", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroGrupoPermissao
        Me.Text = "Cadastro de Grupo de Permissão"

        lblRotuloListagem.Text = "Listagem de Grupo de Permissão"
        objGrid_Coluna_Add(grdListagem, "SQ_GRUPOPERMISSAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Grupo de Permissão", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroCidade
        Me.Text = "Cadastro de Cidade"

        lblRotuloListagem.Text = "Listagem de Cidade"
        objGrid_Coluna_Add(grdListagem, "SQ_CIDADE", 0)
        objGrid_Coluna_Add(grdListagem, "U.F.", 100, , True, , FNC_CarregarLista(enTipoCadastro.UF))
        objGrid_Coluna_Add(grdListagem, "Nome da Cidade", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Código do IBGE", 150, , True, ColumnStyle.IntegerPositive, , , , , 7)
      Case enListagemGeral_TipoTela.CadastroUF
        Me.Text = "Cadastro de U.F."

        lblRotuloListagem.Text = "Listagem de U.F."
        objGrid_Coluna_Add(grdListagem, "SQ_UF", 0)
        objGrid_Coluna_Add(grdListagem, "País", 100, , True, , FNC_CarregarLista(enTipoCadastro.Pais))
        objGrid_Coluna_Add(grdListagem, "Nome da U.F.", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Código da U.F.", 150, , True, , , , , , 2)
      Case enListagemGeral_TipoTela.CadastroPais
        Me.Text = "Cadastro de País"

        lblRotuloListagem.Text = "Listagem de País"
        objGrid_Coluna_Add(grdListagem, "SQ_PAIS", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do País", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Nome da Nascionalidade", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroConvenio
        Me.Text = "Cadastro de Convênio"

        lblRotuloListagem.Text = "Listagem de Convênio"
        objGrid_Coluna_Add(grdListagem, "SQ_CONVENIO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Convênio", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Código do Contrato", 200, , True, , , , , , 20)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        Me.Text = "Cadastro de Grupo de Produto"

        lblRotuloListagem.Text = "Listagem de Grupo de Produto"
        objGrid_Coluna_Add(grdListagem, "SQ_GRUPOPRODUTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Grupo de Produto", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "CFOP", 300, , True, , FNC_CarregarLista(enTipoCadastro.CFOP))
        objGrid_Coluna_Add(grdListagem, "CST", 300, , True, , FNC_CarregarLista(enTipoCadastro.CST))
        objGrid_Coluna_Add(grdListagem, "CSOSN", 300, , True, , FNC_CarregarLista(enTipoCadastro.CSOSN))
        objGrid_Coluna_Add(grdListagem, "Controla Estoque", 150, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Controle de Garantia", 150, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Controla Nº de Série", 150, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
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
      Case enListagemGeral_TipoTela.CadastroBanco
        Me.Text = "Cadastro de Banco"

        lblRotuloListagem.Text = "Listagem de Banco"
        objGrid_Coluna_Add(grdListagem, "SQ_BANCO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Banco", 400, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Número do Banco", 150, , True, ColumnStyle.IntegerPositive)
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
        objGrid_Coluna_Add(grdListagem, "Controla Saldo", 100, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        Me.Text = "Cadastro de Conta Caixa"

        lblRotuloListagem.Text = "Listagem de Conta Caixa"
        objGrid_Coluna_Add(grdListagem, "SQ_CONTACAIXA", 0)
        objGrid_Coluna_Add(grdListagem, "Departamento", 100, , True, , FNC_CarregarLista(enTipoCadastro.Departamento))
        objGrid_Coluna_Add(grdListagem, "Nome da Conta Caixa", 400, , True)
        objGrid_Coluna_Add(grdListagem, "Controla Saldo", 100, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        Me.Text = "Cadastro de Forma de Pagamento"

        lblRotuloListagem.Text = "Listagem de Forma de Pagamento"
        objGrid_Coluna_Add(grdListagem, "SQ_FORMAPAGAMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 200, , True, , FNC_CarregarLista(enTipoCadastro.TipoDocumento))
        objGrid_Coluna_Add(grdListagem, "Nome da Forma de Pagamento", 400, , True, , , , , , 100)
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        Me.Text = "Cadastro de Cargo"

        lblRotuloListagem.Text = "Listagem de Cargo"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CARGO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Cargo", 400, , True, , , , , , 50)
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
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        Me.Text = "Cadastro de Cargo"

        lblRotuloListagem.Text = "Listagem de Cargo"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CARGO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Cargo", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        Me.Text = "Cadastro de Tipo de Endereço"

        lblRotuloListagem.Text = "Listagem de Tipo de Endereço"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_ENDERECO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Endereço", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroTipoEscolaridade
        Me.Text = "Cadastro de Tipo de Escolaridade"

        lblRotuloListagem.Text = "Listagem de Tipo de Escolaridade"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_ESCOLARIDADE", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Escolaridade", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoEstadoCivil
        Me.Text = "Cadastro de Tipo de Escolaridade"

        lblRotuloListagem.Text = "Listagem de Tipo de Estado Cívil"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_ESTADOCIVIL", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Estado Cívil", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        Me.Text = "Cadastro de Tipo de Mídia Social"

        lblRotuloListagem.Text = "Listagem de Tipo de Mídia Social"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_MIDIASOCIAL", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Mídia Social", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroTipoPaciente
        Me.Text = "Cadastro de Tipo de Paciente"

        lblRotuloListagem.Text = "Listagem de Tipo de Paciente"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_PACIENTE", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Paciente", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        Me.Text = "Cadastro de Tipo de Pessoa"

        lblRotuloListagem.Text = "Listagem de Tipo de Pessoa"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_PESSOA", 0)
        objGrid_Coluna_Add(grdListagem, "Físico/Jurídico", 100, , True, , FNC_CarregarLista(enTipoCadastro.FisicoJuridico))
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Pessoa", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
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
      Case enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa
        Me.Text = "Cadastro de Tipo de Referência de Pessoa"

        lblRotuloListagem.Text = "Listagem de Tipo de Referência de Pessoa"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_REFERENCIAPESSOA", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Pessoa", 100, , True, , FNC_CarregarLista(enTipoCadastro.TipoPessoa))
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Referência de Pessoa", 400, , True)
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        Me.Text = "Cadastro de Tipo de Religião"

        lblRotuloListagem.Text = "Listagem de Tipo de Religião"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_RELIGIAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Religião", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoSexo
        Me.Text = "Cadastro de Tipo de Sexo"

        lblRotuloListagem.Text = "Listagem de Tipo de Sexo"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_SEXO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Sexo", 400, , True, , , , , , 50)
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
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "IC_SISTEMA", 0)
      Case enListagemGeral_TipoTela.CadastroTipoContaFinanceira
        Me.Text = "Cadastro de Tipo de Conta Bancária"

        lblRotuloListagem.Text = "Listagem de Tipo de Conta Bancária"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CONTAFINANCEIRA", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Conta Bancária", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoConsulta
        Me.Text = "Cadastro de Tipo de Consulta"

        lblRotuloListagem.Text = "Listagem de Tipo de Consulta"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_CONSULTA", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Consulta", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        Me.Text = "Cadastro de Natureza de Operação"

        lblRotuloListagem.Text = "Listagem de Natureza de Operação"
        objGrid_Coluna_Add(grdListagem, "SQ_NATUREZAOPERACAO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome da Natureza de Operação", 400)
        objGrid_Coluna_Add(grdListagem, "C.F.O.P.", 100)
        objGrid_Coluna_Add(grdListagem, "Ação no Financeiro", 150)
        objGrid_Coluna_Add(grdListagem, "Ação no Estoque", 150)
        objGrid_Coluna_Add(grdListagem, "Plano de Contas", 150)
        objGrid_Coluna_Add(grdListagem, "Finalidade", 150)
        objGrid_Coluna_Add(grdListagem, "Base ICMS (%)", 150, , , ColumnStyle.Double, , const_Formato_Fracao_4casas)
        objGrid_Coluna_Add(grdListagem, "Base ICMS ST (%)", 150, , , ColumnStyle.Double, , const_Formato_Fracao_4casas)
        objGrid_Coluna_Add(grdListagem, "Calcular IPI?", 70)
        objGrid_Coluna_Add(grdListagem, "Referência", 70)
        objGrid_Coluna_Add(grdListagem, "Permite Crédito de ICMS?", 70)
        objGrid_Coluna_Add(grdListagem, "Destaca Imp. Fed., Est. e Munic.", 70)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70)
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
        objGrid_Coluna_Add(grdListagem, "Estoque de Crédito", 150, , True, , FNC_CarregarLista(enTipoCadastro.Estoque))
        objGrid_Coluna_Add(grdListagem, "Estoque de Débito", 150, , True, , FNC_CarregarLista(enTipoCadastro.Estoque))
        objGrid_Coluna_Add(grdListagem, "Código da Transação de Estoque", 100, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Transação de Estoque", 300, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Usar no Recebimento", 150, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Usar na Venda", 120, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Usar na Movimentação de Estoque", 220, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        Me.Text = "Cadastro de Motivo da Doença"

        lblRotuloListagem.Text = "Listagem de Motivo da Doença"
        objGrid_Coluna_Add(grdListagem, "SQ_DOENCA_ESTAGIO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Motivo da Doença", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroTipoServico
        Me.Text = "Cadastro de Tipo de Serviço"

        lblRotuloListagem.Text = "Listagem de Motivo da Doença"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_SERVICO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Tipo de Serviço", 400, , True, , , , , , 50)
      Case enListagemGeral_TipoTela.CadastroServico
        Me.Text = "Cadastro de Serviço"

        lblRotuloListagem.Text = "Listagem de Serviço"
        objGrid_Coluna_Add(grdListagem, "SQ_TIPO_SERVICO", 0)
        objGrid_Coluna_Add(grdListagem, "Tipo de Serviço", 150, , True, , FNC_CarregarLista(enTipoCadastro.TipoServico))
        objGrid_Coluna_Add(grdListagem, "Código do Serviço", 100, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Serviço", 300, , True, , , , , , 100)
        objGrid_Coluna_Add(grdListagem, "Gera Financeiro", 150, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        Me.Text = "Cadastro de Grupo de Plano de Contas"

        lblRotuloListagem.Text = "Listagem de Grupo de Plano de Contas"
        objGrid_Coluna_Add(grdListagem, "SQ_PLANOCONTAS_GRUPO", 0)
        objGrid_Coluna_Add(grdListagem, "Grupo de Plano de Contas Superior", 300, , True, , FNC_CarregarLista(enTipoCadastro.PlanoContasGrupo))
        objGrid_Coluna_Add(grdListagem, "Código do Plano de Contas", 200, , True, , , , , , 10)
        objGrid_Coluna_Add(grdListagem, "Nome do Plano de Contas", 300, , True, , , , , , 100)
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar
        Me.Text = "Cadastro de Segmento"

        lblRotuloListagem.Text = "Listagem de Segmento"
        objGrid_Coluna_Add(grdListagem, "SQ_SEGMENTO", 0)
        objGrid_Coluna_Add(grdListagem, "Nome do Segmento", 400, , True, , , , , , 50)
        objGrid_Coluna_Add(grdListagem, "Ativo", 70, , True, ColumnStyle.CheckBox)
    End Select

    'Botaões de edição do modo somente listagem
    cmdNovo.Visible = (eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroNaturezaOperacao Or _
                       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroTabelaPreco Or _
                       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroEstoque Or _
                       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura Or _
                       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho Or _
                       eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape)
    cmdAlterar.Visible = (eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroNaturezaOperacao Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroTabelaPreco Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroEstoque Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape)
    cmdExcluir.Visible = (eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroNaturezaOperacao Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroTabelaPreco Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroEstoque Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho Or _
                          eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape)

    lblRotuloListagem.Tag = lblRotuloListagem.Text

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

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        sSqlText = "SELECT SQ_PLANOCONTAS," & _
                          "ID_PLANOCONTAS_GRUPO," & _
                          "CD_PLANOCONTAS," & _
                          "NO_PLANOCONTAS," & _
                          "ID_OPT_CREDITODEBITO," & _
                          "ID_OPT_TIPOCUSTO," & _
                          "IIF(IC_ATIVO = 'S', 1, 0)" & _
                   " FROM TB_PLANOCONTAS" & _
                   " ORDER BY ID_OPT_CREDITODEBITO, CD_PLANOCONTAS"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridPlanoContas_SQ_PLANOCONTAS, _
                                                               const_GridPlanoContas_GrupoPlanoContas, _
                                                               const_GridPlanoContas_CodigoPlanoContas, _
                                                               const_GridPlanoContas_NomePlanoContas, _
                                                               const_GridPlanoContas_CreditoDebito, _
                                                               const_GridPlanoContas_TipoCusto, _
                                                               const_GridPlanoContas_Ativo})
      Case enListagemGeral_TipoTela.CadastroProfissao
        sSqlText = "SELECT SQ_PROFISSAO," & _
                          "NO_PROFISSAO" & _
                   " FROM TB_PROFISSAO" & _
                   " ORDER BY NO_PROFISSAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridProfissao_SQ_PROFISSAO, _
                                                               const_GridProfissao_NomeProfissao})
      Case enListagemGeral_TipoTela.CadastroTipoServico
        sSqlText = "SELECT SQ_TIPO_SERVICO," & _
                          "NO_TIPO_SERVICO" & _
                   " FROM TB_TIPO_SERVICO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY NO_TIPO_SERVICO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoServico_SQ_TIPO_SERVICO, _
                                                               const_GridTipoServico_NomeTipoServico})
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar
        sSqlText = "SELECT SQ_SEGMENTO," & _
                          "NO_SEGMENTO," & _
                          "IIF(IC_ATIVO = 'S', 1, 0)" & _
                   " FROM TB_SEGMENTO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                     " AND ID_TIPOSEGMENTO = " & enOpcoes.TipoSegmento_ContasReceberContasPagar.GetHashCode & _
                   " ORDER BY NO_SEGMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridSegmento_SQ_SEGMENTO, _
                                                               const_GridSegmento_NomeSegmento, _
                                                               const_GridSegmento_Ativo})
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        sSqlText = "SELECT SQ_DOENCA_ESTAGIO," & _
                          "NO_DOENCA_ESTAGIO" & _
                   " FROM TB_DOENCA_ESTAGIO" & _
                   " ORDER BY NO_DOENCA_ESTAGIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO, _
                                                               const_GridDoencaEstagio_DoencaEstagio})
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        sSqlText = "SELECT SQ_TIPO_SERVICO," & _
                          "NO_TIPO_SERVICO" & _
                   " FROM TB_TIPO_SERVICO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY NO_TIPO_SERVICO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoServico_SQ_TIPO_SERVICO, _
                                                               const_GridTipoServico_NomeTipoServico})
      Case enListagemGeral_TipoTela.CadastroCargo
        sSqlText = "SELECT SQ_TIPO_CARGO," & _
                          "NO_TIPO_CARGO" & _
                   " FROM TB_TIPO_CARGO" & _
                   " ORDER BY NO_TIPO_CARGO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCargo_SQ_TIPO_CARGO, _
                                                               const_GridCargo_NomeCargo})
      Case enListagemGeral_TipoTela.CadastroCidade
        sSqlText = "SELECT SQ_CIDADE," & _
                          "ID_UF," & _
                          "NO_CIDADE," & _
                          "CD_IBGE" & _
                   " FROM TB_CIDADE" & _
                   " ORDER BY NO_CIDADE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridCidade_SQ_CIDADE, _
                                                               const_GridCidade_UF, _
                                                               const_GridCidade_NomeCidade, _
                                                               const_GridCidade_CodigoIBGE})
      Case enListagemGeral_TipoTela.CadastroUF
        sSqlText = "SELECT SQ_UF," & _
                          "ID_PAIS," & _
                          "NO_UF," & _
                          "CD_UF" & _
                   " FROM TB_UF" & _
                   " ORDER BY NO_UF"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridUF_SQ_UF, _
                                                               const_GridUF_Pais, _
                                                               const_GridUF_NomeUF, _
                                                               const_GridUF_CodigoUF})
      Case enListagemGeral_TipoTela.CadastroPais
        sSqlText = "SELECT SQ_PAIS," & _
                          "NO_PAIS," & _
                          "NO_NACIONALIDADE," & _
                          "IC_SISTEMA" & _
                   " FROM TB_PAIS" & _
                   " ORDER BY NO_PAIS"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridPais_SQ_PAIS, _
                                                               const_GridPais_NomePais, _
                                                               const_GridPais_NomeNascionalidade, _
                                                               const_GridPais_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroConvenio
        sSqlText = "SELECT SQ_CONVENIO," & _
                          "NO_CONVENIO," & _
                          "CD_CONTRATO," & _
                          "IIF(IC_ATIVO = 'S', 1, 0)" & _
                   " FROM TB_CONVENIO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY NO_CONVENIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridConvenio_SQ_CONVENIO, _
                                                               const_GridConvenio_NomeConvenio, _
                                                               const_GridConvenio_CodigoContrato, _
                                                               const_GridConvenio_Ativo})
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        sSqlText = "SELECT SQ_GRUPOPRODUTO," & _
                          "NO_GRUPOPRODUTO," & _
                          "ID_CFOP_PADRAO," & _
                          "ID_CST_PADRAO," & _
                          "ID_CSOSN_PADRAO," & _
                          "IIF(IC_CONTROLA_ESTOQUE = 'S', 1, 0)," & _
                          "IIF(IC_CONTROLE_GARANTIA = 'S', 1, 0)," & _
                          "IIF(IC_CONTROLA_NUMERO_SERIE = 'S', 1, 0)," & _
                          "IIF(IC_ATIVO = 'S', 1, 0)" & _
                   " FROM TB_GRUPOPRODUTO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY NO_GRUPOPRODUTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridGrupoProduto_SQ_GRUPOPRODUTO, _
                                                               const_GridGrupoProduto_NomeGrupoProduto, _
                                                               const_GridGrupoProduto_CFOP_Padrao, _
                                                               const_GridGrupoProduto_CTS_Padrao, _
                                                               const_GridGrupoProduto_CSOSN_Padrao, _
                                                               const_GridGrupoProduto_ControlaEstoque, _
                                                               const_GridGrupoProduto_ControlaGarantia, _
                                                               const_GridGrupoProduto_ControlaNumeroSerie, _
                                                               const_GridGrupoProduto_Ativo})
      Case enListagemGeral_TipoTela.CadastroUnidadeMedida
        sSqlText = "SELECT SQ_UNIDADEMEDIDA," & _
                          "NO_UNIDADEMEDIDA," & _
                          "CD_UNIDADEMEDIDA," & _
                          "CD_UNIDADEMEDIDA_COMPATIVEL" & _
                   " FROM TB_UNIDADEMEDIDA" & _
                   " ORDER BY NO_UNIDADEMEDIDA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridUnidadeMedida_SQ_UNIDADEMEDIDA, _
                                                               const_GridUnidadeMedida_NomeUnidadeMedida, _
                                                               const_GridUnidadeMedida_CodigoUnidadeMedida, _
                                                               const_GridUnidadeMedida_CodigoUnidadeMedidaCompativel})
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        sSqlText = "SELECT SQ_ESPECIALIDADE," & _
                          "NO_ESPECIALIDADE" & _
                   " FROM TB_ESPECIALIDADE" & _
                   " ORDER BY NO_ESPECIALIDADE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridEspecialidade_SQ_ESPECIALIDADE, _
                                                               const_GridEspecialidade_NomeEspecialidade})
      Case enListagemGeral_TipoTela.CadastroGrupoPermissao
        sSqlText = "SELECT SQ_GRUPOPERMISSAO," & _
                          "NO_GRUPOPERMISSAO" & _
                   " FROM TB_SEG_GRUPOPERMISSAO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                     " AND IC_SISTEMA = 'N'" & _
                   " ORDER BY NO_GRUPOPERMISSAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridGrupoPermissao_SQ_GRUPOPERMISSAO, _
                                                               const_GridGrupoPermissao_NomeGrupoPermissao})
      Case enListagemGeral_TipoTela.CadastroBanco
        sSqlText = "SELECT SQ_BANCO," & _
                          "NO_BANCO," & _
                          "NR_BANCO" & _
                   " FROM TB_BANCO" & _
                   " ORDER BY NO_BANCO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridBanco_SQ_BANCO, _
                                                               const_GridBanco_NomeBanco, _
                                                               const_GridBanco_NumeroBanco})
      Case enListagemGeral_TipoTela.CadastroContaBancaria
        sSqlText = "SELECT CB.SQ_CONTAFINANCEIRA," & _
                          "CB.ID_TIPO_CONTAFINANCEIRA," & _
                          "CB.ID_BANCO," & _
                          "CB.NR_AGENCIA," & _
                          "CB.NR_CONTA," & _
                          "CB.NR_CONTA_DIGITO," & _
                          "CB.DT_ABERTURA," & _
                          "IIF(CB.IC_CONTROLASALDO = 'S', 1, 0)," & _
                          "IIF(CB.IC_ATIVO = 'S', 1, 0)" & _
                   " FROM TB_CONTAFINANCEIRA CB" & _
                   " WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY dbo.FC_BANCO_CONTA_DESCRICAO(CB.ID_BANCO, CB.NR_AGENCIA, CB.NR_CONTA, CB.NR_CONTA_DIGITO)"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridContaBancaria_SQ_CONTABANCARIA, _
                                                               const_GridContaBancaria_TipoConta, _
                                                               const_GridContaBancaria_Banco, _
                                                               const_GridContaBancaria_NumeroAgencia, _
                                                               const_GridContaBancaria_NumeroConta, _
                                                               const_GridContaBancaria_DigitoConta, _
                                                               const_GridContaBancaria_DtAbetura, _
                                                               const_GridContaBancaria_ControlaSaldo, _
                                                               const_GridContaBancaria_Ativo})
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        sSqlText = "SELECT CC.SQ_CONTAFINANCEIRA," & _
                          "CC.ID_DEPARTAMENTO_RESPONSAVEL," & _
                          "CC.NO_CONTAFINANCEIRA," & _
                          "IIF(CC.IC_CONTROLASALDO = 'S', 1, 0)," & _
                          "IIF(CC.IC_ATIVO = 'S', 1, 0)," & _
                          "CC.IC_SISTEMA" & _
                   " FROM TB_CONTAFINANCEIRA CC" & _
                    " INNER JOIN TB_DEPARTAMENTO DP ON DP.SQ_DEPARTAMENTO = CC.ID_DEPARTAMENTO_RESPONSAVEL" & _
                                                 " AND DP.ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY CC.NO_CONTAFINANCEIRA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridContaCaixa_SQ_CONTACAIXA, _
                                                               const_GridContaCaixa_Departamento, _
                                                               const_GridContaCaixa_NomeCaixa, _
                                                               const_GridContaCaixa_ControlaSaldo, _
                                                               const_GridContaCaixa_Ativo, _
                                                               const_GridContaCaixa_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        sSqlText = "SELECT SQ_FORMAPAGAMENTO," & _
                          "ID_TIPO_DOCUMENTO," & _
                          "NO_FORMAPAGAMENTO" & _
                   " FROM TB_FORMAPAGAMENTO" & _
                   " ORDER BY NO_FORMAPAGAMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridFormaPagamento_SQ_FORMAPAGAMENTO, _
                                                               const_GridFormaPagamento_TipoDocumento, _
                                                               const_GridFormaPagamento_NomeFormaPagamento})
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        sSqlText = "SELECT SQ_TIPO_CARGO," & _
                          "NO_TIPO_CARGO" & _
                   " FROM TB_TIPO_CARGO" & _
                   " ORDER BY NO_TIPO_CARGO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoCargo_SQ_TIPO_CARGO, _
                                                               const_GridTipoCargo_NomeTipoCargo})
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        sSqlText = "SELECT SQ_TIPO_CONTATO," & _
                          "NO_TIPO_CONTATO," & _
                          "IC_SISTEMA" & _
                   " FROM TB_TIPO_CONTATO" & _
                   " ORDER BY NO_TIPO_CONTATO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoContato_SQ_TIPO_CONTATO, _
                                                               const_GridTipoContato_NomeTipoContato, _
                                                               const_GridTipoContato_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoDocumento
        sSqlText = "SELECT SQ_TIPO_DOCUMENTO," & _
                          "NO_TIPO_DOCUMENTO" & _
                   " FROM TB_TIPO_DOCUMENTO" & _
                   " ORDER BY NO_TIPO_DOCUMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoDocumento_SQ_TIPO_DOCUMENTO, _
                                                               const_GridTipoDocumento_NomeTipoDocumento})
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        sSqlText = "SELECT SQ_TIPO_ENDERECO," & _
                          "NO_TIPO_ENDERECO," & _
                          "IC_SISTEMA" & _
                   " FROM TB_TIPO_ENDERECO" & _
                   " ORDER BY NO_TIPO_ENDERECO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoEndereco_SQ_TIPO_ENDERECO, _
                                                               const_GridTipoEndereco_NomeTipoEndereco, _
                                                               const_GridTipoEndereco_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoEscolaridade
        sSqlText = "SELECT SQ_TIPO_ESCOLARIDADE," & _
                          "NO_TIPO_ESCOLARIDADE" & _
                   " FROM TB_TIPO_ESCOLARIDADE" & _
                   " ORDER BY NO_TIPO_ESCOLARIDADE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE, _
                                                               const_GridTipoEscolaridade_NomeTipoEscolaridade})
      Case enListagemGeral_TipoTela.CadastroTipoEstadoCivil
        sSqlText = "SELECT SQ_TIPO_ESTADOCIVIL," & _
                          "NO_TIPO_ESTADOCIVIL" & _
                   " FROM TB_TIPO_ESTADOCIVIL" & _
                   " ORDER BY NO_TIPO_ESTADOCIVIL"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL, _
                                                               const_GridTipoEstadoCivil_NomeEstadoCivil})
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        sSqlText = "SELECT SQ_TIPO_MIDIASOCIAL," & _
                          "NO_TIPO_MIDIASOCIAL," & _
                          "IC_SISTEMA" & _
                   " FROM TB_TIPO_MIDIASOCIAL" & _
                   " ORDER BY NO_TIPO_MIDIASOCIAL"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL, _
                                                               const_GridTipoMidiaSocial_NomeMidiaSocial, _
                                                               const_GridTipoMidiaSocial_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoPaciente
        sSqlText = "SELECT SQ_TIPO_PACIENTE," & _
                          "NO_TIPO_PACIENTE" & _
                   " FROM TB_TIPO_PACIENTE" & _
                   " ORDER BY NO_TIPO_PACIENTE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoPaciente_SQ_TIPO_PACIENTE, _
                                                               const_GridTipoPaciente_NomeTipoPaciente})
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        sSqlText = "SELECT SQ_TIPO_PESSOA," & _
                          "ID_OPT_FISICO_JURIDICO," & _
                          "NO_TIPO_PESSOA" & _
                   " FROM TB_TIPO_PESSOA" & _
                   " ORDER BY ID_OPT_FISICO_JURIDICO, NO_TIPO_PESSOA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoPessoa_SQ_TIPO_PESSOA, _
                                                               const_GridTipoPessoa_FisicoJuridico, _
                                                               const_GridTipoPessoa_NomeTipoPessoa})
      Case enListagemGeral_TipoTela.CadastroTipoProduto
        sSqlText = "SELECT SQ_TIPO_PRODUTO," & _
                          "NO_TIPO_PRODUTO" & _
                   " FROM TB_TIPO_PRODUTO" & _
                   " ORDER BY NO_TIPO_PRODUTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoProduto_SQ_TIPO_PRODUTO, _
                                                               const_GridTipoProduto_NomeTipoProduto})
      Case enListagemGeral_TipoTela.CadastroTipoQuestionario
        sSqlText = "SELECT SQ_TIPO_QUESTIONARIO," & _
                          "NO_TIPO_QUESTIONARIO," & _
                          "ID_OPT_TIPOCAMPO" & _
                   " FROM TB_TIPO_QUESTIONARIO" & _
                   " ORDER BY NO_TIPO_QUESTIONARIO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO, _
                                                               const_GridTipoQuestionario_NomeTipoQuestionario, _
                                                               const_GridTipoQuestionario_TipoCampo})
      Case enListagemGeral_TipoTela.CadastroTipoRaca
        sSqlText = "SELECT SQ_TIPO_RACA," & _
                          "NO_TIPO_RACA" & _
                   " FROM TB_TIPO_RACA" & _
                   " ORDER BY NO_TIPO_RACA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoRaca_SQ_TIPO_RACA, _
                                                               const_GridTipoRaca_NomeTipoRaca})
      Case enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa
        sSqlText = "SELECT SQ_TIPO_REFERENCIAPESSOA," & _
                          "ID_TIPO_PESSOA," & _
                          "NO_TIPO_REFERENCIAPESSOA" & _
                   " FROM TB_TIPO_REFERENCIAPESSOA" & _
                   " ORDER BY ID_TIPO_PESSOA, NO_TIPO_REFERENCIAPESSOA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA, _
                                                               const_GridTipoReferenciaPessoal_TipoPessoa, _
                                                               const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa})
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        sSqlText = "SELECT SQ_TIPO_RELIGIAO," & _
                          "NO_TIPO_RELIGIAO" & _
                   " FROM TB_TIPO_RELIGIAO" & _
                   " ORDER BY NO_TIPO_RELIGIAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoReligiao_SQ_TIPO_RELIGIAO, _
                                                               const_GridTipoReligiao_NomeTipoReligiao})
      Case enListagemGeral_TipoTela.CadastroTipoSexo
        sSqlText = "SELECT SQ_TIPO_SEXO," & _
                          "NO_TIPO_SEXO" & _
                   " FROM TB_TIPO_SEXO" & _
                   " ORDER BY NO_TIPO_SEXO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoSexo_SQ_TIPO_SEXO, _
                                                               const_GridTipoSexo_NomeTipoSexo})
      Case enListagemGeral_TipoTela.CadastroTipoTelefone
        sSqlText = "SELECT SQ_TIPO_TELEFONE," & _
                          "NO_TIPO_TELEFONE" & _
                   " FROM TB_TIPO_TELEFONE" & _
                   " ORDER BY NO_TIPO_TELEFONE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoTelefone_SQ_TIPO_TELEFONE, _
                                                               const_GridTipoTelefone_NomeTipoTelefone})
      Case enListagemGeral_TipoTela.CadastroDepartamento
        sSqlText = "SELECT SQ_DEPARTAMENTO," & _
                          "NO_DEPARTAMENTO," & _
                          "IIF(IC_ATIVO = 'S', 1, 0)," & _
                          "IC_SISTEMA" & _
                   " FROM TB_DEPARTAMENTO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY NO_DEPARTAMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridDepartamento_SQ_DEPARTAMENTO, _
                                                               const_GridDepartamento_NomeDepartamento, _
                                                               const_GridDepartamento_Ativo, _
                                                               const_GridDepartamento_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoContaFinanceira
        sSqlText = "SELECT SQ_TIPO_CONTAFINANCEIRA," & _
                          "NO_TIPO_CONTAFINANCEIRA" & _
                   " FROM TB_TIPO_CONTAFINANCEIRA" & _
                   " WHERE ISNULL(IC_INTERNO, 'N') = 'N'" & _
                   " ORDER BY NO_TIPO_CONTAFINANCEIRA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA, _
                                                               const_GridTipoContaFinanceira_NomeTipoContaBancaria})
      Case enListagemGeral_TipoTela.CadastroTipoContato
        sSqlText = "SELECT SQ_TIPO_CONTATO," & _
                          "NO_TIPO_CONTATO," & _
                          "IC_SISTEMA" & _
                   " FROM TB_TIPO_CONTATO" & _
                   " ORDER BY NO_TIPO_CONTATO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoContato_SQ_TIPO_CONTATO, _
                                                               const_GridTipoContato_NomeTipoContato, _
                                                               const_GridTipoContato_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroTipoConsulta
        sSqlText = "SELECT SQ_TIPO_CONSULTA," & _
                          "NO_TIPO_CONSULTA," & _
                          "IC_ATIVO" & _
                   " FROM TB_TIPO_CONSULTA" & _
                   " ORDER BY NO_TIPO_CONSULTA"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTipoConsulta_SQ_TIPO_CONSULTA, _
                                                               const_GridTipoConsulta_NO_TIPO_CONSULTA, _
                                                               const_GridTipoConsulta_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        sSqlText = "SELECT NOP.SQ_NATUREZAOPERACAO," & _
                          "NOP.NO_NATUREZAOPERACAO," & _
                          "CFO.CD_CFOP," & _
                          "OAF.NO_OPCAO NO_ACAO_FINANCEIRO," & _
                          "OAE.NO_OPCAO NO_ACAO_ESTOQUE," & _
                          "PLC.NO_CODIGO_PLANOCONTAS," & _
                          "OFN.NO_OPCAO NO_FINALIDADE," & _
                          "NOP.PC_BASEICMS," & _
                          "NOP.PC_BASEICMS_ST," & _
                          "IIF(NOP.IC_CALCULA_IPI = 'S', 'Sim', 'Não')," & _
                          "IIF(NOP.IC_REFERENCIA = 'S', 'Sim', 'Não')," & _
                          "IIF(NOP.IC_CREDITO_ICMS = 'S', 'Sim', 'Não')," & _
                          "IIF(NOP.IC_DESTACA_IMPOSTOS = 'S', 'Sim', 'Não')," & _
                          "IIF(NOP.IC_ATIVO = 'S', 'Sim', 'Não')" & _
                   " FROM TB_NATUREZAOPERACAO NOP" & _
                     " LEFT JOIN TB_CFOP CFO ON NOP.ID_CFOP = CFO.SQ_CFOP" & _
                     " LEFT JOIN TB_OPCAO OAF ON NOP.ID_OPT_FINANCEIRO = OAF.SQ_OPCAO" & _
                     " LEFT JOIN TB_OPCAO OAE ON NOP.ID_OPT_ESTOQUE = OAE.SQ_OPCAO" & _
                     " LEFT JOIN TB_OPCAO OFN ON NOP.ID_OPT_FINALIDADE = OFN.SQ_OPCAO" & _
                     " LEFT JOIN VW_PLANOCONTAS PLC ON NOP.ID_PLANOCONTAS = PLC.SQ_PLANOCONTAS" & _
                   " ORDER BY NO_NATUREZAOPERACAO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridNaturezaOperacao_SQ_NATUREZAOPERACAO, _
                                                               const_GridNaturezaOperacao_NomeNaturezaOperacao, _
                                                               const_GridNaturezaOperacao_CFOP, _
                                                               const_GridNaturezaOperacao_AcaoFinanceiro, _
                                                               const_GridNaturezaOperacao_AcaoEstoque, _
                                                               const_GridNaturezaOperacao_PlanoContas, _
                                                               const_GridNaturezaOperacao_Finalidade, _
                                                               const_GridNaturezaOperacao_BaseICMS, _
                                                               const_GridNaturezaOperacao_BaseICMSST, _
                                                               const_GridNaturezaOperacao_CalcularIPI, _
                                                               const_GridNaturezaOperacao_Referencia, _
                                                               const_GridNaturezaOperacao_PermiteCreditoICMS, _
                                                               const_GridNaturezaOperacao_DestacaImpFedEstMunic, _
                                                               const_GridNaturezaOperacao_Ativo})
      Case enListagemGeral_TipoTela.CadastroTabelaPreco
        sSqlText = "SELECT SQ_TABELAPRECO," & _
                          "NO_TABELAPRECO," & _
                          "DT_INICIO_USO," & _
                          "DT_FIM_USO," & _
                          "DT_ULTIMO_REAJUSTE," & _
                          "PC_DESCONTO_MAXIMO," & _
                          "PC_MARGEM_LUCRO," & _
                          "PC_COMISSAO," & _
                          "IIF(ISNULL(IC_DISPONIVEL_FILIAL, 'N') = 'S', 'Sim', 'Não')" & _
                   " FROM TB_TABELAPRECO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY NO_TABELAPRECO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTabelaPreco_SQ_TABELAPRECO, _
                                                               const_GridTabelaPreco_NO_TABELAPRECO, _
                                                               const_GridTabelaPreco_DT_INICIO_USO, _
                                                               const_GridTabelaPreco_DT_FIM_USO, _
                                                               const_GridTabelaPreco_DT_ULTIMO_REAJUSTE, _
                                                               const_GridTabelaPreco_PC_DESCONTO_MAXIMO, _
                                                               const_GridTabelaPreco_PC_MARGEM_LUCRO, _
                                                               const_GridTabelaPreco_PC_COMISSAO, _
                                                               const_GridTabelaPreco_IC_DISPONIVEL_FILIAL})
      Case enListagemGeral_TipoTela.CadastroEstoque
        sSqlText = "SELECT EST.SQ_ESTOQUE," & _
                          "DEP.NO_DEPARTAMENTO," & _
                          "EST.CD_ESTOQUE," & _
                          "EST.NO_ESTOQUE," & _
                          "IIF(ISNULL(EST.IC_CONTROLA_MINIMOS, 'N') = 'S', 'Sim', 'Não')," & _
                          "IIF(ISNULL(EST.IC_PERMITE_BLOQUEIO, 'N') = 'S', 'Sim', 'Não')," & _
                          "IIF(ISNULL(EST.IC_ATIVO, 'N') = 'S', 'Sim', 'Não')," & _
                          "IIF(ISNULL(EST.IC_PERMITE_SALDO_NEGATIVO, 'N') = 'S', 'Sim', 'Não')," & _
                          "IIF(ISNULL(EST.IC_ENTRADA_AUTOMATICA, 'N') = 'S', 'Sim', 'Não')" & _
                   " FROM TB_ESTOQUE EST" & _
                    " INNER JOIN TB_DEPARTAMENTO DEP ON EST.ID_DEPARTAMENTO_RESPONSAVEL = DEP.SQ_DEPARTAMENTO" & _
                   " WHERE DEP.ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY EST.NO_ESTOQUE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridEstoque_SQ_ESTOQUE, _
                                                               const_GridEstoque_ID_DEPARTAMENTO_RESPONSAVEL, _
                                                               const_GridEstoque_CD_ESTOQUE, _
                                                               const_GridEstoque_NO_ESTOQUE, _
                                                               const_GridEstoque_IC_CONTROLA_MINIMOS, _
                                                               const_GridEstoque_IC_PERMITE_BLOQUEIO, _
                                                               const_GridEstoque_IC_ATIVO, _
                                                               const_GridEstoque_IC_PERMITE_SALDO_NEGATIVO, _
                                                               const_GridEstoque_IC_ENTRADA_AUTOMATICA})
      Case enListagemGeral_TipoTela.CadastroTransacaoEstoque
        sSqlText = "SELECT SQ_TRANSACAOESTOQUE," & _
                          "ID_ESTOQUE_CREDITO," & _
                          "ID_ESTOQUE_DEBITO," & _
                          "CD_TRANSACAOESTOQUE," & _
                          "NO_TRANSACAOESTOQUE," & _
                          "IIF(IC_USAR_RECEBIMENTO = 'S', 1, 0)," & _
                          "IIF(IC_USAR_VENDA = 'S', 1, 0)," & _
                          "IIF(IC_USAR_MOVIMENTACAOMANUAL = 'S', 1, 0)," & _
                          "IIF(IC_ATIVO = 'S', 1, 0)" & _
                   " FROM TB_TRANSACAOESTOQUE" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY NO_TRANSACAOESTOQUE"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridTransacaoEstoque_SQ_TRANSACAOESTOQUE, _
                                                               const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO, _
                                                               const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO, _
                                                               const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE, _
                                                               const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE, _
                                                               const_GridTransacaoEstoque_IC_USAR_RECEBIMENTO, _
                                                               const_GridTransacaoEstoque_IC_USAR_VENDA, _
                                                               const_GridTransacaoEstoque_IC_USAR_MOVIMENTACAOMANUAL, _
                                                               const_GridTransacaoEstoque_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroServico
        sSqlText = "SELECT SQ_SERVICO," & _
                          "ID_TIPO_SERVICO," & _
                          "CD_SERVICO," & _
                          "NO_SERVICO," & _
                          "IIF(IC_GERAFINANCEIRO = 'S', 1, 0)," & _
                          "IIF(IC_ATIVO = 'S', 1, 0)" & _
                   " FROM TB_SERVICO" & _
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & _
                   " ORDER BY NO_SERVICO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridServico_SQ_SERVICO, _
                                                               const_GridServico_ID_TIPO_SERVICO, _
                                                               const_GridServico_CD_SERVICO, _
                                                               const_GridServico_NO_SERVICO, _
                                                               const_GridServico_IC_GERAFINANCEIRO, _
                                                               const_GridServico_IC_ATIVO})
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        sSqlText = "SELECT SQ_MODELODOCUMENTO_ELEMENTO," & _
                          "NO_MODELODOCUMENTO_ELEMENTO," & _
                          "ISNULL(IC_SISTEMA, 'N')" & _
                   " FROM TB_MODELODOCUMENTO_ELEMENTO" & _
                   " WHERE (ID_EMPRESA = " & iID_EMPRESA_FILIAL & " OR ID_EMPRESA IS NULL)" & _
                     " AND ID_TIPO_ELEMENTO = " & IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, enOpcoes.TipoElementoModeloDocumento_Assinatura, _
                                                      IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, enOpcoes.TipoElementoModeloDocumento_Cabecalho, _
                                                                                                                                                        enOpcoes.TipoElementoModeloDocumento_Rodape)) & _
                   " ORDER BY ISNULL(IC_SISTEMA, 'N') DESC," & _
                             "NO_MODELODOCUMENTO_ELEMENTO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridModeloDocumentoElemento_SQ_MODELODOCUMENTO_ELEMENTO, _
                                                               const_GridModeloDocumentoElemento_NO_MODELODOCUMENTO_ELEMENTO, _
                                                               const_GridModeloDocumentoElemento_IC_SISTEMA})
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        sSqlText = "SELECT SQ_PLANOCONTAS_GRUPO," & _
                          "ID_PLANOCONTAS_GRUPO_SUPERIOR," & _
                          "CD_PLANOCONTAS_GRUPO," & _
                          "NO_PLANOCONTAS_GRUPO" & _
                   " FROM TB_PLANOCONTAS_GRUPO" & _
                   " ORDER BY CD_PLANOCONTAS_GRUPO"
        objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO, _
                                                               const_GridPlanoContasGrupo_ID_PLANOCONTAS_GRUPO_SUPERIOR, _
                                                               const_GridPlanoContasGrupo_CodigoGrupoProduto, _
                                                               const_GridPlanoContasGrupo_NomeGrupoProduto})
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

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_PLANOCONTAS_GRUPO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                                        "ID_PLANOCONTAS_GRUPO_SUPERIOR", "@ID_PLANOCONTAS_GRUPO_SUPERIOR", _
                                                                                        "CD_PLANOCONTAS_GRUPO", "@CD_PLANOCONTAS_GRUPO", _
                                                                                        "NO_PLANOCONTAS_GRUPO", "@NO_PLANOCONTAS_GRUPO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("ID_PLANOCONTAS_GRUPO_SUPERIOR", objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_ID_PLANOCONTAS_GRUPO_SUPERIOR, e.Row.Index)), _
                                            DBParametro_Montar("CD_PLANOCONTAS_GRUPO", Trim(objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_CodigoGrupoProduto, e.Row.Index))), _
                                            DBParametro_Montar("NO_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_NomeGrupoProduto, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_PLANOCONTAS_GRUPO", FNC_GerarArray("ID_PLANOCONTAS_GRUPO_SUPERIOR", "@ID_PLANOCONTAS_GRUPO_SUPERIOR", _
                                                                            "CD_PLANOCONTAS_GRUPO", "@CD_PLANOCONTAS_GRUPO", _
                                                                            "NO_PLANOCONTAS_GRUPO", "@NO_PLANOCONTAS_GRUPO"), _
                                                             FNC_GerarArray("SQ_PLANOCONTAS_GRUPO", "@SQ_PLANOCONTAS_GRUPO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_PLANOCONTAS_GRUPO_SUPERIOR", Trim(objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_ID_PLANOCONTAS_GRUPO_SUPERIOR, e.Row.Index))), _
                                            DBParametro_Montar("CD_PLANOCONTAS_GRUPO", Trim(objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_CodigoGrupoProduto, e.Row.Index))), _
                                            DBParametro_Montar("NO_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_NomeGrupoProduto, e.Row.Index)), _
                                            DBParametro_Montar("SQ_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO, e.Row.Index)))
        End If

        Formatar()
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridPlanoContas_SQ_PLANOCONTAS, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_PLANOCONTAS", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                                  "ID_PLANOCONTAS_GRUPO", "@ID_PLANOCONTAS_GRUPO", _
                                                                                  "CD_PLANOCONTAS", "@CD_PLANOCONTAS", _
                                                                                  "NO_PLANOCONTAS", "@NO_PLANOCONTAS", _
                                                                                  "ID_OPT_CREDITODEBITO", "@ID_OPT_CREDITODEBITO", _
                                                                                  "ID_OPT_TIPOCUSTO", "@ID_OPT_TIPOCUSTO", _
                                                                                  "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("ID_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContas_GrupoPlanoContas, e.Row.Index)), _
                                            DBParametro_Montar("CD_PLANOCONTAS", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_CodigoPlanoContas, e.Row.Index))), _
                                            DBParametro_Montar("NO_PLANOCONTAS", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_NomePlanoContas, e.Row.Index))), _
                                            DBParametro_Montar("ID_OPT_CREDITODEBITO", objGrid_Valor(grdListagem, const_GridPlanoContas_CreditoDebito, e.Row.Index)), _
                                            DBParametro_Montar("ID_OPT_TIPOCUSTO", objGrid_Valor(grdListagem, const_GridPlanoContas_TipoCusto, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridPlanoContas_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_PLANOCONTAS", FNC_GerarArray("ID_PLANOCONTAS_GRUPO", "@ID_PLANOCONTAS_GRUPO", _
                                                                      "CD_PLANOCONTAS", "@CD_PLANOCONTAS", _
                                                                      "NO_PLANOCONTAS", "@NO_PLANOCONTAS", _
                                                                      "ID_OPT_CREDITODEBITO", "@ID_OPT_CREDITODEBITO", _
                                                                      "ID_OPT_TIPOCUSTO", "@ID_OPT_TIPOCUSTO", _
                                                                      "IC_ATIVO", "@IC_ATIVO"), _
                                                       FNC_GerarArray("SQ_PLANOCONTAS", "@SQ_PLANOCONTAS"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_PLANOCONTAS_GRUPO", objGrid_Valor(grdListagem, const_GridPlanoContas_GrupoPlanoContas, e.Row.Index)), _
                                            DBParametro_Montar("CD_PLANOCONTAS", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_CodigoPlanoContas, e.Row.Index))), _
                                            DBParametro_Montar("NO_PLANOCONTAS", Trim(objGrid_Valor(grdListagem, const_GridPlanoContas_NomePlanoContas, e.Row.Index))), _
                                            DBParametro_Montar("ID_OPT_CREDITODEBITO", objGrid_Valor(grdListagem, const_GridPlanoContas_CreditoDebito, e.Row.Index)), _
                                            DBParametro_Montar("ID_OPT_TIPOCUSTO", objGrid_Valor(grdListagem, const_GridPlanoContas_TipoCusto, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridPlanoContas_Ativo, e.Row.Index)), _
                                            DBParametro_Montar("SQ_PLANOCONTAS", objGrid_Valor(grdListagem, const_GridPlanoContas_SQ_PLANOCONTAS, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroProfissao
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridProfissao_SQ_PROFISSAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_PROFISSAO", TipoCampoFixo.DadoCriacao, "NO_PROFISSAO", "@NO_PROFISSAO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_PROFISSAO", Trim(objGrid_Valor(grdListagem, const_GridProfissao_NomeProfissao, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_PROFISSAO", FNC_GerarArray("NO_PROFISSAO", "@NO_PROFISSAO"), _
                                                     FNC_GerarArray("SQ_PROFISSAO", "@SQ_PROFISSAO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_PROFISSAO", Trim(objGrid_Valor(grdListagem, const_GridProfissao_NomeProfissao, e.Row.Index))), _
                                            DBParametro_Montar("SQ_PROFISSAO", objGrid_Valor(grdListagem, const_GridProfissao_SQ_PROFISSAO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroDoencaEstagio
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_DOENCA_ESTAGIO", TipoCampoFixo.DadoCriacao, "NO_DOENCA_ESTAGIO", "@NO_DOENCA_ESTAGIO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_DOENCA_ESTAGIO", Trim(objGrid_Valor(grdListagem, const_GridDoencaEstagio_DoencaEstagio, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_DOENCA_ESTAGIO", FNC_GerarArray("NO_DOENCA_ESTAGIO", "@NO_DOENCA_ESTAGIO"), _
                                                          FNC_GerarArray("SQ_DOENCA_ESTAGIO", "@SQ_DOENCA_ESTAGIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_DOENCA_ESTAGIO", Trim(objGrid_Valor(grdListagem, const_GridDoencaEstagio_DoencaEstagio, e.Row.Index))), _
                                            DBParametro_Montar("SQ_DOENCA_ESTAGIO", objGrid_Valor(grdListagem, const_GridDoencaEstagio_SQ_DOENCA_ESTAGIO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoServico
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoServico_SQ_TIPO_SERVICO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_SERVICO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                                   "NO_TIPO_SERVICO", "@NO_TIPO_SERVICO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("NO_TIPO_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridTipoServico_NomeTipoServico, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_SERVICO", FNC_GerarArray("NO_TIPO_SERVICO", "@NO_TIPO_SERVICO"), _
                                                        FNC_GerarArray("SQ_DOENCA_ESTAGIO", "@SQ_DOENCA_ESTAGIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridTipoServico_NomeTipoServico, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_SERVICO", objGrid_Valor(grdListagem, const_GridTipoServico_SQ_TIPO_SERVICO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridSegmento_SQ_SEGMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_SEGMENTO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                               "ID_TIPOSEGMENTO", "@ID_TIPOSEGMENTO", _
                                                                               "NO_SEGMENTO", "@NO_SEGMENTO", _
                                                                               "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("ID_TIPOSEGMENTO", enOpcoes.TipoSegmento_ContasReceberContasPagar.GetHashCode), _
                                            DBParametro_Montar("NO_SEGMENTO", Trim(objGrid_Valor(grdListagem, const_GridSegmento_NomeSegmento, e.Row.Index))), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridSegmento_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_SEGMENTO", FNC_GerarArray("NO_SEGMENTO", "@NO_SEGMENTO", _
                                                                   "IC_ATIVO", "@IC_ATIVO"), _
                                                    FNC_GerarArray("SQ_SEGMENTO", "@SQ_SEGMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_SEGMENTO", Trim(objGrid_Valor(grdListagem, const_GridSegmento_NomeSegmento, e.Row.Index))), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridSegmento_Ativo, e.Row.Index)), _
                                            DBParametro_Montar("SQ_SEGMENTO", objGrid_Valor(grdListagem, const_GridSegmento_SQ_SEGMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoPermissao
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridGrupoPermissao_SQ_GRUPOPERMISSAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_SEG_GRUPOPERMISSAO", TipoCampoFixo.DadoCriacao, "NO_GRUPOPERMISSAO", "@NO_GRUPOPERMISSAO", _
                                                                                         "ID_EMPRESA", "@ID_EMPRESA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_GRUPOPERMISSAO", Trim(objGrid_Valor(grdListagem, const_GridGrupoPermissao_NomeGrupoPermissao, e.Row.Index))), _
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL))
        Else
          sSqlText = DBMontar_Update("TB_SEG_GRUPOPERMISSAO", FNC_GerarArray("NO_GRUPOPERMISSAO", "@NO_GRUPOPERMISSAO", _
                                                                             "ID_EMPRESA", "@ID_EMPRESA"), _
                                                              FNC_GerarArray("SQ_DOENCA_ESTAGIO", "@SQ_DOENCA_ESTAGIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_GRUPOPERMISSAO", Trim(objGrid_Valor(grdListagem, const_GridGrupoPermissao_NomeGrupoPermissao, e.Row.Index))), _
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("SQ_GRUPOPERMISSAO", objGrid_Valor(grdListagem, const_GridGrupoPermissao_SQ_GRUPOPERMISSAO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroCargo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridProfissao_SQ_PROFISSAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CARGO", TipoCampoFixo.DadoCriacao, "NO_TIPO_CARGO", "@NO_TIPO_CARGO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CARGO", Trim(objGrid_Valor(grdListagem, const_GridCargo_NomeCargo, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CARGO", FNC_GerarArray("NO_TIPO_CARGO", "@NO_TIPO_CARGO"), _
                                                      FNC_GerarArray("SQ_TIPO_CARGO", "@SQ_TIPO_CARGO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CARGO", Trim(objGrid_Valor(grdListagem, const_GridCargo_NomeCargo, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_CARGO", objGrid_Valor(grdListagem, const_GridCargo_SQ_TIPO_CARGO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroCidade
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridCidade_SQ_CIDADE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CIDADE", TipoCampoFixo.DadoCriacao, "ID_UF", "@ID_UF", _
                                                                             "NO_CIDADE", "@NO_CIDADE", _
                                                                             "CD_IBGE", "@CD_IBGE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_UF", objGrid_Valor(grdListagem, const_GridCidade_UF, e.Row.Index)), _
                                            DBParametro_Montar("NO_CIDADE", Trim(objGrid_Valor(grdListagem, const_GridCidade_NomeCidade, e.Row.Index))), _
                                            DBParametro_Montar("CD_IBGE", objGrid_Valor(grdListagem, const_GridCidade_CodigoIBGE, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CIDADE", FNC_GerarArray("ID_UF", "@ID_UF", _
                                                                 "NO_CIDADE", "@NO_CIDADE", _
                                                                 "CD_IBGE", "@CD_IBGE"), _
                                                  FNC_GerarArray("SQ_CIDADE", "@SQ_CIDADE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_UF", objGrid_Valor(grdListagem, const_GridCidade_UF, e.Row.Index)), _
                                            DBParametro_Montar("NO_CIDADE", Trim(objGrid_Valor(grdListagem, const_GridCidade_NomeCidade, e.Row.Index))), _
                                            DBParametro_Montar("CD_IBGE", Trim(objGrid_Valor(grdListagem, const_GridCidade_CodigoIBGE, e.Row.Index))), _
                                            DBParametro_Montar("SQ_CIDADE", objGrid_Valor(grdListagem, const_GridCidade_SQ_CIDADE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroUF
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridUF_SQ_UF, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_UF", TipoCampoFixo.DadoCriacao, "ID_PAIS", "@ID_PAIS", _
                                                                         "NO_UF", "@NO_UF", _
                                                                         "CD_UF", "@CD_UF")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_PAIS", objGrid_Valor(grdListagem, const_GridUF_Pais, e.Row.Index)), _
                                            DBParametro_Montar("NO_UF", Trim(objGrid_Valor(grdListagem, const_GridUF_NomeUF, e.Row.Index))), _
                                            DBParametro_Montar("CD_UF", Trim(objGrid_Valor(grdListagem, const_GridUF_CodigoUF, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_UF", FNC_GerarArray("ID_PAIS", "@ID_PAIS", _
                                                             "NO_UF", "@NO_UF", _
                                                             "CD_UF", "@CD_UF"), _
                                              FNC_GerarArray("SQ_UF", "@SQ_UF"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_PAIS", objGrid_Valor(grdListagem, const_GridUF_Pais, e.Row.Index)), _
                                            DBParametro_Montar("NO_UF", Trim(objGrid_Valor(grdListagem, const_GridUF_NomeUF, e.Row.Index))), _
                                            DBParametro_Montar("CD_UF", Trim(objGrid_Valor(grdListagem, const_GridUF_CodigoUF, e.Row.Index))), _
                                            DBParametro_Montar("SQ_UF", objGrid_Valor(grdListagem, const_GridUF_SQ_UF, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroPais
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridPais_SQ_PAIS, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_PAIS", TipoCampoFixo.DadoCriacao, "NO_PAIS", "@NO_PAIS", _
                                                                           "NO_NACIONALIDADE", "@NO_NACIONALIDADE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_PAIS", objGrid_Valor(grdListagem, const_GridPais_NomePais, e.Row.Index)), _
                                            DBParametro_Montar("NO_NACIONALIDADE", Trim(objGrid_Valor(grdListagem, const_GridPais_NomeNascionalidade, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_PAIS", FNC_GerarArray("NO_PAIS", "@NO_PAIS", _
                                                               "NO_NACIONALIDADE", "@NO_NACIONALIDADE"), _
                                                FNC_GerarArray("SQ_PAIS", "@SQ_PAIS"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_PAIS", objGrid_Valor(grdListagem, const_GridPais_NomePais, e.Row.Index)), _
                                            DBParametro_Montar("NO_NACIONALIDADE", Trim(objGrid_Valor(grdListagem, const_GridPais_NomeNascionalidade, e.Row.Index))), _
                                            DBParametro_Montar("SQ_PAIS", objGrid_Valor(grdListagem, const_GridPais_SQ_PAIS, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroConvenio
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridConvenio_SQ_CONVENIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CONVENIO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                               "NO_CONVENIO", "@NO_CONVENIO", _
                                                                               "CD_CONTRATO", "@CD_CONTRATO", _
                                                                               "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("NO_CONVENIO", objGrid_Valor(grdListagem, const_GridConvenio_NomeConvenio, e.Row.Index)), _
                                            DBParametro_Montar("CD_CONTRATO", objGrid_Valor(grdListagem, const_GridConvenio_CodigoContrato, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridConvenio_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CONVENIO", FNC_GerarArray("NO_CONVENIO", "@NO_CONVENIO", _
                                                                   "CD_CONTRATO", "@CD_CONTRATO", _
                                                                   "IC_ATIVO", "@IC_ATIVO"), _
                                                    FNC_GerarArray("SQ_CONVENIO", "@SQ_CONVENIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_CONVENIO", objGrid_Valor(grdListagem, const_GridConvenio_NomeConvenio, e.Row.Index)), _
                                            DBParametro_Montar("CD_CONTRATO", objGrid_Valor(grdListagem, const_GridConvenio_CodigoContrato, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridConvenio_Ativo, e.Row.Index)), _
                                            DBParametro_Montar("SQ_CONVENIO", objGrid_Valor(grdListagem, const_GridConvenio_SQ_CONVENIO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridConvenio_SQ_CONVENIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_GRUPOPRODUTO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                                   "NO_GRUPOPRODUTO", "@NO_GRUPOPRODUTO", _
                                                                                   "ID_CFOP_PADRAO", "@ID_CFOP_PADRAO", _
                                                                                   "ID_CST_PADRAO", "@ID_CST_PADRAO", _
                                                                                   "ID_CSOSN_PADRAO", "@ID_CSOSN_PADRAO", _
                                                                                   "IC_CONTROLA_ESTOQUE", "@IC_CONTROLA_ESTOQUE", _
                                                                                   "IC_CONTROLA_NUMERO_SERIE", "@IC_CONTROLA_NUMERO_SERIE", _
                                                                                   "IC_CONTROLE_GARANTIA", "@IC_CONTROLE_GARANTIA", _
                                                                                   "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("NO_GRUPOPRODUTO", objGrid_Valor(grdListagem, const_GridGrupoProduto_NomeGrupoProduto, e.Row.Index)), _
                                            DBParametro_Montar("ID_CFOP_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CFOP_Padrao, e.Row.Index)), _
                                            DBParametro_Montar("ID_CST_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_Padrao, e.Row.Index)), _
                                            DBParametro_Montar("ID_CSOSN_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CSOSN_Padrao, e.Row.Index)), _
                                            DBParametro_Montar("IC_CONTROLA_ESTOQUE", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaEstoque, e.Row.Index)), _
                                            DBParametro_Montar("IC_CONTROLA_NUMERO_SERIE", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaNumeroSerie, e.Row.Index)), _
                                            DBParametro_Montar("IC_CONTROLE_GARANTIA", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaGarantia, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_GRUPOPRODUTO", FNC_GerarArray("NO_GRUPOPRODUTO", "@NO_GRUPOPRODUTO", _
                                                                       "ID_CFOP_PADRAO", "@ID_CFOP_PADRAO", _
                                                                       "ID_CST_PADRAO", "@ID_CST_PADRAO", _
                                                                       "ID_CSOSN_PADRAO", "@ID_CSOSN_PADRAO", _
                                                                       "IC_CONTROLA_ESTOQUE", "@IC_CONTROLA_ESTOQUE", _
                                                                       "IC_CONTROLA_NUMERO_SERIE", "@IC_CONTROLA_NUMERO_SERIE", _
                                                                       "IC_CONTROLE_GARANTIA", "@IC_CONTROLE_GARANTIA", _
                                                                       "IC_ATIVO", "@IC_ATIVO"), _
                                                        FNC_GerarArray("SQ_GRUPOPRODUTO", "@SQ_GRUPOPRODUTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_GRUPOPRODUTO", objGrid_Valor(grdListagem, const_GridGrupoProduto_NomeGrupoProduto, e.Row.Index)), _
                                            DBParametro_Montar("ID_CFOP_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CFOP_Padrao, e.Row.Index)), _
                                            DBParametro_Montar("ID_CST_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CTS_Padrao, e.Row.Index)), _
                                            DBParametro_Montar("ID_CSOSN_PADRAO", objGrid_Valor(grdListagem, const_GridGrupoProduto_CSOSN_Padrao, e.Row.Index)), _
                                            DBParametro_Montar("IC_CONTROLA_ESTOQUE", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaEstoque, e.Row.Index)), _
                                            DBParametro_Montar("IC_CONTROLA_NUMERO_SERIE", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaNumeroSerie, e.Row.Index)), _
                                            DBParametro_Montar("IC_CONTROLE_GARANTIA", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_ControlaGarantia, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridGrupoProduto_Ativo, e.Row.Index)), _
                                            DBParametro_Montar("SQ_GRUPOPRODUTO", objGrid_Valor(grdListagem, const_GridGrupoProduto_SQ_GRUPOPRODUTO, e.Row.Index)))
        End If

        If Millenium_Interfaciar() Then
          Millenium_DBConectar()
          Millenium_InterfaceTodosGrupoProduto()
          Millenium_DBDesconectar()
        End If
      Case enListagemGeral_TipoTela.CadastroUnidadeMedida
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridUnidadeMedida_SQ_UNIDADEMEDIDA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_UNIDADEMEDIDA", TipoCampoFixo.DadoCriacao, "NO_UNIDADEMEDIDA", "@NO_UNIDADEMEDIDA", _
                                                                                    "CD_UNIDADEMEDIDA", "@CD_UNIDADEMEDIDA", _
                                                                                    "CD_UNIDADEMEDIDA_COMPATIVEL", "@CD_UNIDADEMEDIDA_COMPATIVEL")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_NomeUnidadeMedida, e.Row.Index)), _
                                            DBParametro_Montar("CD_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_CodigoUnidadeMedida, e.Row.Index)), _
                                            DBParametro_Montar("CD_UNIDADEMEDIDA_COMPATIVEL", objGrid_Valor(grdListagem, const_GridUnidadeMedida_CodigoUnidadeMedidaCompativel, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_UNIDADEMEDIDA", FNC_GerarArray("NO_UNIDADEMEDIDA", "@NO_UNIDADEMEDIDA", _
                                                                        "CD_UNIDADEMEDIDA", "@CD_UNIDADEMEDIDA", _
                                                                        "CD_UNIDADEMEDIDA_COMPATIVEL", "@CD_UNIDADEMEDIDA_COMPATIVEL"), _
                                                         FNC_GerarArray("SQ_UNIDADEMEDIDA", "@SQ_UNIDADEMEDIDA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_NomeUnidadeMedida, e.Row.Index)), _
                                            DBParametro_Montar("CD_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_CodigoUnidadeMedida, e.Row.Index)), _
                                            DBParametro_Montar("CD_UNIDADEMEDIDA_COMPATIVEL", objGrid_Valor(grdListagem, const_GridUnidadeMedida_CodigoUnidadeMedidaCompativel, e.Row.Index)), _
                                            DBParametro_Montar("SQ_UNIDADEMEDIDA", objGrid_Valor(grdListagem, const_GridUnidadeMedida_SQ_UNIDADEMEDIDA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroEspecialidade
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridEspecialidade_SQ_ESPECIALIDADE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_ESPECIALIDADE", TipoCampoFixo.DadoCriacao, "NO_ESPECIALIDADE", "@NO_ESPECIALIDADE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_ESPECIALIDADE", objGrid_Valor(grdListagem, const_GridEspecialidade_NomeEspecialidade, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_ESPECIALIDADE", FNC_GerarArray("NO_ESPECIALIDADE", "@NO_ESPECIALIDADE"), _
                                                         FNC_GerarArray("SQ_ESPECIALIDADE", "@SQ_ESPECIALIDADE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_ESPECIALIDADE", objGrid_Valor(grdListagem, const_GridEspecialidade_NomeEspecialidade, e.Row.Index)), _
                                            DBParametro_Montar("SQ_ESPECIALIDADE", objGrid_Valor(grdListagem, const_GridEspecialidade_SQ_ESPECIALIDADE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroBanco
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridBanco_SQ_BANCO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_BANCO", TipoCampoFixo.DadoCriacao, "NO_BANCO", "@NO_BANCO", _
                                                                            "NR_BANCO", "@NR_BANCO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_BANCO", objGrid_Valor(grdListagem, const_GridBanco_NomeBanco, e.Row.Index)), _
                                            DBParametro_Montar("NR_BANCO", objGrid_Valor(grdListagem, const_GridBanco_NumeroBanco, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_BANCO", FNC_GerarArray("NO_BANCO", "@NO_BANCO", _
                                                                "NR_BANCO", "@NR_BANCO"), _
                                                 FNC_GerarArray("SQ_BANCO", "@SQ_BANCO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_BANCO", objGrid_Valor(grdListagem, const_GridBanco_NomeBanco, e.Row.Index)), _
                                            DBParametro_Montar("NR_BANCO", objGrid_Valor(grdListagem, const_GridBanco_NumeroBanco, e.Row.Index)), _
                                            DBParametro_Montar("SQ_BANCO", objGrid_Valor(grdListagem, const_GridBanco_SQ_BANCO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroContaBancaria
        Dim sNO_CONTAFINANCEIRA As String

        sNO_CONTAFINANCEIRA = Trim(e.Row.Cells(const_GridContaBancaria_Banco).Text) & "(" & e.Row.Cells(const_GridContaBancaria_NumeroAgencia).Text _
                                                                                    & " - " & e.Row.Cells(const_GridContaBancaria_NumeroConta).Text _
                                                                                    & "-" & e.Row.Cells(const_GridContaBancaria_DigitoConta).Text & ")"

        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridContaBancaria_SQ_CONTABANCARIA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CONTAFINANCEIRA", TipoCampoFixo.DadoCriacao, "ID_TIPO_CONTAFINANCEIRA", "@ID_TIPO_CONTAFINANCEIRA", _
                                                                                      "ID_PESSOA", "@ID_PESSOA", _
                                                                                      "ID_BANCO", "@ID_BANCO", _
                                                                                      "NO_CONTAFINANCEIRA", "@NO_CONTAFINANCEIRA", _
                                                                                      "NR_AGENCIA", "@NR_AGENCIA", _
                                                                                      "NR_CONTA", "@NR_CONTA", _
                                                                                      "NR_CONTA_DIGITO", "@NR_CONTA_DIGITO", _
                                                                                      "DT_ABERTURA", "@DT_ABERTURA", _
                                                                                      "ID_EMPRESA", "@ID_EMPRESA", _
                                                                                      "IC_CONTROLASALDO", "@IC_CONTROLASALDO", _
                                                                                      "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_TIPO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaBancaria_TipoConta, e.Row.Index)), _
                                            DBParametro_Montar("ID_PESSOA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("ID_BANCO", objGrid_Valor(grdListagem, const_GridContaBancaria_Banco, e.Row.Index)), _
                                            DBParametro_Montar("NO_CONTAFINANCEIRA", sNO_CONTAFINANCEIRA), _
                                            DBParametro_Montar("NR_AGENCIA", objGrid_Valor(grdListagem, const_GridContaBancaria_NumeroAgencia, e.Row.Index)), _
                                            DBParametro_Montar("NR_CONTA", objGrid_Valor(grdListagem, const_GridContaBancaria_NumeroConta, e.Row.Index)), _
                                            DBParametro_Montar("NR_CONTA_DIGITO", objGrid_Valor(grdListagem, const_GridContaBancaria_DigitoConta, e.Row.Index)), _
                                            DBParametro_Montar("DT_ABERTURA", objGrid_Valor(grdListagem, const_GridContaBancaria_DtAbetura, e.Row.Index)), _
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("IC_CONTROLASALDO", objGrid_CheckCol_Valor(grdListagem, const_GridContaBancaria_ControlaSaldo, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridContaBancaria_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CONTAFINANCEIRA", FNC_GerarArray("ID_TIPO_CONTAFINANCEIRA", "@ID_TIPO_CONTAFINANCEIRA", _
                                                                          "ID_BANCO", "@ID_BANCO", _
                                                                          "NO_CONTAFINANCEIRA", "@NO_CONTAFINANCEIRA", _
                                                                          "NR_AGENCIA", "@NR_AGENCIA", _
                                                                          "NR_CONTA", "@NR_CONTA", _
                                                                          "NR_CONTA_DIGITO", "@NR_CONTA_DIGITO", _
                                                                          "DT_ABERTURA", "@DT_ABERTURA", _
                                                                          "IC_CONTROLASALDO", "@IC_CONTROLASALDO", _
                                                                          "IC_ATIVO", "@IC_ATIVO"), _
                                                           FNC_GerarArray("SQ_CONTAFINANCEIRA", "@SQ_CONTAFINANCEIRA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_TIPO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaBancaria_TipoConta, e.Row.Index)), _
                                            DBParametro_Montar("ID_BANCO", objGrid_Valor(grdListagem, const_GridContaBancaria_Banco, e.Row.Index)), _
                                            DBParametro_Montar("NO_CONTAFINANCEIRA", sNO_CONTAFINANCEIRA), _
                                            DBParametro_Montar("NR_AGENCIA", objGrid_Valor(grdListagem, const_GridContaBancaria_NumeroAgencia, e.Row.Index)), _
                                            DBParametro_Montar("NR_CONTA", objGrid_Valor(grdListagem, const_GridContaBancaria_NumeroConta, e.Row.Index)), _
                                            DBParametro_Montar("NR_CONTA_DIGITO", objGrid_Valor(grdListagem, const_GridContaBancaria_DigitoConta, e.Row.Index)), _
                                            DBParametro_Montar("DT_ABERTURA", objGrid_Valor(grdListagem, const_GridContaBancaria_DtAbetura, e.Row.Index)), _
                                            DBParametro_Montar("IC_CONTROLASALDO", objGrid_CheckCol_Valor(grdListagem, const_GridContaBancaria_ControlaSaldo, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridContaBancaria_Ativo, e.Row.Index)), _
                                            DBParametro_Montar("SQ_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaBancaria_SQ_CONTABANCARIA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridContaCaixa_SQ_CONTACAIXA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_CONTAFINANCEIRA", TipoCampoFixo.DadoCriacao, "ID_TIPO_CONTAFINANCEIRA", "@ID_TIPO_CONTAFINANCEIRA", _
                                                                                      "ID_DEPARTAMENTO_RESPONSAVEL", "@ID_DEPARTAMENTO_RESPONSAVEL", _
                                                                                      "NO_CONTAFINANCEIRA", "@NO_CONTAFINANCEIRA", _
                                                                                      "ID_EMPRESA", "@ID_EMPRESA", _
                                                                                      "IC_CONTROLASALDO", "@IC_CONTROLASALDO", _
                                                                                      "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_TIPO_CONTAFINANCEIRA", 1), _
                                            DBParametro_Montar("ID_DEPARTAMENTO_RESPONSAVEL", objGrid_Valor(grdListagem, const_GridContaCaixa_Departamento, e.Row.Index)), _
                                            DBParametro_Montar("NO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaCaixa_NomeCaixa, e.Row.Index)), _
                                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("IC_CONTROLASALDO", objGrid_CheckCol_Valor(grdListagem, const_GridContaCaixa_ControlaSaldo, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridContaCaixa_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_CONTAFINANCEIRA", FNC_GerarArray("ID_DEPARTAMENTO_RESPONSAVEL", "@ID_DEPARTAMENTO_RESPONSAVEL", _
                                                                          "NO_CONTAFINANCEIRA", "@NO_CONTAFINANCEIRA", _
                                                                          "IC_CONTROLASALDO", "@IC_CONTROLASALDO", _
                                                                          "IC_ATIVO", "@IC_ATIVO"), _
                                                           FNC_GerarArray("SQ_CONTAFINANCEIRA", "@SQ_CONTAFINANCEIRA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_DEPARTAMENTO_RESPONSAVEL", objGrid_Valor(grdListagem, const_GridContaCaixa_Departamento, e.Row.Index)), _
                                            DBParametro_Montar("NO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaCaixa_NomeCaixa, e.Row.Index)), _
                                            DBParametro_Montar("IC_CONTROLASALDO", objGrid_CheckCol_Valor(grdListagem, const_GridContaCaixa_ControlaSaldo, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridContaCaixa_Ativo, e.Row.Index)), _
                                            DBParametro_Montar("SQ_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridContaCaixa_SQ_CONTACAIXA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroFormaPagamento
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridFormaPagamento_SQ_FORMAPAGAMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_FORMAPAGAMENTO", TipoCampoFixo.DadoCriacao, "NO_FORMAPAGAMENTO", "@NO_FORMAPAGAMENTO", _
                                                                                     "ID_TIPO_DOCUMENTO", "@ID_TIPO_DOCUMENTO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_FORMAPAGAMENTO", Trim(objGrid_Valor(grdListagem, const_GridFormaPagamento_NomeFormaPagamento, e.Row.Index))), _
                                            DBParametro_Montar("ID_TIPO_DOCUMENTO", objGrid_Valor(grdListagem, const_GridFormaPagamento_TipoDocumento, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_FORMAPAGAMENTO", FNC_GerarArray("NO_FORMAPAGAMENTO", "@NO_FORMAPAGAMENTO", _
                                                                         "ID_TIPO_DOCUMENTO", "@ID_TIPO_DOCUMENTO"), _
                                                          FNC_GerarArray("SQ_FORMAPAGAMENTO", "@SQ_FORMAPAGAMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_FORMAPAGAMENTO", Trim(objGrid_Valor(grdListagem, const_GridFormaPagamento_NomeFormaPagamento, e.Row.Index))), _
                                            DBParametro_Montar("ID_TIPO_DOCUMENTO", objGrid_Valor(grdListagem, const_GridFormaPagamento_TipoDocumento, e.Row.Index)), _
                                            DBParametro_Montar("SQ_FORMAPAGAMENTO", objGrid_Valor(grdListagem, const_GridFormaPagamento_SQ_FORMAPAGAMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoCargo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoCargo_SQ_TIPO_CARGO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CARGO", TipoCampoFixo.DadoCriacao, "NO_TIPO_CARGO", "@NO_TIPO_CARGO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CARGO", Trim(objGrid_Valor(grdListagem, const_GridTipoCargo_NomeTipoCargo, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CARGO", FNC_GerarArray("NO_TIPO_CARGO", "@NO_TIPO_CARGO"), _
                                                      FNC_GerarArray("SQ_TIPO_CARGO", "@SQ_TIPO_CARGO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CARGO", Trim(objGrid_Valor(grdListagem, const_GridTipoCargo_NomeTipoCargo, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_CARGO", objGrid_Valor(grdListagem, const_GridTipoCargo_SQ_TIPO_CARGO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoContato
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoContato_SQ_TIPO_CONTATO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CONTATO", TipoCampoFixo.DadoCriacao, "NO_TIPO_CONTATO", "@NO_TIPO_CONTATO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONTATO", Trim(objGrid_Valor(grdListagem, const_GridTipoCargo_NomeTipoCargo, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CONTATO", FNC_GerarArray("NO_TIPO_CONTATO", "@NO_TIPO_CONTATO"), _
                                                        FNC_GerarArray("SQ_TIPO_CONTATO", "@SQ_TIPO_CONTATO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONTATO", Trim(objGrid_Valor(grdListagem, const_GridTipoCargo_NomeTipoCargo, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_CONTATO", objGrid_Valor(grdListagem, const_GridTipoContato_SQ_TIPO_CONTATO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoDocumento
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoDocumento_SQ_TIPO_DOCUMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_DOCUMENTO", TipoCampoFixo.DadoCriacao, "NO_TIPO_DOCUMENTO", "@NO_TIPO_DOCUMENTO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_DOCUMENTO", Trim(objGrid_Valor(grdListagem, const_GridTipoDocumento_NomeTipoDocumento, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_DOCUMENTO", FNC_GerarArray("NO_TIPO_DOCUMENTO", "@NO_TIPO_DOCUMENTO"), _
                                                          FNC_GerarArray("SQ_TIPO_DOCUMENTO", "@SQ_TIPO_DOCUMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_DOCUMENTO", Trim(objGrid_Valor(grdListagem, const_GridTipoDocumento_NomeTipoDocumento, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_DOCUMENTO", objGrid_Valor(grdListagem, const_GridTipoDocumento_SQ_TIPO_DOCUMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEndereco
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoEndereco_SQ_TIPO_ENDERECO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_ENDERECO", TipoCampoFixo.DadoCriacao, "NO_TIPO_ENDERECO", "@NO_TIPO_ENDERECO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ENDERECO", Trim(objGrid_Valor(grdListagem, const_GridTipoEndereco_NomeTipoEndereco, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_ENDERECO", FNC_GerarArray("NO_TIPO_ENDERECO", "@NO_TIPO_ENDERECO"), _
                                                         FNC_GerarArray("SQ_TIPO_ENDERECO", "@SQ_TIPO_ENDERECO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ENDERECO", Trim(objGrid_Valor(grdListagem, const_GridTipoEndereco_NomeTipoEndereco, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_ENDERECO", objGrid_Valor(grdListagem, const_GridTipoEndereco_SQ_TIPO_ENDERECO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEscolaridade
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_ESCOLARIDADE", TipoCampoFixo.DadoCriacao, "NO_TIPO_ESCOLARIDADE", "@NO_TIPO_ESCOLARIDADE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ESCOLARIDADE", Trim(objGrid_Valor(grdListagem, const_GridTipoEndereco_NomeTipoEndereco, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_ESCOLARIDADE", FNC_GerarArray("NO_TIPO_ESCOLARIDADE", "@NO_TIPO_ESCOLARIDADE"), _
                                                             FNC_GerarArray("SQ_TIPO_ESCOLARIDADE", "@SQ_TIPO_ESCOLARIDADE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ESCOLARIDADE", Trim(objGrid_Valor(grdListagem, const_GridTipoEscolaridade_NomeTipoEscolaridade, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_ESCOLARIDADE", objGrid_Valor(grdListagem, const_GridTipoEscolaridade_SQ_TIPO_ESCOLARIDADE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEstadoCivil
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_ESTADOCIVIL", TipoCampoFixo.DadoCriacao, "NO_TIPO_ESTADOCIVIL", "@NO_TIPO_ESTADOCIVIL")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ESTADOCIVIL", Trim(objGrid_Valor(grdListagem, const_GridTipoEstadoCivil_NomeEstadoCivil, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_ESTADOCIVIL", FNC_GerarArray("NO_TIPO_ESTADOCIVIL", "@NO_TIPO_ESTADOCIVIL"), _
                                                            FNC_GerarArray("SQ_TIPO_ESTADOCIVIL", "@SQ_TIPO_ESTADOCIVIL"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_ESTADOCIVIL", Trim(objGrid_Valor(grdListagem, const_GridTipoEstadoCivil_NomeEstadoCivil, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_ESTADOCIVIL", objGrid_Valor(grdListagem, const_GridTipoEstadoCivil_SQ_TIPO_ESTADOCIVIL, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoMidiaSocial
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_MIDIASOCIAL", TipoCampoFixo.DadoCriacao, "NO_TIPO_MIDIASOCIAL", "@NO_TIPO_MIDIASOCIAL")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_MIDIASOCIAL", Trim(objGrid_Valor(grdListagem, const_GridTipoMidiaSocial_NomeMidiaSocial, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_MIDIASOCIAL", FNC_GerarArray("NO_TIPO_MIDIASOCIAL", "@NO_TIPO_MIDIASOCIAL"), _
                                                            FNC_GerarArray("SQ_TIPO_MIDIASOCIAL", "@SQ_TIPO_MIDIASOCIAL"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_MIDIASOCIAL", Trim(objGrid_Valor(grdListagem, const_GridTipoMidiaSocial_NomeMidiaSocial, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_MIDIASOCIAL", objGrid_Valor(grdListagem, const_GridTipoMidiaSocial_SQ_TIPO_MIDIASOCIAL, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoPaciente
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoPaciente_SQ_TIPO_PACIENTE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_PACIENTE", TipoCampoFixo.DadoCriacao, "NO_TIPO_PACIENTE", "@NO_TIPO_PACIENTE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_PACIENTE", Trim(objGrid_Valor(grdListagem, const_GridTipoPaciente_NomeTipoPaciente, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_PACIENTE", FNC_GerarArray("NO_TIPO_PACIENTE", "@NO_TIPO_PACIENTE"), _
                                                         FNC_GerarArray("SQ_TIPO_PACIENTE", "@SQ_TIPO_PACIENTE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_PACIENTE", Trim(objGrid_Valor(grdListagem, const_GridTipoPaciente_NomeTipoPaciente, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_PACIENTE", objGrid_Valor(grdListagem, const_GridTipoPaciente_SQ_TIPO_PACIENTE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoPessoa
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoPessoa_SQ_TIPO_PESSOA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_PESSOA", TipoCampoFixo.DadoCriacao, "ID_OPT_FISICO_JURIDICO", "@ID_OPT_FISICO_JURIDICO", _
                                                                                  "NO_TIPO_PESSOA", "@NO_TIPO_PESSOA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_OPT_FISICO_JURIDICO", objGrid_Valor(grdListagem, const_GridTipoPessoa_FisicoJuridico, e.Row.Index)), _
                                            DBParametro_Montar("NO_TIPO_PESSOA", Trim(objGrid_Valor(grdListagem, const_GridTipoPessoa_NomeTipoPessoa, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_PESSOA", FNC_GerarArray("ID_OPT_FISICO_JURIDICO", "@ID_OPT_FISICO_JURIDICO", _
                                                                      "NO_TIPO_PESSOA", "@NO_TIPO_PESSOA"), _
                                                       FNC_GerarArray("SQ_TIPO_PESSOA", "@SQ_TIPO_PESSOA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_OPT_FISICO_JURIDICO", objGrid_Valor(grdListagem, const_GridTipoPessoa_FisicoJuridico, e.Row.Index)), _
                                            DBParametro_Montar("NO_TIPO_PESSOA", Trim(objGrid_Valor(grdListagem, const_GridTipoPessoa_NomeTipoPessoa, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_PESSOA", objGrid_Valor(grdListagem, const_GridTipoPessoa_SQ_TIPO_PESSOA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoProduto
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoProduto_SQ_TIPO_PRODUTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_PRODUTO", TipoCampoFixo.DadoCriacao, "NO_TIPO_PRODUTO", "@NO_TIPO_PRODUTO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_PRODUTO", Trim(objGrid_Valor(grdListagem, const_GridTipoProduto_NomeTipoProduto, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_PRODUTO", FNC_GerarArray("NO_TIPO_PRODUTO", "@NO_TIPO_PRODUTO"), _
                                                        FNC_GerarArray("SQ_TIPO_PRODUTO", "@SQ_TIPO_PRODUTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_PRODUTO", Trim(objGrid_Valor(grdListagem, const_GridTipoProduto_NomeTipoProduto, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_PRODUTO", objGrid_Valor(grdListagem, const_GridTipoProduto_SQ_TIPO_PRODUTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoQuestionario
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_QUESTIONARIO", TipoCampoFixo.DadoCriacao, "NO_TIPO_QUESTIONARIO", "@NO_TIPO_QUESTIONARIO", _
                                                                                        "ID_OPT_TIPOCAMPO", "@ID_OPT_TIPOCAMPO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_QUESTIONARIO", Trim(objGrid_Valor(grdListagem, const_GridTipoQuestionario_NomeTipoQuestionario, e.Row.Index))), _
                                            DBParametro_Montar("ID_OPT_TIPOCAMPO", objGrid_Valor(grdListagem, const_GridTipoQuestionario_TipoCampo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_QUESTIONARIO", FNC_GerarArray("NO_TIPO_QUESTIONARIO", "@NO_TIPO_QUESTIONARIO", _
                                                                            "ID_OPT_TIPOCAMPO", "@ID_OPT_TIPOCAMPO"), _
                                                             FNC_GerarArray("SQ_TIPO_QUESTIONARIO", "@SQ_TIPO_QUESTIONARIO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_QUESTIONARIO", Trim(objGrid_Valor(grdListagem, const_GridTipoQuestionario_NomeTipoQuestionario, e.Row.Index))), _
                                            DBParametro_Montar("ID_OPT_TIPOCAMPO", objGrid_Valor(grdListagem, const_GridTipoQuestionario_TipoCampo, e.Row.Index)), _
                                            DBParametro_Montar("SQ_TIPO_QUESTIONARIO", objGrid_Valor(grdListagem, const_GridTipoQuestionario_SQ_TIPO_QUESTIONARIO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoRaca
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoRaca_SQ_TIPO_RACA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_RACA", TipoCampoFixo.DadoCriacao, "NO_TIPO_RACA", "@NO_TIPO_RACA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RACA", Trim(objGrid_Valor(grdListagem, const_GridTipoRaca_NomeTipoRaca, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_RACA", FNC_GerarArray("NO_TIPO_RACA", "@NO_TIPO_RACA"), _
                                                     FNC_GerarArray("SQ_TIPO_RACA", "@SQ_TIPO_RACA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RACA", Trim(objGrid_Valor(grdListagem, const_GridTipoRaca_NomeTipoRaca, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_RACA", objGrid_Valor(grdListagem, const_GridTipoRaca_SQ_TIPO_RACA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_REFERENCIAPESSOA", TipoCampoFixo.DadoCriacao, "NO_TIPO_REFERENCIAPESSOA", "@NO_TIPO_REFERENCIAPESSOA", _
                                                                                            "ID_TIPO_PESSOA", "@ID_TIPO_PESSOA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_REFERENCIAPESSOA", Trim(objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa, e.Row.Index))), _
                                            DBParametro_Montar("ID_TIPO_PESSOA", objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_TipoPessoa, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_REFERENCIAPESSOA", FNC_GerarArray("NO_TIPO_REFERENCIAPESSOA", "@NO_TIPO_REFERENCIAPESSOA", _
                                                                                "ID_TIPO_PESSOA", "@ID_TIPO_PESSOA"), _
                                                                 FNC_GerarArray("SQ_TIPO_REFERENCIAPESSOA", "@SQ_TIPO_REFERENCIAPESSOA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_REFERENCIAPESSOA", Trim(objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa, e.Row.Index))), _
                                            DBParametro_Montar("ID_TIPO_PESSOA", objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_TipoPessoa, e.Row.Index)), _
                                            DBParametro_Montar("SQ_TIPO_REFERENCIAPESSOA", objGrid_Valor(grdListagem, const_GridTipoReferenciaPessoal_SQ_TIPO_REFERENCIAPESSOA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoReligiao_SQ_TIPO_RELIGIAO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_RELIGIAO", TipoCampoFixo.DadoCriacao, "NO_TIPO_RELIGIAO", "@NO_TIPO_RELIGIAO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RELIGIAO", Trim(objGrid_Valor(grdListagem, const_GridTipoReligiao_NomeTipoReligiao, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_RELIGIAO", FNC_GerarArray("NO_TIPO_RELIGIAO", "@NO_TIPO_RELIGIAO"), _
                                                         FNC_GerarArray("SQ_TIPO_RELIGIAO", "@SQ_TIPO_RELIGIAO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_RELIGIAO", Trim(objGrid_Valor(grdListagem, const_GridTipoReligiao_NomeTipoReligiao, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_RELIGIAO", objGrid_Valor(grdListagem, const_GridTipoReligiao_SQ_TIPO_RELIGIAO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoSexo
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoSexo_SQ_TIPO_SEXO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_SEXO", TipoCampoFixo.DadoCriacao, "NO_TIPO_SEXO", "@NO_TIPO_SEXO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_SEXO", Trim(objGrid_Valor(grdListagem, const_GridTipoSexo_NomeTipoSexo, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_SEXO", FNC_GerarArray("NO_TIPO_SEXO", "@NO_TIPO_SEXO"), _
                                                     FNC_GerarArray("SQ_TIPO_SEXO", "@SQ_TIPO_SEXO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_SEXO", Trim(objGrid_Valor(grdListagem, const_GridTipoSexo_NomeTipoSexo, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_SEXO", objGrid_Valor(grdListagem, const_GridTipoSexo_SQ_TIPO_SEXO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoTelefone
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoTelefone_SQ_TIPO_TELEFONE, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_TELEFONE", TipoCampoFixo.DadoCriacao, "NO_TIPO_TELEFONE", "@NO_TIPO_TELEFONE")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_TELEFONE", Trim(objGrid_Valor(grdListagem, const_GridTipoTelefone_NomeTipoTelefone, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_TELEFONE", FNC_GerarArray("NO_TIPO_TELEFONE", "@NO_TIPO_TELEFONE"), _
                                                         FNC_GerarArray("SQ_TIPO_TELEFONE", "@SQ_TIPO_TELEFONE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_TELEFONE", Trim(objGrid_Valor(grdListagem, const_GridTipoTelefone_NomeTipoTelefone, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_TELEFONE", objGrid_Valor(grdListagem, const_GridTipoTelefone_SQ_TIPO_TELEFONE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroDepartamento
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridDepartamento_SQ_DEPARTAMENTO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_DEPARTAMENTO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                                   "NO_DEPARTAMENTO", "@NO_DEPARTAMENTO", _
                                                                                   "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("NO_DEPARTAMENTO", Trim(objGrid_Valor(grdListagem, const_GridDepartamento_NomeDepartamento, e.Row.Index))), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridDepartamento_Ativo, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_DEPARTAMENTO", FNC_GerarArray("ID_EMPRESA", "@ID_EMPRESA", _
                                                                       "NO_DEPARTAMENTO", "@NO_DEPARTAMENTO", _
                                                                       "IC_ATIVO", "@IC_ATIVO"), _
                                                        FNC_GerarArray("SQ_DEPARTAMENTO", "@SQ_DEPARTAMENTO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("NO_DEPARTAMENTO", Trim(objGrid_Valor(grdListagem, const_GridDepartamento_NomeDepartamento, e.Row.Index))), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridDepartamento_Ativo, e.Row.Index)), _
                                            DBParametro_Montar("SQ_DEPARTAMENTO", objGrid_Valor(grdListagem, const_GridDepartamento_SQ_DEPARTAMENTO, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoContaFinanceira
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CONTAFINANCEIRA", TipoCampoFixo.DadoCriacao, "NO_TIPO_CONTAFINANCEIRA", "@NO_TIPO_CONTAFINANCEIRA")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONTAFINANCEIRA", Trim(objGrid_Valor(grdListagem, const_GridTipoContaFinanceira_NomeTipoContaBancaria, e.Row.Index))))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CONTAFINANCEIRA", FNC_GerarArray("NO_TIPO_CONTAFINANCEIRA", "@NO_TIPO_CONTAFINANCEIRA"), _
                                                                FNC_GerarArray("SQ_TIPO_CONTAFINANCEIRA", "@SQ_TIPO_CONTAFINANCEIRA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONTAFINANCEIRA", Trim(objGrid_Valor(grdListagem, const_GridTipoContaFinanceira_NomeTipoContaBancaria, e.Row.Index))), _
                                            DBParametro_Montar("SQ_TIPO_CONTAFINANCEIRA", objGrid_Valor(grdListagem, const_GridTipoContaFinanceira_SQ_TIPO_CONTABANCARIA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTipoConsulta
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoConsulta_SQ_TIPO_CONSULTA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TIPO_CONSULTA", TipoCampoFixo.DadoCriacao, "NO_TIPO_CONSULTA", "@NO_TIPO_CONSULTA", _
                                                                                    "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONSULTA", Trim(objGrid_Valor(grdListagem, const_GridTipoConsulta_NO_TIPO_CONSULTA, e.Row.Index))), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoConsulta_IC_ATIVO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TIPO_CONSULTA", FNC_GerarArray("NO_TIPO_CONSULTA", "@NO_TIPO_CONSULTA", _
                                                                        "IC_ATIVO", "@IC_ATIVO"), _
                                                         FNC_GerarArray("SQ_TIPO_CONSULTA", "@SQ_TIPO_CONSULTA"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("NO_TIPO_CONSULTA", Trim(objGrid_Valor(grdListagem, const_GridTipoConsulta_NO_TIPO_CONSULTA, e.Row.Index))), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTipoConsulta_IC_ATIVO, e.Row.Index)), _
                                            DBParametro_Montar("SQ_TIPO_CONSULTA", objGrid_Valor(grdListagem, const_GridTipoConsulta_SQ_TIPO_CONSULTA, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroTransacaoEstoque
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridTipoConsulta_SQ_TIPO_CONSULTA, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_TRANSACAOESTOQUE", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                                       "CD_TRANSACAOESTOQUE", "@CD_TRANSACAOESTOQUE", _
                                                                                       "NO_TRANSACAOESTOQUE", "@NO_TRANSACAOESTOQUE", _
                                                                                       "ID_ESTOQUE_CREDITO", "@ID_ESTOQUE_CREDITO", _
                                                                                       "ID_ESTOQUE_DEBITO", "@ID_ESTOQUE_DEBITO", _
                                                                                       "IC_USAR_RECEBIMENTO", "@IC_USAR_RECEBIMENTO", _
                                                                                       "IC_USAR_VENDA", "@IC_USAR_VENDA", _
                                                                                       "IC_USAR_MOVIMENTACAOMANUAL", "@IC_USAR_MOVIMENTACAOMANUAL", _
                                                                                       "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("CD_TRANSACAOESTOQUE", Trim(objGrid_Valor(grdListagem, const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE, e.Row.Index))), _
                                            DBParametro_Montar("NO_TRANSACAOESTOQUE", Trim(objGrid_Valor(grdListagem, const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE, e.Row.Index))), _
                                            DBParametro_Montar("ID_ESTOQUE_CREDITO", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO, e.Row.Index)), _
                                            DBParametro_Montar("ID_ESTOQUE_DEBITO", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO, e.Row.Index)), _
                                            DBParametro_Montar("IC_USAR_RECEBIMENTO", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_RECEBIMENTO, e.Row.Index)), _
                                            DBParametro_Montar("IC_USAR_VENDA", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_VENDA, e.Row.Index)), _
                                            DBParametro_Montar("IC_USAR_MOVIMENTACAOMANUAL", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_MOVIMENTACAOMANUAL, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_ATIVO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_TRANSACAOESTOQUE", FNC_GerarArray("ID_EMPRESA", "@ID_EMPRESA", _
                                                                           "CD_TRANSACAOESTOQUE", "@CD_TRANSACAOESTOQUE", _
                                                                           "NO_TRANSACAOESTOQUE", "@NO_TRANSACAOESTOQUE", _
                                                                           "ID_ESTOQUE_CREDITO", "@ID_ESTOQUE_CREDITO", _
                                                                           "ID_ESTOQUE_DEBITO", "@ID_ESTOQUE_DEBITO", _
                                                                           "IC_USAR_RECEBIMENTO", "@IC_USAR_RECEBIMENTO", _
                                                                           "IC_USAR_VENDA", "@IC_USAR_VENDA", _
                                                                           "IC_USAR_MOVIMENTACAOMANUAL", "@IC_USAR_MOVIMENTACAOMANUAL", _
                                                                           "IC_ATIVO", "@IC_ATIVO"), _
                                                            FNC_GerarArray("SQ_TRANSACAOESTOQUE", "@SQ_TRANSACAOESTOQUE"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("CD_TRANSACAOESTOQUE", Trim(objGrid_Valor(grdListagem, const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE, e.Row.Index))), _
                                            DBParametro_Montar("NO_TRANSACAOESTOQUE", Trim(objGrid_Valor(grdListagem, const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE, e.Row.Index))), _
                                            DBParametro_Montar("ID_ESTOQUE_CREDITO", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO, e.Row.Index)), _
                                            DBParametro_Montar("ID_ESTOQUE_DEBITO", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO, e.Row.Index)), _
                                            DBParametro_Montar("IC_USAR_RECEBIMENTO", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_RECEBIMENTO, e.Row.Index)), _
                                            DBParametro_Montar("IC_USAR_VENDA", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_VENDA, e.Row.Index)), _
                                            DBParametro_Montar("IC_USAR_MOVIMENTACAOMANUAL", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_USAR_MOVIMENTACAOMANUAL, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridTransacaoEstoque_IC_ATIVO, e.Row.Index)), _
                                            DBParametro_Montar("SQ_TRANSACAOESTOQUE", objGrid_Valor(grdListagem, const_GridTransacaoEstoque_SQ_TRANSACAOESTOQUE, e.Row.Index)))
        End If
      Case enListagemGeral_TipoTela.CadastroServico
        If FNC_CampoNulo(objGrid_Valor(grdListagem, const_GridServico_SQ_SERVICO, e.Row.Index)) Then
          sSqlText = DBMontar_Insert("TB_SERVICO", TipoCampoFixo.DadoCriacao, "ID_EMPRESA", "@ID_EMPRESA", _
                                                                              "CD_SERVICO", "@CD_SERVICO", _
                                                                              "NO_SERVICO", "@NO_SERVICO", _
                                                                              "ID_TIPO_SERVICO", "@ID_TIPO_SERVICO", _
                                                                              "IC_GERAFINANCEIRO", "@IC_GERAFINANCEIRO", _
                                                                              "IC_ATIVO", "@IC_ATIVO")
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("CD_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridServico_CD_SERVICO, e.Row.Index))), _
                                            DBParametro_Montar("NO_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridServico_NO_SERVICO, e.Row.Index))), _
                                            DBParametro_Montar("ID_TIPO_SERVICO", objGrid_Valor(grdListagem, const_GridServico_ID_TIPO_SERVICO, e.Row.Index)), _
                                            DBParametro_Montar("IC_GERAFINANCEIRO", objGrid_CheckCol_Valor(grdListagem, const_GridServico_IC_GERAFINANCEIRO, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridServico_IC_ATIVO, e.Row.Index)))
        Else
          sSqlText = DBMontar_Update("TB_SERVICO", FNC_GerarArray("ID_EMPRESA", "@ID_EMPRESA", _
                                                                  "CD_SERVICO", "@CD_SERVICO", _
                                                                  "NO_SERVICO", "@NO_SERVICO", _
                                                                  "ID_TIPO_SERVICO", "@ID_TIPO_SERVICO", _
                                                                  "IC_GERAFINANCEIRO", "@IC_GERAFINANCEIRO", _
                                                                  "IC_ATIVO", "@IC_ATIVO"), _
                                                   FNC_GerarArray("SQ_SERVICO", "@SQ_SERVICO"))
          bPesquisar = DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL), _
                                            DBParametro_Montar("CD_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridServico_CD_SERVICO, e.Row.Index))), _
                                            DBParametro_Montar("NO_SERVICO", Trim(objGrid_Valor(grdListagem, const_GridServico_NO_SERVICO, e.Row.Index))), _
                                            DBParametro_Montar("ID_TIPO_SERVICO", objGrid_Valor(grdListagem, const_GridServico_ID_TIPO_SERVICO, e.Row.Index)), _
                                            DBParametro_Montar("IC_GERAFINANCEIRO", objGrid_CheckCol_Valor(grdListagem, const_GridServico_IC_GERAFINANCEIRO, e.Row.Index)), _
                                            DBParametro_Montar("IC_ATIVO", objGrid_CheckCol_Valor(grdListagem, const_GridServico_IC_ATIVO, e.Row.Index)), _
                                            DBParametro_Montar("SQ_SERVICO", objGrid_Valor(grdListagem, const_GridServico_SQ_SERVICO, e.Row.Index)))
        End If
    End Select

    If bPesquisar Then
      Pesquisar()
    End If
  End Sub

  Private Sub grdListagem_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdListagem.BeforeCellActivate
    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroTipoContato
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridTipoContato_IC_SISTEMA).Value, "N") = "S")
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        If e.Cell.Column.Index <> const_GridContaCaixa_Ativo And e.Cell.Column.Index <> const_GridContaCaixa_ControlaSaldo Then
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
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridModeloDocumentoElemento_IC_SISTEMA).Value, "N") = "S")
    End Select
  End Sub

  Private Sub grdListagem_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdListagem.BeforeRowsDeleted
    Dim bCancelar As Boolean

    bLinhaExcluida = False

    e.DisplayPromptMsg = False

    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroPlanoContas
        If FNC_Perguntar("Deseja realmente excluir o plano de contas " & e.Rows(0).Cells(const_GridPlanoContas_NomePlanoContas).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridPlanoContas_SQ_PLANOCONTAS).Value) Then
            DBExecutar_Delete("TB_PLANOCONTAS", "SQ_PLANOCONTAS", e.Rows(0).Cells(const_GridPlanoContas_SQ_PLANOCONTAS).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroPlanoContasGrupo
        If FNC_Perguntar("Deseja realmente excluir o grupo de plano de contas " & e.Rows(0).Cells(const_GridPlanoContasGrupo_NomeGrupoProduto).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO).Value) Then
            DBExecutar_Delete("TB_PLANOCONTAS_GRUPO", "SQ_PLANOCONTAS_GRUPO", e.Rows(0).Cells(const_GridPlanoContasGrupo_SQ_PLANOCONTAS_GRUPO).Value)
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
            DBExecutar_Delete("TB_PROFISSAO", "SQ_PROFISSAO", e.Rows(0).Cells(const_GridProfissao_SQ_PROFISSAO).Value)
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
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar
        If FNC_Perguntar("Deseja realmente excluir o segmento " & e.Rows(0).Cells(const_GridSegmento_NomeSegmento).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridSegmento_SQ_SEGMENTO).Value) Then
            DBExecutar_Delete("TB_SEGMENTO", "SQ_SEGMENTO", e.Rows(0).Cells(const_GridSegmento_SQ_SEGMENTO).Value)
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
      Case enListagemGeral_TipoTela.CadastroCargo
        If FNC_Perguntar("Deseja realmente excluir o cargo " & e.Rows(0).Cells(const_GridCargo_NomeCargo).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridCargo_SQ_TIPO_CARGO).Value) Then
            DBExecutar_Delete("TB_TIPO_CARGO", "SQ_TIPO_CARGO", e.Rows(0).Cells(const_GridCargo_SQ_TIPO_CARGO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroCidade
        If FNC_Perguntar("Deseja realmente excluir a cidade " & e.Rows(0).Cells(const_GridCidade_NomeCidade).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridCidade_SQ_CIDADE).Value) Then
            DBExecutar_Delete("TB_CIDADE", "SQ_CIDADE", e.Rows(0).Cells(const_GridCidade_SQ_CIDADE).Value)
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
              DBExecutar_Delete("TB_PAIS", "SQ_PAIS", e.Rows(0).Cells(const_GridPais_SQ_PAIS).Value)
            End If
          Else
            bCancelar = True
          End If
        End If
      Case enListagemGeral_TipoTela.CadastroConvenio
        If FNC_Perguntar("Deseja realmente excluir o convênio " & e.Rows(0).Cells(const_GridConvenio_NomeConvenio).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridConvenio_SQ_CONVENIO).Value) Then
            DBExecutar_Delete("TB_CONVENIO", "SQ_CONVENIO", e.Rows(0).Cells(const_GridConvenio_SQ_CONVENIO).Value)
          End If
        Else
          bCancelar = True
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
            DBExecutar_Delete("TB_BANCO", "SQ_BANCO", e.Rows(0).Cells(const_GridBanco_SQ_BANCO).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroContaBancaria
        If FNC_Perguntar("Deseja realmente excluir a conta bancária " & e.Rows(0).Cells(const_GridContaBancaria_NumeroConta).Value & "?") Then
          If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridContaBancaria_SQ_CONTABANCARIA).Value) Then
            DBExecutar_Delete("TB_CONTABANCARIA", "SQ_CONTABANCARIA", e.Rows(0).Cells(const_GridContaBancaria_SQ_CONTABANCARIA).Value)
          End If
        Else
          bCancelar = True
        End If
      Case enListagemGeral_TipoTela.CadastroContaCaixa
        If FNC_NVL(e.Rows(0).Cells(const_GridContaCaixa_IC_SISTEMA).Value, "N") = "S" Then
          FNC_Mensagem(const_Mensagem_RegistroSistema)
          bCancelar = True
        Else
          If FNC_Perguntar("Deseja realmente excluir a conta caixa " & e.Rows(0).Cells(const_GridContaCaixa_NomeCaixa).Value & "?") Then
            If Not FNC_CampoNulo(e.Rows(0).Cells(const_GridContaCaixa_SQ_CONTACAIXA).Value) Then
              DBExecutar_Delete("TB_CONTACAIXA", "SQ_CONTACAIXA", e.Rows(0).Cells(const_GridContaCaixa_SQ_CONTACAIXA).Value)
            End If
          Else
            bCancelar = True
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
              DBExecutar_Delete("TB_DEPARTAMENTO", "SQ_DEPARTAMENTO", e.Rows(0).Cells(const_GridDepartamento_SQ_DEPARTAMENTO).Value)
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridPlanoContas_CodigoPlanoContas, e.Row.Cells(const_GridPlanoContas_CodigoPlanoContas).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de plano de contas já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridPlanoContas_NomePlanoContas, e.Row.Cells(const_GridPlanoContas_NomePlanoContas).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridGrupoPermissao_NomeGrupoPermissao, e.Row.Cells(const_GridGrupoPermissao_NomeGrupoPermissao).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridPlanoContasGrupo_CodigoGrupoProduto, e.Row.Cells(const_GridPlanoContasGrupo_CodigoGrupoProduto).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de grupo de plano de contas já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridPlanoContasGrupo_NomeGrupoProduto, e.Row.Cells(const_GridPlanoContasGrupo_NomeGrupoProduto).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridProfissao_NomeProfissao, e.Row.Cells(const_GridProfissao_NomeProfissao).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Profissão já cadastrada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoServico
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoServico_NomeTipoServico).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de serviço")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoServico_NomeTipoServico, e.Row.Cells(const_GridTipoServico_NomeTipoServico).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de serviço já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroSegmento_ContasReceberContasPagar
        If FNC_CampoNulo(e.Row.Cells(const_GridSegmento_NomeSegmento).Value) Then
          FNC_Mensagem("É preciso informar o nome do segmento")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridSegmento_NomeSegmento, e.Row.Cells(const_GridSegmento_NomeSegmento).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridDoencaEstagio_DoencaEstagio, e.Row.Cells(const_GridDoencaEstagio_DoencaEstagio).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoServico_NomeTipoServico, e.Row.Cells(const_GridTipoServico_NomeTipoServico).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de serviço já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroCargo
        If FNC_CampoNulo(e.Row.Cells(const_GridCargo_NomeCargo).Value) Then
          FNC_Mensagem("É preciso informar o nome do cargo")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridCargo_NomeCargo, e.Row.Cells(const_GridCargo_NomeCargo).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridCidade_UF, e.Row.Cells(const_GridCidade_UF).Value < _
                                                       const_GridCidade_NomeCidade, e.Row.Cells(const_GridCidade_NomeCidade).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridUF_Pais, e.Row.Cells(const_GridUF_Pais).Value, _
                                                       const_GridUF_NomeUF, e.Row.Cells(const_GridUF_NomeUF).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("U.F. já cadastrada")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridUF_Pais, e.Row.Cells(const_GridUF_Pais).Value, _
                                                       const_GridUF_CodigoUF, e.Row.Cells(const_GridUF_CodigoUF).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridPais_NomePais, e.Row.Cells(const_GridPais_NomePais).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("País já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridPais_NomeNascionalidade, e.Row.Cells(const_GridPais_NomeNascionalidade).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Nascionalidade já informada")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroConvenio
        If FNC_CampoNulo(e.Row.Cells(const_GridConvenio_NomeConvenio).Value) Then
          FNC_Mensagem("É preciso informar o nome do convênio")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridConvenio_NomeConvenio, e.Row.Cells(const_GridConvenio_NomeConvenio).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Convênio já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroGrupoProduto
        If FNC_CampoNulo(e.Row.Cells(const_GridGrupoProduto_NomeGrupoProduto).Value) Then
          FNC_Mensagem("É preciso informar o nome do grupo de produto")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridGrupoProduto_NomeGrupoProduto, e.Row.Cells(const_GridGrupoProduto_NomeGrupoProduto).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridUnidadeMedida_NomeUnidadeMedida, e.Row.Cells(const_GridUnidadeMedida_NomeUnidadeMedida).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Unidade de Medida já cadastrada")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridUnidadeMedida_CodigoUnidadeMedida, e.Row.Cells(const_GridUnidadeMedida_CodigoUnidadeMedida).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridEspecialidade_NomeEspecialidade, e.Row.Cells(const_GridEspecialidade_NomeEspecialidade).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridEspecialidade_NomeEspecialidade, e.Row.Cells(const_GridEspecialidade_NomeEspecialidade).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridContaBancaria_Banco, e.Row.Cells(const_GridContaBancaria_Banco).Value, _
                                                       const_GridContaBancaria_NumeroConta, e.Row.Cells(const_GridContaBancaria_NumeroConta).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridContaCaixa_NomeCaixa, e.Row.Cells(const_GridContaCaixa_NomeCaixa).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridFormaPagamento_NomeFormaPagamento, e.Row.Cells(const_GridFormaPagamento_NomeFormaPagamento).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoCargo_NomeTipoCargo, e.Row.Cells(const_GridTipoCargo_NomeTipoCargo).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoContato_NomeTipoContato, e.Row.Cells(const_GridTipoContato_NomeTipoContato).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoDocumento_NomeTipoDocumento, e.Row.Cells(const_GridTipoDocumento_NomeTipoDocumento).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de documento já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoEscolaridade
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoEscolaridade_NomeTipoEscolaridade).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de escolaridade")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoEscolaridade_NomeTipoEscolaridade, e.Row.Cells(const_GridTipoEscolaridade_NomeTipoEscolaridade).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoEndereco_NomeTipoEndereco, e.Row.Cells(const_GridTipoEndereco_NomeTipoEndereco).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoEstadoCivil_NomeEstadoCivil, e.Row.Cells(const_GridTipoEstadoCivil_NomeEstadoCivil).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoMidiaSocial_NomeMidiaSocial, e.Row.Cells(const_GridTipoMidiaSocial_NomeMidiaSocial).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoPaciente_NomeTipoPaciente, e.Row.Cells(const_GridTipoPaciente_NomeTipoPaciente).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoPessoa_NomeTipoPessoa, e.Row.Cells(const_GridTipoPessoa_NomeTipoPessoa).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoProduto_NomeTipoProduto, e.Row.Cells(const_GridTipoProduto_NomeTipoProduto).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoQuestionario_NomeTipoQuestionario, e.Row.Cells(const_GridTipoQuestionario_NomeTipoQuestionario).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoRaca_NomeTipoRaca, e.Row.Cells(const_GridTipoRaca_NomeTipoRaca).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoReferenciaPessoal_TipoPessoa, e.Row.Cells(const_GridTipoReferenciaPessoal_TipoPessoa).Value, _
                                                       const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa, e.Row.Cells(const_GridTipoReferenciaPessoal_NomeTipoReferenciaPessoa).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Tipo de referência de pessoa já cadastrado")
          e.Cancel = True
        End If
      Case enListagemGeral_TipoTela.CadastroTipoReligiao
        If FNC_CampoNulo(e.Row.Cells(const_GridTipoReligiao_NomeTipoReligiao).Value) Then
          FNC_Mensagem("É preciso informar o nome do tipo de religião")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoReligiao_NomeTipoReligiao, e.Row.Cells(const_GridTipoReligiao_NomeTipoReligiao).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoSexo_NomeTipoSexo, e.Row.Cells(const_GridTipoSexo_NomeTipoSexo).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoTelefone_NomeTipoTelefone, e.Row.Cells(const_GridTipoTelefone_NomeTipoTelefone).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridDepartamento_NomeDepartamento, e.Row.Cells(const_GridDepartamento_NomeDepartamento).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoContaFinanceira_NomeTipoContaBancaria, e.Row.Cells(const_GridTipoContaFinanceira_NomeTipoContaBancaria).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTipoConsulta_NO_TIPO_CONSULTA, e.Row.Cells(const_GridTipoConsulta_NO_TIPO_CONSULTA).Value), _
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
        If FNC_CampoNulo(e.Row.Cells(const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO).Value) And _
           FNC_CampoNulo(e.Row.Cells(const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO).Value) Then
          FNC_Mensagem("É preciso informar pelo menos o estoque de crédito ou estoque de débito dessa transação")
          e.Cancel = True
          Exit Sub
        End If
        If e.Row.Cells(const_GridTransacaoEstoque_ID_ESTOQUE_CREDITO).Value = _
           e.Row.Cells(const_GridTransacaoEstoque_ID_ESTOQUE_DEBITO).Value Then
          FNC_Mensagem("O estoque de crédito e o estoque de débito não podem serem o mesmo")
          e.Cancel = True
          Exit Sub
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE, e.Row.Cells(const_GridTransacaoEstoque_NO_TRANSACAOESTOQUE).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Nome de transação de estoque já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE, e.Row.Cells(const_GridTransacaoEstoque_CD_TRANSACAOESTOQUE).Value), _
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
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridServico_NO_SERVICO, e.Row.Cells(const_GridServico_NO_SERVICO).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Nome de serviço já cadastrado")
          e.Cancel = True
        End If
        If objGrid_Coluna_ProcurarValor(grdListagem, _
                                        FNC_GerarArray(const_GridServico_CD_SERVICO, e.Row.Cells(const_GridServico_CD_SERVICO).Value), _
                                        e.Row.Index) > -1 Then
          FNC_Mensagem("Código de serviço já cadastrado")
          e.Cancel = True
        End If
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
      Case enListagemGeral_TipoTela.CadastroTabelaPreco
        Dim oForm As New frmCadastroTabelaPreco

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroEstoque
        Dim oForm As New frmCadastroEstoque

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        Dim oForm As New frmCadastroModeloDocumentoElemento

        oForm.iTipoTela = IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, enOpcoes.TipoElementoModeloDocumento_Assinatura, _
                              IIf(eListagemGeral_TipoTela = enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, enOpcoes.TipoElementoModeloDocumento_Cabecalho, _
                                                                                                                                enOpcoes.TipoElementoModeloDocumento_Rodape))

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        FNC_AbriTela(oForm)
    End Select
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
          Exit Sub
        End If

        Dim oForm As New frmCadastroNaturezaOperacao

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_NATUREZAOPERACAO = objGrid_Valor(grdListagem, const_GridNaturezaOperacao_SQ_NATUREZAOPERACAO)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroTabelaPreco
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
          Exit Sub
        End If

        Dim oForm As New frmCadastroTabelaPreco

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_TABELAPRECO = objGrid_Valor(grdListagem, const_GridTabelaPreco_SQ_TABELAPRECO)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroTabelaPreco
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
          Exit Sub
        End If

        Dim oForm As New frmCadastroEstoque

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_ESTOQUE = objGrid_Valor(grdListagem, const_GridEstoque_SQ_ESTOQUE)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroEstoque
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
          Exit Sub
        End If

        Dim oForm As New frmCadastroEstoque

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_ESTOQUE = objGrid_Valor(grdListagem, const_GridEstoque_SQ_ESTOQUE)

        FNC_AbriTela(oForm)
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
          Exit Sub
        End If

        Dim oForm As New frmCadastroModeloDocumentoElemento

        AddHandler oForm.Pesquisar, AddressOf Pesquisar
        oForm.iSQ_MODELODOCUMENTO_ELEMENTO = objGrid_Valor(grdListagem, const_GridModeloDocumentoElemento_SQ_MODELODOCUMENTO_ELEMENTO)

        FNC_AbriTela(oForm)
    End Select
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    Select Case eListagemGeral_TipoTela
      Case enListagemGeral_TipoTela.CadastroNaturezaOperacao
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para exclusão")
          Exit Sub
        End If
        If Not FNC_Perguntar("Deseja realmente excluir essa natureza de operação?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_NATUREZAOPERACAO_DEL", False, "@SQ_NATUREZAOPERACAO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_NATUREZAOPERACAO", objGrid_Valor(grdListagem, const_GridNaturezaOperacao_SQ_NATUREZAOPERACAO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroTabelaPreco
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para exclusão")
          Exit Sub
        End If
        If Not FNC_Perguntar("Deseja realmente excluir essa tabela de preço?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_TABELAPRECO_DEL", False, "@SQ_TABELAPRECO")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_TABELAPRECO", objGrid_Valor(grdListagem, const_GridTabelaPreco_SQ_TABELAPRECO))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroEstoque
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para exclusão")
          Exit Sub
        End If
        If Not FNC_Perguntar("Deseja realmente excluir esse estoque?") Then Exit Sub

        Dim sSqlText As String

        sSqlText = DBMontar_SP("SP_ESTOQUE_DEL", False, "@SQ_ESTOQUE")

        If DBExecutar(sSqlText, DBParametro_Montar("SQ_ESTOQUE", objGrid_Valor(grdListagem, const_GridEstoque_SQ_ESTOQUE))) Then
          Pesquisar()

          FNC_Mensagem("Exclusão Efetuada")
        End If
      Case enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Assinatura, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Cabecalho, _
           enListagemGeral_TipoTela.CadastroModeloDocumentoElemento_Rodape
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
          FNC_Mensagem("Não foi selecionado nenhum registro para exclusão")
          Exit Sub
        End If
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
    End Select
  End Sub
End Class