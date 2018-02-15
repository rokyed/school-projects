CREATE DATABASE  IF NOT EXISTS `ab_orion` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ab_orion`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: ab_orion
-- ------------------------------------------------------
-- Server version	5.1.72-community

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `signs`
--

DROP TABLE IF EXISTS `signs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `signs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `signName` varchar(20) DEFAULT NULL,
  `description` text,
  `imageRef` varchar(300) DEFAULT NULL,
  `startOn` int(11) DEFAULT NULL,
  `endOn` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `signs`
--

LOCK TABLES `signs` WRITE;
/*!40000 ALTER TABLE `signs` DISABLE KEYS */;
INSERT INTO `signs` VALUES (1,'Aries',NULL,'ressources/signs/aries-300px.png',321,419),(2,'Taurus',NULL,'ressources/signs/taurus-300px.png',420,520),(3,'Gemini',NULL,'ressources/signs/gemini-300px.png',521,620),(4,'Cancer',NULL,'ressources/signs/cancer-300px.png',621,722),(5,'Leo',NULL,'ressources/signs/leo-300px.png',723,822),(6,'Virgo',NULL,'ressources/signs/virgo-300px.png',823,922),(7,'Libra',NULL,'ressources/signs/libra-300px.png',923,1023),(8,'Scorpio',NULL,'ressources/signs/scorpio-300px.png',1024,1121),(9,'Sagittarius',NULL,'ressources/signs/sagittarius-300px.png',1122,1221),(10,'Capricorn',NULL,'ressources/signs/capricorn-300px.png',1222,1319),(11,'Aquarius',NULL,'ressources/signs/aquarius-300px.png',120,218),(12,'Pisces',NULL,'ressources/signs/pisces-300px.png',219,320);
/*!40000 ALTER TABLE `signs` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-09-25 21:03:21
