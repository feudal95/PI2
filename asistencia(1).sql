-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 27-02-2019 a las 09:17:40
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `asistencia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `idalumnos` int(11) NOT NULL,
  `RFID` varchar(255) NOT NULL,
  `matricula` varchar(45) NOT NULL,
  `nombreAlumno` varchar(255) NOT NULL,
  `docentes_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistencia`
--

CREATE TABLE `asistencia` (
  `salon_idsalon` int(11) NOT NULL,
  `matricula` varchar(255) NOT NULL,
  `fecha` date NOT NULL,
  `on_time` tinyint(4) DEFAULT NULL,
  `delay` tinyint(4) DEFAULT NULL,
  `alumnos_idalumnos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `docentes`
--

CREATE TABLE `docentes` (
  `id` int(11) NOT NULL,
  `matricula` varchar(45) NOT NULL,
  `pass` varchar(45) NOT NULL,
  `nombreDocente` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `docentes`
--

INSERT INTO `docentes` (`id`, `matricula`, `pass`, `nombreDocente`) VALUES
(1, '1791586', '178231', 'Diego');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salon`
--

CREATE TABLE `salon` (
  `idsalon` int(11) NOT NULL,
  `num_salon` varchar(45) NOT NULL,
  `materia` varchar(255) NOT NULL,
  `horaInicio` varchar(45) NOT NULL,
  `horaFinal` varchar(45) NOT NULL,
  `semestre` varchar(45) NOT NULL,
  `lunes` tinyint(4) NOT NULL DEFAULT '0',
  `martes` tinyint(4) NOT NULL DEFAULT '0',
  `miercoles` tinyint(4) NOT NULL DEFAULT '0',
  `jueves` tinyint(4) NOT NULL DEFAULT '0',
  `viernes` tinyint(4) NOT NULL DEFAULT '0',
  `sabado` tinyint(4) NOT NULL DEFAULT '0',
  `docentes_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='		';

--
-- Volcado de datos para la tabla `salon`
--

INSERT INTO `salon` (`idsalon`, `num_salon`, `materia`, `horaInicio`, `horaFinal`, `semestre`, `lunes`, `martes`, `miercoles`, `jueves`, `viernes`, `sabado`, `docentes_id`) VALUES
(0, '1202', 'Fisica II', 'M1', 'M2', 'tercero', 0, 0, 0, 0, 0, 0, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`idalumnos`,`docentes_id`);

--
-- Indices de la tabla `asistencia`
--
ALTER TABLE `asistencia`
  ADD PRIMARY KEY (`salon_idsalon`,`alumnos_idalumnos`);

--
-- Indices de la tabla `docentes`
--
ALTER TABLE `docentes`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `salon`
--
ALTER TABLE `salon`
  ADD PRIMARY KEY (`idsalon`,`docentes_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `docentes`
--
ALTER TABLE `docentes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
