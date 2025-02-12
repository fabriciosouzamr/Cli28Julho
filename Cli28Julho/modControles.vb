﻿Imports Infragistics.Win
Imports System.Drawing.Printing
Imports System.Drawing.Text
Imports System

Public Module modControles
  Class Combo_Informacao
    Public Titulo As String
    Public Visivel As Boolean
    Public Tamanho As Long
    Public Descricao As Boolean
    Public Codigo As Boolean
    Public Formato As String
    Public Tipo As UltraWinGrid.ColumnStyle
  End Class

  Public Class clsLancaContasReceberPagar_Venda
    Public ID_FORMAPAGAMETO As Integer
    Public ID_DOCUMENTOFINANCEIRO As Integer
    Public ID_OPT_STATUS As Integer
    Public ID_BANCO As Integer
    Public ID_EMITENTE As Integer
    Public ID_TIPODOCUMENTO As Integer
    Public ID_CONDICAOPAGAMENTO As Integer
    Public CodigoParcela As String
    Public DataVencimento As Date
    Public ValorParcela As Double
    Public CodigoDocumento As String
    Public DataDocumento As Date
    Public NumeroAgencia As Integer
    Public NumeroConta As Integer
    Public NumeroConta_Digito As String
    Public DescricaoDocumento As String
    Public TaxaCompensacao As Double
  End Class

  Const const_ComboBox_Usuario_PDV As String = "SELECT DISTINCT ID_USUARIO,NO_PESSOA FROM VW_SEG_USUARIO_GRUPOPERMISSAO (NOLOCK) WHERE IC_ATIVO = 'S'"

  Public Sub ComboBox_CarregarUsuario(oComboBox As ComboBox, ComboBox_Usuario_TipoTela As enComboBox_Usuario_TipoTela)
    Dim sSqlText As String

    sSqlText = const_ComboBox_Usuario_PDV

    Select Case ComboBox_Usuario_TipoTela
      Case enComboBox_Usuario_TipoTela.PDV
        sSqlText = sSqlText & " AND SQ_GRUPOPERMISSAO = " & enSEG_GrupoPermissao.PDV & " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL
      Case enComboBox_Usuario_TipoTela.Empresa
        sSqlText = sSqlText
    End Select

    sSqlText = sSqlText & " ORDER BY NO_PESSOA"

    DBComboBox_Carregar(oComboBox, sSqlText)
  End Sub

  Public Sub ComboBox_CarregarIndicador(ByRef oCboIndicador As ComboBox, iID_Pessoa As Integer)
    Dim sSqlText As String

    'Carregar Indicador
    sSqlText = "SELECT MIN(ID_CIDADE)" &
                   " FROM TB_ENDERECO (NOLOCK)" &
                   " WHERE ID_PESSOA = " & iID_Pessoa &
                     " AND ID_CIDADE IS NOT NULL"
    ComboBox_Carregar(oCboIndicador, enSql.Indicador, New Object() {DBQuery_ValorUnico(sSqlText, 0)})
  End Sub

  Public Function ComboBox_VerificarIndice(ByVal oCombo As System.Windows.Forms.ComboBox, ByVal vValor As Object,
                                           Optional ByVal CdColuna As Integer = 0) As Integer
    Dim iIndice As Integer
    Dim bAchou As Boolean

    For iIndice = 0 To oCombo.Items.Count - 1
      If FNC_NVL(oCombo.Items(iIndice)(CdColuna), Nothing) = FNC_NVL(vValor, FNC_TipoCampo_ValorPadrao(oCombo.Items(iIndice)(CdColuna))) Then
        bAchou = True
        Exit For
      End If
    Next

    If bAchou Then
      Return iIndice
    Else
      Return -1
    End If
  End Function

  Public Sub ComboBox_Selecionar(ByVal oCombo As System.Windows.Forms.ComboBox, ByVal vValor As Object,
                                 Optional ByVal CdColuna As Integer = 0,
                                 Optional bSetarTAG As Boolean = False)
    oCombo.SelectedIndex = ComboBox_VerificarIndice(oCombo, vValor, CdColuna)

    If bSetarTAG Then oCombo.Tag = oCombo.SelectedIndex
  End Sub

  Public Function ComboBox_ListarIDs(ByVal oCombo As System.Windows.Forms.ComboBox,
                                     Optional ByVal CdColuna As Integer = 0) As String
    Dim iCont As Integer
    Dim sRet As String = ""

    If oCombo.Items.Count = 0 Then
      sRet = "-1"
    Else
      For iCont = 0 To oCombo.Items.Count - 1
        FNC_Str_Adicionar(sRet, oCombo.Items(iCont)(CdColuna), ",")
      Next
    End If

    Return sRet
  End Function

  Public Sub ComboBox_CarregarMeses(oComboBox As ComboBox)
    ComboBox_Carregar(oComboBox, New String() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
                                               "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"},
                                 New Object() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12})
    oComboBox.SelectedIndex = -1
  End Sub

  Public Sub ComboBox_CarregarSemanas(oComboBox As ComboBox, iAno As Integer)
    Dim oDataInicial As Date
    Dim oData As New DataTable
    Dim oRow As DataRow
    Dim iCont As Integer

    oData.Columns.Add("NR_SEMANA").DataType = System.Type.GetType("System.Int32")
    oData.Columns.Add("DS_SEMANA").DataType = System.Type.GetType("System.String")
    oData.Columns.Add("DT_SEMANA_INI").DataType = System.Type.GetType("System.DateTime")
    oData.Columns.Add("DT_SEMANA_FIM").DataType = System.Type.GetType("System.DateTime")

    oDataInicial = New DateTime(iAno, 1, 1)
    oDataInicial = oDataInicial.AddDays(0 - oDataInicial.DayOfWeek)

    For iCont = 0 To 52
      oRow = oData.NewRow

      oRow("NR_SEMANA") = iCont
      oRow("DS_SEMANA") = oDataInicial.Date.ToString().Substring(0, 10) + " a " + oDataInicial.AddDays(6).Date.ToString().Substring(0, 10)
      oRow("DT_SEMANA_INI") = oDataInicial
      oRow("DT_SEMANA_FIM") = oDataInicial.AddDays(7).Date

      oData.Rows.Add(oRow)

      oDataInicial = oDataInicial.AddDays(7)
    Next

    oComboBox.DisplayMember = "DS_SEMANA"
    oComboBox.ValueMember = "NR_SEMANA"
    oComboBox.DataSource = oData
  End Sub

  Public Sub ComboBox_CarregarOrigemVenda(oComboBox As ComboBox)
    ComboBox_Carregar(oComboBox, New String() {"Agendamento", "Orçamento"},
                                     New Object() {enOrigemVenda.Agendamento.GetHashCode(), enOrigemVenda.OrcamentoClinica.GetHashCode()})
    oComboBox.SelectedIndex = -1
  End Sub

  Public Sub ComboBox_CarregarFontesInstaladas(oComboBox As ComboBox)
    Dim fontes_instaladas As New InstalledFontCollection
    Dim sDS() As String = Nothing
    Dim iDS() As Object = Nothing
    Dim v_cont As Integer = 0

    oComboBox.Items.Clear()

    For Each fonte_familia As FontFamily In fontes_instaladas.Families
      ReDim Preserve iDS(v_cont)
      ReDim Preserve sDS(v_cont)

      iDS(v_cont) = v_cont
      sDS(v_cont) = fonte_familia.Name

      v_cont = v_cont + 1
    Next fonte_familia

    ComboBox_Carregar(oComboBox, sDS, iDS)

    If oComboBox.Items.Count > 0 Then oComboBox.SelectedIndex = 0
  End Sub

  Public Sub ComboBox_CarregarPeriodoData_MovFinanceira(oComboBox As ComboBox)
    ComboBox_Carregar(oComboBox, New String() {"Lançamento", "Quitação", "Ult. Pagto.", "Vencimento"},
                                     New Object() {const_PeriodoData_MovFinanceira_Lancamento,
                                                   const_PeriodoData_MovFinanceira_Quitacao,
                                                   const_PeriodoData_MovFinanceira_UltimoPagto,
                                                   const_PeriodoData_MovFinanceira_Vencimento})
    oComboBox.SelectedIndex = -1
  End Sub

  Public Sub ToolStripDropDownButton_Carregar(oDropDownButton As ToolStripDropDownButton, Sql As enSql, onClick As EventHandler)
    Dim oData As DataTable
    Dim oItem As ToolStripItem
    Dim sSqlText As String

    sSqlText = Carregar_SqlText(Sql)
    oData = DBQuery(sSqlText, oConexao2)

    oDropDownButton.DropDownItems.Clear()

    If Not objDataTable_Vazio(oData) Then
      For Each oRow As DataRow In oData.Rows
        If onClick Is Nothing Then
          oItem = oDropDownButton.DropDownItems.Add(oRow(1))
        Else
          oItem = oDropDownButton.DropDownItems.Add(oRow(1), Nothing, onClick)
        End If
        oItem.Tag = oRow(0)
      Next
    End If
  End Sub

  Private Function Carregar_SqlText(ComboBox_Simples As enSql,
                                    Optional oParametro() As Object = Nothing) As String
    Dim sSqlText As String = ""
    Dim sSqlText_Where As String = ""
    Dim DBTabela As String = ""
    Dim DBCampo_ID As String = ""
    Dim DBCampo_NO As String = ""
    Dim DBCampo_OrderBy As String = ""
    Dim DBCamposAdicionais As String = ""
    Dim bFiltrarEmpresa As Boolean = False
    Dim bFiltrarEmpresaMatriz As Boolean = False
    Dim bFiltrarAtivo As Boolean = False
    Dim bFiltrarNaoSistema As Boolean = False
    Dim iTipoAux As Integer

    Select Case ComboBox_Simples
      Case enSql.ClinicaSenhaGerada_Hoje_Chamar, enSql.ClinicaSenhaGerada_Hoje_Chamada
        DBTabela = "(SELECT  " + IIf(ComboBox_Simples = enSql.ClinicaSenhaGerada_Hoje_Chamada, " TOP 10 ", "") + " SQ_CLINICA_SENHA, dbo.FNC_STRZERO(NR_CLINICA_SENHA, 3) NR_CLINICA_SENHA" &
                    " FROM TB_CLINICA_SENHA (NOLOCK)" &
                    " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL

        Select Case ComboBox_Simples
          Case enSql.ClinicaSenhaGerada_Hoje_Chamar
            DBTabela = DBTabela &
                      " AND DH_CHAMADA IS NULL "
          Case enSql.ClinicaSenhaGerada_Hoje_Chamada
            DBTabela = DBTabela &
                      " AND DH_CHAMADA IS NOT NULL "
        End Select

        DBTabela = DBTabela &
                      " AND CAST(DH_CLINICA_SENHA AS DATE) = CAST(GETDATE() AS DATE)" + IIf(ComboBox_Simples = enSql.ClinicaSenhaGerada_Hoje_Chamada, " ORDER BY NR_CLINICA_SENHA DESC ", "") + ") X"
        DBCampo_NO = "NR_CLINICA_SENHA"
        DBCampo_ID = "SQ_CLINICA_SENHA"
      Case enSql.ContaCaixa_Empresa, enSql.ContaCaixa_SistemaChamada
        DBTabela = "(SELECT SQ_CONTAFINANCEIRA, NO_CONTAFINANCEIRA" &
                    " FROM TB_CONTAFINANCEIRA (NOLOCK)" &
                    " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                      " AND ID_TIPO_CONTAFINANCEIRA = 1" &
                      IIf(ComboBox_Simples = enSql.ContaCaixa_SistemaChamada, "  AND IC_USA_SISTEMACHAMADA = 'S' ", "") &
                      " AND IC_ATIVO = 'S') X"
        DBCampo_NO = "NO_CONTAFINANCEIRA"
        DBCampo_ID = "SQ_CONTAFINANCEIRA"
      Case enSql.LoteExameCitologico
        DBTabela = "(SELECT SQ_CLINICA_EXAME_CITOLOGICO_LOTE, " &
                           "CONCAT(CLEXL.CD_CLINICA_EXAME_CITOLOGICO_LOTE, ' - ', PESSO_PROFI.NO_PESSOA, ' - ', CONVERT(CHAR, CLEXL.DT_ENVIO, 103)) NO_CLINICA_EXAME_CITOLOGICO_LOTE" &
                    " FROM TB_CLINICA_EXAME_CITOLOGICO_LOTE CLEXL (NOLOCK)" &
                     " INNER JOIN TB_PESSOA PESSO_PROFI (NOLOCK) ON PESSO_PROFI.SQ_PESSOA = CLEXL.ID_PESSOA_PROFISSIONAL) X"
        DBCampo_NO = "NO_CLINICA_EXAME_CITOLOGICO_LOTE"
        DBCampo_ID = "SQ_CLINICA_EXAME_CITOLOGICO_LOTE"
      Case enSql.Atendente
        DBTabela = "(SELECT DISTINCT ID_USUARIO, NO_USUARIO FROM VW_USUARIO_ATENDENTE_VENDA (NOLOCK)) X"
        DBCampo_NO = "NO_USUARIO"
        DBCampo_ID = "ID_USUARIO"
      Case enSql.Turno
        DBTabela = "TB_TURNO (NOLOCK)"
        DBCampo_NO = "NO_TURNO"
        DBCampo_ID = "SQ_TURNO"
        DBCamposAdicionais = ", HR_INICIO, HR_FIM"
      Case enSql.Turno_Todos
        DBTabela = "(SELECT -1 SQ_TURNO, 'Todos' NO_TURNO, '00:00' HR_INICIO, '00:00' HR_FIM, 0 NR_ORDEM" &
                    " UNION ALL " &
                    "SELECT SQ_TURNO, NO_TURNO, HR_INICIO, HR_FIM, 1 NR_ORDEM FROM TB_TURNO (NOLOCK)) X"
        DBCampo_NO = "NO_TURNO"
        DBCampo_ID = "SQ_TURNO"
        DBCamposAdicionais = "NR_ORDEM, HR_INICIO, HR_FIM"
      Case enSql.Cid
        DBTabela = "TB_CID (NOLOCK)"
        DBCampo_NO = "DS_CID"
        DBCampo_ID = "SQ_CID"
        DBCamposAdicionais = ", CD_CID"
      Case enSql.Usuario_Supervisao
        DBTabela = "VW_USUARIO_SUPERVISOR (NOLOCK)"
        DBCampo_NO = "NO_PESSOA"
        DBCampo_ID = "SQ_PESSOA"
        DBCamposAdicionais = ", DS_SENHA"
      Case enSql.Usuario_Supervisao_Caixa
        DBTabela = "(SELECT DISTINCT SQ_PESSOA, NO_PESSOA FROM VW_USUARIO_SUPERVISOR (NOLOCK) A INNER JOIN TB_CONTAFINANCEIRA (NOLOCK) B ON B.ID_PESSOA = A.SQ_PESSOA) X"
        DBCampo_NO = "NO_PESSOA"
        DBCampo_ID = "SQ_PESSOA"
        DBCamposAdicionais = ", DS_SENHA"
      Case enSql.StatusAgendamento_Cancelamento
        DBTabela = "(SELECT SQ_OPCAO, NO_OPCAO FROM TB_OPCAO (NOLOCK) WHERE ID_TIPO_OPCAO IN (13, 16) AND CD_OPCAO = 'E' AND NO_OPCAO_ABREVIADO = 'Cancelamento') X"
        DBCampo_NO = "NO_OPCAO"
        DBCampo_ID = "SQ_OPCAO"
      Case enSql.Profissional_PendenteRepasse
        DBTabela = "(SELECT DISTINCT ID_PESSOA_PROFISSIONAL, NO_PESSOA_PROFISSIONAL FROM VW_CLINICA_VENDA_PENDENTE_REPASSE (NOLOCK)) X"
        DBCampo_NO = "NO_PESSOA_PROFISSIONAL"
        DBCampo_ID = "ID_PESSOA_PROFISSIONAL"
      Case enSql.OrcamentoCliente_Aberto
        DBTabela = "VW_ORCAMENTO_CLIENTE_ABERTO (NOLOCK)"
        DBCampo_NO = "CONCAT(RTRIM(CD_ORCAMENTO_CLIENTE), ' ', CONVERT(NVARCHAR(30), DH_ORCAMENTO_CLIENTE, 103), ' ', CONVERT(NVARCHAR(30), DH_ORCAMENTO_CLIENTE, 108), ' - Val.: ', CONVERT(NVARCHAR(30), DT_VALIDADE, 103)) DS_ORCAMENTO_CLIENTE"
        DBCampo_ID = "SQ_ORCAMENTO_CLIENTE"
        DBCampo_OrderBy = "CD_ORCAMENTO_CLIENTE"

        FNC_Str_Adicionar(sSqlText_Where, "ID_EMPRESA = " & oParametro(0).ToString(), " AND ")
        FNC_Str_Adicionar(sSqlText_Where, "ID_PESSOA = " & oParametro(1).ToString(), " AND ")
      Case enSql.EmpresaAtiva
        DBTabela = "VW_EMPRESA (NOLOCK)"
        DBCampo_NO = "NO_EMPRESA"
        DBCampo_ID = "ID_EMPRESA"
        DBCamposAdicionais = ", ID_EMPRESA_MATRIZ, ID_CIDADE, ID_UF, ID_PAIS, CD_CNPJ, CD_UF"
        FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_ATIVO = " & enOpcoes.AtivoInativo_Pessoal_Ativo.GetHashCode(), " AND ")
      Case enSql.DiasSemana
        DBTabela = "TB_OPCAO"
        DBCampo_NO = "NO_OPCAO"
        DBCampo_ID = "SQ_OPCAO"
        DBCampo_OrderBy = "CD_OPCAO"
        DBCamposAdicionais = ", CD_OPCAO"
        FNC_Str_Adicionar(sSqlText_Where, "ID_TIPO_OPCAO = " & enTipoOpcao.DiasSemana, " AND ")
      Case enSql.Convenio_ComPreco
        DBTabela = "(SELECT DISTINCT ID_CONVENIO, NO_CONVENIO FROM VW_CONVENIO_PROCEDIMENTO (NOLOCK)) X"
        DBCampo_NO = "NO_CONVENIO"
        DBCampo_ID = "ID_CONVENIO"
      Case enSql.Convenio_SemPreco
        DBTabela = "(SELECT C.SQ_CONVENIO, C.NO_CONVENIO" +
                    " FROM TB_CONVENIO (NOLOCK) C" +
                     " LEFT JOIN TB_CONVENIO_PROCEDIMENTO (NOLOCK) P ON P.ID_CONVENIO = C.SQ_CONVENIO" +
                    " WHERE P.ID_CONVENIO IS NULL) X"
        DBCampo_NO = "NO_CONVENIO"
        DBCampo_ID = "SQ_CONVENIO"
      Case enSql.Especilidade_Profissional
        DBTabela = "(SELECT DISTINCT ID_PESSOA, NO_PESSOA FROM VW_PESSOA_ESPECIALIDADE (NOLOCK) WHERE ID_ESPECIALIDADE = " & oParametro(0).ToString() & ") X"
        DBCampo_NO = "NO_PESSOA"
        DBCampo_ID = "ID_PESSOA"
      Case enSql.TipoContaBancaria
        DBTabela = "(SELECT SQ_TIPO_CONTAFINANCEIRA, NO_TIPO_CONTAFINANCEIRA FROM TB_TIPO_CONTAFINANCEIRA" &
                   " WHERE ID_OPT_CLASSE NOT IN (" & enOpcoes.ClasseTipoContaFinanceira_ContaCaixa.GetHashCode() & ")" &
                   " ORDER BY NO_TIPO_CONTAFINANCEIRA) X"
        DBCampo_NO = "NO_TIPO_CONTAFINANCEIRA"
        DBCampo_ID = "SQ_TIPO_CONTAFINANCEIRA"
      Case enSql.Profissional_Especilidade
        DBTabela = "(SELECT -1 ID_ESPECIALIDADE, 'Todos' NO_ESPECIALIDADE, 0 NR_ORDEM" &
                    " UNION ALL " &
                    "SELECT DISTINCT ID_ESPECIALIDADE, NO_ESPECIALIDADE, 1 NR_ORDEM FROM VW_PESSOA_ESPECIALIDADE (NOLOCK) WHERE ID_PESSOA = " & oParametro(0).ToString() & ") X"
        DBCampo_NO = "NO_ESPECIALIDADE"
        DBCampo_ID = "ID_ESPECIALIDADE"
        DBCampo_OrderBy = "NR_ORDEM, NO_ESPECIALIDADE"
      Case enSql.Empresa_Profissional_Especialidade
        DBTabela = "VW_PESSOA_ESPECIALIDADE (NOLOCK)"
        DBCampo_NO = "NO_EMPRESA"
        DBCampo_ID = "ID_EMPRESA"
        If Val(oParametro(0)) > 0 Then FNC_Str_Adicionar(sSqlText_Where, "ID_ESPECIALIDADE = " & oParametro(0).ToString(), " And ")
        If Val(oParametro(1)) > 0 Then FNC_Str_Adicionar(sSqlText_Where, "ID_PESSOA = " & oParametro(1).ToString(), " And ")
      Case enSql.Profissional_Especilidade_Horario
        sSqlText = "SELECT ID_PESSOA, DS_INFORMACAO, HR_INICIO, HR_FIM, ID_PROCEDIMENTO" &
                   " FROM dbo.FC_ESPECIALIDADE_PESSOA_HORARIO(" & oParametro(0).ToString() & ", " & oParametro(1).ToString() & ", '" & oParametro(2).ToString() & "') " &
                   " ORDER BY DS_INFORMACAO"
      Case enSql.DocumentoFinanceiroDisponivel
        sSqlText = "SELECT SQ_DOCUMENTOFINANCEIRO, ISNULL(DS_BANCO_CONTA_CD_DOCUMENTO, CD_DOCUMENTO) + ' - ' + DS_EMITENTE" &
                   " FROM VW_DOCUMENTOFINANCEIRO (NOLOCK)" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ID_TIPODOCUMENTO = " & oParametro(0).ToString() &
                     " AND ID_OPT_STATUS = " & enOpcoes.StatusDocumentoFinanceiro_Cadastrado.GetHashCode() &
                     " AND VL_SALDO > 0" &
                   " ORDER BY ISNULL(DS_BANCO_CONTA_CD_DOCUMENTO, CD_DOCUMENTO) + ' - ' + DS_EMITENTE"
      Case enSql.PessoaCredito_CreditoCedido
        sSqlText = "SELECT DISTINCT SQ_MOVFINANCEIRAPARCELA," +
                                   "RTRIM(CD_MOVFINANCEIRA_PARCELA) + ' (' + RTRIM(NO_PESSOA) + ') - ' + FORMAT(VL_DEBITO, 'C', 'pt-br') CD_MOVFINANCEIRA_PARCELA" &
                   " FROM VW_MOVFINANCEIRAPARCELA_DIREITOCREDITO (NOLOCK)" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND ID_PESSOA_CREDITO IN (" & oParametro.ToString() & ")" &
                     " AND ID_OPT_STATUS IN (" + enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode().ToString() + ", " +
                                                 enOpcoes.StatusMovimentacaoFinanceira_QuitadaParcialmente.GetHashCode().ToString() + ")" &
                     " AND ISNULL(VL_DEBITO, 0) > 0"
      Case enSql.FormaPagamento_QuitarCPCR,
           enSql.FormaPagamento_QuitarVenda
        sSqlText = "SELECT SQ_FORMAPAGAMENTO, NO_FORMAPAGAMENTO" &
                   " FROM VW_FORMAPAGAMENTO (NOLOCK)"

        If Not oParametro Is Nothing Then
          If FNC_NVL(oParametro(0), "").ToString().Trim <> "" Then
            Select Case ComboBox_Simples
              Case enSql.FormaPagamento_QuitarCPCR,
                   enSql.FormaPagamento_QuitarVenda
                sSqlText = sSqlText &
                  " UNION ALL " &
                   "SELECT DISTINCT " & const_FormaPagamento_CreditoPessoa & ", 'Crédito Pessoa'" &
                   " FROM TB_PESSOA_EMPRESA (NOLOCK) " &
                   " WHERE ID_PESSOA IN (" & oParametro(0).ToString() & ")" &
                     " AND ISNULL(VL_CREDITO, 0) > 0" &
                  " UNION ALL " &
                  "SELECT DISTINCT " & const_FormaPagamento_CreditoCedido & ", 'Crédito Próprio/Cedido'" +
                  " FROM VW_MOVFINANCEIRAPARCELA_DIREITOCREDITO (NOLOCK)" +
                  " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                    " AND ID_PESSOA_CREDITO IN (" & oParametro(0).ToString() & ")" &
                    " AND ID_OPT_STATUS IN (" + enOpcoes.StatusMovimentacaoFinanceira_Aberta.GetHashCode().ToString() + ", " +
                                                enOpcoes.StatusMovimentacaoFinanceira_QuitadaParcialmente.GetHashCode().ToString() + ")" &
                    " AND ISNULL(VL_DEBITO, 0) > 0"
            End Select
          End If
        End If

        sSqlText = "SELECT * FROM (" & sSqlText & ") X ORDER BY NO_FORMAPAGAMENTO"
      Case enSql.PessoaCredito_QuitarCPCR
        sSqlText = "SELECT DISTINCT PEN.SQ_PESSOA, RTRIM(PEN.NO_PESSOA) + ' - ' + FORMAT(VL_CREDITO, 'C', 'pt-br') NO_PESSOA" &
                   " FROM TB_PESSOA_EMPRESA (NOLOCK) PEM ON PEM.ID_PESSOA = MVF.ID_PESSOA" &
                                                      " AND ISNULL(PEM.VL_CREDITO, 0) <> 0" &
                    " INNER JOIN VW_PESSOA_NOME (NOLOCK) PEN ON PEN.ID_EMPRESA = PEM.ID_EMPRESA" &
                                                   " AND PEN.SQ_PESSOA = PEM.ID_PESSOA" &
                   " WHERE PEM.ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " AND PEM.ID_PESSOA IN (" & oParametro.ToString() & ")" &
                   " ORDER BY RTRIM(PEN.NO_PESSOA) + ' - ' + FORMAT(VL_CREDITO, 'C', 'pt-br')"
      Case enSql.Grupo_E_StatusMovimentacaoFinanceira
        DBTabela = "VW_OPCAO_STATUS_MOVIMENTACAO_FINANCEIRA (NOLOCK)"
        DBCampo_NO = "NO_OPCAO"
        DBCampo_ID = "SQ_OPCAO"
        DBCampo_OrderBy = "CD_OPCAO, SQ_OPCAO_GRUPO, NO_OPCAO"
        DBCamposAdicionais = ", SQ_OPCAO_GRUPO, CD_OPCAO"
      Case enSql.PessoaProfissionalFornecedorProcedimento
        DBTabela = "VW_PESSOA_PROFISSIONAL_FORNECEDOR_PROCEDIMENTO (NOLOCK)"
        DBCampo_NO = "NO_PESSOA"
        DBCampo_ID = "SQ_PESSOA"
        DBCampo_OrderBy = "NO_PESSOA"
        DBCamposAdicionais = ", IC_PROFISSIONAL, IC_FORNECEDOR"

        bFiltrarEmpresa = True
      Case enSql.PessoaProfissionalFornecedorConvenio_Ativo
        DBCampo_NO = "NO_PESSOA"
        DBCampo_ID = "ID_PESSOA_PROFISSIONAL"

        If oParametro Is Nothing Then
          DBTabela = "(SELECT DISTINCT ID_PESSOA_PROFISSIONAL, NO_PESSOA FROM VW_CONVENIO_PROCEDIMENTO (NOLOCK) WHERE IC_ATIVO = 'S') X"
        Else
          DBTabela = "(SELECT DISTINCT ID_CONVENIO, ID_PESSOA_PROFISSIONAL, NO_PESSOA, VL_PROCEDIMENTO FROM VW_CONVENIO_PROCEDIMENTO (NOLOCK) WHERE IC_ATIVO = 'S') X"

          FNC_Str_Adicionar(sSqlText_Where, "ID_CONVENIO = " & oParametro(0), " AND ")
        End If
      Case enSql.PessoaProfissionalFornecedorConvenioProcedimento_Ativo
        DBTabela = "SELECT * FROM VW_CONVENIO_PROCEDIMENTO (NOLOCK)"

        If Not oParametro Is Nothing Then
          DBTabela = DBTabela & " WHERE ID_CONVENIO = " & oParametro(0) & " AND ID_PROCEDIMENTO = " & oParametro(1)
        End If

        DBTabela = "(SELECT DISTINCT ID_PESSOA_PROFISSIONAL, NO_PESSOA, VL_PROCEDIMENTO, QT_DIAS_REPASSE, VL_REPASSE, PC_REPASSE, IC_ATIVO, IC_PROFISSIONAL_SERVICO_INTERNO FROM (" + DBTabela + ") X1) X2"
        DBCampo_NO = "NO_PESSOA"
        DBCampo_ID = "ID_PESSOA_PROFISSIONAL"
        DBCamposAdicionais = ", VL_PROCEDIMENTO, QT_DIAS_REPASSE, VL_REPASSE, PC_REPASSE, IC_ATIVO, IC_PROFISSIONAL_SERVICO_INTERNO"
        bFiltrarAtivo = True
      Case enSql.Especialidade_Atendida
        DBTabela = "VW_ESPECIALIDADE_ATENDIDA (NOLOCK)"
        DBCampo_NO = "NO_ESPECIALIDADE"
        DBCampo_ID = "ID_ESPECIALIDADE"
        DBCampo_OrderBy = "NO_ESPECIALIDADE"
        If FNC_NVL(oParametro(0), 0) <> 0 Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_EMPRESA = " & oParametro(0), " AND ")
        End If
        bFiltrarEmpresa = True
      Case enSql.CaracteristicaProduto
        DBTabela = "TB_CARACTERISTICA_PRODUTO (NOLOCK)"
        DBCampo_NO = "NO_CARACTERISTICA"
        DBCampo_ID = "SQ_CARACTERISTICA_PRODUTO"
      Case enSql.Vacina
        DBTabela = "TB_VACINA (NOLOCK)"
        DBCampo_NO = "NO_VACINA"
        DBCampo_ID = "SQ_VACINA"
      Case enSql.ContaCaixaAtendimento_SistemaChamada
        DBTabela = "TB_CAIXA_ATENDIMENTO (NOLOCK)"
        DBCampo_NO = "NO_CAIXA_ATENDIMENTO"
        DBCampo_ID = "SQ_CAIXA_ATENDIMENTO"
        bFiltrarAtivo = True
        bFiltrarEmpresa = True
      Case enSql.Funcionario
        sSqlText = "SELECT SQ_PESSOA, NO_PESSOA FROM VW_PESSOA (NOLOCK)" &
                   " WHERE IC_FUNCIONARIO_ATIVO = 'S'" &
                     " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                   " ORDER BY NO_PESSOA"
      Case enSql.ClassificacaoExame
        DBTabela = "TB_CLASSIFICACAO_EXAME (NOLOCK)"
        DBCampo_NO = "NO_CLASSIFICACAO_EXAME"
        DBCampo_ID = "SQ_CLASSIFICACAO_EXAME"
      Case enSql.TipoRelatorio
        DBTabela = "TB_TIPO_RELATORIO (NOLOCK)"
        DBCampo_NO = "NO_TIPO_RELATORIO"
        DBCampo_ID = "SQ_TIPO_RELATORIO"
      Case enSql.TipoIndicador
        DBTabela = "TB_TIPOINDICADOR (NOLOCK)"
        DBCampo_NO = "NO_TIPOINDICADOR"
        DBCampo_ID = "SQ_TIPOINDICADOR"
      Case enSql.TipoCargo
        DBTabela = "TB_TIPO_CARGO (NOLOCK)"
        DBCampo_ID = "SQ_TIPO_CARGO"
      Case enSql.GrupoProcedimento
        DBTabela = "TB_GRUPOPROCEDIMENTO (NOLOCK)"
        DBCampo_ID = "SQ_GRUPOPROCEDIMENTO"
      Case enSql.Agenda
        DBTabela = "VW_AGENDA (NOLOCK)"
        DBCampo_ID = "SQ_AGENDA"
        DBCampo_NO = "NO_PESSOA_EMPRESA"
        bFiltrarEmpresa = True
      Case enSql.Consultorio, enSql.Consultorio_Todos
        DBTabela = "TB_CONSULTORIO (NOLOCK)"
        DBCampo_ID = "SQ_CONSULTORIO"
        DBCampo_NO = "NO_CONSULTORIO"

        If ComboBox_Simples = enSql.Consultorio Then
          If Not oParametro Is Nothing Then
            FNC_Str_Adicionar(sSqlText_Where, "ID_EMPRESA = " & oParametro(0), " AND ")
          Else
            bFiltrarEmpresa = True
          End If
        End If

        DBCamposAdicionais = ", CD_CONSULTORIO"
      Case enSql.TipoPessoa
        DBTabela = "TB_TIPO_PESSOA (NOLOCK)"
        DBCamposAdicionais = ", ID_OPT_FISICO_JURIDICO"
      Case enSql.EstadoCivil
        DBTabela = "TB_TIPO_ESTADOCIVIL (NOLOCK)"
      Case enSql.Banco
        DBTabela = "TB_BANCO (NOLOCK)"
        DBCampo_ID = "SQ_BANCO"
      Case enSql.GrupoTributario
        DBTabela = "TB_GRUPOTRIBUTARIO (NOLOCK)"
        DBCampo_ID = "SQ_GRUPOTRIBUTARIO"
      Case enSql.StatusEstoqueLocalizacao
        DBTabela = "TB_ESTOQUE_LOCALIZACAO_STATUS (NOLOCK)"
        DBCampo_ID = "SQ_ESTOQUE_LOCALIZACAO_STATUS"
        DBCampo_NO = "NO_STATUS"
        bFiltrarEmpresa = True
        bFiltrarAtivo = True
      Case enSql.Nacionalidade
        DBTabela = "TB_PAIS (NOLOCK)"
        DBCampo_ID = "SQ_PAIS"
        DBCampo_NO = "ISNULL(NO_NACIONALIDADE, NO_PAIS)"
        DBCampo_OrderBy = "NR_ORDEM, ISNULL(NO_NACIONALIDADE, NO_PAIS)"
      Case enSql.Escolaridade
        DBTabela = "TB_TIPO_ESCOLARIDADE (NOLOCK)"
      Case enSql.Raca
        DBTabela = "TB_TIPO_RACA (NOLOCK)"
      Case enSql.Religiao
        DBTabela = "TB_TIPO_RELIGIAO (NOLOCK)"
      Case enSql.Servico
        DBTabela = "TB_SERVICO (NOLOCK)"
        DBCamposAdicionais = ", CD_SERVICO"
        bFiltrarEmpresa = True
        bFiltrarAtivo = True
      Case enSql.Sexo
        DBTabela = "TB_TIPO_SEXO (NOLOCK)"
      Case enSql.Profissao
        DBTabela = "TB_PROFISSAO (NOLOCK)"
      Case enSql.Tipo_MidiaSocial
        DBTabela = "TB_TIPO_MIDIASOCIAL (NOLOCK)"
      Case enSql.TipoServico
        DBTabela = "TB_TIPO_SERVICO (NOLOCK)"
        bFiltrarEmpresa = True
      Case enSql.TipoTelefone
        DBTabela = "TB_TIPO_TELEFONE (NOLOCK)"
      Case enSql.TipoEndereco
        DBTabela = "TB_TIPO_ENDERECO (NOLOCK)"
      Case enSql.TipoReferencia
        DBTabela = "TB_TIPO_REFERENCIAPESSOA (NOLOCK)"
      Case enSql.TipoPaciente
        DBTabela = "TB_TIPO_PACIENTE (NOLOCK)"
      Case enSql.Convenio_Ativo, enSql.Convenio
        DBTabela = "TB_CONVENIO (NOLOCK)"
        bFiltrarAtivo = (ComboBox_Simples = enSql.Convenio_Ativo)

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_ADMINISTRADORA = " & oParametro(0), " AND ")
        End If

        DBCamposAdicionais = ", IC_CONTROLACREDITO, IC_SENHA_SUPERVISOR"
      Case enSql.Financiamento_Ativo, enSql.Financiamento
        DBTabela = "TB_FINANCIAMENTO (NOLOCK)"
        bFiltrarEmpresa = True
        bFiltrarAtivo = (ComboBox_Simples = enSql.Financiamento_Ativo)
        DBCamposAdicionais = " ,ID_FINANCIADOR,ID_MODELODOCUMENTO_CONTRATO,NR_MINIMO_PARCELA,NR_MAXIMO_PARCELA,PC_ENTRADA,PC_JUROS,ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS"
      Case enSql.Especialidade
        DBTabela = "TB_ESPECIALIDADE (NOLOCK)"
        bFiltrarAtivo = True
      Case enSql.TabelaPreco
        DBTabela = "TB_TABELAPRECO (NOLOCK)"
        bFiltrarEmpresa = True
      Case enSql.TabelaPreco_Ativa, enSql.TabelaPreco_SemTabelaBase_Ativa
        DBTabela = "(SELECT * FROM TB_TABELAPRECO (NOLOCK)" &
                    " WHERE DT_INICIO_USO <= CAST(GETDATE() AS DATE) AND ISNULL(DT_FIM_USO, CAST(GETDATE() AS DATE)) >= CAST(GETDATE() AS DATE)) X"
        DBCampo_ID = "SQ_TABELAPRECO"
        DBCampo_NO = "NO_TABELAPRECO"

        If ComboBox_Simples = enSql.TabelaPreco_SemTabelaBase_Ativa Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_TABELAPRECO_BASE IS NULL", " AND ")
        End If
        bFiltrarEmpresa = True
      Case enSql.LinhaProdutoVenda
        DBTabela = "TB_PRODUTO_LINHA (NOLOCK)"
        DBCampo_ID = "SQ_PRODUTO_LINHA"
        DBCampo_NO = "NO_PRODUTO_LINHA"

        If ComboBox_Simples = enSql.LinhaProdutoVenda Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_TIPO_PRODUTO_LINHA = " & enOpcoes.TipoLinhaProduto_LinhaVenda.GetHashCode(), " AND ")
        End If

        bFiltrarEmpresa = True
      Case enSql.Empresa
        DBTabela = "VW_EMPRESA (NOLOCK)"
        DBCampo_ID = "ID_EMPRESA"
        DBCamposAdicionais = ", ID_EMPRESA_MATRIZ, ID_CIDADE, ID_UF, ID_PAIS, CD_CNPJ, CD_UF"
      Case enSql.Cidade
        DBTabela = "VW_CIDADE (NOLOCK)"
        DBCampo_ID = "SQ_CIDADE"
        DBCampo_NO = "NO_UF_CIDADE"

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_UF = " & oParametro(0), " AND ")
        End If

        DBCamposAdicionais = ", ID_UF, ID_PAIS, CD_UF, NO_CIDADE"
      Case enSql.Indicador
        DBTabela = "VW_PESSOAINDICADOR (NOLOCK)"
        DBCampo_ID = "ID_PESSOA"
        DBCampo_NO = "CONCAT(RTRIM(ID_PESSOA), ' - ', NO_PESSOA) NO_PESSOA"
        DBCampo_OrderBy = "NO_PESSOA"

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_PESSOA IN (SELECT ID_PESSOA FROM TB_PESSOAINDICADOR_CIDADE WHERE ID_CIDADE = " & oParametro(0) & ")", " AND ")
        End If
        bFiltrarEmpresaMatriz = True
      Case enSql.Profissional, enSql.Profissional_ServicoInterno
        DBTabela = "(SELECT * FROM VW_PESSOA_NOME (NOLOCK) WHERE IC_PROFISSIONAL = 'S') X"
        DBCampo_ID = "SQ_PESSOA"
        DBCampo_NO = "NO_PESSOA"

        If ComboBox_Simples = enSql.Profissional_ServicoInterno Then
          FNC_Str_Adicionar(sSqlText_Where, "IC_PROFISSIONAL_SERVICO_INTERNO = 'S'", " AND ")
        End If

        bFiltrarEmpresa = True
      Case enSql.Anamnese
        DBTabela = "TB_QUESTIONARIO (NOLOCK)"
        bFiltrarEmpresa = True
        bFiltrarAtivo = True
        FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_TIPOQUESTIONARIO = " & enOpcoes.TipoQuestionarioClinica_Anamnese.GetHashCode, " AND ")
      Case enSql.PlanoContas_Credito,
           enSql.PlanoContas_Credito_TodasEmpresa,
           enSql.PlanoContas_Debito,
           enSql.PlanoContas_Debito_TodasEmpresa,
           enSql.PlanoContas
        DBTabela = "VW_PLANOCONTAS (NOLOCK)"
        DBCampo_ID = "SQ_PLANOCONTAS"

        FNC_Str_Adicionar(sSqlText_Where, "IC_ATIVO = 'S'", " AND ")

        If ComboBox_Simples = enSql.PlanoContas Then
          DBCampo_NO = "NO_CREDITODEBITO_PLANOCONTAS"
        Else
          DBCampo_NO = "NO_CODIGO_PLANOCONTAS"

          FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_CREDITODEBITO = " & IIf(ComboBox_Simples = enSql.PlanoContas_Credito Or ComboBox_Simples = enSql.PlanoContas_Credito_TodasEmpresa,
                                                                            enOpcoes.CreditoDebito_Credito.GetHashCode,
                                                                            enOpcoes.CreditoDebito_Debito.GetHashCode), " AND ")
        End If

        bFiltrarEmpresa = Not (ComboBox_Simples = enSql.PlanoContas_Credito_TodasEmpresa Or ComboBox_Simples = enSql.PlanoContas_Debito_TodasEmpresa)
      Case enSql.PlanoContas_Grupo,
           enSql.PlanoContas_Grupo_GrupoSuperior
        DBTabela = "VW_PLANOCONTAS_GRUPO (NOLOCK)"
        DBCampo_ID = "SQ_PLANOCONTAS_GRUPO"
        DBCampo_NO = "DS_PLANOCONTAS_GRUPO"

        FNC_Str_Adicionar(sSqlText_Where, "ID_PLANOCONTAS_GRUPO_SUPERIOR IS NULL", " AND ")
        bFiltrarEmpresa = True
      Case enSql.Produto_LinhaProduto
        DBTabela = "(SELECT DISTINCT ID_PRODUTO_EMPRESA, NO_PRODUTO" &
                    " FROM VW_PRODUTO_EMPRESA_FILIAL (NOLOCK)" &
                    " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                      " AND ID_PRODUTO_LINHA = " & oParametro(0).ToString() & ") X"
        DBCampo_ID = "ID_PRODUTO_EMPRESA"
        DBCampo_NO = "NO_PRODUTO"
      Case enSql.ContaBancaria
        DBTabela = "(SELECT * FROM TB_CONTAFINANCEIRA (NOLOCK) WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & " AND ID_TIPO_CONTAFINANCEIRA NOT IN (1)) X"
        DBCampo_ID = "SQ_CONTAFINANCEIRA"
        DBCampo_NO = "NO_CONTAFINANCEIRA"
        DBCamposAdicionais = ", (VL_SALDO - VL_BLOQUEADO) VL_SALDO"
      Case enSql.ContaCaixa
        DBTabela = "(SELECT * FROM TB_CONTAFINANCEIRA (NOLOCK) WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & " AND ID_TIPO_CONTAFINANCEIRA IN (1)) X"
        DBCampo_ID = "SQ_CONTAFINANCEIRA"
        DBCampo_NO = "NO_CONTAFINANCEIRA"
        DBCamposAdicionais = ", VL_SALDO, PC_DESCONTO_MAXIMO"

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "(SQ_CONTAFINANCEIRA IN (SELECT ID_CONTAFINANCEIRA FROM TB_CONTAFINANCEIRA_PESSOA WHERE ID_PESSOA = " & oParametro(0) & ") OR ID_PESSOA_SUPERVISAO = " & oParametro(0) & ")", " AND ")
        End If
      Case enSql.TipoDocumento, enSql.TipoDocumento_FluxoCaixa
        DBTabela = "TB_TIPO_DOCUMENTO (NOLOCK)"
        DBCampo_ID = "SQ_TIPO_DOCUMENTO"
        DBCamposAdicionais = ", IC_COMPENSAR, IC_CADASTRAR_DOCUMENTO, ID_OPT_INSTITUICAO_GERADORA, IC_CADASTRAR_CONTABANCARIA"

        If ComboBox_Simples = enSql.TipoDocumento_FluxoCaixa Then
          FNC_Str_Adicionar(sSqlText_Where, "ISNULL(IC_FLUXOCAIXA, 'N') = 'S'", " AND ")
        End If

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_UTILIZACAOFINANCEIRO = " & oParametro(0), " AND ")
        End If
      Case enSql.ConselhoProfissional
        DBTabela = "TB_CONSELHOPROFISSIONAL (NOLOCK)"
        DBCampo_ID = "SQ_CONSELHOPROFISSIONAL"
      Case enSql.TipoDocumentoFiscal,
           enSql.TipoDocumentoFiscal_Entrada,
           enSql.TipoDocumentoFiscal_Saida
        DBTabela = "TB_DOCUMENTOFISCAL_TIPO (NOLOCK)"
        DBCampo_ID = "SQ_DOCUMENTOFISCAL_TIPO"
        bFiltrarAtivo = True

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "CD_SERVICO_MODELO = " & FNC_QuotedStr(oParametro(0)), " AND ")
        End If

        Select Case ComboBox_Simples
          Case enSql.TipoDocumentoFiscal_Entrada
            FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_ENTRADASAIDA = " & enOpcoes.NFe_TipoOperacao_Entrada.GetHashCode(), " AND ")
          Case enSql.TipoDocumentoFiscal_Saida
            FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_ENTRADASAIDA = " & enOpcoes.NFe_TipoOperacao_Saida.GetHashCode(), " AND ")
        End Select

        DBCamposAdicionais = ", CD_SERVICO_MODELO, CD_SERVICO_VERSAO, CD_DOCUMENTOFISCAL_TIPO, ID_OPT_NFE_TIPOOPERACAO, ID_OPT_EXIGE_PESSOA, ID_OPT_EXIGE_ENDERECO"
      Case enSql.MidiaSocial_EMail
        DBTabela = "VW_PESSOA_MIDIASOCIAL (NOLOCK)"
        DBCampo_ID = "SQ_PESSOA_MIDIASOCIAL"
        DBCampo_NO = "DS_MIDIASOCIAL"

        FNC_Str_Adicionar(sSqlText_Where, "ID_TIPO_MIDIASOCIAL = " & enTipoMidiaSocial.EMail.GetHashCode(), " AND ")

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_PESSOA = " & oParametro(0), " AND ")
        End If
      Case enSql.Telefone
        DBTabela = "VW_PESSOA_TELEFONE (NOLOCK)"
        DBCampo_ID = "SQ_PESSOA_TELEFONE"
        DBCampo_NO = "CD_NUMERO"

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_PESSOA = " & oParametro(0), " AND ")
        End If
      Case enSql.SerieDocumentoFiscal
        DBTabela = "TB_DOCUMENTOFISCAL_SERIE (NOLOCK)"
        DBCampo_ID = "SQ_DOCUMENTOFISCAL_SERIE"
        DBCampo_NO = "CD_DOCUMENTOFISCAL_SERIE"
        bFiltrarAtivo = True

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_DOCUMENTOFISCAL_TIPO = " & oParametro(0), " AND ")
        End If
      Case enSql.Tipo_Consulta
        DBTabela = "TB_TIPO_CONSULTA (NOLOCK)"
        DBCampo_ID = "SQ_TIPO_CONSULTA"

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "IC_USAR_AGENDAMENTO = " & FNC_QuotedStr(oParametro(0)), " AND ")
        End If
      Case enSql.TabelaProcedimento
        DBTabela = "TB_TABELAPROCEDIMENTO (NOLOCK)"
        DBCampo_ID = "SQ_TABELAPROCEDIMENTO"
      Case enSql.EstagioDoenca
        DBTabela = "TB_DOENCA_ESTAGIO (NOLOCK)"
        DBCampo_ID = "SQ_DOENCA_ESTAGIO"
      Case enSql.Fabricante
        DBTabela = "(SELECT * FROM VW_PESSOA_NOME (NOLOCK) WHERE IC_FABRICANTE = 'S') X"
        DBCampo_ID = "SQ_PESSOA"
        DBCampo_NO = "NO_PESSOA"
        bFiltrarEmpresa = True
      Case enSql.UnidadeMedida
        DBTabela = "TB_UNIDADEMEDIDA (NOLOCK)"
        DBCampo_ID = "SQ_UNIDADEMEDIDA"
      Case enSql.UnidadeMedida
        DBTabela = "TB_UNIDADEMEDIDA (NOLOCK)"
        DBCampo_ID = "SQ_UNIDADEMEDIDA"
      Case enSql.CFOP_Grupo
        DBTabela = "TB_CFOP_GRUPO (NOLOCK)"
        DBCampo_ID = "NR_GRUPO"
        DBCampo_NO = "NO_CFOP_GRUPO"
      Case enSql.CFOP, enSql.CFOP_DentroEstado, enSql.CFOP_ForaEstado, enSql.CFOP_ForaPais
        DBTabela = "VW_CFOP (NOLOCK)"
        DBCampo_ID = "SQ_CFOP"
        DBCampo_NO = "CD_CFOP"
        DBCamposAdicionais = ", DS_CFOP"

        Select Case ComboBox_Simples
          Case enSql.CFOP_DentroEstado
            sSqlText_Where = "ID_OPT_FRONT_ESTADO = " & enOpcoes.FronteiraEstados_DentroEstado.GetHashCode
          Case enSql.CFOP_ForaEstado
            sSqlText_Where = "ID_OPT_FRONT_ESTADO = " & enOpcoes.FronteiraEstados_ForaEstado.GetHashCode
          Case enSql.CFOP_ForaPais
            sSqlText_Where = "ID_OPT_FRONT_ESTADO = " & enOpcoes.FronteiraEstados_Exterior.GetHashCode
        End Select
      Case enSql.CST
        DBTabela = "VW_CST_ICMS (NOLOCK)"
        DBCampo_ID = "SQ_CST"
        DBCampo_NO = "CD_CST"
        DBCamposAdicionais = ",NO_CST,RTRIM(LTRIM(CD_CSOSN)) + '-' + NO_CSOSN NO_CSOSN,CD_CTECF,CD_CSOSN"
      Case enSql.CSOSN
        DBTabela = "TB_CSOSN (NOLOCK)"
        DBCampo_ID = "SQ_CSOSN"
        DBCampo_NO = "CD_CSOSN"
        DBCamposAdicionais = ", NO_CSOSN "
      Case enSql.CSTCofins, enSql.CSTPIS
        DBTabela = "VW_CST_PIS_COFINS (NOLOCK)"
        DBCampo_ID = "SQ_CST"
        DBCampo_NO = "CD_CST"
        DBCamposAdicionais = ", NO_CST"
      Case enSql.CSTIPI
        DBTabela = "VW_CST_IPI (NOLOCK)"
        DBCampo_ID = "SQ_CST"
        DBCampo_NO = "CD_CST"
        DBCamposAdicionais = ", NO_CST"
      Case enSql.NCM
        DBTabela = "TB_NCM (NOLOCK)"
        DBCampo_ID = "SQ_NCM"
        DBCampo_NO = "CD_NCM"
        DBCamposAdicionais = ", DS_NCM"
      Case enSql.GrupoProduto
        DBTabela = "TB_GRUPOPRODUTO (NOLOCK)"
        DBCampo_ID = "SQ_GRUPOPRODUTO"
        bFiltrarAtivo = True
        bFiltrarEmpresa = True
      Case enSql.TipoProduto
        DBTabela = "TB_TIPO_PRODUTO (NOLOCK)"
        DBCampo_ID = "SQ_TIPO_PRODUTO"
      Case enSql.GrupoPermissao
        DBTabela = "TB_SEG_GRUPOPERMISSAO (NOLOCK)"
        DBCampo_ID = "SQ_GRUPOPERMISSAO"
        DBCampo_NO = "NO_GRUPOPERMISSAO"
        sSqlText_Where = "ID_EMPRESA = " & iID_EMPRESA_MATRIZ
        bFiltrarNaoSistema = True
      Case enSql.Usuario_Permissao
        DBTabela = "VW_SEG_USUARIO_EMPRESA (NOLOCK)"
        DBCampo_ID = "ID_USUARIO"
        DBCampo_NO = "NO_PESSOA"
        bFiltrarNaoSistema = True
        bFiltrarAtivo = True
      Case enSql.FormaPagamento
        DBTabela = "VW_FORMAPAGAMENTO (NOLOCK)"
        DBCampo_ID = "SQ_FORMAPAGAMENTO"
        DBCamposAdicionais = ", ID_TIPO_DOCUMENTO, NO_TIPO_DOCUMENTO"
      Case enSql.NaturezaOperacao, enSql.NaturezaOperacao_Compras, enSql.NaturezaOperacao_Vendas
        DBTabela = "VW_NATUREZAOPERACAO (NOLOCK)"
        DBCampo_ID = "SQ_NATUREZAOPERACAO"
        bFiltrarAtivo = True
        bFiltrarEmpresa = True

        Select Case ComboBox_Simples
          Case enSql.NaturezaOperacao_Compras
            sSqlText_Where = "ID_OPT_ENTRADASAIDA = " & enOpcoes.CreditoDebito_Credito.GetHashCode
          Case enSql.NaturezaOperacao_Vendas
            sSqlText_Where = "ID_OPT_ENTRADASAIDA = " & enOpcoes.CreditoDebito_Debito.GetHashCode
        End Select

        If FNC_In(ComboBox_Simples, enSql.NaturezaOperacao_Compras, enSql.NaturezaOperacao_Vendas) Then
          FNC_Str_Adicionar(sSqlText_Where, "(ISNULL(IC_GERAFINANCEIRO, 'N') = 'S' OR ISNULL(IC_MOVIMENTAESTOQUE, 'N') = 'S')", " AND ")
        ElseIf FNC_In(ComboBox_Simples, enSql.NaturezaOperacao_SomenteFiscal) Then
          FNC_Str_Adicionar(sSqlText_Where, "IC_EXIGEPEDIDO = 'N'", " AND ")
        End If

        DBCamposAdicionais = ", IC_CALCULA_IPI, ID_OPT_TIPO_REFERENCIA, IC_CREDITO_ICMS, IC_DESTACA_IMPOSTOS" &
                             ", IC_EXIGEPEDIDO, IC_GERAFINANCEIRO, IC_MOVIMENTAESTOQUE, ID_CFOP_DENTROESTADO" &
                             ", ID_CFOP_FORAESTADO, ID_CFOP_FORAPAIS, ID_OPT_FINALIDADE, ID_OPT_OBRIGATORIEDADE_NUMEROSERIE" &
                             ", ID_DOCUMENTOFISCAL_TIPO, ID_DOCUMENTOFISCAL_SERIE"
      Case enSql.Fornecedor
        DBTabela = "(SELECT SQ_PESSOA, NO_PESSOA, ID_EMPRESA FROM VW_PESSOA_NOME (NOLOCK) WHERE ISNULL(IC_FORNECEDOR, 'N') = 'S') X"
        DBCampo_ID = "SQ_PESSOA"
        DBCampo_NO = "NO_PESSOA"
        bFiltrarEmpresa = True
      Case enSql.Transportadora
        DBTabela = "(SELECT SQ_PESSOA, NO_PESSOA, ID_EMPRESA FROM VW_PESSOA_NOME (NOLOCK) WHERE ISNULL(IC_TRANSPORTADORA, 'N') = 'S') X"
        DBCampo_ID = "SQ_PESSOA"
        DBCampo_NO = "NO_PESSOA"
        bFiltrarEmpresa = True
      Case enSql.StatusAgendamento_Todos
        sSqlText = "SELECT SQ_OPCAO, NO_OPCAO FROM TB_OPCAO (NOLOCK)" &
                   " WHERE IC_ATIVO = 'S'" &
                     " AND ID_TIPO_OPCAO IN ( " & enSql.StatusAgendamento_Sistema.GetHashCode & "," &
                                                  enSql.StatusAgendamento.GetHashCode & ")"

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText, "SQ_OPCAO IN (" & oParametro(0) & ")", " AND ")
        End If

        sSqlText = sSqlText & " ORDER BY NO_OPCAO"
      Case enSql.Endereco
        DBTabela = "(SELECT SQ_ENDERECO, DS_ENDERECO, ID_CIDADE, ID_UF, ID_PAIS FROM VW_ENDERECO (NOLOCK) WHERE ID_PESSOA = " & oParametro(0) & ") X"
        DBCampo_ID = "SQ_ENDERECO"
        DBCampo_NO = "DS_ENDERECO"

        DBCamposAdicionais = ", ID_CIDADE, ID_UF, ID_PAIS"
      Case enSql.CanalNegocio
        DBTabela = "(SELECT SQ_CANALNEGOCIO, NO_CANALNEGOCIO, ID_CONTABILIZACAO_PADRAO FROM TB_CANALNEGOCIO (NOLOCK)" &
                    " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                      " And IC_ATIVO = 'S'" &
                      " AND ID_OPT_TIPOCANALNEGOCIO = " & oParametro(0) & ") X"
        DBCampo_ID = "SQ_CANALNEGOCIO"
        DBCampo_NO = "NO_CANALNEGOCIO"

        DBCamposAdicionais = ", ID_CONTABILIZACAO_PADRAO"
      Case enSql.CondicaoPagamento_Venda, enSql.CondicaoPagamento_Recebimento
        DBTabela = "SELECT * FROM TB_CONDICAOPAGAMENTO (NOLOCK)" &
                   " WHERE IC_ATIVO = 'S'"

        If ComboBox_Simples = enSql.CondicaoPagamento_Venda Then
          DBTabela = DBTabela & " AND IC_USAR_VENDA = 'S'"
        End If
        If ComboBox_Simples = enSql.CondicaoPagamento_Recebimento Then
          DBTabela = DBTabela & " AND IC_USAR_RECEBIMENTO = 'S'"
        End If

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "( ID_FORMAPAGAMENTO_ENTRADA_PADRAO = " & oParametro(0) & " OR ID_FORMAPAGAMENTO_PARCELA_PADRAO = " & oParametro(0) & " )", " AND ")
        End If

        DBTabela = "(" & DBTabela & ") X"
        DBCampo_ID = "SQ_CONDICAOPAGAMENTO"
        DBCampo_NO = "NO_CONDICAOPAGAMENTO"

        DBCamposAdicionais = ",PC_ACRESCIMO,PC_ENTRADA,QT_PARCELA,ID_FORMAPAGAMENTO_ENTRADA_PADRAO,ID_FORMAPAGAMENTO_PARCELA_PADRAO,ID_TIPO_DOCUMENTO_ENTRADA_PADRAO" &
                             ",ID_TIPO_DOCUMENTO_PARCELA_PADRAO,QT_PARCELA_DIASPRIMEIRAPARCELA,QT_PARCELA_DIASINTERVALO,IC_GERAR_AVISTA,IC_USAR_RECEBIMENTO,IC_USAR_VENDA" &
                             ",PC_TAXA_COMPENSACAO,IC_ATIVO"
      Case enSql.UF_Codigo, enSql.UF
        DBTabela = "TB_UF (NOLOCK)"
        DBCampo_ID = "SQ_UF"

        Select Case ComboBox_Simples
          Case enSql.UF
            DBCampo_NO = "NO_UF"
          Case enSql.UF_Codigo
            DBCampo_NO = "CD_UF"
        End Select
      Case enSql.Departamento
        DBTabela = "TB_DEPARTAMENTO (NOLOCK)"
        DBCampo_ID = "SQ_DEPARTAMENTO"
        bFiltrarEmpresa = True
        bFiltrarAtivo = True
      Case enSql.ContaFinanceira
        DBTabela = $"(SELECT * FROM TB_CONTAFINANCEIRA (NOLOCK) WHERE ID_EMPRESA = {iID_EMPRESA_FILIAL}) X"
        DBCampo_ID = "SQ_CONTAFINANCEIRA"
        DBCampo_NO = "NO_CONTAFINANCEIRA"
        DBCamposAdicionais = ", ID_DEPARTAMENTO_RESPONSAVEL"
        bFiltrarEmpresa = True

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "(SQ_CONTAFINANCEIRA IN (SELECT ID_CONTAFINANCEIRA FROM TB_CONTAFINANCEIRA_PESSOA WHERE ID_PESSOA = " & oParametro(0) & ") OR ID_PESSOA_SUPERVISAO = " & oParametro(0) & ")", " AND ")
        End If
      Case enSql.TransacaoEstoque,
           enSql.TransacaoEstoque_MovimentacaoEstoque_Manual,
           enSql.TransacaoEstoque_Recebimento,
           enSql.TransacaoEstoque_Venda
        sSqlText = "SELECT SQ_TRANSACAOESTOQUE, NO_TRANSACAOESTOQUE, ID_ESTOQUE_CREDITO, ID_ESTOQUE_DEBITO, ID_ESTOQUE_LOCALIZACAO_CREDITO," &
                          "ID_ESTOQUE_LOCALIZACAO_DEBITO, NO_ESTOQUE_CREDITO, NO_ESTOQUE_DEBITO, IC_USAR_RECEBIMENTO, IC_USAR_VENDA, IC_USAR_MOVIMENTACAOMANUAL," &
                          "IC_ESTOQUE_CREDITO_PERMITE_BLOQUEIO, IC_ESTOQUE_CREDITO_CONTROLA_MINIMOS, IC_ESTOQUE_CREDITO_CONTROLA_LOCALIZACAO," &
                          "IC_ESTOQUE_CREDITO_PERMITE_SALDO_NEGATIVO, IC_ESTOQUE_CREDITO_ENTRADA_AUTOMATICA, IC_ESTOQUE_DEBITO_PERMITE_BLOQUEIO," &
                          "IC_ESTOQUE_DEBITO_CONTROLA_MINIMOS, IC_ESTOQUE_DEBITO_CONTROLA_LOCALIZACAO, IC_ESTOQUE_DEBITO_PERMITE_SALDO_NEGATIVO," &
                          "IC_ESTOQUE_DEBITO_ENTRADA_AUTOMATICA" &
                   " FROM VW_TRANSACAOESTOQUE (NOLOCK)" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                     " And IC_ATIVO_TOTAL = 'S'"

        Select Case ComboBox_Simples
          Case enSql.TransacaoEstoque_MovimentacaoEstoque_Manual
            sSqlText = sSqlText & " AND IC_USAR_MOVIMENTACAOMANUAL = 'S'"
          Case enSql.TransacaoEstoque_Recebimento
            sSqlText = sSqlText & " AND IC_USAR_RECEBIMENTO = 'S'"
          Case enSql.TransacaoEstoque_Venda
            sSqlText = sSqlText & " AND IC_USAR_VENDA = 'S'"
        End Select
      Case enSql.Produto
        sSqlText = "SELECT SQ_PRODUTO_EMPRESA, NO_PRODUTO FROM VW_PRODUTO_EMPRESA_FILIAL (NOLOCK)" &
                   " WHERE ID_EMPRESA = " & iID_EMPRESA_FILIAL & " AND IC_ATIVO = " & FNC_QuotedStr(oParametro(1))

        If oParametro(0) > 0 Then
          sSqlText = sSqlText & " AND SQ_PRODUTO = " & oParametro(0)
        End If

        DBTabela = "(" & sSqlText & ") X"
        DBCampo_ID = "SQ_PRODUTO_EMPRESA"
        DBCampo_NO = "NO_PRODUTO"
      Case enSql.TipoMovimentacaoFinanceira
        DBTabela = "VW_TIPO_MOVIMENTACAOFINANCEIRA (NOLOCK)"
        DBCampo_ID = "SQ_TIPO_MOVIMENTACAOFINANCEIRA"
      Case enSql.TipoContaFinanceira
        DBTabela = "TB_TIPO_CONTAFINANCEIRA (NOLOCK)"
        DBCampo_ID = "SQ_TIPO_CONTAFINANCEIRA"
      Case enSql.RepositorioImagem
        DBTabela = "(SELECT * FROM TB_REPOSITORIOARQUIVO (NOLOCK)" &
                    " WHERE ID_OPT_TIPO_REPOSITORIOARQUIVO = " & enOpcoes.TipoRepositorioArquivo_Imagem.GetHashCode &
                       "AND ID_EMPRESA = " & iID_EMPRESA_FILIAL & ") X"
        DBCampo_ID = "SQ_REPOSITORIOARQUIVO"
        DBCampo_NO = "DS_REPOSITORIOARQUIVO"
      Case enSql.RepositorioArquivo
        DBTabela = "(SELECT * FROM TB_REPOSITORIOARQUIVO (NOLOCK)" &
                    " WHERE ID_OPT_TIPO_REPOSITORIOARQUIVO = " & enOpcoes.TipoRepositorioArquivo_Arquivo.GetHashCode &
                       "AND ID_EMPRESA = " & iID_EMPRESA_FILIAL & ") X"
        DBCampo_ID = "SQ_REPOSITORIOARQUIVO"
        DBCampo_NO = "DS_REPOSITORIOARQUIVO"
      Case enSql.FaixaEtaria
        DBTabela = "TB_FAIXAETARIA (NOLOCK)"
        DBCampo_ID = "SQ_FAIXAETARIA"
      Case enSql.Legenda
        DBTabela = "TB_LEGENDA (NOLOCK)"
        DBCampo_ID = "SQ_LEGENDA"
      Case enSql.DicionarioDado_Processo_TipoModeloDocumento
        DBTabela = "(SELECT * FROM VW_DICIONARIODADO_PROCESSO_TIPOMODELODOCUMENTO (NOLOCK) WHERE ID_OPT_TIPO_MODELODOCUMENTO = " & oParametro(0) & ") X"
        DBCampo_ID = "SQ_DICIONARIODADO_PROCESSO"
        DBCampo_NO = "NO_DICIONARIODADO_PROCESSO"
      Case enSql.Legenda_Item
        DBTabela = "(SELECT * FROM TB_LEGENDA_ITEM (NOLOCK) WHERE ID_LEGENDA = " + oParametro(0).ToString + ") X"
        DBCampo_ID = "SQ_LEGENDA_ITEM"
        DBCampo_NO = "NO_LEGENDA_ITEM"
      Case enSql.Indicacao
        DBTabela = "(SELECT * FROM TB_INDICACAO (NOLOCK) WHERE ID_OPT_TIPO_INDICACAO = " + oParametro(0).ToString + ") X"
        DBCampo_ID = "SQ_INDICACAO"
        DBCampo_NO = "NO_INDICACAO"
      Case enSql.Vendedor
        DBTabela = "(SELECT SQ_PESSOA, NO_PESSOA, ID_EMPRESA FROM VW_PESSOA_NOME (NOLOCK) WHERE ID_EMPRESA = " + iID_EMPRESA_FILIAL.ToString() + " And IC_VENDEDOR = 'S' AND IC_VENDEDOR_ATIVO = 'S') X"
        DBCampo_ID = "SQ_PESSOA"
        DBCampo_NO = "NO_PESSOA"
        bFiltrarEmpresa = True
      Case enSql.ElementoModeloDocumento_Assinatura,
           enSql.ElementoModeloDocumento_Cabecalho,
           enSql.ElementoModeloDocumento_Rodape
        DBTabela = "(SELECT SQ_MODELODOCUMENTO_ELEMENTO," &
                           "NO_MODELODOCUMENTO_ELEMENTO" &
                    " FROM TB_MODELODOCUMENTO_ELEMENTO (NOLOCK)" &
                    " WHERE IC_ATIVO = 'S'" &
                      " AND (ID_EMPRESA = " & iID_EMPRESA_FILIAL & " OR ID_EMPRESA IS NULL)" &
                      " AND ID_OPT_TIPO_ELEMENTO = " & IIf(ComboBox_Simples = enSql.ElementoModeloDocumento_Assinatura, enOpcoes.TipoElementoModeloDocumento_Assinatura,
                                                       IIf(ComboBox_Simples = enSql.ElementoModeloDocumento_Cabecalho, enOpcoes.TipoElementoModeloDocumento_Cabecalho,
                                                                                                                       enOpcoes.TipoElementoModeloDocumento_Rodape)) & ") X"
        DBCampo_ID = "SQ_MODELODOCUMENTO_ELEMENTO"
        DBCampo_NO = "NO_MODELODOCUMENTO_ELEMENTO"
      Case enSql.Estoque
        DBTabela = "VW_ESTOQUE (NOLOCK)"
        DBCampo_ID = "SQ_ESTOQUE"
        DBCampo_NO = "NO_ESTOQUE"
        bFiltrarAtivo = True
        bFiltrarEmpresa = True
      Case enSql.LocalizacaoEstoque
        DBTabela = "VW_ESTOQUE_LOCALIZACAO (NOLOCK)"
        DBCampo_ID = "SQ_ESTOQUE_LOCALIZACAO"
        DBCampo_NO = "DS_LOCALIZACAO"
        bFiltrarAtivo = True
        bFiltrarEmpresa = True

        If Not oParametro Is Nothing Then
          FNC_Str_Adicionar(sSqlText_Where, "ID_ESTOQUE = " & oParametro(0).ToString, " AND ")
        End If
      Case enSql.ModeloDocumento_Receita,
           enSql.ModeloDocumento_Contrato,
           enSql.ModeloDocumento_Anamnese,
           enSql.ModeloDocumento_Evolucao,
           enSql.ModeloDocumento_Recibo,
           enSql.ModeloDocumento_Exame,
           enSql.ModeloDocumento_Outros
        Select Case ComboBox_Simples
          Case enSql.ModeloDocumento_Receita
            iTipoAux = enOpcoes.TipoModeloDocumento_Receita.GetHashCode
          Case enSql.ModeloDocumento_Contrato
            iTipoAux = enOpcoes.TipoModeloDocumento_Contrato.GetHashCode
          Case enSql.ModeloDocumento_Anamnese
            iTipoAux = enOpcoes.TipoModeloDocumento_Anamnese.GetHashCode
          Case enSql.ModeloDocumento_Evolucao
            iTipoAux = enOpcoes.TipoModeloDocumento_Evolucao.GetHashCode
          Case enSql.ModeloDocumento_Recibo
            iTipoAux = enOpcoes.TipoModeloDocumento_Recibo.GetHashCode
          Case enSql.ModeloDocumento_Exame
            iTipoAux = enOpcoes.TipoModeloDocumento_Exame.GetHashCode
          Case enSql.ModeloDocumento_Outros
            iTipoAux = enOpcoes.TipoModeloDocumento_Anexo.GetHashCode
        End Select
        DBTabela = "(SELECT SQ_MODELODOCUMENTO," &
                           "NO_MODELODOCUMENTO" &
                    " FROM TB_MODELODOCUMENTO (NOLOCK)" &
                    " WHERE (ID_EMPRESA = " & iID_EMPRESA_FILIAL & " OR ID_EMPRESA IS NULL)" &
                      " AND IC_ATIVO = 'S'" &
                      " AND ID_OPT_TIPO_MODELODOCUMENTO = " & iTipoAux & ") X"
        DBCampo_ID = "SQ_MODELODOCUMENTO"
        DBCampo_NO = "NO_MODELODOCUMENTO"
      Case enSql.Segmento_ContasReceberContasPagar.GetHashCode
        DBTabela = "TB_SEGMENTO (NOLOCK)"
        DBCampo_ID = "SQ_SEGMENTO"
        bFiltrarEmpresa = True
        bFiltrarAtivo = True
        FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_TIPOSEGMENTO = " & enOpcoes.TipoSegmento_ContasReceberContasPagar.GetHashCode, " AND ")
      Case enSql.Segmento_OrdemServico.GetHashCode
        DBTabela = "TB_SEGMENTO (NOLOCK)"
        DBCampo_ID = "SQ_SEGMENTO"
        bFiltrarEmpresa = True
        bFiltrarAtivo = True
        FNC_Str_Adicionar(sSqlText_Where, "ID_OPT_TIPOSEGMENTO = " & enOpcoes.TipoSegmento_OrdemServico.GetHashCode, " AND ")
      Case enSql.AgendaPessoal_AgendaLiberada
        DBTabela = "(SELECT *" &
                    " FROM (SELECT ID_PESSOA_AGENDA, NO_PESSOA_AGENDA, ID_OPT_TIPOLIBERACAO" &
                           " FROM VW_PESSOA_AGENDA_LIBERACAO (NOLOCK)" &
                           " WHERE ID_PESSOA_LIBERADA = " & iID_USUARIO &
                             " AND ID_EMPRESA = " & iID_EMPRESA_FILIAL &
                             " AND ID_OPT_TIPOLIBERACAO IS NOT NULL" &
                          " UNION ALL " &
                           "SELECT ID_USUARIO, NO_PESSOA, " & enOpcoes.TipoLiberacaoAgenda_Edicao.GetHashCode & " ID_OPT_TIPOLIBERACAO" &
                           " FROM VW_SEG_USUARIO (NOLOCK)" &
                           " WHERE ID_USUARIO = " & iID_USUARIO & ") X) Y"
        DBCampo_ID = "ID_PESSOA_AGENDA"
        DBCampo_NO = "NO_PESSOA_AGENDA"
        DBCamposAdicionais = ", ID_OPT_TIPOLIBERACAO"
      Case enSql.TipoModeloDocumento.GetHashCode
        sSqlText = "SELECT SQ_OPCAO, NO_OPCAO, CD_OPCAO, VL_MULTIPLICADOR FROM TB_OPCAO (NOLOCK)" &
                   " WHERE IC_ATIVO = 'S'" &
                     " AND ID_TIPO_OPCAO = " & ComboBox_Simples.GetHashCode &
                     " AND CD_OPCAO IN (" & FNC_Array_Para_Lista(oParametro, , True) & ")" &
                   " ORDER BY NO_OPCAO"
      Case enSql.CanalMarcacao
        DBTabela = "TB_CANALMARCACAO (NOLOCK)"
        DBCampo_ID = "SQ_CANALMARCACAO"
      Case enSql.FaixaEtaria
        DBTabela = "TB_FAIXAETARIA (NOLOCK)"
        DBCampo_ID = "SQ_FAIXAETARIA"
      Case Else
        sSqlText = "SELECT SQ_OPCAO, NO_OPCAO, CD_OPCAO, VL_MULTIPLICADOR FROM TB_OPCAO (NOLOCK)" &
                   " WHERE IC_ATIVO = 'S'" &
                     " AND ID_TIPO_OPCAO = " & ComboBox_Simples.GetHashCode &
                   " ORDER BY NO_OPCAO"
    End Select

    If Trim(DBCampo_ID) = "" Then DBCampo_ID = "SQ_" & Mid(DBTabela.Replace("(NOLOCK)", "").Trim(), 4)
    If Trim(DBCampo_NO) = "" Then DBCampo_NO = "NO_" & Mid(DBTabela.Replace("(NOLOCK)", "").Trim(), 4)

    If Trim(sSqlText) = "" Then
      sSqlText = "SELECT " & DBCampo_ID & "," & DBCampo_NO & DBCamposAdicionais &
                       " FROM " & DBTabela

      If bFiltrarEmpresa Then
        FNC_Str_Adicionar(sSqlText_Where, "ID_EMPRESA = " & iID_EMPRESA_FILIAL, " AND ")
      End If
      If bFiltrarEmpresaMatriz Then
        FNC_Str_Adicionar(sSqlText_Where, "ID_EMPRESA = " & iID_EMPRESA_MATRIZ, " AND ")
      End If
      If bFiltrarAtivo Then
        FNC_Str_Adicionar(sSqlText_Where, "IC_ATIVO = 'S'", " AND ")
      End If
      If bFiltrarNaoSistema Then
        FNC_Str_Adicionar(sSqlText_Where, "ISNULL(IC_SISTEMA, 'N') = 'N'", " AND ")
      End If
      If Trim(sSqlText_Where) <> "" Then
        sSqlText = sSqlText & " WHERE " & sSqlText_Where
      End If

      sSqlText = sSqlText &
                       " ORDER BY " & IIf(Trim(DBCampo_OrderBy) = "", DBCampo_NO, DBCampo_OrderBy)
    End If

    Return sSqlText
  End Function

  Public Sub ListBox_Carregar(oListBox As ListBox,
                              Sql As enSql,
                              Optional oParametro() As Object = Nothing)
    DBListBox_Carregar(oListBox, Carregar_SqlText(Sql, oParametro))
  End Sub

  Public Sub ComboBox_Carregar(oComboBox As ComboBox,
                               ComboBox_Simples As enSql,
                               Optional oParametro() As Object = Nothing,
                               Optional bAutoSelecionar As Boolean = False,
                               Optional ValorSelecionar As Object = Nothing)
    DBComboBox_Carregar(oComboBox, Carregar_SqlText(ComboBox_Simples, oParametro))

    Try
      oComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
      oComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Catch ex As Exception
    End Try

    If ValorSelecionar Is Nothing Then
      If oComboBox.Items.Count = 1 And bAutoSelecionar Then
        oComboBox.SelectedIndex = 0
      Else
        oComboBox.SelectedIndex = -1
      End If
    Else
      ComboBox_Selecionar(oComboBox, ValorSelecionar)
    End If

    Select Case ComboBox_Simples
      Case enSql.ContaCaixa
        ComboBox_Selecionar(oComboBox, iUSUARIO_ID_CONTAFINANCEIRA_PADRAO_VENDA)
    End Select
  End Sub

  Public Sub ComboBox_Carregar(ByVal oCombo As System.Windows.Forms.ComboBox,
                               ByVal Texto() As String,
                               Optional ByVal Codigo() As Object = Nothing,
                               Optional ByVal bAdicionarDados As Boolean = False,
                               Optional ByVal bInserirInicio As Boolean = False)
    Dim oData As New DataTable
    Dim RC As DataRowCollection
    Dim oRow As DataRow
    Dim oRowVal(1) As Object
    Dim iCont As Integer

    If bAdicionarDados Then
      oData = oCombo.DataSource
    Else
      oData.Columns.Add("Codigo")
      oData.Columns.Add("Descricao")
    End If

    RC = oData.Rows

    For iCont = 0 To UBound(Texto)
      If Not Codigo Is Nothing Then
        oRowVal(0) = Codigo(iCont)
      End If
      oRowVal(1) = Texto(iCont)

      If bInserirInicio Then
        oRow = oData.NewRow
        oRow.Item(0) = oRowVal(0)
        oRow.Item(1) = oRowVal(1)
        RC.InsertAt(oRow, 0)
      Else
        oRow = RC.Add(oRowVal)
      End If
    Next

    oCombo.AutoCompleteSource = AutoCompleteSource.ListItems
    oCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend

    oCombo.DisplayMember = oData.Columns(1).ColumnName
    oCombo.ValueMember = oData.Columns(0).ColumnName
    oCombo.DataSource = oData
  End Sub

  Public Function ComboBox_Selecionado(oComboBox As ComboBox) As Boolean
    If oComboBox.SelectedIndex >= 0 Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Function ChekBox_Valor(oCheckBox As System.Windows.Forms.CheckBox) As String
    If oCheckBox.Checked Then
      Return "Sim"
    Else
      Return "Não"
    End If
  End Function

  Public Sub ComboBox_CarregarImpressoraInstaladas(oComboBox As ComboBox)
    Dim v_total As Integer
    Dim v_cont As Integer
    Dim pd As PrintDocument = New PrintDocument
    Dim sDS() As String = Nothing
    Dim iDS() As Object = Nothing

    Try
      v_total = pd.PrinterSettings.InstalledPrinters.Count

      If v_total > 0 Then
        With pd.PrinterSettings.InstalledPrinters
          For v_cont = 0 To v_total - 1
            ReDim Preserve iDS(v_cont)
            ReDim Preserve sDS(v_cont)

            iDS(v_cont) = v_cont
            sDS(v_cont) = .Item(v_cont)
          Next
        End With

        ComboBox_Carregar(oComboBox, sDS, iDS)

        If oComboBox.Items.Count > 0 Then oComboBox.SelectedIndex = 0
      End If
    Catch ex As Exception
    Finally
      pd.Dispose()
    End Try
  End Sub

  Public Function ChekListBox_Selecionados(oListBox As System.Windows.Forms.CheckedListBox, Optional iItem As Integer = 0) As String
    Dim iCont As Integer
    Dim sRet As String = ""

    For iCont = 0 To oListBox.CheckedItems.Count - 1
      FNC_Str_Adicionar(sRet, oListBox.CheckedItems(iCont)(iItem), ",")
    Next

    If Trim(sRet) = "" Then sRet = "0"

    Return sRet
  End Function

  Public Sub ChekListBox_Selecionar(oListBox As System.Windows.Forms.CheckedListBox, Valor As Object)
    Dim iCont As Integer
    Dim sRet As String = ""

    For iCont = 0 To oListBox.Items.Count - 1
      If oListBox.Items(iCont)(0) = Valor Then
        oListBox.SetItemCheckState(iCont, CheckState.Checked)
        Exit For
      End If
    Next
  End Sub

  Public Sub ChekListBox_Desmarcar(oListBox As System.Windows.Forms.CheckedListBox)
    Dim iCont As Integer

    For iCont = 0 To oListBox.Items.Count - 1
      oListBox.SetItemCheckState(iCont, CheckState.Unchecked)
    Next
  End Sub

  Public Function TextBox_CampoVazio(oTextBox As TextBox) As Boolean
    If Trim(oTextBox.Text) = "" Then
      Return True
    Else
      Return False
    End If
  End Function

  Public Sub TextBox_FormatarCampoTexto(oTextBox As TextBox, Optional Tamanho As Integer = 0)
    oTextBox.MaxLength = IIf(Tamanho = 0, const_Controle_TamanhoComentario, Tamanho)
    oTextBox.ScrollBars = ScrollBars.Both
  End Sub

  Public Sub ComboBox_CarregarPessoa(oComboBox As ComboBox,
                                       Optional TipoFiltroPessoa As enTipoFiltroPessoa = enTipoFiltroPessoa.Pessoa,
                                       Optional iID_PESSOA As Integer = 0,
                                       Optional bCarregarDocumentoComNome As Boolean = False,
                                       Optional iAtivo As Integer = 20,
                                       Optional bCarregadoTodos As Boolean = False,
                                       Optional bSomenteDS_ID As Boolean = False,
                                       Optional bNome_CPF_CNPJ As Boolean = False,
                                       Optional bSomenteNome As Boolean = False)
    Dim sSqlText As String

    If Trim(oComboBox.Text) = "" And iID_PESSOA = 0 And Not bCarregadoTodos Then
      oComboBox.Items.Clear()
      oComboBox.DataSource = Nothing
    Else
      sSqlText = PesquisaPessoa_String(oComboBox.Text,
                                             IIf(TipoFiltroPessoa = enTipoFiltroPessoa.Pessoa_Fisica,
                                                 enTipoPessoa.Fisica.GetHashCode,
                                                 IIf(FNC_In(TipoFiltroPessoa, enTipoFiltroPessoa.Pessoa_Juridica,
                                                                              enTipoFiltroPessoa.Pessoa_Juridica_E_Empresa), enTipoPessoa.Juridica.GetHashCode, -1)),
                                             "",
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Cliente,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Fabricante,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Fornecedor,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Funcionario,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Medico,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Medico,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Transportadora,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Vendedor,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Paciente,
                                             TipoFiltroPessoa = enTipoFiltroPessoa.Pessoal_Geral Or TipoFiltroPessoa = enTipoFiltroPessoa.Pessoa_Juridica_E_Empresa,
                                             iAtivo, iID_PESSOA, 0, 0, bCarregarDocumentoComNome,
                                             bSomenteDS_ID, ,
                                             bNome_CPF_CNPJ, , bSomenteNome)
      Try
        oComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        oComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
      Catch ex As Exception
      End Try

      DBComboBox_Carregar(oComboBox, sSqlText, 0, 2)

      If oComboBox.Items.Count > 0 Then
        oComboBox.Text = ""
      End If
    End If
  End Sub

  Public Sub ComboBox_CarregarProduto(oComboBox As ComboBox,
                                        Optional iID_PRODUTO As Integer = 0,
                                        Optional iID_PRODUTO_EMPRESA As Integer = 0,
                                        Optional TipoProduto As Integer = 0,
                                        Optional GrupoProduto As Integer = 0,
                                        Optional Origem As Integer = 0,
                                        Optional Codigo As String = "",
                                        Optional Ativo As String = "T",
                                        Optional bCarregarCodigosComNome As Boolean = False,
                                        Optional bSomenteDS_ID As Boolean = False,
                                        Optional bListarLinhaProduto As Boolean = False)
    Dim sSqlText As String

    If Trim(oComboBox.Text) = "" And iID_PRODUTO = 0 And iID_PRODUTO_EMPRESA = 0 Then
      oComboBox.Items.Clear()
      oComboBox.DataSource = Nothing
    Else
      sSqlText = PesquisaProduto_String(iID_PRODUTO, iID_PRODUTO_EMPRESA, oComboBox.Text, TipoProduto, GrupoProduto, Origem, Codigo, Ativo, bCarregarCodigosComNome,, bSomenteDS_ID, bListarLinhaProduto, True)

      DBComboBox_Carregar(oComboBox,
                                sSqlText,
                                const_GridListagemProduto_ID_PRODUTO,
                                const_GridListagemProduto_NO_PRODUTO)

      If oComboBox.Items.Count > 0 Then
        oComboBox.Text = ""
      End If
    End If
  End Sub

  Public Sub ComboBox_CarregarProcedimento(bPesquisarPorCodigo As Boolean,
                                             oComboBox As ComboBox,
                                             oComboBoxPrincipal As ComboBox,
                                             Optional iSQ_PROCEDIMENTO As Integer = 0,
                                             Optional iID_TABELAPROCEDIMENTO As Integer = 0,
                                             Optional iID_CONVENIO As Integer = 0,
                                             Optional iID_PESSOA_PROFISSIONAL As Integer = 0,
                                             Optional iID_GRUPOPROCEDIMENTO As Integer = 0)
    Dim sSqlText As String = ""
    Dim sSqlText_Where As String = ""
    Dim sSqlText2 As String = ""

    If iSQ_PROCEDIMENTO = 0 Then
      If iID_TABELAPROCEDIMENTO = 0 Then
        iID_TABELAPROCEDIMENTO = iEMPRESA_ID_TABELAPROCEDIMENTO_PADRAO
      End If

      If iID_TABELAPROCEDIMENTO > 0 Then
        FNC_Str_Adicionar(sSqlText_Where, "PROCE.ID_TABELAPROCEDIMENTO = " & iID_TABELAPROCEDIMENTO, " AND ")
      End If
      If iID_GRUPOPROCEDIMENTO > 0 Then
        FNC_Str_Adicionar(sSqlText_Where, "PROCE.ID_GRUPOPROCEDIMENTO = " & iID_GRUPOPROCEDIMENTO, " AND ")
      End If

      If bPesquisarPorCodigo Then
        FNC_Str_Adicionar(sSqlText_Where, "PROCE.CD_PROCEDIMENTO LIKE " & FNC_SQL_FormatarLike(oComboBox.Text), " AND ")
      Else
        FNC_Str_Adicionar(sSqlText_Where, "PROCE.NO_PROCEDIMENTO LIKE " & FNC_SQL_FormatarLike(oComboBoxPrincipal.Text), " AND ")
      End If
    Else
      FNC_Str_Adicionar(sSqlText_Where, "PROCE.SQ_PROCEDIMENTO = " & iSQ_PROCEDIMENTO, " AND ")
    End If
    If iID_CONVENIO <> 0 Or iID_PESSOA_PROFISSIONAL <> 0 Then
      sSqlText2 = "SELECT ID_PROCEDIMENTO FROM TB_CONVENIO_PROCEDIMENTO WHERE IC_ATIVO = 'S'"

      If iID_CONVENIO <> 0 Then
        FNC_Str_Adicionar(sSqlText2, " ID_CONVENIO = " + iID_CONVENIO.ToString(), " AND ")
      End If
      If iID_PESSOA_PROFISSIONAL <> 0 Then
        FNC_Str_Adicionar(sSqlText2, " ID_PESSOA_PROFISSIONAL = " + iID_PESSOA_PROFISSIONAL.ToString(), " AND ")
      End If

      FNC_Str_Adicionar(sSqlText_Where, "PROCE.SQ_PROCEDIMENTO IN (" & sSqlText2 & ")", " AND ")
    End If

    If Not oComboBox Is Nothing Then
      sSqlText = "SELECT PROCE.SQ_PROCEDIMENTO," &
                        "PROCE.CD_PROCEDIMENTO," &
                        "PROCE.CD_INTEGRACAO_EXAME," &
                        "PROCE.DS_INTEGRACAO_EXAME," &
                        "PROCE.CD_INTEGRACAO_MATERIAL," &
                        "PROCE.DS_INTEGRACAO_MATERIAL" &
                 " FROM TB_PROCEDIMENTO PROCE" &
                 " WHERE ISNULL(IC_ATIVO, 'N') = 'S'"

      If Trim(sSqlText_Where) <> "" Then
        sSqlText = sSqlText &
                         " AND " & sSqlText_Where
      End If

      sSqlText = sSqlText &
                 " ORDER BY PROCE.NO_PROCEDIMENTO"

      DBComboBox_Carregar(oComboBox, sSqlText)
      oComboBox.SelectedIndex = -1
    End If
    If Not oComboBoxPrincipal Is Nothing Then
      sSqlText = "SELECT PROCE.SQ_PROCEDIMENTO," &
                        "PROCE.NO_PROCEDIMENTO," &
                        "PROCE.CD_INTEGRACAO_EXAME," &
                        "PROCE.DS_INTEGRACAO_EXAME," &
                        "PROCE.CD_INTEGRACAO_MATERIAL," &
                        "PROCE.DS_INTEGRACAO_MATERIAL" &
                 " FROM TB_PROCEDIMENTO PROCE" &
                 " WHERE ISNULL(IC_ATIVO, 'N') = 'S'"

      If Trim(sSqlText_Where) <> "" Then
        sSqlText = sSqlText &
                         " AND " & sSqlText_Where
      End If

      sSqlText = sSqlText &
                       " ORDER BY PROCE.NO_PROCEDIMENTO"

      DBComboBox_Carregar(oComboBoxPrincipal, sSqlText)
      oComboBoxPrincipal.SelectedIndex = -1
    End If
  End Sub

  Public Sub UltraComboBox_Inicializar(ByVal oCombo As Infragistics.Win.UltraWinGrid.UltraCombo,
                                         Optional ByVal TamanhoLista As Long = 0)
    With oCombo
      .DropDownStyle = UltraWinGrid.UltraComboStyle.DropDownList
      If TamanhoLista > 0 Then
        .DropDownWidth = TamanhoLista
      End If
      .DisplayLayout.AutoFitStyle = UltraWinGrid.AutoFitStyle.ResizeAllColumns
    End With
  End Sub
  Public Sub UltraDateTime_CarregarData(oData As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor, sData As String)
    Try
      oData.Text = sData
    Catch ex As Exception
    End Try
  End Sub
  Public Sub UltraComboBox_Carregar(ByVal oCombo As Infragistics.Win.UltraWinGrid.UltraCombo,
                                      ComboBox_Simples As enSql,
                                      Optional ByVal SelecionaAutomatico As Boolean = True,
                                      Optional ByVal LinhaBranco As Boolean = False)
    Dim SqlText As String

    SqlText = Carregar_SqlText(ComboBox_Simples)

    Select Case ComboBox_Simples
      Case enSql.CFOP, enSql.CFOP_DentroEstado, enSql.CFOP_ForaEstado, enSql.CFOP_ForaPais
        UltraDBComboBox_Carregar(oCombo, SqlText,
                                                 New Combo_Informacao() {UltraComboBox_Informacao("SQ_CFOP", False, 0, False, True),
                                                                         UltraComboBox_Informacao("Código", True, 50, True, False),
                                                                         UltraComboBox_Informacao("Descrição", True, 500, False, False)}, False)
      Case enSql.CST
        UltraDBComboBox_Carregar(oCombo, SqlText,
                                                 New Combo_Informacao() {UltraComboBox_Informacao("SQ_CST", False, 0, False, True),
                                                                         UltraComboBox_Informacao("Código", True, 50, True, False),
                                                                         UltraComboBox_Informacao("Descrição", True, 400, False, False),
                                                                         UltraComboBox_Informacao("CSOSN Padrão", True, 350, False, False),
                                                                         UltraComboBox_Informacao("ECF", True, 50, False, False),
                                                                         UltraComboBox_Informacao("Cód. CSOSN", True, 50, False, False)}, False)
      Case enSql.CSOSN
        UltraDBComboBox_Carregar(oCombo, SqlText,
                                  New Combo_Informacao() {UltraComboBox_Informacao("SQ_CSOSN", False, 0, False, True),
                                                          UltraComboBox_Informacao("Código", True, 50, True, False),
                                                          UltraComboBox_Informacao("Descrição", True, 500, False, False)}, False)
      Case enSql.CSTCofins, enSql.CSTIPI, enSql.CSTPIS
        UltraDBComboBox_Carregar(oCombo, SqlText,
                                  New Combo_Informacao() {UltraComboBox_Informacao("SQ_CST", False, 0, False, True),
                                                          UltraComboBox_Informacao("Código", True, 50, True, False),
                                                          UltraComboBox_Informacao("Descrição", True, 500, False, False)}, False)
      Case enSql.NCM
        UltraDBComboBox_Carregar(oCombo, SqlText,
                                                 New Combo_Informacao() {UltraComboBox_Informacao("SQ_NCM", False, 0, False, True),
                                                                         UltraComboBox_Informacao("Código", True, 50, True, False),
                                                                         UltraComboBox_Informacao("Descrição", True, 500, False, False)}, False)
    End Select
  End Sub

  Private Sub UltraDBComboBox_Carregar(ByVal oCombo As Infragistics.Win.UltraWinGrid.UltraCombo,
                                         SqlText As String,
                                         ByVal oCombo_Informacao() As Combo_Informacao,
                                         Optional ByVal SelecionaAutomatico As Boolean = True,
                                         Optional ByVal LinhaBranco As Boolean = False)
    Dim iCont As Integer
    Dim oData As DataTable
    Dim oDataCombo As New DataTable
    Dim iCont_01 As Integer

    oData = DBQuery(SqlText)
    oDataCombo = oData.Copy

    'Se for ter linha em branco
    If LinhaBranco Then
      Dim oRow As DataRow

      'LInha em branco
      oDataCombo.Rows.Clear()
      oRow = oDataCombo.NewRow
      oDataCombo.Rows.Add(oRow)
      oRow(0) = -1
      oRow(1) = Nothing

      For iCont = 0 To oData.Rows.Count - 1
        oRow = oDataCombo.NewRow

        For iCont_01 = 0 To oData.Columns.Count - 1
          oRow(iCont_01) = oData.Rows(iCont)(iCont_01)
        Next

        oDataCombo.Rows.Add(oRow)
      Next
    End If

    If Not oCombo_Informacao Is Nothing Then
      oCombo.DataSource = oDataCombo
      oCombo.DataBind()

      For iCont = LBound(oCombo_Informacao) To UBound(oCombo_Informacao)
        With oCombo_Informacao(iCont)
          oCombo.DisplayLayout.Bands(0).Columns(iCont).Header.Caption = .Titulo
          If .Tamanho > 0 Then
            oCombo.DisplayLayout.Bands(0).Columns(iCont).Width = .Tamanho
          End If
          oCombo.DisplayLayout.Bands(0).Columns(iCont).Hidden = (Not .Visivel)

          If .Descricao Then
            oCombo.DisplayMember = oData.Columns(iCont).ColumnName
          End If
          If .Codigo Then
            oCombo.ValueMember = oData.Columns(iCont).ColumnName
          End If

          If Trim(.Formato) <> "" Then
            oCombo.DisplayLayout.Bands(0).Columns(iCont).Format = .Formato
          End If

          oCombo.DisplayLayout.Bands(0).Columns(iCont).Style = .Tipo
        End With
      Next

      If SelecionaAutomatico And oCombo.DisplayLayout.Rows.Count > 0 Then
        oCombo.SelectedRow = oCombo.DisplayLayout.Rows(0)
      End If
    End If
  End Sub

  Public Function UltraComboBox_Informacao(ByVal Titulo As String, ByVal Visivel As Boolean,
                                             ByVal Tamanho As Long, Optional ByVal Descricao As Boolean = False,
                                             Optional ByVal Codigo As Boolean = False,
                                             Optional ByVal Formato As String = "",
                                             Optional ByVal Tipo As UltraWinGrid.ColumnStyle = UltraWinGrid.ColumnStyle.Default) As Combo_Informacao
    Dim oCombo_Informacao As New Combo_Informacao

    With oCombo_Informacao
      .Titulo = Titulo
      .Visivel = Visivel
      .Tamanho = Tamanho
      .Descricao = Descricao
      .Codigo = Codigo
      .Formato = Formato
      .Tipo = Tipo
    End With

    Return oCombo_Informacao
  End Function

  Public Sub UltraComboBox_Selecionar(ByVal oCombo As Infragistics.Win.UltraWinGrid.UltraCombo,
                                         ByVal Coluna As Integer,
                                         ByVal vValor As Object)
    Dim iIndice As Integer
    Dim bAchou As Boolean

    For iIndice = 0 To oCombo.DisplayLayout.Rows.Count - 1
      If Not FNC_CampoNulo(vValor) Then
        If oCombo.DisplayLayout.Rows(iIndice).Cells(Coluna).Value = vValor Then
          bAchou = True
          Exit For
        End If
      End If
    Next

    If bAchou Then
      oCombo.SelectedRow = oCombo.DisplayLayout.Rows(iIndice)
    Else
      oCombo.SelectedRow = Nothing
    End If
  End Sub

  Public Function UltraComboBox_Selecionado(ByVal oCombo As Infragistics.Win.UltraWinGrid.UltraCombo) As Boolean
    If oCombo.SelectedRow Is Nothing Then
      Return False
    Else
      If Trim(oCombo.SelectedRow.Cells(0).Value) = "-1" Then
        Return False
      Else
        Return True
      End If
    End If
  End Function

  Public Function UltraComboBox_Valor(ByVal oCombo As Infragistics.Win.UltraWinGrid.UltraCombo, Optional iColuna As Integer = 0) As Object
    If oCombo.ActiveRow Is Nothing Then
      Return Nothing
    Else
      If oCombo.ActiveRow.IsEmptyRow Then
        Return False
      Else
        Try
          Return oCombo.ActiveRow.Cells(iColuna).Value
        Catch ex As Exception
          Return Nothing
        End Try
      End If
    End If
  End Function
End Module
