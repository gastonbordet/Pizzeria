CREATE TRIGGER updateStockPizza
ON Pizzas
AFTER UPDATE
AS
UPDATE Stock
SET
IdProducto = IdProducto,
Nombre = INSERTED.Nombre
FROM INSERTED
RETURN
