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
			set @ban=3
	end
else
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
			set @ban=3
	end
else
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
--apellido p. vacio
if(@apem_emp='')
	set @ban=1
else if(LEN(@apem_emp)>15)
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
			set @ban=3
	end
else
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
--apellido p. vacio
if(@telefono_emp='')
	set @ban=1
else if(LEN(@telefono_emp)>12)
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
			set @ban=3
	end
else
	set @ban=4

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
--apellido p. vacio
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
			set @ban=3
	end
else
	set @ban=4