//EJERCICIO 4.2: 
/* DO WHILE:
Escribe un programa que realice estos pasos:

Reciba al menos un número por consola

Determine si el número es positivo o negativo

Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
Tienes completa libertad para elegir el formato de la salida.
*/

int x;
int positivos = 0;
int negativos = 0;
int ceros = 0;
int total = 0;

do
{
    Console.WriteLine("Ingrese un numero: ");
    x = int.Parse(Console.ReadLine());
    if (x > 0) { positivos = positivos + 1; }
    if (x < 0) { negativos = negativos + 1; }
    if (x == 0) { ceros = ceros + 1; }
    total = positivos + negativos + ceros;

} while (total != 20);
Console.WriteLine("La cantidad total de numeros ingresados es: " + total);
Console.WriteLine("La cantidad total de numeros negativos es: " + negativos);
Console.WriteLine("La cantidad total de numeros positivos es: " + positivos);
Console.WriteLine("La cantidad de ceros ingresados es: " + ceros);