CREATE PROCEDURE [dbo].[spRestaurant_Insert]
	@Name nvarchar(100),
	@Location nvarchar(100)
AS
BEGIN 
	INSERT INTO [dbo].[Restaurant] ([Name], [Location])
	VALUES (@Name, @Location);
END