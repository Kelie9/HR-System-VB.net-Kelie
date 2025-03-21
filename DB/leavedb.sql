-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 21, 2025 at 12:23 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `leavedb`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `EMPID` varchar(60) NOT NULL,
  `emp_fname` varchar(60) DEFAULT NULL,
  `emp_lname` varchar(60) DEFAULT NULL,
  `emp_mname` varchar(60) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact` varchar(20) DEFAULT NULL,
  `status` varchar(30) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `birth_place` varchar(100) DEFAULT NULL,
  `emp_sex` varchar(10) DEFAULT NULL,
  `emp_age` int(10) DEFAULT NULL,
  `emerg_contct` varchar(25) DEFAULT NULL,
  `REMAININGLEAVE` double NOT NULL,
  `DEFAULTLEAVE` double NOT NULL,
  `ONLEAVE` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`EMPID`, `emp_fname`, `emp_lname`, `emp_mname`, `address`, `contact`, `status`, `birth_date`, `birth_place`, `emp_sex`, `emp_age`, `emerg_contct`, `REMAININGLEAVE`, `DEFAULTLEAVE`, `ONLEAVE`) VALUES
('0000127', 'AHEREZA', 'ELIAS', 'NA', 'LUZIRA', '0777115678', 'Married', '1994-01-21', 'MBARARA', 'MALE', NULL, '0777978697', 30, 30, 0),
('0000128', 'STUDENT', 'ANONSIYATA', 'NA', 'KANUNGU', '07777777777', 'Married', '1980-03-21', 'KANUNGU', 'FEMALE', NULL, '07888888888', 30, 30, 0);

-- --------------------------------------------------------

--
-- Table structure for table `employee_workinfo`
--

CREATE TABLE `employee_workinfo` (
  `id` int(10) NOT NULL,
  `EMPID` int(30) NOT NULL,
  `d_rate` double DEFAULT NULL,
  `p_method` varchar(60) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL,
  `w_status` varchar(60) DEFAULT NULL,
  `d_hired` date DEFAULT NULL,
  `DEPARTMENT` varchar(50) NOT NULL,
  `w_type` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `employee_workinfo`
--

INSERT INTO `employee_workinfo` (`id`, `EMPID`, `d_rate`, `p_method`, `position`, `w_status`, `d_hired`, `DEPARTMENT`, `w_type`) VALUES
(51, 127, 57, 'Monthly', 'Staff', NULL, '2025-03-20', 'Human Resource Dept.', 'Regular'),
(52, 128, 12, 'Monthly', 'Supervisor', NULL, '2005-03-21', 'ICT', 'Regular');

-- --------------------------------------------------------

--
-- Table structure for table `leave`
--

CREATE TABLE `leave` (
  `LEAVEID` int(11) NOT NULL,
  `EMPID` int(11) NOT NULL,
  `LEAVECODE` int(11) NOT NULL,
  `LEAVEFORMAT` varchar(30) NOT NULL,
  `LEAVEAPPLIED` varchar(50) NOT NULL,
  `DATEFROM` datetime NOT NULL,
  `DATETO` datetime NOT NULL,
  `LEAVEDATE` datetime NOT NULL,
  `LEAVEENDDATE` datetime NOT NULL,
  `NODAYS` double NOT NULL,
  `REASON` text NOT NULL,
  `DAYOFFSCHEDULE` datetime NOT NULL,
  `REMARKS` varchar(30) NOT NULL,
  `APPLIED` tinyint(1) NOT NULL,
  `STATUS` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `leave`
--

INSERT INTO `leave` (`LEAVEID`, `EMPID`, `LEAVECODE`, `LEAVEFORMAT`, `LEAVEAPPLIED`, `DATEFROM`, `DATETO`, `LEAVEDATE`, `LEAVEENDDATE`, `NODAYS`, `REASON`, `DAYOFFSCHEDULE`, `REMARKS`, `APPLIED`, `STATUS`) VALUES
(1, 20425, 0, 'Without Pay', 'Sick', '2015-02-22 06:02:15', '2015-02-22 06:02:15', '2015-02-22 02:02:15', '0000-00-00 00:00:00', 1, '0', '2015-02-22 02:02:15', 'Approved', 1, 'Pending'),
(2, 20424, 0, 'Without Pay', 'Sick', '2015-02-25 06:31:25', '2015-02-25 12:31:25', '2015-02-25 07:31:25', '2015-02-25 07:31:25', 0, '0', '2015-02-25 07:31:25', 'Pending', 1, 'Pending'),
(3, 20425, 0, 'Without Pay', 'Sick', '2015-02-25 06:33:33', '2015-02-25 12:33:33', '2015-02-25 07:33:33', '2015-02-25 07:33:33', 0, '0', '2015-02-25 07:33:33', 'Pending', 1, 'Pending'),
(4, 20421, 0, 'With Pay', 'Sick', '2015-02-25 06:35:51', '2015-02-25 12:35:51', '2015-02-25 07:35:51', '2015-02-25 07:35:51', 0, 'asdasd', '2015-02-25 07:35:51', 'Pending', 1, 'Pending'),
(5, 20424, 0, 'Without Pay', 'Sick', '2015-02-25 06:37:36', '2015-02-25 12:37:36', '2015-02-25 07:37:36', '2015-02-25 07:37:36', 0.5, 'asdasdasasd', '2015-02-25 07:37:36', 'Pending', 1, 'Pending'),
(6, 116, 0, 'With Pay', 'Sick', '2015-02-26 12:05:22', '2015-02-26 12:05:22', '2015-02-04 12:05:22', '2015-02-11 12:05:22', 7, 'I have a fever.', '2015-02-06 12:05:22', 'Approved', 1, 'Pending'),
(7, 117, 0, 'With Pay', 'AccidentOnDuty', '2015-02-26 12:06:47', '2015-02-26 12:06:47', '2015-01-20 12:06:47', '2015-01-29 12:06:47', 9, 'Car Accident.', '2015-01-26 12:06:47', 'Approved', 1, 'Pending'),
(8, 118, 0, 'With Pay', 'Vacation', '2015-02-26 12:08:36', '2015-02-26 12:08:36', '2015-02-11 12:08:36', '2015-02-14 12:08:36', 3, 'Family Matter.', '2015-02-26 12:08:36', 'Approved', 1, 'Pending'),
(9, 111, 0, 'With Pay', 'Sick', '2015-02-26 12:09:28', '2015-02-26 12:09:28', '2015-02-03 12:09:28', '2015-02-06 12:09:28', 3, 'Chicken Pox.', '2015-02-26 12:09:28', 'Approved', 1, 'Pending'),
(10, 119, 0, 'With Pay', 'Sick', '2015-02-26 12:11:28', '2015-02-26 12:11:28', '2015-02-26 12:11:27', '2015-02-26 12:11:27', 0, 'im sick', '2015-02-26 12:11:28', 'Approved', 1, 'Pending'),
(11, 121, 0, 'With Pay', 'Sick', '2015-02-26 02:04:15', '2015-02-26 02:04:15', '2015-02-26 02:04:15', '2015-02-26 02:04:15', 0, 'Sick', '2015-02-26 02:04:15', 'Approved', 1, 'Pending'),
(12, 112, 0, 'With Pay', 'Vacation', '2015-02-26 02:10:09', '2015-02-26 02:10:09', '2015-02-26 02:10:09', '2015-02-28 02:10:09', 1, 'asdasd', '2015-02-26 02:10:09', 'Approved', 1, 'Pending'),
(13, 113, 0, 'Without Pay', 'Sick', '2015-02-26 02:10:47', '2015-02-26 02:10:47', '2015-02-26 02:10:47', '2015-02-28 02:10:47', 1, 'zxcz', '2015-02-26 02:10:47', 'Approved', 1, 'Pending'),
(14, 117, 0, 'With Pay', 'Paternity', '2015-02-26 02:11:19', '2015-02-26 02:11:19', '2015-02-26 02:11:19', '2015-03-01 02:11:19', 2, 'zXcszczx', '2015-02-26 02:11:19', 'Approved', 1, 'Pending'),
(15, 119, 0, 'With Pay', 'Sick', '2015-02-26 02:16:53', '2015-02-26 02:16:53', '2015-02-26 02:16:53', '2015-03-01 02:16:53', 2, 'sadadas', '2015-02-26 02:16:53', 'Approved', 1, 'Pending'),
(16, 117, 0, 'Without Pay', 'Sick', '2015-02-26 02:19:13', '2015-02-26 02:19:13', '2015-02-25 02:19:13', '2015-02-27 02:19:13', 2, 'zxcz', '2015-02-26 02:19:13', 'Approved', 1, 'Pending'),
(17, 111, 0, 'With Pay', 'Sick', '2015-02-26 02:29:58', '2015-02-26 02:29:58', '2015-02-25 02:29:58', '2015-02-26 02:29:58', 1, 'asdasd', '2015-02-26 02:29:58', 'Approved', 1, 'Pending'),
(18, 115, 0, 'Without Pay', 'Vacation', '2015-02-26 02:43:39', '2015-02-26 02:43:39', '2015-02-16 02:43:39', '2015-02-26 02:43:39', 10, 'asdasdas', '2015-02-26 02:43:39', 'Approved', 1, 'Pending'),
(19, 18, 0, 'With Pay', 'Vacation', '2015-02-26 09:22:16', '2015-02-26 09:22:16', '2015-02-01 09:22:16', '2015-02-28 09:22:16', 27, 'Libre ni Paris Hilton.', '2015-02-26 09:22:16', 'Cancelled', 1, 'Pending'),
(20, 114, 0, '', 'Sick', '2015-02-26 09:52:56', '2015-02-26 09:52:56', '2015-02-20 09:52:56', '2015-02-26 09:52:56', 6, 'Admitted to the Hospital.', '2015-02-26 09:52:56', 'Approved', 1, 'Pending'),
(21, 124, 0, 'With Pay', 'Paternity', '2015-02-26 07:21:44', '2015-02-26 05:30:44', '2015-02-26 10:21:44', '2015-02-27 10:21:44', 0.5, 'gonna watch over my wife', '2015-02-28 10:21:44', 'Cancelled', 1, 'Pending'),
(22, 126, 0, 'With Pay', 'Sick', '2015-02-26 12:25:55', '2015-02-26 12:25:55', '2015-02-05 12:25:55', '2015-02-10 12:25:55', 5, 'I have a fever.', '2015-02-26 12:25:55', 'Approved', 1, 'Pending'),
(23, 115, 0, 'Without Pay', 'Sick', '2015-03-12 01:40:13', '2015-03-12 01:40:13', '2015-03-12 01:40:13', '2015-03-14 01:40:13', 1, 'sick', '2015-03-12 01:40:13', 'Approved', 1, 'Approved'),
(24, 123, 0, 'Without Pay', 'Sick', '2015-03-12 01:57:51', '2015-03-12 01:57:51', '2015-03-12 01:57:51', '2015-03-15 01:57:51', 3, 'asdasda', '2015-03-12 01:57:51', 'Approved', 1, 'Approved'),
(25, 117, 0, 'With Pay', 'Sick', '2015-03-12 01:30:25', '2015-03-12 06:00:25', '2015-03-12 02:19:25', '2015-03-12 02:19:25', 0, 'asd', '2015-03-12 02:19:25', 'Approved', 1, 'Approved'),
(26, 116, 0, 'With Pay', 'Sick', '2015-03-12 01:30:41', '2015-03-12 06:00:41', '2015-03-12 02:21:41', '2015-03-12 02:21:41', 0.5, 'sadas', '2015-03-12 02:21:41', 'Approved', 1, 'Approved'),
(27, 0, 0, 'With Pay', 'Sick', '2025-03-21 12:01:34', '2025-03-21 12:01:34', '2025-03-21 12:01:34', '2025-04-21 12:01:34', 30, '', '2025-03-21 12:01:34', 'Approved', 1, 'Approved'),
(28, 128, 0, 'With Pay', 'Sick', '2025-03-21 12:02:44', '2025-03-21 12:02:44', '2025-03-21 12:02:44', '2025-04-21 12:02:44', 30, '', '2025-03-21 12:02:44', 'Approved', 1, 'Approved');

-- --------------------------------------------------------

--
-- Table structure for table `tblapproveleave`
--

CREATE TABLE `tblapproveleave` (
  `APPROVEDID` int(11) NOT NULL,
  `LEAVEID` int(11) NOT NULL,
  `LEAVECODE` varchar(30) NOT NULL,
  `EMPID` varchar(30) NOT NULL,
  `NODAYSAPPROVE` int(30) NOT NULL,
  `user_id` varchar(30) NOT NULL,
  `STATUS` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblapproveleave`
--

INSERT INTO `tblapproveleave` (`APPROVEDID`, `LEAVEID`, `LEAVECODE`, `EMPID`, `NODAYSAPPROVE`, `user_id`, `STATUS`) VALUES
(1, 1, '0', '20425', 1, '12', 'APPROVE'),
(2, 6, '0', '0000116', 7, '12', 'APPROVE'),
(3, 7, '0', '0000117', 9, '12', 'APPROVE'),
(4, 8, '0', '0000118', 3, '12', 'APPROVE'),
(5, 9, '0', '0000111', 3, '12', 'APPROVE'),
(6, 9, '0', '0000111', 3, '12', 'APPROVE'),
(7, 9, '0', '0000111', 3, '12', 'APPROVE'),
(8, 10, '0', '0000119', 0, '12', 'APPROVE'),
(9, 11, '0', '0000121', 0, '12', 'APPROVE'),
(10, 13, '0', '0000113', 1, '12', 'APPROVE'),
(11, 12, '0', '0000112', 1, '12', 'APPROVE'),
(12, 14, '0', '0000117', 2, '12', 'APPROVE'),
(13, 16, '0', '0000117', 2, '12', 'APPROVE'),
(14, 15, '0', '0000119', 2, '12', 'APPROVE'),
(15, 17, '0', '0000111', 1, '10328', 'APPROVE'),
(16, 18, '0', '0000115', 10, '10328', 'APPROVE'),
(17, 20, '0', '0000114', 6, '10328', 'APPROVE'),
(18, 22, '0', '0000126', 5, '12', 'APPROVE');

-- --------------------------------------------------------

--
-- Table structure for table `tblautonumber`
--

CREATE TABLE `tblautonumber` (
  `id` int(11) NOT NULL,
  `STRT` varchar(30) NOT NULL,
  `END` int(11) NOT NULL,
  `INCREMENT` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblautonumber`
--

INSERT INTO `tblautonumber` (`id`, `STRT`, `END`, `INCREMENT`, `DESCRIPTION`) VALUES
(1, '00001', 29, 1, 'employee'),
(2, '1032', 9, 1, 'user');

-- --------------------------------------------------------

--
-- Table structure for table `tbldepartment`
--

CREATE TABLE `tbldepartment` (
  `ID` int(11) NOT NULL,
  `DEPARTMENT` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbldepartment`
--

INSERT INTO `tbldepartment` (`ID`, `DEPARTMENT`) VALUES
(5, 'Finance Dept.'),
(8, 'Human Resource'),
(9, 'Coporate & Coperation Affairs'),
(10, 'Planning'),
(11, 'Transport and Logistics'),
(12, 'ICT'),
(13, 'SACCO'),
(14, 'PROCUREMENT'),
(15, 'AUDITING'),
(16, 'RESEARCH & PROJECTS'),
(17, 'PENSIONS'),
(18, 'INSPECTORATE');

-- --------------------------------------------------------

--
-- Table structure for table `tblleaveinfo`
--

CREATE TABLE `tblleaveinfo` (
  `LEAVEID` int(11) NOT NULL,
  `EMPID` varchar(11) NOT NULL,
  `REASONS` varchar(30) NOT NULL,
  `LEAVEDAYS` int(11) NOT NULL,
  `DEFAULT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblleaveinfo`
--

INSERT INTO `tblleaveinfo` (`LEAVEID`, `EMPID`, `REASONS`, `LEAVEDAYS`, `DEFAULT`) VALUES
(1, '000017', 'SICK', 15, 0),
(2, '000017', 'MATERNITY', 15, 0),
(3, '000017', 'Vacation', 15, 0),
(4, '000017', 'Funeral', 15, 0),
(5, '000017', 'Paternity', 15, 0),
(6, '000017', 'Accident On Duty', 15, 0),
(7, '000018', 'SICK', 15, 0),
(8, '000018', 'MATERNITY', 15, 0),
(9, '000018', 'Vacation', 15, 0),
(10, '000018', 'Funeral', 15, 0),
(11, '000018', 'Paternity', 15, 0),
(12, '000018', 'Accident On Duty', 15, 0),
(13, '000019', 'SICK', 15, 0),
(14, '000019', 'MATERNITY', 15, 0),
(15, '000019', 'Vacation', 15, 0),
(16, '000019', 'Funeral', 15, 0),
(17, '000019', 'Paternity', 15, 0),
(18, '000019', 'Accident On Duty', 15, 0),
(19, '0000110', 'SICK', 15, 0),
(20, '0000110', 'MATERNITY', 15, 0),
(21, '0000110', 'Vacation', 15, 0),
(22, '0000110', 'Funeral', 15, 0),
(23, '0000110', 'Paternity', 15, 0),
(24, '0000110', 'Accident On Duty', 15, 0),
(25, '0000111', 'SICK', 15, 0),
(26, '0000111', 'MATERNITY', 15, 0),
(27, '0000111', 'Vacation', 15, 0),
(28, '0000111', 'Funeral', 15, 0),
(29, '0000111', 'Paternity', 15, 0),
(30, '0000111', 'Accident On Duty', 15, 0),
(31, '0000112', 'SICK', 15, 0),
(32, '0000112', 'MATERNITY', 15, 0),
(33, '0000112', 'Vacation', 15, 0),
(34, '0000112', 'Funeral', 15, 0),
(35, '0000112', 'Paternity', 15, 0),
(36, '0000112', 'Accident On Duty', 15, 0),
(37, '0000113', 'SICK', 15, 0),
(38, '0000113', 'MATERNITY', 15, 0),
(39, '0000113', 'Vacation', 15, 0),
(40, '0000113', 'Funeral', 15, 0),
(41, '0000113', 'Paternity', 15, 0),
(42, '0000113', 'Accident On Duty', 15, 0),
(43, '0000114', 'SICK', 15, 0),
(44, '0000114', 'MATERNITY', 15, 0),
(45, '0000114', 'Vacation', 15, 0),
(46, '0000114', 'Funeral', 15, 0),
(47, '0000114', 'Paternity', 15, 0),
(48, '0000114', 'Accident On Duty', 15, 0),
(49, '0000115', 'SICK', 15, 0),
(50, '0000115', 'MATERNITY', 15, 0),
(51, '0000115', 'Vacation', 15, 0),
(52, '0000115', 'Funeral', 15, 0),
(53, '0000115', 'Paternity', 15, 0),
(54, '0000115', 'Accident On Duty', 15, 0),
(55, '0000116', 'SICK', 15, 0),
(56, '0000116', 'MATERNITY', 15, 0),
(57, '0000116', 'Vacation', 15, 0),
(58, '0000116', 'Funeral', 15, 0),
(59, '0000116', 'Paternity', 15, 0),
(60, '0000116', 'Accident On Duty', 15, 0),
(61, '0000117', 'SICK', 15, 0),
(62, '0000117', 'MATERNITY', 15, 0),
(63, '0000117', 'Vacation', 15, 0),
(64, '0000117', 'Funeral', 15, 0),
(65, '0000117', 'Paternity', 15, 0),
(66, '0000117', 'Accident On Duty', 15, 0),
(67, '0000118', 'SICK', 15, 0),
(68, '0000118', 'MATERNITY', 15, 0),
(69, '0000118', 'Vacation', 15, 0),
(70, '0000118', 'Funeral', 15, 0),
(71, '0000118', 'Paternity', 15, 0),
(72, '0000118', 'Accident On Duty', 15, 0),
(73, '0000119', 'SICK', 15, 0),
(74, '0000119', 'MATERNITY', 15, 0),
(75, '0000119', 'Vacation', 15, 0),
(76, '0000119', 'Funeral', 15, 0),
(77, '0000119', 'Paternity', 15, 0),
(78, '0000119', 'Accident On Duty', 15, 0),
(79, '0000120', 'SICK', 15, 0),
(80, '0000120', 'MATERNITY', 15, 0),
(81, '0000120', 'Vacation', 15, 0),
(82, '0000120', 'Funeral', 15, 0),
(83, '0000120', 'Paternity', 15, 0),
(84, '0000120', 'Accident On Duty', 15, 0),
(85, '0000121', 'SICK', 15, 0),
(86, '0000121', 'MATERNITY', 15, 0),
(87, '0000121', 'Vacation', 15, 0),
(88, '0000121', 'Funeral', 15, 0),
(89, '0000121', 'Paternity', 15, 0),
(90, '0000121', 'Accident On Duty', 15, 0),
(91, '0000122', 'SICK', 15, 0),
(92, '0000122', 'MATERNITY', 15, 0),
(93, '0000122', 'Vacation', 15, 0),
(94, '0000122', 'Funeral', 15, 0),
(95, '0000122', 'Paternity', 15, 0),
(96, '0000122', 'Accident On Duty', 15, 0),
(97, '0000123', 'SICK', 15, 0),
(98, '0000123', 'MATERNITY', 15, 0),
(99, '0000123', 'Vacation', 15, 0),
(100, '0000123', 'Funeral', 15, 0),
(101, '0000123', 'Paternity', 15, 0),
(102, '0000123', 'Accident On Duty', 15, 0),
(103, '0000124', 'SICK', 15, 0),
(104, '0000124', 'MATERNITY', 15, 0),
(105, '0000124', 'Vacation', 15, 0),
(106, '0000124', 'Funeral', 15, 0),
(107, '0000124', 'Paternity', 15, 0),
(108, '0000124', 'Accident On Duty', 15, 0),
(109, '0000125', 'SICK', 15, 0),
(110, '0000125', 'MATERNITY', 15, 0),
(111, '0000125', 'Vacation', 15, 0),
(112, '0000125', 'Funeral', 15, 0),
(113, '0000125', 'Paternity', 15, 0),
(114, '0000125', 'Accident On Duty', 15, 0),
(115, '0000126', 'SICK', 15, 0),
(116, '0000126', 'Vacation', 15, 0),
(117, '0000127', 'SICK', 15, 0),
(118, '0000127', 'Vacation', 15, 0),
(119, '0000128', 'SICK', 15, 0),
(120, '0000128', 'Vacation', 15, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE `tblsettings` (
  `ID` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  `FORTHE` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tblsettings`
--

INSERT INTO `tblsettings` (`ID`, `DESCRIPTION`, `FORTHE`) VALUES
(1, 'Staff', 'Position'),
(2, 'Clerk', 'Position'),
(4, 'Audit Committee', 'Position'),
(7, 'Treasurer', 'Position'),
(10, 'Teller', 'Position'),
(11, 'Office Attendant', 'Position'),
(12, 'Supervisor', 'Position');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `user_id` int(30) NOT NULL,
  `name` text DEFAULT NULL,
  `username` varchar(60) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`user_id`, `name`, `username`, `pass`, `type`) VALUES
(12, 'Ahereza Elias', 'admin', '8be3c943b1609fffbfc51aad666d0a04adf83c9d', 'Administrator'),
(10328, 'Kelian', 'HR', '8be3c943b1609fffbfc51aad666d0a04adf83c9d', 'HR Personnel');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EMPID`);

--
-- Indexes for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `leave`
--
ALTER TABLE `leave`
  ADD PRIMARY KEY (`LEAVEID`);

--
-- Indexes for table `tblapproveleave`
--
ALTER TABLE `tblapproveleave`
  ADD PRIMARY KEY (`APPROVEDID`);

--
-- Indexes for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbldepartment`
--
ALTER TABLE `tbldepartment`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblleaveinfo`
--
ALTER TABLE `tblleaveinfo`
  ADD PRIMARY KEY (`LEAVEID`);

--
-- Indexes for table `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_workinfo`
--
ALTER TABLE `employee_workinfo`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT for table `leave`
--
ALTER TABLE `leave`
  MODIFY `LEAVEID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `tblapproveleave`
--
ALTER TABLE `tblapproveleave`
  MODIFY `APPROVEDID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbldepartment`
--
ALTER TABLE `tbldepartment`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `tblleaveinfo`
--
ALTER TABLE `tblleaveinfo`
  MODIFY `LEAVEID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=121;

--
-- AUTO_INCREMENT for table `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `user_id` int(30) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10329;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
