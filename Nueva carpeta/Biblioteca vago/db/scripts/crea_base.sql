/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     23/07/2016 18:07:55                          */
/*==============================================================*/


/*==============================================================*/
/* Table: Autor                                                 */
/*==============================================================*/
create table Autor (
   iAutorId             integer              identity,
   cNombre              varchar(254)         not null,
   cApellido            varchar(254)         not null,
   constraint PK_AUTOR primary key (iAutorId)
)
go

/*==============================================================*/
/* Table: Biblioteca                                            */
/*==============================================================*/
create table Biblioteca (
   iBibliotecaId        integer              identity,
   cNombre              varchar(254)         not null,
   cDescripcion         varchar(400)         null,
   constraint PK_BIBLIOTECA primary key (iBibliotecaId)
)
go

/*==============================================================*/
/* Table: Editorial                                             */
/*==============================================================*/
create table Editorial (
   iEditorialId         integer              identity,
   cNombre              varchar(254)         not null,
   cDireccion           varchar(254)         null,
   constraint PK_EDITORIAL primary key (iEditorialId)
)
go

/*==============================================================*/
/* Table: Idioma                                                */
/*==============================================================*/
create table Idioma (
   iIdiomaId            integer              identity,
   cNombre              varchar(254)         not null,
   constraint PK_IDIOMA primary key (iIdiomaId)
)
go

/*==============================================================*/
/* Table: Libro                                                 */
/*==============================================================*/
create table Libro (
   iLibroId             integer              identity,
   iEditorialId         integer              not null,
   iAutorId             integer              not null,
   iIdiomaId            integer              null,
   iTipoLibroId         integer              null,
   cDescripcionCorta    varchar(100)         not null,
   cDescripcionLarga    varchar(400)         null,
   iAnioEdicion         integer              null,
   bActivo              bit                  not null,
   constraint PK_LIBRO primary key (iLibroId)
)
go

/*==============================================================*/
/* Table: PrestamoLibro                                         */
/*==============================================================*/
create table PrestamoLibro (
   iPrestamoLibroId     integer              identity,
   iSocioId             integer              not null,
   iLibroId             integer              not null,
   dFechaSalida         date                 not null,
   dFechaDevolucion     date                 not null,
   constraint PK_PRESTAMOLIBRO primary key (iPrestamoLibroId)
)
go

/*==============================================================*/
/* Table: Socio                                                 */
/*==============================================================*/
create table Socio (
   iSocioId             integer              identity,
   cNombre              varchar(254)         not null,
   cApellido            varchar(254)         not null,
   dFechaDeAlta         date                 not null,
   dFechaDeBaja         date                 null,
   bActivo              bit                  not null,
   constraint PK_SOCIO primary key (iSocioId)
)
go

/*==============================================================*/
/* Table: TipoLibro                                             */
/*==============================================================*/
create table TipoLibro (
   iTipoLibroId         integer              identity,
   cNombre              varchar(254)         not null,
   cDescripcion         varchar(400)         null,
   constraint PK_TIPOLIBRO primary key (iTipoLibroId)
)
go

/*==============================================================*/
/* Table: UbicacionLibro                                        */
/*==============================================================*/
create table UbicacionLibro (
   iLibroId             integer              not null,
   iBibliotecaId        integer              not null,
   iEstanteId           integer              not null,
   constraint PK_UBICACIONLIBRO primary key (iLibroId)
)
go

