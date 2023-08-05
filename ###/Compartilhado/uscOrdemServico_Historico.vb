Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class uscOrdemServico_Historico
  Public Event Novo()
  Public Event Editar()
  Public Event Remover()
  Public Event Atualizando()
  Public Event AtualizacaoEfetuada()
  Public Event CalcularTotais()
  Public Event HistoricoAlterado()

  Class clsItem
    Public ItemSelecionado As Boolean = False
    Public SQ_ORDEMSERVICO_HISTORICO As Integer = 0
    Public SQ_ORDEMSERVICO_PRODUTOSERVICO As Integer = 0
    Public ID_OPT_TIPO_HISTORICO As Integer
    Public ID_ORDEMSERVICO_PRODUTO As Integer
    Public ID_PESSOA_RESPONSAVEL As Integer
    Public ID_PESSOA_TERCEIRO As Integer
    Public ID_TABELAPRECO As Integer
    Public ID_PRODUTO_EMPRESA_SERVICO As Integer
    Public DataHistorico As Date
    Public TipoHistorico As String
    Public DescricaoHistorico As String
    Public TecnicoResponsavelLocal As String
    Public PrestadorServicoAutorizada As String
    Public CodigoOSFornecedor As String
    Public DataFinal As String
    Public CodigoProdutoServico As String
    Public ProdutoServico As String
    Public QtdeProdutoServico As Double
    Public VlrProdutoServico As Double
  End Class

  Const const_GridListagem_SQ_ORDEMSERVICO_HISTORICO As Integer = 0
  Const const_GridListagem_SQ_ORDEMSERVICO_PRODUTOSERVICO As Integer = 1
  Const const_GridListagem_ID_OPT_TIPO_HISTORICO As Integer = 2
  Const const_GridListagem_ID_ORDEMSERVICO_PRODUTO As Integer = 3
  Const const_GridListagem_ID_USUARIO_INCLUSAO As Integer = 4
  Const const_GridListagem_ID_PESSOA_RESPONSAVEL As Integer = 5
  Const const_GridListagem_ID_PESSOA_TERCEIRO As Integer = 6
  Const const_GridListagem_ID_TABELAPRECO As Integer = 7
  Const const_GridListagem_ID_PRODUTO_EMPRESA_SERVICO As Integer = 8
  Const const_GridListagem_DataHistorico As Integer = 9
  Const const_GridListagem_TipoHistorico As Integer = 10
  Const const_GridListagem_DescricaoHistorico As Integer = 11
  Const const_GridListagem_TecnicoResponsavelLocal As Integer = 12
  Const const_GridListagem_PrestadorServicoAutorizada As Integer = 13
  Const const_GridListagem_CodigoOSFornecedor As Integer = 14
  Const const_GridListagem_DataFinal As Integer = 15
  Const const_GridListagem_CodigoProdutoServico As Integer = 16
  Const const_GridListagem_ProdutoServico As Integer = 17
  Const const_GridListagem_QtdeProdutoServico As Integer = 18
  Const const_GridListagem_VlrProdutoServico As Integer = 19
  Const const_GridListagem_Acao As Integer = 20

  Public Item As New clsItem

  Dim oDBGridListagem As New UltraWinDataSource.UltraDataSource

  Dim iGridListagem_LinhaEdicao As Integer = -1

  Dim bEdicaoHabilitada As Boolean
  Dim iID_ORDEMSERVICO As Integer

  Public Sub GridFormatar()
    objGrid_Inicializar(grdListagem, , oDBGridListagem, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_ORDEMSERVICO_HISTORICO", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_ORDEMSERVICO_PRODUTOSERVICO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_TIPO_HISTORICO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_ORDEMSERVICO_PRODUTO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_USUARIO_INCLUSAO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_RESPONSAVEL", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_TERCEIRO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_TABELAPRECO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PRODUTO_EMPRESA_SERVICO", 0)
    objGrid_Coluna_Add(grdListagem, "Data do Histórico", 110, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Tipo de Histórico", 200)
    objGrid_Coluna_Add(grdListagem, "Descrição do Histórico", 300)
    objGrid_Coluna_Add(grdListagem, "Técnico/Responsável Local", 200)
    objGrid_Coluna_Add(grdListagem, "Prestador de Serviço/Autorizada", 200)
    objGrid_Coluna_Add(grdListagem, "Código da OS do Fornecedor", 135)
    objGrid_Coluna_Add(grdListagem, "Data Final", 110, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Cód. Produto/Serviço", 130)
    objGrid_Coluna_Add(grdListagem, "Produto/Serviço", 300)
    objGrid_Coluna_Add(grdListagem, "Qtde. Produto/Serviço", 135, , , , , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdListagem, "Vlr. Produto/Serviço", 135, , , , , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdListagem, "Ação", 0)
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Public Sub Finalizar()
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub uscOrdemServico_Historico_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    AjustarTela()
  End Sub

  Public Property EdicaoHabilitada As Boolean
    Get
      Return bEdicaoHabilitada
    End Get
    Set(value As Boolean)
      bEdicaoHabilitada = value
      cmdEditar.Visible = value
      cmdRemover.Visible = value

      AjustarTela()
    End Set
  End Property

  Public Property ID_ORDEMSERVICO As Integer
    Get
      Return iID_ORDEMSERVICO
    End Get
    Set(value As Integer)
      iID_ORDEMSERVICO = value
    End Set
  End Property

  Private Sub AjustarTela()
    cmdGravar.Left = Me.Width - cmdGravar.Width
    cmdNovo.Left = Me.Width - cmdNovo.Width
    cmdEditar.Left = Me.Width - cmdEditar.Width
    cmdRemover.Left = Me.Width - cmdRemover.Width

    If bEdicaoHabilitada Then
      grdListagem.Width = Me.Width - cmdEditar.Width - 3
    Else
      grdListagem.Width = Me.Width
    End If

    grdListagem.Height = Me.Height - grdListagem.Top
  End Sub

  Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o histórico a ser editado")
      Exit Sub
    End If

    CarregarItem()

    iGridListagem_LinhaEdicao = objGrid_LinhaSelecionada(grdListagem)

    RaiseEvent Editar()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    RaiseEvent Atualizando()

    If Item.ID_OPT_TIPO_HISTORICO = 0 Then
      FNC_Mensagem("Informe o tipo de histórico")
      Exit Sub
    End If
    If Trim(Item.TipoHistorico) = "" Then
      FNC_Mensagem("Informe o tipo de histórico")
      Exit Sub
    End If

    Select Case Item.ID_OPT_TIPO_HISTORICO
      Case enOpcoes.TipoHistoricoOrdemServico_InclusaoPecaProduto.GetHashCode,
           enOpcoes.TipoHistoricoOrdemServico_InclusaoPecaProdutoGerarOrcamento.GetHashCode
        If Item.ID_PRODUTO_EMPRESA_SERVICO = 0 Then
          FNC_Mensagem("Informe o produto/peça a ser incluído")
          Exit Sub
        End If
        If Item.QtdeProdutoServico = 0 Then
          FNC_Mensagem("Informe a quantidade do produto/peça")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_InclusaoServico.GetHashCode,
           enOpcoes.TipoHistoricoOrdemServico_InclusaoServicoGerarOrcamento.GetHashCode
        If Item.ID_PRODUTO_EMPRESA_SERVICO = 0 Then
          FNC_Mensagem("Informe o serviço a ser incluído")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_StatusManutencaoLocal.GetHashCode,
           enOpcoes.TipoHistoricoOrdemServico_StatusManutencaoTerceiros.GetHashCode
        If Trim(Item.DescricaoHistorico) = "" Then
          FNC_Mensagem("Comente na descrição do histórico o status da manutenção")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_PendenteProdutoPecaLocal.GetHashCode,
           enOpcoes.TipoHistoricoOrdemServico_PendenteProdutoPecaTerceiros.GetHashCode
        If Trim(Item.DescricaoHistorico) Then
          FNC_Mensagem("Informe na descrição do histórico o que está pendente")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_EnvioManutencaoTerceiros.GetHashCode
        If Item.ID_ORDEMSERVICO_PRODUTO = 0 Then
          FNC_Mensagem("Selecione o Produto em Manutenção que foi enviado para terceiros")
          Exit Sub
        End If
        If Item.ID_PESSOA_TERCEIRO = 0 Then
          FNC_Mensagem("Selecione o ''Prestador de Serviço/Autorizada/Fabricante'' para qual o produto foi enviado")
          Exit Sub
        End If
        If Not IsDate(Item.DataFinal) Then
          FNC_Mensagem("Informe a data da previsão de retorno do produto")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_RetornoManutencaoTerceiros.GetHashCode
        If Not IsDate(Item.DataFinal) Then
          FNC_Mensagem("Informe a data da chegada do produto")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_ServicoConcluido.GetHashCode
        If Not IsDate(Item.DataFinal) Then
          FNC_Mensagem("Informe a data de conclusão do serviço")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_ProdutoSemCondicaoReparo.GetHashCode
        If Item.ID_ORDEMSERVICO_PRODUTO = 0 Then
          FNC_Mensagem("Selecione o Produto em Manutenção que não tem condição de reparo")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_ProdutoRetiradoCliente.GetHashCode
        If Item.ID_ORDEMSERVICO_PRODUTO = 0 Then
          FNC_Mensagem("Selecione o Produto em Manutenção que foi retirado pelo cliente")
          Exit Sub
        End If
        If Not IsDate(Item.DataFinal) Then
          FNC_Mensagem("Informe a data da retirada do produto")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_ProdutoTransitoTerceiros.GetHashCode
        If Item.ID_ORDEMSERVICO_PRODUTO = 0 Then
          FNC_Mensagem("Selecione o Produto em Manutenção que está em trânsito do cliente")
          Exit Sub
        End If
        If Not IsDate(Item.DataFinal) Then
          FNC_Mensagem("Informe a data de previsão de chegada do produto")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_DefinicaoTecnicoResponsavelLocal.GetHashCode
        If Item.ID_PESSOA_RESPONSAVEL = 0 Then
          FNC_Mensagem("Selecione a pessoa/técnico responsável pelo produto localmente")
          Exit Sub
        End If
      Case enOpcoes.TipoHistoricoOrdemServico_ServicoCanceladoPeloCliente.GetHashCode
      Case enOpcoes.TipoHistoricoOrdemServico_ServicoCanceladoPelaEmpresa.GetHashCode
    End Select

    If iGridListagem_LinhaEdicao = -1 Then
      iGridListagem_LinhaEdicao = oDBGridListagem.Rows.Add().Index
    End If

    With grdListagem.Rows(iGridListagem_LinhaEdicao)
      .Cells(const_GridListagem_SQ_ORDEMSERVICO_HISTORICO).Value = Item.SQ_ORDEMSERVICO_HISTORICO
      .Cells(const_GridListagem_ID_OPT_TIPO_HISTORICO).Value = Item.ID_OPT_TIPO_HISTORICO
      .Cells(const_GridListagem_ID_ORDEMSERVICO_PRODUTO).Value = Item.ID_ORDEMSERVICO_PRODUTO
      .Cells(const_GridListagem_ID_PESSOA_RESPONSAVEL).Value = Item.ID_PESSOA_RESPONSAVEL
      .Cells(const_GridListagem_ID_PESSOA_TERCEIRO).Value = Item.ID_PESSOA_TERCEIRO
      .Cells(const_GridListagem_ID_PRODUTO_EMPRESA_SERVICO).Value = Item.ID_PRODUTO_EMPRESA_SERVICO
      .Cells(const_GridListagem_DataHistorico).Value = Item.DataHistorico
      .Cells(const_GridListagem_TipoHistorico).Value = Item.TipoHistorico
      .Cells(const_GridListagem_DescricaoHistorico).Value = Item.DescricaoHistorico
      .Cells(const_GridListagem_TecnicoResponsavelLocal).Value = Item.TecnicoResponsavelLocal
      .Cells(const_GridListagem_PrestadorServicoAutorizada).Value = Item.PrestadorServicoAutorizada
      .Cells(const_GridListagem_CodigoOSFornecedor).Value = Item.CodigoOSFornecedor
      If IsDate(Item.DataFinal) Then .Cells(const_GridListagem_DataFinal).Value = Item.DataFinal
      .Cells(const_GridListagem_CodigoProdutoServico).Value = Item.CodigoProdutoServico
      .Cells(const_GridListagem_ProdutoServico).Value = Item.ProdutoServico
      .Cells(const_GridListagem_QtdeProdutoServico).Value = Item.QtdeProdutoServico
      .Cells(const_GridListagem_VlrProdutoServico).Value = Item.VlrProdutoServico
      .Cells(const_GridListagem_Acao).Value = const_GridAcao_Gravar
    End With

    RaiseEvent CalcularTotais()
    RaiseEvent HistoricoAlterado()
    RaiseEvent AtualizacaoEfetuada()
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    Item = New clsItem
    iGridListagem_LinhaEdicao = -1

    RaiseEvent Novo()
  End Sub

  Private Sub CarregarItem()
    Item = New clsItem

    If objGrid_LinhaSelecionada(grdListagem) > -1 Then
      With Item
        .ItemSelecionado = True
        .SQ_ORDEMSERVICO_HISTORICO = objGrid_Valor(grdListagem, const_GridListagem_SQ_ORDEMSERVICO_HISTORICO)
        .ID_OPT_TIPO_HISTORICO = objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_TIPO_HISTORICO)
        .ID_ORDEMSERVICO_PRODUTO = objGrid_Valor(grdListagem, const_GridListagem_ID_ORDEMSERVICO_PRODUTO, , 0)
        .ID_PESSOA_RESPONSAVEL = objGrid_Valor(grdListagem, const_GridListagem_ID_PESSOA_RESPONSAVEL, , 0)
        .ID_PESSOA_TERCEIRO = objGrid_Valor(grdListagem, const_GridListagem_ID_PESSOA_TERCEIRO, , 0)
        .ID_TABELAPRECO = objGrid_Valor(grdListagem, const_GridListagem_ID_TABELAPRECO, , 0)
        .ID_PRODUTO_EMPRESA_SERVICO = objGrid_Valor(grdListagem, const_GridListagem_ID_PRODUTO_EMPRESA_SERVICO, , 0)
        .DataHistorico = objGrid_Valor(grdListagem, const_GridListagem_DataHistorico)
        .TipoHistorico = objGrid_Valor(grdListagem, const_GridListagem_TipoHistorico)
        .DescricaoHistorico = objGrid_Valor(grdListagem, const_GridListagem_DescricaoHistorico, , "")
        .TecnicoResponsavelLocal = objGrid_Valor(grdListagem, const_GridListagem_TecnicoResponsavelLocal, , "")
        .PrestadorServicoAutorizada = objGrid_Valor(grdListagem, const_GridListagem_PrestadorServicoAutorizada, , "")
        .CodigoOSFornecedor = objGrid_Valor(grdListagem, const_GridListagem_CodigoOSFornecedor, , "")
        If IsDate(objGrid_Valor(grdListagem, const_GridListagem_DataFinal)) Then .DataFinal = objGrid_Valor(grdListagem, const_GridListagem_DataFinal)
        .CodigoProdutoServico = objGrid_Valor(grdListagem, const_GridListagem_CodigoProdutoServico, , "")
        .ProdutoServico = objGrid_Valor(grdListagem, const_GridListagem_ProdutoServico, , "")
        .QtdeProdutoServico = objGrid_Valor(grdListagem, const_GridListagem_QtdeProdutoServico, , 0)
        .VlrProdutoServico = objGrid_Valor(grdListagem, const_GridListagem_VlrProdutoServico, , 0)
      End With
    End If
  End Sub

  Private Sub cmdRemover_Click(sender As Object, e As EventArgs) Handles cmdRemover.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione histórico para remoção ou restauração")
      Exit Sub
    End If

    iGridListagem_LinhaEdicao = -1

    If grdListagem.Rows(objGrid_LinhaSelecionada(grdListagem)).Cells(const_GridListagem_Acao).Value = const_GridAcao_Excluir Then
      grdListagem.Rows(objGrid_LinhaSelecionada(grdListagem)).Appearance.BackColor = Color.White
      grdListagem.Rows(objGrid_LinhaSelecionada(grdListagem)).Cells(const_GridListagem_Acao).Value = const_GridAcao_Gravar
    Else
      grdListagem.Rows(objGrid_LinhaSelecionada(grdListagem)).Appearance.BackColor = Color.Gray
      grdListagem.Rows(objGrid_LinhaSelecionada(grdListagem)).Cells(const_GridListagem_Acao).Value = const_GridAcao_Excluir
    End If

    RaiseEvent Remover()
    RaiseEvent CalcularTotais()
    RaiseEvent HistoricoAlterado()
  End Sub

  Public Function EfetuarGravacao() As Boolean
    Dim bOk As Boolean = False
    Dim iCont As Integer
    Dim sSqlText As String

    If iID_ORDEMSERVICO = 0 Then
      FNC_Mensagem("Não foi informado a OS ref. a esse histórico")
      GoTo Sair
    End If

    For iCont = 0 To grdListagem.Rows.Count - 1
      With grdListagem.Rows(iCont)
        Select Case FNC_NVL(.Cells(const_GridListagem_Acao).Value, const_GridAcao_Neutro)
          Case const_GridAcao_Gravar
            sSqlText = DBMontar_SP("SP_ORDEMSERVICO_HISTORICO_CAD", False, "@SQ_ORDEMSERVICO_HISTORICO OUT", _
                                                                           "@ID_OPT_TIPO_HISTORICO", _
                                                                           "@ID_ORDEMSERVICO", _
                                                                           "@ID_USUARIO_INCLUSAO", _
                                                                           "@ID_ORDEMSERVICO_PRODUTO", _
                                                                           "@ID_PESSOA_RESPONSAVEL", _
                                                                           "@ID_PESSOA_TERCEIRO", _
                                                                           "@CD_ORDEMSERVICO_FORNECEDOR", _
                                                                           "@DH_HISTORICO", _
                                                                           "@DS_HISTORICO", _
                                                                           "@DH_FINALIZACAO")
            DBExecutar(sSqlText, DBParametro_Montar("SQ_ORDEMSERVICO_HISTORICO", .Cells(const_GridListagem_SQ_ORDEMSERVICO_HISTORICO).Value, , ParameterDirection.InputOutput), _
                                 DBParametro_Montar("ID_OPT_TIPO_HISTORICO", .Cells(const_GridListagem_ID_OPT_TIPO_HISTORICO).Value), _
                                 DBParametro_Montar("ID_ORDEMSERVICO", iID_ORDEMSERVICO), _
                                 DBParametro_Montar("ID_USUARIO_INCLUSAO", iID_USUARIO), _
                                 DBParametro_Montar("ID_ORDEMSERVICO_PRODUTO", FNC_NuloZero(.Cells(const_GridListagem_ID_ORDEMSERVICO_PRODUTO).Value, False)), _
                                 DBParametro_Montar("ID_PESSOA_RESPONSAVEL", FNC_NuloZero(.Cells(const_GridListagem_ID_PESSOA_RESPONSAVEL).Value, False)), _
                                 DBParametro_Montar("ID_PESSOA_TERCEIRO", FNC_NuloZero(.Cells(const_GridListagem_ID_PESSOA_TERCEIRO).Value, False)), _
                                 DBParametro_Montar("CD_ORDEMSERVICO_FORNECEDOR", FNC_NuloString(.Cells(const_GridListagem_CodigoOSFornecedor).Value, False)), _
                                 DBParametro_Montar("DH_HISTORICO", .Cells(const_GridListagem_DataHistorico).Value, SqlDbType.DateTime), _
                                 DBParametro_Montar("DS_HISTORICO", FNC_NuloString(Trim(.Cells(const_GridListagem_DescricaoHistorico).Value), False)), _
                                 DBParametro_Montar("DH_FINALIZACAO", .Cells(const_GridListagem_DataFinal).Value, SqlDbType.DateTime))

            .Cells(const_GridListagem_SQ_ORDEMSERVICO_HISTORICO).Value = DBRetorno(1)
            .Cells(const_GridListagem_Acao).Value = const_GridAcao_Removido

            If FNC_In(.Cells(const_GridListagem_ID_OPT_TIPO_HISTORICO).Value, enOpcoes.TipoHistoricoOrdemServico_InclusaoPecaProduto.GetHashCode, _
                                                                              enOpcoes.TipoHistoricoOrdemServico_InclusaoPecaProdutoGerarOrcamento.GetHashCode, _
                                                                              enOpcoes.TipoHistoricoOrdemServico_InclusaoServico.GetHashCode, _
                                                                              enOpcoes.TipoHistoricoOrdemServico_InclusaoServicoGerarOrcamento.GetHashCode) Then
              Dim oPRODUTO_EMPRESA As DBParamentro
              Dim oSERVICO As DBParamentro

              sSqlText = DBMontar_SP("SP_ORDEMSERVICO_PRODUTOSERVICO_CAD", False, "@SQ_ORDEMSERVICO_PRODUTOSERVICO OUTPUT", _
                                                                                  "@ID_ORDEMSERVICO_HISTORICO", _
                                                                                  "@ID_TABELAPRECO", _
                                                                                  "@ID_PRODUTO_EMPRESA", _
                                                                                  "@ID_SERVICO", _
                                                                                  "@QT_PRODUTOSERVICO", _
                                                                                  "@VL_PRODUTOSERVICO")

              oPRODUTO_EMPRESA = DBParametro_Montar("ID_PRODUTO_EMPRESA", Nothing)
              oSERVICO = DBParametro_Montar("ID_SERVICO", Nothing)

              Select Case .Cells(const_GridListagem_ID_OPT_TIPO_HISTORICO).Value
                Case enOpcoes.TipoHistoricoOrdemServico_InclusaoPecaProduto.GetHashCode, enOpcoes.TipoHistoricoOrdemServico_InclusaoPecaProdutoGerarOrcamento.GetHashCode
                  oPRODUTO_EMPRESA = DBParametro_Montar("ID_PRODUTO_EMPRESA", .Cells(const_GridListagem_ID_PRODUTO_EMPRESA_SERVICO).Value)
                Case enOpcoes.TipoHistoricoOrdemServico_InclusaoServico.GetHashCode, enOpcoes.TipoHistoricoOrdemServico_InclusaoServicoGerarOrcamento.GetHashCode
                  oSERVICO = DBParametro_Montar("ID_SERVICO", .Cells(const_GridListagem_ID_PRODUTO_EMPRESA_SERVICO).Value)
              End Select

              DBExecutar(sSqlText, DBParametro_Montar("SQ_ORDEMSERVICO_PRODUTOSERVICO", .Cells(const_GridListagem_SQ_ORDEMSERVICO_PRODUTOSERVICO).Value, , ParameterDirection.InputOutput), _
                                   DBParametro_Montar("ID_ORDEMSERVICO_HISTORICO", .Cells(const_GridListagem_SQ_ORDEMSERVICO_HISTORICO).Value), _
                                   DBParametro_Montar("ID_TABELAPRECO", .Cells(const_GridListagem_ID_TABELAPRECO).Value), _
                                   oPRODUTO_EMPRESA, _
                                   oSERVICO, _
                                   DBParametro_Montar("QT_PRODUTOSERVICO", FNC_NVL(.Cells(const_GridListagem_QtdeProdutoServico).Value, 0)), _
                                   DBParametro_Montar("VL_PRODUTOSERVICO", FNC_NVL(.Cells(const_GridListagem_VlrProdutoServico).Value, 0)))

              .Cells(const_GridListagem_SQ_ORDEMSERVICO_PRODUTOSERVICO).Value = DBRetorno(1)
            End If
          Case const_GridAcao_Excluir
            If FNC_NVL(.Cells(const_GridListagem_SQ_ORDEMSERVICO_HISTORICO).Value, 0) > 0 Then
              sSqlText = DBMontar_SP("SP_ORDEMSERVICO_HISTORICO_DEL", False, "@SQ_ORDEMSERVICO_HISTORICO")

              DBExecutar(sSqlText, DBParametro_Montar("SQ_ORDEMSERVICO_HISTORICO", .Cells(const_GridListagem_SQ_ORDEMSERVICO_HISTORICO).Value))
            End If

            .Cells(const_GridListagem_SQ_ORDEMSERVICO_HISTORICO).Value = const_GridAcao_Removido
            .Hidden = True
        End Select
      End With
    Next

    bOk = True

Sair:
    Return bOk
  End Function

  Public Sub Carregar()
    Dim sSqlText As String

    sSqlText = "SELECT SQ_ORDEMSERVICO_HISTORICO," & _
                      "SQ_ORDEMSERVICO_PRODUTOSERVICO," & _
                      "ID_OPT_TIPO_HISTORICO," & _
                      "ID_ORDEMSERVICO_PRODUTO," & _
                      "ID_USUARIO_INCLUSAO," & _
                      "ID_PESSOA_RESPONSAVEL," & _
                      "ID_PESSOA_TERCEIRO," & _
                      "ID_TABELAPRECO," & _
                      "ISNULL(ID_PRODUTO_EMPRESA, ID_SERVICO) ID_PRODUTO_EMPRESA_SERVICO," & _
                      "DH_HISTORICO," & _
                      "NO_OPT_TIPO_HISTORICO," & _
                      "DS_HISTORICO," & _
                      "NO_PESSOA_RESPONSAVEL," & _
                      "NO_PESSOA_TERCEIRO," & _
                      "CD_ORDEMSERVICO_FORNECEDOR," & _
                      "DH_FINALIZACAO," & _
                      "CD_PRODUTO_SERVICO," & _
                      "NO_PRODUTO_SERVICO," & _
                      "QT_PRODUTOSERVICO," & _
                      "VL_PRODUTOSERVICO," & _
                      FNC_QuotedStr(const_GridAcao_Neutro) & _
               " FROM VW_ORDEMSERVICO_HISTORICO" & _
               " WHERE ID_ORDEMSERVICO = " & iID_ORDEMSERVICO & _
               " ORDER BY DH_HISTORICO, NO_PRODUTO_SERVICO"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_ORDEMSERVICO_HISTORICO, _
                                                           const_GridListagem_SQ_ORDEMSERVICO_PRODUTOSERVICO, _
                                                           const_GridListagem_ID_OPT_TIPO_HISTORICO, _
                                                           const_GridListagem_ID_ORDEMSERVICO_PRODUTO, _
                                                           const_GridListagem_ID_USUARIO_INCLUSAO, _
                                                           const_GridListagem_ID_PESSOA_RESPONSAVEL, _
                                                           const_GridListagem_ID_PESSOA_TERCEIRO, _
                                                           const_GridListagem_ID_TABELAPRECO, _
                                                           const_GridListagem_ID_PRODUTO_EMPRESA_SERVICO, _
                                                           const_GridListagem_DataHistorico, _
                                                           const_GridListagem_TipoHistorico, _
                                                           const_GridListagem_DescricaoHistorico, _
                                                           const_GridListagem_TecnicoResponsavelLocal, _
                                                           const_GridListagem_PrestadorServicoAutorizada, _
                                                           const_GridListagem_CodigoOSFornecedor, _
                                                           const_GridListagem_DataFinal, _
                                                           const_GridListagem_CodigoProdutoServico, _
                                                           const_GridListagem_ProdutoServico, _
                                                           const_GridListagem_QtdeProdutoServico, _
                                                           const_GridListagem_VlrProdutoServico, _
                                                           const_GridListagem_Acao})

    RaiseEvent CalcularTotais()
  End Sub

  Public ReadOnly Property VlrProdutoServico As Double
    Get
      Dim iCont As Integer
      Dim dRet As Double = 0

      For iCont = 0 To grdListagem.Rows.Count - 1
        With grdListagem.Rows(iCont)
          If FNC_In(FNC_NVL(.Cells(const_GridListagem_Acao).Value, 0), const_GridAcao_Gravar, const_GridAcao_Neutro) Then
            dRet = dRet + (FNC_NVL(.Cells(const_GridListagem_QtdeProdutoServico).Value, 0) * FNC_NVL(.Cells(const_GridListagem_VlrProdutoServico).Value, 0))
          End If
        End With
      Next

      Return dRet
    End Get
  End Property

  Public Function OrdemServico_Produto_Existe(iID_ORDEMSERVICO_PRODUTO As Integer) As Boolean
    Dim iCont As Integer
    Dim bAchou As Boolean = False

    For iCont = 0 To grdListagem.Rows.Count - 1
      With grdListagem.Rows(iCont)
        If FNC_In(FNC_NVL(.Cells(const_GridListagem_Acao).Value, 0), const_GridAcao_Gravar, const_GridAcao_Neutro) And _
           FNC_NVL(.Cells(const_GridListagem_ID_ORDEMSERVICO_PRODUTO).Value, 0) = iID_ORDEMSERVICO_PRODUTO Then
          bAchou = True
          Exit For
        End If
      End With
    Next

    Return bAchou
  End Function

  Private Sub grdListagem_DoubleClick(sender As Object, e As EventArgs) Handles grdListagem.DoubleClick
    cmdEditar.PerformClick()
  End Sub
End Class
