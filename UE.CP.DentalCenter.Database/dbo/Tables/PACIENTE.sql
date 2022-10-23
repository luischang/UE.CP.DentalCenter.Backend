CREATE TABLE [dbo].[PACIENTE]
(
	[idPaciente] INT IDENTITY NOT NULL,
	[nombre] NVARCHAR(20),
	[apellido] NVARCHAR(20),
	[dni] int,
	[fechaDeNac] date,
	[telefono] NVARCHAR(18),
	[correo] NVARCHAR(40),
	[frecuente] bit,
	CONSTRAINT [PK_PACIENTE] PRIMARY KEY CLUSTERED ([idPaciente] ASC),
)
