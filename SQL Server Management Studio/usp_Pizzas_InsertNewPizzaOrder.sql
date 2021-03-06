USE [WindyCityPOS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pizzas_InsertNewPizzaOrder]    Script Date: 10/22/2020 10:07:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_Pizzas_InsertNewPizzaOrder]
(
	@Name NVARCHAR(50)
	,@CustomerID INT
	,@PurchasePrice DECIMAL(18,2)
	,@DeliveryPrice DECIMAL(18,2)
)
AS 
	BEGIN
	INSERT INTO [dbo].[Orders]
           ([Name]
           ,[CustomerID]
           ,[PurchasePrice]
           ,[DeliveryPrice])
     VALUES(
			@Name
			,@CustomerID
			,@PurchasePrice
			,@DeliveryPrice
	 )

	 SELECT SCOPE_IDENTITY()
	 --return recently added value

	 END