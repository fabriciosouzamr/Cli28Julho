﻿Imports Infragistics.Win

Public Module LocalOutros
  Public Class clsAgendamento_Disponibilidade
    Public Especialidade As String
    Public Medico As String
    Public NomeMedico As String
    Public Empresa As String
    Public Data As Date
    Public Procedimento As String
    Public Paciente As String
    Public Disponivel As Integer
    Public HoraInicial As String
    Public HoraFim As String
    Public Atendimento_Previsto As Integer
    Public Atendimento_Disponivel As Integer
    Public Retorno_Previsto As Integer
    Public Retorno_Disponivel As Integer
  End Class

End Module

Module Local
  Public osttStatus As System.Windows.Forms.ToolStripStatusLabel

  Public Const const_Anamnese_Formulario As Integer = 1
  Public Const const_Anamnese_ModeloDocumento As Integer = 2

  Public Const const_TipoDocumento_Dinheiro As Integer = 1

  'NF-e
  'Public oNFe_XML As New clsXML

  Public Class clsModeloDocumentoElemento
    Public Texto As String
    Public Font As Font
    Public Alinhamento As StringAlignment
  End Class

  Public Enum enModeloDocumentoElemento_Padrao
    Cabecalho = 1
    Rodape = 2
    Assinatura = 3
  End Enum

  Public Enum enContasReceberPagar_TipoBaixa
    Quitacao = 1
    Renegociacao = 2
  End Enum

  Public Enum enComboBox_AnamneseEvolucao
    SQ_ANAMNESE = 0
    DS = 1
    ID_QUESTIONARIO = 2
    ID_QUESTIONARIO_VERSAO = 3
    ID_QUESTIONARIO_RESPOSTA = 4
    TX_ANAMNESE = 5
    DT_ANAMNESE = 6
    NO_PESSOA_PROFISSIONAL = 7
  End Enum

  Public Enum enPermissao
    CADA_Pessoa_CadastroPessoa = 1
    CADA_Pessoa_CadastroProfissao = 2
    CADA_Pessoa_CadastroFuncao = 3
    CADA_Pessoa_CadastroConselhoProfissional = 4
    CADA_Pessoa_CadastroEmpresa = 5
    CADA_Pessoa_CadastroCidade = 6
    CADA_Pessoa_CadastroUF = 7
    CADA_Pessoa_CadastrodePais = 8
    CADA_Clinica_Especialidade = 9
    CADA_Clinica_GrupoProcedimento = 10
    CADA_Clinica_Procedimento = 11
    CADA_Clinica_CadastrarHorariodeProfissional = 12
    CADA_Clinica_Configuracao = 13
    CADA_Clinica_CadastrarPrecodeProcedimentoseExames = 14
    CADA_Clinica_ManutencaoPrecodeProcedimentoeExames = 15
    CADA_Clinica_Convenio = 16
    CADA_Clinica_Vacina = 17
    CADA_Clinica_Consultorio = 18
    CADA_Tipo_TipoCargo = 19
    CADA_Tipo_TipoConsulta = 20
    CADA_Tipo_TipoDocumentoFinanceiro = 21
    CADA_Tipo_TipeEndereco = 22
    CADA_Tipo_TipoEscolaridade = 23
    CADA_Tipo_TipoEstadoCivil = 24
    CADA_Tipo_TipoMidiaSocial = 25
    CADA_Tipo_TipoPaciente = 26
    CADA_Tipo_TipoPessoa = 27
    CADA_Tipo_TipoRaca = 28
    CADA_Tipo_TipoReferenciaPessoa = 29
    CADA_Tipo_TipoReligiao = 30
    FINA_LançamentodeContasReceber = 31
    FINA_LançamentodeContasPagar = 32
    FINA_LançamentoemContasCaixaContaBancaria = 33
    FINA_ConsultaContasReceber = 34
    FINA_ConsultaContasPagar = 35
    FINA_ConsuladeLançamentoEmContasCaixaContaBancaria = 36
    FINA_Compensacao = 37
    FINA_ConsultaFluxodeCaixa = 38
    FINA_FaturamentodeVendas = 39
    FINA_CondicaoPagamento = 40
    FINA_ContaBancaria = 41
    FINA_ContaCaixa = 42
    FINA_FormaPagamento = 43
    FINA_PlanoContas = 44
    FINA_GrupoPlanodeContas = 45
    FINA_Financiamento = 46
    AGEN_Agendamento = 47
    AGEN_Paciente = 48
    AGEN_ConsultadeAtendimentosRealizados = 49
    AGEN_Execucao = 50
    AGEN_ConsultaprecoProcedimentoseExames = 51
    AGEN_Orcamento = 52
    MEDI_MenuMedico = 53
    VEND_ConsultaVenda = 54
    VEND_ConsultadeVendaPendentes = 55
    VEND_Fechamento = 56
    VEND_AprovacaodeFechamento = 57
    VEND_ConferenciadeFechamento = 58
    CADA_Segurança_GrupoPerimssoes = 59
    CADA_Segurança_Perimssoes = 60
    FINA_Banco = 61
    CADA_Tipo_TipoSexo = 62
    CADA_Clinica_Turno = 63
    CADA_Clinica_ClassificacaoExame = 64

    PERM_AcessoAnamneseEvolucao = 1000
  End Enum

  Public Enum enTipoPermissao
    Incluir = 1
    Alterar = 2
    Excluir = 3
    Consultar = 4
    Permissao = 5
  End Enum

  Public Class clsPermissao
    Public SQ_PERMISSAO As Integer
    Public bIncluir As Boolean = False
    Public bAlterar As Boolean = False
    Public bExcluir As Boolean = False
    Public bConsulta As Boolean = False
    Public bPermissao As Boolean = False
    Public bGravar As Boolean = False
  End Class

  Public oFormMensagem_Mensagem As New Collection

  Dim cPermissao As New Collection
  Dim oFormMensagem As New frmUtil_Mensagem

  Public Sub Main()
    eSistema = enSistema.Clinica

    sPathSistema = FNC_Path_Arquivo(Application.ExecutablePath)

    'If Not DBConectar() Then End

    Dim oFormLogin As New frmLogin

    oFormLogin.Parent = oFormMDI
    oFormLogin.ShowDialog()

    If oFormLogin.AcessoLiberado Then
      FNC_CarregarDados_EmpresaUsuario()
      FNC_CarregarDados_EstacaoTrabalho()
      FNC_UsuarioConfiguracao_Carregar()
      FNC_CarregarAcesso()

      oFormLogin.Dispose()
      oFormLogin = Nothing

      oFormMDI = New frmMDI
      oFormMDI.Text = const_Sistema_Nome
    Else
      Try
        Application.Exit()
      Catch ex As Exception
      End Try
      Try
        End
      Catch ex As Exception
      End Try
    End If
  End Sub

  Public Function PesquisaPessoa_String(Optional NomePessoa As String = "",
                                        Optional TipoPessoa As Integer = -1,
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
                                        Optional bPessoa_Geral As Boolean = False,
                                        Optional iAtivo As Integer = 20,
                                        Optional iID_PESSOA As Integer = 0,
                                        Optional DiaAniversario As Integer = 0,
                                        Optional MesAniversario As Integer = 0,
                                        Optional bCarregarDocumentoComNome As Boolean = False,
                                        Optional bSomenteDS_ID As Boolean = False,
                                        Optional bNaoEmpresa As Boolean = False,
                                        Optional bNome_CPF_CNPJ As Boolean = False,
                                        Optional bConsultaPaciente As Boolean = False,
                                        Optional bSomenteNome As Boolean = False,
                                        Optional sMae As String = "",
                                        Optional sProntuario As String = "") As String
    Dim sSqlText As String = ""
    Dim sSqlText_Where As String = ""
    Dim Documento_SoNumero As String = ""

    sSqlText = "SELECT DISTINCT PES.SQ_PESSOA," &
                               "0," &
                               IIf(bSomenteNome, "RTRIM(PES.NO_PESSOA)",
                                                 "RTRIM(PES.NO_PESSOA)" & IIf(bNome_CPF_CNPJ, " + ' (' + CONCAT(RTRIM(dbo.FC_FormatarCPF_CNPJ(CD_CPF_CNPJ)), ' - ', convert(varchar, DT_NASC_ABERTURA, 103), ' - ', NO_MAE) + ')'", "")) & " NO_PESSOA," &
                               "NO_FANTASIA_REDUZIDO," &
                               "dbo.FC_FormatarCPF_CNPJ(CD_CPF_CNPJ) CD_CPF_CNPJ," &
                               "DS_PACIENTE_PENDENCIAS"

    If Not bSomenteDS_ID Then
      sSqlText = sSqlText &
                      "," & IIf(bConsultaPaciente, "PES.NO_TIPO_PACIENTE", "PES.NO_TIPO_PESSOA") & "," &
                      "dbo.FC_Pessoa_Telefone(PES.SQ_PESSOA) CD_TELEFONES," &
                      "DT_CADASTRO," &
                      "DT_NASC_ABERTURA," &
                      "RIGHT('0' + CAST(DATEPART(DAY, DT_NASC_ABERTURA) AS VARCHAR(2)), 2) + '/' + DATENAME(MONTH, DT_NASC_ABERTURA) NO_DIAMES_ANIVERSARIO," &
                      "NO_NACIONALIDADE," &
                      "NO_NATURALIDADE," &
                      "NO_TIPO_RACA," &
                      "NO_TIPO_RELIGIAO," &
                      "NO_TIPO_SEXO," &
                      "NO_TIPO_ESTADOCIVIL," &
                      "NO_TIPO_ESCOLARIDADE," &
                      "IIF(IC_CLIENTE = 'N', 'Não', 'Sim')," &
                      "IIF(IC_PACIENTE = 'N', 'Não', 'Sim')," &
                      "IIF(IC_FABRICANTE = 'N', 'Não', 'Sim')," &
                      "IIF(IC_FORNECEDOR = 'N', 'Não', 'Sim')," &
                      "IIF(IC_FUNCIONARIO = 'N', 'Não', 'Sim')," &
                      "IIF(IC_PROFISSIONAL = 'N', 'Não', 'Sim')," &
                      "IIF(IC_TRANSPORTADORA = 'N', 'Não', 'Sim')," &
                      "IIF(IC_VENDEDOR = 'N', 'Não', 'Sim')," &
                      "NO_ATIVO," &
                      "dbo.FC_DATEDIFF_Extenso(DT_NASC_ABERTURA, GETDATE(), 'S') DS_IDADE," &
                      "NO_EMPRESA," &
                      "ID_EMPRESA," &
                      "dbo.FC_Pessoa_PodeExcluir(PES.SQ_PESSOA, " & iID_EMPRESA_FILIAL & ")," &
                      "NO_MAE"
    End If

    sSqlText = sSqlText &
               " FROM " & IIf(bPessoa_Geral, "VW_PESSOA_GERAL", IIf(bSomenteDS_ID, "VW_PESSOA_SIMPLES ", "VW_PESSOA")) & " PES"

    If bNaoEmpresa Then
      sSqlText = sSqlText &
               " WHERE SQ_PESSOA NOT IN (SELECT ID_PESSOA FROM TB_PESSOA_EMPRESA)"
    Else
      sSqlText = sSqlText &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
    End If

    If bCarregarDocumentoComNome And Trim(Documento) = "" Then
      Documento = NomePessoa
    End If

    Documento_SoNumero = FNC_SoNumero(Documento)
    If Trim(Documento_SoNumero) = "" Then
      Documento_SoNumero = "X"
    End If

    If iID_PESSOA > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "SQ_PESSOA = " & iID_PESSOA, " AND ")
    End If
    '>>> ESSE BLOCO DEVE FICAR SEMPRE JUNTOS
    If Trim(NomePessoa) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, IIf(bCarregarDocumentoComNome, "(", "") &
                                        "(NO_PESSOA LIKE " & FNC_SQL_FormatarLike(NomePessoa) & " OR " &
                                         "NO_FANTASIA_REDUZIDO LIKE " & FNC_SQL_FormatarLike(NomePessoa) & ")", " AND ")
    End If
    If Trim(Documento) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "(CD_CPF_CNPJ LIKE " & FNC_SQL_FormatarLike(Documento_SoNumero) &
                                         " OR CD_PF_RG LIKE " & FNC_SQL_FormatarLike(Trim(Documento)) &
                                         " OR CD_PJ_IE LIKE " & FNC_SQL_FormatarLike(Trim(Documento)) &
                                         " OR CD_PJ_IM LIKE " & FNC_SQL_FormatarLike(Trim(Documento)) & ")" &
                                         IIf(bCarregarDocumentoComNome, ")", ""), IIf(bCarregarDocumentoComNome, " OR ", " AND "))
    End If
    '>>> ESSE BLOCO DEVE FICAR SEMPRE JUNTOS
    If TipoPessoa > -1 Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_TIPO_PESSOA = " & TipoPessoa, " AND ")
    End If
    If bCliente Then FNC_Str_Adicionar(sSqlText_Where, "IC_CLIENTE = 'S'", " AND ")
    If bFabricante Then FNC_Str_Adicionar(sSqlText_Where, "IC_FABRICANTE = 'S'", " AND ")
    If bFornecedor Then FNC_Str_Adicionar(sSqlText_Where, "IC_FORNECEDOR = 'S'", " AND ")
    If bFuncionario Then FNC_Str_Adicionar(sSqlText_Where, "IC_FUNCIONARIO = 'S'", " AND ")
    If bProfissional Then FNC_Str_Adicionar(sSqlText_Where, "IC_PROFISSIONAL = 'S'", " AND ")
    If bProfissional_ServicoInterno Then FNC_Str_Adicionar(sSqlText_Where, "IC_PROFISSIONAL_SERVICO_INTERNO = 'S'", " AND ")
    If bTransportadora Then FNC_Str_Adicionar(sSqlText_Where, "IC_TRANSPORTADORA = 'S'", " AND ")
    If bVendedor Then FNC_Str_Adicionar(sSqlText_Where, "IC_VENDEDOR = 'S'", " AND ")
    If bPaciente Then FNC_Str_Adicionar(sSqlText_Where, "IC_PACIENTE = 'S'", " AND ")
    If iAtivo <> 0 Then FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_ATIVO = " & iAtivo, " AND ")
    If DiaAniversario > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "DATEPART(DAY, DT_NASC_ABERTURA) = " & DiaAniversario, " AND ")
    End If
    If MesAniversario > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "DATEPART(MONTH, DT_NASC_ABERTURA) = " & MesAniversario, " AND ")
    End If
    If Trim(sMae) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, " NO_MAE LIKE " & FNC_SQL_FormatarLike(sMae), " AND ")
    End If
    If Trim(sProntuario) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, " SQ_PESSOA = " & sProntuario.ToString(), " AND ")
    End If
    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " AND " & sSqlText_Where
    End If

    sSqlText = sSqlText &
               " ORDER BY " & IIf(bSomenteNome, "RTRIM(PES.NO_PESSOA)",
                                                "RTRIM(PES.NO_PESSOA)" & IIf(bNome_CPF_CNPJ, " + ' (' + CONCAT(RTRIM(dbo.FC_FormatarCPF_CNPJ(CD_CPF_CNPJ)), ' - ', convert(varchar, DT_NASC_ABERTURA, 103), ' - ', NO_MAE) + ')'", ""))

    Return sSqlText
  End Function

  Public Function PesquisaProcedimento_String(sAtivo As String,
                                              sNomeProcedimento As String,
                                              sCodigoProcedimento As String,
                                              iTabelaProcedimento As Integer,
                                              iTipoProcedimento As Integer,
                                              iGrupoProcedimento As Integer,
                                              Optional iTipoExame As Integer = 0,
                                              Optional iConvenio As Integer = 0,
                                              Optional iPessoaProfissional As Integer = 0) As String
    Dim sSqlText As String = ""
    Dim sSqlText_Where As String = ""
    Dim sSqlText2 As String = ""

    sSqlText = "SELECT PCD.SQ_PROCEDIMENTO," &
                      "PCD.ID_TABELAPROCEDIMENTO," &
                      "OPC.NO_OPCAO NO_OPT_TIPOPROCEDIMENTO," &
                      "OTE.NO_OPCAO NO_OPT_TIPOEXAME," &
                      "TBP.NO_TABELAPROCEDIMENTO," &
                      "GPP.NO_GRUPOPROCEDIMENTO," &
                      "PCD.CD_PROCEDIMENTO," &
                      "PCD.NO_PROCEDIMENTO," &
                      "TCS.NO_TIPO_CONSULTA," &
                      "ESP.NO_ESPECIALIDADE NO_ESPECIALIDADE_PADRAO," &
                      "IIF(PCD.IC_ATIVO = 'S', 'Sim', 'Não') DS_ATIVO" &
               " FROM TB_PROCEDIMENTO PCD" &
                " INNER JOIN TB_TABELAPROCEDIMENTO TBP ON TBP.SQ_TABELAPROCEDIMENTO = PCD.ID_TABELAPROCEDIMENTO" &
                 " LEFT JOIN TB_OPCAO OPC ON OPC.SQ_OPCAO = PCD.ID_OPT_TIPOPROCEDIMENTO" &
                 " LEFT JOIN TB_OPCAO OTE ON OTE.SQ_OPCAO = PCD.ID_OPT_TIPOEXAME" &
                 " LEFT JOIN TB_GRUPOPROCEDIMENTO GPP ON GPP.SQ_GRUPOPROCEDIMENTO = PCD.ID_GRUPOPROCEDIMENTO" &
                 " LEFT JOIN TB_TIPO_CONSULTA TCS ON TCS.SQ_TIPO_CONSULTA = PCD.ID_TIPO_CONSULTA_PREFERENCIAL" &
                 " LEFT JOIN TB_ESPECIALIDADE ESP ON ESP.SQ_ESPECIALIDADE = PCD.ID_ESPECIALIDADE_PADRAO"

    If Trim(sAtivo) <> "" Then
      If Mid(sAtivo, 1, 1) = "S" Or Mid(sAtivo, 1, 1) = "N" Then
        FNC_Str_Adicionar(sSqlText_Where, "PCD.IC_ATIVO = " & FNC_QuotedStr(Mid(sAtivo, 1, 1)), " AND ")
      End If
    End If
    If Trim(sNomeProcedimento) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "PCD.NO_PROCEDIMENTO LIKE " & FNC_SQL_FormatarLike(sNomeProcedimento), " AND ")
    End If
    If Trim(sCodigoProcedimento) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "PCD.CD_PROCEDIMENTO LIKE " & FNC_SQL_FormatarLike(sCodigoProcedimento), " AND ")
    End If
    If iTabelaProcedimento > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "PCD.ID_TABELAPROCEDIMENTO = " & iTabelaProcedimento, " AND ")
    End If
    If iTipoProcedimento > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "PCD.ID_OPT_TIPOPROCEDIMENTO = " & iTipoProcedimento, " AND ")
    End If
    If iGrupoProcedimento > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "PCD.ID_GRUPOPROCEDIMENTO = " & iGrupoProcedimento, " AND ")
    End If
    If iTipoExame > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "PCD.ID_OPT_TIPOEXAME = " & iTipoExame, " AND ")
    End If
    If iConvenio <> 0 Or iPessoaProfissional <> 0 Then
      sSqlText2 = "SELECT ID_PROCEDIMENTO FROM TB_CONVENIO_PROCEDIMENTO WHERE IC_ATIVO = 'S'"

      If iConvenio <> 0 Then
        FNC_Str_Adicionar(sSqlText2, " ID_CONVENIO = " + iConvenio.ToString(), " AND ")
      End If
      If iPessoaProfissional <> 0 Then
        FNC_Str_Adicionar(sSqlText2, " ID_PESSOA_PROFISSIONAL = " + iPessoaProfissional.ToString(), " AND ")
      End If

      FNC_Str_Adicionar(sSqlText_Where, "SQ_PROCEDIMENTO IN (" & sSqlText2 & ")", " AND ")
    End If
    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " WHERE " & sSqlText_Where
    End If

    sSqlText = sSqlText &
               " ORDER BY TBP.NO_TABELAPROCEDIMENTO, PCD.NO_PROCEDIMENTO"

    Return sSqlText
  End Function

  Public Function PesquisaProduto_String(Optional iIDProduto As Integer = 0,
                                         Optional iIDProdutoEmpresa As Integer = 0,
                                         Optional NomeProduto As String = "",
                                         Optional TipoProduto As Integer = 0,
                                         Optional GrupoProduto As Integer = 0,
                                         Optional Origem As Integer = 0,
                                         Optional Codigo As String = "",
                                         Optional Ativo As String = "T",
                                         Optional bCarregarCodigosComNome As Boolean = False,
                                         Optional bNaoEmpresa As Boolean = False,
                                         Optional bSomenteDS_ID As Boolean = False,
                                         Optional bListarLinhaProduto As Boolean = False,
                                         Optional bNomeCodigo As Boolean = False) As String
    Dim sSqlText
    Dim sSqlText_Where As String = ""

    sSqlText = "SELECT ID_PRODUTO," &
                      "ID_PRODUTO_EMPRESA," &
                      "ID_PRODUTO_LINHA," &
                      "0 Chk," &
                      "CD_PRODUTO," &
                      IIf(bNomeCodigo, "NO_PRODUTO + IIF(ISNULL(CD_BARRA_FABRICANTE, 'X') = 'X', '', ' (' + RTRIM(LTRIM(CD_BARRA_FABRICANTE)) + ')') NO_PRODUTO,", "NO_PRODUTO,") &
                      enListagemProduto_Tipo.Produto.GetHashCode() & " Tipo"

    If Not bSomenteDS_ID Then
      sSqlText = sSqlText & "," &
                            "CD_BARRA_FABRICANTE," &
                            "CD_BARRA," &
                            "NO_UNIDADEMEDIDA," &
                            "NO_GRUPOPRODUTO," &
                            "NO_TIPO_PRODUTO," &
                            "NO_PESSOA_FABRICANTE," &
                            "NO_OPT_ORIGEMPRODUTO," &
                            "CD_CST," &
                            "NO_CST," &
                            "CD_CSOSN," &
                            "NO_CSOSN," &
                            "CD_NCM," &
                            "DS_NCM," &
                            "CD_CST_COFINS," &
                            "NO_CST_COFINS," &
                            "CD_CST_IPI," &
                            "NO_CST_IPI," &
                            "CD_CST_PIS," &
                            "NO_CST_PIS," &
                            "PC_COFINS," &
                            "PC_IPI," &
                            "PC_PIS," &
                            "PC_MVA," &
                            "PC_ALIQUOTA_IBPT_ESTADUAL," &
                            "PC_ALIQUOTA_IBPT_NACIONAL," &
                            "VL_PRECOCUSTO," &
                            "PC_ICMS_ENTRADA," &
                            "PC_ICMS_SAIDA," &
                            "PC_SIMPLESNACIONAL," &
                            "PC_CUSTO_FIXO," &
                            "PC_CUSTO_VARIAVEL," &
                            "PC_OUTROS_IMPOSTOS," &
                            "PC_ICMS_ST," &
                            "PC_FRETE_ENTRADA," &
                            "VL_BRINDE_ACESSORIO," &
                            "VL_PRECOCUSTOTOTAL," &
                            "NR_VALIDADE_COTACAO," &
                            "NR_DIA_ENTREGA_MINIMO," &
                            "DT_CADASTRO," &
                            "IIF(IC_ATIVO = 'S', 'Sim', 'Não') IC_ATIVO," &
                            "DT_ULTIMA_COMPRA," &
                            "DT_ULTIMA_VENDA," &
                            "IIF(IC_CONTROLA_NUMERO_SERIE = 'S', 'Sim', 'Não') IC_CONTROLA_NUMERO_SERIE," &
                            "IIF(IC_CONTROLE_GARANTIA = 'S', 'Sim', 'Não') IC_CONTROLE_GARANTIA," &
                            "NR_MESES_GARANTIA_FORNECEDOR," &
                            "NR_MESES_GARANTIA_REVENDA," &
                            "NO_EMPRESA," &
                            "ID_EMPRESA," &
                            "TP_PODE_EXCLUIR," &
                            "NO_PRODUTO_LINHA," &
                            "ID_UNIDADEMEDIDA"
    End If

    sSqlText = sSqlText &
               " FROM VW_PRODUTO_EMPRESA_FILIAL"

    If bNaoEmpresa Then
      sSqlText = sSqlText &
               " WHERE ID_PRODUTO_EMPRESA NOT IN (SELECT ID_PRODUTO_EMPRESA FROM TB_PRODUTO_EMPRESA_FILIAL WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & ")" &
                 " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL
    Else
      sSqlText = sSqlText &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
    End If

    If bCarregarCodigosComNome And Trim(Codigo) = "" Then
      Codigo = NomeProduto
    End If

    If iIDProduto > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_PRODUTO = " & iIDProduto, " AND ")
    End If
    If iIDProdutoEmpresa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_PRODUTO_EMPRESA = " & iIDProdutoEmpresa, " AND ")
    End If

    '>>> ESSE BLOCO DEVE FICAR SEMPRE JUNTOS
    If Trim(NomeProduto) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, IIf(bCarregarCodigosComNome, "(", "") &
                                        "NO_PRODUTO LIKE " & FNC_SQL_FormatarLike(NomeProduto), " AND ")
    End If
    If Trim(Codigo) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "(CD_PRODUTO LIKE " & FNC_SQL_FormatarLike(Codigo) &
                                     " OR CD_BARRA LIKE " & FNC_SQL_FormatarLike(Trim(Codigo)) &
                                     " OR CD_BARRA_FABRICANTE LIKE " & FNC_SQL_FormatarLike(Trim(Codigo)) & ")" &
                                         IIf(bCarregarCodigosComNome, ")", ""), IIf(bCarregarCodigosComNome, " OR ", " AND "))
    End If
    '>>> ESSE BLOCO DEVE FICAR SEMPRE JUNTOS
    If TipoProduto > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_TIPO_PRODUTO = " & TipoProduto, " AND ")
    End If
    If GrupoProduto > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_GRUPOPRODUTO = " & GrupoProduto, " AND ")
    End If
    If Origem > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_ORIGEMPRODUTO = " & Origem, " AND ")
    End If
    If Ativo <> "T" Then
      FNC_Str_Adicionar(sSqlText_Where, "IC_ATIVO = " & FNC_QuotedStr(Ativo), " AND ")
    End If
    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " AND " & sSqlText_Where
    End If

    If bListarLinhaProduto And Trim(NomeProduto) <> "" Then
      sSqlText = sSqlText &
               " UNION ALL " &
               "SELECT SQ_PRODUTO_LINHA," &
                      "SQ_PRODUTO_LINHA," &
                      "NULL ID_PRODUTO_LINHA," &
                      "0 Chk," &
                      "NULL CD_PRODUTO," &
                      "NO_PRODUTO_LINHA," &
                       enListagemProduto_Tipo.LinhaProduto.GetHashCode()

      If Not bSomenteDS_ID Then
        sSqlText = sSqlText & "," &
                              "NULL CD_BARRA_FABRICANTE," &
                              "NULL CD_BARRA," &
                              "NULL NO_UNIDADEMEDIDA," &
                              "NULL NO_GRUPOPRODUTO," &
                              "NULL NO_TIPO_PRODUTO," &
                              "NULL NO_PESSOA_FABRICANTE," &
                              "NULL NO_OPT_ORIGEMPRODUTO," &
                              "NULL CD_CST," &
                              "NULL NO_CST," &
                              "NULL CD_CSOSN," &
                              "NULL NO_CSOSN," &
                              "NULL CD_NCM," &
                              "NULL DS_NCM," &
                              "NULL CD_CST_COFINS," &
                              "NULL NO_CST_COFINS," &
                              "NULL CD_CST_IPI," &
                              "NULL NO_CST_IPI," &
                              "NULL CD_CST_PIS," &
                              "NULL NO_CST_PIS," &
                              "NULL PC_COFINS," &
                              "NULL PC_IPI," &
                              "NULL PC_PIS," &
                              "NULL PC_MVA," &
                              "NULL PC_ALIQUOTA_IBPT_ESTADUAL," &
                              "NULL PC_ALIQUOTA_IBPT_NACIONAL," &
                              "NULL VL_PRECOCUSTO," &
                              "NULL PC_ICMS_ENTRADA," &
                              "NULL PC_ICMS_SAIDA," &
                              "NULL PC_SIMPLESNACIONAL," &
                              "NULL PC_CUSTO_FIXO," &
                              "NULL PC_CUSTO_VARIAVEL," &
                              "NULL PC_OUTROS_IMPOSTOS," &
                              "NULL PC_ICMS_ST," &
                              "NULL PC_FRETE_ENTRADA," &
                              "NULL VL_BRINDE_ACESSORIO," &
                              "NULL VL_PRECOCUSTOTOTAL," &
                              "NULL NR_VALIDADE_COTACAO," &
                              "NULL NR_DIA_ENTREGA_MINIMO," &
                              "NULL DT_CADASTRO," &
                              "NULL IC_ATIVO," &
                              "NULL DT_ULTIMA_COMPRA," &
                              "NULL DT_ULTIMA_VENDA," &
                              "NULL IC_CONTROLA_NUMERO_SERIE," &
                              "NULL IC_CONTROLE_GARANTIA," &
                              "NULL NR_MESES_GARANTIA_FORNECEDOR," &
                              "NULL NR_MESES_GARANTIA_REVENDA," &
                              "NULL NO_EMPRESA," &
                              "NULL ID_EMPRESA," &
                              "NULL TP_PODE_EXCLUIR," &
                              "NULL NO_PRODUTO_LINHA," &
                              "NULL ID_UNIDADEMEDIDA"
      End If

      sSqlText = sSqlText &
               " FROM TB_PRODUTO_LINHA" &
               " WHERE NO_PRODUTO_LINHA LIKE " & FNC_SQL_FormatarLike(NomeProduto)
    End If

    sSqlText = "SELECT * FROM (" & sSqlText & ") X ORDER BY NO_PRODUTO"

    Return sSqlText
  End Function

  Public Sub FNC_UsuarioConfiguracao_Carregar()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM TB_PESSOA_CONFIGURACAO WHERE ID_PESSOA = " & iID_USUARIO & " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      iUSUARIO_ID_PESSOA_PROFISSIONAL_PADRAO = FNC_NVL(oData.Rows(0).Item("ID_PESSOA_PROFISSIONAL_PADRAO"), 0)
      iUSUARIO_ID_CONTAFINANCEIRA_PADRAO_VENDA = FNC_NVL(oData.Rows(0).Item("ID_CONTAFINANCEIRA_PADRAO_VENDA"), 0)
      iUSUARIO_ID_OPT_CARREGAMENTOAUTOMATICOINICIALIZACAO = FNC_NVL(oData.Rows(0).Item("ID_OPT_CARREGAMENTOAUTOMATICOINICIALIZACAO"), 0)
      bUSUARIO_IC_ATUALIZAR_AGENDA_AUTOMATICO = (FNC_NVL(oData.Rows(0).Item("IC_ATUALIZAR_AGENDA_AUTOMATICO"), "N") = "S")
    End If
  End Sub

  Public Sub FNC_UsuarioConfiguracao_AtualizarAgendaAutomatico(bHabilitar As Boolean)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_CONFIGURACAO_ATUALIZAR_AGENDA_UPD", False, "@ID_EMPRESA",
                                                                                 "@ID_PESSOA",
                                                                                 "@IC_ATUALIZAR_AGENDA_AUTOMATICO")
    DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                         DBParametro_Montar("ID_PESSOA", iID_USUARIO),
                         DBParametro_Montar("IC_ATUALIZAR_AGENDA_AUTOMATICO", IIf(bHabilitar, "S", "N")))
  End Sub

  Public Sub ComboBox_CarregarModeloAnamnese(oCombo As ComboBox)
    Dim sSqlText As String

    sSqlText = "SELECT SQ_QUESTIONARIO_VERSAO ID," &
                      "'Formulário - ' + NO_QUESTIONARIO DS," &
                      const_Anamnese_Formulario & " TP" &
               " FROM VW_QUESTIONARIO_VERSAO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND ID_OPT_TIPOQUESTIONARIO = " & enOpcoes.TipoQuestionarioClinica_Anamnese.GetHashCode &
                 " AND IC_ATIVO = 'S'" &
                 " AND DT_INICIO_USO <= CAST(GETDATE() AS DATE)" &
                 " AND DT_FIM_USO IS NULL" &
               " UNION ALL " &
               "SELECT SQ_MODELODOCUMENTO ID," &
                      "'Modelo de Documento - ' + NO_MODELODOCUMENTO DS," &
                      const_Anamnese_ModeloDocumento & " TP" &
               " FROM TB_MODELODOCUMENTO" &
               " WHERE ID_OPT_TIPO_MODELODOCUMENTO = " & enOpcoes.TipoModeloDocumento_Anamnese.GetHashCode &
                 " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND IC_ATIVO = 'S'"
    sSqlText = "SELECT * FROM (" & sSqlText & ") X ORDER BY DS"
    DBComboBox_Carregar(oCombo, sSqlText)
  End Sub

  Public Sub ComboBox_PossicionarModeloAnamnese(oCombo As ComboBox, iID_MODELODOCUMENTO As Integer, iTipo As Integer)
    Dim iCont As Integer

    For iCont = 0 To oCombo.Items.Count - 1
      If oCombo.Items(iCont)(2) = iTipo And oCombo.Items(iCont)(0) = iID_MODELODOCUMENTO Then
        oCombo.SelectedIndex = iCont
        Exit For
      End If
    Next
  End Sub

  Public Sub ComboBox_CarregarAnamneseEvolucao(oComboBox As ComboBox, iID_Paciente As Integer, iTipoAnamnese As enOpcoes)
    Dim sSqlText As String

    sSqlText = " SELECT SQ_ANAMNESE," &
                       "CONVERT(CHAR(10), DT_ANAMNESE, 103) + ' - ' + NO_PESSOA_PROFISSIONAL DS," &
                       "ID_QUESTIONARIO," &
                       "ID_QUESTIONARIO_VERSAO," &
                       "ID_QUESTIONARIO_RESPOSTA," &
                       "TX_ANAMNESE," &
                       "DT_ANAMNESE," &
                       "NO_PESSOA_PROFISSIONAL" &
                " FROM VW_ANAMNESE" &
                " WHERE ID_PESSOA = " & iID_Paciente &
                  " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                  " AND ID_OPT_TIPOANAMNESE = " & iTipoAnamnese.GetHashCode &
                " ORDER BY DT_ANAMNESE"
    DBComboBox_Carregar(oComboBox, sSqlText)

    If iTipoAnamnese = enOpcoes.TipoModeloDocumento_Anamnese Then
      oComboBox.SelectedIndex = oComboBox.Items.Count - 1
    End If
  End Sub

  Public Sub FNC_CarregarDados_EmpresaUsuario()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = "SELECT dbo.FC_FormatarCPF_CNPJ(EMP.CD_CNPJ) AS CD_CNPJ_FORMATADO, EMP.* FROM VW_EMPRESA EMP WHERE EMP.ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      sPathRepositorioArquivo = FNC_NVL(.Item("DS_PATH_REPOSITORIO_ARQUIVO"), "")
      If Not FNC_CampoNulo(.Item("DS_PATH_REPOSITORIO_ARQUIVO")) Then
        sEMPRESA_DS_PATH_IMAGEM = FNC_DiretorioSistema_AdicionarPath(FNC_NVL(.Item("DS_PATH_IMAGEM"), ""))
      End If
      iMetodoCalculoPreco = FNC_NVL(.Item("ID_OPT_METODOCALCULOPRECO"), enOpcoes.MetodoCalcularPrecoVenda_MetodoPadrao.GetHashCode)
      iEMPRESA_ID_TRANSACAOESTOQUE_PADRAO_COMPRAS = FNC_NVL(.Item("ID_TRANSACAOESTOQUE_PADRAO_COMPRAS"), 0)
      iEMPRESA_ID_TRANSACAOESTOQUE_PADRAO_VENDAS = FNC_NVL(.Item("ID_TRANSACAOESTOQUE_PADRAO_VENDAS"), 0)
      iEMPRESA_ID_PLANOCONTAS_PADRAO_RECEBIMENTO = FNC_NVL(.Item("ID_PLANOCONTAS_PADRAO_RECEBIMENTO"), 0)
      iEMPRESA_ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO = FNC_NVL(.Item("ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO"), 0)
      iEMPRESA_ID_TABELAPROCEDIMENTO_PADRAO = FNC_NVL(.Item("ID_TABELAPROCEDIMENTO_PADRAO"), 0)
      iEMPRESA_ID_MODELODOCUMENTO_RECEITA_PADRAO = FNC_NVL(.Item("ID_MODELODOCUMENTO_RECEITA_PADRAO"), 0)
      iEMPRESA_ID_MODELODOCUMENTO_ANAMNESE_PADRAO = FNC_NVL(.Item("ID_MODELODOCUMENTO_ANAMNESE_PADRAO"), 0)
      iEMPRESA_ID_MODELODOCUMENTO_EVOLUCAO_PADRAO = FNC_NVL(.Item("ID_MODELODOCUMENTO_EVOLUCAO_PADRAO"), 0)
      iEMPRESA_ID_QUESTIONARIO_ANAMNESE_PADRAO = FNC_NVL(.Item("ID_QUESTIONARIO_ANAMNESE_PADRAO"), 0)
      iEMPRESA_ID_MODELODOCUMENTO_RECIBO_PADRAO = FNC_NVL(.Item("ID_MODELODOCUMENTO_RECIBO_PADRAO"), 0)
      iEMPRESA_ID_TIPOCONSULTA_RETORNO = FNC_NVL(.Item("ID_TIPO_CONSULTA_RETORNO"), 0)
      iEMPRESA_ID_TIPO_CONSULTA_VENDA = FNC_NVL(.Item("ID_TIPO_CONSULTA_VENDA"), 0)
      iEMPRESA_ID_SEGMENTO_CRCP_PADRAO = FNC_NVL(.Item("ID_SEGMENTO_CRCP_PADRAO"), 0)
      iEMPRESA_ID_OPT_TIPOCONTROLECONTABIL = FNC_NVL(.Item("ID_OPT_TIPOCONTROLECONTABIL"), 0)
      iEMPRESA_ID_NATUREZAOPERACAO_VENDA = FNC_NVL(.Item("ID_NATUREZAOPERACAO_VENDA"), 0)
      iEMPRESA_ID_TABELAPRECO_PADRAO = FNC_NVL(.Item("ID_TABELAPRECO_PADRAO"), 0)
      iEMPRESA_ID_CANALNEGOCIO_PADRAO_VENDA = FNC_NVL(.Item("ID_CANALNEGOCIO_PADRAO_VENDA"), 0)
      iEMPRESA_ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO = FNC_NVL(.Item("ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO"), 0)
      iEMPRESA_ID_CONDICAOPAGAMENTO_VENDA_PADRAO = FNC_NVL(.Item("ID_CONDICAOPAGAMENTO_VENDA_PADRAO"), 0)
      iEMPRESA_ID_TIPO_DOCUMENTO_PADRAO_VENDA = FNC_NVL(.Item("ID_TIPO_DOCUMENTO_PADRAO_VENDA"), 0)
      iEMPRESA_ID_CONTAFINANCEIRA_PADRAO_VENDA = FNC_NVL(.Item("ID_CONTAFINANCEIRA_PADRAO_VENDA"), 0)
      iEMPRESA_ID_CONTAFINANCEIRA_TESOURARIA = FNC_NVL(.Item("ID_CONTAFINANCEIRA_TESOURARIA"), 0)
      iEMPRESA_ID_CONVENIO_PADRAO = FNC_NVL(.Item("ID_CONVENIO_PADRAO"), 0)
      iEMPRESA_NR_ATENDIMENTO_INTERVALO = FNC_NVL(.Item("NR_ATENDIMENTO_INTERVALO"), 0)
      sEMPRESA_HR_ATENDIMENTO_INICIO = FNC_NVL(.Item("HR_ATENDIMENTO_INICIO"), "")
      sEMPRESA_HR_ATENDIMENTO_SAIDAREFEICAO = FNC_NVL(.Item("HR_ATENDIMENTO_SAIDAREFEICAO"), "")
      sEMPRESA_HR_ATENDIMENTO_RETORNOREFEICAO = FNC_NVL(.Item("HR_ATENDIMENTO_RETORNOREFEICAO"), "")
      sEMPRESA_HR_ATENDIMENTO_FIM = FNC_NVL(.Item("HR_ATENDIMENTO_FIM"), "")
      sEMPRESA_CADASTROTELEFONE_DDD_PADRAO = FNC_NVL(.Item("CADASTROTELEFONE_DDD_PADRAO"), "")
      sEMPRESA_CADASTROTELEFONE_MASCARA = FNC_NVL(.Item("CADASTROTELEFONE_MASCARA"), "")
      sEMPRESA_DADOS_RELATORIO = FNC_NVL(.Item("CD_CNPJ_FORMATADO"), "")

      iEMPRESA_ID_EQUIPAMENTO_PROCESSAMENTO_FISCAL = FNC_NVL(.Item("ID_EQUIPAMENTO_PROCESSAMENTO_FISCAL"), 0)
      iEMPRESA_ID_ORDEMSERVICO_OPT_TIPO_ORDEMSERVICO_PADRAO = FNC_NVL(.Item("ID_ORDEMSERVICO_OPT_TIPO_ORDEMSERVICO_PADRAO"), 0)
      iEMPRESA_ID_ORDEMSERVICO_TABELAPRECO_PADRAO = FNC_NVL(.Item("ID_ORDEMSERVICO_TABELAPRECO_PADRAO"), 0)
      bEMPRESA_ORDEMSERVICO_LISTAGEMPRODUTOMANUTENCAO = (FNC_NVL(.Item("IC_ORDEMSERVICO_LISTAGEMPRODUTOMANUTENCAO"), "N") = "S")
      bEMPRESA_ORDEMSERVICO_DESCRICAOPRODUTOMANUTENCAO = (FNC_NVL(.Item("IC_ORDEMSERVICO_DESCRICAOPRODUTOMANUTENCAO"), "N") = "S")
      bEMPRESA_ORDEMSERVICO_DESCRICAOPRODUTOMANUTENCAO_1OPCAO = (FNC_NVL(.Item("IC_ORDEMSERVICO_DESCRICAOPRODUTOMANUTENCAO_1OPCAO"), "N") = "S")

      sEMPRESA_DADOS_NOMEFANTASIA = FNC_NVL(.Item("NO_FANTASIA_REDUZIDO"), .Item("NO_EMPRESA"))
      sEMPRESA_DADOS_CNPJ = FNC_NVL(.Item("CD_CNPJ_FORMATADO"), "")
      sEMPRESA_DADOS_IE = FNC_NVL(.Item("CD_PJ_IE"), "")
      sEMPRESA_DADOS_IM = FNC_NVL(.Item("CD_PJ_IM"), "")
      bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO = (FNC_NVL(.Item("IC_LISTARTODOS_PROCEDIMENTO"), "N") = "S")
      iEMPRESA_NR_CASASDECIMAIS_VALORES = FNC_NVL(.Item("NR_CASASDECIMAIS_VALORES"), 0)
      iEMPRESA_NR_DIA_VALIDADEORCAMENTO = FNC_NVL(.Item("NR_DIA_VALIDADEORCAMENTO"), 0)
      iEMPRESA_NR_DIA_VALIDADEPEDIDO = FNC_NVL(.Item("NR_DIA_VALIDADEPEDIDO"), 0)
      bEMPRESA_IC_NECESSITA_ANAMNESE_EVOLUCAO = (FNC_NVL(.Item("IC_NECESSITA_ANAMNESE_EVOLUCAO"), "N") = "S")
      bEMPRESA_IC_QUITAR_PROVISIONADO = (FNC_NVL(.Item("IC_QUITAR_PROVISIONADO"), "N") = "S")
      bEMPRESA_IC_PROVISIONADO_POR_PADRAO = (FNC_NVL(.Item("IC_PROVISIONADO_POR_PADRAO"), "N") = "S")

      bEMPRESA_IC_DIAUTIL_DOM = (FNC_NVL(.Item("IC_DIAUTIL_DOM"), "N") = "S")
      bEMPRESA_IC_DIAUTIL_SEG = (FNC_NVL(.Item("IC_DIAUTIL_SEG"), "N") = "S")
      bEMPRESA_IC_DIAUTIL_TER = (FNC_NVL(.Item("IC_DIAUTIL_TER"), "N") = "S")
      bEMPRESA_IC_DIAUTIL_QUA = (FNC_NVL(.Item("IC_DIAUTIL_QUA"), "N") = "S")
      bEMPRESA_IC_DIAUTIL_QUI = (FNC_NVL(.Item("IC_DIAUTIL_QUI"), "N") = "S")
      bEMPRESA_IC_DIAUTIL_SEX = (FNC_NVL(.Item("IC_DIAUTIL_SEX"), "N") = "S")
      bEMPRESA_IC_DIAUTIL_SAB = (FNC_NVL(.Item("IC_DIAUTIL_SAB"), "N") = "S")

      If iID_USUARIO = 1 Then
        sUSUARIO_CD_CPF_CNPJ = sEMPRESA_DADOS_CNPJ
        bUSUARIO_ADMINISTRADOR = True
      End If
    End With

    '>> Endereço
    sSqlText = "SELECT * " &
               " FROM VW_ENDERECO" &
               " WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL &
                 " AND ID_TIPO_ENDERECO = " & enTipoEndereco.Comercial.GetHashCode
    oData = DBQuery(sSqlText)

    If Not objDataTable_CampoVazio(oData) Then
      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          FNC_Str_Adicionar(sEMPRESA_DADOS_RELATORIO, FNC_NVL(.Item("DS_ENDERECO"), ""), " | ")
          sEMPRESA_DADOS_Endereco = FNC_NVL(.Item("DS_ENDERECO"), "") & IIf(Trim(FNC_NVL(.Item("CD_CEP"), "")) = "", "", " CEP: " & .Item("CD_CEP"))
        End With
      End If
    End If

    '>> Telefone
    sSqlText = "SELECT * FROM VW_PESSOA_TELEFONE WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL & " AND ID_TIPO_TELEFONE = " & enTipoTelefone.Comercial.GetHashCode
    oData = DBQuery(sSqlText)

    If Not objDataTable_CampoVazio(oData) Then
      If oData.Rows.Count > 0 Then
        sEMPRESA_DADOS_Telefone = oData.Rows(0).Item("CD_NUMERO")
      End If
    End If

    '>> Midia Social
    sSqlText = "SELECT * FROM VW_PESSOA_MIDIASOCIAL WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    If Not objDataTable_CampoVazio(oData) Then
      For iCont = 0 To oData.Rows.Count - 1
        With oData.Rows(iCont)
          If .Item("ID_TIPO_MIDIASOCIAL") = enTipoMidiaSocial.EMail.GetHashCode Then
            FNC_Str_Adicionar(sEMPRESA_DADOS_RELATORIO, FNC_NVL(.Item("DS_MIDIASOCIAL"), ""), " | ")
            sEMPRESA_DADOS_EMail = FNC_NVL(.Item("DS_MIDIASOCIAL"), "")
          ElseIf .Item("ID_TIPO_MIDIASOCIAL") = enTipoMidiaSocial.WebSite.GetHashCode Then
            sEMPRESA_DADOS_WebSite = FNC_NVL(.Item("DS_MIDIASOCIAL"), "")
          End If
        End With
      Next
    End If

    '>> DADOS DO USÁRIO NA EMPRESA
    sSqlText = "SELECT PSEMP.*, TPCRG.ID_OPT_TIPOFUNCAO" &
               " FROM TB_PESSOA_EMPRESA PSEMP" &
                " LEFT JOIN TB_TIPO_CARGO TPCRG ON TPCRG.SQ_TIPO_CARGO = PSEMP.ID_FUNCIONARIO_TIPO_CARGO" &
               " WHERE PSEMP.ID_PESSOA = " & iID_USUARIO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      bUSUARIO_PROFISSIONAL = (FNC_NVL(oData.Rows(0).Item("IC_PROFISSIONAL"), "N") = "S")
      bUSUARIO_VENDEDOR = (FNC_NVL(oData.Rows(0).Item("IC_VENDEDOR"), "N") = "S")
      iUSUARIO_ID_OPT_TIPOFUNCAO = FNC_NVL(oData.Rows(0).Item("ID_OPT_TIPOFUNCAO"), 0)
      bUSUARIO_ACESSO_SISTEMACHAMADA = (FNC_NVL(oData.Rows(0).Item("IC_FUNCIONARIO_ACESSO_SISTEMACHAMADA"), "N") = "S")
    End If

    '>> DADOS DE SISTEMA
    sSqlText = "SELECT * FROM TB_SISTEMA"
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      sSISTEMA_PathBackupDB = FNC_NVL(oData.Rows(0).Item("DS_PATH_BACKUPDB"), sSISTEMA_PathBackupDB)
      sSISTEMA_LinkWhatsApp_WEB = FNC_NVL(oData.Rows(0).Item("DS_LINK_WHATSAPP_WEB"), sSISTEMA_LinkWhatsApp_WEB)
      sSISTEMA_LlinkChamarCliente = FNC_NVL(oData.Rows(0).Item("DS_LINK_CHAMAR_CLIENTE"), "")
      sSISTEMA_LlinkChamarSenha = FNC_NVL(oData.Rows(0).Item("DS_LINK_CHAMAR_SENHA"), "")
    End If
  End Sub

  Public Sub FNC_WhatsApp(sTelefone As String)
    Try
      System.Diagnostics.Process.Start(sSISTEMA_LinkWhatsApp_WEB.Replace("[TELEFONE]", FNC_FormatarTelefone(sTelefone)))
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Public Sub FNC_CarregarDados_EstacaoTrabalho()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM VW_EMPRESA_ESTACAO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " And NO_ESTACAO = " & FNC_QuotedStr(FNC_Computador_Nome().Trim().ToUpper())
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        sESTACAO_TRABALHO_DS_DIGITALIZADOR_PADRAO = FNC_NVL(.Item("DS_DIGITALIZADOR_PADRAO"), "")
        sESTACAO_TRABALHO_DS_DOCUMENTOFISCAL_PATH_SCHEMAS = FNC_NVL(.Item("DS_DOCUMENTOFISCAL_PATH_SCHEMAS"), "")
        sESTACAO_TRABALHO_DS_CERTIFICADO_DIGITAL_PATH_ARQUIVO = FNC_NVL(.Item("DS_CERTIFICADO_DIGITAL_PATH_ARQUIVO"), "")
        sESTACAO_TRABALHO_DS_CERTIFICADO_DIGITAL_SENHA = FNC_NVL(.Item("DS_CERTIFICADO_DIGITAL_SENHA"), "")
        iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE = FNC_NVL(.Item("ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE"),
                                                                        enOpcoes.AmbienteProcessamento_Homologacao.GetHashCode())
        iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_TIPO = FNC_NVL(.Item("ID_OPT_CERTIFICADO_DIGITAL_TIPO"), 0)
        bESTACAO_TRABALHO_IC_IMPRIME_DANFENCFE_AUTOMATICAMENTE = (FNC_NVL(.Item("IC_IMPRIME_DANFENCFE_AUTOMATICAMENTE"), "N") = "S")
        sESTACAO_TRABALHO_DS_IMPRESSORA_PADRAO_DANFENCFE = FNC_NVL(.Item("DS_IMPRESSORA_PADRAO_DANFENCFE"), "")
        sESTACAO_TRABALHO_DS_FONTE_PADRAO_DANFENCFE = FNC_NVL(.Item("DS_FONTE_PADRAO_DANFENCFE"), "Arial Black")

        iESTACAO_TRABALHO_ID_OPT_NFCe_VERSAO_QRCODE = FNC_NVL(.Item("ID_OPT_NFCe_VERSAO_QRCODE"), 0)
        iESTACAO_TRABALHO_ID_OPT_NFCe_DETALHE_VENDA_NORMAL = FNC_NVL(.Item("ID_OPT_NFCe_DETALHE_VENDA_NORMAL"), 0)
        iESTACAO_TRABALHO_ID_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA = FNC_NVL(.Item("ID_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA"), 0)
        sESTACAO_TRABALHO_CD_NFCe_Token_ID = FNC_NVL(.Item("CD_NFCe_Token_ID"), "")
        sESTACAO_TRABALHO_CD_NFCe_Token_CSC = FNC_NVL(.Item("CD_NFCe_Token_CSC"), "")
        sESTACAO_TRABALHO_CD_OPT_NFCe_VERSAO_QRCODE = FNC_NVL(.Item("CD_OPT_NFCe_VERSAO_QRCODE"), "")
        sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_NORMAL = FNC_NVL(.Item("CD_OPT_NFCe_DETALHE_VENDA_NORMAL"), "")
        sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA = FNC_NVL(.Item("CD_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA"), "")
      End With
    End If
  End Sub

  Public Function FNC_ProximaDataUtil_Local(dData As Date) As Date
    Dim oData As DataTable
    Dim dDataUtil As Date
    Dim sSqlText As String
    Dim bDiaInutil As Boolean

    sSqlText = "SELECT * FROM TB_EMPRESA WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    Do While True
      Select Case dData.DayOfWeek
        Case DayOfWeek.Monday
          bDiaInutil = (FNC_NVL(oData.Rows(0).Item("IC_DIAUTIL_SEG"), "N") = "N")
        Case DayOfWeek.Tuesday
          bDiaInutil = (FNC_NVL(oData.Rows(0).Item("IC_DIAUTIL_TER"), "N") = "N")
        Case DayOfWeek.Wednesday
          bDiaInutil = (FNC_NVL(oData.Rows(0).Item("IC_DIAUTIL_QUA"), "N") = "N")
        Case DayOfWeek.Thursday
          bDiaInutil = (FNC_NVL(oData.Rows(0).Item("IC_DIAUTIL_QUI"), "N") = "N")
        Case DayOfWeek.Friday
          bDiaInutil = (FNC_NVL(oData.Rows(0).Item("IC_DIAUTIL_SEX"), "N") = "N")
        Case DayOfWeek.Saturday
          bDiaInutil = (FNC_NVL(oData.Rows(0).Item("IC_DIAUTIL_SAB"), "N") = "N")
        Case DayOfWeek.Sunday
          bDiaInutil = (FNC_NVL(oData.Rows(0).Item("IC_DIAUTIL_DOM"), "N") = "N")
      End Select

      If Not bDiaInutil Then
        sSqlText = "SELECT COUNT(*) FROM TB_PESSOA_AGENDA" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ((DT_EVENTO = " & FNC_QuotedStr(dData) & ") Or " &
                           "(DAY(DT_EVENTO) = " & dData.Day.ToString & " And " &
                            "MONTH(DT_EVENTO) = " & dData.Month.ToString & " And " &
                            "ISNULL(IC_OCORRE_TODO_ANO_MESMADATA, 'N') = 'S'))"
        bDiaInutil = (DBQuery_ValorUnico(sSqlText) > 0)
      End If

      If Not bDiaInutil Then
        dDataUtil = dData
        Exit Do
      End If

      dData = dData.AddDays(1)
    Loop

    Return dDataUtil
  End Function

  Public Function FNC_CalculaPrecoVenda(PrecoCusto As Double,
                                        ICMSEntrada_Porc As Double,
                                        ICMSST_Porc As Double,
                                        ICMSaida_Porc As Double,
                                        SimplesNacional_Porc As Double,
                                        CustoFixo_Porc As Double,
                                        CustoVariavel_Porc As Double,
                                        OutrosImpostos_Porc As Double,
                                        FreteEntrada_Porc As Double,
                                        FreteSaida_Porc As Double,
                                        Comissao_Porc As Double,
                                        Optional ByRef MargemLucro As Double = 0,
                                        Optional ByRef ICMSEntrada_Valor As Double = 0,
                                        Optional ByRef ICMSST_Valor As Double = 0,
                                        Optional ByRef ICMSaida_Valor As Double = 0,
                                        Optional ByRef SimplesNacional_Valor As Double = 0,
                                        Optional ByRef CustoFixo_Valor As Double = 0,
                                        Optional ByRef CustoVariavel_Valor As Double = 0,
                                        Optional ByRef OutrosImpostos_Valor As Double = 0,
                                        Optional ByRef FreteEntrada_Valor As Double = 0,
                                        Optional ByRef FreteSaida_Valor As Double = 0,
                                        Optional ByRef Comissao_Valor As Double = 0,
                                        Optional ByRef CustoTotal As Double = 0,
                                        Optional ByRef PrecoVenda As Double = 0,
                                        Optional ByRef bCalculando As Boolean = False)
    Dim dEncargos As Double
    Dim dBase As Double
    Dim dCustoCustomizado As Double

    If bCalculando Then GoTo Sair

    bCalculando = True

    Try
      ICMSEntrada_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(ICMSEntrada_Porc, 0))
      ICMSST_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(ICMSST_Porc, 0))
      ICMSaida_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(ICMSaida_Porc, 0))
      SimplesNacional_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(SimplesNacional_Porc, 0))
      CustoFixo_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(CustoFixo_Porc, 0))
      CustoVariavel_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(CustoVariavel_Porc, 0))
      OutrosImpostos_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(OutrosImpostos_Porc, 0))
      FreteEntrada_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(FreteEntrada_Porc, 0))
      FreteSaida_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(FreteSaida_Porc, 0))
      Comissao_Valor = FNC_Porcentagem(PrecoCusto, FNC_NVL(Comissao_Porc, 0))

      If iMetodoCalculoPreco = enOpcoes.MetodoCalcularPrecoVenda_MetodoPadrao Then
        If PrecoCusto > 0 Then
          CustoTotal = (PrecoCusto - ICMSEntrada_Valor) + ICMSaida_Valor + SimplesNacional_Valor + CustoFixo_Valor + CustoVariavel_Valor + OutrosImpostos_Valor + Comissao_Valor + FreteEntrada_Valor + FreteSaida_Valor
          CustoTotal = Math.Round(CustoTotal, iEMPRESA_NR_CASASDECIMAIS_VALORES)

          If FNC_NVL(MargemLucro, 0) > 0 Then
            PrecoVenda = FNC_Porcentagem(CustoTotal, MargemLucro) + CustoTotal
          Else
            MargemLucro = 0
            PrecoVenda = CustoTotal
          End If
        End If
      End If

      If iMetodoCalculoPreco = enOpcoes.MetodoCalcularPrecoVenda_MetodoMarkUp Then
        CustoTotal = (PrecoCusto - ICMSEntrada_Valor) + ICMSaida_Valor + SimplesNacional_Valor + CustoFixo_Valor + CustoVariavel_Valor + OutrosImpostos_Valor + Comissao_Valor + FreteEntrada_Valor + FreteSaida_Valor
        CustoTotal = Math.Round(CustoTotal, iEMPRESA_NR_CASASDECIMAIS_VALORES)
        PrecoVenda = CustoTotal

        dEncargos = ICMSaida_Porc + CustoFixo_Porc + OutrosImpostos_Porc + MargemLucro + FreteEntrada_Porc

        If FNC_NVL(MargemLucro, 0) > 0 Then
          If FNC_NVL(ICMSaida_Porc, 0) +
             FNC_NVL(CustoFixo_Porc, 0) +
             FNC_NVL(OutrosImpostos_Porc, 0) +
             FNC_NVL(FreteEntrada_Porc, 0) = 0 Then
            PrecoVenda = (CustoTotal * dEncargos) + CustoTotal
          Else
            dBase = 1 - (dEncargos)
            If dBase > 0 Then
              PrecoVenda = CustoTotal / dBase
            End If
          End If
        Else
          MargemLucro = 0
          PrecoVenda = CustoTotal
        End If

        PrecoVenda = Microsoft.VisualBasic.Format(PrecoVenda, "##,##.0000")
      End If

      If iMetodoCalculoPreco = enOpcoes.MetodoCalcularPrecoVenda_MetodoDistribuidor Then
        ICMSST_Valor = FNC_Porcentagem(PrecoCusto, ICMSST_Porc)
        CustoTotal = PrecoCusto + ICMSST_Valor
        dCustoCustomizado = CustoTotal

        ICMSaida_Valor = dCustoCustomizado * ICMSaida_Porc
        CustoTotal = CustoTotal + ICMSaida_Valor
        dCustoCustomizado = CustoTotal

        SimplesNacional_Valor = dCustoCustomizado * SimplesNacional_Porc
        CustoTotal = CustoTotal + SimplesNacional_Valor
        dCustoCustomizado = CustoTotal

        CustoFixo_Valor = dCustoCustomizado * CustoFixo_Porc
        CustoTotal = CustoTotal + CustoFixo_Valor
        dCustoCustomizado = CustoTotal

        CustoVariavel_Valor = dCustoCustomizado * CustoVariavel_Porc
        CustoTotal = CustoTotal + CustoVariavel_Valor
        dCustoCustomizado = CustoTotal

        OutrosImpostos_Valor = dCustoCustomizado * OutrosImpostos_Porc
        CustoTotal = CustoTotal + OutrosImpostos_Valor
        dCustoCustomizado = CustoTotal

        FreteEntrada_Valor = dCustoCustomizado * FreteEntrada_Porc
        CustoTotal = CustoTotal + FreteEntrada_Valor
        dCustoCustomizado = CustoTotal

        FreteSaida_Valor = dCustoCustomizado * FreteSaida_Porc
        CustoTotal = CustoTotal + FreteSaida_Valor
        dCustoCustomizado = CustoTotal

        Comissao_Valor = dCustoCustomizado * Comissao_Porc
        CustoTotal = CustoTotal + Comissao_Valor
        dCustoCustomizado = CustoTotal

        CustoTotal = Math.Round(CustoTotal, iEMPRESA_NR_CASASDECIMAIS_VALORES)

        If FNC_NVL(MargemLucro, 0) > 0 Then
          PrecoVenda = (CustoTotal * MargemLucro) + PrecoCusto
        Else
          PrecoVenda = PrecoCusto
        End If
      End If
    Catch ex As Exception
      CustoTotal = PrecoCusto
      PrecoVenda = CustoTotal
    End Try

    bCalculando = False

Sair:
    Return PrecoVenda
  End Function

  Public Sub FNC_GrupoProduto_Carregar(SQ_GRUPOPRODUTO As Integer,
                                       ByRef iID_CST_PADRAO As Integer,
                                       ByRef iID_CSOSN_PADRAO As Integer,
                                       ByRef iID_CST_COFINS_PADRAO As Integer,
                                       ByRef iID_CST_IPI_PADRAO As Integer,
                                       ByRef iID_CST_PIS_PADRAO As Integer)
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM TB_GRUPOPRODUTO WHERE SQ_GRUPOPRODUTO = " & SQ_GRUPOPRODUTO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        iID_CST_PADRAO = FNC_NVL(.Item("ID_CST_PADRAO"), 0)
        iID_CSOSN_PADRAO = FNC_NVL(.Item("ID_CSOSN_PADRAO"), 0)
        iID_CST_COFINS_PADRAO = FNC_NVL(.Item("ID_CST_COFINS_PADRAO"), 0)
        iID_CST_IPI_PADRAO = FNC_NVL(.Item("ID_CST_IPI_PADRAO"), 0)
        iID_CST_PIS_PADRAO = FNC_NVL(.Item("ID_CST_PIS_PADRAO"), 0)
      End With
    End If
  End Sub

  Public Sub FNC_NCM_Carregar(oNCM As System.Windows.Forms.TextBox,
                              iNCM As Integer,
                              sNCM As String,
                              oLabel As System.Windows.Forms.Label,
                              oToolTip As System.Windows.Forms.ToolTip,
                              Optional ByRef AliquiotaIBPT As Double = 0)
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer
    Dim sAux As String = ""

    oNCM.Tag = Nothing

    If iNCM > 0 Or Trim(sNCM) <> "" Then
      If iNCM > 0 Then
        sSqlText = "SELECT SQ_NCM, CD_NCM, DS_NCM, PC_ALIQUOTA_IBPT_ESTADUAL FROM VW_NCM WHERE SQ_NCM = " & iNCM
      Else
        If Len(FNC_SoNumero(sNCM)) <> 8 And Len(sNCM) <> 10 Then
          FNC_Mensagem("O N.C.M. deve ter somente 8 número ou 10 caracteres, entre '.' e números")
          Exit Sub
        End If
        sSqlText = "SELECT SQ_NCM, CD_NCM, DS_NCM, PC_ALIQUOTA_IBPT_ESTADUAL FROM VW_NCM WHERE CD_NCM_SIMPLES = " & Replace(sNCM, ".", "")
      End If

      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        With oData.Rows(iCont)
          oNCM.Text = .Item("CD_NCM")
          oNCM.Tag = .Item("SQ_NCM")
          oLabel.Text = .Item("DS_NCM")
          AliquiotaIBPT = FNC_NVL(.Item("PC_ALIQUOTA_IBPT_ESTADUAL"), 0)
        End With

        sSqlText = "SELECT * FROM DBO.FC_NCM_GRUPO('" & oNCM.Text & "')"
        oData = DBQuery(sSqlText)

        For iCont = 0 To oData.Rows.Count - 1
          With oData.Rows(iCont)
            FNC_Str_Adicionar(sAux, Mid(.Item("CD_NCM") & FNC_StrReplicate(10, "-"), 1, 10) + " " + .Item("DS_NCM"), vbCrLf)
          End With
        Next

        Try
          oToolTip.SetToolTip(oLabel, sAux)
          oToolTip.SetToolTip(oNCM, sAux)

        Catch ex As Exception
        End Try
      End If
    End If
  End Sub

  Public Function FNC_Busca_CFOP_Identificar(sCFOP As String) As Object
    Dim sSqlText As String

    If Trim(sCFOP) = "" Then
      Return Nothing
    Else
      sSqlText = "SELECT SQ_CFOP FROM TB_CFOP WHERE RTRIM(CD_CFOP) = " & FNC_QuotedStr(sCFOP)

      Return DBQuery_ValorUnico(sSqlText, Nothing)
    End If
  End Function

  Public Function FNC_Busca_CPF_CNPJ_Identificar(sCPF As String,
                                                 Optional iID_PESSOA_NOT_IT As Integer = 0,
                                                 Optional sNome As String = "") As Integer
    Dim oData As DataTable
    Dim sSqlText As String

    If Trim(sCPF) = "" Then
      Return 0
    Else
      sSqlText = "SELECT SQ_PESSOA FROM TB_PESSOA" &
                 " WHERE RTRIM(CD_CPF_CNPJ) = " & FNC_QuotedStr(FNC_SoNumero(sCPF)) &
                   " AND SQ_PESSOA NOT IN (" & iID_PESSOA_NOT_IT & ")"

      If Trim(sNome) <> "" Then
        FNC_Str_Adicionar(sSqlText, "UPPER(LTRIM(RTRIM(NO_PESSOA))) = " & FNC_QuotedStr(UCase(sNome).Trim()), " AND ")
      End If

      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        Return 0
      Else
        Return oData.Rows(0).Item("SQ_PESSOA")
      End If
    End If
  End Function

  Public Function FNC_Busca_CSOSN_Identificar(sCSOSN As String) As Object
    Dim sSqlText As String

    If Trim(sCSOSN) = "" Then
      Return Nothing
    Else
      sSqlText = "SELECT SQ_CSOSN FROM TB_CSOSN WHERE RTRIM(CD_CSOSN) = " & FNC_QuotedStr(sCSOSN)

      Return DBQuery_ValorUnico(sSqlText, Nothing)
    End If
  End Function

  Public Function FNC_Busca_CST_Identificar(sCST As String, Grupo As enCST_Grupo) As Object
    Dim sSqlText As String

    If Trim(sCST) = "" Then
      Return Nothing
    Else
      sSqlText = "SELECT SQ_CST FROM TB_CST WHERE RTRIM(CD_CST) = " & FNC_QuotedStr(sCST) & " AND ID_CST_GRUPO = " & Grupo.GetHashCode

      Return DBQuery_ValorUnico(sSqlText, Nothing)
    End If
  End Function

  Public Function FNC_Busca_NCM_Identificar(sNCM As String) As Object
    Dim sSqlText As String

    If Trim(sNCM) = "" Then
      Return Nothing
    Else
      sSqlText = "SELECT SQ_NCM FROM TB_NCM WHERE RTRIM(CD_NCM) = " & FNC_QuotedStr(sNCM)

      Return DBQuery_ValorUnico(sSqlText, Nothing)
    End If
  End Function

  Public Function FNC_Busca_UF(sUF As String) As Object
    Dim sSqlText As String

    If Trim(sUF) = "" Then
      Return Nothing
    Else
      sSqlText = "SELECT SQ_UF FROM TB_UF WHERE RTRIM(CD_UF) = " & FNC_QuotedStr(sUF)

      Return DBQuery_ValorUnico(sSqlText, Nothing)
    End If
  End Function

  Public Function FNC_Busca_Municipio_IBGE(NO_CIDADE As String, CD_UF As String) As Object
    Dim sSqlText As String

    sSqlText = "SELECT CD_IBGE FROM VW_CIDADE WHERE NO_CIDADE = " & FNC_QuotedStr(NO_CIDADE) & " AND CD_UF = " & FNC_QuotedStr(CD_UF)
    Return DBQuery_ValorUnico(sSqlText, Nothing)
  End Function

  Public Function FNC_Busca_Opcao_PorCodigo(sCodigo As String, Tipo As enTipoOpcao) As Object
    Dim sSqlText As String

    If Trim(sCodigo) = "" Then
      Return Nothing
    Else
      sSqlText = "SELECT SQ_OPCAO FROM TB_OPCAO WHERE RTRIM(CD_OPCAO) = " & FNC_QuotedStr(sCodigo) & " AND ID_TIPO_OPCAO = " & Tipo.GetHashCode

      Return DBQuery_ValorUnico(sSqlText, Nothing)
    End If
  End Function

  Public Function FNC_Busca_UnidadeMedida(sUnidadeMedida As String) As Object
    Dim sSqlText As String

    If Trim(sUnidadeMedida) = "" Then
      Return Nothing
    Else
      sSqlText = "SELECT SQ_UNIDADEMEDIDA FROM TB_UNIDADEMEDIDA WHERE RTRIM(CD_UNIDADEMEDIDA) = " & FNC_QuotedStr(sUnidadeMedida)

      Return DBQuery_ValorUnico(sSqlText, Nothing)
    End If
  End Function

  Public Function FNC_Busca_UnidadeMedida_Identificar(sCD_UNIDADEMEDIDA As String) As Object
    Dim sSqlText As String

    If Trim(sCD_UNIDADEMEDIDA) = "" Then
      Return Nothing
    Else
      sSqlText = "SELECT SQ_UNIDADEMEDIDA" &
                 " FROM TB_UNIDADEMEDIDA" &
                 " WHERE CD_UNIDADEMEDIDA = " & FNC_QuotedStr(sCD_UNIDADEMEDIDA) &
                    " OR CD_UNIDADEMEDIDA + IIF(SUBSTRING(CD_UNIDADEMEDIDA, LEN(CD_UNIDADEMEDIDA) - 1, 1) <> ';', ';', '') = " & FNC_QuotedStr(sCD_UNIDADEMEDIDA) &
                    " OR CD_UNIDADEMEDIDA_COMPATIVEL LIKE " & FNC_SQL_FormatarLike(sCD_UNIDADEMEDIDA)
      Return DBQuery_ValorUnico(sSqlText, Nothing)
    End If
  End Function

  Public Function FNC_Busca_TransacaoEstoque_Estoque_Localizacao_Credito(iSQ_TRANSACAOESTOQUE As Integer) As Object
    Return DBQuery_ValorUnico("SELECT ID_ESTOQUE_LOCALIZACAO_CREDITO FROM VW_TRANSACAOESTOQUE X WHERE SQ_TRANSACAOESTOQUE = " & FNC_NVL(iSQ_TRANSACAOESTOQUE, 0), 0)
  End Function

  Public Function FNC_Busca_Estoque_IDEstoque_EstoqueLocalizacao(iSQ_ESTOQUE_LOCALIZACAO As Integer) As Integer
    Return DBQuery_ValorUnico("SELECT ID_ESTOQUE FROM TB_ESTOQUE_LOCALIZACAO WHERE SQ_ESTOQUE_LOCALIZACAO = " & iSQ_ESTOQUE_LOCALIZACAO, 0)
  End Function

  Public Function FNC_Busca_Estoque_NumeroSerie_Existe(iID_ESTOQUE_LOCALIZACAO As Integer,
                                                       iID_ESTOQUE As Integer,
                                                       iID_PRODUTO_EMPRESA As Integer,
                                                       sCD_NUMEROSERIE As String) As Boolean
    Dim sSqlText As String

    If Trim(sCD_NUMEROSERIE) = "" Then
      Return False
    Else
      iID_ESTOQUE = FNC_Busca_Estoque_IDEstoque_EstoqueLocalizacao(iID_ESTOQUE_LOCALIZACAO)

      sSqlText = "SELECT COUNT(*)" &
                 " FROM TB_ESTOQUE_LOCALIZACAO ELC" &
                 " INNER JOIN TB_ESTOQUE_LOCALIZACAO_NUMEROSERIE ELN ON ELN.ID_ESTOQUE_LOCALIZACAO = ELC.SQ_ESTOQUE_LOCALIZACAO" &
                 " WHERE ELC.ID_ESTOQUE = " & iID_ESTOQUE &
                   " AND ELN.ID_PRODUTO_EMPRESA = " & iID_PRODUTO_EMPRESA &
                   " AND ELN.CD_NUMEROSERIE = " & FNC_QuotedStr(sCD_NUMEROSERIE)

      Return (DBQuery_ValorUnico(sSqlText, Nothing) > 0)
    End If
  End Function

  Public Function FNC_Busca_Venda_DocumentoFiscalNumeroSerie(iID_PRODUTO_EMPRESA As Integer,
                                                             sCD_NUMEROSERIE As String) As Integer
    Dim sSqlText As String
    Dim iRet As Integer

    If Trim(sCD_NUMEROSERIE) = "" Then
      Return False
    Else
      sSqlText = "SELECT ID_DOCUMENTOFISCAL_PRODUTO" &
                 " FROM VW_DOCUMENTOFISCAL_PRODUTO_NRSERIE" &
                 " WHERE ID_PRODUTO_EMPRESA = " & iID_PRODUTO_EMPRESA &
                   " AND ID_DOCUMENTOFISCAL_TIPO = " & enTipoDocumentoFiscal.Saida_NotaFiscalSaida.GetHashCode() &
                   " AND UPPER(LTRIM(RTRIM(CD_NUMEROSERIE))) = " & FNC_QuotedStr(sCD_NUMEROSERIE)

      iRet = DBQuery_ValorUnico(sSqlText, 0)

      Return iRet
    End If
  End Function

  Public Function FNC_Busca_MovFinanceiraParcela_ValorDebito(iSQ_MOVFINANCEIRAPARCELA As Integer) As Double
    Dim sSqlText As String
    Dim dRet As Double

    If iSQ_MOVFINANCEIRAPARCELA = 0 Then
      Return 0
    Else
      sSqlText = "SELECT ISNULL(VL_DEBITO, 0) FROM VW_MOVFINANCEIRAPARCELA WHERE SQ_MOVFINANCEIRAPARCELA = " & iSQ_MOVFINANCEIRAPARCELA

      dRet = DBQuery_ValorUnico(sSqlText, 0)

      Return dRet
    End If
  End Function

  Public Function FNC_Busca_TabelaPreco_Produto_Ativo(iSQ_TABELAPRECO As Integer,
                                                      iSQ_PRODUTO As Integer) As Double
    If iSQ_TABELAPRECO > 0 And iSQ_PRODUTO > 0 Then
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT *" &
                 " FROM VW_TABELAPRECO_PRODUTO_ATIVO" &
                 " WHERE ID_TABELAPRECO = " & iSQ_TABELAPRECO &
                   " AND ID_PRODUTO = " & iSQ_PRODUTO
      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        Return 0
      Else
        With oData.Rows(0)
          Return FNC_NVL(.Item("VL_VENDA"), 0)
        End With
      End If
    Else
      Return 0
    End If
  End Function

  Public Function FNC_Busca_Estoque_SaldoMovimentacao(iID_ESTOQUE_LOCALIZACAO As Integer,
                                                      iID_PRODUTO_EMPRESA As Integer) As Double
    Dim sSqlText As String

    sSqlText = "SELECT QT_SALDO - QT_BLOQUEADO QT_SALDO" &
               " FROM TB_ESTOQUE_PRODUTO" &
               " WHERE ID_ESTOQUE_LOCALIZACAO = " & iID_ESTOQUE_LOCALIZACAO &
                 " AND ID_PRODUTO_EMPRESA = " & iID_PRODUTO_EMPRESA

    Return DBQuery_ValorUnico(sSqlText, 0)
  End Function

  Public Function FNC_Busca_Estoque_Produto_ValorMedio(iID_ESTOQUE_LOCALIZACAO As Integer,
                                                       iID_PRODUTO_EMPRESA As Integer) As Double
    Dim sSqlText As String

    sSqlText = "SELECT ISNULL(VL_MEDIO, 0) FROM TB_ESTOQUE_PRODUTO" &
               " WHERE ID_ESTOQUE_LOCALIZACAO = " & iID_ESTOQUE_LOCALIZACAO &
                 " AND ID_PRODUTO_EMPRESA = " & iID_PRODUTO_EMPRESA

    Return DBQuery_ValorUnico(sSqlText, 0)
  End Function

  Public Function FNC_Busca_DocumentoFiscal_NF_Existe(iID_PESSOA As Integer,
                                                      sNF As String) As Boolean
    Dim sSqlText As String

    If Trim(sNF) = "" Then
      Return False
    Else
      sSqlText = "SELECT COUNT(*) FROM TB_DOCUMENTOFISCAL" &
                 " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " AND ID_PESSOA = " & iID_PESSOA &
                   " AND RTRIM(CD_DOCUMENTOFISCAL) = " & FNC_QuotedStr(Trim(sNF)) &
                   " AND ID_OPT_STATUS NOT IN (" & enOpcoes.StatusDocumentoFiscal_Cancelado.GetHashCode & ")"

      Return (DBQuery_ValorUnico(sSqlText, Nothing) > 0)
    End If
  End Function

  Public Function FNC_Busca_DocumentoFiscal_Tipo_SeriePadrao_Venda(iID_DOCUMENTOFISCAL_TIPO As Integer) As Integer
    Dim sSqlText As String

    sSqlText = "SELECT SQ_DOCUMENTOFISCAL_SERIE FROM TB_DOCUMENTOFISCAL_SERIE" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND ID_DOCUMENTOFISCAL_TIPO = " & iID_DOCUMENTOFISCAL_TIPO &
                 " AND ISNULL(IC_PADRAO_VENDA, 'N') = 'S'" &
                 " AND ISNULL(IC_ATIVO, 'N') = 'S'"

    Return DBQuery_ValorUnico(sSqlText, 0)
  End Function

  Public Function FNC_Busca_Financiamento_TabelaPreco_Existe(iID_TABELAPRECO As Integer,
                                                             iID_FINANCIAMENTO As Integer) As Boolean
    Dim sSqlText As String

    If iID_TABELAPRECO = 0 And iID_FINANCIAMENTO = 0 Then
      Return False
    Else
      sSqlText = "SELECT COUNT(*) FROM TB_FINANCIAMENTO_TABELAPRECO" &
                 " WHERE ID_TABELAPRECO = " & iID_TABELAPRECO &
                   " AND ID_FINANCIAMENTO = " & iID_FINANCIAMENTO
      Return (DBQuery_ValorUnico(sSqlText, Nothing) > 0)
    End If
  End Function

  Public Function FNC_Busca_DocumentoFiscal_ID(iID_EMPRESA As Integer,
                                               iID_TIPODOCUMENTOFISCAL As Integer,
                                               sNF As String) As Integer
    Dim sSqlText As String

    If Trim(sNF) = "" Then
      Return 0
    Else
      sSqlText = "SELECT COUNT(*) FROM TB_DOCUMENTOFISCAL" &
                 " WHERE ID_EMPRESA = " & iID_EMPRESA &
                   " AND ID_DOCUMENTOFISCAL_TIPO = " & iID_TIPODOCUMENTOFISCAL &
                   " AND (RTRIM(CD_DOCUMENTOFISCAL) = " & FNC_QuotedStr(Trim(sNF)) & " OR " &
                         "RTRIM(CD_DOCUMENTOFISCAL) = " & FNC_QuotedStr(FNC_StrZero(Trim(sNF), 9)) & ")"

      Return DBQuery_ValorUnico(sSqlText, 0)
    End If
  End Function

  Public Function FNC_Busca_Atendimento_ExisteAnamnese(iSQ_ATENDIMENTO) As Boolean
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM TB_ANAMNESE WHERE ID_ATENDIMENTO = " & iSQ_ATENDIMENTO

    Return (DBQuery_ValorUnico(sSqlText) > 0)
  End Function

  Public Function FNC_Busca_Agendamento_ExisteAtendimento(iSQ_AGENDAMENTO As Integer) As Boolean
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM TB_ATENDIMENTO WHERE ID_AGENDAMENTO = " & iSQ_AGENDAMENTO

    Return (DBQuery_ValorUnico(sSqlText) > 0)
  End Function

  Public Function FNC_Busca_Agendamento_HorarioDisponivel(iID_EMPRESA As Integer,
                                                          iID_PESSOA_PROFISSIONAL As Integer,
                                                          sDH_Inicial As String,
                                                          sDH_Final As String) As DateTime
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_HORARIO_LIVRE", False, "@ID_EMPRESA",
                                                             "@ID_PESSOA",
                                                             "@DH_INICIAL",
                                                             "@DH_FINAL",
                                                             "@DH_DISPONIVEL OUT")

    DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA),
                         DBParametro_Montar("ID_PESSOA", iID_PESSOA_PROFISSIONAL),
                         DBParametro_Montar("DH_INICIAL", sDH_Inicial),
                         DBParametro_Montar("DH_FINAL", sDH_Final),
                         DBParametro_Montar("DH_DISPONIVEL", Nothing, , ParameterDirection.InputOutput))

    Return DBRetorno(1)
  End Function


  Public Function FNC_Busca_Banco_ExisteDepencia(iSQ_BANCO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_CONTAFINANCEIRA WHERE ID_BANCO = " & iSQ_BANCO) > 0 Then
      FNC_Mensagem("Existe conta financeira associada a esse banco")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_DOCUMENTOFINANCEIRO WHERE ID_BANCO = " & iSQ_BANCO) > 0 Then
      FNC_Mensagem("Existe documento financeiro associado a esse banco")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_CanalNegocio_ExisteDepencia(iSQ_CANALNEGOCIO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_EMPRESA WHERE ID_CANALNEGOCIO_PADRAO_VENDA = " & iSQ_CANALNEGOCIO) > 0 Then
      FNC_Mensagem("Esse canal de negócio está cadastrado como Canal de Negócio Padrão de Venda no cadastro de empresa")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PEDIDO WHERE ID_CANALNEGOCIO = " & iSQ_CANALNEGOCIO) > 0 Then
      FNC_Mensagem("Existe pedido associado a esse canal de negócio")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_BuscaVacina_ExisteDepencia(iSQ_CANALNEGOCIO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_EMPRESA WHERE ID_CANALNEGOCIO_PADRAO_VENDA = -" & iSQ_CANALNEGOCIO) > 0 Then
      FNC_Mensagem("Esse canal de negócio está cadastrado como Canal de Negócio Padrão de Venda no cadastro de empresa")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PEDIDO WHERE ID_CANALNEGOCIO = -" & iSQ_CANALNEGOCIO) > 0 Then
      FNC_Mensagem("Existe pedido associado a esse canal de negócio")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_Profissao_ExisteDepencia(iSQ_ID_PROFISSAO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PESSOA_PROFISSAO WHERE ID_PROFISSAO = " & iSQ_ID_PROFISSAO) > 0 Then
      FNC_Mensagem("Existe pessoa associada a essa profissão")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_ProdutoLinha_ExisteDepencia(iSQ_PRODUTO_LINHA As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PEDIDO_PRODUTO WHERE ID_PRODUTO_LINHA = " & iSQ_PRODUTO_LINHA) > 0 Then
      FNC_Mensagem("Existe pedido associado a essa linha de produto")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PRODUTO_EMPRESA_FILIAL WHERE ID_PRODUTO_LINHA = " & iSQ_PRODUTO_LINHA) > 0 Then
      FNC_Mensagem("Existe produto associado a essa linha de produto")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_TABELAPRECO_PRODUTO_LINHA WHERE ID_PRODUTO_LINHA = " & iSQ_PRODUTO_LINHA) > 0 Then
      FNC_Mensagem("Existe table de preço associada a essa linha de produto")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_Departamento_ExisteDepencia(iSQ_DEPARTAMENTO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_ESTOQUE WHERE ID_DEPARTAMENTO_RESPONSAVEL = " & iSQ_DEPARTAMENTO) > 0 Then
      FNC_Mensagem("Existe estoque associado a esse departamento")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_Pais_ExisteDepencia(iSQ_PAIS As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_AGENDA_TELEFONE WHERE ID_PAIS = " & iSQ_PAIS) > 0 Then
      FNC_Mensagem("Existe anotação de histórico de ligação associado a esse pais")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_PlanoContas_ExisteDepencia(iSQ_PLANOCONTAS As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_CONTABILIZACAO_PLANOCONTAS_FPGTO WHERE ID_PLANOCONTAS = " & iSQ_PLANOCONTAS) > 0 Then
      FNC_Mensagem("Existe contabilização associado a esse plano de contas")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_EMPRESA WHERE ID_PLANOCONTAS_PADRAO_RECEBIMENTO = " & iSQ_PLANOCONTAS) > 0 Then
      FNC_Mensagem("Esse plano de contas está cadastrado como Plano de Contas Padrão para Recebimentos no cadastro de empresa")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_MOVFINANCEIRA_PLANOCONTAS WHERE ID_PLANOCONTAS = " & iSQ_PLANOCONTAS) > 0 Then
      FNC_Mensagem("Existe lançamento financeiro associado a esse plano de contas")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_GruoPlanoContas_ExisteDepencia(iSQ_PLANOCONTAS_GRUPO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PLANOCONTAS WHERE ID_PLANOCONTAS_GRUPO = " & iSQ_PLANOCONTAS_GRUPO) > 0 Then
      FNC_Mensagem("Existe plano de contas associado a esse grupo de plano de contas")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_CaracteristicaProduto_ExisteDepencia(iSQ_CARACTERISTICA_PRODUTO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_GRUPOPRODUTO_CARACTERISTICA WHERE ID_CARACTERISTICA_PRODUTO = " & iSQ_CARACTERISTICA_PRODUTO) > 0 Then
      FNC_Mensagem("Existe grupo de produto associado a essa característica de produto")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PRODUTO_CARACTERISTICA WHERE ID_CARACTERISTICA_PRODUTO = " & iSQ_CARACTERISTICA_PRODUTO) > 0 Then
      FNC_Mensagem("Existe produto associado a essa característica de produto")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PRODUTO_LINHA_CARACTERISTICA WHERE ID_CARACTERISTICA_PRODUTO = " & iSQ_CARACTERISTICA_PRODUTO) > 0 Then
      FNC_Mensagem("Existe linha de produto associada a essa característica de produto")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_Cidade_ExisteDepencia(iSQ_CIDADE As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_AGENDA WHERE ID_CIDADE = " & iSQ_CIDADE) > 0 Then
      FNC_Mensagem("Existe Agenda para Anotações/Telefones associado a essa cidade")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_ENDERECO WHERE ID_CIDADE = " & iSQ_CIDADE) > 0 Then
      FNC_Mensagem("Existe endereço associado a essa cidade")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PESSOA WHERE ID_PF_NATURALIDADE = " & iSQ_CIDADE) > 0 Then
      FNC_Mensagem("Existe naturalidade de pessoa associada a essa cidade")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_ConselhoProfissional_ExisteDepencia(iSQ_CONSELHOPROFISSIONAL As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PESSOA_EMPRESA WHERE ID_PROFISSIONAL_CONSELHOPROFISSIONAL = " & iSQ_CONSELHOPROFISSIONAL) > 0 Then
      FNC_Mensagem("Existe cadastro de profissional associado a esse conselho profissional")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_Covenio_ExisteDepencia(iSQ_CONVENIO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_AGENDAMENTO WHERE ID_CONVENIO = " & iSQ_CONVENIO) > 0 Then
      FNC_Mensagem("Existe agendamento associado a esse convênio")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PESSOA_CONVENIO WHERE ID_CONVENIO = " & iSQ_CONVENIO) > 0 Then
      FNC_Mensagem("Existe pessoa associada a esse convênio")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_Segmento_ExisteDepencia(iSQ_SEGMENTO As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PEDIDO WHERE ID_SEGMENTO = " & iSQ_SEGMENTO) > 0 Then
      FNC_Mensagem("Existe pedido associado a esse segmento")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_MOVFINANCEIRA WHERE ID_SEGMENTO = " & iSQ_SEGMENTO) > 0 Then
      FNC_Mensagem("Existe movimentação financeira associada a esse segmento")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_ORDEMSERVICO WHERE ID_SEGMENTO = " & iSQ_SEGMENTO) > 0 Then
      FNC_Mensagem("Existe ordem de serviço associado a esse segmento")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_EMPRESA WHERE ID_SEGMENTO_CRCP_PADRAO = " & iSQ_SEGMENTO) > 0 Then
      FNC_Mensagem("Esse segmento está cadastrado como Segmento de CR/CP Padrão no cadastro de empresa")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_ContaFinanceira_ExisteDepencia(iSQ_CONTAFINANCEIRA As Integer) As Boolean
    Dim bOk As Boolean = True

    If DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_EMPRESA WHERE ID_CONTAFINANCEIRA_PADRAO_VENDA = " & iSQ_CONTAFINANCEIRA) > 0 Then
      FNC_Mensagem("Essa conta financeira está cadastrada como Conta Financeira Padrão de Venda no cadastro de empresa")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_FORMAPAGAMENTO WHERE ID_CONTAFINANCEIRA_QUITACAO = " & iSQ_CONTAFINANCEIRA) > 0 Then
      FNC_Mensagem("Essa conta financeira está cadastrada como Conta Financeiro Quitação no cadastro de forma de pagamento")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PEDIDO WHERE ID_CONTAFINANCEIRA_QUITACAO = " & iSQ_CONTAFINANCEIRA) > 0 Then
      FNC_Mensagem("Essa conta financeira está cadastrada como Conta Financeiro Quitação no cadastro de forma de pagamento")
    ElseIf DBQuery_ValorUnico("SELECT COUNT(*) FROM TB_PESSOA_CONFIGURACAO WHERE ID_CONTAFINANCEIRA_PADRAO_VENDA = " & iSQ_CONTAFINANCEIRA) > 0 Then
      FNC_Mensagem("Essa conta financeira está cadastrada como Conta Financeira Padrão de Venda na configuração de usuário")
    Else
      bOk = False
    End If

    Return bOk
  End Function

  Public Function FNC_Busca_Agendamento_Aberto(iID_PESSOA As Integer) As Integer
    Dim sSqlText As String

    sSqlText = "SELECT SQ_AGENDAMENTO FROM TB_AGENDAMENTO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND ID_PESSOA = " & iID_PESSOA &
                 " AND ID_PESSOA_PROFISSIONAL = " & iID_USUARIO &
                 " AND ID_OPT_STATUS IN (" & enOpcoes.StatusAgendamento_Sistema_ConsultaGerada.GetHashCode & ", " &
                                             enOpcoes.StatusAgendamento_Sistema_Remarcado.GetHashCode & ")"

    Return DBQuery_ValorUnico(sSqlText, 0)
  End Function

  Public Function FNC_Busca_Agendamento_Existe(iID_EMPRESA As Integer,
                                               iID_PESSOA_PROFISSIONAL As Integer,
                                               dDH_AGENDAMENTO As Date) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_AGENDAMENTO_EXISTE", False, "@ID_EMPRESA",
                                                           "@DH_AGENDAMENTO",
                                                           "@ID_PESSOA_PROFISSIONAL",
                                                           "@RET OUT")

    DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA),
                         DBParametro_Montar("DH_AGENDAMENTO", dDH_AGENDAMENTO),
                         DBParametro_Montar("ID_PESSOA_PROFISSIONAL", iID_PESSOA_PROFISSIONAL),
                         DBParametro_Montar("RET", Nothing, , ParameterDirection.InputOutput))

    Return (DBRetorno(1) = "S")
  End Function

  Public Function FNC_Busca_CadastroAgenda_EventoDia(iID_PESSOA As Integer, dData As Date) As Boolean
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM VW_PESSOA_AGENDA" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND ID_PESSOA = " & iID_PESSOA &
                 " AND ((CAST(DT_EVENTO AS DATE) >= " & FNC_QuotedStr(dData) & " AND CAST(DT_EVENTO AS DATE) <= " & FNC_QuotedStr(dData) & ") OR " &
                       "(CAST(DT_EVENTO_FIM AS DATE) >= " & FNC_QuotedStr(dData) & " AND CAST(DT_EVENTO_FIM AS DATE) <= " & FNC_QuotedStr(dData) & "))"

    Return (DBQuery_ValorUnico(sSqlText) > 0)
  End Function

  Public Sub FNC_CarregarAcesso()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim oPermissao As clsPermissao
    Dim bAchou As Boolean

    cPermissao = New Collection

    sSqlText = "SELECT * FROM VW_SEG_USUARIO_ACESSO_GERAL" &
               " WHERE ID_USUARIO = " & iID_USUARIO &
                 " AND ISNULL(ID_EMPRESA, " & iID_EMPRESA_MATRIZ & ") = " & iID_EMPRESA_MATRIZ
    oData = DBQuery(sSqlText)

    For iCont_01 = 0 To oData.Rows.Count - 1
      bAchou = False

      For iCont_02 = 1 To cPermissao.Count
        If cPermissao(iCont_02).SQ_PERMISSAO = oData.Rows(iCont_01).Item("ID_PERMISSAO") Then
          bAchou = True
          Exit For
        End If
      Next

      If Not bAchou Then
        oPermissao = New clsPermissao
        oPermissao.SQ_PERMISSAO = oData.Rows(iCont_01).Item("ID_PERMISSAO")
        cPermissao.Add(oPermissao, "K." & oData.Rows(iCont_01).Item("ID_PERMISSAO"))
      End If

      With cPermissao.Item("K." & oData.Rows(iCont_01).Item("ID_PERMISSAO"))
        Select Case oData.Rows(iCont_01).Item("ID_TIPOPERMISSAO")
          Case enTipoPermissao.Incluir
            .bIncluir = True
            .bGravar = True
          Case enTipoPermissao.Alterar
            .bAlterar = True
            .bGravar = True
          Case enTipoPermissao.Excluir
            .bExcluir = True
          Case enTipoPermissao.Consultar
            .bConsulta = True
          Case enTipoPermissao.Permissao
            .bPermissao = True
        End Select
      End With
    Next

    oData.Dispose()
    oData = Nothing
  End Sub

  Public Function FNC_Permissao_Existe(iID_PERMISSAO As Integer) As Boolean
    Try
      Return cPermissao.Contains("K." & iID_PERMISSAO)
    Catch ex As Exception
      Return False
    End Try
  End Function

  Public Function FNC_Anexo_Gravar(ByRef iSQ_PESSOA_ANEXO As Integer,
                                   iID_PESSOA As Integer,
                                   iID_MODELODOCUMENTO As Integer,
                                   iID_OPT_TIPO_ANEXO As Integer,
                                   iID_ATENDIMENTO As Integer,
                                   iID_PESSOA_AGENDA As Integer,
                                   sDS_ANEXO As String,
                                   dDT_ANEXO As Date,
                                   sDS_PATH_ANEXO As String,
                                   sTX_ANOTACAO As String) As Boolean
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_ANEXO_CAD", False, "@SQ_PESSOA_ANEXO OUT",
                                                         "@ID_PESSOA",
                                                         "@ID_EMPRESA",
                                                         "@ID_MODELODOCUMENTO",
                                                         "@ID_OPT_TIPO_ANEXO",
                                                         "@ID_ATENDIMENTO",
                                                         "@ID_PESSOA_AGENDA",
                                                         "@DS_ANEXO",
                                                         "@DT_ANEXO",
                                                         "@DS_PATH_ANEXO",
                                                         "@TX_ANOTACAO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_ANEXO", FNC_NVL(iSQ_PESSOA_ANEXO, 0), , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_PESSOA", iID_PESSOA),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_MODELODOCUMENTO", FNC_NuloZero(iID_MODELODOCUMENTO, False)),
                            DBParametro_Montar("ID_OPT_TIPO_ANEXO", iID_OPT_TIPO_ANEXO),
                            DBParametro_Montar("ID_ATENDIMENTO", FNC_NuloZero(iID_ATENDIMENTO, False)),
                            DBParametro_Montar("ID_PESSOA_AGENDA", FNC_NuloZero(iID_PESSOA_AGENDA, False)),
                            DBParametro_Montar("DS_ANEXO", Trim(sDS_ANEXO)),
                            DBParametro_Montar("DT_ANEXO", dDT_ANEXO, SqlDbType.DateTime),
                            DBParametro_Montar("DS_PATH_ANEXO", FNC_DiretorioSistema_RemoverPath(sDS_PATH_ANEXO)),
                            DBParametro_Montar("TX_ANOTACAO", sTX_ANOTACAO, SqlDbType.NText)) Then
      If DBTeveRetorno() Then
        iSQ_PESSOA_ANEXO = DBRetorno(1)
      End If
      Return True
    Else
      Return False
    End If
  End Function

  Public Sub FNC_RichTextBoxDocument_Visualizar(ByRef oRichTextBoxDocument As RichTextBoxDocument,
                                                oDoc As RichTextBox,
                                                iID_MODELO_CABECALHO As Integer,
                                                iID_MODELO_ASSINATURA As Integer,
                                                iID_MODELO_RODAPE As Integer,
                                                bExibirNumeroPagina As Boolean)
    Dim oPrintPreviewDialog As New System.Windows.Forms.PrintPreviewDialog()

    If oRichTextBoxDocument Is Nothing Then
      oRichTextBoxDocument = New RichTextBoxDocument(oDoc)
    End If

    oPrintPreviewDialog.Document = FNC_RichTextBoxDocument_Carregar(oRichTextBoxDocument, oDoc, iID_MODELO_CABECALHO, iID_MODELO_ASSINATURA, iID_MODELO_RODAPE, bExibirNumeroPagina)
    oPrintPreviewDialog.ShowDialog()
    oPrintPreviewDialog.Dispose()
    oPrintPreviewDialog = Nothing
  End Sub

  Public Function FNC_RichTextBoxDocument_Carregar(ByRef oRichTextBoxDocument As RichTextBoxDocument,
                                                   oDoc As RichTextBox,
                                                   iID_MODELO_CABECALHO As Integer,
                                                   iID_MODELO_ASSINATURA As Integer,
                                                   iID_MODELO_RODAPE As Integer,
                                                   bExibirNumeroPagina As Boolean) As RichTextBoxDocument
    If oRichTextBoxDocument Is Nothing Then
      oRichTextBoxDocument = New RichTextBoxDocument(oDoc)
    Else
      oRichTextBoxDocument.Document = oDoc
    End If

    If iID_MODELO_CABECALHO <= 0 Then iID_MODELO_CABECALHO = enModeloDocumentoElemento_Padrao.Cabecalho.GetHashCode
    If iID_MODELO_ASSINATURA <= 0 Then iID_MODELO_ASSINATURA = enModeloDocumentoElemento_Padrao.Assinatura.GetHashCode
    If iID_MODELO_RODAPE <= 0 Then iID_MODELO_RODAPE = enModeloDocumentoElemento_Padrao.Rodape.GetHashCode

    With FNC_ModeloDocumentoElemento(iID_MODELO_CABECALHO)
      oRichTextBoxDocument.Header = .Texto
      oRichTextBoxDocument.HeaderFont = .Font
      oRichTextBoxDocument.HeaderAlign = .Alinhamento
    End With
    With FNC_ModeloDocumentoElemento(iID_MODELO_RODAPE)
      oRichTextBoxDocument.Footer = .Texto
      oRichTextBoxDocument.FooterFont = .Font
      oRichTextBoxDocument.FooterAlign = .Alinhamento
    End With

    oRichTextBoxDocument.PageNumber = bExibirNumeroPagina

    Return oRichTextBoxDocument
  End Function

  Public Function FNC_ModeloDocumentoElemento(iSQ_MODELODOCUMENTO_ELEMENTO As Integer) As clsModeloDocumentoElemento
    Dim oData As DataTable
    Dim sSqlText As String
    Dim oRet As New clsModeloDocumentoElemento

    sSqlText = "SELECT * FROM VW_MODELODOCUMENTO_ELEMENTO WHERE SQ_MODELODOCUMENTO_ELEMENTO = " & iSQ_MODELODOCUMENTO_ELEMENTO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      If .Item("IC_SISTEMA") = "S" Then
        Select Case .Item("ID_OPT_TIPO_ELEMENTO")
          Case enOpcoes.TipoElementoModeloDocumento_Cabecalho.GetHashCode
            oRet.Texto = FNC_ModeloDocumentoElemento_CabecalhoPadrao()
          Case enOpcoes.TipoElementoModeloDocumento_Assinatura.GetHashCode
            oRet.Texto = FNC_ModeloDocumentoElemento_AssinaturaPadrao()
          Case enOpcoes.TipoElementoModeloDocumento_Rodape.GetHashCode
            oRet.Texto = FNC_ModeloDocumentoElemento_RodapePadrao()
        End Select
      Else
        If objDataTable_CampoVazio(.Item("TX_MODELODOCUMENTO_ELEMENTO")) Then
          oRet.Texto = "file:" & FNC_DiretorioSistema_AdicionarPath(.Item("DS_PATH_IMAGEM"))
        Else
          oRet.Texto = .Item("TX_MODELODOCUMENTO_ELEMENTO")
        End If
      End If

      oRet.Alinhamento = IIf(FNC_NVL(.Item("IC_ALINHAMENTO"), "E") = "E", StringAlignment.Near,
                                                                          IIf(FNC_NVL(.Item("IC_ALINHAMENTO"), "E") = "C", StringAlignment.Center,
                                                                                                                           StringAlignment.Far))
      If Not objDataTable_CampoVazio(.Item("DS_FONT")) Then
        oRet.Font = FNC_StringToFont(.Item("DS_FONT"))
      End If
    End With

    Return oRet
  End Function

  Public Function FNC_ModeloDocumentoElemento_AssinaturaPadrao() As String

  End Function

  Public Function FNC_ModeloDocumentoElemento_CabecalhoPadrao() As String
    Dim sRet As String

    sRet = UCase(sEMPRESA_DADOS_NOMEFANTASIA)

    Return sRet
  End Function

  Public Function FNC_ModeloDocumentoElemento_RodapePadrao() As String
    Dim sRet As String

    sRet = UCase(sNO_EMPRESA_FILIAL) & vbCrLf &
           "CNPJ.: " & sEMPRESA_DADOS_CNPJ & " INSC. EST.: " & sEMPRESA_DADOS_IE & IIf(Trim(sEMPRESA_DADOS_IM) = "", "", "  INSC. MUNIC.: " & sEMPRESA_DADOS_IM) & vbCrLf &
           sEMPRESA_DADOS_Endereco & " " & sEMPRESA_DADOS_Telefone & vbCrLf &
           "Email: " & IIf(Trim(sEMPRESA_DADOS_EMail) = "", "...", sEMPRESA_DADOS_EMail) & IIf(Trim(sEMPRESA_DADOS_WebSite) = "", "", " Site: " & sEMPRESA_DADOS_WebSite)

    Return sRet
  End Function

  Public Function FNC_Permissao(iID_PERMISSAO As Integer) As clsPermissao
    Try
      Return cPermissao.Item("K." & iID_PERMISSAO)
    Catch ex As Exception
      Return New clsPermissao
    End Try
  End Function

  Public Function FNC_RepositorioArquivo_Arquivo(iSQ_REPOSITORIOARQUIVO As Integer) As String
    Dim oData As DataTable
    Dim sSqlText As String
    Dim sRet As String

    sSqlText = "SELECT * FROM TB_REPOSITORIOARQUIVO WHERE SQ_REPOSITORIOARQUIVO = " & iSQ_REPOSITORIOARQUIVO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      sRet = .Item("DS_PATH_ARQUIVO")
    End With

    Return sRet
  End Function

  Public Function FNC_RepositorioArquivo_ArquivoEmUso(sArquivo As String) As Boolean
    Dim sSqlText As String

    sSqlText = "SELECT dbo.FC_ARQUIVO_EMUSO(" & FNC_QuotedStr(sArquivo) & ")"
    Return (DBQuery_ValorUnico(sSqlText) = "S")
  End Function

  Public Function FNC_RepositorioArquivo_ExcluirArquivo(sArquivo As String) As Boolean
    Dim bOk As Boolean = False

    If Not FNC_RepositorioArquivo_ArquivoEmUso(sArquivo) Then
      Try
        Kill(FNC_DiretorioSistema_AdicionarPath(sArquivo))
        bOk = True
      Catch ex As Exception
      End Try
    End If

    Return bOk
  End Function

  Public Function FNC_Sistema_Dados() As String
    Return const_Sistema_Nome
  End Function

  Public Function FNC_Sistema_Relatorio_Rodape() As String
    Return FNC_Sistema_Dados() & " - (73) 99167-7798 - suporte@dixmed.com.br"
  End Function

  Public Function DBUsuario_ValidarSenha(iID_USUARIO As Integer,
                                         sDS_SENHA As String,
                                         ByRef bEncerrarAplicacao As Boolean) As Boolean
    Dim oData As DataTable
    Dim bOk As Boolean = False
    Dim sSqlText As String

    sSqlText = "SELECT * FROM VW_SEG_USUARIO WHERE ID_USUARIO = " & iID_USUARIO
    oData = DBQuery(sSqlText)

    If oData.Rows.Count = 0 Then
      FNC_Mensagem("Usuário não cadastrado!")
    Else
      If oData.Rows(0).Item("DS_SENHA") = FNC_Criptografia(Trim(sDS_SENHA)) Then
        modDeclaracao.iID_USUARIO = iID_USUARIO
        sNO_USUARIO = oData.Rows(0).Item("NO_PESSOA")
        sNO_USUARIO_RESUMIDO = oData.Rows(0).Item("NO_PESSOA_REDUZIDO")
        sUSUARIO_CD_CPF_CNPJ = oData.Rows(0).Item("CD_CPF_CNPJ")

        If FNC_NVL(oData.Rows(0).Item("IC_TROCARSENHA_PROXIMOACESSO"), "N") = "S" Then
          bEncerrarAplicacao = True

          bOk = FNC_SEGAlterarSenha()
        Else
          bOk = True
        End If
      Else
        FNC_Mensagem("Senha inválida!")
      End If
    End If

    Return bOk
  End Function

  Public Function FNC_SEGAlterarSenha() As Boolean
    Dim oForm As New frmSEGAlterarSenha

    oForm.TopMost = True

    FNC_AbriTela(oForm, , True, True)

    Return oForm.bAlterado
  End Function

  Public Function FNC_CarregarLista(eTipoOpcao As enTipoCadastro, Optional oFiltro As Object = Nothing) As ValueList
    Dim sSqlText As String

    Select Case eTipoOpcao
      Case enTipoCadastro.DiasSemanaPessoaHorario
        sSqlText = "SELECT ID_DIA_SEMANA, NO_DIA_SEMANA FROM VW_DIAS_SEMANA_PESSOA_HORARIO ORDER BY CD_DIA_SEMANA"
      Case enTipoCadastro.Contabilizacao
        sSqlText = "SELECT SQ_CONTABILIZACAO, NO_CONTABILIZACAO FROM TB_CONTABILIZACAO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ISNULL(IC_ATIVO, 'N') = 'S'" &
                   " ORDER BY NO_CONTABILIZACAO"
      Case enTipoCadastro.Funcionario
        sSqlText = "SELECT SQ_PESSOA, NO_PESSOA FROM VW_PESSOA" &
                   " WHERE IC_FUNCIONARIO_ATIVO = 'S'" &
                     " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_PESSOA"
      Case enTipoCadastro.UF
        sSqlText = "SELECT SQ_UF, CD_UF FROM TB_UF" &
                   " ORDER BY CD_UF"
      Case enTipoCadastro.Pais
        sSqlText = "SELECT SQ_PAIS, NO_PAIS FROM TB_PAIS" &
                   " ORDER BY NO_PAIS"
      Case enTipoCadastro.Banco
        sSqlText = "SELECT SQ_BANCO, NO_BANCO FROM TB_BANCO" &
                   " ORDER BY NO_BANCO"
      Case enTipoCadastro.Departamento
        sSqlText = "SELECT SQ_DEPARTAMENTO, NO_DEPARTAMENTO FROM TB_DEPARTAMENTO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND IC_ATIVO = 'S'" &
                   " ORDER BY NO_DEPARTAMENTO"
      Case enTipoCadastro.TipoContaBancaria
        sSqlText = "SELECT SQ_TIPO_CONTAFINANCEIRA, NO_TIPO_CONTAFINANCEIRA FROM TB_TIPO_CONTAFINANCEIRA" &
                   " WHERE ID_OPT_CLASSE NOT IN (" & enOpcoes.ClasseTipoContaFinanceira_ContaCaixa.GetHashCode() & ")" &
                   " ORDER BY NO_TIPO_CONTAFINANCEIRA"
      Case enTipoCadastro.FormaPagamento
        sSqlText = "SELECT SQ_FORMAPAGAMENTO, NO_FORMAPAGAMENTO FROM VW_FORMAPAGAMENTO" &
                   " ORDER BY NO_FORMAPAGAMENTO"
      Case enTipoCadastro.FormaPagamento_QuitarCPCR,
           enTipoCadastro.FormaPagamento_QuitarVenda
        sSqlText = "SELECT SQ_FORMAPAGAMENTO, NO_FORMAPAGAMENTO" &
                   " FROM VW_FORMAPAGAMENTO" &
                   " WHERE ID_OPT_UTILIZACAOFINANCEIRO = " & enOpcoes.TipoUtilizacaoLançamentoFinanceiro_UsarPagamento.GetHashCode()

        If FNC_NVL(oFiltro, "").ToString().Trim <> "" Then
          Select Case eTipoOpcao
            Case enTipoCadastro.FormaPagamento_QuitarCPCR,
                 enTipoCadastro.FormaPagamento_QuitarVenda
              sSqlText = sSqlText &
                  " UNION ALL " &
                   "SELECT DISTINCT " & const_FormaPagamento_CreditoPessoa & ", 'Crédito Pessoa'" &
                   " FROM TB_PESSOA_EMPRESA " &
                   " WHERE ID_PESSOA IN (" & oFiltro.ToString() & ")" &
                     " AND ISNULL(VL_CREDITO, 0) > 0" &
                  " UNION ALL " &
                  "SELECT DISTINCT " & const_FormaPagamento_CreditoCedido & ", 'Crédito Próprio/Cedido'" +
                  " FROM VW_MOVFINANCEIRAPARCELA_DIREITOCREDITO" +
                  " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                    " AND ID_PESSOA_CREDITO IN (" & oFiltro.ToString() & ")" &
                    " AND ID_OPT_STATUS IN (" + enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode().ToString() + ", " +
                                                enOpcoes.StatusMovimentacaoFinanceira_QuitadaParcialmente.GetHashCode().ToString() + ")" &
                    " AND ISNULL(VL_DEBITO, 0) > 0"
          End Select
        End If

        sSqlText = "SELECT * FROM (" & sSqlText & ") X ORDER BY NO_FORMAPAGAMENTO"
      Case enTipoCadastro.PessoaCredito_QuitarCPCR
        sSqlText = "SELECT DISTINCT PEN.SQ_PESSOA, RTRIM(PEN.NO_PESSOA) + ' - ' + FORMAT(VL_CREDITO, 'C', 'pt-br') NO_PESSOA" &
                   " FROM TB_PESSOA_EMPRESA PEM ON PEM.ID_PESSOA = MVF.ID_PESSOA" &
                                             " AND ISNULL(PEM.VL_CREDITO, 0) <> 0" &
                    " INNER JOIN VW_PESSOA_NOME PEN ON PEN.ID_EMPRESA = PEM.ID_EMPRESA" &
                                                 " AND PEN.SQ_PESSOA = PEM.ID_PESSOA" &
                   " WHERE PEM.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND PEM.ID_PESSOA IN (" & oFiltro.ToString() & ")" &
                   " ORDER BY RTRIM(PEN.NO_PESSOA) + ' - ' + FORMAT(VL_CREDITO, 'C', 'pt-br')"
      Case enTipoCadastro.PessoaCredito_QuitarVenda
        sSqlText = "SELECT DISTINCT SQ_PESSOA, NO_PESSOA" &
                   " FROM VW_PESSOA_NOME" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND SQ_PESSOA = " & oFiltro.ToString() &
                   " ORDER BY NO_PESSOA"
      Case enTipoCadastro.PessoaCredito_CreditoCedido
        sSqlText = "SELECT DISTINCT SQ_MOVFINANCEIRAPARCELA," +
                                   "RTRIM(CD_MOVFINANCEIRA_PARCELA) + ' (' + RTRIM(NO_PESSOA) + ') - ' + FORMAT(VL_DEBITO, 'C', 'pt-br') CD_MOVFINANCEIRA_PARCELA" &
                   " FROM VW_MOVFINANCEIRAPARCELA_DIREITOCREDITO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ID_PESSOA_CREDITO IN (" & oFiltro.ToString() & ")" &
                     " AND ID_OPT_STATUS IN (" + enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode().ToString() + ", " +
                                                 enOpcoes.StatusMovimentacaoFinanceira_QuitadaParcialmente.GetHashCode().ToString() + ")" &
                     " AND ISNULL(VL_DEBITO, 0) > 0"
      Case enTipoCadastro.Produto_LinhaProduto
        sSqlText = "SELECT DISTINCT ID_PRODUTO_EMPRESA, NO_PRODUTO" &
                   " FROM VW_PRODUTO_EMPRESA_FILIAL" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ID_PRODUTO_LINHA = " & oFiltro.ToString() &
                   " ORDER BY NO_PRODUTO"
      Case enTipoCadastro.TipoPessoa
        sSqlText = "SELECT SQ_TIPO_PESSOA, NO_TIPO_PESSOA FROM TB_TIPO_PESSOA" &
                   " ORDER BY NO_TIPO_PESSOA"
      Case enTipoCadastro.Sexo
        sSqlText = "SELECT SQ_TIPO_SEXO, NO_TIPO_SEXO FROM TB_TIPO_SEXO" &
                   " ORDER BY NO_TIPO_SEXO"
      Case enTipoCadastro.Legenda
        sSqlText = "SELECT SQ_LEGENDA, NO_LEGENDA FROM TB_LEGENDA" &
                   " ORDER BY NO_LEGENDA"
      Case enTipoCadastro.Profissao
        sSqlText = "SELECT SQ_PROFISSAO, NO_PROFISSAO FROM TB_PROFISSAO" &
                   " ORDER BY NO_PROFISSAO"
      Case enTipoCadastro.MidiaSocial
        sSqlText = "SELECT SQ_TIPO_MIDIASOCIAL, NO_TIPO_MIDIASOCIAL FROM TB_TIPO_MIDIASOCIAL" &
                   " ORDER BY NO_TIPO_MIDIASOCIAL"
      Case enTipoCadastro.TipoTelefone
        sSqlText = "SELECT SQ_TIPO_TELEFONE, NO_TIPO_TELEFONE FROM TB_TIPO_TELEFONE" &
                   " ORDER BY NO_TIPO_TELEFONE"
      Case enTipoCadastro.Convenio
        sSqlText = "SELECT SQ_CONVENIO, NO_CONVENIO FROM TB_CONVENIO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " And IC_ATIVO = 'S'" &
                   " ORDER BY NO_CONVENIO"
      Case enTipoCadastro.TipoEndereco
        sSqlText = "SELECT SQ_TIPO_ENDERECO, NO_TIPO_ENDERECO FROM TB_TIPO_ENDERECO" &
                   " ORDER BY NO_TIPO_ENDERECO"
      Case enTipoCadastro.Cidade
        sSqlText = "SELECT SQ_CIDADE, NO_UF_CIDADE FROM VW_CIDADE" &
                   " ORDER BY NO_UF_CIDADE"
      Case enTipoCadastro.TipoParentesco
        sSqlText = "SELECT SQ_TIPO_PARENTESCO, NO_TIPO_PARENTESCO FROM TB_TIPO_PARENTESCO" &
                   " ORDER BY NO_TIPO_PARENTESCO"
      Case enTipoCadastro.Medicamento
        sSqlText = "SELECT SQ_MEDICAMENTO_APRESENTACAO, NO_MEDICAMENTO_APRESENTACAO FROM VW_MEDICAMENTO_APRESENTACAO" &
                   " ORDER BY NO_MEDICAMENTO_APRESENTACAO"
      Case enTipoCadastro.Procedimento
        sSqlText = "SELECT SQ_PROCEDIMENTO, NO_PROCEDIMENTO FROM TB_PROCEDIMENTO" &
                   " WHERE ID_TABELAPROCEDIMENTO = 13" &
                   " ORDER BY NO_PROCEDIMENTO"
      Case enTipoCadastro.TodosProcedimentos
        sSqlText = "SELECT SQ_PROCEDIMENTO, NO_PROCEDIMENTO FROM TB_PROCEDIMENTO" &
                   " ORDER BY NO_PROCEDIMENTO"
      Case enTipoCadastro.Exame
        sSqlText = "SELECT SQ_PROCEDIMENTO, NO_PROCEDIMENTO FROM TB_PROCEDIMENTO" &
                   " WHERE ID_OPT_TIPOPROCEDIMENTO = 727" &
                   " ORDER BY NO_PROCEDIMENTO"
      Case enTipoCadastro.FaixaEtraria
        sSqlText = "SELECT SQ_FAIXAETARIA, NO_FAIXAETARIA FROM TB_FAIXAETARIA" &
                   " ORDER BY NO_FAIXAETARIA"
      Case enTipoCadastro.CID
        sSqlText = "SELECT SQ_CID, DS_CID2 FROM VW_CID" &
                   " ORDER BY DS_CID2"
      Case enTipoCadastro.PlanoContas_Credito, enTipoCadastro.PlanoContas_Debito
        sSqlText = "SELECT SQ_PLANOCONTAS, NO_PLANOCONTAS_CODIGO" &
                   " FROM VW_PLANOCONTAS" &
                   " WHERE ID_OPT_CREDITODEBITO = " & IIf(eTipoOpcao = enTipoCadastro.PlanoContas_Credito,
                                                                       enOpcoes.CreditoDebito_Credito.GetHashCode,
                                                                       enOpcoes.CreditoDebito_Debito.GetHashCode) &
                     " AND IC_ATIVO = 'S'" &
                   " ORDER BY NO_PLANOCONTAS"
      Case enTipoCadastro.TipoDocumento
        sSqlText = "SELECT SQ_TIPO_DOCUMENTO, NO_TIPO_DOCUMENTO FROM TB_TIPO_DOCUMENTO"

        If Not oFiltro Is Nothing Then
          sSqlText = sSqlText & " WHERE ID_OPT_UTILIZACAOFINANCEIRO = " & oFiltro
        End If

        sSqlText = sSqlText &
                   " ORDER BY NO_TIPO_DOCUMENTO"
      Case enTipoCadastro.TipoServico
        sSqlText = "SELECT SQ_TIPO_SERVICO, NO_TIPO_SERVICO FROM TB_TIPO_SERVICO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_TIPO_SERVICO"
      Case enTipoCadastro.Especialidade
        sSqlText = "SELECT SQ_ESPECIALIDADE, NO_ESPECIALIDADE FROM TB_ESPECIALIDADE" &
                   " ORDER BY NO_ESPECIALIDADE"
      Case enTipoCadastro.TipoReferenciaPessoal
        sSqlText = "SELECT SQ_TIPO_REFERENCIAPESSOA, NO_TIPO_REFERENCIAPESSOA" &
                   " FROM TB_TIPO_REFERENCIAPESSOA" &
                   " WHERE ID_TIPO_PESSOA = " & oFiltro &
                   " ORDER BY NO_TIPO_REFERENCIAPESSOA"
      Case enTipoCadastro.CSOSN
        sSqlText = "SELECT SQ_CSOSN, CD_NO_CSOSN FROM VW_CSOSN" &
                   " ORDER BY CD_NO_CSOSN"
      Case enTipoCadastro.CFOP
        sSqlText = "SELECT SQ_CFOP, CD_DS_CFOP FROM VW_CFOP" &
                   " ORDER BY CD_DS_CFOP"
      Case enTipoCadastro.CST
        sSqlText = "SELECT SQ_CST, CD_NO_CST FROM VW_CST_ICMS" &
                   " ORDER BY CD_NO_CST"
      Case enTipoCadastro.CSTCofins
        sSqlText = "SELECT SQ_CST, CD_NO_CST FROM VW_CST_PIS_COFINS" &
                   " ORDER BY CD_NO_CST"
      Case enTipoCadastro.CSTIPI
        sSqlText = "SELECT SQ_CST, CD_NO_CST FROM VW_CST_IPI" &
                   " ORDER BY CD_NO_CST"
      Case enTipoCadastro.CSTPIS
        sSqlText = "SELECT SQ_CST, CD_NO_CST FROM VW_CST_PIS_COFINS" &
                   " ORDER BY CD_NO_CST"
      Case enTipoCadastro.Estoque
        sSqlText = "SELECT SQ_ESTOQUE, NO_ESTOQUE FROM VW_ESTOQUE" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_ESTOQUE"
      Case enTipoCadastro.TipoDocumentoFiscal_Saida
        sSqlText = "SELECT SQ_DOCUMENTOFISCAL_TIPO, NO_DOCUMENTOFISCAL_TIPO" &
                   " FROM TB_DOCUMENTOFISCAL_TIPO" &
                   " WHERE ID_OPT_NFE_TIPOOPERACAO = " & enOpcoes.NFe_TipoOperacao_Saida.GetHashCode() &
                   " ORDER BY NO_DOCUMENTOFISCAL_TIPO"
      Case enTipoCadastro.TipoDocumentoFiscal_Entrada
        sSqlText = "SELECT SQ_DOCUMENTOFISCAL_TIPO, NO_DOCUMENTOFISCAL_TIPO" &
                   " FROM TB_DOCUMENTOFISCAL_TIPO" &
                   " WHERE ID_OPT_NFE_TIPOOPERACAO = " & enOpcoes.NFe_TipoOperacao_Entrada.GetHashCode() &
                   " ORDER BY NO_DOCUMENTOFISCAL_TIPO"
      Case enTipoCadastro.TipoDocumentoFiscal
        sSqlText = "SELECT SQ_DOCUMENTOFISCAL_TIPO, NO_DOCUMENTOFISCAL_TIPO" &
                   " FROM TB_DOCUMENTOFISCAL_TIPO" &
                   " ORDER BY NO_DOCUMENTOFISCAL_TIPO"
      Case enTipoCadastro.ContaFinanceira
        sSqlText = "SELECT SQ_CONTAFINANCEIRA, NO_CONTAFINANCEIRA FROM VW_CONTAFINANCEIRA" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL

        If Not oFiltro Is Nothing Then
          sSqlText = sSqlText &
                     " And ID_OPT_CLASSE = " & oFiltro
        End If

        sSqlText = sSqlText &
                   " ORDER BY NO_CONTAFINANCEIRA"
      Case enTipoCadastro.PlanoContasGrupo
        sSqlText = "SELECT SQ_PLANOCONTAS_GRUPO, RTRIM(CD_PLANOCONTAS_GRUPO) + '-' + NO_PLANOCONTAS_GRUPO" &
                   " FROM TB_PLANOCONTAS_GRUPO" &
                   " ORDER BY RTRIM(CD_PLANOCONTAS_GRUPO) + '-' + NO_PLANOCONTAS_GRUPO"
      Case enTipoCadastro.UnidadeMedida
        sSqlText = "SELECT SQ_UNIDADEMEDIDA, RTRIM(CD_UNIDADEMEDIDA) + '-' + NO_UNIDADEMEDIDA FROM TB_UNIDADEMEDIDA" &
                   " ORDER BY NO_UNIDADEMEDIDA"
      Case enTipoCadastro.DocumentoFinanceiroDisponivel
        sSqlText = "SELECT SQ_DOCUMENTOFINANCEIRO, ISNULL(DS_BANCO_CONTA_CD_DOCUMENTO, CD_DOCUMENTO) + ' - ' + DS_EMITENTE" &
                   " FROM VW_DOCUMENTOFINANCEIRO" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ID_TIPODOCUMENTO = " & oFiltro &
                     " AND ID_OPT_STATUS = " & enOpcoes.StatusDocumentoFinanceiro_Cadastrado.GetHashCode() &
                     " AND VL_SALDO > 0" &
                   " ORDER BY ISNULL(DS_BANCO_CONTA_CD_DOCUMENTO, CD_DOCUMENTO) + ' - ' + DS_EMITENTE"
      Case enTipoCadastro.TransacaoEstoque,
           enTipoCadastro.TransacaoEstoque_MovimentacaoEstoque_Manual,
           enTipoCadastro.TransacaoEstoque_Recebimento,
           enTipoCadastro.TransacaoEstoque_Venda
        sSqlText = "SELECT SQ_TRANSACAOESTOQUE, NO_TRANSACAOESTOQUE FROM TB_TRANSACAOESTOQUE" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND IC_ATIVO = 'S'"

        Select Case eTipoOpcao
          Case enTipoCadastro.TransacaoEstoque_MovimentacaoEstoque_Manual
            sSqlText = sSqlText & " AND IC_USAR_MOVIMENTACAOMANUAL = 'S'"
          Case enTipoCadastro.TransacaoEstoque_Recebimento
            sSqlText = sSqlText & " AND IC_USAR_RECEBIMENTO = 'S'"
          Case enTipoCadastro.TransacaoEstoque_Venda
            sSqlText = sSqlText & " AND IC_USAR_VENDA = 'S'"
        End Select

        sSqlText = sSqlText &
                   " ORDER BY NO_TRANSACAOESTOQUE"
      Case enTipoCadastro.TipoDocumentoFiscal
        sSqlText = "SELECT SQ_OPCAO, NO_OPCAO FROM TB_OPCAO" &
                   " ORDER BY NO_OPCAO"
      Case Else
        sSqlText = "SELECT SQ_OPCAO, NO_OPCAO FROM TB_OPCAO" &
                   " WHERE ID_TIPO_OPCAO = " & eTipoOpcao.GetHashCode &
                   " ORDER BY NO_OPCAO"
    End Select

    Return DBValueList_Carregar(sSqlText)
  End Function

  Public Sub FNC_Historico_Incluir(iID_OPT_PROCESSO As Integer,
                                   iID_OPT_ACAO As Integer,
                                   iID_OPT_ERRO As Integer,
                                   iID_REGISTRO As Integer,
                                   sDS_HISTORICO As String,
                                   sCD_HISTORICO As String)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_HISTORICO_INS", False, "@ID_EMPRESA",
                                                      "@ID_OPT_PROCESSO",
                                                      "@ID_OPT_ACAO",
                                                      "@ID_OPT_ERRO",
                                                      "@ID_USUARIO",
                                                      "@ID_REGISTRO",
                                                      "@CD_HISTORICO",
                                                      "@DT_HISTORICO",
                                                      "@DS_HISTORICO",
                                                      "@DS_FILTRO",
                                                      "@CD_VERSAO_SISTEMA",
                                                      "@NO_COMPUTADOR_NOME")

    DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                         DBParametro_Montar("ID_OPT_PROCESSO", iID_OPT_PROCESSO),
                         DBParametro_Montar("ID_OPT_ACAO", iID_OPT_ACAO),
                         DBParametro_Montar("ID_OPT_ERRO", FNC_NuloZero(iID_OPT_ERRO, False)),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO),
                         DBParametro_Montar("ID_REGISTRO", iID_REGISTRO),
                         DBParametro_Montar("CD_HISTORICO", FNC_NuloString(sCD_HISTORICO, False)),
                         DBParametro_Montar("DT_HISTORICO", Now, SqlDbType.DateTime),
                         DBParametro_Montar("DS_HISTORICO", FNC_NuloSe(sDS_HISTORICO, ""), , , 1000),
                         DBParametro_Montar("DS_FILTRO", Nothing),
                         DBParametro_Montar("CD_VERSAO_SISTEMA", Application.ProductVersion),
                         DBParametro_Montar("NO_COMPUTADOR_NOME", FNC_Computador_Nome))
  End Sub

  Public Sub FNC_ExecutarScript()
    Dim sArquivo As String = FNC_Diretorio_Tratar(sPathSistema) & "Script.sql"
    Dim sr As System.IO.StreamReader = Nothing
    Dim sb As System.Text.StringBuilder = Nothing

    Dim line As String = ""

    If Dir(sArquivo) = "" Then Exit Sub

    Try
      Dim oCommand As System.Data.Common.DbCommand
      Dim sAux As String = ""

      oCommand = oConexao.CreateCommand()
      oCommand.CommandType = CommandType.Text

      sr = New System.IO.StreamReader(sArquivo)

      Do
        sb = New System.Text.StringBuilder

        Do

          line = sr.ReadLine()
          If (line = "GO" Or line Is Nothing) Then Exit Do

          sb.Append(ControlChars.CrLf & line)
        Loop

        oCommand.CommandText = sb.ToString
        oCommand.ExecuteNonQuery()

        If line Is Nothing Then Exit Do
      Loop Until line Is Nothing

      sr.Close()

      Kill(sArquivo)
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    Finally
      If sr IsNot Nothing Then sr.Close()
      Reset()
    End Try
  End Sub

  Public Sub FNC_AbriTela_ListagemGeral(eListagemGeral_TipoTela As frmListaGeral.enListagemGeral_TipoTela)
    Dim oForm As New frmListaGeral

    oForm.eListagemGeral_TipoTela = eListagemGeral_TipoTela
    FNC_AbriTela(oForm, , , , True, eListagemGeral_TipoTela.GetHashCode)
  End Sub

  Public Sub FNC_PDF_Visualizar(sArquivo)
    If System.IO.File.Exists(sArquivo) Then
      Dim oForm As New frmPDF_Visualizar

      oForm.sArquivo = sArquivo

      FNC_AbriTela(oForm)
    Else
      FNC_Mensagem("Arquivo não encontrado")
    End If
  End Sub

  Public Sub FNC_Form_Container_IdentificarControles(ByVal oControls As Control.ControlCollection)
    Dim aControles(oControls.Count - 1) As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim oBotao As Infragistics.Win.Misc.UltraButton
    Dim oLabel As System.Windows.Forms.Label
    Dim Indice As Integer
    Dim sIdentificadorBotao As String
    Dim oToolTip As New System.Windows.Forms.ToolTip
    Dim bAceitarFocus As Boolean = True

    For iCont_01 = 0 To oControls.Count - 1
      aControles(iCont_01) = oControls(iCont_01).Name
    Next

    For iCont_01 = LBound(aControles) To UBound(aControles)
      iCont_02 = oControls.IndexOfKey(aControles(iCont_01))

      Indice = -1

      If iCont_02 > -1 Then
        If TypeOf oControls(iCont_02) Is Infragistics.Win.Misc.UltraButton Then
          oBotao = oControls(iCont_02)

          If InStr(oBotao.Name, "_") = 0 Then
            sIdentificadorBotao = oBotao.Name
          Else
            sIdentificadorBotao = Left(oBotao.Name, InStr(oBotao.Name, "_") - 1)
          End If

          bAceitarFocus = True
          'Indice = FNC_Form_Container_IdentificarControles_Item(oControls(iCont_02), oToolTip, UCase(sIdentificadorBotao), bAceitarFocus)

          'Form_Botao_Formatar(oBotao, Indice, bAceitarFocus)
        Else
          'se for windows label defino a cor de fundo como transparente
          If TypeOf oControls(iCont_02) Is System.Windows.Forms.Label Then
            oLabel = oControls(iCont_02)
            oLabel.BackColor = Color.Transparent
            oLabel.SendToBack()
          End If
        End If
      End If
    Next
  End Sub

  Public Function FNC_WebCam_CapturarFoto(oPicFoto As PictureBox) As String
    Dim oForm As New frmWebCam_Captura
    Dim sArquivo As String

    oForm.ShowDialog()
    sArquivo = oForm.sArquivoFoto
    oForm.Dispose()

    If Dir(sArquivo) <> "" Then oPicFoto.ImageLocation = sArquivo

    Return sArquivo
  End Function

  Public Sub CarregarDadosPessoa(iSQ_PESSOA As Integer,
                                 oLabelRCPF_CNPJ As Label,
                                 oLabelCPF_CNPJ As Label,
                                 oLabelIE As Label,
                                 oTextBox_Telefone As TextBox)
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT ID_TIPO_PESSOA, dbo.FC_FormatarCPF_CNPJ(CD_CPF_CNPJ) CD_CPF_CNPJ, CD_PJ_IE FROM TB_PESSOA WHERE SQ_PESSOA = " & iSQ_PESSOA
    oData = DBQuery(sSqlText)

    If objDataTable_Vazio(oData) Then
      oLabelCPF_CNPJ.Text = ""
      If Not oLabelIE Is Nothing Then oLabelIE.Text = ""
    Else
      With oData.Rows(0)
        oLabelCPF_CNPJ.Text = IIf(.Item("ID_TIPO_PESSOA") = enTipoPessoa.Juridica.GetHashCode, "C.N.P.J.", "C.P.F.")
        oLabelCPF_CNPJ.Text = FNC_NVL(.Item("CD_CPF_CNPJ"), "")
        If Not oLabelIE Is Nothing Then oLabelIE.Text = FNC_NVL(.Item("CD_PJ_IE"), "")
      End With
    End If

    sSqlText = "SELECT SQ_PESSOA_TELEFONE, CD_NUMERO FROM TB_PESSOA_TELEFONE WHERE ID_PESSOA = " & iSQ_PESSOA
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      If Not oTextBox_Telefone Is Nothing Then
        oTextBox_Telefone.Tag = oData.Rows(0).Item("SQ_PESSOA_TELEFONE")
        oTextBox_Telefone.Text = oData.Rows(0).Item("CD_NUMERO")
      End If
    End If
  End Sub

  Public Function FNC_FormaPagamento_Collection_Carregar() As Collection
    Dim cFORMAPAGAMENTO As New Collection
    Dim oFORMAPAGAMENTO As cFormaPagamento
    Dim sSqlText As String
    Dim oData As DataTable
    Dim iCont As Integer

    sSqlText = "SELECT * FROM VW_FORMAPAGAMENTO"
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      oFORMAPAGAMENTO = New cFormaPagamento

      With oData.Rows(iCont)
        oFORMAPAGAMENTO.SQ_FORMAPAGAMENTO = .Item("SQ_FORMAPAGAMENTO")
        oFORMAPAGAMENTO.ID_TIPO_DOCUMENTO = .Item("ID_TIPO_DOCUMENTO")
        oFORMAPAGAMENTO.ID_OPT_DOCUMENTOCADASTRADO = FNC_NVL(.Item("ID_OPT_DOCUMENTOCADASTRADO"), 0)
        oFORMAPAGAMENTO.ID_OPT_INSTITUICAO_GERADORA = FNC_NVL(.Item("ID_OPT_INSTITUICAO_GERADORA"), -1)
        oFORMAPAGAMENTO.ID_OPT_TIPOFORMAPAGAMENTO = FNC_NVL(.Item("ID_OPT_TIPOFORMAPAGAMENTO"), 0)
        oFORMAPAGAMENTO.NO_FORMAPAGAMENTO = .Item("NO_FORMAPAGAMENTO")
        oFORMAPAGAMENTO.NO_TIPO_DOCUMENTO = .Item("NO_TIPO_DOCUMENTO")
        oFORMAPAGAMENTO.COMPENSA = (FNC_NVL(.Item("IC_COMPENSAR"), "N") = "S")
        oFORMAPAGAMENTO.CADASTRAR_DOCUMENTO = (FNC_NVL(.Item("IC_CADASTRAR_DOCUMENTO"), "N") = "S")
        oFORMAPAGAMENTO.CADASTRAR_CONTABANCARIA = (FNC_NVL(.Item("IC_CADASTRAR_CONTABANCARIA"), "N") = "S")
        oFORMAPAGAMENTO.NO_INSTITUICAO_GERADORA = FNC_NVL(.Item("NO_INSTITUICAO_GERADORA"), "")
        cFORMAPAGAMENTO.Add(oFORMAPAGAMENTO, "K" & .Item("SQ_FORMAPAGAMENTO"))
      End With
    Next

    Return cFORMAPAGAMENTO
  End Function

  Public Function FNC_FormaPagamento_Collection(iID As Integer,
                                                cFormaPagamento As Collection) As cFormaPagamento
    Dim oFORMAPAGAMENTO As New cFormaPagamento
    Dim iCont As Integer
    Dim bAchou As Boolean = False

    If Not cFormaPagamento Is Nothing Then
      For iCont = 1 To cFormaPagamento.Count
        oFORMAPAGAMENTO = cFormaPagamento(iCont)

        If oFORMAPAGAMENTO.SQ_FORMAPAGAMENTO = iID Then
          bAchou = True
          Exit For
        End If
      Next
    End If

    If bAchou Then
      Return oFORMAPAGAMENTO
    Else
      Return New cFormaPagamento
    End If
  End Function

  Public Sub FormMensagem_Exibir(sMensagem As String)
    Try
      oFormMensagem_Mensagem.Add(sMensagem)

      Dim iCont As Integer
      Dim sPopUp As String = ""

      For iCont = 1 To oFormMensagem_Mensagem.Count
        FNC_Str_Adicionar(sPopUp, oFormMensagem_Mensagem(iCont), vbCrLf)
      Next

      oFormMensagem.txtMensagem.Text = sPopUp
      oFormMensagem.Show()

    Catch ex As Exception
    End Try
  End Sub

  Public Function FNC_Busca_Pessoa_Empresa_Credito(iID_Pessoa) As Double
    Dim sSqlText As String

    sSqlText = "SELECT ISNULL(VL_CREDITO, 0)" &
               " FROM TB_PESSOA_EMPRESA" &
               " WHERE ID_PESSOA = " & iID_Pessoa

    Return DBQuery_ValorUnico(sSqlText, 0)
  End Function

  Public Function FNC_Busca_Pedido_MovFinanceira(iID_PEDIDO) As Integer
    Dim sSqlText As String

    sSqlText = "SELECT SQ_MOVFINANCEIRA FROM TB_MOVFINANCEIRA WHERE ID_PEDIDO = " & iID_PEDIDO

    Return DBQuery_ValorUnico(sSqlText, 0)
  End Function

  Public Sub ModeloDocumento_Carregar(ByRef rtbDoc As ExtendedRichTextBox.RichTextBoxPrintCtrl,
                                      iSQ_MODELODOCUMENTO As Integer,
                                      Optional ByRef iID_MODELO_CABECALHO As Integer = 0,
                                      Optional ByRef iID_MODELO_ASSINATURA As Integer = 0,
                                      Optional ByRef iID_MODELO_RODAPE As Integer = 0,
                                      Optional ByRef bExibirNumeroPagina As Boolean = False,
                                      Optional iIDENTIFICADOR As Integer = 0)
    Dim oData As DataTable
    Dim sSqlText As String

    If iSQ_MODELODOCUMENTO > 0 Then
      sSqlText = "SELECT * FROM VW_MODELODOCUMENTO WHERE SQ_MODELODOCUMENTO = " & iSQ_MODELODOCUMENTO
      oData = DBQuery(sSqlText)

      With oData.Rows(0)
        Try
          rtbDoc.Rtf = .Item("TX_MODELODOCUMENTO")
        Catch ex As Exception
        End Try

        iID_MODELO_CABECALHO = FNC_NVL(.Item("ID_MODELO_CABECALHO"), iID_MODELO_CABECALHO)
        iID_MODELO_ASSINATURA = FNC_NVL(.Item("ID_MODELO_ASSINATURA"), iID_MODELO_ASSINATURA)
        iID_MODELO_RODAPE = FNC_NVL(.Item("ID_MODELO_RODAPE"), iID_MODELO_RODAPE)
        bExibirNumeroPagina = (FNC_NVL(.Item("IC_NUMEROPAGINA"), "N") = "S")

        If FNC_NVL(.Item("ID_DICIONARIODADO_PROCESSO"), 0) > 0 Then
          CarregarDicionarioDados_Valores(rtbDoc, FNC_NVL(.Item("ID_DICIONARIODADO_PROCESSO"), 0), iIDENTIFICADOR)
        End If
      End With
    Else
      iID_MODELO_CABECALHO = 0
      iID_MODELO_ASSINATURA = 0
      iID_MODELO_RODAPE = 0
      bExibirNumeroPagina = False
    End If
  End Sub

  Public Sub CarregarDicionarioDados_Valores(ByRef rtbDoc As ExtendedRichTextBox.RichTextBoxPrintCtrl,
                                             iID_DICIONARIODADO_PROCESSO As Integer,
                                             Optional iIDENTIFICADOR As Integer = 0)
    Dim oData_01 As DataTable
    Dim iCont_01 As Integer

    Dim sSqlText As String
    Dim sSqlText_TABELA_MAE As String = ""
    Dim sSqlText_TABELA_FILHO As String = ""
    Dim sSqlText_SELECT As String = ""
    Dim sSqlText_FROM As String = ""
    Dim sSqlText_WHERE As String = ""
    Dim sFiltro As String
    Dim sAux As String

    If iIDENTIFICADOR = 0 Then Exit Sub

    sSqlText = "SELECT * FROM TB_DICIONARIODADO_PROCESSO WHERE SQ_DICIONARIODADO_PROCESSO = " & iID_DICIONARIODADO_PROCESSO
    oData_01 = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData_01) Then
      sFiltro = oData_01.Rows(0).Item("DS_FILTRO")
      sFiltro = Replace(sFiltro, "{EMPRESA}", iID_EMPRESA_FILIAL.ToString)
      sFiltro = Replace(sFiltro, "{USUARIO}", iID_USUARIO.ToString)
      sFiltro = Replace(sFiltro, "{IDENTIFICADOR}", iIDENTIFICADOR.ToString)

      sSqlText_TABELA_MAE = oData_01.Rows(0).Item("DS_TABELA_VIEW")
      sSqlText_WHERE = sFiltro
    End If

    sSqlText = "SELECT * FROM VW_DICIONARIODADO_PROCESSO_VISAO" &
               " WHERE ID_DICIONARIODADO_PROCESSO = " & iID_DICIONARIODADO_PROCESSO
    oData_01 = DBQuery(sSqlText)

    For iCont_01 = 0 To oData_01.Rows.Count - 1
      If Not FNC_In(oData_01.Rows(iCont_01).Item("DS_DB_LIGACAO"), "{USUARIO}", "{EMPRESA}") Then
        With oData_01.Rows(iCont_01)
          'Montar a claúsula FROM
          sSqlText_TABELA_FILHO = .Item("DS_TABELA_VIEW_FILHO") & "_" & iCont_01.ToString
          sAux = .Item("DS_DB_LIGACAO")
          sAux = Replace(sAux, "TABELA_FILHO", sSqlText_TABELA_FILHO)
          sAux = Replace(sAux, "TABELA_MAE", sSqlText_TABELA_MAE)
          sAux = " LEFT JOIN " & .Item("DS_TABELA_VIEW_FILHO") & " " & sSqlText_TABELA_FILHO & " ON " & sAux

          FNC_Str_Adicionar(sSqlText_FROM, sAux, vbCrLf)
        End With

        'Listar os campos
        FNC_Str_Adicionar(sSqlText_SELECT, CarregarDicionarioDados_Valores_Campo(oData_01(iCont_01).Item("ID_DICIONARIODADO_VISAO"), sSqlText_TABELA_FILHO), "," & vbCrLf)
      Else
        CarregarDicionarioDados_Valores_Executar(rtbDoc, iID_DICIONARIODADO_PROCESSO, oData_01.Rows(iCont_01).Item("ID_DICIONARIODADO_VISAO"))
      End If
    Next

    sSqlText = "SELECT " & sSqlText_SELECT & vbCrLf &
               " FROM " & sSqlText_TABELA_MAE & vbCrLf &
                          sSqlText_FROM & vbCrLf &
               " WHERE " & sSqlText_WHERE
    CarregarDicionarioDados_Valores_Listar(rtbDoc, sSqlText)

    CarregarDicionarioDados_Valores_Listar_Sistema(rtbDoc)
  End Sub

  Public Function CarregarDicionarioDados_Valores_Campo(iSQ_DICIONARIODADO_VISAO As Integer, sTABELA_FILHO As String) As String
    Dim oData As DataTable
    Dim sSqlText As String
    Dim sAux As String = ""
    Dim sRet As String = ""

    sSqlText = "SELECT * FROM VW_DICIONARIODADO_VISAO_CAMPO WHERE SQ_DICIONARIODADO_VISAO = " & iSQ_DICIONARIODADO_VISAO
    oData = DBQuery(sSqlText)

    For iCont_02 = 0 To oData.Rows.Count - 1
      With oData(iCont_02)
        sAux = Trim(.Item("NO_CAMPO_MACRO"))
        sAux = "#" & Replace(sAux, "#", "_" & Trim(.Item("SQ_DICIONARIODADO_VISAO").ToString) & "#", 2)

        If InStr(.Item("NO_CAMPO_INTERNO"), "TABELA.") = 0 Then
          FNC_Str_Adicionar(sRet, sTABELA_FILHO & "." & .Item("NO_CAMPO_INTERNO") & " " & FNC_QuotedStr(sAux), "," & vbCrLf)
        Else
          FNC_Str_Adicionar(sRet, Replace(.Item("NO_CAMPO_INTERNO"), "TABELA.", sTABELA_FILHO & ".") & " " & FNC_QuotedStr(sAux), "," & vbCrLf)
        End If
      End With
    Next

    Return sRet
  End Function

  Public Sub CarregarDicionarioDados_Valores_Executar(ByRef rtbDoc As ExtendedRichTextBox.RichTextBoxPrintCtrl,
                                                      iID_DICIONARIODADO_PROCESSO As Integer,
                                                      iID_DICIONARIODADO_VISAO As Integer)
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM VW_DICIONARIODADO_PROCESSO_VISAO" &
               " WHERE ID_DICIONARIODADO_PROCESSO = " & iID_DICIONARIODADO_PROCESSO &
                 " AND ID_DICIONARIODADO_VISAO = " & iID_DICIONARIODADO_VISAO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        sSqlText = "SELECT " & CarregarDicionarioDados_Valores_Campo(iID_DICIONARIODADO_VISAO, .Item("DS_TABELA_VIEW_FILHO")) &
                   " FROM " & .Item("DS_TABELA_VIEW_FILHO") &
                   " WHERE SQ_PESSOA = " & IIf(.Item("DS_DB_LIGACAO") = "{USUARIO}", iID_USUARIO, IIf(.Item("DS_DB_LIGACAO") = "{EMPRESA}", iID_EMPRESA_FILIAL, 0))
      End With
    End If

    CarregarDicionarioDados_Valores_Listar(rtbDoc, sSqlText)
  End Sub

  Public Sub CarregarDicionarioDados_Valores_Listar(ByRef rtbDoc As ExtendedRichTextBox.RichTextBoxPrintCtrl,
                                                    sSqlText As String)
    Dim oData As DataTable
    Dim iCont As Integer

    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      For iCont = 0 To oData.Columns.Count - 1
        If objDataTable_CampoVazio(oData.Rows(0).Item(iCont)) Then
          rtbDoc.Rtf = Replace(rtbDoc.Rtf, Trim(oData.Columns(iCont).ColumnName), "", , , CompareMethod.Text)
        Else
          If FNC_In(oData.Rows(0).Item(iCont).GetType.ToString, "System.DateTime", "System.Decimal") Then
            CarregarDicionarioDados_Valores_Listar_Calcular_Pesquisar(rtbDoc, oData.Columns(iCont).ColumnName, oData.Rows(0).Item(iCont))
          Else
            rtbDoc.Rtf = Replace(rtbDoc.Rtf, Trim(oData.Columns(iCont).ColumnName), oData.Rows(0).Item(iCont), , , CompareMethod.Text)
          End If
        End If
      Next
    End If
  End Sub

  Public Sub CarregarDicionarioDados_Valores_Listar_Sistema(ByRef rtbDoc As ExtendedRichTextBox.RichTextBoxPrintCtrl)
    CarregarDicionarioDados_Valores_Listar_Calcular_Pesquisar(rtbDoc, const_Sistema_DicionarioDados_Menu_Data, Now)
    rtbDoc.Rtf = Replace(rtbDoc.Rtf, const_Sistema_DicionarioDados_Menu_Nome, FNC_Sistema_Dados, , , CompareMethod.Text)
  End Sub

  Public Sub CarregarDicionarioDados_Valores_Listar_Calcular_Pesquisar(ByRef rtbDoc As ExtendedRichTextBox.RichTextBoxPrintCtrl,
                                                                       sTAG As String,
                                                                       oValor As Object)
    Dim StartPosition As Integer
    Dim oRet As Object
    Dim sFatorExemplo As String = ""

    Do While True
      StartPosition = InStr(1, rtbDoc.Text, Trim(sTAG), CompareMethod.Text)

      If StartPosition = 0 Then Exit Do

      oRet = CarregarDicionarioDados_Valores_Listar_Calcular(oValor,
                                                             Mid(rtbDoc.Text, StartPosition + Len(Trim(sTAG)), 9),
                                                             sFatorExemplo)
      sFatorExemplo = Trim(sTAG) & sFatorExemplo

      rtbDoc.Select(StartPosition - 1, Len(sFatorExemplo))
      rtbDoc.SelectedText = oRet

      StartPosition = StartPosition + 1
    Loop
  End Sub

  Private Function CarregarDicionarioDados_Valores_Listar_Calcular(oValor As Object,
                                                                   sFator As String,
                                                                   ByRef sFatorExemplo As String) As Object
    Dim oRet As Object = oValor
    Dim bOk As Boolean

    sFatorExemplo = Mid(sFator, 1, 3) + Mid(sFator, 5, 1) + "00" + Mid(sFator, 8, 1)
    bOk = FNC_In(sFatorExemplo, "#DN+00#", "#DN-00#", "#MN+00#", "#MN-00#", "#AN+00#", "#AN-00#", "#HN+00#", "#HN-00#",
                                "#DU+00#", "#DU-00#", "#MU+00#", "#MU-00#", "#AU+00#", "#AU-00#", "#HU+00#", "#HU-00#")

    If bOk Then
      Select Case Mid(sFatorExemplo, 1, 2)
        Case "#D"
          oRet = oRet.AddDays(IIf(Mid(sFator, 5, 1) = "+", 1, -1) * Int(Mid(sFator, 6, 2)))
        Case "#M"
          oRet = oRet.AddMonths(IIf(Mid(sFator, 5, 1) = "+", 1, -1) * Int(Mid(sFator, 6, 2)))
        Case "#A"
          oRet = oRet.AddYears(IIf(Mid(sFator, 5, 1) = "+", 1, -1) * Int(Mid(sFator, 6, 2)))
        Case "#H"
          oRet = oRet.AddHours(IIf(Mid(sFator, 5, 1) = "+", 1, -1) * Int(Mid(sFator, 6, 2)))
      End Select

      If Mid(sFator, 3, 1) = "U" Then
        oRet = FNC_ProximaDataUtil_Local(oRet)
      End If

      Select Case Mid(sFator, 4, 1)
        Case "E"
          oRet = FNC_Data_Extenso(oRet)
        Case "F"
          oRet = FNC_Data_Extenso(oRet, enFormatoHora.HHMMSS_Extenso)
        Case "G"
          oRet = Mid(oRet.ToString, 1, 10) & " às " & Mid(oRet.ToString, 11).TrimEnd
        Case "H"
          oRet = Mid(oRet.ToString, 11).Trim
        Case "I"
          oRet = FNC_Hora_Extenso(Now, True)
        Case "J"
          oRet = FNC_Data_Extenso(oRet, enFormatoHora.HHMMSS)
        Case Else
          oRet = Mid(oRet.ToString, 1, 10)
      End Select

      sFatorExemplo = Replace(sFatorExemplo, "00", Mid(sFator, 6, 2))
      sFatorExemplo = Mid(sFatorExemplo, 1, 3) + Mid(sFator, 4, 2) + Mid(sFatorExemplo, 5)
    End If

    If Not bOk Then
      sFatorExemplo = Mid(sFator, 1, 3) + "00000" + Mid(sFator, 9, 1)
      bOk = FNC_In(sFatorExemplo, const_Sistema_DicionarioDados_Menu_CalculoMatematico_Adicionar,
                                  const_Sistema_DicionarioDados_Menu_CalculoMatematico_Subtrair,
                                  const_Sistema_DicionarioDados_Menu_CalculoMatematico_Multiplicar,
                                  const_Sistema_DicionarioDados_Menu_CalculoMatematico_Dividir,
                                  const_Sistema_DicionarioDados_Menu_CalculoMatematico_Porcetagem)

      If bOk Then
        Select Case Mid(sFatorExemplo, 1, 3)
          Case "#AD"
            oRet = oRet + Val(Mid(sFator, 4, 5))
          Case "#SB"
            oRet = oRet - Val(Mid(sFator, 4, 5))
          Case "#MT"
            oRet = oRet * Val(Mid(sFator, 4, 5))
          Case "#DV"
            oRet = oRet / Val(Mid(sFator, 4, 5))
          Case "#PC"
            oRet = oRet * Val(Mid(sFator, 4, 5)) / 100
        End Select

        sFatorExemplo = Replace(sFatorExemplo, "00000", Mid(sFator, 4, 5))

        oRet = FormatCurrency(oRet, 2)
      End If
    End If

    If oRet.GetType.ToString = "System.Decimal" Then
      oRet = FormatCurrency(oRet, 2)
    End If

    If Not bOk Then
      sFatorExemplo = ""
    End If

    Return oRet
  End Function
End Module