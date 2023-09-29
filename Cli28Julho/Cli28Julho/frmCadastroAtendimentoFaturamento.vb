﻿Imports Cli28Julho.modDeclaracaoLocal

Public Class frmCadastroAtendimentoFaturamento
  Dim oItens_Pendentes() As cCadastroAtendimentoFaturamento_Item
  Dim oItens_Faturar() As cCadastroAtendimentoFaturamento_Item

  Dim iSQ_MOVFINANCEIRA As Integer

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_Faturamento))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub frmCadastroAtendimentoFaturamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdListar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Listar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    cmdFaturar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Faturar)

    ComboBox_Carregar(cboMedicoPrestador, enSql.Profissional_PendenteRepasse)

    vsbPendentes.SmallChange = 1
    vsbPendentes.LargeChange = 1
    vsbFaturar.SmallChange = 1
    vsbFaturar.LargeChange = 1

    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing

    LimparPendentes()
    LimparFaturar(True)

    cmdSelecionar01.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdSelecionar02.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdSelecionar03.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdSelecionar04.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdSelecionar05.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdSelecionar06.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdRemover01.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdRemover02.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdRemover03.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdRemover04.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdRemover05.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir
    cmdRemover06.Enabled = FNC_Permissao(enPermissao.FINA_FaturamentodeVendas).bIncluir

    vsbPendentes.Enabled = False
    vsbFaturar.Enabled = False
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdListar_Clicado(sender As Object) Handles cmdListar.Clicado
    CarregarDados()
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String = ""
    Dim iCont As Integer = 0
    Dim IC_PROFISSIONAL_SERVICO_INTERNO As Boolean

    iSQ_MOVFINANCEIRA = 0

    If Not ComboBox_Selecionado(cboMedicoPrestador) Then
      FNC_Mensagem("Selecione o Médico/Prestador")
      Exit Sub
    End If

    sSqlText = "SELECT COUNT(*) FROM TB_PESSOA_EMPRESA" &
               " WHERE ID_PESSOA = " & cboMedicoPrestador.SelectedValue &
                 " AND ISNULL(IC_PROFISSIONAL_SERVICO_INTERNO, 'N') = 'S'"
    IC_PROFISSIONAL_SERVICO_INTERNO = (Val(DBQuery_ValorUnico(sSqlText)) > 0)

    txtCodAutorizacao.Text = ""
    txtCodAutorizacao.Select()

    LimparPendentes()
    LimparFaturar(True)

    '"MVFNP.DT_VENCIMENTO," &
    sSqlText = "SELECT DISTINCT CVPRC.SQ_CLINICA_VENDA_PROCEDIMENTO," &
                               "ISNULL(AGEND.CD_AGENDAMENTO, CLVND.CD_CLINICA_VENDA) CD_CLINICA_VENDA,"

    If IC_PROFISSIONAL_SERVICO_INTERNO Then
      sSqlText = sSqlText & "CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) DT_VENCIMENTO,"
    Else
      sSqlText = sSqlText & "CAST(MVFNP.DT_VENCIMENTO AS DATE) DT_VENCIMENTO,"
    End If

    sSqlText = sSqlText &
                               "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                               "PESSO.NO_PESSOA," &
                               "PROCE.NO_PROCEDIMENTO," &
                               "CVPRC.VL_PROCEDIMENTO," &
                               "CVPRC.VL_REPASSE" &
               " FROM TB_MOVFINANCEIRA MVFNC (NOLOCK)" &
                " INNER JOIN VW_MOVFINANCEIRAPARCELA MVFNP (NOLOCK) ON MVFNP.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVPRC (NOLOCK) ON CVPRC.ID_MOVFINANCEIRA = MVFNC.SQ_MOVFINANCEIRA" &
                 " LEFT JOIN TB_AGENDAMENTO AGEND (NOLOCK) ON (AGEND.SQ_AGENDAMENTO = CVPRC.ID_AGENDAMENTO OR AGEND.ID_CLINICA_VENDA_PROCEDIMENTO = CVPRC.SQ_CLINICA_VENDA_PROCEDIMENTO)" &
                 " LEFT JOIN TB_CLINICA_ATENDIMENTO CLATD (NOLOCK) ON CLATD.ID_AGENDAMENTO = AGEND.SQ_AGENDAMENTO" &
                "	INNER JOIN TB_PROCEDIMENTO PROCE (NOLOCK) ON PROCE.SQ_PROCEDIMENTO = CVPRC.ID_PROCEDIMENTO" &
                " INNER JOIN TB_CLINICA_VENDA CLVND (NOLOCK) ON CLVND.SQ_CLINICA_VENDA = CVPRC.ID_CLINICA_VENDA" &
                "	INNER JOIN TB_PESSOA PESSO (NOLOCK) ON PESSO.SQ_PESSOA = CLVND.ID_PESSOA" &
                "	INNER JOIN TB_PESSOA PESSO_PROFI (NOLOCK) ON PESSO_PROFI.SQ_PESSOA = MVFNC.ID_PESSOA" &
                " INNER JOIN TB_PESSOA_EMPRESA PSEMP (NOLOCK) ON PSEMP.ID_PESSOA = PESSO_PROFI.SQ_PESSOA" &
               " WHERE MVFNC.ID_OPT_TIPOMOVFINANCEIRA = " & enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode() &
                 " AND MVFNC.ID_PESSOA = " & cboMedicoPrestador.SelectedValue &
                                                                 " AND MVFNP.VL_DEBITO > 0" &
                                                                 " AND MVFNP.ID_MOVFINANCEIRAGERADA IS NULL" &
                                                          " AND CLVND.DH_CANCELAR IS NULL" &
                                                                       " AND CVPRC.ID_CLINICA_VENDA_DEVOLUCAO IS NULL"

    If IC_PROFISSIONAL_SERVICO_INTERNO Then
      sSqlText = sSqlText &
                 " AND AGEND.ID_OPT_STATUS = " & enOpcoes.StatusAgendamento_Atendido.GetHashCode()

      If IsDate(txtDataInicial.Text) Then
        sSqlText = sSqlText &
                 " AND CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text)
      End If
      If IsDate(txtDataFinal.Text) Then
        sSqlText = sSqlText &
                 " AND CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text)
      End If
    Else
      If IsDate(txtDataInicial.Text) Then
        sSqlText = sSqlText &
                 " AND CAST(MVFNP.DT_VENCIMENTO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text)
      End If
      If IsDate(txtDataFinal.Text) Then
        sSqlText = sSqlText &
                 " AND CAST(MVFNP.DT_VENCIMENTO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text)
      End If
    End If

    If psqPessoa.ID_Pessoa > 0 Then
      sSqlText = sSqlText &
                 " AND PESSO.SQ_PESSOA = " & psqPessoa.ID_Pessoa
    End If

    If IC_PROFISSIONAL_SERVICO_INTERNO Then
      sSqlText = sSqlText &
                 " ORDER BY CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE)"
    Else
      sSqlText = sSqlText &
                 " ORDER BY CAST(MVFNP.DT_VENCIMENTO AS DATE)"
    End If
    oData = DBQuery(sSqlText)

    ReDim oItens_Pendentes(oData.Rows.Count - 1)

    For Each oRow As DataRow In oData.Rows
      oItens_Pendentes(iCont) = New cCadastroAtendimentoFaturamento_Item
      oItens_Pendentes(iCont).SQ_CLINICA_VENDA_PROCEDIMENTO = oRow.Item("SQ_CLINICA_VENDA_PROCEDIMENTO")
      oItens_Pendentes(iCont).CD_CLINICA_VENDA = oRow.Item("CD_CLINICA_VENDA").ToString()
      If IsDate(oRow.Item("DT_VENCIMENTO")) Then oItens_Pendentes(iCont).DT_VENCIMENTO = oRow.Item("DT_VENCIMENTO")
      oItens_Pendentes(iCont).NO_PESSOA_PROFISSIONAL = oRow.Item("NO_PESSOA_PROFISSIONAL")
      oItens_Pendentes(iCont).NO_PESSOA = oRow.Item("NO_PESSOA")
      oItens_Pendentes(iCont).NO_PROCEDIMENTO = oRow.Item("NO_PROCEDIMENTO")
      oItens_Pendentes(iCont).VL_PROCEDIMENTO = oRow.Item("VL_PROCEDIMENTO")
      oItens_Pendentes(iCont).VL_REPASSE = oRow.Item("VL_REPASSE")

      iCont = iCont + 1
    Next

    vsbPendentes.Enabled = (oItens_Pendentes.Length > 6)
    If oItens_Pendentes.Length - 6 > 0 Then vsbPendentes.Maximum = oItens_Pendentes.Length - 5

    vsbPendentes.Value = 1
    vsbFaturar.Value = 1

    ListarPendentes()

    oItens_Faturar = Nothing
  End Sub

  Private Function Itens_Pendentes_Carregado() As Boolean
    If oItens_Pendentes Is Nothing Then
      Return False
    Else
      Return (oItens_Pendentes.Count > 0)
    End If
  End Function

  Private Function Itens_Faturar_Carregado() As Boolean
    If oItens_Faturar Is Nothing Then
      Return False
    Else
      Return (oItens_Faturar.Count > 0)
    End If
  End Function

  Private Sub ListarPendentes()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    LimparPendentes()

    If Itens_Pendentes_Carregado() Then
      For iCont = vsbPendentes.Value - 1 To vsbPendentes.Value + 4
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblPCodAutorizacao" + FNC_StrZero(iLabel, 2))).Text = oItens_Pendentes(iCont).CD_CLINICA_VENDA
          Me.Controls(Me.Controls.IndexOfKey("lblPCodAutorizacao" + FNC_StrZero(iLabel, 2))).Tag = oItens_Pendentes(iCont).SQ_CLINICA_VENDA_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblPData" + FNC_StrZero(iLabel, 2))).Text = oItens_Pendentes(iCont).DT_VENCIMENTO.ToString().Substring(0, 16)
          Me.Controls(Me.Controls.IndexOfKey("lblPMedicoPrestador" + FNC_StrZero(iLabel, 2))).Text = oItens_Pendentes(iCont).NO_PESSOA_PROFISSIONAL
          Me.Controls(Me.Controls.IndexOfKey("lblPPaciente" + FNC_StrZero(iLabel, 2))).Text = oItens_Pendentes(iCont).NO_PESSOA
          Me.Controls(Me.Controls.IndexOfKey("lblPTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = oItens_Pendentes(iCont).NO_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblPValor" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oItens_Pendentes(iCont).VL_PROCEDIMENTO)
          Me.Controls(Me.Controls.IndexOfKey("lblPVlPrestador" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oItens_Pendentes(iCont).VL_REPASSE)
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblPCodAutorizacao" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPData" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPMedicoPrestador" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPPaciente" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPValor" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPVlPrestador" + FNC_StrZero(iLabel, 2))).Text = ""
        End Try

        iLabel = iLabel + 1
      Next
    End If

    CarcularItemPendentes()
  End Sub

  Private Sub ListarFaturar()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    LimparFaturar(False)

    If Itens_Faturar_Carregado() Then
      For iCont = vsbFaturar.Value - 1 To vsbFaturar.Value + 4
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblFCodAutorizacao" + FNC_StrZero(iLabel, 2))).Text = oItens_Faturar(iCont).CD_CLINICA_VENDA
          Me.Controls(Me.Controls.IndexOfKey("lblFCodAutorizacao" + FNC_StrZero(iLabel, 2))).Tag = oItens_Faturar(iCont).SQ_CLINICA_VENDA_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblFData" + FNC_StrZero(iLabel, 2))).Text = oItens_Faturar(iCont).DT_VENCIMENTO.ToString().Substring(0, 16)
          Me.Controls(Me.Controls.IndexOfKey("lblFMedicoPrestador" + FNC_StrZero(iLabel, 2))).Text = oItens_Faturar(iCont).NO_PESSOA_PROFISSIONAL
          Me.Controls(Me.Controls.IndexOfKey("lblFPaciente" + FNC_StrZero(iLabel, 2))).Text = oItens_Faturar(iCont).NO_PESSOA
          Me.Controls(Me.Controls.IndexOfKey("lblFTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = oItens_Faturar(iCont).NO_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblFValor" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oItens_Faturar(iCont).VL_PROCEDIMENTO)
          Me.Controls(Me.Controls.IndexOfKey("lblFVlPrestador" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oItens_Faturar(iCont).VL_REPASSE)
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblFCodAutorizacao" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblFData" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblFMedicoPrestador" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblFPaciente" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblFTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblFValor" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblFVlPrestador" + FNC_StrZero(iLabel, 2))).Text = ""
        End Try

        iLabel = iLabel + 1
      Next
    End If

    CarcularItemFaturar()
  End Sub

  Private Sub LimparPendentes()
    For iCont = 1 To 6
      Me.Controls(Me.Controls.IndexOfKey("lblPCodAutorizacao" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPData" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPMedicoPrestador" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPPaciente" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPTipoAtendimento" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPValor" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPVlPrestador" + FNC_StrZero(iCont, 2))).Text = ""
    Next

    lblPQdte.Text = ""
    lblPValorTotal.Text = FormatCurrency(0)
    lblPValorTotal.Tag = 0
    lblPVlPrestTotal.Text = FormatCurrency(0)
    lblPVlPrestTotal.Tag = 0
  End Sub

  Private Sub LimparFaturar(bDesabilitarvsb As Boolean)
    For iCont = 1 To 6
      Me.Controls(Me.Controls.IndexOfKey("lblFCodAutorizacao" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblFData" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblFMedicoPrestador" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblFPaciente" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblFTipoAtendimento" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblFValor" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblFVlPrestador" + FNC_StrZero(iCont, 2))).Text = ""
    Next

    lblFQdte.Text = ""
    lblFValorTotal.Text = FormatCurrency(0)
    lblFValorTotal.Tag = 0
    lblFVlPrestTotal.Text = FormatCurrency(0)
    lblFVlPrestTotal.Tag = 0

    If bDesabilitarvsb Then vsbFaturar.Enabled = False
  End Sub

  Private Sub vsbPendentes_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbPendentes.Scroll
    ListarPendentes()
  End Sub

  Private Sub cmdSelecionar01_Click(sender As Object, e As EventArgs) Handles cmdSelecionar01.Click, cmdSelecionar02.Click, cmdSelecionar03.Click,
                                                                              cmdSelecionar04.Click, cmdSelecionar05.Click, cmdSelecionar06.Click
    Dim oButton As Button
    Dim oLabel As Label

    oButton = sender
    oLabel = Me.Controls("lblPCodAutorizacao" + oButton.Name.Substring(13, 2))

    iSQ_MOVFINANCEIRA = 0

    MoverItem(oLabel.Tag)
  End Sub

  Private Sub MoverItem(iSQ_CLINICA_VENDA_PROCEDIMENTO As Integer)
    Dim oItens_PendentesUtil(oItens_Pendentes.Count - 2) As cCadastroAtendimentoFaturamento_Item
    Dim iCont As Integer
    Dim iIndice As Integer = 0

    For iCont = 0 To oItens_Pendentes.Count - 1
      If oItens_Pendentes(iCont).SQ_CLINICA_VENDA_PROCEDIMENTO = iSQ_CLINICA_VENDA_PROCEDIMENTO Then
        If oItens_Faturar Is Nothing Then
          ReDim oItens_Faturar(0)
        Else
          ReDim Preserve oItens_Faturar(oItens_Faturar.Length)
        End If

        oItens_Faturar(oItens_Faturar.Length - 1) = New cCadastroAtendimentoFaturamento_Item
        oItens_Faturar(oItens_Faturar.Length - 1).SQ_CLINICA_VENDA_PROCEDIMENTO = oItens_Pendentes(iCont).SQ_CLINICA_VENDA_PROCEDIMENTO
        oItens_Faturar(oItens_Faturar.Length - 1).CD_CLINICA_VENDA = oItens_Pendentes(iCont).CD_CLINICA_VENDA
        oItens_Faturar(oItens_Faturar.Length - 1).DT_VENCIMENTO = oItens_Pendentes(iCont).DT_VENCIMENTO
        oItens_Faturar(oItens_Faturar.Length - 1).NO_PESSOA_PROFISSIONAL = oItens_Pendentes(iCont).NO_PESSOA_PROFISSIONAL
        oItens_Faturar(oItens_Faturar.Length - 1).NO_PESSOA = oItens_Pendentes(iCont).NO_PESSOA
        oItens_Faturar(oItens_Faturar.Length - 1).NO_PROCEDIMENTO = oItens_Pendentes(iCont).NO_PROCEDIMENTO
        oItens_Faturar(oItens_Faturar.Length - 1).VL_PROCEDIMENTO = oItens_Pendentes(iCont).VL_PROCEDIMENTO
        oItens_Faturar(oItens_Faturar.Length - 1).VL_REPASSE = oItens_Pendentes(iCont).VL_REPASSE
      Else
        oItens_PendentesUtil(iIndice) = oItens_Pendentes(iCont)
        iIndice = iIndice + 1
      End If
    Next

    oItens_Pendentes = oItens_PendentesUtil

    vsbPendentes.Enabled = (oItens_Pendentes.Length > 6)
    If oItens_Pendentes.Length - 6 > 0 Then vsbPendentes.Maximum = oItens_Pendentes.Length - 5

    vsbFaturar.Enabled = (oItens_Faturar.Length > 6)
    If oItens_Faturar.Length - 6 > 0 Then vsbFaturar.Maximum = oItens_Faturar.Length - 5

    ListarPendentes()
    ListarFaturar()
  End Sub

  Private Sub cmdRemover01_Click(sender As Object, e As EventArgs) Handles cmdRemover01.Click, cmdRemover02.Click, cmdRemover03.Click,
                                                                           cmdRemover04.Click, cmdRemover05.Click, cmdRemover06.Click
    Dim oButton As Button
    Dim oLabel As Label

    oButton = sender
    oLabel = Me.Controls("lblFCodAutorizacao" + oButton.Name.Substring(10, 2))

    ExcluirItem(oLabel.Tag)
  End Sub

  Private Sub ExcluirItem(iSQ_CLINICA_VENDA_PROCEDIMENTO As Integer)
    Dim oItensUtil(oItens_Faturar.Count - 2) As cCadastroAtendimentoFaturamento_Item
    Dim iCont As Integer
    Dim iIndice As Integer = 0

    For iCont = 0 To oItens_Faturar.Count - 1
      If oItens_Faturar(iCont).SQ_CLINICA_VENDA_PROCEDIMENTO = iSQ_CLINICA_VENDA_PROCEDIMENTO Then
        If oItens_Pendentes Is Nothing Then
          ReDim oItens_Pendentes(0)
        Else
          ReDim Preserve oItens_Pendentes(oItens_Pendentes.Length)
        End If

        oItens_Pendentes(oItens_Pendentes.Length - 1) = New cCadastroAtendimentoFaturamento_Item
        oItens_Pendentes(oItens_Pendentes.Length - 1).SQ_CLINICA_VENDA_PROCEDIMENTO = oItens_Faturar(iCont).SQ_CLINICA_VENDA_PROCEDIMENTO
        oItens_Pendentes(oItens_Pendentes.Length - 1).CD_CLINICA_VENDA = oItens_Faturar(iCont).CD_CLINICA_VENDA
        oItens_Pendentes(oItens_Pendentes.Length - 1).DT_VENCIMENTO = oItens_Faturar(iCont).DT_VENCIMENTO
        oItens_Pendentes(oItens_Pendentes.Length - 1).NO_PESSOA_PROFISSIONAL = oItens_Faturar(iCont).NO_PESSOA_PROFISSIONAL
        oItens_Pendentes(oItens_Pendentes.Length - 1).NO_PESSOA = oItens_Faturar(iCont).NO_PESSOA
        oItens_Pendentes(oItens_Pendentes.Length - 1).NO_PROCEDIMENTO = oItens_Faturar(iCont).NO_PROCEDIMENTO
        oItens_Pendentes(oItens_Pendentes.Length - 1).VL_PROCEDIMENTO = oItens_Faturar(iCont).VL_PROCEDIMENTO
        oItens_Pendentes(oItens_Pendentes.Length - 1).VL_REPASSE = oItens_Faturar(iCont).VL_REPASSE
      Else
        oItensUtil(iIndice) = oItens_Faturar(iCont)
        iIndice = iIndice + 1
      End If
    Next

    oItens_Faturar = oItensUtil

    vsbPendentes.Enabled = (oItens_Pendentes.Length > 6)
    If oItens_Pendentes.Length - 6 > 0 Then vsbPendentes.Maximum = oItens_Pendentes.Length - 6

    vsbFaturar.Enabled = (oItens_Faturar.Length > 6)
    If oItens_Faturar.Length - 6 > 0 Then vsbFaturar.Maximum = oItens_Faturar.Length - 6

    ListarPendentes()
    ListarFaturar()
  End Sub

  Private Sub CarcularItemPendentes()
    Dim dVL_PROCEDIMENTO As Double = 0
    Dim dVL_REPASSE As Double = 0

    lblPQdte.Text = ""
    lblPValorTotal.Text = FormatCurrency(0)
    lblPValorTotal.Tag = 0
    lblPVlPrestTotal.Text = FormatCurrency(0)
    lblPVlPrestTotal.Tag = 0

    If Not oItens_Pendentes Is Nothing Then
      For Each oItem As cCadastroAtendimentoFaturamento_Item In oItens_Pendentes
        dVL_PROCEDIMENTO = dVL_PROCEDIMENTO + oItem.VL_PROCEDIMENTO
        dVL_REPASSE = dVL_REPASSE + oItem.VL_REPASSE
      Next

      lblPQdte.Text = oItens_Pendentes.Length
      lblPValorTotal.Text = FormatCurrency(dVL_PROCEDIMENTO)
      lblPValorTotal.Tag = dVL_PROCEDIMENTO
      lblPVlPrestTotal.Text = FormatCurrency(dVL_REPASSE)
      lblPVlPrestTotal.Tag = dVL_REPASSE
    End If
  End Sub

  Private Sub CarcularItemFaturar()
    Dim dVL_PROCEDIMENTO As Double = 0
    Dim dVL_REPASSE As Double = 0

    lblFQdte.Text = ""
    lblFValorTotal.Text = FormatCurrency(0)
    lblFValorTotal.Tag = 0
    lblFVlPrestTotal.Text = FormatCurrency(0)
    lblFVlPrestTotal.Tag = 0

    If Not oItens_Faturar Is Nothing Then
      For Each oItem As cCadastroAtendimentoFaturamento_Item In oItens_Faturar

        dVL_PROCEDIMENTO = dVL_PROCEDIMENTO + oItem.VL_PROCEDIMENTO
        dVL_REPASSE = dVL_REPASSE + oItem.VL_REPASSE
      Next

      lblFQdte.Text = oItens_Faturar.Length
      lblFValorTotal.Text = FormatCurrency(dVL_PROCEDIMENTO)
      lblFValorTotal.Tag = dVL_PROCEDIMENTO
      lblFVlPrestTotal.Text = FormatCurrency(dVL_REPASSE)
      lblFVlPrestTotal.Tag = dVL_REPASSE
    End If
  End Sub

  Private Sub cmdFaturar_Clicado(sender As Object) Handles cmdFaturar.Clicado
    If Val(lblFQdte.Text) = 0 Then
      FNC_Mensagem("É preciso selecionar as vendas que serão faturadas para médicos/prestador")
      Exit Sub
    End If
    If oItens_Faturar Is Nothing Then
      FNC_Mensagem("É preciso selecionar as vendas que serão faturadas para médicos/prestador")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboMedicoPrestador) Then
      FNC_Mensagem("Selecione o Médico/Prestador de serviços")
      Exit Sub
    End If

    Dim oForm As New frmLancaContasReceberPagar

    oForm.oCadastroAtendimentoFaturamento_Item = oItens_Faturar
    oForm.iID_PESSOA = cboMedicoPrestador.SelectedValue
    oForm.dValorOriginal = lblFVlPrestTotal.Tag

    AddHandler oForm.RegerarConsulta, AddressOf CarregarDados

    FNC_AbriTela(oForm, , True, True)

    iSQ_MOVFINANCEIRA = oForm.iSQ_MOVFINANCEIRA
  End Sub

  Private Sub cmdTodasPendentes_Click(sender As Object, e As EventArgs) Handles cmdTodasPendentes.Click
    For Each oItem As cCadastroAtendimentoFaturamento_Item In oItens_Pendentes
      MoverItem(oItem.SQ_CLINICA_VENDA_PROCEDIMENTO)
    Next
  End Sub

  Private Sub cmdTodosRemover_Click(sender As Object, e As EventArgs) Handles cmdTodosRemover.Click
    For Each oItem As cCadastroAtendimentoFaturamento_Item In oItens_Faturar
      ExcluirItem(oItem.SQ_CLINICA_VENDA_PROCEDIMENTO)
    Next
  End Sub

  Private Sub lblPCodAutorizacao_DoubleClick(sender As Object, e As EventArgs) Handles lblPCodAutorizacao01.DoubleClick, lblPCodAutorizacao02.DoubleClick,
                                                                                       lblPCodAutorizacao03.DoubleClick, lblPCodAutorizacao04.DoubleClick,
                                                                                       lblPCodAutorizacao05.DoubleClick, lblPCodAutorizacao06.DoubleClick
    Dim oLabel As Label
    Dim sCodigo As String

    oLabel = sender
    sCodigo = oLabel.Text

    For Each oItem As cCadastroAtendimentoFaturamento_Item In oItens_Pendentes
      If sCodigo = oItem.CD_CLINICA_VENDA Then
        MoverItem(oItem.SQ_CLINICA_VENDA_PROCEDIMENTO)
      End If
    Next
  End Sub

  Private Sub txtCodAutorizacao_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodAutorizacao.KeyDown
    If Not ComboBox_Selecionado(cboMedicoPrestador) Then
      FNC_Mensagem("Selecione o médico/fornecedor antes")

      txtCodAutorizacao.Text = ""
      txtCodAutorizacao.Select()
    Else
      Dim bAchou As Boolean = False

      If e.KeyCode = Keys.Enter Then
        For Each oItem As cCadastroAtendimentoFaturamento_Item In oItens_Pendentes
          If oItem.CD_CLINICA_VENDA.Trim().ToUpper() = txtCodAutorizacao.Text.Trim().ToUpper() Then
            MoverItem(oItem.SQ_CLINICA_VENDA_PROCEDIMENTO)
            bAchou = True
          End If
        Next

        If Not bAchou Then
          FNC_Mensagem("Fatura não existe ou não pertence a esse fornecedor")
        End If

        txtCodAutorizacao.Text = ""
        txtCodAutorizacao.Select()
      End If
    End If
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    If iSQ_MOVFINANCEIRA = 0 Then
      FNC_Mensagem("É preciso selecionar os atendimentos realizados e depois faturar, antes de imprimir")
      Exit Sub
    End If

    FormRelatorioMedicoFaturamento(iSQ_MOVFINANCEIRA)
  End Sub

  Private Sub vsbFaturar_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbFaturar.Scroll
    ListarFaturar()
  End Sub
End Class