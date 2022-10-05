CREATE TABLE [dbo].[Tratamiento] (
    [Id]                INT             IDENTITY (1, 1) NOT NULL,
    [HistoriaClinicaId] INT             NULL,
    [Descripcion]       NVARCHAR (MAX)  NULL,
    [Material]          NVARCHAR (MAX)  NULL,
    [Presupuesto]       DECIMAL (18, 2) NULL,
    [Observaciones]     NVARCHAR (MAX)  NULL,
    CONSTRAINT [PK_Tratamiento] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Tratamiento_HistoriaClinica1] FOREIGN KEY ([HistoriaClinicaId]) REFERENCES [dbo].[HistoriaClinica] ([Id])
);

