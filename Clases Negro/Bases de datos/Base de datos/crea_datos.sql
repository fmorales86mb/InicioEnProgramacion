--
-- Crea datos en las tablas de la DB
--

insert into Libro (iLibroId, cNombre, iAutorId, iAnioPublicacion) values (1, '10 dias...',1, 1918);
insert into Libro (iLibroId, cNombre, iAutorId, iAnioPublicacion) values (2, 'rebelion en la granja',2, 1940);
insert into Libro (iLibroId, cNombre, iAutorId, iAnioPublicacion) values (3, 'El capital',3, 1840);
insert into Libro (iLibroId, cNombre, iAutorId, iAnioPublicacion) values (4, 'el capital 2',3, 1841);
insert into Libro (iLibroId, cNombre, iAutorId, iAnioPublicacion) values (5, 'como criar conejos',5, 1978);

insert into Autor (iAutorId, cNombre, cApellido) values (1, 'jonh', 'reed');
insert into Autor (iAutorId, cNombre, cApellido) values (2, 'pepe', 'orwel');
insert into Autor (iAutorId, cNombre, cApellido) values (3, 'carlos', 'marx');
insert into Autor (iAutorId) values (4);

insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (1, 'fede', 1, 1);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (2, 'fede', 1, 2);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (3, 'fede', 1, 3);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (4, 'fede', 2, 1);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (5, 'pau', 1, 1);
insert into Ubicacion (iUbicacionId, cMueble, iEstante, iLugar) values (6, 'pau', 1, 2);
