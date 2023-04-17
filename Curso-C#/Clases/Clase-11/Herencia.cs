//Herencia y Polimorfismo:
/* con la herencia podemos tener una clase general, supongamos una clase coche, con todas sus caracteristicas
 * por ejemplo, combustible, puertas, ruedas, etc.
 * y podemos tener sub clases para especificar otras cosas como por ejemplo, modelo, si es deportivo, o no.
 */


using System.ComponentModel;

Vehicle vehicle = new Vehicle();
vehicle.Start();
Car car = new Car();
car.Start();
car.Stop();
car.Start("Soel");

class Vehicle
{
    public float Fuel { get; set; }
    public int aforo { get; set; }
    public void Start()
    {
        Console.WriteLine("Este vehiculo ha arrancado");
    }

}



//con los dos puntos indicamos que car hereda a vehicle
class Car : Vehicle
{
    public int wheels { get; set; }

    public void Start()
    {
        Console.WriteLine("Este auto arranco");
    }

    //sobrecarga
    public void Start(string str)
    {
        Console.WriteLine($"{str} ha arrancado este coche a las {DateTime.Now}.");
    }

    public void Stop()
    {
        Console.WriteLine("El coche se ha detenido");
    }

}

//POLIMORFISMO
/* definimos distintas salidas para metodos en funcion de los parametros u objetos
 * podemos notarlo cuando usamos el metodo start de 3 formas diferentes.
 */


/*SOBRECARGA DE OPERADORES
 * en el string lo hacemos con concatenacion y en los numeros con la suma.
 * supongamos que definimos fracciones 
 * 1/2 +3/4 = a/b
 * clase fraction
 * public static Fraction operator + 
 * de esta forma definimos un metodo para realizar la sobrecarga
 */




