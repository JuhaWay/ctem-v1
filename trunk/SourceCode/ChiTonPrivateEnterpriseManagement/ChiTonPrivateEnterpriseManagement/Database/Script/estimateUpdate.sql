USE [CTEM-DB-v1]
GO

/****** Object:  StoredProcedure [dbo].[EstimateDetail_update]    Script Date: 06/20/2011 08:46:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Author:        TienDH
-- Create date: 12/05/2011
-- Description:    Get full employee's information
-- =============================================
CREATE PROCEDURE [dbo].[EstimateDetail_update]
    @estimateDetailID      bigint,
    @materialID            bigint,
    @quantityEstimate	   int,
    @unitCostEstimate      decimal(18, 0),
    @totalCostEstimate     decimal(18, 0)
   
AS
BEGIN
    UPDATE  EstimateDetail
		SET     
			  QuantityEstimate= @quantityEstimate,
			  MaterialID = @materialID,
              UnitCostEstimate= @unitCostEstimate,
              TotalCostEstimate=@totalCostEstimate
        WHERE EstimateDetailID= @estimateDetailID
END






GO

