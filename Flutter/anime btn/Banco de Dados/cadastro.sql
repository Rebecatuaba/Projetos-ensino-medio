-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Maio-2023 às 14:27
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `cadastro`
--
CREATE DATABASE IF NOT EXISTS `cadastro` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cadastro`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `agenda`
--

CREATE TABLE `agenda` (
  `ID` int(11) NOT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_animal` int(11) DEFAULT NULL,
  `dt_inicio` date DEFAULT NULL,
  `hr_inicio` time DEFAULT NULL,
  `dt_film` date DEFAULT NULL,
  `hr_film` time DEFAULT NULL,
  `dt_cadastro` date DEFAULT NULL,
  `ID_Empresa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `agenda_det`
--

CREATE TABLE `agenda_det` (
  `id_agenda` int(11) DEFAULT NULL,
  `id_servico` int(11) DEFAULT NULL,
  `ID_Empresa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `animal`
--

CREATE TABLE `animal` (
  `ID` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `id_tipo_animal` int(11) NOT NULL,
  `id_raca` int(11) NOT NULL,
  `dt_nasc` date NOT NULL,
  `dt_falec` date NOT NULL,
  `sexo` char(1) NOT NULL,
  `cor` varchar(40) NOT NULL,
  `microchip` varchar(40) NOT NULL,
  `castrado` tinyint(1) NOT NULL,
  `observacoes` varchar(250) NOT NULL,
  `id_cadastro` date NOT NULL,
  `id_empresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `animal`
--

INSERT INTO `animal` (`ID`, `id_cliente`, `nome`, `id_tipo_animal`, `id_raca`, `dt_nasc`, `dt_falec`, `sexo`, `cor`, `microchip`, `castrado`, `observacoes`, `id_cadastro`, `id_empresa`) VALUES
(1, 2, 'UwU', 1, 1, '2023-05-02', '2013-09-11', 'f', 'branco', 'sim', 2, 'kj', '2023-05-01', 3),
(3, 1, 'arthu', 1, 1, '1500-02-16', '2023-05-30', 'f', 'preto', '1', 2, 'ele é negro', '2004-02-25', 65);

-- --------------------------------------------------------

--
-- Estrutura da tabela `animal_anexos`
--

CREATE TABLE `animal_anexos` (
  `ID` int(11) NOT NULL,
  `anexo` varchar(100) NOT NULL,
  `id_empresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `animal_aplicacoes`
--

CREATE TABLE `animal_aplicacoes` (
  `ID` int(11) NOT NULL,
  `vacina` varchar(50) NOT NULL,
  `dt_aplicacao` date NOT NULL,
  `dt_prox_aplicacao` date NOT NULL,
  `id_empresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `animal_fotos`
--

CREATE TABLE `animal_fotos` (
  `ID` int(11) DEFAULT NULL,
  `foto` varchar(100) DEFAULT NULL,
  `dt_cadastro` date DEFAULT NULL,
  `ID_Empresa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `ID` int(11) NOT NULL,
  `nome` varchar(50) DEFAULT NULL,
  `endereco` varchar(100) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `cidade` varchar(50) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cp` varchar(10) DEFAULT NULL,
  `telefone` varchar(10) DEFAULT NULL,
  `celular` varchar(10) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `dt_cadastro` date DEFAULT NULL,
  `ID_Empresa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`ID`, `nome`, `endereco`, `bairro`, `cidade`, `estado`, `cp`, `telefone`, `celular`, `email`, `dt_cadastro`, `ID_Empresa`) VALUES
(1, 'wew', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(2, 'Maria', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `raca`
--

CREATE TABLE `raca` (
  `ID` int(11) NOT NULL,
  `id_tipo_animal` int(11) NOT NULL,
  `raca` varchar(50) NOT NULL,
  `id_empresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `raca`
--

INSERT INTO `raca` (`ID`, `id_tipo_animal`, `raca`, `id_empresa`) VALUES
(1, 1, 'dalmata', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `servicos`
--

CREATE TABLE `servicos` (
  `ID` int(11) NOT NULL,
  `servico` varchar(50) DEFAULT NULL,
  `duracao_estimada` int(11) DEFAULT NULL,
  `ID_Empresa` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `servicos`
--

INSERT INTO `servicos` (`ID`, `servico`, `duracao_estimada`, `ID_Empresa`) VALUES
(3, 'co', 1, 3),
(5, 'co', 1, 8);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tipo_animal`
--

CREATE TABLE `tipo_animal` (
  `ID` int(11) NOT NULL,
  `tipo_animal` varchar(50) NOT NULL,
  `id_empresa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tipo_animal`
--

INSERT INTO `tipo_animal` (`ID`, `tipo_animal`, `id_empresa`) VALUES
(1, 'Calvo', 3),
(2, 'bird', 3);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `agenda`
--
ALTER TABLE `agenda`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_animal` (`id_animal`);

--
-- Índices para tabela `agenda_det`
--
ALTER TABLE `agenda_det`
  ADD KEY `id_agenda` (`id_agenda`),
  ADD KEY `id_servico` (`id_servico`);

--
-- Índices para tabela `animal`
--
ALTER TABLE `animal`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_tipo_animal` (`id_tipo_animal`),
  ADD KEY `id_raca` (`id_raca`);

--
-- Índices para tabela `animal_anexos`
--
ALTER TABLE `animal_anexos`
  ADD KEY `ID` (`ID`);

--
-- Índices para tabela `animal_aplicacoes`
--
ALTER TABLE `animal_aplicacoes`
  ADD KEY `ID` (`ID`);

--
-- Índices para tabela `animal_fotos`
--
ALTER TABLE `animal_fotos`
  ADD KEY `ID` (`ID`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `raca`
--
ALTER TABLE `raca`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `id_tipo_animal` (`id_tipo_animal`);

--
-- Índices para tabela `servicos`
--
ALTER TABLE `servicos`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `tipo_animal`
--
ALTER TABLE `tipo_animal`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `animal`
--
ALTER TABLE `animal`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `raca`
--
ALTER TABLE `raca`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `tipo_animal`
--
ALTER TABLE `tipo_animal`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `agenda`
--
ALTER TABLE `agenda`
  ADD CONSTRAINT `agenda_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`ID`),
  ADD CONSTRAINT `agenda_ibfk_3` FOREIGN KEY (`id_animal`) REFERENCES `cliente` (`ID`),
  ADD CONSTRAINT `agenda_ibfk_4` FOREIGN KEY (`id_animal`) REFERENCES `animal` (`ID`);

--
-- Limitadores para a tabela `agenda_det`
--
ALTER TABLE `agenda_det`
  ADD CONSTRAINT `agenda_det_ibfk_1` FOREIGN KEY (`id_agenda`) REFERENCES `agenda` (`ID`),
  ADD CONSTRAINT `agenda_det_ibfk_2` FOREIGN KEY (`id_agenda`) REFERENCES `agenda` (`ID`),
  ADD CONSTRAINT `agenda_det_ibfk_3` FOREIGN KEY (`id_servico`) REFERENCES `servicos` (`ID`);

--
-- Limitadores para a tabela `animal`
--
ALTER TABLE `animal`
  ADD CONSTRAINT `animal_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`ID`),
  ADD CONSTRAINT `animal_ibfk_2` FOREIGN KEY (`id_tipo_animal`) REFERENCES `tipo_animal` (`ID`),
  ADD CONSTRAINT `animal_ibfk_3` FOREIGN KEY (`id_raca`) REFERENCES `raca` (`ID`);

--
-- Limitadores para a tabela `animal_anexos`
--
ALTER TABLE `animal_anexos`
  ADD CONSTRAINT `animal_anexos_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `animal` (`ID`);

--
-- Limitadores para a tabela `animal_aplicacoes`
--
ALTER TABLE `animal_aplicacoes`
  ADD CONSTRAINT `animal_aplicacoes_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `animal` (`ID`);

--
-- Limitadores para a tabela `animal_fotos`
--
ALTER TABLE `animal_fotos`
  ADD CONSTRAINT `animal_fotos_ibfk_1` FOREIGN KEY (`ID`) REFERENCES `animal` (`ID`);

--
-- Limitadores para a tabela `raca`
--
ALTER TABLE `raca`
  ADD CONSTRAINT `raca_ibfk_1` FOREIGN KEY (`id_tipo_animal`) REFERENCES `tipo_animal` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
