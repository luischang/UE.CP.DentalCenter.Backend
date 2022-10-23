CREATE TABLE [dbo].[ESPECIALIDAD]
(
	[idEspecialidad] int IDENTITY not null,
	[descripcion] nvarchar(50), 
    CONSTRAINT [PK_ESPECIALIDAD] PRIMARY KEY ([idEspecialidad]),
)
