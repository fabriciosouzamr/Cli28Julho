Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Module modSisVida
  Public Class Cabecalho
    Public Property login As String
    Public Property senha As String
    Public Property codlab As String
    Public Property integracao As Integer
    Public Property versao As String
    Public Property datahora As String
    Public Property software As String
    Public Property operador As String
  End Class
  Public Class Amostra
    Public Property codigo_lis As Integer
    Public Property codigo As String
    Public Property descricao As String
    Public Property exames As List(Of Exame)
  End Class

  Public Class Cidade
    'Public Property codigo As String
    'Public Property estado_id As Integer
    'Public Property id As Integer
    'Public Property localidade As String
    Public Property municipio As String
    'Public Property tipo_localidade As String
  End Class

  Public Class Estado
    Public Property codigo_tiss As String
    Public Property descricao As String
    Public Property id As Integer
    Public Property identificador As Object
    Public Property pais_id As Integer
    Public Property sigla As String
  End Class

  Public Class Exame
    Public Property codigo_lis As Integer
    Public Property codigo As String
    Public Property prioridade As Integer
    Public Property descricao As String
    'Public Property dados_adicionais As String
  End Class

  Public Class Paciente
    Public Property codigo_lis As Integer
    Public Property nome As String
    Public Property data_nascimento As String
    Public Property sexo As String
    Public Property tipo_documento As String
    Public Property documento As String
    Public Property cpf As String
    Public Property telefone As String
    Public Property endereco As String
    Public Property cidade As Cidade
    Public Property estado As String
  End Class

  Public Class ProfissionalSaudeSolicitante
    Public Property nome As String
    Public Property uf_conselho As String
    Public Property numero_conselho As String
    Public Property cbo_s As String
    Public Property conselho_profissional As String
  End Class

  Public Class Solicitaco
    'Public Property codigo_lis As Integer
    Public Property paciente As Paciente
    Public Property profissional_saude_solicitante As ProfissionalSaudeSolicitante
    'Public Property observacao As String
    Public Property data As String
    Public Property crm As String
    Public Property amostras As List(Of Amostra)
  End Class

  Public Class Root
    Public Property cabecalho As Cabecalho
    Public Property solicitacoes As List(Of Solicitaco)
  End Class

  Dim _amostras As List(Of Amostra)
  Dim _exames As List(Of Exame)

  Public Sub Inicializar()
    _amostras = New List(Of Amostra)
    _exames = New List(Of Exame)
  End Sub

  Private Sub AdicionarExame(CD_INTEGRACAO_MATERIAL As String, DS_INTEGRACAO_MATERIAL As String, _exame As Exame)
    Dim _amostra As Amostra
    Dim iCont As Integer

    For iCont = 0 To _amostras.Count - 1
      If _amostras(iCont).codigo = CD_INTEGRACAO_MATERIAL Then
        _amostra = _amostras(iCont)
        _amostra.exames.Add(_exame)
        _amostras(iCont) = _amostra
        Exit For
      End If
    Next

    If _amostra Is Nothing Then
      _amostra = New Amostra()
      _amostra.codigo_lis = 0
      _amostra.codigo = CD_INTEGRACAO_MATERIAL
      _amostra.descricao = DS_INTEGRACAO_MATERIAL
      _amostra.exames = New List(Of Exame)
      _amostra.exames.Add(_exame)
      _amostras.Add(_amostra)
    End If
  End Sub

  Public Sub AdicionarExames(SQ_PROCEDIMENTO As Integer,
                             CD_INTEGRACAO_EXAME As String,
                             DS_INTEGRACAO_EXAME As String,
                             CD_INTEGRACAO_MATERIAL As String,
                             DS_INTEGRACAO_MATERIAL As String)
    Dim _exame = New Exame

    _exame.codigo_lis = SQ_PROCEDIMENTO
    _exame.codigo = CD_INTEGRACAO_EXAME
    _exame.prioridade = 1
    _exame.descricao = DS_INTEGRACAO_EXAME

    AdicionarExame(CD_INTEGRACAO_MATERIAL, DS_INTEGRACAO_MATERIAL, _exame)
  End Sub

  Public Sub EnviarSimples(SQ_CLINICA_VENDA_PROCEDIMENTO As Integer,
                           ID_PACIENTE As Integer,
                           NO_PACIENTE As String,
                           DT_PACIENTE_NASCIMENTO As String,
                           CD_SEXO As String,
                           CD_PACIENTE_CPF As String,
                           CD_PACIENTE_TELEFONE As String,
                           DS_PACIENTE_ENDERECO As String,
                           DS_PACIENTE_ENDERECO_CIDADE As String,
                           CD_PACIENTE_ENDERECO_UF As String,
                           NO_PROFISSIONAL As String,
                           NO_PROFISSIONAL_CONSELHO_UF As String,
                           NO_PROFISSIONAL_CONSELHO_NR As String,
                           NO_PROFISSIONAL_CBO As String,
                           NO_PROFISSIONAL_CONSELHO As String)
    Try
      Dim _envio As Root = New Root()
      Dim _solicitaco As Solicitaco = New Solicitaco()
      Dim _paciente As Paciente = New Paciente()
      Dim _profissionalSaudeSolicitante As ProfissionalSaudeSolicitante = New ProfissionalSaudeSolicitante()

      Dim Integracao As modDeclaracaoLocal.Integracao = FNC_Integracao_CarregarDados(modDeclaracaoLocal.enIntegracao.eSisVida)

      If FNC_NVL(Integracao.DS_LINK, "") = "" Then
        FNC_Mensagem("A Integração do SisVda está desconfigurada")
        Exit Sub
      End If

      _paciente.codigo_lis = ID_PACIENTE
      _paciente.nome = NO_PACIENTE
      _paciente.data_nascimento = DT_PACIENTE_NASCIMENTO
      _paciente.tipo_documento = "SR"
      _paciente.documento = "0"
      _paciente.sexo = CD_SEXO
      _paciente.cpf = CD_PACIENTE_CPF
      _paciente.telefone = CD_PACIENTE_TELEFONE
      _paciente.endereco = DS_PACIENTE_ENDERECO
      _paciente.cidade = New Cidade()
      _paciente.cidade.municipio = DS_PACIENTE_ENDERECO_CIDADE
      _paciente.estado = CD_PACIENTE_ENDERECO_UF

      _profissionalSaudeSolicitante.nome = NO_PROFISSIONAL
      _profissionalSaudeSolicitante.uf_conselho = NO_PROFISSIONAL_CONSELHO_UF
      _profissionalSaudeSolicitante.numero_conselho = NO_PROFISSIONAL_CONSELHO_NR
      _profissionalSaudeSolicitante.cbo_s = NO_PROFISSIONAL_CBO
      _profissionalSaudeSolicitante.conselho_profissional = NO_PROFISSIONAL_CONSELHO

      _solicitaco.paciente = _paciente
      _solicitaco.profissional_saude_solicitante = _profissionalSaudeSolicitante
      _solicitaco.data = DateTime.Now.ToString()
      _solicitaco.crm = NO_PROFISSIONAL_CONSELHO_NR & "-" & NO_PROFISSIONAL_CONSELHO_UF
      _solicitaco.amostras = New List(Of Amostra)
      _solicitaco.amostras = _amostras

      _envio.cabecalho = New Cabecalho()
      _envio.cabecalho.login = Integracao.CD_CHAVE_01
      _envio.cabecalho.senha = Integracao.CD_CHAVE_02
      _envio.cabecalho.codlab = Integracao.CD_CHAVE_03
      _envio.cabecalho.integracao = Integracao.CD_CHAVE_04
      _envio.cabecalho.versao = "v1"
      _envio.cabecalho.datahora = DateTime.Now.ToString()
      _envio.cabecalho.software = const_Sistema_Nome
      _envio.cabecalho.operador = sNO_USUARIO
      _envio.solicitacoes = New List(Of Solicitaco)
      _envio.solicitacoes.Add(_solicitaco)

      Dim sTexto As String

      sTexto = Enviar(Integracao.DS_LINK + "/remessa", _envio)

      FNC_Historico_Incluir(enOpcoes.Processo_Historico_Vendas_Lancamento,
                            enOpcoes.Processo_Acao_Transmissao, 0,
                            SQ_CLINICA_VENDA_PROCEDIMENTO,
                            sTexto, "")
    Catch ex As Exception
      FNC_Mensagem("SisVida >> " + ex.Message)
    End Try
  End Sub

  Public Function Enviar(sLink As String, _envio As Root) As String
    Dim sRetorno As String = ""
    Dim httpResponse As HttpWebResponse

    Try
      ToJSON = JsonConvert.SerializeObject(_envio)
      Dim dados = Encoding.UTF8.GetBytes(ToJSON)

      sRetorno = ToJSON

      'Dim webClient As New WebClient()
      'Dim resByte As Byte()
      'Dim reqString() As Byte

      'webClient.Headers("content-type") = "application/x-www-form-urlencoded"
      'reqString = Encoding.Default.GetBytes(ToJSON)
      'resByte = webClient.UploadData(sLink + "/enviar", "post", reqString)
      'sRetorno = Encoding.Default.GetString(resByte)
      'webClient.Dispose()

      'Dim requisicaoWeb = WebRequest.CreateHttp(sLink + "/enviar")
      'requisicaoWeb.Method = "POST"
      'requisicaoWeb.ContentType = "application/x-www-form-urlencoded"
      'requisicaoWeb.ContentLength = dados.Length
      'requisicaoWeb.UserAgent = "RequisicaoWebDemo"

      'Using stream = requisicaoWeb.GetRequestStream()
      '  stream.Write(dados, 0, dados.Length)
      '  stream.Close()
      '  sRetorno = stream.ToString()
      'End Using

      'Dim request As WebRequest = WebRequest.Create(sLink + "/enviar")
      'request.Method = "POST"

      'Dim myRequestAsBytes As Byte() = Encoding.UTF8.GetBytes(ToJSON)
      'request.ContentType = "application/json"
      'request.ContentLength = dados.Length

      'Dim dataStream As Stream = request.GetRequestStream()
      'dataStream.Write(dados, 0, dados.Length)
      'dataStream.Close()

      'Dim response As WebResponse = request.GetResponse()
      'Dim responseStatus = CType(response, HttpWebResponse).StatusDescription

      'response.Close()

      Dim httpWebRequest = CType(WebRequest.Create(sLink + "/enviar"), HttpWebRequest)
      httpWebRequest.ContentType = "application/json"
      httpWebRequest.Method = "POST"
      'httpWebRequest.ContentLength = ToJSON.Length

      Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())
        streamWriter.Write(ToJSON)
      End Using

      httpResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)

      Using streamReader = New StreamReader(httpResponse.GetResponseStream())
        Dim responseText As String = streamReader.ReadToEnd()
      End Using
    Catch ex As Exception
      'FNC_Mensagem(ex.Message)
    End Try

    Return sRetorno
  End Function
End Module
