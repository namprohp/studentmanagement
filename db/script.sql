USE [master]
GO
/****** Object:  Database [Project_PRN212]    Script Date: 11/8/2024 10:45:28 PM ******/
CREATE DATABASE [Project_PRN212]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_PRN212', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Project_PRN212.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_PRN212_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Project_PRN212_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Project_PRN212] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_PRN212].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_PRN212] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_PRN212] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_PRN212] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_PRN212] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_PRN212] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_PRN212] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project_PRN212] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_PRN212] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_PRN212] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_PRN212] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_PRN212] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_PRN212] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_PRN212] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_PRN212] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_PRN212] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Project_PRN212] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_PRN212] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_PRN212] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_PRN212] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_PRN212] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_PRN212] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_PRN212] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_PRN212] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Project_PRN212] SET  MULTI_USER 
GO
ALTER DATABASE [Project_PRN212] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_PRN212] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_PRN212] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_PRN212] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project_PRN212] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project_PRN212] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Project_PRN212] SET QUERY_STORE = OFF
GO
USE [Project_PRN212]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role] [int] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nchar](10) NULL,
	[CourseId] [nchar](10) NOT NULL,
	[TeacherId] [nvarchar](10) NOT NULL,
	[RoomId] [int] NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [nchar](10) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmenId] [nchar](10) NOT NULL,
	[DepartmentName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [nchar](10) NULL,
	[RoomName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ScheduleId] [int] IDENTITY(1,1) NOT NULL,
	[ClassId] [int] NOT NULL,
	[Slot] [int] NOT NULL,
	[DayOfWeek] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[id] [nchar](10) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[Gender] [bit] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[AccountID] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Class]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Class](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [nchar](10) NULL,
	[ClassId] [int] NULL,
	[CourseId] [nchar](10) NULL,
 CONSTRAINT [PK_Student_Class] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 11/8/2024 10:45:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[id] [nvarchar](10) NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[Gender] [bit] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[AccountID] [nvarchar](50) NOT NULL,
	[BrithDate] [date] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'a', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'act', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'admin', N'123', 1)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'akt', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'aktte', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'aktttttt', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'anhttl', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'ant', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'antt', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'avm', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'BinhDT', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'blln', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'bllnt', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'cuonghv', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'cuonghvc', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'ducdm', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'GiangDT', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'haiduuy', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'haiduy', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'haiduyle', N'12', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'haild', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'halth', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'huynm', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'jje', N'password123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'jjoe', N'password123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'ktta', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'kttaa', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'kttaaa', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'lkn', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'lknt', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'lkntt', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'ltntkly', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'lyktn', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'lyntkl', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'sonnt', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'sonnt233', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'thuybt5', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'thuybt57', N'123', 3)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'trungnt', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'trungnt2', N'123', 2)
INSERT [dbo].[Account] ([UserName], [Password], [Role]) VALUES (N'trungnt22', N'123', 2)
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (1, N'SE1809    ', N'SWP391    ', N'TC002', 11)
INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (2, N'SE1813    ', N'ITE302c   ', N'TC005', 11)
INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (4, N'SE1809    ', N'SWR302    ', N'TC002', 1)
INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (5, N'SE1813    ', N'SWP391    ', N'TC001', 5)
INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (6, N'SE1811    ', N'SWP391    ', N'TC002', 2)
INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (8, N'SE1813    ', N'ITE302c   ', N'TC001', 1)
INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (11, N'SE1809    ', N'SWP391    ', N'TC002', 12)
INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (12, N'SE1809    ', N'ITE302c   ', N'TC001', 1)
INSERT [dbo].[Class] ([ClassId], [ClassName], [CourseId], [TeacherId], [RoomId]) VALUES (16, N'SE1809    ', N'SWP391    ', N'TC002', 5)
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
INSERT [dbo].[Course] ([CourseId], [CourseName]) VALUES (N'ITE302c   ', N'Ethics in IT')
INSERT [dbo].[Course] ([CourseId], [CourseName]) VALUES (N'PRN212    ', N'Basis Cross-Platform Application Programming With')
INSERT [dbo].[Course] ([CourseId], [CourseName]) VALUES (N'PRO192    ', N'Java')
INSERT [dbo].[Course] ([CourseId], [CourseName]) VALUES (N'SWP391    ', N'Application development project')
INSERT [dbo].[Course] ([CourseId], [CourseName]) VALUES (N'SWR302    ', N'Software Requirement')
INSERT [dbo].[Course] ([CourseId], [CourseName]) VALUES (N'SWT301    ', N'Software Testing')
GO
INSERT [dbo].[Department] ([DepartmenId], [DepartmentName]) VALUES (N'AL        ', N'Alpha')
INSERT [dbo].[Department] ([DepartmenId], [DepartmentName]) VALUES (N'BE        ', N'Beta')
INSERT [dbo].[Department] ([DepartmenId], [DepartmentName]) VALUES (N'DE        ', N'Delta')
INSERT [dbo].[Department] ([DepartmenId], [DepartmentName]) VALUES (N'EP        ', N'Epsilon')
INSERT [dbo].[Department] ([DepartmenId], [DepartmentName]) VALUES (N'GA        ', N'Gammar')
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (1, N'BE        ', N'BE-101')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (2, N'BE        ', N'BE-102')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (3, N'BE        ', N'BE-103')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (4, N'AL        ', N'BE-104')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (5, N'BE        ', N'BE-106')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (6, N'AL        ', N'AL-101')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (8, N'AL        ', N'AL-103')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (10, N'AL        ', N'AL-105')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (11, N'DE        ', N'DE-101')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (12, N'DE        ', N'DE-102')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (13, N'DE        ', N'DE-103')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (14, N'DE        ', N'DE-104')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (15, N'DE        ', N'DE-105')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (16, N'GA        ', N'GA-101')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (18, N'GA        ', N'GA-103')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (19, N'GA        ', N'GA-104')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (20, N'GA        ', N'GA-105')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (21, N'EP        ', N'EP-101')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (22, N'EP        ', N'EP-102')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (23, N'EP        ', N'EP-103')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (24, N'EP        ', N'EP-104')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (25, N'EP        ', N'EP-105')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (26, N'AL        ', N'AL-106')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (27, N'AL        ', N'AL-106')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (28, N'EP        ', N'EP-106')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (29, N'GA        ', N'GA-106')
INSERT [dbo].[Room] ([RoomId], [DepartmentId], [RoomName]) VALUES (30, N'AL        ', N'AL-104')
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedule] ON 

INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (1, 1, 1, 0, 0)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (2, 16, 2, 1, 0)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (3, 8, 3, 3, 0)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (4, 16, 2, 4, 0)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (5, 16, 2, 6, 0)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (6, 8, 3, 5, 0)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (7, 8, 1, 5, 0)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (8, 8, 1, 4, 0)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (9, 16, 2, 6, 1)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (10, 6, 1, 6, 1)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (11, 8, 5, 5, 1)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (12, 1, 1, 0, 1)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (13, 4, 1, 1, 1)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (14, 11, 1, 2, 1)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (15, 12, 1, 3, 1)
INSERT [dbo].[Schedule] ([ScheduleId], [ClassId], [Slot], [DayOfWeek], [IsActive]) VALUES (16, 16, 4, 3, 1)
SET IDENTITY_INSERT [dbo].[Schedule] OFF
GO
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17001   ', N'Lê Duy Hải', 1, N'hailhe17001@fpt.edu.vn', N'haild', CAST(N'2003-09-07' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE170011  ', N'Lê Duy Hải', 0, N'hailhe17001@fpt.edu.vn', N'haiduy', CAST(N'2003-09-07' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE170018  ', N'Nguyen Van A', 0, N'a@fpt.edu.vn', N'aktttttt', CAST(N'2013-01-23' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17002   ', N'Nguyễn Mạnh Huy', 1, N'hailhe17002@gmail.com', N'huynm', CAST(N'2003-10-02' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17003   ', N'Kiều Thanh Thế Anh', 0, N'kttae17003@fpt.edu.vn', N'ktta', CAST(N'2003-09-09' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17004   ', N'Nguyễn Thành Trung', 0, N'trungnt@fpt.edu.vn', N'trungnt', CAST(N'2003-01-15' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17006   ', N'Nguyen Van A', 0, N'a@fpt.edu.vn', N'akt', CAST(N'2013-01-23' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17007   ', N'Nguyen Van B', 0, N'b@fpt.edu.vn', N'blln', CAST(N'2013-01-23' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17008   ', N'Nguyen Khanh Ly', 0, N'b@fpt.edu.vn', N'lkn', CAST(N'2013-01-23' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17009   ', N'Nguyen Van A', 0, N'a@fpt.edu.vn', N'aktte', CAST(N'2013-01-23' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE172232  ', N'Do Truong Giang', 1, N'Giang@gmail.com', N'GiangDT', CAST(N'2013-01-08' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE17223232', N'Dang Tieu Binh', 1, N'Binh@gmail.com', N'BinhDT', CAST(N'2013-01-14' AS Date))
INSERT [dbo].[Student] ([id], [StudentName], [Gender], [Email], [AccountID], [BirthDate]) VALUES (N'HE173322  ', N'Nguyen Van A', 1, N'a.doe@example.com', N'act', CAST(N'2000-01-01' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Student_Class] ON 

INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (2, N'HE17001   ', 1, N'SWR302    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (3, N'HE17002   ', 2, N'ITE302c   ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (4, N'HE17003   ', 4, N'SWR302    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (5, N'HE17004   ', 1, N'SWR302    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (8, N'HE17002   ', 5, N'PRN212    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (9, N'HE170011  ', 5, N'ITE302c   ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (10, N'HE17001   ', 8, N'ITE302c   ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (11, N'HE17002   ', 8, N'ITE302c   ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (12, N'HE17003   ', 8, N'ITE302c   ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (14, N'HE17007   ', 5, N'PRN212    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (15, N'HE17008   ', 5, N'PRN212    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (16, N'HE17001   ', 1, N'ITE302c   ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (17, N'HE17001   ', 2, N'ITE302c   ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (18, N'HE17001   ', 4, N'SWR302    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (19, N'HE17001   ', 5, N'SWR302    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (20, N'HE17001   ', 6, N'PRN212    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (21, N'HE170018  ', 2, N'ITE302c   ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (24, N'HE170011  ', 12, N'SWR302    ')
INSERT [dbo].[Student_Class] ([id], [StudentId], [ClassId], [CourseId]) VALUES (27, N'HE170018  ', 12, N'PRN212    ')
SET IDENTITY_INSERT [dbo].[Student_Class] OFF
GO
INSERT [dbo].[Teacher] ([id], [TeacherName], [Gender], [Email], [AccountID], [BrithDate]) VALUES (N'TC001', N'Ngô Tùng Sơn', 0, N'sonnt001@fpt.edu.vn', N'sonnt', CAST(N'1989-01-03' AS Date))
INSERT [dbo].[Teacher] ([id], [TeacherName], [Gender], [Email], [AccountID], [BrithDate]) VALUES (N'TC002', N'Doãn Mạnh Đức', 0, N'ducdm003@fpt.edu.vn', N'ducdm', CAST(N'1991-01-04' AS Date))
INSERT [dbo].[Teacher] ([id], [TeacherName], [Gender], [Email], [AccountID], [BrithDate]) VALUES (N'TC004', N'Trịnh Thị Lan Anh', 0, N'anhttl@fpt.edu.vn', N'anhttl', CAST(N'1990-01-02' AS Date))
INSERT [dbo].[Teacher] ([id], [TeacherName], [Gender], [Email], [AccountID], [BrithDate]) VALUES (N'TC005', N'Bui Thi Thuy', 1, N'ThuyBT005@fpt.edu.vn', N'thuybt5', CAST(N'1991-01-04' AS Date))
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Student__349DA58705964A94]    Script Date: 11/8/2024 10:45:28 PM ******/
ALTER TABLE [dbo].[Student] ADD UNIQUE NONCLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Teacher__349DA587B171776E]    Script Date: 11/8/2024 10:45:28 PM ******/
ALTER TABLE [dbo].[Teacher] ADD UNIQUE NONCLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Schedule] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Course]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Room] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Room]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Teacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([id])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Teacher]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmenId])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Department]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Class] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Class]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Account] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([UserName])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Account]
GO
ALTER TABLE [dbo].[Student_Class]  WITH CHECK ADD  CONSTRAINT [FK_Student_Class_Class] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[Student_Class] CHECK CONSTRAINT [FK_Student_Class_Class]
GO
ALTER TABLE [dbo].[Student_Class]  WITH CHECK ADD  CONSTRAINT [FK_Student_Class_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[Student_Class] CHECK CONSTRAINT [FK_Student_Class_Course]
GO
ALTER TABLE [dbo].[Student_Class]  WITH CHECK ADD  CONSTRAINT [FK_Student_Class_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([id])
GO
ALTER TABLE [dbo].[Student_Class] CHECK CONSTRAINT [FK_Student_Class_Student]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Account] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([UserName])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Account]
GO
USE [master]
GO
ALTER DATABASE [Project_PRN212] SET  READ_WRITE 
GO
