Public Class frmCadastroConvenio
  Public iSQ_CONVENIO As Integer

  Public Event Pesquisar()

  Private Sub CmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub FrmCadastroConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim oData As DataTable
    Dim sSqlText As String

    ComboBox_Carregar(cboTipoConvenio, enSql.TipoConvenio)
    psqAdministradora.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Juridica_E_Empresa

    If iSQ_CONVENIO > 0 Then
      sSqlText = "SELECT * FROM TB_CONVENIO WHERE SQ_CONVENIO = " & iSQ_CONVENIO.ToString()
      oData = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData) Then
        With oData.Rows(0)
          txtNomeConvenio.Text = .Item("NO_CONVENIO")
          psqAdministradora.ID_Pessoa = FNC_NVL(.Item("ID_ADMINISTRADORA"), 0)
          chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "N") = "S")
          chkControlaCredito.Checked = (FNC_NVL(.Item("IC_CONTROLACREDITO"), "N") = "S")
          chkSenhaSupervisor.Checked = (FNC_NVL(.Item("IC_SENHA_SUPERVISOR"), "N") = "S")
          txtContrato.Text = FNC_NVL(.Item("CD_CONTRATO"), "")
          ComboBox_Selecionar(cboTipoConvenio, FNC_NVL(.Item("ID_OPT_TIPO"), 0))
          txtDiaCorte.Value = FNC_NVL(.Item("NR_DIA_CORTE"), 0)
          txtDiaPrevPagto.Value = FNC_NVL(.Item("NR_DIA_PREVISAO_PAGAMENTO"), 0)
        End With
      End If
    End If

    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_Convenio).bGravar
  End Sub

  Private Sub CmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    Dim sSqlText As String

    If Trim(txtNomeConvenio.Text) = "" Then
      FNC_Mensagem("Informe o nome do convênio")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboTipoConvenio) Then
      FNC_Mensagem("Selecione o tipo de convênio")
      Exit Sub
    End If

    sSqlText = DBMontar_SP("SP_CONVENIO_CAD", False, "@SQ_CONVENIO OUT",
                                                     "@ID_EMPRESA",
                                                     "@ID_ADMINISTRADORA",
                                                     "@ID_OPT_TIPO",
                                                     "@NO_CONVENIO",
                                                     "@CD_CONTRATO",
                                                     "@NR_DIA_CORTE",
                                                     "@NR_DIA_PREVISAO_PAGAMENTO",
                                                     "@IC_ATIVO",
                                                     "@IC_CONTROLACREDITO",
                                                     "@IC_SENHA_SUPERVISOR")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_CONVENIO", iSQ_CONVENIO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_ADMINISTRADORA", FNC_NuloZero(psqAdministradora.ID_Pessoa, False)),
                            DBParametro_Montar("ID_OPT_TIPO", cboTipoConvenio.SelectedValue),
                            DBParametro_Montar("NO_CONVENIO", txtNomeConvenio.Text.Trim()),
                            DBParametro_Montar("CD_CONTRATO", txtContrato.Text.Trim()),
                            DBParametro_Montar("NR_DIA_CORTE", txtDiaCorte.Value),
                            DBParametro_Montar("NR_DIA_PREVISAO_PAGAMENTO", txtDiaPrevPagto.Value),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N")),
                            DBParametro_Montar("IC_CONTROLACREDITO", IIf(chkControlaCredito.Checked, "S", "N")),
                            DBParametro_Montar("IC_SENHA_SUPERVISOR", IIf(chkSenhaSupervisor.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_CONVENIO = DBRetorno(1)
      End If
    End If

    RaiseEvent Pesquisar()

    FNC_Mensagem("Gravação Efetuada")
  End Sub
End Class