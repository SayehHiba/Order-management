-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 04, 2021 at 04:30 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.3.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gestiondescommandes`
--

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

CREATE TABLE `clients` (
  `codeclt` varchar(20) NOT NULL,
  `nom` varchar(30) NOT NULL,
  `prenom` varchar(30) NOT NULL,
  `tel` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`codeclt`, `nom`, `prenom`, `tel`) VALUES
('2341692', 'sayeh', 'hiba', '80374932');

-- --------------------------------------------------------

--
-- Table structure for table `commande`
--

CREATE TABLE `commande` (
  `codecmd` varchar(20) NOT NULL,
  `datecmd` date NOT NULL,
  `codeclt` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `commande`
--

INSERT INTO `commande` (`codecmd`, `datecmd`, `codeclt`) VALUES
('1', '2018-06-05', '2341692'),
('2', '2018-06-13', '2341692');

-- --------------------------------------------------------

--
-- Table structure for table `ligcommande`
--

CREATE TABLE `ligcommande` (
  `codeprod` varchar(20) NOT NULL,
  `codecmd` varchar(20) NOT NULL,
  `qtcom` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ligcommande`
--

INSERT INTO `ligcommande` (`codeprod`, `codecmd`, `qtcom`) VALUES
('02', '4', 5),
('02', '1', 2),
('04', '1', 5);

-- --------------------------------------------------------

--
-- Table structure for table `produit`
--

CREATE TABLE `produit` (
  `codeprod` varchar(20) NOT NULL,
  `libelle` varchar(20) NOT NULL,
  `prixunitp` float NOT NULL,
  `qtStock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produit`
--

INSERT INTO `produit` (`codeprod`, `libelle`, `prixunitp`, `qtStock`) VALUES
('01', 'parfum', 20, 42),
('02', 'savons', 3, 83),
('03', 'fonds de teint', 60, 141),
('04', 'masques de beauté', 15, 95),
('05', 'démaquillage', 40, 50);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`codeclt`);

--
-- Indexes for table `commande`
--
ALTER TABLE `commande`
  ADD PRIMARY KEY (`codecmd`),
  ADD KEY `codeclt` (`codeclt`);

--
-- Indexes for table `ligcommande`
--
ALTER TABLE `ligcommande`
  ADD KEY `codeprod` (`codeprod`),
  ADD KEY `codecmd` (`codecmd`);

--
-- Indexes for table `produit`
--
ALTER TABLE `produit`
  ADD PRIMARY KEY (`codeprod`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
