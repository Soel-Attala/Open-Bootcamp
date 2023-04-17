//LINQ 
//1. Nuestro origen de datos
int[] numbers = new int[10] {1,2,3,4,5,6,7,8,9,10};
string[] names = new string[5] { "Ana", "Lucia", "Juan", "Roberto", "Luciano" };

//2. Obtendremos  datos de la consulta
//seleccionar numeros pares:
var pares =
from numero in numbers
where (numero % 2) == 0
select numero;
//creamos la consulta, establecemos la condicion e indicamos que seleccione los numeros que cumplan dicha condicion

//seleccionamos impares

var impares = 
    from numero in numbers
    where (numero % 2) != 0
    select numero;
//
var nums =
from numero in numbers
where (numero > 5 && numero <= 8)
select numero;

//hacemos la consulta para los nombres
var nombres =
    from name in names
    where (name.Length > 3)
    select name;


//3. Ejecutamos la consulta
foreach (var num in pares)
{
    Console.Write(num + " ");
}

Console.WriteLine(" ");

foreach (var numero in impares)
{
    Console.Write(numero + " ");
}

Console.WriteLine(" ");

foreach (var numero in nums)
{
    Console.Write(numero + " ");
}


Console.WriteLine(" ");

foreach (var name in nombres)
{
    Console.Write(name + " ");
}





/*
void EscribirConsulta(String names)
{
    foreach (var name in nombres)
    {
        Console.Write(name + " ");
    }
}
*/


//C#

Console.WriteLine(" ");
//usaremos nuestro programa
//y siempre trabajaremos con C#

//Tipos anonimos:
var coche = new { Marca = "Ford", Año = 2021 };
Console.WriteLine($"Tengo un coche marca {coche.Marca} del año {coche.Año} ");
MostrarDato(" Mondeo");
void MostrarDato(string dato)
{
    var myVar = coche.Marca;
    Console.WriteLine(myVar + dato);
}

