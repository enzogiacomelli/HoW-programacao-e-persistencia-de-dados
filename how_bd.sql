-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 25-Set-2020 às 18:44
-- Versão do servidor: 10.4.14-MariaDB
-- versão do PHP: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `how_bd`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome_cliente` varchar(30) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `telefone_cliente` varchar(13) NOT NULL,
  `cliente_excluido` int(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nome_cliente`, `cpf`, `telefone_cliente`, `cliente_excluido`) VALUES
(1, 'Enzo Giacomelli', '089,587,458-65', '(47)3368-7878', 0),
(3, 'teste 3', '555,555,555-55', '(47)3658-9874', 1),
(4, 'teste 2', '222,222,222-22', '(33)3333-3333', 0),
(19, '', '   ,   ,   -', '(  )    -', 1),
(20, '', '   ,   ,   -', '(  )    -', 1),
(21, 'Enzo Giacomelli', '089,587,458-65', '(47)3368-7878', 1),
(22, 'jjj', '   ,   ,   -', '(  )    -', 1),
(23, '', '   ,   ,   -', '(  )    -', 1),
(24, '', '   ,   ,   -', '(  )    -', 1),
(25, '', '   ,   ,   -', '(  )    -', 1),
(26, 'uu', '   ,   ,   -', '(  )    -', 1),
(27, 'ee', '   ,   ,   -', '(  )    -', 1),
(28, 'e', '   ,  5,   -', '(  )    - 55', 1),
(29, '', '   ,   ,   -', '(  )    -', 1),
(30, '', '   ,   ,   -', '(  )    -', 1),
(31, '     o', '   ,   ,   -', '(  )    -', 1),
(32, '', '   ,   ,   -', '(  )    -', 1),
(33, '', '   ,   ,   -5', '(  )    -', 1),
(34, 'o', '   ,   ,   -', '(44)4444-4444', 1),
(35, 'o', '   ,   ,   -', '(44)4444-4444', 1),
(36, 'teste 1', '444,444,444-44', '(47)3365-9742', 1),
(37, 'teste 1', '444,444,444-44', '(47)3365-9742', 1),
(38, ' ', '   ,   ,   -', '(  )    -', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `configuracoes`
--

CREATE TABLE `configuracoes` (
  `numero_total_mesas` int(3) NOT NULL,
  `nome_estabelecimento` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `configuracoes`
--

INSERT INTO `configuracoes` (`numero_total_mesas`, `nome_estabelecimento`) VALUES
(20, 'hands on work');

-- --------------------------------------------------------

--
-- Estrutura da tabela `mesa`
--

CREATE TABLE `mesa` (
  `id_mesa` int(11) NOT NULL,
  `id_reserva_mesa` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `mesa`
--

INSERT INTO `mesa` (`id_mesa`, `id_reserva_mesa`) VALUES
(1, 2),
(2, 0),
(3, 0),
(4, 0),
(5, 0),
(6, 0),
(7, 0),
(8, 0),
(9, 0),
(10, 0),
(11, 0),
(12, 0),
(13, 0),
(14, 0),
(15, 0),
(16, 0),
(17, 0),
(18, 0),
(19, 0),
(20, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `reservas`
--

CREATE TABLE `reservas` (
  `id_reserva` int(11) NOT NULL,
  `id_mesa_reservada` int(11) NOT NULL,
  `id_cliente_reserva` int(11) NOT NULL,
  `horario` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `reservas`
--

INSERT INTO `reservas` (`id_reserva`, `id_mesa_reservada`, `id_cliente_reserva`, `horario`) VALUES
(1, 1, 1, '23:00:00'),
(2, 2, 2, '22:22:22'),
(3, 3, 3, '10:00:00'),
(4, 4, 4, '12:00:00'),
(5, 5, 5, '12:00:00'),
(6, 6, 6, '13:30:00'),
(7, 7, 7, '15:00:00'),
(8, 10, 10, '14:00:00'),
(9, 15, 9, '15:30:00'),
(10, 0, 0, '00:00:00');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Índices para tabela `mesa`
--
ALTER TABLE `mesa`
  ADD PRIMARY KEY (`id_mesa`);

--
-- Índices para tabela `reservas`
--
ALTER TABLE `reservas`
  ADD PRIMARY KEY (`id_reserva`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT de tabela `mesa`
--
ALTER TABLE `mesa`
  MODIFY `id_mesa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `reservas`
--
ALTER TABLE `reservas`
  MODIFY `id_reserva` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
