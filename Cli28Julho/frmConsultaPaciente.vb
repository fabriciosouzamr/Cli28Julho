Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaPaciente
  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub frmConsultaPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_CarregarMeses(cboMesAniversario)
    ComboBox_Carregar(cboAtivo, enSql.AtivoInativo_Pessoal)
    ComboBox_Selecionar(cboAtivo, enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode)

    FormPesquisaPessoa_FormatarGrid(grdListagem, oDBGrid, True, False, True)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    Try
      With FNC_Permissao(enPermissao.CADA_Pessoa_CadastroPessoa)
        cmdNovo.Enabled = .bIncluir
        cmdAlterar.Enabled = .bAlterar
        cmdExcluir.Enabled = .bExcluir
      End With
    Catch ex As Exception
    End Try

    cmdNovo.Enabled = FNC_Permissao(enPermissao.AGEN_Paciente).bIncluir
    cmdAlterar.Enabled = FNC_Permissao(enPermissao.AGEN_Paciente).bAlterar
    cmdExcluir.Enabled = FNC_Permissao(enPermissao.AGEN_Paciente).bExcluir
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    FormPesquisaPessoa_Pesquisar(oGrid:=grdListagem,
                                 NomePessoa:=txtNomePessoa.Text,
                                 TipoPessoa:=-1,
                                 Documento:=txtDocumento.Text,
                                 bCliente:=False,
                                 bFabricante:=False,
                                 bFornecedor:=False,
                                 bFuncionario:=False,
                                 bProfissional:=False,
                                 bProfissional_ServicoInterno:=False,
                                 bTransportadora:=False,
                                 bVendedor:=False,
                                 bPaciente:=True,
                                 iAtivo:=FNC_NVL(cboAtivo.SelectedValue, 0),
                                 iID_PESSOA:=0,
                                 DiaAniversario:=0,
                                 MesAniversario:=FNC_NVL(cboMesAniversario.SelectedValue, 0),
                                 bNaoEmpresa:=False,
                                 bConsultaPaciente:=True,
                                 bSomenteNome:=False,
                                 sTelefone:=txtTelefone.Text)

    lblRListagemPessoa.Text = lblRListagemPessoa.Tag & " (" & grdListagem.Rows.Count & " registro(s))"
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    Dim sSqlText As String

    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para exclusão")
      Exit Sub
    End If
    If Not FNC_Perguntar("Deseja realmente excluir esse paciente?") Then Exit Sub

    If objGrid_Valor(grdListagem, const_GridListagemPessoa_TP_PODEEXCLUIR) = "N" Then
      If FNC_Perguntar("Não é possível excluir esse paciente, pois existem lançamentos relacionados ao mesmo. Deseja somente desativar?") Then
        sSqlText = DBMontar_SP("SP_PESSOA_ATIVO_UPD", False, "@SQ_PESSOA",
                                                             "@ID_EMPRESA",
                                                             "@ID_OPT_ATIVO")
        DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA", objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA)),
                             DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                             DBParametro_Montar("ID_OPT_ATIVO", enOpcoes.AtivoInativo_Pessoal_Inativo.GetHashCode))
        Pesquisar()
      End If

      Exit Sub
    End If

    sSqlText = DBMontar_SP("SP_PESSOA_DEL", False, "@SQ_PESSOA", _
                                                   "@ID_EMPRESA")

    If DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA", objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA)), _
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL)) Then
      Pesquisar()
    End If
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    Dim oForm As New frmCadastroPaciente

    'AddHandler oForm.Pesquisar, AddressOf Pesquisar

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
      Exit Sub
    End If

    Dim oForm As New frmCadastroPaciente

    oForm.Hide()
    AddHandler oForm.Pesquisar, AddressOf Pesquisar
    FNC_AbriTela(oForm)
    oForm.ID_PACIENTE = objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA)
    oForm.Show()
  End Sub

  Private Sub frmConsultaPessoa_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdExcluir.Top = cmdNovo.Top
    cmdImprimir.Top = cmdNovo.Top
    cmdExcel.Top = cmdExcluir.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdNovo.Top
    cmdPDF.Top = cmdNovo.Top
    cmdHistorico.Top = cmdNovo.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cboMesAniversario_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMesAniversario.KeyDown
    If e.KeyCode = Keys.Delete Then cboMesAniversario.SelectedIndex = -1
  End Sub

  Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para impressão")
      Exit Sub
    End If

    FormRelatorioPaciente(objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA))
  End Sub

  Private Sub cboAtivo_KeyDown(sender As Object, e As KeyEventArgs) Handles cboAtivo.KeyDown
    If e.KeyCode = Keys.Delete Then cboAtivo.SelectedIndex = -1
  End Sub

  Private Sub frmConsultaPaciente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub grdListagem_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grdListagem.DoubleClickCell
    cmdAlterar.PerformClick()
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    txtNomePessoa.Text = ""
    txtDocumento.Text = ""
    cboAtivo.SelectedIndex = -1
    cboMesAniversario.SelectedIndex = -1
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub FrmConsultaPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.F3 Then
      cmdPesquisar.PerformClick()
    End If
  End Sub

  Private Sub cmdHistorico_Click(sender As Object, e As EventArgs) Handles cmdHistorico.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("É necessário selecionar o paciente para o qual deseja ver o histórico")
      Exit Sub
    End If

    Dim oForm As New frmConsultaHistorico_Registro

    oForm.iProcessso = enOpcoes.Processo_Historico_Cadastro_CadastroPaciente.GetHashCode()
    oForm.iID_REGISTRO = objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA)
    FNC_AbriTela(oForm, , True, True)
  End Sub
End Class