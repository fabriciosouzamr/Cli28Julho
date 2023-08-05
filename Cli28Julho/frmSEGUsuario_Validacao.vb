Public Class frmSEGUsuario_Validacao
  Public Autorizado As Boolean

  Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
    Autorizado = False
    Close()
  End Sub

  Private Sub frmSEGUsuario_Validacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ComboBox_Carregar(cboLogin_Usuario, enSql.Usuario_Supervisao)
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
    If cboLogin_Usuario.SelectedItem(enComboBox_Usuario_Supervisao.DS_SENHA) <> FNC_Criptografia(Trim(txtSenha.Text)) Then
      FNC_Mensagem("Senha inválida")
      Exit Sub
    End If

    Autorizado = True

    Close()
  End Sub
End Class