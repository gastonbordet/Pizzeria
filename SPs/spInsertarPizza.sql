CREATE PROCEDURE spInsertarPizza
(
@IDPIZZA char(6),
@NOMBRE char(25),
@PRECIO float
)
AS
INSERT INTO Pizzas
(
IdPizza,
Nombre,
Precio
) 
VALUES
(
@IDPIZZA,
@NOMBRE,
@PRECIO
)
RETURN