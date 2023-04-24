//USOS DE INTERFACES
/*Las interfaces basicamente hacen que las clases que deriven de ellas
 * o apliquen dicha interfaz, tengan que cumplir ciertas caracteristicas que 
 * no pueden ser obviadas.
 */

var person = new Person();

public class Person : IPerson
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public DateTime BirthDay { get; set; }

    public Person()
    {
        AskData();
        PersonData();
    }

    public void AskData()
    {
        Console.WriteLine("Whats your name?");
        var name = Console.ReadLine();
        if (name == null)
        {
            Console.WriteLine("Name cannot be empty, please enter your name");
        }
        else
        {
            Name = name;
        }

        Console.WriteLine(" ");

        Console.WriteLine("Whats your email?");
        var email = Console.ReadLine();
        if (email == null)
        {
            Console.WriteLine("Name cannot be empty, please enter your email");
        }
        else
        {
            Email = email;
        }

        Console.WriteLine(" ");

        Console.WriteLine("Whats your age?");
        var age = Convert.ToInt32(Console.ReadLine());
        if (age == 0)
        {
            Console.WriteLine("Name cannot be empty, please set your age");
        }
        else
        {
            Age = age;
        }

        Console.WriteLine(" ");

        Console.WriteLine("Whats your birthdate?");
        var date = Console.ReadLine();
        var birthday = DateTime.Parse(date);
        if (birthday == null)
        {
            Console.WriteLine("Name cannot be empty, please enter your birthda");
        }
        else
        {
            BirthDay = birthday;
        }
    }



    public void PersonData()
    {
        Console.WriteLine("Data successfully load: ");
        Console.WriteLine($"Name: {Name},Email: {Email}, Birthday: {BirthDay} Age: {Age}");
    }
}

public interface IPerson
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public DateTime BirthDay { get; set; }

    public void AskData();
    public void PersonData();
}


//Enums
//son valores definidos por un tipo de constantes.
//seria una lista, que no varia.
//por ejemplo una lista con los meses, dias de semana, estaciones del año.
//son datos que no varían.




