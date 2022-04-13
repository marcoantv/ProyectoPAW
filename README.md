# ProyectoPAW
Proyecto Jhon Gary
Integrantes:
Marco Viquez Corrales
Raquel Fernandez Jimenez
Veronica Calderon Castro
Fabian Arias Torres

/*****************************/
Create the database named: ProyectoPAW
and run this script to create the tables locally

use  ProyectoPAW;

create table Proveedor(
IdProve int primary key identity(1,1),
NombreProveedor varchar(40),
NumeroProveedor int,
Correo varchar(25),
NombreCompania varchar(40),
DireccionExact varchar(200),
Pais varchar(60),
Provincia varchar(30),
Canton varchar(40),
Districto varchar(40)
);

create table Producto(
IdProducto int primary key identity(1,1),
Codigo int unique,
NombreProducto varchar(40),
PrecioUni decimal(12,2),
Descripcion varchar(150),
Cantidad int
);

create table Empleado(
Id int primary key identity(1,1),
Cedula int unique,
Nombre varchar(30),
PrimerApe varchar(30),
SegundoApe varchar(30),
Telefono int,
Correo varchar(25),
Sueldo decimal(12,2)
);

create table Cliente(
Id int primary key identity(1,1),
Cedula int unique,
Nombre varchar(30),
PrimerApe varchar(30),
SegundoApe varchar(30),
Telefono int,
TelefonoHogar int,
Correo varchar(25),
Pais varchar(60),
DireccionExact varchar(200),
Provincia varchar(30),
Canton varchar(40),
Districto varchar(40));

