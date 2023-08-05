Public Class frmSEGUsuario_Clinica_Configuracao
  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmSEGUsuario_Clinica_Configuracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim oData As DataTable
    Dim sSqlText As String

    ComboBox_Carregar(cboProfissionalPadraoAgendamento, enSql.Profissional)
    ComboBox_Carregar(cboContaFinanceiraPadraoVenda, enSql.ContaCaixa, , True)
    ComboBox_Carregar(cboCarregamentoAutomaticoInicializacao, enSql.TelaCarregamentoAutomaticoInicializacao)

    sSqlText = "SELECT * FROM TB_PESSOA_CONFIGURACAO WHERE ID_PESSOA = " & iID_USUARIO & " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      ComboBox_Selecionar(cboProfissionalPadraoAgendamento, oData.Rows(0).Item("ID_PESSOA_PROFISSIONAL_PADRAO"))
      ComboBox_Selecionar(cboContaFinanceiraPadraoVenda, oData.Rows(0).Item("ID_CONTAFINANCEIRA_PADRAO_VENDA"))
      ComboBox_Selecionar(cboCarregamentoAutomaticoInicializacao, oData.Rows(0).Item("ID_OPT_CARREGAMENTOAUTOMATICOINICIALIZACAO"))
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_CONFIGURACAO_CAD", False, "@ID_PESSOA",
                                                                "@ID_EMPRESA",
                                                                "@ID_OPT_CARREGAMENTOAUTOMATICOINICIALIZACAO",
                                                                "@ID_PESSOA_PROFISSIONAL_PADRAO",
                                                                "@ID_CONTAFINANCEIRA_PADRAO_VENDA")
    If DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA", iID_USUARIO),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_OPT_CARREGAMENTOAUTOMATICOINICIALIZACAO", cboCarregamentoAutomaticoInicializacao.SelectedValue),
                            DBParametro_Montar("ID_PESSOA_PROFISSIONAL_PADRAO", cboProfissionalPadraoAgendamento.SelectedValue),
                            DBParametro_Montar("ID_CONTAFINANCEIRA_PADRAO_VENDA", cboContaFinanceiraPadraoVenda.SelectedValue)) Then

      FNC_UsuarioConfiguracao_Carregar()

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub cboCarregamentoAutomaticoInicializacao_KeyDown(sender As Object, e As KeyEventArgs) Handles cboCarregamentoAutomaticoInicializacao.KeyDown
    If e.KeyCode = Keys.Delete Then cboCarregamentoAutomaticoInicializacao.SelectedIndex = -1
  End Sub

  Private Sub cboContaFinanceiraPadraoVenda_KeyDown(sender As Object, e As KeyEventArgs) Handles cboContaFinanceiraPadraoVenda.KeyDown
    If e.KeyCode = Keys.Delete Then cboContaFinanceiraPadraoVenda.SelectedIndex = -1
  End Sub

  Private Sub cboProfissionalPadraoAgendamento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProfissionalPadraoAgendamento.KeyDown
    If e.KeyCode = Keys.Delete Then cboProfissionalPadraoAgendamento.SelectedIndex = -1
  End Sub
End Class