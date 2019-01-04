CREATE PROCEDURE spInsertarPedidoLocal
(
@IDPEDIDOLOCAL char(6),
@CLIENTE char(25),
@MESA int,
@IDEMPLEADO char(6),
@FACTURADO int
)
AS
INSERT INTO Pedidos_Local
(
IdPedidoLocal,
Cliente,
Mesa,
IdEmpleado,
Facturado
)
VALUES
(
@IDPEDIDOLOCAL,
@CLIENTE,
@MESA,
@IDEMPLEADO,
@FACTURADO
)
RETURN