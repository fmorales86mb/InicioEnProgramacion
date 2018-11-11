--
-- Agregación y agrupamiento.
--


-- Máximo y Mínimo (Max, Min).

select max (iEstante), min (iEstante)
from Ubicacion;

-- Contar filas (Count).

select count (cNombreLibro)
from Libro;

-- Suma de valores (Sum).

select sum (iAnioPublicacion)
from Libro;

-- Promedio de valores (Avg).

select avg (iAnioPublicacion)
from Libro;

-- Agrupamiento (Grup by)

-- Las funciones de agregación trabajan sobre grupos de filas. El GROUP BY agrupa 
-- para que las funciones de agregación trabajen

select cMueble, max (iEstante), min (iEstante)
from Ubicacion
group by cMueble;

-- Restricción sobre el grupo (Having)


select U.cMueble, avg (L.iAnioPublicacion)
from Ubicacion U, Libro L
group by U.cMueble 
having count (*) > 9;

-- El HAVING pone condiciones o restricciones a los grupos. El WHERE a las filas.
