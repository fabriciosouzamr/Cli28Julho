Public Class frmSEGAlterarSenha
  Public bAlterado As Boolean = False

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Trim(txtSenhaAtual.Senha) = "" Then
      FNC_Mensagem("É preciso informar a senha atual")
      Exit Sub
    End If
    If Trim(txtNovaSenha.Senha) = "" Then
      FNC_Mensagem("É preciso informar a nova senha")
      Exit Sub
    End If
    If Trim(txtConfirmarSenha.Senha) = "" Then
      FNC_Mensagem("É preciso confirmar a senha")
      Exit Sub
    End If
    If Trim(txtNovaSenha.Senha) <> Trim(txtConfirmarSenha.Senha) Then
      FNC_Mensagem("A nova senha está diferente da senha confirmada")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_SEG_USUARIO_ALTERASENHA", False, "@ID_USUARIO",
                                                                "@DS_SENHA_ATUAL",
                                                                "@DS_NOVA_SENHA")

    If DBExecutar(sSqlText, DBParametro_Montar("ID_USUARIO", iID_USUARIO),
                            DBParametro_Montar("DS_SENHA_ATUAL", FNC_Criptografia(Trim(txtSenhaAtual.Senha))),
                            DBParametro_Montar("DS_NOVA_SENHA", FNC_Criptografia(Trim(txtNovaSenha.Senha)))) Then

      bAlterado = True

      FNC_Mensagem("Senha alterada")

      Me.Close()
    End If
  End Sub
End Class