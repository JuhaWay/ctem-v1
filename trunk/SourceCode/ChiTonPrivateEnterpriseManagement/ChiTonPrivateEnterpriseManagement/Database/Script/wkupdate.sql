USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[Worker_Update]    Script Date: 06/20/2011 08:49:19 ******/
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

