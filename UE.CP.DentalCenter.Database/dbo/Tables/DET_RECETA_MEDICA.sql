CREATE TABLE [dbo].[DET_RECETA_MEDICA]
(
	[idDetRecetaMedica] INT ,
	[idMedicamento] INT,
	[cantidad] INT,
	[descripcion] VARCHAR(20),
	[precioTotal] float,
	CONSTRAINT [PK_DET_RECETA_MEDICA] PRIMARY KEY CLUSTERED ([idDetRecetaMedica] ASC), 
    CONSTRAINT [FK_DET_RECETA_MEDICA_MEDICAMENTO] FOREIGN KEY ([idMedicamento]) REFERENCES [Medicamento]([idMedicamento]),
)
