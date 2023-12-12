Public Class frmLancaContasReceberPagar_Compensacao
  Public Event Pesquisar()

  Public cSQ_MOVFINANCEIRAPARCELA = New Collection
  Public cSQ_PAGAMENTOITEM = New Collection
  Public iSQ_MOVFINANCEIRAPARCELA As Integer
  Public iSQ_PAGAMENTOITEM As Integer

  Class cMOVFINANCEIRAPARCELA
    Public SQ_MOVFINANCEIRAPARCELA As Integer
    Public VL_PARCELA As Double
    Public VL_TAXA_COMPENSACAO As Double
  End Class
  Class cPAGAMENTOITEM
    Public SQ_PAGAMENTOITEM As Integer
    Public VL_PAGAMENTO As Double
  End Class

  Public MOVFINANCEIRAPARCELA As cMOVFINANCEIRAPARCELA()
  Public PAGAMENTOITEM As cPAGAMENTOITEM()
  Dim Indice As Integer = 0

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmLancaContasReceberPagar_Compensacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim sSqlText As String

    ComboBox_Carregar(cboContaFinanceira, enSql.ContaFinanceira)
    ComboBox_Carregar(cboContaFinanceiraTaxaCompensacao, enSql.ContaFinanceira)

    txtDataCompensacao.Value = Now.Date()
    txtValorCompensacao.Value = 0

    If iSQ_MOVFINANCEIRAPARCELA > 0 And Not FNC_Collection_Preenchido(cSQ_MOVFINANCEIRAPARCELA) Then
      If iEMPRESA_ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO = 0 Then
        FNC_Mensagem("É preciso cadastrar o plano de contas padrão para a taxa de compensação para essa empresa")
        cmdGravar.Enabled = False
        Exit Sub
      End If

      cSQ_MOVFINANCEIRAPARCELA = New Collection()
      cSQ_MOVFINANCEIRAPARCELA.Add(iSQ_MOVFINANCEIRAPARCELA)
    End If

    If FNC_Collection_Preenchido(cSQ_MOVFINANCEIRAPARCELA) Then
      ReDim MOVFINANCEIRAPARCELA(cSQ_MOVFINANCEIRAPARCELA.Count - 1)

      For Each Item As Object In cSQ_MOVFINANCEIRAPARCELA
        sSqlText = "SELECT * FROM VW_MOVFINANCEIRAPARCELA WHERE SQ_MOVFINANCEIRAPARCELA = " & Item.ToString()
        CompensacaoDados(sSqlText)
      Next
    ElseIf FNC_Collection_Preenchido(cSQ_PAGAMENTOITEM) Then
      ReDim PAGAMENTOITEM(cSQ_PAGAMENTOITEM.Count - 1)

      For Each Item As Object In cSQ_PAGAMENTOITEM
        sSqlText = "SELECT * FROM VW_PAGAMENTOITEM WHERE SQ_PAGAMENTOITEM = " & Item.ToString()
        CompensacaoDados(sSqlText)
      Next
    Else
      sSqlText = "SELECT * FROM VW_PAGAMENTOITEM WHERE SQ_PAGAMENTOITEM = " & iSQ_PAGAMENTOITEM
      CompensacaoDados(sSqlText)
    End If

    cmdExcluir.Enabled = FNC_Permissao(enPermissao.FINA_Compensacao).bGravar
    cmdGravar.Enabled = FNC_Permissao(enPermissao.FINA_Compensacao).bGravar

    TextBox_FormatarCampoTexto(txtComentario)
  End Sub

  Private Sub CompensacaoDados(sSqlText As String)
    Dim oData As DataTable

    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        If iSQ_PAGAMENTOITEM > 0 Or PAGAMENTOITEM.Count > 0 Then
          ComboBox_Selecionar(cboContaFinanceira, FNC_NVL(.Item("ID_CONTAFINANCEIRA"), 0))
        Else
          ComboBox_Selecionar(cboContaFinanceira, FNC_NVL(.Item("ID_CONTAFINANCEIRA_CREDITO"), 0))
        End If

        If Not FNC_CampoNulo(.Item("DT_COMPENSACAO")) Then
          txtDataCompensacao.Value = .Item("DT_COMPENSACAO")
        End If

        lblRTipoDocumento.Text = .Item("NO_TIPO_DOCUMENTO")

        If iSQ_PAGAMENTOITEM > 0 Then
          txtValorCompensacao.Value = FNC_NVL(.Item("VL_PAGAMENTO"), 0)
        ElseIf cSQ_PAGAMENTOITEM.Count > 0 Then
          PAGAMENTOITEM(Indice) = New cPAGAMENTOITEM()
          PAGAMENTOITEM(Indice).SQ_PAGAMENTOITEM = .Item("SQ_PAGAMENTOITEM")
          PAGAMENTOITEM(Indice).VL_PAGAMENTO = .Item("VL_PAGAMENTO")
          Indice = Indice + 1
          txtValorCompensacao.Value = txtValorCompensacao.Value + FNC_NVL(.Item("VL_PAGAMENTO"), 0)
        Else
          MOVFINANCEIRAPARCELA(Indice) = New cMOVFINANCEIRAPARCELA()
          MOVFINANCEIRAPARCELA(Indice).SQ_MOVFINANCEIRAPARCELA = .Item("SQ_MOVFINANCEIRAPARCELA")
          MOVFINANCEIRAPARCELA(Indice).VL_PARCELA = .Item("VL_PARCELA")
          MOVFINANCEIRAPARCELA(Indice).VL_TAXA_COMPENSACAO = .Item("VL_TAXA_COMPENSACAO")
          Indice = Indice + 1
          txtValorCompensacao.Value = txtValorCompensacao.Value + FNC_NVL(.Item("VL_PARCELA"), 0)
        End If

        If FNC_NVL(.Item("IC_COMPENSADO"), "N") = "S" Then
          txtDataCompensacao.ReadOnly = True
          cboContaFinanceira.Enabled = False

          cmdGravar.Enabled = False
        Else
          cmdExcluir.Enabled = False
        End If
      End With
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboContaFinanceira) Then
      FNC_Mensagem("Selecione a conta financeira")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboContaFinanceiraTaxaCompensacao) Then
      FNC_Mensagem("Selecione a conta financeira da taxa de compensação")
      Exit Sub
    End If
    If Not IsDate(txtDataCompensacao.Text) Then
      FNC_Mensagem("Informe a data de compensação")
      Exit Sub
    End If

    Dim bOk As Boolean
    Dim dVL_TAXA_COMPENSACAO As Double

    If iSQ_PAGAMENTOITEM > 0 Then
      bOk = FormPagamento_Compensacao_Gravar(iSQ_PAGAMENTOITEM,
                                             FNC_NVL(cboContaFinanceira.SelectedValue, 0),
                                             enOpcoes.StatusPagamentoItem_Quitado.GetHashCode(),
                                             txtDataCompensacao.Value,
                                             txtValorCompensacao.Value,
                                             Trim(txtComentario.Text))
    ElseIf PAGAMENTOITEM.Count > 0 Then
      For Each Item As cPAGAMENTOITEM In PAGAMENTOITEM
        bOk = FormPagamento_Compensacao_Gravar(Item.SQ_PAGAMENTOITEM,
                                               FNC_NVL(cboContaFinanceira.SelectedValue, 0),
                                               enOpcoes.StatusPagamentoItem_Quitado.GetHashCode(),
                                               txtDataCompensacao.Value,
                                               Item.VL_PAGAMENTO,
                                               Trim(txtComentario.Text))
      Next
    Else
      For Each Item As cMOVFINANCEIRAPARCELA In MOVFINANCEIRAPARCELA
        dVL_TAXA_COMPENSACAO = dVL_TAXA_COMPENSACAO + Item.VL_TAXA_COMPENSACAO
        bOk = FormMovimentacaoFinanceira_Compensacao_Gravar(Item.SQ_MOVFINANCEIRAPARCELA,
                                                            cboContaFinanceiraTaxaCompensacao.SelectedValue,
                                                            txtDataCompensacao.Value,
                                                            Item.VL_PARCELA,
                                                            Trim(txtComentario.Text))
      Next
    End If

    If dVL_TAXA_COMPENSACAO > 0 Then
      Dim iSQ_MOVFINANCEIRA As Integer
      Dim sSqlText As String

      If FormCadastroMovimentacaoFinanceira(iSQ_MOVFINANCEIRA:=iSQ_MOVFINANCEIRA,
                                            eID_OPT_TIPOMOVFINANCEIRA:=enOpcoes.TipoMovimentacaoFinanceiraContas_ContaBancaria_Debito.GetHashCode(),
                                            eID_OPT_STATUS:=enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode(),
                                            eID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO:=0,
                                            eID_OPT_PERIODOCALCULOFINANCEIRO_JUROS:=0,
                                            iID_PESSOA:=0,
                                            iID_CONTAFINANCERIA_CREDITO:=0,
                                            iID_CONTAFINANCERIA_DEBITO:=cboContaFinanceiraTaxaCompensacao.SelectedValue,
                                            iID_DOCUMENTOFISCAL:=0,
                                            iID_PEDIDO:=0,
                                            iID_ORDEMSERVICO:=0,
                                            iID_SEGMENTO:=0,
                                            iID_CONDICAOPAGAMENTO:=0,
                                            iID_CLINICA_VENDA:=0,
                                            iID_CONVENIO:=0,
                                            sDS_MOVFINANCEIRA:=txtComentario.Text,
                                            dVL_MOVFINANCEIRA:=dVL_TAXA_COMPENSACAO,
                                            dVL_ORIGINAL:=dVL_TAXA_COMPENSACAO,
                                            dVL_DESCONTO:=0,
                                            dDT_MOVIMENTACAO:=txtDataCompensacao.Value,
                                            dDT_1_VENCIMENTO:=txtDataCompensacao.Value,
                                            dPC_ENTRADA:=0,
                                            dPC_JUROS:=0,
                                            dPC_DESCONTO:=0,
                                            dVL_MULTA:=0,
                                            dPC_MULTA:=0,
                                            sCM_MOVFINANCEIRA:=txtComentario.Text) Then
        If FormCadastroMovimentacaoFinanceiraParcela(iSQ_MOVFINANCEIRAPARCELA:=iSQ_MOVFINANCEIRAPARCELA,
                                                     iID_MOVFINANCEIRA:=iSQ_MOVFINANCEIRA,
                                                     eID_OPT_STATUS:=enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode(),
                                                     iID_TIPO_DOCUMENTO:=const_TipoDocumento_Dinheiro,
                                                     iID_MOVFINANCEIRAPARCELAORIGEM:=0,
                                                     iID_DOCUMENTOFINANCEIRO:=0,
                                                     iID_FORMAPAGAMENTO_PREFERENCIAL:=0,
                                                     iID_CONDICAOPAGAMENTO:=0,
                                                     sCD_PARCELA:="001/001",
                                                     sCD_DOCUMENTO:="",
                                                     sCM_DOCUMENTO:=Nothing,
                                                     sDS_EMITENTE:=Nothing,
                                                     dDT_VENCIMENTO:=txtDataCompensacao.Value,
                                                     dDT_QUITACAO:=txtDataCompensacao.Value,
                                                     dVL_PARCELA:=dVL_TAXA_COMPENSACAO,
                                                     dVL_JUROS:=0,
                                                     dVL_DESCONTO:=0,
                                                     dVL_QUITADO:=dVL_TAXA_COMPENSACAO,
                                                     dVL_PROVISAO:=0,
                                                     dPC_TAXA_COMPENSACAO:=0,
                                                     dVL_IMPOSTORETIDO:=0) Then
          FormMovimentacaoFinanceira_Compensacao_Gravar(iSQ_MOVFINANCEIRAPARCELA, cboContaFinanceiraTaxaCompensacao.SelectedValue, txtDataCompensacao.Value, dVL_TAXA_COMPENSACAO, "")

          sSqlText = DBMontar_SP("SP_MOVFINANCEIRA_PLANOCONTAS_CAD", False, "@ID_MOVFINANCEIRA",
                                                                            "@ID_PLANOCONTAS",
                                                                            "@ID_OPT_CREDITODEBITO",
                                                                            "@PC_PARTICIPACAO",
                                                                            "@CM_PARTICIPACAO")

          DBExecutar(sSqlText, DBParametro_Montar("ID_MOVFINANCEIRA", iSQ_MOVFINANCEIRA),
                               DBParametro_Montar("ID_PLANOCONTAS", iEMPRESA_ID_PLANOCONTAS_PADRAO_TAXA_COMPENSACAO),
                               DBParametro_Montar("ID_OPT_CREDITODEBITO", enOpcoes.CreditoDebito_Debito.GetHashCode),
                               DBParametro_Montar("PC_PARTICIPACAO", 100),
                               DBParametro_Montar("CM_PARTICIPACAO", ""))
        End If
      End If
    End If

    If bOk Then
      RaiseEvent Pesquisar()

      FNC_Mensagem("Gravação Efetuada")
      cmdGravar.Enabled = False
    End If
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    Dim sSqlText As String
    Dim bOk As Boolean

    If Not IsDate(txtDataCompensacao.Text) Then
      FNC_Mensagem("Informe a data de compensação")
      Exit Sub
    End If
    If Trim(txtComentario.Text) = "" Then
      FNC_Mensagem("Na exclusão de uma compensação é necessário um comentário sobre a ação")
      Exit Sub
    End If

    If iSQ_MOVFINANCEIRAPARCELA > 0 Then
      sSqlText = DBMontar_SP("SP_MOVFINANCEIRAPARCELA_COMPENSACAO_DEL", False, "@SQ_MOVFINANCEIRAPARCELA", _
                                                                               "@VL_COMPENSACAO", _
                                                                               "@CM_COMPENSACAO")

      bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_MOVFINANCEIRAPARCELA", iSQ_MOVFINANCEIRAPARCELA),
                                 DBParametro_Montar("VL_COMPENSACAO", txtValorCompensacao.Value),
                                 DBParametro_Montar("CM_COMPENSACAO", Trim(txtComentario.Text),,, const_BancoDados_TamanhoComentario))
    Else
      sSqlText = DBMontar_SP("SP_PAGAMENTO_COMPENSACAO_DEL", False, "@SQ_PAGAMENTOITEM", _
                                                                    "@VL_COMPENSACAO", _
                                                                    "@CM_COMPENSACAO")

      bOk = DBExecutar(sSqlText, DBParametro_Montar("SQ_PAGAMENTOITEM", iSQ_PAGAMENTOITEM),
                                 DBParametro_Montar("VL_COMPENSACAO", txtValorCompensacao.Value),
                                 DBParametro_Montar("CM_COMPENSACAO", Trim(txtComentario.Text),,, const_BancoDados_TamanhoComentario))
    End If

    If bOk Then
      RaiseEvent Pesquisar()

      FNC_Mensagem("Exclusão Efetuada")
      cmdExcluir.Enabled = False
    End If
  End Sub
End Class