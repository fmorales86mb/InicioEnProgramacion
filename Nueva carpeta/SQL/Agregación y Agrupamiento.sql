--
-- Agregaci�n y agrupamiento.
--


-- M�ximo y M�nimo (Max, Min).

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

-- Las funciones de agregaci�n trabajan sobre grupos de filas. El GROUP BY agrupa 
-- para que las funciones de agregaci�n trabajen

select cMueble, max (iEstante), min (iEstante)
from Ubicacion
group by cMueble;

-- Restricci�n sobre el grupo (Having)


select U.cMueble, avg (L.iAnioPublicacion)
from Ubicacion U, Libro L
group by U.cMueble 
having count (*) > 9;

-- El HAVING pone condiciones o restricciones a los grupos. El WHERE a las filas.
