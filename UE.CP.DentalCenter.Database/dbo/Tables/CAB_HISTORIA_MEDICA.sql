﻿CREATE TABLE [dbo].[CAB_HISTORIA_MEDICA]
(
	[idHistoriaMedica] INT NOT NULL ,
	[idDetHistoriaMedica] INT,
	[idPaciente] int,
	[fechaDeActualizacion] date,
	CONSTRAINT [PK_HISTORIA_MEDICA] PRIMARY KEY CLUSTERED ([idHistoriaMedica] ASC), 
    CONSTRAINT [FK_CAB_HISTORIA_MEDICA_DET_HISTORIA_MEDICA] FOREIGN KEY ([idPaciente]) REFERENCES [PACIENTE]([idPaciente]),
	CONSTRAINT [FK_DET_HISTORIA_MEDICA] FOREIGN KEY ([idDetHistoriaMedica]) REFERENCES [DET_HISTORIA_MEDICA]([idDetHistoriaMedica])
)
