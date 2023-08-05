Public Class uscpsqProduto
  Public Event ItemSelecionado(sender As Object, e As EventArgs)

  Public ListarLinhaProduto As Boolean = False
  Public ListarInativo As Boolean = False
  Public FiltrarPelaTelaPesquisa As Boolean = False

  Private Sub FormatarTela()
    cboProduto.Width = Me.Width - cboProduto.Left
    Me.Height = cboProduto.Top + cboProduto.Height
  End Sub

  Private Sub uscpsqProduto_Load(sender As Object, e As EventArgs) Handles Me.Load
    FormatarTela()
    cboProduto.Items.Clear()
    cboProduto.Text = ""
  End Sub

  Private Sub uscpsqProduto_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    FormatarTela()
  End Sub

  Public ReadOnly Property Codigo As String
    Get
      If cboProduto.SelectedItem Is Nothing Then
        Return ""
      Else
        Return cboProduto.SelectedItem(const_GridListagemProduto_CD_PRODUTO)
      End If
    End Get
  End Property

  Public ReadOnly Property Descricao As String
    Get
      Return cboProduto.Text
    End Get
  End Property

  Public ReadOnly Property Selecionado As Boolean
    Get
      Return ComboBox_Selecionado(cboProduto)
    End Get
  End Property

  Public ReadOnly Property SelectedItem As Object
    Get
      Return cboProduto.SelectedItem
    End Get
  End Property

  Public Property SelectedIndex As Integer
    Get
      Return cboProduto.SelectedIndex
    End Get
    Set(value As Integer)
      cboProduto.SelectedText = value
    End Set
  End Property

  Public Sub Limpar()
    cboProduto.SelectedIndex = -1
  End Sub

  Public ReadOnly Property LinhaProduto As Boolean
    Get
      If ComboBox_Selecionado(cboProduto) Then
        Return (FNC_NVL(cboProduto.SelectedItem(enCombox_Produto.TIPO), 0) = enListagemProduto_Tipo.LinhaProduto.GetHashCode())
      Else
        Return False
      End If
    End Get
  End Property

  Public Property Identificador As Integer
    Get
      Return FNC_NVL(cboProduto.SelectedValue, -1)
    End Get
    Set(value As Integer)
      If value = -1 Then
        Limpar()
      Else
        FormPesquisaProduto_TratarCombo(Me.ParentForm, cboProduto, Nothing, value, , (Not ListarInativo))
        ComboBox_Selecionar(cboProduto, value)
      End If
    End Set
  End Property

  Public Property Identificador_Filial As Integer
    Get
      Try
        Return FNC_NVL(cboProduto.SelectedItem(const_GridListagemProduto_ID_PRODUTO_EMPRESA), -1)
      Catch ex As Exception
      End Try
    End Get
    Set(value As Integer)
      If value <= 0 Then
        Limpar()
      Else
        Try
          FormPesquisaProduto_TratarCombo(Me.ParentForm, cboProduto, Nothing, 0, value, (Not ListarInativo))
          ComboBox_Selecionar(cboProduto, value, const_GridListagemProduto_ID_PRODUTO_EMPRESA)
        Catch ex As Exception
        End Try
      End If
    End Set
  End Property

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    FormPesquisaProduto_ExibirTela(cboProduto)
  End Sub

  Private Sub cboProduto_KeyDown(sender As Object, e As KeyEventArgs) Handles cboProduto.KeyDown
    If FiltrarPelaTelaPesquisa Then
      If Trim(cboProduto.Text) <> "" And e.KeyCode = Keys.Enter Then
        FormPesquisaProduto_ExibirTela(cboProduto, True)
      End If
    Else
      FormPesquisaProduto_TratarCombo(Me.ParentForm, cboProduto, e, ,, (Not ListarInativo), ListarLinhaProduto)
    End If
  End Sub

  Private Sub cboProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduto.SelectedIndexChanged
    RaiseEvent ItemSelecionado(sender, e)
  End Sub
End Class
