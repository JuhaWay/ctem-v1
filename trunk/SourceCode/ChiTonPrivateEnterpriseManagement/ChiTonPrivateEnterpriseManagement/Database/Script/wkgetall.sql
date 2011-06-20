USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[Worker_GetAll]    Script Date: 06/20/2011 08:49:08 ******/
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

