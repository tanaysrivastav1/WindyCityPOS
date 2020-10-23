USE [WindyCityPOS]
GO
/****** Object:  StoredProcedure [dbo].[usp_ListTypeData_LoadDataIntoComboBox]    Script Date: 10/22/2020 10:06:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_ListTypeData_LoadDataIntoComboBox]
(
	@ListTypeID INT


)
AS 
	BEGIN
		SELECT[ListTypeDataID] AS 'ID'
			 ,[Description] AS 'Description'
		FROM [dbo].[ListTypeData]
		WHERE [ListTypeID] = @ListTypeID

	END