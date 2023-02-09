-- exploramos tablas
SELECT * FROM actor;
SELECT * FROM actor WHERE last_name = 'WAHLBERG';
SELECT * FROM address;

--podemos ver que tenemos una columna llamada city_id eso hace referencia que tenemos una talba
-- llamada city, de la cual estamos importando los datos es decir hay relacion entre tablas.
--en las constrain podemos ver dicha relacion

SELECT * FROM address WHERE district = 'California';
SELECT * FROM address WHERE district = 'California'AND postal_code = '48150';
SELECT * FROM address WHERE district = 'California'AND 
postal_code = '48150' OR postal_code = '58327';
--dependiendo si necesitamos el distrito o no, usamos district ya que el codigo postal en este caso
-- es un dato muy especifico.
SELECT * FROM address WHERE postal_code = '48150' OR postal_code = '58327';

--TABLA CATEGORY

SELECT * FROM category;
SELECT * FROM category WHERE name = 'Action';

--TABLA CITY
SELECT *FROM city;
--podemos ver que hay una tabla relacionada en este caso la country, ya que tenemos el country_id
--junto con la clave foranea.

SELECT *FROM city WHERE city = 'Akron';

SELECT *FROM city WHERE city LIKE 'A%'; 
--Todos los datos de city que comiencen con A y continua con lo que sea.

--TABLA COUNTRY
SELECT * FROM country;
--podemos verificar que la tabla address esta relacionadad con city, y a su vez city esta relacionada con country.
SELECT * FROM country WHERE country = 'Spain';


--TABLA CUSTOMER
SELECT * FROM customer;
SELECT * FROM customer WHERE last_name = 'Williams';
SELECT * FROM customer WHERE activebool = FALSE;
--con el ultimo comando revisamos los datos inactivos, como no hay ninguno, lo modificaremos para que haya.
UPDATE customer SET activebool = FALSE WHERE customer_id = 1;

-- lo dejamos como estaba:
UPDATE customer SET activebool = TRUE WHERE customer_id = 1;

-- si vemos las tablas, veremos la tabla film y una film actor.
-- esta tabla es una relacion entre film y actors. ya que un actor puede haber hecho mas de una pelicula.
--con el id en la columna nos es insuficiente por que no podemos expresarlo simplemente en una columna.
-- entonces usamos la tablar extra film_actors

SELECT * FROM film_actor;

SELECT * FROM film_actor WHERE film_id =1;
SELECT * FROM film_actor WHERE actor_id =1;
--asi podemos ver que el actor con id uno tiene muchas peliculas hechas, y la pelicula con id 1 tiene muchos actores.

SELECT*FROM film;