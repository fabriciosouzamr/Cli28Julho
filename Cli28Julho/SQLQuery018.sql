Use Cli28Julho
GO
USE [Cli28Julho]
GO

/****** Object:  StoredProcedure [dbo].[SP_ATENDIMENTO_CAD]    Script Date: 01/06/2020 23:57:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_ATENDIMENTO_CAD]
(
	@SQ_ATENDIMENTO int output,
	@CD_ATENDIMENTO VARCHAR(10) OUTPUT,
	@ID_EMPRESA int,
	@ID_PESSOA int,
	@ID_CONVENIO int,
	@ID_PESSOA_PROFISSIONAL int,
	@ID_TIPO_CONSULTA int,
	@ID_OPT_STATUS_ATENDIMENTO int,
	@ID_OPT_TIPOSAIDA int,
	@ID_OPT_TIPODOENCA int,
	@ID_AGENDAMENTO INT,
	@NR_DIA_TEMPODOENCA int,
	@ID_OPT_TEMPODOENCA int,
	@ID_OPT_INDICACAOACIDENTE int,
	@ID_PROCEDIMENTO int,
	@CD_IDENTIFICACAO_CONVENIO varchar(30),
	@DH_ATENDIMENTO datetime,
	@DH_FINALIZACAO datetime,
	@DS_QUEIXAPRINCIPAL varchar(MAX),
	@DS_OUTRASINFORMACOES varchar(MAX)
)
AS
BEGIN
  IF ISNULL(@SQ_ATENDIMENTO, 0) = 0
		BEGIN
			SELECT @CD_ATENDIMENTO = dbo.FC_EMPRESA_NOVO_CD_ATENDIMENTO(@ID_EMPRESA)

			UPDATE TB_EMPRESA SET CD_ATENDIMENTO = @CD_ATENDIMENTO WHERE ID_EMPRESA = @ID_EMPRESA

			INSERT INTO TB_ATENDIMENTO
			(ID_EMPRESA, ID_PESSOA, ID_CONVENIO, ID_PESSOA_PROFISSIONAL, ID_TIPO_CONSULTA, ID_AGENDAMENTO,
			 ID_OPT_TIPOSAIDA, ID_OPT_TIPODOENCA, NR_DIA_TEMPODOENCA, ID_OPT_TEMPODOENCA, ID_OPT_INDICACAOACIDENTE,
			 ID_PROCEDIMENTO, CD_ATENDIMENTO, CD_IDENTIFICACAO_CONVENIO, DH_ATENDIMENTO, DH_FINALIZACAO,
			 DS_QUEIXAPRINCIPAL, DS_OUTRASINFORMACOES, ID_OPT_STATUS_ATENDIMENTO)
			VALUES
			(@ID_EMPRESA, @ID_PESSOA, @ID_CONVENIO, @ID_PESSOA_PROFISSIONAL, @ID_TIPO_CONSULTA, @ID_AGENDAMENTO,
			 @ID_OPT_TIPOSAIDA, @ID_OPT_TIPODOENCA, @NR_DIA_TEMPODOENCA, @ID_OPT_TEMPODOENCA, @ID_OPT_INDICACAOACIDENTE,
			 @ID_PROCEDIMENTO, @CD_ATENDIMENTO, @CD_IDENTIFICACAO_CONVENIO, ISNULL(@DH_ATENDIMENTO, GETDATE()), @DH_FINALIZACAO,
			 @DS_QUEIXAPRINCIPAL, @DS_OUTRASINFORMACOES, @ID_OPT_STATUS_ATENDIMENTO)

			SELECT @SQ_ATENDIMENTO = @@IDENTITY
		END
  ELSE
    UPDATE TB_ATENDIMENTO
		 SET ID_EMPRESA = @ID_EMPRESA,
				 ID_PESSOA = @ID_PESSOA,
				 ID_CONVENIO = @ID_CONVENIO,
				 ID_PESSOA_PROFISSIONAL = @ID_PESSOA_PROFISSIONAL,
				 ID_TIPO_CONSULTA = @ID_TIPO_CONSULTA,
				 ID_OPT_TIPOSAIDA = @ID_OPT_TIPOSAIDA,
				 ID_OPT_TIPODOENCA = @ID_OPT_TIPODOENCA,
				 ID_AGENDAMENTO = @ID_AGENDAMENTO,
				 ID_OPT_TEMPODOENCA = @ID_OPT_TEMPODOENCA,
				 ID_OPT_INDICACAOACIDENTE = @ID_OPT_INDICACAOACIDENTE,
				 ID_PROCEDIMENTO = @ID_PROCEDIMENTO,
				 ID_OPT_STATUS_ATENDIMENTO = @ID_OPT_STATUS_ATENDIMENTO,
				 NR_DIA_TEMPODOENCA = @NR_DIA_TEMPODOENCA,
				 CD_IDENTIFICACAO_CONVENIO = @CD_IDENTIFICACAO_CONVENIO,
				 DH_ATENDIMENTO = ISNULL(@DH_ATENDIMENTO, DH_ATENDIMENTO),
				 DH_FINALIZACAO = @DH_FINALIZACAO,
				 DS_QUEIXAPRINCIPAL = @DS_QUEIXAPRINCIPAL,
				 DS_OUTRASINFORMACOES = @DS_OUTRASINFORMACOES
	 WHERE SQ_ATENDIMENTO = @SQ_ATENDIMENTO

  IF @ID_OPT_STATUS_ATENDIMENTO = 51 AND ISNULL(@ID_AGENDAMENTO, 0) <> 0
		UPDATE AG
		 SET DH_CHEGADA = ISNULL(DH_CHEGADA, @DH_FINALIZACAO),
				 DH_SAIDA = @DH_FINALIZACAO,
				 ID_OPT_STATUS = 41
		 FROM TB_AGENDAMENTO AG
		WHERE SQ_AGENDAMENTO = @ID_AGENDAMENTO
END