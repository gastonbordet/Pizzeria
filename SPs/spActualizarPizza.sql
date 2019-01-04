CREATE PROCEDURE spActualizarPizza
(
@IDPIZZA char(6),
@NOMBRE char(25),
@PRECIO float
)
AS
UPDATE Pizzas
SET
IdPizza = @IDPIZZA,
Nombre = @NOMBRE,
Precio = @PRECIO
WHERE 
IdPizza = @IDPIZZA
RETURN