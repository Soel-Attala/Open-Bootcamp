// CLASE 16 - MANEJO DE ARCHIVOS - FILE HANDLING
using System.IO;
string text;
//Read a file in a project folder
try
{
    StreamReader sr = new StreamReader("file.txt");
    var line = sr.ReadLine();
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }

    sr.Close();
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error has occurred: " + ex.Message);

}
finally
{
    Console.WriteLine("End of program");
}


//Create a text file
try
{
    StreamWriter sw = new StreamWriter("myNewFile.txt");
    sw.WriteLine("Hello, im a new text file");
    sw.WriteLine("this is my second line my name is myNewFile.txt");
    sw.Close();
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error has occurred: " + ex.Message);
}



/*
 * Files operation:
 * 1. Create files.
 * 2. Read files --> without modify the content of the file.
 * 3. Write the file --> this modify the content
 * 4. Append --> write adding new content in the end of the file.
 */


//Create a text file with append
try
{
    StreamWriter sw = new StreamWriter("myNewFile.txt", true); //we add true to do an append operation
    sw.WriteLine("Im adding a new line");
    sw.WriteLine("this is an append operation");
    sw.Close();
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error has occurred: " + ex.Message);
}
try
{
    StreamReader sr = new StreamReader("myNewFile.txt");
    var line2 = sr.ReadLine();
    while (line2 != null)
    {
        Console.WriteLine(line2);
        line2 = sr.ReadLine();
    }

    sr.Close();
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error has occurred: " + ex.Message);

}
finally
{
    Console.WriteLine("End of program");
}

