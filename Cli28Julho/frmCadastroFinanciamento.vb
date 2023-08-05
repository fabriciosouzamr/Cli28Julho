Public Class frmCadastroFinanciamento
  Public Event Pesquisar()

  Public iSQ_FINANCIAMENTO As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroFinanciamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboModeloContrato, enSql.ModeloDocumento_Contrato)
    ListBox_Carregar(cklTabelaPreco, enSql.TabelaPreco)
    psqFinanciador.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Juridica_E_Empresa
    psqFinanciador.AdicionarPessoa = True

    chkAtivo.Checked = True

    cmdGravar.Enabled = FNC_Permissao(enPermissao.FINA_Financiamento).bGravar

    If iSQ_FINANCIAMENTO > 0 Then
      CarregarDados()
    End If
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer

    sSqlText = "SELECT * FROM TB_FINANCIAMENTO WHERE SQ_FINANCIAMENTO = " & iSQ_FINANCIAMENTO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      txtNomeFinanciamento.Text = .Item("NO_FINANCIAMENTO")
      psqFinanciador.ID_Pessoa = .Item("ID_FINANCIADOR")
      ComboBox_Selecionar(cboModeloContrato, FNC_NVL(.Item("ID_MODELODOCUMENTO_CONTRATO"), 0))
      txtPercEntrada.Value = FNC_NVL(.Item("PC_ENTRADA"), 0)
      txtJurosMes.Value = FNC_NVL(.Item("PC_JUROS"), 0)
      txtMininoParcela.Value = FNC_NVL(.Item("NR_MINIMO_PARCELA"), 0)
      txtMaximoParcela.Value = FNC_NVL(.Item("NR_MAXIMO_PARCELA"), 0)
      chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "N") = "S")
    End With

    sSqlText = "SELECT * FROM TB_FINANCIAMENTO_TABELAPRECO WHERE ID_FINANCIAMENTO = " & iSQ_FINANCIAMENTO
    oData = DBQuery(sSqlText)

    For iCont_01 = 0 To oData.Rows.Count - 1
      For iCont_02 = 0 To cklTabelaPreco.Items.Count - 1
        If oData.Rows(iCont_01).Item("ID_TABELAPRECO") = cklTabelaPreco.Items(iCont_02)(0) Then
          cklTabelaPreco.SetItemChecked(iCont_02, True)
          Exit For
        End If
      Next
    Next
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String
    Dim iCont As Integer

    If Trim(txtNomeFinanciamento.Text) = "" Then
      FNC_Mensagem("Nome do financiamento")
      Exit Sub
    End If
    If psqFinanciador.ID_Pessoa = 0 Then
      FNC_Mensagem("Nome da financiadora")
      Exit Sub
    End If
    If txtMininoParcela.Value < 1 Then
      FNC_Mensagem("Informe um número igual ou maior que 1 para o mínimo de parcela")
      Exit Sub
    End If
    If txtMaximoParcela.Value < txtMininoParcela.Value Then
      FNC_Mensagem("O máximo de parcela não pode ser menor que o mínino de parcela")
      Exit Sub
    End If

    sSqlText = DBMontar_SP("SP_FINANCIAMENTO_CAD", False, "@SQ_FINANCIAMENTO OUT",
                                                          "@ID_EMPRESA",
                                                          "@ID_FINANCIADOR",
                                                          "@ID_MODELODOCUMENTO_CONTRATO",
                                                          "@NO_FINANCIAMENTO",
                                                          "@NR_MINIMO_PARCELA",
                                                          "@NR_MAXIMO_PARCELA",
                                                          "@PC_ENTRADA",
                                                          "@PC_JUROS",
                                                          "@IC_ATIVO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_FINANCIAMENTO", iSQ_FINANCIAMENTO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_FINANCIADOR", psqFinanciador.ID_Pessoa),
                            DBParametro_Montar("ID_MODELODOCUMENTO_CONTRATO", cboModeloContrato.SelectedValue),
                            DBParametro_Montar("NO_FINANCIAMENTO", txtNomeFinanciamento.Text.Trim()),
                            DBParametro_Montar("NR_MINIMO_PARCELA", txtMininoParcela.Value),
                            DBParametro_Montar("NR_MAXIMO_PARCELA", txtMaximoParcela.Value),
                            DBParametro_Montar("PC_ENTRADA", FNC_NVL(txtPercEntrada.Value, 0)),
                            DBParametro_Montar("PC_JUROS", FNC_NVL(txtJurosMes.Value, 0)),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_FINANCIAMENTO = DBRetorno(1)
      End If

      For iCont = 0 To cklTabelaPreco.Items.Count - 1
        If cklTabelaPreco.GetItemChecked(iCont) Then
          sSqlText = DBMontar_SP("SP_FINANCIAMENTO_TABELAPRECO_CAD", False, "@ID_FINANCIAMENTO",
                                                                            "@ID_TABELAPRECO")
        Else
          sSqlText = DBMontar_SP("SP_FINANCIAMENTO_TABELAPRECO_DEL", False, "@ID_FINANCIAMENTO",
                                                                            "@ID_TABELAPRECO")
        End If

        DBExecutar(sSqlText, DBParametro_Montar("ID_FINANCIAMENTO", iSQ_FINANCIAMENTO),
                             DBParametro_Montar("ID_TABELAPRECO", cklTabelaPreco.Items(iCont)(0)))
      Next
    End If

    RaiseEvent Pesquisar()

    FNC_Mensagem("Gravação Efetuada")
  End Sub
End Class