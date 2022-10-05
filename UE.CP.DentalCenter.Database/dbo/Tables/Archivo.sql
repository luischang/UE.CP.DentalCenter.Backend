CREATE TABLE [dbo].[Archivo] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [HistoriaClinicaId] INT            NULL,
    [Nombre]            NVARCHAR (200) NULL,
    [Formato]           NVARCHAR (10)  NULL,
    CONSTRAINT [PK_Archivo] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Archivo_HistoriaClinica] FOREIGN KEY ([HistoriaClinicaId]) REFERENCES [dbo].[HistoriaClinica] ([Id])
);

