Public Class uscCadParametrizacaoFiscal
  Public Sub Formatar()
    Dim oData As DataTable
    Dim sSqlText As String

    ComboBox_Carregar(cboCRT, enSql.NFe_CodigoRegimeTributario)
    ComboBox_Carregar(cboTipoContribuicaoICMS, enSql.NFe_IndicadorIEDestinatario)
    ComboBox_Carregar(cboCRT_ISSQN, enSql.RegimeTributarioISSQN)
    ComboBox_Carregar(cboRateioISSQN, enSql.SimNao)

    sSqlText = "SELECT * FROM VW_EMPRESA WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      txtCNAEFiscal.Text = FNC_NVL(.Item("CD_CNAE"), "")
      ComboBox_Selecionar(cboCRT, .Item("ID_OPT_CRT"))
      ComboBox_Selecionar(cboCRT_ISSQN, .Item("ID_OPT_CRT_ISSQN"))
      ComboBox_Selecionar(cboRateioISSQN, .Item("ID_OPT_RATEIO_ISSQN"))
      ComboBox_Selecionar(cboTipoContribuicaoICMS, FNC_NVL(.Item("ID_OPT_PJ_CONTRIBUICAO_ICMS"), enOpcoes.NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS.GetHashCode()))
    End With
  End Sub

  Public Sub Gravar()
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_EMPRESA_FISCAL_UPD", False, "@ID_EMPRESA",
                                                           "@ID_OPT_CRT",
                                                           "@ID_OPT_PJ_CONTRIBUICAO_ICMS",
                                                           "@ID_OPT_CRT_ISSQN",
                                                           "@ID_OPT_RATEIO_ISSQN",
                                                           "@CD_CNAE")
    DBExecutar(sSqlText, DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                         DBParametro_Montar("ID_OPT_CRT", cboCRT.SelectedValue),
                         DBParametro_Montar("ID_OPT_PJ_CONTRIBUICAO_ICMS", cboTipoContribuicaoICMS.SelectedValue),
                         DBParametro_Montar("ID_OPT_CRT_ISSQN", cboCRT_ISSQN.SelectedValue),
                         DBParametro_Montar("ID_OPT_RATEIO_ISSQN", cboRateioISSQN.SelectedValue),
                         DBParametro_Montar("CD_CNAE", txtCNAEFiscal.Text))
  End Sub
End Class
