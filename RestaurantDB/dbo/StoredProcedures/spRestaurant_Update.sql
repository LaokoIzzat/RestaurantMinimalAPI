CREATE PROCEDURE [dbo].[spRestaurant_Update]
	@Id int,
	@Name nvarchar(100),
	@Location nvarchar(100)
AS
BEGIN
	UPDATE [dbo].[Restaurant]
	SET [Name] = @Name,
		[Location] = @Location
	WHERE [Id] = @Id;
END
