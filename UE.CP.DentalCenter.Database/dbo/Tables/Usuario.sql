CREATE TABLE [dbo].[Usuario] (
    [Id]              INT            NOT NULL,
    [Paterno]         NVARCHAR (100) NULL,
    [Materno]         NVARCHAR (100) NULL,
    [Nombres]         NVARCHAR (100) NULL,
    [NumeroDocumento] INT            NULL,
    [Correo]          NVARCHAR (100) NULL,
    [Direccion]       NVARCHAR (100) NULL,
    [Teléfono]        NVARCHAR (100) NULL,
    [TipoUsuario]     NVARCHAR (50)  NULL,
    [Contrasena]      NVARCHAR (100) NULL,
    [Estado] NCHAR(5) NULL, 
    CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED ([Id] ASC)
);

