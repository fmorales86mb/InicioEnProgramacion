--
-- DML - Seleccionar datos (select)
--

-- Operadores
-- =, <, >, <=, >=, <>	igual, menor, mayor, menor igual, mayor igual, distinto.
-- [not] between		entre dos valores (inclusive).
-- is [not] null		comparación con valores nulos.
-- [not] like			comparación de string con comodines.
-- [not] in				pertenencia a una lista de valores.
-- not					negación.

select Libro.cNombre, Autor.cNombre, Autor.cApellido, Libro.iAnioPublicacion 
from Libro, Autor
where
	Autor.cApellido = 'marx' and
	Libro.iAnioPublicacion = 1841 and
	Libro.iAutorId = Autor.iAutorId

-- query mas complejo

select Libro.cNombre, Autor.cNombre, Autor.cApellido, Libro.iAnioPublicacion 
from Libro, Autor
where
	Libro.iAutorId = Autor.iAutorId and 
	Libro.iAnioPublicacion > 1930 and 
	libro.iAnioPublicacion < 1990


-- Junta básica

select Libro.iLibroId, Libro.cNombreLibro
from libro, Ubicacion
where
	Libro.iUbicacion = Ubicacion.iUbicacionId and
	Ubicacion.cMueble = 'fede'

-- Not in

select iLibroId 
from Libro
where 
	Libro.bActivo = 1 and
	Libro.iLibroId not in	(select iLibroId 
							 from PrestamoLibro 
							 where 
								bActivo = 1 and
								PrestamoLibro.iLibroId = Libro.iLibroId)

-- Alias (ej. anterior)
	
select L.iLibroId, L.cNombreLibro
from Libro as L, Ubicacion as U
where
	L.iUbicacion = U.iUbicacionId and
	U.cMueble = 'fede' 
	


--
-- DML - Ordenar una consulta (order by)
--

select iLibroId, cNombreLibro, iAutorId, iAnioPublicacion, iUbicacion
from Libro
order by cNombreLibro	
	 


-- 
-- DML - Ingresar filas (insert)
--

insert into Libro (iLibroId, cNombreLibro, iAutorId, iAnioPublicacion, iubicacion, iEditorialId, iPrecio) values (1, '10 dias...',1, 1918, 1, 1, 35);
insert into Libro (iLibroId, cNombreLibro, iAutorId, iAnioPublicacion, iubicacion, iEditorialId, iPrecio) values (2, 'rebelion en la granja',2, 1940, 2, 2, 26);
insert into Libro (iLibroId, cNombreLibro, iAutorId, iAnioPublicacion, iubicacion, iEditorialId, iPrecio) values (3, 'El capital',3, 1840, 3, 1, 94);
insert into Libro (iLibroId, cNombreLibro, iAutorId, iAnioPublicacion, iubicacion, iEditorialId, iPrecio) values (4, 'el capital 2',3, 1841, 4, 2, 97);
insert into Libro (iLibroId, cNombreLibro, iAutorId, iAnioPublicacion, iubicacion, iEditorialId, iPrecio) values (5, 'como criar conejos',5, 1978, 5, 1, 15);

insert into Autor (iAutorId, cNombreAutor, cApellidoAutor) values (1, 'jonh', 'reed');
insert into Autor (iAutorId, cNombreAutor, cApellidoAutor) values (2, 'pepe', 'orwel');
insert into Autor (iAutorId, cNombreAutor, cApellidoAutor) values (3, 'carlos', 'marx');
insert into Autor (iAutorId) values (4);

insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (1, 'fede', 1, 1);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (2, 'fede', 1, 2);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (3, 'fede', 1, 3);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (4, 'fede', 2, 1);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (5, 'pau', 1, 1);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (6, 'pau', 1, 2);

insert into Editorial (iEditorialId, cNombreEditorial, cPais) values (1, 'América', 'Argentina');
insert into Editorial (iEditorialId, cNombreEditorial, cPais) values (2, 'Problemas', 'URSS');

-- Copiar datos de una tabla a otra a partir de una juntada.

insert into fede (iFedeId, cNombreLibro)
	select Libro.iLibroId, Libro.cNombreLibro
	from libro, Ubicacion
	where
		Libro.iUbicacion = Ubicacion.iUbicacionId and
		Ubicacion.cMueble = 'fede'
	;

insert into Pau (iPauId, cNombreLibro)
	select Libro.iLibroId, Libro.cNombreLibro 
	from Libro, Ubicacion
	where
		Libro.iUbicacion = Ubicacion.iUbicacionId and
		Ubicacion.cMueble = 'pau'
;




--
-- DML - Modificación de filas (update)
--

update Libro set cNombreLibro = 'Cria de conejos en jaula' where iLibroId = 5;
update Ubicacion set cMueble = 'pau' where iUbicacionId = 4;




--
-- DML - eliminar filas (delete)
--

delete from Libro where iLibroId = 4;
delete from Ubicacion where cMueble = 'fede';
delete from Pau where iPauId = 5;
delete from Libro where iLibroId < 10;


--
-- DML - filtra las secuencias duplicadas (distinct).
--

select distinct cMueble
from Ubicacion;

--
-- DML - Buscar coincidencias (like)
--

-- Comodines
-- %		Coincide con cualquier substring que contenga uno o más caracteres.
-- _		Coincide con un caracter.

select *
from Libro
where cNombreLibro like '%capital%';



select distinct A.cApellido
from Libro as L, Autor as A
where 
	L.iAutorId = A.iAutorId and
	L.cNombreLibro like '%capital%';

-- Último Id de una tabla.

select IDENT_CURRENT ('Autor') as algo;

