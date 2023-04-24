//Programacion asincronica
/* Async and Await
 * Multithreading
 * esto nos permite hacer varias tareas en paralelo
 * Gestion de tareas -> tasks
 * */

//Ejemplo:
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

//PROGRAMACION ASINCRONA

/*
 * 
Stopwatch Stopwatch = new Stopwatch();
Stopwatch.Start();
int num = 0;
for (int i = 0; i <= 10000000; i++)
{
    num += 1;
}
Stopwatch.Stop();

Console.WriteLine(Stopwatch.Elapsed.Milliseconds);
//nos mide el tiempo que tarda en milisegundos
Console.WriteLine(Stopwatch.Elapsed);
//nos muestra el tiempo detallado
*/

Stopwatch sw = Stopwatch.StartNew();


//Task 1:
var task1 = new Task(() =>
{
    Stopwatch Stopwatch = new Stopwatch();
    Stopwatch.Start();
    Thread.Sleep(1000);
    Stopwatch.Stop();
    Console.WriteLine($"Task 1: {Stopwatch.Elapsed}");
});

//Task2
var task2 = new Task(() =>
{
    Stopwatch Stopwatch = new Stopwatch();
    Stopwatch.Start();
    Thread.Sleep(1000);
    Stopwatch.Stop();
    Console.WriteLine($"Task 2: {Stopwatch.Elapsed}");
});

//Task3
var task3 = new Task(() =>
{
    Stopwatch Stopwatch = new Stopwatch();
    Stopwatch.Start();
    Thread.Sleep(1000);
    Stopwatch.Stop();
    Console.WriteLine($"Task 3: {Stopwatch.Elapsed}");
});

//Task 4 (optimizamos el tiempo)

var task4 = new Task(async () =>
{
    var str = await RandomAsync();
    Console.WriteLine(str);
});

task1.Start();
//code
task2.Start();
//code
task3.Start();
task4.Start();

await task1;
await task2;
await task3;
await task4;



sw.Stop();
Console.WriteLine($"Vemos el tiempo que demora todo el programa: {sw.Elapsed}");
//lo ponemos para ver los milisegundos

static async Task<string> RandomAsync()
{
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    Thread.Sleep(1000);
    sw.Stop();
    var str = $"{num.ToString()} calculado en: {sw.Elapsed}";

    return str;
}

/*agregando esto al task 4 logramos optimizar en 1 segundo el tiempo de ejecucion
esto es por que C# nos permite hacer multi task en paralelo optimizando el tiempo
se denominan tareas asincronas por que dependen de otros recursos que pueden tardar en
ejecutarse.*/




