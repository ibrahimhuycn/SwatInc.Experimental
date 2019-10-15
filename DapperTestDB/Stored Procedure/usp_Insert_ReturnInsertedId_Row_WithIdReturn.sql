CREATE PROCEDURE [dbo].[usp_Insert_ReturnInsertedId_Row_WithIdReturn]
	@Surname VARCHAR(50)
AS

BEGIN TRANSACTION
	INSERT INTO [dbo].[ReturnInsertedIdTest] ([Surname])
	OUTPUT INSERTED.*
	VALUES (@Surname);
COMMIT TRANSACTION
/*
BEGIN TRANSACTION
	INSERT INTO [dbo].[ReturnInsertedIdTest] ([Surname])
	VALUES (@Surname);
	SELECT SCOPE_IDENTITY()  AS Id;
COMMIT TRANSACTION
*/