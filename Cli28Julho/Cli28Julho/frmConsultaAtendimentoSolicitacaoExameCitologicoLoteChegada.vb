Public Class frmConsultaAtendimentoSolicitacaoExameCitologicoLoteChegada
  Public iSQ_CLINICA_EXAME_CITOLOGICO_LOTE As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String

    If Not IsDate(txtDataChegada.Text) Then
      FNC_Mensagem("Informa e data de chegada")
      Exit Sub
    End If

    sSqlText = DBMontar_SP("SP_CLINICA_EXAME_CITOLOGICO_LOTE_CHEGADA", False, "@ID_CLINICA_EXAME_CITOLOGICO_LOTE",
                                                                              "@DT_CHEGADA")
    DBExecutar(sSqlText, DBParametro_Montar("ID_CLINICA_EXAME_CITOLOGICO_LOTE", iSQ_CLINICA_EXAME_CITOLOGICO_LOTE),
                         DBParametro_Montar("DT_CHEGADA", txtDataChegada.DateTime.Date, SqlDbType.Date))

    FNC_Mensagem("Gravação Efetuada")
  End Sub

  Private Sub frmConsultaAtendimentoSolicitacaoExameCitologicoLoteChegada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim oData As DataTable
    Dim sSqlText As String

    txtDataChegada.Value = Nothing

    sSqlText = "SELECT PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL, CLEXL.DT_ENVIO, CLEXL.DT_CHEGADA" &
               " FROM TB_CLINICA_EXAME_CITOLOGICO_LOTE CLEXL" &
                " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLEXL.ID_PESSOA_PROFISSIONAL" &
               " WHERE CLEXL.SQ_CLINICA_EXAME_CITOLOGICO_LOTE = " & iSQ_CLINICA_EXAME_CITOLOGICO_LOTE
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      lblProfissional.Text = oData.Rows(0).Item("NO_PESSOA_PROFISSIONAL")
      lblDataEnvio.Text = oData.Rows(0).Item("DT_ENVIO")
      If Not FNC_CampoNulo(oData.Rows(0).Item("DT_CHEGADA")) Then txtDataChegada.Value = oData.Rows(0).Item("DT_CHEGADA")
    End If
  End Sub
End Class