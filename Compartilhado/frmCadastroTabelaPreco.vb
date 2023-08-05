Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmCadastroTabelaPreco
  Public Event Pesquisar()

  Const const_GridProduto_ID_PRODUTO_EMPRESA As Integer = 0
  Const const_GridProduto_ID_PRODUTO_LINHA As Integer = 1
  Const const_GridProduto_ID_PRODUTO As Integer = 2
  Const const_GridProduto_Sel As Integer = 3
  Const const_GridProduto_Tipo As Integer = 4
  Const const_GridProduto_Produto_ProdutoLinha As Integer = 5
  Const const_GridProduto_PrecoCusto As Integer = 6
  Const const_GridProduto_ICMSEntrada As Integer = 7
  Const const_GridProduto_ICMSST As Integer = 8
  Const const_GridProduto_ICMSSaida As Integer = 9
  Const const_GridProduto_SimplesNacional As Integer = 10
  Const const_GridProduto_CustoFixo As Integer = 11
  Const const_GridProduto_CustoVariavel As Integer = 12
  Const const_GridProduto_OutrosImpostos As Integer = 13
  Const const_GridProduto_FreteEntrada As Integer = 14
  Const const_GridProduto_CustoTotal As Integer = 15
  Const const_GridProduto_MargemLucro As Integer = 16
  Const const_GridProduto_Comissao As Integer = 17
  Const const_GridProduto_ValorBrindeAcessorio As Integer = 18
  Const const_GridProduto_ValorVenda As Integer = 19
  Const const_GridProduto_DescontoMaximo As Integer = 20

  Public iSQ_TABELAPRECO As Integer

  Dim oDBProduto As New UltraWinDataSource.UltraDataSource
  Dim bProcessando As Boolean

  Private Sub frmCadastroTabelaPreco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim sSqlText As String
    Dim iCont As Integer

    objGrid_Inicializar(grdListagemProduto, , oDBProduto, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagemProduto, "SQ_PRODUTO_EMPRESA", 0)
    objGrid_Coluna_Add(grdListagemProduto, "SQ_PRODUTO_LINHA", 0)
    objGrid_Coluna_Add(grdListagemProduto, "ID_PRODUTO", 0)
    objGrid_Coluna_Add(grdListagemProduto, "Sel.", 40, , True, ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdListagemProduto, "Tipo", 150)
    objGrid_Coluna_Add(grdListagemProduto, "Produto/Linha de Produto", 400)
    objGrid_Coluna_Add(grdListagemProduto, "Preço de Custo", 100, , , ColumnStyle.Currency, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_PrecoCusto))
    objGrid_Coluna_Add(grdListagemProduto, "ICMS Entrada %", 105, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_Impostos))
    objGrid_Coluna_Add(grdListagemProduto, "ICMS ST %", 90, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_Impostos))
    objGrid_Coluna_Add(grdListagemProduto, "ICMS Saída %", 95, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_Impostos))
    objGrid_Coluna_Add(grdListagemProduto, "Simples Nacional %", 120, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_Impostos))
    objGrid_Coluna_Add(grdListagemProduto, "Custo Fixo %", 100, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_Impostos))
    objGrid_Coluna_Add(grdListagemProduto, "Custo Variável %", 130, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_Impostos))
    objGrid_Coluna_Add(grdListagemProduto, "Outros Impostos %", 120, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_Impostos))
    objGrid_Coluna_Add(grdListagemProduto, "Frete de Entrada %", 120, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_Impostos))
    objGrid_Coluna_Add(grdListagemProduto, "Custo Total", 100, , , ColumnStyle.Currency, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_PrecoCusto))
    objGrid_Coluna_Add(grdListagemProduto, "Margem de Lucro %", 125, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_PrecoCusto))
    objGrid_Coluna_Add(grdListagemProduto, "Comissão %", 90, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_PrecoCusto))
    objGrid_Coluna_Add(grdListagemProduto, "Valor Brinde Acessório", 140, , , ColumnStyle.Currency, , const_Formato_Fracao_4casas).Hidden = (Not FNC_Permissao_Existe(enPermissao.PERM_FormacaoPreco_PrecoCusto))
    objGrid_Coluna_Add(grdListagemProduto, "Valor Venda", 100, , True, ColumnStyle.Currency, , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdListagemProduto, "Desconto Máximo", 100, , True, ColumnStyle.Double, , const_Formato_Fracao_4casas)
    objGrid_Configuracao_Carregar(grdListagemProduto, Me.Name)

    ComboBox_Carregar(cboTabelaPrecoBase, enSql.TabelaPreco_SemTabelaBase_Ativa)

    txtDataInicioUso.Value = Nothing
    txtDataFimUso.Value = Nothing

    sSqlText = "SELECT PEF.ID_PRODUTO_EMPRESA," &
                      "0," &
                      "PEF.ID_PRODUTO," &
                      "'0'," &
                      "'Produto' NO_TIPO," &
                      "PEF.NO_PRODUTO," &
                      "PEF.VL_PRECOCUSTO," &
                      "PEF.PC_ICMS_ENTRADA," &
                      "PEF.PC_ICMS_ST," &
                      "PEF.PC_ICMS_SAIDA," &
                      "PEF.PC_SIMPLESNACIONAL," &
                      "PEF.PC_CUSTO_FIXO," &
                      "PEF.PC_CUSTO_VARIAVEL," &
                      "PEF.PC_OUTROS_IMPOSTOS," &
                      "PEF.PC_FRETE_ENTRADA," &
                      "PEF.VL_PRECOCUSTOTOTAL," &
                      "PEF.VL_BRINDE_ACESSORIO" &
               " FROM VW_PRODUTO_EMPRESA_FILIAL PEF" &
               " WHERE PEF.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND PEF.IC_ATIVO = 'S'" &
               " UNION ALL " &
               "SELECT 0," &
                      "SQ_PRODUTO_LINHA," &
                      "0," &
                      "'0'," &
                      "'Linha de Produto'," &
                      "NO_PRODUTO_LINHA," &
                      "0 VL_PRECOCUSTO," &
                      "0 PC_ICMS_ENTRADA," &
                      "0 PC_ICMS_ST," &
                      "0 PC_ICMS_SAIDA," &
                      "0 PC_SIMPLESNACIONAL," &
                      "0 PC_CUSTO_FIXO," &
                      "0 PC_CUSTO_VARIAVEL," &
                      "0 PC_OUTROS_IMPOSTOS," &
                      "0 PC_FRETE_ENTRADA," &
                      "0 VL_PRECOCUSTOTOTAL," &
                      "0 VL_BRINDE_ACESSORIO" &
               " FROM TB_PRODUTO_LINHA" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND IC_ATIVO = 'S'" &
               " ORDER BY NO_TIPO, NO_PRODUTO"
    objGrid_Carregar(grdListagemProduto, sSqlText, New Integer() {const_GridProduto_ID_PRODUTO_EMPRESA,
                                                                  const_GridProduto_ID_PRODUTO_LINHA,
                                                                  const_GridProduto_ID_PRODUTO,
                                                                  const_GridProduto_Sel,
                                                                  const_GridProduto_Tipo,
                                                                  const_GridProduto_Produto_ProdutoLinha,
                                                                  const_GridProduto_PrecoCusto,
                                                                  const_GridProduto_ICMSEntrada,
                                                                  const_GridProduto_ICMSST,
                                                                  const_GridProduto_ICMSSaida,
                                                                  const_GridProduto_SimplesNacional,
                                                                  const_GridProduto_CustoFixo,
                                                                  const_GridProduto_CustoVariavel,
                                                                  const_GridProduto_OutrosImpostos,
                                                                  const_GridProduto_FreteEntrada,
                                                                  const_GridProduto_CustoTotal,
                                                                  const_GridProduto_ValorBrindeAcessorio})

    For iCont = 0 To grdListagemProduto.Rows.Count - 1
      grdListagemProduto.Rows(iCont).Cells(const_GridProduto_Sel).Value = False
    Next

    If iSQ_TABELAPRECO > 0 Then
      CarregarDados()
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim iCont As Integer
    Dim bAchou As Boolean

    If Trim(txtNomeTabelaPreco.Text) = "" Then
      FNC_Mensagem("Informe o nome da tabela de preço")
      Exit Sub
    End If
    If Not IsDate(txtDataInicioUso.Text) Then
      FNC_Mensagem("Informe a data de início de uso")
      Exit Sub
    End If
    If ComboBox_Selecionado(cboTabelaPrecoBase) Then
      If txtPercAcrescimoDecrescimo.Value = 0 Then
        FNC_Mensagem("É preciso informar o percentual de acréscimo ou decréscimo ref. a tabela de preço base")
        Exit Sub
      End If
    Else
      For iCont = 0 To grdListagemProduto.Rows.Count - 1
        If objGrid_CheckBox_Selecionado(grdListagemProduto, const_GridProduto_Sel, iCont) Then
          bAchou = True
          Exit For
        End If
      Next
      If Not bAchou Then
        FNC_Mensagem("Selecione algun(s) produto(s) para essa tabela de preço")
        Exit Sub
      End If
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_TABELAPRECO_CAD", False, "@SQ_TABELAPRECO OUT",
                                                        "@ID_EMPRESA",
                                                        "@ID_TABELAPRECO_BASE",
                                                        "@NO_TABELAPRECO",
                                                        "@DT_INICIO_USO",
                                                        "@DT_FIM_USO",
                                                        "@PC_DESCONTO_MAXIMO",
                                                        "@DT_ULTIMO_REAJUSTE",
                                                        "@IC_DISPONIVEL_FILIAL",
                                                        "@PC_MARGEM_LUCRO",
                                                        "@PC_COMISSAO",
                                                        "@PC_TABELAPRECO_BASE_ACRESCIMODECRESCIMO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_TABELAPRECO", iSQ_TABELAPRECO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_TABELAPRECO_BASE", cboTabelaPrecoBase.SelectedValue),
                            DBParametro_Montar("NO_TABELAPRECO", txtNomeTabelaPreco.Text),
                            DBParametro_Montar("DT_INICIO_USO", txtDataInicioUso.Value),
                            DBParametro_Montar("DT_FIM_USO", IIf(IsDate(txtDataFimUso.Text), txtDataFimUso.Value, Nothing)),
                            DBParametro_Montar("PC_DESCONTO_MAXIMO", txtDescontoMaximo.Value),
                            DBParametro_Montar("DT_ULTIMO_REAJUSTE", Now()),
                            DBParametro_Montar("IC_DISPONIVEL_FILIAL", IIf(chkDisponivelFilial.Checked, "S", "N")),
                            DBParametro_Montar("PC_MARGEM_LUCRO", txtMargemLucro.Value),
                            DBParametro_Montar("PC_COMISSAO", txtComissao.Value),
                            DBParametro_Montar("PC_TABELAPRECO_BASE_ACRESCIMODECRESCIMO", txtPercAcrescimoDecrescimo.Value)) Then
      If DBTeveRetorno() Then
        iSQ_TABELAPRECO = DBRetorno(1)
      End If

      For iCont = 0 To grdListagemProduto.Rows.Count - 1
        With grdListagemProduto.Rows(iCont)
          If FNC_NVL(.Cells(const_GridProduto_ID_PRODUTO_LINHA).Value, 0) = 0 Then
            If objGrid_CheckBox_Selecionado(grdListagemProduto, const_GridProduto_Sel, iCont) Then
              FormCadastroTabelaPreco_Produto(iSQ_TABELAPRECO,
                                            FNC_NVL(.Cells(const_GridProduto_ID_PRODUTO_EMPRESA).Value, 0),
                                            FNC_NVL(.Cells(const_GridProduto_PrecoCusto).Value, 0),
                                            FNC_NVL(.Cells(const_GridProduto_ICMSEntrada).Value, 0),
                                            FNC_NVL(.Cells(const_GridProduto_ICMSSaida).Value, 0),
                                            FNC_NVL(.Cells(const_GridProduto_ICMSST).Value, 0),
                                            FNC_NVL(.Cells(const_GridProduto_SimplesNacional).Value, 0),
                                            FNC_NVL(.Cells(const_GridProduto_CustoFixo).Value, 0),
                                            FNC_NVL(.Cells(const_GridProduto_CustoVariavel).Value, 0),
                                            FNC_NVL(.Cells(const_GridProduto_OutrosImpostos).Value, 0),
                                            0,
                                            Val(FNC_NVL(.Cells(const_GridProduto_CustoTotal).Value, 0)),
                                            Val(FNC_NVL(.Cells(const_GridProduto_DescontoMaximo).Value, 0)),
                                            Val(FNC_NVL(.Cells(const_GridProduto_MargemLucro).Value, 0)),
                                            Val(FNC_NVL(.Cells(const_GridProduto_ValorBrindeAcessorio).Value, 0)),
                                            Val(FNC_NVL(.Cells(const_GridProduto_ValorVenda).Value, 0)))
            Else
              sSqlText = DBMontar_SP("SP_TABELAPRECO_PRODUTO_DEL", False, "@ID_TABELAPRECO",
                                                                          "@ID_PRODUTO_EMPRESA")
              DBExecutar(sSqlText, DBParametro_Montar("ID_TABELAPRECO", iSQ_TABELAPRECO),
                                   DBParametro_Montar("ID_PRODUTO_EMPRESA", .Cells(const_GridProduto_ID_PRODUTO_EMPRESA).Value))
            End If
          Else
            If objGrid_CheckBox_Selecionado(grdListagemProduto, const_GridProduto_Sel, iCont) Then
              sSqlText = DBMontar_SP("SP_TABELAPRECO_PRODUTO_LINHA_CAD", False, "@ID_TABELAPRECO",
                                                                                "@ID_PRODUTO_LINHA",
                                                                                "@PC_DESCONTO_MAXIMO",
                                                                                "@VL_VENDA")
              DBExecutar(sSqlText, DBParametro_Montar("ID_TABELAPRECO", iSQ_TABELAPRECO),
                                   DBParametro_Montar("ID_PRODUTO_LINHA", .Cells(const_GridProduto_ID_PRODUTO_LINHA).Value),
                                   DBParametro_Montar("PC_DESCONTO_MAXIMO", Val(FNC_NVL(.Cells(const_GridProduto_DescontoMaximo).Value, 0))),
                                   DBParametro_Montar("VL_VENDA", Val(FNC_NVL(.Cells(const_GridProduto_ValorVenda).Value, 0))))
            Else
              sSqlText = DBMontar_SP("SP_TABELAPRECO_PRODUTO_LINHA_DEL", False, "@ID_TABELAPRECO",
                                                                                "@ID_PRODUTO_LINHA")
              DBExecutar(sSqlText, DBParametro_Montar("ID_TABELAPRECO", iSQ_TABELAPRECO),
                                   DBParametro_Montar("ID_PRODUTO_LINHA", .Cells(const_GridProduto_ID_PRODUTO_LINHA).Value))
            End If
          End If
        End With
      Next

      RaiseEvent Pesquisar()

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer

    bProcessando = True

    sSqlText = "SELECT * FROM TB_TABELAPRECO WHERE SQ_TABELAPRECO = " & iSQ_TABELAPRECO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      txtNomeTabelaPreco.Text = .Item("NO_TABELAPRECO")
      txtDataInicioUso.Text = .Item("DT_INICIO_USO")
      If Not FNC_CampoNulo(.Item("DT_FIM_USO")) Then txtDataFimUso.Text = .Item("DT_FIM_USO")
      txtDescontoMaximo.Value = FNC_NVL(.Item("PC_DESCONTO_MAXIMO"), 0)
      txtDescontoMaximo.Tag = FNC_NVL(.Item("PC_DESCONTO_MAXIMO"), 0)
      txtMargemLucro.Value = FNC_NVL(.Item("PC_MARGEM_LUCRO"), 0)
      txtMargemLucro.Tag = FNC_NVL(.Item("PC_MARGEM_LUCRO"), 0)
      txtComissao.Value = FNC_NVL(.Item("PC_COMISSAO"), 0)
      txtComissao.Tag = FNC_NVL(.Item("PC_COMISSAO"), 0)
      chkDisponivelFilial.Checked = (.Item("IC_DISPONIVEL_FILIAL") = "S")
      ComboBox_Selecionar(cboTabelaPrecoBase, .Item("ID_TABELAPRECO_BASE"))
      txtPercAcrescimoDecrescimo.Value = FNC_NVL(.Item("PC_TABELAPRECO_BASE_ACRESCIMODECRESCIMO"), 0)
    End With

    bProcessando = False

    If Not ComboBox_Selecionado(cboTabelaPrecoBase) Then
      sSqlText = "SELECT * FROM VW_TABELAPRECO_PRODUTO WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & " AND ID_TABELAPRECO = " & iSQ_TABELAPRECO
      oData = DBQuery(sSqlText)

      For iCont_01 = 0 To oData.Rows.Count - 1
        For iCont_02 = 0 To grdListagemProduto.Rows.Count - 1
          With grdListagemProduto.Rows(iCont_02)
            If oData.Rows(iCont_01).Item("ID_PRODUTO_EMPRESA") = .Cells(const_GridProduto_ID_PRODUTO_EMPRESA).Value Then
              .Cells(const_GridProduto_Comissao).Value = Val(oData.Rows(iCont_01).Item("PC_COMISSAO"))
              .Cells(const_GridProduto_MargemLucro).Value = Val(oData.Rows(iCont_01).Item("PC_MARGEM_LUCRO"))
              .Cells(const_GridProduto_DescontoMaximo).Value = Val(oData.Rows(iCont_01).Item("PC_DESCONTO_MAXIMO"))
              .Cells(const_GridProduto_Sel).Value = True
              GridProduto_Calcular(iCont_02)
              Exit For
            End If
          End With
        Next
      Next

      sSqlText = "SELECT * FROM VW_TABELAPRECO_PRODUTO_LINHA WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & " AND ID_TABELAPRECO = " & iSQ_TABELAPRECO
      oData = DBQuery(sSqlText)

      For iCont_01 = 0 To oData.Rows.Count - 1
        For iCont_02 = 0 To grdListagemProduto.Rows.Count - 1
          With grdListagemProduto.Rows(iCont_02)
            If oData.Rows(iCont_01).Item("ID_PRODUTO_LINHA") = .Cells(const_GridProduto_ID_PRODUTO_LINHA).Value Then
              .Cells(const_GridProduto_DescontoMaximo).Value = Val(oData.Rows(iCont_01).Item("PC_DESCONTO_MAXIMO"))
              .Cells(const_GridProduto_ValorVenda).Value = Val(oData.Rows(iCont_01).Item("VL_VENDA"))
              .Cells(const_GridProduto_Sel).Value = True
              Exit For
            End If
          End With
        Next
      Next
    End If

    TabelaPreco_Base_Formatar()
  End Sub

  Private Sub GridProduto_Calcular(iRow As Integer)
    Dim dCustoTotal As Double
    Dim dPrecoVenda As Double

    With grdListagemProduto.Rows(iRow)
      If objGrid_CheckCol_Valor(grdListagemProduto, const_GridProduto_Sel, iRow) = "S" And
         FNC_NVL(.Cells(const_GridProduto_ID_PRODUTO_EMPRESA).Value, 0) > 0 Then
        FNC_CalculaPrecoVenda(FNC_NVL(.Cells(const_GridProduto_PrecoCusto).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_ICMSEntrada).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_ICMSST).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_ICMSSaida).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_SimplesNacional).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_CustoFixo).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_CustoVariavel).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_OutrosImpostos).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_FreteEntrada).Value, 0),
                              0,
                              FNC_NVL(.Cells(const_GridProduto_Comissao).Value, 0),
                              FNC_NVL(.Cells(const_GridProduto_MargemLucro).Value, 0),
                              0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                              dCustoTotal,
                              dPrecoVenda,
                              False)
        .Cells(const_GridProduto_CustoTotal).Value = Math.Round(dCustoTotal, iEMPRESA_NR_CASASDECIMAIS_VALORES)
        .Cells(const_GridProduto_ValorVenda).Value = Math.Round(dPrecoVenda + FNC_NVL(.Cells(const_GridProduto_ValorBrindeAcessorio).Value, 0), iEMPRESA_NR_CASASDECIMAIS_VALORES)
      End If
    End With
  End Sub

  Private Sub txtMargemLucro_LostFocus(sender As Object, e As EventArgs) Handles txtMargemLucro.LostFocus
    txtMargemLucro.Tag = txtMargemLucro.Value
  End Sub

  Private Sub txtMargemLucro_ValueChanged(sender As Object, e As EventArgs) Handles txtMargemLucro.ValueChanged
    Dim iCont As Integer

    For iCont = 0 To grdListagemProduto.Rows.Count - 1
      If objGrid_CheckCol_Valor(grdListagemProduto, const_GridProduto_Sel, iCont) = "S" Then
        grdListagemProduto.Rows(iCont).Cells(const_GridProduto_MargemLucro).Value = txtMargemLucro.Value
      End If
      GridProduto_Calcular(iCont)
    Next
  End Sub

  Private Sub txtComissao_LostFocus(sender As Object, e As EventArgs) Handles txtComissao.LostFocus
    txtComissao.Tag = txtComissao.Value
  End Sub

  Private Sub txtComissao_ValueChanged(sender As Object, e As EventArgs) Handles txtComissao.ValueChanged
    Dim iCont As Integer

    For iCont = 0 To grdListagemProduto.Rows.Count - 1
      If objGrid_CheckCol_Valor(grdListagemProduto, const_GridProduto_Sel, iCont) = "S" Then
        grdListagemProduto.Rows(iCont).Cells(const_GridProduto_Comissao).Value = txtComissao.Value
      End If
      GridProduto_Calcular(iCont)
    Next
  End Sub

  Private Sub txtDescontoMaximo_LostFocus(sender As Object, e As EventArgs) Handles txtDescontoMaximo.LostFocus
    txtDescontoMaximo.Tag = txtDescontoMaximo.Value
  End Sub

  Private Sub txtDescontoMaximo_ValueChanged(sender As Object, e As EventArgs) Handles txtDescontoMaximo.ValueChanged
    Dim iCont As Integer

    For iCont = 0 To grdListagemProduto.Rows.Count - 1
      If objGrid_CheckCol_Valor(grdListagemProduto, const_GridProduto_Sel, iCont) = "S" Then
        grdListagemProduto.Rows(iCont).Cells(const_GridProduto_DescontoMaximo).Value = txtDescontoMaximo.Value
      End If
      GridProduto_Calcular(iCont)
    Next
  End Sub

  Private Sub grdProduto_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles grdListagemProduto.AfterCellUpdate
    If bProcessando Then Exit Sub
    bProcessando = True
    If objGrid_CheckCol_Valor(grdListagemProduto, const_GridProduto_Sel, e.Cell.Row.Index) = "S" Then
      If e.Cell.Column.Index = const_GridProduto_Sel Then
        grdListagemProduto.Rows(e.Cell.Row.Index).Cells(const_GridProduto_MargemLucro).Value = txtMargemLucro.Value
        grdListagemProduto.Rows(e.Cell.Row.Index).Cells(const_GridProduto_Comissao).Value = txtComissao.Value
        grdListagemProduto.Rows(e.Cell.Row.Index).Cells(const_GridProduto_DescontoMaximo).Value = txtDescontoMaximo.Value
      End If
      GridProduto_Calcular(e.Cell.Row.Index)
    Else
      If e.Cell.Column.Index = const_GridProduto_Sel Then
        grdListagemProduto.Rows(e.Cell.Row.Index).Cells(const_GridProduto_CustoTotal).Value = 0
        grdListagemProduto.Rows(e.Cell.Row.Index).Cells(const_GridProduto_ValorVenda).Value = 0
      End If
    End If
    bProcessando = False
  End Sub

  Private Sub frmCadastroTabelaPreco_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdGravar.Left = cmdFechar.Left - cmdGravar.Width - 5
    cmdGravar.Top = cmdFechar.Top
    grdListagemProduto.Width = Me.ClientSize.Width - 10
    grdListagemProduto.Height = cmdFechar.Top - grdListagemProduto.Top - 5
  End Sub

  Private Sub TabelaPreco_Base_Formatar()
    lblRAcrescimoDecrescimo.Enabled = (cboTabelaPrecoBase.SelectedIndex > -1)
    txtPercAcrescimoDecrescimo.Enabled = (cboTabelaPrecoBase.SelectedIndex > -1)
    If Not txtPercAcrescimoDecrescimo.Enabled Then txtPercAcrescimoDecrescimo.Value = 0

    lblRListagemProduto.Enabled = (cboTabelaPrecoBase.SelectedIndex = -1)
    grdListagemProduto.Enabled = (cboTabelaPrecoBase.SelectedIndex = -1)

    If cboTabelaPrecoBase.SelectedIndex > -1 Then objGrid_Limpar_Coluna(grdListagemProduto, const_GridProduto_Sel)
  End Sub

  Private Sub cboTabelaPrecoBase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTabelaPrecoBase.SelectedIndexChanged
    TabelaPreco_Base_Formatar()
  End Sub

  Private Sub grdListagemProduto_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdListagemProduto.BeforeCellActivate
    If FNC_In(e.Cell.Column.Index, const_GridProduto_ICMSEntrada, const_GridProduto_ICMSST, const_GridProduto_ICMSSaida,
                                   const_GridProduto_SimplesNacional, const_GridProduto_CustoFixo, const_GridProduto_CustoVariavel,
                                   const_GridProduto_OutrosImpostos, const_GridProduto_FreteEntrada) Then
      e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridProduto_ID_PRODUTO_EMPRESA).Value, 0) = 0)
    ElseIf FNC_In(e.Cell.Column.Index, const_GridProduto_ValorVenda) Then
      e.Cancel = (FNC_NVL(e.Cell.Row.Cells(const_GridProduto_ID_PRODUTO_LINHA).Value, 0) = 0)
    End If
  End Sub

  Private Sub frmCadastroTabelaPreco_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagemProduto, Me.Name)
  End Sub
End Class