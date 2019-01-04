CREATE PROCEDURE spActualizarEmpleado
(
@IDEMPLEADO char(6),
@NOMBRE char(25),
@PUESTO char(25),
@SUELDO float,
@HORAS int
)
AS
UPDATE Empleados
SET
IdEmpleado = @IDEMPLEADO,
Nombre = @NOMBRE,
Puesto = @PUESTO,
Sueldo = @SUELDO,
Horas = @HORAS
WHERE 
IdEmpleado = @IDEMPLEADO
RETURN