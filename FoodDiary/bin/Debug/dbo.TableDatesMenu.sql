CREATE TABLE [dbo].[TableDatesMenu]
(
	[IdDate] INT NOT NULL PRIMARY KEY, 
    [MaxCalories] INT NULL, 
    [MaxProtein] INT NULL, 
    [MaxFat] INT NULL, 
    [MaxCarbo] INT NULL, 
    [Date] DATETIME NOT NULL, 
    [IdRepastes] INT NULL
)
