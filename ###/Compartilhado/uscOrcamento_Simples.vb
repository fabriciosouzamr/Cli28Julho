Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class uscOrcamento_Simples
  Public Event Fechar()

  Enum enFormato
    Cadastro = 1
    Interno = 2
  End Enum

  Const const_GridOrcamentoProduto_SQ_PEDIDO_PRODUTO As Integer = 0
  Const const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA As Integer = 1
  Const const_GridOrcamentoProduto_ID_PRODUTO_LINHA As Integer = 2
  Const const_GridOrcamentoProduto_ProdutoLinha As Integer = 3
  Const const_GridOrcamentoProduto_NomeProduto As Integer = 4
  Const const_GridOrcamentoProduto_Quantidade As Integer = 5
  Const const_GridOrcamentoProduto_ValorUnitario As Integer = 6
  Const const_GridOrcamentoProduto_ValorTotal As Integer = 7
  Const const_GridOrcamentoProduto_UnidadeMedida As Integer = 8
  Const const_GridOrcamentoProduto_ValorUnitario_Sugerido As Integer = 9

  Const const_GridOrcamentoFinanciamento_SQ_FINANCIAMENTO As Integer = 0
  Const const_GridOrcamentoFinanciamento_ID_MODELODOCUMENTO_CONTRATO As Integer = 1
  Const const_GridOrcamentoFinanciamento_Chk As Integer = 2
  Const const_GridOrcamentoFinanciamento_BTNContrato As Integer = 3
  Const const_GridOrcamentoFinanciamento_NO_FINANCIAMENTO As Integer = 4
  Const const_GridOrcamentoFinanciamento_NO_FINANCIADOR As Integer = 5
  Const const_GridOrcamentoFinanciamento_PC_ENTRADA As Integer = 6
  Const const_GridOrcamentoFinanciamento_PC_JUROS As Integer = 7
  Const const_GridOrcamentoFinanciamento_NR_MINIMO_PARCELA As Integer = 8
  Const const_GridOrcamentoFinanciamento_NR_MAXIMO_PARCELA As Integer = 9
  Const const_GridOrcamentoFinanciamento_IC_PROPRIO As Integer = 10

  Const const_GridOrcamentoParcelamento_NR_Parcela As Integer = 0

  Public iID_PESSOA As Integer
  Public iSQ_PEDIDO_ORCAMENTO As Integer

  Dim cOrcamentoProdutoExcluir As Collection

  Dim oDBGridOrcamento_Produto As New UltraWinDataSource.UltraDataSource
  Dim oDBGridOrcamento_Financiamento As New UltraWinDataSource.UltraDataSource
  Dim oDBGridOrcamento_Parcelamento As New UltraWinDataSource.UltraDataSource

  Dim bEmProcessamento As Boolean
  Dim eFormato As enFormato = enFormato.Cadastro

  Public Property Formato() As enFormato
    Get
      Return eFormato
    End Get
    Set(value As enFormato)
      eFormato = value

      Formatar()
    End Set
  End Property

  Private Sub Formatar()
    cmdOrcamentoImprimirTodos.Left = IIf(eFormato = enFormato.Cadastro, 967, 967)
    cmdOrcamentoImprimirTodos.Top = IIf(eFormato = enFormato.Cadastro, 366, 332)
    cmdOrcamentoImprimir.Left = IIf(eFormato = enFormato.Cadastro, 967, 968)
    cmdOrcamentoImprimir.Top = IIf(eFormato = enFormato.Cadastro, 400, 366)
    cmdOrcamentoImprimirFinanciamento.Left = IIf(eFormato = enFormato.Cadastro, 1074, 1074)
    cmdOrcamentoImprimirFinanciamento.Top = IIf(eFormato = enFormato.Cadastro, 400, 366)
    cmdOrcamentoNovo.Left = IIf(eFormato = enFormato.Cadastro, 943, 968)
    cmdOrcamentoNovo.Top = IIf(eFormato = enFormato.Cadastro, 438, 400)
    cmdOrcamentoGravar.Left = IIf(eFormato = enFormato.Cadastro, 1024, 1049)
    cmdOrcamentoGravar.Top = IIf(eFormato = enFormato.Cadastro, 438, 400)
    Me.Width = IIf(eFormato = enFormato.Cadastro, 1180, 1180)
    Me.Height = IIf(eFormato = enFormato.Cadastro, 465, 427)
    cmdOrcamentoFechar.Visible = (eFormato = enFormato.Cadastro)
  End Sub

  Private Function CarregarPrecoUnitario(bPRODUTO_LINHA As Boolean,
                                         iID_PRODUTO As Integer) As Double
    Dim dRet As Double = 0

    If ComboBox_Selecionado(cboOrcamentoTabelaPreco) Then
      Dim sSqlText As String
      Dim oData As DataTable

      If bPRODUTO_LINHA Then
        sSqlText = "SELECT ISNULL(VL_VENDA, 0) VL_VENDA FROM VW_TABELAPRECO_PRODUTO_LINHA" &
                   " WHERE ID_TABELAPRECO = " & cboOrcamentoTabelaPreco.SelectedValue &
                   " AND ID_PRODUTO_LINHA = " & iID_PRODUTO
      Else
        sSqlText = "SELECT ISNULL(VL_VENDA, 0) VL_VENDA FROM VW_TABELAPRECO_PRODUTO_ATIVO" &
                   " WHERE ID_TABELAPRECO = " & cboOrcamentoTabelaPreco.SelectedValue &
                     " AND ID_PRODUTO_EMPRESA = " & iID_PRODUTO
      End If

      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        dRet = oData.Rows(0).Item("VL_VENDA")
      End If
    End If

    Return dRet
  End Function

  Private Sub cmdOrcamentoImprimir_Click(sender As Object, e As EventArgs) Handles cmdOrcamentoImprimir.Click
    FormRelatorioOrcamento(iSQ_PEDIDO_ORCAMENTO)
  End Sub

  Private Sub cboOrcamentoTabelaPreco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrcamentoTabelaPreco.SelectedIndexChanged
    Orcamento_AtualizarPrecoUnitario()
  End Sub

  Private Sub Orcamento_AtualizarPrecoUnitario()
    Dim iCont As Integer
    Dim sSqlText As String
    Dim oData As DataTable

    If ComboBox_Selecionado(cboOrcamentoTabelaPreco) Then
      For iCont = 0 To grdOrcamentoProdutos.Rows.Count - 1
        With grdOrcamentoProdutos.Rows(iCont)
          If FNC_NVL(.Cells(const_GridOrcamentoProduto_ID_PRODUTO_LINHA).Value, 0) > 0 Then
            sSqlText = "SELECT ISNULL(VL_VENDA, 0) VL_VENDA FROM TB_TABELAPRECO_PRODUTO_LINHA" &
                       " WHERE ID_TABELAPRECO = " & cboOrcamentoTabelaPreco.SelectedValue &
                         " AND ID_PRODUTO_LINHA = " & FNC_NVL(.Cells(const_GridOrcamentoProduto_ID_PRODUTO_LINHA).Value, 0)
          Else
            sSqlText = "SELECT ISNULL(VL_VENDA, 0) VL_VENDA FROM VW_TABELAPRECO_PRODUTO_ATIVO" &
                       " WHERE ID_TABELAPRECO = " & cboOrcamentoTabelaPreco.SelectedValue &
                         " AND ID_PRODUTO_EMPRESA = " & FNC_NVL(.Cells(const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA).Value, 0)
          End If

          oData = DBQuery(sSqlText)

          If Not objDataTable_Vazio(oData) Then
            If oData.Rows(0).Item("VL_VENDA") > 0 Then
              If (FNC_NVL(.Cells(const_GridOrcamentoProduto_ValorUnitario).Value, 0) =
                  FNC_NVL(.Cells(const_GridOrcamentoProduto_ValorUnitario_Sugerido).Value, 0)) Or
                 (FNC_NVL(.Cells(const_GridOrcamentoProduto_ValorUnitario_Sugerido).Value, 0) = 0) Then
                .Cells(const_GridOrcamentoProduto_ValorUnitario_Sugerido).Value = oData.Rows(0).Item("VL_VENDA")
                .Cells(const_GridOrcamentoProduto_ValorUnitario).Value = oData.Rows(0).Item("VL_VENDA")

                .Cells(const_GridOrcamentoProduto_ValorTotal).Value = FNC_NVL(.Cells(const_GridOrcamentoProduto_Quantidade).Value, 0) *
                                                                      FNC_NVL(.Cells(const_GridOrcamentoProduto_ValorUnitario).Value, 0)
              End If
            End If
          End If
        End With
      Next
    End If
  End Sub

  Private Sub grdOrcamentoFinanciamento_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdOrcamentoFinanciamento.BeforeCellActivate
    e.Cancel = ((FNC_NVL(e.Cell.Row.Cells(const_GridOrcamentoFinanciamento_IC_PROPRIO).Value, "N") = "S") And
                FNC_In(e.Cell.Column.Index, const_GridOrcamentoFinanciamento_PC_ENTRADA, const_GridOrcamentoFinanciamento_PC_JUROS))
  End Sub

  Private Sub cmdOrcamentoNovo_Click(sender As Object, e As EventArgs) Handles cmdOrcamentoNovo.Click
    OrcamentoNovo()
  End Sub

  Public Sub OrcamentoNovo(Optional ID_PESSOA As Integer = 0)
    If ID_PESSOA > 0 Then iID_PESSOA = ID_PESSOA

    cmdOrcamentoNovo.Visible = (iSQ_PEDIDO_ORCAMENTO = 0)

    cboOrcamentosCriados.SelectedIndex = -1
    cboOrcamentoTabelaPreco.SelectedIndex = -1
    txtDataValidade.Value = Now().AddDays(iEMPRESA_NR_DIA_VALIDADEORCAMENTO)
    txtPercEntrada.Value = 0
    lblValorEntrada.Text = "0.00"

    cOrcamentoProdutoExcluir = New Collection
    oDBGridOrcamento_Produto.Rows.Clear()

    CarregarOrcamentoParcelamento()
    CarregarOrcamentosCriados()

    cmdOrcamentoImprimir.Enabled = False
    cmdOrcamentoImprimirFinanciamento.Enabled = False
    cmdOrcamentoImprimirTodos.Enabled = False

    If iSQ_PEDIDO_ORCAMENTO > 0 Then
      ComboBox_Selecionar(cboOrcamentosCriados, iSQ_PEDIDO_ORCAMENTO)
    End If
  End Sub

  Private Sub CarregarOrcamentosCriados()
    Dim sSqlText As String

    bEmProcessamento = True

    sSqlText = "SELECT SQ_PEDIDO, CD_ORCAMENTO + ' - Data: ' + CONVERT(varchar(10), DH_PEDIDO, 103) + ' - Validade: ' + CONVERT(varchar(10), DT_VALIDADE, 103) DS_ORCAMENTO" &
               " FROM TB_PEDIDO" &
               " WHERE ID_PESSOA = " + iID_PESSOA.ToString() &
                 " AND ID_OPT_TIPOPEDIDO = " & enOpcoes.TipoPedido_OrcamentoVenda.GetHashCode().ToString() &
               " ORDER BY DS_ORCAMENTO"
    DBComboBox_Carregar(cboOrcamentosCriados, sSqlText)

    bEmProcessamento = False
  End Sub

  Private Sub cboOrcamentosCriados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrcamentosCriados.SelectedIndexChanged
    If bEmProcessamento Then Exit Sub

    If ComboBox_Selecionado(cboOrcamentosCriados) Then
      Dim oData As DataTable
      Dim sSqlText As String
      Dim iCont_01 As Integer
      Dim iCont_02 As Integer
      Dim bAchou As Boolean

      iSQ_PEDIDO_ORCAMENTO = cboOrcamentosCriados.SelectedValue

      sSqlText = "SELECT * FROM TB_PEDIDO WHERE SQ_PEDIDO = " & cboOrcamentosCriados.SelectedValue
      oData = DBQuery(sSqlText)

      With oData.Rows(0)
        ComboBox_Selecionar(cboOrcamentoTabelaPreco, .Item("ID_TABELAPRECO"))
        txtDataValidade.Value = .Item("DT_VALIDADE")
        txtPercEntrada.Value = FNC_NVL(.Item("PC_ENTRADA"), 0)
      End With

      sSqlText = "SELECT SQ_PEDIDO_PRODUTO," &
                        "ID_PRODUTO_EMPRESA," &
                        "ID_PRODUTO_LINHA," &
                        "NO_PRODUTO_LINHA," &
                        "NO_PRODUTO," &
                        "QT_ORCAMENTO," &
                        "VL_UNITARIO," &
                        "QT_ORCAMENTO * VL_UNITARIO," &
                        "ID_UNIDADEMEDIDA," &
                        "VL_UNITARIO" &
                 " FROM VW_PEDIDO_PRODUTO" &
                 " WHERE ID_PEDIDO = " & cboOrcamentosCriados.SelectedValue &
                   " AND ID_OPT_STATUS <> " & enOpcoes.StatusItemPedido_Cancelado.GetHashCode()
      objGrid_Carregar(grdOrcamentoProdutos, sSqlText, New Integer() {const_GridOrcamentoProduto_SQ_PEDIDO_PRODUTO,
                                                                      const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA,
                                                                      const_GridOrcamentoProduto_ID_PRODUTO_LINHA,
                                                                      const_GridOrcamentoProduto_ProdutoLinha,
                                                                      const_GridOrcamentoProduto_NomeProduto,
                                                                      const_GridOrcamentoProduto_Quantidade,
                                                                      const_GridOrcamentoProduto_ValorUnitario,
                                                                      const_GridOrcamentoProduto_ValorTotal,
                                                                      const_GridOrcamentoProduto_UnidadeMedida,
                                                                      const_GridOrcamentoProduto_ValorUnitario_Sugerido})

      For iCont_01 = 0 To grdOrcamentoProdutos.Rows.Count - 1
        With grdOrcamentoProdutos.Rows(iCont_01)
          If objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_LINHA, iCont_01, 0) > 0 Then
            grdOrcamentoProdutos.DisplayLayout.Bands(0).Columns(const_GridOrcamentoProduto_ProdutoLinha).Hidden = False
            .Cells(const_GridOrcamentoProduto_NomeProduto).ValueList = FNC_CarregarLista(enTipoCadastro.Produto_LinhaProduto, FNC_NVL(.Cells(const_GridOrcamentoProduto_ID_PRODUTO_LINHA).Value, 0))
            .Cells(const_GridOrcamentoProduto_NomeProduto).Value = .Cells(const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA).Value
          End If
        End With
      Next

      sSqlText = "SELECT * FROM TB_PEDIDO_FINANCIAMENTO WHERE ID_PEDIDO = " & cboOrcamentosCriados.SelectedValue
      oData = DBQuery(sSqlText)

      For iCont_01 = 0 To grdOrcamentoFinanciamento.Rows.Count - 1
        bAchou = False

        For iCont_02 = 0 To oData.Rows.Count - 1
          If objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_SQ_FINANCIAMENTO, iCont_01) =
             oData.Rows(iCont_02).Item("ID_FINANCIAMENTO") Then
            With grdOrcamentoFinanciamento.Rows(iCont_02)
              .Cells(const_GridOrcamentoFinanciamento_Chk).Value = True
              .Cells(const_GridOrcamentoFinanciamento_PC_ENTRADA).Value = oData.Rows(iCont_02).Item("PC_ENTRADA")
              .Cells(const_GridOrcamentoFinanciamento_PC_JUROS).Value = oData.Rows(iCont_02).Item("PC_JUROS")
            End With

            bAchou = True

            Exit For
          End If
        Next

        If Not bAchou Then
          grdOrcamentoFinanciamento.Rows(iCont_02).Cells(const_GridOrcamentoFinanciamento_Chk).Value = False
        End If
      Next
    End If

    cmdOrcamentoImprimir.Enabled = ComboBox_Selecionado(cboOrcamentosCriados)
    cmdOrcamentoImprimirFinanciamento.Enabled = ComboBox_Selecionado(cboOrcamentosCriados)
    cmdOrcamentoImprimirTodos.Enabled = ComboBox_Selecionado(cboOrcamentosCriados)

    CarregarOrcamentoParcelamento()
    Orcamento_Calculo()
  End Sub

  Private Sub cmdOrcamentoImprimirFinanciamento_Click(sender As Object, e As EventArgs) Handles cmdOrcamentoImprimirFinanciamento.Click
    FormRelatorioOrcamentoFinanciamento(iSQ_PEDIDO_ORCAMENTO)
  End Sub

  Private Sub cmdOrcamentoImprimirTodos_Click(sender As Object, e As EventArgs) Handles cmdOrcamentoImprimirTodos.Click
    FormRelatorioOrcamento(iSQ_PEDIDO_ORCAMENTO)
    FormRelatorioOrcamentoFinanciamento(iSQ_PEDIDO_ORCAMENTO)
  End Sub

  Private Sub grdOrcamentoProdutos_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdOrcamentoProdutos.BeforeRowsDeleted
    e.DisplayPromptMsg = False

    If FNC_NVL(e.Rows(0).Cells(const_GridOrcamentoProduto_ID_PRODUTO_LINHA).Value, 0) = 0 Then
      If Not FNC_Perguntar("Deseja realmente excluir o produto " & e.Rows(0).Cells(const_GridOrcamentoProduto_NomeProduto).Text & "?") Then
        e.Cancel = True
      End If
    Else
      If Not FNC_Perguntar("Deseja realmente excluir a linha de produto " & e.Rows(0).Cells(const_GridOrcamentoProduto_ProdutoLinha).Text & "?") Then
        e.Cancel = True
      End If
    End If

    If Not e.Cancel Then
      If FNC_NVL(e.Rows(0).Cells(const_GridOrcamentoProduto_SQ_PEDIDO_PRODUTO).Value, 0) > 0 Then
        cOrcamentoProdutoExcluir.Add(e.Rows(0).Cells(const_GridOrcamentoProduto_SQ_PEDIDO_PRODUTO).Value)
      End If
    End If
  End Sub

  Private Sub grdOrcamentoProdutos_AfterRowsDeleted(sender As Object, e As EventArgs) Handles grdOrcamentoProdutos.AfterRowsDeleted
    CarregarOrcamentoParcelamento()
    Orcamento_Calculo()
  End Sub

  Private Sub grdOrcamentoProdutos_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdOrcamentoProdutos.BeforeCellActivate
    If e.Cell.Column.Index = const_GridOrcamentoProduto_NomeProduto Then
      e.Cancel = (e.Cell.ValueList Is Nothing)
    ElseIf FNC_In(e.Cell.Column.Index, const_GridOrcamentoProduto_ProdutoLinha, const_GridOrcamentoProduto_ValorTotal) Then
      e.Cancel = True
    End If
  End Sub

  Private Sub grdOrcamentoProdutos_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdOrcamentoProdutos.AfterCellUpdate
    If FNC_In(e.Cell.Column.Index, const_GridOrcamentoProduto_Quantidade, const_GridOrcamentoProduto_ValorUnitario) Then
      e.Cell.Row.Cells(const_GridOrcamentoProduto_ValorTotal).Value = e.Cell.Row.Cells(const_GridOrcamentoProduto_ValorUnitario).Value *
                                                                      e.Cell.Row.Cells(const_GridOrcamentoProduto_Quantidade).Value
      Orcamento_Calculo()
      CarregarOrcamentoParcelamento()
    End If
  End Sub

  Private Sub grdOrcamentoFinanciamento_ClickCellButton(sender As Object, e As CellEventArgs) Handles grdOrcamentoFinanciamento.ClickCellButton
    If FNC_NVL(e.Cell.Row.Cells(const_GridOrcamentoFinanciamento_ID_MODELODOCUMENTO_CONTRATO).Value, 0) = 0 Then
      FNC_Mensagem("Nao existe nenhum modelo de contrato associado a esse financiamento")
    Else
      Dim oDoc As New ExtendedRichTextBox.RichTextBoxPrintCtrl
      Dim iID_MODELO_CABECALHO As Integer
      Dim iID_MODELO_ASSINATURA As Integer
      Dim iID_MODELO_RODAPE As Integer
      Dim bExibirNumeroPagina As Boolean

      ModeloDocumento_Carregar(oDoc,
                               FNC_NVL(e.Cell.Row.Cells(const_GridOrcamentoFinanciamento_ID_MODELODOCUMENTO_CONTRATO).Value, 0),
                               iID_MODELO_CABECALHO,
                               iID_MODELO_ASSINATURA,
                               iID_MODELO_RODAPE,
                               bExibirNumeroPagina,
                               iSQ_PEDIDO_ORCAMENTO)

      FNC_RichTextBoxDocument_Visualizar(Nothing, oDoc, iID_MODELO_CABECALHO, iID_MODELO_ASSINATURA, iID_MODELO_RODAPE, bExibirNumeroPagina)

      oDoc.Dispose()
      oDoc = Nothing
    End If
  End Sub

  Private Sub Orcamento_Calculo()
    lblOrcamentoResumo_ValorTotalNota.Text = FormatCurrency(objGrid_CalcularTotalColuna(grdOrcamentoProdutos, const_GridOrcamentoProduto_ValorTotal))
    lblOrcamentoResumo_Quantidade.Text = objGrid_CalcularTotalColuna(grdOrcamentoProdutos, const_GridOrcamentoProduto_Quantidade)
  End Sub

  Private Sub txtOrcamentoProduto_ValorTotal_ValueChanged(sender As Object, e As EventArgs)
    Orcamento_Calculo()
  End Sub

  Private Sub cmdOrcamentoGravar_Click(sender As Object, e As EventArgs) Handles cmdOrcamentoGravar.Click
    Dim iCont_01 As Integer = 0

    If iID_PESSOA = 0 Then
      FNC_Mensagem("É preciso informar o paciente")
      Exit Sub
    End If
    If grdOrcamentoProdutos.Rows.Count = 0 Then
      FNC_Mensagem("É preciso informar algum produto para essa cotação")
      Exit Sub
    End If
    If Val(FNC_SoNumero(lblOrcamentoResumo_ValorTotalNota.Text)) = 0 Then
      FNC_Mensagem("Informe o valor total da cotação")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboOrcamentoTabelaPreco) Then
      FNC_Mensagem("Selecione a tabela de preço")
      Exit Sub
    End If
    For iCont_01 = 0 To grdOrcamentoProdutos.Rows.Count - 1
      If FNC_NVL(objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA, iCont_01, 0), 0) = 0 And
         FNC_NVL(objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_LINHA, iCont_01, 0), 0) = 0 Then
        FNC_Mensagem("É preciso cadastrar todos os produtos/linhas de produto")
        Exit Sub
      End If
    Next
    For iCont_01 = 0 To grdOrcamentoProdutos.Rows.Count - 1
      If FNC_NVL(objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_UnidadeMedida, iCont_01, 0), 0) = 0 Then
        FNC_Mensagem("É preciso selecionar unidade de medida para todos os produtos")
        Exit Sub
      End If
    Next
    For iCont_01 = 0 To grdOrcamentoFinanciamento.Rows.Count - 1
      If objGrid_CheckBox_Selecionado(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_Chk, iCont_01) Then
        If Not FNC_Busca_Financiamento_TabelaPreco_Existe(FNC_NVL(cboOrcamentoTabelaPreco.SelectedValue, 0),
                                                          objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_SQ_FINANCIAMENTO, iCont_01, 0)) Then
          FNC_Mensagem("O financiamento '" & objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_NO_FINANCIAMENTO, iCont_01, 0) & "' não está liberado para essa tabela de preço")
          Exit Sub
        End If
      End If
      If FNC_NVL(objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoProduto_UnidadeMedida, iCont_01, 0), 0) = 0 Then
        FNC_Mensagem("É preciso selecionar unidade de medida para todos os produtos")
        Exit Sub
      End If
    Next

    Dim iCont_02 As Integer = 0
    Dim iSQ_PEDIDO_PRODUTO As Integer
    Dim iID_PRODUTO_EMPRESA As Integer
    Dim sSqlText As String

    DBUsarTransacao = True

    '>> Cabeçalho da NFe
    If FormCadastroPedido(iSQ_PEDIDO:=iSQ_PEDIDO_ORCAMENTO,
                          iID_EMPRESA:=iID_EMPRESA_FILIAL,
                          iID_PESSOA:=iID_PESSOA,
                          iID_ENDERECO:=Nothing,
                          iID_ENDERECO_RETIRADA:=Nothing,
                          iID_PESSOATELEFONE:=Nothing,
                          iID_PESSOA_MIDIASOCIAL_EMAIL:=Nothing,
                          iID_OPT_TIPOPEDIDO:=enOpcoes.TipoPedido_OrcamentoVenda.GetHashCode(),
                          iID_PESSOA_VENDEDOR:=iID_USUARIO,
                          iID_NATUREZAOPERACAO:=Nothing,
                          iID_OPT_FRETE:=Nothing,
                          iID_PESSOA_TRANSPORTADORA:=Nothing,
                          iID_ENDERECO_TRANSPORTADORA:=Nothing,
                          iID_PESSOATELEFONE_TRANSPORTADORA:=Nothing,
                          iID_OPT_STATUS:=enOpcoes.StatusPedido_Gerada.GetHashCode(),
                          iID_SEGMENTO:=Nothing,
                          iID_CANALNEGOCIO:=Nothing,
                          iID_TABELAPRECO:=cboOrcamentoTabelaPreco.SelectedValue,
                          iID_PEDIDOVENDA_ORIGEM:=Nothing,
                          iID_CONDICAOPAGAMENTO:=Nothing,
                          iID_CONTAFINANCEIRA:=Nothing,
                          iID_DOCUMENTOFISCAL_TIPO:=0,
                          sCD_PEDIDO:=Nothing,
                          sCD_ORCAMENTO:=Nothing,
                          dDH_PEDIDO:=Nothing,
                          dDH_PREVISAO_ENTREGA:=Nothing,
                          dDT_VALIDADE:=txtDataValidade.DateTime.Date,
                          dVL_ACRESCIMO:=0,
                          dVL_DESCONTO_ORCAMENTO:=0,
                          dVL_DESCONTO:=0,
                          dVL_FRETE:=0,
                          dVL_OUTRAS_DESPESAS:=0,
                          dVL_SEGURO:=0,
                          dQT_PESO_BRUTO:=0,
                          dQT_PESO_LIQUIDO:=0,
                          dQT_VOLUMES:=0,
                          dPC_ENTRADA:=FNC_NVL(txtPercEntrada.Value, 0),
                          sDS_ESPECIE:=Nothing,
                          sDS_INFORMACOES_ADICIONAIS:=Nothing) Then
      If DBTeveRetorno() Then
        iSQ_PEDIDO_ORCAMENTO = DBRetorno(1)
      End If

      '>> Produtos - Gravar
      For iCont_01 = 0 To grdOrcamentoProdutos.Rows.Count - 1
        With grdOrcamentoProdutos.Rows(iCont_01)
          iSQ_PEDIDO_PRODUTO = FNC_NVL(.Cells(const_GridOrcamentoProduto_SQ_PEDIDO_PRODUTO).Value, 0)

          If FNC_NVL(.Cells(const_GridOrcamentoProduto_ID_PRODUTO_LINHA).Value, 0) = 0 Then
            iID_PRODUTO_EMPRESA = FNC_NVL(.Cells(const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA).Value, 0)
          Else
            iID_PRODUTO_EMPRESA = FNC_NVL(.Cells(const_GridOrcamentoProduto_NomeProduto).Value, 0)
          End If

          If FormCadastroPedidoProduto(iSQ_PEDIDO_PRODUTO,
                                       iSQ_PEDIDO_ORCAMENTO,
                                       iID_PRODUTO_EMPRESA,
                                       FNC_NuloZero(.Cells(const_GridOrcamentoProduto_ID_PRODUTO_LINHA).Value, False),
                                       FNC_NuloZero(.Cells(const_GridOrcamentoProduto_UnidadeMedida).Value, False),
                                       enOpcoes.StatusItemPedido_Incluido.GetHashCode(),
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       Nothing,
                                       iCont_01 + 1,
                                       Nothing,
                                       CDbl(.Cells(const_GridOrcamentoProduto_Quantidade).Value),
                                       0,
                                       0,
                                       0,
                                       CDbl(.Cells(const_GridOrcamentoProduto_ValorUnitario).Value),
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       Nothing) Then
            If DBTeveRetorno() Then
              iSQ_PEDIDO_PRODUTO = DBRetorno(1)
            End If
          End If
        End With
      Next

      For iCont_01 = 1 To cOrcamentoProdutoExcluir.Count
        sSqlText = DBMontar_SP("SP_PEDIDO_PRODUTO_CCL", False, "@SQ_PEDIDO_PRODUTO")
        DBExecutar(sSqlText, DBParametro_Montar("SQ_PEDIDO_PRODUTO", cOrcamentoProdutoExcluir(iCont_01)))
      Next

      For iCont_01 = 0 To grdOrcamentoFinanciamento.Rows.Count - 1
        If objGrid_CheckBox_Selecionado(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_Chk, iCont_01) Then
          sSqlText = DBMontar_SP("SP_PEDIDO_FINANCIAMENTO_CAD", False, "@ID_PEDIDO",
                                                                       "@ID_FINANCIAMENTO",
                                                                       "@ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS",
                                                                       "@PC_ENTRADA",
                                                                       "@PC_JUROS")
          DBExecutar(sSqlText, DBParametro_Montar("ID_PEDIDO", iSQ_PEDIDO_ORCAMENTO),
                               DBParametro_Montar("ID_FINANCIAMENTO", objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_SQ_FINANCIAMENTO, iCont_01)),
                               DBParametro_Montar("ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS", enOpcoes.PeriodoCalculoFinanceiro_AoMes.GetHashCode()),
                               DBParametro_Montar("PC_ENTRADA", objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_PC_ENTRADA, iCont_01)),
                               DBParametro_Montar("PC_JUROS", objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_PC_JUROS, iCont_01)))
        Else
          sSqlText = DBMontar_SP("SP_PEDIDO_FINANCIAMENTO_DEL", False, "@ID_PEDIDO",
                                                                       "@ID_FINANCIAMENTO")
          DBExecutar(sSqlText, DBParametro_Montar("ID_PEDIDO", iSQ_PEDIDO_ORCAMENTO),
                               DBParametro_Montar("ID_FINANCIAMENTO", objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_SQ_FINANCIAMENTO, iCont_01)))
        End If
      Next

      DBExecutarTransacao()

      cOrcamentoProdutoExcluir = New Collection

      cmdOrcamentoImprimir.Enabled = True
      cmdOrcamentoImprimirFinanciamento.Enabled = True
      cmdOrcamentoImprimirTodos.Enabled = True

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub CarregarFinanciamento()
    Dim sSqlText As String

    sSqlText = "SELECT SQ_FINANCIAMENTO," &
                      "ID_MODELODOCUMENTO_CONTRATO," &
                      "NO_FINANCIAMENTO," &
                      "NO_FINANCIADOR," &
                      "PC_ENTRADA," &
                      "PC_JUROS," &
                      "NR_MINIMO_PARCELA," &
                      "NR_MAXIMO_PARCELA," &
                      "IC_PROPRIO" &
               " FROM VW_FINANCIAMENTO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND ISNULL(IC_ATIVO, 'N') = 'S'" &
               " ORDER BY IC_PROPRIO DESC," &
                         "NO_FINANCIAMENTO"
    objGrid_Carregar(grdOrcamentoFinanciamento, sSqlText, New Integer() {const_GridOrcamentoFinanciamento_SQ_FINANCIAMENTO,
                                                                         const_GridOrcamentoFinanciamento_ID_MODELODOCUMENTO_CONTRATO,
                                                                         const_GridOrcamentoFinanciamento_NO_FINANCIAMENTO,
                                                                         const_GridOrcamentoFinanciamento_NO_FINANCIADOR,
                                                                         const_GridOrcamentoFinanciamento_PC_ENTRADA,
                                                                         const_GridOrcamentoFinanciamento_PC_JUROS,
                                                                         const_GridOrcamentoFinanciamento_NR_MINIMO_PARCELA,
                                                                         const_GridOrcamentoFinanciamento_NR_MAXIMO_PARCELA,
                                                                         const_GridOrcamentoFinanciamento_IC_PROPRIO})
  End Sub

  Private Sub grdOrcamentoFinanciamento_AfterRowActivate(sender As Object, e As EventArgs) Handles grdOrcamentoFinanciamento.AfterRowActivate
    CarregarOrcamentoFinanciamento()
  End Sub

  Private Sub CarregarOrcamentoParcelamento()
    Dim iCont As Integer

    objGrid_Inicializar(grdOrcamentoParcelamento, , oDBGridOrcamento_Parcelamento, UltraWinGrid.CellClickAction.EditAndSelectText, , DefaultableBoolean.True, False, , , , True, , , False)
    objGrid_Coluna_Add(grdOrcamentoParcelamento, "Nº de Parcelas", 100)

    For iCont = 0 To grdOrcamentoProdutos.Rows.Count - 1
      If FNC_NVL(objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_LINHA, iCont), 0) = 0 Then
        objGrid_Coluna_Add(grdOrcamentoParcelamento, objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_NomeProduto, iCont), 200,,, ,, const_Formato_Valor).Tag = FNC_NVL(objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA, iCont),
                                                                                                                                                                                      objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_LINHA, iCont))
      Else
        objGrid_Coluna_Add(grdOrcamentoParcelamento, objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ProdutoLinha, iCont), 200,,, ,, const_Formato_Valor).Tag = FNC_NVL(objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA, iCont),
                                                                                                                                                                                       objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_LINHA, iCont))
      End If
    Next

    CarregarOrcamentoFinanciamento()
  End Sub

  Private Sub CarregarOrcamentoFinanciamento()
    If objGrid_LinhaSelecionada(grdOrcamentoFinanciamento) > -1 Then
      oDBGridOrcamento_Parcelamento.Rows.Clear()

      Dim iCont_01 As Integer
      Dim iCont_02 As Integer
      Dim iCont_03 As Integer
      Dim iNR_MINIMO_PARCELA As Integer
      Dim iNR_MAXIMO_PARCELA As Integer
      Dim dPC_JURO_MES As Double
      Dim oRow As UltraWinDataSource.UltraDataRow

      iNR_MINIMO_PARCELA = objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_NR_MINIMO_PARCELA,, 0)
      iNR_MAXIMO_PARCELA = objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_NR_MAXIMO_PARCELA,, 0)
      dPC_JURO_MES = Val(objGrid_Valor(grdOrcamentoFinanciamento, const_GridOrcamentoFinanciamento_PC_JUROS,, 0)) / 100

      For iCont_01 = iNR_MINIMO_PARCELA To iNR_MAXIMO_PARCELA
        oRow = objGrid_Linha_Add(grdOrcamentoParcelamento, New Object() {const_GridOrcamentoParcelamento_NR_Parcela, iCont_01})
      Next

      For iCont_01 = 0 To grdOrcamentoParcelamento.Rows.Count - 1
        For iCont_02 = 1 To grdOrcamentoParcelamento.DisplayLayout.Bands(0).Columns.Count - 1
          For iCont_03 = 0 To grdOrcamentoProdutos.Rows.Count - 1
            If grdOrcamentoParcelamento.DisplayLayout.Bands(0).Columns(iCont_02).Tag = FNC_NVL(objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA, iCont_03),
                                                                                               objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ID_PRODUTO_LINHA, iCont_03)) Then
              grdOrcamentoParcelamento.Rows(iCont_01).Cells(iCont_02).Value = Financial.Pmt(dPC_JURO_MES,
                                                                                            objGrid_Valor(grdOrcamentoParcelamento, const_GridOrcamentoParcelamento_NR_Parcela, iCont_01),
                                                                                            Val(objGrid_Valor(grdOrcamentoProdutos, const_GridOrcamentoProduto_ValorTotal, iCont_03))) * -1
            End If
          Next
        Next
      Next
    End If
  End Sub

  Public Sub Inicializar()
    If iSQ_PEDIDO_ORCAMENTO = 0 Then
      ComboBox_Carregar(cboOrcamentoTabelaPreco, enSql.TabelaPreco_Ativa)
    Else
      ComboBox_Carregar(cboOrcamentoTabelaPreco, enSql.TabelaPreco)
    End If

    objGrid_Inicializar(grdOrcamentoProdutos, , oDBGridOrcamento_Produto, UltraWinGrid.CellClickAction.EditAndSelectText, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdOrcamentoProdutos, "SQ_PEDIDO_PRODUTO", 0)
    objGrid_Coluna_Add(grdOrcamentoProdutos, "ID_PRODUTO_EMPRESA", 0)
    objGrid_Coluna_Add(grdOrcamentoProdutos, "ID_PRODUTO_LINHA", 0)
    objGrid_Coluna_Add(grdOrcamentoProdutos, "Linha de Produto", 300).Hidden = True
    objGrid_Coluna_Add(grdOrcamentoProdutos, "Nome do Produto", 300)
    objGrid_Coluna_Add(grdOrcamentoProdutos, "Quantidade", 100, , , ColumnStyle.Double)
    objGrid_Coluna_Add(grdOrcamentoProdutos, "Valor Unitário", 100, , , ColumnStyle.Currency,  , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdOrcamentoProdutos, "Valor Total", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdOrcamentoProdutos, "Unidade de Medida", 200, , , , FNC_CarregarLista(enTipoCadastro.UnidadeMedida))
    objGrid_Coluna_Add(grdOrcamentoProdutos, "ValorUnitario_Sugerido", 0)
    objGrid_Configuracao_Carregar(grdOrcamentoProdutos, Me.Name)

    objGrid_Inicializar(grdOrcamentoFinanciamento, , oDBGridOrcamento_Financiamento, UltraWinGrid.CellClickAction.EditAndSelectText, , DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "SQ_FINANCIAMENTO", 0)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "ID_MODELODOCUMENTO_CONTRATO", 0)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "Sel.", 50, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "Ctr.", 50, , True, ColumnStyle.Button)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "Nome do Financiamento", 300,, False)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "Nome do Financiador", 300,, False)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "Entrada", 70, , True, ColumnStyle.Double)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "Juros (m)", 70, , True, ColumnStyle.Double)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "Nº de Máx. Parcela", 100, , False)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "Nº de Min. Parcela", 100, , False)
    objGrid_Coluna_Add(grdOrcamentoFinanciamento, "IC_PROPRIO", 0)
    objGrid_Configuracao_Carregar(grdOrcamentoFinanciamento, Me.Name)

    CarregarOrcamentoParcelamento()
    CarregarFinanciamento()

    OrcamentoNovo()

    Formatar()
  End Sub

  Public Sub Finalizar()
    objGrid_Configuracao_Gravar(grdOrcamentoProdutos, Me.Name)
    objGrid_Configuracao_Gravar(grdOrcamentoFinanciamento, Me.Name)
  End Sub

  Private Sub cmdOrcamentoFechar_Click(sender As Object, e As EventArgs) Handles cmdOrcamentoFechar.Click
    RaiseEvent Fechar()
  End Sub

  Private Sub txtProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProduto.KeyDown
    If Trim(txtProduto.Text) <> "" And e.KeyCode = Keys.Enter Then
      Dim oForm As New frmpsqProduto
      Dim iCont As Integer

      oForm.sFiltro = txtProduto.Text
      oForm.ListarLinhaProduto = True
      oForm.MultiploSelecao = True

      FNC_AbriTela(oForm,, True, True)

      For iCont = 0 To oForm.SQ_PRODUTO.Length - 1
        If oForm.SQ_PRODUTO(iCont) > 0 Then
          Dim oRow As UltraWinDataSource.UltraDataRow
          Dim dValorUnitario_Sugerido As Double

          dValorUnitario_Sugerido = CarregarPrecoUnitario(oForm.PRODUTO_LINHA(iCont),
                                                          oForm.SQ_PRODUTO_EMPRESA(iCont))

          oRow = objGrid_Linha_Add(grdOrcamentoProdutos, New Object() {const_GridOrcamentoProduto_SQ_PEDIDO_PRODUTO, 0,
                                                                       const_GridOrcamentoProduto_ID_PRODUTO_EMPRESA, IIf(oForm.PRODUTO_LINHA(iCont), 0, oForm.SQ_PRODUTO_EMPRESA(iCont)),
                                                                       const_GridOrcamentoProduto_ID_PRODUTO_LINHA, IIf(oForm.PRODUTO_LINHA(iCont), oForm.SQ_PRODUTO_EMPRESA(iCont), 0),
                                                                       const_GridOrcamentoProduto_ProdutoLinha, IIf(oForm.PRODUTO_LINHA(iCont), oForm.NO_PRODUTO(iCont), ""),
                                                                       const_GridOrcamentoProduto_NomeProduto, IIf(oForm.PRODUTO_LINHA(iCont), "", oForm.NO_PRODUTO(iCont)),
                                                                       const_GridOrcamentoProduto_Quantidade, 1,
                                                                       const_GridOrcamentoProduto_ValorUnitario, dValorUnitario_Sugerido,
                                                                       const_GridOrcamentoProduto_ValorUnitario_Sugerido, dValorUnitario_Sugerido,
                                                                       const_GridOrcamentoProduto_ValorTotal, dValorUnitario_Sugerido,
                                                                       const_GridOrcamentoProduto_UnidadeMedida, oForm.ID_UNIDADEMEDIDA(iCont)})

          If oForm.PRODUTO_LINHA(iCont) Then
            grdOrcamentoProdutos.DisplayLayout.Bands(0).Columns(const_GridOrcamentoProduto_ProdutoLinha).Hidden = False

            With grdOrcamentoProdutos.Rows(oRow.Index)
              .Cells(const_GridOrcamentoProduto_NomeProduto).ValueList = FNC_CarregarLista(enTipoCadastro.Produto_LinhaProduto, FNC_NVL(.Cells(const_GridOrcamentoProduto_ID_PRODUTO_LINHA).Value, 0))
            End With
          End If
        End If
      Next

      Orcamento_Calculo()
      CarregarOrcamentoParcelamento()
    End If
  End Sub
End Class
