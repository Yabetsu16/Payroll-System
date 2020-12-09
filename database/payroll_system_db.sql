-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2020 at 02:47 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.3.21

SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payroll_system`
--
DROP DATABASE IF EXISTS `payroll_system`;
CREATE DATABASE IF NOT EXISTS `payroll_system` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `payroll_system`;

-- --------------------------------------------------------

--
-- Table structure for table `employee_tb`
--
-- Creation: Dec 03, 2020 at 01:26 PM
-- Last update: Dec 05, 2020 at 10:47 AM
--

CREATE TABLE `employee_tb` (
  `employee_id` int(11) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `type` varchar(100) NOT NULL,
  `job` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELATIONSHIPS FOR TABLE `employee_tb`:
--

--
-- Truncate table before insert `employee_tb`
--

TRUNCATE TABLE `employee_tb`;
--
-- Dumping data for table `employee_tb`
--

INSERT INTO `employee_tb` (`employee_id`, `firstname`, `lastname`, `username`, `password`, `type`, `job`) VALUES
(1, 'Juan', 'Dela Cruz', 'juan', 'juan', 'Regular', 'Web Developer'),
(2, 'Anderson', 'Deborah', 'deborah', '123', 'Regular', 'CHIEF PROGRAMMER/ANALYST'),
(3, 'Abouelkheir', 'Hassan', 'hassan', '123', 'Regular', 'SENIOR PROGRAMMER/ANALYST'),
(4, 'Ahmed', 'Khalid', 'Khalid_Ahmed', 'Khalid_4131', 'Regular', 'CHIEF PROGRAMMER/ANALYST'),
(5, 'Sonya', 'Armstrong', 'Armstrong_Sonya', 'Armstrong_8708', 'Regular', 'PRINCIPAL PROGRAMMER/ANALYST'),
(6, 'James', 'Burger', 'Burger', 'Burger_6484', 'Regular', 'PRINCIPAL SYSTEMS PROGRAMMER'),
(7, 'Dibo', 'Chen', 'Chen_Dibo', 'Chen_6815', 'Regular', 'CHIEF PROGRAMMER/ANALYST'),
(8, 'Nanette', 'Conley', 'Conley_Nanette', 'Conley_6093', 'Regular', 'CHIEF PROGRAMMER/ANALYST'),
(9, 'Maribel', 'Correa', 'Correa_Maribel', 'Correa_3664', 'Regular', 'PROGRAMMER/ANALYST'),
(10, 'Reginald', 'Dean', 'Dean_Reginald', 'Dean_2540', 'Regular', 'PROGRAMMER/ANALYST');

-- --------------------------------------------------------

--
-- Table structure for table `report_tb`
--
-- Creation: Dec 05, 2020 at 05:18 AM
-- Last update: Dec 05, 2020 at 09:58 AM
--

CREATE TABLE `report_tb` (
  `report_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `type` varchar(100) NOT NULL,
  `job` varchar(100) NOT NULL,
  `gross_salary` float NOT NULL,
  `total_deductions` float NOT NULL,
  `tax` float NOT NULL,
  `sss` float NOT NULL,
  `pagibig` float NOT NULL,
  `philhealth` float NOT NULL,
  `loans` float NOT NULL,
  `deductions` float NOT NULL,
  `remarks` varchar(1000) DEFAULT NULL,
  `net_salary` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELATIONSHIPS FOR TABLE `report_tb`:
--

--
-- Truncate table before insert `report_tb`
--

TRUNCATE TABLE `report_tb`;
--
-- Dumping data for table `report_tb`
--

INSERT INTO `report_tb` (`report_id`, `employee_id`, `name`, `type`, `job`, `gross_salary`, `total_deductions`, `tax`, `sss`, `pagibig`, `philhealth`, `loans`, `deductions`, `remarks`, `net_salary`) VALUES
(1, 1, 'Dela Cruz, Juan', 'Regular', 'Web Developer', 30000, 7781.3, 6000, 581.3, 600, 200, 300, 100, 'Late - 100', 22218.7),
(2, 2, 'Deborah, Anderson', 'Regular', 'CHIEF PROGRAMMER/ANALYST', 15000, 6045, 0, 545, 300, 200, 0, 5000, 'Cash Advance - 5000', 8955),
(3, 3, 'Hassan, Abouelkheir', 'Regular', 'SENIOR PROGRAMMER/ANALYST', 50000, 15081.3, 12500, 581.3, 1000, 200, 500, 300, '2x Absent -150', 34918.7),
(4, 4, 'Khalid, Ahmed', 'Regular', 'CHIEF PROGRAMMER/ANALYST', 1000000, 522781, 350000, 581.3, 20000, 200, 2000, 150000, 'Cash Advance - 150,000', 477219),
(5, 5, 'Armstrong, Sonya', 'Regular', 'PRINCIPAL PROGRAMMER/ANALYST', 20000, 1181.3, 0, 581.3, 400, 200, 0, 0, '', 18818.7),
(6, 6, 'Burger, James', 'Regular', 'PRINCIPAL SYSTEMS PROGRAMMER', 300000, 107781, 96000, 581.3, 6000, 200, 0, 5000, '5x Undertime - 1000', 192219),
(7, 7, 'Chen, Dibo', 'Regular', 'CHIEF PROGRAMMER/ANALYST', 150000, 49081.3, 45000, 581.3, 3000, 200, 300, 0, '', 100919),
(8, 8, 'Conley, Nanette', 'Regular', 'CHIEF PROGRAMMER/ANALYST', 50000, 16281.3, 12500, 581.3, 1000, 200, 2000, 0, '', 33718.7),
(9, 9, 'Correa, Maribel', 'Regular', 'PROGRAMMER/ANALYST', 70000, 23481.3, 21000, 581.3, 1400, 200, 300, 0, '', 46518.7),
(10, 10, 'Dean, Reginald', 'Regular', 'PROGRAMMER/ANALYST', 5000, 781.7, 0, 181.7, 100, 200, 0, 300, '', 4218.3);

-- --------------------------------------------------------

--
-- Table structure for table `time_keeping_tb`
--
-- Creation: Dec 03, 2020 at 07:26 AM
-- Last update: Dec 05, 2020 at 01:32 PM
--

CREATE TABLE `time_keeping_tb` (
  `time_keeping_id` int(11) NOT NULL,
  `employee_id` int(11) NOT NULL,
  `login_datetime` varchar(100) NOT NULL,
  `logout_datetime` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELATIONSHIPS FOR TABLE `time_keeping_tb`:
--   `employee_id`
--       `employee_tb` -> `employee_id`
--

--
-- Truncate table before insert `time_keeping_tb`
--

TRUNCATE TABLE `time_keeping_tb`;
--
-- Dumping data for table `time_keeping_tb`
--

INSERT INTO `time_keeping_tb` (`time_keeping_id`, `employee_id`, `login_datetime`, `logout_datetime`) VALUES
(1, 1, 'Dec. 05, 2020 06:27 PM', 'Dec. 05, 2020 06:27 PM'),
(2, 1, 'Dec. 05, 2020 06:28 PM', 'Dec. 05, 2020 06:28 PM'),
(3, 1, 'Dec. 05, 2020 06:28 PM', 'Dec. 05, 2020 06:28 PM'),
(4, 1, 'Dec. 05, 2020 06:28 PM', 'Dec. 05, 2020 06:28 PM'),
(5, 1, 'Dec. 05, 2020 06:29 PM', 'Dec. 05, 2020 06:29 PM'),
(6, 1, 'Dec. 05, 2020 06:29 PM', 'Dec. 05, 2020 06:30 PM'),
(7, 1, 'Dec. 05, 2020 06:30 PM', 'Dec. 05, 2020 06:30 PM'),
(8, 1, 'Dec. 05, 2020 06:30 PM', 'Dec. 05, 2020 06:30 PM'),
(9, 1, 'Dec. 05, 2020 06:30 PM', 'Dec. 05, 2020 06:30 PM'),
(10, 1, 'Dec. 05, 2020 06:31 PM', 'Dec. 05, 2020 06:31 PM'),
(11, 1, 'Dec. 05, 2020 06:32 PM', 'Dec. 05, 2020 06:32 PM'),
(12, 1, 'Dec. 05, 2020 06:32 PM', 'Dec. 05, 2020 06:32 PM'),
(13, 1, 'Dec. 05, 2020 06:33 PM', 'Dec. 05, 2020 06:33 PM'),
(14, 3, 'Dec. 05, 2020 06:34 PM', 'Dec. 05, 2020 06:34 PM'),
(15, 3, 'Dec. 05, 2020 06:34 PM', 'Dec. 05, 2020 06:34 PM'),
(16, 3, 'Dec. 05, 2020 06:34 PM', 'Dec. 05, 2020 06:34 PM'),
(17, 3, 'Dec. 05, 2020 06:35 PM', 'Dec. 05, 2020 06:35 PM'),
(18, 3, 'Dec. 05, 2020 06:35 PM', 'Dec. 05, 2020 06:35 PM'),
(19, 3, 'Dec. 05, 2020 06:35 PM', 'Dec. 05, 2020 06:35 PM'),
(20, 3, 'Dec. 05, 2020 06:35 PM', 'Dec. 05, 2020 06:35 PM'),
(21, 3, 'Dec. 05, 2020 06:35 PM', 'Dec. 05, 2020 06:35 PM'),
(22, 3, 'Dec. 05, 2020 06:35 PM', 'Dec. 05, 2020 06:36 PM'),
(23, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(24, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(25, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(26, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(27, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(28, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(29, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(30, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(31, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(32, 3, 'Dec. 05, 2020 06:36 PM', 'Dec. 05, 2020 06:36 PM'),
(33, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(34, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(35, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(36, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(37, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(38, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(39, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(40, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(41, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(42, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(43, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:37 PM'),
(44, 3, 'Dec. 05, 2020 06:37 PM', 'Dec. 05, 2020 06:38 PM'),
(45, 3, 'Dec. 05, 2020 06:38 PM', 'Dec. 05, 2020 06:38 PM'),
(46, 3, 'Dec. 05, 2020 06:38 PM', 'Dec. 05, 2020 06:38 PM'),
(47, 3, 'Dec. 05, 2020 06:39 PM', 'Dec. 05, 2020 06:39 PM'),
(48, 3, 'Dec. 05, 2020 06:39 PM', 'Dec. 05, 2020 06:39 PM'),
(49, 3, 'Dec. 05, 2020 06:39 PM', 'Dec. 05, 2020 06:39 PM'),
(50, 3, 'Dec. 05, 2020 06:39 PM', 'Dec. 05, 2020 06:39 PM'),
(51, 3, 'Dec. 05, 2020 06:39 PM', 'Dec. 05, 2020 06:40 PM'),
(52, 3, 'Dec. 05, 2020 06:40 PM', 'Dec. 05, 2020 06:40 PM'),
(53, 3, 'Dec. 05, 2020 06:40 PM', 'Dec. 05, 2020 06:40 PM'),
(54, 3, 'Dec. 05, 2020 06:40 PM', 'Dec. 05, 2020 06:40 PM'),
(55, 3, 'Dec. 05, 2020 06:40 PM', 'Dec. 05, 2020 06:40 PM'),
(56, 3, 'Dec. 05, 2020 06:40 PM', 'Dec. 05, 2020 06:40 PM'),
(57, 3, 'Dec. 05, 2020 06:40 PM', 'Dec. 05, 2020 06:40 PM'),
(58, 2, 'Dec. 05, 2020 06:40 PM', 'Dec. 05, 2020 06:41 PM'),
(59, 2, 'Dec. 05, 2020 06:41 PM', 'Dec. 05, 2020 06:41 PM'),
(60, 2, 'Dec. 05, 2020 06:41 PM', 'Dec. 05, 2020 06:41 PM'),
(61, 2, 'Dec. 05, 2020 06:41 PM', 'Dec. 05, 2020 06:41 PM'),
(62, 2, 'Dec. 05, 2020 06:41 PM', 'Dec. 05, 2020 06:41 PM'),
(63, 2, 'Dec. 05, 2020 06:41 PM', 'Dec. 05, 2020 06:41 PM'),
(64, 2, 'Dec. 05, 2020 06:41 PM', NULL),
(65, 4, 'Dec. 05, 2020 06:42 PM', 'Dec. 05, 2020 06:42 PM'),
(66, 4, 'Dec. 05, 2020 06:43 PM', 'Dec. 05, 2020 06:43 PM'),
(67, 4, 'Dec. 05, 2020 06:43 PM', 'Dec. 05, 2020 06:43 PM'),
(68, 4, 'Dec. 05, 2020 06:43 PM', 'Dec. 05, 2020 06:43 PM'),
(69, 5, 'Dec. 05, 2020 06:44 PM', 'Dec. 05, 2020 06:44 PM'),
(70, 5, 'Dec. 05, 2020 06:44 PM', 'Dec. 05, 2020 06:44 PM'),
(71, 5, 'Dec. 05, 2020 06:44 PM', 'Dec. 05, 2020 06:44 PM'),
(72, 6, 'Dec. 05, 2020 06:47 PM', 'Dec. 05, 2020 06:48 PM'),
(73, 6, 'Dec. 05, 2020 06:48 PM', 'Dec. 05, 2020 06:48 PM'),
(74, 6, 'Dec. 05, 2020 06:48 PM', 'Dec. 05, 2020 06:48 PM'),
(75, 6, 'Dec. 05, 2020 06:48 PM', 'Dec. 05, 2020 06:48 PM'),
(76, 6, 'Dec. 05, 2020 06:48 PM', 'Dec. 05, 2020 06:48 PM'),
(77, 6, 'Dec. 05, 2020 06:48 PM', 'Dec. 05, 2020 06:48 PM'),
(78, 6, 'Dec. 05, 2020 06:49 PM', NULL),
(79, 1, 'Dec. 05, 2020 07:13 PM', 'Dec. 05, 2020 07:13 PM'),
(80, 1, 'Dec. 05, 2020 07:14 PM', 'Dec. 05, 2020 07:14 PM'),
(81, 1, 'Dec. 05, 2020 09:32 PM', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `user_tb`
--
-- Creation: Dec 02, 2020 at 05:48 AM
-- Last update: Dec 05, 2020 at 10:47 AM
--

CREATE TABLE `user_tb` (
  `user_id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELATIONSHIPS FOR TABLE `user_tb`:
--

--
-- Truncate table before insert `user_tb`
--

TRUNCATE TABLE `user_tb`;
--
-- Dumping data for table `user_tb`
--

INSERT INTO `user_tb` (`user_id`, `username`, `password`, `type`) VALUES
(1, 'admin', '21232f297a57a5a743894a0e4a801fc3', 'ADMIN'),
(2, 'juan', 'a94652aa97c7211ba8954dd15a3cf838', 'EMPLOYEE'),
(3, 'deborah', '202cb962ac59075b964b07152d234b70', 'EMPLOYEE'),
(4, 'hassan', '202cb962ac59075b964b07152d234b70', 'EMPLOYEE'),
(5, 'Khalid_Ahmed', 'e5ed04ccc615e0c9081f36c7c71ace95', 'EMPLOYEE'),
(6, 'Armstrong_Sonya', '313c14e2d9fad76eb5fc45a36737f619', 'EMPLOYEE'),
(7, 'Burger', '97bc13aec0017c56be5ba683097bd11d', 'EMPLOYEE'),
(8, 'Chen_Dibo', 'a5fba1e054301e2681806d383cd993e5', 'EMPLOYEE'),
(9, 'Conley_Nanette', '8617d46bd82509a39d7d950fba4c2804', 'EMPLOYEE'),
(10, 'Correa_Maribel', '58a4a7ee5560e087a4660bdbc2ecfc1b', 'EMPLOYEE'),
(11, 'Dean_Reginald', 'fbf7f274e4b093ecc866c17005fa08af', 'EMPLOYEE');

-- --------------------------------------------------------

--
-- Table structure for table `work_tb`
--
-- Creation: Dec 04, 2020 at 05:04 AM
-- Last update: Dec 05, 2020 at 11:14 AM
--

CREATE TABLE `work_tb` (
  `work_id` int(11) NOT NULL,
  `emp_id` int(11) NOT NULL,
  `gross_salary` float NOT NULL DEFAULT 0,
  `net_salary` float NOT NULL DEFAULT 0,
  `allowable_absences` int(11) NOT NULL DEFAULT 0,
  `day` int(11) NOT NULL DEFAULT 0,
  `cutof_period` varchar(100) NOT NULL,
  `payslip` float NOT NULL,
  `tax` float NOT NULL DEFAULT 0,
  `sss` float NOT NULL DEFAULT 0,
  `pagibig` float NOT NULL DEFAULT 0,
  `philhealth` float NOT NULL DEFAULT 0,
  `loans` float NOT NULL DEFAULT 0,
  `deductions` float NOT NULL DEFAULT 0,
  `deduction_remarks` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- RELATIONSHIPS FOR TABLE `work_tb`:
--   `emp_id`
--       `employee_tb` -> `employee_id`
--

--
-- Truncate table before insert `work_tb`
--

TRUNCATE TABLE `work_tb`;
--
-- Dumping data for table `work_tb`
--

INSERT INTO `work_tb` (`work_id`, `emp_id`, `gross_salary`, `net_salary`, `allowable_absences`, `day`, `cutof_period`, `payslip`, `tax`, `sss`, `pagibig`, `philhealth`, `loans`, `deductions`, `deduction_remarks`) VALUES
(1, 1, 30000, 22218.7, 30, 15, '15th', 11109.3, 6000, 581.3, 600, 200, 300, 100, 'Late - 100'),
(2, 2, 15000, 8955, 14, 6, '30th', 8955, 0, 545, 300, 200, 0, 5000, 'Cash Advance - 5000'),
(3, 3, 50000, 34918.7, 14, 11, '30th', 34918.7, 12500, 581.3, 1000, 200, 500, 300, '2x Absent -150'),
(4, 4, 1000000, 477219, 60, 4, '30th', 477219, 350000, 581.3, 20000, 200, 2000, 150000, 'Cash Advance - 150,000'),
(5, 5, 20000, 18818.7, 7, 3, '15th', 9409.35, 0, 581.3, 400, 200, 0, 0, ''),
(6, 6, 300000, 192219, 20, 6, '15th', 96109.4, 96000, 581.3, 6000, 200, 0, 5000, '5x Undertime - 1000'),
(7, 7, 150000, 100919, 30, 0, '15th', 50459.4, 45000, 581.3, 3000, 200, 300, 0, ''),
(8, 8, 50000, 33718.7, 14, 0, '15th', 16859.3, 12500, 581.3, 1000, 200, 2000, 0, ''),
(9, 9, 70000, 46518.7, 5, 0, '15th', 23259.3, 21000, 581.3, 1400, 200, 300, 0, ''),
(10, 10, 5000, 4218.3, 8, 0, '15th', 2109.15, 0, 181.7, 100, 200, 0, 300, '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee_tb`
--
ALTER TABLE `employee_tb`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `report_tb`
--
ALTER TABLE `report_tb`
  ADD PRIMARY KEY (`report_id`),
  ADD UNIQUE KEY `employee_id` (`employee_id`);

--
-- Indexes for table `time_keeping_tb`
--
ALTER TABLE `time_keeping_tb`
  ADD PRIMARY KEY (`time_keeping_id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- Indexes for table `user_tb`
--
ALTER TABLE `user_tb`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `work_tb`
--
ALTER TABLE `work_tb`
  ADD PRIMARY KEY (`work_id`),
  ADD KEY `emp_id` (`emp_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee_tb`
--
ALTER TABLE `employee_tb`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `report_tb`
--
ALTER TABLE `report_tb`
  MODIFY `report_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `time_keeping_tb`
--
ALTER TABLE `time_keeping_tb`
  MODIFY `time_keeping_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=82;

--
-- AUTO_INCREMENT for table `user_tb`
--
ALTER TABLE `user_tb`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `work_tb`
--
ALTER TABLE `work_tb`
  MODIFY `work_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `time_keeping_tb`
--
ALTER TABLE `time_keeping_tb`
  ADD CONSTRAINT `time_keeping_tb_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employee_tb` (`employee_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `work_tb`
--
ALTER TABLE `work_tb`
  ADD CONSTRAINT `work_tb_ibfk_1` FOREIGN KEY (`emp_id`) REFERENCES `employee_tb` (`employee_id`) ON DELETE CASCADE ON UPDATE CASCADE;
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
