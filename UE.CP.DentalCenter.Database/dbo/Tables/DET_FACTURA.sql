CREATE TABLE [dbo].[DET_FACTURA]
(
	[idFactura] INT NOT NULL,
	[idTratamiento] int,
	[idRecetaMedica] int,
	[precio] float,
    CONSTRAINT [FK_DET_FACTURA_TRATAMIENTO] FOREIGN KEY ([idTratamiento]) REFERENCES [TRATAMIENTO]([idTratamiento]), 
    CONSTRAINT [FK_DET_FACTURA_CAB_FACTURA] FOREIGN KEY ([idFactura]) REFERENCES [CAB_FACTURA]([idFactura]), 
    CONSTRAINT [FK_DET_FACTURA_CAB_RECETA] FOREIGN KEY ([idRecetaMedica]) REFERENCES [CAB_RECETA_MEDICA]([idRecetaMedica]),
)
