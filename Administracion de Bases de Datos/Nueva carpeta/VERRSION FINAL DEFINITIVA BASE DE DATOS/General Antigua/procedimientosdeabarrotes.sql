
select* from DETALLECOMPRPRODU
select* from DETALLEEMPVTA
select* from DETALLEPROVCOMP
select* from DETALLEVTAPROD
select* from VENTAS
select* from PRODUCTOS



/* Procedimento almacenado para insertar nuevos empleados */

CREATE PROCEDURE PAInserempleaodos
@NombreE varchar(21) ,
@ApellidoP varchar(16),
@ApellidoM varchar(16),
@telefono varchar(13),
@turno varchar(11)
as
declare @cveemp int
if(@NombreE='' or @ApellidoP=''or @ApellidoM='' or @telefono='' or @turno='')
	begin
if @nombreE=''
PRINT'NO debe dejar el nombre vacio'

if @ApellidoP=''
PRINT'NO debe dejar el apellido paterno vacio'

if @ApellidoM=''
PRINT'NO debe dejar el apellido materno vacio'

if @telefono=''
PRINT'NO debe dejar el telefono vacio'

if @turno=''
PRINT'NO debe dejar el turno vacio'
	end
else
begin
if(LEN(@NombreE)>20)
print('La longitud del nombre no debe ser mayor a 20 caracteres')
else
if(LEN(@ApellidoP)>15 or LEN(@ApellidoM)>15 )
print('La longitud de los apellidos no debe se mayor a 15 caracteres')
else
if(LEN(@telefono)>12 )
print('La longitud del telefono no debe se mayor a 12 caracteres')
else
if(LEN(@turno)>10)
print('La longitud del turno no debe se mayor a 10 caracteres')
else
if(select count(*) from EMPLEADOS where NOMBRE=@NombreE and APELLIDOP=@ApellidoP and APELLIDOM=@ApellidoM and 
TELEFONO=@telefono and TURNO=@turno)>0
				print'Este empleado ya esta insertado'
	else
	begin
		IF(SELECT COuNT(*) FROM EMPLEADOS )=0
			SET @cveemp= 100
		ELSE
			SET @cveemp=(SELECT MAX(CVEEMPLEADO) FROM EMPLEADOS )+1
	
	begin tran
	 insert into EMPLEADOS(CVEEMPLEADO,NOMBRE,APELLIDOM,APELLIDOP,TELEFONO,TURNO) values(@cveemp,@NombreE,@ApellidoP,@ApellidoM,@telefono,@turno)
	commit tran

	end
end

execute PAInserempleaodos '','Lopez','Contreras','3511255999','Vespertino'
execute PAInserempleaodos 'karina','','Contreras','3511255999','Vespertino'
execute PAInserempleaodos 'karina','Lopez','','3511255999','Vespertino'
execute PAInserempleaodos 'karina','Lopez','Contreras','','Vespertino'
execute PAInserempleaodos 'karina','Lopez','Contreras','3511255999',''
execute PAInserempleaodos 'toñodhxs','Lopezjjjjjjjjjjjjjj','Contreras','3511255999','Vespertino'
execute PAInserempleaodos 'toñosdsdsdsdsdsdsdsdsdsdsdsdd','Lopez','Contreras','3511255999','Vespertino'
execute PAInserempleaodos 'toñodhxs','Lopez','Contreras','35112559999909','Vespertino'
execute PAInserempleaodos 'toñodhxs','Lopez','Contreras','3511255999','Vespertinoo'
execute PAInserempleaodos 'Karina','Lopezj','Contreras','3511255999','Vespertino'
execute PAInserempleaodos 'Osvaldo','Lopezj','Contreras','3511255999','Vespertino'
select* from EMPLEADOS
--Se termina el procedimiento para insertar nuevos empleados


--procedimiento para insertar nuevos provedores 
create procedure PAInserprov
@NombPro varchar(31),
@TelPro varchar(13),
@dirección varchar(51)
as
declare @cveprov int
if(@NombPro='' or @TelPro='' or @dirección='')
begin 
if @NombPro=''
begin
print('El nombre del provedor no debe estar vacio')

end
if @TelPro=''
begin
print('El numero de telefono no debe estar vacio')

end
if @dirección=''
begin
print('La dirección no debe estar vacia')

end
end
else
	if(LEN(@NombPro)>30 or LEN(@TelPro)>12 or LEN(@dirección)>50)
	begin
	if LEN(@NombPro)>30
	begin
	print('El nombre del provedor no debe ser mayor a 30 caracteres')
	
	end
	if LEN(@TelPro)>12
	begin
	print('El numero de telefono no debe ser mayor a 12 caracteres')
	
	end
	if LEN(@dirección)>50
	begin
	print('La dirección no debe ser mayor a 50 caracteres')
	
	end
	end
	else
		if(select count(*) from PROVEDORES where NOMBREPROV=@NombPro and TELEFONO=@TelPro and DIRECCION=@dirección)>0
		begin
			print('El provedor ya esta registrado')
			
		end
		else
		begin
		IF(SELECT COuNT(*) FROM PROVEDORES )=0
			SET @cveprov= 1
		ELSE
			SET @cveprov=(SELECT MAX(CVEPROVEDORES) FROM PROVEDORES )+1
	
			begin tran
			insert into PROVEDORES(CVEPROVEDORES,NOMBREPROV,TELEFONO,DIRECCION) values(@cveprov,@NombPro,@TelPro,@dirección)
			commit tran
		end
execute PAInserprov 'Tortillas de Harina',' ','LA piedad Michoacan, Col:Centro ,Arandas #1'
execute PAInserprov 'Tortillas de Harina','3511255999',' '
execute PAInserprov ' ','3511255999 ','LA piedad Michoacan, Col:Centro ,Arandas #12'
execute PAInserprov 'Tortillas de Harinaaaaaaaaahhhhdddddd','3511255999 ','LA piedad Michoacan, Col:Centro ,Arandas #12'
execute PAInserprov 'Tortillas de Harina','35112559992333 ','LA piedad Michoacan, Col:Centro ,Arandas #12'
execute PAInserprov 'Tortillas de Harina','3511255999','LA piedad Michoacan, Col:Centro ,Arandas #12lskakdnlskandlsaldnlasndlasldlasldnlkdslk'
execute PAInserprov 'Tortillas de Harina','3511255999','LA piedad Michoacan, Col:Centro ,Arandas #12'
execute PAInserprov 'Santorini','3512225577','Zamora Michoacan , col: La floresta, hidalgo #13'
execute PAInserprov 'Pantene','3512225577','Zamora Michoacan , col: La floresta, hidalgo #13'
select* from PROVEDORES
delete from PROVEDORES where CVEPROVEDORES=11 or CVEPROVEDORES=12
--se termina el procedimiento para insertar  provedores

--Procedimiento para agregar productos
create procedure PAInserproductos
@cveproducto int,
@nombreproducto varchar(33),
@fechacad date

as
if(@cveproducto is null or @nombreproducto='' or @fechacad='')
begin
if(@cveproducto is null)
print('La clave no puede estar vacio')
if(@nombreproducto='')
print('el nombre de producto no puede estar vacio')
if( @fechacad='')
print('LA fecha de producto no puede estar vacio')
end
else
begin 
	if(LEN(@nombreproducto)>30)
	print('El nombre del producto no puede tener mas de 30 caracteres')
	else
	if(select count(*) from PRODUCTOS where CVEPRODUCTOS=@cveproducto)>0
	begin 
	print('La clave del producto ya a sido registrada')
	end
	else
	begin
		begin tran
		insert into PRODUCTOS(CVEPRODUCTOS,NOMBREPRO,FECHACADUCIDAD) values(@cveproducto,@nombreproducto,@fechacad)
		commit tran
	end
end

execute PAInserproductos null,'1/2 kg de tortillas de harina','2020/03/04'
execute PAInserproductos 123456789,'','2020/03/04'
execute PAInserproductos 123456789,'1/2 kg de tortillas de harina',''
execute PAInserproductos 123456789,'1/2 kg de tortillas de harinakjkjkjkgkggkjgkjgjgkgkgjjgkjgjgkjgjgkgkjkjg','2020/03/04'
execute PAInserproductos 123456789,'1/2 kg de tortillas de harina','2020/03/04'
execute PAInserproductos 111111111,'Agua Santorini 20lts','2022/07/05'
execute PAInserproductos 111111112,'Pantene cafe liso 1lt','2022/07/05'
select* from PRODUCTOS

delete from PRODUCTOS where CVEPRODUCTOS=123444 or CVEPRODUCTOS=1234567 or CVEPRODUCTOS=123456789
--fin de agregar productos

--Agregar ventas

create  procedure PAAgregarventas

as
declare @cveventa int
IF(SELECT COuNT(*) FROM VENTAS )=0
			SET @cveventa= 1000
		ELSE
			SET @cveventa=(SELECT MAX(CVEVENTA) FROM VENTAS )+1
			begin tran
			insert into VENTAS(CVEVENTA) values(@cveventa)
			commit tran

execute PAAgregarventas 

delete from VENTAS where CVEVENTA=1010 or CVEVENTA=1011

select* from VENTAS
--Finaliza agrgar ventasssss

--Procedimeinto almecenado para insertar compras nuevas
	create procedure PAAgregarcompras
	as
declare @cvecompra int
IF(SELECT COuNT(*) FROM COMPRAS )=0
			SET @cvecompra= 1000
		ELSE
			SET @cvecompra=(SELECT MAX(CVECOMPRAS) FROM COMPRAS )+1
			begin tran
			insert into compras(CVECOMPRAS) values(@cvecompra)
			commit tran
	-- fin de insertar compras nuevas
	execute PAAgregarcompras
	select* from COMPRAS

	-- procediiento para detalle provedor compra
	create procedure Padetprovedorcompra
@cveprovedor int,
@cvecompra int

as
if(@cveprovedor is null or @cvecompra is null or @cveprovedor =0 or @cvecompra = 0)
begin
if @cveprovedor is null
print('LA cleve provedor no puede ser nula o vacia')
if @cvecompra is null
print('LA cleve compra no puede ser nula o vacia')
if @cveprovedor =0
print('LA cleve provedor no puede ser 0')
if @cvecompra =0
print('LA cleve compra no puede ser 0')
end
else
--se supone que esto lo hara automatico el sistemas al crear la compra tomara los datos del empleado y se la asignara a la venta cuando se cree
if(select count(*) from DETALLEPROVCOMP where CVECOMPRAS=@cvecompra and CVEPROVEDORES=@cveprovedor)>0
print('A la compra ya se le asigno un provedor el cual es el mismo que se le quiere agregar')
else
if(select count(*) from DETALLEPROVCOMP where CVECOMPRAS=@cvecompra)>0
print('A la compra ya se le asigno un provedor ')
else
	begin
	begin tran
	insert into DETALLEPROVCOMP values(@cveprovedor,@cvecompra)
	commit tran
	end
--finaliza proedimento detalle provedor compra
Execute Padetprovedorcompra null,1012
Execute Padetprovedorcompra 12,null
Execute Padetprovedorcompra 12,0
Execute Padetprovedorcompra 0,1012
Execute Padetprovedorcompra 10,1011
Execute Padetprovedorcompra 111,1011
Execute Padetprovedorcompra 12,1012
Execute Padetprovedorcompra 13,1013

Select * from DETALLEPROVCOMP


--comienza procedimiento detalle compra provedor
create procedure PADetallecompraproducto
@cveproductos int,
@cvecompras int,
@cantidadcompra int,
@preciocompra money,
@precioventa money

as
if(@cveproductos is null or @cvecompras is null or @cantidadcompra is null or @preciocompra is null or @precioventa is null)
begin
if @cveproductos is null
print('La clave del porducto no puede estar vacia o nula')
if @cvecompras is null
print('La clave de la compra no puede estar vacia o nula')
if @cantidadcompra is null
print('La ccantidad comprada no puede estar vacia o nula')
if @preciocompra is null
print('El precio de compra no puede estar vacia o nula')
if @precioventa is null
print('El precio de venta no puede estar vacia o nula')
end
else
if(select count(*) from compras where CVECOMPRAS =@cvecompras)=0
print('La clave de compras no existe digite una clave de una compra existente')
else 
if(select count(*) from PRODUCTOS where CVEPRODUCTOS=@cveproductos)=0
print('La clave del producto no existe digite una clave de un producto  existente o registre priemero el producto ')
else 
if (select count(*) from DETALLECOMPRPRODU where CVECOMPRA=@cvecompras and CVEPRODUCTO=@cveproductos)>0
begin
update DETALLECOMPRPRODU set CANTIDADCOMP=CANTIDADCOMP+@cantidadcompra where CVECOMPRA=@cvecompras and CVEPRODUCTO=@cveproductos
update COMPRAS set TOTALCOMPRA=TOTALCOMPRA+@cantidadcompra*@preciocompra where CVECOMPRAS=@cvecompras
update PRODUCTOS set PRECIOCOMPRA=@preciocompra, PRECIOVTA=@precioventa, EXISTENCIA=EXISTENCIA+@cantidadcompra where CVEPRODUCTOS=@cveproductos
end
else
begin 
begin tran 
insert into DETALLECOMPRPRODU values(@cveproductos,@cvecompras,@cantidadcompra)
update COMPRAS set TOTALCOMPRA=TOTALCOMPRA+@cantidadcompra*@preciocompra where CVECOMPRAS=@cvecompras
update PRODUCTOS set PRECIOCOMPRA=@preciocompra, PRECIOVTA=@precioventa, EXISTENCIA=EXISTENCIA+@cantidadcompra where CVEPRODUCTOS=@cveproductos
commit tran
end
-- finnnnnnn...
execute PADetallecompraproducto null,1012,10,30,32
execute PADetallecompraproducto 111111111,null,10,30,32
execute PADetallecompraproducto 111111111,1012,null,30,32
execute PADetallecompraproducto 111111111,1012,10,null,32
execute PADetallecompraproducto 111111111,1012,10,30,null
execute PADetallecompraproducto 1111111111,1012,10,30,32
execute PADetallecompraproducto 111111111,10122,10,30,32
execute PADetallecompraproducto 111111111,1012,10,30,32
execute PADetallecompraproducto 111111112,1013,10,17,25
select * from PRODUCTOS
select * from DETALLECOMPRPRODU

--Comienza detalleempvta
create  procedure Padetempvta
@cveemp int,
@cveventa int

as
if(@cveemp is null or @cveventa is null or @cveemp=0 or @cveventa=0)
begin
if @cveemp is null
print('LA clave empleado no puede ser nula o vacia')
if @cveventa is null
print('LA clave venta no puede ser nula o vacia')
if @cveemp=0
print('LA clave empleado no puede ser 0')
if @cveventa=0
print('LA clave venta no puede ser 0')
end
else
--se supone que esto lo hara automatico el sistemas al crear la venta tomara los datos del empleado que esta en turno y se la asignara a la venta cuando se cree
if(select count(*) from DETALLEEMPVTA where CVEEMPLEADO=@cveemp and CVEVENTA=@cveventa)>0
print('A la venta ya se le asigno un empleado el cual es el mismo que se le quiere agregar')
else
if(select count(*) from DETALLEEMPVTA where  CVEVENTA=@cveventa)>0
print('A la venta ya se le asigno un empleado ')
else
	begin
	begin tran
	insert into DETALLEEMPVTA values(@cveemp,@cveventa)
	commit tran
	end

--finaliza detalleempvta
Execute Padetempvta null,1010
Execute Padetempvta 0,1010
Execute Padetempvta 106,null
Execute Padetempvta 106,0
Execute Padetempvta 106,1010

Execute Padetempvta 107,1011

select* from EMPLEADOS
select* from VENTAS
-- empieza el detalle vtaprod
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
	commit tran
	end
	else
	begin
	print('No tenemos en inventario el o los productos que quiere comprar')
	end

	--fin de detalle venta y productos
	Execute PADetvtaprod null,1010,1
	Execute PADetvtaprod 111111111,null,1
	Execute PADetvtaprod 111111111,1010,null
	Execute PADetvtaprod 111111111,1010,12
	Execute PADetvtaprod 111111111,1010,1

	Execute PADetvtaprod 111111112,1011,1

	select* from PRODUCTOS
	select* from DETALLEVTAPROD