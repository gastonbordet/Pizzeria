CREATE PROCEDURE spActualizarBebida
(
@IDBEBIDA char(6),
@NOMBRE char(25),
@PRECIO float,
@ALCOHOL char(3)
)
AS
UPDATE Bebidas
SET
IdBebida = @IDBEBIDA,
Nombre = @NOMBRE,
Precio = @PRECIO,
Alcohol = @ALCOHOL
WHERE
IdBebida = @IDBEBIDA
RETURN