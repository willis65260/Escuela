CREATE PROCEDURE Modif_nom_emp
@cve_emp int,
@nom_emp varchar(21),
@ban int output
as

if((SELECT COUNT(*) FROM EMPLEADOS where CVEEMPLEADO=@cve_emp)>0)
	begin 
		if((select VigenteEmp  from EMPLEADOS where CVEEMPLEADO=@cve_emp)=1)
			begin
				--nombre vacio
				if(@nom_emp='')
					set @ban=1
				else if(LEN(@nom_emp)>20)
				--no puede ser mayor  a 20 la longitud
					set @ban=2
				else
					begin
						begin tran
							update EMPLEADOS set NOMBRE=@nom_emp where CVEEMPLEADO=@cve_emp
							update ABARROTESCONSUELO.dbo.EMPLEADOS set NOMBRE=@nom_emp where CVEEMPLEADO=@cve_emp
						commit tran
					end
			end
		else
		--el empleado esta desactivado
			set @ban=3
	end
else
--el empleado no se encuentra
	set @ban=4

create procedure Modif_app_emp
@cve_emp int,
@apep_emp varchar(16),
@ban int output
as
if((SELECT COUNT(*) FROM EMPLEADOS where CVEEMPLEADO=@cve_emp)>0)
	begin 
	if((select VigenteEmp  from EMPLEADOS where CVEEMPLEADO=@cve_emp)=1)
			begin
--apellido p. vacio
if(@apep_emp='')
	set @ban=1
else if(LEN(@apep_emp)>15)
--longitud de apellido no debe ser mayor a 15
	set @ban=2
else

	begin
		begin tran
			update EMPLEADOS set APELLIDOP=@apep_emp where CVEEMPLEADO=@cve_emp
			update ABARROTESCONSUELO.dbo.EMPLEADOS set APELLIDOP=@apep_emp where CVEEMPLEADO=@cve_emp
		commit tran
	end
	end
		else
		--el empleado se encuentra desactivado
			set @ban=3
	end
else
--el empleado no se encontro
	set @ban=4


create procedure Modif_apm_emp
@cve_emp int,
@apem_emp varchar(16),
@ban int output
as
if((SELECT COUNT(*) FROM EMPLEADOS where CVEEMPLEADO=@cve_emp)>0)
	begin 
	if((select VigenteEmp  from EMPLEADOS where CVEEMPLEADO=@cve_emp)=1)
			begin
--apellido m. vacio
if(@apem_emp='')
	set @ban=1
else if(LEN(@apem_emp)>15)
--la longitud del apellido materno no puede ser mayor a 15
	set @ban=2
else
	begin
		begin tran
			update EMPLEADOS set APELLIDOM=@apem_emp where CVEEMPLEADO=@cve_emp
			update ABARROTESCONSUELO.dbo.EMPLEADOS set APELLIDOM=@apem_emp where CVEEMPLEADO=@cve_emp
		commit tran
	end
	end
		else
		--el empelado se encuentra desactivado
			set @ban=3
	end
else
--el emplado no se encuentra registardo
	set @ban=4


create procedure Modif_tel_emp
@cve_emp int,
@telefono_emp varchar(13),
@ban int output
as
if((SELECT COUNT(*) FROM EMPLEADOS where CVEEMPLEADO=@cve_emp)>0)
	begin 
	if((select VigenteEmp  from EMPLEADOS where CVEEMPLEADO=@cve_emp)=1)
			begin
--telefono. vacio
if(@telefono_emp='')
	set @ban=1
else if(LEN(@telefono_emp)>12)
--la longitud delntelefono no pueder mayor a 12
	set @ban=2
else
	begin
		begin tran
			update EMPLEADOS set TELEFONO=@telefono_emp where CVEEMPLEADO=@cve_emp
			update ABARROTESCONSUELO.dbo.EMPLEADOS set TELEFONO=@telefono_emp where CVEEMPLEADO=@cve_emp
		commit tran
	end
	end
		else
		--el empleado se esncuntra suspendido
			set @ban=3
	end
else
-- no se encontro el empleado en la base de datos
	set @ban=4

		--este es para una vez que se dio de baja un empleado y se quiere volver a dar de alta se pueda mediante este procedimeinto
create procedure Modif_vigencia_emp
@cve_emp int,
@vigencia_emp int,
@ban int output
as
if((SELECT COUNT(*) FROM EMPLEADOS where CVEEMPLEADO=@cve_emp)>0)
	begin 
	if((select VigenteEmp  from EMPLEADOS where CVEEMPLEADO=@cve_emp)=1)
			begin
--apellido p. vacio
if(@vigencia_emp!=1 or @vigencia_emp!=0)
	set @ban=1
else
	begin
		begin tran
			update EMPLEADOS set VigenteEmp=@vigencia_emp where CVEEMPLEADO=@cve_emp
			update ABARROTESCONSUELO.dbo.EMPLEADOS set VigenteEmp=@vigencia_emp where CVEEMPLEADO=@cve_emp
		commit tran
	end
	end
		else
			set @ban=3
	end
else
	set @ban=4

create procedure Modif_turno_emp
@cve_emp int,
@turno varchar(11),
@ban int output
as
if((SELECT COUNT(*) FROM EMPLEADOS where CVEEMPLEADO=@cve_emp)>0)
	begin 
	if((select VigenteEmp  from EMPLEADOS where CVEEMPLEADO=@cve_emp)=1)
			begin
--turno. vacio
if(@turno='')
	set @ban=1
else if(LEN(@turno)>10)
	set @ban=2
else
	begin
		begin tran
			update EMPLEADOS set TURNO=@turno where CVEEMPLEADO=@cve_emp
			update ABARROTESCONSUELO.dbo.EMPLEADOS set TURNO=@turno where CVEEMPLEADO=@cve_emp
		commit tran
	end
	end
		else
		--el empleado se encuentra desactivado
			set @ban=3
	end
else
--el empleado no se encontro en la base de datos
	set @ban=4