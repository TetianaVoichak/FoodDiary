CREATE TABLE [dbo].[IngredientDB]
(
	[Id] INT NOT NULL , 
    [Name] NVARCHAR(50) NOT NULL, 
    [Protein] REAL NULL, 
    [Fat] REAL NULL, 
    [Carbohydrate] REAL NULL, 
    [EnergyValue] INT NULL, 
    PRIMARY KEY ([Id], [Name])
)
