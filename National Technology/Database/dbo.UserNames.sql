CREATE TABLE [dbo].[Table]
(
	[UserID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Password] INT NOT NULL, 
    [Fullname] NVARCHAR(50) NOT NULL, 
    [UserName] NVARCHAR(50) NOT NULL
)
