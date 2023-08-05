Public Class frmCadastroCondicaoPagamento
  Public Event Pesquisar()

  Public iSQ_CONDICAOPAGAMENTO As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If txtCodigo.Text.Trim() = "" Then
      FNC_Mensagem("Informe o código da condição de pagamento")
      Exit Sub
    End If
    If txtNome.Text.Trim() = "" Then
      FNC_Mensagem("Informe o nome da condição de pagamento")
      Exit Sub
    End If
    If Not chkParcelamento.Checked Then
      If Not ComboBox_Selecionado(cboTipoDocumentoParaPagamentoUnicoEntrada) Then
        FNC_Mensagem("Selecione o Tipo de Documento para pagamento único ou entrada")
        Exit Sub
      End If
      If Not ComboBox_Selecionado(cboFormaPagamentoParaPagamentoUnicoEntrada) Then
        FNC_Mensagem("Selecione a forma de pagamento padrão para pagamento único ou entrada")
        Exit Sub
      End If
    End If
    If chkParcelamento.Checked Then
      If Not ComboBox_Selecionado(cboTipoDocumentoParcelamento) Then
        FNC_Mensagem("Selecione o Tipo de Documento padrão para parcelas")
        Exit Sub
      End If
      If Not ComboBox_Selecionado(cboFormaPagamentoParcelamento) Then
        FNC_Mensagem("Selecione a forma de pagamento padrão para parcelas")
        Exit Sub
      End If
      If txtQtdeParcela.Value < 1 Then
        FNC_Mensagem("É preciso informar a quantidade de parcelas")
        Exit Sub
      End If
      If txtNrDiaIntervalo.Value < 1 Then
        FNC_Mensagem("É preciso informar o número de dias de intervalo entre parcelas")
        Exit Sub
      End If
      If chkGerarParcelaAVista.Checked And txtPercEntrada.Value <> 0 Then
        FNC_Mensagem("Não é permitido informar 'Entrada (%)' e 'Gerar Parcela A Vista'")
        Exit Sub
      End If
    Else
      If ComboBox_Selecionado(cboFormaPagamentoParcelamento) Or
         txtQtdeParcela.Value > 0 Then
        If Not FNC_Perguntar("Está desmarcado 'Parcelamento' e existe dados de parcelamento informados. Se continuar os mesmos serão pertidos. Deseja continuar?") Then Exit Sub
      End If

      cboFormaPagamentoParcelamento.SelectedIndex = -1
      txtQtdeParcela.Value = 0
      txtDiasPrimeiraParcela.Value = 0
      txtNrDiaIntervalo.Value = 0
      txtPercAcrescimento.Value = 0
      txtPercEntrada.Value = 0
      uscCalculoFinanceiro_Juros.Valor = 0
      chkGerarParcelaAVista.Checked = False
    End If

    Dim sSqlText As String

    sSqlText = "SELECT COUNT(*) FROM TB_CONDICAOPAGAMENTO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND UPPER(RTRIM(CD_CONDICAOPAGAMENTO)) = " & FNC_QuotedStr(txtCodigo.Text.Trim.ToUpper()) &
                 " AND SQ_CONDICAOPAGAMENTO NOT IN (" & iSQ_CONDICAOPAGAMENTO & ")"
    If DBQuery_ValorUnico(sSqlText) > 0 Then
      FNC_Mensagem("Código já informado para outra Condição de Pagamento")
      Exit Sub
    End If
    sSqlText = "SELECT COUNT(*) FROM TB_CONDICAOPAGAMENTO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND UPPER(RTRIM(NO_CONDICAOPAGAMENTO)) = " & FNC_QuotedStr(txtNome.Text.Trim.ToUpper()) &
                 " AND SQ_CONDICAOPAGAMENTO NOT IN (" & iSQ_CONDICAOPAGAMENTO & ")"
    If DBQuery_ValorUnico(sSqlText) > 0 Then
      FNC_Mensagem("Código já informado para outra Condição de Pagamento")
      Exit Sub
    End If

    sSqlText = DBMontar_SP("SP_CONDICAOPAGAMENTO_CAD", False, "@SQ_CONDICAOPAGAMENTO OUT",
                                                              "@ID_EMPRESA",
                                                              "@ID_TIPO_DOCUMENTO_ENTRADA_PADRAO",
                                                              "@ID_TIPO_DOCUMENTO_PARCELA_PADRAO",
                                                              "@ID_FORMAPAGAMENTO_ENTRADA_PADRAO",
                                                              "@ID_FORMAPAGAMENTO_PARCELA_PADRAO",
                                                              "@ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS",
                                                              "@CD_CONDICAOPAGAMENTO",
                                                              "@NO_CONDICAOPAGAMENTO",
                                                              "@QT_PARCELA",
                                                              "@QT_PARCELA_DIASPRIMEIRAPARCELA",
                                                              "@QT_PARCELA_DIASINTERVALO",
                                                              "@PC_ACRESCIMO",
                                                              "@PC_ENTRADA",
                                                              "@PC_JUROS",
                                                              "@PC_TAXA_COMPENSACAO",
                                                              "@IC_GERAR_AVISTA",
                                                              "@IC_USAR_RECEBIMENTO",
                                                              "@IC_USAR_VENDA",
                                                              "@IC_ATIVO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CONDICAOPAGAMENTO", iSQ_CONDICAOPAGAMENTO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_TIPO_DOCUMENTO_ENTRADA_PADRAO", cboTipoDocumentoParaPagamentoUnicoEntrada.SelectedValue),
                            DBParametro_Montar("ID_TIPO_DOCUMENTO_PARCELA_PADRAO", cboTipoDocumentoParcelamento.SelectedValue),
                            DBParametro_Montar("ID_FORMAPAGAMENTO_ENTRADA_PADRAO", cboFormaPagamentoParaPagamentoUnicoEntrada.SelectedValue),
                            DBParametro_Montar("ID_FORMAPAGAMENTO_PARCELA_PADRAO", cboFormaPagamentoParcelamento.SelectedValue),
                            DBParametro_Montar("ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS", uscCalculoFinanceiro_Juros.PeriodoCalculoFinanceiro),
                            DBParametro_Montar("CD_CONDICAOPAGAMENTO", txtCodigo.Text.Trim()),
                            DBParametro_Montar("NO_CONDICAOPAGAMENTO", txtNome.Text.Trim()),
                            DBParametro_Montar("QT_PARCELA", txtQtdeParcela.Value),
                            DBParametro_Montar("QT_PARCELA_DIASPRIMEIRAPARCELA", txtDiasPrimeiraParcela.Value),
                            DBParametro_Montar("QT_PARCELA_DIASINTERVALO", txtNrDiaIntervalo.Value),
                            DBParametro_Montar("PC_ACRESCIMO", txtPercAcrescimento.Value),
                            DBParametro_Montar("PC_ENTRADA", txtPercEntrada.Value),
                            DBParametro_Montar("PC_JUROS", uscCalculoFinanceiro_Juros.Valor),
                            DBParametro_Montar("PC_TAXA_COMPENSACAO", txtTaxaCompensacao.Value),
                            DBParametro_Montar("IC_GERAR_AVISTA", IIf(chkGerarParcelaAVista.Checked, "S", "N")),
                            DBParametro_Montar("IC_USAR_RECEBIMENTO", IIf(chkUsarRecebimento.Checked, "S", "N")),
                            DBParametro_Montar("IC_USAR_VENDA", IIf(chkUsarVenda.Checked, "S", "N")),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_CONDICAOPAGAMENTO = DBRetorno(1)
      End If

      RaiseEvent Pesquisar()

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub chkParcelamento_CheckedChanged(sender As Object, e As EventArgs) Handles chkParcelamento.CheckedChanged
    grpParcelamento.Enabled = chkParcelamento.Checked
  End Sub

  Private Sub frmCadastroCondicaoPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboFormaPagamentoParaPagamentoUnicoEntrada, enSql.FormaPagamento)
    ComboBox_Carregar(cboFormaPagamentoParcelamento, enSql.FormaPagamento)
    ComboBox_Carregar(cboTipoDocumentoParcelamento, enSql.TipoDocumento, New Object() {enOpcoes.TipoUtilizacaoLançamentoFinanceiro_UsarLancamento.GetHashCode()})
    ComboBox_Carregar(cboTipoDocumentoParaPagamentoUnicoEntrada, enSql.TipoDocumento, New Object() {enOpcoes.TipoUtilizacaoLançamentoFinanceiro_UsarLancamento.GetHashCode()})
    chkParcelamento.Checked = False

    cmdNovo.Enabled = FNC_Permissao(enPermissao.FINA_CondicaoPagamento).bIncluir
    cmdGravar.Enabled = FNC_Permissao(enPermissao.FINA_CondicaoPagamento).bGravar

    uscCalculoFinanceiro_Juros.Inicializar()

    If iSQ_CONDICAOPAGAMENTO > 0 Then CarregarDados()
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM TB_CONDICAOPAGAMENTO WHERE SQ_CONDICAOPAGAMENTO = " & iSQ_CONDICAOPAGAMENTO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      txtCodigo.Text = .Item("CD_CONDICAOPAGAMENTO")
      txtNome.Text = .Item("NO_CONDICAOPAGAMENTO")
      ComboBox_Selecionar(cboFormaPagamentoParaPagamentoUnicoEntrada, .Item("ID_FORMAPAGAMENTO_ENTRADA_PADRAO"))
      ComboBox_Selecionar(cboTipoDocumentoParaPagamentoUnicoEntrada, .Item("ID_TIPO_DOCUMENTO_ENTRADA_PADRAO"))
      uscCalculoFinanceiro_Juros.PeriodoCalculoFinanceiro = FNC_NVL(.Item("ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS"), 0)
      chkUsarRecebimento.Checked = (FNC_NVL(.Item("IC_USAR_RECEBIMENTO"), "N") = "S")
      chkUsarVenda.Checked = (FNC_NVL(.Item("IC_USAR_VENDA"), "N") = "S")
      chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "N") = "S")
      chkParcelamento.Checked = (Not FNC_CampoNulo(.Item("ID_FORMAPAGAMENTO_PARCELA_PADRAO")))
      ComboBox_Selecionar(cboFormaPagamentoParcelamento, .Item("ID_FORMAPAGAMENTO_PARCELA_PADRAO"))
      ComboBox_Selecionar(cboTipoDocumentoParcelamento, .Item("ID_TIPO_DOCUMENTO_PARCELA_PADRAO"))
      txtQtdeParcela.Value = FNC_NVL(.Item("QT_PARCELA"), 0)
      txtDiasPrimeiraParcela.Value = FNC_NVL(.Item("QT_PARCELA_DIASPRIMEIRAPARCELA"), 0)
      txtNrDiaIntervalo.Value = FNC_NVL(.Item("QT_PARCELA_DIASINTERVALO"), 0)
      txtPercAcrescimento.Value = FNC_NVL(.Item("PC_ACRESCIMO"), 0)
      txtPercEntrada.Value = FNC_NVL(.Item("PC_ENTRADA"), 0)
      uscCalculoFinanceiro_Juros.Valor = FNC_NVL(.Item("PC_JUROS"), 0)
      txtTaxaCompensacao.Value = FNC_NVL(.Item("PC_TAXA_COMPENSACAO"), 0)
      chkGerarParcelaAVista.Checked = (FNC_NVL(.Item("IC_GERAR_AVISTA"), "N") = "S")

      grpParcelamento.Enabled = chkParcelamento.Checked
    End With
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    iSQ_CONDICAOPAGAMENTO = 0

    txtCodigo.Text = ""
    txtNome.Text = ""
    cboFormaPagamentoParaPagamentoUnicoEntrada.SelectedIndex = -1
    chkUsarRecebimento.Checked = False
    chkUsarVenda.Checked = False
    chkAtivo.Checked = False
    chkParcelamento.Checked = False
    cboFormaPagamentoParcelamento.SelectedIndex = -1
    txtQtdeParcela.Value = 0
    txtDiasPrimeiraParcela.Value = 0
    txtNrDiaIntervalo.Value = 0
    optTipoInvervalo_Livre.Checked = True
    txtPercAcrescimento.Value = 0
    txtPercEntrada.Value = 0
    uscCalculoFinanceiro_Juros.Valor = 0
    chkGerarParcelaAVista.Checked = False
  End Sub

  Private Sub optTipoInvervalo_CheckedChanged(sender As Object, e As EventArgs) Handles optTipoInvervalo_Livre.CheckedChanged,
                                                                                        optTipoInvervalo_Semana.CheckedChanged,
                                                                                        optTipoInvervalo_Quizena.CheckedChanged,
                                                                                        optTipoInvervalo_Mensal.CheckedChanged,
                                                                                        optTipoInvervalo_Trimestre.CheckedChanged,
                                                                                        optTipoInvervalo_Semestre.CheckedChanged,
                                                                                        optTipoInvervalo_Ano.CheckedChanged
    txtNrDiaIntervalo.Value = sender.Tag
    txtNrDiaIntervalo.Enabled = optTipoInvervalo_Livre.Checked
  End Sub
End Class