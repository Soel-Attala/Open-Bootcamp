/*CLASS 22 - DELEGATES, IDEXERS AND ITERATORS
 * Delegates:
 * Is a reference to a method := variable ---> method.
 * here we are declaring a variable that points to another method.
 * <access modificator> DELEGATE <return type> <name>(<parameters>[]);
 *      public          DELEGATE      void      PrintDelegate(String path);
 *      
 *      Default delegates available:
 *      Action<T> ---> always return void (0 to 16 parameters) (generyc type)
 *                     Action<String> --> recive string and return void
 *      anonymously --> 
 *      Func<in T, out TResult
 *      Predicate<T>a
 */

using System.Runtime.CompilerServices;

Console.WriteLine("Custom Delegate:");
Console.WriteLine("Write a message for the delegate. ");
string message = Console.ReadLine();
PrintDelegateClass obj = new PrintDelegateClass();
obj.DelegateExample(message);

//-----------------------------------------------------------
Console.WriteLine("Action Delegate:");
Console.WriteLine("Write a message for the action delegate. ");
string msg = Console.ReadLine();
PrintWithAction obj2 = new PrintWithAction();
obj2.ActionExample(msg);

//-----------------------------------------------------------
Console.WriteLine("Anonymous Delegate:");
Console.WriteLine("Write a message for the anonymous delegate. ");
string msg2 = Console.ReadLine();
PrintWithAnonymously obj3 = new PrintWithAnonymously();
obj3.AnonymousExample(msg2);

//-----------------------------------------------------------
Console.WriteLine("Predicate Delegate:");
Console.WriteLine("Set your age: ");
string input = Console.ReadLine();
int.TryParse(input, out int num);
Predicate<int> isLegalAge = e => e >= 18;
bool legalAge = isLegalAge(num);//true
Console.WriteLine($"Are you leagal age?: {legalAge}");


//Definitions
public delegate void PrintDelegate(String value);

public class PrintDelegateClass
{
    private void Print(String value)
    {
        Console.WriteLine($"I've recived this value: {value} \n");
    }

    public void DelegateExample(string str)
    {
        PrintDelegate printDelegate = new PrintDelegate(Print);
        //Call the object
        printDelegate(str);
    }
}


public class PrintWithAction
{
    private void Print(string value)
    {
        Console.WriteLine($"Action delegate: {value}\n");
    }
    public void ActionExample(string msg)
    {
        Action<string> printWithAction = Print;
        printWithAction(msg);
    }
}

public class PrintWithAnonymously
{
    public void AnonymousExample(string msg2)
    {
        Action<string> printWithAction = delegate (string msg)
        {
            Console.WriteLine($"Anonymously Delegate: {msg}\n");
        };
        printWithAction(msg2);
    }

}
