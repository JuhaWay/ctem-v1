USE [CTEM-DB-v1]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  Table [dbo].[MenuRole]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  UserDefinedFunction [dbo].[RightEnumAliasGenerate]    Script Date: 05/15/2011 07:03:38 ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  Table [dbo].[Construction]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  Table [dbo].[WorkerConstruction]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  Table [dbo].[Worker]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  StoredProcedure [dbo].[Role_GetByMenuID]    Script Date: 05/15/2011 07:03:35 ******/
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
/****** Object:  StoredProcedure [dbo].[Role_GetAll]    Script Date: 05/15/2011 07:03:35 ******/
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
/****** Object:  Table [dbo].[Right]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  StoredProcedure [dbo].[MenuRole_Create]    Script Date: 05/15/2011 07:03:35 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_Update]    Script Date: 05/15/2011 07:03:35 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_GetByRoleID]    Script Date: 05/15/2011 07:03:35 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_GetAll]    Script Date: 05/15/2011 07:03:35 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_Delete]    Script Date: 05/15/2011 07:03:35 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_Create]    Script Date: 05/15/2011 07:03:35 ******/
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
/****** Object:  StoredProcedure [dbo].[GetEmployerByUsername]    Script Date: 05/15/2011 07:03:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[GetEmployerByUsername]
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
/****** Object:  Table [dbo].[EmployerConstruction]    Script Date: 05/15/2011 07:03:37 ******/
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
/****** Object:  ForeignKey [FK_EmployerConstruction_Construction]    Script Date: 05/15/2011 07:03:37 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Construction]
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Employees]    Script Date: 05/15/2011 07:03:37 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Employees] FOREIGN KEY([Username])
REFERENCES [dbo].[Employee] ([Username])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Employees]
GO
