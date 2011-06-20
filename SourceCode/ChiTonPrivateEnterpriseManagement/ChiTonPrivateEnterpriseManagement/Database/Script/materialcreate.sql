USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[Materital_Create]    Script Date: 06/20/2011 08:47:25 ******/
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

