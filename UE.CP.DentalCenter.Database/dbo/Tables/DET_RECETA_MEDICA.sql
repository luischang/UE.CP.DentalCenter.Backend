CREATE TABLE [dbo].[DET_RECETA_MEDICA]
(
	[idDetRecetaMedica] int IDENTITY NOT NULL,
	[idRecetaMedica] int not null,
	[idMedicamento] INT,
	[dosis] float,
	[unidadMedida] NVARCHAR(10),
	[descripcion] VARCHAR(100),
    CONSTRAINT [FK_DET_RECETA_MEDICA_MEDICAMENTO] FOREIGN KEY ([idMedicamento]) REFERENCES [MEDICAMENTO]([idMedicamento]), 
    CONSTRAINT [PK_DET_RECETA_MEDICA] PRIMARY KEY ([idDetRecetaMedica]), 
    CONSTRAINT [FK_DET_RECETA_MEDICA_CAB_RECETA_MEDICA}] FOREIGN KEY ([idRecetaMedica]) REFERENCES [CAB_RECETA_MEDICA]([idRecetaMedica]),
)
