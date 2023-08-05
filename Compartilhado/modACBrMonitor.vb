Imports System
Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports Microsoft.VisualBasic
Imports Tulpep.NotificationWindow

Module modACBrMonitor
  Public ACBrMonitor_sPathInstalacao As String = "C:\ACBrMonitorPLUS\"
  Public ACBrMonitor_sPathConfigECF As String = "C:\ACBrMonitorPLUS\ACBrECF001.INI"

  Public Class clsACBrMonitor
    Class csACBr_ECF_Equipamento_DadosUltimaReducaoZ
      Public Carregado As Boolean = False
      Public ECF_TextoCompleto As String
      Public ECF_DataMovimento As Date
      Public ECF_NumSerie As String
      Public ECF_NumLoja As String
      Public ECF_NumECF As String
      Public ECF_NumCOO As String
      Public ECF_NumCRZ As String
      Public ECF_NumCRO As String
      Public ECF_NaoFiscais_SA_Sangria As Double
      Public ECF_NaoFiscais_SU_Suprimento As Double
      Public ECF_Totalizadores_TotalDescontos As Double
      Public ECF_Totalizadores_TotalCancelamentos As Double
      Public ECF_Totalizadores_TotalAcrescimos As Double
      Public ECF_Totalizadores_TotalNaoFiscal As Double
      Public ECF_Totalizadores_VendaBruta As Double
      Public ECF_Totalizadores_GrandeTotal As Double
    End Class

    Public Enum enACBr_ECF_Equipamento_Status
      estNaoInicializada = 1
      estDesconhecido = 2
      estLivre = 3
      estVenda = 4
      estPagamento = 5
      estRelatorio = 6
      estBloqueada = 7
      estRequerZ = 8
      estRequerX = 9
    End Enum

    Enum enECF_Tipo
      eNCFe = 1
      eECF = 2
      eNaoFiscal = 3
    End Enum

    Enum enACBr_TipoRetorno
      eTP_ECF_Cupom_NaoDefinido = 0
      eTP_ECF_Cupom_NumeroCupom = 1
      eTP_ECF_Cupom_NumeroSerie = 2
      eTP_ECF_Equipamento_Status = 3
      eTP_ECF_Equipamento_DadosUltimaReducaoZ = 4
      eTP_ECF_Equipamento_CancelarUltimoCupom = 5
      eTP_ECF_Equipamento_TestaPodeAbrirCupom = 6
    End Enum

    Const cons_ACBr_ECF_Equipamento_Status_estNaoInicializada As String = "estNaoInicializada"          'Porta Serial ainda não foi aberta
    Const cons_ACBr_ECF_Equipamento_Status_estDesconhecido As String = "estDesconhecido"                'Porta aberta, mas estado ainda não definido
    Const cons_ACBr_ECF_Equipamento_Status_estLivre As String = "estLivre"                              'Impressora Livre, sem nenhum cupom aberto pronta para nova venda, Redução Z e Leitura X ok, pode ou não já ter ocorrido 1ª venda no dia...;"
    Const cons_ACBr_ECF_Equipamento_Status_estVenda As String = "estVenda"                              'Cupom de Venda Aberto com ou sem venda do 1º Item;"
    Const cons_ACBr_ECF_Equipamento_Status_estPagamento As String = "estPagamento"                      'Iniciado Fechamento de Cupom com Formas Pagamento pode ou não ter efetuado o 1º pagamento. Não pode mais vender itens, ou alterar Sub-total;"
    Const cons_ACBr_ECF_Equipamento_Status_estRelatorio As String = "estRelatorio"                      'Imprimindo Cupom Fiscal Vinculado ou Relatório Gerencial;"
    Const cons_ACBr_ECF_Equipamento_Status_estBloqueada As String = "estBloqueada"                      'Redução Z já emitida, bloqueada até as 00:00;"
    Const cons_ACBr_ECF_Equipamento_Status_estRequerZ As String = "estRequerZ"                          'Redução Z do dia anterior ainda não foi emitida. Emitir agora;"
    Const cons_ACBr_ECF_Equipamento_Status_estRequerX As String = "estRequerX"                          'Esta impressora requer Leitura X todo inicio de dia. É necessário imprimir uma Leitura X para poder vender"

    Public Event Mensagem(sMensagem As Object)

    Dim WithEvents oACBr As New AcbrMonitor_TCP.ConexaoTCP

    Dim Controle_TipoRetorno As enACBr_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Cupom_NaoDefinido

    Public oStatus As Object

    Public Controle_oRetorno As Object = Nothing
    Public Controle_sIP As String = "192.168.100.156" '"10.22.1.107"
    Public Controle_iPorta As Integer = 3436

    Public ECF_Tipo As enECF_Tipo = enECF_Tipo.eNaoFiscal
    Public ECF_Cupom_NumeroCupom As String
    Public ECF_NumeroSerie As String
    Public ECF_FormasPagamento As Collection

    Public ECF_Equipamento_DadosUltimaReducaoZ As New csACBr_ECF_Equipamento_DadosUltimaReducaoZ
    Public ECF_Equipamento_PodeAbrirCupom As Boolean = False

    Dim sECF_Equipamento_Status As String

    Dim oFormMensagem_Mensagem As New Collection
    Dim bHouveRetorno As Boolean

    '>> Funções Gerais
    Public Function Controle_Abrir() As Boolean
      Try
        oACBr.Conectar(Controle_sIP, Controle_iPorta)

        oFormMensagem_Mensagem.Clear()

        Return True
      Catch ex As Exception
        FNC_Mensagem(ex.Message)
        Return False
      End Try
    End Function

    Public Sub Controle_Fechar()
      oACBr.Desconectar()
    End Sub

    Public Function Controle_Enviar(sComando As String, Optional bEsperarRetorno As Boolean = False)
      Dim oRet As Object = Nothing
      Dim iCont As Integer

      bHouveRetorno = False

      oACBr.Enviar(sComando)

      If bEsperarRetorno Then
        For iCont = 0 To 1000
          Application.DoEvents()
          Application.DoEvents()
          Application.DoEvents()
          Application.DoEvents()

          If bHouveRetorno Then
            Exit For
          ElseIf icont > 1000 Then
            FNC_Mensagem("Houve um erro na espera de retorno do ACBr Monitor")
          End If

          iCont = iCont + 1
        Next

      End If

      bHouveRetorno = False

      Return oRet
    End Function
    '>> Funções Gerais

    '>> ECF
    Public Sub ECF_Equipamento_Ativar()
      Controle_Enviar("ECF.Ativar", True)

      Controle_Enviar("ECF.IdentificaOperador(" + FNC_AspasDupla(sNO_USUARIO_RESUMIDO) + ")")

      'ECF_Equipamento_TestaPodeAbrirCupom()

      Controle_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Cupom_NumeroSerie
      Controle_Enviar("ECF.NumSerie", True)
    End Sub

    Public Sub ECF_Equipamento_Desativar()
      Controle_Enviar("ECF.Desativar")
    End Sub

    Public Sub ECF_Equipamento_ReducaoZ(dData As Date)
      Dim sData As String

      sData = FNC_StrZero(dData.Day, 2) + "/" + FNC_StrZero(dData.Month, 2) + "/" + FNC_StrZero(dData.Year, 4) + " " +
              FNC_StrZero(dData.Hour, 2) + ":" + FNC_StrZero(dData.Minute, 2)

      Controle_Enviar("ECF.ReducaoZ(" + FNC_AspasDupla(sData) + ")", True)
    End Sub

    Public Sub ECF_Equipamento_CancelarUltimoCopum()
      Controle_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Cupom_NaoDefinido
      Controle_Enviar("ECF.CancelaCupom", True)
    End Sub

    Public Sub ECF_Equipamento_TestaPodeAbrirCupom()
      Controle_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Equipamento_TestaPodeAbrirCupom
      Controle_Enviar("ECF.TestaPodeAbrirCupom", True)
    End Sub

    Public Sub ECF_Equipamento_DadosUltimaReducaoZ_Carregar()
      Controle_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Equipamento_DadosUltimaReducaoZ
      Controle_Enviar("ECF.DadosUltimaReducaoZ", True)
    End Sub

    Public Sub ECF_Equipamento_Status_Verificar()
      Controle_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Equipamento_Status
      FNC_Pausa()
      Dim oRet = Controle_Enviar("ECF.Estado", True)
    End Sub

    Public Function ECF_Equipamento_Status() As enACBr_ECF_Equipamento_Status
      If Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estNaoInicializada) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estNaoInicializada
      ElseIf Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estDesconhecido) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estDesconhecido
      ElseIf Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estLivre) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estLivre
      ElseIf Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estVenda) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estVenda
      ElseIf Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estPagamento) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estPagamento
      ElseIf Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estRelatorio) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estRelatorio
      ElseIf Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estBloqueada) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estBloqueada
      ElseIf Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estRequerZ) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estRequerZ
      ElseIf Microsoft.VisualBasic.Strings.InStr(sECF_Equipamento_Status, cons_ACBr_ECF_Equipamento_Status_estRequerX) > 0 Then
        Return enACBr_ECF_Equipamento_Status.estRequerX
      Else
        Return enACBr_ECF_Equipamento_Status.estDesconhecido
      End If
    End Function

    Public Sub ECF_Equipamento_LeituraX()

    End Sub

    Public Sub ECF_Cupom_Abrir(Optional Cliente_sCNPF As String = "",
                               Optional Cliente_sNome As String = "",
                               Optional Cliente_sEndereco As String = "")
      If Cliente_sCNPF.Trim() = "" And Cliente_sNome.Trim() = "" And Cliente_sEndereco.Trim() = "" Then
        Controle_Enviar("ECF.AbreCupom", True)
      Else
        Controle_Enviar("ECF.AbreCupom(" + FNC_AspasDupla(Cliente_sCNPF) + "," + FNC_AspasDupla(Cliente_sNome) + "," + FNC_AspasDupla(Cliente_sEndereco) + ")", True)
      End If

      ECF_Cupom_NumeroCupom_Verificar()
    End Sub

    Public Sub ECF_Cupom_NumeroCupom_Verificar()
      Controle_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Cupom_NumeroCupom
      Controle_Enviar("ECF.NumCupom", True)
    End Sub


    Public Sub ECF_Cupom_NumeroCOO_Verificar()
      Controle_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Cupom_NumeroCupom
      Controle_Enviar("ECF.NumCOO", True)
    End Sub
    Public Sub ECF_Cupom_Item(Item_sCodigo As String,
                              Item_sDescricao As String,
                              Item_sAliquotaICMS As String,
                              Item_dQtd As Double,
                              Item_dValorUnitario As Double,
                              Optional Item_dValorDescontoAcrescimo As Double = 0,
                              Optional Item_sUnidade As String = "",
                              Optional Item_sTipoDescontoAcrescimo As String = "",
                              Optional Item_sDescontoAcrescimo As String = "",
                              Optional Item_dCodDepartamento As Double = 0)

      Dim sComando As String = "ECF.VendeItem(" + FNC_AspasDupla(Item_sCodigo) + "," + FNC_AspasDupla(Item_sDescricao) + "," + Item_sAliquotaICMS + "," _
                                                + FNC_ValorPraTexto(Item_dQtd) + ", " + FNC_ValorPraTexto(Item_dValorUnitario) _
                                                + IIf(Item_dValorDescontoAcrescimo = 0, "", "," + FNC_ValorPraTexto(Item_dValorDescontoAcrescimo)) _
                                                + IIf(Item_sUnidade = "", "", ",'" + Item_sUnidade + "'") _
                                                + IIf(Item_sTipoDescontoAcrescimo = "", "", ",'" + Item_sTipoDescontoAcrescimo + "'") _
                                                + IIf(Item_sDescontoAcrescimo = "", "", ",'" + Item_sDescontoAcrescimo + "'") _
                                                + IIf(Item_dCodDepartamento = 0, "", "," + FNC_ValorPraTexto(Item_dCodDepartamento)) + ")"

      Controle_Enviar(sComando, True)
    End Sub

    Public Sub ECF_Cupom_SubTotalizar(dDesconto_Acrescimento As Double,
                                      Optional sMensagem01 As String = "",
                                      Optional sMensagem02 As String = "")
      Controle_Enviar("ECF.SubtotalizaCupom(" + FNC_ValorPraTexto(dDesconto_Acrescimento) _
                                              + IIf(sMensagem01.Trim() = "", "", FNC_AspasDupla(sMensagem01 + IIf(sMensagem02.Trim() = "", "", "|" + sMensagem02))) + ")", True)
    End Sub

    Public Sub ECF_Cupom_EfetuaPagamento(sCodFormaPagto As String,
                                         dValor As Double,
                                         Optional sObservacao As String = "",
                                         Optional bImprimeVinculado As Boolean = False)
      Controle_Enviar("ECF.EfetuaPagamento( " + FNC_AspasDupla(sCodFormaPagto) + "," + FNC_ValorPraTexto(dValor) + IIf(sObservacao.Trim() = "", "", FNC_AspasDupla(sObservacao)) + ")", True)
    End Sub

    Public Sub ECF_Cupom_FecharCupom(Optional sMensagem01 As String = "",
                                     Optional sMensagem02 As String = "")
      Controle_Enviar("ECF.FechaCupom(" + IIf(sMensagem01.Trim() = "", "", FNC_AspasDupla(sMensagem01 + IIf(sMensagem02.Trim() = "", "", "|" + sMensagem02))) + ")", True)
    End Sub

    Public Sub ECF_FormaPagamento(iIndice As Integer, ByRef sCodigo As String, ByRef sNome As String)
      Try
        sCodigo = ECF_FormasPagamento(iIndice)(0)
        sNome = ECF_FormasPagamento(iIndice)(1)
      Catch ex As Exception
        sCodigo = ""
        sNome = ""
      End Try
    End Sub

    Public Sub ECF_FormasPagamento_Carregar()
      Dim iCont As Integer = 0

      ECF_FormasPagamento = New Collection

      Do While True
        If Int(FNC_ArquivoINI_Ler(ACBrMonitor_sPathConfigECF, "Forma_Pagamento" + FNC_StrZero(iCont, 2), "Indice", "0")) = 0 Then
          Exit Do
        Else
          ECF_FormasPagamento.Add(New String() {FNC_ArquivoINI_Ler(ACBrMonitor_sPathConfigECF, "Forma_Pagamento" + FNC_StrZero(iCont, 2), "Indice", "0"),
                                                FNC_ArquivoINI_Ler(ACBrMonitor_sPathConfigECF, "Forma_Pagamento" + FNC_StrZero(iCont, 2), "Descricao", "0")})
        End If

        iCont = iCont + 1
      Loop
    End Sub
    '>> ECF

    Protected Overrides Sub Finalize()
      Controle_Fechar()
      oACBr.Dispose()
      oACBr = Nothing

      MyBase.Finalize()
    End Sub

    Private Sub oACBr_LerRetorno(sender As Object, e As AcbrMonitor_TCP.ConexaoTCP.LerRetornoEventArgs) Handles oACBr.LerRetorno
      bHouveRetorno = True

      Select Case Controle_TipoRetorno
        Case enACBr_TipoRetorno.eTP_ECF_Cupom_NaoDefinido
          Controle_oRetorno = e.Retorno

          RaiseEvent Mensagem(Controle_oRetorno)
        Case enACBr_TipoRetorno.eTP_ECF_Cupom_NumeroCupom
          ECF_Cupom_NumeroCupom = Mid(e.Retorno, 4).Trim()
        Case enACBr_TipoRetorno.eTP_ECF_Equipamento_Status
          sECF_Equipamento_Status = Mid(e.Retorno, 4).Trim()
        Case enACBr_TipoRetorno.eTP_ECF_Equipamento_TestaPodeAbrirCupom
          ECF_Equipamento_PodeAbrirCupom = Mid(e.Retorno, 4).Trim().ToUpper() = "OK"
        Case enACBr_TipoRetorno.eTP_ECF_Equipamento_DadosUltimaReducaoZ
          Dim sTemp As String = FNC_Diretorio_Temporario() & "ACBrTemp_" & Now.ToString() & ".ini"

          FNC_ArquivoINIFromString_Criar(sTemp, Mid(e.Retorno, 4).Trim())

          With ECF_Equipamento_DadosUltimaReducaoZ
            .ECF_TextoCompleto = Mid(e.Retorno, 4).Trim()
            .ECF_DataMovimento = FNC_ArquivoINI_Ler(sTemp, "ECF", "DataMovimento", Now.Date.ToString())
            .ECF_NumSerie = FNC_ArquivoINI_Ler(sTemp, "ECF", "NumSerie", "")
            .ECF_NumLoja = FNC_ArquivoINI_Ler(sTemp, "ECF", "NumLoja", "")
            .ECF_NumECF = FNC_ArquivoINI_Ler(sTemp, "ECF", "NumECF", "")
            .ECF_NumCOO = FNC_ArquivoINI_Ler(sTemp, "ECF", "NumCOO", "")
            .ECF_NumCRZ = FNC_ArquivoINI_Ler(sTemp, "ECF", "NumCRZ", "")
            .ECF_NumCRO = FNC_ArquivoINI_Ler(sTemp, "ECF", "NumCRO", "")
            .ECF_NaoFiscais_SA_Sangria = FNC_ConvValorFormatoAmericano(FNC_ArquivoINI_Ler(sTemp, "NaoFiscais", "SA_Sangria", "0"))
            .ECF_NaoFiscais_SU_Suprimento = FNC_ConvValorFormatoAmericano(FNC_ArquivoINI_Ler(sTemp, "NaoFiscais", "SU_Suprimento", "0"))
            .ECF_Totalizadores_TotalDescontos = FNC_ConvValorFormatoAmericano(FNC_ArquivoINI_Ler(sTemp, "Totalizadores", "TotalDescontos", "0"))
            .ECF_Totalizadores_TotalCancelamentos = FNC_ConvValorFormatoAmericano(FNC_ArquivoINI_Ler(sTemp, "Totalizadores", "TotalCancelamentos", "0"))
            .ECF_Totalizadores_TotalAcrescimos = FNC_ConvValorFormatoAmericano(FNC_ArquivoINI_Ler(sTemp, "Totalizadores", "TotalAcrescimos", "0"))
            .ECF_Totalizadores_TotalNaoFiscal = FNC_ConvValorFormatoAmericano(FNC_ArquivoINI_Ler(sTemp, "Totalizadores", "TotalNaoFiscal", "0"))
            .ECF_Totalizadores_VendaBruta = FNC_ConvValorFormatoAmericano(FNC_ArquivoINI_Ler(sTemp, "Totalizadores", "VendaBruta", "0"))
            .ECF_Totalizadores_GrandeTotal = FNC_ConvValorFormatoAmericano(FNC_ArquivoINI_Ler(sTemp, "Totalizadores", "GrandeTotal", "0"))
          End With
      End Select

      Controle_TipoRetorno = enACBr_TipoRetorno.eTP_ECF_Cupom_NaoDefinido
    End Sub
  End Class

  Class TCPCliente
    Dim tcpClient As New System.Net.Sockets.TcpClient

    Public Sub Conectar()
      Try
        tcpClient.Connect("110.22.1.107", 3436)
        Dim networkStream As NetworkStream = tcpClient.GetStream()
      Catch ex As Exception
        FNC_Mensagem(ex.Message)
      End Try
    End Sub

    Public Sub Desconectar()
      Try
        tcpClient.Close()
      Catch ex As Exception
        FNC_Mensagem(ex.Message)
      End Try
    End Sub

    Public Function Perguntar(sPergunta As String) As String
      Dim networkStream As NetworkStream = tcpClient.GetStream()

      If networkStream.CanWrite And networkStream.CanRead Then
        ' executa apenas uma escrita
        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(sPergunta)
        networkStream.Write(sendBytes, 0, sendBytes.Length)

        ' Le o NetworkStream em um buffer
        Dim bytes(tcpClient.ReceiveBufferSize) As Byte
        networkStream.Read(bytes, 0, CInt(tcpClient.ReceiveBufferSize))

        ' exibe os dados recebidos do host no console
        Dim returndata As String = Encoding.ASCII.GetString(bytes)

        Return returndata
      Else
        If Not networkStream.CanRead Then
          FNC_Mensagem("Não é possível enviar dados para este stream")
          tcpClient.Close()
        Else
          If Not networkStream.CanWrite Then
            FNC_Mensagem("Não é possivel ler dados deste stream")
            tcpClient.Close()
          End If
        End If
      End If
      ' da uma pausa para pode ver o resultado
      Console.ReadLine()
    End Function
  End Class
End Module