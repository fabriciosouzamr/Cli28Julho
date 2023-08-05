Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmpsqPessoa
  Public Enum enTipoFiltroPessoa
    Cliente = 1
    Fabricante = 2
    Fornecedor = 3
    Funcionario = 4
    Medico = 5
    Transportadora = 6
    Vendedor = 7
    Pessoa = 8
    Paciente = 9
    Profissional = 10
  End Enum

  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Public TipoFiltro As enTipoFiltroPessoa = enTipoFiltroPessoa.Pessoa
  Public SQ_PESSOA As Integer = 0
  Public NO_PESSOA As String = ""
  Public SomentePesquisa As Boolean

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmpsqPessoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboAtivo, enSql.AtivoInativo_Pessoal)
    ComboBox_Selecionar(cboAtivo, enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode)

    FormPesquisaPessoa_FormatarGrid(grdListagem, oDBGrid)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    lblRListagemPessoa.Text = "Listagem de " & TipoFiltro.ToString
    Me.Text = "Cadastro de " & TipoFiltro.ToString

    Select Case TipoFiltro
      Case enTipoFiltroPessoa.Pessoa
        lblRPessoa.Text = "Nome da " & TipoFiltro.ToString
      Case Else
        lblRPessoa.Text = "Nome do " & TipoFiltro.ToString
    End Select

    If SomentePesquisa Then
      cmdAlterar.Visible = False
      cmdNovoCadastro.Visible = False
    End If
    If (TipoFiltro = enTipoFiltroPessoa.Medico Or TipoFiltro = enTipoFiltroPessoa.Profissional) Then
      lblMae.Visible = False
      txtMae.Visible = False
      lblDocumentos.Visible = False
      txtDocumentos.Visible = False
    End If

    Me.Width = 900
    Me.Height = 420
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    FormPesquisaPessoa_Pesquisar(oGrid:=grdListagem,
                                 NomePessoa:=txtPessoa.Text,
                                 TipoPessoa:=-1,
                                 Documento:=txtDocumentos.Text,
                                 bCliente:=TipoFiltro = enTipoFiltroPessoa.Cliente,
                                 bFabricante:=TipoFiltro = enTipoFiltroPessoa.Fabricante,
                                 bFornecedor:=TipoFiltro = enTipoFiltroPessoa.Fornecedor,
                                 bFuncionario:=TipoFiltro = enTipoFiltroPessoa.Funcionario,
                                 bProfissional:=(TipoFiltro = enTipoFiltroPessoa.Medico Or TipoFiltro = enTipoFiltroPessoa.Profissional),
                                 bProfissional_ServicoInterno:=TipoFiltro = enTipoFiltroPessoa.Medico,
                                 bTransportadora:=TipoFiltro = enTipoFiltroPessoa.Transportadora,
                                 bVendedor:=TipoFiltro = enTipoFiltroPessoa.Vendedor,
                                 bPaciente:=TipoFiltro = enTipoFiltroPessoa.Paciente,
                                 iAtivo:=cboAtivo.SelectedValue,
                                 sMae:=txtMae.Text,
                                 sProntuario:=txtNrProtuario.Text)
  End Sub

  Private Sub cmdSelecionar_Click(sender As Object, e As EventArgs) Handles cmdSelecionar.Click
    RetornarSelecionado()
  End Sub

  Private Sub RetornarSelecionado()
    If objGrid_LinhaSelecionada(grdListagem) > -1 Then
      SQ_PESSOA = objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA)
      NO_PESSOA = objGrid_Valor(grdListagem, const_GridListagemPessoa_NomePessoa)
      Close()
    Else
      FNC_Mensagem("Selecione um registro")
    End If
  End Sub

  Private Sub grdListagem_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdListagem.DoubleClickRow
    RetornarSelecionado()
  End Sub

  Private Sub frmpsqPessoa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub cmdNovoCadastro_Click(sender As Object, e As EventArgs) Handles cmdNovoCadastro.Click
    Dim oForm As New frmCadastroPaciente

    oForm.bFecharAposGravacao = True

    FNC_AbriTela(oForm, , True, True)

    If oForm.bGravado Then
      txtPessoa.Text = oForm.sNO_PESSOA
      Pesquisar()
    End If
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Não foi selecionado nenhum registro para alteração")
      Exit Sub
    End If

    If objGrid_Valor(grdListagem, const_GridListagemPessoa_Paciente) = "Sim" Then
      Dim oFormPaciente As New frmCadastroPaciente

      oFormPaciente.Hide()
      AddHandler oFormPaciente.Pesquisar, AddressOf Pesquisar
      FNC_AbriTela(oFormPaciente)
      oFormPaciente.ID_PACIENTE = objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA)
      oFormPaciente.Show()
    Else
      Dim oFormCadastroPessoa As New frmCadastroPessoa

      AddHandler oFormCadastroPessoa.Pesquisar, AddressOf Pesquisar
      oFormCadastroPessoa.iSQ_PESSOA = objGrid_Valor(grdListagem, const_GridListagemPessoa_SQ_PESSOA)
      FNC_AbriTela(oFormCadastroPessoa)
    End If
  End Sub
End Class