Imports Infragistics.Win

Public Class frmConsultaVendaPendente
  Const const_GridListagem_NR_ITEM As Integer = 0
  Const const_GridListagem_SQ_ITEM As Integer = 1
  Const const_GridListagem_SQ_PESSOA As Integer = 2
  Const const_GridListagem_ID_PESSOA_PROFISSIONAL As Integer = 3
  Const const_GridListagem_ID_CONVENIO As Integer = 4
  Const const_GridListagem_ID_PROCEDIMENTO As Integer = 5
  Const const_GridListagem_ID_OPT_STATUS As Integer = 6
  Const const_GridListagem_DH_ITEM As Integer = 7
  Const const_GridListagem_CD_GRUPO_ITEM As Integer = 8
  Const const_GridListagem_CD_ITEM As Integer = 9
  Const const_GridListagem_NO_PESSOA As Integer = 10
  Const const_GridListagem_NO_PESSOA_PROFISSIONAL As Integer = 11
  Const const_GridListagem_NO_CONVENIO As Integer = 12
  Const const_GridListagem_NO_PROCEDIMENTO As Integer = 13
  Const const_GridListagem_VL_ORCADO As Integer = 14

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmConsultaVendaPendente_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdVenda.Left = 5
    cmdVenda.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdExcel.Top = cmdVenda.Top
    cmdPDF.Top = cmdVenda.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdVenda.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub frmConsultaVendaPendente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    psqPessoa.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Pessoa_Fisica
    ComboBox_Carregar(cboConvenio, enSql.Convenio)
    ComboBox_Carregar(cboProfissionalPrestadorServico, enSql.Profissional)
    ComboBox_CarregarOrigemVenda(cboOrigem)

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "NR_ITEM", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_ITEM", 0)
    objGrid_Coluna_Add(grdListagem, "SQ_PESSOA", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PESSOA_PROFISSIONAL", 0)
    objGrid_Coluna_Add(grdListagem, "ID_CONVENIO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_PROCEDIMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "ID_OPT_STATUS", 0)
    objGrid_Coluna_Add(grdListagem, "Data de Lançamento", 115, , , , , const_Formato_DataHora)
    objGrid_Coluna_Add(grdListagem, "Origem", 90)
    objGrid_Coluna_Add(grdListagem, "Código", 110)
    objGrid_Coluna_Add(grdListagem, "Pessoa", 150)
    objGrid_Coluna_Add(grdListagem, "Profissional", 150)
    objGrid_Coluna_Add(grdListagem, "Convênio", 150)
    objGrid_Coluna_Add(grdListagem, "Procedimento", 150)
    objGrid_Coluna_Add(grdListagem, "Vlr. Orçado", 100, , , , , const_Formato_Valor)

    txtDataValidadeInicial.Value = Nothing
    txtDataValidadeFinal.Value = Nothing

    cmdVenda.Enabled = FNC_Permissao(enPermissao.VEND_ConsultadeVendaPendentes).bIncluir
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""

    sSqlText = "Select " & enOrigemVenda.OrcamentoClinica.GetHashCode() & " NR_ITEM," &
                          "OCCLI.SQ_ORCAMENTO_CLIENTE SQ_ITEM," &
                          "PESSO.SQ_PESSOA," &
                          "PESSO_PROFI.SQ_PESSOA ID_PESSOA_PROFISSIONAL," &
                          "OCCLI.ID_CONVENIO," &
                          "OCPRC.ID_PROCEDIMENTO," &
                          "OCCLI.ID_OPT_STATUS," &
                          "OCCLI.DH_ORCAMENTO_CLIENTE DH_ITEM," &
                          "'Orçamento Clínica' CD_GRUPO_ITEM," &
                          "OCCLI.CD_ORCAMENTO_CLIENTE CD_ITEM," &
                          "PESSO.NO_PESSOA," &
                          "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                          "CONVE.NO_CONVENIO," &
                          "PROCE.NO_PROCEDIMENTO," &
                          "OCPRC.VL_ORCADO" &
                   " FROM TB_ORCAMENTO_CLIENTE OCCLI" &
                    " INNER JOIN TB_ORCAMENTO_CLIENTE_PROCEDIMENTO	OCPRC ON OCPRC.ID_ORCAMENTO_CLIENTE = OCCLI.SQ_ORCAMENTO_CLIENTE" &
                    " INNER JOIN TB_PROCEDIMENTO	PROCE ON PROCE.SQ_PROCEDIMENTO = OCPRC.ID_PROCEDIMENTO" &
                    " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = OCCLI.ID_CONVENIO" &
                    " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = OCCLI.ID_PESSOA" &
                    " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = OCPRC.ID_PESSOA_PROFISSIONAL" &
                   " WHERE OCCLI.ID_OPT_STATUS IN (" & enOpcoes.StatusOrcamentoClinica_Cadastrado.GetHashCode() & "," &
                                                       enOpcoes.StatusOrcamentoClinica_EmAberto.GetHashCode() & ")" &
                   " UNION " &
                   "SELECT " & enOrigemVenda.Agendamento.GetHashCode() & "," &
                          "AGEND.SQ_AGENDAMENTO," &
                          "PESSO.SQ_PESSOA," &
                          "PESSO_PROFI.SQ_PESSOA ID_PESSOA_PROFISSIONAL," &
                          "AGEND.ID_CONVENIO," &
                          "AGEND.ID_PROCEDIMENTO," &
                          "AGEND.ID_OPT_STATUS," &
                          "AGEND.DH_AGENDAMENTO," &
                          "'Agendamento' CD_GRUPO_ITEM," &
                          "AGEND.CD_AGENDAMENTO," &
                          "PESSO.NO_PESSOA," &
                          "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                          "CONVE.NO_CONVENIO," &
                          "PROCE.NO_PROCEDIMENTO," &
                          "CVPCD.VL_PROCEDIMENTO" &
                   " FROM TB_AGENDAMENTO AGEND" &
                    " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                    " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO" &
                    " INNER JOIN TB_CONVENIO_PROCEDIMENTO	CVPCD ON CVPCD.ID_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                                                             " AND CVPCD.ID_CONVENIO = AGEND.ID_CONVENIO" &
                                                             " AND CVPCD.ID_PESSOA_PROFISSIONAL = AGEND.ID_PESSOA_PROFISSIONAL" &
                    " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = AGEND.ID_PESSOA" &
                    " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                   " WHERE AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode()

    If psqPessoa.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, " SQ_PESSOA = " & psqPessoa.ID_Pessoa, " AND ")
    End If
    If ComboBox_Selecionado(cboProfissionalPrestadorServico) Then
      FNC_Str_Adicionar(sSqlText_Where, " ID_PESSOA_PROFISSIONAL = " & cboProfissionalPrestadorServico.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboConvenio) Then
      FNC_Str_Adicionar(sSqlText_Where, " ID_CONVENIO = " & cboConvenio.SelectedValue, " AND ")
    End If
    If psqProcedimento.Identificador > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, " ID_PROCEDIMENTO = " & psqProcedimento.Identificador, " AND ")
    End If
    If ComboBox_Selecionado(cboOrigem) Then
      FNC_Str_Adicionar(sSqlText_Where, " NR_ITEM = " & cboOrigem.SelectedValue, " AND ")
    End If
    If IsDate(txtDataValidadeInicial.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(DH_ITEM AS DATE) >= " & FNC_QuotedStr(txtDataValidadeInicial.Text), " AND ")
    End If
    If IsDate(txtDataValidadeFinal.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, " CAST(DH_ITEM AS DATE) <= " & FNC_QuotedStr(txtDataValidadeFinal.Text), " AND ")
    End If

    sSqlText = "SELECT * FROM (" & sSqlText & ") X"

    If sSqlText_Where <> "" Then
      sSqlText = sSqlText & " WHERE " & sSqlText_Where
    End If

    sSqlText = sSqlText & " ORDER BY NR_ITEM, CD_ITEM"

    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_NR_ITEM,
                                                           const_GridListagem_SQ_ITEM,
                                                           const_GridListagem_SQ_PESSOA,
                                                           const_GridListagem_ID_PESSOA_PROFISSIONAL,
                                                           const_GridListagem_ID_CONVENIO,
                                                           const_GridListagem_ID_PROCEDIMENTO,
                                                           const_GridListagem_ID_OPT_STATUS,
                                                           const_GridListagem_DH_ITEM,
                                                           const_GridListagem_CD_GRUPO_ITEM,
                                                           const_GridListagem_CD_ITEM,
                                                           const_GridListagem_NO_PESSOA,
                                                           const_GridListagem_NO_PESSOA_PROFISSIONAL,
                                                           const_GridListagem_NO_CONVENIO,
                                                           const_GridListagem_NO_PROCEDIMENTO,
                                                           const_GridListagem_VL_ORCADO})
  End Sub

  Private Sub cmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    psqPessoa.ID_Pessoa = 0
    psqProcedimento.Identificador = 0
    cboConvenio.SelectedIndex = -1
    cboOrigem.SelectedIndex = -1
    cboProfissionalPrestadorServico.SelectedIndex = -1
    txtDataValidadeInicial.Value = Nothing
    txtDataValidadeFinal.Value = Nothing
  End Sub

  Private Sub cmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdVenda_Click(sender As Object, e As EventArgs) Handles cmdVenda.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar um registro para o qual deseja gerar uma venda")
      Exit Sub
    End If

    Dim sSqlText As String

    Select Case objGrid_Valor(grdListagem, const_GridListagem_SQ_ITEM)
      Case enOrigemVenda.Agendamento.GetHashCode()
        If objGrid_Valor(grdListagem, const_GridListagem_ID_OPT_STATUS) <> enOpcoes.StatusAgendamento_AguardandoPagamento.GetHashCode() Then
          FNC_Mensagem("É necessário selecionar um agendamento com o status 'Aguardando Pagamento' para gerar uma venda")
          Exit Sub
        End If
      Case enOrigemVenda.OrcamentoClinica.GetHashCode()
        sSqlText = "SELECT COUNT(*) FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO" &
                            " WHERE ID_OPT_STATUS = " & enOpcoes.StatusItemOrcamentoClinica_Cadastrado &
                              " AND ID_ORCAMENTO_CLIENTE = " & objGrid_Valor(grdListagem, const_GridListagem_SQ_ITEM)

        If DBQuery_ValorUnico(sSqlText, 0) = 0 Then
          FNC_Mensagem("É necessário selecionar um orçamento com o itens pendentes para venda para gerar uma venda")
          Exit Sub
        End If
    End Select

    Dim oForm As New frmCadastroVenda

    oForm.iID_PESSOA = objGrid_Valor(grdListagem, const_GridListagem_SQ_PESSOA)

    Select Case objGrid_Valor(grdListagem, const_GridListagem_NR_ITEM)
      Case enOrigemVenda.Agendamento.GetHashCode()
        oForm.oID_AGENDAMENTO = New Collection
        oForm.oID_AGENDAMENTO.Add(objGrid_Valor(grdListagem, const_GridListagem_SQ_ITEM))
      Case enOrigemVenda.OrcamentoClinica.GetHashCode()
        oForm.iID_ORCAMENTO_CLIENTE = objGrid_Valor(grdListagem, const_GridListagem_SQ_ITEM)
    End Select

    AddHandler oForm.GravacaoEfetuada, AddressOf Pesquisar

    FNC_AbriTela(oForm, , True, True)
  End Sub
End Class