CREATE TABLE [dbo].[CAB_RECETA_MEDICA]
(
	[idRecetaMedica] INT NOT NULL ,
	[idDetRecetaMedica] INT,
	[nombreDeClinica] NVARCHAR(30),
	[fecha] date,
	CONSTRAINT [PK_CAB_RECETA_MEDICA] PRIMARY KEY CLUSTERED ([idRecetaMedica] ASC),
	CONSTRAINT [FK_CAB_RECETA_MEDICA] FOREIGN KEY ([idDetRecetaMedica]) REFERENCES [DET_RECETA_MEDICA]([idDetRecetaMedica])

)
