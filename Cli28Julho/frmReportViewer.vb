Imports System.ComponentModel
Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms

Public Class frmReportViewer
  Public Enum enTipoRelatorio
    ListagemPessoa = 1
    ListagemAniversario = 2
    Financeira_FluxoCaixa = 3
    LancamentoFinanceiro_ContaReceberPagar = 4
    LancamentoFinanceiro_FluxoCaixa = 5
    Clinica_Agendamento_Listagem = 6
    Clinica_Atendimento_Listagem = 7
    ListagemProduto = 8
    ListagemProdutoFiscal = 9
    ListagemTabelaPreco = 10
    ListagemTabelaPrecoCusto = 11
    ListagemTabelaPrecoValores = 12
    LancamentoFinanceiro_Compensacao = 13
    Compra_ListagemGeral = 14
    Compra_ListagemProduto = 15
    Venda_ListagemGeral = 16
    Venda_ListagemProduto = 17
    LancamentoFinanceiro_CadastroContaFinanceira = 18
    CadastroPaciente = 19
    Estoque_Cardex = 20
    Estoque_MovimentacaoEstoque = 21
    Estoque_Saldo = 22
    Estoque_ListagemNumeroSerie = 23
    OrdemServico = 24
    OrdemServico_Historico = 25
    LancamentoFinanceiro_ContaReceberPagarParcela = 26
    PlanoContas = 27
    PlanoContasValores = 28
    ListagemUsuario = 29
    Orcamento = 30
    ClinicaOrcamento = 31
    GuiaConsulta = 32
    ExameInterno = 33
    ExameExterno = 34
    AtestadoMedico = 35
    AtestadoAcompanhante = 36
    AtestadoComparecimento = 37
    SolicitacaoExame = 38
    Receituario = 39
    RelatorioMedico = 40
    SolicitacaoVacina = 41
    ClinicaVendaFechamento = 42
    FinanceiroComprovanteTransferencia = 43
    FinanceiroReciboPagamento = 44
    ExameCitologico = 45
    SolicitacaoCitologiaLote = 46
    MedicoFaturamento = 47
    Agendamento = 48
    Voucher = 49
    Voucher_Lancamento = 50
    ConsultaMinhasFaturas = 51
  End Enum

  Public TipoRelatorio As enTipoRelatorio
  Public sFiltro As String
  Public bImprimir As Boolean

  Dim bPaisagem As Boolean = False
  Dim iContador As Integer

  Public Sub Formatar(Optional bRelatorio As Boolean = True)
    Try
      Dim sRodape As String = "-"
      Dim sSubTitulo As String = "-"

      Select Case TipoRelatorio
        Case enTipoRelatorio.ClinicaOrcamento
          sSubTitulo = "Clínica Orçamento"
          Me.Text = "Relatório de Clínica Orçamento"
      End Select

      Select Case TipoRelatorio
        Case enTipoRelatorio.ClinicaOrcamento,
             enTipoRelatorio.GuiaConsulta,
             enTipoRelatorio.ExameInterno,
             enTipoRelatorio.ExameExterno,
             enTipoRelatorio.AtestadoMedico,
             enTipoRelatorio.AtestadoAcompanhante,
             enTipoRelatorio.AtestadoComparecimento,
             enTipoRelatorio.SolicitacaoExame,
             enTipoRelatorio.Receituario,
             enTipoRelatorio.RelatorioMedico,
             enTipoRelatorio.SolicitacaoVacina,
             enTipoRelatorio.ClinicaVendaFechamento,
             enTipoRelatorio.FinanceiroComprovanteTransferencia,
             enTipoRelatorio.FinanceiroReciboPagamento,
             enTipoRelatorio.ExameCitologico,
             enTipoRelatorio.SolicitacaoCitologiaLote
          bPaisagem = False
        Case Else
          bPaisagem = True
      End Select

      If Trim(sFiltro) = "" Then sFiltro = " "
      sRodape = FNC_Sistema_Relatorio_Rodape()

      Dim oPar_Rodape As New ReportParameter("Rodape", sRodape)
      Dim oPar_Empresa As New ReportParameter("Empresa", sNO_EMPRESA_FILIAL)
      Dim oPar_Empresa_Dados As New ReportParameter("Empresa_Dados", sEMPRESA_DADOS_RELATORIO)
      Dim oPar_SubTitulo As New ReportParameter("SubTitulo", sSubTitulo)
      Dim oPar_Filtro As New ReportParameter("Filtro", sFiltro)

      With Me.rpvGeral
        .ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        .PrinterSettings.DefaultPageSettings.Landscape = bPaisagem
        .DocumentMapCollapsed = True
        .LocalReport.EnableExternalImages = True
      End With
    Catch ex As Exception
      FNC_Mensagem("frmReportViewer - " & Me.rpvGeral.LocalReport.ReportPath & " - " & ex.Message)
    End Try
  End Sub

  Private Sub rpvGeral_Load(sender As Object, e As EventArgs) Handles rpvGeral.Load
    Dim ps = New System.Drawing.Printing.PageSettings()
    Dim sSqlText As String

    ps.Landscape = bPaisagem
    ps.PaperSize.RawKind = System.Drawing.Printing.PaperKind.A4

    'If bPaisagem Then
    ps.Margins.Top = 59
    ps.Margins.Left = 50
    ps.Margins.Right = 50
    ps.Margins.Bottom = 59
    'End If

    Select Case TipoRelatorio
      Case enTipoRelatorio.ClinicaOrcamento,
           enTipoRelatorio.GuiaConsulta,
           enTipoRelatorio.ExameInterno,
           enTipoRelatorio.ExameExterno,
           enTipoRelatorio.AtestadoMedico,
           enTipoRelatorio.AtestadoAcompanhante,
           enTipoRelatorio.AtestadoComparecimento,
           enTipoRelatorio.SolicitacaoExame,
           enTipoRelatorio.Receituario,
           enTipoRelatorio.RelatorioMedico,
           enTipoRelatorio.SolicitacaoVacina,
           enTipoRelatorio.ClinicaVendaFechamento,
           enTipoRelatorio.FinanceiroComprovanteTransferencia,
           enTipoRelatorio.FinanceiroReciboPagamento,
           enTipoRelatorio.ExameCitologico,
           enTipoRelatorio.SolicitacaoCitologiaLote,
           enTipoRelatorio.MedicoFaturamento,
           enTipoRelatorio.Agendamento
        ps.Margins.Top = 0
        ps.Margins.Left = 0
        ps.Margins.Right = 0
        ps.Margins.Bottom = 0
      Case Else
        ps.Margins.Top = 59
        ps.Margins.Left = 50
        ps.Margins.Right = 50
        ps.Margins.Bottom = 59
    End Select

    Select Case TipoRelatorio
      Case enTipoRelatorio.FinanceiroComprovanteTransferencia
        ps.PaperSize = CalculatePaperSize(ps.PaperSize.Width, ps.PaperSize.Height / 2)
      Case enTipoRelatorio.AtestadoMedico,
           enTipoRelatorio.AtestadoAcompanhante,
           enTipoRelatorio.AtestadoComparecimento,
           enTipoRelatorio.Receituario,
           enTipoRelatorio.RelatorioMedico,
           enTipoRelatorio.SolicitacaoExame,
           enTipoRelatorio.ExameCitologico
        ps.PaperSize.RawKind = System.Drawing.Printing.PaperKind.A5
      Case enTipoRelatorio.ClinicaOrcamento,
           enTipoRelatorio.ExameExterno,
           enTipoRelatorio.GuiaConsulta,
           enTipoRelatorio.ExameInterno,
           enTipoRelatorio.SolicitacaoCitologiaLote,
           enTipoRelatorio.MedicoFaturamento
        ps.PaperSize.RawKind = System.Drawing.Printing.PaperKind.A4
    End Select

    ps.Landscape = bPaisagem

    sSqlText = "SELECT IM_LOGOTIPO FROM TB_EMPRESA WHERE ID_EMPRESA = " + iID_EMPRESA_FILIAL.ToString()

    rpvGeral.PrinterSettings.PrinterName = FNC_Impressora_Padrao()
    rpvGeral.ShowPrintButton = True
    rpvGeral.SetDisplayMode(DisplayMode.PrintLayout)
    rpvGeral.ZoomMode = ZoomMode.PageWidth
    rpvGeral.SetPageSettings(ps)
    rpvGeral.Refresh()

    rpvGeral.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("EMPRESA", DBQuery(sSqlText)))
    rpvGeral.RefreshReport()
  End Sub

  Public Function CalculatePaperSize(WidthInCentimeters As Double, HeightInCentimetres As Double) As System.Drawing.Printing.PaperSize
    'Dim Width As Integer = Integer.Parse((Math.Round((WidthInCentimeters * 0.393701) * 100, 0, MidpointRounding.AwayFromZero)).ToString())
    'Dim Height As Integer = Integer.Parse((Math.Round((HeightInCentimetres * 0.393701) * 100, 0, MidpointRounding.AwayFromZero)).ToString())

    Dim NewSize As PaperSize = New PaperSize()
    NewSize.RawKind = PaperKind.Custom
    NewSize.Width = WidthInCentimeters
    NewSize.Height = HeightInCentimetres
    NewSize.PaperName = "Custom"

    Return NewSize
  End Function

  Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
    Select Case TipoRelatorio
      Case enTipoRelatorio.ClinicaOrcamento
        Me.Text = "Orçamento"
      Case enTipoRelatorio.GuiaConsulta
        Me.Text = "Guia de Consulta"
      Case enTipoRelatorio.ExameInterno
        Me.Text = "Exames Internos"
      Case enTipoRelatorio.ExameExterno
        Me.Text = "Exames Externos"
      Case enTipoRelatorio.AtestadoMedico
        Me.Text = "Atestado Médico"
      Case enTipoRelatorio.AtestadoAcompanhante
        Me.Text = "Atestado de Acompanhante"
      Case enTipoRelatorio.AtestadoComparecimento
        Me.Text = "Atestado Comparecimento"
      Case enTipoRelatorio.SolicitacaoExame
        Me.Text = "Solicitação de Exame"
      Case enTipoRelatorio.Receituario
        Me.Text = "Receituário"
      Case enTipoRelatorio.RelatorioMedico
        Me.Text = "Relatório Médico"
      Case enTipoRelatorio.SolicitacaoVacina
        Me.Text = "Solicitação de Vacina"
      Case enTipoRelatorio.ClinicaVendaFechamento
        Me.Text = "Fechamento de Venda"
      Case enTipoRelatorio.FinanceiroComprovanteTransferencia
        Me.Text = "Comprovante de Transferência"
      Case enTipoRelatorio.FinanceiroReciboPagamento
        Me.Text = "Recibo de Pagamento"
      Case enTipoRelatorio.Voucher
        Me.Text = "Voucher"
      Case enTipoRelatorio.Voucher_Lancamento
        Me.Text = "Voucher - Lançamentos"
      Case enTipoRelatorio.ConsultaMinhasFaturas
        Me.Text = "Consulta Minhas Faturas"
    End Select
  End Sub
End Class