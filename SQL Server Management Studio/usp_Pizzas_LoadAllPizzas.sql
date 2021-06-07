USE [WindyCityPOS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Pizzas_LoadAllPizzas]    Script Date: 10/22/2020 10:07:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_Pizzas_LoadAllPizzas]
(
	@ListTypeID INT

)
AS
	BEGIN
		--DECLARE @IsSelected BIT
		--SET @IsSelected = 0

		SELECT [ListTypeDataID] AS 'ID'
			   ,[Description] AS 'Title'
			   ,[Select] AS 'Select'
			   --,@IsSelected AS 'Select'
		FROM [dbo].[ListTypeData] WHERE 
			[ListTypeID] = @ListTypeID


	END