CREATE PROCEDURE spGrabarBalance 
(
@MONTO float,
@DIA int,
@MES int,
@A�O int,
@TIPO int
)
AS INSERT INTO Balance
(
Monto,
Dia,
Mes,
A�o,
Tipo
)
VALUES
(
@MONTO,
@DIA,
@MES,
@A�O,
@TIPO
)
RETURN