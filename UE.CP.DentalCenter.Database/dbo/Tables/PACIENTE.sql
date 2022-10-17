CREATE TABLE [dbo].[PACIENTE]
(
	[idPaciente] INT ,
	[nombre] NVARCHAR(20),
	[apellido] NVARCHAR(20),
	[dni] int,
	[fechaDeNac] date,
	[telefono] NVARCHAR(18),
	[correo] NVARCHAR(40),
	CONSTRAINT [PK_PACIENTE] PRIMARY KEY CLUSTERED ([idPaciente] ASC),
)
