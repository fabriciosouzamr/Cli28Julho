Imports Infragistics.Win

Public Class uscPaciente_Historico
  Dim oDBHistoricoConsultas As New UltraWinDataSource.UltraDataSource
  Dim oDBHistoricoFinanceiro As New UltraWinDataSource.UltraDataSource
  Dim oDBHistoricoCompra As New UltraWinDataSource.UltraDataSource
  Dim iID_PACIENTE_CARREGADO As Integer

  Public Sub Inicializar()
    FormCadastroPaciente_HistoricoConsulta_FormatarGrid(grdHistoricoConsultas, oDBHistoricoConsultas)
    FormCadastroPessoa_HistoricoFinanceiro_FormatarGrid(grdHistoricoFinanceiro, oDBHistoricoFinanceiro)
    objGrid_Configuracao_Carregar(grdHistoricoConsultas, Me.Name)
    objGrid_Configuracao_Carregar(grdHistoricoFinanceiro, Me.Name)
  End Sub

  Public Sub Limpar()
    oDBHistoricoConsultas.Rows.Clear()
    oDBHistoricoFinanceiro.Rows.Clear()
    oDBHistoricoCompra.Rows.Clear()
  End Sub

  Public Sub Carregar(iID_PACIENTE As Integer)
    iID_PACIENTE_CARREGADO = iID_PACIENTE

    FormCadastroPaciente_HistoricoConsulta_CarregarGrid(grdHistoricoConsultas, iID_PACIENTE)
    FormCadastroPessoa_HistoricoFinanceiro_CarregarGrid(grdHistoricoFinanceiro, iID_PACIENTE)
  End Sub

  Private Sub cmdAtualizar_Click(sender As Object, e As EventArgs) Handles cmdAtualizar.Click
    Carregar(iID_PACIENTE_CARREGADO)
  End Sub

  Public Sub Finalizar()
    objGrid_Configuracao_Gravar(grdHistoricoConsultas, Me.Name)
    objGrid_Configuracao_Gravar(grdHistoricoFinanceiro, Me.Name)
  End Sub
End Class
