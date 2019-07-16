-- phpMyAdmin SQL Dump
-- version 2.11.9.6
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 14-02-2018 a las 14:29:32
-- Versión del servidor: 5.0.51
-- Versión de PHP: 5.2.12

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `pilar`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Asignaciones`
--

CREATE TABLE IF NOT EXISTS `Asignaciones` (
  `IdAsignacion` int(11) NOT NULL auto_increment,
  `Incidencia` int(11) NOT NULL,
  `Tecnico` int(11) NOT NULL,
  `Fechaasignacion` datetime default NULL,
  `FechaInicio` datetime default NULL,
  `FechaFin` datetime default NULL,
  `Solucion` varchar(255) default NULL,
  `Estado` tinytext NOT NULL,
  `MotivoReasig` char(255) default NULL,
  `DescTrabajo` char(255) default NULL,
  PRIMARY KEY  (`IdAsignacion`),
  KEY `fk_Asignaciones_Tecnicos1_idx` (`Tecnico`),
  KEY `fk_Asignaciones_Intzidentziak1_idx` (`Incidencia`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=20 ;

--
-- Volcar la base de datos para la tabla `Asignaciones`
--

INSERT INTO `Asignaciones` (`IdAsignacion`, `Incidencia`, `Tecnico`, `Fechaasignacion`, `FechaInicio`, `FechaFin`, `Solucion`, `Estado`, `MotivoReasig`, `DescTrabajo`) VALUES
(1, 1, 1, '2018-01-25 00:00:00', NULL, NULL, NULL, '', NULL, NULL),
(2, 27, 40, NULL, NULL, NULL, NULL, 'Procesando', NULL, NULL),
(3, 28, 41, NULL, NULL, NULL, NULL, 'Procesando', NULL, NULL),
(4, 29, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(5, 30, 43, NULL, NULL, NULL, NULL, 'Procesando', NULL, NULL),
(6, 31, 44, NULL, NULL, NULL, NULL, 'Procesando', NULL, NULL),
(7, 32, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(8, 33, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(9, 34, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(10, 35, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(11, 36, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(12, 37, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(13, 38, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(14, 39, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(15, 40, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(16, 41, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(17, 42, 42, NULL, NULL, NULL, NULL, 'Iniciada', NULL, NULL),
(18, 24, 12, '2018-02-14 13:09:27', '2018-02-15 15:15:15', '2018-02-14 13:12:30', '', 'Finalizada', '', 'probando descripcion'),
(19, 21, 12, '2018-02-14 13:16:23', '2020-12-15 15:15:15', '0000-00-00 00:00:00', '', 'Procesando', '', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `AulaTaller`
--

CREATE TABLE IF NOT EXISTS `AulaTaller` (
  `IdAula` int(11) NOT NULL auto_increment,
  `NumeroAula` tinytext NOT NULL,
  `Descripcion` tinytext,
  `Pabellon` int(11) NOT NULL,
  PRIMARY KEY  (`IdAula`),
  KEY `fk_Aula_Pabellones1_idx` (`Pabellon`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Volcar la base de datos para la tabla `AulaTaller`
--

INSERT INTO `AulaTaller` (`IdAula`, `NumeroAula`, `Descripcion`, `Pabellon`) VALUES
(1, 'Taller Hardware', 'Taller Hardware', 0),
(2, '015', 'SMR1', 0),
(4, 'Aula IkasEnpresa del pab.5', 'Aula IkasEnpresa del pab.5', 1),
(5, 'Aula15', 'Aula15', 1),
(6, 'aula 15', 'aula 15', 1),
(7, 'Taller de hardware', 'Taller de hardware', 1),
(8, 'Taller junto contenedor de papel', 'Taller junto contenedor de papel', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Grupos`
--

CREATE TABLE IF NOT EXISTS `Grupos` (
  `IdGrupo` int(11) NOT NULL auto_increment,
  `Nombre` char(50) NOT NULL,
  `Descripcion` char(255) default NULL,
  `Estado` char(10) default 'Alta',
  PRIMARY KEY  (`IdGrupo`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=14 ;

--
-- Volcar la base de datos para la tabla `Grupos`
--

INSERT INTO `Grupos` (`IdGrupo`, `Nombre`, `Descripcion`, `Estado`) VALUES
(1, 'BURLAOS COMPANY', 'ESOS BURLAOS OEOE', 'Alta'),
(2, ' Los Cuatro Fantasticos', NULL, 'Alta'),
(3, 'Kaleeshi y los Dothrakis', NULL, 'Alta'),
(4, 'Jokin', '', 'Baja'),
(5, 'GrupoPrueba', '', 'Alta'),
(6, 'GrupoPrueba2', '', 'Alta'),
(7, 'GrupoMasterHEHEXD', 'ESE GRUPO OEOE!!!', 'Alta'),
(8, 'rana', 'croac', ''),
(9, 'El Grupaso', 'Ez el mejor KAZUUUUU', 'Alta'),
(10, 'Señorehhh', 'muchos señorehh', 'Baja'),
(11, 'LOSXD', 'HEHEXDLOLGETTROLLEDLUUUL', 'Alta'),
(12, 'a', 'aaaa', 'Alta'),
(13, 'aa', 'aaaa', 'Alta');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Intzidentziak`
--

CREATE TABLE IF NOT EXISTS `Intzidentziak` (
  `IdIntzidentzia` int(11) NOT NULL auto_increment,
  `Creada` datetime default NULL,
  `email` varchar(50) default NULL,
  `Equipo` int(11) NOT NULL,
  `Pabellon` int(11) NOT NULL,
  `AulaTaller` int(11) NOT NULL,
  `ArazoenDeskribapena` varchar(255) default NULL,
  `Noizko` datetime default NULL,
  `Oharrak` varchar(255) default NULL,
  `Estado` char(20) NOT NULL,
  PRIMARY KEY  (`IdIntzidentzia`),
  KEY `fk_Intzidentziak_Equipos1_idx` (`Equipo`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=78 ;

--
-- Volcar la base de datos para la tabla `Intzidentziak`
--

INSERT INTO `Intzidentziak` (`IdIntzidentzia`, `Creada`, `email`, `Equipo`, `Pabellon`, `AulaTaller`, `ArazoenDeskribapena`, `Noizko`, `Oharrak`, `Estado`) VALUES
(10, '2018-01-31 14:13:41', 'adios@gmail.com', 2, 3, 1, 'Descripcion de la incidencia', '2018-02-14 14:30:00', 'Observaciones de la incidencia', 'Iniciada'),
(14, '2016-09-28 00:00:00', 'infialonso@elorrieta-errekamari.com', 1, 2, 1, 'no arranca', '2016-10-05 00:00:00', 'HZ012768 -> Urgente: No Contacto: Iratxe Pabellon/Aula: Taller de Hardware', 'En espera'),
(15, '2016-10-18 00:00:00', 'infialonso@elorrieta-errekamari.com', 1, 3, 1, 'El equipo del profesor no tiene red', '2016-10-25 00:00:00', 'HZ026246 -> Urgente: No Contacto: Jon Pabellon/Aula: Pab. 3 Taller 3 Electricidad', 'En espera'),
(16, '2016-10-27 00:00:00', 'fmaizkara@elorrieta-errekamari.com', 1, 4, 1, 'cuando me conecto como administrador no me deja acceder al equipo hz072081 (verificado que está encendido) desde el que instalo los autocads.\nEn el resto de equipos si me deja.....\nhz072081 ó \\10.22.20.88msedu(f)', '2016-11-03 00:00:00', 'hz046565 -> Urgente: No Contacto: alfonso-rafa Pabellon/Aula: aula013 pab 2', 'En espera'),
(20, '2018-02-01 08:51:55', 'Adios@gmail.com', 3, 4, 1, 'Describiendo cosas importantes', '2018-02-01 08:51:55', '', 'Iniciada'),
(21, '2018-02-01 08:58:39', 'AAA', 1, 3, 2, 'AAAA', '2000-01-01 00:00:00', 'Oharrak', 'Procesando'),
(22, '2018-02-01 09:09:41', 'aa', 2, 3, 2, 'aaa', '2018-02-01 09:09:34', '', 'Iniciada'),
(23, '2018-02-01 09:18:55', 'hola@gmail.com', 3, 5, 1, 'Descripcion de la incidencia', '2018-02-22 14:18:55', 'Observaciones de la incidencia', 'Iniciada'),
(24, '2018-02-01 09:27:26', 'aaa', 2, 3, 1, 'aa', '2018-02-01 09:27:17', 'Oharrak', 'Finalizada'),
(25, '2018-02-05 10:12:48', 'AAA', 1, 4, 1, 'AAA', '2018-02-06 10:12:34', 'AAA', 'Cancelada'),
(26, '2018-02-05 10:22:59', 'aa', 2, 4, 3, 'aaa', '2018-02-05 10:22:51', '', 'Iniciada'),
(27, '2017-12-22 09:18:19', 'infialonso@elorrieta-errekamari.com', 4, 1, 4, '  Al arrancar error: no such partition.\n      Entering rescue mode...\n      grub rescue>\n', NULL, 'pasa lo mismo con el equipo  HZ026733 ', 'Procesando'),
(28, '2018-01-09 12:01:45', 'infialonso@elorrieta-errekamari.com', 8, 1, 3, 'no arranca. Falla disco duro', NULL, 'pediente de clonación', 'Procesando'),
(29, '2018-01-22 12:07:15', 'asier.sarabialo@elorrieta-errekamari.com', 9, 1, 3, 'pantalla bloqueada y necesidad de otro disco duro', NULL, '', 'Iniciada'),
(44, '2018-02-06 08:48:37', 'aaaa', 12, 2, 5, 'aaa', '2018-02-06 08:48:18', 'aaa', 'Iniciada'),
(45, '2018-02-08 12:13:51', 'AAAA', 9, 3, 1, 'AAA', '2018-02-08 12:13:43', 'VVVV', 'Iniciada'),
(46, '2018-02-14 08:32:38', 'eder@gmail.com', 3, 4, 3, 'Soy eder', '2018-02-24 08:32:38', '', 'Iniciada'),
(76, '2018-02-14 11:47:48', 'jdslkajdlka@gmail.com', 1, 1, 1, 'Esto no tira hulio', '2019-12-20 15:15:15', 'HULIO', 'Finalizada'),
(77, '2018-02-14 13:21:31', 'aa', 2, 1, 4, 'aaa', '2018-02-14 01:21:21', 'aaaa', 'Iniciada'),
(75, '2018-01-23 12:25:58', 'infpllorente@elorrieta-errekamari.com', 22, 1, 3, 'Puesto con arranque dual linux mint + particion windows 10 elorrieta + particion w10 practicas (2 usuarios superior y medio). Instalar Office 2010, antivirus del centro y libre,  google chrome y flash player.', '2018-01-29 00:00:00', '', 'Iniciada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Inventario`
--

CREATE TABLE IF NOT EXISTS `Inventario` (
  `IdEquipo` int(11) NOT NULL auto_increment,
  `ETIQUETA` tinytext NOT NULL,
  `Arranca` bit(1) default NULL,
  `Aula` int(11) NOT NULL,
  `Ubicacion` tinytext,
  `PlacaBase` varchar(255) default NULL,
  `Manual` varchar(255) default NULL,
  `Procesador` varchar(255) default NULL,
  `TipoNumModulosRAM` varchar(255) default NULL,
  `TesteoRAM` bit(1) default NULL,
  `DiscoDuro` varchar(255) default NULL,
  `TesteoHD` bit(1) default NULL,
  `Tecnico` int(11) default NULL,
  `FechaUltimoTesteo` datetime default NULL,
  `Pabellon` int(11) NOT NULL,
  `Estado` char(10) NOT NULL default 'Alta',
  PRIMARY KEY  (`IdEquipo`),
  KEY `fk_Equipos_Aula1_idx` (`Aula`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=30 ;

--
-- Volcar la base de datos para la tabla `Inventario`
--

INSERT INTO `Inventario` (`IdEquipo`, `ETIQUETA`, `Arranca`, `Aula`, `Ubicacion`, `PlacaBase`, `Manual`, `Procesador`, `TipoNumModulosRAM`, `TesteoRAM`, `DiscoDuro`, `TesteoHD`, `Tecnico`, `FechaUltimoTesteo`, `Pabellon`, `Estado`) VALUES
(1, 'HZ000856', b'1', 1, '', '', '', '', 'O MASSSSS', b'1', '', b'1', 14, '0000-00-00 00:00:00', 1, 'Alta'),
(27, 'HZ111111', b'1', 1, '', '', '', '', '', b'1', '', b'1', 8, '0000-00-00 00:00:00', 1, 'Alta'),
(28, 'a', b'1', 4, 'a', 'a', 'a', 'a', 'a', b'1', 'a', b'0', 25, '2018-02-14 01:42:40', 1, 'Iniciada'),
(2, 'HZ000803', b'0', 1, 'SUELO', 'QBI SUPERB 4FX', NULL, 'Intel Pentium 4   2,66Ghz /S12/533', '2 MODULOS - 512 MB DDR-LOSDOS', b'0', '1-HD   IDE, 120GB (SEAGATE Barracuda 7200.7)', b'0', NULL, NULL, 0, 'Alta'),
(3, 'HZ008357', b'0', 1, 'SUELO', 'QBI SUPERB 4FX', NULL, 'Intel Pentium 4   2,66Ghz /S12/533', '2 MODULOS - 512 MB DDR-LOSDOS', b'0', '1-HD   IDE, 120GB (SEAGATE Barracuda 7200.7)', b'0', NULL, NULL, 0, 'Alta'),
(29, 'JAMEMATEN', b'1', 1, '', '', '', '', '', b'1', '', b'1', 4, '0000-00-00 00:00:00', 1, 'Alta'),
(26, 'HZGUAY', b'1', 1, '', '', '', '', '', b'1', '', b'1', 4, '0000-00-00 00:00:00', 1, 'Alta'),
(23, 'dfzvsd', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, '2018-06-02 09:11:27', 0, '1'),
(24, 'HZ007', NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 4, '2018-06-02 09:40:45', 0, '1'),
(25, 'HZ587932', b'1', 2, 'Bilbao', 'asus', 'www.google.es', 'intel i7', '16GB', b'1', '1TB', b'1', 3, '2018-01-15 09:31:32', 0, 'Alta');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Pabellones`
--

CREATE TABLE IF NOT EXISTS `Pabellones` (
  `IdPabellon` int(11) NOT NULL auto_increment,
  `Nombre` tinytext NOT NULL,
  `Descripcion` tinytext,
  PRIMARY KEY  (`IdPabellon`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Volcar la base de datos para la tabla `Pabellones`
--

INSERT INTO `Pabellones` (`IdPabellon`, `Nombre`, `Descripcion`) VALUES
(1, 'Pabellon 5 Elorrieta', 'Informatica Elorrieta'),
(2, 'Pabellón 1 Elorrieta', NULL),
(3, 'Pabellón 2 Elorrieta', NULL),
(4, 'Pabellon 3 Elorrieta', NULL),
(5, 'Pabellon 4 Elorrieta', NULL),
(6, 'Pabellon Errekamari', NULL),
(0, 'DOMINION', NULL),
(10, 'Migracion', NULL),
(11, 'HOLA', 'NOSE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Tecnicos`
--

CREATE TABLE IF NOT EXISTS `Tecnicos` (
  `IdTecnico` int(11) NOT NULL auto_increment,
  `Nombre` tinytext NOT NULL,
  `Apellidos` tinytext,
  `Email` tinytext,
  `Estado` tinytext NOT NULL,
  `Grupo` int(11) default NULL,
  PRIMARY KEY  (`IdTecnico`),
  KEY `fk_Tecnicos_Grupos1_idx` (`Grupo`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=54 ;

--
-- Volcar la base de datos para la tabla `Tecnicos`
--

INSERT INTO `Tecnicos` (`IdTecnico`, `Nombre`, `Apellidos`, `Email`, `Estado`, `Grupo`) VALUES
(1, 'Christian', 'Amusquivar', 'dasdasd', 'Baja', 2),
(2, 'Lu', 'Barruso', 'aaaa', 'Baja', 0),
(3, 'Unai', 'Baza', '', 'Alta', 2),
(4, 'Eneko', 'Burgos', '', 'Baja', NULL),
(5, 'Xabier', 'Díaz', '', 'Alta', NULL),
(6, 'Cristian', 'Fernandez', '', 'Alta', 3),
(7, 'Julen', 'García', '', 'Alta', NULL),
(8, 'Gorka', 'García', '', 'Alta', NULL),
(9, 'Eneko', 'Hidalgo', '', 'Alta', NULL),
(10, 'Txabi', 'Izaguirre', '', 'Alta', NULL),
(11, 'Ibai', 'Larrinaga', '', 'Alta', 2),
(12, 'Eneko', 'Lazaro', 'eneko@eneko.com', 'Baja', 1),
(13, 'Mikel', 'Llorente', '', 'Alta', NULL),
(14, 'Aitor', 'Mardones', '', 'Alta', NULL),
(15, 'Adrian', 'Martinez', '', 'Alta', 3),
(16, 'Badr', 'Mounib', '', 'Alta', NULL),
(17, 'Guillermo', 'Obregón', '', 'Alta', NULL),
(18, 'Pablo', 'Pérez', '', 'Alta', NULL),
(19, 'Nikolay', 'Poza', '', 'Alta', NULL),
(20, 'Iñaki', 'Sagrario', '', 'Alta', NULL),
(21, 'Asier', 'Sarabia', '', 'Alta', NULL),
(22, 'Yeray', 'Turrión', '', 'Alta', NULL),
(23, 'Yeray', 'Varona', '', 'Alta', NULL),
(24, 'Raisa', 'Vicente', '', 'Alta', NULL),
(25, 'Xabier', 'Villayandre', '', 'Alta', NULL),
(26, 'Eder', 'Martinez', '', 'Alta', NULL),
(27, 'Julian', 'Gomes', '', 'Alta', 4),
(28, 'Pepito', 'Hernandes', 'pphernandes@gmail.com', 'Alta', 4),
(29, 'Jorge', 'Perez', '', 'Alta', 3),
(30, 'asdasd', '', '', 'Alta', 3),
(31, 'Esejokes', 'Master', 'jokins@gmail.com', 'Baja', 2),
(32, 'Pan', 'Pantxi', 'hehexd@gmail.com', 'Alta', 1),
(33, 'Antonio', 'Recio', 'mariscosrecio@hotmail.es', '', 0),
(38, 'Apascovi', 'Felaez', 'ApascoviFelaez@gmail.com', 'Alta', 3),
(37, 'LyanSitho_', 'Wey', 'julen', 'Alta', 3),
(39, 'Carmen', 'De mairena', 'carmendemairena@meetic.es', 'Alta', 5),
(40, 'Equipo 4. Adrian y Cristian', ' ', 'infialonso@elorrieta-errekamari.com', 'Alta', NULL),
(41, 'Equipo 1. Ibai', ' ', 'infialonso@elorrieta-errekamari.com', 'Alta', NULL),
(42, '', ' ', 'asier.sarabialo@elorrieta-errekamari.com', 'Alta', NULL),
(43, 'Equipo 1. Gorka y Luca', ' ', 'infpllorente@elorrieta-errekamari.com', 'Alta', NULL),
(44, 'Equipo 1. Ibai y Christian', ' ', 'infpllorente@elorrieta-errekamari.com', 'Alta', NULL),
(45, 'a', 'b', 'c', 'Alta', 1),
(46, 'antonia', 'larrazabal', 'anton.larrazabalhi@elorrieta', 'Alta', 3),
(47, 'kiko', 'kikez', 'kikez@gmail.com', 'Alta', 7),
(48, 'aaaaa', 'aaa', 'aaa', 'Alta', 4),
(49, 'Asier', 'Caca', 'a@gmail.com', 'Alta', -1),
(50, 'kkkkkkkkkkkkkkkk', 'kkkkkkkkkkkkkkk', 'kkkkkkkkkkkkkkkkkkk', 'Alta', -1),
(51, 'hhh', 'hhhhhhhhhhhhhhhhhhhhh', 'hhhhhhhhhhhhhhhhhhhhhh', 'Alta', -1),
(52, 'kkkkkkkkkkkkkkkkkkkk', 'kkkkkkkkkkkkkkkkkkkkkkkkk', 'kkkkkkkkkkkkkkkkkkkkk', 'Alta', -1),
(53, 'gge', 'erter', 'erer', 'Alta', 2);
