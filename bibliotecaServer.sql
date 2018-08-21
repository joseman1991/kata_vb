
--create database biblioteca;


use biblioteca;
go

 IF OBJECT_ID ( 'dbo.elimina', 'P' ) IS NOT NULL   
    DROP PROCEDURE dbo.elimina;  
 GO  

 create procedure elimina 
 (@tabla varchar(50) )
 as 
  declare @sql nvarchar(50);
  set @sql ='drop table ' + QUOTENAME(@tabla);
  exec sp_executesql @sql;
 go


 exec elimina 'detalle_prestamo';
 exec elimina 'prestamos';
 exec elimina 'lectores';
 --exec elimina 'libro_autor';
 exec elimina 'libros';
 exec elimina 'autores';
 exec elimina 'usuarios';
 exec elimina 'perfiles';

  create table perfiles (
  idperfil int primary key  not null,
  descripcion varchar(64) not null 
 );

 insert into perfiles values(1,'ADMINISTRADOR');
 insert into perfiles values(2,'BIBLIOTECARIO');


 create table usuarios(
  nombreusuario varchar(20) primary key,
  clave varchar(20),
  nombre1 varchar(20) NOT NULL,
  nombre2 varchar(20),
  apellido1 varchar(20),
  apellido2 varchar(20),
  direccion varchar(100),
  idperfil int not null,
  constraint fk_u_p foreign key (idperfil) references perfiles on update cascade
 );

 INSERT INTO usuarios values('kata','123456','KATHERINE','M','A','A2','MONTALVO',1);
 

 create table autores(
  idautor int primary key not null,
   nombre1 varchar(20) NOT NULL,
   nombre2 varchar(20),
   apellido1 varchar(20),
   apellido2 varchar(20)
 );

 create table libros(
  idlibro int not null primary key,
  nombre varchar(50) not null,
  editorial varchar(50) not null,
  autor varchar(100),
  foto image 
 );

 /*
 create table libro_autor(
  idlibro_autor int not null primary key,
  idautor int not null,
  idlibro int not null,
  constraint fk_l_a foreign key (idlibro) references libros(idlibro) on update cascade,
  constraint fk_a_l foreign key (idautor) references autores(idautor) on update cascade 
 );
 */
  create table lectores(
  idlectores int primary key,
  nombre1 varchar(20) NOT NULL,
  nombre2 varchar(20),
  apellido1 varchar(20),
  apellido2 varchar(20),
  direccion varchar(100),
  telefono varchar(10) not null,
 );

 create table prestamos(
  idprestamo int not null primary key,
  idlectores int not null,
  fechaprestamo date default getdate(),
  fechaentrega date default null,
  constraint fk_p_l foreign key (idlectores) references lectores(idlectores) on update cascade 
 );

 create table detalle_prestamo(
  idlibro int not null,
  idprestamo int not null,
  estado char not null,
  constraint fk_l_p foreign key (idlibro) references libros(idlibro) on update cascade,
  constraint fk_d_p foreign key (idprestamo) references prestamos(idprestamo) on update cascade 
 );