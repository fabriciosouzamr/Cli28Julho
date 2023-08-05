Public Class uscTexto_CEP
  Public Event CEPPesquisado()

  Public Endereco As String
  Public Bairro As String
  Public Cidade As String
  Public UF As String

  Private Sub cmdPesquisar_Click(sender As Object, e As EventArgs) Handles cmdPesquisar.Click
    Try
      Dim ds As New DataSet()
      Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEP.Text)

      ds.ReadXml(xml)

      Endereco = ds.Tables(0).Rows(0)("tipo_logradouro").ToString() + " " + ds.Tables(0).Rows(0)("logradouro").ToString()
      Bairro = ds.Tables(0).Rows(0)("bairro").ToString()
      Cidade = ds.Tables(0).Rows(0)("cidade").ToString()
      UF = ds.Tables(0).Rows(0)("uf").ToString()

      RaiseEvent CEPPesquisado()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "C.E.P. Erro")
    End Try
  End Sub

  Public ReadOnly Property Endereco_Completo As String
    Get
      Return Endereco.Trim() + " - " + Bairro.Trim() + " - " + Cidade.Trim() + UF.Trim()
    End Get
  End Property

  Private Sub txtCEP_Enter(sender As Object, e As EventArgs) Handles txtCEP.Enter
    Alerta(True)
    txtCEP.SelectAll()
  End Sub

  Private Sub txtCEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCEP.KeyPress
    If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtCEP_LostFocus(sender As Object, e As EventArgs) Handles txtCEP.LostFocus
    If txtCEP.Text.Trim = "" Then
      Alerta(True)
    Else
      Alerta(FNC_SoNumero(txtCEP.Text).Trim.Length = 8 And txtCEP.Text.Substring(2, 1) = "." And txtCEP.Text.Substring(6, 1) = "-")
    End If
  End Sub

  Private Sub txtCEP_TextChanged(sender As Object, e As EventArgs) Handles txtCEP.TextChanged
    Select Case txtCEP.Text.Trim.Length
      Case 2
        txtCEP.AppendText(".")
      Case 6
        txtCEP.AppendText("-")
      Case 8
        If FNC_SoNumero(txtCEP.Text).Trim.Length = 8 Then
          txtCEP.Text = FNC_Formatar_CEP(txtCEP.Text)
        End If
    End Select
  End Sub

  Public Property Texto As String
    Get
      Return txtCEP.Text
    End Get
    Set(sValor As String)
      txtCEP.Text = FNC_Formatar_CEP(sValor)
    End Set
  End Property

  Public Sub Limpar()
    txtCEP.Text = ""
  End Sub

  Private Sub Alerta(bLimpar As Boolean)
    If bLimpar Then
      txtCEP.BackColor = System.Drawing.SystemColors.Window
      txtCEP.ForeColor = System.Drawing.SystemColors.WindowText
    Else
      txtCEP.BackColor = Color.Red
      txtCEP.ForeColor = Color.White
    End If
  End Sub
End Class
