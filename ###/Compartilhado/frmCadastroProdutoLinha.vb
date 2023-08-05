Public Class frmCadastroProdutoLinha
  Public Event Pesquisar()

  Public iSQ_PRODUTO_LINHA As Integer

  Private Sub frmCadastroProdutoLinha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboTipoProdutoLinha, enSql.TipoLinhaProduto)
    ComboBox_Carregar(cboUnidadeMedida, enSql.UnidadeMedida)

    If iSQ_PRODUTO_LINHA = 0 Then
      lblRProdutoIndicacao.Enabled = False
      cboProdutoIndicacao.Enabled = False
    Else
      ComboBox_Carregar(cboProdutoIndicacao, enSql.Produto_LinhaProduto, New Object() {iSQ_PRODUTO_LINHA})
    End If

    ListBox_Carregar(cklCaracteriscaProduto, enSql.CaracteristicaProduto)

    If iSQ_PRODUTO_LINHA > 0 Then
      CarregarDados()
    Else
      chkAtivo.Checked = True
    End If
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer

    sSqlText = "SELECT * FROM TB_PRODUTO_LINHA" &
               " WHERE SQ_PRODUTO_LINHA = " & iSQ_PRODUTO_LINHA
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        txtNomeProdutoLinha.Text = FNC_NVL(.Item("NO_PRODUTO_LINHA"), "")
        ComboBox_Selecionar(cboTipoProdutoLinha, FNC_NVL(.Item("ID_OPT_TIPO_PRODUTO_LINHA"), 0))
        ComboBox_Selecionar(cboUnidadeMedida, FNC_NVL(.Item("ID_UNIDADEMEDIDA"), 0))
        ComboBox_Selecionar(cboProdutoIndicacao, FNC_NVL(.Item("ID_PRODUTO_EMPRESA_INDICACAO"), 0))
        chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "N") = "S")
      End With
    End If

    sSqlText = "SELECT * FROM TB_PRODUTO_LINHA_CARACTERISTICA WHERE ID_PRODUTO_LINHA = " & iSQ_PRODUTO_LINHA
    oData = DBQuery(sSqlText)

    For iCont_01 = 0 To oData.Rows.Count - 1
      For iCont_02 = 0 To cklCaracteriscaProduto.Items.Count - 1
        If cklCaracteriscaProduto.Items(iCont_02)(0) = oData.Rows(iCont_01).Item("ID_CARACTERISTICA_PRODUTO") Then
          cklCaracteriscaProduto.SetItemCheckState(iCont_02, CheckState.Checked)
        End If
      Next
    Next
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String
    Dim iCont As Integer

    If Trim(txtNomeProdutoLinha.Text) = "" Then
      FNC_Mensagem("Informe o nome da linha de produto")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoProdutoLinha) Then
      FNC_Mensagem("Selecione o tipo de linha de produto")
      Exit Sub
    End If

    sSqlText = DBMontar_SP("SP_PRODUTO_LINHA_CAD", False, "@SQ_PRODUTO_LINHA",
                                                          "@ID_EMPRESA",
                                                          "@ID_OPT_TIPO_PRODUTO_LINHA",
                                                          "@ID_PRODUTO_EMPRESA_INDICACAO",
                                                          "@ID_UNIDADEMEDIDA",
                                                          "@NO_PRODUTO_LINHA",
                                                          "@IC_ATIVO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_PRODUTO_LINHA", iSQ_PRODUTO_LINHA),
                         DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                         DBParametro_Montar("ID_OPT_TIPO_PRODUTO_LINHA", enOpcoes.TipoLinhaProduto_LinhaVenda.GetHashCode()),
                         DBParametro_Montar("ID_PRODUTO_EMPRESA_INDICACAO", cboProdutoIndicacao.SelectedValue),
                         DBParametro_Montar("ID_UNIDADEMEDIDA", cboUnidadeMedida.SelectedValue),
                         DBParametro_Montar("NO_PRODUTO_LINHA", Trim(txtNomeProdutoLinha.Text)),
                         DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N")))

    For iCont = 0 To cklCaracteriscaProduto.Items.Count - 1
      If cklCaracteriscaProduto.GetSelected(iCont) Then
        sSqlText = DBMontar_SP("SP_PRODUTO_LINHA_CARACTERISTICA_CAD", False, "@ID_PRODUTO_LINHA",
                                                                             "@ID_CARACTERISTICA_PRODUTO")
        DBExecutar(sSqlText, DBParametro_Montar("ID_PRODUTO_LINHA", iSQ_PRODUTO_LINHA),
                             DBParametro_Montar("ID_CARACTERISTICA_PRODUTO", cklCaracteriscaProduto.Items(iCont)(0)))
      Else
        sSqlText = DBMontar_SP("SP_PRODUTO_LINHA_CARACTERISTICA_DEL", False, "@ID_PRODUTO_LINHA",
                                                                             "@ID_CARACTERISTICA_PRODUTO")
        DBExecutar(sSqlText, DBParametro_Montar("ID_PRODUTO_LINHA", iSQ_PRODUTO_LINHA),
                             DBParametro_Montar("ID_CARACTERISTICA_PRODUTO", cklCaracteriscaProduto.Items(iCont)(0)))
      End If
    Next

    RaiseEvent Pesquisar()

    FNC_Mensagem("Gravação Efetuada")
  End Sub
End Class