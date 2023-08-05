Public Class frmCadastroPessoaSimples
  Public iSQ_PESSOA As Integer = 0  Public iSQ_ENDERECO As Integer = 0  Public bAdicionarSomenteEndereco As Boolean  Public bGravado As Boolean = False
  Public bIC_CLIENTE As Boolean
  Public bIC_FORNECEDOR As Boolean

  Public sNO_PESSOA As String
  Public sCD_TELEFONE As String
  Public sCD_CELULAR As String

  Dim iSQ_PESSOA_TELEFONE As Integer
  Dim iSQ_PESSOA_MIDIASOCIAL_EMAIL As Integer
  Dim iSQ_PESSOA_MIDIASOCIAL_WEBSITE As Integer

  Private Sub frmCadastroPessoaSimples_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    lblStatus.Text = ""
    lblCPF_CNPJ.Visible = False
    txtCPF_CNPJ.Visible = False

    ComboBox_Carregar(cboTipoPessoa, enSql.TipoPessoa)
    ComboBox_Carregar(cboTipoContribuicaoICMS, enSql.NFe_IndicadorIEDestinatario)

    cboTipoPessoa.SelectedIndex = 0
    HabilitarControle(Not bAdicionarSomenteEndereco, True)
    txtDataNascAbertura.Value = Nothing

    txtNomePessoa.Text = sNO_PESSOA
    txtTelefone.Text = sCD_TELEFONE
    txtCelular.Text = sCD_CELULAR

    ComboBox_Selecionar(cboTipoContribuicaoICMS, enOpcoes.NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS.GetHashCode)
    ComboBox_TipoContribuicaoICMS_Tratar()

    If iSQ_PESSOA > 0 Then
      CarregarDados()
    End If
  End Sub

  Private Sub cboTipoPessoa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPessoa.SelectedIndexChanged
    If cboTipoPessoa.SelectedIndex < 0 Then Exit Sub
    If cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode Then
      lblDataNascAbertura.Text = "Data de Nascimento"
      lblCPF_CNPJ.Text = "C.P.F."
      txtCPF_CNPJ.InputMask = const_Mascara_CPF

      txtInscricaoMunicipal.Text = ""
      txtInscricaoEstadual.Text = ""
      cboTipoContribuicaoICMS.SelectedIndex = -1
    ElseIf cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Juridico.GetHashCode Then
      lblDataNascAbertura.Text = "Data de Abertura"
      lblCPF_CNPJ.Text = "C.N.P.J."
      txtCPF_CNPJ.InputMask = const_Mascara_CNPJ
    End If

    lblRInscriçãoMunicipal.Enabled = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)
    txtInscricaoMunicipal.Enabled = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)
    lblRInscricaoEstaudal.Enabled = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)
    txtInscricaoEstadual.Enabled = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)
    lblRTipoContribuicaoICMS.Enabled = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)
    cboTipoContribuicaoICMS.Enabled = (cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode)

    lblCPF_CNPJ.Visible = True
    txtCPF_CNPJ.Visible = True
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Not ComboBox_Selecionado(cboTipoPessoa) Then
      FNC_Mensagem("Selecione o tipo de pessoa")
      Exit Sub
    End If
    If Trim(FNC_SoNumero(txtCPF_CNPJ.Text)) = "" Then
      FNC_Mensagem("Informe o " & lblCPF_CNPJ.Text)
      Exit Sub
    End If
    If Trim(txtNomePessoa.Text) = "" Then
      FNC_Mensagem("Informe o nome da pessoa")
      Exit Sub
    End If
    If FNC_Busca_CPF_CNPJ_Identificar(txtCPF_CNPJ.Text, iSQ_PESSOA, IIf(FNC_In(Trim(FNC_SoNumero(txtCPF_CNPJ.Text)), "00000000000000", "00000000000"), txtNomePessoa.Text, "")) > 0 Then
      FNC_Mensagem("C.P.F./C.N.P.J. já cadastrado para outra pessoa, favor pesquisá-lo")
      Exit Sub
    End If
    If Trim(txtLogradouro.Text) <> "" Or Trim(txtBairro.Text) <> "" Or ComboBox_Selecionado(cboCidade) Or Trim(FNC_SoNumero(txtCEP.Text)) <> "" Then
      If Trim(txtLogradouro.Text) = "" Or Trim(txtBairro.Text) = "" Or Not ComboBox_Selecionado(cboCidade) Then
        FNC_Mensagem("Se for informar o endereço é necessário informar completo")
        Exit Sub
      End If
    End If

    If FormCadastroPessoa_GravarPessoa(iSQ_PESSOA,
                                       FNC_TextoPrimeiraMaiuscula(txtNomePessoa.Text),
                                       Nothing,
                                       txtDataNascAbertura.Value,
                                       cboTipoPessoa.SelectedValue,
                                       picFoto.ArquivoGravacao,
                                       FNC_SoNumero(txtCPF_CNPJ.Value),
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       0,
                                       FNC_NVL(cboTipoContribuicaoICMS.SelectedValue, 0),
                                       0,
                                       "",
                                       "",
                                       txtNomeFantasiaReduzido.Text,
                                       txtInscricaoEstadual.Text,
                                       txtInscricaoMunicipal.Text,
                                       enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode) Then

      If Trim(txtLogradouro.Text) <> "" Then
        FormPesquisaPessoa_GravarEndereco(iSQ_ENDERECO,
                                          iSQ_PESSOA,
                                          IIf(cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode,
                                              enTipoEndereco.Residencial.GetHashCode,
                                              enTipoEndereco.Comercial.GetHashCode),
                                          cboCidade.SelectedValue,
                                          txtLogradouro.Text,
                                          txtBairro.Text,
                                          txtNumero.Value,
                                          txtComplementoEndereco.Text,
                                          txtCEP.Text,
                                          "S")
      End If
      If Trim(FNC_SoNumero(txtTelefone.Text)) <> "" Then
        FormPesquisaPessoa_GravarTelefone(iSQ_PESSOA_TELEFONE,
                                          iSQ_PESSOA,
                                          IIf(cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode,
                                              enTipoTelefone.Residencial.GetHashCode,
                                              enTipoTelefone.Comercial.GetHashCode),
                                          txtTelefone.Text,
                                          False)
      End If
      If Trim(FNC_SoNumero(txtCelular.Text)) <> "" Then
        FormPesquisaPessoa_GravarTelefone(0,
                                          iSQ_PESSOA,
                                          enTipoTelefone.Celular.GetHashCode,
                                          txtCelular.Text, "", chkWhatsapp.Checked)
      End If
      If Trim(txtEMail.Text) <> "" Then
        FormPesquisaPessoa_GravarMidiaSocial(iSQ_PESSOA_MIDIASOCIAL_EMAIL,
                                             iSQ_PESSOA,
                                             enTipoMidiaSocial.EMail.GetHashCode,
                                             txtEMail.Text)
      End If
      If Trim(txtWebSite.Text) <> "" Then
        FormPesquisaPessoa_GravarMidiaSocial(iSQ_PESSOA_MIDIASOCIAL_EMAIL,
                                             iSQ_PESSOA,
                                             enTipoMidiaSocial.WebSite.GetHashCode,
                                             txtWebSite.Text)
      End If
      If bIC_CLIENTE Then
        FormPesquisaPessoa_GravarCliente(iSQ_PESSOA)
      End If
      If bIC_FORNECEDOR Then
        FormPesquisaPessoa_GravarForencedor(iSQ_PESSOA)
      End If

      bGravado = True

      FNC_Mensagem("Cadastro Efetuado")

      Close()
    End If
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT PES.NO_PESSOA," &
                      "PES.ID_TIPO_PESSOA," &
                      "dbo.FC_FormatarCPF_CNPJ(PES.CD_CPF_CNPJ) CD_CPF_CNPJ," &
                      "PES.NO_FANTASIA_REDUZIDO," &
                      "PES.DT_NASC_ABERTURA," &
                      "PES.CD_PJ_IE," &
                      "PES.CD_PJ_IM," &
                      "PES.DS_PATH_IMAGEM," &
                      "EML.SQ_PESSOA_MIDIASOCIAL SQ_PESSOA_MIDIASOCIAL_EMAIL," &
                      "EML.DS_MIDIASOCIAL DS_MIDIASOCIAL_EMAIL," &
                      "WBS.SQ_PESSOA_MIDIASOCIAL SQ_PESSOA_MIDIASOCIAL_WEBSITE," &
                      "WBS.DS_MIDIASOCIAL DS_MIDIASOCIAL_WEBSITE" &
               " FROM TB_PESSOA PES" &
                " LEFT JOIN VW_PESSOA_MIDIASOCIAL_EMAIL EML ON EML.ID_PESSOA = PES.SQ_PESSOA" &
                " LEFT JOIN VW_PESSOA_MIDIASOCIAL_WEBSITE WBS ON WBS.ID_PESSOA = PES.SQ_PESSOA" &
               " WHERE PES.SQ_PESSOA = " & iSQ_PESSOA
    oData = DBQuery(sSqlText)

    If oData.Rows.Count > 0 Then
      With oData.Rows(0)
        ComboBox_Selecionar(cboTipoPessoa, .Item("ID_TIPO_PESSOA"))
        txtNomePessoa.Text = .Item("NO_PESSOA")
        txtCPF_CNPJ.Text = .Item("CD_CPF_CNPJ")
        If Not FNC_CampoNulo(.Item("DT_NASC_ABERTURA")) Then
          txtDataNascAbertura.Value = .Item("DT_NASC_ABERTURA")
        End If
        txtEMail.Text = FNC_NVL(.Item("DS_MIDIASOCIAL_EMAIL"), "")
        txtWebSite.Text = FNC_NVL(.Item("DS_MIDIASOCIAL_WEBSITE"), "")
        iSQ_PESSOA_MIDIASOCIAL_EMAIL = FNC_NVL(.Item("SQ_PESSOA_MIDIASOCIAL_EMAIL"), 0)
        iSQ_PESSOA_MIDIASOCIAL_WEBSITE = FNC_NVL(.Item("SQ_PESSOA_MIDIASOCIAL_WEBSITE"), 0)
        picFoto.Arquivo = .Item("DS_PATH_IMAGEM")
      End With

      sSqlText = "SELECT * " &
                 " FROM TB_PESSOA_TELEFONE" &
                 " WHERE ID_PESSOA = " & iSQ_PESSOA &
                    "AND ID_TIPO_TELEFONE = " & enTipoTelefone.Comercial.GetHashCode
      oData = DBQuery(sSqlText)

      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          iSQ_PESSOA_TELEFONE = .Item("SQ_PESSOA_TELEFONE")
          txtTelefone.Text = FNC_NVL(.Item("CD_NUMERO"), "")
        End With
      End If

      sSqlText = "SELECT * " &
                 " FROM TB_PESSOA_TELEFONE" &
                 " WHERE ID_PESSOA = " & iSQ_PESSOA &
                    "AND ID_TIPO_TELEFONE = " & enTipoTelefone.Celular.GetHashCode
      oData = DBQuery(sSqlText)

      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          iSQ_PESSOA_TELEFONE = .Item("SQ_PESSOA_TELEFONE")
          txtTelefone.Text = FNC_NVL(.Item("CD_NUMERO"), "")
        End With
      End If

      sSqlText = "SELECT * " &
                 " FROM VW_ENDERECO_PRIMEIRO" &
                 " WHERE ID_PESSOA = " & iSQ_PESSOA &
                    "AND ID_TIPO_ENDERECO = " & IIf(cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode(),
                                                    enTipoEndereco.Residencial.GetHashCode(),
                                                    enTipoEndereco.Comercial.GetHashCode())
      oData = DBQuery(sSqlText)

      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          iSQ_ENDERECO = .Item("SQ_ENDERECO")
          ComboBox_Selecionar(cboCidade, .Item("ID_CIDADE"))
          txtLogradouro.Text = FNC_NVL(.Item("DS_LOGRADOURO"), "")
          txtBairro.Text = FNC_NVL(.Item("NO_BAIRRO"), "")
          txtNumero.Value = FNC_NVL(.Item("NR_LOGRADOURO"), 0)
          txtComplementoEndereco.Text = FNC_NVL(.Item("DS_COMPLEMENTO"), "")
          txtCEP.Text = FNC_NVL(.Item("CD_CEP"), "")
        End With
      End If
    End If
  End Sub

  Private Sub HabilitarControle(bHabilitarDadosGerais As Boolean, bHabilitarDadosEndereco As Boolean)
    cboTipoPessoa.Enabled = bHabilitarDadosGerais
    txtCPF_CNPJ.Enabled = bHabilitarDadosGerais
    txtTelefone.Enabled = bHabilitarDadosGerais
    txtCelular.Enabled = bHabilitarDadosGerais
    chkWhatsapp.Enabled = bHabilitarDadosGerais
    txtNomePessoa.Enabled = bHabilitarDadosGerais
    txtDataNascAbertura.Enabled = bHabilitarDadosGerais

    txtLogradouro.Enabled = bHabilitarDadosEndereco
    txtBairro.Enabled = bHabilitarDadosEndereco
    cboCidade.Enabled = bHabilitarDadosEndereco
    txtCEP.Enabled = bHabilitarDadosEndereco
    txtNumero.Enabled = bHabilitarDadosEndereco
    txtComplementoEndereco.Enabled = bHabilitarDadosEndereco

    txtEMail.Enabled = bHabilitarDadosGerais
    txtWebSite.Enabled = bHabilitarDadosGerais
    picFoto.Enabled = bHabilitarDadosGerais
  End Sub

  Private Sub cboTipoContribuicaoICMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoContribuicaoICMS.SelectedIndexChanged
    ComboBox_TipoContribuicaoICMS_Tratar()
  End Sub

  Private Sub ComboBox_TipoContribuicaoICMS_Tratar()
    Select Case Val(cboTipoContribuicaoICMS.SelectedValue)
      Case enOpcoes.NFe_IndicadorIEDestinatario_ContribuinteICMS.GetHashCode()
        txtInscricaoEstadual.Enabled = True
      Case enOpcoes.NFe_IndicadorIEDestinatario_ContribuinteIsentoInscricaoCadastroContribuintesICMS.GetHashCode()
        txtInscricaoEstadual.Text = "ISENTO"
        txtInscricaoEstadual.Enabled = False
      Case enOpcoes.NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS.GetHashCode()
        txtInscricaoEstadual.Text = ""
        txtInscricaoEstadual.Enabled = False
    End Select
  End Sub

  'Private Sub txtCPF_CNPJ_LostFocus(sender As Object, e As EventArgs) Handles txtCPF_CNPJ.LostFocus
  '  Dim iRet As Integer

  '  iRet = FNC_Busca_CPF_CNPJ_Identificar(txtCPF_CNPJ.Text)

  '  If iRet <> iSQ_PESSOA And iSQ_PESSOA = 0 Then
  '    iSQ_PESSOA = iRet
  '    CarregarDados()
  '  End If
  'End Sub
End Class