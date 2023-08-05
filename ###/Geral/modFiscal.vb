Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Reflection
Imports System.Windows
Imports System.Windows.Forms
Imports DFe.Classes.Entidades
Imports DFe.Classes.Flags
Imports DFe.Utils
Imports DFe.Utils.Assinatura
Imports NFe.Classes
Imports NFe.Classes.Informacoes
Imports NFe.Classes.Informacoes.Cobranca
Imports NFe.Classes.Informacoes.Destinatario
Imports NFe.Classes.Informacoes.Detalhe
Imports NFe.Classes.Informacoes.Detalhe.Tributacao
Imports NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual
Imports NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos
Imports NFe.Classes.Informacoes.Detalhe.Tributacao.Federal
Imports NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.Tipos
Imports NFe.Classes.Informacoes.Emitente
Imports NFe.Classes.Informacoes.Identificacao
Imports NFe.Classes.Informacoes.Identificacao.Tipos
Imports NFe.Classes.Informacoes.Observacoes
Imports NFe.Classes.Informacoes.Pagamento
Imports NFe.Classes.Informacoes.Total
Imports NFe.Classes.Informacoes.Transporte
Imports NFe.Classes.Servicos.ConsultaCadastro
Imports NFe.Classes.Servicos.Tipos
Imports NFe.Servicos
Imports NFe.Servicos.Retorno
Imports NFe.Utils
Imports NFe.Utils.Email
Imports NFe.Utils.InformacoesSuplementares
Imports NFe.Utils.NFe
Imports NFe.Utils.Tributacao.Estadual
Imports DFe.Classes.Extensoes
Imports NFe.Utils.Excecoes
Imports NFeZeus = NFe.Classes.NFe
Imports NFe.Utils.Tributacao.Federal
Imports System.Xml.Serialization
Imports DanfeSharp.Model
Imports NFe.Danfe.Nativo.NFCe
Imports NFe.Danfe.Base.NFCe
Imports NFe.Danfe.Base
Imports DanfeSharp.Modelo
Imports VersaoServico = NFe.Classes.Servicos.Tipos.VersaoServico
Imports NFe.Danfe.Fast.NFCe
Imports NFe.Classes.Servicos.Download
Imports Fiscal
Imports BLL
Imports ACBr.Net.Sat

Module modFiscal
  Public Sub FNC_Fiscal_Danfe_ImprimirNCFe(sXML As String,
                                         sCD_NFCe_DetalheVendaNormal As String,
                                         sCD_NFCe_DetalheVendaContigencia As String,
                                         sCD_NFCe_Token_ID As String,
                                         sCD_NFCe_Token_CSC As String)
    sXML = FNC_DiretorioSistema_AdicionarPath(sXML)

    Dim oConfig As ConfiguracaoDanfeNfce
    Dim NFe As NFeZeus = New NFe.Classes.NFe().CarregarDeArquivoXml(sXML)

    If NFe.infNFe.ide.mod <> ModeloDocumento.NFCe Then
      FNC_Mensagem("O XML informado não é um NFCe")
    End If

    Try
      Dim oProc As nfeProc
      Dim sArquivo As String
      Dim oImpr As DanfeNativoNfce

      oConfig = FNC_Fiscal_Configuracao_NCFe()

      Try
        oProc = New nfeProc().CarregarDeArquivoXml(sXML)
        sArquivo = oProc.ObterXmlString()
      Catch ex1 As Exception
        NFe = New NFe.Classes.NFe().CarregarDeArquivoXml(sXML)
        sArquivo = NFe.ObterXmlString()
      End Try

      oImpr = New DanfeNativoNfce(sArquivo, oConfig, sCD_NFCe_Token_ID, sCD_NFCe_Token_CSC, 0, 0, sESTACAO_TRABALHO_DS_FONTE_PADRAO_DANFENCFE)
      oImpr.Imprimir(sESTACAO_TRABALHO_DS_IMPRESSORA_PADRAO_DANFENCFE)
    Catch ex1 As Exception
      Try
        Dim oDanfe As DanfeNativoNfce
        oConfig = FNC_Fiscal_Configuracao_NCFe()
        oDanfe = New DanfeNativoNfce(sXML, oConfig, sCD_NFCe_Token_ID, sCD_NFCe_Token_CSC)

        oDanfe.Imprimir(False, sESTACAO_TRABALHO_DS_IMPRESSORA_PADRAO_DANFENCFE)
      Catch ex2 As Exception
        Try
          Dim oDanfe As DanfeFrNfce

          oConfig = FNC_Fiscal_Configuracao_NCFe()
          oDanfe = New DanfeFrNfce(NFe, oConfig, sCD_NFCe_Token_ID, sCD_NFCe_Token_CSC)

          oDanfe.Imprimir(False, sESTACAO_TRABALHO_DS_IMPRESSORA_PADRAO_DANFENCFE)
        Catch ex As Exception
          FNC_Mensagem(ex.Message)
        End Try
      End Try
    End Try
  End Sub

  Public Function FNC_Fiscal_Danfe_GerarPDF(sXML As String,
                                          Optional bAbrirArquivo As Boolean = False,
                                          Optional bImprimirCancelado As Boolean = False) As String
    Dim sXML_Local As String = FNC_Arquivo_Local_Temporario("Danfe.xml")

    System.IO.File.Copy(sXML, sXML_Local, True)

    Dim oModelo As DanfeViewModel = DanfeViewModel.CreateFromXmlFile(sXML_Local)
    Dim oDanfe As DanfeSharp.Danfe
    Dim sDanfe As String

    sDanfe = FNC_Arquivo_Local_Temporario("Danfe.pdf")

    oDanfe = New DanfeSharp.Danfe(oModelo)
    If FNC_NVL(sEMPRESA_DS_PATH_IMAGEM, "") <> "" Then
      Dim stream As New System.IO.FileStream(sEMPRESA_DS_PATH_IMAGEM, System.IO.FileMode.Open)
      'oDanfe.AdicionarLogoImagem(sEMPRESA_DS_PATH_IMAGEM)
      oDanfe.AdicionarLogoImagem(stream)
    End If
    oDanfe.Rodape = "Gerado pelo DixMed"
    oDanfe.ImprimirCancelado = bImprimirCancelado
    oDanfe.Gerar()
    oDanfe.Salvar(sDanfe)

    If bAbrirArquivo Then
      FNC_PDF_Visualizar(sDanfe)
    End If

    Return sDanfe
  End Function

  Private Sub FNC_Fiscal_Historico(iErro As Integer,
                                 iSQ_DOCUMENTOFISCAL As Integer,
                                 sDS_HISTORICO As String,
                                 Optional sCD_HISTORICO As String = "",
                                 Optional bExibirMensagem As Boolean = False)
    FNC_Historico_Incluir(enOpcoes.Processo_Historico_Cadastro_CadastroDocumentoFiscal.GetHashCode(),
                      enOpcoes.Processo_Acao_Transmissao.GetHashCode(),
                      iErro,
                      iSQ_DOCUMENTOFISCAL,
                      sDS_HISTORICO,
                      sCD_HISTORICO)

    If bExibirMensagem Then
      FNC_Mensagem(sDS_HISTORICO)
    End If
  End Sub

  Public Function FNC_Fiscal_DFe_StatusServico() As Boolean
    Dim bOk As Boolean = False

    Try
      Dim oConfig As ConfiguracaoServico

      oConfig = FNC_Fiscal_Configuracao()
      If oConfig Is Nothing Then GoTo Sair

      Dim oServico As New NFe.Servicos.ServicosNFe(oConfig)

      If FNC_Fiscal_NFe_StatusProcessamento(oServico.NfeStatusServico().Retorno.cStat) = enOpcoes_NFe_StatusProcessamento.ServicoSVCOperacao Then
        FNC_Mensagem("Serviço disponível")
      Else
        FNC_Mensagem("Serviço indisponível")
        GoTo Sair
      End If
    Catch ex As Exception
      FNC_Mensagem("FNC_Fiscal_DFe_StatusServico - " + ex.Message)
      GoTo Sair
    End Try

    bOk = True

Sair:
    Return bOk
  End Function

  Public Function FNC_Fiscal_DFe_InutilizarNumeracao(sCNPJ As String,
                                                   iAno As Integer,
                                                   sModelo As String,
                                                   sSerie As String,
                                                   iNumeracaoInicial As Integer,
                                                   iNumeracaoFinal As Integer,
                                                   sJustificativa As String) As Boolean

    Dim bOk As Boolean = False

    Try
      Dim oConfig As ConfiguracaoServico

      oConfig = FNC_Fiscal_Configuracao()
      If oConfig Is Nothing Then GoTo Sair

      Dim oServico As New NFe.Servicos.ServicosNFe(oConfig)
      Dim oRetornoNfeInutilizacao As RetornoNfeInutilizacao

      oRetornoNfeInutilizacao = oServico.NfeInutilizacao(FNC_SoNumero(sCNPJ), iAno, Val(sModelo), sSerie, iNumeracaoInicial, iNumeracaoFinal, sJustificativa)

      If FNC_Fiscal_NFe_StatusProcessamento(oRetornoNfeInutilizacao.Retorno.infInut.cStat) = enOpcoes_NFe_StatusProcessamento.InutilizacaoNumeroHomologado Then
        bOk = True
      Else
        FNC_Mensagem(oRetornoNfeInutilizacao.Retorno.infInut.xMotivo)
      End If
    Catch ex As Exception
      FNC_Mensagem("FNC_Fiscal_DFe_InutilizarNumeracao - " + ex.Message)
      GoTo Sair
    End Try

Sair:
    Return bOk
  End Function

  Private Function FNC_Fiscal_NFe_StatusProcessamento(scStat As String) As enOpcoes_NFe_StatusProcessamento
    Dim eRet As enOpcoes_NFe_StatusProcessamento

    If scStat = "100" Then
      eRet = enOpcoes_NFe_StatusProcessamento.AutorizadoUsoNFe
    ElseIf scStat = "101" Then
      eRet = enOpcoes_NFe_StatusProcessamento.CancelamentoNFeHomologado
    ElseIf scStat = "102" Then
      eRet = enOpcoes_NFe_StatusProcessamento.InutilizacaoNumeroHomologado
    ElseIf scStat = "103" Then
      eRet = enOpcoes_NFe_StatusProcessamento.LoteRecebidoComSucesso
    ElseIf scStat = "104" Then
      eRet = enOpcoes_NFe_StatusProcessamento.LotePocessado
    ElseIf scStat = "105" Then
      eRet = enOpcoes_NFe_StatusProcessamento.LoteProcessamento
    ElseIf scStat = "106" Then
      eRet = enOpcoes_NFe_StatusProcessamento.LoteNaoLocalizado
    ElseIf scStat = "107" Then
      eRet = enOpcoes_NFe_StatusProcessamento.ServicoSVCOperacao
    ElseIf scStat = "108" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ServicoParalisadoMomentaneamente_CurtoPrazo
    ElseIf scStat = "109" Then
      eRet = enOpcoes_NFe_StatusProcessamento.ServicoParalisadoPrevisao
    ElseIf scStat = "110" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UsoDenegado
    ElseIf scStat = "111" Then
      eRet = enOpcoes_NFe_StatusProcessamento.ConsultaCadastroComUmaOcorrencia
    ElseIf scStat = "112" Then
      eRet = enOpcoes_NFe_StatusProcessamento.ConsultaCadastroComMaisUmaOcorrencia
    ElseIf scStat = "128" Then
      eRet = enOpcoes_NFe_StatusProcessamento.LoteEventoProcessado
    ElseIf scStat = "135" Then
      eRet = enOpcoes_NFe_StatusProcessamento.EventoRegistradoVinculadoNFe
    ElseIf scStat = "201" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ONumeroMaximoNumeracaoNFeAInutilizarUtrapassouLimite
    ElseIf scStat = "202" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_FalhaReconhecimentoAutoriaIntegridadeArquivoDigital
    ElseIf scStat = "203" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_EmissorNaoHabilitadoParaEmissaoNFe
    ElseIf scStat = "204" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DuplicidadeNFe_999999999999999999999999999999999
    ElseIf scStat = "205" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFeEstaDenegadaBaseDadosSEFAZ
    ElseIf scStat = "206" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFeJaEstaInutilizadaBaseDadosSEFAZ
    ElseIf scStat = "207" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJEmitenteInvalido
    ElseIf scStat = "208" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJDestinatarioInvalido
    ElseIf scStat = "209" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IE_EmitenteInvalida
    ElseIf scStat = "210" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IE_DestinatarioInvalida
    ElseIf scStat = "211" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IE_SubstitutoInvalida
    ElseIf scStat = "212" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DataEmissaoNFePosteriorDataRecebimento
    ElseIf scStat = "213" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJ_BaseEmitenteDifereCNPJ_BaseCertificadoDigital
    ElseIf scStat = "214" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TamanhoMensagemExcedeuLimiteEstabelecido
    ElseIf scStat = "215" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_FalhaSchemaXML
    ElseIf scStat = "216" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ChaveAcessoDifereCadastrada
    ElseIf scStat = "217" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFeNaoConstaBaseDadosSEFAZ
    ElseIf scStat = "218" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFeJaEstaCanceladaBaseDadosSEFAZ
    ElseIf scStat = "219" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CirculacaoNFeVerificada
    ElseIf scStat = "220" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFeAutorizadaHaMais7Dias_168Horas
    ElseIf scStat = "221" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ConfirmadoRecebimentoNFePeloDestinatario
    ElseIf scStat = "222" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ProtocoloAutorizacaoUsoDifereCadastrado
    ElseIf scStat = "223" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJTransmissorLoteDifereCNPJTransmissorConsulta
    ElseIf scStat = "224" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_AFaixaInicialMaiorAFaixaFinal
    ElseIf scStat = "225" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_FalhaSchemaXMLNFe
    ElseIf scStat = "226" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoUFEmitenteDivergeUFAutorizadora
    ElseIf scStat = "227" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ErroChaveAcesso_CampoIDFaltaLiteralNFe
    ElseIf scStat = "228" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DataEmissaoMuitoAtrasada
    ElseIf scStat = "229" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IEEmitenteNaoinformada
    ElseIf scStat = "230" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IEEmitenteNaocadastrada
    ElseIf scStat = "231" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IEEmitenteNaovinculadaCNPJ
    ElseIf scStat = "232" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IEDestinatarioNaoinformada
    ElseIf scStat = "233" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IEDestinatarioNaocadastrada
    ElseIf scStat = "234" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IEDestinatarioNaovinculadaCNPJ
    ElseIf scStat = "235" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_InscricaoSUFRAMAInvalida
    ElseIf scStat = "236" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ChaveAcessoDigitoVerificadorInvalido
    ElseIf scStat = "237" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CPFDestinatarioInvalido
    ElseIf scStat = "238" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_Cabecalho_VersaoArquivoXMLSuperiorVersaoVigente
    ElseIf scStat = "239" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_Cabecalho_VersaoArquivoXMLNaoSuportada
    ElseIf scStat = "240" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CancelamentoInutilizacaoIrregularidadeFiscalEmitente
    ElseIf scStat = "241" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UmNumeroDaFaixaJaFoiUtilizado
    ElseIf scStat = "242" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_Cabecalho_FalhaSchemaXML
    ElseIf scStat = "243" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_XMLMalFormado
    ElseIf scStat = "244" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJCertificadoDigitalDifereCNPJMatrizDoCNPJEmitente
    ElseIf scStat = "245" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJEmitenteNaocadastrado
    ElseIf scStat = "246" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJDestinatarioNaocadastrado
    ElseIf scStat = "247" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_SiglaUFEmitenteDivergeUFAutorizadora
    ElseIf scStat = "248" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UFReciboDivergeUFAutorizadora
    ElseIf scStat = "249" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UFChaveAcessoDivergeUFAutorizadora
    ElseIf scStat = "250" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UFDivergeUFAutorizadora
    ElseIf scStat = "251" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UFMunicipioDestinatarioNaoPertenceSUFRAMA
    ElseIf scStat = "252" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_AmbienteInformadoDivergeAmbienteRecebimento
    ElseIf scStat = "253" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DigitoVerificadorChaveAcessoCompostaInvalida
    ElseIf scStat = "254" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFeComplementarNaoPossuiNFReferenciada
    ElseIf scStat = "255" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFeComplementarPossuiMaisUmaNFReferenciada
    ElseIf scStat = "256" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UmaNFeDaFaixaJaEstaInutilizadaBaseDadosSEFAZ
    ElseIf scStat = "257" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_SolicitanteNaohabilitadoParaEmissaoNFe
    ElseIf scStat = "258" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJConsultaInvalido
    ElseIf scStat = "259" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJConsultaNaoCadastradoComoContribuinteUF
    ElseIf scStat = "260" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IEConsultaInvalida
    ElseIf scStat = "261" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IEConsultaNaocadastradaComoContribuinteUF
    ElseIf scStat = "262" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UFNaoForneceConsultaPorCPF
    ElseIf scStat = "263" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CPFConsultaInvalido
    ElseIf scStat = "264" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CPFConsultaNaoCadastradoComoContribuinteUF
    ElseIf scStat = "265" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_SiglaUFConsultaDifereUFWebService
    ElseIf scStat = "266" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_SerieUtilizadaNaoPermitidaWebService
    ElseIf scStat = "267" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFComplementarReferenciaNFeInexistente
    ElseIf scStat = "268" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFComplementarReferenciaOutraNFeComplementar
    ElseIf scStat = "269" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJEmitenteNFComplementarDifereCNPJNFReferenciada
    ElseIf scStat = "270" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioFatoGeradorDigitoInvalido
    ElseIf scStat = "271" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioFatoGeradorDifereUFEmitente
    ElseIf scStat = "272" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioEmitenteDigitoInvalido
    ElseIf scStat = "273" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioEmitenteDifereUFEmitente
    ElseIf scStat = "274" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioDestinatarioDigitoInvalido
    ElseIf scStat = "275" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioDestinatarioDifereUFDestinatario
    ElseIf scStat = "276" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioLocalRetirada_DigitoInvalido
    ElseIf scStat = "277" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioLocalRetirada_DfereUFLocalRetirada
    ElseIf scStat = "278" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioLocalEntrega_DigitoInvalido
    ElseIf scStat = "279" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioLocalEntrega_DifereUFLocalEntrega
    ElseIf scStat = "280" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoTransmissorInvalido
    ElseIf scStat = "281" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoTransmissorDataValidade
    ElseIf scStat = "282" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoTransmissorSemCNPJ
    ElseIf scStat = "283" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoTransmissorErroCadeiaCertificacao
    ElseIf scStat = "284" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoTransmissorRevogado
    ElseIf scStat = "285" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoTransmissorDifereICPBrasil
    ElseIf scStat = "286" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoTransmissorErroAcessoLCR
    ElseIf scStat = "287" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioFG_ISSQNDigitoInvalido
    ElseIf scStat = "288" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioFG_TransporteiígitoInvalido
    ElseIf scStat = "289" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoInformadaDivergeUFSolicitada
    ElseIf scStat = "290" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoAssinaturaInvalido
    ElseIf scStat = "291" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoAssinaturaDataValidade
    ElseIf scStat = "292" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoAssinaturaSemCNPJ
    ElseIf scStat = "293" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoAssinaturaErroCadeiaCertificacao
    ElseIf scStat = "294" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoAssinaturaRevogado
    ElseIf scStat = "295" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoAssinaturaDifereICPBrasil
    ElseIf scStat = "296" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CertificadoAssinaturaErroAcessoLCR
    ElseIf scStat = "297" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_AssinaturaDifereCalculado
    ElseIf scStat = "298" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_AssinaturaDiferePadraoProjeto
    ElseIf scStat = "299" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_XMLAreaCabecalhoComCodificacaoDiferenteUTF8
    ElseIf scStat = "301" Then
      eRet = enOpcoes_NFe_StatusProcessamento.UsoDenegadoIrregularidadeFiscalEmitente
    ElseIf scStat = "302" Then
      eRet = enOpcoes_NFe_StatusProcessamento.UsoDenegadoIrregularidadeFiscalDestinatario
    ElseIf scStat = "401" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CPFRemetenteInvalido
    ElseIf scStat = "402" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_XMLAreaDadosComCodificacaoDiferenteUTF8
    ElseIf scStat = "403" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_OGrupoInformacoesNFeAvulsaDeUsoExclusivoFisco
    ElseIf scStat = "404" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UsoPrefixoNamespaceNaoPermitido
    ElseIf scStat = "405" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoPaisEmitente_DigitoInvalido
    ElseIf scStat = "406" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoPaisDestinatario_DigitoInvalido
    ElseIf scStat = "407" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_OCPFSoPodeSerInformadoCampoEmitenteParaNFeAvulsa
    ElseIf scStat = "409" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_Campo_cUF_InexistenteElemento_nfeCabecMsgSOAPHeader
    ElseIf scStat = "410" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UFInformadaCampo_cUFNao_AtendidaWebService
    ElseIf scStat = "411" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CampoVersaoDadosInexistenteElemento_nfeCabecMsgSOAPHeader
    ElseIf scStat = "453" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_AnoInutilizacaoNaoPodeSersuperiorAnoAtual
    ElseIf scStat = "454" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_AnoInutilizacaoNaoPodeSerinferior2006
    ElseIf scStat = "478" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_LocalEntregaNaoinformadoFaturamentoDiretoVeiculosNovos
    ElseIf scStat = "502" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ErroChaveAcesso_CampoIDNaoCorrespondeAConcatenacao
    ElseIf scStat = "503" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_SerieUtilizadaForaDaFaixaPermitidaSCAN_900_999
    ElseIf scStat = "504" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DataEntradaSaidaPosteriorPermitido
    ElseIf scStat = "505" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DataEntradaSaidaAnteriorPermitido
    ElseIf scStat = "506" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DataSaidaMenorQueDataEmissao
    ElseIf scStat = "507" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_OCNPJDestinatarioRemetenteNaoDeveSerInformadoOperacao
    ElseIf scStat = "508" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_OCPFDestinatarioRemetenteNaoDeveSerInformadoOperacao
    ElseIf scStat = "509" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_OCNPJConteudoNuloSoValidoOperacaoExterior
    ElseIf scStat = "510" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_OperacaoExteriorCodigoPaisDestinatario1058_Brasil_ouNao
    ElseIf scStat = "511" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NaoOperaçaoExteriorCodigoPaisDestinatarioDifere1058Brasil
    ElseIf scStat = "512" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJLocalRetiradaInvalido
    ElseIf scStat = "513" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioLocalRetiradaDeveSer_9999999_UFRetirada_EX
    ElseIf scStat = "514" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJLocalEntregaInvalido
    ElseIf scStat = "515" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoMunicipioLocalEntregaDeveSer_9999999_UFEntrega_EX
    ElseIf scStat = "516" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ObrigatoriaInformacaoNCM_Genero
    ElseIf scStat = "517" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_InformacaoNCMDifereInformacaoGenero
    ElseIf scStat = "518" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPEntradaNFeSaida
    ElseIf scStat = "519" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPSaidaNFeEntrada
    ElseIf scStat = "520" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPOperacaoExteriorUFDestinatarioDifereEX
    ElseIf scStat = "521" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPNaoEDeOperacaoComExteriorUFDestinatarioEX
    ElseIf scStat = "522" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPOperacaoEstadualUFEmitenteDifereUFDestinatario
    ElseIf scStat = "523" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPNaoEOperacaoEstadualUFEmitenteIgualUFDestinatario
    ElseIf scStat = "524" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPOperacaoComExteriorENaoInformadoNCM
    ElseIf scStat = "525" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPImportacaoENaoInformadDadosDI
    ElseIf scStat = "526" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CFOPExportacaoENaoInformadoLocalEmbarque
    ElseIf scStat = "527" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_OperacaoExportacaoComInformacaoICMSIncompativel
    ElseIf scStat = "528" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ValorICMSDifereProdutoBCAliquota
    ElseIf scStat = "529" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NCMInformacaoObrigatoriaParaProdutoTributadopeloIPI
    ElseIf scStat = "530" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_OperacaoComTibutacaoISSQNinformarInscricaoMunicipal
    ElseIf scStat = "531" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TotalBCICMSDifereSomatorioDosItens
    ElseIf scStat = "532" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TotalICMSDifereSomatorioDosItens
    ElseIf scStat = "533" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TotalBCICMS_STDifereSomatorioItens
    ElseIf scStat = "534" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TotalICMS_STDifereSomatorioItens
    ElseIf scStat = "535" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TotalFreteDifereSomatorioItens
    ElseIf scStat = "536" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TotalSeguroDifereSomatorioItens
    ElseIf scStat = "537" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TotalDescontoDifereSomatorioItens
    ElseIf scStat = "538" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TotalIPIDifereSomatorioItens
    ElseIf scStat = "539" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DuplicidadeNFecomDiferencaChaveAcesso
    ElseIf scStat = "540" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CPFLocalRetiradaInvalido
    ElseIf scStat = "541" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CPFLocalEntregaInvalido
    ElseIf scStat = "542" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJTransportadorInvalido
    ElseIf scStat = "543" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CPFTransportadorInvalido
    ElseIf scStat = "544" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IETransportadorInvalido
    ElseIf scStat = "545" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_NotaFiscalEmitidaContingencia
    ElseIf scStat = "546" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ErroChaveAcesso_CampoID_FaltaLiteralNFe
    ElseIf scStat = "547" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DígitoVerificadorChaveAcessoNFeReferenciadaInvalido
    ElseIf scStat = "548" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJ_NFReferenciadaInvalido
    ElseIf scStat = "549" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJ_NFReferenciadaProdutorInvalido
    ElseIf scStat = "550" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CPF_NFReferenciadaProdutorInvalido
    ElseIf scStat = "551" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_IE_NFReferenciadaProdutorInvalido
    ElseIf scStat = "552" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DigitoVerificadorChaveAcessoCTeReferenciadoInvalido
    ElseIf scStat = "553" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TipoAutorizadorReciboDivergeOrgaoAutorizador
    ElseIf scStat = "554" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_SerieDifereDaFaixa_0_899
    ElseIf scStat = "555" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_TipoAutorizadorProtocoloDivergeOrgaoAutorizador
    ElseIf scStat = "556" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_JustificativaEntradaContingenciaNaoDeveSerInformadaParaTipo
    ElseIf scStat = "557" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_AJustificativaEntradaContingenciaDeveSerInformada
    ElseIf scStat = "558" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_DataEntradaContingenciaPosteriorDataEmissao
    ElseIf scStat = "559" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_UFTransportadorNaoInformado
    ElseIf scStat = "560" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CNPJBaseEmitenteDifereCNPJBasePrimeiraNFeLoteRecebido
    ElseIf scStat = "561" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_MesEmissaoInformadoChaveAcessoDifereMesEmissaoNFe
    ElseIf scStat = "562" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_CodigoNumericoInformadoChaveAcessoDifereCodigoNumericoDa
    ElseIf scStat = "999" Then
      eRet = enOpcoes_NFe_StatusProcessamento.Rejeicao_ErroNaoCatalogadoInformarMensagemErroCapturadoTratamentoDa
    End If

    Return eRet
  End Function

  Private Function FNC_Fiscal_Configuracao_NCFe() As ConfiguracaoDanfeNfce
    Dim oConfig As ConfiguracaoDanfeNfce
    Dim oDetalheVendaNormal As NfceDetalheVendaNormal = NfceDetalheVendaNormal.UmaLinha
    Dim oDetalheVendaContigencia As NfceDetalheVendaContigencia = NfceDetalheVendaContigencia.UmaLinha

    If sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_NORMAL.Trim() <> "" Then
      oDetalheVendaNormal = Val(sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_NORMAL)
    End If
    If sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA.Trim() <> "" Then
      oDetalheVendaContigencia = Val(sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA)
    End If

    oConfig = New ConfiguracaoDanfeNfce(oDetalheVendaNormal, oDetalheVendaContigencia)

    If sEMPRESA_DS_PATH_IMAGEM.Trim() <> "" Then
      Dim oImagem As Image = Image.FromFile(sEMPRESA_DS_PATH_IMAGEM)
      Dim oStream As MemoryStream

      oConfig.Logomarca = New Byte() {}

      oStream = New MemoryStream()
      oImagem.Save(oStream, ImageFormat.Png)
      oStream.Close()
      oConfig.Logomarca = oStream.ToArray()
    End If

    Return oConfig
  End Function

  Private Function FNC_Fiscal_Configuracao(Optional eModeloDocumento As ModeloDocumento = ModeloDocumento.NFe) As NFe.Utils.ConfiguracaoServico
    Dim oConfig As New NFe.Utils.ConfiguracaoServico()
    Dim oCert As System.Security.Cryptography.X509Certificates.X509Certificate2
    Dim oEstado As Estado

    oEstado = oEstado.SiglaParaEstado(sCD_EMPRESA_UF)

    oConfig = ConfiguracaoServico.Instancia

    With oConfig
      Select Case iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE
        Case enOpcoes.AmbienteProcessamento_Producao.GetHashCode()
          .tpAmb = TipoAmbiente.Producao
        Case enOpcoes.AmbienteProcessamento_Homologacao.GetHashCode()
          .tpAmb = TipoAmbiente.Homologacao
        Case Else
          FNC_Mensagem("Tipo de ambiente de transmissão não definido")
          Exit Function
      End Select

      .tpEmis = TipoEmissao.teNormal
      .ProtocoloDeSeguranca = ServicePointManager.SecurityProtocol

      .Certificado = New ConfiguracaoCertificado

      Select Case iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_TIPO
        Case enOpcoes.TipoCertificadoDigital_A1Arquivo.GetHashCode()
          .Certificado.TipoCertificado = TipoCertificado.A1Arquivo
          .Certificado.Arquivo = sESTACAO_TRABALHO_DS_CERTIFICADO_DIGITAL_PATH_ARQUIVO
          .Certificado.Senha = sESTACAO_TRABALHO_DS_CERTIFICADO_DIGITAL_SENHA
        Case enOpcoes.TipoCertificadoDigital_A1ByteArray.GetHashCode()
          oCert = CertificadoDigitalUtils.ListareObterDoRepositorio()
          .Certificado.TipoCertificado = TipoCertificado.A1ByteArray
          .Certificado.ArrayBytesArquivo = oCert.GetRawCertData()
          .Certificado.Serial = oCert.GetSerialNumberString()
        Case enOpcoes.TipoCertificadoDigital_A1Repositorio.GetHashCode()
          oCert = CertificadoDigitalUtils.ListareObterDoRepositorio()
          .Certificado.TipoCertificado = TipoCertificado.A1Repositorio
          .Certificado.Serial = oCert.SerialNumber
        Case enOpcoes.TipoCertificadoDigital_A3.GetHashCode()
          .Certificado.TipoCertificado = TipoCertificado.A3
      End Select

      .Certificado.CacheId = "58A13AD9C6A41D4B"
      .Certificado.ManterDadosEmCache = True
      .Certificado.SignatureMethodSignedXml = "http://www.w3.org/2000/09/xmldsig#rsa-sha1"
      .Certificado.DigestMethodReference = "http://www.w3.org/2000/09/xmldsig#sha1"
      .TimeOut = 30000
      .cUF = oEstado
      .tpEmis = TipoEmissao.teNormal
      .ModeloDocumento = eModeloDocumento
      .VersaoLayout = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoRecepcaoEventoCceCancelamento = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoRecepcaoEventoEpec = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoRecepcaoEventoManifestacaoDestinatario = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNfeRecepcao = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNfeRetRecepcao = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNfeConsultaCadastro = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNfeInutilizacao = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNfeConsultaProtocolo = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNfeStatusServico = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNFeAutorizacao = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNFeRetAutorizacao = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNFeDistribuicaoDFe = DFe.Classes.Flags.VersaoServico.Versao100
      .VersaoNfeConsultaDest = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNfeDownloadNF = DFe.Classes.Flags.VersaoServico.Versao400
      .VersaoNfceAministracaoCSC = DFe.Classes.Flags.VersaoServico.Versao400
      .ProtocoloDeSeguranca = SecurityProtocolType.Tls12
      .DiretorioSchemas = sESTACAO_TRABALHO_DS_DOCUMENTOFISCAL_PATH_SCHEMAS
      .SalvarXmlServicos = True
      .DiretorioSalvarXml = FNC_Diretorio_Temporario()
    End With

    Return oConfig
  End Function

  Private Function FNC_Fiscal_DocumentoFiscal_AssociarProtocolo(oConfig As NFe.Utils.ConfiguracaoServico,
                                                              oNFe As NFe.Classes.NFe,
                                                              sNFe_Chave As String) As NFe.Classes.nfeProc
    Dim oNFe_Servico As NFe.Servicos.ServicosNFe
    Dim oNFe_Servico_Retorno As NFe.Servicos.Retorno.RetornoNfeConsultaProtocolo
    Dim oNFe_Proc As NFe.Classes.nfeProc

    oNFe_Servico = New ServicosNFe(oConfig)
    oNFe_Servico_Retorno = oNFe_Servico.NfeConsultaProtocolo(sNFe_Chave)

    oNFe_Proc = New nfeProc()
    oNFe_Proc.NFe = oNFe
    oNFe_Proc.protNFe = oNFe_Servico_Retorno.Retorno.protNFe
    oNFe_Proc.versao = oNFe_Servico_Retorno.Retorno.versao

    Return oNFe_Proc
  End Function

  Private Function FNC_Fiscal_DocumentoFiscal_Protocolo(oNFe As NFe.Classes.NFe,
                                                      iSQ_DOCUMENTOFISCAL As Integer,
                                                      oConfig As NFe.Utils.ConfiguracaoServico,
                                                      ByRef sCD_PROTOCOLO As String,
                                                      ByRef Optional sNFe_Arquivo As String = "") As Boolean
    Dim oNFe_Servico As NFe.Servicos.ServicosNFe
    Dim oNFe_Servico_Retorno As NFe.Servicos.Retorno.RetornoNfeConsultaProtocolo
    Dim oNFe_Proc As NFe.Classes.nfeProc

    Dim sNFe_Chave As String
    Dim bOk As Boolean = False

    Dim iCont As Integer

    sNFe_Chave = oNFe.infNFe.Id.Substring(3)

    FNC_Fiscal_Historico(0, iSQ_DOCUMENTOFISCAL, "Solicitação de protocolo")

    If String.IsNullOrEmpty(sNFe_Chave) Then
      FNC_Fiscal_Historico(0, iSQ_DOCUMENTOFISCAL, "Solicitação de protocolo - A Chave da NFe não foi encontrada no arquivo",, False)
      GoTo Sair
    End If
    If sNFe_Chave.Trim().Length <> 44 Then
      FNC_Fiscal_Historico(0, iSQ_DOCUMENTOFISCAL, "Solicitação de protocolo - Chave deve conter 44 caracteres",, False)
      GoTo Sair
    End If

    For iCont = 1 To 5
      Application.DoEvents()

      oNFe_Servico = New ServicosNFe(oConfig)
      oNFe_Servico_Retorno = oNFe_Servico.NfeConsultaProtocolo(sNFe_Chave)
      FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_Retorno.Retorno.cStat), iSQ_DOCUMENTOFISCAL, "Solicitação de protocolo - Retorno - " &
                                                                                                                  "Chave de Acesso: " & oNFe_Servico_Retorno.Retorno.chNFe)

      oNFe_Proc = New nfeProc()
      oNFe_Proc.NFe = oNFe
      oNFe_Proc.protNFe = New NFe.Classes.Protocolo.protNFe()
      oNFe_Proc.protNFe = oNFe_Servico_Retorno.Retorno.protNFe
      oNFe_Proc.versao = oNFe_Servico_Retorno.Retorno.versao

      If FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_Retorno.Retorno.cStat) = enOpcoes_NFe_StatusProcessamento.Rejeicao_NFeNaoConstaBaseDadosSEFAZ.GetHashCode() Then
        If iCont = 5 Then
          FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_Retorno.Retorno.cStat), iSQ_DOCUMENTOFISCAL, "NFe Não Consta na Base Dados do SEFAZ")
        End If
      Else
        FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_Retorno.Retorno.cStat), iSQ_DOCUMENTOFISCAL, "Solicitação de protocolo - Retorno - " &
                                                                                                                  "Chave de Acesso: " & oNFe_Proc.protNFe.infProt.chNFe &
                                                                                                                  "Protocolo nº: " & oNFe_Proc.protNFe.infProt.nProt &
                                                                                                                  "Motivo: " & oNFe_Proc.protNFe.infProt.xMotivo)
        If Not oNFe_Proc.protNFe Is Nothing Then
          sCD_PROTOCOLO = oNFe_Proc.protNFe.infProt.nProt
          sNFe_Arquivo = FNC_Diretorio_Tratar(oConfig.DiretorioSalvarXml) & sNFe_Chave & "-procNfe.xml"

          FuncoesXml.ClasseParaArquivoXml(oNFe_Proc, sNFe_Arquivo)
        End If

        bOk = True

        Exit For
      End If
    Next

Sair:
    Return bOk
  End Function

  Private Sub FNC_Fiscal_DocumentoFiscal_Serie_Emissao_NumeroAtual(iSQ_DOCUMENTOFISCAL_SERIE As Integer,
                                                                sCD_DOCUMENTOFISCAL As String)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_SERIE_EMISSAO_NUMEROATUAL_UPD", False, "@SQ_DOCUMENTOFISCAL_SERIE",
                                                                                  "@CD_ULTIMAEMISSAO_NUMERO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFISCAL_SERIE", iSQ_DOCUMENTOFISCAL_SERIE),
                     DBParametro_Montar("CD_ULTIMAEMISSAO_NUMERO", sCD_DOCUMENTOFISCAL))
  End Sub

  Private Sub FNC_Fiscal_DocumentoFiscal_Status(iSQ_DOCUMENTOFISCAL As Integer,
                                              sCD_DOCUMENTOFISCAL As String,
                                              eID_OPT_STATUS As enOpcoes,
                                              eID_OPT_CERTIFICADO_DIGITAL_AMBIENTE As enOpcoes,
                                              Optional sCD_CHAVE_NFE As String = "",
                                              Optional sCD_PROTOCOLO As String = "",
                                              Optional sDS_PATH_XML As String = "")
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_SERIE_STATUS_UPD", False, "@SQ_DOCUMENTOFISCAL",
                                                                     "@CD_DOCUMENTOFISCAL",
                                                                     "@ID_OPT_STATUS",
                                                                     "@ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE",
                                                                     "@CD_CHAVE_NFE",
                                                                     "@CD_PROTOCOLO",
                                                                     "@DS_PATH_XML")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFISCAL", iSQ_DOCUMENTOFISCAL),
                     DBParametro_Montar("CD_DOCUMENTOFISCAL", sCD_DOCUMENTOFISCAL),
                     DBParametro_Montar("ID_OPT_STATUS", eID_OPT_STATUS.GetHashCode()),
                     DBParametro_Montar("ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE", eID_OPT_CERTIFICADO_DIGITAL_AMBIENTE.GetHashCode()),
                     DBParametro_Montar("CD_CHAVE_NFE", FNC_NuloString(sCD_CHAVE_NFE, False)),
                     DBParametro_Montar("CD_PROTOCOLO", FNC_NuloString(sCD_PROTOCOLO, False)),
                     DBParametro_Montar("DS_PATH_XML", FNC_NuloString(sDS_PATH_XML, False)))
  End Sub

  Private Sub FNC_Fiscal_DocumentoFiscal_ChaveNFE(iSQ_DOCUMENTOFISCAL As Integer,
                                                sCD_CHAVE_NFE As String)
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_DOCUMENTOFISCAL_CHAVE_NFE_UPD", False, "@SQ_DOCUMENTOFISCAL",
                                                                  "@CD_CHAVE_NFE")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_DOCUMENTOFISCAL", iSQ_DOCUMENTOFISCAL),
                     DBParametro_Montar("CD_CHAVE_NFE", FNC_NuloString(sCD_CHAVE_NFE, False)))
  End Sub

  Public Function FNC_Fiscal_DocumentoFiscal_Transmitir_Validar(iSQ_DOCUMENTOFISCAL As Integer) As Boolean
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer
    Dim sAux As String = ""
    Dim bOk As Boolean = False

    If iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_TIPO = 0 Or
   (iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_TIPO = enOpcoes.TipoCertificadoDigital_A1Arquivo.GetHashCode() And
    (FNC_NuloString(sESTACAO_TRABALHO_DS_CERTIFICADO_DIGITAL_PATH_ARQUIVO).Trim() = "" Or
     FNC_NuloString(sESTACAO_TRABALHO_DS_CERTIFICADO_DIGITAL_SENHA).Trim() = "")) Then
      FNC_Mensagem("Dados do certificado digital não informado")
      GoTo Sair
    End If
    If sESTACAO_TRABALHO_DS_DOCUMENTOFISCAL_PATH_SCHEMAS.Trim() = "" Then
      FNC_Mensagem("Pasta de Schema no NF-e/NFC-e não informada")
      GoTo Sair
    End If

    sSqlText = "SELECT *" &
           " FROM VW_DOCUMENTOFISCAL_GERAR" &
           " WHERE SQ_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL
    oData = DBQuery(sSqlText)

    If objDataTable_Vazio(oData) Then
      FNC_Mensagem("Documento Fiscal não encontrado")
      GoTo Sair
    Else
      With oData.Rows(0)
        If .Item("ID_OPT_STATUS") = enOpcoes.StatusDocumentoFiscal_Transmitido.GetHashCode() Then
          FNC_Mensagem("Documento Fiscal já transmitido")
          GoTo Sair
        End If
        If .Item("ID_OPT_STATUS") = enOpcoes.StatusDocumentoFiscal_Cancelado.GetHashCode() Then
          FNC_Mensagem("Documento Fiscal cancelado")
          GoTo Sair
        End If
        If Not FNC_In(.Item("ID_DOCUMENTOFISCAL_TIPO"), enTipoDocumentoFiscal.Entrada_NotaFiscalEntrada.GetHashCode(),
                                                enTipoDocumentoFiscal.Saida_NotaFiscalSaida.GetHashCode(),
                                                enTipoDocumentoFiscal.Saida_CupomFiscalEletronico.GetHashCode()) Then
          FNC_Mensagem("Somente Nota Fiscal de Entrada e Nota Fiscal Saída e Cupom Fiscal pode ser transmitido(a)")
          GoTo Sair
        End If
        If FNC_NVL(.Item("CD_SERVICO_MODELO"), "") = "" Then
          FNC_Mensagem("Modelo de serviço do documento fiscal não informado")
          GoTo Sair
        End If
        Select Case FNC_NVL(.Item("CD_SERVICO_MODELO"), "")
          Case const_NFe_ModeloServico_NFe
          Case const_NFe_ModeloServico_NFCe
            If FNC_NVL(sESTACAO_TRABALHO_CD_NFCe_Token_CSC, "").Trim() = "" Then
              FNC_Mensagem("Código do Token CSC não informado")
              GoTo Sair
            End If
            If FNC_NVL(sESTACAO_TRABALHO_CD_NFCe_Token_ID, "").Trim() = "" Then
              FNC_Mensagem("Código do Token ID não informado")
              GoTo Sair
            End If
            If FNC_NVL(iESTACAO_TRABALHO_ID_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA, 0) = 0 Then
              FNC_Mensagem("Tipo de Detalhe Venda Contigência não informado")
              GoTo Sair
            End If
            If FNC_NVL(iESTACAO_TRABALHO_ID_OPT_NFCe_DETALHE_VENDA_NORMAL, 0) = 0 Then
              FNC_Mensagem("Tipo de Detalhe Venda Normal não informado")
              GoTo Sair
            End If
            If FNC_NVL(iESTACAO_TRABALHO_ID_OPT_NFCe_VERSAO_QRCODE, 0) = 0 Then
              FNC_Mensagem("Versão do QR-Code não informado")
              GoTo Sair
            End If
        End Select
        'If FNC_NVL(.Item("IC_EXIBIR_PESSOA"), "N") = "S" Then
        '  If FNC_CampoNulo(.Item("CD_CPF_CNPJ")) Then
        '    FNC_Mensagem("É preciso informar o C.P.F./C.N.P.J. da pessoa da venda")
        '    GoTo Sair
        '  End If
        '  If Not FNC_ValidarCPF_CNPJ(.Item("CD_CPF_CNPJ")) Then
        '    FNC_Mensagem("É preciso informar o C.P.F./C.N.P.J. válido da pessoa da venda")
        '    GoTo Sair
        '  End If
        'End If
        If FNC_NVL(.Item("IC_EXIBIR_ENDERECO"), "N") = "S" Then
          If FNC_NVL(.Item("NO_PESSOA_BAIRRO"), "") = "" Then
            FNC_Mensagem("É preciso informar o bairro do endereço da pessoa")
            GoTo Sair
          End If
          If FNC_NVL(.Item("NO_PESSOA_CIDADE"), "") = "" Then
            FNC_Mensagem("É preciso informar a cidade do endereço da pessoa")
            GoTo Sair
          End If
          If FNC_NVL(.Item("CD_PESSOA_UF"), "") = "" Then
            FNC_Mensagem("É preciso informar a U.F. do endereço da pessoa")
            GoTo Sair
          End If
          If FNC_NVL(.Item("NO_PESSOA_PAIS"), "") = "" Then
            FNC_Mensagem("É preciso informar o país do endereço da pessoa")
            GoTo Sair
          End If
          If FNC_NVL(.Item("CD_PESSOA_CIDADE_IBGE"), "") = "" Then
            FNC_Mensagem("É preciso informar o código do IBGE da cidade do endereço da pessoa")
            GoTo Sair
          End If
          If FNC_NVL(.Item("CD_PESSOA_UF_IBGE"), "") = "" Then
            FNC_Mensagem("É preciso informar o código do IBGE da U.F. do endereço da pessoa")
            GoTo Sair
          End If
          If FNC_NVL(.Item("CD_PESSOA_CEP"), "") = "" Then
            FNC_Mensagem("É preciso informar o código do C.E.P. do endereço da pessoa")
            GoTo Sair
          Else
            If FNC_SoNumero(.Item("CD_PESSOA_CEP")).Length <> const_Formatos_CEP_Tamanho Then
              FNC_Mensagem("o código do C.E.P. do endereço da pessoa está em formato incorreto")
              GoTo Sair
            End If
          End If
        End If
      End With

      sSqlText = "SELECT * FROM VW_DOCUMENTOFISCAL_PRODUTO_GERAR" &
           " WHERE ID_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL &
           " ORDER BY NO_PRODUTO"
      oData = DBQuery(sSqlText)

      For iCont = 0 To oData.Rows.Count - 1
        With oData.Rows(iCont)
          If FNC_CampoNulo(oData.Rows(iCont).Item("CD_CST")) Then
            FNC_Str_Adicionar(sAux, oData.Rows(iCont).Item("NO_PRODUTO") & " - CST COFINS não informado para o produto", vbCrLf)
          End If
          If FNC_CampoNulo(oData.Rows(iCont).Item("CD_NCM")) Then
            FNC_Str_Adicionar(sAux, oData.Rows(iCont).Item("NO_PRODUTO") & " - NCM não informado para o produto", vbCrLf)
          End If
        End With
      Next

      If sAux.Trim() <> "" Then
        sAux = "O(s) produto(s) listado(s) abaixo estão com algum problema de cadastro ou lançamento" & vbCrLf & vbCrLf &
       sAux

        FNC_Mensagem(sAux)
      End If

      bOk = (sAux.Trim() = "")
    End If

Sair:
    Return bOk
  End Function

  Public Function FNC_Fiscal_DocumentoFiscal_CartaCorrecao(iSQ_DOCUMENTOFISCAL As Integer,
                                                         Optional sDescricaoCorrecao As String = "") As Boolean
    Dim oNFe_Servico As NFe.Servicos.ServicosNFe
    Dim oNFe_Servico_RetornoRecepcaoEvento As NFe.Servicos.Retorno.RetornoRecepcaoEvento
    Dim oConfig As NFe.Utils.ConfiguracaoServico
    Dim bOk As Boolean = False
    Dim sSqlText As String

    If iSQ_DOCUMENTOFISCAL = 0 Then
      FNC_Mensagem("Informe o documento fiscal a ser corrigir")
      GoTo Sair
    End If
    If sDescricaoCorrecao.Trim() = "" Then
      FNC_Mensagem("Informe a descrição da correção")
      GoTo Sair
    End If

    oConfig = FNC_Fiscal_Configuracao()
    If oConfig Is Nothing Then GoTo Sair

    oNFe_Servico = New ServicosNFe(oConfig)

    sSqlText = "SELECT * FROM VW_DOCUMENTOFISCAL WHERE SQ_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL

    With DBQuery(sSqlText).Rows(0)
      oNFe_Servico_RetornoRecepcaoEvento = oNFe_Servico.RecepcaoEventoCartaCorrecao(1, 1, .Item("CD_CHAVE_NFE"), sDescricaoCorrecao, FNC_SoNumero(sEMPRESA_DADOS_CNPJ))

      If FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.cStat) = enOpcoes_NFe_StatusProcessamento.LoteEventoProcessado Then
        bOk = True

        FormCadastroDocumentoFiscal_CartaCorrecao_Gravar(iSQ_DOCUMENTOFISCAL, sDescricaoCorrecao)
        FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.cStat), iSQ_DOCUMENTOFISCAL, oNFe_Servico_RetornoRecepcaoEvento.Retorno.xMotivo & vbCrLf, .Item("CD_DOCUMENTOFISCAL"))
      Else
        FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.cStat), iSQ_DOCUMENTOFISCAL, oNFe_Servico_RetornoRecepcaoEvento.Retorno.xMotivo & vbCrLf, .Item("CD_DOCUMENTOFISCAL"))
      End If
    End With

Sair:
    Return bOk
  End Function

  Public Function FNC_Fiscal_DocumentoFiscal_Cancelar(iSQ_DOCUMENTOFISCAL As Integer,
                                                    eModeloDocumento As ModeloDocumento,
                                                    Optional sJustificativa As String = "") As Boolean
    Dim oNFe_Servico As NFe.Servicos.ServicosNFe
    Dim oNFe_Servico_RetornoRecepcaoEvento As NFe.Servicos.Retorno.RetornoRecepcaoEvento
    Dim oConfig As NFe.Utils.ConfiguracaoServico
    Dim bOk As Boolean = False
    Dim sSqlText As String
    Dim oData As DataTable

    If iSQ_DOCUMENTOFISCAL = 0 Then
      FNC_Mensagem("Informe o documento fiscal a ser corrigir")
      GoTo Sair
    End If
    If sJustificativa.Trim() = "" Then
      FNC_Mensagem("Informe a descrição da correção")
      GoTo Sair
    End If

    oConfig = FNC_Fiscal_Configuracao(eModeloDocumento)
    If oConfig Is Nothing Then GoTo Sair

    oNFe_Servico = New ServicosNFe(oConfig)

    sSqlText = "SELECT * FROM VW_DOCUMENTOFISCAL WHERE SQ_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL
    oData = DBQuery(sSqlText)

    If objDataTable_Vazio(oData) Then
      FNC_Mensagem("Documento Fiscal não encontrado")
    Else
      With oData.Rows(0)
        oNFe_Servico_RetornoRecepcaoEvento = oNFe_Servico.RecepcaoEventoCancelamento(1, 1, .Item("CD_PROTOCOLO"), .Item("CD_CHAVE_NFE"), sJustificativa, FNC_SoNumero(sEMPRESA_DADOS_CNPJ))

        If FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.cStat) = enOpcoes_NFe_StatusProcessamento.EventoRegistradoVinculadoNFe Or
           FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.cStat) = enOpcoes_NFe_StatusProcessamento.LoteEventoProcessado Then
          FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.retEvento(0).infEvento.cStat), iSQ_DOCUMENTOFISCAL, oNFe_Servico_RetornoRecepcaoEvento.Retorno.retEvento(0).infEvento.xMotivo & vbCrLf, .Item("CD_DOCUMENTOFISCAL"))

          If FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.retEvento(0).infEvento.cStat) = enOpcoes_NFe_StatusProcessamento.CancelamentoNFeHomologado Or
             FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.retEvento(0).infEvento.cStat) = enOpcoes_NFe_StatusProcessamento.EventoRegistradoVinculadoNFe Then
            bOk = True
            FormCadastroDocumentoFiscal_Cancelamento_Gravar(iSQ_DOCUMENTOFISCAL, sJustificativa)
          Else
            FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.retEvento(0).infEvento.cStat), iSQ_DOCUMENTOFISCAL, oNFe_Servico_RetornoRecepcaoEvento.Retorno.retEvento(0).infEvento.xMotivo & vbCrLf, .Item("CD_DOCUMENTOFISCAL"))
          End If
        Else
          FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoRecepcaoEvento.Retorno.cStat), iSQ_DOCUMENTOFISCAL, oNFe_Servico_RetornoRecepcaoEvento.Retorno.xMotivo & vbCrLf, .Item("CD_DOCUMENTOFISCAL"))
        End If
      End With
    End If

Sair:
    Return bOk
  End Function

  Public Function FNC_Fiscal_DocumentoFiscal_Transmitir(iSQ_DOCUMENTOFISCAL As Integer,
                                                      eModeloDocumento As ModeloDocumento,
                                                      Optional ByRef sDS_PATH_XML As String = "",
                                                      Optional ByRef bImpressaoNCFe As Boolean = False,
                                                      Optional bImprimirDanfeNFe As Boolean = False) As Boolean
    Dim oNFe As NFe.Classes.NFe
    Dim oNFe_Servico As NFe.Servicos.ServicosNFe
    Dim oNFe_Servico_RetornoNFeAutorizacao As NFe.Servicos.Retorno.RetornoNFeAutorizacao
    Dim oNFe_Proc As NFe.Classes.nfeProc
    Dim oConfig As NFe.Utils.ConfiguracaoServico
    Dim bVerificarProtocolo As Boolean = False
    Dim bProblemaNFe As Boolean = False
    Dim sCD_PROTOCOLO As String = ""
    Dim sCD_CHAVE_NFE As String = ""
    Dim sCD_NFCe_DetalheVendaNormal As String = ""
    Dim sCD_NFCe_DetalheVendaContigencia As String = ""
    Dim sCD_NFCe_Token_ID As String = ""
    Dim sCD_NFCe_Token_CSC As String = ""
    Dim bOk As Boolean = False

    If FNC_Fiscal_DocumentoFiscal_Transmitir_Validar(iSQ_DOCUMENTOFISCAL) Then
      Try
        oConfig = FNC_Fiscal_Configuracao(eModeloDocumento)
        If oConfig Is Nothing Then GoTo Sair

        FNC_Fiscal_Historico(0, iSQ_DOCUMENTOFISCAL, "Início de transmissão")

        sCD_CHAVE_NFE = FNC_Fiscal_DocumentoFiscal_ChaveNFE(iSQ_DOCUMENTOFISCAL)

        oNFe = FNC_Fiscal_DocumentoFiscal_Gerar(iSQ_DOCUMENTOFISCAL,
                                        oConfig,
                                        sCD_NFCe_DetalheVendaNormal,
                                        sCD_NFCe_DetalheVendaContigencia,
                                        sCD_NFCe_Token_ID,
                                        sCD_NFCe_Token_CSC)

        Application.DoEvents()

        If Not oNFe Is Nothing Then
          If Trim(sCD_CHAVE_NFE) <> "" Then
            oNFe_Proc = FNC_Fiscal_DocumentoFiscal_AssociarProtocolo(oConfig, oNFe, sCD_CHAVE_NFE)
            oNFe = oNFe_Proc.NFe

            If Not oNFe_Proc.protNFe Is Nothing Then
              bVerificarProtocolo = True
            End If
          End If

          If Not bVerificarProtocolo Then
            FNC_Fiscal_Historico(0, iSQ_DOCUMENTOFISCAL, "Solicitação de autorização")
            oNFe_Servico = New ServicosNFe(oConfig)
            oNFe_Servico_RetornoNFeAutorizacao = oNFe_Servico.NFeAutorizacao(Convert.ToInt32("1"),
                                                                             IIf(oNFe.infNFe.ide.mod = ModeloDocumento.NFCe, IndicadorSincronizacao.Sincrono, IndicadorSincronizacao.Assincrono),
                                                                             New List(Of NFeZeus)(New NFeZeus() {oNFe}), True)
            Try
              FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoNFeAutorizacao.Retorno.cStat), iSQ_DOCUMENTOFISCAL, "Solicitação de autorização - " & oNFe_Servico_RetornoNFeAutorizacao.Retorno.xMotivo & " - Recibo: " & oNFe_Servico_RetornoNFeAutorizacao.Retorno.infRec.nRec)
            Catch ex As Exception
              FNC_Fiscal_Historico(FNC_Fiscal_NFe_StatusProcessamento(oNFe_Servico_RetornoNFeAutorizacao.Retorno.cStat), iSQ_DOCUMENTOFISCAL, "Solicitação de autorização - " & oNFe_Servico_RetornoNFeAutorizacao.Retorno.xMotivo & " - Recibo: " & oNFe_Servico_RetornoNFeAutorizacao.Retorno.protNFe.infProt.nProt)
            End Try

            Application.DoEvents()
            Application.DoEvents()

            bVerificarProtocolo = (Not oNFe_Servico_RetornoNFeAutorizacao.Retorno Is Nothing) And (Not bProblemaNFe)
          End If

          If bVerificarProtocolo Then
            If FNC_Fiscal_DocumentoFiscal_Protocolo(oNFe, iSQ_DOCUMENTOFISCAL, oConfig, sCD_PROTOCOLO, sDS_PATH_XML) Then
              FNC_Fiscal_Historico(0, iSQ_DOCUMENTOFISCAL, "Salvar XML")

              Dim sAux As String

              Try
                sAux = FNC_DiretorioSistema_RemoverPath(FNC_DiretorioSistema_GuardarArquivo(sDS_PATH_XML))
              Catch ex As Exception
                sAux = sDS_PATH_XML
              End Try

              sDS_PATH_XML = sAux

              FNC_Fiscal_DocumentoFiscal_Status(iSQ_DOCUMENTOFISCAL,
                                                oNFe.infNFe.ide.nNF,
                                                enOpcoes.StatusDocumentoFiscal_Transmitido.GetHashCode(),
                                                iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE,
                                                oNFe.infNFe.Id.Substring(3),
                                                sCD_PROTOCOLO,
                                                sDS_PATH_XML)

              Select Case eModeloDocumento
                Case ModeloDocumento.NFe
                  If bImprimirDanfeNFe Then
                    FNC_Fiscal_Danfe_GerarPDF(FNC_DiretorioSistema_AdicionarPath(sDS_PATH_XML), True)
                  End If
                Case ModeloDocumento.NFCe
                  If bImpressaoNCFe And bESTACAO_TRABALHO_IC_IMPRIME_DANFENCFE_AUTOMATICAMENTE Then
                    FNC_Fiscal_Danfe_ImprimirNCFe(sDS_PATH_XML,
                          sCD_NFCe_DetalheVendaNormal,
                          sCD_NFCe_DetalheVendaContigencia,
                          sCD_NFCe_Token_ID,
                          sCD_NFCe_Token_CSC)
                  Else End If
              End Select

              bOk = True

              oNFe_Servico = Nothing
            Else
              FNC_Fiscal_DocumentoFiscal_ChaveNFE(iSQ_DOCUMENTOFISCAL, oNFe.infNFe.Id.Substring(3))
            End If
          End If
        Else
          GoTo Sair
        End If
      Catch ex As Exception
        oConfig = Nothing
        oNFe = Nothing
        oNFe_Servico = Nothing
        oNFe_Servico_RetornoNFeAutorizacao = Nothing

        FNC_Mensagem(ex.Message)

        GoTo Sair
      End Try
    Else
      GoTo Sair
    End If

Sair:
    If Not bOk Then
      FNC_Mensagem("Houve algum problema na transmissão. É necessário verificar o histórico da mesma")
    End If

    Return bOk
  End Function

  Private Function FNC_Fiscal_DocumentoFiscal_ChaveNFE(iSQ_DOCUMENTOFISCAL As Integer)
    Dim sSqlText As String

    sSqlText = "SELECT CD_CHAVE_NFE FROM TB_DOCUMENTOFISCAL WHERE SQ_DOCUMENTOFISCAL = " + iSQ_DOCUMENTOFISCAL.ToString()

    Return FNC_NVL(DBQuery_ValorUnico(sSqlText, ""), "")
  End Function

  Private Function FNC_Fiscal_DocumentoFiscal_FormaPagamento(iID_FORMA_PAGAMENTO As Integer) As NFe.Classes.Informacoes.Pagamento.FormaPagamento
    Dim eFormaPagamento As NFe.Classes.Informacoes.Pagamento.FormaPagamento = FormaPagamento.fpOutro

    Select Case iID_FORMA_PAGAMENTO
      Case const_FormaPagamento_Dinheiro
        eFormaPagamento = FormaPagamento.fpDinheiro
      Case const_FormaPagamento_CartaoCredito
        eFormaPagamento = FormaPagamento.fpCartaoCredito
      Case const_FormaPagamento_CartaoDebito
        eFormaPagamento = FormaPagamento.fpCartaoDebito
      Case const_FormaPagamento_Cheque
        eFormaPagamento = FormaPagamento.fpCheque
      Case const_FormaPagamento_NotaPromissoria
        eFormaPagamento = FormaPagamento.fpDuplicataMercantil
      Case const_FormaPagamento_CreditoCedido
        eFormaPagamento = FormaPagamento.fpDinheiro
      Case const_FormaPagamento_DepositoBancario
        eFormaPagamento = FormaPagamento.fpBoletoBancario
    End Select

    'fpCreditoLoja = 5
    'fpValeAlimentacao = 10
    'fpValeRefeicao = 11
    'fpValePresente = 12
    'fpValeCombustivel = 13
    'fpBoletoBancario = 15
    'fpSemPagamento = 90
    'fpOutro = 99

    Return eFormaPagamento
  End Function

  Public Function FNC_Fiscal_DocumentoFiscal_Produto(oNFe As NFe.Classes.NFe, nItem As String) As NFe.Classes.Informacoes.Detalhe.det
    Dim oProduto As NFe.Classes.Informacoes.Detalhe.det = Nothing

    For Each Item As NFe.Classes.Informacoes.Detalhe.det In oNFe.infNFe.det
      If Item.nItem = nItem Then
        oProduto = Item
        Exit For
      End If
    Next

    Return oProduto
  End Function

  Public Function FNC_Fiscal_DocumentoFiscal_Produto_DadosICMS(oProduto As NFe.Classes.Informacoes.Detalhe.det) As ICMSGeral
    Dim oICMSGeral As ICMSGeral = New ICMSGeral(oProduto.imposto.ICMS.TipoICMS)

    Return oICMSGeral
  End Function

  Public Function FNC_Fiscal_DocumentoFiscal_Produto_DadosCOFINS(oProduto As NFe.Classes.Informacoes.Detalhe.det) As COFINSGeral
    Dim oCOFINSGeral As COFINSGeral = New COFINSGeral(oProduto.imposto.COFINS.TipoCOFINS)

    Return oCOFINSGeral
  End Function

  Public Function FNC_Fiscal_DocumentoFiscal_Produto_DadosPIS(oProduto As NFe.Classes.Informacoes.Detalhe.det) As PISGeral
    Dim oPISGeral As PISGeral = New PISGeral(oProduto.imposto.PIS.TipoPIS)

    Return oPISGeral
  End Function

  Public Function FNC_Fiscal_DocumentoFiscal_Produto_DadosIPI(oProduto As NFe.Classes.Informacoes.Detalhe.det) As IPIGeral
    Dim oIPIGeral As IPIGeral = New IPIGeral(oProduto.imposto.IPI.TipoIPI)

    Return oIPIGeral
  End Function

  Private Function FNC_Fiscal_DocumentoFiscal_Gerar(iSQ_DOCUMENTOFISCAL As Integer,
                                                  oConfig As NFe.Utils.ConfiguracaoServico,
                                                  ByRef sCD_NFCe_DetalheVendaNormal As String,
                                                  ByRef sCD_NFCe_DetalheVendaContigencia As String,
                                                  ByRef sCD_NFCe_Token_ID As String,
                                                  ByRef sCD_NFCe_Token_CSC As String) As NFe.Classes.NFe
    Dim oNFe As NFe.Classes.NFe
    Dim oNFE_Det As NFe.Classes.Informacoes.Detalhe.det
    Dim oNFE_Dup As NFe.Classes.Informacoes.Cobranca.dup = Nothing
    Dim oNFE_Pag As NFe.Classes.Informacoes.Pagamento.pag
    Dim oNFE_Card As NFe.Classes.Informacoes.Pagamento.card
    Dim oNFE_Pag_Det As NFe.Classes.Informacoes.Pagamento.detPag
    Dim oNFE_autXML As NFe.Classes.Informacoes.autXML
    Dim oData_01 As DataTable
    Dim oData_02 As DataTable
    Dim sSqlText As String
    Dim iCont As Integer
    Dim sDS_PATH_XML As String
    Dim sAux As String
    Dim bClienteNaoInformado As Boolean

    Dim sNF As String
    Dim sDS_INFORMACOES_ADICIONAIS As String = ""

    Try
      sSqlText = "SELECT *" &
           " FROM VW_DOCUMENTOFISCAL_GERAR" &
           " WHERE SQ_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL.ToString()
      oData_01 = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData_01) Then
        With oData_01.Rows(0)
          If FNC_CampoNulo(.Item("CD_DOCUMENTOFISCAL_SERIE")) Then
            FNC_Mensagem("O número de série do documento não foi informado")
            Exit Function
          End If
          If FNC_CampoNulo(.Item("CD_EMPRESA_PJ_IE")) Then
            FNC_Mensagem("Inscrição Estadual não foi informado para a empresa que está transmitindo o documento fiscal")
            Exit Function
          End If
          If FNC_CampoNulo(.Item("CD_OPT_CRT")) Then
            FNC_Mensagem("É preciso informar o C.R.T. (Código de Regime Tributário)")
            Exit Function
          End If
          If FNC_CampoNulo(.Item("CD_EMPRESA_UF")) Then
            FNC_Mensagem("Endereço da empresa não cadastrado")
            Exit Function
          End If
          If .Item("CD_SERVICO_MODELO") <> const_NFe_ModeloServico_NFCe Then
            If FNC_CampoNulo(.Item("CD_PESSOA_UF")) And FNC_NVL(.Item("IC_EXIBIR_ENDERECO"), "N") = "S" Then
              FNC_Mensagem("Endereço do destinatário não cadastrado")
              Exit Function
            End If
          End If

          If FNC_CampoNulo(.Item("CD_DOCUMENTOFISCAL")) Then
            FNC_Fiscal_Historico(0, iSQ_DOCUMENTOFISCAL, "Criação do XML do documento fiscal")

            sSqlText = "SELECT dbo.FC_DOCUMENTOFISCAL_SERIE_EMISSAO_NOVONUMERO(" & .Item("ID_DOCUMENTOFISCAL_SERIE") & ")"
            sNF = DBQuery_ValorUnico(sSqlText)

            FNC_Fiscal_DocumentoFiscal_Serie_Emissao_NumeroAtual(.Item("ID_DOCUMENTOFISCAL_SERIE"), sNF)

            FNC_Fiscal_DocumentoFiscal_Status(iSQ_DOCUMENTOFISCAL,
                                  sNF,
                                  enOpcoes.StatusDocumentoFiscal_Transmitindo.GetHashCode(),
                                  iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE,
                                  Nothing, ,
                                  Nothing)
          Else
            FNC_Fiscal_Historico(0, iSQ_DOCUMENTOFISCAL, "Correção do XML do documento fiscal")

            sNF = .Item("CD_DOCUMENTOFISCAL")
          End If

          oNFe = New NFe.Classes.NFe

          oNFe.infNFe = New NFe.Classes.Informacoes.infNFe
          oNFe.infNFe.versao = .Item("CD_SERVICO_VERSAO")
          oNFe.infNFe.ide = New NFe.Classes.Informacoes.Identificacao.ide
          oNFe.infNFe.ide.cUF = Val(.Item("CD_EMPRESA_UF_IBGE"))
          oNFe.infNFe.ide.natOp = .Item("NO_NATUREZAOPERACAO").ToString().Trim()
          oNFe.infNFe.ide.mod = .Item("CD_SERVICO_MODELO")
          oNFe.infNFe.ide.serie = Val(.Item("CD_DOCUMENTOFISCAL_SERIE"))
          oNFe.infNFe.ide.nNF = sNF
          oNFe.infNFe.ide.tpNF = Val(.Item("CD_OPT_NFE_TIPOOPERACAO"))
          oNFe.infNFe.ide.cMunFG = Val(.Item("CD_EMPRESA_CIDADE_IBGE")).ToString().Trim()
          oNFe.infNFe.ide.tpEmis = Val(.Item("CD_OPT_NFE_FORMATOEMISSAO"))
          oNFe.infNFe.ide.tpImp = Val(.Item("CD_OPT_NFE_FORMATOIMPRESSAODANFE"))
          oNFe.infNFe.ide.cNF = "1" + FNC_StrZero(.Item("SQ_DOCUMENTOFISCAL"), 7)
          oNFe.infNFe.ide.tpAmb = oConfig.tpAmb
          oNFe.infNFe.ide.finNFe = FNC_NVL(Val(.Item("CD_OPT_FINALIDADE")), NFe.Classes.Informacoes.Identificacao.Tipos.FinalidadeNFe.fnNormal)
          oNFe.infNFe.ide.verProc = "4.000"

          If oNFe.infNFe.ide.tpEmis <> NFe.Classes.Informacoes.Identificacao.Tipos.TipoEmissao.teNormal Then
            oNFe.infNFe.ide.dhCont = DateTime.Now
            oNFe.infNFe.ide.xJust = "TESTE DE CONTIGÊNCIA PARA NFe/NFCe"
          End If

          If FNC_NVL(.Item("CD_EMPRESA_BACEN"), "") <> FNC_NVL(.Item("CD_PESSOA_BACEN"), "") Then
            oNFe.infNFe.ide.idDest = DestinoOperacao.doExterior
          ElseIf FNC_NVL(.Item("CD_EMPRESA_UF"), "") <> FNC_NVL(.Item("CD_PESSOA_UF"), "") Then
            oNFe.infNFe.ide.idDest = DestinoOperacao.doInterestadual
          Else
            oNFe.infNFe.ide.idDest = DestinoOperacao.doInterna
          End If

          If oNFe.infNFe.ide.mod = DFe.Classes.Flags.ModeloDocumento.NFCe Then
            oNFe.infNFe.ide.idDest = DestinoOperacao.doInterna
          Else
          End If
          oNFe.infNFe.ide.dhEmi = DateTime.Now

          'Mude aqui para enviar a nfe vinculada ao EPEC, V3.10
          If oNFe.infNFe.ide.mod = DFe.Classes.Flags.ModeloDocumento.NFe Then
            oNFe.infNFe.ide.dhSaiEnt = DateTime.Now
          End If

          oNFe.infNFe.ide.procEmi = NFe.Classes.Informacoes.Identificacao.Tipos.ProcessoEmissao.peAplicativoContribuinte

          If objDataTable_CampoVazio(.Item("CD_PESSOA_UF")) Then
            oNFe.infNFe.ide.indFinal = NFe.Classes.Informacoes.Identificacao.Tipos.ConsumidorFinal.cfConsumidorFinal
            oNFe.infNFe.ide.indPres = NFe.Classes.Informacoes.Identificacao.Tipos.PresencaComprador.pcPresencial
          Else
            If .Item("CD_PESSOA_UF") = .Item("CD_EMPRESA_UF") Then
              oNFe.infNFe.ide.indFinal = NFe.Classes.Informacoes.Identificacao.Tipos.ConsumidorFinal.cfConsumidorFinal

              If FNC_NVL(.Item("ID_DOCUMENTOFISCAL_TIPO"), 0) = enTipoDocumentoFiscal.Saida_CupomFiscalEletronico Then
                oNFe.infNFe.ide.indPres = NFe.Classes.Informacoes.Identificacao.Tipos.PresencaComprador.pcPresencial
              Else
                oNFe.infNFe.ide.indPres = NFe.Classes.Informacoes.Identificacao.Tipos.PresencaComprador.pcPresencial
              End If
            Else
              oNFe.infNFe.ide.indPres = NFe.Classes.Informacoes.Identificacao.Tipos.PresencaComprador.pcOutros

              If FNC_NVL(.Item("CD_OPT_PJ_CONTRIBUICAO_ICMS_PS"), 0) = NFe.Classes.Informacoes.Destinatario.indIEDest.NaoContribuinte.GetHashCode() Then
                oNFe.infNFe.ide.indFinal = NFe.Classes.Informacoes.Identificacao.Tipos.ConsumidorFinal.cfConsumidorFinal
              Else
                oNFe.infNFe.ide.indFinal = NFe.Classes.Informacoes.Identificacao.Tipos.ConsumidorFinal.cfNao
              End If
            End If
          End If

          If Not FNC_CampoNulo(.Item("ID_OPT_FISICO_JURIDICO_RESPONSAVELCONTABIL")) Then
            oNFE_autXML = New autXML
            oNFE_autXML.CNPJ = ""
            oNFE_autXML.CPF = ""

            Select Case .Item("ID_OPT_FISICO_JURIDICO_RESPONSAVELCONTABIL")
              Case enOpcoes.FisicoJuridico_Fisico.GetHashCode()
                oNFE_autXML.CPF = Trim(.Item("CD_CPF_CNPJ_PESSOA_RESPONSAVELCONTABIL"))
              Case enOpcoes.FisicoJuridico_Juridico.GetHashCode()
                oNFE_autXML.CNPJ = Trim(.Item("CD_CPF_CNPJ_PESSOA_RESPONSAVELCONTABIL"))
            End Select

            oNFe.infNFe.autXML = New List(Of autXML)(New autXML() {oNFE_autXML})
          End If

          '-- Emitente
          oNFe.infNFe.emit = New NFe.Classes.Informacoes.Emitente.emit
          oNFe.infNFe.emit.CNPJ = FNC_StrZero(.Item("CD_EMPRESA_CNPJ"), 14).ToString().Trim()
          oNFe.infNFe.emit.xNome = .Item("NO_EMPRESA").ToString().Trim()
          oNFe.infNFe.emit.xFant = .Item("NO_FANTASIA_REDUZIDO").ToString().Trim()
          oNFe.infNFe.emit.IE = FNC_SoNumero(FNC_NVL(.Item("CD_EMPRESA_PJ_IE"), "")).ToString().Trim()
          If Not FNC_CampoNulo(.Item("CD_EMPRESA_PJ_IM")) Then
            oNFe.infNFe.emit.IM = FNC_SoNumero(.Item("CD_EMPRESA_PJ_IM")).ToString().Trim()
            oNFe.infNFe.emit.CNAE = FNC_SoNumero(FNC_NVL(.Item("CD_EMPRESA_CNAE"), "")).ToString().Trim()
          Else
            oNFe.infNFe.emit.IM = "ISENTO"
          End If
          oNFe.infNFe.emit.IEST = Nothing
          oNFe.infNFe.emit.CRT = FNC_SoNumero(FNC_NVL(.Item("CD_OPT_CRT"), "")).ToString().Trim()
          '-- Emitente Endereço
          oNFe.infNFe.emit.enderEmit = New NFe.Classes.Informacoes.Emitente.enderEmit
          oNFe.infNFe.emit.enderEmit.xLgr = FNC_NVL(.Item("DS_EMPRESA_LOGRADOURO"), "").ToString().Trim()
          oNFe.infNFe.emit.enderEmit.nro = FNC_Endereco_TratarNumero(.Item("NR_EMPRESA_LOGRADOURO")).ToString().Trim()
          oNFe.infNFe.emit.enderEmit.xCpl = FNC_NVL(.Item("DS_EMPRESA_COMPLEMENTO"), "").ToString().Trim()
          oNFe.infNFe.emit.enderEmit.xBairro = FNC_NVL(.Item("NO_EMPRESA_BAIRRO"), "").ToString().Trim()
          oNFe.infNFe.emit.enderEmit.cMun = FNC_NVL(.Item("CD_EMPRESA_CIDADE_IBGE"), "").ToString().Trim()
          oNFe.infNFe.emit.enderEmit.xMun = FNC_NVL(.Item("NO_EMPRESA_CIDADE"), "").ToString().Trim()
          oNFe.infNFe.emit.enderEmit.UF = Val(.Item("CD_EMPRESA_UF_IBGE"))
          If Not objDataTable_CampoVazio(.Item("CD_EMPRESA_CEP")) Then
            oNFe.infNFe.emit.enderEmit.CEP = FNC_StrZero(FNC_SoNumero(Trim(FNC_NVL(.Item("CD_EMPRESA_CEP"), ""))), 8)
          End If
          oNFe.infNFe.emit.enderEmit.cPais = Trim(FNC_NVL(.Item("CD_EMPRESA_BACEN"), "")).ToString().Trim()
          oNFe.infNFe.emit.enderEmit.xPais = Trim(FNC_NVL(.Item("NO_EMPRESA_PAIS"), "")).ToString().Trim()

          If FNC_SoNumero(Trim(FNC_NVL(.Item("CD_EMPRESA_TELEFONE"), ""))) <> "" Then
            oNFe.infNFe.emit.enderEmit.fone = FNC_SoNumero(Trim(FNC_NVL(.Item("CD_EMPRESA_TELEFONE"), "")))
          End If

          '--Destinatário
          If FNC_NVL(.Item("IC_EXIBIR_PESSOA"), "S") = "S" Then
            If .Item("ID_OPT_FISICO_JURIDICO") = enOpcoes.FisicoJuridico_Juridico.GetHashCode() Then
              oNFe.infNFe.dest = New NFe.Classes.Informacoes.Destinatario.dest(.Item("CD_SERVICO_VERSAO"))
              oNFe.infNFe.dest.CNPJ = FNC_StrZero(FNC_SoNumero(.Item("CD_CPF_CNPJ")), 14).ToString().Trim()
            Else
              If FNC_SoNumero(.Item("CD_CPF_CNPJ")) <> "00000000000" Then
                oNFe.infNFe.dest = New NFe.Classes.Informacoes.Destinatario.dest(.Item("CD_SERVICO_VERSAO"))
                oNFe.infNFe.dest.CPF = FNC_StrZero(FNC_SoNumero(.Item("CD_CPF_CNPJ")), 11).ToString().Trim()
              Else
                bClienteNaoInformado = True
              End If
            End If
          Else
            bClienteNaoInformado = True
          End If

          If Not bClienteNaoInformado Then
            If oNFe.infNFe.ide.tpAmb = TipoAmbiente.Homologacao Then
              oNFe.infNFe.dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"
            Else
              oNFe.infNFe.dest.xNome = .Item("NO_PESSOA").ToString().Trim()
            End If
            If Not FNC_CampoNulo(.Item("DS_PESSOA_EMAIL")) Then oNFe.infNFe.dest.email = FNC_NVL(.Item("DS_PESSOA_EMAIL"), "").ToString().Trim()
          End If

          If Not objDataTable_CampoVazio(.Item("ID_ENDERECO")) And
   Not bClienteNaoInformado And
   FNC_NVL(.Item("IC_EXIBIR_ENDERECO"), "S") = "S" Then
            '--Destinatário Endereço
            oNFe.infNFe.dest.enderDest = New NFe.Classes.Informacoes.Destinatario.enderDest
            oNFe.infNFe.dest.enderDest.xLgr = FNC_NVL(.Item("DS_PESSOA_LOGRADOURO"), " ").ToString().Trim()
            oNFe.infNFe.dest.enderDest.nro = FNC_Endereco_TratarNumero(.Item("NR_PESSOA_LOGRADOURO")).ToString().Trim()
            oNFe.infNFe.dest.enderDest.xCpl = FNC_NVL(.Item("DS_PESSOA_COMPLEMENTO"), " ").ToString().Trim()
            oNFe.infNFe.dest.enderDest.xBairro = .Item("NO_PESSOA_BAIRRO").ToString().Trim()
            oNFe.infNFe.dest.enderDest.cMun = .Item("CD_PESSOA_CIDADE_IBGE").ToString().Trim()
            oNFe.infNFe.dest.enderDest.xMun = .Item("NO_PESSOA_CIDADE").ToString().Trim()
            oNFe.infNFe.dest.enderDest.UF = .Item("CD_PESSOA_UF")
            If Not FNC_CampoNulo(.Item("CD_PESSOA_CEP")) Then oNFe.infNFe.dest.enderDest.CEP = FNC_StrZero(FNC_SoNumero(.Item("CD_PESSOA_CEP")), const_Formatos_CEP_Tamanho)
            oNFe.infNFe.dest.enderDest.cPais = Trim(FNC_NVL(.Item("CD_PESSOA_BACEN"), "")).ToString().Trim()
            oNFe.infNFe.dest.enderDest.xPais = Trim(FNC_NVL(.Item("NO_PESSOA_PAIS"), "")).ToString().Trim()
          End If
          If Not bClienteNaoInformado Then
            If Not FNC_CampoNulo(.Item("CD_PESSOA_TELEFONE")) Then oNFe.infNFe.dest.enderDest.fone = Trim(FNC_SoNumero(FNC_NVL(.Item("CD_PESSOA_TELEFONE"), "")))
          End If

          If oNFe.infNFe.ide.mod = DFe.Classes.Flags.ModeloDocumento.NFCe Then
            If Not bClienteNaoInformado Then
              oNFe.infNFe.dest.indIEDest = NFe.Classes.Informacoes.Destinatario.indIEDest.NaoContribuinte
            End If
          Else
            If Not oNFe.infNFe.dest Is Nothing Then
              oNFe.infNFe.dest.indIEDest = Val(FNC_NVL(.Item("CD_OPT_PJ_CONTRIBUICAO_ICMS_PS"), NFe.Classes.Informacoes.Destinatario.indIEDest.NaoContribuinte.ToString()))
            End If

            If FNC_NVL(.Item("CD_OPT_PJ_CONTRIBUICAO_ICMS_PS"), NFe.Classes.Informacoes.Destinatario.indIEDest.NaoContribuinte) =
   NFe.Classes.Informacoes.Destinatario.indIEDest.ContribuinteICMS And Not bClienteNaoInformado Then
              If Not FNC_CampoNulo(.Item("CD_PJ_IE")) Then oNFe.infNFe.dest.IE = FNC_NVL(.Item("CD_PJ_IE"), "").ToString().Trim()
              If Not FNC_CampoNulo(.Item("CD_PJ_IM")) Then oNFe.infNFe.dest.IM = .Item("CD_PJ_IM").ToString().Trim()
            End If
          End If

          '--Destinatário Endereço Retirada
          If Not objDataTable_CampoVazio(.Item("ID_ENDERECO_RETIRADA")) Then
            If FNC_NVL(.Item("ID_ENDERECO"), 0) <> FNC_NVL(.Item("ID_ENDERECO_RETIRADA"), 0) Then
              oNFe.infNFe.retirada = New NFe.Classes.Informacoes.retirada
              oNFe.infNFe.retirada.xLgr = .Item("DS_PESSOA_RETIRADA_LOGRADOURO").ToString().Trim()
              oNFe.infNFe.retirada.nro = FNC_NVL(.Item("NR_PESSOA_RETIRADA_LOGRADOURO"), " ").ToString().Trim()
              oNFe.infNFe.retirada.xCpl = .Item("DS_PESSOA_RETIRADA_COMPLEMENTO").ToString().Trim()
              oNFe.infNFe.retirada.xBairro = .Item("NO_PESSOA_RETIRADA_BAIRRO").ToString().Trim()
              oNFe.infNFe.retirada.cMun = .Item("CD_PESSOA_RETIRADA_CIDADE_IBGE").ToString().Trim()
              oNFe.infNFe.retirada.xMun = .Item("NO_PESSOA_RETIRADA_CIDADE").ToString().Trim()
              oNFe.infNFe.retirada.UF = .Item("CD_PESSOA_RETIRADA_UF").ToString().Trim()
            End If
          End If

          '-- Transporte
          If FNC_NVL(.Item("ID_DOCUMENTOFISCAL_TIPO"), 0) = enTipoDocumentoFiscal.Saida_CupomFiscalEletronico Then
            oNFe.infNFe.transp = New NFe.Classes.Informacoes.Transporte.transp
            oNFe.infNFe.transp.modFrete = NFe.Classes.Informacoes.Transporte.ModalidadeFrete.mfSemFrete
          Else
            oNFe.infNFe.transp = New NFe.Classes.Informacoes.Transporte.transp
            oNFe.infNFe.transp.modFrete = Val(FNC_NVL(.Item("CD_OPT_FRETE"), enOpcoes.TipoFrete_SemFrete.GetHashCode()))
            oNFe.infNFe.transp.modFrete = NFe.Classes.Informacoes.Transporte.ModalidadeFrete.mfSemFrete

            If FNC_NVL(.Item("CD_OPT_FRETE"), enOpcoes.TipoFrete_SemFrete.GetHashCode()) <> enOpcoes.TipoFrete_SemFrete Then
              oNFe.infNFe.transp.transporta = New NFe.Classes.Informacoes.Transporte.transporta

              If Not FNC_CampoNulo(.Item("ID_PESSOA_TRANSPORTADORA")) Then
                If FNC_NVL(.Item("ID_OPT_TRANSPORTADORA_FISICO_JURIDICO"), 0) = enOpcoes.FisicoJuridico_Juridico.GetHashCode() Then
                  oNFe.infNFe.transp.transporta.CNPJ = FNC_StrZero(.Item("CD_TRANSPORTADORA_CPF_CNPJ"), 14).ToString().Trim()
                Else
                  oNFe.infNFe.transp.transporta.CPF = FNC_StrZero(FNC_SoNumero(.Item("CD_TRANSPORTADORA_CPF_CNPJ")), 11).ToString().Trim()
                End If

                oNFe.infNFe.transp.transporta.xNome = FNC_NVL(.Item("NO_TRANSPORTADORA"), "").ToString().Trim()
                oNFe.infNFe.transp.transporta.xEnder = FNC_NVL(.Item("DS_TRANSPORTADORA_LOGRADOURO_COMPLETO"), "").ToString().Trim()
                oNFe.infNFe.transp.transporta.xMun = FNC_NVL(.Item("NO_TRANSPORTADORA_CIDADE"), "").ToString().Trim()
                oNFe.infNFe.transp.transporta.UF = FNC_NVL(.Item("CD_TRANSPORTADORA_UF"), "").ToString().Trim()

                If FNC_NVL(.Item("CD_OPT_TRANSPORTADORA_PJ_CONTRIBUICAO_ICMS"), NFe.Classes.Informacoes.Destinatario.indIEDest.NaoContribuinte) =
NFe.Classes.Informacoes.Destinatario.indIEDest.ContribuinteICMS Then
                  oNFe.infNFe.transp.transporta.IE = .Item("CD_PJ_IE").ToString().Trim()
                End If
              End If
            End If
          End If

          '-- Detalhe
          sSqlText = "SELECT * FROM VW_DOCUMENTOFISCAL_PRODUTO_GERAR" &
         " WHERE ID_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL &
           " AND ID_OPT_STATUS NOT IN (" & enOpcoes.StatusItemDocumentoFiscal_Cancelado.GetHashCode().ToString & ")"
          oData_02 = DBQuery(sSqlText)

          For iCont = 0 To oData_02.Rows.Count - 1
            If FNC_CampoNulo(oData_02.Rows(iCont).Item("CD_OPT_ORIGEMPRODUTO")) Then
              FNC_Mensagem("É preciso informa a origem do produto " & oData_02.Rows(iCont).Item("NO_PRODUTO"))
              Exit Function
            End If

            oNFE_Det = New NFe.Classes.Informacoes.Detalhe.det

            oNFE_Det.nItem = iCont + 1

            '-- Detalhe Dados do Produto
            oNFE_Det.prod = New NFe.Classes.Informacoes.Detalhe.prod
            oNFE_Det.prod.cProd = oData_02.Rows(iCont).Item("CD_PRODUTO").ToString().Trim()

            If FNC_NVL(oData_02.Rows(iCont).Item("IC_REGISTRADO_GTIN"), "N") = "S" Then
              oNFE_Det.prod.cEAN = oData_02.Rows(iCont).Item("CD_BARRA_FABRICANTE").ToString().Trim()
            Else
              oNFE_Det.prod.cEAN = const_NFe_ProdutoSemGTIN
            End If

            If oNFe.infNFe.ide.tpAmb = TipoAmbiente.Homologacao Then
              oNFE_Det.prod.xProd = "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"
            Else
              oNFE_Det.prod.xProd = oData_02.Rows(iCont).Item("NO_PRODUTO").ToString().Trim()
            End If

            oNFE_Det.prod.NCM = FNC_SoNumero(oData_02.Rows(iCont).Item("CD_NCM")).ToString().Trim()
            oNFE_Det.prod.CFOP = oData_02.Rows(iCont).Item("CD_CFOP").ToString().Trim()
            oNFE_Det.prod.uCom = oData_02.Rows(iCont).Item("CD_UNIDADEMEDIDA").ToString().Trim()
            oNFE_Det.prod.qCom = oData_02.Rows(iCont).Item("QT_PRODUTO")
            oNFE_Det.prod.vUnCom = oData_02.Rows(iCont).Item("VL_UNITARIO")
            oNFE_Det.prod.vProd = oData_02.Rows(iCont).Item("QT_PRODUTO") * oData_02.Rows(iCont).Item("VL_UNITARIO")
            If FNC_NVL(oData_02.Rows(iCont).Item("VL_DESCONTO"), 0) > 0 Then
              oNFE_Det.prod.vDesc = oData_02.Rows(iCont).Item("VL_DESCONTO")
            End If
            oNFE_Det.prod.vFrete = CDbl(FNC_NVL(oData_02.Rows(iCont).Item("VL_FRETE"), 0))
            oNFE_Det.prod.vSeg = CDbl(FNC_NVL(oData_02.Rows(iCont).Item("VL_SEGURO"), 0))
            '-- Detalhe Dados do Produto Tributação
            If FNC_NVL(oData_02.Rows(iCont).Item("IC_REGISTRADO_GTIN"), "N") = "S" Then
              oNFE_Det.prod.cEANTrib = oData_02.Rows(iCont).Item("CD_BARRA_FABRICANTE").ToString().Trim()
            Else
              oNFE_Det.prod.cEANTrib = const_NFe_ProdutoSemGTIN
            End If
            oNFE_Det.prod.uTrib = oData_02.Rows(iCont).Item("CD_UNIDADEMEDIDA").ToString().Trim()
            oNFE_Det.prod.qTrib = oData_02.Rows(iCont).Item("QT_PRODUTO")
            oNFE_Det.prod.vUnTrib = oData_02.Rows(iCont).Item("VL_UNITARIO")
            '-- Detalhe Dados do Produto Totaliza
            oNFE_Det.prod.indTot = IIf(FNC_NVL(oData_02.Rows(iCont).Item("IC_TOTALIZA"), "N") = "S",
                         NFe.Classes.Informacoes.Detalhe.IndicadorTotal.ValorDoItemNaoCompoeTotalNF,
                         NFe.Classes.Informacoes.Detalhe.IndicadorTotal.ValorDoItemCompoeTotalNF)

            '-- Detalhe Impostos
            oNFE_Det.imposto = New NFe.Classes.Informacoes.Detalhe.Tributacao.imposto
            oNFE_Det.imposto.vTotTrib = 0
            '-- Detalhe Imposto ICMS
            oNFE_Det.imposto.ICMS = New NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.ICMS
            oNFE_Det.imposto.ICMS.TipoICMS = ObterIcmsBasico(Val(.Item("CD_OPT_CRT")),
                                                 oData_02.Rows(iCont).Item("CD_OPT_ORIGEMPRODUTO"),
                                                 oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST"),
                                                 oData_02.Rows(iCont).Item("CD_OPT_MODALIDADE_BC_ICMS"),
                                                 oData_02.Rows(iCont).Item("CD_CSOSN"),
                                                 FNC_Porcentagem(FNC_NVL(oData_02.Rows(iCont).Item("VL_TOTAL"), 0), Val(FNC_NVL(oData_02.Rows(iCont).Item("PC_BASE_ICMS"), 0))),
                                                 Val(FNC_NVL(oData_02.Rows(iCont).Item("PC_ICMS"), 0)),
                                                 Val(FNC_NVL(oData_02.Rows(iCont).Item("VL_ICMS"), 0)))
            '-- Detalhe Imposto COFINS
            If Not objDataTable_CampoVazio(oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_COFINS")) Then
              oNFE_Det.imposto.COFINS = New NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.COFINS
              oNFE_Det.imposto.COFINS.TipoCOFINS = ObterCofinsBasico(Val(FNC_NVL(oData_02.Rows(iCont).Item("ID_CST_COFINS_OPT_TIPOCALCULO"), 0)),
                                                       Val(oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_COFINS")),
                                                       FNC_NVL(oData_02.Rows(iCont).Item("VL_TOTAL"), 0),
                                                       FNC_NVL(oData_02.Rows(iCont).Item("PC_COFINS"), 0),
                                                       FNC_NVL(oData_02.Rows(iCont).Item("VL_COFINS"), 0),
                                                       FNC_NVL(oData_02.Rows(iCont).Item("QT_PRODUTO"), 0),
                                                       FNC_NVL(oData_02.Rows(iCont).Item("VL_UNITARIO"), 0))
            End If
            '-- Detalhe Imposto PIS
            If Not objDataTable_CampoVazio(oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_PIS")) Then
              oNFE_Det.imposto.PIS = New NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.PIS
              oNFE_Det.imposto.PIS.TipoPIS = ObterPisBasico(Val(FNC_NVL(oData_02.Rows(iCont).Item("ID_CST_PIS_OPT_TIPOCALCULO"), 0)),
                                              Val(oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_PIS")),
                                              CDbl(FNC_NVL(oData_02.Rows(iCont).Item("VL_TOTAL"), 0)),
                                              CDbl(FNC_NVL(oData_02.Rows(iCont).Item("PC_PIS"), 0)),
                                              CDbl(FNC_NVL(oData_02.Rows(iCont).Item("VL_PIS"), 0)),
                                              FNC_NVL(oData_02.Rows(iCont).Item("QT_PRODUTO"), 0),
                                              FNC_NVL(oData_02.Rows(iCont).Item("VL_UNITARIO"), 0))
            End If
            '-- Detalhe Imposto IPI
            'NFC-e não aceita grupo "IPI"
            If (.Item("CD_SERVICO_MODELO") = const_NFe_ModeloServico_NFe) Then
              If Not objDataTable_CampoVazio(oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_IPI")) Then
                oNFE_Det.imposto.IPI = New NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.IPI
                oNFE_Det.imposto.IPI.cEnq = 999
                oNFE_Det.imposto.IPI.TipoIPI = ObterIPIBasico(Val(oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_IPI")),
                                          FNC_NVL(oData_02.Rows(iCont).Item("VL_TOTAL"), 0),
                                          FNC_NVL(oData_02.Rows(iCont).Item("PC_IPI"), 0),
                                          FNC_NVL(oData_02.Rows(iCont).Item("VL_IPI"), 0))
              End If
            End If

            oNFe.infNFe.det.Add(oNFE_Det)
          Next

          '-- Total
          oNFe.infNFe.total = GetTotal(.Item("CD_SERVICO_VERSAO"), oNFe.infNFe.det)

          '-- Cobrança
          If oNFe.infNFe.ide.mod = ModeloDocumento.NFe And (.Item("CD_SERVICO_VERSAO") = const_NFe_VersaoServico_ve310 Or
                                                  .Item("CD_SERVICO_VERSAO") = const_NFe_VersaoServico_ve400) Then
            oNFe.infNFe.cobr = New NFe.Classes.Informacoes.Cobranca.cobr()
            oNFe.infNFe.cobr.fat = New NFe.Classes.Informacoes.Cobranca.fat
            oNFe.infNFe.cobr.fat.nFat = sNF
            oNFe.infNFe.cobr.fat.vLiq = oNFe.infNFe.total.ICMSTot.vNF
            oNFe.infNFe.cobr.fat.vOrig = oNFe.infNFe.total.ICMSTot.vNF
            oNFe.infNFe.cobr.fat.vDesc = 0D
          End If

          If oNFe.infNFe.ide.mod = ModeloDocumento.NFCe Or
             (oNFe.infNFe.ide.mod = ModeloDocumento.NFe And .Item("CD_SERVICO_VERSAO") = const_NFe_VersaoServico_ve400) Then
            sSqlText = "SELECT PEDPG.ID_FORMAPAGAMENTO, PEDPG.VL_PAGAMENTO, ADMFN.CD_CPF_CNPJ, ADMFN.CD_AUTORIZACAO" +
                       " FROM TB_DOCUMENTOFISCAL DCFSC" +
                        " INNER JOIN TB_PEDIDO_PAGAMENTO PEDPG ON PEDPG.SQ_PEDIDO_PAGAMENTO = DCFSC.ID_PEDIDO_PAGAMENTO" +
                         " LEFT JOIN TB_FORMAPAGAMENTO FPGTO ON FPGTO.SQ_FORMAPAGAMENTO = PEDPG.ID_FORMAPAGAMENTO" &
                         " LEFT JOIN VW_ADMINISTRADOORAFINANCEIRA ADMFN ON ADMFN.ID_ADMINISTRADOORAFINANCEIRA = FPGTO.ID_ADMINISTRADOORA_MAQUINA_CARTAO" &
                       " WHERE DCFSC.SQ_DOCUMENTOFISCAL = " + iSQ_DOCUMENTOFISCAL.ToString()
            oData_02 = DBQuery(sSqlText)

            If objDataTable_Vazio(oData_02) Then
              oNFE_Pag = New NFe.Classes.Informacoes.Pagamento.pag
              oNFE_Pag.detPag = New List(Of NFe.Classes.Informacoes.Pagamento.detPag)
              oNFE_Pag_Det = New NFe.Classes.Informacoes.Pagamento.detPag
              oNFE_Pag_Det.tPag = FormaPagamento.fpSemPagamento
              oNFE_Pag_Det.vPag = 0
              oNFE_Pag.detPag.Add(oNFE_Pag_Det)

              oNFe.infNFe.pag = New List(Of NFe.Classes.Informacoes.Pagamento.pag)
              oNFe.infNFe.pag.Add(oNFE_Pag)
            Else
              For iCont = 0 To oData_02.Rows.Count - 1
                'Pagamento
                If .Item("CD_SERVICO_VERSAO") <> const_NFe_VersaoServico_ve400 Then
                  oNFe.infNFe.pag = New List(Of NFe.Classes.Informacoes.Pagamento.pag)
                  oNFE_Pag = New NFe.Classes.Informacoes.Pagamento.pag
                  oNFE_Pag.tPag = FNC_Fiscal_DocumentoFiscal_FormaPagamento(Val(oData_02.Rows(iCont).Item("ID_FORMAPAGAMENTO")))
                  oNFE_Pag.vPag = oData_02.Rows(iCont).Item("VL_PAGAMENTO")
                Else
                  oNFe.infNFe.pag = New List(Of NFe.Classes.Informacoes.Pagamento.pag)
                  oNFE_Pag = New NFe.Classes.Informacoes.Pagamento.pag
                  oNFE_Pag.vTroco = 0
                  'Pagamento Detalhe
                  oNFE_Pag.detPag = New List(Of NFe.Classes.Informacoes.Pagamento.detPag)
                  oNFE_Pag_Det = New NFe.Classes.Informacoes.Pagamento.detPag
                  oNFE_Pag_Det.tPag = FNC_Fiscal_DocumentoFiscal_FormaPagamento(Val(oData_02.Rows(iCont).Item("ID_FORMAPAGAMENTO")))
                  oNFE_Pag_Det.vPag = oData_02.Rows(iCont).Item("VL_PAGAMENTO")

                  If oNFE_Pag_Det.tPag = FormaPagamento.fpCartaoCredito Or oNFE_Pag_Det.tPag = FormaPagamento.fpCartaoDebito Then
                    oNFE_Card = New NFe.Classes.Informacoes.Pagamento.card
                    oNFE_Card.tpIntegra = TipoIntegracaoPagamento.TipNaoIntegrado
                    oNFE_Card.CNPJ = oData_02.Rows(iCont).Item("CD_CPF_CNPJ")
                    oNFE_Card.tBand = BandeiraCartao.bcOutros
                    oNFE_Card.cAut = oData_02.Rows(iCont).Item("CD_AUTORIZACAO")
                    oNFE_Pag_Det.card = oNFE_Card
                  End If

                  oNFE_Pag.detPag.Add(oNFE_Pag_Det)

                  oNFe.infNFe.pag.Add(oNFE_Pag)
                End If
              Next
            End If
          End If

          If FNC_NVL(.Item("ID_OPT_TIPO_REFERENCIA"), 0) <> enOpcoes.TipoReferenciaNaturezaOperacao_NaoReferenciar.GetHashCode() Then
            Dim oListaNFref As New List(Of NFref)
            Dim oNFref As NFref

            '-- Notas refênciadas
            sSqlText = "SELECT * FROM TB_DOCUMENTOFISCAL_REFERENCIA" &
          " WHERE ID_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL
            oData_02 = DBQuery(sSqlText)

            For iCont = 0 To oData_02.Rows.Count - 1
              oNFref = New NFref()

              If FNC_NVL(.Item("ID_OPT_FINALIDADE"), 0) = enOpcoes.Finalidade_NFe_DevolucaoRetorno.GetHashCode() Then
                Select Case FNC_NVL(.Item("ID_OPT_TIPO_REFERENCIA"), 0)
                  Case enOpcoes.TipoReferenciaNaturezaOperacao_ReferenciarNFe
                    oNFref.refNFe = oData_02.Rows(0).Item("CD_CHAVE_NFE_REFENCENCIA").ToString().Trim()

                    FNC_Str_Adicionar(sDS_INFORMACOES_ADICIONAIS, "DEVOLUCAO REF: " + oNFref.refNFe, ". ")
                End Select
              End If

              oListaNFref.Add(oNFref)
            Next

            oNFe.infNFe.ide.NFref = oListaNFref
          End If

          If Not FNC_CampoNulo(FNC_NuloString(FNC_NVL(.Item("DS_INFORMACOES_ADICIONAIS"), ""), False)) Then
            sDS_INFORMACOES_ADICIONAIS = FNC_NVL(.Item("DS_INFORMACOES_ADICIONAIS"), "") + ". " + sDS_INFORMACOES_ADICIONAIS
          End If

          If Trim(sDS_INFORMACOES_ADICIONAIS) <> "" Then
            oNFe.infNFe.infAdic = New NFe.Classes.Informacoes.Observacoes.infAdic
            sDS_INFORMACOES_ADICIONAIS = sDS_INFORMACOES_ADICIONAIS.Trim()
            If sDS_INFORMACOES_ADICIONAIS.Substring(sDS_INFORMACOES_ADICIONAIS.Length - 1) = "." Then
              sDS_INFORMACOES_ADICIONAIS = sDS_INFORMACOES_ADICIONAIS.Substring(0, sDS_INFORMACOES_ADICIONAIS.Length - 1)
            End If
            oNFe.infNFe.infAdic.infCpl = sDS_INFORMACOES_ADICIONAIS
          End If

          oNFe.Assina(oConfig)

          If oNFe.infNFe.ide.mod = ModeloDocumento.NFCe Then
            If oNFe.infNFeSupl Is Nothing Then
              oNFe.infNFeSupl = New infNFeSupl()
              If .Item("CD_SERVICO_VERSAO") = const_NFe_VersaoServico_ve400 Then
                oNFe.infNFeSupl.urlChave = oNFe.infNFeSupl.ObterUrlConsulta(oNFe, Val(sESTACAO_TRABALHO_CD_OPT_NFCe_VERSAO_QRCODE))
              End If

              sCD_NFCe_DetalheVendaNormal = iESTACAO_TRABALHO_ID_OPT_NFCe_DETALHE_VENDA_NORMAL
              sCD_NFCe_DetalheVendaContigencia = iESTACAO_TRABALHO_ID_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA
              sCD_NFCe_Token_ID = sESTACAO_TRABALHO_CD_NFCe_Token_ID
              sCD_NFCe_Token_CSC = sESTACAO_TRABALHO_CD_NFCe_Token_CSC.ToString().Replace("-", "")
              sCD_NFCe_Token_CSC = sESTACAO_TRABALHO_CD_NFCe_Token_CSC

              oNFe.infNFeSupl.qrCode = oNFe.infNFeSupl.ObterUrlQrCode(oNFe, Val(sESTACAO_TRABALHO_CD_OPT_NFCe_VERSAO_QRCODE), sCD_NFCe_Token_ID, sCD_NFCe_Token_CSC)
            End If
          End If

          sDS_PATH_XML = FNC_NVL(.Item("DS_PATH_XML"), "")

          If FNC_Diretorio_Temporario() <> "" Then
            Try
              sAux = FNC_Diretorio_Temporario() & "NF-" & sNF & "-" & .Item("CD_DOCUMENTOFISCAL_SERIE") & ".xml"
              oNFe.SalvarArquivoXml(sAux)

              If sDS_PATH_XML.Trim() = "" Then
                sDS_PATH_XML = FNC_DiretorioSistema_RemoverPath(FNC_DiretorioSistema_GuardarArquivo(sAux))
              Else
                Try
                  Kill(FNC_DiretorioSistema_AdicionarPath(sDS_PATH_XML))
                  FileCopy(sAux, FNC_DiretorioSistema_AdicionarPath(sDS_PATH_XML))
                Catch ex As Exception
                End Try
              End If

            Catch ex As Exception
              FNC_Mensagem("FNC_Fiscal_DocumentoFiscal_Gerar - SalvarArquivoXml: " + ex.Message)
            End Try
          End If

          oNFe.Valida(oConfig)

          FNC_Fiscal_DocumentoFiscal_Status(iSQ_DOCUMENTOFISCAL,
                                  sNF,
                                  enOpcoes.StatusDocumentoFiscal_Transmitindo.GetHashCode(),
                                  iESTACAO_TRABALHO_ID_OPT_CERTIFICADO_DIGITAL_AMBIENTE,
                                  oNFe.infNFe.Id.Substring(3), ,
                                  sDS_PATH_XML)
        End With
      End If

      Return oNFe
    Catch ex As Exception
      If ex.InnerException Is Nothing Then
        FNC_Mensagem(ex.Message)
      Else
        FNC_Mensagem(ex.Message + "." + ex.InnerException.Message)
      End If
      Return Nothing
    End Try
  End Function

  Private Function ObterIcmsBasico(ByVal oCrt As CRT,
                                 eOrigemMercadoria As NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos.OrigemMercadoria,
                                 eCST As Csticms,
                                 emodBC As DeterminacaoBaseIcms,
                                 eCSOSN As Csosnicms,
                                 vBC As Decimal,
                                 pICMS As Decimal,
                                 vICMS As Decimal) As ICMSBasico
    Dim icmsGeral = New ICMSGeral

    icmsGeral.orig = eOrigemMercadoria
    icmsGeral.CST = eCST
    icmsGeral.modBC = emodBC
    icmsGeral.CSOSN = eCSOSN
    icmsGeral.vBC = vBC
    icmsGeral.pICMS = pICMS
    icmsGeral.vICMS = vICMS
    icmsGeral.modBCST = DeterminacaoBaseIcmsSt.DbisMargemValorAgregado

    'icmsGeral.motDesICMS = MotivoDesoneracaoIcms.MdiTaxi
    'Public Property vICMSSTRet As Decimal?
    'Public Property pBCOp As Decimal
    'Public Property UFST As String
    'Public Property vBCSTDest As Decimal
    'Public Property vICMSSTDest As Decimal
    'Public Property pCredSN As Decimal
    'Public Property vCredICMSSN As Decimal
    'Public Property vBCFCP As Decimal?
    'Public Property pFCP As Decimal?
    'Public Property vFCP As Decimal?
    'Public Property vBCFCPST As Decimal?
    'Public Property pFCPST As Decimal?
    'Public Property vFCPST As Decimal?
    'Public Property pST As Decimal?
    'Public Property vBCFCPSTRet As Decimal?
    'Public Property vBCSTRet As Decimal?
    'Public Property vICMSDif As Decimal?
    'Public Property pDif As Decimal?
    'Public Property vICMSOp As Decimal?
    'Public Property pFCPSTRet As Decimal?
    'Public Property pRedBCST As Decimal?
    'Public Property vBCST As Decimal
    'Public Property pICMSST As Decimal
    'Public Property vICMSST As Decimal
    'Public Property pRedBC As Decimal
    'Public Property vICMSDeson As Decimal?
    'Public Property pMVAST As Decimal?
    'Public Property vFCPSTRet As Decimal?

    Return icmsGeral.ObterICMSBasico(oCrt)
  End Function

  Private Function ObterCofinsBasico(eTipoCalculo As enOpcoes,
                                   eCST As CSTCOFINS,
                                   vBC As Decimal,
                                   pCOFINS As Decimal,
                                   vCOFINS As Decimal,
                                   qBCProd As Decimal,
                                   vAliqProd As Decimal) As COFINSBasico
    Dim cofinsGeral = New COFINSGeral()

    cofinsGeral.CST = eCST

    Select Case eTipoCalculo
      Case enOpcoes.TipoCalculoValor_Lancamento_EmValor.GetHashCode()
        cofinsGeral.vCOFINS = vBC
        cofinsGeral.qBCProd = qBCProd
        cofinsGeral.vAliqProd = vAliqProd
      Case enOpcoes.TipoCalculoValor_Lancamento_Percentual.GetHashCode()
        cofinsGeral.vBC = vBC
        cofinsGeral.pCOFINS = pCOFINS
        cofinsGeral.vCOFINS = vCOFINS
    End Select

    Return cofinsGeral.ObterCOFINSBasico()
  End Function

  Private Function ObterPisBasico(eTipoCalculo As enOpcoes,
                                eCST As CSTPIS,
                                vBC As Decimal,
                                pPIS As Decimal,
                                vPIS As Decimal,
                                qBCProd As Decimal,
                                vAliqProd As Decimal) As PISBasico
    Dim PISGeral = New PISGeral()

    PISGeral.CST = eCST

    Select Case eTipoCalculo
      Case enOpcoes.TipoCalculoValor_Lancamento_EmValor.GetHashCode()
        PISGeral.vPIS = vBC
        PISGeral.qBCProd = qBCProd
        PISGeral.vAliqProd = vAliqProd
      Case enOpcoes.TipoCalculoValor_Lancamento_Percentual.GetHashCode()
        PISGeral.vBC = vBC
        PISGeral.pPIS = pPIS
        PISGeral.vPIS = vPIS
    End Select

    Return PISGeral.ObterPISBasico()
  End Function

  Private Function ObterIPIBasico(eCST As CSTIPI,
                                vBC As Decimal,
                                pIPI As Decimal,
                                vIPI As Decimal) As IPIBasico
    Dim IPIGeral = New IPIGeral() With {
            .CST = eCST,
            .vBC = vBC,
            .pIPI = pIPI,
            .vIPI = vIPI}

    '  Public Property qUnid As Decimal?
    '  Public Property vUnid As Decimal?

    Return IPIGeral.ObterIPIBasico()
  End Function

  Private Function GetTotal(ByVal sVersao As String, ByVal produtos As List(Of det)) As total
    Dim icmsTot = New ICMSTot With {.vProd = produtos.Sum(Function(p) p.prod.vProd),
                                .vDesc = produtos.Sum(Function(p) If(p.prod.vDesc, 0)),
                                .vTotTrib = produtos.Sum(Function(p) If(p.imposto.vTotTrib, 0))}

    If sVersao = const_NFe_VersaoServico_ve310 OrElse const_NFe_VersaoServico_ve400 Then icmsTot.vICMSDeson = 0

    If sVersao = const_NFe_VersaoServico_ve400 Then
      icmsTot.vFCPUFDest = 0
      icmsTot.vICMSUFDest = 0
      icmsTot.vICMSUFRemet = 0
      icmsTot.vFCP = 0
      icmsTot.vFCPST = 0
      icmsTot.vFCPSTRet = 0
      icmsTot.vIPIDevol = 0
    End If

    For Each produto In produtos
      If produto.imposto.IPI IsNot Nothing AndAlso produto.imposto.IPI.TipoIPI.[GetType]() = GetType(IPITrib) Then icmsTot.vIPI = If(icmsTot.vIPI + (CType(produto.imposto.IPI.TipoIPI, IPITrib)).vIPI, 0)

      If produto.imposto.ICMS.TipoICMS.[GetType]() = GetType(ICMS00) Then
        icmsTot.vBC = icmsTot.vBC + (CType(produto.imposto.ICMS.TipoICMS, ICMS00)).vBC
        icmsTot.vICMS = icmsTot.vICMS + (CType(produto.imposto.ICMS.TipoICMS, ICMS00)).vICMS
      End If

      If produto.imposto.ICMS.TipoICMS.[GetType]() = GetType(ICMS20) Then
        icmsTot.vBC = icmsTot.vBC + (CType(produto.imposto.ICMS.TipoICMS, ICMS20)).vBC
        icmsTot.vICMS = icmsTot.vICMS + (CType(produto.imposto.ICMS.TipoICMS, ICMS20)).vICMS
      End If
    Next

    icmsTot.vNF = Convert.ToDecimal(icmsTot.vProd - icmsTot.vDesc - icmsTot.vICMSDeson + icmsTot.vST + icmsTot.vFCPST + icmsTot.vFrete + icmsTot.vSeg + icmsTot.vOutro + icmsTot.vII + icmsTot.vIPI + icmsTot.vIPIDevol)
    Dim t = New total With {
    .ICMSTot = icmsTot}

    Return t
  End Function

  Function rotTrocaAcento(Caract As String) As String
    Dim codiA As String
    Dim codiB As String
    Dim i As Long
    Dim p As Long

    Dim Temp As String
    Dim Ret As String

    codiA = "àáâãäèéêëìíîïòóôõöùúûüÀÁÂÃÄÈÉÊËÌÍÎÒÓÔÕÖÙÚÛÜçÇñÑ"

    'Letras correspondentes para substituição
    codiB = "aaaaaeeeeiiiiooooouuuuAAAAAEEEEIIIOOOOOUUUUcCnN"

    'Armazena em temp a string recebida
    Temp = Caract

    'Loop que irá de andará a string letra a letra
    For i = 1 To Len(Temp)
      If Mid(Temp, i, 1) = "<" Then
        Ret = Ret & "&alt;"
      ElseIf InStr("&", Mid(Temp, i, 1)) > 0 Then
        Ret = Ret & "&amp;"
      ElseIf InStr(">", Mid(Temp, i, 1)) > 0 Then
        Ret = Ret & "&gt;"
      ElseIf InStr("'", Mid(Temp, i, 1)) > 0 Then
        Ret = Ret & "&após"
      ElseIf InStr("""", Mid(Temp, i, 1)) > 0 Then
        Ret = Ret & "&quot"
      Else
        Select Case Asc(UCase(Mid(Temp, i, 1)))
          Case 32 To 93
            Ret = Ret & Mid(Temp, i, 1)
          Case Else
            p = InStr(codiA, Mid(Temp, i, 1))
            If p > 0 Then
              Ret = Ret & Mid(codiB, p, 1)
            Else
              Ret = Ret & " "
            End If
        End Select
      End If
    Next

    'Retorna a nova string
    rotTrocaAcento = Ret
  End Function
End Module

Module modFiscal_SAT
  Dim oACBrSat As ACBrSat
  Dim oCfeAtual As New ACBr.Net.Sat.CFe
  Dim oCfeCancAtual As New CFeCanc

  Private Function SAT_Inicializar() As Boolean
    Dim oData As DataTable
    Dim sSqlText As String
    Dim bRet As Boolean = False

    Try
      oACBrSat = New ACBrSat

      sSqlText = "SELECT * FROM VW_EMPRESA_ESTACAO_SAT WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & " AND NO_ESTACAO = " & FNC_QuotedStr(FNC_Computador_Nome())
      oData = DBQuery(sSqlText)

      With oACBrSat
        .PathDll = "SAT.dll"

        '0=Cdecl, 1=StdCall, 2=MFeIntegrador
        .Modelo = Val(FNC_NVL(oData.Rows(0).Item("CD_OPT_MODELO_SAT"), ACBr.Net.Sat.ModeloSat.StdCall))
        .CodigoAtivacao = FNC_NVL(oData.Rows(0).Item("CD_SAT_ATIVACAO"), "")

        'Producao = 1,Homologacao = 2
        .Configuracoes.IdeTpAmb = Val(FNC_NVL(oData.Rows(0).Item("CD_OPT_CERTIFICADO_DIGITAL_AMBIENTE"), ACBr.Net.DFe.Core.Common.DFeTipoAmbiente.Homologacao))
        .Configuracoes.IdeNumeroCaixa = FNC_NVL(oData.Rows(0).Item("NR_SAT_CAIXA"), 0)

        '.Encoding = "0"
        .Configuracoes.InfCFeVersaoDadosEnt = CDec(0.07) 'CDec(config.AppSettings.Settings.Item("VersaoCFe").Value)
        .Configuracoes.EmitCNPJ = sEMPRESA_DADOS_CNPJ
        .Configuracoes.EmitIE = sEMPRESA_DADOS_IE
        .Configuracoes.EmitIM = sEMPRESA_DADOS_IM

        'Normal = 0, SimpresNacional = 1
        .Configuracoes.EmitCRegTrib = IIf(FNC_NVL(oData.Rows(0).Item("NO_OPT_CRT_ABREVIADO"), "SimpresNacional") = "SimpresNacional", ACBr.Net.Sat.RegTrib.SimplesNacional,
                                                                                                                                      ACBr.Net.Sat.RegTrib.Normal)
        .Configuracoes.EmitIndRatISSQN = IIf(FNC_NVL(oData.Rows(0).Item("ID_OPT_RATEIO_ISSQN"), enOpcoes.SimNao_Nao) = enOpcoes.SimNao_Sim, RatIssqn.Sim, RatIssqn.Nao)
        '0 =Nenhum,1 = MicroempresaMunicipal,2 =Estimativa,3 = SociedadeProfissionais,4 =Cooperativa,5 = MEI, 6 =MEEPP
        .Configuracoes.EmitCRegTribISSQN = 0

        'S=Sim, N=Nao
        .Configuracoes.EmitIndRatISSQN = IIf(FNC_NVL(oData.Rows(0).Item("ID_OPT_RATEIO_ISSQN"), enOpcoes.SimNao_Nao.GetHashCode()) = enOpcoes.SimNao_Nao.GetHashCode(),
                                             ACBr.Net.Sat.RatIssqn.Nao, ACBr.Net.Sat.RatIssqn.Sim)
        .Configuracoes.IdeCNPJ = sEMPRESA_DADOS_CNPJ
        .SignAC = FNC_NVL(oData.Rows(0).Item("CD_SAT_ATIVACAO"), "")

        .Arquivos.SalvarEnvio = (FNC_NVL(oData.Rows(0).Item("IC_SAT_SALVAR_ENVIO"), "N") = "S")
        .Arquivos.SalvarCFe = (FNC_NVL(oData.Rows(0).Item("IC_SAT_SALVAR_CFE"), "N") = "S")
        .Arquivos.SalvarCFeCanc = (FNC_NVL(oData.Rows(0).Item("IC_SAT_SALVAR_CFECANC"), "N") = "S")
        .Arquivos.SepararPorMes = (FNC_NVL(oData.Rows(0).Item("IC_SAT_SEPARAR_DATA"), "N") = "S")
        .Arquivos.SepararPorCNPJ = (FNC_NVL(oData.Rows(0).Item("IC_SAT_SEPARAR_CNPJ"), "N") = "S")
        .Arquivos.PastaCFeCancelamento = FNC_Diretorio_Temporario("SAT_Vendas")
        .Arquivos.PastaCFeVenda = FNC_Diretorio_Temporario("SAT_Vendas")
        .Arquivos.PastaEnvio = FNC_Diretorio_Temporario("SAT")
        .Arquivos.PrefixoArqCFe = "CFe"
        .Arquivos.PrefixoArqCFeCanc = "CFeCanc"

        .Ativar()
      End With

      bRet = True
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
      bRet = False
    End Try

    Return bRet
  End Function

  Public Sub SAT_Gerar(iSQ_DOCUMENTOFISCAL As Integer)
    Dim oData_01 As DataTable
    Dim oData_02 As DataTable
    Dim sSqlText As String
    Dim bClienteNaoInformado As Boolean
    Dim iCont_01 As Integer

    Try
      If SAT_Inicializar() Then
        oCfeAtual = oACBrSat.NewCFe()
        oCfeAtual.InfCFe.Ide.NumeroCaixa = oACBrSat.Configuracoes.IdeNumeroCaixa

        sSqlText = "SELECT *" &
                   " FROM VW_DOCUMENTOFISCAL_GERAR" &
                   " WHERE SQ_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL.ToString()
        oData_01 = DBQuery(sSqlText)

        With oData_01.Rows(0)
          If FNC_NVL(.Item("IC_EXIBIR_PESSOA"), "S") = "S" Then
            If .Item("ID_OPT_FISICO_JURIDICO") = enOpcoes.FisicoJuridico_Juridico.GetHashCode() Then
              oCfeAtual.InfCFe.Dest.CPF = FNC_StrZero(FNC_SoNumero(.Item("CD_CPF_CNPJ")), 14).ToString().Trim()
            Else
              If FNC_SoNumero(.Item("CD_CPF_CNPJ")) <> "00000000000" Then
                oCfeAtual.InfCFe.Dest.CNPJ = FNC_StrZero(FNC_SoNumero(.Item("CD_CPF_CNPJ")), 11).ToString().Trim()
              Else
                bClienteNaoInformado = True
              End If
            End If

            If bClienteNaoInformado Then
              oCfeAtual.InfCFe.Dest.Nome = .Item("NO_PESSOA").ToString().Trim()
            End If
          Else
            bClienteNaoInformado = True
          End If

          If Not objDataTable_CampoVazio(.Item("ID_ENDERECO")) And
                 Not bClienteNaoInformado And
                 FNC_NVL(.Item("IC_EXIBIR_ENDERECO"), "S") = "S" Then
            '--Destinatário Endereço
            oCfeAtual.InfCFe.Entrega.XLgr = FNC_NVL(.Item("DS_PESSOA_LOGRADOURO"), " ").ToString().Trim()
            oCfeAtual.InfCFe.Entrega.Nro = FNC_Endereco_TratarNumero(.Item("NR_PESSOA_LOGRADOURO")).ToString().Trim()
            oCfeAtual.InfCFe.Entrega.XCpl = FNC_NVL(.Item("DS_PESSOA_COMPLEMENTO"), " ").ToString().Trim()
            oCfeAtual.InfCFe.Entrega.XBairro = .Item("NO_PESSOA_BAIRRO").ToString().Trim()
            oCfeAtual.InfCFe.Entrega.XMun = .Item("NO_PESSOA_CIDADE").ToString().Trim()
            oCfeAtual.InfCFe.Entrega.UF = .Item("CD_PESSOA_UF")
          End If

          Dim i = 0
          Dim totalGeral As Double = 0
          Dim totalItem As Double = 0
          Dim totalDesc As Double = 0
          Dim totalOutro As Double = 0

          Dim impest As Double = 0
          Dim impfed As Double = 0
          Dim TimpostoEst As Double = 0
          Dim TimpostoFed As Double = 0

          '-- Detalhe
          sSqlText = "SELECT * FROM VW_DOCUMENTOFISCAL_PRODUTO_GERAR" &
                     " WHERE ID_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL &
                       " AND ID_OPT_STATUS NOT IN (" & enOpcoes.StatusItemDocumentoFiscal_Cancelado.GetHashCode().ToString & ")"
          oData_02 = DBQuery(sSqlText)

          For iCont = 0 To oData_02.Rows.Count - 1
            With oData_02.Rows(iCont)
              Dim det = oCfeAtual.InfCFe.Det.AddNew()
              det.NItem = i 'Sequencia numerica para o item
              det.Prod.CProd = .Item("CD_PRODUTO")
              If FNC_NVL(oData_02.Rows(iCont).Item("IC_REGISTRADO_GTIN"), "N") = "S" Then
                det.Prod.CEAN = oData_02.Rows(iCont).Item("CD_BARRA_FABRICANTE").ToString().Trim()
              Else
                det.Prod.CEAN = const_NFe_ProdutoSemGTIN
              End If
              det.Prod.XProd = .Item("NO_PRODUTO")
              det.Prod.NCM = FNC_NVL(.Item("CD_NCM"), "")
              det.Prod.CFOP = FNC_NVL(.Item("CD_CFOP"), "")
              det.Prod.CEST = FNC_NVL(.Item("CD_CEST"), "")
              det.Prod.UCom = FNC_NVL(.Item("CD_UNIDADEMEDIDA"), "")
              det.Prod.QCom = FNC_NVL(.Item("QT_PRODUTO"), 0)
              det.Prod.VUnCom = FNC_NVL(.Item("VL_UNITARIO"), 0)
              det.Prod.VDesc = FNC_NVL(.Item("VL_DESCONTO"), 0)
              det.Prod.VOutro = FNC_NVL(.Item("VL_SEGURO"), 0) + FNC_NVL(.Item("VL_FRETE"), 0)
              det.Prod.IndRegra = IndRegra.Arredondamento

              totalDesc = totalDesc + det.Prod.VDesc
              totalOutro = totalOutro + det.Prod.VOutro

              'Dim obs = New ProdObsFisco() With {.XCampoDet = "campo", .XTextoDet = "texto"}
              'det.Prod.ObsFiscoDet.Add(obs)

              totalItem = (FNC_NVL(.Item("VL_UNITARIO"), 0) * FNC_NVL(.Item("QT_PRODUTO"), 0))

              totalGeral = totalGeral + totalItem

              impest = (totalItem / 100) * FNC_NVL(.Item("PC_ALIQUOTA_IBPT_ESTADUAL"), 0) 'calcula o imposto estadual de acordo com a tabela IBPT
              impfed = (totalItem / 100) * FNC_NVL(.Item("PC_ALIQUOTA_IBPT_NACIONAL"), 0) 'calcula o imposto federal de acordo com a tabela IBPT

              TimpostoEst += impest 'acumula imposto estadual
              TimpostoFed += impfed 'acumula imposto federal

              det.Imposto.VItem12741 = impest + impfed 'soma os dois impostos para apresentação no item

              Select Case FNC_NVL(.Item("CD_CSOSN"), "")
                Case "102", "300", "500"
                  det.Imposto.Imposto = New ImpostoIcms() With {.Icms = New ImpostoIcmsSn102() With {.Csosn = FNC_NVL(oData_02.Rows(iCont).Item("CD_CSOSN"), ""), .Orig = ACBr.Net.Sat.OrigemMercadoria.Nacional}}
                Case "900"
                  det.Imposto.Imposto = New ImpostoIcms() With {.Icms = New ImpostoIcmsSn900() With {.Csosn = FNC_NVL(oData_02.Rows(iCont).Item("CD_CSOSN"), ""), .Orig = ACBr.Net.Sat.OrigemMercadoria.Nacional, .PIcms = 18D, .VIcms = 0}}
                Case "00", "20", "90"
                  det.Imposto.Imposto = New ImpostoIcms() With {.Icms = New ImpostoIcms00() With {.Cst = FNC_NVL(oData_02.Rows(iCont).Item("CD_CSOSN"), ""), .Orig = ACBr.Net.Sat.OrigemMercadoria.Nacional, .PIcms = 18D, .VIcms = 0}}
                Case "40", "41", "50", "60"
                  det.Imposto.Imposto = New ImpostoIcms() With {.Icms = New ImpostoIcms40() With {.Cst = FNC_NVL(oData_02.Rows(iCont).Item("CD_CSOSN"), ""), .Orig = ACBr.Net.Sat.OrigemMercadoria.Nacional}}
              End Select

              Select Case FNC_NVL(.Item("CD_REF_PROJETOZEUS_CST_PIS"), "")
                Case "04", "06", "07", "08", "09"
                  det.Imposto.Pis.Pis = New ImpostoPisNt() With {.Cst = FNC_NVL(oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_PIS"), "")}
                Case "49"
                  det.Imposto.Pis.Pis = New ImpostoPisSn() With {.Cst = "49"}
                Case "99"
                  det.Imposto.Pis.Pis = New ImpostoPisOutr() With {.Cst = "99", .PPis = (FNC_NVL(oData_02.Rows(iCont).Item("VL_PIS"), 0) / 100), .QBcProd = FNC_NVL(oData_02.Rows(iCont).Item("QT_PRODUTO"), 0), .VAliqProd = (totalItem * (FNC_NVL(oData_02.Rows(iCont).Item("VL_PIS"), 0) / 100))}
                Case "03"
                  det.Imposto.Pis.Pis = New ImpostoPisQtde() With {.Cst = "03", .QBcProd = FNC_NVL(oData_02.Rows(iCont).Item("QT_PRODUTO"), 0), .VAliqProd = totalItem * (FNC_NVL(oData_02.Rows(iCont).Item("VL_PIS"), 0) / 100)}
                Case "01", "02", "05"
                  If FNC_NVL(.Item("CD_REF_PROJETOZEUS_CST_PIS"), "").Equals("01") Then
                    'Dim PisAliqEsp As Double = FNC_NVL(oData_02.Rows(iCont).Item("PC_PIS"), 0)

                    'If PisAliqEsp > 0 Then
                    '  FNC_NVL(oData_02.Rows(iCont).Item("VL_PIS"), 0) = PisAliqEsp
                    'End If
                  End If

                  det.Imposto.Pis.Pis = New ImpostoPisAliq() With {.Cst = FNC_NVL(oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_PIS"), ""), .PPis = (FNC_NVL(oData_02.Rows(iCont).Item("VL_PIS"), 0) / 100)}
                Case Else
                  det.Imposto.Pis.Pis = New ImpostoPisNt() With {.Cst = "07"} 'Excessão para não configurado
              End Select

              Select Case FNC_NVL(.Item("CD_REF_PROJETOZEUS_CST_COFINS"), "")
                Case "04", "06", "07", "08", "09"
                  det.Imposto.Cofins.Cofins = New ImpostoCofinsNt() With {.Cst = oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_COFINS")}
                Case "49"
                  det.Imposto.Cofins.Cofins = New ImpostoCofinsSn() With {.Cst = "49"}
                Case "99"
                  det.Imposto.Cofins.Cofins = New ImpostoCofinsOutr() With {.CST = "99", .PCofins = (FNC_NVL(oData_02.Rows(iCont).Item("VL_COFINS"), 0) / 100), .QBcProd = FNC_NVL(oData_02.Rows(iCont).Item("QT_PRODUTO"), 0), .VAliqProd = (totalItem * (FNC_NVL(oData_02.Rows(iCont).Item("VL_COFINS"), 0) / 100))}
                Case "03"
                  det.Imposto.Cofins.Cofins = New ImpostoCofinsQtde() With {.Cst = "03", .QBcProd = FNC_NVL(oData_02.Rows(iCont).Item("QT_PRODUTO"), 0), .VAliqProd = 0}
                Case "01", "02", "05"
                  If .Item("CD_REF_PROJETOZEUS_CST_COFINS").Equals("01") Then
                    'Dim CofinsAliqEsp = EmpresaBll.GetEmpresa.cofins_alq_esp

                    'If CofinsAliqEsp > 0 Then
                    '  FNC_NVL(oData_02.Rows(iCont).Item("VL_COFINS"), 0) = CofinsAliqEsp
                    'End If
                  End If
                  det.Imposto.Cofins.Cofins = New ImpostoCofinsAliq() With {.Cst = oData_02.Rows(iCont).Item("CD_REF_PROJETOZEUS_CST_COFINS"), .PCofins = (FNC_NVL(oData_02.Rows(iCont).Item("VL_COFINS"), 0) / 100)}
                Case Else
                  det.Imposto.Cofins.Cofins = New ImpostoCofinsNt() With {.Cst = "07"} 'Excessão para não configurado
              End Select
            End With
          Next

          oCfeAtual.InfCFe.Total.VCFeLei12741 = TimpostoEst + TimpostoFed

          sSqlText = "SELECT PEDPG.ID_FORMAPAGAMENTO, PEDPG.VL_PAGAMENTO" +
                       " FROM TB_DOCUMENTOFISCAL DCFSC" +
                        " INNER JOIN TB_PEDIDO_PAGAMENTO PEDPG ON PEDPG.SQ_PEDIDO_PAGAMENTO = DCFSC.ID_PEDIDO_PAGAMENTO" +
                       " WHERE DCFSC.SQ_DOCUMENTOFISCAL = " + iSQ_DOCUMENTOFISCAL.ToString()
          oData_02 = DBQuery(sSqlText)

          For iCont_01 = 0 To oData_02.Rows.Count - 1
            '0 01 - Dinheiro
            '1 02 - Cheque
            '2 03 - Cartão de Crédito
            '3 04 - Cartão de Débito
            '4 05 - Crédito Loja
            '5 10 - Vale Alimentação
            '6 11 - Vale Refeição
            '7 12 - Vale Presente
            '8 13 - Vale Combustível
            '9 99 - Outros

            Dim pgto = oCfeAtual.InfCFe.Pagto.Pagamentos.AddNew()

            Select Case FNC_NVL(.Item("ID_FORMAPAGAMENTO"), 0)
              Case const_FormaPagamento_Dinheiro
                pgto.CMp = CodigoMP.Dinheiro
              Case const_FormaPagamento_Cheque
                pgto.CMp = CodigoMP.Cheque
              Case const_FormaPagamento_CartaoCredito
                pgto.CMp = CodigoMP.CartaodeCredito
              Case const_FormaPagamento_CartaoDebito
                pgto.CMp = CodigoMP.CartaodeDebito
              Case "5"
                pgto.CMp = CodigoMP.CreditoLoja
              Case "10"
                pgto.CMp = CodigoMP.ValeAlimentacao
              Case "11"
                pgto.CMp = CodigoMP.ValeRefeicao
              Case "12"
                pgto.CMp = CodigoMP.ValePresente
              Case "13"
                pgto.CMp = CodigoMP.ValeCombustivel
              Case Else
                pgto.CMp = CodigoMP.Outros

            End Select

            pgto.VMp = FNC_NVL(.Item("VL_PAGAMENTO"), 0)

            'If cxmovimento.valor_desconto > 0 Then oCfeAtual.InfCFe.Total.DescAcrEntr.VDescSubtot += cxmovimento.valor_desconto
            'If cxmovimento.valor_adicional > 0 Then oCfeAtual.InfCFe.Total.DescAcrEntr.VAcresSubtot += cxmovimento.valor_adicional

            'pgto.CAdmC = 999 'codigo da administradora do cartão
          Next

          'Calculo para retirar o valor de desconto por item do desconto no total da venda
          Dim DescProduto = oCfeAtual.InfCFe.Det.Sum(Function(c) c.Prod.VDesc)
          Dim AcresProduto = oCfeAtual.InfCFe.Det.Sum(Function(c) c.Prod.VOutro)

          If DescProduto > 0 Then oCfeAtual.InfCFe.Total.DescAcrEntr.VDescSubtot -= DescProduto
          If AcresProduto > 0 Then oCfeAtual.InfCFe.Total.DescAcrEntr.VAcresSubtot -= AcresProduto

          oCfeAtual.InfCFe.InfAdic.InfCpl = "Federal " & FormatCurrency(TimpostoFed) & " Estadual " & FormatCurrency(TimpostoEst) & "|[Operador: " & sNO_USUARIO_RESUMIDO & "] [Cx: " & oCfeAtual.InfCFe.Ide.NumeroCaixa & "]"
        End With
      End If
    Catch ex As Exception
    End Try
  End Sub
End Module