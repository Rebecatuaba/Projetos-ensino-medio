-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 28/09/2023 às 15:34
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_curso_online`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `aluno`
--

CREATE TABLE `aluno` (
  `ID_ALUNO` int(11) NOT NULL,
  `NOME_ALUNO` varchar(255) DEFAULT NULL,
  `DATA_NASCIMENTO` date DEFAULT NULL,
  `E_MAIL` varchar(255) DEFAULT NULL,
  `GRAU_ESCOLARIEDADE` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `aluno`
--

INSERT INTO `aluno` (`ID_ALUNO`, `NOME_ALUNO`, `DATA_NASCIMENTO`, `E_MAIL`, `GRAU_ESCOLARIEDADE`) VALUES
(1, 'Antonio Carlos Teste Teste', '2010-10-10', 'teste@teste.com.br', 'Sem Escolariedade'),
(2, 'Maria Manuela', '2010-10-10', 'contato@teste.com.br', 'Ensino Médio'),
(3, 'Pedro Paulo', '2010-10-10', 'faleconosco@teste.com.br', 'Ensino Médio'),
(4, 'Jose Silva Santos', '2010-10-10', 'gerencia@teste.com.br', 'Superior Completo'),
(5, 'Mauricio Santos', '2010-10-10', 'marketing@teste.com.br', 'Superior Completo'),
(6, 'Paula Maria', '2010-10-10', 'teste@teste.com.br', 'Sem Escolariedade'),
(7, 'Raquel Ferreira', '2010-10-10', 'contato@teste.com.br', 'Ensino Médio'),
(8, 'Larissa Santos', '2010-10-10', 'faleconosco@teste.com.br', 'Ensino Médio'),
(9, 'Emanuelli Rodrigues', '2010-10-10', 'gerencia@teste.com.br', 'Superior Completo'),
(10, 'Neemias Santos', '2010-10-10', 'marketing@teste.com.br', 'Superior Completo'),
(11, 'Paula Maria', '2010-10-10', 'teste@teste.com.br', 'Sem Escolariedade'),
(12, 'Raquel Ferreira', '2010-10-10', 'contato@teste.com.br', 'Ensino Médio'),
(13, 'Larissa Santos', '2010-10-10', 'faleconosco@teste.com.br', 'Ensino Médio'),
(14, 'Emanuelli Rodrigues', '2010-10-10', 'gerencia@teste.com.br', 'Superior Completo'),
(15, 'Neemias Santos', '2010-10-10', 'marketing@teste.com.br', 'Superior Completo'),
(16, 'Paula Maria', '2010-10-10', 'teste@teste.com.br', 'Sem Escolariedade'),
(17, 'Raquel Ferreira', '2010-10-10', 'contato@teste.com.br', 'Ensino Médio'),
(18, 'Larissa Santos', '2010-10-10', 'faleconosco@teste.com.br', 'Ensino Médio'),
(19, 'Emanuelli Rodrigues', '2010-10-10', 'gerencia@teste.com.br', 'Superior Completo'),
(20, 'Neemias Santos', '2010-10-10', 'marketing@teste.com.br', 'Superior Completo'),
(22, 'Paula Maria', '2000-01-01', 'teste@teste.com.br', 'Sem Escolariedade'),
(23, 'Raquel Ferreira', '2000-01-01', 'contato@teste.com.br', 'Ensino Médio'),
(24, 'Larissa Santos', '2000-01-01', 'faleconosco@teste.com.br', 'Ensino Médio'),
(25, 'Emanuelli Rodrigues', '2000-01-01', 'gerencia@teste.com.br', 'Superior Completo');

-- --------------------------------------------------------

--
-- Estrutura para tabela `aluno_curso`
--

CREATE TABLE `aluno_curso` (
  `ID_ALUNO_CURSO` int(11) NOT NULL,
  `ID_ALUNO` int(11) NOT NULL,
  `ID_CURSO` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `aluno_curso`
--

INSERT INTO `aluno_curso` (`ID_ALUNO_CURSO`, `ID_ALUNO`, `ID_CURSO`) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 1),
(5, 5, 2),
(6, 6, 3);

-- --------------------------------------------------------

--
-- Estrutura para tabela `curso`
--

CREATE TABLE `curso` (
  `ID_CURSO` int(11) NOT NULL,
  `NOME_CURSO` varchar(255) DEFAULT NULL,
  `DESCRICAO_CURSO` text DEFAULT NULL,
  `MATERIAS_CURSOS` text DEFAULT NULL,
  `DURACAO_CURSO` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `curso`
--

INSERT INTO `curso` (`ID_CURSO`, `NOME_CURSO`, `DESCRICAO_CURSO`, `MATERIAS_CURSOS`, `DURACAO_CURSO`) VALUES
(1, 'Propaganda e MKT', 'Publicidade e Propaganda', 'Sociologia | Comunicação | Design Grafico | Teoria do Consumidor', '4 Anos'),
(2, 'Sistema de Informação', 'Curso de Tecnologia', 'Programação I e II | Banco de Dados | Redes de Computador | Sistema Operacionais', '3 Anos'),
(3, 'Administração', 'Curso de Administração', 'Administracao I e II | Economia | Contabilidade | MKT', '4 Anos'),
(4, 'MATEMATICA', 'CURSO SOBRE MATEMATICA BÁSICA', 'OPERADORES ARITIMÉTICOS, PERMUTAÇÃO, FUNÇÕES', '1 ANO');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `aluno`
--
ALTER TABLE `aluno`
  ADD PRIMARY KEY (`ID_ALUNO`);

--
-- Índices de tabela `aluno_curso`
--
ALTER TABLE `aluno_curso`
  ADD PRIMARY KEY (`ID_ALUNO_CURSO`);

--
-- Índices de tabela `curso`
--
ALTER TABLE `curso`
  ADD PRIMARY KEY (`ID_CURSO`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `aluno`
--
ALTER TABLE `aluno`
  MODIFY `ID_ALUNO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT de tabela `aluno_curso`
--
ALTER TABLE `aluno_curso`
  MODIFY `ID_ALUNO_CURSO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `curso`
--
ALTER TABLE `curso`
  MODIFY `ID_CURSO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
