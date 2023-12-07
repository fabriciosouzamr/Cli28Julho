Public Class frmCadastroContaBancaria
  Public Event Pesquisar()

  Public iSQ_CONTAFINANCEIRA As Integer

  Private Sub frmCadastroContaBancaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboTipoContaBancaria, enSql.TipoContaFinanceira)
    ComboBox_Carregar(cboFuncionarioSupervisorContaCaixa, enSql.Usuario_Supervisao)
    ListBox_Carregar(lstFuncionariosUtilizamConta, enSql.Funcionario)

    If iSQ_CONTAFINANCEIRA > 0 Then
      CarregarDados()
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = "SELECT * FROM TB_CONTAFINANCEIRA WHERE SQ_CONTAFINANCEIRA = " & iSQ_CONTAFINANCEIRA
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        ComboBox_Selecionar(cboTipoContaBancaria, .Item("ID_TIPO_CONTAFINANCEIRA"))
        ComboBox_Selecionar(cboFuncionarioSupervisorContaCaixa, .Item("ID_PESSOA_SUPERVISAO"))
        txtNomeContaBancaria.Text = FNC_NVL(.Item("NO_CONTAFINANCEIRA"), "")
        txtNumeroAgencia.Value = FNC_NVL(.Item("NR_AGENCIA"), 0)
        txtNumeroConta.Value = FNC_NVL(.Item("NR_CONTA"), 0)
        txtDigitoConta.Value = FNC_NVL(.Item("NR_CONTA_DIGITO"), 0)

        If Not FNC_CampoNulo(.Item("DT_ABERTURA")) Then
          txtDataAbertura.Value = .Item("DT_ABERTURA")
        End If

        chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "") = "S")
        chkControlaSaldo.Checked = (FNC_NVL(.Item("IC_CONTROLASALDO"), "") = "S")
      End With
    End If

    sSqlText = "SELECT * FROM TB_CONTAFINANCEIRA_PESSOA WHERE ID_CONTAFINANCEIRA = " & iSQ_CONTAFINANCEIRA
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      ChekListBox_Selecionar(lstFuncionariosUtilizamConta, oData.Rows(iCont).Item("ID_PESSOA"))
    Next
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Trim(txtNomeContaBancaria.Text) = "" Then
      FNC_Mensagem("Informe o nome da conta caixa")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoContaBancaria) Then
      FNC_Mensagem("Selecione o tipo da conta bancária")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = DBMontar_SP("SP_CONTABANCARIA_CAD", False, "@SQ_CONTAFINANCEIRA OUT",
                                                          "@ID_EMPRESA",
                                                          "@ID_TIPO_CONTAFINANCEIRA",
                                                          "@ID_PESSOA_SUPERVISAO",
                                                          "@NO_CONTAFINANCEIRA",
                                                          "@NR_AGENCIA",
                                                          "@NR_CONTA",
                                                          "@NR_CONTA_DIGITO",
                                                          "@DT_ABERTURA",
                                                          "@IC_ATIVO",
                                                          "@IC_CONTROLASALDO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CONTAFINANCEIRA", iSQ_CONTAFINANCEIRA, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_TIPO_CONTAFINANCEIRA", cboTipoContaBancaria.SelectedValue),
                            DBParametro_Montar("ID_PESSOA_SUPERVISAO", FNC_NuloZero(cboFuncionarioSupervisorContaCaixa.SelectedValue, False)),
                            DBParametro_Montar("NO_CONTAFINANCEIRA", txtNomeContaBancaria.Text.Trim()),
                            DBParametro_Montar("NR_AGENCIA", txtNumeroAgencia.Value),
                            DBParametro_Montar("NR_CONTA", txtNumeroConta.Value),
                            DBParametro_Montar("NR_CONTA_DIGITO", txtDigitoConta.Value),
                            DBParametro_Montar("DT_ABERTURA", FNC_NuloData(txtDataAbertura.Value), SqlDbType.DateTime),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N")),
                            DBParametro_Montar("IC_CONTROLASALDO", IIf(chkControlaSaldo.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_CONTAFINANCEIRA = DBRetorno(1)
      End If

      sSqlText = DBMontar_SP("SP_CONTAFINANCEIRA_PESSOA_DEL", False, "@SQ_CONTAFINANCEIRA")
      DBExecutar(sSqlText, DBParametro_Montar("SQ_CONTAFINANCEIRA", iSQ_CONTAFINANCEIRA))

      For iCont = 0 To lstFuncionariosUtilizamConta.CheckedItems.Count - 1
        sSqlText = DBMontar_SP("SP_CONTAFINANCEIRA_PESSOA_INS", False, "@ID_CONTAFINANCEIRA",
                                                                       "@ID_PESSOA")
        DBExecutar(sSqlText, DBParametro_Montar("ID_CONTAFINANCEIRA", iSQ_CONTAFINANCEIRA),
                             DBParametro_Montar("ID_PESSOA", lstFuncionariosUtilizamConta.CheckedItems(iCont)(0)))
      Next

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub
End Class