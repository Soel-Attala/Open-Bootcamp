//MULTITHREADING
/* metodologia con multiples hilos de trabajo.
 * Main thread --> pedimos datos a la base de dato.
 * Thread 1 -> conexion a la base de datos -> hacemos la query o peticion.
 * thread 2 -> Consultamos la API
 * el hilo principal podra seguir ejecutando tareas y procesos, y la informacion de los
 * hilos secundarios se añadira cuando termine cada unos u proceso
 */


//MULTITHREADING
using System;
using System.Diagnostics;
using System.Threading;


//WITHOUT MULTITHREADING
/*
Stopwatch noThread = Stopwatch.StartNew();

//task 1:
Thread.Sleep(1000); // 1 sec
//task 2:
Thread.Sleep(1000);// 1 sec
//task 3:
Thread.Sleep(1000);//1 sec


noThread.Stop();
Console.WriteLine($"Our program time is: {noThread.Elapsed}");
//efectivamente nuestro programa demoro 3 segundos y 9 milisegundos en ejecutarse.
*/

//MULTITHREADING
//MAIN THREAD


/*
Thread mainThread = Thread.CurrentThread;
mainThread.Name = "Main Thread"; //le damos un nombre
Console.WriteLine($"We are in thread: {mainThread.Name}");
*/


Stopwatch mainStopwatch = Stopwatch.StartNew();
// we gonna create new task to optimize our program
//TASK 1

var task1 = new Task(() =>
{
    Stopwatch firstStopwatch = Stopwatch.StartNew();
    Thread.Sleep(1000);
    firstStopwatch.Stop();
    Console.WriteLine($"The first task time is {firstStopwatch.Elapsed}");
});

var task2 = new Task(() =>
{
    Stopwatch secondStopwatch = Stopwatch.StartNew();
    Thread.Sleep(1000);
    secondStopwatch.Stop();
    Console.WriteLine($"The second task time is {secondStopwatch.Elapsed}");
});

var task3 = new Task(() =>
{
    Stopwatch thirdStopwatch = Stopwatch.StartNew();
    thirdStopwatch.Stop();
    Console.WriteLine($"The third task time is: {thirdStopwatch.Elapsed}");
});

//Starting task
task1.Start();
task2.Start();
task3.Start();

//we receive the tasks

/* We can do it like this:
await task1;
await task2;
await task3;
*/

//Or like this: 
await Task.WhenAll(task1, task2, task3);// in this way we recive the tasks when they are finished.
mainStopwatch.Stop();
Console.WriteLine($"The time of our program is: {mainStopwatch.Elapsed}");


/*
 * we start a new thread
 * we pass reference with Thread.Start -> refThread: metodo definido por nosotros.
 * este metodo lo definimos para poder inicializar los hilos.
  
 
Stopwatch secondStopwatch = Stopwatch.StartNew();

    ThreadStart refThread = new ThreadStart(threadCreator.ThreadStart);
    Thread secondThread = new Thread(refThread);
    secondThread.Start();
    secondThread.Name = "Second Thread";
    Thread.Sleep(1000);
    secondStopwatch.Stop();
    Console.WriteLine($"The second thread time is {secondStopwatch.Elapsed}");


    Stopwatch thirdStopwatch = Stopwatch.StartNew();
    Thread thirdThread = new Thread(refThread);
    thirdThread.Start();
    thirdStopwatch.Stop();
    Console.WriteLine($"The third thread time is: {thirdStopwatch.Elapsed}");
*/
class threadCreator
{
    public static void ThreadStart()
    {
        Console.WriteLine($"Starting a new thread");
        Console.WriteLine("Starting new tasks");
        Console.WriteLine("Ending all tasks");
    }
}
