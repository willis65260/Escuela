--Procedimiento para eliminar empleados
create procedure bajaempleado
@cve_empleado int,
@ban int output
as
if((select count(*) from DETALLEEMPVTA where CVEEMPLEADO=@cve_empleado)=0)
	begin
		begin tran
			delete from EMPLEADOS where CVEEMPLEADO=@cve_empleado
			delete from ABARROTESCONSUELO.dbo.EMPLEADOS where CVEEMPLEADO=@cve_empleado
		commit tran
	end
else
	begin
		begin tran
			update EMPLEADOS set VigenteEmp=0
			update ABARROTESCONSUELO.dbo.EMPLEADOS set VigenteEmp=0
		commit tran
	end

--Procedimiento para eliminar ventas
/*create*/ alter procedure bajaventa
@cve_producto int,
@cve_venta int,
@ban int output
as
if((select count(*) from DETALLEVTAPROD where CVEPRODUCTO=@cve_producto and CVEVENTA=@cve_venta)=0)
--no hay producto registrado en esa venta
set @ban=1
else
	begin
		begin tran
				update PRODUCTOS set EXISTENCIA=EXISTENCIA+(select CANTIDADVTA from DETALLEVTAPROD where CVEPRODUCTO=@cve_producto and CVEVENTA=@cve_venta)where CVEPRODUCTOS=@cve_producto
				update ABARROTESCONSUELO.dbo.PRODUCTOS set EXISTENCIA=EXISTENCIA+(select CANTIDADVTA from DETALLEVTAPROD where CVEPRODUCTO=@cve_producto and CVEVENTA=@cve_venta) where CVEPRODUCTOS=@cve_producto
				update ABARROTESCONSUELOfracompras.dbo.PRODUCTOS set EXISTENCIA=EXISTENCIA+(select CANTIDADVTA from DETALLEVTAPROD where CVEPRODUCTO=@cve_producto and CVEVENTA=@cve_venta) where CVEPRODUCTOS=@cve_producto

				update VENTAS set TOTALVTA=TOTALVTA-((select CANTIDADVTA from DETALLEVTAPROD where CVEPRODUCTO=@cve_producto and CVEVENTA=@cve_venta)*(select PRECIOVTA from PRODUCTOS where CVEPRODUCTOS=@cve_producto))where CVEVENTA=@cve_venta
				update ABARROTESCONSUELO.dbo.VENTAS set TOTALVTA=TOTALVTA-((select CANTIDADVTA from DETALLEVTAPROD where CVEPRODUCTO=@cve_producto and CVEVENTA=@cve_venta)*(select PRECIOVTA from PRODUCTOS where CVEPRODUCTOS=@cve_producto)) where CVEVENTA=@cve_venta
				
				delete  from DETALLEVTAPROD where CVEPRODUCTO=@cve_producto and CVEVENTA=@cve_venta
				delete  from ABARROTESCONSUELO.dbo.DETALLEVTAPROD where CVEPRODUCTO=@cve_producto and CVEVENTA=@cve_venta
		
			if((select COUNT(*) from DETALLEVTAPROD where CVEVENTA=@cve_venta)=0)
				begin
					delete  from VENTAS where CVEVENTA=@cve_venta
					delete  from ABARROTESCONSUELO.dbo.VENTAS where CVEVENTA=@cve_venta
				end
		commit tran
	end

--Baja de Proguctos--
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
		end
end