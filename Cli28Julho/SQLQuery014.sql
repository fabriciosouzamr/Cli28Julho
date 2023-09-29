ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO
 ADD CD_CLINICA_VENDA_FECHAMENTO VARCHAR(10)
GO
ALTER TABLE TB_EMPRESA
 ADD CD_CLINICA_VENDA_FECHAMENTO VARCHAR(10)
GO
UPDATE BNC SET CD_CLINICA_VENDA_FECHAMENTO = X.COD
 FROM TB_CLINICA_VENDA_FECHAMENTO BNC
  INNER JOIN (SELECT 'FV' + REPLACE(RIGHT(SPACE(10) + CAST(ROW_NUMBER() OVER(ORDER BY SQ_CLINICA_VENDA_FECHAMENTO) AS VARCHAR(10)), 6), ' ', '0') COD, *
               FROM TB_CLINICA_VENDA_FECHAMENTO A) X ON X.SQ_CLINICA_VENDA_FECHAMENTO = BNC.SQ_CLINICA_VENDA_FECHAMENTO
GO
UPDATE TB_EMPRESA SET CD_CLINICA_VENDA_FECHAMENTO = (SELECT MAX(CD_CLINICA_VENDA_FECHAMENTO) FROM TB_CLINICA_VENDA_FECHAMENTO WHERE CD_CLINICA_VENDA_FECHAMENTO LIKE 'FV%')
GO
UPDATE BNC SET CD_CLINICA_VENDA = X.COD
 FROM TB_CLINICA_VENDA BNC
  INNER JOIN (SELECT 'CV' + REPLACE(RIGHT(SPACE(10) + CAST(ROW_NUMBER() OVER(ORDER BY SQ_CLINICA_VENDA) AS VARCHAR(10)), 6), ' ', '0') COD, *
               FROM TB_CLINICA_VENDA) X ON X.SQ_CLINICA_VENDA = BNC.SQ_CLINICA_VENDA
GO
UPDATE TB_EMPRESA SET CD_CLINICA_VENDA = (SELECT MAX(CD_CLINICA_VENDA) FROM TB_CLINICA_VENDA WHERE CD_CLINICA_VENDA LIKE 'CV%')
GO
ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO
 ALTER COLUMN CD_CLINICA_VENDA_FECHAMENTO VARCHAR(10) NOT NULL
GO
ALTER TABLE TB_CLINICA_VENDA
 ALTER COLUMN CD_CLINICA_VENDA VARCHAR(10) NOT NULL
GO
CREATE FUNCTION [dbo].[FC_EMPRESA_NOVO_CD_CLINICA_VENDA_FECHAMENTO]
(
 @ID_EMPRESA INT
)
RETURNS VARCHAR(10)
AS
BEGIN
  DECLARE @NOVO_CD_CLINICA_VENDA_FECHAMENTO VARCHAR(10)

  SELECT @NOVO_CD_CLINICA_VENDA_FECHAMENTO = 'FV' + REPLACE(RIGHT(SPACE(10) + CAST(SUBSTRING(MAX(ISNULL(CD_CLINICA_VENDA_FECHAMENTO, '00')), 3, 6) + 1 AS VARCHAR(10)), 6), ' ', '0')
   FROM TB_EMPRESA

  RETURN @NOVO_CD_CLINICA_VENDA_FECHAMENTO
END
GO
ALTER PROCEDURE [dbo].[SP_CLINICA_VENDA_FECHAMENTO_CAD]
(
 @SQ_CLINICA_VENDA_FECHAMENTO INT OUT,
 @ID_CONTAFINANCEIRA INT,
 @ID_PESSOA_FECHAMENTO INT,
 @DH_FECHAMENTO DATETIME
)
AS
BEGIN
  DECLARE @CD_CLINICA_VENDA_FECHAMENTO VARCHAR(10)
	DECLARE @ID_EMPRESA INT

	SELECT @CD_CLINICA_VENDA_FECHAMENTO = dbo.FC_EMPRESA_NOVO_CD_CLINICA_VENDA_FECHAMENTO(@ID_EMPRESA)

	SELECT @ID_EMPRESA = ID_EMPRESA FROM TB_CONTAFINANCEIRA WHERE SQ_CONTAFINANCEIRA = @ID_CONTAFINANCEIRA

	UPDATE TB_EMPRESA SET CD_CLINICA_VENDA_FECHAMENTO = @CD_CLINICA_VENDA_FECHAMENTO WHERE ID_EMPRESA = @ID_EMPRESA

  INSERT INTO TB_CLINICA_VENDA_FECHAMENTO
	(ID_CONTAFINANCEIRA, ID_PESSOA_FECHAMENTO, CD_CLINICA_VENDA_FECHAMENTO, DH_FECHAMENTO)
	VALUES
  (@ID_CONTAFINANCEIRA, @ID_PESSOA_FECHAMENTO, @CD_CLINICA_VENDA_FECHAMENTO, @DH_FECHAMENTO)

	SET @SQ_CLINICA_VENDA_FECHAMENTO = @@IDENTITY

	RETURN
END
GO
ALTER PROCEDURE [dbo].[SP_CLINICA_VENDA_CAD]
(
 @SQ_CLINICA_VENDA INT OUT,
 @CD_CLINICA_VENDA VARCHAR(10) OUT,
 @ID_EMPRESA INT,
 @ID_CONTAFINANCEIRA INT,
 @ID_PESSOA INT,
 @ID_CONVENIO INT,
 @ID_ATENDIMENTO INT,
 @ID_AGENDAMENTO INT,
 @ID_ORCAMENTO_CLIENTE INT,
 @ID_INDICACAO INT,
 @DH_VENDA DATETIME
)
AS
BEGIN
  IF ISNULL(@SQ_CLINICA_VENDA, 0) = 0
		BEGIN
			SELECT @CD_CLINICA_VENDA = dbo.FC_EMPRESA_NOVO_CD_CLINICA_VENDA(@ID_EMPRESA)

			UPDATE TB_EMPRESA SET CD_CLINICA_VENDA = @CD_CLINICA_VENDA WHERE ID_EMPRESA = @ID_EMPRESA

			INSERT INTO TB_CLINICA_VENDA
			(ID_EMPRESA, ID_CONTAFINANCEIRA, ID_PESSOA, ID_CONVENIO, ID_ATENDIMENTO, ID_AGENDAMENTO,
			 ID_ORCAMENTO_CLIENTE, ID_INDICACAO, ID_OPT_STATUS, CD_CLINICA_VENDA, DH_VENDA)
			VALUES
			(@ID_EMPRESA, @ID_CONTAFINANCEIRA, @ID_PESSOA, @ID_CONVENIO, @ID_ATENDIMENTO, @ID_AGENDAMENTO,
			 @ID_ORCAMENTO_CLIENTE, @ID_INDICACAO, 737  /* Lan�ado */, @CD_CLINICA_VENDA, @DH_VENDA)

			SET @SQ_CLINICA_VENDA = @@IDENTITY
		END
	ELSE
	  UPDATE TB_CLINICA_VENDA
		 SET ID_EMPRESA=@ID_EMPRESA,
				 ID_CONTAFINANCEIRA=@ID_CONTAFINANCEIRA,
				 ID_PESSOA=@ID_PESSOA,
				 ID_CONVENIO=@ID_CONVENIO,
				 ID_ATENDIMENTO=@ID_ATENDIMENTO,
				 ID_AGENDAMENTO=@ID_AGENDAMENTO,
				 ID_ORCAMENTO_CLIENTE=@ID_ORCAMENTO_CLIENTE,
			   ID_INDICACAO=@ID_INDICACAO,
				 DH_VENDA=@DH_VENDA
		 WHERE SQ_CLINICA_VENDA = @SQ_CLINICA_VENDA

	RETURN
END
GO
ALTER FUNCTION [dbo].[FC_EMPRESA_NOVO_CD_CLINICA_VENDA]
(
 @ID_EMPRESA INT
)
RETURNS VARCHAR(10)
AS
BEGIN
  DECLARE @NOVO_CD_CLINICA_VENDA VARCHAR(10)

  SELECT @NOVO_CD_CLINICA_VENDA = 'CV' + REPLACE(RIGHT(SPACE(10) + CAST(SUBSTRING(MAX(ISNULL(CD_CLINICA_VENDA, '00')), 3, 6) + 1 AS VARCHAR(10)), 6), ' ', '0')
   FROM TB_EMPRESA

  RETURN @NOVO_CD_CLINICA_VENDA
END
GO
ALTER TABLE TB_EMPRESA
 ADD ID_CONTAFINANCEIRA_TESOURARIA INT
GO
ALTER TABLE TB_EMPRESA  WITH CHECK ADD  CONSTRAINT FK_EMPRE_CTFIN_TESOU FOREIGN KEY(ID_CONTAFINANCEIRA_TESOURARIA)
 REFERENCES TB_CONTAFINANCEIRA (SQ_CONTAFINANCEIRA)
GO
ALTER PROCEDURE [dbo].[SP_EMPRESA_CAD]
	@ID_EMPRESA INT,
	@ID_TABELAPRECO_PADRAO INT,
	@ID_TRANSACAOESTOQUE_PADRAO_COMPRAS INT,
	@ID_TRANSACAOESTOQUE_PADRAO_VENDAS INT,
	@ID_EMPRESA_MATRIZ INT,
	@ID_PLANOCONTAS_PADRAO_RECEBIMENTO INT,
	@ID_MODELODOCUMENTO_RECIBO_PADRAO INT,
	@ID_SEGMENTO_CRCP_PADRAO INT,
	@ID_CANALNEGOCIO_PADRAO_VENDA INT,
	@ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO INT,
	@ID_CONDICAOPAGAMENTO_VENDA_PADRAO INT,
	@ID_TIPO_DOCUMENTO_PADRAO_VENDA INT,
	@ID_CONTAFINANCEIRA_PADRAO_VENDA INT,
	@ID_CONTAFINANCEIRA_TESOURARIA INT,
	@ID_PESSOA_RESPONSAVEL INT,
	@ID_PESSOA_RESPONSAVELTECNICO INT,
	@ID_PESSOA_RESPONSAVELCONTABIL INT,
	@DS_PATH_REPOSITORIO_ARQUIVO VARCHAR(255),
	@CADASTROTELEFONE_DDD_PADRAO VARCHAR(5),
	@NR_CASASDECIMAIS_VALORES INT,
	@NR_DIA_VALIDADEORCAMENTO INT,
	@NR_DIA_VALIDADEPEDIDO INT,
	@IC_NOME_FANTASIA_RELATORIOS CHAR(1),
	@IC_QUITAR_PROVISIONADO CHAR(1),
	@IC_PROVISIONADO_POR_PADRAO CHAR(1),
	@IM_LOGOTIPO IMAGE,
	@IC_DIAUTIL_DOM CHAR(1),
	@IC_DIAUTIL_SEG CHAR(1),
	@IC_DIAUTIL_TER CHAR(1),
	@IC_DIAUTIL_QUA CHAR(1),
	@IC_DIAUTIL_QUI CHAR(1),
	@IC_DIAUTIL_SEX CHAR(1),
	@IC_DIAUTIL_SAB CHAR(1)
AS
BEGIN
  IF NOT EXISTS(SELECT * FROM TB_EMPRESA WHERE ID_EMPRESA = @ID_EMPRESA)
		INSERT INTO TB_EMPRESA
		(ID_EMPRESA, ID_TABELAPRECO_PADRAO, ID_EMPRESA_MATRIZ, ID_TRANSACAOESTOQUE_PADRAO_COMPRAS,
		 ID_TRANSACAOESTOQUE_PADRAO_VENDAS, ID_PLANOCONTAS_PADRAO_RECEBIMENTO, ID_MODELODOCUMENTO_RECIBO_PADRAO,
		 ID_SEGMENTO_CRCP_PADRAO, ID_CANALNEGOCIO_PADRAO_VENDA, ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO,
		 ID_CONDICAOPAGAMENTO_VENDA_PADRAO, ID_TIPO_DOCUMENTO_PADRAO_VENDA, ID_CONTAFINANCEIRA_PADRAO_VENDA,
		 ID_CONTAFINANCEIRA_TESOURARIA, ID_PESSOA_RESPONSAVEL, ID_PESSOA_RESPONSAVELTECNICO, ID_PESSOA_RESPONSAVELCONTABIL,
		 DS_PATH_REPOSITORIO_ARQUIVO, CADASTROTELEFONE_DDD_PADRAO, NR_CASASDECIMAIS_VALORES, NR_DIA_VALIDADEORCAMENTO, IM_LOGOTIPO,
		 NR_DIA_VALIDADEPEDIDO, IC_NOME_FANTASIA_RELATORIOS, IC_QUITAR_PROVISIONADO, IC_PROVISIONADO_POR_PADRAO,
		 IC_DIAUTIL_DOM, IC_DIAUTIL_SEG, IC_DIAUTIL_TER, IC_DIAUTIL_QUA, IC_DIAUTIL_QUI, IC_DIAUTIL_SEX,
		 IC_DIAUTIL_SAB)
		VALUES
		(@ID_EMPRESA, @ID_TABELAPRECO_PADRAO, @ID_EMPRESA_MATRIZ, @ID_TRANSACAOESTOQUE_PADRAO_COMPRAS,
		 @ID_TRANSACAOESTOQUE_PADRAO_VENDAS, @ID_PLANOCONTAS_PADRAO_RECEBIMENTO, @ID_MODELODOCUMENTO_RECIBO_PADRAO,
		 @ID_SEGMENTO_CRCP_PADRAO, @ID_CANALNEGOCIO_PADRAO_VENDA, @ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO,
		 @ID_CONDICAOPAGAMENTO_VENDA_PADRAO, @ID_TIPO_DOCUMENTO_PADRAO_VENDA, @ID_CONTAFINANCEIRA_PADRAO_VENDA,
		 @ID_CONTAFINANCEIRA_TESOURARIA, @ID_PESSOA_RESPONSAVEL, @ID_PESSOA_RESPONSAVELTECNICO, @ID_PESSOA_RESPONSAVELCONTABIL,
		 @DS_PATH_REPOSITORIO_ARQUIVO,@CADASTROTELEFONE_DDD_PADRAO, @NR_CASASDECIMAIS_VALORES,	@NR_DIA_VALIDADEORCAMENTO, @IM_LOGOTIPO,
		 @NR_DIA_VALIDADEPEDIDO, @IC_NOME_FANTASIA_RELATORIOS, @IC_QUITAR_PROVISIONADO, @IC_PROVISIONADO_POR_PADRAO,
		 @IC_DIAUTIL_DOM, @IC_DIAUTIL_SEG, @IC_DIAUTIL_TER,	@IC_DIAUTIL_QUA, @IC_DIAUTIL_QUI, @IC_DIAUTIL_SEX,
		 @IC_DIAUTIL_SAB)
  ELSE 
		UPDATE TB_EMPRESA
		 SET ID_TABELAPRECO_PADRAO = @ID_TABELAPRECO_PADRAO,
				 ID_TRANSACAOESTOQUE_PADRAO_COMPRAS = @ID_TRANSACAOESTOQUE_PADRAO_COMPRAS,
				 ID_TRANSACAOESTOQUE_PADRAO_VENDAS = @ID_TRANSACAOESTOQUE_PADRAO_VENDAS,
				 ID_EMPRESA_MATRIZ = @ID_EMPRESA_MATRIZ,
				 ID_PLANOCONTAS_PADRAO_RECEBIMENTO = @ID_PLANOCONTAS_PADRAO_RECEBIMENTO,
				 ID_MODELODOCUMENTO_RECIBO_PADRAO = @ID_MODELODOCUMENTO_RECIBO_PADRAO,
				 ID_SEGMENTO_CRCP_PADRAO = @ID_SEGMENTO_CRCP_PADRAO,
				 ID_CANALNEGOCIO_PADRAO_VENDA = @ID_CANALNEGOCIO_PADRAO_VENDA,
				 ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO = @ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO,
				 ID_CONDICAOPAGAMENTO_VENDA_PADRAO = @ID_CONDICAOPAGAMENTO_VENDA_PADRAO,
				 ID_TIPO_DOCUMENTO_PADRAO_VENDA = @ID_TIPO_DOCUMENTO_PADRAO_VENDA,
				 ID_CONTAFINANCEIRA_PADRAO_VENDA = @ID_CONTAFINANCEIRA_PADRAO_VENDA,
				 ID_CONTAFINANCEIRA_TESOURARIA = @ID_CONTAFINANCEIRA_TESOURARIA,
				 ID_PESSOA_RESPONSAVEL = @ID_PESSOA_RESPONSAVEL,
				 ID_PESSOA_RESPONSAVELTECNICO = @ID_PESSOA_RESPONSAVELTECNICO,
				 ID_PESSOA_RESPONSAVELCONTABIL = @ID_PESSOA_RESPONSAVELCONTABIL,
				 DS_PATH_REPOSITORIO_ARQUIVO = @DS_PATH_REPOSITORIO_ARQUIVO,
				 CADASTROTELEFONE_DDD_PADRAO = @CADASTROTELEFONE_DDD_PADRAO,
				 NR_CASASDECIMAIS_VALORES = @NR_CASASDECIMAIS_VALORES,
				 NR_DIA_VALIDADEORCAMENTO = @NR_DIA_VALIDADEORCAMENTO,
				 NR_DIA_VALIDADEPEDIDO = @NR_DIA_VALIDADEPEDIDO,
				 IC_NOME_FANTASIA_RELATORIOS = @IC_NOME_FANTASIA_RELATORIOS,
				 IC_QUITAR_PROVISIONADO = @IC_QUITAR_PROVISIONADO,
				 IC_PROVISIONADO_POR_PADRAO = @IC_PROVISIONADO_POR_PADRAO,
				 IM_LOGOTIPO = ISNULL(@IM_LOGOTIPO, IM_LOGOTIPO),
				 IC_DIAUTIL_DOM = @IC_DIAUTIL_DOM,
				 IC_DIAUTIL_SEG = @IC_DIAUTIL_SEG,
				 IC_DIAUTIL_TER = @IC_DIAUTIL_TER,
				 IC_DIAUTIL_QUA = @IC_DIAUTIL_QUA,
				 IC_DIAUTIL_QUI = @IC_DIAUTIL_QUI,
				 IC_DIAUTIL_SEX = @IC_DIAUTIL_SEX,
				 IC_DIAUTIL_SAB = @IC_DIAUTIL_SAB
		 WHERE ID_EMPRESA = @ID_EMPRESA
END
GO
ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO
 ADD ID_CONTAFINANCEIRA_APROVACAO INT,
     ID_CONTAFINANCEIRA_FINANCEIRA INT
GO
ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO WITH CHECK ADD  CONSTRAINT FK_EMPRE_CTFIN_APROV FOREIGN KEY(ID_CONTAFINANCEIRA_APROVACAO)
 REFERENCES TB_CONTAFINANCEIRA (SQ_CONTAFINANCEIRA)
GO
ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO WITH CHECK ADD  CONSTRAINT FK_EMPRE_CTFIN_FINAN FOREIGN KEY(ID_CONTAFINANCEIRA_FINANCEIRA)
 REFERENCES TB_CONTAFINANCEIRA (SQ_CONTAFINANCEIRA)
GO
CREATE PROCEDURE SP_CLINICA_VENDA_FECHAMENTO_MOVFINANCEIRA
(
 @SQ_CLINICA_VENDA_FECHAMENTO INT,
 @ID_CONTAFINANCEIRA INT
)
AS
BEGIN
  DECLARE @SQ_MOVFINANCEIRA INT

  DECLARE csrCLINICA_VENDA_FECHAMENTO_MOVFINANCEIRA CURSOR FOR  
		SELECT MVFNC.SQ_MOVFINANCEIRA
		 FROM TB_CLINICA_VENDA CLVND
		  INNER JOIN TB_MOVFINANCEIRA	MVFNC ON MVFNC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA
		 WHERE CLVND.ID_CLINICA_VENDA_FECHAMENTO = @SQ_CLINICA_VENDA_FECHAMENTO

  OPEN csrCLINICA_VENDA_FECHAMENTO_MOVFINANCEIRA

  IF @@FETCH_STATUS <> 0
    FETCH NEXT FROM csrCLINICA_VENDA_FECHAMENTO_MOVFINANCEIRA INTO @SQ_MOVFINANCEIRA
  
  WHILE @@FETCH_STATUS = 0  
		BEGIN
			UPDATE TB_MOVFINANCEIRA
			 SET ID_OPT_STATUS = 56	/* Aberto */,
			     ID_CONTAFINANCEIRA_CREDITO = @ID_CONTAFINANCEIRA
			 WHERE SQ_MOVFINANCEIRA = @SQ_MOVFINANCEIRA

			UPDATE TB_MOVFINANCEIRAPARCELA
			 SET ID_OPT_STATUS = 56	/* Aberto */
			 FROM TB_MOVFINANCEIRA
			 WHERE ID_MOVFINANCEIRA = @SQ_MOVFINANCEIRA
			 
			EXEC SP_MOVFINANCEIRA_QUITAR_CAD @SQ_MOVFINANCEIRA

			FETCH NEXT FROM csrCLINICA_VENDA_FECHAMENTO_MOVFINANCEIRA INTO @SQ_MOVFINANCEIRA
		END

  CLOSE csrCLINICA_VENDA_FECHAMENTO_MOVFINANCEIRA
  DEALLOCATE csrCLINICA_VENDA_FECHAMENTO_MOVFINANCEIRA
END
GO
ALTER PROCEDURE [dbo].[SP_CLINICA_VENDA_FECHAMENTO_APROVAR]
(
 @SQ_CLINICA_VENDA_FECHAMENTO INT,
 @ID_CONTAFINANCEIRA_APROVACAO INT,
 @ID_PESSOA_APROVACAO INT,
 @DH_APROVACAO DATETIME
)
AS
BEGIN
  UPDATE TB_CLINICA_VENDA_FECHAMENTO
	 SET ID_CONTAFINANCEIRA_APROVACAO = @ID_CONTAFINANCEIRA_APROVACAO,
	     ID_PESSOA_APROVACAO = @ID_PESSOA_APROVACAO,
	     DH_APROVACAO = @DH_APROVACAO
	 WHERE SQ_CLINICA_VENDA_FECHAMENTO = @SQ_CLINICA_VENDA_FECHAMENTO
END
GO
ALTER PROCEDURE [dbo].[SP_CLINICA_VENDA_FECHAMENTO_FINANCEIRA]
(
 @SQ_CLINICA_VENDA_FECHAMENTO INT,
 @ID_CONTAFINANCEIRA_FINANCEIRA INT,
 @ID_PESSOA_FINANCEIRA INT,
 @DH_FINANCEIRA DATETIME
)
AS
BEGIN
  DECLARE @SQ_MOVFINANCEIRA INT

  UPDATE TB_CLINICA_VENDA_FECHAMENTO
	 SET ID_PESSOA_FINANCEIRA = @ID_PESSOA_FINANCEIRA,
	     DH_FINANCEIRA = @DH_FINANCEIRA
	 WHERE SQ_CLINICA_VENDA_FECHAMENTO = @SQ_CLINICA_VENDA_FECHAMENTO

	EXEC SP_CLINICA_VENDA_FECHAMENTO_MOVFINANCEIRA @SQ_CLINICA_VENDA_FECHAMENTO, @ID_CONTAFINANCEIRA_FINANCEIRA
END
GO
CREATE PROCEDURE SP_MOVFINANCEIRAPARCELA_TRANSFERIR
(
 @SQ_MOVFINANCEIRAPARCELA INT,
 @ID_CONTAFINANCEIRA INT,
 @TP_TRANSFERIDO CHAR(1) OUT
)
AS
BEGIN
  DECLARE @ID_MOVFINANCEIRA INT
	DECLARE @ID_OPT_TIPOMOVFINANCEIRA INT

	SELECT @ID_MOVFINANCEIRA = MVFNP.ID_MOVFINANCEIRA,
				 @ID_OPT_TIPOMOVFINANCEIRA = MVFNC.ID_OPT_TIPOMOVFINANCEIRA
	 FROM TB_MOVFINANCEIRAPARCELA	MVFNP
	  INNER JOIN TB_MOVFINANCEIRA	MVFNC ON MVFNC.SQ_MOVFINANCEIRA = MVFNP.ID_MOVFINANCEIRA
	 WHERE SQ_MOVFINANCEIRAPARCELA = @SQ_MOVFINANCEIRAPARCELA
  
  IF EXISTS(SELECT * FROM TB_MOVFINANCEIRAPARCELA WHERE ID_MOVFINANCEIRA = @ID_MOVFINANCEIRA AND ID_OPT_STATUS NOT IN (56	/*Aberto */))
		SET @TP_TRANSFERIDO = 'N'
  ELSE
		BEGIN
		  IF @ID_OPT_TIPOMOVFINANCEIRA = 45	/* Contas a Receber */
				UPDATE TB_MOVFINANCEIRA
				 SET ID_CONTAFINANCEIRA_CREDITO = @ID_CONTAFINANCEIRA
				 WHERE SQ_MOVFINANCEIRA = @ID_MOVFINANCEIRA
			ELSE IF @ID_OPT_TIPOMOVFINANCEIRA = 46	/* Contas a Pagar */
				UPDATE TB_MOVFINANCEIRA
				 SET ID_CONTAFINANCEIRA_DEBITO = @ID_CONTAFINANCEIRA
				 WHERE SQ_MOVFINANCEIRA = @ID_MOVFINANCEIRA

			SET @TP_TRANSFERIDO = 'S'
		END
END
GO
ALTER VIEW [dbo].[VW_EMPRESA]
AS
SELECT EMP.ID_EMPRESA,
			 EMP.ID_TABELAPRECO_PADRAO,
			 EMP.ID_EMPRESA_MATRIZ,
			 EMP.ID_MOEDA_PADRAO,
			 EMP.ID_OPT_TIPOCONTROLECONTABIL,
			 EMP.ID_NATUREZAOPERACAO_VENDA,
			 EMP.ID_OPT_METODOCALCULOPRECO,
			 EMP.ID_OPT_CRT,
 			 EMP.ID_OPT_CRT_ISSQN,
			 EMP.ID_OPT_RATEIO_ISSQN,
			 EMP.ID_TRANSACAOESTOQUE_PADRAO_COMPRAS,
			 EMP.ID_TRANSACAOESTOQUE_PADRAO_VENDAS,
			 EMP.ID_PLANOCONTAS_PADRAO_RECEBIMENTO,
			 EMP.ID_MODELODOCUMENTO_RECEITA_PADRAO,
			 EMP.ID_MODELODOCUMENTO_ANAMNESE_PADRAO,
			 EMP.ID_MODELODOCUMENTO_EVOLUCAO_PADRAO,
			 EMP.ID_MODELODOCUMENTO_RECIBO_PADRAO,
			 EMP.ID_QUESTIONARIO_ANAMNESE_PADRAO,
			 EMP.ID_TIPO_CONSULTA_RETORNO,
			 PES.ID_TIPO_PESSOA,
			 EMP.ID_TABELAPROCEDIMENTO_PADRAO,
			 EMP.ID_EQUIPAMENTO_PROCESSAMENTO_FISCAL,
			 EMP.ID_ORDEMSERVICO_OPT_TIPO_ORDEMSERVICO_PADRAO,
			 EMP.ID_ORDEMSERVICO_TABELAPRECO_PADRAO,
			 EMP.ID_SEGMENTO_CRCP_PADRAO,
			 EMP.ID_CANALNEGOCIO_PADRAO_VENDA,
			 EMP.ID_CONDICAOPAGAMENTO_RECEBIMENTO_PADRAO,
			 EMP.ID_CONDICAOPAGAMENTO_VENDA_PADRAO,
			 EMP.ID_CONTAFINANCEIRA_PADRAO_VENDA,
			 EMP.ID_CONTAFINANCEIRA_TESOURARIA,
			 EMP.ID_TIPO_DOCUMENTO_PADRAO_VENDA,
			 EMP.ID_PESSOA_RESPONSAVEL,
			 EMP.ID_PESSOA_RESPONSAVELTECNICO,
			 EMP.ID_PESSOA_RESPONSAVELCONTABIL,
			 EDR.ID_CIDADE,
			 EDR.ID_UF,
			 EDR.ID_PAIS,
			 PES.ID_OPT_PJ_CONTRIBUICAO_ICMS,
			 EDR.CD_UF,
			 PES.NO_PESSOA AS NO_EMPRESA,
			 TPP.NO_TIPO_PESSOA, 
			 NOV.NO_NATUREZAOPERACAO NO_NATUREZAOPERACAO_VENDA,
			 CNG.NO_CANALNEGOCIO NO_CANALNEGOCIO_PADRAO_VENDA,
			 TBP.NO_TABELAPRECO NO_TABELAPRECO_PADRAO,
			 MDP.NO_MOEDA NO_MOEDA_PADRAO,
			 OPCAO_MCLPC.NO_OPCAO NO_OPT_METODOCALCULOPRECO,
			 OPCAO_TPOCTC.NO_OPCAO NO_OPT_TIPOCONTROLECONTABIL,
			 OPCAO_CRTBT.NO_OPCAO NO_OPT_CRT,
			 TPC.NO_TRANSACAOESTOQUE NO_TRANSACAOESTOQUE_PADRAO_COMPRAS,
			 PPR.NO_PLANOCONTAS NO_PLANOCONTAS_PADRAO_RECEBIMENTO,
			 RPS.NO_PESSOA NO_PESSOA_RESPONSAVEL,
			 PES.DT_NASC_ABERTURA AS DT_ABERTURA,
			 PES.CD_CPF_CNPJ AS CD_CNPJ,
			 PES.NO_FANTASIA_REDUZIDO,
			 EMP.CD_CNES,
			 PES.CD_PJ_IE,
			 PES.CD_PJ_IM, 
			 EMP.CD_CNAE,
			 PES.ID_OPT_ATIVO,
			 EMP.DS_PATH_REPOSITORIO_ARQUIVO,
			 PES.DS_PATH_IMAGEM,
			 EMP.NR_ATENDIMENTO_INTERVALO,
			 EMP.HR_ATENDIMENTO_INICIO,
			 EMP.HR_ATENDIMENTO_SAIDAREFEICAO,
			 EMP.HR_ATENDIMENTO_RETORNOREFEICAO,
			 EMP.HR_ATENDIMENTO_FIM,
			 EMP.IC_LISTARTODOS_PROCEDIMENTO,
			 EMP.IC_ORDEMSERVICO_LISTAGEMPRODUTOMANUTENCAO,
			 EMP.IC_ORDEMSERVICO_DESCRICAOPRODUTOMANUTENCAO,
			 EMP.IC_ORDEMSERVICO_DESCRICAOPRODUTOMANUTENCAO_1OPCAO,
			 EMP.NR_CASASDECIMAIS_VALORES,
			 EMP.NR_DIA_VALIDADEORCAMENTO,
			 EMP.NR_DIA_VALIDADEPEDIDO,
			 EMP.CADASTROTELEFONE_DDD_PADRAO,
			 EMP.CADASTROTELEFONE_MASCARA,
			 EMP.IC_NECESSITA_ANAMNESE_EVOLUCAO,
			 EMP.IC_QUITAR_PROVISIONADO,
			 EMP.IC_PROVISIONADO_POR_PADRAO,
			 EMP.IC_DIAUTIL_DOM,
			 EMP.IC_DIAUTIL_SEG,
			 EMP.IC_DIAUTIL_TER,
			 EMP.IC_DIAUTIL_QUA,
			 EMP.IC_DIAUTIL_QUI,
			 EMP.IC_DIAUTIL_SEX,
			 EMP.IC_DIAUTIL_SAB
 FROM TB_EMPRESA EMP
  INNER JOIN TB_PESSOA PES ON EMP.ID_EMPRESA = PES.SQ_PESSOA
  INNER JOIN TB_TIPO_PESSOA TPP ON PES.ID_TIPO_PESSOA = TPP.SQ_TIPO_PESSOA
   LEFT JOIN TB_TABELAPRECO TBP ON TBP.SQ_TABELAPRECO = EMP.ID_TABELAPRECO_PADRAO
   LEFT JOIN TB_NATUREZAOPERACAO NOV ON NOV.SQ_NATUREZAOPERACAO = EMP.ID_NATUREZAOPERACAO_VENDA
   LEFT JOIN TB_CANALNEGOCIO CNG ON CNG.SQ_CANALNEGOCIO = EMP.ID_CANALNEGOCIO_PADRAO_VENDA
   LEFT JOIN TB_MOEDA MDP ON MDP.SQ_MOEDA = EMP.ID_MOEDA_PADRAO
   LEFT JOIN TB_PESSOA RPS ON RPS.SQ_PESSOA = EMP.ID_PESSOA_RESPONSAVEL
   LEFT JOIN TB_OPCAO OPCAO_TPOCTC ON OPCAO_TPOCTC.SQ_OPCAO = EMP.ID_OPT_TIPOCONTROLECONTABIL
   LEFT JOIN TB_OPCAO OPCAO_MCLPC ON OPCAO_MCLPC.SQ_OPCAO = EMP.ID_OPT_METODOCALCULOPRECO
   LEFT JOIN TB_OPCAO OPCAO_CRTBT ON OPCAO_CRTBT.SQ_OPCAO = EMP.ID_OPT_CRT
   LEFT JOIN TB_TRANSACAOESTOQUE TPC ON TPC.SQ_TRANSACAOESTOQUE = EMP.ID_TRANSACAOESTOQUE_PADRAO_COMPRAS
   LEFT JOIN TB_PLANOCONTAS PPR ON PPR.SQ_PLANOCONTAS = EMP.ID_PLANOCONTAS_PADRAO_RECEBIMENTO
   LEFT JOIN VW_ENDERECO_PRIMEIRO EDR ON EDR.ID_PESSOA = EMP.ID_EMPRESA
																		 AND EDR.ID_TIPO_ENDERECO = 2