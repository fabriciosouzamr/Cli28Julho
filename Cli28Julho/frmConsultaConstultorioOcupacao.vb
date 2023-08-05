Imports Infragistics.Win

Public Class frmConsultaConstultorioOcupacao
  Const const_GridListagem_SQ_PESSOA_HORARIO As Integer = 0
  Const const_GridListagem_Unidade As Integer = 1
  Const const_GridListagem_Consultorio As Integer = 2
  Const const_GridListagem_Status As Integer = 3
  Const const_GridListagem_Data As Integer = 4
  Const const_GridListagem_Dia As Integer = 5
  Const const_GridListagem_HorarioInicio As Integer = 6
  Const const_GridListagem_HorarioFim As Integer = 7
  Const const_GridListagem_Profssional As Integer = 8
  Const const_GridListagem_QuantidadeAtendimento As Integer = 9
  Const const_GridListagem_QuantidadeRetorno As Integer = 10
  Const const_GridListagem_DataEspecial As Integer = 11

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Const const_Status_Ocupado = "Ocupado"
  Const const_Status_Disponivel = "Disponível"

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String
    Dim sData_Inicial As String
    Dim sData_Final As String

    If Not IsDate(txtDataOcupacaoInicial.Text) Or Not IsDate(txtDataOcupacaoFinal.Text) Then
      FNC_Mensagem("Informe o período de contsulta")
      Exit Sub
    End If

    sData_Inicial = FNC_StrZero(txtDataOcupacaoInicial.DateTime.Day, 2) + "/" + FNC_StrZero(txtDataOcupacaoInicial.DateTime.Month, 2) + "/" + FNC_StrZero(txtDataOcupacaoInicial.DateTime.Year, 4)
    sData_Final = FNC_StrZero(txtDataOcupacaoFinal.DateTime.Day, 2) + "/" + FNC_StrZero(txtDataOcupacaoFinal.DateTime.Month, 2) + "/" + FNC_StrZero(txtDataOcupacaoFinal.DateTime.Year, 4)

    sSqlText = "SELECT PSHRR.SQ_PESSOA_HORARIO," &
                      "EMPRE.NO_PESSOA AS UNIDADE," &
                      "LSTPR.NO_CONSULTORIO," &
                      "IIF(PSHRR.SQ_PESSOA_HORARIO IS NULL, '" & const_Status_Disponivel & "','" & const_Status_Ocupado & "')," &
                      "LSTPR.DH_FUNCIONAMENTO," &
                      "OPCAO.NO_OPCAO AS DIA," &
                      "PSHRR.HR_INICIO," &
                      "PSHRR.HR_FIM," &
                      "PESSO.NO_PESSOA AS PROFISSIONAL," &
                      "PSHRR.QT_ATENDIMENTO," &
                      "PSHRR.QT_RETORNO," &
                      "PSHRR.DT_ESPECIAL" &
               " FROM dbo.FC_CONSULTORIO_HORA_FUNCIONAMENTO_LISTARDATAS('" + sData_Inicial + "', '" + sData_Final + "') LSTPR" &
                " INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = LSTPR.ID_EMPRESA" &
                " INNER JOIN TB_OPCAO OPCAO ON OPCAO.CD_OPCAO = CAST(DATEPART(WEEKDAY, LSTPR.DH_FUNCIONAMENTO) AS CHAR(1))" &
                                         " AND OPCAO.ID_TIPO_OPCAO = " & enTipoOpcao.DiasSemana &
                 " LEFT JOIN dbo.FC_PESSOAHORARIO_HORA_FUNCIONAMENTO_LISTARDATAS('" + sData_Inicial + "', '" + sData_Final + "') PSHRR ON PSHRR.ID_CONSULTORIO = LSTPR.ID_CONSULTORIO" &
                                                                                                                                    " AND PSHRR.ID_OPT_DIA_SEMANA = OPCAO.SQ_OPCAO" &
                                                                                                                                    " AND PSHRR.ID_EMPRESA = EMPRE.SQ_PESSOA" &
                                                                                                                                    " AND LSTPR.DH_FUNCIONAMENTO = PSHRR.DH_INTERVALO" &
                 " LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PSHRR.ID_PESSOA" &
               " WHERE LSTPR.DH_FUNCIONAMENTO IS NOT NULL"

    sSqlText = sSqlText & " AND (PSHRR.DT_ESPECIAL IS NULL OR (PSHRR.DT_ESPECIAL >= '" & sData_Inicial & "' AND PSHRR.DT_ESPECIAL <= '" & sData_Final & "'))"

    If ComboBox_Selecionado(cboStatus) Then
      If cboStatus.SelectedItem(1) = const_Status_Ocupado Then
        sSqlText = sSqlText & " AND PSHRR.SQ_PESSOA_HORARIO IS NOT NULL "
      Else
        sSqlText = sSqlText & " AND PSHRR.SQ_PESSOA_HORARIO IS NULL "
      End If
    End If
    If ComboBox_Selecionado(cboEmpresa) Then
      sSqlText = sSqlText & " AND PSHRR.ID_EMPRESA = " & cboEmpresa.SelectedValue
    End If
    If ComboBox_Selecionado(cboProfissional) Then
      sSqlText = sSqlText & " AND PSHRR.ID_PESSOA = " & cboProfissional.SelectedValue
    End If
    If ComboBox_Selecionado(cboDiaSemana) Then
      sSqlText = sSqlText & " AND OPCAO.CD_OPCAO = " & FNC_QuotedStr(cboDiaSemana.SelectedItem(enComboBox_DiasSemana.CD_DIASEMANA))
    End If
    If ComboBox_Selecionado(cboConsultorio) Then
      sSqlText = sSqlText & " AND LSTPR.ID_CONSULTORIO = " & cboConsultorio.SelectedValue
    End If

    sSqlText = sSqlText & " ORDER BY EMPRE.NO_PESSOA, LSTPR.NO_CONSULTORIO, LSTPR.DH_FUNCIONAMENTO"

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_PESSOA_HORARIO,
                                                           const_GridListagem_Unidade,
                                                           const_GridListagem_Consultorio,
                                                           const_GridListagem_Status,
                                                           const_GridListagem_Data,
                                                           const_GridListagem_Dia,
                                                           const_GridListagem_HorarioInicio,
                                                           const_GridListagem_HorarioFim,
                                                           const_GridListagem_Profssional,
                                                           const_GridListagem_QuantidadeAtendimento,
                                                           const_GridListagem_QuantidadeRetorno,
                                                           const_GridListagem_DataEspecial})
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboEmpresa.SelectedIndex = -1
    cboProfissional.SelectedIndex = -1
    cboDiaSemana.SelectedIndex = -1
    cboStatus.SelectedIndex = -1
    cboConsultorio.SelectedIndex = -1
  End Sub

  Private Sub frmConsultaConstultorioOcupacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtDataOcupacaoInicial.Value = Now()
    txtDataOcupacaoFinal.Value = Now().AddDays(15)

    ComboBox_Carregar(cboEmpresa, enSql.Empresa)
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboDiaSemana, enSql.DiasSemana)
    ComboBox_Carregar(cboConsultorio, enSql.Consultorio_Todos)
    ComboBox_Carregar(cboStatus, New String() {const_Status_Disponivel, const_Status_Ocupado})
    cboStatus.SelectedIndex = -1

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_PESSOA_HORARIO", 0)
    objGrid_Coluna_Add(grdListagem, "Unidade", 100)
    objGrid_Coluna_Add(grdListagem, "Consultório", 100)
    objGrid_Coluna_Add(grdListagem, "Status", 100)
    objGrid_Coluna_Add(grdListagem, "Data", 100, , , , , const_Formato_DataHoraCurta)
    objGrid_Coluna_Add(grdListagem, "Dia", 100)
    objGrid_Coluna_Add(grdListagem, "Horário Início", 100)
    objGrid_Coluna_Add(grdListagem, "Horário Fim", 100)
    objGrid_Coluna_Add(grdListagem, "Profssional", 100)
    objGrid_Coluna_Add(grdListagem, "Qtde. Atendimento", 100)
    objGrid_Coluna_Add(grdListagem, "Qtde. Retorno", 100)
    objGrid_Coluna_Add(grdListagem, "Data Especial", 100)
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    Dim iCont As Integer
    Dim sSQ_PESSOA_HORARIO As String = 0

    For iCont = 0 To grdListagem.Rows.Count - 1
      FNC_Str_Adicionar(sSQ_PESSOA_HORARIO, objGrid_Valor(grdListagem, const_GridListagem_SQ_PESSOA_HORARIO, iCont), ",")
    Next

    FormRelatorioConstultorioOcupacao(sSQ_PESSOA_HORARIO)
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub
End Class