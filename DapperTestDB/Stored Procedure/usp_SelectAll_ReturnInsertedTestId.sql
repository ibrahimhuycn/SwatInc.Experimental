CREATE PROCEDURE [dbo].[usp_SelectAll_ReturnInsertedTestId]

AS
BEGIN TRAN
	SELECT *
	FROM [dbo].[ReturnInsertedIdTest];
COMMIT TRAN

