USE [master]
GO
/****** Object:  Database [Kontactkeeper]    Script Date: 02 Dec 2020 21:15:42 ******/
CREATE DATABASE [Kontactkeeper]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kontactkeeper', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Kontactkeeper.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kontactkeeper_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Kontactkeeper_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Kontactkeeper] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kontactkeeper].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kontactkeeper] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kontactkeeper] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kontactkeeper] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kontactkeeper] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kontactkeeper] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kontactkeeper] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kontactkeeper] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kontactkeeper] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kontactkeeper] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kontactkeeper] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kontactkeeper] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kontactkeeper] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kontactkeeper] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kontactkeeper] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kontactkeeper] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kontactkeeper] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kontactkeeper] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kontactkeeper] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kontactkeeper] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kontactkeeper] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kontactkeeper] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kontactkeeper] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kontactkeeper] SET RECOVERY FULL 
GO
ALTER DATABASE [Kontactkeeper] SET  MULTI_USER 
GO
ALTER DATABASE [Kontactkeeper] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kontactkeeper] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kontactkeeper] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kontactkeeper] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kontactkeeper] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Kontactkeeper', N'ON'
GO
ALTER DATABASE [Kontactkeeper] SET QUERY_STORE = OFF
GO
USE [Kontactkeeper]
GO
/****** Object:  Table [dbo].[tblAdmin]    Script Date: 02 Dec 2020 21:15:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAdmin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [nvarchar](50) NOT NULL,
	[LName] [nvarchar](50) NOT NULL,
	[UName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCallAgent]    Script Date: 02 Dec 2020 21:15:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCallAgent](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [nvarchar](50) NOT NULL,
	[LName] [nvarchar](50) NOT NULL,
	[UName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[TotalHours] [int] NOT NULL,
	[AgentEXT] [nvarchar](50) NOT NULL,
	[AVGCallLength] [nvarchar](50) NOT NULL,
	[TotalCalls] [int] NOT NULL,
	[Performance] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmailUser]    Script Date: 02 Dec 2020 21:15:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmailUser](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[LastSeen] [nvarchar](50) NOT NULL,
	[LastSent] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEndUser]    Script Date: 02 Dec 2020 21:15:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEndUser](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [nvarchar](50) NOT NULL,
	[LName] [nvarchar](50) NOT NULL,
	[UName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Cellnumber] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[FBID] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFBUser]    Script Date: 02 Dec 2020 21:15:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFBUser](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FBID] [nvarchar](50) NOT NULL,
	[FBName] [nvarchar](50) NOT NULL,
	[LastSeen] [datetime] NOT NULL,
	[LastSent] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblFBUser] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblWAUser]    Script Date: 02 Dec 2020 21:15:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblWAUser](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[LastSeen] [nvarchar](50) NOT NULL,
	[LastSent] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblAdmin] ON 

INSERT [dbo].[tblAdmin] ([ID], [FName], [LName], [UName], [Password]) VALUES (1, N'James', N'Ventura', N'james', N'009')
INSERT [dbo].[tblAdmin] ([ID], [FName], [LName], [UName], [Password]) VALUES (2, N'Devilliers', N'Dup', N'divdup', N'123')
INSERT [dbo].[tblAdmin] ([ID], [FName], [LName], [UName], [Password]) VALUES (4, N'Tennille', N'Hardy', N'tennille', N'123')
INSERT [dbo].[tblAdmin] ([ID], [FName], [LName], [UName], [Password]) VALUES (5, N'Kamogelo', N'Matsomela', N'kamo', N'123')
INSERT [dbo].[tblAdmin] ([ID], [FName], [LName], [UName], [Password]) VALUES (6, N'Khwezi', N'Masinga', N'KQD1', N'123')
INSERT [dbo].[tblAdmin] ([ID], [FName], [LName], [UName], [Password]) VALUES (7, N'John', N'Doe', N'JD', N'1234')
INSERT [dbo].[tblAdmin] ([ID], [FName], [LName], [UName], [Password]) VALUES (8, N'Lawrence', N'Mothabela', N'ML', N'1234')
SET IDENTITY_INSERT [dbo].[tblAdmin] OFF
SET IDENTITY_INSERT [dbo].[tblCallAgent] ON 

INSERT [dbo].[tblCallAgent] ([ID], [FName], [LName], [UName], [Password], [TotalHours], [AgentEXT], [AVGCallLength], [TotalCalls], [Performance]) VALUES (3, N'James', N'Ventura', N'james', N'008', 10, N'EXT', N'00:10:00.0000000', 3, 8)
SET IDENTITY_INSERT [dbo].[tblCallAgent] OFF
SET IDENTITY_INSERT [dbo].[tblEndUser] ON 

INSERT [dbo].[tblEndUser] ([ID], [FName], [LName], [UName], [Password], [Cellnumber], [Email], [FBID]) VALUES (14, N'Khwezi', N'Masinga', N'kw123', N'123', N'1234567890', N'123@gmail.com', N'12313333')
INSERT [dbo].[tblEndUser] ([ID], [FName], [LName], [UName], [Password], [Cellnumber], [Email], [FBID]) VALUES (19, N'James', N'Ventura', N'james', N'009', N'0721752568', N'jannesventer09@gmail.com', N'3538559629572375')
SET IDENTITY_INSERT [dbo].[tblEndUser] OFF
SET IDENTITY_INSERT [dbo].[tblWAUser] ON 

INSERT [dbo].[tblWAUser] ([ID], [Phone], [LastSeen], [LastSent]) VALUES (1, N'+27825532439', N'2020-12-02 21:13:08', N'2001-09-11 8:46:40.000')
SET IDENTITY_INSERT [dbo].[tblWAUser] OFF
USE [master]
GO
ALTER DATABASE [Kontactkeeper] SET  READ_WRITE 
GO
