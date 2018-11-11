
/*
CREATE TABLE Persona (
	IdPersona integer not null,
	Nombre varchar(254),
	Apellido varchar(254),
	PRIMARY KEY (IdPersona)
);

CREATE TABLE Departamentos (
	IdDepartamento integer not null,
	Nombre varchar(254),
	Descripcion varchar(254),
	PRIMARY KEY (IdDepartamento)
);


CREATE TABLE PersonaPorDepartametno (
	IdPersona	integer not null,
	IdDepartamento	integer not null,
	Funcion			varchar(254),
	PRIMARY KEY (IdPersona, IdDepartamento)
);

*/

INSERT INTO Persona (IdPersona) VALUES (1);
INSERT INTO Persona (IdPersona, Nombre, Apellido) VALUES (2, 'Federico', 'Morales');
INSERT INTO Persona (IdPersona, Nombre, Apellido) VALUES (3, 'Marcelino', 'Morales');

--UPDATE Persona SET Nombre = 'Juan', Apellido = 'Perez'

SELECT * FROM Persona ORDER BY IdPersona DESC;
select * from Departamentos;
select * from PersonaPorDepartametno;

select Persona.Nombre, Departamentos.Nombre, PersonaPorDepartametno.Funcion 
FROM Persona, Departamentos, PersonaPorDepartametno
WHERE
	Persona.IdPersona = PersonaPorDepartametno.IdPersona AND
	Departamentos.IdDepartamento = PersonaPorDepartametno.IdDepartamento


select Persona.IdPersona, Departamentos.Nombre
FROM Persona, Departamentos
WHERE
	Departamentos.Nombre = 'Ventas'


WHERE
	Persona.IdPersona = PersonaPorDepartametno.IdPersona AND
	Departamentos.IdDepartamento = PersonaPorDepartametno.IdDepartamento



DELETE FROM Persona ;

insert into Departamentos (IdDepartamento, Nombre, Descripcion) values (21, 'Compras', 'Depto de compras');
insert into Departamentos (IdDepartamento, Nombre, Descripcion) values (41, 'Ventas', 'Depto de Ventas');

insert into PersonaPorDepartametno (IdDepartamento, IdPersona, Funcion) values (21, 2, 'Programador');

