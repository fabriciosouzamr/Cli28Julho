Imports Infragistics.Win

Public Class frmConsultaVenda
  Const const_GridListagem_SQ_CLINICA_VENDA As Integer = 0
  Const const_GridListagem_NR_ORIGEM_VENDA As Integer = 1
  Const const_GridListagem_CD_CLINICA_VENDA As Integer = 2
  Const const_GridListagem_Empresa As Integer = 3
  Const const_GridListagem_Paciente As Integer = 4
  Const const_GridListagem_Indicação As Integer = 5
  Const const_GridListagem_CodOrigemVenda As Integer = 6
  Const const_GridListagem_DHVenda As Integer = 7
  Const const_GridListagem_QtdeProcedimento As Integer = 8
  Const const_GridListagem_VlrTotalProcedimento As Integer = 9
  Const const_GridListagem_VlrDesconto As Integer = 10
  Const const_GridListagem_VlrDevolucao As Integer = 11
  Const const_GridListagem_DH_Cancelamento As Integer = 12
  Const const_GridListagem_Obs_Cancelamento As Integer = 13
  Const const_GridListagem_TP_REALIZADO As Integer = 14
  Const const_GridListagem_IC_QUITADA As Integer = 15
  Const const_GridListagem_NO_CANALMARCACAO As Integer = 16
  Const const_GridListagem_SQ_MOVFINANCEIRA As Integer = 17

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub frmConsultaVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboEmpresa, enSql.EmpresaAtiva)
    ComboBox_Carregar(cboConvenio, enSql.Convenio)
    ComboBox_Carregar(cboContaCaixa, enSql.ContaCaixa, New Object() {iID_USUARIO})
    ComboBox_Carregar(cboProfissionalPrestadorServico, enSql.PessoaProfissionalFornecedorConvenio_Ativo)
    ComboBox_Carregar(cboOrigemVenda, New String() {"Orcamento Clínica", "Agendamento"},
                                      New Object() {enOrigemVenda.OrcamentoClinica.GetHashCode(), enOrigemVenda.Agendamento.GetHashCode()})
    cboOrigemVenda.SelectedIndex = -1

    ComboBox_Selecionar(cboEmpresa, iID_EMPRESA_FILIAL)

    txtDataVendaInicial.Value = DateTime.Now()
    txtDataVendaFinal.Value = DateTime.Now()

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_CLINICA_VENDA", 0)
    objGrid_Coluna_Add(grdListagem, "NR_ORIGEM_VENDA", 0)
    objGrid_Coluna_Add(grdListagem, "Cód. Venda", 100)
    objGrid_Coluna_Add(grdListagem, "Empresa", 150)
    objGrid_Coluna_Add(grdListagem, "Paciente", 350)
    objGrid_Coluna_Add(grdListagem, "Indicação", 150)
    objGrid_Coluna_Add(grdListagem, "Cód. Origem Venda", 100)
    objGrid_Coluna_Add(grdListagem, "D/H Venda", 150)
    objGrid_Coluna_Add(grdListagem, "Qtde. Procedimento", 0)
    objGrid_Coluna_Add(grdListagem, "Vlr. Total Procedimento", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Vlr. Desconto", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Vlr. Devolução", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "D/H Cancelamento", 150, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Obs. Cancelamento", 350)
    objGrid_Coluna_Add(grdListagem, "Atendido", 100)
    objGrid_Coluna_Add(grdListagem, "Quitada", 100)
    objGrid_Coluna_Add(grdListagem, "Canal Marcação", 100)
    objGrid_Coluna_Add(grdListagem, "SQ_MOVFINANCEIRA", 0)

    cmdNovo.Enabled = FNC_Permissao(enPermissao.VEND_ConsultaVenda).bIncluir
    cmdAlterar.Enabled = FNC_Permissao(enPermissao.VEND_ConsultaVenda).bAlterar
    cmdCancelar.Enabled = FNC_Permissao(enPermissao.VEND_ConsultaVenda).bExcluir
  End Sub

  Private Sub ComboBoxOrigemVenda_Validar()
    lblRCodigoOrigemVenda.Enabled = (cboOrigemVenda.SelectedIndex > -1)
    txtCodigoOrigemVenda.Enabled = (cboOrigemVenda.SelectedIndex > -1)
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaVenda_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdCancelar.Top = cmdNovo.Top
    cmdExcel.Top = cmdNovo.Top
    cmdPDF.Top = cmdNovo.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdNovo.Top
    cmdGuiaConsultas.Top = cmdNovo.Top
    cmdExameExterno.Top = cmdNovo.Top
    cmdExameInterno.Top = cmdNovo.Top
    cmdDevolver.Top = cmdNovo.Top
    chkImrimirExameExterno.Top = cmdNovo.Top
    chkImrimirExameInterno.Top = cmdNovo.Top
    chkImrimirGuiaConsultas.Top = cmdNovo.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5

    lblQuantidade.Top = cmdPDF.Top
    lblValorTotal.Top = lblQuantidade.Top + lblQuantidade.Height
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""

    If Trim(txtCodigoVenda.Text) = "" Then
      If Not IsDate(txtDataVendaInicial.Text) Then
        FNC_Mensagem("Informe a data inicial para a pesquisa")
        Exit Sub
      End If
      If Not IsDate(txtDataVendaFinal.Text) Then
        FNC_Mensagem("Informe a data final para a pesquisa")
        Exit Sub
      End If
    End If

    sSqlText = "SELECT CLVND.SQ_CLINICA_VENDA," &
                      "IIF(CLVND.ID_ATENDIMENTO IS NULL," &
                          "IIF(CVDPC.IC_AGENDAMENTO = 1," &
                              "IIF(CLVND.ID_ORCAMENTO_CLIENTE IS NULL, 0, " & enOrigemVenda.OrcamentoClinica & "), " & enOrigemVenda.Agendamento & "), " & "-1) NR_ORIGEM_VENDA," &
                      "CLVND.CD_CLINICA_VENDA," &
                      "EMPRE.NO_PESSOA," &
                      "PESSO.NO_PESSOA," &
                      "INDIC.NO_INDICACAO," &
                      "ISNULL(CAST(ATEND.CD_ATENDIMENTO AS VARCHAR(1000)), ISNULL(CAST(OCCLI.CD_ORCAMENTO_CLIENTE AS VARCHAR(1000)), dbo.FC_CLINICA_VENDA_AGENDAMENTO(CLVND.SQ_CLINICA_VENDA))) CD_ORIGEM_VENDA," &
                      "CLVND.DH_VENDA," &
                      "CVDPC.QT_CLINICA_VENDA_PROCEDIMENTO," &
                      "CVDPC.VL_CLINICA_VENDA_PROCEDIMENTO," &
                      "ISNULL(MVFRC.VL_DESCONTO, 0) VL_DESCONTO," &
                      "ISNULL(CVDPC.VL_DEVOLUCAO, 0) VL_DEVOLUCAO," &
                      "CLVND.DH_CANCELAR," &
                      "CLVND.CM_OBSERVACAO_CANCELAMENTO," &
                      "IIF(STSAG.ID_CLINICA_VENDA IS NULL, 'N', 'S') TP_REALIZADO," &
                      "ISNULL(MFCVD.IC_QUITADA, 'N') IC_QUITADA," &
                      "CNLMC.NO_CANALMARCACAO," &
                      "MVFNC.SQ_MOVFINANCEIRA" &
               " FROM TB_CLINICA_VENDA CLVND" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                " INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = CLVND.ID_EMPRESA" &
                 " LEFT JOIN TB_CANALMARCACAO CNLMC ON CNLMC.SQ_CANALMARCACAO = CLVND.ID_CANALMARCACAO" &
                " INNER JOIN (SELECT ID_CLINICA_VENDA," &
                                    "COUNT(*) QT_CLINICA_VENDA_PROCEDIMENTO," &
                                    "SUM(ISNULL(VL_PROCEDIMENTO, 0)) VL_CLINICA_VENDA_PROCEDIMENTO," &
                                    "SUM(ISNULL(VL_DESCONTO, 0)) VL_DESCONTO," &
                                    "SUM(IIF(ID_CLINICA_VENDA_DEVOLUCAO IS NULL, 0, ISNULL(VL_PROCEDIMENTO - VL_DESCONTO, 0))) VL_DEVOLUCAO," &
                                    "MAX(IIF(ID_AGENDAMENTO IS NULL, 0, 1)) IC_AGENDAMENTO" &
                             " FROM TB_CLINICA_VENDA_PROCEDIMENTO GROUP BY ID_CLINICA_VENDA) CVDPC ON CVDPC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                 " LEFT JOIN (SELECT ID_CLINICA_VENDA," &
                                    "SUM(VL_ORIGINAL) VL_ORIGINAL," &
                                    "SUM(VL_DESCONTO) VL_DESCONTO" &
                             " FROM TB_MOVFINANCEIRA" &
                             " WHERE ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                             " GROUP BY ID_CLINICA_VENDA) MVFRC ON MVFRC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA"

    If psqProcedimento.Identificador > 0 Then
      sSqlText = sSqlText &
                " INNER JOIN (SELECT DISTINCT ID_CLINICA_VENDA" &
                             " FROM TB_CLINICA_VENDA_PROCEDIMENTO" &
                             " WHERE ID_PROCEDIMENTO = " & psqProcedimento.Identificador & ") CVDPC1 ON CVDPC1.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA"
    End If
    If ComboBox_Selecionado(cboProfissionalPrestadorServico) Then
      sSqlText = sSqlText &
                " INNER JOIN (SELECT DISTINCT ID_CLINICA_VENDA" &
                             " FROM TB_CLINICA_VENDA_PROCEDIMENTO" &
                             " WHERE ID_PESSOA_PROFISSIONAL = " & cboProfissionalPrestadorServico.SelectedValue & ") CVDPC2 ON CVDPC2.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA"
    End If

    sSqlText = sSqlText &
                 " LEFT JOIN TB_MOVFINANCEIRA MVFNC ON MVFNC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                                                 " AND MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                 " LEFT JOIN (SELECT DISTINCT MVFNC.ID_CLINICA_VENDA, 'S' IC_QUITADA" &
                             " FROM TB_MOVFINANCEIRA MVFNC" &
                              " INNER JOIN TB_MOVFINANCEIRAPARCELA MVFNP ON MVFNP.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                              " INNER JOIN TB_OPCAO OPSTS ON OPSTS.SQ_OPCAO =  MVFNP.ID_OPT_STATUS" &
                             " WHERE MVFNC.ID_CLINICA_VENDA IS NOT NULL" &
                               " AND OPSTS.CD_OPCAO = 'F') MFCVD ON MFCVD.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                 " LEFT JOIN TB_INDICACAO INDIC ON INDIC.SQ_INDICACAO = CLVND.ID_INDICACAO" &
                 " LEFT JOIN TB_ATENDIMENTO ATEND ON ATEND.SQ_ATENDIMENTO = CLVND.ID_ATENDIMENTO" &
                 " LEFT JOIN TB_ORCAMENTO_CLIENTE OCCLI ON OCCLI.SQ_ORCAMENTO_CLIENTE = CLVND.ID_ORCAMENTO_CLIENTE" &
                 " LEFT JOIN (SELECT DISTINCT CLVCN.ID_CLINICA_VENDA" &
                             " FROM TB_CLINICA_VENDA_PROCEDIMENTO CLVCN" &
                              " INNER JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CLVCN.ID_AGENDAMENTO" &
                             " WHERE AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Atendido.GetHashCode() & ") STSAG ON STSAG.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
               " WHERE CLVND.ID_EMPRESA = " & cboEmpresa.SelectedValue.ToString()

    If IsDate(txtDataVendaInicial.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(CLVND.DH_VENDA AS DATE) >= " & FNC_QuotedStr(txtDataVendaInicial.Text), " AND ")
    End If
    If IsDate(txtDataVendaFinal.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(CLVND.DH_VENDA AS DATE) <= " & FNC_QuotedStr(txtDataVendaFinal.Text), " AND ")
    End If
    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.ID_PESSOA = " & psqPessoa.ID_Pessoa.ToString(), " AND ")
    End If
    If ComboBox_Selecionado(cboConvenio) Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.ID_CONVENIO = " & cboConvenio.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboContaCaixa) Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.ID_CONTAFINANCEIRA = " & cboContaCaixa.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboOrigemVenda) Then
      FNC_Str_Adicionar(sSqlText_Where, " IIF(CLVND.ID_ATENDIMENTO Is NULL," &
                                             "IIF(CVDPC.IC_AGENDAMENTO = 1," &
                                                 "IIF(CLVND.ID_ORCAMENTO_CLIENTE Is NULL, 0, " & enOrigemVenda.OrcamentoClinica & "), " & enOrigemVenda.Agendamento & "), " & "-1) = " & cboOrigemVenda.SelectedValue, " AND ")

      If Trim(txtCodigoOrigemVenda.Text) <> "" Then
        If cboOrigemVenda.SelectedValue = enOrigemVenda.Agendamento Then
          FNC_Str_Adicionar(sSqlText_Where, " CLVND.SQ_CLINICA_VENDA IN (SELECT ID_CLINICA_VENDA FROM VW_CLINICA_VENDA_AGENDAMENTO WHERE CD_AGENDAMENTO Like '%" & txtCodigoOrigemVenda.Text & "%')", " AND ")
        Else
          FNC_Str_Adicionar(sSqlText_Where, " ISNULL(CAST(ATEND.CD_ATENDIMENTO AS VARCHAR(1000)), ISNULL(CAST(OCCLI.CD_ORCAMENTO_CLIENTE AS VARCHAR(1000)), dbo.FC_CLINICA_VENDA_AGENDAMENTO(CLVND.SQ_CLINICA_VENDA))) LIKE '%" & txtCodigoOrigemVenda.Text & "%'", " AND ")
        End If
      End If
    End If
    If psqIndicacao.INDICACAO > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.ID_INDICACAO = " & psqIndicacao.INDICACAO, " AND ")
    End If
    If Not chkListarVendasCanceladas.Checked Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.DH_CANCELAR IS NULL ", " AND ")
    End If
    If Trim(txtCodigoVenda.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.CD_CLINICA_VENDA = " + FNC_QuotedStr(txtCodigoVenda.Text), " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " AND " & sSqlText_Where
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_CLINICA_VENDA,
                                                           const_GridListagem_NR_ORIGEM_VENDA,
                                                           const_GridListagem_CD_CLINICA_VENDA,
                                                           const_GridListagem_Empresa,
                                                           const_GridListagem_Paciente,
                                                           const_GridListagem_Indicação,
                                                           const_GridListagem_CodOrigemVenda,
                                                           const_GridListagem_DHVenda,
                                                           const_GridListagem_QtdeProcedimento,
                                                           const_GridListagem_VlrTotalProcedimento,
                                                           const_GridListagem_VlrDesconto,
                                                           const_GridListagem_VlrDevolucao,
                                                           const_GridListagem_DH_Cancelamento,
                                                           const_GridListagem_Obs_Cancelamento,
                                                           const_GridListagem_TP_REALIZADO,
                                                           const_GridListagem_IC_QUITADA,
                                                           const_GridListagem_NO_CANALMARCACAO,
                                                           const_GridListagem_SQ_MOVFINANCEIRA})
    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VlrTotalProcedimento, const_GridListagem_VlrDesconto, const_GridListagem_VlrDevolucao})

    lblQuantidade.Text = Trim(lblQuantidade.Tag) & " " & grdListagem.Rows.Count.ToString()
    lblValorTotal.Text = Trim(lblValorTotal.Tag) & " " & FormatCurrency(objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_VlrTotalProcedimento, grdTipoCalculoTotal.SomarValor) -
                                                                        objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_VlrDesconto, grdTipoCalculoTotal.SomarValor) -
                                                                        objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_VlrDevolucao, grdTipoCalculoTotal.SomarValor))
  End Sub

  Private Sub cboOrigemVenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigemVenda.SelectedIndexChanged
    ComboBoxOrigemVenda_Validar()
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione a venda a ser alterada")
      Exit Sub
    End If
    If Convert.ToDateTime(objGrid_Valor(grdListagem, const_GridListagem_DHVenda)).Date <> Now.Date Then
      FNC_Mensagem("Só é permitido atualizar vendas do mesmo dia")
      Exit Sub
    End If

    Dim oForm As New frmCadastroVendaAlteracao

    oForm.iID_CLINICA_VENDA = objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_VENDA)

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(New frmCadastroVenda)
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    psqPessoa.ID_Pessoa = 0
    txtDataVendaInicial.Value = Nothing
    txtDataVendaFinal.Value = Nothing
    cboOrigemVenda.SelectedIndex = -1
    txtCodigoOrigemVenda.Text = ""
    psqProcedimento.Limpar()
    psqIndicacao.Limpar()
    cboConvenio.SelectedIndex = -1
    cboProfissionalPrestadorServico.SelectedIndex = -1
    cboContaCaixa.SelectedIndex = -1
    cboEmpresa.SelectedIndex = -1
  End Sub

  Private Sub cboOrigemVenda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboOrigemVenda.KeyDown,
                                                                                  cboConvenio.KeyDown,
                                                                                  cboProfissionalPrestadorServico.KeyDown,
                                                                                  cboContaCaixa.KeyDown
    If e.KeyCode = Keys.Delete Then
      Dim oComboBox As ComboBox

      oComboBox = sender

      oComboBox.SelectedIndex = -1
    End If
  End Sub

  Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione a venda a ser cancelada")
      Exit Sub
    End If
    If CDate(objGrid_Valor(grdListagem, const_GridListagem_DHVenda)).Date <> Now().Date Then
      FNC_Mensagem("Só é permitido cancelar venda do mesmo dia")
      Exit Sub
    End If
    If iUSUARIO_ID_OPT_TIPOFUNCAO <> enOpcoes.TipoFuncao_Supervisao.GetHashCode() Then
      If FNC_Perguntar("Somente usuário com perfil de supervisor pode excluir venda de um atendimento realizado. Deseja abrir uma tela para validar usuário de supervisão?") Then
        If Not FormSEGUsuario_Validacao() Then
          Exit Sub
        End If
      Else
        Exit Sub
      End If
    End If

    Dim oForm As New frmConsultaVendaCancelamento

    oForm.iID_CLINICA_VENDA = objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_VENDA)

    FNC_AbriTela(oForm, , True, True)

    Pesquisar()
  End Sub

  Private Sub cmdGuiaConsultas_Click(sender As Object, e As EventArgs) Handles cmdGuiaConsultas.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione a venda a ser impressa")
      Exit Sub
    End If

    FormRelatorioGuiaConsulta(objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_VENDA), chkImrimirGuiaConsultas.Checked)
  End Sub

  Private Sub cmdExameInterno_Click(sender As Object, e As EventArgs) Handles cmdExameInterno.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione a venda a ser impressa")
      Exit Sub
    End If

    FormRelatorioExameInterno(objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_VENDA), chkImrimirExameInterno.Checked)
  End Sub

  Private Sub cmdExameExterno_Click(sender As Object, e As EventArgs) Handles cmdExameExterno.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione a venda a ser impressa")
      Exit Sub
    End If

    FormRelatorioExameExterno(objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_VENDA), chkImrimirExameExterno.Checked)
  End Sub

  Private Sub cmdDevolver_Click(sender As Object, e As EventArgs) Handles cmdDevolver.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione a venda a ser devolvida")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_DH_Cancelamento,, "") <> "" Then
      FNC_Mensagem("Venda já cancelada")
      Exit Sub
    End If

    Dim oForm As New frmConsultaVendaDevolucao

    oForm.iSQ_CLINICA_VENDA = objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_VENDA)

    FNC_AbriTela(oForm, , True, True)

    Pesquisar()
  End Sub
End Class