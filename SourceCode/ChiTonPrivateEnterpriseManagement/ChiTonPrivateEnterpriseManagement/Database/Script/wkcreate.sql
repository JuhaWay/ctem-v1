USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[Worker_Create]    Script Date: 06/20/2011 08:48:58 ******/
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

