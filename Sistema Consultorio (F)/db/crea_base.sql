/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     25/02/2017 0:47:29                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AdjuntoDeTratamiento') and o.name = 'FK_ADJUNTOD_REFERENCE_TRATAMIE')
alter table AdjuntoDeTratamiento
   drop constraint FK_ADJUNTOD_REFERENCE_TRATAMIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AdjuntoDeTratamiento') and o.name = 'FK_ADJUNTOD_REFERENCE_TIPOARCH')
alter table AdjuntoDeTratamiento
   drop constraint FK_ADJUNTOD_REFERENCE_TIPOARCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AdjuntoDeTratamiento') and o.name = 'FK_ADJUNTOD_REFERENCE_ARCHIVOA')
alter table AdjuntoDeTratamiento
   drop constraint FK_ADJUNTOD_REFERENCE_ARCHIVOA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EspecialidadesDeProfecional') and o.name = 'FK_ESPECIAL_REFERENCE_PROFECIO')
alter table EspecialidadesDeProfecional
   drop constraint FK_ESPECIAL_REFERENCE_PROFECIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EspecialidadesDeProfecional') and o.name = 'FK_ESPECIAL_REFERENCE_ESPECIAL')
alter table EspecialidadesDeProfecional
   drop constraint FK_ESPECIAL_REFERENCE_ESPECIAL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Paciente') and o.name = 'FK_PACIENTE_REFERENCE_OBRASOCI')
alter table Paciente
   drop constraint FK_PACIENTE_REFERENCE_OBRASOCI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Paciente') and o.name = 'FK_PACIENTE_REFERENCE_ESTADOPA')
alter table Paciente
   drop constraint FK_PACIENTE_REFERENCE_ESTADOPA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Paciente') and o.name = 'FK_PACIENTE_REFERENCE_TIPOPACI')
alter table Paciente
   drop constraint FK_PACIENTE_REFERENCE_TIPOPACI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PacientesDeTratamiento') and o.name = 'FK_PACIENTE_REFERENCE_TRATAMIE')
alter table PacientesDeTratamiento
   drop constraint FK_PACIENTE_REFERENCE_TRATAMIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PacientesDeTratamiento') and o.name = 'FK_PACIENTE_REFERENCE_PACIENTE')
alter table PacientesDeTratamiento
   drop constraint FK_PACIENTE_REFERENCE_PACIENTE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ProfecionalesDeTratamiento') and o.name = 'FK_PROFECIO_REFERENCE_PROFECIO')
alter table ProfecionalesDeTratamiento
   drop constraint FK_PROFECIO_REFERENCE_PROFECIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ProfecionalesDeTratamiento') and o.name = 'FK_PROFECIO_REFERENCE_TRATAMIE')
alter table ProfecionalesDeTratamiento
   drop constraint FK_PROFECIO_REFERENCE_TRATAMIE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Tratamiento') and o.name = 'FK_TRATAMIE_REFERENCE_ESTADOTR')
alter table Tratamiento
   drop constraint FK_TRATAMIE_REFERENCE_ESTADOTR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AdjuntoDeTratamiento')
            and   type = 'U')
   drop table AdjuntoDeTratamiento
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ArchivoAdjunto')
            and   type = 'U')
   drop table ArchivoAdjunto
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Especialidad')
            and   type = 'U')
   drop table Especialidad
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EspecialidadesDeProfecional')
            and   type = 'U')
   drop table EspecialidadesDeProfecional
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EstadoPaciente')
            and   type = 'U')
   drop table EstadoPaciente
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EstadoTratamiento')
            and   type = 'U')
   drop table EstadoTratamiento
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ObraSocial')
            and   type = 'U')
   drop table ObraSocial
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Paciente')
            and   type = 'U')
   drop table Paciente
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PacientesDeTratamiento')
            and   type = 'U')
   drop table PacientesDeTratamiento
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Profecional')
            and   type = 'U')
   drop table Profecional
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ProfecionalesDeTratamiento')
            and   type = 'U')
   drop table ProfecionalesDeTratamiento
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TipoArchivoAdjunto')
            and   type = 'U')
   drop table TipoArchivoAdjunto
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TipoPaciente')
            and   type = 'U')
   drop table TipoPaciente
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Tratamiento')
            and   type = 'U')
   drop table Tratamiento
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Usuario')
            and   type = 'U')
   drop table Usuario
go

/*==============================================================*/
/* Table: AdjuntoDeTratamiento                                  */
/*==============================================================*/
create table AdjuntoDeTratamiento (
   iArchivoAdjuntoId    integer identity(1,1) 		not null,
   iTratamientoId       integer              not null,
   iTipoArchivoAdjuntoId integer              null,
   constraint PK_ADJUNTODETRATAMIENTO primary key (iArchivoAdjuntoId, iTratamientoId)
)
go

/*==============================================================*/
/* Table: ArchivoAdjunto                                        */
/*==============================================================*/
create table ArchivoAdjunto (
   iArchivoAdjuntoId    integer              identity(1,1)  not null,
   cNombre              varchar(254)         not null,
   constraint PK_ARCHIVOADJUNTO primary key (iArchivoAdjuntoId)
)
go

/*==============================================================*/
/* Table: Especialidad                                          */
/*==============================================================*/
create table Especialidad (
   iEspecialidadId      integer              identity(1,1) not null,
   cNombre              varchar(254)         not null,
   cDescripcion         varchar(400)         null,
   bBorrado		bit			not null default 0,
   constraint PK_ESPECIALIDAD primary key (iEspecialidadId)
)
go

/*==============================================================*/
/* Table: EspecialidadesDeProfecional                           */
/*==============================================================*/
create table EspecialidadesDeProfecional (
   iProfecionalId       integer              not null,
   iEspecialidadId      integer              not null,
   constraint PK_ESPECIALIDADESDEPROFECIONAL primary key (iProfecionalId, iEspecialidadId)
)
go

/*==============================================================*/
/* Table: EstadoPaciente                                        */
/*==============================================================*/
create table EstadoPaciente (
   iEstadoPacienteId    integer              identity(1,1) not null,
   cNombre              varchar(254)         not null,
   cDescripcion         varchar(400)         null,
   bBorrado		bit			not null default 0,
   constraint PK_ESTADOPACIENTE primary key (iEstadoPacienteId)
)
go

/*==============================================================*/
/* Table: EstadoTratamiento                                     */
/*==============================================================*/
create table EstadoTratamiento (
   iEstadoTratamientoId integer              identity(1,1) not null,
   cNombre              varchar(254)         not null,
   cDescripcion         varchar(400)         null,
   bBorrado		bit			not null default 0,
   constraint PK_ESTADOTRATAMIENTO primary key (iEstadoTratamientoId)
)
go

/*==============================================================*/
/* Table: ObraSocial                                            */
/*==============================================================*/
create table ObraSocial (
   iObraSocialId        integer              identity(1,1) not null,
   cNombre              varchar(254)         not null,
   cDireccion           varchar(254)         null,
   cTelefono            varchar(254)         null,
   cInformacionAdicional varchar(400)         null,
   cCuit                varchar(254)         null,
   bBorrado		bit			not null default 0,
   constraint PK_OBRASOCIAL primary key (iObraSocialId)
)
go

/*==============================================================*/
/* Table: Paciente                                              */
/*==============================================================*/
create table Paciente (
   iPacienteId          integer              identity(1,1) not null,
   iObraSocialId        integer              null,
   iEstadoPacienteId    integer              not null,
   iTipoPacienteId      integer              not null,
   cNombre              varchar(254)         not null,
   cApellido            varchar(254)         not null,
   cDiagnostico         varchar(400)         null,
   cCertificadoDiscapacidad varchar(254)         null,
   cMedicacion          varchar(400)         null,
   bBorrado		bit			not null default 0,
   constraint PK_PACIENTE primary key (iPacienteId)
)
go

/*==============================================================*/
/* Table: PacientesDeTratamiento                                */
/*==============================================================*/
create table PacientesDeTratamiento (
   iTratamientoId       integer              not null,
   iPacienteId          integer              not null,
   constraint PK_PACIENTESDETRATAMIENTO primary key (iTratamientoId, iPacienteId)
)
go

/*==============================================================*/
/* Table: Profecional                                           */
/*==============================================================*/
create table Profecional (
   iProfecionalId       integer              identity(1,1) not null,
   cNombre              varchar(254)         not null,
   cApellido            varchar(254)         not null,
   cNroMatricula        varchar(254)         null,
   cNroTelefono         varchar(254)         null,
   cDirPersonal         varchar(254)         null,
   cDirProfecional      varchar(254)         null,
   cPolizaSeguro        varchar(254)         null,
   bBorrado		bit			not null default 0,
   constraint PK_PROFECIONAL primary key (iProfecionalId)
)
go

/*==============================================================*/
/* Table: ProfecionalesDeTratamiento                            */
/*==============================================================*/
create table ProfecionalesDeTratamiento (
   iProfecionalId       integer              not null,
   iTratamientoId       integer              not null,
   constraint PK_PROFECIONALESDETRATAMIENTO primary key (iProfecionalId, iTratamientoId)
)
go

/*==============================================================*/
/* Table: TipoArchivoAdjunto                                    */
/*==============================================================*/
create table TipoArchivoAdjunto (
   iTipoArchivoAdjuntoId integer              identity(1,1) not null,
   cNombre              varchar(254)         not null,
   bBorrado		bit			not null default 0,
   constraint PK_TIPOARCHIVOADJUNTO primary key (iTipoArchivoAdjuntoId)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'Pueden ser informes, imagenes o documentos',
   'user', @CurrentUser, 'table', 'TipoArchivoAdjunto'
go

/*==============================================================*/
/* Table: TipoPaciente                                          */
/*==============================================================*/
create table TipoPaciente (
   iTipoPacienteId      integer              identity(1,1) not null,
   cNombre              varchar(254)         not null,
   cDescripcion         varchar(400)         null,
   bBorrado		bit			not null default 0,
   constraint PK_TIPOPACIENTE primary key (iTipoPacienteId)
)
go

/*==============================================================*/
/* Table: Tratamiento                                           */
/*==============================================================*/
create table Tratamiento (
   iTratamientoId       integer              identity(1,1) not null,
   iEstadoTratamientoId integer              null,
   cHorario             varchar(254)         null,
   dFechaInicio         date                 null,
   dFechaFin            date                 null,
   cComentarios         varchar(400)         not null,
   bBorrado		bit			not null default 0,
   constraint PK_TRATAMIENTO primary key (iTratamientoId)
)
go

/*==============================================================*/
/* Table: Usuario                                               */
/*==============================================================*/
create table Usuario (
   iUsuarioId           integer              identity(1,1) not null,
   cNombre              varchar(254)         null,
   cApellido            varchar(254)         null,
   cLogin               varchar(50)          not null,
   cPassword            varchar(50)          null,
   bBorrado		bit			not null default 0,
   constraint PK_USUARIO primary key (iUsuarioId)
)
go

alter table AdjuntoDeTratamiento
   add constraint FK_ADJUNTOD_REFERENCE_TRATAMIE foreign key (iTratamientoId)
      references Tratamiento (iTratamientoId)
go

alter table AdjuntoDeTratamiento
   add constraint FK_ADJUNTOD_REFERENCE_TIPOARCH foreign key (iTipoArchivoAdjuntoId)
      references TipoArchivoAdjunto (iTipoArchivoAdjuntoId)
go

alter table AdjuntoDeTratamiento
   add constraint FK_ADJUNTOD_REFERENCE_ARCHIVOA foreign key (iArchivoAdjuntoId)
      references ArchivoAdjunto (iArchivoAdjuntoId)
go

alter table EspecialidadesDeProfecional
   add constraint FK_ESPECIAL_REFERENCE_PROFECIO foreign key (iProfecionalId)
      references Profecional (iProfecionalId)
go

alter table EspecialidadesDeProfecional
   add constraint FK_ESPECIAL_REFERENCE_ESPECIAL foreign key (iEspecialidadId)
      references Especialidad (iEspecialidadId)
go

alter table Paciente
   add constraint FK_PACIENTE_REFERENCE_OBRASOCI foreign key (iObraSocialId)
      references ObraSocial (iObraSocialId)
go

alter table Paciente
   add constraint FK_PACIENTE_REFERENCE_ESTADOPA foreign key (iEstadoPacienteId)
      references EstadoPaciente (iEstadoPacienteId)
go

alter table Paciente
   add constraint FK_PACIENTE_REFERENCE_TIPOPACI foreign key (iTipoPacienteId)
      references TipoPaciente (iTipoPacienteId)
go

alter table PacientesDeTratamiento
   add constraint FK_PACIENTE_REFERENCE_TRATAMIE foreign key (iTratamientoId)
      references Tratamiento (iTratamientoId)
go

alter table PacientesDeTratamiento
   add constraint FK_PACIENTE_REFERENCE_PACIENTE foreign key (iPacienteId)
      references Paciente (iPacienteId)
go

alter table ProfecionalesDeTratamiento
   add constraint FK_PROFECIO_REFERENCE_PROFECIO foreign key (iProfecionalId)
      references Profecional (iProfecionalId)
go

alter table ProfecionalesDeTratamiento
   add constraint FK_PROFECIO_REFERENCE_TRATAMIE foreign key (iTratamientoId)
      references Tratamiento (iTratamientoId)
go

alter table Tratamiento
   add constraint FK_TRATAMIE_REFERENCE_ESTADOTR foreign key (iEstadoTratamientoId)
      references EstadoTratamiento (iEstadoTratamientoId)
go

