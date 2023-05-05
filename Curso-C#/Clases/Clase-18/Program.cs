using System;
using System.Collections;

//Clase 18 - Matrix
//what are the matrixes?
//the matrix arrays of 2 or more dimensions.

/*Matrix
 *         m=((1, 2)),
 *           ((3, 4)) 
 */

//form to declarate 1 dimension array:
int[] array = new int[2];
array[0] = 1;
array[1] = 2;

//other form to deaclare array:
int[] array2 = new int[] { 1, 2, 3, 4, 5 };

//another
int[] array3 = { 1, 2, 3, };

//we change the array value
for (int i = 0; i < array.Length; i++)
{
    array3[i] += 1;
}


Console.Write("Array: ( ");
foreach (int i in array)
{
    Console.Write(i + " ");
}
Console.Write(")/n");


Console.WriteLine("  ");
//2D arrays:
//here we know the array size, but we dont know his elements.
Console.WriteLine("\n--Matrix--");
int[,] arr2D = new int[2, 2];
for (int j = 0; j < 2; j++) //j -> 0,1
{
    for (int k = 0; k < 2; k++)//k ->0,1
    {
        arr2D[j, k] = j + k;
        Console.Write(arr2D[j, k] + " ");
    }
    Console.WriteLine();
}

/*
 * [0,0] ---> arr2D[0,0] = 0
 * [0,1] ---> arr2D[0,1] = 1
 * [1,0] ---> arr2D[1,0] = 1
 * [1,1] ---> arr2D[1,1] = 2
 */

int size = 10;
int[,] array2D = new int[size, size];
Console.WriteLine("\n                             --Matrix:2--              ");
for (int j = 0; j < size; j++) //j -> 0,1
{
    for (int k = 0; k < size; k++)//k ->0,1
    {
        array2D[j, k] = j + k;
        Console.Write(array2D[j, k] + "\t");
    }
    Console.WriteLine();
}

//another way to set a matrix
int[][] matrix4 = new int[3][];
matrix4[0] = new int[4] { 1, 2, 3, 4 };//in row 0 we add 4 columns
matrix4[1] = new int[4] { 3, 4, 5, 6 };//the same for row 1

int[,] matrix2 = { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine($"Rank: {matrix2.Length}"); //here we can see mxm -> 2x3 = 6 (2 rows x 3 columns)
Console.WriteLine($"Rank: {matrix2.Rank}");// here we can see the matrix dimension = 2


