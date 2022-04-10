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

create table producto
(
codigo_producto int identity(1,1) primary key not null,
nombre varchar(50) not null,
precio decimal(19,6) not null, --44444419.000201
stock int not null default 0,
descripcion varchar(250)
);
--insert into producto(nombre,precio,descripcion) values ('bebida',4.52,'bebida energizante')
create table venta
(
codigo_venta int identity(1,1) primary key not null,
nombre_cliente varchar(50) default 'Consumidor final',
nit_cliente varchar(50) default '77-45782',
total_pagar decimal(19,2) ,
codigo_vendedor int not null,
constraint FKVendedorIDventaID foreign key(codigo_vendedor) references vendedor(codigo_vendedor)
on update cascade
on delete cascade
);

insert into venta(nombre_cliente,nit_cliente,total_pagar,codigo_vendedor) values('jaun perez','777-55',1542.32,4)

create table detalle_venta
(
order_id int identity(1,1) primary key not null,
codigo_venta int not null,
codigo_producto int not null,
cantidad_producto int not null,
constraint FKDETcodigoventa foreign key(codigo_venta) references venta(codigo_venta),
constraint FKDETcodigoproducto foreign key(codigo_producto) references producto(codigo_producto)
);

select codigo_vendedor as VENDEDOR from vendedor

select count(*) as Total_Vendedores from vendedor

select sum(codigo_vendedor) from vendedor

select nombre ,count(*) as Total_Ventas from vendedor inner join venta on vendedor.tipo =1
	and venta.codigo_vendedor=vendedor.codigo_vendedor
	group by vendedor.codigo_vendedor,vendedor.nombre
	order by 2 desc