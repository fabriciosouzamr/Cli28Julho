Public Class frmCadastroPaciente
  Public Event Pesquisar()

  Public sNO_PESSOA As String
  Public sCD_TELEFONE As String
  Public sCD_CELULAR As String
  Public bFecharAposGravacao As Boolean

  Public bGravado As Boolean

  Dim iID_PACIENTE As Integer
  Dim bFormatado As Boolean = False

  Private Sub oPaciente_Fechar()
    Close()
  End Sub

  Private Sub frmCadastroPaciente_Load(sender As Object, e As EventArgs) Handles Me.Load
    If Not bFormatado Then Formatar()
  End Sub

  Public Sub Formatar()
    bFormatado = True

    Try
      oPaciente.BotaoFechar = True
      oPaciente.BotaoGerarConsultas = False
      oPaciente.sNO_PESSOA = sNO_PESSOA
      oPaciente.sCD_TELEFONE = sCD_TELEFONE
      oPaciente.sCD_CELULAR = sCD_CELULAR
      oPaciente.Formatar()
      oPaciente.ExibirHistorico = True

      Novo()

      If iID_PACIENTE > 0 Then
        'oPaciente.Identificador = iID_PACIENTE
        'oPaciente.BotaoNovo = False
        'oPaciente.CarregarDados()
      End If
    Catch ex As Exception
      FNC_Mensagem("frmCadastroPaciente (Load) - " & ex.Message)
    End Try
  End Sub

  Public Property SomenteCadastro
    Get
      Return oPaciente.ComboPaciente
    End Get
    Set(value)
      oPaciente.ComboPaciente = value
    End Set
  End Property

  Public Property ID_PACIENTE As Integer
    Get
      Return iID_PACIENTE
    End Get
    Set(value As Integer)
      iID_PACIENTE = value
      oPaciente.Identificador = iID_PACIENTE
      oPaciente.BotaoNovo = False
      oPaciente.CarregarDados()
    End Set
  End Property

  Private Sub oPaciente_DadosCarregado() Handles oPaciente.DadosCarregado
    If FNC_Permissao(enPermissao.PERM_AcessoAnamneseEvolucao).bPermissao Then
      If Not tabGeral.TabPages.Contains(tabEvolucao) Then tabGeral.TabPages.Add(tabEvolucao)
      If Not tabGeral.TabPages.Contains(tabGuiaAnamnese) Then tabGeral.TabPages.Add(tabGuiaAnamnese)
    End If

    If Not tabGeral.TabPages.Contains(tabImpressoes) Then tabGeral.TabPages.Add(tabImpressoes)
    If Not tabGeral.TabPages.Contains(tabAnexo) Then tabGeral.TabPages.Add(tabAnexo)

    iID_PACIENTE = oPaciente.Identificador
    oImpressoes.CadastroOrigem = uscImpressoes.enCadastroOrigem.CadastroPessoa
    oImpressoes.iID_PESSOA = oPaciente.Identificador
    oImpressoes.Carregar()
    oAnexo.iID_PESSOA = oPaciente.Identificador
    oAnexo.Carregar()

    If oPaciente.Identificador > 0 Then
      ComboBox_CarregarAnamneseEvolucao(cboAnamneseGeradas, oPaciente.Identificador, enOpcoes.TipoModeloDocumento_Anamnese)

      If cboAnamneseGeradas.Items.Count = 0 Then
        pnlEvolucaoControle.Enabled = False
        pnlEvolucaoEditor.Enabled = False
        oEditorEvolucao.Limpar()
        cboEvolucao.DataSource = Nothing
      Else
        pnlEvolucaoControle.Enabled = True
        pnlEvolucaoEditor.Enabled = True
        oEditorEvolucao.Enabled = False

        ComboBox_CarregarAnamneseEvolucao(cboEvolucao, oPaciente.Identificador, enOpcoes.TipoModeloDocumento_Evolucao)
      End If
    End If
  End Sub

  Private Sub oPaciente_Fechar1() Handles oPaciente.Fechar
    Close()
  End Sub

  Private Sub oPaciente_GravacaoEfetuada() Handles oPaciente.GravacaoEfetuada
    'RaiseEvent Pesquisar()
    bGravado = True
    sNO_PESSOA = oPaciente.sNO_PESSOA
    If bFecharAposGravacao Then Close()
  End Sub

  Private Sub cboAnamneseGeradas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAnamneseGeradas.SelectedIndexChanged
    Dim oItemComboBox As Object

    If ComboBox_Selecionado(cboAnamneseGeradas) Then
      oItemComboBox = cboAnamneseGeradas.SelectedItem

      FormLancamentoAtendimentoMedico_TABAnamnese_Carregar(pnlAnamneseContainer, _
                                                           IIf(FNC_CampoNulo(oItemComboBox(enComboBox_AnamneseEvolucao.ID_QUESTIONARIO)), const_Anamnese_ModeloDocumento, const_Anamnese_Formulario), _
                                                           FNC_NVL(oItemComboBox(enComboBox_AnamneseEvolucao.ID_QUESTIONARIO), 0), _
                                                           FNC_NVL(oItemComboBox(enComboBox_AnamneseEvolucao.ID_QUESTIONARIO_VERSAO), 0), _
                                                           FNC_NVL(oItemComboBox(enComboBox_AnamneseEvolucao.ID_QUESTIONARIO_RESPOSTA), 0), _
                                                           0, _
                                                           FNC_NVL(oItemComboBox(enComboBox_AnamneseEvolucao.TX_ANAMNESE), ""), _
                                                           False, _
                                                           "Anamnese realizada em " & oItemComboBox(enComboBox_AnamneseEvolucao.DT_ANAMNESE).ToString & ", por " & _
                                                                                      oItemComboBox(enComboBox_AnamneseEvolucao.NO_PESSOA_PROFISSIONAL))
    Else
      pnlAnamneseContainer.Controls.Clear()
    End If

    AnamneseControle_Habilitar(Not ComboBox_Selecionado(cboAnamneseGeradas))
  End Sub

  Private Sub cboEvolucao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEvolucao.SelectedIndexChanged
    If ComboBox_Selecionado(cboEvolucao) Then
      Dim sSqlText As String

      sSqlText = "SELECT TX_ANAMNESE FROM TB_ANAMNESE WHERE SQ_ANAMNESE = " & cboEvolucao.SelectedValue
      oEditorEvolucao.Inicializar()
      oEditorEvolucao.Rtf = DBQuery_ValorUnico(sSqlText)
    Else
      oEditorEvolucao.Limpar()
    End If

    oEditorEvolucao.Enabled = ComboBox_Selecionado(cboEvolucao)
  End Sub

  Private Sub AnamneseControle_Habilitar(bHabilitar As Boolean)
    pnlAnamneseControle.Enabled = True
    cboAnamneseGeradas.Enabled = bHabilitar
  End Sub

  Private Sub oPaciente_Novo() Handles oPaciente.Novo
    Novo()
  End Sub

  Private Sub Novo()
    oEditorEvolucao.Limpar()
    oAnexo.Inicializar()
    oImpressoes.Limpar()
    cboAnamneseGeradas.DataSource = Nothing
    pnlAnamneseContainer.Controls.Clear()
    cboEvolucao.DataSource = Nothing

    If tabGeral.TabPages.Contains(tabEvolucao) Then tabGeral.TabPages.Remove(tabEvolucao)
    If tabGeral.TabPages.Contains(tabGuiaAnamnese) Then tabGeral.TabPages.Remove(tabGuiaAnamnese)

    If tabGeral.TabPages.Contains(tabImpressoes) Then tabGeral.TabPages.Remove(tabImpressoes)
    If tabGeral.TabPages.Contains(tabAnexo) Then tabGeral.TabPages.Remove(tabAnexo)
  End Sub

  Private Sub frmCadastroPaciente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    oPaciente.Finalizar()
  End Sub
End Class