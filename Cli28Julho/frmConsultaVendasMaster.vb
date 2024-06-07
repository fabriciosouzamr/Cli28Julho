Imports Infragistics.Win

Public Class frmConsultaVendasMaster
  Const const_GridListagem_NO_PLANOCONTAS_CR As Integer = 0
  Const const_GridListagem_NO_PLANOCONTAS_CP As Integer = 1
  Const const_GridListagem_NO_GRUPOPROCEDIMENTO As Integer = 2
  Const const_GridListagem_NO_ESPECIALIDADE As Integer = 3
  Const const_GridListagem_DS_SOLICITANTE As Integer = 4
  Const const_GridListagem_CD_AGENDAMENTO As Integer = 5
  Const const_GridListagem_NO_CONVENIO As Integer = 6
  Const const_GridListagem_NO_EMPREsa As Integer = 7
  Const const_GridListagem_CD_CLINICA_VENDA As Integer = 8
  Const const_GridListagem_DH_VENDA As Integer = 9
  Const const_GridListagem_NO_PESSOA As Integer = 10
  Const const_GridListagem_NO_BAIRRO As Integer = 11
  Const const_GridListagem_NO_CIDADE As Integer = 12
  Const const_GridListagem_CD_CPF_CNPJ As Integer = 13
  Const const_GridListagem_NO_PROFISSIONAL As Integer = 14
  Const const_GridListagem_NO_PROCEDIMENTO As Integer = 15
  Const const_GridListagem_VL_PROCEDIMENTO As Integer = 16
  Const const_GridListagem_VL_DESCONTO As Integer = 17
  Const const_GridListagem_VL_LIQUIDO As Integer = 18
  Const const_GridListagem_VL_REPASSE As Integer = 19
  Const const_GridListagem_NO_ATENDENTE As Integer = 20
  Const const_GridListagem_ID_MOVFINANCEIRA As Integer = 21
  Const const_GridListagem_CanalMarcacao As Integer = 22
  Const const_GridListagem_DataMarcacao As Integer = 23
  Const const_GridListagem_UsuarioMarcacao As Integer = 24

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""

    sSqlText = "SELECT PLCCR.NO_PLANOCONTAS AS NO_PLANOCONTAS_CR," &
                      "PLCCP.NO_PLANOCONTAS AS NO_PLANOCONTAS_CP," &
                      "GPPRC.NO_GRUPOPROCEDIMENTO," &
                      "ESPEC.NO_ESPECIALIDADE," &
                      "ISNULL(CLVND.DS_SOLICITANTE, ISNULL(CVPCD.DS_SOLICITANTE, PESSO_SOLIC.NO_PESSOA)) DS_SOLICITANTE," &
                      "AGEND.CD_AGENDAMENTO," &
                      "CONVE.NO_CONVENIO," &
                      "EMPRE.NO_PESSOA," &
                      "CLVND.CD_CLINICA_VENDA," &
                      "CLVND.DH_VENDA," &
                      "PESSO.NO_PESSOA," &
                      "ENDER.NO_BAIRRO," &
                      "ENDER.NO_CIDADE," &
                      "PESSO.CD_CPF_CNPJ," &
                      "PROFI.NO_PESSOA AS NO_PROFISSIONAL," &
                      "PROCE.NO_PROCEDIMENTO," &
                      "CVPCD.VL_PROCEDIMENTO," &
                      "ROUND((ISNULL(CLVND.VL_DESCONTO, 0) / MVFCR.VL_ORIGINAL * CVPCD.VL_PROCEDIMENTO) + CVPCD.VL_DESCONTO, 2)," &
                      "CVPCD.VL_PROCEDIMENTO - ROUND((ISNULL(CLVND.VL_DESCONTO, 0) / MVFCR.VL_ORIGINAL * CVPCD.VL_PROCEDIMENTO) + CVPCD.VL_DESCONTO, 2) AS VL_LIQUIDO," &
                      "CVPCD.VL_REPASSE," &
                      "ATEND.NO_PESSOA AS NO_ATENDENTE," &
                      "CVPCD.ID_MOVFINANCEIRA," &
                      "CNLMC.NO_CANALMARCACAO," &
                      "AGEND.DH_INLCUSAO," &
                      "HISTO.NO_USUARIO" &
               " FROM TB_CLINICA_VENDA CLVND (NOLOCK)" &
                " INNER JOIN TB_PESSOA PESSO (NOLOCK) ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                " INNER JOIN TB_PESSOA EMPRE (NOLOCK) ON EMPRE.SQ_PESSOA = CLVND.ID_EMPRESA" &
                " INNER JOIN TB_PESSOA (NOLOCK) ATEND ON ATEND.SQ_PESSOA = CLVND.ID_PESSOA_ATENDENTE" &
                " INNER JOIN TB_CONVENIO (NOLOCK) CONVE ON CONVE.SQ_CONVENIO = CLVND.ID_CONVENIO" &
                " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO (NOLOCK) CVPCD ON CVPCD.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                " INNER JOIN TB_PROCEDIMENTO (NOLOCK) PROCE ON PROCE.SQ_PROCEDIMENTO = CVPCD.ID_PROCEDIMENTO" &
                " INNER JOIN TB_GRUPOPROCEDIMENTO (NOLOCK) GPPRC ON GPPRC.SQ_GRUPOPROCEDIMENTO = PROCE.ID_GRUPOPROCEDIMENTO" &
                " INNER JOIN TB_PESSOA (NOLOCK) PROFI ON PROFI.SQ_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN (SELECT DISTINCT MVFNC.ID_CLINICA_VENDA" &
                             " FROM TB_MOVFINANCEIRA (NOLOCK) MVFNC" &
                              " INNER JOIN TB_MOVFINANCEIRAPARCELA (NOLOCK) MFPCL ON MFPCL.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                             " WHERE MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber &
                               " AND MFPCL.ID_TIPO_DOCUMENTO <> 10 ) MVFPC ON MVFPC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                   " LEFT JOIN (SELECT ID_CLINICA_VENDA," &
                                      "SUM(VL_ORIGINAL) VL_ORIGINAL," &
                                      "SUM(VL_DESCONTO) VL_DESCONTO" &
                               " FROM TB_MOVFINANCEIRA (NOLOCK)" &
                               " WHERE ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode() &
                               " GROUP BY ID_CLINICA_VENDA) MVFCR ON MVFCR.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA" &
                " LEFT JOIN TB_CANALMARCACAO CNLMC (NOLOCK) ON CNLMC.SQ_CANALMARCACAO = CLVND.ID_CANALMARCACAO" &
                " LEFT JOIN TB_PLANOCONTAS PLCCR (NOLOCK) ON PLCCR.SQ_PLANOCONTAS = GPPRC.ID_PLANOCONTAS" &
                " LEFT JOIN TB_PLANOCONTAS PLCCP (NOLOCK) ON PLCCP.SQ_PLANOCONTAS = GPPRC.ID_PLANOCONTAS_CONTASPAGAR" &
                " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER (NOLOCK) ON ENDER.ID_PESSOA = PESSO.SQ_PESSOA" &
                " LEFT JOIN TB_CIDADE CIDAD (NOLOCK) ON CIDAD.SQ_CIDADE = ENDER.ID_CIDADE" &
                " LEFT JOIN TB_AGENDAMENTO AGEND (NOLOCK) ON AGEND.SQ_AGENDAMENTO = CVPCD.ID_AGENDAMENTO" &
                " LEFT JOIN TB_ESPECIALIDADE ESPEC (NOLOCK) ON ESPEC.SQ_ESPECIALIDADE = AGEND.ID_ESPECIALIDADE" &
                " LEFT JOIN TB_OPCAO OPCAO_DIASM (NOLOCK) ON OPCAO_DIASM.CD_OPCAO = CAST(DATEPART(W, CLVND.DH_VENDA) AS CHAR)" &
                                                       " AND OPCAO_DIASM.ID_TIPO_OPCAO = " & enTipoOpcao.DiasSemana.GetHashCode() &
                " LEFT JOIN VW_HISTORICO_INCLUSAO HISTO (NOLOCK) ON HISTO.ID_REGISTRO = AGEND.SQ_AGENDAMENTO" &
                                                              " AND HISTO.ID_OPT_PROCESSO = " & enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode() &
                " LEFT JOIN TB_PESSOA PESSO_SOLIC (NOLOCK) ON PESSO_SOLIC.SQ_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL_SOLICITANTE" &
               " WHERE CLVND.DH_CANCELAR IS NULL" &
                 " AND CVPCD.ID_CLINICA_VENDA_DEVOLUCAO IS NULL"

    If IsDate(txtDataVendaInicial.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(CLVND.DH_VENDA AS DATE) >= " & FNC_QuotedStr(txtDataVendaInicial.Text), " AND ")
    End If
    If IsDate(txtDataVendaFinal.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(CLVND.DH_VENDA AS DATE) <= " & FNC_QuotedStr(txtDataVendaFinal.Text), " AND ")
    End If
    If ComboBox_Selecionado(cboConvenio) Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.ID_CONVENIO = " & cboConvenio.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboEmpresa) Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.ID_EMPRESA = " & cboEmpresa.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboEspecialidade) Then
      FNC_Str_Adicionar(sSqlText_Where, " AGEND.ID_ESPECIALIDADE = " & cboEspecialidade.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboGrupoProcedimento) Then
      FNC_Str_Adicionar(sSqlText_Where, " PROCE.ID_GRUPOPROCEDIMENTO = " & cboGrupoProcedimento.SelectedValue, " AND ")
    End If
    If psqProcedimento.Identificador > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, " PROCE.SQ_PROCEDIMENTO = " & psqProcedimento.Identificador, " AND ")
    End If
    If ComboBox_Selecionado(cboPlanoContasCredito) Then
      FNC_Str_Adicionar(sSqlText_Where, " GPPRC.ID_PLANOCONTAS = " & cboPlanoContasCredito.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboPlanoContasDebito) Then
      FNC_Str_Adicionar(sSqlText_Where, " GPPRC.ID_PLANOCONTAS_CONTASPAGAR = " & cboPlanoContasDebito.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboProfissionalPrestadorServico) Then
      FNC_Str_Adicionar(sSqlText_Where, " CVPCD.ID_PESSOA_PROFISSIONAL = " & cboProfissionalPrestadorServico.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboCanalMarcacao) Then
      FNC_Str_Adicionar(sSqlText_Where, " CLVND.ID_CANALMARCACAO = " & cboCanalMarcacao.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboCidade) Then
      FNC_Str_Adicionar(sSqlText_Where, " ENDER.ID_CIDADE = " & cboCidade.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboUsuarioMarcacao) Then
      sSqlText = sSqlText & " AND HISTO.ID_USUARIO = " & cboUsuarioMarcacao.SelectedValue
    End If
    If IsDate(txtDataMarcacaoInicial.Text) Then
      sSqlText = sSqlText & " AND CAST(AGEND.DH_INLCUSAO AS DATE) >= " & FNC_QuotedStr(txtDataMarcacaoInicial.Text)
    End If
    If IsDate(txtDataMarcacaoFinal.Text) Then
      sSqlText = sSqlText & " AND CAST(AGEND.DH_INLCUSAO AS DATE) <= " & FNC_QuotedStr(txtDataMarcacaoFinal.Text)
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " AND " & sSqlText_Where
    End If

    sSqlText = sSqlText &
               " ORDER BY CLVND.DH_VENDA," &
                         "PESSO.NO_PESSOA"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_NO_PLANOCONTAS_CR,
                                                           const_GridListagem_NO_PLANOCONTAS_CP,
                                                           const_GridListagem_NO_GRUPOPROCEDIMENTO,
                                                           const_GridListagem_NO_ESPECIALIDADE,
                                                           const_GridListagem_DS_SOLICITANTE,
                                                           const_GridListagem_CD_AGENDAMENTO,
                                                           const_GridListagem_NO_CONVENIO,
                                                           const_GridListagem_NO_EMPREsa,
                                                           const_GridListagem_CD_CLINICA_VENDA,
                                                           const_GridListagem_DH_VENDA,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_NO_BAIRRO,
                                                           const_GridListagem_NO_CIDADE,
                                                           const_GridListagem_CD_CPF_CNPJ,
                                                           const_GridListagem_NO_PROFISSIONAL,
                                                           const_GridListagem_NO_PROCEDIMENTO,
                                                           const_GridListagem_VL_PROCEDIMENTO,
                                                           const_GridListagem_VL_DESCONTO,
                                                           const_GridListagem_VL_LIQUIDO,
                                                           const_GridListagem_VL_REPASSE,
                                                           const_GridListagem_NO_ATENDENTE,
                                                           const_GridListagem_ID_MOVFINANCEIRA,
                                                           const_GridListagem_CanalMarcacao,
                                                           const_GridListagem_DataMarcacao,
                                                           const_GridListagem_UsuarioMarcacao})
    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VL_PROCEDIMENTO,
                                                    const_GridListagem_VL_DESCONTO,
                                                    const_GridListagem_VL_LIQUIDO,
                                                    const_GridListagem_VL_REPASSE})

    lblValorTotalProcedimento.Text = lblValorTotalProcedimento.Tag & " " & FormatCurrency(objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_VL_PROCEDIMENTO))
    lblValorTotalDesconto.Text = lblValorTotalDesconto.Tag & " " & FormatCurrency(objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_VL_DESCONTO))
    lblValorTotalLiquido.Text = lblValorTotalLiquido.Tag & " " & FormatCurrency(objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_VL_LIQUIDO))
    lblValorTotalRepasse.Text = lblValorTotalRepasse.Tag & " " & FormatCurrency(objGrid_CalcularTotalColuna(grdListagem, const_GridListagem_VL_REPASSE))
    lblQuantidadeProcedimento.Text = lblQuantidadeProcedimento.Tag & " " & objGrid_CalcularTotalColuna(grdListagem, const_GridListagemHistoricoCompra_CD_PEDIDO, grdTipoCalculoTotal.QuantidadeLinha)

  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub frmConsultaVendasMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtDataVendaInicial.Value = Now
    txtDataVendaFinal.Value = Now.AddDays(15)
    txtDataMarcacaoInicial.Value = Nothing
    txtDataMarcacaoFinal.Value = Nothing

    ComboBox_Carregar(cboEmpresa, enSql.EmpresaAtiva)
    ComboBox_Carregar(cboConvenio, enSql.Convenio)
    ComboBox_Carregar(cboEspecialidade, enSql.Especialidade)
    ComboBox_Carregar(cboGrupoProcedimento, enSql.GrupoProcedimento)
    ComboBox_Carregar(cboPlanoContasCredito, enSql.PlanoContas_Credito_TodasEmpresa)
    ComboBox_Carregar(cboPlanoContasDebito, enSql.PlanoContas_Debito_TodasEmpresa)
    ComboBox_Carregar(cboCanalMarcacao, enSql.CanalMarcacao)
    ComboBox_Carregar(cboCidade, enSql.Cidade)
    ComboBox_Carregar(cboProfissionalPrestadorServico, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboUsuarioMarcacao, enSql.Atendente)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "Plano de Contas de Crédito", 200)
    objGrid_Coluna_Add(grdListagem, "Plano de Contas de Débito", 200)
    objGrid_Coluna_Add(grdListagem, "Grupo de Procedimento", 200)
    objGrid_Coluna_Add(grdListagem, "Especialidade", 200)
    objGrid_Coluna_Add(grdListagem, "Médico Solicitante", 200)
    objGrid_Coluna_Add(grdListagem, "Cód. Agendamento", 200)
    objGrid_Coluna_Add(grdListagem, "Convênio", 200)
    objGrid_Coluna_Add(grdListagem, "Empresa", 200)
    objGrid_Coluna_Add(grdListagem, "Cód. Venda", 200)
    objGrid_Coluna_Add(grdListagem, "D/H da Venda", 200)
    objGrid_Coluna_Add(grdListagem, "Paciente", 200)
    objGrid_Coluna_Add(grdListagem, "Bairro", 200)
    objGrid_Coluna_Add(grdListagem, "Cidade", 200)
    objGrid_Coluna_Add(grdListagem, "C.P.F./C.N.P.J.", 200)
    objGrid_Coluna_Add(grdListagem, "Profissional", 200)
    objGrid_Coluna_Add(grdListagem, "Procedimento", 200)
    objGrid_Coluna_Add(grdListagem, "Vlr. Procedimento", 200, ,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Vlr. Desconto", 200, ,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Vlr. Líquido", 200, ,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Vlr. Repasse", 200, ,,,, const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Atendente", 200)
    objGrid_Coluna_Add(grdListagem, "ID_MOVFINANCEIRA", 0)
    objGrid_Coluna_Add(grdListagem, "Canal de Marcação", 100)
    objGrid_Coluna_Add(grdListagem, "Data de Marcação", 100,,,,, const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Usuário de Marcação", 100)
  End Sub

  Private Sub ComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEmpresa.KeyDown,
                                                                            cboUsuarioMarcacao.KeyDown,
                                                                            cboCanalMarcacao.KeyDown,
                                                                            cboCidade.KeyDown,
                                                                            cboConvenio.KeyDown,
                                                                            cboEspecialidade.KeyDown,
                                                                            cboGrupoProcedimento.KeyDown,
                                                                            cboPlanoContasCredito.KeyDown,
                                                                            cboPlanoContasDebito.KeyDown,
                                                                            cboProfissionalPrestadorServico.KeyDown
    If e.KeyCode = Keys.Delete Then
      Dim oComboBox As New ComboBox

      oComboBox = sender

      oComboBox.SelectedIndex = -1
    End If
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    txtDataVendaInicial.Value = Now
    txtDataVendaFinal.Value = Now.AddDays(15)
    txtDataMarcacaoInicial.Value = Nothing
    txtDataMarcacaoFinal.Value = Nothing

    cboEmpresa.SelectedIndex = -1
    cboConvenio.SelectedIndex = -1
    cboEspecialidade.SelectedIndex = -1
    cboGrupoProcedimento.SelectedIndex = -1
    cboPlanoContasCredito.SelectedIndex = -1
    cboPlanoContasDebito.SelectedIndex = -1
    cboCanalMarcacao.SelectedIndex = -1
    cboCidade.SelectedIndex = -1
    cboProfissionalPrestadorServico.SelectedIndex = -1
    cboUsuarioMarcacao.SelectedIndex = -1
    psqProcedimento.Identificador = 0

    lblValorTotalProcedimento.Text = lblValorTotalProcedimento.Tag
    lblValorTotalDesconto.Text = lblValorTotalDesconto.Tag
    lblValorTotalLiquido.Text = lblValorTotalLiquido.Tag
    lblQuantidadeProcedimento.Text = lblQuantidadeProcedimento.Tag
  End Sub
End Class