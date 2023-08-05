Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmSEGPermissao
  Const const_GridListagem_SQ_PERMISSAO As Integer = 0
  Const const_GridListagem_NO_PERMISSAO As Integer = 1
  Const const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR As Integer = 2
  Const const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_ALTERAR As Integer = 3
  Const const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_EXCLUIR As Integer = 4
  Const const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_CONSULTAR As Integer = 5
  Const const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_PERMISSAO As Integer = 6

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub CarregarComboBox()
    If optComboBox_GrupoPermissao.Checked Then
      ComboBox_Carregar(cboGrupoPermissaoUsuario, enSql.GrupoPermissao)
    ElseIf optComboBox_Usuario.Checked Then
      ComboBox_Carregar(cboGrupoPermissaoUsuario, enSql.Usuario_Permissao)
    End If
  End Sub

  Private Sub optComboBox_GrupoPermissao_CheckedChanged(sender As Object, e As EventArgs) Handles optComboBox_GrupoPermissao.CheckedChanged
    CarregarComboBox()
  End Sub

  Private Sub optComboBox_Usuario_CheckedChanged(sender As Object, e As EventArgs) Handles optComboBox_Usuario.CheckedChanged
    CarregarComboBox()
  End Sub

  Private Sub frmSEGPermissao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    optComboBox_GrupoPermissao.Checked = True

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_PERMISSAO", 0, , , , , const_Formato_NumeroInteiro)
    objGrid_Coluna_Add(grdListagem, "Nome de Permissão", 400, , False)
    objGrid_Coluna_Add(grdListagem, "Inlcuir", 70, , True)
    objGrid_Coluna_Add(grdListagem, "Alterar", 70, , True)
    objGrid_Coluna_Add(grdListagem, "Excluir", 70, , True)
    objGrid_Coluna_Add(grdListagem, "Consultar", 70, , True)
    objGrid_Coluna_Add(grdListagem, "Permissão", 75, , True)

    Grid_Carregar()

    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Segurança_Perimssoes).bGravar
  End Sub

  Private Sub CarregarAcessos()
    Dim oData As DataTable
    Dim sSqlText As String = ""
    Dim iCont As Integer
    Dim iLinha As Integer
    Dim iColuna As Integer

    If ComboBox_Selecionado(cboGrupoPermissaoUsuario) Then
      If optComboBox_GrupoPermissao.Checked Then
        sSqlText = "SELECT ID_PERMISSAO_TIPOPERMISSAO FROM TB_SEG_GRUPOPERMISSAO_ACESSO" & _
                   " WHERE ID_GRUPOPERMISSAO = " & cboGrupoPermissaoUsuario.SelectedValue
      ElseIf optComboBox_Usuario.Checked Then
        sSqlText = "SELECT ID_PERMISSAO_TIPOPERMISSAO FROM TB_SEG_USUARIO_ACESSO" &
                   " WHERE ID_USUARIO = " & cboGrupoPermissaoUsuario.SelectedValue &
                     " AND ID_EMPRESA = " & iID_EMPRESA_MATRIZ
      End If

      oData = DBQuery(sSqlText)

      For iCont = 0 To oData.Rows.Count - 1
        For iLinha = 0 To grdListagem.Rows.Count - 1
          For iColuna = const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR To grdListagem.DisplayLayout.Bands(0).Columns.Count - 1
            If oData.Rows(iCont).Item("ID_PERMISSAO_TIPOPERMISSAO") = grdListagem.Rows(iLinha).Cells(iColuna).Tag Then
              grdListagem.Rows(iLinha).Cells(iColuna).Value = True
              Exit For
            End If
          Next
        Next
      Next
    End If
  End Sub

  Private Sub Grid_Limpar()
    For iLinha = 0 To grdListagem.Rows.Count - 1
      For iColuna = const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR To grdListagem.DisplayLayout.Bands(0).Columns.Count - 1
        grdListagem.Rows(iLinha).Cells(iColuna).Value = False
      Next
    Next
  End Sub

  Private Sub Grid_Carregar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer
    Dim sCD_GRUPO_MENU As String = ""

    sSqlText = "SELECT PERM.SQ_PERMISSAO," &
                      "PERM.CD_GRUPO_MENU," &
                      "PERM.NO_PERMISSAO," &
                      "PERM.IC_PERMISSAOTELA," &
                      "TPI.SQ_PERMISSAO_TIPOPERMISSAO SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR," &
                      "TPA.SQ_PERMISSAO_TIPOPERMISSAO SQ_PERMISSAO_TIPOPERMISSAO_ALTERAR," &
                      "TPE.SQ_PERMISSAO_TIPOPERMISSAO SQ_PERMISSAO_TIPOPERMISSAO_EXCLUIR," &
                      "TPC.SQ_PERMISSAO_TIPOPERMISSAO SQ_PERMISSAO_TIPOPERMISSAO_CONSULTAR," &
                      "TPP.SQ_PERMISSAO_TIPOPERMISSAO SQ_PERMISSAO_TIPOPERMISSAO_PERMISSAO" &
               " FROM TB_SEG_PERMISSAO PERM" &
                " LEFT JOIN (SELECT * FROM TB_SEG_PERMISSAO_TIPOPERMISSAO WHERE ID_TIPOPERMISSAO = 1) TPI ON TPI.ID_PERMISSAO = PERM.SQ_PERMISSAO" &
                " LEFT JOIN (SELECT * FROM TB_SEG_PERMISSAO_TIPOPERMISSAO WHERE ID_TIPOPERMISSAO = 2) TPA ON TPA.ID_PERMISSAO = PERM.SQ_PERMISSAO" &
                " LEFT JOIN (SELECT * FROM TB_SEG_PERMISSAO_TIPOPERMISSAO WHERE ID_TIPOPERMISSAO = 3) TPE ON TPE.ID_PERMISSAO = PERM.SQ_PERMISSAO" &
                " LEFT JOIN (SELECT * FROM TB_SEG_PERMISSAO_TIPOPERMISSAO WHERE ID_TIPOPERMISSAO = 4) TPC ON TPC.ID_PERMISSAO = PERM.SQ_PERMISSAO" &
                " LEFT JOIN (SELECT * FROM TB_SEG_PERMISSAO_TIPOPERMISSAO WHERE ID_TIPOPERMISSAO = 5) TPP ON TPP.ID_PERMISSAO = PERM.SQ_PERMISSAO" &
                " WHERE PERM.IC_SOMENTE_PARA_ADMIN = 'N'" &
               " ORDER BY PERM.IC_PERMISSAOTELA DESC," &
                         "PERM.CD_GRUPO_MENU," &
                         "PERM.NO_PERMISSAO"
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      If Trim(sCD_GRUPO_MENU) <> FNC_NVL(oData.Rows(iCont).Item("CD_GRUPO_MENU"), "") Then
        sCD_GRUPO_MENU = FNC_NVL(oData.Rows(iCont).Item("CD_GRUPO_MENU"), "")

        With oDBGrid.Rows.Add()
          Select Case sCD_GRUPO_MENU
            Case "AGEN"
              .Item(const_GridListagem_NO_PERMISSAO) = "Agendamento"
            Case "CADA"
              .Item(const_GridListagem_NO_PERMISSAO) = "Cadastro"
            Case "CLIN"
              .Item(const_GridListagem_NO_PERMISSAO) = "Clínica"
            Case "CPVD"
              .Item(const_GridListagem_NO_PERMISSAO) = "Compras e Vendas"
            Case "FINA"
              .Item(const_GridListagem_NO_PERMISSAO) = "Financeiro"
            Case "MEDI"
              .Item(const_GridListagem_NO_PERMISSAO) = "Médico"
            Case "RELA"
              .Item(const_GridListagem_NO_PERMISSAO) = "Relatório"
            Case "PERM"
              .Item(const_GridListagem_NO_PERMISSAO) = "Permissões"
            Case "UTIL"
              .Item(const_GridListagem_NO_PERMISSAO) = "Utiliário"
            Case "VEND"
              .Item(const_GridListagem_NO_PERMISSAO) = "Vendas"
          End Select

          grdListagem.Rows(.Index).Appearance.BackColor = Color.Cyan
          grdListagem.Rows(.Index).Cells(const_GridListagem_NO_PERMISSAO).Appearance.FontData.Bold = DefaultableBoolean.True
          grdListagem.Rows(.Index).Cells(const_GridListagem_NO_PERMISSAO).Appearance.ForeColor = Color.Black

        End With
      End If

      With oDBGrid.Rows.Add()
        .Item(const_GridListagem_SQ_PERMISSAO) = oData.Rows(iCont).Item("SQ_PERMISSAO")
        .Item(const_GridListagem_NO_PERMISSAO) = oData.Rows(iCont).Item("NO_PERMISSAO")

        If objDataTable_CampoVazio(oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR")) Then
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR).Hidden = True
        Else
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR).Style = ColumnStyle.CheckBox
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR).Tag = oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR")
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR).Value = False
        End If
        If objDataTable_CampoVazio(oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_ALTERAR")) Then
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_ALTERAR).Hidden = True
        Else
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_ALTERAR).Style = ColumnStyle.CheckBox
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_ALTERAR).Tag = oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_ALTERAR")
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_ALTERAR).Value = False
        End If
        If objDataTable_CampoVazio(oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_EXCLUIR")) Then
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_EXCLUIR).Hidden = True
        Else
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_EXCLUIR).Style = ColumnStyle.CheckBox
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_EXCLUIR).Tag = oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_EXCLUIR")
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_EXCLUIR).Value = False
        End If
        If objDataTable_CampoVazio(oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_CONSULTAR")) Then
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_CONSULTAR).Hidden = True
        Else
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_CONSULTAR).Style = ColumnStyle.CheckBox
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_CONSULTAR).Tag = oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_CONSULTAR")
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_CONSULTAR).Value = False
        End If
        If objDataTable_CampoVazio(oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_PERMISSAO")) Then
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_PERMISSAO).Hidden = True
        Else
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_PERMISSAO).Style = ColumnStyle.CheckBox
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_PERMISSAO).Tag = oData.Rows(iCont).Item("SQ_PERMISSAO_TIPOPERMISSAO_PERMISSAO")
          grdListagem.Rows(.Index).Cells(const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_PERMISSAO).Value = False
        End If
      End With
    Next

    oData.Dispose()
    oData = Nothing
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String
    Dim iLinha As Integer
    Dim iColuna As Integer

    If optComboBox_GrupoPermissao.Checked Then
      If Not ComboBox_Selecionado(cboGrupoPermissaoUsuario) Then
        FNC_Mensagem("Selecione o grupo de permissão")
        Exit Sub
      End If
    ElseIf optComboBox_Usuario.Checked Then
      If Not ComboBox_Selecionado(cboGrupoPermissaoUsuario) Then
        FNC_Mensagem("Selecione o usuário")
        Exit Sub
      End If
    Else
      FNC_Mensagem("É preciso selecionar o grupo de permissão ou o usuário")
      Exit Sub
    End If

    For iLinha = 0 To grdListagem.Rows.Count - 1
      For iColuna = const_GridListagem_SQ_PERMISSAO_TIPOPERMISSAO_INCLUIR To grdListagem.DisplayLayout.Bands(0).Columns.Count - 1
        If objGrid_CheckBox_Selecionado(grdListagem, iColuna, iLinha) Then
          If optComboBox_GrupoPermissao.Checked Then
            sSqlText = DBMontar_SP("SP_SEG_GRUPOPERMISSAO_ACESSO", False, "@ID_GRUPOPERMISSAO",
                                                                    "@ID_PERMISSAO_TIPOPERMISSAO")
            DBExecutar(sSqlText, DBParametro_Montar("ID_GRUPOPERMISSAO", cboGrupoPermissaoUsuario.SelectedValue),
                                 DBParametro_Montar("ID_PERMISSAO_TIPOPERMISSAO", grdListagem.Rows(iLinha).Cells(iColuna).Tag))
          ElseIf optComboBox_Usuario.Checked Then
            sSqlText = DBMontar_SP("SP_SEG_USUARIO_ACESSO", False, "@ID_USUARIO",
                                                             "@ID_EMPRESA",
                                                             "@ID_PERMISSAO_TIPOPERMISSAO")
            DBExecutar(sSqlText, DBParametro_Montar("ID_USUARIO", cboGrupoPermissaoUsuario.SelectedValue),
                                 DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ),
                                 DBParametro_Montar("ID_PERMISSAO_TIPOPERMISSAO", grdListagem.Rows(iLinha).Cells(iColuna).Tag))
          End If
        Else
          If FNC_NVL(grdListagem.Rows(iLinha).Cells(iColuna).Tag, 0) > 0 Then
            If optComboBox_GrupoPermissao.Checked Then
              sSqlText = "DELETE FROM TB_SEG_GRUPOPERMISSAO_ACESSO" &
                       " WHERE ID_GRUPOPERMISSAO = " & cboGrupoPermissaoUsuario.SelectedValue &
                         " AND ID_PERMISSAO_TIPOPERMISSAO = " & grdListagem.Rows(iLinha).Cells(iColuna).Tag
              DBExecutar(sSqlText)
            ElseIf optComboBox_Usuario.Checked Then
              sSqlText = "DELETE FROM TB_SEG_USUARIO_ACESSO" &
                       " WHERE ID_USUARIO = " & cboGrupoPermissaoUsuario.SelectedValue &
                         " AND ID_EMPRESA = " & iID_EMPRESA_MATRIZ &
                         " AND ID_PERMISSAO_TIPOPERMISSAO = " & grdListagem.Rows(iLinha).Cells(iColuna).Tag
              DBExecutar(sSqlText)
            End If
          End If
        End If
      Next
    Next

    FNC_Mensagem("Gravação Efetuada")
  End Sub

  Private Sub cboGrupoPermissaoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrupoPermissaoUsuario.SelectedIndexChanged
    Grid_Limpar()

    If ComboBox_Selecionado(cboGrupoPermissaoUsuario) Then
      CarregarAcessos()
    End If
  End Sub
End Class