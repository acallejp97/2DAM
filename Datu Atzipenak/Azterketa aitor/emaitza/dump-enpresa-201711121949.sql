-- MySQL dump 10.16  Distrib 10.1.25-MariaDB, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: enpresa
-- ------------------------------------------------------
-- Server version	10.1.25-MariaDB-

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
-- Table structure for table `departamentuak`
--

DROP TABLE IF EXISTS `departamentuak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamentuak` (
  `dept_Zbkia` tinyint(2) NOT NULL,
  `izena` varchar(15) DEFAULT NULL,
  `kokapena` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`dept_Zbkia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentuak`
--

LOCK TABLES `departamentuak` WRITE;
/*!40000 ALTER TABLE `departamentuak` DISABLE KEYS */;
INSERT INTO `departamentuak` VALUES (10,'INFORMATIKA','DONOSTIA'),(20,'NOMINAK','BARTZELONA'),(30,'    ','IRUN'),(40,' ','DONOSTIA'),(50,'INFORMATIKA','IRUÑEA'),(60,'LANGILE KUDEAKE','BAIONA'),(70,'IDAZKARITZA','MAULE'),(80,'   ','DONIBANE'),(90,'DENDA','GASTEIZ'),(100,'IDAZKARITZA','EIBAR');
/*!40000 ALTER TABLE `departamentuak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enplegatuak`
--

DROP TABLE IF EXISTS `enplegatuak`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enplegatuak` (
  `enp_Zbkia` smallint(4) NOT NULL,
  `abizena` varchar(10) DEFAULT NULL,
  `lanbidea` varchar(10) DEFAULT NULL,
  `zuzendaria` smallint(4) DEFAULT NULL,
  `altako_data` date DEFAULT NULL,
  `soldata` float(6,2) DEFAULT NULL,
  `komisioa` float(6,2) DEFAULT NULL,
  `dept_Zbkia` tinyint(2) NOT NULL,
  PRIMARY KEY (`enp_Zbkia`),
  KEY `dept_Zbkia` (`dept_Zbkia`),
  KEY `zuzendaria` (`zuzendaria`),
  CONSTRAINT `enplegatuak_ibfk_1` FOREIGN KEY (`dept_Zbkia`) REFERENCES `departamentuak` (`dept_Zbkia`),
  CONSTRAINT `enplegatuak_ibfk_2` FOREIGN KEY (`zuzendaria`) REFERENCES `enplegatuak` (`enp_Zbkia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enplegatuak`
--

LOCK TABLES `enplegatuak` WRITE;
/*!40000 ALTER TABLE `enplegatuak` DISABLE KEYS */;
INSERT INTO `enplegatuak` VALUES (1000,'Etxebe','Alperra',7566,'2016-05-05',500.00,100.00,10),(2000,'Etxenike','Etxafleroa',7566,'2017-01-18',3000.00,600.00,10),(5000,'Bimilakoa','Diruzalea',7902,'2012-12-22',2000.00,1000.00,50),(5050,'Bimilakoa','Diruzalea',7782,'2012-12-22',2000.00,1000.00,50),(6000,'Bimilakoa','Diruzalea',7782,'2012-12-22',2000.00,1000.00,30),(7369,'SAGAZTI','ENPLEGATUA',7902,'1990-12-17',1040.00,NULL,20),(7499,'OZERIN','SALTZAILEA',7698,'1990-02-20',1500.00,390.00,30),(7521,'GOTI','SALTZAILEA',7698,'1991-02-22',1625.00,650.00,30),(7566,'ARANGUREN','ZUZENDARIA',7839,'1991-04-02',2900.00,NULL,20),(7654,'GOIRI','SALTZAILEA',7698,'1991-09-29',1600.00,1020.00,30),(7698,'BERTIZ','ZUZENDARIA',7839,'1991-05-01',3005.00,NULL,30),(7782,'ZUMARDI','ZUZENDARIA',7839,'1991-06-09',2885.00,NULL,10),(7788,'ELEZPE','ANALISTA',7566,'1991-11-09',3000.00,NULL,20),(7839,'BERRIO','LEHENDAKAR',NULL,'1991-11-17',4100.00,NULL,10),(7844,'EGIA','SALTZAILEA',7698,'1991-09-08',1350.00,0.00,30),(7876,'BEITIA','ENPLEGATUA',7788,'1991-09-23',1430.00,NULL,20),(7900,'GORRITI','ENPLEGATUA',7698,'1991-12-03',1335.00,NULL,30),(7902,'GORRIA','ANALISTA',7566,'1991-12-03',3000.00,NULL,20),(7934,'BERGARA','ENPLEGATUA',7782,'1992-01-23',1690.00,NULL,10),(9000,'Etxebe','Alperra',7566,'2016-05-05',500.00,100.00,10),(10000,'Etxebe','Alperra',7566,'2016-05-05',500.00,100.00,10);
/*!40000 ALTER TABLE `enplegatuak` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'enpresa'
--
/*!50003 DROP PROCEDURE IF EXISTS `departamentuaAldatu` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `departamentuaAldatu`(
	IN `Zbkia` INT,
	IN `izena` VARCHAR(15),
	IN `kokapena` VARCHAR(15)
)
BEGIN
UPDATE departamentuak
SET departamentuak.dept_Zbkia=Zbkia,
    departamentuak.izena=izena, 
	 departamentuak.kokapena=kokapena
WHERE departamentuak.dept_Zbkia=Zbkia;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `departamentuaKokapenaAldatu` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `departamentuaKokapenaAldatu`(
	IN `Zbkia` INT,
	IN `Kokapena` VARCHAR(15)
)
BEGIN
UPDATE departamentuak
SET departamentuak.kokapena=Kokapena
WHERE departamentuak.dept_Zbkia=Zbkia;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `departamentuaSartu` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'IGNORE_SPACE,STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `departamentuaSartu`(
IN dept_Zbkia INT(4),
IN izena VARCHAR(50),
IN kokapena VARCHAR(50)
)
BEGIN
	INSERT INTO departamentuak values(dept_Zbkia,izena,kokapena);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `departamentuIzenaAldatu` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `departamentuIzenaAldatu`(
	IN `Zbkia` INT,
	IN `Izena` VARCHAR(15)
)
BEGIN
UPDATE departamentuak
SET departamentuak.izena=Izena
WHERE departamentuak.dept_Zbkia=Zbkia;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `enplegatuaALdatu` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `enplegatuaALdatu`(
	IN `enp_Zbkia` INT(4),
	IN `abizena` VARCHAR(50),
	IN `lanbidea` VARCHAR(50),
	IN `zuzendaria` INT(4),
	IN `altako_data` DATE,
	IN `soldata` FLOAT,
	IN `komisioa` FLOAT,
	IN `dep_Zbkia` SMALLINT
)
BEGIN
UPDATE enplegatuak 
	SET enplegatuak.abizena=abizena,
	    enplegatuak.lanbidea=lanbidea,
	    enplegatuak.zuzendaria=zuzendaria,
	    enplegatuak.altako_data=altako_data,
	    enplegatuak.soldata=soldata,
	    enplegatuak.komisioa=komisioa,
	    enplegatuak.dept_Zbkia=dept_Zbkia
	WHERE enplegatuak.enp_Zbkia=enp_Zbkia;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `enplegatuaEzabatu` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `enplegatuaEzabatu`(zbkia SMALLINT(4))
BEGIN
DELETE FROM enplegatuak where enp_Zbkia=zbkia;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `enplegatuaSartu` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `enplegatuaSartu`(
	IN `enp_Zbkia` INT(4),
	IN `abizena` VARCHAR(50),
	IN `lanbidea` VARCHAR(50),
	IN `zuzendaria` INT(4),
	IN `altako_data` DATE,
	IN `soldata` FLOAT,
	IN `komisioa` FLOAT,
	IN `dep_Zbkia` SMALLINT
)
BEGIN
INSERT INTO enplegatuak VALUES(enp_Zbkia,abizena,lanbidea,zuzendaria,altako_data,soldata,komisioa,dep_Zbkia);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `hartuDepartamentua` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `hartuDepartamentua`(
	IN `Zbkia` INT
)
BEGIN
SELECT * FROM departamentuak WHERE dept_Zbkia=Zbkia; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `kontsultaEGIN` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `kontsultaEGIN`(IN Zbkia INT)
BEGIN
SELECT enp_Zbkia,abizena,lanbidea,zuzendaria,altako_data,soldata,komisioa,dept_Zbkia FROM enplegatuak WHERE enp_Zbkia=Zbkia; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `zerrendatuDEPARTAMENTUAK` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `zerrendatuDEPARTAMENTUAK`()
BEGIN
SELECT * FROM departamentuak;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `zerrendatuENPLEGATUAK` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `zerrendatuENPLEGATUAK`()
BEGIN
select * from enplegatuak;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `zerrendatuZUZENDARIAK` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `zerrendatuZUZENDARIAK`()
BEGIN
SELECT * FROM enplegatuak where enplegatuak.lanbidea='ZUZENDARIA' OR enplegatuak.lanbidea='ANALISTA' OR enplegatuak.lanbidea='LEHENDAKAR';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-12 19:49:50
