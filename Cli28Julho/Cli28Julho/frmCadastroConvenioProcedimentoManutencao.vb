Public Class frmCadastroConvenioProcedimentoManutencao
  Public Sub Formatar()
    picGeral.Image = Image.FromFile(FNC_ConfiguracaoTela(enOpcoes.Clinica_Procedimento_ReajustePreco))
    picGeral.SizeMode = PictureBoxSizeMode.AutoSize
    Me.Width = Me.Width + (picGeral.Width - Me.ClientSize.Width) + 10
    Me.Height = Me.Height + (picGeral.Height - Me.ClientSize.Height) + 10

    cmdFechar.Formatar(enOpcoes.ConfiguracaoTela_Botao_Fechar)

    cmdExecutarReajuste.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atualizar)
    cmdExecutarCopiaTabela.Formatar(enOpcoes.ConfiguracaoTela_Botao_Atualizar)

    cmdExecutarReajuste.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_ManutencaoPrecodeProcedimentoeExames).bGravar
    cmdExecutarCopiaTabela.Enabled = FNC_Permissao(enPermissao.CADA_Clinica_ManutencaoPrecodeProcedimentoeExames).bGravar
  End Sub

  Private Sub frmCadastroConvenioProcedimentoManutencao_Load(sender As Object, e As EventArgs) Handles Me.Load
    CarregarCombosConvenio()
  End Sub

  Private Sub CarregarCombosConvenio()
    ComboBox_Carregar(cboReajusteConvenio, enSql.Convenio_ComPreco)
    ComboBox_Carregar(cboCopiarTabela_ConvenioOrigem, enSql.Convenio_ComPreco)
    ComboBox_Carregar(cboCopiarTabela_ConvenioDestino, enSql.Convenio_SemPreco)
  End Sub

  Private Sub cboReajusteConvenio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReajusteConvenio.SelectedIndexChanged
    If ComboBox_Selecionado(cboReajusteConvenio) Then
      ComboBox_Carregar(cboReajustePrestador, enSql.PessoaProfissionalFornecedorConvenio_Ativo)
      ComboBox_Carregar(cboReajusteGrupoProcedimento, enSql.GrupoProcedimento)
    Else
      cboReajustePrestador.DataSource = Nothing
      cboReajusteGrupoProcedimento.DataSource = Nothing
      psqProcedimento.Identificador = 0
    End If
  End Sub

  Private Sub cmdExecutarCopiaTabela_Clicado(sender As Object) Handles cmdExecutarCopiaTabela.Clicado
    If Not ComboBox_Selecionado(cboCopiarTabela_ConvenioOrigem) Then
      FNC_Mensagem("Selecione o convênio de origem")
      Exit Sub
    End If
    If Not ComboBox_Selecionado(cboCopiarTabela_ConvenioDestino) Then
      FNC_Mensagem("Selecione o convênio de destino")
      Exit Sub
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_CONVENIO_PROCEDIMENTO_COPIAR", False, "@ID_CONVENIO_ORIGEM",
                                                                     "@ID_CONVENIO_DESTINO")
    If DBExecutar(sSqlText, DBParametro_Montar("ID_CONVENIO_ORIGEM", cboCopiarTabela_ConvenioOrigem.SelectedValue),
                            DBParametro_Montar("ID_CONVENIO_DESTINO", cboCopiarTabela_ConvenioDestino.SelectedValue)) Then
      CarregarCombosConvenio()

      FNC_Mensagem("Preço copiado")
    End If
  End Sub

  Private Sub cmdExecutarReajuste_Clicado(sender As Object) Handles cmdExecutarReajuste.Clicado
    If Not ComboBox_Selecionado(cboReajusteConvenio) Then
      FNC_Mensagem("Selecione o convênio do reajuste")
      Exit Sub
    End If
    If txtReajusteValor.Value = 0 Then
      FNC_Mensagem("Informe o percentual de ajuste")
      Exit Sub
    End If
    If Not optReajustePreco.Checked And Not optReajustePrestador.Checked Then
      FNC_Mensagem("Informe o tipo de reajuste")
      Exit Sub
    End If

    Dim oData As DataTable
    Dim sSqlText As String

    sSqlText = "SELECT * FROM VW_CONVENIO_PROCEDIMENTO" &
               " WHERE ID_CONVENIO = " & cboReajusteConvenio.SelectedValue

    If ComboBox_Selecionado(cboReajustePrestador) Then
      sSqlText = sSqlText & " AND ID_PESSOA_PROFISSIONAL = " & cboReajustePrestador.SelectedValue
    End If
    If ComboBox_Selecionado(cboReajusteGrupoProcedimento) Then
      sSqlText = sSqlText & " AND ID_GRUPOPROCEDIMENTO = " & cboReajusteGrupoProcedimento.SelectedValue
    End If
    If psqProcedimento.Identificador > 0 Then
      sSqlText = sSqlText & " AND ID_PROCEDIMENTO = " & psqProcedimento.Identificador
    End If

    oData = DBQuery(sSqlText)

    If oData.Rows.Count = 0 Then
      FNC_Mensagem("Não existe preço a ser ajustado de acordo a esse critério")
    Else
      For Each oRow As DataRow In oData.Rows
        If optReajustePreco.Checked Then
          sSqlText = "UPDATE TB_CONVENIO_PROCEDIMENTO SET VL_PROCEDIMENTO = @VL_PROCEDIMENTO" &
                     " WHERE SQ_CONVENIO_PROCEDIMENTO = @SQ_CONVENIO_PROCEDIMENTO"
          DBExecutar(sSqlText, DBParametro_Montar("VL_PROCEDIMENTO", FNC_Porcentagem(oRow.Item("VL_PROCEDIMENTO"), txtReajusteValor.Value, 2, True)),
                               DBParametro_Montar("SQ_CONVENIO_PROCEDIMENTO", oRow.Item("SQ_CONVENIO_PROCEDIMENTO")))
        ElseIf optReajustePrestador.Checked Then
          If FNC_NVL(oRow.Item("VL_REPASSE"), 0) <> 0 Then
            sSqlText = "UPDATE TB_CONVENIO_PROCEDIMENTO SET VL_REPASSE = @VL_REPASSE" &
                       " WHERE SQ_CONVENIO_PROCEDIMENTO = @SQ_CONVENIO_PROCEDIMENTO"
            DBExecutar(sSqlText, DBParametro_Montar("VL_REPASSE", FNC_Porcentagem(oRow.Item("VL_REPASSE"), txtReajusteValor.Value, 2, True)),
                                 DBParametro_Montar("SQ_CONVENIO_PROCEDIMENTO", oRow.Item("SQ_CONVENIO_PROCEDIMENTO")))
          Else
            sSqlText = "UPDATE TB_CONVENIO_PROCEDIMENTO SET PC_REPASSE = @PC_REPASSE" &
                       " WHERE SQ_CONVENIO_PROCEDIMENTO = @SQ_CONVENIO_PROCEDIMENTO"
            DBExecutar(sSqlText, DBParametro_Montar("PC_REPASSE", FNC_Porcentagem(oRow.Item("PC_REPASSE"), txtReajusteValor.Value, 2, True)),
                                 DBParametro_Montar("SQ_CONVENIO_PROCEDIMENTO", oRow.Item("SQ_CONVENIO_PROCEDIMENTO")))
          End If
        End If
      Next

      FNC_Mensagem("Foi ajustado " & oData.Rows.Count & " preço(s) de acordo a esse critério")
    End If
  End Sub

  Private Sub cmdFechar_Clicado(sender As Object) Handles cmdFechar.Clicado
    Close()
  End Sub
End Class