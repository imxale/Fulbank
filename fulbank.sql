-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 21 mars 2022 à 17:52
-- Version du serveur :  5.7.35
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `fulbank`
--

-- --------------------------------------------------------

--
-- Structure de la table `accountuser`
--

DROP TABLE IF EXISTS `accountuser`;
CREATE TABLE IF NOT EXISTS `accountuser` (
  `IDACCOUNT` int(11) NOT NULL AUTO_INCREMENT,
  `IDTYPE` int(11) NOT NULL,
  `CAP` int(11) DEFAULT NULL,
  `BALANCE` int(11) DEFAULT NULL,
  `IDPERSON` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDACCOUNT`),
  KEY `IDPERSON` (`IDPERSON`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Déchargement des données de la table `accountuser`
--

INSERT INTO `accountuser` (`IDACCOUNT`, `IDTYPE`, `CAP`, `BALANCE`, `IDPERSON`) VALUES
(1, 1, 0, 190, 33),
(2, 2, 0, 1400, 33),
(3, 3, 0, 100140, 33),
(4, 1, 0, 35, 34),
(5, 2, 0, 200, 34);

-- --------------------------------------------------------

--
-- Structure de la table `accountype`
--

DROP TABLE IF EXISTS `accountype`;
CREATE TABLE IF NOT EXISTS `accountype` (
  `IDACCOUNTTYPE` int(11) NOT NULL AUTO_INCREMENT,
  `TYPE` varchar(100) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`IDACCOUNTTYPE`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Déchargement des données de la table `accountype`
--

INSERT INTO `accountype` (`IDACCOUNTTYPE`, `TYPE`) VALUES
(1, 'Current account'),
(2, 'Saving account'),
(3, 'Homeloanplan');

-- --------------------------------------------------------

--
-- Structure de la table `crypto`
--

DROP TABLE IF EXISTS `crypto`;
CREATE TABLE IF NOT EXISTS `crypto` (
  `IDCRYPTO` int(2) NOT NULL AUTO_INCREMENT,
  `NAME` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `EUROVALUE` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`IDCRYPTO`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `crypto`
--

INSERT INTO `crypto` (`IDCRYPTO`, `NAME`, `EUROVALUE`) VALUES
(1, 'Bitcoin', '10.00'),
(2, 'Ethereum', '100.00'),
(3, 'Basic Attention Token', '5542.00');

-- --------------------------------------------------------

--
-- Structure de la table `person`
--

DROP TABLE IF EXISTS `person`;
CREATE TABLE IF NOT EXISTS `person` (
  `IDPERSON` int(2) NOT NULL AUTO_INCREMENT,
  `IDROLE` int(2) NOT NULL,
  `NAME` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `FNAME` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `BIRTH` date DEFAULT NULL,
  `MAIL` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ADDRESS` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CITY` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `POSTAL` int(2) DEFAULT NULL,
  `USER` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PASSWORD` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `CREATIONDATE` date DEFAULT NULL,
  `ISVALID` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`IDPERSON`),
  KEY `FK_PERSON_ROLE` (`IDROLE`)
) ENGINE=MyISAM AUTO_INCREMENT=40 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `person`
--

INSERT INTO `person` (`IDPERSON`, `IDROLE`, `NAME`, `FNAME`, `BIRTH`, `MAIL`, `ADDRESS`, `CITY`, `POSTAL`, `USER`, `PASSWORD`, `CREATIONDATE`, `ISVALID`) VALUES
(33, 1, 'Arnaud', 'Paul', '2002-05-15', 'paul@mail.com', '42 rue parisis', 'Dreux', 28100, 'paul', '+FazYBYU7uvEmsR0yJWetbZMREkhTHY4RcMY28cj+D386zExbVO9o9Hf/4eDoHuEiHrc9OTocjenqdnb7CP2zA==', '2021-10-07', 1),
(34, 1, 'Blanchard', 'Axel', '2001-10-14', 'axel@mail.com', '74 rue de l\'église', 'Chartres', 28000, 'axel', 'fAAXGMme4x4liW45AOdXT6kvyzqPxDi21phKL39E3CQanGBTtD21KdK0FOZ++LwvpZ/QMx+qFrssb9qBignNsQ==', '2021-10-14', 1),
(35, 2, 'SABI', 'Abdelkader', '2002-11-11', 'abdelkader@mail.com', '3 rue du chien', 'Chartres', 28000, 'Custromix', 'x1V6NcYLTfzm/pRrgsuRU82ykPB1rqaB2cS15w22TznIhJMc9aSm2+1FOaLiKgVX4sDIfGpbra6lOH9Y6jOCxA==', '2021-10-14', 1),
(39, 2, 'ADMIN', 'Admin', '2022-01-19', 'admin@admin', '45 rue du prés', 'Dreux', 28411, 'admin', 'OsYD7n8/q0B7v2tLpYOsdRX5gI5vbGsmM6YZi36C2y3YTH8U6IvdBJ3LHa2yLQiDmrx/CqLCs64Ik43ejrf5/Q==', '2022-01-19', 1);

-- --------------------------------------------------------

--
-- Structure de la table `recipient`
--

DROP TABLE IF EXISTS `recipient`;
CREATE TABLE IF NOT EXISTS `recipient` (
  `IDRECIPIENT` int(11) NOT NULL AUTO_INCREMENT,
  `NAME` varchar(100) NOT NULL,
  `ACCOUNTNUMBER` int(11) NOT NULL,
  `IDPERSON` int(11) NOT NULL,
  PRIMARY KEY (`IDRECIPIENT`),
  KEY `IdPerson` (`IDPERSON`),
  KEY `ACCOUNTNUMBER` (`ACCOUNTNUMBER`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `recipient`
--

INSERT INTO `recipient` (`IDRECIPIENT`, `NAME`, `ACCOUNTNUMBER`, `IDPERSON`) VALUES
(1, 'Axel', 4, 33),
(5, 'Paul78', 2, 34),
(6, 'Axel 2', 5, 33);

-- --------------------------------------------------------

--
-- Structure de la table `rendezvous`
--

DROP TABLE IF EXISTS `rendezvous`;
CREATE TABLE IF NOT EXISTS `rendezvous` (
  `IDRENDEZVOUS` int(11) NOT NULL AUTO_INCREMENT,
  `IDPERSON` int(11) NOT NULL,
  `IDREASON` int(11) NOT NULL,
  `COMMENT` text NOT NULL,
  PRIMARY KEY (`IDRENDEZVOUS`),
  KEY `IDPERSON` (`IDPERSON`),
  KEY `IDREASON` (`IDREASON`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `rendezvoustype`
--

DROP TABLE IF EXISTS `rendezvoustype`;
CREATE TABLE IF NOT EXISTS `rendezvoustype` (
  `IDRENDEZVOUSTYPE` int(11) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDRENDEZVOUSTYPE`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `rendezvoustype`
--

INSERT INTO `rendezvoustype` (`IDRENDEZVOUSTYPE`, `LIBELLE`) VALUES
(1, 'Changement de mot de passe');

-- --------------------------------------------------------

--
-- Structure de la table `role`
--

DROP TABLE IF EXISTS `role`;
CREATE TABLE IF NOT EXISTS `role` (
  `IDROLE` int(2) NOT NULL AUTO_INCREMENT,
  `NAME` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDROLE`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `role`
--

INSERT INTO `role` (`IDROLE`, `NAME`) VALUES
(2, 'Banker'),
(3, 'Admin'),
(1, 'Customer');

-- --------------------------------------------------------

--
-- Structure de la table `terminal`
--

DROP TABLE IF EXISTS `terminal`;
CREATE TABLE IF NOT EXISTS `terminal` (
  `IDTERMINAL` int(2) NOT NULL AUTO_INCREMENT,
  `NAME` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `IP` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `AGENCY` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDTERMINAL`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `terminal`
--

INSERT INTO `terminal` (`IDTERMINAL`, `NAME`, `IP`, `AGENCY`) VALUES
(1, 'TerminalDreux', '192.168.10.25', 'Dreux');

-- --------------------------------------------------------

--
-- Structure de la table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
CREATE TABLE IF NOT EXISTS `transaction` (
  `IDTRANSACTION` int(2) NOT NULL AUTO_INCREMENT,
  `IDPERSON` int(2) NOT NULL,
  `IDTERMINAL` int(2) NOT NULL,
  `IDWALLET` int(2) DEFAULT NULL,
  `AMOUNT` int(2) NOT NULL,
  `DATETRANS` date NOT NULL,
  `ACTION` char(32) COLLATE utf8_unicode_ci NOT NULL,
  `IDACCOUNTRECEIVER` int(11) DEFAULT NULL,
  `IDACCOUNTSENDER` int(11) DEFAULT NULL,
  PRIMARY KEY (`IDTRANSACTION`),
  KEY `FK_TRANSACTION_PERSON` (`IDPERSON`),
  KEY `FK_TRANSACTION_TERMINAL` (`IDTERMINAL`),
  KEY `FK_TRANSACTION_WALLET` (`IDWALLET`),
  KEY `IDACCOUNTSENDER` (`IDACCOUNTSENDER`)
) ENGINE=MyISAM AUTO_INCREMENT=149 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `transaction`
--

INSERT INTO `transaction` (`IDTRANSACTION`, `IDPERSON`, `IDTERMINAL`, `IDWALLET`, `AMOUNT`, `DATETRANS`, `ACTION`, `IDACCOUNTRECEIVER`, `IDACCOUNTSENDER`) VALUES
(75, 33, 1, 0, 10, '2021-11-15', 'Dépot', 0, 1),
(76, 33, 1, 0, 10, '2021-11-18', 'Dépot', 0, 1),
(77, 33, 1, 0, 10, '2021-11-18', 'Dépot', 0, 1),
(99, 33, 1, 0, 100, '2021-11-18', 'Virement', 3, 1),
(98, 33, 1, 0, 40, '2021-11-18', 'Dépot', 0, 1),
(90, 33, 1, 0, 10, '2021-11-18', 'Dépot', 0, 0),
(91, 33, 1, 0, 90, '2021-11-18', 'Dépot', 0, 3),
(92, 33, 1, 0, 10, '2021-11-18', 'Dépot', 0, 1),
(97, 33, 1, 0, 20, '2021-11-18', 'Virement', 3, 1),
(100, 34, 1, 0, 400, '2022-01-16', 'Dépot', 0, 4),
(101, 33, 1, 0, 100, '2022-01-16', 'Virement', 0, 2),
(102, 33, 1, 0, 10, '2022-01-16', 'Virement', 1, 3),
(103, 33, 1, 0, 10, '2022-01-16', 'Virement', 0, 2),
(105, 33, 1, 0, 10, '2022-01-16', 'Virement', 4, 1),
(106, 33, 1, 0, 100, '2022-01-19', 'Dépot', 0, 1),
(107, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(108, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(109, 33, 1, 0, 10, '2022-01-19', 'Virement', 2, 1),
(110, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 1),
(111, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(112, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(113, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(114, 33, 1, 0, 50, '2022-01-19', 'Virement', 4, 0),
(115, 33, 1, 0, 20, '2022-01-19', 'Virement', 4, 0),
(116, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(117, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 1),
(118, 33, 1, 0, 40, '2022-01-19', 'Virement', 4, 1),
(119, 33, 1, 0, 40, '2022-01-19', 'Virement', 4, 1),
(120, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(121, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 1),
(122, 33, 1, 0, 5, '2022-01-19', 'Virement', 4, 0),
(123, 33, 1, 0, 5, '2022-01-19', 'Virement', 4, 1),
(124, 33, 1, 0, 25, '2022-01-19', 'Dépot', 0, 1),
(125, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 1),
(126, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 1),
(127, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(128, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(129, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(130, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(131, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(132, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(133, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(134, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(135, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 1),
(136, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 0),
(137, 33, 1, 0, 10, '2022-01-19', 'Virement', 4, 2),
(138, 34, 1, 0, 5, '2022-01-19', 'Virement', 2, 0),
(139, 34, 1, 0, 5, '2022-01-19', 'Virement', 2, 4),
(140, 33, 1, 0, 105, '2022-01-19', 'Virement', 5, 0),
(141, 33, 1, 0, 105, '2022-01-19', 'Virement', 5, 2),
(142, 34, 1, 0, 5, '2022-01-19', 'Virement', 4, 5),
(143, 33, 1, 0, 1000, '2022-01-31', 'Dépot', 0, 2),
(144, 33, 1, 0, 100, '2022-01-31', 'Virement', 5, 2),
(145, 33, 1, 0, 100, '2022-01-31', 'Virement', 5, 2),
(146, 33, 1, 0, 10, '2022-01-31', 'Virement', 4, 2),
(147, 33, 1, 0, 10, '2022-01-31', 'Virement', 4, 1),
(148, 33, 1, 0, 100000, '2022-02-10', 'Dépot', 0, 3);

-- --------------------------------------------------------

--
-- Structure de la table `wallet`
--

DROP TABLE IF EXISTS `wallet`;
CREATE TABLE IF NOT EXISTS `wallet` (
  `IDWALLET` int(2) NOT NULL AUTO_INCREMENT,
  `IDCRYPTO` int(2) NOT NULL,
  `IDPERSON` int(2) NOT NULL,
  `NAME` char(32) COLLATE utf8_unicode_ci DEFAULT NULL,
  `QUANTITY` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`IDWALLET`),
  KEY `FK_WALLET_CRYPTO` (`IDCRYPTO`),
  KEY `FK_WALLET_PERSON` (`IDPERSON`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `wallet`
--

INSERT INTO `wallet` (`IDWALLET`, `IDCRYPTO`, `IDPERSON`, `NAME`, `QUANTITY`) VALUES
(1, 1, 33, 'Bitcoin', '10.00'),
(4, 1, 33, 'Kader le boss', '12.00'),
(3, 33, 0, 'KaderCryptoChef', '120.00');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
