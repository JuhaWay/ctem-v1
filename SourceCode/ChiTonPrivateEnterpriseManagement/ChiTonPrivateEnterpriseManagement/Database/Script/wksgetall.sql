USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[WorkerSalary_GetAll]    Script Date: 06/20/2011 08:49:40 ******/
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
	SELECT	s.ConstructionName,c.Name,c.WorkersSalaryID,c.ConstructionID,c.FromDate,c.ToDate,
			c.TotalSalary,c.CreateDate,c.LastUpdate,c.CreatedBy,c.UpdatedBy
	FROM	WorkersSalary c
	LEFT JOIN Construction s 
	ON s.ConstructionID = c.ConstructionID 
END



GO

