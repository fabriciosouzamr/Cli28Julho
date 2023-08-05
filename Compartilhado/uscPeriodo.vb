Public Class uscPeriodo
  Private Sub uscPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    txtDataInicial.Value = Nothing
    txtDataFinal.Value = Nothing
  End Sub

  Public Property Rotulo
    Get
      Return lblRotulo.Text
    End Get
    Set(value)
      lblRotulo.Text = value
    End Set
  End Property

  Public Property DataInicial As Date
    Get
      Return txtDataInicial.Value
    End Get
    Set(value As Date)
      Try
        txtDataInicial.Value = value
      Catch ex As Exception
      End Try
    End Set
  End Property

  Public Property DataFinal As Date
    Get
      Return txtDataFinal.Value
    End Get
    Set(value As Date)
      Try
        txtDataFinal.Value = value
      Catch ex As Exception
      End Try
    End Set
  End Property

  Public Function Validar() As Boolean
    Dim bOk As Boolean = False

    If IsDate(txtDataInicial.Value) And IsDate(txtDataFinal.Value) Then
      If txtDataInicial.Value > txtDataFinal.Value Then
        FNC_Mensagem("A data inicial de " & lblRotulo.Text & " não pode maior que a data final")
        GoTo Sair
      End If
    End If

    bOk = True

Sair:
    Return bOk
  End Function

  Public ReadOnly Property DataInicial_Valida As Boolean
    Get
      Return IsDate(txtDataInicial.Text)
    End Get
  End Property

  Public ReadOnly Property DataFinal_Valida As Boolean
    Get
      Return IsDate(txtDataFinal.Text)
    End Get
  End Property
End Class
