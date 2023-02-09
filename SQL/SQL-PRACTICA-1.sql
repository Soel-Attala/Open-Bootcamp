-- Table creation
CREATE TABLE IF NOT EXISTS employees(
	id INT
);

-- See table data:
SELECT * FROM employees;

--Data types: boolean
CREATE TABLE IF NOT EXISTS employees(
	id INT,
	married BOOLEAN
);

-- insert table data:
INSERT INTO employees(id, married) VALUES (1, TRUE);
INSERT INTO employees(id, married) VALUES (2, FALSE);

-- Data type: CHAR, VARCHAR, TEXT:
CREATE TABLE IF NOT EXISTS employees(
	id INT,
	married BOOLEAN,
	name VARCHAR (250),
	genre CHAR(1),
);

-- Data type: NUMERIC
CREATE TABLE IF NOT EXISTS employees(	
	id INT,
	married BOOLEAN,
	name VARCHAR (250),
	genre CHAR(1),
	salary NUMERIC(6,2)
);
-- el tipo de dato numerico se usa para numeros decimales, precios, salarios, etc.
-- el numero entre parentesis es el rango soportado por el numero.


-- Data type: DATE
CREATE TABLE IF NOT EXISTS employees(	
	id INT,
	married BOOLEAN,
	name VARCHAR (250),
	genre CHAR(1),
	salary NUMERIC(6,2),
	birth_date DATE DEFAULT CURRENT_DATE
);
-- birth_date DATE DEFAULT CURRENT_DATE (FECHA DE HOY) 
-- O DATE NOT NULL (INDICAMOS QUE SEA OBLIGATORIO)

-- Data type: TIME
CREATE TABLE IF NOT EXISTS employees(	
	id INT,
	married BOOLEAN,
	name VARCHAR (250),
	genre CHAR(1),
	salary NUMERIC(6,2),
	birth_date DATE DEFAULT CURRENT_DATE,
	start_at TIME
);
-- ahora para hacer que el id sea debemos añadir el primary key
--y usarlo como filtro, remplazamos el id INT por id SERIAL (el serial nos automatiza el id
--pero no previene que este se repita.
CREATE TABLE IF NOT EXISTS employees(	
	id SERIAL,
	married BOOLEAN,
	name VARCHAR (250),
	genre CHAR(1),
	salary NUMERIC(6,2),
	birth_date DATE DEFAULT CURRENT_DATE,
	start_at TIME
);
--probamos si el serial funciona agregando un nuevo empleado:
INSERT INTO employees_2021(married, name, genre, salary, birth_date, start_at, ends_at) 
VALUES (FALSE, 'juan', 'M',6230.25, '1997-08-21', '10:00:00', '18:00:00');

INSERT INTO employees(id, married, name, genre) VALUES (1, TRUE, 'Soel Antonio Attala', 'M');
INSERT INTO employees(id, married, name, genre, salary, birth_date, start_at, ends_at) 
VALUES (1, FALSE, 'Soel Antonio Attala', 'M',5231.25, '1996-03-19', '08:00:00', '16:00:00');
--el numero en varchar indica la longitud maxima permitida para el nombre

-- We adding columns to the table
INSERT INTO employees(id, married, name, genre, salary, birth_date, start_at) 
VALUES (2, FALSE, 'Luciano Gasparini', 'M',6230.25, '1995-10-30', '10:00:00';

--Rename table:
ALTER TABLE IF EXISTS employees RENAME TO employees_2021;
--alter table nos permite acceder a las propiedades de la tabla.

--Add more columns:
ALTER TABLE IF EXISTS employees ADD COLUMN ends_at TIME;

INSERT INTO employees_2021 (id, married, name, genre, salary, birth_date, start_at, ends_at) 
VALUES (1, FALSE, 'Soel Antonio Attala', 'M',5231.25, '1996-03-19', '08:00:00', '16:00:00');

INSERT INTO employees_2021(id, married, name, genre, salary, birth_date, start_at, ends_at) 
VALUES (2, FALSE, 'Luciano Gasparini', 'M',6230.25, '1995-10-30', '10:00:00', '18:00:00');


--Delete column:
ALTER TABLE IF EXISTS employees_2021 DROP COLUMN ends_at;

--Update data:

--primary key:
CREATE TABLE IF NOT EXISTS employees_2021(	
	Id SERIAL PRIMARY KEY,
	Married BOOLEAN,
	Name VARCHAR (250),
	Genre CHAR(1),
	Salary NUMERIC(6,2),
	Birth_Date DATE DEFAULT CURRENT_DATE,
	Start_At TIME,
	Ends_At TIME
);
--Agregamos datos
INSERT INTO employees_2021 (Married, Name, Genre, Salary, Birth_Date, Start_at, Ends_at) 
VALUES (False, 'Soel Antonio Attala', 'M',5231.25, '1996-03-19', '08:00:00', '16:00:00');

INSERT INTO employees_2021(Married, Name, Genre, Salary, Birth_Date, Start_at, Ends_at) 
VALUES (False, 'Luciano Gasparini', 'M',6230.25, '1995-10-30', '10:00:00', '18:00:00');

--verificamos si nos deja poner un id repetido:
INSERT INTO employees_2021 (id, married, name, genre, salary, birth_date, start_at, ends_at) 
VALUES (1, FALSE, 'Soel Antonio Attala', 'M',5231.25, '1996-03-19', '08:00:00', '16:00:00');
		
--Haremos que el nombre del empleado sea un dato obligatorio usando NOT NULL:
CREATE TABLE IF NOT EXISTS employees_2021(	
	Id SERIAL PRIMARY KEY,
	Married BOOLEAN,
	Name VARCHAR (250) NOT NULL,
	Genre CHAR(1),
	Salary NUMERIC(6,2),
	Birth_Date DATE DEFAULT CURRENT_DATE,
	Start_At TIME,
	Ends_At TIME
);
--PROBAMOS QUE FUNCIONE		
INSERT INTO employees_2021 (married, genre, salary, birth_date, start_at, ends_at) 
VALUES (FALSE, 'M',5231.25, '1996-03-19', '08:00:00', '16:00:00');
		
		
-- HACEMOS QUE UN VALOR SEA UNICO USANDO UNIQUE:
CREATE TABLE IF NOT EXISTS employees_2021(	
	Id SERIAL PRIMARY KEY,
	Married BOOLEAN,
	Name VARCHAR (250) NOT NULL,
	E_Mail VARCHAR(100) UNIQUE,
	Genre CHAR(1),
	Birth_Date DATE DEFAULT CURRENT_DATE,
	Salary NUMERIC(6,2)
);
--podemos usar UNIQUE(E_MAIL, DNI)

		
--probamos el funcionamiento:
INSERT INTO employees_2021 (Married, Name, E_Mail, Genre, Birth_Date, Salary) 
VALUES (False, 'Soel Antonio Attala','soelattala7@gmail.com', 'M', '1996-03-19',5231.25);

INSERT INTO employees_2021(Married, Name, E_Mail, Genre, Birth_Date, Salary) 
VALUES (False, 'Luciano Gasparini', 'gasparinilg@gmail.com', 'M', '1995-10-30',6230.25);
		
INSERT INTO employees_2021 (Married, Name, E_mail, Genre, Birth_Date, Salary) 
VALUES (False, 'Soel Attala','soelattala7@gmail.com', 'M', '1996-03-19',5231.25);

--Restricciones en rangod e datos CHECK:
CREATE TABLE IF NOT EXISTS employees_2021(	
	Id SERIAL PRIMARY KEY,
	Married BOOLEAN,
	Name VARCHAR (250) NOT NULL,
	E_Mail VARCHAR(100) UNIQUE,
	Genre CHAR(1),
	Birth_Date DATE CHECK (birth_day > '2005-01-01'),
	Salary NUMERIC(6,2) CHECK (salary >0)
);
--probamos el funcionamiento:
INSERT INTO employees_2021 (Married, Name, E_Mail, Genre, Birth_Date, Salary) 
VALUES (False, 'Soel Antonio Attala','soelattala7@gmail.com', 'M', '1996-03-19',5231.25);

INSERT INTO employees_2021(Married, Name, E_Mail, Genre, Birth_Date, Salary) 
VALUES (False, 'Luciano Gasparini', 'gasparinilg@gmail.com', 'M', '1995-10-30',6230.25);

--Ahora ponemos un salario negativo:
INSERT INTO employees_2021(Married, Name, E_Mail, Genre, Birth_Date, Salary) 
VALUES (False, 'Luciano Gasparini', 'gasparinilg3@gmail.com', 'M', '1995-10-30',-6230.25);

-- SI QUEREMOS CREAR UNA BASE DE DATOS USAMOS EL COMANDO: CREATE DATABASE + nombre de la base de datos.
-- PARA BORRAR LA BASE DE DATOS: DROP DATABASE + nombre de lo que queremos borrar.

--show data
SELECT * FROM employees_2021;
--Dlete table:
DROP TABLE IF EXISTS employees_2021;