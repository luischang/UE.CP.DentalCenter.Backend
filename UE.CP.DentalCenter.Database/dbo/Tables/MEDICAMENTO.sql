CREATE TABLE [dbo].[MEDICAMENTO]
(
	[idMedicamento] INT IDENTITY PRIMARY KEY NOT NULL,
	[nombre] NVARCHAR(40),
	[tipo] NVARCHAR(40),
	[precio] float,
)
