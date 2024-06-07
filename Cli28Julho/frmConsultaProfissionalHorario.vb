Imports Infragistics.Win

Public Class frmConsultaProfissionalHorario
  Const const_GridListagem_SQ_PESSOA_HORARIO As Integer = 0
  Const const_GridListagem_ID_PESSOA As Integer = 1
  Const const_GridListagem_ID_OPT_ATIVO As Integer = 2
  Const const_GridListagem_NO_EMPRESA As Integer = 3
  Const const_GridListagem_CD_CPF_CNPJ As Integer = 4
  Const const_GridListagem_NO_PESSOA As Integer = 5
  Const const_GridListagem_NO_OPT_DIA_SEMANA As Integer = 6
  Const const_GridListagem_HR_INICIO As Integer = 7
  Const const_GridListagem_HR_FIM As Integer = 8
  Const const_GridListagem_HR_INTERVALO As Integer = 9
  Const const_GridListagem_QT_PROCEDIMENTOS As Integer = 10
  Const const_GridListagem_QT_RETORNO As Integer = 11
  Const const_GridListagem_NO_CONSULTORIO As Integer = 12
  Const const_GridListagem_DT_ESPECIAL As Integer = 13
  Const const_GridListagem_IC_BLOQUEADO As Integer = 14
  Const const_GridListagem_NO_OPT_ATIVO As Integer = 15

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaProfissionalHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboDiasSemana, enSql.DiasSemana)
    ComboBox_Carregar(cboEmpresa, enSql.Empresa)
    ComboBox_Carregar(cboAtivo, enSql.SimNao)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_PESSOA_HORARIO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_ATIVO", 0)
    objGrid_Coluna_Add(grdListagem, "Empresa", 150)
    objGrid_Coluna_Add(grdListagem, "C.P.F./C.P.N.J.", 150)
    objGrid_Coluna_Add(grdListagem, "Profissional", 300)
    objGrid_Coluna_Add(grdListagem, "Dia da Semana", 100)
    objGrid_Coluna_Add(grdListagem, "Hora Início", 100)
    objGrid_Coluna_Add(grdListagem, "Hora Fim", 100)
    objGrid_Coluna_Add(grdListagem, "Invervalo", 100)
    objGrid_Coluna_Add(grdListagem, "Qtde. Atendimento", 100)
    objGrid_Coluna_Add(grdListagem, "Qtde. Retorno", 100)
    objGrid_Coluna_Add(grdListagem, "Consultório", 100)
    objGrid_Coluna_Add(grdListagem, "Data Especial", 100)
    objGrid_Coluna_Add(grdListagem, "Bloqueado", 100)
    objGrid_Coluna_Add(grdListagem, "Ativo", 100)

    cmdNovo.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_CadastrarHorariodeProfissional).bIncluir
    cmdAlterar.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_CadastrarHorariodeProfissional).bAlterar
  End Sub

  Private Sub frmConsultaProfissionalHorario_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdExcel.Top = cmdNovo.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdNovo.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""

    sSqlText = "SELECT SQ_PESSOA_HORARIO," &
                      "ID_PESSOA," &
                      "ID_OPT_ATIVO," &
                      "NO_EMPRESA," &
                      "CD_CPF_CNPJ," &
                      "NO_PESSOA," &
                      "NO_OPT_DIA_SEMANA," &
                      "HR_INICIO," &
                      "HR_FIM," &
                      "NR_INTERVALO," &
                      "QT_ATENDIMENTO," &
                      "QT_RETORNO," &
                      "NO_CONSULTORIO," &
                      "DT_ESPECIAL," &
                      "IIF(IC_BLOQUEADO = 'N', 'Não', 'Sim')" &
                      "NO_OPT_ATIVO" &
               " FROM VW_PESSOA_HORARIO"

    If ComboBox_Selecionado(cboProfissional) Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_PESSOA = " & cboProfissional.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboEmpresa) Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_EMPRESA = " & cboEmpresa.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboDiasSemana) Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_DIA_SEMANA = " & cboDiasSemana.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboAtivo) Then
      FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_ATIVO = " & cboAtivo.SelectedValue, " AND ")
    End If
    If chkBloqueado.Checked Then
      FNC_Str_Adicionar(sSqlText_Where, "IC_BLOQUEADO = 'S'", " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText + " WHERE " + sSqlText_Where
    End If

    sSqlText = sSqlText &
               " ORDER BY NO_PESSOA, CD_OPT_DIA_SEMANA"

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_PESSOA_HORARIO,
                                                           const_GridListagem_ID_PESSOA,
                                                           const_GridListagem_ID_OPT_ATIVO,
                                                           const_GridListagem_NO_EMPRESA,
                                                           const_GridListagem_CD_CPF_CNPJ,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_NO_OPT_DIA_SEMANA,
                                                           const_GridListagem_HR_INICIO,
                                                           const_GridListagem_HR_FIM,
                                                           const_GridListagem_HR_INTERVALO,
                                                           const_GridListagem_QT_PROCEDIMENTOS,
                                                           const_GridListagem_QT_RETORNO,
                                                           const_GridListagem_NO_CONSULTORIO,
                                                           const_GridListagem_DT_ESPECIAL,
                                                           const_GridListagem_IC_BLOQUEADO,
                                                           const_GridListagem_NO_OPT_ATIVO})
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(New frmCadastroProfissionalHorario)
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o horário a ser alterado")
      Exit Sub
    End If

    Dim oForm As New frmCadastroProfissionalHorario

    oForm.iSQ_PESSOA_HORARIO = objGrid_Valor(grdListagem, const_GridListagem_SQ_PESSOA_HORARIO)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboAtivo.SelectedIndex = -1
    cboDiasSemana.SelectedIndex = -1
    cboProfissional.SelectedIndex = -1
    cboEmpresa.SelectedIndex = -1
    psqProcedimento.Limpar()
  End Sub

  Private Sub cmdCalendario_Click(sender As Object, e As EventArgs) Handles cmdCalendario.Click
    FNC_AbriTela(New frmConsultaProfissionalHorarioMatrix)
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o horário a ser excluído")
      Exit Sub
    End If

    If Not FNC_Perguntar("Deseja realmente excluir esse horário?") Then Exit Sub

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_HORARIO_DEL", False, "@SQ_PESSOA_HORARIO")

    If DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_HORARIO", objGrid_Valor(grdListagem, const_GridListagem_SQ_PESSOA_HORARIO))) Then
      Pesquisar()

      FNC_Mensagem("Exclusão Efetuada")
    End If
  End Sub

  Private Sub cmdBloquearTodos_Click(sender As Object, e As EventArgs) Handles cmdBloquearTodos.Click
    Bloqueio(True)

    FNC_Mensagem("Bloquieo realizado")
  End Sub

  Private Sub cmdDesbloquearTodos_Click(sender As Object, e As EventArgs) Handles cmdDesbloquearTodos.Click
    Bloqueio(False)

    FNC_Mensagem("Desbloquieo realizado")
  End Sub

  Private Sub Bloqueio(bBloqueio As Boolean)
    Dim iCont As Integer
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_HORARIO_BLOQUEIO_UPD", False, "@SQ_PESSOA_HORARIO", "@IC_BLOQUEADO")

    For iCont = 0 To grdListagem.Rows.Count - 1
      If grdListagem.Rows(iCont).VisibleIndex <> -1 Then
        DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_HORARIO", objGrid_Valor(grdListagem, const_GridListagem_SQ_PESSOA_HORARIO, iCont)),
                             DBParametro_Montar("IC_BLOQUEADO", IIf(bBloqueio, "S", "N")))
      End If
    Next
  End Sub
End Class