/*
 * EJERCICIO 3:
 * Crea una estructura de datos para un cliente con estos campos:
 * Nombre completo
 * Teléfono
 * Dirección
 * Email
 * Si es nuevo cliente
 * Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 */

Data data = new Data("Soel Antonio Attala", 306032, "El Moro 315", "soelattala7@gmail.com", "yes");

Data data2 = data with { Name = "Luciano", Phone = 504520, Address = "Los Filtros 775", Email = "luciano123@gmail.com", Newclient = "yes" };
void ShowData()
{
    if (data.Name != null)
    {
        Console.WriteLine("PrimerCliente: " + data);
        Console.WriteLine("Segundo Cliente" + data2);
    }
}

ShowData();

public struct Data
{
    public Data(string name, int phone, string address, string email, string newclient)
    {
        Name = name;
        Phone = phone;
        Address = address;
        Email = email;
        Newclient = newclient;
    }
    public string Name { get; set; }
    public int Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Newclient { get; set; }

    public override string ToString() => $"({Name}, {Phone}, {Address}, {Email}, {Newclient})";


}
