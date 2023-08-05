Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmCadastroOrcamento
  Const const_GrdProcedimento_SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO = 0
  Const const_GrdProcedimento_ID_PROCEDIMENTO = 1
  Const const_GrdProcedimento_ID_PROFISSIONAL = 2
  Const const_GrdProcedimento_DescricaoProcedimentoExame = 3
  Const const_GrdProcedimento_MedicoPrestadorServico = 4
  Const const_GrdProcedimento_Valor = 5
  Const const_GrdProcedimento_Data = 6
  Const const_GrdProcedimento_Solicitante = 7
  Const const_GrdProcedimento_SQ_CLINICA_PROCEDIMENTO = 8
  Const const_GrdProcedimento_ID_CONVENIO = 9

  Const const_GridProfissional_ID_PESSOA_PROFISSIONAL = 0
  Const const_GridProfissional_ID_PROCEDIMENTO = 1
  Const const_GridProfissional_NO_PESSOA = 2
  Const const_GridProfissional_VL_PROCEDIMENTO = 3
  Const const_GridProfissional_PADRAO = 4

  Const const_GrdFinanciamento_QtdeParcela = 0
  Const const_GrdFinanciamento_Entrada = 1
  Const const_GrdFinanciamento_Juros = 2
  Const const_GrdFinanciamento_ValorOriginal = 3
  Const const_GrdFinanciamento_ValorEntrada = 4
  Const const_GrdFinanciamento_ValorRestanteComJuros = 5
  Const const_GrdFinanciamento_ValorParcela = 6

  Public iSQ_ORCAMENTO_CLIENTE As Integer
  Public iID_AGENDAMENTO As Integer

  Dim oDBGridProcedimento As New UltraWinDataSource.UltraDataSource
  Dim oDBGridFinanciamento As New UltraWinDataSource.UltraDataSource
  Dim oDBGridProfissional As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroOrcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboConvenio, enSql.Convenio_Ativo)
    ComboBox_Carregar(cboFinanceiro, enSql.Financiamento_Ativo)

    Procedimento_Limpar()

    objGrid_Inicializar(grdProcedimento, , oDBGridProcedimento, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdProcedimento, "SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdProcedimento, "ID_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdProcedimento, "ID_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdProcedimento, "Descrição do procedimento/Exame", 350)
    objGrid_Coluna_Add(grdProcedimento, "Médico/Prestador de serviço", 350)
    objGrid_Coluna_Add(grdProcedimento, "Valor R$", 150, ,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdProcedimento, "Data do Atendimento", 150, ,,,, const_Formato_Data)
    objGrid_Coluna_Add(grdProcedimento, "Solicitante", 350)
    objGrid_Coluna_Add(grdProcedimento, "SQ_CLINICA_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdProcedimento, "ID_CONVENIO", 0)

    objGrid_Inicializar(grdProfissional, , oDBGridProfissional, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdProfissional, "ID_PESSOA_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdProfissional, "ID_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdProfissional, "Médico/prestador de serviços", 400)
    objGrid_Coluna_Add(grdProfissional, "Vlr. Procedimento", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdProfissional, "Padrão", 100)
    objGrid_Coluna_Add(grdProfissional, "...", 50,,, UltraWinGrid.ColumnStyle.Button)

    objGrid_Inicializar(grdFinanciamento, , oDBGridFinanciamento, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdFinanciamento, "Qtde. de Parcela", 150)
    objGrid_Coluna_Add(grdFinanciamento, "% de Entrada", 200,,,,, const_Formato_Porcentagem)
    objGrid_Coluna_Add(grdFinanciamento, "% de Juros (m)", 200,,,,, const_Formato_Porcentagem)
    objGrid_Coluna_Add(grdFinanciamento, "Valor Original", 200,,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdFinanciamento, "Valor de Entrada", 200,,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdFinanciamento, "Valor Restante com Juros", 200,,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdFinanciamento, "Valor Parcela", 200,,,,, const_Formato_Valor)

    txtDataValidade.Value = Now.AddDays(iEMPRESA_NR_DIA_VALIDADEORCAMENTO)

    psqProcedimento.Convenio = -1
    psqProcedimento.AtualizarListaProcedimento()

    If iSQ_ORCAMENTO_CLIENTE > 0 Then
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT *" &
                 " FROM TB_ORCAMENTO_CLIENTE" +
                 " WHERE SQ_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE.ToString()
      oData = DBQuery(sSqlText)

      With oData.Rows(0)
        psqPessoa.ID_Pessoa = .Item("ID_PESSOA")
        ComboBox_Selecionar(cboConvenio, .Item("ID_CONVENIO"))
        ComboBox_Selecionar(cboFinanceiro, .Item("ID_FINANCIAMENTO"))
        txtDataValidade.Value = .Item("DT_VALIDADE")
        txtCodigo.Text = .Item("CD_ORCAMENTO_CLIENTE")
      End With

      oData.Dispose()

      sSqlText = "SELECT OCPRC.SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO," &
                        "OCPRC.ID_PROCEDIMENTO," &
                        "OCPRC.ID_PESSOA_PROFISSIONAL," &
                        "PROCE.NO_PROCEDIMENTO," &
                        "PESSO.NO_PESSOA," &
                        "OCPRC.VL_ORCADO," &
                        "OCPRC.ID_CONVENIO" &
                 " FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO OCPRC" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL" &
                 " WHERE OCPRC.ID_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE &
                 " ORDER BY PROCE.NO_PROCEDIMENTO"
      objGrid_Carregar(grdProcedimento, sSqlText, New Integer() {const_GrdProcedimento_SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO,
                                                                 const_GrdProcedimento_ID_PROCEDIMENTO,
                                                                 const_GrdProcedimento_ID_PROFISSIONAL,
                                                                 const_GrdProcedimento_DescricaoProcedimentoExame,
                                                                 const_GrdProcedimento_MedicoPrestadorServico,
                                                                 const_GrdProcedimento_Valor,
                                                                 const_GrdProcedimento_ID_CONVENIO})

      psqPessoa.Enabled = False
      cboConvenio.Enabled = False
      cboFinanceiro.Enabled = False
      txtCodigo.Enabled = False
    End If

    cmdGravar.Enabled = FNC_Permissao(enPermissao.AGEN_Orcamento).bGravar
  End Sub

  Private Sub cboConvenio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConvenio.SelectedIndexChanged
    If ComboBox_Selecionado(cboConvenio) Then
      psqProcedimento.Convenio = FNC_NuloZero(cboConvenio.SelectedValue)
    Else
      psqProcedimento.Convenio = -1
    End If

    Procedimento_Limpar()
  End Sub

  Private Sub Procedimento_Limpar()
    oDBGridProcedimento.Rows.Clear()

    For Each oRow As UltraWinDataSource.UltraDataRow In oDBGridFinanciamento.Rows
      oRow.SetCellValue(const_GrdFinanciamento_ValorOriginal, 0)
      oRow.SetCellValue(const_GrdFinanciamento_ValorEntrada, 0)
      oRow.SetCellValue(const_GrdFinanciamento_ValorRestanteComJuros, 0)
      oRow.SetCellValue(const_GrdFinanciamento_ValorParcela, 0)
    Next

    psqProcedimento.AtualizarListaProcedimento()

    oDBGridProfissional.Rows.Clear()

    CalcularTotalProcedimento()
  End Sub

  Private Sub CalcularTotalProcedimento()
    lblValorTotalProcedimento.Tag = objGrid_CalcularTotalColuna(grdProcedimento, const_GrdProcedimento_Valor, grdTipoCalculoTotal.SomarValor)
    lblValorTotalProcedimento.Text = FormatCurrency(lblValorTotalProcedimento.Tag, 2)
    lblQuantidade.Text = objGrid_CalcularTotalColuna(grdProcedimento, const_GrdProcedimento_Valor, grdTipoCalculoTotal.QuantidadeLinha)
  End Sub

  Private Sub cboProfissionalPrestadorServico_SelectedIndexChanged(sender As Object, e As EventArgs)
    Procedimento_Limpar()
  End Sub

  Private Sub cboFinanceiro_SelectedIndexChanged(sender As Object, e As EventArgs)
    oDBGridFinanciamento.Rows.Clear()

    If ComboBox_Selecionado(cboFinanceiro) Then
      Dim iCont As Integer

      For iCont = cboFinanceiro.SelectedItem(enComboBox_Financiamento.NR_MINIMO_PARCELA) To cboFinanceiro.SelectedItem(enComboBox_Financiamento.NR_MAXIMO_PARCELA)
        objGrid_Linha_Add(grdFinanciamento, New Object() {const_GrdFinanciamento_QtdeParcela, iCont,
                                                          const_GrdFinanciamento_Entrada, cboFinanceiro.SelectedItem(enComboBox_Financiamento.PC_ENTRADA) / 100,
                                                          const_GrdFinanciamento_Juros, cboFinanceiro.SelectedItem(enComboBox_Financiamento.PC_JUROS) / 100})
      Next

      FinanciamentoCalcular()
    End If
  End Sub

  Private Sub FinanciamentoCalcular()
    For Each oRow As UltraWinDataSource.UltraDataRow In oDBGridFinanciamento.Rows
      oRow.SetCellValue(const_GrdFinanciamento_ValorOriginal, FNC_NVL(lblValorTotalProcedimento.Tag, 0))
      oRow.SetCellValue(const_GrdFinanciamento_ValorEntrada, FNC_Porcentagem(FNC_NVL(lblValorTotalProcedimento.Tag, 0),
                                                                             FNC_NVL(oRow.GetCellValue(const_GrdFinanciamento_Entrada), 0) * 100))
      oRow.SetCellValue(const_GrdFinanciamento_ValorRestanteComJuros, FNC_Porcentagem(FNC_NVL(oRow.GetCellValue(const_GrdFinanciamento_ValorOriginal), 0) -
                                                                                      FNC_NVL(oRow.GetCellValue(const_GrdFinanciamento_ValorEntrada), 0),
                                                                                      FNC_NVL(oRow.GetCellValue(const_GrdFinanciamento_Juros), 0) * 100 *
                                                                                      FNC_NVL(oRow.GetCellValue(const_GrdFinanciamento_QtdeParcela), 0)))
      oRow.SetCellValue(const_GrdFinanciamento_ValorParcela, FNC_NVL(oRow.GetCellValue(const_GrdFinanciamento_ValorRestanteComJuros), 0) /
                                                             FNC_NVL(oRow.GetCellValue(const_GrdFinanciamento_QtdeParcela), 0))
    Next
  End Sub

  Private Sub lblValorTotalProcedimento_TextChanged(sender As Object, e As EventArgs) Handles lblValorTotalProcedimento.TextChanged
    FinanciamentoCalcular()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String
    Dim iCont As Integer

    If psqPessoa.ID_Pessoa = 0 Then
      FNC_Mensagem("Informe a pessoa desse orçamento")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboConvenio) Then
      FNC_Mensagem("Selecione o convênio desse orçamento")
      Exit Sub
    End If
    If txtDataValidade.Value Is Nothing Then
      FNC_Mensagem("Informe a data de validade desse orçamento")
      Exit Sub
    Else
      If txtDataValidade.DateTime.Date < Now.Date Then
        FNC_Mensagem("A data de validade desse orçamento não pode ser menor que a data atual")
        Exit Sub
      End If
    End If
    If grdProcedimento.Rows.Count = 0 Then
      FNC_Mensagem("Informe pelo menos um procedimento para esse orçamento")
      Exit Sub
    End If
    For iCont = 0 To grdProcedimento.Rows.Count - 1
      If objGrid_Valor(grdProcedimento, const_GrdProcedimento_ID_PROFISSIONAL, iCont, 0) = 0 Then
        FNC_Mensagem("É preciso selecionar o médico/prestador de serviço de todos os procedimentos/exame listados")
        Exit Sub
      End If
    Next

    sSqlText = DBMontar_SP("SP_ORCAMENTO_CLIENTE_CAD", False, "@SQ_ORCAMENTO_CLIENTE OUT",
                                                              "@ID_EMPRESA",
                                                              "@ID_PESSOA",
                                                              "@ID_CONVENIO",
                                                              "@ID_FINANCIAMENTO",
                                                              "@ID_AGENDAMENTO",
                                                              "@CD_ORCAMENTO_CLIENTE OUT",
                                                              "@DH_ORCAMENTO_CLIENTE",
                                                              "@DT_VALIDADE")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_ORCAMENTO_CLIENTE", iSQ_ORCAMENTO_CLIENTE,, ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_PESSOA", psqPessoa.ID_Pessoa),
                            DBParametro_Montar("ID_CONVENIO", cboConvenio.SelectedValue),
                            DBParametro_Montar("ID_FINANCIAMENTO", cboFinanceiro.SelectedValue),
                            DBParametro_Montar("ID_AGENDAMENTO", FNC_NuloSe(iID_AGENDAMENTO, 0)),
                            DBParametro_Montar("CD_ORCAMENTO_CLIENTE", txtCodigo.Text,, ParameterDirection.Output),
                            DBParametro_Montar("DH_ORCAMENTO_CLIENTE", Now(), SqlDbType.DateTime),
                            DBParametro_Montar("DT_VALIDADE", txtDataValidade.DateTime.Date, SqlDbType.DateTime)) Then
      If DBTeveRetorno() And iSQ_ORCAMENTO_CLIENTE = 0 Then
        iSQ_ORCAMENTO_CLIENTE = Convert.ToInt32(DBRetorno(1))
        txtCodigo.Text = DBRetorno(2).ToString()
      End If

      sSqlText = "DELETE FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO WHERE ID_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE
      DBExecutar(sSqlText)

      For iCont = 0 To grdProcedimento.Rows.Count - 1
        With grdProcedimento.Rows(iCont)
          sSqlText = DBMontar_SP("SP_ORCAMENTO_CLIENTE_PROCEDIMENTO_CAD", False, "@SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO",
                                                                                 "@ID_ORCAMENTO_CLIENTE",
                                                                                 "@SQ_CLINICA_PROCEDIMENTO",
                                                                                 "@ID_PROCEDIMENTO",
                                                                                 "@ID_PESSOA_PROFISSIONAL",
                                                                                 "@VL_ORCADO")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO", 0),
                               DBParametro_Montar("ID_ORCAMENTO_CLIENTE", iSQ_ORCAMENTO_CLIENTE),
                               DBParametro_Montar("SQ_CLINICA_PROCEDIMENTO", FNC_NVL(.Cells(const_GrdProcedimento_SQ_CLINICA_PROCEDIMENTO).Value, 0)),
                               DBParametro_Montar("ID_PROCEDIMENTO", .Cells(const_GrdProcedimento_ID_PROCEDIMENTO).Value),
                               DBParametro_Montar("ID_PESSOA_PROFISSIONAL", .Cells(const_GrdProcedimento_ID_PROFISSIONAL).Value),
                               DBParametro_Montar("VL_ORCADO", .Cells(const_GrdProcedimento_Valor).Value, SqlDbType.Money))
        End With
      Next

      cmdSolicitacaoExamesPendentes.Visible = False

      cmdGravar.Enabled = False

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub grdProcedimento_ClickCell(sender As Object, e As UltraWinGrid.ClickCellEventArgs) Handles grdProcedimento.ClickCell
    CarregarProfissional(FNC_NuloZero(e.Cell.Row.Cells(const_GrdProcedimento_ID_PROCEDIMENTO).Value, False),
                         FNC_NuloZero(e.Cell.Row.Cells(const_GrdProcedimento_ID_CONVENIO).Value, False))
  End Sub

  Private Sub CarregarProfissional(iID_PROCEDIMENTO As Integer, iID_CONVENIO As Integer)
    Dim sSqlText As String

    oDBGridProfissional.Rows.Clear()

    sSqlText = "SELECT ID_PESSOA_PROFISSIONAL," &
                      iID_PROCEDIMENTO & "," &
                      "NO_PESSOA," &
                      "VL_PROCEDIMENTO," &
                      "IIF(ISNULL(IC_PADRAO, 'N') = 'S', 'Sim', 'Não')" &
                 " FROM VW_CONVENIO_PROCEDIMENTO" &
                 " WHERE IC_ATIVO = 'S'" &
                   " AND ID_PROCEDIMENTO = " & iID_PROCEDIMENTO &
                   " AND ID_CONVENIO = " & iID_CONVENIO &
               " ORDER BY IC_PADRAO DESC"
    objGrid_Carregar(grdProfissional, sSqlText, New Integer() {const_GridProfissional_ID_PESSOA_PROFISSIONAL,
                                                               const_GridProfissional_ID_PROCEDIMENTO,
                                                               const_GridProfissional_NO_PESSOA,
                                                               const_GridProfissional_VL_PROCEDIMENTO,
                                                               const_GridProfissional_PADRAO})
  End Sub

  Private Sub cmdAdicionarProduto_Click(sender As Object, e As EventArgs) Handles cmdAdicionarProduto.Click
    Dim iCont As Integer

    If psqProcedimento.Identificador = 0 Then
      FNC_Mensagem("Informe o exame/procedimento informado")
    Else
      For iCont = 0 To grdProcedimento.Rows.Count - 1
        If objGrid_Valor(grdProcedimento, const_GrdProcedimento_ID_PROCEDIMENTO, iCont, 0) = psqProcedimento.Identificador Then
          FNC_Mensagem("Exame/procedimento já adicionado")
          Exit Sub
        End If
      Next
    End If

    Dim oRow As UltraWinDataSource.UltraDataRow

    oRow = objGrid_Linha_Add(grdProcedimento, New Object() {const_GrdProcedimento_ID_PROCEDIMENTO, psqProcedimento.Identificador,
                                                            const_GrdProcedimento_DescricaoProcedimentoExame, psqProcedimento.Nome,
                                                            const_GrdProcedimento_ID_CONVENIO, FNC_NVL(cboConvenio.SelectedValue, 0)})

    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT CVPRD.VL_PROCEDIMENTO," &
                      "CVPRD.ID_PESSOA_PROFISSIONAL," &
                      "PSPRF.NO_PESSOA NO_PESSOA_PROFISSIONAL" &
               " FROM TB_CONVENIO_PROCEDIMENTO CVPRD" &
                 " INNER JOIN TB_PESSOA PSPRF ON PSPRF.SQ_PESSOA = CVPRD.ID_PESSOA_PROFISSIONAL" &
               " WHERE IC_PADRAO = 'S'" &
                 " AND ID_PROCEDIMENTO = " & psqProcedimento.Identificador &
                 " AND ID_CONVENIO = " & FNC_NVL(cboConvenio.SelectedValue, 0)
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      oRow.SetCellValue(const_GrdProcedimento_ID_PROFISSIONAL, oData.Rows(0).Item("ID_PESSOA_PROFISSIONAL"))
      oRow.SetCellValue(const_GrdProcedimento_MedicoPrestadorServico, oData.Rows(0).Item("NO_PESSOA_PROFISSIONAL"))
      oRow.SetCellValue(const_GrdProcedimento_Valor, oData.Rows(0).Item("VL_PROCEDIMENTO"))
    End If

    oData.Dispose()

    objGrid_Posicionar(grdProcedimento, New Integer() {const_GrdProcedimento_ID_PROCEDIMENTO}, New Object() {psqProcedimento.Identificador})

    psqProcedimento.Limpar()
    CalcularTotalProcedimento()
  End Sub

  Private Sub grdProfissional_ClickCellButton(sender As Object, e As CellEventArgs) Handles grdProfissional.ClickCellButton
    Dim iCont As Integer

    For iCont = 0 To grdProcedimento.Rows.Count - 1
      If objGrid_Valor(grdProcedimento, const_GrdProcedimento_ID_PROCEDIMENTO, iCont) = e.Cell.Row.Cells(const_GridProfissional_ID_PROCEDIMENTO).Value Then
        grdProcedimento.Rows(iCont).Activate()
      End If
    Next


    Try
      With grdProcedimento.DisplayLayout.ActiveRow
        .Cells(const_GrdProcedimento_ID_PROFISSIONAL).Value = e.Cell.Row.Cells(const_GridProfissional_ID_PESSOA_PROFISSIONAL).Value
        .Cells(const_GrdProcedimento_MedicoPrestadorServico).Value = e.Cell.Row.Cells(const_GridProfissional_NO_PESSOA).Value
        .Cells(const_GrdProcedimento_Valor).Value = e.Cell.Row.Cells(const_GridProfissional_VL_PROCEDIMENTO).Value
        CalcularTotalProcedimento()
      End With
    Catch ex As Exception
    End Try
  End Sub

  Private Sub cmdSolicitacaoExamesPendentes_Click(sender As Object, e As EventArgs) Handles cmdSolicitacaoExamesPendentes.Click
    Dim sSqlText As String

    sSqlText = "SELECT   CPP.ID_PROCEDIMENTO," &
                        "CPP.NO_PROCEDIMENTO," &
                        "CPP.SQ_CLINICA_PROCEDIMENTO," &
                      "CNVPC.ID_PESSOA_PROFISSIONAL," &
                      "CNVPC.NO_PESSOA," &
                      "CNVPC.VL_PROCEDIMENTO," &
                        "CPP.DH_CLINICA_ATENDIMENTO," &
                        "CPP.NO_PESSOA_PROFISSIONAL," &
                        "CPP.ID_CONVENIO" &
               " FROM VW_CLINICA_PROCEDIMENTO_PENDENTE CPP" &
                " LEFT JOIN VW_CONVENIO_PROCEDIMENTO CNVPC ON CNVPC.ID_PROCEDIMENTO = CPP.ID_PROCEDIMENTO" &
                                                        " AND CNVPC.ID_CONVENIO = " & FNC_NVL(cboConvenio.SelectedValue, 0) &
                                                        " AND CNVPC.IC_ATIVO = 'S'" &
                                                        " AND CNVPC.IC_PADRAO = 'S'" &
               " WHERE CPP.ID_PESSOA = " & psqPessoa.ID_Pessoa &
               " ORDER BY CPP.NO_PROCEDIMENTO"
    objGrid_Carregar(grdProcedimento, sSqlText, New Integer() {const_GrdProcedimento_ID_PROCEDIMENTO,
                                                               const_GrdProcedimento_DescricaoProcedimentoExame,
                                                               const_GrdProcedimento_SQ_CLINICA_PROCEDIMENTO,
                                                               const_GrdProcedimento_ID_PROFISSIONAL,
                                                               const_GrdProcedimento_MedicoPrestadorServico,
                                                               const_GrdProcedimento_Valor,
                                                               const_GrdProcedimento_Data,
                                                               const_GrdProcedimento_Solicitante,
                                                               const_GrdProcedimento_ID_CONVENIO})
  End Sub

  Private Sub SolicitacaoExamesPendentes_Verificar()
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*)" &
               " FROM VW_CLINICA_PROCEDIMENTO_PENDENTE" &
               " WHERE ID_PESSOA = " & psqPessoa.ID_Pessoa &
                 " AND ID_OPT_STATUS = " & enOpcoes.StatusExameSolicitado_Solicitado.GetHashCode()
    cmdSolicitacaoExamesPendentes.Visible = (DBQuery_ValorUnico(sSqlText) > 0)
  End Sub

  Private Sub psqPessoa_SelectedIndexChanged() Handles psqPessoa.SelectedIndexChanged
    SolicitacaoExamesPendentes_Verificar()
  End Sub

  Private Sub grdProcedimento_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdProcedimento.BeforeRowsDeleted
    e.DisplayPromptMsg = False

    If Not FNC_Perguntar("Deseja excluir o procedimento/exame " & e.Rows(0).Cells(const_GrdProcedimento_DescricaoProcedimentoExame).Value) Then
      e.Cancel = True
    End If
  End Sub

  Private Sub grdProcedimento_AfterRowsDeleted(sender As Object, e As EventArgs) Handles grdProcedimento.AfterRowsDeleted
    CalcularTotalProcedimento()
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If iSQ_ORCAMENTO_CLIENTE <= 0 Then
      FNC_Mensagem("Grave o orçamento antes de tentar imprimir")
      Exit Sub
    End If

    FormRelatorioOrcamentoProcedimentos(iSQ_ORCAMENTO_CLIENTE)
  End Sub
End Class