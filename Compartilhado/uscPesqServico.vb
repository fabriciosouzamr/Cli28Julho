Public Class uscPesqServico
  Public Event ItemSelecionado()

  Dim bEmProcessamento As Boolean

  Private Sub FormatarTela()
    cboServico.Width = Me.Width - cboServico.Left
    Me.Height = cboServico.Top + cboServico.Height
  End Sub

  Private Sub uscPesqServico_Load(sender As Object, e As EventArgs) Handles Me.Load
    FormatarTela()
    Try
      ComboBox_Carregar(cboServico, enSql.Servico)
    Catch ex As Exception
    End Try
  End Sub

  Private Sub uscPesqServico_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    FormatarTela()
  End Sub

  Public Property Identificador As Integer
    Get
      Return FNC_NVL(cboServico.SelectedValue, 0)
    End Get
    Set(value As Integer)
      If value > 0 Then
        Try
          ComboBox_Selecionar(cboServico, value)
        Catch ex As Exception
        End Try
      End If
    End Set
  End Property

  Public ReadOnly Property Codigo As String
    Get
      If ComboBox_Selecionado(cboServico) Then
        Return cboServico.SelectedItem(2)
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property Descricao As String
    Get
      If ComboBox_Selecionado(cboServico) Then
        Return cboServico.SelectedItem(1)
      Else
        Return ""
      End If
    End Get
  End Property

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    'FormPesquisaProcedimento_BotaoPesquisar(cboProcedimento, cboProcedimentoPrincipal, bEmProcessamento)
  End Sub

  Public ReadOnly Property Nome As String
    Get
      Return cboServico.Text
    End Get
  End Property

  Public Sub Limpar()
    cboServico.SelectedIndex = -1
  End Sub

  Private Sub cboServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServico.SelectedIndexChanged
    RaiseEvent ItemSelecionado()
  End Sub
End Class
