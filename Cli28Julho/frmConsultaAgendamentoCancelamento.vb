Public Class frmConsultaAgendamentoCancelamento
  Public iSQ_AGENDAMENTO As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaAgendamentoCancelamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim sSqlText As String
    Dim oData As DataTable

    sSqlText = "SELECT AGEND.ID_OPT_STATUS," &
                      "AGEND.CD_AGENDAMENTO," &
                      "PESSO.NO_PESSOA" &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" &
                " WHERE AGEND.SQ_AGENDAMENTO = " & iSQ_AGENDAMENTO.ToString()
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      lblCodigo.Text = oData.Rows(0).Item("CD_AGENDAMENTO")
      lblNomePaciente.Text = oData.Rows(0).Item("NO_PESSOA")

      If FNC_In(oData.Rows(0).Item("ID_OPT_STATUS"), enOpcoes.StatusAgendamento_CanceladoClinica,
                                                      enOpcoes.StatusAgendamento_CanceladoPaciente,
                                                      enOpcoes.StatusAgendamento_Sistema_CanceladoFalta) Then
        FNC_Mensagem("Agendamento já cancelado")
        cmdGravar.Enabled = False
      End If
    End If

    oData.Dispose()
    oData = Nothing

    ComboBox_Carregar(cboStatus, enSql.StatusAgendamento_Cancelamento)
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboStatus) Then
      FNC_Mensagem("Selecione o status do cancelamento")
      Exit Sub
    End If
    If Trim(txtComentario.Text) = "" Then
      FNC_Mensagem("Informe o comentário")
      Exit Sub
    End If

    FormCadastroAgendamento_AlterarStatus(iSQ_AGENDAMENTO, cboStatus.SelectedValue)

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_VOUCHER_AGENDAMENDO_DEL", False, "@ID_AGENDAMENTO", "@ID_USUARIO")
    DBExecutar(sSqlText, DBParametro_Montar("ID_AGENDAMENTO", iSQ_AGENDAMENTO),
                         DBParametro_Montar("ID_USUARIO", iID_USUARIO))

    FNC_Historico_Incluir(enOpcoes.Processo_Historico_Clinica_Agendamento, enOpcoes.Processo_Acao_Exclusao, 0, iSQ_AGENDAMENTO, txtComentario.Text, lblCodigo.Text)

    Close()
  End Sub
End Class