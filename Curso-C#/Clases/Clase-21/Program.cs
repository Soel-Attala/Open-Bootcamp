//Class 20 - Sort and complexity
//algorithms: a series of orderly steps to solve a problem
//Sort: sort a set of elements in a list or an array, etc.
//Complexity: complexity determines whether something is more or less difficult, fast, slow, etc.
//is defined in: time and space
//complexity is defined in time, in the number of times an operation must be repeated to complete our algorithm.
//space complexity is the memory we need for the program to run correctly.

using System.Diagnostics;

int[] array;
Console.WriteLine("Introduce the number of elements: ");
var N = Convert.ToInt32(Console.ReadLine());
array = new int[N];
for (int i = 0; i < N; i++)
{
    array[i] = 1;
}
Stopwatch sw = Stopwatch.StartNew();
for (int j = 0; j < N; j++)
{
    for (int k = N - 1; k > 0; k--)
    {
        array[k] = j + k;
    }
}

sw.Stop();
Console.WriteLine($"For {N} elements, the time of the process is: {sw.Elapsed}");

/*
 *  N           Complexity N^2
 *1000          00:00:00.0007753
 *10.000        00:00:00.0717248
 *100.000       00:00:07.1182241
 */

