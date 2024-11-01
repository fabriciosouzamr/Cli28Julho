ALTER VIEW [dbo].[VW_PESSOA_HORARIO]
AS
SELECT PSHRR.*, EMPRE.NO_PESSOA NO_EMPRESA, PESSO.NO_PESSOA, PESSO.CD_CPF_CNPJ, OPCAO_DISMN.NO_OPCAO NO_OPT_DIA_SEMANA, OPCAO_ATIVO.NO_OPCAO NO_OPT_ATIVO, OPCAO_DISMN.CD_OPCAO CD_OPT_DIA_SEMANA, PROCE.CD_PROCEDIMENTO, PROCE.NO_PROCEDIMENTO
 FROM TB_PESSOA_HORARIO PSHRR
  INNER JOIN TB_PESSOA PESSO ON PESSO.SQ_PESSOA = PSHRR.ID_PESSOA
  INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = PSHRR.ID_EMPRESA
   LEFT JOIN TB_PROCEDIMENTO PROCE ON PROCE.SQ_PROCEDIMENTO = PSHRR.ID_PROCEDIMENTO
	INNER JOIN TB_OPCAO OPCAO_DISMN ON OPCAO_DISMN.SQ_OPCAO = PSHRR.ID_OPT_DIA_SEMANA
	INNER JOIN TB_OPCAO OPCAO_ATIVO ON OPCAO_ATIVO.SQ_OPCAO = PSHRR.ID_OPT_ATIVO
GO
UPDATE TB_OPCAO SET NO_OPCAO = 'Exclu�do' WHERE SQ_OPCAO = 733
GO
UPDATE TB_OPCAO SET NO_OPCAO = 'Vendido' WHERE SQ_OPCAO = 735
GO
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (741, 117, 'Em Aberto', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (742, 117, 'Fechado', 'S')
GO
CREATE VIEW VW_ORCAMENTO_CLIENTE
AS
SELECT OCCLI.SQ_ORCAMENTO_CLIENTE,
			 OCCLI.ID_EMPRESA,
			 OCCLI.ID_PESSOA,
			 OCCLI.ID_CONVENIO,
			 OCCLI.ID_FINANCIAMENTO,
			 OCCLI.ID_AGENDAMENTO,
			 OCCLI.ID_OPT_STATUS,
			 STATU.NO_OPCAO NO_OPT_STATUS,
			 EMPRE.NO_PESSOA NO_EMPRESA,
			 OCCLI.CD_ORCAMENTO_CLIENTE,
			 OCCLI.DH_ORCAMENTO_CLIENTE,
			 OCCLI.DT_VALIDADE
 FROM TB_ORCAMENTO_CLIENTE OCCLI
  INNER JOIN TB_PESSOA EMPRE ON EMPRE.SQ_PESSOA = OCCLI.ID_EMPRESA
  INNER JOIN TB_CONVENIO CONVE ON CONVE.SQ_CONVENIO = OCCLI.ID_CONVENIO
   LEFT JOIN TB_FINANCIAMENTO FINAN ON FINAN.SQ_FINANCIAMENTO = OCCLI.ID_FINANCIAMENTO
   LEFT JOIN TB_AGENDAMENTO AGEND ON AGEND.SQ_AGENDAMENTO = OCCLI.ID_AGENDAMENTO
	 LEFT JOIN TB_OPCAO STATU ON STATU.SQ_OPCAO = OCCLI.ID_OPT_STATUS
GO
CREATE VIEW VW_ORCAMENTO_CLIENTE_ABERTO
AS
SELECT *
 FROM VW_ORCAMENTO_CLIENTE
 WHERE ID_OPT_STATUS IN (732, 741)