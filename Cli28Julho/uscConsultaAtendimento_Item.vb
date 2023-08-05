Public Class uscConsultaAtendimento_Item
  Public Event Chamar(sender As Object)
  Public Event Atender(sender As Object)

  Public iSQ_AGENDAMENTO As Integer
  Public iID_OPT_STATUS As Integer

  Public Sub Formatar()
    Limpar()
    cmdAtendimento.Formatar(enOpcoes.ConfiguracaoTela_Botao_Disponivel)
    cmdChamar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Chamar)
    cmdChamar.Visible = False
    cmdAtendimento.Enabled = False

    Background(True)
  End Sub

  Public Sub Limpar()
    lblNumero.Text = ""
    lblPaciente.Text = ""
    lblIdade.Text = ""
    lblTipoAtendimento.Text = ""
    lblStatus.Text = ""
    lblConfirmacaoChegada.Text = ""
    cmdAtendimento.Formatar(enOpcoes.ConfiguracaoTela_Botao_Disponivel)
    cmdChamar.Visible = False
  End Sub

  Public Sub BotoesExibir(bAtendido As Boolean)
    cmdChamar.Visible = (Not bAtendido)
    cmdAtendimento.Enabled = True

    If bAtendido Then
      cmdAtendimento.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atendido)
    Else
      cmdAtendimento.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atender)
    End If
  End Sub

  Private Sub cmdChamar_Clicado(sender As Object) Handles cmdChamar.Clicado
    RaiseEvent Chamar(Me)
  End Sub

  Private Sub cmdAtendimento_Clicado(sender As Object) Handles cmdAtendimento.Clicado
    RaiseEvent Atender(Me)
  End Sub

  Public Sub Disponivel()
    cmdAtendimento.Formatar(enOpcoes.ConfiguracaoTela_Botao_Disponivel)
    cmdAtendimento.Enabled = False
    cmdChamar.Enabled = False
    cmdChamar.Visible = False
  End Sub

  Public Sub Atendido()
    cmdAtendimento.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atendido)
    cmdAtendimento.Enabled = False
    cmdChamar.Enabled = False
    cmdChamar.Visible = False
  End Sub

  Public Sub Reserva()
    cmdAtendimento.Formatar(enOpcoes.ConfiguracaoTela_Botao_Reserva)
    cmdAtendimento.Enabled = True
    cmdChamar.Enabled = False
    cmdChamar.Visible = False
  End Sub

  Public ReadOnly Property TipoBotao As Integer
    Get
      Return cmdAtendimento.TipoBotao
    End Get
  End Property


  Private Sub Background(Habilitado As Boolean)
    If Habilitado Then
      Me.BackgroundImage = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_TelaInicial_Itens))
    Else
      Me.BackgroundImage = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.ConfiguracaoTela_Atendimento_Medico_TelaInicial_ItensDesabilitados))
    End If
  End Sub
End Class
