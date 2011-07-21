USE [CTEM-DB-v1]
GO
/****** Object:  StoredProcedure [dbo].[Estimate_search]    Script Date: 07/21/2011 07:47:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
ALTER PROCEDURE [dbo].[Estimate_search]
	@Name   nvarchar(150),
	@ConstructionID bigint,
	@ManagerID  bigint
AS
BEGIN
    SELECT    c.ConstructionName,e.*,p.ConstructionName as ParentName
    FROM    Estimate e
    INNER JOIN Construction c
    ON      e.ConstructionID = c.ConstructionID
    INNER JOIN Construction p
    ON      p.ConstructionID = (SELECT ParentID FROM Construction WHERE ConstructionID = e.ConstructionID)
    WHERE  e.type=0 AND e.IsDeleted!=1
    AND e.ConstructionID =ISNULL(@ConstructionID,e.ConstructionID)
    AND e.EstimateName like ISNULL(@Name,e.EstimateName)
    AND p.ManagerID= ISNULL(@ManagerID,p.ManagerID)
    ORDER BY p.ConstructionID

END

