-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: chorifest
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `assist`
--

DROP TABLE IF EXISTS `assist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assist` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assist`
--

LOCK TABLES `assist` WRITE;
/*!40000 ALTER TABLE `assist` DISABLE KEYS */;
/*!40000 ALTER TABLE `assist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assist-chorifest`
--

DROP TABLE IF EXISTS `assist-chorifest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assist-chorifest` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ChorifestId` int NOT NULL,
  `AssistId` int NOT NULL,
  `AssistMenuId` int NOT NULL,
  `went` bit(1) DEFAULT NULL,
  `payment` bit(1) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Fk-AssistChorifest-Assist_idx` (`AssistId`),
  KEY `Fk-AssistChorifest-AssistMenu_idx` (`AssistMenuId`),
  KEY `Fk-AssistChorifest-Chorifest_idx` (`ChorifestId`),
  CONSTRAINT `Fk-AssistChorifest-Assist` FOREIGN KEY (`AssistId`) REFERENCES `assist` (`Id`),
  CONSTRAINT `Fk-AssistChorifest-AssistMenu` FOREIGN KEY (`AssistMenuId`) REFERENCES `assist-menu` (`Id`),
  CONSTRAINT `Fk-AssistChorifest-Chorifest` FOREIGN KEY (`ChorifestId`) REFERENCES `chorifest` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assist-chorifest`
--

LOCK TABLES `assist-chorifest` WRITE;
/*!40000 ALTER TABLE `assist-chorifest` DISABLE KEYS */;
/*!40000 ALTER TABLE `assist-chorifest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assist-menu`
--

DROP TABLE IF EXISTS `assist-menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assist-menu` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MenuId` int NOT NULL,
  `QtyMenu` int NOT NULL,
  `DrinkId` int DEFAULT NULL,
  `QtyDrink` int DEFAULT NULL,
  `ExtraId` int DEFAULT NULL,
  `QtyExtra` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Fk-AssistMenu-Menu_idx` (`MenuId`),
  KEY `Fk-AssistMenu-Drink_idx` (`DrinkId`),
  KEY `Fk-AssistMenu-Extra_idx` (`ExtraId`),
  CONSTRAINT `Fk-AssistMenu-Drink` FOREIGN KEY (`DrinkId`) REFERENCES `drink` (`Id`),
  CONSTRAINT `Fk-AssistMenu-Extra` FOREIGN KEY (`ExtraId`) REFERENCES `extra` (`Id`),
  CONSTRAINT `Fk-AssistMenu-Menu` FOREIGN KEY (`MenuId`) REFERENCES `menu` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assist-menu`
--

LOCK TABLES `assist-menu` WRITE;
/*!40000 ALTER TABLE `assist-menu` DISABLE KEYS */;
/*!40000 ALTER TABLE `assist-menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chorifest`
--

DROP TABLE IF EXISTS `chorifest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chorifest` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Date` datetime DEFAULT NULL,
  `Title` varchar(45) DEFAULT NULL,
  `State` int DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `ResgitrationStart` datetime DEFAULT NULL,
  `RegistrationEnd` varchar(45) DEFAULT NULL,
  `QuantityAssist` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Fk-Chorifest-State_idx` (`State`),
  CONSTRAINT `Fk-Chorifest-State` FOREIGN KEY (`State`) REFERENCES `state-chorifest` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chorifest`
--

LOCK TABLES `chorifest` WRITE;
/*!40000 ALTER TABLE `chorifest` DISABLE KEYS */;
/*!40000 ALTER TABLE `chorifest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `drink`
--

DROP TABLE IF EXISTS `drink`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `drink` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Price` float DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drink`
--

LOCK TABLES `drink` WRITE;
/*!40000 ALTER TABLE `drink` DISABLE KEYS */;
/*!40000 ALTER TABLE `drink` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `extra`
--

DROP TABLE IF EXISTS `extra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `extra` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Price` float DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `extra`
--

LOCK TABLES `extra` WRITE;
/*!40000 ALTER TABLE `extra` DISABLE KEYS */;
/*!40000 ALTER TABLE `extra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `food`
--

DROP TABLE IF EXISTS `food`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `food` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Description` varchar(100) NOT NULL,
  `Price` float DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `food`
--

LOCK TABLES `food` WRITE;
/*!40000 ALTER TABLE `food` DISABLE KEYS */;
/*!40000 ALTER TABLE `food` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FoodId` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `Fk-Menu-Food_idx` (`FoodId`),
  CONSTRAINT `Fk-Menu-Food` FOREIGN KEY (`FoodId`) REFERENCES `food` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu-chorifest`
--

DROP TABLE IF EXISTS `menu-chorifest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu-chorifest` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `MenuId` int DEFAULT NULL,
  `ChorifestId` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Fk-MenuChorifest-Menu_idx` (`MenuId`),
  KEY `Fk-MenuChorifest-Chorifest_idx` (`ChorifestId`),
  CONSTRAINT `Fk-MenuChorifest-Chorifest` FOREIGN KEY (`ChorifestId`) REFERENCES `chorifest` (`Id`),
  CONSTRAINT `Fk-MenuChorifest-Menu` FOREIGN KEY (`MenuId`) REFERENCES `menu` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu-chorifest`
--

LOCK TABLES `menu-chorifest` WRITE;
/*!40000 ALTER TABLE `menu-chorifest` DISABLE KEYS */;
/*!40000 ALTER TABLE `menu-chorifest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Description` varchar(45) DEFAULT NULL,
  `Price` float DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol`
--

DROP TABLE IF EXISTS `rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(45) NOT NULL,
  `Description` varchar(45) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol`
--

LOCK TABLES `rol` WRITE;
/*!40000 ALTER TABLE `rol` DISABLE KEYS */;
INSERT INTO `rol` VALUES (1,'Admin','Administrador');
/*!40000 ALTER TABLE `rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `state-chorifest`
--

DROP TABLE IF EXISTS `state-chorifest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `state-chorifest` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(45) NOT NULL,
  `Description` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `state-chorifest`
--

LOCK TABLES `state-chorifest` WRITE;
/*!40000 ALTER TABLE `state-chorifest` DISABLE KEYS */;
/*!40000 ALTER TABLE `state-chorifest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Surname` varchar(45) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Rol` int DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `Fk-User-Rol_idx` (`Rol`),
  CONSTRAINT `Fk-User-Rol` FOREIGN KEY (`Rol`) REFERENCES `rol` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Diego','Gomez','diegomartin@gmail.com',1,'1234');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-10-23 21:52:30
