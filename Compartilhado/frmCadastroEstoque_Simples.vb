Imports Infragistics.Win

Public Class frmCadastroEstoque_Simples
  Const const_GridLocal_Nome As Integer = 0
  Const const_GridLocal_Linhas As Integer = 1
  Const const_GridLocal_Coluna As Integer = 2
  Const const_GridLocal_Ativo As Integer = 3

  Const const_GridLocalicacao_SQ_ESTOQUE_LOCALIZACAO As Integer = 0
  Const const_GridLocalicacao_DS_LOCALIZACAO As Integer = 1
  Const const_GridLocalicacao_DS_LOCAL As Integer = 2
  Const const_GridLocalicacao_CD_LINHA As Integer = 3
  Const const_GridLocalicacao_CD_COLUNA As Integer = 4
  Const const_GridLocalicacao_IC_ATIVO As Integer = 5

  Const const_GridProdutos_DS_LOCALIZACAO As Integer = 0
  Const const_GridProdutos_NO_GRUPOPRODUTO As Integer = 1
  Const const_GridProdutos_NO_TIPO_PRODUTO As Integer = 2
  Const const_GridProdutos_CD_PRODUTO As Integer = 3
  Const const_GridProdutos_CD_BARRA As Integer = 4
  Const const_GridProdutos_NO_PRODUTO As Integer = 5
  Const const_GridProdutos_QT_SALDO As Integer = 6
  Const const_GridProdutos_QT_BLOQUEADO As Integer = 7
  Const const_GridProdutos_QT_DISPONIVEL As Integer = 8
  Const const_GridProdutos_VL_ULTIMA_COMPRA As Integer = 9
  Const const_GridProdutos_VL_MEDIO As Integer = 10
  Const const_GridProdutos_QT_ESTOQUE_RECOMENDADO As Integer = 11
  Const const_GridProdutos_QT_ESTOQUE_MINIMO As Integer = 12

  Public Event Pesquisar()

  Public iSQ_ESTOQUE As Integer
  Public iTipoTela As Integer

  Dim oDBGridLocal As New UltraWinDataSource.UltraDataSource
  Dim oDBGridGrade As New UltraWinDataSource.UltraDataSource
  Dim oDBGridLocalizacao As New UltraWinDataSource.UltraDataSource
  Dim oDBGridProdutos As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroEstoque_Simples_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboDepartamento, enSql.Departamento)

    objGrid_Inicializar(grdProdutos, , oDBGridProdutos, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdProdutos, "Localização", 150)
    objGrid_Coluna_Add(grdProdutos, "Grupo de Produto", 110)
    objGrid_Coluna_Add(grdProdutos, "Tipo de Produto", 110)
    objGrid_Coluna_Add(grdProdutos, "Cód. Produto", 100)
    objGrid_Coluna_Add(grdProdutos, "Cód. Barra", 100)
    objGrid_Coluna_Add(grdProdutos, "Produto", 250)
    objGrid_Coluna_Add(grdProdutos, "Qtde. Saldo", 110, , , , , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdProdutos, "Qtde. Bloqueado", 110, , , , , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdProdutos, "Qtde. Disponível", 110, , , , , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdProdutos, "Vl. Últ. Compra", 100, , , , , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdProdutos, "Vl. Médio", 100, , , , , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdProdutos, "Qtde. Recomedada", 120, , , , , const_Formato_Fracao_4casas)
    objGrid_Coluna_Add(grdProdutos, "Qtde. Est. Mínimo", 120, , , , , const_Formato_Fracao_4casas)
    objGrid_Configuracao_Carregar(grdProdutos, Me.Name)

    chkAtivo.Checked = True

    If iSQ_ESTOQUE > 0 Then
      CarregarDados()
      CarregarDados_SaldoEstoque()
    Else
      chkAtivo.Checked = True
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Trim(txtNomeEstoque.Text) = "" Then
      FNC_Mensagem("Informe o nome do estoque")
      Exit Sub
    End If
    If Trim(txtCodigoEstoque.Text) = "" Then
      FNC_Mensagem("Informe o código do estoque")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboDepartamento) Then
      FNC_Mensagem("Selecione o departamento")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_ESTOQUE_CAD", False, "@SQ_ESTOQUE OUT",
                                                    "@ID_DEPARTAMENTO_RESPONSAVEL",
                                                    "@CD_ESTOQUE",
                                                    "@NO_ESTOQUE",
                                                    "@IC_CONTROLA_MINIMOS",
                                                    "@IC_PERMITE_BLOQUEIO",
                                                    "@IC_ATIVO",
                                                    "@IC_CONTROLA_LOCALIZACAO",
                                                    "@IC_ENTRADA_AUTOMATICA",
                                                    "@IC_PERMITE_SALDO_NEGATIVO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_ESTOQUE", iSQ_ESTOQUE, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_DEPARTAMENTO_RESPONSAVEL", cboDepartamento.SelectedValue),
                            DBParametro_Montar("CD_ESTOQUE", txtCodigoEstoque.Text),
                            DBParametro_Montar("NO_ESTOQUE", Trim(txtNomeEstoque.Text)),
                            DBParametro_Montar("IC_CONTROLA_MINIMOS", IIf(chkControlaMinimos.Checked, "S", "N")),
                            DBParametro_Montar("IC_PERMITE_BLOQUEIO", IIf(chkPermiteBloqueio.Checked, "S", "N")),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N")),
                            DBParametro_Montar("IC_CONTROLA_LOCALIZACAO", "N"),
                            DBParametro_Montar("IC_ENTRADA_AUTOMATICA", IIf(chkEntradaAutomatica.Checked, "S", "N")),
                            DBParametro_Montar("IC_PERMITE_SALDO_NEGATIVO", IIf(chkPermiteSaldoNegativo.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_ESTOQUE = DBRetorno(1)
      End If

      RaiseEvent Pesquisar()

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT *" &
               " FROM TB_ESTOQUE" &
               " WHERE SQ_ESTOQUE = " & iSQ_ESTOQUE
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      txtCodigoEstoque.Text = FNC_NVL(.Item("CD_ESTOQUE"), "")
      txtNomeEstoque.Text = .Item("NO_ESTOQUE")
      ComboBox_Selecionar(cboDepartamento, .Item("ID_DEPARTAMENTO_RESPONSAVEL"))
      chkControlaMinimos.Checked = (.Item("IC_CONTROLA_MINIMOS") = "S")
      chkPermiteBloqueio.Checked = (.Item("IC_PERMITE_BLOQUEIO") = "S")
      chkEntradaAutomatica.Checked = (.Item("IC_ENTRADA_AUTOMATICA") = "S")
      chkPermiteSaldoNegativo.Checked = (.Item("IC_PERMITE_SALDO_NEGATIVO") = "S")
      chkAtivo.Checked = (.Item("IC_ATIVO") = "S")
    End With
  End Sub

  Private Sub CarregarDados_SaldoEstoque()
    Dim sSqlText As String

    sSqlText = "SELECT DS_LOCALIZACAO," &
                      "NO_GRUPOPRODUTO," &
                      "NO_TIPO_PRODUTO," &
                      "CD_PRODUTO," &
                      "CD_BARRA," &
                      "NO_PRODUTO," &
                      "QT_SALDO," &
                      "QT_BLOQUEADO," &
                      "QT_SALDO - QT_BLOQUEADO QT_DISPONIVEL," &
                      "VL_ULTIMA_COMPRA," &
                      "VL_MEDIO," &
                      "QT_ESTOQUE_RECOMENDADO," &
                      "QT_ESTOQUE_MINIMO" &
               " FROM VW_ESTOQUE_PRODUTO" &
               " WHERE ID_ESTOQUE = " & iSQ_ESTOQUE &
               " ORDER BY DS_LOCALIZACAO," &
                         "NO_GRUPOPRODUTO," &
                         "NO_TIPO_PRODUTO," &
                         "NO_PRODUTO"
    objGrid_Carregar(grdProdutos, sSqlText, New Integer() {const_GridProdutos_DS_LOCALIZACAO,
                                                           const_GridProdutos_NO_GRUPOPRODUTO,
                                                           const_GridProdutos_NO_TIPO_PRODUTO,
                                                           const_GridProdutos_CD_PRODUTO,
                                                           const_GridProdutos_CD_BARRA,
                                                           const_GridProdutos_NO_PRODUTO,
                                                           const_GridProdutos_QT_SALDO,
                                                           const_GridProdutos_QT_BLOQUEADO,
                                                           const_GridProdutos_QT_DISPONIVEL,
                                                           const_GridProdutos_VL_ULTIMA_COMPRA,
                                                           const_GridProdutos_VL_MEDIO,
                                                           const_GridProdutos_QT_ESTOQUE_RECOMENDADO,
                                                           const_GridProdutos_QT_ESTOQUE_MINIMO})
  End Sub

  Private Sub cmdProdutos_Atualizar_Click(sender As Object, e As EventArgs) Handles cmdProdutos_Atualizar.Click
    CarregarDados_SaldoEstoque()
  End Sub

  Private Sub cmdProdutos_Excel_Click(sender As Object, e As EventArgs) Handles cmdProdutos_Excel.Click
    objGrid_ExportarExcell(grdProdutos, Me.Text)
  End Sub

  Private Sub frmCadastroEstoque_Simples_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdProdutos, Me.Text)
  End Sub
End Class