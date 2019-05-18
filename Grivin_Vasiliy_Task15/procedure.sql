use UserAndAwards

CREATE PROCEDURE AddUser
(
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@birthdate DATE
)

AS
BEGIN
	INSERT INTO Users
	OUTPUT INSERTED.ID
	VALUES(@firstName, @lastName, @birthdate)
END
GO

CREATE PROCEDURE AddAward
(
	@title nvarchar(50),
	@description nvarchar(250)
)
AS
BEGIN
	INSERT INTO dbo.Awards
	VALUES(@title, @description)
END
GO

CREATE PROCEDURE GetUser
(
	@id int
)

AS
BEGIN
	SELECT dbo.Users.ID, dbo.Users.FistName, dbo.Users.LastName, dbo.Users.Birthday
	FROM dbo.Users
	WHERE dbo.Users.ID = @id
END
GO

CREATE PROCEDURE GetAwards

AS
BEGIN
	SELECT *
	FROM dbo.Awards

END
GO

CREATE PROCEDURE GetAward
(
	@ID int
)
AS
BEGIN
	SELECT *
	FROM dbo.Awards
	WHERE @ID = ID
END
GO

CREATE PROCEDURE GetUsersAwards
(
	@ID int
)
AS
BEGIN
	SELECT dbo.Awards.Id, dbo.Awards.Title, dbo.Awards.Discription
	FROM dbo.Relations join dbo.Awards on dbo.Relations.IDAwards =  dbo.Awards.Id
	WHERE IDUser = @ID
END
GO

CREATE PROCEDURE GetUsersId
AS
BEGIN
	SELECT dbo.Users.ID
	FROM dbo.Users
END
GO


CREATE PROCEDURE RemoveUser
(
	@id int
)

AS
BEGIN
	DELETE 
	FROM dbo.Users
	WHERE ID = @id
END
GO

CREATE PROCEDURE UpdateUser
(
	@id int,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@birthday DATE
)

AS
BEGIN
	UPDATE dbo.Users
	SET [FistName] = @firstName,[LastName] = @lastName, [Birthday] = @birthday
	FROM dbo.Users
	WHERE ID = @id

	DELETE 
	FROM dbo.Relations
	WHERE dbo.Relations.IDUser = @id
END
GO

CREATE PROCEDURE RemoveAward
(
	@id int
)

AS
BEGIN
	DELETE 
	FROM dbo.Awards
	WHERE ID = @id
END

GO

CREATE PROCEDURE UpdateAward
(
	@id int,
    @title nvarchar(50),
	@description nvarchar(250)
)

AS
BEGIN
	UPDATE dbo.Awards
	SET [Title] = @title, [Discription] = @description
	FROM dbo.Awards
	WHERE ID = @id
END
GO
CREATE PROCEDURE SetUserAward
(
	@idAward int,
	@idUser int
)
AS
BEGIN
INSERT INTO dbo.Relations
VALUES (@idAward, @idUser)
END
GO 
