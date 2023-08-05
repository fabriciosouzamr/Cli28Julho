Public Class frmConsultaAtendimentosRealizados
  Class cAtendimentoRealizado
    Public ID_AGENDAMENTO As Integer
    Public CD_CLINICA_VENDA As String
    Public DH_CLINICA_ATENDIMENTO As String
    Public NO_PESSOA_PROFISSIONAL As String
    Public NO_PESSOA As String
    Public NO_TIPO_CONSULTA As String
    Public VL_PROCEDIMENTO As Double
  End Class

  Dim oAtendimentoRealizado() As cAtendimentoRealizado

  Private Sub frmConsultaAtendimentosRealizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cmdImprimir.Formatar(enOpcoes.ConfiguracaoTela_Botao_Imprimir)
    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)
    cmdListar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Listar)

    ComboBox_Carregar(cboMedico, enSql.Profissional)
    ComboBox_Carregar(cboTipoConsulta, enSql.Tipo_Consulta)

    lblQtde.Text = "0"
    lblTotal.Text = FormatCurrency(0)

    LimparAtendimentos()

    VScrollBar.SmallChange = 1
    VScrollBar.LargeChange = 1
  End Sub

  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_AtendimentosRealizados_Consulta))
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
    Dim sSqlText_Where As String = ""
    Dim iIndice As Integer
    Dim dValor As Double

    LimparAtendimentos()

    sSqlText = "SELECT CLVND.CD_CLINICA_VENDA," &
                      "CLATD.DH_CLINICA_ATENDIMENTO," &
                      "PESSO_PROFI.NO_PESSOA NO_PESSOA_PROFISSIONAL," &
                      "PESSO.NO_PESSOA NO_PESSOA," &
                      "TPCST.NO_TIPO_CONSULTA," &
                      "CLATD.VL_PROCEDIMENTO," &
                      "CLATD.ID_AGENDAMENTO" &
               " FROM TB_CLINICA_ATENDIMENTO CLATD" &
                " INNER JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                 " LEFT JOIN TB_CLINICA_VENDA_PROCEDIMENTO CLVCN ON CLVCN.ID_AGENDAMENTO = CLATD.ID_AGENDAMENTO" &
                 " LEFT JOIN TB_CLINICA_VENDA	CLVND ON CLVND.SQ_CLINICA_VENDA = CLVCN.ID_CLINICA_VENDA" &
                " INNER JOIN TB_PESSOA PESSO_PROFI ON PESSO_PROFI.SQ_PESSOA = CLATD.ID_PESSOA_PROFISSIONAL" &
                " INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CLATD.ID_PESSOA" &
                " INNER JOIN TB_TIPO_CONSULTA	TPCST ON TPCST.SQ_TIPO_CONSULTA = AGEND.ID_TIPO_CONSULTA"

    If ComboBox_Selecionado(cboMedico) Then
      FNC_Str_Adicionar(sSqlText_Where, "CLATD.ID_PESSOA_PROFISSIONAL = " & cboMedico.SelectedValue, " AND ")
    End If
    If psqPaciente.ID_Pessoa > 0 Then
      FNC_Str_Adicionar(sSqlText_Where, "CLATD.ID_PESSOA = " & psqPaciente.ID_Pessoa, " AND ")
    End If
    If ComboBox_Selecionado(cboTipoConsulta) Then
      FNC_Str_Adicionar(sSqlText_Where, "AGEND.ID_TIPO_CONSULTA = " & cboTipoConsulta.SelectedValue, " AND ")
    End If
    If IsDate(txtDataInicial.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, "CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) >= " & FNC_QuotedStr(txtDataInicial.Text), " AND ")
    End If
    If IsDate(txtDataFinal.Text) Then
      FNC_Str_Adicionar(sSqlText_Where, "CAST(CLATD.DH_CLINICA_ATENDIMENTO AS DATE) <= " & FNC_QuotedStr(txtDataFinal.Text), " AND ")
    End If

    If Trim(sSqlText_Where) <> "" Then
      sSqlText = sSqlText & " WHERE " & sSqlText_Where
    End If

    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      ReDim oAtendimentoRealizado(oData.Rows.Count - 1)

      For Each oRow As DataRow In oData.Rows
        oAtendimentoRealizado(iIndice) = New cAtendimentoRealizado
        oAtendimentoRealizado(iIndice).ID_AGENDAMENTO = FNC_NVL(oRow.Item("ID_AGENDAMENTO"), 0)
        oAtendimentoRealizado(iIndice).CD_CLINICA_VENDA = FNC_NVL(oRow.Item("CD_CLINICA_VENDA"), "")
        oAtendimentoRealizado(iIndice).DH_CLINICA_ATENDIMENTO = oRow.Item("DH_CLINICA_ATENDIMENTO")
        oAtendimentoRealizado(iIndice).NO_PESSOA_PROFISSIONAL = oRow.Item("NO_PESSOA_PROFISSIONAL")
        oAtendimentoRealizado(iIndice).NO_PESSOA = oRow.Item("NO_PESSOA")
        oAtendimentoRealizado(iIndice).NO_TIPO_CONSULTA = FNC_NVL(oRow.Item("NO_TIPO_CONSULTA"), "")
        oAtendimentoRealizado(iIndice).VL_PROCEDIMENTO = oRow.Item("VL_PROCEDIMENTO")

        dValor = dValor + oAtendimentoRealizado(iIndice).VL_PROCEDIMENTO

        iIndice = iIndice + 1
      Next

      VScrollBar.Enabled = (oAtendimentoRealizado.Length > 7)
      If oAtendimentoRealizado.Length - 7 > 0 Then VScrollBar.Maximum = oAtendimentoRealizado.Length - 6

      ListarAtendimentos()
    End If

    VScrollBar.Value = 1

    lblQtde.Text = oData.Rows.Count
    lblTotal.Text = FormatCurrency(dValor)

    oData.Dispose()
  End Sub

  Private Sub LimparAtendimentos()
    For iCont = 1 To 7
      Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iCont, 2))).Tag = 0
      Me.Controls(Me.Controls.IndexOfKey("lblCodAutorizacao" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iCont, 2))).Text = ""
      Me.Controls(Me.Controls.IndexOfKey("lblValor" + FNC_StrZero(iCont, 2))).Text = ""
    Next
  End Sub

  Private Function Atendimentos_Carregado() As Boolean
    If oAtendimentoRealizado Is Nothing Then
      Return False
    Else
      Return (oAtendimentoRealizado.Count > 0)
    End If
  End Function

  Private Sub ListarAtendimentos()
    Dim iCont As Integer
    Dim iLabel As Integer = 1

    If Atendimentos_Carregado() Then
      For iCont = VScrollBar.Value - 1 To VScrollBar.Value + 5
        Try
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Tag = oAtendimentoRealizado(iCont).ID_AGENDAMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblCodAutorizacao" + FNC_StrZero(iLabel, 2))).Text = oAtendimentoRealizado(iCont).CD_CLINICA_VENDA
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = oAtendimentoRealizado(iCont).DH_CLINICA_ATENDIMENTO
          Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iLabel, 2))).Text = oAtendimentoRealizado(iCont).NO_PESSOA_PROFISSIONAL
          Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iLabel, 2))).Text = oAtendimentoRealizado(iCont).NO_PESSOA
          Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = oAtendimentoRealizado(iCont).NO_TIPO_CONSULTA
          Me.Controls(Me.Controls.IndexOfKey("lblValor" + FNC_StrZero(iLabel, 2))).Text = FormatCurrency(oAtendimentoRealizado(iCont).VL_PROCEDIMENTO)
        Catch ex As Exception
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Tag = 0
          Me.Controls(Me.Controls.IndexOfKey("lblCodAutorizacao" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblData" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblMedico" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblPaciente" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblTipoAtendimento" + FNC_StrZero(iLabel, 2))).Text = ""
          Me.Controls(Me.Controls.IndexOfKey("lblValor" + FNC_StrZero(iLabel, 2))).Text = ""
        End Try

        iLabel = iLabel + 1
      Next
    End If
  End Sub

  Private Sub VScrollBar_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar.Scroll
    ListarAtendimentos()
  End Sub

  Private Sub lblData_DoubleClick(sender As Object, e As EventArgs) Handles lblData01.DoubleClick, lblData02.DoubleClick, lblData03.DoubleClick,
                                                                            lblData04.DoubleClick, lblData05.DoubleClick, lblData06.DoubleClick,
                                                                            lblData07.DoubleClick
    Dim oLabel As Label

    oLabel = sender

    CarregarAtendimento(oLabel.Name.Substring(Len("lblData")))
  End Sub

  Private Sub lblMedico_DoubleClick(sender As Object, e As EventArgs) Handles lblMedico01.DoubleClick, lblMedico02.DoubleClick, lblMedico03.DoubleClick,
                                                                              lblMedico04.DoubleClick, lblMedico05.DoubleClick, lblMedico06.DoubleClick,
                                                                              lblMedico07.DoubleClick
    Dim oLabel As Label

    oLabel = sender

    CarregarAtendimento(oLabel.Name.Substring(Len("lblMedico")))
  End Sub

  Private Sub lblPaciente_DoubleClick(sender As Object, e As EventArgs) Handles lblPaciente01.DoubleClick, lblPaciente02.DoubleClick, lblPaciente03.DoubleClick,
                                                                                lblPaciente04.DoubleClick, lblPaciente05.DoubleClick, lblPaciente06.DoubleClick,
                                                                                lblPaciente07.DoubleClick
    Dim oLabel As Label

    oLabel = sender

    CarregarAtendimento(oLabel.Name.Substring(Len("lblPaciente")))
  End Sub

  Private Sub lblTipoAtendimento_DoubleClick(sender As Object, e As EventArgs) Handles lblTipoAtendimento01.DoubleClick, lblTipoAtendimento02.DoubleClick,
                                                                                       lblTipoAtendimento03.DoubleClick, lblTipoAtendimento04.DoubleClick,
                                                                                       lblTipoAtendimento05.DoubleClick, lblTipoAtendimento06.DoubleClick,
                                                                                       lblTipoAtendimento07.DoubleClick
    Dim oLabel As Label

    oLabel = sender

    CarregarAtendimento(oLabel.Name.Substring(Len("lblTipoAtendimento")))
  End Sub

  Private Sub lblCodAutorizacao_DoubleClick(sender As Object, e As EventArgs) Handles lblCodAutorizacao01.DoubleClick, lblCodAutorizacao02.DoubleClick,
                                                                                      lblCodAutorizacao03.DoubleClick, lblCodAutorizacao04.DoubleClick,
                                                                                      lblCodAutorizacao05.DoubleClick, lblCodAutorizacao06.DoubleClick,
                                                                                      lblCodAutorizacao07.DoubleClick
    Dim oLabel As Label

    oLabel = sender

    CarregarAtendimento(oLabel.Name.Substring(Len("lblCodAutorizacao")))
  End Sub

  Private Sub lblValor_DoubleClick(sender As Object, e As EventArgs) Handles lblValor01.DoubleClick, lblValor02.DoubleClick, lblValor03.DoubleClick,
                                                                             lblValor04.DoubleClick, lblValor05.DoubleClick, lblValor06.DoubleClick,
                                                                             lblValor07.DoubleClick
    Dim oLabel As Label

    oLabel = sender

    CarregarAtendimento(oLabel.Name.Substring(Len("lblValor")))
  End Sub

  Private Sub CarregarAtendimento(sCodigo As String)
    Dim iID_AGENDAMENTO As Integer
    Dim oLabel As Label

    oLabel = Me.Controls("lblData" + sCodigo)
    iID_AGENDAMENTO = oLabel.Tag

    Dim oForm As New frmCadastroAtendimento

    oForm.Formatar()
    oForm.iID_AGENDAMENTO = iID_AGENDAMENTO
    oForm.bEditar = False

    FNC_AbriTela(oForm)
  End Sub
End Class