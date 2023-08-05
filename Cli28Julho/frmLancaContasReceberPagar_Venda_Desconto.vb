Public Class frmLancaContasReceberPagar_Venda_Desconto
  Public Autorizado As Boolean
  Public ValorDesconto As Double
  Public ValorTotal As Double
  Public PcDesconto As Double
  Public iPessoaLiberacaoDesconto As Integer

  Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
    Autorizado = False
    Close()
  End Sub

  Private Sub cmdValidar_Click(sender As Object, e As EventArgs) Handles cmdValidar.Click
    If Not ComboBox_Selecionado(cboLogin_Usuario) Then
      FNC_Mensagem("Selecione o usuário")
      Exit Sub
    End If
    If Trim(txtSenha.Text) = "" Then
      FNC_Mensagem("Informe a senha")
      Exit Sub
    End If
    If txtValorDesconto.Value <= 0 Then
      FNC_Mensagem("Informe o valor de desconto")
      Exit Sub
    End If
    If cboLogin_Usuario.SelectedItem(enComboBox_Usuario_Supervisao.DS_SENHA) <> FNC_Criptografia(Trim(txtSenha.Text)) Then
      FNC_Mensagem("Senha inválida")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = "SELECT PC_DESCONTO_MAXIMO FROM TB_CONTAFINANCEIRA WHERE ID_PESSOA = " & cboLogin_Usuario.SelectedValue & " AND ID_EMPRESA = " & iID_EMPRESA_MATRIZ

    PcDesconto = DBQuery_ValorUnico(sSqlText, 0)

    If FNC_Porcentagem(ValorTotal, PcDesconto) < txtValorDesconto.Value Then
      FNC_Mensagem("O valor de desconto informado é maior que o permitido")
      Exit Sub
    End If

    iPessoaLiberacaoDesconto = FNC_NVL(cboLogin_Usuario.SelectedValue, 0)
    ValorDesconto = txtValorDesconto.Value
    Autorizado = True

    Close()
  End Sub

  Private Sub frmLancaContasReceberPagar_Venda_Desconto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboLogin_Usuario, enSql.Usuario_Supervisao)
  End Sub
End Class