Module modSistemaComercial
  Public Function FNC_DB_Endereco_Buscar(iID_Pessoa As Integer,
                                         sCidade_IBGE As String,
                                         sBairro As String,
                                         sLogradouro As String,
                                         sNumero As String) As Integer
    Dim sSqlText As String

    If iID_Pessoa = 0 Or
       sCidade_IBGE.Trim() = "" Or
       sBairro.Trim() = "" Or
       sLogradouro.Trim() = "" Or
       sNumero.Trim() = "" Then
      Return 0
    Else
      sSqlText = "SELECT SQ_ENDERECO" &
                 " FROM VW_ENDERECO" &
                 " WHERE ID_PESSOA = " & iID_Pessoa &
                   " AND CD_IBGE = " & FNC_QuotedStr(sCidade_IBGE) &
                   " AND NO_BAIRRO = " & FNC_QuotedStr(sBairro.Trim()) &
                   " AND DS_ENDERECO = " & FNC_QuotedStr(sLogradouro.Trim()) &
                   " AND NR_LOGRADOURO = " & FNC_QuotedStr(sNumero.Trim())

      Return DBQuery_ValorUnico(sSqlText)
    End If
  End Function

  Public Function FNC_DB_Telefone_Buscar(iID_Pessoa As Integer,
                                         sDDD As String,
                                         sNumero As String) As Integer
    Dim sSqlText As String

    If iID_Pessoa = 0 Or
       sNumero.Trim() = "" Then
      Return 0
    Else
      If sDDD.Trim() <> "" Then
        sNumero = "(" & sDDD.Trim() & ") " & sNumero
      End If

      sSqlText = "SELECT SQ_PESSOA_TELEFONE" &
                 " FROM TB_PESSOA_TELEFONE" &
                 " WHERE ID_PESSOA = " & iID_Pessoa &
                   " AND CD_NUMERO = " & FNC_QuotedStr(sNumero)

      Return DBQuery_ValorUnico(sSqlText)
    End If
  End Function
End Module