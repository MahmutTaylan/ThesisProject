USE [master]
GO
/****** Object:  Database [mythesis]    Script Date: 16.12.2014 17:24:53 ******/
CREATE DATABASE [mythesis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mythesis', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\mythesis.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'mythesis_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\mythesis_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [mythesis] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mythesis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mythesis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mythesis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mythesis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mythesis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mythesis] SET ARITHABORT OFF 
GO
ALTER DATABASE [mythesis] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mythesis] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [mythesis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mythesis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mythesis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mythesis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mythesis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mythesis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mythesis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mythesis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mythesis] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mythesis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mythesis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mythesis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mythesis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mythesis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mythesis] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mythesis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mythesis] SET RECOVERY FULL 
GO
ALTER DATABASE [mythesis] SET  MULTI_USER 
GO
ALTER DATABASE [mythesis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mythesis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mythesis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mythesis] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'mythesis', N'ON'
GO
USE [mythesis]
GO
/****** Object:  Table [dbo].[author]    Script Date: 16.12.2014 17:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[author](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[university_id] [int] NULL,
	[faculty_id] [int] NULL,
	[department_id] [int] NULL,
	[instructer_id] [int] NULL,
	[name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[department]    Script Date: 16.12.2014 17:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[department](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[faculty_id] [int] NULL,
	[name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[faculty]    Script Date: 16.12.2014 17:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[faculty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[university_id] [int] NULL,
	[name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[instructer]    Script Date: 16.12.2014 17:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[instructer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[deparment_id] [int] NULL,
	[name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[thesis]    Script Date: 16.12.2014 17:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[thesis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[author_id] [int] NULL,
	[name] [varchar](255) NULL,
	[years] [varchar](255) NULL,
	[detail] [varchar](255) NULL,
	[texts] [varchar](255) NULL,
	[subjects] [varchar](255) NULL,
	[paths] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[university]    Script Date: 16.12.2014 17:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[university](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 16.12.2014 17:24:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[username] [varchar](255) NULL,
	[password] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [mythesis] SET  READ_WRITE 
GO
