/* INTERFACES
 * una interfaz es un tipo particular de clase, en la cual no estamos definiendo todo como lo haciamos anteriormente.
 * sino que, es una especie de contrato, es decir cualquier clase de estructura puede ejecutar dicho contrato.
 * es decir, siempre y cuando se cumplan las condiciones de dicho contrato, el mismo puede ser ejecutado.
 * lo bueno es que nuestra estructura debe de ir cumpliendo condiciones.
 */


public interface IVehicle
{
    void Start();
    public string marca { get; set; }

}
class Vehicle2 : IVehicle
{
    public string marca { get; set; }
    void IVehicle.Start()
    {
        Console.WriteLine("Arrancar");
    }
  
}


