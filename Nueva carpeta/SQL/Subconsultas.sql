--
-- Subconsultas (Subqueries)
--

select L.cNombreLibro, U.iEstante
from Libro as L, Ubicacion as U
where U.iEstante = (select max (iEstante)
					from Ubicacion);

-- Sólo las columnas de la consulta exterior pueden aparecer en el resultado.
-- El WHERE y el HAVING pueden anidar subqueries.


--
-- Operadores de los subqueries 
--

-- IN		Retorna True si está incluido en los valores retornados del subquery.
-- ANY		Retorna True si la comparación es True para al menos un valor retornado del subquery.
-- ALL		Retorna True si la comparación es True para todos los valores retornados del subquery
-- EXISTS	Retorna True si el subquery retorna al menos una fila. False si retorna cero filas.

-- Los subqueries se pueden usar en el FROM. (ver por qué no se recomienda.)
