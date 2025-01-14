USE [master]
GO
/****** Object:  Database [Hospital_Panel]    Script Date: 7.01.2025 05:25:51 ******/
CREATE DATABASE [Hospital_Panel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital_Panel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Hospital_Panel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hospital_Panel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Hospital_Panel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Hospital_Panel] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital_Panel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital_Panel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital_Panel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital_Panel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital_Panel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital_Panel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital_Panel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hospital_Panel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital_Panel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital_Panel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital_Panel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital_Panel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital_Panel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital_Panel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital_Panel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital_Panel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospital_Panel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital_Panel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital_Panel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital_Panel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital_Panel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital_Panel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital_Panel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital_Panel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hospital_Panel] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital_Panel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital_Panel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital_Panel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital_Panel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hospital_Panel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hospital_Panel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Hospital_Panel] SET QUERY_STORE = ON
GO
ALTER DATABASE [Hospital_Panel] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Hospital_Panel]
GO
/****** Object:  Table [dbo].[Tbl_Announcements]    Script Date: 7.01.2025 05:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Announcements](
	[AnnouncementID] [smallint] IDENTITY(1,1) NOT NULL,
	[Announcement] [varchar](200) NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[AnnouncementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Appointments]    Script Date: 7.01.2025 05:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Appointments](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentDate] [varchar](10) NULL,
	[AppointmentTime] [varchar](5) NULL,
	[AppointmentDepartment] [varchar](30) NULL,
	[AppointmentDoctor] [varchar](20) NULL,
	[AppointmentStatus] [bit] NULL,
	[PatientCitizenID] [char](11) NULL,
	[PatientComplaint] [varchar](250) NULL,
 CONSTRAINT [PK_Tbl_Appointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Departments]    Script Date: 7.01.2025 05:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Departments](
	[DepartmentID] [tinyint] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](30) NULL,
 CONSTRAINT [PK_Tbl_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Doctors]    Script Date: 7.01.2025 05:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Doctors](
	[DoctorID] [tinyint] IDENTITY(1,1) NOT NULL,
	[DoctorName] [varchar](10) NULL,
	[DoctorSurname] [varchar](10) NULL,
	[DoctorDepartment] [varchar](30) NULL,
	[DoctorCitizenID] [char](11) NULL,
	[DoctorPass] [varchar](15) NULL,
 CONSTRAINT [PK_Tbl_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Patients]    Script Date: 7.01.2025 05:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Patients](
	[PatientID] [smallint] IDENTITY(1,1) NOT NULL,
	[PatientName] [varchar](10) NULL,
	[PatientSurname] [varchar](10) NULL,
	[PatientCitizenID] [char](11) NULL,
	[PatientPhone] [varchar](15) NULL,
	[PatientPass] [varchar](15) NULL,
	[PatientGender] [varchar](6) NULL,
 CONSTRAINT [PK_Tbl_Patients] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Secretary]    Script Date: 7.01.2025 05:25:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Secretary](
	[SecretaryID] [tinyint] IDENTITY(1,1) NOT NULL,
	[SecretaryNameSurname] [varchar](20) NULL,
	[SecretaryCitizenID] [char](11) NULL,
	[SecretaryPass] [varchar](15) NULL,
 CONSTRAINT [PK_Tbl_Secretary] PRIMARY KEY CLUSTERED 
(
	[SecretaryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Announcements] ON 

INSERT [dbo].[Tbl_Announcements] ([AnnouncementID], [Announcement]) VALUES (1, N'Warning! Intruder in the emergency. 22.00-06/01/2025')
INSERT [dbo].[Tbl_Announcements] ([AnnouncementID], [Announcement]) VALUES (2, N'Need Cardiology Doctor In Block-B')
SET IDENTITY_INSERT [dbo].[Tbl_Announcements] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Appointments] ON 

INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (1, N'28.06.2005', N'09:30', N'Cardiology', N'Jack Franklin', 1, N'10162040010', N'Heart Pain')
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (2, N'10.01.2025', N'11:00', N'Ear Nose Throat Diseases', N'Ali Demir', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (3, N'10.01.2025', N'09:30', N'Urology', N'Yusuf Demir', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (4, N'10.01.2025', N'10:30', N'Urology', N'Yusuf Demir', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (5, N'10.01.2025', N'11:30', N'Urology', N'Yusuf Demir', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (6, N'10.01.2025', N'11:30', N'Cardiology', N'Jack Franklin', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (7, N'10.01.2025', N'10:30', N'Cardiology', N'Jack Franklin', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (8, N'10.01.2025', N'12:30', N'Ear Nose Throat Diseases', N'Ahmet Kral', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (9, N'15.01.2025', N'09:30', N'Neurology', N'Elif Kitap', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (10, N'15.01.2025', N'09:40', N'Neurology', N'Elif Kitap', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (11, N'15.01.2025', N'09:50', N'Neurology', N'Elif Kitap', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (12, N'15.01.2025', N'10:00', N'Neurology', N'Elif Kitap', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (13, N'17.01.2025', N'10:00', N'Neurology', N'Berkay Kaplan', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (14, N'17.01.2025', N'11:00', N'Neurology', N'Berkay Kaplan', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (15, N'19.01.2025', N'13:00', N'Neurology', N'Ziya Mehmet', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (16, N'19.01.2025', N'14:00', N'Neurology', N'Ziya Mehmet', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (17, N'21.01.2025', N'14:00', N'Gastroenterology', N'Sakıp Ateş', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (18, N'21.01.2025', N'15:00', N'Gastroenterology', N'Sakıp Ateş', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (19, N'21.01.2025', N'16:00', N'Gastroenterology', N'Sakıp Ateş', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (20, N'20.01.2025', N'10:00', N'Eye Diseases', N'Yalın Toprak', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (21, N'20.01.2025', N'10:20', N'Eye Diseases', N'Yalın Toprak', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (22, N'20.01.2025', N'10:40', N'Eye Diseases', N'Yalın Toprak', 1, N'10162040010', N'Can''t see properly')
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (23, N'20.01.2025', N'11:00', N'Eye Diseases', N'Yalın Toprak', 0, NULL, NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (24, N'21.01.2025', N'13:00', N'Gastroenterology', N'Sakıp Ateş', 1, N'20510020350', NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (25, N'21.01.2025', N'10:00', N'Gastroenterology', N'Sakıp Ateş', 1, N'12050045305', NULL)
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (26, N'15.01.2025', N'10:10', N'Neurology', N'Elif Kitap', 1, N'21950520301', N'Heavy headache')
INSERT [dbo].[Tbl_Appointments] ([AppointmentID], [AppointmentDate], [AppointmentTime], [AppointmentDepartment], [AppointmentDoctor], [AppointmentStatus], [PatientCitizenID], [PatientComplaint]) VALUES (27, N'10.01.2025', N'12:30', N'Urology', N'Yusuf Demir', 1, N'20534035019', NULL)
SET IDENTITY_INSERT [dbo].[Tbl_Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Departments] ON 

INSERT [dbo].[Tbl_Departments] ([DepartmentID], [DepartmentName]) VALUES (1, N'Cardiology')
INSERT [dbo].[Tbl_Departments] ([DepartmentID], [DepartmentName]) VALUES (2, N'Ear Nose Throat Diseases')
INSERT [dbo].[Tbl_Departments] ([DepartmentID], [DepartmentName]) VALUES (3, N'Eye Diseases')
INSERT [dbo].[Tbl_Departments] ([DepartmentID], [DepartmentName]) VALUES (4, N'Gastroenterology')
INSERT [dbo].[Tbl_Departments] ([DepartmentID], [DepartmentName]) VALUES (5, N'Neurology')
INSERT [dbo].[Tbl_Departments] ([DepartmentID], [DepartmentName]) VALUES (6, N'Urology')
SET IDENTITY_INSERT [dbo].[Tbl_Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Doctors] ON 

INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (1, N'Jack', N'Franklin', N'Cardiology', N'11111111111', N'1111')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (2, N'Mehmet ', N'Akdemir', N'Cardiology', N'33333333333', N'1111')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (3, N'Ahmet', N'Kral', N'Ear Nose Throat Diseases', N'22222222222', N'3333')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (4, N'Ali', N'Demir', N'Ear Nose Throat Diseases', N'32323232321', N'4444')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (5, N'Ayşe', N'Kara', N'Ear Nose Throat Diseases', N'44444444441', N'5555')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (6, N'Elif', N'Kitap', N'Neurology', N'55555555555', N'5500')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (7, N'Berkay', N'Kaplan', N'Neurology', N'66666666666', N'0988')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (8, N'Ziya', N'Mehmet', N'Neurology', N'99999999999', N'9900')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (9, N'Yusuf', N'Demir', N'Urology', N'77733322212', N'1099')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (10, N'Yalın', N'Toprak', N'Eye Diseases', N'44444444444', N'4444')
INSERT [dbo].[Tbl_Doctors] ([DoctorID], [DoctorName], [DoctorSurname], [DoctorDepartment], [DoctorCitizenID], [DoctorPass]) VALUES (11, N'Sakıp', N'Ateş', N'Gastroenterology', N'66666666666', N'6767')
SET IDENTITY_INSERT [dbo].[Tbl_Doctors] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Patients] ON 

INSERT [dbo].[Tbl_Patients] ([PatientID], [PatientName], [PatientSurname], [PatientCitizenID], [PatientPhone], [PatientPass], [PatientGender]) VALUES (1, N'Ulaş', N'Aylar', N'10162040010', N'(535) 230-1010', N'12345', N'Male')
INSERT [dbo].[Tbl_Patients] ([PatientID], [PatientName], [PatientSurname], [PatientCitizenID], [PatientPhone], [PatientPass], [PatientGender]) VALUES (2, N'Kerem', N'Ayhan', N'21950520301', N'(542) 300-3520', N'1111', N'Male')
INSERT [dbo].[Tbl_Patients] ([PatientID], [PatientName], [PatientSurname], [PatientCitizenID], [PatientPhone], [PatientPass], [PatientGender]) VALUES (3, N'Gülce', N'Aylar', N'11034050120', N'(535) 200-5015', N'12345', N'Female')
INSERT [dbo].[Tbl_Patients] ([PatientID], [PatientName], [PatientSurname], [PatientCitizenID], [PatientPhone], [PatientPass], [PatientGender]) VALUES (4, N'Ceren', N'Toprak', N'12050045305', N'(530) 200-1560', N'123456', N'Female')
INSERT [dbo].[Tbl_Patients] ([PatientID], [PatientName], [PatientSurname], [PatientCitizenID], [PatientPhone], [PatientPass], [PatientGender]) VALUES (5, N'Adnan', N'Hızlı', N'20510020350', N'(530) 450-2530', N'102030', N'Male')
INSERT [dbo].[Tbl_Patients] ([PatientID], [PatientName], [PatientSurname], [PatientCitizenID], [PatientPhone], [PatientPass], [PatientGender]) VALUES (6, N'Filiz', N'Aylar', N'20534035019', N'(536) 560-3745', N'4035', N'Female')
INSERT [dbo].[Tbl_Patients] ([PatientID], [PatientName], [PatientSurname], [PatientCitizenID], [PatientPhone], [PatientPass], [PatientGender]) VALUES (7, N'Ahmet', N'Öztürk', N'1203003550 ', N'(540) 355-1520', N'456010', N'Male')
INSERT [dbo].[Tbl_Patients] ([PatientID], [PatientName], [PatientSurname], [PatientCitizenID], [PatientPhone], [PatientPass], [PatientGender]) VALUES (8, N'Fırat', N'Hızlı', N'55566677788', N'(540) 333-2211', N'5566', N'Male')
SET IDENTITY_INSERT [dbo].[Tbl_Patients] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Secretary] ON 

INSERT [dbo].[Tbl_Secretary] ([SecretaryID], [SecretaryNameSurname], [SecretaryCitizenID], [SecretaryPass]) VALUES (1, N'Ali Güneş', N'55555555555', N'5555')
INSERT [dbo].[Tbl_Secretary] ([SecretaryID], [SecretaryNameSurname], [SecretaryCitizenID], [SecretaryPass]) VALUES (2, N'Orhan Tatlı', N'77777888889', N'8888')
SET IDENTITY_INSERT [dbo].[Tbl_Secretary] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tbl_Departments]    Script Date: 7.01.2025 05:25:51 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Tbl_Departments] ON [dbo].[Tbl_Departments]
(
	[DepartmentName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Appointments] ADD  CONSTRAINT [DF_Tbl_Appointments_AppointmentStatus]  DEFAULT ((0)) FOR [AppointmentStatus]
GO
USE [master]
GO
ALTER DATABASE [Hospital_Panel] SET  READ_WRITE 
GO
