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
INSERT INTO TB_TIPO_OPCAO (SQ_TIPO_OPCAO, NO_TIPO_OPCAO) VALUES (120, 'Configuração de Tela')
GO
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (744 , 120, 'Contas a Receber - Consulta', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (745 , 120, 'Contas a Receber - Consulta', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (746 , 120, 'Atendimento\Vacinas - Cadastro', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (747 , 120, 'Atendimento\Médico - Antecedentes', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (748 , 120, 'Atendimento\Médico - Atestados', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (749 , 120, 'Atendimento\Médico - Outras Consultas do Paciente', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (750 , 120, 'Atendimento\Médico - Receituário', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (751 , 120, 'Atendimento\Médico - Relatório', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (752 , 120, 'Atendimento\Médico - Solicitação de Fisioterapia', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (753 , 120, 'Atendimento\Médico - Solicitação de Vacinas', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (754 , 120, 'Atendimento\Médico - Tela Inicial', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (755 , 120, 'Atendimento\Médico - Tela de atendimento', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (756 , 120, 'Atendimento\Médico - Solicitação de Exames- Tela Maximizada', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (757 , 120, 'Atendimento\Médico - Solicitação de Exames Citológico', 'S')
GO
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (758 , 120, 'Botão - Atender', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (759 , 120, 'Botão - Atendimentos Realizados', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (760 , 120, 'Botão - Chamar', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (761 , 120, 'Botão - Fechar', 'S')
INSERT INTO TB_OPCAO (SQ_OPCAO, ID_TIPO_OPCAO, NO_OPCAO, IC_ATIVO) VALUES (762 , 120, 'Botão - Minhas Faturas', 'S')
GO
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (744, 'Formulários\Financeiro\Contas a receber - Consulta.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (745, 'Formulários\Financeiro\Contas a receber - Consulta.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (746, 'Formulários\Médico - Atendimento\Vacinas - Cadastro.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (747, 'Formulários\Médico - Atendimento\Médico - Antecedentes.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (748, 'Formulários\Médico - Atendimento\Médico - Atestados.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (749, 'Formulários\Médico - Atendimento\Médico - Outras Consultas do Paciente.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (750, 'Formulários\Médico - Atendimento\Médico - Receituário.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (751, 'Formulários\Médico - Atendimento\Médico - Relatório.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (752, 'Formulários\Médico - Atendimento\Médico - Solicitação de Fisioterapia.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (753, 'Formulários\Médico - Atendimento\Médico - Solicitação de Vacinas.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (754, 'Formulários\Médico - Atendimento\Médico 01 - Tela Inicial.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (755, 'Formulários\Médico - Atendimento\Médico 02 - Tela de atendimento.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (756, 'Formulários\Médico - Atendimento\Médico 03 - Solicitação de Exames- Tela Maximizada.jpg')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (757, 'Formulários\Médico - Atendimento\Médico 04 - Solicitação de Exames Citológico.jpg')
GO
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (758, 'Formulários\Botao\BTN_Atender_##.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (759, 'Formulários\Botao\BTN_AtendimentosRealizados_##.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (760, 'Formulários\Botao\BTN_Chamar_##.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (761, 'Formulários\Botao\BTN_Fechar_##.png')
INSERT INTO TB_CONFIG_TELA (ID_TELA, DS_PATH_IMAGEM_FUNDO) VALUES (762, 'Formulários\Botao\BTN_MinhasFaturas_##.png')