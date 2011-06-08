USE [master]
GO

/****** Object:  Database [CTEM-DB-v1]    Script Date: 06/05/2011 21:16:43 ******/
CREATE DATABASE [CTEM-DB-v1] ON  PRIMARY 
( NAME = N'CTEM-DB-v1', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\CTEM-DB-v1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CTEM-DB-v1_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA\CTEM-DB-v1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [CTEM-DB-v1] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CTEM-DB-v1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [CTEM-DB-v1] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET ARITHABORT OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [CTEM-DB-v1] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [CTEM-DB-v1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [CTEM-DB-v1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET  DISABLE_BROKER 
GO

ALTER DATABASE [CTEM-DB-v1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [CTEM-DB-v1] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [CTEM-DB-v1] SET  READ_WRITE 
GO

ALTER DATABASE [CTEM-DB-v1] SET RECOVERY FULL 
GO

ALTER DATABASE [CTEM-DB-v1] SET  MULTI_USER 
GO

ALTER DATABASE [CTEM-DB-v1] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [CTEM-DB-v1] SET DB_CHAINING OFF 
GO
