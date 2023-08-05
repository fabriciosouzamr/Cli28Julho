Public Class uscVoucher
  Class cVoucher
    Public SQ_VOUCHER As Double
    Public VL_SALDO As Double
    Public Adicionado As Boolean = False
  End Class

  Dim dValorSaldo As Double

  Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
    If e.KeyCode = Keys.KeyCode.Enter Then
      If Trim(txtCodigo.Text) <> "" Then
        Dim sSqlText As String
        Dim oData As DataTable
        Dim oVoucher As cVoucher
        Dim bValido As Boolean = False

        sSqlText = "SELECT SQ_VOUCHER, VL_VOUCHER - VL_MOVIMENTADO - VL_CANCELADO VL_SALDO FROM TB_VOUCHER WHERE CD_VOUCHER = " + FNC_QuotedStr(txtCodigo.Text)
        oData = DBQuery(sSqlText)

        If objDataTable_Vazio(oData) Then
          FNC_Mensagem("O código informado é inválido")
        Else
          If Convert.ToDouble(oData.Rows(0).Item("VL_SALDO")) > 0 Then
            bValido = True
            dValorSaldo = dValorSaldo + Convert.ToDouble(oData.Rows(0).Item("VL_SALDO"))
            oVoucher = New cVoucher
            oVoucher.SQ_VOUCHER = oData.Rows(0).Item("SQ_VOUCHER")
            oVoucher.VL_SALDO = oData.Rows(0).Item("VL_SALDO")

            mnuVouvher.Items.Add(txtCodigo.Text + " " + FormatCurrency(Convert.ToDouble(oData.Rows(0).Item("VL_SALDO")))).Tag = oVoucher

            lblNumeroVoucher.Text = FNC_StrZero(mnuVouvher.Items.Count, 2)
          Else
            FNC_Mensagem("O voucher informado não tem saldo")
          End If
          lblSaldo.Text = FormatCurrency(dValorSaldo)

          txtCodigo.SelectAll()
        End If

        If Not bValido Then
          txtCodigo.Text = ""
        End If
      End If
    End If
  End Sub

  Public Sub Limpar()
    dValorSaldo = 0
    lblSaldo.Text = ""
    lblNumeroVoucher.Text = "00"
  End Sub

  Public Sub Salvar(iID_AGENDAMENTO As Integer, iID_CLINICA_VENDA As Integer, dValor As Double)
    Dim dSaldo As Double = dValor
    Dim dMovimentado As Double
    Dim oVoucher As cVoucher

    If mnuVouvher.Items.Count > 0 Then
      For Each oItem As ToolStripItem In mnuVouvher.Items
        oVoucher = oItem.Tag

        If oVoucher.VL_SALDO < dSaldo Then
          dMovimentado = oVoucher.VL_SALDO
        Else
          dMovimentado = dSaldo
        End If

        If Not oVoucher.Adicionado Then
          Dim sSqlText As String

          sSqlText = DBMontar_SP("SP_VOUCHER_MOVIMENTADO_UPD", False, "@SQ_VOUCHER",
                                                                      "@ID_AGENDAMENTO",
                                                                      "@ID_CLINICA_VENDA",
                                                                      "@VL_MOVIMENTADO",
                                                                      "@ID_USUARIO",
                                                                      "@ID_EMPRESA")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_VOUCHER", oVoucher.SQ_VOUCHER),
                               DBParametro_Montar("ID_AGENDAMENTO", FNC_NuloZero(iID_AGENDAMENTO, False)),
                               DBParametro_Montar("ID_CLINICA_VENDA", FNC_NuloZero(iID_CLINICA_VENDA, False)),
                               DBParametro_Montar("VL_MOVIMENTADO", dMovimentado),
                               DBParametro_Montar("ID_USUARIO", iID_USUARIO),
                               DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL))
        End If

        dSaldo = dSaldo - dMovimentado

        If dSaldo <= 0 Then Exit For
      Next
    End If
  End Sub

  Public Function ValorEmVoucher(dValor As Double) As Double
    Dim dSaldo As Double = dValor
    Dim dMovimentado As Double
    Dim oVoucher As cVoucher

    If mnuVouvher.Items.Count > 0 Then
      For Each oItem As ToolStripItem In mnuVouvher.Items
        oVoucher = oItem.Tag

        If oVoucher.VL_SALDO < dSaldo Then
          dMovimentado = oVoucher.VL_SALDO
        Else
          dMovimentado = dSaldo
        End If

        dSaldo = dSaldo - dMovimentado

        If dSaldo <= 0 Then Exit For
      Next
    End If

    Return dMovimentado
  End Function

  Public Sub Carregar(oID_AGENDAMENTO As Object)
    Dim oVoucher As cVoucher
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT VL.ID_AGENDAMENTO, VL.ID_VOUCHER, VC.CD_VOUCHER, SUM(VL.VL_LANCAMENTO) VL_LANCAMENTO" &
               " FROM TB_VOUCHER_LANCAMENTO VL" &
                " INNER JOIN TB_VOUCHER VC ON VC.SQ_VOUCHER = VL.ID_VOUCHER" &
               " WHERE VL.ID_AGENDAMENTO IN (" & oID_AGENDAMENTO.ToString().Replace("-", ",") & ")" &
               " GROUP BY VL.ID_AGENDAMENTO, VL.ID_VOUCHER, VC.CD_VOUCHER" &
               " HAVING SUM(VL.VL_LANCAMENTO) > 0"
    oData = DBQuery(sSqlText)

    For Each oRow As DataRow In oData.Rows
      oVoucher = New cVoucher
      oVoucher.SQ_VOUCHER = oRow.Item("ID_VOUCHER")
      oVoucher.VL_SALDO = oRow.Item("VL_LANCAMENTO")
      oVoucher.Adicionado = True
      dValorSaldo = dValorSaldo + oRow.Item("VL_LANCAMENTO")

      mnuVouvher.Items.Add(oRow.Item("CD_VOUCHER") + " " + FormatCurrency(Convert.ToDouble(oRow.Item("VL_LANCAMENTO")))).Tag = oVoucher
    Next

    lblSaldo.Text = FormatCurrency(dValorSaldo)
  End Sub
End Class