CREATE DATABASE Minerva;

USE [master]
GO
CREATE LOGIN [usrminerva] WITH PASSWORD=N'123456', 
   DEFAULT_DATABASE=[Minerva], 
   CHECK_EXPIRATION=OFF, 
   CHECK_POLICY=ON
GO
USE [Minerva]
GO
CREATE USER [usrminerva] FOR LOGIN [usrminerva]
GO
USE [Minerva]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrminerva]
GO

CREATE TABLE Producto (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  codigo VARCHAR(10) NOT NULL,
  descripcion VARCHAR(200) NOT NULL,
  unidadMedida VARCHAR(20) NOT NULL,
  saldo DECIMAL NOT NULL DEFAULT 0,
  precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0)
);
CREATE TABLE Proveedor (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nit VARCHAR(15) NOT NULL,
  razonSocial VARCHAR(120) NOT NULL,
  direccion VARCHAR(250) NOT NULL,
  telefono VARCHAR(20) NOT NULL,
  representante VARCHAR(50) NOT NULL
);
CREATE TABLE Empleado (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  cedulaIdentidad VARCHAR(20) NOT NULL,
  nombre VARCHAR(20) NOT NULL,
  paterno VARCHAR(20) NOT NULL,
  materno VARCHAR(20) NOT NULL,
  direccion VARCHAR(250) NOT NULL,
  celular BIGINT NOT NULL,
  cargo VARCHAR(50) NOT NULL
);
CREATE TABLE Usuario (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  usuario VARCHAR(10) NOT NULL,
  clave VARCHAR(150) NOT NULL,
  idEmpleado INT NOT NULL,
  CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);
CREATE TABLE Compra (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  transaccion INT NOT NULL,
  fecha DATE NOT NULL DEFAULT GETDATE(),
  idProveedor INT NOT NULL,
  CONSTRAINT fk_Compra_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
);
CREATE TABLE CompraDetalle (
  id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  idCompra INT NOT NULL,
  idProducto INT NOT NULL,
  cantidad DECIMAL NOT NULL CHECK(cantidad > 0),
  precioUnitario DECIMAL NOT NULL,
  total DECIMAL NOT NULL,
  CONSTRAINT fk_CompraDetalle_Compra FOREIGN KEY(idCompra) REFERENCES Compra(id),
  CONSTRAINT fk_CompraDetalle_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);

ALTER TABLE dbo.Usuario ADD usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME();
ALTER TABLE dbo.Usuario ADD fechaRegistro DATETIME NULL DEFAULT GETDATE();
ALTER TABLE dbo.Usuario ADD registroActivo BIT NULL DEFAULT 1;

ALTER TABLE dbo.Proveedor ADD usuarioRegistro VARCHAR(100) NULL DEFAULT SUSER_SNAME();
ALTER TABLE dbo.Proveedor ADD fechaRegistro DATETIME NULL DEFAULT GETDATE();
ALTER TABLE dbo.Proveedor ADD registroActivo BIT NULL DEFAULT 1;

...
...
...

CREATE PROC paProductoListar  @parametro VARCHAR(50)
AS 
	SELECT id, codigo, descripcion, unidadMedida, saldo, precioVenta,
		   usuarioRegistro, fechaRegistro
	FROM Producto 
	WHERE registroActivo=1
		  AND codigo+descripcion LIKE '%'+@parametro+'%'

INSERT INTO Producto 
VALUES ('HB525', 'Hoja Bond tamaño carta', 'Paquete', 
		0, 21, SUSER_SNAME(), GETDATE(), 1)

EXEC paProductoListar 'BOND'

select * from Producto


