CREATE TABLE [dbo].[Auto]
(
	[targa] VARCHAR(7) NOT NULL PRIMARY KEY, 
    [cilindrata] INT NOT NULL, 
    [prezzo] DECIMAL(8, 2) NULL, 
	[marca] VARCHAR(50) NULL, 
    [modello] VARCHAR(50) NOT NULL, 
    [colore] VARCHAR(50) NOT NULL, 
    [alimentazione] VARCHAR(50) NOT NULL
)
