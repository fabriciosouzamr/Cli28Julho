Imports Infragistics.Win

Public Class frmConsultaAbestencaoDia
  Const const_GridListagem_SQ_AGENDAMENTO As Integer = 0
  Const const_GridListagem_Unidade As Integer = 1
  Const const_GridListagem_Profssional As Integer = 2
  Const const_GridListagem_DataAgendamento As Integer = 3
  Const const_GridListagem_Status As Integer = 4
  Const const_GridListagem_Especialidade As Integer = 5
  Const const_GridListagem_Procedimento As Integer = 6
  Const const_GridListagem_CodAgendamento As Integer = 7
  Const const_GridListagem_Tipo As Integer = 8
  Const const_GridListagem_Paciente As Integer = 9
  Const const_GridListagem_Telefone As Integer = 10
  Const const_GridListagem_CanalMarcacao As Integer = 11
  Const const_GridListagem_DataMarcacao As Integer = 12
  Const const_GridListagem_UsuarioMarcacao As Integer = 13

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String

    sSqlText = "SELECT AGEND.SQ_AGENDAMENTO," &
                      "EMPRE.NO_PESSOA AS UNIDADE," &
                      "PROFI.NO_PESSOA AS PROFISSIONAL," &
                      "AGEND.DH_AGENDAMENTO," &
                      "OPCAO.NO_OPCAO AS STATUS," &
                      "ESPEC.NO_ESPECIALIDADE AS ESPECIALIDADE," &
                      "PROCE.NO_PROCEDIMENTO AS PROCEDIMENTO," &
                      "AGEND.CD_AGENDAMENTO," &
                      "TPCST.NO_TIPO_CONSULTA AS TIPO," &
                      "PESSO.NO_PESSOA AS PACIENTE," &
                      "MIN(PSTEL.CD_NUMERO) AS TELEFONE," &
                      "CNLMC.NO_CANALMARCACAO," &
                      "HISTO.DT_HISTORICO," &
                      "HISTO.NO_USUARIO" &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_OPCAO OPCAO ON OPCAO.SQ_OPCAO = AGEND.ID_OPT_STATUS" &
                " INNER JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = AGEND.ID_ESPECIALIDADE" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA  = AGEND.ID_PESSOA" &
                " INNER JOIN TB_PESSOA AS PROFI ON PROFI.SQ_PESSOA  = AGEND.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO  = AGEND.ID_PROCEDIMENTO" &
                " INNER JOIN TB_TIPO_CONSULTA TPCST ON TPCST.SQ_TIPO_CONSULTA  = AGEND.ID_TIPO_CONSULTA" &
                " INNER JOIN TB_PESSOA AS EMPRE ON EMPRE.SQ_PESSOA  = AGEND.ID_EMPRESA" &
                " INNER JOIN TB_PESSOA_TELEFONE PSTEL ON PSTEL.ID_PESSOA = AGEND.ID_PESSOA" &
                 " LEFT JOIN TB_CANALMARCACAO CNLMC ON CNLMC.SQ_CANALMARCACAO = AGEND.ID_CANALMARCACAO" &
                 " LEFT JOIN TB_OPCAO OPCAO_DIASM ON OPCAO_DIASM.CD_OPCAO = CAST(DATEPART(W, AGEND.DH_AGENDAMENTO) AS CHAR)" &
                                               " AND OPCAO_DIASM.ID_TIPO_OPCAO = " & enTipoOpcao.DiasSemana.GetHashCode() &
                 " LEFT JOIN VW_HISTORICO_INCLUSAO HISTO ON HISTO.ID_REGISTRO = AGEND.SQ_AGENDAMENTO" &
                                                      " AND HISTO.ID_OPT_PROCESSO = " & enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode() &
               " WHERE (AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Agendado & " OR " &
                       "AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_AguardandoAtendimento & " OR " &
                       "AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_AguardandoPagamento & ")"

    If ComboBox_Selecionado(cboEmpresa) Then
      sSqlText = sSqlText & " AND AGEND.ID_EMPRESA = " & cboEmpresa.SelectedValue
    End If
    If ComboBox_Selecionado(cboProfissional) Then
      sSqlText = sSqlText & " AND AGEND.ID_PESSOA_PROFISSIONAL = " & cboProfissional.SelectedValue
    End If
    If IsDate(txtDataAtendimentoInicial.Text) Then
      sSqlText = sSqlText & " AND CAST(AGEND.DH_AGENDAMENTO AS DATE) >= " & FNC_QuotedStr(txtDataAtendimentoInicial.Text)
    End If
    If IsDate(txtDataAtendimentoFinal.Text) Then
      sSqlText = sSqlText & " AND CAST(AGEND.DH_AGENDAMENTO AS DATE) <= " & FNC_QuotedStr(txtDataAtendimentoFinal.Text)
    End If
    If ComboBox_Selecionado(cboStatus) Then
      sSqlText = sSqlText & " AND AGEND.ID_OPT_STATUS = " & cboStatus.SelectedValue
    End If
    If ComboBox_Selecionado(cboUsuarioMarcacao) Then
      sSqlText = sSqlText & " AND HISTO.ID_USUARIO = " & cboUsuarioMarcacao.SelectedValue
    End If
    If ComboBox_Selecionado(cboCanalMarcacao) Then
      sSqlText = sSqlText & " AND CNLMC.SQ_CANALMARCACAO = " & cboCanalMarcacao.SelectedValue
    End If
    If IsDate(txtDataMarcacaoInicial.Text) Then
      sSqlText = sSqlText & " AND CAST(HISTO.DT_HISTORICO AS DATE) >= " & FNC_QuotedStr(txtDataMarcacaoInicial.Text)
    End If
    If IsDate(txtDataMarcacaoFinal.Text) Then
      sSqlText = sSqlText & " AND CAST(HISTO.DT_HISTORICO AS DATE) <= " & FNC_QuotedStr(txtDataMarcacaoFinal.Text)
    End If

    sSqlText = sSqlText &
               " GROUP BY AGEND.SQ_AGENDAMENTO," &
                         "EMPRE.NO_PESSOA," &
                         "PROFI.NO_PESSOA," &
                         "AGEND.DH_AGENDAMENTO," &
                         "OPCAO.NO_OPCAO," &
                         "ESPEC.NO_ESPECIALIDADE," &
                         "PROCE.NO_PROCEDIMENTO," &
                         "AGEND.CD_AGENDAMENTO," &
                         "TPCST.NO_TIPO_CONSULTA," &
                         "PESSO.NO_PESSOA," &
                         "CNLMC.NO_CANALMARCACAO," &
                         "HISTO.DT_HISTORICO," &
                         "HISTO.NO_USUARIO"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_AGENDAMENTO,
                                                           const_GridListagem_Unidade,
                                                           const_GridListagem_Profssional,
                                                           const_GridListagem_DataAgendamento,
                                                           const_GridListagem_Status,
                                                           const_GridListagem_Especialidade,
                                                           const_GridListagem_Procedimento,
                                                           const_GridListagem_CodAgendamento,
                                                           const_GridListagem_Tipo,
                                                           const_GridListagem_Paciente,
                                                           const_GridListagem_Telefone,
                                                           const_GridListagem_CanalMarcacao,
                                                           const_GridListagem_DataMarcacao,
                                                           const_GridListagem_UsuarioMarcacao})

    If grdListagem.Rows.Count = 0 Then
      lblRListagemPessoa.Text = lblRListagemPessoa.Tag
    Else
      lblRListagemPessoa.Text = lblRListagemPessoa.Tag & " (" & grdListagem.Rows.Count & ")"
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboEmpresa.SelectedIndex = -1
    cboProfissional.SelectedIndex = -1
    cboStatus.SelectedIndex = -1

    txtDataAtendimentoInicial.Value = Nothing
    txtDataAtendimentoFinal.Value = Nothing
    txtDataMarcacaoInicial.Value = Nothing
    txtDataMarcacaoFinal.Value = Nothing
  End Sub

  Private Sub frmConsultaAbestencaoDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboEmpresa, enSql.Empresa)
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboCanalMarcacao, enSql.CanalMarcacao)
    ComboBox_Carregar(cboUsuarioMarcacao, enSql.Atendente)
    ComboBox_Carregar(cboStatus, enSql.StatusAgendamento_Todos, New Object() {enOpcoes.StatusAgendamento_Agendado & "," &
                                                                              enOpcoes.StatusAgendamento_AguardandoAtendimento & "," &
                                                                              enOpcoes.StatusAgendamento_AguardandoPagamento})
    txtDataAtendimentoInicial.Value = Nothing
    txtDataAtendimentoFinal.Value = Nothing
    txtDataMarcacaoInicial.Value = Nothing
    txtDataMarcacaoFinal.Value = Nothing

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_AGENDAMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "Unidade", 100)
    objGrid_Coluna_Add(grdListagem, "Profssional", 100)
    objGrid_Coluna_Add(grdListagem, "Data Agendamento", 100,,,,, const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Status", 100)
    objGrid_Coluna_Add(grdListagem, "Especialidade", 100)
    objGrid_Coluna_Add(grdListagem, "Procedimento", 100)
    objGrid_Coluna_Add(grdListagem, "Cód. Agendamento", 100)
    objGrid_Coluna_Add(grdListagem, "Tipo", 100)
    objGrid_Coluna_Add(grdListagem, "Paciente", 100)
    objGrid_Coluna_Add(grdListagem, "Telefone", 100)
    objGrid_Coluna_Add(grdListagem, "Canal de Marcação", 100)
    objGrid_Coluna_Add(grdListagem, "Data de Marcação", 100,,,,, const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Usuário de Marcação", 100)
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    Dim iCont As Integer
    Dim sSQ_AGENDAMENTO As String = 0

    For iCont = 0 To grdListagem.Rows.Count - 1
      FNC_Str_Adicionar(sSQ_AGENDAMENTO, objGrid_Valor(grdListagem, const_GridListagem_SQ_AGENDAMENTO, iCont), ",")
    Next

    FormRelatorioAbestencaoDia(sSQ_AGENDAMENTO)
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub
End Class