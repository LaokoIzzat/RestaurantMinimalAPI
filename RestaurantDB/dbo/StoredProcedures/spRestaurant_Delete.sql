CREATE PROCEDURE [dbo].[spRestaurant_Delete]
	@Id int
AS
BEGIN
	DELETE
	FROM [dbo].[Restaurant]
	WHERE [Id] = @Id;
END
