CREATE TABLE [dbo].[Cita] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Paterno]         NVARCHAR (100) NULL,
    [Materno]         NVARCHAR (100) NULL,
    [Nombres]         NVARCHAR (100) NULL,
    [NumeroDocumento] INT            NULL,
    [Correo]          NVARCHAR (100) NULL,
    [Teléfono]        NVARCHAR (100) NULL,
    [FechaYHora]      DATETIME       NULL,
    [UsuarioId]       INT            NULL,
    CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Cita_Usuario] FOREIGN KEY ([UsuarioId]) REFERENCES [dbo].[Usuario] ([Id])
);

