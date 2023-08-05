Public Class frmCadastroPessoaSimples
  Public iSQ_PESSOA As Integer = 0  Public iSQ_ENDERECO As Integer = 0  Public bAdicionarSomenteEndereco As Boolean  Public bGravado As Boolean = False

  Dim iSQ_PESSOA_TELEFONE As Integer
  Dim iSQ_PESSOA_MIDIASOCIAL_EMAIL As Integer
  Dim iSQ_PESSOA_MIDIASOCIAL_WEBSITE As Integer

  Private Sub frmCadastroPessoaSimples_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    lblCPF_CNPJ.Visible = False
    txtCPF_CNPJ.Visible = False
    ComboBox_Carregar(cboTipoPessoa, enComboBox.TipoPessoa)
    cboTipoPessoa.SelectedIndex = 0
    HabilitarControle(Not bAdicionarSomenteEndereco, True)
  End Sub

  Private Sub cboTipoPessoa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPessoa.SelectedIndexChanged
    If cboTipoPessoa.SelectedIndex < 0 Then Exit Sub
    If cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Fisico.GetHashCode Then
      lblDataNascAbertura.Text = "Data de Nascimento"
      lblCPF_CNPJ.Text = "C.P.F."
      txtCPF_CNPJ.InputMask = const_Mascara_CPF
    ElseIf cboTipoPessoa.SelectedItem(enCombox_TipoPessoa_Campos.SQ_OPT_FISICO_JURIDICO) = enOpcoes.FisicoJuridico_Juridico.GetHashCode Then
      lblDataNascAbertura.Text = "Data de Abertura"
      lblCPF_CNPJ.Text = "C.N.P.J."
      txtCPF_CNPJ.InputMask = const_Mascara_CNPJ
    End If

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
    If FormPesquisaPessoa_CNPJ_CPF_Existente(txtCPF_CNPJ.Text) Then
      FNC_Mensagem(lblCPF_CNPJ.Text & " já cadastrado, favor pesquisá-lo")
      Exit Sub
    End If
    If Trim(txtLogradouro.Text) <> "" Or Trim(txtBairro.Text) <> "" Or ComboBox_Selecionado(cboCidade) Or Trim(FNC_SoNumero(txtCEP.Text)) <> "" Then
      If Trim(txtLogradouro.Text) = "" Or Trim(txtBairro.Text) = "" Or Not ComboBox_Selecionado(cboCidade) Or Trim(FNC_SoNumero(txtCEP.Text)) = "" Then
        FNC_Mensagem("Se for informar o endereço é necessário informar completo")
        Exit Sub
      End If
    End If

    If FormCadastroPessoa_GravarPessoa(iSQ_PESSOA, _
                                       txtNomePessoa.Text, _
                                       txtDataNascAbertura.Value, _
                                       cboTipoPessoa.SelectedValue, _
                                       picFoto.ArquivoGravacao, _
                                       FNC_SoNumero(txtCPF_CNPJ.Value), _
                                       0, _
                                       0, _
                                       0, _
                                       0, _
                                       0, _
                                       0, _
                                       0, _
                                       0, _
                                       0, _
                                       "", _
                                       "", _
                                       txtNomeFantasiaReduzido.Text, _
                                       "", _
                                       "", _
                                       enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode) Then

      If Trim(txtLogradouro.Text) <> "" Then
        FormPesquisaPessoa_GravarEndereco(iSQ_ENDERECO, _
                                          iSQ_PESSOA, _
                                          enTipoEndereco.Comercial.GetHashCode, _
                                          cboCidade.SelectedValue, _
                                          txtLogradouro.Text, _
                                          txtBairro.Text, _
                                          txtNumero.Value, _
                                          txtComplementoEndereco.Text, _
                                          txtCEP.Text, _
                                          "S")
      End If
      If Trim(FNC_SoNumero(txtTelefone.Text)) <> "" Then
        FormPesquisaPessoa_GravarTelefone(iSQ_PESSOA_TELEFONE, _
                                          iSQ_PESSOA, _
                                          enTipoTelefone.Comercial.GetHashCode, _
                                          txtTelefone.Text, _
                                          True)
      End If
      If Trim(FNC_SoNumero(txtCelular.Text)) <> "" Then
        FormPesquisaPessoa_GravarTelefone(0, _
                                          iSQ_PESSOA, _
                                          enTipoTelefone.Celular.GetHashCode, _
                                          txtCelular.Text, _
                                          chkWhatsapp.Checked)
      End If
      If Trim(txtEMail.Text) <> "" Then
        FormPesquisaPessoa_GravarMidiaSocial(iSQ_PESSOA_MIDIASOCIAL_EMAIL, _
                                             iSQ_PESSOA,
                                             enTipoMidiaSocial.EMail.GetHashCode, _
                                             txtEMail.Text)
      End If
      If Trim(txtWebSite.Text) <> "" Then
        FormPesquisaPessoa_GravarMidiaSocial(iSQ_PESSOA_MIDIASOCIAL_EMAIL, _
                                             iSQ_PESSOA,
                                             enTipoMidiaSocial.WebSite.GetHashCode, _
                                             txtWebSite.Text)
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

    sSqlText = "SELECT PES.NO_PESSOA," & _
                      "dbo.FC_FormatarCPF_CNPJ(PES.CD_CPF_CNPJ) CD_CPF_CNPJ," & _
                      "PES.NO_FANTASIA_REDUZIDO," & _
                      "PES.DT_NASC_ABERTURA," & _
                      "PES.CD_PJ_IE," & _
                      "PES.CD_PJ_IM," & _
                      "EMP.ID_TABELAPRECO_PADRAO," & _
                      "EMP.DS_PATH_REPOSITORIO_ARQUIVO," & _
                      "PES.DS_PATH_IMAGEM," & _
                      "EML.SQ_PESSOA_MIDIASOCIAL SQ_PESSOA_MIDIASOCIAL_EMAIL," & _
                      "WBS.SQ_PESSOA_MIDIASOCIAL SQ_PESSOA_MIDIASOCIAL_WEBSITE," & _
                      "EML.DS_MIDIASOCIAL DS_MIDIASOCIAL_EMAIL," & _
                      "WBS.DS_MIDIASOCIAL DS_MIDIASOCIAL_WEBSITE" & _
                    " FROM TB_PESSOA PES" & _
                     " INNER JOIN TB_EMPRESA EMP ON EMP.ID_EMPRESA = PES.SQ_PESSOA" & _
                      " LEFT JOIN VW_PESSOA_MIDIASOCIAL_EMAIL EML ON EML.ID_PESSOA = PES.SQ_PESSOA" & _
                      " LEFT JOIN VW_PESSOA_MIDIASOCIAL_WEBSITE WBS ON WBS.ID_PESSOA = PES.SQ_PESSOA" & _
                    " WHERE PES.SQ_PESSOA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    If oData.Rows.Count > 0 Then
      With oData.Rows(0)
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

      sSqlText = "SELECT * " & _
                 " FROM TB_PESSOA_TELEFONE" & _
                 " WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL & _
                    "AND ID_TIPO_TELEFONE = " & enTipoTelefone.Comercial.GetHashCode
      oData = DBQuery(sSqlText)

      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          iSQ_PESSOA_TELEFONE = .Item("SQ_PESSOA_TELEFONE")
          txtTelefone.Text = FNC_NVL(.Item("CD_NUMERO"), "")
        End With
      End If

      sSqlText = "SELECT * " & _
                 " FROM TB_PESSOA_TELEFONE" & _
                 " WHERE ID_PESSOA = " & iID_EMPRESA_FILIAL & _
                    "AND ID_TIPO_TELEFONE = " & enTipoTelefone.Celular.GetHashCode
      oData = DBQuery(sSqlText)

      If oData.Rows.Count > 0 Then
        With oData.Rows(0)
          iSQ_PESSOA_TELEFONE = .Item("SQ_PESSOA_TELEFONE")
          txtTelefone.Text = FNC_NVL(.Item("CD_NUMERO"), "")
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
End Class