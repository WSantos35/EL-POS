DROP DATABASE BD_201700708;

CREATE DATABASE BD_201700708;

USE BD_201700708;

create table vendedor(
	codigo_vendedor int identity(1,1) primary key not null,
	nombre varchar(50) not null,
	fecha_nacimiento datetime not null,
	sexo varchar(15) not null,
	usuario varchar(25) unique not null,
	contrasenia varchar(10) not null,
	tipo int not null,
	foto varchar(250)
);

SELECT *
	FROM VENDEDOR;

INSERT INTO vendedor(nombre,fecha_nacimiento,sexo,usuario,contrasenia,tipo,foto) 
	VALUES('Super Admin','20220330','M','admin','admin1',2,'ruta foto');