Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Xml

Module modQuestionario
  Public Const const_GridQuestionario_ID_QUESTIONARIO_VERSAO_ITEM As Integer = 0
  Public Const const_GridQuestionario_ID_OPT_TIPO_QUESTIONARIO As Integer = 1
  Public Const const_GridQuestionario_Pergunta As Integer = 2
  Public Const const_GridQuestionario_Resposta As Integer = 3
  Public Const const_GridQuestionario_PerguntaExplicacao As Integer = 4
  Public Const const_GridQuestionario_RespostaExplicacao As Integer = 5

  Public Function FNC_Questionario_DadosVitais_ID(bVersaoAtual As Boolean) As Integer
    Dim sSqlText As String

    sSqlText = "SELECT " & IIf(bVersaoAtual, "QV.SQ_QUESTIONARIO_VERSAO", "QV.ID_QUESTIONARIO") &
               " FROM TB_QUESTIONARIO QU" &
               " INNER JOIN TB_OPCAO OP ON OP.SQ_OPCAO = QU.ID_OPT_TIPOQUESTIONARIO" &
                                     " AND OP.ID_TIPO_OPCAO = " & enTipoOpcao.TipoQuestionarioClinicaDadosVitais.GetHashCode &
                " LEFT JOIN TB_QUESTIONARIO_VERSAO QV ON QU.SQ_QUESTIONARIO = QV.ID_QUESTIONARIO" &
                                                   " AND QV.DT_FIM_USO IS NULL" &
               " WHERE QU.ID_EMPRESA = " & iID_EMPRESA_FILIAL
    Return DBQuery_ValorUnico(sSqlText)
  End Function

  Public Sub FNC_Questionario_Carregar(ByVal oGrid As UltraGrid,
                                       iSQ_QUESTIONARIOVERSAO As Integer,
                                       iID_TIPO_SEXO As Integer,
                                       Optional iID_QUESTIONARIO_RESPOSTA As Integer = 0)
    Dim oRow As UltraWinDataSource.UltraDataRow
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer
    Dim oDBGrid As New UltraWinDataSource.UltraDataSource

    If oGrid.DisplayLayout.Bands(0).Columns.Count > 0 Then
      Try
        oGrid = oGrid.DataSource
        oDBGrid.Rows.Clear()
      Catch ex As Exception
      End Try

      sSqlText = "SELECT QTI.SQ_QUESTIONARIO_VERSAO_ITEM," &
                          "QTI.ID_TIPO_QUESTIONARIO," &
                          "QTI.ID_LEGENDA," &
                          "QTI.DS_PERGUNTA," &
                          "QTI.NR_TAMANHORESPOSTA," &
                          "QTI.ID_LEGENDA_EXPLICACAO," &
                          "QTI.DS_ROTULO_EXPLICACAO," &
                          "QRT.DS_RESPOSTA," &
                          "QRT.NR_RESPOSTA," &
                          "QRT.DT_RESPOSTA," &
                          "QRT.IC_RESPOSTA," &
                          "QRT.DS_EXPLICACAO," &
                          "QRT.QT_EXPLICACAO" &
                   " FROM TB_QUESTIONARIO_VERSAO QTV" &
                    " INNER JOIN TB_QUESTIONARIO_VERSAO_ITEM QTI ON QTI.ID_QUESTIONARIO_VERSAO = QTV.SQ_QUESTIONARIO_VERSAO" &
                     " LEFT JOIN (SELECT * FROM TB_QUESTIONARIO_RESPOSTA_ITEM" &
                                 " WHERE ID_QUESTIONARIO_RESPOSTA = " & iID_QUESTIONARIO_RESPOSTA & ") QRT ON QRT.ID_QUESTIONARIO_VERSAO_ITEM = QTI.SQ_QUESTIONARIO_VERSAO_ITEM" &
                   " WHERE QTV.SQ_QUESTIONARIO_VERSAO = " & iSQ_QUESTIONARIOVERSAO &
                     " AND (QTI.ID_TIPO_SEXO = " & iID_TIPO_SEXO & " OR QTI.ID_TIPO_SEXO IS NULL)" &
                   " ORDER BY QTI.NR_ORDEM_PERGUNTA"
      oData = DBQuery(sSqlText)

      For iCont = 0 To oData.Rows.Count - 1
        oRow = objGrid_Linha_Add(oGrid,
                                 New Object() {const_GridQuestionario_ID_QUESTIONARIO_VERSAO_ITEM, oData.Rows(iCont).Item("SQ_QUESTIONARIO_VERSAO_ITEM"),
                                               const_GridQuestionario_ID_OPT_TIPO_QUESTIONARIO, oData.Rows(iCont).Item("ID_TIPO_QUESTIONARIO"),
                                               const_GridQuestionario_Pergunta, oData.Rows(iCont).Item("DS_PERGUNTA")})

        Select Case oData.Rows(iCont).Item("ID_TIPO_QUESTIONARIO")
          Case enOpcoes.TipoCampo_Data
          Case enOpcoes.TipoCampo_Texto
          Case enOpcoes.TipoCampo_Numero
            oRow.SetCellValue(const_GridQuestionario_Resposta, oData.Rows(iCont).Item("NR_RESPOSTA"))
          Case enOpcoes.TipoCampo_Legenda_UnicaOpcao
          Case enOpcoes.TipoCampo_Marcacao
        End Select
      Next
    End If
  End Sub

  Public Sub FNC_QuestionarioVersao_Imprimir(iSQ_QUESTIONARIO As Integer)
    Dim sSqlText As String


  End Sub

  Public Function FNC_QuestionarioVersao_CarregarDadosVitais(ByVal oGrid As UltraGrid,
                                                             iID_TIPO_SEXO As Integer,
                                                             Optional iID_QUESTIONARIO_VERSAO As Integer = 0,
                                                             Optional iID_QUESTIONARIO_RESPOSTA As Integer = 0) As Integer
    Dim iRet As Integer

    If iID_QUESTIONARIO_VERSAO = 0 Then
      iRet = FNC_Questionario_DadosVitais_ID(True)
    Else
      iRet = iID_QUESTIONARIO_VERSAO
    End If

    FNC_Questionario_Carregar(oGrid, iRet, iID_TIPO_SEXO, iID_QUESTIONARIO_RESPOSTA)

    Return iRet
  End Function

  Public Function FNC_QuestionarioVersao_Uso(iSQ_QUESTIONARIO_VERSAO As Integer) As Boolean
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM TB_QUESTIONARIO_RESPOSTA WHERE ID_QUESTIONARIO_VERSAO = " & iSQ_QUESTIONARIO_VERSAO

    Return (DBQuery_ValorUnico(sSqlText) > 0)
  End Function

  Public Sub FNC_Atendimento_DadosVitais_Resposta(iSQ_ATENDIMENTO As Integer,
                                                  ByRef iSQ_QUESTIONARIO_RESPOSTA As Integer,
                                                  ByRef iID_QUESTIONARIO_VERSAO As Integer)
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT SQ_QUESTIONARIO_RESPOSTA, ID_QUESTIONARIO_VERSAO FROM TB_QUESTIONARIO_RESPOSTA WHERE ID_ATENDIMENTO = " & iSQ_ATENDIMENTO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      iSQ_QUESTIONARIO_RESPOSTA = oData.Rows(0).Item("SQ_QUESTIONARIO_RESPOSTA")
      iID_QUESTIONARIO_VERSAO = oData.Rows(0).Item("ID_QUESTIONARIO_VERSAO")
    End If
  End Sub

  Public Sub FNC_Questionario_FormatarGrid(ByVal oGrid As UltraGrid,
                                           oDBGrid As UltraWinDataSource.UltraDataSource,
                                           Optional bPossibilidadeExplicacao As Boolean = True)

    objGrid_Inicializar(oGrid, AllowAddNew.Default, oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(oGrid, "ID_QUESTIONARIO_VERSAO", 0)
    objGrid_Coluna_Add(oGrid, "ID_TIPO_QUESTIONARIO", 0)
    objGrid_Coluna_Add(oGrid, "Pergunta", 150)
    objGrid_Coluna_Add(oGrid, "Resposta", 150, , True)
    objGrid_Coluna_Add(oGrid, "Pergunta Explicação", 150).Hidden = (Not bPossibilidadeExplicacao)
    objGrid_Coluna_Add(oGrid, "Resposta Explicação", 150, True).Hidden = (Not bPossibilidadeExplicacao)
  End Sub

  Public Function FNC_Questionario_Resposta_Gravar(ByRef iSQ_QUESTIONARIO_RESPOSTA As Integer,
                                                   iID_QUESTIONARIO_VERSAO As Integer,
                                                   iID_PESSOA As Integer,
                                                   iID_ATENDIMENTO As Integer,
                                                   iID_PESSOA_PROFISSIONAL As Integer)
    Dim sSqlText As String
    Dim bOk As Boolean

    sSqlText = DBMontar_SP("SP_QUESTIONARIO_RESPOSTA_CAD", False, "@SQ_QUESTIONARIO_RESPOSTA OUT",
                                                                  "@ID_QUESTIONARIO_VERSAO",
                                                                  "@ID_EMPRESA",
                                                                  "@ID_PESSOA",
                                                                  "@ID_ATENDIMENTO",
                                                                  "@ID_PESSOA_PROFISSIONAL",
                                                                  "@DT_RESPOSTA")
    bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_RESPOSTA", iSQ_QUESTIONARIO_RESPOSTA, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_QUESTIONARIO_VERSAO", iID_QUESTIONARIO_VERSAO),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                               DBParametro_Montar("ID_PESSOA", FNC_NuloZero(iID_PESSOA, False)),
                               DBParametro_Montar("ID_ATENDIMENTO", FNC_NuloZero(iID_ATENDIMENTO, False)),
                               DBParametro_Montar("ID_PESSOA_PROFISSIONAL", FNC_NuloZero(iID_PESSOA_PROFISSIONAL, False)),
                               DBParametro_Montar("DT_RESPOSTA", Now.Date))
    If DBTeveRetorno() Then
      iSQ_QUESTIONARIO_RESPOSTA = DBRetorno(1)
    End If

    Return bOk
  End Function

  Public Sub FNC_Questionario_Gravar(ByVal oGrid As UltraGrid,
                                     ByRef iSQ_QUESTIONARIO_RESPOSTA As Integer,
                                     iID_QUESTIONARIO_VERSAO As Integer,
                                     Optional iID_PESSOA As Integer = 0,
                                     Optional iID_PROFISSIONAL As Integer = 0,
                                     Optional iID_ATENDIMENTO As Integer = 0)
    Dim sSqlText As String
    Dim iCont As Integer

    'Dados do Paciente
    If FNC_Questionario_Resposta_Gravar(iSQ_QUESTIONARIO_RESPOSTA,
                                        iID_QUESTIONARIO_VERSAO,
                                        iID_PESSOA,
                                        iID_ATENDIMENTO,
                                        iID_PROFISSIONAL) Then
      Dim oID_LEGENDA_ITEM As DBParamentro
      Dim oDS_RESPOSTA As DBParamentro
      Dim oNR_RESPOSTA As DBParamentro
      Dim oDT_RESPOSTA As DBParamentro
      Dim oIC_RESPOSTA As DBParamentro

      For iCont = 0 To oGrid.Rows.Count - 1
        oID_LEGENDA_ITEM = New DBParamentro
        oDS_RESPOSTA = New DBParamentro
        oNR_RESPOSTA = New DBParamentro
        oDT_RESPOSTA = New DBParamentro
        oIC_RESPOSTA = New DBParamentro

        oID_LEGENDA_ITEM = DBParametro_Montar("ID_LEGENDA_ITEM", Nothing)
        oDS_RESPOSTA = DBParametro_Montar("DS_RESPOSTA", Nothing)
        oNR_RESPOSTA = DBParametro_Montar("NR_RESPOSTA", Nothing, SqlDbType.Float)
        oDT_RESPOSTA = DBParametro_Montar("DT_RESPOSTA", Nothing, SqlDbType.Date)
        oIC_RESPOSTA = DBParametro_Montar("IC_RESPOSTA", Nothing)

        Select Case objGrid_Valor(oGrid, const_GridQuestionario_ID_OPT_TIPO_QUESTIONARIO, iCont)
          Case enOpcoes.TipoCampo_Data
            oDT_RESPOSTA.Valor = objGrid_Valor(oGrid, const_GridQuestionario_Resposta, iCont)
          Case enOpcoes.TipoCampo_Texto
            oDS_RESPOSTA.Valor = objGrid_Valor(oGrid, const_GridQuestionario_Resposta, iCont)
          Case enOpcoes.TipoCampo_Numero
            If Not FNC_CampoNulo(objGrid_Valor(oGrid, const_GridQuestionario_Resposta, iCont)) Then
              oNR_RESPOSTA.Valor = IIf(FNC_CampoNulo(objGrid_Valor(oGrid, const_GridQuestionario_Resposta, iCont)), Nothing, Val(objGrid_Valor(oGrid, const_GridQuestionario_Resposta, iCont)))
            End If
          Case enOpcoes.TipoCampo_Legenda_UnicaOpcao
            oID_LEGENDA_ITEM.Valor = objGrid_Valor(oGrid, const_GridQuestionario_Resposta, iCont)
          Case enOpcoes.TipoCampo_Marcacao
            oIC_RESPOSTA.Valor = IIf(objGrid_Valor(oGrid, const_GridQuestionario_Resposta, iCont) = 1, "S", "N")
        End Select

        sSqlText = DBMontar_SP("SP_QUESTIONARIO_RESPOSTA_ITEM_CAD", False, "@ID_QUESTIONARIO_RESPOSTA", _
                                                                           "@ID_QUESTIONARIO_VERSAO_ITEM", _
                                                                           "@ID_LEGENDA_ITEM", _
                                                                           "@DS_RESPOSTA", _
                                                                           "@NR_RESPOSTA", _
                                                                           "@DT_RESPOSTA", _
                                                                           "@IC_RESPOSTA", _
                                                                           "@DS_EXPLICACAO")
        DBExecutar(sSqlText, DBParametro_Montar("ID_QUESTIONARIO_RESPOSTA", iSQ_QUESTIONARIO_RESPOSTA), _
                             DBParametro_Montar("ID_QUESTIONARIO_VERSAO_ITEM", objGrid_Valor(oGrid, const_GridQuestionario_ID_QUESTIONARIO_VERSAO_ITEM, iCont)), _
                             oID_LEGENDA_ITEM, _
                             oDS_RESPOSTA, _
                             oNR_RESPOSTA, _
                             oDT_RESPOSTA, _
                             oIC_RESPOSTA, _
                             DBParametro_Montar("DS_EXPLICACAO", FNC_NuloString(objGrid_Valor(oGrid, const_GridQuestionario_RespostaExplicacao, iCont), False)))
      Next
    End If
  End Sub

  Public Sub FNC_Questionario_Relatorio_Gerar(iSQ_QUESTIONARIO_VERSAO As Integer)
    Dim oXML As New XmlDocument
    Dim sArquivo As String
    Dim sSqlText As String

    sSqlText = "SELECT DS_PATH_RELATORIO FROM TB_QUESTIONARIO_VERSAO WHERE SQ_QUESTIONARIO_VERSAO = " & iSQ_QUESTIONARIO_VERSAO
    sArquivo = DBQuery_ValorUnico(sSqlText, "")

    If Trim(sArquivo) <> "" Then
      sArquivo = FNC_DiretorioSistema_AdicionarPath(sArquivo)

      If Dir(sArquivo) = "" Then sArquivo = ""
    End If

    sArquivo = FNC_Relatorio_CarregarArquivo("RPT_ModeloFicha.rdl")

    oXML = New XmlDocument
    oXML.Load(sArquivo)

    oXML = Nothing
  End Sub
End Module
