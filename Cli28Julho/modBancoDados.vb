Imports System.Data.SqlClient
Imports System.Data.Common
Imports Infragistics.Win

Module modBancoDados
  Public iDB_TimeOut As Integer = 30
  Public bUsarTransacao As Boolean
  Public oTipoComando As System.Data.CommandType = CommandType.Text
  Public bDBCarregandoComboBox As Boolean = False

  Public sDBStringDeConecao01 As String = ""
  Public sDBStringDeConecao02 As String = ""

  Dim oTrans As SqlTransaction
  Dim oRetorno As Collection
  Dim MsgErr As String
  Dim bErro As Boolean
  Dim bExibirErro As Boolean = True

  Public Class DBWhere
    Public Query As String
    Public NomeCampo As String
    Public ValorCampo As String
  End Class

  Public Class DBParamentro
    Public Nome As String
    Public Valor As Object
    Public Tipo As SqlDbType
    Public Direcao As ParameterDirection
    Public Tamanho As Integer
  End Class

  Public Enum TipoCampoFixo
    Todos = -1
    Nenhum = 0
    DadoCriacao = 1
    DadoAlteracao = 2
    DadoExclusao = 3
  End Enum

  Public Property DBUsarTransacao() As Boolean
    Get
      Return bUsarTransacao
    End Get
    Set(ByVal Valor As Boolean)
      If Valor Then
        If bUsarTransacao Then oTrans.Commit()

        bUsarTransacao = Valor

        oTrans = oConexao.BeginTransaction
      Else
        If bUsarTransacao Then
          oTrans.Rollback()
          bUsarTransacao = False
        End If
      End If
    End Set
  End Property

  Public Function DBConectarServidor(iServidor As Integer) As Boolean
    sDBStringDeConecao01 = "Serv" & FNC_StrZero(iServidor, 2) & "_StringDeConecao1"
    sDBStringDeConecao02 = "Serv" & FNC_StrZero(iServidor, 2) & "_StringDeConecao2"

    Return DBConectar(sDBStringDeConecao01, sDBStringDeConecao02)
  End Function

  Public Function DBConectar(Optional sStringDeConecao01 As String = "StringDeConecao",
                             Optional sStringDeConecao02 As String = "",
                             Optional bValidarConexao As Boolean = False,
                             Optional ByRef oConexaoConectar As SqlConnection = Nothing) As Boolean
    Dim bOk As Boolean = True
    Dim sString As String
    Dim sSenha As String

    Try
      sString = FNC_ConfiguracaoAplicacao(sStringDeConecao01)

      If FNC_NVL(sString, "") = "" Then
        Err.Raise(1, , "String de conexão não encontrada!")
      Else
        Try
          sSenha = Mid(sString, InStr(sString, "pwd=") + Len("pwd="))
          sString = Mid(sString, 1, InStr(sString, "pwd=") + Len("pwd=") - 1) & FNC_Descriptografar(sSenha)
        Catch ex As Exception
          sString = Replace(sString, "pwd1=", "pwd=")
        End Try

        If oConexaoConectar Is Nothing Then
          If bValidarConexao Then
            If oConexao.State = ConnectionState.Broken Then
              oConexao.Close()
            ElseIf oConexao.State = ConnectionState.Open Then
              bOk = True
              GoTo Sair
            End If
          End If

          oConexao = New SqlConnection(sString)
          oConexao.Open()
          oConexaoDBQuery = New SqlConnection(sString)
          oConexaoDBQuery.Open()
        Else
          If bValidarConexao Then
            If oConexaoConectar.State = ConnectionState.Broken Then
              oConexaoConectar.Close()
            ElseIf oConexaoConectar.State = ConnectionState.Open Then
              bOk = True
              GoTo Sair
            End If
          End If

          oConexaoConectar = New SqlConnection(sString)
          oConexaoConectar.Open()
        End If
      End If
    Catch ex As Exception
      If (InStr(ex.Message.ToUpper(), "ERRO AO LOCALIZAR SERVIDOR/INSTÂNCIA ESPECIFICADA") > 0 Or
          InStr(ex.Message.ToUpper(), "SERVIDOR NÃO FOI ENCONTRADO") > 0 Or
          InStr(ex.Message.ToUpper(), "SERVIDOR NAO FOI ENCONTRADO") > 0) And
        sStringDeConecao02.Trim() <> "" And
        FNC_NVL(FNC_ConfiguracaoAplicacao(sStringDeConecao02), "") <> "" Then
        bOk = DBConectar(sStringDeConecao02,, bValidarConexao, oConexaoConectar)
      Else
        bOk = False
        FNC_Mensagem(sStringDeConecao01 & " - " & ex.Message)
      End If
    End Try

Sair:
    Return bOk
  End Function

  Public Function DBDesconectar() As Boolean
    Dim bOk As Boolean = True

    Try
      oConexao.Close()
      oConexao.Dispose()
    Catch ex As Exception
      bOk = False
      FNC_Mensagem(ex.Message)
    End Try

    Return bOk
  End Function

  Public Function DBQuery_ListaRetorno(ByVal sSqlText As String,
                                       ByRef sMensagem As String,
                                       Optional ByVal oConexaoQuery As System.Data.Common.DbConnection = Nothing) As Boolean
    Dim oData As DataTable
    Dim iCont As Integer

    Try
      oData = DBQuery(sSqlText, oConexaoQuery)

      For iCont = 0 To oData.Rows.Count - 1
        FNC_Str_Adicionar(sMensagem, oData.Rows(iCont).Item(0), vbCrLf)
      Next
    Catch ex As Exception
      sMensagem = ""
    End Try

    Return (FNC_NVL(sMensagem, "") > "")
  End Function

  Public Function DBQuery_ValorUnicoInt(ByVal sSqlText As String,
                                        Optional ByVal ValorPadrao As Object = Nothing,
                                        Optional ByVal oConexaoQuery As System.Data.Common.DbConnection = Nothing) As Integer
    Return Convert.ToInt32(DBQuery_ValorUnico(sSqlText, ValorPadrao, oConexaoQuery))
  End Function

  Public Function DBQuery_ValorUnico(ByVal sSqlText As String,
                                     Optional ByVal ValorPadrao As Object = Nothing,
                                     Optional ByVal oConexaoQuery As System.Data.Common.DbConnection = Nothing) As Object
    Dim oRet As Object

    Try
      oRet = DBQuery(sSqlText, oConexaoQuery).Rows(0).Item(0)
    Catch ex As Exception
      oRet = Nothing
    End Try

    Return FNC_NVL(oRet, ValorPadrao)
  End Function

  Public Function DBQuery(sSqlText As String, Optional oConexaoQuery As System.Data.Common.DbConnection = Nothing) As DataTable
    Dim oSqlDataAdapter As DbDataAdapter = Nothing
    Dim oDataSet As New DataSet
    Dim oData As DataTable

    Try
      If oConexaoQuery Is Nothing Then
        oConexaoDBQuery.Close()
        oConexaoDBQuery.Open()
        oConexaoQuery = oConexao
      End If

      DBConectar(sDBStringDeConecao01, sDBStringDeConecao02, True, oConexaoQuery)

      If TypeOf oConexaoQuery Is System.Data.SqlClient.SqlConnection Then
        oSqlDataAdapter = New SqlDataAdapter(sSqlText, oConexaoQuery)
      ElseIf TypeOf oConexaoQuery Is System.Data.OleDb.OleDbConnection Then
        oSqlDataAdapter = New OleDb.OleDbDataAdapter(sSqlText, oConexaoQuery)
        'ElseIf TypeOf oConexaoQuery Is FirebirdSql.Data.FirebirdClient.FbConnection Then
        '  oSqlDataAdapter = New FirebirdSql.Data.FirebirdClient.FbDataAdapter(sSqlText, oConexaoQuery)
      End If

      oSqlDataAdapter.SelectCommand.CommandTimeout = 0
      oSqlDataAdapter.Fill(oDataSet)
      oData = oDataSet.Tables(0)

      oDataSet.Dispose()
      oSqlDataAdapter.Dispose()

      Return oData
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
      Return Nothing
    End Try
  End Function

  Public Function DBExecutarAsync(ByVal SqlText As String,
                                  ByVal ParamArray Parametro() As DBParamentro) As Boolean
    Return DBExecutar(SqlText, Nothing, True, Parametro)
  End Function

  Public Function DBExecutar(ByVal SqlText As String,
                             ByVal ParamArray Parametro() As DBParamentro) As Boolean
    Return DBExecutar(SqlText, Nothing, False, Parametro)
  End Function
  Public Function DBExecutar(ByVal SqlText As String,
                             oConexaoQuery As System.Data.Common.DbConnection,
                             Async As Boolean,
                             ByVal ParamArray Parametro() As DBParamentro) As Boolean
    Dim iLinhaAfetada As Integer

    Return DBExecutar_LinhaAfetadas(SqlText, iLinhaAfetada, oConexaoQuery, Async, Parametro)
  End Function

  Public Function DBExecutar_LinhaAfetadas(ByVal sSqlText As String,
                                           ByRef iLinhaAfetada As Integer,
                                           Async As Boolean,
                                           ByVal ParamArray Parametro() As DBParamentro) As Boolean
    Return DBExecutar_LinhaAfetadas(sSqlText, iLinhaAfetada, Nothing, Async, Parametro)
  End Function
  Public Function DBExecutar_LinhaAfetadas(ByVal sSqlText As String,
                                           ByRef iLinhaAfetada As Integer,
                                           oConexaoQuery As System.Data.Common.DbConnection,
                                           Async As Boolean,
                                           ByVal ParamArray Parametro() As DBParamentro) As Boolean
    Dim oAux As DBParamentro
    Dim oCommand As DbCommand
    Dim oParametro As SqlParameter
    Dim bOutPutParametro As Boolean
    Dim bRetornoParametro As Boolean
    Dim sAux As String = ""

    Try
      DBConectar(sDBStringDeConecao01, sDBStringDeConecao02, True, oConexaoQuery)

      oCommand = New SqlCommand
      oCommand = oConexao.CreateCommand()
      oCommand.CommandTimeout = iDB_TimeOut
      oCommand.CommandTimeout = 0

      If bUsarTransacao Then oCommand.Transaction = oTrans

      oCommand.CommandType = oTipoComando
      oTipoComando = CommandType.Text

      If Parametro Is Nothing Then
        oCommand.CommandText = sSqlText

        If Async Then
          oCommand.ExecuteNonQueryAsync()
        Else
          oCommand.ExecuteNonQuery()
        End If
      Else
        oCommand.CommandText = sSqlText
        oCommand.Prepare()

        For Each oAux In Parametro
          If oAux.Tipo <> SqlDbType.Image Then
            'FNC_Str_Adicionar(sAux, oAux.Nome & " = " & IIf(FNC_CampoNulo(oAux.Valor), "NULL", oAux.Valor) & " | ", vbCrLf)
          End If

          Select Case oAux.Direcao
            Case ParameterDirection.InputOutput, ParameterDirection.Output
              bOutPutParametro = True
            Case ParameterDirection.ReturnValue
              bRetornoParametro = True
          End Select

          oParametro = New SqlParameter
          oParametro = oCommand.CreateParameter

          With oParametro
            .ParameterName = oAux.Nome
            .Direction = oAux.Direcao

            If oAux.Tipo = SqlDbType.Image Then
              .SqlDbType = oAux.Tipo
            End If

            If oAux.Valor Is Nothing Then
              .Value = System.DBNull.Value
            Else
              .Value = oAux.Valor
            End If

            If oAux.Tamanho <> 0 Then
              .Size = oAux.Tamanho
            End If
          End With

          oCommand.Parameters.Add(oParametro)
        Next

        If (bOutPutParametro Or bRetornoParametro) AndAlso Not Async Then
          Dim iCont As Integer
          Dim oData As SqlDataReader

          oData = oCommand.ExecuteReader()

          iLinhaAfetada = oData.RecordsAffected

          oRetorno = New Collection

          For iCont = 0 To oCommand.Parameters.Count - 1
            If oCommand.Parameters(iCont).Direction = ParameterDirection.Output Or
               oCommand.Parameters(iCont).Direction = ParameterDirection.InputOutput Or
               oCommand.Parameters(iCont).Direction = ParameterDirection.ReturnValue Then
              oRetorno.Add(oCommand.Parameters(iCont).Value)
            End If
          Next

          oCommand.Dispose()

          oData.Close()
          oData = Nothing
        ElseIf bRetornoParametro AndAlso Not Async Then
          oRetorno = New Collection

          oRetorno.Add(oCommand.ExecuteScalar)
        Else
          If Async Then
            oCommand.ExecuteNonQueryAsync()
          Else
            iLinhaAfetada = oCommand.ExecuteNonQuery()
          End If
        End If
      End If

      oTipoComando = CommandType.Text

      Return True

      Exit Function
    Catch eDB As SqlException
      MsgErr = eDB.Message
      Call Erro_Tratar("MOD_DB.DBExecutar_LinhaAfetadas (OracleException)", sSqlText)
      Return False
    Catch ex As Exception
      Call Erro_Tratar("MOD_DB.DBExecutar_LinhaAfetadas (Exception)", sSqlText)
      Return False
    End Try
  End Function

  Public Function DBQuery_Append(ByVal oData As DataTable,
                                 ByVal SqlText As String,
                                 Optional ByVal bLimparTabela As Boolean = False,
                                 Optional ByVal oDataAux As DataTable = Nothing) As DataTable
    Dim oRow As DataRow
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer

    If oDataAux Is Nothing Then
      oDataAux = New DataTable
      oDataAux = DBQuery(SqlText)
    End If

    If bLimparTabela Then
      oData.Rows.Clear()
    End If

    For iCont_01 = 0 To oDataAux.Rows.Count - 1
      oRow = oData.Rows.Add

      For iCont_02 = 0 To oDataAux.Columns.Count - 1
        oRow.Item(iCont_02) = oDataAux.Rows(iCont_01).Item(iCont_02)
      Next
    Next

    Return oData
  End Function

  Public Sub DBComboBox_Carregar(oCombo As ComboBox,
                                 sSqlText As String,
                                 Optional ColunaIdentificador As Integer = 0,
                                 Optional ColunaNome As Integer = 1)
    Dim oData As DataTable

    bDBCarregandoComboBox = True

    Try
      oCombo.DataSource = Nothing
      oCombo.ValueMember = Nothing
      oCombo.DisplayMember = Nothing
    Catch ex As Exception
    End Try

    Try
      oData = DBQuery(sSqlText)

      oCombo.ValueMember = oData.Columns(ColunaIdentificador).ColumnName
      oCombo.DisplayMember = oData.Columns(ColunaNome).ColumnName
      oCombo.DataSource = oData
    Catch ex As Exception
    End Try

    oCombo.SelectedIndex = -1
    bDBCarregandoComboBox = False
  End Sub

  Public Sub DBListBox_Carregar(oList As ListBox,
                                sSqlText As String,
                                Optional ColunaIdentificador As Integer = 0,
                                Optional ColunaNome As Integer = 1)
    Dim oData As DataTable

    Try
      oList.DataSource = Nothing
      oList.ValueMember = Nothing
      oList.DisplayMember = Nothing
    Catch ex As Exception
    End Try

    oData = DBQuery(sSqlText)

    oList.DataSource = oData
    oList.ValueMember = oData.Columns(ColunaIdentificador).ColumnName
    oList.DisplayMember = oData.Columns(ColunaNome).ColumnName
  End Sub

  Public Sub DBEmpresa_Dados(iID_EMPRESA As Integer)
    Dim sSqlText As String
    Dim oData As DataTable

    sSqlText = "SELECT NO_EMPRESA FROM VW_EMPRESA WHERE ID_EMPRESA = " & iID_EMPRESA
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      sNO_EMPRESA_FILIAL = .Item("NO_EMPRESA")
    End With
  End Sub

  Public Function DBData_Criar(ByVal oDS As DataSet,
                               ByVal TabelaNome As String,
                               ByVal Coluna() As String,
                               Optional ByVal ColunaTipo() As eDbType = Nothing) As DataTable
    Dim oData As New DataTable
    Dim iCont As Integer

    oData.TableName = TabelaNome

    For iCont = LBound(Coluna) To UBound(Coluna)
      oData.Columns.Add(Coluna(iCont))

      If Not ColunaTipo Is Nothing Then
        oData.Columns(Coluna(iCont)).DataType = DBDataType(ColunaTipo(iCont))
      End If
    Next

    If Not oDS Is Nothing Then
      oDS.Tables.Add(oData)
    End If

    Return oData
  End Function

  Public Function DBDataType(ByVal oTipo As eDbType) As System.Type
    Select Case oTipo
      Case eDbType._Inteiro
        Return System.Type.GetType("System.Int16")
      Case eDbType._Numero
        Return System.Type.GetType("System.Double")
      Case eDbType._Data
        Return System.Type.GetType("System.DateTime")
      Case eDbType._Texto
        Return System.Type.GetType("System.String")
      Case eDbType._Decimal
        Return System.Type.GetType("System.Decimal")
      Case Else
        Return System.Type.GetType("System.String")
    End Select
  End Function

  Public Sub DBData_Relationamento_Criar(ByVal oDS As DataSet, ByVal Nome As String,
                                         ByVal oTB01 As DataTable, ByVal Colunas01() As String,
                                         ByVal oTB02 As DataTable, ByVal Colunas02() As String)

    Dim iCont As Integer

    If Not oTB01 Is Nothing And Not oTB02 Is Nothing Then
      Dim oDR As DataRelation
      Dim oColunas01(UBound(Colunas01)) As DataColumn
      Dim oColunas02(UBound(Colunas02)) As DataColumn

      For iCont = LBound(Colunas01) To UBound(Colunas01)
        oColunas01(iCont) = oTB01.Columns(Colunas01(iCont))
        oColunas02(iCont) = oTB02.Columns(Colunas02(iCont))
      Next

      oDR = New DataRelation(Nome & "_", oColunas01, oColunas02, False)
      oDS.Relations.Add(oDR)

      oDR = Nothing
    End If
  End Sub

  Public Sub DBInfo_Cidade(sIBGE As String,
                           Optional ByRef sNome As String = "",
                           Optional ByRef iID_Cidade As Integer = 0,
                           Optional ByRef iID_UF As Integer = 0,
                           Optional ByRef iID_Pais As Integer = 0)
    Dim oData As DataTable
    Dim sSqlText As String

    sNome = ""
    iID_Cidade = 0
    iID_UF = 0
    iID_Pais = 0

    Try
      If sIBGE.Trim().Length = 6 Then
        sSqlText = "SELECT SQ_CIDADE, ID_UF, ID_PAIS, NO_CIDADE FROM VW_CIDADE WHERE CD_IBGE LIKE " + FNC_SQL_FormatarLike(sIBGE)
      Else
        sSqlText = "SELECT SQ_CIDADE, ID_UF, ID_PAIS, NO_CIDADE FROM VW_CIDADE WHERE CD_IBGE = " + FNC_QuotedStr(sIBGE)
      End If

      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        With oData.Rows(0)
          sNome = .Item("NO_CIDADE")
          iID_Cidade = .Item("SQ_CIDADE")
          iID_UF = .Item("ID_UF")
          iID_Pais = .Item("ID_PAIS")
        End With
      End If
    Catch ex As Exception
    End Try
  End Sub

  Private Sub LimparErro()
    bErro = False
    MsgErr = ""
  End Sub

  Private Sub MsgError_Setar(ByVal sErro As String)
    MsgErr = sErro
    bErro = True
  End Sub

  Private Sub Erro_Tratar(ByVal LocalErro As String,
                          Optional ByVal ErroComplemento As String = "")
    Dim sErro As String

    sErro = MsgErr

    MsgError_Setar(FNC_TratarErro(sErro, bExibirErro, LocalErro, ErroComplemento))
    LimparErro()
  End Sub

  Public Function DBContemErro() As Boolean
    Return bErro
  End Function

  Public Function DBExecutar_Insert(ByVal Tabela As String,
                                ByVal CampoFixo As Boolean,
                                ByVal ParamArray CampoValor() As Object) As Boolean
    Dim SqlText As String

    If DBContemErro() Then
      Return False
    End If

    SqlText = DBMontar_Insert(Tabela, CampoFixo, CampoValor)

    Return DBExecutar(SqlText)
  End Function

  Public Function DBExecutar_Update(ByVal Tabela As String,
                                    ByVal CampoValor As Object,
                                    ByVal Where As Object,
                                    Optional ByVal CampoFixo As Boolean = True) As Boolean
    Dim SqlText As String

    If DBContemErro() Then
      Return False
    End If

    SqlText = DBMontar_Update(Tabela, CampoValor, Where, CampoFixo)

    Return DBExecutar(SqlText)
  End Function

  Public Function DBExecutar_Delete(ByVal Tabela As String,
                                    ByVal ParamArray Where() As Object) As Boolean
    Dim SqlText As String
    Dim sWhere As String = String.Empty
    Dim Aux As String
    Dim bCampo As Boolean
    Dim bOperador As Boolean

    If DBContemErro() Then
      Return False
    End If

    bCampo = True

    For Each Aux In Where
      If bCampo Then
        sWhere = sWhere + Aux
        bCampo = False
      ElseIf bOperador Then
        sWhere = sWhere + " " + Aux + " "
        bCampo = True
        bOperador = False
      Else
        If UCase(Aux) = "IS NULL" Then
          sWhere = sWhere & " is null "
        Else
          sWhere = sWhere & " = " & Aux
        End If

        bOperador = True
      End If
    Next

    SqlText = "Delete from " & Tabela & " where " & sWhere

    Return DBExecutar(SqlText)
  End Function

  Public Function DBMontar_Insert(ByVal Tabela As String,
                                  ByVal CampoFixo As TipoCampoFixo,
                                  ByVal ParamArray CampoValor() As Object) As String
    Dim SqlText As String
    Dim Campo As String = String.Empty
    Dim Valor As String = String.Empty
    Dim Aux As String
    Dim bCampo As Boolean

    bCampo = True

    For Each Aux In CampoValor
      If Trim(Aux) <> "" Then
        If bCampo Then
          If Trim(Campo) <> "" Then Campo = Campo & ","
          Campo = Campo + Aux
        Else
          If Trim(Valor) <> "" Then Valor = Valor & ","

          If IsNumeric(Aux) Then
            Valor = Valor + FNC_ConvValorFormatoAmericano(Aux)
          Else
            Valor = Valor + FNC_NuloString(Aux)
          End If
        End If

        bCampo = (Not bCampo)
      End If
    Next

    'If CampoFixo = TipoCampoFixo.Todos Or CampoFixo = TipoCampoFixo.DadoCriacao Then
    '    If Trim(Campo) <> "" Then Campo = Campo & ","
    '    If Trim(Valor) <> "" Then Valor = Valor & ","

    '    Campo = Campo & "dt_Criacao, no_User_Criacao"
    '    Valor = Valor & "sysdate, " & UCase(FNC_QuotedStr(sAcesso_UsuarioLogado))
    'End If

    'If CampoFixo = TipoCampoFixo.Todos Or CampoFixo = TipoCampoFixo.DadoAlteracao Then
    '    If Trim(Campo) <> "" Then Campo = Campo & ","
    '    If Trim(Valor) <> "" Then Valor = Valor & ","

    '    Campo = Campo & "dt_Alteracao, no_User_Alteracao"
    '    Valor = Valor & "sysdate, " & UCase(FNC_QuotedStr(sAcesso_UsuarioLogado))
    'End If

    SqlText = "Insert into " & Tabela & " (" & Campo & ") values (" & Valor & ")"

    Return SqlText
  End Function

  Public Function DBMontar_Update(ByVal Tabela As String,
                                  ByVal CampoValor As Object,
                                  ByVal Where As Object,
                                  Optional ByVal CampoFixo As Boolean = True,
                                  Optional ByVal CampoExclusao As Boolean = False) As String
    Dim SqlText As String
    Dim sCampo As String = String.Empty
    Dim sWhere As String = String.Empty
    Dim Aux As String
    Dim bCampo As Boolean
    Dim bOperador As Boolean

    bCampo = True

    If Not CampoValor Is Nothing Then
      For Each Aux In CampoValor
        If bCampo Then
          If Trim(sCampo) <> "" Then sCampo = sCampo & ","
          sCampo = sCampo + FNC_NuloString(Aux)
        Else
          If IsNumeric(Aux) Then
            sCampo = sCampo & " = " & FNC_ConvValorFormatoAmericano(Aux)
          Else
            sCampo = sCampo & " = " & FNC_NuloString(Aux)
          End If
        End If

        bCampo = (Not bCampo)
      Next
    End If

    bCampo = True

    If Not Where Is Nothing Then
      For Each Aux In Where
        If bCampo Then
          sWhere = sWhere + Aux
          bCampo = False
        ElseIf bOperador Then
          sWhere = sWhere + " " + Aux + " "
          bCampo = True
          bOperador = False
        Else
          If UCase(Aux) = "IS NULL" Then
            sWhere = sWhere & " IS NULL "
          Else
            sWhere = sWhere & " = " & Aux
          End If

          bOperador = True
        End If
      Next
    End If

    'If CampoFixo Then
    '    If Trim(sCampo) <> "" Then sCampo = sCampo + ", "
    '    sCampo = sCampo & "dt_alteracao = sysdate, no_user_alteracao = " & UCase(FNC_QuotedStr(sacesso_usuariologado))
    'End If
    'If CampoExclusao Then
    '    If Trim(sCampo) <> "" Then sCampo = sCampo + ", "
    '    sCampo = sCampo & "dt_exclusao = sysdate, no_user_exclusao = " & UCase(FNC_QuotedStr(sacesso_usuariologado))
    'End If

    SqlText = "Update " & Tabela & " set " & sCampo

    If Trim(sWhere) <> "" Then
      SqlText = SqlText & " where " & sWhere
    End If

    Return SqlText
  End Function

  Public Function DBMontar_Where(ByVal Query As String,
                                 ByVal Campo As String,
                                 ByVal Valor As String) As DBWhere
    Dim oWhere As New DBWhere

    With oWhere
      .Query = Query
      .NomeCampo = Campo
      .ValorCampo = Valor
    End With

    Return oWhere
  End Function

  Public Function DBMontar_SP(ByVal SP As String,
                              ByVal CampoErro As Boolean,
                              ByVal ParamArray Campo() As Object) As String
    Dim SqlText As String
    Dim Parametro As String = String.Empty
    Dim Aux As String

    For Each Aux In Campo
      If Trim(Parametro) <> "" Then Parametro = Parametro & ","

      If IsNumeric(Aux) Then
        Aux = FNC_ConvValorFormatoAmericano(Aux)
      End If

      Parametro = Parametro + Aux
    Next

    If CampoErro Then
      Parametro = Parametro & ", :P_Erro"
    End If

    SqlText = "CALL " & SP & " (" & Parametro & ")"
    SqlText = "EXEC " & SP & "  " & Parametro

    Return SqlText
  End Function

  Public Function DBMontar_Function(ByVal sFunction As String,
                                    ByVal ParamArray Campo() As Object) As String
    Dim SqlText As String
    Dim Parametro As String = String.Empty
    Dim Aux As String

    For Each Aux In Campo
      If Trim(Parametro) <> "" Then Parametro = Parametro & ","

      If IsNumeric(Aux) Then
        Aux = FNC_ConvValorFormatoAmericano(Aux)
      End If

      Parametro = Parametro + Aux
    Next

    SqlText = sFunction & " (" & Parametro & ")"

    Return "BEGIN :RET:= " & SqlText & "; END;"
  End Function

  Public Function DBParametro_Montar(ByVal Nome As String,
                                     ByVal Valor As Object,
                                     Optional ByVal Tipo As SqlDbType = SqlDbType.VarChar,
                                     Optional ByVal Direcao As ParameterDirection =
                                                               ParameterDirection.Input,
                                     Optional ByVal Tamanho As Integer = 0) As DBParamentro
    Dim oPar As New DBParamentro

    With oPar
      .Nome = Nome
      .Valor = Valor
      .Tipo = Tipo
      .Direcao = Direcao

      If Tamanho > -1 Then
        If Tipo = SqlDbType.VarChar And Tamanho = 0 Then
          .Tamanho = 100
        Else
          .Tamanho = Tamanho
        End If
      End If
    End With

    Return oPar
  End Function

  Public Function objDataTable_Vazio(ByVal oData As DataTable) As Boolean
    Dim bVazio As Boolean

    bVazio = True

    If Not oData Is Nothing Then
      If oData.Rows.Count > 0 Then
        bVazio = False
      End If
    End If

    Return bVazio
  End Function

  Public Function objDataTable_CampoVazio(ByVal oCampo As Object) As Boolean
    Return oCampo Is System.DBNull.Value
  End Function

  Public Function DBTeveRetorno() As Boolean
    If oRetorno Is Nothing Then
      Return False
    Else
      Return oRetorno.Count > 0
    End If
  End Function

  Public Sub DBTimeOut_Alterar(iTempo As Integer)
    iDB_TimeOut = iTempo
  End Sub

  Public Sub DBTimeOut_Reiniciar()
    iDB_TimeOut = 30
  End Sub

  Public Function DBRetorno(ByVal Indice As Integer) As String
    If DBTeveRetorno() Then
      If Indice > oRetorno.Count Then
        FNC_Mensagem("Parâmetro inexistente")
        Return Nothing
      Else
        If oRetorno(Indice) Is DBNull.Value Then
          Return ""
        Else
          Return oRetorno(Indice)
        End If
      End If
    Else
      Return ""
    End If
  End Function

  Public Function DBExecutarTransacao(Optional ByVal bCommit As Boolean = True) As Boolean
    If Not bUsarTransacao Then
      Return True
      Exit Function
    End If

    On Error GoTo Erro

    Call LimparErro()

    If bCommit Then
      oTrans.Commit()
    Else
      oTrans.Rollback()
    End If

    oTrans.Dispose()

    bUsarTransacao = False

    Return True

    Exit Function

Erro:
    Call Erro_Tratar("MOD_DB.DBExecutarTransacao")
  End Function

  Public Sub DBBackup()
    Try
      Dim sArquivoBackup As String
      Dim sDB As String = "DBGE"

      sArquivoBackup = FNC_Diretorio_Tratar(sSISTEMA_PathBackupDB) & sDB & "-" & Replace(Replace(Replace(Now.ToString, "/", "-"), ":", "-"), " ", "-") & ".bak"

      ' comando para fazer o backup do Banco de dados
      Dim cmdBackup As New SqlCommand("BACKUP DATABASE [" & sDB & "] TO DISK = '" & sArquivoBackup & "'", oConexao)
      cmdBackup.CommandTimeout = (60 * 10)
      cmdBackup.ExecuteNonQuery()

      FNC_Mensagem("Backup gerado em " & sArquivoBackup)
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    Finally
    End Try
  End Sub
End Module
