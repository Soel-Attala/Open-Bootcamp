
/* EJERCICIO 4.3
 * FOR:
 * Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true
*/

Console.WriteLine();
Console.WriteLine("Introduzca los datos para su rectangulo: ");
Console.WriteLine(" ");
Console.WriteLine("Introduzca el ancho: ");
int ancho = int.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("Introduzca el alto: ");
int altura = int.Parse(Console.ReadLine());

Console.WriteLine(" ");
Console.WriteLine("Si desea el rectangulo relleno coloque 1, si lo desea vacio coloque 0");
int relleno = int.Parse(Console.ReadLine());

// Rectángulo vacío
if (relleno != 0)
{
    // Rectángulo relleno
    for (int i = 0; i < altura; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            Console.Write("*"); // Imprimir asterisco en todas las posiciones
        }
        Console.WriteLine(); // Nueva línea
    }

}
else
{
    for (int i = 0; i < altura; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            if (i == 0 || i == altura - 1 || j == 0 || j == ancho - 1)
            {
                Console.Write("*"); // Imprimir borde
            }
            else
            {
                Console.Write(" "); // Imprimir espacio en blanco
            }
        }
        Console.WriteLine(); // Nueva línea
    }
}







/*
int width = 5;
int height = 5;

// Rectángulo relleno
for (int row = 0; row < height; row++)
{
    for (int col = 0; col < width; col++)
    {
        Console.Write("*"); // Imprimir asterisco en todas las posiciones
    }
    Console.WriteLine(); // Nueva línea
}
*/