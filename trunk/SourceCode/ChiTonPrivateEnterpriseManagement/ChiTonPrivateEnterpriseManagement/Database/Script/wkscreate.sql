USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[WorkerSalary_Create]    Script Date: 06/20/2011 08:49:29 ******/
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

