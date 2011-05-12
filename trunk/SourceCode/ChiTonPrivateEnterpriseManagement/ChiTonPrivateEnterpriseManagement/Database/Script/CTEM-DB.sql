USE [CTEM-DB-v1]
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
EXEC sys.sp_db_vardecimal_storage_format N'CTEM-DB-v1', N'ON'
GO
USE [CTEM-DB-v1]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 05/11/2011 17:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[FullName] [nvarchar](125) NOT NULL,
	[Address] [nvarchar](255) NULL,
	[Email] [varchar](100) NULL,
	[Note] [nvarchar](255) NULL,
	[Position] [nvarchar](125) NOT NULL,
	[RightsValue] [bigint] NOT NULL,
	[CMND] [varchar](20) NULL,
	[Passport] [varchar](20) NULL,
	[DOB] [varchar](50) NULL,
	[MobilePhone] [varchar](15) NULL,
	[HomePhone] [varchar](15) NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Construction]    Script Date: 05/11/2011 17:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Construction](
	[ConstructionID] [bigint] IDENTITY(1,1) NOT NULL,
	[ConstructionName] [nvarchar](125) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[ConstructionAddress] [nvarchar](max) NULL,
	[CommencementDate] [datetime] NULL,
	[CompletionDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Construction] PRIMARY KEY CLUSTERED 
(
	[ConstructionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WorkerConstruction]    Script Date: 05/11/2011 17:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WorkerConstruction](
	[WorkerConstructionID] [bigint] IDENTITY(1,1) NOT NULL,
	[WorkerID] [bigint] NOT NULL,
	[ConstructionID] [bigint] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_WorkerConstruction] PRIMARY KEY CLUSTERED 
(
	[WorkerConstructionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 05/11/2011 17:29:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Worker](
	[WorkerID] [bigint] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](125) NOT NULL,
	[Address] [nvarchar](255) NULL,
	[Email] [varchar](100) NULL,
	[Note] [nvarchar](255) NULL,
	[Position] [nvarchar](125) NOT NULL,
	[CMND] [varchar](20) NULL,
	[Passport] [varchar](20) NULL,
	[DOB] [varchar](14) NULL,
	[MobilePhone] [varchar](15) NULL,
	[HomePhone] [varchar](15) NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
	[Status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[WorkerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[RightEnumAliasGenerate]    Script Date: 05/11/2011 17:29:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[RightEnumAliasGenerate] 
(
	-- Add the parameters for the function here
	@RightName VARCHAR(50)
)
RETURNS VARCHAR(50)
AS
BEGIN

	RETURN UPPER(REPLACE(@RightName, ' ', '_'))

END
GO
/****** Object:  Table [dbo].[Right]    Script Date: 05/11/2011 17:29:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Right](
	[RightID] [bigint] IDENTITY(1,1) NOT NULL,
	[RightName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Value] [bigint] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
	[EnumAlias]  AS ([dbo].[RightEnumAliasGenerate]([RightName])),
 CONSTRAINT [PK_Rights] PRIMARY KEY CLUSTERED 
(
	[RightID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployerConstruction]    Script Date: 05/11/2011 17:29:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployerConstruction](
	[EmployerConstructionID] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[ConstructionID] [bigint] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_EmployerConstruction] PRIMARY KEY CLUSTERED 
(
	[EmployerConstructionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Construction]    Script Date: 05/11/2011 17:29:57 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Construction]
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Employees]    Script Date: 05/11/2011 17:29:57 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Employees] FOREIGN KEY([Username])
REFERENCES [dbo].[Employee] ([Username])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Employees]
GO
