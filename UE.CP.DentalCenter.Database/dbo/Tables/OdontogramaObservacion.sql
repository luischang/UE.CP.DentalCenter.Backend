CREATE TABLE [dbo].[OdontogramaObservacion] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [OdontogramaId] INT            NULL,
    [Observacion]   NVARCHAR (MAX) NULL,
    [Estado]        BIT            NULL,
    CONSTRAINT [PK_OdontogramaObservacion] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OdontogramaObservacion_Odontograma] FOREIGN KEY ([OdontogramaId]) REFERENCES [dbo].[Odontograma] ([Id])
);

