USE [master]
GO
/****** Object:  Database [College Management System]    Script Date: 29-11-2022 13:55:40 ******/
CREATE DATABASE [College Management System]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'College Management System', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\College Management System.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'College Management System_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\College Management System_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [College Management System] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [College Management System].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [College Management System] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [College Management System] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [College Management System] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [College Management System] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [College Management System] SET ARITHABORT OFF 
GO
ALTER DATABASE [College Management System] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [College Management System] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [College Management System] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [College Management System] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [College Management System] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [College Management System] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [College Management System] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [College Management System] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [College Management System] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [College Management System] SET  DISABLE_BROKER 
GO
ALTER DATABASE [College Management System] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [College Management System] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [College Management System] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [College Management System] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [College Management System] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [College Management System] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [College Management System] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [College Management System] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [College Management System] SET  MULTI_USER 
GO
ALTER DATABASE [College Management System] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [College Management System] SET DB_CHAINING OFF 
GO
ALTER DATABASE [College Management System] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [College Management System] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [College Management System] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [College Management System] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [College Management System] SET QUERY_STORE = OFF
GO
USE [College Management System]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 29-11-2022 13:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepName] [varchar](50) NOT NULL,
	[DepDetails] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 29-11-2022 13:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 29-11-2022 13:55:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Name] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Phoneno] [varchar](50) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[Pname] [varchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Department] ([DepName], [DepDetails]) VALUES (N'Computer Science', N'Bachelor of Technology')
INSERT [dbo].[Department] ([DepName], [DepDetails]) VALUES (N'Electrical and Communication', N'Bachelor of Technology in Electronics')
INSERT [dbo].[Department] ([DepName], [DepDetails]) VALUES (N'Mechanical', N'Bachelor of Technology in Machanics')
INSERT [dbo].[Department] ([DepName], [DepDetails]) VALUES (N'Information Technology', N'Bachelor of Technology in IT felid')
GO
INSERT [dbo].[Login] ([username], [password]) VALUES (N'kumar', N'1234')
INSERT [dbo].[Login] ([username], [password]) VALUES (N'Renukar', N'2222')
INSERT [dbo].[Login] ([username], [password]) VALUES (N'ramu', N'3333')
INSERT [dbo].[Login] ([username], [password]) VALUES (N'rajesh', N'4444')
INSERT [dbo].[Login] ([username], [password]) VALUES (N'ravi', N'5555')
INSERT [dbo].[Login] ([username], [password]) VALUES (N' sandeep', N'1234')
INSERT [dbo].[Login] ([username], [password]) VALUES (N'kushi', N'8888')
INSERT [dbo].[Login] ([username], [password]) VALUES (N'SANDEEP1', N'123')
GO
INSERT [dbo].[Student] ([Name], [Gender], [Phoneno], [Address], [Pname]) VALUES (N'Kumar', N'Male', N'8330959352', N'Andra', N'Sankar')
INSERT [dbo].[Student] ([Name], [Gender], [Phoneno], [Address], [Pname]) VALUES (N'vidhya', N'Female', N'7925965901', N'Chennai', N'Ravi')
INSERT [dbo].[Student] ([Name], [Gender], [Phoneno], [Address], [Pname]) VALUES (N'GunaSekhar', N'Male', N'8686150497', N'Pondicherry', N'sankar')
INSERT [dbo].[Student] ([Name], [Gender], [Phoneno], [Address], [Pname]) VALUES (N'Mourya', N'Male', N'9823517645', N'pradesh', N'venkat')
GO
USE [master]
GO
ALTER DATABASE [College Management System] SET  READ_WRITE 
GO
