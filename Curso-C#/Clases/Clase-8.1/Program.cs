//METODOS II

float f = 3.141516f;
EscribirNumeroReal(f);


void EscribirNumeroReal(float n)
{
    Console.WriteLine(n.ToString("#.##")); //tener cuidado con el redondeo.
}

void SumaDeReales(float a, float b)
{
    float resultado = a + b;
    Console.WriteLine(resultado.ToString("#.#"));
}


//Recursividad:
/*Factorial -> !
 * 1! = 1
 * 2! = 2 * 1 = 2
 * 3! = 3 * 2 * 1 = 6
 */

Console.WriteLine(CalcularFactorial(3));
long CalcularFactorial(long n)
{
    if (n == 1)
    {
        return 1;
    }
    return n * CalcularFactorial(n - 1);
}

Puerta door = new Puerta();
door.Abrir();
door.CambiarAlto(200);
door.MostrarEstado();
door.Cerrar();
door.MostrarEstado();
door.PintarPuerta("Marron");


public class Puerta
{
    int ancho;
    int altura;
    string color;
    string material = "madera";
    bool abierta;

    public void Abrir()
    {
        abierta = true;
    }

    public void Cerrar()
    {
        abierta = false;
    }

    public void MostrarEstado()
    {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Altura: {0}", altura);
        Console.WriteLine("Material: {0}", material);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("¿Abierta?: {0}", abierta);
    }

    public void CambiarAlto(int n)
    {
        altura = n;
    }
    public void PintarPuerta(string color)
    {
        this.color = color;
    }

}
