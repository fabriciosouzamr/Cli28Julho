Public Class frmCadastroNaturezaOperacao
    Public Event Pesquisar()

    Public iSQ_NATUREZAOPERACAO As Integer

    Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
        Close()
    End Sub

    Private Sub frmCadastroNaturezaOperacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UltraComboBox_Inicializar(cboCFOP_DescricaoDentroEstado, 550)

        ComboBox_Carregar(cboFinalidade, enSql.Finalidade_NFe)
        ComboBox_Carregar(cboPlanoContas, enSql.PlanoContas)
        ComboBox_Carregar(cboStatusNumeroSerieBloqueado, enSql.StatusEstoqueLocalizacao)
        ComboBox_Carregar(cboObrigatoriedadeNumeroSerie, enSql.ObrigatoriedadeNumeroSerie)
        ComboBox_Carregar(cboTipoDocumentoFiscal, enSql.TipoDocumentoFiscal)
        ComboBox_Carregar(cboTipoReferencia, enSql.TipoReferenciaNaturezaOperacao)
        ComboBox_Carregar(cboStatusDocFiscalReferenciado, enSql.StatusDocumentoFiscal)
        ComboBox_Selecionar(cboTipoReferencia, enOpcoes.TipoReferenciaNaturezaOperacao_NaoReferenciar.GetHashCode())

        UltraComboBox_Carregar(cboCFOP_DescricaoDentroEstado, enSql.CFOP_DentroEstado)
        UltraComboBox_Carregar(cboCFOP_DescricaoForaEstado, enSql.CFOP_ForaEstado)
        UltraComboBox_Carregar(cboCFOP_DescricaoForaPais, enSql.CFOP_ForaPais)

        lblCFOP_DescricaoDentroEstado.Text = ""
        lblCFOP_DescricaoForaEstado.Text = ""
        lblCFOP_DescricaoForaPais.Text = ""
        chkAtivo.Checked = True

        TextBox_FormatarCampoTexto(txtObservacao)

        VerificarBloquearEstoque()

        lblRStatusDocFiscalReferenciado.Enabled = False
        cboStatusNumeroSerieBloqueado.Enabled = False

        If iSQ_NATUREZAOPERACAO > 0 Then
            CarregarDados()
        End If
    End Sub

    Private Sub CarregarDados()
        Dim oData As DataTable
        Dim sSqlText As String

        sSqlText = "SELECT * FROM TB_NATUREZAOPERACAO WHERE SQ_NATUREZAOPERACAO = " & iSQ_NATUREZAOPERACAO
        oData = DBQuery(sSqlText)

        If Not objDataTable_Vazio(oData) Then
            With oData.Rows(0)
                txtNomeNaturezaOperacao.Text = .Item("NO_NATUREZAOPERACAO")
                UltraComboBox_Selecionar(cboCFOP_DescricaoDentroEstado, enCombox_CFOP.SQ_CFOP, FNC_NVL(.Item("ID_CFOP_DENTROESTADO"), 0))
                UltraComboBox_Selecionar(cboCFOP_DescricaoForaEstado, enCombox_CFOP.SQ_CFOP, FNC_NVL(.Item("ID_CFOP_FORAESTADO"), 0))
                UltraComboBox_Selecionar(cboCFOP_DescricaoForaPais, enCombox_CFOP.SQ_CFOP, FNC_NVL(.Item("ID_CFOP_FORAPAIS"), 0))
                ComboBox_Selecionar(cboPlanoContas, .Item("ID_PLANOCONTAS"))
                ComboBox_Selecionar(cboFinalidade, .Item("ID_OPT_FINALIDADE"))
                ComboBox_Selecionar(cboObrigatoriedadeNumeroSerie, .Item("ID_OPT_OBRIGATORIEDADE_NUMEROSERIE"))
                ComboBox_Selecionar(cboStatusNumeroSerieBloqueado, .Item("ID_ESTOQUE_LOCALIZACAO_STATUS"))
                ComboBox_Selecionar(cboTipoDocumentoFiscal, .Item("ID_DOCUMENTOFISCAL_TIPO"))
                ComboBox_Selecionar(cboSerieDocumentoFiscal, .Item("ID_DOCUMENTOFISCAL_SERIE"))
                ComboBox_Selecionar(cboTipoReferencia, .Item("ID_OPT_TIPO_REFERENCIA"))
                txtBaseICMS.Value = FNC_NVL(.Item("PC_BASE_ICMS"), 0)
                txtBaseICMS_ST.Value = FNC_NVL(.Item("PC_BASE_SUBSTITUICAO_ICMS"), 0)
                chkGerarFinanceiro.Checked = (FNC_NVL(.Item("IC_GERAFINANCEIRO"), "N") = "S")
                chkMovimentarEstoque.Checked = (FNC_NVL(.Item("IC_MOVIMENTAESTOQUE"), "N") = "S")
                chkCalcularIPI.Checked = (FNC_NVL(.Item("IC_CALCULA_IPI"), "N") = "S")
                chkPermiteAproveitamentCreditoICMS.Checked = (FNC_NVL(.Item("IC_CREDITO_ICMS"), "N") = "S")
                chkDestacaTributosImpostosFederaisEstaduaisMunicipais.Checked = (FNC_NVL(.Item("IC_DESTACA_IMPOSTOS"), "N") = "S")
                chkExibePedido.Checked = (FNC_NVL(.Item("IC_EXIGEPEDIDO"), "N") = "S")
                chkBloquearEstoque.Checked = (FNC_NVL(.Item("IC_PRODUTO_BLOQUEARESTOQUE"), "N") = "S")
                chkUsarOrcamento.Checked = (FNC_NVL(.Item("IC_USAR_ORCAMENTO"), "N") = "S")
                chkAtivo.Checked = (.Item("IC_ATIVO") = "S")
                txtObservacao.Text = FNC_NVL(.Item("CM_OBSERVACAO"), "")
            End With
        End If
    End Sub

    Private Sub cboCFOP_DescricaoDentroEstado_ValueChanged(sender As Object, e As EventArgs) Handles cboCFOP_DescricaoDentroEstado.ValueChanged
        If cboCFOP_DescricaoDentroEstado.ActiveRow Is Nothing Then
            lblCFOP_DescricaoDentroEstado.Text = ""
        Else
            lblCFOP_DescricaoDentroEstado.Text = cboCFOP_DescricaoDentroEstado.ActiveRow.Cells(enCombox_CFOP.DS_CFOP).Text
        End If
    End Sub

    Private Sub cboCFOP_DescricaoForaEstado_ValueChanged(sender As Object, e As EventArgs) Handles cboCFOP_DescricaoForaEstado.ValueChanged
        If cboCFOP_DescricaoForaEstado.ActiveRow Is Nothing Then
            lblCFOP_DescricaoForaEstado.Text = ""
        Else
            lblCFOP_DescricaoForaEstado.Text = cboCFOP_DescricaoForaEstado.ActiveRow.Cells(enCombox_CFOP.DS_CFOP).Text
        End If
    End Sub

    Private Sub cboCFOP_DescricaoForaPais_ValueChanged(sender As Object, e As EventArgs) Handles cboCFOP_DescricaoForaPais.ValueChanged
        If cboCFOP_DescricaoForaPais.ActiveRow Is Nothing Then
            lblCFOP_DescricaoForaPais.Text = ""
        Else
            lblCFOP_DescricaoForaPais.Text = cboCFOP_DescricaoForaPais.ActiveRow.Cells(enCombox_CFOP.DS_CFOP).Text
        End If
    End Sub

    Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
        Dim sSqlText As String

        If Trim(txtNomeNaturezaOperacao.Text) = "" Then
            FNC_Mensagem("É necessário informar o nome da natureza de operação")
            Exit Sub
        End If
        If Not UltraComboBox_Selecionado(cboCFOP_DescricaoDentroEstado) Then
            FNC_Mensagem("É necessário selelecionar o CFOP")
            Exit Sub
        End If
        If chkBloquearEstoque.Checked And Not ComboBox_Selecionado(cboStatusNumeroSerieBloqueado) Then
            FNC_Mensagem("É necessário selelecionar o Status de Número de Série Bloqueado")
            Exit Sub
        End If
        If cboStatusDocFiscalReferenciado.Enabled Then
            If Not ComboBox_Selecionado(cboStatusDocFiscalReferenciado) Then
                FNC_Mensagem("Informe o novo status do documento referenciado")
                Exit Sub
            End If
        End If

        sSqlText = DBMontar_SP("SP_NATUREZAOPERACAO_CAD", False, "@SQ_NATUREZAOPERACAO OUT",
                                                                 "@ID_EMPRESA",
                                                                 "@ID_CFOP_DENTROESTADO",
                                                                 "@ID_CFOP_FORAESTADO",
                                                                 "@ID_CFOP_FORAPAIS",
                                                                 "@ID_PLANOCONTAS",
                                                                 "@ID_OPT_FINALIDADE",
                                                                 "@ID_OPT_OBRIGATORIEDADE_NUMEROSERIE",
                                                                 "@ID_OPT_TIPO_REFERENCIA",
                                                                 "@ID_DOCUMENTOFISCAL_TIPO",
                                                                 "@ID_DOCUMENTOFISCAL_SERIE",
                                                                 "@ID_ESTOQUE_LOCALIZACAO_STATUS",
                                                                 "@ID_STATUS_DOCUMENTOFISCALREFERENCIADO",
                                                                 "@NO_NATUREZAOPERACAO",
                                                                 "@PC_BASE_ICMS",
                                                                 "@PC_BASE_SUBSTITUICAO_ICMS",
                                                                 "@IC_MOVIMENTAESTOQUE",
                                                                 "@IC_GERAFINANCEIRO",
                                                                 "@IC_CALCULA_IPI",
                                                                 "@IC_CREDITO_ICMS",
                                                                 "@IC_DESTACA_IMPOSTOS",
                                                                 "@IC_EXIGEPEDIDO",
                                                                 "@IC_PRODUTO_BLOQUEARESTOQUE",
                                                                 "@IC_USAR_ORCAMENTO",
                                                                 "@IC_ATIVO",
                                                                 "@CM_OBSERVACAO")
        If DBExecutar(sSqlText, DBParametro_Montar("SQ_NATUREZAOPERACAO", iSQ_NATUREZAOPERACAO, , ParameterDirection.InputOutput),
                                DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                                DBParametro_Montar("ID_CFOP_DENTROESTADO", UltraComboBox_Valor(cboCFOP_DescricaoDentroEstado)),
                                DBParametro_Montar("ID_CFOP_FORAESTADO", UltraComboBox_Valor(cboCFOP_DescricaoForaEstado)),
                                DBParametro_Montar("ID_CFOP_FORAPAIS", UltraComboBox_Valor(cboCFOP_DescricaoForaPais)),
                                DBParametro_Montar("ID_PLANOCONTAS", cboPlanoContas.SelectedValue),
                                DBParametro_Montar("ID_OPT_FINALIDADE", cboFinalidade.SelectedValue),
                                DBParametro_Montar("ID_OPT_OBRIGATORIEDADE_NUMEROSERIE", cboObrigatoriedadeNumeroSerie.SelectedValue),
                                DBParametro_Montar("ID_OPT_TIPO_REFERENCIA", cboTipoReferencia.SelectedValue),
                                DBParametro_Montar("ID_DOCUMENTOFISCAL_TIPO", cboTipoDocumentoFiscal.SelectedValue),
                                DBParametro_Montar("ID_DOCUMENTOFISCAL_SERIE", cboSerieDocumentoFiscal.SelectedValue),
                                DBParametro_Montar("ID_ESTOQUE_LOCALIZACAO_STATUS", cboStatusNumeroSerieBloqueado.SelectedValue),
                                DBParametro_Montar("ID_STATUS_DOCUMENTOFISCALREFERENCIADO", cboStatusDocFiscalReferenciado.SelectedValue),
                                DBParametro_Montar("NO_NATUREZAOPERACAO", Trim(txtNomeNaturezaOperacao.Text)),
                                DBParametro_Montar("PC_BASE_ICMS", txtBaseICMS.Value),
                                DBParametro_Montar("PC_BASE_SUBSTITUICAO_ICMS", txtBaseICMS_ST.Value),
                                DBParametro_Montar("IC_MOVIMENTAESTOQUE", IIf(chkMovimentarEstoque.Checked, "S", "N")),
                                DBParametro_Montar("IC_GERAFINANCEIRO", IIf(chkGerarFinanceiro.Checked, "S", "N")),
                                DBParametro_Montar("IC_CALCULA_IPI", IIf(chkCalcularIPI.Checked, "S", "N")),
                                DBParametro_Montar("IC_CREDITO_ICMS", IIf(chkPermiteAproveitamentCreditoICMS.Checked, "S", "N")),
                                DBParametro_Montar("IC_DESTACA_IMPOSTOS", IIf(chkDestacaTributosImpostosFederaisEstaduaisMunicipais.Checked, "S", "N")),
                                DBParametro_Montar("IC_EXIGEPEDIDO", IIf(chkExibePedido.Checked, "S", "N")),
                                DBParametro_Montar("IC_PRODUTO_BLOQUEARESTOQUE", IIf(chkBloquearEstoque.Checked, "S", "N")),
                                DBParametro_Montar("IC_USAR_ORCAMENTO", IIf(chkUsarOrcamento.Checked, "S", "N")),
                                DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N")),
                                DBParametro_Montar("CM_OBSERVACAO", FNC_NuloSe(Trim(txtObservacao.Text), ""),,, const_BancoDados_TamanhoComentario)) Then
            If DBTeveRetorno() Then
                iSQ_NATUREZAOPERACAO = DBRetorno(1)
            End If

            RaiseEvent Pesquisar()

            FNC_Mensagem("Gravação Efetuada")
        End If
    End Sub

    Private Sub chkBloquearEstoque_CheckedChanged(sender As Object, e As EventArgs) Handles chkBloquearEstoque.CheckedChanged
        VerificarBloquearEstoque()
    End Sub

    Private Sub VerificarBloquearEstoque()
        lblR_StatusNumeroSerieBloqueado.Enabled = chkBloquearEstoque.Checked
        cboStatusNumeroSerieBloqueado.Enabled = chkBloquearEstoque.Checked
    End Sub

    Private Sub cboTipoDocumentoFiscal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDocumentoFiscal.SelectedIndexChanged
        FormCadastroDocumentoFiscal_TipoDocumentoFiscal_Carregar(cboTipoDocumentoFiscal, cboSerieDocumentoFiscal, lblInfoDocumentoFiscal)
    End Sub

    Private Sub cboTipoDocumentoFiscal_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoDocumentoFiscal.KeyDown
        If e.KeyCode = Keys.Delete Then
            cboTipoDocumentoFiscal.SelectedIndex = -1
            cboSerieDocumentoFiscal.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboSerieDocumentoFiscal_KeyDown(sender As Object, e As KeyEventArgs) Handles cboSerieDocumentoFiscal.KeyDown
        If e.KeyCode = Keys.Delete Then
            cboSerieDocumentoFiscal.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboObrigatoriedadeNumeroSerie_KeyDown(sender As Object, e As KeyEventArgs) Handles cboObrigatoriedadeNumeroSerie.KeyDown
        If e.KeyCode = Keys.Delete Then
            cboObrigatoriedadeNumeroSerie.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboStatusNumeroSerieBloqueado_KeyDown(sender As Object, e As KeyEventArgs) Handles cboStatusNumeroSerieBloqueado.KeyDown
        If e.KeyCode = Keys.Delete Then
            cboStatusNumeroSerieBloqueado.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboFinalidade_KeyDown(sender As Object, e As KeyEventArgs) Handles cboFinalidade.KeyDown
        If e.KeyCode = Keys.Delete Then
            cboFinalidade.SelectedIndex = -1
        End If
    End Sub

    Private Sub cboCFOP_DescricaoDentroEstado_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles cboCFOP_DescricaoDentroEstado.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            cboCFOP_DescricaoDentroEstado.SelectedRow = Nothing
        End If
    End Sub

    Private Sub cboCFOP_DescricaoForaEstado_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles cboCFOP_DescricaoForaEstado.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            cboCFOP_DescricaoForaEstado.SelectedRow = Nothing
        End If
    End Sub

    Private Sub cboCFOP_DescricaoForaPais_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles cboCFOP_DescricaoForaPais.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            cboCFOP_DescricaoForaPais.SelectedRow = Nothing
        End If
    End Sub

    Private Sub cboTipoReferencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoReferencia.SelectedIndexChanged
        lblRStatusDocFiscalReferenciado.Enabled = (FNC_NVL(cboTipoReferencia.SelectedValue, 0) = enOpcoes.TipoReferenciaNaturezaOperacao_ReferenciarNFCe Or
                                                   FNC_NVL(cboTipoReferencia.SelectedValue, 0) = enOpcoes.TipoReferenciaNaturezaOperacao_ReferenciarNFe)
        cboStatusDocFiscalReferenciado.Enabled = lblRStatusDocFiscalReferenciado.Enabled
    End Sub
End Class