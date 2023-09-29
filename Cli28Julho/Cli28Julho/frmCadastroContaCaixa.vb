﻿Public Class frmCadastroContaCaixa
  Public Event Pesquisar()

  Public iSQ_CONTAFINANCEIRA As Integer

  Private Sub frmCadastroContaCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboDepartamento, enSql.Departamento)
    ComboBox_Carregar(cboFuncionarioSupervisorContaCaixa, enSql.Usuario_Supervisao)
    ListBox_Carregar(lstFuncionariosUtilizamConta, enSql.Funcionario)

    If iSQ_CONTAFINANCEIRA > 0 Then
      CarregarDados()
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = "SELECT * FROM TB_CONTAFINANCEIRA WHERE SQ_CONTAFINANCEIRA = " & iSQ_CONTAFINANCEIRA
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        txtNomeContaCaixa.Text = FNC_NVL(.Item("NO_CONTAFINANCEIRA"), "")
        txtLocalizacao.Text = FNC_NVL(.Item("DS_LOCALIZACAO"), "")
        ComboBox_Selecionar(cboDepartamento, .Item("ID_DEPARTAMENTO_RESPONSAVEL"))
        ComboBox_Selecionar(cboFuncionarioSupervisorContaCaixa, .Item("ID_PESSOA_SUPERVISAO"))

        chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "") = "S")
        chkControlaSaldo.Checked = (FNC_NVL(.Item("IC_CONTROLASALDO"), "") = "S")
      End With
    End If

    sSqlText = "SELECT * FROM TB_CONTAFINANCEIRA_PESSOA WHERE ID_CONTAFINANCEIRA = " & iSQ_CONTAFINANCEIRA
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      ChekListBox_Selecionar(lstFuncionariosUtilizamConta, oData.Rows(iCont).Item("ID_PESSOA"))
    Next
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Trim(txtNomeContaCaixa.Text) = "" Then
      FNC_Mensagem("Informe o nome da conta caixa")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboDepartamento) Then
      FNC_Mensagem("Selecione o departamento")
      Exit Sub
    End If

    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = DBMontar_SP("SP_CONTACAIXA_CAD", False, "@SQ_CONTAFINANCEIRA OUT",
                                                       "@ID_DEPARTAMENTO_RESPONSAVEL",
                                                       "@ID_PESSOA_SUPERVISAO",
                                                       "@NO_CONTAFINANCEIRA",
                                                       "@DS_LOCALIZACAO",
                                                       "@IC_ATIVO",
                                                       "@IC_CONTROLASALDO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CONTAFINANCEIRA", iSQ_CONTAFINANCEIRA, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_DEPARTAMENTO_RESPONSAVEL", cboDepartamento.SelectedValue),
                            DBParametro_Montar("ID_PESSOA_SUPERVISAO", FNC_NuloZero(cboFuncionarioSupervisorContaCaixa.SelectedValue, False)),
                            DBParametro_Montar("NO_CONTAFINANCEIRA", txtNomeContaCaixa.Text.Trim()),
                            DBParametro_Montar("DS_LOCALIZACAO", txtLocalizacao.Text.Trim()),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N")),
                            DBParametro_Montar("IC_CONTROLASALDO", IIf(chkControlaSaldo.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_CONTAFINANCEIRA = DBRetorno(1)
      End If

      sSqlText = DBMontar_SP("SP_CONTAFINANCEIRA_PESSOA_DEL", False, "@SQ_CONTAFINANCEIRA")
      DBExecutar(sSqlText, DBParametro_Montar("SQ_CONTAFINANCEIRA", iSQ_CONTAFINANCEIRA))

      For iCont = 0 To lstFuncionariosUtilizamConta.CheckedItems.Count - 1
        sSqlText = DBMontar_SP("SP_CONTAFINANCEIRA_PESSOA_INS", False, "@ID_CONTAFINANCEIRA",
                                                                       "@ID_PESSOA")
        DBExecutar(sSqlText, DBParametro_Montar("ID_CONTAFINANCEIRA", iSQ_CONTAFINANCEIRA),
                             DBParametro_Montar("ID_PESSOA", lstFuncionariosUtilizamConta.CheckedItems(iCont)(0)))
      Next

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub
End Class