Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmCadastroEstoque
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

  Private Sub frmCadastroEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboDepartamento, enSql.Departamento)



    objGrid_Inicializar(grdGrade, , oDBGridGrade, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)

    objGrid_Inicializar(grdLocalizacao, AllowAddNew.FixedAddRowOnTop, oDBGridLocalizacao, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdLocalizacao, "SQ_ESTOQUE_LOCALIZACAO", 0)
    objGrid_Coluna_Add(grdLocalizacao, "Localização", 300, , True, , , , , , 100)
    objGrid_Coluna_Add(grdLocalizacao, "Local", 100)
    objGrid_Coluna_Add(grdLocalizacao, "Linha", 100)
    objGrid_Coluna_Add(grdLocalizacao, "Coluna", 100)
    objGrid_Coluna_Add(grdLocalizacao, "Ativo", 70, , True, ColumnStyle.CheckBox)

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

    tabGeral.TabPages.Remove(tbpProdutos)
    chkAtivo.Checked = True

    If iSQ_ESTOQUE > 0 Then
      CarregarDados()
      CarregarDados_SaldoEstoque()
    Else
      chkAtivo.Checked = True
      chkControlaLocalizacao_CheckedChanged(Nothing, Nothing)
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
    If chkControlaLocalizacao.Checked And grdLocalizacao.Rows.Count = 0 Then
      FNC_Mensagem("Esse estoque terá controle por locilização, mas não foi informado as localizações")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_ESTOQUE_CAD", False, "@SQ_ESTOQUE OUT", _
                                                    "@ID_DEPARTAMENTO_RESPONSAVEL", _
                                                    "@CD_ESTOQUE", _
                                                    "@NO_ESTOQUE", _
                                                    "@IC_CONTROLA_MINIMOS", _
                                                    "@IC_PERMITE_BLOQUEIO", _
                                                    "@IC_ATIVO", _
                                                    "@IC_CONTROLA_LOCALIZACAO", _
                                                    "@IC_ENTRADA_AUTOMATICA", _
                                                    "@IC_PERMITE_SALDO_NEGATIVO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_ESTOQUE", iSQ_ESTOQUE, , ParameterDirection.InputOutput), _
                            DBParametro_Montar("ID_DEPARTAMENTO_RESPONSAVEL", cboDepartamento.SelectedValue), _
                            DBParametro_Montar("CD_ESTOQUE", txtCodigoEstoque.Text), _
                            DBParametro_Montar("NO_ESTOQUE", Trim(txtNomeEstoque.Text)), _
                            DBParametro_Montar("IC_CONTROLA_MINIMOS", IIf(chkControlaMinimos.Checked, "S", "N")), _
                            DBParametro_Montar("IC_PERMITE_BLOQUEIO", IIf(chkPermiteBloqueio.Checked, "S", "N")), _
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N")), _
                            DBParametro_Montar("IC_CONTROLA_LOCALIZACAO", IIf(chkControlaLocalizacao.Checked, "S", "N")), _
                            DBParametro_Montar("IC_ENTRADA_AUTOMATICA", IIf(chkEntradaAutomatica.Checked, "S", "N")), _
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

    sSqlText = "SELECT *" & _
               " FROM TB_ESTOQUE" & _
               " WHERE SQ_ESTOQUE = " & iSQ_ESTOQUE
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      txtCodigoEstoque.Text = FNC_NVL(.Item("CD_ESTOQUE"), "")
      txtNomeEstoque.Text = .Item("NO_ESTOQUE")
      ComboBox_Selecionar(cboDepartamento, .Item("ID_DEPARTAMENTO_RESPONSAVEL"))
      chkControlaMinimos.Checked = (.Item("IC_CONTROLA_MINIMOS") = "S")
      chkControlaLocalizacao.Checked = (.Item("IC_CONTROLA_LOCALIZACAO") = "S")
      chkPermiteBloqueio.Checked = (.Item("IC_PERMITE_BLOQUEIO") = "S")
      chkEntradaAutomatica.Checked = (.Item("IC_ENTRADA_AUTOMATICA") = "S")
      chkPermiteSaldoNegativo.Checked = (.Item("IC_PERMITE_SALDO_NEGATIVO") = "S")
      chkAtivo.Checked = (.Item("IC_ATIVO") = "S")
    End With

    tabGeral.TabPages.Insert(1, tbpProdutos)
  End Sub

  Private Sub CarregarDados_SaldoEstoque()
    Dim sSqlText As String

    sSqlText = "SELECT DS_LOCALIZACAO," & _
                      "NO_GRUPOPRODUTO," & _
                      "NO_TIPO_PRODUTO," & _
                      "CD_PRODUTO," & _
                      "CD_BARRA," & _
                      "NO_PRODUTO," & _
                      "QT_SALDO," & _
                      "QT_BLOQUEADO," & _
                      "QT_SALDO - QT_BLOQUEADO QT_DISPONIVEL," & _
                      "VL_ULTIMA_COMPRA," & _
                      "VL_MEDIO," & _
                      "QT_ESTOQUE_RECOMENDADO," & _
                      "QT_ESTOQUE_MINIMO" & _
               " FROM VW_ESTOQUE_PRODUTO" & _
               " WHERE ID_ESTOQUE = " & iSQ_ESTOQUE & _
               " ORDER BY DS_LOCALIZACAO," & _
                         "NO_GRUPOPRODUTO," & _
                         "NO_TIPO_PRODUTO," & _
                         "NO_PRODUTO"
    objGrid_Carregar(grdProdutos, sSqlText, New Integer() {const_GridProdutos_DS_LOCALIZACAO, _
                                                           const_GridProdutos_NO_GRUPOPRODUTO, _
                                                           const_GridProdutos_NO_TIPO_PRODUTO, _
                                                           const_GridProdutos_CD_PRODUTO, _
                                                           const_GridProdutos_CD_BARRA, _
                                                           const_GridProdutos_NO_PRODUTO, _
                                                           const_GridProdutos_QT_SALDO, _
                                                           const_GridProdutos_QT_BLOQUEADO, _
                                                           const_GridProdutos_QT_DISPONIVEL, _
                                                           const_GridProdutos_VL_ULTIMA_COMPRA, _
                                                           const_GridProdutos_VL_MEDIO, _
                                                           const_GridProdutos_QT_ESTOQUE_RECOMENDADO, _
                                                           const_GridProdutos_QT_ESTOQUE_MINIMO})
  End Sub

  Private Sub chkControlaLocalizacao_CheckedChanged(sender As Object, e As EventArgs) Handles chkControlaLocalizacao.CheckedChanged
    Dim iCont As Integer = 0

    lblRLocal.Enabled = (chkControlaLocalizacao.Checked)
    grdLocal.Enabled = (chkControlaLocalizacao.Checked)
    lblRGrade.Enabled = (chkControlaLocalizacao.Checked)
    grdGrade.Enabled = (chkControlaLocalizacao.Checked)
    lblRLocalizacao.Enabled = (chkControlaLocalizacao.Checked)
    grdLocalizacao.Enabled = (chkControlaLocalizacao.Checked)

    If Not chkControlaLocalizacao.Checked Then
      oDBGridLocal.Rows.Clear()
      oDBGridGrade.Rows.Clear()
      oDBGridLocalizacao.Rows.Clear()

      While iCont <= grdLocalizacao.Rows.Count - 1
        With grdLocalizacao.Rows(iCont)
          If objGrid_Valor(grdLocalizacao, const_GridLocalicacao_DS_LOCAL, iCont) Is Nothing Then
            grdLocalizacao.Rows(iCont).Delete()
          Else
            iCont = iCont + 1
          End If
        End With
      End While
    End If
  End Sub

  Private Sub cmdProdutos_Atualizar_Click(sender As Object, e As EventArgs) Handles cmdProdutos_Atualizar.Click
    CarregarDados_SaldoEstoque()
  End Sub

  Private Sub cmdProdutos_Excel_Click(sender As Object, e As EventArgs) Handles cmdProdutos_Excel.Click
    objGrid_ExportarExcell(grdProdutos, Me.Text, cmdProdutos_Excel)
  End Sub
End Class