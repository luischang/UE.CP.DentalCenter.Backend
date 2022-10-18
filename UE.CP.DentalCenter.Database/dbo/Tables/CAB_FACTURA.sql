CREATE TABLE [dbo].[CAB_FACTURA]
(
	[idFactura] INT NOT NULL,
	[idPaciente] int,
	[idCita] int,
	[fechaHora] datetime,
	[precioTotal] float,
	CONSTRAINT [PK_CAB_FACTURA] PRIMARY KEY CLUSTERED ([idFactura] ASC), 
)
