Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmpsqProduto
  Public SQ_PRODUTO() As Integer
  Public SQ_PRODUTO_EMPRESA() As Integer
  Public ID_UNIDADEMEDIDA() As Integer
  Public NO_PRODUTO() As String
  Public PRODUTO_LINHA() As Boolean
  Public sFiltro As String = ""
  Public MultiploSelecao As Boolean = False
  Public ListarLinhaProduto As Boolean = False

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdSelecionar_Click(sender As Object, e As EventArgs) Handles cmdSelecionar.Click
    RetornarSelecionado()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisa()
  End Sub

  Private Sub Pesquisa()
    FormPesquisaProduto_Pesquisar(grdListagem,
                                  txtNomeProduto.Text,
                                  FNC_NVL(cboTipoProduto.SelectedValue, -1),
                                  -1, -1, txtCodigos.Text,
                                  Mid(cboAtivo.SelectedItem(0), 1, 1),,
                                  ListarLinhaProduto)
  End Sub

  Private Sub RetornarSelecionado()
    If (objGrid_LinhaSelecionada(grdListagem) > -1 And Not MultiploSelecao) Or
       (objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagemProduto_Check) > 0 And MultiploSelecao) Then
      If MultiploSelecao Then
        Dim iCont As Integer
        Dim iSelecionado As Integer = 0

        ReDim SQ_PRODUTO(objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagemProduto_Check) - 1)
        ReDim SQ_PRODUTO_EMPRESA(objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagemProduto_Check) - 1)
        ReDim ID_UNIDADEMEDIDA(objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagemProduto_Check) - 1)
        ReDim NO_PRODUTO(objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagemProduto_Check) - 1)
        ReDim PRODUTO_LINHA(objGrid_CheckBox_QtdeSelecionado(grdListagem, const_GridListagemProduto_Check) - 1)

        For iCont = 0 To grdListagem.Rows.Count - 1
          If objGrid_CheckBox_Selecionado(grdListagem, const_GridListagemProduto_Check, iCont) Then
            SQ_PRODUTO(iSelecionado) = objGrid_Valor(grdListagem, const_GridListagemProduto_ID_PRODUTO, iCont)
            SQ_PRODUTO_EMPRESA(iSelecionado) = objGrid_Valor(grdListagem, const_GridListagemProduto_ID_PRODUTO_EMPRESA, iCont)
            ID_UNIDADEMEDIDA(iSelecionado) = FNC_NVL(objGrid_Valor(grdListagem, const_GridListagemProduto_ID_UNIDADEMEDIDA, iCont), 0)
            NO_PRODUTO(iSelecionado) = objGrid_Valor(grdListagem, const_GridListagemProduto_NO_PRODUTO, iCont)
            PRODUTO_LINHA(iSelecionado) = (objGrid_Valor(grdListagem, const_GridListagemProduto_TIPO, iCont) = enListagemProduto_Tipo.LinhaProduto)
            iSelecionado = iSelecionado + 1
          End If
        Next
      Else
        SQ_PRODUTO(0) = objGrid_Valor(grdListagem, const_GridListagemProduto_ID_PRODUTO)
        SQ_PRODUTO_EMPRESA(0) = objGrid_Valor(grdListagem, const_GridListagemProduto_ID_PRODUTO_EMPRESA)
        ID_UNIDADEMEDIDA(0) = objGrid_Valor(grdListagem, const_GridListagemProduto_ID_UNIDADEMEDIDA)
        NO_PRODUTO(0) = objGrid_Valor(grdListagem, const_GridListagemProduto_NO_PRODUTO)
        PRODUTO_LINHA(0) = (objGrid_Valor(grdListagem, const_GridListagemProduto_TIPO) = enListagemProduto_Tipo.LinhaProduto)
      End If

      Close()
    Else
      FNC_Mensagem("Selecione um registro")
    End If
  End Sub

  Private Sub grdListagem_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdListagem.DoubleClickRow
    RetornarSelecionado()
  End Sub

  Private Sub cboTipoProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoProduto.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoProduto.SelectedIndex = -1
  End Sub

  Private Sub frmpsqProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboTipoProduto, enSql.TipoProduto)
    cboAtivo.SelectedIndex = 1

    ReDim SQ_PRODUTO(0)
    ReDim SQ_PRODUTO_EMPRESA(0)
    ReDim NO_PRODUTO(0)
    ReDim PRODUTO_LINHA(0)
    ReDim ID_UNIDADEMEDIDA(0)

    SQ_PRODUTO(0) = 0
    SQ_PRODUTO_EMPRESA(0) = 0
    ID_UNIDADEMEDIDA(0) = 0
    NO_PRODUTO(0) = ""
    PRODUTO_LINHA(0) = False

    FormPesquisaProduto_FormatarGrid(grdListagem, oDBGrid)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    grdListagem.DisplayLayout.Bands(0).Columns(const_GridListagemProduto_Check).Hidden = (Not MultiploSelecao)

    If sFiltro <> "" Then
      txtNomeProduto.Text = sFiltro
      Pesquisa()
    End If
  End Sub

  Private Sub frmpsqProduto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub
End Class