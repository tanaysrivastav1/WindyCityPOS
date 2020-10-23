CREATE PROCEDURE usp_Pizzas_InsertNewPizzaOrder
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