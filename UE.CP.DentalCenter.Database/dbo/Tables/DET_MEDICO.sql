CREATE TABLE [dbo].[DET_MEDICO](
    [idMedico]   INT,
    [especialidad]  NVARCHAR (20), 
    CONSTRAINT [FK_DET_MEDICO_CAB_MEDICO] FOREIGN KEY ([idMedico]) REFERENCES [CAB_MEDICO]([idMedico]),
);