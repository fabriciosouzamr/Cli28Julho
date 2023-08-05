Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win

Module modInfragistics
  Public Sub FNC_WinUltraDataSource_Copiar(oUltraDataSource_Origem As UltraDataSource, ByRef oUltraDataSource_Destino As UltraDataSource)
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer

    oUltraDataSource_Destino = New UltraDataSource

    'Adiciona as coluna no destino
    For iCont_01 = 0 To oUltraDataSource_Origem.Band.Columns.Count - 1
      With oUltraDataSource_Destino.Band.Columns.Add(oUltraDataSource_Origem.Band.Columns(iCont_01).Key)
        .DataType = oUltraDataSource_Origem.Band.Columns(iCont_01).DataType
      End With
    Next

    'Adiciona as linhas no destino
    For iCont_01 = 0 To oUltraDataSource_Origem.Rows.Count - 1
      With oUltraDataSource_Destino.Rows.Add()
        For iCont_02 = 0 To oUltraDataSource_Origem.Band.Columns.Count - 1
          .SetCellValue(iCont_02, oUltraDataSource_Origem.Rows(iCont_01).GetCellValue(iCont_02))
        Next
      End With
    Next
  End Sub

  Public Function DDBValueList_Carregar(ByVal SqlText As String, Optional oConexaoQuery As System.Data.Common.DbConnection = Nothing) As ValueList
    Dim oData As DataTable
    Dim iCont As Integer
    Dim oLista As New ValueList

    oData = DBQuery(SqlText, oConexaoQuery)

    If Not objDataTable_Vazio(oData) Then
      For iCont = 0 To oData.Rows.Count - 1
        With oData.Rows(iCont)
          oLista.ValueListItems.Add(.Item(0), .Item(1))
        End With
      Next
    End If

    oData = Nothing

    Return oLista
  End Function

  Public Function DDBValueList_Carregar(ByVal Coluna_Valor() As Object) As ValueList
    Dim iCont As Integer
    Dim oLista As New ValueList

    For iCont = 0 To UBound(Coluna_Valor) Step 2
      oLista.ValueListItems.Add(Coluna_Valor(iCont), Coluna_Valor(iCont + 1))
    Next

    Return oLista
  End Function

  Public Function FNC_WinUltraDataSource_Identico(oUltraDataSource_Origem As UltraDataSource, _
                                                  oUltraDataSource_Destino As UltraDataSource, _
                                                  Optional iLinha As Integer = 0)
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim bOk As Boolean = True

    For iCont_01 = iLinha To IIf(iLinha = 0, oUltraDataSource_Origem.Rows.Count - 1, iLinha)
      For iCont_02 = 0 To oUltraDataSource_Destino.Band.Columns.Count - 1
        If FNC_CampoNulo(oUltraDataSource_Origem.Rows(iCont_01).GetCellValue(iCont_02)) Or _
           FNC_CampoNulo(oUltraDataSource_Destino.Rows(iCont_01).GetCellValue(iCont_02)) Then
          If Not FNC_CampoNulo(oUltraDataSource_Origem.Rows(iCont_01).GetCellValue(iCont_02)) Or _
             Not FNC_CampoNulo(oUltraDataSource_Destino.Rows(iCont_01).GetCellValue(iCont_02)) Then
            bOk = False
            Exit For
          End If
        ElseIf oUltraDataSource_Origem.Rows(iCont_01).GetCellValue(iCont_02) <> oUltraDataSource_Destino.Rows(iCont_01).GetCellValue(iCont_02) Then
          bOk = False
          Exit For
        End If
      Next
    Next

    Return bOk
  End Function
End Module
