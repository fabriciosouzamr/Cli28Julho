Public Class frmCadastroAtendimentoOutrasConsultas
  Class cAtendimento
    Public CD_PROCEDIMENTO As String
    Public NO_PROCEDIMENTO As String
    Public NO_MEDICO As String
    Public DH_CLINICA_ATENDIMENTO As String
    Public DESCRICAO As String
    Public EXAMES_SOLICITADOS() As String
  End Class

  Public iID_PESSOA As Integer

  Dim oAtendimento() As cAtendimento

  Private Sub frmCadastroAtendimentoOutrasConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim oData As DataTable
    Dim sSqlText As String

    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdListar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Listar)

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1

    sSqlText = "SELECT CONCAT(RTRIM(PESSO.NO_PESSOA), ' - ', CAST(PESSO.SQ_PESSOA AS VARCHAR)) NO_PESSOA," &
                      "dbo.FC_DateDiff_Extenso(PESSO.DT_NASC_ABERTURA, GETDATE(), 'S') DS_IDADE" &
               " FROM TB_PESSOA PESSO" &
               " WHERE PESSO.SQ_PESSOA = " & iID_PESSOA
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      lblPaciente.Text = oData.Rows(0).Item("NO_PESSOA")
      lblIdade.Text = oData.Rows(0).Item("DS_IDADE")
    End If

    oData.Dispose()

    LimparAtendimentos()

    txtDataInicial.Value = Now.Date.AddYears(-5)
    txtDataFinal.Value = Now.Date()

    Listar()
  End Sub

  Private Sub LimparAtendimentos()
    Dim oItem As ListBox

    For iCont = 1 To 4
      Me.Controls(Me.Controls.IndexOfKey("lblCodigoProcedimento" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblDescricaoProcedimento" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblDataHora" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("rtbDescricao" + FNC_StrZero(iCont, 2))).Text = ""
      oItem = Me.Controls(Me.Controls.IndexOfKey("lstExamesSolicitados" + FNC_StrZero(iCont, 2)))
      oItem.Items.Clear()
    Next
  End Sub

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_OutrasConsultasPaciente))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdListar_Clicado(sender As Object) Handles cmdListar.Clicado
    Listar()
  End Sub

  Private Sub Listar()
    Dim oData As DataTable
    Dim oData_Exames As DataTable = New DataTable()
    Dim sSqlText As String
    Dim sSqlText_Where As String = ""
    Dim iIndice As Integer = 0
    Dim iCont As Integer = 0

    Try
      sSqlText = "SELECT CLATD.SQ_CLINICA_ATENDIMENTO," &
                       "CLATD.DH_CLINICA_ATENDIMENTO," &
                       "PROCE.CD_PROCEDIMENTO," &
                       "PROCE.NO_PROCEDIMENTO," &
                       "PESSO.NO_PESSOA NO_MEDICO," &
                       "CLATD.DS_CLINICA_ATENDIMENTO" &
                " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                 " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CLATD.ID_PROCEDIMENTO" &
                 " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                " WHERE CLATD.ID_PESSOA = " & iID_PESSOA.ToString()

      If IsDate(txtDataInicial.Text) Then
        FNC_Str_Adicionar(sSqlText_Where, " CAST(DH_CLINICA_ATENDIMENTO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text), " AND ")
      End If
      If IsDate(txtDataFinal.Text) Then
        FNC_Str_Adicionar(sSqlText_Where, " CAST(DH_CLINICA_ATENDIMENTO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text), " AND ")
      End If

      If Trim(sSqlText_Where) <> "" Then
        If optMinhasConsultas.Checked Then
          sSqlText = sSqlText & " AND CLATD.ID_PESSOA_PROFISSIONAL = " & iID_USUARIO & " AND " & sSqlText_Where
        End If
        If optOutrosProfissionais.Checked Then
          sSqlText = sSqlText & " AND CLATD.ID_PESSOA_PROFISSIONAL <> " & iID_USUARIO & " AND " & sSqlText_Where
        End If
      End If

      sSqlText = sSqlText & " ORDER BY CLATD.DH_CLINICA_ATENDIMENTO DESC"
      oData = DBQuery(sSqlText)

      If objDataTable_Vazio(oData) Then
        oAtendimento = Nothing
      Else
        ReDim oAtendimento(oData.Rows.Count - 1)

        For Each oRow As DataRow In oData.Rows
          oAtendimento(iIndice) = New cAtendimento()

          With oAtendimento(iIndice)
            .CD_PROCEDIMENTO = oRow.Item("CD_PROCEDIMENTO")
            .NO_PROCEDIMENTO = FNC_NVL(oRow.Item("NO_PROCEDIMENTO"), "")
            .NO_MEDICO = oRow.Item("NO_MEDICO")
            .DH_CLINICA_ATENDIMENTO = oRow.Item("DH_CLINICA_ATENDIMENTO")
            .DESCRICAO = FNC_NVL(oRow.Item("DS_CLINICA_ATENDIMENTO"), "")
          End With

          sSqlText = "SELECT 'Receituário : ' + CONVERT(VARCHAR, DT_LANCAMENTO, 103) DS_TITULO," +
                             "DS_RECEITUARIO" +
                     " FROM TB_CLINICA_RECEITUARIO" +
                     " WHERE ID_CLINICA_ATENDIMENTO = " & oRow.Item("SQ_CLINICA_ATENDIMENTO")
          oData_Exames = DBQuery(sSqlText)

          If Not objDataTable_Vazio(oData_Exames) Then
            If oAtendimento(iIndice).DESCRICAO.Trim() <> "" Then
              oAtendimento(iIndice).DESCRICAO = oAtendimento(iIndice).DESCRICAO + Environment.NewLine
            End If

            For Each oRowExame As DataRow In oData_Exames.Rows
              FNC_Str_Adicionar(oAtendimento(iIndice).DESCRICAO, oRowExame.Item("DS_TITULO") + " " + oRowExame.Item("DS_RECEITUARIO"), Environment.NewLine)
            Next
          End If

          sSqlText = "SELECT CONCAT(PROCE.CD_PROCEDIMENTO, ' - ', PROCE.NO_PROCEDIMENTO) DS_PROCEDIMENTO" &
                       " FROM TB_CLINICA_PROCEDIMENTO CLPCD" &
                        " INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CLPCD.ID_PROCEDIMENTO" &
                       " WHERE CLPCD.ID_CLINICA_ATENDIMENTO = " & oRow.Item("SQ_CLINICA_ATENDIMENTO") &
                       " UNION ALL " &
                       "SELECT 'Exame Citológico'" &
                       " FROM TB_CLINICA_EXAME_CITOLOGICO" &
                       " WHERE ID_CLINICA_ATENDIMENTO = " & oRow.Item("SQ_CLINICA_ATENDIMENTO")
          oData_Exames = DBQuery(sSqlText)

          If Not objDataTable_Vazio(oData_Exames) Then
            ReDim oAtendimento(iIndice).EXAMES_SOLICITADOS(oData_Exames.Rows.Count - 1)

            iCont = 0

            For Each oRowExame As DataRow In oData_Exames.Rows
              oAtendimento(iIndice).EXAMES_SOLICITADOS(iCont) = oRowExame.Item("DS_PROCEDIMENTO")

              iCont = iCont + 1
            Next
          End If

          iIndice = iIndice + 1
        Next

        oData.Dispose()
        oData_Exames.Dispose()
      End If

      If oAtendimento Is Nothing Then
        VScrollBar.Enabled = False
        LimparAtendimentos()
      Else
        VScrollBar.Enabled = (oAtendimento.Length > 4)
        If oAtendimento.Length - 4 > 0 Then VScrollBar.Maximum = oAtendimento.Length - 3
      End If

      VScrollBar.Value = 1

      ListarAtendimentos()
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Private Function Atendimentos_Carregado() As Boolean
    If oAtendimento Is Nothing Then
      Return False
    Else
      Return (oAtendimento.Count > 0)
    End If
  End Function

  Private Sub ListarAtendimentos()
    Dim oItem As ListBox
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    If Atendimentos_Carregado() Then
      For iCont = VScrollBar.Value - 1 To VScrollBar.Value + 2
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblCodigoProcedimento" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).CD_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblDescricaoProcedimento" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).NO_PROCEDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).NO_MEDICO
          Me.Controls(Me.Controls.IndexOfKey("lblDataHora" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).DH_CLINICA_ATENDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("rtbDescricao" + FNC_StrZero(iLabel, 2))).Text = oAtendimento(iCont).DESCRICAO

          Try
            oItem = Me.Controls(Me.Controls.IndexOfKey("lstExamesSolicitados" + FNC_StrZero(iLabel, 2)))

            oItem.Items.Clear()

            If Not oAtendimento(iCont).EXAMES_SOLICITADOS Is Nothing Then
              For Each oItemExame As String In oAtendimento(iCont).EXAMES_SOLICITADOS
                oItem.Items.Add(oItemExame)
              Next
            End If
          Catch ex As Exception
          End Try
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblCodigoProcedimento" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblDescricaoProcedimento" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblDataHora" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("rtbDescricao" + FNC_StrZero(iLabel, 2))).Text = ""
          oItem = Me.Controls(Me.Controls.IndexOfKey("lstExamesSolicitados" + FNC_StrZero(iLabel, 2)))
          oItem.Items.Clear()
        End Try

        iLabel = iLabel + 1
      Next
    End If
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    ListarAtendimentos()
  End Sub
End Class