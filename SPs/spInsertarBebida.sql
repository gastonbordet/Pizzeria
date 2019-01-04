CREATE PROCEDURE spInsertarBebida
(
@IDBEBIDA char(6),
@NOMBRE char(25),
@PRECIO float,
@ALCOHOL char(6)
)
AS
INSERT INTO Bebidas
(
IdBebida,
Nombre,
Precio,
Alcohol
) 
VALUES
(
@IDBEBIDA,
@NOMBRE,
@PRECIO,
@ALCOHOL
)
RETURN