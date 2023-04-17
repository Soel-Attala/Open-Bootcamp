//constructores y destructores

//CONSTRUCTOR
Puerta door = new Puerta(70, 200, 0000, true);
door.MostrarEstado();

public class Puerta
{
    int ancho;
    int alto;
    int color;
    bool abierta;

    public Puerta(int ancho = 60, int alto = 150, int color = 4, bool abierta = false)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
        this.abierta = abierta;
    }
    public void MostrarEstado()
    {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Altura: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("¿Abierta?: {0}", abierta);
    }
}