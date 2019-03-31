-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 01, 2019 at 12:24 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `asistencia`
--

-- --------------------------------------------------------

--
-- Table structure for table `alumnos`
--

CREATE TABLE `alumnos` (
  `idalumnos` int(11) NOT NULL,
  `RFID` varchar(255) NOT NULL,
  `matricula` varchar(45) NOT NULL,
  `nombreAlumno` varchar(255) NOT NULL,
  `docentes_id` int(11) NOT NULL,
  `salon_idsalon` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `alumnos`
--

INSERT INTO `alumnos` (`idalumnos`, `RFID`, `matricula`, `nombreAlumno`, `docentes_id`, `salon_idsalon`) VALUES
(0, '1', '1', '1', 1, 1),
(0, '123asa', '123as', 'Diego', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `asistencia`
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
-- Table structure for table `docentes`
--

CREATE TABLE `docentes` (
  `id` int(11) NOT NULL,
  `matricula` varchar(45) NOT NULL,
  `pass` varchar(45) NOT NULL,
  `nombreDocente` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `docentes`
--

INSERT INTO `docentes` (`id`, `matricula`, `pass`, `nombreDocente`) VALUES
(1, '1791586', '178231', 'Diego');

-- --------------------------------------------------------

--
-- Table structure for table `salon`
--

CREATE TABLE `salon` (
  `idsalon` int(11) NOT NULL,
  `num_salon` varchar(45) NOT NULL,
  `materia` varchar(255) NOT NULL,
  `horaInicio` time NOT NULL,
  `horaFinal` time NOT NULL,
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
-- Dumping data for table `salon`
--

INSERT INTO `salon` (`idsalon`, `num_salon`, `materia`, `horaInicio`, `horaFinal`, `semestre`, `lunes`, `martes`, `miercoles`, `jueves`, `viernes`, `sabado`, `docentes_id`) VALUES
(1, '1202', 'Fisica II', '12:00:00', '00:00:00', 'tercero', 0, 0, 0, 0, 0, 0, 1),
(6, '1782', 'ciencias', '00:00:00', '13:50:00', '14:30:00', 0, 0, 0, 0, 0, 0, 1),
(7, '1782', 'ciencias', '00:00:00', '14:00:00', '14:30:00', 0, 0, 0, 0, 0, 1, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asistencia`
--
ALTER TABLE `asistencia`
  ADD PRIMARY KEY (`salon_idsalon`,`alumnos_idalumnos`);

--
-- Indexes for table `docentes`
--
ALTER TABLE `docentes`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `salon`
--
ALTER TABLE `salon`
  ADD PRIMARY KEY (`idsalon`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `docentes`
--
ALTER TABLE `docentes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `salon`
--
ALTER TABLE `salon`
  MODIFY `idsalon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
