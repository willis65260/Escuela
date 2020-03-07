/*Procedimientos almacenados Fragmento Ventas*/

/*Procedimiento Insertar Empleados*/
CREATE PROCEDURE PAInserempleaodos
@Nombre varchar(21),
@ApellidoP varchar(16),
@ApellidoM varchar(16),
@telefono varchar(13),
@turno varchar(11)
/*@Vigente int*/

as
declare @CVE_Emp int
	if( (select COUNT(*) from EMPLEADOS)=0)
		set @CVE_Emp=100
	else
		set @CVE_Emp=(select MAX(CVEEMPLEADO) from EMPLEADOS)+1

	/*No cadenas Vacias*/
	if(@Nombre='')
		print 'El nombre no puede estar vacio'
	else
	if(@ApellidoP='')
		print 'El Apellido P. no puede estar vacio'
	else
	if(@ApellidoM='')
		print 'El Apellido M. no puede estar vacio'
	else
	if(@telefono='')
		print 'El Telefono no puede estar vacio'
	else
	if(@turno='')
		print 'El Turno no puede estar vacio'
	else
	/*Longitudes*/
	if(LEN(@Nombre)>20)
		print 'La longitud del nombre no puede exceder los 20 Caracteres'
	else
	if(LEN(@ApellidoP)>15)
		print 'La longitud del apellido P. no puede exceder los 20 Caracteres'
	else
	if(LEN(@ApellidoM)>15)
		print 'La longitud del apellido M. no puede exceder los 20 Caracteres'
	else
	if(LEN(@telefono)>10)
		print 'La longitud del telefono no puede ser mayor a 10'
	else
		begin tran
			insert into EMPLEADOS(CVEEMPLEADO,NOMBRE,APELLIDOP,APELLIDOM,TELEFONO,TURNO) 
				VALUES(@CVE_Emp,@Nombre,@ApellidoP,@ApellidoM,@telefono,@turno)
			insert into ABARROTESCONSUELO.dbo.EMPLEADOS(CVEEMPLEADO,NOMBRE,APELLIDOP,APELLIDOM,TELEFONO,TURNO) 
				VALUES(@CVE_Emp,@Nombre,@ApellidoP,@ApellidoM,@telefono,@turno)
		


/*Procedimiento Para Agregar Ventas*/
CREATE PROCEDURE PAAgregarventas
as
declare @cveventa int
IF(SELECT COuNT(*) FROM VENTAS )=0
			SET @cveventa= 1000
		ELSE
			SET @cveventa=(SELECT MAX(CVEVENTA) FROM VENTAS )+1
			begin
				begin tran
					insert into VENTAS(CVEVENTA) values(@cveventa)
					insert into ABARROTESCONSUELO.dbo.VENTAS(CVEVENTA) values(@cveventa)
				commit tran
			end
/*Procedimiento Insertar Productos*/
CREATE PROCEDURE PAInserproductos
@cveProd int,
@NomProd varchar(33),
@fechacadProd date
/*@Ban int output*/
AS
if(@cveProd is null)
	print 'La clave no puede estar vacia'
else
if(@NomProd='')
	print 'El nombre del producto no puede estar vacio'
else
if(@fechacadProd='')
	print 'La fecha de caducidad del producto no puede estar vacia'
else
if(LEN(@NomProd)>30)
	print 'El nommbre del producto no puede tener mas de 30 caracteres'
else
if( (SELECT COUNT(*) FROM PRODUCTOS WHERE CVEPRODUCTOS=@cveProd)>0)
	print 'Ese producto ya ha sido registrado'
else
	begin
		begin tran
			insert into PRODUCTOS(CVEPRODUCTOS,NOMBREPRO,FECHACADUCIDAD) VALUES(@cveProd,@NomProd,@fechacadProd)
			insert into ABARROTESCONSUELO.dbo.PRODUCTOS(CVEPRODUCTOS,NOMBREPRO,FECHACADUCIDAD) VALUES(@cveProd,@NomProd,@fechacadProd)
			insert into ABARROTESCONSUELOfracompras.dbo.PRODUCTOS(CVEPRODUCTOS,NOMBREPRO,FECHACADUCIDAD) VALUES(@cveProd,@NomProd,@fechacadProd)
		commit tran
	end


/*Procedimiento Detalle Empleado-Venta*/
CREATE PROCEDURE Padetempvta
@CVE_Emp int,
@CVE_Vta int

as

if(@CVE_Emp is null or @CVE_Emp=0)
print 'La clave del empleado no puede ser nula ni ser cero'
else
if(@CVE_Vta is null or @CVE_Vta=0)
print 'La clave de la venta no puede ser nula ni ser cero'
else
	if((SELECT COUNT(*) FROM DETALLEEMPVTA WHERE CVEEMPLEADO=@CVE_Emp and CVEVENTA=@CVE_Vta)>0)
		print 'A la venta ya se le fue asignado un empleado el cual es el mismo que se le quiere agregar'
	else
		if((SELECT COUNT(*) FROM DETALLEEMPVTA WHERE CVEVENTA=@CVE_Vta)>0)
			print 'A la venta ya se le asigno un empleado'
		else
			begin
				begin tran
					insert into DETALLEEMPVTA values(@CVE_Emp,@CVE_Vta)
					insert into ABARROTESCONSUELO.dbo.DETALLEEMPVTA values(@CVE_Emp,@CVE_Vta)
				commit tran
			end


/*Procedimiento Detalle Venta*/
create procedure PADetvtaprod
@cveproducto int,
@cveventa int,
@cantidad int
as
	if(@cveproducto is null or @cveventa is null or @cantidad is null)
		begin 
			if @cveproducto is null
				print('La clave del producto no puede estar vacia o nula')
			if @cveventa is null
				print('La clave de la ventao no puede estar vacia o nula')
			if @cantidad is null
				print('La cantidad de venta no puede estar vacia o nula')
		end
--Se puede validar si el producto no se encuentra registrado sin embargo si esta en la tineda pues es por que esta registrado 
--Al igual que la venta se puede validar que exista la venta pero el sistemas la creera automaticamente asi que exitira 
else
	if(Select count(*) from DETALLEVTAPROD where CVEPRODUCTO=@cveproducto and CVEVENTA=@cveventa)>0
		begin 
			if (select EXISTENCIA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)>=@cantidad
				begin
					begin tran
					update DETALLEVTAPROD set CANTIDADVTA=CANTIDADVTA+@cantidad where CVEPRODUCTO=@cveproducto and CVEVENTA=@cveventa
					update VENTAS set TOTALVTA=TOTALVTA+(@cantidad*(Select PRECIOVTA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)) where CVEVENTA=@cveventa
					update PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto

					update ABARROTESCONSUELO.dbo.DETALLEVTAPROD set CANTIDADVTA=CANTIDADVTA+@cantidad where CVEPRODUCTO=@cveproducto and CVEVENTA=@cveventa
					update ABARROTESCONSUELO.dbo.VENTAS set TOTALVTA=TOTALVTA+(@cantidad*(Select PRECIOVTA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)) where CVEVENTA=@cveventa
					update ABARROTESCONSUELO.dbo.PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto
					
					/*Hace Falta Poner Los Updates Para el Fragmentos de compras*/
					
					commit tran
				end
			else
				print('No tenemos en inventario el o los productos que quiere comprar')
		end
	else 
	if (select EXISTENCIA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)>=@cantidad
		begin
			begin tran
			insert into DETALLEVTAPROD values(@cveproducto,@cveventa,@cantidad)
			update VENTAS set TOTALVTA=TOTALVTA+(@cantidad*(Select PRECIOVTA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)) where CVEVENTA=@cveventa
			update PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto

			insert into ABARROTESCONSUELO.dbo.DETALLEVTAPROD values(@cveproducto,@cveventa,@cantidad)
			update ABARROTESCONSUELO.dbo.VENTAS set TOTALVTA=TOTALVTA+(@cantidad*(Select PRECIOVTA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)) where CVEVENTA=@cveventa
			update ABARROTESCONSUELO.dbo.PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto
			
			/*Hace Falta Poner Los Updates para el Fragmentos de compras*/
			commit tran
		end
	else
		begin
			print('No tenemos en inventario el o los productos que quiere comprar')
		end