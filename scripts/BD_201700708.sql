CREATE DATABASE BD_201700708;

USE BD_201700708;


CREATE TABLE VENDEDOR(
	CODIGO_VENDEDOR INT NOT NULL IDENTITY(1,1),
	NOMBRE VARCHAR(150) NOT NULL,
	FECHA_NACIMIENTO VARCHAR(20) NOT NULL,
	SEXO VARCHAR(1) NOT NULL,
	PASSWORD VARCHAR(150) NOT NULL,
	USUARIO VARCHAR(100) NOT NULL,
	TIPO VARCHAR(5) NOT NULL,
	FOTOGRAFIA VARCHAR(150) NOT NULL,
	CONSTRAINT VENDEDOR_PK PRIMARY KEY(CODIGO_VENDEDOR),
	CONSTRAINT VENDEDOR_UNI UNIQUE(USUARIO)
);


CREATE TABLE PRODUCTO(
	CODIGO_PRODUCTO INT NOT NULL IDENTITY(1,1),
	NOMBRE VARCHAR(150) NOT NULL,
	PRECIO NUMERIC(9,2) NOT NULL,
	EXISTENCIAS INT NOT NULL,
	CONSTRAINT PRODUCTO_PK PRIMARY KEY(CODIGO_PRODUCTO)
);

CREATE TABLE VENTA(
	CODIGO_VENTA INT NOT NULL IDENTITY(1,1),
	CODIGO_VENDEDOR INT NOT NULL,
	TOTAL_PAGAR NUMERIC(9,2) NOT NULL,
	CONSTRAINT VENTA_PK PRIMARY KEY(CODIGO_VENTA),
	CONSTRAINT VENTA_FK FOREIGN KEY(CODIGO_VENDEDOR) REFERENCES VENDEDOR(CODIGO_VENDEDOR)
);

CREATE TABLE DETALLE_VENTA(
	ORDER_ID INT NOT NULL IDENTITY(1,1),
	CODIGO_VENTA INT NOT NULL,
	CODIGO_PRODUCTO INT NOT NULL,
	CANTIDAD_PRODUCTO INT NOT NULL,
	CONSTRAINT DETALLE_VENTA_PK PRIMARY KEY(ORDER_ID),
	CONSTRAINT DV_CODVENTA_FK FOREIGN KEY(CODIGO_VENTA) REFERENCES VENTA(CODIGO_VENTA),
	CONSTRAINT DV_CODPROD_FK FOREIGN KEY(CODIGO_PRODUCTO) REFERENCES PRODUCTO(CODIGO_PRODUCTO)
);

SELECT *
	FROM VENDEDOR;

INSERT INTO VENDEDOR(NOMBRE,FECHA_NACIMIENTO,SEXO,PASSWORD,USUARIO,TIPO,FOTOGRAFIA) 
	VALUES('Admin','','M','Admin','Admin','A','')