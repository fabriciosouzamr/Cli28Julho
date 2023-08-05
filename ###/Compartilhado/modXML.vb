Imports System.Xml

'Class clsXML1
'  Public oXML As New XmlDocument
'  Public oNFe As cNFe
'  Public sArquivo As String

'  Dim bCarregado As Boolean

'  Public Function AbrirArquivo(Optional sArquivoXML As String = "") As Boolean
'    Dim bOk As Boolean = False

'    Try
'      If Trim(sArquivoXML) = "" Then
'        sArquivoXML = FNC_Arquivo_Dialogo_Abrir(enTipoArquivo.eXML)

'        If Trim(sArquivoXML) = "" Then GoTo Sair
'      Else
'        If Dir(sArquivoXML) = "" Then
'          FNC_Mensagem("Arquivo XML inexistente")
'          GoTo Sair
'        End If
'      End If

'      sArquivo = sArquivoXML

'      oXML = New XmlDocument
'      oXML.Load(sArquivoXML)
'    Catch ex As Exception
'      FNC_Mensagem(ex.Message)
'      GoTo Sair
'    End Try

'    bOk = True

'Sair:
'    Return bOk
'  End Function

'  Public Function Carregar(Optional sXML As String = "") As Boolean
'    Dim bOk As Boolean = False

'    Try
'      oXML = New XmlDocument
'      oXML.LoadXml(sXML)
'    Catch ex As Exception
'      FNC_Mensagem(ex.Message)
'      GoTo Sair
'    End Try

'    bOk = True

'Sair:
'    Return bOk
'  End Function

'  Public Sub FecharArquivo()
'    oXML = Nothing
'    bCarregado = False
'  End Sub

'  Public ReadOnly Property Nfe() As Boolean
'    Get
'      Return (oXML.FirstChild.Name = "nfeProc")
'    End Get
'  End Property

'  Public ReadOnly Property Nfe_Versao() As enNFe_Versao
'    Get
'      Select Case oXML.FirstChild.Attributes("versao").Value
'        Case "2.00"
'          Return enNFe_Versao.e2_00
'        Case "3.10"
'          Return enNFe_Versao.e3_10
'        Case Else
'          Return Nothing
'      End Select
'    End Get
'  End Property

'  Public Function LerNFe() As Boolean
'    bCarregado = False

'    If XML_Elemento_Item("ide", "tpAmb") <> "1" Then
'      FNC_Mensagem("Essa NFe não foi gerada em um ambiente de produção")
'      GoTo Erro
'    End If

'    Dim iCont As Integer
'    Dim oProd As cNfe_Produto
'    Dim oDup As cNfe_Duplicata

'    oNFe = New cNFe

'    With oNFe
'      .XML = sArquivo
'      .NaturezaOperacao = XML_Elemento_Item("ide", "natOp")
'      .FormaPagamento = XML_Elemento_Item("ide", "indPag")
'      .Modelo = XML_Elemento_Item("ide", "mod")
'      .Serie = XML_Elemento_Item("ide", "serie")
'      .NrNF = XML_Elemento_Item("ide", "nNF")
'      .DataHora_Emissao = FNC_Data_TratarAAAAMMDD(XML_Elemento_Item("ide", New String() {"dEmi", "dhEmi"}))
'      .DataHora_EntradaSaida = FNC_Data_TratarAAAAMMDD(XML_Elemento_Item("ide", New String() {"dSaiEnt", "dhSaiEnt"}))
'      .TipoOperacao = XML_Elemento_Item("ide", "tpNF")
'      .LocalDestino = XML_Elemento_Item("ide", "idDest")
'      .IBGE_Municipio = XML_Elemento_Item("ide", "cMunFG")
'      .FormatoImpressaoDanfe = XML_Elemento_Item("ide", "tpImp")
'      .FormatoEmissao = XML_Elemento_Item("ide", "tpEmis")
'      .FinalidadeEmissaoNFe = XML_Elemento_Item("ide", "finNFe")
'      .IndOperConsFinal = XML_Elemento_Item("ide", "indFinal")
'      .CompradorPresente = XML_Elemento_Item("ide", "indPres")
'      .ProcessoEmissaoNFe = XML_Elemento_Item("ide", "procEmi")
'      .Emissor = XML_Elemento_Item("ide", "verProc")
'      .DataHoraContigencia = FNC_Data_TratarAAAAMMDD(XML_Elemento_Item("ide", "dhCont"))
'      .JustificativaContigencia = XML_Elemento_Item("ide", "xJust")
'      .Emit_CPF_CNPJ = XML_Elemento_Item("emit", New String() {"CNPJ", "CPF"})
'      .Emit_Nome = XML_Elemento_Item("emit", "xNome")
'      .Emit_NomeFantasia = XML_Elemento_Item("emit", "xFant")
'      .Emit_IM = XML_Elemento_Item("emit", "IM")
'      .Emit_CNAE = XML_Elemento_Item("emit", "CNAE")
'      .Emit_IE = XML_Elemento_Item("emit", "IE")
'      .Emit_IEST = XML_Elemento_Item("emit", "IEST")
'      .Emit_RegimeTributario = XML_Elemento_Item("emit", "CRT")
'      .Emit_End_Logradouro = XML_Elemento_Item("enderEmit", "xLgr")
'      .Emit_End_Numero = XML_Elemento_Item("enderEmit", "nro")
'      .Emit_End_Complemento = XML_Elemento_Item("enderEmit", "xCpl")
'      .Emit_End_Bairro = XML_Elemento_Item("enderEmit", "xBairro")
'      .Emit_End_IBGE_Municipio = XML_Elemento_Item("enderEmit", "cMun")
'      .Emit_End_Codigo_UF = XML_Elemento_Item("enderEmit", "UF")
'      .Emit_End_CEP = XML_Elemento_Item("enderEmit", "CEP")
'      .Emit_End_Fone = XML_Elemento_Item("enderEmit", "fone")
'      .Dest_CPF_CNPJ = XML_Elemento_Item("dest", New String() {"CNPJ", "CPF"})
'      .Dest_Nome = XML_Elemento_Item("dest", "xNome")
'      .Dest_DocEstrageiro = XML_Elemento_Item("dest", "idEstrangeiro")
'      .Dest_IndicadorIE = XML_Elemento_Item("dest", "indIEDest")
'      .Dest_IE = XML_Elemento_Item("dest", "IE")
'      .ISuframa = XML_Elemento_Item("dest", "ISUF")
'      .Dest_IM = XML_Elemento_Item("dest", "IM")
'      .Dest_EMail = XML_Elemento_Item("dest", "email")
'      .Dest_End_Logradouro = XML_Elemento_Item("enderDest", "xLgr")
'      .Dest_End_Numero = XML_Elemento_Item("enderDest", "nro")
'      .Dest_End_Complemento = XML_Elemento_Item("enderDest", "xCpl")
'      .Dest_End_Bairro = XML_Elemento_Item("enderDest", "xBairro")
'      .Dest_End_IBGE_Municipio = XML_Elemento_Item("enderDest", "cMun")
'      .Dest_End_Codigo_UF = XML_Elemento_Item("enderDest", "UF")
'      .Dest_End_CEP = XML_Elemento_Item("enderDest", "CEP")
'      .Dest_End_Fone = XML_Elemento_Item("enderDest", "fone")
'      .EndRetirada_CNPJ = XML_Elemento_Item("retirada", New String() {"CNPJ", "CPF"})
'      .EndRetirada_Logradouro = XML_Elemento_Item("retirada", "xLgr")
'      .EndRetirada_Numero = XML_Elemento_Item("retirada", "nro")
'      .EndRetirada_Complemento = XML_Elemento_Item("retirada", "xCpl")
'      .EndRetirada_Bairro = XML_Elemento_Item("retirada", "xBairro")
'      .EndRetirada_IBGE_Municio = XML_Elemento_Item("retirada", "cMun")
'      .EndRetirada_Codigo_UF = XML_Elemento_Item("retirada", "UF")
'      .EndEntrega_CPF_CNPJ = XML_Elemento_Item("entrega", New String() {"CNPJ", "CPF"})
'      .EndEntrega_Logradouro = XML_Elemento_Item("entrega", "xLgr")
'      .EndEntrega_Numero = XML_Elemento_Item("entrega", "nro")
'      .EndEntrega_Complemento = XML_Elemento_Item("entrega", "xCpl")
'      .EndEntrega_Bairro = XML_Elemento_Item("entrega", "xBairro")
'      .EndEntrega_IBGE_Municio = XML_Elemento_Item("entrega", "cMun")
'      .EndEntrega_Codigo_UF = XML_Elemento_Item("entrega", "UF")
'      .VlTotal_BaseCalcICMS = Val(XML_Elemento_Item("ICMSTot", "vBC"))
'      .VlTotal_ValorICMS = Val(XML_Elemento_Item("ICMSTot", "vICMS"))
'      .VlTotal_ValorICMSDesc = Val(XML_Elemento_Item("ICMSTot", "vICMSDeson"))
'      .VlTotal_BaseCalcICMSST = Val(XML_Elemento_Item("ICMSTot", "vBCST"))
'      .VlTotal_ValorICMSST = Val(XML_Elemento_Item("ICMSTot", "vST"))
'      .VlTotal_ValorProduto = Val(XML_Elemento_Item("ICMSTot", "vProd"))
'      .VlTotal_ValorFrete = Val(XML_Elemento_Item("ICMSTot", "vFrete"))
'      .VlTotal_ValorSeguro = Val(XML_Elemento_Item("ICMSTot", "vSeg"))
'      .VlTotal_ValorDesconto = Val(XML_Elemento_Item("ICMSTot", "vDesc"))
'      .VlTotal_ValorII = Val(XML_Elemento_Item("ICMSTot", "vII"))
'      .VlTotal_ValorIPI = Val(XML_Elemento_Item("ICMSTot", "vIPI"))
'      .VlTotal_ValorPIS = Val(XML_Elemento_Item("ICMSTot", "vPIS"))
'      .VlTotal_ValorCofins = Val(XML_Elemento_Item("ICMSTot", "vCOFINS"))
'      .VlTotal_ValorOutrasDesp = Val(XML_Elemento_Item("ICMSTot", "vOutro"))
'      .VlTotal_ValorNF = Val(XML_Elemento_Item("ICMSTot", "vNF"))
'      .Transp_ModalidadeFrete = XML_Elemento_Item("transp", "modFrete")
'      .Transp_CPF_CNPJ = XML_Elemento_Item("transporta", New String() {"CNPJ", "CPF"})
'      .Transp_Nome = XML_Elemento_Item("transporta", "xNome")
'      .Transp_IE = XML_Elemento_Item("transporta", "IE")
'      .Transp_End_Logradouro = XML_Elemento_Item("transporta", "xEnder")
'      .Transp_End_IBGE_Municipio = XML_Elemento_Item("transporta", "cMun")
'      .Transp_End_Municipio = XML_Elemento_Item("transporta", "xMun")
'      .Transp_End_UF = XML_Elemento_Item("transporta", "UF")
'      .Transp_Placa = XML_Elemento_Item("veicTransp", "placa")
'      .Transp_Placa_UF = XML_Elemento_Item("veicTransp", "UF")
'      .Transp_Placa_RNTC = XML_Elemento_Item("veicTransp", "RNTC")
'      .Transp_Placa2 = XML_Elemento_Item("reboque", "placa")
'      .Transp_Placa2_UF = XML_Elemento_Item("reboque", "UF")
'      .Transp_Placa2_RNTC = XML_Elemento_Item("reboque", "RNTC")
'      .Transp_Volume_Quantidade = Val(XML_Elemento_Item("vol", "qVol"))
'      .Transp_Volume_Especie = Val(XML_Elemento_Item("vol", "esp"))
'      .Transp_Volume_Marca = Val(XML_Elemento_Item("vol", "marca"))
'      .Transp_Volume_PesoLiquido = Val(XML_Elemento_Item("vol", "pesoL"))
'      .Transp_Volume_PesoBruto = Val(XML_Elemento_Item("vol", "pesoB"))
'      .Cobranca_NumeroFatura = XML_Elemento_Item("fat", "nFat")
'      .Cobranca_ValorOriginal = Val(XML_Elemento_Item("fat", "vOrig"))
'      .Cobranca_ValorDesconto = Val(XML_Elemento_Item("fat", "vDesc"))
'      .Cobranca_ValorLiquido = Val(XML_Elemento_Item("fat", "vLiq"))
'      .CobrancaParcNrParcela = XML_Elemento_Item("dup", "nDup")
'      .CobrancaParcVencimento = FNC_Data_TratarAAAAMMDD(XML_Elemento_Item("dup", "dVenc"))
'      .CobrancaParcValorParcela = Val(XML_Elemento_Item("dup", "vDup"))
'      .InformacoesComplementares = XML_Elemento_Item("infAdic", "infCpl")
'      .Info_Chave = XML_Elemento_Item("infProt", "chNFe")
'      .Info_DH_Recebimento = XML_Elemento_Item("infProt", "dhRecbto")
'      .Info_Status = XML_Elemento_Item("infProt", "cStat")
'      .Info_Motivo = XML_Elemento_Item("infProt", "xMotivo")

'      For iCont = 0 To XML_Elementos("prod").Count - 1
'        oProd = New cNfe_Produto

'        With oProd
'          .Codigo = XML_Elemento_Item("prod", "cProd", iCont)
'          .CodigoBarra = XML_Elemento_Item("prod", "cEAN", iCont)
'          .Nome = XML_Elemento_Item("prod", "xProd", iCont)
'          .NCM = XML_Elemento_Item("prod", "NCM", iCont)
'          .CFOP = XML_Elemento_Item("prod", "CFOP", iCont)
'          .UnidadeMedida = XML_Elemento_Item("prod", "uCom", iCont)
'          .Quantidade = Val(XML_Elemento_Item("prod", "qCom", iCont))
'          .ValorUnitario = Val(XML_Elemento_Item("prod", "vUnCom", iCont))
'          .ValorTotal = Val(XML_Elemento_Item("prod", "vProd", iCont))
'          .EANTributavel = XML_Elemento_Item("prod", "cEANTrib", iCont)
'          .UnidadeTributavel = XML_Elemento_Item("prod", "uTrib", iCont)
'          .QuantidadeTributavel = Val(XML_Elemento_Item("prod", "qTrib", iCont))
'          .ValorTributavel = Val(XML_Elemento_Item("prod", "vUnTrib", iCont))
'          .ValorFrete = Val(XML_Elemento_Item("prod", "vFrete", iCont))
'          .ValorSeguro = Val(XML_Elemento_Item("prod", "vSeg", iCont))
'          .ValorDesconto = Val(XML_Elemento_Item("prod", "vDesc", iCont))
'          .ValorOutrasDespesas = Val(XML_Elemento_Item("prod", "vOutro_item", iCont))
'          .IncluirValorTotal = XML_Elemento_Item("prod", "indTot", iCont)
'          .TipoItem = XML_Elemento_Item("prod", "nTipoItem", iCont)
'          .PedidoCompra = XML_Elemento_Item("prod", "xPed_item", iCont)
'          .PedidoCompra_Item = XML_Elemento_Item("prod", "nItemPed", iCont)
'          .CEST = XML_Elemento_Item("prod", "CEST", iCont)
'        End With

'        .Produto.Add(oProd)
'      Next

'      For iCont = 0 To XML_Elementos("dup").Count - 1
'        oDup = New cNfe_Duplicata

'        With oDup
'          .nDup = XML_Elemento_Item("dup", "nDup", iCont)
'          .vDup = Val(XML_Elemento_Item("dup", "vDup", iCont))
'          .dVenc = FNC_Data_TratarAAAAMMDD(XML_Elemento_Item("dup", "dVenc", iCont))
'        End With

'        .Duplicata.Add(oDup)
'      Next
'    End With

'    bCarregado = True

'    Return True

'    Exit Function

'Erro:
'    Return False
'  End Function

'  Public Function XML_Elemento(sNome As String, Optional Indice As Integer = 0) As XmlNode
'    Return oXML.GetElementsByTagName(sNome).Item(Indice)
'  End Function

'  Public Function XML_Elementos(sNome As String) As XmlNodeList
'    Return oXML.GetElementsByTagName(sNome)
'  End Function

'  Public Function XML_Elemento_Item(sNome As String,
'                                    Item As String,
'                                    Optional Indice As Integer = 0,
'                                    Optional ValorPadrao As Object = Nothing) As String
'    Try
'      Return XML_Elemento(sNome, Indice).Item(Item).InnerText

'    Catch ex As Exception
'      Return ValorPadrao
'    End Try
'  End Function

'  Public Function XML_Elemento_Item(sNome As String,
'                                    Item() As String,
'                                    Optional Indice As Integer = 0,
'                                    Optional ValorPadrao As Object = Nothing) As String
'    Dim sValor As String = ValorPadrao

'    Try
'      Dim iCont As Integer

'      For iCont = 0 To Item.Count - 1
'        If Not XML_Elemento(sNome, Indice).Item(Item(iCont)) Is Nothing Then
'          sValor = XML_Elemento(sNome, Indice).Item(Item(iCont)).InnerText
'          Exit For
'        End If
'      Next
'    Catch ex As Exception
'    End Try

'    Return sValor
'  End Function

'  Public ReadOnly Property Carregado As Boolean
'    Get
'      Return bCarregado
'    End Get
'  End Property
'End Class
