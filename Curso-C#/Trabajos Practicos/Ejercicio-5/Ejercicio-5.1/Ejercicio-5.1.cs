//EJERCICIO 5.1:
/*Pida datos a un cliente: Nombre, email, cupón

Determine si un cliente tiene un cupon descuento

Muestre un precio rebajado en función del descuento

Muestre el precio de un producto sin descuento si no hay cupón

Nota: puedes poner un precio fijo de un producto o uno variable.
*/

int precio = 1000;
float descuento;
float total;


Console.WriteLine("A continuacion le pediremos una serie de datos: ");
Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese su mail: ");
string mail = Console.ReadLine();
Console.WriteLine("Ingrese su numero de cupon siendo este 1, 2, 3, o cero en caso de no tener uno: ");
int cupon = int.Parse(Console.ReadLine());
if (cupon == 1)
{
    descuento = 0.3f;
    total = precio - (precio * descuento);
    Console.WriteLine("El precio final del producto es: " + total);
}
else
{
    if (cupon == 2)
    {
        descuento = 0.35f;
        total = precio - (precio * descuento);
        Console.WriteLine("El precio final del producto es: " + total);
    }
    else
    {
        if (cupon == 3)
        {
            descuento = 0.5f;
            total = precio - (precio * descuento);
            Console.WriteLine("El precio final del producto es: " + total);
        }
        else
        {
            Console.WriteLine("El precio del producto es: " + precio);
        }
    }
}
