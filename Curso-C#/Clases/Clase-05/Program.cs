/* IF - ELSE:
 * EL IF BASICAMENTE ES UNA ESTRUCTURA CONDICIONAL.
 * DONDE ESTABLECEMOS, SI X CONDICION SE CUMPLE, HAZ ESTO, SINO, HAZ AQUELLO (O NO HAGAS NADA).
 * */


using System.ComponentModel;

string hoy = "miercoles";
/*
if (hoy == "lunes")
{
    Console.WriteLine("Hoy es lunes");

}
else
{
    Console.WriteLine("no es lunes");

}
*/

//Switch 
switch (hoy)
{
    case "lunes":
        Console.WriteLine("es lunes");
        break;

    case "martes":
        Console.WriteLine("es martes");
        break;
    default:
        Console.WriteLine("el dia no esta cargado");
        break;
}

