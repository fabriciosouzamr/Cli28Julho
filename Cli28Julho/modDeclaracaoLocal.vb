Public Class modDeclaracaoLocal
  '>>> CLASSES <<<
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

  Public Class cCadastroAtendimentoFaturamento_Item
    Public SQ_CLINICA_VENDA_PROCEDIMENTO As Integer
    Public CD_CLINICA_VENDA As String
    Public DT_VENCIMENTO As Date
    Public NO_PESSOA_PROFISSIONAL As String
    Public NO_PESSOA As String
    Public NO_PROCEDIMENTO As String
    Public VL_PROCEDIMENTO As Double
    Public VL_REPASSE As Double
  End Class

  Public Class cSolicitacaoExameCitologico
    Public sDS_MEDICO_EXTERNO As String
    Public sDS_COLETA As String
    Public sDS_UM As String
    Public sDS_FILHOS As String
    Public sDS_ABORTO As String
    Public sDS_PARA As String
    Public sDS_LOCAL_COLETA As String
    Public sDS_ACHADOS_COLPOSCOPICOS As String
    Public sIC_DIU As String
  End Class

  Public Class Integracao
    Public SQ_INTEGRACAO As Integer
    Public NO_INTEGRACAO As String
    Public DS_LINK As String
    Public CD_CHAVE_01 As String
    Public CD_CHAVE_02 As String
    Public CD_CHAVE_03 As String
    Public CD_CHAVE_04 As String
    Public CD_CHAVE_05 As String
    Public TP_ATIVO As Boolean
  End Class

  Public Enum enCadastroVenda_Fechamento
    eAprovacao = 1
    eFinanceiro = 2
  End Enum

  Public Enum enIntegracao
    eSisVida = 1
  End Enum
End Class
