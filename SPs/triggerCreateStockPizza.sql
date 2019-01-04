CREATE TRIGGER createStockPizza
ON Pizzas
AFTER INSERT
AS
INSERT INTO Stock (Idproducto, Nombre, Cantidad)
SELECT IdPizza, Nombre, 0
FROM INSERTED
RETURN
