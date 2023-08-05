Imports System.IO

Public Class uscAnexo
  Const const_lvwAnexo_iAnexo As Integer = 0
  Const const_lvwAnexo_sArquivo As Integer = 1
  Const const_lvwAnexo_sTexto As Integer = 2
  Const const_lvwAnexo_Anotacao As Integer = 3
  Const const_lvwAnexo_TipoAnexo As Integer = 4

  Public iID_PESSOA As Integer
  Public iID_ATENDIMENTO As Integer
  Public iID_PESSOA_AGENDA As Integer

  Public oTipoAnexo_Grupo() As String = New String() {const_TipoAnexo_Grupo_Anexo}

  Dim oimlAnexo As New ImageList

  Public Sub TipoAnexo_Grupo_Adicionar(sTipoAnexo_Grupo)
    If oTipoAnexo_Grupo Is Nothing Then
      ReDim oTipoAnexo_Grupo(0)
    Else
      ReDim Preserve oTipoAnexo_Grupo(oTipoAnexo_Grupo.Length)
    End If

    oTipoAnexo_Grupo(oTipoAnexo_Grupo.Length - 1) = sTipoAnexo_Grupo
  End Sub

  Private Sub uscAnexo_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    AjustarTela()
  End Sub

  Private Sub AjustarTela()
    lvwAnexos.Height = Me.Height - 10
    cmdAnexo_Imprimir.Top = Me.Height - cmdAnexo_Imprimir.Height - 5
    cmdAnexo_Imprimir.Left = Me.Width - cmdAnexo_Imprimir.Width - 6
    cmdAnexo_Novo.Top = cmdAnexo_Imprimir.Top
    cmdAnexo_Excluir.Top = cmdAnexo_Imprimir.Top
    cmdAnexo_SelecionarNovoArquivo.Top = cmdAnexo_Imprimir.Top
    cmdAnexo_ObterFoto.Top = cmdAnexo_Imprimir.Top
    cmdAnexo_Digitalizacao.Top = cmdAnexo_Imprimir.Top
    tabAnexo.Height = cmdAnexo_Imprimir.Top - tabAnexo.Top - 5
    tabAnexo.Width = Me.Width - tabAnexo.Left - 5
  End Sub

  Private Sub cmdAnexo_SelecionarNovoArquivo_Click(sender As Object, e As EventArgs) Handles cmdAnexo_SelecionarNovoArquivo.Click
    Anexo_AbrirArquivo(FNC_Arquivo_Dialogo_Abrir())
  End Sub

  Private Sub Anexo_RemoverTab()
    tabAnexo.TabPages.Remove(tbpAnexo_TextoRTF)
    tabAnexo.TabPages.Remove(tbpAnexo_Imagem)
    tabAnexo.TabPages.Remove(tbpAnexo_PDF)
  End Sub

  Private Function Anexo_AbrirArquivo_Minuatura(sArquivo) As Boolean
    Dim sArquivo_Tipo As String

    If Trim(sArquivo) = "" Then
      Return False
    Else
      sArquivo_Tipo = FNC_Arquivo_Tipo(Path.GetExtension(sArquivo))

      Return (InStr(sArquivo_Tipo, "Image") > 0)
    End If
  End Function

  Private Sub Anexo_AbrirArquivo(sArquivo)
    Dim sArquivo_Tipo As String

    Anexo_RemoverTab()

    sArquivo_Tipo = FNC_Arquivo_Tipo(Path.GetExtension(sArquivo))

    Try
      If Mid(sArquivo_Tipo, 1, Len("Adobe Acrobat")) = "Adobe Acrobat" Then
        AcrobatVisualizador.src = sArquivo
        tabAnexo.TabPages.Insert(0, tbpAnexo_PDF)
        tabAnexo.SelectTab(0)
      ElseIf sArquivo_Tipo = "Text Document" Or sArquivo_Tipo = "Rich Text Format" Then
        rctAnexo.CarregarArquivo(sArquivo)
        tabAnexo.TabPages.Insert(0, tbpAnexo_TextoRTF)
        tabAnexo.SelectTab(0)
      ElseIf InStr(sArquivo_Tipo, "Image") > 0 Then
        picAnexo_Imagem.Arquivo = sArquivo
        tabAnexo.TabPages.Insert(0, tbpAnexo_Imagem)
        tabAnexo.SelectTab(0)
      End If

      txtAnexo_Descricao.Text = Path.GetFileNameWithoutExtension(sArquivo)
      txtAnexo_Descricao.Tag = 0
      lblAnexo_NomeArquivo.Text = "Nome do Arquivo: " & sArquivo
      lblAnexo_NomeArquivo.Tag = sArquivo

      AjustarTela()
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Private Sub Anexo_Adicionar(sTitulo As String, sTexto As String, sArquivo As String, iAnexo As Integer, sAnotacao As String, bUsarMiniatura As Boolean)
    Dim sChave As String = ""

    Try
      sChave = Guid.NewGuid.ToString

      If Trim(sArquivo) <> "" Then
        If bUsarMiniatura Then
          oimlAnexo.Images.Add(sChave, FNC_Imagem_Minuatura(sArquivo, oimlAnexo.ImageSize.Width, oimlAnexo.ImageSize.Height))
        Else
          Dim oImagem As New clsExtracticon

          oimlAnexo.Images.Add(sChave, oImagem.IconToBitmap(oImagem.IconAsociado(sArquivo)))
        End If
      End If
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
    Try
      With lvwAnexos.Items.Add(sTitulo)
        .ImageKey = sChave
        .Tag = New Object() {iAnexo, sArquivo, sTexto, sAnotacao}
      End With
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Private Sub cmdAnexo_Gravar_Click(sender As Object, e As EventArgs) Handles cmdAnexo_Gravar.Click
    Dim bAdicionar As Boolean

    If Not IsDate(txtAnexo_Data.Text) Then
      FNC_Mensagem("Informe o horário a data do documento")
      Exit Sub
    End If
    If Trim(txtAnexo_Descricao.Text) = "" Then
      FNC_Mensagem("Informe a descrição do documento")
      Exit Sub
    End If
    If Dir(lblAnexo_NomeArquivo.Tag) = "" Or lblAnexo_NomeArquivo.Tag = "" Then
      FNC_Mensagem("Selecione ou obtenha um arquivo ou imagem")
      Exit Sub
    End If
    If iID_PESSOA = 0 Then
      FNC_Mensagem("Selecione a pessoa")
      Exit Sub
    End If

    lblAnexo_NomeArquivo.Tag = FNC_DiretorioSistema_GuardarArquivo(lblAnexo_NomeArquivo.Tag)
    bAdicionar = (FNC_NVL(txtAnexo_Descricao.Tag, 0) = 0)

    If FNC_Anexo_Gravar(txtAnexo_Descricao.Tag,
                        iID_PESSOA,
                        0,
                        enOpcoes.TipoModeloDocumento_Anexo.GetHashCode,
                        iID_ATENDIMENTO,
                        iID_PESSOA_AGENDA,
                        Trim(txtAnexo_Descricao.Text),
                        txtAnexo_Data.DateTime,
                        FNC_DiretorioSistema_RemoverPath(lblAnexo_NomeArquivo.Tag),
                        oEditor_Anotacao.Rtf) Then
      If DBTeveRetorno() Then
        txtAnexo_Descricao.Tag = DBRetorno(1)
      End If

      If bAdicionar Then
        Anexo_Adicionar(Trim(txtAnexo_Descricao.Text),
                        Trim(txtAnexo_Descricao.Text),
                        lblAnexo_NomeArquivo.Tag,
                        txtAnexo_Descricao.Tag,
                        oEditor_Anotacao.Rtf,
                        Anexo_AbrirArquivo_Minuatura(lblAnexo_NomeArquivo.Tag))
      End If

      FNC_Mensagem("Arquivo anexado")
    End If
  End Sub

  Private Sub cmdAnexo_Excluir_Click(sender As Object, e As EventArgs) Handles cmdAnexo_Excluir.Click
    Dim sSqlText As String
    Dim iCont As Integer

    If FNC_NVL(txtAnexo_Descricao.Tag, 0) = 0 Then
      FNC_Mensagem("Selecione o arquivo a ser excluído")
      Exit Sub
    End If

    sSqlText = DBMontar_SP("SP_PESSOA_ANEXO_DEL", False, "@SQ_PESSOA_ANEXO")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_PESSOA_ANEXO", FNC_NVL(txtAnexo_Descricao.Tag, 0)))

    For iCont = 0 To lvwAnexos.Items.Count - 1
      If lvwAnexos.Items(iCont).Tag(const_lvwAnexo_iAnexo) = FNC_NVL(txtAnexo_Descricao.Tag, 0) Then
        lvwAnexos.Items.RemoveAt(iCont)
        Exit For
      End If
    Next

    FNC_RepositorioArquivo_ExcluirArquivo(lblAnexo_NomeArquivo.Tag)

    cmdAnexo_Novo.PerformClick()

    FNC_Mensagem("Arquivo excluído")
  End Sub

  Public Sub Inicializar()
    lvwAnexos.Items.Clear()
    oimlAnexo.Images.Clear()
    picAnexo_Imagem.Zoom()

    Limpar()
  End Sub

  Public Sub Carregar()
    Dim oData As DataTable
    Dim sSqlText As String
    Dim iCont As Integer

    Inicializar()

    sSqlText = "SELECT * FROM VW_PESSOA_ANEXO" &
               " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                 " AND CD_TIPO_ANEXO IN (" & FNC_Array_Para_Lista(oTipoAnexo_Grupo, , True) & ")"

    If iID_PESSOA > 0 Then
      sSqlText = sSqlText &
                 " AND ID_PESSOA = " & iID_PESSOA
    End If
    If iID_PESSOA_AGENDA > 0 Then
      sSqlText = sSqlText &
                 " AND ID_PESSOA_AGENDA = " & iID_PESSOA_AGENDA
    Else
      sSqlText = sSqlText &
                 " AND ID_PESSOA_AGENDA IS NULL"
    End If

    oData = DBQuery(sSqlText)

    For iCont = 0 To oData.Rows.Count - 1
      With oData.Rows(iCont)
        Anexo_Adicionar(.Item("DS_ANEXO") &
                        IIf(.Item("ID_OPT_TIPO_ANEXO") = enOpcoes.TipoModeloDocumento_Receita.GetHashCode, vbCrLf & .Item("CD_ATENDIMENTO"), "") &
                        vbCrLf & .Item("DT_ANEXO").ToString,
                        .Item("DS_ANEXO"),
                        FNC_DiretorioSistema_AdicionarPath(FNC_NVL(.Item("DS_PATH_ANEXO"), "")),
                        .Item("SQ_PESSOA_ANEXO"),
                        .Item("TX_ANOTACAO"),
                        Anexo_AbrirArquivo_Minuatura(FNC_DiretorioSistema_AdicionarPath(FNC_NVL(.Item("DS_PATH_ANEXO"), ""))))
      End With
    Next
  End Sub

  Private Sub lvwAnexos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwAnexos.SelectedIndexChanged
    If lvwAnexos.SelectedItems.Count > 0 Then
      With lvwAnexos.SelectedItems(0)
        Anexo_AbrirArquivo(.Tag(const_lvwAnexo_sArquivo))
        txtAnexo_Descricao.Text = .Tag(const_lvwAnexo_sTexto)
        txtAnexo_Descricao.Tag = .Tag(const_lvwAnexo_iAnexo)
        lblAnexo_NomeArquivo.Text = "Nome do Arquivo: " & .Tag(const_lvwAnexo_sArquivo)
        lblAnexo_NomeArquivo.Tag = .Tag(const_lvwAnexo_sArquivo)
        oEditor_Anotacao.Rtf = .Tag(const_lvwAnexo_Anotacao)
      End With
    End If
  End Sub

  Public Sub New()
    InitializeComponent()

    lvwAnexos.LargeImageList = oimlAnexo
    lvwAnexos.LargeImageList.ImageSize = New Size(48, 48)

    Limpar()
    cmdAnexo_Novo.PerformClick()
  End Sub

  Public Sub Limpar()
    Anexo_RemoverTab()
    rctAnexo.Limpar()
    rctAnexo.SoLeitura = True
    picAnexo_Imagem.HabilitarBotoes = False
  End Sub

  Private Sub cmdAnexo_Imprimir_Click(sender As Object, e As EventArgs) Handles cmdAnexo_Imprimir.Click
    If tabAnexo.TabPages(0) Is tbpAnexo_PDF Then
      AcrobatVisualizador.Print()
    ElseIf tabAnexo.TabPages(0) Is tbpAnexo_TextoRTF Then
      rctAnexo.Imprimir()
    ElseIf tabAnexo.TabPages(0) Is tbpAnexo_Imagem Then
      picAnexo_Imagem.Imprimir()
    End If
  End Sub

  Private Sub picAnexo_Imagem_ImagemAlterada() Handles picAnexo_Imagem.ImagemAlterada
    lblAnexo_NomeArquivo.Text = "Nome Arquivo: " & picAnexo_Imagem.Arquivo
    lblAnexo_NomeArquivo.Tag = picAnexo_Imagem.Arquivo
  End Sub

  Private Sub cmdAnexo_Novo_Click(sender As Object, e As EventArgs) Handles cmdAnexo_Novo.Click
    Anexo_RemoverTab()
    txtAnexo_Data.Value = Now
    txtAnexo_Descricao.Text = ""
    lblAnexo_NomeArquivo.Text = ""
    lblAnexo_NomeArquivo.Tag = ""
    oEditor_Anotacao.Limpar()
  End Sub

  Private Sub cmdAnexo_ObterFoto_Click(sender As Object, e As EventArgs) Handles cmdAnexo_ObterFoto.Click
    Anexo_RemoverTab()
    tabAnexo.TabPages.Insert(0, tbpAnexo_Imagem)
    tabAnexo.SelectTab(0)
    picAnexo_Imagem.ObterFoto()
  End Sub

  Private Sub cmdAnexo_Digitalizacao_Click(sender As Object, e As EventArgs) Handles cmdAnexo_Digitalizacao.Click
    Anexo_RemoverTab()
    tabAnexo.TabPages.Insert(0, tbpAnexo_Imagem)
    tabAnexo.SelectTab(0)
    picAnexo_Imagem.Digitalizar()
  End Sub
End Class
