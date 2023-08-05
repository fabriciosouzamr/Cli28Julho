Imports Infragistics.Win

Public Class frmConsultaFaturamento
  Const const_GridListagem_DH_AGENDAMENTO As Integer = 0
  Const const_GridListagem_PROFISSIONAL As Integer = 1
  Const const_GridListagem_PROFINTE As Integer = 2
  Const const_GridListagem_CD_CLINICA_VENDA As Integer = 3
  Const const_GridListagem_CD_AGENDAMENTO As Integer = 4
  Const const_GridListagem_DH_ATENDIMENTO_REALIZADO As Integer = 5
  Const const_GridListagem_NO_PROCEDIMENTO As Integer = 6
  Const const_GridListagem_FATURA_DATA As Integer = 7
  Const const_GridListagem_FATURA_VALOR As Integer = 8
  Const const_GridListagem_VL_PARCELA As Integer = 9

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub frmConsultaFaturamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "D/H Agendamento", 100)
    objGrid_Coluna_Add(grdListagem, "Profissional", 100)
    objGrid_Coluna_Add(grdListagem, "Paciente", 100)
    objGrid_Coluna_Add(grdListagem, "Cód. Venda", 100)
    objGrid_Coluna_Add(grdListagem, "Cód. Agendanto", 100)
    objGrid_Coluna_Add(grdListagem, "D/H Atendimento Realizado", 100, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Procedimento", 100)
    objGrid_Coluna_Add(grdListagem, "Data Fatura", 100, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Valor Fatura", 100)
    objGrid_Coluna_Add(grdListagem, "Vlr. Parcela", 100)

    Limpar()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String
    Dim sSqlText_Where As String

    If Not IsDate(txtDataAgendamentoInicial.Text) Or Not IsDate(txtDataAgendamentoFinal.Text) Then
      FNC_Mensagem("Informe o período de contsulta")
      Exit Sub
    End If

    sSqlText = "SELECT DH_AGENDAMENTO," &
                      "NO_PROFISSIONAL," &
                      "NO_PACIENTE," &
                      "CD_CLINICA_VENDA," &
                      "CD_AGENDAMENTO," &
                      "DH_ATENDIMENTO_REALIZADO," &
                      "NO_PROCEDIMENTO," &
                      "FATURA_DATA," &
                      "FATURA_VALOR," &
                      "VL_PARCELA" &
               " FROM VW_CONSULTAFATURAMENTO"

    If ComboBox_Selecionado(cboProfissional) Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_PROFISSIONAL = " & cboProfissional.SelectedValue, " AND ")
    End If
    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_PACIENTE = " & psqPessoa.ID_Pessoa, " AND ")
    End If
    If Trim(txtCodigoAgendamento.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "CD_AGENDAMENTO = " & FNC_QuotedStr(txtCodigoAgendamento.Text), " AND ")
    End If
    If Trim(txtCodigoVenda.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where, "CD_CLINICA_VENDA = " & FNC_QuotedStr(txtCodigoVenda.Text), " AND ")
    End If
    If IsDate(txtDataAgendamentoInicial.Value) Then
      FNC_Str_Adicionar(sSqlText_Where, "CAST(DH_AGENDAMENTO AS DATE) >= " & FNC_QuotedStr(txtDataAgendamentoInicial.Text), " AND ")
    End If
    If IsDate(txtDataAgendamentoFinal.Value) Then
      FNC_Str_Adicionar(sSqlText_Where, "CAST(DH_AGENDAMENTO AS DATE) <= " & FNC_QuotedStr(txtDataAgendamentoFinal.Text), " AND ")
    End If
    If IsDate(txtDataFaturaInicial.Value) Then
      FNC_Str_Adicionar(sSqlText_Where, "CAST(FATURA_DATA AS DATE) >= " & FNC_QuotedStr(txtDataFaturaInicial.Text), " AND ")
    End If
    If IsDate(txtDataFaturaFinal.Value) Then
      FNC_Str_Adicionar(sSqlText_Where, "CAST(FATURA_DATA AS DATE) <= " & FNC_QuotedStr(txtDataFaturaFinal.Text), " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " WHERE " & sSqlText_Where
    End If

    sSqlText = sSqlText & " ORDER BY DH_AGENDAMENTO DESC, NO_PROFISSIONAL, NO_PACIENTE"

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_DH_AGENDAMENTO,
                                                           const_GridListagem_PROFISSIONAL,
                                                           const_GridListagem_PROFINTE,
                                                           const_GridListagem_CD_CLINICA_VENDA,
                                                           const_GridListagem_CD_AGENDAMENTO,
                                                           const_GridListagem_DH_ATENDIMENTO_REALIZADO,
                                                           const_GridListagem_NO_PROCEDIMENTO,
                                                           const_GridListagem_FATURA_DATA,
                                                           const_GridListagem_FATURA_VALOR,
                                                           const_GridListagem_VL_PARCELA})
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    Limpar()
  End Sub

  Private Sub Limpar()
    txtDataAgendamentoInicial.Text = ""
    txtDataAgendamentoFinal.Text = ""
    txtDataFaturaInicial.Text = ""
    txtDataFaturaFinal.Text = ""
    cboProfissional.SelectedIndex = -1
    psqPessoa.ID_Pessoa = 0
    txtCodigoAgendamento.Text = ""
    txtCodigoVenda.Text = ""
  End Sub

  Private Sub cmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub cboProfissional_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProfissional.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboProfissional.SelectedIndex = -1
    End If
  End Sub
End Class