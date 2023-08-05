CREATE VIEW VW_PROCEDIMENTO_UTILIZACAO
AS
SELECT X.ID_PROCEDIMENTO, SUM(X.QTDE) QTDE_UTILIZACAO
 FROM (SELECT ID_PROCEDIMENTO, COUNT(*) QTDE
        FROM TB_CLINICA_VENDA_PROCEDIMENTO GROUP BY ID_PROCEDIMENTO
	   UNION ALL
	   SELECT ID_PROCEDIMENTO, COUNT(*) QTDE
	    FROM TB_CLINICA_PROCEDIMENTO GROUP BY ID_PROCEDIMENTO
	   UNION ALL
	   SELECT ID_PROCEDIMENTO, COUNT(*) QTDE
	    FROM TB_CLINICA_ATENDIMENTO GROUP BY ID_PROCEDIMENTO) X
 GROUP BY X.ID_PROCEDIMENTO
GO
ALTER TABLE TB_EMPRESA
 ADD DS_RECEITUARIO TEXT,
     DS_ATESTADO TEXT