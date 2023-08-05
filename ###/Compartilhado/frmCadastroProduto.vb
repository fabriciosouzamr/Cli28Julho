Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmCadastroProduto
  Public Event Pesquisar()

  Const const_GridTabelaPreco_ID_TABELAPRECO As Integer = 0
  Const const_GridTabelaPreco_Sel As Integer = 1
  Const const_GridTabelaPreco_NomeTabelaPreco As Integer = 2
  Const const_GridTabelaPreco_Comissao As Integer = 3
  Const const_GridTabelaPreco_CustoTotal As Integer = 4
  Const const_GridTabelaPreco_MargemLucro As Integer = 5
  Const const_GridTabelaPreco_ValorBrindeAcessorio As Integer = 6
  Const const_GridTabelaPreco_ValorVenda As Integer = 7
  Const const_GridTabelaPreco_DescontoMaximo As Integer = 8

  Const const_GridFornecedor_ID_FORNECEDOR As Integer = 0
  Const const_GridFornecedor_NomeFornecedor As Integer = 1
  Const const_GridFornecedor_CodigoFornecedor As Integer = 2
  Const const_GridFornecedor_ValorUnitarioUltimaCompra As Integer = 3
  Const const_GridFornecedor_Acao As Integer = 4

  Public iSQ_PRODUTO As Integer
  Public iSQ_PRODUTO_EMPRESA As Integer
  Public bGravado As Boolean = False

  Public oNFe_Produto As NFe.Classes.Informacoes.Detalhe.det

  Dim iLinhaFornecedor As Integer = -1

  Dim bCalculando As Boolean = False
  Dim bProcessando As Boolean = False
  Dim bCarregandoProduto As Double = False
  Dim bFormCarrregado As Boolean = False

  Dim oDBTabelaPreco As New UltraWinDataSource.UltraDataSource
  Dim oDBFornecedor As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cboUnidadeMedida_KeyDown(sender As Object, e As KeyEventArgs) Handles cboUnidadeMedida.KeyDown
    If e.KeyCode = Keys.Delete Then cboUnidadeMedida.SelectedIndex = -1
  End Sub

  Private Sub cboFabricante_KeyDown(sender As Object, e As KeyEventArgs) Handles cboFabricante.KeyDown
    If e.KeyCode = Keys.Delete Then cboFabricante.SelectedIndex = -1
  End Sub

  Private Sub cboCST_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCST.KeyDown
    If e.KeyCode = Keys.Delete Then cboCST.SelectedRow = Nothing
  End Sub

  Private Sub cboCSOSN_ValueChanged(sender As Object, e As KeyEventArgs) Handles cboCSOSN.KeyDown
    If e.KeyCode = Keys.Delete Then cboCSOSN.SelectedRow = Nothing
  End Sub

  Private Sub cboCSTCofins_ValueChanged(sender As Object, e As KeyEventArgs) Handles cboCSTCofins.KeyDown
    If e.KeyCode = Keys.Delete Then cboCSTCofins.SelectedRow = Nothing
  End Sub

  Private Sub cboCSTPIS_ValueChanged(sender As Object, e As KeyEventArgs) Handles cboCSTPIS.KeyDown
    If e.KeyCode = Keys.Delete Then cboCSTPIS.SelectedRow = Nothing
  End Sub

  Private Sub cboCSTIPI_ValueChanged(sender As Object, e As KeyEventArgs) Handles cboCSTIPI.KeyDown
    If e.KeyCode = Keys.Delete Then cboCSTIPI.SelectedRow = Nothing
  End Sub

  Private Sub cboGrupoProduto_ValueChanged(sender As Object, e As KeyEventArgs) Handles cboGrupoProduto.KeyDown
    If e.KeyCode = Keys.Delete Then cboGrupoProduto.SelectedIndex = -1
  End Sub

  Private Sub cboTipoProduto_ValueChanged(sender As Object, e As KeyEventArgs) Handles cboTipoProduto.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoProduto.SelectedIndex = -1
  End Sub

  Private Sub frmCadastroProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    FormatarTela()

    If iSQ_PRODUTO = 0 Then
      txtCodigo.Text = FNC_StrZero(Val(DBQuery_ValorUnico("SELECT IDENT_CURRENT('TB_PRODUTO')", 0)), 10)

      If Not oNFe_Produto Is Nothing Then
        With oNFe_Produto
          If Trim(.prod.cEAN) = "" Or Trim(.prod.cEAN).ToUpper() = const_NFe_ProdutoSemGTIN Then
            txtCodigoFabricante.Text = .prod.cProd
          Else
            txtCodigoFabricante.Text = .prod.cEAN
          End If
          If Trim(.prod.cEAN).ToUpper() <> const_NFe_ProdutoSemGTIN Then
            txtCodigoBarra.Text = .prod.cEAN
          End If
          txtNomeProduto.Text = .prod.xProd
          txtNCM.Text = .prod.NCM
          ComboBox_Selecionar(cboUnidadeMedida, FNC_Busca_UnidadeMedida_Identificar(.prod.uCom))
          txtPrecoCusto.Value = Math.Round(.prod.vUnCom, iEMPRESA_NR_CASASDECIMAIS_VALORES)
          txtCustoTotal.Value = Math.Round(.prod.vUnCom, iEMPRESA_NR_CASASDECIMAIS_VALORES)
          txtNCM_LostFocus(Nothing, Nothing)
          UltraComboBox_Selecionar(cboCST, enCombox_CST.SQ_CST, FormCadastroProduto_BuscarCST_Zeus(enCST_Grupo.eCST_ICMS, FNC_Fiscal_DocumentoFiscal_Produto_DadosICMS(oNFe_Produto).CST.GetHashCode().ToString()))
          If FNC_Fiscal_DocumentoFiscal_Produto_DadosICMS(oNFe_Produto).CSOSN.GetHashCode() <> 0 Then
            UltraComboBox_Selecionar(cboCSOSN, enCombox_CSOSN.CD_CSOSN, FNC_Fiscal_DocumentoFiscal_Produto_DadosICMS(oNFe_Produto).CSOSN.GetHashCode.ToString())
          End If
          If Not oNFe_Produto.imposto.COFINS Is Nothing Then
            UltraComboBox_Selecionar(cboCSTCofins, enCombox_CST.SQ_CST, FormCadastroProduto_BuscarCST_Zeus(enCST_Grupo.eCST_PIS_COFINS, FNC_Fiscal_DocumentoFiscal_Produto_DadosCOFINS(oNFe_Produto).CST.GetHashCode().ToString()))
            txtCOFINS.Value = FNC_Fiscal_DocumentoFiscal_Produto_DadosCOFINS(oNFe_Produto).pCOFINS
          End If
          If Not oNFe_Produto.imposto.PIS Is Nothing Then
            UltraComboBox_Selecionar(cboCSTPIS, enCombox_CST.SQ_CST, FormCadastroProduto_BuscarCST_Zeus(enCST_Grupo.eCST_PIS_COFINS, FNC_Fiscal_DocumentoFiscal_Produto_DadosPIS(oNFe_Produto).CST.GetHashCode().ToString()))
            txtPIS.Value = FNC_Fiscal_DocumentoFiscal_Produto_DadosPIS(oNFe_Produto).pPIS
          End If
          If Not oNFe_Produto.imposto.IPI Is Nothing Then
            UltraComboBox_Selecionar(cboCSTIPI, enCombox_CST.SQ_CST, FormCadastroProduto_BuscarCST_Zeus(enCST_Grupo.eCST_IPI, FNC_Fiscal_DocumentoFiscal_Produto_DadosIPI(oNFe_Produto).CST.GetHashCode().ToString()))
            txtIPI.Value = FNC_Fiscal_DocumentoFiscal_Produto_DadosIPI(oNFe_Produto).pIPI
          End If
          ComboBox_Selecionar(cboOrigemProduto, FormCadastroProduto_BuscarOrigemProduto(FNC_Fiscal_DocumentoFiscal_Produto_DadosICMS(oNFe_Produto).orig.GetHashCode.ToString()))
          chkAtivo.Checked = True
        End With

        tabGeral.SelectedTab = tbpDadosFilial
      End If
    Else
      CarregarDados()
    End If

    bFormCarrregado = True
  End Sub

  Private Sub FormatarTela()
    Dim sSqlText As String

    lblCST_Descricao.Text = ""
    lblCSOSN_Descricao.Text = ""
    lblNCM_Descricao.Text = ""
    lblCSTCofins_Descricao.Text = ""
    lblCSTPIS_Descricao.Text = ""
    lblCSTIPI_Descricao.Text = ""
    lblDataUltimaCompra.Text = ""
    lblDataUltimaVenda.Text = ""
    txtNCM.Tag = Nothing
    chkAtivo.Checked = True
    ControleGarantia_TratarControle()
    picProduto.Inicializar()
    picProduto.SelecionarImagem = True

    UltraComboBox_Inicializar(cboCST, 700)
    UltraComboBox_Inicializar(cboCSOSN, 550)
    UltraComboBox_Inicializar(cboCSTCofins, 550)
    UltraComboBox_Inicializar(cboCSTIPI, 550)
    UltraComboBox_Inicializar(cboCSTPIS, 550)

    ComboBox_Carregar(cboUnidadeMedida, enSql.UnidadeMedida)
    ComboBox_Carregar(cboFabricante, enSql.Fabricante)
    UltraComboBox_Carregar(cboCST, enSql.CST)
    UltraComboBox_Carregar(cboCSOSN, enSql.CSOSN)
    UltraComboBox_Carregar(cboCSTCofins, enSql.CSTCofins)
    UltraComboBox_Carregar(cboCSTIPI, enSql.CSTIPI)
    UltraComboBox_Carregar(cboCSTPIS, enSql.CSTPIS)
    ComboBox_Carregar(cboGrupoProduto, enSql.GrupoProduto)
    ComboBox_Carregar(cboTipoProduto, enSql.TipoProduto)
    ComboBox_Carregar(cboLinhaProdutoVenda, enSql.LinhaProdutoVenda)
    ComboBox_Carregar(cboOrigemProduto, enSql.OrigemProduto)
    ComboBox_Carregar(cboModalidade_BC_ICMS, enSql.ModalidadeBaseCalculoICMS)
    ComboBox_Carregar(cboModalidade_BC_ICMS_ST, enSql.ModalidadeBaseCalculoICMSST)
    ComboBox_Carregar(cboGrupoTributario, enSql.GrupoTributario)

    ComboBox_Selecionar(cboOrigemProduto, enOpcoes.OrigemProduto_0Nacional_ExcetoIndicadasCodigos_3_4_5_8.GetHashCode)
    ComboBox_Selecionar(cboModalidade_BC_ICMS, enOpcoes.ModalidadeBaseCalculoICMS_ValorOperacao.GetHashCode)
    ComboBox_Selecionar(cboModalidade_BC_ICMS_ST, enOpcoes.ModalidadeBaseCalculoICMS_MargemValorAgregado.GetHashCode)

    ListBox_Carregar(cklCaracteriscaProduto, enSql.CaracteristicaProduto)

    objGrid_Inicializar(grdTabelaPreco, , oDBTabelaPreco, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdTabelaPreco, "SQ_TABELAPRECO", 0)
    objGrid_Coluna_Add(grdTabelaPreco, "Sel.", 40, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdTabelaPreco, "Nome da Tabela de Preço", 250)
    objGrid_Coluna_Add(grdTabelaPreco, "Comissão %", 90, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdTabelaPreco, "Custo Total", 100, , , ColumnStyle.Currency, , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdTabelaPreco, "Margem de Lucro %", 125, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdTabelaPreco, "Valor Brinde e Acessório", 140, , , ColumnStyle.Currency, , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdTabelaPreco, "Valor Venda", 100, , , ColumnStyle.Currency, , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdTabelaPreco, "Desconto Máximo", 100, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas)
    objGrid_Configuracao_Carregar(grdTabelaPreco, Me.Name)

    objGrid_Inicializar(grdFornecedor, , oDBFornecedor, UltraWinGrid.CellClickAction.RowSelect, DefaultableBoolean.False, DefaultableBoolean.True, False, , , , True)
    objGrid_Coluna_Add(grdFornecedor, "ID_FORNECEDOR", 0)
    objGrid_Coluna_Add(grdFornecedor, "Nome do Fornecedor", 300)
    objGrid_Coluna_Add(grdFornecedor, "Código Prod. Fornecedor", 150)
    objGrid_Coluna_Add(grdFornecedor, "Valor Unit. Ult. Compra", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdFornecedor, "ACAO", 0)
    objGrid_Configuracao_Carregar(grdFornecedor, Me.Name)

    sSqlText = "SELECT SQ_TABELAPRECO," &
                      "NO_TABELAPRECO," &
                      "PC_MARGEM_LUCRO," &
                      "PC_COMISSAO," &
                      "PC_DESCONTO_MAXIMO" &
               " FROM TB_TABELAPRECO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND ISNULL(DT_FIM_USO, CAST(GETDATE() AS DATE)) >= CAST(GETDATE() AS DATE)" &
               " ORDER BY NO_TABELAPRECO"
    objGrid_Carregar(grdTabelaPreco, sSqlText, New Integer() {const_GridTabelaPreco_ID_TABELAPRECO,
                                                              const_GridTabelaPreco_NomeTabelaPreco,
                                                              const_GridTabelaPreco_MargemLucro,
                                                              const_GridTabelaPreco_Comissao,
                                                              const_GridTabelaPreco_DescontoMaximo})

    Fornecedor_Novo()
  End Sub

  Private Sub cboCST_ValueChanged(sender As Object, e As EventArgs) Handles cboCST.ValueChanged
    If cboCST.ActiveRow Is Nothing Then
      lblCST_Descricao.Text = ""
    Else
      lblCST_Descricao.Text = cboCST.ActiveRow.Cells(enCombox_CST.NO_CST).Text

      If Not UltraComboBox_Selecionado(cboCSOSN) Then
        UltraComboBox_Selecionar(cboCSOSN, enCombox_CSOSN.CD_CSOSN, cboCST.SelectedRow.Cells(enCombox_CST.CD_CSOSN).Value)
      End If
    End If
  End Sub

  Private Sub cboCSOSN_ValueChanged(sender As Object, e As EventArgs) Handles cboCSOSN.ValueChanged, cboCSOSN.KeyDown
    If cboCSOSN.ActiveRow Is Nothing Then
      lblCSOSN_Descricao.Text = ""
    Else
      lblCSOSN_Descricao.Text = cboCSOSN.ActiveRow.Cells(enCombox_CSOSN.DS_CSOSN).Text
    End If
  End Sub

  Private Sub cboCSTPIS_ValueChanged(sender As Object, e As EventArgs) Handles cboCSTPIS.ValueChanged, cboCSTPIS.KeyDown
    If cboCSTPIS.ActiveRow Is Nothing Then
      lblCSTPIS_Descricao.Text = ""
    Else
      lblCSTPIS_Descricao.Text = cboCSTPIS.ActiveRow.Cells(enCombox_CST.NO_CST).Text
    End If
  End Sub

  Private Sub cboCSTIPI_ValueChanged(sender As Object, e As EventArgs) Handles cboCSTIPI.ValueChanged, cboCSTIPI.KeyDown
    If cboCSTIPI.ActiveRow Is Nothing Then
      lblCSTIPI_Descricao.Text = ""
    Else
      lblCSTIPI_Descricao.Text = cboCSTIPI.ActiveRow.Cells(enCombox_CST.NO_CST).Text
    End If
  End Sub

  Private Sub cboCSTCofins_ValueChanged(sender As Object, e As EventArgs) Handles cboCSTCofins.ValueChanged, cboCSTCofins.KeyDown
    If cboCSTCofins.ActiveRow Is Nothing Then
      lblCSTCofins_Descricao.Text = ""
    Else
      lblCSTCofins_Descricao.Text = cboCSTCofins.ActiveRow.Cells(enCombox_CST.NO_CST).Text
    End If
  End Sub

  Private Sub CalculaPrecoVenda()
    FNC_CalculaPrecoVenda(txtPrecoCusto.Value,
                          txtICMSEntrada_Porc.Value,
                          txtICMSST_Porc.Value,
                          txtICMSaida_Porc.Value,
                          txtSimplesNacional_Porc.Value,
                          txtCustoFixo_Porc.Value,
                          txtCustoVariavel_Porc.Value,
                          txtOutrosImpostos_Porc.Value,
                          txtFreteEntrada_Porc.Value,
                          0, 0, 0,
                          txtICMSEntrada_Valor.Value,
                          txtICMSST_Valor.Value,
                          txtICMSaida_Valor.Value,
                          txtSimplesNacional_Valor.Value,
                          txtCustoFixo_Valor.Value,
                          txtCustoVariavel_Valor.Value,
                          txtOutrosImpostos_Valor.Value,
                          txtFreteEntrada_Valor.Value,
                          0, 0,
                          txtCustoTotal.Value,
                          0,
                          bCalculando)

    TabelaPreco_Atualizar()
  End Sub

  Private Sub TabelaPreco_Atualizar()
    Dim iCont As Integer

    For iCont = 0 To grdTabelaPreco.Rows.Count - 1
      If objGrid_CheckBox_Selecionado(grdTabelaPreco, const_GridTabelaPreco_Sel, iCont) Then
        GridProduto_Calcular(iCont)
      End If
    Next
  End Sub

  Private Sub txtPrecoCusto_ValueChanged(sender As Object, e As EventArgs) Handles txtPrecoCusto.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub txtICMSEntrada_Porc_ValueChanged(sender As Object, e As EventArgs) Handles txtICMSEntrada_Porc.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub txtICMSST_Porc_ValueChanged(sender As Object, e As EventArgs) Handles txtICMSST_Porc.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub txtICMSaida_Porc_ValueChanged(sender As Object, e As EventArgs) Handles txtICMSaida_Porc.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub txtCustoOperacional_Porc_ValueChanged(sender As Object, e As EventArgs) Handles txtCustoVariavel_Porc.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub txtOutrosImpostos_Porc_ValueChanged(sender As Object, e As EventArgs) Handles txtOutrosImpostos_Porc.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub txtFreteEntrada_Porc_ValueChanged(sender As Object, e As EventArgs) Handles txtFreteEntrada_Porc.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer

    bCarregandoProduto = True

    sSqlText = "SELECT * FROM TB_PRODUTO WHERE SQ_PRODUTO = " & iSQ_PRODUTO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      ComboBox_Selecionar(cboUnidadeMedida, FNC_NVL(.Item("ID_UNIDADEMEDIDA"), 0))
      ComboBox_Selecionar(cboFabricante, FNC_NVL(.Item("ID_PESSOA_FABRICANTE"), 0))
      ComboBox_Selecionar(cboGrupoTributario, FNC_NVL(.Item("ID_GRUPOTRIBUTARIO"), 0))
      txtCodigo.Text = FNC_NVL(.Item("CD_PRODUTO"), "")
      txtNomeProduto.Text = FNC_NVL(.Item("NO_PRODUTO"), "")
      txtCodigoFabricante.Text = FNC_NVL(.Item("CD_BARRA_FABRICANTE"), "")
      UltraComboBox_Selecionar(cboCST, enCombox_CST.SQ_CST, FNC_NVL(.Item("ID_CST"), 0))
      UltraComboBox_Selecionar(cboCSOSN, enCombox_CSOSN.SQ_CSOSN, FNC_NVL(.Item("ID_CSOSN"), 0))
      FNC_NCM_Carregar(txtNCM, FNC_NVL(.Item("ID_NCM"), 0), "", lblNCM_Descricao, ToolTip1)
      txtCOFINS.Value = FNC_NVL(.Item("PC_COFINS"), 0)
      txtIPI.Value = FNC_NVL(.Item("PC_IPI"), 0)
      txtPIS.Value = FNC_NVL(.Item("PC_PIS"), 0)
      UltraComboBox_Selecionar(cboCSTCofins, enCombox_CST.SQ_CST, FNC_NVL(.Item("ID_CST_COFINS"), 0))
      UltraComboBox_Selecionar(cboCSTIPI, enCombox_CST.SQ_CST, FNC_NVL(.Item("ID_CST_IPI"), 0))
      UltraComboBox_Selecionar(cboCSTPIS, enCombox_CST.SQ_CST, FNC_NVL(.Item("ID_CST_PIS"), 0))
      txtMVA.Value = FNC_NVL(.Item("PC_MVA"), 0)
      txtIBPT_Estadual.Value = FNC_NVL(.Item("PC_ALIQUOTA_IBPT_ESTADUAL"), 0)
      txtIBPT_Nacional.Value = FNC_NVL(.Item("PC_ALIQUOTA_IBPT_NACIONAL"), 0)
      txtPesoLiquido.Value = FNC_NVL(.Item("QT_PESO_LIQUIDO"), 0)
      txtPesoBruto.Value = FNC_NVL(.Item("QT_PESO_BRUTO"), 0)
      chkRegistradoGTIN.Checked = (FNC_NVL(.Item("IC_REGISTRADO_GTIN"), "N") = "S")
    End With

    sSqlText = "SELECT * FROM TB_PRODUTO_EMPRESA WHERE ID_PRODUTO = " & iSQ_PRODUTO & " AND ID_EMPRESA = " & iID_EMPRESA_MATRIZ
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        iSQ_PRODUTO_EMPRESA = .Item("SQ_PRODUTO_EMPRESA")
        ComboBox_Selecionar(cboGrupoProduto, FNC_NVL(.Item("ID_GRUPOPRODUTO"), 0))
        ComboBox_Selecionar(cboTipoProduto, FNC_NVL(.Item("ID_TIPO_PRODUTO"), 0))
        txtCodigoBarra.Text = FNC_NVL(.Item("CD_BARRA"), "")
        txtValidadeCotacao.Value = FNC_NVL(.Item("NR_VALIDADE_COTACAO"), 0)
        txtPrecoCusto.Value = FNC_NVL(.Item("VL_PRECOCUSTO"), 0)
        txtICMSEntrada_Porc.Value = FNC_NVL(.Item("PC_ICMS_ENTRADA"), 0)
        txtICMSST_Porc.Value = FNC_NVL(.Item("PC_ICMS_ST"), 0)
        txtICMSaida_Porc.Value = FNC_NVL(.Item("PC_ICMS_SAIDA"), 0)
        txtSimplesNacional_Porc.Value = FNC_NVL(.Item("PC_SIMPLESNACIONAL"), 0)
        txtCustoFixo_Porc.Value = FNC_NVL(.Item("PC_CUSTO_FIXO"), 0)
        txtCustoVariavel_Porc.Value = FNC_NVL(.Item("PC_CUSTO_VARIAVEL"), 0)
        txtOutrosImpostos_Porc.Value = FNC_NVL(.Item("PC_OUTROS_IMPOSTOS"), 0)
        txtFreteEntrada_Porc.Value = FNC_NVL(.Item("PC_FRETE_ENTRADA"), 0)
        txtValorBrindeAcessorios.Value = FNC_NVL(.Item("VL_BRINDE_ACESSORIO"), 0)
        chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "N") = "S")
        ComboBox_Selecionar(cboOrigemProduto, FNC_NVL(.Item("ID_OPT_ORIGEMPRODUTO"), 0))
        ComboBox_Selecionar(cboModalidade_BC_ICMS, FNC_NVL(.Item("ID_OPT_MODALIDADE_BC_ICMS"), 0))
        ComboBox_Selecionar(cboModalidade_BC_ICMS_ST, FNC_NVL(.Item("ID_OPT_MODALIDADE_BC_ICMS_ST"), 0))
        picProduto.Arquivo = .Item("DS_PATH_IMAGEM")
      End With
    End If

    sSqlText = "SELECT * FROM TB_PRODUTO_EMPRESA_FILIAL WHERE ID_PRODUTO_EMPRESA = " & iSQ_PRODUTO_EMPRESA & " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        txtDiaMinimoEntrega.Value = FNC_NVL(.Item("NR_DIA_ENTREGA_MINIMO"), 0)
        lblDataUltimaCompra.Text = FNC_NVL(.Item("DT_ULTIMA_COMPRA"), "")
        lblDataUltimaVenda.Text = FNC_NVL(.Item("DT_ULTIMA_VENDA"), "")
        chkControladoPorNumeroSerie.Checked = (FNC_NVL(.Item("IC_CONTROLA_NUMERO_SERIE"), "N") = "S")
        chkControleGarantia.Checked = (FNC_NVL(.Item("IC_CONTROLE_GARANTIA"), "N") = "S")
        txtEstoqueRecomendado.Value = FNC_NVL(.Item("QT_ESTOQUE_RECOMENDADO"), 0)
        txtEstoqueMinimo.Value = FNC_NVL(.Item("QT_ESTOQUE_MINIMO"), 0)
        txtMesesGarantiaFornecedor.Value = FNC_NVL(.Item("NR_MESES_GARANTIA_FORNECEDOR"), 0)
        txtMesesGarantiaRevenda.Value = FNC_NVL(.Item("NR_MESES_GARANTIA_REVENDA"), 0)
        ComboBox_Selecionar(cboLinhaProdutoVenda, FNC_NVL(.Item("ID_PRODUTO_LINHA"), 0))
      End With
    End If

    sSqlText = "SELECT * FROM VW_TABELAPRECO_PRODUTO_ATIVO WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & " AND ID_PRODUTO_EMPRESA = " & iSQ_PRODUTO_EMPRESA
    oData = DBQuery(sSqlText)

    For iCont_01 = 0 To oData.Rows.Count - 1
      For iCont_02 = 0 To grdTabelaPreco.Rows.Count - 1
        If oData.Rows(iCont_01).Item("ID_TABELAPRECO") = objGrid_Valor(grdTabelaPreco, const_GridTabelaPreco_ID_TABELAPRECO, iCont_02) Then
          With grdTabelaPreco.Rows(iCont_02)
            .Cells(const_GridTabelaPreco_Sel).Value = 1
            .Cells(const_GridTabelaPreco_DescontoMaximo).Value = FNC_NVL(oData.Rows(iCont_01).Item("PC_DESCONTO_MAXIMO"), 0)
            .Cells(const_GridTabelaPreco_MargemLucro).Value = FNC_NVL(oData.Rows(iCont_01).Item("PC_MARGEM_LUCRO"), 0)
            .Cells(const_GridTabelaPreco_CustoTotal).Value = FNC_NVL(oData.Rows(iCont_01).Item("VL_PRECOCUSTOTOTAL"), 0)
            .Cells(const_GridTabelaPreco_ValorVenda).Value = FNC_NVL(oData.Rows(iCont_01).Item("VL_VENDA"), 0)
            Exit For
          End With
        End If
      Next
    Next

    CarregarDados_Fornecedor()

    HabilitarControleMatriz(iID_EMPRESA_FILIAL = iID_EMPRESA_MATRIZ)

    sSqlText = "SELECT * FROM TB_PRODUTO_CARACTERISTICA WHERE ID_PRODUTO = " & iSQ_PRODUTO
    oData = DBQuery(sSqlText)

    For iCont_01 = 0 To oData.Rows.Count - 1
      For iCont_02 = 0 To cklCaracteriscaProduto.Items.Count - 1
        If cklCaracteriscaProduto.Items(iCont_02)(0) = oData.Rows(iCont_01).Item("ID_CARACTERISTICA_PRODUTO") Then
          cklCaracteriscaProduto.SetItemCheckState(iCont_02, CheckState.Checked)
        End If
      Next
    Next

    bCarregandoProduto = False
  End Sub

  Private Sub CarregarDados_Fornecedor()
    Dim sSqlText As String

    sSqlText = "SELECT ID_FORNECEDOR," &
                      "NO_FORNECEDOR," &
                      "CD_PRODUTO_FORNECEDOR," &
                      "VL_UNITARIO_UTLIMACOMPRA," &
                      const_GridAcao_Neutro &
               " FROM VW_PRODUTO_FORNECEDOR" &
               " WHERE ID_PRODUTO_EMPRESA = " & iSQ_PRODUTO_EMPRESA &
               " ORDER BY NO_FORNECEDOR"
    objGrid_Carregar(grdFornecedor, sSqlText, New Integer() {const_GridFornecedor_ID_FORNECEDOR,
                                                             const_GridFornecedor_NomeFornecedor,
                                                             const_GridFornecedor_CodigoFornecedor,
                                                             const_GridFornecedor_ValorUnitarioUltimaCompra,
                                                             const_GridFornecedor_Acao})
  End Sub

  Private Sub HabilitarControleMatriz(bHabilitar As Boolean)
    cboGrupoProduto.Enabled = bHabilitar
    cboTipoProduto.Enabled = bHabilitar
    txtCodigoBarra.Enabled = bHabilitar
    txtValidadeCotacao.Enabled = bHabilitar
    txtPrecoCusto.Enabled = bHabilitar
    txtICMSEntrada_Porc.Enabled = bHabilitar
    txtICMSST_Porc.Enabled = bHabilitar
    txtICMSaida_Porc.Enabled = bHabilitar
    txtCustoVariavel_Porc.Enabled = bHabilitar
    txtOutrosImpostos_Porc.Enabled = bHabilitar
    txtFreteEntrada_Porc.Enabled = bHabilitar
    chkAtivo.Enabled = bHabilitar
    cboOrigemProduto.Enabled = bHabilitar
    picProduto.HabilitarBotoes = bHabilitar
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Gravar()
  End Sub

  Public Sub Gravar()
    Dim sSqlText As String
    Dim iCont As Integer

    If Trim(txtNomeProduto.Text) = "" Then
      FNC_Mensagem("Informe o nome do produto")
      Exit Sub
    End If
    If Trim(txtCodigo.Text) = "" Then
      FNC_Mensagem("Informar o código de produto")
    Else
      If FormPesquisaProduto_CodigoExiste(txtCodigo.Text, iSQ_PRODUTO) Then
        FNC_Mensagem("Código de produto já cadastrado")
        Exit Sub
      End If
    End If
    If Not ComboBox_Selecionado(cboGrupoProduto) Then
      FNC_Mensagem("É necessário selecionar o grupo de produto")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoProduto) Then
      FNC_Mensagem("É necessário selecionar o tipo de produto")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboUnidadeMedida) Then
      FNC_Mensagem("É necessário selecionar a unidade de medida")
      Exit Sub
    End If

    DBUsarTransacao = True

    sSqlText = DBMontar_SP("SP_PRODUTO_CAD", False, "@SQ_PRODUTO OUT",
                                                    "@ID_UNIDADEMEDIDA",
                                                    "@ID_PESSOA_FABRICANTE",
                                                    "@ID_GRUPOTRIBUTARIO",
                                                    "@ID_CST",
                                                    "@ID_CSOSN",
                                                    "@ID_NCM",
                                                    "@ID_CST_COFINS",
                                                    "@ID_CST_IPI",
                                                    "@ID_CST_PIS",
                                                    "@CD_PRODUTO",
                                                    "@CD_BARRA_FABRICANTE",
                                                    "@NO_PRODUTO",
                                                    "@DS_PRODUTO",
                                                    "@PC_COFINS",
                                                    "@PC_IPI",
                                                    "@PC_PIS",
                                                    "@PC_MVA",
                                                    "@PC_ALIQUOTA_IBPT_ESTADUAL",
                                                    "@PC_ALIQUOTA_IBPT_NACIONAL",
                                                    "@QT_PESO_LIQUIDO",
                                                    "@QT_PESO_BRUTO",
                                                    "@IC_REGISTRADO_GTIN")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_PRODUTO", iSQ_PRODUTO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_UNIDADEMEDIDA", cboUnidadeMedida.SelectedValue),
                            DBParametro_Montar("ID_PESSOA_FABRICANTE", cboFabricante.SelectedValue),
                            DBParametro_Montar("ID_GRUPOTRIBUTARIO", cboGrupoTributario.SelectedValue),
                            DBParametro_Montar("ID_CST", UltraComboBox_Valor(cboCST)),
                            DBParametro_Montar("ID_CSOSN", UltraComboBox_Valor(cboCSOSN)),
                            DBParametro_Montar("ID_NCM", FNC_NuloSe(txtNCM.Tag, 0)),
                            DBParametro_Montar("ID_CST_COFINS", UltraComboBox_Valor(cboCSTCofins)),
                            DBParametro_Montar("ID_CST_IPI", UltraComboBox_Valor(cboCSTIPI)),
                            DBParametro_Montar("ID_CST_PIS", UltraComboBox_Valor(cboCSTPIS)),
                            DBParametro_Montar("CD_PRODUTO", FNC_NuloSe(Trim(txtCodigo.Text), "")),
                            DBParametro_Montar("CD_BARRA_FABRICANTE", FNC_NuloSe(txtCodigoFabricante.Text, "")),
                            DBParametro_Montar("NO_PRODUTO", Trim(txtNomeProduto.Text)),
                            DBParametro_Montar("DS_PRODUTO", Nothing),
                            DBParametro_Montar("PC_COFINS", FNC_NVL(txtCOFINS.Value, 0)),
                            DBParametro_Montar("PC_IPI", FNC_NVL(txtIPI.Value, 0)),
                            DBParametro_Montar("PC_PIS", FNC_NVL(txtPIS.Value, 0)),
                            DBParametro_Montar("PC_MVA", FNC_NVL(txtMVA.Value, 0)),
                            DBParametro_Montar("PC_ALIQUOTA_IBPT_ESTADUAL", FNC_NVL(txtIBPT_Estadual.Value, 0)),
                            DBParametro_Montar("PC_ALIQUOTA_IBPT_NACIONAL", FNC_NVL(txtIBPT_Nacional.Value, 0)),
                            DBParametro_Montar("QT_PESO_LIQUIDO", FNC_NVL(txtPesoLiquido.Value, 0)),
                            DBParametro_Montar("QT_PESO_BRUTO", FNC_NVL(txtPesoBruto.Value, 0)),
                            DBParametro_Montar("IC_REGISTRADO_GTIN", IIf(chkRegistradoGTIN.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_PRODUTO = DBRetorno(1)
      End If

      sSqlText = DBMontar_SP("SP_PRODUTO_EMPRESA_CAD", False, "@SQ_PRODUTO_EMPRESA OUT",
                                                              "@ID_PRODUTO",
                                                              "@ID_EMPRESA",
                                                              "@ID_GRUPOPRODUTO",
                                                              "@ID_TIPO_PRODUTO",
                                                              "@CD_BARRA",
                                                              "@NR_VALIDADE_COTACAO",
                                                              "@VL_PRECOCUSTO",
                                                              "@PC_ICMS_ENTRADA",
                                                              "@PC_ICMS_SAIDA",
                                                              "@PC_SIMPLESNACIONAL",
                                                              "@PC_CUSTO_FIXO",
                                                              "@PC_CUSTO_VARIAVEL",
                                                              "@PC_OUTROS_IMPOSTOS",
                                                              "@VL_PRECOCUSTOTOTAL",
                                                              "@VL_BRINDE_ACESSORIO",
                                                              "@DT_CADASTRO",
                                                              "@IC_ATIVO",
                                                              "@ID_OPT_ORIGEMPRODUTO",
                                                              "@ID_OPT_MODALIDADE_BC_ICMS",
                                                              "@ID_OPT_MODALIDADE_BC_ICMS_ST",
                                                              "@PC_ICMS_ST",
                                                              "@PC_FRETE_ENTRADA",
                                                              "@DS_PATH_IMAGEM")
      If Not DBExecutar(sSqlText, DBParametro_Montar("SQ_PRODUTO_EMPRESA", iSQ_PRODUTO_EMPRESA, , ParameterDirection.InputOutput),
                                  DBParametro_Montar("ID_PRODUTO", iSQ_PRODUTO),
                                  DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                  DBParametro_Montar("ID_GRUPOPRODUTO", cboGrupoProduto.SelectedValue),
                                  DBParametro_Montar("ID_TIPO_PRODUTO", cboTipoProduto.SelectedValue),
                                  DBParametro_Montar("CD_BARRA", Trim(txtCodigoBarra.Text)),
                                  DBParametro_Montar("NR_VALIDADE_COTACAO", txtValidadeCotacao.Value),
                                  DBParametro_Montar("VL_PRECOCUSTO", txtPrecoCusto.Value),
                                  DBParametro_Montar("PC_ICMS_ENTRADA", txtICMSEntrada_Porc.Value),
                                  DBParametro_Montar("PC_ICMS_SAIDA", txtICMSaida_Porc.Value),
                                  DBParametro_Montar("PC_SIMPLESNACIONAL", txtSimplesNacional_Porc.Value),
                                  DBParametro_Montar("PC_CUSTO_FIXO", txtCustoFixo_Porc.Value),
                                  DBParametro_Montar("PC_CUSTO_VARIAVEL", txtCustoVariavel_Porc.Value),
                                  DBParametro_Montar("PC_OUTROS_IMPOSTOS", txtOutrosImpostos_Porc.Value),
                                  DBParametro_Montar("VL_PRECOCUSTOTOTAL", txtCustoTotal.Value),
                                  DBParametro_Montar("VL_BRINDE_ACESSORIO", txtValorBrindeAcessorios.Value),
                                  DBParametro_Montar("DT_CADASTRO", Now.Date, SqlDbType.Date),
                                  DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N")),
                                  DBParametro_Montar("ID_OPT_ORIGEMPRODUTO", cboOrigemProduto.SelectedValue),
                                  DBParametro_Montar("ID_OPT_MODALIDADE_BC_ICMS", cboModalidade_BC_ICMS.SelectedValue),
                                  DBParametro_Montar("ID_OPT_MODALIDADE_BC_ICMS_ST", cboModalidade_BC_ICMS_ST.SelectedValue),
                                  DBParametro_Montar("PC_ICMS_ST", txtICMSST_Porc.Value),
                                  DBParametro_Montar("PC_FRETE_ENTRADA", txtFreteEntrada_Porc.Value),
                                  DBParametro_Montar("DS_PATH_IMAGEM", picProduto.ArquivoGravacao)) Then GoTo Erro
      If DBTeveRetorno() Then
        iSQ_PRODUTO_EMPRESA = DBRetorno(1)
      End If

      sSqlText = DBMontar_SP("SP_PRODUTO_EMPRESA_FILIAL_CAD", False, "@ID_PRODUTO_EMPRESA",
                                                                     "@ID_EMPRESA",
                                                                     "@ID_PRODUTO_LINHA",
                                                                     "@NR_DIA_ENTREGA_MINIMO",
                                                                     "@IC_CONTROLA_NUMERO_SERIE",
                                                                     "@IC_CONTROLE_GARANTIA",
                                                                     "@QT_ESTOQUE_RECOMENDADO",
                                                                     "@QT_ESTOQUE_MINIMO",
                                                                     "@NR_MESES_GARANTIA_FORNECEDOR",
                                                                     "@NR_MESES_GARANTIA_REVENDA")
      If Not DBExecutar(sSqlText, DBParametro_Montar("ID_PRODUTO_EMPRESA", iSQ_PRODUTO_EMPRESA),
                                  DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                  DBParametro_Montar("ID_PRODUTO_LINHA", cboLinhaProdutoVenda.SelectedValue),
                                  DBParametro_Montar("NR_DIA_ENTREGA_MINIMO", txtDiaMinimoEntrega.Value),
                                  DBParametro_Montar("IC_CONTROLA_NUMERO_SERIE", IIf(chkControladoPorNumeroSerie.Checked, "S", "N")),
                                  DBParametro_Montar("IC_CONTROLE_GARANTIA", IIf(chkControleGarantia.Checked, "S", "N")),
                                  DBParametro_Montar("QT_ESTOQUE_RECOMENDADO", txtEstoqueRecomendado.Value),
                                  DBParametro_Montar("QT_ESTOQUE_MINIMO", txtEstoqueMinimo.Value),
                                  DBParametro_Montar("NR_MESES_GARANTIA_FORNECEDOR", txtMesesGarantiaFornecedor.Value),
                                  DBParametro_Montar("NR_MESES_GARANTIA_REVENDA", txtMesesGarantiaRevenda.Value)) Then GoTo Erro

      For iCont = 0 To grdTabelaPreco.Rows.Count - 1
        If objGrid_CheckBox_Selecionado(grdTabelaPreco, const_GridTabelaPreco_Sel, iCont) Then
          With grdTabelaPreco.Rows(iCont)
            FormCadastroTabelaPreco_Produto(.Cells(const_GridTabelaPreco_ID_TABELAPRECO).Value,
                                            iSQ_PRODUTO_EMPRESA,
                                            txtPrecoCusto.Value,
                                            txtICMSEntrada_Porc.Value,
                                            txtICMSaida_Porc.Value,
                                            txtICMSST_Porc.Value,
                                            txtSimplesNacional_Porc.Value,
                                            txtCustoFixo_Porc.Value,
                                            txtCustoVariavel_Porc.Value,
                                            txtOutrosImpostos_Porc.Value,
                                            0,
                                            txtCustoTotal.Value,
                                            Val(.Cells(const_GridTabelaPreco_DescontoMaximo).Value),
                                            Val(.Cells(const_GridTabelaPreco_MargemLucro).Value),
                                            txtValorBrindeAcessorios.Value,
                                            Val(.Cells(const_GridTabelaPreco_ValorVenda).Value))
          End With
        End If
      Next

      For iCont = 0 To grdFornecedor.Rows.Count - 1
        With grdFornecedor.Rows(iCont)
          Select Case .Cells(const_GridFornecedor_Acao).Value
            Case const_GridAcao_Gravar
              sSqlText = DBMontar_SP("SP_PRODUTO_FORNECEDOR_CAD", False, "@ID_PRODUTO_EMPRESA",
                                                                         "@ID_FORNECEDOR",
                                                                         "@CD_PRODUTO_FORNECEDOR",
                                                                         "@VL_UNITARIO_UTLIMACOMPRA")
              DBExecutar(sSqlText, DBParametro_Montar("ID_PRODUTO_EMPRESA", iSQ_PRODUTO_EMPRESA),
                                   DBParametro_Montar("ID_FORNECEDOR", .Cells(const_GridFornecedor_ID_FORNECEDOR).Value),
                                   DBParametro_Montar("CD_PRODUTO_FORNECEDOR", .Cells(const_GridFornecedor_CodigoFornecedor).Value),
                                   DBParametro_Montar("VL_UNITARIO_UTLIMACOMPRA", .Cells(const_GridFornecedor_ValorUnitarioUltimaCompra).Value, SqlDbType.Money))
            Case const_GridAcao_Excluir
              sSqlText = DBMontar_SP("SP_PRODUTO_FORNECEDOR_DEL", False, "@ID_PRODUTO_EMPRESA",
                                                                         "@ID_FORNECEDOR")
              DBExecutar(sSqlText, DBParametro_Montar("ID_PRODUTO_EMPRESA", iSQ_PRODUTO_EMPRESA),
                                   DBParametro_Montar("ID_FORNECEDOR", .Cells(const_GridFornecedor_ID_FORNECEDOR).Value))
          End Select
        End With
      Next

      For iCont = 0 To cklCaracteriscaProduto.Items.Count - 1
        If cklCaracteriscaProduto.GetItemChecked(iCont) Then
          sSqlText = DBMontar_SP("SP_PRODUTO_CARACTERISTICA_CAD", False, "@ID_PRODUTO",
                                                                         "@ID_CARACTERISTICA_PRODUTO")
          DBExecutar(sSqlText, DBParametro_Montar("ID_PRODUTO", iSQ_PRODUTO),
                               DBParametro_Montar("ID_CARACTERISTICA_PRODUTO", cklCaracteriscaProduto.Items(iCont)(0)))
        Else
          sSqlText = DBMontar_SP("SP_PRODUTO_CARACTERISTICA_DEL", False, "@ID_PRODUTO",
                                                                         "@ID_CARACTERISTICA_PRODUTO")
          DBExecutar(sSqlText, DBParametro_Montar("ID_PRODUTO", iSQ_PRODUTO),
                               DBParametro_Montar("ID_CARACTERISTICA_PRODUTO", cklCaracteriscaProduto.Items(iCont)(0)))
        End If
      Next

      picProduto.ValidarArquivo()

      If Not DBExecutarTransacao() Then GoTo Erro

      RaiseEvent Pesquisar()

      CarregarDados_Fornecedor()

      bGravado = True

      FNC_Mensagem("Gravação efetuada")

      If Not oNFe_Produto Is Nothing Then
        cmdFechar_Click(Nothing, Nothing)
      End If
    Else
      GoTo Erro
    End If

    Exit Sub

Erro:
    DBUsarTransacao = False
  End Sub

  Private Sub txtNCM_LostFocus(sender As Object, e As EventArgs) Handles txtNCM.LostFocus
    FNC_NCM_Carregar(txtNCM, 0, txtNCM.Text, lblNCM_Descricao, ToolTip1, txtIBPT_Estadual.Value)
  End Sub

  Private Function ValidarCamposPreenchidos()
    If UltraComboBox_Selecionado(cboCSTPIS) Then
      If FNC_NVL(txtPIS.Value, 0) = 0 Then
        FNC_Mensagem("O percentual do PIS não foi informado ")
        GoTo Erro
      End If
    End If
    If UltraComboBox_Selecionado(cboCSTCofins) Then
      If FNC_NVL(txtCOFINS.Value, 0) = 0 Then
        FNC_Mensagem("O percentual do COFINS não foi informado")
        GoTo Erro
      End If
    End If
    If UltraComboBox_Selecionado(cboCSTIPI) Then
      If FNC_NVL(txtIPI.Value, 0) = 0 Then
        FNC_Mensagem("O percentual do IPI não foi informado")
        GoTo Erro
      End If
    End If
    If FNC_NVL(txtCOFINS.Value, 0) <> 0 Then
      If Not UltraComboBox_Selecionado(cboCSTCofins) Then
        FNC_Mensagem("O CST do COFINS não foi informado")
        GoTo Erro
      End If
    End If
    If FNC_NVL(txtIPI.Value, 0) <> 0 Then
      If Not UltraComboBox_Selecionado(cboCSTIPI) Then
        FNC_Mensagem("O CST do IPI não foi informado")
        GoTo Erro
      End If
    End If
    'If FNC_NVL(txtPrecoCusto.Value, 0) = 0 Then
    '  FNC_Mensagem("O preço de custo não foi informado")
    '  GoTo Erro
    'End If
    If Trim(txtNCM.Text) <> "" Then
      If FNC_NVL(txtIBPT_Estadual.Value, 0) = 0 Then
        FNC_Mensagem("O percentual do IBPT não foi informado")
        GoTo Erro
      End If
    End If
    'If Trim(txtNCM.Text) = "" Then
    '  FNC_Mensagem("O NCM não foi informado")
    '  GoTo Erro
    'End If
    If Not UltraComboBox_Selecionado(cboCSOSN) Then
      FNC_Mensagem("O CSOSN não foi informado")
      GoTo Erro
    End If
    If Not UltraComboBox_Selecionado(cboCST) Then
      FNC_Mensagem("O CST não foi informado")
      GoTo Erro
    End If
    If Not ComboBox_Selecionado(cboOrigemProduto) Then
      FNC_Mensagem("A origem não foi informada")
      GoTo Erro
    End If
    If Not ComboBox_Selecionado(cboUnidadeMedida) Then
      FNC_Mensagem("A unidade de medida não foi informado")
      GoTo Erro
    End If
    If Not ComboBox_Selecionado(cboGrupoProduto) Then
      FNC_Mensagem("O grupo não foi informado")
      GoTo Erro
    End If
    If Not ComboBox_Selecionado(cboTipoProduto) Then
      FNC_Mensagem("O tipo de item não foi informado")
      GoTo Erro
    End If
    If Trim(txtNomeProduto.Text) = "" Then
      FNC_Mensagem("Nome do produto não foi informado")
      GoTo Erro
    End If
    If chkControleGarantia.Checked Then
      If FNC_NVL(txtMesesGarantiaFornecedor.Value, 0) = 0 And FNC_NVL(txtMesesGarantiaRevenda.Value, 0) = 0 Then
        FNC_Mensagem("Para usar controle de garantia é necessário informar a quantidade de meses de garantia do fornecedor e/ou garantia de revenda")
        GoTo Erro
      End If
    End If

    Return True

    GoTo Erro

Erro:
    Return False
  End Function

  Private Sub cboGrupoProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoProduto.SelectedIndexChanged
    If ComboBox_Selecionado(cboGrupoProduto) And Not bCarregandoProduto And bFormCarrregado Then
      Dim iID_CST As Integer
      Dim iID_CSOSN As Integer
      Dim iID_CST_COFINS_PADRAO As Integer
      Dim iID_CST_IPI_PADRAO As Integer
      Dim iID_CST_PIS_PADRAO As Integer

      FNC_GrupoProduto_Carregar(cboGrupoProduto.SelectedValue, iID_CST, iID_CSOSN, iID_CST_COFINS_PADRAO, iID_CST_IPI_PADRAO, iID_CST_PIS_PADRAO)

      If Not UltraComboBox_Selecionado(cboCST) Then UltraComboBox_Selecionar(cboCST, 0, iID_CST)
      If Not UltraComboBox_Selecionado(cboCSOSN) Then UltraComboBox_Selecionar(cboCSOSN, 0, iID_CSOSN)
      If Not UltraComboBox_Selecionado(cboCSTCofins) Then UltraComboBox_Selecionar(cboCSTCofins, 0, iID_CST_COFINS_PADRAO)
      If Not UltraComboBox_Selecionado(cboCSTIPI) Then UltraComboBox_Selecionar(cboCSTIPI, 0, iID_CST_IPI_PADRAO)
      If Not UltraComboBox_Selecionado(cboCSTPIS) Then UltraComboBox_Selecionar(cboCSTPIS, 0, iID_CST_PIS_PADRAO)

      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT * FROM TB_GRUPOPRODUTO WHERE SQ_GRUPOPRODUTO = " & cboGrupoProduto.SelectedValue
      oData = DBQuery(sSqlText)

      With oData.Rows(0)
        If FNC_NVL(.Item("IC_CONTROLE_GARANTIA"), "N") = "S" And Not chkControleGarantia.Checked Then
          If iSQ_PRODUTO = 0 Then
            chkControleGarantia.Checked = True
          Else
            If FNC_Perguntar("Esse grupo de produto tem controle de garantia. Deseja alterar essa informação nesse produto?") Then
              chkControleGarantia.Checked = True
            End If
          End If
        End If
        If FNC_NVL(.Item("IC_CONTROLA_NUMERO_SERIE"), "N") = "S" And Not chkControladoPorNumeroSerie.Checked Then
          If iSQ_PRODUTO = 0 Then
            chkControladoPorNumeroSerie.Checked = True
          Else
            If FNC_Perguntar("Esse grupo de produto tem controle por número de série. Deseja alterar essa informação nesse produto?") Then
              chkControladoPorNumeroSerie.Checked = True
            End If
          End If
        End If
      End With
    End If
  End Sub

  Private Sub grdTabelaPreco_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdTabelaPreco.AfterCellUpdate
    If bProcessando Then Exit Sub
    bProcessando = True
    If objGrid_CheckCol_Valor(grdTabelaPreco, const_GridTabelaPreco_Sel, e.Cell.Row.Index) = "S" Then
      GridProduto_Calcular(e.Cell.Row.Index)
    Else
      grdTabelaPreco.Rows(e.Cell.Row.Index).Cells(const_GridTabelaPreco_CustoTotal).Value = 0
      grdTabelaPreco.Rows(e.Cell.Row.Index).Cells(const_GridTabelaPreco_ValorVenda).Value = 0
    End If
    bProcessando = False
  End Sub

  Private Sub GridProduto_Calcular(iRow As Integer)
    Dim dCustoTotal As Double
    Dim dPrecoVenda As Double

    With grdTabelaPreco.Rows(iRow)
      If objGrid_CheckCol_Valor(grdTabelaPreco, const_GridTabelaPreco_Sel, iRow) = "S" Then
        FNC_CalculaPrecoVenda(txtPrecoCusto.Value,
                              txtICMSEntrada_Porc.Value,
                              txtICMSST_Porc.Value,
                              txtICMSaida_Porc.Value,
                              txtSimplesNacional_Porc.Value,
                              txtCustoFixo_Porc.Value,
                              txtCustoVariavel_Porc.Value,
                              txtOutrosImpostos_Porc.Value,
                              txtFreteEntrada_Porc.Value,
                              0,
                              FNC_NVL(.Cells(const_GridTabelaPreco_Comissao).Value, 0),
                              FNC_NVL(.Cells(const_GridTabelaPreco_MargemLucro).Value, 0),
                              0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                              dCustoTotal,
                              dPrecoVenda,
                              False)
        .Cells(const_GridTabelaPreco_CustoTotal).Value = dCustoTotal
        .Cells(const_GridTabelaPreco_ValorBrindeAcessorio).Value = FNC_NVL(txtValorBrindeAcessorios.Value, 0)

        dPrecoVenda = dPrecoVenda + FNC_NVL(txtValorBrindeAcessorios.Value, 0)
        dPrecoVenda = dPrecoVenda + FNC_Porcentagem(FNC_NVL(txtValorBrindeAcessorios.Value, 0), FNC_NVL(.Cells(const_GridTabelaPreco_MargemLucro).Value, 0))
        .Cells(const_GridTabelaPreco_ValorVenda).Value = dPrecoVenda
      End If
    End With
  End Sub

  Private Sub txtCodigoBarra_LostFocus(sender As Object, e As EventArgs) Handles txtCodigoBarra.LostFocus
    ToolTip1.SetToolTip(txtCodigoBarra, txtCodigoBarra.Text)
  End Sub

  Private Sub txtSimplesNacional_Porc_ValueChanged(sender As Object, e As EventArgs) Handles txtSimplesNacional_Porc.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub txtCustoFixo_Porc_ValueChanged(sender As Object, e As EventArgs) Handles txtCustoFixo_Porc.ValueChanged
    CalculaPrecoVenda()
  End Sub

  Private Sub txtValorBrindeAcessorios_ValueChanged(sender As Object, e As EventArgs) Handles txtValorBrindeAcessorios.ValueChanged
    TabelaPreco_Atualizar()
  End Sub

  Private Sub chkControleGarantia_CheckedChanged(sender As Object, e As EventArgs) Handles chkControleGarantia.CheckedChanged
    ControleGarantia_TratarControle()
  End Sub

  Private Sub ControleGarantia_TratarControle()
    lblRMesesGarantiaFornecedor.Enabled = chkControleGarantia.Checked
    txtMesesGarantiaFornecedor.Enabled = chkControleGarantia.Checked
    lblRMesesGarantiaRevenda.Enabled = chkControleGarantia.Checked
    txtMesesGarantiaRevenda.Enabled = chkControleGarantia.Checked
    cmdAtualizarGarantia.Enabled = chkControleGarantia.Checked
    chkControladoPorNumeroSerie.Enabled = (Not chkControleGarantia.Checked)
    chkControladoPorNumeroSerie.Checked = IIf(chkControleGarantia.Checked, True, chkControladoPorNumeroSerie.Checked)
  End Sub

  Private Sub Fornecedor_FormatarBotao(bAdicionar As Boolean)
    If bAdicionar Then
      cmdGravarFornecedor.Text = "      Adicionar"
      cmdGravarFornecedor.Image = My.Resources.Resources.Mini_Adicionar
    Else
      cmdGravarFornecedor.Text = "      Atualizar"
      cmdGravarFornecedor.Image = My.Resources.Resources.Mini_Atualizar
    End If
  End Sub

  Private Sub Fornecedor_Novo()
    iLinhaFornecedor = -1
    Fornecedor_FormatarBotao(True)
    psqFornecedor.ID_Pessoa = 0
    txtCodigoProdutoFornecedor.Text = ""
    txtValorUltimaCompraFornecedor.Value = 0
    cmdRemoverFornecedor.Enabled = False
  End Sub

  Private Sub cmdNovoFornecedor_Click(sender As Object, e As EventArgs) Handles cmdNovoFornecedor.Click
    Fornecedor_Novo()
  End Sub

  Private Sub cmdGravarFornecedor_Click(sender As Object, e As EventArgs) Handles cmdGravarFornecedor.Click
    If psqFornecedor.ID_Pessoa = 0 Then
      FNC_Mensagem("É preciso selecionar o fornecedor")
      Exit Sub
    End If

    If iLinhaFornecedor = -1 Then
      iLinhaFornecedor = oDBFornecedor.Rows.Add().Index
    End If

    With grdFornecedor.Rows(iLinhaFornecedor)
      .Cells(const_GridFornecedor_ID_FORNECEDOR).Value = psqFornecedor.ID_Pessoa
      .Cells(const_GridFornecedor_NomeFornecedor).Value = psqFornecedor.DS_Pessoa
      .Cells(const_GridFornecedor_CodigoFornecedor).Value = txtCodigoProdutoFornecedor.Text
      .Cells(const_GridFornecedor_ValorUnitarioUltimaCompra).Value = txtValorUltimaCompraFornecedor.Value
      .Cells(const_GridFornecedor_Acao).Value = const_GridAcao_Gravar
    End With
  End Sub

  Private Sub cmdRemoverFornecedor_Click(sender As Object, e As EventArgs) Handles cmdRemoverFornecedor.Click
    With grdFornecedor.Rows(iLinhaFornecedor)
      If .Cells(const_GridFornecedor_Acao).Value = const_GridAcao_Excluir Then
        .Appearance.BackColor = Color.White
        .Cells(const_GridFornecedor_Acao).Value = const_GridAcao_Neutro
      Else
        .Appearance.BackColor = Color.Gray
        .Cells(const_GridFornecedor_Acao).Value = const_GridAcao_Excluir
      End If
    End With
  End Sub

  Private Sub grdFornecedor_AfterSelectChange(sender As Object, e As AfterSelectChangeEventArgs) Handles grdFornecedor.AfterSelectChange
    If grdFornecedor.DisplayLayout.ActiveRow Is Nothing Then
      Fornecedor_Novo()
    Else
      With grdFornecedor.DisplayLayout.ActiveRow
        iLinhaFornecedor = .Index
        cmdRemoverFornecedor.Enabled = True
        psqFornecedor.ID_Pessoa = .Cells(const_GridFornecedor_ID_FORNECEDOR).Value
        txtCodigoProdutoFornecedor.Text = .Cells(const_GridFornecedor_CodigoFornecedor).Value
        txtValorUltimaCompraFornecedor.Value = .Cells(const_GridFornecedor_ValorUnitarioUltimaCompra).Value
      End With
    End If
  End Sub

  Private Sub cmdAtualizarGarantia_Click(sender As Object, e As EventArgs) Handles cmdAtualizarGarantia.Click
    Dim sSqlText As String

    If iSQ_PRODUTO_EMPRESA > 0 Then
      sSqlText = DBMontar_SP("SP_PRODUTO_EMPRESA_NUMEROSERIE_GARANTIA_UPD", False, "@ID_EMPRESA",
                                                                                   "@ID_PRODUTO_EMPRESA")
      DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL, , ParameterDirection.InputOutput),
                           DBParametro_Montar("ID_PRODUTO_EMPRESA", iSQ_PRODUTO_EMPRESA))

      FNC_Mensagem("Garantia atualiza para esse produto")
    End If
  End Sub

  Private Sub cboOrigemProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles cboOrigemProduto.KeyDown
    If e.KeyCode = Keys.Delete Then cboUnidadeMedida.SelectedIndex = -1
  End Sub

  Private Sub cboGrupoTributario_KeyDown(sender As Object, e As KeyEventArgs) Handles cboGrupoTributario.KeyDown
    If e.KeyCode = Keys.Delete Then cboGrupoTributario.SelectedIndex = -1
  End Sub

  Private Sub cboModalidade_BC_ICMS_KeyDown(sender As Object, e As KeyEventArgs) Handles cboModalidade_BC_ICMS.KeyDown
    If e.KeyCode = Keys.Delete Then cboModalidade_BC_ICMS.SelectedIndex = -1
  End Sub

  Private Sub cboModalidade_BC_ICMS_ST_KeyDown(sender As Object, e As KeyEventArgs) Handles cboModalidade_BC_ICMS_ST.KeyDown
    If e.KeyCode = Keys.Delete Then cboModalidade_BC_ICMS_ST.SelectedIndex = -1
  End Sub

  Private Sub frmCadastroProduto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdTabelaPreco, Me.Name)
    objGrid_Configuracao_Gravar(grdFornecedor, Me.Name)
  End Sub
End Class