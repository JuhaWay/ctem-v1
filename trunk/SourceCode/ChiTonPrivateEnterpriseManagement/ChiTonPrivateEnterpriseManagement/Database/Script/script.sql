USE [master]
GO
/****** Object:  Database [CTEM-DB-v1]    Script Date: 05/19/2011 17:21:44 ******/
CREATE DATABASE [CTEM-DB-v1] ON  PRIMARY 
( NAME = N'CTEM-DB-v1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CTEM-DB-v1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CTEM-DB-v1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CTEM-DB-v1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[Role]    Script Date: 05/19/2011 17:21:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[RightsValue] [bigint] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 05/19/2011 17:21:46 ******/
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
	[RoleID] [bigint] NULL,
	[RightsValue] [bigint] NULL,
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
/****** Object:  Table [dbo].[Construction]    Script Date: 05/19/2011 17:21:46 ******/
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
/****** Object:  Table [dbo].[Menu]    Script Date: 05/19/2011 17:21:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] NOT NULL,
	[MenuName] [nvarchar](125) NOT NULL,
	[Parent] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuRole]    Script Date: 05/19/2011 17:21:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuRole](
	[MenuRoleID] [bigint] IDENTITY(1,1) NOT NULL,
	[MenuID] [int] NOT NULL,
	[RoleID] [bigint] NOT NULL,
 CONSTRAINT [PK_MenuRole] PRIMARY KEY CLUSTERED 
(
	[MenuRoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkerConstruction]    Script Date: 05/19/2011 17:21:46 ******/
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
/****** Object:  Table [dbo].[Worker]    Script Date: 05/19/2011 17:21:46 ******/
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
/****** Object:  UserDefinedFunction [dbo].[RightEnumAliasGenerate]    Script Date: 05/19/2011 17:21:48 ******/
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
/****** Object:  StoredProcedure [dbo].[MenuRole_Create]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[MenuRole_Create]
	@MenuID		INT,
	@RoleID		BIGINT
AS
BEGIN
	INSERT INTO MenuRole 
			(MenuID, RoleID)
	VALUES	(@MenuID, @RoleID)
END
GO
/****** Object:  StoredProcedure [dbo].[Role_GetByMenuID]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Role_GetByMenuID]
	@menuID BIGINT
AS
BEGIN
	SELECT	RoleID, RoleName, Description, RightsValue, IsActive, CreatedDate, LastUpdated, CreatedBy, UpdatedBy
	FROM	Role
	WHERE	RoleID IN	(
							SELECT	RoleID
							FROM	MenuRole
							WHERE	MenuID = @menuID
						)
END
GO
/****** Object:  StoredProcedure [dbo].[Role_GetAll]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Role_GetAll]
AS
BEGIN
	SELECT	RoleID, RoleName, Description, RightsValue, IsActive, CreatedDate, LastUpdated, CreatedBy, UpdatedBy
	FROM	Role
END
GO
/****** Object:  StoredProcedure [dbo].[Menu_Update]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Menu_Update]
	@menuID			INT,
	@menuName		NVARCHAR(125),
	@parent			INT,
	@description	NVARCHAR(MAX)
AS
BEGIN
	UPDATE  [Menu]
	SET     MenuName = @menuName,
			Parent = @parent,
			Description = @description
	WHERE	MenuID = @menuID
END
GO
/****** Object:  StoredProcedure [dbo].[Menu_GetByRoleID]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Menu_GetByRoleID]
	@roleID BIGINT
AS
BEGIN
	SELECT	MenuID, MenuName, Parent, Description
	FROM	Menu
	WHERE	MenuID IN	(
							SELECT	MenuID
							FROM	MenuRole
							WHERE	RoleID = @roleID
						)
END
GO
/****** Object:  StoredProcedure [dbo].[Menu_GetAll]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Menu_GetAll]
AS
BEGIN
	SELECT	MenuID, MenuName, Parent, Description
	FROM	Menu
END
GO
/****** Object:  StoredProcedure [dbo].[Menu_Delete]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Menu_Delete]
	@menuID	INT	
AS
BEGIN
	DELETE FROM [MenuRole]
	WHERE		MenuID = @menuID
	
	DELETE FROM [Menu]
	WHERE		MenuID = @menuID
END
GO
/****** Object:  StoredProcedure [dbo].[Menu_Create]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Menu_Create]
	@menuID			INT,
	@menuName		NVARCHAR(125),
	@parent			INT,
	@description	NVARCHAR(MAX)
AS
BEGIN
	INSERT INTO Menu 
			(MenuID, MenuName, Parent, Description)
	VALUES	(@menuID, @menuName, @parent, @description)	
END
GO
/****** Object:  Table [dbo].[EmployerConstruction]    Script Date: 05/19/2011 17:21:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Employer_GetByUsername]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employer_GetByUsername]
	@username VARCHAR(50)
AS
BEGIN
	SELECT	E.Username,E.Password,E.FullName,
			E.Address,E.Email,E.Note,
			E.RoleID, E.RightsValue,E.CMND,E.Passport,
			E.DOB,E.MobilePhone,E.HomePhone,E.CreatedDate,
			E.LastUpdated,E.CreatedBy,E.UpdatedBy, E.Status, R.RoleName
	FROM	Employee E JOIN Role R ON E.RoleID = R.RoleID
	WHERE	E.Username = @username
END
GO
/****** Object:  Table [dbo].[Rights]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rights](
	[RightID] [bigint] NOT NULL,
	[RightName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Value] [bigint] NOT NULL,
	[isActive] [bit] NOT NULL,
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
/****** Object:  StoredProcedure [dbo].[Rights_Update]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Rights_Update]
	@rightID		BIGINT,
	@rightName		NVARCHAR(50),
	@description	NVARCHAR(225),
	@isActive		BIT,
	@updatedBy		NVARCHAR(50)
AS
	DECLARE @lastUpdate DATETIME;
	SET		@lastUpdate = GETDATE();
BEGIN
	UPDATE	[Rights]
	SET		RightName = @rightName,
			Description = @description,
			isActive = @isActive,
			LastUpdated =@lastUpdate,
			UpdatedBy = @updatedBy		
	WHERE	RightID = @rightID
END
GO
/****** Object:  StoredProcedure [dbo].[Rights_GetAll]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Rights_GetAll]
AS
BEGIN
	SELECT	RightID, RightName, Description, Value, isActive, CreatedDate, LastUpdated, CreatedBy, UpdatedBy, EnumAlias
	FROM	Rights
END
GO
/****** Object:  StoredProcedure [dbo].[Rights_Delete]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Rights_Delete]
	@rightID	INT	
AS
BEGIN
	DELETE FROM [Rights]
	WHERE		RightID = @rightID
END
GO
/****** Object:  StoredProcedure [dbo].[Rights_Create]    Script Date: 05/19/2011 17:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Rights_Create]
	@rightID		BIGINT,
	@rightName		NVARCHAR(50),
	@description	NVARCHAR(225),
	@value			BIGINT,
	@isActive		BIT,
	@createdBy		NVARCHAR(50),
	@updatedBy		NVARCHAR(50)
AS
	DECLARE @createdDate DATETIME;
	SET		@createdDate = GETDATE();
BEGIN
	INSERT INTO Rights 
			(RightID, RightName, Description, Value, isActive, CreatedDate, LastUpdated, CreatedBy, UpdatedBy)
	VALUES	(@rightID, @rightName, @description, @value, @isActive, @createdDate, @createdDate, @createdBy, @updatedBy)	
END
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Construction]    Script Date: 05/19/2011 17:21:50 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Construction]
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Employees]    Script Date: 05/19/2011 17:21:50 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Employees] FOREIGN KEY([Username])
REFERENCES [dbo].[Employee] ([Username])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Employees]
GO
