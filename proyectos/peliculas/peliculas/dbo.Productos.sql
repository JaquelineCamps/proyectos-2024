CREATE TABLE [dbo].[Productos] (
    [IdProducto]   INT             IDENTITY (1, 1) NOT NULL,
    [codigo]       CHAR (50)       NOT NULL,
    [nombre]       CHAR (100)      NOT NULL,
    [marca]        CHAR (50)       NOT NULL,
    [presentacion] CHAR (100)      NOT NULL,
    [precio]       DECIMAL (10, 2) NULL,
    [stock]        CHAR (100)      NULL,
    PRIMARY KEY CLUSTERED ([IdProducto] ASC)
);

