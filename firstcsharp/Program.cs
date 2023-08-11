using firstcsharp.Topics;

public class Program
{

    private static void Main(string[] args) //method or behaviour or logic
    {
        var Equal = Car<string>.Equalvalue("string", "result");
        var result = Car<int>.Equalvalue(54, 634);

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