--
-- DDL - Tipo de datos
--
--		 Lógico - boolean
--		 Caracter - char, varchar
--		 Numérico - numeric, decimal, integer, smallint
--		 Numérico aproximado - float, real, double precision
--		 Fecha y tiempo - date, time, timestamp
--		 Intervalo - interval


--
-- DDL - Creacion de las tablas de la DB
--

create table Libro  (
	iLibroId integer not null,
	cNombreLibro varchar(254) not null,
	iAutorId integer not null,
	iAnioPublicacion integer,
	iUbicacion integer not null,
	iEditorialId integer,
	iPrecio integer not null, 
	PRIMARY KEY (iLibroId)
);

create table Autor (
	iAutorId integer not null,
	cNombreAutor varchar(254),
	cApellidoAutor varchar(254),
	primary key (iAutorId)
);

create table Ubicacion (
	iUbicacionId integer not null,
	cMueble varchar (254) not null,
	iEstante integer not null,
	iLugar integer not null,
	primary key (iUbicacionId)
);

create table Fede (
	iFedeId integer not null,
	cNombreLibro varchar (254) not null,
	primary key (iFedeId)
);

create table Pau (
	iPauId integer not null,
	cNombreLibro varchar (254) not null,
	primary key (iPauId)
);

create table Editorial (
	iEditorialId integer not null,
	cNombreEditorial varchar (254) not null,
	cPais varchar (254),
	primary key (iEditorialId)
);


--
-- DDL - Eliminación de tablas
--

drop table Autor;
drop table Fede;
drop table libro;
drop table Ubicacion;
drop table Pau
--
-- DDL - Modificación de tablas
--

-- Agregar columna

alter table autor add cNacionalidad varchar (254)

alter table Libro add iEditorialId integer;

alter table Libro add iPrecio integer;

-- Cambiar la definición de columnas

alter table ubicacion alter column cEstante varchar (254) 

-- Agrega o quita restricciones (ver mejor)

alter table ubicacion add constraint ilugar primary key (ilugar)


