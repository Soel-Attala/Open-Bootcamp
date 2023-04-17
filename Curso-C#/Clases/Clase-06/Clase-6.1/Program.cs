//CLASE 6: CADENAS Y ARRAYS
//como definimos y podemos interactuar con las cadenas

using System.Security.Cryptography.X509Certificates;
/*
string str;
string str3 = System.String.Empty;
Console.WriteLine(str3.GetType());

char[] letters = { '$', '#', '&' };
Console.WriteLine(letters[0]);
string str4 = "$#&";
Console.WriteLine(str4[0]);

string str5 = "Hola, este es mi mensaje";
Console.WriteLine(str5[0]);


//Concatenacion:
string msg1 = "Buenos días";
string msg2 = "estoy programando en C#";

//imprimir mensaje
Console.WriteLine((msg1 + " ," + msg2));
string msg3 = msg1 + msg2;

//Literales
//Caracteres especiales:

string columns = "|  Column1  | \t|  Column2  | \t|  Column3  |";
string hr = "---------------------------------------------";
string content = "|Contenido1| \n|Contenido1| \n|Contenido1|\t|Contenido2| \n\t\t|Contenido2| \n\t\t|Contenido2| \t|Contenido3| \n\t\t\t\t|Contenido3| \n\t\t\t\t|Contenido3|";
Console.WriteLine(columns);
Console.WriteLine(hr);
Console.Write(content);

//caracteres escapados -> son los que se usan con la barra inclinada \
string head = "\r| Column1 |  | Column2  |  | Column3 |";
string hrr = "--------------------------------------";
string rows = "|Contenido1| |Contenido2| |Contenido3|\r\n|Contenido1| |Contenido2| |Contenido3| \r\n|Contenido1| |Contenido2| |Contenido3|";
Console.WriteLine(head);
Console.WriteLine(hrr);
Console.WriteLine(rows);


string multilinea = "hola, " +
      "este es un mensaje " +
      "de varias lineas";

string multilinea2 = @"este es un string 
de varias lineas
sin concatenar ";

string comillas = @"El se autoproclama ""programador"".";
Console.WriteLine(comillas);
Console.WriteLine(multilinea2);
*/




//Interpolacion 
var persona = (nombre: " Soel", edad: " 27", lenguaje: " C#");
Console.WriteLine($"{persona.nombre} tiene{persona.edad} años y prgorama en{persona.lenguaje}.");

//subcadenas
string cadena = "este es mi mensaje";

//substring / replace
string miCadena2 = cadena.Substring(0, 10);
Console.WriteLine(miCadena2);
string miCadena3 = cadena.Replace("mensaje", "podcast");
Console.WriteLine(miCadena3);

//Limpiar espacio:
string miCadena4 = cadena.Trim();
Console.WriteLine(miCadena4);

int index = cadena.IndexOf('m');
Console.WriteLine(index);

