CREATE PROCEDURE spInsertarDetallePedido 
(
@IDPEDIDO char(6),
@NOMBRE char(25),
@CANTIDAD int,
@PRECIO float
)
AS
INSERT INTO Detalles_Pedido
(
IdPedido,
Nombre,
Cantidad,
Precio
)
VALUES 
(
@IDPEDIDO,
@NOMBRE,
@CANTIDAD,
@PRECIO
)
RETURN 