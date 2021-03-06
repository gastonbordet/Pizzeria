USE Master
GO
CREATE database Pizzeria
ON
(NAME = 'Pizzeria', FILENAME = 'c:\Pizzeria')
GO
USE Pizzeria
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stock](
	[IdProducto] [char](6) NOT NULL,
	[Nombre] [char](25) NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Stock] ([IdProducto], [Nombre], [Cantidad]) VALUES (N'agu002', N'Agua mineral             ', 99)
INSERT [dbo].[Stock] ([IdProducto], [Nombre], [Cantidad]) VALUES (N'muz001', N'Muzzarella               ', 97)
INSERT [dbo].[Stock] ([IdProducto], [Nombre], [Cantidad]) VALUES (N'nap002', N'Napolitana               ', 100)
INSERT [dbo].[Stock] ([IdProducto], [Nombre], [Cantidad]) VALUES (N'qui001', N'Cerveza Quilmes          ', 100)
/****** Object:  Table [dbo].[Balance]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Balance](
	[Monto] [money] NULL,
	[Dia] [int] NULL,
	[Mes] [int] NULL,
	[Año] [int] NULL,
	[Tipo] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (5000.0000, 6, 12, 2018, -1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (0.0000, 6, 12, 2018, -1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (7500.0000, 6, 12, 2018, -1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (100.0000, 6, 12, 2018, 1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (200.0000, 7, 12, 2018, 1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (40.0000, 8, 12, 2018, -1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (200.0000, 8, 12, 2018, 1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (150.0000, 8, 12, 2018, 1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (300.0000, 8, 12, 2018, 1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (100.0000, 8, 12, 2018, 1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (230.0000, 8, 12, 2018, 1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (380.0000, 8, 12, 2018, 1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (4000.0000, 6, 12, 2018, -1)
INSERT [dbo].[Balance] ([Monto], [Dia], [Mes], [Año], [Tipo]) VALUES (100.0000, 6, 12, 2018, 1)
/****** Object:  Table [dbo].[Pedidos_Local]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedidos_Local](
	[IdPedidoLocal] [char](6) NOT NULL,
	[Cliente] [char](25) NULL,
	[Mesa] [int] NULL,
	[IdEmpleado] [char](6) NULL,
	[Facturado] [int] NULL,
 CONSTRAINT [PK_Pedidos_Local] PRIMARY KEY CLUSTERED 
(
	[IdPedidoLocal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Pedidos_Local] ([IdPedidoLocal], [Cliente], [Mesa], [IdEmpleado], [Facturado]) VALUES (N'5     ', N'Adrian                   ', 3, N'gon001', 1)
INSERT [dbo].[Pedidos_Local] ([IdPedidoLocal], [Cliente], [Mesa], [IdEmpleado], [Facturado]) VALUES (N'6     ', N'gonzalo                  ', 6, N'gon001', 1)
INSERT [dbo].[Pedidos_Local] ([IdPedidoLocal], [Cliente], [Mesa], [IdEmpleado], [Facturado]) VALUES (N'8     ', N'Alfredo                  ', 8, N'gon001', 1)
INSERT [dbo].[Pedidos_Local] ([IdPedidoLocal], [Cliente], [Mesa], [IdEmpleado], [Facturado]) VALUES (N'ped001', N'Gaston                   ', 1, N'gon001', 1)
INSERT [dbo].[Pedidos_Local] ([IdPedidoLocal], [Cliente], [Mesa], [IdEmpleado], [Facturado]) VALUES (N'ped002', N'Pedro                    ', 2, N'gon001', 1)
INSERT [dbo].[Pedidos_Local] ([IdPedidoLocal], [Cliente], [Mesa], [IdEmpleado], [Facturado]) VALUES (N'ped004', N'Gonzalo                  ', 8, N'gon001', 1)
INSERT [dbo].[Pedidos_Local] ([IdPedidoLocal], [Cliente], [Mesa], [IdEmpleado], [Facturado]) VALUES (N'ped005', N'Adrian                   ', 5, N'Lucas ', 1)
/****** Object:  Table [dbo].[Pedidos_Delivery]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pedidos_Delivery](
	[IdPedidoDelivery] [char](6) NOT NULL,
	[Cliente] [char](25) NULL,
	[Telefono] [int] NULL,
	[Direccion] [char](25) NULL,
	[IdEmpleado] [char](6) NOT NULL,
	[Facturado] [int] NULL,
 CONSTRAINT [PK_Pedidos_Delivery] PRIMARY KEY CLUSTERED 
(
	[IdPedidoDelivery] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Pedidos_Delivery] ([IdPedidoDelivery], [Cliente], [Telefono], [Direccion], [IdEmpleado], [Facturado]) VALUES (N'7     ', N'federico                 ', 123123, N'adwad                    ', N'gon001', 1)
INSERT [dbo].[Pedidos_Delivery] ([IdPedidoDelivery], [Cliente], [Telefono], [Direccion], [IdEmpleado], [Facturado]) VALUES (N'ped003', N'Franco                   ', 111, N'asd                      ', N'gon001', 1)
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [char](6) NOT NULL,
	[Nombre] [char](25) NULL,
	[Puesto] [char](25) NULL,
	[Sueldo] [money] NULL,
	[Horas] [int] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Empleados] ([IdEmpleado], [Nombre], [Puesto], [Sueldo], [Horas]) VALUES (N'gon001', N'Lucas Gonzalez           ', N'Repartidor               ', 8000.0000, 80)
/****** Object:  Table [dbo].[Detalles_Pedido]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalles_Pedido](
	[IdPedido] [char](6) NOT NULL,
	[NombreProducto] [char](25) NOT NULL,
	[Cantidad] [int] NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_Detalles_Pedido] PRIMARY KEY CLUSTERED 
(
	[IdPedido] ASC,
	[NombreProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'5     ', N'Cerveza Quilmes          ', 1, 80.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'5     ', N'Napolitana               ', 1, 150.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'6     ', N'Muzzarella               ', 1, 100.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'7     ', N'Muzzarella               ', 2, 100.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'8     ', N'Agua mineral             ', 1, 80.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'8     ', N'Muzzarella               ', 3, 100.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'ped001', N'Muzzarella               ', 2, 100.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'ped002', N'Napolitana               ', 1, 150.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'ped003', N'Muzzarella               ', 1, 100.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'ped004', N'Muzzarella               ', 1, 100.0000)
INSERT [dbo].[Detalles_Pedido] ([IdPedido], [NombreProducto], [Cantidad], [Precio]) VALUES (N'ped005', N'Napolitana               ', 2, 150.0000)
/****** Object:  Table [dbo].[Pizzas]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pizzas](
	[IdPizza] [char](6) NOT NULL,
	[Nombre] [char](25) NULL,
	[Precio] [money] NULL,
 CONSTRAINT [PK_Pizzas] PRIMARY KEY CLUSTERED 
(
	[IdPizza] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Pizzas] ([IdPizza], [Nombre], [Precio]) VALUES (N'muz001', N'Muzzarella               ', 100.0000)
INSERT [dbo].[Pizzas] ([IdPizza], [Nombre], [Precio]) VALUES (N'nap002', N'Napolitana               ', 150.0000)
/****** Object:  Table [dbo].[Bebidas]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bebidas](
	[IdBebida] [char](6) NOT NULL,
	[Nombre] [char](25) NULL,
	[Precio] [money] NULL,
	[Alcohol] [char](3) NULL,
 CONSTRAINT [PK_Bebidas] PRIMARY KEY CLUSTERED 
(
	[IdBebida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Bebidas] ([IdBebida], [Nombre], [Precio], [Alcohol]) VALUES (N'agu002', N'Agua mineral             ', 80.0000, N'no ')
INSERT [dbo].[Bebidas] ([IdBebida], [Nombre], [Precio], [Alcohol]) VALUES (N'qui001', N'Cerveza Quilmes          ', 80.0000, N'si ')
/****** Object:  StoredProcedure [dbo].[spActualizarEmpleado]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spActualizarEmpleado]
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
GO
/****** Object:  StoredProcedure [dbo].[spActualizarStock]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spActualizarStock] 
(
@NOMBRE char(25),
@CANTIDAD int
)
AS
UPDATE Stock
SET
Cantidad = @CANTIDAD
WHERE Nombre = @NOMBRE
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spEliminarEmpleado]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarEmpleado]
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
GO
/****** Object:  StoredProcedure [dbo].[spPagarPedido]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spPagarPedido]
(
@IDPEDIDOLOCAL char(6)
)
AS
UPDATE Pedidos_Local
SET
Facturado = 1
WHERE IdPedidoLocal = @IDPEDIDOLOCAL
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPedidoLocal]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarPedidoLocal]
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
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPedidoDelivery]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarPedidoDelivery] 
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
GO
/****** Object:  StoredProcedure [dbo].[spInsertarEmpleado]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarEmpleado] 
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
GO
/****** Object:  StoredProcedure [dbo].[spInsertarDetallePedido]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarDetallePedido] 
(
@IDPEDIDO char(6),
@NOMBREPRODUCTO char(25),
@CANTIDAD int,
@PRECIO float
)
AS
INSERT INTO Detalles_Pedido
(
IdPedido,
NombreProducto,
Cantidad,
Precio
)
VALUES 
(
@IDPEDIDO,
@NOMBREPRODUCTO,
@CANTIDAD,
@PRECIO
)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spGrabarBalance]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGrabarBalance] 
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
GO
/****** Object:  Trigger [updateStockPizza]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[updateStockPizza]
ON [dbo].[Pizzas]
AFTER UPDATE
AS
UPDATE Stock
SET
IdProducto = IdProducto,
Nombre = INSERTED.Nombre
FROM INSERTED
RETURN
GO
/****** Object:  Trigger [updateStockBebida]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[updateStockBebida]
ON [dbo].[Bebidas]
AFTER UPDATE
AS
UPDATE Stock
SET
IdProducto = IdBebida,
Nombre = INSERTED.Nombre
FROM INSERTED
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spEliminarPizza]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarPizza]
(
@IDPIZZA char(6),
@NOMBRE char(25),
@PRECIO float
)
AS
DELETE FROM Pizzas
WHERE IdPizza = @IDPIZZA
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarBebida]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarBebida]
(
@IDBEBIDA char(6),
@NOMBRE char(25),
@PRECIO float,
@ALCOHOL char(6)
)
AS
INSERT INTO Bebidas
(
IdBebida,
Nombre,
Precio,
Alcohol
) 
VALUES
(
@IDBEBIDA,
@NOMBRE,
@PRECIO,
@ALCOHOL
)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPizza]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarPizza]
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
GO
/****** Object:  StoredProcedure [dbo].[spEliminarBebida]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEliminarBebida]
(
@IDBEBIDA char(6),
@NOMBRE char(25),
@PRECIO float,
@ALCOHOL char(3)
)
AS
DELETE FROM Bebidas
WHERE IdBebida = @IDBEBIDA
RETURN
GO
/****** Object:  StoredProcedure [dbo].[spActualizarPizza]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spActualizarPizza]
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
GO
/****** Object:  StoredProcedure [dbo].[spActualizarBebida]    Script Date: 12/08/2018 13:06:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spActualizarBebida]
(
@IDBEBIDA char(6),
@NOMBRE char(25),
@PRECIO float,
@ALCOHOL char(3)
)
AS
UPDATE Bebidas
SET
IdBebida = @IDBEBIDA,
Nombre = @NOMBRE,
Precio = @PRECIO,
Alcohol = @ALCOHOL
WHERE
IdBebida = @IDBEBIDA
RETURN
GO
/****** Object:  Trigger [deleteStockPizza]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[deleteStockPizza]
ON [dbo].[Pizzas]
FOR DELETE
AS
DELETE FROM Stock WHERE IdProducto = (SELECT DELETED.IdPizza FROM DELETED)
RETURN
GO
/****** Object:  Trigger [deleteStockBebida]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[deleteStockBebida]
ON [dbo].[Bebidas]
FOR DELETE
AS
DELETE FROM Stock WHERE IdProducto = (SELECT DELETED.IdBebida FROM DELETED)
RETURN
GO
/****** Object:  Trigger [createStockPizza]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[createStockPizza]
ON [dbo].[Pizzas]
AFTER INSERT
AS
INSERT INTO Stock (Idproducto, Nombre, Cantidad)
SELECT IdPizza, Nombre, 0
FROM INSERTED
RETURN
GO
/****** Object:  Trigger [createStockBebida]    Script Date: 12/08/2018 13:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[createStockBebida]
ON [dbo].[Bebidas]
AFTER INSERT
AS
INSERT INTO Stock (Idproducto, Nombre, Cantidad)
SELECT IdBebida, Nombre, 0
FROM INSERTED
RETURN
GO
