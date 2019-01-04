CREATE TRIGGER createStockBebida
ON Bebidas
AFTER INSERT
AS
INSERT INTO Stock (Idproducto, Nombre, Cantidad)
SELECT IdBebida, Nombre, 0
FROM INSERTED
RETURN
