CREATE TABLE [dbo].[CAB_MEDICO](
    [idMedico]   INT,
    [idDetMedico] INT,
    [nombre]  NVARCHAR (20),
    [apellido]  NVARCHAR (20),
    [genero]  NVARCHAR (10),
    CONSTRAINT [PK_CAB_MEDICO] PRIMARY KEY CLUSTERED ([idMedico] ASC),
    CONSTRAINT [FK_CAB_MEDICO] FOREIGN KEY ([idDetMedico]) REFERENCES [DET_MEDICO]([idDetMedico])
);