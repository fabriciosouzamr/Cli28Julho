CREATE TABLE TB_CLINICA_VACINA
(
 SQ_CLINICA_VACINA INT IDENTITY(1, 1) NOT NULL,
 ID_CLINICA_ATENDIMENTO INT NOT NULL,
 ID_PESSOA INT NOT NULL,
 ID_VACINA INT NOT NULL,
 DT_LANCAMENTO DATE NOT NULL,
 QT_DOSAGEM INT NOT NULL,
 CM_CLINICA_VACINA VARCHAR(8000)
)
GO
ALTER TABLE TB_CLINICA_VACINA ADD CONSTRAINT PK_CLINICA_VACINA
 PRIMARY KEY CLUSTERED (SQ_CLINICA_VACINA)
GO
ALTER TABLE TB_CLINICA_VACINA WITH CHECK ADD CONSTRAINT FK_CLVCN_CLATD FOREIGN KEY(ID_CLINICA_ATENDIMENTO)
 REFERENCES TB_CLINICA_ATENDIMENTO (SQ_CLINICA_ATENDIMENTO)
GO
ALTER TABLE TB_CLINICA_VACINA WITH CHECK ADD CONSTRAINT FK_CLVCN_PESSO FOREIGN KEY(ID_PESSOA)
 REFERENCES TB_PESSOA (SQ_PESSOA)
GO
ALTER TABLE TB_CLINICA_VACINA WITH CHECK ADD CONSTRAINT FK_CLVCN_VACIN FOREIGN KEY(ID_VACINA)
 REFERENCES TB_VACINA (SQ_VACINA)
GO
CREATE PROCEDURE SP_CLINICA_VACINA_CAD
(
 @SQ_CLINICA_VACINA INT,
 @ID_CLINICA_ATENDIMENTO INT,
 @ID_PESSOA INT,
 @ID_VACINA INT,
 @DT_LANCAMENTO DATE,
 @QT_DOSAGEM INT,
 @CM_CLINICA_VACINA VARCHAR(8000)
)
AS
BEGIN
  IF ISNULL(@SQ_CLINICA_VACINA, 0) = 0
	  INSERT INTO TB_CLINICA_VACINA
		(ID_CLINICA_ATENDIMENTO, ID_PESSOA, ID_VACINA, DT_LANCAMENTO, QT_DOSAGEM, CM_CLINICA_VACINA)
		VALUES
		(@ID_CLINICA_ATENDIMENTO, @ID_PESSOA, @ID_VACINA, @DT_LANCAMENTO, @QT_DOSAGEM, @CM_CLINICA_VACINA)
	ELSE
	  UPDATE TB_CLINICA_VACINA
		 SET ID_CLINICA_ATENDIMENTO = @ID_CLINICA_ATENDIMENTO,
				 ID_PESSOA = @ID_PESSOA,
				 ID_VACINA = @ID_VACINA,
				 DT_LANCAMENTO = @DT_LANCAMENTO,
				 QT_DOSAGEM = @QT_DOSAGEM,
				 CM_CLINICA_VACINA = @CM_CLINICA_VACINA
		 WHERE SQ_CLINICA_VACINA = @SQ_CLINICA_VACINA
END