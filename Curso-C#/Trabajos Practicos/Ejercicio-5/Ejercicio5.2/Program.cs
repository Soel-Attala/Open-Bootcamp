//EJERCICIO 5.2:
/*
Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++.
Presenta la lista en consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. 
Presenta el resultado en consola.
Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.
*/


var list = new List<string> { "C#", "Java", "C++", "Python", "Ruby", "PHP" };
foreach (var element in list)
{
    Console.WriteLine(element);
}

Console.WriteLine("Seleccione el lenguaje deseado: ");

int seleccion = int.Parse(Console.ReadLine()) - 1;

switch (seleccion)
{
    case 0:
        Console.WriteLine($"Usted ha seleccionado: {list[seleccion]}");
        break;

    case 1:
        Console.WriteLine($"Usted ha seleccionado: {list[seleccion]}");
        break;

    case 2:
        Console.WriteLine($"Usted ha seleccionado: {list[seleccion]}");
        break;

    case 3:
        Console.WriteLine($"Usted ha seleccionado: {list[seleccion]}");
        break;

    case 4:
        Console.WriteLine($"Usted ha seleccionado: {list[seleccion]}");
        break;

    case 5:
        Console.WriteLine($"Usted ha seleccionado: {list[seleccion]}");
        break;

    default:
        Console.WriteLine("Hola Mundo de C#");
        break;
}


