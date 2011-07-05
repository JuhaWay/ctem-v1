USE [CTEM-DB-v1]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  Table [dbo].[StockOut]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  Table [dbo].[StockOutDetail]    Script Date: 06/25/2011 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockOutDetail](
	[StockOutID] [bigint] NOT NULL,
	[MaterialID] [bigint] NOT NULL,
	[Quantity] [float] NULL,
 CONSTRAINT [PK_StockOutDetail] PRIMARY KEY CLUSTERED 
(
	[StockOutID] ASC,
	[MaterialID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[RightEnumAliasGenerate]    Script Date: 06/25/2011 09:55:12 ******/
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
/****** Object:  Table [dbo].[Material]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  Table [dbo].[Menu]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  StoredProcedure [dbo].[Employee_GetSalary]    Script Date: 06/25/2011 09:55:08 ******/
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
	@empId			BIGINT,
	@fromTime		VARCHAR(6),
	@toTime			VARCHAR(6),
	@sortBy			VARCHAR(30),
	@direction		VARCHAR(10),
	@salary			BIGINT,
	@allowance		BIGINT,
	@phonecost		BIGINT,
	@payDebt		BIGINT,
	@actualIncome	BIGINT
AS
BEGIN
	DECLARE	@SQL VARCHAR(MAX)
	SET @SQL = '
	SELECT	S.EmployeeSalaryID, E.Username, E.FullName, S.Month, S.Salary, S.Allowance, S.PhoneCost, S.DebtPay, S.ActualIncome, S.isPay, S.CreatedDate, S.LastUpdate
	FROM	EmployeeSalary S JOIN Employee E ON S.EmployeeID = E.EmployeeID
	WHERE	S.Month BETWEEN @fromTime AND @toTime AND
			S.Salary >= ''' + @salary + ''' AND
			S.Allowance >= ''' + @allowance + ''' AND
			S.PhoneCost >= ''' + @phonecost + ''' AND
			S.DebtPay >= ''' + @payDebt + ''' AND
			S.ActualIncome >= ''' + @actualIncome
	IF	@empId <> 0
	BEGIN
		SET @SQL = @SQL + ''' AND S.EmployeeID = ''' + @empId
	END
	
	EXEC(@SQL)
END
GO
/****** Object:  Table [dbo].[Construction]    Script Date: 06/25/2011 09:55:10 ******/
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
	[TotalEstimateCost] [bigint] NULL,
	[TotalRealCost] [bigint] NULL,
	[ParentID] [bigint] NULL,
	[Status] [nvarchar](50) NULL,
	[HasEstimate] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[UpdatedBy] [varchar](50) NULL,
	[SubcontractorID] [bigint] NULL,
	[ProgressRate] [float] NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_Construction] PRIMARY KEY CLUSTERED 
(
	[ConstructionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Debt]    Script Date: 06/25/2011 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Debt](
	[DebtID] [bigint] IDENTITY(1,1) NOT NULL,
	[DebtName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[TotalOwe] [bigint] NULL,
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
/****** Object:  Table [dbo].[Subcontractor]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  Table [dbo].[Warehouse]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  StoredProcedure [dbo].[Subcontractor_GetByName]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Subcontractor_GetByID]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Subcontractor_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Subcontractor_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
	INSERT INTO Subcontractor 
			(SubcontractorName, SubcontractorAddress,PhoneNumber)
	VALUES	(@subcontractorName, @subcontractorAddress,@phoneNumber)	
END
GO
/****** Object:  StoredProcedure [dbo].[StockOutDetail_Create]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[StockOutDetail_Create]
	@StockOutID	BIGINT,
	@MaterialID	BIGINT,
	@Quantity	FLOAT
AS
--DECLARE @CreatedDate DATETIME
--SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO StockOutDetail
			(StockOutID, MaterialID, Quantity)
	VALUES	(@StockOutID, @MaterialID, @Quantity)
END
GO
/****** Object:  Table [dbo].[WorkersSalary]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  StoredProcedure [dbo].[Debt_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Debt_GetAll]
AS
BEGIN
	SELECT	*
	FROM	Debt
END
GO
/****** Object:  StoredProcedure [dbo].[Debt_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Construction_GetChildren]    Script Date: 06/25/2011 09:55:08 ******/
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
	SELECT	s.SubcontractorName,c.ConstructionID,c.ConstructionName,
			c.ConstructionAddress,c.CommencementDate,c.CompletionDate,
			c.CreatedBy,c.CreatedDate,c.Description,c.HasEstimate,c.LastUpdated,
			c.ParentID,c.Status,c.TotalEstimateCost,c.TotalRealCost,c.UpdatedBy,c.ParentID
	FROM	Construction c
	INNER JOIN Subcontractor s 
	ON c.SubcontractorID = s.SubcontractorID AND c.ParentID =@constructionID 
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetByName]    Script Date: 06/25/2011 09:55:08 ******/
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
    WHERE    ConstructionName =@constructionName
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetByID]    Script Date: 06/25/2011 09:55:08 ******/
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
	SELECT	*
	FROM	Construction
	WHERE	ConstructionID =@constructionID
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
	SELECT	s.SubcontractorName,c.ConstructionID,c.ConstructionName,
			c.ConstructionAddress,c.CommencementDate,c.CompletionDate,
			c.CreatedBy,c.CreatedDate,c.Description,c.HasEstimate,c.LastUpdated,
			c.ParentID,c.Status,c.TotalEstimateCost,c.TotalRealCost,c.UpdatedBy
	FROM	Construction c
	LEFT OUTER JOIN Subcontractor s 
	ON s.SubcontractorID = c.SubcontractorID AND ParentID = 0;
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_Delete]    Script Date: 06/25/2011 09:55:08 ******/
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
	DELETE FROM [Construction]
	WHERE ConstructionID =@constructionID 
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
	@totalEstimateCost		decimal(18, 0),
	@status					nvarchar(50),
	@hasEstimate			bit,
	@parentID				bigint
AS
BEGIN
	INSERT INTO Construction 
			(ConstructionName,SubcontractorID, Description,ConstructionAddress,
			CommencementDate,CompletionDate,TotalEstimateCost,
			TotalRealCost,Status,HasEstimate,ParentID)
	VALUES	(@constructionName,@subconstractorID,@description	,@constructionAddress,
			@commencementDate,@completionDate,@totalEstimateCost,
			0,@status,@hasEstimate,@parentID)	
END
GO
/****** Object:  Table [dbo].[Estimate]    Script Date: 06/25/2011 09:55:10 ******/
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
 CONSTRAINT [PK_Estimate] PRIMARY KEY CLUSTERED 
(
	[EstimateID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComparationDebt]    Script Date: 06/25/2011 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComparationDebt](
	[ComparationDebtID] [bigint] IDENTITY(1,1) NOT NULL,
	[DebtID] [bigint] NOT NULL,
	[RepresentationDebtName] [nvarchar](50) NOT NULL,
	[DateCompare] [datetime] NULL,
	[TotalOwe] [bigint] NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[CreateBy] [nvarchar](50) NULL,
	[UpdateBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[LastUpdateDate] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_ComparationDebt] PRIMARY KEY CLUSTERED 
(
	[ComparationDebtID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Construction_UpdateTotalEstimateCost]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Construction_Update]    Script Date: 06/25/2011 09:55:08 ******/
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
	@completionDate			DATETIME,
	@totalEstimateCost		decimal(18, 0),
	@status					nvarchar(50),
	@hasEstimate			bit
AS
BEGIN
	UPDATE  [Construction]
			
	SET     ConstructionName = @constructionName,
			SubcontractorID = @subconstractorID,
			Description = @description,
			ConstructionAddress = @constructionAddress,
			CommencementDate =@commencementDate,
			completionDate = @completionDate,
			TotalEstimateCost=@totalEstimateCost,
			Status=@status,
			HasEstimate=@hasEstimate
	WHERE	ConstructionID =@constructionID
END
GO
/****** Object:  StoredProcedure [dbo].[Material_Update]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Material_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Material_Delete]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Materital_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  Table [dbo].[MenuRole]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_Update]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  Table [dbo].[Rights]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[StockOut_Create]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[StockOut_Create]
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
/****** Object:  StoredProcedure [dbo].[Role_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Role_Delete]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Role_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Role_Update]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Role_GetByMenuID]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Rights_Update]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Rights_GetByRightValue]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Rights_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Rights_Delete]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Rights_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[MenuRole_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_Delete]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Menu_GetByRoleID]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Employee_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  Table [dbo].[MaterialWarehouse]    Script Date: 06/25/2011 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaterialWarehouse](
	[WarehouseID] [bigint] NOT NULL,
	[MaterialID] [bigint] NOT NULL,
	[Quantity] [float] NULL,
	[AveragePrice] [bigint] NULL,
	[TotalCost] [bigint] NULL,
 CONSTRAINT [PK_MaterialWarehouse] PRIMARY KEY CLUSTERED 
(
	[MaterialID] ASC,
	[WarehouseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinalAccount]    Script Date: 06/25/2011 09:55:10 ******/
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
	[TotalCost] [bigint] NULL,
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
/****** Object:  StoredProcedure [dbo].[CompareDebt_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[CompareDebt_GetAll]
AS
BEGIN
	SELECT	CD.*, D.DebtName
	FROM	ComparationDebt CD JOIN Debt D ON CD.DebtID = D.DebtID
END
GO
/****** Object:  StoredProcedure [dbo].[CompareDebt_Create]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[CompareDebt_Create]
	@DateCompare			DATETIME,
	@DebtID					BIGINT,
	@FromDate				DATETIME,
	@ToDate					DATETIME,	
	@TotalOwe				BIGINT,
	@RepresentationDebtName	NVARCHAR(50),
	@Note					NVARCHAR(MAX)
	
AS
DECLARE @CreatedDate DATETIME
SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO ComparationDebt 
			(DateCompare, DebtID, FromDate, ToDate, TotalOwe, RepresentationDebtName, Note)
	VALUES	(@DateCompare, @DebtID, @FromDate, @ToDate, @TotalOwe, @RepresentationDebtName, @Note)
END
GO
/****** Object:  StoredProcedure [dbo].[ComparationDebt_Create]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[ComparationDebt_Create]
	@DebtID					BIGINT,
	@RepresentationDebtName	NVARCHAR(50),
	@DateCompare			DATETIME,
	@FromDate				DATETIME,
	@ToDate					DATETIME,
	@TotalOwe				BIGINT,
	@Note					DATETIME,
	@CreatedBy				NVARCHAR(50)
AS
DECLARE @CreatedDate DATETIME
SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO ComparationDebt 
			(DebtID, RepresentationDebtName, DateCompare, FromDate, ToDate, TotalOwe, Note, CreateBy, UpdateBy, CreatedDate, LastUpdateDate)
	VALUES	(@DebtID, @RepresentationDebtName, @DateCompare, @FromDate,@ToDate, @TotalOwe, @Note, @CreatedBy, @CreatedBy, @CreatedDate, @CreatedDate)
END
GO
/****** Object:  StoredProcedure [dbo].[Construction_GetHaveWarehouse]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  Table [dbo].[Advance]    Script Date: 06/25/2011 09:55:10 ******/
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
	CreatedBy [nvarchar](max) NULL,
	UpdatedBy [nvarchar](max) NULL
 CONSTRAINT [PK_Advance_1] PRIMARY KEY CLUSTERED 
(
	[AdvanceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstimateDetail]    Script Date: 06/25/2011 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstimateDetail](
	[EstimateDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[EstimateID] [bigint] NOT NULL,
	[MaterialID] [bigint] NOT NULL,
	[QuantityEstimate] [float] NULL,
	[UnitCostEstimate] [bigint] NULL,
	[TotalCostEstimate] [bigint] NULL,
	[QuantityReal] [float] NULL,
	[UnitCostReal] [bigint] NULL,
	[TotalCostReal] [bigint] NULL,
	[Note] [nvarchar](max) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_EstimateDetail] PRIMARY KEY CLUSTERED 
(
	[EstimateDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Estimate_UpdateTotalCost]    Script Date: 06/25/2011 09:55:08 ******/
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
    @estimateID            BIGINT,

    @totalCostEstimate        decimal(18, 0)
AS
BEGIN
    UPDATE  [Estimate]
    SET      TotalCostEstimate= @totalCostEstimate

           
    WHERE    EstimateID =@estimateID
END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
    SELECT    c.ConstructionName,e.EstimateID,e.ConstructionID,
            e.EstimateName,e.TotalCostEstimate,e.TotalCostReal,
            e.CreatedDate,e.CreatedBy,e.UpdatedDate,e.UpdatedBy
    FROM    Estimate e
    INNER JOIN Construction c
    ON      e.ConstructionID = c.ConstructionID

END
GO
/****** Object:  StoredProcedure [dbo].[Estimate_Delete]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Estimate_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
    @constructionID        bigint,
    @estimateName        nvarchar(150),
    @totalCostEstimate    bigint,
    @totalCostReal        bigint,
    @createdDate        datetime ,
    @updatedDate        datetime,
    @createdBy            nvarchar(150),
    @updatedBy            nvarchar(150)
   
AS
BEGIN
    INSERT INTO Estimate
            (ConstructionID,EstimateName,
             TotalCostEstimate,TotalCostReal,CreatedDate,
             UpdatedDate,CreatedBy,UpdatedBy)
    VALUES    (@constructionID,@estimateName,
            @totalCostEstimate,@totalCostReal,@createdDate,
            @updatedDate,@createdBy,@updatedBy)   
END
GO
/****** Object:  Table [dbo].[EmployerConstruction]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  StoredProcedure [dbo].[Employer_GetByUsername]    Script Date: 06/25/2011 09:55:08 ******/
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
			E.RoleID, E.RightsValue,E.CMND,
			E.DOB,E.PhoneNumber, E.IsActive, R.RoleName, E.TotalDebt
	FROM	Employee E JOIN Role R ON E.RoleID = R.RoleID
	WHERE	E.Username = @username
END
GO
/****** Object:  Table [dbo].[EmployeeSalary]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  StoredProcedure [dbo].[Employee_Update]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Employee_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  Table [dbo].[Worker]    Script Date: 06/25/2011 09:55:10 ******/
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
/****** Object:  StoredProcedure [dbo].[Warehouse_Get]    Script Date: 06/25/2011 09:55:08 ******/
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
	@Type NVARCHAR(50)
AS
BEGIN
	SELECT	W.*, C.ConstructionName
	FROM	Warehouse W LEFT OUTER JOIN Construction C ON W.ConstructionID = C.ConstructionID
	WHERE	W.[Type] = @Type
END
GO
/****** Object:  StoredProcedure [dbo].[Warehouse_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[WorkerSalary_Update]    Script Date: 06/25/2011 09:55:08 ******/
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
	@createDate				DATETIME,
	@lastUpdate				DATETIME,
	@createdBy				nvarchar(50),
	@updatedBy				nvarchar(50)
AS
BEGIN
	UPDATE  [WorkersSalary]
			
	SET      ConstructionID = @constructionID,
			Name = @name,
			FromDate = @fromDate,
			ToDate = @toDate,
			TotalSalary =@totalSalary,
			CreateDate = @createDate,
			LastUpdate=@toDate,
			CreatedBy=@lastUpdate,
			UpdatedBy=@updatedBy
	WHERE	WorkersSalaryID = @workersSalaryID
END
GO
/****** Object:  StoredProcedure [dbo].[WorkerSalary_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
	FROM	WorkersSalary
END
GO
/****** Object:  StoredProcedure [dbo].[WorkerSalary_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
	@createDate				DATETIME,
	@lastUpdate				DATETIME,
	@createdBy				nvarchar(50),
	@updatedBy				nvarchar(50)

AS
BEGIN
	INSERT INTO WorkersSalary 
			(ConstructionID,Name,FromDate,ToDate,
			TotalSalary,CreateDate,LastUpdate,CreatedBy,UpdatedBy)
	VALUES	(@constructionID,@name,@fromDate,@toDate,
			@totalSalary,@createDate,@lastUpdate,
			@createdBy,@updatedBy)	
END
GO
/****** Object:  StoredProcedure [dbo].[Worker_Update]    Script Date: 06/25/2011 09:55:08 ******/
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
	@ManDate				int,
	@Salary					decimal(18, 0),
	@TotalSalary			decimal(18, 0),
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
/****** Object:  StoredProcedure [dbo].[Worker_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Worker_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
	@ManDate				int,
	@salary					decimal(18, 0),
	@totalSalary			decimal(18, 0),
	@position				nvarchar(125),
	@createDate				DATETIME,
	@lastUpdated			DATETIME,
	@createdBy				nvarchar(50),
	@updatedBy				nvarchar(50)

AS
BEGIN
	INSERT INTO Worker 
			(WorkersSalaryID,FullName,ManDate,Salary,
			TotalSalary,Position,CreatedDate,CreatedBy,LastUpdated,UpdatedBy)
	VALUES	(@workersSalaryID,@fullName,@ManDate,
			@salary,@totalSalary,@position,@createDate,@createdBy,@lastUpdated,
			@updatedBy)	
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetAdvance]    Script Date: 06/25/2011 09:55:08 ******/
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
	
AS
BEGIN
	SELECT	A.*, E.Username, E.FullName
	FROM	Advance A JOIN Employee E ON A.EmployeeID = E.EmployeeID	
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_CreateSalary]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Employee_CreateAdvance]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Advance_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Advance_GetAll]
AS
BEGIN
	SELECT	*
	FROM	Advance	
END
GO
/****** Object:  StoredProcedure [dbo].[Advance_Create]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[Advance_Create]
	@EmployeeID		BIGINT,
	@TotalAdvance	BIGINT,
	@Reason			NVARCHAR(MAX),
	@Note			NVARCHAR(MAX),
	@CreatedBy		NVARCHAR(50)
AS
DECLARE @CreatedDate DATETIME
SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO Advance 
			(EmployeeID, TotalAdvance, Reason, Note, CreatedBy, UpdatedBy, CreatedDate, LastUpdate)
	VALUES	(@EmployeeID, @TotalAdvance, @Reason, @Note, @CreatedBy, @CreatedBy, @CreatedDate, @CreatedDate)
END
GO
/****** Object:  StoredProcedure [dbo].[MaterialWarehouse_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[Employee_GetAllSalary]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TIENDH
-- Create date: 06/06/2011
-- Description:	abc
-- =============================================
CREATE PROCEDURE [dbo].[Employee_GetAllSalary] 
AS
BEGIN
	SELECT	S.EmployeeSalaryID, E.Username, E.FullName, S.Month, S.Salary, S.Allowance, S.PhoneCost, S.DebtPay, S.ActualIncome, S.isPay, S.CreatedDate, S.LastUpdate
	FROM	EmployeeSalary S JOIN Employee E ON S.EmployeeID = E.EmployeeID
END
GO
/****** Object:  Table [dbo].[FinalAccountDetail]    Script Date: 06/25/2011 09:55:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalAccountDetail](
	[FinalAccountDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[FinalAccountID] [bigint] NOT NULL,
	[MaterialID] [bigint] NOT NULL,
	[Quantity] [float] NULL,
	[UnitCost] [bigint] NULL,
	[TotalCost] [bigint] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_FinalAccountDetail] PRIMARY KEY CLUSTERED 
(
	[FinalAccountDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_GetAll]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccount_GetAll]
AS
BEGIN
    SELECT  FA.*, C.ConstructionName, D.DebtName
    FROM    FinalAccount FA JOIN Construction C ON FA.ConstructionID = C.ConstructionID, Debt D
    WHERE	FA.DebtID = D.DebtID

END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccount_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
	VALUES	(@FinalAccountID, @FinalAccountName, @ConstructionID, @PersonAccount, @DateAccount, @DebtID, @TransportationCost, @TotalCost, @IsPay, @Note, @CreatedBy, @CreatedBy, @CreatedDate, @CreatedDate)
END
GO
/****** Object:  StoredProcedure [dbo].[EstimateDetail_update]    Script Date: 06/25/2011 09:55:08 ******/
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
    @quantityEstimate	   int,
    @unitCostEstimate      decimal(18, 0),
    @totalCostEstimate     decimal(18, 0)
   
AS
BEGIN
    UPDATE  EstimateDetail
		SET     
			  QuantityEstimate= @quantityEstimate,
			  MaterialID = @materialID,
              UnitCostEstimate= @unitCostEstimate,
              TotalCostEstimate=@totalCostEstimate
        WHERE EstimateDetailID= @estimateDetailID
END
GO
/****** Object:  StoredProcedure [dbo].[EstimateDetail_GetByEstimateId]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[EstimateDetail_Delete]    Script Date: 06/25/2011 09:55:08 ******/
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
/****** Object:  StoredProcedure [dbo].[EstimateDetail_Create]    Script Date: 06/25/2011 09:55:08 ******/
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
    @quantityEstimate    int,
    @unitCostEstimate    decimal(18, 0),
    @totalCostEstimate    decimal(18, 0)
   
AS
BEGIN
    INSERT INTO EstimateDetail
            (EstimateID,MaterialID,QuantityEstimate,
             UnitCostEstimate,TotalCostEstimate)
    VALUES    (@estimateID,@materialID,@quantityEstimate,
            @unitCostEstimate,@totalCostEstimate)   
END
GO
/****** Object:  StoredProcedure [dbo].[FinalAccountDetail_Create]    Script Date: 06/25/2011 09:55:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		TienDH
-- Create date: 12/05/2011
-- Description:	Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[FinalAccountDetail_Create]
	@FinalAccountID	BIGINT,
	@MaterialID		BIGINT,
	@Quantity		FLOAT,
	@UnitCost		BIGINT,
	@TotalCost		BIGINT,
	@Note			NVARCHAR(MAX)
AS
--DECLARE @CreatedDate DATETIME
--SET		@CreatedDate = GETDATE()
BEGIN
	INSERT INTO FinalAccountDetail 
			(FinalAccountID, MaterialID, Quantity, UnitCost, TotalCost, Note)
	VALUES	(@FinalAccountID, @MaterialID, @Quantity, @UnitCost, @TotalCost, @Note)
END
GO
/****** Object:  ForeignKey [FK_Advance_Employee]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[Advance]  WITH CHECK ADD  CONSTRAINT [FK_Advance_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Advance] CHECK CONSTRAINT [FK_Advance_Employee]
GO
/****** Object:  ForeignKey [FK_ComparationDebt_Debt]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[ComparationDebt]  WITH CHECK ADD  CONSTRAINT [FK_ComparationDebt_Debt] FOREIGN KEY([DebtID])
REFERENCES [dbo].[Debt] ([DebtID])
GO
ALTER TABLE [dbo].[ComparationDebt] CHECK CONSTRAINT [FK_ComparationDebt_Debt]
GO
/****** Object:  ForeignKey [FK_Employee_Role]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Role]
GO
/****** Object:  ForeignKey [FK_EmployeeSalary_Employee]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[EmployeeSalary]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSalary_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployeeSalary] CHECK CONSTRAINT [FK_EmployeeSalary_Employee]
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Construction]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Construction]
GO
/****** Object:  ForeignKey [FK_EmployerConstruction_Employee]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[EmployerConstruction]  WITH CHECK ADD  CONSTRAINT [FK_EmployerConstruction_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployerConstruction] CHECK CONSTRAINT [FK_EmployerConstruction_Employee]
GO
/****** Object:  ForeignKey [FK_Estimate_Construction]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[Estimate]  WITH CHECK ADD  CONSTRAINT [FK_Estimate_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[Estimate] CHECK CONSTRAINT [FK_Estimate_Construction]
GO
/****** Object:  ForeignKey [FK_EstimateDetail_Estimate]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[EstimateDetail]  WITH CHECK ADD  CONSTRAINT [FK_EstimateDetail_Estimate] FOREIGN KEY([EstimateID])
REFERENCES [dbo].[Estimate] ([EstimateID])
GO
ALTER TABLE [dbo].[EstimateDetail] CHECK CONSTRAINT [FK_EstimateDetail_Estimate]
GO
/****** Object:  ForeignKey [FK_EstimateDetail_Material]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[EstimateDetail]  WITH CHECK ADD  CONSTRAINT [FK_EstimateDetail_Material] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Material] ([MaterialID])
GO
ALTER TABLE [dbo].[EstimateDetail] CHECK CONSTRAINT [FK_EstimateDetail_Material]
GO
/****** Object:  ForeignKey [FK_FinalAccount_ComparationDebt]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[FinalAccount]  WITH CHECK ADD  CONSTRAINT [FK_FinalAccount_ComparationDebt] FOREIGN KEY([ComparationDebtID])
REFERENCES [dbo].[ComparationDebt] ([ComparationDebtID])
GO
ALTER TABLE [dbo].[FinalAccount] CHECK CONSTRAINT [FK_FinalAccount_ComparationDebt]
GO
/****** Object:  ForeignKey [FK_FinalAccount_Construction]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[FinalAccount]  WITH CHECK ADD  CONSTRAINT [FK_FinalAccount_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[FinalAccount] CHECK CONSTRAINT [FK_FinalAccount_Construction]
GO
/****** Object:  ForeignKey [FK_FinalAccount_Debt]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[FinalAccount]  WITH CHECK ADD  CONSTRAINT [FK_FinalAccount_Debt] FOREIGN KEY([DebtID])
REFERENCES [dbo].[Debt] ([DebtID])
GO
ALTER TABLE [dbo].[FinalAccount] CHECK CONSTRAINT [FK_FinalAccount_Debt]
GO
/****** Object:  ForeignKey [FK_FinalAccountDetail_FinalAccount]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[FinalAccountDetail]  WITH CHECK ADD  CONSTRAINT [FK_FinalAccountDetail_FinalAccount] FOREIGN KEY([FinalAccountID])
REFERENCES [dbo].[FinalAccount] ([FinalAccountID])
GO
ALTER TABLE [dbo].[FinalAccountDetail] CHECK CONSTRAINT [FK_FinalAccountDetail_FinalAccount]
GO
/****** Object:  ForeignKey [FK_FinalAccountDetail_Material]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[FinalAccountDetail]  WITH CHECK ADD  CONSTRAINT [FK_FinalAccountDetail_Material] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Material] ([MaterialID])
GO
ALTER TABLE [dbo].[FinalAccountDetail] CHECK CONSTRAINT [FK_FinalAccountDetail_Material]
GO
/****** Object:  ForeignKey [FK_MaterialWarehouse_Material]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[MaterialWarehouse]  WITH CHECK ADD  CONSTRAINT [FK_MaterialWarehouse_Material] FOREIGN KEY([MaterialID])
REFERENCES [dbo].[Material] ([MaterialID])
GO
ALTER TABLE [dbo].[MaterialWarehouse] CHECK CONSTRAINT [FK_MaterialWarehouse_Material]
GO
/****** Object:  ForeignKey [FK_MaterialWarehouse_Warehouse]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[MaterialWarehouse]  WITH CHECK ADD  CONSTRAINT [FK_MaterialWarehouse_Warehouse] FOREIGN KEY([WarehouseID])
REFERENCES [dbo].[Warehouse] ([WarehouseID])
GO
ALTER TABLE [dbo].[MaterialWarehouse] CHECK CONSTRAINT [FK_MaterialWarehouse_Warehouse]
GO
/****** Object:  ForeignKey [FK_MenuRole_Menu]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[MenuRole]  WITH CHECK ADD  CONSTRAINT [FK_MenuRole_Menu] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menu] ([MenuID])
GO
ALTER TABLE [dbo].[MenuRole] CHECK CONSTRAINT [FK_MenuRole_Menu]
GO
/****** Object:  ForeignKey [FK_MenuRole_Role1]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[MenuRole]  WITH CHECK ADD  CONSTRAINT [FK_MenuRole_Role1] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[MenuRole] CHECK CONSTRAINT [FK_MenuRole_Role1]
GO
/****** Object:  ForeignKey [FK_Warehouse_Construction]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[Warehouse]  WITH CHECK ADD  CONSTRAINT [FK_Warehouse_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[Warehouse] CHECK CONSTRAINT [FK_Warehouse_Construction]
GO
/****** Object:  ForeignKey [FK_Worker_WorkersSalary]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[Worker]  WITH CHECK ADD  CONSTRAINT [FK_Worker_WorkersSalary] FOREIGN KEY([WorkersSalaryID])
REFERENCES [dbo].[WorkersSalary] ([WorkersSalaryID])
GO
ALTER TABLE [dbo].[Worker] CHECK CONSTRAINT [FK_Worker_WorkersSalary]
GO
/****** Object:  ForeignKey [FK_WorkersSalary_Construction]    Script Date: 06/25/2011 09:55:10 ******/
ALTER TABLE [dbo].[WorkersSalary]  WITH CHECK ADD  CONSTRAINT [FK_WorkersSalary_Construction] FOREIGN KEY([ConstructionID])
REFERENCES [dbo].[Construction] ([ConstructionID])
GO
ALTER TABLE [dbo].[WorkersSalary] CHECK CONSTRAINT [FK_WorkersSalary_Construction]
GO
