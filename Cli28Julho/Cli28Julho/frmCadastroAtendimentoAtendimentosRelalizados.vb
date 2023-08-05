Public Class frmCadastroAtendimentoAtendimentosRelalizados
  Class cAtendimentos
    Public iID_AGENDAMENTO As Integer
    Public Data As String
    Public Paciente As String
    Public TipoAtendimento As String
    Public Status As String
    Public Valor As Double
    Public VlPrestador As Double
  End Class

  Dim oAtendimentos() As cAtendimentos

  Private Sub frmCadastroAtendimentoAtendimentosRelalizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_AtendimentosRealizados))
    ComboBox_Carregar(cboStatus, enSql.StatusAtendimentoClinica)
    ComboBox_Carregar(cboTipoConsulta, enSql.Tipo_Consulta)

    cmdListar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Listar)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)

    txtPeriodoInicial.Value = Nothing
    txtPeriodoFinal.Value = Nothing

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1

    lblMedico.Text = sNO_USUARIO

    psqPessoa.TipoFiltro = uscPesqPessoa.enTipoFiltroPessoa.Paciente

    LimparAtendimentos()
  End Sub

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_AtendimentosRealizados))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub

  Private Sub cmdListar_Clicado(sender As Object) Handles cmdListar.Clicado
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iIndice As Integer = 0
    Dim iQuantidade As Integer
    Dim dValorTotal As Double
    Dim dVlPrestadorTotal As Double

    sSqlText = "SELECT CLATD.ID_AGENDAMENTO," &
                      "CLATD.DH_CLINICA_ATENDIMENTO," &
                      "PESSO.NO_PESSOA," &
                      "TPCST.NO_TIPO_CONSULTA," &
                      "OPCAO_STATU.NO_OPCAO NO_OPT_STATUS," &
                      "ISNULL(CVDPC.VL_PROCEDIMENTO, 0) VL_PROCEDIMENTO," &
                      "ISNULL(CVDPC.VL_REPASSE, 0) VL_REPASSE" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                " INNER JOIN TB_AGENDAMENTO	AGEND ON AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                " INNER JOIN TB_CLINICA_VENDA_PROCEDIMENTO CVDPC ON CVDPC.ID_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                " INNER JOIN TB_TIPO_CONSULTA	TPCST ON TPCST.SQ_TIPO_CONSULTA = AGEND.ID_TIPO_CONSULTA" &
                " INNER JOIN TB_OPCAO OPCAO_STATU ON OPCAO_STATU.SQ_OPCAO = CLATD.ID_OPT_STATUS" &
               " WHERE CLATD.ID_PESSOA_PROFISSIONAL = " & iID_USUARIO

    If IsDate(txtPeriodoInicial.Text) Then
      sSqlText = sSqlText & " AND CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) >= " & FNC_QuotedStr(txtPeriodoInicial.Text)
    End If
    If IsDate(txtPeriodoFinal.Text) Then
      sSqlText = sSqlText & " AND CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) <= " & FNC_QuotedStr(txtPeriodoFinal.Text)
    End If
    If psqPessoa.ID_Pessoa > 0 Then
      sSqlText = sSqlText & " AND CLATD.ID_PESSOA = " & psqPessoa.ID_Pessoa
    End If
    If ComboBox_Selecionado(cboTipoConsulta) Then
      sSqlText = sSqlText & " AND AGEND.ID_TIPO_CONSULTA = " & cboTipoConsulta.SelectedValue
    End If
    If ComboBox_Selecionado(cboStatus) Then
      sSqlText = sSqlText & " AND CLATD.ID_OPT_STATUS = " & cboStatus.SelectedValue
    End If

    oData = DBQuery(sSqlText)

    If objDataTable_Vazio(oData) Then
      oAtendimentos = Nothing
    Else
      ReDim oAtendimentos(oData.Rows.Count - 1)

      iQuantidade = oData.Rows.Count

      For Each oRow As DataRow In oData.Rows
        oAtendimentos(iIndice) = New cAtendimentos()

        With oAtendimentos(iIndice)
          .iID_AGENDAMENTO = oRow.Item("ID_AGENDAMENTO")
          .Data = oRow.Item("DH_CLINICA_ATENDIMENTO")
          .Paciente = oRow.Item("NO_PESSOA")
          .TipoAtendimento = oRow.Item("NO_TIPO_CONSULTA")
          .Status = oRow.Item("NO_OPT_STATUS")
          .Valor = oRow.Item("VL_PROCEDIMENTO")
          .VlPrestador = oRow.Item("VL_REPASSE")

          dValorTotal = dValorTotal + .Valor
          dVlPrestadorTotal = dVlPrestadorTotal + .VlPrestador
        End With

        iIndice = iIndice + 1
      Next
    End If

    If oAtendimentos Is Nothing Then
      VScrollBar.Enabled = False
    Else
      VScrollBar.Enabled = (oAtendimentos.Length > 7)
      If oAtendimentos.Length - 7 > 0 Then VScrollBar.Maximum = oAtendimentos.Length - 6
    End If

    VScrollBar.Value = 1

    ListarAtendimentos()

    lblQuantidade.Text = iQuantidade
    lblValorTotal.Text = FormatCurrency(dValorTotal)
    lblVlPrestadorTotal.Text = FormatCurrency(dVlPrestadorTotal)
  End Sub

  Private Sub ListarAtendimentos()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    LimparAtendimentos()

    If Not oAtendimentos Is Nothing Then
      For iCont = VScrollBar.Value - 1 To VScrollBar.Value + 5
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Tag = oAtendimentos(iCont).iID_AGENDAMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = oAtendimentos(iCont).Data
          Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iLabel, 2))).Text = oAtendimentos(iCont).Paciente
          Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = oAtendimentos(iCont).TipoAtendimento
          Me.Controls(Me.Controls.IndexOfKey("lblStatus" + FNC_StrZero(iLabel, 2))).Text = oAtendimentos(iCont).Status
          Me.Controls(Me.Controls.IndexOfKey("lblValor" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oAtendimentos(iCont).Valor)
          Me.Controls(Me.Controls.IndexOfKey("lblVlPrestador" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oAtendimentos(iCont).VlPrestador)
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Tag = 0
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblStatus" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblValor" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblVlPrestador" + FNC_StrZero(iLabel, 2))).Text = ""
        End Try

        iLabel = iLabel + 1
      Next
    End If
  End Sub

  Private Sub LimparAtendimentos()
    For iCont = 1 To 7
      Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iCont, 2))).Tag = 0
      Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblStatus" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblValor" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblVlPrestador" + FNC_StrZero(iCont, 2))).Text = ""
    Next

    lblQuantidade.Text = "0"
    lblValorTotal.Text = FormatCurrency(0)
    lblVlPrestadorTotal.Text = FormatCurrency(0)
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    ListarAtendimentos()
  End Sub
End Class