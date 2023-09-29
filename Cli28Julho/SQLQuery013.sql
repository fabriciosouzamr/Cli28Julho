UPDATE TB_SISTEMA SET CD_VERSAO_DB = '00013'
GO
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (743, 18, 'Em Venda', 'S')
GO
CREATE TABLE TB_CLINICA_VENDA_FECHAMENTO
(
 SQ_CLINICA_VENDA_FECHAMENTO INT NOT NULL IDENTITY(1, 1),
 ID_CONTAFINANCEIRA INT NOT NULL,
 DH_PERIODO_INICIO DATETIME,
 DH_PERIODO_FIM DATETIME,
 ID_PESSOA_FECHAMENTO INT NOT NULL,
 DH_FECHAMENTO DATETIME NOT NULL,
 ID_PESSOA_APROVACAO INT,
 DH_APROVACAO DATETIME,
 ID_PESSOA_FINANCEIRA INT,
 DH_FINANCEIRA DATETIME
)
GO
ALTER TABLE dbo.TB_CLINICA_VENDA_FECHAMENTO ADD CONSTRAINT	PK_CLINICA_VENDA_FECHAMENTO
  PRIMARY KEY CLUSTERED  (SQ_CLINICA_VENDA_FECHAMENTO)
GO
ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO  WITH CHECK ADD  CONSTRAINT FK_CVFCM_CTFIN FOREIGN KEY(ID_CONTAFINANCEIRA)
 REFERENCES TB_CONTA_FINANCEIRA (SQ_CONTA_FINANCEIRA)
GO
ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO  WITH CHECK ADD  CONSTRAINT FK_CVFCM_PESSO_FCMNT FOREIGN KEY(ID_CVFCM_PESSOA_FECHAMENTO)
 REFERENCES TB_PESSOA (SQ_PESSOA)
GO
ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO  WITH CHECK ADD  CONSTRAINT FK_CVFCM_PESSO_APROV FOREIGN KEY(ID_CVFCM_PESSOA_APROVACAO)
 REFERENCES TB_PESSOA (SQ_PESSOA)
GO
ALTER TABLE TB_CLINICA_VENDA_FECHAMENTO  WITH CHECK ADD  CONSTRAINT FK_CVFCM_PESSO_FINAN FOREIGN KEY(ID_CVFCM_PESSOA_FINANCEIRA)
 REFERENCES TB_PESSOA (SQ_PESSOA)
GO
CREATE PROCEDURE SP_CLINICA_VENDA_FECHAMENTO_CAD
(
 @SQ_CLINICA_VENDA_FECHAMENTO INT OUT,
 @ID_CONTAFINANCEIRA INT,
 @ID_PESSOA_FECHAMENTO INT,
 @DH_FECHAMENTO DATETIME
)
AS
BEGIN
  INSERT INTO TB_CLINICA_VENDA_FECHAMENTO
	(ID_CONTAFINANCEIRA, ID_PESSOA_FECHAMENTO, DH_FECHAMENTO)
	VALUES
  (@ID_CONTAFINANCEIRA, @ID_PESSOA_FECHAMENTO, @DH_FECHAMENTO)

	SET @SQ_CLINICA_VENDA_FECHAMENTO = @@IDENTITY

	RETURN
END
GO
CREATE PROCEDURE SP_CLINICA_VENDA_FECHAMENTO_APROVAR
(
 @SQ_CLINICA_VENDA_FECHAMENTO INT,
 @ID_PESSOA_APROVACAO INT,
 @DH_APROVACAO DATETIME
)
AS
BEGIN
  UPDATE TB_CLINICA_VENDA_FECHAMENTO
	 SET ID_PESSOA_APROVACAO = @ID_PESSOA_APROVACAO,
	     DH_APROVACAO = @DH_APROVACAO
	 WHERE SQ_CLINICA_VENDA_FECHAMENTO = @SQ_CLINICA_VENDA_FECHAMENTO
END
GO
CREATE PROCEDURE SP_CLINICA_VENDA_FECHAMENTO_FINANCEIRA
(
 @SQ_CLINICA_VENDA_FECHAMENTO INT,
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

  DECLARE csrCLINICA_VENDA_FECHAMENTO_FINANCEIRA CURSOR FOR  
		SELECT MVFNC.SQ_MOVFINANCEIRA
		 FROM TB_CLINICA_VENDA CLVND
		  INNER JOIN TB_MOVFINANCEIRA	MVFNC ON MVFNC.ID_CLINICA_VENDA = CLVND.SQ_CLINICA_VENDA
		 WHERE ID_CLINICA_VENDA_FECHAMENTO = @SQ_CLINICA_VENDA_FECHAMENTO

  OPEN csrCLINICA_VENDA_FECHAMENTO_FINANCEIRA

  IF @@FETCH_STATUS <> 0
    FETCH NEXT FROM csrCLINICA_VENDA_FECHAMENTO_FINANCEIRA INTO @SQ_MOVFINANCEIRA
  
  WHILE @@FETCH_STATUS = 0  
		BEGIN
			UPDATE TB_MOVFINANCEIRA
			 SET ID_OPT_STATUS = 56	/* Aberto */
			 WHERE SQ_MOVFINANCEIRA = @SQ_MOVFINANCEIRA

			EXEC SP_MOVFINANCEIRA_QUITAR_CAD @SQ_MOVFINANCEIRA

			FETCH NEXT FROM csrCLINICA_VENDA_FECHAMENTO_FINANCEIRA INTO @SQ_MOVFINANCEIRA
		END

  CLOSE csrCLINICA_VENDA_FECHAMENTO_FINANCEIRA
  DEALLOCATE csrCLINICA_VENDA_FECHAMENTO_FINANCEIRA
END
GO
ALTER TABLE TB_CLINICA_VENDA
 ADD ID_CLINICA_VENDA_FECHAMENTO INT
GO
ALTER TABLE TB_CLINICA_VENDA WITH CHECK ADD CONSTRAINT FK_CLVND_CVFCM FOREIGN KEY(ID_CLINICA_VENDA_FECHAMENTO)
 REFERENCES TB_CLINICA_VENDA_FECHAMENTO (SQ_CLINICA_VENDA_FECHAMENTO)
GO
ALTER TABLE TB_EMPRESA
 ADD CD_CLINICA_VENDA VARCHAR(10)
GO
ALTER TABLE TB_CLINICA_VENDA
 ADD CD_CLINICA_VENDA VARCHAR(10)
GO
ALTER TABLE TB_CLINICA_VENDA
 ADD ID_CONTAFINANCEIRA INT
GO
ALTER TABLE TB_CLINICA_VENDA WITH CHECK ADD CONSTRAINT FK_CLVND_CTFIN FOREIGN KEY(ID_CONTAFINANCEIRA)
 REFERENCES TB_CONTAFINANCEIRA (SQ_CONTAFINANCEIRA)
GO
CREATE FUNCTION [dbo].[FC_EMPRESA_NOVO_CD_CLINICA_VENDA]
(
 @ID_EMPRESA INT
)
RETURNS VARCHAR(10)
AS
BEGIN
  DECLARE @NOVO_CD_CLINICA_VENDA VARCHAR(10)

  SELECT @NOVO_CD_CLINICA_VENDA= 'CV' + REPLACE(RIGHT(SPACE(10) + CAST(SUBSTRING(MAX(ISNULL(CD_CLINICA_VENDA, '00')), 3, 6) + 1 AS VARCHAR(10)), 6), ' ', '0')
   FROM TB_EMPRESA

  RETURN @NOVO_CD_CLINICA_VENDA
END
GO
UPDATE BNC SET CD_CLINICA_VENDA = X.COD
 FROM TB_CLINICA_VENDA BNC
  INNER JOIN (SELECT 'CR' + REPLACE(RIGHT(SPACE(10) + CAST(ROW_NUMBER() OVER(ORDER BY SQ_CLINICA_VENDA) AS VARCHAR(10)), 6), ' ', '0') COD, *
               FROM TB_CLINICA_VENDA A) X ON X.SQ_CLINICA_VENDA = BNC.SQ_CLINICA_VENDA
GO
UPDATE TB_EMPRESA SET CD_CLINICA_VENDA = (SELECT MAX(CD_CLINICA_VENDA) FROM TB_CLINICA_VENDA WHERE CD_CLINICA_VENDA LIKE 'CV%')
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
			SELECT @CD_CLINICA_VENDA = dbo.FC_EMPRESA_NOVO_CD_ORCAMENTOCLINICA(@ID_EMPRESA)

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
CREATE PROCEDURE SP_FECHAMENTO_CLINICA_VENDA_INS
(
 @SQ_CLINICA_VENDA_FECHAMENTO INT,
 @SQ_CLINICA_VENDA INT
)
AS
BEGIN
  DECLARE @DH_VENDA DATETIME
	DECLARE @DH_PERIODO_INICIO DATETIME
	DECLARE @DH_PERIODO_FIM DATETIME
	DECLARE @SQ_MOVFINANCEIRA INT

	SELECT @DH_VENDA = DH_VENDA
	 FROM TB_CLINICA_VENDA
	 WHERE SQ_CLINICA_VENDA = @SQ_CLINICA_VENDA

	SELECT @DH_PERIODO_INICIO = ISNULL(DH_PERIODO_INICIO, @DH_VENDA),
			   @DH_PERIODO_FIM = ISNULL(DH_PERIODO_FIM, @DH_VENDA)
	 FROM TB_CLINICA_VENDA_FECHAMENTO
	 WHERE SQ_CLINICA_VENDA_FECHAMENTO = @SQ_CLINICA_VENDA_FECHAMENTO

  SELECT @SQ_MOVFINANCEIRA = SQ_MOVFINANCEIRA
	 FROM TB_MOVFINANCEIRA
	 WHERE ID_CLINICA_VENDA = @SQ_CLINICA_VENDA

	IF @DH_VENDA < @DH_PERIODO_INICIO
	 SET @DH_PERIODO_INICIO = @DH_VENDA 

	IF @DH_VENDA > @DH_PERIODO_FIM
	 SET @DH_PERIODO_FIM = @DH_VENDA 

  UPDATE TB_CLINICA_VENDA
	 SET ID_CLINICA_VENDA_FECHAMENTO = @SQ_CLINICA_VENDA_FECHAMENTO
	 WHERE SQ_CLINICA_VENDA = @SQ_CLINICA_VENDA

	UPDATE TB_CLINICA_VENDA_FECHAMENTO
	 SET DH_PERIODO_INICIO = @DH_PERIODO_INICIO,
			 DH_PERIODO_FIM = @DH_PERIODO_FIM
	 WHERE SQ_CLINICA_VENDA_FECHAMENTO = @SQ_CLINICA_VENDA_FECHAMENTO
END
GO
ALTER PROCEDURE [dbo].[SP_MOVFINANCEIRA_QUITAR_CAD]
(
 @SQ_MOVFINANCEIRA INT
)
AS
BEGIN
  IF EXISTS(SELECT *
	           FROM TB_MOVFINANCEIRAPARCELA MFP
						  INNER JOIN TB_TIPO_DOCUMENTO TDC ON TDC.SQ_TIPO_DOCUMENTO = MFP.ID_TIPO_DOCUMENTO 
						 WHERE MFP.ID_MOVFINANCEIRA = @SQ_MOVFINANCEIRA
							 AND TDC.IC_COMPENSAR = 'N')		-- Dinheiro
		BEGIN
			DECLARE @ID_EMPRESA INT
			DECLARE @ID_CONTAFINANCEIRA INT
			DECLARE @SQ_MOVFINANCEIRAPARCELA INT
			DECLARE @DT_PAGAMENTO DATE
			DECLARE @DT_LANCAMENTO DATETIME
			DECLARE @VL_PARCELA MONEY
			DECLARE @VL_PAGAMENTO MONEY

		  DECLARE @SQ_PAGAMENTO INT
			DECLARE @SQ_PAGAMENTOITEM INT

			SET @DT_LANCAMENTO = GETDATE()

			SELECT @ID_EMPRESA = ID_EMPRESA,
						 @ID_CONTAFINANCEIRA = ISNULL(ID_CONTAFINANCEIRA_CREDITO, ID_CONTAFINANCEIRA_DEBITO),
			       @DT_PAGAMENTO = DT_MOVIMENTACAO
			 FROM TB_MOVFINANCEIRA
			 WHERE SQ_MOVFINANCEIRA = @SQ_MOVFINANCEIRA

		  EXEC SP_PAGAMENTO_CAD @SQ_PAGAMENTO OUT,
														@ID_EMPRESA,
														64,		/* Pagamento */
														@DT_LANCAMENTO,
														@DT_PAGAMENTO

			-- Relaciona as parcelas ao pagamento
		  DECLARE csrParcela CURSOR FOR
	     SELECT MFP.SQ_MOVFINANCEIRAPARCELA, MFP.VL_PARCELA
			  FROM TB_MOVFINANCEIRAPARCELA MFP
				WHERE MFP.ID_MOVFINANCEIRA = @SQ_MOVFINANCEIRA
				  AND MFP.ID_TIPO_DOCUMENTO = 1		/* Dinheiro */

		  OPEN csrParcela

		  IF @@FETCH_STATUS <> 0
		    FETCH NEXT FROM csrParcela INTO @SQ_MOVFINANCEIRAPARCELA, @VL_PARCELA

		  WHILE @@FETCH_STATUS = 0  
		    BEGIN
				  IF @SQ_MOVFINANCEIRAPARCELA IS NOT NULL
						EXEC SP_MOVFINANCEIRAPARCELA_PGT @SQ_MOVFINANCEIRAPARCELA, @SQ_PAGAMENTO, NULL, @VL_PARCELA, 0, 0, 0, 0, 0, 0, NULL, @DT_PAGAMENTO

		      FETCH NEXT FROM csrParcela INTO @SQ_MOVFINANCEIRAPARCELA, @VL_PARCELA
		    END

		  CLOSE csrParcela
		  DEALLOCATE csrParcela

			-- Inseri os itens do pagamento
	    SELECT @VL_PAGAMENTO = SUM(MFP.VL_PARCELA)
			FROM TB_MOVFINANCEIRAPARCELA MFP
			WHERE MFP.ID_MOVFINANCEIRA = @SQ_MOVFINANCEIRA
				AND MFP.ID_TIPO_DOCUMENTO = 1		-- Dinheiro

			EXEC SP_PAGAMENTOITEM_CAD @SQ_PAGAMENTOITEM OUT,
																@SQ_PAGAMENTO,
																384,	-- Quitado
																NULL,
																1,		-- Dinheiro
																@ID_CONTAFINANCEIRA,
																NULL,
																NULL,
																NULL,
																@VL_PAGAMENTO

			EXEC SP_PAGAMENTO_COMPENSACAO_CAD @SQ_PAGAMENTOITEM,
			                                  @ID_CONTAFINANCEIRA,
                                        384,	-- Quitado
                                        @DT_LANCAMENTO,
                                        @DT_PAGAMENTO,
                                        @VL_PAGAMENTO,
                                        NULL

			EXEC SP_PAGAMENTOITEM_MOVFINANCEIRA_CAD @SQ_PAGAMENTOITEM

			EXEC SP_MOVFINANCEIRA_STATUS @SQ_MOVFINANCEIRA
		END
END