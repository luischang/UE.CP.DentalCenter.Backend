CREATE TABLE [dbo].[Receta] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [HistoriaClinicaId] INT            NULL,
    [Medicamento]       NVARCHAR (100) NULL,
    [Cantidad]          INT            NULL,
    [Dosis]             NVARCHAR (50)  NULL,
    [Intervalo]         NVARCHAR (20)  NULL,
    CONSTRAINT [PK_Receta] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Receta_HistoriaClinica] FOREIGN KEY ([HistoriaClinicaId]) REFERENCES [dbo].[HistoriaClinica] ([Id])
);

