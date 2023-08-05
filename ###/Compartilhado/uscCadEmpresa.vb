Public Class uscCadEmpresa
  Public bConfiguracaoInicial As Boolean

  Public Sub Formatar()
    ComboBox_Carregar(cboTipoContribuicaoICMS, enSql.NFe_IndicadorIEDestinatario)

    ComboBox_Selecionar(cboTipoContribuicaoICMS, enOpcoes.NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS.GetHashCode)

    ComboBox_TipoContribuicaoICMS_Tratar()

    If bConfiguracaoInicial Then
      If Trim(txtDiretorio.Text) = "" Then
        txtDiretorio.Text = FNC_Diretorio_Tratar(sPathSistema) + "Arquivos"

        If Not System.IO.Directory.Exists(txtDiretorio.Text) Then
          MkDir(txtDiretorio.Text)
        End If
      End If
    End If
  End Sub

  Private Sub cboTipoContribuicaoICMS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoContribuicaoICMS.SelectedIndexChanged
    ComboBox_TipoContribuicaoICMS_Tratar()
  End Sub

  Private Sub cmdAbrirDiretorio_Click(sender As Object, e As EventArgs) Handles cmdAbrirDiretorio.Click
    txtDiretorio.Text = FNC_Pasta_Dialogo_Abrir()
  End Sub

  Private Sub ComboBox_TipoContribuicaoICMS_Tratar()
    Select Case Val(cboTipoContribuicaoICMS.SelectedValue)
      Case enOpcoes.NFe_IndicadorIEDestinatario_ContribuinteICMS.GetHashCode()
        txtInscricaoEstadual.Enabled = True
      Case enOpcoes.NFe_IndicadorIEDestinatario_ContribuinteIsentoInscricaoCadastroContribuintesICMS.GetHashCode()
        txtInscricaoEstadual.Text = "ISENTO"
        txtInscricaoEstadual.Enabled = False
      Case enOpcoes.NFe_IndicadorIEDestinatario_NaoContribuintePodeNaoIE_CadastroContribuintesICMS.GetHashCode()
        txtInscricaoEstadual.Text = ""
        txtInscricaoEstadual.Enabled = False
    End Select
  End Sub
End Class
