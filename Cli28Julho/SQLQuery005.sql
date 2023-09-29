USE Cli28Julho
GO
ALTER TABLE TB_CONVENIO_PROCEDIMENTO
 ADD IC_PADRAO CHAR(1) DEFAULT 'N'
GO
UPDATE TB_CONVENIO_PROCEDIMENTO SET IC_PADRAO = 'N'
GO
ALTER PROCEDURE [dbo].[SP_CONVENIO_PROCEDIMENTO_CAD]
(
	@SQ_CONVENIO_PROCEDIMENTO INT,
	@ID_PROCEDIMENTO INT,
	@ID_CONVENIO INT,
	@ID_PESSOA_PROFISSIONAL INT,
	@VL_PROCEDIMENTO MONEY,
	@VL_REPASSE MONEY,
	@PC_REPASSE DECIMAL(18, 5),
	@QT_DIAS_REPASSE INT,
	@CM_OBSERVACAO VARCHAR(500),
	@IC_ATIVO CHAR(1),
	@IC_PADRAO CHAR(1)
)
AS
BEGIN
  IF ISNULL(@SQ_CONVENIO_PROCEDIMENTO, 0) = 0
	  INSERT INTO TB_CONVENIO_PROCEDIMENTO
		(ID_PROCEDIMENTO, ID_CONVENIO, ID_PESSOA_PROFISSIONAL, VL_PROCEDIMENTO, VL_REPASSE, PC_REPASSE, QT_DIAS_REPASSE, CM_OBSERVACAO, IC_ATIVO, IC_PADRAO)
		VALUES
		(@ID_PROCEDIMENTO, @ID_CONVENIO, @ID_PESSOA_PROFISSIONAL, @VL_PROCEDIMENTO, @VL_REPASSE, @PC_REPASSE, @QT_DIAS_REPASSE, @CM_OBSERVACAO, @IC_ATIVO, @IC_PADRAO)
	ELSE
	  UPDATE TB_CONVENIO_PROCEDIMENTO
		 SET VL_PROCEDIMENTO = @VL_PROCEDIMENTO,
				 VL_REPASSE = @VL_REPASSE,
				 PC_REPASSE = @PC_REPASSE,
				 QT_DIAS_REPASSE = @QT_DIAS_REPASSE,
				 CM_OBSERVACAO = @CM_OBSERVACAO,
				 IC_ATIVO = @IC_ATIVO,
				 IC_PADRAO = @IC_PADRAO
		 WHERE SQ_CONVENIO_PROCEDIMENTO = @SQ_CONVENIO_PROCEDIMENTO
END
GO
ALTER TABLE TB_ORCAMENTO_CLIENTE DROP CONSTRAINT FK_OCCLI_PESSO_PROFI
GO
ALTER TABLE TB_ORCAMENTO_CLIENTE
 DROP COLUMN ID_PESSOA_PROFISSIONAL
GO
ALTER TABLE TB_ORCAMENTO_CLIENTE  WITH CHECK ADD  CONSTRAINT FK_OCCLI_PESSO_PROFI FOREIGN KEY(ID_PESSOA_PROFISSIONAL, ID_EMPRESA)
 REFERENCES TB_PESSOA_EMPRESA (ID_PESSOA, ID_EMPRESA)
GO
DELETE FROM TB_ORCAMENTO_CLIENTE_PROCEDIMENTO
GO
ALTER TABLE TB_ORCAMENTO_CLIENTE_PROCEDIMENTO
 ADD ID_PESSOA_PROFISSIONAL INT NOT NULL
GO
ALTER TABLE TB_ORCAMENTO_CLIENTE_PROCEDIMENTO  WITH CHECK ADD  CONSTRAINT FK_OCPRC_PESSO_PROFI FOREIGN KEY(ID_PESSOA_PROFISSIONAL)
 REFERENCES TB_PESSOA (SQ_PESSOA)
GO
ALTER VIEW [dbo].[VW_CONVENIO_PROCEDIMENTO]
AS
SELECT PESSO.NO_PESSOA, CONVE.NO_CONVENIO, PROCE.NO_PROCEDIMENTO, CVPCD.*
 FROM TB_CONVENIO_PROCEDIMENTO CVPCD
  INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = CVPCD.ID_PESSOA_PROFISSIONAL
	INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = CVPCD.ID_CONVENIO
	INNER JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = CVPCD.ID_PROCEDIMENTO
GO
ALTER PROCEDURE [dbo].[SP_ORCAMENTO_CLIENTE_PROCEDIMENTO_CAD]
(
 @SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO INT,
 @ID_ORCAMENTO_CLIENTE INT,
 @ID_PROCEDIMENTO INT,
 @ID_PESSOA_PROFISSIONAL INT,
 @VL_ORCADO MONEY
)
AS
BEGIN
  IF ISNULL(@SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO, 0) = 0
		INSERT INTO TB_ORCAMENTO_CLIENTE_PROCEDIMENTO
		(ID_ORCAMENTO_CLIENTE,ID_PROCEDIMENTO,ID_PESSOA_PROFISSIONAL,VL_ORCADO)
     VALUES
		(@ID_ORCAMENTO_CLIENTE,@ID_PROCEDIMENTO,@ID_PESSOA_PROFISSIONAL,@VL_ORCADO)
	ELSE
	  UPDATE TB_ORCAMENTO_CLIENTE_PROCEDIMENTO
		 SET ID_ORCAMENTO_CLIENTE=@ID_ORCAMENTO_CLIENTE,
				 ID_PROCEDIMENTO=@ID_PROCEDIMENTO,
				 ID_PESSOA_PROFISSIONAL=@ID_PESSOA_PROFISSIONAL,
				 VL_ORCADO=@VL_ORCADO
		 WHERE SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO = @SQ_ORCAMENTO_CLIENTE_PROCEDIMENTO
END
GO
ALTER PROCEDURE [dbo].[SP_ORCAMENTO_CLIENTE_CAD]
(
 @SQ_ORCAMENTO_CLIENTE INT OUTPUT,
 @ID_EMPRESA INT,
 @ID_PESSOA INT,
 @ID_CONVENIO INT,
 @ID_FINANCIAMENTO INT,
 @ID_AGENDAMENTO INT,
 @CD_ORCAMENTO_CLIENTE VARCHAR(10) OUT,
 @DH_ORCAMENTO_CLIENTE DATETIME,
 @DT_VALIDADE DATE
)
AS
BEGIN
  IF ISNULL(@SQ_ORCAMENTO_CLIENTE, 0) = 0
		BEGIN
			SELECT @CD_ORCAMENTO_CLIENTE = dbo.FC_EMPRESA_NOVO_CD_ORCAMENTOCLINICA(@ID_EMPRESA)

			UPDATE TB_EMPRESA SET CD_ORCAMENTOCLINICA = @CD_ORCAMENTO_CLIENTE WHERE ID_EMPRESA = @ID_EMPRESA

			INSERT INTO TB_ORCAMENTO_CLIENTE
			(ID_EMPRESA,ID_PESSOA,ID_CONVENIO,ID_FINANCIAMENTO,ID_AGENDAMENTO,CD_ORCAMENTO_CLIENTE,DH_ORCAMENTO_CLIENTE,DT_VALIDADE)
			VALUES
			(@ID_EMPRESA,@ID_PESSOA,@ID_CONVENIO,@ID_FINANCIAMENTO,@ID_AGENDAMENTO,@CD_ORCAMENTO_CLIENTE,@DH_ORCAMENTO_CLIENTE,@DT_VALIDADE)

			SET @SQ_ORCAMENTO_CLIENTE = @@IDENTITY
		END
	ELSE
	  UPDATE TB_ORCAMENTO_CLIENTE
		 SET ID_EMPRESA=@ID_EMPRESA,
				 ID_PESSOA=@ID_PESSOA,
				 ID_CONVENIO=@ID_CONVENIO,
				 ID_FINANCIAMENTO=@ID_FINANCIAMENTO,
				 ID_AGENDAMENTO=@ID_AGENDAMENTO,
				 CD_ORCAMENTO_CLIENTE=ISNULL(@CD_ORCAMENTO_CLIENTE, CD_ORCAMENTO_CLIENTE),
				 DH_ORCAMENTO_CLIENTE=@DH_ORCAMENTO_CLIENTE,
				 DT_VALIDADE=@DT_VALIDADE
		 WHERE SQ_ORCAMENTO_CLIENTE = @SQ_ORCAMENTO_CLIENTE

	RETURN
END