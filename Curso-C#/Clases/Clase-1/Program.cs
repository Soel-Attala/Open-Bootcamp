Console.WriteLine("Hello, World!");

Console.WriteLine("The clock shows 20:00hs");

// para entrar y salir de carpetas a traves de la consola usamos:
// Entrar: cd + nombre carpeta
// Salir cd . .

Console.WriteLine("Please tell us your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);

Console.WriteLine();
Console.WriteLine("Insert your age please: ");
string age = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Where are you from: ");
string city = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Please verify your data:");
Console.WriteLine("Name: " + name + " " + "Age: " + age + " " + "City: " + city);
Console.WriteLine("is this correct?");
Console.ReadLine();
Console.WriteLine("Data were successfully loaded");


Console.WriteLine("Pleas insert the time:");
string time = Console.ReadLine();
Console.WriteLine("The clock will set in: " + time);