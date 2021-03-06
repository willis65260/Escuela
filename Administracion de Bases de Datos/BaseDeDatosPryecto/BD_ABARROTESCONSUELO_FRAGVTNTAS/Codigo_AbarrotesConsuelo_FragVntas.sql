CREATE DATABASE ABARROTESCONSUELO_FRAGVENTAS

USE ABARROTESCONSUELO_FRAGVENTAS

CREATE TABLE EMPLEADOS
(
CVEEMPLEADO INT PRIMARY KEY,
NOMBRE VARCHAR(20) NOT NULL,
APELLIDOP VARCHAR(15) NOT NULL,
APELLIDOM VARCHAR(15) NOT NULL,
TELEFONO VARCHAR(12) NOT NULL,
VigenteEmp int default(1)NOT NULL,
TURNO VARCHAR(10) NOT NULL
)

CREATE TABLE VENTAS 
(
CVEVENTA INT PRIMARY KEY,
FECHAVTA DATE DEFAULT(GETDATE()) NOT NULL,
TOTALVTA MONEY DEFAULT(0) NOT NULL
)
 CREATE TABLE DETALLEEMPVTA
 (
 CVEEMPLEADO INT FOREIGN KEY REFERENCES EMPLEADOS NOT NULL,
 CVEVENTA INT FOREIGN KEY REFERENCES VENTAS NOT NULL,
 )

 CREATE TABLE PRODUCTOS
 (
 CVEPRODUCTOS INT PRIMARY KEY,
 NOMBREPRO VARCHAR(30) NOT NULL,
 EXISTENCIA INT DEFAULT(0) NOT NULL,
 Edoproducto int default(1)NOT NULL,
 PRECIOVTA MONEY DEFAULT(0)
 )

 CREATE TABLE DETALLEVTAPROD
 (
 CVEPRODUCTO INT FOREIGN KEY REFERENCES PRODUCTOS NOT NULL,
 CVEVENTA INT FOREIGN KEY REFERENCES VENTAS NOT NULL,
 CANTIDADVTA INT NOT NULL,
 )

 
