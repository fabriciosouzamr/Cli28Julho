Imports Infragistics.Win

Public Class frmMensagemModelo
  Const const_GridProfssional_ID_PESSOA_PROFISSIONAL As Integer = 0
  Const const_GridProfssional_NomeProfissional As Integer = 1
  Const const_GridProfssional_ImgemMensagem As Integer = 2

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    oConfirmacaoAgendaInclusao.Gravar()
    oConfirmacaoAgenda3dias.Gravar()
    oConfirmacaoAgenda1dias.Gravar()
    oConfirmacaoAgendaNoDias.Gravar()
    oMensagemAgradecimento.Gravar()
    oMensagemAgradecimentoExame.Gravar()
    oAniversarianteDia.Gravar()
    oCancelamentoAgendamento.Gravar()

    Dim iCont As Integer

    For iCont = 0 To grdProfssional.Rows.Count - 1
      With grdProfssional.Rows(iCont)
        sSqlText = DBMontar_SP("SP_PROFISSIONAL_CONFIG_MENSAGEM", False, "@ID_PESSOA_PROFISSIONAL",
                                                                         "@ID_EMPRESA",
                                                                         "@DS_PATH_IMAGEM_MENSAGEM")
        DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA_PROFISSIONAL", objGrid_Valor(grdProfssional, const_GridProfssional_ID_PESSOA_PROFISSIONAL, iCont)),
                             DBParametro_Montar("ID_EMPRESA", 2),
                             DBParametro_Montar("DS_PATH_IMAGEM_MENSAGEM", objGrid_Valor(grdProfssional, const_GridProfssional_ImgemMensagem, iCont), ,, 8000))
      End With
    Next

    FNC_Mensagem("Configuração efetuada")
  End Sub

  Private Sub frmMensagemModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    oConfirmacaoAgendaInclusao.Carregar("CONFIRMINC", tbsConfirmacaoAgenda.Text)
    oConfirmacaoAgenda3dias.Carregar("CONFIRM3D", tbsConfirmacaoAgenda.Text)
    oConfirmacaoAgenda1dias.Carregar("CONFIRM1D", tbsConfirmacaoAgenda.Text)
    oConfirmacaoAgendaNoDias.Carregar("CONFIRMND", tbsConfirmacaoAgenda.Text)
    oMensagemAgradecimento.Carregar("AGRADECA", tbsMensagemAgradecimento.Text)
    oMensagemAgradecimentoExame.Carregar("AGRADECEXM", tbsMensagemAgradecimento.Text)
    oAniversarianteDia.Carregar("NIVER", tbsAniversarianteDia.Text)
    oCancelamentoAgendamento.Carregar("CANCAGENDA", tbsAniversarianteDia.Text)

    objGrid_Inicializar(grdProfssional, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdProfssional, "ID_PESSOA_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdProfssional, "Nome do Profissional", 300)
    objGrid_Coluna_Add(grdProfssional, "Imgem para Mensagem", 300,, True)

    Dim sSqlText As String

    sSqlText = "SELECT PESSO.SQ_PESSOA, PESSO.NO_PESSOA, PSCFG.DS_PATH_IMAGEM_MENSAGEM" &
               " FROM TB_PESSOA_EMPRESA PSEMP" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PSEMP.ID_PESSOA" &
                 " LEFT JOIN TB_PESSOA_CONFIGURACAO PSCFG ON PSCFG.ID_PESSOA = PESSO.SQ_PESSOA" &
                                                       " And PSCFG.ID_EMPRESA = 2" &
               " WHERE PSEMP.IC_PROFISSIONAL_ATIVO = 'S'" &
                 " AND PSEMP.IC_PROFISSIONAL = 'S'" &
                 " AND PSEMP.IC_PROFISSIONAL_SERVICO_INTERNO = 'S'" &
              " ORDER BY PESSO.NO_PESSOA"
    objGrid_Carregar(grdProfssional, sSqlText, New Integer() {const_GridProfssional_ID_PESSOA_PROFISSIONAL,
                                                              const_GridProfssional_NomeProfissional,
                                                              const_GridProfssional_ImgemMensagem})

    Me.Width = 1250
    Me.Height = 615
  End Sub
End Class