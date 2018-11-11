--
-- Prueba de consutlas.
--

-- Cantidad total de libros.

select count (iLibroId)
from Libro;

-- Título de los libros.

select cNombreLibro
from Libro;

-- Títulos de los libros del mueble Fede.

select L.cNombreLibro
from Libro as L inner join Ubicacion as U
on L.iUbicacion = U.iUbicacionId
where U.cMueble = 'fede';

-- Título de los libros del mueble Pau.

select L.cNombreLibro
from Libro as L inner join Ubicacion as U
on L.iUbicacion = U.iUbicacionId
where U.cMueble = 'pau';

-- Libro más caro y su precio.

select cNombreLibro, iPrecio
from Libro
where iPrecio = (select max (iPrecio)
				 from Libro);

-- El precio del libro más caro  de cada mueble.

select max (L.iPrecio)
from Libro as L inner join Ubicacion as U
on L.iUbicacion = U.iUbicacionId
group by U.cMueble;
 
-- Los libros más caros de cada mueble con su precio.

-- (ver)


-- Los autores de la Editorial América.

select distinct A.cNombreAutor, A.cApellidoAutor
from Autor as A inner join Libro as L
on A.iAutorId = L.iAutorId
where L.iEditorialId = 1;


