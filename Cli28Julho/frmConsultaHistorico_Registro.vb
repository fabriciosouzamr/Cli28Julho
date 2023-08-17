Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmConsultaHistorico_Registro
  Const const_GridListagem_SQ_HISTORICO As Integer = 0
  Const const_GridListagem_ID_OPT_PROCESSO As Integer = 1
  Const const_GridListagem_ID_OPT_ACAO As Integer = 2
  Const const_GridListagem_ID_OPT_ERRO As Integer = 3
  Const const_GridListagem_NO_OPT_PROCESSO As Integer = 4
  Const const_GridListagem_NO_OPT_ACAO As Integer = 5
  Const const_GridListagem_CD_HISTORICO As Integer = 6
  Const const_GridListagem_DT_HISTORICO As Integer = 7
  Const const_GridListagem_DS_HISTORICO As Integer = 8
  Const const_GridListagem_NO_USUARIO As Integer = 9
  Const const_GridListagem_NO_COMPUTADOR_NOME As Integer = 10
  Const const_GridListagem_CD_VERSAO_SISTEMA As Integer = 11
  Const const_GridListagem_NO_OPT_ERRO As Integer = 12

  Public iProcessso As Integer
  Public iID_REGISTRO As Integer
  Public iID_REGISTROS As List(Of Integer)
  Public iID_EMPRESA As Integer

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub frmConsultaHistorico_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim bErroIdentificado As Boolean

    bErroIdentificado = (Not FNC_In(iProcessso, enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode()))

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, False, , , , True, , , False)
    objGrid_Coluna_Add(grdListagem, "SQ_HISTORICO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_PROCESSO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_ACAO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_ERRO", 0)
    objGrid_Coluna_Add(grdListagem, "Processo", 0)
    objGrid_Coluna_Add(grdListagem, "Ação", 70)
    objGrid_Coluna_Add(grdListagem, "Código", 100)
    objGrid_Coluna_Add(grdListagem, "D/H Histórico", 100,,, ColumnStyle.DateTime)
    objGrid_Coluna_Add(grdListagem, "Descrição", 200)
    objGrid_Coluna_Add(grdListagem, "Usuário", 150)
    objGrid_Coluna_Add(grdListagem, "Nome do Computador", 150)
    objGrid_Coluna_Add(grdListagem, "Versão Sistema", 110)
    objGrid_Coluna_Add(grdListagem, "Erro Identificado", 100).Hidden = (Not bErroIdentificado)

    Dim sSqlText As String = ""

    If Not iID_REGISTROS Is Nothing AndAlso iID_REGISTROS.Any() Then
      sSqlText = iID_REGISTROS.FirstOrDefault()
    Else
      sSqlText = iID_REGISTRO
    End If

    Select Case iProcessso
      Case enOpcoes.Processo_Historico_Clinica_Agendamento.GetHashCode()
        sSqlText = $"SELECT 'Agendamento: ' + RTRIM(CD_AGENDAMENTO) + ' (' + RTRIM(NO_PESSOA) + ')' FROM VW_AGENDAMENTO WHERE SQ_AGENDAMENTO = {sSqlText}"
      Case enOpcoes.Processo_Historico_Cadastro_CadastroDocumentoFiscal.GetHashCode()
        sSqlText = $"SELECT NO_DOCUMENTOFISCAL_TIPO + ': ' + CD_DOCUMENTOFISCAL + ' (' + NO_NATUREZAOPERACAO + ')' FROM VW_DOCUMENTOFISCAL WHERE SQ_DOCUMENTOFISCAL = {sSqlText}"
      Case enOpcoes.Processo_Historico_Cadastro_CadastroPaciente.GetHashCode()
        sSqlText = $"SELECT RTRIM(DBO.FC_FORMATARCPF_CNPJ(CD_CPF_CNPJ)) + ' - ' + NO_PESSOA FROM TB_PESSOA WHERE SQ_PESSOA = {sSqlText}"
      Case enOpcoes.Processo_Historico_Financeiro_Voucher.GetHashCode()
        sSqlText = $"SELECT 'Voucher: ' + RTRIM(CD_VOUCHER) + ' (' + RTRIM(NO_PESSOA) + ')'
                     FROM TB_VOUCHER V
                      INNER JOIN TB_PESSOA P ON P.SQ_PESSOA = V.ID_PESSOA
                     WHERE SQ_VOUCHER = {sSqlText}"
      Case enOpcoes.Processo_Historico_Financeiro_LancamentoContasaReceber_Pagar.GetHashCode()
        sSqlText = $"SELECT NO_OPT_TIPOMOVFINANCEIRA + ': ' + RTRIM(CD_MOVFINANCEIRA_PARCELA) + ' (' + RTRIM(NO_PESSOA) + ')' FROM VW_MOVFINANCEIRAPARCELA WHERE SQ_MOVFINANCEIRAPARCELA = {sSqlText}"
    End Select

    lblDescricao.Text = DBQuery_ValorUnico(sSqlText)

    CarregarDados()
  End Sub

  Private Sub CarregarDados()
    Dim sSqlText As String
    Dim sSqlText_WHere As String = ""
    Dim sSqlText_Registro As String = ""

    If Not iID_REGISTROS Is Nothing AndAlso iID_REGISTROS.Any() Then
      For Each registro As Integer In iID_REGISTROS
        FNC_Str_Adicionar(sSqlText_Registro, registro.ToString(), ", ")
      Next
    ElseIf iID_REGISTRO > 0 Then
      sSqlText_Registro = iID_REGISTRO.ToString()
    End If


    sSqlText = "SELECT SQ_HISTORICO," +
                      "ID_OPT_PROCESSO," +
                      "ID_OPT_ACAO," +
                      "ID_OPT_ERRO, " +
                      "NO_OPT_PROCESSO," +
                      "NO_OPT_ACAO," +
                      "CD_HISTORICO," +
                      "DT_HISTORICO," +
                      "DS_HISTORICO," +
                      "NO_USUARIO," +
                      "NO_COMPUTADOR_NOME," +
                      "CD_VERSAO_SISTEMA," +
                      "NO_OPT_ERRO" +
               " FROM VW_HISTORICO"

    If iID_EMPRESA > 0 Then
      FNC_Str_Adicionar(sSqlText_WHere, "ID_EMPRESA = " & iID_EMPRESA, " AND ")
    End If
    If Not String.IsNullOrEmpty(sSqlText_Registro) Then
      FNC_Str_Adicionar(sSqlText_WHere, "ID_REGISTRO IN (" & sSqlText_Registro & ")", " AND ")
    End If
    If iProcessso > 0 Then
      FNC_Str_Adicionar(sSqlText_WHere, "ID_OPT_PROCESSO = " & iProcessso, " AND ")
    End If

    If Trim(sSqlText_WHere) <> "" Then
      sSqlText = sSqlText + " WHERE " + sSqlText_WHere
    End If

    sSqlText = sSqlText &
               " ORDER BY DT_HISTORICO"

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_HISTORICO,
                                                           const_GridListagem_ID_OPT_PROCESSO,
                                                           const_GridListagem_ID_OPT_ACAO,
                                                           const_GridListagem_ID_OPT_ERRO,
                                                           const_GridListagem_NO_OPT_PROCESSO,
                                                           const_GridListagem_NO_OPT_ACAO,
                                                           const_GridListagem_CD_HISTORICO,
                                                           const_GridListagem_DT_HISTORICO,
                                                           const_GridListagem_DS_HISTORICO,
                                                           const_GridListagem_NO_USUARIO,
                                                           const_GridListagem_NO_COMPUTADOR_NOME,
                                                           const_GridListagem_CD_VERSAO_SISTEMA,
                                                           const_GridListagem_NO_OPT_ERRO})
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub grdListagem_ClickCell(sender As Object, e As ClickCellEventArgs) Handles grdListagem.ClickCell
    txtDescricaoHistorico.Text = FNC_NVL(e.Cell.Row.Cells(const_GridListagem_DS_HISTORICO).Value, "")
  End Sub
End Class