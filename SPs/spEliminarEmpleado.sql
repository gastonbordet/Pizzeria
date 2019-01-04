USE [Pizzeria]
GO
/****** Object:  StoredProcedure [dbo].[spEliminarEmpleado]    Script Date: 11/30/2018 14:26:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spEliminarEmpleado]
(
@IDEMPLEADO char(6),
@NOMBRE char(25),
@PUESTO char(25),
@SUELDO float,
@HORAS int
)
AS
DELETE FROM Empleados
WHERE IdEmpleado = @IDEMPLEADO
RETURN
