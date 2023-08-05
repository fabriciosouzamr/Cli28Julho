Public Class frmRichTextBox_Pesquisar
  Public ortbDoc As ExtendedRichTextBox.RichTextBoxPrintCtrl

  Private Sub cmdPequisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPequisar.Click
    Dim StartPosition As Integer
    Dim SearchType As CompareMethod

    If chkMaiusculaMinuscula.Checked = True Then
      SearchType = CompareMethod.Binary
    Else
      SearchType = CompareMethod.Text
    End If

    StartPosition = InStr(1, ortbDoc.Text, txtTextoPesquisa.Text, SearchType)

    If StartPosition = 0 Then
      MessageBox.Show("Texto: " & txtTextoPesquisa.Text.ToString() & " não encontrado", "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
      Exit Sub
    End If

    ortbDoc.Select(StartPosition - 1, txtTextoPesquisa.Text.Length)
    ortbDoc.ScrollToCaret()
    ortbDoc.Parent.Focus()
  End Sub

  Private Sub cmdProxima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProxima.Click
    Dim StartPosition As Integer = ortbDoc.SelectionStart + 2
    Dim SearchType As CompareMethod

    If chkMaiusculaMinuscula.Checked = True Then
      SearchType = CompareMethod.Binary
    Else
      SearchType = CompareMethod.Text
    End If

    StartPosition = InStr(StartPosition, ortbDoc.Text, txtTextoPesquisa.Text, SearchType)

    If StartPosition = 0 Then
      MessageBox.Show("Texto: " & txtTextoPesquisa.Text.ToString() & " não encontrado", "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
      Exit Sub
    End If

    ortbDoc.Select(StartPosition - 1, txtTextoPesquisa.Text.Length)
    ortbDoc.ScrollToCaret()
    ortbDoc.Parent.Focus()
  End Sub
End Class