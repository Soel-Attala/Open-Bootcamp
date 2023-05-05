/*  INDEXERS:
 *  Is a resource that allows us to access the data structure of a matrix.
 * 
 *  Indexers Declaration:
 *  
 */

Console.WriteLine("Week days example: ");
WeekDays weekDays = new WeekDays();
Console.WriteLine(weekDays["Monday"]);

Console.WriteLine("Temperature array example: ");
var diallyTemperature = new Temperature();
diallyTemperature[3] = 11.5f;
diallyTemperature[9] = 13.3f;

// now we gonna see the data:
for (int i = 0; i < diallyTemperature.len; i++)
{
    Console.WriteLine($"Item: {diallyTemperature[i]}");
}
public class Temperature
{
    float[] temp = new float[10]
    {
        10f, 8f, 14f, 9f, 12f,
        10f, 11f, 14f, 9f, 12f
    };
    public int len => temp.Length;

    //Indexer
    public float this[int index]
    {
        get => temp[index];
        set => temp[index] = value;
    }
}

class WeekDays
{
    public string[] days =
    {
        "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday"
    };
    public int this[string days] => FindDayIndex(days);

    private int FindDayIndex(string day)
    {
        for (int j = 0; j < days.Length; j++)
        {
            if (days[j] == day)
            {
                Console.WriteLine($"The day is: {days[j]}\n");
            }

        }
        return 0;
    }
}