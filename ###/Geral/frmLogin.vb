Public Class frmLogin
  Public AcessoLiberado As Boolean = False

  Private Sub cmdLogin_Acessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin_Acessar.Click
    If Not ComboBox_Selecionado(cboLogin_Usuario) Then
      FNC_Mensagem("Selecione o funcionário de acesso")
      Exit Sub
    End If
    If TextBox_CampoVazio(txtLogin_Senha) Then
      FNC_Mensagem("Informe a senha")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboEmpresa) Then
      FNC_Mensagem("Selecione a empresa")
      Exit Sub
    End If

    Dim bEncerrarAplicacao As Boolean

    If DBUsuario_ValidarSenha(cboLogin_Usuario.SelectedValue, txtLogin_Senha.Text, bEncerrarAplicacao) Then
      Dim sSqlText As String

      sSqlText = DBMontar_Update("TB_SEG_USUARIO", FNC_GerarArray("DT_ULTIMO_ACESSO", "@DT_ULTIMO_ACESSO", _
                                                                  "CD_VERSAO_SISTEMA", "@CD_VERSAO_SISTEMA"), _
                                                   FNC_GerarArray("ID_USUARIO", "@ID_USUARIO"))
      DBExecutar(sSqlText, DBParametro_Montar("DT_ULTIMO_ACESSO", Now()), _
                           DBParametro_Montar("CD_VERSAO_SISTEMA", Application.ProductVersion), _
                           DBParametro_Montar("ID_USUARIO", iID_USUARIO))

      AcessoLiberado = True
      iID_EMPRESA_FILIAL = cboEmpresa.SelectedValue
      iID_EMPRESA_MATRIZ = cboEmpresa.SelectedItem(enCombox_Empresa.ID_EMPRESA_MATRIZ)
      sNO_EMPRESA_FILIAL = cboEmpresa.Text

      My.Settings.Login_IDUsuario = cboLogin_Usuario.SelectedValue
      My.Settings.Login_IDEmpresa = cboEmpresa.SelectedValue
      My.Settings.Save()

      Me.Close()
    Else
      If bEncerrarAplicacao Then Me.Close()
    End If
  End Sub

  Private Sub cmdLogin_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin_Cancelar.Click
    Me.Close()
  End Sub

  Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    eSistema = enSistema.Gerencial
    Select Case eSistema
      Case enSistema.PDV
        ComboBox_CarregarUsuario(cboLogin_Usuario, enComboBox_Usuario_TipoTela.PDV)
      Case enSistema.Gerencial
        ComboBox_CarregarUsuario(cboLogin_Usuario, enComboBox_Usuario_TipoTela.Empresa)
    End Select

    ComboBox_Carregar(cboEmpresa, enComboBox.Empresa)

    ComboBox_Possicionar(cboLogin_Usuario, My.Settings.Login_IDUsuario)
    ComboBox_Possicionar(cboEmpresa, My.Settings.Login_IDEmpresa)

    txtLogin_Senha.Focus()
  End Sub
End Class
