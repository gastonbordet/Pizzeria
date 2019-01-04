CREATE PROCEDURE spEliminarBebida
(
@IDBEBIDA char(6),
@NOMBRE char(25),
@PRECIO float,
@ALCOHOL char(3)
)
AS
DELETE FROM Bebidas
WHERE IdBebida = @IDBEBIDA
RETURN
