-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 26 mai 2026 à 17:57
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `pizzeria`
--

-- --------------------------------------------------------

--
-- Structure de la table `affecter`
--

DROP TABLE IF EXISTS `affecter`;
CREATE TABLE IF NOT EXISTS `affecter` (
  `CodeServeur` varchar(5) NOT NULL,
  `NumBorne` tinyint NOT NULL,
  `DateHeureOuverture` datetime NOT NULL,
  `DateHeureFermeture` datetime DEFAULT NULL,
  PRIMARY KEY (`CodeServeur`,`NumBorne`,`DateHeureOuverture`),
  KEY `FK_Affecter_NumBorne` (`NumBorne`),
  KEY `FK_Affecter_DateHeureOuverture` (`DateHeureOuverture`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Structure de la table `borne`
--

DROP TABLE IF EXISTS `borne`;
CREATE TABLE IF NOT EXISTS `borne` (
  `NumBorne` tinyint NOT NULL,
  `ZoneBorne` varchar(30) DEFAULT NULL COMMENT 'salle / comptoir / terrasse / livraison',
  PRIMARY KEY (`NumBorne`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `borne`
--

INSERT INTO `borne` (`NumBorne`, `ZoneBorne`) VALUES
(1, 'comptoir'),
(2, 'salle'),
(3, 'salle'),
(4, 'salle'),
(5, 'terrasse'),
(6, 'terrasse'),
(7, 'livraison'),
(8, 'livraison');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

DROP TABLE IF EXISTS `commande`;
CREATE TABLE IF NOT EXISTS `commande` (
  `NumCommande` int NOT NULL AUTO_INCREMENT,
  `DateHeureCommande` datetime DEFAULT NULL,
  `ModeReglement` varchar(30) DEFAULT NULL COMMENT 'Espèces / Carte Bancaire / Ticket Restaurant / Lydia / PayLib / Chèque Vacances',
  `MontantTTC` decimal(7,2) DEFAULT NULL,
  `NumBorne` tinyint NOT NULL,
  `CodeServeur` varchar(5) NOT NULL,
  PRIMARY KEY (`NumCommande`),
  KEY `FK_Commande_NumBorne` (`NumBorne`),
  KEY `FK_Commande_CodeServeur` (`CodeServeur`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`NumCommande`, `DateHeureCommande`, `ModeReglement`, `MontantTTC`, `NumBorne`, `CodeServeur`) VALUES
(4, '2026-05-26 20:14:21', 'Espèces', '1.00', 8, '4'),
(5, '2026-05-26 20:16:01', 'Espèces', '3.00', 1, '4'),
(6, '2026-05-26 20:16:16', 'Espèces', '4.00', 1, '4'),
(7, '2026-05-26 20:19:14', 'Espèces', '6.00', 4, '4'),
(8, '2026-05-26 20:20:38', 'Espèces', '1.00', 4, '4'),
(9, '2026-05-26 20:24:16', 'PayLib', '6.00', 3, '4'),
(10, '2026-05-26 20:26:41', 'Espèces', '64.00', 6, '4'),
(11, '2026-05-26 20:39:28', 'Carte Bancaire', '42.00', 8, '4'),
(12, '2026-05-26 20:39:48', 'Espèces', '25.99', 8, '4'),
(13, '2026-05-26 20:40:07', 'Lydia', '0.00', 5, '4');

-- --------------------------------------------------------

--
-- Structure de la table `ligne_commande`
--

DROP TABLE IF EXISTS `ligne_commande`;
CREATE TABLE IF NOT EXISTS `ligne_commande` (
  `NumCommande` int NOT NULL,
  `NumLigne` int NOT NULL,
  `TypeArticle` varchar(15) NOT NULL COMMENT 'pizza / menu / supplement',
  `RefArticle` int NOT NULL COMMENT 'NumPizza, NumMenu ou NumSupplement selon TypeArticle',
  `QteArticle` int DEFAULT '1',
  `PrixUnitaireHT` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`NumCommande`,`NumLigne`),
  KEY `FK_LigneCommande_NumCommande` (`NumCommande`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `ligne_commande`
--

INSERT INTO `ligne_commande` (`NumCommande`, `NumLigne`, `TypeArticle`, `RefArticle`, `QteArticle`, `PrixUnitaireHT`) VALUES
(4, 1, 'pizza', 6, 1, '8.18'),
(5, 1, 'menu', 4, 1, '16.36'),
(5, 2, 'menu', 4, 1, '16.36'),
(5, 3, 'supplement', 6, 1, '0.91'),
(6, 1, 'pizza', 6, 1, '8.18'),
(6, 2, 'pizza', 6, 1, '8.18'),
(6, 3, 'pizza', 6, 1, '8.18'),
(6, 4, 'menu', 5, 1, '14.55'),
(7, 1, 'pizza', 6, 1, '8.18'),
(7, 2, 'menu', 6, 1, '17.27'),
(7, 3, 'supplement', 4, 1, '1.36'),
(7, 4, 'supplement', 4, 1, '1.36'),
(7, 5, 'supplement', 4, 1, '1.36'),
(7, 6, 'supplement', 4, 1, '1.36'),
(8, 1, 'pizza', 4, 1, '8.64'),
(9, 1, 'menu', 3, 1, '7.27'),
(9, 2, 'menu', 3, 1, '7.27'),
(9, 3, 'menu', 3, 1, '7.27'),
(9, 4, 'supplement', 6, 1, '0.91'),
(9, 5, 'supplement', 6, 1, '0.91'),
(9, 6, 'supplement', 6, 1, '0.91'),
(10, 1, 'pizza', 8, 1, '9.09'),
(10, 2, 'menu', 6, 1, '17.27'),
(10, 3, 'menu', 5, 1, '14.55'),
(10, 4, 'menu', 5, 1, '14.55'),
(10, 5, 'supplement', 1, 1, '1.36'),
(10, 6, 'supplement', 1, 1, '1.36'),
(11, 1, 'supplement', 6, 1, '0.91'),
(11, 2, 'menu', 1, 1, '9.09'),
(11, 3, 'menu', 1, 1, '9.09'),
(11, 4, 'menu', 1, 1, '9.09'),
(11, 5, 'pizza', 14, 1, '10.00'),
(12, 1, 'menu', 3, 1, '7.27'),
(12, 2, 'menu', 3, 1, '7.27'),
(12, 3, 'menu', 1, 1, '9.09');

-- --------------------------------------------------------

--
-- Structure de la table `menu`
--

DROP TABLE IF EXISTS `menu`;
CREATE TABLE IF NOT EXISTS `menu` (
  `NumMenu` int NOT NULL AUTO_INCREMENT,
  `LibelleMenu` varchar(80) NOT NULL,
  `DescriptionMenu` varchar(200) DEFAULT NULL,
  `PrixHTmenu` decimal(6,2) NOT NULL,
  PRIMARY KEY (`NumMenu`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `menu`
--

INSERT INTO `menu` (`NumMenu`, `LibelleMenu`, `DescriptionMenu`, `PrixHTmenu`) VALUES
(1, 'Menu Étudiant', '1 pizza classique (jusqu\'à 30 cm) + 1 boisson 33 cl', '9.09'),
(2, 'Menu Famiglia', '1 pizza spéciale (jusqu\'à 40 cm) + 1 dessert + 2 boissons 33 cl', '18.18'),
(3, 'Menu Bambino', '1 pizza classique enfant (22 cm) + 1 jus de fruit + 1 dessert', '7.27'),
(4, 'Menu Duo', '2 pizzas classiques (30 cm) + 2 boissons 33 cl', '16.36'),
(5, 'Menu Gourmand', '1 pizza spéciale (30 cm) + 1 entrée (salade/soupe) + 1 dessert + 1 boisson', '14.55'),
(6, 'Menu Livraison', '2 pizzas au choix + 1 dessert offert (commandes livrées uniquement)', '17.27');

-- --------------------------------------------------------

--
-- Structure de la table `ouverture_service`
--

DROP TABLE IF EXISTS `ouverture_service`;
CREATE TABLE IF NOT EXISTS `ouverture_service` (
  `DateHeureOuverture` datetime NOT NULL,
  `Service` varchar(10) DEFAULT NULL COMMENT 'midi / soir',
  PRIMARY KEY (`DateHeureOuverture`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Structure de la table `pizza`
--

DROP TABLE IF EXISTS `pizza`;
CREATE TABLE IF NOT EXISTS `pizza` (
  `NumPizza` int NOT NULL AUTO_INCREMENT,
  `NomPizza` varchar(60) NOT NULL,
  `DescriptionPizza` varchar(150) DEFAULT NULL,
  `PrixHTpizza` decimal(6,2) NOT NULL,
  `CategoriePizza` varchar(30) DEFAULT NULL COMMENT 'classique / spéciale / végétarienne',
  PRIMARY KEY (`NumPizza`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `pizza`
--

INSERT INTO `pizza` (`NumPizza`, `NomPizza`, `DescriptionPizza`, `PrixHTpizza`, `CategoriePizza`) VALUES
(1, 'Margherita', 'Tomate, mozzarella, basilic frais', '7.27', 'classique'),
(2, 'Regina', 'Tomate, mozzarella, jambon, champignons', '8.18', 'classique'),
(3, 'Reine', 'Tomate, mozzarella, jambon blanc, olives noires', '8.18', 'classique'),
(4, '4 Fromages', 'Mozzarella, gorgonzola, chèvre, parmesan', '8.64', 'classique'),
(5, 'Napolitaine', 'Tomate, mozzarella, anchois, câpres, olives', '8.64', 'classique'),
(6, 'Romaine', 'Tomate, mozzarella, anchois, ail, herbes de Provence', '8.18', 'classique'),
(7, 'Calzone', 'Tomate, mozzarella, jambon, ricotta – pizza fermée', '9.09', 'classique'),
(8, 'Diavola', 'Tomate, mozzarella, chorizo, piment rouge', '9.09', 'spéciale'),
(9, 'Orientale', 'Tomate, mozzarella, merguez, poivrons, harissa', '9.55', 'spéciale'),
(10, 'Mexicana', 'Tomate, mozzarella, bœuf haché, jalapeños, maïs, haricots rouges', '9.55', 'spéciale'),
(11, 'Poulet Pesto', 'Crème, mozzarella, poulet grillé, pesto basilic, tomates séchées', '10.00', 'spéciale'),
(12, 'Fruits de Mer', 'Tomate, mozzarella, crevettes, calamars, moules', '10.91', 'spéciale'),
(13, 'Truffe & Roquette', 'Crème, mozzarella, jambon de Parme, roquette, huile de truffe', '12.73', 'spéciale'),
(14, 'BBQ Chicken', 'Sauce BBQ, mozzarella, poulet, oignons caramélisés, bacon', '10.00', 'spéciale'),
(15, 'Végétarienne', 'Tomate, mozzarella, poivrons, courgettes, aubergines, champignons', '8.64', 'végétarienne'),
(16, 'Chèvre Miel', 'Crème, mozzarella, chèvre, miel, noix, roquette', '9.09', 'végétarienne'),
(17, 'Primavera', 'Tomate, mozzarella, épinards, tomates cerises, olives, basilic', '8.64', 'végétarienne');

-- --------------------------------------------------------

--
-- Structure de la table `serveur`
--

DROP TABLE IF EXISTS `serveur`;
CREATE TABLE IF NOT EXISTS `serveur` (
  `CodeServeur` varchar(5) NOT NULL,
  `NomServeur` varchar(50) DEFAULT NULL,
  `PrenomServeur` varchar(50) DEFAULT NULL,
  `Login` varchar(20) NOT NULL,
  `MDP` varchar(64) NOT NULL,
  PRIMARY KEY (`CodeServeur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `serveur`
--

INSERT INTO `serveur` (`CodeServeur`, `NomServeur`, `PrenomServeur`, `Login`, `MDP`) VALUES
('1', 'FERRARI', 'Marco', 'ferrarim', 'f50093e72de71c534894e9cfbd3b0bf36e217733ba7831371e2feb620989812f'),
('2', 'ROSSI', 'Sofia', 'rossis', '08eab8f3b2939691aa32e9f93ac4a667668bb66cd72c7889b691d3276ffc2421'),
('3', 'BIANCHI', 'Luca', 'bianchil', '02f0b387500624474735cb3f56e7d63ed63b4758e71e21500469b6520737bfb3'),
('4', 'CONTI', 'Elena', 'contie', '238ffc1892d5d28d7952a78cdbf1652323aa25fcb770d5e2c143b2bf9edbbab3'),
('5', 'MORETTI', 'Giulia', 'morettig', '86a3a3f7fe023561edd4a79b2f0036e4eb10583bf06ed241678ff3a03e3c737c'),
('6', 'RICCI', 'Antonio', 'riccia', 'b34361dc879fb44b2c290fc25e7820747d513443f92e77049bd3f53fbb599926'),
('7', 'LOMBARDI', 'Chiara', 'lombardic', '182bdc9b639bdd135b8b1674c779af1374684861d0ea89397ef015215cb796ce');

-- --------------------------------------------------------

--
-- Structure de la table `supplement`
--

DROP TABLE IF EXISTS `supplement`;
CREATE TABLE IF NOT EXISTS `supplement` (
  `NumSupplement` int NOT NULL AUTO_INCREMENT,
  `LibelleSupplement` varchar(60) NOT NULL,
  `PrixHTsupplement` decimal(5,2) NOT NULL,
  PRIMARY KEY (`NumSupplement`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb3;

--
-- Déchargement des données de la table `supplement`
--

INSERT INTO `supplement` (`NumSupplement`, `LibelleSupplement`, `PrixHTsupplement`) VALUES
(1, 'Supplément fromage', '1.36'),
(2, 'Supplément mozzarella', '1.36'),
(3, 'Supplément champignons', '0.91'),
(4, 'Supplément jambon', '1.36'),
(5, 'Supplément chorizo', '1.36'),
(6, 'Supplément anchois', '0.91'),
(7, 'Supplément olives', '0.91'),
(8, 'Supplément œuf', '0.91'),
(9, 'Supplément bacon', '1.36'),
(10, 'Supplément roquette', '0.91'),
(11, 'Supplément tomates séchées', '0.91'),
(12, 'Bord farci fromage', '1.82'),
(13, 'Sauce piquante', '0.45'),
(14, 'Sauce BBQ', '0.45');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `affecter`
--
ALTER TABLE `affecter`
  ADD CONSTRAINT `FK_Affecter_CodeServeur` FOREIGN KEY (`CodeServeur`) REFERENCES `serveur` (`CodeServeur`),
  ADD CONSTRAINT `FK_Affecter_DateHeureOuverture` FOREIGN KEY (`DateHeureOuverture`) REFERENCES `ouverture_service` (`DateHeureOuverture`),
  ADD CONSTRAINT `FK_Affecter_NumBorne` FOREIGN KEY (`NumBorne`) REFERENCES `borne` (`NumBorne`);

--
-- Contraintes pour la table `commande`
--
ALTER TABLE `commande`
  ADD CONSTRAINT `FK_Commande_CodeServeur` FOREIGN KEY (`CodeServeur`) REFERENCES `serveur` (`CodeServeur`),
  ADD CONSTRAINT `FK_Commande_NumBorne` FOREIGN KEY (`NumBorne`) REFERENCES `borne` (`NumBorne`);

--
-- Contraintes pour la table `ligne_commande`
--
ALTER TABLE `ligne_commande`
  ADD CONSTRAINT `FK_LigneCommande_NumCommande` FOREIGN KEY (`NumCommande`) REFERENCES `commande` (`NumCommande`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
