-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.1.25-MariaDB- - Ubuntu 17.04
-- Server OS:                    debian-linux-gnu
-- HeidiSQL Version:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for enpresa
CREATE DATABASE IF NOT EXISTS `enpresa` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `enpresa`;

-- Dumping structure for procedure enpresa.Aldatu
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Aldatu`(
	in zbk int (10),
	in apellidos VARCHAR(10),
	in oficios VARCHAR(10),
	in salarios INT(20),
	in comisions INT(10),
	in dirs int (10),
	in fecha_alts DATE,
	in dept_nos int (10))
BEGIN
 Update empleados
	 set apellido=apellidos,
	 oficio=oficios,
	 salario=salarios,
	 comision=comisions,
	 dir=dirs,
	 fecha_alt=fecha_alts,
	 dept_no=dept_nos
 where emp_no=zbk;
END//
DELIMITER ;

-- Dumping structure for table enpresa.CLIENTES
CREATE TABLE IF NOT EXISTS `CLIENTES` (
  `ID` tinyint(3) unsigned NOT NULL,
  `NOMBRE` varchar(50) NOT NULL,
  `DIRECCION` varchar(50) DEFAULT NULL,
  `POBLACION` varchar(50) DEFAULT NULL,
  `TELEF` varchar(20) DEFAULT NULL,
  `NIF` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table enpresa.CLIENTES: ~4 rows (approximately)
/*!40000 ALTER TABLE `CLIENTES` DISABLE KEYS */;
REPLACE INTO `CLIENTES` (`ID`, `NOMBRE`, `DIRECCION`, `POBLACION`, `TELEF`, `NIF`) VALUES
	(1, 'MARIA SERRANO', 'C/Las Flores 23', 'Guadalajara', '949876655', '34343434L'),
	(2, 'PEDRO BRAVO', 'C/Galiano 6', 'Guadalajara', '949256376', '2256880E'),
	(3, 'MANUEL SERRA', 'Av Atance 24', 'Guadalajara', '949800090', '1234567E'),
	(4, 'ALICIA PÉREZ', 'C/La Azucena 123', 'Talavera', '925678090', '56564564J');
/*!40000 ALTER TABLE `CLIENTES` ENABLE KEYS */;

-- Dumping structure for table enpresa.departamentos
CREATE TABLE IF NOT EXISTS `departamentos` (
  `dept_no` tinyint(2) NOT NULL,
  `dnombre` varchar(15) DEFAULT NULL,
  `loc` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`dept_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table enpresa.departamentos: ~4 rows (approximately)
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
REPLACE INTO `departamentos` (`dept_no`, `dnombre`, `loc`) VALUES
	(10, 'CONTABILIDAD', 'SEVILLA'),
	(20, 'INVESTIGACIÓN', 'MADRID'),
	(30, 'VENTAS', 'BARCELONA'),
	(40, 'PRODUCCIÓN', 'BILBAO');
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;

-- Dumping structure for procedure enpresa.departamentuak
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `departamentuak`(
in kode int(10),
out izena VARCHAR(30),
out kok VARCHAR(30))
BEGIN
SELECT dnombre, loc 
into izena, kok from departamentos 
where dept_no like kode;
END//
DELIMITER ;

-- Dumping structure for table enpresa.empleados
CREATE TABLE IF NOT EXISTS `empleados` (
  `emp_no` smallint(4) NOT NULL,
  `apellido` varchar(10) DEFAULT NULL,
  `oficio` varchar(10) DEFAULT NULL,
  `dir` smallint(6) DEFAULT NULL,
  `fecha_alt` date DEFAULT NULL,
  `salario` float(6,2) DEFAULT NULL,
  `comision` float(6,2) DEFAULT NULL,
  `dept_no` tinyint(2) NOT NULL,
  PRIMARY KEY (`emp_no`),
  KEY `FK_DEP` (`dept_no`),
  CONSTRAINT `FK_DEP` FOREIGN KEY (`dept_no`) REFERENCES `departamentos` (`dept_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table enpresa.empleados: ~15 rows (approximately)
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
REPLACE INTO `empleados` (`emp_no`, `apellido`, `oficio`, `dir`, `fecha_alt`, `salario`, `comision`, `dept_no`) VALUES
	(1001, 'nuevo', 'EMPLEADO', NULL, NULL, 2000.00, NULL, 10),
	(7369, 'SÁNCHEZ', 'EMPLEADO', 7902, '1990-12-17', 1040.00, NULL, 20),
	(7499, 'ARROYO', 'VENDEDOR', 7698, '1990-02-20', 1500.00, 390.00, 30),
	(7521, 'SALA', 'VENDEDOR', 7698, '1991-02-22', 1625.00, 650.00, 30),
	(7566, 'JIMÉNEZ', 'DIRECTOR', 7839, '1991-04-01', 2900.00, 0.00, 20),
	(7654, 'MARTÍN', 'VENDEDOR', 7698, '1991-09-29', 1600.00, 1020.00, 30),
	(7698, 'NEGRO', 'DIRECTOR', 7839, '1991-05-01', 3005.00, NULL, 30),
	(7782, 'CEREZO', 'DIRECTOR', 7839, '1991-06-09', 2885.00, NULL, 10),
	(7788, 'GIL', 'ANALISTA', 7566, '1991-11-09', 3000.00, NULL, 20),
	(7839, 'REY', 'PRESIDENTE', NULL, '1991-11-17', 4100.00, NULL, 10),
	(7844, 'TOVAR', 'VENDEDOR', 7698, '1991-09-08', 1350.00, 0.00, 30),
	(7876, 'ALONSO', 'EMPLEADO', 7788, '1991-09-23', 1430.00, NULL, 20),
	(7900, 'JIMENO', 'EMPLEADO', 7698, '1991-12-03', 1335.00, NULL, 30),
	(7902, 'FERNÁNDEZ', 'ANALISTA', 7566, '1991-12-03', 3000.00, NULL, 20),
	(7934, 'MUÑOZ', 'EMPLEADO', 7782, '1992-01-23', 1690.00, NULL, 10);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;

-- Dumping structure for procedure enpresa.Ezabatu
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Ezabatu`(in zbk INT(10))
BEGIN
	Delete from empleados where emp_no = zbk;
END//
DELIMITER ;

-- Dumping structure for procedure enpresa.Insertar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Insertar`(
	in zbk int (10), 
	in apellidos VARCHAR(10),
	in oficios VARCHAR(10),
	in salarios INT(20),
	in comisions INT(10),
	in dirs int (10),
	in fecha_alts DATE,
	in dept_nos int (10))
BEGIN
	insert into empleados (emp_no, apellido, oficio, salario, comision, dir,fecha_alt, dept_no)
	values (zbk, apellidos, oficios, salarios, comisions, dirs, fecha_alts, dept_nos) ;
 
END//
DELIMITER ;

-- Dumping structure for table enpresa.PRODUCTOS
CREATE TABLE IF NOT EXISTS `PRODUCTOS` (
  `ID` mediumint(8) unsigned NOT NULL,
  `DESCRIPCION` varchar(50) NOT NULL,
  `STOCKACTUAL` mediumint(8) unsigned DEFAULT '0',
  `STOCKMINIMO` mediumint(8) unsigned DEFAULT '0',
  `PVP` decimal(8,2) DEFAULT '0.00',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table enpresa.PRODUCTOS: ~5 rows (approximately)
/*!40000 ALTER TABLE `PRODUCTOS` DISABLE KEYS */;
REPLACE INTO `PRODUCTOS` (`ID`, `DESCRIPCION`, `STOCKACTUAL`, `STOCKMINIMO`, `PVP`) VALUES
	(4, 'Diccionario Maria Moliner 2 tomos', 55, 5, 43.00),
	(5, 'Impresora HP Deskjet F370', 10, 1, 30.65),
	(6, 'Pen Drive 8 Gigas', 52, 5, 7.00),
	(7, 'Ratón óptico inalámbrico Logitecht', 14, 2, 15.00),
	(8, 'El señor de los anillos, 3 DVDs', 8, 2, 25.00);
/*!40000 ALTER TABLE `PRODUCTOS` ENABLE KEYS */;

-- Dumping structure for procedure enpresa.select_to
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `select_to`(
	in zbk int (10), 
	out apellidos VARCHAR(10),
	out oficios VARCHAR(10),
	out salarios INT(20),
	out comisions INT(10), 
	out dirs int (10),
	out fecha_alts DATE,
	out dept_nos int (10))
BEGIN
	SELECT apellido, oficio, salario, comision, dir, fecha_alt, dept_no 
	into apellidos, oficios, salarios, comisions, dirs, fecha_alts, dept_nos 
	from empleados 
	where emp_no like zbk; 
 END//
DELIMITER ;

-- Dumping structure for procedure enpresa.u2_8
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `u2_8`(
	IN `dep` INT,
	OUT `bataz_bestekoa` FLOAT,
	OUT `kopurua` INT
)
BEGIN
SELECT AVG(salario) INTO bataz_bestekoa FROM empleados WHERE dept_no=d;
SELECT COUNT(*) INTO kopurua FROM empleados WHERE dept_no=d;
END//
DELIMITER ;

-- Dumping structure for table enpresa.VENTAS
CREATE TABLE IF NOT EXISTS `VENTAS` (
  `IDVENTA` smallint(5) unsigned NOT NULL,
  `FECHAVENTA` date NOT NULL,
  `IDCLIENTE` tinyint(3) unsigned NOT NULL,
  `IDPRODUCTO` mediumint(8) unsigned NOT NULL,
  `CANTIDAD` tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (`IDVENTA`),
  KEY `VENTAS_PROD` (`IDPRODUCTO`),
  KEY `VENTAS_CLI` (`IDCLIENTE`),
  CONSTRAINT `VENTAS_CLI` FOREIGN KEY (`IDCLIENTE`) REFERENCES `CLIENTES` (`ID`),
  CONSTRAINT `VENTAS_PROD` FOREIGN KEY (`IDPRODUCTO`) REFERENCES `PRODUCTOS` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table enpresa.VENTAS: ~5 rows (approximately)
/*!40000 ALTER TABLE `VENTAS` DISABLE KEYS */;
REPLACE INTO `VENTAS` (`IDVENTA`, `FECHAVENTA`, `IDCLIENTE`, `IDPRODUCTO`, `CANTIDAD`) VALUES
	(1, '2012-07-16', 1, 4, 3),
	(2, '2012-07-17', 4, 5, 2),
	(3, '2012-07-19', 2, 5, 1),
	(4, '2012-08-20', 1, 6, 5),
	(5, '2012-08-22', 3, 4, 1);
/*!40000 ALTER TABLE `VENTAS` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
