CREATE PROCEDURE spInsertarEmpleado 
(
@IDEMPLEADO char(6),
@NOMBRE char(25),
@PUESTO char(25),
@SUELDO float,
@HORAS int
)
AS
INSERT INTO Empleados
(
IdEmpleado,
Nombre,
Puesto,
Sueldo,
Horas
)
VALUES
(
@IDEMPLEADO,
@NOMBRE,
@PUESTO,
@SUELDO,
@HORAS
)
RETURN