CREATE TABLE [dbo].[peliculas] (
    [IdPelicula]    INT        IDENTITY (1, 1) NOT NULL,
    [titulo]        CHAR (100) NOT NULL,
    [autor]         CHAR (50)  NOT NULL,
    [sinopsis]      CHAR (300) NULL,
    [duracion]      CHAR (50)  NULL,
    [clasificacion] CHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([IdPelicula] ASC)
);

