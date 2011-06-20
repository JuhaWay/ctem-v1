USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[WorkerSalary_Update]    Script Date: 06/20/2011 08:49:51 ******/
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

