Public Class frmClinica_Configuracao
  Dim bCarregandoTela As Boolean

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    oCadClinicaConfiguracao.Gravar()

    Dim sSqlText As String

    sSqlText = "UPDATE TB_EMPRESA SET DS_RECEITUARIO = @DS_RECEITUARIO, DS_ATESTADO = @DS_ATESTADO WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL

    DBExecutar(sSqlText, DBParametro_Montar("DS_RECEITUARIO", txtReceituario.Text),
                         DBParametro_Montar("DS_ATESTADO", txtAtestado.Text))

    FNC_Mensagem("Gravação Efetuada")
  End Sub

  Private Sub frmClinica_Configuracao_Load(sender As Object, e As EventArgs) Handles Me.Load
    oCadClinicaConfiguracao.Formatar()

    Dim sSqlText As String
    Dim oData As DataTable

    sSqlText = "SELECT * FROM TB_EMPRESA WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL
    oData = DBQuery(sSqlText)

    If Not objDataTable_Vazio(oData) Then
      txtReceituario.Text = FNC_NVL(oData.Rows(0).Item("DS_RECEITUARIO"), "")
      txtAtestado.Text = FNC_NVL(oData.Rows(0).Item("DS_ATESTADO"), "")
    End If

    cmdGravar.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_Configuracao).bGravar
  End Sub
End Class