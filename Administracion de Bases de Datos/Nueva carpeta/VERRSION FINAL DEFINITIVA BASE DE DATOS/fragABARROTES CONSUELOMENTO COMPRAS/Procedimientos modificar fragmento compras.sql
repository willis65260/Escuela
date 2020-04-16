--modificar provedores
--modificar el nombre del provedor
create procedure modinombrepro
@cveprov int,
@NombPro varchar(31),
@Ban int output
as

if((select count(*) from PROVEDORES where CVEPROVEDORES=@cveprov )>0 )
if(select VigenteProv  from PROVEDORES where CVEPROVEDORES=@cveprov)=1
	begin 
	begin tran
	update PROVEDORES set NOMBREPROV=@NombPro where CVEPROVEDORES=@cveprov
	update ABARROTESCONSUELO.dbo.PROVEDORES set NOMBREPROV=@NombPro where CVEPROVEDORES=@cveprov
	set @Ban=1
	commit tran
	end
else
--el provedor se encuentra no vigente
set @Ban=2
else
--No se encuentra el provedor en la base de datos
set @Ban=3
--modficar el telefono del provedor
create procedure moditelefonopro
@cveprov int,
@telprov varchar(30),
@Ban int output
as
if((select count(*) from PROVEDORES where CVEPROVEDORES=@cveprov )>0)
if(select VigenteProv  from PROVEDORES where CVEPROVEDORES=@cveprov)=1
begin 
begin tran
update PROVEDORES set TELEFONO=@telprov where CVEPROVEDORES=@cveprov
update ABARROTESCONSUELO.dbo.PROVEDORES set TELEFONO=@telprov where CVEPROVEDORES=@cveprov
set @Ban=1
commit tran
end
else
--el provedor se encuentra no vigente
set @Ban=2
else
--No se encuentra el provedor en la base de datos
set @Ban=3

--modificar la direccion del provedor
create procedure modidireccionpro
@cveprov int,
@dirprov varchar(50),
@Ban int output
as
if((select count(*) from PROVEDORES where CVEPROVEDORES=@cveprov )>0)
if(select VigenteProv  from PROVEDORES where CVEPROVEDORES=@cveprov)=1
begin 
begin tran
update PROVEDORES set DIRECCION=@dirprov  where CVEPROVEDORES=@cveprov
update ABARROTESCONSUELO.dbo.PROVEDORES set DIRECCION=@dirprov  where CVEPROVEDORES=@cveprov
set @Ban=1
commit tran
end
else
--el provedor se encuentra no vigente
set @Ban=2
else
--No se encuentra el provedor en la base de datos
set @Ban=3

--para despues de dar de baja un provedor y si despues s evuelve a tener un nuevo contacto con el
create procedure modificarvigenciaprov
@cveprov int,
@vigencia int,
@Ban int output
as
if((SELECT COUNT(*) FROM PROVEDORES where CVEPROVEDORES=@cveprov)>0)
	begin 
	if((select VigenteProv  from PROVEDORES where CVEPROVEDORES=@cveprov)=1)
			begin
if(@vigencia!=1 or @vigencia!=0)
--Digite estados validos 0 o 1
	set @ban=1
else
	begin
		begin tran
			update PROVEDORES set VigenteProv=@vigencia where CVEPROVEDORES=@cveprov
			update ABARROTESCONSUELO.dbo.PROVEDORES set VigenteProv=@vigencia where CVEPROVEDORES=@cveprov
		commit tran
	end
	end
		else
		--solo se puede volver a activar el provedor con un 1
			set @ban=3
	end
else
--no se encuentra este provedor que quiere modificar
	set @ban=4

---------------------modificar productos----------------------------------------
CREATE PROCEDURE Modif_nom_prod
@cve_prod int,
@nom_prod varchar(33),
@ban int output
as
if((select COUNT(*) from PRODUCTOS where CVEPRODUCTOS=@cve_prod)>0)
	begin 
if((select Edoproducto from PRODUCTOS where CVEPRODUCTOS=@cve_prod)=1)
	begin 
if(@nom_prod='')
--nombre vacio
	set @ban=1
else if(LEN(@nom_prod)>32)
--nombre no puede exeder 32 digitos
	set @ban=2
else
	begin
		begin tran
			update PRODUCTOS set NOMBREPRO=@nom_prod where CVEPRODUCTOS=@cve_prod
			update ABARROTESCONSUELO.dbo.PRODUCTOS set NOMBREPRO=@nom_prod where CVEPRODUCTOS=@cve_prod
			update ABARROTESCONSUELO_FRAGVENTAS.dbo.PRODUCTOS set NOMBREPRO=@nom_prod where CVEPRODUCTOS=@cve_prod
		commit tran
	end
end
		else
		--el producto se encuentra dado de baja no se puede hacer cambios
			set @ban=3
	end
else
--el producto no se encuentra en la base de datos
	set @ban=4

-- no se podran modificar las existencias ya que quedara inconsistente nuestras compras ua que no cuadrara 
--lo que compramos y vendemos con las existencias

------- volver a activar un producto que ya habiamos dado de baja----
CREATE PROCEDURE Modif_edo_prod
@cve_prod int,
@edo_prod int,
@ban int output
as
if((select COUNT(*) from PRODUCTOS where CVEPRODUCTOS=@cve_prod)>0)
begin 

if(@edo_prod!=0 or @edo_prod!=1)
-- el estado introducido no es valido
	set @ban=1
else
	begin
	if(@edo_prod=1 and (select Edoproducto from PRODUCTOS where CVEPRODUCTOS=@cve_prod)=0)
	  begin
		begin tran
			update PRODUCTOS set Edoproducto=@edo_prod where CVEPRODUCTOS=@cve_prod
			update ABARROTESCONSUELO.dbo.PRODUCTOS set Edoproducto=@edo_prod where CVEPRODUCTOS=@cve_prod
			update ABARROTESCONSUELO_FRAGVENTAS.dbo.PRODUCTOS set Edoproducto=@edo_prod where CVEPRODUCTOS=@cve_prod
		commit tran
		end
		else
		--para dar de baja debe de hacerlo en su apartado correspondiente
			set @ban=4
	end
end
		else
		--no se encuentra el producto en las bases de datos
			set @ban=3


CREATE PROCEDURE Modif_precv_prod
@cve_prod int,
@prec_vta int,
@ban int output
as
if((select COUNT(*) from PRODUCTOS where CVEPRODUCTOS=@cve_prod)>0)
	begin 
		if((select Edoproducto from PRODUCTOS where CVEPRODUCTOS=@cve_prod)=1)
			begin
			if(@prec_vta=0 or @prec_vta is null)
			begin
				--el precio venta no puede ser null o 0
			set @ban=4
			end
			else
			begin
			begin tran
					update PRODUCTOS set PRECIOVTA=@prec_vta where CVEPRODUCTOS=@cve_prod
					update ABARROTESCONSUELO.dbo.PRODUCTOS set PRECIOVTA=@prec_vta where CVEPRODUCTOS=@cve_prod
					update ABARROTESCONSUELO_FRAGVENTAS.dbo.PRODUCTOS set PRECIOVTA=@prec_vta where CVEPRODUCTOS=@cve_prod
				commit tran
			end
			end
		else
		--el producto se encuentra dado de baja no se puede modificar
			set @ban=3
	end
else
-- el producto no se encuentra en la base de datos
	set @ban=4

	----el precio compra no se podra modificar por que quedaria inconsistete nuestra tabla de compras 