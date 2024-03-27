Imports Infragistics.Win.UltraWinToolbars
Imports System.Threading

Public Class frmMDI
  'Private Sub ValidarAcesso()
  '  Dim oMenu As System.Windows.Forms.ToolStripMenuItem
  '  Dim bHouveLiberacao As Boolean

  '  If System.Diagnostics.Debugger.IsAttached Then Exit Sub

  '  'Acesso de Menus
  '  For Each oMenu In mnuGeral.Items
  '    If TypeOf oMenu Is System.Windows.Forms.ToolStripMenuItem Then
  '      If Val(oMenu.Tag) <> -1 Then
  '        bHouveLiberacao = False
  '        ValidaAcesso_Menu(oMenu, bHouveLiberacao)

  '        oMenu.Visible = bHouveLiberacao
  '      End If
  '    End If
  '  Next

  '  mnuCadastro_Clinica
  '  mnuCli.Visible = ValidaAcesso_Menu(mnuCliConsultaAgendamento, bHouveLiberacao) And (ValidaAcesso_Menu(mnuCliAgendamento, bHouveLiberacao) Or
  '                                                                                                ValidaAcesso_Menu(mnuCliAtendimentoMedico, bHouveLiberacao) Or
  '                                                                                                ValidaAcesso_Menu(mnuCliPaciente, bHouveLiberacao) Or
  '                                                                                                ValidaAcesso_Menu(mnuCliConsultaPaciente, bHouveLiberacao))
  '  mnuFinSeparador01.Visible = (ValidaAcesso_Menu(mnuFinContasPagar, bHouveLiberacao) Or ValidaAcesso_Menu(mnuFinFluxoCaixa, bHouveLiberacao)) And
  '                              (ValidaAcesso_Menu(mnuFinConsultaContasPagar, bHouveLiberacao) Or ValidaAcesso_Menu(mnuFinConsultaFluxoCaixa, bHouveLiberacao))
  '  mnuFinSeparador02.Visible = (ValidaAcesso_Menu(mnuFinConsultaContasPagar, bHouveLiberacao) Or ValidaAcesso_Menu(mnuFinConsultaFluxoCaixa, bHouveLiberacao)) And
  '                              ValidaAcesso_Menu(mnuFinCompensacao, bHouveLiberacao)
  '  mnuCeVSeparador1.Visible = (ValidaAcesso_Menu(mnuCeVCompras, bHouveLiberacao) Or ValidaAcesso_Menu(mnuCeVPedidoVendas, bHouveLiberacao)) And
  '                             (ValidaAcesso_Menu(mnuCeVMovimentarEstoque, bHouveLiberacao) Or ValidaAcesso_Menu(mnuCeVPendenciaEstoque, bHouveLiberacao))
  '  mnuCeVSeparador2.Visible = (ValidaAcesso_Menu(mnuCeVMovimentarEstoque, bHouveLiberacao) Or ValidaAcesso_Menu(mnuCeVPendenciaEstoque, bHouveLiberacao)) And
  '                             ValidaAcesso_Menu(mnuCeVProdutoGarantia, bHouveLiberacao)
  '  mnuCeVSeparador3.Visible = ValidaAcesso_Menu(mnuCeVProdutoGarantia, bHouveLiberacao) And ValidaAcesso_Menu(mnuCeVOrdemServico, bHouveLiberacao)
  '  mnuCadSeparador01.Visible = (ValidaAcesso_Menu(mnuCadPessoa, bHouveLiberacao) Or ValidaAcesso_Menu(mnuCadEmpresa, bHouveLiberacao)) And
  '                              ValidaAcesso_Menu(mnuCadProduto, bHouveLiberacao)
  '  mnuCadSeparador02.Visible = ValidaAcesso_Menu(mnuCadProduto, bHouveLiberacao) And ValidaAcesso_Menu(mnuCadClinica, bHouveLiberacao)
  '  mnuCadSeparador03.Visible = ValidaAcesso_Menu(mnuCadClinica, bHouveLiberacao) And ValidaAcesso_Menu(mnuCadFinanceiro, bHouveLiberacao)
  '  mnuCadSeparador04.Visible = ValidaAcesso_Menu(mnuCadFinanceiro, bHouveLiberacao) And ValidaAcesso_Menu(mnuCadFiscal, bHouveLiberacao)
  '  mnuCadSeparador05.Visible = ValidaAcesso_Menu(mnuCadFiscal, bHouveLiberacao) And ValidaAcesso_Menu(mnuCadModelos, bHouveLiberacao)
  '  mnuCadSeparador06.Visible = ValidaAcesso_Menu(mnuCadModelos, bHouveLiberacao) And ValidaAcesso_Menu(mnuCadTipo, bHouveLiberacao)
  '  mnuCadSeparador07.Visible = ValidaAcesso_Menu(mnuCadTipo, bHouveLiberacao) And ValidaAcesso_Menu(mnuCadSeguranca, bHouveLiberacao)
  '  mnuCadSeparador08.Visible = ValidaAcesso_Menu(mnuCadSeguranca, bHouveLiberacao) And ValidaAcesso_Menu(mnuCadUsuario, bHouveLiberacao)
  'End Sub

  Private tSenha_ContaCaixa As Thread

  Dim iSenha_ContaCaixaAtendimento As Integer

  Public Sub Senha_ContaCaixa()
    Dim oData As DataTable
    Dim sSqlText As String

    Do While (True)
      If iSenha_ContaCaixaAtendimento > 0 Then
        Try
          Threading.Thread.Sleep(5000)

          sSqlText = "SELECT * FROM VW_CLINICA_SENHA_ULTIMA_SENHA_CHAMADA_HOJE (NOLOCK) WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
          oData = DBQuery(sSqlText, oConexao2)

          If Not objDataTable_Vazio(oData) Then
            ddbSenha_UltimaSenhaChamada.Text = ddbSenha_UltimaSenhaChamada.Tag & " " &
                                             FNC_StrZero(oData.Rows(0).Item("NR_CLINICA_SENHA").ToString(), 3) &
                                             " (" & oData.Rows(0).Item("NO_CAIXA_ATENDIMENTO") & ")"
          End If

          sSqlText = "SELECT NR_CLINICA_SENHA FROM VW_CLINICA_SENHA_ULTIMA_SENHA_GERADA_HOJE (NOLOCK) WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
          ddbSenha_UltimaSenhaGerada.Text = ddbSenha_UltimaSenhaGerada.Tag & " " & FNC_StrZero(DBQuery_ValorUnico(sSqlText, 0, oConexao2).ToString(), 3)

          ddbSenha_ContaCaixa_ChamarSenha_Chamar()
          ddbSenha_ContaCaixa_ChamarSenha_Chamada()
        Catch ex As Exception
        End Try
      End If
    Loop
  End Sub

  Private Sub ddbSenha_ContaCaixa_ChamarSenha_Chamar()
    ToolStripDropDownButton_Carregar(ddbSenha_ContaCaixa_ChamarSenha, enSql.ClinicaSenhaGerada_Hoje_Chamar, AddressOf Senha_ContaCaixa_Chamar)
  End Sub

  Private Sub ddbSenha_ContaCaixa_ChamarSenha_Chamada()
    ToolStripDropDownButton_Carregar(ddbSenha_ContaCaixa_SenhaChamada, enSql.ClinicaSenhaGerada_Hoje_Chamada, AddressOf Senha_ContaCaixa_Chamar)
  End Sub

  Private Sub Senha_ContaCaixa_Chamar(sender As Object, e As EventArgs)
    Dim oData As DataTable
    Dim sSqlText As String
    Dim oItem As ToolStripItem
    Dim iUnidade As Integer
    Dim sURL As String

    oItem = sender

    sSqlText = "EXEC SP_CLINICA_SENHA_CHAMADA_UPD " & oItem.Tag & "," & iSenha_ContaCaixaAtendimento & "," & iID_USUARIO
    DBExecutar(sSqlText, oConexao2)

    If iID_EMPRESA_FILIAL = iID_EMPRESA_MATRIZ Then
      iUnidade = 1
    Else
      iUnidade = 2
    End If

    sSqlText = "SELECT CLSNH.NR_CLINICA_SENHA, CLSNH.ID_EMPRESA, CXATD.NO_CAIXA_ATENDIMENTO, CXATD.DS_LOCALIZACAO" &
               " FROM TB_CLINICA_SENHA CLSNH" &
               " INNER JOIN TB_CAIXA_ATENDIMENTO CXATD ON CXATD.SQ_CAIXA_ATENDIMENTO = CLSNH.ID_CAIXA_ATENDIMENTO" &
               " WHERE CLSNH.SQ_CLINICA_SENHA = " & oItem.Tag
    oData = DBQuery(sSqlText, oConexao2)

    If Not objDataTable_Vazio(oData) Then
      Try
        sURL = sSISTEMA_LlinkChamarSenha.Replace("[Senha]", oData.Rows(0).Item("NR_CLINICA_SENHA")) _
                                        .Replace("[Unidade]", iUnidade) _
                                        .Replace("[Andar]", FNC_NVL(oData.Rows(0).Item("DS_LOCALIZACAO"), "")) _
                                        .Replace("[Caixa]", FNC_NVL(oData.Rows(0).Item("NO_CAIXA_ATENDIMENTO"), ""))

        Clipboard.SetText(sURL)
        FNC_URL_Executar(sURL)

        FNC_Mensagem("Senha " + oData.Rows(0).Item("NR_CLINICA_SENHA").ToString() + " chamada com sucesso!")
      Catch ex As Exception
        FNC_Mensagem("ERRO: " & ex.Message)
      End Try
    End If
  End Sub

  Private Function ValidaAcesso_Menu(oMenu As System.Windows.Forms.ToolStripMenuItem, ByRef bHouveLiberacao As Boolean)
    Dim iCont As Integer
    Dim bLiberacao As Boolean

    If FNC_CampoNulo(oMenu.Tag) Then
      FNC_Mensagem("O menu " & oMenu.Text & " está sem controle de permissão definido")
    Else
      If Val(oMenu.Tag) = 0 Then
        bLiberacao = True
      ElseIf Val(oMenu.Tag) <> 0 Then
        oMenu.Visible = FNC_Permissao_Existe(oMenu.Tag)
        bLiberacao = FNC_Permissao_Existe(oMenu.Tag)
      End If

      If oMenu.DropDownItems.Count > 0 Then
        For iCont = 0 To oMenu.DropDownItems.Count - 1
          If Not TypeOf oMenu.DropDownItems(iCont) Is System.Windows.Forms.ToolStripSeparator Then
            If ValidaAcesso_Menu(oMenu.DropDownItems(iCont), bHouveLiberacao) Then
              bLiberacao = True
              bHouveLiberacao = True
              oMenu.DropDownItems(iCont).Visible = True
            Else
              oMenu.DropDownItems(iCont).Visible = False
              oMenu.DropDownItems(iCont).Tag = 0
            End If
          End If
        Next
      End If
    End If

    Return bLiberacao
  End Function

  Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Control.CheckForIllegalCrossThreadCalls = False

    Me.Visible = False

    Main()
    oFormMDI = Me

    If bUSUARIO_ACESSO_SISTEMACHAMADA Then
      DBConectar(sDBStringDeConecao01, sDBStringDeConecao02, , oConexao2)

      tSenha_ContaCaixa = New Thread(AddressOf Me.Senha_ContaCaixa)
      tSenha_ContaCaixa.IsBackground = True
      tSenha_ContaCaixa.Start()
    End If

    osttStatus = sttStatus
    sttEmpresa.Text = sNO_EMPRESA_FILIAL
    sttUsuario.Text = sNO_USUARIO
    sttVersao.Text = Application.ProductVersion
    sttServidor.Text = Split(oConexao.DataSource, "\")(0)
    sttServidor.ToolTipText = sttServidor.ToolTipText & vbCrLf & "DB: " & oConexao.Database

    ValidarAcesso()

    Me.Text = const_Sistema_Nome
    Me.Visible = True

    If FNC_Permissao_Existe(enPermissao.MEDI_MenuMedico) And Not bUSUARIO_ADMINISTRADOR Then
      TelaAtendimento()
    End If

    ToolStripDropDownButton_Carregar(ddbSenha_ContaCaixa, enSql.ContaCaixaAtendimento_SistemaChamada, AddressOf Senha_ContaCaixa_Clicar)
    stbSenha.Visible = bUSUARIO_ACESSO_SISTEMACHAMADA
  End Sub

  Private Sub Senha_ContaCaixa_Clicar(sender As Object, e As EventArgs)
    Dim oItem As ToolStripItem

    oItem = sender

    ddbSenha_ContaCaixaSelecionada.Text = oItem.Text
    iSenha_ContaCaixaAtendimento = oItem.Tag
  End Sub

  Private Sub ValidarAcesso()
    Dim oMenu As System.Windows.Forms.ToolStripMenuItem
    Dim bHouveLiberacao As Boolean

    'If System.Diagnostics.Debugger.IsAttached Then Exit Sub

    'Acesso de Menus
    For Each oMenu In mnuGeral.Items
      If TypeOf oMenu Is System.Windows.Forms.ToolStripMenuItem Then
        If Val(oMenu.Tag) <> -1 Then
          bHouveLiberacao = False
          ValidaAcesso_Menu(oMenu, bHouveLiberacao)

          oMenu.Visible = bHouveLiberacao
          If Not bHouveLiberacao Then oMenu.Tag = 0
        End If
      End If
    Next

    Dim bCadastro_Pessoa As Boolean = (FNC_NVL(mnuCadastro_Pessoa_FisicaJuridica.Tag, 0) + FNC_NVL(mnuCadastro_Pessoa_Profissao.Tag, 0) +
                                       FNC_NVL(mnuCadastro_Pessoa_Funcao.Tag, 0) + FNC_NVL(mnuCadastro_Pessoa_ConselhoProfissional.Tag, 0) +
                                       FNC_NVL(mnuCadastro_Pessoa_Empresa.Tag, 0) + FNC_NVL(mnuCadastro_Pessoa_Cidade.Tag, 0) +
                                       FNC_NVL(mnuCadastro_Pessoa_UF.Tag, 0) + FNC_NVL(mnuCadastro_Pessoa_Pais.Tag, 0)) > 0
    Dim bCadastro_Clinica As Boolean = (FNC_NVL(mnuCadastro_Clinica_Especialidade.Tag, 0) + FNC_NVL(mnuCadastro_Clinica_GrupoProcedimento.Tag, 0) +
                                        FNC_NVL(mnuCadastro_Clinica_Procedimento.Tag, 0) + FNC_NVL(mnuCadastro_Clinica_CadastrarHorarioProfissional.Tag, 0) +
                                        FNC_NVL(mnuCadastro_Clinica_Configuracao.Tag, 0) + FNC_NVL(mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames.Tag, 0) +
                                        FNC_NVL(mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames.Tag, 0) + FNC_NVL(mnuCadastro_Clinica_Convenio.Tag, 0) +
                                        FNC_NVL(mnuCadastro_Clinica_Vacina.Tag, 0) + FNC_NVL(mnuCadastro_Clinica_Consultorio.Tag, 0)) > 0
    Dim bCadastro_Tipo As Boolean = (FNC_NVL(mnuCadastro_Tipo_TipoCargo.Tag, 0) + FNC_NVL(mnuCadastro_Tipo_TipoConsulta.Tag, 0) +
                                     FNC_NVL(mnuCadastro_Tipo_TipoDocumentoFinanceiro.Tag, 0) + FNC_NVL(mnuCadastro_Tipo_TipoEndereco.Tag, 0) +
                                     FNC_NVL(mnuCadastro_Tipo_TipoEscolaridade.Tag, 0) + FNC_NVL(mnuCadastro_Tipo_TipoEstadoCivil.Tag, 0) +
                                     FNC_NVL(mnuCadastro_Tipo_TipoMidiaSocial.Tag, 0) + FNC_NVL(mnuCadastro_Tipo_TipoPaciente.Tag, 0) +
                                     FNC_NVL(mnuCadastro_Tipo_TipoPessoa.Tag, 0) + FNC_NVL(mnuCadastro_Tipo_TipoRaca.Tag, 0) +
                                     FNC_NVL(mnuCadastro_Tipo_TipoReferencialPessoal.Tag, 0) + FNC_NVL(mnuCadastro_Tipo_TipoRelegiao.Tag, 0)) > 0
    Dim bCadastro_Seguranca As Boolean = (FNC_NVL(mnuCadastro_Seguranca_Permissao.Tag, 0) + FNC_NVL(mnuCadastro_Seguranca_GrupoPermissao.Tag, 0)) > 0
    mnuCadastro_Pessoa.Visible = bCadastro_Pessoa
    mnuCadastro_Clinica.Visible = bCadastro_Clinica
    mnuCadastro_Tipo.Visible = bCadastro_Tipo
    mnuCadastro_Seguranca.Visible = bCadastro_Seguranca

    mnuCadastro_Separador01.Visible = bCadastro_Pessoa And bCadastro_Clinica And bCadastro_Tipo
    mnuCadastro_Separador02.Visible = bCadastro_Seguranca
  End Sub

  Private Sub mnuCadastro_Clinica_CadastrarHorarioProfissional_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_CadastrarHorarioProfissional.Click
    FNC_AbriTela(New frmConsultaProfissionalHorario)
  End Sub

  Private Sub mnuAgendamento_Agendar_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_Agendar.Click
    FNC_AbriTela(New frmCadastroAgendamento)
  End Sub

  Private Sub mnuCadastro_Pessoa_FisicaJuridica_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Pessoa_FisicaJuridica.Click
    FNC_AbriTela(New frmConsultaPessoa)
  End Sub

  Private Sub mnuCadastro_Pessoa_Profissao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Pessoa_Profissao.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroProfissao)
  End Sub

  Private Sub mnuCadastro_Pessoa_Funcao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Pessoa_Funcao.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroCargo)
  End Sub

  Private Sub mnuCadastro_Pessoa_ConselhoProfissional_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Pessoa_ConselhoProfissional.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroConselhoProfissional)
  End Sub

  Private Sub mnuCadastro_Pessoa_Cidade_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Pessoa_Cidade.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroCidade)
  End Sub

  Private Sub mnuCadastro_Pessoa_UF_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Pessoa_UF.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroUF)
  End Sub

  Private Sub mnuCadastro_Pessoa_Pais_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Pessoa_Pais.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroPais)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoConsulta_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoConsulta.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoConsulta)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoEndereco_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoEndereco.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoEndereco)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoEscolaridade_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoEscolaridade.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoEscolaridade)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoEstadoCivil_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoEstadoCivil.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoEstadoCivil)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoMidiaSocial_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoMidiaSocial.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoMidiaSocial)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoPaciente_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoPaciente.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoPaciente)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoPessoa_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoPessoa.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoPessoa)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoRaca_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoRaca.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoRaca)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoReferencialPessoal_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoReferencialPessoal.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoReferenciaPessoa)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoRelegiao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoRelegiao.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoReligiao)
  End Sub

  Private Sub mnuCadastro_Clinica_Especialidade_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_Especialidade.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroEspecialidade)
  End Sub

  Private Sub mnuCadastro_Clinica_Procedimento_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_Procedimento.Click
    FNC_AbriTela(New frmConsultaProcedimento)
  End Sub

  Private Sub mnuCadastro_Clinica_Configuracao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_Configuracao.Click
    FNC_AbriTela(New frmClinica_Configuracao)
  End Sub

  Private Sub mnuAgendamento_Precos_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_Precos.Click
    FNC_AbriTela(frmConsultaConvenioProcedimento)
  End Sub

  Private Sub mnuCadastro_Financeiro_ContasReceber_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ContasReceber.Click
    Dim oForm As New frmLancaContasReceberPagar

    oForm.iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode()

    FNC_AbriTela(oForm,,,, True, oForm.iTipoMovimentacao)
  End Sub

  Private Sub mnuCadastro_Financeiro_ContasPagar_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ContasPagar.Click
    Dim oForm As New frmLancaContasReceberPagar

    oForm.iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode()

    FNC_AbriTela(oForm,,,, True, oForm.iTipoMovimentacao)
  End Sub

  Private Sub mnuCadastro_Financeiro_FluxoCaixa_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_FluxoCaixa.Click
    FNC_AbriTela(New frmLancaFluxoCaixa)
  End Sub

  Private Sub mnuCadastro_Financeiro_ConsultaContasReceber_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ConsultaContasReceber.Click
    Dim oForm As New frmConsultaContasReceberPagar

    oForm.iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasReceber.GetHashCode()

    FNC_AbriTela(oForm,,,, True, oForm.iTipoMovimentacao)
  End Sub

  Private Sub mnuCadastro_Financeiro_ConsultaContasPagar_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ConsultaContasPagar.Click
    Dim oForm As New frmConsultaContasReceberPagar

    oForm.iTipoMovimentacao = enOpcoes.TipoMovimentacaoFinanceiraRecebePagar_ContasPagar.GetHashCode()

    FNC_AbriTela(oForm,,,, True, oForm.iTipoMovimentacao)
  End Sub

  Private Sub mnuCadastro_Financeiro_ConsultaFluxoCaixa_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ConsultaFluxoCaixa.Click
    FNC_AbriTela(New frmConsultaFluxoCaixa)
  End Sub

  Private Sub mnuCadastro_Financeiro_Compensacao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_Compensacao.Click
    FNC_AbriTela(New frmConsultaCompensacao)
  End Sub

  Private Sub mnuCadastro_Financeiro_ConsultaDeFluxoCaixa_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ConsultaDeFluxoCaixa.Click
    FNC_AbriTela(frmConsultaFluxoCaixaSaldos)
  End Sub

  Private Sub mnuAgendamento_Paciente_Click(sender As Object, e As EventArgs)
    Dim oForm As New frmCadastroPaciente

    oForm.SomenteCadastro = True

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuAgendamento_ConsultarPaciente_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultarPaciente.Click
    FNC_AbriTela(New frmConsultaPaciente)
  End Sub

  Private Sub mnuCadastro_Pessoa_Empresa_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Pessoa_Empresa.Click
    FNC_AbriTela(New frmCadastroEmpresa)
  End Sub

  Private Sub mnuAgendamento_ConsultaAgendamento_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultaAgendamento.Click
    FNC_AbriTela(New frmConsultaAgendamento)
  End Sub

  Private Sub mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames.Click
    FNC_AbriTela(New frmCadastroConvenioProcedimento)
  End Sub

  Private Sub mnuCadastro_Clinica_Convenio_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_Convenio.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroConvenio)
  End Sub

  Private Sub mnuAgendamento_Orcamento_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_Orcamento.Click
    FNC_AbriTela(New frmConsultaOrcamento)
  End Sub

  Private Sub mnuAgendamento_Venda_Click(sender As Object, e As EventArgs) Handles mnuVenda_ConsultaVendasRealizadas.Click
    FNC_AbriTela(New frmConsultaVenda)
  End Sub

  Private Sub mnuCadastro_Financeiro_FormaPagamento_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_FormaPagamento.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroFormaPagamento)
  End Sub

  Private Sub mnuCadastro_Financeiro_CondicaoPagamento_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_CondicaoPagamento.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroCondicaoPagamento)
  End Sub

  Private Sub mnuAgendamento_Venda_Fechamento_Click(sender As Object, e As EventArgs) Handles mnuVenda_Fechamento.Click
    FNC_AbriTela(New frmCadastroVenda_Fechamento)
  End Sub

  Private Sub mnuAgendamento_Venda_AprovacaoFechamento_Click(sender As Object, e As EventArgs) Handles mnuVenda_AprovacaoFechamento.Click
    Dim oForm As New frmCadastroVenda_Fechamento_Aprovacao

    oForm.eCadastroVenda_Fechamento = modDeclaracaoLocal.enCadastroVenda_Fechamento.eAprovacao

    FNC_AbriTela(oForm, , , , True, modDeclaracaoLocal.enCadastroVenda_Fechamento.eAprovacao)
  End Sub

  Private Sub mnuAgendamento_Venda_ConferenciaFechamento_Click(sender As Object, e As EventArgs) Handles mnuVenda_ConferenciaFechamento.Click
    Dim oForm As New frmCadastroVenda_Fechamento_Aprovacao

    oForm.eCadastroVenda_Fechamento = modDeclaracaoLocal.enCadastroVenda_Fechamento.eFinanceiro

    FNC_AbriTela(oForm, , , , True, modDeclaracaoLocal.enCadastroVenda_Fechamento.eFinanceiro)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoDocumentoFinanceiro_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoDocumentoFinanceiro.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoDocumento)
  End Sub

  Private Sub mnuCadastro_Financeiro_ContaCaixa_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ContaCaixa.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroContaCaixa)
  End Sub

  Private Sub mnuCadastro_Financeiro_ContaBancaria_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ContaBancaria.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroContaBancaria)
  End Sub

  Private Sub mnuAgendamento_Venda_VendaPendente_Click(sender As Object, e As EventArgs) Handles mnuVenda_VendaPendente.Click
    FNC_AbriTela(New frmConsultaVendaPendente)
  End Sub

  Private Sub mnuMedico_Atendimento_Click(sender As Object, e As EventArgs) Handles mnuMedico_Atendimento.Click
    TelaAtendimento()
  End Sub

  Private Sub TelaAtendimento()
    Dim oForm As New frmConsultaAtendimento

    oFormConsultaAtendimento = oForm
    FNC_AbriTela(oForm)

    oForm.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub mnuCadastro_Clinica_Vacina_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_Vacina.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroVacina)
  End Sub

  Private Sub mnuCadastro_Clinica_Consultorio_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_Consultorio.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroConsultorio)
  End Sub

  Private Sub mnuAgendamento_ConsultaAtendimentosRealizados_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultaAtendimentosRealizados.Click
    Dim oForm As New frmConsultaAtendimentosRealizados

    oForm.Formatar()

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuCadastro_Financeiro_FaturamentoVenda_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_FaturamentoVenda.Click
    Dim oForm As New frmCadastroAtendimentoFaturamento

    oForm.Formatar()

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuCadastro_Usuario_Configuracao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Usuario_Configuracao.Click
    FNC_AbriTela(frmSEGUsuario_Clinica_Configuracao)
  End Sub

  Private Sub mnuCadastro_Usuario_AlterarSenha_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Usuario_AlterarSenha.Click
    FNC_AbriTela(frmSEGAlterarSenha)
  End Sub

  Private Sub mnuMedico_MinhasFaturas_Click(sender As Object, e As EventArgs) Handles mnuMedico_MinhasFaturas.Click
    Dim oForm As New frmConsultaMinhasFaturas

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoCargo_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoCargo.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoCargo)
  End Sub

  Private Sub mnuCadastro_Clinica_GrupoProcedimento_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_GrupoProcedimento.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroGrupoProcedimento)
  End Sub

  Private Sub mnuCadastro_Clinica_ReajustarPrecoProcedimentosExames_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames.Click
    Dim oForm As New frmCadastroConvenioProcedimentoManutencao

    oForm.Formatar()

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuAgendamento_Precos_Profissional_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_Precos_Profissional.Click
    FNC_AbriTela(frmConsultaConvenioProfissional)
  End Sub

  Private Sub mnuCadastro_Financeiro_PlanoContas_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_PlanoContas.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroPlanoContas)
  End Sub

  Private Sub mnuCadastro_Financeiro_GrupoPlanoContas_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_GrupoPlanoContas.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroPlanoContasGrupo)
  End Sub

  Private Sub mnuCadastro_Financeiro_Financiamento_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_Financiamento.Click
    FNC_AbriTela(frmCadastroFinanciamento)
  End Sub

  Private Sub mnuAgendamento_Execucao_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_Execucao.Click
    FNC_AbriTela(frmCadastroAtendimentoExecucao)
  End Sub

  Private Sub mnuCadastro_Seguranca_GrupoPermissao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Seguranca_GrupoPermissao.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroGrupoPermissao)
  End Sub

  Private Sub mnuCadastro_Seguranca_Permissao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Seguranca_Permissao.Click
    FNC_AbriTela(frmSEGPermissao)
  End Sub

  Private Sub mnuCadastro_Financeiro_Banco_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_Banco.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroBanco)
  End Sub

  Private Sub TipoDeSexoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeSexoToolStripMenuItem.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoSexo)
  End Sub

  Private Sub mnuCadastro_Clinica_Turno_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_Turno.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTurno)
  End Sub

  Private Sub mnuCadastro_Clinica_ClassificacaoExame_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_ClassificacaoExame.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroClassificacaoExame)
  End Sub

  Private Sub mnuMedico_ConsultaSolicitacaoExamesCitologicos_Click(sender As Object, e As EventArgs) Handles mnuMedico_ConsultaSolicitacaoExamesCitologicos.Click
    FNC_AbriTela(frmConsultaAtendimentoSolicitacaoExameCitologico)
  End Sub

  Private Sub mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos.Click
    FNC_AbriTela(frmConsultaAtendimentoSolicitacaoExameCitologicoLote)
  End Sub

  Private Sub mnuAgendamento_ConsultaSolicitacaoExamesCitologicos_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultaSolicitacaoExamesCitologicos.Click
    FNC_AbriTela(frmConsultaAtendimentoSolicitacaoExameCitologico)
  End Sub

  Private Sub mnuCadastro_Tipo_TipoRelatorio_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Tipo_TipoRelatorio.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoRelatorio)
  End Sub

  Private Sub mnuCadastro_Clinica_TipoIndicador_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_TipoIndicador.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroTipoIndicador)
  End Sub

  Private Sub mnuCadastro_Financeiro_HistoricoIndicacao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_HistoricoIndicacao.Click
    FNC_AbriTela(frmIndicador_Historico)
  End Sub

  Private Sub mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio.Click
    FNC_AbriTela(New frmConsultaProfissionalHorarioBloqueioAgenda)
  End Sub

  Private Sub mnuAgendamento_ConsultaOcupacaoTempoPrevisto_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultaOcupacaoTempoPrevisto.Click
    FNC_AbriTela(frmConsultaOcupacaoTempoPrevisto)
  End Sub

  Private Sub mnuAgendamento_ConsultaOcupacaoConsultorio_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultaOcupacaoConsultorio.Click
    FNC_AbriTela(frmConsultaConstultorioOcupacao)
  End Sub

  Private Sub mnuAgendamento_ConsultaDiaAbestencao_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultaDiaAbestencao.Click
    FNC_AbriTela(frmConsultaAbestencaoDia)
  End Sub

  Private Sub mnuCadastro_Clinica_CanalMarcacao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_CanalMarcacao.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroCanalMarcacao)
  End Sub

  Private Sub mnuVenda_ConsultaVendasMaster_Click(sender As Object, e As EventArgs) Handles mnuVenda_ConsultaVendasMaster.Click
    FNC_AbriTela(frmConsultaVendasMaster)
  End Sub

  Private Sub mnuAgendamento_ConsultaExamePrescrito_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ConsultaExamePrescrito.Click
    FNC_AbriTela(frmConsultaExamesPrescritos)
  End Sub

  Private Sub frmMDI_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    If e.Alt Then
      Select Case e.KeyCode
        Case Keys.N
          If FNC_Permissao(enPermissao.VEND_ConsultaVenda).bIncluir Then FNC_AbriTela(frmCadastroVenda)
        Case Keys.V
          If FNC_Permissao_Existe(enPermissao.VEND_ConsultaVenda) Then FNC_AbriTela(frmConsultaVenda)
        Case Keys.A
          If FNC_Permissao_Existe(enPermissao.AGEN_Agendamento) Then FNC_AbriTela(frmConsultaAgendamento)
        Case Keys.O
          If FNC_Permissao(enPermissao.AGEN_Orcamento).bIncluir Then FNC_AbriTela(frmCadastroOrcamento)
        Case Keys.P
          If FNC_Permissao(enPermissao.AGEN_Paciente).bIncluir Then FNC_AbriTela(frmCadastroPaciente)
      End Select
    End If
  End Sub

  Private Sub mnuCadastro_Financeiro_Voucher_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_Voucher.Click
    FNC_AbriTela(New frmConsultaVoucher)
  End Sub

  Private Sub mnuCadastro_Clinica_CaixaAtendimento_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Clinica_CaixaAtendimento.Click
    FNC_AbriTela_ListagemGeral(frmListaGeral.enListagemGeral_TipoTela.CadastroCaixaAtendimento)
  End Sub

  Private Sub mnuCadastro_Financeiro_ConsultaFaturamentoVenda_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_ConsultaFaturamentoVenda.Click
    Dim oForm As New frmConsultaFaturamento

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuCadastro_Utilitario_TEF_Administrador_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Utilitario_TEF_Administrador.Click
    'If PayGo.Vender() Then
    '  FNC_Mensagem(PayGo.sRetorno.ToString())
    'End If
  End Sub

  Private Sub mnuAgendamento_MensagemParaPaciente_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_MensagemParaPaciente.Click
    Dim oForm As New frmMensagem

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuAgendamento_ModeloMensagem_Click(sender As Object, e As EventArgs) Handles mnuAgendamento_ModeloMensagem.Click
    Dim oForm As New frmMensagemModelo

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuCadastro_Utilitario_Integracao_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Utilitario_Integracao.Click
    Dim oForm As New frmCadastroIntegracao

    FNC_AbriTela(oForm)
  End Sub

  Private Sub mnuCadastro_Financeiro_FaturamentoVendaAlterar_Click(sender As Object, e As EventArgs) Handles mnuCadastro_Financeiro_FaturamentoVendaAlterar.Click
    Dim oForm As New frmCadastroAtendimentoFaturamentoAlterar

    FNC_AbriTela(oForm)
  End Sub
End Class