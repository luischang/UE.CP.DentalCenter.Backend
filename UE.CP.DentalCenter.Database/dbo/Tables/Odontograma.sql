CREATE TABLE [dbo].[Odontograma] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [UsuarioId]    INT           NULL,
    [NumeroDiente] INT           NULL,
    [Descripcion]  NVARCHAR (50) NULL,
    CONSTRAINT [PK_Odontograma] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Odontograma_Usuario] FOREIGN KEY ([UsuarioId]) REFERENCES [dbo].[Usuario] ([Id])
);

