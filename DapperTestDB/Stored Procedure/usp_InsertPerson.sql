CREATE PROCEDURE [dbo].[usp_InsertPerson]
	@IdCardNumber VARCHAR(50),
	@PersonName VARCHAR(50),
	@Address VARCHAR(50)
AS
BEGIN
	SET STATISTICS IO OFF
	INSERT INTO DBO.People (IdCardNumber,PeopleName,[Address]) VALUES (@IdCardNumber,@PersonName,@Address)
END
