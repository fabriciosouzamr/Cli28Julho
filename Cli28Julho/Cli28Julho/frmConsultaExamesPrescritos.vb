Imports Infragistics.Win

Public Class frmConsultaExamesPrescritos
  Const const_GridListagem_UNIDADE As Integer = 0
  Const const_GridListagem_DH_CLINICA_ATENDIMENTO As Integer = 1
  Const const_GridListagem_CD_AGENDAMENTO As Integer = 2
  Const const_GridListagem_PACIENTE As Integer = 3
  Const const_GridListagem_CD_NUMERO As Integer = 4
  Const const_GridListagem_CIDADE As Integer = 5
  Const const_GridListagem_PROFISSIONAL As Integer = 6
  Const const_GridListagem_ESPECIALIDADE As Integer = 7
  Const const_GridListagem_PROCEDIMENTO As Integer = 8
  Const const_GridListagem_VALOR_TABELA As Integer = 9
  Const const_GridListagem_CONVENIO As Integer = 10
  Const const_GridListagem_CD_ORCAMENTO_CLIENTE As Integer = 11
  Const const_GridListagem_DH_ORCAMENTO_CLIENTE As Integer = 12
  Const const_GridListagem_VL_ORCADO As Integer = 13
  Const const_GridListagem_DH_VENDA As Integer = 14
  Const const_GridListagem_CD_CLINICA_VENDA As Integer = 15
  Const const_GridListagem_VL_PROCEDIMENTO As Integer = 16

  Dim oDBGrid As New Infragistics.Win.UltraWinDataSource.UltraDataSource

  Private Sub fomConsultaExamesPrescritos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtDataLancamentoInicial.Value = Nothing
    txtDataLancamentoFinal.Value = Nothing
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboCidade, enSql.Cidade)
    ComboBox_Carregar(cboEspecialidade, enSql.Especialidade)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "Unidade", 100)
    objGrid_Coluna_Add(grdListagem, "D/H Atendimento", 100)
    objGrid_Coluna_Add(grdListagem, "Código Agendamento", 100)
    objGrid_Coluna_Add(grdListagem, "Paciente", 100)
    objGrid_Coluna_Add(grdListagem, "Número", 100)
    objGrid_Coluna_Add(grdListagem, "Cidade", 100)
    objGrid_Coluna_Add(grdListagem, "Profissional", 100)
    objGrid_Coluna_Add(grdListagem, "Especialidade", 100)
    objGrid_Coluna_Add(grdListagem, "procedimento", 100)
    objGrid_Coluna_Add(grdListagem, "Valor da Tabela", 100, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "Convênio", 100)
    objGrid_Coluna_Add(grdListagem, "Código do Orçamento", 100)
    objGrid_Coluna_Add(grdListagem, "D/H do Orçamento", 100)
    objGrid_Coluna_Add(grdListagem, "Vlr. Orçado", 100, , , , , const_Formato_Valor)
    objGrid_Coluna_Add(grdListagem, "D/H da Venda", 100)
    objGrid_Coluna_Add(grdListagem, "Código da Venda", 100)
    objGrid_Coluna_Add(grdListagem, "Vlr. Venda", 100, , , , , const_Formato_Valor)
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String

    sSqlText = "SELECT EMPRE.NO_PESSOA AS UNIDADE," &
                      "CLATD.DH_CLINICA_ATENDIMENTO," &
                      "AGEND.CD_AGENDAMENTO," &
                      "PESSO.NO_PESSOA AS PACIENTE," &
                      "PSTEL.CD_NUMERO," &
                      "ENDER.NO_CIDADE AS CIDADE," &
                      "PESSO_PROFI.NO_PESSOA AS PROFISSIONAL," &
                      "ESPEC.NO_ESPECIALIDADE AS ESPECIALIDADE," &
                      "PROCE.NO_PROCEDIMENTO AS PROCEDIMENTO," &
                      "CVNPC.VL_PROCEDIMENTO AS VALOR_TABELA," &
                      "CONVE.NO_CONVENIO AS CONVENIO," &
                      "OCCLI.CD_ORCAMENTO_CLIENTE AS [Nº ORÇAMENTO]," &
                      "OCCLI.DH_ORCAMENTO_CLIENTE AS [DATA ORÇAMENTO]," &
                      "OCPCD.VL_ORCADO," &
                      "CLVND.DH_VENDA AS DATA_VENDA," &
                      "CLVND.CD_CLINICA_VENDA AS COD_VENDA," &
                      "CVPCD.VL_PROCEDIMENTO AS VALOR_NA_VENDA" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                " INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = CLATD.ID_EMPRESA" &
                " INNER JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO" &
                " INNER JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = AGEND.ID_ESPECIALIDADE" &
                " INNER JOIN TB_CLINICA_PROCEDIMENTO CLPCD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLPCD.ID_CLINICA_ATENDIMENTO" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO" &
                " INNER JOIN TB_PESSOA AS PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                 " LEFT JOIN VW_ENDERECO_PRIMEIRO ENDER ON ENDER .ID_PESSOA = PESSO.SQ_PESSOA" &
                 " LEFT JOIN VW_PESSOA_TELEFONE_PRIMEIRO PSTEL ON PSTEL.ID_PESSOA = PESSO.SQ_PESSOA" &
                 " LEFT JOIN TB_ORCAMENTO_CLIENTE_PROCEDIMENTO OCPCD ON OCPCD.ID_CLINICA_PROCEDIMENTO = CLPCD.SQ_CLINICA_PROCEDIMENTO" &
                 " LEFT JOIN TB_ORCAMENTO_CLIENTE OCCLI ON OCPCD.ID_ORCAMENTO_CLIENTE = OCCLI.SQ_ORCAMENTO_CLIENTE" &
                 " LEFT JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPCD ON (CVPCD.ID_ORCAMENTO_CLIENTE_PROCEDIMENTO = OCPCD.SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO OR " &
                                                                    "CVPCD.ID_CLINICA_PROCEDIMENTO = CLPCD.SQ_CLINICA_PROCEDIMENTO)" &
                 " LEFT JOIN TB_CLINICA_VENDA CLVND ON CLVND.SQ_CLINICA_VENDA = CVPCD.ID_CLINICA_VENDA" &
                 " LEFT JOIN TB_CONVENIO_PROCEDIMENTO CVNPC ON CVNPC.ID_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO" &
                                                         " AND CVNPC.ID_CONVENIO = AGEND.ID_CONVENIO" &
                                                         " AND CVNPC.IC_PADRAO = 'S'" &
               " WHERE CLVND.DH_CANCELAR IS NULL"

    If IsDate(txtDataLancamentoInicial.Text) Then
      FNC_Str_Adicionar(sSqlText, "CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) >= " & FNC_QuotedStr(txtDataLancamentoInicial.Text), " AND ")
    End If
    If IsDate(txtDataLancamentoFinal.Text) Then
      FNC_Str_Adicionar(sSqlText, "CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) <= " & FNC_QuotedStr(txtDataLancamentoFinal.Text), " AND ")
    End If
    If ComboBox_Selecionado(cboProfissional) Then
      FNC_Str_Adicionar(sSqlText, "CLATD.ID_PESSOA_PROFISSIONAL = " & cboProfissional.SelectedValue, " AND ")
    End If
    If psqProcedimento.Identificador > 0 Then
      FNC_Str_Adicionar(sSqlText, "CLPCD.ID_PROCEDIMENTO = " & psqProcedimento.Identificador, " AND ")
    End If
    If ComboBox_Selecionado(cboCidade) Then
      FNC_Str_Adicionar(sSqlText, "ENDER.ID_CIDADE = " & cboCidade.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboEspecialidade) Then
      FNC_Str_Adicionar(sSqlText, "AGEND.ID_ESPECIALIDADE = " & cboEspecialidade.SelectedValue, " AND ")
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_UNIDADE,
                                                           const_GridListagem_DH_CLINICA_ATENDIMENTO,
                                                           const_GridListagem_CD_AGENDAMENTO,
                                                           const_GridListagem_PACIENTE,
                                                           const_GridListagem_CD_NUMERO,
                                                           const_GridListagem_CIDADE,
                                                           const_GridListagem_PROFISSIONAL,
                                                           const_GridListagem_ESPECIALIDADE,
                                                           const_GridListagem_PROCEDIMENTO,
                                                           const_GridListagem_VALOR_TABELA,
                                                           const_GridListagem_CONVENIO,
                                                           const_GridListagem_CD_ORCAMENTO_CLIENTE,
                                                           const_GridListagem_DH_ORCAMENTO_CLIENTE,
                                                           const_GridListagem_VL_ORCADO,
                                                           const_GridListagem_DH_VENDA,
                                                           const_GridListagem_CD_CLINICA_VENDA,
                                                           const_GridListagem_VL_PROCEDIMENTO})
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    txtDataLancamentoInicial.Value = Nothing
    txtDataLancamentoFinal.Value = Nothing
    cboProfissional.SelectedIndex = -1
    cboEspecialidade.SelectedIndex = -1
    psqProcedimento.Identificador = 0
    cboCidade.SelectedIndex = -1
  End Sub

  Private Sub ComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProfissional.KeyDown,
                                                                            cboCidade.KeyDown,
                                                                            cboEspecialidade.KeyDown
    If e.KeyCode = Keys.Delete Then
      Dim oComboBox As New ComboBox

      oComboBox = sender

      oComboBox.SelectedIndex = -1
    End If
  End Sub
End Class