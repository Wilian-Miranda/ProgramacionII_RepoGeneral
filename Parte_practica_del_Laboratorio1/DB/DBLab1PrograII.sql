use master;

go
create database Estudiante;
go

go
use Estudiante;
go

go
create table TblNotasEstudiante(
	id int not null primary key identity(1,1),
	Nombre varchar(100),
	lab1 decimal(5,2) not null,
	lab2 decimal(5,2) not null,
	lab3 decimal(5,2) not null,
	par1 decimal(5,2) not null,
	par2 decimal(5,2) not null,
	par3 decimal(5,2) not null,
	nota decimal(5,2) 
);
go