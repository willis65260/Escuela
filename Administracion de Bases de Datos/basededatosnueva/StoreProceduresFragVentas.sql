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
		

/*Procedimiento Insertar Productos*/
