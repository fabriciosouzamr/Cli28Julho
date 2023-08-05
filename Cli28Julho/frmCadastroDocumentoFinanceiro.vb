Public Class frmCadastroDocumentoFinanceiro
  Public iSQ_DOCUMENTOFINANCEIRO As Integer
  Public iSQ_TIPO_DOCUMENTO As Integer
  Public dVL_DOCUMENTO As Double
  Public bFecharTela As Boolean

  Private Sub frmCadastroDocumentoFinanceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboTipoDocumento, enSql.TipoDocumento)
    ComboBox_Carregar(cboBanco, enSql.Banco)
    ComboBox_Carregar(cboStatus, enSql.StatusDocumentoFinanceiro)

    ComboBox_Selecionar(cboStatus, enOpcoes.StatusDocumentoFinanceiro_Cadastrado.GetHashCode)
    ComboBox_Selecionar(cboTipoDocumento, iSQ_TIPO_DOCUMENTO)
    cboTipoDocumento.Enabled = (iSQ_TIPO_DOCUMENTO = 0)
    txtValorDocumento.Value = dVL_DOCUMENTO
    txtValorDocumento.Enabled = (dVL_DOCUMENTO = 0)

    If iSQ_DOCUMENTOFINANCEIRO = 0 Then
      cboStatus.Enabled = False
    Else
      CarregarDados()
    End If
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM TB_DOCUMENTOFINANCEIRO WHERE SQ_DOCUMENTOFINANCEIRO = " & iSQ_DOCUMENTOFINANCEIRO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        ComboBox_Selecionar(cboTipoDocumento, .Item("ID_TIPODOCUMENTO"))
        ComboBox_Selecionar(cboStatus, .Item("ID_OPT_STATUS"))
        ComboBox_Selecionar(cboBanco, .Item("ID_BANCO"))
        psqEmitente.ID_Pessoa = FNC_NVL(.Item("ID_EMITENTE"), 0)
        txtDataEmissao.Value = .Item("DT_DOCUMENTO")
        txtDataVencimento.Value = .Item("DT_VENCIMENTO")
        If Not FNC_CampoNulo(.Item("DS_EMITENTE")) And FNC_CampoNulo(.Item("ID_EMITENTE")) Then
          psqEmitente.DS_Pessoa = .Item("DS_EMITENTE")
        End If
        txtNrAgencia.Value = FNC_NVL(.Item("NR_BANCO_AGENCIA"), 0)
        txtNrConta.Value = FNC_NVL(.Item("NR_BANCO_CONTA"), 0)
        txtNrContaDigito.Value = FNC_NVL(.Item("NR_BANCO_CONTA_DIGITO"), 0)
        txtCodigoDocumento.Text = FNC_NVL(.Item("CD_DOCUMENTO"), "")
        txtDescricaoDocumento.Text = FNC_NVL(.Item("DS_DOCUMENTO"), "")
        txtValorDocumento.Value = FNC_NVL(.Item("VL_DOCUMENTO"), 0)
        txtSaldoDisponivel.Value = FNC_NVL(.Item("VL_SALDO"), 0)

        txtValorDocumento.ReadOnly = (txtSaldoDisponivel.Value > 0)
        cboStatus.Enabled = (txtSaldoDisponivel.Value = 0)
      End With
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboTipoDocumento) Then
      FNC_Mensagem("Selecione o tipo do documento")
      Exit Sub
    End If
    If psqEmitente.ID_Pessoa = 0 And Trim(psqEmitente.NO_PESSOA) = "" Then
      FNC_Mensagem("Selecione o emitente")
      Exit Sub
    End If
    If Trim(txtCodigoDocumento.Text) = "" Then
      FNC_Mensagem("Informe o código ou número do documento")
      Exit Sub
    End If
    If Not IsDate(txtDataEmissao.Text) Then
      FNC_Mensagem("Informe a data de emissão do documento")
      Exit Sub
    End If
    If Not IsDate(txtDataVencimento.Text) Then
      FNC_Mensagem("Informe a data de vencimento do documento")
      Exit Sub
    End If
    If txtValorDocumento.Value <= 0 Then
      FNC_Mensagem("Informe o valor do documento")
      Exit Sub
    End If

    If FNC_NVL(cboTipoDocumento.SelectedItem(enComboBox_TipoDocumento.ID_OPT_INSTITUICAO_GERADORA), 0) = enOpcoes.TipoInstituicao_Bancaria.GetHashCode Then
      If Not ComboBox_Selecionado(cboBanco) Then
        FNC_Mensagem("Selecione o banco, pois esse tipo de documento é de uma instituição bancária")
        Exit Sub
      End If

      If FNC_NVL(cboTipoDocumento.SelectedItem(enComboBox_TipoDocumento.IC_CADASTRAR_CONTABANCARIA), "N") = "S" Then
        If FNC_NVL(txtNrAgencia.Value, 0) = 0 Then
          FNC_Mensagem("Informe o número da agência, pois esse tipo de documento é de uma instituição bancária")
          Exit Sub
        End If
        If FNC_NVL(txtNrConta.Value, 0) = 0 Then
          FNC_Mensagem("Informe o número da conta, pois esse tipo de documento é de uma instituição bancária")
          Exit Sub
        End If
        If FNC_NVL(txtNrContaDigito.Value, 0) = 0 Then
          FNC_Mensagem("Informe o dígito da conta, pois esse tipo de documento é de uma instituição bancária")
          Exit Sub
        End If
      End If
    End If

    If Not ComboBox_Selecionado(cboStatus) Then
      FNC_Mensagem("Selecione o status")
      Exit Sub
    End If

    If FormCadastroDocumentoFinanceiro_Gravar(iSQ_DOCUMENTOFINANCEIRO,
                                              cboTipoDocumento.SelectedValue,
                                              cboBanco.SelectedValue,
                                              psqEmitente.ID_Pessoa,
                                              txtDataEmissao.Value,
                                              txtDataVencimento.Value,
                                              psqEmitente.NO_PESSOA,
                                              txtNrAgencia.Value,
                                              txtNrConta.Value,
                                              txtNrContaDigito.Value,
                                              txtCodigoDocumento.Text,
                                              txtValorDocumento.Value,
                                              txtSaldoDisponivel.Value,
                                              txtDescricaoDocumento.Text) Then
      If bFecharTela Then
        Close()
      Else
        FNC_Mensagem("Gravação Efetuada")
      End If

      If iSQ_TIPO_DOCUMENTO > 0 Then
        Close()
      End If
    End If
  End Sub
End Class