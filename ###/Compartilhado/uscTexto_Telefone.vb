Public Class uscTexto_Telefone
  Private Sub uscTexto_Telefone_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    txtTelefone.Width = (Me.Width - txtTelefone.Left)
    Me.Height = txtTelefone.Height
  End Sub

  Public Sub Novo()
    If sEMPRESA_CADASTROTELEFONE_DDD_PADRAO.Trim() = "" Then
      txtTelefone.Text = ""
    Else
      txtTelefone.Text = "(" & sEMPRESA_CADASTROTELEFONE_DDD_PADRAO.Trim() & ")"
    End If
  End Sub

  Private Sub txtTelefone_TextChanged(sender As Object, e As EventArgs) Handles txtTelefone.TextChanged
    Dim strIn As String = FNC_SoNumero(txtTelefone.Text)

    If sEMPRESA_CADASTROTELEFONE_MASCARA.Trim() <> "" Then
      If ContarCaracteres(sEMPRESA_CADASTROTELEFONE_MASCARA, "#") = strIn.Length Then
        txtTelefone.Text = Convert.ToInt64(strIn).ToString(sEMPRESA_CADASTROTELEFONE_MASCARA)
      End If
    End If

    Me.txtTelefone.Select(txtTelefone.Text.Length, 0)
  End Sub

  Private Function ContarCaracteres(sTexto As String, sCaractere As String) As Integer
    Dim iCont As Integer
    Dim iRet As Integer = 0

    For iCont = 0 To sTexto.Length
      If Mid(sTexto, iCont, 1) = sCaractere Then
        iRet = iRet + 1
      End If
    Next

    Return iRet
  End Function

  Private Sub txtTelefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefone.KeyPress
    If sEMPRESA_CADASTROTELEFONE_MASCARA.Trim() <> "" Then
      If Asc(e.KeyChar) <> 8 Then
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
          e.Handled = True
        End If
      End If
    End If
  End Sub
End Class
