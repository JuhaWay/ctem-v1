USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[Material_Delete]    Script Date: 06/20/2011 08:46:52 ******/
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

