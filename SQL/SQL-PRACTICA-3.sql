CREATE TABLE manufacturer(
	id SERIAL,
	name VARCHAR(50) NOT NULL,
	num_employees INT,
	CONSTRAINT pk_manofacturer PRIMARY KEY(id)
);
--si tuvieramos otro esquema definimos la tabla como nombresquema.nombretabla,
--como solo tenemos el public, entonces lo dejamos por defecto.

-- INSERTAMOS FABRICANTES:
INSERT INTO manufacturer (name, num_employees)
VALUES('Ford', 29000);

INSERT INTO manufacturer (name, num_employees)
VALUES('Toyota', 35000);

INSERT INTO manufacturer (name, num_employees)
VALUES('Chevrolet', 27000);

INSERT INTO manufacturer (name, num_employees)
VALUES('Honda', 32000);

--CREAMOS LA TABLA MODEL PARA LOS MODELOS DE AUTOS
CREATE TABLE model(
	id SERIAL,
	name VARCHAR(50) NOT NULL,
	manufacturer_id INT,
	CONSTRAINT pk_model PRIMARY KEY(id),
	CONSTRAINT fk_model_manufacturer FOREIGN KEY(manufacturer_id) REFERENCES manufacturer(id)	
);

INSERT INTO model (name, manufacturer_id)
VALUES('Honda Civic', 4);
UPDATE model SET name = 'Civic' WHERE id =1;

INSERT INTO model (name, manufacturer_id)
VALUES('Focus', 1);

INSERT INTO model (name, manufacturer_id)
VALUES('Hilux', 2);

INSERT INTO model (name, manufacturer_id)
VALUES('Astra', 3);


--VERSION
CREATE TABLE version(
	id SERIAL,
	name VARCHAR(50) NOT NULL,
	engine VARCHAR(50),
	price NUMERIC,
	cc NUMERIC(2,1),
	id_model INT,
	CONSTRAINT pk_version PRIMARY KEY(id),
	CONSTRAINT pk_version_model FOREIGN KEY (id_model) REFERENCES model(id) ON UPDATE cascade ON DELETE set NULL
);

--si nosotros borramos una entidad relacionada con esta, por ejemplo, si tengo muchas versiones de 
-- toyota prius y borro el modelo, con el modo cascada se borran todas las versiones de ese vehiculo
-- pero si usamos set null se mantendran las versiones

INSERT INTO version (name, engine, price, cc, id_model) VALUES('Model Basic', 'Diessel 4C', 30000, 1.9, 3);
INSERT INTO version (name, engine, price, cc, id_model) VALUES('Model Medium', 'Diessel 5C', 50000, 2.2, 3);
INSERT INTO version (name, engine, price, cc, id_model) VALUES('Model Advance', 'Diessel 6C V', 70000, 3.2, 3);

INSERT INTO version (name, engine, price, cc, id_model) VALUES('Model Basic', 'Nafta 4C', 40000, 2.8, 4);
INSERT INTO version (name, engine, price, cc, id_model) VALUES('Model Medium', 'Nafta 5C', 60000, 3.0, 4);
INSERT INTO version (name, engine, price, cc, id_model) VALUES('Model Advance', 'Nafta 6C V', 90000, 3.2, 4);


--EXTRA
CREATE TABLE extra(
	id SERIAL,
	name VARCHAR(50) NOT NULL,
	description VARCHAR (300),
	CONSTRAINT pk_extra PRIMARY KEY(id)	
);

CREATE TABLE extra_version(
	id_version INT,
	id_extra INT,
	price NUMERIC NOT NULL CHECK (price>=0),
	CONSTRAINT pk_extra_version PRIMARY KEY (id_version, id_extra),
	CONSTRAINT fk_extra_version FOREIGN KEY (id_version) REFERENCES version(id) ON UPDATE cascade ON DELETE cascade,
	CONSTRAINT fk_version_extra FOREIGN KEY (id_extra) REFERENCES extra(id) ON UPDATE cascade ON DELETE cascade
);
-- en esta tabla usaremos una clave primaria para 2 campos, para extra y version. Como es many to many
-- cada extra y cada version aparecera muchas veces, por eso la version unicamente no puede ser clave, y el extra por si solo tampoco
-- ya que como no queremos que se repita la clave primaria, se combinan para tener por ejemplo, version 1 extra 2,
-- seria 1_2


--en la tabla versiones usamos una colmuna para relacionar tablas. Pero ahora como es many to many usaremos
-- otra tabla para relacionar ambas tablas, es decir entre version y extras.
--una version puede tener mas de un extra, pero a su vez, un extra puede estar en varias versiones.
-- es decir, sera una tabla de tipo many to many
-- la idea es que cada extra tenga un precio, por que, si un coche basico tiene un costo de 10000, dependiendo los
-- extras que tenga, sera el nnuevo precio.

INSERT INTO extra (name, description)
VALUES ('Techo Solar', 'Panel solar de carga para motor hybrido');
INSERT INTO extra (name, description)
VALUES ('Caja Automatica', 'Caja Automatica con eleccion secuencial y manual');
INSERT INTO extra (name, description)
VALUES ('WiFi', 'Conexion WiFi de alta velocidad');


--Honda Civil Basic techo solar
INSERT INTO extra_version VALUES(4,1,3000);
--CAJA AUTOMATICA CIVIC MEDIUM:
INSERT INTO extra_version VALUES(5,2,6000);
--WIFI CIVIC MEDIUM
INSERT INTO extra_version VALUES(5,3,10000);

--CIVIC ADVANCE WIFI
INSERT INTO extra_version VALUES(6,3,13000);
--CIVIC ADVANCE PANEL SOLAR
INSERT INTO extra_version VALUES(6,1,5000);

--ASTRA BASIC PANEL:
INSERT INTO extra_version VALUES(1,1,3000);
--ASTRA BASIC WIFI:
INSERT INTO extra_version VALUES(1,3,6000);
--ASTRA BASIC CAJA AUTOMATICA:
INSERT INTO extra_version VALUES(1,2,5000);


--CREAMOS TABLA DE EMPLEADOS
CREATE TABLE employee(
	id SERIAL,
	name VARCHAR(30),
	nif VARCHAR(9) NOT NULL UNIQUE ,
	phone VARCHAR(9),
	CONSTRAINT pk_employee PRIMARY KEY (id)
);

INSERT INTO employee (name, nif, phone)
VALUES ('Rodolfo', '123456789', '4315482');
INSERT INTO employee (name, nif, phone)
VALUES ('Carlos', '325486859', '4365845');
INSERT INTO employee (name, nif, phone)
VALUES ('Julio', '985475323', '42465874');


--CREAMOS TABLA DE CLIENTES
CREATE TABLE customer(
	id SERIAL,
	name VARCHAR(30),
	phone VARCHAR(9),
	email VARCHAR(20) NOT NULL UNIQUE,
	CONSTRAINT pk_customer PRIMARY KEY(id)
);

INSERT INTO customer (name, phone, email)
VALUES ('Mario', '123456789', 'Mario@company.com');
INSERT INTO customer (name, phone, email)
VALUES ('Finn', '325486859', 'finn@company.com');
INSERT INTO customer (name, phone, email)
VALUES ('Nestor', '985475323', 'Nestor@company.com');

--DEBEMOS CREAR UNA TABLA QUE REALACIONE TODO LO ANTERIOR:
CREATE TABLE vehicle(
	id SERIAL,
	license_num VARCHAR(7),
	creation_date DATE,
	price_gross NUMERIC,
	price_net NUMERIC,
	type VARCHAR(30),
	
	id_manufacturer INT,
	id_model INT,
	id_version INT,
	id_extra INT,
	
	CONSTRAINT pk_vehicle PRIMARY KEY(id),
	CONSTRAINT pk_vehicle_manufacturer FOREIGN KEY (id_manufacturer) REFERENCES manufacturer(id),
	CONSTRAINT pk_vehicle_model FOREIGN KEY (id_model) REFERENCES model(id),
	CONSTRAINT pk_vehicle_extra_version FOREIGN KEY (id_version, id_extra) 
	REFERENCES extra_version(id_version, id_extra)
);

INSERT INTO vehicle(license_num, price_gross, id_manufacturer, id_model, id_version, id_extra)
VALUES('485CHN', 50000,1,2,1,3);


CREATE TABLE Sales(
	id SERIAL,
	sell_date DATE,
	channel VARCHAR(300),
	
	id_vehicle INT,
	id_employee INT,
	id_customer INT,
	
	CONSTRAINT pk_sale PRIMARY KEY (id),
	CONSTRAINT fk_sale_vehicle FOREIGN KEY (id_vehicle) REFERENCES vehicle(id),
	CONSTRAINT fk_sale_employee FOREIGN KEY (id_employee) REFERENCES employee(id),
	CONSTRAINT fk_sale_customer FOREIGN KEY (id_customer) REFERENCES customer(id)
);
INSERT INTO sales(sell_date, channel, id_vehicle, id_employee, id_customer)
VALUES ('2022-03-10', 'Telefonica', 6, 3, 2);



SELECT * FROM model;
SELECT * FROM manufacturer;
SELECT * FROM version;
SELECT * FROM extra;
SELECT * FROM extra_version;
SELECT * FROM sales;
SELECT * FROM vehicle;
SELECT * FROM employee;
