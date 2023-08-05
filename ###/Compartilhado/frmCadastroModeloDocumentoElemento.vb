Public Class frmCadastroModeloDocumentoElemento
  Public Event Pesquisar()

  Public iSQ_MODELODOCUMENTO_ELEMENTO As Integer
  Public iTipoTela As Integer

  Dim sTermo As String
  Dim sTermo_Pred As String = " do "
  Dim sArquivo As String
  Dim bEmProcessamento As Boolean

  Private Sub cmdFechar_Click(sender As Object, e As EventArgs) Handles cmdFechar.Click
    Close()
  End Sub

  Private Sub frmCadastroModeloDocumentoElemento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    bEmProcessamento = True
    txtTexto.Top = picImagem.Top
    txtTexto.Left = picImagem.Left
    pnlAlinhamento.Top = txtTexto.Top + txtTexto.Height + 5
    pnlAlinhamento.Left = txtTexto.Left
    picImagem.Inicializar()
    optTexto_Marcar()

    ComboBox_Carregar(cboRepositorioImagem, enSql.RepositorioImagem)

    chkAtivo.Checked = True

    If iSQ_MODELODOCUMENTO_ELEMENTO = 0 Then
      Dim oData As DataTable
      Dim sSqlText As String

      If iTipoTela = enOpcoes.TipoElementoModeloDocumento_Assinatura Then sTermo_Pred = " da "

      sSqlText = "SELECT * FROM TB_OPCAO WHERE SQ_OPCAO = " & iTipoTela
      oData = DBQuery(sSqlText)

      Me.Text = Me.Text & " - " & oData.Rows(0).Item("NO_OPCAO")
      lblRTexto.Text = "Imagem" & sTermo_Pred & oData.Rows(0).Item("NO_OPCAO")
      lblRTexto.Text = "Texto" & sTermo_Pred & oData.Rows(0).Item("NO_OPCAO")
      sTermo = oData.Rows(0).Item("NO_OPCAO")
    Else
      CarregarDados()
    End If
    bEmProcessamento = False
  End Sub

  Private Sub CarregarDados()
    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM VW_MODELODOCUMENTO_ELEMENTO" & _
               " WHERE SQ_MODELODOCUMENTO_ELEMENTO = " & iSQ_MODELODOCUMENTO_ELEMENTO
    oData = DBQuery(sSqlText)

    With oData.Rows(0)
      Me.Text = Me.Text & " - " & .Item("NO_OPT_TIPO_ELEMENTO")
      iTipoTela = .Item("ID_OPT_TIPO_ELEMENTO")
      If iTipoTela = enOpcoes.TipoElementoModeloDocumento_Assinatura Then sTermo_Pred = " da "

      txtNomeElemento.Text = .Item("NO_MODELODOCUMENTO_ELEMENTO")
      chkAtivo.Checked = (FNC_NVL(.Item("IC_ATIVO"), "N") = "S")

      If FNC_NVL(.Item("IC_SISTEMA"), "N") = "N" Then
        If objDataTable_CampoVazio(.Item("TX_MODELODOCUMENTO_ELEMENTO")) Then
          optImagem_Marcar()
          lblRTexto.Text = "Imagem" & sTermo_Pred & .Item("NO_OPT_TIPO_ELEMENTO")
          picImagem.Arquivo = FNC_DiretorioSistema_AdicionarPath(.Item("DS_PATH_IMAGEM"))
        Else
          optTexto_Marcar()
          lblRTexto.Text = "Texto" & sTermo_Pred & .Item("NO_OPT_TIPO_ELEMENTO")
          txtTexto.Text = .Item("TX_MODELODOCUMENTO_ELEMENTO")

          If Not objDataTable_CampoVazio(.Item("DS_FONT")) Then
            txtTexto.Font = FNC_StringToFont(.Item("DS_FONT"))
          End If

          optAlinharCentralizado.Checked = (.Item("IC_ALINHAMENTO") = "C")
          optAlinharEsquerda.Checked = (.Item("IC_ALINHAMENTO") = "E")
          optAlinharDireita.Checked = (.Item("IC_ALINHAMENTO") = "D")
        End If
      Else
        optTexto_Marcar()
        lblRTexto.Text = "Texto" & sTermo_Pred & .Item("NO_OPT_TIPO_ELEMENTO")

        Select Case iTipoTela
          Case enOpcoes.TipoElementoModeloDocumento_Assinatura
            txtTexto.Text = FNC_ModeloDocumentoElemento_AssinaturaPadrao()
          Case enOpcoes.TipoElementoModeloDocumento_Cabecalho
            txtTexto.Text = FNC_ModeloDocumentoElemento_CabecalhoPadrao()
          Case enOpcoes.TipoElementoModeloDocumento_Rodape
            txtTexto.Text = FNC_ModeloDocumentoElemento_RodapePadrao()
        End Select
      End If

      pnlTipo.Enabled = (FNC_NVL(.Item("IC_SISTEMA"), "N") = "N")
      txtNomeElemento.Enabled = (FNC_NVL(.Item("IC_SISTEMA"), "N") = "N")
      txtTexto.ReadOnly = (FNC_NVL(.Item("IC_SISTEMA"), "N") = "S")
      picImagem.Enabled = (FNC_NVL(.Item("IC_SISTEMA"), "N") = "N")
      pnlAlinhamento.Enabled = (FNC_NVL(.Item("IC_SISTEMA"), "N") = "N")
      cmdFonte.Enabled = (FNC_NVL(.Item("IC_SISTEMA"), "N") = "N")
      cmdGravar.Enabled = (FNC_NVL(.Item("IC_SISTEMA"), "N") = "N")

      lblRNomeElemento.Text = "Nome" & sTermo_Pred & .Item("NO_MODELODOCUMENTO_ELEMENTO")
    End With
  End Sub

  Private Sub cmdGravar_Click(sender As Object, e As EventArgs) Handles cmdGravar.Click
    If Trim(txtNomeElemento.Text) = "" Then
      FNC_Mensagem("Informe o nome" & sTermo_Pred & sTermo)
      Exit Sub
    End If
    If optTexto.Checked And Trim(txtTexto.Text) = "" Then
      FNC_Mensagem("Informe o texto" & sTermo_Pred & sTermo)
      Exit Sub
    End If
    If optImagem.Checked And picImagem.Image Is Nothing Then
      FNC_Mensagem("Carregue a imagem" & sTermo_Pred & sTermo)
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_MODELODOCUMENTO_ELEMENTO_CAD", False, "@SQ_MODELODOCUMENTO_ELEMENTO",
                                                                     "@ID_EMPRESA",
                                                                     "@ID_OPT_TIPO_ELEMENTO",
                                                                     "@NO_MODELODOCUMENTO_ELEMENTO",
                                                                     "@TX_MODELODOCUMENTO_ELEMENTO",
                                                                     "@DS_PATH_IMAGEM",
                                                                     "@DS_FONT",
                                                                     "@IC_ALINHAMENTO",
                                                                     "@IC_ATIVO")

    If DBExecutar(sSqlText, DBParametro_Montar("SQ_MODELODOCUMENTO_ELEMENTO", iSQ_MODELODOCUMENTO_ELEMENTO),
                            DBParametro_Montar("ID_EMPRESA", iID_EMPRESA_FILIAL),
                            DBParametro_Montar("ID_OPT_TIPO_ELEMENTO", iTipoTela),
                            DBParametro_Montar("NO_MODELODOCUMENTO_ELEMENTO", txtNomeElemento.Text),
                            DBParametro_Montar("TX_MODELODOCUMENTO_ELEMENTO", IIf(optTexto.Checked, txtTexto.Text, Nothing)),
                            DBParametro_Montar("DS_PATH_IMAGEM", IIf(optImagem.Checked, picImagem.ArquivoGravacao, Nothing)),
                            DBParametro_Montar("DS_FONT", IIf(optTexto.Checked, FNC_FontToString(txtTexto.Font), Nothing), , , 300),
                            DBParametro_Montar("IC_ALINHAMENTO", IIf(optTexto.Checked, IIf(optAlinharCentralizado.Checked, "C", IIf(optAlinharDireita.Checked, "D", "E")), Nothing)),
                            DBParametro_Montar("IC_ATIVO", IIf(chkAtivo.Checked, "S", "N"))) Then
      picImagem.ValidarArquivo()

      RaiseEvent Pesquisar()

      FNC_Mensagem("Gravação Efetuada")
    End If
  End Sub

  Private Sub optImagem_Marcar()
    optImagem.Checked = True
    optImagem_CheckedChanged(Nothing, Nothing)
  End Sub

  Private Sub optTexto_Marcar()
    optTexto.Checked = True
    optTexto_CheckedChanged(Nothing, Nothing)
  End Sub

  Private Sub optImagem_CheckedChanged(sender As Object, e As EventArgs) Handles optImagem.CheckedChanged
    picImagem.Visible = True
    txtTexto.Visible = False
    cmdFonte.Visible = False
    pnlAlinhamento.Visible = False
    lblRUsarRepositorioImagem.Visible = True
    cboRepositorioImagem.Visible = True
  End Sub

  Private Sub optTexto_CheckedChanged(sender As Object, e As EventArgs) Handles optTexto.CheckedChanged
    picImagem.Visible = False
    txtTexto.Visible = True
    cmdFonte.Visible = True
    pnlAlinhamento.Visible = True
    picImagem.Inicializar()
    lblRUsarRepositorioImagem.Visible = False
    cboRepositorioImagem.SelectedIndex = -1
    cboRepositorioImagem.Visible = False
  End Sub

  Private Sub cboRepositorioImagem_KeyDown(sender As Object, e As KeyEventArgs) Handles cboRepositorioImagem.KeyDown
    If e.KeyCode = Keys.Delete Then
      cboRepositorioImagem.SelectedIndex = -1
      picImagem.Inicializar()
    End If
  End Sub

  Private Sub cboRepositorioImagem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRepositorioImagem.SelectedIndexChanged
    If ComboBox_Selecionado(cboRepositorioImagem) And Not bEmProcessamento Then
      sArquivo = FNC_RepositorioArquivo_Arquivo(cboRepositorioImagem.SelectedValue)
      picImagem.Arquivo = sArquivo
    End If
  End Sub

  Private Sub optAlinharEsquerda_CheckedChanged(sender As Object, e As EventArgs) Handles optAlinharEsquerda.CheckedChanged
    txtTexto.TextAlign = HorizontalAlignment.Left
  End Sub

  Private Sub optAlinharCentralizado_CheckedChanged(sender As Object, e As EventArgs) Handles optAlinharCentralizado.CheckedChanged
    txtTexto.TextAlign = HorizontalAlignment.Center
  End Sub

  Private Sub optAlinharDireita_CheckedChanged(sender As Object, e As EventArgs) Handles optAlinharDireita.CheckedChanged
    txtTexto.TextAlign = HorizontalAlignment.Right
  End Sub

  Private Sub cmdFonte_Click(sender As Object, e As EventArgs) Handles cmdFonte.Click
    FontDialog1.Font = txtTexto.Font

    FontDialog1.ShowDialog()

    txtTexto.Font = FontDialog1.Font
  End Sub
End Class