//CLASE 3: ESTRUCTURAS DE DATOS

//Los datos del mismo tipo se pueden almacenar en colecciones
//podemos usar metodos de colecciones para realizar operacionesd de forma mas simple 
//y evitar errores.

//ARRAYS
//Tenemos arrays unidimencionales, bidimencionales, y tridimencionales.
// para localizar los datos en cada uno necesitamos 1,2,3 indices respectivamente.
// los indices representan la posicion, partiendo desde el cero

using System.Security.Cryptography.X509Certificates;

Coords myCoords = new Coords(0, 1, 3);
Console.WriteLine(myCoords.X);
Console.WriteLine(myCoords.Y);
Console.WriteLine(myCoords.Z);
Coords myCoords2 = myCoords with { X = 3 };
Console.WriteLine(myCoords2);

public struct Coords
{
    public Coords(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public double X { get; set; }
    public double Y { get; set; }
    //si dejamos solo get es solo lectura, si agregamos set nos deja agregar escritura
    public double Z { get; set; }


    public override string ToString() => $"({X}, {Y}, {Z})";

}

/*
arriba haremos un objeto con esta estructura,
lo hacemos arriba para que no tire error 

en la consola podremos ver los valores de x e y asignados mas arriba.

procedemos a crear la letra z y hacerlo tridimencional.


podemos crear un objeto de tipo referencia, cada objeto tiene un tipo definido.
podemos crear objetos de lectura, usando readOnly, ejemplo public readonly struct Coords
el read only basicamente deja solo leer por lo que solo se pueden asignar datos al crearlo,
despues no puede modificarse.
*/


