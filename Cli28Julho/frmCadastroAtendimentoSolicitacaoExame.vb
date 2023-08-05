Public Class frmCadastroAtendimentoSolicitacaoExame
  Class cExame
    Public SQ_PROCEDIMENTO As Integer
    Public ID_OPT_TIPOEXAME As Integer
    Public DS_PROCEDIMENTO As String
    Public CM_PROCEDIMENTO As String
  End Class

  Public iID_CLINICA_ATENDIMENTO As Integer
  Public bEditar As Boolean

  Dim oExame() As cExame
  Dim oExameDB() As cExame
  Dim oExameEscolhido() As cExame
  Dim eOPT_TIPOEXAME As enOpcoes
  Dim iExameExcluir() As Integer
  Dim iID_ESPECIALIDADE As Integer
  Dim bEmpProcessamento As Boolean

  Private Sub frmCadastroAtendimentoSolicitacaoExame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_SolicitarExames_Fechar)
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_SolicitarExames_Imprimir)
    cmdImprimirSelecionados.Formatar(enOpcoes.ConfiguracaoTela_Botao_SolicitarExames_ImprimirSelecionados)
    cmdVisualizar.Formatar(enOpcoes.ConfiguracaoTela_Botao_SolicitarExames_Visualizar)

    ComboBox_Carregar(cboClassificacaoExame, enSql.ClassificacaoExame)

    lblProntuario.Text = ""
    lblIdade.Text = ""

    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = "SELECT PESSO.SQ_PESSOA," &
                      "PESSO.NO_PESSOA," &
                      "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, getdate(), 'S') DS_NASC_ABERTURA" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                 " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
               " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO.ToString()
    oData = DBQuery(sSqlText)

    lblProntuario.Text = oData.Rows(0).Item("SQ_PESSOA")
    lblPessoa.Text = oData.Rows(0).Item("NO_PESSOA")
    lblIdade.Text = oData.Rows(0).Item("DS_NASC_ABERTURA")

    oData.Dispose()

    For iCont = 1 To 10
      Me.Controls(Me.Controls.IndexOfKey("lblExameEscolhido" + FNC_StrZero(iCont, 2))).Text = ""
    Next

    sSqlText = "SELECT AGEND.ID_ESPECIALIDADE" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
               " WHERE CLATD.SQ_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
    iID_ESPECIALIDADE = DBQuery_ValorUnicoInt(sSqlText, 0)

    CarregarExamesSelecionados()
    LimparExames()

    vsbExame.SmallChange = 1
    vsbExame.LargeChange = 1
    vsbExame.Value = 1
    vsbExame.Minimum = 1
    vsbExameEscolhido.SmallChange = 1
    vsbExameEscolhido.LargeChange = 1
    vsbExameEscolhido.Value = 1
    vsbExameEscolhido.Minimum = 1

    CarregarExames()
  End Sub

  Private Sub LimparExames()
    For iCont = 1 To 10
      Me.Controls(Me.Controls.IndexOfKey("lblExame" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblExame" + FNC_StrZero(iCont, 2))).Tag = Nothing
    Next
  End Sub

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_SolicitacaExames_TelaMaximizada))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub CarregarExamesSelecionados()
    Dim oData As DataTable
    Dim sSqlText As String = ""
    Dim iIndice As Integer = 0

    sSqlText = "SELECT -1 SQ_PROCEDIMENTO," &
                       enOpcoes.TipoExame_Citologico.GetHashCode() & " ID_OPT_TIPOEXAME," &
                      "'Exame Citolóigico' DS_PROCEDIMENTO," &
                      "' ' CM_PROCEDIMENTO," &
                      "'N' IC_IMPRESSAO," &
                      "GETDATE() DH_INCLUSAO" &
               " FROM TB_CLINICA_EXAME_CITOLOGICO" &
               " WHERE ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO &
               " UNION ALL " &
               "SELECT PROCE.SQ_PROCEDIMENTO," &
                      "PROCE.ID_OPT_TIPOEXAME," &
                      "CONCAT(PROCE.CD_PROCEDIMENTO, ' - ', PROCE.NO_PROCEDIMENTO) DS_PROCEDIMENTO," &
                      "CLPCD.CM_PROCEDIMENTO," &
                      "CLPCD.IC_IMPRESSAO," &
                      "CLPCD.DH_INCLUSAO" &
               " FROM TB_CLINICA_PROCEDIMENTO	CLPCD" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO" &
               " WHERE CLPCD.ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
    sSqlText = "SELECT * FROM (" & sSqlText & ") X ORDER BY DH_INCLUSAO DESC"
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      ReDim oExameEscolhido(oData.Rows.Count - 1)

      For Each oRow As DataRow In oData.Rows
        oExameEscolhido(iIndice) = New cExame
        oExameEscolhido(iIndice).SQ_PROCEDIMENTO = oRow.Item("SQ_PROCEDIMENTO")
        oExameEscolhido(iIndice).ID_OPT_TIPOEXAME = oRow.Item("ID_OPT_TIPOEXAME")
        oExameEscolhido(iIndice).DS_PROCEDIMENTO = oRow.Item("DS_PROCEDIMENTO")
        oExameEscolhido(iIndice).CM_PROCEDIMENTO = FNC_NVL(oRow.Item("CM_PROCEDIMENTO"), "")

        iIndice = iIndice + 1
      Next

      vsbExameEscolhido.Enabled = (oExameEscolhido.Length > 10)
      If oExameEscolhido.Length - 10 > 0 Then vsbExameEscolhido.Maximum = oExameEscolhido.Length - 9 Else vsbExameEscolhido.Maximum = 1

      ListarExamesSelecionados(True)
    End If
  End Sub

  Private Sub CarregarExames()
    Dim oData As DataTable
    Dim sSqlText As String = ""
    Dim sItem As String = ""
    Dim iCont As Integer = 0

    If bEmpProcessamento Then Exit Sub

    If Not optLaboratorias.Checked Then
      bEmpProcessamento = True
      cboClassificacaoExame.SelectedIndex = -1
      bEmpProcessamento = False
    End If

    txtFiltroExame.Text = ""

    If optCitologico.Checked Then
      eOPT_TIPOEXAME = enOpcoes.TipoExame_Citologico
    ElseIf optComplementares.Checked Then
      eOPT_TIPOEXAME = enOpcoes.TipoExame_Complementar
    ElseIf optLaboratorias.Checked Then
      eOPT_TIPOEXAME = enOpcoes.TipoExame_Laboratorial
    End If

    LimparExames()

    sSqlText = "SELECT PROCE.*" &
               " FROM TB_PROCEDIMENTO PROCE" &
                " LEFT JOIN TB_PROCEDIMENTO_ESPECIALIDADE PCESP ON PCESP.ID_PROCEDIMENTO = PROCE.SQ_PROCEDIMENTO" &
                                                             " AND PCESP.ID_ESPECIALIDADE = " & iID_ESPECIALIDADE &
                                                             " AND ISNULL(PCESP.IC_FAVORITO, 'N') = 'S'" &
               " WHERE PROCE.ID_OPT_TIPOPROCEDIMENTO = " & enOpcoes.TipoProcedimento_Exame.GetHashCode()

    If optOutros.Checked Then
      sSqlText = sSqlText & " AND PCESP.ID_PROCEDIMENTO IS NULL"
    Else
      sSqlText = sSqlText & " AND PCESP.ID_PROCEDIMENTO IS NOT NULL"
    End If
    If eOPT_TIPOEXAME <> 0 Then
      sSqlText = sSqlText & " AND PROCE.ID_OPT_TIPOEXAME = " & eOPT_TIPOEXAME.GetHashCode()
    End If
    If ComboBox_Selecionado(cboClassificacaoExame) Then
      sSqlText = sSqlText & " AND PROCE.ID_CLASSIFICACAO_EXAME = " & cboClassificacaoExame.SelectedValue
    End If

    If Not oExameEscolhido Is Nothing Then
      If oExameEscolhido.Count <> 0 Then
        For Each oItem As cExame In oExameEscolhido
          FNC_Str_Adicionar(sItem, oItem.SQ_PROCEDIMENTO, ",")
        Next

        sSqlText = sSqlText & " AND PROCE.SQ_PROCEDIMENTO NOT IN (" & sItem & ")"
      End If
    End If

    If iEMPRESA_ID_TABELAPROCEDIMENTO_PADRAO <> 0 Then
      sSqlText = sSqlText & " AND PROCE.ID_TABELAPROCEDIMENTO IN (" & iEMPRESA_ID_TABELAPROCEDIMENTO_PADRAO.ToString() & ")"
    End If

    sSqlText = sSqlText &
               " ORDER BY PROCE.NO_PROCEDIMENTO"
    oData = DBQuery(sSqlText)

    ReDim oExameDB(oData.Rows.Count - 1)

    For Each oRow As DataRow In oData.Rows
      oExameDB(iCont) = New cExame
      oExameDB(iCont).SQ_PROCEDIMENTO = oRow.Item("SQ_PROCEDIMENTO")
      oExameDB(iCont).DS_PROCEDIMENTO = oRow.Item("CD_PROCEDIMENTO").ToString() + " - " +
                                        oRow.Item("NO_PROCEDIMENTO").ToString()

      iCont = iCont + 1
    Next

    FiltrarExames()
  End Sub

  Private Sub FiltrarExames()
    Dim bAchou As Boolean

    If oExameDB Is Nothing Then Exit Sub

    oExame = Nothing

    For Each oItem As cExame In oExameDB
      bAchou = False

      If Trim(txtFiltroExame.Text) = "" Then
        bAchou = True
      Else
        If oItem.DS_PROCEDIMENTO.ToUpper().IndexOf(txtFiltroExame.Text.ToUpper()) > -1 Then
          bAchou = True
        End If
      End If

      If bAchou Then
        If oExame Is Nothing Then
          ReDim oExame(0)
        Else
          ReDim Preserve oExame(oExame.Length)
        End If

        oExame(oExame.Length - 1) = oItem
      End If
    Next

    If oExame Is Nothing Then
      vsbExame.Enabled = False
      vsbExame.Maximum = 1
    Else
      vsbExame.Enabled = (oExame.Length > 10)
      If oExame.Length - 10 > 0 Then vsbExame.Maximum = oExame.Length - 9 Else vsbExame.Maximum = 1
    End If

    vsbExame.Value = 1

    ListarExames()
  End Sub

  Private Sub MoverItem(iSQ_PROCEDIMENTO As Integer)
    Dim oExameUtil(oExame.Count - 2) As cExame
    Dim oExameCopia() As cExame
    Dim iCont As Integer
    Dim iIndice As Integer = 0

    If oExameEscolhido Is Nothing Then
      ReDim oExameCopia(0)
    Else
      ReDim oExameCopia(oExameEscolhido.Length)
    End If

    For iCont = 1 To oExameCopia.Count - 1
      oExameCopia(iCont) = oExameEscolhido(iCont - 1)
    Next

    oExameEscolhido = oExameCopia

    For iCont = 0 To oExame.Count - 1
      If oExame(iCont).SQ_PROCEDIMENTO = iSQ_PROCEDIMENTO Then
        oExameEscolhido(0) = New cExame
        oExameEscolhido(0).SQ_PROCEDIMENTO = oExame(iCont).SQ_PROCEDIMENTO
        oExameEscolhido(0).ID_OPT_TIPOEXAME = eOPT_TIPOEXAME.GetHashCode()
        oExameEscolhido(0).DS_PROCEDIMENTO = oExame(iCont).DS_PROCEDIMENTO
        oExameEscolhido(0).CM_PROCEDIMENTO = oExame(iCont).CM_PROCEDIMENTO
      Else
        oExameUtil(iIndice) = oExame(iCont)
        iIndice = iIndice + 1
      End If
    Next

    Try
      oExame = oExameUtil

      vsbExame.Enabled = (oExame.Length > 10)
      If oExame.Length - 10 > 0 Then vsbExame.Maximum = oExame.Length - 9 Else vsbExame.Maximum = 1

      vsbExameEscolhido.Enabled = (oExameEscolhido.Length > 10)
      If oExameEscolhido.Length - 10 > 0 Then vsbExameEscolhido.Maximum = oExameEscolhido.Length - 9 Else vsbExameEscolhido.Maximum = 1
    Catch ex As Exception
    End Try

    ListarExames()
    ListarExamesSelecionados(True)

    Salvar()
  End Sub

  Private Sub ExcluirItem(iSQ_PROCEDIMENTO As Integer, iPT_TIPOEXAME As Integer)
    Dim oExameUtil(oExameEscolhido.Count - 2) As cExame
    Dim iCont As Integer
    Dim iIndice As Integer = 0

    For iCont = 0 To oExameEscolhido.Count - 1
      If oExameEscolhido(iCont).SQ_PROCEDIMENTO = iSQ_PROCEDIMENTO Then
        If eOPT_TIPOEXAME.GetHashCode() = iPT_TIPOEXAME Then
          If oExame Is Nothing Then
            ReDim oExame(0)
          Else
            ReDim Preserve oExame(oExame.Length)
          End If

          oExame(oExame.Length - 1) = New cExame
          oExame(oExame.Length - 1).SQ_PROCEDIMENTO = oExameEscolhido(iCont).SQ_PROCEDIMENTO
          oExame(oExame.Length - 1).DS_PROCEDIMENTO = oExameEscolhido(iCont).DS_PROCEDIMENTO
          oExame(oExame.Length - 1).CM_PROCEDIMENTO = oExameEscolhido(iCont).CM_PROCEDIMENTO
        End If
      Else
        oExameUtil(iIndice) = oExameEscolhido(iCont)
        iIndice = iIndice + 1
      End If
    Next

    If iExameExcluir Is Nothing Then
      ReDim iExameExcluir(0)
    Else
      ReDim iExameExcluir(iExameExcluir.Length)
    End If

    iExameExcluir(iExameExcluir.Length - 1) = iSQ_PROCEDIMENTO

    oExameEscolhido = oExameUtil

    If Not oExame Is Nothing Then
      vsbExame.Enabled = (oExame.Length > 10)
      If oExame.Length - 10 > 0 Then vsbExame.Maximum = oExame.Length - 9 Else vsbExame.Maximum = 1
    End If

    vsbExameEscolhido.Enabled = (oExameEscolhido.Length > 10)
    If oExameEscolhido.Length - 10 > 0 Then vsbExameEscolhido.Maximum = oExameEscolhido.Length - 9 Else vsbExameEscolhido.Maximum = 1

    ListarExames()
    ListarExamesSelecionados(True)

    Salvar()
  End Sub

  Private Function Exame_Carregado() As Boolean
    If oExame Is Nothing Then
      Return False
    Else
      Return (oExame.Count > 0)
    End If
  End Function

  Private Sub ListarExames()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    If Exame_Carregado() Then
      For iCont = vsbExame.Value - 1 To vsbExame.Value + 8
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblExame" + FNC_StrZero(iLabel, 2))).Text = oExame(iCont).DS_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblExame" + FNC_StrZero(iLabel, 2))).Tag = oExame(iCont)
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblExame" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblExame" + FNC_StrZero(iLabel, 2))).Tag = Nothing
        End Try

        iLabel = iLabel + 1
      Next
    End If
  End Sub

  Private Sub ListarExamesSelecionados(bPosicionarPonteiro As Boolean)
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    If bPosicionarPonteiro Then vsbExameEscolhido.Value = 1

    For iCont = vsbExameEscolhido.Value - 1 To vsbExameEscolhido.Value + 8
      Try
        Me.Controls(Me.Controls.IndexOfKey("lblExameEscolhido" + FNC_StrZero(iLabel, 2))).Text = oExameEscolhido(iCont).DS_PROCEDIMENTO
        Me.Controls(Me.Controls.IndexOfKey("lblExameEscolhido" + FNC_StrZero(iLabel, 2))).Tag = oExameEscolhido(iCont)
        Me.Controls(Me.Controls.IndexOfKey("txtObservacao" + FNC_StrZero(iLabel, 2))).Text = oExameEscolhido(iCont).CM_PROCEDIMENTO
      Catch ex As Exception
        Me.Controls(Me.Controls.IndexOfKey("lblExameEscolhido" + FNC_StrZero(iLabel, 2))).Text = ""
        Me.Controls(Me.Controls.IndexOfKey("lblExameEscolhido" + FNC_StrZero(iLabel, 2))).Tag = Nothing
        Me.Controls(Me.Controls.IndexOfKey("txtObservacao" + FNC_StrZero(iLabel, 2))).Text = ""
      End Try

      iLabel = iLabel + 1
    Next

    cmdImprimir.Enabled = (oExameEscolhido.Count <> 0)
    cmdImprimirSelecionados.Enabled = (oExameEscolhido.Count <> 0)
    cmdVisualizar.Enabled = (oExameEscolhido.Count <> 0)
  End Sub

  Private Sub vsbExame_ValueChanged(sender As Object, e As EventArgs) Handles vsbExame.ValueChanged
    ListarExames()
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdSelecionar_Click(sender As Object, e As EventArgs) Handles cmdSelecionar01.Click, cmdSelecionar02.Click, cmdSelecionar03.Click,
                                                                            cmdSelecionar04.Click, cmdSelecionar05.Click, cmdSelecionar06.Click,
                                                                            cmdSelecionar07.Click, cmdSelecionar08.Click, cmdSelecionar09.Click,
                                                                            cmdSelecionar10.Click
    Dim oButton As Button
    Dim oLabel As Label
    Dim oExame As cExame

    oButton = sender
    oLabel = Me.Controls("lblExame" + oButton.Name.Substring(13, 2))

    oExame = oLabel.Tag
    MoverItem(oExame.SQ_PROCEDIMENTO)
  End Sub

  Private Sub txtObservacao01_TextChanged(sender As Object, e As EventArgs) Handles txtObservacao01.TextChanged, txtObservacao02.TextChanged,
                                                                                    txtObservacao03.TextChanged, txtObservacao04.TextChanged,
                                                                                    txtObservacao05.TextChanged, txtObservacao06.TextChanged,
                                                                                    txtObservacao07.TextChanged, txtObservacao08.TextChanged,
                                                                                    txtObservacao09.TextChanged, txtObservacao10.TextChanged
    Dim oTextBox As TextBox
    Dim oLabel As Label
    Dim iCont As Integer
    Dim oExame As cExame

    oTextBox = sender
    oLabel = Me.Controls("lblExameEscolhido" + oTextBox.Name.Substring(13, 2))

    For iCont = 0 To oExameEscolhido.Length - 1
      oExame = oLabel.Tag
      If oExameEscolhido(iCont).SQ_PROCEDIMENTO = oExame.SQ_PROCEDIMENTO Then
        oExameEscolhido(iCont).CM_PROCEDIMENTO = oTextBox.Text
      End If
    Next
  End Sub

  Private Sub vsbExameEscolhido_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbExameEscolhido.Scroll
    ListarExamesSelecionados(False)
  End Sub

  Private Sub cmdExcluir01_Click(sender As Object, e As EventArgs) Handles cmdExcluir01.Click, cmdExcluir02.Click, cmdExcluir03.Click,
                                                                           cmdExcluir04.Click, cmdExcluir05.Click, cmdExcluir06.Click,
                                                                           cmdExcluir07.Click, cmdExcluir08.Click, cmdExcluir09.Click,
                                                                           cmdExcluir10.Click
    Dim oButton As Button
    Dim oLabel As Label
    Dim oExame As cExame

    Try
      oButton = sender
      oLabel = Me.Controls("lblExameEscolhido" + oButton.Name.Substring(10, 2))
      oExame = oLabel.Tag

      ExcluirItem(oExame.SQ_PROCEDIMENTO, oExame.ID_OPT_TIPOEXAME)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub optComplementares_CheckedChanged(sender As Object, e As EventArgs) Handles optComplementares.CheckedChanged,
                                                                                         optLaboratorias.CheckedChanged
    CarregarExames()
  End Sub

  Private Sub Salvar()
    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CLINICA_PROCEDIMENTO_CAD", False, "@SQ_CLINICA_PROCEDIMENTO",
                                                                 "@ID_CLINICA_ATENDIMENTO",
                                                                 "@ID_PROCEDIMENTO",
                                                                 "@CM_PROCEDIMENTO")

    For Each oItem As cExame In oExameEscolhido
      If oItem.SQ_PROCEDIMENTO > 0 Then
        DBExecutar(sSqlText, DBParametro_Montar("SQ_CLINICA_PROCEDIMENTO", 0),
                             DBParametro_Montar("ID_CLINICA_ATENDIMENTO", iID_CLINICA_ATENDIMENTO),
                             DBParametro_Montar("ID_PROCEDIMENTO", oItem.SQ_PROCEDIMENTO),
                             DBParametro_Montar("CM_PROCEDIMENTO", oItem.CM_PROCEDIMENTO))
      End If
    Next

    If Not iExameExcluir Is Nothing Then
      For Each iItem As Integer In iExameExcluir
        sSqlText = "DELETE FROM TB_CLINICA_PROCEDIMENTO WHERE ID_CLINICA_ATENDIMENTO = " + iID_CLINICA_ATENDIMENTO.ToString() + " AND ID_PROCEDIMENTO = " + iItem.ToString()
        DBExecutar(sSqlText)
      Next
    End If
  End Sub

  Private Sub optCitologico_CheckedChanged(sender As Object, e As EventArgs) Handles optCitologico.CheckedChanged
    If optCitologico.Checked Then
      Dim oForm As New frmCadastroAtendimentoSolicitacaoExameCitologico

      oForm.iID_CLINICA_ATENDIMENTO = iID_CLINICA_ATENDIMENTO
      oForm.Formatar()

      FNC_AbriTela(oForm, , True, True)

      If oForm.bGravado Then CarregarExamesSelecionados()
    End If
  End Sub

  Private Sub txtFiltroExame_TextChanged(sender As Object, e As EventArgs) Handles txtFiltroExame.TextChanged
    FiltrarExames()
  End Sub

  Private Sub lblExame_Click(sender As Object, e As EventArgs) Handles lblExame01.Click, lblExame02.Click, lblExame03.Click, lblExame04.Click,
                                                                       lblExame05.Click, lblExame06.Click, lblExame07.Click, lblExame08.Click,
                                                                       lblExame09.Click, lblExame10.Click
    Dim oLabel As Label
    Dim oExame As cExame

    oLabel = sender

    oExame = oLabel.Tag

    If Not oExame Is Nothing Then
      MoverItem(oExame.SQ_PROCEDIMENTO)
    End If
  End Sub

  Private Sub cmdVisualizar_Clicado(sender As Object) Handles cmdVisualizar.Clicado
    Dim sSqlText As String

    Salvar()

    sSqlText = "UPDATE TB_CLINICA_PROCEDIMENTO SET IC_IMPRESSAO = 'S'" &
               " WHERE ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
    DBExecutar(sSqlText)

    FormRelatorioSolicitacaoExame(iID_CLINICA_ATENDIMENTO, True)
  End Sub

  Private Sub cmdImprimirSelecionados_Clicado(sender As Object) Handles cmdImprimirSelecionados.Clicado
    Dim sSqlText As String
    Dim sID As String = ""

    If chkSelecionarImpressao01.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(0).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao02.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(1).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao03.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(2).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao04.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(3).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao05.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(4).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao06.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(5).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao07.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(6).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao08.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(7).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao09.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(8).SQ_PROCEDIMENTO, ",")
    If chkSelecionarImpressao10.Checked Then FNC_Str_Adicionar(sID, oExameEscolhido(9).SQ_PROCEDIMENTO, ",")

    sSqlText = "UPDATE TB_CLINICA_PROCEDIMENTO SET IC_IMPRESSAO = 'N'" &
               " WHERE ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
    DBExecutar(sSqlText)
    sSqlText = "UPDATE TB_CLINICA_PROCEDIMENTO SET IC_IMPRESSAO = 'S'" &
               " WHERE ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO &
                 " AND ID_PROCEDIMENTO IN (" & sID & ")"
    DBExecutar(sSqlText)

    FormRelatorioSolicitacaoExame(iID_CLINICA_ATENDIMENTO, True, True)
  End Sub

  Private Sub ImportarFavorito()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim eOPT_TIPOEXAME As Integer

    If optCitologico.Checked Then
      eOPT_TIPOEXAME = enOpcoes.TipoExame_Citologico
    ElseIf optComplementares.Checked Then
      eOPT_TIPOEXAME = enOpcoes.TipoExame_Complementar
    ElseIf optLaboratorias.Checked Then
      eOPT_TIPOEXAME = enOpcoes.TipoExame_Laboratorial
    End If

    sSqlText = "SELECT PSPRC.ID_PROCEDIMENTO" &
               " FROM TB_PESSOA_PROCEDIMENTO PSPRC" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = PSPRC.ID_PROCEDIMENTO" &
                                                " AND PROCE.ID_OPT_TIPOEXAME = " & eOPT_TIPOEXAME.GetHashCode() &
                " INNER JOIN TB_PROCEDIMENTO_ESPECIALIDADE PCESP ON PCESP.ID_PROCEDIMENTO = PSPRC.ID_PROCEDIMENTO" &
                                                              " AND PCESP.ID_ESPECIALIDADE = " & iID_ESPECIALIDADE &
               " WHERE PSPRC.ID_PESSOA = " & iID_USUARIO
    oData = DBQuery(sSqlText)

    For Each oRow As DataRow In oData.Rows
      MoverItem(Convert.ToInt32(oRow.Item("ID_PROCEDIMENTO")))
    Next
  End Sub

  Private Sub cboClassificacaoExame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClassificacaoExame.SelectedIndexChanged
    CarregarExames()
  End Sub

  Private Sub cboClassificacaoExame_KeyDown(sender As Object, e As KeyEventArgs) Handles cboClassificacaoExame.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboClassificacaoExame.SelectedIndex = -1
    End If
  End Sub

  Private Sub optOutros_CheckedChanged(sender As Object, e As EventArgs) Handles optOutros.CheckedChanged
    CarregarExames()
  End Sub

  Private Sub cmdImprimir_Clicado(sender As Object) Handles cmdImprimir.Clicado
    Dim sSqlText As String

    Salvar()

    sSqlText = "UPDATE TB_CLINICA_PROCEDIMENTO SET IC_IMPRESSAO = 'S'" &
               " WHERE ID_CLINICA_ATENDIMENTO = " & iID_CLINICA_ATENDIMENTO
    DBExecutar(sSqlText)

    FormRelatorioSolicitacaoExame(iID_CLINICA_ATENDIMENTO, True, True)
  End Sub
End Class