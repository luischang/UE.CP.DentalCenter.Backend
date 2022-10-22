CREATE TABLE [dbo].[CAB_FACTURA]
(
	[idFactura] INT NOT NULL,
	[idDetFactura] int,
	[idPaciente] int,
	[idCita] int,
	[fechaHora] datetime,
	[precioTotal] float,
	CONSTRAINT [PK_CAB_FACTURA] PRIMARY KEY CLUSTERED ([idFactura] ASC), 
	CONSTRAINT [FK_DET_FACTURA] FOREIGN KEY ([idDetFactura]) REFERENCES [DET_FACTURA]([idDetFactura])
)
