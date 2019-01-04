CREATE TRIGGER updateStockBebida
ON Bebidas
AFTER UPDATE
AS
UPDATE Stock
SET
IdProducto = IdProducto,
Nombre = INSERTED.Nombre
FROM INSERTED
RETURN
