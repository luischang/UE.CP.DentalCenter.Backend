CREATE TABLE [dbo].[HistoriaClinica] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [UsuarioPacienteId] INT            NULL,
    [UsuarioMedicoId]   INT            NULL,
    [FechaAtencion]     DATETIME       NULL,
    [Observacion]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_HistoriaClinica] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_HistoriaClinica_Usuario] FOREIGN KEY ([UsuarioPacienteId]) REFERENCES [dbo].[Usuario] ([Id]),
    CONSTRAINT [FK_HistoriaClinica_Usuario1] FOREIGN KEY ([UsuarioMedicoId]) REFERENCES [dbo].[Usuario] ([Id])
);

