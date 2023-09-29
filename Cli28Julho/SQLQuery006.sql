USE Cli28Julho
GO
INSERT INTO TB_TIPO_OPCAO (SQ_TIPO_OPCAO, NO_TIPO_OPCAO) VALUES (119, 'Status de Venda')
GO
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (737, 119, 'Lan�ado', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (738, 119, 'Cancelado', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (739, 119, 'Estornado', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (740, 119, 'Cancelado Parcial', 'S')
GO
CREATE TABLE TB_CLINICA_VENDA
(
 SQ_CLINICA_VENDA INT NOT NULL IDENTITY(1, 1),
 ID_EMPRESA INT NOT NULL,
 ID_PESSOA INT NOT NULL,
 ID_CONVENIO INT NOT NULL,
 ID_OPT_STATUS INT NOT NULL,
 ID_ATENDIMENTO INT,
 ID_AGENDAMENTO INT,
 ID_ORCAMENTO_CLIENTE INT,
 ID_INDICACAO INT,
 DH_VENDA DATETIME NOT NULL DEFAULT GETDATE()
)
GO
ALTER TABLE TB_CLINICA_VENDA ADD CONSTRAINT	PK_CLINICA_VENDA
  PRIMARY KEY CLUSTERED  (SQ_CLINICA_VENDA)
GO
ALTER TABLE TB_CLINICA_VENDA  WITH CHECK ADD  CONSTRAINT FK_CLVND_EMPRE FOREIGN KEY(ID_EMPRESA)
 REFERENCES TB_EMPRESA (ID_EMPRESA)
GO
ALTER TABLE TB_CLINICA_VENDA  WITH CHECK ADD  CONSTRAINT FK_CLVND_OPCAO_STATU FOREIGN KEY(ID_OPT_STATUS)
 REFERENCES TB_OPCAO (SQ_OPCAO)
GO
ALTER TABLE TB_CLINICA_VENDA  WITH CHECK ADD  CONSTRAINT FK_CLVND_PESSO FOREIGN KEY(ID_PESSOA)
 REFERENCES TB_PESSOA (SQ_PESSOA)
GO
ALTER TABLE TB_CLINICA_VENDA  WITH CHECK ADD  CONSTRAINT FK_CLVND_CONVE FOREIGN KEY(ID_CONVENIO)
 REFERENCES TB_CONVENIO (SQ_CONVENIO)
GO
ALTER TABLE TB_CLINICA_VENDA  WITH CHECK ADD  CONSTRAINT FK_CLVND_ATEND FOREIGN KEY(ID_ATENDIMENTO)
 REFERENCES TB_ATENDIMENTO (SQ_ATENDIMENTO)
GO
ALTER TABLE TB_CLINICA_VENDA  WITH CHECK ADD  CONSTRAINT FK_CLVND_AGEND FOREIGN KEY(ID_AGENDAMENTO)
 REFERENCES TB_AGENDAMENTO (SQ_AGENDAMENTO)
GO
ALTER TABLE TB_CLINICA_VENDA  WITH CHECK ADD  CONSTRAINT FK_CLVND_OCCLI FOREIGN KEY(ID_ORCAMENTO_CLIENTE)
 REFERENCES TB_ORCAMENTO_CLIENTE (SQ_ORCAMENTO_CLIENTE)
GO
ALTER TABLE TB_CLINICA_VENDA  WITH CHECK ADD  CONSTRAINT FK_CLVND_INDIC FOREIGN KEY(ID_INDICACAO)
 REFERENCES TB_INDICACAO (SQ_INDICACAO)
GO
CREATE TABLE TB_CLINICA_VENDA_PROCEDIMENTO
(
 SQ_CLINICA_VENDA_PROCEDIMENTO INT NOT NULL IDENTITY(1, 1),
 ID_CLINICA_VENDA INT NOT NULL,
 ID_PROCEDIMENTO INT NOT NULL,
 ID_PESSOA_PROFISSIONAL INT NOT NULL,
 ID_OPT_STATUS INT NOT NULL,
 VL_PROCEDIMENTO MONEY NOT NULL,
 VL_DESCONTO MONEY NOT NULL DEFAULT 0,
 DT_PREVISAO_FATURAMENTO DATE NOT NULL,
 CM_CANCELAMENTO_ESTORNO VARCHAR(5000),
)
GO
ALTER TABLE TB_CLINICA_VENDA_PROCEDIMENTO ADD CONSTRAINT	PK_CLINICA_VENDA_PROCEDIMENTO
  PRIMARY KEY CLUSTERED  (SQ_CLINICA_VENDA_PROCEDIMENTO)
GO
ALTER TABLE TB_CLINICA_VENDA_PROCEDIMENTO WITH CHECK ADD  CONSTRAINT FK_CVDPC_INDIC FOREIGN KEY(ID_PROCEDIMENTO)
 REFERENCES TB_PROCEDIMENTO (SQ_PROCEDIMENTO)
GO
ALTER TABLE TB_CLINICA_VENDA_PROCEDIMENTO WITH CHECK ADD  CONSTRAINT FK_CVDPC_CLVND FOREIGN KEY(ID_CLINICA_VENDA)
 REFERENCES TB_CLINICA_VENDA (SQ_CLINICA_VENDA)
GO
ALTER TABLE TB_CLINICA_VENDA_PROCEDIMENTO WITH CHECK ADD  CONSTRAINT FK_CVDPC_PESSO_PROFI FOREIGN KEY(ID_PESSOA_PROFISSIONAL)
 REFERENCES TB_PESSOA (SQ_PESSOA)
GO
CREATE PROCEDURE SP_CLINICA_VENDA_CAD
(
 @SQ_CLINICA_VENDA INT OUT,
 @ID_EMPRESA INT,
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
			INSERT INTO TB_CLINICA_VENDA
			(ID_EMPRESA, ID_PESSOA, ID_CONVENIO, ID_ATENDIMENTO, ID_AGENDAMENTO, ID_ORCAMENTO_CLIENTE,
			 ID_INDICACAO, ID_OPT_STATUS, DH_VENDA)
			VALUES
			(@ID_EMPRESA, @ID_PESSOA, @ID_CONVENIO, @ID_ATENDIMENTO, @ID_AGENDAMENTO, @ID_ORCAMENTO_CLIENTE,
			 @ID_INDICACAO, 737  /* Lan�ado */, @DH_VENDA)

			SET @SQ_CLINICA_VENDA = @@IDENTITY
		END
	ELSE
	  UPDATE TB_CLINICA_VENDA
		 SET ID_EMPRESA=@ID_EMPRESA,
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
CREATE PROCEDURE SQ_CLINICA_VENDA_PROCEDIMENTO_CAD
(
 @SQ_CLINICA_VENDA_PROCEDIMENTO INT,
 @ID_CLINICA_VENDA INT,
 @ID_PROCEDIMENTO INT,
 @ID_PESSOA_PROFISSIONAL INT,
 @VL_PROCEDIMENTO MONEY,
 @VL_DESCONTO MONEY,
 @DT_PREVISAO_FATURAMENTO DATE
)
AS
BEGIN
  IF ISNULL(@SQ_CLINICA_VENDA_PROCEDIMENTO, 0)  = 0
	  INSERT INTO TB_CLINICA_VENDA_PROCEDIMENTO
		(ID_CLINICA_VENDA, ID_PROCEDIMENTO, ID_PESSOA_PROFISSIONAL, ID_OPT_STATUS, VL_PROCEDIMENTO, VL_DESCONTO,DT_PREVISAO_FATURAMENTO)
		VALUES
		(@ID_CLINICA_VENDA, @ID_PROCEDIMENTO, @ID_PESSOA_PROFISSIONAL, 737  /* Lan�ado */, @VL_PROCEDIMENTO, @VL_DESCONTO,@DT_PREVISAO_FATURAMENTO)
	ELSE
	 UPDATE TB_CLINICA_VENDA_PROCEDIMENTO
	  SET ID_CLINICA_VENDA=@ID_CLINICA_VENDA,
				ID_PROCEDIMENTO=@ID_PROCEDIMENTO,
				ID_PESSOA_PROFISSIONAL=@ID_PESSOA_PROFISSIONAL,
				VL_PROCEDIMENTO=@VL_PROCEDIMENTO,
				VL_DESCONTO=@VL_DESCONTO,
				 DT_PREVISAO_FATURAMENTO=@DT_PREVISAO_FATURAMENTO
	  WHERE SQ_CLINICA_VENDA_PROCEDIMENTO = @SQ_CLINICA_VENDA_PROCEDIMENTO
END
GO
ALTER TABLE TB_MOVFINANCEIRA WITH CHECK ADD  CONSTRAINT FK_MVFNC_CLVND FOREIGN KEY(ID_CLINICA_VENDA)
 REFERENCES TB_CLINICA_VENDA (SQ_CLINICA_VENDA)
GO
ALTER PROCEDURE [dbo].[SP_MOVFINANCEIRA_CAD]
(
 @SQ_MOVFINANCEIRA int out,
 @ID_EMPRESA int ,
 @ID_OPT_TIPOMOVFINANCEIRA int ,
 @ID_OPT_STATUS int,
 @ID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO int,
 @ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS int,
 @ID_PESSOA int ,
 @ID_CONTAFINANCEIRA_CREDITO int ,
 @ID_CONTAFINANCEIRA_DEBITO int ,
 @ID_DOCUMENTOFISCAL INT,
 @ID_PEDIDO INT,
 @ID_ORDEMSERVICO INT,
 @ID_SEGMENTO INT,
 @ID_CONDICAOPAGAMENTO INT,
 @ID_CLINICA_VENDA INT,
 @DS_MOVFINANCEIRA varchar(200),
 @VL_MOVFINANCEIRA money,
 @VL_ORIGINAL money,
 @VL_DESCONTO money,
 @DT_MOVIMENTACAO date ,
 @DT_1_VENCIMENTO date ,
 @PC_ENTRADA decimal(18, 4) ,
 @PC_JUROS decimal(18, 4) ,
 @PC_DESCONTO decimal(18, 4) ,
 @VL_MULTA money ,
 @PC_MULTA decimal(18, 4) ,
 @CM_MOVFINANCEIRA varchar(MAX) 
)
AS
BEGIN
  DECLARE @CD_MOVFINANCEIRA VARCHAR(10)

  IF ISNULL(@SQ_MOVFINANCEIRA, 0) = 0
		BEGIN
			SELECT @CD_MOVFINANCEIRA = dbo.FC_EMPRESA_NOVO_CD_MOVFINANCEIRA(@ID_EMPRESA, @ID_OPT_TIPOMOVFINANCEIRA)

			EXEC SP_EMPRESA_NOVO_CD_MOVFINANCEIRA @ID_EMPRESA, @ID_OPT_TIPOMOVFINANCEIRA, @CD_MOVFINANCEIRA

			INSERT INTO TB_MOVFINANCEIRA
			(ID_EMPRESA, ID_OPT_TIPOMOVFINANCEIRA, ID_OPT_STATUS, ID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO,
			 ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS, ID_PESSOA, ID_CONTAFINANCEIRA_CREDITO, ID_CONTAFINANCEIRA_DEBITO,
			 ID_DOCUMENTOFISCAL,ID_PEDIDO,ID_ORDEMSERVICO, ID_SEGMENTO, ID_CONDICAOPAGAMENTO, ID_CLINICA_VENDA,
			 CD_MOVFINANCEIRA, DS_MOVFINANCEIRA,VL_MOVFINANCEIRA, VL_ORIGINAL, VL_DESCONTO, DT_MOVIMENTACAO,
			 DT_1_VENCIMENTO, PC_ENTRADA, PC_JUROS, PC_DESCONTO, VL_MULTA, PC_MULTA, CM_MOVFINANCEIRA)
			VALUES
			(@ID_EMPRESA, @ID_OPT_TIPOMOVFINANCEIRA, @ID_OPT_STATUS, @ID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO,
			 @ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS, @ID_PESSOA, @ID_CONTAFINANCEIRA_CREDITO, @ID_CONTAFINANCEIRA_DEBITO,
			 @ID_DOCUMENTOFISCAL,@ID_PEDIDO,@ID_ORDEMSERVICO, @ID_SEGMENTO, @ID_CONDICAOPAGAMENTO, @ID_CLINICA_VENDA,
			 @CD_MOVFINANCEIRA, @DS_MOVFINANCEIRA, @VL_MOVFINANCEIRA, @VL_ORIGINAL, @VL_DESCONTO, @DT_MOVIMENTACAO,
			 @DT_1_VENCIMENTO, @PC_ENTRADA, @PC_JUROS, @PC_DESCONTO, @VL_MULTA, @PC_MULTA, @CM_MOVFINANCEIRA)

			SELECT @SQ_MOVFINANCEIRA = @@IDENTITY
    END
  ELSE
		UPDATE TB_MOVFINANCEIRA
  	 SET ID_EMPRESA = @ID_EMPRESA,
				 ID_OPT_TIPOMOVFINANCEIRA = @ID_OPT_TIPOMOVFINANCEIRA,
				 ID_OPT_STATUS = ISNULL(@ID_OPT_STATUS, ID_OPT_STATUS),
				 ID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO = @ID_OPT_PERIODOCALCULOFINANCEIRO_DESCONTO,
				 ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS = @ID_OPT_PERIODOCALCULOFINANCEIRO_JUROS,
				 ID_PESSOA = @ID_PESSOA,
				 ID_CONTAFINANCEIRA_CREDITO = @ID_CONTAFINANCEIRA_CREDITO,
				 ID_CONTAFINANCEIRA_DEBITO = @ID_CONTAFINANCEIRA_DEBITO,
				 ID_DOCUMENTOFISCAL = ISNULL(@ID_DOCUMENTOFISCAL, ID_DOCUMENTOFISCAL),
				 ID_PEDIDO = ISNULL(@ID_PEDIDO, ID_PEDIDO),
				 ID_ORDEMSERVICO = ISNULL(@ID_ORDEMSERVICO, ID_ORDEMSERVICO),
				 ID_SEGMENTO = @ID_SEGMENTO,
				 ID_CONDICAOPAGAMENTO = @ID_CONDICAOPAGAMENTO,
				 ID_CLINICA_VENDA = @ID_CLINICA_VENDA,
				 DS_MOVFINANCEIRA = @DS_MOVFINANCEIRA,
				 VL_MOVFINANCEIRA = @VL_MOVFINANCEIRA,
				 VL_ORIGINAL = @VL_ORIGINAL,
				 VL_DESCONTO = @VL_DESCONTO,
				 DT_MOVIMENTACAO = ISNULL(@DT_MOVIMENTACAO, DT_MOVIMENTACAO),
				 DT_1_VENCIMENTO = @DT_1_VENCIMENTO,
				 PC_ENTRADA = @PC_ENTRADA,
				 PC_JUROS = @PC_JUROS,
				 PC_DESCONTO = @PC_DESCONTO,
				 VL_MULTA = @VL_MULTA,
				 PC_MULTA = @PC_MULTA,
				 CM_MOVFINANCEIRA = @CM_MOVFINANCEIRA
		WHERE SQ_MOVFINANCEIRA = @SQ_MOVFINANCEIRA

  RETURN
END