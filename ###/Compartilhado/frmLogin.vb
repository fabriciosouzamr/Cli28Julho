Public Class frmLogin
  Public AcessoLiberado As Boolean = False
  Dim bCarregando As Boolean

  Private Sub cmdLogin_Acessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin_Acessar.Click
    If Not ComboBox_Selecionado(cboLogin_Usuario) Then
      FNC_Mensagem("Selecione o funcionário de acesso")
      Exit Sub
    End If
    If txtLogin_Senha.Senha.Trim() = "" Then
      FNC_Mensagem("Informe a senha")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboEmpresa) Then
      FNC_Mensagem("Selecione a empresa")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboServidor) Then
      FNC_Mensagem("Selecione o servidor")
      Exit Sub
    End If

    Dim bEncerrarAplicacao As Boolean

    If DBUsuario_ValidarSenha(cboLogin_Usuario.SelectedValue, txtLogin_Senha.Senha, bEncerrarAplicacao) Then
      Dim sSqlText As String

      sSqlText = "SELECT COUNT(*)" &
                 " FROM VW_SEG_USUARIO_ACESSO_GERAL" &
                 " WHERE ID_USUARIO = " & iID_USUARIO

      If DBQuery_ValorUnico(sSqlText) > 0 Then
        AcessoLiberado = True
        iID_EMPRESA_FILIAL = cboEmpresa.SelectedValue
        sID_EMPRESA_CNPJ = cboEmpresa.SelectedItem(enCombox_Empresa.CD_CNPJ)
        iID_EMPRESA_MATRIZ = cboEmpresa.SelectedItem(enCombox_Empresa.ID_EMPRESA_MATRIZ)
        iID_EMPRESA_CIDADE = FNC_NVL(cboEmpresa.SelectedItem(enCombox_Empresa.ID_CIDADE), 0)
        iID_EMPRESA_UF = FNC_NVL(cboEmpresa.SelectedItem(enCombox_Empresa.ID_UF), 0)
        sCD_EMPRESA_UF = FNC_NVL(cboEmpresa.SelectedItem(enCombox_Empresa.CD_UF), "")
        iID_EMPRESA_PAIS = FNC_NVL(cboEmpresa.SelectedItem(enCombox_Empresa.ID_PAIS), 0)
        sNO_EMPRESA_FILIAL = cboEmpresa.Text

        sSqlText = DBMontar_Update("TB_SEG_USUARIO_EMPRESA", FNC_GerarArray("DT_ULTIMO_ACESSO", "@DT_ULTIMO_ACESSO",
                                                                            "CD_VERSAO_SISTEMA", "@CD_VERSAO_SISTEMA",
                                                                            "NO_COMPUTADOR_NOME", "@NO_COMPUTADOR_NOME"),
                                                             FNC_GerarArray("ID_USUARIO", "@ID_USUARIO", " AND ",
                                                                            "ID_EMPRESA", "@ID_EMPRESA"))
        DBExecutar(sSqlText, DBParametro_Montar("DT_ULTIMO_ACESSO", Now()),
                             DBParametro_Montar("CD_VERSAO_SISTEMA", Application.ProductVersion),
                             DBParametro_Montar("NO_COMPUTADOR_NOME", FNC_Computador_Nome),
                             DBParametro_Montar("ID_USUARIO", iID_USUARIO),
                             DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_MATRIZ))

        My.Settings.Login_IDUsuario = cboLogin_Usuario.SelectedValue
        My.Settings.Login_IDEmpresa = cboEmpresa.SelectedValue
        My.Settings.Login_IDServidor = cboServidor.SelectedValue
        My.Settings.Save()

        bUSUARIO_ADMINISTRADOR = (Convert.ToInt32(cboLogin_Usuario.SelectedValue) = 1)

        Me.Close()
      Else
        FNC_Mensagem("Usuário sem acesso a empresa selecionada")
      End If
    Else
      If bEncerrarAplicacao Then Me.Close()
    End If
  End Sub

  Private Sub cmdLogin_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin_Cancelar.Click
    Me.Close()
  End Sub

  Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    eSistema = enSistema.Empresa

    ComboBox_CarregarServidor()
  End Sub

  Private Sub ComboBox_CarregarServidor()
    Dim iCont As Integer
    Dim oTexto() As String
    Dim oCodigo() As Object

    For iCont = 1 To FNC_ConfiguracaoAplicacao("Serv_Numeros")
      ReDim Preserve oTexto(iCont - 1)
      ReDim Preserve oCodigo(iCont - 1)

      oTexto(iCont - 1) = FNC_ConfiguracaoAplicacao("Serv" & FNC_StrZero(iCont, 2) & "_Nome")
      oCodigo(iCont - 1) = iCont
    Next

    bCarregando = True
    ComboBox_Carregar(cboServidor, oTexto, oCodigo)
    cboServidor.SelectedIndex = -1
    bCarregando = False

    If cboServidor.Items.Count = 1 Then
      Me.Height = 212
      lblRServidor.Visible = False
      cboServidor.Visible = False

      cboServidor.SelectedIndex = 0
    Else
      ComboBox_Selecionar(cboServidor, My.Settings.Login_IDServidor)
    End If
  End Sub

  Private Sub cboServidor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServidor.SelectedIndexChanged
    If ComboBox_Selecionado(cboServidor) And Not bCarregando Then
      Try
        cboLogin_Usuario.DataSource = Nothing
        cboEmpresa.DataSource = Nothing

        If DBConectarServidor(cboServidor.SelectedValue) Then
          Select Case eSistema
            Case enSistema.PDV
              ComboBox_CarregarUsuario(cboLogin_Usuario, enComboBox_Usuario_TipoTela.PDV)
            Case enSistema.Empresa
              ComboBox_CarregarUsuario(cboLogin_Usuario, enComboBox_Usuario_TipoTela.Empresa)
          End Select

          ComboBox_Carregar(cboEmpresa, enSql.EmpresaAtiva)

          ComboBox_Selecionar(cboLogin_Usuario, My.Settings.Login_IDUsuario)
          ComboBox_Selecionar(cboEmpresa, My.Settings.Login_IDEmpresa)

          txtLogin_Senha.Focus()

          FNC_ExecutarScript()
        Else
          FNC_Mensagem("Houve algum problema pra conectar ao banco de dados")
        End If
      Catch ex As Exception
        FNC_Mensagem(ex.Message)
      End Try
    End If
  End Sub
End Class
