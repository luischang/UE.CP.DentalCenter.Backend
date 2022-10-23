CREATE TABLE [dbo].[HORARIO_DISPONIBLE]
(
	[idHorarioDisponible] int identity not null,
	[idMedico] INT NOT NULL,
	[dia] date,
	[horaIni] time,
	[horaFin] time,
	[estado] int, 
    CONSTRAINT [FK_HORARIO_DISPONIBLE_CAB_MEDICO] FOREIGN KEY ([idMedico]) REFERENCES [CAB_MEDICO]([idMedico]),
)
