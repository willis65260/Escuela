--provedores insertar--

create procedure PAInserprovfc
@NombPro varchar(31),
@TelPro varchar(13),
@dirección varchar(51),
@Ban int output
as
declare @cveprov int
if(@NombPro='' or @TelPro='' or @dirección='')
begin 
if @NombPro=''
begin
--print('El nombre del provedor no debe estar vacio')
set @Ban=1
end
if @TelPro=''
begin
--print('El numero de telefono no debe estar vacio')
set @Ban=2
end
if @dirección=''
begin
--print('La dirección no debe estar vacia')
set @Ban=3
end
end
else
	if(LEN(@NombPro)>30 or LEN(@TelPro)>12 or LEN(@dirección)>50)
	begin
	if LEN(@NombPro)>30
	begin
	--print('El nombre del provedor no debe ser mayor a 30 caracteres')
	set @Ban=4
	end
	if LEN(@TelPro)>12
	begin
	--print('El numero de telefono no debe ser mayor a 12 caracteres')
	set @Ban=5
	end
	if LEN(@dirección)>50
	begin
	--print('La dirección no debe ser mayor a 50 caracteres')
	set @Ban=6
	end
	end
	else
		if(select count(*) from PROVEDORES where NOMBREPROV=@NombPro and TELEFONO=@TelPro and DIRECCION=@dirección)>0
		begin
			--print('El provedor ya esta registrado')
			set @Ban=7
		end
		else
		begin
		IF(SELECT COuNT(*) FROM PROVEDORES )=0
			SET @cveprov= 1
		ELSE
			SET @cveprov=(SELECT MAX(CVEPROVEDORES) FROM PROVEDORES )+1
	
			begin tran
			insert into ABARROTESCONSUELO.dbo.PROVEDORES(CVEPROVEDORES,NOMBREPROV,TELEFONO,DIRECCION) values(@cveprov,@NombPro,@TelPro,@dirección)
			insert into PROVEDORES(CVEPROVEDORES,NOMBREPROV,TELEFONO,DIRECCION) values(@cveprov,@NombPro,@TelPro,@dirección)
			commit tran
		end

		--    Insertar Productos----
create  procedure PAInserproductosfc
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
		insert into ABARROTESCONSUELO_FRAGVENTAS.dbo.PRODUCTOS(CVEPRODUCTOS,NOMBREPRO) values(@cveproducto,@nombreproducto)
		commit tran
	end
end
--
-- procediiento para detalle provedor compra
create procedure Padetprovedorcomprafc
@cveprovedor int,
@cvecompra int,
@Ban int output
as
if(@cveprovedor is null or @cvecompra is null or @cveprovedor =0 or @cvecompra = 0)
begin
if @cveprovedor is null
--print('LA cleve provedor no puede ser nula o vacia')
set @Ban=1
if @cvecompra is null
--print('LA cleve compra no puede ser nula o vacia')
set @Ban=2
if @cveprovedor =0
--print('LA cleve provedor no puede ser 0')
set @Ban=3
if @cvecompra =0
--print('LA cleve compra no puede ser 0')
set @Ban=4
end
else
--se supone que esto lo hara automatico el sistemas al crear la compra tomara los datos del empleado y se la asignara a la venta cuando se cree
if(select count(*) from DETALLEPROVCOMP where CVECOMPRAS=@cvecompra and CVEPROVEDORES=@cveprovedor)>0
begin
--print('A la compra ya se le asigno un provedor el cual es el mismo que se le quiere agregar')
set @Ban=5
end
else 
if(select count(*) from DETALLEPROVCOMP where CVECOMPRAS=@cvecompra)>0
begin
--print('A la compra ya se le asigno un provedor ')
set @Ban=6
end
else
	begin
	begin tran
	insert into ABARROTESCONSUELO.dbo.DETALLEPROVCOMP values(@cveprovedor,@cvecompra)
	insert into DETALLEPROVCOMP values(@cveprovedor,@cvecompra)
	commit tran
	end
--finaliza proedimento detalle provedor compra

--comienza procedimiento detalle compra producto
create Procedure PADetallecompraproductofc
@cveproductos int,
@cvecompras int,
@fechacaducidad date,
@cantidadcompra int,
@preciocompra money,
@precioventa money,
@Ban int output
as
if(@cveproductos is null or @cvecompras is null or @cantidadcompra is null or @preciocompra is null or @precioventa is null or @fechacaducidad is null)
begin
if @cveproductos is null
--print('La clave del porducto no puede estar vacia o nula')
set @Ban=1
if @cvecompras is null
--print('La clave de la compra no puede estar vacia o nula')
set @Ban=2
if @cantidadcompra is null
--print('La ccantidad comprada no puede estar vacia o nula')
set @Ban=3
if @preciocompra is null
--print('El precio de compra no puede estar vacia o nula')
set @Ban=4
if @precioventa is null
--print('El precio de venta no puede estar vacia o nula')
set @Ban=5
if @fechacaducidad is null
--print('La fecha de caducidad no puede estar vacia o nula')
set @Ban=6
end
else
if(select count(*) from compras where CVECOMPRAS=@cvecompras)=0
begin
--print('La clave de compras no existe digite una clave de una compra existente')
set @Ban=7
end
else 
if(select count(*) from PRODUCTOS where CVEPRODUCTOS=@cveproductos)=0
begin
--print('La clave del producto no existe digite una clave de un producto  existente o registre priemero el producto ')
set @Ban=8
end
else 
if (select count(*) from DETALLECOMPRPRODU where CVECOMPRA=@cvecompras and CVEPRODUCTO=@cveproductos)>0
begin
--BD ORIGINAL
update ABARROTESCONSUELO.dbo.DETALLECOMPRPRODU set CANTIDADCOMP=CANTIDADCOMP+@cantidadcompra,FECHACADUCIDAD=@fechacaducidad where CVECOMPRA=@cvecompras and CVEPRODUCTO=@cveproductos
update ABARROTESCONSUELO.dbo.COMPRAS set TOTALCOMPRA=TOTALCOMPRA+@cantidadcompra*@preciocompra where CVECOMPRAS=@cvecompras
update ABARROTESCONSUELO.dbo.PRODUCTOS set PRECIOCOMPRA=@preciocompra, PRECIOVTA=@precioventa, EXISTENCIA=EXISTENCIA+@cantidadcompra, Edoproducto=1 where CVEPRODUCTOS=@cveproductos
--BD FRagmento compras
update DETALLECOMPRPRODU set CANTIDADCOMP=CANTIDADCOMP+@cantidadcompra,FECHACADUCIDAD=@fechacaducidad where CVECOMPRA=@cvecompras and CVEPRODUCTO=@cveproductos
update COMPRAS set TOTALCOMPRA=TOTALCOMPRA+@cantidadcompra*@preciocompra where CVECOMPRAS=@cvecompras
update PRODUCTOS set PRECIOCOMPRA=@preciocompra, PRECIOVTA=@precioventa, EXISTENCIA=EXISTENCIA+@cantidadcompra, Edoproducto=1 where CVEPRODUCTOS=@cveproductos
--BD Fragmento Ventas
update ABARROTESCONSUELO_FRAGVENTAS.dbo.PRODUCTOS set PRECIOVTA=@precioventa, EXISTENCIA=EXISTENCIA+@cantidadcompra, Edoproducto=1 where CVEPRODUCTOS=@cveproductos
end
else
begin 
begin tran 
--BD PRimera
insert into ABARROTESCONSUELO.dbo.DETALLECOMPRPRODU values(@cveproductos,@cvecompras,@fechacaducidad,@cantidadcompra)
update ABARROTESCONSUELO.dbo.COMPRAS set TOTALCOMPRA=TOTALCOMPRA+@cantidadcompra*@preciocompra where CVECOMPRAS=@cvecompras
update ABARROTESCONSUELO.dbo.PRODUCTOS set PRECIOCOMPRA=@preciocompra, PRECIOVTA=@precioventa, EXISTENCIA=EXISTENCIA+@cantidadcompra, Edoproducto=1 where CVEPRODUCTOS=@cveproductos
--BD fragmento compras
insert into DETALLECOMPRPRODU values(@cveproductos,@cvecompras,@fechacaducidad,@cantidadcompra)
update COMPRAS set TOTALCOMPRA=TOTALCOMPRA+@cantidadcompra*@preciocompra where CVECOMPRAS=@cvecompras
update PRODUCTOS set PRECIOCOMPRA=@preciocompra, PRECIOVTA=@precioventa, EXISTENCIA=EXISTENCIA+@cantidadcompra, Edoproducto=1 where CVEPRODUCTOS=@cveproductos
--BD Fragmento Ventas
update ABARROTESCONSUELO_FRAGVENTAS.dbo.PRODUCTOS set PRECIOVTA=@precioventa, EXISTENCIA=EXISTENCIA+@cantidadcompra, Edoproducto=1 where CVEPRODUCTOS=@cveproductos
commit tran
end
-- finnnnnnn...
--Procedimeinto almecenado para insertar compras nuevas
	create procedure PAAgregarcompras
	as
declare @cvecompra int
IF(SELECT COuNT(*) FROM COMPRAS )=0
			SET @cvecompra= 1000
		ELSE
			SET @cvecompra=(SELECT MAX(CVECOMPRAS) FROM COMPRAS )+1
			begin tran
			insert into ABARROTESCONSUELO.dbo.compras(CVECOMPRAS) values(@cvecompra)
			insert into compras(CVECOMPRAS) values(@cvecompra)
			commit tran
	-- fin de insertar compras nuevas