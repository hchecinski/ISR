CREATE PROCEDURE [dbo].[Initialize_Role]
AS
	BEGIN
		DELETE FROM [dbo].[Role]
	END
	BEGIN
		INSERT INTO [dbo].[Role] (RoleName)
		VALUES ('Admin')
		INSERT INTO [dbo].[Role] (RoleName)
		VALUES ('Moderator')
		INSERT INTO [dbo].[Role] (RoleName)
		VALUES ('Standart')
	END
