﻿Imports Infragistics.Win
    Public Especialidade As String

  'NF-e
  'Public oNFe_XML As New clsXML

  Public Class clsModeloDocumentoElemento

    'If Not DBConectar() Then End

    Dim oFormLogin As New frmLogin
    '>>> ESSE BLOCO DEVE FICAR SEMPRE JUNTOS
    If Trim(NomePessoa) <> "" Then
    '>>> ESSE BLOCO DEVE FICAR SEMPRE JUNTOS
    If TipoPessoa > -1 Then

    '>>> ESSE BLOCO DEVE FICAR SEMPRE JUNTOS
    If Trim(NomeProduto) <> "" Then
    '>>> ESSE BLOCO DEVE FICAR SEMPRE JUNTOS
    If TipoProduto > 0 Then
    Dim Integracao As modDeclaracaoLocal.Integracao

    Integracaos = New List(Of modDeclaracaoLocal.Integracao)

    sSqlText = "SELECT * FROM TB_INTEGRACAO"
      For iCont = 0 To oData.Rows.Count - 1
        Integracao = New modDeclaracaoLocal.Integracao()
        Integracao.SQ_INTEGRACAO = oData.Rows(iCont).Item("SQ_INTEGRACAO")
        Integracao.NO_INTEGRACAO = oData.Rows(iCont).Item("NO_INTEGRACAO")
        Integracao.DS_LINK = FNC_NVL(oData.Rows(iCont).Item("DS_LINK"), "")
        Integracao.CD_CHAVE_01 = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_01"), "")
        Integracao.CD_CHAVE_02 = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_02"), "")
        Integracao.CD_CHAVE_03 = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_03"), "")
        Integracao.CD_CHAVE_04 = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_04"), "")
        Integracao.CD_CHAVE_05 = FNC_NVL(oData.Rows(iCont).Item("CD_CHAVE_05"), "")
        Integracao.TP_ATIVO = (FNC_NVL(oData.Rows(iCont).Item("TP_ATIVO"), "") = "S")
        Integracaos.Add(Integracao)
      Next
    End If
  End Sub

  Public Function FNC_Integracao_CarregarDados(Integracao As modDeclaracaoLocal.enIntegracao) As modDeclaracaoLocal.Integracao
    Dim _Integracao As modDeclaracaoLocal.Integracao = New modDeclaracaoLocal.Integracao()

    If Not Integracaos Is Nothing Then
      Dim iCont As Integer

      For iCont = 0 To Integracaos.Count - 1
        If Integracaos(iCont).SQ_INTEGRACAO = Integracao.GetHashCode() Then
          _Integracao = Integracaos(iCont)
          Exit For
        End If
      Next
    End If

    Return _Integracao
  End Function

      'sEMPRESA_PAYGO_REGISTRO_CERTIFICACAO = FNC_NVL(.Item("PAYGO_REGISTRO_CERTIFICACAO"), "")

      If iID_USUARIO = 1 Then

    '>> Endereço
    sSqlText = "SELECT * " &

    '>> Telefone
    sSqlText = "SELECT * FROM VW_PESSOA_TELEFONE WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL & " AND ID_TIPO_TELEFONE = " & enTipoTelefone.Comercial.GetHashCode

    '>> Midia Social
    sSqlText = "SELECT * FROM VW_PESSOA_MIDIASOCIAL WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL

    '>> DADOS DO USÁRIO NA EMPRESA
    sSqlText = "SELECT PSEMP.*, TPCRG.ID_OPT_TIPOFUNCAO" &

    '>> DADOS DE SISTEMA
    sSqlText = "SELECT * FROM TB_SISTEMA"
          'Indice = FNC_Form_Container_IdentificarControles_Item(oControls(iCont_02), oToolTip, UCase(sIdentificadorBotao), bAceitarFocus)

          'Form_Botao_Formatar(oBotao, Indice, bAceitarFocus)
        Else
          'se for windows label defino a cor de fundo como transparente
          If TypeOf oControls(iCont_02) Is System.Windows.Forms.Label Then
          'Montar a claúsula FROM
          sSqlText_TABELA_FILHO = .Item("DS_TABELA_VIEW_FILHO") & "_" & iCont_01.ToString

        'Listar os campos
        FNC_Str_Adicionar(sSqlText_SELECT, CarregarDicionarioDados_Valores_Campo(oData_01(iCont_01).Item("ID_DICIONARIODADO_VISAO"), sSqlText_TABELA_FILHO), "," & vbCrLf)