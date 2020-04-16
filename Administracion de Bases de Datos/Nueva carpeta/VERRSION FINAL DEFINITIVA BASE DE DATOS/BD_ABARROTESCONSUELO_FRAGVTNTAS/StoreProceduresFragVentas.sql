/*Procedimientos almacenados Fragmento Ventas*/

/*Procedimiento Insertar Empleados*/
CREATE PROCEDURE PAInserempleaodos
@Nombre varchar(21),
@ApellidoP varchar(16),
@ApellidoM varchar(16),
@telefono varchar(13),
@Tarea varchar(7),
@turno varchar(11),
@Ban int output
as
declare @cveemp int
if(@Nombre='' or @ApellidoP='' or @ApellidoM='' or @telefono='' or @Tarea='' or @turno='')
begin 
if(@Nombre='')
	--print 'El nombre no puede estar vacio'
	set @Ban=1
else 
if(@ApellidoP='')
	--print 'El Apellido P. no puede estar vacio'
	set @Ban=2
else
if(@ApellidoM='')
	--print 'El Apellido P. no puede estar vacio'
	set @Ban=3
else
if(@telefono='')
	--print 'El Apellido P. no puede estar vacio'
	set @Ban=4
else
if(@Tarea='')
	--print 'El Apellido P. no puede estar vacio'
	set @Ban=5
else
if(@turno='')
	--print 'El Apellido P. no puede estar vacio'
	set @Ban=6
end
else
begin
 if(LEN(@Nombre)>20)
--print('La longitud del nombre no debe ser mayor a 20 caracteres')
set @Ban=7
else
if(LEN(@ApellidoP)>15 or LEN(@ApellidoM)>15 )
--print('La longitud de los apellidos no debe se mayor a 15 caracteres')
set @Ban=8
else
if(LEN(@telefono)>12 )
--print('La longitud del telefono no debe se mayor a 12 caracteres')
set @Ban=9
else
if(LEN(@Tarea)>7)
--print('La longitud de la tarea no debe se mayor a 7 caracteres')
--aqui tambien se deberia de validar que en tarea solo fuera Vender o Comprar o Ambos o Admin pero lo 
--manejaremos en visual con solo permirtirle entrar unas de las 4 opciones
set @Ban=10
else
if(LEN(@turno)>10)
--print('La longitud del turno no debe se mayor a 10 caracteres')
set @Ban=11
else
if(select count(*) from EMPLEADOS where NOMBRE=@Nombre and APELLIDOP=@ApellidoP and APELLIDOM=@ApellidoM and TELEFONO=@telefono and TURNO=@turno)>0
				--print'Este empleado ya esta insertado'
				set @Ban=12
	else
	begin
		IF(SELECT COuNT(*) FROM EMPLEADOS )=0
			SET @cveemp= 100
		ELSE
			SET @cveemp=(SELECT MAX(CVEEMPLEADO) FROM EMPLEADOS )+1
	
	begin tran
	 insert into EMPLEADOS(CVEEMPLEADO,NOMBRE,APELLIDOP,APELLIDOM,Tareas,TELEFONO,TURNO) values(@cveemp,@Nombre,@ApellidoP,@ApellidoM,@Tarea,@telefono,@turno)
	 insert into ABARROTESCONSUELO.dbo.EMPLEADOS(CVEEMPLEADO,NOMBRE,APELLIDOP,APELLIDOM,Tareas,TELEFONO,TURNO) values(@cveemp,@Nombre,@ApellidoP,@ApellidoM,@Tarea,@telefono,@turno)
	commit tran

	end
end


/*Procedimiento Para Agregar Ventas*/
CREATE PROCEDURE PAAgregarventas
as
declare @cveventa int
IF(SELECT COUNT(*) FROM VENTAS )=0
			SET @cveventa= 1000
		ELSE
		begin
			SET @cveventa=(SELECT MAX(CVEVENTA) FROM VENTAS )+1
				begin tran
					insert into VENTAS(CVEVENTA) values(@cveventa)
					insert into ABARROTESCONSUELO.dbo.VENTAS(CVEVENTA) values(@cveventa)
				commit tran
			end


/*Procedimiento Insertar Productos que no se ocupa en realidad */
create  procedure PAInserproductosfv
@cveproducto int,
@nombreproducto varchar(33),
@Ban int output
as
if(@cveproducto is null or @cveproducto=0 or @nombreproducto='')
begin
if(@cveproducto is null or @cveproducto=0)
--print('La clave no puede estar vacio')
set @Ban=1
if(@nombreproducto='')
--print('el nombre de producto no puede estar vacio')
set @Ban=2
end
else
begin 
	if(LEN(@nombreproducto)>30)
	--print('El nombre del producto no puede tener mas de 30 caracteres')
	set @Ban=4
	else
	if(select count(*) from PRODUCTOS where CVEPRODUCTOS=@cveproducto)>0
	begin 
	--print('La clave del producto ya a sido registrada')
	set @Ban=5
	end
	else
	begin
		begin tran
		insert into PRODUCTOS(CVEPRODUCTOS,NOMBREPRO) values(@cveproducto,@nombreproducto)
		insert into ABARROTESCONSUELO.dbo.PRODUCTOS(CVEPRODUCTOS,NOMBREPRO) values(@cveproducto,@nombreproducto)
		insert into ABARROTESCONSUELO_FRAGCOMPRA.dbo.PRODUCTOS(CVEPRODUCTOS,NOMBREPRO) values(@cveproducto,@nombreproducto)
		commit tran
		--print('El producto se a registrado exitosamente')
			set @Ban=6
	end
end
--

/*Procedimiento Detalle Empleado-Venta*/
CREATE PROCEDURE Padetempvta
@CVE_Emp int,
@CVE_Vta int,
@Ban int output
as
if(@CVE_Emp is null or @CVE_Emp=0)
--print 'La clave del empleado no puede ser nula ni ser cero'
set @Ban=1
else
if(@CVE_Vta is null or @CVE_Vta=0)
--print 'La clave de la venta no puede ser nula ni ser cero'
set @Ban=2
else
	if((SELECT COUNT(*) FROM DETALLEEMPVTA WHERE CVEEMPLEADO=@CVE_Emp and CVEVENTA=@CVE_Vta)>0)
		--print 'A la venta ya se le fue asignado un empleado el cual es el mismo que se le quiere agregar'
		set @Ban=3
	else
		if((SELECT COUNT(*) FROM DETALLEEMPVTA WHERE CVEVENTA=@CVE_Vta)>0)
			--print 'A la venta ya se le asigno un empleado'
			set @Ban=4
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
@cantidad int,
@Ban int output
as
	if(@cveproducto is null or @cveventa is null or @cantidad is null)
		begin 
			if @cveproducto is null
				--print('La clave del producto no puede estar vacia o nula')
				set @Ban=1
			if @cveventa is null
				--print('La clave de la ventao no puede estar vacia o nula')
				set @Ban=2
			if @cantidad is null
				--print('La cantidad de venta no puede estar vacia o nula')
				set @Ban=3
		end
--Se puede validar si el producto no se encuentra registrado sin embargo si esta en la tineda pues es por que esta registrado 
--Al igual que la venta se puede validar que exista la venta pero el sistema la creera automaticamente asi que exitira 
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
					
					update ABARROTESCONSUELO_FRAGCOMPRA.dbo.PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto
					commit tran
				end
			else
				--print('No tenemos en inventario el o los productos que quiere comprar')
				set @Ban=3
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
			
			update ABARROTESCONSUELO_FRAGCOMPRA.dbo.PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto
			commit tran
		end
	else
		begin
			--print('No tenemos en inventario el o los productos que quiere comprar')
			set @Ban=4
		end