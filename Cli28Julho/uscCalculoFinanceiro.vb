Public Class uscCalculoFinanceiro
  Public Event Atualizado()

  Dim sRotulo As String = "Juros"

  Public Property PeriodoCalculoFinanceiro As Object
    Get
      Try
        Return cboPeriodoCalculoFinanceiro.SelectedValue
      Catch ex As Exception
      End Try
    End Get
    Set(value As Object)
      Try
        ComboBox_Selecionar(cboPeriodoCalculoFinanceiro, value)
      Catch ex As Exception
      End Try
    End Set
  End Property

  Public Property Valor As Decimal
    Get
      Return FNC_NVL(txtValor.Value, 0)
    End Get
    Set(value As Decimal)
      txtValor.Value = value
    End Set
  End Property

  Public Property Rotulo As String
    Get
      Return sRotulo
    End Get
    Set(value As String)
      sRotulo = value
      lblRotulo.Text = sRotulo + " (%)"
    End Set
  End Property

  Public Sub Inicializar(Optional ManterUnico As Boolean = False)
    ComboBox_Carregar(cboPeriodoCalculoFinanceiro, enSql.PeriodoCalculoFinanceiro)
    ComboBox_Selecionar(cboPeriodoCalculoFinanceiro, enOpcoes.PeriodoCalculoFinanceiro_AoMes.GetHashCode())

    If ManterUnico Then
      ComboBox_Selecionar(cboPeriodoCalculoFinanceiro, enOpcoes.PeriodoCalculoFinanceiro_Unico.GetHashCode())
    Else
      cboPeriodoCalculoFinanceiro.Items.Remove(enOpcoes.PeriodoCalculoFinanceiro_Unico.GetHashCode())
    End If
  End Sub

  Private Sub txtValor_ValueChanged(sender As Object, e As EventArgs) Handles txtValor.ValueChanged
    RaiseEvent Atualizado()
  End Sub

  Private Sub cboPeriodoCalculoFinanceiro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPeriodoCalculoFinanceiro.SelectedIndexChanged
    RaiseEvent Atualizado()
  End Sub
End Class
