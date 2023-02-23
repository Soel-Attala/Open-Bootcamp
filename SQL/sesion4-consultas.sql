SELECT * FROM address;
-- nos da 604 resultados
SELECT district FROM address;
--nos devuelve 604 resultados por que hay 604 distritos
-- habra varios distritos repetidos, si queremos que nos de todos diferentes para saber exactamente el total sería:
SELECT DISTINCT district FROM address;
--con esto obtenemos 379 resultados ya que quitamos los duplicados

SELECT last_name FROM customer;
--nos da 600 resultados

SELECT DISTINCT last_name FROM customer;
--nos da 600 tambien, ya que no hay repetidos


-- and, or, not
SELECT * FROM address WHERE district = 'California';
SELECT * FROM address WHERE district != 'California';
SELECT * FROM address WHERE NOT district = 'California' ORDER BY district;
-- el comando con WHERE NOT es lo mismo que != es decir el segundo y el tercero son los mismo
-- con order by seleccionamos una columna y hacemos que nos ordene los datos de la tabla en 
--orden alfabetico segun esa columna
SELECT * FROM address WHERE district = 'California' OR district = 'Abu Dhabi' ORDER BY district;
--con el comando or, le pedimos que nos traiga los datos que cumplan algunas de las condiciones.
SELECT * FROM address WHERE district IS NOT NULL AND district = '' ORDER BY district;
-- de esta manera le pedimos que no traiga ni los nulos, ni los que tienen texto vacio.

SELECT * FROM address WHERE NOT district = '' ORDER BY district;
SELECT * FROM address WHERE district IS NOT NULL ORDER BY district;

SELECT * FROM address WHERE address2 IS NOT NULL AND address_id = 1 ORDER BY district;



-- group by
--nos pedira que usemos ciertos datos en una funcion de agregacion como condicion,
--una funcion de agregacion es una funcion que reduce los datos, es decir, por ejemplo hace un calculo.

SELECT district, COUNT (district) FROM address group by district;
-- aqui le pedimos que nos de un distrito y luego la cuenta.
SELECT district, COUNT (district) as repeat FROM address group by district;
-- con el comando as solo ponemos el nombre de la columna del count.



-- UNION 
-- si tenemos dos tablas iguales, supongamos que una tiene datos del 2020 y la otra del 2021
-- con union podemos traer los datos de ambas combinados en una sola tabla.


--joins 
SELECT * FROM customer;
SELECT * FROM address;
SELECT * FROM city;
SELECT * FROM country;
-- estas tabalas estan relacionadas, es decir supongamos que queremos enviar un producto a un cliente
-- entonces debemos obtener info de todas las tablas relacionadas.

-- consultaremos dos tablas, customer y address
SELECT first_name, last_name, address_id FROM customer 
INNER JOIN address on customer.address_id = address.address_id;
--nos dara error

SELECT first_name, last_name, customer.address_id FROM customer 
INNER JOIN address on customer.address_id = address.address_id;

--tenemos distintos tipos de join, ya sea right y left que hace que se incluyan los datos de las tablas
-- de derecha o izquierda aunque no coincidan.
--colocamos customer en el campo de arriba para resolver la ambiguedad por que ambos campos tienen el mismo nombre
-- de esta forma le indicamos que pertenece a customer.


--con el inner sacamos solo los que coinciden con los que estamos pidiendo

--cuando hacemos el inner debemos indicar la columna que se relaciona, entonces, vemos que address_id
-- es la clave foranea de customer y la primaria de address,
--por lo que utilizamos dicha columna planteando su relacion.

--podemos abreviar esto asi
SELECT first_name, last_name, customer.address_id FROM customer 
INNER JOIN address on customer.address_id = address.address_id;

SELECT first_name, last_name, c.address_id FROM customer c
INNER JOIN address a on c.address_id = a.address_id;
-- vemos que es lo mismo, lo unico que hacemos es asignarle la letra c a customer y a address la letra a.

--agregaremos la direccion a la tabla
SELECT first_name, last_name, customer.address_id, address FROM customer 
INNER JOIN address on customer.address_id = address.address_id;
-- aqui hemos reunido los datos de ambas tablas por lo que podemos traer los datos de ambas.
-- si hacemos esto:
SELECT * FROM customer 
INNER JOIN address on customer.address_id = address.address_id;
--nos trae todos los datos de ambas tablas, una tabla al lado de otra, es muy poco practico.


SELECT c.email, a.address FROM customer c
INNER JOIN address a on c.address_id = a.address_id;


-- CONSULTA A 3 TABLAS: CUSTOMER, ADDRESS, CITY.
SELECT cu.email, a.address, ci.city FROM customer cu
INNER JOIN address a on cu.address_id = a.address_id
INNER JOIN city ci ON a.city_id = ci.city_id;

--basicamente aqui repetimos lo anterior, relacionamos customer -> address (en el primer inner join),
-- y address con city (en el segundo inner join).


-- CONSULTA A 4 TABLAS:
SELECT cu.email, a.address, ci.city, co.country FROM customer cu
INNER JOIN address a on cu.address_id = a.address_id
INNER JOIN city ci ON a.city_id = ci.city_id
INNER JOIN country co ON ci.country_id = co.country_id ORDER BY country;


--FUNCION CONCATENAR: UNIREMOS DOS COLUMNAS DE UNA TABLA EN UNA NUEVA.

SELECT * FROM actor;

SELECT CONCAT(first_name,'  ', last_name) as Full_Name from actor;

-- Funcion Like:
