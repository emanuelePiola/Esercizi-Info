drop table [dbo].[Auto]

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

INSERT INTO auto (targa, cilindrata, prezzo, marca, modello, colore, alimentazione)
VALUES
    ('GF236WT', 2993, 220000.00, 'BMW', 'M4 CSL', 'Gray', 'Benzina'),
    ('GF237WT', 2993, 120000.00, 'BMW', 'M4 competition', 'Blue', 'Benzina'),
    ('GF238WT', 2993, 220000.00, 'BMW', 'M4 CSL', 'Red', 'Benzina'),
    ('GF239WT', 3996, 200000.00, 'Porsche', '911 GT3', 'Green', 'Benzina'),
    ('GF240WT', 2993, 120000.00, 'BMW', 'M4 competition', 'Green', 'Benzina');
