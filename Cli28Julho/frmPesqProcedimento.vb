Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class frmPesqProcedimento
  Dim oDBGrid As New UltraWinDataSource.UltraDataSource
  Public SQ_PROCEDIMENTO As Integer = 0
  Public NO_PROCEDIMENTO As String = ""
  Public ID_TABELAPROCEDIMENTO As Integer = 0
  Public ID_CONVENIO As Integer = 0

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdSelecionar_Click(sender As Object, e As EventArgs) Handles cmdSelecionar.Click
    RetornarSelecionado()
  End Sub

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    FormPesquisaProcedimento_Pesquisar(grdListagem,
                                       FNC_NVL(cboAtivo.SelectedValue, "T"),
                                       txtNomeProcedimento.Text,
                                       txtCodigos.Text,
                                       FNC_NVL(cboTabelaProcedimento.SelectedValue, 0),
                                       FNC_NVL(cboTipoProcedimento.SelectedValue, 0),
                                       FNC_NVL(cboTipoExame.SelectedValue, 0),
                                       ID_CONVENIO)
  End Sub

  Private Sub RetornarSelecionado()
    If objGrid_LinhaSelecionada(grdListagem) > -1 Then
      SQ_PROCEDIMENTO = objGrid_Valor(grdListagem, const_GridListagemProcedimento_SQ_PROCEDIMENTO)
      NO_PROCEDIMENTO = objGrid_Valor(grdListagem, const_GridListagemProcedimento_NO_PROCEDIMENTO)
      ID_TABELAPROCEDIMENTO = objGrid_Valor(grdListagem, const_GridListagemProcedimento_ID_TABELAPROCEDIMENTO)
      Close()
    Else
      FNC_Mensagem("Selecione um registro")
    End If
  End Sub

  Private Sub grdListagem_DoubleClickRow(sender As Object, e As DoubleClickRowEventArgs) Handles grdListagem.DoubleClickRow
    RetornarSelecionado()
  End Sub

  Private Sub cboTabelaProcedimento_KeyDown(sender As Object, e As KeyEventArgs) Handles cboTabelaProcedimento.KeyDown
    If e.KeyCode = Keys.Delete Then cboTabelaProcedimento.SelectedIndex = -1
  End Sub

  Private Sub frmPesqProcedimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cboAtivo.SelectedIndex = 1

    ComboBox_Carregar(cboTabelaProcedimento, enSql.TabelaProcedimento)
    ComboBox_Selecionar(cboTabelaProcedimento, iEMPRESA_ID_TABELAPROCEDIMENTO_PADRAO)
    ComboBox_Carregar(cboTipoProcedimento, enSql.TipoProcedimento)

    FormPesquisaProcedimento_FormatarGrid(grdListagem, oDBGrid, True)
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)

    TipoExame_Habilitar(False)
  End Sub

  Private Sub frmPesqProcedimento_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    objGrid_Configuracao_Gravar(grdListagem, Me.Name)
  End Sub

  Private Sub cboTipoProcedimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoProcedimento.SelectedIndexChanged
    If ComboBox_Selecionado(cboTipoProcedimento) Then
      TipoExame_Habilitar(cboTipoProcedimento.SelectedValue = enOpcoes.TipoProcedimento_Exame.GetHashCode())
    Else
      TipoExame_Habilitar(False)
    End If
  End Sub

  Private Sub TipoExame_Habilitar(bHabilitar As Boolean)
    lblRTipoExame.Enabled = bHabilitar
    cboTipoExame.Enabled = bHabilitar
    If Not bHabilitar Then cboTipoExame.SelectedIndex = -1
  End Sub
End Class