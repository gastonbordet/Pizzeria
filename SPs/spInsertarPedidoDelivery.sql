CREATE PROCEDURE spInsertarPedidoDelivery 
(
@IDPEDIDODELIVERY char(6),
@CLIENTE char(25),
@TELEFONO int,
@DIRECCION char(25),
@IDEMPLEADO char(6),
@FACTURADO int
)
AS INSERT INTO Pedidos_Delivery
(
IdPedidoDelivery,
Cliente,
Telefono,
Direccion,
IdEmpleado,
Facturado
)
VALUES
(
@IDPEDIDODELIVERY,
@CLIENTE,
@TELEFONO,
@DIRECCION,
@IDEMPLEADO,
@FACTURADO
)
RETURN