ALTER VIEW VW_ORCAMENTO_CLIENTE_ABERTO
AS
SELECT *
 FROM VW_ORCAMENTO_CLIENTE
 WHERE ID_OPT_STATUS IN (732, 741)
   AND DT_VALIDADE >= CAST(GETDATE() AS DATE)
GO
ALTER TABLE TB_ESPECIALIDADE
 ADD IC_ATIVO CHAR(1)
GO
UPDATE TB_ESPECIALIDADE SET IC_ATIVO = 'S'