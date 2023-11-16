create database creditos
go
use creditos

create table profesion(id_profesion int identity(1,1)primary key,
                                    descripcion varchar(20))

insert profesion (descripcion) values ('profesor')
insert profesion (descripcion) values ('doctor')
insert profesion (descripcion) values ('programador')
insert profesion (descripcion) values ('ingeniero civil')

select * from profesion

create table clientes(
Rut numeric (9)primary key,
DV char(1),
nombre varchar (25),
fecha_nacimiento varchar(25),
Apellido_paterno varchar (20),
Apellido_materno varchar (20),
Sueldo_liquido varchar (100),
id_profesion int foreign key references profesion(id_profesion)
)

create table credito (
Codigo varchar (5)primary key,
Nombre varchar (50),
tasa_interes varchar(4),
Edad_maxima numeric(3),
monto_minimo numeric(9),
monto_maximo numeric(9),
Sueldo_minimo numeric(8),
)

select * from clientes
select * from credito
exec ValidarCredito 19376507,1000000,1
create or alter procedure ValidarCredito(@rut_cliente numeric (9),
                                         @monto_solicitado numeric(9),
                                         @Codigo_Credito varchar (5))
as
begin
  -- validar que el monto solicitasdo esté dentro del rango
      declare @monto_min numeric(9)
      declare @monto_max numeric(9)
 
      select @monto_min = monto_minimo,
           @monto_max  = monto_maximo
      from credito where codigo = @Codigo_Credito

      if(@monto_solicitado >=@monto_min AND @monto_solicitado <=@monto_max)
        select 0 as cod_retorno, 'Monto dentro del rango' as Mensaje
    else
        select 1 as cod_retorno, 'Error monto fuera del rango' as Mensaje
end

--La edad del cliente más el plazo del crédito debe ser menor o igual a la edad máxima del tipo de crédito seleccionado.
exec ValidarEdad 2,1000000,1,12
create or alter procedure ValidarEdad  (@rut_cliente numeric (9),
                                        @monto_solicitado numeric(9),
                                        @Codigo_Credito varchar (5),
                                        @plazo int)
as
begin
      declare @fecha_nac date
            select @fecha_nac = fecha_nacimiento
      from clientes where Rut = @rut_cliente

      declare @cliente_año_nac int
      declare @edad_cliente int

            select @cliente_año_nac = year(@fecha_nac)
            select @edad_cliente = year(getdate()) - @cliente_año_nac


      declare @edad_maxima int  
            select @edad_maxima = Edad_maxima
      from credito where codigo = @Codigo_Credito

      if( @edad_cliente + @plazo <= @edad_maxima)
        select 0 as cod_retorno, 'Edad valida' as Mensaje
      else
        select 1 as cod_retorno, 'Error, no cumple edad maxima permitida' as Mensaje
end
--El sueldo del cliente debe ser mayor o igual al sueldo mínimo del tipo de crédito seleccionado.
exec ValidarSueldo 1,1000000,1,12,1500000
create or alter procedure ValidarSueldo (@rut_cliente numeric (9),
                                         @monto_solicitado numeric(9),
                                         @Codigo_Credito varchar (5),
                                         @plazo int,
                                         @sueldo_cliente numeric(9))
as
begin
      declare @sueldo_minimo numeric(9)
            select @sueldo_minimo = sueldo_minimo
      from credito
      where codigo = @Codigo_Credito

      if (@sueldo_cliente >= @sueldo_minimo)
            select 0 as cod_retorno, 'Sueldo válido' as Mensaje
	  else
			select 1 as cod_retorno, 'Error, sueldo insuficiente' as Mensaje
end