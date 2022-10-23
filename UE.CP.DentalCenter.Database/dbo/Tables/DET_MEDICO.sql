CREATE TABLE [dbo].[DET_MEDICO](
    [idDetMedico]   INT IDENTITY NOT NULL,
    [idMedico] int Not null,
    [idEspecialidad]  int NOT NULL, 
    CONSTRAINT [PK_DET_MEDICO] PRIMARY KEY ([idDetMedico]), 
    CONSTRAINT [FK_DET_MEDICO_ESPECIALIDAD] FOREIGN KEY ([idEspecialidad]) REFERENCES [ESPECIALIDAD]([idEspecialidad]), 
    CONSTRAINT [FK_DET_MEDICO_CAB_MEDICO] FOREIGN KEY ([idMedico]) REFERENCES [CAB_MEDICO]([idMedico]),
);