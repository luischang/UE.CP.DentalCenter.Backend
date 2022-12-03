CREATE TABLE [dbo].[Login] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Usuario]    NVARCHAR (50) NOT NULL,
    [Contraseña] NVARCHAR (50) NOT NULL,
    [idMedico]   INT           NULL,
    [idPaciente] INT           NULL,
    [idAsistente] INT           NULL,
    [Tipo]       NVARCHAR (15) NULL,
    CONSTRAINT [PK__Login__3214EC07EBAE25E7] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_IdMedico] FOREIGN KEY ([idMedico]) REFERENCES [dbo].[CAB_MEDICO] ([idMedico]),
    CONSTRAINT [FK_Login_PACIENTE] FOREIGN KEY ([idPaciente]) REFERENCES [dbo].[PACIENTE] ([idPaciente]), 
    CONSTRAINT [FK_Login_PersonalAdm] FOREIGN KEY ([idAsistente]) REFERENCES [dbo].[PERSONAL_ADM]([idAsistente])
);


