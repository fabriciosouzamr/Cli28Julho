Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid

Public Class frmCadastroProfissionalHorario
  Const const_GridListagem_ID_PROCEDIMENTO As Integer = 0

  Public iSQ_PESSOA_HORARIO As Integer = 0

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub frmCadastroProfissionalHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboFilial, enSql.EmpresaAtiva)
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboDiasSemana, enSql.DiasSemana)
    ComboBox_Carregar(cboConsultorio, enSql.Consultorio)
    ComboBox_Carregar(cboAtivo, enSql.SimNao)

    ComboBox_Selecionar(cboFilial, iID_EMPRESA_FILIAL)

    objGrid_Inicializar(grdListagem, AllowAddNew.FixedAddRowOnTop, oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.True, , , , , True)
    objGrid_Coluna_Add(grdListagem, "Procedimento", 500, , True, , FNC_CarregarLista(enTipoCadastro.TodosProcedimentos))

    txtData.Text = ""

    If iSQ_PESSOA_HORARIO > 0 Then
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT * FROM TB_PESSOA_HORARIO WHERE SQ_PESSOA_HORARIO = " & iSQ_PESSOA_HORARIO.ToString()
      oData = DBQuery(sSqlText)

      ComboBox_Selecionar(cboFilial, oData.Rows(0).Item("ID_EMPRESA"))
      ComboBox_Selecionar(cboProfissional, oData.Rows(0).Item("ID_PESSOA"))
      ComboBox_Selecionar(cboDiasSemana, oData.Rows(0).Item("ID_OPT_DIA_SEMANA"))
      ComboBox_Selecionar(cboConsultorio, oData.Rows(0).Item("ID_CONSULTORIO"))
      ComboBox_Selecionar(cboAtivo, oData.Rows(0).Item("ID_OPT_ATIVO"))
      txtHoraInicio.Text = oData.Rows(0).Item("HR_INICIO")
      txtHoraFim.Text = oData.Rows(0).Item("HR_FIM")
      txtQtdeProcedimento.Value = oData.Rows(0).Item("QT_ATENDIMENTO")
      txtQtdeRetorno.Value = oData.Rows(0).Item("QT_RETORNO")
      If Not FNC_CampoNulo(oData.Rows(0).Item("DT_ESPECIAL")) Then txtData.Value = oData.Rows(0).Item("DT_ESPECIAL")
      chkBloqueado.Checked = (FNC_NVL(oData.Rows(0).Item("IC_BLOQUEADO"), "N") = "S")

      oData.Dispose()

      Carregar()
    End If

    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_CadastrarHorariodeProfissional).bGravar
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboFilial) Then
      FNC_Mensagem("Selecione a filial")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboProfissional) Then
      FNC_Mensagem("Selecione o profissional")
      Exit Sub
    End If
    If chkBloqueado.Checked And Not IsDate(txtData.Text) Then
      FNC_Mensagem("Para informar o bloqueio é preciso informar a data")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim iCont As Integer
    Dim oParametro(11) As DBParamentro

    sSqlText = DBMontar_SP("SP_PESSOA_HORARIO_CAD", False, "@SQ_PESSOA_HORARIO OUT",
                                                           "@ID_EMPRESA",
                                                           "@ID_PESSOA",
                                                           "@ID_OPT_DIA_SEMANA",
                                                           "@ID_OPT_ATIVO",
                                                           "@ID_CONSULTORIO",
                                                           "@QT_ATENDIMENTO",
                                                           "@QT_RETORNO",
                                                           "@HR_INICIO",
                                                           "@HR_FIM",
                                                           "@DT_ESPECIAL",
                                                           "@IC_BLOQUEADO")
    oParametro(0) = DBParametro_Montar("SQ_PESSOA_HORARIO", iSQ_PESSOA_HORARIO,, ParameterDirection.InputOutput)
    oParametro(1) = DBParametro_Montar("ID_EMPRESA", cboFilial.SelectedValue)
    oParametro(2) = DBParametro_Montar("ID_PESSOA", cboProfissional.SelectedValue)
    oParametro(3) = DBParametro_Montar("ID_OPT_DIA_SEMANA", cboDiasSemana.SelectedValue)
    oParametro(4) = DBParametro_Montar("ID_OPT_ATIVO", cboAtivo.SelectedValue)
    oParametro(5) = DBParametro_Montar("ID_CONSULTORIO", cboConsultorio.SelectedValue)
    oParametro(6) = DBParametro_Montar("QT_ATENDIMENTO", txtQtdeProcedimento.Value)
    oParametro(7) = DBParametro_Montar("QT_RETORNO", txtQtdeRetorno.Value)
    oParametro(8) = DBParametro_Montar("HR_INICIO", txtHoraInicio.Text)
    oParametro(9) = DBParametro_Montar("HR_FIM", txtHoraFim.Text)
    If IsDate(txtData.Text) Then
      oParametro(10) = DBParametro_Montar("DT_ESPECIAL", txtData.Text, SqlDbType.DateTime)
    Else
      oParametro(10) = DBParametro_Montar("DT_ESPECIAL", Nothing, SqlDbType.DateTime)
    End If
    oParametro(11) = DBParametro_Montar("IC_BLOQUEADO", IIf(chkBloqueado.Checked, "S", "N"))

    DBExecutar(sSqlText, oParametro)

    If DBTeveRetorno() Then
      iSQ_PESSOA_HORARIO = DBRetorno(1)
    End If

    sSqlText = "DELETE FROM TB_PESSOA_HORARIO_PROCEDIMENTO WHERE ID_PESSOA_HORARIO = " & iSQ_PESSOA_HORARIO
    DBExecutar(sSqlText)

    For iCont = 0 To grdListagem.Rows.Count - 1
      With grdListagem.Rows(iCont)
        sSqlText = DBMontar_SP("SP_PESSOA_HORARIO_PROCEDIMENTO_CAD", False, "@ID_PESSOA_HORARIO",
                                                                            "@ID_PROCEDIMENTO")
        DBExecutar(sSqlText, DBParametro_Montar("ID_PESSOA_HORARIO", iSQ_PESSOA_HORARIO),
                             DBParametro_Montar("ID_PROCEDIMENTO", FNC_NVL(.Cells(const_GridListagem_ID_PROCEDIMENTO).Value, 0)))
      End With
    Next

    FNC_Mensagem("Gravação Efetuada")
  End Sub

  Private Sub psqProcedimento_ItemSelecionado(sender As Object, e As EventArgs) 
    Carregar()
  End Sub

  Private Sub Carregar()
    Dim sSqlText As String

    sSqlText = "SELECT ID_PROCEDIMENTO FROM TB_PESSOA_HORARIO_PROCEDIMENTO WHERE ID_PESSOA_HORARIO = " & iSQ_PESSOA_HORARIO
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_ID_PROCEDIMENTO})
  End Sub

  Private Sub cmdCopiarHorarioExames_Click(sender As Object, e As EventArgs) Handles cmdCopiarHorarioExames.Click
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PESSOA_HORARIO_COPIAR", False, "@ID_PESSOA_HORARIO")
    If DBExecutar(sSqlText, DBParametro_Montar("@ID_PESSOA_HORARIO", iSQ_PESSOA_HORARIO)) Then
      FNC_Mensagem("Copia realizada")
    End If
  End Sub

  Private Sub txtData_ValueChanged(sender As Object, e As EventArgs) Handles txtData.ValueChanged
    If IsDate(txtData.Text) Then
      ComboBox_Selecionar(cboDiasSemana, txtData.DateTime.DayOfWeek + 1, enComboBox_DiasSemana.CD_DIASEMANA)
    End If
  End Sub

  Private Sub cboFilial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilial.SelectedIndexChanged
    If ComboBox_Selecionado(cboFilial) Then
      ComboBox_Carregar(cboConsultorio, enSql.Consultorio, New Object() {FNC_NVL(cboFilial.SelectedValue, 0)})
    Else
      ComboBox_Carregar(cboConsultorio, enSql.Consultorio)
    End If
  End Sub
End Class