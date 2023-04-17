//Strings nulos y vacios
/*
string str = "hello";
string nullString = null;
string emptyString = string.Empty;

string tempStr = str + emptyString;
Console.WriteLine(tempStr);

bool b = (emptyString == nullString); //Camel case -> mniVariable, miArray
Console.WriteLine(b);

*/
//String builder
StringBuilder strBuilder = new StringBuilder("Hola, mundo");
Console.WriteLine(strBuilder[0]); //H
Console.WriteLine(strBuilder); //Hola, mundo


//Arrays
int[] arr = new int[2]; // 1,2
string[] names = new string[2];
names[0] = "Soel";
names[1] = "Luciano";

foreach (string element in names)
{
    Console.WriteLine(element);

}

for (int j = 0; j < names.Length; j++)
{
    Console.Error.WriteLine(names[j]);
}

int[] numbers = { 1, 2, 3, 4, 5 };
Array.Sort(numbers); //ordenamos array de numeros
foreach (int element in numbers)
{
    Console.Error.WriteLine(element);
}

//array 2x2
int[,] miArray2D = new int[2, 2];
miArray2D[0, 0] = 1;
miArray2D[0, 1] = 2;
miArray2D[1, 0] = 3;
miArray2D[1, 1] = 4;


for (int k = 0; k < 2; k++)
{
    for (int l = 0; l < 2; l++)
    {
        Console.WriteLine(miArray2D[k, l] + " ");
    }
    Console.WriteLine("");
}
Console.WriteLine(miArray2D.Length);
