-- Sentencias DML: Data Manipulation Language

-- Consultas o recuperacion de datos:
SELECT * FROM employees_2021;

-- si queremos recuperar todo ponemos un asterisco, en caso que queramos algo especifico
-- por ejemplo una columna, se especifica entre el select y el from.

SELECT id FROM employees_2021;
SELECT id, name, e_mail FROM employees_2021;


--Filtrar filas:
SELECT * FROM employees_2021 WHERE id = 1;

SELECT * FROM employees_2021 WHERE name = 'Lucianno';

SELECT * FROM employees_2021 WHERE married = FALSE;

SELECT * FROM employees_2021 WHERE married = FALSE and salary > 6000;

-- 2. Insercion de datos:

INSERT INTO  employees_2021(name, e_mail) VALUES('Roberto', 'Robert@company.com');

--3. Actualizar y editar datos:

UPDATE employees_2021 set birth_date = '1970-05-07';
-- si no colocamos un filtro nos cambiara a TODOS los usuarios

UPDATE employees_2021 set birth_date = '1970-05-07' WHERE id = 5;

UPDATE employees_2021 set birth_date = '1970-05-07' WHERE e_mail = soelattala7@gmail.com;

UPDATE employees_2021 set birth_date = '1985-05-07' WHERE id = 4 RETURNING*;
--con el returning logramos que nos devuelva automaticamente el dato.

--4. Borrar:

DELETE FROM employees_2021;

DELETE FROM employees_2021 WHERE e_mail = 'Robert@company.com';




--SELECT
SELECT * FROM employees_2021;


