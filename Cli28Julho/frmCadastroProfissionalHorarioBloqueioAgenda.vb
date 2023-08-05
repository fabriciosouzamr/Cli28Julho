Imports Infragistics.Win

Public Class frmCadastroProfissionalHorarioBloqueioAgenda
  Const const_GridListagem_ID_PESSOA As Integer = 0
  Const const_GridListagem_Chk As Integer = 1
  Const const_GridListagem_NO_PESSOA As Integer = 2

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Dim iSQ_PESSOA_HORARIO_BLOQUEIO As Integer

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroProfissionalHorarioBloqueioAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA", 0)
    objGrid_Coluna_Add(grdListagem, "...", 30,, True, UltraWinGrid.ColumnStyle.CheckBox,,,,,,,,,,,,,,,, True)
    objGrid_Coluna_Add(grdListagem, "Profissional", 300)

    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing

    ComboBox_Carregar(cboEspecialidade, enSql.Especialidade)
  End Sub

  Private Sub cboEspecialidade_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEspecialidade.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboEspecialidade.SelectedIndex = -1
    End If
  End Sub

  Private Sub CarregarDados()
    Dim sSqlText As String

    sSqlText = "SELECT DISTINCT PESSO.SQ_PESSOA," &
                               "0," &
                               "PESSO.NO_PESSOA" &
               " FROM TB_PESSOA_ESPECIALIDADE	PSESP" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PSESP.ID_PESSOA" &
                                          " AND PESSO.ID_OPT_ATIVO = " & enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode() &
                " INNER JOIN TB_PESSOA_EMPRESA PE ON PE.ID_PESSOA = PESSO.SQ_PESSOA" &
                                               " AND PE.ID_EMPRESA = " & iID_EMPRESA_MATRIZ &
                                               " AND ISNULL(PE.IC_PROFISSIONAL_SERVICO_INTERNO, 'N') = 'S'"

    If ComboBox_Selecionado(cboEspecialidade) Then
      sSqlText = sSqlText &
                " WHERE PSESP.ID_ESPECIALIDADE = " & cboEspecialidade.SelectedValue
    End If

    sSqlText = sSqlText &
               " ORDER BY PESSO.NO_PESSOA"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_PESSOA,
                                                           const_GridListagem_Chk,
                                                           const_GridListagem_NO_PESSOA})
  End Sub

  Private Sub cboEspecialidade_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEspecialidade.SelectedValueChanged
    CarregarDados()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not IsDate(txtDataInicial.Value) Then
      FNC_Mensagem("Informe a data inicial")
      Exit Sub
    End If
    If Not IsDate(txtDataFinal.Value) Then
      FNC_Mensagem("Informe a data final")
      Exit Sub
    End If

    Dim bAchou As Boolean
    Dim iCont As Integer

    For iCont = 0 To grdListagem.Rows.Count - 1
      If objGrid_CheckBox_Selecionado(grdListagem, const_GridListagem_Chk, iCont) Then
        bAchou = True
      End If
    Next

    If Not bAchou Then
      FNC_Mensagem("Selecione algum profissional")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_HORARIO_BLOQUEIO_CAD", False, "@SQ_PESSOA_HORARIO_BLOQUEIO OUT",
                                                                    "@ID_EMPRESA",
                                                                    "@ID_PESSOA",
                                                                    "@DT_BLOQUEIO_INCIO",
                                                                    "@DT_BLOQUEIO_FIM",
                                                                    "@ID_USUARIO")
    For iCont = 0 To grdListagem.Rows.Count - 1
      If objGrid_CheckBox_Selecionado(grdListagem, const_GridListagem_Chk, iCont) Then
        DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_HORARIO_BLOQUEIO", iSQ_PESSOA_HORARIO_BLOQUEIO, , ParameterDirection.InputOutput),
                             DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                             DBParametro_Montar("ID_PESSOA", objGrid_Valor(grdListagem, const_GridListagem_ID_PESSOA, iCont)),
                             DBParametro_Montar("DT_BLOQUEIO_INCIO", txtDataInicial.Value, SqlDbType.DateTime),
                             DBParametro_Montar("DT_BLOQUEIO_FIM", txtDataFinal.Value, SqlDbType.DateTime),
                             DBParametro_Montar("ID_USUARIO", iID_USUARIO))

        If DBTeveRetorno() Then
          iSQ_PESSOA_HORARIO_BLOQUEIO = DBRetorno(1)
        End If
      End If
    Next

    FNC_Mensagem("Gravação Efetuada")
  End Sub
End Class