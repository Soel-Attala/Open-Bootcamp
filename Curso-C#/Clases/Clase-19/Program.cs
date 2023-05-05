//Clase-19 - EVENTS

/*Publisher
Determines when the event is triggered
Event definition
Delegate
*/

/*
 * Subscriber
accepts the event and provides an event handler
method that will be executed when the event occurs.
 */

/*
 * Event
Delegate encapsulated in the editor class.
Delegate -> calls a method when the condition is met.
 */


CalcSubscriptor calculator = new CalcSubscriptor(5, 7);
calculator.SumResult();
calculator.SubstractResult();

public class Editor
{
    public delegate void ExampleEvent();
    public event ExampleEvent exampleEvent;
}

public class EventCalc
{
    public delegate void ExampleDelegate();
    public event ExampleDelegate exampleDelegate;

    public void sum(int a, int b)
    {
        if (exampleDelegate != null)
        {
            exampleDelegate();
            Console.WriteLine($"The sum is: {a + b}");
        }
        else
        {
            Console.WriteLine("You dont have a subscription to this event.");
        }
    }

    public void substract(int a, int b)
    {
        if (exampleDelegate != null)
        {
            exampleDelegate();
            Console.WriteLine($"The substract is: {a - b}");
        }
        else
        {
            Console.WriteLine("You dont have a subscription to this event.");
        }
    }
}

public class CalcSubscriptor
{
    EventCalc editor;
    private readonly int A;
    private readonly int B;
    public void ExampleEventHandler()
    {
        Console.WriteLine("The operation result is printed:");
    }
    public CalcSubscriptor(int a, int b)
    {
        editor = new EventCalc();
        A = a;
        B = b;
        editor.exampleDelegate += ExampleEventHandler; //we can subscribe to an event using += and we can unsubscribe using -=
        //the events can exist inside interfaces
        //to execute an event we need to call the delegate.
    }
    public void SumResult()
    {
        editor.sum(A, B);
    }
    public void SubstractResult()
    {
        editor.substract(A, B);
    }

}