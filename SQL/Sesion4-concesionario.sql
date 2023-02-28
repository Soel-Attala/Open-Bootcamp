--CANTIDAD DE VENTAS POR EMPLEADO
SELECT * FROM sale s
INNER JOIN employee e ON s.id_employee = e.id
SELECT *FROM employee;

INSERT INTO sales(sell_date, channel, id_vehicle, id_employee, id_customer)
VALUES ('2022-03-04', 'Phone', 1, 4, 1);

INSERT INTO sales(sell_date, channel, id_vehicle, id_employee, id_customer)
VALUES ('2022-03-04', 'Phone', 6, 5, 1);

SELECT e.name, COUNT(s.id) AS total_ventas FROM sales s
INNER JOIN employee e ON s.id_employee = e.id
GROUP BY e.name;

--CANTIDAD DE COMPRAS POR CLIENTE
SELECT c.email, COUNT(s.id) AS total_ventas FROM sales s
INNER JOIN customer c ON s.id_customer = c.id
GROUP BY c.email;


--FABRICANTE MAS VENDIDO
SELECT e.name, COUNT(s.id) AS total_ventas FROM sales s
INNER JOIN employee e ON s.id_employee = e.id
GROUP BY e.name;


--MODELO MAS VENDIDO
SELECT * FROM sales;
SELECT * FROM vehicle;
SELECT * FROM manufacturer;

SELECT m.name, COUNT(s.id) FROM sales s
INNER JOIN vehicle v ON s.id_vehicle = v.id
INNER JOIN manufacturer m ON v.id_manufacturer = m.id
GROUP BY m.name;


--VERSION MAS VENDIDA





--EXTRA MAS PEDIDO



