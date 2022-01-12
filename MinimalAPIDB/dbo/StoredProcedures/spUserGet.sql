CREATE PROCEDURE [dbo].[spUserGet]
	@Id int
AS
begin
	SELECT Id, FirstName, LastName
	FROM dbo.[User]
	WHERE Id = @Id
end
