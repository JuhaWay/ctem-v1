USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[Material_Update]    Script Date: 06/20/2011 08:47:13 ******/
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

