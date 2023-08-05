Imports Infragistics.Win

Public Class frmConsultaOrcamento
  Const const_GridListagem_SQ_ORCAMENTO_CLIENTE As Integer = 0
  Const const_GridListagem_ID_PESSOA As Integer = 1
  Const const_GridListagem_ID_OPT_STATUS As Integer = 2
  Const const_GridListagem_CD_ORCAMENTO_CLIENTE As Integer = 3
  Const const_GridListagem_DH_ORCAMENTO_CLIENTE As Integer = 4
  Const const_GridListagem_DT_VALIDADE As Integer = 5
  Const const_GridListagem_NO_PESSOA As Integer = 6
  Const const_GridListagem_NO_CONVENIO As Integer = 7
  Const const_GridListagem_NO_FINANCIAMENTO As Integer = 8
  Const const_GridListagem_NO_OPT_STATUS As Integer = 9

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(frmCadastroOrcamento)
  End Sub

  Private Sub frmConsultaOrcamento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdExcel.Top = cmdNovo.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdNovo.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub frmConsultaOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboConvenio, enSql.Convenio_Ativo)
    ComboBox_Carregar(cboFinanciamento, enSql.Financiamento_Ativo)
    ComboBox_Carregar(cboProfissionalPrestadorServico, enSql.PessoaProfissionalFornecedorConvenio_Ativo)
    ComboBox_Carregar(cboStatus, enSql.StatusOrcamentoClinica)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_ORCAMENTO_CLIENTE", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdListagem, "Código do Orçamento", 150)
    objGrid_Coluna_Add(grdListagem, "D/H  do Orçamento", 150)
    objGrid_Coluna_Add(grdListagem, "Data de Validade", 150)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 300)
    objGrid_Coluna_Add(grdListagem, "Convênio", 250)
    objGrid_Coluna_Add(grdListagem, "Financiamento", 250)
    objGrid_Coluna_Add(grdListagem, "Status", 250)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    txtDataValidadeInicial.Value = Nothing
    txtDataValidadeFinal.Value = Nothing

    cmdNovo.Enabled = FNC_Permissao(enPermissao.AGEN_Orcamento).bIncluir
    cmdAlterar.Enabled = FNC_Permissao(enPermissao.AGEN_Orcamento).bAlterar
    cmdVenda.Enabled = FNC_Permissao(enPermissao.VEND_ConsultaVenda).bIncluir
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""

    sSqlText = "SELECT OCCLI.SQ_ORCAMENTO_CLIENTE," +
                      "OCCLI.ID_PESSOA," +
                      "OCCLI.ID_OPT_STATUS," +
                      "OCCLI.CD_ORCAMENTO_CLIENTE," +
                      "OCCLI.DH_ORCAMENTO_CLIENTE," +
                      "OCCLI.DT_VALIDADE," +
                      "PESSO.NO_PESSOA," +
                      "CONVE.NO_CONVENIO," +
                      "FINAN.NO_FINANCIAMENTO," +
                      "OPCAO_STATU.NO_OPCAO" +
               " FROM TB_ORCAMENTO_CLIENTE OCCLI" +
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = OCCLI.ID_PESSOA" +
                " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = OCCLI.ID_CONVENIO" +
                " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = OCCLI.ID_OPT_STATUS" +
                 " LEFT JOIN TB_FINANCIAMENTO FINAN ON FINAN.SQ_FINANCIAMENTO = OCCLI.ID_FINANCIAMENTO"

    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "OCCLI.ID_PESSOA = " & psqPessoa.ID_Pessoa, " AND ")
    End If
    If ComboBox_Selecionado(cboConvenio) Then
      FNC_Str_Adicionar(sSqlText_Where, "OCCLI.ID_CONVENIO = " & cboConvenio.SelectedValue, " AND ")
    End If
    If txtDataValidadeInicial.IsDateValid And Not txtDataValidadeInicial.Value Is Nothing Then
      FNC_Str_Adicionar(sSqlText_Where, "OCCLI.DT_VALIDADE >= " & FNC_QuotedStr(txtDataValidadeInicial.Value), " AND ")
    End If
    If txtDataValidadeFinal.IsDateValid And Not txtDataValidadeFinal.Value Is Nothing Then
      FNC_Str_Adicionar(sSqlText_Where, "OCCLI.DT_VALIDADE <= " & FNC_QuotedStr(txtDataValidadeFinal.Value), " AND ")
    End If
    If ComboBox_Selecionado(cboProfissionalPrestadorServico) Then
      FNC_Str_Adicionar(sSqlText_Where, "OCCLI.ID_FINANCIAMENTO = " & cboProfissionalPrestadorServico.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboFinanciamento) Then
      FNC_Str_Adicionar(sSqlText_Where, "OCCLI.ID_FINANCIAMENTO = " & cboFinanciamento.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboStatus) Then
      FNC_Str_Adicionar(sSqlText_Where, "OCCLI.ID_OPT_STATUS = " & cboStatus.SelectedValue, " AND ")
    End If
    If Trim(txtCodigo.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "OCCLI.CD_ORCAMENTO_CLIENTE = " & FNC_QuotedStr(txtCodigo.Text), " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " WHERE " & sSqlText_Where
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_ORCAMENTO_CLIENTE,
                                                           const_GridListagem_ID_PESSOA,
                                                           const_GridListagem_ID_OPT_STATUS,
                                                           const_GridListagem_CD_ORCAMENTO_CLIENTE,
                                                           const_GridListagem_DH_ORCAMENTO_CLIENTE,
                                                           const_GridListagem_DT_VALIDADE,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_NO_CONVENIO,
                                                           const_GridListagem_NO_FINANCIAMENTO,
                                                           const_GridListagem_NO_OPT_STATUS})
  End Sub

  Private Sub cmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser alterado")
      Exit Sub
    End If

    Dim oForm As New frmCadastroOrcamento

    oForm.iSQ_ORCAMENTO_CLIENTE = objGrid_Valor(grdListagem, const_GridListagem_SQ_ORCAMENTO_CLIENTE)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cmdVenda_Click(sender As Object, e As EventArgs) Handles cmdVenda.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar o orçamento para o qual deseja gerar uma venda")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO" &
                " WHERE ID_OPT_STATUS = " & enOpcoes.StatusItemOrcamentoClinica_Cadastrado &
                  " AND ID_ORCAMENTO_CLIENTE = " & objGrid_Valor(grdListagem, const_GridListagem_SQ_ORCAMENTO_CLIENTE)

    If DBQuery_ValorUnico(sSqlText, 0) = 0 Then
      FNC_Mensagem("É necessário selecionar um orçamento com o itens pendentes para venda para gerar uma venda")
      Exit Sub
    End If

    Dim oForm As New frmCadastroVenda

    oForm.iID_PESSOA = objGrid_Valor(grdListagem, const_GridListagem_ID_PESSOA)
    oForm.iID_ORCAMENTO_CLIENTE = objGrid_Valor(grdListagem, const_GridListagem_SQ_ORCAMENTO_CLIENTE)

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    psqPessoa.ID_Pessoa = 0
    cboConvenio.SelectedIndex = -1
    cboFinanciamento.SelectedIndex = -1
    cboProfissionalPrestadorServico.SelectedIndex = -1
    cboStatus.SelectedIndex = -1
    txtCodigo.Text = ""
    txtDataValidadeInicial.Value = Nothing
    txtDataValidadeFinal.Value = Nothing
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser impresso")
      Exit Sub
    End If

    FormRelatorioOrcamentoProcedimentos(objGrid_Valor(grdListagem, const_GridListagem_SQ_ORCAMENTO_CLIENTE))
  End Sub
End Class