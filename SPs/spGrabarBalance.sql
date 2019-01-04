CREATE PROCEDURE spGrabarBalance 
(
@MONTO float,
@DIA int,
@MES int,
@AÑO int,
@TIPO int
)
AS INSERT INTO Balance
(
Monto,
Dia,
Mes,
Año,
Tipo
)
VALUES
(
@MONTO,
@DIA,
@MES,
@AÑO,
@TIPO
)
RETURN