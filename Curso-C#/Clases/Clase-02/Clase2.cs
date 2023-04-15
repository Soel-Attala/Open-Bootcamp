/*

CLASE NUMERO 2 - TIPOS DE DATOS

int i = 0
long l = 1;
float f =1.52233f; //en el float debemos poner la f al final
double d = 1.52233;
decimal dec = 1.52233m; //en el decimal debemos poner la m al final
string s = "Hola";
char c = 'a'; //almacena un caracter y se usa comilla simple
bool b = true; //boolean nos devuelve true o false

Console.write(" int: "+i);
Console.WriteLine(" long: "+l);
Console.write(" float: "+f);
Console.WriteLine(" double: "+d);
Console.write(" decimal: "+dec);
Console.WriteLine(" string: "+s);
*/

int age = Console.ReadLine(); //lee el valor que ingresa el usuario, y recibe un string, por eso no nos toma el itn
//podemos usar la conversion de tipo de datos para convertir el string a int.

//de momento lo usaremos como string para que no nos de error
string age = Console.ReadLine();
Console.WriteLine("Introduce tu edad: "+age);

//Conversion de tipos de datos:
//Tenemos una automatica y una manual, la conversion consiste en convertir un tipo de dato a otro.

//Conversion automatica:
//es implicita, no necesitamos hacer nada, el compilador lo hace por nosotros.
// se hace de datos menores a mayores en tamaño, por ejemplo de int a long, de int a float, etc.
int i = 5;
float miFloat = i;
Console.WriteLine("Mi float es: "+miFloat);
//como vemos se pasa de int a float de forma automatica
//ambos toman el valor de 5, es decir, le asigna a miFloat el valor de i.
float f = 5.5f;
double = miDouble = f;
Console.WriteLine("Mi double es: "+miDouble);
//como vemos se pasa de float a double de forma automatica
//ambos toman el valor de 5.5, es decir, le asigna a miDouble el valor de f.



//Conversion manual:
//es explicita, debemos hacerlo nosotros, el compilador no lo hace por nosotros.
//se hace de datos mayores a menores en tamaño, por ejemplo de long a int, de float a int, etc.

string str = "5";
int miInt = int.Parse(str);
int miInt2 = Convert.ToInt32(str);
Console.WriteLine("Mi int es: "+miInt);
Console.WriteLine("Mi int es: "+miInt2);

miInt2 = miInt2 + 1;

Console.WriteLine("Mi int ahora es: "+miInt2);


//si queremos convertir un string a un tipo de dato que sea int, debemos usar el metodo ToInt32
//estos dos metodos se pueden usar para convertir tipos de datos a int, 
//pero no se pueden usar para convertir tipos de datos a otros tipos de datos que no sean int.

//si queremos convertir un string a un tipo de dato que no sea int, debemos usar el metodo Parse
//cada tipo tiene distintos metodos para convertirlo a otro tipo de dato, por ejemplo:
//int.Parse, float.Parse, double.Parse, decimal.Parse, etc.



//TIPOS DE VARIABLES Y CONSTANTES
const int miConstante = 5; //constante, no se puede modificar
//es decir que miConstante siempre va a valer 5, no se puede modificar.
//si queremos modificarla, nos va a dar error.
const float pi = 3.1416f;
//en estos casos conviene usar const por que pi siempre va a valer 3.1416f
//con nuestro nombre y datos puntuales podemos usar const ya que no cambian.


//Nullables
//son variables que pueden ser nulas, es decir, que pueden tener un valor nulo.
//por ejemplo, si tenemos una variable int, no puede ser nula, es decir, no puede tener un valor nulo.
//si queremos que una variable int pueda tener un valor nulo, debemos usar el tipo de dato nullable.
//para usar el tipo de dato nullable, debemos ponerle un signo de interrogacion al final del tipo de dato.
//por ejemplo, si queremos que una variable int sea nullable, debemos ponerle un signo de interrogacion al final.
int? miNullable = null;
Console.WriteLine("Mi nullable es: "+miNullable);
//como vemos, al ponerle el signo de interrogacion, la variable ya no es int, si no int?
//es decir, ya no es un int, si no un int nullable.
//null no es lo mismo que vacio, null es un valor nulo, es decir, no tiene valor.
//en las bases de datos se usa mucho el null, ya que si no tenemos un valor, se le asigna null.
//cuando una persona llena un formulario y deja campos en blanco, esos campos se le asignan null.
//si queremos saber si una variable es null, debemos usar el metodo HasValue, 
//eso nos devolvera true o false dependiendo si la variable es null o no.
string? miNullable2 = null;



//variables
//son variables que pueden ser modificadas, es decir, que pueden cambiar de valor.
//por ejemplo, si tenemos una variable int, podemos modificarla, es decir, podemos cambiarle el valor.
//si queremos que una variable int no pueda ser modificada, debemos usar el tipo de dato const.





