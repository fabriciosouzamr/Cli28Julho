Public Class frmConsultaAgendamentoExecucao
  Public iSQ_AGENDAMENTO As Integer

  Private Sub frmConsultaAgendamentoExecucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim oData As DataTable
    Dim sSqlText As String

    If iSQ_AGENDAMENTO > 0 Then
      sSqlText = "SELECT CD_AGENDAMENTO, NO_PESSOA, ID_PESSOA_EXECUTOR" &
                 " FROM VW_AGENDAMENTO" &
                 " WHERE SQ_AGENDAMENTO = " & iSQ_AGENDAMENTO
      oData = DBQuery(sSqlText)

      lblCodigo.Text = oData.Rows(0).Item("CD_AGENDAMENTO")
      lblNomePaciente.Text = oData.Rows(0).Item("NO_PESSOA")
      psqExecutor.ID_Pessoa = FNC_NVL(oData.Rows(0).Item("ID_PESSOA_EXECUTOR"), 0)
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String
    Dim sHistorico As String

    sSqlText = DBMontar_SP("SP_AGENDAMENTO_PESSOA_EXECUTOR_UPD", False, "@SQ_AGENDAMENTO",
                                                                        "@ID_PESSOA_EXECUTOR")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_AGENDAMENTO", iSQ_AGENDAMENTO),
                         DBParametro_Montar("ID_PESSOA_EXECUTOR", FNC_NuloZero(psqExecutor.ID_Pessoa, False)))

    If psqExecutor.ID_Pessoa > 0 Then
      sHistorico = "Pessoa Executora:" & psqExecutor.cboPessoa.Text
    Else
      sHistorico = "Pessoa Executora: Sem Pessoa Executora"
    End If

    FNC_Historico_Incluir(enOpcoes.Processo_Historico_Clinica_Agendamento, enOpcoes.Processo_Acao_Alteracao, 0, iSQ_AGENDAMENTO, sHistorico, lblCodigo.Text)

    FNC_Mensagem("Gravação Efetuada")

    Close()
  End Sub
End Class