Public Class frmRelatorioOrcamento
  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If Trim(txtCodigoOrcamento.Text) = "" Then
      FNC_Mensagem("Informe o código de orçamento")
      Exit Sub
    End If

    Try
      Dim oForm As New frmReportViewer
      Dim oData As DataTable
      Dim oDataProcedimentos As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT OCCLI.SQ_ORCAMENTO_CLIENTE" &
                       ",PESSO.NO_PESSOA" &
                       ",CONVE.NO_CONVENIO" &
                       ",FINAN.NO_FINANCIAMENTO" &
                       ",AGEND.CD_AGENDAMENTO" &
                       ",OCCLI.CD_ORCAMENTO_CLIENTE" &
                       ",OCCLI.DH_ORCAMENTO_CLIENTE" &
                       ",OCCLI.DT_VALIDADE" &
                       ",OPCAO_STATU.NO_OPCAO" &
                 " FROM TB_ORCAMENTO_CLIENTE OCCLI" &
                  " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = OCCLI.ID_PESSOA" &
                  " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = OCCLI.ID_CONVENIO" &
                   " LEFT JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = OCCLI.ID_AGENDAMENTO" &
                   " LEFT JOIN TB_FINANCIAMENTO FINAN ON FINAN.SQ_FINANCIAMENTO = OCCLI.ID_FINANCIAMENTO" &
                  " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = OCCLI.ID_OPT_STATUS" &
                 " WHERE OCCLI.CD_ORCAMENTO_CLIENTE LIKE '%" + txtCodigoOrcamento.Text + "%'"
      oData = DBQuery(sSqlText)

      sSqlText = "SELECT OCPRC.ID_ORCAMENTO_CLIENTE" &
                       ",PROCE.CD_PROCEDIMENTO" &
                       ",PROCE.NO_PROCEDIMENTO" &
                       ",OCPRC.VL_ORCADO" &
                       ",OPCAO_STATU.NO_OPCAO" &
                       ",PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL" &
                 " FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO OCPRC" &
                  " INNER JOIN TB_ORCAMENTO_CLIENTE OCCLI ON OCCLI.SQ_ORCAMENTO_CLIENTE = OCPRC.ID_ORCAMENTO_CLIENTE" &
                  " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                  " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = OCPRC.ID_OPT_STATUS" &
                   " LEFT JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL" &
                 " WHERE OCCLI.CD_ORCAMENTO_CLIENTE LIKE '%" + txtCodigoOrcamento.Text + "%'" &
                 " ORDER BY PROCE.NO_PROCEDIMENTO"
      oDataProcedimentos = DBQuery(sSqlText)

      With oForm.rpvGeral
        .LocalReport.ReportPath = FNC_Relatorio_CarregarArquivo("Impressoes\OrcamentoExames.rdl")
        oForm.TipoRelatorio = frmReportViewer.enTipoRelatorio.ClinicaOrcamento
        oForm.Formatar()

        .LocalReport.DataSources.Clear()
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("datGeral", oData))
        .LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("datProcedimentos", oDataProcedimentos))
        .RefreshReport()
        oForm.Show()
      End With
    Catch ex As Exception
      FNC_Mensagem("frmRelatorioOrcamento - " & ex.Message)
    End Try
  End Sub
End Class