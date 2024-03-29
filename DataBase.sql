USE [master]
GO
/****** Object:  Database [HospitalProject]    Script Date: 21.02.2024 16:00:55 ******/
CREATE DATABASE [HospitalProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HospitalProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HospitalProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HospitalProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\HospitalProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HospitalProject] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HospitalProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HospitalProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HospitalProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HospitalProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HospitalProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HospitalProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [HospitalProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HospitalProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HospitalProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HospitalProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HospitalProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HospitalProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HospitalProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HospitalProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HospitalProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HospitalProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HospitalProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HospitalProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HospitalProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HospitalProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HospitalProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HospitalProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HospitalProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HospitalProject] SET  MULTI_USER 
GO
ALTER DATABASE [HospitalProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HospitalProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HospitalProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HospitalProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HospitalProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HospitalProject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HospitalProject] SET QUERY_STORE = ON
GO
ALTER DATABASE [HospitalProject] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HospitalProject]
GO
/****** Object:  Table [dbo].[Tbl_Anouncement]    Script Date: 21.02.2024 16:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Anouncement](
	[Anouncementid] [smallint] IDENTITY(1,1) NOT NULL,
	[Anouncement] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Appointments]    Script Date: 21.02.2024 16:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Appointments](
	[Appointmentid] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentDate] [varchar](10) NULL,
	[AppointmentTime] [varchar](5) NULL,
	[AppointmentExpertise] [varchar](30) NULL,
	[AppointmentDoctor] [varchar](20) NULL,
	[AppointmentStatus] [bit] NULL,
	[PatientTC] [char](11) NULL,
	[PatientComplaint] [varchar](250) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Doctors]    Script Date: 21.02.2024 16:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Doctors](
	[Doctorid] [tinyint] IDENTITY(1,1) NOT NULL,
	[DoctorName] [varchar](10) NULL,
	[DoctorSurname] [varchar](10) NULL,
	[DoctorExpertise] [varchar](30) NULL,
	[DoctorTC] [char](11) NULL,
	[DoctorPassword] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Expertise]    Script Date: 21.02.2024 16:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Expertise](
	[Expertiseid] [tinyint] IDENTITY(1,1) NOT NULL,
	[ExpertiseName] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Patients]    Script Date: 21.02.2024 16:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Patients](
	[Patientid] [smallint] IDENTITY(1,1) NOT NULL,
	[PatientName] [varchar](10) NULL,
	[PatientSurname] [varchar](10) NULL,
	[PatientTC] [char](11) NULL,
	[PatientGSM] [varchar](15) NULL,
	[PatientPassword] [varchar](10) NULL,
	[PatientGender] [varchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Secretary]    Script Date: 21.02.2024 16:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Secretary](
	[Secretaryid] [tinyint] IDENTITY(1,1) NOT NULL,
	[SecretaryNameSurname] [varchar](20) NULL,
	[SecretaryTC] [char](11) NULL,
	[SecretaryPassword] [varchar](10) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Appointments] ADD  CONSTRAINT [DF_Tbl_Appointments_AppointmentStatus]  DEFAULT ((0)) FOR [AppointmentStatus]
GO
USE [master]
GO
ALTER DATABASE [HospitalProject] SET  READ_WRITE 
GO
