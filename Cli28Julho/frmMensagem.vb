Imports Infragistics.Win

Public Class frmMensagem
  Const const_GridListagem_SQ_AGENDAMENTO As Integer = 0
  Const const_GridListagem_Chk As Integer = 1
  Const const_GridListagem_PACIENTE As Integer = 2
  Const const_GridListagem_FONE As Integer = 3
  Const const_GridListagem_CD_AGENDAMENTO As Integer = 4
  Const const_GridListagem_NO_GRUPOPROCEDIMENTO As Integer = 5
  Const const_GridListagem_CD_PROCEDIMENTO As Integer = 6
  Const const_GridListagem_NO_PROCEDIMENTO As Integer = 7
  Const const_GridListagem_NO_PROCEDIMENTO_PRESCRITO As Integer = 8
  Const const_GridListagem_DH_AGENDAMENTO As Integer = 9
  Const const_GridListagem_NO_STATUS As Integer = 10
  Const const_GridListagem_NO_CONVENIO As Integer = 11
  Const const_GridListagem_NO_STATUS_PACIENTE As Integer = 12
  Const const_GridListagem_NO_PROFISSAO As Integer = 13
  Const const_GridListagem_NO_CIDADE As Integer = 14
  Const const_GridListagem_NO_BAIRRO As Integer = 15
  Const const_GridListagem_NO_TIPO_ESTADOCIVIL As Integer = 16
  Const const_GridListagem_NO_PROFISSIONAL As Integer = 17
  Const const_GridListagem_NO_ESPECIALIDADE As Integer = 18
  Const const_GridListagem_NO_TIPO_CONSULTA As Integer = 19
  Const const_GridListagem_DT_NASC_ABERTURA As Integer = 20
  Const const_GridListagem_FONEZAP As Integer = 21
  Const const_GridListagem_NO_CANALMARCACAO As Integer = 22

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Dim sSqlText As String
    Dim sSqlText_Where_01 As String = ""
    Dim sSqlText_Where_02 As String = ""
    Dim sSqlText_Exclusao As String

    sSqlText = "SELECT DISTINCT AGEND.SQ_AGENDAMENTO," &
                               "0 CHK," &
                               "PESSO_PACIE.NO_PESSOA AS PACIENTE," &
                               "PSTEL.CD_NUMERO AS FONE," &
                               "AGEND.CD_AGENDAMENTO," &
                               "GPPCD.NO_GRUPOPROCEDIMENTO AS [GRUPO PROCEDIMENTO]," &
                               "PROCE.CD_PROCEDIMENTO," &
                               "PROCE.NO_PROCEDIMENTO AS PROCEDIMENTO," &
                               "PRCPC.NO_PROCEDIMENTO," &
                               "AGEND.DH_AGENDAMENTO," &
                               "OPCAO_STSAG.NO_OPCAO AS STATUS," &
                               "CONVE.NO_CONVENIO AS CONVÊNIO," &
                               "OPCAO_STSPS.NO_OPCAO AS [STATUS DO PACIENTE]," &
                               "PROFI.NO_PROFISSAO AS PROFISSÃO," &
                               "CIDAD.NO_CIDADE AS CIDADE," &
                               "ENDER.NO_BAIRRO AS BAIRRO," &
                               "TPSTC.NO_TIPO_ESTADOCIVIL AS [ESTADO CIVIL]," &
                               "PESSO_PROFI.NO_PESSOA AS PROFISSIONAL," &
                               "ESPEC.NO_ESPECIALIDADE AS ESPECIALIDADE," &
                               "TPCST.NO_TIPO_CONSULTA," &
                               "CAST(PESSO_PACIE.DT_NASC_ABERTURA AS DATE) DT_NASC_ABERTURA," &
                               "dbo.FC_Formatar_NUMERO_WHATSAPP(PSTEL.CD_NUMERO) CD_NUMERO," &
                               "CNLMC.NO_CANALMARCACAO"

    If chkQuemNaoFezExamesNovamente.Checked Then sSqlText = sSqlText & ",AGEND.ID_PROCEDIMENTO,AGEND.ID_PESSOA"

    sSqlText = sSqlText &
               " FROM TB_AGENDAMENTO AGEND" &
                " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = AGEND.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN TB_ESPECIALIDADE ESPEC ON ESPEC.SQ_ESPECIALIDADE = AGEND.ID_ESPECIALIDADE" &
                " INNER JOIN TB_PESSOA_ESPECIALIDADE PSESP ON PSESP.ID_ESPECIALIDADE = ESPEC.SQ_ESPECIALIDADE" &
                                                         " AND PSESP.ID_PESSOA = PESSO_PROFI.SQ_PESSOA" &
                " INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = AGEND.ID_CONVENIO" &
                " INNER JOIN TB_OPCAO OPCAO_STSAG ON AGEND.ID_OPT_STATUS = OPCAO_STSAG.SQ_OPCAO" &
                " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = AGEND.ID_PROCEDIMENTO" &
                " INNER JOIN TB_GRUPOPROCEDIMENTO GPPCD ON GPPCD.SQ_GRUPOPROCEDIMENTO = PROCE.ID_GRUPOPROCEDIMENTO" &
                " INNER JOIN TB_PESSOA PESSO_PACIE ON PESSO_PACIE.SQ_PESSOA = AGEND.ID_PESSOA" &
                " INNER JOIN TB_OPCAO OPCAO_STSPS ON OPCAO_STSPS.SQ_OPCAO = PESSO_PACIE.ID_OPT_ATIVO" &
                 " LEFT JOIN TB_CANALMARCACAO CNLMC ON CNLMC.SQ_CANALMARCACAO = AGEND.ID_CANALMARCACAO" &
                 " LEFT JOIN TB_TIPO_CONSULTA TPCST ON TPCST.SQ_TIPO_CONSULTA = AGEND.ID_TIPO_CONSULTA" &
                 " LEFT JOIN TB_ENDERECO ENDER ON ENDER.ID_PESSOA = PESSO_PACIE.SQ_PESSOA" &
                 " LEFT JOIN TB_CIDADE CIDAD ON CIDAD.SQ_CIDADE = ENDER.ID_CIDADE" &
                 " LEFT JOIN TB_CLINICA_ATENDIMENTO CLATD ON AGEND.ID_PROCEDIMENTO = CLATD.ID_PROCEDIMENTO" &
                                                       " AND AGEND.ID_EMPRESA = CLATD.ID_EMPRESA" &
                                                       " AND AGEND.ID_PESSOA = CLATD.ID_PESSOA" &
                                                       " AND AGEND.ID_PESSOA_PROFISSIONAL = CLATD.ID_PESSOA_PROFISSIONAL" &
                                                       " AND AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                 " LEFT JOIN TB_PESSOA_PROFISSAO PACIE_PROFI ON PACIE_PROFI.ID_PESSOA = PESSO_PACIE.SQ_PESSOA" &
                 " LEFT JOIN TB_PROFISSAO PROFI ON PROFI.SQ_PROFISSAO = PACIE_PROFI.ID_PROFISSAO" &
                 " LEFT JOIN TB_TIPO_ESTADOCIVIL TPSTC ON TPSTC.SQ_TIPO_ESTADOCIVIL = PESSO_PACIE.ID_PF_TIPO_ESTADOCIVIL" &
                 " LEFT JOIN TB_CLINICA_EXAME_CITOLOGICO CECIT ON CECIT.ID_CLINICA_ATENDIMENTO = CLATD.SQ_CLINICA_ATENDIMENTO" &
                 " LEFT JOIN (SELECT ID_PESSOA, IC_WHATSAPP, MAX(CD_NUMERO) CD_NUMERO FROM TB_PESSOA_TELEFONE WHERE IC_WHATSAPP = 'S' GROUP BY ID_PESSOA, IC_WHATSAPP) PSTEL ON PSTEL.ID_PESSOA = PESSO_PACIE.SQ_PESSOA" &
                 " LEFT JOIN TB_CLINICA_PROCEDIMENTO CLPCD ON CLPCD.ID_CLINICA_ATENDIMENTO = CLATD.SQ_CLINICA_ATENDIMENTO" &
                 " LEFT JOIN TB_PROCEDIMENTO PRCPC ON PRCPC.SQ_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO"

    If ComboBox_Selecionado(cboTipoAgendamento) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_TIPO_CONSULTA = " & cboTipoAgendamento.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboConvenio) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_CONVENIO = " & cboConvenio.SelectedValue, " AND ")
    End If
    If chkExamePrevisto.Checked Then
      FNC_Str_Adicionar(sSqlText_Where_01, "CLPCD.SQ_CLINICA_PROCEDIMENTO IS NOT NULL", " AND ")
    End If
    If chkQuemNaoFezExames.Checked Then
      FNC_Str_Adicionar(sSqlText_Where_01, "CLPCD.SQ_CLINICA_PROCEDIMENTO NOT IN (SELECT ID_CLINICA_PROCEDIMENTO FROM TB_CLINICA_VENDA_PROCEDIMENTO WHERE ID_CLINICA_PROCEDIMENTO IS NOT NULL)", " AND ")
    End If
    If chkAniversariantesDia.Checked Then
      FNC_Str_Adicionar(sSqlText_Where_01, "MONTH(PESSO_PACIE.DT_NASC_ABERTURA) = MONTH(GETDATE()) AND DAY(PESSO_PACIE.DT_NASC_ABERTURA) = DAY(GETDATE())", " AND ")
    End If
    If ComboBox_Selecionado(cboGrupoProcedimento) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "PROCE.ID_GRUPOPROCEDIMENTO = " & cboGrupoProcedimento.SelectedValue, " AND ")
    End If
    If psqProcedimento.Identificador > 0 Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_PROCEDIMENTO = " & psqProcedimento.Identificador, " AND ")
    End If
    If psqExamePrescrito.Identificador > 0 Then
      FNC_Str_Adicionar(sSqlText_Where_01, "CLPCD.ID_PROCEDIMENTO = " & psqExamePrescrito.Identificador, " AND ")
    End If
    If IsDate(txtDataNascimentoInicial.Value) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "CAST(PESSO_PACIE.DT_NASC_ABERTURA AS DATE) >= " & FNC_QuotedStr(txtDataNascimentoInicial.Text), " AND ")
    End If
    If IsDate(txtDataNascimentoFinal.Value) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "CAST(PESSO_PACIE.DT_NASC_ABERTURA AS DATE) <= " & FNC_QuotedStr(txtDataNascimentoFinal.Text), " AND ")
    End If
    If ComboBox_Selecionado(cboSexo) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "PESSO_PACIE.ID_PF_TIPO_SEXO = " & cboSexo.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboProfissao) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_PESSOA IN (SELECT ID_PESSOA FROM TB_PESSOA_PROFISSAO WHERE ID_PROFISSAO = " & cboProfissao.SelectedValue & ")", " AND ")
    End If
    If ComboBox_Selecionado(cboCidade) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_PESSOA IN (SELECT ID_PESSOA FROM TB_ENDERECO WHERE ID_CIDADE  = " & cboCidade.SelectedValue & ")", " AND ")
    End If
    If Trim(txtBairro.Text) <> "" Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_PESSOA IN (SELECT ID_PESSOA FROM TB_ENDERECO WHERE NO_BAIRRO LIKE " & FNC_SQL_FormatarLike(txtBairro.Text) & ")", " AND ")
    End If
    If ComboBox_Selecionado(cboEstadoCivil) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "PESSO_PACIE.ID_PF_TIPO_ESTADOCIVIL = " & cboEstadoCivil.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboProfissional) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_PESSOA_PROFISSIONAL = " & cboProfissional.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboCanalMarcacao) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_CANALMARCACAO = " & cboCanalMarcacao.SelectedValue, " AND ")
    End If
    If ComboBox_Selecionado(cboEspecialidade) Then
      FNC_Str_Adicionar(sSqlText_Where_01, "AGEND.ID_PESSOA_PROFISSIONAL IN (SELECT ID_PESSOA FROM TB_PESSOA_ESPECIALIDADE WHERE ID_ESPECIALIDADE  = " & cboEspecialidade.SelectedValue & ")", " AND ")
    End If
    If txtDiaAniversario.Value > 0 Then
      FNC_Str_Adicionar(sSqlText_Where_01, "DATEPART(DAY, PESSO_PACIE.DT_NASC_ABERTURA) = " & txtDiaAniversario.Value, " AND ")
    End If
    If cboMesAniversario.SelectedIndex > -1 Then
      FNC_Str_Adicionar(sSqlText_Where_01, "DATEPART(MONTH, PESSO_PACIE.DT_NASC_ABERTURA) = " & cboMesAniversario.SelectedValue, " AND ")
    End If

    If chkQuemNaoFezExamesNovamente.Checked And IsDate(txtDataAgendamentoFinal.Value) Then
      sSqlText_Exclusao = "SELECT AG.ID_PESSOA, AG.ID_PROCEDIMENTO FROM TB_AGENDAMENTO AG WHERE AG.ID_OPT_STATUS NOT IN (42,43,44,661) AND AG.DH_AGENDAMENTO > " & FNC_QuotedStr(txtDataAgendamentoFinal.Text)

      If psqProcedimento.Identificador > 0 Then
        sSqlText_Exclusao = sSqlText_Exclusao & " AND AG.ID_PROCEDIMENTO = " & psqProcedimento.Identificador
      End If
    End If

    If (IsDate(txtDataSemAgendamentoInicial.Value) Or IsDate(txtDataSemAgendamentoFinal.Value)) Then
      If IsDate(txtDataAgendamentoInicial.Value) Then
        FNC_Str_Adicionar(sSqlText_Where_02, "CAST(AGEND.DH_AGENDAMENTO AS DATE) >= " & FNC_QuotedStr(txtDataAgendamentoInicial.Text), " AND ")
      End If
      If IsDate(txtDataAgendamentoFinal.Value) Then
        FNC_Str_Adicionar(sSqlText_Where_02, "CAST(AGEND.DH_AGENDAMENTO AS DATE) <= " & FNC_QuotedStr(txtDataAgendamentoFinal.Text), " AND ")
      End If
      sSqlText_Where_02 = "((" & sSqlText_Where_02 & ") OR AGEND.SQ_AGENDAMENTO IN (SELECT SQ_AGENDAMENTO FROM TB_AGENDAMENTO" &
                                               " WHERE ID_PROCEDIMENTO = " & psqProcedimento.Identificador

      If IsDate(txtDataSemAgendamentoInicial.Value) Then
        sSqlText_Where_02 = sSqlText_Where_02 & " AND CAST(DH_AGENDAMENTO AS DATE) >= " & FNC_QuotedStr(txtDataSemAgendamentoInicial.Text)
      End If
      If IsDate(txtDataSemAgendamentoFinal.Value) Then
        sSqlText_Where_02 = sSqlText_Where_02 & " AND CAST(DH_AGENDAMENTO AS DATE) <= " & FNC_QuotedStr(txtDataSemAgendamentoFinal.Text)
      End If

      sSqlText_Where_02 = sSqlText_Where_02 & "))"

      sSqlText_Where_01 = sSqlText_Where_01 & " AND " & sSqlText_Where_02
    Else
      If IsDate(txtDataAgendamentoInicial.Value) Then
        FNC_Str_Adicionar(sSqlText_Where_01, "CAST(AGEND.DH_AGENDAMENTO AS DATE) >= " & FNC_QuotedStr(txtDataAgendamentoInicial.Text), " AND ")
      End If
      If IsDate(txtDataAgendamentoFinal.Value) Then
        FNC_Str_Adicionar(sSqlText_Where_01, "CAST(AGEND.DH_AGENDAMENTO AS DATE) <= " & FNC_QuotedStr(txtDataAgendamentoFinal.Text), " AND ")
      End If
    End If

    sSqlText = sSqlText & " WHERE PSTEL.IC_WHATSAPP = 'S'"

    If Not String.IsNullOrEmpty(sSqlText_Where_01) Then
      sSqlText = sSqlText & " AND " & sSqlText_Where_01
    End If

    sSqlText = sSqlText &
                " ORDER BY PESSO_PACIE.NO_PESSOA"
    Dim oData As DataTable = DBQuery(sSqlText)

    If Not String.IsNullOrWhiteSpace(sSqlText_Exclusao) Then
      Dim oDataExclusao As DataTable = DBQuery(sSqlText_Exclusao)
      Dim iCont As Integer = 0
      Dim bAchou As Boolean

      Do While iCont < oData.Rows.Count
        bAchou = False

        For Each oDataRowExclusao As DataRow In oDataExclusao.Rows
          If oData.Rows(iCont).Item("ID_PESSOA") = oDataRowExclusao.Item("ID_PESSOA") And
             oData.Rows(iCont).Item("ID_PROCEDIMENTO") = oDataRowExclusao.Item("ID_PROCEDIMENTO") Then
            oData.Rows.RemoveAt(iCont)
            bAchou = True
            Exit For
          End If
        Next

        If Not bAchou Then
          iCont = iCont + 1
        End If
      Loop

    End If

    If chkQuemNaoFezExamesNovamente.Checked Then
      oData.Columns.Remove(oData.Columns("ID_PESSOA"))
      oData.Columns.Remove(oData.Columns("ID_PROCEDIMENTO"))
    End If


    objGrid_Carregar(grdListagem, sSqlText, New Integer() {const_GridListagem_SQ_AGENDAMENTO,
                                                           const_GridListagem_Chk,
                                                           const_GridListagem_PACIENTE,
                                                           const_GridListagem_FONE,
                                                           const_GridListagem_CD_AGENDAMENTO,
                                                           const_GridListagem_NO_GRUPOPROCEDIMENTO,
                                                           const_GridListagem_CD_PROCEDIMENTO,
                                                           const_GridListagem_NO_PROCEDIMENTO,
                                                           const_GridListagem_NO_PROCEDIMENTO_PRESCRITO,
                                                           const_GridListagem_DH_AGENDAMENTO,
                                                           const_GridListagem_NO_STATUS,
                                                           const_GridListagem_NO_CONVENIO,
                                                           const_GridListagem_NO_STATUS_PACIENTE,
                                                           const_GridListagem_NO_PROFISSAO,
                                                           const_GridListagem_NO_CIDADE,
                                                           const_GridListagem_NO_BAIRRO,
                                                           const_GridListagem_NO_TIPO_ESTADOCIVIL,
                                                           const_GridListagem_NO_PROFISSIONAL,
                                                           const_GridListagem_NO_ESPECIALIDADE,
                                                           const_GridListagem_NO_TIPO_CONSULTA,
                                                           const_GridListagem_DT_NASC_ABERTURA,
                                                           const_GridListagem_FONEZAP,
                                                           const_GridListagem_NO_CANALMARCACAO},,, oData)

    ContarContatos()
  End Sub

  Private Sub ContarContatos()
    Dim Contados As New Collection()
    Dim iCont01 As Integer
    Dim iCont02 As Integer
    Dim bachou As Boolean

    For iCont01 = 0 To grdListagem.Rows.Count - 1
      bachou = False

      If grdListagem.Rows(iCont01).Cells(const_GridListagem_FONEZAP).Value.ToString().Trim() <> "" Then
        For iCont02 = 1 To Contados.Count
          If Contados(iCont02) = grdListagem.Rows(iCont01).Cells(const_GridListagem_FONEZAP).Value Then
            bachou = True
            Exit For
          End If
        Next
      End If

      If Not bachou Then
        Contados.Add(grdListagem.Rows(iCont01).Cells(const_GridListagem_FONEZAP).Value)
      End If
    Next

    lblQuantidadePessoas.Text = lblQuantidadePessoas.Tag & " " & FNC_StrZero(Contados.Count, 3)
  End Sub

  Private Sub frmMensagem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboGrupoProcedimento, enSql.GrupoProcedimento)
    ComboBox_Carregar(cboSexo, enSql.Sexo)
    ComboBox_Carregar(cboProfissao, enSql.Profissao)
    ComboBox_Carregar(cboConvenio, enSql.Convenio)
    ComboBox_Carregar(cboCidade, enSql.Cidade)
    ComboBox_Carregar(cboEstadoCivil, enSql.EstadoCivil)
    ComboBox_Carregar(cboStatus, enSql.AtivoInativo_Pessoal)
    ComboBox_Carregar(cboEspecialidade, enSql.Especialidade)
    ComboBox_Carregar(cboProfissional, enSql.Profissional_ServicoInterno)
    ComboBox_Carregar(cboTipoAgendamento, enSql.Tipo_Consulta)
    ComboBox_Carregar(cboCanalMarcacao, enSql.CanalMarcacao)
    ComboBox_CarregarMeses(cboMesAniversario)

    txtDataAgendamentoInicial.Value = Nothing
    txtDataAgendamentoFinal.Value = Nothing
    txtDataSemAgendamentoInicial.Value = Nothing
    txtDataSemAgendamentoFinal.Value = Nothing
    txtDataNascimentoInicial.Value = Nothing
    txtDataNascimentoFinal.Value = Nothing

    objGrid_Inicializar(grdListagem, , oDBGrid, UltraWinGrid.CellClickAction.RowSelect, , DefaultableBoolean.False, True, , , , True)
    objGrid_Coluna_Add(grdListagem, "SQ_AGENDAMENTO", 0)
    objGrid_Coluna_Add(grdListagem, "...", 30, , True, UltraWinGrid.ColumnStyle.CheckBox)
    objGrid_Coluna_Add(grdListagem, "Paciente", 100)
    objGrid_Coluna_Add(grdListagem, "Fone", 100)
    objGrid_Coluna_Add(grdListagem, "Cód. Agendamento", 100)
    objGrid_Coluna_Add(grdListagem, "Grupo de Procedimento", 100)
    objGrid_Coluna_Add(grdListagem, "Cód. Procedimento", 150)
    objGrid_Coluna_Add(grdListagem, "Procedimento", 150)
    objGrid_Coluna_Add(grdListagem, "Exames Prescritos", 150)
    objGrid_Coluna_Add(grdListagem, "D/H Agendamento", 0)
    objGrid_Coluna_Add(grdListagem, "Status", 100)
    objGrid_Coluna_Add(grdListagem, "Convênio", 150)
    objGrid_Coluna_Add(grdListagem, "Status DO Paciente", 100)
    objGrid_Coluna_Add(grdListagem, "Profissão", 100)
    objGrid_Coluna_Add(grdListagem, "Cidade", 100)
    objGrid_Coluna_Add(grdListagem, "Bairro", 100)
    objGrid_Coluna_Add(grdListagem, "Estado Civíl", 100)
    objGrid_Coluna_Add(grdListagem, "Profissional", 100)
    objGrid_Coluna_Add(grdListagem, "Especialidade", 100)
    objGrid_Coluna_Add(grdListagem, "Tipo de Consulta", 100)
    objGrid_Coluna_Add(grdListagem, "Data de Nascimento", 100, ,, UltraWinGrid.ColumnStyle.Date)
    objGrid_Coluna_Add(grdListagem, "Fone Formatado", 100)
    objGrid_Coluna_Add(grdListagem, "Canal de Marcação", 200)

    Me.Width = 1150
    Me.Height = 600
  End Sub

  Private Sub cmdWhatsApp_EnviarListagem_Click(sender As Object, e As EventArgs) Handles cmdWhatsApp_EnviarListagem.Click
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim oChatGuru As New modChatGuru()
    Dim Lista As Collection = New Collection()
    Dim Achou As Boolean

    Dim iLinha As Integer

    For iCont_01 = 0 To grdListagem.Rows.GetFilteredInNonGroupByRows().Count - 1
      iLinha = grdListagem.Rows.GetFilteredInNonGroupByRows(iCont_01).Index
      If objGrid_CheckCol_Valor(grdListagem, const_GridListagem_Chk, iLinha) = "S" Then
        Achou = False

        For iCont_02 = 1 To Lista.Count
          If Split(Lista(iCont_02), "#")(1) = objGrid_Valor(grdListagem, const_GridListagem_FONEZAP, iLinha) Then
            Achou = True
            Exit For
          End If
        Next

        If Not Achou Then Lista.Add(objGrid_Valor(grdListagem, const_GridListagem_PACIENTE, iLinha) + "#" + objGrid_Valor(grdListagem, const_GridListagem_FONEZAP, iLinha))
      End If
    Next

    For iCont_01 = 1 To Lista.Count
      oChatGuru.sKey = txtKeyZap.Text
      oChatGuru.Enviar(rtbWahtsApp.Text,
                       Split(Lista(iCont_01), "#")(0).Trim(),
                       Split(Lista(iCont_01), "#")(1),
                       txtTituloLinkArquivo.Text,
                       txtLinkArquivo.Text,
                       txtCodigoUsuario.Text)
    Next

    txtLinkArquivo.Text = ""

    FNC_Mensagem("Mensagem enviada")
  End Sub

  Private Sub cmdWhatsApp_EnviarNumero_Click(sender As Object, e As EventArgs) Handles cmdWhatsApp_EnviarNumero.Click
    Dim oChatGuru As New modChatGuru()

    If Trim(txtNumeroZap.Text) = "" Then
      FNC_Mensagem("Informe o número para envio")
      Exit Sub
    End If

    Try
      oChatGuru.sKey = txtKeyZap.Text
      oChatGuru.Enviar(rtbWahtsApp.Text, "Clínica 28 Julho - TI", txtNumeroZap.Text,
                                                                  txtTituloLinkArquivo.Text,
                                                                  txtLinkArquivo.Text,
                                                                  txtCodigoUsuario.Text)
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try

    txtLinkArquivo.Text = ""

    FNC_Mensagem("Mensagem enviada")
  End Sub

  Private Sub ComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles cboGrupoProcedimento.KeyDown,
                                                                            cboSexo.KeyDown,
                                                                            cboProfissao.KeyDown,
                                                                            cboConvenio.KeyDown,
                                                                            cboCidade.KeyDown,
                                                                            cboEstadoCivil.KeyDown,
                                                                            cboStatus.KeyDown,
                                                                            cboProfissional.KeyDown,
                                                                            cboEspecialidade.KeyDown,
                                                                            cboTipoAgendamento.KeyDown,
                                                                            cboMesAniversario.KeyDown
    If e.KeyCode = Keys.Delete Then
      sender.SelectedIndex = -1
    End If
  End Sub

  Private Sub cmdExportarExcel_Click(sender As Object, e As EventArgs) Handles cmdExportarExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub chkQuemNaoFezExamesNovamente_CheckedChanged(sender As Object, e As EventArgs) Handles chkQuemNaoFezExamesNovamente.CheckedChanged
    If chkQuemNaoFezExamesNovamente.Checked Then
      txtDataSemAgendamentoInicial.Value = Nothing
      txtDataSemAgendamentoFinal.Value = Nothing
    End If

    txtDataSemAgendamentoInicial.Enabled = (Not chkQuemNaoFezExamesNovamente.Checked)
    txtDataSemAgendamentoFinal.Enabled = (Not chkQuemNaoFezExamesNovamente.Checked)
  End Sub

    Private Sub cmdSMS_PreVisualizacao_Click(sender As Object, e As EventArgs) Handles cmdSMS_PreVisualizacao.Click

    End Sub
End Class