CREATE TABLE [dbo].[Login]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY,
	[Usuario] nvarchar(50) NOT NULL,
	Contraseña nvarchar(50) NOT NULL, 
    [idMedico] INT NOT NULL,
	CONSTRAINT [FK_IdMedico] FOREIGN KEY ([idMedico]) REFERENCES [CAB_MEDICO]([idMedico]),

)
