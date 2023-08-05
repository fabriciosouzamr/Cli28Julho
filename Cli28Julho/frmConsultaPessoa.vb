Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaPessoa
  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub frmConsultaPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboTipoPessoa, enSql.TipoPessoa)
    ComboBox_CarregarMeses(cboMesAniversario)
    ComboBox_Carregar(cboAtivo, enSql.AtivoInativo_Pessoal)
    ComboBox_Selecionar(cboAtivo, enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode)

    FormPesquisaPessoa_FormatarGrid(grdListagem, oDBGrid, True, False)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    Try
      With FNC_Permissao(enPermissao.CADA_Pessoa_CadastroPessoa)
        cmdNovo.Enabled = .bIncluir
        cmdAlterar.Enabled = .bAlterar
        cmdExcluir.Enabled = .bExcluir
      End With
    Catch ex As Exception
    End Try

    cmdNovo.Enabled = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroPessoa).bIncluir
    cmdAlterar.Enabled = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroPessoa).bAlterar
    cmdExcluir.Enabled = FNC_Permissao(enPermissao.CADA_Pessoa_CadastroPessoa).bExcluir
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    If Trim(txtNomePessoa.Text) = "" And Not ComboBox_Selecionado(cboTipoPessoa) And
       Trim(txtDocumento.Text) = "" And txtDiaAniversario.Value = 0 And Not ComboBox_Selecionado(cboMesAniversario) And
       Not chkCliente.Checked And Not chkFabricante.Checked And Not chkFornecedor.Checked And Not chkFuncionario.Checked And
       Not chkProfissional.Checked And Not chkProfissional_PrestaServicosInterno.Checked And Not chkPaciente.Checked And
       Not chkVendedor.Checked And Not chkTransportadora.Checked Then
      If Not FNC_Perguntar("Informe algum dado para filtro, caso contrário será listados uma grande quantidade de dados de pessoas. Deseja continuar?") Then
        Exit Sub
      End If
    End If

    Pesquisar()
  End Sub

    Private Sub Pesquisar()
        FormPesquisaPessoa_Pesquisar(grdListagem,
                                     txtNomePessoa.Text,
                                     FNC_NVL(cboTipoPessoa.SelectedValue, -1),
                                     txtDocumento.Text,
                                     chkCliente.Checked,
                                     chkFabricante.Checked,
                                     chkFornecedor.Checked,
                                     chkFuncionario.Checked,
                                     chkProfissional.Checked,
                                     chkProfissional_PrestaServicosInterno.Checked,
                                     chkTransportadora.Checked,
                                     chkVendedor.Checked,
                                     chkPaciente.Checked,
                                     cboAtivo.SelectedValue, 0,
                                     txtDiaAniversario.Value,
                                     FNC_NVL(cboMesAniversario.SelectedValue, 0))

        lblRListagemPessoa.Text = lblRListagemPessoa.Tag & " (" & grdListagem.Rows.Count & " registro(s))"
    End Sub

    Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    Dim sSqlText As String

    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para exclusão")
      Exit Sub
    End If
    If Not FNC_Perguntar("Deseja realmente excluir essa pessoa?") Then Exit Sub

    If objGrid_Valor(grdListagem, const_GridListagemPessoa_TP_PODEEXCLUIR) = "N" Then
      If FNC_Perguntar("Não é possível excluir essa pessoa, pois existem lançamentos relacionados a mesma. Deseja somente desativar?") Then
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
    Dim oForm As New frmCadastroPessoa

    AddHandler oForm.Pesquisar, AddressOf Pesquisar

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
      Exit Sub
    End If

    Dim oForm As New frmCadastroPessoa

    AddHandler oForm.Pesquisar, AddressOf Pesquisar
    oForm.iSQ_PESSOA = objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub frmConsultaPessoa_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdExcluir.Top = cmdNovo.Top
    cmdExcel.Top = cmdExcluir.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    cmdFechar.Top = cmdNovo.Top
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cboTipoPessoa_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTipoPessoa.KeyDown
    If e.KeyCode = Keys.Delete Then cboTipoPessoa.SelectedIndex = -1
  End Sub

  Private Sub cboMesAniversario_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMesAniversario.KeyDown
    If e.KeyCode = Keys.Delete Then cboMesAniversario.SelectedIndex = -1
  End Sub

  Private Sub frmConsultaPessoa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub grdListagem_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grdListagem.DoubleClickCell
    cmdAlterar.PerformClick()
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    txtNomePessoa.Text = ""
    txtDocumento.Text = ""
    txtDiaAniversario.Value = 0
    cboMesAniversario.SelectedIndex = -1
    cboAtivo.SelectedIndex = -1
    cboTipoPessoa.SelectedIndex = -1
    chkCliente.Checked = False
    chkFabricante.Checked = False
    chkFornecedor.Checked = False
    chkFuncionario.Checked = False
    chkPaciente.Checked = False
    chkProfissional.Checked = False
    chkTransportadora.Checked = False
    chkVendedor.Checked = False
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub FrmConsultaPessoa_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.F3 Then
      cmdPesquisar.PerformClick()
    End If
  End Sub
End Class