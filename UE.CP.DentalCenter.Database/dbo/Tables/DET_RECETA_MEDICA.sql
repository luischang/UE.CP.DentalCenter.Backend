CREATE TABLE [dbo].[DET_RECETA_MEDICA]
(
	[idRecetaMedica] int,
	[idMedicamento] INT,
	[dosis] float,
	[unidadMedida] NVARCHAR(10),
	[descripcion] VARCHAR(100),
    CONSTRAINT [FK_DET_RECETA_MEDICA_MEDICAMENTO] FOREIGN KEY ([idMedicamento]) REFERENCES [MEDICAMENTO]([idMedicamento]), 
    CONSTRAINT [FK_DET_RECETA_MEDICA_CAB_RECETA_MEDICA] FOREIGN KEY ([idRecetaMedica]) REFERENCES [CAB_RECETA_MEDICA]([idRecetaMedica]),
)
