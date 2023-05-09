using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//             -------------------- SINGLETON --------------------------  



Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton is working");
}
else
{
    Console.WriteLine("Singleton is failing");
}

public sealed class Singleton //sealed sealed does not allow us to make another instance of this class.
{
    static Singleton() { }
    private static Singleton _instance;
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }

    public static void NewMethod()
    {
        Console.WriteLine("Hello from my new method");
    }
}


//              -----------------  --------------------

