USE [WindyCityPOS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Orders_DeleteOrder]    Script Date: 10/22/2020 10:07:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_Orders_DeleteOrder]
(
	@OrderID INT

)
AS
	BEGIN
		DELETE FROM [dbo].[ProductSizes]
		WHERE [ProductID] = @OrderID

		DELETE FROM [dbo].[Orders]
		WHERE [OrderID] = @OrderID

	END