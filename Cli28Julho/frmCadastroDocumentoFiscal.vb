Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmCadastroDocumentoFiscal
    Const const_GridProduto_SQ_DOCUMENTOFISCAL_PRODUTO As Integer = 0
    Const const_GridProduto_ID_PRODUTO_EMPRESA As Integer = 1
    Const const_GridProduto_ID_PEDIDO_PRODUTO As Integer = 2
    Const const_GridProduto_ID_CFOP As Integer = 3
    Const const_GridProduto_ID_CSOSN As Integer = 4
    Const const_GridProduto_ID_CST As Integer = 5
    Const const_GridProduto_ID_NCM As Integer = 6
    Const const_GridProduto_NomeProduto As Integer = 7
    Const const_GridProduto_Quantidade As Integer = 8
    Const const_GridProduto_ValorUnitario As Integer = 9
    Const const_GridProduto_ValorDesconto As Integer = 10
    Const const_GridProduto_ValorTotal As Integer = 11
    Const const_GridProduto_CFOP As Integer = 12
    Const const_GridProduto_CSOSN As Integer = 13
    Const const_GridProduto_CST As Integer = 14
    Const const_GridProduto_NCM As Integer = 15
    Const const_GridProduto_ICMS As Integer = 16
    Const const_GridProduto_ICMS_Subst As Integer = 17
    Const const_GridProduto_PIS As Integer = 18
    Const const_GridProduto_Cofins As Integer = 19
    Const const_GridProduto_IPI As Integer = 20
    Const const_GridProduto_II As Integer = 21
    Const const_GridProduto_IC_CONTROLA_NUMERO_SERIE As Integer = 22
    Const const_GridProduto_TransacaoEstoque As Integer = 23
    Const const_GridProduto_UnidadeMedida As Integer = 24
    Const const_GridProduto_SQ_ESTOQUE_LOCALIZACAO As Integer = 25
    Const const_GridProduto_IC_TOTALIZA As Integer = 26
    Const const_GridProduto_NR_INDEX_XML As Integer = 27

    Const const_GridProdutoNumeroSerie_ID_PRODUTO_EMPRESA As Integer = 0
    Const const_GridProdutoNumeroSerie_NO_PRODUTO As Integer = 1
    Const const_GridProdutoNumeroSerie_Quantidade As Integer = 2

    Const const_GridNumeroSerie_ID_PRODUTO_EMPRESA As Integer = 0
    Const const_GridNumeroSerie_STATUS As Integer = 1
    Const const_GridNumeroSerie_Sel As Integer = 2
    Const const_GridNumeroSerie_CD_NUMERO_SERIE As Integer = 3

    Const const_StatusNumeroSerie_Excluido As Integer = 1

    Public iSQ_DOCUMENTOFISCAL As Integer
    Public bCopiar As Boolean
    Public bDevolver As Boolean

    Dim iID_OPT_STATUS As Integer
    Dim sDS_PATH_XML As String

    Dim iGridProduto_LinhaEdicao As Integer = -1
    Dim oDBGridProduto As New UltraWinDataSource.UltraDataSource
    Dim oDBGridProdutoNumeroSerie As New UltraWinDataSource.UltraDataSource
    Dim oDBGridNumeroSerie As New UltraWinDataSource.UltraDataSource

    Dim bIC_CONTROLA_NUMERO_SERIE As Boolean
    Dim iID_UNIDADEMEDIDA As Integer
    Dim bAdicionandoProduto As Boolean

    Dim bEmProcessamento As Boolean

    Dim cProdutos_Remover As New Collection

    Private Sub frmCadastroDocumentoFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objGrid_Inicializar(grdProdutos, , oDBGridProduto, UltraWinGrid.CellClickAction.EditAndSelectText, , DefaultableBoolean.True, False, , , , True)
        objGrid_Coluna_Add(grdProdutos, "SQ_DOCUMENTOFISCAL_PRODUTO", 100)
        objGrid_Coluna_Add(grdProdutos, "ID_PRODUTO_EMPRESA", 0)
        objGrid_Coluna_Add(grdProdutos, "ID_PEDIDO_PRODUTO", 0)
        objGrid_Coluna_Add(grdProdutos, "ID_CFOP", 0)
        objGrid_Coluna_Add(grdProdutos, "ID_CSOSN", 0)
        objGrid_Coluna_Add(grdProdutos, "ID_CST", 0)
        objGrid_Coluna_Add(grdProdutos, "ID_NCM", 0)
        objGrid_Coluna_Add(grdProdutos, "Nome do Produto", 300)
        objGrid_Coluna_Add(grdProdutos, "Quantidade", 100, , True, ColumnStyle.Double)
        objGrid_Coluna_Add(grdProdutos, "Valor Unitário", 100, , True, ColumnStyle.Currency,  , const_Formato_Valor_4casas)
        objGrid_Coluna_Add(grdProdutos, "Valor Desconto", 100, , , ColumnStyle.Currency,  , const_Formato_Valor_4casas)
        objGrid_Coluna_Add(grdProdutos, "Valor Total", 100, , , ColumnStyle.Currency, , const_Formato_Valor_4casas)
        objGrid_Coluna_Add(grdProdutos, "CFOP", 80)
        objGrid_Coluna_Add(grdProdutos, "CSOSN", 80)
        objGrid_Coluna_Add(grdProdutos, "CST", 80)
        objGrid_Coluna_Add(grdProdutos, "NCM", 80)
        objGrid_Coluna_Add(grdProdutos, "ICMS %", 80, , True, ColumnStyle.Double)
        objGrid_Coluna_Add(grdProdutos, "ICMS Subst %", 80, , True, ColumnStyle.Double)
        objGrid_Coluna_Add(grdProdutos, "PIS%", 80, , True, ColumnStyle.Double)
        objGrid_Coluna_Add(grdProdutos, "COFINS%", 80, , True, ColumnStyle.Double)
        objGrid_Coluna_Add(grdProdutos, "IPI %", 80, , True, ColumnStyle.Double)
        objGrid_Coluna_Add(grdProdutos, "II %", 80, , True, ColumnStyle.Double)
        objGrid_Coluna_Add(grdProdutos, "Ctrl. Nº Série", 80)
        objGrid_Coluna_Add(grdProdutos, "Transação de Estoque", 300, , True, , FNC_CarregarLista(enTipoCadastro.TransacaoEstoque_Venda))
        objGrid_Coluna_Add(grdProdutos, "Unidade de Medida", 200, , True, , FNC_CarregarLista(enTipoCadastro.UnidadeMedida))
        objGrid_Coluna_Add(grdProdutos, "SQ_ESTOQUE_LOCALIZACAO", 0)
        objGrid_Coluna_Add(grdProdutos, "IC_TOTALIZA", 0)
        objGrid_Coluna_Add(grdProdutos, "NR_INDEX_XML", 0)
        objGrid_Configuracao_Carregar(grdProdutos, Me.Name)

        objGrid_Inicializar(grdProdutoNumeroSerie, , oDBGridProdutoNumeroSerie, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True, , , False)
        objGrid_Coluna_Add(grdProdutoNumeroSerie, "SQ_PRODUTO", 0)
        objGrid_Coluna_Add(grdProdutoNumeroSerie, "Nome do Produto", 350)
        objGrid_Coluna_Add(grdProdutoNumeroSerie, "Quantidade", 150)

        objGrid_Inicializar(grdNumeroSerie, AllowAddNew.FixedAddRowOnTop, oDBGridNumeroSerie, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True, , , False)
        objGrid_Coluna_Add(grdNumeroSerie, "SQ_PRODUTO", 0)
        objGrid_Coluna_Add(grdNumeroSerie, "STATUS", 0)
        objGrid_Coluna_Add(grdNumeroSerie, "Sel.", 50, , True, ColumnStyle.CheckBox)
        objGrid_Coluna_Add(grdNumeroSerie, "Número de Série", 330, , False)

        UltraComboBox_Inicializar(cboCFOP, 550)
        UltraComboBox_Inicializar(cboProduto_CFOP, 550)
        UltraComboBox_Inicializar(cboProduto_CST, 700)
        UltraComboBox_Inicializar(cboProduto_CSOSN, 550)

        ComboBox_Carregar(cboNaturezaOperacao, enSql.NaturezaOperacao)
        ComboBox_Carregar(cboTabelaPreco, enSql.TabelaPreco_Ativa)
        ComboBox_Carregar(cboTransacaoEstoque, enSql.TransacaoEstoque_Recebimento)
        ComboBox_Carregar(cboTipoDocumentoFiscal, enSql.TipoDocumentoFiscal)
        ComboBox_Carregar(cboTipoFrete, enSql.TipoFrete)
        ComboBox_Carregar(cboUFPlaca, enSql.UF_Codigo)
        ComboBox_Carregar(cboUFPlaca2, enSql.UF_Codigo)

        UltraComboBox_Carregar(cboProduto_CST, enSql.CST)
        UltraComboBox_Carregar(cboProduto_CSOSN, enSql.CSOSN)

        ComboBox_Selecionar(cboTipoFrete, enOpcoes.TipoFrete_SemFrete.GetHashCode())

        txtDataDocumentoFiscal.DateTime = Now()

        tbpNumerosSeries.Visible = False

        DocumentoFiscal_Gravado(False)

        If iSQ_DOCUMENTOFISCAL > 0 Then
            CarregarDados()
        End If

        lblREmail.Visible = True
        lblRTelefone.Visible = True
        lblREmail.BringToFront()
        lblRTelefone.BringToFront()

        TextBox_FormatarCampoTexto(txtInformacaoComplementar, const_Controle_TamanhoComentario_DocumentoFiscal)
    End Sub

    Private Sub DocumentoFiscal_Gravado(bGravado As Boolean)
        cmdImprimir.Visible = bGravado
        cmdHistorico.Visible = bGravado
    End Sub

    Private Sub psqPessoa_SelectedIndexChanged() Handles psqPessoa.SelectedIndexChanged
        FormCadastroPessoa_CarregarEnderecoTelefoneEMail(psqPessoa.ID_Pessoa,
                                                         cboEmail,
                                                         cboTelefone,
                                                         cboEnderecoFaturamento,
                                                         psqPessoa)
    End Sub

    Private Sub psqTransportadora_SelectedIndexChanged() Handles psqTransportadora.SelectedIndexChanged
        FormCadastroPessoa_CarregarEnderecoTelefoneEMail(psqTransportadora.ID_Pessoa,
                                                         Nothing,
                                                         cboTelefoneTransportadora,
                                                         cboEnderecoTransportadora,
                                                         psqTransportadora)
    End Sub

    Private Sub cmdAdicionarEnderecoFaturamento_Click(sender As Object, e As EventArgs) Handles cmdAdicionarEnderecoFaturamento.Click
        If psqPessoa.Selecionado Then
            Dim iSQ_ENDERECO As Integer

            If FormPesquisaPessoa_Cadastro(psqPessoa.ID_Pessoa, True, iSQ_ENDERECO) Then
                FormCadastroPessoa_CarregarEnderecoPessoa(psqPessoa.ID_Pessoa, cboEnderecoFaturamento)
                ComboBox_Selecionar(cboEnderecoFaturamento, iSQ_ENDERECO)
            End If
        Else
            FNC_Mensagem("É preciso carregar a pessoa referente a esse endereço")
        End If
    End Sub

    Private Sub cboTipoDocumentoFiscal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDocumentoFiscal.SelectedIndexChanged
        ComboBox_TipoDocumentoFiscal_Tratar()
    End Sub

    Private Sub ComboBox_TipoDocumentoFiscal_Tratar()
        FormCadastroDocumentoFiscal_TipoDocumentoFiscal_Carregar(cboTipoDocumentoFiscal, cboSerieDocumentoFiscal, lblInfoDocumentoFiscal)

        Try
            Select Case cboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.ID_OPT_NFE_TIPOOPERACAO)
                Case enOpcoes.NFe_TipoOperacao_Entrada.GetHashCode()
                    ComboBox_Carregar(cboTransacaoEstoque, enSql.TransacaoEstoque_Recebimento)
                    grdProdutos.DisplayLayout.Bands(0).Columns(const_GridProduto_TransacaoEstoque).ValueList = FNC_CarregarLista(enTipoCadastro.TransacaoEstoque_Recebimento)
                Case enOpcoes.NFe_TipoOperacao_Saida.GetHashCode()
                    ComboBox_Carregar(cboTransacaoEstoque, enSql.TransacaoEstoque_Venda)
                    grdProdutos.DisplayLayout.Bands(0).Columns(const_GridProduto_TransacaoEstoque).ValueList = FNC_CarregarLista(enTipoCadastro.TransacaoEstoque_Venda)
                Case Else
                    cboTransacaoEstoque.DataSource = Nothing
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TipoDocumentoFiscal_Carregar()
        If ComboBox_Selecionado(cboTipoDocumentoFiscal) Then
            lblInfoDocumentoFiscal.Text = cboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.CD_DOCUMENTOFISCAL_TIPO).ToString() +
                                          "/Mod: " + cboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.CD_SERVICO_MODELO).ToString() +
                                          "/Versão " + cboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.CD_SERVICO_VERSAO).ToString()

            ComboBox_Carregar(cboSerieDocumentoFiscal, enSql.SerieDocumentoFiscal, New Object() {cboTipoDocumentoFiscal.SelectedValue})
        Else
            lblInfoDocumentoFiscal.Text = ""
            cboSerieDocumentoFiscal.DataSource = Nothing
        End If
    End Sub

    Private Sub cmdAdicionarEnderecoTransportadora_Click(sender As Object, e As EventArgs) Handles cmdAdicionarEnderecoTransportadora.Click
        If psqTransportadora.Selecionado Then
            Dim iSQ_ENDERECO As Integer

            If FormPesquisaPessoa_Cadastro(psqTransportadora.ID_Pessoa, True, iSQ_ENDERECO) Then
                FormCadastroPessoa_CarregarEnderecoPessoa(psqPessoa.ID_Pessoa, cboEnderecoTransportadora)
                ComboBox_Selecionar(cboEnderecoFaturamento, iSQ_ENDERECO)
            End If
        Else
            FNC_Mensagem("É preciso carregar a transportadora referente a esse endereço")
        End If
    End Sub

    Private Sub psqProduto_ItemSelecionado(sender As Object, e As EventArgs) Handles psqProduto.ItemSelecionado
        If psqProduto.Identificador > 0 Then
            Dim oData As DataTable
            Dim sSqlText As String

            sSqlText = "SELECT * FROM VW_PRODUTO_EMPRESA_FILIAL" &
                       " WHERE ID_PRODUTO = " & psqProduto.Identificador &
                         " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL
            oData = DBQuery(sSqlText)

            If Not objDataTable_Vazio(oData) Then
                With oData.Rows(0)
                    UltraComboBox_Selecionar(cboProduto_CFOP, enCombox_CFOP.SQ_CFOP, UltraComboBox_Valor(cboCFOP))
                    UltraComboBox_Selecionar(cboProduto_CST, enCombox_CST.SQ_CST, FNC_NVL(.Item("ID_CST"), 0))
                    UltraComboBox_Selecionar(cboProduto_CSOSN, enCombox_CSOSN.SQ_CSOSN, FNC_NVL(.Item("ID_CSOSN"), 0))
                    txtProduto_IPI.Value = FNC_NVL(.Item("PC_IPI"), 0)
                    bIC_CONTROLA_NUMERO_SERIE = (.Item("IC_CONTROLA_NUMERO_SERIE") = "S")
                    iID_UNIDADEMEDIDA = FNC_NVL(.Item("ID_UNIDADEMEDIDA"), 0)
                    FormCadastroPedidoNCMLabel(lblNCM_Descricao, FNC_NVL(.Item("ID_NCM"), 0), Trim(FNC_NVL(.Item("CD_NCM"), "").ToString()), Trim(FNC_NVL(.Item("DS_NCM"), "")))

                    ComboBox_Selecionar(cboTransacaoEstoque, FNC_NVL(.Item("ID_TRANSACAOESTOQUE_PADRAO_VENDAS"), iEMPRESA_ID_TRANSACAOESTOQUE_PADRAO_VENDAS))
                End With
            End If

            txtProduto_ValorUnitario.Value = FNC_Busca_TabelaPreco_Produto_Ativo(FNC_NVL(cboTabelaPreco.SelectedValue, 0), psqProduto.Identificador)
        End If
    End Sub

    Private Sub cboEnderecoFaturamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEnderecoFaturamento.SelectedIndexChanged
        FormCadastroDocumentoFiscal_CFOP_Carregar(cboNaturezaOperacao, cboEnderecoFaturamento, cboCFOP, cboProduto_CFOP)
    End Sub

    Private Sub cboNaturezaOperacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNaturezaOperacao.SelectedIndexChanged
        FormCadastroDocumentoFiscal_CFOP_Carregar(cboNaturezaOperacao, cboEnderecoFaturamento, cboCFOP, cboProduto_CFOP)
    End Sub

    Private Sub Produto_CalcularTotal()
        If bEmProcessamento Then Exit Sub

        Try
            txtProduto_ValorTotal.Value = txtProduto_Quantidade.Value * txtProduto_ValorUnitario.Value

            'Validar valor de desconto
            If txtProduto_ValorDesconto.Value > txtProduto_ValorTotal.Value Then
                FNC_Mensagem("O valor de desconto de produto não pode ser maior que o valor total")
                txtProduto_ValorDesconto.Value = 0
            Else
                txtProduto_ValorTotal.Value = txtProduto_ValorTotal.Value - txtProduto_ValorDesconto.Value
            End If
        Catch ex As Exception
            txtProduto_ValorTotal.Value = 0
        End Try
    End Sub

    Private Sub txtProduto_Quantidade_ValueChanged(sender As Object, e As EventArgs) Handles txtProduto_Quantidade.ValueChanged
        Produto_CalcularTotal()
    End Sub

    Private Sub txtProduto_ValorUnitario_ValueChanged(sender As Object, e As EventArgs) Handles txtProduto_ValorUnitario.ValueChanged
        Produto_CalcularTotal()
    End Sub

    Private Sub cmdAdicionarProduto_Click(sender As Object, e As EventArgs) Handles cmdAdicionarProduto.Click
        If psqProduto.Identificador = 0 Then
            FNC_Mensagem("Carregue e selecione o produto a ser adicionado")
            Exit Sub
        End If
        If txtProduto_Quantidade.Value <= 0 Then
            FNC_Mensagem("Informe a quantidade do produto")
            Exit Sub
        End If
        If txtProduto_ValorUnitario.Value <= 0 Then
            FNC_Mensagem("Informe o valor unitário do produto")
            Exit Sub
        End If
        'If Not ComboBox_Selecionado(cboTransacaoEstoque) Then
        '  FNC_Mensagem("Carregue e selecione a transção de estoque do produto a ser adicionado")
        '  Exit Sub
        'End If
        If Not UltraComboBox_Selecionado(cboProduto_CFOP) Then
            FNC_Mensagem("Selecione o C.F.O.P. padrão do pedido antes")
            Exit Sub
        End If
        'If FNC_NVL(cboTransacaoEstoque.SelectedItem(enCombobox_TransacaoEstoque.IC_ESTOQUE_DEBITO_PERMITE_SALDO_NEGATIVO), "N") = "N" Then
        '  If SaldoEstoque_Consultar() < txtProduto_Quantidade.Value + objGrid_CalcularTotalColuna(grdProdutos,
        '                                                                                          const_GridProduto_Quantidade,
        '                                                                                          grdTipoCalculoTotal.SomarValor,
        '                                                                                          New Object() {const_GridProdutoNumeroSerie_ID_PRODUTO_EMPRESA, psqProduto.Identificador_Filial}) Then
        '    FNC_Mensagem("O saldo de estoque está menor que a quantidade informada para esse produto, e o estoque selecionado não permite saldo negativo")
        '    Exit Sub
        '  End If
        'End If

        bAdicionandoProduto = True

        Dim iSQ_ESTOQUE_LOCALIZACAO As Integer

        If ComboBox_Selecionado(cboTransacaoEstoque) Then
            iSQ_ESTOQUE_LOCALIZACAO = FNC_NVL(cboTransacaoEstoque.SelectedItem(enCombobox_TransacaoEstoque.SQ_ESTOQUE_LOCALIZACAO_DEBITO), 0)
        End If

        If iGridProduto_LinhaEdicao = -1 Then
            objGrid_Linha_Add(grdProdutos, New Object() {const_GridProduto_ID_PRODUTO_EMPRESA, psqProduto.Identificador_Filial,
                                                         const_GridProduto_ID_CFOP, UltraComboBox_Valor(cboProduto_CFOP),
                                                         const_GridProduto_ID_CSOSN, UltraComboBox_Valor(cboProduto_CSOSN),
                                                         const_GridProduto_ID_CST, UltraComboBox_Valor(cboProduto_CST),
                                                         const_GridProduto_ID_NCM, lblNCM_Descricao.Tag,
                                                         const_GridProduto_UnidadeMedida, iID_UNIDADEMEDIDA,
                                                         const_GridProduto_IC_CONTROLA_NUMERO_SERIE, IIf(bIC_CONTROLA_NUMERO_SERIE, "S", "N"),
                                                         const_GridProduto_NomeProduto, psqProduto.Descricao,
                                                         const_GridProduto_Quantidade, txtProduto_Quantidade.Value,
                                                         const_GridProduto_ValorUnitario, txtProduto_ValorUnitario.Value,
                                                         const_GridProduto_ValorDesconto, txtProduto_ValorDesconto.Value,
                                                         const_GridProduto_ValorTotal, txtProduto_ValorTotal.Value,
                                                         const_GridProduto_CFOP, UltraComboBox_Valor(cboProduto_CFOP, 1),
                                                         const_GridProduto_CSOSN, UltraComboBox_Valor(cboProduto_CSOSN, 1),
                                                         const_GridProduto_CST, UltraComboBox_Valor(cboProduto_CST, 1),
                                                         const_GridProduto_NCM, lblNCM_Descricao.Text,
                                                         const_GridProduto_IPI, txtProduto_IPI.Value,
                                                         const_GridProduto_TransacaoEstoque, Val(cboTransacaoEstoque.SelectedValue),
                                                         const_GridProduto_SQ_ESTOQUE_LOCALIZACAO, FNC_NuloSe(iSQ_ESTOQUE_LOCALIZACAO, 0),
                                                         const_GridProduto_IC_TOTALIZA, "S"})
        Else
            With grdProdutos.Rows(iGridProduto_LinhaEdicao)
                .Cells(const_GridProduto_ID_CFOP).Value = UltraComboBox_Valor(cboProduto_CFOP)
                .Cells(const_GridProduto_ID_CSOSN).Value = UltraComboBox_Valor(cboProduto_CSOSN)
                .Cells(const_GridProduto_ID_CST).Value = UltraComboBox_Valor(cboProduto_CST)
                .Cells(const_GridProduto_ID_NCM).Value = lblNCM_Descricao.Tag
                .Cells(const_GridProduto_UnidadeMedida).Value = iID_UNIDADEMEDIDA
                .Cells(const_GridProduto_IC_CONTROLA_NUMERO_SERIE).Value = IIf(bIC_CONTROLA_NUMERO_SERIE, "S", "N")
                .Cells(const_GridProduto_NomeProduto).Value = psqProduto.Descricao
                .Cells(const_GridProduto_Quantidade).Value = txtProduto_Quantidade.Value
                .Cells(const_GridProduto_ValorUnitario).Value = txtProduto_ValorUnitario.Value
                .Cells(const_GridProduto_ValorDesconto).Value = txtProduto_ValorDesconto.Value
                .Cells(const_GridProduto_ValorTotal).Value = txtProduto_ValorTotal.Value
                .Cells(const_GridProduto_CFOP).Value = UltraComboBox_Valor(cboProduto_CFOP, 1)
                .Cells(const_GridProduto_CSOSN).Value = UltraComboBox_Valor(cboProduto_CSOSN, 1)
                .Cells(const_GridProduto_CST).Value = UltraComboBox_Valor(cboProduto_CST, 1)
                .Cells(const_GridProduto_NCM).Value = lblNCM_Descricao.Text
                .Cells(const_GridProduto_IPI).Value = txtProduto_IPI.Value
                .Cells(const_GridProduto_TransacaoEstoque).Value = Val(cboTransacaoEstoque.SelectedValue)
                .Cells(const_GridProduto_SQ_ESTOQUE_LOCALIZACAO).Value = FNC_NuloSe(iSQ_ESTOQUE_LOCALIZACAO, 0)
                .Cells(const_GridProduto_IC_TOTALIZA).Value = "S"
            End With
        End If

        Produto_Tratar()

        Produto_Novo()

        bAdicionandoProduto = False
    End Sub

    Private Sub Produto_Tratar()
        GridProduto_Calcular()
        ProdutoNumeroSerie_Carregar()
    End Sub

    Private Sub GridProduto_Calcular()
        txtQuantidadeTotalNota.Value = objGrid_CalcularTotalColuna(grdProdutos, const_GridProduto_Quantidade)

        lblResumo_Quantidade.Text = FormatNumber(objGrid_CalcularTotalColuna(grdProdutos, const_GridProduto_Quantidade))
        lblResumo_VlTotalProduto.Text = FormatCurrency(Val(objGrid_CalcularTotalColuna(grdProdutos, const_GridProduto_Quantidade)) *
                                                       Val(objGrid_CalcularTotalColuna(grdProdutos, const_GridProduto_ValorUnitario)))
        lblResumo_VlDesconto.Text = FormatCurrency(objGrid_CalcularTotalColuna(grdProdutos, const_GridProduto_ValorDesconto))
        lblResumo_VlTotalNota.Text = FormatCurrency(objGrid_CalcularTotalColuna(grdProdutos, const_GridProduto_ValorTotal))
    End Sub

    Private Sub ProdutoNumeroSerie_Carregar()
        Dim oData As DataTable
        Dim sSqlText As String = ""
        Dim sAux As String
        Dim iCont_01 As Integer
        Dim iCont_02 As Integer
        Dim bAchou As Boolean
        Dim iRowIndex As Integer

        oDBGridProdutoNumeroSerie.Rows.Clear()

        For iCont_01 = 0 To grdProdutos.Rows.Count - 1
            If objGrid_Valor(grdProdutos, const_GridProduto_IC_CONTROLA_NUMERO_SERIE, iCont_01) = "S" Then
                objGrid_Linha_Add(grdProdutoNumeroSerie, New Object() {const_GridProdutoNumeroSerie_ID_PRODUTO_EMPRESA, objGrid_Valor(grdProdutos, const_GridProduto_ID_PRODUTO_EMPRESA, iCont_01),
                                                                       const_GridProdutoNumeroSerie_NO_PRODUTO, objGrid_Valor(grdProdutos, const_GridProduto_NomeProduto, iCont_01),
                                                                       const_GridProdutoNumeroSerie_Quantidade, objGrid_Valor(grdProdutos, const_GridProduto_Quantidade, iCont_01)})
                sAux = "SELECT ID_PRODUTO_EMPRESA," &
                              "CD_NUMEROSERIE" &
                       " FROM VW_ESTOQUE_LOCALIZACAO_NUMEROSERIE" &
                       " WHERE ID_ESTOQUE_LOCALIZACAO_STATUS = " & enEstoqueLocalizacaoStatus.Disponivel.GetHashCode &
                         " And ID_PRODUTO_EMPRESA = " & objGrid_Valor(grdProdutos, const_GridProduto_ID_PRODUTO_EMPRESA, iCont_01)

                FNC_Str_Adicionar(sSqlText, sAux, " UNION ALL ")
            End If
        Next

        For iCont_01 = 0 To grdNumeroSerie.Rows.Count - 1
            grdNumeroSerie.Rows(iCont_01).Hidden = True
            grdNumeroSerie.Rows(iCont_01).Cells(const_GridNumeroSerie_STATUS).Value = const_StatusNumeroSerie_Excluido
        Next

        If sSqlText.Trim() <> "" Then
            sSqlText = "SELECT * FROM (" & sSqlText & ") X ORDER BY ID_PRODUTO_EMPRESA, CD_NUMEROSERIE"
            oData = DBQuery(sSqlText)

            For iCont_01 = 0 To oData.Rows.Count - 1
                bAchou = False

                For iCont_02 = 0 To grdNumeroSerie.Rows.Count - 1
                    With grdNumeroSerie.Rows(iCont_02)
                        If FNC_NVL(.Cells(const_GridNumeroSerie_ID_PRODUTO_EMPRESA).Value, 0) = oData.Rows(iCont_01).Item("ID_PRODUTO_EMPRESA") And
                           Trim(FNC_NVL(.Cells(const_GridNumeroSerie_CD_NUMERO_SERIE).Value, "")) = Trim(oData.Rows(iCont_01).Item("CD_NUMEROSERIE")) Then
                            bAchou = True
                            .Hidden = False
                            .Cells(const_GridNumeroSerie_STATUS).Value = Nothing
                        End If
                    End With
                Next

                If Not bAchou Then
                    iRowIndex = oDBGridNumeroSerie.Rows.Add().Index

                    With grdNumeroSerie.Rows(iRowIndex)
                        .Cells(const_GridNumeroSerie_Sel).Value = False
                        .Cells(const_GridNumeroSerie_ID_PRODUTO_EMPRESA).Value = Trim(oData.Rows(iCont_01).Item("ID_PRODUTO_EMPRESA"))
                        .Cells(const_GridNumeroSerie_CD_NUMERO_SERIE).Value = Trim(oData.Rows(iCont_01).Item("CD_NUMEROSERIE"))
                    End With
                End If
            Next
        End If

        ProdutoNumeroSerie_Exibir()
    End Sub

    Private Sub ProdutoNumeroSerie_Exibir()
        Dim iCont As Integer

        For iCont = 0 To grdNumeroSerie.Rows.Count - 1
            With grdNumeroSerie.Rows(iCont)
                If FNC_NVL(.Cells(const_GridNumeroSerie_STATUS).Value, 0) = const_StatusNumeroSerie_Excluido Then
                    .Hidden = True
                Else
                    If Convert.ToInt32(FNC_NVL(.Cells(const_GridNumeroSerie_ID_PRODUTO_EMPRESA).Value, 0)) =
                       Convert.ToInt32(objGrid_Valor(grdProdutoNumeroSerie, const_GridProdutoNumeroSerie_ID_PRODUTO_EMPRESA)) Then
                        .Hidden = False
                    Else
                        .Hidden = True
                    End If
                End If
            End With
        Next
    End Sub

    Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
        Gravar(True)
    End Sub

    Private Function Gravar(ExibirMensagem As Boolean) As Boolean
        Dim iCont As Integer
        Dim bOk As Boolean = False

        If Not ComboBox_Selecionado(cboNaturezaOperacao) Then
            FNC_Mensagem("Selecione a natureza da operação")
            GoTo Sair
        End If
        If Not UltraComboBox_Selecionado(cboCFOP) Then
            FNC_Mensagem("Selecione a CFOP principal")
            GoTo Sair
        End If
        If Not txtDataDocumentoFiscal.IsDateValid Then
            FNC_Mensagem("Informe a data de emissão")
            GoTo Sair
        End If
        If Not ComboBox_Selecionado(cboTipoDocumentoFiscal) Then
            FNC_Mensagem("Selecione o tipo do documento fiscal")
            GoTo Sair
        End If
        If Not ComboBox_Selecionado(cboSerieDocumentoFiscal) Then
            FNC_Mensagem("Selecione a série do documento fiscal")
            GoTo Sair
        End If
        If psqPessoa.ID_Pessoa = 0 And chkExibirDocumentoFiscal_Pessoa.Checked Then
            FNC_Mensagem("Selecione a pessoa destinatária do documento fiscal")
            GoTo Sair
        End If
        If Not ComboBox_Selecionado(cboEnderecoFaturamento) And chkExibirDocumentoFiscal_EnderecoFaturamento.Checked Then
            FNC_Mensagem("Selecione o endereço da pessoa destinatária do documento fiscal")
            GoTo Sair
        End If
        If grdProdutos.Rows.Count = 0 Then
            FNC_Mensagem("Selecione o(s) produto(s) desse documento fiscal")
            GoTo Sair
        End If
        For iCont = 0 To grdProdutos.Rows.Count - 1
            With grdProdutos.Rows(iCont)
                If FNC_CampoNulo(.Cells(const_GridProduto_ID_NCM).Value) Then
                    FNC_Mensagem("Selecione o NCM de todos os produtos")
                    GoTo Sair
                End If
            End With
        Next
        If FNC_NVL(cboNaturezaOperacao.SelectedItem(enComboBox_NaturezaoOperacao.ID_OPT_TIPO_REFERENCIA), enOpcoes.TipoReferenciaNaturezaOperacao_NaoReferenciar.GetHashCode()) <>
           enOpcoes.TipoReferenciaNaturezaOperacao_NaoReferenciar.GetHashCode() Then
            If Trim(txtNumeroChaveNFeReferenciada.Text) = "" Then
                FNC_Mensagem("Esse tipo de natureza de operação exige que tenha uma outra nf-e/nfce-e vinculado")
                Exit Function
            End If
        End If

        If FormCadastroDocumentoFiscal_Gravar(iSQ_DOCUMENTOFISCAL:=iSQ_DOCUMENTOFISCAL,
                                          iID_NATUREZAOPERACAO:=cboNaturezaOperacao.SelectedValue,
                                          iID_PESSOA:=psqPessoa.ID_Pessoa,
                                          iID_ENDERECO:=cboEnderecoFaturamento.SelectedValue,
                                          iID_ENDERECO_RETIRADA:=0,
                                          iID_PESSOA_TELEFONE:=cboTelefone.SelectedValue,
                                          iID_PESSOA_MIDIASOCIAL:=cboEmail.SelectedValue,
                                          iID_DOCUMENTOFISCAL_SERIE:=cboSerieDocumentoFiscal.SelectedValue,
                                          iID_PESSOA_TRANSPORTADORA:=psqTransportadora.ID_Pessoa,
                                          iID_ENDERECO_TRANSPORTADORA:=cboEnderecoTransportadora.SelectedValue,
                                          iID_PESSOATELEFONE_TRANSPORTADORA:=cboTelefoneTransportadora.SelectedValue,
                                          iID_TRANSPORTE_PLACA_UF:=cboUFPlaca.SelectedValue,
                                          iID_TRANSPORTE_PLACA_2_UF:=cboUFPlaca2.SelectedValue,
                                          iID_OPT_STATUS:=enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode(),
                                          iID_DOCUMENTOFISCAL_TIPO:=cboTipoDocumentoFiscal.SelectedValue,
                                          iID_OPT_FINALIDADE:=cboNaturezaOperacao.SelectedItem(enComboBox_NaturezaoOperacao.ID_OPT_FINALIDADE),
                                          iID_OPT_FRETE:=cboTipoFrete.SelectedValue,
                                          iID_OPT_COMPRADORPRESENTE:=enOpcoes.NFe_CompradorPresenteOperacao_OperacaoPesencial.GetHashCode(),
                                          iID_OPT_NFE_FORMATOEMISSAO:=enOpcoes.NFe_FormaEmissaoNFe_Normal_EmissaoNormal.GetHashCode(),
                                          iID_EQUIPAMENTO_PROCESSAMENTO_FISCAL:=0,
                                          iID_PEDIDO_PAGAMENTO:=0,
                                          bIC_EXIBIR_PESSOA:=chkExibirDocumentoFiscal_Pessoa.Checked,
                                          bIC_EXIBIR_ENDERECO:=chkExibirDocumentoFiscal_EnderecoFaturamento.Checked,
                                          sCD_CHAVE_NFE:=txtNumeroChaveNFe.Text,
                                          sCD_NF_MODELO:="",
                                          sCD_NF_SERIE:="",
                                          sCD_DOCUMENTOFISCAL:=txtNumeroDocumentoFiscal.Text,
                                          sCD_TRANSPORTE_PLACA:=txtPlaca.Text,
                                          sCD_TRANSPORTE_PLACA_2:=txtPlaca2.Text,
                                          dDH_EMISSAO:=txtDataDocumentoFiscal.DateTime,
                                          dDH_SAIDA:=Nothing,
                                          dDH_CONTIGENCIA:=Nothing,
                                          dQT_VOLUMES:=txtVolume.Value,
                                          dQT_PESO_BRUTO:=txtPesoBruto.Value,
                                          dQT_PESO_LIQUIDO:=txtPesoLiquido.Value,
                                          sDS_ESPECIE:=txtEspecie.Text,
                                          sDS_MARCA:=txtMarca.Text,
                                          sDS_JUSTIFICATIVA_CONTIGENCIA:="",
                                          sDS_INFORMACOES_ADICIONAIS:=txtInformacaoComplementar.Text.Replace(ControlChars.CrLf, "").Replace(vbLf, ""),
                                          sDS_PATH_XML:="",
                                          sCD_PROTOCOLO:=txtNumeroProtocoloAutorizacao.Text) Then
            If DBTeveRetorno() Then
                iSQ_DOCUMENTOFISCAL = DBRetorno(1)
            End If

            Dim iSQ_DOCUMENTOFISCAL_PRODUTO As Integer

            '>> Gravação dos Produtos
            For iCont = 0 To grdProdutos.Rows.Count - 1
                With grdProdutos.Rows(iCont)
                    iSQ_DOCUMENTOFISCAL_PRODUTO = FNC_NVL(.Cells(const_GridProduto_SQ_DOCUMENTOFISCAL_PRODUTO).Value, 0)

                    If FormCadastroDocumentoFiscal_Produto_Gravar(iSQ_DOCUMENTOFISCAL_PRODUTO,
                                                                  iSQ_DOCUMENTOFISCAL,
                                                                  CDbl(.Cells(const_GridProduto_ID_PRODUTO_EMPRESA).Value),
                                                                  CDbl(.Cells(const_GridProduto_UnidadeMedida).Value),
                                                                  enOpcoes.StatusItemDocumentoFiscal_Incluido.GetHashCode(),
                                                                  0,
                                                                  CDbl(.Cells(const_GridProduto_ID_CFOP).Value),
                                                                  CDbl(.Cells(const_GridProduto_ID_CSOSN).Value),
                                                                  CDbl(.Cells(const_GridProduto_ID_CST).Value),
                                                                  0,
                                                                  0,
                                                                  CDbl(.Cells(const_GridProduto_ID_NCM).Value),
                                                                  0,
                                                                  .Cells(const_GridProduto_TransacaoEstoque).Value,
                                                                  "",
                                                                  CDbl(.Cells(const_GridProduto_Quantidade).Value),
                                                                  CDbl(.Cells(const_GridProduto_ValorUnitario).Value),
                                                                  0,
                                                                  0,
                                                                  CDbl(FNC_NVL(.Cells(const_GridProduto_ValorDesconto).Value, 0)),
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
                                                                  "") Then
                        .Cells(const_GridProduto_SQ_DOCUMENTOFISCAL_PRODUTO).Value = iSQ_DOCUMENTOFISCAL_PRODUTO
                    Else
                        GoTo Sair
                    End If
                End With
            Next

            '>> Gravação dos Produtos
            For iCont = 1 To cProdutos_Remover.Count
                FormCadastroDocumentoFiscal_Produto_Cancelar(Convert.ToInt32(cProdutos_Remover(iCont)))
            Next

            If Trim(txtNumeroChaveNFeReferenciada.Text) <> "" Then
                FormCadastroDocumentoFiscalReferencia_Gravar(iSQ_DOCUMENTOFISCAL, txtNumeroChaveNFeReferenciada.Text)
            End If

            bCopiar = False
            bDevolver = False

            CarregarDados()

            If ExibirMensagem Then FNC_Mensagem("Gravação Efetuada")

            DocumentoFiscal_Gravado(True)

            bOk = True
        End If

Sair:
        Return bOk
    End Function

    Private Sub CarregarDados()
        Dim oData_01 As DataTable
        Dim oData_02 As DataTable
        Dim sSqlText As String
        Dim sCD_CHAVE_NFE As String = ""

        sSqlText = "SELECT * FROM TB_DOCUMENTOFISCAL WHERE SQ_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL
        oData_01 = DBQuery(sSqlText)

        If Not objDataTable_Vazio(oData_01) Then
            With oData_01.Rows(0)
                iID_OPT_STATUS = FNC_NVL(.Item("ID_OPT_STATUS"), enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode())

                If bCopiar Or bDevolver Then
                    sCD_CHAVE_NFE = FNC_NVL(.Item("CD_CHAVE_NFE"), "")
                Else
                    txtNumero.Text = FNC_NVL(.Item("CD_DOCUMENTOFISCAL"), "")
                    txtNumeroDocumentoFiscal.Text = FNC_NVL(.Item("CD_DOCUMENTOFISCAL"), "")
                    txtNumeroChaveNFe.Text = FNC_NVL(.Item("CD_CHAVE_NFE"), "")
                    txtNumeroProtocoloAutorizacao.Text = FNC_NVL(.Item("CD_PROTOCOLO"), "")
                End If

                If Not bDevolver Then
                    ComboBox_Selecionar(cboNaturezaOperacao, .Item("ID_NATUREZAOPERACAO"))
                End If
                psqPessoa.ID_Pessoa = .Item("ID_PESSOA")
                ComboBox_Selecionar(cboEnderecoFaturamento, FNC_NVL(.Item("ID_ENDERECO"), 0))
                ComboBox_Selecionar(cboTelefone, FNC_NVL(.Item("ID_PESSOA_TELEFONE"), 0))
                ComboBox_Selecionar(cboEmail, FNC_NVL(.Item("ID_PESSOA_MIDIASOCIAL_EMAIL"), 0))
                ComboBox_Selecionar(cboTipoDocumentoFiscal, FNC_NVL(.Item("ID_DOCUMENTOFISCAL_TIPO"), 0))
                ComboBox_TipoDocumentoFiscal_Tratar()
                ComboBox_Selecionar(cboSerieDocumentoFiscal, FNC_NVL(.Item("ID_DOCUMENTOFISCAL_SERIE"), 0))
                psqTransportadora.ID_Pessoa = FNC_NVL(.Item("ID_PESSOA_TRANSPORTADORA"), 0)
                ComboBox_Selecionar(cboEnderecoTransportadora, FNC_NVL(.Item("ID_ENDERECO_TRANSPORTADORA"), 0))
                ComboBox_Selecionar(cboTelefoneTransportadora, FNC_NVL(.Item("ID_PESSOATELEFONE_TRANSPORTADORA"), 0))
                ComboBox_Selecionar(cboUFPlaca, FNC_NVL(.Item("ID_TRANSPORTE_PLACA_UF"), 0))
                ComboBox_Selecionar(cboUFPlaca2, FNC_NVL(.Item("ID_TRANSPORTE_PLACA_2_UF"), 0))
                ComboBox_Selecionar(cboTipoFrete, FNC_NVL(.Item("ID_OPT_FRETE"), 0))
                txtPlaca.Text = FNC_NVL(.Item("CD_TRANSPORTE_PLACA"), "")
                txtPlaca2.Text = FNC_NVL(.Item("CD_TRANSPORTE_PLACA_2"), "")
                If bCopiar Or bDevolver Then
                    txtDataDocumentoFiscal.DateTime = Now()
                Else
                    If Not objDataTable_CampoVazio(.Item("DH_EMISSAO")) Then
                        txtDataDocumentoFiscal.DateTime = .Item("DH_EMISSAO")
                    End If
                End If
                txtVolume.Value = FNC_NVL(.Item("QT_VOLUMES"), 0)
                txtPesoBruto.Value = FNC_NVL(.Item("QT_PESO_BRUTO"), 0)
                txtPesoLiquido.Value = FNC_NVL(.Item("QT_PESO_LIQUIDO"), 0)
                txtEspecie.Text = FNC_NVL(.Item("DS_ESPECIE"), "")
                txtMarca.Text = FNC_NVL(.Item("DS_MARCA"), "")
                txtInformacaoComplementar.Text = FNC_NVL(.Item("DS_INFORMACOES_ADICIONAIS"), "")
                sDS_PATH_XML = FNC_NVL(.Item("DS_PATH_XML"), "")

                chkExibirDocumentoFiscal_Pessoa.Checked = (FNC_NVL(.Item("IC_EXIBIR_PESSOA"), "S") = "S")
                chkExibirDocumentoFiscal_EnderecoFaturamento.Checked = (FNC_NVL(.Item("IC_EXIBIR_ENDERECO"), "S") = "S")

                If Not bCopiar And Not bDevolver Then
                    If FNC_NVL(.Item("ID_OPT_STATUS"), enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode()) = enOpcoes.StatusDocumentoFiscal_Transmitido.GetHashCode() Then
                        FNC_Mensagem("Documento Fiscal transmitido não pode ser alterado")
                        Edicao(False)
                    End If
                End If

                sSqlText = "SELECT " + IIf(bCopiar Or bDevolver, " 0,", "SQ_DOCUMENTOFISCAL_PRODUTO,") &
                                  "ID_PRODUTO_EMPRESA," &
                                  "ID_PEDIDO_PRODUTO," &
                                  "ID_UNIDADEMEDIDA," &
                                  IIf(bDevolver, "ID_CFOP_DEVOLUCAO,", "ID_CFOP,") &
                                  "ID_CSOSN," &
                                  "ID_CST," &
                                  "ID_NCM," &
                                  IIf(bDevolver, "CD_CFOP_DEVOLUCAO,", "CD_CFOP,") &
                                  "CD_CSOSN," &
                                  "CD_CST," &
                                  "CD_DS_NCM," &
                                  "ID_TRANSACAOESTOQUE," &
                                  "NO_PRODUTO," &
                                  "QT_PRODUTO," &
                                  "VL_UNITARIO," &
                                  "VL_DESCONTO," &
                                  "VL_TOTAL," &
                                  "VL_ICMS," &
                                  "VL_SUBSTITUICAO_ICMS," &
                                  "VL_IPI," &
                                  "VL_COFINS," &
                                  "VL_IPI," &
                                  "VL_II," &
                                  "IC_CONTROLA_NUMERO_SERIE," &
                                  "IC_TOTALIZA" &
                           " FROM VW_DOCUMENTOFISCAL_PRODUTO" &
                           " WHERE ID_DOCUMENTOFISCAL = " & iSQ_DOCUMENTOFISCAL &
                             " AND ID_OPT_STATUS NOT IN (" & enOpcoes.StatusItemDocumentoFiscal_Cancelado.GetHashCode().ToString & ")"
                objGrid_Carregar(grdProdutos, sSqlText, New Integer() {const_GridProduto_SQ_DOCUMENTOFISCAL_PRODUTO,
                                                                       const_GridProduto_ID_PRODUTO_EMPRESA,
                                                                       const_GridProduto_ID_PEDIDO_PRODUTO,
                                                                       const_GridProduto_UnidadeMedida,
                                                                       const_GridProduto_ID_CFOP,
                                                                       const_GridProduto_ID_CSOSN,
                                                                       const_GridProduto_ID_CST,
                                                                       const_GridProduto_ID_NCM,
                                                                       const_GridProduto_CFOP,
                                                                       const_GridProduto_CSOSN,
                                                                       const_GridProduto_CST,
                                                                       const_GridProduto_NCM,
                                                                       const_GridProduto_TransacaoEstoque,
                                                                       const_GridProduto_NomeProduto,
                                                                       const_GridProduto_Quantidade,
                                                                       const_GridProduto_ValorUnitario,
                                                                       const_GridProduto_ValorDesconto,
                                                                       const_GridProduto_ValorTotal,
                                                                       const_GridProduto_ICMS,
                                                                       const_GridProduto_ICMS_Subst,
                                                                       const_GridProduto_PIS,
                                                                       const_GridProduto_Cofins,
                                                                       const_GridProduto_IPI,
                                                                       const_GridProduto_II,
                                                                       const_GridProduto_IC_CONTROLA_NUMERO_SERIE,
                                                                       const_GridProduto_IC_TOTALIZA})

                If bDevolver Then
                    txtNumeroChaveNFeReferenciada.Text = sCD_CHAVE_NFE
                End If

                If bCopiar Or bDevolver Then
                    iSQ_DOCUMENTOFISCAL = 0
                End If

                If Trim(txtNumeroChaveNFeReferenciada.Text) = "" Then
                    oData_02 = DBQuery("SELECT * FROM TB_DOCUMENTOFISCAL_REFERENCIA WHERE ID_DOCUMENTOFISCAL = " + iSQ_DOCUMENTOFISCAL.ToString())

                    If Not objDataTable_Vazio(oData_02) Then
                        txtNumeroChaveNFeReferenciada.Text = oData_02.Rows(0).Item("CD_CHAVE_NFE_REFENCENCIA")
                    End If
                End If
            End With
        End If

        Produto_Tratar()
        DocumentoFiscal_Gravado(True)
    End Sub

    Private Sub Produto_Novo()
        bEmProcessamento = True

        iGridProduto_LinhaEdicao = -1

        psqProduto.Enabled = True
        txtProduto_Quantidade.Enabled = True
        txtProduto_ValorUnitario.Enabled = True

        psqProduto.Identificador = 0
        cboProduto_CFOP.SelectedRow = Nothing
        cboProduto_CSOSN.SelectedRow = Nothing
        cboProduto_CST.SelectedRow = Nothing
        txtProduto_Quantidade.Value = 0
        txtProduto_ValorUnitario.Value = 0
        txtProduto_ValorTotal.Value = 0
        txtProduto_IPI.Value = 0
        lblNCM_Descricao.Tag = 0
        lblNCM_Descricao.Text = ""

        bEmProcessamento = False
    End Sub

    Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
        Close()
    End Sub

    Private Sub cmdProduto_Novo_Click(sender As Object, e As EventArgs) Handles cmdProduto_Novo.Click
        Produto_Novo()
    End Sub

    Private Sub cmdProduto_Editar_Click(sender As Object, e As EventArgs) Handles cmdProduto_Editar.Click
        If objGrid_LinhaSelecionada(grdProdutos) = -1 Then
            FNC_Mensagem("Selecione o produto de manutenção para edição")
            Exit Sub
        End If

        iGridProduto_LinhaEdicao = objGrid_LinhaSelecionada(grdProdutos)

        psqProduto.Identificador_Filial = objGrid_Valor(grdProdutos, const_GridProduto_ID_PRODUTO_EMPRESA)
        txtProduto_Quantidade.Value = Val(objGrid_Valor(grdProdutos, const_GridProduto_Quantidade))
        txtProduto_ValorUnitario.Value = Val(objGrid_Valor(grdProdutos, const_GridProduto_ValorUnitario,, 0))
        txtProduto_ValorDesconto.Value = Val(FNC_ConvValorFormatoAmericano(objGrid_Valor(grdProdutos, const_GridProduto_ValorDesconto, , 0)))
        ComboBox_Selecionar(cboTransacaoEstoque, objGrid_Valor(grdProdutos, const_GridProduto_TransacaoEstoque))
        UltraComboBox_Selecionar(cboProduto_CFOP, enCombox_CFOP.SQ_CFOP, objGrid_Valor(grdProdutos, const_GridProduto_ID_CFOP))
        UltraComboBox_Selecionar(cboProduto_CST, enCombox_CST.SQ_CST, objGrid_Valor(grdProdutos, const_GridProduto_ID_CST))
        UltraComboBox_Selecionar(cboProduto_CSOSN, enCombox_CSOSN.SQ_CSOSN, objGrid_Valor(grdProdutos, const_GridProduto_ID_CSOSN))
        txtProduto_IPI.Value = objGrid_Valor(grdProdutos, const_GridProduto_IPI)
    End Sub

    Private Sub cmdProduto_Remover_Click(sender As Object, e As EventArgs) Handles cmdProduto_Remover.Click
        If objGrid_LinhaSelecionada(grdProdutos) = -1 Then
            FNC_Mensagem("Selecione o produto para remoção")
            Exit Sub
        End If

        iGridProduto_LinhaEdicao = -1

        cProdutos_Remover.Add(objGrid_Valor(grdProdutos, const_GridProduto_SQ_DOCUMENTOFISCAL_PRODUTO))

        objGrid_ExcluirLinha(grdProdutos)
    End Sub

    Private Sub cmdTransmitir_NFe_Click(sender As Object, e As EventArgs) Handles cmdTransmitir_NFe.Click
        If Not FNC_Perguntar("Deseja realmente transmitir esse documento fiscal") Then
            Exit Sub
        End If

        If Gravar(False) Then
            If iSQ_DOCUMENTOFISCAL > 0 Then
                If FNC_Fiscal_DocumentoFiscal_Transmitir(iSQ_DOCUMENTOFISCAL,
                                                         cboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.CD_SERVICO_MODELO),,, True) Then
                    FNC_Mensagem("Documento fiscal transmitido")
                End If
            End If
        End If
    End Sub

    Private Sub cmdHistorico_Click(sender As Object, e As EventArgs) Handles cmdHistorico.Click
        If iSQ_DOCUMENTOFISCAL = 0 Then
            FNC_Mensagem("Selecione o documento fiscal para o qual deseja ver o histórico")
        Else
            Dim oForm As New frmConsultaHistorico_Registro

            oForm.iProcessso = enOpcoes.Processo_Historico_Cadastro_CadastroDocumentoFiscal.GetHashCode()
            oForm.iID_REGISTRO = iSQ_DOCUMENTOFISCAL
            FNC_AbriTela(oForm, , True, True)
        End If
    End Sub

    Private Sub Edicao(bEditar As Boolean)
        cmdGravar.Enabled = bEditar
        cmdTransmitir_NFe.Enabled = bEditar
    End Sub

    Private Sub grdProdutos_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdProdutos.AfterCellUpdate
        If FNC_In(e.Cell.Column.Index, const_GridProduto_Quantidade, const_GridProduto_ValorUnitario, const_GridProduto_ValorTotal) Then
            GridProduto_Calcular()
        End If
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        If iSQ_DOCUMENTOFISCAL = 0 Then
            FNC_Mensagem("Esse documento fiscal não foi gravado ainda")
            Exit Sub
        End If
        If Trim(sDS_PATH_XML) = "" Then
            FNC_Mensagem("Arquivo XML não gerado ainda")
            Exit Sub
        End If

        Select Case cboTipoDocumentoFiscal.SelectedItem(enComboBox_DocumentoFiscal_Tipo.CD_SERVICO_MODELO)
            Case const_NFe_ModeloServico_NFCe
                FNC_Fiscal_Danfe_ImprimirNCFe(FNC_DiretorioSistema_AdicionarPath(sDS_PATH_XML),
                                              sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_NORMAL,
                                              sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA,
                                              sESTACAO_TRABALHO_CD_NFCe_Token_ID,
                                              sESTACAO_TRABALHO_CD_NFCe_Token_CSC)
            Case const_NFe_ModeloServico_NFe
        'FNC_Fiscal_Danfe_GerarPDF(FNC_DiretorioSistema_AdicionarPath(sDS_PATH_XML), True)
    End Select
    End Sub

    Private Sub frmCadastroDocumentoFiscal_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        objGrid_Configuracao_Gravar(grdProdutos, Me.Text)
    End Sub

    Private Sub txtProduto_ValorDesconto_ValueChanged(sender As Object, e As EventArgs) Handles txtProduto_ValorDesconto.ValueChanged
        Produto_CalcularTotal()
    End Sub
End Class