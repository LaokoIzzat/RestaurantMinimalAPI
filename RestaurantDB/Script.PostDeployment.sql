/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT 1 FROM [dbo].[Restaurant])
BEGIN 
    INSERT INTO [dbo].[Restaurant] ([Name], [Location])
    VALUES ('Nawroz', 'Harringay'),
           ('Berenjak', 'Soho'),
           ('The Mantl', 'Knightsbridge'),
           ('Robata', 'Soho');
END