CREATE TABLE [dbo].Booking
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] INT NULL, 
    [User] VARCHAR(50) NULL, 
    [StartDate] DATE NULL, 
    [EndDate] DATE NULL, 
    [TotalPrice] INT NULL, 
    [Car] NCHAR(10) NULL, 
    [CarId] INT NULL
)
