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
	cNombre varchar(254) not null,
	iAutorId integer not null,
	iAnioPublicacion integer,
	PRIMARY KEY (iLibroId)
);

create table Autor (
	iAutorId integer not null,
	cNombre varchar(254),
	cApellido varchar(254),
	primary key (iAutorId)
);

create table Ubicacion (
	iUbicacionId integer not null,
	cMueble varchar (254) not null,
	iEstante integer not null,
	iLugar integer not null,
	primary key (iUbicacionId)
);


--
-- DDL - Eliminación de tablas
--

drop table Autor;

--
-- DDL - Modificación de tablas
--

-- Agregar columna

alter table autor add cNacionalidad varchar (254)

-- Cambiar la definición de columnas

alter table ubicacion alter column cEstante varchar (254) 

