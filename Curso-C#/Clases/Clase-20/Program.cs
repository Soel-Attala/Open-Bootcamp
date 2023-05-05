//Debugging - Debug (Depuracion)

Console.WriteLine("Write your message");
var msg = Console.ReadLine();
Console.WriteLine($"I've recived this message: {msg}");
int resultado = 0;
for (int i = 0; i < 10; i++)
{
    resultado = (i * i) + 1;
    Console.WriteLine(resultado);
}
Console.ReadLine();