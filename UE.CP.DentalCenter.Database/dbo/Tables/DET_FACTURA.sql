CREATE TABLE [dbo].[DET_FACTURA]
(
	[idDetFactura] INT NOT NULL,
	[idTratamiento] int NULL,
	[idRecetaMedica] int NULL,
	[precio] float,
    CONSTRAINT [FK_DET_FACTURA_TRATAMIENTO] FOREIGN KEY ([idTratamiento]) REFERENCES [TRATAMIENTO]([idTratamiento]), 
    CONSTRAINT [FK_DET_FACTURA_CAB_RECETA] FOREIGN KEY ([idRecetaMedica]) REFERENCES [CAB_RECETA_MEDICA]([idRecetaMedica]), 
    CONSTRAINT [PK_DET_FACTURA] PRIMARY KEY ([idDetFactura]),
)
