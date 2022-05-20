CREATE TABLE [dbo].[Car]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[Name] Varchar (50) NOT NULL, 
	[Model] Varchar (50) NOT NULL,
	[Company] Varchar (50) NOT NULL,
	[Age] Int NOT NULL,
	[CreateDate] DATETIME NOT NULL, 
	CONSTRAINT [PK_CAR] PRIMARY KEY CLUSTERED ([Id] ASC)
)
