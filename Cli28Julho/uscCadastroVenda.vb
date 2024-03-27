Imports Cli28Julho.modDeclaracaoLocal
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class uscCadastroVenda
  Public Event GravacaoEfetuada()
  Public Event Fechar()

  Const const_ComboVendaPendente_NR_ITEM As Integer = 0
  Const const_ComboVendaPendente_CD_ITEM As Integer = 1
  Const const_ComboVendaPendente_SQ_ITEM As Integer = 2
  Const const_ComboVendaPendente_ID_CONVENIO As Integer = 3

  Const const_GridListagem_ID_PROCEDIMENTO As Integer = 0
  Const const_GridListagem_ID_PESSOA_PROFISSIONAL As Integer = 1
  Const const_GridListagem_ProfissionalPrestadorServico As Integer = 2
  Const const_GridListagem_Procedimento As Integer = 3
  Const const_GridListagem_Desconto As Integer = 4
  Const const_GridListagem_Valor As Integer = 5
  Const const_GridListagem_QT_DIAS_REPASSE As Integer = 6
  Const const_GridListagem_SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO As Integer = 7
  Const const_GridListagem_SQ_AGENDAMENTO As Integer = 8
  Const const_GridListagem_SQ_CLINICA_PROCEDIMENTO As Integer = 9
  Const const_GridListagem_VL_REPASSE As Integer = 10
  Const const_GridListagem_BNT_Agendamento As Integer = 11
  Const const_GridListagem_BNT_Pessoa As Integer = 12
  Const const_GridListagem_DH_NovoAgendamento As Integer = 13
  Const const_GridListagem_Pessoa_Agendamento As Integer = 14
  Const const_GridListagem_Especialidade As Integer = 15
  Const const_GridListagem_ExigeExameCitologico As Integer = 16
  Const const_GridListagem_BNT_ExameCitologico As Integer = 17
  Const const_GridListagem_IC_PROFISSIONAL_SERVICO_INTERNO As Integer = 18
  Const const_GridListagem_ID_EMPRESA As Integer = 19
  Const const_GridListagem_ID_PESSOA_AGENDAMENTO As Integer = 20
  Const const_GridListagem_DH_AgendamentoPendente As Integer = 21
  Const const_GridListagem_ID_PESSOA_HORARIO As Integer = 22
  Const const_GridListagem_IntegracaoSisVida As Integer = 23
  Const const_GridListagem_CodigoIntegracaoProcedimentoExame As Integer = 24
  Const const_GridListagem_DescricaoIntegracaoProcedimentoExame As Integer = 25
  Const const_GridListagem_CodigoIntegracaoProcedimentoMaterial As Integer = 26
  Const const_GridListagem_DescricaoIntegracaoProcedimentoMaterial As Integer = 27
  Const const_GridListagem_CodigoProcedimento As Integer = 28
  Const const_GridListagem_Solicitante As Integer = 29
  Const const_GridListagem_BNT_Solicitante As Integer = 30
  Const const_GridListagem_ID_Solicitante As Integer = 31
  Const const_GridListagem_SQ_VENDA_CLINICA_PROCEDIMENTO As Integer = 32

  Public iSQ_CLINICA_VENDA As Integer
  Public iID_PESSOA As Integer
  Public iID_ATENDIMENTO As Integer
  Public oID_AGENDAMENTO As New Collection
  Public iID_ORCAMENTO_CLIENTE As Integer
  Public iID_CLINICA_ATENDIMENTO As Integer

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Dim bEmpProcessamento As Boolean

  Dim dDescontoMaximo As Double
  Dim dDescontoMaximoSupervisor As Double
  Dim iPessoaLiberacaoDesconto As Double
  Dim sIdentificador As String

  Dim iLinhaEdicao As Integer = -1

  Dim DT_PACIENTE_NOME As String
  Dim DT_PACIENTE_NASCIMENTO As String
  Dim TP_PACIENTE_MASCULINO As String
  Dim CD_PACIENTE_CPF As String
  Dim CD_PACIENTE_TELEFONE As String
  Dim DS_PACIENTE_ENDERECO As String
  Dim DS_PACIENTE_ENDERECO_CIDADE As String
  Dim CD_PACIENTE_ENDERECO_UF As String

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    RaiseEvent Fechar()
  End Sub

  Public Sub Formatar()
    ComboBox_Carregar(cboConvenio, enSql.Convenio_Ativo)
    ComboBox_Selecionar(cboConvenio, iEMPRESA_ID_CONVENIO_PADRAO)
    ComboBox_Carregar(cboContaFinanceira, enSql.ContaCaixa, New Object() {iID_USUARIO})
    ComboBox_Carregar(cboCanalMarcacao, enSql.CanalMarcacao)

    If cboContaFinanceira.Items.Count = 1 Then
      cboContaFinanceira.SelectedIndex = 0
    End If

    psqProcedimento.Convenio = -1
    txtDataVenda.Value = Now()

    lblQuantidade.Text = "0"
    lblValorTotalProcedimento.Text = "R$ 0,00"
    lblValorTotalDesconto.Text = "R$ 0,00"
    lblSaldoConvenio.Text = ""
    lblSaldoConvenio.Visible = False

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "ID_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdListagem, "Médico/Prestador de Serviços", 350)
    objGrid_Coluna_Add(grdListagem, "Nome do Prodecimeno", 350)
    objGrid_Coluna_Add(grdListagem, "Valor do Desconto", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Valor do Procedimento", 150, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "QT_DIAS_REPASSE", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_AGENDAMENTO", 0) '''
    objGrid_Coluna_Add(grdListagem, "SQ_CLINICA_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "VL_REPASSE", 0)
    objGrid_Coluna_Add(grdListagem, "Agend.", 50, , , ColumnStyle.Button)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 50, , , ColumnStyle.Button)
    objGrid_Coluna_Add(grdListagem, "D/H Agendamento", 150)
    objGrid_Coluna_Add(grdListagem, "Pessoa Agendamento", 300)
    objGrid_Coluna_Add(grdListagem, "Especialidade", 150, , True)
    objGrid_Coluna_Add(grdListagem, "Exige Exame Citológico", 150)
    objGrid_Coluna_Add(grdListagem, "Ex. Citol.", 100, , , ColumnStyle.Button)
    objGrid_Coluna_Add(grdListagem, "IC_PROFISSIONAL_SERVICO_INTERNO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_EMPRESA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_AGENDAMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "D/H Agendamento Pendente", 150, ,,,, const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_HORARIO", 0)
    objGrid_Coluna_Add(grdListagem, "IntegracaoSisVida", 0)
    objGrid_Coluna_Add(grdListagem, "CodigoIntegracaoProcedimentoExame", 0)
    objGrid_Coluna_Add(grdListagem, "DescricaoIntegracaoProcedimentoExame", 0)
    objGrid_Coluna_Add(grdListagem, "CodigoIntegracaoProcedimentoMaterial", 0)
    objGrid_Coluna_Add(grdListagem, "DescricaoIntegracaoProcedimentoMaterial", 0)
    objGrid_Coluna_Add(grdListagem, "CodigoProcedimento", 0)
    objGrid_Coluna_Add(grdListagem, "Solicitante", 300)
    objGrid_Coluna_Add(grdListagem, "Solicitante", 50, , , ColumnStyle.Button)
    objGrid_Coluna_Add(grdListagem, "ID_Solicitante", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_VENDA_CLINICA_PROCEDIMENTO", 0)

    If iID_PESSOA > 0 Then
      psqPessoa.ID_Pessoa = iID_PESSOA

      If oID_AGENDAMENTO.Count <> 0 Or iID_ORCAMENTO_CLIENTE <> 0 Then
        If cboVendaPendente.Items.Count = 0 Then
          ComboBox_VendaPendente_Carregar()
        End If

        If oID_AGENDAMENTO.Count > 0 Then
          ComboVendaPendente_Poscionar(enOrigemVenda.Agendamento.GetHashCode(), oID_AGENDAMENTO)
        End If
        If iID_ORCAMENTO_CLIENTE > 0 Then
          ComboVendaPendente_Poscionar(enOrigemVenda.OrcamentoClinica.GetHashCode(), iID_ORCAMENTO_CLIENTE)
        End If
      End If
    End If

    If Not oID_AGENDAMENTO Is Nothing Then
      If oID_AGENDAMENTO.Count <> 0 Then
        ValidarAlteracaoConvenio()
      End If
    End If

    If iSQ_CLINICA_VENDA > 0 Then
      Dim sSqlText As String
      Dim oData As DataTable

      sSqlText = "SELECT * FROM TB_CLINICA_VENDA WHERE SQ_CLINICA_VENDA = " & iSQ_CLINICA_VENDA
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        With oData.Rows(0)
          txtCodigoVenda.Text = .Item("CD_CLINICA_VENDA")
          ComboBox_Selecionar(cboContaFinanceira, .Item("ID_CONTAFINANCEIRA"))
          psqPessoa.ID_Pessoa = .Item("ID_PESSOA")
          ComboBox_Selecionar(cboConvenio, .Item("ID_CONVENIO"))
          ComboBox_CarregarIndicador(cboIndicador, psqPessoa.ID_Pessoa)
          ComboBox_Selecionar(cboIndicador, .Item("ID_PESSOAINDICADOR"))
          ComboBox_Selecionar(cboCanalMarcacao, .Item("ID_CANALMARCACAO"))
          txtDataVenda.DateTime = .Item("DH_VENDA")
        End With
      End If
    End If

    ValidarAlteracaoConvenio()
  End Sub

  Private Sub cboConvenio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboConvenio.SelectedIndexChanged
    ValidarAlteracaoConvenio()
    Convenio_AtualizarCredito()

    Dim iCont As Integer
    Dim oData As DataTable
    Dim sSqlText As String

    For iCont = 0 To grdListagem.Rows.Count - 1
      sSqlText = "SELECT VL_PROCEDIMENTO, VL_REPASSE FROM TB_CONVENIO_PROCEDIMENTO" &
                 " WHERE ID_CONVENIO = " & FNC_NVL(cboConvenio.SelectedValue, 0) &
                   " AND ID_PROCEDIMENTO = " & objGrid_Valor(grdListagem, const_GridListagem_ID_PROCEDIMENTO, iCont) &
                   " AND ID_PESSOA_PROFISSIONAL = " & objGrid_Valor(grdListagem, const_GridListagem_ID_PESSOA_PROFISSIONAL, iCont)
      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        grdListagem.Rows(iCont).Cells(const_GridListagem_Valor).Value = 0
        grdListagem.Rows(iCont).Cells(const_GridListagem_VL_REPASSE).Value = 0
      Else
        grdListagem.Rows(iCont).Cells(const_GridListagem_Valor).Value = FNC_NVL(oData.Rows(0).Item("VL_PROCEDIMENTO"), 0)
        grdListagem.Rows(iCont).Cells(const_GridListagem_VL_REPASSE).Value = FNC_NVL(oData.Rows(0).Item("VL_REPASSE"), 0)
      End If
    Next

    If Not oData Is Nothing Then oData.Dispose()

    CalcularProcedimento()
  End Sub

  Private Sub ValidarAlteracaoConvenio()
    If ComboBox_Selecionado(cboConvenio) Then
      psqProcedimento.Convenio = cboConvenio.SelectedValue
    Else
      psqProcedimento.Convenio = -1
    End If

    CarregarPessoaProfissionalFornecedorConvenioProcedimento()

    'If FNC_NVL(cboConvenio.Tag, 0) <> FNC_NVL(cboConvenio.SelectedValue, 0) And cboConvenio.Enabled Then oDBGrid.Rows.Clear()

    cboConvenio.Tag = cboConvenio.SelectedValue
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If psqPessoa.ID_Pessoa = 0 Then
      FNC_Mensagem("Informe o cliente")
      Exit Sub
    End If
    If Not txtDataVenda.IsDateValid Then
      FNC_Mensagem("Informe a data da venda")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboConvenio) Then
      FNC_Mensagem("Selecione o convênio")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboContaFinanceira) Then
      FNC_Mensagem("Selecione a conta caixa")
      Exit Sub
    End If
    If grdListagem.Rows.Count = 0 Then
      FNC_Mensagem("Informe pelo menos um procedimento para a venda")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboCanalMarcacao) Then
      FNC_Mensagem("Selecione a canal de marcação")
      Exit Sub
    End If
    If Not CadastroClienteValido(psqPessoa.ID_Pessoa) Then
      FNC_Mensagem("O cadastro desse cliente está incompleto, favor corrigir")
      Exit Sub
    End If

    For Each oRow As UltraGridRow In grdListagem.Rows
      If FNC_NVL(oRow.Cells(const_GridListagem_Valor).Value, 0) = 0 Then
        FNC_Mensagem("Favor informar o valor para todos os procedimentos/exames")
        Exit Sub
      End If
      If FNC_NVL(oRow.Cells(const_GridListagem_SQ_AGENDAMENTO).Value, 0) = 0 And
         FNC_NVL(oRow.Cells(const_GridListagem_IC_PROFISSIONAL_SERVICO_INTERNO).Value, "N") = "S" And
         Not IsDate(FNC_NVL(oRow.Cells(const_GridListagem_DH_NovoAgendamento).Value, 0)) Then
        FNC_Mensagem("Favor informar a data de agendamento de todos os prestadores de serviços internos")
        Exit Sub
      End If
      If oRow.Cells(const_GridListagem_ExigeExameCitologico).Value = "S" And
         oRow.Cells(const_GridListagem_BNT_ExameCitologico).Tag Is Nothing Then
        FNC_Mensagem("Favor informar os dados de todas as vendas que Exige Exame Citológico")
        Exit Sub
      End If
      If IsDate(oRow.Cells(const_GridListagem_DH_AgendamentoPendente).Value) Then
        If FNC_Pessoa_Horario_Bloqueio_Data(oRow.Cells(const_GridListagem_ID_PESSOA_PROFISSIONAL).Value, oRow.Cells(const_GridListagem_DH_AgendamentoPendente).Value) Then
          FNC_Mensagem("A agenda do profissional " + oRow.Cells(const_GridListagem_ProfissionalPrestadorServico).Value + "  está bloqueada")
          Exit Sub
        End If
      End If
      If FNC_NVL(oRow.Cells(const_GridListagem_IntegracaoSisVida).Value, "N") = "S" And
         FNC_NVL(oRow.Cells(const_GridListagem_Solicitante).Value, "") = "" Then
        FNC_Mensagem("É preciso informa o profissional solicitante do procedimento " + oRow.Cells(const_GridListagem_Procedimento).Value + ", do prestador " + oRow.Cells(const_GridListagem_ProfissionalPrestadorServico).Value)
        Exit Sub
      End If
    Next

    Dim oLancaContasReceberPagar_Venda As clsLancaContasReceberPagar_Venda()

    Dim dValorDesconto As Double
    Dim oForm As New frmLancaContasReceberPagar_Venda

    oForm.dVoucher = oVoucher.ValorEmVoucher(lblValorTotalProcedimento.Tag - objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_Desconto, grdTipoCalculoTotal.SomarValor))
    oForm.DescontoMaximo = dDescontoMaximo
    oForm.dValorTotal = lblValorTotalProcedimento.Tag
    oForm.txtValorDesconto.Value = objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_Desconto, grdTipoCalculoTotal.SomarValor)

    FNC_AbriTela(oForm, , True, True)

    iPessoaLiberacaoDesconto = oForm.iPessoaLiberacaoDesconto
    dDescontoMaximo = oForm.DescontoMaximo
    dDescontoMaximoSupervisor = oForm.DescontoMaximoSupervisor
    dValorDesconto = oForm.ValorDesconto

    oLancaContasReceberPagar_Venda = oForm.oLancaContasReceberPagar_Venda

    If oLancaContasReceberPagar_Venda Is Nothing And oForm.dVoucher = 0 Then
      FNC_Mensagem("É preciso informar as formas de pagamentos")
      Exit Sub
    Else
      If oLancaContasReceberPagar_Venda.Count = 0 And oForm.dVoucher = 0 Then
        FNC_Mensagem("É preciso informar as formas de pagamentos")
        Exit Sub
      End If
    End If

    cmdGravar.Enabled = False

    Dim sSqlText As String
    Dim iCont01 As Integer
    Dim iSQ_AGENDAMENTO As Integer
    Dim iSQ_CLINICA_VENDA_PROCEDIMENTO As Integer
    Dim iID_TIPO_CONSULTA_VENDA As Integer
    Dim oSolicitacaoExameCitologico As modDeclaracaoLocal.cSolicitacaoExameCitologico

    sSqlText = DBMontar_SP("SP_CLINICA_VENDA_CAD", False, "@SQ_CLINICA_VENDA OUT",
                                                          "@CD_CLINICA_VENDA OUT",
                                                          "@ID_EMPRESA",
                                                          "@ID_CONTAFINANCEIRA",
                                                          "@ID_PESSOA",
                                                          "@ID_CONVENIO",
                                                          "@ID_ATENDIMENTO",
                                                          "@ID_ORCAMENTO_CLIENTE",
                                                          "@ID_INDICACAO",
                                                          "@ID_PESSOA_LIBERACAO_DESCONTO",
                                                          "@ID_PESSOA_ATENDENTE",
                                                          "@ID_PESSOAINDICADOR",
                                                          "@ID_CANALMARCACAO",
                                                          "@DH_VENDA",
                                                          "@DS_SOLICITANTE",
                                                          "@PC_DESCONTO_MAXIMO",
                                                          "@PC_DESCONTO_MAXIMO_SUPERVISOR",
                                                          "@VL_VOUCHER",
                                                          "@VL_DESCONTO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA", iSQ_CLINICA_VENDA,, ParameterDirection.InputOutput),
                            DBParametro_Montar("CD_CLINICA_VENDA", Nothing,, ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_CONTAFINANCEIRA", cboContaFinanceira.SelectedValue),
                            DBParametro_Montar("ID_PESSOA", psqPessoa.ID_Pessoa),
                            DBParametro_Montar("ID_CONVENIO", cboConvenio.SelectedValue),
                            DBParametro_Montar("ID_ATENDIMENTO", FNC_NuloSe(iID_ATENDIMENTO, 0)),
                            DBParametro_Montar("ID_ORCAMENTO_CLIENTE", FNC_NuloSe(iID_ORCAMENTO_CLIENTE, 0)),
                            DBParametro_Montar("ID_INDICACAO", Nothing),
                            DBParametro_Montar("ID_PESSOA_LIBERACAO_DESCONTO", FNC_NuloSe(iPessoaLiberacaoDesconto, 0)),
                            DBParametro_Montar("ID_PESSOA_ATENDENTE", FNC_NuloSe(iID_USUARIO, 0)),
                            DBParametro_Montar("ID_PESSOAINDICADOR", cboIndicador.SelectedValue),
                            DBParametro_Montar("ID_CANALMARCACAO", cboCanalMarcacao.SelectedValue),
                            DBParametro_Montar("DH_VENDA", txtDataVenda.DateTime, SqlDbType.DateTime),
                            DBParametro_Montar("DS_SOLICITANTE", Nothing),
                            DBParametro_Montar("PC_DESCONTO_MAXIMO", dDescontoMaximo),
                            DBParametro_Montar("PC_DESCONTO_MAXIMO_SUPERVISOR", dDescontoMaximoSupervisor),
                            DBParametro_Montar("VL_VOUCHER", oForm.dVoucher),
                            DBParametro_Montar("VL_DESCONTO", oForm.txtValorDescontoSupervisor.Value)) Then
      If DBTeveRetorno() And iSQ_CLINICA_VENDA = 0 Then
        iSQ_CLINICA_VENDA = Convert.ToInt32(DBRetorno(1))
        txtCodigoVenda.Text = DBRetorno(2)
      End If

      sSqlText = "DELETE FROM TB_CLINICA_VENDA_PROCEDIMENTO WHERE ID_CLINICA_VENDA = " & iSQ_CLINICA_VENDA
      DBExecutar(sSqlText)

      For iCont01 = 0 To grdListagem.Rows.Count - 1
        With grdListagem.Rows(iCont01)
          sSqlText = DBMontar_SP("SP_CLINICA_VENDA_PROCEDIMENTO_CAD", False, "@SQ_CLINICA_VENDA_PROCEDIMENTO OUT",
                                                                             "@ID_CLINICA_VENDA",
                                                                             "@ID_PROCEDIMENTO",
                                                                             "@ID_PESSOA_PROFISSIONAL",
                                                                             "@ID_ORCAMENTO_CLIENTE_PROCEDIMENTO",
                                                                             "@ID_CLINICA_PROCEDIMENTO",
                                                                             "@ID_AGENDAMENTO",
                                                                             "@VL_PROCEDIMENTO",
                                                                             "@VL_REPASSE",
                                                                             "@VL_DESCONTO",
                                                                             "@DT_PREVISAO_FATURAMENTO",
                                                                             "@DS_SOLICITANTE",
                                                                             "@ID_PESSOA_PROFISSIONAL_SOLICITANTE")
          DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_VENDA_PROCEDIMENTO", 0, , ParameterDirection.InputOutput),
                               DBParametro_Montar("ID_CLINICA_VENDA", iSQ_CLINICA_VENDA),
                               DBParametro_Montar("ID_PROCEDIMENTO", .Cells(const_GridListagem_ID_PROCEDIMENTO).Value),
                               DBParametro_Montar("ID_PESSOA_PROFISSIONAL", .Cells(const_GridListagem_ID_PESSOA_PROFISSIONAL).Value),
                               DBParametro_Montar("ID_ORCAMENTO_CLIENTE_PROCEDIMENTO", .Cells(const_GridListagem_SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO).Value),
                               DBParametro_Montar("ID_CLINICA_PROCEDIMENTO", .Cells(const_GridListagem_SQ_CLINICA_PROCEDIMENTO).Value),
                               DBParametro_Montar("ID_AGENDAMENTO", .Cells(const_GridListagem_SQ_AGENDAMENTO).Value),
                               DBParametro_Montar("VL_PROCEDIMENTO", .Cells(const_GridListagem_Valor).Value),
                               DBParametro_Montar("VL_REPASSE", CDbl(FNC_NVL(.Cells(const_GridListagem_VL_REPASSE).Value, 0))),
                               DBParametro_Montar("VL_DESCONTO", CDbl(FNC_NVL(.Cells(const_GridListagem_Desconto).Value, 0)), SqlDbType.Money),
                               DBParametro_Montar("DT_PREVISAO_FATURAMENTO", txtDataVenda.DateTime.AddDays(FNC_NuloZero(.Cells(const_GridListagem_QT_DIAS_REPASSE).Value, False)), SqlDbType.DateTime),
                               DBParametro_Montar("DS_SOLICITANTE", .Cells(const_GridListagem_Solicitante).Value),
                               DBParametro_Montar("ID_PESSOA_PROFISSIONAL_SOLICITANTE", .Cells(const_GridListagem_ID_Solicitante).Value))

          iSQ_CLINICA_VENDA_PROCEDIMENTO = DBRetorno(1)

          .Cells(const_GridListagem_SQ_VENDA_CLINICA_PROCEDIMENTO).Value = iSQ_CLINICA_VENDA_PROCEDIMENTO

          iSQ_AGENDAMENTO = 0

          If IsDate(.Cells(const_GridListagem_DH_NovoAgendamento).Value) Then
            sSqlText = "SELECT TPCST.SQ_TIPO_CONSULTA" &
                       " FROM TB_PROCEDIMENTO PROCE" &
                        " INNER JOIN TB_TIPO_CONSULTA TPCST ON TPCST.ID_OPT_TIPOPROCEDIMENTO = PROCE.ID_OPT_TIPOPROCEDIMENTO" &
                        " WHERE PROCE.SQ_PROCEDIMENTO = " & .Cells(const_GridListagem_ID_PROCEDIMENTO).Value
            iID_TIPO_CONSULTA_VENDA = DBQuery_ValorUnicoInt(sSqlText, iEMPRESA_ID_TIPO_CONSULTA_VENDA)
            FormCadastroAgendamento_Gravar(iSQ_AGENDAMENTO,
                                           Nothing,
                                           .Cells(const_GridListagem_ID_EMPRESA).Value,
                                           iID_TIPO_CONSULTA_VENDA,
                                           FNC_NVL(.Cells(const_GridListagem_ID_PESSOA_AGENDAMENTO).Value, psqPessoa.ID_Pessoa),
                                           .Cells(const_GridListagem_ID_PESSOA_PROFISSIONAL).Value,
                                           Nothing,
                                           .Cells(const_GridListagem_Especialidade).Value,
                                           cboConvenio.SelectedValue,
                                           .Cells(const_GridListagem_ID_PROCEDIMENTO).Value,
                                           cboIndicador.SelectedValue,
                                           enOpcoes.StatusAgendamento_AguardandoAtendimento,
                                           cboCanalMarcacao.SelectedValue,
                                           .Cells(const_GridListagem_DH_NovoAgendamento).Value,
                                           Nothing,
                                           Nothing,
                                           Nothing,
                                           Nothing,
                                           Nothing,
                                           Nothing,
                                           .Cells(const_GridListagem_Valor).Value,
                                           FNC_NVL(.Cells(const_GridListagem_ID_PESSOA_HORARIO).Value, 0))

            sSqlText = "UPDATE TB_AGENDAMENTO SET ID_CLINICA_VENDA_PROCEDIMENTO = " & iSQ_CLINICA_VENDA_PROCEDIMENTO.ToString() &
                       " WHERE SQ_AGENDAMENTO = " & iSQ_AGENDAMENTO
            DBExecutar(sSqlText)
          ElseIf .Cells(const_GridListagem_ExigeExameCitologico).Value = "S" Then
            oSolicitacaoExameCitologico = .Cells(const_GridListagem_BNT_ExameCitologico).Tag
            FormCadastroAtendimentoSolicitacaoExameCitologico(0,
                                                              0,
                                                              iSQ_CLINICA_VENDA,
                                                              oSolicitacaoExameCitologico.sDS_MEDICO_EXTERNO,
                                                              oSolicitacaoExameCitologico.sDS_COLETA,
                                                              oSolicitacaoExameCitologico.sDS_UM,
                                                              oSolicitacaoExameCitologico.sDS_FILHOS,
                                                              oSolicitacaoExameCitologico.sDS_ABORTO,
                                                              oSolicitacaoExameCitologico.sDS_PARA,
                                                              oSolicitacaoExameCitologico.sDS_LOCAL_COLETA,
                                                              oSolicitacaoExameCitologico.sDS_ACHADOS_COLPOSCOPICOS,
                                                              oSolicitacaoExameCitologico.sIC_DIU)
          End If
        End With
      Next

      Dim iSQ_MOVFINANCEIRA As Integer

      FormCadastroMovimentacaoFinanceira(iSQ_MOVFINANCEIRA,
                                         enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber,
                                         enOpcoes.StatusMovimentacaoFinanceira_Aberta,
                                         enOpcoes.PeriodoCalculoFinanceiro_AoMes,
                                         enOpcoes.PeriodoCalculoFinanceiro_AoMes,
                                         psqPessoa.ID_Pessoa,
                                         cboContaFinanceira.SelectedValue, 0, 0, 0, 0, 0, 0, iSQ_CLINICA_VENDA, 0, "VENDA DE EXAME/PROCEDIMENTO CÓD " + txtCodigoVenda.Text,
                                         lblValorTotalProcedimento.Tag, lblValorTotalProcedimento.Tag, dValorDesconto, DateTime.Now, DateTime.Now, 0, 0, 0, 0, 0, Nothing)

      If Not oLancaContasReceberPagar_Venda Is Nothing Then
        For Each Item As clsLancaContasReceberPagar_Venda In oLancaContasReceberPagar_Venda
          iCont01 = iCont01 + 1

          FormCadastroMovimentacaoFinanceiraParcela(0, iSQ_MOVFINANCEIRA, enOpcoes.StatusMovimentacaoFinanceira_EmVenda.GetHashCode(),
                                                    Item.ID_TIPODOCUMENTO, 0, Item.ID_DOCUMENTOFINANCEIRO, Item.ID_FORMAPAGAMETO,
                                                    Item.ID_CONDICAOPAGAMENTO, Item.CodigoParcela, Item.CodigoDocumento, Item.DescricaoDocumento,
                                                    Nothing, Item.DataVencimento, Nothing, Item.ValorParcela, 0, 0, 0, 0, Item.TaxaCompensacao, 0)
        Next
      End If

      sSqlText = DBMontar_SP("SP_CLINICA_VENDA_MOVFINANCEIRA_PLNCONTAS_CAD", False, "@ID_MOVFINANCEIRA",
                                                                                    "@ID_CLINICA_VENDA")

      DBExecutar(sSqlText, DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                           DBParametro_Montar("ID_CLINICA_VENDA", iSQ_CLINICA_VENDA))

      sSqlText = DBMontar_SP("SP_CLINICA_VENDA_MOVFINANCEIRA_PAGAR_CAD", False, "@ID_CLINICA_VENDA",
                                                                                "@DS_MOVFINANCEIRA",
                                                                                "@ID_USUARIO")

      DBExecutar(sSqlText, DBParametro_Montar("ID_CLINICA_VENDA", iSQ_CLINICA_VENDA),
                           DBParametro_Montar("DS_MOVFINANCEIRA", "Repasse para o Profissional Ref a " + psqPessoa.cboPessoa.Text),
                           DBParametro_Montar("ID_USUARIO", iID_USUARIO))

      oVoucher.Salvar(0,
                      iSQ_CLINICA_VENDA,
                      lblValorTotalProcedimento.Tag - objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_Desconto, grdTipoCalculoTotal.SomarValor))

      ComboBox_Carregar(cboVendaPendente, enSql.OrcamentoCliente_Aberto, New Object() {iID_EMPRESA_FILIAL, psqPessoa.ID_Pessoa})

      sSqlText = "UPDATE TB_CLINICA_VENDA SET TP_INTEGRADO_SISVIDA = 'N'" &
                 " WHERE SQ_CLINICA_VENDA = " & iSQ_CLINICA_VENDA
      DBExecutar(sSqlText)

      ''Integração SisVida
      'Dim oData As DataTable
      'Dim NO_PROFISSIONAL As String = ""
      'Dim NO_PROFISSIONAL_CONSELHO_UF As String = ""
      'Dim NO_PROFISSIONAL_CONSELHO_NR As String = ""
      'Dim NO_PROFISSIONAL_CBO As String = ""
      'Dim NO_PROFISSIONAL_CONSELHO As String = ""
      'Dim NO_PESSOA As String = ""
      'Dim oID_Solicitante As New Collection()
      'Dim Achou As Boolean
      'Dim iCont02 As Integer

      'For iCont01 = 0 To grdListagem.Rows.Count - 1
      '  With grdListagem.Rows(iCont01)
      '    If FNC_NVL(.Cells(const_GridListagem_IntegracaoSisVida).Value, "N") = "S" And
      '       FNC_NVL(.Cells(const_GridListagem_CodigoIntegracaoProcedimentoExame).Value, "") <> "" Then
      '      Achou = False
      '      Achou = FNC_Collection_Existe(oID_Solicitante, .Cells(const_GridListagem_ID_Solicitante).Value)

      '      If Not Achou Then oID_Solicitante.Add(.Cells(const_GridListagem_ID_Solicitante).Value)
      '    End If
      '  End With
      'Next

      'If oID_Solicitante.Count > 0 Then
      '  For iCont02 = 1 To oID_Solicitante.Count
      '    modSisVida.Inicializar()

      '    For iCont01 = 0 To grdListagem.Rows.Count - 1
      '      With grdListagem.Rows(iCont01)
      '        If FNC_NVL(.Cells(const_GridListagem_IntegracaoSisVida).Value, "N") = "S" And
      '           FNC_NVL(.Cells(const_GridListagem_CodigoIntegracaoProcedimentoExame).Value, "") <> "" And
      '           FNC_NVL(.Cells(const_GridListagem_ID_Solicitante).Value, "") = oID_Solicitante(iCont02) Then
      '          sSqlText = "SELECT PE.DS_PROFISSIONAL_CBO," &
      '                                "UF.CD_UF," &
      '                                "PE.NR_PROFISSIONAL_CONSELHOPROFISSIONAL," &
      '                                "CP.CD_CONSELHOPROFISSIONAL" &
      '                         " FROM TB_PESSOA_EMPRESA PE" &
      '                          " INNER JOIN TB_UF UF ON UF.SQ_UF = PE.ID_PROFISSIONAL_CONSELHOPROFISSIONAL_UF" &
      '                          " INNER JOIN TB_CONSELHOPROFISSIONAL CP ON CP.SQ_CONSELHOPROFISSIONAL = PE.ID_PROFISSIONAL_CONSELHOPROFISSIONAL" &
      '                          " WHERE PE.ID_PESSOA = " & .Cells(const_GridListagem_ID_Solicitante).Value &
      '                            " AND PE.ID_EMPRESA = " & iID_EMPRESA_MATRIZ
      '          oData = DBQuery(sSqlText)

      '          If objDataTable_Vazio(oData) Then
      '            NO_PROFISSIONAL = ""
      '            NO_PROFISSIONAL_CONSELHO_UF = ""
      '            NO_PROFISSIONAL_CONSELHO_NR = ""
      '            NO_PROFISSIONAL_CBO = ""
      '            NO_PROFISSIONAL_CONSELHO = ""
      '          Else
      '            NO_PROFISSIONAL = .Cells(const_GridListagem_Solicitante).Value
      '            NO_PROFISSIONAL_CONSELHO_UF = FNC_NVL(oData.Rows(0).Item("CD_UF"), "")
      '            NO_PROFISSIONAL_CONSELHO_NR = FNC_NVL(oData.Rows(0).Item("NR_PROFISSIONAL_CONSELHOPROFISSIONAL"), "")
      '            NO_PROFISSIONAL_CBO = FNC_NVL(oData.Rows(0).Item("DS_PROFISSIONAL_CBO"), "")
      '            NO_PROFISSIONAL_CONSELHO = FNC_NVL(oData.Rows(0).Item("CD_CONSELHOPROFISSIONAL"), "")
      '          End If

      '          If psqPessoa.cboPessoa.Text.IndexOf("(") > 0 Then
      '            NO_PESSOA = psqPessoa.cboPessoa.Text.Substring(0, psqPessoa.cboPessoa.Text.IndexOf("(")).Trim()
      '          Else
      '            NO_PESSOA = psqPessoa.cboPessoa.Text
      '          End If

      '          modSisVida.AdicionarExames(.Cells(const_GridListagem_ID_PROCEDIMENTO).Value,
      '                                     Trim(.Cells(const_GridListagem_CodigoIntegracaoProcedimentoExame).Value),
      '                                     Trim(.Cells(const_GridListagem_DescricaoIntegracaoProcedimentoExame).Value),
      '                                     Trim(.Cells(const_GridListagem_CodigoIntegracaoProcedimentoMaterial).Value),
      '                                     Trim(.Cells(const_GridListagem_DescricaoIntegracaoProcedimentoMaterial).Value))
      '        End If
      '      End With
      '    Next

      '    FNC_Historico_Incluir(enOpcoes.Processo_Historico_Vendas_Lancamento,
      '                          enOpcoes.Processo_Acao_Inclusao, 0,
      '                          iSQ_CLINICA_VENDA,
      '                          "", txtCodigoVenda.Text)

      '    modSisVida.EnviarSimples(iSQ_CLINICA_VENDA,
      '                             psqPessoa.ID_Pessoa,
      '                             NO_PESSOA,
      '                             DT_PACIENTE_NASCIMENTO,
      '                             TP_PACIENTE_MASCULINO,
      '                             CD_PACIENTE_CPF,
      '                             CD_PACIENTE_TELEFONE,
      '                             DS_PACIENTE_ENDERECO,
      '                             DS_PACIENTE_ENDERECO_CIDADE,
      '                             CD_PACIENTE_ENDERECO_UF,
      '                             NO_PROFISSIONAL,
      '                             NO_PROFISSIONAL_CONSELHO_UF,
      '                             NO_PROFISSIONAL_CONSELHO_NR,
      '                             NO_PROFISSIONAL_CBO,
      '                             NO_PROFISSIONAL_CONSELHO)
      '  Next
      'End If

      FNC_Mensagem("Gravação Efetuada")

      RaiseEvent GravacaoEfetuada()
    End If
  End Sub

  Private Function ProfissionalPrestadorServico_IntegracaoSisVida(iID_PESSOA As Integer) As String
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) " &
               " FROM TB_PESSOA_INTEGRACAO PI" &
                " INNER JOIN TB_INTEGRACAO IT ON IT.SQ_INTEGRACAO = PI.ID_INTEGRACAO" &
                                           " AND ISNULL(IT.TP_ATIVO, 'N') = 'S'" &
               " WHERE PI.ID_PESSOA = " & iID_PESSOA &
                 " AND PI.ID_INTEGRACAO = " & enIntegracao.eSisVida.GetHashCode().ToString()
    Return IIf(DBQuery_ValorUnico(sSqlText) > 0, "S", "N")
  End Function

  Private Sub cmdAdicionarProduto_Click(sender As Object, e As EventArgs) Handles cmdAdicionarProduto.Click
    If psqProcedimento.Identificador = 0 Then
      FNC_Mensagem("Informe o procedimento a ser adicionado")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboProfissionalPrestadorServico) Then
      FNC_Mensagem("Selecione o médico/prestador de serviço")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboContaFinanceira) Then
      FNC_Mensagem("Selecione a conta caixa")
      Exit Sub
    End If
    If txtValorProcedimento.Value <= 0 Then
      FNC_Mensagem("Informe o valor do procedimento")
      Exit Sub
    End If
    If txtValorDesconto.Value > txtValorProcedimento.Value Then
      FNC_Mensagem("O Valor do desconto não pode ser maior que o valor do procedimento")
      Exit Sub
    End If
    If lblSaldoConvenio.Visible And FNC_NVL(lblSaldoConvenio.Tag, 0) < (txtValorProcedimento.Value - txtValorDesconto.Value) Then
      FNC_Mensagem("Esse convênio tem controle de créito, e o saldo é menor do que o valor do procedimento")
      Exit Sub
    End If
    If CDbl(FNC_NVL(cboContaFinanceira.SelectedItem(enComboBox_ContaCaixa.PC_DESCONTO_MAXIMO), 0)) < txtPercentualDesconto.Value AndAlso
       CDbl(FNC_NVL(cboContaFinanceira.SelectedItem(enComboBox_ContaCaixa.PC_DESCONTO_MAXIMO), 0)) > 0 Then
      FNC_Mensagem("O % de desconto não pode ser maior que o limite do caixa")
      Exit Sub
    End If

    Dim dVL_REPASSE As Double

    If FNC_NVL(cboProfissionalPrestadorServico.SelectedItem(enComboBox_PessoaProfissionalFornecedorConvenioProcedimento.VL_REPASSE), 0) = 0 Then
      dVL_REPASSE = FNC_Porcentagem(txtValorProcedimento.Value, cboProfissionalPrestadorServico.SelectedItem(enComboBox_PessoaProfissionalFornecedorConvenioProcedimento.PC_REPASSE), 2)
    Else
      dVL_REPASSE = cboProfissionalPrestadorServico.SelectedItem(enComboBox_PessoaProfissionalFornecedorConvenioProcedimento.VL_REPASSE)
    End If

    Dim oData As DataTable
    Dim sSqlText As String
    Dim iID_Especialidade As Integer = 0
    Dim sNO_Especialidade As String = ""
    Dim sIC_GERA_CLINICA_EXAME_CITOLOGICO As String = "N"
    Dim iLinha As Integer

    sSqlText = "SELECT PROCE.ID_ESPECIALIDADE_PADRAO," &
                      "ESPEC.NO_ESPECIALIDADE," &
                      "ISNULL(PROCE.IC_GERA_CLINICA_EXAME_CITOLOGICO, 'N') IC_GERA_CLINICA_EXAME_CITOLOGICO" &
                 " FROM TB_PROCEDIMENTO PROCE" &
                  " LEFT JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = PROCE.ID_ESPECIALIDADE_PADRAO" &
                 " WHERE PROCE.SQ_PROCEDIMENTO = " & psqProcedimento.Identificador
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      If Not objDataTable_CampoVazio(oData.Rows(0).Item("NO_ESPECIALIDADE")) Then
        iID_Especialidade = oData.Rows(0).Item("ID_ESPECIALIDADE_PADRAO")
        sNO_Especialidade = oData.Rows(0).Item("NO_ESPECIALIDADE")
      End If

      If iID_CLINICA_ATENDIMENTO = 0 And iID_ORCAMENTO_CLIENTE = 0 And iID_ATENDIMENTO = 0 Then
        sIC_GERA_CLINICA_EXAME_CITOLOGICO = oData.Rows(0).Item("IC_GERA_CLINICA_EXAME_CITOLOGICO")
      Else
        sIC_GERA_CLINICA_EXAME_CITOLOGICO = "N"
      End If
    End If

    oData.Dispose()

    If iLinhaEdicao = -1 Then
      iLinha = objGrid_Linha_Add(grdListagem, New Object() {const_GridListagem_ID_PROCEDIMENTO, psqProcedimento.Identificador,
                                                            const_GridListagem_ID_PESSOA_PROFISSIONAL, cboProfissionalPrestadorServico.SelectedValue,
                                                            const_GridListagem_ProfissionalPrestadorServico, cboProfissionalPrestadorServico.SelectedItem(enComboBox_PessoaProfissionalFornecedorConvenioProcedimento.NO_PESSOA),
                                                            const_GridListagem_IC_PROFISSIONAL_SERVICO_INTERNO, cboProfissionalPrestadorServico.SelectedItem(enComboBox_PessoaProfissionalFornecedorConvenioProcedimento.IC_PROFISSIONAL_SERVICO_INTERNO),
                                                            const_GridListagem_CodigoProcedimento, psqProcedimento.Codigo,
                                                            const_GridListagem_Procedimento, psqProcedimento.Nome,
                                                            const_GridListagem_VL_REPASSE, dVL_REPASSE,
                                                            const_GridListagem_Desconto, txtValorDesconto.Value,
                                                            const_GridListagem_Valor, txtValorProcedimento.Value,
                                                            const_GridListagem_QT_DIAS_REPASSE, cboProfissionalPrestadorServico.SelectedItem(enComboBox_PessoaProfissionalFornecedorConvenioProcedimento.QT_DIAS_REPASSE),
                                                            const_GridListagem_ExigeExameCitologico, sIC_GERA_CLINICA_EXAME_CITOLOGICO,
                                                            const_GridListagem_IntegracaoSisVida, ProfissionalPrestadorServico_IntegracaoSisVida(cboProfissionalPrestadorServico.SelectedValue),
                                                            const_GridListagem_CodigoIntegracaoProcedimentoExame, psqProcedimento.cboProcedimento.SelectedItem(enComboBox_Procedimento.CD_INTEGRACAO_EXAME),
                                                            const_GridListagem_DescricaoIntegracaoProcedimentoExame, psqProcedimento.cboProcedimento.SelectedItem(enComboBox_Procedimento.DS_INTEGRACAO_EXAME),
                                                            const_GridListagem_CodigoIntegracaoProcedimentoMaterial, psqProcedimento.cboProcedimento.SelectedItem(enComboBox_Procedimento.CD_INTEGRACAO_MATERIAL),
                                                            const_GridListagem_DescricaoIntegracaoProcedimentoMaterial, psqProcedimento.cboProcedimento.SelectedItem(enComboBox_Procedimento.DS_INTEGRACAO_MATERIAL)}).Index
      Grid_CarregarEspecialidade_Linha(iLinha)
    Else
      With grdListagem.Rows(iLinhaEdicao)
        .Cells(const_GridListagem_Desconto).Value = txtValorDesconto.Value
        .Cells(const_GridListagem_Valor).Value = txtValorProcedimento.Value
        .Cells(const_GridListagem_ExigeExameCitologico).Value = sIC_GERA_CLINICA_EXAME_CITOLOGICO
      End With
    End If

    CalcularProcedimento()

    Novo()
  End Sub

  Private Sub CalcularProcedimento()
    lblQuantidade.Text = objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_ID_PROCEDIMENTO, grdTipoCalculoTotal.QuantidadeLinha)
    lblValorTotalProcedimento.Tag = objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_Valor, grdTipoCalculoTotal.SomarValor)
    lblValorTotalProcedimento.Text = FormatCurrency(lblValorTotalProcedimento.Tag)
    lblValorTotalDesconto.Text = FormatCurrency(objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_Desconto, grdTipoCalculoTotal.SomarValor))
  End Sub

  Private Sub CarregarPessoaProfissionalFornecedorConvenioProcedimento()
    If Not ComboBox_Selecionado(cboConvenio) Or psqProcedimento.Identificador = 0 Then
      cboProfissionalPrestadorServico.DataSource = Nothing
    Else
      ComboBox_Carregar(cboProfissionalPrestadorServico, enSql.PessoaProfissionalFornecedorConvenioProcedimento_Ativo, New Object() {FNC_NuloZero(cboConvenio.SelectedValue),
                                                                                                                                     FNC_NuloZero(psqProcedimento.Identificador)})
      Dim sSqlText As String

      sSqlText = "SELECT ISNULL(ID_PESSOA_PROFISSIONAL, 0) FROM VW_CONVENIO_PROCEDIMENTO" &
                 " WHERE ID_CONVENIO = " & FNC_NuloZero(cboConvenio.SelectedValue) &
                   " And ID_PROCEDIMENTO = " & FNC_NuloZero(psqProcedimento.Identificador) &
                   " And IC_PADRAO = 'S'"

      ComboBox_Selecionar(cboProfissionalPrestadorServico, DBQuery_ValorUnico(sSqlText, 0))
    End If
  End Sub

  Private Sub psqProcedimento_ItemSelecionado(sender As Object, e As EventArgs) Handles psqProcedimento.ItemSelecionado
    CarregarPessoaProfissionalFornecedorConvenioProcedimento()
  End Sub

  Private Sub cboProfissionalPrestadorServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProfissionalPrestadorServico.SelectedIndexChanged
    If ComboBox_Selecionado(cboProfissionalPrestadorServico) Then
      txtValorProcedimento.Value = FNC_NuloZero(cboProfissionalPrestadorServico.SelectedItem(enComboBox_PessoaProfissionalFornecedorConvenioProcedimento.VL_PROCEDIMENTO), False)
    Else
      txtValorProcedimento.Value = 0
    End If
  End Sub

  Private Sub psqPessoa_SelectedIndexChanged() Handles psqPessoa.SelectedIndexChanged
    bEmpProcessamento = True
    CarregarDadosPessoa()
    CarregarVendaPendente()
    ComboBox_CarregarIndicador(cboIndicador, psqPessoa.ID_Pessoa)
    bEmpProcessamento = False
  End Sub

  Private Sub CarregarDadosPessoa()
    Dim oData As DataTable
    Dim SqlText As String

    SqlText = "SELECT PES.NO_PESSOA, PES.DT_NASC_ABERTURA, SUBSTRING(ISNULL(SXO.NO_TIPO_SEXO, ''), 1, 1) NO_TIPO_SEXO, PES.CD_CPF_CNPJ, TLP.CD_NUMERO, ENP.DS_LOGRADOURO_COMPLETO, ENP.NO_CIDADE, ENP.CD_UF" +
              " FROM TB_PESSOA PES" +
               " LEFT JOIN TB_TIPO_SEXO SXO On SXO.SQ_TIPO_SEXO = PES.ID_PF_TIPO_SEXO" +
               " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO TLP ON TLP.ID_PESSOA = PES.SQ_PESSOA" +
               " LEFT JOIN VW_ENDERECO_PRIMEIRO ENP ON ENP.ID_PESSOA = PES.SQ_PESSOA" +
              " WHERE PES.SQ_PESSOA = " & psqPessoa.ID_Pessoa
    oData = DBQuery(SqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        DT_PACIENTE_NOME = FNC_NVL(.Item("NO_PESSOA"), "")
        DT_PACIENTE_NASCIMENTO = FNC_NVL(.Item("DT_NASC_ABERTURA"), "")
        TP_PACIENTE_MASCULINO = FNC_NVL(.Item("NO_TIPO_SEXO"), "")
        CD_PACIENTE_CPF = FNC_NVL(.Item("CD_CPF_CNPJ"), "")
        CD_PACIENTE_TELEFONE = FNC_NVL(.Item("CD_NUMERO"), "")
        DS_PACIENTE_ENDERECO = FNC_NVL(.Item("DS_LOGRADOURO_COMPLETO"), "")
        DS_PACIENTE_ENDERECO_CIDADE = FNC_NVL(.Item("NO_CIDADE"), "")
        CD_PACIENTE_ENDERECO_UF = FNC_NVL(.Item("CD_UF"), "")
      End With
    End If
  End Sub

  Private Sub CarregarVendaPendente()
    Dim sSqlText As String
    Dim bMultiploAgenamento As Boolean

    If oID_AGENDAMENTO Is Nothing Then
      oID_AGENDAMENTO = New Collection
    End If

    bMultiploAgenamento = (oID_AGENDAMENTO.Count > 1)

    sSqlText = "SELECT " & enOrigemVenda.OrcamentoClinica.GetHashCode() & " NR_ITEM," &
                      "CONCAT('Orçamento Clínica: ', CD_ORCAMENTO_CLIENTE) CD_ITEM," &
                      "CAST(SQ_ORCAMENTO_CLIENTE AS VARCHAR(100)) SQ_ITEM," &
                      "ID_CONVENIO" &
               " FROM TB_ORCAMENTO_CLIENTE" &
               " WHERE ID_OPT_STATUS IN (" & enOpcoes.StatusOrcamentoClinica_Cadastrado.GetHashCode() & "," &
                                             enOpcoes.StatusOrcamentoClinica_EmAberto.GetHashCode() & ")" &
                 " And ID_PESSOA = " & psqPessoa.ID_Pessoa.ToString()

    If iID_ORCAMENTO_CLIENTE > 0 Then
      sSqlText = sSqlText & " AND SQ_ORCAMENTO_CLIENTE = " & iID_ORCAMENTO_CLIENTE
    End If

    If Not bMultiploAgenamento Then
      sSqlText = sSqlText &
               " UNION " &
               "SELECT " & enOrigemVenda.Agendamento.GetHashCode() & "," &
                      "CONCAT('Agendamento: ', CD_AGENDAMENTO, ' - ', PROCE.NO_PROCEDIMENTO)," &
                      IIf(bMultiploAgenamento, FNC_QuotedStr(FNC_Collection_Para_Lista(oID_AGENDAMENTO, "-")), "SQ_AGENDAMENTO") & "," &
                      "ID_CONVENIO" &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
               " WHERE AGEND.ID_PESSOA = " & psqPessoa.ID_Pessoa.ToString() &
                 " AND AGEND.ID_OPT_STATUS IN (" & enOpcoes.StatusAgendamento_Confirmado.GetHashCode() & "," &
                                                   enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode() & "," &
                                                   enOpcoes.StatusAgendamento_Agendado.GetHashCode() & ")"

      If oID_AGENDAMENTO.Count > 0 Then
        If Val(oID_AGENDAMENTO(1)) > 0 Then
          sSqlText = sSqlText & " AND AGEND.SQ_AGENDAMENTO = " & oID_AGENDAMENTO(1)
        End If
      End If
    ElseIf oID_AGENDAMENTO.Count > 1 Then
      sSqlText = sSqlText &
               " UNION " &
               "SELECT " & enOrigemVenda.Agendamento.GetHashCode() & "," &
                      "'Múltiplos Agendamentos'," &
                      FNC_QuotedStr(FNC_Collection_Para_Lista(oID_AGENDAMENTO, "-")) & "," &
                      "ID_CONVENIO" &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" &
               " WHERE AGEND.SQ_AGENDAMENTO IN (" & FNC_Collection_Para_Lista(oID_AGENDAMENTO) & ")"
    End If

    sSqlText = sSqlText &
             " UNION " &
             "SELECT DISTINCT " & enOrigemVenda.SolicitacaoExame.GetHashCode() & "," &
                             "CONCAT('Atendimento Clínica: ', CD_CLINICA_ATENDIMENTO, ' - ', NO_PESSOA_PROFISSIONAL) CD_ITEM," &
                             "CAST(ID_CLINICA_ATENDIMENTO AS VARCHAR(100))," &
                             "ID_CONVENIO" &
             " FROM VW_CLINICA_PROCEDIMENTO_PENDENTE" &
             " WHERE ID_PESSOA = " & psqPessoa.ID_Pessoa.ToString()

    If iID_CLINICA_ATENDIMENTO > 0 Then
      sSqlText = sSqlText & " AND ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
    End If

    sSqlText = "SELECT * FROM (" & sSqlText & ") X ORDER BY NR_ITEM, CD_ITEM"

    DBComboBox_Carregar(cboVendaPendente, sSqlText)
  End Sub

  Private Sub CarregarAgendamentoPendente(oID_AGENDAMENTO As Object)
    Dim sSqlText As String

    sSqlText = "SELECT DISTINCT AGEND.ID_PROCEDIMENTO," &
                               "AGEND.ID_PESSOA_PROFISSIONAL," &
                               "PESSO.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                               "PROCE.NO_PROCEDIMENTO," &
                               "0.0," &
                               "CVPCD.VL_PROCEDIMENTO," &
                               "ISNULL(CVPCD.QT_DIAS_REPASSE, 0) QT_DIAS_REPASSE," &
                               "AGEND.SQ_AGENDAMENTO," &
                               "CVPCD.VL_REPASSE_REAL," &
                               "CVPCD.IC_PROFISSIONAL_SERVICO_INTERNO," &
                               "PROCE.IC_GERA_CLINICA_EXAME_CITOLOGICO," &
                               "AGEND.DH_AGENDAMENTO," &
                               "PROCE.CD_INTEGRACAO_EXAME," &
                               "PROCE.DS_INTEGRACAO_EXAME," &
                               "PROCE.CD_INTEGRACAO_MATERIAL," &
                               "PROCE.DS_INTEGRACAO_MATERIAL" &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                 " LEFT JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = PROCE.ID_ESPECIALIDADE_PADRAO" &
                 " LEFT JOIN VW_CONVENIO_PROCEDIMENTO CVPCD ON CVPCD.ID_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                                                         " AND CVPCD.ID_PESSOA_PROFISSIONAL = AGEND.ID_PESSOA_PROFISSIONAL" &
                                                         " AND CVPCD.ID_CONVENIO = AGEND.ID_CONVENIO" &
                                                         " AND CVPCD.IC_ATIVO = 'S'" &
               " WHERE AGEND.SQ_AGENDAMENTO IN (" & oID_AGENDAMENTO.ToString().Replace("-", ",") & ")"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_PROCEDIMENTO,
                                                           const_GridListagem_ID_PESSOA_PROFISSIONAL,
                                                           const_GridListagem_ProfissionalPrestadorServico,
                                                           const_GridListagem_Procedimento,
                                                           const_GridListagem_Desconto,
                                                           const_GridListagem_Valor,
                                                           const_GridListagem_QT_DIAS_REPASSE,
                                                           const_GridListagem_SQ_AGENDAMENTO,
                                                           const_GridListagem_VL_REPASSE,
                                                           const_GridListagem_IC_PROFISSIONAL_SERVICO_INTERNO,
                                                           const_GridListagem_ExigeExameCitologico,
                                                           const_GridListagem_DH_AgendamentoPendente,
                                                           const_GridListagem_CodigoIntegracaoProcedimentoExame,
                                                           const_GridListagem_DescricaoIntegracaoProcedimentoExame,
                                                           const_GridListagem_CodigoIntegracaoProcedimentoMaterial,
                                                           const_GridListagem_DescricaoIntegracaoProcedimentoMaterial})

    Grid_CarregarEspecialidade()

    If grdListagem.Rows.Count > 0 Then
      Dim oData As DataTable

      sSqlText = "SELECT ID_PESSOAINDICADOR, ID_CANALMARCACAO FROM TB_AGENDAMENTO WHERE SQ_AGENDAMENTO = " & grdListagem.Rows(0).Cells(const_GridListagem_SQ_AGENDAMENTO).Value
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        ComboBox_Selecionar(cboIndicador, oData.Rows(0).Item("ID_PESSOAINDICADOR"))
        ComboBox_Selecionar(cboCanalMarcacao, oData.Rows(0).Item("ID_CANALMARCACAO"))
      End If

      oVoucher.Carregar(oID_AGENDAMENTO)
    End If
  End Sub

  Private Sub CarregarOrcamentoPendente(iSQ_ORCAMENTO_CLIENTE As Integer)
    Dim sSqlText As String

    sSqlText = "SELECT DISTINCT OCPRC.ID_PROCEDIMENTO," &
                               "OCPRC.ID_PESSOA_PROFISSIONAL," &
                               "PESSO.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                               "PROCE.NO_PROCEDIMENTO," &
                               "0.0," &
                               "OCPRC.VL_ORCADO," &
                               "ISNULL(CVPCD.QT_DIAS_REPASSE, 0) QT_DIAS_REPASSE," &
                               "OCPRC.SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO," &
                               "CVPCD.VL_REPASSE_REAL," &
                               "PROCE.IC_GERA_CLINICA_EXAME_CITOLOGICO," &
                               "CVPCD.IC_PROFISSIONAL_SERVICO_INTERNO," &
                               "PESSO_SOLIC.NO_PESSOA," &
                               "PESSO_SOLIC.SQ_PESSOA," &
                               "PROCE.CD_INTEGRACAO_EXAME," &
                               "PROCE.DS_INTEGRACAO_EXAME," &
                               "PROCE.CD_INTEGRACAO_MATERIAL," &
                               "PROCE.DS_INTEGRACAO_MATERIAL" &
               " FROM TB_ORCAMENTO_CLIENTE OCCLI" &
                " INNER JOIN TB_ORCAMENTO_CLIENTE_PROCEDIMENTO OCPRC ON OCPRC.ID_ORCAMENTO_CLIENTE = OCCLI.SQ_ORCAMENTO_CLIENTE" &
                                                                  " AND OCPRC.ID_OPT_STATUS = " & enOpcoes.StatusItemOrcamentoClinica_Cadastrado.GetHashCode() &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                 " LEFT JOIN TB_CLINICA_PROCEDIMENTO CLCPC ON CLCPC.SQ_CLINICA_PROCEDIMENTO = OCPRC.ID_CLINICA_PROCEDIMENTO" &
                 " LEFT JOIN TB_CLINICA_EXAME_CITOLOGICO CEXCT ON CEXCT.ID_CLINICA_ATENDIMENTO = CLCPC.ID_CLINICA_ATENDIMENTO" &
                 " LEFT JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = PROCE.ID_ESPECIALIDADE_PADRAO" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL" &
                 " LEFT JOIN VW_CONVENIO_PROCEDIMENTO CVPCD ON CVPCD.ID_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                                                         " AND CVPCD.ID_PESSOA_PROFISSIONAL = OCPRC.ID_PESSOA_PROFISSIONAL" &
                                                         " AND CVPCD.ID_CONVENIO = OCCLI.ID_CONVENIO" &
                 " LEFT JOIN TB_PESSOA PESSO_SOLIC ON PESSO_SOLIC.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL_SOLICITANTE" &
               " WHERE OCCLI.SQ_ORCAMENTO_CLIENTE = " & iSQ_ORCAMENTO_CLIENTE.ToString()
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_PROCEDIMENTO,
                                                           const_GridListagem_ID_PESSOA_PROFISSIONAL,
                                                           const_GridListagem_ProfissionalPrestadorServico,
                                                           const_GridListagem_Procedimento,
                                                           const_GridListagem_Desconto,
                                                           const_GridListagem_Valor,
                                                           const_GridListagem_QT_DIAS_REPASSE,
                                                           const_GridListagem_SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO,
                                                           const_GridListagem_VL_REPASSE,
                                                           const_GridListagem_ExigeExameCitologico,
                                                           const_GridListagem_IC_PROFISSIONAL_SERVICO_INTERNO,
                                                           const_GridListagem_Solicitante,
                                                           const_GridListagem_ID_Solicitante,
                                                           const_GridListagem_CodigoIntegracaoProcedimentoExame,
                                                           const_GridListagem_DescricaoIntegracaoProcedimentoExame,
                                                           const_GridListagem_CodigoIntegracaoProcedimentoMaterial,
                                                           const_GridListagem_DescricaoIntegracaoProcedimentoMaterial})

    Grid_CarregarEspecialidade()
  End Sub

  Private Sub CarregarClinicaProcedimentoPendente(iID_CLINICA_ATENDIMENTO As Integer)
    Dim sSqlText As String

    sSqlText = "SELECT DISTINCT CLPCD.ID_PROCEDIMENTO," &
                               "PESSO.SQ_PESSOA ID_PESSOA_PROFISSIONAL," &
                               "PESSO.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                               "CLPCD.NO_PROCEDIMENTO," &
                               "0.0," &
                               "CVPCD.VL_PROCEDIMENTO," &
                               "ISNULL(CVPCD.QT_DIAS_REPASSE, 0) QT_DIAS_REPASSE," &
                               "CLPCD.SQ_CLINICA_PROCEDIMENTO," &
                               "CVPCD.VL_REPASSE_REAL," &
                               "PROCE.IC_GERA_CLINICA_EXAME_CITOLOGICO," &
                               "CVPCD.IC_PROFISSIONAL_SERVICO_INTERNO," &
                               "CLPCD.ID_PESSOA_PROFISSIONAL," &
                               "CLPCD.NO_PESSOA_PROFISSIONAL," &
                               "PROCE.CD_INTEGRACAO_EXAME," &
                               "PROCE.DS_INTEGRACAO_EXAME," &
                               "PROCE.CD_INTEGRACAO_MATERIAL," &
                               "PROCE.DS_INTEGRACAO_MATERIAL" &
               " FROM VW_CLINICA_PROCEDIMENTO_PENDENTE CLPCD" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO" &
                 " LEFT JOIN VW_CONVENIO_PROCEDIMENTO CVPCD ON CVPCD.ID_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO" &
                                                         " AND CVPCD.ID_CONVENIO = CLPCD.ID_CONVENIO" &
                                                         " AND CVPCD.IC_PADRAO = 'S'" &
                " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL" &
                " LEFT JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = PROCE.ID_ESPECIALIDADE_PADRAO" &
               " WHERE CLPCD.ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO.ToString()
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_PROCEDIMENTO,
                                                           const_GridListagem_ID_PESSOA_PROFISSIONAL,
                                                           const_GridListagem_ProfissionalPrestadorServico,
                                                           const_GridListagem_Procedimento,
                                                           const_GridListagem_Desconto,
                                                           const_GridListagem_Valor,
                                                           const_GridListagem_QT_DIAS_REPASSE,
                                                           const_GridListagem_SQ_CLINICA_PROCEDIMENTO,
                                                           const_GridListagem_VL_REPASSE,
                                                           const_GridListagem_ExigeExameCitologico,
                                                           const_GridListagem_IC_PROFISSIONAL_SERVICO_INTERNO,
                                                           const_GridListagem_ID_Solicitante,
                                                           const_GridListagem_Solicitante,
                                                           const_GridListagem_CodigoIntegracaoProcedimentoExame,
                                                           const_GridListagem_DescricaoIntegracaoProcedimentoExame,
                                                           const_GridListagem_CodigoIntegracaoProcedimentoMaterial,
                                                           const_GridListagem_DescricaoIntegracaoProcedimentoMaterial})

    Grid_CarregarEspecialidade()
  End Sub

  Private Sub grdListagem_BeforeRowsDeleted(sender As Object, e As BeforeRowsDeletedEventArgs) Handles grdListagem.BeforeRowsDeleted
    e.DisplayPromptMsg = False

    If Not FNC_Perguntar("Deseja excluir o procedimento/exame " & e.Rows(0).Cells(const_GridListagem_Procedimento).Value) Then
      e.Cancel = True
    End If
  End Sub

  Private Sub cboVendaPendente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVendaPendente.SelectedIndexChanged
    ComboBox_VendaPendente_Carregar()
  End Sub

  Private Sub ComboBox_VendaPendente_Carregar()
    If bEmpProcessamento Then Exit Sub

    If ComboBox_Selecionado(cboVendaPendente) Then
      oID_AGENDAMENTO = New Collection
      iID_ORCAMENTO_CLIENTE = 0

      Select Case cboVendaPendente.SelectedItem(const_ComboVendaPendente_NR_ITEM)
        Case enOrigemVenda.OrcamentoClinica.GetHashCode()
          iID_ORCAMENTO_CLIENTE = cboVendaPendente.SelectedItem(const_ComboVendaPendente_SQ_ITEM)
          CarregarOrcamentoPendente(cboVendaPendente.SelectedItem(const_ComboVendaPendente_SQ_ITEM))
        Case enOrigemVenda.Agendamento.GetHashCode()
          oID_AGENDAMENTO = FNC_Lista_Para_Collection(cboVendaPendente.SelectedItem(const_ComboVendaPendente_SQ_ITEM), "-")
          CarregarAgendamentoPendente(cboVendaPendente.SelectedItem(const_ComboVendaPendente_SQ_ITEM))
        Case enOrigemVenda.SolicitacaoExame
          iID_CLINICA_ATENDIMENTO = cboVendaPendente.SelectedItem(const_ComboVendaPendente_SQ_ITEM)
          CarregarClinicaProcedimentoPendente(cboVendaPendente.SelectedItem(const_ComboVendaPendente_SQ_ITEM))
      End Select

      CalcularProcedimento()

      Try
        If FNC_NVL(cboVendaPendente.SelectedItem(const_ComboVendaPendente_ID_CONVENIO), 0) <> 0 Then
          cboConvenio.Tag = FNC_NVL(cboVendaPendente.SelectedItem(const_ComboVendaPendente_ID_CONVENIO), 0)
          cboConvenio.Enabled = (FNC_NVL(cboVendaPendente.SelectedItem(const_ComboVendaPendente_ID_CONVENIO), 0) <> 0)
          ComboBox_Selecionar(cboConvenio, cboVendaPendente.SelectedItem(const_ComboVendaPendente_ID_CONVENIO))
        End If
      Catch ex As Exception
      End Try
    Else
      cboConvenio.Enabled = False
    End If
  End Sub

  Private Sub cboVendaPendente_KeyDown(sender As Object, e As KeyEventArgs) Handles cboVendaPendente.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboVendaPendente.SelectedIndex = -1
      cboConvenio.Enabled = True
    End If
  End Sub

  Private Sub grdListagem_AfterRowsDeleted(sender As Object, e As EventArgs) Handles grdListagem.AfterRowsDeleted
    CalcularProcedimento()
  End Sub

  Private Sub ComboVendaPendente_Poscionar(NR_ITEM As Integer, SQ_ITEM As Object)
    Dim iCont As Integer

    For iCont = 0 To cboVendaPendente.Items.Count - 1
      If IsNumeric(SQ_ITEM) Then
        If cboVendaPendente.Items(iCont)(const_ComboVendaPendente_NR_ITEM) = NR_ITEM And
           cboVendaPendente.Items(iCont)(const_ComboVendaPendente_SQ_ITEM) = SQ_ITEM Then
          cboVendaPendente.SelectedIndex = iCont
          Exit For
        End If
      Else
        If cboVendaPendente.Items(iCont)(const_ComboVendaPendente_NR_ITEM) = NR_ITEM And
           cboVendaPendente.Items(iCont)(const_ComboVendaPendente_SQ_ITEM) = FNC_Collection_Para_Lista(SQ_ITEM, "-") Then
          cboVendaPendente.SelectedIndex = iCont
          Exit For
        End If
      End If
    Next
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    Formatar()
  End Sub

  Private Sub cmdGuiaConsultas_Click(sender As Object, e As EventArgs) Handles cmdGuiaConsultas.Click
    If iSQ_CLINICA_VENDA <= 0 Then
      FNC_Mensagem("É preciso gravar a venda antes")
      Exit Sub
    End If

    FormRelatorioGuiaConsulta(iSQ_CLINICA_VENDA, chkImrimirGuiaConsultas.Checked)
  End Sub

  Private Sub cmdExameInterno_Click(sender As Object, e As EventArgs) Handles cmdExameInterno.Click
    If iSQ_CLINICA_VENDA <= 0 Then
      FNC_Mensagem("É preciso gravar a venda antes")
      Exit Sub
    End If

    FormRelatorioExameInterno(iSQ_CLINICA_VENDA, chkImrimirExameInterno.Checked)
  End Sub

  Private Sub cmdExameExterno_Click(sender As Object, e As EventArgs) Handles cmdExameExterno.Click
    If iSQ_CLINICA_VENDA <= 0 Then
      FNC_Mensagem("É preciso gravar a venda antes")
      Exit Sub
    End If

    FormRelatorioExameExterno(iSQ_CLINICA_VENDA, chkImrimirExameExterno.Checked)
  End Sub

  Private Sub cboContaFinanceira_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContaFinanceira.SelectedIndexChanged
    If ComboBox_Selecionado(cboContaFinanceira) Then
      dDescontoMaximo = CDbl(FNC_NVL(cboContaFinanceira.SelectedItem(enComboBox_ContaCaixa.PC_DESCONTO_MAXIMO), 0))
    Else
      dDescontoMaximo = 0
    End If
  End Sub

  Private Sub cmdNovoProduto_Click(sender As Object, e As EventArgs) Handles cmdNovoProduto.Click
    Novo()
  End Sub

  Private Sub Novo()
    psqProcedimento.Enabled = True
    cboProfissionalPrestadorServico.Enabled = True
    psqProcedimento.Identificador = 0
    txtValorProcedimento.Value = 0
    txtValorDesconto.Value = 0
    cboProfissionalPrestadorServico.SelectedIndex = -1
    cmdAdicionarProduto.Image = My.Resources.Resources.Mini_Adicionar
    iLinhaEdicao = -1
  End Sub

  Private Sub grdListagem_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdListagem.DoubleClickRow
    psqProcedimento.Enabled = False
    cboProfissionalPrestadorServico.Enabled = False
    psqProcedimento.Identificador = e.Row.Cells(const_GridListagem_ID_PROCEDIMENTO).Value
    txtValorProcedimento.Value = e.Row.Cells(const_GridListagem_Valor).Value
    txtValorDesconto.Value = e.Row.Cells(const_GridListagem_Desconto).Value
    ComboBox_Selecionar(cboProfissionalPrestadorServico, e.Row.Cells(const_GridListagem_ID_PESSOA_PROFISSIONAL).Value)
    cmdAdicionarProduto.Image = My.Resources.Resources.Mini_Atualizar
    iLinhaEdicao = e.Row.Index
  End Sub

  Private Sub txtPercentualDesconto_ValueChanged(sender As Object, e As EventArgs) Handles txtPercentualDesconto.ValueChanged
    Try
      txtValorDesconto.Value = (txtValorProcedimento.Value * txtPercentualDesconto.Value / 100)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub txtValorDesconto_ValueChanged(sender As Object, e As EventArgs) Handles txtValorDesconto.ValueChanged
    Try
      txtPercentualDesconto.Value = (txtValorDesconto.Value / txtValorProcedimento.Value * 100)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub txtValorDesconto_LostFocus(sender As Object, e As EventArgs) Handles txtValorDesconto.LostFocus
    txtValorDesconto.Value = Math.Round(txtValorDesconto.Value, 2)
  End Sub

  Private Sub Convenio_AtualizarCredito()
    If ComboBox_Selecionado(cboConvenio) Then
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "Select SQ_CONVENIO, VL_CREDITO FROM TB_CONVENIO WHERE SQ_CONVENIO = " & cboConvenio.SelectedValue & " And ISNULL(IC_CONTROLACREDITO, 'N') = 'S'"
      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        lblSaldoConvenio.Tag = 0
        lblSaldoConvenio.Visible = False
      Else
        lblSaldoConvenio.Tag = FNC_NVL(oData.Rows(0).Item("VL_CREDITO"), 0)
        lblSaldoConvenio.Text = FormatCurrency(lblSaldoConvenio.Tag)
        lblSaldoConvenio.Visible = True
      End If

      oData.Dispose()
    End If
  End Sub

  Private Sub grdListagem_ClickCellButton(sender As Object, e As CellEventArgs) Handles grdListagem.ClickCellButton
    Select Case e.Cell.Column.Index
      Case const_GridListagem_BNT_Agendamento
        If FNC_NVL(e.Cell.Row.Cells(const_GridListagem_SQ_AGENDAMENTO).Value, 0) > 0 Then
          FNC_Mensagem("Já existe agendamento para essa venda")
          Exit Sub
        End If
        If FNC_NVL(e.Cell.Row.Cells(const_GridListagem_Especialidade).Value, 0) = 0 Then
          FNC_Mensagem("Não foi selecionado uma especialidade para esse procedimento")
          Exit Sub
        End If

        Dim oForm As New frmConsultaAgendamentoDisponibilidade
        oForm.sData_Inicial = Now.Date
        oForm.sData_Final = Now.Date.AddDays(15)
        oForm.sID_Procedimentos = e.Cell.Row.Cells(const_GridListagem_ID_PROCEDIMENTO).Value
        oForm.sID_Especialidade = e.Cell.Row.Cells(const_GridListagem_Especialidade).Value.ToString()
        oForm.sID_Paiciente = psqPessoa.ID_Pessoa
        oForm.bPodeSelecionar = True
        oForm.bRetornarData = True
        oForm.sEspecialidade = e.Cell.Row.Cells(const_GridListagem_Especialidade).Text
        oForm.sProcedimentos = e.Cell.Row.Cells(const_GridListagem_Procedimento).Value
        oForm.sPaciente = psqPessoa.cboPessoa.Text

        oForm.Formatar()

        FNC_AbriTela(oForm, , True, True)

        If Not oForm.bFechou Then
          e.Cell.Row.Cells(const_GridListagem_DH_NovoAgendamento).Value = oForm.dDataRetorno
          e.Cell.Row.Cells(const_GridListagem_ID_PESSOA_PROFISSIONAL).Value = oForm.sID_Profissionais
          e.Cell.Row.Cells(const_GridListagem_ProfissionalPrestadorServico).Value = oForm.sProfissionais
          e.Cell.Row.Cells(const_GridListagem_ID_EMPRESA).Value = oForm.sEmpresa
          e.Cell.Row.Cells(const_GridListagem_ID_PESSOA_HORARIO).Value = oForm.ID_PESSOA_HORARIO
        End If

        oForm = Nothing
      Case const_GridListagem_BNT_ExameCitologico
        Dim oForm As New frmCadastroAtendimentoSolicitacaoExameCitologico

        oForm.iSQ_PESSOA = psqPessoa.ID_Pessoa
        oForm.bFecharSair = True

        FNC_AbriTela(oForm,, True, True)

        e.Cell.Row.Cells(const_GridListagem_BNT_ExameCitologico).Tag = oForm.oSolicitacaoExameCitologico
      Case const_GridListagem_BNT_Pessoa
        Dim oForm As New frmpsqPessoa

        oForm.HabilitarSelecionarTodos = True
        oForm.TipoFiltro = frmpsqPessoa.enTipoFiltroPessoa.Paciente
        FNC_AbriTela(oForm, , True, True)

        If oForm.SQ_PESSOA > 0 Then
          If oForm.SelecionarParaTodos Then
            Grid_AtualizarTodos(oForm.NO_PESSOA, const_GridListagem_Pessoa_Agendamento)
            Grid_AtualizarTodos(oForm.SQ_PESSOA, const_GridListagem_ID_PESSOA_AGENDAMENTO)
          Else
            e.Cell.Row.Cells(const_GridListagem_Pessoa_Agendamento).Value = oForm.NO_PESSOA
            e.Cell.Row.Cells(const_GridListagem_ID_PESSOA_AGENDAMENTO).Value = oForm.SQ_PESSOA
          End If
        End If

        oForm.Close()
        oForm.Dispose()
      Case const_GridListagem_BNT_Solicitante
        Dim oForm As New frmpsqPessoa

        oForm.HabilitarSelecionarTodos = True
        oForm.TipoFiltro = frmpsqPessoa.enTipoFiltroPessoa.Profissional
        FNC_AbriTela(oForm, , True, True)

        If oForm.SQ_PESSOA > 0 Then
          If oForm.SelecionarParaTodos Then
            Grid_AtualizarTodos(oForm.NO_PESSOA, const_GridListagem_Solicitante)
            Grid_AtualizarTodos(oForm.SQ_PESSOA, const_GridListagem_ID_Solicitante)
          Else
            e.Cell.Row.Cells(const_GridListagem_Solicitante).Value = oForm.NO_PESSOA
            e.Cell.Row.Cells(const_GridListagem_ID_Solicitante).Value = oForm.SQ_PESSOA
          End If
        End If

        oForm.Close()
        oForm.Dispose()
    End Select
  End Sub

  Private Sub Grid_AtualizarTodos(Valor As Object, Coluna As Integer)
    For iLinha = 0 To grdListagem.Rows.Count - 1
      grdListagem.Rows(iLinha).Cells(Coluna).Value = Valor
    Next
  End Sub

  Private Sub Grid_CarregarEspecialidade()
    Dim iLinha As Integer

    For iLinha = 0 To grdListagem.Rows.Count - 1
      grdListagem.Rows(iLinha).Cells(const_GridListagem_IntegracaoSisVida).Value = ProfissionalPrestadorServico_IntegracaoSisVida(grdListagem.Rows(iLinha).Cells(const_GridListagem_ID_PESSOA_PROFISSIONAL).Value)

      Grid_CarregarEspecialidade_Linha(iLinha)
    Next
  End Sub

  Private Sub Grid_CarregarEspecialidade_Linha(iLinha)
    Dim sSqlText As String

    If FNC_NVL(grdListagem.Rows(iLinha).Cells(const_GridListagem_IC_PROFISSIONAL_SERVICO_INTERNO).Value, "N") = "S" Then
      sSqlText = "SELECT PSESP.ID_ESPECIALIDADE, ESPEC.NO_ESPECIALIDADE" &
               " FROM TB_PESSOA_ESPECIALIDADE PSESP" &
                " INNER JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = PSESP.ID_ESPECIALIDADE" &
                " WHERE PSESP.ID_PESSOA = " & grdListagem.Rows(iLinha).Cells(const_GridListagem_ID_PESSOA_PROFISSIONAL).Value
      grdListagem.Rows(iLinha).Cells(const_GridListagem_Especialidade).ValueList = DBValueList_Carregar(sSqlText)
    Else
      grdListagem.Rows(iLinha).Cells(const_GridListagem_Especialidade).ValueList = Nothing
    End If
  End Sub

  Public Function CadastroClienteValido(iID_Cliente As Integer) As Boolean
    Dim bOk As Boolean = False
    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) " &
               " FROM TB_PESSOA" &
               " WHERE SQ_PESSOA = " & iID_Cliente &
                 " AND (LTRIM(RTRIM(ISNULL(NO_PESSOA, ''))) = '' OR LTRIM(RTRIM(ISNULL(NO_MAE, ''))) = '' OR  LTRIM(RTRIM(ISNULL(CD_CPF_CNPJ, ''))) = '' OR 
																								 DT_NASC_ABERTURA Is NULL OR
																								 ID_PF_TIPO_ESTADOCIVIL IS NULL OR
																								 ID_PF_NACIONALIDADE IS NULL OR
																								 ID_PF_NATURALIDADE IS NULL)"

    If DBQuery_ValorUnicoInt(sSqlText) = 0 Then
      sSqlText = "SELECT COUNT(*) FROM TB_PESSOA_TELEFONE WHERE ID_PESSOA = " & iID_Cliente

      If DBQuery_ValorUnicoInt(sSqlText) > 0 Then
        sSqlText = "SELECT COUNT(*) FROM TB_ENDERECO WHERE ID_PESSOA = " & iID_Cliente

        If DBQuery_ValorUnicoInt(sSqlText) > 0 Then
          sSqlText = "SELECT COUNT(*) FROM TB_ENDERECO" &
                     " WHERE ID_PESSOA = " & iID_Cliente &
                       " AND (LTRIM(RTrim(ISNULL(DS_LOGRADOURO, ''))) = '' OR LTRIM(RTRIM(ISNULL(NO_BAIRRO, ''))) = '' OR LTRIM(RTRIM(ISNULL(NR_LOGRADOURO, ''))) = '' OR ID_CIDADE IS NULL)"

          If DBQuery_ValorUnicoInt(sSqlText) = 0 Then
            bOk = True
          End If
        End If
      End If
    End If

    Return bOk
  End Function
End Class
