Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmConsultaProcedimento
  Dim oDBGrid As New UltraWinDataSource.UltraDataSource

  Private Sub frmConsultaProcedimento_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    cmdNovo.Left = 5
    cmdNovo.Top = Me.ClientSize.Height - cmdFechar.Height - 5
    cmdAlterar.Top = cmdNovo.Top
    cmdExcluir.Top = cmdNovo.Top
    cmdExcel.Top = cmdNovo.Top
    cmdPDF.Top = cmdNovo.Top
    cmdFechar.Top = cmdNovo.Top
    cmdFechar.Left = Me.ClientSize.Width - cmdFechar.Width - 5
    grdListagem.Width = Me.ClientSize.Width - 10
    grdListagem.Height = cmdFechar.Top - grdListagem.Top - 5
  End Sub

  Private Sub cmdExcel_Click(sender As Object, e As EventArgs) Handles cmdExcel.Click
    objGrid_ExportarExcell(grdListagem, Me.Text, cmdExcel)
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Pesquisar()
  End Sub

  Private Sub Pesquisar()
    FormPesquisaProcedimento_Pesquisar(grdListagem,
                                       FNC_NVL(cboAtivo.SelectedItem, "T"),
                                       txtNomeProcedimento.Text,
                                       txtCodigo.Text,
                                       FNC_NVL(cboTabelaProcedimento.SelectedValue, 0),
                                       FNC_NVL(cboTipoProcedimento.SelectedValue, 0),
                                       FNC_NVL(cboGrupoProcedimento.SelectedValue, 0),)

    lblRListagemPessoa.Text = lblRListagemPessoa.Tag & " (" & grdListagem.Rows.Count & " registro(s))"
  End Sub

  Private Sub frmConsultaProcedimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cboAtivo.SelectedIndex = 1

    ComboBox_Carregar(cboTabelaProcedimento, enSql.TabelaProcedimento)
    ComboBox_Carregar(cboTipoProcedimento, enSql.TipoProcedimento)
    ComboBox_Carregar(cboGrupoProcedimento, enSql.GrupoProcedimento)
    ComboBox_Selecionar(cboTabelaProcedimento, iEMPRESA_ID_TABELAPROCEDIMENTO_PADRAO)

    FormPesquisaProcedimento_FormatarGrid(grdListagem, oDBGrid, True)
    objGrid_Configuracao_Carregar(grdListagem, Me.Name)

    cmdNovo.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_Procedimento).bIncluir
    cmdAlterar.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_Procedimento).bAlterar
    cmdExcluir.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_Procedimento).bExcluir
  End Sub

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdNovo_Click(sender As Object, e As EventArgs) Handles cmdNovo.Click
    FNC_AbriTela(New frmCadastroProcedimento)
  End Sub

  Private Sub cmdAlterar_Click(sender As Object, e As EventArgs) Handles cmdAlterar.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o procedimento a ser alterado")
      Exit Sub
    End If

    Dim oForm As New frmCadastroProcedimento

    oForm.iSQ_PROCEDIMENTO = objGrid_Valor(grdListagem, const_GridListagemProcedimento_SQ_PROCEDIMENTO)

    FNC_AbriTela(oForm)
  End Sub

  Private Sub cmdExcluir_Click(sender As Object, e As EventArgs) Handles cmdExcluir.Click
    If objGrid_LinhaSelecionada(grdListagem) = -1 Then
      FNC_Mensagem("Selecione o procedimento a ser excluído")
      Exit Sub
    End If

    If Not FNC_Perguntar("Deseja realmente excluir esse procedimento?") Then Exit Sub

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_PROCEDIMENTO_DEL", False, "@SQ_PROCEDIMENTO")

    If DBExecutar(sSqlText, DBParametro_Montar("SQ_PROCEDIMENTO", objGrid_Valor(grdListagem, const_GridListagemProcedimento_SQ_PROCEDIMENTO))) Then
      Pesquisar()

      FNC_Mensagem("Exclusão Efetuada")
    End If
  End Sub

  Private Sub frmConsultaProcedimento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub grdListagem_DoubleClickCell(sender As Object, e As DoubleClickCellEventArgs) Handles grdListagem.DoubleClickCell
    cmdAlterar.PerformClick()
  End Sub

  Private Sub CmdLimpar_Click(sender As Object, e As EventArgs) Handles cmdLimpar.Click
    txtNomeProcedimento.Text = ""
    txtCodigo.Text = ""
    cboAtivo.SelectedIndex = -1
    cboTabelaProcedimento.SelectedIndex = -1
    cboGrupoProcedimento.SelectedIndex = -1
  End Sub

  Private Sub CmdPDF_Click(sender As Object, e As EventArgs) Handles cmdPDF.Click
    objGrid_ExportarPDF(grdListagem, Me.Text)
  End Sub

  Private Sub FrmConsultaProcedimento_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.KeyCode = Keys.F3 Then
      cmdPesquisar.PerformClick()
    End If
  End Sub
End Class