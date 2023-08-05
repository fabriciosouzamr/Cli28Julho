<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDI
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDI))
    Me.mnuGeral = New System.Windows.Forms.MenuStrip()
    Me.mnuCadastro = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa_FisicaJuridica = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa_Profissao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa_Funcao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa_ConselhoProfissional = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa_Empresa = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa_Cidade = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa_UF = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Pessoa_Pais = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_Especialidade = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_GrupoProcedimento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_Procedimento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_CadastrarHorarioProfissional = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_Configuracao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_Convenio = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_Vacina = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_Consultorio = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_Turno = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_ClassificacaoExame = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_TipoIndicador = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Clinica_CanalMarcacao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoCargo = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoConsulta = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoDocumentoFinanceiro = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoEndereco = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoEscolaridade = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoEstadoCivil = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoMidiaSocial = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoPaciente = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoPessoa = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoRaca = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoRelatorio = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoReferencialPessoal = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Tipo_TipoRelegiao = New System.Windows.Forms.ToolStripMenuItem()
    Me.TipoDeSexoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Separador01 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuCadastro_Usuario = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Usuario_Configuracao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Usuario_AlterarSenha = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Separador02 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuCadastro_Seguranca = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Seguranca_GrupoPermissao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Seguranca_Permissao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuFinanceiro = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_ContasReceber = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_ContasPagar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_FluxoCaixa = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_Separador01 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuCadastro_Financeiro_ConsultaContasReceber = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_ConsultaContasPagar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_ConsultaFluxoCaixa = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_Separador02 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuCadastro_Financeiro_Compensacao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_Separador03 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuCadastro_Financeiro_ConsultaDeFluxoCaixa = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_Separador04 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuCadastro_Financeiro_FaturamentoVenda = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_CondicaoPagamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_Banco = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_ContaBancaria = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_ContaCaixa = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_FormaPagamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_PlanoContas = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_GrupoPlanoContas = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_Financiamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_HistoricoIndicacao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCadastro_Financeiro_Voucher = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_Agendar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_ConsultaAgendamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_ConsultarPaciente = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_ConsultaAtendimentosRealizados = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_Execucao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_Separador01 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuAgendamento_Precos = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_Precos_Profissional = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_Orcamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_Separador02 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_ConsultaSolicitacaoExamesCitologicos = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_Separador03 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuAgendamento_ConsultaOcupacaoTempoPrevisto = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_ConsultaOcupacaoConsultorio = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_ConsultaDiaAbestencao = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAgendamento_ConsultaExamePrescrito = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuMedico = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuMedico_Atendimento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuMedico_Financeiro = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuMedico_MinhasFaturas = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuMedico_ConsultaSolicitacaoExamesCitologicos = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuVenda = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuVenda_ConsultaVendasRealizadas = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuVenda_VendaPendente = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuVenda_Fechamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuVenda_AprovacaoFechamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuVenda_ConferenciaFechamento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuVenda_ConsultaVendasMaster = New System.Windows.Forms.ToolStripMenuItem()
    Me.stbRodape = New System.Windows.Forms.StatusStrip()
    Me.sttEmpresa = New System.Windows.Forms.ToolStripStatusLabel()
    Me.sttUsuario = New System.Windows.Forms.ToolStripStatusLabel()
    Me.sttStatus = New System.Windows.Forms.ToolStripStatusLabel()
    Me.sttVersao = New System.Windows.Forms.ToolStripStatusLabel()
    Me.sttServidor = New System.Windows.Forms.ToolStripStatusLabel()
    Me.stbSenha = New System.Windows.Forms.StatusStrip()
    Me.ddbSenha_ContaCaixa = New System.Windows.Forms.ToolStripDropDownButton()
    Me.ddbSenha_ContaCaixaSelecionada = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ddbSenha_UltimaSenhaGerada = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ddbSenha_UltimaSenhaChamada = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ddbSenha_ContaCaixa_ChamarSenha = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuCadastro_Clinica_CaixaAtendimento = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGeral.SuspendLayout()
        Me.stbRodape.SuspendLayout()
        Me.stbSenha.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuGeral
        '
        Me.mnuGeral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro, Me.mnuFinanceiro, Me.mnuAgendamento, Me.mnuMedico, Me.mnuVenda})
        Me.mnuGeral.Location = New System.Drawing.Point(0, 0)
        Me.mnuGeral.Name = "mnuGeral"
        Me.mnuGeral.Size = New System.Drawing.Size(1083, 24)
        Me.mnuGeral.TabIndex = 5
        '
        'mnuCadastro
        '
        Me.mnuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro_Pessoa, Me.mnuCadastro_Clinica, Me.mnuCadastro_Tipo, Me.mnuCadastro_Separador01, Me.mnuCadastro_Usuario, Me.mnuCadastro_Separador02, Me.mnuCadastro_Seguranca})
        Me.mnuCadastro.Name = "mnuCadastro"
        Me.mnuCadastro.Size = New System.Drawing.Size(66, 20)
        Me.mnuCadastro.Tag = "0"
        Me.mnuCadastro.Text = "Cadastro"
        '
        'mnuCadastro_Pessoa
        '
        Me.mnuCadastro_Pessoa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro_Pessoa_FisicaJuridica, Me.mnuCadastro_Pessoa_Profissao, Me.mnuCadastro_Pessoa_Funcao, Me.mnuCadastro_Pessoa_ConselhoProfissional, Me.mnuCadastro_Pessoa_Empresa, Me.mnuCadastro_Pessoa_Cidade, Me.mnuCadastro_Pessoa_UF, Me.mnuCadastro_Pessoa_Pais})
        Me.mnuCadastro_Pessoa.Name = "mnuCadastro_Pessoa"
        Me.mnuCadastro_Pessoa.Size = New System.Drawing.Size(180, 22)
        Me.mnuCadastro_Pessoa.Tag = "0"
        Me.mnuCadastro_Pessoa.Text = "Pessoa"
        '
        'mnuCadastro_Pessoa_FisicaJuridica
        '
        Me.mnuCadastro_Pessoa_FisicaJuridica.Name = "mnuCadastro_Pessoa_FisicaJuridica"
        Me.mnuCadastro_Pessoa_FisicaJuridica.Size = New System.Drawing.Size(195, 22)
        Me.mnuCadastro_Pessoa_FisicaJuridica.Tag = "1"
        Me.mnuCadastro_Pessoa_FisicaJuridica.Text = "Pessoa (Física/Jurídica)"
        '
        'mnuCadastro_Pessoa_Profissao
        '
        Me.mnuCadastro_Pessoa_Profissao.Name = "mnuCadastro_Pessoa_Profissao"
        Me.mnuCadastro_Pessoa_Profissao.Size = New System.Drawing.Size(195, 22)
        Me.mnuCadastro_Pessoa_Profissao.Tag = "2"
        Me.mnuCadastro_Pessoa_Profissao.Text = "Profissão"
        '
        'mnuCadastro_Pessoa_Funcao
        '
        Me.mnuCadastro_Pessoa_Funcao.Name = "mnuCadastro_Pessoa_Funcao"
        Me.mnuCadastro_Pessoa_Funcao.Size = New System.Drawing.Size(195, 22)
        Me.mnuCadastro_Pessoa_Funcao.Tag = "3"
        Me.mnuCadastro_Pessoa_Funcao.Text = "Função"
        '
        'mnuCadastro_Pessoa_ConselhoProfissional
        '
        Me.mnuCadastro_Pessoa_ConselhoProfissional.Name = "mnuCadastro_Pessoa_ConselhoProfissional"
        Me.mnuCadastro_Pessoa_ConselhoProfissional.Size = New System.Drawing.Size(195, 22)
        Me.mnuCadastro_Pessoa_ConselhoProfissional.Tag = "4"
        Me.mnuCadastro_Pessoa_ConselhoProfissional.Text = "Conselho Profissional"
        '
        'mnuCadastro_Pessoa_Empresa
        '
        Me.mnuCadastro_Pessoa_Empresa.Name = "mnuCadastro_Pessoa_Empresa"
        Me.mnuCadastro_Pessoa_Empresa.Size = New System.Drawing.Size(195, 22)
        Me.mnuCadastro_Pessoa_Empresa.Tag = "5"
        Me.mnuCadastro_Pessoa_Empresa.Text = "Empresa"
        '
        'mnuCadastro_Pessoa_Cidade
        '
        Me.mnuCadastro_Pessoa_Cidade.Name = "mnuCadastro_Pessoa_Cidade"
        Me.mnuCadastro_Pessoa_Cidade.Size = New System.Drawing.Size(195, 22)
        Me.mnuCadastro_Pessoa_Cidade.Tag = "6"
        Me.mnuCadastro_Pessoa_Cidade.Text = "Cidade"
        '
        'mnuCadastro_Pessoa_UF
        '
        Me.mnuCadastro_Pessoa_UF.Name = "mnuCadastro_Pessoa_UF"
        Me.mnuCadastro_Pessoa_UF.Size = New System.Drawing.Size(195, 22)
        Me.mnuCadastro_Pessoa_UF.Tag = "7"
        Me.mnuCadastro_Pessoa_UF.Text = "U.F."
        '
        'mnuCadastro_Pessoa_Pais
        '
        Me.mnuCadastro_Pessoa_Pais.Name = "mnuCadastro_Pessoa_Pais"
        Me.mnuCadastro_Pessoa_Pais.Size = New System.Drawing.Size(195, 22)
        Me.mnuCadastro_Pessoa_Pais.Tag = "8"
        Me.mnuCadastro_Pessoa_Pais.Text = "País"
        '
        'mnuCadastro_Clinica
        '
        Me.mnuCadastro_Clinica.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro_Clinica_Especialidade, Me.mnuCadastro_Clinica_GrupoProcedimento, Me.mnuCadastro_Clinica_Procedimento, Me.mnuCadastro_Clinica_CadastrarHorarioProfissional, Me.mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio, Me.mnuCadastro_Clinica_Configuracao, Me.mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames, Me.mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames, Me.mnuCadastro_Clinica_Convenio, Me.mnuCadastro_Clinica_Vacina, Me.mnuCadastro_Clinica_Consultorio, Me.mnuCadastro_Clinica_Turno, Me.mnuCadastro_Clinica_ClassificacaoExame, Me.mnuCadastro_Clinica_TipoIndicador, Me.mnuCadastro_Clinica_CanalMarcacao, Me.mnuCadastro_Clinica_CaixaAtendimento})
        Me.mnuCadastro_Clinica.Name = "mnuCadastro_Clinica"
        Me.mnuCadastro_Clinica.Size = New System.Drawing.Size(180, 22)
        Me.mnuCadastro_Clinica.Tag = "0"
        Me.mnuCadastro_Clinica.Text = "Clínica"
        '
        'mnuCadastro_Clinica_Especialidade
        '
        Me.mnuCadastro_Clinica_Especialidade.Name = "mnuCadastro_Clinica_Especialidade"
        Me.mnuCadastro_Clinica_Especialidade.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_Especialidade.Tag = "9"
        Me.mnuCadastro_Clinica_Especialidade.Text = "Especialidade"
        '
        'mnuCadastro_Clinica_GrupoProcedimento
        '
        Me.mnuCadastro_Clinica_GrupoProcedimento.Name = "mnuCadastro_Clinica_GrupoProcedimento"
        Me.mnuCadastro_Clinica_GrupoProcedimento.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_GrupoProcedimento.Tag = "10"
        Me.mnuCadastro_Clinica_GrupoProcedimento.Text = "Grupo de Procedimento"
        '
        'mnuCadastro_Clinica_Procedimento
        '
        Me.mnuCadastro_Clinica_Procedimento.Name = "mnuCadastro_Clinica_Procedimento"
        Me.mnuCadastro_Clinica_Procedimento.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_Procedimento.Tag = "11"
        Me.mnuCadastro_Clinica_Procedimento.Text = "Procedimento"
        '
        'mnuCadastro_Clinica_CadastrarHorarioProfissional
        '
        Me.mnuCadastro_Clinica_CadastrarHorarioProfissional.Name = "mnuCadastro_Clinica_CadastrarHorarioProfissional"
        Me.mnuCadastro_Clinica_CadastrarHorarioProfissional.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_CadastrarHorarioProfissional.Tag = "12"
        Me.mnuCadastro_Clinica_CadastrarHorarioProfissional.Text = "Cadastrar horário de profissional"
        '
        'mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio
        '
        Me.mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio.Name = "mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio"
        Me.mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio.Tag = "66"
        Me.mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio.Text = "Cadastrar horário de profissional - Bloqueio"
        '
        'mnuCadastro_Clinica_Configuracao
        '
        Me.mnuCadastro_Clinica_Configuracao.Name = "mnuCadastro_Clinica_Configuracao"
        Me.mnuCadastro_Clinica_Configuracao.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_Configuracao.Tag = "13"
        Me.mnuCadastro_Clinica_Configuracao.Text = "Configuração"
        '
        'mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames
        '
        Me.mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames.Name = "mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames"
        Me.mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames.Tag = "14"
        Me.mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames.Text = "Cadastrar preço de procedimentos e exames"
        '
        'mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames
        '
        Me.mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames.Name = "mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames"
        Me.mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames.Tag = "15"
        Me.mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames.Text = "Manutenção de preço de procedimentos e exames"
        '
        'mnuCadastro_Clinica_Convenio
        '
        Me.mnuCadastro_Clinica_Convenio.Name = "mnuCadastro_Clinica_Convenio"
        Me.mnuCadastro_Clinica_Convenio.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_Convenio.Tag = "16"
        Me.mnuCadastro_Clinica_Convenio.Text = "Convênio"
        '
        'mnuCadastro_Clinica_Vacina
        '
        Me.mnuCadastro_Clinica_Vacina.Name = "mnuCadastro_Clinica_Vacina"
        Me.mnuCadastro_Clinica_Vacina.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_Vacina.Tag = "17"
        Me.mnuCadastro_Clinica_Vacina.Text = "Vacina"
        '
        'mnuCadastro_Clinica_Consultorio
        '
        Me.mnuCadastro_Clinica_Consultorio.Name = "mnuCadastro_Clinica_Consultorio"
        Me.mnuCadastro_Clinica_Consultorio.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_Consultorio.Tag = "18"
        Me.mnuCadastro_Clinica_Consultorio.Text = "Consultório"
        '
        'mnuCadastro_Clinica_Turno
        '
        Me.mnuCadastro_Clinica_Turno.Name = "mnuCadastro_Clinica_Turno"
        Me.mnuCadastro_Clinica_Turno.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_Turno.Tag = "63"
        Me.mnuCadastro_Clinica_Turno.Text = "Turno"
        '
        'mnuCadastro_Clinica_ClassificacaoExame
        '
        Me.mnuCadastro_Clinica_ClassificacaoExame.Name = "mnuCadastro_Clinica_ClassificacaoExame"
        Me.mnuCadastro_Clinica_ClassificacaoExame.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_ClassificacaoExame.Tag = "64"
        Me.mnuCadastro_Clinica_ClassificacaoExame.Text = "Classificação de Exame"
        '
        'mnuCadastro_Clinica_TipoIndicador
        '
        Me.mnuCadastro_Clinica_TipoIndicador.Name = "mnuCadastro_Clinica_TipoIndicador"
        Me.mnuCadastro_Clinica_TipoIndicador.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_TipoIndicador.Tag = "67"
        Me.mnuCadastro_Clinica_TipoIndicador.Text = "Tipo de Indicador"
        '
        'mnuCadastro_Clinica_CanalMarcacao
        '
        Me.mnuCadastro_Clinica_CanalMarcacao.Name = "mnuCadastro_Clinica_CanalMarcacao"
        Me.mnuCadastro_Clinica_CanalMarcacao.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_CanalMarcacao.Tag = "69"
        Me.mnuCadastro_Clinica_CanalMarcacao.Text = "Canal de Marcação"
        '
        'mnuCadastro_Tipo
        '
        Me.mnuCadastro_Tipo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro_Tipo_TipoCargo, Me.mnuCadastro_Tipo_TipoConsulta, Me.mnuCadastro_Tipo_TipoDocumentoFinanceiro, Me.mnuCadastro_Tipo_TipoEndereco, Me.mnuCadastro_Tipo_TipoEscolaridade, Me.mnuCadastro_Tipo_TipoEstadoCivil, Me.mnuCadastro_Tipo_TipoMidiaSocial, Me.mnuCadastro_Tipo_TipoPaciente, Me.mnuCadastro_Tipo_TipoPessoa, Me.mnuCadastro_Tipo_TipoRaca, Me.mnuCadastro_Tipo_TipoRelatorio, Me.mnuCadastro_Tipo_TipoReferencialPessoal, Me.mnuCadastro_Tipo_TipoRelegiao, Me.TipoDeSexoToolStripMenuItem})
        Me.mnuCadastro_Tipo.Name = "mnuCadastro_Tipo"
        Me.mnuCadastro_Tipo.Size = New System.Drawing.Size(180, 22)
        Me.mnuCadastro_Tipo.Tag = "0"
        Me.mnuCadastro_Tipo.Text = "Tipos"
        '
        'mnuCadastro_Tipo_TipoCargo
        '
        Me.mnuCadastro_Tipo_TipoCargo.Name = "mnuCadastro_Tipo_TipoCargo"
        Me.mnuCadastro_Tipo_TipoCargo.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoCargo.Tag = "19"
        Me.mnuCadastro_Tipo_TipoCargo.Text = "Tipo de Cargo"
        '
        'mnuCadastro_Tipo_TipoConsulta
        '
        Me.mnuCadastro_Tipo_TipoConsulta.Name = "mnuCadastro_Tipo_TipoConsulta"
        Me.mnuCadastro_Tipo_TipoConsulta.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoConsulta.Tag = "20"
        Me.mnuCadastro_Tipo_TipoConsulta.Text = "Tipo de Consulta"
        '
        'mnuCadastro_Tipo_TipoDocumentoFinanceiro
        '
        Me.mnuCadastro_Tipo_TipoDocumentoFinanceiro.Name = "mnuCadastro_Tipo_TipoDocumentoFinanceiro"
        Me.mnuCadastro_Tipo_TipoDocumentoFinanceiro.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoDocumentoFinanceiro.Tag = "21"
        Me.mnuCadastro_Tipo_TipoDocumentoFinanceiro.Text = "Tipo de Documento Financeiro"
        '
        'mnuCadastro_Tipo_TipoEndereco
        '
        Me.mnuCadastro_Tipo_TipoEndereco.Name = "mnuCadastro_Tipo_TipoEndereco"
        Me.mnuCadastro_Tipo_TipoEndereco.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoEndereco.Tag = "22"
        Me.mnuCadastro_Tipo_TipoEndereco.Text = "Tipo de Endereço"
        '
        'mnuCadastro_Tipo_TipoEscolaridade
        '
        Me.mnuCadastro_Tipo_TipoEscolaridade.Name = "mnuCadastro_Tipo_TipoEscolaridade"
        Me.mnuCadastro_Tipo_TipoEscolaridade.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoEscolaridade.Tag = "23"
        Me.mnuCadastro_Tipo_TipoEscolaridade.Text = "Tipo de Escolaridade"
        '
        'mnuCadastro_Tipo_TipoEstadoCivil
        '
        Me.mnuCadastro_Tipo_TipoEstadoCivil.Name = "mnuCadastro_Tipo_TipoEstadoCivil"
        Me.mnuCadastro_Tipo_TipoEstadoCivil.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoEstadoCivil.Tag = "24"
        Me.mnuCadastro_Tipo_TipoEstadoCivil.Text = "Tipo de Estado Civíl"
        '
        'mnuCadastro_Tipo_TipoMidiaSocial
        '
        Me.mnuCadastro_Tipo_TipoMidiaSocial.Name = "mnuCadastro_Tipo_TipoMidiaSocial"
        Me.mnuCadastro_Tipo_TipoMidiaSocial.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoMidiaSocial.Tag = "25"
        Me.mnuCadastro_Tipo_TipoMidiaSocial.Text = "Tipo de Mídia Social"
        '
        'mnuCadastro_Tipo_TipoPaciente
        '
        Me.mnuCadastro_Tipo_TipoPaciente.Name = "mnuCadastro_Tipo_TipoPaciente"
        Me.mnuCadastro_Tipo_TipoPaciente.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoPaciente.Tag = "26"
        Me.mnuCadastro_Tipo_TipoPaciente.Text = "Tipo de Paciente"
        '
        'mnuCadastro_Tipo_TipoPessoa
        '
        Me.mnuCadastro_Tipo_TipoPessoa.Name = "mnuCadastro_Tipo_TipoPessoa"
        Me.mnuCadastro_Tipo_TipoPessoa.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoPessoa.Tag = "27"
        Me.mnuCadastro_Tipo_TipoPessoa.Text = "Tipo de Pessoa"
        '
        'mnuCadastro_Tipo_TipoRaca
        '
        Me.mnuCadastro_Tipo_TipoRaca.Name = "mnuCadastro_Tipo_TipoRaca"
        Me.mnuCadastro_Tipo_TipoRaca.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoRaca.Tag = "28"
        Me.mnuCadastro_Tipo_TipoRaca.Text = "Tipo de Raça"
        '
        'mnuCadastro_Tipo_TipoRelatorio
        '
        Me.mnuCadastro_Tipo_TipoRelatorio.Name = "mnuCadastro_Tipo_TipoRelatorio"
        Me.mnuCadastro_Tipo_TipoRelatorio.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoRelatorio.Tag = "70"
        Me.mnuCadastro_Tipo_TipoRelatorio.Text = "Tipo de Relatório"
        '
        'mnuCadastro_Tipo_TipoReferencialPessoal
        '
        Me.mnuCadastro_Tipo_TipoReferencialPessoal.Name = "mnuCadastro_Tipo_TipoReferencialPessoal"
        Me.mnuCadastro_Tipo_TipoReferencialPessoal.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoReferencialPessoal.Tag = "29"
        Me.mnuCadastro_Tipo_TipoReferencialPessoal.Text = "Tipo de Referência Pessoal"
        '
        'mnuCadastro_Tipo_TipoRelegiao
        '
        Me.mnuCadastro_Tipo_TipoRelegiao.Name = "mnuCadastro_Tipo_TipoRelegiao"
        Me.mnuCadastro_Tipo_TipoRelegiao.ShowShortcutKeys = False
        Me.mnuCadastro_Tipo_TipoRelegiao.Size = New System.Drawing.Size(237, 22)
        Me.mnuCadastro_Tipo_TipoRelegiao.Tag = "30"
        Me.mnuCadastro_Tipo_TipoRelegiao.Text = "Tipo de Religião"
        '
        'TipoDeSexoToolStripMenuItem
        '
        Me.TipoDeSexoToolStripMenuItem.Name = "TipoDeSexoToolStripMenuItem"
        Me.TipoDeSexoToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.TipoDeSexoToolStripMenuItem.Tag = "61"
        Me.TipoDeSexoToolStripMenuItem.Text = "Tipo de Sexo"
        '
        'mnuCadastro_Separador01
        '
        Me.mnuCadastro_Separador01.Name = "mnuCadastro_Separador01"
        Me.mnuCadastro_Separador01.Size = New System.Drawing.Size(177, 6)
        '
        'mnuCadastro_Usuario
        '
        Me.mnuCadastro_Usuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro_Usuario_Configuracao, Me.mnuCadastro_Usuario_AlterarSenha})
        Me.mnuCadastro_Usuario.Name = "mnuCadastro_Usuario"
        Me.mnuCadastro_Usuario.Size = New System.Drawing.Size(180, 22)
        Me.mnuCadastro_Usuario.Tag = "0"
        Me.mnuCadastro_Usuario.Text = "Usuário"
        '
        'mnuCadastro_Usuario_Configuracao
        '
        Me.mnuCadastro_Usuario_Configuracao.Name = "mnuCadastro_Usuario_Configuracao"
        Me.mnuCadastro_Usuario_Configuracao.Size = New System.Drawing.Size(146, 22)
        Me.mnuCadastro_Usuario_Configuracao.Tag = "0"
        Me.mnuCadastro_Usuario_Configuracao.Text = "Configuração"
        '
        'mnuCadastro_Usuario_AlterarSenha
        '
        Me.mnuCadastro_Usuario_AlterarSenha.Name = "mnuCadastro_Usuario_AlterarSenha"
        Me.mnuCadastro_Usuario_AlterarSenha.Size = New System.Drawing.Size(146, 22)
        Me.mnuCadastro_Usuario_AlterarSenha.Tag = "0"
        Me.mnuCadastro_Usuario_AlterarSenha.Text = "Alterar Senha"
        '
        'mnuCadastro_Separador02
        '
        Me.mnuCadastro_Separador02.Name = "mnuCadastro_Separador02"
        Me.mnuCadastro_Separador02.Size = New System.Drawing.Size(177, 6)
        '
        'mnuCadastro_Seguranca
        '
        Me.mnuCadastro_Seguranca.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro_Seguranca_GrupoPermissao, Me.mnuCadastro_Seguranca_Permissao})
        Me.mnuCadastro_Seguranca.Name = "mnuCadastro_Seguranca"
        Me.mnuCadastro_Seguranca.Size = New System.Drawing.Size(180, 22)
        Me.mnuCadastro_Seguranca.Tag = "0"
        Me.mnuCadastro_Seguranca.Text = "Segurança"
        '
        'mnuCadastro_Seguranca_GrupoPermissao
        '
        Me.mnuCadastro_Seguranca_GrupoPermissao.Name = "mnuCadastro_Seguranca_GrupoPermissao"
        Me.mnuCadastro_Seguranca_GrupoPermissao.Size = New System.Drawing.Size(185, 22)
        Me.mnuCadastro_Seguranca_GrupoPermissao.Tag = "59"
        Me.mnuCadastro_Seguranca_GrupoPermissao.Text = "Grupo de Permissões"
        '
        'mnuCadastro_Seguranca_Permissao
        '
        Me.mnuCadastro_Seguranca_Permissao.Name = "mnuCadastro_Seguranca_Permissao"
        Me.mnuCadastro_Seguranca_Permissao.Size = New System.Drawing.Size(185, 22)
        Me.mnuCadastro_Seguranca_Permissao.Tag = "60"
        Me.mnuCadastro_Seguranca_Permissao.Text = "Permissões"
        '
        'mnuFinanceiro
        '
        Me.mnuFinanceiro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro_Financeiro_ContasReceber, Me.mnuCadastro_Financeiro_ContasPagar, Me.mnuCadastro_Financeiro_FluxoCaixa, Me.mnuCadastro_Financeiro_Separador01, Me.mnuCadastro_Financeiro_ConsultaContasReceber, Me.mnuCadastro_Financeiro_ConsultaContasPagar, Me.mnuCadastro_Financeiro_ConsultaFluxoCaixa, Me.mnuCadastro_Financeiro_Separador02, Me.mnuCadastro_Financeiro_Compensacao, Me.mnuCadastro_Financeiro_Separador03, Me.mnuCadastro_Financeiro_ConsultaDeFluxoCaixa, Me.mnuCadastro_Financeiro_Separador04, Me.mnuCadastro_Financeiro_FaturamentoVenda, Me.mnuCadastro_Financeiro_CondicaoPagamento, Me.mnuCadastro_Financeiro_Banco, Me.mnuCadastro_Financeiro_ContaBancaria, Me.mnuCadastro_Financeiro_ContaCaixa, Me.mnuCadastro_Financeiro_FormaPagamento, Me.mnuCadastro_Financeiro_PlanoContas, Me.mnuCadastro_Financeiro_GrupoPlanoContas, Me.mnuCadastro_Financeiro_Financiamento, Me.mnuCadastro_Financeiro_HistoricoIndicacao, Me.mnuCadastro_Financeiro_Voucher})
        Me.mnuFinanceiro.Name = "mnuFinanceiro"
        Me.mnuFinanceiro.Size = New System.Drawing.Size(74, 20)
        Me.mnuFinanceiro.Tag = "0"
        Me.mnuFinanceiro.Text = "Financeiro"
        '
        'mnuCadastro_Financeiro_ContasReceber
        '
        Me.mnuCadastro_Financeiro_ContasReceber.Name = "mnuCadastro_Financeiro_ContasReceber"
        Me.mnuCadastro_Financeiro_ContasReceber.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_ContasReceber.Tag = "31"
        Me.mnuCadastro_Financeiro_ContasReceber.Text = "Lançamento de Contas a Receber"
        '
        'mnuCadastro_Financeiro_ContasPagar
        '
        Me.mnuCadastro_Financeiro_ContasPagar.Name = "mnuCadastro_Financeiro_ContasPagar"
        Me.mnuCadastro_Financeiro_ContasPagar.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_ContasPagar.Tag = "32"
        Me.mnuCadastro_Financeiro_ContasPagar.Text = "Lançamento de Contas a Pagar"
        '
        'mnuCadastro_Financeiro_FluxoCaixa
        '
        Me.mnuCadastro_Financeiro_FluxoCaixa.Name = "mnuCadastro_Financeiro_FluxoCaixa"
        Me.mnuCadastro_Financeiro_FluxoCaixa.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_FluxoCaixa.Tag = "33"
        Me.mnuCadastro_Financeiro_FluxoCaixa.Text = "Lançamento em Conta Caixa/Conta Bancária"
        '
        'mnuCadastro_Financeiro_Separador01
        '
        Me.mnuCadastro_Financeiro_Separador01.Name = "mnuCadastro_Financeiro_Separador01"
        Me.mnuCadastro_Financeiro_Separador01.Size = New System.Drawing.Size(375, 6)
        '
        'mnuCadastro_Financeiro_ConsultaContasReceber
        '
        Me.mnuCadastro_Financeiro_ConsultaContasReceber.Name = "mnuCadastro_Financeiro_ConsultaContasReceber"
        Me.mnuCadastro_Financeiro_ConsultaContasReceber.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_ConsultaContasReceber.Tag = "34"
        Me.mnuCadastro_Financeiro_ConsultaContasReceber.Text = "Consulta de Contas a Receber"
        '
        'mnuCadastro_Financeiro_ConsultaContasPagar
        '
        Me.mnuCadastro_Financeiro_ConsultaContasPagar.Name = "mnuCadastro_Financeiro_ConsultaContasPagar"
        Me.mnuCadastro_Financeiro_ConsultaContasPagar.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_ConsultaContasPagar.Tag = "35"
        Me.mnuCadastro_Financeiro_ConsultaContasPagar.Text = "Consulta de Contas a Pagar"
        '
        'mnuCadastro_Financeiro_ConsultaFluxoCaixa
        '
        Me.mnuCadastro_Financeiro_ConsultaFluxoCaixa.Name = "mnuCadastro_Financeiro_ConsultaFluxoCaixa"
        Me.mnuCadastro_Financeiro_ConsultaFluxoCaixa.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_ConsultaFluxoCaixa.Tag = "36"
        Me.mnuCadastro_Financeiro_ConsultaFluxoCaixa.Text = "Consulta de Lançamento em Conta Caixa/Conta Bancária"
        '
        'mnuCadastro_Financeiro_Separador02
        '
        Me.mnuCadastro_Financeiro_Separador02.Name = "mnuCadastro_Financeiro_Separador02"
        Me.mnuCadastro_Financeiro_Separador02.Size = New System.Drawing.Size(375, 6)
        '
        'mnuCadastro_Financeiro_Compensacao
        '
        Me.mnuCadastro_Financeiro_Compensacao.Name = "mnuCadastro_Financeiro_Compensacao"
        Me.mnuCadastro_Financeiro_Compensacao.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_Compensacao.Tag = "37"
        Me.mnuCadastro_Financeiro_Compensacao.Text = "Compensação"
        '
        'mnuCadastro_Financeiro_Separador03
        '
        Me.mnuCadastro_Financeiro_Separador03.Name = "mnuCadastro_Financeiro_Separador03"
        Me.mnuCadastro_Financeiro_Separador03.Size = New System.Drawing.Size(375, 6)
        '
        'mnuCadastro_Financeiro_ConsultaDeFluxoCaixa
        '
        Me.mnuCadastro_Financeiro_ConsultaDeFluxoCaixa.Name = "mnuCadastro_Financeiro_ConsultaDeFluxoCaixa"
        Me.mnuCadastro_Financeiro_ConsultaDeFluxoCaixa.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_ConsultaDeFluxoCaixa.Tag = "38"
        Me.mnuCadastro_Financeiro_ConsultaDeFluxoCaixa.Text = "Consulta de Fluxo de Caixa"
        '
        'mnuCadastro_Financeiro_Separador04
        '
        Me.mnuCadastro_Financeiro_Separador04.Name = "mnuCadastro_Financeiro_Separador04"
        Me.mnuCadastro_Financeiro_Separador04.Size = New System.Drawing.Size(375, 6)
        '
        'mnuCadastro_Financeiro_FaturamentoVenda
        '
        Me.mnuCadastro_Financeiro_FaturamentoVenda.Name = "mnuCadastro_Financeiro_FaturamentoVenda"
        Me.mnuCadastro_Financeiro_FaturamentoVenda.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_FaturamentoVenda.Tag = "39"
        Me.mnuCadastro_Financeiro_FaturamentoVenda.Text = "Faturamento de Vendas"
        '
        'mnuCadastro_Financeiro_CondicaoPagamento
        '
        Me.mnuCadastro_Financeiro_CondicaoPagamento.Name = "mnuCadastro_Financeiro_CondicaoPagamento"
        Me.mnuCadastro_Financeiro_CondicaoPagamento.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_CondicaoPagamento.Tag = "40"
        Me.mnuCadastro_Financeiro_CondicaoPagamento.Text = "Condição de Pagamento"
        '
        'mnuCadastro_Financeiro_Banco
        '
        Me.mnuCadastro_Financeiro_Banco.Name = "mnuCadastro_Financeiro_Banco"
        Me.mnuCadastro_Financeiro_Banco.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_Banco.Tag = "61"
        Me.mnuCadastro_Financeiro_Banco.Text = "Banco"
        '
        'mnuCadastro_Financeiro_ContaBancaria
        '
        Me.mnuCadastro_Financeiro_ContaBancaria.Name = "mnuCadastro_Financeiro_ContaBancaria"
        Me.mnuCadastro_Financeiro_ContaBancaria.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_ContaBancaria.Tag = "41"
        Me.mnuCadastro_Financeiro_ContaBancaria.Text = "Conta Bancária"
        '
        'mnuCadastro_Financeiro_ContaCaixa
        '
        Me.mnuCadastro_Financeiro_ContaCaixa.Name = "mnuCadastro_Financeiro_ContaCaixa"
        Me.mnuCadastro_Financeiro_ContaCaixa.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_ContaCaixa.Tag = "42"
        Me.mnuCadastro_Financeiro_ContaCaixa.Text = "Conta Caixa"
        '
        'mnuCadastro_Financeiro_FormaPagamento
        '
        Me.mnuCadastro_Financeiro_FormaPagamento.Name = "mnuCadastro_Financeiro_FormaPagamento"
        Me.mnuCadastro_Financeiro_FormaPagamento.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_FormaPagamento.Tag = "43"
        Me.mnuCadastro_Financeiro_FormaPagamento.Text = "Forma de Pagamento"
        '
        'mnuCadastro_Financeiro_PlanoContas
        '
        Me.mnuCadastro_Financeiro_PlanoContas.Name = "mnuCadastro_Financeiro_PlanoContas"
        Me.mnuCadastro_Financeiro_PlanoContas.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_PlanoContas.Tag = "44"
        Me.mnuCadastro_Financeiro_PlanoContas.Text = "Plano de Contas"
        '
        'mnuCadastro_Financeiro_GrupoPlanoContas
        '
        Me.mnuCadastro_Financeiro_GrupoPlanoContas.Name = "mnuCadastro_Financeiro_GrupoPlanoContas"
        Me.mnuCadastro_Financeiro_GrupoPlanoContas.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_GrupoPlanoContas.Tag = "45"
        Me.mnuCadastro_Financeiro_GrupoPlanoContas.Text = "Grupo de Plano de Contas"
        '
        'mnuCadastro_Financeiro_Financiamento
        '
        Me.mnuCadastro_Financeiro_Financiamento.Name = "mnuCadastro_Financeiro_Financiamento"
        Me.mnuCadastro_Financeiro_Financiamento.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_Financiamento.Tag = "46"
        Me.mnuCadastro_Financeiro_Financiamento.Text = "Financiamento"
        '
        'mnuCadastro_Financeiro_HistoricoIndicacao
        '
        Me.mnuCadastro_Financeiro_HistoricoIndicacao.Name = "mnuCadastro_Financeiro_HistoricoIndicacao"
        Me.mnuCadastro_Financeiro_HistoricoIndicacao.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_HistoricoIndicacao.Tag = "71"
        Me.mnuCadastro_Financeiro_HistoricoIndicacao.Text = "Histórico de Indicação"
        '
        'mnuCadastro_Financeiro_Voucher
        '
        Me.mnuCadastro_Financeiro_Voucher.Name = "mnuCadastro_Financeiro_Voucher"
        Me.mnuCadastro_Financeiro_Voucher.ShowShortcutKeys = False
        Me.mnuCadastro_Financeiro_Voucher.Size = New System.Drawing.Size(378, 22)
        Me.mnuCadastro_Financeiro_Voucher.Tag = "0"
        Me.mnuCadastro_Financeiro_Voucher.Text = "Voucher"
        '
        'mnuAgendamento
        '
        Me.mnuAgendamento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAgendamento_Agendar, Me.mnuAgendamento_ConsultaAgendamento, Me.mnuAgendamento_ConsultarPaciente, Me.mnuAgendamento_ConsultaAtendimentosRealizados, Me.mnuAgendamento_Execucao, Me.mnuAgendamento_Separador01, Me.mnuAgendamento_Precos, Me.mnuAgendamento_Precos_Profissional, Me.mnuAgendamento_Orcamento, Me.mnuAgendamento_Separador02, Me.mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos, Me.mnuAgendamento_ConsultaSolicitacaoExamesCitologicos, Me.mnuAgendamento_Separador03, Me.mnuAgendamento_ConsultaOcupacaoTempoPrevisto, Me.mnuAgendamento_ConsultaOcupacaoConsultorio, Me.mnuAgendamento_ConsultaDiaAbestencao, Me.mnuAgendamento_ConsultaExamePrescrito})
        Me.mnuAgendamento.Name = "mnuAgendamento"
        Me.mnuAgendamento.Size = New System.Drawing.Size(95, 20)
        Me.mnuAgendamento.Tag = "0"
        Me.mnuAgendamento.Text = "Agendamento"
        '
        'mnuAgendamento_Agendar
        '
        Me.mnuAgendamento_Agendar.Name = "mnuAgendamento_Agendar"
        Me.mnuAgendamento_Agendar.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_Agendar.Tag = "47"
        Me.mnuAgendamento_Agendar.Text = "Agendar"
        '
        'mnuAgendamento_ConsultaAgendamento
        '
        Me.mnuAgendamento_ConsultaAgendamento.Name = "mnuAgendamento_ConsultaAgendamento"
        Me.mnuAgendamento_ConsultaAgendamento.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultaAgendamento.Tag = "47"
        Me.mnuAgendamento_ConsultaAgendamento.Text = "Consulta de Agendamento"
        '
        'mnuAgendamento_ConsultarPaciente
        '
        Me.mnuAgendamento_ConsultarPaciente.Name = "mnuAgendamento_ConsultarPaciente"
        Me.mnuAgendamento_ConsultarPaciente.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultarPaciente.Tag = "48"
        Me.mnuAgendamento_ConsultarPaciente.Text = "Consulta de Paciente"
        '
        'mnuAgendamento_ConsultaAtendimentosRealizados
        '
        Me.mnuAgendamento_ConsultaAtendimentosRealizados.Name = "mnuAgendamento_ConsultaAtendimentosRealizados"
        Me.mnuAgendamento_ConsultaAtendimentosRealizados.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultaAtendimentosRealizados.Tag = "49"
        Me.mnuAgendamento_ConsultaAtendimentosRealizados.Text = "Consulta de Atendimentos Realizados"
        '
        'mnuAgendamento_Execucao
        '
        Me.mnuAgendamento_Execucao.Name = "mnuAgendamento_Execucao"
        Me.mnuAgendamento_Execucao.ShortcutKeyDisplayString = ""
        Me.mnuAgendamento_Execucao.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_Execucao.Tag = "50"
        Me.mnuAgendamento_Execucao.Text = "Execução"
        '
        'mnuAgendamento_Separador01
        '
        Me.mnuAgendamento_Separador01.Name = "mnuAgendamento_Separador01"
        Me.mnuAgendamento_Separador01.Size = New System.Drawing.Size(391, 6)
        '
        'mnuAgendamento_Precos
        '
        Me.mnuAgendamento_Precos.Name = "mnuAgendamento_Precos"
        Me.mnuAgendamento_Precos.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_Precos.Tag = "51"
        Me.mnuAgendamento_Precos.Text = "Consultar preço de procedimentos e exames"
        '
        'mnuAgendamento_Precos_Profissional
        '
        Me.mnuAgendamento_Precos_Profissional.Name = "mnuAgendamento_Precos_Profissional"
        Me.mnuAgendamento_Precos_Profissional.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_Precos_Profissional.Tag = "51"
        Me.mnuAgendamento_Precos_Profissional.Text = "Consultar preço de procedimentos e exames por profissional"
        '
        'mnuAgendamento_Orcamento
        '
        Me.mnuAgendamento_Orcamento.Name = "mnuAgendamento_Orcamento"
        Me.mnuAgendamento_Orcamento.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_Orcamento.Tag = "52"
        Me.mnuAgendamento_Orcamento.Text = "Orçamento"
        '
        'mnuAgendamento_Separador02
        '
        Me.mnuAgendamento_Separador02.Name = "mnuAgendamento_Separador02"
        Me.mnuAgendamento_Separador02.Size = New System.Drawing.Size(391, 6)
        '
        'mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos
        '
        Me.mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos.Name = "mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos"
        Me.mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos.Tag = "71"
        Me.mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos.Text = "Consulta de Lote de Solicitação de Exames Citológicos"
        '
        'mnuAgendamento_ConsultaSolicitacaoExamesCitologicos
        '
        Me.mnuAgendamento_ConsultaSolicitacaoExamesCitologicos.Name = "mnuAgendamento_ConsultaSolicitacaoExamesCitologicos"
        Me.mnuAgendamento_ConsultaSolicitacaoExamesCitologicos.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultaSolicitacaoExamesCitologicos.Tag = "72"
        Me.mnuAgendamento_ConsultaSolicitacaoExamesCitologicos.Text = "Consulta de Solicitação de Exames Citológicos"
        '
        'mnuAgendamento_Separador03
        '
        Me.mnuAgendamento_Separador03.Name = "mnuAgendamento_Separador03"
        Me.mnuAgendamento_Separador03.Size = New System.Drawing.Size(391, 6)
        '
        'mnuAgendamento_ConsultaOcupacaoTempoPrevisto
        '
        Me.mnuAgendamento_ConsultaOcupacaoTempoPrevisto.Name = "mnuAgendamento_ConsultaOcupacaoTempoPrevisto"
        Me.mnuAgendamento_ConsultaOcupacaoTempoPrevisto.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultaOcupacaoTempoPrevisto.Tag = "0"
        Me.mnuAgendamento_ConsultaOcupacaoTempoPrevisto.Text = "Consulta de Ocupação de Tempo Previsto"
        '
        'mnuAgendamento_ConsultaOcupacaoConsultorio
        '
        Me.mnuAgendamento_ConsultaOcupacaoConsultorio.Name = "mnuAgendamento_ConsultaOcupacaoConsultorio"
        Me.mnuAgendamento_ConsultaOcupacaoConsultorio.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultaOcupacaoConsultorio.Tag = "0"
        Me.mnuAgendamento_ConsultaOcupacaoConsultorio.Text = "Consulta de Ocupação de Consultório"
        '
        'mnuAgendamento_ConsultaDiaAbestencao
        '
        Me.mnuAgendamento_ConsultaDiaAbestencao.Name = "mnuAgendamento_ConsultaDiaAbestencao"
        Me.mnuAgendamento_ConsultaDiaAbestencao.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultaDiaAbestencao.Tag = "0"
        Me.mnuAgendamento_ConsultaDiaAbestencao.Text = "Consulta de Dia de Abestenção"
        '
        'mnuAgendamento_ConsultaExamePrescrito
        '
        Me.mnuAgendamento_ConsultaExamePrescrito.Name = "mnuAgendamento_ConsultaExamePrescrito"
        Me.mnuAgendamento_ConsultaExamePrescrito.Size = New System.Drawing.Size(394, 22)
        Me.mnuAgendamento_ConsultaExamePrescrito.Tag = "0"
        Me.mnuAgendamento_ConsultaExamePrescrito.Text = "Consulta de Exame Prescritos"
        '
        'mnuMedico
        '
        Me.mnuMedico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMedico_Atendimento, Me.mnuMedico_Financeiro, Me.mnuMedico_MinhasFaturas, Me.mnuMedico_ConsultaSolicitacaoExamesCitologicos})
        Me.mnuMedico.Name = "mnuMedico"
        Me.mnuMedico.Size = New System.Drawing.Size(59, 20)
        Me.mnuMedico.Tag = "0"
        Me.mnuMedico.Text = "Médico"
        '
        'mnuMedico_Atendimento
        '
        Me.mnuMedico_Atendimento.Name = "mnuMedico_Atendimento"
        Me.mnuMedico_Atendimento.Size = New System.Drawing.Size(319, 22)
        Me.mnuMedico_Atendimento.Tag = "53"
        Me.mnuMedico_Atendimento.Text = "Atendimento"
        '
        'mnuMedico_Financeiro
        '
        Me.mnuMedico_Financeiro.Name = "mnuMedico_Financeiro"
        Me.mnuMedico_Financeiro.Size = New System.Drawing.Size(319, 22)
        Me.mnuMedico_Financeiro.Tag = "53"
        Me.mnuMedico_Financeiro.Text = "Financeiro"
        '
        'mnuMedico_MinhasFaturas
        '
        Me.mnuMedico_MinhasFaturas.Name = "mnuMedico_MinhasFaturas"
        Me.mnuMedico_MinhasFaturas.Size = New System.Drawing.Size(319, 22)
        Me.mnuMedico_MinhasFaturas.Tag = "53"
        Me.mnuMedico_MinhasFaturas.Text = "Minhas Faturas"
        '
        'mnuMedico_ConsultaSolicitacaoExamesCitologicos
        '
        Me.mnuMedico_ConsultaSolicitacaoExamesCitologicos.Name = "mnuMedico_ConsultaSolicitacaoExamesCitologicos"
        Me.mnuMedico_ConsultaSolicitacaoExamesCitologicos.Size = New System.Drawing.Size(319, 22)
        Me.mnuMedico_ConsultaSolicitacaoExamesCitologicos.Tag = "53"
        Me.mnuMedico_ConsultaSolicitacaoExamesCitologicos.Text = "Consulta de Solicitação de Exames Citológicos"
        '
        'mnuVenda
        '
        Me.mnuVenda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuVenda_ConsultaVendasRealizadas, Me.mnuVenda_VendaPendente, Me.mnuVenda_Fechamento, Me.mnuVenda_AprovacaoFechamento, Me.mnuVenda_ConferenciaFechamento, Me.mnuVenda_ConsultaVendasMaster})
        Me.mnuVenda.Name = "mnuVenda"
        Me.mnuVenda.Size = New System.Drawing.Size(56, 20)
        Me.mnuVenda.Tag = "0"
        Me.mnuVenda.Text = "Vendas"
        '
        'mnuVenda_ConsultaVendasRealizadas
        '
        Me.mnuVenda_ConsultaVendasRealizadas.Name = "mnuVenda_ConsultaVendasRealizadas"
        Me.mnuVenda_ConsultaVendasRealizadas.Size = New System.Drawing.Size(234, 22)
        Me.mnuVenda_ConsultaVendasRealizadas.Tag = "54"
        Me.mnuVenda_ConsultaVendasRealizadas.Text = "Consulta de Vendas Realizadas"
        '
        'mnuVenda_VendaPendente
        '
        Me.mnuVenda_VendaPendente.Name = "mnuVenda_VendaPendente"
        Me.mnuVenda_VendaPendente.Size = New System.Drawing.Size(234, 22)
        Me.mnuVenda_VendaPendente.Tag = "55"
        Me.mnuVenda_VendaPendente.Text = "Vendas Pendentes"
        '
        'mnuVenda_Fechamento
        '
        Me.mnuVenda_Fechamento.Name = "mnuVenda_Fechamento"
        Me.mnuVenda_Fechamento.Size = New System.Drawing.Size(234, 22)
        Me.mnuVenda_Fechamento.Tag = "56"
        Me.mnuVenda_Fechamento.Text = "Fechamento"
        '
        'mnuVenda_AprovacaoFechamento
        '
        Me.mnuVenda_AprovacaoFechamento.Name = "mnuVenda_AprovacaoFechamento"
        Me.mnuVenda_AprovacaoFechamento.Size = New System.Drawing.Size(234, 22)
        Me.mnuVenda_AprovacaoFechamento.Tag = "57"
        Me.mnuVenda_AprovacaoFechamento.Text = "Aprovação de Fechamento"
        '
        'mnuVenda_ConferenciaFechamento
        '
        Me.mnuVenda_ConferenciaFechamento.Name = "mnuVenda_ConferenciaFechamento"
        Me.mnuVenda_ConferenciaFechamento.Size = New System.Drawing.Size(234, 22)
        Me.mnuVenda_ConferenciaFechamento.Tag = "58"
        Me.mnuVenda_ConferenciaFechamento.Text = "Conferência de Fechamento"
        '
        'mnuVenda_ConsultaVendasMaster
        '
        Me.mnuVenda_ConsultaVendasMaster.Name = "mnuVenda_ConsultaVendasMaster"
        Me.mnuVenda_ConsultaVendasMaster.Size = New System.Drawing.Size(234, 22)
        Me.mnuVenda_ConsultaVendasMaster.Tag = "65"
        Me.mnuVenda_ConsultaVendasMaster.Text = "Consulta de Vendas - Master"
        '
        'stbRodape
        '
        Me.stbRodape.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sttEmpresa, Me.sttUsuario, Me.sttStatus, Me.sttVersao, Me.sttServidor})
        Me.stbRodape.Location = New System.Drawing.Point(0, 426)
        Me.stbRodape.Name = "stbRodape"
        Me.stbRodape.ShowItemToolTips = True
        Me.stbRodape.Size = New System.Drawing.Size(1083, 24)
        Me.stbRodape.TabIndex = 8
        '
        'sttEmpresa
        '
        Me.sttEmpresa.AutoSize = False
        Me.sttEmpresa.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sttEmpresa.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.sttEmpresa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sttEmpresa.Name = "sttEmpresa"
        Me.sttEmpresa.Size = New System.Drawing.Size(300, 19)
        Me.sttEmpresa.Text = "Empresa"
        Me.sttEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sttEmpresa.ToolTipText = "Nome da Empresa/Filial"
        '
        'sttUsuario
        '
        Me.sttUsuario.AutoSize = False
        Me.sttUsuario.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sttUsuario.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.sttUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sttUsuario.Name = "sttUsuario"
        Me.sttUsuario.Size = New System.Drawing.Size(741, 19)
        Me.sttUsuario.Spring = True
        Me.sttUsuario.Text = "Usuário"
        Me.sttUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sttUsuario.ToolTipText = "Usuário conectado"
        '
        'sttStatus
        '
        Me.sttStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sttStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sttStatus.Name = "sttStatus"
        Me.sttStatus.Size = New System.Drawing.Size(4, 19)
        '
        'sttVersao
        '
        Me.sttVersao.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sttVersao.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.sttVersao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sttVersao.Name = "sttVersao"
        Me.sttVersao.Size = New System.Drawing.Size(23, 19)
        Me.sttVersao.Text = "00"
        Me.sttVersao.ToolTipText = "Versão do Aplicativo"
        '
        'sttServidor
        '
        Me.sttServidor.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sttServidor.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.sttServidor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sttServidor.Name = "sttServidor"
        Me.sttServidor.Size = New System.Drawing.Size(59, 19)
        Me.sttServidor.Text = "SqlServer"
        Me.sttServidor.ToolTipText = "Servidor"
        '
        'stbSenha
        '
        Me.stbSenha.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ddbSenha_ContaCaixa, Me.ddbSenha_ContaCaixaSelecionada, Me.ddbSenha_UltimaSenhaGerada, Me.ddbSenha_UltimaSenhaChamada, Me.ddbSenha_ContaCaixa_ChamarSenha})
        Me.stbSenha.Location = New System.Drawing.Point(0, 402)
        Me.stbSenha.Name = "stbSenha"
        Me.stbSenha.Size = New System.Drawing.Size(1083, 24)
        Me.stbSenha.TabIndex = 10
        Me.stbSenha.Text = "StatusStrip1"
        '
        'ddbSenha_ContaCaixa
        '
        Me.ddbSenha_ContaCaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ddbSenha_ContaCaixa.Image = CType(resources.GetObject("ddbSenha_ContaCaixa.Image"), System.Drawing.Image)
        Me.ddbSenha_ContaCaixa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbSenha_ContaCaixa.Name = "ddbSenha_ContaCaixa"
        Me.ddbSenha_ContaCaixa.Size = New System.Drawing.Size(29, 22)
        Me.ddbSenha_ContaCaixa.Text = "ToolStripDropDownButton1"
        '
        'ddbSenha_ContaCaixaSelecionada
        '
        Me.ddbSenha_ContaCaixaSelecionada.Name = "ddbSenha_ContaCaixaSelecionada"
        Me.ddbSenha_ContaCaixaSelecionada.Size = New System.Drawing.Size(0, 19)
        '
        'ddbSenha_UltimaSenhaGerada
        '
        Me.ddbSenha_UltimaSenhaGerada.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ddbSenha_UltimaSenhaGerada.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ddbSenha_UltimaSenhaGerada.Name = "ddbSenha_UltimaSenhaGerada"
        Me.ddbSenha_UltimaSenhaGerada.Size = New System.Drawing.Size(145, 19)
        Me.ddbSenha_UltimaSenhaGerada.Tag = "Última Senha Gerada: "
        Me.ddbSenha_UltimaSenhaGerada.Text = "Última Senha Gerada: 000"
        '
        'ddbSenha_UltimaSenhaChamada
        '
        Me.ddbSenha_UltimaSenhaChamada.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ddbSenha_UltimaSenhaChamada.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.ddbSenha_UltimaSenhaChamada.Name = "ddbSenha_UltimaSenhaChamada"
        Me.ddbSenha_UltimaSenhaChamada.Size = New System.Drawing.Size(159, 19)
        Me.ddbSenha_UltimaSenhaChamada.Tag = "Última Senha Chamada:"
        Me.ddbSenha_UltimaSenhaChamada.Text = "Última Senha Chamada: 000"
        '
        'ddbSenha_ContaCaixa_ChamarSenha
        '
        Me.ddbSenha_ContaCaixa_ChamarSenha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ddbSenha_ContaCaixa_ChamarSenha.Image = CType(resources.GetObject("ddbSenha_ContaCaixa_ChamarSenha.Image"), System.Drawing.Image)
        Me.ddbSenha_ContaCaixa_ChamarSenha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbSenha_ContaCaixa_ChamarSenha.Name = "ddbSenha_ContaCaixa_ChamarSenha"
        Me.ddbSenha_ContaCaixa_ChamarSenha.Size = New System.Drawing.Size(29, 22)
        Me.ddbSenha_ContaCaixa_ChamarSenha.Text = "ToolStripDropDownButton1"
        '
        'mnuCadastro_Clinica_CaixaAtendimento
        '
        Me.mnuCadastro_Clinica_CaixaAtendimento.Name = "mnuCadastro_Clinica_CaixaAtendimento"
        Me.mnuCadastro_Clinica_CaixaAtendimento.Size = New System.Drawing.Size(341, 22)
        Me.mnuCadastro_Clinica_CaixaAtendimento.Tag = "0"
        Me.mnuCadastro_Clinica_CaixaAtendimento.Text = "Caixa de Atendimento"
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 450)
        Me.Controls.Add(Me.stbSenha)
        Me.Controls.Add(Me.stbRodape)
        Me.Controls.Add(Me.mnuGeral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.mnuGeral
        Me.Name = "frmMDI"
        Me.Text = "ww"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuGeral.ResumeLayout(False)
        Me.mnuGeral.PerformLayout()
        Me.stbRodape.ResumeLayout(False)
        Me.stbRodape.PerformLayout()
        Me.stbSenha.ResumeLayout(False)
        Me.stbSenha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuGeral As MenuStrip
    Friend WithEvents mnuAgendamento As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_Agendar As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_ConsultaAgendamento As ToolStripMenuItem
  Friend WithEvents mnuAgendamento_Precos As ToolStripMenuItem
  Friend WithEvents mnuCadastro As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoConsulta As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoEndereco As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoEscolaridade As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoEstadoCivil As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoMidiaSocial As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoPaciente As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoPessoa As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoRaca As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoReferencialPessoal As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoRelegiao As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_Especialidade As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_Procedimento As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_CadastrarHorarioProfissional As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_Configuracao As ToolStripMenuItem
    Friend WithEvents mnuFinanceiro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_Compensacao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_ConsultaContasPagar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_ConsultaContasReceber As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_ConsultaDeFluxoCaixa As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_ConsultaFluxoCaixa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_ContasPagar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_ContasReceber As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_FluxoCaixa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_Separador01 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCadastro_Financeiro_Separador02 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCadastro_Financeiro_Separador03 As ToolStripSeparator
    Friend WithEvents mnuAgendamento_ConsultarPaciente As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_Separador01 As ToolStripSeparator
    Friend WithEvents stbRodape As StatusStrip
    Friend WithEvents sttEmpresa As ToolStripStatusLabel
    Friend WithEvents sttUsuario As ToolStripStatusLabel
    Friend WithEvents sttStatus As ToolStripStatusLabel
    Friend WithEvents sttVersao As ToolStripStatusLabel
    Friend WithEvents sttServidor As ToolStripStatusLabel
    Friend WithEvents mnuCadastro_Clinica_ConsultarPrecoProcedimentosExames As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_Convenio As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_Orcamento As ToolStripMenuItem
    Friend WithEvents mnuVenda_ConsultaVendasRealizadas As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_Separador04 As ToolStripSeparator
    Friend WithEvents mnuCadastro_Financeiro_FormaPagamento As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_CondicaoPagamento As ToolStripMenuItem
    Friend WithEvents mnuVenda_Fechamento As ToolStripMenuItem
    Friend WithEvents mnuVenda_AprovacaoFechamento As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoDocumentoFinanceiro As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_ContaBancaria As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_ContaCaixa As ToolStripMenuItem
    Friend WithEvents mnuVenda_VendaPendente As ToolStripMenuItem
    Friend WithEvents mnuMedico As ToolStripMenuItem
    Friend WithEvents mnuMedico_Atendimento As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_Vacina As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_Consultorio As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_ConsultaAtendimentosRealizados As ToolStripMenuItem
    Friend WithEvents mnuMedico_Financeiro As ToolStripMenuItem
    Friend WithEvents mnuVenda As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_FaturamentoVenda As ToolStripMenuItem
    Friend WithEvents mnuVenda_ConferenciaFechamento As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Separador01 As ToolStripSeparator
    Friend WithEvents mnuCadastro_Usuario As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Usuario_Configuracao As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Usuario_AlterarSenha As ToolStripMenuItem
    Friend WithEvents mnuMedico_MinhasFaturas As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoCargo As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_GrupoProcedimento As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_ManutencaoPrecoProcedimentosExames As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_Precos_Profissional As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_PlanoContas As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_GrupoPlanoContas As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_Financiamento As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_Execucao As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Separador02 As ToolStripSeparator
    Friend WithEvents mnuCadastro_Seguranca As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Seguranca_GrupoPermissao As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Seguranca_Permissao As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa_FisicaJuridica As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa_Profissao As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa_Funcao As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa_ConselhoProfissional As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa_Empresa As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa_Cidade As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa_UF As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Pessoa_Pais As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_Banco As ToolStripMenuItem
    Friend WithEvents TipoDeSexoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_Turno As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_ClassificacaoExame As ToolStripMenuItem
    Friend WithEvents mnuMedico_ConsultaSolicitacaoExamesCitologicos As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_Separador02 As ToolStripSeparator
    Friend WithEvents mnuAgendamento_ConsultaLoteSolicitacaoExamesCitologicos As ToolStripMenuItem
    Friend WithEvents mnuAgendamento_ConsultaSolicitacaoExamesCitologicos As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Tipo_TipoRelatorio As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_TipoIndicador As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Financeiro_HistoricoIndicacao As ToolStripMenuItem
    Friend WithEvents mnuCadastro_Clinica_CadastrarHorarioProfissional_Bloqueio As ToolStripMenuItem
  Friend WithEvents mnuAgendamento_Separador03 As ToolStripSeparator
  Friend WithEvents mnuAgendamento_ConsultaOcupacaoTempoPrevisto As ToolStripMenuItem
  Friend WithEvents mnuAgendamento_ConsultaOcupacaoConsultorio As ToolStripMenuItem
  Friend WithEvents mnuAgendamento_ConsultaDiaAbestencao As ToolStripMenuItem
  Friend WithEvents mnuCadastro_Clinica_CanalMarcacao As ToolStripMenuItem
  Friend WithEvents mnuVenda_ConsultaVendasMaster As ToolStripMenuItem
  Friend WithEvents mnuAgendamento_ConsultaExamePrescrito As ToolStripMenuItem
  Friend WithEvents mnuCadastro_Financeiro_Voucher As ToolStripMenuItem
    Friend WithEvents stbSenha As StatusStrip
    Friend WithEvents ddbSenha_ContaCaixa As ToolStripDropDownButton
    Friend WithEvents ddbSenha_UltimaSenhaGerada As ToolStripStatusLabel
    Friend WithEvents ddbSenha_UltimaSenhaChamada As ToolStripStatusLabel
    Friend WithEvents ddbSenha_ContaCaixaSelecionada As ToolStripStatusLabel
    Friend WithEvents ddbSenha_ContaCaixa_ChamarSenha As ToolStripDropDownButton
    Friend WithEvents mnuCadastro_Clinica_CaixaAtendimento As ToolStripMenuItem
End Class
