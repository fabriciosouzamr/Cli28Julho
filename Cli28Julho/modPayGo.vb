Module PayGo
  Dim Lista As Collection

  Public Function Ativo() As Boolean
    Try
      Lista = New Collection()

      Return True
    Catch ex As Exception
      Return False
    End Try
  End Function

  Private Sub GerarArquivo(Tipo As String)
    Dim sSqlText As String
    Dim PAYGO_IDENTIFICACAO_RET As String

    sSqlText = DBMontar_SP("SP_EMPRESA_ESTACAO_PAYGO_IDENTIFICACAO", False, "@SQ_EMPRESA_ESTACAO",
                                                                            "@PAYGO_IDENTIFICACAO_RET OUT")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_EMPRESA_ESTACAO", iESTACAO_TRABALHO_SQ_EMPRESA_ESTACAO),
                            DBParametro_Montar("PAYGO_IDENTIFICACAO_RET", iID_EMPRESA_FILIAL, , ParameterDirection.InputOutput)) Then
      If DBTeveRetorno() Then
        PAYGO_IDENTIFICACAO_RET = DBRetorno(1)
      End If
    End If
  End Sub
End Module