USE [CTEM-DB-v1]
GO
/****** Object:  Table [dbo].[Subcontractor]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subcontractor](
	[SubcontractorID] [bigint] IDENTITY(1,1) NOT NULL,
	[SubcontractorName] [nvarchar](50) NOT NULL,
	[SubcontractorAddress] [nvarchar](250) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_Subcontractor] PRIMARY KEY CLUSTERED 
(
	[SubcontractorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockOutDetail]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOutDetail](
	[StockOutID] [bigint] NOT NULL,
	[MaterialID] [bigint] NOT NULL,
	[Quantity] [float] NOT NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_StockOutDetail] PRIMARY KEY CLUSTERED 
(
	[StockOutID] ASC,
	[MaterialID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockOut]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOut](
	[StockOutID] [bigint] IDENTITY(1,1) NOT NULL,
	[DateStockOut] [datetime] NULL,
	[StockOutFrom] [nvarchar](50) NULL,
	[StockOutTo] [nvarchar](50) NULL,
	[Driver] [nvarchar](50) NULL,
	[TransportationCost] [bigint] NULL,
	[NoVehicle] [nvarchar](50) NULL,
	[Note] [nvarchar](max) NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_StockOut] PRIMARY KEY CLUSTERED 
(
	[StockOutID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[VehicleID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](125) NULL,
	[Number] [nvarchar](125) NULL,
	[WarehouseID] [nvarchar](125) NULL,
	[ConstructionID] [bigint] NULL,
	[ManagerID] [bigint] NULL,
	[Status] [nvarchar](125) NOT NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[RightsValue] [bigint] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[RightEnumAliasGenerate]    Script Date: 07/19/2011 19:47:00 ******/
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
/****** Object:  Table [dbo].[Menu]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] NOT NULL,
	[MenuName] [nvarchar](125) NOT NULL,
	[Parent] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ledger]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ledger](
	[LedgerID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Number] [bit] NULL,
	[Person] [nvarchar](50) NULL,
	[Reason] [nvarchar](50) NULL,
	[Method] [nvarchar](50) NULL,
	[Date] [datetime] NULL,
	[Kind] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ledger] PRIMARY KEY CLUSTERED 
(
	[LedgerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[MaterialID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaterialName] [nvarchar](max) NOT NULL,
	[MaterialParentID] [bigint] NULL,
	[EstimateCalUnit] [nvarchar](50) NULL,
	[RealCalUnit] [nvarchar](50) NULL,
	[Ratio] [float] NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Construction]    Script Date: 07/19/2011 19:46:59 ******/
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
	[ParentID] [bigint] NULL,
	[ManagerID] [bigint] NOT NULL,
	[Status] [nvarchar](50) NULL,
	[HasEstimate] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
	[SubcontractorID] [bigint] NULL,
	[ProgressRate] [float] NULL,
	[Type] [nvarchar](50) NULL,
	[IsDeleted] [char](1) NULL,
 CONSTRAINT [PK_Construction] PRIMARY KEY CLUSTERED 
(
	[ConstructionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Debt]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Debt](
	[DebtID] [bigint] IDENTITY(1,1) NOT NULL,
	[DebtName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[TotalOwe] [bigint] NOT NULL,
	[IsActive] [bit] NULL,
	[Note] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Debt] PRIMARY KEY CLUSTERED 
(
	[DebtID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleDairy]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleDairy](
	[VehicleDairyID] [bigint] IDENTITY(1,1) NOT NULL,
	[VehicleID] [bigint] NULL,
	[ConstructionID] [bigint] NOT NULL,
	[DriverID] [bigint] NULL,
	[RoadMap] [nvarchar](50) NULL,
	[FualCost] [bigint] NULL,
	[DamagedCost] [bigint] NULL,
	[Date] [datetime] NULL,
	[isPaid] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Warehouse]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Warehouse](
	[WarehouseID] [bigint] IDENTITY(1,1) NOT NULL,
	[WarehouseName] [nvarchar](250) NULL,
	[ConstructionID] [bigint] NULL,
	[ManagerName] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Type] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Warehouse] PRIMARY KEY CLUSTERED 
(
	[WarehouseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkersSalary]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkersSalary](
	[WorkersSalaryID] [bigint] IDENTITY(1,1) NOT NULL,
	[ConstructionID] [bigint] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[FromDate] [datetime] NOT NULL,
	[ToDate] [datetime] NOT NULL,
	[TotalSalary] [bigint] NOT NULL,
	[CreateDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_WorkersSalary] PRIMARY KEY CLUSTERED 
(
	[WorkersSalaryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_GetStockOut]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_GetStockOut]
	@WarehouseName	NVARCHAR(50),
	@from			DATETIME,
	@to				DATETIME
AS
BEGIN
	SELECT	S.* 
	FROM	StockOut S LEFT OUTER JOIN Vehicle V ON S.NoVehicle = V.VehicleID
	WHERE	StockOutFrom LIKE N'%' + @WarehouseName + '%' AND
			DateStockOut BETWEEN @from AND @to
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_Get]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_Get]
	@Type	NVARCHAR(50),
	@Name	NVARCHAR(150),
	@Status INT
AS
BEGIN
	IF @Status = -1
	BEGIN
		SELECT	W.*, C.ConstructionName
		FROM	Warehouse W LEFT OUTER JOIN Construction C ON W.ConstructionID = C.ConstructionID
		WHERE	W.[Type] LIKE N'%' + @Type + '%' AND
				W.[WarehouseName] LIKE N'%' + @Name + '%'
	END

	IF @Status <> -1
	BEGIN
		SELECT	W.*, C.ConstructionName
		FROM	Warehouse W LEFT OUTER JOIN Construction C ON W.ConstructionID = C.ConstructionID
		WHERE	W.[Type] LIKE N'%' + @Type + '%' AND
				W.[WarehouseName] LIKE N'%' + @Name + '%' AND
				IsActive = CONVERT(BIT,  @Status)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_DeleteStockOut]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_DeleteStockOut]
    @StockoutId	BIGINT   
AS
BEGIN
	DELETE FROM StockOutDetail
	WHERE		StockOutID = @StockoutId
	
    DELETE FROM StockOut
    WHERE		StockOutID = @StockoutId    
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_DeleteAllStock]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_DeleteAllStock]
AS
BEGIN
    DELETE FROM StockOutDetail
    
    DELETE FROM StockOut
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_Update]
	@WarehouseID	BIGINT,
	@WarehouseName	NVARCHAR(225),
	@ConstructionID	BIGINT,
	@ManagerName	NVARCHAR(50),
	@Description	NVARCHAR(MAX),
	@Type			NVARCHAR(50),
	@Address		NVARCHAR(MAX),
	@IsActive		BIT
AS
BEGIN
	UPDATE	Warehouse
	SET		WarehouseName = @WarehouseName,
			ConstructionID = @ConstructionID,
			ManagerName = @ManagerName,
			[Description] = @Description,
			[Type] = @Type,
			[Address]= @Address,
			IsActive = @IsActive
	WHERE	WarehouseID = @WarehouseID
END
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Worker](
	[WorkerID] [bigint] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](125) NOT NULL,
	[WorkersSalaryID] [bigint] NULL,
	[ManDate] [float] NULL,
	[Salary] [bigint] NULL,
	[TotalSalary] [bigint] NULL,
	[Position] [nvarchar](125) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[WorkerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[WorkerSalary_Update]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[WorkerSalary_Update]
    @workersSalaryID        bigint,
	@constructionID			bigint,
	@name					NVARCHAR(225),
	@fromDate				DateTime,
	@toDate					DateTime,
	@totalSalary			decimal(18, 0),
	@updatedBy				nvarchar(50)
AS
	DECLARE @lastUpdate	DATETIME
    SET     @lastUpdate = GETDATE()
BEGIN
	UPDATE  [WorkersSalary]
			
	SET      ConstructionID = @constructionID,
			Name = @name,
			FromDate = @fromDate,
			ToDate = @toDate,
			TotalSalary =@totalSalary,
			LastUpdate=@lastUpdate,
			UpdatedBy=@updatedBy
	WHERE	WorkersSalaryID = @workersSalaryID
END
GO
/****** Object:  StoredProcedure [dbo].[WorkerSalary_search]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[WorkerSalary_search]
		@Name             nvarchar(250),
		@ConstructionID   bigint
AS
BEGIN
	SELECT	*
	FROM	WorkersSalary e
	LEFT OUTER JOIN Construction c
	ON      e.ConstructionID = c.ConstructionID
	WHERE e.Name like ISNULL(@Name,e.Name)
	AND   e.ConstructionID =ISNULL(@ConstructionID,e.ConstructionID)
END
GO
/****** Object:  StoredProcedure [dbo].[WorkerSalary_GetAll]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[WorkerSalary_GetAll]
AS
BEGIN
	SELECT	*
	FROM	WorkersSalary e
	INNER JOIN Construction c
	ON      e.ConstructionID = c.ConstructionID
END
GO
/****** Object:  StoredProcedure [dbo].[WorkerSalary_Create]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[WorkerSalary_Create]
	@constructionID			bigint,
	@name					NVARCHAR(225),
	@fromDate				DateTime,
	@toDate					DateTime,
	@totalSalary			decimal(18, 0),
	@createdBy				nvarchar(50)

AS
	DECLARE @createDate	DATETIME
    SET     @createDate = GETDATE()
BEGIN
	INSERT INTO WorkersSalary 
			(ConstructionID,Name,FromDate,ToDate,
			TotalSalary,CreateDate,CreatedBy)
	VALUES	(@constructionID,@name,@fromDate,@toDate,
			@totalSalary,@createDate,@createdBy)	
END
GO
/****** Object:  StoredProcedure [dbo].[VehicleDairy_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[VehicleDairy_Delete]
    @VehicleDairyID          bigint
   
AS
BEGIN
    DELETE FROM VehicleDairy
    WHERE VehicleDairyID = @VehicleDairyID
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_Create]
	@WarehouseName	NVARCHAR(225),
	@ConstructionID	BIGINT,
	@ManagerName	NVARCHAR(50),
	@Description	NVARCHAR(MAX),
	@Type			NVARCHAR(50),
	@Address		NVARCHAR(MAX),
	@IsActive		BIT
AS
--DECLARE @CreatedDate DATETIME
--SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO Warehouse
			(WarehouseName, ConstructionID, ManagerName, [Description], [Type], [Address], IsActive)
	VALUES	(@WarehouseName, @ConstructionID, @ManagerName, @Description, @Type, @Address, @IsActive)
END
GO
/****** Object:  StoredProcedure [dbo].[Menu_Create]    Script Date: 07/19/2011 19:46:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Warehouse_CreateStockOut]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_CreateStockOut]
	@DateStockOut		DATETIME,
	@StockOutFrom		NVARCHAR(50),
	@StockOutTo			NVARCHAR(50),
	@Driver				NVARCHAR(50),
	@TransportationCost	BIGINT,
	@NoVehicle			NVARCHAR(50),
	@Note				NVARCHAR(MAX),
	@CreatedBy			NVARCHAR(50)
AS
DECLARE @CreatedDate DATETIME
SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO StockOut 
			(DateStockOut, StockOutFrom, StockOutTo, Driver, TransportationCost, NoVehicle, Note, CreateDate, LastUpdate, CreatedBy, UpdatedBy)
	VALUES	(@DateStockOut, @StockOutFrom, @StockOutTo, @Driver, @TransportationCost, @NoVehicle, @Note, @CreatedDate, @CreatedDate, @CreatedBy, @CreatedBy)
END
GO
/****** Object:  StoredProcedure [dbo].[Vehicle_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Vehicle_Delete]
    @VehicleID           bigint
   
AS
BEGIN
    DELETE FROM Vehicle
    WHERE VehicleID = @VehicleID
END
GO
/****** Object:  StoredProcedure [dbo].[Vehicle_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
create PROCEDURE [dbo].[Vehicle_Create]
	@ConstructionID			bigint,
	@WarehouseID			bigint,
	@ManagerID				bigint,
	@Name					NVARCHAR(225),
	@Number					NVARCHAR(125),
	@Status					NVARCHAR(125)

AS
BEGIN
	INSERT INTO Vehicle
	(Name,Number,ManagerID,WarehouseID,ConstructionID,Status)
	VALUES	
	(@Name,@Number,@ManagerID,@WarehouseID,@ConstructionID,@Status)
END
GO
/****** Object:  StoredProcedure [dbo].[Role_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
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
	SELECT	RoleID, RoleName, Description, RightsValue, IsActive
	FROM	Role
END
GO
/****** Object:  StoredProcedure [dbo].[Role_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Role_Delete]
	@roleID	INT	
AS
BEGIN
	DELETE FROM [Role]
	WHERE		RoleID = @roleID
END
GO
/****** Object:  StoredProcedure [dbo].[Role_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Role_Create]	
	@roleName		NVARCHAR(50),
	@description	NVARCHAR(225),
	@rightsValue	BIGINT,
	@isActive		BIT
AS
BEGIN
	INSERT INTO Role 
			(RoleName, Description, RightsValue, IsActive)
	VALUES	(@roleName, @description, @rightsValue, @isActive)	
END
GO
/****** Object:  Table [dbo].[Rights]    Script Date: 07/19/2011 19:46:59 ******/
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
	[EnumAlias]  AS ([dbo].[RightEnumAliasGenerate]([RightName])),
 CONSTRAINT [PK_Rights] PRIMARY KEY CLUSTERED 
(
	[RightID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Vehicle_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
create PROCEDURE [dbo].[Vehicle_Update]
    @VehicleID				bigint,
	@ConstructionID			bigint,
	@WarehouseID			bigint,
	@ManagerID				bigint,
	@Name					NVARCHAR(225),
	@Number					NVARCHAR(125),
	@Status					NVARCHAR(125)

AS
BEGIN
	UPDATE  [Vehicle]
			
	SET    	Name = @Name,
			Number = @Number,
			ManagerID= @ManagerID,
			WarehouseID =@WarehouseID,
			ConstructionID = @ConstructionID,
			Status=@Status
	WHERE	VehicleID = @VehicleID
END
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[FullName] [nvarchar](125) NOT NULL,
	[Address] [nvarchar](255) NULL,
	[Email] [nvarchar](100) NULL,
	[Note] [nvarchar](255) NULL,
	[RoleID] [bigint] NULL,
	[RightsValue] [bigint] NULL,
	[CMND] [varchar](20) NULL,
	[DOB] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[PhoneNumber] [varchar](15) NULL,
	[TotalDebt] [bigint] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Estimate]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estimate](
	[EstimateID] [bigint] IDENTITY(1,1) NOT NULL,
	[ConstructionID] [bigint] NOT NULL,
	[EstimateName] [nvarchar](150) NOT NULL,
	[TotalCostEstimate] [bigint] NULL,
	[TotalCostReal] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[TotalMaterialCost] [bigint] NULL,
	[TotalWorkerCost] [bigint] NULL,
	[TotalMachineCost] [bigint] NULL,
	[TotalCostsIncurred] [bigint] NULL,
	[Type] [int] NULL,
 CONSTRAINT [PK_Estimate] PRIMARY KEY CLUSTERED 
(
	[EstimateID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetAllParentandChildren]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_GetAllParentandChildren]
AS
BEGIN
	SELECT	*
	FROM Construction
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_GetAll]
AS
BEGIN
	SELECT	*
	FROM Construction
	WHERE  ParentID!=0 AND IsDeleted!=1 AND HasEstimate='True'
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetByName]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_GetByName]
    @constructionName nvarchar(125)

AS
BEGIN
    SELECT    *
    FROM    Construction
    WHERE    ConstructionName =@constructionName AND IsDeleted!=1 
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_Create]
	@DebtName		NVARCHAR(MAX),
	@Address		NVARCHAR(MAX),
	@PhoneNumber	NVARCHAR(50),
	@TotalOwe		BIGINT,
	@IsActive		BIT,
	@Note			NVARCHAR(MAX),
	@CreatedBy		NVARCHAR(50)
AS
DECLARE @CreatedDate DATETIME
SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO Debt 
			(DebtName, Address, PhoneNumber, TotalOwe, IsActive, Note, CreatedDate, UpdatedDate, CreatedBy, UpdatedBy)
	VALUES	(@DebtName, @Address, @PhoneNumber, @TotalOwe, @IsActive, @Note, @CreatedDate, @CreatedDate, @CreatedBy, @CreatedBy)
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_Create]
	@constructionName		NVARCHAR(50),
	@subconstractorID		bigint,
	@description			NVARCHAR(225),
	@constructionAddress	NVARCHAR(225),
	@commencementDate       DATETIME ,
	@completionDate			DATETIME,
	@progressRate			decimal(18, 0),
	@status					nvarchar(50),
	@type					nvarchar(50),
	@hasEstimate			bit,
	@parentID				bigint,
	@managerID				bigint,
	@createdBy				nvarchar(50)
AS
	DECLARE @CreatedDate	DATETIME
    SET     @CreatedDate = GETDATE()
BEGIN
	INSERT INTO Construction 
			(ConstructionName,SubcontractorID, Description,ConstructionAddress,
			CommencementDate,CompletionDate,Status,HasEstimate,ParentID,CreatedBy, CreatedDate,ProgressRate,Type,ManagerID)
	VALUES	(@constructionName,@subconstractorID,@description	,@constructionAddress,
			@commencementDate,@completionDate,@status,@hasEstimate,@parentID,@createdBy, @CreatedDate,@progressRate,@type,@managerID)	
END
SELECT  IDENT_CURRENT('Construction')
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetHaveWarehouse]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_GetHaveWarehouse]
AS
BEGIN
	SELECT	C.*, W.WarehouseID
	FROM	Construction C JOIN Warehouse W ON C.ConstructionID = W.ConstructionID
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_Update]
	@DebtID			BIGINT,
	@DebtName		NVARCHAR(50),
	@Address		NVARCHAR(MAX),
	@TotalOwe		BIGINT,
	@IsActive		BIT,
	@Note			NVARCHAR(MAX),
	@PhoneNumber	NVARCHAR(50),
	@UpdatedBy		NVARCHAR(50)
AS
DECLARE @LastUpdated DATETIME
SET		@LastUpdated = GETDATE()
BEGIN	
	UPDATE	Debt
	SET		DebtName = @DebtName,
			Address = @Address,
			TotalOwe = @TotalOwe,
			IsActive =  @IsActive,
			Note = @Note,
			PhoneNumber = @PhoneNumber,
			UpdatedBy = @UpdatedBy,
			UpdatedDate = @LastUpdated
	WHERE	DebtID = @DebtID
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_GetDebt]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_GetDebt]
	@DebtID		BIGINT,
	@DebtName	NVARCHAR(250),
	@Status		INT
AS
BEGIN
	IF @DebtID = 0 AND @Status = -1
	BEGIN
		SELECT	*
		FROM	Debt
		WHERE   DebtName LIKE N'%' + @DebtName + '%'
	END
	
	IF @DebtID <> 0 AND @Status = -1
	BEGIN
		SELECT	*
		FROM	Debt
		WHERE   DebtName LIKE N'%' + @DebtName + '%' AND
				DebtID = @DebtID
	END
	
	IF @DebtID = 0 AND @Status <> -1
	BEGIN
		SELECT	*
		FROM	Debt
		WHERE   DebtName LIKE N'%' + @DebtName + '%' AND
				IsActive = CONVERT(BIT,  @Status)
	END
	
	IF @DebtID <> 0 AND @Status <> -1
	BEGIN
		SELECT	*
		FROM	Debt
		WHERE   DebtName LIKE N'%' + @DebtName + '%' AND
				DebtID = @DebtID AND
				IsActive = CONVERT(BIT,  @Status)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_UpdateTotalEstimateCost]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_UpdateTotalEstimateCost]
	@constructionID			BIGINT,
	@totalEstimateCost		decimal(18, 0)
AS
BEGIN
	UPDATE  [Construction]
			
	SET    TotalEstimateCost=@totalEstimateCost
	WHERE	ConstructionID =@constructionID
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_UpdateTotal]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_UpdateTotal]
    @ConstructionID        bigint
AS
	DECLARE @totalEstimateCost	bigint
	DECLARE @totalRealCost	bigint
BEGIN
	SET @totalEstimateCost = (SELECT SUM(EstimateCost) FROM Construction WHERE ParentID = @ConstructionID)
	SET @totalRealCost = (SELECT SUM(RealCost) FROM Construction WHERE ParentID = @ConstructionID)
	UPDATE  [Construction]			
	SET    TotalEstimateCost = EstimateCost +@totalEstimateCost,
		   TotalRealCost = RealCost +@totalRealCost				
	WHERE	ConstructionID = @ConstructionID
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_Update]
	@constructionID			BIGINT,
	@constructionName		NVARCHAR(50),
	@subconstractorID		bigint,
	@description			NVARCHAR(225),
	@constructionAddress	NVARCHAR(225),
	@commencementDate       DATETIME ,
	@progressRate			decimal(18, 0),
	@completionDate			DATETIME,
	@status					nvarchar(50),
	@hasEstimate			bit,
	@managerID				bigint,
	@updatedBy				nvarchar(50)
AS
	DECLARE @LastUpdated	DATETIME
    SET     @LastUpdated = GETDATE()
BEGIN
	UPDATE  [Construction]
			
	SET     ConstructionName = @constructionName,
			SubcontractorID = @subconstractorID,
			Description = @description,
			ConstructionAddress = @constructionAddress,
			CommencementDate =@commencementDate,
			completionDate = @completionDate,
			ProgressRate =@progressRate,
			Status=@status,
			ManagerID = @managerID,
			HasEstimate=@hasEstimate,
			LastUpdated = @LastUpdated,
			UpdatedBy = @updatedBy
	WHERE	ConstructionID =@constructionID
END
GO
/****** Object:  Table [dbo].[ComparationDebt]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComparationDebt](
	[ComparationDebtID] [bigint] IDENTITY(1,1) NOT NULL,
	[DebtID] [bigint] NOT NULL,
	[RepresentationDebtName] [nvarchar](50) NOT NULL,
	[DateCompare] [datetime] NULL,
	[TotalOwe] [bigint] NOT NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ComparationDebt] PRIMARY KEY CLUSTERED 
(
	[ComparationDebtID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Ledger_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Ledger_Update]
	@LedgerID           bigint,
	@Name				nvarchar(50),
	@Type				nvarchar(50),
	@Kind				nvarchar(50),
	@Number				bigint,
	@Person				nvarchar(50),
	@Reason				nvarchar(50),
	@Method				nvarchar(50),
	@Date			    DATETIME
AS
BEGIN
	UPDATE Ledger
	SET Name = @Name,
	    Type = @Type,
	    Kind = @Kind,
	    Number = @Number,
	    Person = @Person,
	    Reason = @Reason,
	    Method = @Method,
	    Date = @Date
	 WHERE LedgerID = @LedgerID   
	
END
GO
/****** Object:  StoredProcedure [dbo].[Ledger_search]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Ledger_search]
		@Name			 nvarchar(50),
		@Type			 nvarchar(50),
		@Person			 nvarchar(50),
		@Kind		     nvarchar(50)
		
AS	
BEGIN
	SELECT	*
	FROM	Ledger v
	WHERE v.Name like ISNULL(@Name,v.Name) 
	and v.Type = ISNULL(@Type,v.Type) 
	and v.Person like ISNULL(@Person,v.Person)
	and v.Kind = ISNULL(@Kind,v.Kind) 
END
GO
/****** Object:  StoredProcedure [dbo].[Ledger_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Ledger_GetAll]
AS
BEGIN
	SELECT	*
	FROM	Ledger
END
GO
/****** Object:  StoredProcedure [dbo].[Ledger_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Ledger_Delete]
    @LedgerID          bigint
   
AS
BEGIN
    DELETE FROM Ledger
    WHERE LedgerID = @LedgerID
END
GO
/****** Object:  StoredProcedure [dbo].[Ledger_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Ledger_Create]
	@Name				nvarchar(50),
	@Type				nvarchar(50),
	@Kind				nvarchar(50),
	@Number				bigint,
	@Person				nvarchar(125),
	@Reason				nvarchar(125),
	@Method				nvarchar(125),
	@Date			    DATETIME
AS
BEGIN
	INSERT INTO Ledger
	(Name,Type,Number,Person,Reason,Method,Date,Kind)
	VALUES	
	(@Name,@Type,@Number,@Person,@Reason,@Method,@Date,@Kind)
END
GO
/****** Object:  StoredProcedure [dbo].[Material_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Material_GetAll]
AS
BEGIN
    SELECT    *
    FROM   Material

END
GO
/****** Object:  StoredProcedure [dbo].[Material_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Material_Delete]
    @MaterialID            bigint
   
AS
BEGIN
    DELETE FROM Material
    WHERE MaterialID = @MaterialID
END
GO
/****** Object:  Table [dbo].[MaterialWarehouse]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialWarehouse](
	[WarehouseID] [bigint] NOT NULL,
	[MaterialID] [bigint] NOT NULL,
	[Quantity] [float] NOT NULL,
	[AveragePrice] [bigint] NOT NULL,
	[TotalCost] [bigint] NOT NULL,
 CONSTRAINT [PK_MaterialWarehouse] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC,
	[WarehouseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Material_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Material_Update]
	@MaterialID			BIGINT,
	@MaterialName		NVARCHAR(50),
	@MaterialParentID   bigint,
	@EstimateCalUnit	NVARCHAR(225),
	@RealCalUnit		NVARCHAR(225),
	@Ratio				FLOAT 
AS
BEGIN
	UPDATE  [Material]
			
	SET     MaterialName = @MaterialName,
			MaterialParentID = @MaterialParentID,
			EstimateCalUnit = @EstimateCalUnit,
			RealCalUnit = @RealCalUnit,
			Ratio =@Ratio

	WHERE	MaterialID =@MaterialID
END
GO
/****** Object:  StoredProcedure [dbo].[Material_search]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Material_search]
        @Name    nvarchar(MAX)
AS
BEGIN
    SELECT    *
    FROM   Material
    WHERE MaterialName like ISNULL(@Name,MaterialName)

END
GO
/****** Object:  StoredProcedure [dbo].[Materital_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Materital_Create]
	@MaterialName			NVARCHAR(50),
	@MaterialParentID		bigint,
	@EstimateCalUnit		NVARCHAR(225),
	@RealCalUnit			NVARCHAR(225),
	@Ratio				    FLOAT
AS
BEGIN
	INSERT INTO Material 
			(MaterialName,MaterialParentID, 
			 EstimateCalUnit,RealCalUnit,Ratio)
	VALUES	(@MaterialName,@MaterialParentID,
			 @EstimateCalUnit,@RealCalUnit,@Ratio)	
END
GO
/****** Object:  Table [dbo].[MenuRole]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuRole](
	[MenuID] [int] NOT NULL,
	[RoleID] [bigint] NOT NULL,
 CONSTRAINT [PK_MenuRole_1] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC,
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Menu_Update]    Script Date: 07/19/2011 19:46:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
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
	SELECT	MenuID, MenuName, Parent, Type, Description
	FROM	Menu
END
GO
/****** Object:  StoredProcedure [dbo].[Subcontractor_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Subcontractor_Update]
	@subcontractorID        bigint,
	@subcontractorName		NVARCHAR(50),
	@subcontractorAddress	NVARCHAR(225),
	@phoneNumber			NVARCHAR(225)
AS
BEGIN
	UPDATE Subcontractor
	SET    SubcontractorName = 	@subcontractorName,
		   SubcontractorAddress = @subcontractorAddress,
		   PhoneNumber = @phoneNumber
    WHERE  SubcontractorID = @subcontractorID		   
END
GO
/****** Object:  StoredProcedure [dbo].[Subcontractor_search]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Subcontractor_search]
		@Name     nvarchar(50)
AS
BEGIN
	SELECT	*
	FROM	Subcontractor
	WHERE  SubcontractorName  LIKE ISNULL(@Name,SubcontractorName)
END
GO
/****** Object:  StoredProcedure [dbo].[Subcontractor_GetByName]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Subcontractor_GetByName]
	@subcontractorName nvarchar(50)
AS
BEGIN
	SELECT	*
	FROM	Subcontractor
	WHERE	SubcontractorName =@subcontractorName
END
GO
/****** Object:  StoredProcedure [dbo].[Subcontractor_GetByID]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Subcontractor_GetByID]
	@subcontractorID BIGINT
AS
BEGIN
	SELECT	*
	FROM	Subcontractor
	WHERE	SubcontractorID =@subcontractorID
END
GO
/****** Object:  StoredProcedure [dbo].[Subcontractor_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Subcontractor_GetAll]
AS
BEGIN
	SELECT	*
	FROM	Subcontractor
END
GO
/****** Object:  StoredProcedure [dbo].[Subcontractor_delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Subcontractor_delete]
	@subcontractorID        bigint
AS
BEGIN
	DELETE FROM Subcontractor
    WHERE  SubcontractorID = @subcontractorID		   
END
GO
/****** Object:  StoredProcedure [dbo].[Subcontractor_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Subcontractor_Create]
	@subcontractorName		NVARCHAR(50),
	@subcontractorAddress	NVARCHAR(225),
	@phoneNumber			NVARCHAR(225)
AS
BEGIN
	INSERT Subcontractor
    (SubcontractorName,SubcontractorAddress,PhoneNumber)
	 VALUES(@subcontractorName,@subcontractorAddress,@phoneNumber)	   
END
SELECT  IDENT_CURRENT('Subcontractor')
GO
/****** Object:  StoredProcedure [dbo].[Role_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Role_Update]
	@roleID			BIGINT,
	@roleName		NVARCHAR(50),
	@description	NVARCHAR(225),
	@rightsValue	BIGINT,
	@isActive		BIT
AS
BEGIN
	UPDATE	[Role]
	SET		RoleName = @roleName,
			Description = @description,
			RightsValue = @rightsValue,
			isActive = @isActive
	WHERE	RoleID = @roleID
END
GO
/****** Object:  StoredProcedure [dbo].[Role_GetWithoutAdmin]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Role_GetWithoutAdmin]
AS
BEGIN
	SELECT	RoleID, RoleName, Description, RightsValue, IsActive
	FROM	Role
	WHERE	RoleName NOT LIKE '%admin%'
END
GO
/****** Object:  StoredProcedure [dbo].[Role_GetByMenuID]    Script Date: 07/19/2011 19:46:56 ******/
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
	SELECT	RoleID, RoleName, Description, RightsValue, IsActive
	FROM	Role
	WHERE	RoleID IN	(
							SELECT	RoleID
							FROM	MenuRole
							WHERE	MenuID = @menuID
						)
END
GO
/****** Object:  StoredProcedure [dbo].[Rights_Update]    Script Date: 07/19/2011 19:46:56 ******/
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
	@isActive		BIT
AS
BEGIN
	UPDATE	[Rights]
	SET		RightName = @rightName,
			Description = @description,
			isActive = @isActive
	WHERE	RightID = @rightID
END
GO
/****** Object:  StoredProcedure [dbo].[Rights_GetByRightValue]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Rights_GetByRightValue] 
	-- Add the parameters for the stored procedure here
	@rightValue BIGINT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SELECT RightID, RightName, Description, Value, isActive, EnumAlias
	FROM Rights
	WHERE (Value & @rightValue) <> 0    	
END
GO
/****** Object:  StoredProcedure [dbo].[Rights_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
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
	SELECT	RightID, RightName, Description, Value, isActive, EnumAlias
	FROM	Rights
END
GO
/****** Object:  StoredProcedure [dbo].[Rights_Delete]    Script Date: 07/19/2011 19:46:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Rights_Create]    Script Date: 07/19/2011 19:46:56 ******/
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
	@isActive		BIT
AS
BEGIN
	INSERT INTO Rights 
			(RightID, RightName, Description, Value, isActive)
	VALUES	(@rightID, @rightName, @description, @value, @isActive)	
END
GO
/****** Object:  StoredProcedure [dbo].[MenuRole_Create]    Script Date: 07/19/2011 19:46:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_Delete]    Script Date: 07/19/2011 19:46:56 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_GetByRoleID]    Script Date: 07/19/2011 19:46:56 ******/
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
	SELECT	MenuID, MenuName, Parent, Type, Description
	FROM	Menu
	WHERE	MenuID IN	(
							SELECT	MenuID
							FROM	MenuRole
							WHERE	RoleID = @roleID
						)
END
GO
/****** Object:  StoredProcedure [dbo].[MaterialWarehouse_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[MaterialWarehouse_Create]
	@WarehouseID	BIGINT,
	@MaterialID		BIGINT,
	@Quantity		FLOAT,
	@AveragePrice	BIGINT,
	@TotalCost		BIGINT
AS
--DECLARE @CreatedDate DATETIME
--SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO MaterialWarehouse 
			(WarehouseID, MaterialID, Quantity, AveragePrice, TotalCost)
	VALUES	(@WarehouseID, @MaterialID, @Quantity, @AveragePrice, @TotalCost)
END
GO
/****** Object:  StoredProcedure [dbo].[Material_GetByWarehouseId]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Material_GetByWarehouseId]
	@WarehouseId	BIGINT
AS
BEGIN
    SELECT	M.*
    FROM	Material M JOIN MaterialWarehouse MW ON M.MaterialID = MW.MaterialID
    WHERE	MW.WarehouseID = @WarehouseId

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_UpdateTotalMachineCost]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
create PROCEDURE [dbo].[Estimate_UpdateTotalMachineCost]
    @ConstructionID      bigint
AS
	DECLARE @totalFualCost	bigint
	DECLARE @totalDamagedCost	bigint
	DECLARE @EstimateID	bigint
BEGIN
	SET @totalFualCost= (SELECT SUM(FualCost) FROM VehicleDairy WHERE ConstructionID = @ConstructionID)
	SET @totalDamagedCost= (SELECT SUM(DamagedCost) FROM VehicleDairy WHERE ConstructionID = @ConstructionID)
	SET @EstimateID = (SELECT EstimateID FROM Estimate WHERE ConstructionID = @ConstructionID)	
	UPDATE  [Estimate]			
	SET     TotalMachineCost= (@totalFualCost + @totalDamagedCost)		
	WHERE	EstimateID = @EstimateID
END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_UpdateForSub]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_UpdateForSub]
	@ConstructionID              bigint,
    @TotalCostEstimate       bigint,
    @TotalCostReal           nvarchar(150)  
AS
BEGIN
    UPDATE   [Estimate]
    
	SET      TotalCostEstimate = @TotalCostEstimate,
			 TotalCostReal = @TotalCostReal		 
     WHERE   ConstructionID = @ConstructionID         
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_Create]	
	@Username		VARCHAR(50),
	@Password	    VARCHAR(100),
	@FullName		NVARCHAR(125),
	@Address		NVARCHAR(225),
	@Email			NVARCHAR(100),
	@Note			NVARCHAR(225),
	@RoleID			BIGINT,
	@RightsValue	BIGINT,
	@CMND			VARCHAR(20),	
	@DOB			VARCHAR(50),
	@IsActive		BIT,
	@PhoneNumber	VARCHAR(15),
	@TotalDebt		BIGINT
AS
BEGIN
	INSERT INTO Employee 
			(Username, Password, FullName, Address, Email, Note, RoleID, RightsValue, CMND, DOB, IsActive, PhoneNumber, TotalDebt)
	VALUES	(@Username, @Password, @FullName, @Address, @Email, @Note, @RoleID, @RightsValue, @CMND, @DOB, @IsActive, @PhoneNumber, @TotalDebt)	
END
GO
/****** Object:  Table [dbo].[EstimateDetail]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstimateDetail](
	[EstimateDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[EstimateID] [bigint] NOT NULL,
	[MaterialID] [bigint] NULL,
	[QuantityEstimate] [float] NULL,
	[UnitCostEstimate] [bigint] NULL,
	[TotalCostEstimate] [bigint] NULL,
	[QuantityReal] [float] NULL,
	[UnitCostReal] [bigint] NULL,
	[TotalCostReal] [bigint] NULL,
	[Note] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_EstimateDetail] PRIMARY KEY CLUSTERED 
(
	[EstimateDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Estimate_UpdateTotalWorkerCost]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_UpdateTotalWorkerCost]
    @ConstructionID      bigint
AS
	DECLARE @totalSalary	bigint
	DECLARE @EstimateID	bigint
BEGIN
	SET @totalSalary = (SELECT SUM(TotalSalary) FROM WorkersSalary WHERE ConstructionID = @ConstructionID)
	SET @EstimateID = (SELECT EstimateID FROM Estimate WHERE ConstructionID = @ConstructionID)	
	UPDATE  [Estimate]			
	SET     TotalWorkerCost=@totalSalary			
	WHERE	EstimateID = @EstimateID
END
GO
/****** Object:  Table [dbo].[FinalAccount]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalAccount](
	[FinalAccountID] [bigint] NOT NULL,
	[FinalAccountName] [nvarchar](max) NULL,
	[ConstructionID] [bigint] NULL,
	[PersonAccount] [nvarchar](50) NULL,
	[DateAccount] [datetime] NULL,
	[DebtID] [bigint] NULL,
	[WarehouseID] [bigint] NULL,
	[TransportationCost] [bigint] NULL,
	[TotalCost] [bigint] NOT NULL,
	[ComparationDebtID] [bigint] NULL,
	[IsPay] [bit] NULL,
	[Note] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_FinalAccount] PRIMARY KEY CLUSTERED 
(
	[FinalAccountID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advance]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advance](
	[AdvanceID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [bigint] NOT NULL,
	[TotalAdvance] [bigint] NULL,
	[Reason] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
 CONSTRAINT [PK_Advance_1] PRIMARY KEY CLUSTERED 
(
	[AdvanceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Construction_Search]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_Search]
	@Name		       NVARCHAR(50),
	@FromDate          DATETIME ,
	@ToDate			   DATETIME,
	@SubcontractorID   bigint,
	@Status			   nvarchar(50),
	@ManagerID		   bigint
AS
BEGIN
	SELECT	s.SubcontractorName,c.*,e.TotalCostEstimate,e.TotalCostReal,m.Username
	FROM	Construction c
	LEFT OUTER JOIN Subcontractor s 
	ON s.SubcontractorID = c.SubcontractorID 
	LEFT OUTER JOIN Estimate e
	ON e.ConstructionID = c.ConstructionID 
	LEFT OUTER JOIN Employee m
	ON c.ManagerID = m.EmployeeID 
	WHERE c.IsDeleted!=1
	AND c.ConstructionName like ISNULL(@Name,c.ConstructionName)
	AND c.ManagerID = ISNULL(@ManagerID,c.ManagerID)
	AND c.SubcontractorID = ISNULL(@SubcontractorID,c.SubcontractorID)
	AND c.Status like ISNULL(@Status,c.Status)
	AND c.CommencementDate>= ISNULL(@FromDate,c.CommencementDate)
	AND c.CommencementDate<= ISNULL(@ToDate,c.CommencementDate)
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetReportByName]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_GetReportByName]
    @constructionName nvarchar(125)
AS
BEGIN
    SELECT   *
    FROM    Construction C LEFT OUTER JOIN Estimate E ON C.ConstructionID = E.ConstructionID
    WHERE   C.ConstructionName LIKE @constructionName
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_GetCompare]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_GetCompare]
	@DebtName	NVARCHAR(150),
	@FromDate	DATETIME,
	@ToDate		DATETIME
AS
BEGIN
	SELECT	CD.*, D.DebtName
	FROM	ComparationDebt CD JOIN Debt D ON CD.DebtID = D.DebtID
	WHERE	D.DebtName LIKE N'%' + @DebtName + '%' AND
			CD.DateCompare BETWEEN @FromDate AND @ToDate
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_DeleteCompare]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_DeleteCompare]
    @Id	BIGINT
AS
BEGIN
    DELETE FROM ComparationDebt
    WHERE ComparationDebtID = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_DeleteAllCompare]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_DeleteAllCompare]
AS
BEGIN
    DELETE FROM ComparationDebt
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_DeleteAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_DeleteAll]
AS
BEGIN
	DELETE FROM ComparationDebt
	
    DELETE FROM Debt
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_Delete]
    @DebtID	BIGINT
   
AS
BEGIN
    DELETE FROM ComparationDebt
    WHERE DebtID = @DebtID
    
    DELETE FROM Debt
    WHERE DebtID = @DebtID   
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_CreateCompare]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_CreateCompare]
	@DebtID					BIGINT,
	@RepresentationDebtName	NVARCHAR(50),
	@DateCompare			DATETIME,
	@FromDate				DATETIME,
	@ToDate					DATETIME,
	@TotalOwe				BIGINT,
	@Note					NVARCHAR(MAX),
	@CreatedBy				NVARCHAR(50)
AS
DECLARE @CreatedDate DATETIME
SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO ComparationDebt 
			(DebtID, RepresentationDebtName, DateCompare, FromDate, ToDate, TotalOwe, Note, CreatedBy, UpdatedBy, CreatedDate, LastUpdated)
	VALUES	(@DebtID, @RepresentationDebtName, @DateCompare, @FromDate,@ToDate, @TotalOwe, @Note, @CreatedBy, @CreatedBy, @CreatedDate, @CreatedDate)
	
	UPDATE  Debt
	SET		TotalOwe -= @TotalOwe
	WHERE	DebtID = @DebtID
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetChildren]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_GetChildren]
	@constructionID BIGINT
AS
BEGIN
	SELECT	s.SubcontractorName,c.*,e.TotalCostEstimate,e.TotalCostReal,m.Username
	FROM	Construction c
	LEFT JOIN Subcontractor s 
	ON c.SubcontractorID = s.SubcontractorID 
	LEFT JOIN Estimate e 
	ON c.ConstructionID = e.ConstructionID
	LEFT OUTER JOIN Employee m
	ON c.ManagerID = m.EmployeeID  
	WHERE  c.ParentID =@constructionID AND  c.IsDeleted!=1 
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetByID]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_GetByID]
	@constructionID BIGINT
AS
BEGIN
	SELECT	s.SubcontractorName,c.*,e.TotalCostEstimate,e.TotalCostReal,m.Username
	FROM	Construction c
	LEFT OUTER JOIN Subcontractor s 
	ON s.SubcontractorID = c.SubcontractorID 
	LEFT OUTER JOIN Estimate e
	ON e.ConstructionID = c.ConstructionID 
	LEFT OUTER JOIN Employee m
	ON c.ManagerID = m.EmployeeID 
	WHERE c.ConstructionID=@constructionID AND  c.IsDeleted!=1
END
GO
/****** Object:  Table [dbo].[EmployerConstruction]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployerConstruction](
	[EmployeeID] [bigint] NOT NULL,
	[ConstructionID] [bigint] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_EmployerConstruction_1] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[ConstructionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[Employer_GetByUsername]    Script Date: 07/19/2011 19:46:56 ******/
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
	SELECT	E.EmployeeID, E.Username,E.Password,E.FullName,
			E.Address,E.Email,E.Note,
			E.RoleID, E.RightsValue,E.CMND,
			E.DOB,E.PhoneNumber, E.IsActive, R.RoleName, E.TotalDebt
	FROM	Employee E JOIN Role R ON E.RoleID = R.RoleID
	WHERE	E.Username = @username
END
GO
/****** Object:  Table [dbo].[EmployeeSalary]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeSalary](
	[EmployeeSalaryID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [bigint] NOT NULL,
	[Month] [nvarchar](50) NULL,
	[Salary] [bigint] NULL,
	[Allowance] [bigint] NULL,
	[PhoneCost] [bigint] NULL,
	[DebtPay] [bigint] NULL,
	[ActualIncome] [bigint] NULL,
	[isPay] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_EmployeeSalary] PRIMARY KEY CLUSTERED 
(
	[EmployeeSalaryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Debt_UpdateCompare]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_UpdateCompare]
	@CompareDebtId			BIGINT,
	@DebtID					BIGINT,
	@RepresentationDebtName	NVARCHAR(50),
	@DateCompare			DATETIME,
	@FromDate				DATETIME,
	@ToDate					DATETIME,
	@TotalOwe				BIGINT,
	@Note					NVARCHAR(MAX),
	@UpdatedBy				NVARCHAR(50)
AS
DECLARE @LastUpdated DATETIME,
		@TotalOweOld BIGINT
SET		@LastUpdated = GETDATE()

SELECT	@TotalOweOld = TotalOwe
FROM	ComparationDebt
WHERE	ComparationDebtID = @CompareDebtId

BEGIN	
	UPDATE	ComparationDebt
	SET		DebtID = @DebtID,
			RepresentationDebtName = @RepresentationDebtName,
			DateCompare = @DateCompare,
			ToDate = @ToDate,
			FromDate = @FromDate,
			TotalOwe = @TotalOwe,
			Note = @Note,
			UpdatedBy = @UpdatedBy,
			LastUpdated = @LastUpdated
	WHERE	ComparationDebtID = @CompareDebtId
	
	UPDATE	Debt
	SET		TotalOwe = TotalOwe + @TotalOweOld - @TotalOwe
	WHERE	DebtID = @DebtID
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetEmployee]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_GetEmployee]
	@username	NVARCHAR(50),
	@fullname	NVARCHAR(50),	
	@roleName	NVARCHAR(50),
	@status		INT
AS
BEGIN
	IF @status = -1
	BEGIN
		SELECT	E.EmployeeID, E.Username,E.Password,E.FullName,
				E.Address,E.Email,E.Note,
				E.RoleID, E.RightsValue,E.CMND,
				E.DOB,E.PhoneNumber, E.IsActive, E.TotalDebt, R.RoleName
		FROM	Employee E JOIN Role R ON E.RoleID = R.RoleID	
		WHERE	R.RoleName LIKE N'%' + @roleName + '%' AND
				R.RoleName NOT LIKE N'%admin%' AND
				E.Username LIKE N'%' + @username + '%' AND
				E.FullName LIKE N'%' + @fullname + '%'
	END
	
	IF @status <> -1
	BEGIN
		SELECT	E.EmployeeID, E.Username,E.Password,E.FullName,
				E.Address,E.Email,E.Note,
				E.RoleID, E.RightsValue,E.CMND,
				E.DOB,E.PhoneNumber, E.IsActive, E.TotalDebt, R.RoleName
		FROM	Employee E JOIN Role R ON E.RoleID = R.RoleID	
		WHERE	R.RoleName LIKE N'%' + @roleName + '%' AND
				R.RoleName NOT LIKE N'%admin%' AND
				E.Username LIKE N'%' + @username + '%' AND
				E.FullName LIKE N'%' + @fullname + '%' AND
				E.IsActive = CONVERT(BIT, @status)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetAllWithoutAdmin]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_GetAllWithoutAdmin]
AS
BEGIN
	SELECT	E.EmployeeID, E.Username,E.Password,E.FullName,
			E.Address,E.Email,E.Note,
			E.RoleID, E.RightsValue,E.CMND,
			E.DOB,E.PhoneNumber, E.IsActive, E.TotalDebt, R.RoleName
	FROM	Employee E JOIN Role R ON E.RoleID = R.RoleID	
	WHERE	R.RoleName NOT LIKE '%admin%'
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_GetAll]
AS
BEGIN
	SELECT	E.EmployeeID, E.Username,E.Password,E.FullName,
			E.Address,E.Email,E.Note,
			E.RoleID, E.RightsValue,E.CMND,
			E.DOB,E.PhoneNumber, E.IsActive, E.TotalDebt, R.RoleName
	FROM	Employee E JOIN Role R ON E.RoleID = R.RoleID	
END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_Update]
    @estimateID        bigint,
    @estimateName        nvarchar(150),
    @updatedBy            nvarchar(150)
   
AS
	DECLARE @updatedDate 	DATETIME
    SET     @updatedDate = GETDATE()
BEGIN
    UPDATE   [Estimate]
    
	SET      EstimateName = @estimateName,
			 UpdatedBy = @updatedBy,
			 UpdatedDate = @updatedDate			 
     WHERE   EstimateID = @estimateID         
END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_search]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_search]
	@Name   nvarchar(150),
	@ConstructionID bigint
AS
BEGIN
    SELECT    c.ConstructionName,e.*
    FROM    Estimate e
    INNER JOIN Construction c
    ON      e.ConstructionID = c.ConstructionID
    WHERE  e.type=0 AND e.IsDeleted!=1
    AND e.ConstructionID =ISNULL(@ConstructionID,e.ConstructionID)
    AND e.EstimateName like ISNULL(@Name,e.EstimateName)

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_GetEstimateIDByConstructionID]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_GetEstimateIDByConstructionID]
	@ConstructionID	BIGINT
AS
BEGIN
    SELECT  E.EstimateID
    FROM    Estimate E JOIN Construction C ON E.ConstructionID = C.ConstructionID
END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_GetByConstruction]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_GetByConstruction]
		@ConstructionID bigint
AS
BEGIN
    SELECT  c.ConstructionName,e.EstimateID,e.ConstructionID,
            e.EstimateName,e.TotalCostEstimate,e.TotalCostReal,
            e.CreatedDate,e.CreatedBy,e.UpdatedDate,e.UpdatedBy
    FROM    Estimate e
    INNER JOIN Construction c
    ON      e.ConstructionID  = c.ConstructionID and e.ConstructionID=@ConstructionID

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_GetAll]
AS
BEGIN
    SELECT    c.ConstructionName,e.*
    FROM    Estimate e
    INNER JOIN Construction c
    ON      e.ConstructionID = c.ConstructionID
    WHERE   e.IsDeleted!=1 ;

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_Delete]
    @estimateID            bigint
   
AS
BEGIN
    DELETE FROM Estimate
    WHERE EstimateID = @estimateID
END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_Create]
    @constructionID       bigint,
    @type				  int,
    @estimateName         nvarchar(150),
    @totalCostEstimate    bigint,
    @totalCostReal        bigint,
    @createdBy            nvarchar(150)
   
AS
	DECLARE @createdDate 	DATETIME
    SET     @createdDate = GETDATE()
BEGIN
    INSERT INTO Estimate
            (ConstructionID,EstimateName,
             TotalCostEstimate,TotalCostReal,Type,CreatedDate,
             CreatedBy)
    VALUES    (@constructionID,@estimateName,
            @totalCostEstimate,@totalCostReal,@type,@createdDate,
            @createdBy)   
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_Update]
	@EmployeeID		BIGINT,
	@Username		VARCHAR(50),
	@Password	    VARCHAR(100),
	@FullName		NVARCHAR(125),
	@Address		NVARCHAR(225),
	@Email			NVARCHAR(100),
	@Note			NVARCHAR(225),
	@RoleID			BIGINT,
	@RightsValue	BIGINT,
	@CMND			VARCHAR(20),	
	@DOB			VARCHAR(50),
	@IsActive		BIT,
	@PhoneNumber	VARCHAR(15),
	@TotalDebt		BIGINT
AS
BEGIN
	UPDATE	[Employee]
	SET		Username = @Username,
			Password = @Password,
			FullName = @FullName,
			Address = @Address,
			Email = @Email,
			Note = @Note,
			RoleID = @RoleID,
			RightsValue = @RightsValue,
			CMND = @CMND,
			DOB = @DOB,
			IsActive = @IsActive,
			PhoneNumber = @PhoneNumber,
			TotalDebt = @TotalDebt
	WHERE	EmployeeID = @EmployeeID
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_ResetPass]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_ResetPass]
	@EmployeeID		BIGINT,
	@Password	    VARCHAR(100)
AS
BEGIN
	UPDATE	[Employee]
	SET		[Password] = @Password
	WHERE	EmployeeID = @EmployeeID
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_UpdateRight]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_UpdateRight]
	@EmployeeID		BIGINT,
	@RoleID			BIGINT,
	@RightsValue	BIGINT
AS
BEGIN
	UPDATE	[Employee]
	SET		RoleID = @RoleID,
			RightsValue = @RightsValue
	WHERE	EmployeeID = @EmployeeID
END
GO
/****** Object:  StoredProcedure [dbo].[Vehicle_search]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Vehicle_search]
		@Name			 nvarchar(50),
		@Number			nvarchar(50),
		@ConstructionID  bigint
		
AS	
   DECLARE @SQL nvarchar(500)
BEGIN
	SELECT	c.ConstructionName,e.Username,w.WarehouseName,v.*
	FROM	Vehicle v
	LEFT OUTER JOIN Employee e
	ON v.ManagerID = e.EmployeeID
	LEFT OUTER JOIN Construction c 
	ON v.ConstructionID = c.ConstructionID
	LEFT OUTER JOIN Warehouse w 
	ON v.WarehouseID = w.WarehouseID
	WHERE v.Name like ISNULL(@Name,v.Name) 
	and v.Number like ISNULL(@Number,v.Number) 
	and v.ConstructionID = ISNULL(@ConstructionID,v.ConstructionID)
END
GO
/****** Object:  StoredProcedure [dbo].[Vehicle_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Vehicle_GetAll]
AS
BEGIN
	SELECT	c.ConstructionName,e.Username,w.WarehouseName,v.*
	FROM	Vehicle v
	LEFT OUTER JOIN Employee e
	ON v.ManagerID = e.EmployeeID
	LEFT OUTER JOIN Construction c 
	ON v.ConstructionID = c.ConstructionID
	LEFT OUTER JOIN Warehouse w 
	ON v.WarehouseID = w.WarehouseID;
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_CreateItem]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_CreateItem]
	@WarehouseID	BIGINT,
	@MaterialID		BIGINT,
	@Quantity		FLOAT,
	@TotalCost		BIGINT,
	@AveragePrice	BIGINT
	
AS
BEGIN
	INSERT INTO MaterialWarehouse
			(WarehouseID, MaterialID, Quantity, TotalCost, AveragePrice)
	VALUES	(@WarehouseID, @MaterialID, @Quantity, @TotalCost, @AveragePrice)
END
GO
/****** Object:  StoredProcedure [dbo].[VehicleDairy_search]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[VehicleDairy_search]
		@VehicleID bigint,
		@ConstructionID bigint,
		@DriverID bigint,
		@FromDate datetime,
		@ToDate	  datetime
AS
BEGIN
	SELECT	c.Name,e.Username,d.ConstructionName ,v.*
	FROM	VehicleDairy v
	LEFT OUTER JOIN Employee e
	ON v.DriverID = e.EmployeeID
	LEFT OUTER JOIN Vehicle c 
	ON v.VehicleID = c.VehicleID
	LEFT OUTER JOIN Construction d 
	ON v.ConstructionID = d.ConstructionID
	WHERE v.VehicleID  = ISNULL(@VehicleID,v.VehicleID)
	AND v.DriverID = ISNULL(@DriverID,v.DriverID)
	AND v.ConstructionID = ISNULL(@ConstructionID,v.ConstructionID)
	AND v.Date<= @ToDate AND v.Date >=@FromDate
END
GO
/****** Object:  StoredProcedure [dbo].[VehicleDairy_GetAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[VehicleDairy_GetAll]
AS
BEGIN
	SELECT	c.Name,e.Username,v.*
	FROM	VehicleDairy v
	LEFT OUTER JOIN Employee e
	ON v.DriverID = e.EmployeeID
	LEFT OUTER JOIN Vehicle c 
	ON v.VehicleID = c.VehicleID
END
GO
/****** Object:  StoredProcedure [dbo].[Worker_Update]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Worker_Update]
    @WorkerID		        bigint,
	@FullName				nvarchar(50),
	@ManDate				float,
	@Salary					bigint,
	@TotalSalary			bigint,
	@Position				nvarchar(125),
	@updatedBy				nvarchar(50)
AS
    DECLARE @LastUpdated	DATETIME
    SET     @LastUpdated = GETDATE()
BEGIN
	UPDATE  [Worker]
			
	SET    
			FullName = @FullName,
			ManDate = @ManDate,
			Salary = @Salary,
			TotalSalary =@TotalSalary,
			Position = @Position,
			LastUpdated = @LastUpdated,
			UpdatedBy=@updatedBy
			
			
	WHERE	WorkerID = @WorkerID
END
GO
/****** Object:  StoredProcedure [dbo].[Worker_GetAll]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Worker_GetAll]
	@workersSalaryID	bigint
AS
BEGIN
	SELECT	*
	FROM Worker
	WHERE WorkersSalaryID = @workersSalaryID
END
GO
/****** Object:  StoredProcedure [dbo].[Worker_Delete]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Worker_Delete]
    @WorkerID            bigint
   
AS
BEGIN
    DELETE FROM Worker
    WHERE WorkerID = @WorkerID
END
GO
/****** Object:  StoredProcedure [dbo].[Worker_Create]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Worker_Create]
	@workersSalaryID		NVARCHAR(225),
	@fullName				nvarchar(50),
	@ManDate				float,
	@salary					bigint,
	@totalSalary			bigint,
	@position				nvarchar(125),
	@createdBy				nvarchar(50)

AS
	 DECLARE @createDate	DATETIME
     SET     @createDate = GETDATE()
BEGIN
	INSERT INTO Worker 
			(WorkersSalaryID,FullName,ManDate,Salary,
			TotalSalary,Position,CreatedDate,CreatedBy)
	VALUES	(@workersSalaryID,@fullName,@ManDate,
			@salary,@totalSalary,@position,@createDate,@createdBy)	
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_UpdateItem]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_UpdateItem]
	@WarehouseID	BIGINT,
	@MaterialID		BIGINT,
	@Quantity		FLOAT,
	@TotalCost		BIGINT,
	@AveragePrice	BIGINT
	
AS
BEGIN
	UPDATE	MaterialWarehouse
	SET		Quantity = @Quantity,
			TotalCost = @TotalCost,
			AveragePrice = @AveragePrice
	WHERE	WarehouseID = @WarehouseID AND
			MaterialID = @MaterialID
END
GO
/****** Object:  StoredProcedure [dbo].[WorkersSalary_Delete]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[WorkersSalary_Delete]
	@workersSalaryID        bigint
AS
BEGIN
	DELETE  [Worker]
	WHERE	WorkersSalaryID = @workersSalaryID
	DELETE  [WorkersSalary]
	WHERE	 WorkersSalaryID =@workersSalaryID	
	
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_Material]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_Material]
	@WarehouseID	BIGINT,
	@MaterialID		BIGINT
AS
BEGIN
	SELECT	*
	FROM	MaterialWarehouse
	WHERE	WarehouseID = @WarehouseID AND
			MaterialID = @MaterialID
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_GetWarehouseMaterial]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_GetWarehouseMaterial]
	@WarehouseName	NVARCHAR(50),
	@MaterialName	NVARCHAR(50)
AS
BEGIN
	SELECT	M.*, W.WarehouseName, Mat.MaterialName, Mat.RealCalUnit
	FROM	MaterialWarehouse M JOIN Warehouse W ON M.WarehouseID = W.WarehouseID, Material Mat
	WHERE	M.MaterialID = Mat.MaterialID AND
			W.WarehouseName LIKE N'%' + @WarehouseName + '%' AND
			Mat.MaterialName LIKE N'%' + @MaterialName + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_DeleteAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_DeleteAll]
AS
BEGIN
    DELETE FROM MaterialWarehouse
    
    DELETE FROM Warehouse
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_Delete]
    @WarehouseID	BIGINT
   
AS
BEGIN
    DELETE FROM MaterialWarehouse
    WHERE WarehouseID = @WarehouseID
    
    DELETE FROM Warehouse
    WHERE WarehouseID = @WarehouseID   
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_CreateStockOutDetail]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Warehouse_CreateStockOutDetail]
	@WarehouseFromID	BIGINT,
	@WarehouseToID		BIGINT,
	@StockOutID			BIGINT,
	@MaterialID			BIGINT,
	@Quantity			FLOAT,
	@Note				NVARCHAR(MAX)
AS
BEGIN
	DECLARE @AvgCostFromHW	BIGINT,
			@AvgCostToHW	BIGINT,
			@ConstructoinId BIGINT,
			@MatId BIGINT,
			@TotalCost BIGINT
			
	SELECT	@ConstructoinId = ConstructionID
	FROM	Warehouse
	WHERE	WarehouseID = @WarehouseToID
	
	SELECT	@MatId = MaterialID, @AvgCostToHW = AveragePrice
	FROM	MaterialWarehouse
	WHERE	WarehouseID = @WarehouseToID
	
	SELECT	@AvgCostFromHW = AveragePrice
	FROM	MaterialWarehouse
	WHERE	WarehouseID = @WarehouseFromID
	
	SET	@TotalCost = @Quantity * @AvgCostFromHW

	INSERT INTO StockOutDetail
			(StockOutID, MaterialID, Quantity, Note)
	VALUES	(@StockOutID, @MaterialID, @Quantity, @Note)
	
	IF	@WarehouseToID = 0
	BEGIN		
		UPDATE	MaterialWarehouse
		SET		TotalCost -= @TotalCost,
				Quantity -= @Quantity
		WHERE	WarehouseID = @WarehouseFromID AND
				MaterialID = @MaterialID
	END
	
	IF @WarehouseToID <> 0
	BEGIN
		UPDATE	MaterialWarehouse
		SET		TotalCost -= @TotalCost,
				Quantity -= @Quantity
		WHERE	WarehouseID = @WarehouseFromID AND
				MaterialID = @MaterialID					
				
		IF @ConstructoinId <> 0
		BEGIN
			UPDATE	Estimate
			SET		TotalCostReal += @TotalCost,
					TotalMaterialCost += @TotalCost
			WHERE	ConstructionID = @ConstructoinId
		END
		
		IF @MatId <> 0
		BEGIN
			UPDATE	MaterialWarehouse
			SET		Quantity += @Quantity,
					TotalCost += @TotalCost,
					AveragePrice = CONVERT(FLOAT, (@AvgCostFromHW + @AvgCostToHW)/2)
		END
		
		IF	@MatId = 0
		BEGIN
			INSERT INTO MaterialWarehouse
					(WarehouseID, MaterialID, Quantity, TotalCost, AveragePrice)
			VALUES	(@WarehouseToID, @MaterialID, @Quantity, @TotalCost, @AvgCostFromHW)
		END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[WorkerSalary_UpdateTotalSalary]    Script Date: 07/19/2011 19:46:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[WorkerSalary_UpdateTotalSalary]
    @workersSalaryID        bigint,
    @ConstructionID			bigint
AS
	DECLARE @totalSalary	bigint
BEGIN
	SET @totalSalary = (SELECT SUM(TotalSalary) FROM Worker WHERE WorkersSalaryID = @workersSalaryID)
	UPDATE  [WorkersSalary]			
	SET    TotalSalary =@totalSalary			
	WHERE	WorkersSalaryID = @workersSalaryID
END
EXEC Estimate_UpdateTotalWorkerCost @ConstructionID
GO
/****** Object:  StoredProcedure [dbo].[VehicleDairy_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[VehicleDairy_Create]
	@VehicleID				bigint,
	@ConstructionID			bigint,
	@DriverID				bigint,
	@RoadMap				NVARCHAR(225),
	@FualCost				bigint,
	@DamagedCost			bigint,
	@Date					DateTime,
	@isPaid					bit

AS
BEGIN
	INSERT INTO VehicleDairy
	(VehicleID,ConstructionID,RoadMap,DriverID,FualCost,DamagedCost,Date,isPaid)
	VALUES	
	(@VehicleID,@ConstructionID,@RoadMap,@DriverID,@FualCost,@DamagedCost,@Date,@isPaid)
END
EXEC Estimate_UpdateTotalMachineCost @constructionID
GO
/****** Object:  StoredProcedure [dbo].[VehicleDairy_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[VehicleDairy_Update]
	@VehicleDairyID			bigint,
	@ConstructionID			bigint,
   	@VehicleID				bigint,
	@DriverID				bigint,
	@RoadMap				NVARCHAR(225),
	@FualCost				bigint,
	@DamagedCost			bigint,
	@Date					DateTime,
	@isPaid					bit

AS
BEGIN
	UPDATE  [VehicleDairy]
			
	SET    	VehicleID = @VehicleID,
	        ConstructionID = @ConstructionID,
			DriverID = @DriverID,
			RoadMap= @RoadMap,
			FualCost =@FualCost,
			DamagedCost = @DamagedCost,
			Date=@Date,
			isPaid =@isPaid
	WHERE	VehicleDairyID = @VehicleDairyID
END
EXEC Estimate_UpdateTotalMachineCost @constructionID
GO
/****** Object:  StoredProcedure [dbo].[Employee_UpdateAdvance]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_UpdateAdvance]	
	@AdvanceId		BIGINT,
	@EmployeeID		BIGINT,
	@TotalAdvance	BIGINT,
	@Reason			NVARCHAR(MAX),
	@Note			NVARCHAR(MAX)
AS
BEGIN
	DECLARE @date	DATETIME
	SET		@date = GETDATE()
	
	UPDATE	Advance
	SET		EmployeeID = @EmployeeID,
			TotalAdvance = @TotalAdvance,
			Reason = @Reason,
			Note = @Note,
			LastUpdate = @date
	WHERE	AdvanceID = @AdvanceId
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetSalary]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TIENDH
-- Create date: 06/06/2011
-- Description:	abc
-- =============================================
CREATE PROCEDURE [dbo].[Employee_GetSalary] 
	@name		NVARCHAR(50),
	@from		VARCHAR(6),
	@to			VARCHAR(6)	
AS
BEGIN
	SELECT	S.*, E.Username, E.FullName
	FROM	EmployeeSalary S JOIN Employee E ON S.EmployeeID = E.EmployeeID
	WHERE	S.Month BETWEEN @from AND @to AND
			E.FullName LIKE N'%' + @name + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetAdvance]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TIENDH
-- Create date: 06/06/2011
-- Description:	abc
-- =============================================
CREATE PROCEDURE [dbo].[Employee_GetAdvance] 
	@Name		NVARCHAR(150),
	@FromDate	DATETIME,
	@ToDate		DATETIME
AS
BEGIN
	SELECT	A.*, E.Username, E.FullName
	FROM	Advance A JOIN Employee E ON A.EmployeeID = E.EmployeeID
	WHERE	E.FullName LIKE N'%' + @Name + '%' AND
			A.LastUpdate BETWEEN @FromDate AND @ToDate
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_DeleteSalary]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_DeleteSalary]
    @SalaryId	BIGINT
AS
BEGIN
    DELETE FROM EmployeeSalary
    WHERE EmployeeSalaryID = @SalaryId
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_DeleteEmp]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_DeleteEmp]
    @Username	NVARCHAR(50)
AS
BEGIN
DECLARE @EmployeeID	BIGINT,
		@VehicleDailyID BIGINT		

SELECT	@EmployeeID = EmployeeID
FROM	Employee
WHERE	Username = @Username

	DELETE FROM Advance
	WHERE EmployeeID = @EmployeeID
	
	DELETE FROM EmployeeSalary
	WHERE EmployeeID = @EmployeeID

    DELETE FROM Employee
    WHERE Username = @Username
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_DeleteAllSalary]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_DeleteAllSalary]
AS
BEGIN
    DELETE FROM EmployeeSalary
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_DeleteAllEmp]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_DeleteAllEmp]
AS
BEGIN
	DELETE FROM Advance
	
	DELETE FROM EmployeeSalary
	
	DELETE FROM EmployerConstruction
	
    DELETE FROM Employee
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_DeleteAllAdvance]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_DeleteAllAdvance]
AS
BEGIN
    DELETE FROM Advance
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_DeleteAdvance]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_DeleteAdvance]
    @AdvanceId	BIGINT
AS
BEGIN
    DELETE FROM Advance
    WHERE AdvanceID = @AdvanceId
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_CreateSalary]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_CreateSalary]	
	@EmployeeID		BIGINT,
	@Month			VARCHAR(6),
	@Salary			BIGINT,
	@Allowance		BIGINT,
	@PhoneCost		BIGINT,
	@DebtPay		BIGINT,
	@ActualIncome	BIGINT,
	@isPay			BIT,
	@Note			NVARCHAR(MAX)
AS
BEGIN
	DECLARE @date	DATETIME
	SET		@date = GETDATE()
	INSERT INTO EmployeeSalary
			(EmployeeID, Month, Salary, Allowance, PhoneCost, DebtPay, ActualIncome, isPay, Note, CreatedDate, LastUpdate)
	VALUES	(@EmployeeID, @Month, @Salary, @Allowance, @PhoneCost, @DebtPay, @ActualIncome, @isPay, @Note, @date, @date)	
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_CreateAdvance]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_CreateAdvance]	
	@EmployeeID		BIGINT,
	@TotalAdvance	BIGINT,
	@Reason			NVARCHAR(MAX),
	@Note			NVARCHAR(MAX)
AS
BEGIN
	DECLARE @date	DATETIME
	SET		@date = GETDATE()
	INSERT INTO Advance
			(EmployeeID, TotalAdvance, Reason, Note, CreatedDate, LastUpdate)
	VALUES	(@EmployeeID, @TotalAdvance, @Reason, @Note, @date, @date)	
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_UpdateSalary]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Employee_UpdateSalary]	
	@SalaryID		BIGINT,
	@EmployeeID		BIGINT,
	@Month			VARCHAR(6),
	@Salary			BIGINT,
	@Allowance		BIGINT,
	@PhoneCost		BIGINT,
	@DebtPay		BIGINT,
	@ActualIncome	BIGINT,
	@isPay			BIT,
	@Note			NVARCHAR(MAX)
AS
BEGIN
	DECLARE @date	DATETIME
	SET		@date = GETDATE()
	
	UPDATE	EmployeeSalary
	SET		EmployeeID = @EmployeeID,
			[Month] = @Month,
			Salary = @Salary,
			Allowance = @Allowance,
			PhoneCost = @PhoneCost,
			DebtPay = @DebtPay,
			ActualIncome = @ActualIncome,
			isPay = isPay,
			Note = @Note,
			LastUpdate = @date
	WHERE	EmployeeSalaryID = @SalaryID
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Construction_Delete]
	@constructionID			BIGINT
AS
BEGIN
	
	DELETE FROM [EstimateDetail]
	WHERE EstimateID IN 
    (SELECT EstimateID FROM Estimate WHERE ConstructionID IN
    (SELECT ConstructionID FROM Construction WHERE ParentID=@constructionID))

	DELETE FROM  [Estimate]
	WHERE	ConstructionID IN 
	(SELECT ConstructionID FROM Construction WHERE ParentID =@constructionID)
	
	DELETE FROM   [Construction]
	WHERE	ParentID =@constructionID
	
	DELETE FROM  [EstimateDetail]
	WHERE	EstimateID = (SELECT EstimateID FROM Estimate WHERE ConstructionID=@constructionID)
	
	
	DELETE FROM  [Estimate]
	WHERE	ConstructionID =@constructionID
	
	DELETE FROM   [Construction]
	WHERE	ConstructionID =@constructionID
	
	
	
	
	
	
END
GO
/****** Object:  StoredProcedure [dbo].[EstimateDetal_Check]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[EstimateDetal_Check]
		@MaterialID bigint,
		@EstimateID bigint
AS
BEGIN
    SELECT    *
    FROM   EstimateDetail
    WHERE MaterialID = @MaterialID AND EstimateID = @EstimateID

END
GO
/****** Object:  StoredProcedure [dbo].[EstimateDetail_update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[EstimateDetail_update]
    @estimateDetailID      bigint,
    @materialID            bigint,
    @quantityEstimate	   float,
    @unitCostEstimate      decimal(18, 0),
    @totalCostEstimate     decimal(18, 0),
    @name				   nvarchar(50)	
   
AS
BEGIN
    UPDATE  EstimateDetail
		SET     
			  QuantityEstimate= @quantityEstimate,
			  MaterialID = @materialID,
              UnitCostEstimate= @unitCostEstimate,
              TotalCostEstimate=@totalCostEstimate,
              Name =@name             
        WHERE EstimateDetailID= @estimateDetailID
END
GO
/****** Object:  StoredProcedure [dbo].[EstimateDetail_search]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[EstimateDetail_search]
    @estimateID BIGINT,
    @materialID BIGINT
AS
BEGIN
    SELECT  c.MaterialName,e.*
    FROM    EstimateDetail e
    LEFT JOIN Material c
    ON    c.MaterialID=e.MaterialID 
    WHERE e.EstimateID =@estimateID
    AND ( e.MaterialID = ISNULL(@materialID,e.MaterialID) OR e.MaterialID is NULL)
END
GO
/****** Object:  StoredProcedure [dbo].[EstimateDetail_GetByEstimateId]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[EstimateDetail_GetByEstimateId]
    @estimateID BIGINT
AS
BEGIN
    SELECT  c.MaterialName,e.EstimateDetailID,e.EstimateID,e.MaterialID,e.QuantityEstimate,
            e.UnitCostEstimate,e.TotalCostEstimate,e.QuantityReal,e.UnitCostReal,
            e.TotalCostReal,e.Status,e.Note
    FROM    EstimateDetail e
    INNER JOIN Material c
    ON    c.MaterialID=e.MaterialID AND e.EstimateID =@estimateID
END
GO
/****** Object:  StoredProcedure [dbo].[EstimateDetail_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[EstimateDetail_Delete]
    @estimateDetailID            bigint
   
AS
BEGIN
    DELETE FROM EstimateDetail
    WHERE EstimateDetailID = @estimateDetailID
END
GO
/****** Object:  StoredProcedure [dbo].[EstimateDetail_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[EstimateDetail_Create]
    @estimateID            bigint,
    @materialID            bigint,
    @quantityEstimate	   float,
    @unitCostEstimate      decimal(18, 0),
    @totalCostEstimate     decimal(18, 0),
    @name				   nvarchar(50)	
   
AS				
BEGIN
    INSERT INTO EstimateDetail
            (EstimateID,MaterialID,QuantityEstimate,
             UnitCostEstimate,TotalCostEstimate,Name)
    VALUES    (@estimateID,@materialID,@quantityEstimate,
            @unitCostEstimate,@totalCostEstimate,@name)   
END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_UpdateTotalRealCost]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_UpdateTotalRealCost]
    @estimateID		BIGINT
AS
BEGIN
	DECLARE @totalRealCost BIGINT
	SELECT	@totalRealCost = SUM(TotalCostReal)
	FROM	EstimateDetail
	WHERE	EstimateID = @estimateID
	
    UPDATE  [Estimate]
    SET      TotalCostEstimate = @totalRealCost
    WHERE    EstimateID = @estimateID
END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_Create]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_Create]
	@FinalAccountID		BIGINT,
	@FinalAccountName	NVARCHAR(MAX),
	@ConstructionID		BIGINT,
	@PersonAccount		NVARCHAR(50),
	@DateAccount		DATETIME,
	@DebtID				BIGINT,	
	@TransportationCost	BIGINT,
	@TotalCost			BIGINT,
	@IsPay				BIT,
	@Note				NVARCHAR(MAX),
	@CreatedBy			NVARCHAR(50)
AS
DECLARE @CreatedDate DATETIME
SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO FinalAccount 
			(FinalAccountID, FinalAccountName, ConstructionID, PersonAccount, DateAccount, DebtID, TransportationCost, TotalCost, IsPay, Note, CreatedDate, LastUpdate, CreatedBy, UpdatedBy)
	VALUES	(@FinalAccountID, @FinalAccountName, @ConstructionID, @PersonAccount, @DateAccount, @DebtID, @TransportationCost, @TotalCost, @IsPay, @Note, @CreatedDate, @CreatedDate, @CreatedBy, @CreatedBy)
	
	IF @IsPay = 0
	BEGIN
		UPDATE  Debt
		SET		TotalOwe += @TotalCost
		WHERE	DebtID = @DebtID
	END
	
	IF @IsPay = 1
	BEGIN
		UPDATE	Estimate
		SET		TotalCostReal += @TotalCost
		WHERE	ConstructionID = @ConstructionID
	END

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_UpdateEstimateDetailAccount]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_UpdateEstimateDetailAccount]
    @estimateID		    bigint,
    @MaterialID	        bigint,
    @QuantityReal		bigint,
    @UnitCostReal		bigint,
    @TotalCostReal		bigint
   
AS
BEGIN
    UPDATE  EstimateDetail
	SET		QuantityReal += @QuantityReal,
			UnitCostReal += @UnitCostReal,
			TotalCostReal += @TotalCostReal
    WHERE	EstimateID = @estimateID AND
			MaterialID = @MaterialID
END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_UpdateTotalCost]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Estimate_UpdateTotalCost]
    @estimateID            BIGINT
AS
    DECLARE @totalEstimateCost BIGINT
BEGIN
	SET @totalEstimateCost = (SELECT SUM(TotalCostEstimate) FROM EstimateDetail WHERE EstimateID = @estimateID)
    IF @totalEstimateCost is NULL 
    BEGIN
		SET @totalEstimateCost =0
    END
    
    UPDATE  [Estimate]
    SET      TotalCostEstimate= @totalEstimateCost
    WHERE    EstimateID =@estimateID
END
GO
/****** Object:  Table [dbo].[FinalAccountDetail]    Script Date: 07/19/2011 19:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalAccountDetail](
	[FinalAccountDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[FinalAccountID] [bigint] NOT NULL,
	[MaterialID] [bigint] NOT NULL,
	[Quantity] [float] NOT NULL,
	[UnitCost] [bigint] NOT NULL,
	[TotalCost] [bigint] NOT NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_FinalAccountDetail] PRIMARY KEY CLUSTERED 
(
	[FinalAccountDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_GetFinalAccount]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_GetFinalAccount]
	@Id			BIGINT,
	@Name		NVARCHAR(150),
	@ConsName	NVARCHAR(150),
	@DebtName	NVARCHAR(150),
	@FromDate	DATETIME,
	@ToDate		DATETIME
AS
BEGIN
IF	@Id = 0
BEGIN
	SELECT  FA.*, C.ConstructionName, D.DebtName
    FROM    FinalAccount FA LEFT OUTER JOIN Construction C ON FA.ConstructionID = C.ConstructionID, Debt D
    WHERE	FA.DebtID = D.DebtID AND
			FA.FinalAccountName LIKE N'%' + @Name + '%' AND
			(C.ConstructionName LIKE N'%' + @ConsName + '%' OR C.ConstructionName IS NULL) AND
			D.DebtName LIKE N'%' + @DebtName + '%' AND
			FA.DateAccount BETWEEN @FromDate AND @ToDate
END

IF @Id <> 0
BEGIN
	SELECT  FA.*, C.ConstructionName, D.DebtName
    FROM    FinalAccount FA LEFT OUTER JOIN Construction C ON FA.ConstructionID = C.ConstructionID, Debt D
    WHERE	FA.DebtID = D.DebtID AND
			FA.FinalAccountID = @Id AND
			FA.FinalAccountName LIKE N'%' + @Name + '%' AND
			(C.ConstructionName LIKE N'%' + @ConsName + '%' OR C.ConstructionName IS NULL) AND
			D.DebtName LIKE N'%' + @DebtName + '%' AND
			FA.DateAccount BETWEEN @FromDate AND @ToDate
END
END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_Update]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_Update]
	@FinalAccountID		BIGINT,
	@FinalAccountName	NVARCHAR(MAX),
	@ConstructionID		BIGINT,
	@PersonAccount		NVARCHAR(50),
	@DateAccount		DATETIME,
	@DebtID				BIGINT,	
	@TransportationCost	BIGINT,
	@TotalCost			BIGINT,
	@IsPay				BIT,
	@Note				NVARCHAR(MAX),
	@CreatedBy			NVARCHAR(50)
AS
DECLARE @LastUpdated	DATETIME,
		@TotalOldCost	BIGINT
SET		@LastUpdated = GETDATE()

SELECT  @TotalOldCost = TotalCost
FROM	FinalAccount
WHERE	FinalAccountID = @FinalAccountID

BEGIN
	UPDATE	FinalAccount 
	SET		FinalAccountName = @FinalAccountName,
			ConstructionID = @ConstructionID,
			PersonAccount  = @PersonAccount,
			DateAccount = @DateAccount, 
			DebtID = @DebtID, 
			TransportationCost = @TransportationCost, 
			TotalCost = @TotalCost, 
			IsPay = @IsPay, 
			Note = @Note, 
			LastUpdate = @LastUpdated, 
			UpdatedBy = @CreatedBy	
	WHERE	FinalAccountID = @FinalAccountID			
	
	IF @IsPay = 0
	BEGIN
		UPDATE  Debt
		SET		TotalOwe = TotalOwe - @TotalOldCost + @TotalCost
		WHERE	DebtID = @DebtID
	END
	
	IF @IsPay = 1
	BEGIN
		UPDATE	Estimate
		SET		TotalCostReal = TotalCostReal - @TotalOldCost + @TotalCost
		WHERE	ConstructionID = @ConstructionID
	END

END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_GetFinalAccountItem]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_GetFinalAccountItem]
	@accId			BIGINT,
	@materialId		BIGINT
AS
BEGIN
	SELECT	FinalAccountDetailID
	FROM	FinalAccountDetail
	WHERE	FinalAccountID = @accId AND
			MaterialID = @materialId
END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_GetFinalAccountDetial]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_GetFinalAccountDetial]
	@FinalAccountID BIGINT
AS
BEGIN
	SELECT	FAD.*, M.RealCalUnit, M.MaterialName
	FROM	FinalAccountDetail FAD JOIN Material M ON FAD.MaterialID = M.MaterialID
	WHERE	FinalAccountID = @FinalAccountID
END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_DeleteAll]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_DeleteAll]
AS
BEGIN
	DELETE FROM FinalAccountDetail
	
    DELETE FROM FinalAccount
END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_Delete]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_Delete]
    @FinalAccountID	BIGINT
   
AS
BEGIN
	DELETE FROM FinalAccountDetail
	WHERE FinalAccountID = @FinalAccountID

    DELETE FROM FinalAccount
    WHERE FinalAccountID = @FinalAccountID    
END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_CreateDetail]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_CreateDetail]
	@FinalAccountID	BIGINT,
	@MaterialID		BIGINT,
	@Quantity		FLOAT,
	@UnitCost		BIGINT,
	@TotalCost		BIGINT,
	@Note			NVARCHAR(MAX)
AS
BEGIN
	INSERT INTO FinalAccountDetail 
			(FinalAccountID, MaterialID, Quantity, UnitCost, TotalCost, Note)
	VALUES	(@FinalAccountID, @MaterialID, @Quantity, @UnitCost, @TotalCost, @Note)
END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_UpdateDetail]    Script Date: 07/19/2011 19:46:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_UpdateDetail]
	@FinalAccountDetailID BIGINT,
	@FinalAccountID	BIGINT,
	@MaterialID		BIGINT,
	@Quantity		FLOAT,
	@UnitCost		BIGINT,
	@TotalCost		BIGINT,
	@Note			NVARCHAR(MAX)
AS
BEGIN
	UPDATE	FinalAccountDetail 
	SET		FinalAccountID = @FinalAccountID,
			MaterialID = @MaterialID,
			Quantity = @Quantity,
			UnitCost = @UnitCost,
			TotalCost = @TotalCost,
			Note = @Note
	WHERE	FinalAccountDetailID = @FinalAccountDetailID
END
GO
/****** Object:  Default [DF_Construction_IsDeleted]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[Construction] ADD  CONSTRAINT [DF_Construction_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_Estimate_IsDeleted]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[Estimate] ADD  CONSTRAINT [DF_Estimate_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_EstimateDetail_IsDeleted]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[EstimateDetail] ADD  CONSTRAINT [DF_EstimateDetail_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
/****** Object:  Default [DF_Vehicle_Stastus]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[Vehicle] ADD  CONSTRAINT [DF_Vehicle_Stastus]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  ForeignKey [FK_Advance_Employee]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[Advance]  WITH CHECK ADD  CONSTRAINT [FK_Advance_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Advance] CHECK CONSTRAINT [FK_Advance_Employee]
GO
/****** Object:  ForeignKey [FK_ComparationDebt_Debt]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[ComparationDebt]  WITH CHECK ADD  CONSTRAINT [FK_ComparationDebt_Debt] FOREIGN KEY([DebtID])
REFERENCES [dbo].[Debt] ([DebtID])
GO
ALTER TABLE [dbo].[ComparationDebt] CHECK CONSTRAINT [FK_ComparationDebt_Debt]
GO
/****** Object:  ForeignKey [FK_Employee_Role]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Role]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_Employee]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_Employee]
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Construction]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Construction]
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Employee]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Employee]
GO
/****** Object:  ForeignKey [FK_Estimate_Construction]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[Estimate]  WITH CHECK ADD  CONSTRAINT [FK_Estimate_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[Estimate] CHECK CONSTRAINT [FK_Estimate_Construction]
GO
/****** Object:  ForeignKey [FK_EstimateDetail_Estimate]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[EstimateDetail]  WITH CHECK ADD  CONSTRAINT [FK_EstimateDetail_Estimate] FOREIGN KEY([EstimateID])
REFERENCES [dbo].[Estimate] ([EstimateID])
GO
ALTER TABLE [dbo].[EstimateDetail] CHECK CONSTRAINT [FK_EstimateDetail_Estimate]
GO
/****** Object:  ForeignKey [FK_EstimateDetail_Material]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[EstimateDetail]  WITH CHECK ADD  CONSTRAINT [FK_EstimateDetail_Material] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Material] ([MaterialID])
GO
ALTER TABLE [dbo].[EstimateDetail] CHECK CONSTRAINT [FK_EstimateDetail_Material]
GO
/****** Object:  ForeignKey [FK_FinalAccount_ComparationDebt]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[FinalAccount]  WITH CHECK ADD  CONSTRAINT [FK_FinalAccount_ComparationDebt] FOREIGN KEY([ComparationDebtID])
REFERENCES [dbo].[ComparationDebt] ([ComparationDebtID])
GO
ALTER TABLE [dbo].[FinalAccount] CHECK CONSTRAINT [FK_FinalAccount_ComparationDebt]
GO
/****** Object:  ForeignKey [FK_FinalAccount_Debt]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[FinalAccount]  WITH CHECK ADD  CONSTRAINT [FK_FinalAccount_Debt] FOREIGN KEY([DebtID])
REFERENCES [dbo].[Debt] ([DebtID])
GO
ALTER TABLE [dbo].[FinalAccount] CHECK CONSTRAINT [FK_FinalAccount_Debt]
GO
/****** Object:  ForeignKey [FK_FinalAccountDetail_FinalAccount]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[FinalAccountDetail]  WITH CHECK ADD  CONSTRAINT [FK_FinalAccountDetail_FinalAccount] FOREIGN KEY([FinalAccountID])
REFERENCES [dbo].[FinalAccount] ([FinalAccountID])
GO
ALTER TABLE [dbo].[FinalAccountDetail] CHECK CONSTRAINT [FK_FinalAccountDetail_FinalAccount]
GO
/****** Object:  ForeignKey [FK_MaterialWarehouse_Material]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[MaterialWarehouse]  WITH CHECK ADD  CONSTRAINT [FK_MaterialWarehouse_Material] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Material] ([MaterialID])
GO
ALTER TABLE [dbo].[MaterialWarehouse] CHECK CONSTRAINT [FK_MaterialWarehouse_Material]
GO
/****** Object:  ForeignKey [FK_MaterialWarehouse_Warehouse]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[MaterialWarehouse]  WITH CHECK ADD  CONSTRAINT [FK_MaterialWarehouse_Warehouse] FOREIGN KEY([WarehouseID])
REFERENCES [dbo].[Warehouse] ([WarehouseID])
GO
ALTER TABLE [dbo].[MaterialWarehouse] CHECK CONSTRAINT [FK_MaterialWarehouse_Warehouse]
GO
/****** Object:  ForeignKey [FK_MenuRole_Menu]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[MenuRole]  WITH CHECK ADD  CONSTRAINT [FK_MenuRole_Menu] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menu] ([MenuID])
GO
ALTER TABLE [dbo].[MenuRole] CHECK CONSTRAINT [FK_MenuRole_Menu]
GO
/****** Object:  ForeignKey [FK_MenuRole_Role1]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[MenuRole]  WITH CHECK ADD  CONSTRAINT [FK_MenuRole_Role1] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[MenuRole] CHECK CONSTRAINT [FK_MenuRole_Role1]
GO
/****** Object:  ForeignKey [FK_Worker_WorkersSalary]    Script Date: 07/19/2011 19:46:59 ******/
ALTER TABLE [dbo].[Worker]  WITH CHECK ADD  CONSTRAINT [FK_Worker_WorkersSalary] FOREIGN KEY([WorkersSalaryID])
REFERENCES [dbo].[WorkersSalary] ([WorkersSalaryID])
GO
ALTER TABLE [dbo].[Worker] CHECK CONSTRAINT [FK_Worker_WorkersSalary]
GO
