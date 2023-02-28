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
SELECT * FROM film;
SELECT * FROM film WHERE description LIKE '%Monastery%';
-- usamos like por que sin ponemos igual, ningun resultado nos dara = a monastery
--usamos el doble % para incluir la palabra, sin importar el texto que tenga delante o despues.
-- por ejemplo si ponemos Monastery%, estamos diciendo que comienza con monastery y sigue con cualquier texto.
SELECT * FROM film WHERE description LIKE '%Drama%';

SELECT * FROM actor WHERE last_name LIKE '%LI%' ORDER BY first_name; --ESTE VA DE A-Z 
SELECT * FROM actor WHERE last_name LIKE '%LI%' ORDER BY first_name DESC; -- ESTE DESCENDENTE VA DE Z-A

-- OPERADOR IN: nos permite buscar en una lista de datos.
SELECT * FROM country;
SELECT * FROM country WHERE country = 'Spain' or country = 'Germany' or country = 'France';
SELECT * FROM country WHERE country IN('Spain', 'Germany','France');
--el in evita la repeticion del and y el or.

-- El IN tambien se utiliza bastante con el ID.
SELECT * FROM customer WHERE customer_id IN(15,16,17,18);

--combinamos count con group by:
SELECT * FROM actor;
SELECT last_name, COUNT(last_name) FROM actor GROUP BY last_name;
-- pero si solo queremos los que se repitan por ejemplo
SELECT last_name, COUNT(last_name) FROM actor GROUP BY last_name;
--el where no puede ir despues del group by.
--el where no permite funciones de agregacion.
SELECT last_name, COUNT(last_name) FROM actor GROUP BY last_name HAVING count(last_name)>1;

--veremos cuantos actores tiene cada pelicula
SELECT * FROM film;
SELECT * FROM film_actor;

SELECT f.title, COUNT(fa.actor_id) FROM film f 
INNER JOIN film_actor fa on f.film_id = fa.film_id
GROUP BY f.title;
--asi vemos cuantos actores participan en cada pelicula.


--USAREMOS LA TABLA INVENTORY
SELECT * FROM inventory;
SELECT * FROM film;

--ASI PODEMOS VER CUANTAS COPIAS TENEMOS DE LA PELICULA QUE BUSCA EL CLIENTE
SELECT f.title, COUNT(i.inventory_id) AS N°Film FROM film f
INNER JOIN inventory i ON i.film_id = f.film_id
WHERE title = 'ACADEMY DINOSAUR'
GROUP BY title;

--ASI VEMOS TODAS LAS PELICULAS
SELECT f.title, COUNT(i.inventory_id) AS N°Film FROM film f
INNER JOIN inventory i ON i.film_id = f.film_id
GROUP BY title ORDER BY n°film DESC;


-- TABLA PAYMENT Y FUNCION SUMA
SELECT * FROM customer;
SELECT * FROM payment;

SELECT c.email, COUNT(p.payment_id) as N°pagos FROM payment p
INNER JOIN customer c ON p.customer_id = c.customer_id
GROUP BY c.email;
-- de esta forma vemos cuantos pagos hizo cada correo, si queremos ver el total de dinero haremos lo siguiente.
SELECT c.email, SUM(p.amount) as N°pagos FROM payment p
INNER JOIN customer c ON p.customer_id = c.customer_id
GROUP BY c.email;

--ahora veremos cuanto vendio cada empleado
SELECT * FROM staff;
SELECT * FROM payment;

SELECT s.first_name, COUNT(p.payment_id) as N°pagos, SUM(p.amount) as total_cash FROM payment p
INNER JOIN staff s ON p.staff_id = s.staff_id
GROUP BY s.first_name;




-- SUB QUERIES
SELECT* FROM film;
SELECT * FROM language;

SELECT DISTINCT language_id FROM film;
--usamos el distinct para ver si hay idiomas diferentes, pero como no los hay, actualizaremos algunos con el update
UPDATE film SET language_id =4 WHERE film_id > 300 AND film_id < 400;
UPDATE film SET language_id =3 WHERE film_id > 600 AND film_id < 700;

SELECT l.name, COUNT(film_id) as cantidad_peliculas FROM film f
INNER JOIN language l on f.language_id = l.language_id
GROUP BY l.name;

SELECT title FROM film 
WHERE language_id = (SELECT language_id FROM language WHERE name = 'English')
-- En este caso el select que esta entre parentesis, sera remplazado por el id del idioma ingles.
-- es decir, quedaria algo asi WHERE LANGUAGE_ID = 1  de esta forma, obtenemos el id haciendo un select dentro de 
-- otro select

SELECT title FROM film 
WHERE language_id IN (SELECT language_id FROM language WHERE name = 'English' OR name = 'Italian';)
--aqui usamos IN para filtrar mas de un lenguage
-- dentro del sub select podemos hacer joins, pero es mas complcado.

--LAS PELICULAS MAS ALQUILADAS

SELECT * FROM rental;
SELECT * FROM inventory;
SELECT * FROM film;

SELECT f.title, COUNT(f.film_id) AS veces_alquilada FROM film f
INNER JOIN (SELECT * FROM inventory i
INNER JOIN rental r on r.inventory_id = i.inventory_id) res on res.film_id = f.film_id
GROUP BY f.title 
ORDER BY veces_alquilada DESC;
--en el inner join haremos una subquery para relacionar rental con inventory
(SELECT * FROM inventory i
INNER JOIN rental r on r.inventory_id = i.inventory_id)



--la idea de esto es responder preguntas de negocios.
-- es decir con estas consultas trabajamos con lo que ya tenemos para poder analizar los datos
-- supongamos que tenemos 4 tiendas pero, 2 de ellas tienen mas gastos que ganancias, entonces
-- aqui podemos ver todos sus datos y tomar la decision de cerrarlas.

