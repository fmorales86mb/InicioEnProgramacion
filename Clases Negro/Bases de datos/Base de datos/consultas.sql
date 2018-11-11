--
-- Esta columna hace consultas
--

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
	



