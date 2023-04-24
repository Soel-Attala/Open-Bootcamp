//COLLECTIONS
//Nos sirven para ordenar contenido, datos, y depende de que tarea queremos realizar,
//va a variar que es mejor para cada caso.
//usaremos por ejemplo System.Collections.Gneric
//System.Linq

//string collection

using System.Drawing;
using System.Reflection.Metadata.Ecma335;


/*
var car = new List<string>();
car.Add("Ford");
car.Add("Chevrolet");
car.Add("Honda");
car.Add("Toyota");

var car2 = new List<string> { "Seat", "Volkswagen", "Fiat" };
foreach (var the in car)
{
    Console.WriteLine(the + " ");
}
*/
//creamos la lista
/*
List<Element> elements = CreateList();

//hacemos un query con linq para los elementos de la lista
var query = from the in elements
            where the.AtomicNumber < 20
            select the;

//recorremos la lista
foreach (Element the in query)
{
    Console.WriteLine($"Nombre: {the.Name}, Symbol: {the.Symbol}, Atomic-Number: {the.AtomicNumber}");
}

//agregamos elementos a la lista
static List<Element> CreateList()
{
    return new List<Element> {
        new Element() { Symbol = "K", Name = "Potasio", AtomicNumber = 19 },
        new Element() { Symbol = "Ca", Name = "Calcio", AtomicNumber = 20 },
        new Element() { Symbol = "Ti", Name = "Titanio", AtomicNumber = 22 }
    };
}


public class Element
{
    public string Symbol { get; set; }
    public string Name { get; set; }
    public int AtomicNumber { get; set; }

}
*/



//dentro de las colecciones, podemos encontrar las listas, diccionarios, arrays, etc.
/*Tipos de colecciones:
 * IEnumerable -> Query de LINQ.
 * List -> Almacenan por indice.
 * Dictionary -> Almacenan por key, value.
 */

//-----------------------------------------------------------

/*
CarList();
static void CarList()
{
    var cars = new List<Car>
    {
        { new Car() { Name = "Car1", Color = "Blue", Speed = 150 } },
        { new Car() { Name = "Car2", Color = "Red", Speed = 120 } },
        { new Car() { Name = "Car3", Color = "Black", Speed = 180 } },
        { new Car() { Name = "Car4", Color = "Green", Speed = 140 } },
        { new Car() { Name = "Car5", Color = "White", Speed = 110 } }
    };
    cars.Sort();
    foreach (Car car in cars)
    {
        Console.WriteLine($"{car.Name}, {car.Color}, {car.Speed}");
    }

}


class Car : IComparable<Car>
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; }

    public int CompareTo(Car other)
    {
        int compare;
        compare = String.Compare(this.Name, other.Color, true);
        if (compare == 0)
        {
            compare = this.Speed.CompareTo(other.Speed);
            compare = -compare;
        }
        return compare;
    }

}
*/


//Customize colections

