Imports Infragistics.Win

Public Class frmConsultaOcupacaoTempoPrevisto
  Const const_GridListagem_SQ_CLINICA_ATENDIMENTO As Integer = 0
  Const const_GridListagem_Unidade As Integer = 1
  Const const_GridListagem_Profssional As Integer = 2
  Const const_GridListagem_Paciente As Integer = 3
  Const const_GridListagem_Idade As Integer = 4
  Const const_GridListagem_InicioAtendimento As Integer = 5
  Const const_GridListagem_FimAtendimento As Integer = 6
  Const const_GridListagem_Tempo As Integer = 7

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String

    sSqlText = "Select CLATD.SQ_CLINICA_ATENDIMENTO," &
                      "EMPRE.NO_PESSOA As UNIDADE," &
                      "PROFI.NO_PESSOA As PROFISSIONAL," &
                      "PESSO.NO_PESSOA As PACIENTE," &
                      "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') DS_NASCIMENTO," &
                      "CLATD.DH_CLINICA_INICIO_ATENDIMENTO," &
                      "CLATD.DH_FIM_ATENDIMENTO," &
                      "dbo.FC_ConverteSegundosEmHoras(DATEDIFF(SECOND, DH_CLINICA_INICIO_ATENDIMENTO, DH_FIM_ATENDIMENTO)) AS TEMPO" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_PESSOA PROFI ON CLATD.ID_PESSOA_PROFISSIONAL = PROFI.SQ_PESSOA" &
                " INNER JOIN TB_PESSOA AS EMPRE ON EMPRE.SQ_PESSOA = CLATD.ID_EMPRESA" &
                " INNER JOIN TB_PESSOA AS PESSO ON CLATD.ID_PESSOA = PESSO.SQ_PESSOA" &
               " WHERE CLATD.DH_FIM_ATENDIMENTO IS NOT NULL"

    If ComboBox_Selecionado(cboEmpresa) Then
      sSqlText = sSqlText & " AND CLATD.ID_EMPRESA = " & cboEmpresa.SelectedValue
    End If
    If ComboBox_Selecionado(cboProfissional) Then
      sSqlText = sSqlText & " AND CLATD.ID_PESSOA_PROFISSIONAL = " & cboProfissional.SelectedValue
    End If
    If IsDate(txtDataAtendimentoInicial.Text) Then
      sSqlText = sSqlText & " AND CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) >= " & FNC_QuotedStr(txtDataAtendimentoInicial.Text)
    End If
    If IsDate(txtDataAtendimentoFinal.Text) Then
      sSqlText = sSqlText & " AND CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) <= " & FNC_QuotedStr(txtDataAtendimentoFinal.Text)
    End If
    If psqPessoa.ID_Pessoa > 0 Then
      sSqlText = sSqlText & " AND CLATD.ID_PESSOA = " & psqPessoa.ID_Pessoa
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_CLINICA_ATENDIMENTO,
                                                           const_GridListagem_Unidade,
                                                           const_GridListagem_Profssional,
                                                           const_GridListagem_Paciente,
                                                           const_GridListagem_Idade,
                                                           const_GridListagem_InicioAtendimento,
                                                           const_GridListagem_FimAtendimento,
                                                           const_GridListagem_Tempo})

    Dim oData As DataTable

    sSqlText = "SELECT COUNT(*) QUANTIDADE," &
                      "CAST(MIN(DH_CLINICA_INICIO_ATENDIMENTO) AS DATETIME) DH_CLINICA_INICIO_ATENDIMENTO," &
                      "CAST(MAX(DH_FIM_ATENDIMENTO) AS DATETIME) DH_FIM_ATENDIMENTO," &
                      "dbo.FC_ConverteSegundosEmHoras(DATEDIFF(SECOND, MIN(DH_CLINICA_INICIO_ATENDIMENTO), MAX(DH_FIM_ATENDIMENTO))) TEMPO" &
               " FROM (" + sSqlText + ") X"
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      If oData.Rows(0).Item("QUANTIDADE") = 0 Then
        lblQuantidade.Text = ""
        lblInicio.Text = ""
        lblTermino.Text = ""
        lblTempo.Text = ""
      Else
        lblQuantidade.Text = oData.Rows(0).Item("QUANTIDADE")
        lblInicio.Text = oData.Rows(0).Item("DH_CLINICA_INICIO_ATENDIMENTO")
        lblTermino.Text = oData.Rows(0).Item("DH_FIM_ATENDIMENTO")
        lblTempo.Text = oData.Rows(0).Item("TEMPO")
      End If
    End If

    oData.Dispose()
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboEmpresa.SelectedIndex = -1
    cboProfissional.SelectedIndex = -1
    txtDataAtendimentoInicial.Value = Nothing
    txtDataAtendimentoFinal.Value = Nothing
  End Sub

  Private Sub frmConsultaOcupacaoTempoPrevisto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboEmpresa, enSql.Empresa)
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    txtDataAtendimentoInicial.Value = Nothing
    txtDataAtendimentoFinal.Value = Nothing

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_CLINICA_ATENDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "Unidade", 100)
    objGrid_Coluna_Add(grdListagem, "Profssional", 100)
    objGrid_Coluna_Add(grdListagem, "Paciente", 100)
    objGrid_Coluna_Add(grdListagem, "Idade", 100)
    objGrid_Coluna_Add(grdListagem, "Início Atendimento", 120, ,,,, const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Fim Atendimento", 120, ,,,, const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Tempo", 100)

    lblTermino.Text = ""
    lblInicio.Text = ""
    lblQuantidade.Text = ""
    lblTempo.Text = ""
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    Dim iCont As Integer
    Dim sSQ_CLINICA_ATENDIMENTO As String = 0

    For iCont = 0 To grdListagem.Rows.Count - 1
      FNC_Str_Adicionar(sSQ_CLINICA_ATENDIMENTO, objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_ATENDIMENTO, iCont), ",")
    Next

    FormRelatorioOcupacaoTempoPrevisto(sSQ_CLINICA_ATENDIMENTO, lblTermino.Text, lblInicio.Text, lblQuantidade.Text, lblTempo.Text)
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub
End Class