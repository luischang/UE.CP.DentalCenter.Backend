CREATE TABLE [dbo].[TRATAMIENTO]
(
	[idTratamiento] INT ,
	[tipo] NVARCHAR(40),
	[duracionDias] int,
	[precio] FLOAT,
	[descripcion] NVARCHAR(40),
	CONSTRAINT [PK_TRATAMIENTO] PRIMARY KEY CLUSTERED ([idTratamiento] ASC),
)
