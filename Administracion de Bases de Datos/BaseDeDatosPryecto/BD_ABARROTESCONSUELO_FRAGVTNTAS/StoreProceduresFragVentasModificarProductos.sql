CREATE PROCEDURE Modif_nom_prod
@cve_prod int,
@nom_prod varchar(33),
@ban int output
as
if((select COUNT(*) from PRODUCTOS where CVEPRODUCTOS=@cve_prod)>0)
	begin 
--nombre vacio
if((select Edoproducto from PRODUCTOS where CVEPRODUCTOS=@cve_prod)=1)
	begin 
if(@nom_prod='')
	set @ban=1
else if(LEN(@nom_prod)>32)
	set @ban=2
else
	begin
		begin tran
			update PRODUCTOS set NOMBREPRO=@nom_prod where CVEPRODUCTOS=@cve_prod
			update ABARROTESCONSUELO.dbo.PRODUCTOS set NOMBREPRO=@nom_prod where CVEPRODUCTOS=@cve_prod
			update ABARROTESCONSUELOfracompras.dbo.PRODUCTOS set NOMBREPRO=@nom_prod where CVEPRODUCTOS=@cve_prod
		commit tran
	end
end
		else
			set @ban=3
	end
else
	set @ban=4



CREATE PROCEDURE Modif_exis_prod
@cve_prod int,
@existencias int,
@ban int output
as
if((select COUNT(*) from PRODUCTOS where CVEPRODUCTOS=@cve_prod)>0)
	begin
--nombre vacio
if((select Edoproducto from PRODUCTOS where CVEPRODUCTOS=@cve_prod)=1)
	begin 
		if(@existencias=0)
			set @ban=1
		else if(@existencias<(select EXISTENCIA from PRODUCTOS where CVEPRODUCTOS=@cve_prod))
			set @ban=2
		else
			begin
				begin tran
					update PRODUCTOS set EXISTENCIA=@existencias where CVEPRODUCTOS=@cve_prod
					update ABARROTESCONSUELO.dbo.PRODUCTOS set EXISTENCIA=@existencias where CVEPRODUCTOS=@cve_prod
					update ABARROTESCONSUELOfracompras.dbo.PRODUCTOS set EXISTENCIA=@existencias where CVEPRODUCTOS=@cve_prod
				commit tran
			end
	end
		else
			set @ban=3
	end
else
	set @ban=4


CREATE PROCEDURE Modif_edo_prod
@cve_prod int,
@edo_prod int,
@ban int output
as
if((select COUNT(*) from PRODUCTOS where CVEPRODUCTOS=@cve_prod)>0)
	begin 
--nombre vacio

if(@edo_prod!=0 or @edo_prod!=1)
	set @ban=1
else
	begin
		begin tran
			update PRODUCTOS set Edoproducto=@edo_prod where CVEPRODUCTOS=@cve_prod
			update ABARROTESCONSUELO.dbo.PRODUCTOS set Edoproducto=@edo_prod where CVEPRODUCTOS=@cve_prod
			update ABARROTESCONSUELOfracompras.dbo.PRODUCTOS set Edoproducto=@edo_prod where CVEPRODUCTOS=@cve_prod
		commit tran
	end
end
		else
			set @ban=3


CREATE PROCEDURE Modif_precv_prod
@cve_prod int,
@prec_vta int,
@ban int output
as
if((select COUNT(*) from PRODUCTOS where CVEPRODUCTOS=@cve_prod)>0)
	begin 
--nombre vacio
		if((select Edoproducto from PRODUCTOS where CVEPRODUCTOS=@cve_prod)=1)
			begin
				begin tran
					update PRODUCTOS set PRECIOVTA=@prec_vta where CVEPRODUCTOS=@cve_prod
					update ABARROTESCONSUELO.dbo.PRODUCTOS set PRECIOVTA=@prec_vta where CVEPRODUCTOS=@cve_prod
					update ABARROTESCONSUELOfracompras.dbo.PRODUCTOS set PRECIOVTA=@prec_vta where CVEPRODUCTOS=@cve_prod
				commit tran
			end
		else
			set @ban=3
	end
else
	set @ban=4

CREATE PROCEDURE Modif_precc_prod
@cve_prod int,
@prec_comp int,
@ban int output
as
if((select COUNT(*) from PRODUCTOS where CVEPRODUCTOS=@cve_prod)>0)
	begin 
--nombre vacio
		if((select Edoproducto from PRODUCTOS where CVEPRODUCTOS=@cve_prod)=1)
			begin
				begin tran
					update ABARROTESCONSUELO.dbo.PRODUCTOS set PRECIOCOMPRA=@prec_comp where CVEPRODUCTOS=@cve_prod
					update ABARROTESCONSUELOfracompras.dbo.PRODUCTOS set PRECIOCOMPRA=@prec_comp where CVEPRODUCTOS=@cve_prod
				commit tran
			end
		else
			set @ban=3
	end
else
	set @ban=4