select * from Autor;
select * from Libro;

create table TipoAutor (
	iTipoAutorId integer not null,
	cNombre varchar (254),
	primary key (iTipoAutorId)
);

alter table Autor add  iTipoAutorId integer;

select * from libro, autor


-- left outer join

select l.cNombre, a.cApellido
from Libro l
left outer join Autor a on a.iautorId = l.iautorId


select l.iautorId, sum(iTipoAutorId) 
from libro l, autor
group by l.iAutorId

select l.iautorId, sum(iTipoAutorId) 
from libro l, autor
group by l.iAutorId



select l.cNombre as nombreLIbro, a.cApellido as NombreAutor, t.cNombre as Nombretipo
from Autor a, Libro l, TipoAutor t 
where
	 t.iTipoAutorId = a.iTipoAutorId and
	 a.iAutorId = l.iAutorId;

select l.cNombre as nombreLIbro, a.cApellido as NombreAutor, t.cNombre as Nombretipo
from Autor a
join Libro l on a.iAutorId = l.iAutorId
join TipoAutor t on t.iTipoAutorId = a.iTipoAutorId
where 
	a.capellido = 'reed'

	 

	  