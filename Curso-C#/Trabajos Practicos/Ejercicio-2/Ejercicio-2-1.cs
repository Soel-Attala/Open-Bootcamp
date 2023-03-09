//Ejercicio-1:
//Escribe un programa que reciba datos de una persona y genera un mensaje,
//usa una variable para cada dato y otra para el mensaje.
//Ej: nombre, apellido, edad, sabe programar, etc.


Console.WriteLine("Tell us your name:");
string name = Console.ReadLine();
Console.WriteLine("Please set your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Please set your city:");
string city = Console.ReadLine();
Console.WriteLine("Please set your phone: ");
int phone = int.Parse(Console.ReadLine());

string Mesage = "Your data was successfully uploaded: " + "Name: " + name + "  Age: " + age + "  City: " + city + "  Phone: " + phone;

Console.WriteLine(Mesage);
