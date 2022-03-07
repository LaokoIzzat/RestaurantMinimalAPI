CREATE PROCEDURE [dbo].[spRestaurant_Get]
	@Id int
AS
BEGIN
	SELECT [Id], [Name], [Location] 
	FROM [dbo].[Restaurant]
	WHERE [Id] = @Id;
END
