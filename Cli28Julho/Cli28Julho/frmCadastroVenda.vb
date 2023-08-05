Public Class frmCadastroVenda
  Public Event GravacaoEfetuada()

  Public iSQ_CLINICA_VENDA As Integer
  Public iID_PESSOA As Integer
  Public iID_ATENDIMENTO As Integer
  Public oID_AGENDAMENTO As Collection
  Public iID_ORCAMENTO_CLIENTE As Integer

  Private Sub uscCadastroVenda_Fechar() Handles uscCadastroVenda.Fechar
    Close()
  End Sub

  Private Sub frmCadastroVenda_Load(sender As Object, e As EventArgs) Handles Me.Load
    uscCadastroVenda.iSQ_CLINICA_VENDA = iSQ_CLINICA_VENDA
    uscCadastroVenda.iID_PESSOA = iID_PESSOA
    uscCadastroVenda.iID_ATENDIMENTO = iID_ATENDIMENTO
    uscCadastroVenda.oID_AGENDAMENTO = oID_AGENDAMENTO
    uscCadastroVenda.iID_ORCAMENTO_CLIENTE = iID_ORCAMENTO_CLIENTE
    uscCadastroVenda.Formatar()
  End Sub

  Private Sub uscCadastroVenda_GravacaoEfetuada() Handles uscCadastroVenda.GravacaoEfetuada
    RaiseEvent GravacaoEfetuada()
  End Sub
End Class