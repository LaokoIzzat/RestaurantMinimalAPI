CREATE PROCEDURE [dbo].[spRestaurant_GetAll]
AS
BEGIN
	SELECT [Id], [Name], [Location] 
	FROM [dbo].[Restaurant];
END
