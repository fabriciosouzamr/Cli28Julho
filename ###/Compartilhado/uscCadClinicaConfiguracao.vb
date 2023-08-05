Public Class uscCadClinicaConfiguracao
  Dim bCarregandoTela As Boolean

  Public Sub Formatar()
    bCarregandoTela = True

    ComboBox_Carregar(cboTipoConsulta_Retorno, enSql.Tipo_Consulta)
    ComboBox_Carregar(cboTipoConsulta_Venda, enSql.Tipo_Consulta)
    ComboBox_Carregar(cboModeloReceita_Padrao, enSql.ModeloDocumento_Receita)
    ComboBox_CarregarModeloAnamnese(cboModeloAnamnese_Padrao)
    ComboBox_Carregar(cboModeloEvoluca_Padrao, enSql.ModeloDocumento_Evolucao)
    ComboBox_Carregar(cboTabelaProcedimento_Padrao, enSql.TabelaProcedimento)

    CarregarDados()
    bCarregandoTela = False
  End Sub

  Private Sub ComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoConsulta_Retorno.KeyDown,
                                                                            cboModeloReceita_Padrao.KeyDown,
                                                                            cboModeloEvoluca_Padrao.KeyDown,
                                                                            cboModeloAnamnese_Padrao.KeyDown,
                                                                            cboTabelaProcedimento_Padrao.KeyDown
    If e.KeyCode = Keys.Delete Then
      sender.SelectedIndex = -1
    End If
  End Sub

  Private Sub cboTabelaProcedimento_Padrao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTabelaProcedimento_Padrao.SelectedIndexChanged
    If Not bCarregandoTela Then
      chkCarregarTodosProcedimentosPadrao.Enabled = ComboBox_Selecionado(cboTabelaProcedimento_Padrao)

      If Not chkCarregarTodosProcedimentosPadrao.Enabled Then chkCarregarTodosProcedimentosPadrao.Checked = False
    End If
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM TB_EMPRESA WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        ComboBox_Selecionar(cboTabelaProcedimento_Padrao, FNC_NVL(.Item("ID_TABELAPROCEDIMENTO_PADRAO"), 0))
        ComboBox_Selecionar(cboTipoConsulta_Retorno, FNC_NVL(.Item("ID_TIPO_CONSULTA_RETORNO"), 0))
        ComboBox_Selecionar(cboTipoConsulta_Venda, FNC_NVL(.Item("ID_TIPO_CONSULTA_VENDA"), 0))
        ComboBox_Selecionar(cboModeloReceita_Padrao, FNC_NVL(.Item("ID_MODELODOCUMENTO_RECEITA_PADRAO"), 0))
        ComboBox_Selecionar(cboModeloEvoluca_Padrao, FNC_NVL(.Item("ID_MODELODOCUMENTO_EVOLUCAO_PADRAO"), 0))
        ComboBox_PossicionarModeloAnamnese(cboModeloAnamnese_Padrao, FNC_NVL(.Item("ID_MODELODOCUMENTO_ANAMNESE_PADRAO"), FNC_NVL(.Item("ID_QUESTIONARIO_ANAMNESE_PADRAO"), 0)),
                                                                     IIf(FNC_NVL(.Item("ID_QUESTIONARIO_ANAMNESE_PADRAO"), 0) = 0, const_Anamnese_ModeloDocumento, const_Anamnese_Formulario))
        txtAtendimento_Intervalo.Value = FNC_NVL(.Item("NR_ATENDIMENTO_INTERVALO"), 30)
        txtAtendimento_HoraInicio.Text = FNC_NVL(.Item("HR_ATENDIMENTO_INICIO"), "06:00")
        txtAtendimento_HoraSaidaRefeicao.Text = FNC_NVL(.Item("HR_ATENDIMENTO_SAIDAREFEICAO"), "00:00")
        txtAtendimento_HoraRetornoRefeicao.Text = FNC_NVL(.Item("HR_ATENDIMENTO_RETORNOREFEICAO"), "00:00")
        txtAtendimento_HoraFim.Text = FNC_NVL(.Item("HR_ATENDIMENTO_FIM"), "18:00")
        chkCarregarTodosProcedimentosPadrao.Checked = (FNC_NVL(.Item("IC_LISTARTODOS_PROCEDIMENTO"), "N") = "S")
      End With
    End If

    sSqlText = "SELECT * FROM TB_CONFIG"
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        txtIdadeIdoso.Value = FNC_NVL(.Item("NR_IDOSO_IDADE"), 30)
      End With
    End If
  End Sub

  Private Sub cboTabelaProcedimento_Padrao_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTabelaProcedimento_Padrao.KeyDown
    If e.KeyCode = Keys.Delete Then cboTabelaProcedimento_Padrao.SelectedIndex = -1
  End Sub

  Public Sub Gravar()
    Dim sSqlText As String

    If txtAtendimento_Intervalo.Value <= 0 Then
      FNC_Mensagem("É preciso informar o horário inicial de atendimento")
      Exit Sub
    End If
    If Trim(txtAtendimento_HoraInicio.Text) = "" Then
      FNC_Mensagem("É preciso informar o horário inicial de atendimento")
      Exit Sub
    End If
    If Trim(txtAtendimento_HoraFim.Text) = "" Then
      FNC_Mensagem("É preciso informar o horário final de atendimento")
      Exit Sub
    End If
    If Not FNC_Data_HoraValida(txtAtendimento_HoraInicio.Text) Then
      FNC_Mensagem("Hora inicial do atendimento inválido")
      Exit Sub
    End If
    If Not FNC_Data_HoraValida(txtAtendimento_HoraFim.Text) Then
      FNC_Mensagem("Hora final do atendimento inválido")
      Exit Sub
    End If
    If FNC_Hora(txtAtendimento_HoraInicio.Text) >= FNC_Hora(txtAtendimento_HoraFim.Text) Then
      FNC_Mensagem("Hora de início de atendimento está maior ou igual o horário final de atendimento")
      Exit Sub
    End If
    If Not FNC_Data_HoraValida(txtAtendimento_HoraSaidaRefeicao.Text) Then
      FNC_Mensagem("Informe um horário válido para a saída para refeição, ou 00:00 caso não exista esse intervalo")
      Exit Sub
    End If
    If Not FNC_Data_HoraValida(txtAtendimento_HoraRetornoRefeicao.Text) Then
      FNC_Mensagem("Informe um horário válido para o retorno de refeição, ou 00:00 caso não exista esse intervalo")
      Exit Sub
    End If
    If txtAtendimento_HoraSaidaRefeicao.Text <> "00:00" Then
      If FNC_Hora(txtAtendimento_HoraSaidaRefeicao.Text) <= FNC_Hora(txtAtendimento_HoraInicio.Text) Or
         FNC_Hora(txtAtendimento_HoraSaidaRefeicao.Text) >= FNC_Hora(txtAtendimento_HoraRetornoRefeicao.Text) Then
        FNC_Mensagem("O horário de saída para refeição precisa ser maior que o horário inicial e menor que o horário de retorno")
        Exit Sub
      End If
    End If
    If txtAtendimento_HoraRetornoRefeicao.Text <> "00:00" Then
      If FNC_Hora(txtAtendimento_HoraRetornoRefeicao.Text) <= FNC_Hora(txtAtendimento_HoraSaidaRefeicao.Text) Or
         FNC_Hora(txtAtendimento_HoraRetornoRefeicao.Text) >= FNC_Hora(txtAtendimento_HoraFim.Text) Then
        FNC_Mensagem("O horário de retorno de refeição precisa ser maior que o horário saída para refeição e menor que o horário final")
        Exit Sub
      End If
    End If

    Dim iID_MODELODOCUMENTO_ANAMNESE_PADRAO As Integer = 0
    Dim iID_QUESTIONARIO_ANAMNESE_PADRAO As Integer = 0

    If ComboBox_Selecionado(cboModeloAnamnese_Padrao) Then
      Select Case cboModeloAnamnese_Padrao.SelectedItem(2)
        Case const_Anamnese_Formulario
          iID_QUESTIONARIO_ANAMNESE_PADRAO = cboModeloAnamnese_Padrao.SelectedValue
        Case const_Anamnese_ModeloDocumento
          iID_MODELODOCUMENTO_ANAMNESE_PADRAO = cboModeloAnamnese_Padrao.SelectedValue
      End Select
    End If

    sSqlText = DBMontar_SP("SP_EMPRESA_CLINICA_CONFIGURACAO_CAD", False, "@ID_EMPRESA",
                                                                         "@ID_TABELAPROCEDIMENTO_PADRAO",
                                                                         "@ID_MODELODOCUMENTO_RECEITA_PADRAO",
                                                                         "@ID_MODELODOCUMENTO_ANAMNESE_PADRAO," &
                                                                         "@ID_MODELODOCUMENTO_EVOLUCAO_PADRAO," &
                                                                         "@ID_QUESTIONARIO_ANAMNESE_PADRAO",
                                                                         "@ID_TIPO_CONSULTA_RETORNO",
                                                                         "@ID_TIPO_CONSULTA_VENDA",
                                                                         "@NR_ATENDIMENTO_INTERVALO",
                                                                         "@HR_ATENDIMENTO_INICIO",
                                                                         "@HR_ATENDIMENTO_SAIDAREFEICAO",
                                                                         "@HR_ATENDIMENTO_RETORNOREFEICAO",
                                                                         "@HR_ATENDIMENTO_FIM",
                                                                         "@IC_LISTARTODOS_PROCEDIMENTO",
                                                                         "@IC_NECESSITA_ANAMNESE_EVOLUCAO",
                                                                         "@NR_IDOSO_IDADE")
    DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                         DBParametro_Montar("ID_TABELAPROCEDIMENTO_PADRAO", cboTabelaProcedimento_Padrao.SelectedValue),
                         DBParametro_Montar("ID_MODELODOCUMENTO_RECEITA_PADRAO", cboModeloReceita_Padrao.SelectedValue),
                         DBParametro_Montar("ID_MODELODOCUMENTO_ANAMNESE_PADRAO", FNC_NuloZero(iID_MODELODOCUMENTO_ANAMNESE_PADRAO, False)),
                         DBParametro_Montar("ID_MODELODOCUMENTO_EVOLUCAO_PADRAO", cboModeloEvoluca_Padrao.SelectedValue),
                         DBParametro_Montar("ID_QUESTIONARIO_ANAMNESE_PADRAO", FNC_NuloZero(iID_QUESTIONARIO_ANAMNESE_PADRAO, False)),
                         DBParametro_Montar("ID_TIPO_CONSULTA_RETORNO", cboTipoConsulta_Retorno.SelectedValue),
                         DBParametro_Montar("ID_TIPO_CONSULTA_VENDA", cboTipoConsulta_Venda.SelectedValue),
                         DBParametro_Montar("NR_ATENDIMENTO_INTERVALO", txtAtendimento_Intervalo.Value),
                         DBParametro_Montar("HR_ATENDIMENTO_INICIO", txtAtendimento_HoraInicio.Text),
                         DBParametro_Montar("HR_ATENDIMENTO_SAIDAREFEICAO", txtAtendimento_HoraSaidaRefeicao.Text),
                         DBParametro_Montar("HR_ATENDIMENTO_RETORNOREFEICAO", txtAtendimento_HoraRetornoRefeicao.Text),
                         DBParametro_Montar("HR_ATENDIMENTO_FIM", txtAtendimento_HoraFim.Text),
                         DBParametro_Montar("IC_LISTARTODOS_PROCEDIMENTO", IIf(chkCarregarTodosProcedimentosPadrao.Checked, "S", "N")),
                         DBParametro_Montar("IC_NECESSITA_ANAMNESE_EVOLUCAO", IIf(chkNecessarioAnamneseEvolucoes.Checked, "S", "N")),
                         DBParametro_Montar("NR_IDOSO_IDADE", txtIdadeIdoso.Value))

    iEMPRESA_ID_TIPOCONSULTA_RETORNO = FNC_NVL(cboTipoConsulta_Retorno.SelectedValue, 0)
    iEMPRESA_ID_TIPO_CONSULTA_VENDA = FNC_NVL(cboTipoConsulta_Venda.SelectedValue, 0)
    iEMPRESA_ID_TABELAPROCEDIMENTO_PADRAO = FNC_NVL(cboTabelaProcedimento_Padrao.SelectedValue, 0)
    iEMPRESA_ID_MODELODOCUMENTO_RECEITA_PADRAO = FNC_NVL(cboModeloReceita_Padrao.SelectedValue, 0)
    iEMPRESA_ID_MODELODOCUMENTO_ANAMNESE_PADRAO = iID_MODELODOCUMENTO_ANAMNESE_PADRAO
    iEMPRESA_ID_MODELODOCUMENTO_EVOLUCAO_PADRAO = FNC_NVL(cboModeloEvoluca_Padrao.SelectedValue, 0)
    iEMPRESA_ID_QUESTIONARIO_ANAMNESE_PADRAO = iID_QUESTIONARIO_ANAMNESE_PADRAO
    iEMPRESA_NR_ATENDIMENTO_INTERVALO = txtAtendimento_Intervalo.Value
    sEMPRESA_HR_ATENDIMENTO_INICIO = txtAtendimento_HoraInicio.Text
    sEMPRESA_HR_ATENDIMENTO_SAIDAREFEICAO = txtAtendimento_HoraSaidaRefeicao.Text
    sEMPRESA_HR_ATENDIMENTO_RETORNOREFEICAO = txtAtendimento_HoraRetornoRefeicao.Text
    sEMPRESA_HR_ATENDIMENTO_FIM = txtAtendimento_HoraFim.Text
    bEMPRESA_IC_LISTARTODOS_PROCEDIMENTO = chkCarregarTodosProcedimentosPadrao.Checked
    bEMPRESA_IC_NECESSITA_ANAMNESE_EVOLUCAO = chkNecessarioAnamneseEvolucoes.Checked
  End Sub
End Class
