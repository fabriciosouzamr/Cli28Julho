Imports Infragistics.Win

Public Class frmConsultaContasReceberPagar_Transferir
  Const const_GridListagem_NO_TIPODOCUMENTO As Integer = 0
  Const const_GridListagem_VL_TIPODOCUMENTO As Integer = 1

  Public Class MOVFINANCEIRA
    Public SQ_MOVFINANCEIRAPARCELA As Integer
    Public NO_TIPODOCUMENTO As String
    Public VL_MOVFINANCEIRA As Double
  End Class

  Dim oMOVFINANCEIRA() As MOVFINANCEIRA

  Dim oDBGrid As New Infragistics.Win.UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Public Sub Carregar()
    Dim iCont As Integer
    Dim bAchou As Boolean

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "Tipo de Documento", 200)
    objGrid_Coluna_Add(grdListagem, "Valor do Tipo de Documento", 200, , , , , const_Formato_Valor)

    For Each oItem_MOVFINANCEIRA As MOVFINANCEIRA In oMOVFINANCEIRA
      bAchou = False

      For iCont = 0 To grdListagem.Rows.Count - 1
        With grdListagem.Rows(iCont)
          If oItem_MOVFINANCEIRA.NO_TIPODOCUMENTO = .Cells(const_GridListagem_NO_TIPODOCUMENTO).Value Then
            bAchou = True
            .Cells(const_GridListagem_VL_TIPODOCUMENTO).Value = FNC_NuloZero(.Cells(const_GridListagem_VL_TIPODOCUMENTO).Value) + oItem_MOVFINANCEIRA.VL_MOVFINANCEIRA
            Exit For
          End If
        End With
      Next

      If Not bAchou Then
        objGrid_Linha_Add(grdListagem, New Object() {const_GridListagem_NO_TIPODOCUMENTO, oItem_MOVFINANCEIRA.NO_TIPODOCUMENTO.Trim(),
                                                     const_GridListagem_VL_TIPODOCUMENTO, oItem_MOVFINANCEIRA.VL_MOVFINANCEIRA})
      End If
    Next

    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VL_TIPODOCUMENTO})
  End Sub

  Public Sub MOVFINANCEIRA_Adicionar(SQ_MOVFINANCEIRA As Integer, NO_TIPODOCUMENTO As String, VL_MOVFINANCEIRA As Double)
    If oMOVFINANCEIRA Is Nothing Then
      ReDim oMOVFINANCEIRA(0)
    Else
      ReDim Preserve oMOVFINANCEIRA(oMOVFINANCEIRA.Length)
    End If

    oMOVFINANCEIRA(oMOVFINANCEIRA.Length - 1) = New MOVFINANCEIRA()

    With oMOVFINANCEIRA(oMOVFINANCEIRA.Length - 1)
      .SQ_MOVFINANCEIRAPARCELA = SQ_MOVFINANCEIRA
      .NO_TIPODOCUMENTO = NO_TIPODOCUMENTO
      .VL_MOVFINANCEIRA = VL_MOVFINANCEIRA
    End With

    lblQuantidadeTitulos.Tag = FNC_NVL(lblQuantidadeTitulos.Tag, 0) + 1
    lblValorTotalTransferencia.Tag = FNC_NVL(lblValorTotalTransferencia.Tag, 0) + VL_MOVFINANCEIRA

    lblQuantidadeTitulos.Text = lblQuantidadeTitulos.Tag.ToString()
    lblValorTotalTransferencia.Text = FormatCurrency(lblValorTotalTransferencia.Tag, 2)
  End Sub

  Private Sub frmConsultaContasReceberPagar_Transferir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboContaCaixa, enSql.ContaCaixa, New Object() {iID_USUARIO})
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If FNC_NuloZero(lblQuantidadeTitulos.Tag) = 0 Then
      FNC_Mensagem("Não existe(m) título(s) a ser(em) transferido(s).")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboContaCaixa) Then
      FNC_Mensagem("Selecione a conta caixa de destino")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim bITEM_NAO_TRANSFERIDO As Boolean

    sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_TRANSFERIR", False, "@SQ_MOVFINANCEIRAPARCELA",
                                                                        "@ID_CONTAFINANCEIRA",
                                                                        "@TP_TRANSFERIDO OUT")

    For Each oItem_MOVFINANCEIRA As MOVFINANCEIRA In oMOVFINANCEIRA
      DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA", oItem_MOVFINANCEIRA.SQ_MOVFINANCEIRAPARCELA),
                           DBParametro_Montar("ID_CONTAFINANCEIRA", cboContaCaixa.SelectedValue),
                           DBParametro_Montar("TP_TRANSFERIDO", Nothing, , ParameterDirection.Output))

      If DBTeveRetorno() Then
        bITEM_NAO_TRANSFERIDO = (DBRetorno(1) = "N" Or bITEM_NAO_TRANSFERIDO)
      End If
    Next

    If bITEM_NAO_TRANSFERIDO Then
      FNC_Mensagem("Nem todas as movimentações foram transferidas")
    End If

    cmdGravar.Enabled = False
  End Sub
End Class