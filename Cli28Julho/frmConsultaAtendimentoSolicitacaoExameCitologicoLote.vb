Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaAtendimentoSolicitacaoExameCitologicoLote
  Const const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO_LOTE As Integer = 0
  Const const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO_LOTE As Integer = 1
  Const const_GridListagem_CD_PRONTUARIO As Integer = 2
  Const const_GridListagem_NO_PESSOA_PROFISSIONAL As Integer = 3
  Const const_GridListagem_DT_ENVIO As Integer = 4
  Const const_GridListagem_DT_CHEGADA As Integer = 5

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Dim sSqlText As String

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String = ""
    Dim sSqlText_Where As String = ""

    sSqlText = "SELECT CLEXL.SQ_CLINICA_EXAME_CITOLOGICO_LOTE," &
                      "CLEXL.CD_CLINICA_EXAME_CITOLOGICO_LOTE," &
                      "PESSO.SQ_PESSOA," &
                      "PESSO.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                      "CLEXL.DT_ENVIO," &
                      "CLEXL.DT_CHEGADA" &
               " FROM TB_CLINICA_EXAME_CITOLOGICO_LOTE CLEXL" &
               "  INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLEXL.ID_PESSOA_PROFISSIONAL"

    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, " CLEXL.ID_PESSOA_PROFISSIONAL = " & psqPessoa.ID_Pessoa, " AND ")
    End If
    If IsDate(txtDataEnvioInicio.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CLEXL.DT_ENVIO >= " & FNC_QuotedStr(txtDataEnvioInicio.Text), " AND ")
    End If
    If IsDate(txtDataEnvioFim.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CLEXL.DT_ENVIO <= " & FNC_QuotedStr(txtDataEnvioFim.Text), " AND ")
    End If

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO_LOTE,
                                                           const_GridListagem_CD_CLINICA_EXAME_CITOLOGICO_LOTE,
                                                           const_GridListagem_CD_PRONTUARIO,
                                                           const_GridListagem_NO_PESSOA_PROFISSIONAL,
                                                           const_GridListagem_DT_ENVIO,
                                                           const_GridListagem_DT_CHEGADA})
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(New frmCadastroAtendimentoSolicitacaoExameCitologicoLote)
  End Sub

  Private Sub frmConsultaAtendimentoSolicitacaoExameCitologicoLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_CLINICA_EXAME_CITOLOGICO_LOTE", 0)
    objGrid_Coluna_Add(grdListagem, "Código do Lote Exame Citológico", 300)
    objGrid_Coluna_Add(grdListagem, "Prontuário", 300)
    objGrid_Coluna_Add(grdListagem, "Profissional de Análise", 300)
    objGrid_Coluna_Add(grdListagem, "Data de Envio", 150)
    objGrid_Coluna_Add(grdListagem, "Data de Chegada", 150)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    txtDataEnvioInicio.Value = Nothing
    txtDataEnvioFim.Value = Nothing
  End Sub

  Private Sub cmdRetorno_Click(sender As Object, e As EventArgs) Handles cmdRetorno.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser determinado a chegada")
      Exit Sub
    End If

    Dim oForm As New frmConsultaAtendimentoSolicitacaoExameCitologicoLoteChegada

    oForm.iSQ_CLINICA_EXAME_CITOLOGICO_LOTE = objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO_LOTE)

    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser impresso")
      Exit Sub
    End If

    FormRelatorioExameCitologicoLote(objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO_LOTE))
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o lançamento a ser alterado")
      Exit Sub
    End If

    Dim oForm As New frmCadastroAtendimentoSolicitacaoExameCitologicoLote

    oForm.iSQ_CLINICA_EXAME_CITOLOGICO_LOTE = objGrid_Valor(grdListagem, const_GridListagem_SQ_CLINICA_EXAME_CITOLOGICO_LOTE)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub frmConsultaAtendimentoSolicitacaoExameCitologicoLote_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub
End Class