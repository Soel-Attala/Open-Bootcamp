int resultado = CalcularCuadrado(2);
int CalcularCuadrado(int n)
{
    Console.WriteLine(n * n);
    return n * n;
}

void CalculoDeNotas(int a)
{
    if (a < 5)
    {
        Console.WriteLine("has reprobado");
    }
    else if (a > 5)
    {
        Console.WriteLine("has aprobado");
    }
}

CalcularCuadrado(3);
CalculoDeNotas(4);
CalculoDeNotas(7);


//Funciones anonimas
//son funciones sin nombre o funciones lambda
//(imput-parametros) => expresion

int[] numbers = { 1, 2, 3, 4, 5 };
var squareNumbers = numbers.Select(x => x * x * x);
Console.WriteLine(string.Join(", ", squareNumbers));
//aqui la funcion lambda es el x=>x*x*x



//metodos
var moto = new moto();
moto.Arrancar();
moto.ArrancarMoto();

//Extension
Clase_7._1.ExtensionMotos.Acelerar();

//retornos de metodos
int gasolina = moto.CantidadGasolina();
Console.WriteLine($"Nos quedan unos {gasolina} litros de combustible");

//sobrecargas
dynamic nivelTanque = moto.CargarCombustible(15.5d); // 10.5f o 10, dynamic reconoce cualquiera de los 3 metodos
Console.WriteLine($"Ahora que cargamos combustible tenemos {nivelTanque} litros de combustible");


//definimos metodos
class moto
{
    public static void Arrancar()//el metodo static es un metodo de clase
    {
        Console.WriteLine("La moto arranca");
    }

    public void ArrancarMoto() //es un metodo para esa moto especifica, es decir es un metodo de los objetos
    {
        Console.WriteLine("Arranco esta moto");
    }
    public int CantidadGasolina()
    {
        int gasolina = 20;
        return gasolina;
    }

    public int CargarCombustible(int litros)
    {
        int nivelTanque = 20 + litros;
        return nivelTanque;
    }

    public float CargarCombustible(float litros)
    {
        float nivelTanque = 20 + litros;
        return nivelTanque;
    }

    public double CargarCombustible(double litros)
    {
        double nivelTanque = 20 + litros;
        return nivelTanque;
    }

}

//sobrecarga de metodos: es cuando hay una definicion para varios tipos de parametros.
//si tenemos 3 metodos iguales pero de distinto tipo, por ejemplo
//un float, un int y un double: podemos usar la key dynamic para llamarlos sin importar cual sea


