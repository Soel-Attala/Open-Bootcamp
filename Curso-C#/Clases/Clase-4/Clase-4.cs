//CLASE 4: BUCLES
//BUCLE WHILE: significa mientras
using System.Reflection.Metadata;

int i = 0;
Console.WriteLine("WHILE");
while (i < 10)
{
    Console.Write(i + " ");
    i++;// i = i+1;
}

Console.WriteLine(" ");
//Bucle For: repite una operacion mientras se cumpla una condicion un numero de veces.
Console.WriteLine("FOR:");

for (int j = 1; j <= 10; j++)
{
    Console.Write(j + " ");
}

Console.WriteLine(" ");

//Bucle do While: 
//la diferencia entre el do while y el while es que el do while se ejecuta al menos una ves
//es decir, el while no se ejecuta si la condicion es falsa, ahora, el do while, ejecuta
//y luego aplica el bucle, por lo que si es falso ya se ejecuto una vez.
int k = 11;
Console.WriteLine("DO WHILE: ");
do
{
    Console.Write(k + " ");

} while (k < 10);

//NO CUMPLE LA CONDICION, SIN EMBARGO SE EJECUTA UNA VEZ
Console.WriteLine(" ");
Console.WriteLine("FOREACH ");
//FOREACH
var list = new List<string> { "Soel ", "Juan ", "Mario ", "Luciano " };
foreach (var element in list)
{
    Console.Write(element);
}
//si agregamos un elemento sigue funcionando, en cambio en el for, debemos definir
//el numero de elementos al comienzo por lo que no recorreria todo.




//Ejemplos:
Console.WriteLine();
Console.WriteLine("sumar los 100 primeros enteros:");
//sumar los 100 primeros enteros:
int n = 0;
int suma = 0;
for (n = 0; n <= 100; n++)
{
    suma += n;
}
Console.WriteLine(suma);


//Expandimos el codigo para que el usuario indique hasta donde sumar:
int f = 0;
int resultado = 0;
int limit = 0;
Console.WriteLine("Introduce el limite de la suma");
limit = Convert.ToInt32(Console.ReadLine());
for (f = 0; f <= 100; f++)
{
    resultado += f;
}
Console.WriteLine($"Resultado: {resultado} ");

//Escribir todos los elementos de un array

int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
Console.WriteLine("Contamos los elementos de un array usando un for:");
for (n = 0; n < arr.Length; n++)
{
    Console.Write(arr[n] + " ");
}
Console.WriteLine(" ");
Console.WriteLine("foreach");
foreach (var item in arr)
{
    Console.Write(item + " ");

}
