--
-- Junta Interna (inner join) o Junta básica
-- 

select L.cNombreLibro, U.cMueble
from Libro as L, Ubicacion as U
where 
	L.iUbicacion = U.iUbicacionId;

-- Es equivalente a:

select L.cNombreLibro, U.cMueble
from Libro as L inner join Ubicacion as U on U.iUbicacionId = L.iUbicacion;


--
-- Junta Externa (outer join) 
--

-- Left Outer Join
-- Retorna: inner join, filas de A que NO entran en la junta.


select L.cNombreLibro, U.cMueble, U.iEstante, U.iLugar
from Libro L
Left outer join Ubicacion U on L.iUbicacion = U.iUbicacionId;



-- Right Outer Join
-- Retorna: inner join, filas de B que NO entran en la junta.

select L.cNombreLibro, U.cMueble, U.iEstante, U.iLugar
from Libro L
right outer join Ubicacion U on L.iUbicacion = U.iUbicacionId;


-- Full Outer Join
-- Retornan: inner join, filas de A que NO entran en la junta, filas de B
-- que NO entran en la junta.

select L.cNombreLibro, U.cMueble, U.iEstante, U.iLugar
from Libro L
full outer join Ubicacion U on L.iUbicacion = U.iUbicacionId;


