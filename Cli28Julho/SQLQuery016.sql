CREATE TABLE TB_CONFIG_TELA
(
 ID_TELA INT NOT NULL,
 DS_PATH_IMAGEM_FUNDO VARCHAR(8000) NOT NULL
)
GO
ALTER TABLE TB_CONFIG_TELA ADD CONSTRAINT	PK_CONFIG_TELA
 PRIMARY KEY CLUSTERED (ID_TELA)
GO
ALTER TABLE TB_CONFIG_TELA WITH CHECK ADD CONSTRAINT FK_CFGTL_OPCAO_TELA FOREIGN KEY(ID_TELA)
 REFERENCES TB_OPCAO (SQ_OPCAO)
GO
INSERT INTO TB_TIPO_OPCAO (SQ_TIPO_OPCAO, NO_TIPO_OPCAO) VALUES (120, 'Configura��o de Tela')
GO
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (744 , 120, 'Contas a Receber - Consulta', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (745 , 120, 'Contas a Receber - Consulta', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (746 , 120, 'Atendimento\Vacinas - Cadastro', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (747 , 120, 'Atendimento\M�dico - Antecedentes', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (748 , 120, 'Atendimento\M�dico - Atestados', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (749 , 120, 'Atendimento\M�dico - Outras Consultas do Paciente', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (750 , 120, 'Atendimento\M�dico - Receitu�rio', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (751 , 120, 'Atendimento\M�dico - Relat�rio', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (752 , 120, 'Atendimento\M�dico - Solicita��o de Fisioterapia', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (753 , 120, 'Atendimento\M�dico - Solicita��o de Vacinas', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (754 , 120, 'Atendimento\M�dico - Tela Inicial', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (755 , 120, 'Atendimento\M�dico - Tela de atendimento', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (756 , 120, 'Atendimento\M�dico - Solicita��o de Exames- Tela Maximizada', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (757 , 120, 'Atendimento\M�dico - Solicita��o de Exames Citol�gico', 'S')
GO
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (758 , 120, 'Bot�o - Atender', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (759 , 120, 'Bot�o - Atendimentos Realizados', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (760 , 120, 'Bot�o - Chamar', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (761 , 120, 'Bot�o - Fechar', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (762 , 120, 'Bot�o - Minhas Faturas', 'S')
GO
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (744, 'Formul�rios\Financeiro\Contas a receber - Consulta.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (745, 'Formul�rios\Financeiro\Contas a receber - Consulta.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (746, 'Formul�rios\M�dico - Atendimento\Vacinas - Cadastro.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (747, 'Formul�rios\M�dico - Atendimento\M�dico - Antecedentes.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (748, 'Formul�rios\M�dico - Atendimento\M�dico - Atestados.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (749, 'Formul�rios\M�dico - Atendimento\M�dico - Outras Consultas do Paciente.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (750, 'Formul�rios\M�dico - Atendimento\M�dico - Receitu�rio.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (751, 'Formul�rios\M�dico - Atendimento\M�dico - Relat�rio.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (752, 'Formul�rios\M�dico - Atendimento\M�dico - Solicita��o de Fisioterapia.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (753, 'Formul�rios\M�dico - Atendimento\M�dico - Solicita��o de Vacinas.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (754, 'Formul�rios\M�dico - Atendimento\M�dico 01 - Tela Inicial.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (755, 'Formul�rios\M�dico - Atendimento\M�dico 02 - Tela de atendimento.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (756, 'Formul�rios\M�dico - Atendimento\M�dico 03 - Solicita��o de Exames- Tela Maximizada.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (757, 'Formul�rios\M�dico - Atendimento\M�dico 04 - Solicita��o de Exames Citol�gico.jpg')
GO
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (758, 'Formul�rios\Botao\BTN_Atender_##.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (759, 'Formul�rios\Botao\BTN_AtendimentosRealizados_##.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (760, 'Formul�rios\Botao\BTN_Chamar_##.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (761, 'Formul�rios\Botao\BTN_Fechar_##.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (762, 'Formul�rios\Botao\BTN_MinhasFaturas_##.png')