CREATE PROCEDURE ups_Products_LoadAllOrdersByOrderName
(
	@Name NVARCHAR(MAX)
)
AS
	BEGIN

	SELECT
		p.[OrderID]
	   ,p.[Name] AS 'Order'
	   ,l1.[Description] AS 'Type of Cheese'
	   ,p.[PurchasePrice] AS 'Purchase Price'
	   ,p.[DeliveryPrice] AS 'Delivery Price'
	   ,l3.[Description] AS 'Type of Pizza'

FROM [dbo].[Orders] p
LEFT JOIN [dbo].[ListTypeData] l1 ON p.CustomerID = l1.ListTypeDataID
LEFT JOIN [dbo].[ListTypeData] l2 ON p.OrderID =l2.ListTypeDataID
LEFT JOIN [dbo].[ProductSizes] ps ON p.OrderID = ps.[ProductID]
LEFT JOIN [dbo].[ListTypeData] l3 ON ps.[SizeID] = l3.ListTypeDataID

--now loading all orders by order name (in name column)
WHERE p.[Name] LIKE + '%' + @Name + '%'

END