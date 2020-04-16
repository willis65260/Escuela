--Procedimientos almacenados para Eliminaciones fragmento Compras------
---------------Eliminar provedores----
create procedure Bajaprovedoresfragcompras
@cveprov int,
@ban int output
As
if(select count(*) from PROVEDORES where CVEPROVEDORES=@cveprov)>0
begin
if (select count(*) from DETALLEPROVCOMP where CVEPROVEDORES=@cveprov)>0
begin
begin tran 
update PROVEDORES set VigenteProv=0 where CVEPROVEDORES=@cveprov
-- modificaciones en bade de datos general----
update ABARROTESCONSUELO.dbo.PROVEDORES set VigenteProv=0 where CVEPROVEDORES=@cveprov
commit tran
end
else
begin
begin tran
delete provedores where CVEPROVEDORES=@cveprov
commit tran
end
end
else
--el provedor no se encuentra en la base de datos
set @ban=1


------------eliminar comprasssss------
create procedure Bajacomprascompleta
@cvecompra int,
@cveproducto int,
@ban int output
As
declare @cantidad int
declare @preciocom money
if(select count(*) from DETALLECOMPRPRODU where CVECOMPRA=@cvecompra and CVEPRODUCTO=@cveproducto)=0
begin
--La compra no esta relacionada con dicho producto
set @ban=1
end
else
begin 
set @cantidad=(select CANTIDADCOMP from DETALLECOMPRPRODU where CVECOMPRA=@cvecompra and CVEPRODUCTO=@cveproducto)
set @preciocom=(select PRECIOCOMPRA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)
if (select EXISTENCIA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)>=@cantidad
begin 
begin tran 
update PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto
update COMPRAS set TOTALCOMPRA=TOTALCOMPRA-(@preciocom*@cantidad) where CVECOMPRAS=@cvecompra
delete DETALLECOMPRPRODU where CVECOMPRA=@cvecompra and CVEPRODUCTO=@cveproducto
--------modificaiones en base general-----
update ABARROTESCONSUELO.dbo.PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto
update ABARROTESCONSUELO.dbo.COMPRAS set TOTALCOMPRA=TOTALCOMPRA-(@preciocom*@cantidad) where CVECOMPRAS=@cvecompra
delete ABARROTESCONSUELO.dbo.DETALLECOMPRPRODU where CVECOMPRA=@cvecompra and CVEPRODUCTO=@cveproducto
--------modificaiones en base poo frag ventas-----
update ABARROTESCONSUELO_FRAGVENTAS.dbo.PRODUCTOS set EXISTENCIA=EXISTENCIA-@cantidad where CVEPRODUCTOS=@cveproducto
commit tran
--se dio de baja el detalle correspondiete al producto y compra dada de baja
set @ban=2
if(select count(*) from DETALLECOMPRPRODU where CVECOMPRA=@cvecompra)=0
begin
-- si en la tabla detalle compra productos no hay nada ya pues eliminar la compra ya que pues esta vacia 
begin tran
--primero eliminar el detalle provedor compra
delete DETALLEPROVCOMP where CVECOMPRAS=@cvecompra
--luego la compra
delete COMPRAS where CVECOMPRAS=@cvecompra
--base de datos general------
--primero eliminar el detalle provedor compra
delete ABARROTESCONSUELO.dbo.DETALLEPROVCOMP where CVECOMPRAS=@cvecompra
--luego la compra
delete ABARROTESCONSUELO.dbo.COMPRAS where CVECOMPRAS=@cvecompra
commit tran
-----se elimino el detalle provedor compra y la compra ya que al eliminar un detalle compra producto nos dimos 
--cuenta que ya no hay nada en la compra entonces se puede eliminar la compra
set @ban=3
end
end
end

create procedure bajaproducto
@cveproducto int,
@ban int output
as
if(select count(*) from PRODUCTOS where CVEPRODUCTOS=@cveproducto)>0
begin 
if(select EXISTENCIA from PRODUCTOS where CVEPRODUCTOS=@cveproducto)>0
begin
--El producto no se puede eliminar debido a que pues hay existencias
set @ban=1
end
else
begin
begin tran
update PRODUCTOS set Edoproducto=0 where CVEPRODUCTOS=@cveproducto
--- actualizacion a la general
update ABARROTESCONSUELO.dbo.PRODUCTOS set Edoproducto=0 where CVEPRODUCTOS=@cveproducto
---Falta de la de poo
update ABARROTESCONSUELO_FRAGVENTAS.dbo.productos set Edoproducto=0 where CVEPRODUCTOS=@cveproducto
commit tran
-- se cambio el  estado del producto  
set @ban=2
end
end

