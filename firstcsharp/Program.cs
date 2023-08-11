using firstcsharp.Topics;

public class Program
{

    private static void Main(string[] args) //method or behaviour or logic
    {
        var Equal = Car.Equalvalue<string>("string", "result");
        var result = Car.Equalvalue<int>(54, 634);

        if(Equal)
        {
            Console.WriteLine("Numbers matched");
        }
        else
        {
            Console.WriteLine("Not matched");
        }

    }

}