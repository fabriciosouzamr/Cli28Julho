Public Class uscImpressoes
  Public Event AntesGravacao(ByRef bCancelar As Boolean)

  Public Enum enCadastroOrigem
    CadastroPessoa = 1
    CadastroAtendimento = 2
  End Enum

  Class clsEditorImpressoes
    Public iSQ_PESSOA_ANEXO As Integer
    Public iID_OPT_TIPO_ANEXO As Integer
  End Class

  Public CadastroOrigem As enCadastroOrigem = enCadastroOrigem.CadastroAtendimento
  Public iID_PESSOA As Integer
  Public iID_ATENDIMENTO As Integer
  Public sCD_ATENDIMENTO As String

  Private Sub pnlImpressoes_Botoes_Resize(sender As Object, e As EventArgs) Handles pnlImpressoes_Botoes.Resize
    cmdImpressoes_Gravar.Left = pnlImpressoes_Botoes.Width - cmdImpressoes_Gravar.Width - 5
  End Sub

  Private Sub tvwModeloDocumento_BeforeSelect(sender As Object, e As TreeViewCancelEventArgs) Handles tvwModeloDocumento.BeforeSelect
    If e.Node.Text = "<Novo Documento Em Branco>" Or e.Node.Text = "<Novo Documento>" Then
      RaiseEvent AntesGravacao(Nothing)
    End If

    oEditorImpressoes.SoLeitura = True

    Select Case CadastroOrigem
      Case enCadastroOrigem.CadastroAtendimento
        oEditorImpressoes.IDENTIFICADOR = iID_ATENDIMENTO
      Case enCadastroOrigem.CadastroPessoa
        oEditorImpressoes.IDENTIFICADOR = iID_PESSOA
    End Select

    If e.Node.Text = "<Novo Documento Em Branco>" Then
      oEditorImpressoes.Limpar()
      oEditorImpressoes.Tag = New clsEditorImpressoes
      oEditorImpressoes.Tag.iID_OPT_TIPO_ANEXO = enOpcoes.TipoModeloDocumento_Anexo.GetHashCode
      oEditorImpressoes.SoLeitura = False
    ElseIf e.Node.Text = "<Novo Documento>" Then
      oEditorImpressoes.Limpar()
      oEditorImpressoes.MODELODOCUMENTO = e.Node.Parent.Tag
      oEditorImpressoes.Tag = New clsEditorImpressoes
      oEditorImpressoes.Tag.iID_OPT_TIPO_ANEXO = e.Node.Parent.Parent.Tag
      oEditorImpressoes.SoLeitura = False
    ElseIf e.Node.Nodes.Count = 0 And Not e.Node.Parent Is Nothing Then
      Dim oData As DataTable
      Dim sSqlText As String

      sSqlText = "SELECT * FROM TB_PESSOA_ANEXO WHERE SQ_PESSOA_ANEXO = " & e.Node.Tag
      oData = DBQuery(sSqlText)

      With oData.Rows(0)
        oEditorImpressoes.Rtf = .Item("TX_ANOTACAO")
        oEditorImpressoes.Tag = New clsEditorImpressoes
        oEditorImpressoes.Tag.iID_OPT_TIPO_ANEXO = e.Node.Parent.Parent.Tag
        oEditorImpressoes.Tag.iSQ_PESSOA_ANEXO = .Item("SQ_PESSOA_ANEXO")
      End With

      oData.Dispose()
      oData = Nothing
    End If
  End Sub

  Private Sub cmdImpressoes_Gravar_Click(sender As Object, e As EventArgs) Handles cmdImpressoes_Gravar.Click
    If oEditorImpressoes.Tag Is Nothing Then Exit Sub
    If Trim(oEditorImpressoes.Texto) = "" Then
      FNC_Mensagem("Informe o texto desse documento")
      Exit Sub
    End If
    If iID_PESSOA = 0 Then
      FNC_Mensagem("Selecione o paciente")
      Exit Sub
    End If

    Dim bCancelar As Boolean

    RaiseEvent AntesGravacao(bCancelar)

    If bCancelar Then Exit Sub

    Dim sDS_ANEXO As String = ""

    Select Case oEditorImpressoes.Tag.iID_OPT_TIPO_ANEXO
      Case enOpcoes.TipoModeloDocumento_Anexo
      Case enOpcoes.TipoModeloDocumento_Contrato
        sDS_ANEXO = "Contrato"
      Case enOpcoes.TipoModeloDocumento_Exame
        sDS_ANEXO = "Exame Médico"
      Case enOpcoes.TipoModeloDocumento_Receita
        sDS_ANEXO = "Receita Médica"
      Case enOpcoes.TipoModeloDocumento_Recibo
        sDS_ANEXO = "Recibo"
    End Select

    FNC_Anexo_Gravar(oEditorImpressoes.Tag.iSQ_PESSOA_ANEXO,
                     iID_PESSOA,
                     oEditorImpressoes.MODELODOCUMENTO,
                     oEditorImpressoes.Tag.iID_OPT_TIPO_ANEXO,
                     iID_ATENDIMENTO,
                     0,
                     sDS_ANEXO & IIf(Trim(sCD_ATENDIMENTO) = "", "", " - " & sCD_ATENDIMENTO),
                     Now(),
                     Nothing,
                     oEditorImpressoes.Rtf)

    tvwModeloDocumento.SelectedNode.Parent.Nodes.Add("K3." & oEditorImpressoes.Tag.iSQ_PESSOA_ANEXO, Now()).Tag = oEditorImpressoes.Tag.iSQ_PESSOA_ANEXO
  End Sub

  Public Sub Limpar()
    oEditorImpressoes.Limpar()
    oEditorImpressoes.SoLeitura = True
    tvwModeloDocumento.Nodes.Clear()
  End Sub

  Public Sub Carregar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer
    Dim oNode As TreeNode

    tvwModeloDocumento.Nodes.Clear()

    If iID_PESSOA = 0 Then Exit Sub

    tvwModeloDocumento.Nodes.Add("K1.0", "<Novo Documento Em Branco>").Tag = 0
    TVWModeloDocumento_Anexo_Carregar(tvwModeloDocumento.Nodes(tvwModeloDocumento.Nodes.IndexOfKey("K1.0")), 0)

    sSqlText = "SELECT * FROM TB_OPCAO WHERE SQ_OPCAO IN (" & enOpcoes.TipoModeloDocumento_Exame.GetHashCode & ", " & _
                                                              enOpcoes.TipoModeloDocumento_Receita.GetHashCode & ")"
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      With oData.Rows(iCont)
        tvwModeloDocumento.Nodes.Add("K1." & .Item("SQ_OPCAO"), .Item("NO_OPCAO")).Tag = .Item("SQ_OPCAO")
      End With
    Next

    sSqlText = "SELECT * FROM TB_MODELODOCUMENTO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND IC_ATIVO = 'S'" &
                 " AND ID_OPT_TIPO_MODELODOCUMENTO IN (" & enOpcoes.TipoModeloDocumento_Exame.GetHashCode & ", " &
                                                           enOpcoes.TipoModeloDocumento_Receita.GetHashCode & ")"
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      With tvwModeloDocumento.Nodes(tvwModeloDocumento.Nodes.IndexOfKey("K1." & oData.Rows(iCont).Item("ID_OPT_TIPO_MODELODOCUMENTO")))
        oNode = .Nodes.Add("K2." & oData.Rows(iCont).Item("SQ_MODELODOCUMENTO"), oData.Rows(iCont).Item("NO_MODELODOCUMENTO"))
        oNode.Tag = oData.Rows(iCont).Item("SQ_MODELODOCUMENTO")
        oNode.Nodes.Add("K3." & oData.Rows(iCont).Item("SQ_MODELODOCUMENTO"), "<Novo Documento>").Tag = oData.Rows(iCont).Item("SQ_MODELODOCUMENTO")

        TVWModeloDocumento_Anexo_Carregar(oNode, oData.Rows(iCont).Item("SQ_MODELODOCUMENTO"))
      End With
    Next
  End Sub

  Private Sub TVWModeloDocumento_Anexo_Carregar(oNode As TreeNode, iID_MODELODOCUMENTO As Integer)
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    sSqlText = "SELECT * FROM TB_PESSOA_ANEXO" &
               " WHERE ID_PESSOA = " & iID_PESSOA &
                 " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND ISNULL(ID_MODELODOCUMENTO, 0) = " & iID_MODELODOCUMENTO &
               " ORDER BY DT_ANEXO"
    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      oNode.Nodes.Add("K3." & oData.Rows(iCont).Item("SQ_PESSOA_ANEXO"), oData.Rows(iCont).Item("DT_ANEXO")).Tag = oData.Rows(iCont).Item("SQ_PESSOA_ANEXO")
    Next
  End Sub

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

    Limpar()
  End Sub
End Class
