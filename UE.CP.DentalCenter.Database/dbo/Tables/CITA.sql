CREATE TABLE [dbo].[CITA]
(
	[idCita] INT NOT NULL ,
	[idPaciente] int,
	[idMedico] int,
	[estado] NVARCHAR(30),
	[fecha] date,
	CONSTRAINT [PK_CITA] PRIMARY KEY CLUSTERED ([idCita] ASC), 
    CONSTRAINT [FK_CITA_PACIENTE] FOREIGN KEY ([idPaciente]) REFERENCES [PACIENTE]([idPaciente]), 
    CONSTRAINT [FK_CITA_MEDICO] FOREIGN KEY ([idMedico]) REFERENCES [CAB_MEDICO]([idMedico]),
)
