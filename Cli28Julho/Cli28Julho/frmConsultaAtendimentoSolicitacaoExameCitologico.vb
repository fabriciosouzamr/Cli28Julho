Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaAtendimentoSolicitacaoExameCitologico
	Const const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO As Integer = 0
	Const const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO As Integer = 1
	Const const_GridListagem_DH_CLINICA_EXAME_CITOLOGICO As Integer = 2
	Const const_GridListagem_CD_CLINICA_ATENDIMENTO As Integer = 3
	Const const_GridListagem_NO_CONVENIO As Integer = 4
	Const const_GridListagem_NO_PESSOA As Integer = 5
	Const const_GridListagem_DS_IDADE As Integer = 6
	Const const_GridListagem_DS_FILHOS As Integer = 7
	Const const_GridListagem_DS_ABORTO As Integer = 8
	Const const_GridListagem_DS_MEDICO_EXTERNO As Integer = 9
	Const const_GridListagem_DS_COLETA As Integer = 10
	Const const_GridListagem_DS_UM As Integer = 11
	Const const_GridListagem_DS_LOCAL_COLETA As Integer = 12
	Const const_GridListagem_IC_DIU As Integer = 13
	Const const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO_LOTE As Integer = 14
	Const const_GridListagem_ID_CLINICA_ATENDIMENTO As Integer = 15
	Const const_GridListagem_DT_ENVIO As Integer = 16
	Const const_GridListagem_DT_CHEGADA As Integer = 17

	Dim oDBGrid As New UltraWinDataSource.UltraDataSource

	Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
		If objGrid_LinhaSelecionada(grdListagem) = -1 Then
			FNC_Mensagem("Selecione o lançamento a ser impresso")
			Exit Sub
		End If

    FormRelatorioExameCitologico(objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO), False)
  End Sub

	Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
		Dim sSqlText As String
		Dim sSqlText_Where As String = ""

    sSqlText = "SELECT CLEXC.SQ_CLINICA_EXAME_CITOLOGICO," &
                      "CLEXC.CD_CLINICA_EXAME_CITOLOGICO," &
                      "CLEXC.DH_CLINICA_EXAME_CITOLOGICO," &
                      "ISNULL(CLATD.CD_CLINICA_ATENDIMENTO, CLVND.CD_CLINICA_VENDA)," &
                      "CONVE.NO_CONVENIO," &
                      "PESSO.NO_PESSOA," &
                      "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S')," &
                      "CLEXC.DS_FILHOS," &
                      "CLEXC.DS_ABORTO," &
                      "CLEXC.DS_MEDICO_EXTERNO," &
                      "CLEXC.DS_COLETA," &
                      "CLEXC.DS_UM," &
                      "CLEXC.DS_LOCAL_COLETA," &
                      "CLEXC.IC_DIU," &
                      "CLEXL.CD_CLINICA_EXAME_CITOLOGICO_LOTE," &
                      "CLEXC.ID_CLINICA_ATENDIMENTO," &
                      "CLEXL.DT_ENVIO," &
                      "ISNULL(CLEXC.DT_CHEGADA, CLEXL.DT_CHEGADA) DT_CHEGADA" &
               " FROM TB_CLINICA_EXAME_CITOLOGICO	CLEXC" &
                " LEFT JOIN TB_CLINICA_ATENDIMENTO	CLATD ON CLATD.SQ_CLINICA_ATENDIMENTO = CLEXC.ID_CLINICA_ATENDIMENTO" &
                " LEFT JOIN TB_CLINICA_VENDA	CLVND ON CLVND.SQ_CLINICA_VENDA = CLEXC.ID_CLINICA_VENDA" &
                "	LEFT JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                                          " OR PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                " LEFT JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                " LEFT JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO" &
                " LEFT JOIN TB_CLINICA_EXAME_CITOLOGICO_LOTE	CLEXL ON CLEXL.SQ_CLINICA_EXAME_CITOLOGICO_LOTE = CLEXC.ID_CLINICA_EXAME_CITOLOGICO_LOTE"

    If ComboBox_Selecionado(cboLoteExameCitologico) Then
			FNC_Str_Adicionar(sSqlText_Where, "CLEXC.ID_CLINICA_EXAME_CITOLOGICO_LOTE = " & cboLoteExameCitologico.SelectedValue, " AND ")
		End If
		If Trim(txtCodigoExameCitologico.Text) <> "" Then
			FNC_Str_Adicionar(sSqlText_Where, "CLEXC.CD_CLINICA_EXAME_CITOLOGICO_LOTE = " & FNC_QuotedStr(txtCodigoExameCitologico.Text), " AND ")
		End If
		If IsDate(txtDataEnvioInicio.Text) Then
			FNC_Str_Adicionar(sSqlText_Where, "CAST(CLEXC.DH_CLINICA_EXAME_CITOLOGICO AS DATE) >= " & FNC_QuotedStr(txtDataEnvioInicio.Text), " AND ")
		End If
		If IsDate(txtDataEnvioFim.Text) Then
			FNC_Str_Adicionar(sSqlText_Where, "CAST(CLEXC.DH_CLINICA_EXAME_CITOLOGICO AS DATE) <= " & FNC_QuotedStr(txtDataEnvioFim.Text), " AND ")
		End If
		If psqPessoa.ID_Pessoa > 0 Then
			FNC_Str_Adicionar(sSqlText_Where, "CLATD.ID_PESSOA = " & psqPessoa.ID_Pessoa, " AND ")
		End If

		If Trim(sSqlText_Where) <> "" Then
			sSqlText = sSqlText & " WHERE " & sSqlText_Where
		End If

		objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO,
																													 const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO,
																													 const_GridListagem_DH_CLINICA_EXAME_CITOLOGICO,
																													 const_GridListagem_CD_CLINICA_ATENDIMENTO,
																													 const_GridListagem_NO_CONVENIO,
																													 const_GridListagem_NO_PESSOA,
																													 const_GridListagem_DS_IDADE,
																													 const_GridListagem_DS_FILHOS,
																													 const_GridListagem_DS_ABORTO,
																													 const_GridListagem_DS_MEDICO_EXTERNO,
																													 const_GridListagem_DS_COLETA,
																													 const_GridListagem_DS_UM,
																													 const_GridListagem_DS_LOCAL_COLETA,
																													 const_GridListagem_IC_DIU,
																													 const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO_LOTE,
																													 const_GridListagem_ID_CLINICA_ATENDIMENTO,
																													 const_GridListagem_DT_ENVIO,
																													 const_GridListagem_DT_CHEGADA})
	End Sub

	Private Sub frmConsultaAtendimentoSolicitacaoExameCitologico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
		objGrid_Coluna_Add(grdListagem, "SQ_CLINICA_EXAME_CITOLOGICO", 0)
		objGrid_Coluna_Add(grdListagem, "Código do Exame Citológico", 150)
		objGrid_Coluna_Add(grdListagem, "D/H do Exame Citológico", 150, , ,,, const_Formato_DataHora)
		objGrid_Coluna_Add(grdListagem, "Prontunário", 150)
		objGrid_Coluna_Add(grdListagem, "Convênio", 150)
		objGrid_Coluna_Add(grdListagem, "Paciente", 150)
		objGrid_Coluna_Add(grdListagem, "Idade", 150)
		objGrid_Coluna_Add(grdListagem, "Filhos", 150)
		objGrid_Coluna_Add(grdListagem, "Aborto", 150)
		objGrid_Coluna_Add(grdListagem, "Médico Externo", 150)
		objGrid_Coluna_Add(grdListagem, "Coleta", 150)
		objGrid_Coluna_Add(grdListagem, "UM", 150)
		objGrid_Coluna_Add(grdListagem, "Local de Coleta", 150)
		objGrid_Coluna_Add(grdListagem, "DIU?", 150)
		objGrid_Coluna_Add(grdListagem, "Código do Lote do Exame Citológico", 150)
		objGrid_Coluna_Add(grdListagem, "ID_CLINICA_ATENDIMENTO", 0)
		objGrid_Coluna_Add(grdListagem, "D/H do Envio", 150, , ,,, const_Formato_DataHora)
		objGrid_Coluna_Add(grdListagem, "D/H do Chegada", 150, , ,,, const_Formato_DataHora)

		ComboBox_Carregar(cboLoteExameCitologico, enSql.LoteExameCitologico)

		txtDataEnvioInicio.Value = Nothing
		txtDataEnvioFim.Value = Nothing
	End Sub

	Private Sub cmdRetorno_Click(sender As Object, e As EventArgs) Handles cmdRetorno.Click
		If objGrid_LinhaSelecionada(grdListagem) = -1 Then
			FNC_Mensagem("Selecione o lançamento a ser determinado a chegada")
			Exit Sub
		End If
		If Trim(objGrid_Valor(grdListagem, const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO_LOTE, , "")) = "" Then
			FNC_Mensagem("Esse exame citológico não foi envivado para análise")
			Exit Sub
		End If

		Dim oForm As New frmConsultaAtendimentoSolicitacaoExameCitologicoChegada

		oForm.iSQ_CLINICA_EXAME_CITOLOGICO = objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO)

		FNC_AbriTela(oForm, , True, True)
	End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub
End Class