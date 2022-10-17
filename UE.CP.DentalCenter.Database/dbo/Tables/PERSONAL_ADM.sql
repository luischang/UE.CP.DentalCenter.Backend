CREATE TABLE [dbo].[PERSONAL_ADM]
(
	[idAsistente] INT ,
	[nombre] NVARCHAR(20),
	[apellido] NVARCHAR(20),
	[dni] int,
	[rol] NVARCHAR(20),
	CONSTRAINT [PK_PERSONAL_ADM] PRIMARY KEY CLUSTERED ([idAsistente] ASC),
)
