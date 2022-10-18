CREATE TABLE [dbo].[CAB_RECETA_MEDICA]
(
	[idRecetaMedica] INT NOT NULL ,
	[nombreDeClinica] NVARCHAR(30),
	[fecha] date,
	CONSTRAINT [PK_CAB_RECETA_MEDICA] PRIMARY KEY CLUSTERED ([idRecetaMedica] ASC) 

)
