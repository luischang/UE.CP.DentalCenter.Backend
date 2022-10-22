CREATE TABLE [dbo].[DET_RECETA_MEDICA]
(
	[idDetRecetaMedica] int NOT NULL,
	[idMedicamento] INT,
	[dosis] float,
	[unidadMedida] NVARCHAR(10),
	[descripcion] VARCHAR(100),
    CONSTRAINT [FK_DET_RECETA_MEDICA_MEDICAMENTO] FOREIGN KEY ([idMedicamento]) REFERENCES [MEDICAMENTO]([idMedicamento]), 
    CONSTRAINT [PK_DET_RECETA_MEDICA] PRIMARY KEY ([idDetRecetaMedica]),
)
