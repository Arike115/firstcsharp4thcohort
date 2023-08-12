using firstcsharp.Topics;

public delegate void Print(int value);
public class Program
{
    //Anonymous method
    //anonymous type
    //Nullable types
    //preprocessor directives
    //xml documentation
    //iteration
    //Attributes
    private static void Main(string[] args) //method or behaviour or logic or function
    {
        //Anonymous method
        int i = 10;

        Print print = delegate (int value)
        {
            value += i;
            Console.WriteLine("Anonymous value is: {0}", value);
        };

        print(100);


        //Anonymouse Type
        var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
        Console.WriteLine(student.Id); //output: 1
        Console.WriteLine(student.FirstName); //output: James
        Console.WriteLine(student.LastName); // output: Bond

        //Nullable Type
        int? result = null;
        bool? check = null;
        decimal? resultDecimal = null;

        //Iteration
        //External iteration
        List<string> resultList = new List<string> {"result","india", "nigeria", "Denmark" };
        for(int y = 0; y < resultList.Count; y++)
        {
            Console.WriteLine(y);
        }
        foreach(var resultS in resultList)
        {
            Console.WriteLine(resultS);
        }
        Console.WriteLine("internal -----------");
        //internal iteration
        resultList.ForEach(x => Console.WriteLine(x));
       
    }

    public static void Calculate()
    {
        
    }

   

}