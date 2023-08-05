Public Class frmCadastroModeloDocumento
  Public Event Pesquisar()

  Public iSQ_MODELODOCUMENTO As Integer

  Dim bCarregado As Boolean = False

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroModeloDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboTipoModeloDocumento, enSql.TipoModeloDocumento, New String() {const_TipoAnexo_Grupo_Atendimento,
                                                                                       const_TipoAnexo_Grupo_Impressao})
    ComboBox_Carregar(cboModeloAssinatura, enSql.ElementoModeloDocumento_Assinatura)
    ComboBox_Carregar(cboModeloCabecalho, enSql.ElementoModeloDocumento_Cabecalho)
    ComboBox_Carregar(cboModeloRodape, enSql.ElementoModeloDocumento_Rodape)

    bCarregado = True

    chkAtivo.Checked = True

    If iSQ_MODELODOCUMENTO = 0 Then
      chkExibirNumeroPagina.Checked = True
      ComboBox_Selecionar(cboModeloAssinatura, enModeloDocumentoElemento_Padrao.Assinatura.GetHashCode)
      ComboBox_Selecionar(cboModeloCabecalho, enModeloDocumentoElemento_Padrao.Cabecalho.GetHashCode)
      ComboBox_Selecionar(cboModeloRodape, enModeloDocumentoElemento_Padrao.Rodape.GetHashCode)
    Else
      CarregarDados()
    End If
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM TB_MODELODOCUMENTO WHERE SQ_MODELODOCUMENTO = " & iSQ_MODELODOCUMENTO
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      With oData.Rows(0)
        txtNomeModeloDocumento.Text = .Item("NO_MODELODOCUMENTO")
        ComboBox_Selecionar(cboTipoModeloDocumento, .Item("ID_OPT_TIPO_MODELODOCUMENTO"))
        ComboBox_Selecionar(cboProcesso, FNC_NVL(.Item("ID_DICIONARIODADO_PROCESSO"), 0))
        oEditorTexto.Rtf = .Item("TX_MODELODOCUMENTO")
        ComboBox_Selecionar(cboModeloCabecalho, FNC_NVL(.Item("ID_MODELO_CABECALHO"), 0))
        ComboBox_Selecionar(cboModeloAssinatura, FNC_NVL(.Item("ID_MODELO_ASSINATURA"), 0))
        ComboBox_Selecionar(cboModeloRodape, FNC_NVL(.Item("ID_MODELO_RODAPE"), 0))
        chkExibirNumeroPagina.Checked = (FNC_NVL(.Item("IC_NUMEROPAGINA"), "N") = "S")
        chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "N") = "S")
      End With
    End If
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboTipoModeloDocumento) Then
      FNC_Mensagem("Selecione o Tipo de Modelo de Documento")
      Exit Sub
    End If
    If Trim(txtNomeModeloDocumento.Text) = "" Then
      FNC_Mensagem("Informe o nome do modelo do documento")
      Exit Sub
    End If
    If Trim(oEditorTexto.Texto) = "" Then
      FNC_Mensagem("Informe o texto desse modelo de documento")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_MODELODOCUMENTO_CAD", False, "@SQ_MODELODOCUMENTO OUT",
                                                            "@ID_EMPRESA",
                                                            "@ID_OPT_TIPO_MODELODOCUMENTO",
                                                            "@ID_MODELO_CABECALHO",
                                                            "@ID_MODELO_RODAPE",
                                                            "@ID_MODELO_ASSINATURA",
                                                            "@ID_DICIONARIODADO_PROCESSO",
                                                            "@NO_MODELODOCUMENTO",
                                                            "@TX_MODELODOCUMENTO",
                                                            "@IC_NUMEROPAGINA",
                                                            "@IC_ATIVO")
    If DBExecutar(sSqlText, DBParametro_Montar("SQ_MODELODOCUMENTO", iSQ_MODELODOCUMENTO, , ParameterDirection.InputOutput),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_OPT_TIPO_MODELODOCUMENTO", cboTipoModeloDocumento.SelectedValue),
                            DBParametro_Montar("ID_MODELO_CABECALHO", cboModeloCabecalho.SelectedValue),
                            DBParametro_Montar("ID_MODELO_RODAPE", cboModeloRodape.SelectedValue),
                            DBParametro_Montar("ID_MODELO_ASSINATURA", cboModeloAssinatura.SelectedValue),
                            DBParametro_Montar("ID_DICIONARIODADO_PROCESSO", FNC_NVL(cboProcesso.SelectedValue, 0)),
                            DBParametro_Montar("NO_MODELODOCUMENTO", Trim(txtNomeModeloDocumento.Text)),
                            DBParametro_Montar("TX_MODELODOCUMENTO", oEditorTexto.Rtf, SqlDbType.NText),
                            DBParametro_Montar("IC_NUMEROPAGINA", IIf(chkExibirNumeroPagina.Checked, "S", "N")),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N"))) Then
      If DBTeveRetorno() Then
        iSQ_MODELODOCUMENTO = DBRetorno(1)
      End If

      RaiseEvent Pesquisar()

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub chkExibirNumeroPagina_CheckedChanged(sender As Object, e As EventArgs) Handles chkExibirNumeroPagina.CheckedChanged
    oEditorTexto.ExibirNumeroPagina = chkExibirNumeroPagina.Checked
  End Sub

  Private Sub cboModeloCabecalho_KeyDown(sender As Object, e As KeyEventArgs) Handles cboModeloCabecalho.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboModeloCabecalho.SelectedValue = -1
    End If
  End Sub

  Private Sub cboModeloAssinatura_KeyDown(sender As Object, e As KeyEventArgs) Handles cboModeloAssinatura.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboModeloAssinatura.SelectedValue = -1
    End If
  End Sub

  Private Sub cboModeloRodape_KeyDown(sender As Object, e As KeyEventArgs) Handles cboModeloRodape.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboModeloRodape.SelectedValue = -1
    End If
  End Sub

  Private Sub cboModeloCabecalho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModeloCabecalho.SelectedIndexChanged
    oEditorTexto.MODELO_CABECALHO = FNC_NVL(cboModeloCabecalho.SelectedValue, -1)
  End Sub

  Private Sub cboModeloAssinatura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModeloAssinatura.SelectedIndexChanged
    oEditorTexto.MODELO_ASSINATURA = FNC_NVL(cboModeloAssinatura.SelectedValue, -1)
  End Sub

  Private Sub cboModeloRodape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModeloRodape.SelectedIndexChanged
    oEditorTexto.MODELO_RODAPE = FNC_NVL(cboModeloRodape.SelectedValue, -1)
  End Sub

  Private Sub cboProcesso_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProcesso.SelectedValueChanged
    If bCarregado Then
      If ComboBox_Selecionado(cboProcesso) Then
        oEditorTexto.DICIONARIODADO_PROCESSO = FNC_NVL(cboProcesso.SelectedValue, 0)
      Else
        oEditorTexto.DICIONARIODADO_PROCESSO = 0
      End If
    End If
  End Sub

  Private Sub cboTipoModeloDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoModeloDocumento.SelectedIndexChanged
    If bCarregado Then
      ComboBox_Carregar(cboProcesso,
                        enSql.DicionarioDado_Processo_TipoModeloDocumento,
                        New Object() {FNC_NVL(cboTipoModeloDocumento.SelectedValue, 0)})

      If cboProcesso.Items.Count = 1 Then
        cboProcesso.SelectedIndex = 0
      End If
    End If
  End Sub
End Class