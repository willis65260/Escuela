CREATE DATABASE ABARROTESCONSUELOfracompras

USE ABARROTESCONSUELOfracompras

 CREATE TABLE PRODUCTOS
 (
 CVEPRODUCTOS INT PRIMARY KEY,
 NOMBREPRO VARCHAR(30) NOT NULL,
 PRECIOCOMPRA MONEY DEFAULT(0) NOT NULL,
 FECHACADUCIDAD DATE NOT NULL,
 EXISTENCIA INT DEFAULT(0) NOT NULL,
 PRECIOVTA MONEY DEFAULT(0)
 )

 CREATE TABLE COMPRAS 
 (
 CVECOMPRAS INT PRIMARY KEY,
 FECHACOMPRA DATE DEFAULT(GETDATE()) NOT NULL,
 TOTALCOMPRA MONEY DEFAULT(0)
 )

 CREATE TABLE PROVEDORES
 (
 CVEPROVEDORES INT PRIMARY KEY,
 NOMBREPROV VARCHAR(30) NOT NULL,
 TELEFONO VARCHAR(12) NOT NULL,
 VigenteProv int default(1)NOT NULL,
 DIRECCION VARCHAR(50) NOT NULL
 )

 CREATE TABLE DETALLEPROVCOMP
 (
 CVEPROVEDORES INT FOREIGN KEY REFERENCES PROVEDORES NOT NULL,
 CVECOMPRAS INT FOREIGN KEY REFERENCES COMPRAS NOT NULL
 )

 CREATE TABLE DETALLECOMPRPRODU
 (
 CVEPRODUCTO INT FOREIGN KEY REFERENCES PRODUCTOS NOT NULL,
 CVECOMPRA INT FOREIGN KEY REFERENCES COMPRAS NOT NULL,
 CANTIDADCOMP INT NOT NULL
 )

 