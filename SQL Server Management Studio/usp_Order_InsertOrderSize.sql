USE [WindyCityPOS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Order_InsertOrderSize]    Script Date: 10/22/2020 10:06:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_Order_InsertOrderSize]
(
	@ProductID INT
	,@SizeID   INT

)
AS
	BEGIN

	INSERT INTO [dbo].[ProductSizes]
           ([ProductID]
           ,[SizeID])
     VALUES
	 (
		@ProductID
		,@SizeID

	 )

	END