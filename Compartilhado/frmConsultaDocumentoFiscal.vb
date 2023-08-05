Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaDocumentoFiscal
  Const const_GridListagem_SQ_DOCUMENTOFISCAL As Integer = 0
  Const const_GridListagem_ID_DOCUMENTOFISCAL_TIPO As Integer = 1
  Const const_GridListagem_ID_OPT_STATUS As Integer = 2
  Const const_GridListagem_ID_PESSOA As Integer = 3
  Const const_GridListagem_CD_SERVICO_MODELO As Integer = 4
  Const const_GridListagem_NO_DOCUMENTOFISCAL_TIPO As Integer = 5
  Const const_GridListagem_CD_DOCUMENTOFISCAL_SERIE As Integer = 6
  Const const_GridListagem_CD_DOCUMENTOFISCAL As Integer = 7
  Const const_GridListagem_DH_EMISSAO As Integer = 8
  Const const_GridListagem_NO_PESSOA As Integer = 9
  Const const_GridListagem_NO_NATUREZAOPERACAO As Integer = 10
  Const const_GridListagem_VL_DOCUMENTOFISCAL As Integer = 11
  Const const_GridListagem_NO_OPT_STATUS As Integer = 12
  Const const_GridListagem_DS_PATH_XML As Integer = 13
  Const const_GridListagem_CD_CHAVE_NFE As Integer = 14
  Const const_GridListagem_CD_PROTOCOLO As Integer = 15
  Const const_GridListagem_DataCartaCorrecao As Integer = 16
  Const const_GridListagem_CartaCorrecao As Integer = 17
  Const const_GridListagem_DataCancelamento As Integer = 18
  Const const_GridListagem_JustificativaCancelamento As Integer = 19

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub frmConsultaOrdemServico_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdCancelar.Top = cmdNovo.Top
    cmdCartaCorrecao.Top = cmdNovo.Top
    cmdImprimir.Top = cmdNovo.Top
    cmdTransmitir_NFe.Top = cmdNovo.Top
    cmdHistorico.Top = cmdNovo.Top
    cmdBaixarXML.Top = cmdCancelar.Top
    cmdExcel.Top = cmdCancelar.Top
    cmdPDF.Top = cmdExcel.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdNovo.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(New frmCadastroDocumentoFiscal)
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaOrdemServico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_DOCUMENTOFISCAL", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_TIPO_ORDEMSERVICO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA", 0)
    objGrid_Coluna_Add(grdListagem, "CD_SERVICO_MODELO", 0)
    objGrid_Coluna_Add(grdListagem, "Tipo do Documento Fiscal", 200)
    objGrid_Coluna_Add(grdListagem, "Série do Documento Fiscal", 200)
    objGrid_Coluna_Add(grdListagem, "Nº do Documento Fiscal", 200)
    objGrid_Coluna_Add(grdListagem, "Data de Emissão", 115, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 300)
    objGrid_Coluna_Add(grdListagem, "Natureza de Operação", 300)
    objGrid_Coluna_Add(grdListagem, "Vl. Documento Fiscal", 140, , , , , const_Formato_Valor_4casas)
    objGrid_Coluna_Add(grdListagem, "Status", 150)
    objGrid_Coluna_Add(grdListagem, "DS_PATH_XML", 0)
    objGrid_Coluna_Add(grdListagem, "Chave de Acesso", 150)
    objGrid_Coluna_Add(grdListagem, "Protocolo", 100)
    objGrid_Coluna_Add(grdListagem, "Data de Carta de Correção", 120, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Carta de Correção", 300)
    objGrid_Coluna_Add(grdListagem, "Data do Cancelamento", 120, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Justificativa Cancelamento", 300)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing

    ComboBox_Carregar(cboNaturezaOperacao, enSql.NaturezaOperacao)
    ComboBox_Carregar(cboTipoDocumentoFiscal, enSql.TipoDocumentoFiscal)
    ComboBox_Carregar(cboStatus, enSql.StatusDocumentoFiscal)
  End Sub

  Private Sub cboTipoDocumentoFiscal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoDocumentoFiscal.SelectedIndexChanged
    If ComboBox_Selecionado(cboTipoDocumentoFiscal) Then
      ComboBox_Carregar(cboSerieDocumentoFiscal, enSql.SerieDocumentoFiscal, New Object() {cboTipoDocumentoFiscal.SelectedValue})
    Else
      cboSerieDocumentoFiscal.DataSource = Nothing
    End If
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String

    sSqlText = "SELECT DCFSC.SQ_DOCUMENTOFISCAL," &
                      "DCFSC.ID_DOCUMENTOFISCAL_TIPO," &
                      "DCFSC.ID_OPT_STATUS," &
                      "DCFSC.ID_PESSOA," &
                      "DCFSC.CD_SERVICO_MODELO," &
                      "DCFSC.NO_DOCUMENTOFISCAL_TIPO," &
                      "DCFSC.CD_DOCUMENTOFISCAL_SERIE," &
                      "DCFSC.CD_DOCUMENTOFISCAL," &
                      "DCFSC.DH_EMISSAO," &
                      "DCFSC.NO_PESSOA," &
                      "DCFSC.NO_NATUREZAOPERACAO," &
                      "SUM(DCFPD.VL_TOTAL) VL_DOCUMENTOFISCAL," &
                      "DCFSC.NO_OPT_STATUS," &
                      "DCFSC.DS_PATH_XML," &
                      "DCFSC.CD_CHAVE_NFE," &
                      "DCFSC.CD_PROTOCOLO," &
                      "DCFSC.DH_CARTACORRECAO," &
                      "DCFSC.DS_CARTACORRECAO," &
                      "DCFSC.DH_CANCELAMENTO," &
                      "DCFSC.DS_JUSTIFICATIVA_CANCELAMENTO" &
               " FROM VW_DOCUMENTOFISCAL DCFSC" &
                " INNER JOIN VW_DOCUMENTOFISCAL_PRODUTO DCFPD ON DCFPD.ID_DOCUMENTOFISCAL = DCFSC.SQ_DOCUMENTOFISCAL " &
               " WHERE DCFSC.ID_EMPRESA = " & iID_EMPRESA_FILIAL

    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText, "DCFSC.ID_PESSOA = " & psqPessoa.ID_Pessoa, " AND ")
    End If
    If ComboBox_Selecionado(cboStatus) Then
      FNC_Str_Adicionar(sSqlText, "DCFSC.ID_OPT_STATUS = " & cboStatus.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboNaturezaOperacao) Then
      FNC_Str_Adicionar(sSqlText, "DCFSC.ID_NATUREZAOPERACAO = " & cboNaturezaOperacao.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboTipoDocumentoFiscal) Then
      FNC_Str_Adicionar(sSqlText, "DCFSC.ID_DOCUMENTOFISCAL_TIPO = " & cboTipoDocumentoFiscal.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboSerieDocumentoFiscal) Then
      FNC_Str_Adicionar(sSqlText, "DCFSC.ID_DOCUMENTOFISCAL_SERIE = " & cboSerieDocumentoFiscal.SelectedValue, " AND ")
    End If
    If IsDate(txtDataInicial.Value) Then
      FNC_Str_Adicionar(sSqlText, "CAST(DCFSC.DH_EMISSAO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text), " AND ")
    End If
    If IsDate(txtDataFinal.Value) Then
      FNC_Str_Adicionar(sSqlText, "CAST(DCFSC.DH_EMISSAO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text), " AND ")
    End If
    If psqProduto.Identificador > 0 Then
      FNC_Str_Adicionar(sSqlText, "SQ_DOCUMENTOFISCAL IN (SELECT ID_DOCUMENTOFISCAL" &
                                                         " FROM TB_DOCUMENTOFISCAL_PRODUTO" &
                                                         " WHERE ID_PRODUTO_EMPRESA = " & psqProduto.Identificador_Filial & ")", " AND ")
    End If
    If Trim(txtCodDocumento.Text) <> "" Then
            FNC_Str_Adicionar(sSqlText, "DCFSC.CD_DOCUMENTOFISCAL LIKE " & FNC_SQL_FormatarLike(Trim(txtCodDocumento.Text)), " AND ")
        End If

    sSqlText = sSqlText &
               " GROUP BY DCFSC.SQ_DOCUMENTOFISCAL," &
                         "DCFSC.ID_DOCUMENTOFISCAL_TIPO," &
                         "DCFSC.ID_OPT_STATUS," &
                         "DCFSC.ID_PESSOA," &
                         "DCFSC.CD_SERVICO_MODELO," &
                         "DCFSC.NO_DOCUMENTOFISCAL_TIPO," &
                         "DCFSC.CD_DOCUMENTOFISCAL_SERIE," &
                         "DCFSC.CD_DOCUMENTOFISCAL," &
                         "DCFSC.DH_EMISSAO," &
                         "DCFSC.NO_PESSOA," &
                         "DCFSC.NO_NATUREZAOPERACAO," &
                         "DCFSC.NO_OPT_STATUS," &
                         "DCFSC.DS_PATH_XML," &
                         "DCFSC.CD_CHAVE_NFE," &
                         "DCFSC.CD_PROTOCOLO," &
                         "DCFSC.DH_CARTACORRECAO," &
                         "DCFSC.DS_CARTACORRECAO," &
                         "DCFSC.DH_CANCELAMENTO," &
                         "DCFSC.DS_JUSTIFICATIVA_CANCELAMENTO"
    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_DOCUMENTOFISCAL,
                                                           const_GridListagem_ID_DOCUMENTOFISCAL_TIPO,
                                                           const_GridListagem_ID_OPT_STATUS,
                                                           const_GridListagem_ID_PESSOA,
                                                           const_GridListagem_CD_SERVICO_MODELO,
                                                           const_GridListagem_NO_DOCUMENTOFISCAL_TIPO,
                                                           const_GridListagem_CD_DOCUMENTOFISCAL_SERIE,
                                                           const_GridListagem_CD_DOCUMENTOFISCAL,
                                                           const_GridListagem_DH_EMISSAO,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_NO_NATUREZAOPERACAO,
                                                           const_GridListagem_VL_DOCUMENTOFISCAL,
                                                           const_GridListagem_NO_OPT_STATUS,
                                                           const_GridListagem_DS_PATH_XML,
                                                           const_GridListagem_CD_CHAVE_NFE,
                                                           const_GridListagem_CD_PROTOCOLO,
                                                           const_GridListagem_DataCartaCorrecao,
                                                           const_GridListagem_CartaCorrecao,
                                                           const_GridListagem_DataCancelamento,
                                                           const_GridListagem_JustificativaCancelamento})

    objGrid_ExibirTotal(grdListagem, New Integer() {const_GridListagem_VL_DOCUMENTOFISCAL})
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o documento fiscal a ser alterado")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusDocumentoFiscal_DocumentoFiscalGerado.GetHashCode() Then
      FNC_Mensagem("Documento Fiscal já gerado")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusDocumentoFiscal_Cancelado.GetHashCode() Then
      FNC_Mensagem("Documento Fiscal já cancelado")
      Exit Sub
    End If

    Dim oForm As New frmCadastroDocumentoFiscal

    oForm.iSQ_DOCUMENTOFISCAL = objGrid_Valor(grdListagem, const_GridListagem_SQ_DOCUMENTOFISCAL)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o documento fiscal a ser cancelado")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusDocumentoFiscal_Cancelado.GetHashCode() Then
      FNC_Mensagem("Documento Fiscal já cancelado")
      Exit Sub
    End If

    If Not FNC_Perguntar("Deseja realmente cancelar esse documento fiscal?") Then Exit Sub

    Dim oForm As New frmCadastroDocumentoFiscal_CC_Cancelamento

    oForm.CadastroDocumentoFiscal_CC_Cancelamento = frmCadastroDocumentoFiscal_CC_Cancelamento.enCadastroDocumentoFiscal_CC_Cancelamento.Cancelamento
    oForm.iSQ_DOCUMENTOFISCAL = objGrid_Valor(grdListagem, const_GridListagem_SQ_DOCUMENTOFISCAL)

    FNC_AbriTela(oForm,, True, True)
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para impressão")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_DS_PATH_XML,, "") = "" Then
      FNC_Mensagem("Documento Fiscal ainda não foi gerado")
      Exit Sub
    End If

    Select Case objGrid_Valor(grdListagem, const_GridListagem_CD_SERVICO_MODELO)
      Case const_NFe_ModeloServico_NFCe
        FNC_Fiscal_Danfe_ImprimirNCFe(objGrid_Valor(grdListagem, const_GridListagem_DS_PATH_XML,, ""),
                                      sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_NORMAL,
                                      sESTACAO_TRABALHO_CD_OPT_NFCe_DETALHE_VENDA_CONTIGENCIA,
                                      sESTACAO_TRABALHO_CD_NFCe_Token_ID,
                                      sESTACAO_TRABALHO_CD_NFCe_Token_CSC)
      Case const_NFe_ModeloServico_NFe
        FNC_Fiscal_Danfe_GerarPDF(FNC_DiretorioSistema_AdicionarPath(objGrid_Valor(grdListagem, const_GridListagem_DS_PATH_XML)), True)
    End Select
  End Sub

  Private Sub ComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles cboStatus.KeyDown,
                                                                            cboTipoDocumentoFiscal.KeyDown,
                                                                            cboSerieDocumentoFiscal.KeyDown,
                                                                            cboNaturezaOperacao.KeyDown
    If e.KeyCode = Keys.Delete Then
      sender.SelectedIndex = -1
    End If
  End Sub

  Private Sub cmdTransmitir_NFe_Click(sender As Object, e As EventArgs) Handles cmdTransmitir_NFe.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o documento fiscal a ser transmitido")
      Exit Sub
    End If
    If Not FNC_Perguntar("Deseja realmente transmitir esse documento fiscal") Then
      Exit Sub
    End If

    Select Case objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS)
      Case enOpcoes.StatusDocumentoFiscal_Cancelado.GetHashCode()
        FNC_Mensagem("Documento fiscal cancelado, o mesmo não pode ser transmitido")
      Case enOpcoes.StatusDocumentoFiscal_Recebido.GetHashCode()
        FNC_Mensagem("Documento fiscal recebido de terceiro, o mesmo não pode ser transmitido")
      Case enOpcoes.StatusDocumentoFiscal_Transmitido.GetHashCode()
        FNC_Mensagem("Documento fiscal já transmitido")
      Case Else
        If FNC_Fiscal_DocumentoFiscal_Transmitir(objGrid_Valor(grdListagem, const_GridListagem_SQ_DOCUMENTOFISCAL),
                                                 Val(objGrid_Valor(grdListagem, const_GridListagem_CD_SERVICO_MODELO))) Then
          FNC_Mensagem("Documento fiscal transmitido")
        End If

        Pesquisar()
    End Select
  End Sub

  Private Sub cmdHistorico_Click(sender As Object, e As EventArgs) Handles cmdHistorico.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar o documento fiscal para o qual deseja ver o histórico")
      Exit Sub
    End If

    Dim oForm As New frmConsultaHistorico_Registro

    oForm.iProcessso = enOpcoes.Processo_Historico_Cadastro_CadastroDocumentoFiscal.GetHashCode()
    oForm.iID_REGISTRO = objGrid_Valor(grdListagem, const_GridListagem_SQ_DOCUMENTOFISCAL)
    FNC_AbriTela(oForm, , True, True)
  End Sub

  Private Sub cmdCartaCorrecao_Click(sender As Object, e As EventArgs) Handles cmdCartaCorrecao.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o documento fiscal para o qual será enviada a carta de correção")
      Exit Sub
    End If
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) <> enOpcoes.StatusDocumentoFiscal_Transmitido.GetHashCode() Then
      FNC_Mensagem("Documento fiscal precisa está transmitido para ter uma carta de correção enviada")
      Exit Sub
    End If

    Dim oForm As New frmCadastroDocumentoFiscal_CC_Cancelamento

    oForm.CadastroDocumentoFiscal_CC_Cancelamento = frmCadastroDocumentoFiscal_CC_Cancelamento.enCadastroDocumentoFiscal_CC_Cancelamento.CartaCorrecao
    oForm.iSQ_DOCUMENTOFISCAL = objGrid_Valor(grdListagem, const_GridListagem_SQ_DOCUMENTOFISCAL)

    FNC_AbriTela(oForm,, True, True)
  End Sub

  Private Sub frmConsultaDocumentoFiscal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub cmdBaixarXML_Click(sender As Object, e As EventArgs) Handles cmdBaixarXML.Click
    If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS, , enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode()) = enOpcoes.StatusDocumentoFiscal_Transmitido.GetHashCode() Then
      FNC_DiretorioSistema_BaixarArquivo(objGrid_Valor(grdListagem, const_GridListagem_DS_PATH_XML))
    ElseIf objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS, , enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode()) = enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode() Then
      FNC_Mensagem("O Documento Fiscal cancelado")
    Else
      FNC_Mensagem("O Documento Fiscal não foi transmitido")
    End If
  End Sub

  Private Sub cmsBaixarXML_BaixarTodosListados_Click(sender As Object, e As EventArgs) Handles cmsBaixarXML_BaixarTodosListados.Click
    Dim iCont As Integer
    Dim sDocumentoFiscal As String

    If grdListagem.Rows.Count = 0 Then
      FNC_Mensagem("Não foi listado nenhum documento fiscal")
    Else
      Dim sDiretorio As String = FNC_Diretorio_Selecionar()

      If Trim(sDiretorio) = "" Then
        FNC_Mensagem("Diretório não selecionado")
      Else
        For iCont = 0 To grdListagem.Rows.Count - 1
          sDocumentoFiscal = objGrid_Valor(grdListagem, const_GridListagem_NO_PESSOA, iCont, "")

          If objGrid_Valor(grdListagem, const_GridListagem_CD_DOCUMENTOFISCAL, iCont, "") <> "" Then
            sDocumentoFiscal = sDocumentoFiscal & " (" & objGrid_Valor(grdListagem, const_GridListagem_CD_DOCUMENTOFISCAL, iCont, "") & ")"
          End If

          If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS, iCont, enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode()) = enOpcoes.StatusDocumentoFiscal_Transmitido.GetHashCode() Then
            If objGrid_Valor(grdListagem, const_GridListagem_ID_DOCUMENTOFISCAL_TIPO, iCont) = enTipoDocumentoFiscal.Saida_CupomFiscalEletronico.GetHashCode() Then
              FNC_DiretorioSistema_BaixarArquivo(objGrid_Valor(grdListagem, const_GridListagem_DS_PATH_XML, iCont), FNC_Diretorio_Tratar(sDiretorio) & "NFC-e " & FNC_StrZero(objGrid_Valor(grdListagem, const_GridListagem_CD_DOCUMENTOFISCAL, iCont), 5) & ".xml", False)
            Else
              FNC_DiretorioSistema_BaixarArquivo(objGrid_Valor(grdListagem, const_GridListagem_DS_PATH_XML, iCont), FNC_Diretorio_Tratar(sDiretorio) & "NF-e " & FNC_StrZero(objGrid_Valor(grdListagem, const_GridListagem_CD_DOCUMENTOFISCAL, iCont), 5) & ".xml", False)
            End If
          ElseIf objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS, iCont, enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode()) = enOpcoes.StatusDocumentoFiscal_Cadastrado.GetHashCode() Then
            FNC_Mensagem("O Documento Fiscal cancelado [" & sDocumentoFiscal & "]")
          Else
            FNC_Mensagem("O Documento Fiscal não foi transmitido [" & sDocumentoFiscal & "]")
          End If
        Next
      End If

      FNC_Mensagem("Arquivo(s) baixado(s)")
    End If
  End Sub

  Private Sub grdListagem_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grdListagem.DoubleClickCell
    cmdAlterar.PerformClick()
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    cboNaturezaOperacao.SelectedIndex = -1
    cboSerieDocumentoFiscal.SelectedIndex = -1
    cboStatus.SelectedIndex = -1
    cboTipoDocumentoFiscal.SelectedIndex = -1
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
    txtCodDocumento.Text = ""
    psqPessoa.ID_Pessoa = 0
    psqProduto.Identificador = 0
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub FrmConsultaDocumentoFiscal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.F3 Then
      cmdPesquisar.PerformClick()
    End If
  End Sub

    Private Sub cmdCopiar_Click(sender As Object, e As EventArgs) Handles cmdCopiar.Click
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
            FNC_Mensagem("Selecione o documento fiscal a ser alterado")
            Exit Sub
        End If
        If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusDocumentoFiscal_DocumentoFiscalGerado.GetHashCode() Then
            FNC_Mensagem("Documento Fiscal já gerado")
            Exit Sub
        End If
        If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusDocumentoFiscal_Cancelado.GetHashCode() Then
            FNC_Mensagem("Documento Fiscal já cancelado")
            Exit Sub
        End If

        Dim oForm As New frmCadastroDocumentoFiscal

        oForm.iSQ_DOCUMENTOFISCAL = objGrid_Valor(grdListagem, const_GridListagem_SQ_DOCUMENTOFISCAL)
        oForm.bCopiar = True

        FNC_AbriTela(oForm)
    End Sub

    Private Sub cmdDevolver_Click(sender As Object, e As EventArgs) Handles cmdDevolver.Click
        If objGrid_LinhaSelecionada(grdListagem) = -1 Then
            FNC_Mensagem("Selecione o documento fiscal a ser alterado")
            Exit Sub
        End If
        If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusDocumentoFiscal_DocumentoFiscalGerado.GetHashCode() Then
            FNC_Mensagem("Documento Fiscal já gerado")
            Exit Sub
        End If
        If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) = enOpcoes.StatusDocumentoFiscal_Cancelado.GetHashCode() Then
            FNC_Mensagem("Documento Fiscal já cancelado")
            Exit Sub
        End If

        Dim oForm As New frmCadastroDocumentoFiscal

        oForm.iSQ_DOCUMENTOFISCAL = objGrid_Valor(grdListagem, const_GridListagem_SQ_DOCUMENTOFISCAL)
        oForm.bDevolver = True

        FNC_AbriTela(oForm)
    End Sub
End Class